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
    //     VESA Virtual Controls Usage Page.
    // </summary>
    [Description("VESA Virtual Controls Usage Page")]
    public enum VESAVirtualControlsPage : uint
    {
        // <summary>
        //     Undefined Usage.
        // </summary>
        [Description("Undefined")]
        Undefined = 0x00820000,

        // <summary>
        //     Degauss Usage.
        // </summary>
        [Description("Degauss")]
        Degauss = 0x00820001,

        // <summary>
        //     Brightness Usage.
        // </summary>
        [Description("Brightness")]
        Brightness = 0x00820010,

        // <summary>
        //     Contrast Usage.
        // </summary>
        [Description("Contrast")]
        Contrast = 0x00820012,

        // <summary>
        //     Red Video Gain Usage.
        // </summary>
        [Description("Red Video Gain")]
        RedVideoGain = 0x00820016,

        // <summary>
        //     Green Video Gain Usage.
        // </summary>
        [Description("Green Video Gain")]
        GreenVideoGain = 0x00820018,

        // <summary>
        //     Blue Video Gain Usage.
        // </summary>
        [Description("Blue Video Gain")]
        BlueVideoGain = 0x0082001a,

        // <summary>
        //     Focus Usage.
        // </summary>
        [Description("Focus")]
        Focus = 0x0082001c,

        // <summary>
        //     Horizontal Position Usage.
        // </summary>
        [Description("Horizontal Position")]
        HorizontalPosition = 0x00820020,

        // <summary>
        //     Horizontal Size Usage.
        // </summary>
        [Description("Horizontal Size")]
        HorizontalSize = 0x00820022,

        // <summary>
        //     Horizontal Pincushion Usage.
        // </summary>
        [Description("Horizontal Pincushion")]
        HorizontalPincushion = 0x00820024,

        // <summary>
        //     Horizontal Pincushion Balance Usage.
        // </summary>
        [Description("Horizontal Pincushion Balance")]
        HorizontalPincushionBalance = 0x00820026,

        // <summary>
        //     Horizontal Misconvergence Usage.
        // </summary>
        [Description("Horizontal Misconvergence")]
        HorizontalMisconvergence = 0x00820028,

        // <summary>
        //     Horizontal Linearity Usage.
        // </summary>
        [Description("Horizontal Linearity")]
        HorizontalLinearity = 0x0082002a,

        // <summary>
        //     Horizontal Linearity Balance Usage.
        // </summary>
        [Description("Horizontal Linearity Balance")]
        HorizontalLinearityBalance = 0x0082002c,

        // <summary>
        //     Vertical Position Usage.
        // </summary>
        [Description("Vertical Position")]
        VerticalPosition = 0x00820030,

        // <summary>
        //     Vertical Size Usage.
        // </summary>
        [Description("Vertical Size")]
        VerticalSize = 0x00820032,

        // <summary>
        //     Vertical Pincushion Usage.
        // </summary>
        [Description("Vertical Pincushion")]
        VerticalPincushion = 0x00820034,

        // <summary>
        //     Vertical Pincushion Balance Usage.
        // </summary>
        [Description("Vertical Pincushion Balance")]
        VerticalPincushionBalance = 0x00820036,

        // <summary>
        //     Vertical Misconvergence Usage.
        // </summary>
        [Description("Vertical Misconvergence")]
        VerticalMisconvergence = 0x00820038,

        // <summary>
        //     Vertical Linearity Usage.
        // </summary>
        [Description("Vertical Linearity")]
        VerticalLinearity = 0x0082003a,

        // <summary>
        //     Vertical Linearity Balance Usage.
        // </summary>
        [Description("Vertical Linearity Balance")]
        VerticalLinearityBalance = 0x0082003c,

        // <summary>
        //     Parallelogram Distortion (Key Balance) Usage.
        // </summary>
        [Description("Parallelogram Distortion (Key Balance)")]
        ParallelogramDistortionKeyBalance = 0x00820040,

        // <summary>
        //     Trapezoidal Distortion (Key) Usage.
        // </summary>
        [Description("Trapezoidal Distortion (Key)")]
        TrapezoidalDistortionKey = 0x00820042,

        // <summary>
        //     Tilt (Rotation) Usage.
        // </summary>
        [Description("Tilt (Rotation)")]
        TiltRotation = 0x00820044,

        // <summary>
        //     Top Corner Distortion Control Usage.
        // </summary>
        [Description("Top Corner Distortion Control")]
        TopCornerDistortionControl = 0x00820046,

        // <summary>
        //     Top Corner Distortion Balance Usage.
        // </summary>
        [Description("Top Corner Distortion Balance")]
        TopCornerDistortionBalance = 0x00820048,

        // <summary>
        //     Bottom Corner Distortion Control Usage.
        // </summary>
        [Description("Bottom Corner Distortion Control")]
        BottomCornerDistortionControl = 0x0082004a,

        // <summary>
        //     Bottom Corner Distortion Balance Usage.
        // </summary>
        [Description("Bottom Corner Distortion Balance")]
        BottomCornerDistortionBalance = 0x0082004c,

        // <summary>
        //     Horizontal Moiré Usage.
        // </summary>
        [Description("Horizontal Moiré")]
        HorizontalMoiré = 0x00820056,

        // <summary>
        //     Vertical Moiré Usage.
        // </summary>
        [Description("Vertical Moiré")]
        VerticalMoiré = 0x00820058,

        // <summary>
        //     Input Level Select Usage.
        // </summary>
        [Description("Input Level Select")]
        InputLevelSelect = 0x0082005e,

        // <summary>
        //     Input Source Select Usage.
        // </summary>
        [Description("Input Source Select")]
        InputSourceSelect = 0x00820060,

        // <summary>
        //     Red Video Black Level Usage.
        // </summary>
        [Description("Red Video Black Level")]
        RedVideoBlackLevel = 0x0082006c,

        // <summary>
        //     Green Video Black Level Usage.
        // </summary>
        [Description("Green Video Black Level")]
        GreenVideoBlackLevel = 0x0082006e,

        // <summary>
        //     Blue Video Black Level Usage.
        // </summary>
        [Description("Blue Video Black Level")]
        BlueVideoBlackLevel = 0x00820070,

        // <summary>
        //     Auto Size Center Usage.
        // </summary>
        [Description("Auto Size Center")]
        AutoSizeCenter = 0x008200a2,

        // <summary>
        //     Polarity Horizontal Synchronization Usage.
        // </summary>
        [Description("Polarity Horizontal Synchronization")]
        PolarityHorizontalSynchronization = 0x008200a4,

        // <summary>
        //     Polarity Vertical Synchronization Usage.
        // </summary>
        [Description("Polarity Vertical Synchronization")]
        PolarityVerticalSynchronization = 0x008200a6,

        // <summary>
        //     Synchronization Type Usage.
        // </summary>
        [Description("Synchronization Type")]
        SynchronizationType = 0x008200a8,

        // <summary>
        //     Screen Orientation Usage.
        // </summary>
        [Description("Screen Orientation")]
        ScreenOrientation = 0x008200aa,

        // <summary>
        //     Horizontal Frequency Usage.
        // </summary>
        [Description("Horizontal Frequency")]
        HorizontalFrequency = 0x008200ac,

        // <summary>
        //     Vertical Frequency Usage.
        // </summary>
        [Description("Vertical Frequency")]
        VerticalFrequency = 0x008200ae,

        // <summary>
        //     Settings Usage.
        // </summary>
        [Description("Settings")]
        Settings = 0x008200b0,

        // <summary>
        //     On Screen Display Usage.
        // </summary>
        [Description("On Screen Display")]
        OnScreenDisplay = 0x008200ca,

        // <summary>
        //     Stereo Mode Usage.
        // </summary>
        [Description("Stereo Mode")]
        StereoMode = 0x008200d4
    }
}
