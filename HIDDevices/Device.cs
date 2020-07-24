// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Threading;
using HidSharp;
using HidSharp.Reports;
using Microsoft.VisualStudio.Threading;

namespace HIDDevices
{
    /// <summary>
    ///     Class Device.
    ///     Implements the <see cref="IObservable{T}" /> interface
    ///     Implements the <see cref="IReadOnlyDictionary{TKey,TValue}" />
    /// </summary>
    /// <seealso cref="IObservable{T}" />
    /// <seealso cref="IReadOnlyDictionary{TKey, TValue}" />
    public sealed class Device : IObservable<IList<ControlChange>>, IReadOnlyDictionary<Control, ControlChange>
    {
        private readonly Dictionary<Control, ControlChange> _cache;
        private readonly IObservable<IList<ControlChange>> _changes;
        private readonly IReadOnlyDictionary<(DataItem dataItem, int index), Control> _controls;
        private readonly HidDevice _device;

        private readonly HashSet<Usage> _usages;
        private CancellationTokenSource? _cancellationTokenSource;
        private BehaviorSubject<bool>? _connectedSubject;

        internal Device(Devices devices, HidDevice device, byte[] rawReportDescriptor)
        {
            Devices = devices;

            // Calculate a friendly name
            Name = GetName(device);

            _device = device;
            var cancellationTokenSource = new CancellationTokenSource();
            _cancellationTokenSource = cancellationTokenSource;
            _connectedSubject = new BehaviorSubject<bool>(false);

            RawReportDescriptor = rawReportDescriptor;
            var reportDescriptor = new ReportDescriptor(RawReportDescriptor);
            var deviceItems = reportDescriptor.DeviceItems;

            _usages = new HashSet<Usage>(deviceItems
                .SelectMany(deviceItem =>
                    deviceItem.Usages
                        .GetAllValues()
                        .Select(Usage.Get)));

            // Create parsers
            var inputParsers = deviceItems
                .ToDictionary(i => i, i => i.CreateDeviceItemInputParser());

            // Find controls.
            _controls = inputParsers.Values
                .SelectMany(inputParser => Enumerable.Range(0, inputParser.ValueCount)
                    .Select(index => (index, dataValue: inputParser.GetValue(index))))
                .ToDictionary(t => (t.dataValue.DataItem, t.index), t => new Control(this, t.dataValue, t.index));

            // Create cache of last known values.
            _cache = new Dictionary<Control, ControlChange>();

#pragma warning disable CA1031 // Do not catch general exception types
            var listener = Observable.Create<IList<ControlChange>>(
                    async (observer, token) =>
                    {
                        // The observable token is only cancelled when all subscribers stop listening, and only
                        // 'best-efforts' are used.  We supplement with explicit disposal, which is triggered when
                        // a disconnect is detected.
                        using var combinedToken = token.CombineWith(cancellationTokenSource.Token);
                        var cancellationToken = combinedToken.Token;
                        if (cancellationToken.IsCancellationRequested)
                        {
                            observer.OnCompleted();
                            return;
                        }

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
                            observer.OnCompleted();
                            return;
                        }
                        catch (Exception ex)
                        {
                            // Log error TODO Event
                            Devices.Logger?.Log(Event.DeviceConnectionFailed, ex, Name);
                            observer.OnError(ex);
                            return;
                        }

                        _connectedSubject?.OnNext(true);

                        try
                        {
                            // Create buffer
                            var buffer = new byte[_device.GetMaxInputReportLength()];

                            var inputReceiver = reportDescriptor.CreateHidDeviceInputReceiver();

                            inputReceiver.Start(stream);
                            Devices.Logger?.Log(Event.DeviceConnected, Name);

                            // Some devices spam changes, so we collect only the last value as quickly as possible.
                            var batch = new Dictionary<(DataItem, int), (DataValue, long timestamp)>(_controls.Count);
                            while (!cancellationToken.IsCancellationRequested)
                            {
                                await inputReceiver.WaitHandle;

                                if (!inputReceiver.IsRunning)
                                {
                                    break;
                                }

                                while (inputReceiver.TryRead(buffer, 0, out var report))
                                {
                                    var timestamp = Stopwatch.GetTimestamp();

                                    foreach (var parser in inputParsers.Values)
                                    {
                                        if (!parser.TryParseReport(buffer, 0, report))
                                        {
                                            continue;
                                        }

                                        while (parser.HasChanged)
                                        {
                                            var index = parser.GetNextChangedIndex();
                                            var dataValue = parser.GetValue(index);
                                            var dataItem = dataValue.DataItem;
                                            batch[(dataItem, index)] = (dataValue, timestamp);
                                        }
                                    }
                                }

                                // Check for changes
                                if (batch.Count < 1)
                                {
                                    continue;
                                }

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
                                        if (_cache.TryGetValue(control, out var controlChange))
                                        {
                                            var updatedChange = controlChange.Update(tuple.value);
                                            if (updatedChange is null)
                                            {
                                                continue;
                                            }

                                            controlChange = updatedChange.Value;
                                        }
                                        else
                                        {
                                            controlChange = new ControlChange(control, tuple.value);
                                        }

                                        _cache[control] = controlChange;
                                        batchList.Add(controlChange);
                                    }
                                }

                                // Notify observers
                                if (batchList.Count > 0)
                                {
                                    observer.OnNext(batchList);
                                }

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
                            Devices.Logger?.Log(Event.DeviceError, ex, Name);
                            observer.OnError(ex);
                        }
                        finally
                        {
                            _connectedSubject?.OnNext(false);
                            await stream.DisposeAsync().ConfigureAwait(false);
                        }

                        Devices.Logger?.Log(Event.DeviceConnectionClosed, Name);
                        observer.OnCompleted();
                    })
                .Publish()
                .RefCount();
            _changes = Observable.Defer(()
                => listener
                    // Always dump last seen values on subscription
                    .StartWith(_cache.Values
                        // Simulate a change from double.NaN
                        .Select(c => c.PreviousValue.Equals(double.NaN) ? c : c.Reset())
                        .ToList()));
#pragma warning restore CA1031 // Do not catch general exception types
        }

        /// <summary>
        ///     Gets the usages.
        /// </summary>
        /// <value>The usages.</value>
        public IReadOnlyCollection<Usage> Usages => _usages;

        /// <summary>
        ///     Gets the devices.
        /// </summary>
        /// <value>The devices.</value>
        public Devices Devices { get; }

        /// <summary>
        ///     Gets the device path.
        /// </summary>
        /// <value>The device path.</value>
        public string DevicePath => _device.DevicePath;

        /// <summary>
        ///     Gets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; }

        /// <summary>
        ///     The USB product ID. These are listed at: http://usb-ids.gowdy.us
        /// </summary>
        /// <value>The product identifier.</value>
        public int ProductId => _device.ProductID;

        /// <summary>
        ///     The device release number.
        /// </summary>
        /// <value>The release number.</value>
        public Version ReleaseNumber => _device.ReleaseNumber;

        /// <summary>
        ///     Gets an observable of the device's connection state.
        /// </summary>
        /// <value>
        ///     An observable of the device's connection state, which returns <see langword="true" /> when connecting and
        ///     <see langword="false" /> when disconnecting.
        /// </value>
        public IObservable<bool> ConnectionState
            => _connectedSubject ?? throw new ObjectDisposedException(nameof(Device));

        /// <summary>
        ///     Gets the current <see cref="ConnectionState">connection state</see>.
        /// </summary>
        /// <value>The is connected.</value>
        /// <seealso cref="ConnectionState" />
        public bool IsConnected => _connectedSubject?.Value ?? throw new ObjectDisposedException(nameof(Device));

        internal byte[] RawReportDescriptor { get; }

        /// <summary>
        ///     Gets an enumeration of controls.
        /// </summary>
        /// <value>The controls.</value>
        public IEnumerable<Control> Controls => _controls.Values;

        /// <inheritdoc />
        public IDisposable Subscribe(IObserver<IList<ControlChange>> observer) => _changes.Subscribe(observer);

        /// <inheritdoc />
        public IEnumerator<KeyValuePair<Control, ControlChange>> GetEnumerator()
        {
            KeyValuePair<Control, ControlChange>[] snapshot;
            lock (_cache)
            {
                snapshot = _cache.ToArray();
            }

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
            {
                return _cache.ContainsKey(key);
            }
        }

        /// <inheritdoc />
        public bool TryGetValue(Control key, out ControlChange value)
        {
            lock (_cache)
            {
                return _cache.TryGetValue(key, out value);
            }
        }

        /// <inheritdoc />
        public ControlChange this[Control key]
        {
            get
            {
                lock (_cache)
                {
                    return _cache[key];
                }
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
                {
                    return _cache.Values;
                }
            }
        }

        /// <summary>
        ///     Disposes this device, forcing any remaining subscribers to disconnect.
        ///     We only do this when our devices collection is disposed, otherwise we can resurrect this device
        ///     any time it is plugged back in.  As such, this is not a public method, and we don't implement
        ///     <seealso cref="IDisposable" />.
        /// </summary>
        internal void Dispose()
        {
            Interlocked.Exchange(ref _cancellationTokenSource, null)?.Dispose();
            var connectedSubject = Interlocked.Exchange(ref _connectedSubject, null);
            if (connectedSubject is null)
            {
                return;
            }

            connectedSubject.OnCompleted();
            connectedSubject.Dispose();
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

        /// <summary>
        ///     Gets a filtered observable of control changes.
        /// </summary>
        /// <param name="predicate">
        ///     A function that returns <see langword="true" /> if the control should be monitored for changes;
        ///     otherwise <see langword="false" />.
        /// </param>
        /// <returns>A filtered observable of control changes.</returns>
        public IObservable<IList<ControlChange>> Watch(Func<Control, bool>? predicate = null)
            => predicate is null
                ? (IObservable<IList<ControlChange>>)this
                : this.Select(l => l.Where(change => predicate(change.Control)).ToList());
    }
}
