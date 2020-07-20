// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

using System;

namespace HIDDevices.Converters
{
    /// <summary>
    ///     Class SignedConverter converts control values to a property value between -1 and 1, centred on 0. This class cannot
    ///     be inherited.
    ///     Implements the <see cref="IControlConverter{T}" /> interface.
    /// </summary>
    /// <seealso cref="IControlConverter{T}" />
    /// <seealso cref="RangeConverter" />
    public sealed class SignedConverter : RangeConverter
    {
        /// <summary>
        ///     The singleton instance of the converter.
        /// </summary>
        public static readonly SignedConverter Instance = new SignedConverter();

        private SignedConverter() : base(-1D, 1D)
        {
        }
    }
}
