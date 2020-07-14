// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

using System;

namespace HIDDevices.Converters
{
    public class RangeConverter : IControlConverter<double>
    {
        public RangeConverter(double min, double max)
        {
            if (max <= min)
            {
                throw new ArgumentOutOfRangeException(nameof(max),
                    $"The value range's max '{max}' must be greater than the minimum '{min}'.");
            }

            Min = min;
            Max = max;
            Range = max - min;
        }

        public double Min { get; }
        public double Max { get; }
        public double Range { get; }

        /// <inheritdoc />
        public double ConvertTo(double value) => double.IsNaN(value)
            ? double.NaN
            : Min + (value * Range);
    }
}
