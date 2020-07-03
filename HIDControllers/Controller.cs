// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Threading;
using System.Threading.Tasks;
using DynamicData;
using HIDControllers.Controls;
using HidSharp;
using HidSharp.Reports;
using HidSharp.Reports.Input;

namespace HIDControllers
{
    public class Controller : IAsyncDisposable
    {
        private readonly Dictionary<(Usage, DataItem), Axis> _axes;
        private readonly HidDevice _device;
        private readonly Dictionary<DeviceItem, DeviceItemInputParser?> _items;

        internal readonly byte[] RawReportDescriptor;
        private SourceCache<ControlChange, Control>? _changes = new SourceCache<ControlChange, Control>(c => c.Control);
        private HidStream? _hidStream;
        private HidDeviceInputReceiver? _inputReceiver;
        private byte[]? _inputReportBuffer;

        public Controller(Controllers controllers, HidDevice device, byte[] rawReportDescriptor,
            ReportDescriptor reportDescriptor,
            IReadOnlyList<(DeviceItem item, DeviceType type, IReadOnlyList<(Usage usage, DataItem dataItem)> usages)>
                items)
        {
            // Try to open HID Stream before doing any work, so that we can fail early if access is denied.
            _device = device;
            if (!_device.TryOpen(out var stream))
            {
                throw new InvalidOperationException(string.Format(Resources.HidStreamOpenFailure, Name));
            }

            stream.ReadTimeout = Timeout.Infinite;
            _hidStream = stream;

            Controllers = controllers;
            RawReportDescriptor = rawReportDescriptor;
            _items = items.ToDictionary(i => i.item, _ => (DeviceItemInputParser?)null);
            Name = GetName(device);
            _axes = items
                .SelectMany(i => i.usages)
                .ToDictionary(t => t, t => Control.Create(this, t.usage, t.dataItem));

            /*
             * Group Axis into Control
             */
            var axes = new List<Control>();
            var toGroup = new Dictionary<Usage, Axis>();

            // Find single dimension axes and just add them, whilst placing multi-dimensional axes into toGroup collection
            foreach (var axis in _axes.Values)
            {
                if (axis.Type.IsGrouped)
                {
                    toGroup[axis.Type.Usage] = axis;
                }
                else
                {
                    axes.Add(axis);
                }

                // Add initial values - note that the initial value may be double.NaN, which would mean this hasn't 'changed'
                // however we still include in the changes to ensure the axis is included in the first change batch.
                _changes.AddOrUpdate(new ControlChange(axis, double.NaN, axis.Value));
            }

            // Create grouping Control for groups
            while (toGroup.Count > 0)
            {
                var axisType = toGroup.Values.First().Type;
                var usages = axisType.Group;
                var group = new Axis[usages.Count];
                for (var i = 0; i < usages.Count; i++)
                {
                    var usage = usages[i];
                    group[i] = toGroup[usage];
                    toGroup.Remove(usage);
                }

                axes.Add(axisType.Create(group));
            }

            Controls = axes.ToArray();

            // Create buffer
            _inputReportBuffer = new byte[_device.GetMaxInputReportLength()];

            // Create parsers
            foreach (var item in _items.Keys.ToArray())
            {
                _items[item] = item.CreateDeviceItemInputParser();
            }

            _inputReceiver = reportDescriptor.CreateHidDeviceInputReceiver();
            _inputReceiver.Received += InputReceived;
            _inputReceiver.Stopped += InputStopped;

            _inputReceiver.Start(stream);
        }

        public IObservable<IList<ControlChange>> Changes
            => _changes?
                   .Connect()
                   .Select(cs => cs.Select(c => c.Current).Where(cc => cc != null).ToList())
               ?? throw new ObjectDisposedException(nameof(Controller));

        public Controllers Controllers { get; }

