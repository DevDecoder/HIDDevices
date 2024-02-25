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
    //     Lighting And Illumination Usage Page.
    // </summary>
    public sealed class LightingAndIlluminationUsagePage : UsagePage
    {
        // <summary>
        //     Singleton instance of Lighting And Illumination Usage Page.
        // </summary>
        public static readonly LightingAndIlluminationUsagePage Instance = new();

        // <summary>
        //     Create singleton.
        // </summary>
        private LightingAndIlluminationUsagePage() : base(0x0059, "Lighting And Illumination")
        {
        }

        /// <inheritdoc />
        protected override Usage CreateUsage(ushort id)
        {
            switch (id)
            {
                case 0x0000: return new Usage(this, id, "Undefined", UsageTypes.None);
                case 0x0001: return new Usage(this, id, "LampArray", UsageTypes.CA);
                case 0x0002: return new Usage(this, id, "LampArrayAttributesReport", UsageTypes.CL);
                case 0x0003: return new Usage(this, id, "LampCount", UsageTypes.SV|UsageTypes.DV);
                case 0x0004: return new Usage(this, id, "BoundingBoxWidthInMicrometers", UsageTypes.SV);
                case 0x0005: return new Usage(this, id, "BoundingBoxHeightInMicrometers", UsageTypes.SV);
                case 0x0006: return new Usage(this, id, "BoundingBoxDepthInMicrometers", UsageTypes.SV);
                case 0x0007: return new Usage(this, id, "LampArrayKind", UsageTypes.SV);
                case 0x0008: return new Usage(this, id, "MinUpdateIntervalInMicroseconds", UsageTypes.SV);
                case 0x0020: return new Usage(this, id, "LampAttributesRequestReport", UsageTypes.CL);
                case 0x0021: return new Usage(this, id, "LampId", UsageTypes.SV|UsageTypes.DV);
                case 0x0022: return new Usage(this, id, "LampAttributesResponseReport", UsageTypes.CL);
                case 0x0023: return new Usage(this, id, "PositionXInMicrometers", UsageTypes.DV);
                case 0x0024: return new Usage(this, id, "PositionYInMicrometers", UsageTypes.DV);
                case 0x0025: return new Usage(this, id, "PositionZInMicrometers", UsageTypes.DV);
                case 0x0026: return new Usage(this, id, "LampPurposes", UsageTypes.DV);
                case 0x0027: return new Usage(this, id, "UpdateLatencyInMicroseconds", UsageTypes.DV);
                case 0x0028: return new Usage(this, id, "RedLevelCount", UsageTypes.DV);
                case 0x0029: return new Usage(this, id, "GreenLevelCount", UsageTypes.DV);
                case 0x002a: return new Usage(this, id, "BlueLevelCount", UsageTypes.DV);
                case 0x002b: return new Usage(this, id, "IntensityLevelCount", UsageTypes.DV);
                case 0x002c: return new Usage(this, id, "IsProgrammable", UsageTypes.DV);
                case 0x002d: return new Usage(this, id, "InputBinding", UsageTypes.DV);
                case 0x0050: return new Usage(this, id, "LampMultiUpdateReport", UsageTypes.CL);
                case 0x0051: return new Usage(this, id, "RedUpdateChannel", UsageTypes.DV);
                case 0x0052: return new Usage(this, id, "GreenUpdateChannel", UsageTypes.DV);
                case 0x0053: return new Usage(this, id, "BlueUpdateChannel", UsageTypes.DV);
                case 0x0054: return new Usage(this, id, "IntensityUpdateChannel", UsageTypes.DV);
                case 0x0055: return new Usage(this, id, "LampUpdateFlags", UsageTypes.DV);
                case 0x0060: return new Usage(this, id, "LampRangeUpdateReport", UsageTypes.CL);
                case 0x0061: return new Usage(this, id, "LampIdStart", UsageTypes.DV);
                case 0x0062: return new Usage(this, id, "LampIdEnd", UsageTypes.DV);
                case 0x0070: return new Usage(this, id, "LampArrayControlReport", UsageTypes.CL);
                case 0x0071: return new Usage(this, id, "AutonomousMode", UsageTypes.DV);
            }

            return base.CreateUsage(id);
        }
    }
}
