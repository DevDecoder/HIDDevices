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
    //     FIDO Alliance Usage Page.
    // </summary>
    public sealed class FIDOAllianceUsagePage : UsagePage
    {
        // <summary>
        //     Singleton instance of FIDO Alliance Usage Page.
        // </summary>
        public static readonly FIDOAllianceUsagePage Instance = new();

        // <summary>
        //     Create singleton.
        // </summary>
        private FIDOAllianceUsagePage() : base(0xf1d0, "FIDO Alliance")
        {
        }

        /// <inheritdoc />
        protected override Usage CreateUsage(ushort id)
        {
            switch (id)
            {
                case 0x0000: return new Usage(this, id, "Undefined", UsageTypes.None);
                case 0x0001: return new Usage(this, id, "U2F Authenticator Device", UsageTypes.CA);
                case 0x0020: return new Usage(this, id, "Input Report Data", UsageTypes.DV);
                case 0x0021: return new Usage(this, id, "Output Report Data", UsageTypes.DV);
            }

            return base.CreateUsage(id);
        }
    }
}
