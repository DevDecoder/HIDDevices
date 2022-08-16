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
    //     Battery System Usage Page.
    // </summary>
    public sealed class BatterySystemUsagePage : UsagePage
    {
        // <summary>
        //     Singleton instance of Battery System Usage Page.
        // </summary>
        public static readonly BatterySystemUsagePage Instance = new();

        // <summary>
        //     Create singleton.
        // </summary>
        private BatterySystemUsagePage() : base(0x0085, "Battery System")
        {
        }

        /// <inheritdoc />
        protected override Usage CreateUsage(ushort id)
        {
            switch (id)
            {
                case 0x0000: return new Usage(this, id, "Undefined", UsageTypes.None);
                case 0x0001: return new Usage(this, id, "Smart Battery Battery Mode", UsageTypes.CL);
                case 0x0002: return new Usage(this, id, "Smart Battery Battery Status", UsageTypes.NAry);
                case 0x0003: return new Usage(this, id, "Smart Battery Alarm Warning", UsageTypes.NAry);
                case 0x0004: return new Usage(this, id, "Smart Battery Charger Mode", UsageTypes.CL);
                case 0x0005: return new Usage(this, id, "Smart Battery Charger Status", UsageTypes.CL);
                case 0x0006: return new Usage(this, id, "Smart Battery Charger Spec Info", UsageTypes.CL);
                case 0x0007: return new Usage(this, id, "Smart Battery Selector State", UsageTypes.CL);
                case 0x0008: return new Usage(this, id, "Smart Battery Selector Presets", UsageTypes.CL);
                case 0x0009: return new Usage(this, id, "Smart Battery Selector Info", UsageTypes.CL);
                case 0x0010: return new Usage(this, id, "Optional Mfg Function 1", UsageTypes.DV);
                case 0x0011: return new Usage(this, id, "Optional Mfg Function 2", UsageTypes.DV);
                case 0x0012: return new Usage(this, id, "Optional Mfg Function 3", UsageTypes.DV);
                case 0x0013: return new Usage(this, id, "Optional Mfg Function 4", UsageTypes.DV);
                case 0x0014: return new Usage(this, id, "Optional Mfg Function 5", UsageTypes.DV);
                case 0x0015: return new Usage(this, id, "Connection To SM Bus", UsageTypes.DF);
                case 0x0016: return new Usage(this, id, "Output Connection", UsageTypes.DF);
                case 0x0017: return new Usage(this, id, "Charger Connection", UsageTypes.DF);
                case 0x0018: return new Usage(this, id, "Battery Insertion", UsageTypes.DF);
                case 0x0019: return new Usage(this, id, "Use Next", UsageTypes.DF);
                case 0x001a: return new Usage(this, id, "OK To Use", UsageTypes.DF);
                case 0x001b: return new Usage(this, id, "Battery Supported", UsageTypes.DF);
                case 0x001c: return new Usage(this, id, "Selector Revision", UsageTypes.DF);
                case 0x001d: return new Usage(this, id, "Charging Indicator", UsageTypes.DF);
                case 0x0028: return new Usage(this, id, "Manufacturer Access", UsageTypes.DV);
                case 0x0029: return new Usage(this, id, "Remaining Capacity Limit", UsageTypes.DV);
                case 0x002a: return new Usage(this, id, "Remaining Time Limit", UsageTypes.DV);
                case 0x002b: return new Usage(this, id, "At Rate", UsageTypes.DV);
                case 0x002c: return new Usage(this, id, "Capacity Mode", UsageTypes.DV);
                case 0x002d: return new Usage(this, id, "Broadcast To Charger", UsageTypes.DV);
                case 0x002e: return new Usage(this, id, "Primary Battery", UsageTypes.DV);
                case 0x002f: return new Usage(this, id, "Charge Controller", UsageTypes.DV);
                case 0x0040: return new Usage(this, id, "Terminate Charge", UsageTypes.Sel);
                case 0x0041: return new Usage(this, id, "Terminate Discharge", UsageTypes.Sel);
                case 0x0042: return new Usage(this, id, "Below Remaining Capacity Limit", UsageTypes.Sel);
                case 0x0043: return new Usage(this, id, "Remaining Time Limit Expired", UsageTypes.Sel);
                case 0x0044: return new Usage(this, id, "Charging", UsageTypes.Sel);
                case 0x0045: return new Usage(this, id, "Discharging", UsageTypes.Sel);
                case 0x0046: return new Usage(this, id, "Fully Charged", UsageTypes.Sel);
                case 0x0047: return new Usage(this, id, "Fully Discharged", UsageTypes.Sel);
                case 0x0048: return new Usage(this, id, "Conditioning Flag", UsageTypes.DF);
                case 0x0049: return new Usage(this, id, "At Rate OK", UsageTypes.DF);
                case 0x004a: return new Usage(this, id, "Smart Battery Error Code", UsageTypes.DV);
                case 0x004b: return new Usage(this, id, "Need Replacement", UsageTypes.DF);
                case 0x0060: return new Usage(this, id, "At Rate Time To Full", UsageTypes.DV);
                case 0x0061: return new Usage(this, id, "At Rate Time To Empty", UsageTypes.DV);
                case 0x0062: return new Usage(this, id, "Average Current", UsageTypes.DV);
                case 0x0063: return new Usage(this, id, "Max Error", UsageTypes.DV);
                case 0x0064: return new Usage(this, id, "Relative State Of Charge", UsageTypes.DV);
                case 0x0065: return new Usage(this, id, "Absolute State Of Charge", UsageTypes.DV);
                case 0x0066: return new Usage(this, id, "Remaining Capacity", UsageTypes.DV);
                case 0x0067: return new Usage(this, id, "Full Charge Capacity", UsageTypes.DV);
                case 0x0068: return new Usage(this, id, "Run Time To Empty", UsageTypes.DV);
                case 0x0069: return new Usage(this, id, "Average Time To Empty", UsageTypes.DV);
                case 0x006a: return new Usage(this, id, "Average Time To Full", UsageTypes.DV);
                case 0x006b: return new Usage(this, id, "Cycle Count", UsageTypes.DV);
                case 0x0080: return new Usage(this, id, "Battery Pack Model Level", UsageTypes.SV);
                case 0x0081: return new Usage(this, id, "Internal Charge Controller", UsageTypes.SF);
                case 0x0082: return new Usage(this, id, "Primary Battery Support", UsageTypes.SF);
                case 0x0083: return new Usage(this, id, "Design Capacity", UsageTypes.SV);
                case 0x0084: return new Usage(this, id, "Specification Info", UsageTypes.SV);
                case 0x0085: return new Usage(this, id, "Manufacture Date", UsageTypes.SV);
                case 0x0086: return new Usage(this, id, "Serial Number", UsageTypes.SV);
                case 0x0087: return new Usage(this, id, "iManufacturer Name", UsageTypes.SV);
                case 0x0088: return new Usage(this, id, "iDevice Name", UsageTypes.SV);
                case 0x0089: return new Usage(this, id, "iDevice Chemistry", UsageTypes.SV);
                case 0x008a: return new Usage(this, id, "Manufacturer Data", UsageTypes.SV);
                case 0x008b: return new Usage(this, id, "Rechargable", UsageTypes.SV);
                case 0x008c: return new Usage(this, id, "Warning Capacity Limit", UsageTypes.SV);
                case 0x008d: return new Usage(this, id, "Capacity Granularity 1", UsageTypes.SV);
                case 0x008e: return new Usage(this, id, "Capacity Granularity 2", UsageTypes.SV);
                case 0x008f: return new Usage(this, id, "iOEM Information", UsageTypes.SV);
                case 0x00c0: return new Usage(this, id, "Inhibit Charge", UsageTypes.DF);
                case 0x00c1: return new Usage(this, id, "Enable Polling", UsageTypes.DF);
                case 0x00c2: return new Usage(this, id, "Reset To Zero", UsageTypes.DF);
                case 0x00d0: return new Usage(this, id, "AC Present", UsageTypes.DV);
                case 0x00d1: return new Usage(this, id, "Battery Present", UsageTypes.DV);
                case 0x00d2: return new Usage(this, id, "Power Fail", UsageTypes.DV);
                case 0x00d3: return new Usage(this, id, "Alarm Inhibited", UsageTypes.DV);
                case 0x00d4: return new Usage(this, id, "Thermistor Under Range", UsageTypes.DV);
                case 0x00d5: return new Usage(this, id, "Thermistor Hot", UsageTypes.DV);
                case 0x00d6: return new Usage(this, id, "Thermistor Cold", UsageTypes.DV);
                case 0x00d7: return new Usage(this, id, "Thermistor Over Range", UsageTypes.DV);
                case 0x00d8: return new Usage(this, id, "Voltage Out Of Range", UsageTypes.DV);
                case 0x00d9: return new Usage(this, id, "Current Out Of Range", UsageTypes.DV);
                case 0x00da: return new Usage(this, id, "Current Not Regulated", UsageTypes.DV);
                case 0x00db: return new Usage(this, id, "Voltage Not Regulated", UsageTypes.DV);
                case 0x00dc: return new Usage(this, id, "Master Mode", UsageTypes.DV);
                case 0x00f0: return new Usage(this, id, "Charger Selector Support", UsageTypes.SF);
                case 0x00f1: return new Usage(this, id, "Charger Spec", UsageTypes.SV);
                case 0x00f2: return new Usage(this, id, "Level 2", UsageTypes.SF);
                case 0x00f3: return new Usage(this, id, "Level 3", UsageTypes.SF);
            }

            return base.CreateUsage(id);
        }
    }
}
