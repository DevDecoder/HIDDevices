// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

namespace HIDDevices.Converters
{
    public sealed class SignedConverter : RangeConverter
    {
        public static readonly SignedConverter Instance = new SignedConverter();

        private SignedConverter() : base(-1D, 1D)
        {
        }
    }
}
