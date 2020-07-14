// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

namespace HIDDevices.Converters
{
    public class LeftTriggerConverter : TriggerConverter
    {
        public static readonly LeftTriggerConverter Instance = new LeftTriggerConverter();

        public LeftTriggerConverter() : base(true)
        {
        }
    }
}
