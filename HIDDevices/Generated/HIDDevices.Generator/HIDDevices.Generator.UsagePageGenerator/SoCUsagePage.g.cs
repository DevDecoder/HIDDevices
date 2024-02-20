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
    //     SoC Usage Page.
    // </summary>
    public sealed class SoCUsagePage : UsagePage
    {
        // <summary>
        //     Singleton instance of SoC Usage Page.
        // </summary>
        public static readonly SoCUsagePage Instance = new();

        // <summary>
        //     Create singleton.
        // </summary>
        private SoCUsagePage() : base(0x0011, "SoC")
        {
        }

        /// <inheritdoc />
        protected override Usage CreateUsage(ushort id)
        {
            switch (id)
            {
                case 0x0000: return new Usage(this, id, "Undefined", UsageTypes.None);
                case 0x0001: return new Usage(this, id, "SocControl", UsageTypes.CA);
                case 0x0002: return new Usage(this, id, "FirmwareTransfer", UsageTypes.CL);
                case 0x0003: return new Usage(this, id, "FirmwareFileId", UsageTypes.DV);
                case 0x0004: return new Usage(this, id, "FileOffsetInBytes", UsageTypes.DV);
                case 0x0005: return new Usage(this, id, "FileTransferSizeMaxInBytes", UsageTypes.DV);
                case 0x0006: return new Usage(this, id, "FilePayload", UsageTypes.DV);
                case 0x0007: return new Usage(this, id, "FilePayloadSizeInBytes", UsageTypes.DV);
                case 0x0008: return new Usage(this, id, "FilePayloadContainsLastBytes", UsageTypes.DF);
                case 0x0009: return new Usage(this, id, "FileTransferStop", UsageTypes.DF);
                case 0x000a: return new Usage(this, id, "FileTransferTillEnd", UsageTypes.DF);
            }

            return base.CreateUsage(id);
        }
    }
}
