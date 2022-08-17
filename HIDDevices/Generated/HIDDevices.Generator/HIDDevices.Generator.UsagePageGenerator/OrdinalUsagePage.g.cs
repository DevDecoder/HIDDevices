// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

// Specification revision: 1.3.0; generated at 2022-03-01 02:00:40Z.

#pragma warning disable CS0108 // Member hides inherited member; missing new keyword

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;

namespace DevDecoder.HIDDevices.Pages
{
    using DevDecoder.HIDDevices.Usages;

    // <summary>
    //     Ordinal Usage Page.
    // </summary>
    public sealed class OrdinalUsagePage : UsagePage
    {
        // <summary>
        //     Singleton instance of Ordinal Usage Page.
        // </summary>
        public static readonly OrdinalUsagePage Instance = new();

        // <summary>
        //     Create singleton.
        // </summary>
        private OrdinalUsagePage() : base(0x000a, "Ordinal")
        {
        }

        /// <inheritdoc />
        protected override Usage CreateUsage(ushort id)
        {
            switch (id)
            {
                case 0x0000: return new Usage(this, id, "Undefined", UsageTypes.None);
                case 0x0001: return new Usage(this, id, "Instance 0", UsageTypes.UM);
                case 0x0002: return new Usage(this, id, "Instance 1", UsageTypes.UM);
                case 0x0003: return new Usage(this, id, "Instance 2", UsageTypes.UM);
                case 0x0004: return new Usage(this, id, "Instance 3", UsageTypes.UM);
                case 0x0005: return new Usage(this, id, "Instance 4", UsageTypes.UM);
                case 0x0006: return new Usage(this, id, "Instance 5", UsageTypes.UM);
                case 0x0007: return new Usage(this, id, "Instance 6", UsageTypes.UM);
                case 0x0008: return new Usage(this, id, "Instance 7", UsageTypes.UM);
                case 0x0009: return new Usage(this, id, "Instance 8", UsageTypes.UM);
                case 0x000a: return new Usage(this, id, "Instance 9", UsageTypes.UM);
                case 0x000b: return new Usage(this, id, "Instance 10", UsageTypes.UM);
                case 0x000c: return new Usage(this, id, "Instance 11", UsageTypes.UM);
                case 0x000d: return new Usage(this, id, "Instance 12", UsageTypes.UM);
                case 0x000e: return new Usage(this, id, "Instance 13", UsageTypes.UM);
                case 0x000f: return new Usage(this, id, "Instance 14", UsageTypes.UM);
                case 0x0010: return new Usage(this, id, "Instance 15", UsageTypes.UM);
            }
            var n = (ushort)(id-0x0001);
            if (id >= 0x0011 || id <= 0xffff) return new Usage(this, id, $"Instance {n}", UsageTypes.UM);

            return base.CreateUsage(id);
        }
    }
}
