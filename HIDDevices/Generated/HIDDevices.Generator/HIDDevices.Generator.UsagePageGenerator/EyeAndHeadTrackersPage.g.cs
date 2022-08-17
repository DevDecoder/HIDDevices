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
    //     Eye and Head Trackers Usage Page.
    // </summary>
    [Description("Eye and Head Trackers Usage Page")]
    public enum EyeAndHeadTrackersPage : uint
    {
        // <summary>
        //     Undefined Usage.
        // </summary>
        [Description("Undefined")]
        Undefined = 0x00120000,

        // <summary>
        //     Eye Tracker Usage.
        // </summary>
        [Description("Eye Tracker")]
        EyeTracker = 0x00120001,

        // <summary>
        //     Head Tracker Usage.
        // </summary>
        [Description("Head Tracker")]
        HeadTracker = 0x00120002,

        // <summary>
        //     Tracking Data Usage.
        // </summary>
        [Description("Tracking Data")]
        TrackingData = 0x00120010,

        // <summary>
        //     Capabilities Usage.
        // </summary>
        [Description("Capabilities")]
        Capabilities = 0x00120011,

        // <summary>
        //     Configuration Usage.
        // </summary>
        [Description("Configuration")]
        Configuration = 0x00120012,

        // <summary>
        //     Status Usage.
        // </summary>
        [Description("Status")]
        Status = 0x00120013,

        // <summary>
        //     Control Usage.
        // </summary>
        [Description("Control")]
        Control = 0x00120014,

        // <summary>
        //     Sensor Timestamp Usage.
        // </summary>
        [Description("Sensor Timestamp")]
        SensorTimestamp = 0x00120020,

        // <summary>
        //     Position X Usage.
        // </summary>
        [Description("Position X")]
        PositionX = 0x00120021,

        // <summary>
        //     Position Y Usage.
        // </summary>
        [Description("Position Y")]
        PositionY = 0x00120022,

        // <summary>
        //     Position Z Usage.
        // </summary>
        [Description("Position Z")]
        PositionZ = 0x00120023,

        // <summary>
        //     Gaze Point Usage.
        // </summary>
        [Description("Gaze Point")]
        GazePoint = 0x00120024,

        // <summary>
        //     Left Eye Position Usage.
        // </summary>
        [Description("Left Eye Position")]
        LeftEyePosition = 0x00120025,

        // <summary>
        //     Right Eye Position Usage.
        // </summary>
        [Description("Right Eye Position")]
        RightEyePosition = 0x00120026,

        // <summary>
        //     Head Position Usage.
        // </summary>
        [Description("Head Position")]
        HeadPosition = 0x00120027,

        // <summary>
        //     Head Direction Point Usage.
        // </summary>
        [Description("Head Direction Point")]
        HeadDirectionPoint = 0x00120028,

        // <summary>
        //     Rotation about X axis Usage.
        // </summary>
        [Description("Rotation about X axis")]
        RotationAboutXAxis = 0x00120029,

        // <summary>
        //     Rotation about Y axis Usage.
        // </summary>
        [Description("Rotation about Y axis")]
        RotationAboutYAxis = 0x0012002a,

        // <summary>
        //     Rotation about Z axis Usage.
        // </summary>
        [Description("Rotation about Z axis")]
        RotationAboutZAxis = 0x0012002b,

        // <summary>
        //     Tracker Quality Usage.
        // </summary>
        [Description("Tracker Quality")]
        TrackerQuality = 0x00120100,

        // <summary>
        //     Minimum Tracking Distance Usage.
        // </summary>
        [Description("Minimum Tracking Distance")]
        MinimumTrackingDistance = 0x00120101,

        // <summary>
        //     Optimum Tracking Distance Usage.
        // </summary>
        [Description("Optimum Tracking Distance")]
        OptimumTrackingDistance = 0x00120102,

        // <summary>
        //     Maximum Tracking Distance Usage.
        // </summary>
        [Description("Maximum Tracking Distance")]
        MaximumTrackingDistance = 0x00120103,

        // <summary>
        //     Maximum Screen Plane Width Usage.
        // </summary>
        [Description("Maximum Screen Plane Width")]
        MaximumScreenPlaneWidth = 0x00120104,

        // <summary>
        //     Maximum Screen Plane Height Usage.
        // </summary>
        [Description("Maximum Screen Plane Height")]
        MaximumScreenPlaneHeight = 0x00120105,

        // <summary>
        //     Display Manufacturer ID Usage.
        // </summary>
        [Description("Display Manufacturer ID")]
        DisplayManufacturerID = 0x00120200,

        // <summary>
        //     Display Product ID Usage.
        // </summary>
        [Description("Display Product ID")]
        DisplayProductID = 0x00120201,

        // <summary>
        //     Display Serial Number Usage.
        // </summary>
        [Description("Display Serial Number")]
        DisplaySerialNumber = 0x00120202,

        // <summary>
        //     Display Manufacturer Date Usage.
        // </summary>
        [Description("Display Manufacturer Date")]
        DisplayManufacturerDate = 0x00120203,

        // <summary>
        //     Calibrated Screen Width Usage.
        // </summary>
        [Description("Calibrated Screen Width")]
        CalibratedScreenWidth = 0x00120204,

        // <summary>
        //     Calibrated Screen Height Usage.
        // </summary>
        [Description("Calibrated Screen Height")]
        CalibratedScreenHeight = 0x00120205,

        // <summary>
        //     Sampling Frequency Usage.
        // </summary>
        [Description("Sampling Frequency")]
        SamplingFrequency = 0x00120300,

        // <summary>
        //     Configuration Status Usage.
        // </summary>
        [Description("Configuration Status")]
        ConfigurationStatus = 0x00120301,

        // <summary>
        //     Device Mode Request Usage.
        // </summary>
        [Description("Device Mode Request")]
        DeviceModeRequest = 0x00120400
    }
}
