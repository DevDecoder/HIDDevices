// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

using System;
using System.Diagnostics.CodeAnalysis;
using HIDDevices.Controllers;

namespace HIDDevices.Converters
{
    /// <summary>
    ///     Interface IControlConverter defines an interface for <see cref="Control" /> value conversion to
    ///     <see cref="Controller" /> property values.
    /// </summary>
    /// <seealso cref="Control" />
    /// <seealso cref="Controller" />
    public interface IControlConverter
    {
        /// <summary>
        ///     Gets the support property type.
        /// </summary>
        /// <value>The property type.</value>
        Type Type { get; }

        /// <summary>
        ///     Method to convert a <see cref="Control" /> value to a <see cref="Controller">Controller's</see> property value.
        /// </summary>
        /// <param name="value">The control value.</param>
        /// <returns>The property value.</returns>
        object? Convert(double value);
    }

    /// <summary>
    ///     Interface IControlConverter defines an interface for <see cref="Control" /> value conversion to
    ///     <see cref="Controller" /> property values.
    /// </summary>
    /// <typeparam name="T">The property type</typeparam>
    /// <seealso cref="HIDDevices.Converters.IControlConverter" />
    /// <seealso cref="Control" />
    /// <seealso cref="Controller" />
    public interface IControlConverter<out T> : IControlConverter
    {
        /// <inheritdoc />
        Type IControlConverter.Type => typeof(T);

        /// <inheritdoc />
        object? IControlConverter.Convert(double value) => Convert(value);

        /// <summary>
        ///     Method to convert a <see cref="Control" /> value to a <see cref="Controller">Controller's</see> property value.
        /// </summary>
        /// <param name="value">The control value.</param>
        /// <returns>The property value.</returns>
        [return: MaybeNull]
        new T Convert(double value);
    }
}
