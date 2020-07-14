// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

using System;

namespace HIDDevices.Converters
{
    public sealed class DirectionConverter : IControlConverter<Direction>
    {
        public static readonly DirectionConverter Instance = new DirectionConverter();

        private DirectionConverter()
        {
        }

        /// <inheritdoc />
        public Direction ConvertTo(double value) => double.IsNaN(value)
            ? Direction.NotPressed
            : (Direction)Math.Clamp((int)Math.Round(value * 7.0), 0, 7);
    }
}
