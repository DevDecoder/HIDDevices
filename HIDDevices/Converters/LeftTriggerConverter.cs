// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

using System;

namespace HIDDevices.Converters
{
    /// <summary>
    ///     Class LeftTriggerConverter converts control values for trigger properties. This class cannot be inherited.
    ///     Implements the <see cref="ControlConverter{T}" />.
    /// </summary>
    /// <seealso cref="ControlConverter{T}" />
    /// <seealso cref="RangeConverter" />
    public sealed class LeftTriggerConverter : RangeConverter
    {
        /// <summary>
        ///     The singleton instance of the converter.
        /// </summary>
        public static readonly LeftTriggerConverter Instance = new LeftTriggerConverter();

        private LeftTriggerConverter() : base(0D, 1D, 0.5D)
        {
        }
    }
}
