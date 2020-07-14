// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

using HIDDevices.Converters;
using HIDDevices.Usages;

namespace HIDDevices.Controllers
{
    [Device((uint)GenericDesktopPage.GamePad)]
    [Required]
    public class Gamepad : Controller
    {
        /// <inheritdoc />
        protected Gamepad(Device device, params ControlInfo[] controls)
            : base(device, controls)
        {
        }

        [Control((uint)GenericDesktopPage.X)]
        [Required]
        [Converter(typeof(SignedConverter))]
        public double X => GetValue<double>();

        [Control((uint)GenericDesktopPage.Y)]
        [Required]
        [Converter(typeof(SignedConverter))]
        public double Y => GetValue<double>();

        [Control((uint)GenericDesktopPage.Rx)]
        [Converter(typeof(SignedConverter))]
        public double Rx => GetValue<double>();

        [Control((uint)GenericDesktopPage.Ry)]
        [Converter(typeof(SignedConverter))]
        public double Ry => GetValue<double>();

        [Control((uint)GenericDesktopPage.Start, Weight = 2)]
        [Control((uint)ButtonPage.Button8)]
        public bool Start => GetValue<bool>();

        [Control((uint)GenericDesktopPage.Select, Weight = 2)]
        [Control((uint)ButtonPage.Button7)]
        public bool Select => GetValue<bool>();

        [Control((uint)GenericDesktopPage.Z)]
        [Converter(typeof(LeftTriggerConverter))]
        public double LeftTrigger => GetValue<double>();

        [Control((uint)GenericDesktopPage.Z)]
        [Converter(typeof(RightTriggerConverter))]
        public double RightTrigger => GetValue<double>();

        [Control((uint)ButtonPage.Button1)]
        [Required]
        public bool AButton => GetValue<bool>();

        [Control((uint)ButtonPage.Button2)] public bool BButton => GetValue<bool>();

        [Control((uint)ButtonPage.Button3)] public bool XButton => GetValue<bool>();

        [Control((uint)ButtonPage.Button4)] public bool YButton => GetValue<bool>();

        [Control((uint)ButtonPage.Button5)] public bool LeftButton => GetValue<bool>();

        [Control((uint)ButtonPage.Button6)] public bool RightButton => GetValue<bool>();

        [Control((uint)ButtonPage.Button9)] public bool LeftStick => GetValue<bool>();
        [Control((uint)ButtonPage.Button10)] public bool RightStick => GetValue<bool>();

        [Control((uint)GenericDesktopPage.HatSwitch)]
        [Converter(typeof(DirectionConverter))]
        public Direction Hat => GetValue<Direction>();
    }
}
