// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

namespace HIDDevices.Converters
{
    public sealed class BooleanConverter : IControlConverter<bool>
    {
        public static readonly BooleanConverter Instance = new BooleanConverter();

        private BooleanConverter()
        {
        }

        /// <inheritdoc />
        public bool ConvertTo(double value) => !double.IsNaN(value) && value > 0.5D;
    }
}
