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
    //     Haptics Usage Page.
    // </summary>
    [Description("Haptics Usage Page")]
    public enum HapticsPage : uint
    {
        // <summary>
        //     Undefined Usage.
        // </summary>
        [Description("Undefined")]
        Undefined = 0x000e0000,

        // <summary>
        //     Simple Haptic Controller Usage.
        // </summary>
        [Description("Simple Haptic Controller")]
        SimpleHapticController = 0x000e0001,

        // <summary>
        //     Waveform List Usage.
        // </summary>
        [Description("Waveform List")]
        WaveformList = 0x000e0010,

        // <summary>
        //     Duration List Usage.
        // </summary>
        [Description("Duration List")]
        DurationList = 0x000e0011,

        // <summary>
        //     Auto Trigger Usage.
        // </summary>
        [Description("Auto Trigger")]
        AutoTrigger = 0x000e0020,

        // <summary>
        //     Manual Trigger Usage.
        // </summary>
        [Description("Manual Trigger")]
        ManualTrigger = 0x000e0021,

        // <summary>
        //     Auto Trigger Associated Control Usage.
        // </summary>
        [Description("Auto Trigger Associated Control")]
        AutoTriggerAssociatedControl = 0x000e0022,

        // <summary>
        //     Intensity Usage.
        // </summary>
        [Description("Intensity")]
        Intensity = 0x000e0023,

        // <summary>
        //     Repeat Count Usage.
        // </summary>
        [Description("Repeat Count")]
        RepeatCount = 0x000e0024,

        // <summary>
        //     Retrigger Period Usage.
        // </summary>
        [Description("Retrigger Period")]
        RetriggerPeriod = 0x000e0025,

        // <summary>
        //     Waveform Vendor Page Usage.
        // </summary>
        [Description("Waveform Vendor Page")]
        WaveformVendorPage = 0x000e0026,

        // <summary>
        //     Waveform Vendor ID Usage.
        // </summary>
        [Description("Waveform Vendor ID")]
        WaveformVendorID = 0x000e0027,

        // <summary>
        //     Waveform Cutoff Time Usage.
        // </summary>
        [Description("Waveform Cutoff Time")]
        WaveformCutoffTime = 0x000e0028,

        // <summary>
        //     Waveform None Usage.
        // </summary>
        [Description("Waveform None")]
        WaveformNone = 0x000e1001,

        // <summary>
        //     Waveform Stop Usage.
        // </summary>
        [Description("Waveform Stop")]
        WaveformStop = 0x000e1002,

        // <summary>
        //     Waveform Click Usage.
        // </summary>
        [Description("Waveform Click")]
        WaveformClick = 0x000e1003,

        // <summary>
        //     Waveform Buzz Continuous Usage.
        // </summary>
        [Description("Waveform Buzz Continuous")]
        WaveformBuzzContinuous = 0x000e1004,

        // <summary>
        //     Waveform Rumble Continuous Usage.
        // </summary>
        [Description("Waveform Rumble Continuous")]
        WaveformRumbleContinuous = 0x000e1005,

        // <summary>
        //     Waveform Press Usage.
        // </summary>
        [Description("Waveform Press")]
        WaveformPress = 0x000e1006,

        // <summary>
        //     Waveform Release Usage.
        // </summary>
        [Description("Waveform Release")]
        WaveformRelease = 0x000e1007,

        // <summary>
        //     Waveform Hover Usage.
        // </summary>
        [Description("Waveform Hover")]
        WaveformHover = 0x000e1008,

        // <summary>
        //     Waveform Success Usage.
        // </summary>
        [Description("Waveform Success")]
        WaveformSuccess = 0x000e1009,

        // <summary>
        //     Waveform Error Usage.
        // </summary>
        [Description("Waveform Error")]
        WaveformError = 0x000e100a,

        // <summary>
        //     Waveform Ink Continuous Usage.
        // </summary>
        [Description("Waveform Ink Continuous")]
        WaveformInkContinuous = 0x000e100b,

        // <summary>
        //     Waveform Pencil Continuous Usage.
        // </summary>
        [Description("Waveform Pencil Continuous")]
        WaveformPencilContinuous = 0x000e100c,

        // <summary>
        //     Waveform Marker Continuous Usage.
        // </summary>
        [Description("Waveform Marker Continuous")]
        WaveformMarkerContinuous = 0x000e100d,

        // <summary>
        //     Waveform Chisel Marker Continuous Usage.
        // </summary>
        [Description("Waveform Chisel Marker Continuous")]
        WaveformChiselMarkerContinuous = 0x000e100e,

        // <summary>
        //     Waveform Brush Continuous Usage.
        // </summary>
        [Description("Waveform Brush Continuous")]
        WaveformBrushContinuous = 0x000e100f,

        // <summary>
        //     Waveform Eraser Continuous Usage.
        // </summary>
        [Description("Waveform Eraser Continuous")]
        WaveformEraserContinuous = 0x000e1010,

        // <summary>
        //     Waveform Sparkle Continuous Usage.
        // </summary>
        [Description("Waveform Sparkle Continuous")]
        WaveformSparkleContinuous = 0x000e1011
    }
}
