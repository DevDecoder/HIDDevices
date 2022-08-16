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
    //     Keyboard/Keypad Usage Page.
    // </summary>
    public sealed class KeyboardKeypadUsagePage : UsagePage
    {
        // <summary>
        //     Singleton instance of Keyboard/Keypad Usage Page.
        // </summary>
        public static readonly KeyboardKeypadUsagePage Instance = new();

        // <summary>
        //     Create singleton.
        // </summary>
        private KeyboardKeypadUsagePage() : base(0x0007, "Keyboard/Keypad")
        {
        }

        /// <inheritdoc />
        protected override Usage CreateUsage(ushort id)
        {
            switch (id)
            {
                case 0x0000: return new Usage(this, id, "Undefined", UsageTypes.None);
                case 0x0001: return new Usage(this, id, "ErrorRollOver", UsageTypes.Sel);
                case 0x0002: return new Usage(this, id, "POSTFail", UsageTypes.Sel);
                case 0x0003: return new Usage(this, id, "ErrorUndefined", UsageTypes.Sel);
                case 0x0004: return new Usage(this, id, "Keyboard A", UsageTypes.Sel);
                case 0x0005: return new Usage(this, id, "Keyboard B", UsageTypes.Sel);
                case 0x0006: return new Usage(this, id, "Keyboard C", UsageTypes.Sel);
                case 0x0007: return new Usage(this, id, "Keyboard D", UsageTypes.Sel);
                case 0x0008: return new Usage(this, id, "Keyboard E", UsageTypes.Sel);
                case 0x0009: return new Usage(this, id, "Keyboard F", UsageTypes.Sel);
                case 0x000a: return new Usage(this, id, "Keyboard G", UsageTypes.Sel);
                case 0x000b: return new Usage(this, id, "Keyboard H", UsageTypes.Sel);
                case 0x000c: return new Usage(this, id, "Keyboard I", UsageTypes.Sel);
                case 0x000d: return new Usage(this, id, "Keyboard J", UsageTypes.Sel);
                case 0x000e: return new Usage(this, id, "Keyboard K", UsageTypes.Sel);
                case 0x000f: return new Usage(this, id, "Keyboard L", UsageTypes.Sel);
                case 0x0010: return new Usage(this, id, "Keyboard M", UsageTypes.Sel);
                case 0x0011: return new Usage(this, id, "Keyboard N", UsageTypes.Sel);
                case 0x0012: return new Usage(this, id, "Keyboard O", UsageTypes.Sel);
                case 0x0013: return new Usage(this, id, "Keyboard P", UsageTypes.Sel);
                case 0x0014: return new Usage(this, id, "Keyboard Q", UsageTypes.Sel);
                case 0x0015: return new Usage(this, id, "Keyboard R", UsageTypes.Sel);
                case 0x0016: return new Usage(this, id, "Keyboard S", UsageTypes.Sel);
                case 0x0017: return new Usage(this, id, "Keyboard T", UsageTypes.Sel);
                case 0x0018: return new Usage(this, id, "Keyboard U", UsageTypes.Sel);
                case 0x0019: return new Usage(this, id, "Keyboard V", UsageTypes.Sel);
                case 0x001a: return new Usage(this, id, "Keyboard W", UsageTypes.Sel);
                case 0x001b: return new Usage(this, id, "Keyboard X", UsageTypes.Sel);
                case 0x001c: return new Usage(this, id, "Keyboard Y", UsageTypes.Sel);
                case 0x001d: return new Usage(this, id, "Keyboard Z", UsageTypes.Sel);
                case 0x001e: return new Usage(this, id, "Keyboard 1 and Bang", UsageTypes.Sel);
                case 0x001f: return new Usage(this, id, "Keyboard 2 and At", UsageTypes.Sel);
                case 0x0020: return new Usage(this, id, "Keyboard 3 And Hash", UsageTypes.Sel);
                case 0x0021: return new Usage(this, id, "Keyboard 4 and Dollar", UsageTypes.Sel);
                case 0x0022: return new Usage(this, id, "Keyboard 5 and Percent", UsageTypes.Sel);
                case 0x0023: return new Usage(this, id, "Keyboard 6 and Caret", UsageTypes.Sel);
                case 0x0024: return new Usage(this, id, "Keyboard 7 and Ampersand", UsageTypes.Sel);
                case 0x0025: return new Usage(this, id, "Keyboard 8 and Star", UsageTypes.Sel);
                case 0x0026: return new Usage(this, id, "Keyboard 9 and Left Bracket", UsageTypes.Sel);
                case 0x0027: return new Usage(this, id, "Keyboard 0 and Right Bracket", UsageTypes.Sel);
                case 0x0028: return new Usage(this, id, "Keyboard Return Enter", UsageTypes.Sel);
                case 0x0029: return new Usage(this, id, "Keyboard Escape", UsageTypes.Sel);
                case 0x002a: return new Usage(this, id, "Keyboard Delete", UsageTypes.Sel);
                case 0x002b: return new Usage(this, id, "Keyboard Tab", UsageTypes.Sel);
                case 0x002c: return new Usage(this, id, "Keyboard Spacebar", UsageTypes.Sel);
                case 0x002d: return new Usage(this, id, "Keyboard Dash and Underscore", UsageTypes.Sel);
                case 0x002e: return new Usage(this, id, "Keyboard Equals and Plus", UsageTypes.Sel);
                case 0x002f: return new Usage(this, id, "Keyboard Left Brace", UsageTypes.Sel);
                case 0x0030: return new Usage(this, id, "Keyboard Right Brace", UsageTypes.Sel);
                case 0x0031: return new Usage(this, id, "Keyboard Pipe and Slash", UsageTypes.Sel);
                case 0x0032: return new Usage(this, id, "Keyboard Non-US", UsageTypes.Sel);
                case 0x0033: return new Usage(this, id, "Keyboard SemiColon and Colon", UsageTypes.Sel);
                case 0x0034: return new Usage(this, id, "Keyboard Left Apos and Double", UsageTypes.Sel);
                case 0x0035: return new Usage(this, id, "Keyboard Grave Accent and Tilde", UsageTypes.Sel);
                case 0x0036: return new Usage(this, id, "Keyboard Comma", UsageTypes.Sel);
                case 0x0037: return new Usage(this, id, "Keyboard Period", UsageTypes.Sel);
                case 0x0038: return new Usage(this, id, "Keyboard QuestionMark", UsageTypes.Sel);
                case 0x0039: return new Usage(this, id, "Keyboard Caps Lock", UsageTypes.Sel);
                case 0x003a: return new Usage(this, id, "Keyboard F1", UsageTypes.Sel);
                case 0x003b: return new Usage(this, id, "Keyboard F2", UsageTypes.Sel);
                case 0x003c: return new Usage(this, id, "Keyboard F3", UsageTypes.Sel);
                case 0x003d: return new Usage(this, id, "Keyboard F4", UsageTypes.Sel);
                case 0x003e: return new Usage(this, id, "Keyboard F5", UsageTypes.Sel);
                case 0x003f: return new Usage(this, id, "Keyboard F6", UsageTypes.Sel);
                case 0x0040: return new Usage(this, id, "Keyboard F7", UsageTypes.Sel);
                case 0x0041: return new Usage(this, id, "Keyboard F8", UsageTypes.Sel);
                case 0x0042: return new Usage(this, id, "Keyboard F9", UsageTypes.Sel);
                case 0x0043: return new Usage(this, id, "Keyboard F10", UsageTypes.Sel);
                case 0x0044: return new Usage(this, id, "Keyboard F11", UsageTypes.Sel);
                case 0x0045: return new Usage(this, id, "Keyboard F12", UsageTypes.Sel);
                case 0x0046: return new Usage(this, id, "Keyboard PrintScreen", UsageTypes.Sel);
                case 0x0047: return new Usage(this, id, "Keyboard Scroll Lock", UsageTypes.Sel);
                case 0x0048: return new Usage(this, id, "Keyboard Pause", UsageTypes.Sel);
                case 0x0049: return new Usage(this, id, "Keyboard Insert", UsageTypes.Sel);
                case 0x004a: return new Usage(this, id, "Keyboard Home", UsageTypes.Sel);
                case 0x004b: return new Usage(this, id, "Keyboard PageUp", UsageTypes.Sel);
                case 0x004c: return new Usage(this, id, "Keyboard Delete Forward", UsageTypes.Sel);
                case 0x004d: return new Usage(this, id, "Keyboard End", UsageTypes.Sel);
                case 0x004e: return new Usage(this, id, "Keyboard PageDown", UsageTypes.Sel);
                case 0x004f: return new Usage(this, id, "Keyboard RightArrow", UsageTypes.Sel);
                case 0x0050: return new Usage(this, id, "Keyboard LeftArrow", UsageTypes.Sel);
                case 0x0051: return new Usage(this, id, "Keyboard DownArrow", UsageTypes.Sel);
                case 0x0052: return new Usage(this, id, "Keyboard UpArrow", UsageTypes.Sel);
                case 0x0053: return new Usage(this, id, "Keypad Num Lock and Clear", UsageTypes.Sel);
                case 0x0054: return new Usage(this, id, "Keypad Forward Slash", UsageTypes.Sel);
                case 0x0055: return new Usage(this, id, "Keypad Star", UsageTypes.Sel);
                case 0x0056: return new Usage(this, id, "Keyboard Dash", UsageTypes.Sel);
                case 0x0057: return new Usage(this, id, "Keypad Plus", UsageTypes.Sel);
                case 0x0058: return new Usage(this, id, "Keypad ENTER", UsageTypes.Sel);
                case 0x0059: return new Usage(this, id, "Keypad 1 and End", UsageTypes.Sel);
                case 0x005a: return new Usage(this, id, "Keypad 2 and Down Arrow", UsageTypes.Sel);
                case 0x005b: return new Usage(this, id, "Keypad 3 and PageDn", UsageTypes.Sel);
                case 0x005c: return new Usage(this, id, "Keypad 4 and Left Arrow", UsageTypes.Sel);
                case 0x005d: return new Usage(this, id, "Keypad 5", UsageTypes.Sel);
                case 0x005e: return new Usage(this, id, "Keypad 6 and Right Arrow", UsageTypes.Sel);
                case 0x005f: return new Usage(this, id, "Keypad 7 and Home", UsageTypes.Sel);
                case 0x0060: return new Usage(this, id, "Keypad 8 and Up Arrow", UsageTypes.Sel);
                case 0x0061: return new Usage(this, id, "Keypad 9 and PageUp", UsageTypes.Sel);
                case 0x0062: return new Usage(this, id, "Keypad 0 and Insert", UsageTypes.Sel);
                case 0x0063: return new Usage(this, id, "Keypad Period", UsageTypes.Sel);
                case 0x0064: return new Usage(this, id, "Keyboard Non-US Slash Bar", UsageTypes.Sel);
                case 0x0065: return new Usage(this, id, "Keyboard Application", UsageTypes.Sel);
                case 0x0066: return new Usage(this, id, "Keyboard Power", UsageTypes.Sel);
                case 0x0067: return new Usage(this, id, "Keypad Equals", UsageTypes.Sel);
                case 0x0068: return new Usage(this, id, "Keyboard F13", UsageTypes.Sel);
                case 0x0069: return new Usage(this, id, "Keyboard F14", UsageTypes.Sel);
                case 0x006a: return new Usage(this, id, "Keyboard F15", UsageTypes.Sel);
                case 0x006b: return new Usage(this, id, "Keyboard F16", UsageTypes.Sel);
                case 0x006c: return new Usage(this, id, "Keyboard F17", UsageTypes.Sel);
                case 0x006d: return new Usage(this, id, "Keyboard F18", UsageTypes.Sel);
                case 0x006e: return new Usage(this, id, "Keyboard F19", UsageTypes.Sel);
                case 0x006f: return new Usage(this, id, "Keyboard F20", UsageTypes.Sel);
                case 0x0070: return new Usage(this, id, "Keyboard F21", UsageTypes.Sel);
                case 0x0071: return new Usage(this, id, "Keyboard F22", UsageTypes.Sel);
                case 0x0072: return new Usage(this, id, "Keyboard F23", UsageTypes.Sel);
                case 0x0073: return new Usage(this, id, "Keyboard F24", UsageTypes.Sel);
                case 0x0074: return new Usage(this, id, "Keyboard Execute", UsageTypes.Sel);
                case 0x0075: return new Usage(this, id, "Keyboard Help", UsageTypes.Sel);
                case 0x0076: return new Usage(this, id, "Keyboard Menu", UsageTypes.Sel);
                case 0x0077: return new Usage(this, id, "Keyboard Select", UsageTypes.Sel);
                case 0x0078: return new Usage(this, id, "Keyboard Stop", UsageTypes.Sel);
                case 0x0079: return new Usage(this, id, "Keyboard Again", UsageTypes.Sel);
                case 0x007a: return new Usage(this, id, "Keyboard Undo", UsageTypes.Sel);
                case 0x007b: return new Usage(this, id, "Keyboard Cut", UsageTypes.Sel);
                case 0x007c: return new Usage(this, id, "Keyboard Copy", UsageTypes.Sel);
                case 0x007d: return new Usage(this, id, "Keyboard Paste", UsageTypes.Sel);
                case 0x007e: return new Usage(this, id, "Keyboard Find", UsageTypes.Sel);
                case 0x007f: return new Usage(this, id, "Keyboard Mute", UsageTypes.Sel);
                case 0x0080: return new Usage(this, id, "Keyboard Volume Up", UsageTypes.Sel);
                case 0x0081: return new Usage(this, id, "Keyboard Volume Down", UsageTypes.Sel);
                case 0x0082: return new Usage(this, id, "Keyboard Locking Caps Lock", UsageTypes.Sel);
                case 0x0083: return new Usage(this, id, "Keyboard Locking Num Lock", UsageTypes.Sel);
                case 0x0084: return new Usage(this, id, "Keyboard Locking Scroll Lock", UsageTypes.Sel);
                case 0x0085: return new Usage(this, id, "Keypad Comma", UsageTypes.Sel);
                case 0x0086: return new Usage(this, id, "Keypad Equal Sign", UsageTypes.Sel);
                case 0x0087: return new Usage(this, id, "Keyboard International1", UsageTypes.Sel);
                case 0x0088: return new Usage(this, id, "Keyboard International2", UsageTypes.Sel);
                case 0x0089: return new Usage(this, id, "Keyboard International3", UsageTypes.Sel);
                case 0x008a: return new Usage(this, id, "Keyboard International4", UsageTypes.Sel);
                case 0x008b: return new Usage(this, id, "Keyboard International5", UsageTypes.Sel);
                case 0x008c: return new Usage(this, id, "Keyboard International6", UsageTypes.Sel);
                case 0x008d: return new Usage(this, id, "Keyboard International7", UsageTypes.Sel);
                case 0x008e: return new Usage(this, id, "Keyboard International8", UsageTypes.Sel);
                case 0x008f: return new Usage(this, id, "Keyboard International9", UsageTypes.Sel);
                case 0x0090: return new Usage(this, id, "Keyboard LANG1", UsageTypes.Sel);
                case 0x0091: return new Usage(this, id, "Keyboard LANG2", UsageTypes.Sel);
                case 0x0092: return new Usage(this, id, "Keyboard LANG3", UsageTypes.Sel);
                case 0x0093: return new Usage(this, id, "Keyboard LANG4", UsageTypes.Sel);
                case 0x0094: return new Usage(this, id, "Keyboard LANG5", UsageTypes.Sel);
                case 0x0095: return new Usage(this, id, "Keyboard LANG6", UsageTypes.Sel);
                case 0x0096: return new Usage(this, id, "Keyboard LANG7", UsageTypes.Sel);
                case 0x0097: return new Usage(this, id, "Keyboard LANG8", UsageTypes.Sel);
                case 0x0098: return new Usage(this, id, "Keyboard LANG9", UsageTypes.Sel);
                case 0x0099: return new Usage(this, id, "Keyboard Alternate Erase", UsageTypes.Sel);
                case 0x009a: return new Usage(this, id, "Keyboard SysReq Attention", UsageTypes.Sel);
                case 0x009b: return new Usage(this, id, "Keyboard Cancel", UsageTypes.Sel);
                case 0x009c: return new Usage(this, id, "Keyboard Clear", UsageTypes.Sel);
                case 0x009d: return new Usage(this, id, "Keyboard Prior", UsageTypes.Sel);
                case 0x009e: return new Usage(this, id, "Keyboard Return", UsageTypes.Sel);
                case 0x009f: return new Usage(this, id, "Keyboard Separator", UsageTypes.Sel);
                case 0x00a0: return new Usage(this, id, "Keyboard Out", UsageTypes.Sel);
                case 0x00a1: return new Usage(this, id, "Keyboard Oper", UsageTypes.Sel);
                case 0x00a2: return new Usage(this, id, "Keyboard Clear Again", UsageTypes.Sel);
                case 0x00a3: return new Usage(this, id, "Keyboard CrSel Props", UsageTypes.Sel);
                case 0x00a4: return new Usage(this, id, "Keyboard ExSel", UsageTypes.Sel);
                case 0x00b0: return new Usage(this, id, "Keypad Double 0", UsageTypes.Sel);
                case 0x00b1: return new Usage(this, id, "Keypad Triple 0", UsageTypes.Sel);
                case 0x00b2: return new Usage(this, id, "Thousands Separator", UsageTypes.Sel);
                case 0x00b3: return new Usage(this, id, "Decimal Separator", UsageTypes.Sel);
                case 0x00b4: return new Usage(this, id, "Currency Unit", UsageTypes.Sel);
                case 0x00b5: return new Usage(this, id, "Currency Sub-unit", UsageTypes.Sel);
                case 0x00b6: return new Usage(this, id, "Keypad Left Bracket", UsageTypes.Sel);
                case 0x00b7: return new Usage(this, id, "Keypad Right Bracket", UsageTypes.Sel);
                case 0x00b8: return new Usage(this, id, "Keypad Left Brace", UsageTypes.Sel);
                case 0x00b9: return new Usage(this, id, "Keypad Right Brace", UsageTypes.Sel);
                case 0x00ba: return new Usage(this, id, "Keypad Tab", UsageTypes.Sel);
                case 0x00bb: return new Usage(this, id, "Keypad Backspace", UsageTypes.Sel);
                case 0x00bc: return new Usage(this, id, "Keypad A", UsageTypes.Sel);
                case 0x00bd: return new Usage(this, id, "Keypad B", UsageTypes.Sel);
                case 0x00be: return new Usage(this, id, "Keypad C", UsageTypes.Sel);
                case 0x00bf: return new Usage(this, id, "Keypad D", UsageTypes.Sel);
                case 0x00c0: return new Usage(this, id, "Keypad E", UsageTypes.Sel);
                case 0x00c1: return new Usage(this, id, "Keypad F", UsageTypes.Sel);
                case 0x00c2: return new Usage(this, id, "Keypad XOR", UsageTypes.Sel);
                case 0x00c3: return new Usage(this, id, "Keypad Caret", UsageTypes.Sel);
                case 0x00c4: return new Usage(this, id, "Keypad Percentage", UsageTypes.Sel);
                case 0x00c5: return new Usage(this, id, "Keypad Less", UsageTypes.Sel);
                case 0x00c6: return new Usage(this, id, "Keypad Greater", UsageTypes.Sel);
                case 0x00c7: return new Usage(this, id, "Keypad Ampersand", UsageTypes.Sel);
                case 0x00c8: return new Usage(this, id, "Keypad Double Ampersand", UsageTypes.Sel);
                case 0x00c9: return new Usage(this, id, "Keypad Bar", UsageTypes.Sel);
                case 0x00ca: return new Usage(this, id, "Keypad Double Bar", UsageTypes.Sel);
                case 0x00cb: return new Usage(this, id, "Keypad Colon", UsageTypes.Sel);
                case 0x00cc: return new Usage(this, id, "Keypad Hash", UsageTypes.Sel);
                case 0x00cd: return new Usage(this, id, "Keypad Space", UsageTypes.Sel);
                case 0x00ce: return new Usage(this, id, "Keypad At", UsageTypes.Sel);
                case 0x00cf: return new Usage(this, id, "Keypad Bang", UsageTypes.Sel);
                case 0x00d0: return new Usage(this, id, "Keypad Memory Store", UsageTypes.Sel);
                case 0x00d1: return new Usage(this, id, "Keypad Memory Recall", UsageTypes.Sel);
                case 0x00d2: return new Usage(this, id, "Keypad Memory Clear", UsageTypes.Sel);
                case 0x00d3: return new Usage(this, id, "Keypad Memory Add", UsageTypes.Sel);
                case 0x00d4: return new Usage(this, id, "Keypad Memory Subtract", UsageTypes.Sel);
                case 0x00d5: return new Usage(this, id, "Keypad Memory Multiply", UsageTypes.Sel);
                case 0x00d6: return new Usage(this, id, "Keypad Memory Divide", UsageTypes.Sel);
                case 0x00d7: return new Usage(this, id, "Keypad Plus Minus", UsageTypes.Sel);
                case 0x00d8: return new Usage(this, id, "Keypad Clear", UsageTypes.Sel);
                case 0x00d9: return new Usage(this, id, "Keypad Clear Entry", UsageTypes.Sel);
                case 0x00da: return new Usage(this, id, "Keypad Binary", UsageTypes.Sel);
                case 0x00db: return new Usage(this, id, "Keypad Octal", UsageTypes.Sel);
                case 0x00dc: return new Usage(this, id, "Keypad Decimal", UsageTypes.Sel);
                case 0x00dd: return new Usage(this, id, "Keypad Hexadecimal", UsageTypes.Sel);
                case 0x00e0: return new Usage(this, id, "Keyboard LeftControl", UsageTypes.DV);
                case 0x00e1: return new Usage(this, id, "Keyboard LeftShift", UsageTypes.DV);
                case 0x00e2: return new Usage(this, id, "Keyboard LeftAlt", UsageTypes.DV);
                case 0x00e3: return new Usage(this, id, "Keyboard Left GUI", UsageTypes.DV);
                case 0x00e4: return new Usage(this, id, "Keyboard RightControl", UsageTypes.DV);
                case 0x00e5: return new Usage(this, id, "Keyboard RightShift", UsageTypes.DV);
                case 0x00e6: return new Usage(this, id, "Keyboard RightAlt", UsageTypes.DV);
                case 0x00e7: return new Usage(this, id, "Keyboard Right GUI", UsageTypes.DV);
            }

            return base.CreateUsage(id);
        }
    }
}
