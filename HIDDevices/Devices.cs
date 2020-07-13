// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Threading;
using System.Threading.Tasks;
using DynamicData;
using DynamicData.Kernel;
using HidSharp;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.Threading;

namespace HIDDevices
{
    public sealed class Devices : IObservableCache<Device, string>
    {
        private readonly TaskCompletionSource<bool> _loadedTaskCompletionSource =
            new TaskCompletionSource<bool>(TaskCreationOptions.RunContinuationsAsynchronously);

        private readonly AsyncAutoResetEvent _triggerRefresh = new AsyncAutoResetEvent(true);

        internal readonly ILogger<Devices>? Logger;
        private SourceCache<Device, string>? _controllers;
        private CancellationTokenSource? _refreshCancellationTokenSource;

        /// <summary>
        ///     Initialises a new instance of the <see cref="Devices" /> class.
        /// </summary>
        /// <param name="logger">The logger (optional).</param>
        public Devices(ILogger<Devices>? logger = null)
        {
            Logger = logger;
            _controllers = new SourceCache<Device, string>(c => c.DevicePath);

            DeviceList.Local.Changed += (sender, args) => Refresh();
            _refreshCancellationTokenSource = new CancellationTokenSource();
            var cancellationToken = _refreshCancellationTokenSource.Token;
            Task.Run(() => RefreshAsync(cancellationToken), cancellationToken)
                .ConfigureAwait(false); // Launch in background thread
            Refresh();
        }

        public IEnumerable<Device> All =>
            _controllers?.Items ?? throw new ObjectDisposedException(nameof(Devices));

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
            Interlocked.Exchange(ref _refreshCancellationTokenSource, null)?.Dispose();
            var controllers = Interlocked.Exchange(ref _controllers, null);
            if (controllers is null)
            {
                return;
            }

            var toDispose = controllers.Items.ToArray();
            controllers.Clear();
            controllers?.Dispose();
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
        ///     Force a refresh of controllers.  The refresh will occur asynchronously.
        /// </summary>
        /// TODO Consider making this async and awaiting next refresh completion.
        public void Refresh() => _triggerRefresh.Set();

        private async Task RefreshAsync(CancellationToken cancellationToken)
        {
#if DEBUG
            //HidSharpDiagnostics.EnableTracing = true;
#else
            HidSharpDiagnostics.EnableTracing = false;
#endif

            // Create dictionary to hold disconnected controllers, allowing for resurrection.
            var zombieControllers = new Dictionary<string, Device>();
            do
            {
                try
                {
                    await _triggerRefresh.WaitAsync(cancellationToken).ConfigureAwait(false);
                    if (cancellationToken.IsCancellationRequested)
                    {
                        return;
                    }

                    // Get all existing values
                    var controllers = _controllers ?? throw new ObjectDisposedException(nameof(Devices));
                    var existing = controllers.KeyValues.ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

                    var added = new List<Device>();
                    var updated = new List<(Device existing, Device updated)>();

                    var list = DeviceList.Local;
                    foreach (var hidDevice in list.GetHidDevices())
                    {
                        if (cancellationToken.IsCancellationRequested)
                        {
                            return;
                        }

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
                            else if (zombieControllers.TryGetValue(hidDevice.DevicePath, out existingController))
                            {
                                // Resurrect the zombie.
                                zombieControllers.Remove(existingController.DevicePath);

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
                                zombieControllers.Add(kvp.Value.DevicePath, kvp.Value);
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

                    // Indicate we have loaded.
                    _loadedTaskCompletionSource.TrySetResult(true);
                }
#pragma warning disable CA1031 // Do not catch general exception types
                catch (OperationCanceledException)
                {
                    // If we get a cancellation exception we must be disposing, so abort.
                    return;
                }
                catch (Exception exception)
                {
                    Logger?.Log(Event.RefreshFailure, exception);
                }
#pragma warning restore CA1031 // Do not catch general exception types
                //_loadedCompletionSource?.TrySetResult(true);
            } while (!cancellationToken.IsCancellationRequested);
        }

        public Task LoadAsync(CancellationToken cancellationToken = default) =>
            _loadedTaskCompletionSource.Task.WithCancellation(cancellationToken);

        /// <summary>
        ///     Gets a filtered observable of control changes.
        /// </summary>
        /// <param name="predicate">
        ///     A function that returns <see langword="true" /> if the control should be monitored for changes;
        ///     otherwise <see langword="false" />.
        /// </param>
        /// <returns>A filtered observable of control changes.</returns>
        public IObservable<IList<ControlChange>> Watch(Func<Control, bool>? predicate = null)
            => Connect()
                .SelectMany(cs => cs)
                .Where(c => c.Reason != ChangeReason.Remove && (predicate is null || c.Current.Keys.Any(predicate)))
                .Select(c => c.Current)
                .SelectMany(c => c.Watch(predicate)
                    // Suppress errors so we don't stop listening on valid controllers - error will already have been logged.
                    .Catch((Exception _) => Observable.Empty<IList<ControlChange>>()))
                .Where(l => l.Count > 0);

#pragma warning disable VSTHRD002 // Avoid problematic synchronous waits
        public void Load() => _loadedTaskCompletionSource.Task.GetAwaiter().GetResult();

        public void Load(TimeSpan timeout) =>
            _loadedTaskCompletionSource.Task.WithTimeout(timeout).GetAwaiter().GetResult();
#pragma warning restore VSTHRD002 // Avoid problematic synchronous waits

        //  predicate is null ? Connect() : Connect().Select(l => l.Where(change => predicate(change.Control)).ToList());
    }
}
