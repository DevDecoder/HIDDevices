// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

using System;
using System.ComponentModel;
using System.Globalization;

namespace DevDecoder.HIDDevices.Converters;

/// <summary>
///     Class ControlConverter.
///     Implements the <see cref="TypeConverter" />
///     Used to conveniently create control converters.
/// </summary>
/// <typeparam name="T">The type of control property.</typeparam>
/// <seealso cref="TypeConverter" />
public abstract class ControlConverter<T> : TypeConverter
{
    /// <inheritdoc />
    public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) =>
        sourceType == typeof(double) || base.CanConvertFrom(context, sourceType);

    /// <inheritdoc />
    public override object? ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        => value is double dv
            ? Convert(context, culture, dv)
            : base.ConvertFrom(context, culture, value);

    /// <summary>
    ///     Converts the value to the <see cref="T">specified type.</see>.
    /// </summary>
    /// <param name="context">The context.</param>
    /// <param name="culture">The culture.</param>
    /// <param name="value">The value.</param>
    /// <returns>The value.</returns>
    protected virtual T? Convert(ITypeDescriptorContext context, CultureInfo culture, double value) =>
        base.ConvertFrom(context, culture, value) is T v ? v : default;
}
