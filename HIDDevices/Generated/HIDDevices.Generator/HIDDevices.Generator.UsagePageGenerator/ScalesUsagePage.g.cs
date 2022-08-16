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
    //     Scales Usage Page.
    // </summary>
    public sealed class ScalesUsagePage : UsagePage
    {
        // <summary>
        //     Singleton instance of Scales Usage Page.
        // </summary>
        public static readonly ScalesUsagePage Instance = new();

        // <summary>
        //     Create singleton.
        // </summary>
        private ScalesUsagePage() : base(0x008d, "Scales")
        {
        }

        /// <inheritdoc />
        protected override Usage CreateUsage(ushort id)
        {
            switch (id)
            {
                case 0x0000: return new Usage(this, id, "Undefined", UsageTypes.None);
                case 0x0001: return new Usage(this, id, "Scales", UsageTypes.CA);
                case 0x0020: return new Usage(this, id, "Scale Device", UsageTypes.CL);
                case 0x0021: return new Usage(this, id, "Scale Class", UsageTypes.NAry);
                case 0x0022: return new Usage(this, id, "Scale Class I Metric", UsageTypes.Sel);
                case 0x0023: return new Usage(this, id, "Scale Class II Metric", UsageTypes.Sel);
                case 0x0024: return new Usage(this, id, "Scale Class III Metric", UsageTypes.Sel);
                case 0x0025: return new Usage(this, id, "Scale Class IIIL Metric", UsageTypes.Sel);
                case 0x0026: return new Usage(this, id, "Scale Class IV Metric", UsageTypes.Sel);
                case 0x0027: return new Usage(this, id, "Scale Class III English", UsageTypes.Sel);
                case 0x0028: return new Usage(this, id, "Scale Class IIIL English", UsageTypes.Sel);
                case 0x0029: return new Usage(this, id, "Scale Class IV English", UsageTypes.Sel);
                case 0x002a: return new Usage(this, id, "Scale Class Generic", UsageTypes.Sel);
                case 0x0030: return new Usage(this, id, "Scale Attribute Report", UsageTypes.CL);
                case 0x0031: return new Usage(this, id, "Scale Control Report", UsageTypes.CL);
                case 0x0032: return new Usage(this, id, "Scale Data Report", UsageTypes.CL);
                case 0x0033: return new Usage(this, id, "Scale Status Report", UsageTypes.CL);
                case 0x0034: return new Usage(this, id, "Scale Weight Limit Report", UsageTypes.CL);
                case 0x0035: return new Usage(this, id, "Scale Statistics Report", UsageTypes.CL);
                case 0x0040: return new Usage(this, id, "Data Weight", UsageTypes.DV);
                case 0x0041: return new Usage(this, id, "Data Scaling", UsageTypes.DV);
                case 0x0050: return new Usage(this, id, "Weight Unit", UsageTypes.CL);
                case 0x0051: return new Usage(this, id, "Weight Unit Milligram", UsageTypes.Sel);
                case 0x0052: return new Usage(this, id, "Weight Unit Gram", UsageTypes.Sel);
                case 0x0053: return new Usage(this, id, "Weight Unit Kilogram", UsageTypes.Sel);
                case 0x0054: return new Usage(this, id, "Weight Unit Carats", UsageTypes.Sel);
                case 0x0055: return new Usage(this, id, "Weight Unit Taels", UsageTypes.Sel);
                case 0x0056: return new Usage(this, id, "Weight Unit Grains", UsageTypes.Sel);
                case 0x0057: return new Usage(this, id, "Weight Unit Pennyweights", UsageTypes.Sel);
                case 0x0058: return new Usage(this, id, "Weight Unit Metric Ton", UsageTypes.Sel);
                case 0x0059: return new Usage(this, id, "Weight Unit Avoir Ton", UsageTypes.Sel);
                case 0x005a: return new Usage(this, id, "Weight Unit Troy Ounce", UsageTypes.Sel);
                case 0x005b: return new Usage(this, id, "Weight Unit Ounce", UsageTypes.Sel);
                case 0x005c: return new Usage(this, id, "Weight Unit Pound", UsageTypes.Sel);
                case 0x0060: return new Usage(this, id, "Calibration Count", UsageTypes.DV);
                case 0x0061: return new Usage(this, id, "Re-Zero Count", UsageTypes.DV);
                case 0x0070: return new Usage(this, id, "Scale Status", UsageTypes.NAry);
                case 0x0071: return new Usage(this, id, "Scale Status Fault", UsageTypes.Sel);
                case 0x0072: return new Usage(this, id, "Scale Status Stable at Center of Zero", UsageTypes.Sel);
                case 0x0073: return new Usage(this, id, "Scale Status In Motion", UsageTypes.Sel);
                case 0x0074: return new Usage(this, id, "Scale Status Weight Stable", UsageTypes.Sel);
                case 0x0075: return new Usage(this, id, "Scale Status Under Zero", UsageTypes.Sel);
                case 0x0076: return new Usage(this, id, "Scale Status Over Weight Limit", UsageTypes.Sel);
                case 0x0077: return new Usage(this, id, "Scale Status Requires Calibration", UsageTypes.Sel);
                case 0x0078: return new Usage(this, id, "Scale Status Requires Rezeroing", UsageTypes.Sel);
                case 0x0080: return new Usage(this, id, "Zero Scale", UsageTypes.OOC);
                case 0x0081: return new Usage(this, id, "Enforced Zero Return", UsageTypes.OOC);
            }

            return base.CreateUsage(id);
        }
    }
}
