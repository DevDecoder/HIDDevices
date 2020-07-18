// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

using System;

namespace HIDDevices.Converters
{
    /// <summary>
    ///     Class RangeConverter converts control values to a range. This class cannot be inherited.
    ///     Implements the <see cref="IControlConverter{T}" /> interface.
    /// </summary>
    /// <seealso cref="IControlConverter{T}" />
    /// .
    public class RangeConverter : IControlConverter<double>
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="RangeConverter" /> class.
        /// </summary>
        /// <param name="outputMinimum">The minimum.</param>
        /// <param name="outputMaximum">The maximum.</param>
        /// <param name="inputMinimum">The input minimum.</param>
        /// <param name="inputMaximum">The input maximum.</param>
        /// <exception cref="ArgumentOutOfRangeException">outputMaximum</exception>
        public RangeConverter(
            double outputMinimum, 
            double outputMaximum, 
            double inputMinimum = 0D,
            double inputMaximum = 1D)
        {
            if (inputMaximum < 0D)
            {
                inputMinimum = 0D;
            }
            else if (inputMinimum > 1D)
            {
                inputMinimum = 1D;
            }

            if (inputMaximum < 0D)
            {
                inputMaximum = 0D;
            }
            else if (inputMaximum > 1D)
            {
                inputMaximum = 1D;
            }

            if (inputMaximum < inputMinimum)
            {
                // Flip both input and output ranges so input range always has min<max.
                var swap = inputMinimum;
                inputMinimum = inputMaximum;
                inputMaximum = swap;

                swap = outputMinimum;
                outputMinimum = outputMaximum;
                outputMaximum = swap;
            }

            InputMinimum = inputMinimum;
            InputMaximum = inputMaximum;
            InputRange = inputMaximum - inputMinimum;

            OutputMinimum = outputMinimum;
            OutputMaximum = outputMaximum;
            OutputRange = outputMaximum - outputMinimum;
        }

        /// <summary>
        ///     Gets the input minimum.
        /// </summary>
        /// <value>The input minimum.</value>
        public double InputMinimum { get; }

        /// <summary>
        ///     Gets the input maximum.
        /// </summary>
        /// <value>The input maximum.</value>
        public double InputMaximum { get; }

        /// <summary>
        ///     Gets the input range.
        /// </summary>
        /// <value>The input range.</value>
        public double InputRange { get; }

        /// <summary>
        ///     Gets the output minimum.
        /// </summary>
        /// <value>The output minimum.</value>
        public double OutputMinimum { get; }

        /// <summary>
        ///     Gets the output maximum.
        /// </summary>
        /// <value>The output maximum.</value>
        public double OutputMaximum { get; }

        /// <summary>
        ///     Gets the output range.
        /// </summary>
        /// <value>The output range.</value>
        public double OutputRange { get; }

        /// <inheritdoc />
        public double Convert(double value)
        {
            if (double.IsNaN(value))
            {
                return double.NaN;
            }

            if (value <= InputMinimum)
            {
                return OutputMinimum;
            }

            if (value >= InputMaximum)
            {
                return OutputMaximum;
            }

            return OutputMinimum + (((value - InputMinimum) / InputRange) * OutputRange);
        }
    }
}
