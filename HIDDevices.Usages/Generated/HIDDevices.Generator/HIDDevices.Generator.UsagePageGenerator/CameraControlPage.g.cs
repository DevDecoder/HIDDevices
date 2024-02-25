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
    //     Camera Control Usage Page.
    // </summary>
    [Description("Camera Control Usage Page")]
    public enum CameraControlPage : uint
    {
        // <summary>
        //     Undefined Usage.
        // </summary>
        [Description("Undefined")]
        Undefined = 0x00900000,

        // <summary>
        //     Camera Auto-focus Usage.
        // </summary>
        [Description("Camera Auto-focus")]
        CameraAutofocus = 0x00900020,

        // <summary>
        //     Camera Shutter Usage.
        // </summary>
        [Description("Camera Shutter")]
        CameraShutter = 0x00900021
    }
}
