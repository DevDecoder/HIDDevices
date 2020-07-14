// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

using System;

namespace HIDDevices.Converters
{
    public class TriggerConverter : IControlConverter<double>
    {
        public TriggerConverter(bool isLeft, double centre = 0.5D, double min = 0D, double max = 1D)
        {
            if (max <= min)
            {
                throw new ArgumentOutOfRangeException(nameof(max),
                    $"The value range's max '{max}' must be greater than the minimum '{min}'.");
            }

            IsLeft = isLeft;
            Centre = centre;
            Min = min;
            Max = max;
            Range = max - min;
        }

        public bool IsLeft { get; }
        public double Centre { get; }
        public double Min { get; }
        public double Max { get; }
        public double Range { get; }

        /// <inheritdoc />
        public double ConvertTo(double value)
        {
            if (double.IsNaN(value))
            {
                return double.NaN;
            }

            if (IsLeft)
            {
                value = (value - Centre) / (1D - Centre);
            }
            else
            {
                value = (Centre - value) / Centre;
            }

            if (value < 0D)
            {
                return Min;
            }

            return Min + (value * Range);
        }
    }
}
