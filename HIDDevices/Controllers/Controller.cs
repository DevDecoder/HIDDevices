// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reactive.Subjects;
using System.Runtime.CompilerServices;
using System.Threading;
using HIDDevices.Converters;

namespace HIDDevices.Controllers
{
    public partial class Controller : IReadOnlyCollection<ControlValue>, IDisposable
    {
        private static readonly ConcurrentDictionary<Type, IControlConverter> s_defaultConverters =
            new ConcurrentDictionary<Type, IControlConverter>();

        private readonly ConcurrentDictionary<string, ControlValue> _values =
            new ConcurrentDictionary<string, ControlValue>();

        public readonly IReadOnlyDictionary<Control, IReadOnlyList<ControlInfo>> Mapping;
        private IDisposable? _subscription;
        private Subject<IList<ControlValue>>? _valuesSubject;

        static Controller() =>
            // Register a default converter to boolean.
            s_defaultConverters[typeof(bool)] = BooleanConverter.Instance;

        protected Controller(Device device, params ControlInfo[] controls)
        {
            Device = device;
            Mapping = controls.GroupBy(c => c.Control)
                .ToDictionary(g => g.Key, g => (IReadOnlyList<ControlInfo>)g.ToArray());
            _valuesSubject = new Subject<IList<ControlValue>>();
        }

        public void Connect()
        {
            // Create a new subscription, disposing any existing one.
            Interlocked.Exchange(ref _subscription,  Device.Subscribe(OnControlChange, OnError, OnDisconnect))?.Dispose();
        }

        public IEnumerable Controls => Mapping.Values;

        public long Timestamp { get; private set; }

        public Device Device { get; }

        public string Name => Device.Name;

        public bool IsConnected => _subscription != null && Device.IsConnected;

        /// <inheritdoc />
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public IObservable<IList<ControlValue>> Changes => _valuesSubject ?? throw new ObjectDisposedException(Name);

        /// <inheritdoc />
        public IEnumerator<ControlValue> GetEnumerator() => _values.Values.GetEnumerator();

        /// <inheritdoc />
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        /// <inheritdoc />
        public int Count => _values.Count;

        public bool IsMapped(string propertyName) =>
            Mapping.Values
                .SelectMany(list => list)
                .Any(controlInfo => string.Equals(controlInfo.PropertyName, propertyName));

        protected T GetValue<T>([CallerMemberName] string? propertyName = null)
        {
            if (!_values.TryGetValue(propertyName!, out var controlValue))
            {
                return default!;
            }

            if (!typeof(T).IsAssignableFrom(controlValue.Type))
            {
                throw new InvalidOperationException(
                    $"The {propertyName} is expecting a value of type '{typeof(T)}' but has a value of type '{controlValue.Type}'.");
            }

            var value = controlValue.Value;
            return value is null ? default! : (T)value;
        }

        protected virtual void OnDisconnect()
        {
            Interlocked.Exchange(ref _subscription, null)?.Dispose();
        }

        protected virtual void OnError(Exception exception)
        {
            Interlocked.Exchange(ref _subscription, null)?.Dispose();
        }

        protected virtual void OnControlChange(IList<ControlChange> changes)
        {
            var valueChanges = new List<ControlValue>(changes.Count);
            foreach (var change in changes)
            {
                if (!Mapping.TryGetValue(change.Control, out var list))
                {
                    continue;
                }

                foreach (var controlInfo in list)
                {
                    object? value;
                    // Find converter, or get default converter
                    var converter = controlInfo.Converter;
                    if (converter is null && !s_defaultConverters.TryGetValue(controlInfo.Type, out converter))
                    {
                        if (controlInfo.Type != typeof(double))
                        {
                            throw new InvalidOperationException(
                                $"The {controlInfo.PropertyName} is expecting a value of type '{controlInfo.Type}' but there is no default converter registered for that type, nor explicit converter supplied.");
                        }

                        // We can accept a double directly
                        value = change.Value;
                    }
                    else
                    {
                        value = converter.ConvertTo(change.Value);
                    }

                    var controlValue = new ControlValue(change, controlInfo, value);
                    _values[controlInfo.PropertyName] = controlValue;

                    if (change.Timestamp > Timestamp)
                    {
                        Timestamp = change.Timestamp;
                    }

                    valueChanges.Add(controlValue);
                }
            }

            if (valueChanges.Count > 0)
                _valuesSubject?.OnNext(valueChanges.ToArray());
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                Interlocked.Exchange(ref _subscription, null)?.Dispose();
                Interlocked.Exchange(ref _valuesSubject, null)?.Dispose();
            }
        }

        public IReadOnlyList<ControlValue> ChangesSince(long timestamp)
            => timestamp < Timestamp
                ? _values.Values.Where(c => c.Timestamp > timestamp).ToArray()
                : Array.Empty<ControlValue>();

        [return: MaybeNull]
        public static T Create<T>(Device device) where T : Controller =>
            ControllerInfo.Get<T>()?.CreateController(device) as T;

        public static Controller? Create(Device device, Type deviceType) =>
            ControllerInfo.Get(deviceType)?.CreateController(device);

        public static void Register<T>(CreateControllerDelegate<T> createControllerDelegate) where T : Controller?
            => Register(typeof(T), createControllerDelegate);

        public static void Register(
            Type type,
            CreateControllerDelegate<Controller?> createControllerDelegate)
            => ControllerInfo.Register(type, createControllerDelegate);

        public static void RegisterDefaultTypeConverter(IControlConverter converter)
        {
            var type = Array.Find(
                    converter.GetType().GetInterfaces(),
                    i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IControlConverter<>))
                ?.GetGenericArguments()
                ?.First();
            if (type is null)
            {
                throw new ArgumentOutOfRangeException(nameof(converter),
                    "The supplied converter must implement IControlConverter<>");
            }

            s_defaultConverters[type] = converter;
        }
    }
}
