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
    //     VR Controls Usage Page.
    // </summary>
    [Description("VR Controls Usage Page")]
    public enum VRControlsPage : uint
    {
        // <summary>
        //     Undefined Usage.
        // </summary>
        [Description("Undefined")]
        Undefined = 0x00030000,

        // <summary>
        //     Belt Usage.
        // </summary>
        [Description("Belt")]
        Belt = 0x00030001,

        // <summary>
        //     Body Suit Usage.
        // </summary>
        [Description("Body Suit")]
        BodySuit = 0x00030002,

        // <summary>
        //     Flexor Usage.
        // </summary>
        [Description("Flexor")]
        Flexor = 0x00030003,

        // <summary>
        //     Glove Usage.
        // </summary>
        [Description("Glove")]
        Glove = 0x00030004,

        // <summary>
        //     Head Tracker Usage.
        // </summary>
        [Description("Head Tracker")]
        HeadTracker = 0x00030005,

        // <summary>
        //     Head Mounted Display Usage.
        // </summary>
        [Description("Head Mounted Display")]
        HeadMountedDisplay = 0x00030006,

        // <summary>
        //     Hand Tracker Usage.
        // </summary>
        [Description("Hand Tracker")]
        HandTracker = 0x00030007,

        // <summary>
        //     Oculometer Usage.
        // </summary>
        [Description("Oculometer")]
        Oculometer = 0x00030008,

        // <summary>
        //     Vest Usage.
        // </summary>
        [Description("Vest")]
        Vest = 0x00030009,

        // <summary>
        //     Animatronic Device Usage.
        // </summary>
        [Description("Animatronic Device")]
        AnimatronicDevice = 0x0003000a,

        // <summary>
        //     Stereo Enable Usage.
        // </summary>
        [Description("Stereo Enable")]
        StereoEnable = 0x00030020,

        // <summary>
        //     Display Enable Usage.
        // </summary>
        [Description("Display Enable")]
        DisplayEnable = 0x00030021
    }
}
