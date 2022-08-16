// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reactive.Subjects;
using System.Runtime.CompilerServices;
using System.Threading;
using BooleanConverter = DevDecoder.HIDDevices.Converters.BooleanConverter;

namespace DevDecoder.HIDDevices.Controllers;

/// <summary>
///     Class Controller is a collection of controls mapped to properties.
///     Implements the <see cref="IReadOnlyCollection{T}" /> interface.
///     Implements the <see cref="IDisposable" /> interface.
/// </summary>
/// <seealso cref="IReadOnlyCollection{T}" />
/// <seealso cref="IDisposable" />
public partial class Controller : IReadOnlyCollection<ControlValue>, IDisposable
{
    private static readonly ConcurrentDictionary<Type, TypeConverter> s_defaultConverters = new();

    private readonly ConcurrentDictionary<string, ControlValue> _values = new();

    /// <summary>
    ///     The mapping of <seealso cref="Control" /> to associated <see cref="ControlInfo">ControlInfos</see>.
    /// </summary>
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

    /// <summary>
    ///     Gets the controls associated with this controller.
    /// </summary>
    /// <value>The controls.</value>
    public IEnumerable Controls => Mapping.Values;

    /// <summary>
    ///     Gets the timestamp of the last update received from the controller.
    /// </summary>
    /// <value>The timestamp.</value>
    public long Timestamp { get; private set; }

    /// <summary>
    ///     Gets the associated device.
    /// </summary>
    /// <value>The device.</value>
    public Device Device { get; }

    /// <summary>
    ///     Gets the name.
    /// </summary>
    /// <value>The name.</value>
    public string Name => Device.Name;

    /// <summary>
    ///     Gets an observable of the device's connection state.
    /// </summary>
    /// <value>
    ///     An observable of the device's connection state, which returns <see langword="true" /> when connecting and
    ///     <see langword="false" /> when disconnecting.
    /// </value>
    public IObservable<bool> ConnectionState => Device.ConnectionState;

    /// <summary>
    ///     Gets a value indicating whether this controller is connected.
    /// </summary>
    /// <value><see langword="true" /> if this controller is connected; otherwise, <see langword="false" />.</value>
    public bool IsConnected => _subscription != null && Device.IsConnected;

    /// <summary>
    ///     Gets an observable of changes.
    /// </summary>
    /// <value>The changes.</value>
    /// <exception cref="ObjectDisposedException">The controller is disposed.</exception>
    public IObservable<IList<ControlValue>> Changes => _valuesSubject ?? throw new ObjectDisposedException(Name);

    /// <inheritdoc />
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    /// <inheritdoc />
    public IEnumerator<ControlValue> GetEnumerator() => _values.Values.GetEnumerator();

    /// <inheritdoc />
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    /// <inheritdoc />
    public int Count => _values.Count;

    /// <summary>
    ///     Connects to the controller and starts listening for changes.
    /// </summary>
    public void Connect() =>
        // Create a new subscription, disposing any existing one.
        Interlocked.Exchange(ref _subscription, Device.Subscribe(OnControlChange, OnError, OnDisconnect))
            ?.Dispose();

    /// <summary>
    ///     Determines whether the <see cref="propertyName">specified property</see> is mapped to a control.
    /// </summary>
    /// <param name="propertyName">Name of the property.</param>
    /// <returns>
    ///     <see langword="true" /> if the <see cref="propertyName">specified property</see> is mapped; otherwise,
    ///     <see langword="false" />.
    /// </returns>
    public bool IsMapped(string propertyName) =>
        Mapping.Values
            .SelectMany(list => list)
            .Any(controlInfo => string.Equals(controlInfo.PropertyName, propertyName));

    /// <summary>
    ///     Gets the value for the <see cref="propertyName">specified property</see>.
    /// </summary>
    /// <typeparam name="T">The property type.</typeparam>
    /// <param name="propertyName">Name of the property.</param>
    /// <returns>The current value.</returns>
    /// <exception cref="InvalidOperationException">An invalid property type was specified.</exception>
    protected T GetValue<T>([CallerMemberName] string? propertyName = null)
    {
        if (!_values.TryGetValue(propertyName!, out var controlValue))
        {
            return default!;
        }

        if (!typeof(T).IsAssignableFrom(controlValue.Type))
        {
            throw new InvalidOperationException(string.Format(Resources.ControllerInvalidPropertyType, propertyName,
                typeof(T), controlValue.Type));
        }

        var value = controlValue.Value;
        return value is null ? default! : (T)value;
    }

    /// <summary>
    ///     Called when the controller is disconnected.
    /// </summary>
    protected virtual void OnDisconnect() => Interlocked.Exchange(ref _subscription, null)?.Dispose();

