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
    //     Auxiliary Display Usage Page.
    // </summary>
    public sealed class AuxiliaryDisplayUsagePage : UsagePage
    {
        // <summary>
        //     Singleton instance of Auxiliary Display Usage Page.
        // </summary>
        public static readonly AuxiliaryDisplayUsagePage Instance = new();

        // <summary>
        //     Create singleton.
        // </summary>
        private AuxiliaryDisplayUsagePage() : base(0x0014, "Auxiliary Display")
        {
        }

        /// <inheritdoc />
        protected override Usage CreateUsage(ushort id)
        {
            switch (id)
            {
                case 0x0000: return new Usage(this, id, "Undefined", UsageTypes.None);
                case 0x0001: return new Usage(this, id, "Alphanumeric Display", UsageTypes.CA);
                case 0x0002: return new Usage(this, id, "Auxiliary Display", UsageTypes.CA);
                case 0x0020: return new Usage(this, id, "Display Attributes Report", UsageTypes.CL);
                case 0x0021: return new Usage(this, id, "ASCII Character Set", UsageTypes.SF);
                case 0x0022: return new Usage(this, id, "Data Read Back", UsageTypes.SF);
                case 0x0023: return new Usage(this, id, "Font Read Back", UsageTypes.SF);
                case 0x0024: return new Usage(this, id, "Display Control Report", UsageTypes.CL);
                case 0x0025: return new Usage(this, id, "Clear Display", UsageTypes.DF);
                case 0x0026: return new Usage(this, id, "Display Enable", UsageTypes.DF);
                case 0x0027: return new Usage(this, id, "Screen Saver Delay", UsageTypes.SV|UsageTypes.DV);
                case 0x0028: return new Usage(this, id, "Screen Saver Enable", UsageTypes.DF);
                case 0x0029: return new Usage(this, id, "Vertical Scroll", UsageTypes.SF|UsageTypes.DF);
                case 0x002a: return new Usage(this, id, "Horizontal Scroll", UsageTypes.SF|UsageTypes.DF);
                case 0x002b: return new Usage(this, id, "Character Report", UsageTypes.CL);
                case 0x002c: return new Usage(this, id, "Display Data", UsageTypes.DV);
                case 0x002d: return new Usage(this, id, "Display Status", UsageTypes.CL);
                case 0x002e: return new Usage(this, id, "Stat Not Ready", UsageTypes.Sel);
                case 0x002f: return new Usage(this, id, "Stat Ready", UsageTypes.Sel);
                case 0x0030: return new Usage(this, id, "Err Not a loadable character", UsageTypes.Sel);
                case 0x0031: return new Usage(this, id, "Err Font data cannot be read", UsageTypes.Sel);
                case 0x0032: return new Usage(this, id, "Cursor Position Report", UsageTypes.Sel);
                case 0x0033: return new Usage(this, id, "Row", UsageTypes.DV);
                case 0x0034: return new Usage(this, id, "Column", UsageTypes.DV);
                case 0x0035: return new Usage(this, id, "Rows", UsageTypes.SV);
                case 0x0036: return new Usage(this, id, "Columns", UsageTypes.SV);
                case 0x0037: return new Usage(this, id, "Cursor Pixel Positioning", UsageTypes.SF);
                case 0x0038: return new Usage(this, id, "Cursor Mode", UsageTypes.DF);
                case 0x0039: return new Usage(this, id, "Cursor Enable", UsageTypes.DF);
                case 0x003a: return new Usage(this, id, "Cursor Blink", UsageTypes.DF);
                case 0x003b: return new Usage(this, id, "Font Report", UsageTypes.CL);
                case 0x003c: return new Usage(this, id, "Font Data", UsageTypes.BufferedBytes);
                case 0x003d: return new Usage(this, id, "Character Width", UsageTypes.SV);
                case 0x003e: return new Usage(this, id, "Character Height", UsageTypes.SV);
                case 0x003f: return new Usage(this, id, "Character Spacing Horizontal", UsageTypes.SV);
                case 0x0040: return new Usage(this, id, "Character Spacing Vertical", UsageTypes.SV);
                case 0x0041: return new Usage(this, id, "Unicode Character Set", UsageTypes.SF);
                case 0x0042: return new Usage(this, id, "Font 7-Segment", UsageTypes.SF);
                case 0x0043: return new Usage(this, id, "7-Segment Direct Map", UsageTypes.SF);
                case 0x0044: return new Usage(this, id, "Font 14-Segment", UsageTypes.SF);
                case 0x0045: return new Usage(this, id, "14-Segment Direct Map", UsageTypes.SF);
                case 0x0046: return new Usage(this, id, "Display Brightness", UsageTypes.DV);
                case 0x0047: return new Usage(this, id, "Display Contrast", UsageTypes.DV);
                case 0x0048: return new Usage(this, id, "Character Attribute", UsageTypes.CL);
                case 0x0049: return new Usage(this, id, "Attribute Readback", UsageTypes.SF);
                case 0x004a: return new Usage(this, id, "Attribute Data", UsageTypes.DV);
                case 0x004b: return new Usage(this, id, "Char Attr Enhance", UsageTypes.OOC);
                case 0x004c: return new Usage(this, id, "Char Attr Underline", UsageTypes.OOC);
                case 0x004d: return new Usage(this, id, "Char Attr Blink", UsageTypes.OOC);
                case 0x0080: return new Usage(this, id, "Bitmap Size X", UsageTypes.SV);
                case 0x0081: return new Usage(this, id, "Bitmap Size Y", UsageTypes.SV);
                case 0x0082: return new Usage(this, id, "Max Blit Size", UsageTypes.SV);
                case 0x0083: return new Usage(this, id, "Bit Depth Format", UsageTypes.SV);
                case 0x0084: return new Usage(this, id, "Display Orientation", UsageTypes.DV);
                case 0x0085: return new Usage(this, id, "Palette Report", UsageTypes.CL);
                case 0x0086: return new Usage(this, id, "Palette Data Size", UsageTypes.SV);
                case 0x0087: return new Usage(this, id, "Palette Data Offset", UsageTypes.SV);
                case 0x0088: return new Usage(this, id, "Palette Data", UsageTypes.BufferedBytes);
                case 0x008a: return new Usage(this, id, "Blit Report", UsageTypes.CL);
                case 0x008b: return new Usage(this, id, "Blit Rectangle X1", UsageTypes.SV);
                case 0x008c: return new Usage(this, id, "Blit Rectangle Y1", UsageTypes.SV);
                case 0x008d: return new Usage(this, id, "Blit Rectangle X2", UsageTypes.SV);
                case 0x008e: return new Usage(this, id, "Blit Rectangle Y2", UsageTypes.SV);
                case 0x008f: return new Usage(this, id, "Blit Data", UsageTypes.BufferedBytes);
                case 0x0090: return new Usage(this, id, "Soft Button", UsageTypes.CL);
                case 0x0091: return new Usage(this, id, "Soft Button ID", UsageTypes.SV);
                case 0x0092: return new Usage(this, id, "Soft Button Side", UsageTypes.SV);
                case 0x0093: return new Usage(this, id, "Soft Button Offset 1", UsageTypes.SV);
                case 0x0094: return new Usage(this, id, "Soft Button Offset 2", UsageTypes.SV);
                case 0x0095: return new Usage(this, id, "Soft Button Report", UsageTypes.SV);
                case 0x00c2: return new Usage(this, id, "Soft Keys", UsageTypes.SV);
                case 0x00cc: return new Usage(this, id, "Display Data Extensions", UsageTypes.SF);
                case 0x00cf: return new Usage(this, id, "Character Mapping", UsageTypes.SV);
                case 0x00dd: return new Usage(this, id, "Unicode Equivalent", UsageTypes.SV);
                case 0x00df: return new Usage(this, id, "Character Page Mapping", UsageTypes.SV);
                case 0x00ff: return new Usage(this, id, "Request Report", UsageTypes.DV);
            }

            return base.CreateUsage(id);
        }
    }
}
