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
    //     Camera Control Usage Page.
    // </summary>
    public sealed class CameraControlUsagePage : UsagePage
    {
        // <summary>
        //     Singleton instance of Camera Control Usage Page.
        // </summary>
        public static readonly CameraControlUsagePage Instance = new();

        // <summary>
        //     Create singleton.
        // </summary>
        private CameraControlUsagePage() : base(0x0090, "Camera Control")
        {
        }

        /// <inheritdoc />
        protected override Usage CreateUsage(ushort id)
        {
            switch (id)
            {
                case 0x0000: return new Usage(this, id, "Undefined", UsageTypes.None);
                case 0x0020: return new Usage(this, id, "Camera Auto-focus", UsageTypes.OSC);
                case 0x0021: return new Usage(this, id, "Camera Shutter", UsageTypes.OSC);
            }

            return base.CreateUsage(id);
        }
    }
}
