// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

using System;
using System.ComponentModel;
using System.Diagnostics;

namespace DevDecoder.HIDDevices.Controllers;

/// <summary>
///     Struct ControlValue holds the latest value of a <see cref="HIDDevices.Control" /> for a
///     <seealso cref="Controller" />.
/// </summary>
/// <seealso cref="Controller" />
/// <seealso cref="HIDDevices.Control" />
/// <seealso cref="ControlChange" />
/// <seealso cref="IEquatable{T}" />
public readonly struct ControlValue : IEquatable<ControlValue>
{
    internal ControlValue(ControlChange change, ControlInfo info, object? value)
    {
        Debug.Assert(ReferenceEquals(change.Control, info.Control));
        Change = change;
        Info = info;
        Value = value;
    }

    /// <summary>
    ///     Gets the type.
    /// </summary>
    /// <value>The type.</value>
    public Type Type => Info.Type;

    /// <summary>
    ///     Gets the name of the property.
    /// </summary>
    /// <value>The name of the property.</value>
    public string PropertyName => Info.PropertyName;

    /// <summary>
    ///     Gets the control.
    /// </summary>
    /// <value>The control.</value>
    public Control Control => Info.Control;

    /// <summary>
    ///     Gets the timestamp.
    /// </summary>
    /// <value>The timestamp.</value>
    public long Timestamp => Change.Timestamp;

    /// <summary>
    ///     Gets the elapsed.
    /// </summary>
    /// <value>The elapsed.</value>
    public TimeSpan Elapsed => Change.Elapsed;

    /// <summary>
    ///     Gets the converter.
    /// </summary>
    /// <value>The converter.</value>
    public TypeConverter? Converter => Info.Converter;

    /// <summary>
    ///     Gets the change.
    /// </summary>
    /// <value>The change.</value>
    public ControlChange Change { get; }

    /// <summary>
    ///     Gets the control information.
    /// </summary>
    /// <value>The control information.</value>
    public ControlInfo Info { get; }

    /// <summary>
    ///     Gets the value.
    /// </summary>
    /// <value>The value.</value>
    public object? Value { get; }

    /// <inheritdoc />
    public bool Equals(ControlValue other) =>
        Change.Equals(other.Change) && Info.Equals(other.Info) && Equals(Value, other.Value);

    /// <inheritdoc />
    public override bool Equals(object? obj) => obj is ControlValue other && Equals(other);

    /// <inheritdoc />
    public override int GetHashCode() => HashCode.Combine(Change, Info, Value);

    /// <summary>
    ///     Implements the == operator.
    /// </summary>
    /// <param name="left">The left.</param>
    /// <param name="right">The right.</param>
    /// <returns>The result of the operator.</returns>
    public static bool operator ==(ControlValue left, ControlValue right) => left.Equals(right);

    /// <summary>
    ///     Implements the != operator.
    /// </summary>
    /// <param name="left">The left.</param>
    /// <param name="right">The right.</param>
    /// <returns>The result of the operator.</returns>
    public static bool operator !=(ControlValue left, ControlValue right) => !left.Equals(right);
}
