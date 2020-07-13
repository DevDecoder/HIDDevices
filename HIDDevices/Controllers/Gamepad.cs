// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using HIDDevices.Usages;

namespace HIDDevices
{
    [Device((uint)GenericDesktopPage.GamePad, Required = true)]
    public class Gamepad : Controller
    {
        /// <inheritdoc />
        protected Gamepad(Device device, IReadOnlyDictionary<Control, string> mapping)
            : base(device, mapping)
        {
        }

        [ControlProperty((uint)GenericDesktopPage.X, Required = true)]
        public ControlChange X => GetChange();

        [ControlProperty((uint)GenericDesktopPage.Y, Required = true)]
        public ControlChange Y => GetChange();

        [ControlProperty((uint)GenericDesktopPage.Rx)]
        public ControlChange Rx => GetChange();

        [ControlProperty((uint)GenericDesktopPage.Ry)]
        public ControlChange Ry => GetChange();

        [ControlProperty((uint)GenericDesktopPage.Rz)]
        public ControlChange Rz => GetChange();

        [ControlProperty((uint)GenericDesktopPage.Start, (uint)ButtonPage.Button8)]
        public ControlChange Start => GetChange();

        [ControlProperty((uint)GenericDesktopPage.Select)]
        public ControlChange Select => GetChange();

        [ControlProperty((uint)ButtonPage.Button1, Required = true)]
        public ControlChange Button1 => GetChange();

        [ControlProperty((uint)ButtonPage.Button2)]
        public ControlChange Button2 => GetChange();

        [ControlProperty((uint)ButtonPage.Button3)]
        public ControlChange Button3 => GetChange();

        [ControlProperty((uint)ButtonPage.Button4)]
        public ControlChange Button4 => GetChange();

        [ControlProperty((uint)ButtonPage.Button5)]
        public ControlChange Button5 => GetChange();

        [ControlProperty((uint)ButtonPage.Button6)]
        public ControlChange Button6 => GetChange();

        [ControlProperty((uint)ButtonPage.Button7)]
        public ControlChange Button7 => GetChange();

        [ControlProperty((uint)ButtonPage.Button8)]
        public ControlChange Button8 => GetChange();

        [ControlProperty((uint)ButtonPage.Button9)]
        public ControlChange Button9 => GetChange();

        [ControlProperty((uint)ButtonPage.Button10)]
        public ControlChange Button10 => GetChange();

        [ControlProperty((uint)GenericDesktopPage.HatSwitch)]
        public ControlChange Hat => GetChange();
    }
}
