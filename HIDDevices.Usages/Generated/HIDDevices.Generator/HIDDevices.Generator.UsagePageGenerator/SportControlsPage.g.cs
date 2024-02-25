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
    //     Sport Controls Usage Page.
    // </summary>
    [Description("Sport Controls Usage Page")]
    public enum SportControlsPage : uint
    {
        // <summary>
        //     Undefined Usage.
        // </summary>
        [Description("Undefined")]
        Undefined = 0x00040000,

        // <summary>
        //     Baseball Bat Usage.
        // </summary>
        [Description("Baseball Bat")]
        BaseballBat = 0x00040001,

        // <summary>
        //     Golf Club Usage.
        // </summary>
        [Description("Golf Club")]
        GolfClub = 0x00040002,

        // <summary>
        //     Rowing Machine Usage.
        // </summary>
        [Description("Rowing Machine")]
        RowingMachine = 0x00040003,

        // <summary>
        //     Treadmill Usage.
        // </summary>
        [Description("Treadmill")]
        Treadmill = 0x00040004,

        // <summary>
        //     Oar Usage.
        // </summary>
        [Description("Oar")]
        Oar = 0x00040030,

        // <summary>
        //     Slope Usage.
        // </summary>
        [Description("Slope")]
        Slope = 0x00040031,

        // <summary>
        //     Rate Usage.
        // </summary>
        [Description("Rate")]
        Rate = 0x00040032,

        // <summary>
        //     Stick Speed Usage.
        // </summary>
        [Description("Stick Speed")]
        StickSpeed = 0x00040033,

        // <summary>
        //     Stick Face Angle Usage.
        // </summary>
        [Description("Stick Face Angle")]
        StickFaceAngle = 0x00040034,

        // <summary>
        //     Stick Heel/Toe Usage.
        // </summary>
        [Description("Stick Heel/Toe")]
        StickHeelToe = 0x00040035,

        // <summary>
        //     Stick Follow Through Usage.
        // </summary>
        [Description("Stick Follow Through")]
        StickFollowThrough = 0x00040036,

        // <summary>
        //     Stick Tempo Usage.
        // </summary>
        [Description("Stick Tempo")]
        StickTempo = 0x00040037,

        // <summary>
        //     Stick Type Usage.
        // </summary>
        [Description("Stick Type")]
        StickType = 0x00040038,

        // <summary>
        //     Stick Height Usage.
        // </summary>
        [Description("Stick Height")]
        StickHeight = 0x00040039,

        // <summary>
        //     Putter Usage.
        // </summary>
        [Description("Putter")]
        Putter = 0x00040050,

        // <summary>
        //     1 Iron Usage.
        // </summary>
        [Description("1 Iron")]
        _1Iron = 0x00040051,

        // <summary>
        //     2 Iron Usage.
        // </summary>
        [Description("2 Iron")]
        _2Iron = 0x00040052,

        // <summary>
        //     3 Iron Usage.
        // </summary>
        [Description("3 Iron")]
        _3Iron = 0x00040053,

        // <summary>
        //     4 Iron Usage.
        // </summary>
        [Description("4 Iron")]
        _4Iron = 0x00040054,

        // <summary>
        //     5 Iron Usage.
        // </summary>
        [Description("5 Iron")]
        _5Iron = 0x00040055,

        // <summary>
        //     6 Iron Usage.
        // </summary>
        [Description("6 Iron")]
        _6Iron = 0x00040056,

        // <summary>
        //     7 Iron Usage.
        // </summary>
        [Description("7 Iron")]
        _7Iron = 0x00040057,

        // <summary>
        //     8 Iron Usage.
        // </summary>
        [Description("8 Iron")]
        _8Iron = 0x00040058,

        // <summary>
        //     9 Iron Usage.
        // </summary>
        [Description("9 Iron")]
        _9Iron = 0x00040059,

        // <summary>
        //     10 Iron Usage.
        // </summary>
        [Description("10 Iron")]
        _10Iron = 0x0004005a,

        // <summary>
        //     11 Iron Usage.
        // </summary>
        [Description("11 Iron")]
        _11Iron = 0x0004005b,

        // <summary>
        //     Sand Wedge Usage.
        // </summary>
        [Description("Sand Wedge")]
        SandWedge = 0x0004005c,

        // <summary>
        //     Loft Wedge Usage.
        // </summary>
        [Description("Loft Wedge")]
        LoftWedge = 0x0004005d,

        // <summary>
        //     Power Wedge Usage.
        // </summary>
        [Description("Power Wedge")]
        PowerWedge = 0x0004005e,

        // <summary>
        //     1 Wood Usage.
        // </summary>
        [Description("1 Wood")]
        _1Wood = 0x0004005f,

        // <summary>
        //     3 Wood Usage.
        // </summary>
        [Description("3 Wood")]
        _3Wood = 0x00040060,

        // <summary>
        //     5 Wood Usage.
        // </summary>
        [Description("5 Wood")]
        _5Wood = 0x00040061,

        // <summary>
        //     7 Wood Usage.
        // </summary>
        [Description("7 Wood")]
        _7Wood = 0x00040062,

        // <summary>
        //     9 Wood Usage.
        // </summary>
        [Description("9 Wood")]
        _9Wood = 0x00040063
    }
}
