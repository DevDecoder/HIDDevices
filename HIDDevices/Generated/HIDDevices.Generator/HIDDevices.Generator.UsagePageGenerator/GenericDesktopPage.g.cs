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
    //     Generic Desktop Usage Page.
    // </summary>
    [Description("Generic Desktop Usage Page")]
    public enum GenericDesktopPage : uint
    {
        // <summary>
        //     Undefined Usage.
        // </summary>
        [Description("Undefined")]
        Undefined = 0x00010000,

        // <summary>
        //     Pointer Usage.
        // </summary>
        [Description("Pointer")]
        Pointer = 0x00010001,

        // <summary>
        //     Mouse Usage.
        // </summary>
        [Description("Mouse")]
        Mouse = 0x00010002,

        // <summary>
        //     Joystick Usage.
        // </summary>
        [Description("Joystick")]
        Joystick = 0x00010004,

        // <summary>
        //     Gamepad Usage.
        // </summary>
        [Description("Gamepad")]
        Gamepad = 0x00010005,

        // <summary>
        //     Keyboard Usage.
        // </summary>
        [Description("Keyboard")]
        Keyboard = 0x00010006,

        // <summary>
        //     Keypad Usage.
        // </summary>
        [Description("Keypad")]
        Keypad = 0x00010007,

        // <summary>
        //     Multi-axis Controller Usage.
        // </summary>
        [Description("Multi-axis Controller")]
        MultiaxisController = 0x00010008,

        // <summary>
        //     Tablet PC System Controls Usage.
        // </summary>
        [Description("Tablet PC System Controls")]
        TabletPCSystemControls = 0x00010009,

        // <summary>
        //     Water Cooling Device Usage.
        // </summary>
        [Description("Water Cooling Device")]
        WaterCoolingDevice = 0x0001000a,

        // <summary>
        //     Computer Chassis Device Usage.
        // </summary>
        [Description("Computer Chassis Device")]
        ComputerChassisDevice = 0x0001000b,

        // <summary>
        //     Wireless Radio Controls Usage.
        // </summary>
        [Description("Wireless Radio Controls")]
        WirelessRadioControls = 0x0001000c,

        // <summary>
        //     Portable Device Control Usage.
        // </summary>
        [Description("Portable Device Control")]
        PortableDeviceControl = 0x0001000d,

        // <summary>
        //     System Multi-Axis Controller Usage.
        // </summary>
        [Description("System Multi-Axis Controller")]
        SystemMultiAxisController = 0x0001000e,

        // <summary>
        //     Spatial Controller Usage.
        // </summary>
        [Description("Spatial Controller")]
        SpatialController = 0x0001000f,

        // <summary>
        //     Assistive Control Usage.
        // </summary>
        [Description("Assistive Control")]
        AssistiveControl = 0x00010010,

        // <summary>
        //     Device Dock Usage.
        // </summary>
        [Description("Device Dock")]
        DeviceDock = 0x00010011,

        // <summary>
        //     Dockable Device Usage.
        // </summary>
        [Description("Dockable Device")]
        DockableDevice = 0x00010012,

        // <summary>
        //     Call State Management Control Usage.
        // </summary>
        [Description("Call State Management Control")]
        CallStateManagementControl = 0x00010013,

        // <summary>
        //     X Usage.
        // </summary>
        [Description("X")]
        X = 0x00010030,

        // <summary>
        //     Y Usage.
        // </summary>
        [Description("Y")]
        Y = 0x00010031,

        // <summary>
        //     Z Usage.
        // </summary>
        [Description("Z")]
        Z = 0x00010032,

        // <summary>
        //     Rx Usage.
        // </summary>
        [Description("Rx")]
        Rx = 0x00010033,

        // <summary>
        //     Ry Usage.
        // </summary>
        [Description("Ry")]
        Ry = 0x00010034,

        // <summary>
        //     Rz Usage.
        // </summary>
        [Description("Rz")]
        Rz = 0x00010035,

        // <summary>
        //     Slider Usage.
        // </summary>
        [Description("Slider")]
        Slider = 0x00010036,

        // <summary>
        //     Dial Usage.
        // </summary>
        [Description("Dial")]
        Dial = 0x00010037,

        // <summary>
        //     Wheel Usage.
        // </summary>
        [Description("Wheel")]
        Wheel = 0x00010038,

        // <summary>
        //     Hat Switch Usage.
        // </summary>
        [Description("Hat Switch")]
        HatSwitch = 0x00010039,

        // <summary>
        //     Counted Buffer Usage.
        // </summary>
        [Description("Counted Buffer")]
        CountedBuffer = 0x0001003a,

        // <summary>
        //     Byte Count Usage.
        // </summary>
        [Description("Byte Count")]
        ByteCount = 0x0001003b,

        // <summary>
        //     Motion Wakeup Usage.
        // </summary>
        [Description("Motion Wakeup")]
        MotionWakeup = 0x0001003c,

        // <summary>
        //     Start Usage.
        // </summary>
        [Description("Start")]
        Start = 0x0001003d,

        // <summary>
        //     Select Usage.
        // </summary>
        [Description("Select")]
        Select = 0x0001003e,

        // <summary>
        //     Vx Usage.
        // </summary>
        [Description("Vx")]
        Vx = 0x00010040,

        // <summary>
        //     Vy Usage.
        // </summary>
        [Description("Vy")]
        Vy = 0x00010041,

        // <summary>
        //     Vz Usage.
        // </summary>
        [Description("Vz")]
        Vz = 0x00010042,

        // <summary>
        //     Vbrx Usage.
        // </summary>
        [Description("Vbrx")]
        Vbrx = 0x00010043,

        // <summary>
        //     Vbry Usage.
        // </summary>
        [Description("Vbry")]
        Vbry = 0x00010044,

        // <summary>
        //     Vbrz Usage.
        // </summary>
        [Description("Vbrz")]
        Vbrz = 0x00010045,

        // <summary>
        //     Vno Usage.
        // </summary>
        [Description("Vno")]
        Vno = 0x00010046,

        // <summary>
        //     Feature Notification Usage.
        // </summary>
        [Description("Feature Notification")]
        FeatureNotification = 0x00010047,

        // <summary>
        //     Resolution Multiplier Usage.
        // </summary>
        [Description("Resolution Multiplier")]
        ResolutionMultiplier = 0x00010048,

        // <summary>
        //     Qx Usage.
        // </summary>
        [Description("Qx")]
        Qx = 0x00010049,

        // <summary>
        //     Qy Usage.
        // </summary>
        [Description("Qy")]
        Qy = 0x0001004a,

        // <summary>
        //     Qz Usage.
        // </summary>
        [Description("Qz")]
        Qz = 0x0001004b,

        // <summary>
        //     Qw Usage.
        // </summary>
        [Description("Qw")]
        Qw = 0x0001004c,

        // <summary>
        //     System Control Usage.
        // </summary>
        [Description("System Control")]
        SystemControl = 0x00010080,

        // <summary>
        //     System Power Down Usage.
        // </summary>
        [Description("System Power Down")]
        SystemPowerDown = 0x00010081,

        // <summary>
        //     System Sleep Usage.
        // </summary>
        [Description("System Sleep")]
        SystemSleep = 0x00010082,

        // <summary>
        //     System Wake Up Usage.
        // </summary>
        [Description("System Wake Up")]
        SystemWakeUp = 0x00010083,

        // <summary>
        //     System Context Menu Usage.
        // </summary>
        [Description("System Context Menu")]
        SystemContextMenu = 0x00010084,

        // <summary>
        //     System Main Menu Usage.
        // </summary>
        [Description("System Main Menu")]
        SystemMainMenu = 0x00010085,

        // <summary>
        //     System App Menu Usage.
        // </summary>
        [Description("System App Menu")]
        SystemAppMenu = 0x00010086,

        // <summary>
        //     System Menu Help Usage.
        // </summary>
        [Description("System Menu Help")]
        SystemMenuHelp = 0x00010087,

        // <summary>
        //     System Menu Exit Usage.
        // </summary>
        [Description("System Menu Exit")]
        SystemMenuExit = 0x00010088,

        // <summary>
        //     System Menu Select Usage.
        // </summary>
        [Description("System Menu Select")]
        SystemMenuSelect = 0x00010089,

        // <summary>
        //     System Menu Right Usage.
        // </summary>
        [Description("System Menu Right")]
        SystemMenuRight = 0x0001008a,

        // <summary>
        //     System Menu Left Usage.
        // </summary>
        [Description("System Menu Left")]
        SystemMenuLeft = 0x0001008b,

        // <summary>
        //     System Menu Up Usage.
        // </summary>
        [Description("System Menu Up")]
        SystemMenuUp = 0x0001008c,

        // <summary>
        //     System Menu Down Usage.
        // </summary>
        [Description("System Menu Down")]
        SystemMenuDown = 0x0001008d,

        // <summary>
        //     System Cold Restart Usage.
        // </summary>
        [Description("System Cold Restart")]
        SystemColdRestart = 0x0001008e,

        // <summary>
        //     System Warm Restart Usage.
        // </summary>
        [Description("System Warm Restart")]
        SystemWarmRestart = 0x0001008f,

        // <summary>
        //     D-pad Up Usage.
        // </summary>
        [Description("D-pad Up")]
        DpadUp = 0x00010090,

        // <summary>
        //     D-pad Down Usage.
        // </summary>
        [Description("D-pad Down")]
        DpadDown = 0x00010091,

        // <summary>
        //     D-pad Right Usage.
        // </summary>
        [Description("D-pad Right")]
        DpadRight = 0x00010092,

        // <summary>
        //     D-pad Left Usage.
        // </summary>
        [Description("D-pad Left")]
        DpadLeft = 0x00010093,

        // <summary>
        //     Index Trigger Usage.
        // </summary>
        [Description("Index Trigger")]
        IndexTrigger = 0x00010094,

        // <summary>
        //     Palm Trigger Usage.
        // </summary>
        [Description("Palm Trigger")]
        PalmTrigger = 0x00010095,

        // <summary>
        //     Thumbstick Usage.
        // </summary>
        [Description("Thumbstick")]
        Thumbstick = 0x00010096,

        // <summary>
        //     System Function Shift Usage.
        // </summary>
        [Description("System Function Shift")]
        SystemFunctionShift = 0x00010097,

        // <summary>
        //     System Function Shift Lock Usage.
        // </summary>
        [Description("System Function Shift Lock")]
        SystemFunctionShiftLock = 0x00010098,

        // <summary>
        //     System Function Shift Lock Indicator Usage.
        // </summary>
        [Description("System Function Shift Lock Indicator")]
        SystemFunctionShiftLockIndicator = 0x00010099,

        // <summary>
        //     System Dismiss Notification Usage.
        // </summary>
        [Description("System Dismiss Notification")]
        SystemDismissNotification = 0x0001009a,

        // <summary>
        //     System Do Not Disturb Usage.
        // </summary>
        [Description("System Do Not Disturb")]
        SystemDoNotDisturb = 0x0001009b,

        // <summary>
        //     System Dock Usage.
        // </summary>
        [Description("System Dock")]
        SystemDock = 0x000100a0,

        // <summary>
        //     System Undock Usage.
        // </summary>
        [Description("System Undock")]
        SystemUndock = 0x000100a1,

        // <summary>
        //     System Setup Usage.
        // </summary>
        [Description("System Setup")]
        SystemSetup = 0x000100a2,

        // <summary>
        //     System Break Usage.
        // </summary>
        [Description("System Break")]
        SystemBreak = 0x000100a3,

        // <summary>
        //     System Debugger Break Usage.
        // </summary>
        [Description("System Debugger Break")]
        SystemDebuggerBreak = 0x000100a4,

        // <summary>
        //     Application Break Usage.
        // </summary>
        [Description("Application Break")]
        ApplicationBreak = 0x000100a5,

        // <summary>
        //     Application Debugger Break Usage.
        // </summary>
        [Description("Application Debugger Break")]
        ApplicationDebuggerBreak = 0x000100a6,

        // <summary>
        //     System Speaker Mute Usage.
        // </summary>
        [Description("System Speaker Mute")]
        SystemSpeakerMute = 0x000100a7,

        // <summary>
        //     System Hibernate Usage.
        // </summary>
        [Description("System Hibernate")]
        SystemHibernate = 0x000100a8,

        // <summary>
        //     System Microphone Mute Usage.
        // </summary>
        [Description("System Microphone Mute")]
        SystemMicrophoneMute = 0x000100a9,

        // <summary>
        //     System Display Invert Usage.
        // </summary>
        [Description("System Display Invert")]
        SystemDisplayInvert = 0x000100b0,

        // <summary>
        //     System Display Internal Usage.
        // </summary>
        [Description("System Display Internal")]
        SystemDisplayInternal = 0x000100b1,

        // <summary>
        //     System Display External Usage.
        // </summary>
        [Description("System Display External")]
        SystemDisplayExternal = 0x000100b2,

        // <summary>
        //     System Display Both Usage.
        // </summary>
        [Description("System Display Both")]
        SystemDisplayBoth = 0x000100b3,

        // <summary>
        //     System Display Dual Usage.
        // </summary>
        [Description("System Display Dual")]
        SystemDisplayDual = 0x000100b4,

        // <summary>
        //     System Display Toggle Int/Ext Mode Usage.
        // </summary>
        [Description("System Display Toggle Int/Ext Mode")]
        SystemDisplayToggleIntExtMode = 0x000100b5,

        // <summary>
        //     System Display Swap Primary/Secondary Usage.
        // </summary>
        [Description("System Display Swap Primary/Secondary")]
        SystemDisplaySwapPrimarySecondary = 0x000100b6,

        // <summary>
        //     System Display Toggle LCD Autoscale Usage.
        // </summary>
        [Description("System Display Toggle LCD Autoscale")]
        SystemDisplayToggleLCDAutoscale = 0x000100b7,

        // <summary>
        //     Sensor Zone Usage.
        // </summary>
        [Description("Sensor Zone")]
        SensorZone = 0x000100c0,

        // <summary>
        //     RPM Usage.
        // </summary>
        [Description("RPM")]
        RPM = 0x000100c1,

        // <summary>
        //     Coolant Level Usage.
        // </summary>
        [Description("Coolant Level")]
        CoolantLevel = 0x000100c2,

        // <summary>
        //     Coolant Critical Level Usage.
        // </summary>
        [Description("Coolant Critical Level")]
        CoolantCriticalLevel = 0x000100c3,

        // <summary>
        //     Coolant Pump Usage.
        // </summary>
        [Description("Coolant Pump")]
        CoolantPump = 0x000100c4,

        // <summary>
        //     Chassis Enclosure Usage.
        // </summary>
        [Description("Chassis Enclosure")]
        ChassisEnclosure = 0x000100c5,

        // <summary>
        //     Wireless Radio Button Usage.
        // </summary>
        [Description("Wireless Radio Button")]
        WirelessRadioButton = 0x000100c6,

        // <summary>
        //     Wireless Radio LED Usage.
        // </summary>
        [Description("Wireless Radio LED")]
        WirelessRadioLED = 0x000100c7,

        // <summary>
        //     Wireless Radio Slider Switch Usage.
        // </summary>
        [Description("Wireless Radio Slider Switch")]
        WirelessRadioSliderSwitch = 0x000100c8,

        // <summary>
        //     System Display Rotation Lock Button Usage.
        // </summary>
        [Description("System Display Rotation Lock Button")]
        SystemDisplayRotationLockButton = 0x000100c9,

        // <summary>
        //     System Display Rotation Lock Slider Switch Usage.
        // </summary>
        [Description("System Display Rotation Lock Slider Switch")]
        SystemDisplayRotationLockSliderSwitch = 0x000100ca,

        // <summary>
        //     Control Enable Usage.
        // </summary>
        [Description("Control Enable")]
        ControlEnable = 0x000100cb,

        // <summary>
        //     Dockable Device Unique ID Usage.
        // </summary>
        [Description("Dockable Device Unique ID")]
        DockableDeviceUniqueID = 0x000100d0,

        // <summary>
        //     Dockable Device Vendor ID Usage.
        // </summary>
        [Description("Dockable Device Vendor ID")]
        DockableDeviceVendorID = 0x000100d1,

        // <summary>
        //     Dockable Device Primary Usage Page Usage.
        // </summary>
        [Description("Dockable Device Primary Usage Page")]
        DockableDevicePrimaryUsagePage = 0x000100d2,

        // <summary>
        //     Dockable Device Primary Usage ID Usage.
        // </summary>
        [Description("Dockable Device Primary Usage ID")]
        DockableDevicePrimaryUsageID = 0x000100d3,

        // <summary>
        //     Dockable Device Docking State Usage.
        // </summary>
        [Description("Dockable Device Docking State")]
        DockableDeviceDockingState = 0x000100d4,

        // <summary>
        //     Dockable Device Display Occlusion Usage.
        // </summary>
        [Description("Dockable Device Display Occlusion")]
        DockableDeviceDisplayOcclusion = 0x000100d5,

        // <summary>
        //     Dockable Device Object Type Usage.
        // </summary>
        [Description("Dockable Device Object Type")]
        DockableDeviceObjectType = 0x000100d6,

        // <summary>
        //     Call Active LED Usage.
        // </summary>
        [Description("Call Active LED")]
        CallActiveLED = 0x000100e0,

        // <summary>
        //     Call Mute Toggle Usage.
        // </summary>
        [Description("Call Mute Toggle")]
        CallMuteToggle = 0x000100e1,

        // <summary>
        //     Call Mute LED Usage.
        // </summary>
        [Description("Call Mute LED")]
        CallMuteLED = 0x000100e2
    }
}