    /// <summary>
    ///     Called when an error is raised by the underlying connection.
    /// </summary>
    /// <param name="exception">The exception.</param>
    protected virtual void OnError(Exception exception) => Interlocked.Exchange(ref _subscription, null)?.Dispose();

    /// <summary>
    ///     Called when a control's value changes.
    /// </summary>
    /// <param name="changes">The changes.</param>
    /// <exception cref="InvalidOperationException">No converter was found for a control.</exception>
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
                var converter = controlInfo.Converter ??
                                (s_defaultConverters.TryGetValue(controlInfo.Type, out var defaultConverter)
                                    ? defaultConverter
                                    : null);

                if (converter is null)
                {
                    // Attempt to get valid TypeConverter
                    converter = TypeDescriptor.GetConverter(controlInfo.Type);
                    if (!converter.CanConvertFrom(typeof(double)))
                    {
                        converter = null;
                    }
                }

                if (converter is null)
                {
                    if (!controlInfo.Type.IsAssignableFrom(typeof(double)))
                    {
                        throw new InvalidOperationException(
                            string.Format(
                                Resources.ControllerMissingConverter,
                                controlInfo.PropertyName, controlInfo.Type));
                    }

                    // We can accept a double directly
                    value = change.Value;
                }
                else
                {
                    value = converter.ConvertFrom(change.Value);
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
        {
            _valuesSubject?.OnNext(valueChanges.ToArray());
        }
    }

    /// <summary>
    ///     Releases unmanaged and - optionally - managed resources.
    /// </summary>
    /// <param name="disposing">
    ///     <see langword="true" /> to release both managed and unmanaged resources;
    ///     <see langword="false" /> to release only unmanaged resources.
    /// </param>
    protected virtual void Dispose(bool disposing)
    {
        if (disposing)
        {
            Interlocked.Exchange(ref _subscription, null)?.Dispose();
            Interlocked.Exchange(ref _valuesSubject, null)?.Dispose();
        }
    }

    /// <summary>
    ///     Gets all changes that have occurred since the <see cref="timestamp">specified timestamp</see>.
    /// </summary>
    /// <param name="timestamp">The timestamp.</param>
    /// <returns>A collection of changes.</returns>
    public IReadOnlyList<ControlValue> ChangesSince(long timestamp)
        => timestamp < Timestamp
            ? _values.Values.Where(c => c.Timestamp > timestamp).ToArray()
            : Array.Empty<ControlValue>();

    /// <summary>
    ///     Creates a controller from the <see cref="device">specified device</see>, if possible.
    /// </summary>
    /// <typeparam name="T">The controller type</typeparam>
    /// <param name="device">
    ///     The device if it supports the <see cref="T">specified controller type</see>; otherwise
    ///     <see langword="null" />.
    /// </param>
    /// <returns>A controller; or <see langword="null" />.</returns>
    [return: MaybeNull]
    public static T Create<T>(Device device) where T : Controller =>
        ControllerInfo.Get<T>()?.CreateController(device) as T;

    /// <summary>
    ///     Creates a controller from the <see cref="device">specified device</see>, if possible.
    /// </summary>
    /// <param name="device">
    ///     The device if it supports the <see cref="deviceType">specified controller type</see>; otherwise
    ///     <see langword="null" />.
    /// </param>
    /// <param name="deviceType">Type of the device.</param>
    /// <returns>A controller; or <see langword="null" />.</returns>
    public static Controller? Create(Device device, Type deviceType) =>
        ControllerInfo.Get(deviceType)?.CreateController(device);

    /// <summary>
    ///     Registers a control creation delegate which creates controls for the <see cref="T">specified controller type</see>.
    /// </summary>
    /// <typeparam name="T">The controller type.</typeparam>
    /// <param name="createControllerDelegate">The create controller delegate.</param>
    public static void Register<T>(CreateControllerDelegate<T> createControllerDelegate) where T : Controller?
        => Register(typeof(T), createControllerDelegate);

    /// <summary>
    ///     Registers a control creation delegate which creates controls for the
    ///     <see cref="type">specified controller type</see>.
    /// </summary>
    /// <param name="type">The controller type.</param>
    /// <param name="createControllerDelegate">The create controller delegate.</param>
    public static void Register(
        Type type,
        CreateControllerDelegate<Controller?> createControllerDelegate)
        => ControllerInfo.Register(type, createControllerDelegate);

    /// <summary>
    ///     Registers a default type converter used for converting control values to property values.
    /// </summary>
    /// <param name="type">The type.</param>
    /// <param name="converter">The converter.</param>
    /// <exception cref="ArgumentOutOfRangeException">The supplied converter must implement IControlConverter&lt;&gt;</exception>
    public static void RegisterDefaultTypeConverter(Type type, TypeConverter converter) =>
        s_defaultConverters[type] = converter;
}
