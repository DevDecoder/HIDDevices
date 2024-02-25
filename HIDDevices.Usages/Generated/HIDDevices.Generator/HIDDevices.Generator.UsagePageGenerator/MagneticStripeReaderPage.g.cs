// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

// Specification revision: 1.5.0; generated at 2024-01-08 23:33:15Z.

#pragma warning disable CS0108 // Member hides inherited member; missing new keyword

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;

namespace DevDecoder.HIDDevices.Usages
{
    // <summary>
    //     Magnetic Stripe Reader Usage Page.
    // </summary>
    [Description("Magnetic Stripe Reader Usage Page")]
    public enum MagneticStripeReaderPage : uint
    {
        // <summary>
        //     Undefined Usage.
        // </summary>
        [Description("Undefined")]
        Undefined = 0x008e0000,

        // <summary>
        //     MSR Device Read-Only Usage.
        // </summary>
        [Description("MSR Device Read-Only")]
        MSRDeviceReadOnly = 0x008e0001,

        // <summary>
        //     Track 1 Length Usage.
        // </summary>
        [Description("Track 1 Length")]
        Track1Length = 0x008e0011,

        // <summary>
        //     Track 2 Length Usage.
        // </summary>
        [Description("Track 2 Length")]
        Track2Length = 0x008e0012,

        // <summary>
        //     Track 3 Length Usage.
        // </summary>
        [Description("Track 3 Length")]
        Track3Length = 0x008e0013,

        // <summary>
        //     Track JIS Length Usage.
        // </summary>
        [Description("Track JIS Length")]
        TrackJISLength = 0x008e0014,

        // <summary>
        //     Track Data Usage.
        // </summary>
        [Description("Track Data")]
        TrackData = 0x008e0020,

        // <summary>
        //     Track 1 Data Usage.
        // </summary>
        [Description("Track 1 Data")]
        Track1Data = 0x008e0021,

        // <summary>
        //     Track 2 Data Usage.
        // </summary>
        [Description("Track 2 Data")]
        Track2Data = 0x008e0022,

        // <summary>
        //     Track 3 Data Usage.
        // </summary>
        [Description("Track 3 Data")]
        Track3Data = 0x008e0023,

        // <summary>
        //     Track JIS Data Usage.
        // </summary>
        [Description("Track JIS Data")]
        TrackJISData = 0x008e0024
    }
}
