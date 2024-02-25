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
    //     Power Usage Page.
    // </summary>
    public sealed class PowerUsagePage : UsagePage
    {
        // <summary>
        //     Singleton instance of Power Usage Page.
        // </summary>
        public static readonly PowerUsagePage Instance = new();

        // <summary>
        //     Create singleton.
        // </summary>
        private PowerUsagePage() : base(0x0084, "Power")
        {
        }

        /// <inheritdoc />
        protected override Usage CreateUsage(ushort id)
        {
            switch (id)
            {
                case 0x0000: return new Usage(this, id, "Undefined", UsageTypes.None);
                case 0x0001: return new Usage(this, id, "iName", UsageTypes.SV);
                case 0x0002: return new Usage(this, id, "Present Status", UsageTypes.CL);
                case 0x0003: return new Usage(this, id, "Changed Status", UsageTypes.CL);
                case 0x0004: return new Usage(this, id, "UPS", UsageTypes.CA);
                case 0x0005: return new Usage(this, id, "Power Supply", UsageTypes.CA);
                case 0x0010: return new Usage(this, id, "Battery System", UsageTypes.CP);
                case 0x0011: return new Usage(this, id, "Battery System Id", UsageTypes.SV);
                case 0x0012: return new Usage(this, id, "Battery", UsageTypes.CP);
                case 0x0013: return new Usage(this, id, "Battery Id", UsageTypes.SV);
                case 0x0014: return new Usage(this, id, "Charger", UsageTypes.CP);
                case 0x0015: return new Usage(this, id, "Charger Id", UsageTypes.SV);
                case 0x0016: return new Usage(this, id, "Power Converter", UsageTypes.CP);
                case 0x0017: return new Usage(this, id, "Power Converter Id", UsageTypes.SV);
                case 0x0018: return new Usage(this, id, "Outlet System", UsageTypes.CP);
                case 0x0019: return new Usage(this, id, "Outlet System Id", UsageTypes.SV);
                case 0x001a: return new Usage(this, id, "Input", UsageTypes.CP);
                case 0x001b: return new Usage(this, id, "Input Id", UsageTypes.SV);
                case 0x001c: return new Usage(this, id, "Output", UsageTypes.CP);
                case 0x001d: return new Usage(this, id, "Output Id", UsageTypes.SV);
                case 0x001e: return new Usage(this, id, "Flow", UsageTypes.CP);
                case 0x001f: return new Usage(this, id, "Flow Id", UsageTypes.SV);
                case 0x0020: return new Usage(this, id, "Outlet", UsageTypes.CP);
                case 0x0021: return new Usage(this, id, "Outlet Id", UsageTypes.SV);
                case 0x0022: return new Usage(this, id, "Gang", UsageTypes.CL|UsageTypes.CP);
                case 0x0023: return new Usage(this, id, "Gang Id", UsageTypes.SV);
                case 0x0024: return new Usage(this, id, "Power Summary", UsageTypes.CL|UsageTypes.CP);
                case 0x0025: return new Usage(this, id, "Power Summary Id", UsageTypes.SV);
                case 0x0030: return new Usage(this, id, "Voltage", UsageTypes.DV);
                case 0x0031: return new Usage(this, id, "Current", UsageTypes.DV);
                case 0x0032: return new Usage(this, id, "Frequency", UsageTypes.DV);
                case 0x0033: return new Usage(this, id, "Apparent Power", UsageTypes.DV);
                case 0x0034: return new Usage(this, id, "Active Power", UsageTypes.DV);
                case 0x0035: return new Usage(this, id, "Percent Load", UsageTypes.DV);
                case 0x0036: return new Usage(this, id, "Temperature", UsageTypes.DV);
                case 0x0037: return new Usage(this, id, "Humidity", UsageTypes.DV);
                case 0x0038: return new Usage(this, id, "Bad Count", UsageTypes.DV);
                case 0x0040: return new Usage(this, id, "Config Voltage", UsageTypes.SV|UsageTypes.DV);
                case 0x0041: return new Usage(this, id, "Config Current", UsageTypes.SV|UsageTypes.DV);
                case 0x0042: return new Usage(this, id, "Config Frequency", UsageTypes.SV|UsageTypes.DV);
                case 0x0043: return new Usage(this, id, "Config Apparent Power", UsageTypes.SV|UsageTypes.DV);
                case 0x0044: return new Usage(this, id, "Config Active Power", UsageTypes.SV|UsageTypes.DV);
                case 0x0045: return new Usage(this, id, "Config Percent Load", UsageTypes.SV|UsageTypes.DV);
                case 0x0046: return new Usage(this, id, "Config Temperature", UsageTypes.SV|UsageTypes.DV);
                case 0x0047: return new Usage(this, id, "Config Humidity", UsageTypes.SV|UsageTypes.DV);
                case 0x0050: return new Usage(this, id, "Switch On Control", UsageTypes.DV);
                case 0x0051: return new Usage(this, id, "Switch Off Control", UsageTypes.DV);
                case 0x0052: return new Usage(this, id, "Toggle Control", UsageTypes.DV);
                case 0x0053: return new Usage(this, id, "Low Voltage Transfer", UsageTypes.DV);
                case 0x0054: return new Usage(this, id, "High Voltage Transfer", UsageTypes.DV);
                case 0x0055: return new Usage(this, id, "Delay Before Reboot", UsageTypes.DV);
                case 0x0056: return new Usage(this, id, "Delay Before Startup", UsageTypes.DV);
                case 0x0057: return new Usage(this, id, "Delay Before Shutdown", UsageTypes.DV);
                case 0x0058: return new Usage(this, id, "Test", UsageTypes.DV);
                case 0x0059: return new Usage(this, id, "Module Reset", UsageTypes.DV);
                case 0x005a: return new Usage(this, id, "Audible Alarm Control", UsageTypes.DV);
                case 0x0060: return new Usage(this, id, "Present", UsageTypes.DF);
                case 0x0061: return new Usage(this, id, "Good", UsageTypes.DF);
                case 0x0062: return new Usage(this, id, "Internal Failure", UsageTypes.DF);
                case 0x0063: return new Usage(this, id, "Voltag Out Of Range", UsageTypes.DF);
                case 0x0064: return new Usage(this, id, "Frequency Out Of Range", UsageTypes.DF);
                case 0x0065: return new Usage(this, id, "Overload", UsageTypes.DF);
                case 0x0066: return new Usage(this, id, "Over Charged", UsageTypes.DF);
                case 0x0067: return new Usage(this, id, "Over Temperature", UsageTypes.DF);
                case 0x0068: return new Usage(this, id, "Shutdown Requested", UsageTypes.DF);
                case 0x0069: return new Usage(this, id, "Shutdown Imminent", UsageTypes.DF);
                case 0x006b: return new Usage(this, id, "Switch On/Off", UsageTypes.DF);
                case 0x006c: return new Usage(this, id, "Switchable", UsageTypes.DF);
                case 0x006d: return new Usage(this, id, "Used", UsageTypes.DF);
                case 0x006e: return new Usage(this, id, "Boost", UsageTypes.DF);
                case 0x006f: return new Usage(this, id, "Buck", UsageTypes.DF);
                case 0x0070: return new Usage(this, id, "Initialized", UsageTypes.DF);
                case 0x0071: return new Usage(this, id, "Tested", UsageTypes.DF);
                case 0x0072: return new Usage(this, id, "Awaiting Power", UsageTypes.DF);
                case 0x0073: return new Usage(this, id, "Communication Lost", UsageTypes.DF);
                case 0x00fd: return new Usage(this, id, "iManufacturer", UsageTypes.SV);
                case 0x00fe: return new Usage(this, id, "iProduct", UsageTypes.SV);
                case 0x00ff: return new Usage(this, id, "iSerialNumber", UsageTypes.SV);
            }

            return base.CreateUsage(id);
        }
    }
}
