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
    //     Medical Instrument Usage Page.
    // </summary>
    [Description("Medical Instrument Usage Page")]
    public enum MedicalInstrumentPage : uint
    {
        // <summary>
        //     Undefined Usage.
        // </summary>
        [Description("Undefined")]
        Undefined = 0x00400000,

        // <summary>
        //     Medical Ultrasound Usage.
        // </summary>
        [Description("Medical Ultrasound")]
        MedicalUltrasound = 0x00400001,

        // <summary>
        //     VCR/Acquisition Usage.
        // </summary>
        [Description("VCR/Acquisition")]
        VCRAcquisition = 0x00400020,

        // <summary>
        //     Freeze/Thaw Usage.
        // </summary>
        [Description("Freeze/Thaw")]
        FreezeThaw = 0x00400021,

        // <summary>
        //     Clip Store Usage.
        // </summary>
        [Description("Clip Store")]
        ClipStore = 0x00400022,

        // <summary>
        //     Update Usage.
        // </summary>
        [Description("Update")]
        Update = 0x00400023,

        // <summary>
        //     Next Usage.
        // </summary>
        [Description("Next")]
        Next = 0x00400024,

        // <summary>
        //     Save Usage.
        // </summary>
        [Description("Save")]
        Save = 0x00400025,

        // <summary>
        //     Print Usage.
        // </summary>
        [Description("Print")]
        Print = 0x00400026,

        // <summary>
        //     Microphone Enable Usage.
        // </summary>
        [Description("Microphone Enable")]
        MicrophoneEnable = 0x00400027,

        // <summary>
        //     Cine Usage.
        // </summary>
        [Description("Cine")]
        Cine = 0x00400040,

        // <summary>
        //     Transmit Power Usage.
        // </summary>
        [Description("Transmit Power")]
        TransmitPower = 0x00400041,

        // <summary>
        //     Volume Usage.
        // </summary>
        [Description("Volume")]
        Volume = 0x00400042,

        // <summary>
        //     Focus Usage.
        // </summary>
        [Description("Focus")]
        Focus = 0x00400043,

        // <summary>
        //     Depth Usage.
        // </summary>
        [Description("Depth")]
        Depth = 0x00400044,

        // <summary>
        //     Soft Step - Primary Usage.
        // </summary>
        [Description("Soft Step - Primary")]
        SoftStepPrimary = 0x00400060,

        // <summary>
        //     Soft Step - Secondary Usage.
        // </summary>
        [Description("Soft Step - Secondary")]
        SoftStepSecondary = 0x00400061,

        // <summary>
        //     Depth Gain Compensation Usage.
        // </summary>
        [Description("Depth Gain Compensation")]
        DepthGainCompensation = 0x00400070,

        // <summary>
        //     Zoom Select Usage.
        // </summary>
        [Description("Zoom Select")]
        ZoomSelect = 0x00400080,

        // <summary>
        //     Zoom Adjust Usage.
        // </summary>
        [Description("Zoom Adjust")]
        ZoomAdjust = 0x00400081,

        // <summary>
        //     Spectral Doppler Mode Select Usage.
        // </summary>
        [Description("Spectral Doppler Mode Select")]
        SpectralDopplerModeSelect = 0x00400082,

        // <summary>
        //     Spectral Doppler Adjust Usage.
        // </summary>
        [Description("Spectral Doppler Adjust")]
        SpectralDopplerAdjust = 0x00400083,

        // <summary>
        //     Color Doppler Mode Select Usage.
        // </summary>
        [Description("Color Doppler Mode Select")]
        ColorDopplerModeSelect = 0x00400084,

        // <summary>
        //     Color Doppler Adjust Usage.
        // </summary>
        [Description("Color Doppler Adjust")]
        ColorDopplerAdjust = 0x00400085,

        // <summary>
        //     Motion Mode Select Usage.
        // </summary>
        [Description("Motion Mode Select")]
        MotionModeSelect = 0x00400086,

        // <summary>
        //     Motion Mode Adjust Usage.
        // </summary>
        [Description("Motion Mode Adjust")]
        MotionModeAdjust = 0x00400087,

        // <summary>
        //     2-D Mode Select Usage.
        // </summary>
        [Description("2-D Mode Select")]
        _2DModeSelect = 0x00400088,

        // <summary>
        //     2-D Mode Adjust Usage.
        // </summary>
        [Description("2-D Mode Adjust")]
        _2DModeAdjust = 0x00400089,

        // <summary>
        //     Soft Control Select Usage.
        // </summary>
        [Description("Soft Control Select")]
        SoftControlSelect = 0x004000a0,

        // <summary>
        //     Soft Control Adjust Usage.
        // </summary>
        [Description("Soft Control Adjust")]
        SoftControlAdjust = 0x004000a1
    }
}
