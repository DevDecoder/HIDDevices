// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

namespace HIDDevices.Converters
{
    public class RightTriggerConverter : TriggerConverter
    {
        public static readonly RightTriggerConverter Instance = new RightTriggerConverter();

        public RightTriggerConverter() : base(false)
        {
        }
    }
}
