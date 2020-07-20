// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Reactive.Threading.Tasks;
using System.Threading;
using System.Threading.Tasks;
using DynamicData;
using DynamicData.Kernel;
using HidSharp;
using Microsoft.Extensions.Logging;

namespace HIDDevices
{
    /// <summary>
    ///     Class Devices. This class cannot be inherited.
    ///     Implements the <see cref="IObservableCache{T, TKey}" /> interface.
    ///     An observable collection of <see cref="Device">devices</see> that monitors HID Devices asynchronously.
    /// </summary>
    /// <seealso cref="IObservableCache{T, TKey}" />
    public sealed class Devices : IObservableCache<Device, string>
    {
        private readonly Dictionary<string, Device> _zombieControllers;
        internal readonly ILogger<Devices>? Logger;
        private SourceCache<Device, string>? _controllers;
        private IDisposable? _eventSubscription;
        private BehaviorSubject<bool>? _refreshingBehaviorSubject;

        /// <summary>
        ///     Initialises a new instance of the <see cref="Devices" /> class.
        /// </summary>
        /// <param name="logger">The logger (optional).</param>
        public Devices(ILogger<Devices>? logger = null)
        {
            Logger = logger;
            _controllers = new SourceCache<Device, string>(c => c.DevicePath);
            _refreshingBehaviorSubject = new BehaviorSubject<bool>(false);

            // Create dictionary to hold disconnected controllers, allowing for resurrection.
            _zombieControllers = new Dictionary<string, Device>();

            _eventSubscription = Observable
                .FromEventPattern<EventHandler<DeviceListChangedEventArgs>, DeviceListChangedEventArgs>(
                    h => DeviceList.Local.Changed += h,
                    h => DeviceList.Local.Changed -= h)
                // We don't care about args, so discard
                .Select(_ => Unit.Default)
                // We need an initial load so add a unit to trigger first load.
                .StartWith(Unit.Default)
                // Run as background task
                .ObserveOn(TaskPoolScheduler.Default)
                .Subscribe(_ => UpdateDevices());
        }

        /// <summary>
        ///     Gets an enumeration of currently available devices.
        /// </summary>
        /// <value>An enumeration of currently available devices.</value>
        /// <exception cref="ObjectDisposedException">This collection is disposed.</exception>
        public IEnumerable<Device> All =>
            _controllers?.Items ?? throw new ObjectDisposedException(nameof(Devices));

        /// <summary>
        ///     Gets an observable that indicates when the current collection of devices is refreshing.
        /// </summary>
        /// <value>
        ///     The refreshing observable returns a <see langword="true" /> when it starts refreshing; otherwise
        ///     <see langword="false" />.
        /// </value>
        public IObservable<bool> Refreshing
            => _refreshingBehaviorSubject ??
               throw new ObjectDisposedException(nameof(Devices));

        /// <summary>
        ///     Gets a value indicating whether the collection of devices is currently <see cref="Refreshing">refreshing</see>.
        /// </summary>
        /// <value><see langword="true" /> if this instance is refreshing; otherwise, <see langword="false" />.</value>
        /// <seealso cref="Refreshing" />
        public bool IsRefreshing => Refreshing.LastAsync().Wait();

        /// <inheritdoc />
        public IObservable<Change<Device, string>> Watch(string key) =>
            _controllers?.Watch(key) ?? throw new ObjectDisposedException(nameof(Devices));

        /// <inheritdoc />
        public IObservable<IChangeSet<Device, string>> Connect(Func<Device, bool>? predicate = null)
            => _controllers?.Connect(predicate) ?? throw new ObjectDisposedException(nameof(Devices));

        /// <inheritdoc />
        public IObservable<IChangeSet<Device, string>> Preview(Func<Device, bool>? predicate = null)
            => _controllers?.Preview(predicate) ?? throw new ObjectDisposedException(nameof(Devices));

        /// <inheritdoc />
        public IObservable<int> CountChanged
            => _controllers?.CountChanged ?? throw new ObjectDisposedException(nameof(Devices));

        /// <inheritdoc />
        public void Dispose()
        {
            Interlocked.Exchange(ref _eventSubscription, null)?.Dispose();
            var refreshingBehaviorSubject = Interlocked.Exchange(ref _refreshingBehaviorSubject, null);
            if (refreshingBehaviorSubject != null)
            {
                refreshingBehaviorSubject.OnCompleted();
                refreshingBehaviorSubject.Dispose();
            }

            var controllers = Interlocked.Exchange(ref _controllers, null);
            if (controllers is null)
            {
                return;
            }

            var toDispose = controllers.Items.Concat(_zombieControllers.Values).ToArray();
            controllers.Clear();
            controllers?.Dispose();
            _zombieControllers.Clear();
            foreach (var device in toDispose)
            {
                // Note we only dispose controllers when we're disposed,
                // otherwise we keep them so we can 'resurrect' them.
                device.Dispose();
            }
        }

        /// <inheritdoc />
        public Optional<Device> Lookup(string key)
            => _controllers?.Lookup(key) ?? throw new ObjectDisposedException(nameof(Devices));

