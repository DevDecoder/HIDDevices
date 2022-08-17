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
    //     Digitizers Usage Page.
    // </summary>
    public sealed class DigitizersUsagePage : UsagePage
    {
        // <summary>
        //     Singleton instance of Digitizers Usage Page.
        // </summary>
        public static readonly DigitizersUsagePage Instance = new();

        // <summary>
        //     Create singleton.
        // </summary>
        private DigitizersUsagePage() : base(0x000d, "Digitizers")
        {
        }

        /// <inheritdoc />
        protected override Usage CreateUsage(ushort id)
        {
            switch (id)
            {
                case 0x0000: return new Usage(this, id, "Undefined", UsageTypes.None);
                case 0x0001: return new Usage(this, id, "Digitizer", UsageTypes.CA);
                case 0x0002: return new Usage(this, id, "Pen", UsageTypes.CA);
                case 0x0003: return new Usage(this, id, "Light Pen", UsageTypes.CA);
                case 0x0004: return new Usage(this, id, "Touch Screen", UsageTypes.CA);
                case 0x0005: return new Usage(this, id, "Touch Pad", UsageTypes.CA);
                case 0x0006: return new Usage(this, id, "Whiteboard", UsageTypes.CA);
                case 0x0007: return new Usage(this, id, "Coordinate Measuring Machine", UsageTypes.CA);
                case 0x0008: return new Usage(this, id, "3D Digitizer", UsageTypes.CA);
                case 0x0009: return new Usage(this, id, "Stereo Plotter", UsageTypes.CA);
                case 0x000a: return new Usage(this, id, "Articulated Arm", UsageTypes.CA);
                case 0x000b: return new Usage(this, id, "Armature", UsageTypes.CA);
                case 0x000c: return new Usage(this, id, "Multiple Point Digitizer", UsageTypes.CA);
                case 0x000d: return new Usage(this, id, "Free Space Wand", UsageTypes.CA);
                case 0x000e: return new Usage(this, id, "Device Configuration", UsageTypes.CA);
                case 0x000f: return new Usage(this, id, "Capacitive Heat Map Digitizer", UsageTypes.CA);
                case 0x0020: return new Usage(this, id, "Stylus", UsageTypes.CA|UsageTypes.CL);
                case 0x0021: return new Usage(this, id, "Puck", UsageTypes.CL);
                case 0x0022: return new Usage(this, id, "Finger", UsageTypes.CL);
                case 0x0023: return new Usage(this, id, "Device settings", UsageTypes.CL);
                case 0x0024: return new Usage(this, id, "Character Gesture", UsageTypes.CL);
                case 0x0030: return new Usage(this, id, "Tip Pressure", UsageTypes.DV);
                case 0x0031: return new Usage(this, id, "Barrel Pressure", UsageTypes.DV);
                case 0x0032: return new Usage(this, id, "In Range", UsageTypes.MC);
                case 0x0033: return new Usage(this, id, "Touch", UsageTypes.MC);
                case 0x0034: return new Usage(this, id, "Untouch", UsageTypes.OSC);
                case 0x0035: return new Usage(this, id, "Tap", UsageTypes.OSC);
                case 0x0036: return new Usage(this, id, "Quality", UsageTypes.DV);
                case 0x0037: return new Usage(this, id, "Data Valid", UsageTypes.MC);
                case 0x0038: return new Usage(this, id, "Transducer Index", UsageTypes.DV);
                case 0x0039: return new Usage(this, id, "Tablet Function Keys", UsageTypes.CL);
                case 0x003a: return new Usage(this, id, "Program Change Keys", UsageTypes.CL);
                case 0x003b: return new Usage(this, id, "Battery Strength", UsageTypes.DV);
                case 0x003c: return new Usage(this, id, "Invert", UsageTypes.MC);
                case 0x003d: return new Usage(this, id, "X Tilt", UsageTypes.DV);
                case 0x003e: return new Usage(this, id, "Y Tilt", UsageTypes.DV);
                case 0x003f: return new Usage(this, id, "Azimuth", UsageTypes.DV);
                case 0x0040: return new Usage(this, id, "Altitude", UsageTypes.DV);
                case 0x0041: return new Usage(this, id, "Twist", UsageTypes.DV);
                case 0x0042: return new Usage(this, id, "Tip Switch", UsageTypes.MC);
                case 0x0043: return new Usage(this, id, "Secondary Tip Switch", UsageTypes.MC);
                case 0x0044: return new Usage(this, id, "Barrel Switch", UsageTypes.MC);
                case 0x0045: return new Usage(this, id, "Eraser", UsageTypes.MC);
                case 0x0046: return new Usage(this, id, "Tablet Pick", UsageTypes.MC);
                case 0x0047: return new Usage(this, id, "Touch Valid", UsageTypes.MC);
                case 0x0048: return new Usage(this, id, "Width", UsageTypes.DV);
                case 0x0049: return new Usage(this, id, "Height", UsageTypes.DV);
                case 0x0051: return new Usage(this, id, "Contact Identifier", UsageTypes.DV);
                case 0x0052: return new Usage(this, id, "Device Mode", UsageTypes.DV);
                case 0x0053: return new Usage(this, id, "Device Identifier", UsageTypes.DV|UsageTypes.SV);
                case 0x0054: return new Usage(this, id, "Contact Count", UsageTypes.DV);
                case 0x0055: return new Usage(this, id, "Contact Count Maximum", UsageTypes.SV);
                case 0x0056: return new Usage(this, id, "Scan Time", UsageTypes.DV);
                case 0x0057: return new Usage(this, id, "Surface Switch", UsageTypes.DF);
                case 0x0058: return new Usage(this, id, "Button Switch", UsageTypes.DF);
                case 0x0059: return new Usage(this, id, "Pad Type", UsageTypes.SF);
                case 0x005a: return new Usage(this, id, "Secondary Barrel Switch", UsageTypes.MC);
                case 0x005b: return new Usage(this, id, "Transducer Serial Number", UsageTypes.SV);
                case 0x005c: return new Usage(this, id, "Preferred Color", UsageTypes.DV);
                case 0x005d: return new Usage(this, id, "Preferred Color is Locked", UsageTypes.MC);
                case 0x005e: return new Usage(this, id, "Preferred Line Width", UsageTypes.DV);
                case 0x005f: return new Usage(this, id, "Preferred Line Width is Locked", UsageTypes.MC);
                case 0x0060: return new Usage(this, id, "Latency Mode", UsageTypes.DF);
                case 0x0061: return new Usage(this, id, "Gesture Character Quality", UsageTypes.DV);
                case 0x0062: return new Usage(this, id, "Character Gesture Data Length", UsageTypes.DV);
                case 0x0063: return new Usage(this, id, "Character Gesture Data", UsageTypes.DV);
                case 0x0064: return new Usage(this, id, "Gesture Character Encoding", UsageTypes.NAry);
                case 0x0065: return new Usage(this, id, "UTF8 Character Gesture Encoding", UsageTypes.Sel);
                case 0x0066: return new Usage(this, id, "UTF16 Little Endian Character Gesture Encoding", UsageTypes.Sel);
                case 0x0067: return new Usage(this, id, "UTF16 Big Endian Character Gesture Encoding", UsageTypes.Sel);
                case 0x0068: return new Usage(this, id, "UTF32 Little Endian Character Gesture Encoding", UsageTypes.Sel);
                case 0x0069: return new Usage(this, id, "UTF32 Big Endian Character Gesture Encoding", UsageTypes.Sel);
                case 0x006a: return new Usage(this, id, "Capacitive Heat Map Protocol Vendor ID", UsageTypes.SV);
                case 0x006b: return new Usage(this, id, "Capacitive Heat Map Protocol Version", UsageTypes.SV);
                case 0x006c: return new Usage(this, id, "Capacitive Heat Map Frame Data", UsageTypes.DV);
                case 0x006d: return new Usage(this, id, "Gesture Character Enable", UsageTypes.DF);
                case 0x006e: return new Usage(this, id, "Transducer Serial Number Part 2", UsageTypes.SV);
                case 0x006f: return new Usage(this, id, "No Preferred Color", UsageTypes.DF);
                case 0x0070: return new Usage(this, id, "Preferred Line Style", UsageTypes.NAry);
                case 0x0071: return new Usage(this, id, "Preferred Line Style is Locked", UsageTypes.MC);
                case 0x0072: return new Usage(this, id, "Ink", UsageTypes.Sel);
                case 0x0073: return new Usage(this, id, "Pencil", UsageTypes.Sel);
                case 0x0074: return new Usage(this, id, "Highlighter", UsageTypes.Sel);
                case 0x0075: return new Usage(this, id, "Chisel Marker", UsageTypes.Sel);
                case 0x0076: return new Usage(this, id, "Brush", UsageTypes.Sel);
                case 0x0077: return new Usage(this, id, "No Preference", UsageTypes.Sel);
                case 0x0080: return new Usage(this, id, "Digitizer Diagnostic", UsageTypes.CL);
                case 0x0081: return new Usage(this, id, "Digitizer Error", UsageTypes.NAry);
                case 0x0082: return new Usage(this, id, "Err Normal Status", UsageTypes.Sel);
                case 0x0083: return new Usage(this, id, "Err Transducers Exceeded", UsageTypes.Sel);
                case 0x0084: return new Usage(this, id, "Err Full Trans Features Unavailable", UsageTypes.Sel);
                case 0x0085: return new Usage(this, id, "Err Charge Low", UsageTypes.Sel);
                case 0x0090: return new Usage(this, id, "Transducer Software Info", UsageTypes.CL);
                case 0x0091: return new Usage(this, id, "Transducer Vendor Id", UsageTypes.SV);
                case 0x0092: return new Usage(this, id, "Transducer Product Id", UsageTypes.SV);
                case 0x0093: return new Usage(this, id, "Device Supported Protocols", UsageTypes.NAry|UsageTypes.CL);
                case 0x0094: return new Usage(this, id, "Transducer Supported Protocols", UsageTypes.NAry|UsageTypes.CL);
                case 0x0095: return new Usage(this, id, "No Protocol", UsageTypes.Sel);
                case 0x0096: return new Usage(this, id, "Wacom AES Protocol", UsageTypes.Sel);
                case 0x0097: return new Usage(this, id, "USI Protocol", UsageTypes.Sel);
                case 0x0098: return new Usage(this, id, "Microsoft Pen Protocol", UsageTypes.Sel);
                case 0x00a0: return new Usage(this, id, "Supported Report Rates", UsageTypes.SV|UsageTypes.CL);
                case 0x00a1: return new Usage(this, id, "Report Rate", UsageTypes.DV);
                case 0x00a2: return new Usage(this, id, "Transducer Connected", UsageTypes.SF);
                case 0x00a3: return new Usage(this, id, "Switch Disabled", UsageTypes.Sel);
                case 0x00a4: return new Usage(this, id, "Switch Unimplemented", UsageTypes.Sel);
                case 0x00a5: return new Usage(this, id, "Transducer Switches", UsageTypes.Sel);
            }

            return base.CreateUsage(id);
        }
    }
}
