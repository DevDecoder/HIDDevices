// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

// Auto Generated at 2022-08-16 23:04:44Z.
// Specification revision: 3.3.0; generated at 2022-03-01 02:00:40Z.

#pragma warning disable CS0108 // Member hides inherited member; missing new keyword

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;

namespace DevDecoder.HIDDevices.Usages
{
    // <summary>
    //     Lighting And Illumination Usage Page.
    // </summary>
    [Description("Lighting And Illumination Usage Page")]
    public enum LightingAndIlluminationPage : uint
    {
        // <summary>
        //     Undefined Usage.
        // </summary>
        [Description("Undefined")]
        Undefined = 0x00590000,

        // <summary>
        //     LampArray Usage.
        // </summary>
        [Description("LampArray")]
        LampArray = 0x00590001,

        // <summary>
        //     LampArrayAttributesReport Usage.
        // </summary>
        [Description("LampArrayAttributesReport")]
        LampArrayAttributesReport = 0x00590002,

        // <summary>
        //     LampCount Usage.
        // </summary>
        [Description("LampCount")]
        LampCount = 0x00590003,

        // <summary>
        //     BoundingBoxWidthInMicrometers Usage.
        // </summary>
        [Description("BoundingBoxWidthInMicrometers")]
        BoundingBoxWidthInMicrometers = 0x00590004,

        // <summary>
        //     BoundingBoxHeightInMicrometers Usage.
        // </summary>
        [Description("BoundingBoxHeightInMicrometers")]
        BoundingBoxHeightInMicrometers = 0x00590005,

        // <summary>
        //     BoundingBoxDepthInMicrometers Usage.
        // </summary>
        [Description("BoundingBoxDepthInMicrometers")]
        BoundingBoxDepthInMicrometers = 0x00590006,

        // <summary>
        //     LampArrayKind Usage.
        // </summary>
        [Description("LampArrayKind")]
        LampArrayKind = 0x00590007,

        // <summary>
        //     MinUpdateIntervalInMicroseconds Usage.
        // </summary>
        [Description("MinUpdateIntervalInMicroseconds")]
        MinUpdateIntervalInMicroseconds = 0x00590008,

        // <summary>
        //     LampAttributesRequestReport Usage.
        // </summary>
        [Description("LampAttributesRequestReport")]
        LampAttributesRequestReport = 0x00590020,

        // <summary>
        //     LampId Usage.
        // </summary>
        [Description("LampId")]
        LampId = 0x00590021,

        // <summary>
        //     LampAttributesResponseReport Usage.
        // </summary>
        [Description("LampAttributesResponseReport")]
        LampAttributesResponseReport = 0x00590022,

        // <summary>
        //     PositionXInMicrometers Usage.
        // </summary>
        [Description("PositionXInMicrometers")]
        PositionXInMicrometers = 0x00590023,

        // <summary>
        //     PositionYInMicrometers Usage.
        // </summary>
        [Description("PositionYInMicrometers")]
        PositionYInMicrometers = 0x00590024,

        // <summary>
        //     PositionZInMicrometers Usage.
        // </summary>
        [Description("PositionZInMicrometers")]
        PositionZInMicrometers = 0x00590025,

        // <summary>
        //     LampPurposes Usage.
        // </summary>
        [Description("LampPurposes")]
        LampPurposes = 0x00590026,

        // <summary>
        //     UpdateLatencyInMicroseconds Usage.
        // </summary>
        [Description("UpdateLatencyInMicroseconds")]
        UpdateLatencyInMicroseconds = 0x00590027,

        // <summary>
        //     RedLevelCount Usage.
        // </summary>
        [Description("RedLevelCount")]
        RedLevelCount = 0x00590028,

        // <summary>
        //     GreenLevelCount Usage.
        // </summary>
        [Description("GreenLevelCount")]
        GreenLevelCount = 0x00590029,

        // <summary>
        //     BlueLevelCount Usage.
        // </summary>
        [Description("BlueLevelCount")]
        BlueLevelCount = 0x0059002a,

        // <summary>
        //     IntensityLevelCount Usage.
        // </summary>
        [Description("IntensityLevelCount")]
        IntensityLevelCount = 0x0059002b,

        // <summary>
        //     IsProgrammable Usage.
        // </summary>
        [Description("IsProgrammable")]
        IsProgrammable = 0x0059002c,

        // <summary>
        //     InputBinding Usage.
        // </summary>
        [Description("InputBinding")]
        InputBinding = 0x0059002d,

        // <summary>
        //     LampMultiUpdateReport Usage.
        // </summary>
        [Description("LampMultiUpdateReport")]
        LampMultiUpdateReport = 0x00590050,

        // <summary>
        //     RedUpdateChannel Usage.
        // </summary>
        [Description("RedUpdateChannel")]
        RedUpdateChannel = 0x00590051,

        // <summary>
        //     GreenUpdateChannel Usage.
        // </summary>
        [Description("GreenUpdateChannel")]
        GreenUpdateChannel = 0x00590052,

        // <summary>
        //     BlueUpdateChannel Usage.
        // </summary>
        [Description("BlueUpdateChannel")]
        BlueUpdateChannel = 0x00590053,

        // <summary>
        //     IntensityUpdateChannel Usage.
        // </summary>
        [Description("IntensityUpdateChannel")]
        IntensityUpdateChannel = 0x00590054,

        // <summary>
        //     LampUpdateFlags Usage.
        // </summary>
        [Description("LampUpdateFlags")]
        LampUpdateFlags = 0x00590055,

        // <summary>
        //     LampRangeUpdateReport Usage.
        // </summary>
        [Description("LampRangeUpdateReport")]
        LampRangeUpdateReport = 0x00590060,

        // <summary>
        //     LampIdStart Usage.
        // </summary>
        [Description("LampIdStart")]
        LampIdStart = 0x00590061,

        // <summary>
        //     LampIdEnd Usage.
        // </summary>
        [Description("LampIdEnd")]
        LampIdEnd = 0x00590062,

        // <summary>
        //     LampArrayControlReport Usage.
        // </summary>
        [Description("LampArrayControlReport")]
        LampArrayControlReport = 0x00590070,

        // <summary>
        //     AutonomousMode Usage.
        // </summary>
        [Description("AutonomousMode")]
        AutonomousMode = 0x00590071
    }
}
