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
    //     Simulation Controls Usage Page.
    // </summary>
    public sealed class SimulationControlsUsagePage : UsagePage
    {
        // <summary>
        //     Singleton instance of Simulation Controls Usage Page.
        // </summary>
        public static readonly SimulationControlsUsagePage Instance = new();

        // <summary>
        //     Create singleton.
        // </summary>
        private SimulationControlsUsagePage() : base(0x0002, "Simulation Controls")
        {
        }

        /// <inheritdoc />
        protected override Usage CreateUsage(ushort id)
        {
            switch (id)
            {
                case 0x0000: return new Usage(this, id, "Undefined", UsageTypes.None);
                case 0x0001: return new Usage(this, id, "Flight Simulation Device", UsageTypes.CA);
                case 0x0002: return new Usage(this, id, "Automobile Simulation Device", UsageTypes.CA);
                case 0x0003: return new Usage(this, id, "Tank Simulation Device", UsageTypes.CA);
                case 0x0004: return new Usage(this, id, "Spaceship Simulation Device", UsageTypes.CA);
                case 0x0005: return new Usage(this, id, "Submarine Simulation Device", UsageTypes.CA);
                case 0x0006: return new Usage(this, id, "Sailing Simulation Device", UsageTypes.CA);
                case 0x0007: return new Usage(this, id, "Motorcycle Simulation Device", UsageTypes.CA);
                case 0x0008: return new Usage(this, id, "Sports Simulation Device", UsageTypes.CA);
                case 0x0009: return new Usage(this, id, "Airplane Simulation Device", UsageTypes.CA);
                case 0x000a: return new Usage(this, id, "Helicopter Simulation Device", UsageTypes.CA);
                case 0x000b: return new Usage(this, id, "Magic Carpet Simulation Device", UsageTypes.CA);
                case 0x000c: return new Usage(this, id, "Bicycle Simulation Device", UsageTypes.CA);
                case 0x0020: return new Usage(this, id, "Flight Control Stick", UsageTypes.CA);
                case 0x0021: return new Usage(this, id, "Flight Stick", UsageTypes.CA);
                case 0x0022: return new Usage(this, id, "Cyclic Control", UsageTypes.CP);
                case 0x0023: return new Usage(this, id, "Cyclic Trim", UsageTypes.CP);
                case 0x0024: return new Usage(this, id, "Flight Yoke", UsageTypes.CA);
                case 0x0025: return new Usage(this, id, "Track Control", UsageTypes.CP);
                case 0x00b0: return new Usage(this, id, "Aileron", UsageTypes.DV);
                case 0x00b1: return new Usage(this, id, "Aileron Trim", UsageTypes.DV);
                case 0x00b2: return new Usage(this, id, "Anti-Torque Control", UsageTypes.DV);
                case 0x00b3: return new Usage(this, id, "Autopilot Enable", UsageTypes.OOC);
                case 0x00b4: return new Usage(this, id, "Chaff Release", UsageTypes.OSC);
                case 0x00b5: return new Usage(this, id, "Collective Control", UsageTypes.DV);
                case 0x00b6: return new Usage(this, id, "Dive Brake", UsageTypes.DV);
                case 0x00b7: return new Usage(this, id, "Electronic Countermeasures", UsageTypes.OOC);
                case 0x00b8: return new Usage(this, id, "Elevator", UsageTypes.DV);
                case 0x00b9: return new Usage(this, id, "Elevator Trim", UsageTypes.DV);
                case 0x00ba: return new Usage(this, id, "Rudder", UsageTypes.DV);
                case 0x00bb: return new Usage(this, id, "Throttle", UsageTypes.DV);
                case 0x00bc: return new Usage(this, id, "Flight Communications", UsageTypes.OOC);
                case 0x00bd: return new Usage(this, id, "Flare Release", UsageTypes.OSC);
                case 0x00be: return new Usage(this, id, "Landing Gear", UsageTypes.OOC);
                case 0x00bf: return new Usage(this, id, "Toe Brake", UsageTypes.DV);
                case 0x00c0: return new Usage(this, id, "Trigger", UsageTypes.MC);
                case 0x00c1: return new Usage(this, id, "Weapons Arm", UsageTypes.OOC);
                case 0x00c2: return new Usage(this, id, "Weapons Select", UsageTypes.OSC);
                case 0x00c3: return new Usage(this, id, "Wing Flaps", UsageTypes.DV);
                case 0x00c4: return new Usage(this, id, "Accelerator", UsageTypes.DV);
                case 0x00c5: return new Usage(this, id, "Brake", UsageTypes.DV);
                case 0x00c6: return new Usage(this, id, "Clutch", UsageTypes.DV);
                case 0x00c7: return new Usage(this, id, "Shifter", UsageTypes.DV);
                case 0x00c8: return new Usage(this, id, "Steering", UsageTypes.DV);
                case 0x00c9: return new Usage(this, id, "Turret Direction", UsageTypes.DV);
                case 0x00ca: return new Usage(this, id, "Barrel Elevation", UsageTypes.DV);
                case 0x00cb: return new Usage(this, id, "Dive Plane", UsageTypes.DV);
                case 0x00cc: return new Usage(this, id, "Ballast", UsageTypes.DV);
                case 0x00cd: return new Usage(this, id, "Bicycle Crank", UsageTypes.DV);
                case 0x00ce: return new Usage(this, id, "Handle Bars", UsageTypes.DV);
                case 0x00cf: return new Usage(this, id, "Front Brake", UsageTypes.DV);
                case 0x00d0: return new Usage(this, id, "Rear Brake", UsageTypes.DV);
            }

            return base.CreateUsage(id);
        }
    }
}
