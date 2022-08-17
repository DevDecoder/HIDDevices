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
    //     Generic Desktop Usage Page.
    // </summary>
    public sealed class GenericDesktopUsagePage : UsagePage
    {
        // <summary>
        //     Singleton instance of Generic Desktop Usage Page.
        // </summary>
        public static readonly GenericDesktopUsagePage Instance = new();

        // <summary>
        //     Create singleton.
        // </summary>
        private GenericDesktopUsagePage() : base(0x0001, "Generic Desktop")
        {
        }

        /// <inheritdoc />
        protected override Usage CreateUsage(ushort id)
        {
            switch (id)
            {
                case 0x0000: return new Usage(this, id, "Undefined", UsageTypes.None);
                case 0x0001: return new Usage(this, id, "Pointer", UsageTypes.CP);
                case 0x0002: return new Usage(this, id, "Mouse", UsageTypes.CA);
                case 0x0004: return new Usage(this, id, "Joystick", UsageTypes.CA);
                case 0x0005: return new Usage(this, id, "Gamepad", UsageTypes.CA);
                case 0x0006: return new Usage(this, id, "Keyboard", UsageTypes.CA);
                case 0x0007: return new Usage(this, id, "Keypad", UsageTypes.CA);
                case 0x0008: return new Usage(this, id, "Multi-axis Controller", UsageTypes.CA);
                case 0x0009: return new Usage(this, id, "Tablet PC System Controls", UsageTypes.CA);
                case 0x000a: return new Usage(this, id, "Water Cooling Device", UsageTypes.CA);
                case 0x000b: return new Usage(this, id, "Computer Chassis Device", UsageTypes.CA);
                case 0x000c: return new Usage(this, id, "Wireless Radio Controls", UsageTypes.CA);
                case 0x000d: return new Usage(this, id, "Portable Device Control", UsageTypes.CA);
                case 0x000e: return new Usage(this, id, "System Multi-Axis Controller", UsageTypes.CA);
                case 0x000f: return new Usage(this, id, "Spatial Controller", UsageTypes.CA);
                case 0x0010: return new Usage(this, id, "Assistive Control", UsageTypes.CA);
                case 0x0011: return new Usage(this, id, "Device Dock", UsageTypes.CA);
                case 0x0012: return new Usage(this, id, "Dockable Device", UsageTypes.CA);
                case 0x0013: return new Usage(this, id, "Call State Management Control", UsageTypes.CA);
                case 0x0030: return new Usage(this, id, "X", UsageTypes.DV);
                case 0x0031: return new Usage(this, id, "Y", UsageTypes.DV);
                case 0x0032: return new Usage(this, id, "Z", UsageTypes.DV);
                case 0x0033: return new Usage(this, id, "Rx", UsageTypes.DV);
                case 0x0034: return new Usage(this, id, "Ry", UsageTypes.DV);
                case 0x0035: return new Usage(this, id, "Rz", UsageTypes.DV);
                case 0x0036: return new Usage(this, id, "Slider", UsageTypes.DV);
                case 0x0037: return new Usage(this, id, "Dial", UsageTypes.DV);
                case 0x0038: return new Usage(this, id, "Wheel", UsageTypes.DV);
                case 0x0039: return new Usage(this, id, "Hat Switch", UsageTypes.DV);
                case 0x003a: return new Usage(this, id, "Counted Buffer", UsageTypes.CL);
                case 0x003b: return new Usage(this, id, "Byte Count", UsageTypes.DV);
                case 0x003c: return new Usage(this, id, "Motion Wakeup", UsageTypes.OSC|UsageTypes.DF);
                case 0x003d: return new Usage(this, id, "Start", UsageTypes.OOC);
                case 0x003e: return new Usage(this, id, "Select", UsageTypes.OOC);
                case 0x0040: return new Usage(this, id, "Vx", UsageTypes.DV);
                case 0x0041: return new Usage(this, id, "Vy", UsageTypes.DV);
                case 0x0042: return new Usage(this, id, "Vz", UsageTypes.DV);
                case 0x0043: return new Usage(this, id, "Vbrx", UsageTypes.DV);
                case 0x0044: return new Usage(this, id, "Vbry", UsageTypes.DV);
                case 0x0045: return new Usage(this, id, "Vbrz", UsageTypes.DV);
                case 0x0046: return new Usage(this, id, "Vno", UsageTypes.DV);
                case 0x0047: return new Usage(this, id, "Feature Notification", UsageTypes.DV|UsageTypes.DF);
                case 0x0048: return new Usage(this, id, "Resolution Multiplier", UsageTypes.DV);
                case 0x0049: return new Usage(this, id, "Qx", UsageTypes.DV);
                case 0x004a: return new Usage(this, id, "Qy", UsageTypes.DV);
                case 0x004b: return new Usage(this, id, "Qz", UsageTypes.DV);
                case 0x004c: return new Usage(this, id, "Qw", UsageTypes.DV);
                case 0x0080: return new Usage(this, id, "System Control", UsageTypes.CA);
                case 0x0081: return new Usage(this, id, "System Power Down", UsageTypes.OSC);
                case 0x0082: return new Usage(this, id, "System Sleep", UsageTypes.OSC);
                case 0x0083: return new Usage(this, id, "System Wake Up", UsageTypes.OSC);
                case 0x0084: return new Usage(this, id, "System Context Menu", UsageTypes.OSC);
                case 0x0085: return new Usage(this, id, "System Main Menu", UsageTypes.OSC);
                case 0x0086: return new Usage(this, id, "System App Menu", UsageTypes.OSC);
                case 0x0087: return new Usage(this, id, "System Menu Help", UsageTypes.OSC);
                case 0x0088: return new Usage(this, id, "System Menu Exit", UsageTypes.OSC);
                case 0x0089: return new Usage(this, id, "System Menu Select", UsageTypes.OSC);
                case 0x008a: return new Usage(this, id, "System Menu Right", UsageTypes.RTC);
                case 0x008b: return new Usage(this, id, "System Menu Left", UsageTypes.RTC);
                case 0x008c: return new Usage(this, id, "System Menu Up", UsageTypes.RTC);
                case 0x008d: return new Usage(this, id, "System Menu Down", UsageTypes.RTC);
                case 0x008e: return new Usage(this, id, "System Cold Restart", UsageTypes.OSC);
                case 0x008f: return new Usage(this, id, "System Warm Restart", UsageTypes.OSC);
                case 0x0090: return new Usage(this, id, "D-pad Up", UsageTypes.OOC);
                case 0x0091: return new Usage(this, id, "D-pad Down", UsageTypes.OOC);
                case 0x0092: return new Usage(this, id, "D-pad Right", UsageTypes.OOC);
                case 0x0093: return new Usage(this, id, "D-pad Left", UsageTypes.OOC);
                case 0x0094: return new Usage(this, id, "Index Trigger", UsageTypes.MC|UsageTypes.DV);
                case 0x0095: return new Usage(this, id, "Palm Trigger", UsageTypes.MC|UsageTypes.DV);
                case 0x0096: return new Usage(this, id, "Thumbstick", UsageTypes.CP);
                case 0x0097: return new Usage(this, id, "System Function Shift", UsageTypes.MC);
                case 0x0098: return new Usage(this, id, "System Function Shift Lock", UsageTypes.OOC);
                case 0x0099: return new Usage(this, id, "System Function Shift Lock Indicator", UsageTypes.DV);
                case 0x009a: return new Usage(this, id, "System Dismiss Notification", UsageTypes.OSC);
                case 0x009b: return new Usage(this, id, "System Do Not Disturb", UsageTypes.OOC);
                case 0x00a0: return new Usage(this, id, "System Dock", UsageTypes.OSC);
                case 0x00a1: return new Usage(this, id, "System Undock", UsageTypes.OSC);
                case 0x00a2: return new Usage(this, id, "System Setup", UsageTypes.OSC);
                case 0x00a3: return new Usage(this, id, "System Break", UsageTypes.OSC);
                case 0x00a4: return new Usage(this, id, "System Debugger Break", UsageTypes.OSC);
                case 0x00a5: return new Usage(this, id, "Application Break", UsageTypes.OSC);
                case 0x00a6: return new Usage(this, id, "Application Debugger Break", UsageTypes.OSC);
                case 0x00a7: return new Usage(this, id, "System Speaker Mute", UsageTypes.OSC);
                case 0x00a8: return new Usage(this, id, "System Hibernate", UsageTypes.OSC);
                case 0x00b0: return new Usage(this, id, "System Display Invert", UsageTypes.OSC);
                case 0x00b1: return new Usage(this, id, "System Display Internal", UsageTypes.OSC);
                case 0x00b2: return new Usage(this, id, "System Display External", UsageTypes.OSC);
                case 0x00b3: return new Usage(this, id, "System Display Both", UsageTypes.OSC);
                case 0x00b4: return new Usage(this, id, "System Display Dual", UsageTypes.OSC);
                case 0x00b5: return new Usage(this, id, "System Display Toggle Int/Ext Mode", UsageTypes.OSC);
                case 0x00b6: return new Usage(this, id, "System Display Swap Primary/Secondary", UsageTypes.OSC);
                case 0x00b7: return new Usage(this, id, "System Display Toggle LCD Autoscale", UsageTypes.OSC);
                case 0x00c0: return new Usage(this, id, "Sensor Zone", UsageTypes.CL);
                case 0x00c1: return new Usage(this, id, "RPM", UsageTypes.DV);
                case 0x00c2: return new Usage(this, id, "Coolant Level", UsageTypes.DV);
                case 0x00c3: return new Usage(this, id, "Coolant Critical Level", UsageTypes.SV);
                case 0x00c4: return new Usage(this, id, "Coolant Pump", UsageTypes.US);
                case 0x00c5: return new Usage(this, id, "Chassis Enclosure", UsageTypes.CL);
                case 0x00c6: return new Usage(this, id, "Wireless Radio Button", UsageTypes.OOC);
                case 0x00c7: return new Usage(this, id, "Wireless Radio LED", UsageTypes.OOC);
                case 0x00c8: return new Usage(this, id, "Wireless Radio Slider Switch", UsageTypes.OOC);
                case 0x00c9: return new Usage(this, id, "System Display Rotation Lock Button", UsageTypes.OOC);
                case 0x00ca: return new Usage(this, id, "System Display Rotation Lock Slider Switch", UsageTypes.OOC);
                case 0x00cb: return new Usage(this, id, "Control Enable", UsageTypes.DF);
                case 0x00d0: return new Usage(this, id, "Dockable Device Unique ID", UsageTypes.DV);
                case 0x00d1: return new Usage(this, id, "Dockable Device Vendor ID", UsageTypes.DV);
                case 0x00d2: return new Usage(this, id, "Dockable Device Primary Usage Page", UsageTypes.DV);
                case 0x00d3: return new Usage(this, id, "Dockable Device Primary Usage ID", UsageTypes.DV);
                case 0x00d4: return new Usage(this, id, "Dockable Device Docking State", UsageTypes.DF);
                case 0x00d5: return new Usage(this, id, "Dockable Device Display Occlusion", UsageTypes.CL);
                case 0x00d6: return new Usage(this, id, "Dockable Device Object Type", UsageTypes.DV);
                case 0x00e0: return new Usage(this, id, "Call Active LED", UsageTypes.OOC);
                case 0x00e1: return new Usage(this, id, "Call Mute Toggle", UsageTypes.OSC);
                case 0x00e2: return new Usage(this, id, "Call Mute LED", UsageTypes.OOC);
            }

            return base.CreateUsage(id);
        }
    }
}