        public IReadOnlyCollection<Control> Controls { get; }
        public IEnumerable<Button> Buttons => Controls.OfType<Button>();
        public IEnumerable<Slider> Sliders => Controls.OfType<Slider>();
        public IEnumerable<DPad> DPads => Controls.OfType<DPad>();
        public IEnumerable<Hat> Hats => Controls.OfType<Hat>();
        public IEnumerable<Joystick> Joysticks => Controls.OfType<Joystick>();

        public string Name { get; }
        public string DevicePath => _device.DevicePath;

        /// <inheritdoc />
        public ValueTask DisposeAsync()
        {
            var inputReceiver = Interlocked.Exchange(ref _inputReceiver, null);
            if (inputReceiver != null)
            {
                inputReceiver.Received -= InputReceived;
                inputReceiver.Stopped -= InputStopped;
            }

            _items.Clear();

            Interlocked.Exchange(ref _inputReportBuffer, null);
            Interlocked.Exchange(ref _changes, null)?.Dispose();

            return Interlocked.Exchange(ref _hidStream, null)?.DisposeAsync() ?? new ValueTask();
        }

        /// <summary>
        ///     Gets the friendly name for the device.
        /// </summary>
        /// <param name="device">The device.</param>
        /// <returns>System.String.</returns>
        private static string GetName(HidDevice device)
        {
            var manufacturer = string.Empty;
#pragma warning disable CA1031 // Do not catch general exception types
            // ReSharper disable EmptyGeneralCatchClause
            try
            {
                manufacturer = device.GetManufacturer().Trim();
            }
            catch { }

            var productName = string.Empty;
            try
            {
                productName = device.GetProductName().Trim();
            }
            catch { }
            // ReSharper restore EmptyGeneralCatchClause
#pragma warning restore CA1031 // Do not catch general exception types

            if (!string.IsNullOrWhiteSpace(manufacturer))
            {
                return !string.IsNullOrWhiteSpace(productName)
                    ? $"{manufacturer} {productName}"
                    : $"{manufacturer}; " + string.Format(Resources.DefaultControllerName, device.VendorID,
                        device.ProductID, device.ReleaseNumber);
            }

            if (!string.IsNullOrWhiteSpace(productName))
            {
                return productName;
            }

            return string.Format(Resources.DefaultControllerName, device.VendorID, device.ProductID,
                device.ReleaseNumber);
        }

        /// <inheritdoc />
        public override string ToString() => Name;

        private void InputStopped(object? sender, EventArgs e) =>
            Controllers.Logger?.Log(Event.ControllerStreamStopped, Name);

        private void InputReceived(object? sender, EventArgs e)
        {
            var receiver = (HidDeviceInputReceiver?)sender;
            if (receiver is null)
            {
                return;
            }

            try
            {
                var changes = new List<ControlChange>();
                while (receiver.TryRead(_inputReportBuffer, 0, out var report))
                {
                    foreach (var parser in _items.Values)
                    {
                        if (parser?.TryParseReport(_inputReportBuffer, 0, report) != true ||
                            !parser.HasChanged)
                        {
                            continue;
                        }

                        // Find changes
                        while (parser.HasChanged)
                        {
                            var changedIndex = parser.GetNextChangedIndex();
                            var dataValue = parser.GetValue(changedIndex);
                            var dataItem = dataValue.DataItem;
                            var usage = (Usage)dataValue.Usages.FirstOrDefault(
                                u => AxisType.SupportedUsage((Usage)u));

                            if (!_axes.TryGetValue((usage, dataItem), out var axis))
                            {
                                continue;
                            }

                            var args = axis.Set(dataValue);
                            if (args != null)
                            {
                                changes.Add(args);
                            }
                        }

                        break;
                    }
                }

                if (changes.Count > 0)
                {
                    _changes?.Edit(c => c.AddOrUpdate(changes));
                }
            }
#pragma warning disable CA1031 // Do not catch general exception types
            catch (Exception exception)
            {
                Controllers.Logger?.Log(Event.ControllerInputParseFailure, exception, Name);
            }
#pragma warning restore CA1031 // Do not catch general exception types
        }
    }
}
