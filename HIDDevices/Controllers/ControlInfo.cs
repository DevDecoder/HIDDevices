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
public class ControlInfo
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="ControlInfo" /> class.
    /// </summary>
    /// <param name="type">The type of the property.</param>
    /// <param name="propertyName">Name of the property.</param>
    /// <param name="control">The control.</param>
    /// <param name="converter">The converter.</param>
    public ControlInfo(Type type, string propertyName, Control control, TypeConverter? converter)
    {
        Type = type;
        PropertyName = propertyName;
        Control = control;
        Converter = converter;
    }

    /// <summary>
    ///     Gets the type.
    /// </summary>
    /// <value>The type.</value>
    public Type Type { get; }

    /// <summary>
    ///     Gets the name of the property.
    /// </summary>
    /// <value>The name of the property.</value>
    public string PropertyName { get; }

    /// <summary>
    ///     Gets the control.
    /// </summary>
    /// <value>The control.</value>
    public Control Control { get; }

    /// <summary>
    ///     Gets the converter.
    /// </summary>
    /// <value>The converter.</value>
    public TypeConverter? Converter { get; }
}

/// <summary>
///     Class ControlInfo. This class cannot be inherited.
///     Generic version of <seealso cref="ControlInfo" /> for conveniently defining control infos.
/// </summary>
/// <typeparam name="T">The property type.</typeparam>
/// <seealso cref="ControlInfo" />
public sealed class ControlInfo<T> : ControlInfo
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="ControlInfo{T}" /> class.
    /// </summary>
    /// <param name="propertyName">Name of the property.</param>
    /// <param name="control">The control.</param>
    /// <param name="converter">The converter.</param>
    public ControlInfo(string propertyName, Control control, TypeConverter? converter)
        : base(typeof(T), propertyName, control, converter)
    {
    }
}
