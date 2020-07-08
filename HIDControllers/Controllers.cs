using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reactive.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DynamicData;
using DynamicData.Kernel;
using HIDControllers.OLD;
using HidSharp;
using HidSharp.Reports;
using HidSharp.Utility;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.Threading;

namespace HIDControllers
{
    public sealed class Controllers : IObservableCache<Controller, string>
    {
        private SourceCache<Controller, string>? _controllers;
        private readonly AsyncAutoResetEvent _triggerRefresh = new AsyncAutoResetEvent(true);

        internal readonly ILogger<Controllers>? Logger;
        private CancellationTokenSource? _refreshCancellationTokenSource;

        /// <summary>
        ///     Initialises a new instance of the <see cref="Controllers" /> class.
        /// </summary>
        /// <param name="logger">The logger (optional).</param>
        public Controllers(ILogger<Controllers>? logger = null)
        {
            Logger = logger;
            _controllers = new SourceCache<Controller, string>(c => c.DevicePath);

            DeviceList.Local.Changed += (sender, args) => Refresh();
            _refreshCancellationTokenSource = new CancellationTokenSource();
            var cancellationToken = _refreshCancellationTokenSource.Token;
            Task.Run(() => RefreshAsync(cancellationToken), cancellationToken)
                .ConfigureAwait(false); // Launch in background thread
            Refresh();
        }

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
                    var controllers = _controllers ?? throw new ObjectDisposedException(nameof(Controllers));
                    var existing = controllers.KeyValues.ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

                    var added = new List<Controller>();
                    var updated = new List<(Controller existing, Controller updated)>();

                    var list = DeviceList.Local;
                    foreach (var device in list.GetHidDevices())
                    {
                        if (cancellationToken.IsCancellationRequested)
                        {
                            return;
                        }

                        try
                        {
                            var rawReportDescriptor = device.GetRawReportDescriptor();
#pragma warning disable IDE0018 // Inline variable declaration - required to coerce to nullable type.
                            // ReSharper disable once InlineOutVariableDeclaration
                            Controller? existingController;
#pragma warning restore IDE0018 // Inline variable declaration
                            // Check to see if controller already exists and is unchanged.
                            if (existing.TryGetValue(device.DevicePath, out existingController))
                            {
                                if (rawReportDescriptor.SequenceEqual(existingController.RawReportDescriptor))
                                {
                                    // We found this controller, so remove from the existing list.
                                    existing.Remove(existingController.DevicePath);
                                    continue;
                                }
                            }
                            else
                            {
                                existingController = null;
                            }

                            var controller = new Controller(this, device, rawReportDescriptor);

                            // Update collection with new controller info
                            if (existingController is null)
                            {
                                added.Add(controller);
                            }
                            else
                            {
                                existing.Remove(controller.DevicePath);
                                updated.Add((existingController, controller));
                            }
                        }
#pragma warning disable CA1031 // Do not catch general exception types
                        catch (Exception exception)
                        {
                            Logger?.Log(Event.ControllerCreationFailure, exception, device);
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
                                cache.RemoveKey(kvp.Key);
                                kvp.Value.Dispose();
                                Logger?.Log(Event.ControllerRemove, kvp.Value.Name);
                            }

                            foreach (var c in added)
                            {
                                cache.AddOrUpdate(c);
                                Logger?.Log(Event.ControllerAdd, c.Name);
                            }

                            foreach (var t in updated)
                            {
                                cache.AddOrUpdate(t.updated);
                                t.existing.Dispose();
                                Logger?.Log(Event.ControllerUpdate, t.updated.Name);
                            }
                        });
                    }
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

        /// <inheritdoc />
        public IObservable<Change<Controller, string>> Watch(string key) =>
            _controllers?.Watch(key) ?? throw new ObjectDisposedException(nameof(Controllers));

        /// <inheritdoc />
        public IObservable<IChangeSet<Controller, string>> Connect(Func<Controller, bool>? predicate = null)
            => _controllers?.Connect(predicate) ?? throw new ObjectDisposedException(nameof(Controllers));

        /// <inheritdoc />
        public IObservable<IChangeSet<Controller, string>> Preview(Func<Controller, bool>? predicate = null)
            => _controllers?.Preview(predicate) ?? throw new ObjectDisposedException(nameof(Controllers));

        /// <inheritdoc />
        public IObservable<int> CountChanged
            => _controllers?.CountChanged ?? throw new ObjectDisposedException(nameof(Controllers));

        /// <inheritdoc />
        public void Dispose()
        {
            Interlocked.Exchange(ref _refreshCancellationTokenSource, null)?.Dispose();
            var controllers = Interlocked.Exchange(ref _controllers, null);
            if (controllers is null) return;
            var toDispose = controllers.Items.ToArray();
            controllers.Clear();
            controllers?.Dispose();
            foreach (var controller in toDispose) controller.Dispose();
        }

        /// <inheritdoc />
        public Optional<Controller> Lookup(string key)
            => _controllers?.Lookup(key) ?? throw new ObjectDisposedException(nameof(Controllers));

        /// <inheritdoc />
        public IEnumerable<string> Keys
            => _controllers?.Keys ?? throw new ObjectDisposedException(nameof(Controllers));

        /// <inheritdoc />
        public IEnumerable<Controller> Items
            => _controllers?.Items ?? throw new ObjectDisposedException(nameof(Controllers));

        /// <inheritdoc />
        public IEnumerable<KeyValuePair<string, Controller>> KeyValues
            => _controllers?.KeyValues ?? throw new ObjectDisposedException(nameof(Controllers));

        /// <inheritdoc />
        public int Count => _controllers?.Count ?? throw new ObjectDisposedException(nameof(Controllers));

        /// <summary>
        /// Gets a filtered observable of control changes.
        /// </summary>
        /// <param name="predicate">A function that returns <see langword="true"/> if the control should be monitored for changes; otherwise <see langword="false"/>.</param>
        /// <returns>A filtered observable of control changes.</returns>
        public IObservable<IList<ControlChange>> Watch(Func<Control, bool>? predicate = null)
            => Connect()
                .SelectMany(cs => cs)
                .Where(c => c.Reason != ChangeReason.Remove && (predicate is null || c.Current.Keys.Any(predicate)))
                .Select(c => c.Current)
                .SelectMany(c => c.Watch(predicate)
                    // Suppress errors so we don't stop listening on valid controllers - error will already have been logged.
                    .Catch((Exception ex) => Observable.Empty<IList<ControlChange>>()))
                .Where(l => l.Count > 0);

        //  predicate is null ? Connect() : Connect().Select(l => l.Where(change => predicate(change.Control)).ToList());
    }
}
