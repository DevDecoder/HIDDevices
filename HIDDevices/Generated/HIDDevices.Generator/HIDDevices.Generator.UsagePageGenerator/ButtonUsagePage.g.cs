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
    //     Button Usage Page.
    // </summary>
    public sealed class ButtonUsagePage : UsagePage
    {
        // <summary>
        //     Singleton instance of Button Usage Page.
        // </summary>
        public static readonly ButtonUsagePage Instance = new();

        // <summary>
        //     Create singleton.
        // </summary>
        private ButtonUsagePage() : base(0x0009, "Button")
        {
        }

        /// <inheritdoc />
        protected override Usage CreateUsage(ushort id)
        {
            switch (id)
            {
                case 0x0000: return new Usage(this, id, "Undefined", UsageTypes.None);
                case 0x0001: return new Usage(this, id, "Button 0", UsageTypes.Sel|UsageTypes.OOC|UsageTypes.MC|UsageTypes.OSC);
                case 0x0002: return new Usage(this, id, "Button 1", UsageTypes.Sel|UsageTypes.OOC|UsageTypes.MC|UsageTypes.OSC);
                case 0x0003: return new Usage(this, id, "Button 2", UsageTypes.Sel|UsageTypes.OOC|UsageTypes.MC|UsageTypes.OSC);
                case 0x0004: return new Usage(this, id, "Button 3", UsageTypes.Sel|UsageTypes.OOC|UsageTypes.MC|UsageTypes.OSC);
                case 0x0005: return new Usage(this, id, "Button 4", UsageTypes.Sel|UsageTypes.OOC|UsageTypes.MC|UsageTypes.OSC);
                case 0x0006: return new Usage(this, id, "Button 5", UsageTypes.Sel|UsageTypes.OOC|UsageTypes.MC|UsageTypes.OSC);
                case 0x0007: return new Usage(this, id, "Button 6", UsageTypes.Sel|UsageTypes.OOC|UsageTypes.MC|UsageTypes.OSC);
                case 0x0008: return new Usage(this, id, "Button 7", UsageTypes.Sel|UsageTypes.OOC|UsageTypes.MC|UsageTypes.OSC);
                case 0x0009: return new Usage(this, id, "Button 8", UsageTypes.Sel|UsageTypes.OOC|UsageTypes.MC|UsageTypes.OSC);
                case 0x000a: return new Usage(this, id, "Button 9", UsageTypes.Sel|UsageTypes.OOC|UsageTypes.MC|UsageTypes.OSC);
                case 0x000b: return new Usage(this, id, "Button 10", UsageTypes.Sel|UsageTypes.OOC|UsageTypes.MC|UsageTypes.OSC);
                case 0x000c: return new Usage(this, id, "Button 11", UsageTypes.Sel|UsageTypes.OOC|UsageTypes.MC|UsageTypes.OSC);
                case 0x000d: return new Usage(this, id, "Button 12", UsageTypes.Sel|UsageTypes.OOC|UsageTypes.MC|UsageTypes.OSC);
                case 0x000e: return new Usage(this, id, "Button 13", UsageTypes.Sel|UsageTypes.OOC|UsageTypes.MC|UsageTypes.OSC);
                case 0x000f: return new Usage(this, id, "Button 14", UsageTypes.Sel|UsageTypes.OOC|UsageTypes.MC|UsageTypes.OSC);
                case 0x0010: return new Usage(this, id, "Button 15", UsageTypes.Sel|UsageTypes.OOC|UsageTypes.MC|UsageTypes.OSC);
            }
            var n = (ushort)(id-0x0001);
            if (id >= 0x0011 || id <= 0xffff) return new Usage(this, id, $"Button {n}", UsageTypes.Sel|UsageTypes.OOC|UsageTypes.MC|UsageTypes.OSC);

            return base.CreateUsage(id);
        }
    }
}
