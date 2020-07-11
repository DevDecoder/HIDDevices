// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;

namespace HIDControllers.Devices
{
    public partial class Device : IReadOnlyCollection<ControlChange>, IDisposable
    {
        private readonly Dictionary<string, ControlChange> _changes = new Dictionary<string, ControlChange>();

        public IReadOnlyDictionary<Control, string> Mapping { get; }
        private IDisposable? _subscription;

        protected Device(Controller controller, IReadOnlyDictionary<Control, string> mapping)
        {
            Controller = controller;
            _subscription = controller.Subscribe(OnControlChange, OnError, OnDisconnect);
            Mapping = mapping;
        }

        public long Timestamp { get; private set; }

        public Controller Controller { get; }

        public bool IsConnected => _subscription != null && Controller.IsConnected;

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

        public static bool Supports<T>(Controller controller) where T : Device
            => DeviceInfo.Get<T>()?.SupportsDevice(controller) == true;

        public static bool Supports(Controller controller, Type deviceType)
            => DeviceInfo.Get(deviceType)?.SupportsDevice(controller) == true;

        [return: MaybeNull]
        public static T Create<T>(Controller controller) where T : Device =>
            DeviceInfo.Get<T>()?.CreateDevice(controller) as T;

        public static Device? Create(Controller controller, Type deviceType) =>
            DeviceInfo.Get(deviceType)?.CreateDevice(controller);

        public static void Register<T>(
            CreateDeviceDelegate<T> createDeviceDelegate,
            SupportsDeviceDelegate? supportsDeviceDelegate = null) where T : Device
            => Register(typeof(T), createDeviceDelegate, supportsDeviceDelegate);

        public static void Register(
            Type type,
            CreateDeviceDelegate<Device> createDeviceDelegate,
            SupportsDeviceDelegate? supportsDeviceDelegate = null)
            => DeviceInfo.Register(type, createDeviceDelegate, supportsDeviceDelegate);
    }

    [return: MaybeNull]
    public delegate T CreateDeviceDelegate<out T>(Controller controller) where T : Device;

    public delegate bool SupportsDeviceDelegate(Controller controller);
}
