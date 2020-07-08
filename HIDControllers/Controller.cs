// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reactive.Linq;
using System.Threading;
using System.Threading.Tasks;
using DynamicData;
using HIDControllers.OLD;
using HidSharp;
using HidSharp.Reports;
using HidSharp.Reports.Input;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.Threading;
using Nito.AsyncEx.Interop;

namespace HIDControllers
{
    public sealed class Controller : IObservable<IList<ControlChange>>, IReadOnlyDictionary<Control, ControlChange>, IDisposable
    {
        private readonly IReadOnlyDictionary<(DataItem dataItem, int index), Control> _controls;
        private readonly HidDevice _device;
        private readonly IObservable<IList<ControlChange>> _changes;
        private readonly Dictionary<Control, ControlChange> _cache;
        private CancellationTokenSource? _cancellationTokenSource;

        public IReadOnlyCollection<Usage> Usages { get; }

        public Controller(Controllers controllers, HidDevice device, byte[] rawReportDescriptor)
        {
            Controllers = controllers;

            // Calculate a friendly name
            Name = GetName(device);

            _device = device;
            var cancellationTokenSource = new CancellationTokenSource();
            _cancellationTokenSource = cancellationTokenSource;

            RawReportDescriptor = rawReportDescriptor;
            var reportDescriptor = new ReportDescriptor(RawReportDescriptor);
            var deviceItems = reportDescriptor.DeviceItems;

            Usages = deviceItems.SelectMany(deviceItem => deviceItem.Usages.GetAllValues().Select(Usage.Get)).ToArray();

            // Create parsers
            var inputParsers = deviceItems
                .ToDictionary(i => i, i => i.CreateDeviceItemInputParser());

            // Find controls.
            _controls = inputParsers.Values
                .SelectMany(inputParser => Enumerable.Range(0, inputParser.ValueCount)
                    .Select(index => (index, dataValue: inputParser.GetValue(index))))
                .ToDictionary(t => (t.dataValue.DataItem, t.index), t => new Control(this, t.dataValue, t.index));

            // Create cache of last values.
            _cache = _controls.Values.ToDictionary(c => c, c => new ControlChange(c));

            var listener = Observable.Create<IList<ControlChange>>(
                    async (observer, token) =>
                    {
                        // The observable token is only cancelled when all subscribers stop listening, and only
                        // 'best-efforts' are used.  We supplement with explicit disposal, which is triggered when
                        // a disconnect is detected.
                        using var cancellationToken = token.CombineWith(cancellationTokenSource.Token);

                        // Try to open the stream
                        HidStream stream;
                        try
                        {
                            var options = new OpenConfiguration();
                            options.SetOption(OpenOption.Interruptible, true);
                            stream = device.Open();
                            stream.ReadTimeout = Timeout.Infinite;
                        }
                        catch (OperationCanceledException)
                        {
                            // Ignore, just complete
                            return;
                        }
                        catch (Exception ex)
                        {
                            // Log error
                            Controllers.Logger.LogError(ex, $"Failed to open a connection to the {Name} Controller.");
                            observer.OnError(ex);
                            return;
                        }

                        try
                        {
                            // Create buffer
                            var buffer = new byte[_device.GetMaxInputReportLength()];

                            var inputReceiver = reportDescriptor.CreateHidDeviceInputReceiver();

                            inputReceiver.Start(stream);

                            Controllers.Logger.LogInformation($"Began listening to {Name} Controller.");

                            // Some devices spam changes, so we collect only the last value as quickly as possible.
                            var batch = new Dictionary<(DataItem, int), DataValue>(_controls.Count);
                            while (!cancellationToken.Token.IsCancellationRequested)
                            {
                                await inputReceiver.WaitHandle;

                                if (!inputReceiver.IsRunning) break;

                                while (inputReceiver.TryRead(buffer, 0, out var report))
                                {
                                    foreach (var parser in inputParsers.Values)
                                    {
                                        if (!parser.TryParseReport(buffer, 0, report))
                                            continue;

                                        while (parser.HasChanged)
                                        {
                                            var index = parser.GetNextChangedIndex();
                                            var dataValue = parser.GetValue(index);
                                            var dataItem = dataValue.DataItem;
                                            foreach (var usage in dataValue.Usages)
                                            {
                                                batch[(dataItem, index)] = dataValue;
                                            }
                                        }
                                    }
                                }

                                // Check for changes
                                if (batch.Count < 1) continue;

                                // Update cache with batch of changes.
                                var batchList = new List<ControlChange>(batch.Count);
                                lock (_cache)
                                {
                                    foreach (var tuple in batch
                                        .Select(kvp => (
                                            control: _controls.TryGetValue(kvp.Key, out var control) ? control : null,
                                            value: kvp.Value))
                                        .Where(t => t.control != null))
                                    {
                                        var control = tuple.control!;
                                        var controlChange = _cache[control].Update(tuple.value);

                                        // Check for actual change in value
                                        if (controlChange is null) continue;

                                        _cache[control] = controlChange.Value;
                                        batchList.Add(controlChange.Value);
                                    }
                                }

                                // Notify observers
                                if (batchList.Count > 0)
                                    observer.OnNext(batchList);

                                // We've done with this batch now
                                batch.Clear();
                            }
                        }
                        catch (OperationCanceledException)
                        {
                            // Ignore, just complete
                        }
                        catch (Exception ex)
                        {
                            Controllers.Logger.LogError(ex, $"Failed listening to {Name} Controller.");
                            observer.OnError(ex);
                        }
                        finally
                        {
                            if (stream != null)
                                await stream.DisposeAsync().ConfigureAwait(false);
                        }

                        Controllers.Logger.LogInformation($"Stopped listening to {Name} Controller.");
                        observer.OnCompleted();
                    })
                .Publish()
                .RefCount();
            _changes = Observable.Defer(()
                => listener
                    // Always dump current/initial values on subscription
                    .StartWith(_cache.Values
                        // Simulate a change from double.NaN
                        .Select(c => c.PreviousValue.Equals(double.NaN) ? c : c.Reset())
                        .ToList()));
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

        public Controllers Controllers { get; }

        public string DevicePath => _device.DevicePath;

        public string Name { get; }

        /// <inheritdoc />
        public IEnumerator<KeyValuePair<Control, ControlChange>> GetEnumerator()
        {
            KeyValuePair<Control, ControlChange>[] snapshot;
            lock (_cache)
                snapshot = _cache.ToArray();

            return ((IEnumerable<KeyValuePair<Control, ControlChange>>)snapshot).GetEnumerator();
        }

        /// <inheritdoc />
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        /// <inheritdoc />
        public int Count => _controls.Count;

        /// <inheritdoc />
        public bool ContainsKey(Control key)
        {
            lock (_cache)
                return _cache.ContainsKey(key);
        }

        /// <inheritdoc />
        public bool TryGetValue(Control key, out ControlChange value)
        {
            lock (_cache)
                return _cache.TryGetValue(key, out value);
        }

        /// <inheritdoc />
        public ControlChange this[Control key]
        {
            get
            {
                lock (_cache)
                    return _cache[key];
            }
        }

        /// <inheritdoc />
        public IEnumerable<Control> Keys => _controls.Values;

        /// <inheritdoc />
        public IEnumerable<ControlChange> Values
        {
            get
            {
                lock (_cache)
                    return _cache.Values;
            }
        }

        internal byte[] RawReportDescriptor { get; }

        /// <inheritdoc />
        public IDisposable Subscribe(IObserver<IList<ControlChange>> observer) => _changes.Subscribe(observer);

        /// <inheritdoc />
        public override string ToString() => Name;

        /// <summary>
        /// Gets a filtered observable of control changes.
        /// </summary>
        /// <param name="predicate">A function that returns <see langword="true"/> if the control should be monitored for changes; otherwise <see langword="false"/>.</param>
        /// <returns>A filtered observable of control changes.</returns>
        public IObservable<IList<ControlChange>> Watch(Func<Control, bool>? predicate = null)
            => predicate is null
                ? (IObservable<IList<ControlChange>>)this
                : this.Select(l => l.Where(change => predicate(change.Control)).ToList());

        /// <inheritdoc />
        public void Dispose() => Interlocked.Exchange(ref _cancellationTokenSource, null)?.Dispose();
    }
}
