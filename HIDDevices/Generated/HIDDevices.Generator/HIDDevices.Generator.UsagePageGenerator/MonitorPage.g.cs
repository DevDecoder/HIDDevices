// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

// Specification revision: 1.3.0; generated at 2022-03-01 02:00:40Z.

#pragma warning disable CS0108 // Member hides inherited member; missing new keyword

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;

namespace DevDecoder.HIDDevices.Usages
{
    // <summary>
    //     Monitor Usage Page.
    // </summary>
    [Description("Monitor Usage Page")]
    public enum MonitorPage : uint
    {
        // <summary>
        //     Undefined Usage.
        // </summary>
        [Description("Undefined")]
        Undefined = 0x00800000,

        // <summary>
        //     Monitor Control Usage.
        // </summary>
        [Description("Monitor Control")]
        MonitorControl = 0x00800001,

        // <summary>
        //     EDID Information Usage.
        // </summary>
        [Description("EDID Information")]
        EDIDInformation = 0x00800002,

        // <summary>
        //     VDIF Information Usage.
        // </summary>
        [Description("VDIF Information")]
        VDIFInformation = 0x00800003,

        // <summary>
        //     VESA Version Usage.
        // </summary>
        [Description("VESA Version")]
        VESAVersion = 0x00800004
    }
}
