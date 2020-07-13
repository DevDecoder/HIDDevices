// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;

namespace HIDDevices
{
    public partial class Controller : IReadOnlyCollection<ControlChange>, IDisposable
    {
        private readonly Dictionary<string, ControlChange> _changes = new Dictionary<string, ControlChange>();

        public IReadOnlyDictionary<Control, string> Mapping { get; }
        private IDisposable? _subscription;

        protected Controller(Device device, IReadOnlyDictionary<Control, string> mapping)
        {
            Device = device;
            _subscription = device.Subscribe(OnControlChange, OnError, OnDisconnect);
            Mapping = mapping;
        }

        public long Timestamp { get; private set; }

        public Device Device { get; }

        public bool IsConnected => _subscription != null && Device.IsConnected;

        public bool IsMapped(string propertyName) => Mapping.Values.Any(v => string.Equals(v, propertyName));

        /// <inheritdoc />
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <inheritdoc />
        public IEnumerator<ControlChange> GetEnumerator() => _changes.Values.GetEnumerator();

        /// <inheritdoc />
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        /// <inheritdoc />
        public int Count => _changes.Count;

        protected ControlChange GetChange([CallerMemberName] string? propertyName = null)
            => _changes.TryGetValue(propertyName!, out var change) ? change : default;

        protected virtual void OnDisconnect() => Dispose();

        protected virtual void OnError(Exception exception) => Dispose();

        protected virtual void OnControlChange(IList<ControlChange> changes)
        {
            foreach (var change in changes)
            {
                if (!Mapping.TryGetValue(change.Control, out var index))
                {
                    continue;
                }

                _changes[index] = change;
                if (change.Timestamp > Timestamp)
                {
                    Timestamp = change.Timestamp;
                }
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                Interlocked.Exchange(ref _subscription, null)?.Dispose();
            }
        }

        public IEnumerable<ControlChange> ChangesSince(long timestamp)
            => timestamp < Timestamp
                ? _changes.Values.Where(c => c.Timestamp > timestamp)
                : Enumerable.Empty<ControlChange>();

        public static bool Supports<T>(Device device) where T : Controller
            => ControllerInfo.Get<T>()?.SupportsController(device) == true;

        public static bool Supports(Device device, Type deviceType)
            => ControllerInfo.Get(deviceType)?.SupportsController(device) == true;

        [return: MaybeNull]
        public static T Create<T>(Device device) where T : Controller =>
            ControllerInfo.Get<T>()?.CreateController(device) as T;

        public static Controller? Create(Device device, Type deviceType) =>
            ControllerInfo.Get(deviceType)?.CreateController(device);

        public static void Register<T>(
            CreateControllerDelegate<T> createControllerDelegate,
            SupportsControllerDelegate? supportsControllerDelegate = null) where T : Controller
            => Register(typeof(T), createControllerDelegate, supportsControllerDelegate);

        public static void Register(
            Type type,
            CreateControllerDelegate<Controller> createControllerDelegate,
            SupportsControllerDelegate? supportsControllerDelegate = null)
            => ControllerInfo.Register(type, createControllerDelegate, supportsControllerDelegate);
    }

    [return: MaybeNull]
    public delegate T CreateControllerDelegate<out T>(Device controller) where T : Controller;

    public delegate bool SupportsControllerDelegate(Device controller);
}
