// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

using System;
using System.Globalization;

namespace HIDDevices.Converters
{
    /// <summary>
    ///     Class BooleanConverter converts control values to a boolean. This class cannot be inherited.
    ///     Implements <see cref="ControlConverter{T}" />.
    /// </summary>
    public sealed class BooleanConverter : ControlConverter<bool>
    {
        /// <summary>
        ///     The singleton instance of the converter.
        /// </summary>
        public static readonly BooleanConverter Instance = new BooleanConverter();

        private BooleanConverter()
        {
        }

        /// <inheritdoc />
        protected override bool Convert(CultureInfo culture, double value) => !double.IsNaN(value) && value > 0.5D;
    }
}
