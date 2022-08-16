// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

// Auto Generated at 2022-08-16 23:04:44Z.
// Specification revision: 3.3.0; generated at 2022-03-01 02:00:40Z.

#pragma warning disable CS0108 // Member hides inherited member; missing new keyword

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;

namespace DevDecoder.HIDDevices.Pages
{
    using DevDecoder.HIDDevices.Usages;

    // <summary>
    //     VR Controls Usage Page.
    // </summary>
    public sealed class VRControlsUsagePage : UsagePage
    {
        // <summary>
        //     Singleton instance of VR Controls Usage Page.
        // </summary>
        public static readonly VRControlsUsagePage Instance = new();

        // <summary>
        //     Create singleton.
        // </summary>
        private VRControlsUsagePage() : base(0x0003, "VR Controls")
        {
        }

        /// <inheritdoc />
        protected override Usage CreateUsage(ushort id)
        {
            switch (id)
            {
                case 0x0000: return new Usage(this, id, "Undefined", UsageTypes.None);
                case 0x0001: return new Usage(this, id, "Belt", UsageTypes.CA);
                case 0x0002: return new Usage(this, id, "Body Suit", UsageTypes.CA);
                case 0x0003: return new Usage(this, id, "Flexor", UsageTypes.CP);
                case 0x0004: return new Usage(this, id, "Glove", UsageTypes.CA);
                case 0x0005: return new Usage(this, id, "Head Tracker", UsageTypes.CP);
                case 0x0006: return new Usage(this, id, "Head Mounted Display", UsageTypes.CA);
                case 0x0007: return new Usage(this, id, "Hand Tracker", UsageTypes.CA);
                case 0x0008: return new Usage(this, id, "Oculometer", UsageTypes.CA);
                case 0x0009: return new Usage(this, id, "Vest", UsageTypes.CA);
                case 0x000a: return new Usage(this, id, "Animatronic Device", UsageTypes.CA);
                case 0x0020: return new Usage(this, id, "Stereo Enable", UsageTypes.OOC);
                case 0x0021: return new Usage(this, id, "Display Enable", UsageTypes.OOC);
            }

            return base.CreateUsage(id);
        }
    }
}
