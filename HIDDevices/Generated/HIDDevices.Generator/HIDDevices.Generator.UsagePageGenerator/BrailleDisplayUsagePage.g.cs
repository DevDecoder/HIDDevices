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
    //     Braille Display Usage Page.
    // </summary>
    public sealed class BrailleDisplayUsagePage : UsagePage
    {
        // <summary>
        //     Singleton instance of Braille Display Usage Page.
        // </summary>
        public static readonly BrailleDisplayUsagePage Instance = new();

        // <summary>
        //     Create singleton.
        // </summary>
        private BrailleDisplayUsagePage() : base(0x0041, "Braille Display")
        {
        }

        /// <inheritdoc />
        protected override Usage CreateUsage(ushort id)
        {
            switch (id)
            {
                case 0x0000: return new Usage(this, id, "Undefined", UsageTypes.None);
                case 0x0001: return new Usage(this, id, "Braille Display", UsageTypes.CA);
                case 0x0002: return new Usage(this, id, "Braille Row", UsageTypes.NAry);
                case 0x0003: return new Usage(this, id, "8 Dot Braille Cell", UsageTypes.DV);
                case 0x0004: return new Usage(this, id, "6 Dot Braille Cell", UsageTypes.DV);
                case 0x0005: return new Usage(this, id, "Number of Braille Cells", UsageTypes.DV);
                case 0x0006: return new Usage(this, id, "Screen Reader Control", UsageTypes.NAry);
                case 0x0007: return new Usage(this, id, "Screen Reader Identifier", UsageTypes.DV);
                case 0x00fa: return new Usage(this, id, "Router Set 1", UsageTypes.NAry);
                case 0x00fb: return new Usage(this, id, "Router Set 2", UsageTypes.NAry);
                case 0x00fc: return new Usage(this, id, "Router Set 3", UsageTypes.NAry);
                case 0x0100: return new Usage(this, id, "Router Key", UsageTypes.Sel);
                case 0x0101: return new Usage(this, id, "Row Router Key", UsageTypes.Sel);
                case 0x0200: return new Usage(this, id, "Braille Buttons", UsageTypes.NAry);
                case 0x0201: return new Usage(this, id, "Braille Keyboard Dot 1", UsageTypes.Sel);
                case 0x0202: return new Usage(this, id, "Braille Keyboard Dot 2", UsageTypes.Sel);
                case 0x0203: return new Usage(this, id, "Braille Keyboard Dot 3", UsageTypes.Sel);
                case 0x0204: return new Usage(this, id, "Braille Keyboard Dot 4", UsageTypes.Sel);
                case 0x0205: return new Usage(this, id, "Braille Keyboard Dot 5", UsageTypes.Sel);
                case 0x0206: return new Usage(this, id, "Braille Keyboard Dot 6", UsageTypes.Sel);
                case 0x0207: return new Usage(this, id, "Braille Keyboard Dot 7", UsageTypes.Sel);
                case 0x0208: return new Usage(this, id, "Braille Keyboard Dot 8", UsageTypes.Sel);
                case 0x0209: return new Usage(this, id, "Braille Keyboard Space", UsageTypes.Sel);
                case 0x020a: return new Usage(this, id, "Braille Keyboard Left Space", UsageTypes.Sel);
                case 0x020b: return new Usage(this, id, "Braille Keyboard Right Space", UsageTypes.Sel);
                case 0x020c: return new Usage(this, id, "Braille Face Controls", UsageTypes.NAry);
                case 0x020d: return new Usage(this, id, "Braille Left Controls", UsageTypes.NAry);
                case 0x020e: return new Usage(this, id, "Braille Right Controls", UsageTypes.NAry);
                case 0x020f: return new Usage(this, id, "Braille Top Controls", UsageTypes.NAry);
                case 0x0210: return new Usage(this, id, "Braille Joystick Center", UsageTypes.Sel);
                case 0x0211: return new Usage(this, id, "Braille Joystick Up", UsageTypes.Sel);
                case 0x0212: return new Usage(this, id, "Braille Joystick Down", UsageTypes.Sel);
                case 0x0213: return new Usage(this, id, "Braille Joystick Left", UsageTypes.Sel);
                case 0x0214: return new Usage(this, id, "Braille Joystick Right", UsageTypes.Sel);
                case 0x0215: return new Usage(this, id, "Braille D-Pad Center", UsageTypes.Sel);
                case 0x0216: return new Usage(this, id, "Braille D-Pad Up", UsageTypes.Sel);
                case 0x0217: return new Usage(this, id, "Braille D-Pad Down", UsageTypes.Sel);
                case 0x0218: return new Usage(this, id, "Braille D-Pad Left", UsageTypes.Sel);
                case 0x0219: return new Usage(this, id, "Braille D-Pad Right", UsageTypes.Sel);
                case 0x021a: return new Usage(this, id, "Braille Pan Left", UsageTypes.Sel);
                case 0x021b: return new Usage(this, id, "Braille Pan Right", UsageTypes.Sel);
                case 0x021c: return new Usage(this, id, "Braille Rocker Up", UsageTypes.Sel);
                case 0x021d: return new Usage(this, id, "Braille Rocker Down", UsageTypes.Sel);
                case 0x021e: return new Usage(this, id, "Braille Rocker Press", UsageTypes.Sel);
            }

            return base.CreateUsage(id);
        }
    }
}
