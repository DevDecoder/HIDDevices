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
    //     SoC Usage Page.
    // </summary>
    [Description("SoC Usage Page")]
    public enum SoCPage : uint
    {
        // <summary>
        //     Undefined Usage.
        // </summary>
        [Description("Undefined")]
        Undefined = 0x00110000,

        // <summary>
        //     SocControl Usage.
        // </summary>
        [Description("SocControl")]
        SocControl = 0x00110001,

        // <summary>
        //     FirmwareTransfer Usage.
        // </summary>
        [Description("FirmwareTransfer")]
        FirmwareTransfer = 0x00110002,

        // <summary>
        //     FirmwareFileId Usage.
        // </summary>
        [Description("FirmwareFileId")]
        FirmwareFileId = 0x00110003,

        // <summary>
        //     FileOffsetInBytes Usage.
        // </summary>
        [Description("FileOffsetInBytes")]
        FileOffsetInBytes = 0x00110004,

        // <summary>
        //     FileTransferSizeMaxInBytes Usage.
        // </summary>
        [Description("FileTransferSizeMaxInBytes")]
        FileTransferSizeMaxInBytes = 0x00110005,

        // <summary>
        //     FilePayload Usage.
        // </summary>
        [Description("FilePayload")]
        FilePayload = 0x00110006,

        // <summary>
        //     FilePayloadSizeInBytes Usage.
        // </summary>
        [Description("FilePayloadSizeInBytes")]
        FilePayloadSizeInBytes = 0x00110007,

        // <summary>
        //     FilePayloadContainsLastBytes Usage.
        // </summary>
        [Description("FilePayloadContainsLastBytes")]
        FilePayloadContainsLastBytes = 0x00110008,

        // <summary>
        //     FileTransferStop Usage.
        // </summary>
        [Description("FileTransferStop")]
        FileTransferStop = 0x00110009,

        // <summary>
        //     FileTransferTillEnd Usage.
        // </summary>
        [Description("FileTransferTillEnd")]
        FileTransferTillEnd = 0x0011000a
    }
}