        /// <inheritdoc />
        IEnumerable<string> IObservableCache<Device, string>.Keys
            => _controllers?.Keys ?? throw new ObjectDisposedException(nameof(Devices));

        /// <inheritdoc />
        IEnumerable<Device> IObservableCache<Device, string>.Items
            => _controllers?.Items ?? throw new ObjectDisposedException(nameof(Devices));

        /// <inheritdoc />
        IEnumerable<KeyValuePair<string, Device>> IObservableCache<Device, string>.KeyValues
            => _controllers?.KeyValues ?? throw new ObjectDisposedException(nameof(Devices));

        /// <inheritdoc />
        public int Count => _controllers?.Count ?? throw new ObjectDisposedException(nameof(Devices));

        /// <summary>
        ///     Update the list of current HID devices.
        /// </summary>
        /// <exception cref="ObjectDisposedException">This collection is disposed.</exception>
        private void UpdateDevices()
        {
            try
            {
                // Get all existing values
                var controllers = _controllers;
                if (controllers is null)
                {
                    return;
                }

                // Indicate we're in the process of refreshing.
                _refreshingBehaviorSubject?.OnNext(true);

                var existing = controllers.KeyValues.ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

                var added = new List<Device>();
                var updated = new List<(Device existing, Device updated)>();

                var list = DeviceList.Local;
                foreach (var hidDevice in list.GetHidDevices())
                {
                    try
                    {
                        var rawReportDescriptor = hidDevice.GetRawReportDescriptor();
#pragma warning disable IDE0018 // Inline variable declaration - required to coerce to nullable type.
                        // ReSharper disable once InlineOutVariableDeclaration
                        Device? existingController;
#pragma warning restore IDE0018 // Inline variable declaration
                        // Check to see if device already exists and is unchanged.
                        if (existing.TryGetValue(hidDevice.DevicePath, out existingController))
                        {
                            if (rawReportDescriptor.SequenceEqual(existingController.RawReportDescriptor))
                            {
                                // We found this device, so remove from the existing list.
                                existing.Remove(existingController.DevicePath);
                                continue;
                            }
                        }
                        else if (_zombieControllers.TryGetValue(hidDevice.DevicePath, out existingController))
                        {
                            // Resurrect the zombie.
                            _zombieControllers.Remove(existingController.DevicePath);

                            if (rawReportDescriptor.SequenceEqual(existingController.RawReportDescriptor))
                            {
                                continue;
                            }

                            // The definition of the device has changed, so we can dispose the zombie
                            // so it can be replaced by a new device.
                            existingController.Dispose();
                            existingController = null;
                        }
                        else
                        {
                            existingController = null;
                        }

                        var device = new Device(this, hidDevice, rawReportDescriptor);

                        // Update collection with new device info
                        if (existingController is null)
                        {
                            added.Add(device);
                        }
                        else
                        {
                            existing.Remove(device.DevicePath);
                            updated.Add((existingController, device));
                        }
                    }
#pragma warning disable CA1031 // Do not catch general exception types
                    catch (Exception exception)
                    {
                        Logger?.Log(Event.DeviceCreationFailure, exception, hidDevice);
                    }
#pragma warning restore CA1031 // Do not catch general exception types
                }

                // Indicate refresh completed
                _refreshingBehaviorSubject?.OnNext(false);

                // Remove existing controllers that weren't found or updated
                if (existing.Count > 0 || added.Count > 0 || updated.Count > 0)
                {
                    // Batch changes
                    controllers.Edit(cache =>
                    {
                        foreach (var kvp in existing)
                        {
                            // Move device to zombie storage, as it's definition is
                            // still valid, but is no longer connected, if it is reconnected
                            // it can be safely resurrected.
                            cache.RemoveKey(kvp.Key);
                            _zombieControllers.Add(kvp.Value.DevicePath, kvp.Value);
                            Logger?.Log(Event.DeviceRemove, kvp.Value.Name);
                        }

                        foreach (var c in added)
                        {
                            cache.AddOrUpdate(c);
                            Logger?.Log(Event.DeviceAdd, c.Name);
                        }

                        foreach (var t in updated)
                        {
                            cache.AddOrUpdate(t.updated);
                            // As the device definition has fundamentally changed,
                            // we will dispose the existing device now, as it will not
                            // be resurrected.
                            t.existing.Dispose();
                            Logger?.Log(Event.DeviceUpdate, t.updated.Name);
                        }
                    });
                }
            }
#pragma warning disable CA1031 // Do not catch general exception types
            catch (Exception exception)
            {
                Logger?.Log(Event.RefreshFailure, exception);
            }
#pragma warning restore CA1031 // Do not catch general exception types
        }

        /// <summary>
        ///     Asynchronous task that completes when the first load of devices has completed.
        /// </summary>
        /// <param name="cancellationToken">
        ///     The cancellation token that can be used by other objects or threads to receive notice
        ///     of cancellation.
        /// </param>
        /// <returns>An awaitable task that completes when the first load of devices has completed.</returns>
        public Task<IChangeSet<Device, string>> LoadAsync(CancellationToken cancellationToken = default)
            => _controllers?.Connect().FirstAsync().ToTask(cancellationToken) ??
               throw new ObjectDisposedException(nameof(Devices));
    }
}
