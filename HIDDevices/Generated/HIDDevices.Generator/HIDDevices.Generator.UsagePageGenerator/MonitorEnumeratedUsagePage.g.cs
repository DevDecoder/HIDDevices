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
    //     Monitor Enumerated Usage Page.
    // </summary>
    public sealed class MonitorEnumeratedUsagePage : UsagePage
    {
        // <summary>
        //     Singleton instance of Monitor Enumerated Usage Page.
        // </summary>
        public static readonly MonitorEnumeratedUsagePage Instance = new();

        // <summary>
        //     Create singleton.
        // </summary>
        private MonitorEnumeratedUsagePage() : base(0x0081, "Monitor Enumerated")
        {
        }

        /// <inheritdoc />
        protected override Usage CreateUsage(ushort id)
        {
            switch (id)
            {
                case 0x0000: return new Usage(this, id, "Undefined", UsageTypes.None);
                case 0x0001: return new Usage(this, id, "Enum 0", UsageTypes.Sel);
                case 0x0002: return new Usage(this, id, "Enum 1", UsageTypes.Sel);
                case 0x0003: return new Usage(this, id, "Enum 2", UsageTypes.Sel);
                case 0x0004: return new Usage(this, id, "Enum 3", UsageTypes.Sel);
                case 0x0005: return new Usage(this, id, "Enum 4", UsageTypes.Sel);
                case 0x0006: return new Usage(this, id, "Enum 5", UsageTypes.Sel);
                case 0x0007: return new Usage(this, id, "Enum 6", UsageTypes.Sel);
                case 0x0008: return new Usage(this, id, "Enum 7", UsageTypes.Sel);
                case 0x0009: return new Usage(this, id, "Enum 8", UsageTypes.Sel);
                case 0x000a: return new Usage(this, id, "Enum 9", UsageTypes.Sel);
                case 0x000b: return new Usage(this, id, "Enum 10", UsageTypes.Sel);
                case 0x000c: return new Usage(this, id, "Enum 11", UsageTypes.Sel);
                case 0x000d: return new Usage(this, id, "Enum 12", UsageTypes.Sel);
                case 0x000e: return new Usage(this, id, "Enum 13", UsageTypes.Sel);
                case 0x000f: return new Usage(this, id, "Enum 14", UsageTypes.Sel);
                case 0x0010: return new Usage(this, id, "Enum 15", UsageTypes.Sel);
            }
            var n = (ushort)(id-0x0001);
            if (id >= 0x0011 || id <= 0xffff) return new Usage(this, id, $"Enum {n}", UsageTypes.Sel);

            return base.CreateUsage(id);
        }
    }
}
