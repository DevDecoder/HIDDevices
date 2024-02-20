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
    //     LED Usage Page.
    // </summary>
    public sealed class LEDUsagePage : UsagePage
    {
        // <summary>
        //     Singleton instance of LED Usage Page.
        // </summary>
        public static readonly LEDUsagePage Instance = new();

        // <summary>
        //     Create singleton.
        // </summary>
        private LEDUsagePage() : base(0x0008, "LED")
        {
        }

        /// <inheritdoc />
        protected override Usage CreateUsage(ushort id)
        {
            switch (id)
            {
                case 0x0000: return new Usage(this, id, "Undefined", UsageTypes.None);
                case 0x0001: return new Usage(this, id, "Num Lock", UsageTypes.OOC);
                case 0x0002: return new Usage(this, id, "Caps Lock", UsageTypes.OOC);
                case 0x0003: return new Usage(this, id, "Scroll Lock", UsageTypes.OOC);
                case 0x0004: return new Usage(this, id, "Compose", UsageTypes.OOC);
                case 0x0005: return new Usage(this, id, "Kana", UsageTypes.OOC);
                case 0x0006: return new Usage(this, id, "Power", UsageTypes.OOC);
                case 0x0007: return new Usage(this, id, "Shift", UsageTypes.OOC);
                case 0x0008: return new Usage(this, id, "Do Not Disturb", UsageTypes.OOC);
                case 0x0009: return new Usage(this, id, "Mute", UsageTypes.OOC);
                case 0x000a: return new Usage(this, id, "Tone Enable", UsageTypes.OOC);
                case 0x000b: return new Usage(this, id, "High Cut Filter", UsageTypes.OOC);
                case 0x000c: return new Usage(this, id, "Low Cut Filter", UsageTypes.OOC);
                case 0x000d: return new Usage(this, id, "Equalizer Enable", UsageTypes.OOC);
                case 0x000e: return new Usage(this, id, "Sound Field On", UsageTypes.OOC);
                case 0x000f: return new Usage(this, id, "Surround On", UsageTypes.OOC);
                case 0x0010: return new Usage(this, id, "Repeat", UsageTypes.OOC);
                case 0x0011: return new Usage(this, id, "Stereo", UsageTypes.OOC);
                case 0x0012: return new Usage(this, id, "Sampling Rate Detect", UsageTypes.OOC);
                case 0x0013: return new Usage(this, id, "Spinning", UsageTypes.OOC);
                case 0x0014: return new Usage(this, id, "CAV", UsageTypes.OOC);
                case 0x0015: return new Usage(this, id, "CLV", UsageTypes.OOC);
                case 0x0016: return new Usage(this, id, "Recording Format Detect", UsageTypes.OOC);
                case 0x0017: return new Usage(this, id, "Off-Hook", UsageTypes.OOC);
                case 0x0018: return new Usage(this, id, "Ring", UsageTypes.OOC);
                case 0x0019: return new Usage(this, id, "Message Waiting", UsageTypes.OOC);
                case 0x001a: return new Usage(this, id, "Data Mode", UsageTypes.OOC);
                case 0x001b: return new Usage(this, id, "Battery Operation", UsageTypes.OOC);
                case 0x001c: return new Usage(this, id, "Battery OK", UsageTypes.OOC);
                case 0x001d: return new Usage(this, id, "Battery Low", UsageTypes.OOC);
                case 0x001e: return new Usage(this, id, "Speaker", UsageTypes.OOC);
                case 0x001f: return new Usage(this, id, "Headset", UsageTypes.OOC);
                case 0x0020: return new Usage(this, id, "Hold", UsageTypes.OOC);
                case 0x0021: return new Usage(this, id, "Microphone", UsageTypes.OOC);
                case 0x0022: return new Usage(this, id, "Coverage", UsageTypes.OOC);
                case 0x0023: return new Usage(this, id, "Night Mode", UsageTypes.OOC);
                case 0x0024: return new Usage(this, id, "Send Calls", UsageTypes.OOC);
                case 0x0025: return new Usage(this, id, "Call Pickup", UsageTypes.OOC);
                case 0x0026: return new Usage(this, id, "Conference", UsageTypes.OOC);
                case 0x0027: return new Usage(this, id, "Stand-by", UsageTypes.OOC);
                case 0x0028: return new Usage(this, id, "Camera On", UsageTypes.OOC);
                case 0x0029: return new Usage(this, id, "Camera Off", UsageTypes.OOC);
                case 0x002a: return new Usage(this, id, "On-Line", UsageTypes.OOC);
                case 0x002b: return new Usage(this, id, "Off-Line", UsageTypes.OOC);
                case 0x002c: return new Usage(this, id, "Busy", UsageTypes.OOC);
                case 0x002d: return new Usage(this, id, "Ready", UsageTypes.OOC);
                case 0x002e: return new Usage(this, id, "Paper-Out", UsageTypes.OOC);
                case 0x002f: return new Usage(this, id, "Paper-Jam", UsageTypes.OOC);
                case 0x0030: return new Usage(this, id, "Remote", UsageTypes.OOC);
                case 0x0031: return new Usage(this, id, "Forward", UsageTypes.OOC);
                case 0x0032: return new Usage(this, id, "Reverse", UsageTypes.OOC);
                case 0x0033: return new Usage(this, id, "Stop", UsageTypes.OOC);
                case 0x0034: return new Usage(this, id, "Rewind", UsageTypes.OOC);
                case 0x0035: return new Usage(this, id, "Fast Forward", UsageTypes.OOC);
                case 0x0036: return new Usage(this, id, "Play", UsageTypes.OOC);
                case 0x0037: return new Usage(this, id, "Pause", UsageTypes.OOC);
                case 0x0038: return new Usage(this, id, "Record", UsageTypes.OOC);
                case 0x0039: return new Usage(this, id, "Error", UsageTypes.OOC);
                case 0x003a: return new Usage(this, id, "Usage Selected Indicator", UsageTypes.US);
                case 0x003b: return new Usage(this, id, "Usage In Use Indicator", UsageTypes.US);
                case 0x003c: return new Usage(this, id, "Usage Multi Mode Indicator", UsageTypes.UM);
                case 0x003d: return new Usage(this, id, "Indicator On", UsageTypes.Sel);
                case 0x003e: return new Usage(this, id, "Indicator Flash", UsageTypes.Sel);
                case 0x003f: return new Usage(this, id, "Indicator Slow Blink", UsageTypes.Sel);
                case 0x0040: return new Usage(this, id, "Indicator Fast Blink", UsageTypes.Sel);
                case 0x0041: return new Usage(this, id, "Indicator Off", UsageTypes.Sel);
                case 0x0042: return new Usage(this, id, "Flash On Time", UsageTypes.DV);
                case 0x0043: return new Usage(this, id, "Slow Blink On Time", UsageTypes.DV);
                case 0x0044: return new Usage(this, id, "Slow Blink Off Time", UsageTypes.DV);
                case 0x0045: return new Usage(this, id, "Fast Blink On Time", UsageTypes.DV);
                case 0x0046: return new Usage(this, id, "Fast Blink Off Time", UsageTypes.DV);
                case 0x0047: return new Usage(this, id, "Usage Indicator Color", UsageTypes.UM);
                case 0x0048: return new Usage(this, id, "Indicator Red", UsageTypes.Sel);
                case 0x0049: return new Usage(this, id, "Indicator Green", UsageTypes.Sel);
                case 0x004a: return new Usage(this, id, "Indicator Amber", UsageTypes.Sel);
                case 0x004b: return new Usage(this, id, "Generic Indicator", UsageTypes.OOC);
                case 0x004c: return new Usage(this, id, "System Suspend", UsageTypes.OOC);
                case 0x004d: return new Usage(this, id, "External Power Connected", UsageTypes.OOC);
                case 0x004e: return new Usage(this, id, "Indicator Blue", UsageTypes.Sel);
                case 0x004f: return new Usage(this, id, "Indicator Orange", UsageTypes.Sel);
                case 0x0050: return new Usage(this, id, "Good Status", UsageTypes.OOC);
                case 0x0051: return new Usage(this, id, "Warning Status", UsageTypes.OOC);
                case 0x0052: return new Usage(this, id, "RGB LED", UsageTypes.CL);
                case 0x0053: return new Usage(this, id, "Red LED Channel", UsageTypes.DV);
                case 0x0054: return new Usage(this, id, "Blue LED Channel", UsageTypes.DV);
                case 0x0055: return new Usage(this, id, "Green LED Channel", UsageTypes.DV);
                case 0x0056: return new Usage(this, id, "LED Intensity", UsageTypes.DV);
                case 0x0057: return new Usage(this, id, "System Microphone Mute", UsageTypes.OOC);
                case 0x0060: return new Usage(this, id, "Player Indicator", UsageTypes.NAry);
                case 0x0061: return new Usage(this, id, "Player 1", UsageTypes.Sel);
                case 0x0062: return new Usage(this, id, "Player 2", UsageTypes.Sel);
                case 0x0063: return new Usage(this, id, "Player 3", UsageTypes.Sel);
                case 0x0064: return new Usage(this, id, "Player 4", UsageTypes.Sel);
                case 0x0065: return new Usage(this, id, "Player 5", UsageTypes.Sel);
                case 0x0066: return new Usage(this, id, "Player 6", UsageTypes.Sel);
                case 0x0067: return new Usage(this, id, "Player 7", UsageTypes.Sel);
                case 0x0068: return new Usage(this, id, "Player 8", UsageTypes.Sel);
            }

            return base.CreateUsage(id);
        }
    }
}
