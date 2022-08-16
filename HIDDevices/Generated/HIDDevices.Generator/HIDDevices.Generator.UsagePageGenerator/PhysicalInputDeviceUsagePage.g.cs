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
    //     Physical Input Device Usage Page.
    // </summary>
    public sealed class PhysicalInputDeviceUsagePage : UsagePage
    {
        // <summary>
        //     Singleton instance of Physical Input Device Usage Page.
        // </summary>
        public static readonly PhysicalInputDeviceUsagePage Instance = new();

        // <summary>
        //     Create singleton.
        // </summary>
        private PhysicalInputDeviceUsagePage() : base(0x000f, "Physical Input Device")
        {
        }

        /// <inheritdoc />
        protected override Usage CreateUsage(ushort id)
        {
            switch (id)
            {
                case 0x0000: return new Usage(this, id, "Undefined", UsageTypes.None);
                case 0x0001: return new Usage(this, id, "Physical Input Device", UsageTypes.CA);
                case 0x0020: return new Usage(this, id, "Normal", UsageTypes.DV);
                case 0x0021: return new Usage(this, id, "Set Effect Report", UsageTypes.CL);
                case 0x0022: return new Usage(this, id, "Effect Parameter Block Index", UsageTypes.DV);
                case 0x0023: return new Usage(this, id, "Parameter Block Offset", UsageTypes.DV);
                case 0x0024: return new Usage(this, id, "ROM Flag", UsageTypes.DF);
                case 0x0025: return new Usage(this, id, "Effect Type", UsageTypes.NAry);
                case 0x0026: return new Usage(this, id, "ET Constant-Force", UsageTypes.Sel);
                case 0x0027: return new Usage(this, id, "ET Ramp", UsageTypes.Sel);
                case 0x0028: return new Usage(this, id, "ET Custom-Force", UsageTypes.Sel);
                case 0x0030: return new Usage(this, id, "ET Square", UsageTypes.Sel);
                case 0x0031: return new Usage(this, id, "ET Sine", UsageTypes.Sel);
                case 0x0032: return new Usage(this, id, "ET Triangle", UsageTypes.Sel);
                case 0x0033: return new Usage(this, id, "ET Sawtooth Up", UsageTypes.Sel);
                case 0x0034: return new Usage(this, id, "ET Sawtooth Down", UsageTypes.Sel);
                case 0x0040: return new Usage(this, id, "ET Spring", UsageTypes.Sel);
                case 0x0041: return new Usage(this, id, "ET Damper", UsageTypes.Sel);
                case 0x0042: return new Usage(this, id, "ET Inertia", UsageTypes.Sel);
                case 0x0043: return new Usage(this, id, "ET Friction", UsageTypes.Sel);
                case 0x0050: return new Usage(this, id, "Duration", UsageTypes.DV);
                case 0x0051: return new Usage(this, id, "Sample Period", UsageTypes.DV);
                case 0x0052: return new Usage(this, id, "Gain", UsageTypes.DV);
                case 0x0053: return new Usage(this, id, "Trigger Button", UsageTypes.DV);
                case 0x0054: return new Usage(this, id, "Trigger Repeat Interval", UsageTypes.DV);
                case 0x0055: return new Usage(this, id, "Axes Enable", UsageTypes.US);
                case 0x0056: return new Usage(this, id, "Direction Enable", UsageTypes.DF);
                case 0x0057: return new Usage(this, id, "Direction", UsageTypes.CL);
                case 0x0058: return new Usage(this, id, "Type Specific Block Offset", UsageTypes.CL);
                case 0x0059: return new Usage(this, id, "Block Type", UsageTypes.NAry);
                case 0x005a: return new Usage(this, id, "Set Envelope Report", UsageTypes.CL|UsageTypes.SV);
                case 0x005b: return new Usage(this, id, "Attack Level", UsageTypes.DV);
                case 0x005c: return new Usage(this, id, "Attack Time", UsageTypes.DV);
                case 0x005d: return new Usage(this, id, "Fade Level", UsageTypes.DV);
                case 0x005e: return new Usage(this, id, "Fade Time", UsageTypes.DV);
                case 0x005f: return new Usage(this, id, "Set Condition Report", UsageTypes.CL|UsageTypes.SV);
                case 0x0060: return new Usage(this, id, "Center-Point Offset", UsageTypes.DV);
                case 0x0061: return new Usage(this, id, "Positive Coefficient", UsageTypes.DV);
                case 0x0062: return new Usage(this, id, "Negative Coefficient", UsageTypes.DV);
                case 0x0063: return new Usage(this, id, "Positive Saturation", UsageTypes.DV);
                case 0x0064: return new Usage(this, id, "Negative Saturation", UsageTypes.DV);
                case 0x0065: return new Usage(this, id, "Dead Band", UsageTypes.DV);
                case 0x0066: return new Usage(this, id, "Download Force Sample", UsageTypes.CL);
                case 0x0067: return new Usage(this, id, "Isoch Custom-Force Enable", UsageTypes.DF);
                case 0x0068: return new Usage(this, id, "Custom-Force Data Report", UsageTypes.CL);
                case 0x0069: return new Usage(this, id, "Custom-Force Data", UsageTypes.DV);
                case 0x006a: return new Usage(this, id, "Custom-Force Vendor Defined Data", UsageTypes.DV);
                case 0x006b: return new Usage(this, id, "Set Custom-Force Report", UsageTypes.CL|UsageTypes.SV);
                case 0x006c: return new Usage(this, id, "Custom-Force Data Offset", UsageTypes.DV);
                case 0x006d: return new Usage(this, id, "Sample Count", UsageTypes.DV);
                case 0x006e: return new Usage(this, id, "Set Periodic Report", UsageTypes.CL|UsageTypes.SV);
                case 0x006f: return new Usage(this, id, "Offset", UsageTypes.DV);
                case 0x0070: return new Usage(this, id, "Magnitude", UsageTypes.DV);
                case 0x0071: return new Usage(this, id, "Phase", UsageTypes.DV);
                case 0x0072: return new Usage(this, id, "Period", UsageTypes.DV);
                case 0x0073: return new Usage(this, id, "Set Constant-Force Report", UsageTypes.CL|UsageTypes.SV);
                case 0x0074: return new Usage(this, id, "Set Ramp-Force Report", UsageTypes.CL|UsageTypes.SV);
                case 0x0075: return new Usage(this, id, "Ramp Start", UsageTypes.DV);
                case 0x0076: return new Usage(this, id, "Ramp End", UsageTypes.DV);
                case 0x0077: return new Usage(this, id, "Effect Operation Report", UsageTypes.CL);
                case 0x0078: return new Usage(this, id, "Effect Operation", UsageTypes.NAry);
                case 0x0079: return new Usage(this, id, "Op Effect Start", UsageTypes.Sel);
                case 0x007a: return new Usage(this, id, "Op Effect Start Solo", UsageTypes.Sel);
                case 0x007b: return new Usage(this, id, "Op Effect Stop", UsageTypes.Sel);
                case 0x007c: return new Usage(this, id, "Loop Count", UsageTypes.DV);
                case 0x007d: return new Usage(this, id, "Device Gain Report", UsageTypes.CL);
                case 0x007e: return new Usage(this, id, "Device Gain", UsageTypes.DV);
                case 0x007f: return new Usage(this, id, "Parameter Block Pools Report", UsageTypes.CL);
                case 0x0080: return new Usage(this, id, "RAM Pool Size", UsageTypes.DV);
                case 0x0081: return new Usage(this, id, "ROM Pool Size", UsageTypes.SV);
                case 0x0082: return new Usage(this, id, "ROM Effect Block Count", UsageTypes.SV);
                case 0x0083: return new Usage(this, id, "Simultaneous Effects Max", UsageTypes.SV);
                case 0x0084: return new Usage(this, id, "Pool Alignment", UsageTypes.SV);
                case 0x0085: return new Usage(this, id, "Parameter Block Move Report", UsageTypes.CL);
                case 0x0086: return new Usage(this, id, "Move Source", UsageTypes.DV);
                case 0x0087: return new Usage(this, id, "Move Destination", UsageTypes.DV);
                case 0x0088: return new Usage(this, id, "Move Length", UsageTypes.DV);
                case 0x0089: return new Usage(this, id, "Effect Parameter Block Load Report", UsageTypes.CL);
                case 0x008b: return new Usage(this, id, "Effect Parameter Block Load Status", UsageTypes.NAry);
                case 0x008c: return new Usage(this, id, "Block Load Success", UsageTypes.Sel);
                case 0x008d: return new Usage(this, id, "Block Load Full", UsageTypes.Sel);
                case 0x008e: return new Usage(this, id, "Block Load Error", UsageTypes.Sel);
                case 0x008f: return new Usage(this, id, "Block Handle", UsageTypes.DV);
                case 0x0090: return new Usage(this, id, "Effect Parameter Block Free Report", UsageTypes.CL);
                case 0x0091: return new Usage(this, id, "Type Specific Block Handle", UsageTypes.CL);
                case 0x0092: return new Usage(this, id, "PID State Report", UsageTypes.CL);
                case 0x0094: return new Usage(this, id, "Effect Playing", UsageTypes.DF);
                case 0x0095: return new Usage(this, id, "PID Device Control Report", UsageTypes.CL);
                case 0x0096: return new Usage(this, id, "PID Device Control", UsageTypes.NAry);
                case 0x0097: return new Usage(this, id, "DC Enable Actuators", UsageTypes.Sel);
                case 0x0098: return new Usage(this, id, "DC Disable Actuators", UsageTypes.Sel);
                case 0x0099: return new Usage(this, id, "DC Stop All Effects", UsageTypes.Sel);
                case 0x009a: return new Usage(this, id, "DC Reset", UsageTypes.Sel);
                case 0x009b: return new Usage(this, id, "DC Pause", UsageTypes.Sel);
                case 0x009c: return new Usage(this, id, "DC Continue", UsageTypes.Sel);
                case 0x009f: return new Usage(this, id, "Device Paused", UsageTypes.DF);
                case 0x00a0: return new Usage(this, id, "Actuators Enabled", UsageTypes.DF);
                case 0x00a4: return new Usage(this, id, "Safety Switch", UsageTypes.DF);
                case 0x00a5: return new Usage(this, id, "Actuator Override Switch", UsageTypes.DF);
                case 0x00a6: return new Usage(this, id, "Actuator Power", UsageTypes.OOC);
                case 0x00a7: return new Usage(this, id, "Start Delay", UsageTypes.DV);
                case 0x00a8: return new Usage(this, id, "Parameter Block Size", UsageTypes.CL);
                case 0x00a9: return new Usage(this, id, "Device-Managed Pool", UsageTypes.SF);
                case 0x00aa: return new Usage(this, id, "Shared Parameter Blocks", UsageTypes.SF);
                case 0x00ab: return new Usage(this, id, "Create New Effect Parameter Block Report", UsageTypes.CL);
                case 0x00ac: return new Usage(this, id, "RAM Pool Available", UsageTypes.DV);
            }

            return base.CreateUsage(id);
        }
    }
}
