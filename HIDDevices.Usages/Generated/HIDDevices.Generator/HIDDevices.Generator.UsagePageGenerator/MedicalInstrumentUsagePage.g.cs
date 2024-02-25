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
    //     Medical Instrument Usage Page.
    // </summary>
    public sealed class MedicalInstrumentUsagePage : UsagePage
    {
        // <summary>
        //     Singleton instance of Medical Instrument Usage Page.
        // </summary>
        public static readonly MedicalInstrumentUsagePage Instance = new();

        // <summary>
        //     Create singleton.
        // </summary>
        private MedicalInstrumentUsagePage() : base(0x0040, "Medical Instrument")
        {
        }

        /// <inheritdoc />
        protected override Usage CreateUsage(ushort id)
        {
            switch (id)
            {
                case 0x0000: return new Usage(this, id, "Undefined", UsageTypes.None);
                case 0x0001: return new Usage(this, id, "Medical Ultrasound", UsageTypes.CA);
                case 0x0020: return new Usage(this, id, "VCR/Acquisition", UsageTypes.OOC);
                case 0x0021: return new Usage(this, id, "Freeze/Thaw", UsageTypes.OOC);
                case 0x0022: return new Usage(this, id, "Clip Store", UsageTypes.OSC);
                case 0x0023: return new Usage(this, id, "Update", UsageTypes.OSC);
                case 0x0024: return new Usage(this, id, "Next", UsageTypes.OSC);
                case 0x0025: return new Usage(this, id, "Save", UsageTypes.OSC);
                case 0x0026: return new Usage(this, id, "Print", UsageTypes.OSC);
                case 0x0027: return new Usage(this, id, "Microphone Enable", UsageTypes.OSC);
                case 0x0040: return new Usage(this, id, "Cine", UsageTypes.LC);
                case 0x0041: return new Usage(this, id, "Transmit Power", UsageTypes.LC);
                case 0x0042: return new Usage(this, id, "Volume", UsageTypes.LC);
                case 0x0043: return new Usage(this, id, "Focus", UsageTypes.LC);
                case 0x0044: return new Usage(this, id, "Depth", UsageTypes.LC);
                case 0x0060: return new Usage(this, id, "Soft Step - Primary", UsageTypes.LC);
                case 0x0061: return new Usage(this, id, "Soft Step - Secondary", UsageTypes.LC);
                case 0x0070: return new Usage(this, id, "Depth Gain Compensation", UsageTypes.LC);
                case 0x0080: return new Usage(this, id, "Zoom Select", UsageTypes.OSC);
                case 0x0081: return new Usage(this, id, "Zoom Adjust", UsageTypes.LC);
                case 0x0082: return new Usage(this, id, "Spectral Doppler Mode Select", UsageTypes.OSC);
                case 0x0083: return new Usage(this, id, "Spectral Doppler Adjust", UsageTypes.LC);
                case 0x0084: return new Usage(this, id, "Color Doppler Mode Select", UsageTypes.OSC);
                case 0x0085: return new Usage(this, id, "Color Doppler Adjust", UsageTypes.LC);
                case 0x0086: return new Usage(this, id, "Motion Mode Select", UsageTypes.OSC);
                case 0x0087: return new Usage(this, id, "Motion Mode Adjust", UsageTypes.LC);
                case 0x0088: return new Usage(this, id, "2-D Mode Select", UsageTypes.OSC);
                case 0x0089: return new Usage(this, id, "2-D Mode Adjust", UsageTypes.LC);
                case 0x00a0: return new Usage(this, id, "Soft Control Select", UsageTypes.OSC);
                case 0x00a1: return new Usage(this, id, "Soft Control Adjust", UsageTypes.LC);
            }

            return base.CreateUsage(id);
        }
    }
}
