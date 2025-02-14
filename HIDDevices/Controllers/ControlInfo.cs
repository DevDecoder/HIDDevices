// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

using System;
using System.ComponentModel;

namespace DevDecoder.HIDDevices.Controllers;

/// <summary>
///     Class ControlInfo is used to indicate the relationship between a <seealso cref="HIDDevices.Control" /> and a
///     property on a <seealso cref="Controller" />.  These are normally generated automatically, but can be created
///     manually when creating a custom controller.
/// </summary>
/// <seealso cref="Controller" />
/// <seealso cref="HIDDevices.Control" />
/// <remarks>
///     Initializes a new instance of the <see cref="ControlInfo" /> class.
/// </remarks>
/// <param name="type">The type of the property.</param>
/// <param name="propertyName">Name of the property.</param>
/// <param name="control">The control.</param>
/// <param name="converter">The converter.</param>
public class ControlInfo(Type type, string propertyName, Control control, TypeConverter? converter)
{

    /// <summary>
    ///     Gets the type.
    /// </summary>
    /// <value>The type.</value>
    public Type Type { get; } = type;

    /// <summary>
    ///     Gets the name of the property.
    /// </summary>
    /// <value>The name of the property.</value>
    public string PropertyName { get; } = propertyName;

    /// <summary>
    ///     Gets the control.
    /// </summary>
    /// <value>The control.</value>
    public Control Control { get; } = control;

    /// <summary>
    ///     Gets the converter.
    /// </summary>
    /// <value>The converter.</value>
    public TypeConverter? Converter { get; } = converter;
}

/// <summary>
///     Class ControlInfo. This class cannot be inherited.
///     Generic version of <seealso cref="ControlInfo" /> for conveniently defining control infos.
/// </summary>
/// <typeparam name="T">The property type.</typeparam>
/// <seealso cref="ControlInfo" />
/// <remarks>
///     Initializes a new instance of the <see cref="ControlInfo{T}" /> class.
/// </remarks>
/// <param name="propertyName">Name of the property.</param>
/// <param name="control">The control.</param>
/// <param name="converter">The converter.</param>
public sealed class ControlInfo<T>(string propertyName, Control control, TypeConverter? converter) : ControlInfo(typeof(T), propertyName, control, converter)
{
}
