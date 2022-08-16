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
    //     Game Controls Usage Page.
    // </summary>
    public sealed class GameControlsUsagePage : UsagePage
    {
        // <summary>
        //     Singleton instance of Game Controls Usage Page.
        // </summary>
        public static readonly GameControlsUsagePage Instance = new();

        // <summary>
        //     Create singleton.
        // </summary>
        private GameControlsUsagePage() : base(0x0005, "Game Controls")
        {
        }

        /// <inheritdoc />
        protected override Usage CreateUsage(ushort id)
        {
            switch (id)
            {
                case 0x0000: return new Usage(this, id, "Undefined", UsageTypes.None);
                case 0x0001: return new Usage(this, id, "3D Game Controller", UsageTypes.CA);
                case 0x0002: return new Usage(this, id, "Pinball Device", UsageTypes.CA);
                case 0x0003: return new Usage(this, id, "Gun Device", UsageTypes.CA);
                case 0x0020: return new Usage(this, id, "Point of View", UsageTypes.CP);
                case 0x0021: return new Usage(this, id, "Turn Right/Left", UsageTypes.DV);
                case 0x0022: return new Usage(this, id, "Pitch Forward/Backward", UsageTypes.DV);
                case 0x0023: return new Usage(this, id, "Roll Right/Left", UsageTypes.DV);
                case 0x0024: return new Usage(this, id, "Move Right/Left", UsageTypes.DV);
                case 0x0025: return new Usage(this, id, "Move Forward/Backward", UsageTypes.DV);
                case 0x0026: return new Usage(this, id, "Move Up/Down", UsageTypes.DV);
                case 0x0027: return new Usage(this, id, "Lean Right/Left", UsageTypes.DV);
                case 0x0028: return new Usage(this, id, "Lean Forward/Backward", UsageTypes.DV);
                case 0x0029: return new Usage(this, id, "Height of POV", UsageTypes.DV);
                case 0x002a: return new Usage(this, id, "Flipper", UsageTypes.MC);
                case 0x002b: return new Usage(this, id, "Secondary Flipper", UsageTypes.MC);
                case 0x002c: return new Usage(this, id, "Bump", UsageTypes.MC);
                case 0x002d: return new Usage(this, id, "New Game", UsageTypes.OSC);
                case 0x002e: return new Usage(this, id, "Shoot Ball", UsageTypes.OSC);
                case 0x002f: return new Usage(this, id, "Player", UsageTypes.OSC);
                case 0x0030: return new Usage(this, id, "Gun Bolt", UsageTypes.OOC);
                case 0x0031: return new Usage(this, id, "Gun Clip", UsageTypes.OOC);
                case 0x0032: return new Usage(this, id, "Gun Selector", UsageTypes.NAry);
                case 0x0033: return new Usage(this, id, "Gun Single Shot", UsageTypes.Sel);
                case 0x0034: return new Usage(this, id, "Gun Burst", UsageTypes.Sel);
                case 0x0035: return new Usage(this, id, "Gun Automatic", UsageTypes.Sel);
                case 0x0036: return new Usage(this, id, "Gun Safety", UsageTypes.OOC);
                case 0x0037: return new Usage(this, id, "Gamepad Fire/Jump", UsageTypes.CL);
                case 0x0039: return new Usage(this, id, "Gamepad Trigger", UsageTypes.CL);
                case 0x003a: return new Usage(this, id, "Form-fitting Gamepad", UsageTypes.SF);
            }

            return base.CreateUsage(id);
        }
    }
}
