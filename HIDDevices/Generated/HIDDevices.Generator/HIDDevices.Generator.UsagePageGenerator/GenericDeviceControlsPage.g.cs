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
    //     Generic Device Controls Usage Page.
    // </summary>
    [Description("Generic Device Controls Usage Page")]
    public enum GenericDeviceControlsPage : uint
    {
        // <summary>
        //     Undefined Usage.
        // </summary>
        [Description("Undefined")]
        Undefined = 0x00060000,

        // <summary>
        //     Background/Nonuser Controls Usage.
        // </summary>
        [Description("Background/Nonuser Controls")]
        BackgroundNonuserControls = 0x00060001,

        // <summary>
        //     Battery Strength Usage.
        // </summary>
        [Description("Battery Strength")]
        BatteryStrength = 0x00060020,

        // <summary>
        //     Wireless Channel Usage.
        // </summary>
        [Description("Wireless Channel")]
        WirelessChannel = 0x00060021,

        // <summary>
        //     Wireless ID Usage.
        // </summary>
        [Description("Wireless ID")]
        WirelessID = 0x00060022,

        // <summary>
        //     Discover Wireless Control Usage.
        // </summary>
        [Description("Discover Wireless Control")]
        DiscoverWirelessControl = 0x00060023,

        // <summary>
        //     Security Code Character Entered Usage.
        // </summary>
        [Description("Security Code Character Entered")]
        SecurityCodeCharacterEntered = 0x00060024,

        // <summary>
        //     Security Code Character Erased Usage.
        // </summary>
        [Description("Security Code Character Erased")]
        SecurityCodeCharacterErased = 0x00060025,

        // <summary>
        //     Security Code Cleared Usage.
        // </summary>
        [Description("Security Code Cleared")]
        SecurityCodeCleared = 0x00060026,

        // <summary>
        //     Sequence ID Usage.
        // </summary>
        [Description("Sequence ID")]
        SequenceID = 0x00060027,

        // <summary>
        //     Sequence ID Reset Usage.
        // </summary>
        [Description("Sequence ID Reset")]
        SequenceIDReset = 0x00060028,

        // <summary>
        //     RF Signal Strength Usage.
        // </summary>
        [Description("RF Signal Strength")]
        RFSignalStrength = 0x00060029,

        // <summary>
        //     Software Version Usage.
        // </summary>
        [Description("Software Version")]
        SoftwareVersion = 0x0006002a,

        // <summary>
        //     Protocol Version Usage.
        // </summary>
        [Description("Protocol Version")]
        ProtocolVersion = 0x0006002b,

        // <summary>
        //     Hardware Version Usage.
        // </summary>
        [Description("Hardware Version")]
        HardwareVersion = 0x0006002c,

        // <summary>
        //     Major Usage.
        // </summary>
        [Description("Major")]
        Major = 0x0006002d,

        // <summary>
        //     Minor Usage.
        // </summary>
        [Description("Minor")]
        Minor = 0x0006002e,

        // <summary>
        //     Revision Usage.
        // </summary>
        [Description("Revision")]
        Revision = 0x0006002f,

        // <summary>
        //     Handedness Usage.
        // </summary>
        [Description("Handedness")]
        Handedness = 0x00060030,

        // <summary>
        //     Either Hand Usage.
        // </summary>
        [Description("Either Hand")]
        EitherHand = 0x00060031,

        // <summary>
        //     Left Hand Usage.
        // </summary>
        [Description("Left Hand")]
        LeftHand = 0x00060032,

        // <summary>
        //     Right Hand Usage.
        // </summary>
        [Description("Right Hand")]
        RightHand = 0x00060033,

        // <summary>
        //     Both Hands Usage.
        // </summary>
        [Description("Both Hands")]
        BothHands = 0x00060034,

        // <summary>
        //     Grip Pose Offset Usage.
        // </summary>
        [Description("Grip Pose Offset")]
        GripPoseOffset = 0x00060040,

        // <summary>
        //     Pointer Pose Offset Usage.
        // </summary>
        [Description("Pointer Pose Offset")]
        PointerPoseOffset = 0x00060041
    }
}
