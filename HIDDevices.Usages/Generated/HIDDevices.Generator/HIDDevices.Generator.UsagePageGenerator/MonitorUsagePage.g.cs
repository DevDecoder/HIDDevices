// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

// Specification revision: 1.5.0; generated at 2024-01-08 23:33:15Z.

#pragma warning disable CS0108 // Member hides inherited member; missing new keyword

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;

namespace DevDecoder.HIDDevices.Pages
{
    using DevDecoder.HIDDevices.Usages;

    // <summary>
    //     Monitor Usage Page.
    // </summary>
    public sealed class MonitorUsagePage : UsagePage
    {
        // <summary>
        //     Singleton instance of Monitor Usage Page.
        // </summary>
        public static readonly MonitorUsagePage Instance = new();

        // <summary>
        //     Create singleton.
        // </summary>
        private MonitorUsagePage() : base(0x0080, "Monitor")
        {
        }

        /// <inheritdoc />
        protected override Usage CreateUsage(ushort id)
        {
            switch (id)
            {
                case 0x0000: return new Usage(this, id, "Undefined", UsageTypes.None);
                case 0x0001: return new Usage(this, id, "Monitor Control", UsageTypes.CA);
                case 0x0002: return new Usage(this, id, "EDID Information", UsageTypes.SV);
                case 0x0003: return new Usage(this, id, "VDIF Information", UsageTypes.SV);
                case 0x0004: return new Usage(this, id, "VESA Version", UsageTypes.SV);
            }

            return base.CreateUsage(id);
        }
    }
}
