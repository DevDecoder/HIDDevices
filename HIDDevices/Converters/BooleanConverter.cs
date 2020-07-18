// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

namespace HIDDevices.Converters
{
    /// <summary>
    ///     Class BooleanConverter converts control values to a boolean. This class cannot be inherited.
    ///     Implements the <see cref="IControlConverter{T}" /> interface.
    /// </summary>
    /// <seealso cref="IControlConverter{T}" />
    /// .
    public sealed class BooleanConverter : IControlConverter<bool>
    {
        /// <summary>
        ///     The singleton instance of the converter.
        /// </summary>
        public static readonly BooleanConverter Instance = new BooleanConverter();

        private BooleanConverter()
        {
        }

        /// <inheritdoc />
        public bool Convert(double value) => !double.IsNaN(value) && value > 0.5D;
    }
}
