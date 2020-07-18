// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

using System;
using HIDDevices.Controllers;

namespace HIDDevices
{
    /// <summary>
    ///     Class RequiredAttribute. This class cannot be inherited.
    ///     Attribute to attach to properties of <seealso cref="Controller" /> that also have at least one
    ///     <seealso cref="ControlAttribute" />,
    ///     to indicate that the property must find a matching <seealso cref="Control" /> for the device to be valid.
    /// </summary>
    /// <seealso cref="Controller" />
    /// <seealso cref="ControlAttribute" />
    /// <seealso cref="Control" />
    /// <seealso cref="Attribute" />
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Class)]
    public sealed class RequiredAttribute : Attribute
    {
    }
}
