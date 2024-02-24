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
    //     Barcode Scanner Usage Page.
    // </summary>
    public sealed class BarcodeScannerUsagePage : UsagePage
    {
        // <summary>
        //     Singleton instance of Barcode Scanner Usage Page.
        // </summary>
        public static readonly BarcodeScannerUsagePage Instance = new();

        // <summary>
        //     Create singleton.
        // </summary>
        private BarcodeScannerUsagePage() : base(0x008c, "Barcode Scanner")
        {
        }

        /// <inheritdoc />
        protected override Usage CreateUsage(ushort id)
        {
            switch (id)
            {
                case 0x0000: return new Usage(this, id, "Undefined", UsageTypes.None);
                case 0x0001: return new Usage(this, id, "Barcode Badge Reader", UsageTypes.CA);
                case 0x0002: return new Usage(this, id, "Barcode Scanner", UsageTypes.CA);
                case 0x0003: return new Usage(this, id, "Dumb Bar Code Scanner", UsageTypes.CA);
                case 0x0004: return new Usage(this, id, "Cordless Scanner Base", UsageTypes.CA);
                case 0x0005: return new Usage(this, id, "Bar Code Scanner Cradle", UsageTypes.CA);
                case 0x0010: return new Usage(this, id, "Attribute Report", UsageTypes.CL);
                case 0x0011: return new Usage(this, id, "Settings Report", UsageTypes.CL);
                case 0x0012: return new Usage(this, id, "Scanned Data Report", UsageTypes.CL);
                case 0x0013: return new Usage(this, id, "Raw Scanned Data Report", UsageTypes.CL);
                case 0x0014: return new Usage(this, id, "Trigger Report", UsageTypes.CL);
                case 0x0015: return new Usage(this, id, "Status Report", UsageTypes.CL);
                case 0x0016: return new Usage(this, id, "UPC/EAN Control Report", UsageTypes.CL);
                case 0x0017: return new Usage(this, id, "EAN 2/3 Label Control Report", UsageTypes.CL);
                case 0x0018: return new Usage(this, id, "Code 39 Control Report", UsageTypes.CL);
                case 0x0019: return new Usage(this, id, "Interleaved 2 of 5 Control Report", UsageTypes.CL);
                case 0x001a: return new Usage(this, id, "Standard 2 of 5 Control Report", UsageTypes.CL);
                case 0x001b: return new Usage(this, id, "MSI Plessey Control Report", UsageTypes.CL);
                case 0x001c: return new Usage(this, id, "Codabar Control Report", UsageTypes.CL);
                case 0x001d: return new Usage(this, id, "Code 128 Control Report", UsageTypes.CL);
                case 0x001e: return new Usage(this, id, "Misc 1D Control Report", UsageTypes.CL);
                case 0x001f: return new Usage(this, id, "2D Control Report", UsageTypes.CL);
                case 0x0030: return new Usage(this, id, "Aiming/Pointer Mode", UsageTypes.SF);
                case 0x0031: return new Usage(this, id, "Bar Code Present Sensor", UsageTypes.SF);
                case 0x0032: return new Usage(this, id, "Class 1A Laser", UsageTypes.SF);
                case 0x0033: return new Usage(this, id, "Class 2 Laser", UsageTypes.SF);
                case 0x0034: return new Usage(this, id, "Heater Present", UsageTypes.SF);
                case 0x0035: return new Usage(this, id, "Contact Scanner", UsageTypes.SF);
                case 0x0036: return new Usage(this, id, "Electronic Article Surveillance Notification", UsageTypes.SF);
                case 0x0037: return new Usage(this, id, "Constant Electronic Article Surveillance", UsageTypes.SF);
                case 0x0038: return new Usage(this, id, "Error Indication", UsageTypes.SF);
                case 0x0039: return new Usage(this, id, "Fixed Beeper", UsageTypes.SF);
                case 0x003a: return new Usage(this, id, "Good Decode Indication", UsageTypes.SF);
                case 0x003b: return new Usage(this, id, "Hands Free Scanning", UsageTypes.SF);
                case 0x003c: return new Usage(this, id, "Intrinsically Safe", UsageTypes.SF);
                case 0x003d: return new Usage(this, id, "Klasse Eins Laser", UsageTypes.SF);
                case 0x003e: return new Usage(this, id, "Long Range Scanner", UsageTypes.SF);
                case 0x003f: return new Usage(this, id, "Mirror Speed Control", UsageTypes.SF);
                case 0x0040: return new Usage(this, id, "Not On File Indication", UsageTypes.SF);
                case 0x0041: return new Usage(this, id, "Programmable Beeper", UsageTypes.SF);
                case 0x0042: return new Usage(this, id, "Triggerless", UsageTypes.SF);
                case 0x0043: return new Usage(this, id, "Wand", UsageTypes.SF);
                case 0x0044: return new Usage(this, id, "Water Resistant", UsageTypes.SF);
                case 0x0045: return new Usage(this, id, "Multi-Range Scanner", UsageTypes.SF);
                case 0x0046: return new Usage(this, id, "Proximity Sensor", UsageTypes.SF);
                case 0x004d: return new Usage(this, id, "Fragment Decoding", UsageTypes.DF);
                case 0x004e: return new Usage(this, id, "Scanner Read Confidence", UsageTypes.DV);
                case 0x004f: return new Usage(this, id, "Data Prefix", UsageTypes.NAry);
                case 0x0050: return new Usage(this, id, "Prefix AIMI", UsageTypes.Sel);
                case 0x0051: return new Usage(this, id, "Prefix None", UsageTypes.Sel);
                case 0x0052: return new Usage(this, id, "Prefix Proprietary", UsageTypes.Sel);
                case 0x0055: return new Usage(this, id, "Active Time", UsageTypes.DV);
                case 0x0056: return new Usage(this, id, "Aiming Laser Pattern", UsageTypes.DF);
                case 0x0057: return new Usage(this, id, "Bar Code Present", UsageTypes.OOC);
                case 0x0058: return new Usage(this, id, "Beeper State", UsageTypes.OOC);
                case 0x0059: return new Usage(this, id, "Laser On Time", UsageTypes.DV);
                case 0x005a: return new Usage(this, id, "Laser State", UsageTypes.OOC);
                case 0x005b: return new Usage(this, id, "Lockout Time", UsageTypes.DV);
                case 0x005c: return new Usage(this, id, "Motor State", UsageTypes.OOC);
                case 0x005d: return new Usage(this, id, "Motor Timeout", UsageTypes.DV);
                case 0x005e: return new Usage(this, id, "Power On Reset Scanner", UsageTypes.DF);
                case 0x005f: return new Usage(this, id, "Prevent Read of Barcodes", UsageTypes.DF);
                case 0x0060: return new Usage(this, id, "Initiate Barcode Read", UsageTypes.DF);
                case 0x0061: return new Usage(this, id, "Trigger State", UsageTypes.OOC);
                case 0x0062: return new Usage(this, id, "Trigger Mode", UsageTypes.NAry);
                case 0x0063: return new Usage(this, id, "Trigger Mode Blinking Laser On", UsageTypes.Sel);
                case 0x0064: return new Usage(this, id, "Trigger Mode Continuous Laser On", UsageTypes.Sel);
                case 0x0065: return new Usage(this, id, "Trigger Mode Laser on while Pulled", UsageTypes.Sel);
                case 0x0066: return new Usage(this, id, "Trigger Mode Laser stays on after release", UsageTypes.Sel);
                case 0x006d: return new Usage(this, id, "Commit Parameters to NVM", UsageTypes.DF);
                case 0x006e: return new Usage(this, id, "Parameter Scanning", UsageTypes.DF);
                case 0x006f: return new Usage(this, id, "Parameters Changed", UsageTypes.OOC);
                case 0x0070: return new Usage(this, id, "Set parameter default values", UsageTypes.DF);
                case 0x0075: return new Usage(this, id, "Scanner In Cradle", UsageTypes.OOC);
                case 0x0076: return new Usage(this, id, "Scanner In Range", UsageTypes.OOC);
                case 0x007a: return new Usage(this, id, "Aim Duration", UsageTypes.DV);
                case 0x007b: return new Usage(this, id, "Good Read Lamp Duration", UsageTypes.DV);
                case 0x007c: return new Usage(this, id, "Good Read Lamp Intensity", UsageTypes.DV);
                case 0x007d: return new Usage(this, id, "Good Read LED", UsageTypes.DF);
                case 0x007e: return new Usage(this, id, "Good Read Tone Frequency", UsageTypes.DV);
                case 0x007f: return new Usage(this, id, "Good Read Tone Length", UsageTypes.DV);
                case 0x0080: return new Usage(this, id, "Good Read Tone Volume", UsageTypes.DV);
                case 0x0082: return new Usage(this, id, "No Read Message", UsageTypes.DF);
                case 0x0083: return new Usage(this, id, "Not on File Volume", UsageTypes.DV);
                case 0x0084: return new Usage(this, id, "Powerup Beep", UsageTypes.DF);
                case 0x0085: return new Usage(this, id, "Sound Error Beep", UsageTypes.DF);
                case 0x0086: return new Usage(this, id, "Sound Good Read Beep", UsageTypes.DF);
                case 0x0087: return new Usage(this, id, "Sound Not On File Beep", UsageTypes.DF);
                case 0x0088: return new Usage(this, id, "Good Read When to Write", UsageTypes.NAry);
                case 0x0089: return new Usage(this, id, "GRWTI After Decode", UsageTypes.Sel);
                case 0x008a: return new Usage(this, id, "GRWTI Beep/Lamp after transmit", UsageTypes.Sel);
                case 0x008b: return new Usage(this, id, "GRWTI No Beep/Lamp use at all", UsageTypes.Sel);
                case 0x0091: return new Usage(this, id, "Bookland EAN", UsageTypes.DF);
                case 0x0092: return new Usage(this, id, "Convert EAN 8 to 13 Type", UsageTypes.DF);
                case 0x0093: return new Usage(this, id, "Convert UPC A to EAN-13", UsageTypes.DF);
                case 0x0094: return new Usage(this, id, "Convert UPC-E to A", UsageTypes.DF);
                case 0x0095: return new Usage(this, id, "EAN-13", UsageTypes.DF);
                case 0x0096: return new Usage(this, id, "EAN-8", UsageTypes.DF);
                case 0x0097: return new Usage(this, id, "EAN-99 128 Mandatory", UsageTypes.DF);
                case 0x0098: return new Usage(this, id, "EAN-99 P5/128 Optional", UsageTypes.DF);
                case 0x0099: return new Usage(this, id, "Enable EAN Two Label", UsageTypes.DF);
                case 0x009a: return new Usage(this, id, "UPC/EAN", UsageTypes.DF);
                case 0x009b: return new Usage(this, id, "UPC/EAN Coupon Code", UsageTypes.DF);
                case 0x009c: return new Usage(this, id, "UPC/EAN Periodicals", UsageTypes.DV);
                case 0x009d: return new Usage(this, id, "UPC-A", UsageTypes.DF);
                case 0x009e: return new Usage(this, id, "UPC-A with 128 Mandatory", UsageTypes.DF);
                case 0x009f: return new Usage(this, id, "UPC-A with 128 Optional", UsageTypes.DF);
                case 0x00a0: return new Usage(this, id, "UPC-A with P5 Optional", UsageTypes.DF);
                case 0x00a1: return new Usage(this, id, "UPC-E", UsageTypes.DF);
                case 0x00a2: return new Usage(this, id, "UPC-E1", UsageTypes.DF);
                case 0x00a9: return new Usage(this, id, "Periodical", UsageTypes.NAry);
                case 0x00aa: return new Usage(this, id, "Periodical Auto-Discriminate +2", UsageTypes.Sel);
                case 0x00ab: return new Usage(this, id, "Periodical Only Decode with +2", UsageTypes.Sel);
                case 0x00ac: return new Usage(this, id, "Periodical Ignore +2", UsageTypes.Sel);
                case 0x00ad: return new Usage(this, id, "Periodical Auto-Discriminate +5", UsageTypes.Sel);
                case 0x00ae: return new Usage(this, id, "Periodical Only Decode with +5", UsageTypes.Sel);
                case 0x00af: return new Usage(this, id, "Periodical Ignore +5", UsageTypes.Sel);
                case 0x00b0: return new Usage(this, id, "Check", UsageTypes.NAry);
                case 0x00b1: return new Usage(this, id, "Check Disable Price", UsageTypes.Sel);
                case 0x00b2: return new Usage(this, id, "Check Enable 4 digit Price", UsageTypes.Sel);
                case 0x00b3: return new Usage(this, id, "Check Enable 5 digit Price", UsageTypes.Sel);
                case 0x00b4: return new Usage(this, id, "Check Enable European 4 digit Price", UsageTypes.Sel);
                case 0x00b5: return new Usage(this, id, "Check Enable European 5 digit Price", UsageTypes.Sel);
                case 0x00b7: return new Usage(this, id, "EAN Two Label", UsageTypes.DF);
                case 0x00b8: return new Usage(this, id, "EAN Three Label", UsageTypes.DF);
                case 0x00b9: return new Usage(this, id, "EAN 8 Flag Digit 1", UsageTypes.DV);
                case 0x00ba: return new Usage(this, id, "EAN 8 Flag Digit 2", UsageTypes.DV);
                case 0x00bb: return new Usage(this, id, "EAN 8 Flag Digit 3", UsageTypes.DV);
                case 0x00bc: return new Usage(this, id, "EAN 13 Flag Digit 1", UsageTypes.DV);
                case 0x00bd: return new Usage(this, id, "EAN 13 Flag Digit 2", UsageTypes.DV);
                case 0x00be: return new Usage(this, id, "EAN 13 Flag Digit 3", UsageTypes.DV);
                case 0x00bf: return new Usage(this, id, "Add EAN 2/3 Label Definition", UsageTypes.DF);
                case 0x00c0: return new Usage(this, id, "Clear all EAN 2/3 Label Definitions", UsageTypes.DF);
                case 0x00c3: return new Usage(this, id, "Codabar", UsageTypes.DF);
                case 0x00c4: return new Usage(this, id, "Code 128", UsageTypes.DF);
                case 0x00c7: return new Usage(this, id, "Code 39", UsageTypes.DF);
                case 0x00c8: return new Usage(this, id, "Code 93", UsageTypes.DF);
                case 0x00c9: return new Usage(this, id, "Full ASCII Conversion", UsageTypes.DF);
                case 0x00ca: return new Usage(this, id, "Interleaved 2 of 5", UsageTypes.DF);
                case 0x00cb: return new Usage(this, id, "Italian Pharmacy Code", UsageTypes.DF);
                case 0x00cc: return new Usage(this, id, "MSI/Plessey", UsageTypes.DF);
                case 0x00cd: return new Usage(this, id, "Standard 2 of 5 IATA", UsageTypes.DF);
                case 0x00ce: return new Usage(this, id, "Standard 2 of 5", UsageTypes.DF);
                case 0x00d3: return new Usage(this, id, "Transmit Start/Stop", UsageTypes.DF);
                case 0x00d4: return new Usage(this, id, "Tri-Optic", UsageTypes.DF);
                case 0x00d5: return new Usage(this, id, "UCC/EAN-128", UsageTypes.DF);
                case 0x00d6: return new Usage(this, id, "Check Digit", UsageTypes.NAry);
                case 0x00d7: return new Usage(this, id, "Check Digit Disable", UsageTypes.Sel);
                case 0x00d8: return new Usage(this, id, "Check Digit Enable Interleaved 2 of 5 OPCC", UsageTypes.Sel);
                case 0x00d9: return new Usage(this, id, "Check Digit Enable Interleaved 2 of 5 USS", UsageTypes.Sel);
                case 0x00da: return new Usage(this, id, "Check Digit Enable Standard 2 of 5 OPCC", UsageTypes.Sel);
                case 0x00db: return new Usage(this, id, "Check Digit Enable Standard 2 of 5 USS", UsageTypes.Sel);
                case 0x00dc: return new Usage(this, id, "Check Digit Enable One MSI Plessey", UsageTypes.Sel);
                case 0x00dd: return new Usage(this, id, "Check Digit Enable Two MSI Plessey", UsageTypes.Sel);
                case 0x00de: return new Usage(this, id, "Check Digit Codabar Enable", UsageTypes.Sel);
                case 0x00df: return new Usage(this, id, "Check Digit Code 39 Enable", UsageTypes.Sel);
                case 0x00f0: return new Usage(this, id, "Transmit Check Digit", UsageTypes.NAry);
                case 0x00f1: return new Usage(this, id, "Disable Check Digit Transmit", UsageTypes.Sel);
                case 0x00f2: return new Usage(this, id, "Enable Check Digit Transmit", UsageTypes.Sel);
                case 0x00fb: return new Usage(this, id, "Symbology Identifier 1", UsageTypes.DV);
                case 0x00fc: return new Usage(this, id, "Symbology Identifier 2", UsageTypes.DV);
                case 0x00fd: return new Usage(this, id, "Symbology Identifier 3", UsageTypes.DV);
                case 0x00fe: return new Usage(this, id, "Decoded Data", UsageTypes.DV);
                case 0x00ff: return new Usage(this, id, "Decode Data Continued", UsageTypes.DF);
                case 0x0100: return new Usage(this, id, "Bar Space Data", UsageTypes.DV);
                case 0x0101: return new Usage(this, id, "Scanner Data Accuracy", UsageTypes.DV);
                case 0x0102: return new Usage(this, id, "Raw Data Polarity", UsageTypes.NAry);
                case 0x0103: return new Usage(this, id, "Polarity Inverted Bar Code", UsageTypes.Sel);
                case 0x0104: return new Usage(this, id, "Polarity Normal Bar Code", UsageTypes.Sel);
                case 0x0106: return new Usage(this, id, "Minimum Length to Decode", UsageTypes.DV);
                case 0x0107: return new Usage(this, id, "Maximum Length to Decode", UsageTypes.DV);
                case 0x0108: return new Usage(this, id, "Discrete Length to Decode 1", UsageTypes.DV);
                case 0x0109: return new Usage(this, id, "Discrete Length to Decode 2", UsageTypes.DV);
                case 0x010a: return new Usage(this, id, "Data Length Method", UsageTypes.NAry);
                case 0x010b: return new Usage(this, id, "DL Method Read any", UsageTypes.Sel);
                case 0x010c: return new Usage(this, id, "DL Method Check in Range", UsageTypes.Sel);
                case 0x010d: return new Usage(this, id, "DL Method Check for Discrete", UsageTypes.Sel);
                case 0x0110: return new Usage(this, id, "Aztec Code", UsageTypes.DF);
                case 0x0111: return new Usage(this, id, "BC412", UsageTypes.DF);
                case 0x0112: return new Usage(this, id, "Channel Code", UsageTypes.DF);
                case 0x0113: return new Usage(this, id, "Code 16", UsageTypes.DF);
                case 0x0114: return new Usage(this, id, "Code 32", UsageTypes.DF);
                case 0x0115: return new Usage(this, id, "Code 49", UsageTypes.DF);
                case 0x0116: return new Usage(this, id, "Code One", UsageTypes.DF);
                case 0x0117: return new Usage(this, id, "Colorcode", UsageTypes.DF);
                case 0x0118: return new Usage(this, id, "Data Matrix", UsageTypes.DF);
                case 0x0119: return new Usage(this, id, "MaxiCode", UsageTypes.DF);
                case 0x011a: return new Usage(this, id, "MicroPDF", UsageTypes.DF);
                case 0x011b: return new Usage(this, id, "PDF-417", UsageTypes.DF);
                case 0x011c: return new Usage(this, id, "PosiCode", UsageTypes.DF);
                case 0x011d: return new Usage(this, id, "QR Code", UsageTypes.DF);
                case 0x011e: return new Usage(this, id, "SuperCode", UsageTypes.DF);
                case 0x011f: return new Usage(this, id, "UltraCode", UsageTypes.DF);
                case 0x0120: return new Usage(this, id, "USD-5 (Slug Code)", UsageTypes.DF);
                case 0x0121: return new Usage(this, id, "VeriCode", UsageTypes.DF);
            }

            return base.CreateUsage(id);
        }
    }
}
