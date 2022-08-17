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
    //     Magnetic Stripe Reader Usage Page.
    // </summary>
    public sealed class MagneticStripeReaderUsagePage : UsagePage
    {
        // <summary>
        //     Singleton instance of Magnetic Stripe Reader Usage Page.
        // </summary>
        public static readonly MagneticStripeReaderUsagePage Instance = new();

        // <summary>
        //     Create singleton.
        // </summary>
        private MagneticStripeReaderUsagePage() : base(0x008e, "Magnetic Stripe Reader")
        {
        }

        /// <inheritdoc />
        protected override Usage CreateUsage(ushort id)
        {
            switch (id)
            {
                case 0x0000: return new Usage(this, id, "Undefined", UsageTypes.None);
                case 0x0001: return new Usage(this, id, "MSR Device Read-Only", UsageTypes.CA);
                case 0x0011: return new Usage(this, id, "Track 1 Length", UsageTypes.DV);
                case 0x0012: return new Usage(this, id, "Track 2 Length", UsageTypes.DV);
                case 0x0013: return new Usage(this, id, "Track 3 Length", UsageTypes.DV);
                case 0x0014: return new Usage(this, id, "Track JIS Length", UsageTypes.DV);
                case 0x0020: return new Usage(this, id, "Track Data", UsageTypes.SF|UsageTypes.DF|UsageTypes.DV);
                case 0x0021: return new Usage(this, id, "Track 1 Data", UsageTypes.SF|UsageTypes.DF|UsageTypes.DV);
                case 0x0022: return new Usage(this, id, "Track 2 Data", UsageTypes.SF|UsageTypes.DF|UsageTypes.DV);
                case 0x0023: return new Usage(this, id, "Track 3 Data", UsageTypes.SF|UsageTypes.DF|UsageTypes.DV);
                case 0x0024: return new Usage(this, id, "Track JIS Data", UsageTypes.SF|UsageTypes.DF|UsageTypes.DV);
            }

            return base.CreateUsage(id);
        }
    }
}
