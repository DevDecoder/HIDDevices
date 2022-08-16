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
    //     FIDO Alliance Usage Page.
    // </summary>
    [Description("FIDO Alliance Usage Page")]
    public enum FIDOAlliancePage : uint
    {
        // <summary>
        //     Undefined Usage.
        // </summary>
        [Description("Undefined")]
        Undefined = 0xf1d00000,

        // <summary>
        //     U2F Authenticator Device Usage.
        // </summary>
        [Description("U2F Authenticator Device")]
        U2FAuthenticatorDevice = 0xf1d00001,

        // <summary>
        //     Input Report Data Usage.
        // </summary>
        [Description("Input Report Data")]
        InputReportData = 0xf1d00020,

        // <summary>
        //     Output Report Data Usage.
        // </summary>
        [Description("Output Report Data")]
        OutputReportData = 0xf1d00021
    }
}
