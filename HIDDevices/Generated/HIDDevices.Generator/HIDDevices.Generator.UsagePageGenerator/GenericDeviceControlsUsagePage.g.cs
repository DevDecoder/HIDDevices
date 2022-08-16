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
    //     Generic Device Controls Usage Page.
    // </summary>
    public sealed class GenericDeviceControlsUsagePage : UsagePage
    {
        // <summary>
        //     Singleton instance of Generic Device Controls Usage Page.
        // </summary>
        public static readonly GenericDeviceControlsUsagePage Instance = new();

        // <summary>
        //     Create singleton.
        // </summary>
        private GenericDeviceControlsUsagePage() : base(0x0006, "Generic Device Controls")
        {
        }

        /// <inheritdoc />
        protected override Usage CreateUsage(ushort id)
        {
            switch (id)
            {
                case 0x0000: return new Usage(this, id, "Undefined", UsageTypes.None);
                case 0x0001: return new Usage(this, id, "Background/Nonuser Controls", UsageTypes.CA);
                case 0x0020: return new Usage(this, id, "Battery Strength", UsageTypes.DV);
                case 0x0021: return new Usage(this, id, "Wireless Channel", UsageTypes.DV);
                case 0x0022: return new Usage(this, id, "Wireless ID", UsageTypes.DV);
                case 0x0023: return new Usage(this, id, "Discover Wireless Control", UsageTypes.OSC);
                case 0x0024: return new Usage(this, id, "Security Code Character Entered", UsageTypes.OSC);
                case 0x0025: return new Usage(this, id, "Security Code Character Erased", UsageTypes.OSC);
                case 0x0026: return new Usage(this, id, "Security Code Cleared", UsageTypes.OSC);
                case 0x0027: return new Usage(this, id, "Sequence ID", UsageTypes.DV);
                case 0x0028: return new Usage(this, id, "Sequence ID Reset", UsageTypes.DF);
                case 0x0029: return new Usage(this, id, "RF Signal Strength", UsageTypes.DV);
                case 0x002a: return new Usage(this, id, "Software Version", UsageTypes.CL);
                case 0x002b: return new Usage(this, id, "Protocol Version", UsageTypes.CL);
                case 0x002c: return new Usage(this, id, "Hardware Version", UsageTypes.CL);
                case 0x002d: return new Usage(this, id, "Major", UsageTypes.SV);
                case 0x002e: return new Usage(this, id, "Minor", UsageTypes.SV);
                case 0x002f: return new Usage(this, id, "Revision", UsageTypes.SV);
                case 0x0030: return new Usage(this, id, "Handedness", UsageTypes.NAry);
                case 0x0031: return new Usage(this, id, "Either Hand", UsageTypes.Sel);
                case 0x0032: return new Usage(this, id, "Left Hand", UsageTypes.Sel);
                case 0x0033: return new Usage(this, id, "Right Hand", UsageTypes.Sel);
                case 0x0034: return new Usage(this, id, "Both Hands", UsageTypes.Sel);
                case 0x0040: return new Usage(this, id, "Grip Pose Offset", UsageTypes.CP);
                case 0x0041: return new Usage(this, id, "Pointer Pose Offset", UsageTypes.CP);
            }

            return base.CreateUsage(id);
        }
    }
}
