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
    //     Sport Controls Usage Page.
    // </summary>
    public sealed class SportControlsUsagePage : UsagePage
    {
        // <summary>
        //     Singleton instance of Sport Controls Usage Page.
        // </summary>
        public static readonly SportControlsUsagePage Instance = new();

        // <summary>
        //     Create singleton.
        // </summary>
        private SportControlsUsagePage() : base(0x0004, "Sport Controls")
        {
        }

        /// <inheritdoc />
        protected override Usage CreateUsage(ushort id)
        {
            switch (id)
            {
                case 0x0000: return new Usage(this, id, "Undefined", UsageTypes.None);
                case 0x0001: return new Usage(this, id, "Baseball Bat", UsageTypes.CA);
                case 0x0002: return new Usage(this, id, "Golf Club", UsageTypes.CA);
                case 0x0003: return new Usage(this, id, "Rowing Machine", UsageTypes.CA);
                case 0x0004: return new Usage(this, id, "Treadmill", UsageTypes.CA);
                case 0x0030: return new Usage(this, id, "Oar", UsageTypes.DV);
                case 0x0031: return new Usage(this, id, "Slope", UsageTypes.DV);
                case 0x0032: return new Usage(this, id, "Rate", UsageTypes.DV);
                case 0x0033: return new Usage(this, id, "Stick Speed", UsageTypes.DV);
                case 0x0034: return new Usage(this, id, "Stick Face Angle", UsageTypes.DV);
                case 0x0035: return new Usage(this, id, "Stick Heel/Toe", UsageTypes.DV);
                case 0x0036: return new Usage(this, id, "Stick Follow Through", UsageTypes.DV);
                case 0x0037: return new Usage(this, id, "Stick Tempo", UsageTypes.DV);
                case 0x0038: return new Usage(this, id, "Stick Type", UsageTypes.NAry);
                case 0x0039: return new Usage(this, id, "Stick Height", UsageTypes.DV);
                case 0x0050: return new Usage(this, id, "Putter", UsageTypes.Sel);
                case 0x0051: return new Usage(this, id, "1 Iron", UsageTypes.Sel);
                case 0x0052: return new Usage(this, id, "2 Iron", UsageTypes.Sel);
                case 0x0053: return new Usage(this, id, "3 Iron", UsageTypes.Sel);
                case 0x0054: return new Usage(this, id, "4 Iron", UsageTypes.Sel);
                case 0x0055: return new Usage(this, id, "5 Iron", UsageTypes.Sel);
                case 0x0056: return new Usage(this, id, "6 Iron", UsageTypes.Sel);
                case 0x0057: return new Usage(this, id, "7 Iron", UsageTypes.Sel);
                case 0x0058: return new Usage(this, id, "8 Iron", UsageTypes.Sel);
                case 0x0059: return new Usage(this, id, "9 Iron", UsageTypes.Sel);
                case 0x005a: return new Usage(this, id, "10 Iron", UsageTypes.Sel);
                case 0x005b: return new Usage(this, id, "11 Iron", UsageTypes.Sel);
                case 0x005c: return new Usage(this, id, "Sand Wedge", UsageTypes.Sel);
                case 0x005d: return new Usage(this, id, "Loft Wedge", UsageTypes.Sel);
                case 0x005e: return new Usage(this, id, "Power Wedge", UsageTypes.Sel);
                case 0x005f: return new Usage(this, id, "1 Wood", UsageTypes.Sel);
                case 0x0060: return new Usage(this, id, "3 Wood", UsageTypes.Sel);
                case 0x0061: return new Usage(this, id, "5 Wood", UsageTypes.Sel);
                case 0x0062: return new Usage(this, id, "7 Wood", UsageTypes.Sel);
                case 0x0063: return new Usage(this, id, "9 Wood", UsageTypes.Sel);
            }

            return base.CreateUsage(id);
        }
    }
}
