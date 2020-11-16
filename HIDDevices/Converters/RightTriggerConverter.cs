// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

using System;

namespace DevDecoder.HIDDevices.Converters
{
    /// <summary>
    ///     Class RightTriggerConverter converts control values for trigger properties. This class cannot be inherited.
    ///     Implements the <see cref="ControlConverter{T}" />.
    /// </summary>
    /// <seealso cref="ControlConverter{T}" />
    /// <seealso cref="RangeConverter" />
    public sealed class RightTriggerConverter : RangeConverter
    {
        /// <summary>
        ///     The singleton instance of the converter.
        /// </summary>
        public static readonly RightTriggerConverter Instance = new RightTriggerConverter();

        public RightTriggerConverter() : base(0D, 1D, 0.5D, 0D)
        {
        }
    }
}
