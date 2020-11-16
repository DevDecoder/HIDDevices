// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.
//
// Auto Generated 2581 usages in 36 pages on 16/11/2020 17:41:36.

#pragma warning disable CS0108 // Member hides inherited member; missing new keyword

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;

namespace DevDecoder.HIDDevices.Usages
{
    using DevDecoder.HIDDevices.Pages;

    /// <summary>
    ///     Undefined Usage Page.
    /// </summary>
    [Description("Undefined Usage Page")]
    public enum UndefinedPage : uint
    {
        /// <summary>
        ///     Undefined Usage.
        /// </summary>
        [Description("Undefined")]
        Undefined = 0x00000000
    }

    /// <summary>
    ///     Generic Desktop Controls Usage Page.
    /// </summary>
    [Description("Generic Desktop Controls Usage Page")]
    public enum GenericDesktopPage : uint
    {
        /// <summary>
        ///     Undefined Usage.
        /// </summary>
        [Description("Undefined")]
        Undefined = 0x00010000,

        /// <summary>
        ///     Pointer Usage.
        /// </summary>
        [Description("Pointer")]
        Pointer = 0x00010001,

        /// <summary>
        ///     Mouse Usage.
        /// </summary>
        [Description("Mouse")]
        Mouse = 0x00010002,

        /// <summary>
        ///     Joystick Usage.
        /// </summary>
        [Description("Joystick")]
        Joystick = 0x00010004,

        /// <summary>
        ///     Game Pad Usage.
        /// </summary>
        [Description("Game Pad")]
        GamePad = 0x00010005,

        /// <summary>
        ///     Keyboard Usage.
        /// </summary>
        [Description("Keyboard")]
        Keyboard = 0x00010006,

        /// <summary>
        ///     Keypad Usage.
        /// </summary>
        [Description("Keypad")]
        Keypad = 0x00010007,

        /// <summary>
        ///     Multi-axis Controller Usage.
        /// </summary>
        [Description("Multi-axis Controller")]
        MultiaxisController = 0x00010008,

        /// <summary>
        ///     Tablet PC System Controls Usage.
        /// </summary>
        [Description("Tablet PC System Controls")]
        TabletPCSystemControls = 0x00010009,

        /// <summary>
        ///     Water Cooling Device Usage.
        /// </summary>
        [Description("Water Cooling Device")]
        WaterCoolingDevice = 0x0001000a,

        /// <summary>
        ///     Computer Chassis Device Usage.
        /// </summary>
        [Description("Computer Chassis Device")]
        ComputerChassisDevice = 0x0001000b,

        /// <summary>
        ///     Wireless Radio Controls Usage.
        /// </summary>
        [Description("Wireless Radio Controls")]
        WirelessRadioControls = 0x0001000c,

        /// <summary>
        ///     Portable Device Control Usage.
        /// </summary>
        [Description("Portable Device Control")]
        PortableDeviceControl = 0x0001000d,

        /// <summary>
        ///     System Multi-axis Controller Usage.
        /// </summary>
        [Description("System Multi-axis Controller")]
        SystemMultiaxisController = 0x0001000e,

        /// <summary>
        ///     Spatial Controller Usage.
        /// </summary>
        [Description("Spatial Controller")]
        SpatialController = 0x0001000f,

        /// <summary>
        ///     Assistive Control Usage.
        /// </summary>
        [Description("Assistive Control")]
        AssistiveControl = 0x00010010,

        /// <summary>
        ///     Device Dock Usage.
        /// </summary>
        [Description("Device Dock")]
        DeviceDock = 0x00010011,

        /// <summary>
        ///     Dockable Device Usage.
        /// </summary>
        [Description("Dockable Device")]
        DockableDevice = 0x00010012,

        /// <summary>
        ///     X Usage.
        /// </summary>
        [Description("X")]
        X = 0x00010030,

        /// <summary>
        ///     Y Usage.
        /// </summary>
        [Description("Y")]
        Y = 0x00010031,

        /// <summary>
        ///     Z Usage.
        /// </summary>
        [Description("Z")]
        Z = 0x00010032,

        /// <summary>
        ///     Rx Usage.
        /// </summary>
        [Description("Rx")]
        Rx = 0x00010033,

        /// <summary>
        ///     Ry Usage.
        /// </summary>
        [Description("Ry")]
        Ry = 0x00010034,

        /// <summary>
        ///     Rz Usage.
        /// </summary>
        [Description("Rz")]
        Rz = 0x00010035,

        /// <summary>
        ///     Slider Usage.
        /// </summary>
        [Description("Slider")]
        Slider = 0x00010036,

        /// <summary>
        ///     Dial Usage.
        /// </summary>
        [Description("Dial")]
        Dial = 0x00010037,

        /// <summary>
        ///     Wheel Usage.
        /// </summary>
        [Description("Wheel")]
        Wheel = 0x00010038,

        /// <summary>
        ///     Hat switch Usage.
        /// </summary>
        [Description("Hat switch")]
        HatSwitch = 0x00010039,

        /// <summary>
        ///     Counter Buffer Usage.
        /// </summary>
        [Description("Counter Buffer")]
        CounterBuffer = 0x0001003a,

        /// <summary>
        ///     Byte Count Usage.
        /// </summary>
        [Description("Byte Count")]
        ByteCount = 0x0001003b,

        /// <summary>
        ///     Motion Wakeup Usage.
        /// </summary>
        [Description("Motion Wakeup")]
        MotionWakeup = 0x0001003c,

        /// <summary>
        ///     Start Usage.
        /// </summary>
        [Description("Start")]
        Start = 0x0001003d,

        /// <summary>
        ///     Select Usage.
        /// </summary>
        [Description("Select")]
        Select = 0x0001003e,

        /// <summary>
        ///     Vx Usage.
        /// </summary>
        [Description("Vx")]
        Vx = 0x00010040,

        /// <summary>
        ///     Vy Usage.
        /// </summary>
        [Description("Vy")]
        Vy = 0x00010041,

        /// <summary>
        ///     Vz Usage.
        /// </summary>
        [Description("Vz")]
        Vz = 0x00010042,

        /// <summary>
        ///     Vbrx Usage.
        /// </summary>
        [Description("Vbrx")]
        Vbrx = 0x00010043,

        /// <summary>
        ///     Vbry Usage.
        /// </summary>
        [Description("Vbry")]
        Vbry = 0x00010044,

        /// <summary>
        ///     Vbrz Usage.
        /// </summary>
        [Description("Vbrz")]
        Vbrz = 0x00010045,

        /// <summary>
        ///     Vno Usage.
        /// </summary>
        [Description("Vno")]
        Vno = 0x00010046,

        /// <summary>
        ///     Feature Notification Usage.
        /// </summary>
        [Description("Feature Notification")]
        FeatureNotification = 0x00010047,

        /// <summary>
        ///     Resolution Multiplier Usage.
        /// </summary>
        [Description("Resolution Multiplier")]
        ResolutionMultiplier = 0x00010048,

        /// <summary>
        ///     Qx Usage.
        /// </summary>
        [Description("Qx")]
        Qx = 0x00010049,

        /// <summary>
        ///     Qy Usage.
        /// </summary>
        [Description("Qy")]
        Qy = 0x0001004a,

        /// <summary>
        ///     Qz Usage.
        /// </summary>
        [Description("Qz")]
        Qz = 0x0001004b,

        /// <summary>
        ///     Qw Usage.
        /// </summary>
        [Description("Qw")]
        Qw = 0x0001004c,

        /// <summary>
        ///     System Control Usage.
        /// </summary>
        [Description("System Control")]
        SystemControl = 0x00010080,

        /// <summary>
        ///     System Power Down Usage.
        /// </summary>
        [Description("System Power Down")]
        SystemPowerDown = 0x00010081,

        /// <summary>
        ///     System Sleep Usage.
        /// </summary>
        [Description("System Sleep")]
        SystemSleep = 0x00010082,

        /// <summary>
        ///     System Wake up Usage.
        /// </summary>
        [Description("System Wake up")]
        SystemWakeUp = 0x00010083,

        /// <summary>
        ///     System Context Menu Usage.
        /// </summary>
        [Description("System Context Menu")]
        SystemContextMenu = 0x00010084,

        /// <summary>
        ///     System Main Menu Usage.
        /// </summary>
        [Description("System Main Menu")]
        SystemMainMenu = 0x00010085,

        /// <summary>
        ///     System App Menu Usage.
        /// </summary>
        [Description("System App Menu")]
        SystemAppMenu = 0x00010086,

        /// <summary>
        ///     System Menu Help Usage.
        /// </summary>
        [Description("System Menu Help")]
        SystemMenuHelp = 0x00010087,

        /// <summary>
        ///     System Menu Exit Usage.
        /// </summary>
        [Description("System Menu Exit")]
        SystemMenuExit = 0x00010088,

        /// <summary>
        ///     System Menu Select Usage.
        /// </summary>
        [Description("System Menu Select")]
        SystemMenuSelect = 0x00010089,

        /// <summary>
        ///     System Menu Right Usage.
        /// </summary>
        [Description("System Menu Right")]
        SystemMenuRight = 0x0001008a,

        /// <summary>
        ///     System Menu Left Usage.
        /// </summary>
        [Description("System Menu Left")]
        SystemMenuLeft = 0x0001008b,

        /// <summary>
        ///     System Menu Up Usage.
        /// </summary>
        [Description("System Menu Up")]
        SystemMenuUp = 0x0001008c,

        /// <summary>
        ///     System Menu Down Usage.
        /// </summary>
        [Description("System Menu Down")]
        SystemMenuDown = 0x0001008d,

        /// <summary>
        ///     System Cold Restart Usage.
        /// </summary>
        [Description("System Cold Restart")]
        SystemColdRestart = 0x0001008e,

        /// <summary>
        ///     System Warm Restart Usage.
        /// </summary>
        [Description("System Warm Restart")]
        SystemWarmRestart = 0x0001008f,

        /// <summary>
        ///     D-pad Up Usage.
        /// </summary>
        [Description("D-pad Up")]
        DpadUp = 0x00010090,

        /// <summary>
        ///     D-pad Down Usage.
        /// </summary>
        [Description("D-pad Down")]
        DpadDown = 0x00010091,

        /// <summary>
        ///     D-pad Right Usage.
        /// </summary>
        [Description("D-pad Right")]
        DpadRight = 0x00010092,

        /// <summary>
        ///     D-pad Left Usage.
        /// </summary>
        [Description("D-pad Left")]
        DpadLeft = 0x00010093,

        /// <summary>
        ///     Index Trigger Usage.
        /// </summary>
        [Description("Index Trigger")]
        IndexTrigger = 0x00010094,

        /// <summary>
        ///     Palm Trigger Usage.
        /// </summary>
        [Description("Palm Trigger")]
        PalmTrigger = 0x00010095,

        /// <summary>
        ///     Thumbstick Usage.
        /// </summary>
        [Description("Thumbstick")]
        Thumbstick = 0x00010096,

        /// <summary>
        ///     System Function Shift Usage.
        /// </summary>
        [Description("System Function Shift")]
        SystemFunctionShift = 0x00010097,

        /// <summary>
        ///     System Function Shift Lock Usage.
        /// </summary>
        [Description("System Function Shift Lock")]
        SystemFunctionShiftLock = 0x00010098,

        /// <summary>
        ///     System Function Shift Lock Indicator Usage.
        /// </summary>
        [Description("System Function Shift Lock Indicator")]
        SystemFunctionShiftLockIndicator = 0x00010099,

        /// <summary>
        ///     System Dismiss Notification Usage.
        /// </summary>
        [Description("System Dismiss Notification")]
        SystemDismissNotification = 0x0001009a,

        /// <summary>
        ///     System Do Not Disturb Usage.
        /// </summary>
        [Description("System Do Not Disturb")]
        SystemDoNotDisturb = 0x0001009b,

        /// <summary>
        ///     System Dock Usage.
        /// </summary>
        [Description("System Dock")]
        SystemDock = 0x000100a0,

        /// <summary>
        ///     System Undock Usage.
        /// </summary>
        [Description("System Undock")]
        SystemUndock = 0x000100a1,

        /// <summary>
        ///     System Setup Usage.
        /// </summary>
        [Description("System Setup")]
        SystemSetup = 0x000100a2,

        /// <summary>
        ///     System Break Usage.
        /// </summary>
        [Description("System Break")]
        SystemBreak = 0x000100a3,

        /// <summary>
        ///     System Debugger Break Usage.
        /// </summary>
        [Description("System Debugger Break")]
        SystemDebuggerBreak = 0x000100a4,

        /// <summary>
        ///     Application Break Usage.
        /// </summary>
        [Description("Application Break")]
        ApplicationBreak = 0x000100a5,

        /// <summary>
        ///     Application Debugger Break Usage.
        /// </summary>
        [Description("Application Debugger Break")]
        ApplicationDebuggerBreak = 0x000100a6,

        /// <summary>
        ///     System Speaker Mute Usage.
        /// </summary>
        [Description("System Speaker Mute")]
        SystemSpeakerMute = 0x000100a7,

        /// <summary>
        ///     System Hibernate Usage.
        /// </summary>
        [Description("System Hibernate")]
        SystemHibernate = 0x000100a8,

        /// <summary>
        ///     System Display Invert Usage.
        /// </summary>
        [Description("System Display Invert")]
        SystemDisplayInvert = 0x000100b0,

        /// <summary>
        ///     System Display Internal Usage.
        /// </summary>
        [Description("System Display Internal")]
        SystemDisplayInternal = 0x000100b1,

        /// <summary>
        ///     System Display External Usage.
        /// </summary>
        [Description("System Display External")]
        SystemDisplayExternal = 0x000100b2,

        /// <summary>
        ///     System Display Both Usage.
        /// </summary>
        [Description("System Display Both")]
        SystemDisplayBoth = 0x000100b3,

        /// <summary>
        ///     System Display Dual Usage.
        /// </summary>
        [Description("System Display Dual")]
        SystemDisplayDual = 0x000100b4,

        /// <summary>
        ///     System Display Toggle Int/Ext Usage.
        /// </summary>
        [Description("System Display Toggle Int/Ext")]
        SystemDisplayToggleIntExt = 0x000100b5,

        /// <summary>
        ///     System Display Swap Primary/Secondary Usage.
        /// </summary>
        [Description("System Display Swap Primary/Secondary")]
        SystemDisplaySwapPrimarySecondary = 0x000100b6,

        /// <summary>
        ///     System Display LCD Autoscale Usage.
        /// </summary>
        [Description("System Display LCD Autoscale")]
        SystemDisplayLCDAutoscale = 0x000100b7,

        /// <summary>
        ///     Sensor Zone Usage.
        /// </summary>
        [Description("Sensor Zone")]
        SensorZone = 0x000100c0,

        /// <summary>
        ///     RPM Usage.
        /// </summary>
        [Description("RPM")]
        RPM = 0x000100c1,

        /// <summary>
        ///     Coolant Level Usage.
        /// </summary>
        [Description("Coolant Level")]
        CoolantLevel = 0x000100c2,

        /// <summary>
        ///     Coolant Critical Level Usage.
        /// </summary>
        [Description("Coolant Critical Level")]
        CoolantCriticalLevel = 0x000100c3,

        /// <summary>
        ///     Coolant Pump Usage.
        /// </summary>
        [Description("Coolant Pump")]
        CoolantPump = 0x000100c4,

        /// <summary>
        ///     Chassis Enclosure Usage.
        /// </summary>
        [Description("Chassis Enclosure")]
        ChassisEnclosure = 0x000100c5,

        /// <summary>
        ///     Wireless Radio Button Usage.
        /// </summary>
        [Description("Wireless Radio Button")]
        WirelessRadioButton = 0x000100c6,

        /// <summary>
        ///     Wireless Radio LED Usage.
        /// </summary>
        [Description("Wireless Radio LED")]
        WirelessRadioLED = 0x000100c7,

        /// <summary>
        ///     Wireless Radio Slider Switch Usage.
        /// </summary>
        [Description("Wireless Radio Slider Switch")]
        WirelessRadioSliderSwitch = 0x000100c8,

        /// <summary>
        ///     System Display Rotation Lock Button Usage.
        /// </summary>
        [Description("System Display Rotation Lock Button")]
        SystemDisplayRotationLockButton = 0x000100c9,

        /// <summary>
        ///     System Display Rotation Lock Slider Switch Usage.
        /// </summary>
        [Description("System Display Rotation Lock Slider Switch")]
        SystemDisplayRotationLockSliderSwitch = 0x000100ca,

        /// <summary>
        ///     Control Enable Usage.
        /// </summary>
        [Description("Control Enable")]
        ControlEnable = 0x000100cb,

        /// <summary>
        ///     Dockable Device Unique ID Usage.
        /// </summary>
        [Description("Dockable Device Unique ID")]
        DockableDeviceUniqueID = 0x000100d0,

        /// <summary>
        ///     Dockable Device Vendor ID Usage.
        /// </summary>
        [Description("Dockable Device Vendor ID")]
        DockableDeviceVendorID = 0x000100d1,

        /// <summary>
        ///     Dockable Device Primary Usage Page Usage.
        /// </summary>
        [Description("Dockable Device Primary Usage Page")]
        DockableDevicePrimaryUsagePage = 0x000100d2,

        /// <summary>
        ///     Dockable Device Primary Usage ID Usage.
        /// </summary>
        [Description("Dockable Device Primary Usage ID")]
        DockableDevicePrimaryUsageID = 0x000100d3,

        /// <summary>
        ///     Dockable Device Docking State Usage.
        /// </summary>
        [Description("Dockable Device Docking State")]
        DockableDeviceDockingState = 0x000100d4,

        /// <summary>
        ///     Dockable Device Display Occlusion Usage.
        /// </summary>
        [Description("Dockable Device Display Occlusion")]
        DockableDeviceDisplayOcclusion = 0x000100d5,

        /// <summary>
        ///     Dockable Device Object Type Usage.
        /// </summary>
        [Description("Dockable Device Object Type")]
        DockableDeviceObjectType = 0x000100d6
    }

    /// <summary>
    ///     Simulation Controls Usage Page.
    /// </summary>
    [Description("Simulation Controls Usage Page")]
    public enum SimulationPage : uint
    {
        /// <summary>
        ///     Undefined Usage.
        /// </summary>
        [Description("Undefined")]
        Undefined = 0x00020000,

        /// <summary>
        ///     Flight Simulation Device Usage.
        /// </summary>
        [Description("Flight Simulation Device")]
        FlightSimulationDevice = 0x00020001,

        /// <summary>
        ///     Automobile Simulation Device Usage.
        /// </summary>
        [Description("Automobile Simulation Device")]
        AutomobileSimulationDevice = 0x00020002,

        /// <summary>
        ///     Tank Simulation Device Usage.
        /// </summary>
        [Description("Tank Simulation Device")]
        TankSimulationDevice = 0x00020003,

        /// <summary>
        ///     Spaceship Simulation Device Usage.
        /// </summary>
        [Description("Spaceship Simulation Device")]
        SpaceshipSimulationDevice = 0x00020004,

        /// <summary>
        ///     Submarine Simulation Device Usage.
        /// </summary>
        [Description("Submarine Simulation Device")]
        SubmarineSimulationDevice = 0x00020005,

        /// <summary>
        ///     Sailing Simulation Device Usage.
        /// </summary>
        [Description("Sailing Simulation Device")]
        SailingSimulationDevice = 0x00020006,

        /// <summary>
        ///     Motorcycle Simulation Device Usage.
        /// </summary>
        [Description("Motorcycle Simulation Device")]
        MotorcycleSimulationDevice = 0x00020007,

        /// <summary>
        ///     Sports Simulation Device Usage.
        /// </summary>
        [Description("Sports Simulation Device")]
        SportsSimulationDevice = 0x00020008,

        /// <summary>
        ///     Airplane Simulation Device Usage.
        /// </summary>
        [Description("Airplane Simulation Device")]
        AirplaneSimulationDevice = 0x00020009,

        /// <summary>
        ///     Helicopter Simulation Device Usage.
        /// </summary>
        [Description("Helicopter Simulation Device")]
        HelicopterSimulationDevice = 0x0002000a,

        /// <summary>
        ///     Magic Carpet Simulation Device Usage.
        /// </summary>
        [Description("Magic Carpet Simulation Device")]
        MagicCarpetSimulationDevice = 0x0002000b,

        /// <summary>
        ///     Bicycle Simulation Device Usage.
        /// </summary>
        [Description("Bicycle Simulation Device")]
        BicycleSimulationDevice = 0x0002000c,

        /// <summary>
        ///     Flight Control Stick Usage.
        /// </summary>
        [Description("Flight Control Stick")]
        FlightControlStick = 0x00020020,

        /// <summary>
        ///     Flight Stick Usage.
        /// </summary>
        [Description("Flight Stick")]
        FlightStick = 0x00020021,

        /// <summary>
        ///     Cyclic Control Usage.
        /// </summary>
        [Description("Cyclic Control")]
        CyclicControl = 0x00020022,

        /// <summary>
        ///     Cyclic Trim Usage.
        /// </summary>
        [Description("Cyclic Trim")]
        CyclicTrim = 0x00020023,

        /// <summary>
        ///     Flight Yoke Usage.
        /// </summary>
        [Description("Flight Yoke")]
        FlightYoke = 0x00020024,

        /// <summary>
        ///     Track Control Usage.
        /// </summary>
        [Description("Track Control")]
        TrackControl = 0x00020025,

        /// <summary>
        ///     Aileron Usage.
        /// </summary>
        [Description("Aileron")]
        Aileron = 0x000200b0,

        /// <summary>
        ///     Aileron Trim Usage.
        /// </summary>
        [Description("Aileron Trim")]
        AileronTrim = 0x000200b1,

        /// <summary>
        ///     Anti-Torque Control Usage.
        /// </summary>
        [Description("Anti-Torque Control")]
        AntiTorqueControl = 0x000200b2,

        /// <summary>
        ///     Autopilot Enable Usage.
        /// </summary>
        [Description("Autopilot Enable")]
        AutopilotEnable = 0x000200b3,

        /// <summary>
        ///     Chaff Release Usage.
        /// </summary>
        [Description("Chaff Release")]
        ChaffRelease = 0x000200b4,

        /// <summary>
        ///     Collective Control Usage.
        /// </summary>
        [Description("Collective Control")]
        CollectiveControl = 0x000200b5,

        /// <summary>
        ///     Dive Brake Usage.
        /// </summary>
        [Description("Dive Brake")]
        DiveBrake = 0x000200b6,

        /// <summary>
        ///     Electronic Countermeasures Usage.
        /// </summary>
        [Description("Electronic Countermeasures")]
        ElectronicCountermeasures = 0x000200b7,

        /// <summary>
        ///     Elevator Usage.
        /// </summary>
        [Description("Elevator")]
        Elevator = 0x000200b8,

        /// <summary>
        ///     Elevator Trim Usage.
        /// </summary>
        [Description("Elevator Trim")]
        ElevatorTrim = 0x000200b9,

        /// <summary>
        ///     Rudder Usage.
        /// </summary>
        [Description("Rudder")]
        Rudder = 0x000200ba,

        /// <summary>
        ///     Throttle Usage.
        /// </summary>
        [Description("Throttle")]
        Throttle = 0x000200bb,

        /// <summary>
        ///     Flight Communications Usage.
        /// </summary>
        [Description("Flight Communications")]
        FlightCommunications = 0x000200bc,

        /// <summary>
        ///     Flare Release Usage.
        /// </summary>
        [Description("Flare Release")]
        FlareRelease = 0x000200bd,

        /// <summary>
        ///     Landing Gear Usage.
        /// </summary>
        [Description("Landing Gear")]
        LandingGear = 0x000200be,

        /// <summary>
        ///     Toe Brake Usage.
        /// </summary>
        [Description("Toe Brake")]
        ToeBrake = 0x000200bf,

        /// <summary>
        ///     Trigger Usage.
        /// </summary>
        [Description("Trigger")]
        Trigger = 0x000200c0,

        /// <summary>
        ///     Weapons Arm Usage.
        /// </summary>
        [Description("Weapons Arm")]
        WeaponsArm = 0x000200c1,

        /// <summary>
        ///     Weapons Select Usage.
        /// </summary>
        [Description("Weapons Select")]
        WeaponsSelect = 0x000200c2,

        /// <summary>
        ///     Wing Flaps Usage.
        /// </summary>
        [Description("Wing Flaps")]
        WingFlaps = 0x000200c3,

        /// <summary>
        ///     Accelerator Usage.
        /// </summary>
        [Description("Accelerator")]
        Accelerator = 0x000200c4,

        /// <summary>
        ///     Brake Usage.
        /// </summary>
        [Description("Brake")]
        Brake = 0x000200c5,

        /// <summary>
        ///     Clutch Usage.
        /// </summary>
        [Description("Clutch")]
        Clutch = 0x000200c6,

        /// <summary>
        ///     Shifter Usage.
        /// </summary>
        [Description("Shifter")]
        Shifter = 0x000200c7,

        /// <summary>
        ///     Steering Usage.
        /// </summary>
        [Description("Steering")]
        Steering = 0x000200c8,

        /// <summary>
        ///     Turret Direction Usage.
        /// </summary>
        [Description("Turret Direction")]
        TurretDirection = 0x000200c9,

        /// <summary>
        ///     Barrel Elevation Usage.
        /// </summary>
        [Description("Barrel Elevation")]
        BarrelElevation = 0x000200ca,

        /// <summary>
        ///     Dive Plane Usage.
        /// </summary>
        [Description("Dive Plane")]
        DivePlane = 0x000200cb,

        /// <summary>
        ///     Ballast Usage.
        /// </summary>
        [Description("Ballast")]
        Ballast = 0x000200cc,

        /// <summary>
        ///     Bicycle Crank Usage.
        /// </summary>
        [Description("Bicycle Crank")]
        BicycleCrank = 0x000200cd,

        /// <summary>
        ///     Handle Bars Usage.
        /// </summary>
        [Description("Handle Bars")]
        HandleBars = 0x000200ce,

        /// <summary>
        ///     Front Brake Usage.
        /// </summary>
        [Description("Front Brake")]
        FrontBrake = 0x000200cf,

        /// <summary>
        ///     Rear Brake Usage.
        /// </summary>
        [Description("Rear Brake")]
        RearBrake = 0x000200d0
    }

    /// <summary>
    ///     VR Controls Usage Page.
    /// </summary>
    [Description("VR Controls Usage Page")]
    public enum VRPage : uint
    {
        /// <summary>
        ///     Undefined Usage.
        /// </summary>
        [Description("Undefined")]
        Undefined = 0x00030000,

        /// <summary>
        ///     Belt Usage.
        /// </summary>
        [Description("Belt")]
        Belt = 0x00030001,

        /// <summary>
        ///     Body Suit Usage.
        /// </summary>
        [Description("Body Suit")]
        BodySuit = 0x00030002,

        /// <summary>
        ///     Flexor Usage.
        /// </summary>
        [Description("Flexor")]
        Flexor = 0x00030003,

        /// <summary>
        ///     Glove Usage.
        /// </summary>
        [Description("Glove")]
        Glove = 0x00030004,

        /// <summary>
        ///     Head Tracker Usage.
        /// </summary>
        [Description("Head Tracker")]
        HeadTracker = 0x00030005,

        /// <summary>
        ///     Head Mounted Display Usage.
        /// </summary>
        [Description("Head Mounted Display")]
        HeadMountedDisplay = 0x00030006,

        /// <summary>
        ///     Hand Tracker Usage.
        /// </summary>
        [Description("Hand Tracker")]
        HandTracker = 0x00030007,

        /// <summary>
        ///     Oculometer Usage.
        /// </summary>
        [Description("Oculometer")]
        Oculometer = 0x00030008,

        /// <summary>
        ///     Vest Usage.
        /// </summary>
        [Description("Vest")]
        Vest = 0x00030009,

        /// <summary>
        ///     Animatronic Device Usage.
        /// </summary>
        [Description("Animatronic Device")]
        AnimatronicDevice = 0x0003000a,

        /// <summary>
        ///     Stereo Enable Usage.
        /// </summary>
        [Description("Stereo Enable")]
        StereoEnable = 0x00030020,

        /// <summary>
        ///     Display Enable Usage.
        /// </summary>
        [Description("Display Enable")]
        DisplayEnable = 0x00030021
    }

    /// <summary>
    ///     Sport Controls Usage Page.
    /// </summary>
    [Description("Sport Controls Usage Page")]
    public enum SportPage : uint
    {
        /// <summary>
        ///     Undefined Usage.
        /// </summary>
        [Description("Undefined")]
        Undefined = 0x00040000,

        /// <summary>
        ///     Baseball Bat Usage.
        /// </summary>
        [Description("Baseball Bat")]
        BaseballBat = 0x00040001,

        /// <summary>
        ///     Golf Club Usage.
        /// </summary>
        [Description("Golf Club")]
        GolfClub = 0x00040002,

        /// <summary>
        ///     Rowing Machine Usage.
        /// </summary>
        [Description("Rowing Machine")]
        RowingMachine = 0x00040003,

        /// <summary>
        ///     Treadmill Usage.
        /// </summary>
        [Description("Treadmill")]
        Treadmill = 0x00040004,

        /// <summary>
        ///     Oar Usage.
        /// </summary>
        [Description("Oar")]
        Oar = 0x00040030,

        /// <summary>
        ///     Slope Usage.
        /// </summary>
        [Description("Slope")]
        Slope = 0x00040031,

        /// <summary>
        ///     Rate Usage.
        /// </summary>
        [Description("Rate")]
        Rate = 0x00040032,

        /// <summary>
        ///     Stick Speed Usage.
        /// </summary>
        [Description("Stick Speed")]
        StickSpeed = 0x00040033,

        /// <summary>
        ///     Stick Face Angle Usage.
        /// </summary>
        [Description("Stick Face Angle")]
        StickFaceAngle = 0x00040034,

        /// <summary>
        ///     Stick Heel/Toe Usage.
        /// </summary>
        [Description("Stick Heel/Toe")]
        StickHeelToe = 0x00040035,

        /// <summary>
        ///     Stick Follow Through Usage.
        /// </summary>
        [Description("Stick Follow Through")]
        StickFollowThrough = 0x00040036,

        /// <summary>
        ///     Stick Tempo Usage.
        /// </summary>
        [Description("Stick Tempo")]
        StickTempo = 0x00040037,

        /// <summary>
        ///     Stick Type Usage.
        /// </summary>
        [Description("Stick Type")]
        StickType = 0x00040038,

        /// <summary>
        ///     Stick Height Usage.
        /// </summary>
        [Description("Stick Height")]
        StickHeight = 0x00040039,

        /// <summary>
        ///     Putter Usage.
        /// </summary>
        [Description("Putter")]
        Putter = 0x00040050,

        /*
         * Range: 0x0051 -> 0x005b
         * {n+1} Iron
         */

        /// <summary>
        ///     1 Iron Usage.
        /// </summary>
        [Description("1 Iron")]
        Iron = 0x00040051,

        /// <summary>
        ///     2 Iron Usage.
        /// </summary>
        [Description("2 Iron")]
        Iron2 = 0x00040052,

        /// <summary>
        ///     3 Iron Usage.
        /// </summary>
        [Description("3 Iron")]
        Iron3 = 0x00040053,

        /// <summary>
        ///     4 Iron Usage.
        /// </summary>
        [Description("4 Iron")]
        Iron4 = 0x00040054,

        /// <summary>
        ///     5 Iron Usage.
        /// </summary>
        [Description("5 Iron")]
        Iron5 = 0x00040055,

        /// <summary>
        ///     6 Iron Usage.
        /// </summary>
        [Description("6 Iron")]
        Iron6 = 0x00040056,

        /// <summary>
        ///     7 Iron Usage.
        /// </summary>
        [Description("7 Iron")]
        Iron7 = 0x00040057,

        /// <summary>
        ///     8 Iron Usage.
        /// </summary>
        [Description("8 Iron")]
        Iron8 = 0x00040058,

        /// <summary>
        ///     9 Iron Usage.
        /// </summary>
        [Description("9 Iron")]
        Iron9 = 0x00040059,

        /// <summary>
        ///     10 Iron Usage.
        /// </summary>
        [Description("10 Iron")]
        Iron10 = 0x0004005a,

        /// <summary>
        ///     11 Iron Usage.
        /// </summary>
        [Description("11 Iron")]
        Iron11 = 0x0004005b,

        /// <summary>
        ///     Sand Wedge Usage.
        /// </summary>
        [Description("Sand Wedge")]
        SandWedge = 0x0004005c,

        /// <summary>
        ///     Loft Wedge Usage.
        /// </summary>
        [Description("Loft Wedge")]
        LoftWedge = 0x0004005d,

        /// <summary>
        ///     Power Wedge Usage.
        /// </summary>
        [Description("Power Wedge")]
        PowerWedge = 0x0004005e,

        /*
         * Range: 0x005f -> 0x0063
         * {2*n+1} Wood
         */

        /// <summary>
        ///     1 Wood Usage.
        /// </summary>
        [Description("1 Wood")]
        Wood = 0x0004005f,

        /// <summary>
        ///     3 Wood Usage.
        /// </summary>
        [Description("3 Wood")]
        Wood2 = 0x00040060,

        /// <summary>
        ///     5 Wood Usage.
        /// </summary>
        [Description("5 Wood")]
        Wood3 = 0x00040061,

        /// <summary>
        ///     7 Wood Usage.
        /// </summary>
        [Description("7 Wood")]
        Wood4 = 0x00040062,

        /// <summary>
        ///     9 Wood Usage.
        /// </summary>
        [Description("9 Wood")]
        Wood5 = 0x00040063
    }

    /// <summary>
    ///     Game Controls Usage Page.
    /// </summary>
    [Description("Game Controls Usage Page")]
    public enum GamePage : uint
    {
        /// <summary>
        ///     Undefined Usage.
        /// </summary>
        [Description("Undefined")]
        Undefined = 0x00050000,

        /// <summary>
        ///     3D Game Controller Usage.
        /// </summary>
        [Description("3D Game Controller")]
        DGameController = 0x00050001,

        /// <summary>
        ///     Pinball Device Usage.
        /// </summary>
        [Description("Pinball Device")]
        PinballDevice = 0x00050002,

        /// <summary>
        ///     Gun Device Usage.
        /// </summary>
        [Description("Gun Device")]
        GunDevice = 0x00050003,

        /// <summary>
        ///     Point of View Usage.
        /// </summary>
        [Description("Point of View")]
        PointOfView = 0x00050020,

        /// <summary>
        ///     Turn Right/Left Usage.
        /// </summary>
        [Description("Turn Right/Left")]
        TurnRightLeft = 0x00050021,

        /// <summary>
        ///     Pitch Right/Left Usage.
        /// </summary>
        [Description("Pitch Right/Left")]
        PitchRightLeft = 0x00050022,

        /// <summary>
        ///     Roll Right/Left Usage.
        /// </summary>
        [Description("Roll Right/Left")]
        RollRightLeft = 0x00050023,

        /// <summary>
        ///     Move Right/Left Usage.
        /// </summary>
        [Description("Move Right/Left")]
        MoveRightLeft = 0x00050024,

        /// <summary>
        ///     Move Forward/Backward Usage.
        /// </summary>
        [Description("Move Forward/Backward")]
        MoveForwardBackward = 0x00050025,

        /// <summary>
        ///     Move Up/Down Usage.
        /// </summary>
        [Description("Move Up/Down")]
        MoveUpDown = 0x00050026,

        /// <summary>
        ///     Lean Right/Left Usage.
        /// </summary>
        [Description("Lean Right/Left")]
        LeanRightLeft = 0x00050027,

        /// <summary>
        ///     Lean Forward/Backward Usage.
        /// </summary>
        [Description("Lean Forward/Backward")]
        LeanForwardBackward = 0x00050028,

        /// <summary>
        ///     Height of POV Usage.
        /// </summary>
        [Description("Height of POV")]
        HeightOfPOV = 0x00050029,

        /// <summary>
        ///     Flipper Usage.
        /// </summary>
        [Description("Flipper")]
        Flipper = 0x0005002a,

        /// <summary>
        ///     Secondary Flipper Usage.
        /// </summary>
        [Description("Secondary Flipper")]
        SecondaryFlipper = 0x0005002b,

        /// <summary>
        ///     Bump Usage.
        /// </summary>
        [Description("Bump")]
        Bump = 0x0005002c,

        /// <summary>
        ///     New Game Usage.
        /// </summary>
        [Description("New Game")]
        NewGame = 0x0005002d,

        /// <summary>
        ///     Shoot Ball Usage.
        /// </summary>
        [Description("Shoot Ball")]
        ShootBall = 0x0005002e,

        /// <summary>
        ///     Player Usage.
        /// </summary>
        [Description("Player")]
        Player = 0x0005002f,

        /// <summary>
        ///     Gun Bolt Usage.
        /// </summary>
        [Description("Gun Bolt")]
        GunBolt = 0x00050030,

        /// <summary>
        ///     Gun Clip Usage.
        /// </summary>
        [Description("Gun Clip")]
        GunClip = 0x00050031,

        /// <summary>
        ///     Gun Selector Usage.
        /// </summary>
        [Description("Gun Selector")]
        GunSelector = 0x00050032,

        /// <summary>
        ///     Gun Single Shot Usage.
        /// </summary>
        [Description("Gun Single Shot")]
        GunSingleShot = 0x00050033,

        /// <summary>
        ///     Gun Burst Usage.
        /// </summary>
        [Description("Gun Burst")]
        GunBurst = 0x00050034,

        /// <summary>
        ///     Gun Automatic Usage.
        /// </summary>
        [Description("Gun Automatic")]
        GunAutomatic = 0x00050035,

        /// <summary>
        ///     Gun Safety Usage.
        /// </summary>
        [Description("Gun Safety")]
        GunSafety = 0x00050036,

        /// <summary>
        ///     Gamepad Fire/Jump Usage.
        /// </summary>
        [Description("Gamepad Fire/Jump")]
        GamepadFireJump = 0x00050037,

        /// <summary>
        ///     Gamepad Trigger Usage.
        /// </summary>
        [Description("Gamepad Trigger")]
        GamepadTrigger = 0x00050039,

        /// <summary>
        ///     Form-fitting Gamepad Usage.
        /// </summary>
        [Description("Form-fitting Gamepad")]
        FormfittingGamepad = 0x0005003a
    }

    /// <summary>
    ///     Generic Device Controls Usage Page.
    /// </summary>
    [Description("Generic Device Controls Usage Page")]
    public enum GenericDevicePage : uint
    {
        /// <summary>
        ///     Undefined Usage.
        /// </summary>
        [Description("Undefined")]
        Undefined = 0x00060000,

        /// <summary>
        ///     Background Controls Usage.
        /// </summary>
        [Description("Background Controls")]
        BackgroundControls = 0x00060001,

        /// <summary>
        ///     Battery Strength Usage.
        /// </summary>
        [Description("Battery Strength")]
        BatteryStrength = 0x00060020,

        /// <summary>
        ///     Wireless Channel Usage.
        /// </summary>
        [Description("Wireless Channel")]
        WirelessChannel = 0x00060021,

        /// <summary>
        ///     Wireless ID Usage.
        /// </summary>
        [Description("Wireless ID")]
        WirelessID = 0x00060022,

        /// <summary>
        ///     Discover Wireless Control Usage.
        /// </summary>
        [Description("Discover Wireless Control")]
        DiscoverWirelessControl = 0x00060023,

        /// <summary>
        ///     Security Code Character Entered Usage.
        /// </summary>
        [Description("Security Code Character Entered")]
        SecurityCodeCharacterEntered = 0x00060024,

        /// <summary>
        ///     Security Code Character Erased Usage.
        /// </summary>
        [Description("Security Code Character Erased")]
        SecurityCodeCharacterErased = 0x00060025,

        /// <summary>
        ///     Security Code Cleared Usage.
        /// </summary>
        [Description("Security Code Cleared")]
        SecurityCodeCleared = 0x00060026,

        /// <summary>
        ///     Sequence ID Usage.
        /// </summary>
        [Description("Sequence ID")]
        SequenceID = 0x00060027,

        /// <summary>
        ///     Sequence ID Reset Usage.
        /// </summary>
        [Description("Sequence ID Reset")]
        SequenceIDReset = 0x00060028,

        /// <summary>
        ///     RF Signal Strength Usage.
        /// </summary>
        [Description("RF Signal Strength")]
        RFSignalStrength = 0x00060029,

        /// <summary>
        ///     Software Version Usage.
        /// </summary>
        [Description("Software Version")]
        SoftwareVersion = 0x0006002a,

        /// <summary>
        ///     Protocol Version Usage.
        /// </summary>
        [Description("Protocol Version")]
        ProtocolVersion = 0x0006002b,

        /// <summary>
        ///     Hardware Version Usage.
        /// </summary>
        [Description("Hardware Version")]
        HardwareVersion = 0x0006002c,

        /// <summary>
        ///     Major Usage.
        /// </summary>
        [Description("Major")]
        Major = 0x0006002d,

        /// <summary>
        ///     Minor Usage.
        /// </summary>
        [Description("Minor")]
        Minor = 0x0006002e,

        /// <summary>
        ///     Revision Usage.
        /// </summary>
        [Description("Revision")]
        Revision = 0x0006002f,

        /// <summary>
        ///     Handedness Usage.
        /// </summary>
        [Description("Handedness")]
        Handedness = 0x00060030,

        /// <summary>
        ///     Either Hand Usage.
        /// </summary>
        [Description("Either Hand")]
        EitherHand = 0x00060031,

        /// <summary>
        ///     Left Hand Usage.
        /// </summary>
        [Description("Left Hand")]
        LeftHand = 0x00060032,

        /// <summary>
        ///     Right Hand Usage.
        /// </summary>
        [Description("Right Hand")]
        RightHand = 0x00060033,

        /// <summary>
        ///     Both Hands Usage.
        /// </summary>
        [Description("Both Hands")]
        BothHands = 0x00060034,

        /// <summary>
        ///     Grip Pose Offset Usage.
        /// </summary>
        [Description("Grip Pose Offset")]
        GripPoseOffset = 0x00060040,

        /// <summary>
        ///     Pointer Pose Offset Usage.
        /// </summary>
        [Description("Pointer Pose Offset")]
        PointerPoseOffset = 0x00060041
    }

    /// <summary>
    ///     Keyboard/Keypad Usage Page.
    /// </summary>
    [Description("Keyboard/Keypad Usage Page")]
    public enum KeyboardKeypadPage : uint
    {
        /// <summary>
        ///     None Usage.
        /// </summary>
        [Description("None")]
        None = 0x00070000,

        /// <summary>
        ///     ErrorRollOver Usage.
        /// </summary>
        [Description("ErrorRollOver")]
        ErrorRollOver = 0x00070001,

        /// <summary>
        ///     POSTFail Usage.
        /// </summary>
        [Description("POSTFail")]
        POSTFail = 0x00070002,

        /// <summary>
        ///     ErrorUndefined Usage.
        /// </summary>
        [Description("ErrorUndefined")]
        ErrorUndefined = 0x00070003,

        /// <summary>
        ///     a A Usage.
        /// </summary>
        [Description("a A")]
        AA = 0x00070004,

        /// <summary>
        ///     b B Usage.
        /// </summary>
        [Description("b B")]
        BB = 0x00070005,

        /// <summary>
        ///     c C Usage.
        /// </summary>
        [Description("c C")]
        CC = 0x00070006,

        /// <summary>
        ///     d D Usage.
        /// </summary>
        [Description("d D")]
        DD = 0x00070007,

        /// <summary>
        ///     e E Usage.
        /// </summary>
        [Description("e E")]
        EE = 0x00070008,

        /// <summary>
        ///     f F Usage.
        /// </summary>
        [Description("f F")]
        FF = 0x00070009,

        /// <summary>
        ///     g G Usage.
        /// </summary>
        [Description("g G")]
        GG = 0x0007000a,

        /// <summary>
        ///     h H Usage.
        /// </summary>
        [Description("h H")]
        HH = 0x0007000b,

        /// <summary>
        ///     i I Usage.
        /// </summary>
        [Description("i I")]
        II = 0x0007000c,

        /// <summary>
        ///     j J Usage.
        /// </summary>
        [Description("j J")]
        JJ = 0x0007000d,

        /// <summary>
        ///     k K Usage.
        /// </summary>
        [Description("k K")]
        KK = 0x0007000e,

        /// <summary>
        ///     l L Usage.
        /// </summary>
        [Description("l L")]
        LL = 0x0007000f,

        /// <summary>
        ///     m M Usage.
        /// </summary>
        [Description("m M")]
        MM = 0x00070010,

        /// <summary>
        ///     n N Usage.
        /// </summary>
        [Description("n N")]
        NN = 0x00070011,

        /// <summary>
        ///     o O Usage.
        /// </summary>
        [Description("o O")]
        OO = 0x00070012,

        /// <summary>
        ///     p P Usage.
        /// </summary>
        [Description("p P")]
        PP = 0x00070013,

        /// <summary>
        ///     q Q Usage.
        /// </summary>
        [Description("q Q")]
        QQ = 0x00070014,

        /// <summary>
        ///     r R Usage.
        /// </summary>
        [Description("r R")]
        RR = 0x00070015,

        /// <summary>
        ///     s S Usage.
        /// </summary>
        [Description("s S")]
        SS = 0x00070016,

        /// <summary>
        ///     t T Usage.
        /// </summary>
        [Description("t T")]
        TT = 0x00070017,

        /// <summary>
        ///     u U Usage.
        /// </summary>
        [Description("u U")]
        UU = 0x00070018,

        /// <summary>
        ///     v V Usage.
        /// </summary>
        [Description("v V")]
        VV = 0x00070019,

        /// <summary>
        ///     w W Usage.
        /// </summary>
        [Description("w W")]
        WW = 0x0007001a,

        /// <summary>
        ///     x X Usage.
        /// </summary>
        [Description("x X")]
        XX = 0x0007001b,

        /// <summary>
        ///     y Y Usage.
        /// </summary>
        [Description("y Y")]
        YY = 0x0007001c,

        /// <summary>
        ///     z Z Usage.
        /// </summary>
        [Description("z Z")]
        ZZ = 0x0007001d,

        /// <summary>
        ///     1 ! Usage.
        /// </summary>
        [Description("1 !")]
        KeyboardKeypad_1 = 0x0007001e,

        /// <summary>
        ///     2 @ Usage.
        /// </summary>
        [Description("2 @")]
        KeyboardKeypad_2 = 0x0007001f,

        /// <summary>
        ///     3 # Usage.
        /// </summary>
        [Description("3 #")]
        KeyboardKeypad_3 = 0x00070020,

        /// <summary>
        ///     4 $ Usage.
        /// </summary>
        [Description("4 $")]
        KeyboardKeypad_4 = 0x00070021,

        /// <summary>
        ///     5 % Usage.
        /// </summary>
        [Description("5 %")]
        KeyboardKeypad_5 = 0x00070022,

        /// <summary>
        ///     6 ^ Usage.
        /// </summary>
        [Description("6 ^")]
        KeyboardKeypad_6 = 0x00070023,

        /// <summary>
        ///     7 & Usage.
        /// </summary>
        [Description("7 &")]
        KeyboardKeypad_7 = 0x00070024,

        /// <summary>
        ///     8 * Usage.
        /// </summary>
        [Description("8 *")]
        KeyboardKeypad_8 = 0x00070025,

        /// <summary>
        ///     9 ( Usage.
        /// </summary>
        [Description("9 (")]
        KeyboardKeypad_9 = 0x00070026,

        /// <summary>
        ///     0 ) Usage.
        /// </summary>
        [Description("0 )")]
        KeyboardKeypad_0 = 0x00070027,

        /// <summary>
        ///     Enter Usage.
        /// </summary>
        [Description("Enter")]
        Enter = 0x00070028,

        /// <summary>
        ///     Esc Usage.
        /// </summary>
        [Description("Esc")]
        Esc = 0x00070029,

        /// <summary>
        ///     Backspace Usage.
        /// </summary>
        [Description("Backspace")]
        Backspace = 0x0007002a,

        /// <summary>
        ///     Tab Usage.
        /// </summary>
        [Description("Tab")]
        Tab = 0x0007002b,

        /// <summary>
        ///     Space Usage.
        /// </summary>
        [Description("Space")]
        Space = 0x0007002c,

        /// <summary>
        ///     - _ Usage.
        /// </summary>
        [Description("- _")]
        _ = 0x0007002d,

        /// <summary>
        ///     = + Usage.
        /// </summary>
        [Description("= +")]
        KeyboardKeypad_ = 0x0007002e,

        /// <summary>
        ///     [ { Usage.
        /// </summary>
        [Description("[ {")]
        KeyboardKeypad_10 = 0x0007002f,

        /// <summary>
        ///     ] } Usage.
        /// </summary>
        [Description("] }")]
        KeyboardKeypad_11 = 0x00070030,

        /// <summary>
        ///     \ | Usage.
        /// </summary>
        [Description("\\ |")]
        KeyboardKeypad_12 = 0x00070031,

        /// <summary>
        ///     # ~ Usage.
        /// </summary>
        [Description("# ~")]
        KeyboardKeypad_13 = 0x00070032,

        /// <summary>
        ///     ; : Usage.
        /// </summary>
        [Description("; :")]
        KeyboardKeypad_14 = 0x00070033,

        /// <summary>
        ///     ' " Usage.
        /// </summary>
        [Description("' \"")]
        KeyboardKeypad_15 = 0x00070034,

        /// <summary>
        ///     ` ´ Usage.
        /// </summary>
        [Description("` ´")]
        KeyboardKeypad_16 = 0x00070035,

        /// <summary>
        ///     , < Usage.
        /// </summary>
        [Description(", <")]
        KeyboardKeypad_17 = 0x00070036,

        /// <summary>
        ///     . > Usage.
        /// </summary>
        [Description(". >")]
        KeyboardKeypad_18 = 0x00070037,

        /// <summary>
        ///     / ? Usage.
        /// </summary>
        [Description("/ ?")]
        KeyboardKeypad_19 = 0x00070038,

        /// <summary>
        ///     CapsLock Usage.
        /// </summary>
        [Description("CapsLock")]
        CapsLock = 0x00070039,

        /// <summary>
        ///     F1 Usage.
        /// </summary>
        [Description("F1")]
        F1 = 0x0007003a,

        /// <summary>
        ///     F2 Usage.
        /// </summary>
        [Description("F2")]
        F2 = 0x0007003b,

        /// <summary>
        ///     F3 Usage.
        /// </summary>
        [Description("F3")]
        F3 = 0x0007003c,

        /// <summary>
        ///     F4 Usage.
        /// </summary>
        [Description("F4")]
        F4 = 0x0007003d,

        /// <summary>
        ///     F5 Usage.
        /// </summary>
        [Description("F5")]
        F5 = 0x0007003e,

        /// <summary>
        ///     F6 Usage.
        /// </summary>
        [Description("F6")]
        F6 = 0x0007003f,

        /// <summary>
        ///     F7 Usage.
        /// </summary>
        [Description("F7")]
        F7 = 0x00070040,

        /// <summary>
        ///     F8 Usage.
        /// </summary>
        [Description("F8")]
        F8 = 0x00070041,

        /// <summary>
        ///     F9 Usage.
        /// </summary>
        [Description("F9")]
        F9 = 0x00070042,

        /// <summary>
        ///     F10 Usage.
        /// </summary>
        [Description("F10")]
        F10 = 0x00070043,

        /// <summary>
        ///     F11 Usage.
        /// </summary>
        [Description("F11")]
        F11 = 0x00070044,

        /// <summary>
        ///     F12 Usage.
        /// </summary>
        [Description("F12")]
        F12 = 0x00070045,

        /// <summary>
        ///     PrintScreen SysRq Usage.
        /// </summary>
        [Description("PrintScreen SysRq")]
        PrintScreenSysRq = 0x00070046,

        /// <summary>
        ///     ScrollLock Usage.
        /// </summary>
        [Description("ScrollLock")]
        ScrollLock = 0x00070047,

        /// <summary>
        ///     Pause Usage.
        /// </summary>
        [Description("Pause")]
        Pause = 0x00070048,

        /// <summary>
        ///     Insert Usage.
        /// </summary>
        [Description("Insert")]
        Insert = 0x00070049,

        /// <summary>
        ///     Home Usage.
        /// </summary>
        [Description("Home")]
        Home = 0x0007004a,

        /// <summary>
        ///     PageUp Usage.
        /// </summary>
        [Description("PageUp")]
        PageUp = 0x0007004b,

        /// <summary>
        ///     Delete Usage.
        /// </summary>
        [Description("Delete")]
        Delete = 0x0007004c,

        /// <summary>
        ///     End Usage.
        /// </summary>
        [Description("End")]
        End = 0x0007004d,

        /// <summary>
        ///     PageDown Usage.
        /// </summary>
        [Description("PageDown")]
        PageDown = 0x0007004e,

        /// <summary>
        ///     RightArrow Usage.
        /// </summary>
        [Description("RightArrow")]
        RightArrow = 0x0007004f,

        /// <summary>
        ///     LeftArrow Usage.
        /// </summary>
        [Description("LeftArrow")]
        LeftArrow = 0x00070050,

        /// <summary>
        ///     DownArrow Usage.
        /// </summary>
        [Description("DownArrow")]
        DownArrow = 0x00070051,

        /// <summary>
        ///     UpArrow Usage.
        /// </summary>
        [Description("UpArrow")]
        UpArrow = 0x00070052,

        /// <summary>
        ///     NumLock Clear Usage.
        /// </summary>
        [Description("NumLock Clear")]
        NumLockClear = 0x00070053,

        /// <summary>
        ///     Keypad / Usage.
        /// </summary>
        [Description("Keypad /")]
        Keypad = 0x00070054,

        /// <summary>
        ///     Keypad * Usage.
        /// </summary>
        [Description("Keypad *")]
        Keypad2 = 0x00070055,

        /// <summary>
        ///     Keypad - Usage.
        /// </summary>
        [Description("Keypad -")]
        Keypad3 = 0x00070056,

        /// <summary>
        ///     Keypad + Usage.
        /// </summary>
        [Description("Keypad +")]
        Keypad4 = 0x00070057,

        /// <summary>
        ///     Keypad Enter Usage.
        /// </summary>
        [Description("Keypad Enter")]
        KeypadEnter = 0x00070058,

        /// <summary>
        ///     Keypad 1 Usage.
        /// </summary>
        [Description("Keypad 1")]
        Keypad1 = 0x00070059,

        /// <summary>
        ///     Keypad 2 Usage.
        /// </summary>
        [Description("Keypad 2")]
        Keypad22 = 0x0007005a,

        /// <summary>
        ///     Keypad 3 Usage.
        /// </summary>
        [Description("Keypad 3")]
        Keypad32 = 0x0007005b,

        /// <summary>
        ///     Keypad 4 Usage.
        /// </summary>
        [Description("Keypad 4")]
        Keypad42 = 0x0007005c,

        /// <summary>
        ///     Keypad 5 Usage.
        /// </summary>
        [Description("Keypad 5")]
        Keypad5 = 0x0007005d,

        /// <summary>
        ///     Keypad 6 Usage.
        /// </summary>
        [Description("Keypad 6")]
        Keypad6 = 0x0007005e,

        /// <summary>
        ///     Keypad 7 Usage.
        /// </summary>
        [Description("Keypad 7")]
        Keypad7 = 0x0007005f,

        /// <summary>
        ///     Keypad 8 Usage.
        /// </summary>
        [Description("Keypad 8")]
        Keypad8 = 0x00070060,

        /// <summary>
        ///     Keypad 9 Usage.
        /// </summary>
        [Description("Keypad 9")]
        Keypad9 = 0x00070061,

        /// <summary>
        ///     Keypad 0 Usage.
        /// </summary>
        [Description("Keypad 0")]
        Keypad0 = 0x00070062,

        /// <summary>
        ///     Keypad . Usage.
        /// </summary>
        [Description("Keypad .")]
        Keypad10 = 0x00070063,

        /// <summary>
        ///     \ | Usage.
        /// </summary>
        [Description("\\ |")]
        KeyboardKeypad_20 = 0x00070064,

        /// <summary>
        ///     Application Usage.
        /// </summary>
        [Description("Application")]
        Application = 0x00070065,

        /// <summary>
        ///     Power Usage.
        /// </summary>
        [Description("Power")]
        Power = 0x00070066,

        /// <summary>
        ///     Keypad = Usage.
        /// </summary>
        [Description("Keypad =")]
        Keypad11 = 0x00070067,

        /// <summary>
        ///     F13 Usage.
        /// </summary>
        [Description("F13")]
        F13 = 0x00070068,

        /// <summary>
        ///     F14 Usage.
        /// </summary>
        [Description("F14")]
        F14 = 0x00070069,

        /// <summary>
        ///     F15 Usage.
        /// </summary>
        [Description("F15")]
        F15 = 0x0007006a,

        /// <summary>
        ///     F16 Usage.
        /// </summary>
        [Description("F16")]
        F16 = 0x0007006b,

        /// <summary>
        ///     F17 Usage.
        /// </summary>
        [Description("F17")]
        F17 = 0x0007006c,

        /// <summary>
        ///     F18 Usage.
        /// </summary>
        [Description("F18")]
        F18 = 0x0007006d,

        /// <summary>
        ///     F19 Usage.
        /// </summary>
        [Description("F19")]
        F19 = 0x0007006e,

        /// <summary>
        ///     F20 Usage.
        /// </summary>
        [Description("F20")]
        F20 = 0x0007006f,

        /// <summary>
        ///     F21 Usage.
        /// </summary>
        [Description("F21")]
        F21 = 0x00070070,

        /// <summary>
        ///     F22 Usage.
        /// </summary>
        [Description("F22")]
        F22 = 0x00070071,

        /// <summary>
        ///     F23 Usage.
        /// </summary>
        [Description("F23")]
        F23 = 0x00070072,

        /// <summary>
        ///     F24 Usage.
        /// </summary>
        [Description("F24")]
        F24 = 0x00070073,

        /// <summary>
        ///     Execute Usage.
        /// </summary>
        [Description("Execute")]
        Execute = 0x00070074,

        /// <summary>
        ///     Help Usage.
        /// </summary>
        [Description("Help")]
        Help = 0x00070075,

        /// <summary>
        ///     Menu Usage.
        /// </summary>
        [Description("Menu")]
        Menu = 0x00070076,

        /// <summary>
        ///     Select Usage.
        /// </summary>
        [Description("Select")]
        Select = 0x00070077,

        /// <summary>
        ///     Stop Usage.
        /// </summary>
        [Description("Stop")]
        Stop = 0x00070078,

        /// <summary>
        ///     Again Usage.
        /// </summary>
        [Description("Again")]
        Again = 0x00070079,

        /// <summary>
        ///     Undo Usage.
        /// </summary>
        [Description("Undo")]
        Undo = 0x0007007a,

        /// <summary>
        ///     Cut Usage.
        /// </summary>
        [Description("Cut")]
        Cut = 0x0007007b,

        /// <summary>
        ///     Copy Usage.
        /// </summary>
        [Description("Copy")]
        Copy = 0x0007007c,

        /// <summary>
        ///     Paste Usage.
        /// </summary>
        [Description("Paste")]
        Paste = 0x0007007d,

        /// <summary>
        ///     Find Usage.
        /// </summary>
        [Description("Find")]
        Find = 0x0007007e,

        /// <summary>
        ///     Mute Usage.
        /// </summary>
        [Description("Mute")]
        Mute = 0x0007007f,

        /// <summary>
        ///     VolumeUp Usage.
        /// </summary>
        [Description("VolumeUp")]
        VolumeUp = 0x00070080,

        /// <summary>
        ///     VolumeDown Usage.
        /// </summary>
        [Description("VolumeDown")]
        VolumeDown = 0x00070081,

        /// <summary>
        ///     LockingCapsLock Usage.
        /// </summary>
        [Description("LockingCapsLock")]
        LockingCapsLock = 0x00070082,

        /// <summary>
        ///     LockingNumLock Usage.
        /// </summary>
        [Description("LockingNumLock")]
        LockingNumLock = 0x00070083,

        /// <summary>
        ///     LockingScrollLock Usage.
        /// </summary>
        [Description("LockingScrollLock")]
        LockingScrollLock = 0x00070084,

        /// <summary>
        ///     Keypad , Usage.
        /// </summary>
        [Description("Keypad ,")]
        Keypad12 = 0x00070085,

        /// <summary>
        ///     Keypad == Usage.
        /// </summary>
        [Description("Keypad ==")]
        Keypad13 = 0x00070086,

        /*
         * Range: 0x0087 -> 0x008f
         * International{n+1}
         */

        /// <summary>
        ///     International1 Usage.
        /// </summary>
        [Description("International1")]
        International1 = 0x00070087,

        /// <summary>
        ///     International2 Usage.
        /// </summary>
        [Description("International2")]
        International2 = 0x00070088,

        /// <summary>
        ///     International3 Usage.
        /// </summary>
        [Description("International3")]
        International3 = 0x00070089,

        /// <summary>
        ///     International4 Usage.
        /// </summary>
        [Description("International4")]
        International4 = 0x0007008a,

        /// <summary>
        ///     International5 Usage.
        /// </summary>
        [Description("International5")]
        International5 = 0x0007008b,

        /// <summary>
        ///     International6 Usage.
        /// </summary>
        [Description("International6")]
        International6 = 0x0007008c,

        /// <summary>
        ///     International7 Usage.
        /// </summary>
        [Description("International7")]
        International7 = 0x0007008d,

        /// <summary>
        ///     International8 Usage.
        /// </summary>
        [Description("International8")]
        International8 = 0x0007008e,

        /// <summary>
        ///     International9 Usage.
        /// </summary>
        [Description("International9")]
        International9 = 0x0007008f,

        /*
         * Range: 0x0090 -> 0x0098
         * LANG{n+1}
         */

        /// <summary>
        ///     LANG1 Usage.
        /// </summary>
        [Description("LANG1")]
        LANG1 = 0x00070090,

        /// <summary>
        ///     LANG2 Usage.
        /// </summary>
        [Description("LANG2")]
        LANG2 = 0x00070091,

        /// <summary>
        ///     LANG3 Usage.
        /// </summary>
        [Description("LANG3")]
        LANG3 = 0x00070092,

        /// <summary>
        ///     LANG4 Usage.
        /// </summary>
        [Description("LANG4")]
        LANG4 = 0x00070093,

        /// <summary>
        ///     LANG5 Usage.
        /// </summary>
        [Description("LANG5")]
        LANG5 = 0x00070094,

        /// <summary>
        ///     LANG6 Usage.
        /// </summary>
        [Description("LANG6")]
        LANG6 = 0x00070095,

        /// <summary>
        ///     LANG7 Usage.
        /// </summary>
        [Description("LANG7")]
        LANG7 = 0x00070096,

        /// <summary>
        ///     LANG8 Usage.
        /// </summary>
        [Description("LANG8")]
        LANG8 = 0x00070097,

        /// <summary>
        ///     LANG9 Usage.
        /// </summary>
        [Description("LANG9")]
        LANG9 = 0x00070098,

        /// <summary>
        ///     Alternate Erase Usage.
        /// </summary>
        [Description("Alternate Erase")]
        AlternateErase = 0x00070099,

        /// <summary>
        ///     SysReq Attention Usage.
        /// </summary>
        [Description("SysReq Attention")]
        SysReqAttention = 0x0007009a,

        /// <summary>
        ///     Cancel Usage.
        /// </summary>
        [Description("Cancel")]
        Cancel = 0x0007009b,

        /// <summary>
        ///     Clear Usage.
        /// </summary>
        [Description("Clear")]
        Clear = 0x0007009c,

        /// <summary>
        ///     Prior Usage.
        /// </summary>
        [Description("Prior")]
        Prior = 0x0007009d,

        /// <summary>
        ///     Return Usage.
        /// </summary>
        [Description("Return")]
        Return = 0x0007009e,

        /// <summary>
        ///     Separator Usage.
        /// </summary>
        [Description("Separator")]
        Separator = 0x0007009f,

        /// <summary>
        ///     Out Usage.
        /// </summary>
        [Description("Out")]
        Out = 0x000700a0,

        /// <summary>
        ///     Oper Usage.
        /// </summary>
        [Description("Oper")]
        Oper = 0x000700a1,

        /// <summary>
        ///     Clear Again Usage.
        /// </summary>
        [Description("Clear Again")]
        ClearAgain = 0x000700a2,

        /// <summary>
        ///     CrSel Props Usage.
        /// </summary>
        [Description("CrSel Props")]
        CrSelProps = 0x000700a3,

        /// <summary>
        ///     ExSel Usage.
        /// </summary>
        [Description("ExSel")]
        ExSel = 0x000700a4,

        /// <summary>
        ///     Keypad 00 Usage.
        /// </summary>
        [Description("Keypad 00")]
        Keypad00 = 0x000700b0,

        /// <summary>
        ///     Keypad 000 Usage.
        /// </summary>
        [Description("Keypad 000")]
        Keypad000 = 0x000700b1,

        /// <summary>
        ///     1000sSeparator Usage.
        /// </summary>
        [Description("1000sSeparator")]
        SSeparator = 0x000700b2,

        /// <summary>
        ///     DecimalSeparator Usage.
        /// </summary>
        [Description("DecimalSeparator")]
        DecimalSeparator = 0x000700b3,

        /// <summary>
        ///     CurrencyUnit Usage.
        /// </summary>
        [Description("CurrencyUnit")]
        CurrencyUnit = 0x000700b4,

        /// <summary>
        ///     CurrencySubunit Usage.
        /// </summary>
        [Description("CurrencySubunit")]
        CurrencySubunit = 0x000700b5,

        /// <summary>
        ///     Keypad ( Usage.
        /// </summary>
        [Description("Keypad (")]
        Keypad14 = 0x000700b6,

        /// <summary>
        ///     Keypad ) Usage.
        /// </summary>
        [Description("Keypad )")]
        Keypad15 = 0x000700b7,

        /// <summary>
        ///     Keypad { Usage.
        /// </summary>
        [Description("Keypad {")]
        Keypad16 = 0x000700b8,

        /// <summary>
        ///     Keypad } Usage.
        /// </summary>
        [Description("Keypad }")]
        Keypad17 = 0x000700b9,

        /// <summary>
        ///     Keypad Tab Usage.
        /// </summary>
        [Description("Keypad Tab")]
        KeypadTab = 0x000700ba,

        /// <summary>
        ///     Keypad Backspace Usage.
        /// </summary>
        [Description("Keypad Backspace")]
        KeypadBackspace = 0x000700bb,

        /// <summary>
        ///     Keypad A Usage.
        /// </summary>
        [Description("Keypad A")]
        KeypadA = 0x000700bc,

        /// <summary>
        ///     Keypad B Usage.
        /// </summary>
        [Description("Keypad B")]
        KeypadB = 0x000700bd,

        /// <summary>
        ///     Keypad C Usage.
        /// </summary>
        [Description("Keypad C")]
        KeypadC = 0x000700be,

        /// <summary>
        ///     Keypad D Usage.
        /// </summary>
        [Description("Keypad D")]
        KeypadD = 0x000700bf,

        /// <summary>
        ///     Keypad E Usage.
        /// </summary>
        [Description("Keypad E")]
        KeypadE = 0x000700c0,

        /// <summary>
        ///     Keypad F Usage.
        /// </summary>
        [Description("Keypad F")]
        KeypadF = 0x000700c1,

        /// <summary>
        ///     Keypad XOR Usage.
        /// </summary>
        [Description("Keypad XOR")]
        KeypadXOR = 0x000700c2,

        /// <summary>
        ///     Keypad ^ Usage.
        /// </summary>
        [Description("Keypad ^")]
        Keypad18 = 0x000700c3,

        /// <summary>
        ///     Keypad % Usage.
        /// </summary>
        [Description("Keypad %")]
        Keypad19 = 0x000700c4,

        /// <summary>
        ///     Keypad < Usage.
        /// </summary>
        [Description("Keypad <")]
        Keypad20 = 0x000700c5,

        /// <summary>
        ///     Keypad > Usage.
        /// </summary>
        [Description("Keypad >")]
        Keypad21 = 0x000700c6,

        /// <summary>
        ///     Keypad & Usage.
        /// </summary>
        [Description("Keypad &")]
        Keypad23 = 0x000700c7,

        /// <summary>
        ///     Keypad && Usage.
        /// </summary>
        [Description("Keypad &&")]
        Keypad24 = 0x000700c8,

        /// <summary>
        ///     Keypad | Usage.
        /// </summary>
        [Description("Keypad |")]
        Keypad25 = 0x000700c9,

        /// <summary>
        ///     Keypad || Usage.
        /// </summary>
        [Description("Keypad ||")]
        Keypad26 = 0x000700ca,

        /// <summary>
        ///     Keypad : Usage.
        /// </summary>
        [Description("Keypad :")]
        Keypad27 = 0x000700cb,

        /// <summary>
        ///     Keypad # Usage.
        /// </summary>
        [Description("Keypad #")]
        Keypad28 = 0x000700cc,

        /// <summary>
        ///     Keypad Space Usage.
        /// </summary>
        [Description("Keypad Space")]
        KeypadSpace = 0x000700cd,

        /// <summary>
        ///     Keypad @ Usage.
        /// </summary>
        [Description("Keypad @")]
        Keypad29 = 0x000700ce,

        /// <summary>
        ///     Keypad ! Usage.
        /// </summary>
        [Description("Keypad !")]
        Keypad30 = 0x000700cf,

        /// <summary>
        ///     Keypad MemoryStore Usage.
        /// </summary>
        [Description("Keypad MemoryStore")]
        KeypadMemoryStore = 0x000700d0,

        /// <summary>
        ///     Keypad MemoryRecall Usage.
        /// </summary>
        [Description("Keypad MemoryRecall")]
        KeypadMemoryRecall = 0x000700d1,

        /// <summary>
        ///     Keypad MemoryClear Usage.
        /// </summary>
        [Description("Keypad MemoryClear")]
        KeypadMemoryClear = 0x000700d2,

        /// <summary>
        ///     Keypad MemoryAdd Usage.
        /// </summary>
        [Description("Keypad MemoryAdd")]
        KeypadMemoryAdd = 0x000700d3,

        /// <summary>
        ///     Keypad MemorySubtract Usage.
        /// </summary>
        [Description("Keypad MemorySubtract")]
        KeypadMemorySubtract = 0x000700d4,

        /// <summary>
        ///     Keypad MemoryMultiply Usage.
        /// </summary>
        [Description("Keypad MemoryMultiply")]
        KeypadMemoryMultiply = 0x000700d5,

        /// <summary>
        ///     Keypad MemoryDivide Usage.
        /// </summary>
        [Description("Keypad MemoryDivide")]
        KeypadMemoryDivide = 0x000700d6,

        /// <summary>
        ///     Keypad +/- Usage.
        /// </summary>
        [Description("Keypad +/-")]
        Keypad31 = 0x000700d7,

        /// <summary>
        ///     Keypad Clear Usage.
        /// </summary>
        [Description("Keypad Clear")]
        KeypadClear = 0x000700d8,

        /// <summary>
        ///     Keypad ClearEntry Usage.
        /// </summary>
        [Description("Keypad ClearEntry")]
        KeypadClearEntry = 0x000700d9,

        /// <summary>
        ///     Keypad Binary Usage.
        /// </summary>
        [Description("Keypad Binary")]
        KeypadBinary = 0x000700da,

        /// <summary>
        ///     Keypad Octal Usage.
        /// </summary>
        [Description("Keypad Octal")]
        KeypadOctal = 0x000700db,

        /// <summary>
        ///     Keypad Decimal Usage.
        /// </summary>
        [Description("Keypad Decimal")]
        KeypadDecimal = 0x000700dc,

        /// <summary>
        ///     Keypad Hexadecimal Usage.
        /// </summary>
        [Description("Keypad Hexadecimal")]
        KeypadHexadecimal = 0x000700dd,

        /// <summary>
        ///     LeftCtrl Usage.
        /// </summary>
        [Description("LeftCtrl")]
        LeftCtrl = 0x000700e0,

        /// <summary>
        ///     LeftShift Usage.
        /// </summary>
        [Description("LeftShift")]
        LeftShift = 0x000700e1,

        /// <summary>
        ///     LeftAlt Usage.
        /// </summary>
        [Description("LeftAlt")]
        LeftAlt = 0x000700e2,

        /// <summary>
        ///     LeftGUI Usage.
        /// </summary>
        [Description("LeftGUI")]
        LeftGUI = 0x000700e3,

        /// <summary>
        ///     RightCtrl Usage.
        /// </summary>
        [Description("RightCtrl")]
        RightCtrl = 0x000700e4,

        /// <summary>
        ///     RightShift Usage.
        /// </summary>
        [Description("RightShift")]
        RightShift = 0x000700e5,

        /// <summary>
        ///     RightAlt Usage.
        /// </summary>
        [Description("RightAlt")]
        RightAlt = 0x000700e6,

        /// <summary>
        ///     RightGUI Usage.
        /// </summary>
        [Description("RightGUI")]
        RightGUI = 0x000700e7
    }

    /// <summary>
    ///     LEDs Usage Page.
    /// </summary>
    [Description("LEDs Usage Page")]
    public enum LEDsPage : uint
    {
        /// <summary>
        ///     Undefined Usage.
        /// </summary>
        [Description("Undefined")]
        Undefined = 0x00080000,

        /// <summary>
        ///     Num Lock Usage.
        /// </summary>
        [Description("Num Lock")]
        NumLock = 0x00080001,

        /// <summary>
        ///     Caps Lock Usage.
        /// </summary>
        [Description("Caps Lock")]
        CapsLock = 0x00080002,

        /// <summary>
        ///     Scroll Lock Usage.
        /// </summary>
        [Description("Scroll Lock")]
        ScrollLock = 0x00080003,

        /// <summary>
        ///     Compose Usage.
        /// </summary>
        [Description("Compose")]
        Compose = 0x00080004,

        /// <summary>
        ///     Kana Usage.
        /// </summary>
        [Description("Kana")]
        Kana = 0x00080005,

        /// <summary>
        ///     Power Usage.
        /// </summary>
        [Description("Power")]
        Power = 0x00080006,

        /// <summary>
        ///     Shift Usage.
        /// </summary>
        [Description("Shift")]
        Shift = 0x00080007,

        /// <summary>
        ///     Do Not Disturb Usage.
        /// </summary>
        [Description("Do Not Disturb")]
        DoNotDisturb = 0x00080008,

        /// <summary>
        ///     Mute Usage.
        /// </summary>
        [Description("Mute")]
        Mute = 0x00080009,

        /// <summary>
        ///     Tone Enable Usage.
        /// </summary>
        [Description("Tone Enable")]
        ToneEnable = 0x0008000a,

        /// <summary>
        ///     High Cut Filter Usage.
        /// </summary>
        [Description("High Cut Filter")]
        HighCutFilter = 0x0008000b,

        /// <summary>
        ///     Low Cut Filter Usage.
        /// </summary>
        [Description("Low Cut Filter")]
        LowCutFilter = 0x0008000c,

        /// <summary>
        ///     Equalizer Enable Usage.
        /// </summary>
        [Description("Equalizer Enable")]
        EqualizerEnable = 0x0008000d,

        /// <summary>
        ///     Sound Field On Usage.
        /// </summary>
        [Description("Sound Field On")]
        SoundFieldOn = 0x0008000e,

        /// <summary>
        ///     Surround On Usage.
        /// </summary>
        [Description("Surround On")]
        SurroundOn = 0x0008000f,

        /// <summary>
        ///     Repeat Usage.
        /// </summary>
        [Description("Repeat")]
        Repeat = 0x00080010,

        /// <summary>
        ///     Stereo Usage.
        /// </summary>
        [Description("Stereo")]
        Stereo = 0x00080011,

        /// <summary>
        ///     Sampling Rate Detect Usage.
        /// </summary>
        [Description("Sampling Rate Detect")]
        SamplingRateDetect = 0x00080012,

        /// <summary>
        ///     Spinning Usage.
        /// </summary>
        [Description("Spinning")]
        Spinning = 0x00080013,

        /// <summary>
        ///     CAV Usage.
        /// </summary>
        [Description("CAV")]
        CAV = 0x00080014,

        /// <summary>
        ///     CLV Usage.
        /// </summary>
        [Description("CLV")]
        CLV = 0x00080015,

        /// <summary>
        ///     Recording Format Detect Usage.
        /// </summary>
        [Description("Recording Format Detect")]
        RecordingFormatDetect = 0x00080016,

        /// <summary>
        ///     Off-Hook Usage.
        /// </summary>
        [Description("Off-Hook")]
        OffHook = 0x00080017,

        /// <summary>
        ///     Ring Usage.
        /// </summary>
        [Description("Ring")]
        Ring = 0x00080018,

        /// <summary>
        ///     Message Waiting Usage.
        /// </summary>
        [Description("Message Waiting")]
        MessageWaiting = 0x00080019,

        /// <summary>
        ///     Data Mode Usage.
        /// </summary>
        [Description("Data Mode")]
        DataMode = 0x0008001a,

        /// <summary>
        ///     Battery Operation Usage.
        /// </summary>
        [Description("Battery Operation")]
        BatteryOperation = 0x0008001b,

        /// <summary>
        ///     Battery OK Usage.
        /// </summary>
        [Description("Battery OK")]
        BatteryOK = 0x0008001c,

        /// <summary>
        ///     Battery Low Usage.
        /// </summary>
        [Description("Battery Low")]
        BatteryLow = 0x0008001d,

        /// <summary>
        ///     Speaker Usage.
        /// </summary>
        [Description("Speaker")]
        Speaker = 0x0008001e,

        /// <summary>
        ///     Head Set Usage.
        /// </summary>
        [Description("Head Set")]
        HeadSet = 0x0008001f,

        /// <summary>
        ///     Hold Usage.
        /// </summary>
        [Description("Hold")]
        Hold = 0x00080020,

        /// <summary>
        ///     Microphone Usage.
        /// </summary>
        [Description("Microphone")]
        Microphone = 0x00080021,

        /// <summary>
        ///     Coverage Usage.
        /// </summary>
        [Description("Coverage")]
        Coverage = 0x00080022,

        /// <summary>
        ///     Night Mode Usage.
        /// </summary>
        [Description("Night Mode")]
        NightMode = 0x00080023,

        /// <summary>
        ///     Send Calls Usage.
        /// </summary>
        [Description("Send Calls")]
        SendCalls = 0x00080024,

        /// <summary>
        ///     Call Pickup Usage.
        /// </summary>
        [Description("Call Pickup")]
        CallPickup = 0x00080025,

        /// <summary>
        ///     Conference Usage.
        /// </summary>
        [Description("Conference")]
        Conference = 0x00080026,

        /// <summary>
        ///     Stand-by Usage.
        /// </summary>
        [Description("Stand-by")]
        Standby = 0x00080027,

        /// <summary>
        ///     Camera On Usage.
        /// </summary>
        [Description("Camera On")]
        CameraOn = 0x00080028,

        /// <summary>
        ///     Camera Off Usage.
        /// </summary>
        [Description("Camera Off")]
        CameraOff = 0x00080029,

        /// <summary>
        ///     On-Line Usage.
        /// </summary>
        [Description("On-Line")]
        OnLine = 0x0008002a,

        /// <summary>
        ///     Off-Line Usage.
        /// </summary>
        [Description("Off-Line")]
        OffLine = 0x0008002b,

        /// <summary>
        ///     Busy Usage.
        /// </summary>
        [Description("Busy")]
        Busy = 0x0008002c,

        /// <summary>
        ///     Ready Usage.
        /// </summary>
        [Description("Ready")]
        Ready = 0x0008002d,

        /// <summary>
        ///     Paper-Out Usage.
        /// </summary>
        [Description("Paper-Out")]
        PaperOut = 0x0008002e,

        /// <summary>
        ///     Paper-Jam Usage.
        /// </summary>
        [Description("Paper-Jam")]
        PaperJam = 0x0008002f,

        /// <summary>
        ///     Remote Usage.
        /// </summary>
        [Description("Remote")]
        Remote = 0x00080030,

        /// <summary>
        ///     Forward Usage.
        /// </summary>
        [Description("Forward")]
        Forward = 0x00080031,

        /// <summary>
        ///     Reverse Usage.
        /// </summary>
        [Description("Reverse")]
        Reverse = 0x00080032,

        /// <summary>
        ///     Stop Usage.
        /// </summary>
        [Description("Stop")]
        Stop = 0x00080033,

        /// <summary>
        ///     Rewind Usage.
        /// </summary>
        [Description("Rewind")]
        Rewind = 0x00080034,

        /// <summary>
        ///     Fast Forward Usage.
        /// </summary>
        [Description("Fast Forward")]
        FastForward = 0x00080035,

        /// <summary>
        ///     Play Usage.
        /// </summary>
        [Description("Play")]
        Play = 0x00080036,

        /// <summary>
        ///     Pause Usage.
        /// </summary>
        [Description("Pause")]
        Pause = 0x00080037,

        /// <summary>
        ///     Record Usage.
        /// </summary>
        [Description("Record")]
        Record = 0x00080038,

        /// <summary>
        ///     Error Usage.
        /// </summary>
        [Description("Error")]
        Error = 0x00080039,

        /// <summary>
        ///     Usage Selected Indicator Usage.
        /// </summary>
        [Description("Usage Selected Indicator")]
        UsageSelectedIndicator = 0x0008003a,

        /// <summary>
        ///     Usage In Use Indicator Usage.
        /// </summary>
        [Description("Usage In Use Indicator")]
        UsageInUseIndicator = 0x0008003b,

        /// <summary>
        ///     Usage Multi Mode Indicator Usage.
        /// </summary>
        [Description("Usage Multi Mode Indicator")]
        UsageMultiModeIndicator = 0x0008003c,

        /// <summary>
        ///     Indicator On Usage.
        /// </summary>
        [Description("Indicator On")]
        IndicatorOn = 0x0008003d,

        /// <summary>
        ///     Indicator Flash Usage.
        /// </summary>
        [Description("Indicator Flash")]
        IndicatorFlash = 0x0008003e,

        /// <summary>
        ///     Indicator Slow Blink Usage.
        /// </summary>
        [Description("Indicator Slow Blink")]
        IndicatorSlowBlink = 0x0008003f,

        /// <summary>
        ///     Indicator Fast Blink Usage.
        /// </summary>
        [Description("Indicator Fast Blink")]
        IndicatorFastBlink = 0x00080040,

        /// <summary>
        ///     Indicator Off Usage.
        /// </summary>
        [Description("Indicator Off")]
        IndicatorOff = 0x00080041,

        /// <summary>
        ///     Flash On Time Usage.
        /// </summary>
        [Description("Flash On Time")]
        FlashOnTime = 0x00080042,

        /// <summary>
        ///     Slow Blink On Time Usage.
        /// </summary>
        [Description("Slow Blink On Time")]
        SlowBlinkOnTime = 0x00080043,

        /// <summary>
        ///     Slow Blink Off Time Usage.
        /// </summary>
        [Description("Slow Blink Off Time")]
        SlowBlinkOffTime = 0x00080044,

        /// <summary>
        ///     Fast Blink On Time Usage.
        /// </summary>
        [Description("Fast Blink On Time")]
        FastBlinkOnTime = 0x00080045,

        /// <summary>
        ///     Fast Blink Off Time Usage.
        /// </summary>
        [Description("Fast Blink Off Time")]
        FastBlinkOffTime = 0x00080046,

        /// <summary>
        ///     Usage Indicator Color Usage.
        /// </summary>
        [Description("Usage Indicator Color")]
        UsageIndicatorColor = 0x00080047,

        /// <summary>
        ///     Indicator Red Usage.
        /// </summary>
        [Description("Indicator Red")]
        IndicatorRed = 0x00080048,

        /// <summary>
        ///     Indicator Green Usage.
        /// </summary>
        [Description("Indicator Green")]
        IndicatorGreen = 0x00080049,

        /// <summary>
        ///     Indicator Amber Usage.
        /// </summary>
        [Description("Indicator Amber")]
        IndicatorAmber = 0x0008004a,

        /// <summary>
        ///     Generic Indicator Usage.
        /// </summary>
        [Description("Generic Indicator")]
        GenericIndicator = 0x0008004b,

        /// <summary>
        ///     System Suspend Usage.
        /// </summary>
        [Description("System Suspend")]
        SystemSuspend = 0x0008004c,

        /// <summary>
        ///     External Power Connected Usage.
        /// </summary>
        [Description("External Power Connected")]
        ExternalPowerConnected = 0x0008004d,

        /// <summary>
        ///     Indicator Blue Usage.
        /// </summary>
        [Description("Indicator Blue")]
        IndicatorBlue = 0x0008004e,

        /// <summary>
        ///     Indicator Orange Usage.
        /// </summary>
        [Description("Indicator Orange")]
        IndicatorOrange = 0x0008004f,

        /// <summary>
        ///     Good Status Usage.
        /// </summary>
        [Description("Good Status")]
        GoodStatus = 0x00080050,

        /// <summary>
        ///     Warning Status Usage.
        /// </summary>
        [Description("Warning Status")]
        WarningStatus = 0x00080051,

        /// <summary>
        ///     RGB LED Usage.
        /// </summary>
        [Description("RGB LED")]
        RGBLED = 0x00080052,

        /// <summary>
        ///     Red LED Channel Usage.
        /// </summary>
        [Description("Red LED Channel")]
        RedLEDChannel = 0x00080053,

        /// <summary>
        ///     Green LED Channel Usage.
        /// </summary>
        [Description("Green LED Channel")]
        GreenLEDChannel = 0x00080054,

        /// <summary>
        ///     Blue LED Channel Usage.
        /// </summary>
        [Description("Blue LED Channel")]
        BlueLEDChannel = 0x00080055,

        /// <summary>
        ///     LED Intensity Usage.
        /// </summary>
        [Description("LED Intensity")]
        LEDIntensity = 0x00080056,

        /// <summary>
        ///     Player Indicator Usage.
        /// </summary>
        [Description("Player Indicator")]
        PlayerIndicator = 0x00080060,

        /*
         * Range: 0x0061 -> 0x0068
         * Player {n+1}
         */

        /// <summary>
        ///     Player 1 Usage.
        /// </summary>
        [Description("Player 1")]
        Player1 = 0x00080061,

        /// <summary>
        ///     Player 2 Usage.
        /// </summary>
        [Description("Player 2")]
        Player2 = 0x00080062,

        /// <summary>
        ///     Player 3 Usage.
        /// </summary>
        [Description("Player 3")]
        Player3 = 0x00080063,

        /// <summary>
        ///     Player 4 Usage.
        /// </summary>
        [Description("Player 4")]
        Player4 = 0x00080064,

        /// <summary>
        ///     Player 5 Usage.
        /// </summary>
        [Description("Player 5")]
        Player5 = 0x00080065,

        /// <summary>
        ///     Player 6 Usage.
        /// </summary>
        [Description("Player 6")]
        Player6 = 0x00080066,

        /// <summary>
        ///     Player 7 Usage.
        /// </summary>
        [Description("Player 7")]
        Player7 = 0x00080067,

        /// <summary>
        ///     Player 8 Usage.
        /// </summary>
        [Description("Player 8")]
        Player8 = 0x00080068
    }

    /// <summary>
    ///     Button Usage Page.
    /// </summary>
    [Description("Button Usage Page")]
    public enum ButtonPage : uint
    {
        /// <summary>
        ///     No button pressed Usage.
        /// </summary>
        [Description("No button pressed")]
        NoButtonPressed = 0x00090000,

        /*
         * Range: 0x0001 -> 0xffff
         * Button {n+1}
         */

        /// <summary>
        ///     Button 1 Usage.
        /// </summary>
        [Description("Button 1")]
        Button1 = 0x00090001,

        /// <summary>
        ///     Button 2 Usage.
        /// </summary>
        [Description("Button 2")]
        Button2 = 0x00090002,

        /// <summary>
        ///     Button 3 Usage.
        /// </summary>
        [Description("Button 3")]
        Button3 = 0x00090003,

        /// <summary>
        ///     Button 4 Usage.
        /// </summary>
        [Description("Button 4")]
        Button4 = 0x00090004,

        /// <summary>
        ///     Button 5 Usage.
        /// </summary>
        [Description("Button 5")]
        Button5 = 0x00090005,

        /// <summary>
        ///     Button 6 Usage.
        /// </summary>
        [Description("Button 6")]
        Button6 = 0x00090006,

        /// <summary>
        ///     Button 7 Usage.
        /// </summary>
        [Description("Button 7")]
        Button7 = 0x00090007,

        /// <summary>
        ///     Button 8 Usage.
        /// </summary>
        [Description("Button 8")]
        Button8 = 0x00090008,

        /// <summary>
        ///     Button 9 Usage.
        /// </summary>
        [Description("Button 9")]
        Button9 = 0x00090009,

        /// <summary>
        ///     Button 10 Usage.
        /// </summary>
        [Description("Button 10")]
        Button10 = 0x0009000a,

        /// <summary>
        ///     Button 11 Usage.
        /// </summary>
        [Description("Button 11")]
        Button11 = 0x0009000b,

        /// <summary>
        ///     Button 12 Usage.
        /// </summary>
        [Description("Button 12")]
        Button12 = 0x0009000c,

        /// <summary>
        ///     Button 13 Usage.
        /// </summary>
        [Description("Button 13")]
        Button13 = 0x0009000d,

        /// <summary>
        ///     Button 14 Usage.
        /// </summary>
        [Description("Button 14")]
        Button14 = 0x0009000e,

        /// <summary>
        ///     Button 15 Usage.
        /// </summary>
        [Description("Button 15")]
        Button15 = 0x0009000f,

        /// <summary>
        ///     Button 16 Usage.
        /// </summary>
        [Description("Button 16")]
        Button16 = 0x00090010
    }

    /// <summary>
    ///     Ordinal Usage Page.
    /// </summary>
    [Description("Ordinal Usage Page")]
    public enum OrdinalPage : uint
    {
        /// <summary>
        ///     Undefined Usage.
        /// </summary>
        [Description("Undefined")]
        Undefined = 0x000a0000,

        /*
         * Range: 0x0001 -> 0xffff
         * Instance {n+1}
         */

        /// <summary>
        ///     Instance 1 Usage.
        /// </summary>
        [Description("Instance 1")]
        Instance1 = 0x000a0001,

        /// <summary>
        ///     Instance 2 Usage.
        /// </summary>
        [Description("Instance 2")]
        Instance2 = 0x000a0002,

        /// <summary>
        ///     Instance 3 Usage.
        /// </summary>
        [Description("Instance 3")]
        Instance3 = 0x000a0003,

        /// <summary>
        ///     Instance 4 Usage.
        /// </summary>
        [Description("Instance 4")]
        Instance4 = 0x000a0004,

        /// <summary>
        ///     Instance 5 Usage.
        /// </summary>
        [Description("Instance 5")]
        Instance5 = 0x000a0005,

        /// <summary>
        ///     Instance 6 Usage.
        /// </summary>
        [Description("Instance 6")]
        Instance6 = 0x000a0006,

        /// <summary>
        ///     Instance 7 Usage.
        /// </summary>
        [Description("Instance 7")]
        Instance7 = 0x000a0007,

        /// <summary>
        ///     Instance 8 Usage.
        /// </summary>
        [Description("Instance 8")]
        Instance8 = 0x000a0008,

        /// <summary>
        ///     Instance 9 Usage.
        /// </summary>
        [Description("Instance 9")]
        Instance9 = 0x000a0009,

        /// <summary>
        ///     Instance 10 Usage.
        /// </summary>
        [Description("Instance 10")]
        Instance10 = 0x000a000a,

        /// <summary>
        ///     Instance 11 Usage.
        /// </summary>
        [Description("Instance 11")]
        Instance11 = 0x000a000b,

        /// <summary>
        ///     Instance 12 Usage.
        /// </summary>
        [Description("Instance 12")]
        Instance12 = 0x000a000c,

        /// <summary>
        ///     Instance 13 Usage.
        /// </summary>
        [Description("Instance 13")]
        Instance13 = 0x000a000d,

        /// <summary>
        ///     Instance 14 Usage.
        /// </summary>
        [Description("Instance 14")]
        Instance14 = 0x000a000e,

        /// <summary>
        ///     Instance 15 Usage.
        /// </summary>
        [Description("Instance 15")]
        Instance15 = 0x000a000f,

        /// <summary>
        ///     Instance 16 Usage.
        /// </summary>
        [Description("Instance 16")]
        Instance16 = 0x000a0010
    }

    /// <summary>
    ///     Telephony Usage Page.
    /// </summary>
    [Description("Telephony Usage Page")]
    public enum TelephonyPage : uint
    {
        /// <summary>
        ///     Undefined Usage.
        /// </summary>
        [Description("Undefined")]
        Undefined = 0x000b0000,

        /// <summary>
        ///     Phone Usage.
        /// </summary>
        [Description("Phone")]
        Phone = 0x000b0001,

        /// <summary>
        ///     Answering Machine Usage.
        /// </summary>
        [Description("Answering Machine")]
        AnsweringMachine = 0x000b0002,

        /// <summary>
        ///     Message Controls Usage.
        /// </summary>
        [Description("Message Controls")]
        MessageControls = 0x000b0003,

        /// <summary>
        ///     Handset Usage.
        /// </summary>
        [Description("Handset")]
        Handset = 0x000b0004,

        /// <summary>
        ///     Headset Usage.
        /// </summary>
        [Description("Headset")]
        Headset = 0x000b0005,

        /// <summary>
        ///     Telephony Key Pad Usage.
        /// </summary>
        [Description("Telephony Key Pad")]
        TelephonyKeyPad = 0x000b0006,

        /// <summary>
        ///     Programmable Button Usage.
        /// </summary>
        [Description("Programmable Button")]
        ProgrammableButton = 0x000b0007,

        /// <summary>
        ///     Hook Switch Usage.
        /// </summary>
        [Description("Hook Switch")]
        HookSwitch = 0x000b0020,

        /// <summary>
        ///     Flash Usage.
        /// </summary>
        [Description("Flash")]
        Flash = 0x000b0021,

        /// <summary>
        ///     Feature Usage.
        /// </summary>
        [Description("Feature")]
        Feature = 0x000b0022,

        /// <summary>
        ///     Hold Usage.
        /// </summary>
        [Description("Hold")]
        Hold = 0x000b0023,

        /// <summary>
        ///     Redial Usage.
        /// </summary>
        [Description("Redial")]
        Redial = 0x000b0024,

        /// <summary>
        ///     Transfer Usage.
        /// </summary>
        [Description("Transfer")]
        Transfer = 0x000b0025,

        /// <summary>
        ///     Drop Usage.
        /// </summary>
        [Description("Drop")]
        Drop = 0x000b0026,

        /// <summary>
        ///     Park Usage.
        /// </summary>
        [Description("Park")]
        Park = 0x000b0027,

        /// <summary>
        ///     Forward Calls Usage.
        /// </summary>
        [Description("Forward Calls")]
        ForwardCalls = 0x000b0028,

        /// <summary>
        ///     Alternate  Function Usage.
        /// </summary>
        [Description("Alternate  Function")]
        AlternateFunction = 0x000b0029,

        /// <summary>
        ///     Line Usage.
        /// </summary>
        [Description("Line")]
        Line = 0x000b002a,

        /// <summary>
        ///     Speaker Phone Usage.
        /// </summary>
        [Description("Speaker Phone")]
        SpeakerPhone = 0x000b002b,

        /// <summary>
        ///     Conference Usage.
        /// </summary>
        [Description("Conference")]
        Conference = 0x000b002c,

        /// <summary>
        ///     Ring Enable Usage.
        /// </summary>
        [Description("Ring Enable")]
        RingEnable = 0x000b002d,

        /// <summary>
        ///     Ring Select Usage.
        /// </summary>
        [Description("Ring Select")]
        RingSelect = 0x000b002e,

        /// <summary>
        ///     Phone Mute Usage.
        /// </summary>
        [Description("Phone Mute")]
        PhoneMute = 0x000b002f,

        /// <summary>
        ///     Caller ID Usage.
        /// </summary>
        [Description("Caller ID")]
        CallerID = 0x000b0030,

        /// <summary>
        ///     Speed Dial Usage.
        /// </summary>
        [Description("Speed Dial")]
        SpeedDial = 0x000b0050,

        /// <summary>
        ///     Store Number Usage.
        /// </summary>
        [Description("Store Number")]
        StoreNumber = 0x000b0051,

        /// <summary>
        ///     Recall Number Usage.
        /// </summary>
        [Description("Recall Number")]
        RecallNumber = 0x000b0052,

        /// <summary>
        ///     Phone Directory Usage.
        /// </summary>
        [Description("Phone Directory")]
        PhoneDirectory = 0x000b0053,

        /// <summary>
        ///     Voice Mail Usage.
        /// </summary>
        [Description("Voice Mail")]
        VoiceMail = 0x000b0070,

        /// <summary>
        ///     Screen Calls Usage.
        /// </summary>
        [Description("Screen Calls")]
        ScreenCalls = 0x000b0071,

        /// <summary>
        ///     Do Not Disturb Usage.
        /// </summary>
        [Description("Do Not Disturb")]
        DoNotDisturb = 0x000b0072,

        /// <summary>
        ///     Message Usage.
        /// </summary>
        [Description("Message")]
        Message = 0x000b0073,

        /// <summary>
        ///     Answer On/Off Usage.
        /// </summary>
        [Description("Answer On/Off")]
        AnswerOnOff = 0x000b0074,

        /// <summary>
        ///     Inside Dial Tone Usage.
        /// </summary>
        [Description("Inside Dial Tone")]
        InsideDialTone = 0x000b0090,

        /// <summary>
        ///     Outside Dial Tone Usage.
        /// </summary>
        [Description("Outside Dial Tone")]
        OutsideDialTone = 0x000b0091,

        /// <summary>
        ///     Inside Ring Tone Usage.
        /// </summary>
        [Description("Inside Ring Tone")]
        InsideRingTone = 0x000b0092,

        /// <summary>
        ///     Outside Ring Tone Usage.
        /// </summary>
        [Description("Outside Ring Tone")]
        OutsideRingTone = 0x000b0093,

        /// <summary>
        ///     Priority Ring Tone Usage.
        /// </summary>
        [Description("Priority Ring Tone")]
        PriorityRingTone = 0x000b0094,

        /// <summary>
        ///     Inside Ringback Usage.
        /// </summary>
        [Description("Inside Ringback")]
        InsideRingback = 0x000b0095,

        /// <summary>
        ///     Priority Ringback Usage.
        /// </summary>
        [Description("Priority Ringback")]
        PriorityRingback = 0x000b0096,

        /// <summary>
        ///     Line Busy Tone Usage.
        /// </summary>
        [Description("Line Busy Tone")]
        LineBusyTone = 0x000b0097,

        /// <summary>
        ///     Reorder Tone Usage.
        /// </summary>
        [Description("Reorder Tone")]
        ReorderTone = 0x000b0098,

        /// <summary>
        ///     Call Waiting Tone Usage.
        /// </summary>
        [Description("Call Waiting Tone")]
        CallWaitingTone = 0x000b0099,

        /// <summary>
        ///     Confirmation Tone 1 Usage.
        /// </summary>
        [Description("Confirmation Tone 1")]
        ConfirmationTone1 = 0x000b009a,

        /// <summary>
        ///     Confirmation Tone 2 Usage.
        /// </summary>
        [Description("Confirmation Tone 2")]
        ConfirmationTone2 = 0x000b009b,

        /// <summary>
        ///     Tones Off Usage.
        /// </summary>
        [Description("Tones Off")]
        TonesOff = 0x000b009c,

        /// <summary>
        ///     Outside Ringback Usage.
        /// </summary>
        [Description("Outside Ringback")]
        OutsideRingback = 0x000b009d,

        /// <summary>
        ///     Ringer Usage.
        /// </summary>
        [Description("Ringer")]
        Ringer = 0x000b009e,

        /*
         * Range: 0x00b0 -> 0x00b9
         * Phone Key {n}
         */

        /// <summary>
        ///     Phone Key 0 Usage.
        /// </summary>
        [Description("Phone Key 0")]
        PhoneKey0 = 0x000b00b0,

        /// <summary>
        ///     Phone Key 1 Usage.
        /// </summary>
        [Description("Phone Key 1")]
        PhoneKey1 = 0x000b00b1,

        /// <summary>
        ///     Phone Key 2 Usage.
        /// </summary>
        [Description("Phone Key 2")]
        PhoneKey2 = 0x000b00b2,

        /// <summary>
        ///     Phone Key 3 Usage.
        /// </summary>
        [Description("Phone Key 3")]
        PhoneKey3 = 0x000b00b3,

        /// <summary>
        ///     Phone Key 4 Usage.
        /// </summary>
        [Description("Phone Key 4")]
        PhoneKey4 = 0x000b00b4,

        /// <summary>
        ///     Phone Key 5 Usage.
        /// </summary>
        [Description("Phone Key 5")]
        PhoneKey5 = 0x000b00b5,

        /// <summary>
        ///     Phone Key 6 Usage.
        /// </summary>
        [Description("Phone Key 6")]
        PhoneKey6 = 0x000b00b6,

        /// <summary>
        ///     Phone Key 7 Usage.
        /// </summary>
        [Description("Phone Key 7")]
        PhoneKey7 = 0x000b00b7,

        /// <summary>
        ///     Phone Key 8 Usage.
        /// </summary>
        [Description("Phone Key 8")]
        PhoneKey8 = 0x000b00b8,

        /// <summary>
        ///     Phone Key 9 Usage.
        /// </summary>
        [Description("Phone Key 9")]
        PhoneKey9 = 0x000b00b9,

        /// <summary>
        ///     Phone Key Star Usage.
        /// </summary>
        [Description("Phone Key Star")]
        PhoneKeyStar = 0x000b00ba,

        /// <summary>
        ///     Phone Key Pound Usage.
        /// </summary>
        [Description("Phone Key Pound")]
        PhoneKeyPound = 0x000b00bb,

        /// <summary>
        ///     Phone Key A Usage.
        /// </summary>
        [Description("Phone Key A")]
        PhoneKeyA = 0x000b00bc,

        /// <summary>
        ///     Phone Key B Usage.
        /// </summary>
        [Description("Phone Key B")]
        PhoneKeyB = 0x000b00bd,

        /// <summary>
        ///     Phone Key C Usage.
        /// </summary>
        [Description("Phone Key C")]
        PhoneKeyC = 0x000b00be,

        /// <summary>
        ///     Phone Key D Usage.
        /// </summary>
        [Description("Phone Key D")]
        PhoneKeyD = 0x000b00bf,

        /// <summary>
        ///     Phone Key Call History Usage.
        /// </summary>
        [Description("Phone Key Call History")]
        PhoneKeyCallHistory = 0x000b00c0,

        /// <summary>
        ///     Phone Key Caller ID Usage.
        /// </summary>
        [Description("Phone Key Caller ID")]
        PhoneKeyCallerID = 0x000b00c1,

        /// <summary>
        ///     Phone Key Settings Usage.
        /// </summary>
        [Description("Phone Key Settings")]
        PhoneKeySettings = 0x000b00c2,

        /// <summary>
        ///     Host Control Usage.
        /// </summary>
        [Description("Host Control")]
        HostControl = 0x000b00f0,

        /// <summary>
        ///     Host Available Usage.
        /// </summary>
        [Description("Host Available")]
        HostAvailable = 0x000b00f1,

        /// <summary>
        ///     Host Call Active Usage.
        /// </summary>
        [Description("Host Call Active")]
        HostCallActive = 0x000b00f2,

        /// <summary>
        ///     Activate Handset Audio Usage.
        /// </summary>
        [Description("Activate Handset Audio")]
        ActivateHandsetAudio = 0x000b00f3,

        /// <summary>
        ///     Ring Type Usage.
        /// </summary>
        [Description("Ring Type")]
        RingType = 0x000b00f4,

        /// <summary>
        ///     Re-dialable Phone Number Usage.
        /// </summary>
        [Description("Re-dialable Phone Number")]
        RedialablePhoneNumber = 0x000b00f5,

        /// <summary>
        ///     Stop Ring Tone Usage.
        /// </summary>
        [Description("Stop Ring Tone")]
        StopRingTone = 0x000b00f8,

        /// <summary>
        ///     PSTN Ring Tone Usage.
        /// </summary>
        [Description("PSTN Ring Tone")]
        PSTNRingTone = 0x000b00f9,

        /// <summary>
        ///     Host Ring Tone Usage.
        /// </summary>
        [Description("Host Ring Tone")]
        HostRingTone = 0x000b00fa,

        /// <summary>
        ///     Alert Sound Error Usage.
        /// </summary>
        [Description("Alert Sound Error")]
        AlertSoundError = 0x000b00fb,

        /// <summary>
        ///     Alert Sound Confirm Usage.
        /// </summary>
        [Description("Alert Sound Confirm")]
        AlertSoundConfirm = 0x000b00fc,

        /// <summary>
        ///     Alert Sound Notification Usage.
        /// </summary>
        [Description("Alert Sound Notification")]
        AlertSoundNotification = 0x000b00fd,

        /// <summary>
        ///     Silent Ring Usage.
        /// </summary>
        [Description("Silent Ring")]
        SilentRing = 0x000b00fe,

        /// <summary>
        ///     Email Message Waiting Usage.
        /// </summary>
        [Description("Email Message Waiting")]
        EmailMessageWaiting = 0x000b0108,

        /// <summary>
        ///     Voicemail Message Waiting Usage.
        /// </summary>
        [Description("Voicemail Message Waiting")]
        VoicemailMessageWaiting = 0x000b0109,

        /// <summary>
        ///     Host Hold Usage.
        /// </summary>
        [Description("Host Hold")]
        HostHold = 0x000b010a,

        /// <summary>
        ///     Incoming Call History Count Usage.
        /// </summary>
        [Description("Incoming Call History Count")]
        IncomingCallHistoryCount = 0x000b0110,

        /// <summary>
        ///     Outgoing Call History Count Usage.
        /// </summary>
        [Description("Outgoing Call History Count")]
        OutgoingCallHistoryCount = 0x000b0111,

        /// <summary>
        ///     Incoming Call History Usage.
        /// </summary>
        [Description("Incoming Call History")]
        IncomingCallHistory = 0x000b0112,

        /// <summary>
        ///     Outgoing Call History Usage.
        /// </summary>
        [Description("Outgoing Call History")]
        OutgoingCallHistory = 0x000b0113,

        /// <summary>
        ///     Phone Locale Usage.
        /// </summary>
        [Description("Phone Locale")]
        PhoneLocale = 0x000b0114,

        /// <summary>
        ///     Phone Time Second Usage.
        /// </summary>
        [Description("Phone Time Second")]
        PhoneTimeSecond = 0x000b0140,

        /// <summary>
        ///     Phone Time Minute Usage.
        /// </summary>
        [Description("Phone Time Minute")]
        PhoneTimeMinute = 0x000b0141,

        /// <summary>
        ///     Phone Time Hour Usage.
        /// </summary>
        [Description("Phone Time Hour")]
        PhoneTimeHour = 0x000b0142,

        /// <summary>
        ///     Phone Time Day Usage.
        /// </summary>
        [Description("Phone Time Day")]
        PhoneTimeDay = 0x000b0143,

        /// <summary>
        ///     Phone Time Month Usage.
        /// </summary>
        [Description("Phone Time Month")]
        PhoneTimeMonth = 0x000b0144,

        /// <summary>
        ///     Phone Time Year Usage.
        /// </summary>
        [Description("Phone Time Year")]
        PhoneTimeYear = 0x000b0145,

        /// <summary>
        ///     Handset Nickname Usage.
        /// </summary>
        [Description("Handset Nickname")]
        HandsetNickname = 0x000b0146,

        /// <summary>
        ///     Address Book ID Usage.
        /// </summary>
        [Description("Address Book ID")]
        AddressBookID = 0x000b0147,

        /// <summary>
        ///     Call Duration Usage.
        /// </summary>
        [Description("Call Duration")]
        CallDuration = 0x000b014a,

        /// <summary>
        ///     Dual Mode Phone Usage.
        /// </summary>
        [Description("Dual Mode Phone")]
        DualModePhone = 0x000b014b
    }

    /// <summary>
    ///     Consumer Usage Page.
    /// </summary>
    [Description("Consumer Usage Page")]
    public enum ConsumerPage : uint
    {
        /// <summary>
        ///     Undefined Usage.
        /// </summary>
        [Description("Undefined")]
        Undefined = 0x000c0000,

        /// <summary>
        ///     Consumer Control Usage.
        /// </summary>
        [Description("Consumer Control")]
        ConsumerControl = 0x000c0001,

        /// <summary>
        ///     Numeric Key Pad Usage.
        /// </summary>
        [Description("Numeric Key Pad")]
        NumericKeyPad = 0x000c0002,

        /// <summary>
        ///     Programmable Buttons Usage.
        /// </summary>
        [Description("Programmable Buttons")]
        ProgrammableButtons = 0x000c0003,

        /// <summary>
        ///     Microphone Usage.
        /// </summary>
        [Description("Microphone")]
        Microphone = 0x000c0004,

        /// <summary>
        ///     Headphone Usage.
        /// </summary>
        [Description("Headphone")]
        Headphone = 0x000c0005,

        /// <summary>
        ///     Graphic Equalizer Usage.
        /// </summary>
        [Description("Graphic Equalizer")]
        GraphicEqualizer = 0x000c0006,

        /// <summary>
        ///     +10 Usage.
        /// </summary>
        [Description("+10")]
        Consumer_10 = 0x000c0020,

        /// <summary>
        ///     +100 Usage.
        /// </summary>
        [Description("+100")]
        Consumer_100 = 0x000c0021,

        /// <summary>
        ///     AM/PM Usage.
        /// </summary>
        [Description("AM/PM")]
        AMPM = 0x000c0022,

        /// <summary>
        ///     Power Usage.
        /// </summary>
        [Description("Power")]
        Power = 0x000c0030,

        /// <summary>
        ///     Reset Usage.
        /// </summary>
        [Description("Reset")]
        Reset = 0x000c0031,

        /// <summary>
        ///     Sleep Usage.
        /// </summary>
        [Description("Sleep")]
        Sleep = 0x000c0032,

        /// <summary>
        ///     Sleep After Usage.
        /// </summary>
        [Description("Sleep After")]
        SleepAfter = 0x000c0033,

        /// <summary>
        ///     Sleep Mode Usage.
        /// </summary>
        [Description("Sleep Mode")]
        SleepMode = 0x000c0034,

        /// <summary>
        ///     Illumination Usage.
        /// </summary>
        [Description("Illumination")]
        Illumination = 0x000c0035,

        /// <summary>
        ///     Function Buttons Usage.
        /// </summary>
        [Description("Function Buttons")]
        FunctionButtons = 0x000c0036,

        /// <summary>
        ///     Menu Usage.
        /// </summary>
        [Description("Menu")]
        Menu = 0x000c0040,

        /// <summary>
        ///     Menu Pick Usage.
        /// </summary>
        [Description("Menu Pick")]
        MenuPick = 0x000c0041,

        /// <summary>
        ///     Menu Up Usage.
        /// </summary>
        [Description("Menu Up")]
        MenuUp = 0x000c0042,

        /// <summary>
        ///     Menu Down Usage.
        /// </summary>
        [Description("Menu Down")]
        MenuDown = 0x000c0043,

        /// <summary>
        ///     Menu Left Usage.
        /// </summary>
        [Description("Menu Left")]
        MenuLeft = 0x000c0044,

        /// <summary>
        ///     Menu Right Usage.
        /// </summary>
        [Description("Menu Right")]
        MenuRight = 0x000c0045,

        /// <summary>
        ///     Menu Escape Usage.
        /// </summary>
        [Description("Menu Escape")]
        MenuEscape = 0x000c0046,

        /// <summary>
        ///     Menu Value Increase Usage.
        /// </summary>
        [Description("Menu Value Increase")]
        MenuValueIncrease = 0x000c0047,

        /// <summary>
        ///     Menu Value Decrease Usage.
        /// </summary>
        [Description("Menu Value Decrease")]
        MenuValueDecrease = 0x000c0048,

        /// <summary>
        ///     Data On Screen Usage.
        /// </summary>
        [Description("Data On Screen")]
        DataOnScreen = 0x000c0060,

        /// <summary>
        ///     Closed Caption Usage.
        /// </summary>
        [Description("Closed Caption")]
        ClosedCaption = 0x000c0061,

        /// <summary>
        ///     Closed Caption Select Usage.
        /// </summary>
        [Description("Closed Caption Select")]
        ClosedCaptionSelect = 0x000c0062,

        /// <summary>
        ///     VCR/TV Usage.
        /// </summary>
        [Description("VCR/TV")]
        VCRTV = 0x000c0063,

        /// <summary>
        ///     Broadcast Mode Usage.
        /// </summary>
        [Description("Broadcast Mode")]
        BroadcastMode = 0x000c0064,

        /// <summary>
        ///     Snapshot Usage.
        /// </summary>
        [Description("Snapshot")]
        Snapshot = 0x000c0065,

        /// <summary>
        ///     Still Usage.
        /// </summary>
        [Description("Still")]
        Still = 0x000c0066,

        /// <summary>
        ///     Picture-in-Picture Toggle Usage.
        /// </summary>
        [Description("Picture-in-Picture Toggle")]
        PictureinPictureToggle = 0x000c0067,

        /// <summary>
        ///     Picture-in-Picture Swap Usage.
        /// </summary>
        [Description("Picture-in-Picture Swap")]
        PictureinPictureSwap = 0x000c0068,

        /// <summary>
        ///     Red Menu Button Usage.
        /// </summary>
        [Description("Red Menu Button")]
        RedMenuButton = 0x000c0069,

        /// <summary>
        ///     Green Menu Button Usage.
        /// </summary>
        [Description("Green Menu Button")]
        GreenMenuButton = 0x000c006a,

        /// <summary>
        ///     Blue Menu Button Usage.
        /// </summary>
        [Description("Blue Menu Button")]
        BlueMenuButton = 0x000c006b,

        /// <summary>
        ///     Yellow Menu Button Usage.
        /// </summary>
        [Description("Yellow Menu Button")]
        YellowMenuButton = 0x000c006c,

        /// <summary>
        ///     Aspect Usage.
        /// </summary>
        [Description("Aspect")]
        Aspect = 0x000c006d,

        /// <summary>
        ///     3D Mode Select Usage.
        /// </summary>
        [Description("3D Mode Select")]
        DModeSelect = 0x000c006e,

        /// <summary>
        ///     Display Brightness Increment Usage.
        /// </summary>
        [Description("Display Brightness Increment")]
        DisplayBrightnessIncrement = 0x000c006f,

        /// <summary>
        ///     Display Brightness Decrement Usage.
        /// </summary>
        [Description("Display Brightness Decrement")]
        DisplayBrightnessDecrement = 0x000c0070,

        /// <summary>
        ///     Display Brightness Usage.
        /// </summary>
        [Description("Display Brightness")]
        DisplayBrightness = 0x000c0071,

        /// <summary>
        ///     Display Backlight Toggle Usage.
        /// </summary>
        [Description("Display Backlight Toggle")]
        DisplayBacklightToggle = 0x000c0072,

        /// <summary>
        ///     Display Set Brightness to Minimum Usage.
        /// </summary>
        [Description("Display Set Brightness to Minimum")]
        DisplaySetBrightnessToMinimum = 0x000c0073,

        /// <summary>
        ///     Display Set Brightness to Maximum Usage.
        /// </summary>
        [Description("Display Set Brightness to Maximum")]
        DisplaySetBrightnessToMaximum = 0x000c0074,

        /// <summary>
        ///     Display Set Auto Brightness Usage.
        /// </summary>
        [Description("Display Set Auto Brightness")]
        DisplaySetAutoBrightness = 0x000c0075,

        /// <summary>
        ///     Camera Access Enabled Usage.
        /// </summary>
        [Description("Camera Access Enabled")]
        CameraAccessEnabled = 0x000c0076,

        /// <summary>
        ///     Camera Access Disabled Usage.
        /// </summary>
        [Description("Camera Access Disabled")]
        CameraAccessDisabled = 0x000c0077,

        /// <summary>
        ///     Camera Access Toggle Usage.
        /// </summary>
        [Description("Camera Access Toggle")]
        CameraAccessToggle = 0x000c0078,

        /// <summary>
        ///     Keyboard Brightness Increment Usage.
        /// </summary>
        [Description("Keyboard Brightness Increment")]
        KeyboardBrightnessIncrement = 0x000c0079,

        /// <summary>
        ///     Keyboard Brightness Decrement Usage.
        /// </summary>
        [Description("Keyboard Brightness Decrement")]
        KeyboardBrightnessDecrement = 0x000c007a,

        /// <summary>
        ///     Keyboard Backlight Set Level Usage.
        /// </summary>
        [Description("Keyboard Backlight Set Level")]
        KeyboardBacklightSetLevel = 0x000c007b,

        /// <summary>
        ///     Keyboard Backlight Toggle Usage.
        /// </summary>
        [Description("Keyboard Backlight Toggle")]
        KeyboardBacklightToggle = 0x000c007c,

        /// <summary>
        ///     Keyboard Backlight Set Minimum Usage.
        /// </summary>
        [Description("Keyboard Backlight Set Minimum")]
        KeyboardBacklightSetMinimum = 0x000c007d,

        /// <summary>
        ///     Keyboard Backlight Set Maximum Usage.
        /// </summary>
        [Description("Keyboard Backlight Set Maximum")]
        KeyboardBacklightSetMaximum = 0x000c007e,

        /// <summary>
        ///     Keyboard Backlight Auto Usage.
        /// </summary>
        [Description("Keyboard Backlight Auto")]
        KeyboardBacklightAuto = 0x000c007f,

        /// <summary>
        ///     Selection Usage.
        /// </summary>
        [Description("Selection")]
        Selection = 0x000c0080,

        /// <summary>
        ///     Assign Selection Usage.
        /// </summary>
        [Description("Assign Selection")]
        AssignSelection = 0x000c0081,

        /// <summary>
        ///     Mode Step Usage.
        /// </summary>
        [Description("Mode Step")]
        ModeStep = 0x000c0082,

        /// <summary>
        ///     Recall Last Usage.
        /// </summary>
        [Description("Recall Last")]
        RecallLast = 0x000c0083,

        /// <summary>
        ///     Enter Channel Usage.
        /// </summary>
        [Description("Enter Channel")]
        EnterChannel = 0x000c0084,

        /// <summary>
        ///     Order Movie Usage.
        /// </summary>
        [Description("Order Movie")]
        OrderMovie = 0x000c0085,

        /// <summary>
        ///     Channel Usage.
        /// </summary>
        [Description("Channel")]
        Channel = 0x000c0086,

        /// <summary>
        ///     Media Selection Usage.
        /// </summary>
        [Description("Media Selection")]
        MediaSelection = 0x000c0087,

        /// <summary>
        ///     Media Select  Usage.
        /// </summary>
        [Description("Media Select ")]
        MediaSelect = 0x000c0088,

        /// <summary>
        ///     Media Select TV Usage.
        /// </summary>
        [Description("Media Select TV")]
        MediaSelectTV = 0x000c0089,

        /// <summary>
        ///     Media Select WWW Usage.
        /// </summary>
        [Description("Media Select WWW")]
        MediaSelectWWW = 0x000c008a,

        /// <summary>
        ///     Media Select DVD Usage.
        /// </summary>
        [Description("Media Select DVD")]
        MediaSelectDVD = 0x000c008b,

        /// <summary>
        ///     Media Select Telephone Usage.
        /// </summary>
        [Description("Media Select Telephone")]
        MediaSelectTelephone = 0x000c008c,

        /// <summary>
        ///     Media Select Program Guide Usage.
        /// </summary>
        [Description("Media Select Program Guide")]
        MediaSelectProgramGuide = 0x000c008d,

        /// <summary>
        ///     Media Select Video Phone Usage.
        /// </summary>
        [Description("Media Select Video Phone")]
        MediaSelectVideoPhone = 0x000c008e,

        /// <summary>
        ///     Media Select Games Usage.
        /// </summary>
        [Description("Media Select Games")]
        MediaSelectGames = 0x000c008f,

        /// <summary>
        ///     Media Select Messages Usage.
        /// </summary>
        [Description("Media Select Messages")]
        MediaSelectMessages = 0x000c0090,

        /// <summary>
        ///     Media Select CD Usage.
        /// </summary>
        [Description("Media Select CD")]
        MediaSelectCD = 0x000c0091,

        /// <summary>
        ///     Media Select VCR Usage.
        /// </summary>
        [Description("Media Select VCR")]
        MediaSelectVCR = 0x000c0092,

        /// <summary>
        ///     Media Select Tuner Usage.
        /// </summary>
        [Description("Media Select Tuner")]
        MediaSelectTuner = 0x000c0093,

        /// <summary>
        ///     Quit Usage.
        /// </summary>
        [Description("Quit")]
        Quit = 0x000c0094,

        /// <summary>
        ///     Help Usage.
        /// </summary>
        [Description("Help")]
        Help = 0x000c0095,

        /// <summary>
        ///     Media Select Tape Usage.
        /// </summary>
        [Description("Media Select Tape")]
        MediaSelectTape = 0x000c0096,

        /// <summary>
        ///     Media Select Cable Usage.
        /// </summary>
        [Description("Media Select Cable")]
        MediaSelectCable = 0x000c0097,

        /// <summary>
        ///     Media Select Satellite Usage.
        /// </summary>
        [Description("Media Select Satellite")]
        MediaSelectSatellite = 0x000c0098,

        /// <summary>
        ///     Media Select Security Usage.
        /// </summary>
        [Description("Media Select Security")]
        MediaSelectSecurity = 0x000c0099,

        /// <summary>
        ///     Media Select Home Usage.
        /// </summary>
        [Description("Media Select Home")]
        MediaSelectHome = 0x000c009a,

        /// <summary>
        ///     Media Select Call Usage.
        /// </summary>
        [Description("Media Select Call")]
        MediaSelectCall = 0x000c009b,

        /// <summary>
        ///     Channel Increment Usage.
        /// </summary>
        [Description("Channel Increment")]
        ChannelIncrement = 0x000c009c,

        /// <summary>
        ///     Channel Decrement Usage.
        /// </summary>
        [Description("Channel Decrement")]
        ChannelDecrement = 0x000c009d,

        /// <summary>
        ///     Media Select SAP Usage.
        /// </summary>
        [Description("Media Select SAP")]
        MediaSelectSAP = 0x000c009e,

        /// <summary>
        ///     VCR Plus Usage.
        /// </summary>
        [Description("VCR Plus")]
        VCRPlus = 0x000c00a0,

        /// <summary>
        ///     Once Usage.
        /// </summary>
        [Description("Once")]
        Once = 0x000c00a1,

        /// <summary>
        ///     Daily Usage.
        /// </summary>
        [Description("Daily")]
        Daily = 0x000c00a2,

        /// <summary>
        ///     Weekly Usage.
        /// </summary>
        [Description("Weekly")]
        Weekly = 0x000c00a3,

        /// <summary>
        ///     Monthly Usage.
        /// </summary>
        [Description("Monthly")]
        Monthly = 0x000c00a4,

        /// <summary>
        ///     Play Usage.
        /// </summary>
        [Description("Play")]
        Play = 0x000c00b0,

        /// <summary>
        ///     Pause Usage.
        /// </summary>
        [Description("Pause")]
        Pause = 0x000c00b1,

        /// <summary>
        ///     Record Usage.
        /// </summary>
        [Description("Record")]
        Record = 0x000c00b2,

        /// <summary>
        ///     Fast Forward Usage.
        /// </summary>
        [Description("Fast Forward")]
        FastForward = 0x000c00b3,

        /// <summary>
        ///     Rewind Usage.
        /// </summary>
        [Description("Rewind")]
        Rewind = 0x000c00b4,

        /// <summary>
        ///     Scan Next Track Usage.
        /// </summary>
        [Description("Scan Next Track")]
        ScanNextTrack = 0x000c00b5,

        /// <summary>
        ///     Scan Previous Track Usage.
        /// </summary>
        [Description("Scan Previous Track")]
        ScanPreviousTrack = 0x000c00b6,

        /// <summary>
        ///     Stop Usage.
        /// </summary>
        [Description("Stop")]
        Stop = 0x000c00b7,

        /// <summary>
        ///     Eject Usage.
        /// </summary>
        [Description("Eject")]
        Eject = 0x000c00b8,

        /// <summary>
        ///     Random Play Usage.
        /// </summary>
        [Description("Random Play")]
        RandomPlay = 0x000c00b9,

        /// <summary>
        ///     Select Disk Usage.
        /// </summary>
        [Description("Select Disk")]
        SelectDisk = 0x000c00ba,

        /// <summary>
        ///     Enter Disk Usage.
        /// </summary>
        [Description("Enter Disk")]
        EnterDisk = 0x000c00bb,

        /// <summary>
        ///     Repeat Usage.
        /// </summary>
        [Description("Repeat")]
        Repeat = 0x000c00bc,

        /// <summary>
        ///     Tracking Usage.
        /// </summary>
        [Description("Tracking")]
        Tracking = 0x000c00bd,

        /// <summary>
        ///     Track Normal Usage.
        /// </summary>
        [Description("Track Normal")]
        TrackNormal = 0x000c00be,

        /// <summary>
        ///     Slow Tracking Usage.
        /// </summary>
        [Description("Slow Tracking")]
        SlowTracking = 0x000c00bf,

        /// <summary>
        ///     Frame Forward Usage.
        /// </summary>
        [Description("Frame Forward")]
        FrameForward = 0x000c00c0,

        /// <summary>
        ///     Frame Back Usage.
        /// </summary>
        [Description("Frame Back")]
        FrameBack = 0x000c00c1,

        /// <summary>
        ///     Mark Usage.
        /// </summary>
        [Description("Mark")]
        Mark = 0x000c00c2,

        /// <summary>
        ///     Clear Mark Usage.
        /// </summary>
        [Description("Clear Mark")]
        ClearMark = 0x000c00c3,

        /// <summary>
        ///     Repeat From Mark Usage.
        /// </summary>
        [Description("Repeat From Mark")]
        RepeatFromMark = 0x000c00c4,

        /// <summary>
        ///     Return To Mark Usage.
        /// </summary>
        [Description("Return To Mark")]
        ReturnToMark = 0x000c00c5,

        /// <summary>
        ///     Search Mark Forward Usage.
        /// </summary>
        [Description("Search Mark Forward")]
        SearchMarkForward = 0x000c00c6,

        /// <summary>
        ///     Search Mark Backwards Usage.
        /// </summary>
        [Description("Search Mark Backwards")]
        SearchMarkBackwards = 0x000c00c7,

        /// <summary>
        ///     Counter Reset Usage.
        /// </summary>
        [Description("Counter Reset")]
        CounterReset = 0x000c00c8,

        /// <summary>
        ///     Show Counter Usage.
        /// </summary>
        [Description("Show Counter")]
        ShowCounter = 0x000c00c9,

        /// <summary>
        ///     Tracking Increment Usage.
        /// </summary>
        [Description("Tracking Increment")]
        TrackingIncrement = 0x000c00ca,

        /// <summary>
        ///     Tracking Decrement Usage.
        /// </summary>
        [Description("Tracking Decrement")]
        TrackingDecrement = 0x000c00cb,

        /// <summary>
        ///     Stop/Eject Usage.
        /// </summary>
        [Description("Stop/Eject")]
        StopEject = 0x000c00cc,

        /// <summary>
        ///     Play/Pause Usage.
        /// </summary>
        [Description("Play/Pause")]
        PlayPause = 0x000c00cd,

        /// <summary>
        ///     Play/Skip Usage.
        /// </summary>
        [Description("Play/Skip")]
        PlaySkip = 0x000c00ce,

        /// <summary>
        ///     Voice Command Usage.
        /// </summary>
        [Description("Voice Command")]
        VoiceCommand = 0x000c00cf,

        /// <summary>
        ///     Invoke Capture Interface Usage.
        /// </summary>
        [Description("Invoke Capture Interface")]
        InvokeCaptureInterface = 0x000c00d0,

        /// <summary>
        ///     Start/Stop Game Recording Usage.
        /// </summary>
        [Description("Start/Stop Game Recording")]
        StartStopGameRecording = 0x000c00d1,

        /// <summary>
        ///     Historical Game Capture Usage.
        /// </summary>
        [Description("Historical Game Capture")]
        HistoricalGameCapture = 0x000c00d2,

        /// <summary>
        ///     Capture Game Screenshot Usage.
        /// </summary>
        [Description("Capture Game Screenshot")]
        CaptureGameScreenshot = 0x000c00d3,

        /// <summary>
        ///     Show/Hide Recording Indicator Usage.
        /// </summary>
        [Description("Show/Hide Recording Indicator")]
        ShowHideRecordingIndicator = 0x000c00d4,

        /// <summary>
        ///     Start/Stop Microphone Capture Usage.
        /// </summary>
        [Description("Start/Stop Microphone Capture")]
        StartStopMicrophoneCapture = 0x000c00d5,

        /// <summary>
        ///     Start or Stop Camera Capture Usage.
        /// </summary>
        [Description("Start or Stop Camera Capture")]
        StartOrStopCameraCapture = 0x000c00d6,

        /// <summary>
        ///     Start/Stop Game Broadcast Usage.
        /// </summary>
        [Description("Start/Stop Game Broadcast")]
        StartStopGameBroadcast = 0x000c00d7,

        /// <summary>
        ///     Volume Usage.
        /// </summary>
        [Description("Volume")]
        Volume = 0x000c00e0,

        /// <summary>
        ///     Balance Usage.
        /// </summary>
        [Description("Balance")]
        Balance = 0x000c00e1,

        /// <summary>
        ///     Mute Usage.
        /// </summary>
        [Description("Mute")]
        Mute = 0x000c00e2,

        /// <summary>
        ///     Bass Usage.
        /// </summary>
        [Description("Bass")]
        Bass = 0x000c00e3,

        /// <summary>
        ///     Treble Usage.
        /// </summary>
        [Description("Treble")]
        Treble = 0x000c00e4,

        /// <summary>
        ///     Bass Boost Usage.
        /// </summary>
        [Description("Bass Boost")]
        BassBoost = 0x000c00e5,

        /// <summary>
        ///     Surround Mode Usage.
        /// </summary>
        [Description("Surround Mode")]
        SurroundMode = 0x000c00e6,

        /// <summary>
        ///     Loudness Usage.
        /// </summary>
        [Description("Loudness")]
        Loudness = 0x000c00e7,

        /// <summary>
        ///     MPX Usage.
        /// </summary>
        [Description("MPX")]
        MPX = 0x000c00e8,

        /// <summary>
        ///     Volume Increment Usage.
        /// </summary>
        [Description("Volume Increment")]
        VolumeIncrement = 0x000c00e9,

        /// <summary>
        ///     Volume Decrement Usage.
        /// </summary>
        [Description("Volume Decrement")]
        VolumeDecrement = 0x000c00ea,

        /// <summary>
        ///     Speed Select Usage.
        /// </summary>
        [Description("Speed Select")]
        SpeedSelect = 0x000c00f0,

        /// <summary>
        ///     Playback Speed Usage.
        /// </summary>
        [Description("Playback Speed")]
        PlaybackSpeed = 0x000c00f1,

        /// <summary>
        ///     Standard Play Usage.
        /// </summary>
        [Description("Standard Play")]
        StandardPlay = 0x000c00f2,

        /// <summary>
        ///     Long Play Usage.
        /// </summary>
        [Description("Long Play")]
        LongPlay = 0x000c00f3,

        /// <summary>
        ///     Extended Play Usage.
        /// </summary>
        [Description("Extended Play")]
        ExtendedPlay = 0x000c00f4,

        /// <summary>
        ///     Slow Usage.
        /// </summary>
        [Description("Slow")]
        Slow = 0x000c00f5,

        /// <summary>
        ///     Fan Enable Usage.
        /// </summary>
        [Description("Fan Enable")]
        FanEnable = 0x000c0100,

        /// <summary>
        ///     Fan Speed Usage.
        /// </summary>
        [Description("Fan Speed")]
        FanSpeed = 0x000c0101,

        /// <summary>
        ///     Light Enable Usage.
        /// </summary>
        [Description("Light Enable")]
        LightEnable = 0x000c0102,

        /// <summary>
        ///     Light Illumination Level Usage.
        /// </summary>
        [Description("Light Illumination Level")]
        LightIlluminationLevel = 0x000c0103,

        /// <summary>
        ///     Climate Control Enable Usage.
        /// </summary>
        [Description("Climate Control Enable")]
        ClimateControlEnable = 0x000c0104,

        /// <summary>
        ///     Room Temperature Usage.
        /// </summary>
        [Description("Room Temperature")]
        RoomTemperature = 0x000c0105,

        /// <summary>
        ///     Security Enable Usage.
        /// </summary>
        [Description("Security Enable")]
        SecurityEnable = 0x000c0106,

        /// <summary>
        ///     Fire Alarm Usage.
        /// </summary>
        [Description("Fire Alarm")]
        FireAlarm = 0x000c0107,

        /// <summary>
        ///     Police Alarm Usage.
        /// </summary>
        [Description("Police Alarm")]
        PoliceAlarm = 0x000c0108,

        /// <summary>
        ///     Proximity Usage.
        /// </summary>
        [Description("Proximity")]
        Proximity = 0x000c0109,

        /// <summary>
        ///     Motion Usage.
        /// </summary>
        [Description("Motion")]
        Motion = 0x000c010a,

        /// <summary>
        ///     Duress Alarm Usage.
        /// </summary>
        [Description("Duress Alarm")]
        DuressAlarm = 0x000c010b,

        /// <summary>
        ///     Holdup Alarm Usage.
        /// </summary>
        [Description("Holdup Alarm")]
        HoldupAlarm = 0x000c010c,

        /// <summary>
        ///     Medical Alarm Usage.
        /// </summary>
        [Description("Medical Alarm")]
        MedicalAlarm = 0x000c010d,

        /// <summary>
        ///     Balance Right Usage.
        /// </summary>
        [Description("Balance Right")]
        BalanceRight = 0x000c0150,

        /// <summary>
        ///     Balance Left Usage.
        /// </summary>
        [Description("Balance Left")]
        BalanceLeft = 0x000c0151,

        /// <summary>
        ///     Bass Increment Usage.
        /// </summary>
        [Description("Bass Increment")]
        BassIncrement = 0x000c0152,

        /// <summary>
        ///     Bass Decrement Usage.
        /// </summary>
        [Description("Bass Decrement")]
        BassDecrement = 0x000c0153,

        /// <summary>
        ///     Treble Increment Usage.
        /// </summary>
        [Description("Treble Increment")]
        TrebleIncrement = 0x000c0154,

        /// <summary>
        ///     Treble Decrement Usage.
        /// </summary>
        [Description("Treble Decrement")]
        TrebleDecrement = 0x000c0155,

        /// <summary>
        ///     Speaker System Usage.
        /// </summary>
        [Description("Speaker System")]
        SpeakerSystem = 0x000c0160,

        /// <summary>
        ///     Channel Left Usage.
        /// </summary>
        [Description("Channel Left")]
        ChannelLeft = 0x000c0161,

        /// <summary>
        ///     Channel Right Usage.
        /// </summary>
        [Description("Channel Right")]
        ChannelRight = 0x000c0162,

        /// <summary>
        ///     Channel Center Usage.
        /// </summary>
        [Description("Channel Center")]
        ChannelCenter = 0x000c0163,

        /// <summary>
        ///     Channel Front Usage.
        /// </summary>
        [Description("Channel Front")]
        ChannelFront = 0x000c0164,

        /// <summary>
        ///     Channel Center Front Usage.
        /// </summary>
        [Description("Channel Center Front")]
        ChannelCenterFront = 0x000c0165,

        /// <summary>
        ///     Channel Side Usage.
        /// </summary>
        [Description("Channel Side")]
        ChannelSide = 0x000c0166,

        /// <summary>
        ///     Channel Surround Usage.
        /// </summary>
        [Description("Channel Surround")]
        ChannelSurround = 0x000c0167,

        /// <summary>
        ///     Channel Low Frequency Enhancement Usage.
        /// </summary>
        [Description("Channel Low Frequency Enhancement")]
        ChannelLowFrequencyEnhancement = 0x000c0168,

        /// <summary>
        ///     Channel Top Usage.
        /// </summary>
        [Description("Channel Top")]
        ChannelTop = 0x000c0169,

        /// <summary>
        ///     Channel Unknown Usage.
        /// </summary>
        [Description("Channel Unknown")]
        ChannelUnknown = 0x000c016a,

        /// <summary>
        ///     Sub-channel Usage.
        /// </summary>
        [Description("Sub-channel")]
        Subchannel = 0x000c0170,

        /// <summary>
        ///     Sub-channel Increment Usage.
        /// </summary>
        [Description("Sub-channel Increment")]
        SubchannelIncrement = 0x000c0171,

        /// <summary>
        ///     Sub-channel Decrement Usage.
        /// </summary>
        [Description("Sub-channel Decrement")]
        SubchannelDecrement = 0x000c0172,

        /// <summary>
        ///     Alternate Audio Increment Usage.
        /// </summary>
        [Description("Alternate Audio Increment")]
        AlternateAudioIncrement = 0x000c0173,

        /// <summary>
        ///     Alternate Audio Decrement Usage.
        /// </summary>
        [Description("Alternate Audio Decrement")]
        AlternateAudioDecrement = 0x000c0174,

        /// <summary>
        ///     Application Launch Buttons Usage.
        /// </summary>
        [Description("Application Launch Buttons")]
        ApplicationLaunchButtons = 0x000c0180,

        /// <summary>
        ///     AL Launch Button Configuration Tool Usage.
        /// </summary>
        [Description("AL Launch Button Configuration Tool")]
        ALLaunchButtonConfigurationTool = 0x000c0181,

        /// <summary>
        ///     AL Programmable Button Configuration Usage.
        /// </summary>
        [Description("AL Programmable Button Configuration")]
        ALProgrammableButtonConfiguration = 0x000c0182,

        /// <summary>
        ///     AL Consumer Control Configuration Usage.
        /// </summary>
        [Description("AL Consumer Control Configuration")]
        ALConsumerControlConfiguration = 0x000c0183,

        /// <summary>
        ///     AL Word Processor Usage.
        /// </summary>
        [Description("AL Word Processor")]
        ALWordProcessor = 0x000c0184,

        /// <summary>
        ///     AL Text Editor Usage.
        /// </summary>
        [Description("AL Text Editor")]
        ALTextEditor = 0x000c0185,

        /// <summary>
        ///     AL Spreadsheet Usage.
        /// </summary>
        [Description("AL Spreadsheet")]
        ALSpreadsheet = 0x000c0186,

        /// <summary>
        ///     AL Graphics Editor Usage.
        /// </summary>
        [Description("AL Graphics Editor")]
        ALGraphicsEditor = 0x000c0187,

        /// <summary>
        ///     AL Presentation App Usage.
        /// </summary>
        [Description("AL Presentation App")]
        ALPresentationApp = 0x000c0188,

        /// <summary>
        ///     AL Database App Usage.
        /// </summary>
        [Description("AL Database App")]
        ALDatabaseApp = 0x000c0189,

        /// <summary>
        ///     AL Email Reader Usage.
        /// </summary>
        [Description("AL Email Reader")]
        ALEmailReader = 0x000c018a,

        /// <summary>
        ///     AL Newsreader Usage.
        /// </summary>
        [Description("AL Newsreader")]
        ALNewsreader = 0x000c018b,

        /// <summary>
        ///     AL Voicemail Usage.
        /// </summary>
        [Description("AL Voicemail")]
        ALVoicemail = 0x000c018c,

        /// <summary>
        ///     AL Contacts/Address Book Usage.
        /// </summary>
        [Description("AL Contacts/Address Book")]
        ALContactsAddressBook = 0x000c018d,

        /// <summary>
        ///     AL Calendar/Schedule Usage.
        /// </summary>
        [Description("AL Calendar/Schedule")]
        ALCalendarSchedule = 0x000c018e,

        /// <summary>
        ///     AL Task/Project Manager Usage.
        /// </summary>
        [Description("AL Task/Project Manager")]
        ALTaskProjectManager = 0x000c018f,

        /// <summary>
        ///     AL Log/Journal/Timecard Usage.
        /// </summary>
        [Description("AL Log/Journal/Timecard")]
        ALLogJournalTimecard = 0x000c0190,

        /// <summary>
        ///     AL Checkbook/Finance Usage.
        /// </summary>
        [Description("AL Checkbook/Finance")]
        ALCheckbookFinance = 0x000c0191,

        /// <summary>
        ///     AL Calculator Usage.
        /// </summary>
        [Description("AL Calculator")]
        ALCalculator = 0x000c0192,

        /// <summary>
        ///     AL A/V Capture/Playback Usage.
        /// </summary>
        [Description("AL A/V Capture/Playback")]
        ALAVCapturePlayback = 0x000c0193,

        /// <summary>
        ///     AL Local Machine Browser Usage.
        /// </summary>
        [Description("AL Local Machine Browser")]
        ALLocalMachineBrowser = 0x000c0194,

        /// <summary>
        ///     AL LAN/WAN Browser Usage.
        /// </summary>
        [Description("AL LAN/WAN Browser")]
        ALLANWANBrowser = 0x000c0195,

        /// <summary>
        ///     AL Internet Browser Usage.
        /// </summary>
        [Description("AL Internet Browser")]
        ALInternetBrowser = 0x000c0196,

        /// <summary>
        ///     AL Remote Networking/ISP Connect Usage.
        /// </summary>
        [Description("AL Remote Networking/ISP Connect")]
        ALRemoteNetworkingISPConnect = 0x000c0197,

        /// <summary>
        ///     AL Network Conference Usage.
        /// </summary>
        [Description("AL Network Conference")]
        ALNetworkConference = 0x000c0198,

        /// <summary>
        ///     AL Network Chat Usage.
        /// </summary>
        [Description("AL Network Chat")]
        ALNetworkChat = 0x000c0199,

        /// <summary>
        ///     AL Telephony/Dialer Usage.
        /// </summary>
        [Description("AL Telephony/Dialer")]
        ALTelephonyDialer = 0x000c019a,

        /// <summary>
        ///     AL Logon Usage.
        /// </summary>
        [Description("AL Logon")]
        ALLogon = 0x000c019b,

        /// <summary>
        ///     AL Logoff Usage.
        /// </summary>
        [Description("AL Logoff")]
        ALLogoff = 0x000c019c,

        /// <summary>
        ///     AL Logon/Logoff Usage.
        /// </summary>
        [Description("AL Logon/Logoff")]
        ALLogonLogoff = 0x000c019d,

        /// <summary>
        ///     AL Terminal Lock/Screensaver Usage.
        /// </summary>
        [Description("AL Terminal Lock/Screensaver")]
        ALTerminalLockScreensaver = 0x000c019e,

        /// <summary>
        ///     AL Control Panel Usage.
        /// </summary>
        [Description("AL Control Panel")]
        ALControlPanel = 0x000c019f,

        /// <summary>
        ///     AL Command Line Processor/Run Usage.
        /// </summary>
        [Description("AL Command Line Processor/Run")]
        ALCommandLineProcessorRun = 0x000c01a0,

        /// <summary>
        ///     AL Process/Task Manager Usage.
        /// </summary>
        [Description("AL Process/Task Manager")]
        ALProcessTaskManager = 0x000c01a1,

        /// <summary>
        ///     AL Select Task/Application Usage.
        /// </summary>
        [Description("AL Select Task/Application")]
        ALSelectTaskApplication = 0x000c01a2,

        /// <summary>
        ///     AL Next Task/Application Usage.
        /// </summary>
        [Description("AL Next Task/Application")]
        ALNextTaskApplication = 0x000c01a3,

        /// <summary>
        ///     AL Previous Task/Application Usage.
        /// </summary>
        [Description("AL Previous Task/Application")]
        ALPreviousTaskApplication = 0x000c01a4,

        /// <summary>
        ///     AL Preemptive Halt Task/Application Usage.
        /// </summary>
        [Description("AL Preemptive Halt Task/Application")]
        ALPreemptiveHaltTaskApplication = 0x000c01a5,

        /// <summary>
        ///     AL Integrated Help Center Usage.
        /// </summary>
        [Description("AL Integrated Help Center")]
        ALIntegratedHelpCenter = 0x000c01a6,

        /// <summary>
        ///     AL Documents Usage.
        /// </summary>
        [Description("AL Documents")]
        ALDocuments = 0x000c01a7,

        /// <summary>
        ///     AL Thesaurus Usage.
        /// </summary>
        [Description("AL Thesaurus")]
        ALThesaurus = 0x000c01a8,

        /// <summary>
        ///     AL Dictionary Usage.
        /// </summary>
        [Description("AL Dictionary")]
        ALDictionary = 0x000c01a9,

        /// <summary>
        ///     AL Desktop Usage.
        /// </summary>
        [Description("AL Desktop")]
        ALDesktop = 0x000c01aa,

        /// <summary>
        ///     AL Spell Check Usage.
        /// </summary>
        [Description("AL Spell Check")]
        ALSpellCheck = 0x000c01ab,

        /// <summary>
        ///     AL Grammar Check Usage.
        /// </summary>
        [Description("AL Grammar Check")]
        ALGrammarCheck = 0x000c01ac,

        /// <summary>
        ///     AL Wireless Status Usage.
        /// </summary>
        [Description("AL Wireless Status")]
        ALWirelessStatus = 0x000c01ad,

        /// <summary>
        ///     AL Keyboard Layout Usage.
        /// </summary>
        [Description("AL Keyboard Layout")]
        ALKeyboardLayout = 0x000c01ae,

        /// <summary>
        ///     AL Virus Protection Usage.
        /// </summary>
        [Description("AL Virus Protection")]
        ALVirusProtection = 0x000c01af,

        /// <summary>
        ///     AL Encryption Usage.
        /// </summary>
        [Description("AL Encryption")]
        ALEncryption = 0x000c01b0,

        /// <summary>
        ///     AL Screen Saver Usage.
        /// </summary>
        [Description("AL Screen Saver")]
        ALScreenSaver = 0x000c01b1,

        /// <summary>
        ///     AL Alarms Usage.
        /// </summary>
        [Description("AL Alarms")]
        ALAlarms = 0x000c01b2,

        /// <summary>
        ///     AL Clock Usage.
        /// </summary>
        [Description("AL Clock")]
        ALClock = 0x000c01b3,

        /// <summary>
        ///     AL File Browser Usage.
        /// </summary>
        [Description("AL File Browser")]
        ALFileBrowser = 0x000c01b4,

        /// <summary>
        ///     AL Power Status Usage.
        /// </summary>
        [Description("AL Power Status")]
        ALPowerStatus = 0x000c01b5,

        /// <summary>
        ///     AL Image Browser Usage.
        /// </summary>
        [Description("AL Image Browser")]
        ALImageBrowser = 0x000c01b6,

        /// <summary>
        ///     AL Audio Browser Usage.
        /// </summary>
        [Description("AL Audio Browser")]
        ALAudioBrowser = 0x000c01b7,

        /// <summary>
        ///     AL Movie Browser Usage.
        /// </summary>
        [Description("AL Movie Browser")]
        ALMovieBrowser = 0x000c01b8,

        /// <summary>
        ///     AL Digital Rights Manager Usage.
        /// </summary>
        [Description("AL Digital Rights Manager")]
        ALDigitalRightsManager = 0x000c01b9,

        /// <summary>
        ///     AL Digital Wallet Usage.
        /// </summary>
        [Description("AL Digital Wallet")]
        ALDigitalWallet = 0x000c01ba,

        /// <summary>
        ///     AL Instant Messaging Usage.
        /// </summary>
        [Description("AL Instant Messaging")]
        ALInstantMessaging = 0x000c01bc,

        /// <summary>
        ///     AL OEM Features/Tips/Tutorial Browser Usage.
        /// </summary>
        [Description("AL OEM Features/Tips/Tutorial Browser")]
        ALOEMFeaturesTipsTutorialBrowser = 0x000c01bd,

        /// <summary>
        ///     AL OEM Help Usage.
        /// </summary>
        [Description("AL OEM Help")]
        ALOEMHelp = 0x000c01be,

        /// <summary>
        ///     AL Online Community Usage.
        /// </summary>
        [Description("AL Online Community")]
        ALOnlineCommunity = 0x000c01bf,

        /// <summary>
        ///     AL Entertainment Content Browser Usage.
        /// </summary>
        [Description("AL Entertainment Content Browser")]
        ALEntertainmentContentBrowser = 0x000c01c0,

        /// <summary>
        ///     AL Online Shopping Browser Usage.
        /// </summary>
        [Description("AL Online Shopping Browser")]
        ALOnlineShoppingBrowser = 0x000c01c1,

        /// <summary>
        ///     AL SmartCard Information/Help Usage.
        /// </summary>
        [Description("AL SmartCard Information/Help")]
        ALSmartCardInformationHelp = 0x000c01c2,

        /// <summary>
        ///     AL Market Monitor/Finance Browser Usage.
        /// </summary>
        [Description("AL Market Monitor/Finance Browser")]
        ALMarketMonitorFinanceBrowser = 0x000c01c3,

        /// <summary>
        ///     AL Customized Corporate News Browser Usage.
        /// </summary>
        [Description("AL Customized Corporate News Browser")]
        ALCustomizedCorporateNewsBrowser = 0x000c01c4,

        /// <summary>
        ///     AL Online Activity Browser Usage.
        /// </summary>
        [Description("AL Online Activity Browser")]
        ALOnlineActivityBrowser = 0x000c01c5,

        /// <summary>
        ///     AL Research/Search Browser Usage.
        /// </summary>
        [Description("AL Research/Search Browser")]
        ALResearchSearchBrowser = 0x000c01c6,

        /// <summary>
        ///     AL Audio Player Usage.
        /// </summary>
        [Description("AL Audio Player")]
        ALAudioPlayer = 0x000c01c7,

        /// <summary>
        ///     AL Navigation Usage.
        /// </summary>
        [Description("AL Navigation")]
        ALNavigation = 0x000c01c8,

        /// <summary>
        ///     AL Context-aware desktop assistant Usage.
        /// </summary>
        [Description("AL Context-aware desktop assistant")]
        ALContextawareDesktopAssistant = 0x000c01cb,

        /// <summary>
        ///     Generic GUI Application Controls Usage.
        /// </summary>
        [Description("Generic GUI Application Controls")]
        GenericGUIApplicationControls = 0x000c0200,

        /// <summary>
        ///     AC New Usage.
        /// </summary>
        [Description("AC New")]
        ACNew = 0x000c0201,

        /// <summary>
        ///     AC Open Usage.
        /// </summary>
        [Description("AC Open")]
        ACOpen = 0x000c0202,

        /// <summary>
        ///     AC Close Usage.
        /// </summary>
        [Description("AC Close")]
        ACClose = 0x000c0203,

        /// <summary>
        ///     AC Exit Usage.
        /// </summary>
        [Description("AC Exit")]
        ACExit = 0x000c0204,

        /// <summary>
        ///     AC Maximize Usage.
        /// </summary>
        [Description("AC Maximize")]
        ACMaximize = 0x000c0205,

        /// <summary>
        ///     AC Minimize Usage.
        /// </summary>
        [Description("AC Minimize")]
        ACMinimize = 0x000c0206,

        /// <summary>
        ///     AC Save Usage.
        /// </summary>
        [Description("AC Save")]
        ACSave = 0x000c0207,

        /// <summary>
        ///     AC Print Usage.
        /// </summary>
        [Description("AC Print")]
        ACPrint = 0x000c0208,

        /// <summary>
        ///     AC Properties Usage.
        /// </summary>
        [Description("AC Properties")]
        ACProperties = 0x000c0209,

        /// <summary>
        ///     AC Undo Usage.
        /// </summary>
        [Description("AC Undo")]
        ACUndo = 0x000c021a,

        /// <summary>
        ///     AC Copy Usage.
        /// </summary>
        [Description("AC Copy")]
        ACCopy = 0x000c021b,

        /// <summary>
        ///     AC Cut Usage.
        /// </summary>
        [Description("AC Cut")]
        ACCut = 0x000c021c,

        /// <summary>
        ///     AC Paste Usage.
        /// </summary>
        [Description("AC Paste")]
        ACPaste = 0x000c021d,

        /// <summary>
        ///     AC Select All Usage.
        /// </summary>
        [Description("AC Select All")]
        ACSelectAll = 0x000c021e,

        /// <summary>
        ///     AC Find Usage.
        /// </summary>
        [Description("AC Find")]
        ACFind = 0x000c021f,

        /// <summary>
        ///     AC Find and Replace Usage.
        /// </summary>
        [Description("AC Find and Replace")]
        ACFindAndReplace = 0x000c0220,

        /// <summary>
        ///     AC Search Usage.
        /// </summary>
        [Description("AC Search")]
        ACSearch = 0x000c0221,

        /// <summary>
        ///     AC Go To Usage.
        /// </summary>
        [Description("AC Go To")]
        ACGoTo = 0x000c0222,

        /// <summary>
        ///     AC Home Usage.
        /// </summary>
        [Description("AC Home")]
        ACHome = 0x000c0223,

        /// <summary>
        ///     AC Back Usage.
        /// </summary>
        [Description("AC Back")]
        ACBack = 0x000c0224,

        /// <summary>
        ///     AC Forward Usage.
        /// </summary>
        [Description("AC Forward")]
        ACForward = 0x000c0225,

        /// <summary>
        ///     AC Stop Usage.
        /// </summary>
        [Description("AC Stop")]
        ACStop = 0x000c0226,

        /// <summary>
        ///     AC Refresh Usage.
        /// </summary>
        [Description("AC Refresh")]
        ACRefresh = 0x000c0227,

        /// <summary>
        ///     AC Previous Link Usage.
        /// </summary>
        [Description("AC Previous Link")]
        ACPreviousLink = 0x000c0228,

        /// <summary>
        ///     AC Next Link Usage.
        /// </summary>
        [Description("AC Next Link")]
        ACNextLink = 0x000c0229,

        /// <summary>
        ///     AC Bookmarks Usage.
        /// </summary>
        [Description("AC Bookmarks")]
        ACBookmarks = 0x000c022a,

        /// <summary>
        ///     AC History Usage.
        /// </summary>
        [Description("AC History")]
        ACHistory = 0x000c022b,

        /// <summary>
        ///     AC Subscriptions Usage.
        /// </summary>
        [Description("AC Subscriptions")]
        ACSubscriptions = 0x000c022c,

        /// <summary>
        ///     AC Zoom In Usage.
        /// </summary>
        [Description("AC Zoom In")]
        ACZoomIn = 0x000c022d,

        /// <summary>
        ///     AC Zoom Out Usage.
        /// </summary>
        [Description("AC Zoom Out")]
        ACZoomOut = 0x000c022e,

        /// <summary>
        ///     AC Zoom Usage.
        /// </summary>
        [Description("AC Zoom")]
        ACZoom = 0x000c022f,

        /// <summary>
        ///     AC Full Screen View Usage.
        /// </summary>
        [Description("AC Full Screen View")]
        ACFullScreenView = 0x000c0230,

        /// <summary>
        ///     AC Normal View Usage.
        /// </summary>
        [Description("AC Normal View")]
        ACNormalView = 0x000c0231,

        /// <summary>
        ///     AC View Toggle Usage.
        /// </summary>
        [Description("AC View Toggle")]
        ACViewToggle = 0x000c0232,

        /// <summary>
        ///     AC Scroll Up Usage.
        /// </summary>
        [Description("AC Scroll Up")]
        ACScrollUp = 0x000c0233,

        /// <summary>
        ///     AC Scroll Down Usage.
        /// </summary>
        [Description("AC Scroll Down")]
        ACScrollDown = 0x000c0234,

        /// <summary>
        ///     AC Scroll Usage.
        /// </summary>
        [Description("AC Scroll")]
        ACScroll = 0x000c0235,

        /// <summary>
        ///     AC Pan Left Usage.
        /// </summary>
        [Description("AC Pan Left")]
        ACPanLeft = 0x000c0236,

        /// <summary>
        ///     AC Pan Right Usage.
        /// </summary>
        [Description("AC Pan Right")]
        ACPanRight = 0x000c0237,

        /// <summary>
        ///     AC Pan Usage.
        /// </summary>
        [Description("AC Pan")]
        ACPan = 0x000c0238,

        /// <summary>
        ///     AC New Window Usage.
        /// </summary>
        [Description("AC New Window")]
        ACNewWindow = 0x000c0239,

        /// <summary>
        ///     AC Tile Horizontally Usage.
        /// </summary>
        [Description("AC Tile Horizontally")]
        ACTileHorizontally = 0x000c023a,

        /// <summary>
        ///     AC Tile Vertically Usage.
        /// </summary>
        [Description("AC Tile Vertically")]
        ACTileVertically = 0x000c023b,

        /// <summary>
        ///     AC Format Usage.
        /// </summary>
        [Description("AC Format")]
        ACFormat = 0x000c023c,

        /// <summary>
        ///     AC Edit Usage.
        /// </summary>
        [Description("AC Edit")]
        ACEdit = 0x000c023d,

        /// <summary>
        ///     AC Bold Usage.
        /// </summary>
        [Description("AC Bold")]
        ACBold = 0x000c023e,

        /// <summary>
        ///     AC Italics Usage.
        /// </summary>
        [Description("AC Italics")]
        ACItalics = 0x000c023f,

        /// <summary>
        ///     AC Underline Usage.
        /// </summary>
        [Description("AC Underline")]
        ACUnderline = 0x000c0240,

        /// <summary>
        ///     AC Strikethrough Usage.
        /// </summary>
        [Description("AC Strikethrough")]
        ACStrikethrough = 0x000c0241,

        /// <summary>
        ///     AC Subscript Usage.
        /// </summary>
        [Description("AC Subscript")]
        ACSubscript = 0x000c0242,

        /// <summary>
        ///     AC Superscript Usage.
        /// </summary>
        [Description("AC Superscript")]
        ACSuperscript = 0x000c0243,

        /// <summary>
        ///     AC All Caps Usage.
        /// </summary>
        [Description("AC All Caps")]
        ACAllCaps = 0x000c0244,

        /// <summary>
        ///     AC Rotate Usage.
        /// </summary>
        [Description("AC Rotate")]
        ACRotate = 0x000c0245,

        /// <summary>
        ///     AC Resize Usage.
        /// </summary>
        [Description("AC Resize")]
        ACResize = 0x000c0246,

        /// <summary>
        ///     AC Flip Horizontal Usage.
        /// </summary>
        [Description("AC Flip Horizontal")]
        ACFlipHorizontal = 0x000c0247,

        /// <summary>
        ///     AC Vertical Usage.
        /// </summary>
        [Description("AC Vertical")]
        ACVertical = 0x000c0248,

        /// <summary>
        ///     AC Mirror Horizontal Usage.
        /// </summary>
        [Description("AC Mirror Horizontal")]
        ACMirrorHorizontal = 0x000c0249,

        /// <summary>
        ///     AC Mirror Vertical Usage.
        /// </summary>
        [Description("AC Mirror Vertical")]
        ACMirrorVertical = 0x000c024a,

        /// <summary>
        ///     AC Font Select Usage.
        /// </summary>
        [Description("AC Font Select")]
        ACFontSelect = 0x000c024b,

        /// <summary>
        ///     AC Font Color Usage.
        /// </summary>
        [Description("AC Font Color")]
        ACFontColor = 0x000c024c,

        /// <summary>
        ///     AC Font Size Usage.
        /// </summary>
        [Description("AC Font Size")]
        ACFontSize = 0x000c024d,

        /// <summary>
        ///     AC Justify Left Usage.
        /// </summary>
        [Description("AC Justify Left")]
        ACJustifyLeft = 0x000c024e,

        /// <summary>
        ///     AC Justify Center H Usage.
        /// </summary>
        [Description("AC Justify Center H")]
        ACJustifyCenterH = 0x000c024f,

        /// <summary>
        ///     AC Justify Right Usage.
        /// </summary>
        [Description("AC Justify Right")]
        ACJustifyRight = 0x000c0250,

        /// <summary>
        ///     AC Justify Block H Usage.
        /// </summary>
        [Description("AC Justify Block H")]
        ACJustifyBlockH = 0x000c0251,

        /// <summary>
        ///     AC Justify Top Usage.
        /// </summary>
        [Description("AC Justify Top")]
        ACJustifyTop = 0x000c0252,

        /// <summary>
        ///     AC Justify Center V Usage.
        /// </summary>
        [Description("AC Justify Center V")]
        ACJustifyCenterV = 0x000c0253,

        /// <summary>
        ///     AC Justify Bottom Usage.
        /// </summary>
        [Description("AC Justify Bottom")]
        ACJustifyBottom = 0x000c0254,

        /// <summary>
        ///     AC Justify Block V Usage.
        /// </summary>
        [Description("AC Justify Block V")]
        ACJustifyBlockV = 0x000c0255,

        /// <summary>
        ///     AC Indent Decrease Usage.
        /// </summary>
        [Description("AC Indent Decrease")]
        ACIndentDecrease = 0x000c0256,

        /// <summary>
        ///     AC Indent Increase Usage.
        /// </summary>
        [Description("AC Indent Increase")]
        ACIndentIncrease = 0x000c0257,

        /// <summary>
        ///     AC Numbered List Usage.
        /// </summary>
        [Description("AC Numbered List")]
        ACNumberedList = 0x000c0258,

        /// <summary>
        ///     AC Restart Numbering Usage.
        /// </summary>
        [Description("AC Restart Numbering")]
        ACRestartNumbering = 0x000c0259,

        /// <summary>
        ///     AC Bulleted List Usage.
        /// </summary>
        [Description("AC Bulleted List")]
        ACBulletedList = 0x000c025a,

        /// <summary>
        ///     AC Promote Usage.
        /// </summary>
        [Description("AC Promote")]
        ACPromote = 0x000c025b,

        /// <summary>
        ///     AC Demote Usage.
        /// </summary>
        [Description("AC Demote")]
        ACDemote = 0x000c025c,

        /// <summary>
        ///     AC Yes Usage.
        /// </summary>
        [Description("AC Yes")]
        ACYes = 0x000c025d,

        /// <summary>
        ///     AC No Usage.
        /// </summary>
        [Description("AC No")]
        ACNo = 0x000c025e,

        /// <summary>
        ///     AC Cancel Usage.
        /// </summary>
        [Description("AC Cancel")]
        ACCancel = 0x000c025f,

        /// <summary>
        ///     AC Catalog Usage.
        /// </summary>
        [Description("AC Catalog")]
        ACCatalog = 0x000c0260,

        /// <summary>
        ///     AC Buy/Checkout Usage.
        /// </summary>
        [Description("AC Buy/Checkout")]
        ACBuyCheckout = 0x000c0261,

        /// <summary>
        ///     AC Add to Cart Usage.
        /// </summary>
        [Description("AC Add to Cart")]
        ACAddToCart = 0x000c0262,

        /// <summary>
        ///     AC Expand Usage.
        /// </summary>
        [Description("AC Expand")]
        ACExpand = 0x000c0263,

        /// <summary>
        ///     AC Expand All Usage.
        /// </summary>
        [Description("AC Expand All")]
        ACExpandAll = 0x000c0264,

        /// <summary>
        ///     AC Collapse Usage.
        /// </summary>
        [Description("AC Collapse")]
        ACCollapse = 0x000c0265,

        /// <summary>
        ///     AC Collapse All Usage.
        /// </summary>
        [Description("AC Collapse All")]
        ACCollapseAll = 0x000c0266,

        /// <summary>
        ///     AC Print Preview Usage.
        /// </summary>
        [Description("AC Print Preview")]
        ACPrintPreview = 0x000c0267,

        /// <summary>
        ///     AC Paste Special Usage.
        /// </summary>
        [Description("AC Paste Special")]
        ACPasteSpecial = 0x000c0268,

        /// <summary>
        ///     AC Insert Mode Usage.
        /// </summary>
        [Description("AC Insert Mode")]
        ACInsertMode = 0x000c0269,

        /// <summary>
        ///     AC Delete Usage.
        /// </summary>
        [Description("AC Delete")]
        ACDelete = 0x000c026a,

        /// <summary>
        ///     AC Lock Usage.
        /// </summary>
        [Description("AC Lock")]
        ACLock = 0x000c026b,

        /// <summary>
        ///     AC Unlock Usage.
        /// </summary>
        [Description("AC Unlock")]
        ACUnlock = 0x000c026c,

        /// <summary>
        ///     AC Protect Usage.
        /// </summary>
        [Description("AC Protect")]
        ACProtect = 0x000c026d,

        /// <summary>
        ///     AC Unprotect Usage.
        /// </summary>
        [Description("AC Unprotect")]
        ACUnprotect = 0x000c026e,

        /// <summary>
        ///     AC Attach Comment Usage.
        /// </summary>
        [Description("AC Attach Comment")]
        ACAttachComment = 0x000c026f,

        /// <summary>
        ///     AC Delete Comment Usage.
        /// </summary>
        [Description("AC Delete Comment")]
        ACDeleteComment = 0x000c0270,

        /// <summary>
        ///     AC View Comment Usage.
        /// </summary>
        [Description("AC View Comment")]
        ACViewComment = 0x000c0271,

        /// <summary>
        ///     AC Select Word Usage.
        /// </summary>
        [Description("AC Select Word")]
        ACSelectWord = 0x000c0272,

        /// <summary>
        ///     AC Select Sentence Usage.
        /// </summary>
        [Description("AC Select Sentence")]
        ACSelectSentence = 0x000c0273,

        /// <summary>
        ///     AC Select Paragraph Usage.
        /// </summary>
        [Description("AC Select Paragraph")]
        ACSelectParagraph = 0x000c0274,

        /// <summary>
        ///     AC Select Column Usage.
        /// </summary>
        [Description("AC Select Column")]
        ACSelectColumn = 0x000c0275,

        /// <summary>
        ///     AC Select Row Usage.
        /// </summary>
        [Description("AC Select Row")]
        ACSelectRow = 0x000c0276,

        /// <summary>
        ///     AC Select Table Usage.
        /// </summary>
        [Description("AC Select Table")]
        ACSelectTable = 0x000c0277,

        /// <summary>
        ///     AC Select Object Usage.
        /// </summary>
        [Description("AC Select Object")]
        ACSelectObject = 0x000c0278,

        /// <summary>
        ///     AC Redo/Repeat Usage.
        /// </summary>
        [Description("AC Redo/Repeat")]
        ACRedoRepeat = 0x000c0279,

        /// <summary>
        ///     AC Sort Usage.
        /// </summary>
        [Description("AC Sort")]
        ACSort = 0x000c027a,

        /// <summary>
        ///     AC Sort Ascending Usage.
        /// </summary>
        [Description("AC Sort Ascending")]
        ACSortAscending = 0x000c027b,

        /// <summary>
        ///     AC Sort Descending Usage.
        /// </summary>
        [Description("AC Sort Descending")]
        ACSortDescending = 0x000c027c,

        /// <summary>
        ///     AC Filter Usage.
        /// </summary>
        [Description("AC Filter")]
        ACFilter = 0x000c027d,

        /// <summary>
        ///     AC Set Clock Usage.
        /// </summary>
        [Description("AC Set Clock")]
        ACSetClock = 0x000c027e,

        /// <summary>
        ///     AC View Clock Usage.
        /// </summary>
        [Description("AC View Clock")]
        ACViewClock = 0x000c027f,

        /// <summary>
        ///     AC Select Time Zone Usage.
        /// </summary>
        [Description("AC Select Time Zone")]
        ACSelectTimeZone = 0x000c0280,

        /// <summary>
        ///     AC Edit Time Zones Usage.
        /// </summary>
        [Description("AC Edit Time Zones")]
        ACEditTimeZones = 0x000c0281,

        /// <summary>
        ///     AC Set Alarm Usage.
        /// </summary>
        [Description("AC Set Alarm")]
        ACSetAlarm = 0x000c0282,

        /// <summary>
        ///     AC Clear Alarm Usage.
        /// </summary>
        [Description("AC Clear Alarm")]
        ACClearAlarm = 0x000c0283,

        /// <summary>
        ///     AC Snooze Alarm Usage.
        /// </summary>
        [Description("AC Snooze Alarm")]
        ACSnoozeAlarm = 0x000c0284,

        /// <summary>
        ///     AC Reset Alarm Usage.
        /// </summary>
        [Description("AC Reset Alarm")]
        ACResetAlarm = 0x000c0285,

        /// <summary>
        ///     AC Synchronize Usage.
        /// </summary>
        [Description("AC Synchronize")]
        ACSynchronize = 0x000c0286,

        /// <summary>
        ///     AC Send/Receive Usage.
        /// </summary>
        [Description("AC Send/Receive")]
        ACSendReceive = 0x000c0287,

        /// <summary>
        ///     AC Send To Usage.
        /// </summary>
        [Description("AC Send To")]
        ACSendTo = 0x000c0288,

        /// <summary>
        ///     AC Reply Usage.
        /// </summary>
        [Description("AC Reply")]
        ACReply = 0x000c0289,

        /// <summary>
        ///     AC Reply All Usage.
        /// </summary>
        [Description("AC Reply All")]
        ACReplyAll = 0x000c028a,

        /// <summary>
        ///     AC Forward Msg Usage.
        /// </summary>
        [Description("AC Forward Msg")]
        ACForwardMsg = 0x000c028b,

        /// <summary>
        ///     AC Send Usage.
        /// </summary>
        [Description("AC Send")]
        ACSend = 0x000c028c,

        /// <summary>
        ///     AC Attach File Usage.
        /// </summary>
        [Description("AC Attach File")]
        ACAttachFile = 0x000c028d,

        /// <summary>
        ///     AC Upload Usage.
        /// </summary>
        [Description("AC Upload")]
        ACUpload = 0x000c028e,

        /// <summary>
        ///     AC Download (Save Target As) Usage.
        /// </summary>
        [Description("AC Download (Save Target As)")]
        ACDownloadSaveTargetAs = 0x000c028f,

        /// <summary>
        ///     AC Set Borders Usage.
        /// </summary>
        [Description("AC Set Borders")]
        ACSetBorders = 0x000c0290,

        /// <summary>
        ///     AC Insert Row Usage.
        /// </summary>
        [Description("AC Insert Row")]
        ACInsertRow = 0x000c0291,

        /// <summary>
        ///     AC Insert Column Usage.
        /// </summary>
        [Description("AC Insert Column")]
        ACInsertColumn = 0x000c0292,

        /// <summary>
        ///     AC Insert File Usage.
        /// </summary>
        [Description("AC Insert File")]
        ACInsertFile = 0x000c0293,

        /// <summary>
        ///     AC Insert Picture Usage.
        /// </summary>
        [Description("AC Insert Picture")]
        ACInsertPicture = 0x000c0294,

        /// <summary>
        ///     AC Insert Object Usage.
        /// </summary>
        [Description("AC Insert Object")]
        ACInsertObject = 0x000c0295,

        /// <summary>
        ///     AC Insert Symbol Usage.
        /// </summary>
        [Description("AC Insert Symbol")]
        ACInsertSymbol = 0x000c0296,

        /// <summary>
        ///     AC Save and Close Usage.
        /// </summary>
        [Description("AC Save and Close")]
        ACSaveAndClose = 0x000c0297,

        /// <summary>
        ///     AC Rename Usage.
        /// </summary>
        [Description("AC Rename")]
        ACRename = 0x000c0298,

        /// <summary>
        ///     AC Merge Usage.
        /// </summary>
        [Description("AC Merge")]
        ACMerge = 0x000c0299,

        /// <summary>
        ///     AC Split Usage.
        /// </summary>
        [Description("AC Split")]
        ACSplit = 0x000c029a,

        /// <summary>
        ///     AC Distribute Horizontally Usage.
        /// </summary>
        [Description("AC Distribute Horizontally")]
        ACDistributeHorizontally = 0x000c029b,

        /// <summary>
        ///     AC Distribute Vertically Usage.
        /// </summary>
        [Description("AC Distribute Vertically")]
        ACDistributeVertically = 0x000c029c,

        /// <summary>
        ///     AC Next Keyboard Layout Select Usage.
        /// </summary>
        [Description("AC Next Keyboard Layout Select")]
        ACNextKeyboardLayoutSelect = 0x000c029d,

        /// <summary>
        ///     AC Navigation Guidance Usage.
        /// </summary>
        [Description("AC Navigation Guidance")]
        ACNavigationGuidance = 0x000c029e,

        /// <summary>
        ///     AC Desktop Show All Windows Usage.
        /// </summary>
        [Description("AC Desktop Show All Windows")]
        ACDesktopShowAllWindows = 0x000c029f,

        /// <summary>
        ///     AC Desktop Show All Applications Usage.
        /// </summary>
        [Description("AC Desktop Show All Applications")]
        ACDesktopShowAllApplications = 0x000c02a0,

        /// <summary>
        ///     Extended Keyboard Attributes Collection Usage.
        /// </summary>
        [Description("Extended Keyboard Attributes Collection")]
        ExtendedKeyboardAttributesCollection = 0x000c02c0,

        /// <summary>
        ///     Keyboard Form Factor Usage.
        /// </summary>
        [Description("Keyboard Form Factor")]
        KeyboardFormFactor = 0x000c02c1,

        /// <summary>
        ///     Keyboard Key Type Usage.
        /// </summary>
        [Description("Keyboard Key Type")]
        KeyboardKeyType = 0x000c02c2,

        /// <summary>
        ///     Keyboard Physical Layout Usage.
        /// </summary>
        [Description("Keyboard Physical Layout")]
        KeyboardPhysicalLayout = 0x000c02c3,

        /// <summary>
        ///     Vendor-Specific Keyboard Physical Layout Usage.
        /// </summary>
        [Description("Vendor-Specific Keyboard Physical Layout")]
        VendorSpecificKeyboardPhysicalLayout = 0x000c02c4,

        /// <summary>
        ///     Keyboard IETF Language Tag Index Usage.
        /// </summary>
        [Description("Keyboard IETF Language Tag Index")]
        KeyboardIETFLanguageTagIndex = 0x000c02c5,

        /// <summary>
        ///     Implemented Keyboard Input Assist Controls Usage.
        /// </summary>
        [Description("Implemented Keyboard Input Assist Controls")]
        ImplementedKeyboardInputAssistControls = 0x000c02c6,

        /// <summary>
        ///     Keyboard Input Assist Previous Usage.
        /// </summary>
        [Description("Keyboard Input Assist Previous")]
        KeyboardInputAssistPrevious = 0x000c02c7,

        /// <summary>
        ///     Keyboard Input Assist Next Usage.
        /// </summary>
        [Description("Keyboard Input Assist Next")]
        KeyboardInputAssistNext = 0x000c02c8,

        /// <summary>
        ///     Keyboard Input Assist Previous Group Usage.
        /// </summary>
        [Description("Keyboard Input Assist Previous Group")]
        KeyboardInputAssistPreviousGroup = 0x000c02c9,

        /// <summary>
        ///     Keyboard Input Assist Next Group Usage.
        /// </summary>
        [Description("Keyboard Input Assist Next Group")]
        KeyboardInputAssistNextGroup = 0x000c02ca,

        /// <summary>
        ///     Keyboard Input Assist Accept Usage.
        /// </summary>
        [Description("Keyboard Input Assist Accept")]
        KeyboardInputAssistAccept = 0x000c02cb,

        /// <summary>
        ///     Keyboard Input Assist Cancel Usage.
        /// </summary>
        [Description("Keyboard Input Assist Cancel")]
        KeyboardInputAssistCancel = 0x000c02cc,

        /// <summary>
        ///     Privacy Screen Toggle Usage.
        /// </summary>
        [Description("Privacy Screen Toggle")]
        PrivacyScreenToggle = 0x000c02d0,

        /// <summary>
        ///     Privacy Screen Level Decrement Usage.
        /// </summary>
        [Description("Privacy Screen Level Decrement")]
        PrivacyScreenLevelDecrement = 0x000c02d1,

        /// <summary>
        ///     Privacy Screen Level Increment Usage.
        /// </summary>
        [Description("Privacy Screen Level Increment")]
        PrivacyScreenLevelIncrement = 0x000c02d2,

        /// <summary>
        ///     Privacy Screen Level Minimum Usage.
        /// </summary>
        [Description("Privacy Screen Level Minimum")]
        PrivacyScreenLevelMinimum = 0x000c02d3,

        /// <summary>
        ///     Privacy Screen Level Maximum Usage.
        /// </summary>
        [Description("Privacy Screen Level Maximum")]
        PrivacyScreenLevelMaximum = 0x000c02d4
    }

    /// <summary>
    ///     Digitizer Usage Page.
    /// </summary>
    [Description("Digitizer Usage Page")]
    public enum DigitizerPage : uint
    {
        /// <summary>
        ///     Undefined Usage.
        /// </summary>
        [Description("Undefined")]
        Undefined = 0x000d0000,

        /// <summary>
        ///     Digitizer Usage.
        /// </summary>
        [Description("Digitizer")]
        Digitizer = 0x000d0001,

        /// <summary>
        ///     Pen Usage.
        /// </summary>
        [Description("Pen")]
        Pen = 0x000d0002,

        /// <summary>
        ///     Light Pen Usage.
        /// </summary>
        [Description("Light Pen")]
        LightPen = 0x000d0003,

        /// <summary>
        ///     Touch Screen Usage.
        /// </summary>
        [Description("Touch Screen")]
        TouchScreen = 0x000d0004,

        /// <summary>
        ///     Touch Pad Usage.
        /// </summary>
        [Description("Touch Pad")]
        TouchPad = 0x000d0005,

        /// <summary>
        ///     White Board Usage.
        /// </summary>
        [Description("White Board")]
        WhiteBoard = 0x000d0006,

        /// <summary>
        ///     Coordinate Measuring Machine Usage.
        /// </summary>
        [Description("Coordinate Measuring Machine")]
        CoordinateMeasuringMachine = 0x000d0007,

        /// <summary>
        ///     3D Digitizer Usage.
        /// </summary>
        [Description("3D Digitizer")]
        DDigitizer = 0x000d0008,

        /// <summary>
        ///     Stereo Plotter Usage.
        /// </summary>
        [Description("Stereo Plotter")]
        StereoPlotter = 0x000d0009,

        /// <summary>
        ///     Articulated Arm Usage.
        /// </summary>
        [Description("Articulated Arm")]
        ArticulatedArm = 0x000d000a,

        /// <summary>
        ///     Armature Usage.
        /// </summary>
        [Description("Armature")]
        Armature = 0x000d000b,

        /// <summary>
        ///     Multiple Point Digitizer Usage.
        /// </summary>
        [Description("Multiple Point Digitizer")]
        MultiplePointDigitizer = 0x000d000c,

        /// <summary>
        ///     Free Space Wand Usage.
        /// </summary>
        [Description("Free Space Wand")]
        FreeSpaceWand = 0x000d000d,

        /// <summary>
        ///     Device Configuration Usage.
        /// </summary>
        [Description("Device Configuration")]
        DeviceConfiguration = 0x000d000e,

        /// <summary>
        ///     Capacitive Heat Map Digitizer Usage.
        /// </summary>
        [Description("Capacitive Heat Map Digitizer")]
        CapacitiveHeatMapDigitizer = 0x000d000f,

        /// <summary>
        ///     Stylus Usage.
        /// </summary>
        [Description("Stylus")]
        Stylus = 0x000d0020,

        /// <summary>
        ///     Puck Usage.
        /// </summary>
        [Description("Puck")]
        Puck = 0x000d0021,

        /// <summary>
        ///     Finger Usage.
        /// </summary>
        [Description("Finger")]
        Finger = 0x000d0022,

        /// <summary>
        ///     Device Settings Usage.
        /// </summary>
        [Description("Device Settings")]
        DeviceSettings = 0x000d0023,

        /// <summary>
        ///     Character Gesture Usage.
        /// </summary>
        [Description("Character Gesture")]
        CharacterGesture = 0x000d0024,

        /// <summary>
        ///     Tip Pressure Usage.
        /// </summary>
        [Description("Tip Pressure")]
        TipPressure = 0x000d0030,

        /// <summary>
        ///     Barrel Pressure Usage.
        /// </summary>
        [Description("Barrel Pressure")]
        BarrelPressure = 0x000d0031,

        /// <summary>
        ///     In Range Usage.
        /// </summary>
        [Description("In Range")]
        InRange = 0x000d0032,

        /// <summary>
        ///     Touch Usage.
        /// </summary>
        [Description("Touch")]
        Touch = 0x000d0033,

        /// <summary>
        ///     Untouch Usage.
        /// </summary>
        [Description("Untouch")]
        Untouch = 0x000d0034,

        /// <summary>
        ///     Tap Usage.
        /// </summary>
        [Description("Tap")]
        Tap = 0x000d0035,

        /// <summary>
        ///     Quality Usage.
        /// </summary>
        [Description("Quality")]
        Quality = 0x000d0036,

        /// <summary>
        ///     Data Valid Usage.
        /// </summary>
        [Description("Data Valid")]
        DataValid = 0x000d0037,

        /// <summary>
        ///     Transducer Index Usage.
        /// </summary>
        [Description("Transducer Index")]
        TransducerIndex = 0x000d0038,

        /// <summary>
        ///     Tablet Function Keys Usage.
        /// </summary>
        [Description("Tablet Function Keys")]
        TabletFunctionKeys = 0x000d0039,

        /// <summary>
        ///     Program Change Keys Usage.
        /// </summary>
        [Description("Program Change Keys")]
        ProgramChangeKeys = 0x000d003a,

        /// <summary>
        ///     Battery Strength Usage.
        /// </summary>
        [Description("Battery Strength")]
        BatteryStrength = 0x000d003b,

        /// <summary>
        ///     Invert Usage.
        /// </summary>
        [Description("Invert")]
        Invert = 0x000d003c,

        /// <summary>
        ///     X Tilt Usage.
        /// </summary>
        [Description("X Tilt")]
        XTilt = 0x000d003d,

        /// <summary>
        ///     Y Tilt Usage.
        /// </summary>
        [Description("Y Tilt")]
        YTilt = 0x000d003e,

        /// <summary>
        ///     Azimuth Usage.
        /// </summary>
        [Description("Azimuth")]
        Azimuth = 0x000d003f,

        /// <summary>
        ///     Altitude Usage.
        /// </summary>
        [Description("Altitude")]
        Altitude = 0x000d0040,

        /// <summary>
        ///     Twist Usage.
        /// </summary>
        [Description("Twist")]
        Twist = 0x000d0041,

        /// <summary>
        ///     Tip Switch Usage.
        /// </summary>
        [Description("Tip Switch")]
        TipSwitch = 0x000d0042,

        /// <summary>
        ///     Secondary Tip Switch Usage.
        /// </summary>
        [Description("Secondary Tip Switch")]
        SecondaryTipSwitch = 0x000d0043,

        /// <summary>
        ///     Barrel Switch Usage.
        /// </summary>
        [Description("Barrel Switch")]
        BarrelSwitch = 0x000d0044,

        /// <summary>
        ///     Eraser Usage.
        /// </summary>
        [Description("Eraser")]
        Eraser = 0x000d0045,

        /// <summary>
        ///     Tablet Pick Usage.
        /// </summary>
        [Description("Tablet Pick")]
        TabletPick = 0x000d0046,

        /// <summary>
        ///     Touch Valid Usage.
        /// </summary>
        [Description("Touch Valid")]
        TouchValid = 0x000d0047,

        /// <summary>
        ///     Width Usage.
        /// </summary>
        [Description("Width")]
        Width = 0x000d0048,

        /// <summary>
        ///     Height Usage.
        /// </summary>
        [Description("Height")]
        Height = 0x000d0049,

        /// <summary>
        ///     Contact Identifier Usage.
        /// </summary>
        [Description("Contact Identifier")]
        ContactIdentifier = 0x000d0051,

        /// <summary>
        ///     Device Mode Usage.
        /// </summary>
        [Description("Device Mode")]
        DeviceMode = 0x000d0052,

        /// <summary>
        ///     Device Identifier Usage.
        /// </summary>
        [Description("Device Identifier")]
        DeviceIdentifier = 0x000d0053,

        /// <summary>
        ///     Contact Count Usage.
        /// </summary>
        [Description("Contact Count")]
        ContactCount = 0x000d0054,

        /// <summary>
        ///     Contact Count Maximum Usage.
        /// </summary>
        [Description("Contact Count Maximum")]
        ContactCountMaximum = 0x000d0055,

        /// <summary>
        ///     Scan Time Usage.
        /// </summary>
        [Description("Scan Time")]
        ScanTime = 0x000d0056,

        /// <summary>
        ///     Surface Width Usage.
        /// </summary>
        [Description("Surface Width")]
        SurfaceWidth = 0x000d0057,

        /// <summary>
        ///     Button Switch Usage.
        /// </summary>
        [Description("Button Switch")]
        ButtonSwitch = 0x000d0058,

        /// <summary>
        ///     Pad Type Usage.
        /// </summary>
        [Description("Pad Type")]
        PadType = 0x000d0059,

        /// <summary>
        ///     Secondary Barrel Switch Usage.
        /// </summary>
        [Description("Secondary Barrel Switch")]
        SecondaryBarrelSwitch = 0x000d005a,

        /// <summary>
        ///     Transducer Serial Number Usage.
        /// </summary>
        [Description("Transducer Serial Number")]
        TransducerSerialNumber = 0x000d005b,

        /// <summary>
        ///     Preferred Color Usage.
        /// </summary>
        [Description("Preferred Color")]
        PreferredColor = 0x000d005c,

        /// <summary>
        ///     Latency Mode Usage.
        /// </summary>
        [Description("Latency Mode")]
        LatencyMode = 0x000d0060,

        /// <summary>
        ///     Gesture Character Quality Usage.
        /// </summary>
        [Description("Gesture Character Quality")]
        GestureCharacterQuality = 0x000d0061,

        /// <summary>
        ///     Character Gesture Data Length Usage.
        /// </summary>
        [Description("Character Gesture Data Length")]
        CharacterGestureDataLength = 0x000d0062,

        /// <summary>
        ///     Character Gesture Data Usage.
        /// </summary>
        [Description("Character Gesture Data")]
        CharacterGestureData = 0x000d0063,

        /// <summary>
        ///     Gesture Character Encoding Usage.
        /// </summary>
        [Description("Gesture Character Encoding")]
        GestureCharacterEncoding = 0x000d0064,

        /// <summary>
        ///     UTF8 Character Gesture Encoding Usage.
        /// </summary>
        [Description("UTF8 Character Gesture Encoding")]
        UTF8CharacterGestureEncoding = 0x000d0065,

        /// <summary>
        ///     UTF16 Little Endian Character Gesture Encoding Usage.
        /// </summary>
        [Description("UTF16 Little Endian Character Gesture Encoding")]
        UTF16LittleEndianCharacterGestureEncoding = 0x000d0066,

        /// <summary>
        ///     UTF16 Big Endian Character Gesture Encoding Usage.
        /// </summary>
        [Description("UTF16 Big Endian Character Gesture Encoding")]
        UTF16BigEndianCharacterGestureEncoding = 0x000d0067,

        /// <summary>
        ///     UTF32 Little Endian Character Gesture Encoding Usage.
        /// </summary>
        [Description("UTF32 Little Endian Character Gesture Encoding")]
        UTF32LittleEndianCharacterGestureEncoding = 0x000d0068,

        /// <summary>
        ///     UTF32 Big Endian Character Gesture Encoding Usage.
        /// </summary>
        [Description("UTF32 Big Endian Character Gesture Encoding")]
        UTF32BigEndianCharacterGestureEncoding = 0x000d0069,

        /// <summary>
        ///     Capacitive Heat Map Protocol Vendor ID Usage.
        /// </summary>
        [Description("Capacitive Heat Map Protocol Vendor ID")]
        CapacitiveHeatMapProtocolVendorID = 0x000d006a,

        /// <summary>
        ///     Capacitive Heat Map Protocol Version Usage.
        /// </summary>
        [Description("Capacitive Heat Map Protocol Version")]
        CapacitiveHeatMapProtocolVersion = 0x000d006b,

        /// <summary>
        ///     Capacitive Heat Map Frame Data Usage.
        /// </summary>
        [Description("Capacitive Heat Map Frame Data")]
        CapacitiveHeatMapFrameData = 0x000d006c,

        /// <summary>
        ///     Gesture Character Enable Usage.
        /// </summary>
        [Description("Gesture Character Enable")]
        GestureCharacterEnable = 0x000d006d,

        /// <summary>
        ///     Transducer Software Info Usage.
        /// </summary>
        [Description("Transducer Software Info")]
        TransducerSoftwareInfo = 0x000d0090,

        /// <summary>
        ///     Transducer Vendor ID Usage.
        /// </summary>
        [Description("Transducer Vendor ID")]
        TransducerVendorID = 0x000d0091,

        /// <summary>
        ///     Transducer Product ID Usage.
        /// </summary>
        [Description("Transducer Product ID")]
        TransducerProductID = 0x000d0092,

        /// <summary>
        ///     Device Supported Protocols Usage.
        /// </summary>
        [Description("Device Supported Protocols")]
        DeviceSupportedProtocols = 0x000d0093,

        /// <summary>
        ///     Transducer Supported Protocols Usage.
        /// </summary>
        [Description("Transducer Supported Protocols")]
        TransducerSupportedProtocols = 0x000d0094,

        /// <summary>
        ///     No Protocol Usage.
        /// </summary>
        [Description("No Protocol")]
        NoProtocol = 0x000d0095,

        /// <summary>
        ///     Wacom AES Protocol Usage.
        /// </summary>
        [Description("Wacom AES Protocol")]
        WacomAESProtocol = 0x000d0096,

        /// <summary>
        ///     USI Protocol Usage.
        /// </summary>
        [Description("USI Protocol")]
        USIProtocol = 0x000d0097,

        /// <summary>
        ///     Microsoft Pen Protocol Usage.
        /// </summary>
        [Description("Microsoft Pen Protocol")]
        MicrosoftPenProtocol = 0x000d0098,

        /// <summary>
        ///     Supported Report Rates Usage.
        /// </summary>
        [Description("Supported Report Rates")]
        SupportedReportRates = 0x000d00a0,

        /// <summary>
        ///     Report Rate Usage.
        /// </summary>
        [Description("Report Rate")]
        ReportRate = 0x000d00a1,

        /// <summary>
        ///     Transducer Connected Usage.
        /// </summary>
        [Description("Transducer Connected")]
        TransducerConnected = 0x000d00a2,

        /// <summary>
        ///     Switch Disabled Usage.
        /// </summary>
        [Description("Switch Disabled")]
        SwitchDisabled = 0x000d00a3,

        /// <summary>
        ///     Switch Unimplemented Usage.
        /// </summary>
        [Description("Switch Unimplemented")]
        SwitchUnimplemented = 0x000d00a4,

        /// <summary>
        ///     Transducer Switches Usage.
        /// </summary>
        [Description("Transducer Switches")]
        TransducerSwitches = 0x000d00a5
    }

    /// <summary>
    ///     Haptics Usage Page.
    /// </summary>
    [Description("Haptics Usage Page")]
    public enum HapticsPage : uint
    {
        /// <summary>
        ///     Undefined Usage.
        /// </summary>
        [Description("Undefined")]
        Undefined = 0x000e0000,

        /// <summary>
        ///     Simple Haptic Controller Usage.
        /// </summary>
        [Description("Simple Haptic Controller")]
        SimpleHapticController = 0x000e0001,

        /// <summary>
        ///     Waveform List Usage.
        /// </summary>
        [Description("Waveform List")]
        WaveformList = 0x000e0010,

        /// <summary>
        ///     Duration List Usage.
        /// </summary>
        [Description("Duration List")]
        DurationList = 0x000e0011,

        /// <summary>
        ///     Auto Trigger Usage.
        /// </summary>
        [Description("Auto Trigger")]
        AutoTrigger = 0x000e0020,

        /// <summary>
        ///     Manual Trigger Usage.
        /// </summary>
        [Description("Manual Trigger")]
        ManualTrigger = 0x000e0021,

        /// <summary>
        ///     Auto Trigger Associated Control Usage.
        /// </summary>
        [Description("Auto Trigger Associated Control")]
        AutoTriggerAssociatedControl = 0x000e0022,

        /// <summary>
        ///     Intensity Usage.
        /// </summary>
        [Description("Intensity")]
        Intensity = 0x000e0023,

        /// <summary>
        ///     Repeat Count Usage.
        /// </summary>
        [Description("Repeat Count")]
        RepeatCount = 0x000e0024,

        /// <summary>
        ///     Retrigger Period Usage.
        /// </summary>
        [Description("Retrigger Period")]
        RetriggerPeriod = 0x000e0025,

        /// <summary>
        ///     Waveform Vendor Page Usage.
        /// </summary>
        [Description("Waveform Vendor Page")]
        WaveformVendorPage = 0x000e0026,

        /// <summary>
        ///     Waveform Vendor ID Usage.
        /// </summary>
        [Description("Waveform Vendor ID")]
        WaveformVendorID = 0x000e0027,

        /// <summary>
        ///     Waveform Cutoff Time Usage.
        /// </summary>
        [Description("Waveform Cutoff Time")]
        WaveformCutoffTime = 0x000e0028,

        /// <summary>
        ///     WAVEFORM_NONE Usage.
        /// </summary>
        [Description("WAVEFORM_NONE")]
        WAVEFORM_NONE = 0x000e1001,

        /// <summary>
        ///     WAVEFORM_STOP Usage.
        /// </summary>
        [Description("WAVEFORM_STOP")]
        WAVEFORM_STOP = 0x000e1002,

        /// <summary>
        ///     WAVEFORM_CLICK Usage.
        /// </summary>
        [Description("WAVEFORM_CLICK")]
        WAVEFORM_CLICK = 0x000e1003,

        /// <summary>
        ///     WAVEFORM_BUZZ_CONTINUOUS Usage.
        /// </summary>
        [Description("WAVEFORM_BUZZ_CONTINUOUS")]
        WAVEFORM_BUZZ_CONTINUOUS = 0x000e1004,

        /// <summary>
        ///     WAVEFORM_RUMBLE_CONTINUOUS Usage.
        /// </summary>
        [Description("WAVEFORM_RUMBLE_CONTINUOUS")]
        WAVEFORM_RUMBLE_CONTINUOUS = 0x000e1005,

        /// <summary>
        ///     WAVEFORM_PRESS Usage.
        /// </summary>
        [Description("WAVEFORM_PRESS")]
        WAVEFORM_PRESS = 0x000e1006,

        /// <summary>
        ///     WAVEFORM_RELEASE Usage.
        /// </summary>
        [Description("WAVEFORM_RELEASE")]
        WAVEFORM_RELEASE = 0x000e1007
    }

    /// <summary>
    ///     Physical Interface Device Usage Page.
    /// </summary>
    [Description("Physical Interface Device Usage Page")]
    public enum PhysicalInterfaceDevicePage : uint
    {
        /// <summary>
        ///     Undefined Usage.
        /// </summary>
        [Description("Undefined")]
        Undefined = 0x000f0000,

        /// <summary>
        ///     Physical Interface Device Usage.
        /// </summary>
        [Description("Physical Interface Device")]
        PhysicalInterfaceDevice = 0x000f0001,

        /// <summary>
        ///     Normal Usage.
        /// </summary>
        [Description("Normal")]
        Normal = 0x000f0020,

        /// <summary>
        ///     Set Effect Report Usage.
        /// </summary>
        [Description("Set Effect Report")]
        SetEffectReport = 0x000f0021,

        /// <summary>
        ///     Effect Block Index Usage.
        /// </summary>
        [Description("Effect Block Index")]
        EffectBlockIndex = 0x000f0022,

        /// <summary>
        ///     Parameter Block Offset Usage.
        /// </summary>
        [Description("Parameter Block Offset")]
        ParameterBlockOffset = 0x000f0023,

        /// <summary>
        ///     ROM Flag Usage.
        /// </summary>
        [Description("ROM Flag")]
        ROMFlag = 0x000f0024,

        /// <summary>
        ///     Effect Type Usage.
        /// </summary>
        [Description("Effect Type")]
        EffectType = 0x000f0025,

        /// <summary>
        ///     ET Constant Force Usage.
        /// </summary>
        [Description("ET Constant Force")]
        ETConstantForce = 0x000f0026,

        /// <summary>
        ///     ET Ramp Usage.
        /// </summary>
        [Description("ET Ramp")]
        ETRamp = 0x000f0027,

        /// <summary>
        ///     ET Custom Force Data Usage.
        /// </summary>
        [Description("ET Custom Force Data")]
        ETCustomForceData = 0x000f0028,

        /// <summary>
        ///     ET Square Usage.
        /// </summary>
        [Description("ET Square")]
        ETSquare = 0x000f0030,

        /// <summary>
        ///     ET Sine Usage.
        /// </summary>
        [Description("ET Sine")]
        ETSine = 0x000f0031,

        /// <summary>
        ///     ET Triangle Usage.
        /// </summary>
        [Description("ET Triangle")]
        ETTriangle = 0x000f0032,

        /// <summary>
        ///     ET Sawtooth Up Usage.
        /// </summary>
        [Description("ET Sawtooth Up")]
        ETSawtoothUp = 0x000f0033,

        /// <summary>
        ///     ET Sawtooth Down Usage.
        /// </summary>
        [Description("ET Sawtooth Down")]
        ETSawtoothDown = 0x000f0034,

        /// <summary>
        ///     ET Spring Usage.
        /// </summary>
        [Description("ET Spring")]
        ETSpring = 0x000f0040,

        /// <summary>
        ///     ET Damper Usage.
        /// </summary>
        [Description("ET Damper")]
        ETDamper = 0x000f0041,

        /// <summary>
        ///     ET Inertia Usage.
        /// </summary>
        [Description("ET Inertia")]
        ETInertia = 0x000f0042,

        /// <summary>
        ///     ET Friction Usage.
        /// </summary>
        [Description("ET Friction")]
        ETFriction = 0x000f0043,

        /// <summary>
        ///     Duration Usage.
        /// </summary>
        [Description("Duration")]
        Duration = 0x000f0050,

        /// <summary>
        ///     Sample Period Usage.
        /// </summary>
        [Description("Sample Period")]
        SamplePeriod = 0x000f0051,

        /// <summary>
        ///     Gain Usage.
        /// </summary>
        [Description("Gain")]
        Gain = 0x000f0052,

        /// <summary>
        ///     Trigger Button Usage.
        /// </summary>
        [Description("Trigger Button")]
        TriggerButton = 0x000f0053,

        /// <summary>
        ///     Trigger Repeat Interval Usage.
        /// </summary>
        [Description("Trigger Repeat Interval")]
        TriggerRepeatInterval = 0x000f0054,

        /// <summary>
        ///     Axes Enable Usage.
        /// </summary>
        [Description("Axes Enable")]
        AxesEnable = 0x000f0055,

        /// <summary>
        ///     Direction Enable Usage.
        /// </summary>
        [Description("Direction Enable")]
        DirectionEnable = 0x000f0056,

        /// <summary>
        ///     Direction Usage.
        /// </summary>
        [Description("Direction")]
        Direction = 0x000f0057,

        /// <summary>
        ///     Type Specific Block Offset Usage.
        /// </summary>
        [Description("Type Specific Block Offset")]
        TypeSpecificBlockOffset = 0x000f0058,

        /// <summary>
        ///     Block Type Usage.
        /// </summary>
        [Description("Block Type")]
        BlockType = 0x000f0059,

        /// <summary>
        ///     Set Envelope Report Usage.
        /// </summary>
        [Description("Set Envelope Report")]
        SetEnvelopeReport = 0x000f005a,

        /// <summary>
        ///     Attack Level Usage.
        /// </summary>
        [Description("Attack Level")]
        AttackLevel = 0x000f005b,

        /// <summary>
        ///     Attack Time Usage.
        /// </summary>
        [Description("Attack Time")]
        AttackTime = 0x000f005c,

        /// <summary>
        ///     Fade Level Usage.
        /// </summary>
        [Description("Fade Level")]
        FadeLevel = 0x000f005d,

        /// <summary>
        ///     Fade Time Usage.
        /// </summary>
        [Description("Fade Time")]
        FadeTime = 0x000f005e,

        /// <summary>
        ///     Set Condition Report Usage.
        /// </summary>
        [Description("Set Condition Report")]
        SetConditionReport = 0x000f005f,

        /// <summary>
        ///     CP Offset Usage.
        /// </summary>
        [Description("CP Offset")]
        CPOffset = 0x000f0060,

        /// <summary>
        ///     Positive Coefficient Usage.
        /// </summary>
        [Description("Positive Coefficient")]
        PositiveCoefficient = 0x000f0061,

        /// <summary>
        ///     Negative Coefficient Usage.
        /// </summary>
        [Description("Negative Coefficient")]
        NegativeCoefficient = 0x000f0062,

        /// <summary>
        ///     Positive Saturation Usage.
        /// </summary>
        [Description("Positive Saturation")]
        PositiveSaturation = 0x000f0063,

        /// <summary>
        ///     Negative Saturation Usage.
        /// </summary>
        [Description("Negative Saturation")]
        NegativeSaturation = 0x000f0064,

        /// <summary>
        ///     Dead Band Usage.
        /// </summary>
        [Description("Dead Band")]
        DeadBand = 0x000f0065,

        /// <summary>
        ///     Download Force Sample Usage.
        /// </summary>
        [Description("Download Force Sample")]
        DownloadForceSample = 0x000f0066,

        /// <summary>
        ///     Isoch Custom Force Enable Usage.
        /// </summary>
        [Description("Isoch Custom Force Enable")]
        IsochCustomForceEnable = 0x000f0067,

        /// <summary>
        ///     Custom Force Data Report Usage.
        /// </summary>
        [Description("Custom Force Data Report")]
        CustomForceDataReport = 0x000f0068,

        /// <summary>
        ///     Custom Force Data Usage.
        /// </summary>
        [Description("Custom Force Data")]
        CustomForceData = 0x000f0069,

        /// <summary>
        ///     Custom Force Vendor Defined Data Usage.
        /// </summary>
        [Description("Custom Force Vendor Defined Data")]
        CustomForceVendorDefinedData = 0x000f006a,

        /// <summary>
        ///     Set Custom Force Report Usage.
        /// </summary>
        [Description("Set Custom Force Report")]
        SetCustomForceReport = 0x000f006b,

        /// <summary>
        ///     Custom Force Data Offset Usage.
        /// </summary>
        [Description("Custom Force Data Offset")]
        CustomForceDataOffset = 0x000f006c,

        /// <summary>
        ///     Sample Count Usage.
        /// </summary>
        [Description("Sample Count")]
        SampleCount = 0x000f006d,

        /// <summary>
        ///     Set Periodic Report Usage.
        /// </summary>
        [Description("Set Periodic Report")]
        SetPeriodicReport = 0x000f006e,

        /// <summary>
        ///     Offset Usage.
        /// </summary>
        [Description("Offset")]
        Offset = 0x000f006f,

        /// <summary>
        ///     Magnitude Usage.
        /// </summary>
        [Description("Magnitude")]
        Magnitude = 0x000f0070,

        /// <summary>
        ///     Phase Usage.
        /// </summary>
        [Description("Phase")]
        Phase = 0x000f0071,

        /// <summary>
        ///     Period Usage.
        /// </summary>
        [Description("Period")]
        Period = 0x000f0072,

        /// <summary>
        ///     Set Constant Force Report Usage.
        /// </summary>
        [Description("Set Constant Force Report")]
        SetConstantForceReport = 0x000f0073,

        /// <summary>
        ///     Set Ramp Force Report Usage.
        /// </summary>
        [Description("Set Ramp Force Report")]
        SetRampForceReport = 0x000f0074,

        /// <summary>
        ///     Ramp Start Usage.
        /// </summary>
        [Description("Ramp Start")]
        RampStart = 0x000f0075,

        /// <summary>
        ///     Ramp End Usage.
        /// </summary>
        [Description("Ramp End")]
        RampEnd = 0x000f0076,

        /// <summary>
        ///     Effect Operation Report Usage.
        /// </summary>
        [Description("Effect Operation Report")]
        EffectOperationReport = 0x000f0077,

        /// <summary>
        ///     Effect Operation Usage.
        /// </summary>
        [Description("Effect Operation")]
        EffectOperation = 0x000f0078,

        /// <summary>
        ///     Op Effect Start Usage.
        /// </summary>
        [Description("Op Effect Start")]
        OpEffectStart = 0x000f0079,

        /// <summary>
        ///     Op Effect Start Solo Usage.
        /// </summary>
        [Description("Op Effect Start Solo")]
        OpEffectStartSolo = 0x000f007a,

        /// <summary>
        ///     Op Effect Stop Usage.
        /// </summary>
        [Description("Op Effect Stop")]
        OpEffectStop = 0x000f007b,

        /// <summary>
        ///     Loop Count Usage.
        /// </summary>
        [Description("Loop Count")]
        LoopCount = 0x000f007c,

        /// <summary>
        ///     Device Gain Report Usage.
        /// </summary>
        [Description("Device Gain Report")]
        DeviceGainReport = 0x000f007d,

        /// <summary>
        ///     Device Gain Usage.
        /// </summary>
        [Description("Device Gain")]
        DeviceGain = 0x000f007e,

        /// <summary>
        ///     PID Pool Report Usage.
        /// </summary>
        [Description("PID Pool Report")]
        PIDPoolReport = 0x000f007f,

        /// <summary>
        ///     RAM Pool Size Usage.
        /// </summary>
        [Description("RAM Pool Size")]
        RAMPoolSize = 0x000f0080,

        /// <summary>
        ///     ROM Pool Size Usage.
        /// </summary>
        [Description("ROM Pool Size")]
        ROMPoolSize = 0x000f0081,

        /// <summary>
        ///     ROM Effect Block Count Usage.
        /// </summary>
        [Description("ROM Effect Block Count")]
        ROMEffectBlockCount = 0x000f0082,

        /// <summary>
        ///     Simultaneous Effects Max Usage.
        /// </summary>
        [Description("Simultaneous Effects Max")]
        SimultaneousEffectsMax = 0x000f0083,

        /// <summary>
        ///     Pool Alignment Usage.
        /// </summary>
        [Description("Pool Alignment")]
        PoolAlignment = 0x000f0084,

        /// <summary>
        ///     PID Pool Move Report Usage.
        /// </summary>
        [Description("PID Pool Move Report")]
        PIDPoolMoveReport = 0x000f0085,

        /// <summary>
        ///     Move Source Usage.
        /// </summary>
        [Description("Move Source")]
        MoveSource = 0x000f0086,

        /// <summary>
        ///     Move Destination Usage.
        /// </summary>
        [Description("Move Destination")]
        MoveDestination = 0x000f0087,

        /// <summary>
        ///     Move Length Usage.
        /// </summary>
        [Description("Move Length")]
        MoveLength = 0x000f0088,

        /// <summary>
        ///     PID Block Load Report Usage.
        /// </summary>
        [Description("PID Block Load Report")]
        PIDBlockLoadReport = 0x000f0089,

        /// <summary>
        ///     Block Load Status Usage.
        /// </summary>
        [Description("Block Load Status")]
        BlockLoadStatus = 0x000f008b,

        /// <summary>
        ///     Block Load Success Usage.
        /// </summary>
        [Description("Block Load Success")]
        BlockLoadSuccess = 0x000f008c,

        /// <summary>
        ///     Block Load Full Usage.
        /// </summary>
        [Description("Block Load Full")]
        BlockLoadFull = 0x000f008d,

        /// <summary>
        ///     Block Load Error Usage.
        /// </summary>
        [Description("Block Load Error")]
        BlockLoadError = 0x000f008e,

        /// <summary>
        ///     Block Handle Usage.
        /// </summary>
        [Description("Block Handle")]
        BlockHandle = 0x000f008f,

        /// <summary>
        ///     PID Block Free Report Usage.
        /// </summary>
        [Description("PID Block Free Report")]
        PIDBlockFreeReport = 0x000f0090,

        /// <summary>
        ///     Type Specific Block Handle Usage.
        /// </summary>
        [Description("Type Specific Block Handle")]
        TypeSpecificBlockHandle = 0x000f0091,

        /// <summary>
        ///     PID State Report Usage.
        /// </summary>
        [Description("PID State Report")]
        PIDStateReport = 0x000f0092,

        /// <summary>
        ///     Effect Playing Usage.
        /// </summary>
        [Description("Effect Playing")]
        EffectPlaying = 0x000f0094,

        /// <summary>
        ///     PID Device Control Report Usage.
        /// </summary>
        [Description("PID Device Control Report")]
        PIDDeviceControlReport = 0x000f0095,

        /// <summary>
        ///     PID Device Control Usage.
        /// </summary>
        [Description("PID Device Control")]
        PIDDeviceControl = 0x000f0096,

        /// <summary>
        ///     DC Enable Actuators Usage.
        /// </summary>
        [Description("DC Enable Actuators")]
        DCEnableActuators = 0x000f0097,

        /// <summary>
        ///     DC Disable Actuators Usage.
        /// </summary>
        [Description("DC Disable Actuators")]
        DCDisableActuators = 0x000f0098,

        /// <summary>
        ///     DC Stop All Effects Usage.
        /// </summary>
        [Description("DC Stop All Effects")]
        DCStopAllEffects = 0x000f0099,

        /// <summary>
        ///     DC Device Reset Usage.
        /// </summary>
        [Description("DC Device Reset")]
        DCDeviceReset = 0x000f009a,

        /// <summary>
        ///     DC Device Pause Usage.
        /// </summary>
        [Description("DC Device Pause")]
        DCDevicePause = 0x000f009b,

        /// <summary>
        ///     DC Device Continue Usage.
        /// </summary>
        [Description("DC Device Continue")]
        DCDeviceContinue = 0x000f009c,

        /// <summary>
        ///     Device Paused Usage.
        /// </summary>
        [Description("Device Paused")]
        DevicePaused = 0x000f009f,

        /// <summary>
        ///     Actuators Enabled Usage.
        /// </summary>
        [Description("Actuators Enabled")]
        ActuatorsEnabled = 0x000f00a0,

        /// <summary>
        ///     Safety Switch Usage.
        /// </summary>
        [Description("Safety Switch")]
        SafetySwitch = 0x000f00a4,

        /// <summary>
        ///     Actuator Override Switch Usage.
        /// </summary>
        [Description("Actuator Override Switch")]
        ActuatorOverrideSwitch = 0x000f00a5,

        /// <summary>
        ///     Actuator Power Usage.
        /// </summary>
        [Description("Actuator Power")]
        ActuatorPower = 0x000f00a6,

        /// <summary>
        ///     Start Delay Usage.
        /// </summary>
        [Description("Start Delay")]
        StartDelay = 0x000f00a7,

        /// <summary>
        ///     Parameter Block Size Usage.
        /// </summary>
        [Description("Parameter Block Size")]
        ParameterBlockSize = 0x000f00a8,

        /// <summary>
        ///     Device Managed Pool Usage.
        /// </summary>
        [Description("Device Managed Pool")]
        DeviceManagedPool = 0x000f00a9,

        /// <summary>
        ///     Shared Parameter Blocks Usage.
        /// </summary>
        [Description("Shared Parameter Blocks")]
        SharedParameterBlocks = 0x000f00aa,

        /// <summary>
        ///     Create New Effect Report Usage.
        /// </summary>
        [Description("Create New Effect Report")]
        CreateNewEffectReport = 0x000f00ab,

        /// <summary>
        ///     RAM Pool Available Usage.
        /// </summary>
        [Description("RAM Pool Available")]
        RAMPoolAvailable = 0x000f00ac
    }

    /// <summary>
    ///     Unicode Usage Page.
    /// </summary>
    [Description("Unicode Usage Page")]
    public enum UnicodePage : uint
    {
        /// <summary>
        ///     Undefined Usage.
        /// </summary>
        [Description("Undefined")]
        Undefined = 0x00100000
    }

    /// <summary>
    ///     Eye and Head Trackers Usage Page.
    /// </summary>
    [Description("Eye and Head Trackers Usage Page")]
    public enum EyeAndHeadTrackersPage : uint
    {
        /// <summary>
        ///     Undefined Usage.
        /// </summary>
        [Description("Undefined")]
        Undefined = 0x00120000,

        /// <summary>
        ///     Eye Tracker Usage.
        /// </summary>
        [Description("Eye Tracker")]
        EyeTracker = 0x00120001,

        /// <summary>
        ///     Head Tracker Usage.
        /// </summary>
        [Description("Head Tracker")]
        HeadTracker = 0x00120002,

        /// <summary>
        ///     Tracking Data Usage.
        /// </summary>
        [Description("Tracking Data")]
        TrackingData = 0x00120010,

        /// <summary>
        ///     Capabilities Usage.
        /// </summary>
        [Description("Capabilities")]
        Capabilities = 0x00120011,

        /// <summary>
        ///     Configuration Usage.
        /// </summary>
        [Description("Configuration")]
        Configuration = 0x00120012,

        /// <summary>
        ///     Status Usage.
        /// </summary>
        [Description("Status")]
        Status = 0x00120013,

        /// <summary>
        ///     Control Usage.
        /// </summary>
        [Description("Control")]
        Control = 0x00120014,

        /// <summary>
        ///     Sensor Timestamp Usage.
        /// </summary>
        [Description("Sensor Timestamp")]
        SensorTimestamp = 0x00120020,

        /// <summary>
        ///     Position X Usage.
        /// </summary>
        [Description("Position X")]
        PositionX = 0x00120021,

        /// <summary>
        ///     Position Y Usage.
        /// </summary>
        [Description("Position Y")]
        PositionY = 0x00120022,

        /// <summary>
        ///     Position Z Usage.
        /// </summary>
        [Description("Position Z")]
        PositionZ = 0x00120023,

        /// <summary>
        ///     Gaze Point Usage.
        /// </summary>
        [Description("Gaze Point")]
        GazePoint = 0x00120024,

        /// <summary>
        ///     Left Eye Position Usage.
        /// </summary>
        [Description("Left Eye Position")]
        LeftEyePosition = 0x00120025,

        /// <summary>
        ///     Right Eye Position Usage.
        /// </summary>
        [Description("Right Eye Position")]
        RightEyePosition = 0x00120026,

        /// <summary>
        ///     Head Position Usage.
        /// </summary>
        [Description("Head Position")]
        HeadPosition = 0x00120027,

        /// <summary>
        ///     Head Direction Point Usage.
        /// </summary>
        [Description("Head Direction Point")]
        HeadDirectionPoint = 0x00120028,

        /// <summary>
        ///     Rotation about X axis Usage.
        /// </summary>
        [Description("Rotation about X axis")]
        RotationAboutXAxis = 0x00120029,

        /// <summary>
        ///     Rotation about Y axis Usage.
        /// </summary>
        [Description("Rotation about Y axis")]
        RotationAboutYAxis = 0x0012002a,

        /// <summary>
        ///     Rotation about Z axis Usage.
        /// </summary>
        [Description("Rotation about Z axis")]
        RotationAboutZAxis = 0x0012002b,

        /// <summary>
        ///     Tracker Quality Usage.
        /// </summary>
        [Description("Tracker Quality")]
        TrackerQuality = 0x00120100,

        /// <summary>
        ///     Minimum Tracking Distance Usage.
        /// </summary>
        [Description("Minimum Tracking Distance")]
        MinimumTrackingDistance = 0x00120101,

        /// <summary>
        ///     Optimum Tracking Distance Usage.
        /// </summary>
        [Description("Optimum Tracking Distance")]
        OptimumTrackingDistance = 0x00120102,

        /// <summary>
        ///     Maximum Tracking Distance Usage.
        /// </summary>
        [Description("Maximum Tracking Distance")]
        MaximumTrackingDistance = 0x00120103,

        /// <summary>
        ///     Maximum Screen Plane Width Usage.
        /// </summary>
        [Description("Maximum Screen Plane Width")]
        MaximumScreenPlaneWidth = 0x00120104,

        /// <summary>
        ///     Maximum Screen Plane Height Usage.
        /// </summary>
        [Description("Maximum Screen Plane Height")]
        MaximumScreenPlaneHeight = 0x00120105,

        /// <summary>
        ///     Display Manufacturer ID Usage.
        /// </summary>
        [Description("Display Manufacturer ID")]
        DisplayManufacturerID = 0x00120200,

        /// <summary>
        ///     Display Product ID Usage.
        /// </summary>
        [Description("Display Product ID")]
        DisplayProductID = 0x00120201,

        /// <summary>
        ///     Display Serial Number Usage.
        /// </summary>
        [Description("Display Serial Number")]
        DisplaySerialNumber = 0x00120202,

        /// <summary>
        ///     Display Manufacturer Date Usage.
        /// </summary>
        [Description("Display Manufacturer Date")]
        DisplayManufacturerDate = 0x00120203,

        /// <summary>
        ///     Calibrated Screen Width Usage.
        /// </summary>
        [Description("Calibrated Screen Width")]
        CalibratedScreenWidth = 0x00120204,

        /// <summary>
        ///     Calibrated Screen Height Usage.
        /// </summary>
        [Description("Calibrated Screen Height")]
        CalibratedScreenHeight = 0x00120205,

        /// <summary>
        ///     Sampling Frequency Usage.
        /// </summary>
        [Description("Sampling Frequency")]
        SamplingFrequency = 0x00120300,

        /// <summary>
        ///     Configuration Status Usage.
        /// </summary>
        [Description("Configuration Status")]
        ConfigurationStatus = 0x00120301,

        /// <summary>
        ///     Device Mode Request Usage.
        /// </summary>
        [Description("Device Mode Request")]
        DeviceModeRequest = 0x00120400
    }

    /// <summary>
    ///     Auxiliary Display Usage Page.
    /// </summary>
    [Description("Auxiliary Display Usage Page")]
    public enum AuxiliaryDisplayPage : uint
    {
        /// <summary>
        ///     Undefined Usage.
        /// </summary>
        [Description("Undefined")]
        Undefined = 0x00140000,

        /// <summary>
        ///     Alphanumeric Display Usage.
        /// </summary>
        [Description("Alphanumeric Display")]
        AlphanumericDisplay = 0x00140001,

        /// <summary>
        ///     Auxiliary Display Usage.
        /// </summary>
        [Description("Auxiliary Display")]
        AuxiliaryDisplay = 0x00140002,

        /// <summary>
        ///     Display Attributes Report Usage.
        /// </summary>
        [Description("Display Attributes Report")]
        DisplayAttributesReport = 0x00140020,

        /// <summary>
        ///     ASCII Character Set Usage.
        /// </summary>
        [Description("ASCII Character Set")]
        ASCIICharacterSet = 0x00140021,

        /// <summary>
        ///     Data Read Back Usage.
        /// </summary>
        [Description("Data Read Back")]
        DataReadBack = 0x00140022,

        /// <summary>
        ///     Font Read Back Usage.
        /// </summary>
        [Description("Font Read Back")]
        FontReadBack = 0x00140023,

        /// <summary>
        ///     Display Control Report Usage.
        /// </summary>
        [Description("Display Control Report")]
        DisplayControlReport = 0x00140024,

        /// <summary>
        ///     Clear Display Usage.
        /// </summary>
        [Description("Clear Display")]
        ClearDisplay = 0x00140025,

        /// <summary>
        ///     Display Enable Usage.
        /// </summary>
        [Description("Display Enable")]
        DisplayEnable = 0x00140026,

        /// <summary>
        ///     Screen Saver Delay Usage.
        /// </summary>
        [Description("Screen Saver Delay")]
        ScreenSaverDelay = 0x00140027,

        /// <summary>
        ///     Screen Saver Enable Usage.
        /// </summary>
        [Description("Screen Saver Enable")]
        ScreenSaverEnable = 0x00140028,

        /// <summary>
        ///     Vertical Scroll Usage.
        /// </summary>
        [Description("Vertical Scroll")]
        VerticalScroll = 0x00140029,

        /// <summary>
        ///     Horizontal Scroll Usage.
        /// </summary>
        [Description("Horizontal Scroll")]
        HorizontalScroll = 0x0014002a,

        /// <summary>
        ///     Character Report Usage.
        /// </summary>
        [Description("Character Report")]
        CharacterReport = 0x0014002b,

        /// <summary>
        ///     Display Data Usage.
        /// </summary>
        [Description("Display Data")]
        DisplayData = 0x0014002c,

        /// <summary>
        ///     Display Status Usage.
        /// </summary>
        [Description("Display Status")]
        DisplayStatus = 0x0014002d,

        /// <summary>
        ///     Stat Not Ready Usage.
        /// </summary>
        [Description("Stat Not Ready")]
        StatNotReady = 0x0014002e,

        /// <summary>
        ///     Stat Ready Usage.
        /// </summary>
        [Description("Stat Ready")]
        StatReady = 0x0014002f,

        /// <summary>
        ///     Err Not a loadable character Usage.
        /// </summary>
        [Description("Err Not a loadable character")]
        ErrNotALoadableCharacter = 0x00140030,

        /// <summary>
        ///     Err Font data cannot be read Usage.
        /// </summary>
        [Description("Err Font data cannot be read")]
        ErrFontDataCannotBeRead = 0x00140031,

        /// <summary>
        ///     Cursor Position Report Usage.
        /// </summary>
        [Description("Cursor Position Report")]
        CursorPositionReport = 0x00140032,

        /// <summary>
        ///     Row Usage.
        /// </summary>
        [Description("Row")]
        Row = 0x00140033,

        /// <summary>
        ///     Column Usage.
        /// </summary>
        [Description("Column")]
        Column = 0x00140034,

        /// <summary>
        ///     Rows Usage.
        /// </summary>
        [Description("Rows")]
        Rows = 0x00140035,

        /// <summary>
        ///     Columns Usage.
        /// </summary>
        [Description("Columns")]
        Columns = 0x00140036,

        /// <summary>
        ///     Cursor Pixel Positioning Usage.
        /// </summary>
        [Description("Cursor Pixel Positioning")]
        CursorPixelPositioning = 0x00140037,

        /// <summary>
        ///     Cursor Mode Usage.
        /// </summary>
        [Description("Cursor Mode")]
        CursorMode = 0x00140038,

        /// <summary>
        ///     Cursor Enable Usage.
        /// </summary>
        [Description("Cursor Enable")]
        CursorEnable = 0x00140039,

        /// <summary>
        ///     Cursor Blink Usage.
        /// </summary>
        [Description("Cursor Blink")]
        CursorBlink = 0x0014003a,

        /// <summary>
        ///     Font Report Usage.
        /// </summary>
        [Description("Font Report")]
        FontReport = 0x0014003b,

        /// <summary>
        ///     Font Data Usage.
        /// </summary>
        [Description("Font Data")]
        FontData = 0x0014003c,

        /// <summary>
        ///     Character Width Usage.
        /// </summary>
        [Description("Character Width")]
        CharacterWidth = 0x0014003d,

        /// <summary>
        ///     Character Height Usage.
        /// </summary>
        [Description("Character Height")]
        CharacterHeight = 0x0014003e,

        /// <summary>
        ///     Character Spacing Horizontal Usage.
        /// </summary>
        [Description("Character Spacing Horizontal")]
        CharacterSpacingHorizontal = 0x0014003f,

        /// <summary>
        ///     Character Spacing Vertical Usage.
        /// </summary>
        [Description("Character Spacing Vertical")]
        CharacterSpacingVertical = 0x00140040,

        /// <summary>
        ///     Unicode Character Set Usage.
        /// </summary>
        [Description("Unicode Character Set")]
        UnicodeCharacterSet = 0x00140041,

        /// <summary>
        ///     Font 7-Segment Usage.
        /// </summary>
        [Description("Font 7-Segment")]
        Font7Segment = 0x00140042,

        /// <summary>
        ///     7-Segment Direct Map Usage.
        /// </summary>
        [Description("7-Segment Direct Map")]
        SegmentDirectMap = 0x00140043,

        /// <summary>
        ///     Font 14-Segment Usage.
        /// </summary>
        [Description("Font 14-Segment")]
        Font14Segment = 0x00140044,

        /// <summary>
        ///     14-Segment Direct Map Usage.
        /// </summary>
        [Description("14-Segment Direct Map")]
        SegmentDirectMap2 = 0x00140045,

        /// <summary>
        ///     Display Brightness Usage.
        /// </summary>
        [Description("Display Brightness")]
        DisplayBrightness = 0x00140046,

        /// <summary>
        ///     Display Contrast Usage.
        /// </summary>
        [Description("Display Contrast")]
        DisplayContrast = 0x00140047,

        /// <summary>
        ///     Character Attribute Usage.
        /// </summary>
        [Description("Character Attribute")]
        CharacterAttribute = 0x00140048,

        /// <summary>
        ///     Attribute Readback Usage.
        /// </summary>
        [Description("Attribute Readback")]
        AttributeReadback = 0x00140049,

        /// <summary>
        ///     Attribute Data Usage.
        /// </summary>
        [Description("Attribute Data")]
        AttributeData = 0x0014004a,

        /// <summary>
        ///     Char Attr Enhance Usage.
        /// </summary>
        [Description("Char Attr Enhance")]
        CharAttrEnhance = 0x0014004b,

        /// <summary>
        ///     Char Attr Underline Usage.
        /// </summary>
        [Description("Char Attr Underline")]
        CharAttrUnderline = 0x0014004c,

        /// <summary>
        ///     Char Attr Blink Usage.
        /// </summary>
        [Description("Char Attr Blink")]
        CharAttrBlink = 0x0014004d,

        /// <summary>
        ///     Bitmap Size X Usage.
        /// </summary>
        [Description("Bitmap Size X")]
        BitmapSizeX = 0x00140080,

        /// <summary>
        ///     Bitmap Size Y Usage.
        /// </summary>
        [Description("Bitmap Size Y")]
        BitmapSizeY = 0x00140081,

        /// <summary>
        ///     Max Blit Size Usage.
        /// </summary>
        [Description("Max Blit Size")]
        MaxBlitSize = 0x00140082,

        /// <summary>
        ///     Bit Depth Format Usage.
        /// </summary>
        [Description("Bit Depth Format")]
        BitDepthFormat = 0x00140083,

        /// <summary>
        ///     Display Orientation Usage.
        /// </summary>
        [Description("Display Orientation")]
        DisplayOrientation = 0x00140084,

        /// <summary>
        ///     Palette Report Usage.
        /// </summary>
        [Description("Palette Report")]
        PaletteReport = 0x00140085,

        /// <summary>
        ///     Palette Data Size Usage.
        /// </summary>
        [Description("Palette Data Size")]
        PaletteDataSize = 0x00140086,

        /// <summary>
        ///     Palette Data Offset Usage.
        /// </summary>
        [Description("Palette Data Offset")]
        PaletteDataOffset = 0x00140087,

        /// <summary>
        ///     Palette Data Usage.
        /// </summary>
        [Description("Palette Data")]
        PaletteData = 0x00140088,

        /// <summary>
        ///     Blit Report Usage.
        /// </summary>
        [Description("Blit Report")]
        BlitReport = 0x0014008a,

        /// <summary>
        ///     Blit Rectangle X1 Usage.
        /// </summary>
        [Description("Blit Rectangle X1")]
        BlitRectangleX1 = 0x0014008b,

        /// <summary>
        ///     Blit Rectangle Y1 Usage.
        /// </summary>
        [Description("Blit Rectangle Y1")]
        BlitRectangleY1 = 0x0014008c,

        /// <summary>
        ///     Blit Rectangle X2 Usage.
        /// </summary>
        [Description("Blit Rectangle X2")]
        BlitRectangleX2 = 0x0014008d,

        /// <summary>
        ///     Blit Rectangle Y2 Usage.
        /// </summary>
        [Description("Blit Rectangle Y2")]
        BlitRectangleY2 = 0x0014008e,

        /// <summary>
        ///     Blit Data Usage.
        /// </summary>
        [Description("Blit Data")]
        BlitData = 0x0014008f,

        /// <summary>
        ///     Soft Button Usage.
        /// </summary>
        [Description("Soft Button")]
        SoftButton = 0x00140090,

        /// <summary>
        ///     Soft Button ID Usage.
        /// </summary>
        [Description("Soft Button ID")]
        SoftButtonID = 0x00140091,

        /// <summary>
        ///     Soft Button Side Usage.
        /// </summary>
        [Description("Soft Button Side")]
        SoftButtonSide = 0x00140092,

        /// <summary>
        ///     Soft Button Offset 1 Usage.
        /// </summary>
        [Description("Soft Button Offset 1")]
        SoftButtonOffset1 = 0x00140093,

        /// <summary>
        ///     Soft Button Offset 2 Usage.
        /// </summary>
        [Description("Soft Button Offset 2")]
        SoftButtonOffset2 = 0x00140094,

        /// <summary>
        ///     Soft Button Report Usage.
        /// </summary>
        [Description("Soft Button Report")]
        SoftButtonReport = 0x00140095
    }

    /// <summary>
    ///     Sensor Usage Page.
    /// </summary>
    [Description("Sensor Usage Page")]
    public enum SensorPage : uint
    {
        /// <summary>
        ///     Undefined Usage.
        /// </summary>
        [Description("Undefined")]
        Undefined = 0x00200000,

        /// <summary>
        ///     Sensor Usage.
        /// </summary>
        [Description("Sensor")]
        Sensor = 0x00200001,

        /// <summary>
        ///     Biometric Usage.
        /// </summary>
        [Description("Biometric")]
        Biometric = 0x00200010,

        /// <summary>
        ///     Biometric: Human Presence Usage.
        /// </summary>
        [Description("Biometric: Human Presence")]
        BiometricHumanPresence = 0x00200011,

        /// <summary>
        ///     Biometric: Human Proximity Usage.
        /// </summary>
        [Description("Biometric: Human Proximity")]
        BiometricHumanProximity = 0x00200012,

        /// <summary>
        ///     Biometric: Human Touch Usage.
        /// </summary>
        [Description("Biometric: Human Touch")]
        BiometricHumanTouch = 0x00200013,

        /// <summary>
        ///     Biometric: Blood Pressure Usage.
        /// </summary>
        [Description("Biometric: Blood Pressure")]
        BiometricBloodPressure = 0x00200014,

        /// <summary>
        ///     Biometric: Body Temperature Usage.
        /// </summary>
        [Description("Biometric: Body Temperature")]
        BiometricBodyTemperature = 0x00200015,

        /// <summary>
        ///     Biometric: Heart Rate Usage.
        /// </summary>
        [Description("Biometric: Heart Rate")]
        BiometricHeartRate = 0x00200016,

        /// <summary>
        ///     Biometric: Heart Rate Variability Usage.
        /// </summary>
        [Description("Biometric: Heart Rate Variability")]
        BiometricHeartRateVariability = 0x00200017,

        /// <summary>
        ///     Biometric: Peripheral Oxygen Saturation Usage.
        /// </summary>
        [Description("Biometric: Peripheral Oxygen Saturation")]
        BiometricPeripheralOxygenSaturation = 0x00200018,

        /// <summary>
        ///     Biometric: Respiratory Rate Usage.
        /// </summary>
        [Description("Biometric: Respiratory Rate")]
        BiometricRespiratoryRate = 0x00200019,

        /// <summary>
        ///     Electrical Usage.
        /// </summary>
        [Description("Electrical")]
        Electrical = 0x00200020,

        /// <summary>
        ///     Electrical: Capacitance Usage.
        /// </summary>
        [Description("Electrical: Capacitance")]
        ElectricalCapacitance = 0x00200021,

        /// <summary>
        ///     Electrical: Current Usage.
        /// </summary>
        [Description("Electrical: Current")]
        ElectricalCurrent = 0x00200022,

        /// <summary>
        ///     Electrical: Power Usage.
        /// </summary>
        [Description("Electrical: Power")]
        ElectricalPower = 0x00200023,

        /// <summary>
        ///     Electrical: Inductance Usage.
        /// </summary>
        [Description("Electrical: Inductance")]
        ElectricalInductance = 0x00200024,

        /// <summary>
        ///     Electrical: Resistance Usage.
        /// </summary>
        [Description("Electrical: Resistance")]
        ElectricalResistance = 0x00200025,

        /// <summary>
        ///     Electrical: Voltage Usage.
        /// </summary>
        [Description("Electrical: Voltage")]
        ElectricalVoltage = 0x00200026,

        /// <summary>
        ///     Electrical: Potentiometer Usage.
        /// </summary>
        [Description("Electrical: Potentiometer")]
        ElectricalPotentiometer = 0x00200027,

        /// <summary>
        ///     Electrical: Frequency Usage.
        /// </summary>
        [Description("Electrical: Frequency")]
        ElectricalFrequency = 0x00200028,

        /// <summary>
        ///     Electrical: Period Usage.
        /// </summary>
        [Description("Electrical: Period")]
        ElectricalPeriod = 0x00200029,

        /// <summary>
        ///     Environmental Usage.
        /// </summary>
        [Description("Environmental")]
        Environmental = 0x00200030,

        /// <summary>
        ///     Environmental: Atmospheric Pressure Usage.
        /// </summary>
        [Description("Environmental: Atmospheric Pressure")]
        EnvironmentalAtmosphericPressure = 0x00200031,

        /// <summary>
        ///     Environmental: Humidity Usage.
        /// </summary>
        [Description("Environmental: Humidity")]
        EnvironmentalHumidity = 0x00200032,

        /// <summary>
        ///     Environmental: Temperature Usage.
        /// </summary>
        [Description("Environmental: Temperature")]
        EnvironmentalTemperature = 0x00200033,

        /// <summary>
        ///     Environmental: Wind Direction Usage.
        /// </summary>
        [Description("Environmental: Wind Direction")]
        EnvironmentalWindDirection = 0x00200034,

        /// <summary>
        ///     Environmental: Wind Speed Usage.
        /// </summary>
        [Description("Environmental: Wind Speed")]
        EnvironmentalWindSpeed = 0x00200035,

        /// <summary>
        ///     Environmental: Air Quality Usage.
        /// </summary>
        [Description("Environmental: Air Quality")]
        EnvironmentalAirQuality = 0x00200036,

        /// <summary>
        ///     Environmental: Heat Index Usage.
        /// </summary>
        [Description("Environmental: Heat Index")]
        EnvironmentalHeatIndex = 0x00200037,

        /// <summary>
        ///     Environmental: Surface Temperature Usage.
        /// </summary>
        [Description("Environmental: Surface Temperature")]
        EnvironmentalSurfaceTemperature = 0x00200038,

        /// <summary>
        ///     Environmental: Volatile Organic Compounds Usage.
        /// </summary>
        [Description("Environmental: Volatile Organic Compounds")]
        EnvironmentalVolatileOrganicCompounds = 0x00200039,

        /// <summary>
        ///     Light Usage.
        /// </summary>
        [Description("Light")]
        Light = 0x00200040,

        /// <summary>
        ///     Light: Ambient Light Usage.
        /// </summary>
        [Description("Light: Ambient Light")]
        LightAmbientLight = 0x00200041,

        /// <summary>
        ///     Light: Consumer Infrared Usage.
        /// </summary>
        [Description("Light: Consumer Infrared")]
        LightConsumerInfrared = 0x00200042,

        /// <summary>
        ///     Light: Infrared Light Usage.
        /// </summary>
        [Description("Light: Infrared Light")]
        LightInfraredLight = 0x00200043,

        /// <summary>
        ///     Light: Visible Light Usage.
        /// </summary>
        [Description("Light: Visible Light")]
        LightVisibleLight = 0x00200044,

        /// <summary>
        ///     Light: Ultraviolet Light Usage.
        /// </summary>
        [Description("Light: Ultraviolet Light")]
        LightUltravioletLight = 0x00200045,

        /// <summary>
        ///     Location Usage.
        /// </summary>
        [Description("Location")]
        Location = 0x00200050,

        /// <summary>
        ///     Location: Broadcast Usage.
        /// </summary>
        [Description("Location: Broadcast")]
        LocationBroadcast = 0x00200051,

        /// <summary>
        ///     Location: Dead Reckoning Usage.
        /// </summary>
        [Description("Location: Dead Reckoning")]
        LocationDeadReckoning = 0x00200052,

        /// <summary>
        ///     Location: GPS Usage.
        /// </summary>
        [Description("Location: GPS")]
        LocationGPS = 0x00200053,

        /// <summary>
        ///     Location: Lookup Usage.
        /// </summary>
        [Description("Location: Lookup")]
        LocationLookup = 0x00200054,

        /// <summary>
        ///     Location: Other Usage.
        /// </summary>
        [Description("Location: Other")]
        LocationOther = 0x00200055,

        /// <summary>
        ///     Location: Static Usage.
        /// </summary>
        [Description("Location: Static")]
        LocationStatic = 0x00200056,

        /// <summary>
        ///     Location: Triangulation Usage.
        /// </summary>
        [Description("Location: Triangulation")]
        LocationTriangulation = 0x00200057,

        /// <summary>
        ///     Mechanical Usage.
        /// </summary>
        [Description("Mechanical")]
        Mechanical = 0x00200060,

        /// <summary>
        ///     Mechanical: Boolean Switch Usage.
        /// </summary>
        [Description("Mechanical: Boolean Switch")]
        MechanicalBooleanSwitch = 0x00200061,

        /// <summary>
        ///     Mechanical: Boolean Switch Array Usage.
        /// </summary>
        [Description("Mechanical: Boolean Switch Array")]
        MechanicalBooleanSwitchArray = 0x00200062,

        /// <summary>
        ///     Mechanical: Multivalue Switch Usage.
        /// </summary>
        [Description("Mechanical: Multivalue Switch")]
        MechanicalMultivalueSwitch = 0x00200063,

        /// <summary>
        ///     Mechanical: Force Usage.
        /// </summary>
        [Description("Mechanical: Force")]
        MechanicalForce = 0x00200064,

        /// <summary>
        ///     Mechanical: Pressure Usage.
        /// </summary>
        [Description("Mechanical: Pressure")]
        MechanicalPressure = 0x00200065,

        /// <summary>
        ///     Mechanical: Strain Usage.
        /// </summary>
        [Description("Mechanical: Strain")]
        MechanicalStrain = 0x00200066,

        /// <summary>
        ///     Mechanical: Weight Usage.
        /// </summary>
        [Description("Mechanical: Weight")]
        MechanicalWeight = 0x00200067,

        /// <summary>
        ///     Mechanical: Haptic Vibrator Usage.
        /// </summary>
        [Description("Mechanical: Haptic Vibrator")]
        MechanicalHapticVibrator = 0x00200068,

        /// <summary>
        ///     Mechanical: Hall Effect Switch Usage.
        /// </summary>
        [Description("Mechanical: Hall Effect Switch")]
        MechanicalHallEffectSwitch = 0x00200069,

        /// <summary>
        ///     Motion Usage.
        /// </summary>
        [Description("Motion")]
        Motion = 0x00200070,

        /// <summary>
        ///     Motion: Accelerometer 1D Usage.
        /// </summary>
        [Description("Motion: Accelerometer 1D")]
        MotionAccelerometer1D = 0x00200071,

        /// <summary>
        ///     Motion: Accelerometer 2D Usage.
        /// </summary>
        [Description("Motion: Accelerometer 2D")]
        MotionAccelerometer2D = 0x00200072,

        /// <summary>
        ///     Motion: Accelerometer 3D Usage.
        /// </summary>
        [Description("Motion: Accelerometer 3D")]
        MotionAccelerometer3D = 0x00200073,

        /// <summary>
        ///     Motion: Gyrometer 1D Usage.
        /// </summary>
        [Description("Motion: Gyrometer 1D")]
        MotionGyrometer1D = 0x00200074,

        /// <summary>
        ///     Motion: Gyrometer 2D Usage.
        /// </summary>
        [Description("Motion: Gyrometer 2D")]
        MotionGyrometer2D = 0x00200075,

        /// <summary>
        ///     Motion: Gyrometer 3D Usage.
        /// </summary>
        [Description("Motion: Gyrometer 3D")]
        MotionGyrometer3D = 0x00200076,

        /// <summary>
        ///     Motion: Motion Detector Usage.
        /// </summary>
        [Description("Motion: Motion Detector")]
        MotionMotionDetector = 0x00200077,

        /// <summary>
        ///     Motion: Speedometer Usage.
        /// </summary>
        [Description("Motion: Speedometer")]
        MotionSpeedometer = 0x00200078,

        /// <summary>
        ///     Motion: Accelerometer Usage.
        /// </summary>
        [Description("Motion: Accelerometer")]
        MotionAccelerometer = 0x00200079,

        /// <summary>
        ///     Motion: Gyrometer Usage.
        /// </summary>
        [Description("Motion: Gyrometer")]
        MotionGyrometer = 0x0020007a,

        /// <summary>
        ///     Motion: Gravity Vector Usage.
        /// </summary>
        [Description("Motion: Gravity Vector")]
        MotionGravityVector = 0x0020007b,

        /// <summary>
        ///     Motion: Linear Accelerometer Usage.
        /// </summary>
        [Description("Motion: Linear Accelerometer")]
        MotionLinearAccelerometer = 0x0020007c,

        /// <summary>
        ///     Orientation Usage.
        /// </summary>
        [Description("Orientation")]
        Orientation = 0x00200080,

        /// <summary>
        ///     Orientation: Compass 1D Usage.
        /// </summary>
        [Description("Orientation: Compass 1D")]
        OrientationCompass1D = 0x00200081,

        /// <summary>
        ///     Orientation: Compass 2D Usage.
        /// </summary>
        [Description("Orientation: Compass 2D")]
        OrientationCompass2D = 0x00200082,

        /// <summary>
        ///     Orientation: Compass 3D Usage.
        /// </summary>
        [Description("Orientation: Compass 3D")]
        OrientationCompass3D = 0x00200083,

        /// <summary>
        ///     Orientation: Inclinometer 1D Usage.
        /// </summary>
        [Description("Orientation: Inclinometer 1D")]
        OrientationInclinometer1D = 0x00200084,

        /// <summary>
        ///     Orientation: Inclinometer 2D Usage.
        /// </summary>
        [Description("Orientation: Inclinometer 2D")]
        OrientationInclinometer2D = 0x00200085,

        /// <summary>
        ///     Orientation: Inclinometer 3D Usage.
        /// </summary>
        [Description("Orientation: Inclinometer 3D")]
        OrientationInclinometer3D = 0x00200086,

        /// <summary>
        ///     Orientation: Distance 1D Usage.
        /// </summary>
        [Description("Orientation: Distance 1D")]
        OrientationDistance1D = 0x00200087,

        /// <summary>
        ///     Orientation: Distance 2D Usage.
        /// </summary>
        [Description("Orientation: Distance 2D")]
        OrientationDistance2D = 0x00200088,

        /// <summary>
        ///     Orientation: Distance 3D Usage.
        /// </summary>
        [Description("Orientation: Distance 3D")]
        OrientationDistance3D = 0x00200089,

        /// <summary>
        ///     Orientation: Device Orientation Usage.
        /// </summary>
        [Description("Orientation: Device Orientation")]
        OrientationDeviceOrientation = 0x0020008a,

        /// <summary>
        ///     Orientation: Compass Usage.
        /// </summary>
        [Description("Orientation: Compass")]
        OrientationCompass = 0x0020008b,

        /// <summary>
        ///     Orientation: Inclinometer Usage.
        /// </summary>
        [Description("Orientation: Inclinometer")]
        OrientationInclinometer = 0x0020008c,

        /// <summary>
        ///     Orientation: Distance Usage.
        /// </summary>
        [Description("Orientation: Distance")]
        OrientationDistance = 0x0020008d,

        /// <summary>
        ///     Orientation: Relative Orientation Usage.
        /// </summary>
        [Description("Orientation: Relative Orientation")]
        OrientationRelativeOrientation = 0x0020008e,

        /// <summary>
        ///     Orientation: Simple Orientation Usage.
        /// </summary>
        [Description("Orientation: Simple Orientation")]
        OrientationSimpleOrientation = 0x0020008f,

        /// <summary>
        ///     Scanner Usage.
        /// </summary>
        [Description("Scanner")]
        Scanner = 0x00200090,

        /// <summary>
        ///     Scanner: Barcode Usage.
        /// </summary>
        [Description("Scanner: Barcode")]
        ScannerBarcode = 0x00200091,

        /// <summary>
        ///     Scanner: RFID Usage.
        /// </summary>
        [Description("Scanner: RFID")]
        ScannerRFID = 0x00200092,

        /// <summary>
        ///     Scanner: NFC Usage.
        /// </summary>
        [Description("Scanner: NFC")]
        ScannerNFC = 0x00200093,

        /// <summary>
        ///     Time Usage.
        /// </summary>
        [Description("Time")]
        Time = 0x002000a0,

        /// <summary>
        ///     Time: Alarm Timer Usage.
        /// </summary>
        [Description("Time: Alarm Timer")]
        TimeAlarmTimer = 0x002000a1,

        /// <summary>
        ///     Time: Real Time Clock Usage.
        /// </summary>
        [Description("Time: Real Time Clock")]
        TimeRealTimeClock = 0x002000a2,

        /// <summary>
        ///     Personal Activity Usage.
        /// </summary>
        [Description("Personal Activity")]
        PersonalActivity = 0x002000b0,

        /// <summary>
        ///     Personal Activity: Activity Detection Usage.
        /// </summary>
        [Description("Personal Activity: Activity Detection")]
        PersonalActivityActivityDetection = 0x002000b1,

        /// <summary>
        ///     Personal Activity: Device Position Usage.
        /// </summary>
        [Description("Personal Activity: Device Position")]
        PersonalActivityDevicePosition = 0x002000b2,

        /// <summary>
        ///     Personal Activity: Pedometer Usage.
        /// </summary>
        [Description("Personal Activity: Pedometer")]
        PersonalActivityPedometer = 0x002000b3,

        /// <summary>
        ///     Personal Activity: Step Detection Usage.
        /// </summary>
        [Description("Personal Activity: Step Detection")]
        PersonalActivityStepDetection = 0x002000b4,

        /// <summary>
        ///     Orientation Extended Usage.
        /// </summary>
        [Description("Orientation Extended")]
        OrientationExtended = 0x002000c0,

        /// <summary>
        ///     Orientation Extended: Geomagnetic Orientation Usage.
        /// </summary>
        [Description("Orientation Extended: Geomagnetic Orientation")]
        OrientationExtendedGeomagneticOrientation = 0x002000c1,

        /// <summary>
        ///     Orientation Extended: Magnetometer Usage.
        /// </summary>
        [Description("Orientation Extended: Magnetometer")]
        OrientationExtendedMagnetometer = 0x002000c2,

        /// <summary>
        ///     Gesture Usage.
        /// </summary>
        [Description("Gesture")]
        Gesture = 0x002000d0,

        /// <summary>
        ///     Gesture: Chassis Flip Gesture Usage.
        /// </summary>
        [Description("Gesture: Chassis Flip Gesture")]
        GestureChassisFlipGesture = 0x002000d1,

        /// <summary>
        ///     Gesture: Hinge Fold Gesture Usage.
        /// </summary>
        [Description("Gesture: Hinge Fold Gesture")]
        GestureHingeFoldGesture = 0x002000d2,

        /// <summary>
        ///     Other Usage.
        /// </summary>
        [Description("Other")]
        Other = 0x002000e0,

        /// <summary>
        ///     Other: Custom Usage.
        /// </summary>
        [Description("Other: Custom")]
        OtherCustom = 0x002000e1,

        /// <summary>
        ///     Other: Generic Usage.
        /// </summary>
        [Description("Other: Generic")]
        OtherGeneric = 0x002000e2,

        /// <summary>
        ///     Other: Generic Enumerator Usage.
        /// </summary>
        [Description("Other: Generic Enumerator")]
        OtherGenericEnumerator = 0x002000e3,

        /// <summary>
        ///     Other: Hinge Angle Usage.
        /// </summary>
        [Description("Other: Hinge Angle")]
        OtherHingeAngle = 0x002000e4,

        /// <summary>
        ///     Event: Sensor State Usage.
        /// </summary>
        [Description("Event: Sensor State")]
        EventSensorState = 0x00200201,

        /// <summary>
        ///     Event: Sensor Event Usage.
        /// </summary>
        [Description("Event: Sensor Event")]
        EventSensorEvent = 0x00200202,

        /// <summary>
        ///     Property: Friendly Name Usage.
        /// </summary>
        [Description("Property: Friendly Name")]
        PropertyFriendlyName = 0x00200301,

        /// <summary>
        ///     Property: Persistent Unique ID Usage.
        /// </summary>
        [Description("Property: Persistent Unique ID")]
        PropertyPersistentUniqueID = 0x00200302,

        /// <summary>
        ///     Property: Sensor Status Usage.
        /// </summary>
        [Description("Property: Sensor Status")]
        PropertySensorStatus = 0x00200303,

        /// <summary>
        ///     Property: Minimum Report Interval Usage.
        /// </summary>
        [Description("Property: Minimum Report Interval")]
        PropertyMinimumReportInterval = 0x00200304,

        /// <summary>
        ///     Property: Sensor Manufacturer Usage.
        /// </summary>
        [Description("Property: Sensor Manufacturer")]
        PropertySensorManufacturer = 0x00200305,

        /// <summary>
        ///     Property: Sensor Model Usage.
        /// </summary>
        [Description("Property: Sensor Model")]
        PropertySensorModel = 0x00200306,

        /// <summary>
        ///     Property: Sensor Serial Number Usage.
        /// </summary>
        [Description("Property: Sensor Serial Number")]
        PropertySensorSerialNumber = 0x00200307,

        /// <summary>
        ///     Property: Sensor Description Usage.
        /// </summary>
        [Description("Property: Sensor Description")]
        PropertySensorDescription = 0x00200308,

        /// <summary>
        ///     Property: Sensor Connection Type Usage.
        /// </summary>
        [Description("Property: Sensor Connection Type")]
        PropertySensorConnectionType = 0x00200309,

        /// <summary>
        ///     Property: Sensor Device Path Usage.
        /// </summary>
        [Description("Property: Sensor Device Path")]
        PropertySensorDevicePath = 0x0020030a,

        /// <summary>
        ///     Property: Sensor Hardware Revision Usage.
        /// </summary>
        [Description("Property: Sensor Hardware Revision")]
        PropertySensorHardwareRevision = 0x0020030b,

        /// <summary>
        ///     Property: Sensor Firmware Revision Usage.
        /// </summary>
        [Description("Property: Sensor Firmware Revision")]
        PropertySensorFirmwareRevision = 0x0020030c,

        /// <summary>
        ///     Property: Release Date Usage.
        /// </summary>
        [Description("Property: Release Date")]
        PropertyReleaseDate = 0x0020030d,

        /// <summary>
        ///     Property: Report Interval Usage.
        /// </summary>
        [Description("Property: Report Interval")]
        PropertyReportInterval = 0x0020030e,

        /// <summary>
        ///     Property: Change Sensitivity Absolute Usage.
        /// </summary>
        [Description("Property: Change Sensitivity Absolute")]
        PropertyChangeSensitivityAbsolute = 0x0020030f,

        /// <summary>
        ///     Property: Change Sensitivity Percent of Range Usage.
        /// </summary>
        [Description("Property: Change Sensitivity Percent of Range")]
        PropertyChangeSensitivityPercentOfRange = 0x00200310,

        /// <summary>
        ///     Property: Change Sensitivity Percent Relative Usage.
        /// </summary>
        [Description("Property: Change Sensitivity Percent Relative")]
        PropertyChangeSensitivityPercentRelative = 0x00200311,

        /// <summary>
        ///     Property: Accuracy Usage.
        /// </summary>
        [Description("Property: Accuracy")]
        PropertyAccuracy = 0x00200312,

        /// <summary>
        ///     Property: Resolution Usage.
        /// </summary>
        [Description("Property: Resolution")]
        PropertyResolution = 0x00200313,

        /// <summary>
        ///     Property: Maximum Usage.
        /// </summary>
        [Description("Property: Maximum")]
        PropertyMaximum = 0x00200314,

        /// <summary>
        ///     Property: Minimum Usage.
        /// </summary>
        [Description("Property: Minimum")]
        PropertyMinimum = 0x00200315,

        /// <summary>
        ///     Property: Reporting State Usage.
        /// </summary>
        [Description("Property: Reporting State")]
        PropertyReportingState = 0x00200316,

        /// <summary>
        ///     Property: Sampling Rate Usage.
        /// </summary>
        [Description("Property: Sampling Rate")]
        PropertySamplingRate = 0x00200317,

        /// <summary>
        ///     Property: Response Curve Usage.
        /// </summary>
        [Description("Property: Response Curve")]
        PropertyResponseCurve = 0x00200318,

        /// <summary>
        ///     Property: Power State Usage.
        /// </summary>
        [Description("Property: Power State")]
        PropertyPowerState = 0x00200319,

        /// <summary>
        ///     Property: Maximum FIFO Events Usage.
        /// </summary>
        [Description("Property: Maximum FIFO Events")]
        PropertyMaximumFIFOEvents = 0x0020031a,

        /// <summary>
        ///     Property: Report Latency Usage.
        /// </summary>
        [Description("Property: Report Latency")]
        PropertyReportLatency = 0x0020031b,

        /// <summary>
        ///     Property: Flush FIFO Events Usage.
        /// </summary>
        [Description("Property: Flush FIFO Events")]
        PropertyFlushFIFOEvents = 0x0020031c,

        /// <summary>
        ///     Property: Maximum Power Consumption Usage.
        /// </summary>
        [Description("Property: Maximum Power Consumption")]
        PropertyMaximumPowerConsumption = 0x0020031d,

        /// <summary>
        ///     Data Field: Location Usage.
        /// </summary>
        [Description("Data Field: Location")]
        DataFieldLocation = 0x00200400,

        /// <summary>
        ///     Data Field: Altitude Antenna Sea Level Usage.
        /// </summary>
        [Description("Data Field: Altitude Antenna Sea Level")]
        DataFieldAltitudeAntennaSeaLevel = 0x00200402,

        /// <summary>
        ///     Data Field: Differential Reference Station ID Usage.
        /// </summary>
        [Description("Data Field: Differential Reference Station ID")]
        DataFieldDifferentialReferenceStationID = 0x00200403,

        /// <summary>
        ///     Data Field: Altitude Ellipsoid Error Usage.
        /// </summary>
        [Description("Data Field: Altitude Ellipsoid Error")]
        DataFieldAltitudeEllipsoidError = 0x00200404,

        /// <summary>
        ///     Data Field: Altitude Ellipsoid Usage.
        /// </summary>
        [Description("Data Field: Altitude Ellipsoid")]
        DataFieldAltitudeEllipsoid = 0x00200405,

        /// <summary>
        ///     Data Field: Altitude Sea Level Error Usage.
        /// </summary>
        [Description("Data Field: Altitude Sea Level Error")]
        DataFieldAltitudeSeaLevelError = 0x00200406,

        /// <summary>
        ///     Data Field: Altitude Sea Level Usage.
        /// </summary>
        [Description("Data Field: Altitude Sea Level")]
        DataFieldAltitudeSeaLevel = 0x00200407,

        /// <summary>
        ///     Data Field: Differential GPS Data Age Usage.
        /// </summary>
        [Description("Data Field: Differential GPS Data Age")]
        DataFieldDifferentialGPSDataAge = 0x00200408,

        /// <summary>
        ///     Data Field: Error Radius Usage.
        /// </summary>
        [Description("Data Field: Error Radius")]
        DataFieldErrorRadius = 0x00200409,

        /// <summary>
        ///     Data Field: Fix Quality Usage.
        /// </summary>
        [Description("Data Field: Fix Quality")]
        DataFieldFixQuality = 0x0020040a,

        /// <summary>
        ///     Data Field: Fix Type Usage.
        /// </summary>
        [Description("Data Field: Fix Type")]
        DataFieldFixType = 0x0020040b,

        /// <summary>
        ///     Data Field: Geoidal Separation Usage.
        /// </summary>
        [Description("Data Field: Geoidal Separation")]
        DataFieldGeoidalSeparation = 0x0020040c,

        /// <summary>
        ///     Data Field: GPS Operation Mode Usage.
        /// </summary>
        [Description("Data Field: GPS Operation Mode")]
        DataFieldGPSOperationMode = 0x0020040d,

        /// <summary>
        ///     Data Field: GPS Selection Mode Usage.
        /// </summary>
        [Description("Data Field: GPS Selection Mode")]
        DataFieldGPSSelectionMode = 0x0020040e,

        /// <summary>
        ///     Data Field: GPS Status Usage.
        /// </summary>
        [Description("Data Field: GPS Status")]
        DataFieldGPSStatus = 0x0020040f,

        /// <summary>
        ///     Data Field: Position Dilution of Precision Usage.
        /// </summary>
        [Description("Data Field: Position Dilution of Precision")]
        DataFieldPositionDilutionOfPrecision = 0x00200410,

        /// <summary>
        ///     Data Field: Horizontal Dilution of Precision Usage.
        /// </summary>
        [Description("Data Field: Horizontal Dilution of Precision")]
        DataFieldHorizontalDilutionOfPrecision = 0x00200411,

        /// <summary>
        ///     Data Field: Vertical Dilution of Precision Usage.
        /// </summary>
        [Description("Data Field: Vertical Dilution of Precision")]
        DataFieldVerticalDilutionOfPrecision = 0x00200412,

        /// <summary>
        ///     Data Field: Latitude Usage.
        /// </summary>
        [Description("Data Field: Latitude")]
        DataFieldLatitude = 0x00200413,

        /// <summary>
        ///     Data Field: Longitude Usage.
        /// </summary>
        [Description("Data Field: Longitude")]
        DataFieldLongitude = 0x00200414,

        /// <summary>
        ///     Data Field: True Heading Usage.
        /// </summary>
        [Description("Data Field: True Heading")]
        DataFieldTrueHeading = 0x00200415,

        /// <summary>
        ///     Data Field: Magnetic Heading Usage.
        /// </summary>
        [Description("Data Field: Magnetic Heading")]
        DataFieldMagneticHeading = 0x00200416,

        /// <summary>
        ///     Data Field: Magnetic Variation Usage.
        /// </summary>
        [Description("Data Field: Magnetic Variation")]
        DataFieldMagneticVariation = 0x00200417,

        /// <summary>
        ///     Data Field: Speed Usage.
        /// </summary>
        [Description("Data Field: Speed")]
        DataFieldSpeed = 0x00200418,

        /// <summary>
        ///     Data Field: Satellites in View Usage.
        /// </summary>
        [Description("Data Field: Satellites in View")]
        DataFieldSatellitesInView = 0x00200419,

        /// <summary>
        ///     Data Field: Satellites in View Azimuth Usage.
        /// </summary>
        [Description("Data Field: Satellites in View Azimuth")]
        DataFieldSatellitesInViewAzimuth = 0x0020041a,

        /// <summary>
        ///     Data Field: Satellites in View Elevation Usage.
        /// </summary>
        [Description("Data Field: Satellites in View Elevation")]
        DataFieldSatellitesInViewElevation = 0x0020041b,

        /// <summary>
        ///     Data Field: Satellites in View IDs Usage.
        /// </summary>
        [Description("Data Field: Satellites in View IDs")]
        DataFieldSatellitesInViewIDs = 0x0020041c,

        /// <summary>
        ///     Data Field: Satellites in View PRNs Usage.
        /// </summary>
        [Description("Data Field: Satellites in View PRNs")]
        DataFieldSatellitesInViewPRNs = 0x0020041d,

        /// <summary>
        ///     Data Field: Satellites in View S/N Ratios Usage.
        /// </summary>
        [Description("Data Field: Satellites in View S/N Ratios")]
        DataFieldSatellitesInViewSNRatios = 0x0020041e,

        /// <summary>
        ///     Data Field: Satellites Used Count Usage.
        /// </summary>
        [Description("Data Field: Satellites Used Count")]
        DataFieldSatellitesUsedCount = 0x0020041f,

        /// <summary>
        ///     Data Field: Satellites Used PRNs Usage.
        /// </summary>
        [Description("Data Field: Satellites Used PRNs")]
        DataFieldSatellitesUsedPRNs = 0x00200420,

        /// <summary>
        ///     Data Field: NMEA Sentence Usage.
        /// </summary>
        [Description("Data Field: NMEA Sentence")]
        DataFieldNMEASentence = 0x00200421,

        /// <summary>
        ///     Data Field: Address Line 1 Usage.
        /// </summary>
        [Description("Data Field: Address Line 1")]
        DataFieldAddressLine1 = 0x00200422,

        /// <summary>
        ///     Data Field: Address Line 2 Usage.
        /// </summary>
        [Description("Data Field: Address Line 2")]
        DataFieldAddressLine2 = 0x00200423,

        /// <summary>
        ///     Data Field: City Usage.
        /// </summary>
        [Description("Data Field: City")]
        DataFieldCity = 0x00200424,

        /// <summary>
        ///     Data Field: State or Province Usage.
        /// </summary>
        [Description("Data Field: State or Province")]
        DataFieldStateOrProvince = 0x00200425,

        /// <summary>
        ///     Data Field: Country or Region (ISO 3166) Usage.
        /// </summary>
        [Description("Data Field: Country or Region (ISO 3166)")]
        DataFieldCountryOrRegionISO3166 = 0x00200426,

        /// <summary>
        ///     Data Field: Postal Code Usage.
        /// </summary>
        [Description("Data Field: Postal Code")]
        DataFieldPostalCode = 0x00200427,

        /// <summary>
        ///     Property: Location Desired Accuracy Usage.
        /// </summary>
        [Description("Property: Location Desired Accuracy")]
        PropertyLocationDesiredAccuracy = 0x0020042b,

        /// <summary>
        ///     Data Field: Environmental Usage.
        /// </summary>
        [Description("Data Field: Environmental")]
        DataFieldEnvironmental = 0x00200430,

        /// <summary>
        ///     Data Field: Atmospheric Pressure Usage.
        /// </summary>
        [Description("Data Field: Atmospheric Pressure")]
        DataFieldAtmosphericPressure = 0x00200431,

        /// <summary>
        ///     Data Field: Relative Humidity Usage.
        /// </summary>
        [Description("Data Field: Relative Humidity")]
        DataFieldRelativeHumidity = 0x00200433,

        /// <summary>
        ///     Data Field: Temperature Usage.
        /// </summary>
        [Description("Data Field: Temperature")]
        DataFieldTemperature = 0x00200434,

        /// <summary>
        ///     Data Field: Wind Direction Usage.
        /// </summary>
        [Description("Data Field: Wind Direction")]
        DataFieldWindDirection = 0x00200435,

        /// <summary>
        ///     Data Field: Wind Speed Usage.
        /// </summary>
        [Description("Data Field: Wind Speed")]
        DataFieldWindSpeed = 0x00200436,

        /// <summary>
        ///     Data Field: Air Quality Index Usage.
        /// </summary>
        [Description("Data Field: Air Quality Index")]
        DataFieldAirQualityIndex = 0x00200437,

        /// <summary>
        ///     Data Field: Equivalent CO2 Usage.
        /// </summary>
        [Description("Data Field: Equivalent CO2")]
        DataFieldEquivalentCO2 = 0x00200438,

        /// <summary>
        ///     Data Field: Volatile Organic Compound Concentration Usage.
        /// </summary>
        [Description("Data Field: Volatile Organic Compound Concentration")]
        DataFieldVolatileOrganicCompoundConcentration = 0x00200439,

        /// <summary>
        ///     Property: Environmental Usage.
        /// </summary>
        [Description("Property: Environmental")]
        PropertyEnvironmental = 0x00200440,

        /// <summary>
        ///     Property: Reference Pressure (default Sel "Unit: bars) Usage.
        /// </summary>
        [Description("Property: Reference Pressure (default Sel \"Unit: bars)")]
        PropertyReferencePressureDefaultSelUnitBars = 0x00200441,

        /// <summary>
        ///     Data Field: Motion Usage.
        /// </summary>
        [Description("Data Field: Motion")]
        DataFieldMotion = 0x00200450,

        /// <summary>
        ///     Data Field: Motion State Usage.
        /// </summary>
        [Description("Data Field: Motion State")]
        DataFieldMotionState = 0x00200451,

        /// <summary>
        ///     Data Field: Acceleration Usage.
        /// </summary>
        [Description("Data Field: Acceleration")]
        DataFieldAcceleration = 0x00200452,

        /// <summary>
        ///     Data Field: Acceleration Axis X Usage.
        /// </summary>
        [Description("Data Field: Acceleration Axis X")]
        DataFieldAccelerationAxisX = 0x00200453,

        /// <summary>
        ///     Data Field: Acceleration Axis Y Usage.
        /// </summary>
        [Description("Data Field: Acceleration Axis Y")]
        DataFieldAccelerationAxisY = 0x00200454,

        /// <summary>
        ///     Data Field: Acceleration Axis Z Usage.
        /// </summary>
        [Description("Data Field: Acceleration Axis Z")]
        DataFieldAccelerationAxisZ = 0x00200455,

        /// <summary>
        ///     Data Field: Angular Velocity Usage.
        /// </summary>
        [Description("Data Field: Angular Velocity")]
        DataFieldAngularVelocity = 0x00200456,

        /// <summary>
        ///     Data Field: Angular Velocity X about Axis Usage.
        /// </summary>
        [Description("Data Field: Angular Velocity X about Axis")]
        DataFieldAngularVelocityXAboutAxis = 0x00200457,

        /// <summary>
        ///     Data Field: Angular Velocity Y about Axis Usage.
        /// </summary>
        [Description("Data Field: Angular Velocity Y about Axis")]
        DataFieldAngularVelocityYAboutAxis = 0x00200458,

        /// <summary>
        ///     Data Field: Angular Velocity Z about Axis Usage.
        /// </summary>
        [Description("Data Field: Angular Velocity Z about Axis")]
        DataFieldAngularVelocityZAboutAxis = 0x00200459,

        /// <summary>
        ///     Data Field: Angular Position Usage.
        /// </summary>
        [Description("Data Field: Angular Position")]
        DataFieldAngularPosition = 0x0020045a,

        /// <summary>
        ///     Data Field: Angular Position about X Axis Usage.
        /// </summary>
        [Description("Data Field: Angular Position about X Axis")]
        DataFieldAngularPositionAboutXAxis = 0x0020045b,

        /// <summary>
        ///     Data Field: Angular Position about Y Axis Usage.
        /// </summary>
        [Description("Data Field: Angular Position about Y Axis")]
        DataFieldAngularPositionAboutYAxis = 0x0020045c,

        /// <summary>
        ///     Data Field: Angular Position about Z Axis Usage.
        /// </summary>
        [Description("Data Field: Angular Position about Z Axis")]
        DataFieldAngularPositionAboutZAxis = 0x0020045d,

        /// <summary>
        ///     Data Field: Motion Speed Usage.
        /// </summary>
        [Description("Data Field: Motion Speed")]
        DataFieldMotionSpeed = 0x0020045e,

        /// <summary>
        ///     Data Field: Motion Intensity (percent) Usage.
        /// </summary>
        [Description("Data Field: Motion Intensity (percent)")]
        DataFieldMotionIntensityPercent = 0x0020045f,

        /// <summary>
        ///     Data Field: Orientation Usage.
        /// </summary>
        [Description("Data Field: Orientation")]
        DataFieldOrientation = 0x00200470,

        /// <summary>
        ///     Data Field: Heading Usage.
        /// </summary>
        [Description("Data Field: Heading")]
        DataFieldHeading = 0x00200471,

        /// <summary>
        ///     Data Field: Heading X Axis Usage.
        /// </summary>
        [Description("Data Field: Heading X Axis")]
        DataFieldHeadingXAxis = 0x00200472,

        /// <summary>
        ///     Data Field: Heading Y Axis Usage.
        /// </summary>
        [Description("Data Field: Heading Y Axis")]
        DataFieldHeadingYAxis = 0x00200473,

        /// <summary>
        ///     Data Field: Heading Z Axis Usage.
        /// </summary>
        [Description("Data Field: Heading Z Axis")]
        DataFieldHeadingZAxis = 0x00200474,

        /// <summary>
        ///     Data Field: Heading Compensated Magnetic North Usage.
        /// </summary>
        [Description("Data Field: Heading Compensated Magnetic North")]
        DataFieldHeadingCompensatedMagneticNorth = 0x00200475,

        /// <summary>
        ///     Data Field: Heading Compensated True North Usage.
        /// </summary>
        [Description("Data Field: Heading Compensated True North")]
        DataFieldHeadingCompensatedTrueNorth = 0x00200476,

        /// <summary>
        ///     Data Field: Heading Magnetic North Usage.
        /// </summary>
        [Description("Data Field: Heading Magnetic North")]
        DataFieldHeadingMagneticNorth = 0x00200477,

        /// <summary>
        ///     Data Field: Heading True North Usage.
        /// </summary>
        [Description("Data Field: Heading True North")]
        DataFieldHeadingTrueNorth = 0x00200478,

        /// <summary>
        ///     Data Field: Distance Usage.
        /// </summary>
        [Description("Data Field: Distance")]
        DataFieldDistance = 0x00200479,

        /// <summary>
        ///     Data Field: Distance X Axis Usage.
        /// </summary>
        [Description("Data Field: Distance X Axis")]
        DataFieldDistanceXAxis = 0x0020047a,

        /// <summary>
        ///     Data Field: Distance Y Axis Usage.
        /// </summary>
        [Description("Data Field: Distance Y Axis")]
        DataFieldDistanceYAxis = 0x0020047b,

        /// <summary>
        ///     Data Field: Distance Z Axis Usage.
        /// </summary>
        [Description("Data Field: Distance Z Axis")]
        DataFieldDistanceZAxis = 0x0020047c,

        /// <summary>
        ///     Data Field: Distance Out-of-Range Usage.
        /// </summary>
        [Description("Data Field: Distance Out-of-Range")]
        DataFieldDistanceOutofRange = 0x0020047d,

        /// <summary>
        ///     Data Field: Tilt Usage.
        /// </summary>
        [Description("Data Field: Tilt")]
        DataFieldTilt = 0x0020047e,

        /// <summary>
        ///     Data Field: Tilt X Axis Usage.
        /// </summary>
        [Description("Data Field: Tilt X Axis")]
        DataFieldTiltXAxis = 0x0020047f,

        /// <summary>
        ///     Data Field: Tilt Y Axis Usage.
        /// </summary>
        [Description("Data Field: Tilt Y Axis")]
        DataFieldTiltYAxis = 0x00200480,

        /// <summary>
        ///     Data Field: Tilt Z Axis Usage.
        /// </summary>
        [Description("Data Field: Tilt Z Axis")]
        DataFieldTiltZAxis = 0x00200481,

        /// <summary>
        ///     Data Field: Rotation Matrix Usage.
        /// </summary>
        [Description("Data Field: Rotation Matrix")]
        DataFieldRotationMatrix = 0x00200482,

        /// <summary>
        ///     Data Field: Quaternion Usage.
        /// </summary>
        [Description("Data Field: Quaternion")]
        DataFieldQuaternion = 0x00200483,

        /// <summary>
        ///     Data Field: Magnetic Flux Usage.
        /// </summary>
        [Description("Data Field: Magnetic Flux")]
        DataFieldMagneticFlux = 0x00200484,

        /// <summary>
        ///     Data Field: Magnetic Flux X Axis Usage.
        /// </summary>
        [Description("Data Field: Magnetic Flux X Axis")]
        DataFieldMagneticFluxXAxis = 0x00200485,

        /// <summary>
        ///     Data Field: Magnetic Flux Y Axis Usage.
        /// </summary>
        [Description("Data Field: Magnetic Flux Y Axis")]
        DataFieldMagneticFluxYAxis = 0x00200486,

        /// <summary>
        ///     Data Field: Magnetic Flux Z Axis Usage.
        /// </summary>
        [Description("Data Field: Magnetic Flux Z Axis")]
        DataFieldMagneticFluxZAxis = 0x00200487,

        /// <summary>
        ///     Data Field: Magnetometer Accuracy Usage.
        /// </summary>
        [Description("Data Field: Magnetometer Accuracy")]
        DataFieldMagnetometerAccuracy = 0x00200488,

        /// <summary>
        ///     Data Field: Simple Orientation Direction Usage.
        /// </summary>
        [Description("Data Field: Simple Orientation Direction")]
        DataFieldSimpleOrientationDirection = 0x00200489,

        /// <summary>
        ///     Data Field: Mechanical Usage.
        /// </summary>
        [Description("Data Field: Mechanical")]
        DataFieldMechanical = 0x00200490,

        /// <summary>
        ///     Data Field: Boolean Switch State Usage.
        /// </summary>
        [Description("Data Field: Boolean Switch State")]
        DataFieldBooleanSwitchState = 0x00200491,

        /// <summary>
        ///     Data Field: Boolean Switch Array States Usage.
        /// </summary>
        [Description("Data Field: Boolean Switch Array States")]
        DataFieldBooleanSwitchArrayStates = 0x00200492,

        /// <summary>
        ///     Data Field: Multivalue Switch Value Usage.
        /// </summary>
        [Description("Data Field: Multivalue Switch Value")]
        DataFieldMultivalueSwitchValue = 0x00200493,

        /// <summary>
        ///     Data Field: Force Usage.
        /// </summary>
        [Description("Data Field: Force")]
        DataFieldForce = 0x00200494,

        /// <summary>
        ///     Data Field: Absolute Pressure Usage.
        /// </summary>
        [Description("Data Field: Absolute Pressure")]
        DataFieldAbsolutePressure = 0x00200495,

        /// <summary>
        ///     Data Field: Gauge Pressure Usage.
        /// </summary>
        [Description("Data Field: Gauge Pressure")]
        DataFieldGaugePressure = 0x00200496,

        /// <summary>
        ///     Data Field: Strain Usage.
        /// </summary>
        [Description("Data Field: Strain")]
        DataFieldStrain = 0x00200497,

        /// <summary>
        ///     Data Field: Weight Usage.
        /// </summary>
        [Description("Data Field: Weight")]
        DataFieldWeight = 0x00200498,

        /// <summary>
        ///     Property: Mechanical Usage.
        /// </summary>
        [Description("Property: Mechanical")]
        PropertyMechanical = 0x002004a0,

        /// <summary>
        ///     Property: Vibration State Usage.
        /// </summary>
        [Description("Property: Vibration State")]
        PropertyVibrationState = 0x002004a1,

        /// <summary>
        ///     Property: Forward Vibration Speed (percent) Usage.
        /// </summary>
        [Description("Property: Forward Vibration Speed (percent)")]
        PropertyForwardVibrationSpeedPercent = 0x002004a2,

        /// <summary>
        ///     Property: Backward Vibration Speed (percent) Usage.
        /// </summary>
        [Description("Property: Backward Vibration Speed (percent)")]
        PropertyBackwardVibrationSpeedPercent = 0x002004a3,

        /// <summary>
        ///     Data Field: Biometric Usage.
        /// </summary>
        [Description("Data Field: Biometric")]
        DataFieldBiometric = 0x002004b0,

        /// <summary>
        ///     Data Field: Human Presence Usage.
        /// </summary>
        [Description("Data Field: Human Presence")]
        DataFieldHumanPresence = 0x002004b1,

        /// <summary>
        ///     Data Field: Human Proximity Range Usage.
        /// </summary>
        [Description("Data Field: Human Proximity Range")]
        DataFieldHumanProximityRange = 0x002004b2,

        /// <summary>
        ///     Data Field: Human Proximity Out of Range Usage.
        /// </summary>
        [Description("Data Field: Human Proximity Out of Range")]
        DataFieldHumanProximityOutOfRange = 0x002004b3,

        /// <summary>
        ///     Data Field: Human Touch State Usage.
        /// </summary>
        [Description("Data Field: Human Touch State")]
        DataFieldHumanTouchState = 0x002004b4,

        /// <summary>
        ///     Data Field: Blood Pressure Usage.
        /// </summary>
        [Description("Data Field: Blood Pressure")]
        DataFieldBloodPressure = 0x002004b5,

        /// <summary>
        ///     Data Field: Blood Pressure Diastolic Usage.
        /// </summary>
        [Description("Data Field: Blood Pressure Diastolic")]
        DataFieldBloodPressureDiastolic = 0x002004b6,

        /// <summary>
        ///     Data Field: Blood Pressure Systolic Usage.
        /// </summary>
        [Description("Data Field: Blood Pressure Systolic")]
        DataFieldBloodPressureSystolic = 0x002004b7,

        /// <summary>
        ///     Data Field: Heart Rate (HeartbeatsPM) Usage.
        /// </summary>
        [Description("Data Field: Heart Rate (HeartbeatsPM)")]
        DataFieldHeartRateHeartbeatsPM = 0x002004b8,

        /// <summary>
        ///     Data Field: Resting Heart Rate (HeartbeatsPM) Usage.
        /// </summary>
        [Description("Data Field: Resting Heart Rate (HeartbeatsPM)")]
        DataFieldRestingHeartRateHeartbeatsPM = 0x002004b9,

        /// <summary>
        ///     Data Field: Heartbeat Interval Usage.
        /// </summary>
        [Description("Data Field: Heartbeat Interval")]
        DataFieldHeartbeatInterval = 0x002004ba,

        /// <summary>
        ///     Data Field: Respiratory Rate Usage.
        /// </summary>
        [Description("Data Field: Respiratory Rate")]
        DataFieldRespiratoryRate = 0x002004bb,

        /// <summary>
        ///     Data Field: SpO2 (percent) Usage.
        /// </summary>
        [Description("Data Field: SpO2 (percent)")]
        DataFieldSpO2Percent = 0x002004bc,

        /// <summary>
        ///     Data Field: Light Usage.
        /// </summary>
        [Description("Data Field: Light")]
        DataFieldLight = 0x002004d0,

        /// <summary>
        ///     Data Field: Illuminance Usage.
        /// </summary>
        [Description("Data Field: Illuminance")]
        DataFieldIlluminance = 0x002004d1,

        /// <summary>
        ///     Data Field: Color Temperature Usage.
        /// </summary>
        [Description("Data Field: Color Temperature")]
        DataFieldColorTemperature = 0x002004d2,

        /// <summary>
        ///     Data Field: Chromaticity Usage.
        /// </summary>
        [Description("Data Field: Chromaticity")]
        DataFieldChromaticity = 0x002004d3,

        /// <summary>
        ///     Data Field: Chromaticity X Usage.
        /// </summary>
        [Description("Data Field: Chromaticity X")]
        DataFieldChromaticityX = 0x002004d4,

        /// <summary>
        ///     Data Field: Chromaticity Y Usage.
        /// </summary>
        [Description("Data Field: Chromaticity Y")]
        DataFieldChromaticityY = 0x002004d5,

        /// <summary>
        ///     Data Field: Consumer IR Sentence Receive Usage.
        /// </summary>
        [Description("Data Field: Consumer IR Sentence Receive")]
        DataFieldConsumerIRSentenceReceive = 0x002004d6,

        /// <summary>
        ///     Data Field: Infrared Light Usage.
        /// </summary>
        [Description("Data Field: Infrared Light")]
        DataFieldInfraredLight = 0x002004d7,

        /// <summary>
        ///     Data Field: Red Light Usage.
        /// </summary>
        [Description("Data Field: Red Light")]
        DataFieldRedLight = 0x002004d8,

        /// <summary>
        ///     Data Field: Green Light Usage.
        /// </summary>
        [Description("Data Field: Green Light")]
        DataFieldGreenLight = 0x002004d9,

        /// <summary>
        ///     Data Field: Blue Light Usage.
        /// </summary>
        [Description("Data Field: Blue Light")]
        DataFieldBlueLight = 0x002004da,

        /// <summary>
        ///     Data Field: Ultraviolet A Light Usage.
        /// </summary>
        [Description("Data Field: Ultraviolet A Light")]
        DataFieldUltravioletALight = 0x002004db,

        /// <summary>
        ///     Data Field: Ultraviolet B Light Usage.
        /// </summary>
        [Description("Data Field: Ultraviolet B Light")]
        DataFieldUltravioletBLight = 0x002004dc,

        /// <summary>
        ///     Data Field: Ultraviolet Index Usage.
        /// </summary>
        [Description("Data Field: Ultraviolet Index")]
        DataFieldUltravioletIndex = 0x002004dd,

        /// <summary>
        ///     Property: Light Usage.
        /// </summary>
        [Description("Property: Light")]
        PropertyLight = 0x002004e0,

        /// <summary>
        ///     Property: Consumer IR Sentence Send Usage.
        /// </summary>
        [Description("Property: Consumer IR Sentence Send")]
        PropertyConsumerIRSentenceSend = 0x002004e1,

        /// <summary>
        ///     Data Field: Scanner Usage.
        /// </summary>
        [Description("Data Field: Scanner")]
        DataFieldScanner = 0x002004f0,

        /// <summary>
        ///     Data Field: RFID Tag 40 Bit Usage.
        /// </summary>
        [Description("Data Field: RFID Tag 40 Bit")]
        DataFieldRFIDTag40Bit = 0x002004f1,

        /// <summary>
        ///     Data Field: NFC Sentence Receive Usage.
        /// </summary>
        [Description("Data Field: NFC Sentence Receive")]
        DataFieldNFCSentenceReceive = 0x002004f2,

        /// <summary>
        ///     Property: Scanner Usage.
        /// </summary>
        [Description("Property: Scanner")]
        PropertyScanner = 0x002004f8,

        /// <summary>
        ///     Property: NFC Sentence Send Usage.
        /// </summary>
        [Description("Property: NFC Sentence Send")]
        PropertyNFCSentenceSend = 0x002004f9,

        /// <summary>
        ///     Data Field: Electrical Usage.
        /// </summary>
        [Description("Data Field: Electrical")]
        DataFieldElectrical = 0x00200500,

        /// <summary>
        ///     Data Field: Capacitance Usage.
        /// </summary>
        [Description("Data Field: Capacitance")]
        DataFieldCapacitance = 0x00200501,

        /// <summary>
        ///     Data Field: Current Usage.
        /// </summary>
        [Description("Data Field: Current")]
        DataFieldCurrent = 0x00200502,

        /// <summary>
        ///     Data Field: Electrical Power Usage.
        /// </summary>
        [Description("Data Field: Electrical Power")]
        DataFieldElectricalPower = 0x00200503,

        /// <summary>
        ///     Data Field: Inductance Usage.
        /// </summary>
        [Description("Data Field: Inductance")]
        DataFieldInductance = 0x00200504,

        /// <summary>
        ///     Data Field: Resistance Usage.
        /// </summary>
        [Description("Data Field: Resistance")]
        DataFieldResistance = 0x00200505,

        /// <summary>
        ///     Data Field: Voltage Usage.
        /// </summary>
        [Description("Data Field: Voltage")]
        DataFieldVoltage = 0x00200506,

        /// <summary>
        ///     Data Field: Frequency Usage.
        /// </summary>
        [Description("Data Field: Frequency")]
        DataFieldFrequency = 0x00200507,

        /// <summary>
        ///     Data Field: Period Usage.
        /// </summary>
        [Description("Data Field: Period")]
        DataFieldPeriod = 0x00200508,

        /// <summary>
        ///     Data Field: Percent of Range Usage.
        /// </summary>
        [Description("Data Field: Percent of Range")]
        DataFieldPercentOfRange = 0x00200509,

        /// <summary>
        ///     Data Field: Time Usage.
        /// </summary>
        [Description("Data Field: Time")]
        DataFieldTime = 0x00200520,

        /// <summary>
        ///     Data Field: Year Usage.
        /// </summary>
        [Description("Data Field: Year")]
        DataFieldYear = 0x00200521,

        /// <summary>
        ///     Data Field: Month Usage.
        /// </summary>
        [Description("Data Field: Month")]
        DataFieldMonth = 0x00200522,

        /// <summary>
        ///     Data Field: Day Usage.
        /// </summary>
        [Description("Data Field: Day")]
        DataFieldDay = 0x00200523,

        /// <summary>
        ///     Data Field: Day of Week Usage.
        /// </summary>
        [Description("Data Field: Day of Week")]
        DataFieldDayOfWeek = 0x00200524,

        /// <summary>
        ///     Data Field: Minute Usage.
        /// </summary>
        [Description("Data Field: Minute")]
        DataFieldMinute = 0x00200526,

        /// <summary>
        ///     Data Field: Second Usage.
        /// </summary>
        [Description("Data Field: Second")]
        DataFieldSecond = 0x00200527,

        /// <summary>
        ///     Data Field: Millisecond Usage.
        /// </summary>
        [Description("Data Field: Millisecond")]
        DataFieldMillisecond = 0x00200528,

        /// <summary>
        ///     Data Field: Timestamp Usage.
        /// </summary>
        [Description("Data Field: Timestamp")]
        DataFieldTimestamp = 0x00200529,

        /// <summary>
        ///     Data Field: Julian Day of Year Usage.
        /// </summary>
        [Description("Data Field: Julian Day of Year")]
        DataFieldJulianDayOfYear = 0x0020052a,

        /// <summary>
        ///     Data Field: Time Since System Boot Usage.
        /// </summary>
        [Description("Data Field: Time Since System Boot")]
        DataFieldTimeSinceSystemBoot = 0x0020052b,

        /// <summary>
        ///     Property: Time Usage.
        /// </summary>
        [Description("Property: Time")]
        PropertyTime = 0x00200530,

        /// <summary>
        ///     Property: Time Zone Offset from UTC Usage.
        /// </summary>
        [Description("Property: Time Zone Offset from UTC")]
        PropertyTimeZoneOffsetFromUTC = 0x00200531,

        /// <summary>
        ///     Property: Time Zone Name Usage.
        /// </summary>
        [Description("Property: Time Zone Name")]
        PropertyTimeZoneName = 0x00200532,

        /// <summary>
        ///     Property: Daylight Savings Time Observed Usage.
        /// </summary>
        [Description("Property: Daylight Savings Time Observed")]
        PropertyDaylightSavingsTimeObserved = 0x00200533,

        /// <summary>
        ///     Property: Time Trim Adjustment Usage.
        /// </summary>
        [Description("Property: Time Trim Adjustment")]
        PropertyTimeTrimAdjustment = 0x00200534,

        /// <summary>
        ///     Property: Arm Alarm Usage.
        /// </summary>
        [Description("Property: Arm Alarm")]
        PropertyArmAlarm = 0x00200535,

        /// <summary>
        ///     Data Field: Custom Usage.
        /// </summary>
        [Description("Data Field: Custom")]
        DataFieldCustom = 0x00200540,

        /// <summary>
        ///     Data Field: Custom Usage Usage.
        /// </summary>
        [Description("Data Field: Custom Usage")]
        DataFieldCustomUsage = 0x00200541,

        /// <summary>
        ///     Data Field: Custom Boolean Array Usage.
        /// </summary>
        [Description("Data Field: Custom Boolean Array")]
        DataFieldCustomBooleanArray = 0x00200542,

        /// <summary>
        ///     Data Field: Custom Value Usage.
        /// </summary>
        [Description("Data Field: Custom Value")]
        DataFieldCustomValue = 0x00200543,

        /*
         * Range: 0x0544 -> 0x055f
         * Data Field: Custom Value {n+1}
         */

        /// <summary>
        ///     Data Field: Custom Value 1 Usage.
        /// </summary>
        [Description("Data Field: Custom Value 1")]
        DataFieldCustomValue1 = 0x00200544,

        /// <summary>
        ///     Data Field: Custom Value 2 Usage.
        /// </summary>
        [Description("Data Field: Custom Value 2")]
        DataFieldCustomValue2 = 0x00200545,

        /// <summary>
        ///     Data Field: Custom Value 3 Usage.
        /// </summary>
        [Description("Data Field: Custom Value 3")]
        DataFieldCustomValue3 = 0x00200546,

        /// <summary>
        ///     Data Field: Custom Value 4 Usage.
        /// </summary>
        [Description("Data Field: Custom Value 4")]
        DataFieldCustomValue4 = 0x00200547,

        /// <summary>
        ///     Data Field: Custom Value 5 Usage.
        /// </summary>
        [Description("Data Field: Custom Value 5")]
        DataFieldCustomValue5 = 0x00200548,

        /// <summary>
        ///     Data Field: Custom Value 6 Usage.
        /// </summary>
        [Description("Data Field: Custom Value 6")]
        DataFieldCustomValue6 = 0x00200549,

        /// <summary>
        ///     Data Field: Custom Value 7 Usage.
        /// </summary>
        [Description("Data Field: Custom Value 7")]
        DataFieldCustomValue7 = 0x0020054a,

        /// <summary>
        ///     Data Field: Custom Value 8 Usage.
        /// </summary>
        [Description("Data Field: Custom Value 8")]
        DataFieldCustomValue8 = 0x0020054b,

        /// <summary>
        ///     Data Field: Custom Value 9 Usage.
        /// </summary>
        [Description("Data Field: Custom Value 9")]
        DataFieldCustomValue9 = 0x0020054c,

        /// <summary>
        ///     Data Field: Custom Value 10 Usage.
        /// </summary>
        [Description("Data Field: Custom Value 10")]
        DataFieldCustomValue10 = 0x0020054d,

        /// <summary>
        ///     Data Field: Custom Value 11 Usage.
        /// </summary>
        [Description("Data Field: Custom Value 11")]
        DataFieldCustomValue11 = 0x0020054e,

        /// <summary>
        ///     Data Field: Custom Value 12 Usage.
        /// </summary>
        [Description("Data Field: Custom Value 12")]
        DataFieldCustomValue12 = 0x0020054f,

        /// <summary>
        ///     Data Field: Custom Value 13 Usage.
        /// </summary>
        [Description("Data Field: Custom Value 13")]
        DataFieldCustomValue13 = 0x00200550,

        /// <summary>
        ///     Data Field: Custom Value 14 Usage.
        /// </summary>
        [Description("Data Field: Custom Value 14")]
        DataFieldCustomValue14 = 0x00200551,

        /// <summary>
        ///     Data Field: Custom Value 15 Usage.
        /// </summary>
        [Description("Data Field: Custom Value 15")]
        DataFieldCustomValue15 = 0x00200552,

        /// <summary>
        ///     Data Field: Custom Value 16 Usage.
        /// </summary>
        [Description("Data Field: Custom Value 16")]
        DataFieldCustomValue16 = 0x00200553,

        /// <summary>
        ///     Data Field: Generic Usage.
        /// </summary>
        [Description("Data Field: Generic")]
        DataFieldGeneric = 0x00200560,

        /// <summary>
        ///     Data Field: Generic GUID or PROPERTYKEY Usage.
        /// </summary>
        [Description("Data Field: Generic GUID or PROPERTYKEY")]
        DataFieldGenericGUIDOrPROPERTYKEY = 0x00200561,

        /// <summary>
        ///     Data Field: Generic Category GUID Usage.
        /// </summary>
        [Description("Data Field: Generic Category GUID")]
        DataFieldGenericCategoryGUID = 0x00200562,

        /// <summary>
        ///     Data Field: Generic Type GUID Usage.
        /// </summary>
        [Description("Data Field: Generic Type GUID")]
        DataFieldGenericTypeGUID = 0x00200563,

        /// <summary>
        ///     Data Field: Generic Event PROPERTYKEY Usage.
        /// </summary>
        [Description("Data Field: Generic Event PROPERTYKEY")]
        DataFieldGenericEventPROPERTYKEY = 0x00200564,

        /// <summary>
        ///     Data Field: Generic Property PROPERTYKEY Usage.
        /// </summary>
        [Description("Data Field: Generic Property PROPERTYKEY")]
        DataFieldGenericPropertyPROPERTYKEY = 0x00200565,

        /// <summary>
        ///     Data Field: Generic Data Field PROPERTYKEY Usage.
        /// </summary>
        [Description("Data Field: Generic Data Field PROPERTYKEY")]
        DataFieldGenericDataFieldPROPERTYKEY = 0x00200566,

        /// <summary>
        ///     Data Field: Generic Event Usage.
        /// </summary>
        [Description("Data Field: Generic Event")]
        DataFieldGenericEvent = 0x00200567,

        /// <summary>
        ///     Data Field: Generic Property Usage.
        /// </summary>
        [Description("Data Field: Generic Property")]
        DataFieldGenericProperty = 0x00200568,

        /// <summary>
        ///     Data Field: Generic Data Field Usage.
        /// </summary>
        [Description("Data Field: Generic Data Field")]
        DataFieldGenericDataField = 0x00200569,

        /// <summary>
        ///     Data Field: Enumerator Table Row Index Usage.
        /// </summary>
        [Description("Data Field: Enumerator Table Row Index")]
        DataFieldEnumeratorTableRowIndex = 0x0020056a,

        /// <summary>
        ///     Data Field: Enumerator Table Row Count Usage.
        /// </summary>
        [Description("Data Field: Enumerator Table Row Count")]
        DataFieldEnumeratorTableRowCount = 0x0020056b,

        /// <summary>
        ///     Data Field: Generic GUID or PROPERTYKEY kind Usage.
        /// </summary>
        [Description("Data Field: Generic GUID or PROPERTYKEY kind")]
        DataFieldGenericGUIDOrPROPERTYKEYKind = 0x0020056c,

        /// <summary>
        ///     Data Field: Generic GUID Usage.
        /// </summary>
        [Description("Data Field: Generic GUID")]
        DataFieldGenericGUID = 0x0020056d,

        /// <summary>
        ///     Data Field: Generic PROPERTYKEY Usage.
        /// </summary>
        [Description("Data Field: Generic PROPERTYKEY")]
        DataFieldGenericPROPERTYKEY = 0x0020056e,

        /// <summary>
        ///     Data Field: Generic Top Level Collection ID Usage.
        /// </summary>
        [Description("Data Field: Generic Top Level Collection ID")]
        DataFieldGenericTopLevelCollectionID = 0x0020056f,

        /// <summary>
        ///     Data Field: Generic Report ID Usage.
        /// </summary>
        [Description("Data Field: Generic Report ID")]
        DataFieldGenericReportID = 0x00200570,

        /// <summary>
        ///     Data Field: Generic Report Item Position Index Usage.
        /// </summary>
        [Description("Data Field: Generic Report Item Position Index")]
        DataFieldGenericReportItemPositionIndex = 0x00200571,

        /// <summary>
        ///     Data Field: Generic Firmware VARTYPE Usage.
        /// </summary>
        [Description("Data Field: Generic Firmware VARTYPE")]
        DataFieldGenericFirmwareVARTYPE = 0x00200572,

        /// <summary>
        ///     Data Field: Generic Unit of Measure Usage.
        /// </summary>
        [Description("Data Field: Generic Unit of Measure")]
        DataFieldGenericUnitOfMeasure = 0x00200573,

        /// <summary>
        ///     Data Field: Generic Unit Exponent Usage.
        /// </summary>
        [Description("Data Field: Generic Unit Exponent")]
        DataFieldGenericUnitExponent = 0x00200574,

        /// <summary>
        ///     Data Field: Generic Report Size Usage.
        /// </summary>
        [Description("Data Field: Generic Report Size")]
        DataFieldGenericReportSize = 0x00200575,

        /// <summary>
        ///     Data Field: Generic Report Count Usage.
        /// </summary>
        [Description("Data Field: Generic Report Count")]
        DataFieldGenericReportCount = 0x00200576,

        /// <summary>
        ///     Property: Generic Usage.
        /// </summary>
        [Description("Property: Generic")]
        PropertyGeneric = 0x00200580,

        /// <summary>
        ///     Property: Enumerator Table Row Index Usage.
        /// </summary>
        [Description("Property: Enumerator Table Row Index")]
        PropertyEnumeratorTableRowIndex = 0x00200581,

        /// <summary>
        ///     Property: Enumerator Table Row Count Usage.
        /// </summary>
        [Description("Property: Enumerator Table Row Count")]
        PropertyEnumeratorTableRowCount = 0x00200582,

        /// <summary>
        ///     Data Field: Personal Activity Usage.
        /// </summary>
        [Description("Data Field: Personal Activity")]
        DataFieldPersonalActivity = 0x00200590,

        /// <summary>
        ///     Data Field: Activity Type Usage.
        /// </summary>
        [Description("Data Field: Activity Type")]
        DataFieldActivityType = 0x00200591,

        /// <summary>
        ///     Data Field: Activity State Usage.
        /// </summary>
        [Description("Data Field: Activity State")]
        DataFieldActivityState = 0x00200592,

        /// <summary>
        ///     Data Field: Device Position Usage.
        /// </summary>
        [Description("Data Field: Device Position")]
        DataFieldDevicePosition = 0x00200593,

        /// <summary>
        ///     Data Field: Step Count Usage.
        /// </summary>
        [Description("Data Field: Step Count")]
        DataFieldStepCount = 0x00200594,

        /// <summary>
        ///     Data Field: Step Count Reset Usage.
        /// </summary>
        [Description("Data Field: Step Count Reset")]
        DataFieldStepCountReset = 0x00200595,

        /// <summary>
        ///     Data Field: Step Duration Usage.
        /// </summary>
        [Description("Data Field: Step Duration")]
        DataFieldStepDuration = 0x00200596,

        /// <summary>
        ///     Data Field: Step Type Usage.
        /// </summary>
        [Description("Data Field: Step Type")]
        DataFieldStepType = 0x00200597,

        /// <summary>
        ///     Property: Minimum Activity Detection Interval Usage.
        /// </summary>
        [Description("Property: Minimum Activity Detection Interval")]
        PropertyMinimumActivityDetectionInterval = 0x002005a0,

        /// <summary>
        ///     Property: Supported Activity Types Usage.
        /// </summary>
        [Description("Property: Supported Activity Types")]
        PropertySupportedActivityTypes = 0x002005a1,

        /// <summary>
        ///     Property: Subscribed Activity Types Usage.
        /// </summary>
        [Description("Property: Subscribed Activity Types")]
        PropertySubscribedActivityTypes = 0x002005a2,

        /// <summary>
        ///     Property: Supported Step Types Usage.
        /// </summary>
        [Description("Property: Supported Step Types")]
        PropertySupportedStepTypes = 0x002005a3,

        /// <summary>
        ///     Property: Subscribed Step Types Usage.
        /// </summary>
        [Description("Property: Subscribed Step Types")]
        PropertySubscribedStepTypes = 0x002005a4,

        /// <summary>
        ///     Property: Floor Height Usage.
        /// </summary>
        [Description("Property: Floor Height")]
        PropertyFloorHeight = 0x002005a5,

        /// <summary>
        ///     Data Field: Custom Type ID Usage.
        /// </summary>
        [Description("Data Field: Custom Type ID")]
        DataFieldCustomTypeID = 0x002005b0,

        /// <summary>
        ///     Data Field: Hinge Usage.
        /// </summary>
        [Description("Data Field: Hinge")]
        DataFieldHinge = 0x002005e0,

        /// <summary>
        ///     Data Field: Hinge Angle Usage.
        /// </summary>
        [Description("Data Field: Hinge Angle")]
        DataFieldHingeAngle = 0x002005e1,

        /// <summary>
        ///     Data Field: Gesture Sensor Usage.
        /// </summary>
        [Description("Data Field: Gesture Sensor")]
        DataFieldGestureSensor = 0x002005f0,

        /// <summary>
        ///     Data Field: Gesture State Usage.
        /// </summary>
        [Description("Data Field: Gesture State")]
        DataFieldGestureState = 0x002005f1,

        /// <summary>
        ///     Data Field: Hinge Fold Initial Angle Usage.
        /// </summary>
        [Description("Data Field: Hinge Fold Initial Angle")]
        DataFieldHingeFoldInitialAngle = 0x002005f2,

        /// <summary>
        ///     Data Field: Hinge Fold Final Angle Usage.
        /// </summary>
        [Description("Data Field: Hinge Fold Final Angle")]
        DataFieldHingeFoldFinalAngle = 0x002005f3,

        /// <summary>
        ///     Data Field: Hinge Fold Contributing Panel Usage.
        /// </summary>
        [Description("Data Field: Hinge Fold Contributing Panel")]
        DataFieldHingeFoldContributingPanel = 0x002005f4,

        /// <summary>
        ///     Data Field: Hinge Fold Type Usage.
        /// </summary>
        [Description("Data Field: Hinge Fold Type")]
        DataFieldHingeFoldType = 0x002005f5,

        /// <summary>
        ///     Sensor State: Undefined Usage.
        /// </summary>
        [Description("Sensor State: Undefined")]
        SensorStateUndefined = 0x00200800,

        /// <summary>
        ///     Sensor State: Ready Usage.
        /// </summary>
        [Description("Sensor State: Ready")]
        SensorStateReady = 0x00200801,

        /// <summary>
        ///     Sensor State: Not Available Usage.
        /// </summary>
        [Description("Sensor State: Not Available")]
        SensorStateNotAvailable = 0x00200802,

        /// <summary>
        ///     Sensor State: No Data Usage.
        /// </summary>
        [Description("Sensor State: No Data")]
        SensorStateNoData = 0x00200803,

        /// <summary>
        ///     Sensor State: Initializing Usage.
        /// </summary>
        [Description("Sensor State: Initializing")]
        SensorStateInitializing = 0x00200804,

        /// <summary>
        ///     Sensor State: Access Denied Usage.
        /// </summary>
        [Description("Sensor State: Access Denied")]
        SensorStateAccessDenied = 0x00200805,

        /// <summary>
        ///     Sensor State: Error Usage.
        /// </summary>
        [Description("Sensor State: Error")]
        SensorStateError = 0x00200806,

        /// <summary>
        ///     Sensor Event: Unknown Usage.
        /// </summary>
        [Description("Sensor Event: Unknown")]
        SensorEventUnknown = 0x00200810,

        /// <summary>
        ///     Sensor Event: State Changed Usage.
        /// </summary>
        [Description("Sensor Event: State Changed")]
        SensorEventStateChanged = 0x00200811,

        /// <summary>
        ///     Sensor Event: Property Changed Usage.
        /// </summary>
        [Description("Sensor Event: Property Changed")]
        SensorEventPropertyChanged = 0x00200812,

        /// <summary>
        ///     Sensor Event: Data Updated Usage.
        /// </summary>
        [Description("Sensor Event: Data Updated")]
        SensorEventDataUpdated = 0x00200813,

        /// <summary>
        ///     Sensor Event: Poll Response Usage.
        /// </summary>
        [Description("Sensor Event: Poll Response")]
        SensorEventPollResponse = 0x00200814,

        /// <summary>
        ///     Sensor Event: Change Sensitivity Usage.
        /// </summary>
        [Description("Sensor Event: Change Sensitivity")]
        SensorEventChangeSensitivity = 0x00200815,

        /// <summary>
        ///     Sensor Event: Range Maximum Reached Usage.
        /// </summary>
        [Description("Sensor Event: Range Maximum Reached")]
        SensorEventRangeMaximumReached = 0x00200816,

        /// <summary>
        ///     Sensor Event: Range Minimum Reached Usage.
        /// </summary>
        [Description("Sensor Event: Range Minimum Reached")]
        SensorEventRangeMinimumReached = 0x00200817,

        /// <summary>
        ///     Sensor Event: High Threshold Cross Upward Usage.
        /// </summary>
        [Description("Sensor Event: High Threshold Cross Upward")]
        SensorEventHighThresholdCrossUpward = 0x00200818,

        /// <summary>
        ///     Sensor Event: High Threshold Cross Downward Usage.
        /// </summary>
        [Description("Sensor Event: High Threshold Cross Downward")]
        SensorEventHighThresholdCrossDownward = 0x00200819,

        /// <summary>
        ///     Sensor Event: Low Threshold Cross Upward Usage.
        /// </summary>
        [Description("Sensor Event: Low Threshold Cross Upward")]
        SensorEventLowThresholdCrossUpward = 0x0020081a,

        /// <summary>
        ///     Sensor Event: Low Threshold Cross Downward Usage.
        /// </summary>
        [Description("Sensor Event: Low Threshold Cross Downward")]
        SensorEventLowThresholdCrossDownward = 0x0020081b,

        /// <summary>
        ///     Sensor Event: Zero Threshold Cross Upward Usage.
        /// </summary>
        [Description("Sensor Event: Zero Threshold Cross Upward")]
        SensorEventZeroThresholdCrossUpward = 0x0020081c,

        /// <summary>
        ///     Sensor Event: Zero Threshold Cross Downward Usage.
        /// </summary>
        [Description("Sensor Event: Zero Threshold Cross Downward")]
        SensorEventZeroThresholdCrossDownward = 0x0020081d,

        /// <summary>
        ///     Sensor Event: Period Exceeded Usage.
        /// </summary>
        [Description("Sensor Event: Period Exceeded")]
        SensorEventPeriodExceeded = 0x0020081e,

        /// <summary>
        ///     Sensor Event: Frequency Exceeded Usage.
        /// </summary>
        [Description("Sensor Event: Frequency Exceeded")]
        SensorEventFrequencyExceeded = 0x0020081f,

        /// <summary>
        ///     Sensor Event: Complex Trigger Usage.
        /// </summary>
        [Description("Sensor Event: Complex Trigger")]
        SensorEventComplexTrigger = 0x00200820,

        /// <summary>
        ///     Connection Type: Integrated Usage.
        /// </summary>
        [Description("Connection Type: Integrated")]
        ConnectionTypeIntegrated = 0x00200830,

        /// <summary>
        ///     Connection Type: Attached Usage.
        /// </summary>
        [Description("Connection Type: Attached")]
        ConnectionTypeAttached = 0x00200831,

        /// <summary>
        ///     Connection Type: External Usage.
        /// </summary>
        [Description("Connection Type: External")]
        ConnectionTypeExternal = 0x00200832,

        /// <summary>
        ///     Reporting State: Report No Events Usage.
        /// </summary>
        [Description("Reporting State: Report No Events")]
        ReportingStateReportNoEvents = 0x00200840,

        /// <summary>
        ///     Reporting State: Report All Events Usage.
        /// </summary>
        [Description("Reporting State: Report All Events")]
        ReportingStateReportAllEvents = 0x00200841,

        /// <summary>
        ///     Reporting State: Report Threshold Events Usage.
        /// </summary>
        [Description("Reporting State: Report Threshold Events")]
        ReportingStateReportThresholdEvents = 0x00200842,

        /// <summary>
        ///     Reporting State: Wake On No Events Usage.
        /// </summary>
        [Description("Reporting State: Wake On No Events")]
        ReportingStateWakeOnNoEvents = 0x00200843,

        /// <summary>
        ///     Reporting State: Wake On All Events Usage.
        /// </summary>
        [Description("Reporting State: Wake On All Events")]
        ReportingStateWakeOnAllEvents = 0x00200844,

        /// <summary>
        ///     Reporting State: Wake On Threshold Events Usage.
        /// </summary>
        [Description("Reporting State: Wake On Threshold Events")]
        ReportingStateWakeOnThresholdEvents = 0x00200845,

        /// <summary>
        ///     Power State: Undefined Usage.
        /// </summary>
        [Description("Power State: Undefined")]
        PowerStateUndefined = 0x00200850,

        /// <summary>
        ///     Power State: D0 Full Power Usage.
        /// </summary>
        [Description("Power State: D0 Full Power")]
        PowerStateD0FullPower = 0x00200851,

        /// <summary>
        ///     Power State: D1 Low Power Usage.
        /// </summary>
        [Description("Power State: D1 Low Power")]
        PowerStateD1LowPower = 0x00200852,

        /// <summary>
        ///     Power State: D2 Standby Power with Wakeup Usage.
        /// </summary>
        [Description("Power State: D2 Standby Power with Wakeup")]
        PowerStateD2StandbyPowerWithWakeup = 0x00200853,

        /// <summary>
        ///     Power State: D3 Sleep with Wakeup Usage.
        /// </summary>
        [Description("Power State: D3 Sleep with Wakeup")]
        PowerStateD3SleepWithWakeup = 0x00200854,

        /// <summary>
        ///     Power State: D4 Power Off Usage.
        /// </summary>
        [Description("Power State: D4 Power Off")]
        PowerStateD4PowerOff = 0x00200855,

        /// <summary>
        ///     Accuracy: Default Usage.
        /// </summary>
        [Description("Accuracy: Default")]
        AccuracyDefault = 0x00200860,

        /// <summary>
        ///     Accuracy: High Usage.
        /// </summary>
        [Description("Accuracy: High")]
        AccuracyHigh = 0x00200861,

        /// <summary>
        ///     Accuracy: Medium Usage.
        /// </summary>
        [Description("Accuracy: Medium")]
        AccuracyMedium = 0x00200862,

        /// <summary>
        ///     Accuracy: Low Usage.
        /// </summary>
        [Description("Accuracy: Low")]
        AccuracyLow = 0x00200863,

        /// <summary>
        ///     Fix Quality: No Fix Usage.
        /// </summary>
        [Description("Fix Quality: No Fix")]
        FixQualityNoFix = 0x00200870,

        /// <summary>
        ///     Fix Quality: GPS Usage.
        /// </summary>
        [Description("Fix Quality: GPS")]
        FixQualityGPS = 0x00200871,

        /// <summary>
        ///     Fix Quality: DGPS Usage.
        /// </summary>
        [Description("Fix Quality: DGPS")]
        FixQualityDGPS = 0x00200872,

        /// <summary>
        ///     Fix Type: No Fix Usage.
        /// </summary>
        [Description("Fix Type: No Fix")]
        FixTypeNoFix = 0x00200880,

        /// <summary>
        ///     Fix Type: GPS SPS Mode, Fix Valid Usage.
        /// </summary>
        [Description("Fix Type: GPS SPS Mode, Fix Valid")]
        FixTypeGPSSPSModeFixValid = 0x00200881,

        /// <summary>
        ///     Fix Type: DGPS SPS Mode, Fix Valid Usage.
        /// </summary>
        [Description("Fix Type: DGPS SPS Mode, Fix Valid")]
        FixTypeDGPSSPSModeFixValid = 0x00200882,

        /// <summary>
        ///     Fix Type: GPS PPS Mode, Fix Valid Usage.
        /// </summary>
        [Description("Fix Type: GPS PPS Mode, Fix Valid")]
        FixTypeGPSPPSModeFixValid = 0x00200883,

        /// <summary>
        ///     Fix Type: Real Time Kinematic Usage.
        /// </summary>
        [Description("Fix Type: Real Time Kinematic")]
        FixTypeRealTimeKinematic = 0x00200884,

        /// <summary>
        ///     Fix Type: Float RTK Usage.
        /// </summary>
        [Description("Fix Type: Float RTK")]
        FixTypeFloatRTK = 0x00200885,

        /// <summary>
        ///     Fix Type: Estimated (dead reckoned) Usage.
        /// </summary>
        [Description("Fix Type: Estimated (dead reckoned)")]
        FixTypeEstimatedDeadReckoned = 0x00200886,

        /// <summary>
        ///     Fix Type: Manual Input Mode Usage.
        /// </summary>
        [Description("Fix Type: Manual Input Mode")]
        FixTypeManualInputMode = 0x00200887,

        /// <summary>
        ///     Fix Type: Simulator Mode Usage.
        /// </summary>
        [Description("Fix Type: Simulator Mode")]
        FixTypeSimulatorMode = 0x00200888,

        /// <summary>
        ///     GPS Operation Mode: Manual Usage.
        /// </summary>
        [Description("GPS Operation Mode: Manual")]
        GPSOperationModeManual = 0x00200890,

        /// <summary>
        ///     GPS Operation Mode: Automatic Usage.
        /// </summary>
        [Description("GPS Operation Mode: Automatic")]
        GPSOperationModeAutomatic = 0x00200891,

        /// <summary>
        ///     GPS Selection Mode: Autonomous Usage.
        /// </summary>
        [Description("GPS Selection Mode: Autonomous")]
        GPSSelectionModeAutonomous = 0x002008a0,

        /// <summary>
        ///     GPS Selection Mode: DGPS Usage.
        /// </summary>
        [Description("GPS Selection Mode: DGPS")]
        GPSSelectionModeDGPS = 0x002008a1,

        /// <summary>
        ///     GPS Selection Mode: Estimated (dead reckoned) Usage.
        /// </summary>
        [Description("GPS Selection Mode: Estimated (dead reckoned)")]
        GPSSelectionModeEstimatedDeadReckoned = 0x002008a2,

        /// <summary>
        ///     GPS Selection Mode: Manual Input Usage.
        /// </summary>
        [Description("GPS Selection Mode: Manual Input")]
        GPSSelectionModeManualInput = 0x002008a3,

        /// <summary>
        ///     GPS Selection Mode: Simulator Usage.
        /// </summary>
        [Description("GPS Selection Mode: Simulator")]
        GPSSelectionModeSimulator = 0x002008a4,

        /// <summary>
        ///     GPS Selection Mode: Data Not Valid Usage.
        /// </summary>
        [Description("GPS Selection Mode: Data Not Valid")]
        GPSSelectionModeDataNotValid = 0x002008a5,

        /// <summary>
        ///     GPS Status: Data Valid Usage.
        /// </summary>
        [Description("GPS Status: Data Valid")]
        GPSStatusDataValid = 0x002008b0,

        /// <summary>
        ///     GPS Status: Data Not Valid Usage.
        /// </summary>
        [Description("GPS Status: Data Not Valid")]
        GPSStatusDataNotValid = 0x002008b1,

        /// <summary>
        ///     Day of Week: Sunday Usage.
        /// </summary>
        [Description("Day of Week: Sunday")]
        DayOfWeekSunday = 0x002008c0,

        /// <summary>
        ///     Day of Week: Monday Usage.
        /// </summary>
        [Description("Day of Week: Monday")]
        DayOfWeekMonday = 0x002008c1,

        /// <summary>
        ///     Day of Week: Tuesday Usage.
        /// </summary>
        [Description("Day of Week: Tuesday")]
        DayOfWeekTuesday = 0x002008c2,

        /// <summary>
        ///     Day of Week: Wednesday Usage.
        /// </summary>
        [Description("Day of Week: Wednesday")]
        DayOfWeekWednesday = 0x002008c3,

        /// <summary>
        ///     Day of Week: Thursday Usage.
        /// </summary>
        [Description("Day of Week: Thursday")]
        DayOfWeekThursday = 0x002008c4,

        /// <summary>
        ///     Day of Week: Friday Usage.
        /// </summary>
        [Description("Day of Week: Friday")]
        DayOfWeekFriday = 0x002008c5,

        /// <summary>
        ///     Day of Week: Saturday Usage.
        /// </summary>
        [Description("Day of Week: Saturday")]
        DayOfWeekSaturday = 0x002008c6,

        /// <summary>
        ///     Kind: Category Usage.
        /// </summary>
        [Description("Kind: Category")]
        KindCategory = 0x002008d0,

        /// <summary>
        ///     Kind: Type Usage.
        /// </summary>
        [Description("Kind: Type")]
        KindType = 0x002008d1,

        /// <summary>
        ///     Kind: Event Usage.
        /// </summary>
        [Description("Kind: Event")]
        KindEvent = 0x002008d2,

        /// <summary>
        ///     Kind: Property Usage.
        /// </summary>
        [Description("Kind: Property")]
        KindProperty = 0x002008d3,

        /// <summary>
        ///     Kind: Data Field Usage.
        /// </summary>
        [Description("Kind: Data Field")]
        KindDataField = 0x002008d4,

        /// <summary>
        ///     Magnetometer Accuracy: Low Usage.
        /// </summary>
        [Description("Magnetometer Accuracy: Low")]
        MagnetometerAccuracyLow = 0x002008e0,

        /// <summary>
        ///     Magnetometer Accuracy: Medium Usage.
        /// </summary>
        [Description("Magnetometer Accuracy: Medium")]
        MagnetometerAccuracyMedium = 0x002008e1,

        /// <summary>
        ///     Magnetometer Accuracy: High Usage.
        /// </summary>
        [Description("Magnetometer Accuracy: High")]
        MagnetometerAccuracyHigh = 0x002008e2,

        /// <summary>
        ///     Simple Orientation Direction: Not Rotated Usage.
        /// </summary>
        [Description("Simple Orientation Direction: Not Rotated")]
        SimpleOrientationDirectionNotRotated = 0x002008f0,

        /// <summary>
        ///     Simple Orientation Direction: Rotated 90 Degrees CCW Usage.
        /// </summary>
        [Description("Simple Orientation Direction: Rotated 90 Degrees CCW")]
        SimpleOrientationDirectionRotated90DegreesCCW = 0x002008f1,

        /// <summary>
        ///     Simple Orientation Direction: Rotated 180 Degrees CCW Usage.
        /// </summary>
        [Description("Simple Orientation Direction: Rotated 180 Degrees CCW")]
        SimpleOrientationDirectionRotated180DegreesCCW = 0x002008f2,

        /// <summary>
        ///     Simple Orientation Direction: Rotated 270 Degrees CCW Usage.
        /// </summary>
        [Description("Simple Orientation Direction: Rotated 270 Degrees CCW")]
        SimpleOrientationDirectionRotated270DegreesCCW = 0x002008f3,

        /// <summary>
        ///     Simple Orientation Direction: Face Up Usage.
        /// </summary>
        [Description("Simple Orientation Direction: Face Up")]
        SimpleOrientationDirectionFaceUp = 0x002008f4,

        /// <summary>
        ///     Simple Orientation Direction: Face Down Usage.
        /// </summary>
        [Description("Simple Orientation Direction: Face Down")]
        SimpleOrientationDirectionFaceDown = 0x002008f5,

        /// <summary>
        ///     VT_NULL: Empty Usage.
        /// </summary>
        [Description("VT_NULL: Empty")]
        VT_NULLEmpty = 0x00200900,

        /// <summary>
        ///     VT_BOOL: Boolean Usage.
        /// </summary>
        [Description("VT_BOOL: Boolean")]
        VT_BOOLBoolean = 0x00200901,

        /// <summary>
        ///     VT_UI1: Byte Usage.
        /// </summary>
        [Description("VT_UI1: Byte")]
        VT_UI1Byte = 0x00200902,

        /// <summary>
        ///     VT_I1: Character Usage.
        /// </summary>
        [Description("VT_I1: Character")]
        VT_I1Character = 0x00200903,

        /// <summary>
        ///     VT_UI2: Unsigned Short Usage.
        /// </summary>
        [Description("VT_UI2: Unsigned Short")]
        VT_UI2UnsignedShort = 0x00200904,

        /// <summary>
        ///     VT_I2: Short Usage.
        /// </summary>
        [Description("VT_I2: Short")]
        VT_I2Short = 0x00200905,

        /// <summary>
        ///     VT_UI4: Unsigned Long Usage.
        /// </summary>
        [Description("VT_UI4: Unsigned Long")]
        VT_UI4UnsignedLong = 0x00200906,

        /// <summary>
        ///     VT_I4: Long Usage.
        /// </summary>
        [Description("VT_I4: Long")]
        VT_I4Long = 0x00200907,

        /// <summary>
        ///     VT_UI8: Unsigned Long Long Usage.
        /// </summary>
        [Description("VT_UI8: Unsigned Long Long")]
        VT_UI8UnsignedLongLong = 0x00200908,

        /// <summary>
        ///     VT_I8: Long Long Usage.
        /// </summary>
        [Description("VT_I8: Long Long")]
        VT_I8LongLong = 0x00200909,

        /// <summary>
        ///     VT_R4: Float Usage.
        /// </summary>
        [Description("VT_R4: Float")]
        VT_R4Float = 0x0020090a,

        /// <summary>
        ///     VT_R8: Double Usage.
        /// </summary>
        [Description("VT_R8: Double")]
        VT_R8Double = 0x0020090b,

        /// <summary>
        ///     VT_WSTR: Wide String Usage.
        /// </summary>
        [Description("VT_WSTR: Wide String")]
        VT_WSTRWideString = 0x0020090c,

        /// <summary>
        ///     VT_STR: Narrow String Usage.
        /// </summary>
        [Description("VT_STR: Narrow String")]
        VT_STRNarrowString = 0x0020090d,

        /// <summary>
        ///     VT_CLSID: Guid Usage.
        /// </summary>
        [Description("VT_CLSID: Guid")]
        VT_CLSIDGuid = 0x0020090e,

        /// <summary>
        ///     VT_VECTOR|VT_UI1: Opaque Structure Usage.
        /// </summary>
        [Description("VT_VECTOR|VT_UI1: Opaque Structure")]
        VT_VECTORVT_UI1OpaqueStructure = 0x0020090f,

        /// <summary>
        ///     VT_F16E0: HID 16-bit Float e0 Usage.
        /// </summary>
        [Description("VT_F16E0: HID 16-bit Float e0")]
        VT_F16E0HID16bitFloatE0 = 0x00200910,

        /// <summary>
        ///     VT_F16E1: HID 16-bit Float e1 Usage.
        /// </summary>
        [Description("VT_F16E1: HID 16-bit Float e1")]
        VT_F16E1HID16bitFloatE1 = 0x00200911,

        /// <summary>
        ///     VT_F16E2: HID 16-bit Float e2 Usage.
        /// </summary>
        [Description("VT_F16E2: HID 16-bit Float e2")]
        VT_F16E2HID16bitFloatE2 = 0x00200912,

        /// <summary>
        ///     VT_F16E3: HID 16-bit Float e3 Usage.
        /// </summary>
        [Description("VT_F16E3: HID 16-bit Float e3")]
        VT_F16E3HID16bitFloatE3 = 0x00200913,

        /// <summary>
        ///     VT_F16E4: HID 16-bit Float e4 Usage.
        /// </summary>
        [Description("VT_F16E4: HID 16-bit Float e4")]
        VT_F16E4HID16bitFloatE4 = 0x00200914,

        /// <summary>
        ///     VT_F16E5: HID 16-bit Float e5 Usage.
        /// </summary>
        [Description("VT_F16E5: HID 16-bit Float e5")]
        VT_F16E5HID16bitFloatE5 = 0x00200915,

        /// <summary>
        ///     VT_F16E6: HID 16-bit Float e6 Usage.
        /// </summary>
        [Description("VT_F16E6: HID 16-bit Float e6")]
        VT_F16E6HID16bitFloatE6 = 0x00200916,

        /// <summary>
        ///     VT_F16E7: HID 16-bit Float e7 Usage.
        /// </summary>
        [Description("VT_F16E7: HID 16-bit Float e7")]
        VT_F16E7HID16bitFloatE7 = 0x00200917,

        /// <summary>
        ///     VT_F16E8: HID 16-bit Float e-8 Usage.
        /// </summary>
        [Description("VT_F16E8: HID 16-bit Float e-8")]
        VT_F16E8HID16bitFloatE8 = 0x00200918,

        /// <summary>
        ///     VT_F16E9: HID 16-bit Float e-7 Usage.
        /// </summary>
        [Description("VT_F16E9: HID 16-bit Float e-7")]
        VT_F16E9HID16bitFloatE7 = 0x00200919,

        /// <summary>
        ///     VT_F16EA: HID 16-bit Float e-6 Usage.
        /// </summary>
        [Description("VT_F16EA: HID 16-bit Float e-6")]
        VT_F16EAHID16bitFloatE6 = 0x0020091a,

        /// <summary>
        ///     VT_F16EB: HID 16-bit Float e-5 Usage.
        /// </summary>
        [Description("VT_F16EB: HID 16-bit Float e-5")]
        VT_F16EBHID16bitFloatE5 = 0x0020091b,

        /// <summary>
        ///     VT_F16EC: HID 16-bit Float e-4 Usage.
        /// </summary>
        [Description("VT_F16EC: HID 16-bit Float e-4")]
        VT_F16ECHID16bitFloatE4 = 0x0020091c,

        /// <summary>
        ///     VT_F16ED: HID 16-bit Float e-3 Usage.
        /// </summary>
        [Description("VT_F16ED: HID 16-bit Float e-3")]
        VT_F16EDHID16bitFloatE3 = 0x0020091d,

        /// <summary>
        ///     VT_F16EE: HID 16-bit Float e-2 Usage.
        /// </summary>
        [Description("VT_F16EE: HID 16-bit Float e-2")]
        VT_F16EEHID16bitFloatE2 = 0x0020091e,

        /// <summary>
        ///     VT_F16EF: HID 16-bit Float e-1 Usage.
        /// </summary>
        [Description("VT_F16EF: HID 16-bit Float e-1")]
        VT_F16EFHID16bitFloatE1 = 0x0020091f,

        /// <summary>
        ///     VT_F32E0: HID 32-bit Float e0 Usage.
        /// </summary>
        [Description("VT_F32E0: HID 32-bit Float e0")]
        VT_F32E0HID32bitFloatE0 = 0x00200920,

        /// <summary>
        ///     VT_F32E1: HID 32-bit Float e1 Usage.
        /// </summary>
        [Description("VT_F32E1: HID 32-bit Float e1")]
        VT_F32E1HID32bitFloatE1 = 0x00200921,

        /// <summary>
        ///     VT_F32E2: HID 32-bit Float e2 Usage.
        /// </summary>
        [Description("VT_F32E2: HID 32-bit Float e2")]
        VT_F32E2HID32bitFloatE2 = 0x00200922,

        /// <summary>
        ///     VT_F32E3: HID 32-bit Float e3 Usage.
        /// </summary>
        [Description("VT_F32E3: HID 32-bit Float e3")]
        VT_F32E3HID32bitFloatE3 = 0x00200923,

        /// <summary>
        ///     VT_F32E4: HID 32-bit Float e4 Usage.
        /// </summary>
        [Description("VT_F32E4: HID 32-bit Float e4")]
        VT_F32E4HID32bitFloatE4 = 0x00200924,

        /// <summary>
        ///     VT_F32E5: HID 32-bit Float e5 Usage.
        /// </summary>
        [Description("VT_F32E5: HID 32-bit Float e5")]
        VT_F32E5HID32bitFloatE5 = 0x00200925,

        /// <summary>
        ///     VT_F32E6: HID 32-bit Float e6 Usage.
        /// </summary>
        [Description("VT_F32E6: HID 32-bit Float e6")]
        VT_F32E6HID32bitFloatE6 = 0x00200926,

        /// <summary>
        ///     VT_F32E7: HID 32-bit Float e7 Usage.
        /// </summary>
        [Description("VT_F32E7: HID 32-bit Float e7")]
        VT_F32E7HID32bitFloatE7 = 0x00200927,

        /// <summary>
        ///     VT_F32E8: HID 32-bit Float e-8 Usage.
        /// </summary>
        [Description("VT_F32E8: HID 32-bit Float e-8")]
        VT_F32E8HID32bitFloatE8 = 0x00200928,

        /// <summary>
        ///     VT_F32E9: HID 32-bit Float e-7 Usage.
        /// </summary>
        [Description("VT_F32E9: HID 32-bit Float e-7")]
        VT_F32E9HID32bitFloatE7 = 0x00200929,

        /// <summary>
        ///     VT_F32EA: HID 32-bit Float e-6 Usage.
        /// </summary>
        [Description("VT_F32EA: HID 32-bit Float e-6")]
        VT_F32EAHID32bitFloatE6 = 0x0020092a,

        /// <summary>
        ///     VT_F32EB: HID 32-bit Float e-5 Usage.
        /// </summary>
        [Description("VT_F32EB: HID 32-bit Float e-5")]
        VT_F32EBHID32bitFloatE5 = 0x0020092b,

        /// <summary>
        ///     VT_F32EC: HID 32-bit Float e-4 Usage.
        /// </summary>
        [Description("VT_F32EC: HID 32-bit Float e-4")]
        VT_F32ECHID32bitFloatE4 = 0x0020092c,

        /// <summary>
        ///     VT_F32ED: HID 32-bit Float e-3 Usage.
        /// </summary>
        [Description("VT_F32ED: HID 32-bit Float e-3")]
        VT_F32EDHID32bitFloatE3 = 0x0020092d,

        /// <summary>
        ///     VT_F32EE: HID 32-bit Float e-2 Usage.
        /// </summary>
        [Description("VT_F32EE: HID 32-bit Float e-2")]
        VT_F32EEHID32bitFloatE2 = 0x0020092e,

        /// <summary>
        ///     VT_F32EF: HID 32-bit Float e-1 Usage.
        /// </summary>
        [Description("VT_F32EF: HID 32-bit Float e-1")]
        VT_F32EFHID32bitFloatE1 = 0x0020092f,

        /// <summary>
        ///     Activity Type: Unknown Usage.
        /// </summary>
        [Description("Activity Type: Unknown")]
        ActivityTypeUnknown = 0x00200930,

        /// <summary>
        ///     Activity Type: Stationary Usage.
        /// </summary>
        [Description("Activity Type: Stationary")]
        ActivityTypeStationary = 0x00200931,

        /// <summary>
        ///     Activity Type: Fidgeting Usage.
        /// </summary>
        [Description("Activity Type: Fidgeting")]
        ActivityTypeFidgeting = 0x00200932,

        /// <summary>
        ///     Activity Type: Walking Usage.
        /// </summary>
        [Description("Activity Type: Walking")]
        ActivityTypeWalking = 0x00200933,

        /// <summary>
        ///     Activity Type: Running Usage.
        /// </summary>
        [Description("Activity Type: Running")]
        ActivityTypeRunning = 0x00200934,

        /// <summary>
        ///     Activity Type: In Vehicle Usage.
        /// </summary>
        [Description("Activity Type: In Vehicle")]
        ActivityTypeInVehicle = 0x00200935,

        /// <summary>
        ///     Activity Type: Biking Usage.
        /// </summary>
        [Description("Activity Type: Biking")]
        ActivityTypeBiking = 0x00200936,

        /// <summary>
        ///     Activity Type: Idle Usage.
        /// </summary>
        [Description("Activity Type: Idle")]
        ActivityTypeIdle = 0x00200937,

        /// <summary>
        ///     Unit: Not Specified Usage.
        /// </summary>
        [Description("Unit: Not Specified")]
        UnitNotSpecified = 0x00200940,

        /// <summary>
        ///     Unit: Lux Usage.
        /// </summary>
        [Description("Unit: Lux")]
        UnitLux = 0x00200941,

        /// <summary>
        ///     Unit: Degrees Kelvin Usage.
        /// </summary>
        [Description("Unit: Degrees Kelvin")]
        UnitDegreesKelvin = 0x00200942,

        /// <summary>
        ///     Unit: Degrees Celsius Usage.
        /// </summary>
        [Description("Unit: Degrees Celsius")]
        UnitDegreesCelsius = 0x00200943,

        /// <summary>
        ///     Unit: Pascal Usage.
        /// </summary>
        [Description("Unit: Pascal")]
        UnitPascal = 0x00200944,

        /// <summary>
        ///     Unit: Newton Usage.
        /// </summary>
        [Description("Unit: Newton")]
        UnitNewton = 0x00200945,

        /// <summary>
        ///     Unit: Meters/Second Usage.
        /// </summary>
        [Description("Unit: Meters/Second")]
        UnitMetersSecond = 0x00200946,

        /// <summary>
        ///     Unit: Kilogram Usage.
        /// </summary>
        [Description("Unit: Kilogram")]
        UnitKilogram = 0x00200947,

        /// <summary>
        ///     Unit: Meter Usage.
        /// </summary>
        [Description("Unit: Meter")]
        UnitMeter = 0x00200948,

        /// <summary>
        ///     Unit: Meters/Second/Second Usage.
        /// </summary>
        [Description("Unit: Meters/Second/Second")]
        UnitMetersSecondSecond = 0x00200949,

        /// <summary>
        ///     Unit: Farad Usage.
        /// </summary>
        [Description("Unit: Farad")]
        UnitFarad = 0x0020094a,

        /// <summary>
        ///     Unit: Ampere Usage.
        /// </summary>
        [Description("Unit: Ampere")]
        UnitAmpere = 0x0020094b,

        /// <summary>
        ///     Unit: Watt Usage.
        /// </summary>
        [Description("Unit: Watt")]
        UnitWatt = 0x0020094c,

        /// <summary>
        ///     Unit: Henry Usage.
        /// </summary>
        [Description("Unit: Henry")]
        UnitHenry = 0x0020094d,

        /// <summary>
        ///     Unit: Ohm Usage.
        /// </summary>
        [Description("Unit: Ohm")]
        UnitOhm = 0x0020094e,

        /// <summary>
        ///     Unit: Volt Usage.
        /// </summary>
        [Description("Unit: Volt")]
        UnitVolt = 0x0020094f,

        /// <summary>
        ///     Unit: Hertz Usage.
        /// </summary>
        [Description("Unit: Hertz")]
        UnitHertz = 0x00200950,

        /// <summary>
        ///     Unit: Bar Usage.
        /// </summary>
        [Description("Unit: Bar")]
        UnitBar = 0x00200951,

        /// <summary>
        ///     Unit: Degrees Anti-clockwise Usage.
        /// </summary>
        [Description("Unit: Degrees Anti-clockwise")]
        UnitDegreesAnticlockwise = 0x00200952,

        /// <summary>
        ///     Unit: Degrees Clockwise Usage.
        /// </summary>
        [Description("Unit: Degrees Clockwise")]
        UnitDegreesClockwise = 0x00200953,

        /// <summary>
        ///     Unit: Degrees Usage.
        /// </summary>
        [Description("Unit: Degrees")]
        UnitDegrees = 0x00200954,

        /// <summary>
        ///     Unit: Degrees/Second Usage.
        /// </summary>
        [Description("Unit: Degrees/Second")]
        UnitDegreesSecond = 0x00200955,

        /// <summary>
        ///     Unit: Degrees/Second/Second Usage.
        /// </summary>
        [Description("Unit: Degrees/Second/Second")]
        UnitDegreesSecondSecond = 0x00200956,

        /// <summary>
        ///     Unit: Knot Usage.
        /// </summary>
        [Description("Unit: Knot")]
        UnitKnot = 0x00200957,

        /// <summary>
        ///     Unit: Percent Usage.
        /// </summary>
        [Description("Unit: Percent")]
        UnitPercent = 0x00200958,

        /// <summary>
        ///     Unit: Second Usage.
        /// </summary>
        [Description("Unit: Second")]
        UnitSecond = 0x00200959,

        /// <summary>
        ///     Unit: Millisecond Usage.
        /// </summary>
        [Description("Unit: Millisecond")]
        UnitMillisecond = 0x0020095a,

        /// <summary>
        ///     Unit: G Usage.
        /// </summary>
        [Description("Unit: G")]
        UnitG = 0x0020095b,

        /// <summary>
        ///     Unit: Bytes Usage.
        /// </summary>
        [Description("Unit: Bytes")]
        UnitBytes = 0x0020095c,

        /// <summary>
        ///     Unit: Milligauss Usage.
        /// </summary>
        [Description("Unit: Milligauss")]
        UnitMilligauss = 0x0020095d,

        /// <summary>
        ///     Unit: Bits Usage.
        /// </summary>
        [Description("Unit: Bits")]
        UnitBits = 0x0020095e,

        /// <summary>
        ///     Activity State: No State Change Usage.
        /// </summary>
        [Description("Activity State: No State Change")]
        ActivityStateNoStateChange = 0x00200960,

        /// <summary>
        ///     Activity State: Start Activity Usage.
        /// </summary>
        [Description("Activity State: Start Activity")]
        ActivityStateStartActivity = 0x00200961,

        /// <summary>
        ///     Activity State: End Activity Usage.
        /// </summary>
        [Description("Activity State: End Activity")]
        ActivityStateEndActivity = 0x00200962,

        /// <summary>
        ///     Exponent 0: 1 Usage.
        /// </summary>
        [Description("Exponent 0: 1")]
        Exponent01 = 0x00200970,

        /// <summary>
        ///     Exponent 1: 10 Usage.
        /// </summary>
        [Description("Exponent 1: 10")]
        Exponent110 = 0x00200971,

        /// <summary>
        ///     Exponent 2: 100 Usage.
        /// </summary>
        [Description("Exponent 2: 100")]
        Exponent2100 = 0x00200972,

        /// <summary>
        ///     Exponent 3: 1 000 Usage.
        /// </summary>
        [Description("Exponent 3: 1 000")]
        Exponent31000 = 0x00200973,

        /// <summary>
        ///     Exponent 4: 10 000 Usage.
        /// </summary>
        [Description("Exponent 4: 10 000")]
        Exponent410000 = 0x00200974,

        /// <summary>
        ///     Exponent 5: 100 000 Usage.
        /// </summary>
        [Description("Exponent 5: 100 000")]
        Exponent5100000 = 0x00200975,

        /// <summary>
        ///     Exponent 6: 1 000 000 Usage.
        /// </summary>
        [Description("Exponent 6: 1 000 000")]
        Exponent61000000 = 0x00200976,

        /// <summary>
        ///     Exponent 7: 10 000 000 Usage.
        /// </summary>
        [Description("Exponent 7: 10 000 000")]
        Exponent710000000 = 0x00200977,

        /// <summary>
        ///     Exponent 8: 0.00 000 001 Usage.
        /// </summary>
        [Description("Exponent 8: 0.00 000 001")]
        Exponent8000000001 = 0x00200978,

        /// <summary>
        ///     Exponent 9: 0.0 000 001 Usage.
        /// </summary>
        [Description("Exponent 9: 0.0 000 001")]
        Exponent900000001 = 0x00200979,

        /// <summary>
        ///     Exponent A: 0.000 001 Usage.
        /// </summary>
        [Description("Exponent A: 0.000 001")]
        ExponentA0000001 = 0x0020097a,

        /// <summary>
        ///     Exponent B: 0.00 001 Usage.
        /// </summary>
        [Description("Exponent B: 0.00 001")]
        ExponentB000001 = 0x0020097b,

        /// <summary>
        ///     Exponent C: 0.0 001 Usage.
        /// </summary>
        [Description("Exponent C: 0.0 001")]
        ExponentC00001 = 0x0020097c,

        /// <summary>
        ///     Exponent D: 0.001 Usage.
        /// </summary>
        [Description("Exponent D: 0.001")]
        ExponentD0001 = 0x0020097d,

        /// <summary>
        ///     Exponent E: 0.01 Usage.
        /// </summary>
        [Description("Exponent E: 0.01")]
        ExponentE001 = 0x0020097e,

        /// <summary>
        ///     Exponent F: 0.1 Usage.
        /// </summary>
        [Description("Exponent F: 0.1")]
        ExponentF01 = 0x0020097f,

        /// <summary>
        ///     Device Position: Unknown Usage.
        /// </summary>
        [Description("Device Position: Unknown")]
        DevicePositionUnknown = 0x00200980,

        /// <summary>
        ///     Device Position: Unchanged Usage.
        /// </summary>
        [Description("Device Position: Unchanged")]
        DevicePositionUnchanged = 0x00200981,

        /// <summary>
        ///     Device Position: On Desk Usage.
        /// </summary>
        [Description("Device Position: On Desk")]
        DevicePositionOnDesk = 0x00200982,

        /// <summary>
        ///     Device Position: In Hand Usage.
        /// </summary>
        [Description("Device Position: In Hand")]
        DevicePositionInHand = 0x00200983,

        /// <summary>
        ///     Device Position: Moving in Bag Usage.
        /// </summary>
        [Description("Device Position: Moving in Bag")]
        DevicePositionMovingInBag = 0x00200984,

        /// <summary>
        ///     Device Position: Stationary in Bag Usage.
        /// </summary>
        [Description("Device Position: Stationary in Bag")]
        DevicePositionStationaryInBag = 0x00200985,

        /// <summary>
        ///     Step Type: Unknown Usage.
        /// </summary>
        [Description("Step Type: Unknown")]
        StepTypeUnknown = 0x00200990,

        /// <summary>
        ///     Step Type: Running Usage.
        /// </summary>
        [Description("Step Type: Running")]
        StepTypeRunning = 0x00200991,

        /// <summary>
        ///     Step Type: Walking Usage.
        /// </summary>
        [Description("Step Type: Walking")]
        StepTypeWalking = 0x00200992,

        /// <summary>
        ///     Gesture State: Unknown Usage.
        /// </summary>
        [Description("Gesture State: Unknown")]
        GestureStateUnknown = 0x002009a0,

        /// <summary>
        ///     Gesture State: Started Usage.
        /// </summary>
        [Description("Gesture State: Started")]
        GestureStateStarted = 0x002009a1,

        /// <summary>
        ///     Gesture State: Completed Usage.
        /// </summary>
        [Description("Gesture State: Completed")]
        GestureStateCompleted = 0x002009a2,

        /// <summary>
        ///     Gesture State: Cancelled Usage.
        /// </summary>
        [Description("Gesture State: Cancelled")]
        GestureStateCancelled = 0x002009a3,

        /// <summary>
        ///     Contributing Panel: Unknown Usage.
        /// </summary>
        [Description("Contributing Panel: Unknown")]
        ContributingPanelUnknown = 0x002009b0,

        /// <summary>
        ///     Contributing Panel: Panel1 Usage.
        /// </summary>
        [Description("Contributing Panel: Panel1")]
        ContributingPanelPanel1 = 0x002009b1,

        /// <summary>
        ///     Contributing Panel: Panel2 Usage.
        /// </summary>
        [Description("Contributing Panel: Panel2")]
        ContributingPanelPanel2 = 0x002009b2,

        /// <summary>
        ///     Contributing Panel: Both Usage.
        /// </summary>
        [Description("Contributing Panel: Both")]
        ContributingPanelBoth = 0x002009b3,

        /// <summary>
        ///     Fold Type: Unknown Usage.
        /// </summary>
        [Description("Fold Type: Unknown")]
        FoldTypeUnknown = 0x002009b4,

        /// <summary>
        ///     Fold Type: Increasing Usage.
        /// </summary>
        [Description("Fold Type: Increasing")]
        FoldTypeIncreasing = 0x002009b5,

        /// <summary>
        ///     Fold Type: Decreasing Usage.
        /// </summary>
        [Description("Fold Type: Decreasing")]
        FoldTypeDecreasing = 0x002009b6,

        /*
         * Range: 0x1000 -> 0x1fff
         * Change Sensitivity Absolute
         */

        /// <summary>
        ///     Change Sensitivity Absolute Usage.
        /// </summary>
        [Description("Change Sensitivity Absolute")]
        ChangeSensitivityAbsolute = 0x00201000,

        /// <summary>
        ///     Change Sensitivity Absolute Usage.
        /// </summary>
        [Description("Change Sensitivity Absolute")]
        ChangeSensitivityAbsolute2 = 0x00201001,

        /// <summary>
        ///     Change Sensitivity Absolute Usage.
        /// </summary>
        [Description("Change Sensitivity Absolute")]
        ChangeSensitivityAbsolute3 = 0x00201002,

        /// <summary>
        ///     Change Sensitivity Absolute Usage.
        /// </summary>
        [Description("Change Sensitivity Absolute")]
        ChangeSensitivityAbsolute4 = 0x00201003,

        /// <summary>
        ///     Change Sensitivity Absolute Usage.
        /// </summary>
        [Description("Change Sensitivity Absolute")]
        ChangeSensitivityAbsolute5 = 0x00201004,

        /// <summary>
        ///     Change Sensitivity Absolute Usage.
        /// </summary>
        [Description("Change Sensitivity Absolute")]
        ChangeSensitivityAbsolute6 = 0x00201005,

        /// <summary>
        ///     Change Sensitivity Absolute Usage.
        /// </summary>
        [Description("Change Sensitivity Absolute")]
        ChangeSensitivityAbsolute7 = 0x00201006,

        /// <summary>
        ///     Change Sensitivity Absolute Usage.
        /// </summary>
        [Description("Change Sensitivity Absolute")]
        ChangeSensitivityAbsolute8 = 0x00201007,

        /// <summary>
        ///     Change Sensitivity Absolute Usage.
        /// </summary>
        [Description("Change Sensitivity Absolute")]
        ChangeSensitivityAbsolute9 = 0x00201008,

        /// <summary>
        ///     Change Sensitivity Absolute Usage.
        /// </summary>
        [Description("Change Sensitivity Absolute")]
        ChangeSensitivityAbsolute10 = 0x00201009,

        /// <summary>
        ///     Change Sensitivity Absolute Usage.
        /// </summary>
        [Description("Change Sensitivity Absolute")]
        ChangeSensitivityAbsolute11 = 0x0020100a,

        /// <summary>
        ///     Change Sensitivity Absolute Usage.
        /// </summary>
        [Description("Change Sensitivity Absolute")]
        ChangeSensitivityAbsolute12 = 0x0020100b,

        /// <summary>
        ///     Change Sensitivity Absolute Usage.
        /// </summary>
        [Description("Change Sensitivity Absolute")]
        ChangeSensitivityAbsolute13 = 0x0020100c,

        /// <summary>
        ///     Change Sensitivity Absolute Usage.
        /// </summary>
        [Description("Change Sensitivity Absolute")]
        ChangeSensitivityAbsolute14 = 0x0020100d,

        /// <summary>
        ///     Change Sensitivity Absolute Usage.
        /// </summary>
        [Description("Change Sensitivity Absolute")]
        ChangeSensitivityAbsolute15 = 0x0020100e,

        /// <summary>
        ///     Change Sensitivity Absolute Usage.
        /// </summary>
        [Description("Change Sensitivity Absolute")]
        ChangeSensitivityAbsolute16 = 0x0020100f,

        /*
         * Range: 0x2000 -> 0x2fff
         * Maximum
         */

        /// <summary>
        ///     Maximum Usage.
        /// </summary>
        [Description("Maximum")]
        Maximum = 0x00202000,

        /// <summary>
        ///     Maximum Usage.
        /// </summary>
        [Description("Maximum")]
        Maximum2 = 0x00202001,

        /// <summary>
        ///     Maximum Usage.
        /// </summary>
        [Description("Maximum")]
        Maximum3 = 0x00202002,

        /// <summary>
        ///     Maximum Usage.
        /// </summary>
        [Description("Maximum")]
        Maximum4 = 0x00202003,

        /// <summary>
        ///     Maximum Usage.
        /// </summary>
        [Description("Maximum")]
        Maximum5 = 0x00202004,

        /// <summary>
        ///     Maximum Usage.
        /// </summary>
        [Description("Maximum")]
        Maximum6 = 0x00202005,

        /// <summary>
        ///     Maximum Usage.
        /// </summary>
        [Description("Maximum")]
        Maximum7 = 0x00202006,

        /// <summary>
        ///     Maximum Usage.
        /// </summary>
        [Description("Maximum")]
        Maximum8 = 0x00202007,

        /// <summary>
        ///     Maximum Usage.
        /// </summary>
        [Description("Maximum")]
        Maximum9 = 0x00202008,

        /// <summary>
        ///     Maximum Usage.
        /// </summary>
        [Description("Maximum")]
        Maximum10 = 0x00202009,

        /// <summary>
        ///     Maximum Usage.
        /// </summary>
        [Description("Maximum")]
        Maximum11 = 0x0020200a,

        /// <summary>
        ///     Maximum Usage.
        /// </summary>
        [Description("Maximum")]
        Maximum12 = 0x0020200b,

        /// <summary>
        ///     Maximum Usage.
        /// </summary>
        [Description("Maximum")]
        Maximum13 = 0x0020200c,

        /// <summary>
        ///     Maximum Usage.
        /// </summary>
        [Description("Maximum")]
        Maximum14 = 0x0020200d,

        /// <summary>
        ///     Maximum Usage.
        /// </summary>
        [Description("Maximum")]
        Maximum15 = 0x0020200e,

        /// <summary>
        ///     Maximum Usage.
        /// </summary>
        [Description("Maximum")]
        Maximum16 = 0x0020200f,

        /*
         * Range: 0x3000 -> 0x3fff
         * Minimum
         */

        /// <summary>
        ///     Minimum Usage.
        /// </summary>
        [Description("Minimum")]
        Minimum = 0x00203000,

        /// <summary>
        ///     Minimum Usage.
        /// </summary>
        [Description("Minimum")]
        Minimum2 = 0x00203001,

        /// <summary>
        ///     Minimum Usage.
        /// </summary>
        [Description("Minimum")]
        Minimum3 = 0x00203002,

        /// <summary>
        ///     Minimum Usage.
        /// </summary>
        [Description("Minimum")]
        Minimum4 = 0x00203003,

        /// <summary>
        ///     Minimum Usage.
        /// </summary>
        [Description("Minimum")]
        Minimum5 = 0x00203004,

        /// <summary>
        ///     Minimum Usage.
        /// </summary>
        [Description("Minimum")]
        Minimum6 = 0x00203005,

        /// <summary>
        ///     Minimum Usage.
        /// </summary>
        [Description("Minimum")]
        Minimum7 = 0x00203006,

        /// <summary>
        ///     Minimum Usage.
        /// </summary>
        [Description("Minimum")]
        Minimum8 = 0x00203007,

        /// <summary>
        ///     Minimum Usage.
        /// </summary>
        [Description("Minimum")]
        Minimum9 = 0x00203008,

        /// <summary>
        ///     Minimum Usage.
        /// </summary>
        [Description("Minimum")]
        Minimum10 = 0x00203009,

        /// <summary>
        ///     Minimum Usage.
        /// </summary>
        [Description("Minimum")]
        Minimum11 = 0x0020300a,

        /// <summary>
        ///     Minimum Usage.
        /// </summary>
        [Description("Minimum")]
        Minimum12 = 0x0020300b,

        /// <summary>
        ///     Minimum Usage.
        /// </summary>
        [Description("Minimum")]
        Minimum13 = 0x0020300c,

        /// <summary>
        ///     Minimum Usage.
        /// </summary>
        [Description("Minimum")]
        Minimum14 = 0x0020300d,

        /// <summary>
        ///     Minimum Usage.
        /// </summary>
        [Description("Minimum")]
        Minimum15 = 0x0020300e,

        /// <summary>
        ///     Minimum Usage.
        /// </summary>
        [Description("Minimum")]
        Minimum16 = 0x0020300f,

        /*
         * Range: 0x4000 -> 0x4fff
         * Accuracy
         */

        /// <summary>
        ///     Accuracy Usage.
        /// </summary>
        [Description("Accuracy")]
        Accuracy = 0x00204000,

        /// <summary>
        ///     Accuracy Usage.
        /// </summary>
        [Description("Accuracy")]
        Accuracy2 = 0x00204001,

        /// <summary>
        ///     Accuracy Usage.
        /// </summary>
        [Description("Accuracy")]
        Accuracy3 = 0x00204002,

        /// <summary>
        ///     Accuracy Usage.
        /// </summary>
        [Description("Accuracy")]
        Accuracy4 = 0x00204003,

        /// <summary>
        ///     Accuracy Usage.
        /// </summary>
        [Description("Accuracy")]
        Accuracy5 = 0x00204004,

        /// <summary>
        ///     Accuracy Usage.
        /// </summary>
        [Description("Accuracy")]
        Accuracy6 = 0x00204005,

        /// <summary>
        ///     Accuracy Usage.
        /// </summary>
        [Description("Accuracy")]
        Accuracy7 = 0x00204006,

        /// <summary>
        ///     Accuracy Usage.
        /// </summary>
        [Description("Accuracy")]
        Accuracy8 = 0x00204007,

        /// <summary>
        ///     Accuracy Usage.
        /// </summary>
        [Description("Accuracy")]
        Accuracy9 = 0x00204008,

        /// <summary>
        ///     Accuracy Usage.
        /// </summary>
        [Description("Accuracy")]
        Accuracy10 = 0x00204009,

        /// <summary>
        ///     Accuracy Usage.
        /// </summary>
        [Description("Accuracy")]
        Accuracy11 = 0x0020400a,

        /// <summary>
        ///     Accuracy Usage.
        /// </summary>
        [Description("Accuracy")]
        Accuracy12 = 0x0020400b,

        /// <summary>
        ///     Accuracy Usage.
        /// </summary>
        [Description("Accuracy")]
        Accuracy13 = 0x0020400c,

        /// <summary>
        ///     Accuracy Usage.
        /// </summary>
        [Description("Accuracy")]
        Accuracy14 = 0x0020400d,

        /// <summary>
        ///     Accuracy Usage.
        /// </summary>
        [Description("Accuracy")]
        Accuracy15 = 0x0020400e,

        /// <summary>
        ///     Accuracy Usage.
        /// </summary>
        [Description("Accuracy")]
        Accuracy16 = 0x0020400f,

        /*
         * Range: 0x5000 -> 0x5fff
         * Resolution
         */

        /// <summary>
        ///     Resolution Usage.
        /// </summary>
        [Description("Resolution")]
        Resolution = 0x00205000,

        /// <summary>
        ///     Resolution Usage.
        /// </summary>
        [Description("Resolution")]
        Resolution2 = 0x00205001,

        /// <summary>
        ///     Resolution Usage.
        /// </summary>
        [Description("Resolution")]
        Resolution3 = 0x00205002,

        /// <summary>
        ///     Resolution Usage.
        /// </summary>
        [Description("Resolution")]
        Resolution4 = 0x00205003,

        /// <summary>
        ///     Resolution Usage.
        /// </summary>
        [Description("Resolution")]
        Resolution5 = 0x00205004,

        /// <summary>
        ///     Resolution Usage.
        /// </summary>
        [Description("Resolution")]
        Resolution6 = 0x00205005,

        /// <summary>
        ///     Resolution Usage.
        /// </summary>
        [Description("Resolution")]
        Resolution7 = 0x00205006,

        /// <summary>
        ///     Resolution Usage.
        /// </summary>
        [Description("Resolution")]
        Resolution8 = 0x00205007,

        /// <summary>
        ///     Resolution Usage.
        /// </summary>
        [Description("Resolution")]
        Resolution9 = 0x00205008,

        /// <summary>
        ///     Resolution Usage.
        /// </summary>
        [Description("Resolution")]
        Resolution10 = 0x00205009,

        /// <summary>
        ///     Resolution Usage.
        /// </summary>
        [Description("Resolution")]
        Resolution11 = 0x0020500a,

        /// <summary>
        ///     Resolution Usage.
        /// </summary>
        [Description("Resolution")]
        Resolution12 = 0x0020500b,

        /// <summary>
        ///     Resolution Usage.
        /// </summary>
        [Description("Resolution")]
        Resolution13 = 0x0020500c,

        /// <summary>
        ///     Resolution Usage.
        /// </summary>
        [Description("Resolution")]
        Resolution14 = 0x0020500d,

        /// <summary>
        ///     Resolution Usage.
        /// </summary>
        [Description("Resolution")]
        Resolution15 = 0x0020500e,

        /// <summary>
        ///     Resolution Usage.
        /// </summary>
        [Description("Resolution")]
        Resolution16 = 0x0020500f,

        /*
         * Range: 0x6000 -> 0x6fff
         * Threshold High
         */

        /// <summary>
        ///     Threshold High Usage.
        /// </summary>
        [Description("Threshold High")]
        ThresholdHigh = 0x00206000,

        /// <summary>
        ///     Threshold High Usage.
        /// </summary>
        [Description("Threshold High")]
        ThresholdHigh2 = 0x00206001,

        /// <summary>
        ///     Threshold High Usage.
        /// </summary>
        [Description("Threshold High")]
        ThresholdHigh3 = 0x00206002,

        /// <summary>
        ///     Threshold High Usage.
        /// </summary>
        [Description("Threshold High")]
        ThresholdHigh4 = 0x00206003,

        /// <summary>
        ///     Threshold High Usage.
        /// </summary>
        [Description("Threshold High")]
        ThresholdHigh5 = 0x00206004,

        /// <summary>
        ///     Threshold High Usage.
        /// </summary>
        [Description("Threshold High")]
        ThresholdHigh6 = 0x00206005,

        /// <summary>
        ///     Threshold High Usage.
        /// </summary>
        [Description("Threshold High")]
        ThresholdHigh7 = 0x00206006,

        /// <summary>
        ///     Threshold High Usage.
        /// </summary>
        [Description("Threshold High")]
        ThresholdHigh8 = 0x00206007,

        /// <summary>
        ///     Threshold High Usage.
        /// </summary>
        [Description("Threshold High")]
        ThresholdHigh9 = 0x00206008,

        /// <summary>
        ///     Threshold High Usage.
        /// </summary>
        [Description("Threshold High")]
        ThresholdHigh10 = 0x00206009,

        /// <summary>
        ///     Threshold High Usage.
        /// </summary>
        [Description("Threshold High")]
        ThresholdHigh11 = 0x0020600a,

        /// <summary>
        ///     Threshold High Usage.
        /// </summary>
        [Description("Threshold High")]
        ThresholdHigh12 = 0x0020600b,

        /// <summary>
        ///     Threshold High Usage.
        /// </summary>
        [Description("Threshold High")]
        ThresholdHigh13 = 0x0020600c,

        /// <summary>
        ///     Threshold High Usage.
        /// </summary>
        [Description("Threshold High")]
        ThresholdHigh14 = 0x0020600d,

        /// <summary>
        ///     Threshold High Usage.
        /// </summary>
        [Description("Threshold High")]
        ThresholdHigh15 = 0x0020600e,

        /// <summary>
        ///     Threshold High Usage.
        /// </summary>
        [Description("Threshold High")]
        ThresholdHigh16 = 0x0020600f,

        /*
         * Range: 0x7000 -> 0x7fff
         * Threshold Low
         */

        /// <summary>
        ///     Threshold Low Usage.
        /// </summary>
        [Description("Threshold Low")]
        ThresholdLow = 0x00207000,

        /// <summary>
        ///     Threshold Low Usage.
        /// </summary>
        [Description("Threshold Low")]
        ThresholdLow2 = 0x00207001,

        /// <summary>
        ///     Threshold Low Usage.
        /// </summary>
        [Description("Threshold Low")]
        ThresholdLow3 = 0x00207002,

        /// <summary>
        ///     Threshold Low Usage.
        /// </summary>
        [Description("Threshold Low")]
        ThresholdLow4 = 0x00207003,

        /// <summary>
        ///     Threshold Low Usage.
        /// </summary>
        [Description("Threshold Low")]
        ThresholdLow5 = 0x00207004,

        /// <summary>
        ///     Threshold Low Usage.
        /// </summary>
        [Description("Threshold Low")]
        ThresholdLow6 = 0x00207005,

        /// <summary>
        ///     Threshold Low Usage.
        /// </summary>
        [Description("Threshold Low")]
        ThresholdLow7 = 0x00207006,

        /// <summary>
        ///     Threshold Low Usage.
        /// </summary>
        [Description("Threshold Low")]
        ThresholdLow8 = 0x00207007,

        /// <summary>
        ///     Threshold Low Usage.
        /// </summary>
        [Description("Threshold Low")]
        ThresholdLow9 = 0x00207008,

        /// <summary>
        ///     Threshold Low Usage.
        /// </summary>
        [Description("Threshold Low")]
        ThresholdLow10 = 0x00207009,

        /// <summary>
        ///     Threshold Low Usage.
        /// </summary>
        [Description("Threshold Low")]
        ThresholdLow11 = 0x0020700a,

        /// <summary>
        ///     Threshold Low Usage.
        /// </summary>
        [Description("Threshold Low")]
        ThresholdLow12 = 0x0020700b,

        /// <summary>
        ///     Threshold Low Usage.
        /// </summary>
        [Description("Threshold Low")]
        ThresholdLow13 = 0x0020700c,

        /// <summary>
        ///     Threshold Low Usage.
        /// </summary>
        [Description("Threshold Low")]
        ThresholdLow14 = 0x0020700d,

        /// <summary>
        ///     Threshold Low Usage.
        /// </summary>
        [Description("Threshold Low")]
        ThresholdLow15 = 0x0020700e,

        /// <summary>
        ///     Threshold Low Usage.
        /// </summary>
        [Description("Threshold Low")]
        ThresholdLow16 = 0x0020700f,

        /*
         * Range: 0x8000 -> 0x8fff
         * Calibration Offset
         */

        /// <summary>
        ///     Calibration Offset Usage.
        /// </summary>
        [Description("Calibration Offset")]
        CalibrationOffset = 0x00208000,

        /// <summary>
        ///     Calibration Offset Usage.
        /// </summary>
        [Description("Calibration Offset")]
        CalibrationOffset2 = 0x00208001,

        /// <summary>
        ///     Calibration Offset Usage.
        /// </summary>
        [Description("Calibration Offset")]
        CalibrationOffset3 = 0x00208002,

        /// <summary>
        ///     Calibration Offset Usage.
        /// </summary>
        [Description("Calibration Offset")]
        CalibrationOffset4 = 0x00208003,

        /// <summary>
        ///     Calibration Offset Usage.
        /// </summary>
        [Description("Calibration Offset")]
        CalibrationOffset5 = 0x00208004,

        /// <summary>
        ///     Calibration Offset Usage.
        /// </summary>
        [Description("Calibration Offset")]
        CalibrationOffset6 = 0x00208005,

        /// <summary>
        ///     Calibration Offset Usage.
        /// </summary>
        [Description("Calibration Offset")]
        CalibrationOffset7 = 0x00208006,

        /// <summary>
        ///     Calibration Offset Usage.
        /// </summary>
        [Description("Calibration Offset")]
        CalibrationOffset8 = 0x00208007,

        /// <summary>
        ///     Calibration Offset Usage.
        /// </summary>
        [Description("Calibration Offset")]
        CalibrationOffset9 = 0x00208008,

        /// <summary>
        ///     Calibration Offset Usage.
        /// </summary>
        [Description("Calibration Offset")]
        CalibrationOffset10 = 0x00208009,

        /// <summary>
        ///     Calibration Offset Usage.
        /// </summary>
        [Description("Calibration Offset")]
        CalibrationOffset11 = 0x0020800a,

        /// <summary>
        ///     Calibration Offset Usage.
        /// </summary>
        [Description("Calibration Offset")]
        CalibrationOffset12 = 0x0020800b,

        /// <summary>
        ///     Calibration Offset Usage.
        /// </summary>
        [Description("Calibration Offset")]
        CalibrationOffset13 = 0x0020800c,

        /// <summary>
        ///     Calibration Offset Usage.
        /// </summary>
        [Description("Calibration Offset")]
        CalibrationOffset14 = 0x0020800d,

        /// <summary>
        ///     Calibration Offset Usage.
        /// </summary>
        [Description("Calibration Offset")]
        CalibrationOffset15 = 0x0020800e,

        /// <summary>
        ///     Calibration Offset Usage.
        /// </summary>
        [Description("Calibration Offset")]
        CalibrationOffset16 = 0x0020800f,

        /*
         * Range: 0x9000 -> 0x9fff
         * Calibration Multiplier
         */

        /// <summary>
        ///     Calibration Multiplier Usage.
        /// </summary>
        [Description("Calibration Multiplier")]
        CalibrationMultiplier = 0x00209000,

        /// <summary>
        ///     Calibration Multiplier Usage.
        /// </summary>
        [Description("Calibration Multiplier")]
        CalibrationMultiplier2 = 0x00209001,

        /// <summary>
        ///     Calibration Multiplier Usage.
        /// </summary>
        [Description("Calibration Multiplier")]
        CalibrationMultiplier3 = 0x00209002,

        /// <summary>
        ///     Calibration Multiplier Usage.
        /// </summary>
        [Description("Calibration Multiplier")]
        CalibrationMultiplier4 = 0x00209003,

        /// <summary>
        ///     Calibration Multiplier Usage.
        /// </summary>
        [Description("Calibration Multiplier")]
        CalibrationMultiplier5 = 0x00209004,

        /// <summary>
        ///     Calibration Multiplier Usage.
        /// </summary>
        [Description("Calibration Multiplier")]
        CalibrationMultiplier6 = 0x00209005,

        /// <summary>
        ///     Calibration Multiplier Usage.
        /// </summary>
        [Description("Calibration Multiplier")]
        CalibrationMultiplier7 = 0x00209006,

        /// <summary>
        ///     Calibration Multiplier Usage.
        /// </summary>
        [Description("Calibration Multiplier")]
        CalibrationMultiplier8 = 0x00209007,

        /// <summary>
        ///     Calibration Multiplier Usage.
        /// </summary>
        [Description("Calibration Multiplier")]
        CalibrationMultiplier9 = 0x00209008,

        /// <summary>
        ///     Calibration Multiplier Usage.
        /// </summary>
        [Description("Calibration Multiplier")]
        CalibrationMultiplier10 = 0x00209009,

        /// <summary>
        ///     Calibration Multiplier Usage.
        /// </summary>
        [Description("Calibration Multiplier")]
        CalibrationMultiplier11 = 0x0020900a,

        /// <summary>
        ///     Calibration Multiplier Usage.
        /// </summary>
        [Description("Calibration Multiplier")]
        CalibrationMultiplier12 = 0x0020900b,

        /// <summary>
        ///     Calibration Multiplier Usage.
        /// </summary>
        [Description("Calibration Multiplier")]
        CalibrationMultiplier13 = 0x0020900c,

        /// <summary>
        ///     Calibration Multiplier Usage.
        /// </summary>
        [Description("Calibration Multiplier")]
        CalibrationMultiplier14 = 0x0020900d,

        /// <summary>
        ///     Calibration Multiplier Usage.
        /// </summary>
        [Description("Calibration Multiplier")]
        CalibrationMultiplier15 = 0x0020900e,

        /// <summary>
        ///     Calibration Multiplier Usage.
        /// </summary>
        [Description("Calibration Multiplier")]
        CalibrationMultiplier16 = 0x0020900f,

        /*
         * Range: 0xa000 -> 0xafff
         * Report Interval
         */

        /// <summary>
        ///     Report Interval Usage.
        /// </summary>
        [Description("Report Interval")]
        ReportInterval = 0x0020a000,

        /// <summary>
        ///     Report Interval Usage.
        /// </summary>
        [Description("Report Interval")]
        ReportInterval2 = 0x0020a001,

        /// <summary>
        ///     Report Interval Usage.
        /// </summary>
        [Description("Report Interval")]
        ReportInterval3 = 0x0020a002,

        /// <summary>
        ///     Report Interval Usage.
        /// </summary>
        [Description("Report Interval")]
        ReportInterval4 = 0x0020a003,

        /// <summary>
        ///     Report Interval Usage.
        /// </summary>
        [Description("Report Interval")]
        ReportInterval5 = 0x0020a004,

        /// <summary>
        ///     Report Interval Usage.
        /// </summary>
        [Description("Report Interval")]
        ReportInterval6 = 0x0020a005,

        /// <summary>
        ///     Report Interval Usage.
        /// </summary>
        [Description("Report Interval")]
        ReportInterval7 = 0x0020a006,

        /// <summary>
        ///     Report Interval Usage.
        /// </summary>
        [Description("Report Interval")]
        ReportInterval8 = 0x0020a007,

        /// <summary>
        ///     Report Interval Usage.
        /// </summary>
        [Description("Report Interval")]
        ReportInterval9 = 0x0020a008,

        /// <summary>
        ///     Report Interval Usage.
        /// </summary>
        [Description("Report Interval")]
        ReportInterval10 = 0x0020a009,

        /// <summary>
        ///     Report Interval Usage.
        /// </summary>
        [Description("Report Interval")]
        ReportInterval11 = 0x0020a00a,

        /// <summary>
        ///     Report Interval Usage.
        /// </summary>
        [Description("Report Interval")]
        ReportInterval12 = 0x0020a00b,

        /// <summary>
        ///     Report Interval Usage.
        /// </summary>
        [Description("Report Interval")]
        ReportInterval13 = 0x0020a00c,

        /// <summary>
        ///     Report Interval Usage.
        /// </summary>
        [Description("Report Interval")]
        ReportInterval14 = 0x0020a00d,

        /// <summary>
        ///     Report Interval Usage.
        /// </summary>
        [Description("Report Interval")]
        ReportInterval15 = 0x0020a00e,

        /// <summary>
        ///     Report Interval Usage.
        /// </summary>
        [Description("Report Interval")]
        ReportInterval16 = 0x0020a00f,

        /*
         * Range: 0xb000 -> 0xbfff
         * Frequency Max
         */

        /// <summary>
        ///     Frequency Max Usage.
        /// </summary>
        [Description("Frequency Max")]
        FrequencyMax = 0x0020b000,

        /// <summary>
        ///     Frequency Max Usage.
        /// </summary>
        [Description("Frequency Max")]
        FrequencyMax2 = 0x0020b001,

        /// <summary>
        ///     Frequency Max Usage.
        /// </summary>
        [Description("Frequency Max")]
        FrequencyMax3 = 0x0020b002,

        /// <summary>
        ///     Frequency Max Usage.
        /// </summary>
        [Description("Frequency Max")]
        FrequencyMax4 = 0x0020b003,

        /// <summary>
        ///     Frequency Max Usage.
        /// </summary>
        [Description("Frequency Max")]
        FrequencyMax5 = 0x0020b004,

        /// <summary>
        ///     Frequency Max Usage.
        /// </summary>
        [Description("Frequency Max")]
        FrequencyMax6 = 0x0020b005,

        /// <summary>
        ///     Frequency Max Usage.
        /// </summary>
        [Description("Frequency Max")]
        FrequencyMax7 = 0x0020b006,

        /// <summary>
        ///     Frequency Max Usage.
        /// </summary>
        [Description("Frequency Max")]
        FrequencyMax8 = 0x0020b007,

        /// <summary>
        ///     Frequency Max Usage.
        /// </summary>
        [Description("Frequency Max")]
        FrequencyMax9 = 0x0020b008,

        /// <summary>
        ///     Frequency Max Usage.
        /// </summary>
        [Description("Frequency Max")]
        FrequencyMax10 = 0x0020b009,

        /// <summary>
        ///     Frequency Max Usage.
        /// </summary>
        [Description("Frequency Max")]
        FrequencyMax11 = 0x0020b00a,

        /// <summary>
        ///     Frequency Max Usage.
        /// </summary>
        [Description("Frequency Max")]
        FrequencyMax12 = 0x0020b00b,

        /// <summary>
        ///     Frequency Max Usage.
        /// </summary>
        [Description("Frequency Max")]
        FrequencyMax13 = 0x0020b00c,

        /// <summary>
        ///     Frequency Max Usage.
        /// </summary>
        [Description("Frequency Max")]
        FrequencyMax14 = 0x0020b00d,

        /// <summary>
        ///     Frequency Max Usage.
        /// </summary>
        [Description("Frequency Max")]
        FrequencyMax15 = 0x0020b00e,

        /// <summary>
        ///     Frequency Max Usage.
        /// </summary>
        [Description("Frequency Max")]
        FrequencyMax16 = 0x0020b00f,

        /*
         * Range: 0xc000 -> 0xcfff
         * Period Max
         */

        /// <summary>
        ///     Period Max Usage.
        /// </summary>
        [Description("Period Max")]
        PeriodMax = 0x0020c000,

        /// <summary>
        ///     Period Max Usage.
        /// </summary>
        [Description("Period Max")]
        PeriodMax2 = 0x0020c001,

        /// <summary>
        ///     Period Max Usage.
        /// </summary>
        [Description("Period Max")]
        PeriodMax3 = 0x0020c002,

        /// <summary>
        ///     Period Max Usage.
        /// </summary>
        [Description("Period Max")]
        PeriodMax4 = 0x0020c003,

        /// <summary>
        ///     Period Max Usage.
        /// </summary>
        [Description("Period Max")]
        PeriodMax5 = 0x0020c004,

        /// <summary>
        ///     Period Max Usage.
        /// </summary>
        [Description("Period Max")]
        PeriodMax6 = 0x0020c005,

        /// <summary>
        ///     Period Max Usage.
        /// </summary>
        [Description("Period Max")]
        PeriodMax7 = 0x0020c006,

        /// <summary>
        ///     Period Max Usage.
        /// </summary>
        [Description("Period Max")]
        PeriodMax8 = 0x0020c007,

        /// <summary>
        ///     Period Max Usage.
        /// </summary>
        [Description("Period Max")]
        PeriodMax9 = 0x0020c008,

        /// <summary>
        ///     Period Max Usage.
        /// </summary>
        [Description("Period Max")]
        PeriodMax10 = 0x0020c009,

        /// <summary>
        ///     Period Max Usage.
        /// </summary>
        [Description("Period Max")]
        PeriodMax11 = 0x0020c00a,

        /// <summary>
        ///     Period Max Usage.
        /// </summary>
        [Description("Period Max")]
        PeriodMax12 = 0x0020c00b,

        /// <summary>
        ///     Period Max Usage.
        /// </summary>
        [Description("Period Max")]
        PeriodMax13 = 0x0020c00c,

        /// <summary>
        ///     Period Max Usage.
        /// </summary>
        [Description("Period Max")]
        PeriodMax14 = 0x0020c00d,

        /// <summary>
        ///     Period Max Usage.
        /// </summary>
        [Description("Period Max")]
        PeriodMax15 = 0x0020c00e,

        /// <summary>
        ///     Period Max Usage.
        /// </summary>
        [Description("Period Max")]
        PeriodMax16 = 0x0020c00f,

        /*
         * Range: 0xd000 -> 0xdfff
         * Change Sensitivity Percent of Range
         */

        /// <summary>
        ///     Change Sensitivity Percent of Range Usage.
        /// </summary>
        [Description("Change Sensitivity Percent of Range")]
        ChangeSensitivityPercentOfRange = 0x0020d000,

        /// <summary>
        ///     Change Sensitivity Percent of Range Usage.
        /// </summary>
        [Description("Change Sensitivity Percent of Range")]
        ChangeSensitivityPercentOfRange2 = 0x0020d001,

        /// <summary>
        ///     Change Sensitivity Percent of Range Usage.
        /// </summary>
        [Description("Change Sensitivity Percent of Range")]
        ChangeSensitivityPercentOfRange3 = 0x0020d002,

        /// <summary>
        ///     Change Sensitivity Percent of Range Usage.
        /// </summary>
        [Description("Change Sensitivity Percent of Range")]
        ChangeSensitivityPercentOfRange4 = 0x0020d003,

        /// <summary>
        ///     Change Sensitivity Percent of Range Usage.
        /// </summary>
        [Description("Change Sensitivity Percent of Range")]
        ChangeSensitivityPercentOfRange5 = 0x0020d004,

        /// <summary>
        ///     Change Sensitivity Percent of Range Usage.
        /// </summary>
        [Description("Change Sensitivity Percent of Range")]
        ChangeSensitivityPercentOfRange6 = 0x0020d005,

        /// <summary>
        ///     Change Sensitivity Percent of Range Usage.
        /// </summary>
        [Description("Change Sensitivity Percent of Range")]
        ChangeSensitivityPercentOfRange7 = 0x0020d006,

        /// <summary>
        ///     Change Sensitivity Percent of Range Usage.
        /// </summary>
        [Description("Change Sensitivity Percent of Range")]
        ChangeSensitivityPercentOfRange8 = 0x0020d007,

        /// <summary>
        ///     Change Sensitivity Percent of Range Usage.
        /// </summary>
        [Description("Change Sensitivity Percent of Range")]
        ChangeSensitivityPercentOfRange9 = 0x0020d008,

        /// <summary>
        ///     Change Sensitivity Percent of Range Usage.
        /// </summary>
        [Description("Change Sensitivity Percent of Range")]
        ChangeSensitivityPercentOfRange10 = 0x0020d009,

        /// <summary>
        ///     Change Sensitivity Percent of Range Usage.
        /// </summary>
        [Description("Change Sensitivity Percent of Range")]
        ChangeSensitivityPercentOfRange11 = 0x0020d00a,

        /// <summary>
        ///     Change Sensitivity Percent of Range Usage.
        /// </summary>
        [Description("Change Sensitivity Percent of Range")]
        ChangeSensitivityPercentOfRange12 = 0x0020d00b,

        /// <summary>
        ///     Change Sensitivity Percent of Range Usage.
        /// </summary>
        [Description("Change Sensitivity Percent of Range")]
        ChangeSensitivityPercentOfRange13 = 0x0020d00c,

        /// <summary>
        ///     Change Sensitivity Percent of Range Usage.
        /// </summary>
        [Description("Change Sensitivity Percent of Range")]
        ChangeSensitivityPercentOfRange14 = 0x0020d00d,

        /// <summary>
        ///     Change Sensitivity Percent of Range Usage.
        /// </summary>
        [Description("Change Sensitivity Percent of Range")]
        ChangeSensitivityPercentOfRange15 = 0x0020d00e,

        /// <summary>
        ///     Change Sensitivity Percent of Range Usage.
        /// </summary>
        [Description("Change Sensitivity Percent of Range")]
        ChangeSensitivityPercentOfRange16 = 0x0020d00f,

        /*
         * Range: 0xe000 -> 0xefff
         * Change Sensitivity Percent Relative
         */

        /// <summary>
        ///     Change Sensitivity Percent Relative Usage.
        /// </summary>
        [Description("Change Sensitivity Percent Relative")]
        ChangeSensitivityPercentRelative = 0x0020e000,

        /// <summary>
        ///     Change Sensitivity Percent Relative Usage.
        /// </summary>
        [Description("Change Sensitivity Percent Relative")]
        ChangeSensitivityPercentRelative2 = 0x0020e001,

        /// <summary>
        ///     Change Sensitivity Percent Relative Usage.
        /// </summary>
        [Description("Change Sensitivity Percent Relative")]
        ChangeSensitivityPercentRelative3 = 0x0020e002,

        /// <summary>
        ///     Change Sensitivity Percent Relative Usage.
        /// </summary>
        [Description("Change Sensitivity Percent Relative")]
        ChangeSensitivityPercentRelative4 = 0x0020e003,

        /// <summary>
        ///     Change Sensitivity Percent Relative Usage.
        /// </summary>
        [Description("Change Sensitivity Percent Relative")]
        ChangeSensitivityPercentRelative5 = 0x0020e004,

        /// <summary>
        ///     Change Sensitivity Percent Relative Usage.
        /// </summary>
        [Description("Change Sensitivity Percent Relative")]
        ChangeSensitivityPercentRelative6 = 0x0020e005,

        /// <summary>
        ///     Change Sensitivity Percent Relative Usage.
        /// </summary>
        [Description("Change Sensitivity Percent Relative")]
        ChangeSensitivityPercentRelative7 = 0x0020e006,

        /// <summary>
        ///     Change Sensitivity Percent Relative Usage.
        /// </summary>
        [Description("Change Sensitivity Percent Relative")]
        ChangeSensitivityPercentRelative8 = 0x0020e007,

        /// <summary>
        ///     Change Sensitivity Percent Relative Usage.
        /// </summary>
        [Description("Change Sensitivity Percent Relative")]
        ChangeSensitivityPercentRelative9 = 0x0020e008,

        /// <summary>
        ///     Change Sensitivity Percent Relative Usage.
        /// </summary>
        [Description("Change Sensitivity Percent Relative")]
        ChangeSensitivityPercentRelative10 = 0x0020e009,

        /// <summary>
        ///     Change Sensitivity Percent Relative Usage.
        /// </summary>
        [Description("Change Sensitivity Percent Relative")]
        ChangeSensitivityPercentRelative11 = 0x0020e00a,

        /// <summary>
        ///     Change Sensitivity Percent Relative Usage.
        /// </summary>
        [Description("Change Sensitivity Percent Relative")]
        ChangeSensitivityPercentRelative12 = 0x0020e00b,

        /// <summary>
        ///     Change Sensitivity Percent Relative Usage.
        /// </summary>
        [Description("Change Sensitivity Percent Relative")]
        ChangeSensitivityPercentRelative13 = 0x0020e00c,

        /// <summary>
        ///     Change Sensitivity Percent Relative Usage.
        /// </summary>
        [Description("Change Sensitivity Percent Relative")]
        ChangeSensitivityPercentRelative14 = 0x0020e00d,

        /// <summary>
        ///     Change Sensitivity Percent Relative Usage.
        /// </summary>
        [Description("Change Sensitivity Percent Relative")]
        ChangeSensitivityPercentRelative15 = 0x0020e00e,

        /// <summary>
        ///     Change Sensitivity Percent Relative Usage.
        /// </summary>
        [Description("Change Sensitivity Percent Relative")]
        ChangeSensitivityPercentRelative16 = 0x0020e00f
    }

    /// <summary>
    ///     Medical Instruments Usage Page.
    /// </summary>
    [Description("Medical Instruments Usage Page")]
    public enum MedicalInstrumentsPage : uint
    {
        /// <summary>
        ///     Undefined Usage.
        /// </summary>
        [Description("Undefined")]
        Undefined = 0x00400000,

        /// <summary>
        ///     Medical Ultrasound Usage.
        /// </summary>
        [Description("Medical Ultrasound")]
        MedicalUltrasound = 0x00400001,

        /// <summary>
        ///     VCR/Acquisition Usage.
        /// </summary>
        [Description("VCR/Acquisition")]
        VCRAcquisition = 0x00400020,

        /// <summary>
        ///     Freeze/Thaw Usage.
        /// </summary>
        [Description("Freeze/Thaw")]
        FreezeThaw = 0x00400021,

        /// <summary>
        ///     Clip Store Usage.
        /// </summary>
        [Description("Clip Store")]
        ClipStore = 0x00400022,

        /// <summary>
        ///     Update Usage.
        /// </summary>
        [Description("Update")]
        Update = 0x00400023,

        /// <summary>
        ///     Next Usage.
        /// </summary>
        [Description("Next")]
        Next = 0x00400024,

        /// <summary>
        ///     Save Usage.
        /// </summary>
        [Description("Save")]
        Save = 0x00400025,

        /// <summary>
        ///     Print Usage.
        /// </summary>
        [Description("Print")]
        Print = 0x00400026,

        /// <summary>
        ///     Microphone Enable Usage.
        /// </summary>
        [Description("Microphone Enable")]
        MicrophoneEnable = 0x00400027,

        /// <summary>
        ///     Cine Usage.
        /// </summary>
        [Description("Cine")]
        Cine = 0x00400040,

        /// <summary>
        ///     Transmit Power Usage.
        /// </summary>
        [Description("Transmit Power")]
        TransmitPower = 0x00400041,

        /// <summary>
        ///     Volume Usage.
        /// </summary>
        [Description("Volume")]
        Volume = 0x00400042,

        /// <summary>
        ///     Focus Usage.
        /// </summary>
        [Description("Focus")]
        Focus = 0x00400043,

        /// <summary>
        ///     Depth Usage.
        /// </summary>
        [Description("Depth")]
        Depth = 0x00400044,

        /// <summary>
        ///     Soft Step - Primary Usage.
        /// </summary>
        [Description("Soft Step - Primary")]
        SoftStepPrimary = 0x00400060,

        /// <summary>
        ///     Soft Step - Secondary Usage.
        /// </summary>
        [Description("Soft Step - Secondary")]
        SoftStepSecondary = 0x00400061,

        /// <summary>
        ///     Depth Gain Compensation Usage.
        /// </summary>
        [Description("Depth Gain Compensation")]
        DepthGainCompensation = 0x00400070,

        /// <summary>
        ///     Zoom Select Usage.
        /// </summary>
        [Description("Zoom Select")]
        ZoomSelect = 0x00400080,

        /// <summary>
        ///     Zoom Adjust Usage.
        /// </summary>
        [Description("Zoom Adjust")]
        ZoomAdjust = 0x00400081,

        /// <summary>
        ///     Spectral Doppler Mode Select Usage.
        /// </summary>
        [Description("Spectral Doppler Mode Select")]
        SpectralDopplerModeSelect = 0x00400082,

        /// <summary>
        ///     Spectral Doppler Adjust Usage.
        /// </summary>
        [Description("Spectral Doppler Adjust")]
        SpectralDopplerAdjust = 0x00400083,

        /// <summary>
        ///     Color Doppler Mode Select Usage.
        /// </summary>
        [Description("Color Doppler Mode Select")]
        ColorDopplerModeSelect = 0x00400084,

        /// <summary>
        ///     Color Doppler Adjust Usage.
        /// </summary>
        [Description("Color Doppler Adjust")]
        ColorDopplerAdjust = 0x00400085,

        /// <summary>
        ///     Motion Mode Select Usage.
        /// </summary>
        [Description("Motion Mode Select")]
        MotionModeSelect = 0x00400086,

        /// <summary>
        ///     Motion Mode Adjust Usage.
        /// </summary>
        [Description("Motion Mode Adjust")]
        MotionModeAdjust = 0x00400087,

        /// <summary>
        ///     2D Mode Select Usage.
        /// </summary>
        [Description("2D Mode Select")]
        DModeSelect = 0x00400088,

        /// <summary>
        ///     2D Mode Adjust Usage.
        /// </summary>
        [Description("2D Mode Adjust")]
        DModeAdjust = 0x00400089,

        /// <summary>
        ///     Soft Control Select Usage.
        /// </summary>
        [Description("Soft Control Select")]
        SoftControlSelect = 0x004000a0,

        /// <summary>
        ///     Soft Control Adjust Usage.
        /// </summary>
        [Description("Soft Control Adjust")]
        SoftControlAdjust = 0x004000a1
    }

    /// <summary>
    ///     Braille Display Usage Page.
    /// </summary>
    [Description("Braille Display Usage Page")]
    public enum BrailleDisplayPage : uint
    {
        /// <summary>
        ///     Undefined Usage.
        /// </summary>
        [Description("Undefined")]
        Undefined = 0x00410000,

        /// <summary>
        ///     Braille Display Usage.
        /// </summary>
        [Description("Braille Display")]
        BrailleDisplay = 0x00410001,

        /// <summary>
        ///     Braille Row Usage.
        /// </summary>
        [Description("Braille Row")]
        BrailleRow = 0x00410002,

        /// <summary>
        ///     8 Dot Braille Cell Usage.
        /// </summary>
        [Description("8 Dot Braille Cell")]
        DotBrailleCell = 0x00410003,

        /// <summary>
        ///     6 Dot Braille Cell Usage.
        /// </summary>
        [Description("6 Dot Braille Cell")]
        DotBrailleCell2 = 0x00410004,

        /// <summary>
        ///     Number of Braille Cells Usage.
        /// </summary>
        [Description("Number of Braille Cells")]
        NumberOfBrailleCells = 0x00410005,

        /// <summary>
        ///     Screen Reader Control Usage.
        /// </summary>
        [Description("Screen Reader Control")]
        ScreenReaderControl = 0x00410006,

        /// <summary>
        ///     Screen Reader Identifier Usage.
        /// </summary>
        [Description("Screen Reader Identifier")]
        ScreenReaderIdentifier = 0x00410007,

        /*
         * Range: 0x00fa -> 0x00fc
         * Router Set {n+1}
         */

        /// <summary>
        ///     Router Set 1 Usage.
        /// </summary>
        [Description("Router Set 1")]
        RouterSet1 = 0x004100fa,

        /// <summary>
        ///     Router Set 2 Usage.
        /// </summary>
        [Description("Router Set 2")]
        RouterSet2 = 0x004100fb,

        /// <summary>
        ///     Router Set 3 Usage.
        /// </summary>
        [Description("Router Set 3")]
        RouterSet3 = 0x004100fc,

        /// <summary>
        ///     Braille Buttons Usage.
        /// </summary>
        [Description("Braille Buttons")]
        BrailleButtons = 0x00410100,

        /*
         * Range: 0x0201 -> 0x0208
         * Braille Keyboard Dot {n+1}
         */

        /// <summary>
        ///     Braille Keyboard Dot 1 Usage.
        /// </summary>
        [Description("Braille Keyboard Dot 1")]
        BrailleKeyboardDot1 = 0x00410201,

        /// <summary>
        ///     Braille Keyboard Dot 2 Usage.
        /// </summary>
        [Description("Braille Keyboard Dot 2")]
        BrailleKeyboardDot2 = 0x00410202,

        /// <summary>
        ///     Braille Keyboard Dot 3 Usage.
        /// </summary>
        [Description("Braille Keyboard Dot 3")]
        BrailleKeyboardDot3 = 0x00410203,

        /// <summary>
        ///     Braille Keyboard Dot 4 Usage.
        /// </summary>
        [Description("Braille Keyboard Dot 4")]
        BrailleKeyboardDot4 = 0x00410204,

        /// <summary>
        ///     Braille Keyboard Dot 5 Usage.
        /// </summary>
        [Description("Braille Keyboard Dot 5")]
        BrailleKeyboardDot5 = 0x00410205,

        /// <summary>
        ///     Braille Keyboard Dot 6 Usage.
        /// </summary>
        [Description("Braille Keyboard Dot 6")]
        BrailleKeyboardDot6 = 0x00410206,

        /// <summary>
        ///     Braille Keyboard Dot 7 Usage.
        /// </summary>
        [Description("Braille Keyboard Dot 7")]
        BrailleKeyboardDot7 = 0x00410207,

        /// <summary>
        ///     Braille Keyboard Dot 8 Usage.
        /// </summary>
        [Description("Braille Keyboard Dot 8")]
        BrailleKeyboardDot8 = 0x00410208,

        /// <summary>
        ///     Braille Keyboard Space Usage.
        /// </summary>
        [Description("Braille Keyboard Space")]
        BrailleKeyboardSpace = 0x00410209,

        /// <summary>
        ///     Braille Keyboard Left Space Usage.
        /// </summary>
        [Description("Braille Keyboard Left Space")]
        BrailleKeyboardLeftSpace = 0x0041020a,

        /// <summary>
        ///     Braille Keyboard Right Space Usage.
        /// </summary>
        [Description("Braille Keyboard Right Space")]
        BrailleKeyboardRightSpace = 0x0041020b,

        /// <summary>
        ///     Braille Face Controls Usage.
        /// </summary>
        [Description("Braille Face Controls")]
        BrailleFaceControls = 0x0041020c,

        /// <summary>
        ///     Braille Left Controls Usage.
        /// </summary>
        [Description("Braille Left Controls")]
        BrailleLeftControls = 0x0041020d,

        /// <summary>
        ///     Braille Right Controls Usage.
        /// </summary>
        [Description("Braille Right Controls")]
        BrailleRightControls = 0x0041020e,

        /// <summary>
        ///     Braille Top Controls Usage.
        /// </summary>
        [Description("Braille Top Controls")]
        BrailleTopControls = 0x0041020f,

        /// <summary>
        ///     Braille Joystick Center Usage.
        /// </summary>
        [Description("Braille Joystick Center")]
        BrailleJoystickCenter = 0x00410210,

        /// <summary>
        ///     Braille Joystick Up Usage.
        /// </summary>
        [Description("Braille Joystick Up")]
        BrailleJoystickUp = 0x00410211,

        /// <summary>
        ///     Braille Joystick Down Usage.
        /// </summary>
        [Description("Braille Joystick Down")]
        BrailleJoystickDown = 0x00410212,

        /// <summary>
        ///     Braille Joystick Left Usage.
        /// </summary>
        [Description("Braille Joystick Left")]
        BrailleJoystickLeft = 0x00410213,

        /// <summary>
        ///     Braille Joystick Right Usage.
        /// </summary>
        [Description("Braille Joystick Right")]
        BrailleJoystickRight = 0x00410214,

        /// <summary>
        ///     Braille D-pad Center Usage.
        /// </summary>
        [Description("Braille D-pad Center")]
        BrailleDpadCenter = 0x00410215,

        /// <summary>
        ///     Braille D-pad Up Usage.
        /// </summary>
        [Description("Braille D-pad Up")]
        BrailleDpadUp = 0x00410216,

        /// <summary>
        ///     Braille D-pad Down Usage.
        /// </summary>
        [Description("Braille D-pad Down")]
        BrailleDpadDown = 0x00410217,

        /// <summary>
        ///     Braille D-pad Left Usage.
        /// </summary>
        [Description("Braille D-pad Left")]
        BrailleDpadLeft = 0x00410218,

        /// <summary>
        ///     Braille D-pad Right Usage.
        /// </summary>
        [Description("Braille D-pad Right")]
        BrailleDpadRight = 0x00410219,

        /// <summary>
        ///     Braille Pan Left Usage.
        /// </summary>
        [Description("Braille Pan Left")]
        BraillePanLeft = 0x0041021a,

        /// <summary>
        ///     Braille Pan Right Usage.
        /// </summary>
        [Description("Braille Pan Right")]
        BraillePanRight = 0x0041021b,

        /// <summary>
        ///     Braille Rocker Up Usage.
        /// </summary>
        [Description("Braille Rocker Up")]
        BrailleRockerUp = 0x0041021c,

        /// <summary>
        ///     Braille Rocker Down Usage.
        /// </summary>
        [Description("Braille Rocker Down")]
        BrailleRockerDown = 0x0041021d,

        /// <summary>
        ///     Braille Rocker Press Usage.
        /// </summary>
        [Description("Braille Rocker Press")]
        BrailleRockerPress = 0x0041021e
    }

    /// <summary>
    ///     Lighting and Illumination Usage Page.
    /// </summary>
    [Description("Lighting and Illumination Usage Page")]
    public enum LightingAndIlluminationPage : uint
    {
        /// <summary>
        ///     Undefined Usage.
        /// </summary>
        [Description("Undefined")]
        Undefined = 0x00590000,

        /// <summary>
        ///     Lamp Array Usage.
        /// </summary>
        [Description("Lamp Array")]
        LampArray = 0x00590001,

        /// <summary>
        ///     Lamp Array Attributes Report Usage.
        /// </summary>
        [Description("Lamp Array Attributes Report")]
        LampArrayAttributesReport = 0x00590002,

        /// <summary>
        ///     Lamp Count Usage.
        /// </summary>
        [Description("Lamp Count")]
        LampCount = 0x00590003,

        /// <summary>
        ///     Bounding Box Width (um) Usage.
        /// </summary>
        [Description("Bounding Box Width (um)")]
        BoundingBoxWidthUm = 0x00590004,

        /// <summary>
        ///     Bounding Box Height (um) Usage.
        /// </summary>
        [Description("Bounding Box Height (um)")]
        BoundingBoxHeightUm = 0x00590005,

        /// <summary>
        ///     Bounding Box Depth (um) Usage.
        /// </summary>
        [Description("Bounding Box Depth (um)")]
        BoundingBoxDepthUm = 0x00590006,

        /// <summary>
        ///     Lamp Array Kind Usage.
        /// </summary>
        [Description("Lamp Array Kind")]
        LampArrayKind = 0x00590007,

        /// <summary>
        ///     Minimal Update Interval (us) Usage.
        /// </summary>
        [Description("Minimal Update Interval (us)")]
        MinimalUpdateIntervalUs = 0x00590008,

        /// <summary>
        ///     Lamp Attributes Request Report Usage.
        /// </summary>
        [Description("Lamp Attributes Request Report")]
        LampAttributesRequestReport = 0x00590020,

        /// <summary>
        ///     Lamp ID Usage.
        /// </summary>
        [Description("Lamp ID")]
        LampID = 0x00590021,

        /// <summary>
        ///     Lamp Attributes Response Report Usage.
        /// </summary>
        [Description("Lamp Attributes Response Report")]
        LampAttributesResponseReport = 0x00590022,

        /// <summary>
        ///     Position X (um) Usage.
        /// </summary>
        [Description("Position X (um)")]
        PositionXUm = 0x00590023,

        /// <summary>
        ///     Position Y (um) Usage.
        /// </summary>
        [Description("Position Y (um)")]
        PositionYUm = 0x00590024,

        /// <summary>
        ///     Position Z (um) Usage.
        /// </summary>
        [Description("Position Z (um)")]
        PositionZUm = 0x00590025,

        /// <summary>
        ///     Lamp Purposes Usage.
        /// </summary>
        [Description("Lamp Purposes")]
        LampPurposes = 0x00590026,

        /// <summary>
        ///     Update Latency (us) Usage.
        /// </summary>
        [Description("Update Latency (us)")]
        UpdateLatencyUs = 0x00590027,

        /// <summary>
        ///     Red Level Count Usage.
        /// </summary>
        [Description("Red Level Count")]
        RedLevelCount = 0x00590028,

        /// <summary>
        ///     Green Level Count Usage.
        /// </summary>
        [Description("Green Level Count")]
        GreenLevelCount = 0x00590029,

        /// <summary>
        ///     Blue Level Count Usage.
        /// </summary>
        [Description("Blue Level Count")]
        BlueLevelCount = 0x0059002a,

        /// <summary>
        ///     Intensity Level Count Usage.
        /// </summary>
        [Description("Intensity Level Count")]
        IntensityLevelCount = 0x0059002b,

        /// <summary>
        ///     Programmable Usage.
        /// </summary>
        [Description("Programmable")]
        Programmable = 0x0059002c,

        /// <summary>
        ///     Input Binding Usage.
        /// </summary>
        [Description("Input Binding")]
        InputBinding = 0x0059002d,

        /// <summary>
        ///     Lamp Multi Update Report Usage.
        /// </summary>
        [Description("Lamp Multi Update Report")]
        LampMultiUpdateReport = 0x00590050,

        /// <summary>
        ///     Red Update Channel Usage.
        /// </summary>
        [Description("Red Update Channel")]
        RedUpdateChannel = 0x00590051,

        /// <summary>
        ///     Green Update Channel Usage.
        /// </summary>
        [Description("Green Update Channel")]
        GreenUpdateChannel = 0x00590052,

        /// <summary>
        ///     Blue Update Channel Usage.
        /// </summary>
        [Description("Blue Update Channel")]
        BlueUpdateChannel = 0x00590053,

        /// <summary>
        ///     Intensity Update Channel Usage.
        /// </summary>
        [Description("Intensity Update Channel")]
        IntensityUpdateChannel = 0x00590054,

        /// <summary>
        ///     Lamp Update Complete Usage.
        /// </summary>
        [Description("Lamp Update Complete")]
        LampUpdateComplete = 0x00590055,

        /// <summary>
        ///     Lamp Range Update Report Usage.
        /// </summary>
        [Description("Lamp Range Update Report")]
        LampRangeUpdateReport = 0x00590060,

        /// <summary>
        ///     Lamp ID Start Usage.
        /// </summary>
        [Description("Lamp ID Start")]
        LampIDStart = 0x00590061,

        /// <summary>
        ///     Lamp ID End Usage.
        /// </summary>
        [Description("Lamp ID End")]
        LampIDEnd = 0x00590062,

        /// <summary>
        ///     Lamp Array Control Report Usage.
        /// </summary>
        [Description("Lamp Array Control Report")]
        LampArrayControlReport = 0x00590070,

        /// <summary>
        ///     Autonomous Mode Usage.
        /// </summary>
        [Description("Autonomous Mode")]
        AutonomousMode = 0x00590071,

        /// <summary>
        ///     Lamp Array Kind Keyboard Usage.
        /// </summary>
        [Description("Lamp Array Kind Keyboard")]
        LampArrayKindKeyboard = 0x00590101,

        /// <summary>
        ///     Lamp Array Kind Mouse Usage.
        /// </summary>
        [Description("Lamp Array Kind Mouse")]
        LampArrayKindMouse = 0x00590102,

        /// <summary>
        ///     Lamp Array Kind Game Controller Usage.
        /// </summary>
        [Description("Lamp Array Kind Game Controller")]
        LampArrayKindGameController = 0x00590103,

        /// <summary>
        ///     Lamp Array Kind Peripheral Usage.
        /// </summary>
        [Description("Lamp Array Kind Peripheral")]
        LampArrayKindPeripheral = 0x00590104,

        /// <summary>
        ///     Lamp Array Kind Scene Usage.
        /// </summary>
        [Description("Lamp Array Kind Scene")]
        LampArrayKindScene = 0x00590105,

        /// <summary>
        ///     Lamp Array Kind Notification Usage.
        /// </summary>
        [Description("Lamp Array Kind Notification")]
        LampArrayKindNotification = 0x00590106,

        /// <summary>
        ///     Lamp Array Kind Chassis Usage.
        /// </summary>
        [Description("Lamp Array Kind Chassis")]
        LampArrayKindChassis = 0x00590107,

        /// <summary>
        ///     Lamp Array Kind Wearable Usage.
        /// </summary>
        [Description("Lamp Array Kind Wearable")]
        LampArrayKindWearable = 0x00590108,

        /// <summary>
        ///     Lamp Array Kind Furniture Usage.
        /// </summary>
        [Description("Lamp Array Kind Furniture")]
        LampArrayKindFurniture = 0x00590109,

        /// <summary>
        ///     Lamp Array Kind Art Usage.
        /// </summary>
        [Description("Lamp Array Kind Art")]
        LampArrayKindArt = 0x0059010a,

        /// <summary>
        ///     Lamp Purpose Control Usage.
        /// </summary>
        [Description("Lamp Purpose Control")]
        LampPurposeControl = 0x00590201,

        /// <summary>
        ///     Lamp Purpose Accent Usage.
        /// </summary>
        [Description("Lamp Purpose Accent")]
        LampPurposeAccent = 0x00590202,

        /// <summary>
        ///     Lamp Purpose Branding Usage.
        /// </summary>
        [Description("Lamp Purpose Branding")]
        LampPurposeBranding = 0x00590203,

        /// <summary>
        ///     Lamp Purpose Status Usage.
        /// </summary>
        [Description("Lamp Purpose Status")]
        LampPurposeStatus = 0x00590204,

        /// <summary>
        ///     Lamp Purpose Illumination Usage.
        /// </summary>
        [Description("Lamp Purpose Illumination")]
        LampPurposeIllumination = 0x00590205,

        /// <summary>
        ///     Lamp Purpose Presentation Usage.
        /// </summary>
        [Description("Lamp Purpose Presentation")]
        LampPurposePresentation = 0x00590206
    }

    /// <summary>
    ///     Monitor Usage Page.
    /// </summary>
    [Description("Monitor Usage Page")]
    public enum MonitorPage : uint
    {
        /// <summary>
        ///     Undefined Usage.
        /// </summary>
        [Description("Undefined")]
        Undefined = 0x00800000,

        /// <summary>
        ///     Monitor Control Usage.
        /// </summary>
        [Description("Monitor Control")]
        MonitorControl = 0x00800001
    }

    /// <summary>
    ///     Monitor Enumerated Values Usage Page.
    /// </summary>
    [Description("Monitor Enumerated Values Usage Page")]
    public enum MonitorEnumeratedValuesPage : uint
    {
        /*
         * Range: 0x0000 -> 0xffff
         * ENUM_{id}
         */

        /// <summary>
        ///     ENUM_0 Usage.
        /// </summary>
        [Description("ENUM_0")]
        ENUM_0 = 0x00810000,

        /// <summary>
        ///     ENUM_1 Usage.
        /// </summary>
        [Description("ENUM_1")]
        ENUM_1 = 0x00810001,

        /// <summary>
        ///     ENUM_2 Usage.
        /// </summary>
        [Description("ENUM_2")]
        ENUM_2 = 0x00810002,

        /// <summary>
        ///     ENUM_3 Usage.
        /// </summary>
        [Description("ENUM_3")]
        ENUM_3 = 0x00810003,

        /// <summary>
        ///     ENUM_4 Usage.
        /// </summary>
        [Description("ENUM_4")]
        ENUM_4 = 0x00810004,

        /// <summary>
        ///     ENUM_5 Usage.
        /// </summary>
        [Description("ENUM_5")]
        ENUM_5 = 0x00810005,

        /// <summary>
        ///     ENUM_6 Usage.
        /// </summary>
        [Description("ENUM_6")]
        ENUM_6 = 0x00810006,

        /// <summary>
        ///     ENUM_7 Usage.
        /// </summary>
        [Description("ENUM_7")]
        ENUM_7 = 0x00810007,

        /// <summary>
        ///     ENUM_8 Usage.
        /// </summary>
        [Description("ENUM_8")]
        ENUM_8 = 0x00810008,

        /// <summary>
        ///     ENUM_9 Usage.
        /// </summary>
        [Description("ENUM_9")]
        ENUM_9 = 0x00810009,

        /// <summary>
        ///     ENUM_10 Usage.
        /// </summary>
        [Description("ENUM_10")]
        ENUM_10 = 0x0081000a,

        /// <summary>
        ///     ENUM_11 Usage.
        /// </summary>
        [Description("ENUM_11")]
        ENUM_11 = 0x0081000b,

        /// <summary>
        ///     ENUM_12 Usage.
        /// </summary>
        [Description("ENUM_12")]
        ENUM_12 = 0x0081000c,

        /// <summary>
        ///     ENUM_13 Usage.
        /// </summary>
        [Description("ENUM_13")]
        ENUM_13 = 0x0081000d,

        /// <summary>
        ///     ENUM_14 Usage.
        /// </summary>
        [Description("ENUM_14")]
        ENUM_14 = 0x0081000e,

        /// <summary>
        ///     ENUM_15 Usage.
        /// </summary>
        [Description("ENUM_15")]
        ENUM_15 = 0x0081000f
    }

    /// <summary>
    ///     VESA Virtual Controls Usage Page.
    /// </summary>
    [Description("VESA Virtual Controls Usage Page")]
    public enum VESAVirtualPage : uint
    {
        /// <summary>
        ///     Undefined Usage.
        /// </summary>
        [Description("Undefined")]
        Undefined = 0x00820000,

        /// <summary>
        ///      Usage.
        /// </summary>
        [Description("")]
        VESAVirtual_ = 0x00820001,

        /// <summary>
        ///      Usage.
        /// </summary>
        [Description("")]
        VESAVirtual_2 = 0x00820010,

        /// <summary>
        ///      Usage.
        /// </summary>
        [Description("")]
        VESAVirtual_3 = 0x00820012,

        /// <summary>
        ///      Usage.
        /// </summary>
        [Description("")]
        VESAVirtual_4 = 0x00820016,

        /// <summary>
        ///      Usage.
        /// </summary>
        [Description("")]
        VESAVirtual_5 = 0x00820018,

        /// <summary>
        ///      Usage.
        /// </summary>
        [Description("")]
        VESAVirtual_6 = 0x0082001a,

        /// <summary>
        ///      Usage.
        /// </summary>
        [Description("")]
        VESAVirtual_7 = 0x0082001c,

        /// <summary>
        ///      Usage.
        /// </summary>
        [Description("")]
        VESAVirtual_8 = 0x00820020,

        /// <summary>
        ///      Usage.
        /// </summary>
        [Description("")]
        VESAVirtual_9 = 0x00820022,

        /// <summary>
        ///      Usage.
        /// </summary>
        [Description("")]
        VESAVirtual_10 = 0x00820024,

        /// <summary>
        ///      Usage.
        /// </summary>
        [Description("")]
        VESAVirtual_11 = 0x00820026,

        /// <summary>
        ///      Usage.
        /// </summary>
        [Description("")]
        VESAVirtual_12 = 0x00820028,

        /// <summary>
        ///      Usage.
        /// </summary>
        [Description("")]
        VESAVirtual_13 = 0x0082002a,

        /// <summary>
        ///      Usage.
        /// </summary>
        [Description("")]
        VESAVirtual_14 = 0x0082002c,

        /// <summary>
        ///      Usage.
        /// </summary>
        [Description("")]
        VESAVirtual_15 = 0x00820030,

        /// <summary>
        ///      Usage.
        /// </summary>
        [Description("")]
        VESAVirtual_16 = 0x00820032,

        /// <summary>
        ///      Usage.
        /// </summary>
        [Description("")]
        VESAVirtual_17 = 0x00820034,

        /// <summary>
        ///      Usage.
        /// </summary>
        [Description("")]
        VESAVirtual_18 = 0x00820036,

        /// <summary>
        ///      Usage.
        /// </summary>
        [Description("")]
        VESAVirtual_19 = 0x00820038,

        /// <summary>
        ///      Usage.
        /// </summary>
        [Description("")]
        VESAVirtual_20 = 0x0082003a,

        /// <summary>
        ///      Usage.
        /// </summary>
        [Description("")]
        VESAVirtual_21 = 0x0082003c,

        /// <summary>
        ///      Usage.
        /// </summary>
        [Description("")]
        VESAVirtual_22 = 0x00820040,

        /// <summary>
        ///      Usage.
        /// </summary>
        [Description("")]
        VESAVirtual_23 = 0x00820042,

        /// <summary>
        ///      Usage.
        /// </summary>
        [Description("")]
        VESAVirtual_24 = 0x00820044,

        /// <summary>
        ///      Usage.
        /// </summary>
        [Description("")]
        VESAVirtual_25 = 0x00820046,

        /// <summary>
        ///      Usage.
        /// </summary>
        [Description("")]
        VESAVirtual_26 = 0x00820048,

        /// <summary>
        ///      Usage.
        /// </summary>
        [Description("")]
        VESAVirtual_27 = 0x0082004a,

        /// <summary>
        ///      Usage.
        /// </summary>
        [Description("")]
        VESAVirtual_28 = 0x0082004c,

        /// <summary>
        ///      Usage.
        /// </summary>
        [Description("")]
        VESAVirtual_29 = 0x00820056,

        /// <summary>
        ///      Usage.
        /// </summary>
        [Description("")]
        VESAVirtual_30 = 0x00820058,

        /// <summary>
        ///      Usage.
        /// </summary>
        [Description("")]
        VESAVirtual_31 = 0x0082005e,

        /// <summary>
        ///      Usage.
        /// </summary>
        [Description("")]
        VESAVirtual_32 = 0x00820060,

        /// <summary>
        ///      Usage.
        /// </summary>
        [Description("")]
        VESAVirtual_33 = 0x0082006c,

        /// <summary>
        ///      Usage.
        /// </summary>
        [Description("")]
        VESAVirtual_34 = 0x0082006e,

        /// <summary>
        ///      Usage.
        /// </summary>
        [Description("")]
        VESAVirtual_35 = 0x00820070,

        /// <summary>
        ///      Usage.
        /// </summary>
        [Description("")]
        VESAVirtual_36 = 0x008200a2,

        /// <summary>
        ///      Usage.
        /// </summary>
        [Description("")]
        VESAVirtual_37 = 0x008200a4,

        /// <summary>
        ///      Usage.
        /// </summary>
        [Description("")]
        VESAVirtual_38 = 0x008200a6,

        /// <summary>
        ///      Usage.
        /// </summary>
        [Description("")]
        VESAVirtual_39 = 0x008200a8,

        /// <summary>
        ///      Usage.
        /// </summary>
        [Description("")]
        VESAVirtual_40 = 0x008200aa,

        /// <summary>
        ///      Usage.
        /// </summary>
        [Description("")]
        VESAVirtual_41 = 0x008200ac,

        /// <summary>
        ///      Usage.
        /// </summary>
        [Description("")]
        VESAVirtual_42 = 0x008200ae,

        /// <summary>
        ///      Usage.
        /// </summary>
        [Description("")]
        VESAVirtual_43 = 0x008200b0,

        /// <summary>
        ///      Usage.
        /// </summary>
        [Description("")]
        VESAVirtual_44 = 0x008200ca,

        /// <summary>
        ///      Usage.
        /// </summary>
        [Description("")]
        VESAVirtual_45 = 0x008200d4
    }

    /// <summary>
    ///     Monitor Reserved Usage Page.
    /// </summary>
    [Description("Monitor Reserved Usage Page")]
    public enum MonitorReservedPage : uint
    {
        /// <summary>
        ///     Undefined Usage.
        /// </summary>
        [Description("Undefined")]
        Undefined = 0x00830000
    }

    /// <summary>
    ///     Power Device Usage Page.
    /// </summary>
    [Description("Power Device Usage Page")]
    public enum PowerDevicePage : uint
    {
        /// <summary>
        ///     Undefined Usage.
        /// </summary>
        [Description("Undefined")]
        Undefined = 0x00840000,

        /// <summary>
        ///     iName Usage.
        /// </summary>
        [Description("iName")]
        IName = 0x00840001,

        /// <summary>
        ///     Present Status Usage.
        /// </summary>
        [Description("Present Status")]
        PresentStatus = 0x00840002,

        /// <summary>
        ///     Changed Status Usage.
        /// </summary>
        [Description("Changed Status")]
        ChangedStatus = 0x00840003,

        /// <summary>
        ///     UPS Usage.
        /// </summary>
        [Description("UPS")]
        UPS = 0x00840004,

        /// <summary>
        ///     Power Supply Usage.
        /// </summary>
        [Description("Power Supply")]
        PowerSupply = 0x00840005,

        /// <summary>
        ///     Peripheral Device Usage.
        /// </summary>
        [Description("Peripheral Device")]
        PeripheralDevice = 0x00840006,

        /// <summary>
        ///     Battery System Usage.
        /// </summary>
        [Description("Battery System")]
        BatterySystem = 0x00840010,

        /// <summary>
        ///     Battery System ID Usage.
        /// </summary>
        [Description("Battery System ID")]
        BatterySystemID = 0x00840011,

        /// <summary>
        ///     Battery Usage.
        /// </summary>
        [Description("Battery")]
        Battery = 0x00840012,

        /// <summary>
        ///     Battery ID Usage.
        /// </summary>
        [Description("Battery ID")]
        BatteryID = 0x00840013,

        /// <summary>
        ///     Charger Usage.
        /// </summary>
        [Description("Charger")]
        Charger = 0x00840014,

        /// <summary>
        ///     Charger ID Usage.
        /// </summary>
        [Description("Charger ID")]
        ChargerID = 0x00840015,

        /// <summary>
        ///     Power Converter Usage.
        /// </summary>
        [Description("Power Converter")]
        PowerConverter = 0x00840016,

        /// <summary>
        ///     Power Converter ID Usage.
        /// </summary>
        [Description("Power Converter ID")]
        PowerConverterID = 0x00840017,

        /// <summary>
        ///     Outlet System Usage.
        /// </summary>
        [Description("Outlet System")]
        OutletSystem = 0x00840018,

        /// <summary>
        ///     Outlet System ID Usage.
        /// </summary>
        [Description("Outlet System ID")]
        OutletSystemID = 0x00840019,

        /// <summary>
        ///     Input Usage.
        /// </summary>
        [Description("Input")]
        Input = 0x0084001a,

        /// <summary>
        ///     Input ID Usage.
        /// </summary>
        [Description("Input ID")]
        InputID = 0x0084001b,

        /// <summary>
        ///     Output Usage.
        /// </summary>
        [Description("Output")]
        Output = 0x0084001c,

        /// <summary>
        ///     Output ID Usage.
        /// </summary>
        [Description("Output ID")]
        OutputID = 0x0084001d,

        /// <summary>
        ///     Flow Usage.
        /// </summary>
        [Description("Flow")]
        Flow = 0x0084001e,

        /// <summary>
        ///     Flow ID Usage.
        /// </summary>
        [Description("Flow ID")]
        FlowID = 0x0084001f,

        /// <summary>
        ///     Outlet Usage.
        /// </summary>
        [Description("Outlet")]
        Outlet = 0x00840020,

        /// <summary>
        ///     Outlet ID Usage.
        /// </summary>
        [Description("Outlet ID")]
        OutletID = 0x00840021,

        /// <summary>
        ///     Gang Usage.
        /// </summary>
        [Description("Gang")]
        Gang = 0x00840022,

        /// <summary>
        ///     Power Summary Usage.
        /// </summary>
        [Description("Power Summary")]
        PowerSummary = 0x00840022,

        /// <summary>
        ///     Gang ID Usage.
        /// </summary>
        [Description("Gang ID")]
        GangID = 0x00840023,

        /// <summary>
        ///     Power Summary ID Usage.
        /// </summary>
        [Description("Power Summary ID")]
        PowerSummaryID = 0x00840023,

        /// <summary>
        ///     Voltage Usage.
        /// </summary>
        [Description("Voltage")]
        Voltage = 0x00840030,

        /// <summary>
        ///     Current Usage.
        /// </summary>
        [Description("Current")]
        Current = 0x00840031,

        /// <summary>
        ///     Frequency Usage.
        /// </summary>
        [Description("Frequency")]
        Frequency = 0x00840032,

        /// <summary>
        ///     Apparent Power Usage.
        /// </summary>
        [Description("Apparent Power")]
        ApparentPower = 0x00840033,

        /// <summary>
        ///     Active Power Usage.
        /// </summary>
        [Description("Active Power")]
        ActivePower = 0x00840034,

        /// <summary>
        ///     Load (percent) Usage.
        /// </summary>
        [Description("Load (percent)")]
        LoadPercent = 0x00840035,

        /// <summary>
        ///     Temperature Usage.
        /// </summary>
        [Description("Temperature")]
        Temperature = 0x00840036,

        /// <summary>
        ///     Humidity Usage.
        /// </summary>
        [Description("Humidity")]
        Humidity = 0x00840037,

        /// <summary>
        ///     Bad Count Usage.
        /// </summary>
        [Description("Bad Count")]
        BadCount = 0x00840038,

        /// <summary>
        ///     Nominal Voltage Usage.
        /// </summary>
        [Description("Nominal Voltage")]
        NominalVoltage = 0x00840040,

        /// <summary>
        ///     Nominal Current Usage.
        /// </summary>
        [Description("Nominal Current")]
        NominalCurrent = 0x00840041,

        /// <summary>
        ///     Nominal Frequency Usage.
        /// </summary>
        [Description("Nominal Frequency")]
        NominalFrequency = 0x00840042,

        /// <summary>
        ///     Nominal Apparent Power Usage.
        /// </summary>
        [Description("Nominal Apparent Power")]
        NominalApparentPower = 0x00840043,

        /// <summary>
        ///     Nominal Active Power Usage.
        /// </summary>
        [Description("Nominal Active Power")]
        NominalActivePower = 0x00840044,

        /// <summary>
        ///     Nominal Load (percent) Usage.
        /// </summary>
        [Description("Nominal Load (percent)")]
        NominalLoadPercent = 0x00840045,

        /// <summary>
        ///     Nominal Temperature Usage.
        /// </summary>
        [Description("Nominal Temperature")]
        NominalTemperature = 0x00840046,

        /// <summary>
        ///     Nominal Humidity Usage.
        /// </summary>
        [Description("Nominal Humidity")]
        NominalHumidity = 0x00840047,

        /// <summary>
        ///     Switch On Control Usage.
        /// </summary>
        [Description("Switch On Control")]
        SwitchOnControl = 0x00840050,

        /// <summary>
        ///     Switch Off Control Usage.
        /// </summary>
        [Description("Switch Off Control")]
        SwitchOffControl = 0x00840051,

        /// <summary>
        ///     Toggle Control Usage.
        /// </summary>
        [Description("Toggle Control")]
        ToggleControl = 0x00840052,

        /// <summary>
        ///     Low Voltage Transfer Usage.
        /// </summary>
        [Description("Low Voltage Transfer")]
        LowVoltageTransfer = 0x00840053,

        /// <summary>
        ///     High Voltage Transfer Usage.
        /// </summary>
        [Description("High Voltage Transfer")]
        HighVoltageTransfer = 0x00840054,

        /// <summary>
        ///     Delay Before Reboot Usage.
        /// </summary>
        [Description("Delay Before Reboot")]
        DelayBeforeReboot = 0x00840055,

        /// <summary>
        ///     Delay Before Startup Usage.
        /// </summary>
        [Description("Delay Before Startup")]
        DelayBeforeStartup = 0x00840056,

        /// <summary>
        ///     Delay Before Shutdown Usage.
        /// </summary>
        [Description("Delay Before Shutdown")]
        DelayBeforeShutdown = 0x00840057,

        /// <summary>
        ///     Test Usage.
        /// </summary>
        [Description("Test")]
        Test = 0x00840058,

        /// <summary>
        ///     Module Reset Usage.
        /// </summary>
        [Description("Module Reset")]
        ModuleReset = 0x00840059,

        /// <summary>
        ///     Audible Alarm Control Usage.
        /// </summary>
        [Description("Audible Alarm Control")]
        AudibleAlarmControl = 0x0084005a,

        /// <summary>
        ///     Present Usage.
        /// </summary>
        [Description("Present")]
        Present = 0x00840060,

        /// <summary>
        ///     Good Usage.
        /// </summary>
        [Description("Good")]
        Good = 0x00840061,

        /// <summary>
        ///     Internal Failure Usage.
        /// </summary>
        [Description("Internal Failure")]
        InternalFailure = 0x00840062,

        /// <summary>
        ///     Voltage Out Of Range Usage.
        /// </summary>
        [Description("Voltage Out Of Range")]
        VoltageOutOfRange = 0x00840063,

        /// <summary>
        ///     Frequency Out Of Range Usage.
        /// </summary>
        [Description("Frequency Out Of Range")]
        FrequencyOutOfRange = 0x00840064,

        /// <summary>
        ///     Overload Usage.
        /// </summary>
        [Description("Overload")]
        Overload = 0x00840065,

        /// <summary>
        ///     Overcharged Usage.
        /// </summary>
        [Description("Overcharged")]
        Overcharged = 0x00840066,

        /// <summary>
        ///     Over Temperature Usage.
        /// </summary>
        [Description("Over Temperature")]
        OverTemperature = 0x00840067,

        /// <summary>
        ///     Shutdown Requested Usage.
        /// </summary>
        [Description("Shutdown Requested")]
        ShutdownRequested = 0x00840068,

        /// <summary>
        ///     Shutdown Imminent Usage.
        /// </summary>
        [Description("Shutdown Imminent")]
        ShutdownImminent = 0x00840069,

        /// <summary>
        ///     Switch On/Off Usage.
        /// </summary>
        [Description("Switch On/Off")]
        SwitchOnOff = 0x0084006b,

        /// <summary>
        ///     Switchable Usage.
        /// </summary>
        [Description("Switchable")]
        Switchable = 0x0084006c,

        /// <summary>
        ///     Used Usage.
        /// </summary>
        [Description("Used")]
        Used = 0x0084006d,

        /// <summary>
        ///     Boost Usage.
        /// </summary>
        [Description("Boost")]
        Boost = 0x0084006e,

        /// <summary>
        ///     Buck Usage.
        /// </summary>
        [Description("Buck")]
        Buck = 0x0084006f,

        /// <summary>
        ///     Initialized Usage.
        /// </summary>
        [Description("Initialized")]
        Initialized = 0x00840070,

        /// <summary>
        ///     Tested Usage.
        /// </summary>
        [Description("Tested")]
        Tested = 0x00840071,

        /// <summary>
        ///     Awaiting Power Usage.
        /// </summary>
        [Description("Awaiting Power")]
        AwaitingPower = 0x00840072,

        /// <summary>
        ///     Communication Lost Usage.
        /// </summary>
        [Description("Communication Lost")]
        CommunicationLost = 0x00840073,

        /// <summary>
        ///     iManufacturer Usage.
        /// </summary>
        [Description("iManufacturer")]
        IManufacturer = 0x008400fd,

        /// <summary>
        ///     iProduct Usage.
        /// </summary>
        [Description("iProduct")]
        IProduct = 0x008400fe,

        /// <summary>
        ///     iSerialNumber Usage.
        /// </summary>
        [Description("iSerialNumber")]
        ISerialNumber = 0x008400ff
    }

    /// <summary>
    ///     Battery System Usage Page.
    /// </summary>
    [Description("Battery System Usage Page")]
    public enum BatterySystemPage : uint
    {
        /// <summary>
        ///     Undefined Usage.
        /// </summary>
        [Description("Undefined")]
        Undefined = 0x00850000,

        /// <summary>
        ///     SMB Battery Mode Usage.
        /// </summary>
        [Description("SMB Battery Mode")]
        SMBBatteryMode = 0x00850001,

        /// <summary>
        ///     SMB Battery Status Usage.
        /// </summary>
        [Description("SMB Battery Status")]
        SMBBatteryStatus = 0x00850002,

        /// <summary>
        ///     SMB Alarm Warning Usage.
        /// </summary>
        [Description("SMB Alarm Warning")]
        SMBAlarmWarning = 0x00850003,

        /// <summary>
        ///     SMB Charger Mode Usage.
        /// </summary>
        [Description("SMB Charger Mode")]
        SMBChargerMode = 0x00850004,

        /// <summary>
        ///     SMB Charger Status Usage.
        /// </summary>
        [Description("SMB Charger Status")]
        SMBChargerStatus = 0x00850005,

        /// <summary>
        ///     SMB Charger Spec Info Usage.
        /// </summary>
        [Description("SMB Charger Spec Info")]
        SMBChargerSpecInfo = 0x00850006,

        /// <summary>
        ///     SMB Selector State Usage.
        /// </summary>
        [Description("SMB Selector State")]
        SMBSelectorState = 0x00850007,

        /// <summary>
        ///     SMB Selector Presets Usage.
        /// </summary>
        [Description("SMB Selector Presets")]
        SMBSelectorPresets = 0x00850008,

        /// <summary>
        ///     SMB Selector Info Usage.
        /// </summary>
        [Description("SMB Selector Info")]
        SMBSelectorInfo = 0x00850009,

        /*
         * Range: 0x0010 -> 0x0014
         * Optional Mfg Function {n+1}
         */

        /// <summary>
        ///     Optional Mfg Function 1 Usage.
        /// </summary>
        [Description("Optional Mfg Function 1")]
        OptionalMfgFunction1 = 0x00850010,

        /// <summary>
        ///     Optional Mfg Function 2 Usage.
        /// </summary>
        [Description("Optional Mfg Function 2")]
        OptionalMfgFunction2 = 0x00850011,

        /// <summary>
        ///     Optional Mfg Function 3 Usage.
        /// </summary>
        [Description("Optional Mfg Function 3")]
        OptionalMfgFunction3 = 0x00850012,

        /// <summary>
        ///     Optional Mfg Function 4 Usage.
        /// </summary>
        [Description("Optional Mfg Function 4")]
        OptionalMfgFunction4 = 0x00850013,

        /// <summary>
        ///     Optional Mfg Function 5 Usage.
        /// </summary>
        [Description("Optional Mfg Function 5")]
        OptionalMfgFunction5 = 0x00850014,

        /// <summary>
        ///     Connection To SMBus Usage.
        /// </summary>
        [Description("Connection To SMBus")]
        ConnectionToSMBus = 0x00850015,

        /// <summary>
        ///     Output Connection Usage.
        /// </summary>
        [Description("Output Connection")]
        OutputConnection = 0x00850016,

        /// <summary>
        ///     Charger Connection Usage.
        /// </summary>
        [Description("Charger Connection")]
        ChargerConnection = 0x00850017,

        /// <summary>
        ///     Battery Insertion Usage.
        /// </summary>
        [Description("Battery Insertion")]
        BatteryInsertion = 0x00850018,

        /// <summary>
        ///     Use Next Usage.
        /// </summary>
        [Description("Use Next")]
        UseNext = 0x00850019,

        /// <summary>
        ///     OK To Use Usage.
        /// </summary>
        [Description("OK To Use")]
        OKToUse = 0x0085001a,

        /// <summary>
        ///     Battery Supported Usage.
        /// </summary>
        [Description("Battery Supported")]
        BatterySupported = 0x0085001b,

        /// <summary>
        ///     Selector Revision Usage.
        /// </summary>
        [Description("Selector Revision")]
        SelectorRevision = 0x0085001c,

        /// <summary>
        ///     Charging Indicator Usage.
        /// </summary>
        [Description("Charging Indicator")]
        ChargingIndicator = 0x0085001d,

        /// <summary>
        ///     Manufacturer Access Usage.
        /// </summary>
        [Description("Manufacturer Access")]
        ManufacturerAccess = 0x00850028,

        /// <summary>
        ///     Remaining Capacity Limit Usage.
        /// </summary>
        [Description("Remaining Capacity Limit")]
        RemainingCapacityLimit = 0x00850029,

        /// <summary>
        ///     Remaining Time Limit Usage.
        /// </summary>
        [Description("Remaining Time Limit")]
        RemainingTimeLimit = 0x0085002a,

        /// <summary>
        ///     At Rate Usage.
        /// </summary>
        [Description("At Rate")]
        AtRate = 0x0085002b,

        /// <summary>
        ///     Capacity Mode Usage.
        /// </summary>
        [Description("Capacity Mode")]
        CapacityMode = 0x0085002c,

        /// <summary>
        ///     Broadcast To Charger Usage.
        /// </summary>
        [Description("Broadcast To Charger")]
        BroadcastToCharger = 0x0085002d,

        /// <summary>
        ///     Primary Battery Usage.
        /// </summary>
        [Description("Primary Battery")]
        PrimaryBattery = 0x0085002e,

        /// <summary>
        ///     Charge Controller Usage.
        /// </summary>
        [Description("Charge Controller")]
        ChargeController = 0x0085002f,

        /// <summary>
        ///     Terminate Charge Usage.
        /// </summary>
        [Description("Terminate Charge")]
        TerminateCharge = 0x00850040,

        /// <summary>
        ///     Terminate Discharge Usage.
        /// </summary>
        [Description("Terminate Discharge")]
        TerminateDischarge = 0x00850041,

        /// <summary>
        ///     Below Remaining Capacity Limit Usage.
        /// </summary>
        [Description("Below Remaining Capacity Limit")]
        BelowRemainingCapacityLimit = 0x00850042,

        /// <summary>
        ///     Remaining Time Limit Expired Usage.
        /// </summary>
        [Description("Remaining Time Limit Expired")]
        RemainingTimeLimitExpired = 0x00850043,

        /// <summary>
        ///     Charging Usage.
        /// </summary>
        [Description("Charging")]
        Charging = 0x00850044,

        /// <summary>
        ///     Discharging Usage.
        /// </summary>
        [Description("Discharging")]
        Discharging = 0x00850045,

        /// <summary>
        ///     Fully Charged Usage.
        /// </summary>
        [Description("Fully Charged")]
        FullyCharged = 0x00850046,

        /// <summary>
        ///     Fully Discharged Usage.
        /// </summary>
        [Description("Fully Discharged")]
        FullyDischarged = 0x00850047,

        /// <summary>
        ///     Conditioning Flag Usage.
        /// </summary>
        [Description("Conditioning Flag")]
        ConditioningFlag = 0x00850048,

        /// <summary>
        ///     At Rate OK Usage.
        /// </summary>
        [Description("At Rate OK")]
        AtRateOK = 0x00850049,

        /// <summary>
        ///     SMB Error Code Usage.
        /// </summary>
        [Description("SMB Error Code")]
        SMBErrorCode = 0x0085004a,

        /// <summary>
        ///     Need Replacement Usage.
        /// </summary>
        [Description("Need Replacement")]
        NeedReplacement = 0x0085004b,

        /// <summary>
        ///     At Rate Time To Full Usage.
        /// </summary>
        [Description("At Rate Time To Full")]
        AtRateTimeToFull = 0x00850060,

        /// <summary>
        ///     At Rate Time To Empty Usage.
        /// </summary>
        [Description("At Rate Time To Empty")]
        AtRateTimeToEmpty = 0x00850061,

        /// <summary>
        ///     Average Current Usage.
        /// </summary>
        [Description("Average Current")]
        AverageCurrent = 0x00850062,

        /// <summary>
        ///     Max Error Usage.
        /// </summary>
        [Description("Max Error")]
        MaxError = 0x00850063,

        /// <summary>
        ///     Relative State Of Charge Usage.
        /// </summary>
        [Description("Relative State Of Charge")]
        RelativeStateOfCharge = 0x00850064,

        /// <summary>
        ///     Absolute State Of Charge Usage.
        /// </summary>
        [Description("Absolute State Of Charge")]
        AbsoluteStateOfCharge = 0x00850065,

        /// <summary>
        ///     Remaining Capacity Usage.
        /// </summary>
        [Description("Remaining Capacity")]
        RemainingCapacity = 0x00850066,

        /// <summary>
        ///     Full Charge Capacity Usage.
        /// </summary>
        [Description("Full Charge Capacity")]
        FullChargeCapacity = 0x00850067,

        /// <summary>
        ///     Run Time To Empty Usage.
        /// </summary>
        [Description("Run Time To Empty")]
        RunTimeToEmpty = 0x00850068,

        /// <summary>
        ///     Average Time To Empty Usage.
        /// </summary>
        [Description("Average Time To Empty")]
        AverageTimeToEmpty = 0x00850069,

        /// <summary>
        ///     Average Time To Full Usage.
        /// </summary>
        [Description("Average Time To Full")]
        AverageTimeToFull = 0x0085006a,

        /// <summary>
        ///     Cycle Count Usage.
        /// </summary>
        [Description("Cycle Count")]
        CycleCount = 0x0085006b,

        /// <summary>
        ///     Battery Pack Model Level Usage.
        /// </summary>
        [Description("Battery Pack Model Level")]
        BatteryPackModelLevel = 0x00850080,

        /// <summary>
        ///     Internal Charge Controller Usage.
        /// </summary>
        [Description("Internal Charge Controller")]
        InternalChargeController = 0x00850081,

        /// <summary>
        ///     Primary Battery Support Usage.
        /// </summary>
        [Description("Primary Battery Support")]
        PrimaryBatterySupport = 0x00850082,

        /// <summary>
        ///     Design Capacity Usage.
        /// </summary>
        [Description("Design Capacity")]
        DesignCapacity = 0x00850083,

        /// <summary>
        ///     Specification Info Usage.
        /// </summary>
        [Description("Specification Info")]
        SpecificationInfo = 0x00850084,

        /// <summary>
        ///     Manufacturer Date Usage.
        /// </summary>
        [Description("Manufacturer Date")]
        ManufacturerDate = 0x00850085,

        /// <summary>
        ///     Serial Number Usage.
        /// </summary>
        [Description("Serial Number")]
        SerialNumber = 0x00850086,

        /// <summary>
        ///     iManufacturer Usage.
        /// </summary>
        [Description("iManufacturer")]
        IManufacturer = 0x00850087,

        /// <summary>
        ///     iDeviceName Usage.
        /// </summary>
        [Description("iDeviceName")]
        IDeviceName = 0x00850088,

        /// <summary>
        ///     iDeviceChemistry Usage.
        /// </summary>
        [Description("iDeviceChemistry")]
        IDeviceChemistry = 0x00850089,

        /// <summary>
        ///     Manufacturer Data Usage.
        /// </summary>
        [Description("Manufacturer Data")]
        ManufacturerData = 0x0085008a,

        /// <summary>
        ///     Rechargeable Usage.
        /// </summary>
        [Description("Rechargeable")]
        Rechargeable = 0x0085008b,

        /// <summary>
        ///     Warning Capacity Limit Usage.
        /// </summary>
        [Description("Warning Capacity Limit")]
        WarningCapacityLimit = 0x0085008c,

        /// <summary>
        ///     Capacity Granularity 1 Usage.
        /// </summary>
        [Description("Capacity Granularity 1")]
        CapacityGranularity1 = 0x0085008d,

        /// <summary>
        ///     Capacity Granularity 2 Usage.
        /// </summary>
        [Description("Capacity Granularity 2")]
        CapacityGranularity2 = 0x0085008e,

        /// <summary>
        ///     iOEMInformation Usage.
        /// </summary>
        [Description("iOEMInformation")]
        IOEMInformation = 0x0085008f,

        /// <summary>
        ///     Inhibit Charge Usage.
        /// </summary>
        [Description("Inhibit Charge")]
        InhibitCharge = 0x008500c0,

        /// <summary>
        ///     Enable Polling Usage.
        /// </summary>
        [Description("Enable Polling")]
        EnablePolling = 0x008500c1,

        /// <summary>
        ///     Reset To Zero Usage.
        /// </summary>
        [Description("Reset To Zero")]
        ResetToZero = 0x008500c2,

        /// <summary>
        ///     AC Present Usage.
        /// </summary>
        [Description("AC Present")]
        ACPresent = 0x008500d0,

        /// <summary>
        ///     Battery Present Usage.
        /// </summary>
        [Description("Battery Present")]
        BatteryPresent = 0x008500d1,

        /// <summary>
        ///     Power Fail Usage.
        /// </summary>
        [Description("Power Fail")]
        PowerFail = 0x008500d2,

        /// <summary>
        ///     Alarm Inhibited Usage.
        /// </summary>
        [Description("Alarm Inhibited")]
        AlarmInhibited = 0x008500d3,

        /// <summary>
        ///     Thermistor Under Range Usage.
        /// </summary>
        [Description("Thermistor Under Range")]
        ThermistorUnderRange = 0x008500d4,

        /// <summary>
        ///     Thermistor Hot Usage.
        /// </summary>
        [Description("Thermistor Hot")]
        ThermistorHot = 0x008500d5,

        /// <summary>
        ///     Thermistor Cold Usage.
        /// </summary>
        [Description("Thermistor Cold")]
        ThermistorCold = 0x008500d6,

        /// <summary>
        ///     Thermistor Over Range Usage.
        /// </summary>
        [Description("Thermistor Over Range")]
        ThermistorOverRange = 0x008500d7,

        /// <summary>
        ///     Voltage Out Of Range Usage.
        /// </summary>
        [Description("Voltage Out Of Range")]
        VoltageOutOfRange = 0x008500d8,

        /// <summary>
        ///     Current Out Of Range Usage.
        /// </summary>
        [Description("Current Out Of Range")]
        CurrentOutOfRange = 0x008500d9,

        /// <summary>
        ///     Current Not Regulated Usage.
        /// </summary>
        [Description("Current Not Regulated")]
        CurrentNotRegulated = 0x008500da,

        /// <summary>
        ///     Voltage Not Regulated Usage.
        /// </summary>
        [Description("Voltage Not Regulated")]
        VoltageNotRegulated = 0x008500db,

        /// <summary>
        ///     Master Mode Usage.
        /// </summary>
        [Description("Master Mode")]
        MasterMode = 0x008500dc,

        /// <summary>
        ///     Charger Selector Support Usage.
        /// </summary>
        [Description("Charger Selector Support")]
        ChargerSelectorSupport = 0x008500f0,

        /// <summary>
        ///     Charger Spec Usage.
        /// </summary>
        [Description("Charger Spec")]
        ChargerSpec = 0x008500f1,

        /// <summary>
        ///     Level 2 Usage.
        /// </summary>
        [Description("Level 2")]
        Level2 = 0x008500f2,

        /// <summary>
        ///     Level 3 Usage.
        /// </summary>
        [Description("Level 3")]
        Level3 = 0x008500f3
    }

    /// <summary>
    ///     Bar Code Scanner Usage Page.
    /// </summary>
    [Description("Bar Code Scanner Usage Page")]
    public enum BarCodeScannerPage : uint
    {
        /// <summary>
        ///     Undefined Usage.
        /// </summary>
        [Description("Undefined")]
        Undefined = 0x008c0000,

        /// <summary>
        ///     Bar Code Badge Reader Usage.
        /// </summary>
        [Description("Bar Code Badge Reader")]
        BarCodeBadgeReader = 0x008c0001,

        /// <summary>
        ///     Bar Code Scanner Usage.
        /// </summary>
        [Description("Bar Code Scanner")]
        BarCodeScanner = 0x008c0002,

        /// <summary>
        ///     Dumb Bar Code Scanner Usage.
        /// </summary>
        [Description("Dumb Bar Code Scanner")]
        DumbBarCodeScanner = 0x008c0003,

        /// <summary>
        ///     Cordless Scanner Base Usage.
        /// </summary>
        [Description("Cordless Scanner Base")]
        CordlessScannerBase = 0x008c0004,

        /// <summary>
        ///     Bar Code Scanner Cradle Usage.
        /// </summary>
        [Description("Bar Code Scanner Cradle")]
        BarCodeScannerCradle = 0x008c0005,

        /// <summary>
        ///     Attribute Report Usage.
        /// </summary>
        [Description("Attribute Report")]
        AttributeReport = 0x008c0010,

        /// <summary>
        ///     Settings Report Usage.
        /// </summary>
        [Description("Settings Report")]
        SettingsReport = 0x008c0011,

        /// <summary>
        ///     Scanned Data Report Usage.
        /// </summary>
        [Description("Scanned Data Report")]
        ScannedDataReport = 0x008c0012,

        /// <summary>
        ///     Raw Scanned Data Report Usage.
        /// </summary>
        [Description("Raw Scanned Data Report")]
        RawScannedDataReport = 0x008c0013,

        /// <summary>
        ///     Trigger Report Usage.
        /// </summary>
        [Description("Trigger Report")]
        TriggerReport = 0x008c0014,

        /// <summary>
        ///     Status Report Usage.
        /// </summary>
        [Description("Status Report")]
        StatusReport = 0x008c0015,

        /// <summary>
        ///     UPC/EAN Control Report Usage.
        /// </summary>
        [Description("UPC/EAN Control Report")]
        UPCEANControlReport = 0x008c0016,

        /// <summary>
        ///     EAN 2/3 Label Control Report Usage.
        /// </summary>
        [Description("EAN 2/3 Label Control Report")]
        EAN23LabelControlReport = 0x008c0017,

        /// <summary>
        ///     Code 39 Control Report Usage.
        /// </summary>
        [Description("Code 39 Control Report")]
        Code39ControlReport = 0x008c0018,

        /// <summary>
        ///     Interleaved 2 of 5 Control Report Usage.
        /// </summary>
        [Description("Interleaved 2 of 5 Control Report")]
        Interleaved2Of5ControlReport = 0x008c0019,

        /// <summary>
        ///     Standard 2 of 5 Control Report Usage.
        /// </summary>
        [Description("Standard 2 of 5 Control Report")]
        Standard2Of5ControlReport = 0x008c001a,

        /// <summary>
        ///     MSI Plessey Control Report Usage.
        /// </summary>
        [Description("MSI Plessey Control Report")]
        MSIPlesseyControlReport = 0x008c001b,

        /// <summary>
        ///     Codabar Control Report Usage.
        /// </summary>
        [Description("Codabar Control Report")]
        CodabarControlReport = 0x008c001c,

        /// <summary>
        ///     Code 128 Control Report Usage.
        /// </summary>
        [Description("Code 128 Control Report")]
        Code128ControlReport = 0x008c001d,

        /// <summary>
        ///     Misc 1D Control Report Usage.
        /// </summary>
        [Description("Misc 1D Control Report")]
        Misc1DControlReport = 0x008c001e,

        /// <summary>
        ///     2D Control Report Usage.
        /// </summary>
        [Description("2D Control Report")]
        DControlReport = 0x008c001f,

        /// <summary>
        ///     Aiming/Pointer Mode Usage.
        /// </summary>
        [Description("Aiming/Pointer Mode")]
        AimingPointerMode = 0x008c0030,

        /// <summary>
        ///     Bar Code Present Sensor Usage.
        /// </summary>
        [Description("Bar Code Present Sensor")]
        BarCodePresentSensor = 0x008c0031,

        /// <summary>
        ///     Class 1A Laser Usage.
        /// </summary>
        [Description("Class 1A Laser")]
        Class1ALaser = 0x008c0032,

        /// <summary>
        ///     Class 2 Laser Usage.
        /// </summary>
        [Description("Class 2 Laser")]
        Class2Laser = 0x008c0033,

        /// <summary>
        ///     Heater Present Usage.
        /// </summary>
        [Description("Heater Present")]
        HeaterPresent = 0x008c0034,

        /// <summary>
        ///     Contact Scanner Usage.
        /// </summary>
        [Description("Contact Scanner")]
        ContactScanner = 0x008c0035,

        /// <summary>
        ///     Electronic Article Surveillance Notification Usage.
        /// </summary>
        [Description("Electronic Article Surveillance Notification")]
        ElectronicArticleSurveillanceNotification = 0x008c0036,

        /// <summary>
        ///     Constant Electronic Article Surveillance Usage.
        /// </summary>
        [Description("Constant Electronic Article Surveillance")]
        ConstantElectronicArticleSurveillance = 0x008c0037,

        /// <summary>
        ///     Error Indication Usage.
        /// </summary>
        [Description("Error Indication")]
        ErrorIndication = 0x008c0038,

        /// <summary>
        ///     Fixed Beeper Usage.
        /// </summary>
        [Description("Fixed Beeper")]
        FixedBeeper = 0x008c0039,

        /// <summary>
        ///     Good Decode Indication Usage.
        /// </summary>
        [Description("Good Decode Indication")]
        GoodDecodeIndication = 0x008c003a,

        /// <summary>
        ///     Hands Free Scanning Usage.
        /// </summary>
        [Description("Hands Free Scanning")]
        HandsFreeScanning = 0x008c003b,

        /// <summary>
        ///     Intrinsically Safe Usage.
        /// </summary>
        [Description("Intrinsically Safe")]
        IntrinsicallySafe = 0x008c003c,

        /// <summary>
        ///     Class 1 Laser Usage.
        /// </summary>
        [Description("Class 1 Laser")]
        Class1Laser = 0x008c003d,

        /// <summary>
        ///     Long Range Scanner Usage.
        /// </summary>
        [Description("Long Range Scanner")]
        LongRangeScanner = 0x008c003e,

        /// <summary>
        ///     Mirror Speed Control Usage.
        /// </summary>
        [Description("Mirror Speed Control")]
        MirrorSpeedControl = 0x008c003f,

        /// <summary>
        ///     Not On File Indication Usage.
        /// </summary>
        [Description("Not On File Indication")]
        NotOnFileIndication = 0x008c0040,

        /// <summary>
        ///     Programmable Beeper Usage.
        /// </summary>
        [Description("Programmable Beeper")]
        ProgrammableBeeper = 0x008c0041,

        /// <summary>
        ///     Triggerless Usage.
        /// </summary>
        [Description("Triggerless")]
        Triggerless = 0x008c0042,

        /// <summary>
        ///     Wand Usage.
        /// </summary>
        [Description("Wand")]
        Wand = 0x008c0043,

        /// <summary>
        ///     Water Resistant Usage.
        /// </summary>
        [Description("Water Resistant")]
        WaterResistant = 0x008c0044,

        /// <summary>
        ///     Multi-Range Scanner Usage.
        /// </summary>
        [Description("Multi-Range Scanner")]
        MultiRangeScanner = 0x008c0045,

        /// <summary>
        ///     Proximity Sensor Usage.
        /// </summary>
        [Description("Proximity Sensor")]
        ProximitySensor = 0x008c0046,

        /// <summary>
        ///     Fragment Decoding Usage.
        /// </summary>
        [Description("Fragment Decoding")]
        FragmentDecoding = 0x008c004d,

        /// <summary>
        ///     Scanner Read Confidence Usage.
        /// </summary>
        [Description("Scanner Read Confidence")]
        ScannerReadConfidence = 0x008c004e,

        /// <summary>
        ///     Data Prefix Usage.
        /// </summary>
        [Description("Data Prefix")]
        DataPrefix = 0x008c004f,

        /// <summary>
        ///     Prefix AIMI Usage.
        /// </summary>
        [Description("Prefix AIMI")]
        PrefixAIMI = 0x008c0050,

        /// <summary>
        ///     Prefix None Usage.
        /// </summary>
        [Description("Prefix None")]
        PrefixNone = 0x008c0051,

        /// <summary>
        ///     Prefix Proprietary Usage.
        /// </summary>
        [Description("Prefix Proprietary")]
        PrefixProprietary = 0x008c0052,

        /// <summary>
        ///     Active Time Usage.
        /// </summary>
        [Description("Active Time")]
        ActiveTime = 0x008c0055,

        /// <summary>
        ///     Aiming Laser Pattern Usage.
        /// </summary>
        [Description("Aiming Laser Pattern")]
        AimingLaserPattern = 0x008c0056,

        /// <summary>
        ///     Bar Code Present Usage.
        /// </summary>
        [Description("Bar Code Present")]
        BarCodePresent = 0x008c0057,

        /// <summary>
        ///     Beeper State Usage.
        /// </summary>
        [Description("Beeper State")]
        BeeperState = 0x008c0058,

        /// <summary>
        ///     Laser On Time Usage.
        /// </summary>
        [Description("Laser On Time")]
        LaserOnTime = 0x008c0059,

        /// <summary>
        ///     Laser State Usage.
        /// </summary>
        [Description("Laser State")]
        LaserState = 0x008c005a,

        /// <summary>
        ///     Lockout Time Usage.
        /// </summary>
        [Description("Lockout Time")]
        LockoutTime = 0x008c005b,

        /// <summary>
        ///     Motor State Usage.
        /// </summary>
        [Description("Motor State")]
        MotorState = 0x008c005c,

        /// <summary>
        ///     Motor Timeout Usage.
        /// </summary>
        [Description("Motor Timeout")]
        MotorTimeout = 0x008c005d,

        /// <summary>
        ///     Power On Reset Scanner Usage.
        /// </summary>
        [Description("Power On Reset Scanner")]
        PowerOnResetScanner = 0x008c005e,

        /// <summary>
        ///     Prevent Read of Barcodes Usage.
        /// </summary>
        [Description("Prevent Read of Barcodes")]
        PreventReadOfBarcodes = 0x008c005f,

        /// <summary>
        ///     Initiate Barcode Read Usage.
        /// </summary>
        [Description("Initiate Barcode Read")]
        InitiateBarcodeRead = 0x008c0060,

        /// <summary>
        ///     Trigger State Usage.
        /// </summary>
        [Description("Trigger State")]
        TriggerState = 0x008c0061,

        /// <summary>
        ///     Trigger Mode Usage.
        /// </summary>
        [Description("Trigger Mode")]
        TriggerMode = 0x008c0062,

        /// <summary>
        ///     Trigger Mode Blinking Laser On Usage.
        /// </summary>
        [Description("Trigger Mode Blinking Laser On")]
        TriggerModeBlinkingLaserOn = 0x008c0063,

        /// <summary>
        ///     Trigger Mode Continuous Laser On Usage.
        /// </summary>
        [Description("Trigger Mode Continuous Laser On")]
        TriggerModeContinuousLaserOn = 0x008c0064,

        /// <summary>
        ///     Trigger Mode Laser on while Pulled Usage.
        /// </summary>
        [Description("Trigger Mode Laser on while Pulled")]
        TriggerModeLaserOnWhilePulled = 0x008c0065,

        /// <summary>
        ///     Trigger Mode Laser stays on after Trigger release Usage.
        /// </summary>
        [Description("Trigger Mode Laser stays on after Trigger release")]
        TriggerModeLaserStaysOnAfterTriggerRelease = 0x008c0066,

        /// <summary>
        ///     Commit Parameters to NVM Usage.
        /// </summary>
        [Description("Commit Parameters to NVM")]
        CommitParametersToNVM = 0x008c006d,

        /// <summary>
        ///     Parameter Scanning Usage.
        /// </summary>
        [Description("Parameter Scanning")]
        ParameterScanning = 0x008c006e,

        /// <summary>
        ///     Parameters Changed Usage.
        /// </summary>
        [Description("Parameters Changed")]
        ParametersChanged = 0x008c006f,

        /// <summary>
        ///     Set parameter default values Usage.
        /// </summary>
        [Description("Set parameter default values")]
        SetParameterDefaultValues = 0x008c0070,

        /// <summary>
        ///     Scanner In Cradle Usage.
        /// </summary>
        [Description("Scanner In Cradle")]
        ScannerInCradle = 0x008c0075,

        /// <summary>
        ///     Scanner In Range Usage.
        /// </summary>
        [Description("Scanner In Range")]
        ScannerInRange = 0x008c0076,

        /// <summary>
        ///     Aim Duration Usage.
        /// </summary>
        [Description("Aim Duration")]
        AimDuration = 0x008c007a,

        /// <summary>
        ///     Good Read Lamp Duration Usage.
        /// </summary>
        [Description("Good Read Lamp Duration")]
        GoodReadLampDuration = 0x008c007b,

        /// <summary>
        ///     Good Read Lamp Intensity Usage.
        /// </summary>
        [Description("Good Read Lamp Intensity")]
        GoodReadLampIntensity = 0x008c007c,

        /// <summary>
        ///     Good Read LED Usage.
        /// </summary>
        [Description("Good Read LED")]
        GoodReadLED = 0x008c007d,

        /// <summary>
        ///     Good Read Tone Frequency Usage.
        /// </summary>
        [Description("Good Read Tone Frequency")]
        GoodReadToneFrequency = 0x008c007e,

        /// <summary>
        ///     Good Read Tone Length Usage.
        /// </summary>
        [Description("Good Read Tone Length")]
        GoodReadToneLength = 0x008c007f,

        /// <summary>
        ///     Good Read Tone Volume Usage.
        /// </summary>
        [Description("Good Read Tone Volume")]
        GoodReadToneVolume = 0x008c0080,

        /// <summary>
        ///     No Read Message Usage.
        /// </summary>
        [Description("No Read Message")]
        NoReadMessage = 0x008c0082,

        /// <summary>
        ///     Not on File Volume Usage.
        /// </summary>
        [Description("Not on File Volume")]
        NotOnFileVolume = 0x008c0083,

        /// <summary>
        ///     Powerup Beep Usage.
        /// </summary>
        [Description("Powerup Beep")]
        PowerupBeep = 0x008c0084,

        /// <summary>
        ///     Sound Error Beep Usage.
        /// </summary>
        [Description("Sound Error Beep")]
        SoundErrorBeep = 0x008c0085,

        /// <summary>
        ///     Sound Good Read Beep Usage.
        /// </summary>
        [Description("Sound Good Read Beep")]
        SoundGoodReadBeep = 0x008c0086,

        /// <summary>
        ///     Sound Not On File Beep Usage.
        /// </summary>
        [Description("Sound Not On File Beep")]
        SoundNotOnFileBeep = 0x008c0087,

        /// <summary>
        ///     Good Read When to Write Usage.
        /// </summary>
        [Description("Good Read When to Write")]
        GoodReadWhenToWrite = 0x008c0088,

        /// <summary>
        ///     GRWTI After Decode Usage.
        /// </summary>
        [Description("GRWTI After Decode")]
        GRWTIAfterDecode = 0x008c0089,

        /// <summary>
        ///     GRWTI Beep/Lamp after transmit Usage.
        /// </summary>
        [Description("GRWTI Beep/Lamp after transmit")]
        GRWTIBeepLampAfterTransmit = 0x008c008a,

        /// <summary>
        ///     GRWTI No Beep/Lamp use at all Usage.
        /// </summary>
        [Description("GRWTI No Beep/Lamp use at all")]
        GRWTINoBeepLampUseAtAll = 0x008c008b,

        /// <summary>
        ///     Bookland EAN Usage.
        /// </summary>
        [Description("Bookland EAN")]
        BooklandEAN = 0x008c0091,

        /// <summary>
        ///     Convert EAN 8 to 13 Type Usage.
        /// </summary>
        [Description("Convert EAN 8 to 13 Type")]
        ConvertEAN8To13Type = 0x008c0092,

        /// <summary>
        ///     Convert UPC A to EAN-13 Usage.
        /// </summary>
        [Description("Convert UPC A to EAN-13")]
        ConvertUPCAToEAN13 = 0x008c0093,

        /// <summary>
        ///     Convert UPC-E to A Usage.
        /// </summary>
        [Description("Convert UPC-E to A")]
        ConvertUPCEToA = 0x008c0094,

        /// <summary>
        ///     EAN-13 Usage.
        /// </summary>
        [Description("EAN-13")]
        EAN13 = 0x008c0095,

        /// <summary>
        ///     EAN-8 Usage.
        /// </summary>
        [Description("EAN-8")]
        EAN8 = 0x008c0096,

        /// <summary>
        ///     EAN-99 128_Mandatory Usage.
        /// </summary>
        [Description("EAN-99 128_Mandatory")]
        EAN99128_Mandatory = 0x008c0097,

        /// <summary>
        ///     EAN-99 P5/128_Optional Usage.
        /// </summary>
        [Description("EAN-99 P5/128_Optional")]
        EAN99P5128_Optional = 0x008c0098,

        /// <summary>
        ///     UPC/EAN Usage.
        /// </summary>
        [Description("UPC/EAN")]
        UPCEAN = 0x008c009a,

        /// <summary>
        ///     UPC/EAN Coupon Code Usage.
        /// </summary>
        [Description("UPC/EAN Coupon Code")]
        UPCEANCouponCode = 0x008c009b,

        /// <summary>
        ///     UPC/EAN Periodicals Usage.
        /// </summary>
        [Description("UPC/EAN Periodicals")]
        UPCEANPeriodicals = 0x008c009c,

        /// <summary>
        ///     UPC-A Usage.
        /// </summary>
        [Description("UPC-A")]
        UPCA = 0x008c009d,

        /// <summary>
        ///     UPC-A with 128 Mandatory Usage.
        /// </summary>
        [Description("UPC-A with 128 Mandatory")]
        UPCAWith128Mandatory = 0x008c009e,

        /// <summary>
        ///     UPC-A with 128 Optional Usage.
        /// </summary>
        [Description("UPC-A with 128 Optional")]
        UPCAWith128Optional = 0x008c009f,

        /// <summary>
        ///     UPC-A with P5 Optional Usage.
        /// </summary>
        [Description("UPC-A with P5 Optional")]
        UPCAWithP5Optional = 0x008c00a0,

        /// <summary>
        ///     UPC-E Usage.
        /// </summary>
        [Description("UPC-E")]
        UPCE = 0x008c00a1,

        /// <summary>
        ///     UPC-E1 Usage.
        /// </summary>
        [Description("UPC-E1")]
        UPCE1 = 0x008c00a2,

        /// <summary>
        ///     Periodical Usage.
        /// </summary>
        [Description("Periodical")]
        Periodical = 0x008c00a9,

        /// <summary>
        ///     Periodical Auto-Discriminate + 2 Usage.
        /// </summary>
        [Description("Periodical Auto-Discriminate + 2")]
        PeriodicalAutoDiscriminate2 = 0x008c00aa,

        /// <summary>
        ///     Periodical Only Decode with + 2 Usage.
        /// </summary>
        [Description("Periodical Only Decode with + 2")]
        PeriodicalOnlyDecodeWith2 = 0x008c00ab,

        /// <summary>
        ///     Periodical Ignore + 2 Usage.
        /// </summary>
        [Description("Periodical Ignore + 2")]
        PeriodicalIgnore2 = 0x008c00ac,

        /// <summary>
        ///     Periodical Auto-Discriminate + 5 Usage.
        /// </summary>
        [Description("Periodical Auto-Discriminate + 5")]
        PeriodicalAutoDiscriminate5 = 0x008c00ad,

        /// <summary>
        ///     Periodical Only Decode with + 5 Usage.
        /// </summary>
        [Description("Periodical Only Decode with + 5")]
        PeriodicalOnlyDecodeWith5 = 0x008c00ae,

        /// <summary>
        ///     Periodical Ignore + 5 Usage.
        /// </summary>
        [Description("Periodical Ignore + 5")]
        PeriodicalIgnore5 = 0x008c00af,

        /// <summary>
        ///     Check Usage.
        /// </summary>
        [Description("Check")]
        Check = 0x008c00b0,

        /// <summary>
        ///     Check Disable Price Usage.
        /// </summary>
        [Description("Check Disable Price")]
        CheckDisablePrice = 0x008c00b1,

        /// <summary>
        ///     Check Enable 4 digit Price Usage.
        /// </summary>
        [Description("Check Enable 4 digit Price")]
        CheckEnable4DigitPrice = 0x008c00b2,

        /// <summary>
        ///     Check Enable 5 digit Price Usage.
        /// </summary>
        [Description("Check Enable 5 digit Price")]
        CheckEnable5DigitPrice = 0x008c00b3,

        /// <summary>
        ///     Check Enable European 4 digit Price Usage.
        /// </summary>
        [Description("Check Enable European 4 digit Price")]
        CheckEnableEuropean4DigitPrice = 0x008c00b4,

        /// <summary>
        ///     Check Enable European 5 digit Price Usage.
        /// </summary>
        [Description("Check Enable European 5 digit Price")]
        CheckEnableEuropean5DigitPrice = 0x008c00b5,

        /// <summary>
        ///     EAN Two Label Usage.
        /// </summary>
        [Description("EAN Two Label")]
        EANTwoLabel = 0x008c00b7,

        /// <summary>
        ///     EAN Three Label Usage.
        /// </summary>
        [Description("EAN Three Label")]
        EANThreeLabel = 0x008c00b8,

        /// <summary>
        ///     EAN 8 Flag Digit 1 Usage.
        /// </summary>
        [Description("EAN 8 Flag Digit 1")]
        EAN8FlagDigit1 = 0x008c00b9,

        /// <summary>
        ///     EAN 8 Flag Digit 2 Usage.
        /// </summary>
        [Description("EAN 8 Flag Digit 2")]
        EAN8FlagDigit2 = 0x008c00ba,

        /// <summary>
        ///     EAN 8 Flag Digit 3 Usage.
        /// </summary>
        [Description("EAN 8 Flag Digit 3")]
        EAN8FlagDigit3 = 0x008c00bb,

        /// <summary>
        ///     EAN 13 Flag Digit 1 Usage.
        /// </summary>
        [Description("EAN 13 Flag Digit 1")]
        EAN13FlagDigit1 = 0x008c00bc,

        /// <summary>
        ///     EAN 13 Flag Digit 2 Usage.
        /// </summary>
        [Description("EAN 13 Flag Digit 2")]
        EAN13FlagDigit2 = 0x008c00bd,

        /// <summary>
        ///     EAN 13 Flag Digit 3 Usage.
        /// </summary>
        [Description("EAN 13 Flag Digit 3")]
        EAN13FlagDigit3 = 0x008c00be,

        /// <summary>
        ///     Add EAN 2/3 Label Definition Usage.
        /// </summary>
        [Description("Add EAN 2/3 Label Definition")]
        AddEAN23LabelDefinition = 0x008c00bf,

        /// <summary>
        ///     Clear all EAN 2/3 Label Definitions Usage.
        /// </summary>
        [Description("Clear all EAN 2/3 Label Definitions")]
        ClearAllEAN23LabelDefinitions = 0x008c00c0,

        /// <summary>
        ///     Codabar Usage.
        /// </summary>
        [Description("Codabar")]
        Codabar = 0x008c00c3,

        /// <summary>
        ///     Code 128 Usage.
        /// </summary>
        [Description("Code 128")]
        Code128 = 0x008c00c4,

        /// <summary>
        ///     Code 39 Usage.
        /// </summary>
        [Description("Code 39")]
        Code39 = 0x008c00c7,

        /// <summary>
        ///     Code 93 Usage.
        /// </summary>
        [Description("Code 93")]
        Code93 = 0x008c00c8,

        /// <summary>
        ///     Full ASCII Conversion Usage.
        /// </summary>
        [Description("Full ASCII Conversion")]
        FullASCIIConversion = 0x008c00c9,

        /// <summary>
        ///     Interleaved 2 of 5 Usage.
        /// </summary>
        [Description("Interleaved 2 of 5")]
        Interleaved2Of5 = 0x008c00ca,

        /// <summary>
        ///     Italian Pharmacy Code Usage.
        /// </summary>
        [Description("Italian Pharmacy Code")]
        ItalianPharmacyCode = 0x008c00cb,

        /// <summary>
        ///     MSI/Plessey Usage.
        /// </summary>
        [Description("MSI/Plessey")]
        MSIPlessey = 0x008c00cc,

        /// <summary>
        ///     Standard 2 of 5 IATA Usage.
        /// </summary>
        [Description("Standard 2 of 5 IATA")]
        Standard2Of5IATA = 0x008c00cd,

        /// <summary>
        ///     Standard 2 of 5 Usage.
        /// </summary>
        [Description("Standard 2 of 5")]
        Standard2Of5 = 0x008c00ce,

        /// <summary>
        ///     Transmit Start/Stop Usage.
        /// </summary>
        [Description("Transmit Start/Stop")]
        TransmitStartStop = 0x008c00d3,

        /// <summary>
        ///     Tri-Optic Usage.
        /// </summary>
        [Description("Tri-Optic")]
        TriOptic = 0x008c00d4,

        /// <summary>
        ///     UCC/EAN-128 Usage.
        /// </summary>
        [Description("UCC/EAN-128")]
        UCCEAN128 = 0x008c00d5,

        /// <summary>
        ///     Check Digit Usage.
        /// </summary>
        [Description("Check Digit")]
        CheckDigit = 0x008c00d6,

        /// <summary>
        ///     Check Digit Disable Usage.
        /// </summary>
        [Description("Check Digit Disable")]
        CheckDigitDisable = 0x008c00d7,

        /// <summary>
        ///     Check Digit Enable Interleaved 2 of 5 OPCC Usage.
        /// </summary>
        [Description("Check Digit Enable Interleaved 2 of 5 OPCC")]
        CheckDigitEnableInterleaved2Of5OPCC = 0x008c00d8,

        /// <summary>
        ///     Check Digit Enable Interleaved 2 of 5 USS Usage.
        /// </summary>
        [Description("Check Digit Enable Interleaved 2 of 5 USS")]
        CheckDigitEnableInterleaved2Of5USS = 0x008c00d9,

        /// <summary>
        ///     Check Digit Enable Standard 2 of 5 OPCC Usage.
        /// </summary>
        [Description("Check Digit Enable Standard 2 of 5 OPCC")]
        CheckDigitEnableStandard2Of5OPCC = 0x008c00da,

        /// <summary>
        ///     Check Digit Enable Standard 2 of 5 USS Usage.
        /// </summary>
        [Description("Check Digit Enable Standard 2 of 5 USS")]
        CheckDigitEnableStandard2Of5USS = 0x008c00db,

        /// <summary>
        ///     Check Digit Enable One MSI Plessey Usage.
        /// </summary>
        [Description("Check Digit Enable One MSI Plessey")]
        CheckDigitEnableOneMSIPlessey = 0x008c00dc,

        /// <summary>
        ///     Check Digit Enable Two MSI Plessey Usage.
        /// </summary>
        [Description("Check Digit Enable Two MSI Plessey")]
        CheckDigitEnableTwoMSIPlessey = 0x008c00dd,

        /// <summary>
        ///     Check Digit Codabar Enable Usage.
        /// </summary>
        [Description("Check Digit Codabar Enable")]
        CheckDigitCodabarEnable = 0x008c00de,

        /// <summary>
        ///     Check Digit Code 39 Enable Usage.
        /// </summary>
        [Description("Check Digit Code 39 Enable")]
        CheckDigitCode39Enable = 0x008c00df,

        /// <summary>
        ///     Transmit Check Digit Usage.
        /// </summary>
        [Description("Transmit Check Digit")]
        TransmitCheckDigit = 0x008c00f0,

        /// <summary>
        ///     Disable Check Digit Transmit Usage.
        /// </summary>
        [Description("Disable Check Digit Transmit")]
        DisableCheckDigitTransmit = 0x008c00f1,

        /// <summary>
        ///     Enable Check Digit Transmit Usage.
        /// </summary>
        [Description("Enable Check Digit Transmit")]
        EnableCheckDigitTransmit = 0x008c00f2,

        /// <summary>
        ///     Symbology Identifier Usage.
        /// </summary>
        [Description("Symbology Identifier")]
        SymbologyIdentifier = 0x008c00fb,

        /// <summary>
        ///     Symbology Identifier Usage.
        /// </summary>
        [Description("Symbology Identifier")]
        SymbologyIdentifier2 = 0x008c00fc,

        /// <summary>
        ///     Symbology Identifier Usage.
        /// </summary>
        [Description("Symbology Identifier")]
        SymbologyIdentifier3 = 0x008c00fd,

        /// <summary>
        ///     Decoded Data Usage.
        /// </summary>
        [Description("Decoded Data")]
        DecodedData = 0x008c00fe,

        /// <summary>
        ///     Decode Data Continued Usage.
        /// </summary>
        [Description("Decode Data Continued")]
        DecodeDataContinued = 0x008c00ff,

        /// <summary>
        ///     Bar Space Data Usage.
        /// </summary>
        [Description("Bar Space Data")]
        BarSpaceData = 0x008c0100,

        /// <summary>
        ///     Scanner Data Accuracy Usage.
        /// </summary>
        [Description("Scanner Data Accuracy")]
        ScannerDataAccuracy = 0x008c0101,

        /// <summary>
        ///     Raw Data Polarity Usage.
        /// </summary>
        [Description("Raw Data Polarity")]
        RawDataPolarity = 0x008c0102,

        /// <summary>
        ///     Polarity Inverted Bar Code Usage.
        /// </summary>
        [Description("Polarity Inverted Bar Code")]
        PolarityInvertedBarCode = 0x008c0103,

        /// <summary>
        ///     Polarity Normal Bar Code Usage.
        /// </summary>
        [Description("Polarity Normal Bar Code")]
        PolarityNormalBarCode = 0x008c0104,

        /// <summary>
        ///     Minimum Length to Decode Usage.
        /// </summary>
        [Description("Minimum Length to Decode")]
        MinimumLengthToDecode = 0x008c0106,

        /// <summary>
        ///     Maximum Length to Decode Usage.
        /// </summary>
        [Description("Maximum Length to Decode")]
        MaximumLengthToDecode = 0x008c0107,

        /// <summary>
        ///     First Discrete Length to Decode Usage.
        /// </summary>
        [Description("First Discrete Length to Decode")]
        FirstDiscreteLengthToDecode = 0x008c0108,

        /// <summary>
        ///     Second Discrete Length to Decode Usage.
        /// </summary>
        [Description("Second Discrete Length to Decode")]
        SecondDiscreteLengthToDecode = 0x008c0109,

        /// <summary>
        ///     Data Length Method Usage.
        /// </summary>
        [Description("Data Length Method")]
        DataLengthMethod = 0x008c010a,

        /// <summary>
        ///     DL Method Read any Usage.
        /// </summary>
        [Description("DL Method Read any")]
        DLMethodReadAny = 0x008c010b,

        /// <summary>
        ///     DL Method Check in Range Usage.
        /// </summary>
        [Description("DL Method Check in Range")]
        DLMethodCheckInRange = 0x008c010c,

        /// <summary>
        ///     DL Method Check for Discrete Usage.
        /// </summary>
        [Description("DL Method Check for Discrete")]
        DLMethodCheckForDiscrete = 0x008c010d,

        /// <summary>
        ///     Aztec Code Usage.
        /// </summary>
        [Description("Aztec Code")]
        AztecCode = 0x008c0110,

        /// <summary>
        ///     BC412 Usage.
        /// </summary>
        [Description("BC412")]
        BC412 = 0x008c0111,

        /// <summary>
        ///     Channel Code Usage.
        /// </summary>
        [Description("Channel Code")]
        ChannelCode = 0x008c0112,

        /// <summary>
        ///     Code 16 Usage.
        /// </summary>
        [Description("Code 16")]
        Code16 = 0x008c0113,

        /// <summary>
        ///     Code 32 Usage.
        /// </summary>
        [Description("Code 32")]
        Code32 = 0x008c0114,

        /// <summary>
        ///     Code 49 Usage.
        /// </summary>
        [Description("Code 49")]
        Code49 = 0x008c0115,

        /// <summary>
        ///     Code One Usage.
        /// </summary>
        [Description("Code One")]
        CodeOne = 0x008c0116,

        /// <summary>
        ///     Colorcode Usage.
        /// </summary>
        [Description("Colorcode")]
        Colorcode = 0x008c0117,

        /// <summary>
        ///     Data Matrix Usage.
        /// </summary>
        [Description("Data Matrix")]
        DataMatrix = 0x008c0118,

        /// <summary>
        ///     MaxiCode Usage.
        /// </summary>
        [Description("MaxiCode")]
        MaxiCode = 0x008c0119,

        /// <summary>
        ///     MicroPDF Usage.
        /// </summary>
        [Description("MicroPDF")]
        MicroPDF = 0x008c011a,

        /// <summary>
        ///     PDF-417 Usage.
        /// </summary>
        [Description("PDF-417")]
        PDF417 = 0x008c011b,

        /// <summary>
        ///     PosiCode Usage.
        /// </summary>
        [Description("PosiCode")]
        PosiCode = 0x008c011c,

        /// <summary>
        ///     QR Code Usage.
        /// </summary>
        [Description("QR Code")]
        QRCode = 0x008c011d,

        /// <summary>
        ///     SuperCode Usage.
        /// </summary>
        [Description("SuperCode")]
        SuperCode = 0x008c011e,

        /// <summary>
        ///     UltraCode Usage.
        /// </summary>
        [Description("UltraCode")]
        UltraCode = 0x008c011f,

        /// <summary>
        ///     USD-5 (Slug Code) Usage.
        /// </summary>
        [Description("USD-5 (Slug Code)")]
        USD5SlugCode = 0x008c0120,

        /// <summary>
        ///     VeriCode Usage.
        /// </summary>
        [Description("VeriCode")]
        VeriCode = 0x008c0121
    }

    /// <summary>
    ///     Weighing Devices Usage Page.
    /// </summary>
    [Description("Weighing Devices Usage Page")]
    public enum WeighingDevicesPage : uint
    {
        /// <summary>
        ///     Undefined Usage.
        /// </summary>
        [Description("Undefined")]
        Undefined = 0x008d0000,

        /// <summary>
        ///     Weighing Device Usage.
        /// </summary>
        [Description("Weighing Device")]
        WeighingDevice = 0x008d0001,

        /// <summary>
        ///     Scale Device Usage.
        /// </summary>
        [Description("Scale Device")]
        ScaleDevice = 0x008d0020,

        /// <summary>
        ///     Scale Class I Metric Usage.
        /// </summary>
        [Description("Scale Class I Metric")]
        ScaleClassIMetric = 0x008d0021,

        /// <summary>
        ///     Scale Class I Metric Usage.
        /// </summary>
        [Description("Scale Class I Metric")]
        ScaleClassIMetric2 = 0x008d0022,

        /// <summary>
        ///     Scale Class II Metric Usage.
        /// </summary>
        [Description("Scale Class II Metric")]
        ScaleClassIIMetric = 0x008d0023,

        /// <summary>
        ///     Scale Class III Metric Usage.
        /// </summary>
        [Description("Scale Class III Metric")]
        ScaleClassIIIMetric = 0x008d0024,

        /// <summary>
        ///     Scale Class IIIL Metric Usage.
        /// </summary>
        [Description("Scale Class IIIL Metric")]
        ScaleClassIIILMetric = 0x008d0025,

        /// <summary>
        ///     Scale Class IV Metric Usage.
        /// </summary>
        [Description("Scale Class IV Metric")]
        ScaleClassIVMetric = 0x008d0026,

        /// <summary>
        ///     Scale Class III English Usage.
        /// </summary>
        [Description("Scale Class III English")]
        ScaleClassIIIEnglish = 0x008d0027,

        /// <summary>
        ///     Scale Class IIIL English Usage.
        /// </summary>
        [Description("Scale Class IIIL English")]
        ScaleClassIIILEnglish = 0x008d0028,

        /// <summary>
        ///     Scale Class IV English Usage.
        /// </summary>
        [Description("Scale Class IV English")]
        ScaleClassIVEnglish = 0x008d0029,

        /// <summary>
        ///     Scale Class Generic Usage.
        /// </summary>
        [Description("Scale Class Generic")]
        ScaleClassGeneric = 0x008d002a,

        /// <summary>
        ///     Scale Attribute Report Usage.
        /// </summary>
        [Description("Scale Attribute Report")]
        ScaleAttributeReport = 0x008d0030,

        /// <summary>
        ///     Scale Control Report Usage.
        /// </summary>
        [Description("Scale Control Report")]
        ScaleControlReport = 0x008d0031,

        /// <summary>
        ///     Scale Data Report Usage.
        /// </summary>
        [Description("Scale Data Report")]
        ScaleDataReport = 0x008d0032,

        /// <summary>
        ///     Scale Status Report Usage.
        /// </summary>
        [Description("Scale Status Report")]
        ScaleStatusReport = 0x008d0033,

        /// <summary>
        ///     Scale Weight Limit Report Usage.
        /// </summary>
        [Description("Scale Weight Limit Report")]
        ScaleWeightLimitReport = 0x008d0034,

        /// <summary>
        ///     Scale Statistics Report Usage.
        /// </summary>
        [Description("Scale Statistics Report")]
        ScaleStatisticsReport = 0x008d0035,

        /// <summary>
        ///     Data Weight Usage.
        /// </summary>
        [Description("Data Weight")]
        DataWeight = 0x008d0040,

        /// <summary>
        ///     Data Scaling Usage.
        /// </summary>
        [Description("Data Scaling")]
        DataScaling = 0x008d0041,

        /// <summary>
        ///     Weight Unit Usage.
        /// </summary>
        [Description("Weight Unit")]
        WeightUnit = 0x008d0050,

        /// <summary>
        ///     Weight Unit Milligram Usage.
        /// </summary>
        [Description("Weight Unit Milligram")]
        WeightUnitMilligram = 0x008d0051,

        /// <summary>
        ///     Weight Unit Gram Usage.
        /// </summary>
        [Description("Weight Unit Gram")]
        WeightUnitGram = 0x008d0052,

        /// <summary>
        ///     Weight Unit Kilogram Usage.
        /// </summary>
        [Description("Weight Unit Kilogram")]
        WeightUnitKilogram = 0x008d0053,

        /// <summary>
        ///     Weight Unit Carats Usage.
        /// </summary>
        [Description("Weight Unit Carats")]
        WeightUnitCarats = 0x008d0054,

        /// <summary>
        ///     Weight Unit Taels Usage.
        /// </summary>
        [Description("Weight Unit Taels")]
        WeightUnitTaels = 0x008d0055,

        /// <summary>
        ///     Weight Unit Grains Usage.
        /// </summary>
        [Description("Weight Unit Grains")]
        WeightUnitGrains = 0x008d0056,

        /// <summary>
        ///     Weight Unit Pennyweights Usage.
        /// </summary>
        [Description("Weight Unit Pennyweights")]
        WeightUnitPennyweights = 0x008d0057,

        /// <summary>
        ///     Weight Unit Metric Ton Usage.
        /// </summary>
        [Description("Weight Unit Metric Ton")]
        WeightUnitMetricTon = 0x008d0058,

        /// <summary>
        ///     Weight Unit Avoir Ton Usage.
        /// </summary>
        [Description("Weight Unit Avoir Ton")]
        WeightUnitAvoirTon = 0x008d0059,

        /// <summary>
        ///     Weight Unit Troy Ounce Usage.
        /// </summary>
        [Description("Weight Unit Troy Ounce")]
        WeightUnitTroyOunce = 0x008d005a,

        /// <summary>
        ///     Weight Unit Ounce Usage.
        /// </summary>
        [Description("Weight Unit Ounce")]
        WeightUnitOunce = 0x008d005b,

        /// <summary>
        ///     Weight Unit Pound Usage.
        /// </summary>
        [Description("Weight Unit Pound")]
        WeightUnitPound = 0x008d005c,

        /// <summary>
        ///     Calibration Count Usage.
        /// </summary>
        [Description("Calibration Count")]
        CalibrationCount = 0x008d0060,

        /// <summary>
        ///     Re-Zero Count Usage.
        /// </summary>
        [Description("Re-Zero Count")]
        ReZeroCount = 0x008d0061,

        /// <summary>
        ///     Scale Status Usage.
        /// </summary>
        [Description("Scale Status")]
        ScaleStatus = 0x008d0070,

        /// <summary>
        ///     Scale Status Fault Usage.
        /// </summary>
        [Description("Scale Status Fault")]
        ScaleStatusFault = 0x008d0071,

        /// <summary>
        ///     Scale Status Stable at Center of Zero Usage.
        /// </summary>
        [Description("Scale Status Stable at Center of Zero")]
        ScaleStatusStableAtCenterOfZero = 0x008d0072,

        /// <summary>
        ///     Scale Status In Motion Usage.
        /// </summary>
        [Description("Scale Status In Motion")]
        ScaleStatusInMotion = 0x008d0073,

        /// <summary>
        ///     Scale Status Weight Stable Usage.
        /// </summary>
        [Description("Scale Status Weight Stable")]
        ScaleStatusWeightStable = 0x008d0074,

        /// <summary>
        ///     Scale Status Under Zero Usage.
        /// </summary>
        [Description("Scale Status Under Zero")]
        ScaleStatusUnderZero = 0x008d0075,

        /// <summary>
        ///     Scale Status Over Weight Limit Usage.
        /// </summary>
        [Description("Scale Status Over Weight Limit")]
        ScaleStatusOverWeightLimit = 0x008d0076,

        /// <summary>
        ///     Scale Status Requires Calibration Usage.
        /// </summary>
        [Description("Scale Status Requires Calibration")]
        ScaleStatusRequiresCalibration = 0x008d0077,

        /// <summary>
        ///     Scale Status Requires Rezeroing Usage.
        /// </summary>
        [Description("Scale Status Requires Rezeroing")]
        ScaleStatusRequiresRezeroing = 0x008d0078,

        /// <summary>
        ///     Zero Scale Usage.
        /// </summary>
        [Description("Zero Scale")]
        ZeroScale = 0x008d0080,

        /// <summary>
        ///     Enforced Zero Return Usage.
        /// </summary>
        [Description("Enforced Zero Return")]
        EnforcedZeroReturn = 0x008d0081
    }

    /// <summary>
    ///     Magnetic Stripe Reading (MSR) Devices Usage Page.
    /// </summary>
    [Description("Magnetic Stripe Reading (MSR) Devices Usage Page")]
    public enum MagneticStripeReadingMSRDevicesPage : uint
    {
        /// <summary>
        ///     Undefined Usage.
        /// </summary>
        [Description("Undefined")]
        Undefined = 0x008e0000,

        /// <summary>
        ///     MSR Device Read-Only Usage.
        /// </summary>
        [Description("MSR Device Read-Only")]
        MSRDeviceReadOnly = 0x008e0001,

        /*
         * Range: 0x0011 -> 0x0013
         * Track {n+1} Length
         */

        /// <summary>
        ///     Track 1 Length Usage.
        /// </summary>
        [Description("Track 1 Length")]
        Track1Length = 0x008e0011,

        /// <summary>
        ///     Track 2 Length Usage.
        /// </summary>
        [Description("Track 2 Length")]
        Track2Length = 0x008e0012,

        /// <summary>
        ///     Track 3 Length Usage.
        /// </summary>
        [Description("Track 3 Length")]
        Track3Length = 0x008e0013,

        /// <summary>
        ///     Track JIS Length Usage.
        /// </summary>
        [Description("Track JIS Length")]
        TrackJISLength = 0x008e0014,

        /// <summary>
        ///     Track Data Usage.
        /// </summary>
        [Description("Track Data")]
        TrackData = 0x008e0020,

        /*
         * Range: 0x0021 -> 0x0023
         * Track {n+1} Data
         */

        /// <summary>
        ///     Track 1 Data Usage.
        /// </summary>
        [Description("Track 1 Data")]
        Track1Data = 0x008e0021,

        /// <summary>
        ///     Track 2 Data Usage.
        /// </summary>
        [Description("Track 2 Data")]
        Track2Data = 0x008e0022,

        /// <summary>
        ///     Track 3 Data Usage.
        /// </summary>
        [Description("Track 3 Data")]
        Track3Data = 0x008e0023,

        /// <summary>
        ///     Track JIS Data Usage.
        /// </summary>
        [Description("Track JIS Data")]
        TrackJISData = 0x008e0024
    }

    /// <summary>
    ///     Reserved Point of Sale Usage Page.
    /// </summary>
    [Description("Reserved Point of Sale Usage Page")]
    public enum ReservedPointOfSalePage : uint
    {
        /// <summary>
        ///     Undefined Usage.
        /// </summary>
        [Description("Undefined")]
        Undefined = 0x008f0000
    }

    /// <summary>
    ///     Camera Control Usage Page.
    /// </summary>
    [Description("Camera Control Usage Page")]
    public enum CameraControlPage : uint
    {
        /// <summary>
        ///     Undefined Usage.
        /// </summary>
        [Description("Undefined")]
        Undefined = 0x00900000,

        /// <summary>
        ///     Camera Auto-focus Usage.
        /// </summary>
        [Description("Camera Auto-focus")]
        CameraAutofocus = 0x00900020,

        /// <summary>
        ///     Camera Shutter Usage.
        /// </summary>
        [Description("Camera Shutter")]
        CameraShutter = 0x00900021
    }

    /// <summary>
    ///     Arcade Usage Page.
    /// </summary>
    [Description("Arcade Usage Page")]
    public enum ArcadePage : uint
    {
        /// <summary>
        ///     Undefined Usage.
        /// </summary>
        [Description("Undefined")]
        Undefined = 0x00910000,

        /// <summary>
        ///     General Purpose IO Card Usage.
        /// </summary>
        [Description("General Purpose IO Card")]
        GeneralPurposeIOCard = 0x00910001,

        /// <summary>
        ///     Coin Door Usage.
        /// </summary>
        [Description("Coin Door")]
        CoinDoor = 0x00910002,

        /// <summary>
        ///     Watchdog Timer Usage.
        /// </summary>
        [Description("Watchdog Timer")]
        WatchdogTimer = 0x00910003,

        /// <summary>
        ///     General Purpose Analog Input State Usage.
        /// </summary>
        [Description("General Purpose Analog Input State")]
        GeneralPurposeAnalogInputState = 0x00910030,

        /// <summary>
        ///     General Purpose Digital Input State Usage.
        /// </summary>
        [Description("General Purpose Digital Input State")]
        GeneralPurposeDigitalInputState = 0x00910031,

        /// <summary>
        ///     General Purpose Optical Input State Usage.
        /// </summary>
        [Description("General Purpose Optical Input State")]
        GeneralPurposeOpticalInputState = 0x00910032,

        /// <summary>
        ///     General Purpose Digital Output State Usage.
        /// </summary>
        [Description("General Purpose Digital Output State")]
        GeneralPurposeDigitalOutputState = 0x00910033,

        /// <summary>
        ///     Number of Coin Doors Usage.
        /// </summary>
        [Description("Number of Coin Doors")]
        NumberOfCoinDoors = 0x00910034,

        /// <summary>
        ///     Coin Drawer Drop Count Usage.
        /// </summary>
        [Description("Coin Drawer Drop Count")]
        CoinDrawerDropCount = 0x00910035,

        /// <summary>
        ///     Coin Drawer Start Usage.
        /// </summary>
        [Description("Coin Drawer Start")]
        CoinDrawerStart = 0x00910036,

        /// <summary>
        ///     Coin Drawer Service Usage.
        /// </summary>
        [Description("Coin Drawer Service")]
        CoinDrawerService = 0x00910037,

        /// <summary>
        ///     Coin Drawer Tilt Usage.
        /// </summary>
        [Description("Coin Drawer Tilt")]
        CoinDrawerTilt = 0x00910038,

        /// <summary>
        ///     Coin Door Test Usage.
        /// </summary>
        [Description("Coin Door Test")]
        CoinDoorTest = 0x00910039,

        /// <summary>
        ///     Coin Door Lockout Usage.
        /// </summary>
        [Description("Coin Door Lockout")]
        CoinDoorLockout = 0x00910040,

        /// <summary>
        ///     Watchdog Timeout Usage.
        /// </summary>
        [Description("Watchdog Timeout")]
        WatchdogTimeout = 0x00910041,

        /// <summary>
        ///     Watchdog Action Usage.
        /// </summary>
        [Description("Watchdog Action")]
        WatchdogAction = 0x00910042,

        /// <summary>
        ///     Watchdog Reboot Usage.
        /// </summary>
        [Description("Watchdog Reboot")]
        WatchdogReboot = 0x00910043,

        /// <summary>
        ///     Watchdog Restart Usage.
        /// </summary>
        [Description("Watchdog Restart")]
        WatchdogRestart = 0x00910044,

        /// <summary>
        ///     Alarm Input Usage.
        /// </summary>
        [Description("Alarm Input")]
        AlarmInput = 0x00910045,

        /// <summary>
        ///     Coin Door Counter Usage.
        /// </summary>
        [Description("Coin Door Counter")]
        CoinDoorCounter = 0x00910046,

        /// <summary>
        ///     I/O Direction Mapping Usage.
        /// </summary>
        [Description("I/O Direction Mapping")]
        IODirectionMapping = 0x00910047,

        /// <summary>
        ///     Set I/O Direction Usage.
        /// </summary>
        [Description("Set I/O Direction")]
        SetIODirection = 0x00910048,

        /// <summary>
        ///     Extended Optical Input State Usage.
        /// </summary>
        [Description("Extended Optical Input State")]
        ExtendedOpticalInputState = 0x00910049,

        /// <summary>
        ///     Pin Pad Input State Usage.
        /// </summary>
        [Description("Pin Pad Input State")]
        PinPadInputState = 0x0091004a,

        /// <summary>
        ///     Pin Pad Status Usage.
        /// </summary>
        [Description("Pin Pad Status")]
        PinPadStatus = 0x0091004b,

        /// <summary>
        ///     Pin Pad Output Usage.
        /// </summary>
        [Description("Pin Pad Output")]
        PinPadOutput = 0x0091004c,

        /// <summary>
        ///     Pin Pad Command Usage.
        /// </summary>
        [Description("Pin Pad Command")]
        PinPadCommand = 0x0091004d
    }

    /// <summary>
    ///     Fast IDentity Online Alliance Usage Page.
    /// </summary>
    [Description("Fast IDentity Online Alliance Usage Page")]
    public enum FastIDentityOnlineAlliancePage : uint
    {
        /// <summary>
        ///     Undefined Usage.
        /// </summary>
        [Description("Undefined")]
        Undefined = 0xf1d00000,

        /// <summary>
        ///     U2F Authenticator Device Usage.
        /// </summary>
        [Description("U2F Authenticator Device")]
        U2FAuthenticatorDevice = 0xf1d00001,

        /// <summary>
        ///     Input Report Data Usage.
        /// </summary>
        [Description("Input Report Data")]
        InputReportData = 0xf1d00020,

        /// <summary>
        ///     Output Report Data Usage.
        /// </summary>
        [Description("Output Report Data")]
        OutputReportData = 0xf1d00021
    }
}

/*
 * END OF ENUM DEFINITIONS
 */

namespace DevDecoder.HIDDevices
{
    using DevDecoder.HIDDevices.Pages;

    /// <summary>
    ///     Base class for all usage pages.
    /// </summary>
    public partial class UsagePage
    {
        /// <summary>
        ///     Dictionary of all defined usage pages.
        /// </summary>
        private static ConcurrentDictionary<ushort, UsagePage> s_pages =
                new ConcurrentDictionary<ushort, UsagePage>
                {
                    [0x0000] = UndefinedUsagePage.Instance,
                    [0x0001] = GenericDesktopUsagePage.Instance,
                    [0x0002] = SimulationUsagePage.Instance,
                    [0x0003] = VRUsagePage.Instance,
                    [0x0004] = SportUsagePage.Instance,
                    [0x0005] = GameUsagePage.Instance,
                    [0x0006] = GenericDeviceUsagePage.Instance,
                    [0x0007] = KeyboardKeypadUsagePage.Instance,
                    [0x0008] = LEDsUsagePage.Instance,
                    [0x0009] = ButtonUsagePage.Instance,
                    [0x000a] = OrdinalUsagePage.Instance,
                    [0x000b] = TelephonyUsagePage.Instance,
                    [0x000c] = ConsumerUsagePage.Instance,
                    [0x000d] = DigitizerUsagePage.Instance,
                    [0x000e] = HapticsUsagePage.Instance,
                    [0x000f] = PhysicalInterfaceDeviceUsagePage.Instance,
                    [0x0010] = UnicodeUsagePage.Instance,
                    [0x0012] = EyeAndHeadTrackersUsagePage.Instance,
                    [0x0014] = AuxiliaryDisplayUsagePage.Instance,
                    [0x0020] = SensorUsagePage.Instance,
                    [0x0040] = MedicalInstrumentsUsagePage.Instance,
                    [0x0041] = BrailleDisplayUsagePage.Instance,
                    [0x0059] = LightingAndIlluminationUsagePage.Instance,
                    [0x0080] = MonitorUsagePage.Instance,
                    [0x0081] = MonitorEnumeratedValuesUsagePage.Instance,
                    [0x0082] = VESAVirtualUsagePage.Instance,
                    [0x0083] = MonitorReservedUsagePage.Instance,
                    [0x0084] = PowerDeviceUsagePage.Instance,
                    [0x0085] = BatterySystemUsagePage.Instance,
                    [0x008c] = BarCodeScannerUsagePage.Instance,
                    [0x008d] = WeighingDevicesUsagePage.Instance,
                    [0x008e] = MagneticStripeReadingMSRDevicesUsagePage.Instance,
                    [0x008f] = ReservedPointOfSaleUsagePage.Instance,
                    [0x0090] = CameraControlUsagePage.Instance,
                    [0x0091] = ArcadeUsagePage.Instance,
                    [0xf1d0] = FastIDentityOnlineAllianceUsagePage.Instance
                };

        /// <summary>
        ///     Undefined Usage Page.
        /// </summary>
        public static readonly UndefinedUsagePage Undefined = UndefinedUsagePage.Instance;

        /// <summary>
        ///     Generic Desktop Controls Usage Page.
        /// </summary>
        public static readonly GenericDesktopUsagePage GenericDesktop = GenericDesktopUsagePage.Instance;

        /// <summary>
        ///     Simulation Controls Usage Page.
        /// </summary>
        public static readonly SimulationUsagePage Simulation = SimulationUsagePage.Instance;

        /// <summary>
        ///     VR Controls Usage Page.
        /// </summary>
        public static readonly VRUsagePage VR = VRUsagePage.Instance;

        /// <summary>
        ///     Sport Controls Usage Page.
        /// </summary>
        public static readonly SportUsagePage Sport = SportUsagePage.Instance;

        /// <summary>
        ///     Game Controls Usage Page.
        /// </summary>
        public static readonly GameUsagePage Game = GameUsagePage.Instance;

        /// <summary>
        ///     Generic Device Controls Usage Page.
        /// </summary>
        public static readonly GenericDeviceUsagePage GenericDevice = GenericDeviceUsagePage.Instance;

        /// <summary>
        ///     Keyboard/Keypad Usage Page.
        /// </summary>
        public static readonly KeyboardKeypadUsagePage KeyboardKeypad = KeyboardKeypadUsagePage.Instance;

        /// <summary>
        ///     LEDs Usage Page.
        /// </summary>
        public static readonly LEDsUsagePage LEDs = LEDsUsagePage.Instance;

        /// <summary>
        ///     Button Usage Page.
        /// </summary>
        public static readonly ButtonUsagePage Button = ButtonUsagePage.Instance;

        /// <summary>
        ///     Ordinal Usage Page.
        /// </summary>
        public static readonly OrdinalUsagePage Ordinal = OrdinalUsagePage.Instance;

        /// <summary>
        ///     Telephony Usage Page.
        /// </summary>
        public static readonly TelephonyUsagePage Telephony = TelephonyUsagePage.Instance;

        /// <summary>
        ///     Consumer Usage Page.
        /// </summary>
        public static readonly ConsumerUsagePage Consumer = ConsumerUsagePage.Instance;

        /// <summary>
        ///     Digitizer Usage Page.
        /// </summary>
        public static readonly DigitizerUsagePage Digitizer = DigitizerUsagePage.Instance;

        /// <summary>
        ///     Haptics Usage Page.
        /// </summary>
        public static readonly HapticsUsagePage Haptics = HapticsUsagePage.Instance;

        /// <summary>
        ///     Physical Interface Device Usage Page.
        /// </summary>
        public static readonly PhysicalInterfaceDeviceUsagePage PhysicalInterfaceDevice = PhysicalInterfaceDeviceUsagePage.Instance;

        /// <summary>
        ///     Unicode Usage Page.
        /// </summary>
        public static readonly UnicodeUsagePage Unicode = UnicodeUsagePage.Instance;

        /// <summary>
        ///     Eye and Head Trackers Usage Page.
        /// </summary>
        public static readonly EyeAndHeadTrackersUsagePage EyeAndHeadTrackers = EyeAndHeadTrackersUsagePage.Instance;

        /// <summary>
        ///     Auxiliary Display Usage Page.
        /// </summary>
        public static readonly AuxiliaryDisplayUsagePage AuxiliaryDisplay = AuxiliaryDisplayUsagePage.Instance;

        /// <summary>
        ///     Sensor Usage Page.
        /// </summary>
        public static readonly SensorUsagePage Sensor = SensorUsagePage.Instance;

        /// <summary>
        ///     Medical Instruments Usage Page.
        /// </summary>
        public static readonly MedicalInstrumentsUsagePage MedicalInstruments = MedicalInstrumentsUsagePage.Instance;

        /// <summary>
        ///     Braille Display Usage Page.
        /// </summary>
        public static readonly BrailleDisplayUsagePage BrailleDisplay = BrailleDisplayUsagePage.Instance;

        /// <summary>
        ///     Lighting and Illumination Usage Page.
        /// </summary>
        public static readonly LightingAndIlluminationUsagePage LightingAndIllumination = LightingAndIlluminationUsagePage.Instance;

        /// <summary>
        ///     Monitor Usage Page.
        /// </summary>
        public static readonly MonitorUsagePage Monitor = MonitorUsagePage.Instance;

        /// <summary>
        ///     Monitor Enumerated Values Usage Page.
        /// </summary>
        public static readonly MonitorEnumeratedValuesUsagePage MonitorEnumeratedValues = MonitorEnumeratedValuesUsagePage.Instance;

        /// <summary>
        ///     VESA Virtual Controls Usage Page.
        /// </summary>
        public static readonly VESAVirtualUsagePage VESAVirtual = VESAVirtualUsagePage.Instance;

        /// <summary>
        ///     Monitor Reserved Usage Page.
        /// </summary>
        public static readonly MonitorReservedUsagePage MonitorReserved = MonitorReservedUsagePage.Instance;

        /// <summary>
        ///     Power Device Usage Page.
        /// </summary>
        public static readonly PowerDeviceUsagePage PowerDevice = PowerDeviceUsagePage.Instance;

        /// <summary>
        ///     Battery System Usage Page.
        /// </summary>
        public static readonly BatterySystemUsagePage BatterySystem = BatterySystemUsagePage.Instance;

        /// <summary>
        ///     Bar Code Scanner Usage Page.
        /// </summary>
        public static readonly BarCodeScannerUsagePage BarCodeScanner = BarCodeScannerUsagePage.Instance;

        /// <summary>
        ///     Weighing Devices Usage Page.
        /// </summary>
        public static readonly WeighingDevicesUsagePage WeighingDevices = WeighingDevicesUsagePage.Instance;

        /// <summary>
        ///     Magnetic Stripe Reading (MSR) Devices Usage Page.
        /// </summary>
        public static readonly MagneticStripeReadingMSRDevicesUsagePage MagneticStripeReadingMSRDevices = MagneticStripeReadingMSRDevicesUsagePage.Instance;

        /// <summary>
        ///     Reserved Point of Sale Usage Page.
        /// </summary>
        public static readonly ReservedPointOfSaleUsagePage ReservedPointOfSale = ReservedPointOfSaleUsagePage.Instance;

        /// <summary>
        ///     Camera Control Usage Page.
        /// </summary>
        public static readonly CameraControlUsagePage CameraControl = CameraControlUsagePage.Instance;

        /// <summary>
        ///     Arcade Usage Page.
        /// </summary>
        public static readonly ArcadeUsagePage Arcade = ArcadeUsagePage.Instance;

        /// <summary>
        ///     Fast IDentity Online Alliance Usage Page.
        /// </summary>
        public static readonly FastIDentityOnlineAllianceUsagePage FastIDentityOnlineAlliance = FastIDentityOnlineAllianceUsagePage.Instance;

    }
}

namespace DevDecoder.HIDDevices.Pages
{
    using DevDecoder.HIDDevices.Usages;

    /// <summary>
    ///     Base class for all usage pages.
    /// </summary>
    public sealed class UndefinedUsagePage : UsagePage
    {
        /// <summary>
        ///     Singleton instance of Undefined Usage Page.
        /// </summary>
        public static readonly UndefinedUsagePage Instance = new UndefinedUsagePage();

        private UndefinedUsagePage() : base(0x0000, "Undefined")
        {
        }

        /// <inheritdoc />
        protected override Usage CreateUsage(ushort id) 
        {
            switch (id)
            {
                case 0x0000: return new Usage(this, id, "Undefined", UsageTypes.None);
            }

            return base.CreateUsage(id);
        }
    }

    /// <summary>
    ///     Base class for all usage pages.
    /// </summary>
    public sealed class GenericDesktopUsagePage : UsagePage
    {
        /// <summary>
        ///     Singleton instance of GenericDesktop Usage Page.
        /// </summary>
        public static readonly GenericDesktopUsagePage Instance = new GenericDesktopUsagePage();

        private GenericDesktopUsagePage() : base(0x0001, "GenericDesktop")
        {
        }

        /// <inheritdoc />
        protected override Usage CreateUsage(ushort id) 
        {
            switch (id)
            {
                case 0x0000: return new Usage(this, id, "Undefined", UsageTypes.None);
                case 0x0001: return new Usage(this, id, "Pointer", UsageTypes.CP);
                case 0x0002: return new Usage(this, id, "Mouse", UsageTypes.CA);
                case 0x0004: return new Usage(this, id, "Joystick", UsageTypes.CA);
                case 0x0005: return new Usage(this, id, "Game Pad", UsageTypes.CA);
                case 0x0006: return new Usage(this, id, "Keyboard", UsageTypes.CA);
                case 0x0007: return new Usage(this, id, "Keypad", UsageTypes.CA);
                case 0x0008: return new Usage(this, id, "Multi-axis Controller", UsageTypes.CA);
                case 0x0009: return new Usage(this, id, "Tablet PC System Controls", UsageTypes.CA);
                case 0x000a: return new Usage(this, id, "Water Cooling Device", UsageTypes.CA);
                case 0x000b: return new Usage(this, id, "Computer Chassis Device", UsageTypes.CA);
                case 0x000c: return new Usage(this, id, "Wireless Radio Controls", UsageTypes.CA);
                case 0x000d: return new Usage(this, id, "Portable Device Control", UsageTypes.CA);
                case 0x000e: return new Usage(this, id, "System Multi-axis Controller", UsageTypes.CA);
                case 0x000f: return new Usage(this, id, "Spatial Controller", UsageTypes.CA);
                case 0x0010: return new Usage(this, id, "Assistive Control", UsageTypes.CA);
                case 0x0011: return new Usage(this, id, "Device Dock", UsageTypes.CA);
                case 0x0012: return new Usage(this, id, "Dockable Device", UsageTypes.CA);
                case 0x0030: return new Usage(this, id, "X", UsageTypes.DV);
                case 0x0031: return new Usage(this, id, "Y", UsageTypes.DV);
                case 0x0032: return new Usage(this, id, "Z", UsageTypes.DV);
                case 0x0033: return new Usage(this, id, "Rx", UsageTypes.DV);
                case 0x0034: return new Usage(this, id, "Ry", UsageTypes.DV);
                case 0x0035: return new Usage(this, id, "Rz", UsageTypes.DV);
                case 0x0036: return new Usage(this, id, "Slider", UsageTypes.DV);
                case 0x0037: return new Usage(this, id, "Dial", UsageTypes.DV);
                case 0x0038: return new Usage(this, id, "Wheel", UsageTypes.DV);
                case 0x0039: return new Usage(this, id, "Hat switch", UsageTypes.DV);
                case 0x003a: return new Usage(this, id, "Counter Buffer", UsageTypes.CL);
                case 0x003b: return new Usage(this, id, "Byte Count", UsageTypes.DV);
                case 0x003c: return new Usage(this, id, "Motion Wakeup", UsageTypes.OSC);
                case 0x003d: return new Usage(this, id, "Start", UsageTypes.OOC);
                case 0x003e: return new Usage(this, id, "Select", UsageTypes.OOC);
                case 0x0040: return new Usage(this, id, "Vx", UsageTypes.DV);
                case 0x0041: return new Usage(this, id, "Vy", UsageTypes.DV);
                case 0x0042: return new Usage(this, id, "Vz", UsageTypes.DV);
                case 0x0043: return new Usage(this, id, "Vbrx", UsageTypes.DV);
                case 0x0044: return new Usage(this, id, "Vbry", UsageTypes.DV);
                case 0x0045: return new Usage(this, id, "Vbrz", UsageTypes.DV);
                case 0x0046: return new Usage(this, id, "Vno", UsageTypes.DV);
                case 0x0047: return new Usage(this, id, "Feature Notification", UsageTypes.DV|UsageTypes.DF);
                case 0x0048: return new Usage(this, id, "Resolution Multiplier", UsageTypes.DV);
                case 0x0049: return new Usage(this, id, "Qx", UsageTypes.DV);
                case 0x004a: return new Usage(this, id, "Qy", UsageTypes.DV);
                case 0x004b: return new Usage(this, id, "Qz", UsageTypes.DV);
                case 0x004c: return new Usage(this, id, "Qw", UsageTypes.DV);
                case 0x0080: return new Usage(this, id, "System Control", UsageTypes.CA);
                case 0x0081: return new Usage(this, id, "System Power Down", UsageTypes.OSC);
                case 0x0082: return new Usage(this, id, "System Sleep", UsageTypes.OSC);
                case 0x0083: return new Usage(this, id, "System Wake up", UsageTypes.OSC);
                case 0x0084: return new Usage(this, id, "System Context Menu", UsageTypes.OSC);
                case 0x0085: return new Usage(this, id, "System Main Menu", UsageTypes.OSC);
                case 0x0086: return new Usage(this, id, "System App Menu", UsageTypes.OSC);
                case 0x0087: return new Usage(this, id, "System Menu Help", UsageTypes.OSC);
                case 0x0088: return new Usage(this, id, "System Menu Exit", UsageTypes.OSC);
                case 0x0089: return new Usage(this, id, "System Menu Select", UsageTypes.OSC);
                case 0x008a: return new Usage(this, id, "System Menu Right", UsageTypes.RTC);
                case 0x008b: return new Usage(this, id, "System Menu Left", UsageTypes.RTC);
                case 0x008c: return new Usage(this, id, "System Menu Up", UsageTypes.RTC);
                case 0x008d: return new Usage(this, id, "System Menu Down", UsageTypes.RTC);
                case 0x008e: return new Usage(this, id, "System Cold Restart", UsageTypes.OSC);
                case 0x008f: return new Usage(this, id, "System Warm Restart", UsageTypes.OSC);
                case 0x0090: return new Usage(this, id, "D-pad Up", UsageTypes.OOC);
                case 0x0091: return new Usage(this, id, "D-pad Down", UsageTypes.OOC);
                case 0x0092: return new Usage(this, id, "D-pad Right", UsageTypes.OOC);
                case 0x0093: return new Usage(this, id, "D-pad Left", UsageTypes.OOC);
                case 0x0094: return new Usage(this, id, "Index Trigger", UsageTypes.MC|UsageTypes.DV);
                case 0x0095: return new Usage(this, id, "Palm Trigger", UsageTypes.MC|UsageTypes.DV);
                case 0x0096: return new Usage(this, id, "Thumbstick", UsageTypes.CP);
                case 0x0097: return new Usage(this, id, "System Function Shift", UsageTypes.MC);
                case 0x0098: return new Usage(this, id, "System Function Shift Lock", UsageTypes.OOC);
                case 0x0099: return new Usage(this, id, "System Function Shift Lock Indicator", UsageTypes.DV);
                case 0x009a: return new Usage(this, id, "System Dismiss Notification", UsageTypes.OSC);
                case 0x009b: return new Usage(this, id, "System Do Not Disturb", UsageTypes.OOC);
                case 0x00a0: return new Usage(this, id, "System Dock", UsageTypes.OSC);
                case 0x00a1: return new Usage(this, id, "System Undock", UsageTypes.OSC);
                case 0x00a2: return new Usage(this, id, "System Setup", UsageTypes.OSC);
                case 0x00a3: return new Usage(this, id, "System Break", UsageTypes.OSC);
                case 0x00a4: return new Usage(this, id, "System Debugger Break", UsageTypes.OSC);
                case 0x00a5: return new Usage(this, id, "Application Break", UsageTypes.OSC);
                case 0x00a6: return new Usage(this, id, "Application Debugger Break", UsageTypes.OSC);
                case 0x00a7: return new Usage(this, id, "System Speaker Mute", UsageTypes.OSC);
                case 0x00a8: return new Usage(this, id, "System Hibernate", UsageTypes.OSC);
                case 0x00b0: return new Usage(this, id, "System Display Invert", UsageTypes.OSC);
                case 0x00b1: return new Usage(this, id, "System Display Internal", UsageTypes.OSC);
                case 0x00b2: return new Usage(this, id, "System Display External", UsageTypes.OSC);
                case 0x00b3: return new Usage(this, id, "System Display Both", UsageTypes.OSC);
                case 0x00b4: return new Usage(this, id, "System Display Dual", UsageTypes.OSC);
                case 0x00b5: return new Usage(this, id, "System Display Toggle Int/Ext", UsageTypes.OSC);
                case 0x00b6: return new Usage(this, id, "System Display Swap Primary/Secondary", UsageTypes.OSC);
                case 0x00b7: return new Usage(this, id, "System Display LCD Autoscale", UsageTypes.OSC);
                case 0x00c0: return new Usage(this, id, "Sensor Zone", UsageTypes.CL);
                case 0x00c1: return new Usage(this, id, "RPM", UsageTypes.DV);
                case 0x00c2: return new Usage(this, id, "Coolant Level", UsageTypes.DV);
                case 0x00c3: return new Usage(this, id, "Coolant Critical Level", UsageTypes.SV);
                case 0x00c4: return new Usage(this, id, "Coolant Pump", UsageTypes.US);
                case 0x00c5: return new Usage(this, id, "Chassis Enclosure", UsageTypes.CL);
                case 0x00c6: return new Usage(this, id, "Wireless Radio Button", UsageTypes.OOC);
                case 0x00c7: return new Usage(this, id, "Wireless Radio LED", UsageTypes.OOC);
                case 0x00c8: return new Usage(this, id, "Wireless Radio Slider Switch", UsageTypes.OOC);
                case 0x00c9: return new Usage(this, id, "System Display Rotation Lock Button", UsageTypes.OOC);
                case 0x00ca: return new Usage(this, id, "System Display Rotation Lock Slider Switch", UsageTypes.OOC);
                case 0x00cb: return new Usage(this, id, "Control Enable", UsageTypes.DF);
                case 0x00d0: return new Usage(this, id, "Dockable Device Unique ID", UsageTypes.DV);
                case 0x00d1: return new Usage(this, id, "Dockable Device Vendor ID", UsageTypes.DV);
                case 0x00d2: return new Usage(this, id, "Dockable Device Primary Usage Page", UsageTypes.DV);
                case 0x00d3: return new Usage(this, id, "Dockable Device Primary Usage ID", UsageTypes.DV);
                case 0x00d4: return new Usage(this, id, "Dockable Device Docking State", UsageTypes.DF);
                case 0x00d5: return new Usage(this, id, "Dockable Device Display Occlusion", UsageTypes.CL);
                case 0x00d6: return new Usage(this, id, "Dockable Device Object Type", UsageTypes.DV);
            }

            return base.CreateUsage(id);
        }
    }

    /// <summary>
    ///     Base class for all usage pages.
    /// </summary>
    public sealed class SimulationUsagePage : UsagePage
    {
        /// <summary>
        ///     Singleton instance of Simulation Usage Page.
        /// </summary>
        public static readonly SimulationUsagePage Instance = new SimulationUsagePage();

        private SimulationUsagePage() : base(0x0002, "Simulation")
        {
        }

        /// <inheritdoc />
        protected override Usage CreateUsage(ushort id) 
        {
            switch (id)
            {
                case 0x0000: return new Usage(this, id, "Undefined", UsageTypes.None);
                case 0x0001: return new Usage(this, id, "Flight Simulation Device", UsageTypes.CA);
                case 0x0002: return new Usage(this, id, "Automobile Simulation Device", UsageTypes.CA);
                case 0x0003: return new Usage(this, id, "Tank Simulation Device", UsageTypes.CA);
                case 0x0004: return new Usage(this, id, "Spaceship Simulation Device", UsageTypes.CA);
                case 0x0005: return new Usage(this, id, "Submarine Simulation Device", UsageTypes.CA);
                case 0x0006: return new Usage(this, id, "Sailing Simulation Device", UsageTypes.CA);
                case 0x0007: return new Usage(this, id, "Motorcycle Simulation Device", UsageTypes.CA);
                case 0x0008: return new Usage(this, id, "Sports Simulation Device", UsageTypes.CA);
                case 0x0009: return new Usage(this, id, "Airplane Simulation Device", UsageTypes.CA);
                case 0x000a: return new Usage(this, id, "Helicopter Simulation Device", UsageTypes.CA);
                case 0x000b: return new Usage(this, id, "Magic Carpet Simulation Device", UsageTypes.CA);
                case 0x000c: return new Usage(this, id, "Bicycle Simulation Device", UsageTypes.CA);
                case 0x0020: return new Usage(this, id, "Flight Control Stick", UsageTypes.CA);
                case 0x0021: return new Usage(this, id, "Flight Stick", UsageTypes.CA);
                case 0x0022: return new Usage(this, id, "Cyclic Control", UsageTypes.CP);
                case 0x0023: return new Usage(this, id, "Cyclic Trim", UsageTypes.CP);
                case 0x0024: return new Usage(this, id, "Flight Yoke", UsageTypes.CA);
                case 0x0025: return new Usage(this, id, "Track Control", UsageTypes.CP);
                case 0x00b0: return new Usage(this, id, "Aileron", UsageTypes.DV);
                case 0x00b1: return new Usage(this, id, "Aileron Trim", UsageTypes.DV);
                case 0x00b2: return new Usage(this, id, "Anti-Torque Control", UsageTypes.DV);
                case 0x00b3: return new Usage(this, id, "Autopilot Enable", UsageTypes.OOC);
                case 0x00b4: return new Usage(this, id, "Chaff Release", UsageTypes.OSC);
                case 0x00b5: return new Usage(this, id, "Collective Control", UsageTypes.DV);
                case 0x00b6: return new Usage(this, id, "Dive Brake", UsageTypes.DV);
                case 0x00b7: return new Usage(this, id, "Electronic Countermeasures", UsageTypes.OOC);
                case 0x00b8: return new Usage(this, id, "Elevator", UsageTypes.DV);
                case 0x00b9: return new Usage(this, id, "Elevator Trim", UsageTypes.DV);
                case 0x00ba: return new Usage(this, id, "Rudder", UsageTypes.DV);
                case 0x00bb: return new Usage(this, id, "Throttle", UsageTypes.DV);
                case 0x00bc: return new Usage(this, id, "Flight Communications", UsageTypes.OOC);
                case 0x00bd: return new Usage(this, id, "Flare Release", UsageTypes.OSC);
                case 0x00be: return new Usage(this, id, "Landing Gear", UsageTypes.OOC);
                case 0x00bf: return new Usage(this, id, "Toe Brake", UsageTypes.DV);
                case 0x00c0: return new Usage(this, id, "Trigger", UsageTypes.MC);
                case 0x00c1: return new Usage(this, id, "Weapons Arm", UsageTypes.OOC);
                case 0x00c2: return new Usage(this, id, "Weapons Select", UsageTypes.OSC);
                case 0x00c3: return new Usage(this, id, "Wing Flaps", UsageTypes.DV);
                case 0x00c4: return new Usage(this, id, "Accelerator", UsageTypes.DV);
                case 0x00c5: return new Usage(this, id, "Brake", UsageTypes.DV);
                case 0x00c6: return new Usage(this, id, "Clutch", UsageTypes.DV);
                case 0x00c7: return new Usage(this, id, "Shifter", UsageTypes.DV);
                case 0x00c8: return new Usage(this, id, "Steering", UsageTypes.DV);
                case 0x00c9: return new Usage(this, id, "Turret Direction", UsageTypes.DV);
                case 0x00ca: return new Usage(this, id, "Barrel Elevation", UsageTypes.DV);
                case 0x00cb: return new Usage(this, id, "Dive Plane", UsageTypes.DV);
                case 0x00cc: return new Usage(this, id, "Ballast", UsageTypes.DV);
                case 0x00cd: return new Usage(this, id, "Bicycle Crank", UsageTypes.DV);
                case 0x00ce: return new Usage(this, id, "Handle Bars", UsageTypes.DV);
                case 0x00cf: return new Usage(this, id, "Front Brake", UsageTypes.DV);
                case 0x00d0: return new Usage(this, id, "Rear Brake", UsageTypes.DV);
            }

            return base.CreateUsage(id);
        }
    }

    /// <summary>
    ///     Base class for all usage pages.
    /// </summary>
    public sealed class VRUsagePage : UsagePage
    {
        /// <summary>
        ///     Singleton instance of VR Usage Page.
        /// </summary>
        public static readonly VRUsagePage Instance = new VRUsagePage();

        private VRUsagePage() : base(0x0003, "VR")
        {
        }

        /// <inheritdoc />
        protected override Usage CreateUsage(ushort id) 
        {
            switch (id)
            {
                case 0x0000: return new Usage(this, id, "Undefined", UsageTypes.None);
                case 0x0001: return new Usage(this, id, "Belt", UsageTypes.CA);
                case 0x0002: return new Usage(this, id, "Body Suit", UsageTypes.CA);
                case 0x0003: return new Usage(this, id, "Flexor", UsageTypes.CP);
                case 0x0004: return new Usage(this, id, "Glove", UsageTypes.CA);
                case 0x0005: return new Usage(this, id, "Head Tracker", UsageTypes.CP);
                case 0x0006: return new Usage(this, id, "Head Mounted Display", UsageTypes.CA);
                case 0x0007: return new Usage(this, id, "Hand Tracker", UsageTypes.CA);
                case 0x0008: return new Usage(this, id, "Oculometer", UsageTypes.CA);
                case 0x0009: return new Usage(this, id, "Vest", UsageTypes.CA);
                case 0x000a: return new Usage(this, id, "Animatronic Device", UsageTypes.CA);
                case 0x0020: return new Usage(this, id, "Stereo Enable", UsageTypes.OOC);
                case 0x0021: return new Usage(this, id, "Display Enable", UsageTypes.OOC);
            }

            return base.CreateUsage(id);
        }
    }

    /// <summary>
    ///     Base class for all usage pages.
    /// </summary>
    public sealed class SportUsagePage : UsagePage
    {
        /// <summary>
        ///     Singleton instance of Sport Usage Page.
        /// </summary>
        public static readonly SportUsagePage Instance = new SportUsagePage();

        private SportUsagePage() : base(0x0004, "Sport")
        {
        }

        /// <inheritdoc />
        protected override Usage CreateUsage(ushort id) 
        {
            switch (id)
            {
                case 0x0000: return new Usage(this, id, "Undefined", UsageTypes.None);
                case 0x0001: return new Usage(this, id, "Baseball Bat", UsageTypes.CA);
                case 0x0002: return new Usage(this, id, "Golf Club", UsageTypes.CA);
                case 0x0003: return new Usage(this, id, "Rowing Machine", UsageTypes.CA);
                case 0x0004: return new Usage(this, id, "Treadmill", UsageTypes.CA);
                case 0x0030: return new Usage(this, id, "Oar", UsageTypes.DV);
                case 0x0031: return new Usage(this, id, "Slope", UsageTypes.DV);
                case 0x0032: return new Usage(this, id, "Rate", UsageTypes.DV);
                case 0x0033: return new Usage(this, id, "Stick Speed", UsageTypes.DV);
                case 0x0034: return new Usage(this, id, "Stick Face Angle", UsageTypes.DV);
                case 0x0035: return new Usage(this, id, "Stick Heel/Toe", UsageTypes.DV);
                case 0x0036: return new Usage(this, id, "Stick Follow Through", UsageTypes.DV);
                case 0x0037: return new Usage(this, id, "Stick Tempo", UsageTypes.DV);
                case 0x0038: return new Usage(this, id, "Stick Type", UsageTypes.NAry);
                case 0x0039: return new Usage(this, id, "Stick Height", UsageTypes.DV);
                case 0x0050: return new Usage(this, id, "Putter", UsageTypes.Sel);
                case 0x0051: return new Usage(this, id, "1 Iron", UsageTypes.Sel);
                case 0x0052: return new Usage(this, id, "2 Iron", UsageTypes.Sel);
                case 0x0053: return new Usage(this, id, "3 Iron", UsageTypes.Sel);
                case 0x0054: return new Usage(this, id, "4 Iron", UsageTypes.Sel);
                case 0x0055: return new Usage(this, id, "5 Iron", UsageTypes.Sel);
                case 0x0056: return new Usage(this, id, "6 Iron", UsageTypes.Sel);
                case 0x0057: return new Usage(this, id, "7 Iron", UsageTypes.Sel);
                case 0x0058: return new Usage(this, id, "8 Iron", UsageTypes.Sel);
                case 0x0059: return new Usage(this, id, "9 Iron", UsageTypes.Sel);
                case 0x005a: return new Usage(this, id, "10 Iron", UsageTypes.Sel);
                case 0x005b: return new Usage(this, id, "11 Iron", UsageTypes.Sel);
                case 0x005c: return new Usage(this, id, "Sand Wedge", UsageTypes.Sel);
                case 0x005d: return new Usage(this, id, "Loft Wedge", UsageTypes.Sel);
                case 0x005e: return new Usage(this, id, "Power Wedge", UsageTypes.Sel);
                case 0x005f: return new Usage(this, id, "1 Wood", UsageTypes.Sel);
                case 0x0060: return new Usage(this, id, "3 Wood", UsageTypes.Sel);
                case 0x0061: return new Usage(this, id, "5 Wood", UsageTypes.Sel);
                case 0x0062: return new Usage(this, id, "7 Wood", UsageTypes.Sel);
                case 0x0063: return new Usage(this, id, "9 Wood", UsageTypes.Sel);
            }

            return base.CreateUsage(id);
        }
    }

    /// <summary>
    ///     Base class for all usage pages.
    /// </summary>
    public sealed class GameUsagePage : UsagePage
    {
        /// <summary>
        ///     Singleton instance of Game Usage Page.
        /// </summary>
        public static readonly GameUsagePage Instance = new GameUsagePage();

        private GameUsagePage() : base(0x0005, "Game")
        {
        }

        /// <inheritdoc />
        protected override Usage CreateUsage(ushort id) 
        {
            switch (id)
            {
                case 0x0000: return new Usage(this, id, "Undefined", UsageTypes.None);
                case 0x0001: return new Usage(this, id, "3D Game Controller", UsageTypes.CA);
                case 0x0002: return new Usage(this, id, "Pinball Device", UsageTypes.CA);
                case 0x0003: return new Usage(this, id, "Gun Device", UsageTypes.CA);
                case 0x0020: return new Usage(this, id, "Point of View", UsageTypes.CP);
                case 0x0021: return new Usage(this, id, "Turn Right/Left", UsageTypes.DV);
                case 0x0022: return new Usage(this, id, "Pitch Right/Left", UsageTypes.DV);
                case 0x0023: return new Usage(this, id, "Roll Right/Left", UsageTypes.DV);
                case 0x0024: return new Usage(this, id, "Move Right/Left", UsageTypes.DV);
                case 0x0025: return new Usage(this, id, "Move Forward/Backward", UsageTypes.DV);
                case 0x0026: return new Usage(this, id, "Move Up/Down", UsageTypes.DV);
                case 0x0027: return new Usage(this, id, "Lean Right/Left", UsageTypes.DV);
                case 0x0028: return new Usage(this, id, "Lean Forward/Backward", UsageTypes.DV);
                case 0x0029: return new Usage(this, id, "Height of POV", UsageTypes.DV);
                case 0x002a: return new Usage(this, id, "Flipper", UsageTypes.MC);
                case 0x002b: return new Usage(this, id, "Secondary Flipper", UsageTypes.MC);
                case 0x002c: return new Usage(this, id, "Bump", UsageTypes.MC);
                case 0x002d: return new Usage(this, id, "New Game", UsageTypes.OSC);
                case 0x002e: return new Usage(this, id, "Shoot Ball", UsageTypes.OSC);
                case 0x002f: return new Usage(this, id, "Player", UsageTypes.OSC);
                case 0x0030: return new Usage(this, id, "Gun Bolt", UsageTypes.OOC);
                case 0x0031: return new Usage(this, id, "Gun Clip", UsageTypes.OOC);
                case 0x0032: return new Usage(this, id, "Gun Selector", UsageTypes.NAry);
                case 0x0033: return new Usage(this, id, "Gun Single Shot", UsageTypes.Sel);
                case 0x0034: return new Usage(this, id, "Gun Burst", UsageTypes.Sel);
                case 0x0035: return new Usage(this, id, "Gun Automatic", UsageTypes.Sel);
                case 0x0036: return new Usage(this, id, "Gun Safety", UsageTypes.OOC);
                case 0x0037: return new Usage(this, id, "Gamepad Fire/Jump", UsageTypes.CL);
                case 0x0039: return new Usage(this, id, "Gamepad Trigger", UsageTypes.CL);
                case 0x003a: return new Usage(this, id, "Form-fitting Gamepad", UsageTypes.SF);
            }

            return base.CreateUsage(id);
        }
    }

    /// <summary>
    ///     Base class for all usage pages.
    /// </summary>
    public sealed class GenericDeviceUsagePage : UsagePage
    {
        /// <summary>
        ///     Singleton instance of GenericDevice Usage Page.
        /// </summary>
        public static readonly GenericDeviceUsagePage Instance = new GenericDeviceUsagePage();

        private GenericDeviceUsagePage() : base(0x0006, "GenericDevice")
        {
        }

        /// <inheritdoc />
        protected override Usage CreateUsage(ushort id) 
        {
            switch (id)
            {
                case 0x0000: return new Usage(this, id, "Undefined", UsageTypes.None);
                case 0x0001: return new Usage(this, id, "Background Controls", UsageTypes.CA);
                case 0x0020: return new Usage(this, id, "Battery Strength", UsageTypes.DV);
                case 0x0021: return new Usage(this, id, "Wireless Channel", UsageTypes.DV);
                case 0x0022: return new Usage(this, id, "Wireless ID", UsageTypes.DV);
                case 0x0023: return new Usage(this, id, "Discover Wireless Control", UsageTypes.OSC);
                case 0x0024: return new Usage(this, id, "Security Code Character Entered", UsageTypes.OSC);
                case 0x0025: return new Usage(this, id, "Security Code Character Erased", UsageTypes.OSC);
                case 0x0026: return new Usage(this, id, "Security Code Cleared", UsageTypes.OSC);
                case 0x0027: return new Usage(this, id, "Sequence ID", UsageTypes.DV);
                case 0x0028: return new Usage(this, id, "Sequence ID Reset", UsageTypes.DF);
                case 0x0029: return new Usage(this, id, "RF Signal Strength", UsageTypes.DV);
                case 0x002a: return new Usage(this, id, "Software Version", UsageTypes.CL);
                case 0x002b: return new Usage(this, id, "Protocol Version", UsageTypes.CL);
                case 0x002c: return new Usage(this, id, "Hardware Version", UsageTypes.CL);
                case 0x002d: return new Usage(this, id, "Major", UsageTypes.SV);
                case 0x002e: return new Usage(this, id, "Minor", UsageTypes.SV);
                case 0x002f: return new Usage(this, id, "Revision", UsageTypes.SV);
                case 0x0030: return new Usage(this, id, "Handedness", UsageTypes.NAry);
                case 0x0031: return new Usage(this, id, "Either Hand", UsageTypes.Sel);
                case 0x0032: return new Usage(this, id, "Left Hand", UsageTypes.Sel);
                case 0x0033: return new Usage(this, id, "Right Hand", UsageTypes.Sel);
                case 0x0034: return new Usage(this, id, "Both Hands", UsageTypes.Sel);
                case 0x0040: return new Usage(this, id, "Grip Pose Offset", UsageTypes.CP);
                case 0x0041: return new Usage(this, id, "Pointer Pose Offset", UsageTypes.CP);
            }

            return base.CreateUsage(id);
        }
    }

    /// <summary>
    ///     Base class for all usage pages.
    /// </summary>
    public sealed class KeyboardKeypadUsagePage : UsagePage
    {
        /// <summary>
        ///     Singleton instance of KeyboardKeypad Usage Page.
        /// </summary>
        public static readonly KeyboardKeypadUsagePage Instance = new KeyboardKeypadUsagePage();

        private KeyboardKeypadUsagePage() : base(0x0007, "KeyboardKeypad")
        {
        }

        /// <inheritdoc />
        protected override Usage CreateUsage(ushort id) 
        {
            switch (id)
            {
                case 0x0000: return new Usage(this, id, "None", UsageTypes.Sel);
                case 0x0001: return new Usage(this, id, "ErrorRollOver", UsageTypes.Sel);
                case 0x0002: return new Usage(this, id, "POSTFail", UsageTypes.Sel);
                case 0x0003: return new Usage(this, id, "ErrorUndefined", UsageTypes.Sel);
                case 0x0004: return new Usage(this, id, "a A", UsageTypes.Sel);
                case 0x0005: return new Usage(this, id, "b B", UsageTypes.Sel);
                case 0x0006: return new Usage(this, id, "c C", UsageTypes.Sel);
                case 0x0007: return new Usage(this, id, "d D", UsageTypes.Sel);
                case 0x0008: return new Usage(this, id, "e E", UsageTypes.Sel);
                case 0x0009: return new Usage(this, id, "f F", UsageTypes.Sel);
                case 0x000a: return new Usage(this, id, "g G", UsageTypes.Sel);
                case 0x000b: return new Usage(this, id, "h H", UsageTypes.Sel);
                case 0x000c: return new Usage(this, id, "i I", UsageTypes.Sel);
                case 0x000d: return new Usage(this, id, "j J", UsageTypes.Sel);
                case 0x000e: return new Usage(this, id, "k K", UsageTypes.Sel);
                case 0x000f: return new Usage(this, id, "l L", UsageTypes.Sel);
                case 0x0010: return new Usage(this, id, "m M", UsageTypes.Sel);
                case 0x0011: return new Usage(this, id, "n N", UsageTypes.Sel);
                case 0x0012: return new Usage(this, id, "o O", UsageTypes.Sel);
                case 0x0013: return new Usage(this, id, "p P", UsageTypes.Sel);
                case 0x0014: return new Usage(this, id, "q Q", UsageTypes.Sel);
                case 0x0015: return new Usage(this, id, "r R", UsageTypes.Sel);
                case 0x0016: return new Usage(this, id, "s S", UsageTypes.Sel);
                case 0x0017: return new Usage(this, id, "t T", UsageTypes.Sel);
                case 0x0018: return new Usage(this, id, "u U", UsageTypes.Sel);
                case 0x0019: return new Usage(this, id, "v V", UsageTypes.Sel);
                case 0x001a: return new Usage(this, id, "w W", UsageTypes.Sel);
                case 0x001b: return new Usage(this, id, "x X", UsageTypes.Sel);
                case 0x001c: return new Usage(this, id, "y Y", UsageTypes.Sel);
                case 0x001d: return new Usage(this, id, "z Z", UsageTypes.Sel);
                case 0x001e: return new Usage(this, id, "1 !", UsageTypes.Sel);
                case 0x001f: return new Usage(this, id, "2 @", UsageTypes.Sel);
                case 0x0020: return new Usage(this, id, "3 #", UsageTypes.Sel);
                case 0x0021: return new Usage(this, id, "4 $", UsageTypes.Sel);
                case 0x0022: return new Usage(this, id, "5 %", UsageTypes.Sel);
                case 0x0023: return new Usage(this, id, "6 ^", UsageTypes.Sel);
                case 0x0024: return new Usage(this, id, "7 &", UsageTypes.Sel);
                case 0x0025: return new Usage(this, id, "8 *", UsageTypes.Sel);
                case 0x0026: return new Usage(this, id, "9 (", UsageTypes.Sel);
                case 0x0027: return new Usage(this, id, "0 )", UsageTypes.Sel);
                case 0x0028: return new Usage(this, id, "Enter", UsageTypes.Sel);
                case 0x0029: return new Usage(this, id, "Esc", UsageTypes.Sel);
                case 0x002a: return new Usage(this, id, "Backspace", UsageTypes.Sel);
                case 0x002b: return new Usage(this, id, "Tab", UsageTypes.Sel);
                case 0x002c: return new Usage(this, id, "Space", UsageTypes.Sel);
                case 0x002d: return new Usage(this, id, "- _", UsageTypes.Sel);
                case 0x002e: return new Usage(this, id, "= +", UsageTypes.Sel);
                case 0x002f: return new Usage(this, id, "[ {", UsageTypes.Sel);
                case 0x0030: return new Usage(this, id, "] }", UsageTypes.Sel);
                case 0x0031: return new Usage(this, id, "\\ |", UsageTypes.Sel);
                case 0x0032: return new Usage(this, id, "# ~", UsageTypes.Sel);
                case 0x0033: return new Usage(this, id, "; :", UsageTypes.Sel);
                case 0x0034: return new Usage(this, id, "' \"", UsageTypes.Sel);
                case 0x0035: return new Usage(this, id, "` ´", UsageTypes.Sel);
                case 0x0036: return new Usage(this, id, ", <", UsageTypes.Sel);
                case 0x0037: return new Usage(this, id, ". >", UsageTypes.Sel);
                case 0x0038: return new Usage(this, id, "/ ?", UsageTypes.Sel);
                case 0x0039: return new Usage(this, id, "CapsLock", UsageTypes.Sel);
                case 0x003a: return new Usage(this, id, "F1", UsageTypes.Sel);
                case 0x003b: return new Usage(this, id, "F2", UsageTypes.Sel);
                case 0x003c: return new Usage(this, id, "F3", UsageTypes.Sel);
                case 0x003d: return new Usage(this, id, "F4", UsageTypes.Sel);
                case 0x003e: return new Usage(this, id, "F5", UsageTypes.Sel);
                case 0x003f: return new Usage(this, id, "F6", UsageTypes.Sel);
                case 0x0040: return new Usage(this, id, "F7", UsageTypes.Sel);
                case 0x0041: return new Usage(this, id, "F8", UsageTypes.Sel);
                case 0x0042: return new Usage(this, id, "F9", UsageTypes.Sel);
                case 0x0043: return new Usage(this, id, "F10", UsageTypes.Sel);
                case 0x0044: return new Usage(this, id, "F11", UsageTypes.Sel);
                case 0x0045: return new Usage(this, id, "F12", UsageTypes.Sel);
                case 0x0046: return new Usage(this, id, "PrintScreen SysRq", UsageTypes.Sel);
                case 0x0047: return new Usage(this, id, "ScrollLock", UsageTypes.Sel);
                case 0x0048: return new Usage(this, id, "Pause", UsageTypes.Sel);
                case 0x0049: return new Usage(this, id, "Insert", UsageTypes.Sel);
                case 0x004a: return new Usage(this, id, "Home", UsageTypes.Sel);
                case 0x004b: return new Usage(this, id, "PageUp", UsageTypes.Sel);
                case 0x004c: return new Usage(this, id, "Delete", UsageTypes.Sel);
                case 0x004d: return new Usage(this, id, "End", UsageTypes.Sel);
                case 0x004e: return new Usage(this, id, "PageDown", UsageTypes.Sel);
                case 0x004f: return new Usage(this, id, "RightArrow", UsageTypes.Sel);
                case 0x0050: return new Usage(this, id, "LeftArrow", UsageTypes.Sel);
                case 0x0051: return new Usage(this, id, "DownArrow", UsageTypes.Sel);
                case 0x0052: return new Usage(this, id, "UpArrow", UsageTypes.Sel);
                case 0x0053: return new Usage(this, id, "NumLock Clear", UsageTypes.Sel);
                case 0x0054: return new Usage(this, id, "Keypad /", UsageTypes.Sel);
                case 0x0055: return new Usage(this, id, "Keypad *", UsageTypes.Sel);
                case 0x0056: return new Usage(this, id, "Keypad -", UsageTypes.Sel);
                case 0x0057: return new Usage(this, id, "Keypad +", UsageTypes.Sel);
                case 0x0058: return new Usage(this, id, "Keypad Enter", UsageTypes.Sel);
                case 0x0059: return new Usage(this, id, "Keypad 1", UsageTypes.Sel);
                case 0x005a: return new Usage(this, id, "Keypad 2", UsageTypes.Sel);
                case 0x005b: return new Usage(this, id, "Keypad 3", UsageTypes.Sel);
                case 0x005c: return new Usage(this, id, "Keypad 4", UsageTypes.Sel);
                case 0x005d: return new Usage(this, id, "Keypad 5", UsageTypes.Sel);
                case 0x005e: return new Usage(this, id, "Keypad 6", UsageTypes.Sel);
                case 0x005f: return new Usage(this, id, "Keypad 7", UsageTypes.Sel);
                case 0x0060: return new Usage(this, id, "Keypad 8", UsageTypes.Sel);
                case 0x0061: return new Usage(this, id, "Keypad 9", UsageTypes.Sel);
                case 0x0062: return new Usage(this, id, "Keypad 0", UsageTypes.Sel);
                case 0x0063: return new Usage(this, id, "Keypad .", UsageTypes.Sel);
                case 0x0064: return new Usage(this, id, "\\ |", UsageTypes.Sel);
                case 0x0065: return new Usage(this, id, "Application", UsageTypes.Sel);
                case 0x0066: return new Usage(this, id, "Power", UsageTypes.Sel);
                case 0x0067: return new Usage(this, id, "Keypad =", UsageTypes.Sel);
                case 0x0068: return new Usage(this, id, "F13", UsageTypes.Sel);
                case 0x0069: return new Usage(this, id, "F14", UsageTypes.Sel);
                case 0x006a: return new Usage(this, id, "F15", UsageTypes.Sel);
                case 0x006b: return new Usage(this, id, "F16", UsageTypes.Sel);
                case 0x006c: return new Usage(this, id, "F17", UsageTypes.Sel);
                case 0x006d: return new Usage(this, id, "F18", UsageTypes.Sel);
                case 0x006e: return new Usage(this, id, "F19", UsageTypes.Sel);
                case 0x006f: return new Usage(this, id, "F20", UsageTypes.Sel);
                case 0x0070: return new Usage(this, id, "F21", UsageTypes.Sel);
                case 0x0071: return new Usage(this, id, "F22", UsageTypes.Sel);
                case 0x0072: return new Usage(this, id, "F23", UsageTypes.Sel);
                case 0x0073: return new Usage(this, id, "F24", UsageTypes.Sel);
                case 0x0074: return new Usage(this, id, "Execute", UsageTypes.Sel);
                case 0x0075: return new Usage(this, id, "Help", UsageTypes.Sel);
                case 0x0076: return new Usage(this, id, "Menu", UsageTypes.Sel);
                case 0x0077: return new Usage(this, id, "Select", UsageTypes.Sel);
                case 0x0078: return new Usage(this, id, "Stop", UsageTypes.Sel);
                case 0x0079: return new Usage(this, id, "Again", UsageTypes.Sel);
                case 0x007a: return new Usage(this, id, "Undo", UsageTypes.Sel);
                case 0x007b: return new Usage(this, id, "Cut", UsageTypes.Sel);
                case 0x007c: return new Usage(this, id, "Copy", UsageTypes.Sel);
                case 0x007d: return new Usage(this, id, "Paste", UsageTypes.Sel);
                case 0x007e: return new Usage(this, id, "Find", UsageTypes.Sel);
                case 0x007f: return new Usage(this, id, "Mute", UsageTypes.Sel);
                case 0x0080: return new Usage(this, id, "VolumeUp", UsageTypes.Sel);
                case 0x0081: return new Usage(this, id, "VolumeDown", UsageTypes.Sel);
                case 0x0082: return new Usage(this, id, "LockingCapsLock", UsageTypes.Sel);
                case 0x0083: return new Usage(this, id, "LockingNumLock", UsageTypes.Sel);
                case 0x0084: return new Usage(this, id, "LockingScrollLock", UsageTypes.Sel);
                case 0x0085: return new Usage(this, id, "Keypad ,", UsageTypes.Sel);
                case 0x0086: return new Usage(this, id, "Keypad ==", UsageTypes.Sel);
                case 0x0087: return new Usage(this, id, "International1", UsageTypes.Sel);
                case 0x0088: return new Usage(this, id, "International2", UsageTypes.Sel);
                case 0x0089: return new Usage(this, id, "International3", UsageTypes.Sel);
                case 0x008a: return new Usage(this, id, "International4", UsageTypes.Sel);
                case 0x008b: return new Usage(this, id, "International5", UsageTypes.Sel);
                case 0x008c: return new Usage(this, id, "International6", UsageTypes.Sel);
                case 0x008d: return new Usage(this, id, "International7", UsageTypes.Sel);
                case 0x008e: return new Usage(this, id, "International8", UsageTypes.Sel);
                case 0x008f: return new Usage(this, id, "International9", UsageTypes.Sel);
                case 0x0090: return new Usage(this, id, "LANG1", UsageTypes.Sel);
                case 0x0091: return new Usage(this, id, "LANG2", UsageTypes.Sel);
                case 0x0092: return new Usage(this, id, "LANG3", UsageTypes.Sel);
                case 0x0093: return new Usage(this, id, "LANG4", UsageTypes.Sel);
                case 0x0094: return new Usage(this, id, "LANG5", UsageTypes.Sel);
                case 0x0095: return new Usage(this, id, "LANG6", UsageTypes.Sel);
                case 0x0096: return new Usage(this, id, "LANG7", UsageTypes.Sel);
                case 0x0097: return new Usage(this, id, "LANG8", UsageTypes.Sel);
                case 0x0098: return new Usage(this, id, "LANG9", UsageTypes.Sel);
                case 0x0099: return new Usage(this, id, "Alternate Erase", UsageTypes.Sel);
                case 0x009a: return new Usage(this, id, "SysReq Attention", UsageTypes.Sel);
                case 0x009b: return new Usage(this, id, "Cancel", UsageTypes.Sel);
                case 0x009c: return new Usage(this, id, "Clear", UsageTypes.Sel);
                case 0x009d: return new Usage(this, id, "Prior", UsageTypes.Sel);
                case 0x009e: return new Usage(this, id, "Return", UsageTypes.Sel);
                case 0x009f: return new Usage(this, id, "Separator", UsageTypes.Sel);
                case 0x00a0: return new Usage(this, id, "Out", UsageTypes.Sel);
                case 0x00a1: return new Usage(this, id, "Oper", UsageTypes.Sel);
                case 0x00a2: return new Usage(this, id, "Clear Again", UsageTypes.Sel);
                case 0x00a3: return new Usage(this, id, "CrSel Props", UsageTypes.Sel);
                case 0x00a4: return new Usage(this, id, "ExSel", UsageTypes.Sel);
                case 0x00b0: return new Usage(this, id, "Keypad 00", UsageTypes.Sel);
                case 0x00b1: return new Usage(this, id, "Keypad 000", UsageTypes.Sel);
                case 0x00b2: return new Usage(this, id, "1000sSeparator", UsageTypes.Sel);
                case 0x00b3: return new Usage(this, id, "DecimalSeparator", UsageTypes.Sel);
                case 0x00b4: return new Usage(this, id, "CurrencyUnit", UsageTypes.Sel);
                case 0x00b5: return new Usage(this, id, "CurrencySubunit", UsageTypes.Sel);
                case 0x00b6: return new Usage(this, id, "Keypad (", UsageTypes.Sel);
                case 0x00b7: return new Usage(this, id, "Keypad )", UsageTypes.Sel);
                case 0x00b8: return new Usage(this, id, "Keypad {", UsageTypes.Sel);
                case 0x00b9: return new Usage(this, id, "Keypad }", UsageTypes.Sel);
                case 0x00ba: return new Usage(this, id, "Keypad Tab", UsageTypes.Sel);
                case 0x00bb: return new Usage(this, id, "Keypad Backspace", UsageTypes.Sel);
                case 0x00bc: return new Usage(this, id, "Keypad A", UsageTypes.Sel);
                case 0x00bd: return new Usage(this, id, "Keypad B", UsageTypes.Sel);
                case 0x00be: return new Usage(this, id, "Keypad C", UsageTypes.Sel);
                case 0x00bf: return new Usage(this, id, "Keypad D", UsageTypes.Sel);
                case 0x00c0: return new Usage(this, id, "Keypad E", UsageTypes.Sel);
                case 0x00c1: return new Usage(this, id, "Keypad F", UsageTypes.Sel);
                case 0x00c2: return new Usage(this, id, "Keypad XOR", UsageTypes.Sel);
                case 0x00c3: return new Usage(this, id, "Keypad ^", UsageTypes.Sel);
                case 0x00c4: return new Usage(this, id, "Keypad %", UsageTypes.Sel);
                case 0x00c5: return new Usage(this, id, "Keypad <", UsageTypes.Sel);
                case 0x00c6: return new Usage(this, id, "Keypad >", UsageTypes.Sel);
                case 0x00c7: return new Usage(this, id, "Keypad &", UsageTypes.Sel);
                case 0x00c8: return new Usage(this, id, "Keypad &&", UsageTypes.Sel);
                case 0x00c9: return new Usage(this, id, "Keypad |", UsageTypes.Sel);
                case 0x00ca: return new Usage(this, id, "Keypad ||", UsageTypes.Sel);
                case 0x00cb: return new Usage(this, id, "Keypad :", UsageTypes.Sel);
                case 0x00cc: return new Usage(this, id, "Keypad #", UsageTypes.Sel);
                case 0x00cd: return new Usage(this, id, "Keypad Space", UsageTypes.Sel);
                case 0x00ce: return new Usage(this, id, "Keypad @", UsageTypes.Sel);
                case 0x00cf: return new Usage(this, id, "Keypad !", UsageTypes.Sel);
                case 0x00d0: return new Usage(this, id, "Keypad MemoryStore", UsageTypes.Sel);
                case 0x00d1: return new Usage(this, id, "Keypad MemoryRecall", UsageTypes.Sel);
                case 0x00d2: return new Usage(this, id, "Keypad MemoryClear", UsageTypes.Sel);
                case 0x00d3: return new Usage(this, id, "Keypad MemoryAdd", UsageTypes.Sel);
                case 0x00d4: return new Usage(this, id, "Keypad MemorySubtract", UsageTypes.Sel);
                case 0x00d5: return new Usage(this, id, "Keypad MemoryMultiply", UsageTypes.Sel);
                case 0x00d6: return new Usage(this, id, "Keypad MemoryDivide", UsageTypes.Sel);
                case 0x00d7: return new Usage(this, id, "Keypad +/-", UsageTypes.Sel);
                case 0x00d8: return new Usage(this, id, "Keypad Clear", UsageTypes.Sel);
                case 0x00d9: return new Usage(this, id, "Keypad ClearEntry", UsageTypes.Sel);
                case 0x00da: return new Usage(this, id, "Keypad Binary", UsageTypes.Sel);
                case 0x00db: return new Usage(this, id, "Keypad Octal", UsageTypes.Sel);
                case 0x00dc: return new Usage(this, id, "Keypad Decimal", UsageTypes.Sel);
                case 0x00dd: return new Usage(this, id, "Keypad Hexadecimal", UsageTypes.Sel);
                case 0x00e0: return new Usage(this, id, "LeftCtrl", UsageTypes.DF);
                case 0x00e1: return new Usage(this, id, "LeftShift", UsageTypes.DF);
                case 0x00e2: return new Usage(this, id, "LeftAlt", UsageTypes.DF);
                case 0x00e3: return new Usage(this, id, "LeftGUI", UsageTypes.DF);
                case 0x00e4: return new Usage(this, id, "RightCtrl", UsageTypes.DF);
                case 0x00e5: return new Usage(this, id, "RightShift", UsageTypes.DF);
                case 0x00e6: return new Usage(this, id, "RightAlt", UsageTypes.DF);
                case 0x00e7: return new Usage(this, id, "RightGUI", UsageTypes.DF);
            }

            return base.CreateUsage(id);
        }
    }

    /// <summary>
    ///     Base class for all usage pages.
    /// </summary>
    public sealed class LEDsUsagePage : UsagePage
    {
        /// <summary>
        ///     Singleton instance of LEDs Usage Page.
        /// </summary>
        public static readonly LEDsUsagePage Instance = new LEDsUsagePage();

        private LEDsUsagePage() : base(0x0008, "LEDs")
        {
        }

        /// <inheritdoc />
        protected override Usage CreateUsage(ushort id) 
        {
            switch (id)
            {
                case 0x0000: return new Usage(this, id, "Undefined", UsageTypes.None);
                case 0x0001: return new Usage(this, id, "Num Lock", UsageTypes.OOC);
                case 0x0002: return new Usage(this, id, "Caps Lock", UsageTypes.OOC);
                case 0x0003: return new Usage(this, id, "Scroll Lock", UsageTypes.OOC);
                case 0x0004: return new Usage(this, id, "Compose", UsageTypes.OOC);
                case 0x0005: return new Usage(this, id, "Kana", UsageTypes.OOC);
                case 0x0006: return new Usage(this, id, "Power", UsageTypes.OOC);
                case 0x0007: return new Usage(this, id, "Shift", UsageTypes.OOC);
                case 0x0008: return new Usage(this, id, "Do Not Disturb", UsageTypes.OOC);
                case 0x0009: return new Usage(this, id, "Mute", UsageTypes.OOC);
                case 0x000a: return new Usage(this, id, "Tone Enable", UsageTypes.OOC);
                case 0x000b: return new Usage(this, id, "High Cut Filter", UsageTypes.OOC);
                case 0x000c: return new Usage(this, id, "Low Cut Filter", UsageTypes.OOC);
                case 0x000d: return new Usage(this, id, "Equalizer Enable", UsageTypes.OOC);
                case 0x000e: return new Usage(this, id, "Sound Field On", UsageTypes.OOC);
                case 0x000f: return new Usage(this, id, "Surround On", UsageTypes.OOC);
                case 0x0010: return new Usage(this, id, "Repeat", UsageTypes.OOC);
                case 0x0011: return new Usage(this, id, "Stereo", UsageTypes.OOC);
                case 0x0012: return new Usage(this, id, "Sampling Rate Detect", UsageTypes.OOC);
                case 0x0013: return new Usage(this, id, "Spinning", UsageTypes.OOC);
                case 0x0014: return new Usage(this, id, "CAV", UsageTypes.OOC);
                case 0x0015: return new Usage(this, id, "CLV", UsageTypes.OOC);
                case 0x0016: return new Usage(this, id, "Recording Format Detect", UsageTypes.OOC);
                case 0x0017: return new Usage(this, id, "Off-Hook", UsageTypes.OOC);
                case 0x0018: return new Usage(this, id, "Ring", UsageTypes.OOC);
                case 0x0019: return new Usage(this, id, "Message Waiting", UsageTypes.OOC);
                case 0x001a: return new Usage(this, id, "Data Mode", UsageTypes.OOC);
                case 0x001b: return new Usage(this, id, "Battery Operation", UsageTypes.OOC);
                case 0x001c: return new Usage(this, id, "Battery OK", UsageTypes.OOC);
                case 0x001d: return new Usage(this, id, "Battery Low", UsageTypes.OOC);
                case 0x001e: return new Usage(this, id, "Speaker", UsageTypes.OOC);
                case 0x001f: return new Usage(this, id, "Head Set", UsageTypes.OOC);
                case 0x0020: return new Usage(this, id, "Hold", UsageTypes.OOC);
                case 0x0021: return new Usage(this, id, "Microphone", UsageTypes.OOC);
                case 0x0022: return new Usage(this, id, "Coverage", UsageTypes.OOC);
                case 0x0023: return new Usage(this, id, "Night Mode", UsageTypes.OOC);
                case 0x0024: return new Usage(this, id, "Send Calls", UsageTypes.OOC);
                case 0x0025: return new Usage(this, id, "Call Pickup", UsageTypes.OOC);
                case 0x0026: return new Usage(this, id, "Conference", UsageTypes.OOC);
                case 0x0027: return new Usage(this, id, "Stand-by", UsageTypes.OOC);
                case 0x0028: return new Usage(this, id, "Camera On", UsageTypes.OOC);
                case 0x0029: return new Usage(this, id, "Camera Off", UsageTypes.OOC);
                case 0x002a: return new Usage(this, id, "On-Line", UsageTypes.OOC);
                case 0x002b: return new Usage(this, id, "Off-Line", UsageTypes.OOC);
                case 0x002c: return new Usage(this, id, "Busy", UsageTypes.OOC);
                case 0x002d: return new Usage(this, id, "Ready", UsageTypes.OOC);
                case 0x002e: return new Usage(this, id, "Paper-Out", UsageTypes.OOC);
                case 0x002f: return new Usage(this, id, "Paper-Jam", UsageTypes.OOC);
                case 0x0030: return new Usage(this, id, "Remote", UsageTypes.OOC);
                case 0x0031: return new Usage(this, id, "Forward", UsageTypes.OOC);
                case 0x0032: return new Usage(this, id, "Reverse", UsageTypes.OOC);
                case 0x0033: return new Usage(this, id, "Stop", UsageTypes.OOC);
                case 0x0034: return new Usage(this, id, "Rewind", UsageTypes.OOC);
                case 0x0035: return new Usage(this, id, "Fast Forward", UsageTypes.OOC);
                case 0x0036: return new Usage(this, id, "Play", UsageTypes.OOC);
                case 0x0037: return new Usage(this, id, "Pause", UsageTypes.OOC);
                case 0x0038: return new Usage(this, id, "Record", UsageTypes.OOC);
                case 0x0039: return new Usage(this, id, "Error", UsageTypes.OOC);
                case 0x003a: return new Usage(this, id, "Usage Selected Indicator", UsageTypes.US);
                case 0x003b: return new Usage(this, id, "Usage In Use Indicator", UsageTypes.US);
                case 0x003c: return new Usage(this, id, "Usage Multi Mode Indicator", UsageTypes.UM);
                case 0x003d: return new Usage(this, id, "Indicator On", UsageTypes.Sel);
                case 0x003e: return new Usage(this, id, "Indicator Flash", UsageTypes.Sel);
                case 0x003f: return new Usage(this, id, "Indicator Slow Blink", UsageTypes.Sel);
                case 0x0040: return new Usage(this, id, "Indicator Fast Blink", UsageTypes.Sel);
                case 0x0041: return new Usage(this, id, "Indicator Off", UsageTypes.Sel);
                case 0x0042: return new Usage(this, id, "Flash On Time", UsageTypes.DV);
                case 0x0043: return new Usage(this, id, "Slow Blink On Time", UsageTypes.DV);
                case 0x0044: return new Usage(this, id, "Slow Blink Off Time", UsageTypes.DV);
                case 0x0045: return new Usage(this, id, "Fast Blink On Time", UsageTypes.DV);
                case 0x0046: return new Usage(this, id, "Fast Blink Off Time", UsageTypes.DV);
                case 0x0047: return new Usage(this, id, "Usage Indicator Color", UsageTypes.UM);
                case 0x0048: return new Usage(this, id, "Indicator Red", UsageTypes.Sel);
                case 0x0049: return new Usage(this, id, "Indicator Green", UsageTypes.Sel);
                case 0x004a: return new Usage(this, id, "Indicator Amber", UsageTypes.Sel);
                case 0x004b: return new Usage(this, id, "Generic Indicator", UsageTypes.OOC);
                case 0x004c: return new Usage(this, id, "System Suspend", UsageTypes.OOC);
                case 0x004d: return new Usage(this, id, "External Power Connected", UsageTypes.OOC);
                case 0x004e: return new Usage(this, id, "Indicator Blue", UsageTypes.Sel);
                case 0x004f: return new Usage(this, id, "Indicator Orange", UsageTypes.Sel);
                case 0x0050: return new Usage(this, id, "Good Status", UsageTypes.OOC);
                case 0x0051: return new Usage(this, id, "Warning Status", UsageTypes.OOC);
                case 0x0052: return new Usage(this, id, "RGB LED", UsageTypes.CL);
                case 0x0053: return new Usage(this, id, "Red LED Channel", UsageTypes.DV);
                case 0x0054: return new Usage(this, id, "Green LED Channel", UsageTypes.DV);
                case 0x0055: return new Usage(this, id, "Blue LED Channel", UsageTypes.DV);
                case 0x0056: return new Usage(this, id, "LED Intensity", UsageTypes.DV);
                case 0x0060: return new Usage(this, id, "Player Indicator", UsageTypes.NAry);
                case 0x0061: return new Usage(this, id, "Player 1", UsageTypes.Sel);
                case 0x0062: return new Usage(this, id, "Player 2", UsageTypes.Sel);
                case 0x0063: return new Usage(this, id, "Player 3", UsageTypes.Sel);
                case 0x0064: return new Usage(this, id, "Player 4", UsageTypes.Sel);
                case 0x0065: return new Usage(this, id, "Player 5", UsageTypes.Sel);
                case 0x0066: return new Usage(this, id, "Player 6", UsageTypes.Sel);
                case 0x0067: return new Usage(this, id, "Player 7", UsageTypes.Sel);
                case 0x0068: return new Usage(this, id, "Player 8", UsageTypes.Sel);
            }

            return base.CreateUsage(id);
        }
    }

    /// <summary>
    ///     Base class for all usage pages.
    /// </summary>
    public sealed class ButtonUsagePage : UsagePage
    {
        /// <summary>
        ///     Singleton instance of Button Usage Page.
        /// </summary>
        public static readonly ButtonUsagePage Instance = new ButtonUsagePage();

        private ButtonUsagePage() : base(0x0009, "Button")
        {
        }

        /// <inheritdoc />
        protected override Usage CreateUsage(ushort id) 
        {
            switch (id)
            {
                case 0x0000: return new Usage(this, id, "No button pressed", UsageTypes.Sel);
                case 0x0001: return new Usage(this, id, "Button 1", UsageTypes.Sel|UsageTypes.OOC|UsageTypes.MC|UsageTypes.OSC);
                case 0x0002: return new Usage(this, id, "Button 2", UsageTypes.Sel|UsageTypes.OOC|UsageTypes.MC|UsageTypes.OSC);
                case 0x0003: return new Usage(this, id, "Button 3", UsageTypes.Sel|UsageTypes.OOC|UsageTypes.MC|UsageTypes.OSC);
                case 0x0004: return new Usage(this, id, "Button 4", UsageTypes.Sel|UsageTypes.OOC|UsageTypes.MC|UsageTypes.OSC);
                case 0x0005: return new Usage(this, id, "Button 5", UsageTypes.Sel|UsageTypes.OOC|UsageTypes.MC|UsageTypes.OSC);
                case 0x0006: return new Usage(this, id, "Button 6", UsageTypes.Sel|UsageTypes.OOC|UsageTypes.MC|UsageTypes.OSC);
                case 0x0007: return new Usage(this, id, "Button 7", UsageTypes.Sel|UsageTypes.OOC|UsageTypes.MC|UsageTypes.OSC);
                case 0x0008: return new Usage(this, id, "Button 8", UsageTypes.Sel|UsageTypes.OOC|UsageTypes.MC|UsageTypes.OSC);
                case 0x0009: return new Usage(this, id, "Button 9", UsageTypes.Sel|UsageTypes.OOC|UsageTypes.MC|UsageTypes.OSC);
                case 0x000a: return new Usage(this, id, "Button 10", UsageTypes.Sel|UsageTypes.OOC|UsageTypes.MC|UsageTypes.OSC);
                case 0x000b: return new Usage(this, id, "Button 11", UsageTypes.Sel|UsageTypes.OOC|UsageTypes.MC|UsageTypes.OSC);
                case 0x000c: return new Usage(this, id, "Button 12", UsageTypes.Sel|UsageTypes.OOC|UsageTypes.MC|UsageTypes.OSC);
                case 0x000d: return new Usage(this, id, "Button 13", UsageTypes.Sel|UsageTypes.OOC|UsageTypes.MC|UsageTypes.OSC);
                case 0x000e: return new Usage(this, id, "Button 14", UsageTypes.Sel|UsageTypes.OOC|UsageTypes.MC|UsageTypes.OSC);
                case 0x000f: return new Usage(this, id, "Button 15", UsageTypes.Sel|UsageTypes.OOC|UsageTypes.MC|UsageTypes.OSC);
                case 0x0010: return new Usage(this, id, "Button 16", UsageTypes.Sel|UsageTypes.OOC|UsageTypes.MC|UsageTypes.OSC);
            }

            // Create dynamic usages from ranges
            var n = (ushort)(id-0x0001);
            if (id >= 0x0001 || id < 0xffff) return new Usage(this, id, $"Button {n+1}", UsageTypes.Sel|UsageTypes.OOC|UsageTypes.MC|UsageTypes.OSC);

            return base.CreateUsage(id);
        }
    }

    /// <summary>
    ///     Base class for all usage pages.
    /// </summary>
    public sealed class OrdinalUsagePage : UsagePage
    {
        /// <summary>
        ///     Singleton instance of Ordinal Usage Page.
        /// </summary>
        public static readonly OrdinalUsagePage Instance = new OrdinalUsagePage();

        private OrdinalUsagePage() : base(0x000a, "Ordinal")
        {
        }

        /// <inheritdoc />
        protected override Usage CreateUsage(ushort id) 
        {
            switch (id)
            {
                case 0x0000: return new Usage(this, id, "Undefined", UsageTypes.None);
                case 0x0001: return new Usage(this, id, "Instance 1", UsageTypes.UM);
                case 0x0002: return new Usage(this, id, "Instance 2", UsageTypes.UM);
                case 0x0003: return new Usage(this, id, "Instance 3", UsageTypes.UM);
                case 0x0004: return new Usage(this, id, "Instance 4", UsageTypes.UM);
                case 0x0005: return new Usage(this, id, "Instance 5", UsageTypes.UM);
                case 0x0006: return new Usage(this, id, "Instance 6", UsageTypes.UM);
                case 0x0007: return new Usage(this, id, "Instance 7", UsageTypes.UM);
                case 0x0008: return new Usage(this, id, "Instance 8", UsageTypes.UM);
                case 0x0009: return new Usage(this, id, "Instance 9", UsageTypes.UM);
                case 0x000a: return new Usage(this, id, "Instance 10", UsageTypes.UM);
                case 0x000b: return new Usage(this, id, "Instance 11", UsageTypes.UM);
                case 0x000c: return new Usage(this, id, "Instance 12", UsageTypes.UM);
                case 0x000d: return new Usage(this, id, "Instance 13", UsageTypes.UM);
                case 0x000e: return new Usage(this, id, "Instance 14", UsageTypes.UM);
                case 0x000f: return new Usage(this, id, "Instance 15", UsageTypes.UM);
                case 0x0010: return new Usage(this, id, "Instance 16", UsageTypes.UM);
            }

            // Create dynamic usages from ranges
            var n = (ushort)(id-0x0001);
            if (id >= 0x0001 || id < 0xffff) return new Usage(this, id, $"Instance {n+1}", UsageTypes.UM);

            return base.CreateUsage(id);
        }
    }

    /// <summary>
    ///     Base class for all usage pages.
    /// </summary>
    public sealed class TelephonyUsagePage : UsagePage
    {
        /// <summary>
        ///     Singleton instance of Telephony Usage Page.
        /// </summary>
        public static readonly TelephonyUsagePage Instance = new TelephonyUsagePage();

        private TelephonyUsagePage() : base(0x000b, "Telephony")
        {
        }

        /// <inheritdoc />
        protected override Usage CreateUsage(ushort id) 
        {
            switch (id)
            {
                case 0x0000: return new Usage(this, id, "Undefined", UsageTypes.None);
                case 0x0001: return new Usage(this, id, "Phone", UsageTypes.CA);
                case 0x0002: return new Usage(this, id, "Answering Machine", UsageTypes.CA);
                case 0x0003: return new Usage(this, id, "Message Controls", UsageTypes.CL);
                case 0x0004: return new Usage(this, id, "Handset", UsageTypes.CL);
                case 0x0005: return new Usage(this, id, "Headset", UsageTypes.CL);
                case 0x0006: return new Usage(this, id, "Telephony Key Pad", UsageTypes.NAry);
                case 0x0007: return new Usage(this, id, "Programmable Button", UsageTypes.NAry);
                case 0x0020: return new Usage(this, id, "Hook Switch", UsageTypes.OOC);
                case 0x0021: return new Usage(this, id, "Flash", UsageTypes.MC);
                case 0x0022: return new Usage(this, id, "Feature", UsageTypes.OSC);
                case 0x0023: return new Usage(this, id, "Hold", UsageTypes.OOC);
                case 0x0024: return new Usage(this, id, "Redial", UsageTypes.OSC);
                case 0x0025: return new Usage(this, id, "Transfer", UsageTypes.OSC);
                case 0x0026: return new Usage(this, id, "Drop", UsageTypes.OSC);
                case 0x0027: return new Usage(this, id, "Park", UsageTypes.OOC);
                case 0x0028: return new Usage(this, id, "Forward Calls", UsageTypes.OOC);
                case 0x0029: return new Usage(this, id, "Alternate  Function", UsageTypes.MC);
                case 0x002a: return new Usage(this, id, "Line", UsageTypes.OSC|UsageTypes.NAry);
                case 0x002b: return new Usage(this, id, "Speaker Phone", UsageTypes.OOC);
                case 0x002c: return new Usage(this, id, "Conference", UsageTypes.OOC);
                case 0x002d: return new Usage(this, id, "Ring Enable", UsageTypes.OOC);
                case 0x002e: return new Usage(this, id, "Ring Select", UsageTypes.OSC);
                case 0x002f: return new Usage(this, id, "Phone Mute", UsageTypes.OOC);
                case 0x0030: return new Usage(this, id, "Caller ID", UsageTypes.MC);
                case 0x0050: return new Usage(this, id, "Speed Dial", UsageTypes.OSC);
                case 0x0051: return new Usage(this, id, "Store Number", UsageTypes.OSC);
                case 0x0052: return new Usage(this, id, "Recall Number", UsageTypes.OSC);
                case 0x0053: return new Usage(this, id, "Phone Directory", UsageTypes.OOC);
                case 0x0070: return new Usage(this, id, "Voice Mail", UsageTypes.OOC);
                case 0x0071: return new Usage(this, id, "Screen Calls", UsageTypes.OOC);
                case 0x0072: return new Usage(this, id, "Do Not Disturb", UsageTypes.OOC);
                case 0x0073: return new Usage(this, id, "Message", UsageTypes.OSC);
                case 0x0074: return new Usage(this, id, "Answer On/Off", UsageTypes.OOC);
                case 0x0090: return new Usage(this, id, "Inside Dial Tone", UsageTypes.MC);
                case 0x0091: return new Usage(this, id, "Outside Dial Tone", UsageTypes.MC);
                case 0x0092: return new Usage(this, id, "Inside Ring Tone", UsageTypes.MC);
                case 0x0093: return new Usage(this, id, "Outside Ring Tone", UsageTypes.MC);
                case 0x0094: return new Usage(this, id, "Priority Ring Tone", UsageTypes.MC);
                case 0x0095: return new Usage(this, id, "Inside Ringback", UsageTypes.MC);
                case 0x0096: return new Usage(this, id, "Priority Ringback", UsageTypes.MC);
                case 0x0097: return new Usage(this, id, "Line Busy Tone", UsageTypes.MC);
                case 0x0098: return new Usage(this, id, "Reorder Tone", UsageTypes.MC);
                case 0x0099: return new Usage(this, id, "Call Waiting Tone", UsageTypes.MC);
                case 0x009a: return new Usage(this, id, "Confirmation Tone 1", UsageTypes.MC);
                case 0x009b: return new Usage(this, id, "Confirmation Tone 2", UsageTypes.MC);
                case 0x009c: return new Usage(this, id, "Tones Off", UsageTypes.OOC);
                case 0x009d: return new Usage(this, id, "Outside Ringback", UsageTypes.MC);
                case 0x009e: return new Usage(this, id, "Ringer", UsageTypes.OOC);
                case 0x00b0: return new Usage(this, id, "Phone Key 0", UsageTypes.Sel);
                case 0x00b1: return new Usage(this, id, "Phone Key 1", UsageTypes.Sel);
                case 0x00b2: return new Usage(this, id, "Phone Key 2", UsageTypes.Sel);
                case 0x00b3: return new Usage(this, id, "Phone Key 3", UsageTypes.Sel);
                case 0x00b4: return new Usage(this, id, "Phone Key 4", UsageTypes.Sel);
                case 0x00b5: return new Usage(this, id, "Phone Key 5", UsageTypes.Sel);
                case 0x00b6: return new Usage(this, id, "Phone Key 6", UsageTypes.Sel);
                case 0x00b7: return new Usage(this, id, "Phone Key 7", UsageTypes.Sel);
                case 0x00b8: return new Usage(this, id, "Phone Key 8", UsageTypes.Sel);
                case 0x00b9: return new Usage(this, id, "Phone Key 9", UsageTypes.Sel);
                case 0x00ba: return new Usage(this, id, "Phone Key Star", UsageTypes.Sel);
                case 0x00bb: return new Usage(this, id, "Phone Key Pound", UsageTypes.Sel);
                case 0x00bc: return new Usage(this, id, "Phone Key A", UsageTypes.Sel);
                case 0x00bd: return new Usage(this, id, "Phone Key B", UsageTypes.Sel);
                case 0x00be: return new Usage(this, id, "Phone Key C", UsageTypes.Sel);
                case 0x00bf: return new Usage(this, id, "Phone Key D", UsageTypes.Sel);
                case 0x00c0: return new Usage(this, id, "Phone Key Call History", UsageTypes.Sel);
                case 0x00c1: return new Usage(this, id, "Phone Key Caller ID", UsageTypes.Sel);
                case 0x00c2: return new Usage(this, id, "Phone Key Settings", UsageTypes.Sel);
                case 0x00f0: return new Usage(this, id, "Host Control", UsageTypes.OOC);
                case 0x00f1: return new Usage(this, id, "Host Available", UsageTypes.OOC);
                case 0x00f2: return new Usage(this, id, "Host Call Active", UsageTypes.OOC);
                case 0x00f3: return new Usage(this, id, "Activate Handset Audio", UsageTypes.OOC);
                case 0x00f4: return new Usage(this, id, "Ring Type", UsageTypes.NAry);
                case 0x00f5: return new Usage(this, id, "Re-dialable Phone Number", UsageTypes.OOC);
                case 0x00f8: return new Usage(this, id, "Stop Ring Tone", UsageTypes.Sel);
                case 0x00f9: return new Usage(this, id, "PSTN Ring Tone", UsageTypes.Sel);
                case 0x00fa: return new Usage(this, id, "Host Ring Tone", UsageTypes.Sel);
                case 0x00fb: return new Usage(this, id, "Alert Sound Error", UsageTypes.Sel);
                case 0x00fc: return new Usage(this, id, "Alert Sound Confirm", UsageTypes.Sel);
                case 0x00fd: return new Usage(this, id, "Alert Sound Notification", UsageTypes.Sel);
                case 0x00fe: return new Usage(this, id, "Silent Ring", UsageTypes.Sel);
                case 0x0108: return new Usage(this, id, "Email Message Waiting", UsageTypes.OOC);
                case 0x0109: return new Usage(this, id, "Voicemail Message Waiting", UsageTypes.OOC);
                case 0x010a: return new Usage(this, id, "Host Hold", UsageTypes.OOC);
                case 0x0110: return new Usage(this, id, "Incoming Call History Count", UsageTypes.DV);
                case 0x0111: return new Usage(this, id, "Outgoing Call History Count", UsageTypes.DV);
                case 0x0112: return new Usage(this, id, "Incoming Call History", UsageTypes.CL);
                case 0x0113: return new Usage(this, id, "Outgoing Call History", UsageTypes.CL);
                case 0x0114: return new Usage(this, id, "Phone Locale", UsageTypes.DV);
                case 0x0140: return new Usage(this, id, "Phone Time Second", UsageTypes.DV);
                case 0x0141: return new Usage(this, id, "Phone Time Minute", UsageTypes.DV);
                case 0x0142: return new Usage(this, id, "Phone Time Hour", UsageTypes.DV);
                case 0x0143: return new Usage(this, id, "Phone Time Day", UsageTypes.DV);
                case 0x0144: return new Usage(this, id, "Phone Time Month", UsageTypes.DV);
                case 0x0145: return new Usage(this, id, "Phone Time Year", UsageTypes.DV);
                case 0x0146: return new Usage(this, id, "Handset Nickname", UsageTypes.DV);
                case 0x0147: return new Usage(this, id, "Address Book ID", UsageTypes.DV);
                case 0x014a: return new Usage(this, id, "Call Duration", UsageTypes.DV);
                case 0x014b: return new Usage(this, id, "Dual Mode Phone", UsageTypes.CA);
            }

            return base.CreateUsage(id);
        }
    }

    /// <summary>
    ///     Base class for all usage pages.
    /// </summary>
    public sealed class ConsumerUsagePage : UsagePage
    {
        /// <summary>
        ///     Singleton instance of Consumer Usage Page.
        /// </summary>
        public static readonly ConsumerUsagePage Instance = new ConsumerUsagePage();

        private ConsumerUsagePage() : base(0x000c, "Consumer")
        {
        }

        /// <inheritdoc />
        protected override Usage CreateUsage(ushort id) 
        {
            switch (id)
            {
                case 0x0000: return new Usage(this, id, "Undefined", UsageTypes.None);
                case 0x0001: return new Usage(this, id, "Consumer Control", UsageTypes.CA);
                case 0x0002: return new Usage(this, id, "Numeric Key Pad", UsageTypes.NAry);
                case 0x0003: return new Usage(this, id, "Programmable Buttons", UsageTypes.NAry);
                case 0x0004: return new Usage(this, id, "Microphone", UsageTypes.CA);
                case 0x0005: return new Usage(this, id, "Headphone", UsageTypes.CA);
                case 0x0006: return new Usage(this, id, "Graphic Equalizer", UsageTypes.CA);
                case 0x0020: return new Usage(this, id, "+10", UsageTypes.OSC);
                case 0x0021: return new Usage(this, id, "+100", UsageTypes.OSC);
                case 0x0022: return new Usage(this, id, "AM/PM", UsageTypes.OSC);
                case 0x0030: return new Usage(this, id, "Power", UsageTypes.OOC);
                case 0x0031: return new Usage(this, id, "Reset", UsageTypes.OSC);
                case 0x0032: return new Usage(this, id, "Sleep", UsageTypes.OSC);
                case 0x0033: return new Usage(this, id, "Sleep After", UsageTypes.OSC);
                case 0x0034: return new Usage(this, id, "Sleep Mode", UsageTypes.RTC);
                case 0x0035: return new Usage(this, id, "Illumination", UsageTypes.OOC);
                case 0x0036: return new Usage(this, id, "Function Buttons", UsageTypes.NAry);
                case 0x0040: return new Usage(this, id, "Menu", UsageTypes.OOC);
                case 0x0041: return new Usage(this, id, "Menu Pick", UsageTypes.OSC);
                case 0x0042: return new Usage(this, id, "Menu Up", UsageTypes.OSC);
                case 0x0043: return new Usage(this, id, "Menu Down", UsageTypes.OSC);
                case 0x0044: return new Usage(this, id, "Menu Left", UsageTypes.OSC);
                case 0x0045: return new Usage(this, id, "Menu Right", UsageTypes.OSC);
                case 0x0046: return new Usage(this, id, "Menu Escape", UsageTypes.OSC);
                case 0x0047: return new Usage(this, id, "Menu Value Increase", UsageTypes.OSC);
                case 0x0048: return new Usage(this, id, "Menu Value Decrease", UsageTypes.OSC);
                case 0x0060: return new Usage(this, id, "Data On Screen", UsageTypes.OOC);
                case 0x0061: return new Usage(this, id, "Closed Caption", UsageTypes.OOC);
                case 0x0062: return new Usage(this, id, "Closed Caption Select", UsageTypes.OSC);
                case 0x0063: return new Usage(this, id, "VCR/TV", UsageTypes.OOC);
                case 0x0064: return new Usage(this, id, "Broadcast Mode", UsageTypes.OSC);
                case 0x0065: return new Usage(this, id, "Snapshot", UsageTypes.OSC);
                case 0x0066: return new Usage(this, id, "Still", UsageTypes.OSC);
                case 0x0067: return new Usage(this, id, "Picture-in-Picture Toggle", UsageTypes.OSC);
                case 0x0068: return new Usage(this, id, "Picture-in-Picture Swap", UsageTypes.OSC);
                case 0x0069: return new Usage(this, id, "Red Menu Button", UsageTypes.MC);
                case 0x006a: return new Usage(this, id, "Green Menu Button", UsageTypes.MC);
                case 0x006b: return new Usage(this, id, "Blue Menu Button", UsageTypes.MC);
                case 0x006c: return new Usage(this, id, "Yellow Menu Button", UsageTypes.MC);
                case 0x006d: return new Usage(this, id, "Aspect", UsageTypes.OSC);
                case 0x006e: return new Usage(this, id, "3D Mode Select", UsageTypes.OSC);
                case 0x006f: return new Usage(this, id, "Display Brightness Increment", UsageTypes.RTC);
                case 0x0070: return new Usage(this, id, "Display Brightness Decrement", UsageTypes.RTC);
                case 0x0071: return new Usage(this, id, "Display Brightness", UsageTypes.LC);
                case 0x0072: return new Usage(this, id, "Display Backlight Toggle", UsageTypes.OOC);
                case 0x0073: return new Usage(this, id, "Display Set Brightness to Minimum", UsageTypes.OSC);
                case 0x0074: return new Usage(this, id, "Display Set Brightness to Maximum", UsageTypes.OSC);
                case 0x0075: return new Usage(this, id, "Display Set Auto Brightness", UsageTypes.OOC);
                case 0x0076: return new Usage(this, id, "Camera Access Enabled", UsageTypes.OOC);
                case 0x0077: return new Usage(this, id, "Camera Access Disabled", UsageTypes.OOC);
                case 0x0078: return new Usage(this, id, "Camera Access Toggle", UsageTypes.OOC);
                case 0x0079: return new Usage(this, id, "Keyboard Brightness Increment", UsageTypes.OSC);
                case 0x007a: return new Usage(this, id, "Keyboard Brightness Decrement", UsageTypes.OSC);
                case 0x007b: return new Usage(this, id, "Keyboard Backlight Set Level", UsageTypes.LC);
                case 0x007c: return new Usage(this, id, "Keyboard Backlight Toggle", UsageTypes.OOC);
                case 0x007d: return new Usage(this, id, "Keyboard Backlight Set Minimum", UsageTypes.OSC);
                case 0x007e: return new Usage(this, id, "Keyboard Backlight Set Maximum", UsageTypes.OSC);
                case 0x007f: return new Usage(this, id, "Keyboard Backlight Auto", UsageTypes.OOC);
                case 0x0080: return new Usage(this, id, "Selection", UsageTypes.NAry);
                case 0x0081: return new Usage(this, id, "Assign Selection", UsageTypes.OSC);
                case 0x0082: return new Usage(this, id, "Mode Step", UsageTypes.OSC);
                case 0x0083: return new Usage(this, id, "Recall Last", UsageTypes.OSC);
                case 0x0084: return new Usage(this, id, "Enter Channel", UsageTypes.OSC);
                case 0x0085: return new Usage(this, id, "Order Movie", UsageTypes.OSC);
                case 0x0086: return new Usage(this, id, "Channel", UsageTypes.LC);
                case 0x0087: return new Usage(this, id, "Media Selection", UsageTypes.NAry);
                case 0x0088: return new Usage(this, id, "Media Select ", UsageTypes.Sel);
                case 0x0089: return new Usage(this, id, "Media Select TV", UsageTypes.Sel);
                case 0x008a: return new Usage(this, id, "Media Select WWW", UsageTypes.Sel);
                case 0x008b: return new Usage(this, id, "Media Select DVD", UsageTypes.Sel);
                case 0x008c: return new Usage(this, id, "Media Select Telephone", UsageTypes.Sel);
                case 0x008d: return new Usage(this, id, "Media Select Program Guide", UsageTypes.Sel);
                case 0x008e: return new Usage(this, id, "Media Select Video Phone", UsageTypes.Sel);
                case 0x008f: return new Usage(this, id, "Media Select Games", UsageTypes.Sel);
                case 0x0090: return new Usage(this, id, "Media Select Messages", UsageTypes.Sel);
                case 0x0091: return new Usage(this, id, "Media Select CD", UsageTypes.Sel);
                case 0x0092: return new Usage(this, id, "Media Select VCR", UsageTypes.Sel);
                case 0x0093: return new Usage(this, id, "Media Select Tuner", UsageTypes.Sel);
                case 0x0094: return new Usage(this, id, "Quit", UsageTypes.OSC);
                case 0x0095: return new Usage(this, id, "Help", UsageTypes.OOC);
                case 0x0096: return new Usage(this, id, "Media Select Tape", UsageTypes.Sel);
                case 0x0097: return new Usage(this, id, "Media Select Cable", UsageTypes.Sel);
                case 0x0098: return new Usage(this, id, "Media Select Satellite", UsageTypes.Sel);
                case 0x0099: return new Usage(this, id, "Media Select Security", UsageTypes.Sel);
                case 0x009a: return new Usage(this, id, "Media Select Home", UsageTypes.Sel);
                case 0x009b: return new Usage(this, id, "Media Select Call", UsageTypes.Sel);
                case 0x009c: return new Usage(this, id, "Channel Increment", UsageTypes.OSC);
                case 0x009d: return new Usage(this, id, "Channel Decrement", UsageTypes.OSC);
                case 0x009e: return new Usage(this, id, "Media Select SAP", UsageTypes.Sel);
                case 0x00a0: return new Usage(this, id, "VCR Plus", UsageTypes.OSC);
                case 0x00a1: return new Usage(this, id, "Once", UsageTypes.OSC);
                case 0x00a2: return new Usage(this, id, "Daily", UsageTypes.OSC);
                case 0x00a3: return new Usage(this, id, "Weekly", UsageTypes.OSC);
                case 0x00a4: return new Usage(this, id, "Monthly", UsageTypes.OSC);
                case 0x00b0: return new Usage(this, id, "Play", UsageTypes.OOC);
                case 0x00b1: return new Usage(this, id, "Pause", UsageTypes.OOC);
                case 0x00b2: return new Usage(this, id, "Record", UsageTypes.OOC);
                case 0x00b3: return new Usage(this, id, "Fast Forward", UsageTypes.OOC);
                case 0x00b4: return new Usage(this, id, "Rewind", UsageTypes.OOC);
                case 0x00b5: return new Usage(this, id, "Scan Next Track", UsageTypes.OSC);
                case 0x00b6: return new Usage(this, id, "Scan Previous Track", UsageTypes.OSC);
                case 0x00b7: return new Usage(this, id, "Stop", UsageTypes.OSC);
                case 0x00b8: return new Usage(this, id, "Eject", UsageTypes.OSC);
                case 0x00b9: return new Usage(this, id, "Random Play", UsageTypes.OOC);
                case 0x00ba: return new Usage(this, id, "Select Disk", UsageTypes.NAry);
                case 0x00bb: return new Usage(this, id, "Enter Disk", UsageTypes.MC);
                case 0x00bc: return new Usage(this, id, "Repeat", UsageTypes.OSC);
                case 0x00bd: return new Usage(this, id, "Tracking", UsageTypes.LC);
                case 0x00be: return new Usage(this, id, "Track Normal", UsageTypes.OSC);
                case 0x00bf: return new Usage(this, id, "Slow Tracking", UsageTypes.LC);
                case 0x00c0: return new Usage(this, id, "Frame Forward", UsageTypes.RTC);
                case 0x00c1: return new Usage(this, id, "Frame Back", UsageTypes.RTC);
                case 0x00c2: return new Usage(this, id, "Mark", UsageTypes.OSC);
                case 0x00c3: return new Usage(this, id, "Clear Mark", UsageTypes.OSC);
                case 0x00c4: return new Usage(this, id, "Repeat From Mark", UsageTypes.OOC);
                case 0x00c5: return new Usage(this, id, "Return To Mark", UsageTypes.OSC);
                case 0x00c6: return new Usage(this, id, "Search Mark Forward", UsageTypes.OSC);
                case 0x00c7: return new Usage(this, id, "Search Mark Backwards", UsageTypes.OSC);
                case 0x00c8: return new Usage(this, id, "Counter Reset", UsageTypes.OSC);
                case 0x00c9: return new Usage(this, id, "Show Counter", UsageTypes.OSC);
                case 0x00ca: return new Usage(this, id, "Tracking Increment", UsageTypes.RTC);
                case 0x00cb: return new Usage(this, id, "Tracking Decrement", UsageTypes.RTC);
                case 0x00cc: return new Usage(this, id, "Stop/Eject", UsageTypes.OSC);
                case 0x00cd: return new Usage(this, id, "Play/Pause", UsageTypes.OSC);
                case 0x00ce: return new Usage(this, id, "Play/Skip", UsageTypes.OSC);
                case 0x00cf: return new Usage(this, id, "Voice Command", UsageTypes.OSC);
                case 0x00d0: return new Usage(this, id, "Invoke Capture Interface", UsageTypes.OSC);
                case 0x00d1: return new Usage(this, id, "Start/Stop Game Recording", UsageTypes.OSC);
                case 0x00d2: return new Usage(this, id, "Historical Game Capture", UsageTypes.OSC);
                case 0x00d3: return new Usage(this, id, "Capture Game Screenshot", UsageTypes.OSC);
                case 0x00d4: return new Usage(this, id, "Show/Hide Recording Indicator", UsageTypes.OSC);
                case 0x00d5: return new Usage(this, id, "Start/Stop Microphone Capture", UsageTypes.OSC);
                case 0x00d6: return new Usage(this, id, "Start or Stop Camera Capture", UsageTypes.OSC);
                case 0x00d7: return new Usage(this, id, "Start/Stop Game Broadcast", UsageTypes.OSC);
                case 0x00e0: return new Usage(this, id, "Volume", UsageTypes.LC);
                case 0x00e1: return new Usage(this, id, "Balance", UsageTypes.LC);
                case 0x00e2: return new Usage(this, id, "Mute", UsageTypes.OOC);
                case 0x00e3: return new Usage(this, id, "Bass", UsageTypes.LC);
                case 0x00e4: return new Usage(this, id, "Treble", UsageTypes.LC);
                case 0x00e5: return new Usage(this, id, "Bass Boost", UsageTypes.OOC);
                case 0x00e6: return new Usage(this, id, "Surround Mode", UsageTypes.OSC);
                case 0x00e7: return new Usage(this, id, "Loudness", UsageTypes.OOC);
                case 0x00e8: return new Usage(this, id, "MPX", UsageTypes.OOC);
                case 0x00e9: return new Usage(this, id, "Volume Increment", UsageTypes.RTC);
                case 0x00ea: return new Usage(this, id, "Volume Decrement", UsageTypes.RTC);
                case 0x00f0: return new Usage(this, id, "Speed Select", UsageTypes.OSC);
                case 0x00f1: return new Usage(this, id, "Playback Speed", UsageTypes.NAry);
                case 0x00f2: return new Usage(this, id, "Standard Play", UsageTypes.Sel);
                case 0x00f3: return new Usage(this, id, "Long Play", UsageTypes.Sel);
                case 0x00f4: return new Usage(this, id, "Extended Play", UsageTypes.Sel);
                case 0x00f5: return new Usage(this, id, "Slow", UsageTypes.OSC);
                case 0x0100: return new Usage(this, id, "Fan Enable", UsageTypes.OOC);
                case 0x0101: return new Usage(this, id, "Fan Speed", UsageTypes.LC);
                case 0x0102: return new Usage(this, id, "Light Enable", UsageTypes.OOC);
                case 0x0103: return new Usage(this, id, "Light Illumination Level", UsageTypes.LC);
                case 0x0104: return new Usage(this, id, "Climate Control Enable", UsageTypes.OOC);
                case 0x0105: return new Usage(this, id, "Room Temperature", UsageTypes.LC);
                case 0x0106: return new Usage(this, id, "Security Enable", UsageTypes.OOC);
                case 0x0107: return new Usage(this, id, "Fire Alarm", UsageTypes.OSC);
                case 0x0108: return new Usage(this, id, "Police Alarm", UsageTypes.OSC);
                case 0x0109: return new Usage(this, id, "Proximity", UsageTypes.LC);
                case 0x010a: return new Usage(this, id, "Motion", UsageTypes.OSC);
                case 0x010b: return new Usage(this, id, "Duress Alarm", UsageTypes.OSC);
                case 0x010c: return new Usage(this, id, "Holdup Alarm", UsageTypes.OSC);
                case 0x010d: return new Usage(this, id, "Medical Alarm", UsageTypes.OSC);
                case 0x0150: return new Usage(this, id, "Balance Right", UsageTypes.RTC);
                case 0x0151: return new Usage(this, id, "Balance Left", UsageTypes.RTC);
                case 0x0152: return new Usage(this, id, "Bass Increment", UsageTypes.RTC);
                case 0x0153: return new Usage(this, id, "Bass Decrement", UsageTypes.RTC);
                case 0x0154: return new Usage(this, id, "Treble Increment", UsageTypes.RTC);
                case 0x0155: return new Usage(this, id, "Treble Decrement", UsageTypes.RTC);
                case 0x0160: return new Usage(this, id, "Speaker System", UsageTypes.CL);
                case 0x0161: return new Usage(this, id, "Channel Left", UsageTypes.CL);
                case 0x0162: return new Usage(this, id, "Channel Right", UsageTypes.CL);
                case 0x0163: return new Usage(this, id, "Channel Center", UsageTypes.CL);
                case 0x0164: return new Usage(this, id, "Channel Front", UsageTypes.CL);
                case 0x0165: return new Usage(this, id, "Channel Center Front", UsageTypes.CL);
                case 0x0166: return new Usage(this, id, "Channel Side", UsageTypes.CL);
                case 0x0167: return new Usage(this, id, "Channel Surround", UsageTypes.CL);
                case 0x0168: return new Usage(this, id, "Channel Low Frequency Enhancement", UsageTypes.CL);
                case 0x0169: return new Usage(this, id, "Channel Top", UsageTypes.CL);
                case 0x016a: return new Usage(this, id, "Channel Unknown", UsageTypes.CL);
                case 0x0170: return new Usage(this, id, "Sub-channel", UsageTypes.LC);
                case 0x0171: return new Usage(this, id, "Sub-channel Increment", UsageTypes.OSC);
                case 0x0172: return new Usage(this, id, "Sub-channel Decrement", UsageTypes.OSC);
                case 0x0173: return new Usage(this, id, "Alternate Audio Increment", UsageTypes.OSC);
                case 0x0174: return new Usage(this, id, "Alternate Audio Decrement", UsageTypes.OSC);
                case 0x0180: return new Usage(this, id, "Application Launch Buttons", UsageTypes.NAry);
                case 0x0181: return new Usage(this, id, "AL Launch Button Configuration Tool", UsageTypes.Sel);
                case 0x0182: return new Usage(this, id, "AL Programmable Button Configuration", UsageTypes.Sel);
                case 0x0183: return new Usage(this, id, "AL Consumer Control Configuration", UsageTypes.Sel);
                case 0x0184: return new Usage(this, id, "AL Word Processor", UsageTypes.Sel);
                case 0x0185: return new Usage(this, id, "AL Text Editor", UsageTypes.Sel);
                case 0x0186: return new Usage(this, id, "AL Spreadsheet", UsageTypes.Sel);
                case 0x0187: return new Usage(this, id, "AL Graphics Editor", UsageTypes.Sel);
                case 0x0188: return new Usage(this, id, "AL Presentation App", UsageTypes.Sel);
                case 0x0189: return new Usage(this, id, "AL Database App", UsageTypes.Sel);
                case 0x018a: return new Usage(this, id, "AL Email Reader", UsageTypes.Sel);
                case 0x018b: return new Usage(this, id, "AL Newsreader", UsageTypes.Sel);
                case 0x018c: return new Usage(this, id, "AL Voicemail", UsageTypes.Sel);
                case 0x018d: return new Usage(this, id, "AL Contacts/Address Book", UsageTypes.Sel);
                case 0x018e: return new Usage(this, id, "AL Calendar/Schedule", UsageTypes.Sel);
                case 0x018f: return new Usage(this, id, "AL Task/Project Manager", UsageTypes.Sel);
                case 0x0190: return new Usage(this, id, "AL Log/Journal/Timecard", UsageTypes.Sel);
                case 0x0191: return new Usage(this, id, "AL Checkbook/Finance", UsageTypes.Sel);
                case 0x0192: return new Usage(this, id, "AL Calculator", UsageTypes.Sel);
                case 0x0193: return new Usage(this, id, "AL A/V Capture/Playback", UsageTypes.Sel);
                case 0x0194: return new Usage(this, id, "AL Local Machine Browser", UsageTypes.Sel);
                case 0x0195: return new Usage(this, id, "AL LAN/WAN Browser", UsageTypes.Sel);
                case 0x0196: return new Usage(this, id, "AL Internet Browser", UsageTypes.Sel);
                case 0x0197: return new Usage(this, id, "AL Remote Networking/ISP Connect", UsageTypes.Sel);
                case 0x0198: return new Usage(this, id, "AL Network Conference", UsageTypes.Sel);
                case 0x0199: return new Usage(this, id, "AL Network Chat", UsageTypes.Sel);
                case 0x019a: return new Usage(this, id, "AL Telephony/Dialer", UsageTypes.Sel);
                case 0x019b: return new Usage(this, id, "AL Logon", UsageTypes.Sel);
                case 0x019c: return new Usage(this, id, "AL Logoff", UsageTypes.Sel);
                case 0x019d: return new Usage(this, id, "AL Logon/Logoff", UsageTypes.Sel);
                case 0x019e: return new Usage(this, id, "AL Terminal Lock/Screensaver", UsageTypes.Sel);
                case 0x019f: return new Usage(this, id, "AL Control Panel", UsageTypes.Sel);
                case 0x01a0: return new Usage(this, id, "AL Command Line Processor/Run", UsageTypes.Sel);
                case 0x01a1: return new Usage(this, id, "AL Process/Task Manager", UsageTypes.Sel);
                case 0x01a2: return new Usage(this, id, "AL Select Task/Application", UsageTypes.Sel);
                case 0x01a3: return new Usage(this, id, "AL Next Task/Application", UsageTypes.Sel);
                case 0x01a4: return new Usage(this, id, "AL Previous Task/Application", UsageTypes.Sel);
                case 0x01a5: return new Usage(this, id, "AL Preemptive Halt Task/Application", UsageTypes.Sel);
                case 0x01a6: return new Usage(this, id, "AL Integrated Help Center", UsageTypes.Sel);
                case 0x01a7: return new Usage(this, id, "AL Documents", UsageTypes.Sel);
                case 0x01a8: return new Usage(this, id, "AL Thesaurus", UsageTypes.Sel);
                case 0x01a9: return new Usage(this, id, "AL Dictionary", UsageTypes.Sel);
                case 0x01aa: return new Usage(this, id, "AL Desktop", UsageTypes.Sel);
                case 0x01ab: return new Usage(this, id, "AL Spell Check", UsageTypes.Sel);
                case 0x01ac: return new Usage(this, id, "AL Grammar Check", UsageTypes.Sel);
                case 0x01ad: return new Usage(this, id, "AL Wireless Status", UsageTypes.Sel);
                case 0x01ae: return new Usage(this, id, "AL Keyboard Layout", UsageTypes.Sel);
                case 0x01af: return new Usage(this, id, "AL Virus Protection", UsageTypes.Sel);
                case 0x01b0: return new Usage(this, id, "AL Encryption", UsageTypes.Sel);
                case 0x01b1: return new Usage(this, id, "AL Screen Saver", UsageTypes.Sel);
                case 0x01b2: return new Usage(this, id, "AL Alarms", UsageTypes.Sel);
                case 0x01b3: return new Usage(this, id, "AL Clock", UsageTypes.Sel);
                case 0x01b4: return new Usage(this, id, "AL File Browser", UsageTypes.Sel);
                case 0x01b5: return new Usage(this, id, "AL Power Status", UsageTypes.Sel);
                case 0x01b6: return new Usage(this, id, "AL Image Browser", UsageTypes.Sel);
                case 0x01b7: return new Usage(this, id, "AL Audio Browser", UsageTypes.Sel);
                case 0x01b8: return new Usage(this, id, "AL Movie Browser", UsageTypes.Sel);
                case 0x01b9: return new Usage(this, id, "AL Digital Rights Manager", UsageTypes.Sel);
                case 0x01ba: return new Usage(this, id, "AL Digital Wallet", UsageTypes.Sel);
                case 0x01bc: return new Usage(this, id, "AL Instant Messaging", UsageTypes.Sel);
                case 0x01bd: return new Usage(this, id, "AL OEM Features/Tips/Tutorial Browser", UsageTypes.Sel);
                case 0x01be: return new Usage(this, id, "AL OEM Help", UsageTypes.Sel);
                case 0x01bf: return new Usage(this, id, "AL Online Community", UsageTypes.Sel);
                case 0x01c0: return new Usage(this, id, "AL Entertainment Content Browser", UsageTypes.Sel);
                case 0x01c1: return new Usage(this, id, "AL Online Shopping Browser", UsageTypes.Sel);
                case 0x01c2: return new Usage(this, id, "AL SmartCard Information/Help", UsageTypes.Sel);
                case 0x01c3: return new Usage(this, id, "AL Market Monitor/Finance Browser", UsageTypes.Sel);
                case 0x01c4: return new Usage(this, id, "AL Customized Corporate News Browser", UsageTypes.Sel);
                case 0x01c5: return new Usage(this, id, "AL Online Activity Browser", UsageTypes.Sel);
                case 0x01c6: return new Usage(this, id, "AL Research/Search Browser", UsageTypes.Sel);
                case 0x01c7: return new Usage(this, id, "AL Audio Player", UsageTypes.Sel);
                case 0x01c8: return new Usage(this, id, "AL Navigation", UsageTypes.Sel);
                case 0x01cb: return new Usage(this, id, "AL Context-aware desktop assistant", UsageTypes.Sel);
                case 0x0200: return new Usage(this, id, "Generic GUI Application Controls", UsageTypes.NAry);
                case 0x0201: return new Usage(this, id, "AC New", UsageTypes.Sel);
                case 0x0202: return new Usage(this, id, "AC Open", UsageTypes.Sel);
                case 0x0203: return new Usage(this, id, "AC Close", UsageTypes.Sel);
                case 0x0204: return new Usage(this, id, "AC Exit", UsageTypes.Sel);
                case 0x0205: return new Usage(this, id, "AC Maximize", UsageTypes.Sel);
                case 0x0206: return new Usage(this, id, "AC Minimize", UsageTypes.Sel);
                case 0x0207: return new Usage(this, id, "AC Save", UsageTypes.Sel);
                case 0x0208: return new Usage(this, id, "AC Print", UsageTypes.Sel);
                case 0x0209: return new Usage(this, id, "AC Properties", UsageTypes.Sel);
                case 0x021a: return new Usage(this, id, "AC Undo", UsageTypes.Sel);
                case 0x021b: return new Usage(this, id, "AC Copy", UsageTypes.Sel);
                case 0x021c: return new Usage(this, id, "AC Cut", UsageTypes.Sel);
                case 0x021d: return new Usage(this, id, "AC Paste", UsageTypes.Sel);
                case 0x021e: return new Usage(this, id, "AC Select All", UsageTypes.Sel);
                case 0x021f: return new Usage(this, id, "AC Find", UsageTypes.Sel);
                case 0x0220: return new Usage(this, id, "AC Find and Replace", UsageTypes.Sel);
                case 0x0221: return new Usage(this, id, "AC Search", UsageTypes.Sel);
                case 0x0222: return new Usage(this, id, "AC Go To", UsageTypes.Sel);
                case 0x0223: return new Usage(this, id, "AC Home", UsageTypes.Sel);
                case 0x0224: return new Usage(this, id, "AC Back", UsageTypes.Sel);
                case 0x0225: return new Usage(this, id, "AC Forward", UsageTypes.Sel);
                case 0x0226: return new Usage(this, id, "AC Stop", UsageTypes.Sel);
                case 0x0227: return new Usage(this, id, "AC Refresh", UsageTypes.Sel);
                case 0x0228: return new Usage(this, id, "AC Previous Link", UsageTypes.Sel);
                case 0x0229: return new Usage(this, id, "AC Next Link", UsageTypes.Sel);
                case 0x022a: return new Usage(this, id, "AC Bookmarks", UsageTypes.Sel);
                case 0x022b: return new Usage(this, id, "AC History", UsageTypes.Sel);
                case 0x022c: return new Usage(this, id, "AC Subscriptions", UsageTypes.Sel);
                case 0x022d: return new Usage(this, id, "AC Zoom In", UsageTypes.Sel);
                case 0x022e: return new Usage(this, id, "AC Zoom Out", UsageTypes.Sel);
                case 0x022f: return new Usage(this, id, "AC Zoom", UsageTypes.LC);
                case 0x0230: return new Usage(this, id, "AC Full Screen View", UsageTypes.Sel);
                case 0x0231: return new Usage(this, id, "AC Normal View", UsageTypes.Sel);
                case 0x0232: return new Usage(this, id, "AC View Toggle", UsageTypes.Sel);
                case 0x0233: return new Usage(this, id, "AC Scroll Up", UsageTypes.Sel);
                case 0x0234: return new Usage(this, id, "AC Scroll Down", UsageTypes.Sel);
                case 0x0235: return new Usage(this, id, "AC Scroll", UsageTypes.LC);
                case 0x0236: return new Usage(this, id, "AC Pan Left", UsageTypes.Sel);
                case 0x0237: return new Usage(this, id, "AC Pan Right", UsageTypes.Sel);
                case 0x0238: return new Usage(this, id, "AC Pan", UsageTypes.LC);
                case 0x0239: return new Usage(this, id, "AC New Window", UsageTypes.Sel);
                case 0x023a: return new Usage(this, id, "AC Tile Horizontally", UsageTypes.Sel);
                case 0x023b: return new Usage(this, id, "AC Tile Vertically", UsageTypes.Sel);
                case 0x023c: return new Usage(this, id, "AC Format", UsageTypes.Sel);
                case 0x023d: return new Usage(this, id, "AC Edit", UsageTypes.Sel);
                case 0x023e: return new Usage(this, id, "AC Bold", UsageTypes.Sel);
                case 0x023f: return new Usage(this, id, "AC Italics", UsageTypes.Sel);
                case 0x0240: return new Usage(this, id, "AC Underline", UsageTypes.Sel);
                case 0x0241: return new Usage(this, id, "AC Strikethrough", UsageTypes.Sel);
                case 0x0242: return new Usage(this, id, "AC Subscript", UsageTypes.Sel);
                case 0x0243: return new Usage(this, id, "AC Superscript", UsageTypes.Sel);
                case 0x0244: return new Usage(this, id, "AC All Caps", UsageTypes.Sel);
                case 0x0245: return new Usage(this, id, "AC Rotate", UsageTypes.Sel);
                case 0x0246: return new Usage(this, id, "AC Resize", UsageTypes.Sel);
                case 0x0247: return new Usage(this, id, "AC Flip Horizontal", UsageTypes.Sel);
                case 0x0248: return new Usage(this, id, "AC Vertical", UsageTypes.Sel);
                case 0x0249: return new Usage(this, id, "AC Mirror Horizontal", UsageTypes.Sel);
                case 0x024a: return new Usage(this, id, "AC Mirror Vertical", UsageTypes.Sel);
                case 0x024b: return new Usage(this, id, "AC Font Select", UsageTypes.Sel);
                case 0x024c: return new Usage(this, id, "AC Font Color", UsageTypes.Sel);
                case 0x024d: return new Usage(this, id, "AC Font Size", UsageTypes.Sel);
                case 0x024e: return new Usage(this, id, "AC Justify Left", UsageTypes.Sel);
                case 0x024f: return new Usage(this, id, "AC Justify Center H", UsageTypes.Sel);
                case 0x0250: return new Usage(this, id, "AC Justify Right", UsageTypes.Sel);
                case 0x0251: return new Usage(this, id, "AC Justify Block H", UsageTypes.Sel);
                case 0x0252: return new Usage(this, id, "AC Justify Top", UsageTypes.Sel);
                case 0x0253: return new Usage(this, id, "AC Justify Center V", UsageTypes.Sel);
                case 0x0254: return new Usage(this, id, "AC Justify Bottom", UsageTypes.Sel);
                case 0x0255: return new Usage(this, id, "AC Justify Block V", UsageTypes.Sel);
                case 0x0256: return new Usage(this, id, "AC Indent Decrease", UsageTypes.Sel);
                case 0x0257: return new Usage(this, id, "AC Indent Increase", UsageTypes.Sel);
                case 0x0258: return new Usage(this, id, "AC Numbered List", UsageTypes.Sel);
                case 0x0259: return new Usage(this, id, "AC Restart Numbering", UsageTypes.Sel);
                case 0x025a: return new Usage(this, id, "AC Bulleted List", UsageTypes.Sel);
                case 0x025b: return new Usage(this, id, "AC Promote", UsageTypes.Sel);
                case 0x025c: return new Usage(this, id, "AC Demote", UsageTypes.Sel);
                case 0x025d: return new Usage(this, id, "AC Yes", UsageTypes.Sel);
                case 0x025e: return new Usage(this, id, "AC No", UsageTypes.Sel);
                case 0x025f: return new Usage(this, id, "AC Cancel", UsageTypes.Sel);
                case 0x0260: return new Usage(this, id, "AC Catalog", UsageTypes.Sel);
                case 0x0261: return new Usage(this, id, "AC Buy/Checkout", UsageTypes.Sel);
                case 0x0262: return new Usage(this, id, "AC Add to Cart", UsageTypes.Sel);
                case 0x0263: return new Usage(this, id, "AC Expand", UsageTypes.Sel);
                case 0x0264: return new Usage(this, id, "AC Expand All", UsageTypes.Sel);
                case 0x0265: return new Usage(this, id, "AC Collapse", UsageTypes.Sel);
                case 0x0266: return new Usage(this, id, "AC Collapse All", UsageTypes.Sel);
                case 0x0267: return new Usage(this, id, "AC Print Preview", UsageTypes.Sel);
                case 0x0268: return new Usage(this, id, "AC Paste Special", UsageTypes.Sel);
                case 0x0269: return new Usage(this, id, "AC Insert Mode", UsageTypes.Sel);
                case 0x026a: return new Usage(this, id, "AC Delete", UsageTypes.Sel);
                case 0x026b: return new Usage(this, id, "AC Lock", UsageTypes.Sel);
                case 0x026c: return new Usage(this, id, "AC Unlock", UsageTypes.Sel);
                case 0x026d: return new Usage(this, id, "AC Protect", UsageTypes.Sel);
                case 0x026e: return new Usage(this, id, "AC Unprotect", UsageTypes.Sel);
                case 0x026f: return new Usage(this, id, "AC Attach Comment", UsageTypes.Sel);
                case 0x0270: return new Usage(this, id, "AC Delete Comment", UsageTypes.Sel);
                case 0x0271: return new Usage(this, id, "AC View Comment", UsageTypes.Sel);
                case 0x0272: return new Usage(this, id, "AC Select Word", UsageTypes.Sel);
                case 0x0273: return new Usage(this, id, "AC Select Sentence", UsageTypes.Sel);
                case 0x0274: return new Usage(this, id, "AC Select Paragraph", UsageTypes.Sel);
                case 0x0275: return new Usage(this, id, "AC Select Column", UsageTypes.Sel);
                case 0x0276: return new Usage(this, id, "AC Select Row", UsageTypes.Sel);
                case 0x0277: return new Usage(this, id, "AC Select Table", UsageTypes.Sel);
                case 0x0278: return new Usage(this, id, "AC Select Object", UsageTypes.Sel);
                case 0x0279: return new Usage(this, id, "AC Redo/Repeat", UsageTypes.Sel);
                case 0x027a: return new Usage(this, id, "AC Sort", UsageTypes.Sel);
                case 0x027b: return new Usage(this, id, "AC Sort Ascending", UsageTypes.Sel);
                case 0x027c: return new Usage(this, id, "AC Sort Descending", UsageTypes.Sel);
                case 0x027d: return new Usage(this, id, "AC Filter", UsageTypes.Sel);
                case 0x027e: return new Usage(this, id, "AC Set Clock", UsageTypes.Sel);
                case 0x027f: return new Usage(this, id, "AC View Clock", UsageTypes.Sel);
                case 0x0280: return new Usage(this, id, "AC Select Time Zone", UsageTypes.Sel);
                case 0x0281: return new Usage(this, id, "AC Edit Time Zones", UsageTypes.Sel);
                case 0x0282: return new Usage(this, id, "AC Set Alarm", UsageTypes.Sel);
                case 0x0283: return new Usage(this, id, "AC Clear Alarm", UsageTypes.Sel);
                case 0x0284: return new Usage(this, id, "AC Snooze Alarm", UsageTypes.Sel);
                case 0x0285: return new Usage(this, id, "AC Reset Alarm", UsageTypes.Sel);
                case 0x0286: return new Usage(this, id, "AC Synchronize", UsageTypes.Sel);
                case 0x0287: return new Usage(this, id, "AC Send/Receive", UsageTypes.Sel);
                case 0x0288: return new Usage(this, id, "AC Send To", UsageTypes.Sel);
                case 0x0289: return new Usage(this, id, "AC Reply", UsageTypes.Sel);
                case 0x028a: return new Usage(this, id, "AC Reply All", UsageTypes.Sel);
                case 0x028b: return new Usage(this, id, "AC Forward Msg", UsageTypes.Sel);
                case 0x028c: return new Usage(this, id, "AC Send", UsageTypes.Sel);
                case 0x028d: return new Usage(this, id, "AC Attach File", UsageTypes.Sel);
                case 0x028e: return new Usage(this, id, "AC Upload", UsageTypes.Sel);
                case 0x028f: return new Usage(this, id, "AC Download (Save Target As)", UsageTypes.Sel);
                case 0x0290: return new Usage(this, id, "AC Set Borders", UsageTypes.Sel);
                case 0x0291: return new Usage(this, id, "AC Insert Row", UsageTypes.Sel);
                case 0x0292: return new Usage(this, id, "AC Insert Column", UsageTypes.Sel);
                case 0x0293: return new Usage(this, id, "AC Insert File", UsageTypes.Sel);
                case 0x0294: return new Usage(this, id, "AC Insert Picture", UsageTypes.Sel);
                case 0x0295: return new Usage(this, id, "AC Insert Object", UsageTypes.Sel);
                case 0x0296: return new Usage(this, id, "AC Insert Symbol", UsageTypes.Sel);
                case 0x0297: return new Usage(this, id, "AC Save and Close", UsageTypes.Sel);
                case 0x0298: return new Usage(this, id, "AC Rename", UsageTypes.Sel);
                case 0x0299: return new Usage(this, id, "AC Merge", UsageTypes.Sel);
                case 0x029a: return new Usage(this, id, "AC Split", UsageTypes.Sel);
                case 0x029b: return new Usage(this, id, "AC Distribute Horizontally", UsageTypes.Sel);
                case 0x029c: return new Usage(this, id, "AC Distribute Vertically", UsageTypes.Sel);
                case 0x029d: return new Usage(this, id, "AC Next Keyboard Layout Select", UsageTypes.Sel);
                case 0x029e: return new Usage(this, id, "AC Navigation Guidance", UsageTypes.Sel);
                case 0x029f: return new Usage(this, id, "AC Desktop Show All Windows", UsageTypes.Sel);
                case 0x02a0: return new Usage(this, id, "AC Desktop Show All Applications", UsageTypes.Sel);
                case 0x02c0: return new Usage(this, id, "Extended Keyboard Attributes Collection", UsageTypes.CL);
                case 0x02c1: return new Usage(this, id, "Keyboard Form Factor", UsageTypes.SV);
                case 0x02c2: return new Usage(this, id, "Keyboard Key Type", UsageTypes.SV);
                case 0x02c3: return new Usage(this, id, "Keyboard Physical Layout", UsageTypes.SV);
                case 0x02c4: return new Usage(this, id, "Vendor-Specific Keyboard Physical Layout", UsageTypes.SV);
                case 0x02c5: return new Usage(this, id, "Keyboard IETF Language Tag Index", UsageTypes.SV);
                case 0x02c6: return new Usage(this, id, "Implemented Keyboard Input Assist Controls", UsageTypes.SV);
                case 0x02c7: return new Usage(this, id, "Keyboard Input Assist Previous", UsageTypes.Sel);
                case 0x02c8: return new Usage(this, id, "Keyboard Input Assist Next", UsageTypes.Sel);
                case 0x02c9: return new Usage(this, id, "Keyboard Input Assist Previous Group", UsageTypes.Sel);
                case 0x02ca: return new Usage(this, id, "Keyboard Input Assist Next Group", UsageTypes.Sel);
                case 0x02cb: return new Usage(this, id, "Keyboard Input Assist Accept", UsageTypes.Sel);
                case 0x02cc: return new Usage(this, id, "Keyboard Input Assist Cancel", UsageTypes.Sel);
                case 0x02d0: return new Usage(this, id, "Privacy Screen Toggle", UsageTypes.OOC);
                case 0x02d1: return new Usage(this, id, "Privacy Screen Level Decrement", UsageTypes.RTC);
                case 0x02d2: return new Usage(this, id, "Privacy Screen Level Increment", UsageTypes.RTC);
                case 0x02d3: return new Usage(this, id, "Privacy Screen Level Minimum", UsageTypes.OSC);
                case 0x02d4: return new Usage(this, id, "Privacy Screen Level Maximum", UsageTypes.OSC);
            }

            return base.CreateUsage(id);
        }
    }

    /// <summary>
    ///     Base class for all usage pages.
    /// </summary>
    public sealed class DigitizerUsagePage : UsagePage
    {
        /// <summary>
        ///     Singleton instance of Digitizer Usage Page.
        /// </summary>
        public static readonly DigitizerUsagePage Instance = new DigitizerUsagePage();

        private DigitizerUsagePage() : base(0x000d, "Digitizer")
        {
        }

        /// <inheritdoc />
        protected override Usage CreateUsage(ushort id) 
        {
            switch (id)
            {
                case 0x0000: return new Usage(this, id, "Undefined", UsageTypes.None);
                case 0x0001: return new Usage(this, id, "Digitizer", UsageTypes.CA);
                case 0x0002: return new Usage(this, id, "Pen", UsageTypes.CA);
                case 0x0003: return new Usage(this, id, "Light Pen", UsageTypes.CA);
                case 0x0004: return new Usage(this, id, "Touch Screen", UsageTypes.CA);
                case 0x0005: return new Usage(this, id, "Touch Pad", UsageTypes.CA);
                case 0x0006: return new Usage(this, id, "White Board", UsageTypes.CA);
                case 0x0007: return new Usage(this, id, "Coordinate Measuring Machine", UsageTypes.CA);
                case 0x0008: return new Usage(this, id, "3D Digitizer", UsageTypes.CA);
                case 0x0009: return new Usage(this, id, "Stereo Plotter", UsageTypes.CA);
                case 0x000a: return new Usage(this, id, "Articulated Arm", UsageTypes.CA);
                case 0x000b: return new Usage(this, id, "Armature", UsageTypes.CA);
                case 0x000c: return new Usage(this, id, "Multiple Point Digitizer", UsageTypes.CA);
                case 0x000d: return new Usage(this, id, "Free Space Wand", UsageTypes.CA);
                case 0x000e: return new Usage(this, id, "Device Configuration", UsageTypes.CA);
                case 0x000f: return new Usage(this, id, "Capacitive Heat Map Digitizer", UsageTypes.CA);
                case 0x0020: return new Usage(this, id, "Stylus", UsageTypes.CA|UsageTypes.CL);
                case 0x0021: return new Usage(this, id, "Puck", UsageTypes.CL);
                case 0x0022: return new Usage(this, id, "Finger", UsageTypes.CL);
                case 0x0023: return new Usage(this, id, "Device Settings", UsageTypes.CL);
                case 0x0024: return new Usage(this, id, "Character Gesture", UsageTypes.CL);
                case 0x0030: return new Usage(this, id, "Tip Pressure", UsageTypes.DV);
                case 0x0031: return new Usage(this, id, "Barrel Pressure", UsageTypes.DV);
                case 0x0032: return new Usage(this, id, "In Range", UsageTypes.MC);
                case 0x0033: return new Usage(this, id, "Touch", UsageTypes.MC);
                case 0x0034: return new Usage(this, id, "Untouch", UsageTypes.OSC);
                case 0x0035: return new Usage(this, id, "Tap", UsageTypes.OSC);
                case 0x0036: return new Usage(this, id, "Quality", UsageTypes.DV);
                case 0x0037: return new Usage(this, id, "Data Valid", UsageTypes.MC);
                case 0x0038: return new Usage(this, id, "Transducer Index", UsageTypes.DV);
                case 0x0039: return new Usage(this, id, "Tablet Function Keys", UsageTypes.CL);
                case 0x003a: return new Usage(this, id, "Program Change Keys", UsageTypes.CL);
                case 0x003b: return new Usage(this, id, "Battery Strength", UsageTypes.DV);
                case 0x003c: return new Usage(this, id, "Invert", UsageTypes.MC);
                case 0x003d: return new Usage(this, id, "X Tilt", UsageTypes.DV);
                case 0x003e: return new Usage(this, id, "Y Tilt", UsageTypes.DV);
                case 0x003f: return new Usage(this, id, "Azimuth", UsageTypes.DV);
                case 0x0040: return new Usage(this, id, "Altitude", UsageTypes.DV);
                case 0x0041: return new Usage(this, id, "Twist", UsageTypes.DV);
                case 0x0042: return new Usage(this, id, "Tip Switch", UsageTypes.MC);
                case 0x0043: return new Usage(this, id, "Secondary Tip Switch", UsageTypes.MC);
                case 0x0044: return new Usage(this, id, "Barrel Switch", UsageTypes.MC);
                case 0x0045: return new Usage(this, id, "Eraser", UsageTypes.MC);
                case 0x0046: return new Usage(this, id, "Tablet Pick", UsageTypes.MC);
                case 0x0047: return new Usage(this, id, "Touch Valid", UsageTypes.MC);
                case 0x0048: return new Usage(this, id, "Width", UsageTypes.DV);
                case 0x0049: return new Usage(this, id, "Height", UsageTypes.DV);
                case 0x0051: return new Usage(this, id, "Contact Identifier", UsageTypes.DV);
                case 0x0052: return new Usage(this, id, "Device Mode", UsageTypes.DV);
                case 0x0053: return new Usage(this, id, "Device Identifier", UsageTypes.DV);
                case 0x0054: return new Usage(this, id, "Contact Count", UsageTypes.DV);
                case 0x0055: return new Usage(this, id, "Contact Count Maximum", UsageTypes.SV);
                case 0x0056: return new Usage(this, id, "Scan Time", UsageTypes.DV);
                case 0x0057: return new Usage(this, id, "Surface Width", UsageTypes.DF);
                case 0x0058: return new Usage(this, id, "Button Switch", UsageTypes.DF);
                case 0x0059: return new Usage(this, id, "Pad Type", UsageTypes.SF);
                case 0x005a: return new Usage(this, id, "Secondary Barrel Switch", UsageTypes.MC);
                case 0x005b: return new Usage(this, id, "Transducer Serial Number", UsageTypes.SV);
                case 0x005c: return new Usage(this, id, "Preferred Color", UsageTypes.DV);
                case 0x0060: return new Usage(this, id, "Latency Mode", UsageTypes.DF);
                case 0x0061: return new Usage(this, id, "Gesture Character Quality", UsageTypes.DV);
                case 0x0062: return new Usage(this, id, "Character Gesture Data Length", UsageTypes.DV);
                case 0x0063: return new Usage(this, id, "Character Gesture Data", UsageTypes.DV);
                case 0x0064: return new Usage(this, id, "Gesture Character Encoding", UsageTypes.NAry);
                case 0x0065: return new Usage(this, id, "UTF8 Character Gesture Encoding", UsageTypes.Sel);
                case 0x0066: return new Usage(this, id, "UTF16 Little Endian Character Gesture Encoding", UsageTypes.Sel);
                case 0x0067: return new Usage(this, id, "UTF16 Big Endian Character Gesture Encoding", UsageTypes.Sel);
                case 0x0068: return new Usage(this, id, "UTF32 Little Endian Character Gesture Encoding", UsageTypes.Sel);
                case 0x0069: return new Usage(this, id, "UTF32 Big Endian Character Gesture Encoding", UsageTypes.Sel);
                case 0x006a: return new Usage(this, id, "Capacitive Heat Map Protocol Vendor ID", UsageTypes.SV);
                case 0x006b: return new Usage(this, id, "Capacitive Heat Map Protocol Version", UsageTypes.SV);
                case 0x006c: return new Usage(this, id, "Capacitive Heat Map Frame Data", UsageTypes.DV);
                case 0x006d: return new Usage(this, id, "Gesture Character Enable", UsageTypes.DF);
                case 0x0090: return new Usage(this, id, "Transducer Software Info", UsageTypes.CL);
                case 0x0091: return new Usage(this, id, "Transducer Vendor ID", UsageTypes.SV);
                case 0x0092: return new Usage(this, id, "Transducer Product ID", UsageTypes.SV);
                case 0x0093: return new Usage(this, id, "Device Supported Protocols", UsageTypes.CL|UsageTypes.NAry);
                case 0x0094: return new Usage(this, id, "Transducer Supported Protocols", UsageTypes.CL|UsageTypes.NAry);
                case 0x0095: return new Usage(this, id, "No Protocol", UsageTypes.Sel);
                case 0x0096: return new Usage(this, id, "Wacom AES Protocol", UsageTypes.Sel);
                case 0x0097: return new Usage(this, id, "USI Protocol", UsageTypes.Sel);
                case 0x0098: return new Usage(this, id, "Microsoft Pen Protocol", UsageTypes.Sel);
                case 0x00a0: return new Usage(this, id, "Supported Report Rates", UsageTypes.CL|UsageTypes.SV);
                case 0x00a1: return new Usage(this, id, "Report Rate", UsageTypes.DV);
                case 0x00a2: return new Usage(this, id, "Transducer Connected", UsageTypes.SF);
                case 0x00a3: return new Usage(this, id, "Switch Disabled", UsageTypes.Sel);
                case 0x00a4: return new Usage(this, id, "Switch Unimplemented", UsageTypes.Sel);
                case 0x00a5: return new Usage(this, id, "Transducer Switches", UsageTypes.CL);
            }

            return base.CreateUsage(id);
        }
    }

    /// <summary>
    ///     Base class for all usage pages.
    /// </summary>
    public sealed class HapticsUsagePage : UsagePage
    {
        /// <summary>
        ///     Singleton instance of Haptics Usage Page.
        /// </summary>
        public static readonly HapticsUsagePage Instance = new HapticsUsagePage();

        private HapticsUsagePage() : base(0x000e, "Haptics")
        {
        }

        /// <inheritdoc />
        protected override Usage CreateUsage(ushort id) 
        {
            switch (id)
            {
                case 0x0000: return new Usage(this, id, "Undefined", UsageTypes.None);
                case 0x0001: return new Usage(this, id, "Simple Haptic Controller", UsageTypes.CA|UsageTypes.CL);
                case 0x0010: return new Usage(this, id, "Waveform List", UsageTypes.NAry);
                case 0x0011: return new Usage(this, id, "Duration List", UsageTypes.NAry);
                case 0x0020: return new Usage(this, id, "Auto Trigger", UsageTypes.DV);
                case 0x0021: return new Usage(this, id, "Manual Trigger", UsageTypes.DV);
                case 0x0022: return new Usage(this, id, "Auto Trigger Associated Control", UsageTypes.SV);
                case 0x0023: return new Usage(this, id, "Intensity", UsageTypes.DV);
                case 0x0024: return new Usage(this, id, "Repeat Count", UsageTypes.DV);
                case 0x0025: return new Usage(this, id, "Retrigger Period", UsageTypes.DV);
                case 0x0026: return new Usage(this, id, "Waveform Vendor Page", UsageTypes.SV);
                case 0x0027: return new Usage(this, id, "Waveform Vendor ID", UsageTypes.SV);
                case 0x0028: return new Usage(this, id, "Waveform Cutoff Time", UsageTypes.SV);
                case 0x1001: return new Usage(this, id, "WAVEFORM_NONE", UsageTypes.Sel);
                case 0x1002: return new Usage(this, id, "WAVEFORM_STOP", UsageTypes.Sel);
                case 0x1003: return new Usage(this, id, "WAVEFORM_CLICK", UsageTypes.Sel);
                case 0x1004: return new Usage(this, id, "WAVEFORM_BUZZ_CONTINUOUS", UsageTypes.Sel);
                case 0x1005: return new Usage(this, id, "WAVEFORM_RUMBLE_CONTINUOUS", UsageTypes.Sel);
                case 0x1006: return new Usage(this, id, "WAVEFORM_PRESS", UsageTypes.Sel);
                case 0x1007: return new Usage(this, id, "WAVEFORM_RELEASE", UsageTypes.Sel);
            }

            return base.CreateUsage(id);
        }
    }

    /// <summary>
    ///     Base class for all usage pages.
    /// </summary>
    public sealed class PhysicalInterfaceDeviceUsagePage : UsagePage
    {
        /// <summary>
        ///     Singleton instance of PhysicalInterfaceDevice Usage Page.
        /// </summary>
        public static readonly PhysicalInterfaceDeviceUsagePage Instance = new PhysicalInterfaceDeviceUsagePage();

        private PhysicalInterfaceDeviceUsagePage() : base(0x000f, "PhysicalInterfaceDevice")
        {
        }

        /// <inheritdoc />
        protected override Usage CreateUsage(ushort id) 
        {
            switch (id)
            {
                case 0x0000: return new Usage(this, id, "Undefined", UsageTypes.None);
                case 0x0001: return new Usage(this, id, "Physical Interface Device", UsageTypes.CA);
                case 0x0020: return new Usage(this, id, "Normal", UsageTypes.DV);
                case 0x0021: return new Usage(this, id, "Set Effect Report", UsageTypes.CL);
                case 0x0022: return new Usage(this, id, "Effect Block Index", UsageTypes.DV);
                case 0x0023: return new Usage(this, id, "Parameter Block Offset", UsageTypes.DV);
                case 0x0024: return new Usage(this, id, "ROM Flag", UsageTypes.DF);
                case 0x0025: return new Usage(this, id, "Effect Type", UsageTypes.NAry);
                case 0x0026: return new Usage(this, id, "ET Constant Force", UsageTypes.Sel);
                case 0x0027: return new Usage(this, id, "ET Ramp", UsageTypes.Sel);
                case 0x0028: return new Usage(this, id, "ET Custom Force Data", UsageTypes.Sel);
                case 0x0030: return new Usage(this, id, "ET Square", UsageTypes.Sel);
                case 0x0031: return new Usage(this, id, "ET Sine", UsageTypes.Sel);
                case 0x0032: return new Usage(this, id, "ET Triangle", UsageTypes.Sel);
                case 0x0033: return new Usage(this, id, "ET Sawtooth Up", UsageTypes.Sel);
                case 0x0034: return new Usage(this, id, "ET Sawtooth Down", UsageTypes.Sel);
                case 0x0040: return new Usage(this, id, "ET Spring", UsageTypes.Sel);
                case 0x0041: return new Usage(this, id, "ET Damper", UsageTypes.Sel);
                case 0x0042: return new Usage(this, id, "ET Inertia", UsageTypes.Sel);
                case 0x0043: return new Usage(this, id, "ET Friction", UsageTypes.Sel);
                case 0x0050: return new Usage(this, id, "Duration", UsageTypes.DV);
                case 0x0051: return new Usage(this, id, "Sample Period", UsageTypes.DV);
                case 0x0052: return new Usage(this, id, "Gain", UsageTypes.DV);
                case 0x0053: return new Usage(this, id, "Trigger Button", UsageTypes.DV);
                case 0x0054: return new Usage(this, id, "Trigger Repeat Interval", UsageTypes.DV);
                case 0x0055: return new Usage(this, id, "Axes Enable", UsageTypes.US);
                case 0x0056: return new Usage(this, id, "Direction Enable", UsageTypes.DF);
                case 0x0057: return new Usage(this, id, "Direction", UsageTypes.CL);
                case 0x0058: return new Usage(this, id, "Type Specific Block Offset", UsageTypes.CL);
                case 0x0059: return new Usage(this, id, "Block Type", UsageTypes.NAry);
                case 0x005a: return new Usage(this, id, "Set Envelope Report", UsageTypes.CL);
                case 0x005b: return new Usage(this, id, "Attack Level", UsageTypes.DV);
                case 0x005c: return new Usage(this, id, "Attack Time", UsageTypes.DV);
                case 0x005d: return new Usage(this, id, "Fade Level", UsageTypes.DV);
                case 0x005e: return new Usage(this, id, "Fade Time", UsageTypes.DV);
                case 0x005f: return new Usage(this, id, "Set Condition Report", UsageTypes.CL);
                case 0x0060: return new Usage(this, id, "CP Offset", UsageTypes.DV);
                case 0x0061: return new Usage(this, id, "Positive Coefficient", UsageTypes.DV);
                case 0x0062: return new Usage(this, id, "Negative Coefficient", UsageTypes.DV);
                case 0x0063: return new Usage(this, id, "Positive Saturation", UsageTypes.DV);
                case 0x0064: return new Usage(this, id, "Negative Saturation", UsageTypes.DV);
                case 0x0065: return new Usage(this, id, "Dead Band", UsageTypes.DV);
                case 0x0066: return new Usage(this, id, "Download Force Sample", UsageTypes.CL);
                case 0x0067: return new Usage(this, id, "Isoch Custom Force Enable", UsageTypes.DF);
                case 0x0068: return new Usage(this, id, "Custom Force Data Report", UsageTypes.CL);
                case 0x0069: return new Usage(this, id, "Custom Force Data", UsageTypes.DV);
                case 0x006a: return new Usage(this, id, "Custom Force Vendor Defined Data", UsageTypes.DV);
                case 0x006b: return new Usage(this, id, "Set Custom Force Report", UsageTypes.CL);
                case 0x006c: return new Usage(this, id, "Custom Force Data Offset", UsageTypes.DV);
                case 0x006d: return new Usage(this, id, "Sample Count", UsageTypes.DV);
                case 0x006e: return new Usage(this, id, "Set Periodic Report", UsageTypes.CL);
                case 0x006f: return new Usage(this, id, "Offset", UsageTypes.DV);
                case 0x0070: return new Usage(this, id, "Magnitude", UsageTypes.DV);
                case 0x0071: return new Usage(this, id, "Phase", UsageTypes.DV);
                case 0x0072: return new Usage(this, id, "Period", UsageTypes.DV);
                case 0x0073: return new Usage(this, id, "Set Constant Force Report", UsageTypes.CL);
                case 0x0074: return new Usage(this, id, "Set Ramp Force Report", UsageTypes.CL);
                case 0x0075: return new Usage(this, id, "Ramp Start", UsageTypes.DV);
                case 0x0076: return new Usage(this, id, "Ramp End", UsageTypes.DV);
                case 0x0077: return new Usage(this, id, "Effect Operation Report", UsageTypes.CL);
                case 0x0078: return new Usage(this, id, "Effect Operation", UsageTypes.NAry);
                case 0x0079: return new Usage(this, id, "Op Effect Start", UsageTypes.Sel);
                case 0x007a: return new Usage(this, id, "Op Effect Start Solo", UsageTypes.Sel);
                case 0x007b: return new Usage(this, id, "Op Effect Stop", UsageTypes.Sel);
                case 0x007c: return new Usage(this, id, "Loop Count", UsageTypes.DV);
                case 0x007d: return new Usage(this, id, "Device Gain Report", UsageTypes.CL);
                case 0x007e: return new Usage(this, id, "Device Gain", UsageTypes.DV);
                case 0x007f: return new Usage(this, id, "PID Pool Report", UsageTypes.CL);
                case 0x0080: return new Usage(this, id, "RAM Pool Size", UsageTypes.DV);
                case 0x0081: return new Usage(this, id, "ROM Pool Size", UsageTypes.SV);
                case 0x0082: return new Usage(this, id, "ROM Effect Block Count", UsageTypes.SV);
                case 0x0083: return new Usage(this, id, "Simultaneous Effects Max", UsageTypes.SV);
                case 0x0084: return new Usage(this, id, "Pool Alignment", UsageTypes.SV);
                case 0x0085: return new Usage(this, id, "PID Pool Move Report", UsageTypes.CL);
                case 0x0086: return new Usage(this, id, "Move Source", UsageTypes.DV);
                case 0x0087: return new Usage(this, id, "Move Destination", UsageTypes.DV);
                case 0x0088: return new Usage(this, id, "Move Length", UsageTypes.DV);
                case 0x0089: return new Usage(this, id, "PID Block Load Report", UsageTypes.CL);
                case 0x008b: return new Usage(this, id, "Block Load Status", UsageTypes.NAry);
                case 0x008c: return new Usage(this, id, "Block Load Success", UsageTypes.Sel);
                case 0x008d: return new Usage(this, id, "Block Load Full", UsageTypes.Sel);
                case 0x008e: return new Usage(this, id, "Block Load Error", UsageTypes.Sel);
                case 0x008f: return new Usage(this, id, "Block Handle", UsageTypes.None);
                case 0x0090: return new Usage(this, id, "PID Block Free Report", UsageTypes.CL);
                case 0x0091: return new Usage(this, id, "Type Specific Block Handle", UsageTypes.CL);
                case 0x0092: return new Usage(this, id, "PID State Report", UsageTypes.CL);
                case 0x0094: return new Usage(this, id, "Effect Playing", UsageTypes.DF);
                case 0x0095: return new Usage(this, id, "PID Device Control Report", UsageTypes.CL);
                case 0x0096: return new Usage(this, id, "PID Device Control", UsageTypes.NAry);
                case 0x0097: return new Usage(this, id, "DC Enable Actuators", UsageTypes.Sel);
                case 0x0098: return new Usage(this, id, "DC Disable Actuators", UsageTypes.Sel);
                case 0x0099: return new Usage(this, id, "DC Stop All Effects", UsageTypes.Sel);
                case 0x009a: return new Usage(this, id, "DC Device Reset", UsageTypes.Sel);
                case 0x009b: return new Usage(this, id, "DC Device Pause", UsageTypes.Sel);
                case 0x009c: return new Usage(this, id, "DC Device Continue", UsageTypes.Sel);
                case 0x009f: return new Usage(this, id, "Device Paused", UsageTypes.DF);
                case 0x00a0: return new Usage(this, id, "Actuators Enabled", UsageTypes.DF);
                case 0x00a4: return new Usage(this, id, "Safety Switch", UsageTypes.DF);
                case 0x00a5: return new Usage(this, id, "Actuator Override Switch", UsageTypes.DF);
                case 0x00a6: return new Usage(this, id, "Actuator Power", UsageTypes.OOC);
                case 0x00a7: return new Usage(this, id, "Start Delay", UsageTypes.DV);
                case 0x00a8: return new Usage(this, id, "Parameter Block Size", UsageTypes.CL);
                case 0x00a9: return new Usage(this, id, "Device Managed Pool", UsageTypes.SF);
                case 0x00aa: return new Usage(this, id, "Shared Parameter Blocks", UsageTypes.SF);
                case 0x00ab: return new Usage(this, id, "Create New Effect Report", UsageTypes.CL);
                case 0x00ac: return new Usage(this, id, "RAM Pool Available", UsageTypes.DV);
            }

            return base.CreateUsage(id);
        }
    }

    /// <summary>
    ///     Base class for all usage pages.
    /// </summary>
    public sealed class UnicodeUsagePage : UsagePage
    {
        /// <summary>
        ///     Singleton instance of Unicode Usage Page.
        /// </summary>
        public static readonly UnicodeUsagePage Instance = new UnicodeUsagePage();

        private UnicodeUsagePage() : base(0x0010, "Unicode")
        {
        }

        /// <inheritdoc />
        protected override Usage CreateUsage(ushort id) 
        {
            switch (id)
            {
                case 0x0000: return new Usage(this, id, "Undefined", UsageTypes.None);
            }

            return base.CreateUsage(id);
        }
    }

    /// <summary>
    ///     Base class for all usage pages.
    /// </summary>
    public sealed class EyeAndHeadTrackersUsagePage : UsagePage
    {
        /// <summary>
        ///     Singleton instance of EyeAndHeadTrackers Usage Page.
        /// </summary>
        public static readonly EyeAndHeadTrackersUsagePage Instance = new EyeAndHeadTrackersUsagePage();

        private EyeAndHeadTrackersUsagePage() : base(0x0012, "EyeAndHeadTrackers")
        {
        }

        /// <inheritdoc />
        protected override Usage CreateUsage(ushort id) 
        {
            switch (id)
            {
                case 0x0000: return new Usage(this, id, "Undefined", UsageTypes.None);
                case 0x0001: return new Usage(this, id, "Eye Tracker", UsageTypes.CA);
                case 0x0002: return new Usage(this, id, "Head Tracker", UsageTypes.CA);
                case 0x0010: return new Usage(this, id, "Tracking Data", UsageTypes.CP);
                case 0x0011: return new Usage(this, id, "Capabilities", UsageTypes.CL);
                case 0x0012: return new Usage(this, id, "Configuration", UsageTypes.CL);
                case 0x0013: return new Usage(this, id, "Status", UsageTypes.CL);
                case 0x0014: return new Usage(this, id, "Control", UsageTypes.CL);
                case 0x0020: return new Usage(this, id, "Sensor Timestamp", UsageTypes.DV);
                case 0x0021: return new Usage(this, id, "Position X", UsageTypes.DV);
                case 0x0022: return new Usage(this, id, "Position Y", UsageTypes.DV);
                case 0x0023: return new Usage(this, id, "Position Z", UsageTypes.DV);
                case 0x0024: return new Usage(this, id, "Gaze Point", UsageTypes.CP);
                case 0x0025: return new Usage(this, id, "Left Eye Position", UsageTypes.CP);
                case 0x0026: return new Usage(this, id, "Right Eye Position", UsageTypes.CP);
                case 0x0027: return new Usage(this, id, "Head Position", UsageTypes.CP);
                case 0x0028: return new Usage(this, id, "Head Direction Point", UsageTypes.CP);
                case 0x0029: return new Usage(this, id, "Rotation about X axis", UsageTypes.DV);
                case 0x002a: return new Usage(this, id, "Rotation about Y axis", UsageTypes.DV);
                case 0x002b: return new Usage(this, id, "Rotation about Z axis", UsageTypes.DV);
                case 0x0100: return new Usage(this, id, "Tracker Quality", UsageTypes.SV);
                case 0x0101: return new Usage(this, id, "Minimum Tracking Distance", UsageTypes.SV);
                case 0x0102: return new Usage(this, id, "Optimum Tracking Distance", UsageTypes.SV);
                case 0x0103: return new Usage(this, id, "Maximum Tracking Distance", UsageTypes.SV);
                case 0x0104: return new Usage(this, id, "Maximum Screen Plane Width", UsageTypes.SV);
                case 0x0105: return new Usage(this, id, "Maximum Screen Plane Height", UsageTypes.SV);
                case 0x0200: return new Usage(this, id, "Display Manufacturer ID", UsageTypes.SV);
                case 0x0201: return new Usage(this, id, "Display Product ID", UsageTypes.SV);
                case 0x0202: return new Usage(this, id, "Display Serial Number", UsageTypes.SV);
                case 0x0203: return new Usage(this, id, "Display Manufacturer Date", UsageTypes.SV);
                case 0x0204: return new Usage(this, id, "Calibrated Screen Width", UsageTypes.SV);
                case 0x0205: return new Usage(this, id, "Calibrated Screen Height", UsageTypes.SV);
                case 0x0300: return new Usage(this, id, "Sampling Frequency", UsageTypes.DV);
                case 0x0301: return new Usage(this, id, "Configuration Status", UsageTypes.DV);
                case 0x0400: return new Usage(this, id, "Device Mode Request", UsageTypes.DV);
            }

            return base.CreateUsage(id);
        }
    }

    /// <summary>
    ///     Base class for all usage pages.
    /// </summary>
    public sealed class AuxiliaryDisplayUsagePage : UsagePage
    {
        /// <summary>
        ///     Singleton instance of AuxiliaryDisplay Usage Page.
        /// </summary>
        public static readonly AuxiliaryDisplayUsagePage Instance = new AuxiliaryDisplayUsagePage();

        private AuxiliaryDisplayUsagePage() : base(0x0014, "AuxiliaryDisplay")
        {
        }

        /// <inheritdoc />
        protected override Usage CreateUsage(ushort id) 
        {
            switch (id)
            {
                case 0x0000: return new Usage(this, id, "Undefined", UsageTypes.None);
                case 0x0001: return new Usage(this, id, "Alphanumeric Display", UsageTypes.CA);
                case 0x0002: return new Usage(this, id, "Auxiliary Display", UsageTypes.CA);
                case 0x0020: return new Usage(this, id, "Display Attributes Report", UsageTypes.CL);
                case 0x0021: return new Usage(this, id, "ASCII Character Set", UsageTypes.SF);
                case 0x0022: return new Usage(this, id, "Data Read Back", UsageTypes.SF);
                case 0x0023: return new Usage(this, id, "Font Read Back", UsageTypes.SF);
                case 0x0024: return new Usage(this, id, "Display Control Report", UsageTypes.CL);
                case 0x0025: return new Usage(this, id, "Clear Display", UsageTypes.DF);
                case 0x0026: return new Usage(this, id, "Display Enable", UsageTypes.DF);
                case 0x0027: return new Usage(this, id, "Screen Saver Delay", UsageTypes.SV|UsageTypes.DV);
                case 0x0028: return new Usage(this, id, "Screen Saver Enable", UsageTypes.DF);
                case 0x0029: return new Usage(this, id, "Vertical Scroll", UsageTypes.SF|UsageTypes.DF);
                case 0x002a: return new Usage(this, id, "Horizontal Scroll", UsageTypes.SF|UsageTypes.DF);
                case 0x002b: return new Usage(this, id, "Character Report", UsageTypes.CL);
                case 0x002c: return new Usage(this, id, "Display Data", UsageTypes.DV);
                case 0x002d: return new Usage(this, id, "Display Status", UsageTypes.CL);
                case 0x002e: return new Usage(this, id, "Stat Not Ready", UsageTypes.Sel);
                case 0x002f: return new Usage(this, id, "Stat Ready", UsageTypes.Sel);
                case 0x0030: return new Usage(this, id, "Err Not a loadable character", UsageTypes.Sel);
                case 0x0031: return new Usage(this, id, "Err Font data cannot be read", UsageTypes.Sel);
                case 0x0032: return new Usage(this, id, "Cursor Position Report", UsageTypes.CL);
                case 0x0033: return new Usage(this, id, "Row", UsageTypes.DV);
                case 0x0034: return new Usage(this, id, "Column", UsageTypes.DV);
                case 0x0035: return new Usage(this, id, "Rows", UsageTypes.SV);
                case 0x0036: return new Usage(this, id, "Columns", UsageTypes.SV);
                case 0x0037: return new Usage(this, id, "Cursor Pixel Positioning", UsageTypes.SF);
                case 0x0038: return new Usage(this, id, "Cursor Mode", UsageTypes.DF);
                case 0x0039: return new Usage(this, id, "Cursor Enable", UsageTypes.DF);
                case 0x003a: return new Usage(this, id, "Cursor Blink", UsageTypes.DF);
                case 0x003b: return new Usage(this, id, "Font Report", UsageTypes.CL);
                case 0x003c: return new Usage(this, id, "Font Data", UsageTypes.None);
                case 0x003d: return new Usage(this, id, "Character Width", UsageTypes.SV);
                case 0x003e: return new Usage(this, id, "Character Height", UsageTypes.SV);
                case 0x003f: return new Usage(this, id, "Character Spacing Horizontal", UsageTypes.SV);
                case 0x0040: return new Usage(this, id, "Character Spacing Vertical", UsageTypes.SV);
                case 0x0041: return new Usage(this, id, "Unicode Character Set", UsageTypes.SF);
                case 0x0042: return new Usage(this, id, "Font 7-Segment", UsageTypes.SF);
                case 0x0043: return new Usage(this, id, "7-Segment Direct Map", UsageTypes.SF);
                case 0x0044: return new Usage(this, id, "Font 14-Segment", UsageTypes.SF);
                case 0x0045: return new Usage(this, id, "14-Segment Direct Map", UsageTypes.SF);
                case 0x0046: return new Usage(this, id, "Display Brightness", UsageTypes.DV);
                case 0x0047: return new Usage(this, id, "Display Contrast", UsageTypes.DV);
                case 0x0048: return new Usage(this, id, "Character Attribute", UsageTypes.CL);
                case 0x0049: return new Usage(this, id, "Attribute Readback", UsageTypes.SF);
                case 0x004a: return new Usage(this, id, "Attribute Data", UsageTypes.DV);
                case 0x004b: return new Usage(this, id, "Char Attr Enhance", UsageTypes.OOC);
                case 0x004c: return new Usage(this, id, "Char Attr Underline", UsageTypes.OOC);
                case 0x004d: return new Usage(this, id, "Char Attr Blink", UsageTypes.OOC);
                case 0x0080: return new Usage(this, id, "Bitmap Size X", UsageTypes.SV);
                case 0x0081: return new Usage(this, id, "Bitmap Size Y", UsageTypes.SV);
                case 0x0082: return new Usage(this, id, "Max Blit Size", UsageTypes.SV);
                case 0x0083: return new Usage(this, id, "Bit Depth Format", UsageTypes.SV);
                case 0x0084: return new Usage(this, id, "Display Orientation", UsageTypes.DV);
                case 0x0085: return new Usage(this, id, "Palette Report", UsageTypes.CL);
                case 0x0086: return new Usage(this, id, "Palette Data Size", UsageTypes.SV);
                case 0x0087: return new Usage(this, id, "Palette Data Offset", UsageTypes.SV);
                case 0x0088: return new Usage(this, id, "Palette Data", UsageTypes.None);
                case 0x008a: return new Usage(this, id, "Blit Report", UsageTypes.CL);
                case 0x008b: return new Usage(this, id, "Blit Rectangle X1", UsageTypes.SV);
                case 0x008c: return new Usage(this, id, "Blit Rectangle Y1", UsageTypes.SV);
                case 0x008d: return new Usage(this, id, "Blit Rectangle X2", UsageTypes.SV);
                case 0x008e: return new Usage(this, id, "Blit Rectangle Y2", UsageTypes.SV);
                case 0x008f: return new Usage(this, id, "Blit Data", UsageTypes.None);
                case 0x0090: return new Usage(this, id, "Soft Button", UsageTypes.CL);
                case 0x0091: return new Usage(this, id, "Soft Button ID", UsageTypes.SV);
                case 0x0092: return new Usage(this, id, "Soft Button Side", UsageTypes.SV);
                case 0x0093: return new Usage(this, id, "Soft Button Offset 1", UsageTypes.SV);
                case 0x0094: return new Usage(this, id, "Soft Button Offset 2", UsageTypes.SV);
                case 0x0095: return new Usage(this, id, "Soft Button Report", UsageTypes.SV);
            }

            return base.CreateUsage(id);
        }
    }

    /// <summary>
    ///     Base class for all usage pages.
    /// </summary>
    public sealed class SensorUsagePage : UsagePage
    {
        /// <summary>
        ///     Singleton instance of Sensor Usage Page.
        /// </summary>
        public static readonly SensorUsagePage Instance = new SensorUsagePage();

        private SensorUsagePage() : base(0x0020, "Sensor")
        {
        }

        /// <inheritdoc />
        protected override Usage CreateUsage(ushort id) 
        {
            switch (id)
            {
                case 0x0000: return new Usage(this, id, "Undefined", UsageTypes.None);
                case 0x0001: return new Usage(this, id, "Sensor", UsageTypes.CA|UsageTypes.CP);
                case 0x0010: return new Usage(this, id, "Biometric", UsageTypes.CA|UsageTypes.CP);
                case 0x0011: return new Usage(this, id, "Biometric: Human Presence", UsageTypes.CA|UsageTypes.CP);
                case 0x0012: return new Usage(this, id, "Biometric: Human Proximity", UsageTypes.CA|UsageTypes.CP);
                case 0x0013: return new Usage(this, id, "Biometric: Human Touch", UsageTypes.CA|UsageTypes.CP);
                case 0x0014: return new Usage(this, id, "Biometric: Blood Pressure", UsageTypes.CA|UsageTypes.CP);
                case 0x0015: return new Usage(this, id, "Biometric: Body Temperature", UsageTypes.CA|UsageTypes.CP);
                case 0x0016: return new Usage(this, id, "Biometric: Heart Rate", UsageTypes.CA|UsageTypes.CP);
                case 0x0017: return new Usage(this, id, "Biometric: Heart Rate Variability", UsageTypes.CA|UsageTypes.CP);
                case 0x0018: return new Usage(this, id, "Biometric: Peripheral Oxygen Saturation", UsageTypes.CA|UsageTypes.CP);
                case 0x0019: return new Usage(this, id, "Biometric: Respiratory Rate", UsageTypes.CA|UsageTypes.CP);
                case 0x0020: return new Usage(this, id, "Electrical", UsageTypes.CA|UsageTypes.CP);
                case 0x0021: return new Usage(this, id, "Electrical: Capacitance", UsageTypes.CA|UsageTypes.CP);
                case 0x0022: return new Usage(this, id, "Electrical: Current", UsageTypes.CA|UsageTypes.CP);
                case 0x0023: return new Usage(this, id, "Electrical: Power", UsageTypes.CA|UsageTypes.CP);
                case 0x0024: return new Usage(this, id, "Electrical: Inductance", UsageTypes.CA|UsageTypes.CP);
                case 0x0025: return new Usage(this, id, "Electrical: Resistance", UsageTypes.CA|UsageTypes.CP);
                case 0x0026: return new Usage(this, id, "Electrical: Voltage", UsageTypes.CA|UsageTypes.CP);
                case 0x0027: return new Usage(this, id, "Electrical: Potentiometer", UsageTypes.CA|UsageTypes.CP);
                case 0x0028: return new Usage(this, id, "Electrical: Frequency", UsageTypes.CA|UsageTypes.CP);
                case 0x0029: return new Usage(this, id, "Electrical: Period", UsageTypes.CA|UsageTypes.CP);
                case 0x0030: return new Usage(this, id, "Environmental", UsageTypes.CA|UsageTypes.CP);
                case 0x0031: return new Usage(this, id, "Environmental: Atmospheric Pressure", UsageTypes.CA|UsageTypes.CP);
                case 0x0032: return new Usage(this, id, "Environmental: Humidity", UsageTypes.CA|UsageTypes.CP);
                case 0x0033: return new Usage(this, id, "Environmental: Temperature", UsageTypes.CA|UsageTypes.CP);
                case 0x0034: return new Usage(this, id, "Environmental: Wind Direction", UsageTypes.CA|UsageTypes.CP);
                case 0x0035: return new Usage(this, id, "Environmental: Wind Speed", UsageTypes.CA|UsageTypes.CP);
                case 0x0036: return new Usage(this, id, "Environmental: Air Quality", UsageTypes.CA|UsageTypes.CP);
                case 0x0037: return new Usage(this, id, "Environmental: Heat Index", UsageTypes.CA|UsageTypes.CP);
                case 0x0038: return new Usage(this, id, "Environmental: Surface Temperature", UsageTypes.CA|UsageTypes.CP);
                case 0x0039: return new Usage(this, id, "Environmental: Volatile Organic Compounds", UsageTypes.CA|UsageTypes.CP);
                case 0x0040: return new Usage(this, id, "Light", UsageTypes.CA|UsageTypes.CP);
                case 0x0041: return new Usage(this, id, "Light: Ambient Light", UsageTypes.CA|UsageTypes.CP);
                case 0x0042: return new Usage(this, id, "Light: Consumer Infrared", UsageTypes.CA|UsageTypes.CP);
                case 0x0043: return new Usage(this, id, "Light: Infrared Light", UsageTypes.CA|UsageTypes.CP);
                case 0x0044: return new Usage(this, id, "Light: Visible Light", UsageTypes.CA|UsageTypes.CP);
                case 0x0045: return new Usage(this, id, "Light: Ultraviolet Light", UsageTypes.CA|UsageTypes.CP);
                case 0x0050: return new Usage(this, id, "Location", UsageTypes.CA|UsageTypes.CP);
                case 0x0051: return new Usage(this, id, "Location: Broadcast", UsageTypes.CA|UsageTypes.CP);
                case 0x0052: return new Usage(this, id, "Location: Dead Reckoning", UsageTypes.CA|UsageTypes.CP);
                case 0x0053: return new Usage(this, id, "Location: GPS", UsageTypes.CA|UsageTypes.CP);
                case 0x0054: return new Usage(this, id, "Location: Lookup", UsageTypes.CA|UsageTypes.CP);
                case 0x0055: return new Usage(this, id, "Location: Other", UsageTypes.CA|UsageTypes.CP);
                case 0x0056: return new Usage(this, id, "Location: Static", UsageTypes.CA|UsageTypes.CP);
                case 0x0057: return new Usage(this, id, "Location: Triangulation", UsageTypes.CA|UsageTypes.CP);
                case 0x0060: return new Usage(this, id, "Mechanical", UsageTypes.CA|UsageTypes.CP);
                case 0x0061: return new Usage(this, id, "Mechanical: Boolean Switch", UsageTypes.CA|UsageTypes.CP);
                case 0x0062: return new Usage(this, id, "Mechanical: Boolean Switch Array", UsageTypes.CA|UsageTypes.CP);
                case 0x0063: return new Usage(this, id, "Mechanical: Multivalue Switch", UsageTypes.CA|UsageTypes.CP);
                case 0x0064: return new Usage(this, id, "Mechanical: Force", UsageTypes.CA|UsageTypes.CP);
                case 0x0065: return new Usage(this, id, "Mechanical: Pressure", UsageTypes.CA|UsageTypes.CP);
                case 0x0066: return new Usage(this, id, "Mechanical: Strain", UsageTypes.CA|UsageTypes.CP);
                case 0x0067: return new Usage(this, id, "Mechanical: Weight", UsageTypes.CA|UsageTypes.CP);
                case 0x0068: return new Usage(this, id, "Mechanical: Haptic Vibrator", UsageTypes.CA|UsageTypes.CP);
                case 0x0069: return new Usage(this, id, "Mechanical: Hall Effect Switch", UsageTypes.CA|UsageTypes.CP);
                case 0x0070: return new Usage(this, id, "Motion", UsageTypes.CA|UsageTypes.CP);
                case 0x0071: return new Usage(this, id, "Motion: Accelerometer 1D", UsageTypes.CA|UsageTypes.CP);
                case 0x0072: return new Usage(this, id, "Motion: Accelerometer 2D", UsageTypes.CA|UsageTypes.CP);
                case 0x0073: return new Usage(this, id, "Motion: Accelerometer 3D", UsageTypes.CA|UsageTypes.CP);
                case 0x0074: return new Usage(this, id, "Motion: Gyrometer 1D", UsageTypes.CA|UsageTypes.CP);
                case 0x0075: return new Usage(this, id, "Motion: Gyrometer 2D", UsageTypes.CA|UsageTypes.CP);
                case 0x0076: return new Usage(this, id, "Motion: Gyrometer 3D", UsageTypes.CA|UsageTypes.CP);
                case 0x0077: return new Usage(this, id, "Motion: Motion Detector", UsageTypes.CA|UsageTypes.CP);
                case 0x0078: return new Usage(this, id, "Motion: Speedometer", UsageTypes.CA|UsageTypes.CP);
                case 0x0079: return new Usage(this, id, "Motion: Accelerometer", UsageTypes.CA|UsageTypes.CP);
                case 0x007a: return new Usage(this, id, "Motion: Gyrometer", UsageTypes.CA|UsageTypes.CP);
                case 0x007b: return new Usage(this, id, "Motion: Gravity Vector", UsageTypes.CA|UsageTypes.CP);
                case 0x007c: return new Usage(this, id, "Motion: Linear Accelerometer", UsageTypes.CA|UsageTypes.CP);
                case 0x0080: return new Usage(this, id, "Orientation", UsageTypes.CA|UsageTypes.CP);
                case 0x0081: return new Usage(this, id, "Orientation: Compass 1D", UsageTypes.CA|UsageTypes.CP);
                case 0x0082: return new Usage(this, id, "Orientation: Compass 2D", UsageTypes.CA|UsageTypes.CP);
                case 0x0083: return new Usage(this, id, "Orientation: Compass 3D", UsageTypes.CA|UsageTypes.CP);
                case 0x0084: return new Usage(this, id, "Orientation: Inclinometer 1D", UsageTypes.CA|UsageTypes.CP);
                case 0x0085: return new Usage(this, id, "Orientation: Inclinometer 2D", UsageTypes.CA|UsageTypes.CP);
                case 0x0086: return new Usage(this, id, "Orientation: Inclinometer 3D", UsageTypes.CA|UsageTypes.CP);
                case 0x0087: return new Usage(this, id, "Orientation: Distance 1D", UsageTypes.CA|UsageTypes.CP);
                case 0x0088: return new Usage(this, id, "Orientation: Distance 2D", UsageTypes.CA|UsageTypes.CP);
                case 0x0089: return new Usage(this, id, "Orientation: Distance 3D", UsageTypes.CA|UsageTypes.CP);
                case 0x008a: return new Usage(this, id, "Orientation: Device Orientation", UsageTypes.CA|UsageTypes.CP);
                case 0x008b: return new Usage(this, id, "Orientation: Compass", UsageTypes.CA|UsageTypes.CP);
                case 0x008c: return new Usage(this, id, "Orientation: Inclinometer", UsageTypes.CA|UsageTypes.CP);
                case 0x008d: return new Usage(this, id, "Orientation: Distance", UsageTypes.CA|UsageTypes.CP);
                case 0x008e: return new Usage(this, id, "Orientation: Relative Orientation", UsageTypes.CA|UsageTypes.CP);
                case 0x008f: return new Usage(this, id, "Orientation: Simple Orientation", UsageTypes.CA|UsageTypes.CP);
                case 0x0090: return new Usage(this, id, "Scanner", UsageTypes.CA|UsageTypes.CP);
                case 0x0091: return new Usage(this, id, "Scanner: Barcode", UsageTypes.CA|UsageTypes.CP);
                case 0x0092: return new Usage(this, id, "Scanner: RFID", UsageTypes.CA|UsageTypes.CP);
                case 0x0093: return new Usage(this, id, "Scanner: NFC", UsageTypes.CA|UsageTypes.CP);
                case 0x00a0: return new Usage(this, id, "Time", UsageTypes.CA|UsageTypes.CP);
                case 0x00a1: return new Usage(this, id, "Time: Alarm Timer", UsageTypes.CA|UsageTypes.CP);
                case 0x00a2: return new Usage(this, id, "Time: Real Time Clock", UsageTypes.CA|UsageTypes.CP);
                case 0x00b0: return new Usage(this, id, "Personal Activity", UsageTypes.CA|UsageTypes.CP);
                case 0x00b1: return new Usage(this, id, "Personal Activity: Activity Detection", UsageTypes.CA|UsageTypes.CP);
                case 0x00b2: return new Usage(this, id, "Personal Activity: Device Position", UsageTypes.CA|UsageTypes.CP);
                case 0x00b3: return new Usage(this, id, "Personal Activity: Pedometer", UsageTypes.CA|UsageTypes.CP);
                case 0x00b4: return new Usage(this, id, "Personal Activity: Step Detection", UsageTypes.CA|UsageTypes.CP);
                case 0x00c0: return new Usage(this, id, "Orientation Extended", UsageTypes.CA|UsageTypes.CP);
                case 0x00c1: return new Usage(this, id, "Orientation Extended: Geomagnetic Orientation", UsageTypes.CA|UsageTypes.CP);
                case 0x00c2: return new Usage(this, id, "Orientation Extended: Magnetometer", UsageTypes.CA|UsageTypes.CP);
                case 0x00d0: return new Usage(this, id, "Gesture", UsageTypes.CA|UsageTypes.CP);
                case 0x00d1: return new Usage(this, id, "Gesture: Chassis Flip Gesture", UsageTypes.CA|UsageTypes.CP);
                case 0x00d2: return new Usage(this, id, "Gesture: Hinge Fold Gesture", UsageTypes.CA|UsageTypes.CP);
                case 0x00e0: return new Usage(this, id, "Other", UsageTypes.CA|UsageTypes.CP);
                case 0x00e1: return new Usage(this, id, "Other: Custom", UsageTypes.CA|UsageTypes.CP);
                case 0x00e2: return new Usage(this, id, "Other: Generic", UsageTypes.CA|UsageTypes.CP);
                case 0x00e3: return new Usage(this, id, "Other: Generic Enumerator", UsageTypes.CA|UsageTypes.CP);
                case 0x00e4: return new Usage(this, id, "Other: Hinge Angle", UsageTypes.CA|UsageTypes.CP);
                case 0x0201: return new Usage(this, id, "Event: Sensor State", UsageTypes.NAry);
                case 0x0202: return new Usage(this, id, "Event: Sensor Event", UsageTypes.NAry);
                case 0x0301: return new Usage(this, id, "Property: Friendly Name", UsageTypes.SV);
                case 0x0302: return new Usage(this, id, "Property: Persistent Unique ID", UsageTypes.DV);
                case 0x0303: return new Usage(this, id, "Property: Sensor Status", UsageTypes.DV);
                case 0x0304: return new Usage(this, id, "Property: Minimum Report Interval", UsageTypes.SV);
                case 0x0305: return new Usage(this, id, "Property: Sensor Manufacturer", UsageTypes.SV);
                case 0x0306: return new Usage(this, id, "Property: Sensor Model", UsageTypes.SV);
                case 0x0307: return new Usage(this, id, "Property: Sensor Serial Number", UsageTypes.SV);
                case 0x0308: return new Usage(this, id, "Property: Sensor Description", UsageTypes.SV);
                case 0x0309: return new Usage(this, id, "Property: Sensor Connection Type", UsageTypes.NAry);
                case 0x030a: return new Usage(this, id, "Property: Sensor Device Path", UsageTypes.DV);
                case 0x030b: return new Usage(this, id, "Property: Sensor Hardware Revision", UsageTypes.SV);
                case 0x030c: return new Usage(this, id, "Property: Sensor Firmware Revision", UsageTypes.SV);
                case 0x030d: return new Usage(this, id, "Property: Release Date", UsageTypes.SV);
                case 0x030e: return new Usage(this, id, "Property: Report Interval", UsageTypes.DV);
                case 0x030f: return new Usage(this, id, "Property: Change Sensitivity Absolute", UsageTypes.DV);
                case 0x0310: return new Usage(this, id, "Property: Change Sensitivity Percent of Range", UsageTypes.DV);
                case 0x0311: return new Usage(this, id, "Property: Change Sensitivity Percent Relative", UsageTypes.DV);
                case 0x0312: return new Usage(this, id, "Property: Accuracy", UsageTypes.DV);
                case 0x0313: return new Usage(this, id, "Property: Resolution", UsageTypes.DV);
                case 0x0314: return new Usage(this, id, "Property: Maximum", UsageTypes.DV);
                case 0x0315: return new Usage(this, id, "Property: Minimum", UsageTypes.DV);
                case 0x0316: return new Usage(this, id, "Property: Reporting State", UsageTypes.NAry);
                case 0x0317: return new Usage(this, id, "Property: Sampling Rate", UsageTypes.DV);
                case 0x0318: return new Usage(this, id, "Property: Response Curve", UsageTypes.DV);
                case 0x0319: return new Usage(this, id, "Property: Power State", UsageTypes.NAry);
                case 0x031a: return new Usage(this, id, "Property: Maximum FIFO Events", UsageTypes.SV);
                case 0x031b: return new Usage(this, id, "Property: Report Latency", UsageTypes.DV);
                case 0x031c: return new Usage(this, id, "Property: Flush FIFO Events", UsageTypes.DF);
                case 0x031d: return new Usage(this, id, "Property: Maximum Power Consumption", UsageTypes.DV);
                case 0x0400: return new Usage(this, id, "Data Field: Location", UsageTypes.SV);
                case 0x0402: return new Usage(this, id, "Data Field: Altitude Antenna Sea Level", UsageTypes.SV);
                case 0x0403: return new Usage(this, id, "Data Field: Differential Reference Station ID", UsageTypes.SV);
                case 0x0404: return new Usage(this, id, "Data Field: Altitude Ellipsoid Error", UsageTypes.SV);
                case 0x0405: return new Usage(this, id, "Data Field: Altitude Ellipsoid", UsageTypes.SV);
                case 0x0406: return new Usage(this, id, "Data Field: Altitude Sea Level Error", UsageTypes.SV);
                case 0x0407: return new Usage(this, id, "Data Field: Altitude Sea Level", UsageTypes.SV);
                case 0x0408: return new Usage(this, id, "Data Field: Differential GPS Data Age", UsageTypes.SV);
                case 0x0409: return new Usage(this, id, "Data Field: Error Radius", UsageTypes.SV);
                case 0x040a: return new Usage(this, id, "Data Field: Fix Quality", UsageTypes.NAry);
                case 0x040b: return new Usage(this, id, "Data Field: Fix Type", UsageTypes.NAry);
                case 0x040c: return new Usage(this, id, "Data Field: Geoidal Separation", UsageTypes.SV);
                case 0x040d: return new Usage(this, id, "Data Field: GPS Operation Mode", UsageTypes.NAry);
                case 0x040e: return new Usage(this, id, "Data Field: GPS Selection Mode", UsageTypes.NAry);
                case 0x040f: return new Usage(this, id, "Data Field: GPS Status", UsageTypes.NAry);
                case 0x0410: return new Usage(this, id, "Data Field: Position Dilution of Precision", UsageTypes.SV);
                case 0x0411: return new Usage(this, id, "Data Field: Horizontal Dilution of Precision", UsageTypes.SV);
                case 0x0412: return new Usage(this, id, "Data Field: Vertical Dilution of Precision", UsageTypes.SV);
                case 0x0413: return new Usage(this, id, "Data Field: Latitude", UsageTypes.SV);
                case 0x0414: return new Usage(this, id, "Data Field: Longitude", UsageTypes.SV);
                case 0x0415: return new Usage(this, id, "Data Field: True Heading", UsageTypes.SV);
                case 0x0416: return new Usage(this, id, "Data Field: Magnetic Heading", UsageTypes.SV);
                case 0x0417: return new Usage(this, id, "Data Field: Magnetic Variation", UsageTypes.SV);
                case 0x0418: return new Usage(this, id, "Data Field: Speed", UsageTypes.SV);
                case 0x0419: return new Usage(this, id, "Data Field: Satellites in View", UsageTypes.SV);
                case 0x041a: return new Usage(this, id, "Data Field: Satellites in View Azimuth", UsageTypes.SV);
                case 0x041b: return new Usage(this, id, "Data Field: Satellites in View Elevation", UsageTypes.SV);
                case 0x041c: return new Usage(this, id, "Data Field: Satellites in View IDs", UsageTypes.SV);
                case 0x041d: return new Usage(this, id, "Data Field: Satellites in View PRNs", UsageTypes.SV);
                case 0x041e: return new Usage(this, id, "Data Field: Satellites in View S/N Ratios", UsageTypes.SV);
                case 0x041f: return new Usage(this, id, "Data Field: Satellites Used Count", UsageTypes.SV);
                case 0x0420: return new Usage(this, id, "Data Field: Satellites Used PRNs", UsageTypes.SV);
                case 0x0421: return new Usage(this, id, "Data Field: NMEA Sentence", UsageTypes.SV);
                case 0x0422: return new Usage(this, id, "Data Field: Address Line 1", UsageTypes.SV);
                case 0x0423: return new Usage(this, id, "Data Field: Address Line 2", UsageTypes.SV);
                case 0x0424: return new Usage(this, id, "Data Field: City", UsageTypes.SV);
                case 0x0425: return new Usage(this, id, "Data Field: State or Province", UsageTypes.SV);
                case 0x0426: return new Usage(this, id, "Data Field: Country or Region (ISO 3166)", UsageTypes.SV);
                case 0x0427: return new Usage(this, id, "Data Field: Postal Code", UsageTypes.SV);
                case 0x042b: return new Usage(this, id, "Property: Location Desired Accuracy", UsageTypes.NAry);
                case 0x0430: return new Usage(this, id, "Data Field: Environmental", UsageTypes.SV);
                case 0x0431: return new Usage(this, id, "Data Field: Atmospheric Pressure", UsageTypes.SV);
                case 0x0433: return new Usage(this, id, "Data Field: Relative Humidity", UsageTypes.SV);
                case 0x0434: return new Usage(this, id, "Data Field: Temperature", UsageTypes.SV);
                case 0x0435: return new Usage(this, id, "Data Field: Wind Direction", UsageTypes.SV);
                case 0x0436: return new Usage(this, id, "Data Field: Wind Speed", UsageTypes.SV);
                case 0x0437: return new Usage(this, id, "Data Field: Air Quality Index", UsageTypes.SV);
                case 0x0438: return new Usage(this, id, "Data Field: Equivalent CO2", UsageTypes.SV);
                case 0x0439: return new Usage(this, id, "Data Field: Volatile Organic Compound Concentration", UsageTypes.SV);
                case 0x0440: return new Usage(this, id, "Property: Environmental", UsageTypes.SV);
                case 0x0441: return new Usage(this, id, "Property: Reference Pressure (default Sel \"Unit: bars)", UsageTypes.SV);
                case 0x0450: return new Usage(this, id, "Data Field: Motion", UsageTypes.SV);
                case 0x0451: return new Usage(this, id, "Data Field: Motion State", UsageTypes.SF);
                case 0x0452: return new Usage(this, id, "Data Field: Acceleration", UsageTypes.SV);
                case 0x0453: return new Usage(this, id, "Data Field: Acceleration Axis X", UsageTypes.SV);
                case 0x0454: return new Usage(this, id, "Data Field: Acceleration Axis Y", UsageTypes.SV);
                case 0x0455: return new Usage(this, id, "Data Field: Acceleration Axis Z", UsageTypes.SV);
                case 0x0456: return new Usage(this, id, "Data Field: Angular Velocity", UsageTypes.SV);
                case 0x0457: return new Usage(this, id, "Data Field: Angular Velocity X about Axis", UsageTypes.SV);
                case 0x0458: return new Usage(this, id, "Data Field: Angular Velocity Y about Axis", UsageTypes.SV);
                case 0x0459: return new Usage(this, id, "Data Field: Angular Velocity Z about Axis", UsageTypes.SV);
                case 0x045a: return new Usage(this, id, "Data Field: Angular Position", UsageTypes.SV);
                case 0x045b: return new Usage(this, id, "Data Field: Angular Position about X Axis", UsageTypes.SV);
                case 0x045c: return new Usage(this, id, "Data Field: Angular Position about Y Axis", UsageTypes.SV);
                case 0x045d: return new Usage(this, id, "Data Field: Angular Position about Z Axis", UsageTypes.SV);
                case 0x045e: return new Usage(this, id, "Data Field: Motion Speed", UsageTypes.SV);
                case 0x045f: return new Usage(this, id, "Data Field: Motion Intensity (percent)", UsageTypes.SV);
                case 0x0470: return new Usage(this, id, "Data Field: Orientation", UsageTypes.SV);
                case 0x0471: return new Usage(this, id, "Data Field: Heading", UsageTypes.SV);
                case 0x0472: return new Usage(this, id, "Data Field: Heading X Axis", UsageTypes.SV);
                case 0x0473: return new Usage(this, id, "Data Field: Heading Y Axis", UsageTypes.SV);
                case 0x0474: return new Usage(this, id, "Data Field: Heading Z Axis", UsageTypes.SV);
                case 0x0475: return new Usage(this, id, "Data Field: Heading Compensated Magnetic North", UsageTypes.SV);
                case 0x0476: return new Usage(this, id, "Data Field: Heading Compensated True North", UsageTypes.SV);
                case 0x0477: return new Usage(this, id, "Data Field: Heading Magnetic North", UsageTypes.SV);
                case 0x0478: return new Usage(this, id, "Data Field: Heading True North", UsageTypes.SV);
                case 0x0479: return new Usage(this, id, "Data Field: Distance", UsageTypes.SV);
                case 0x047a: return new Usage(this, id, "Data Field: Distance X Axis", UsageTypes.SV);
                case 0x047b: return new Usage(this, id, "Data Field: Distance Y Axis", UsageTypes.SV);
                case 0x047c: return new Usage(this, id, "Data Field: Distance Z Axis", UsageTypes.SV);
                case 0x047d: return new Usage(this, id, "Data Field: Distance Out-of-Range", UsageTypes.SV);
                case 0x047e: return new Usage(this, id, "Data Field: Tilt", UsageTypes.SV);
                case 0x047f: return new Usage(this, id, "Data Field: Tilt X Axis", UsageTypes.SV);
                case 0x0480: return new Usage(this, id, "Data Field: Tilt Y Axis", UsageTypes.SV);
                case 0x0481: return new Usage(this, id, "Data Field: Tilt Z Axis", UsageTypes.SV);
                case 0x0482: return new Usage(this, id, "Data Field: Rotation Matrix", UsageTypes.SV);
                case 0x0483: return new Usage(this, id, "Data Field: Quaternion", UsageTypes.SV);
                case 0x0484: return new Usage(this, id, "Data Field: Magnetic Flux", UsageTypes.SV);
                case 0x0485: return new Usage(this, id, "Data Field: Magnetic Flux X Axis", UsageTypes.SV);
                case 0x0486: return new Usage(this, id, "Data Field: Magnetic Flux Y Axis", UsageTypes.SV);
                case 0x0487: return new Usage(this, id, "Data Field: Magnetic Flux Z Axis", UsageTypes.SV);
                case 0x0488: return new Usage(this, id, "Data Field: Magnetometer Accuracy", UsageTypes.NAry);
                case 0x0489: return new Usage(this, id, "Data Field: Simple Orientation Direction", UsageTypes.NAry);
                case 0x0490: return new Usage(this, id, "Data Field: Mechanical", UsageTypes.SV);
                case 0x0491: return new Usage(this, id, "Data Field: Boolean Switch State", UsageTypes.SF);
                case 0x0492: return new Usage(this, id, "Data Field: Boolean Switch Array States", UsageTypes.SV);
                case 0x0493: return new Usage(this, id, "Data Field: Multivalue Switch Value", UsageTypes.SV);
                case 0x0494: return new Usage(this, id, "Data Field: Force", UsageTypes.SV);
                case 0x0495: return new Usage(this, id, "Data Field: Absolute Pressure", UsageTypes.SV);
                case 0x0496: return new Usage(this, id, "Data Field: Gauge Pressure", UsageTypes.SV);
                case 0x0497: return new Usage(this, id, "Data Field: Strain", UsageTypes.SV);
                case 0x0498: return new Usage(this, id, "Data Field: Weight", UsageTypes.SV);
                case 0x04a0: return new Usage(this, id, "Property: Mechanical", UsageTypes.SV);
                case 0x04a1: return new Usage(this, id, "Property: Vibration State", UsageTypes.SV);
                case 0x04a2: return new Usage(this, id, "Property: Forward Vibration Speed (percent)", UsageTypes.SV);
                case 0x04a3: return new Usage(this, id, "Property: Backward Vibration Speed (percent)", UsageTypes.SV);
                case 0x04b0: return new Usage(this, id, "Data Field: Biometric", UsageTypes.SV);
                case 0x04b1: return new Usage(this, id, "Data Field: Human Presence", UsageTypes.SF);
                case 0x04b2: return new Usage(this, id, "Data Field: Human Proximity Range", UsageTypes.SV);
                case 0x04b3: return new Usage(this, id, "Data Field: Human Proximity Out of Range", UsageTypes.SF);
                case 0x04b4: return new Usage(this, id, "Data Field: Human Touch State", UsageTypes.SF);
                case 0x04b5: return new Usage(this, id, "Data Field: Blood Pressure", UsageTypes.SV);
                case 0x04b6: return new Usage(this, id, "Data Field: Blood Pressure Diastolic", UsageTypes.SV);
                case 0x04b7: return new Usage(this, id, "Data Field: Blood Pressure Systolic", UsageTypes.SV);
                case 0x04b8: return new Usage(this, id, "Data Field: Heart Rate (HeartbeatsPM)", UsageTypes.SV);
                case 0x04b9: return new Usage(this, id, "Data Field: Resting Heart Rate (HeartbeatsPM)", UsageTypes.SV);
                case 0x04ba: return new Usage(this, id, "Data Field: Heartbeat Interval", UsageTypes.SV);
                case 0x04bb: return new Usage(this, id, "Data Field: Respiratory Rate", UsageTypes.SV);
                case 0x04bc: return new Usage(this, id, "Data Field: SpO2 (percent)", UsageTypes.SV);
                case 0x04d0: return new Usage(this, id, "Data Field: Light", UsageTypes.SV);
                case 0x04d1: return new Usage(this, id, "Data Field: Illuminance", UsageTypes.SV);
                case 0x04d2: return new Usage(this, id, "Data Field: Color Temperature", UsageTypes.SV);
                case 0x04d3: return new Usage(this, id, "Data Field: Chromaticity", UsageTypes.SV);
                case 0x04d4: return new Usage(this, id, "Data Field: Chromaticity X", UsageTypes.SV);
                case 0x04d5: return new Usage(this, id, "Data Field: Chromaticity Y", UsageTypes.SV);
                case 0x04d6: return new Usage(this, id, "Data Field: Consumer IR Sentence Receive", UsageTypes.SV);
                case 0x04d7: return new Usage(this, id, "Data Field: Infrared Light", UsageTypes.SV);
                case 0x04d8: return new Usage(this, id, "Data Field: Red Light", UsageTypes.SV);
                case 0x04d9: return new Usage(this, id, "Data Field: Green Light", UsageTypes.SV);
                case 0x04da: return new Usage(this, id, "Data Field: Blue Light", UsageTypes.SV);
                case 0x04db: return new Usage(this, id, "Data Field: Ultraviolet A Light", UsageTypes.SV);
                case 0x04dc: return new Usage(this, id, "Data Field: Ultraviolet B Light", UsageTypes.SV);
                case 0x04dd: return new Usage(this, id, "Data Field: Ultraviolet Index", UsageTypes.SV);
                case 0x04e0: return new Usage(this, id, "Property: Light", UsageTypes.DV);
                case 0x04e1: return new Usage(this, id, "Property: Consumer IR Sentence Send", UsageTypes.DV);
                case 0x04f0: return new Usage(this, id, "Data Field: Scanner", UsageTypes.SV);
                case 0x04f1: return new Usage(this, id, "Data Field: RFID Tag 40 Bit", UsageTypes.SV);
                case 0x04f2: return new Usage(this, id, "Data Field: NFC Sentence Receive", UsageTypes.SV);
                case 0x04f8: return new Usage(this, id, "Property: Scanner", UsageTypes.SV);
                case 0x04f9: return new Usage(this, id, "Property: NFC Sentence Send", UsageTypes.SV);
                case 0x0500: return new Usage(this, id, "Data Field: Electrical", UsageTypes.SV);
                case 0x0501: return new Usage(this, id, "Data Field: Capacitance", UsageTypes.SV);
                case 0x0502: return new Usage(this, id, "Data Field: Current", UsageTypes.SV);
                case 0x0503: return new Usage(this, id, "Data Field: Electrical Power", UsageTypes.SV);
                case 0x0504: return new Usage(this, id, "Data Field: Inductance", UsageTypes.SV);
                case 0x0505: return new Usage(this, id, "Data Field: Resistance", UsageTypes.SV);
                case 0x0506: return new Usage(this, id, "Data Field: Voltage", UsageTypes.SV);
                case 0x0507: return new Usage(this, id, "Data Field: Frequency", UsageTypes.SV);
                case 0x0508: return new Usage(this, id, "Data Field: Period", UsageTypes.SV);
                case 0x0509: return new Usage(this, id, "Data Field: Percent of Range", UsageTypes.SV);
                case 0x0520: return new Usage(this, id, "Data Field: Time", UsageTypes.SV);
                case 0x0521: return new Usage(this, id, "Data Field: Year", UsageTypes.SV);
                case 0x0522: return new Usage(this, id, "Data Field: Month", UsageTypes.SV);
                case 0x0523: return new Usage(this, id, "Data Field: Day", UsageTypes.SV);
                case 0x0524: return new Usage(this, id, "Data Field: Day of Week", UsageTypes.NAry);
                case 0x0526: return new Usage(this, id, "Data Field: Minute", UsageTypes.SV);
                case 0x0527: return new Usage(this, id, "Data Field: Second", UsageTypes.SV);
                case 0x0528: return new Usage(this, id, "Data Field: Millisecond", UsageTypes.SV);
                case 0x0529: return new Usage(this, id, "Data Field: Timestamp", UsageTypes.SV);
                case 0x052a: return new Usage(this, id, "Data Field: Julian Day of Year", UsageTypes.SV);
                case 0x052b: return new Usage(this, id, "Data Field: Time Since System Boot", UsageTypes.SV);
                case 0x0530: return new Usage(this, id, "Property: Time", UsageTypes.DV);
                case 0x0531: return new Usage(this, id, "Property: Time Zone Offset from UTC", UsageTypes.DV);
                case 0x0532: return new Usage(this, id, "Property: Time Zone Name", UsageTypes.DV);
                case 0x0533: return new Usage(this, id, "Property: Daylight Savings Time Observed", UsageTypes.DF);
                case 0x0534: return new Usage(this, id, "Property: Time Trim Adjustment", UsageTypes.DV);
                case 0x0535: return new Usage(this, id, "Property: Arm Alarm", UsageTypes.DF);
                case 0x0540: return new Usage(this, id, "Data Field: Custom", UsageTypes.SV);
                case 0x0541: return new Usage(this, id, "Data Field: Custom Usage", UsageTypes.SV);
                case 0x0542: return new Usage(this, id, "Data Field: Custom Boolean Array", UsageTypes.SV);
                case 0x0543: return new Usage(this, id, "Data Field: Custom Value", UsageTypes.SV);
                case 0x0544: return new Usage(this, id, "Data Field: Custom Value 1", UsageTypes.SV);
                case 0x0545: return new Usage(this, id, "Data Field: Custom Value 2", UsageTypes.SV);
                case 0x0546: return new Usage(this, id, "Data Field: Custom Value 3", UsageTypes.SV);
                case 0x0547: return new Usage(this, id, "Data Field: Custom Value 4", UsageTypes.SV);
                case 0x0548: return new Usage(this, id, "Data Field: Custom Value 5", UsageTypes.SV);
                case 0x0549: return new Usage(this, id, "Data Field: Custom Value 6", UsageTypes.SV);
                case 0x054a: return new Usage(this, id, "Data Field: Custom Value 7", UsageTypes.SV);
                case 0x054b: return new Usage(this, id, "Data Field: Custom Value 8", UsageTypes.SV);
                case 0x054c: return new Usage(this, id, "Data Field: Custom Value 9", UsageTypes.SV);
                case 0x054d: return new Usage(this, id, "Data Field: Custom Value 10", UsageTypes.SV);
                case 0x054e: return new Usage(this, id, "Data Field: Custom Value 11", UsageTypes.SV);
                case 0x054f: return new Usage(this, id, "Data Field: Custom Value 12", UsageTypes.SV);
                case 0x0550: return new Usage(this, id, "Data Field: Custom Value 13", UsageTypes.SV);
                case 0x0551: return new Usage(this, id, "Data Field: Custom Value 14", UsageTypes.SV);
                case 0x0552: return new Usage(this, id, "Data Field: Custom Value 15", UsageTypes.SV);
                case 0x0553: return new Usage(this, id, "Data Field: Custom Value 16", UsageTypes.SV);
                case 0x0560: return new Usage(this, id, "Data Field: Generic", UsageTypes.SV);
                case 0x0561: return new Usage(this, id, "Data Field: Generic GUID or PROPERTYKEY", UsageTypes.SV);
                case 0x0562: return new Usage(this, id, "Data Field: Generic Category GUID", UsageTypes.SV);
                case 0x0563: return new Usage(this, id, "Data Field: Generic Type GUID", UsageTypes.SV);
                case 0x0564: return new Usage(this, id, "Data Field: Generic Event PROPERTYKEY", UsageTypes.SV);
                case 0x0565: return new Usage(this, id, "Data Field: Generic Property PROPERTYKEY", UsageTypes.SV);
                case 0x0566: return new Usage(this, id, "Data Field: Generic Data Field PROPERTYKEY", UsageTypes.SV);
                case 0x0567: return new Usage(this, id, "Data Field: Generic Event", UsageTypes.SV);
                case 0x0568: return new Usage(this, id, "Data Field: Generic Property", UsageTypes.SV);
                case 0x0569: return new Usage(this, id, "Data Field: Generic Data Field", UsageTypes.SV);
                case 0x056a: return new Usage(this, id, "Data Field: Enumerator Table Row Index", UsageTypes.SV);
                case 0x056b: return new Usage(this, id, "Data Field: Enumerator Table Row Count", UsageTypes.SV);
                case 0x056c: return new Usage(this, id, "Data Field: Generic GUID or PROPERTYKEY kind", UsageTypes.NAry);
                case 0x056d: return new Usage(this, id, "Data Field: Generic GUID", UsageTypes.SV);
                case 0x056e: return new Usage(this, id, "Data Field: Generic PROPERTYKEY", UsageTypes.SV);
                case 0x056f: return new Usage(this, id, "Data Field: Generic Top Level Collection ID", UsageTypes.SV);
                case 0x0570: return new Usage(this, id, "Data Field: Generic Report ID", UsageTypes.SV);
                case 0x0571: return new Usage(this, id, "Data Field: Generic Report Item Position Index", UsageTypes.SV);
                case 0x0572: return new Usage(this, id, "Data Field: Generic Firmware VARTYPE", UsageTypes.NAry);
                case 0x0573: return new Usage(this, id, "Data Field: Generic Unit of Measure", UsageTypes.NAry);
                case 0x0574: return new Usage(this, id, "Data Field: Generic Unit Exponent", UsageTypes.NAry);
                case 0x0575: return new Usage(this, id, "Data Field: Generic Report Size", UsageTypes.SV);
                case 0x0576: return new Usage(this, id, "Data Field: Generic Report Count", UsageTypes.SV);
                case 0x0580: return new Usage(this, id, "Property: Generic", UsageTypes.DV);
                case 0x0581: return new Usage(this, id, "Property: Enumerator Table Row Index", UsageTypes.DV);
                case 0x0582: return new Usage(this, id, "Property: Enumerator Table Row Count", UsageTypes.SV);
                case 0x0590: return new Usage(this, id, "Data Field: Personal Activity", UsageTypes.SV);
                case 0x0591: return new Usage(this, id, "Data Field: Activity Type", UsageTypes.NAry);
                case 0x0592: return new Usage(this, id, "Data Field: Activity State", UsageTypes.NAry);
                case 0x0593: return new Usage(this, id, "Data Field: Device Position", UsageTypes.NAry);
                case 0x0594: return new Usage(this, id, "Data Field: Step Count", UsageTypes.SV);
                case 0x0595: return new Usage(this, id, "Data Field: Step Count Reset", UsageTypes.DF);
                case 0x0596: return new Usage(this, id, "Data Field: Step Duration", UsageTypes.SV);
                case 0x0597: return new Usage(this, id, "Data Field: Step Type", UsageTypes.NAry);
                case 0x05a0: return new Usage(this, id, "Property: Minimum Activity Detection Interval", UsageTypes.DV);
                case 0x05a1: return new Usage(this, id, "Property: Supported Activity Types", UsageTypes.NAry);
                case 0x05a2: return new Usage(this, id, "Property: Subscribed Activity Types", UsageTypes.NAry);
                case 0x05a3: return new Usage(this, id, "Property: Supported Step Types", UsageTypes.NAry);
                case 0x05a4: return new Usage(this, id, "Property: Subscribed Step Types", UsageTypes.NAry);
                case 0x05a5: return new Usage(this, id, "Property: Floor Height", UsageTypes.DV);
                case 0x05b0: return new Usage(this, id, "Data Field: Custom Type ID", UsageTypes.SV);
                case 0x05e0: return new Usage(this, id, "Data Field: Hinge", UsageTypes.SV|UsageTypes.DV);
                case 0x05e1: return new Usage(this, id, "Data Field: Hinge Angle", UsageTypes.SV|UsageTypes.DV);
                case 0x05f0: return new Usage(this, id, "Data Field: Gesture Sensor", UsageTypes.SV);
                case 0x05f1: return new Usage(this, id, "Data Field: Gesture State", UsageTypes.NAry);
                case 0x05f2: return new Usage(this, id, "Data Field: Hinge Fold Initial Angle", UsageTypes.SV);
                case 0x05f3: return new Usage(this, id, "Data Field: Hinge Fold Final Angle", UsageTypes.SV);
                case 0x05f4: return new Usage(this, id, "Data Field: Hinge Fold Contributing Panel", UsageTypes.NAry);
                case 0x05f5: return new Usage(this, id, "Data Field: Hinge Fold Type", UsageTypes.NAry);
                case 0x0800: return new Usage(this, id, "Sensor State: Undefined", UsageTypes.Sel);
                case 0x0801: return new Usage(this, id, "Sensor State: Ready", UsageTypes.Sel);
                case 0x0802: return new Usage(this, id, "Sensor State: Not Available", UsageTypes.Sel);
                case 0x0803: return new Usage(this, id, "Sensor State: No Data", UsageTypes.Sel);
                case 0x0804: return new Usage(this, id, "Sensor State: Initializing", UsageTypes.Sel);
                case 0x0805: return new Usage(this, id, "Sensor State: Access Denied", UsageTypes.Sel);
                case 0x0806: return new Usage(this, id, "Sensor State: Error", UsageTypes.Sel);
                case 0x0810: return new Usage(this, id, "Sensor Event: Unknown", UsageTypes.Sel);
                case 0x0811: return new Usage(this, id, "Sensor Event: State Changed", UsageTypes.Sel);
                case 0x0812: return new Usage(this, id, "Sensor Event: Property Changed", UsageTypes.Sel);
                case 0x0813: return new Usage(this, id, "Sensor Event: Data Updated", UsageTypes.Sel);
                case 0x0814: return new Usage(this, id, "Sensor Event: Poll Response", UsageTypes.Sel);
                case 0x0815: return new Usage(this, id, "Sensor Event: Change Sensitivity", UsageTypes.Sel);
                case 0x0816: return new Usage(this, id, "Sensor Event: Range Maximum Reached", UsageTypes.Sel);
                case 0x0817: return new Usage(this, id, "Sensor Event: Range Minimum Reached", UsageTypes.Sel);
                case 0x0818: return new Usage(this, id, "Sensor Event: High Threshold Cross Upward", UsageTypes.Sel);
                case 0x0819: return new Usage(this, id, "Sensor Event: High Threshold Cross Downward", UsageTypes.Sel);
                case 0x081a: return new Usage(this, id, "Sensor Event: Low Threshold Cross Upward", UsageTypes.Sel);
                case 0x081b: return new Usage(this, id, "Sensor Event: Low Threshold Cross Downward", UsageTypes.Sel);
                case 0x081c: return new Usage(this, id, "Sensor Event: Zero Threshold Cross Upward", UsageTypes.Sel);
                case 0x081d: return new Usage(this, id, "Sensor Event: Zero Threshold Cross Downward", UsageTypes.Sel);
                case 0x081e: return new Usage(this, id, "Sensor Event: Period Exceeded", UsageTypes.Sel);
                case 0x081f: return new Usage(this, id, "Sensor Event: Frequency Exceeded", UsageTypes.Sel);
                case 0x0820: return new Usage(this, id, "Sensor Event: Complex Trigger", UsageTypes.Sel);
                case 0x0830: return new Usage(this, id, "Connection Type: Integrated", UsageTypes.Sel);
                case 0x0831: return new Usage(this, id, "Connection Type: Attached", UsageTypes.Sel);
                case 0x0832: return new Usage(this, id, "Connection Type: External", UsageTypes.Sel);
                case 0x0840: return new Usage(this, id, "Reporting State: Report No Events", UsageTypes.Sel);
                case 0x0841: return new Usage(this, id, "Reporting State: Report All Events", UsageTypes.Sel);
                case 0x0842: return new Usage(this, id, "Reporting State: Report Threshold Events", UsageTypes.Sel);
                case 0x0843: return new Usage(this, id, "Reporting State: Wake On No Events", UsageTypes.Sel);
                case 0x0844: return new Usage(this, id, "Reporting State: Wake On All Events", UsageTypes.Sel);
                case 0x0845: return new Usage(this, id, "Reporting State: Wake On Threshold Events", UsageTypes.Sel);
                case 0x0850: return new Usage(this, id, "Power State: Undefined", UsageTypes.Sel);
                case 0x0851: return new Usage(this, id, "Power State: D0 Full Power", UsageTypes.Sel);
                case 0x0852: return new Usage(this, id, "Power State: D1 Low Power", UsageTypes.Sel);
                case 0x0853: return new Usage(this, id, "Power State: D2 Standby Power with Wakeup", UsageTypes.Sel);
                case 0x0854: return new Usage(this, id, "Power State: D3 Sleep with Wakeup", UsageTypes.Sel);
                case 0x0855: return new Usage(this, id, "Power State: D4 Power Off", UsageTypes.Sel);
                case 0x0860: return new Usage(this, id, "Accuracy: Default", UsageTypes.Sel);
                case 0x0861: return new Usage(this, id, "Accuracy: High", UsageTypes.Sel);
                case 0x0862: return new Usage(this, id, "Accuracy: Medium", UsageTypes.Sel);
                case 0x0863: return new Usage(this, id, "Accuracy: Low", UsageTypes.Sel);
                case 0x0870: return new Usage(this, id, "Fix Quality: No Fix", UsageTypes.Sel);
                case 0x0871: return new Usage(this, id, "Fix Quality: GPS", UsageTypes.Sel);
                case 0x0872: return new Usage(this, id, "Fix Quality: DGPS", UsageTypes.Sel);
                case 0x0880: return new Usage(this, id, "Fix Type: No Fix", UsageTypes.Sel);
                case 0x0881: return new Usage(this, id, "Fix Type: GPS SPS Mode, Fix Valid", UsageTypes.Sel);
                case 0x0882: return new Usage(this, id, "Fix Type: DGPS SPS Mode, Fix Valid", UsageTypes.Sel);
                case 0x0883: return new Usage(this, id, "Fix Type: GPS PPS Mode, Fix Valid", UsageTypes.Sel);
                case 0x0884: return new Usage(this, id, "Fix Type: Real Time Kinematic", UsageTypes.Sel);
                case 0x0885: return new Usage(this, id, "Fix Type: Float RTK", UsageTypes.Sel);
                case 0x0886: return new Usage(this, id, "Fix Type: Estimated (dead reckoned)", UsageTypes.Sel);
                case 0x0887: return new Usage(this, id, "Fix Type: Manual Input Mode", UsageTypes.Sel);
                case 0x0888: return new Usage(this, id, "Fix Type: Simulator Mode", UsageTypes.Sel);
                case 0x0890: return new Usage(this, id, "GPS Operation Mode: Manual", UsageTypes.Sel);
                case 0x0891: return new Usage(this, id, "GPS Operation Mode: Automatic", UsageTypes.Sel);
                case 0x08a0: return new Usage(this, id, "GPS Selection Mode: Autonomous", UsageTypes.Sel);
                case 0x08a1: return new Usage(this, id, "GPS Selection Mode: DGPS", UsageTypes.Sel);
                case 0x08a2: return new Usage(this, id, "GPS Selection Mode: Estimated (dead reckoned)", UsageTypes.Sel);
                case 0x08a3: return new Usage(this, id, "GPS Selection Mode: Manual Input", UsageTypes.Sel);
                case 0x08a4: return new Usage(this, id, "GPS Selection Mode: Simulator", UsageTypes.Sel);
                case 0x08a5: return new Usage(this, id, "GPS Selection Mode: Data Not Valid", UsageTypes.Sel);
                case 0x08b0: return new Usage(this, id, "GPS Status: Data Valid", UsageTypes.Sel);
                case 0x08b1: return new Usage(this, id, "GPS Status: Data Not Valid", UsageTypes.Sel);
                case 0x08c0: return new Usage(this, id, "Day of Week: Sunday", UsageTypes.Sel);
                case 0x08c1: return new Usage(this, id, "Day of Week: Monday", UsageTypes.Sel);
                case 0x08c2: return new Usage(this, id, "Day of Week: Tuesday", UsageTypes.Sel);
                case 0x08c3: return new Usage(this, id, "Day of Week: Wednesday", UsageTypes.Sel);
                case 0x08c4: return new Usage(this, id, "Day of Week: Thursday", UsageTypes.Sel);
                case 0x08c5: return new Usage(this, id, "Day of Week: Friday", UsageTypes.Sel);
                case 0x08c6: return new Usage(this, id, "Day of Week: Saturday", UsageTypes.Sel);
                case 0x08d0: return new Usage(this, id, "Kind: Category", UsageTypes.Sel);
                case 0x08d1: return new Usage(this, id, "Kind: Type", UsageTypes.Sel);
                case 0x08d2: return new Usage(this, id, "Kind: Event", UsageTypes.Sel);
                case 0x08d3: return new Usage(this, id, "Kind: Property", UsageTypes.Sel);
                case 0x08d4: return new Usage(this, id, "Kind: Data Field", UsageTypes.Sel);
                case 0x08e0: return new Usage(this, id, "Magnetometer Accuracy: Low", UsageTypes.Sel);
                case 0x08e1: return new Usage(this, id, "Magnetometer Accuracy: Medium", UsageTypes.Sel);
                case 0x08e2: return new Usage(this, id, "Magnetometer Accuracy: High", UsageTypes.Sel);
                case 0x08f0: return new Usage(this, id, "Simple Orientation Direction: Not Rotated", UsageTypes.Sel);
                case 0x08f1: return new Usage(this, id, "Simple Orientation Direction: Rotated 90 Degrees CCW", UsageTypes.Sel);
                case 0x08f2: return new Usage(this, id, "Simple Orientation Direction: Rotated 180 Degrees CCW", UsageTypes.Sel);
                case 0x08f3: return new Usage(this, id, "Simple Orientation Direction: Rotated 270 Degrees CCW", UsageTypes.Sel);
                case 0x08f4: return new Usage(this, id, "Simple Orientation Direction: Face Up", UsageTypes.Sel);
                case 0x08f5: return new Usage(this, id, "Simple Orientation Direction: Face Down", UsageTypes.Sel);
                case 0x0900: return new Usage(this, id, "VT_NULL: Empty", UsageTypes.Sel);
                case 0x0901: return new Usage(this, id, "VT_BOOL: Boolean", UsageTypes.Sel);
                case 0x0902: return new Usage(this, id, "VT_UI1: Byte", UsageTypes.Sel);
                case 0x0903: return new Usage(this, id, "VT_I1: Character", UsageTypes.Sel);
                case 0x0904: return new Usage(this, id, "VT_UI2: Unsigned Short", UsageTypes.Sel);
                case 0x0905: return new Usage(this, id, "VT_I2: Short", UsageTypes.Sel);
                case 0x0906: return new Usage(this, id, "VT_UI4: Unsigned Long", UsageTypes.Sel);
                case 0x0907: return new Usage(this, id, "VT_I4: Long", UsageTypes.Sel);
                case 0x0908: return new Usage(this, id, "VT_UI8: Unsigned Long Long", UsageTypes.Sel);
                case 0x0909: return new Usage(this, id, "VT_I8: Long Long", UsageTypes.Sel);
                case 0x090a: return new Usage(this, id, "VT_R4: Float", UsageTypes.Sel);
                case 0x090b: return new Usage(this, id, "VT_R8: Double", UsageTypes.Sel);
                case 0x090c: return new Usage(this, id, "VT_WSTR: Wide String", UsageTypes.Sel);
                case 0x090d: return new Usage(this, id, "VT_STR: Narrow String", UsageTypes.Sel);
                case 0x090e: return new Usage(this, id, "VT_CLSID: Guid", UsageTypes.Sel);
                case 0x090f: return new Usage(this, id, "VT_VECTOR|VT_UI1: Opaque Structure", UsageTypes.Sel);
                case 0x0910: return new Usage(this, id, "VT_F16E0: HID 16-bit Float e0", UsageTypes.Sel);
                case 0x0911: return new Usage(this, id, "VT_F16E1: HID 16-bit Float e1", UsageTypes.Sel);
                case 0x0912: return new Usage(this, id, "VT_F16E2: HID 16-bit Float e2", UsageTypes.Sel);
                case 0x0913: return new Usage(this, id, "VT_F16E3: HID 16-bit Float e3", UsageTypes.Sel);
                case 0x0914: return new Usage(this, id, "VT_F16E4: HID 16-bit Float e4", UsageTypes.Sel);
                case 0x0915: return new Usage(this, id, "VT_F16E5: HID 16-bit Float e5", UsageTypes.Sel);
                case 0x0916: return new Usage(this, id, "VT_F16E6: HID 16-bit Float e6", UsageTypes.Sel);
                case 0x0917: return new Usage(this, id, "VT_F16E7: HID 16-bit Float e7", UsageTypes.Sel);
                case 0x0918: return new Usage(this, id, "VT_F16E8: HID 16-bit Float e-8", UsageTypes.Sel);
                case 0x0919: return new Usage(this, id, "VT_F16E9: HID 16-bit Float e-7", UsageTypes.Sel);
                case 0x091a: return new Usage(this, id, "VT_F16EA: HID 16-bit Float e-6", UsageTypes.Sel);
                case 0x091b: return new Usage(this, id, "VT_F16EB: HID 16-bit Float e-5", UsageTypes.Sel);
                case 0x091c: return new Usage(this, id, "VT_F16EC: HID 16-bit Float e-4", UsageTypes.Sel);
                case 0x091d: return new Usage(this, id, "VT_F16ED: HID 16-bit Float e-3", UsageTypes.Sel);
                case 0x091e: return new Usage(this, id, "VT_F16EE: HID 16-bit Float e-2", UsageTypes.Sel);
                case 0x091f: return new Usage(this, id, "VT_F16EF: HID 16-bit Float e-1", UsageTypes.Sel);
                case 0x0920: return new Usage(this, id, "VT_F32E0: HID 32-bit Float e0", UsageTypes.Sel);
                case 0x0921: return new Usage(this, id, "VT_F32E1: HID 32-bit Float e1", UsageTypes.Sel);
                case 0x0922: return new Usage(this, id, "VT_F32E2: HID 32-bit Float e2", UsageTypes.Sel);
                case 0x0923: return new Usage(this, id, "VT_F32E3: HID 32-bit Float e3", UsageTypes.Sel);
                case 0x0924: return new Usage(this, id, "VT_F32E4: HID 32-bit Float e4", UsageTypes.Sel);
                case 0x0925: return new Usage(this, id, "VT_F32E5: HID 32-bit Float e5", UsageTypes.Sel);
                case 0x0926: return new Usage(this, id, "VT_F32E6: HID 32-bit Float e6", UsageTypes.Sel);
                case 0x0927: return new Usage(this, id, "VT_F32E7: HID 32-bit Float e7", UsageTypes.Sel);
                case 0x0928: return new Usage(this, id, "VT_F32E8: HID 32-bit Float e-8", UsageTypes.Sel);
                case 0x0929: return new Usage(this, id, "VT_F32E9: HID 32-bit Float e-7", UsageTypes.Sel);
                case 0x092a: return new Usage(this, id, "VT_F32EA: HID 32-bit Float e-6", UsageTypes.Sel);
                case 0x092b: return new Usage(this, id, "VT_F32EB: HID 32-bit Float e-5", UsageTypes.Sel);
                case 0x092c: return new Usage(this, id, "VT_F32EC: HID 32-bit Float e-4", UsageTypes.Sel);
                case 0x092d: return new Usage(this, id, "VT_F32ED: HID 32-bit Float e-3", UsageTypes.Sel);
                case 0x092e: return new Usage(this, id, "VT_F32EE: HID 32-bit Float e-2", UsageTypes.Sel);
                case 0x092f: return new Usage(this, id, "VT_F32EF: HID 32-bit Float e-1", UsageTypes.Sel);
                case 0x0930: return new Usage(this, id, "Activity Type: Unknown", UsageTypes.Sel);
                case 0x0931: return new Usage(this, id, "Activity Type: Stationary", UsageTypes.Sel);
                case 0x0932: return new Usage(this, id, "Activity Type: Fidgeting", UsageTypes.Sel);
                case 0x0933: return new Usage(this, id, "Activity Type: Walking", UsageTypes.Sel);
                case 0x0934: return new Usage(this, id, "Activity Type: Running", UsageTypes.Sel);
                case 0x0935: return new Usage(this, id, "Activity Type: In Vehicle", UsageTypes.Sel);
                case 0x0936: return new Usage(this, id, "Activity Type: Biking", UsageTypes.Sel);
                case 0x0937: return new Usage(this, id, "Activity Type: Idle", UsageTypes.Sel);
                case 0x0940: return new Usage(this, id, "Unit: Not Specified", UsageTypes.Sel);
                case 0x0941: return new Usage(this, id, "Unit: Lux", UsageTypes.Sel);
                case 0x0942: return new Usage(this, id, "Unit: Degrees Kelvin", UsageTypes.Sel);
                case 0x0943: return new Usage(this, id, "Unit: Degrees Celsius", UsageTypes.Sel);
                case 0x0944: return new Usage(this, id, "Unit: Pascal", UsageTypes.Sel);
                case 0x0945: return new Usage(this, id, "Unit: Newton", UsageTypes.Sel);
                case 0x0946: return new Usage(this, id, "Unit: Meters/Second", UsageTypes.Sel);
                case 0x0947: return new Usage(this, id, "Unit: Kilogram", UsageTypes.Sel);
                case 0x0948: return new Usage(this, id, "Unit: Meter", UsageTypes.Sel);
                case 0x0949: return new Usage(this, id, "Unit: Meters/Second/Second", UsageTypes.Sel);
                case 0x094a: return new Usage(this, id, "Unit: Farad", UsageTypes.Sel);
                case 0x094b: return new Usage(this, id, "Unit: Ampere", UsageTypes.Sel);
                case 0x094c: return new Usage(this, id, "Unit: Watt", UsageTypes.Sel);
                case 0x094d: return new Usage(this, id, "Unit: Henry", UsageTypes.Sel);
                case 0x094e: return new Usage(this, id, "Unit: Ohm", UsageTypes.Sel);
                case 0x094f: return new Usage(this, id, "Unit: Volt", UsageTypes.Sel);
                case 0x0950: return new Usage(this, id, "Unit: Hertz", UsageTypes.Sel);
                case 0x0951: return new Usage(this, id, "Unit: Bar", UsageTypes.Sel);
                case 0x0952: return new Usage(this, id, "Unit: Degrees Anti-clockwise", UsageTypes.Sel);
                case 0x0953: return new Usage(this, id, "Unit: Degrees Clockwise", UsageTypes.Sel);
                case 0x0954: return new Usage(this, id, "Unit: Degrees", UsageTypes.Sel);
                case 0x0955: return new Usage(this, id, "Unit: Degrees/Second", UsageTypes.Sel);
                case 0x0956: return new Usage(this, id, "Unit: Degrees/Second/Second", UsageTypes.Sel);
                case 0x0957: return new Usage(this, id, "Unit: Knot", UsageTypes.Sel);
                case 0x0958: return new Usage(this, id, "Unit: Percent", UsageTypes.Sel);
                case 0x0959: return new Usage(this, id, "Unit: Second", UsageTypes.Sel);
                case 0x095a: return new Usage(this, id, "Unit: Millisecond", UsageTypes.Sel);
                case 0x095b: return new Usage(this, id, "Unit: G", UsageTypes.Sel);
                case 0x095c: return new Usage(this, id, "Unit: Bytes", UsageTypes.Sel);
                case 0x095d: return new Usage(this, id, "Unit: Milligauss", UsageTypes.Sel);
                case 0x095e: return new Usage(this, id, "Unit: Bits", UsageTypes.Sel);
                case 0x0960: return new Usage(this, id, "Activity State: No State Change", UsageTypes.Sel);
                case 0x0961: return new Usage(this, id, "Activity State: Start Activity", UsageTypes.Sel);
                case 0x0962: return new Usage(this, id, "Activity State: End Activity", UsageTypes.Sel);
                case 0x0970: return new Usage(this, id, "Exponent 0: 1", UsageTypes.Sel);
                case 0x0971: return new Usage(this, id, "Exponent 1: 10", UsageTypes.Sel);
                case 0x0972: return new Usage(this, id, "Exponent 2: 100", UsageTypes.Sel);
                case 0x0973: return new Usage(this, id, "Exponent 3: 1 000", UsageTypes.Sel);
                case 0x0974: return new Usage(this, id, "Exponent 4: 10 000", UsageTypes.Sel);
                case 0x0975: return new Usage(this, id, "Exponent 5: 100 000", UsageTypes.Sel);
                case 0x0976: return new Usage(this, id, "Exponent 6: 1 000 000", UsageTypes.Sel);
                case 0x0977: return new Usage(this, id, "Exponent 7: 10 000 000", UsageTypes.Sel);
                case 0x0978: return new Usage(this, id, "Exponent 8: 0.00 000 001", UsageTypes.Sel);
                case 0x0979: return new Usage(this, id, "Exponent 9: 0.0 000 001", UsageTypes.Sel);
                case 0x097a: return new Usage(this, id, "Exponent A: 0.000 001", UsageTypes.Sel);
                case 0x097b: return new Usage(this, id, "Exponent B: 0.00 001", UsageTypes.Sel);
                case 0x097c: return new Usage(this, id, "Exponent C: 0.0 001", UsageTypes.Sel);
                case 0x097d: return new Usage(this, id, "Exponent D: 0.001", UsageTypes.Sel);
                case 0x097e: return new Usage(this, id, "Exponent E: 0.01", UsageTypes.Sel);
                case 0x097f: return new Usage(this, id, "Exponent F: 0.1", UsageTypes.Sel);
                case 0x0980: return new Usage(this, id, "Device Position: Unknown", UsageTypes.Sel);
                case 0x0981: return new Usage(this, id, "Device Position: Unchanged", UsageTypes.Sel);
                case 0x0982: return new Usage(this, id, "Device Position: On Desk", UsageTypes.Sel);
                case 0x0983: return new Usage(this, id, "Device Position: In Hand", UsageTypes.Sel);
                case 0x0984: return new Usage(this, id, "Device Position: Moving in Bag", UsageTypes.Sel);
                case 0x0985: return new Usage(this, id, "Device Position: Stationary in Bag", UsageTypes.Sel);
                case 0x0990: return new Usage(this, id, "Step Type: Unknown", UsageTypes.Sel);
                case 0x0991: return new Usage(this, id, "Step Type: Running", UsageTypes.Sel);
                case 0x0992: return new Usage(this, id, "Step Type: Walking", UsageTypes.Sel);
                case 0x09a0: return new Usage(this, id, "Gesture State: Unknown", UsageTypes.Sel);
                case 0x09a1: return new Usage(this, id, "Gesture State: Started", UsageTypes.Sel);
                case 0x09a2: return new Usage(this, id, "Gesture State: Completed", UsageTypes.Sel);
                case 0x09a3: return new Usage(this, id, "Gesture State: Cancelled", UsageTypes.Sel);
                case 0x09b0: return new Usage(this, id, "Contributing Panel: Unknown", UsageTypes.Sel);
                case 0x09b1: return new Usage(this, id, "Contributing Panel: Panel1", UsageTypes.Sel);
                case 0x09b2: return new Usage(this, id, "Contributing Panel: Panel2", UsageTypes.Sel);
                case 0x09b3: return new Usage(this, id, "Contributing Panel: Both", UsageTypes.Sel);
                case 0x09b4: return new Usage(this, id, "Fold Type: Unknown", UsageTypes.Sel);
                case 0x09b5: return new Usage(this, id, "Fold Type: Increasing", UsageTypes.Sel);
                case 0x09b6: return new Usage(this, id, "Fold Type: Decreasing", UsageTypes.Sel);
                case 0x1000: return new Usage(this, id, "Change Sensitivity Absolute", UsageTypes.US);
                case 0x1001: return new Usage(this, id, "Change Sensitivity Absolute", UsageTypes.US);
                case 0x1002: return new Usage(this, id, "Change Sensitivity Absolute", UsageTypes.US);
                case 0x1003: return new Usage(this, id, "Change Sensitivity Absolute", UsageTypes.US);
                case 0x1004: return new Usage(this, id, "Change Sensitivity Absolute", UsageTypes.US);
                case 0x1005: return new Usage(this, id, "Change Sensitivity Absolute", UsageTypes.US);
                case 0x1006: return new Usage(this, id, "Change Sensitivity Absolute", UsageTypes.US);
                case 0x1007: return new Usage(this, id, "Change Sensitivity Absolute", UsageTypes.US);
                case 0x1008: return new Usage(this, id, "Change Sensitivity Absolute", UsageTypes.US);
                case 0x1009: return new Usage(this, id, "Change Sensitivity Absolute", UsageTypes.US);
                case 0x100a: return new Usage(this, id, "Change Sensitivity Absolute", UsageTypes.US);
                case 0x100b: return new Usage(this, id, "Change Sensitivity Absolute", UsageTypes.US);
                case 0x100c: return new Usage(this, id, "Change Sensitivity Absolute", UsageTypes.US);
                case 0x100d: return new Usage(this, id, "Change Sensitivity Absolute", UsageTypes.US);
                case 0x100e: return new Usage(this, id, "Change Sensitivity Absolute", UsageTypes.US);
                case 0x100f: return new Usage(this, id, "Change Sensitivity Absolute", UsageTypes.US);
                case 0x2000: return new Usage(this, id, "Maximum", UsageTypes.US);
                case 0x2001: return new Usage(this, id, "Maximum", UsageTypes.US);
                case 0x2002: return new Usage(this, id, "Maximum", UsageTypes.US);
                case 0x2003: return new Usage(this, id, "Maximum", UsageTypes.US);
                case 0x2004: return new Usage(this, id, "Maximum", UsageTypes.US);
                case 0x2005: return new Usage(this, id, "Maximum", UsageTypes.US);
                case 0x2006: return new Usage(this, id, "Maximum", UsageTypes.US);
                case 0x2007: return new Usage(this, id, "Maximum", UsageTypes.US);
                case 0x2008: return new Usage(this, id, "Maximum", UsageTypes.US);
                case 0x2009: return new Usage(this, id, "Maximum", UsageTypes.US);
                case 0x200a: return new Usage(this, id, "Maximum", UsageTypes.US);
                case 0x200b: return new Usage(this, id, "Maximum", UsageTypes.US);
                case 0x200c: return new Usage(this, id, "Maximum", UsageTypes.US);
                case 0x200d: return new Usage(this, id, "Maximum", UsageTypes.US);
                case 0x200e: return new Usage(this, id, "Maximum", UsageTypes.US);
                case 0x200f: return new Usage(this, id, "Maximum", UsageTypes.US);
                case 0x3000: return new Usage(this, id, "Minimum", UsageTypes.US);
                case 0x3001: return new Usage(this, id, "Minimum", UsageTypes.US);
                case 0x3002: return new Usage(this, id, "Minimum", UsageTypes.US);
                case 0x3003: return new Usage(this, id, "Minimum", UsageTypes.US);
                case 0x3004: return new Usage(this, id, "Minimum", UsageTypes.US);
                case 0x3005: return new Usage(this, id, "Minimum", UsageTypes.US);
                case 0x3006: return new Usage(this, id, "Minimum", UsageTypes.US);
                case 0x3007: return new Usage(this, id, "Minimum", UsageTypes.US);
                case 0x3008: return new Usage(this, id, "Minimum", UsageTypes.US);
                case 0x3009: return new Usage(this, id, "Minimum", UsageTypes.US);
                case 0x300a: return new Usage(this, id, "Minimum", UsageTypes.US);
                case 0x300b: return new Usage(this, id, "Minimum", UsageTypes.US);
                case 0x300c: return new Usage(this, id, "Minimum", UsageTypes.US);
                case 0x300d: return new Usage(this, id, "Minimum", UsageTypes.US);
                case 0x300e: return new Usage(this, id, "Minimum", UsageTypes.US);
                case 0x300f: return new Usage(this, id, "Minimum", UsageTypes.US);
                case 0x4000: return new Usage(this, id, "Accuracy", UsageTypes.US);
                case 0x4001: return new Usage(this, id, "Accuracy", UsageTypes.US);
                case 0x4002: return new Usage(this, id, "Accuracy", UsageTypes.US);
                case 0x4003: return new Usage(this, id, "Accuracy", UsageTypes.US);
                case 0x4004: return new Usage(this, id, "Accuracy", UsageTypes.US);
                case 0x4005: return new Usage(this, id, "Accuracy", UsageTypes.US);
                case 0x4006: return new Usage(this, id, "Accuracy", UsageTypes.US);
                case 0x4007: return new Usage(this, id, "Accuracy", UsageTypes.US);
                case 0x4008: return new Usage(this, id, "Accuracy", UsageTypes.US);
                case 0x4009: return new Usage(this, id, "Accuracy", UsageTypes.US);
                case 0x400a: return new Usage(this, id, "Accuracy", UsageTypes.US);
                case 0x400b: return new Usage(this, id, "Accuracy", UsageTypes.US);
                case 0x400c: return new Usage(this, id, "Accuracy", UsageTypes.US);
                case 0x400d: return new Usage(this, id, "Accuracy", UsageTypes.US);
                case 0x400e: return new Usage(this, id, "Accuracy", UsageTypes.US);
                case 0x400f: return new Usage(this, id, "Accuracy", UsageTypes.US);
                case 0x5000: return new Usage(this, id, "Resolution", UsageTypes.US);
                case 0x5001: return new Usage(this, id, "Resolution", UsageTypes.US);
                case 0x5002: return new Usage(this, id, "Resolution", UsageTypes.US);
                case 0x5003: return new Usage(this, id, "Resolution", UsageTypes.US);
                case 0x5004: return new Usage(this, id, "Resolution", UsageTypes.US);
                case 0x5005: return new Usage(this, id, "Resolution", UsageTypes.US);
                case 0x5006: return new Usage(this, id, "Resolution", UsageTypes.US);
                case 0x5007: return new Usage(this, id, "Resolution", UsageTypes.US);
                case 0x5008: return new Usage(this, id, "Resolution", UsageTypes.US);
                case 0x5009: return new Usage(this, id, "Resolution", UsageTypes.US);
                case 0x500a: return new Usage(this, id, "Resolution", UsageTypes.US);
                case 0x500b: return new Usage(this, id, "Resolution", UsageTypes.US);
                case 0x500c: return new Usage(this, id, "Resolution", UsageTypes.US);
                case 0x500d: return new Usage(this, id, "Resolution", UsageTypes.US);
                case 0x500e: return new Usage(this, id, "Resolution", UsageTypes.US);
                case 0x500f: return new Usage(this, id, "Resolution", UsageTypes.US);
                case 0x6000: return new Usage(this, id, "Threshold High", UsageTypes.US);
                case 0x6001: return new Usage(this, id, "Threshold High", UsageTypes.US);
                case 0x6002: return new Usage(this, id, "Threshold High", UsageTypes.US);
                case 0x6003: return new Usage(this, id, "Threshold High", UsageTypes.US);
                case 0x6004: return new Usage(this, id, "Threshold High", UsageTypes.US);
                case 0x6005: return new Usage(this, id, "Threshold High", UsageTypes.US);
                case 0x6006: return new Usage(this, id, "Threshold High", UsageTypes.US);
                case 0x6007: return new Usage(this, id, "Threshold High", UsageTypes.US);
                case 0x6008: return new Usage(this, id, "Threshold High", UsageTypes.US);
                case 0x6009: return new Usage(this, id, "Threshold High", UsageTypes.US);
                case 0x600a: return new Usage(this, id, "Threshold High", UsageTypes.US);
                case 0x600b: return new Usage(this, id, "Threshold High", UsageTypes.US);
                case 0x600c: return new Usage(this, id, "Threshold High", UsageTypes.US);
                case 0x600d: return new Usage(this, id, "Threshold High", UsageTypes.US);
                case 0x600e: return new Usage(this, id, "Threshold High", UsageTypes.US);
                case 0x600f: return new Usage(this, id, "Threshold High", UsageTypes.US);
                case 0x7000: return new Usage(this, id, "Threshold Low", UsageTypes.US);
                case 0x7001: return new Usage(this, id, "Threshold Low", UsageTypes.US);
                case 0x7002: return new Usage(this, id, "Threshold Low", UsageTypes.US);
                case 0x7003: return new Usage(this, id, "Threshold Low", UsageTypes.US);
                case 0x7004: return new Usage(this, id, "Threshold Low", UsageTypes.US);
                case 0x7005: return new Usage(this, id, "Threshold Low", UsageTypes.US);
                case 0x7006: return new Usage(this, id, "Threshold Low", UsageTypes.US);
                case 0x7007: return new Usage(this, id, "Threshold Low", UsageTypes.US);
                case 0x7008: return new Usage(this, id, "Threshold Low", UsageTypes.US);
                case 0x7009: return new Usage(this, id, "Threshold Low", UsageTypes.US);
                case 0x700a: return new Usage(this, id, "Threshold Low", UsageTypes.US);
                case 0x700b: return new Usage(this, id, "Threshold Low", UsageTypes.US);
                case 0x700c: return new Usage(this, id, "Threshold Low", UsageTypes.US);
                case 0x700d: return new Usage(this, id, "Threshold Low", UsageTypes.US);
                case 0x700e: return new Usage(this, id, "Threshold Low", UsageTypes.US);
                case 0x700f: return new Usage(this, id, "Threshold Low", UsageTypes.US);
                case 0x8000: return new Usage(this, id, "Calibration Offset", UsageTypes.US);
                case 0x8001: return new Usage(this, id, "Calibration Offset", UsageTypes.US);
                case 0x8002: return new Usage(this, id, "Calibration Offset", UsageTypes.US);
                case 0x8003: return new Usage(this, id, "Calibration Offset", UsageTypes.US);
                case 0x8004: return new Usage(this, id, "Calibration Offset", UsageTypes.US);
                case 0x8005: return new Usage(this, id, "Calibration Offset", UsageTypes.US);
                case 0x8006: return new Usage(this, id, "Calibration Offset", UsageTypes.US);
                case 0x8007: return new Usage(this, id, "Calibration Offset", UsageTypes.US);
                case 0x8008: return new Usage(this, id, "Calibration Offset", UsageTypes.US);
                case 0x8009: return new Usage(this, id, "Calibration Offset", UsageTypes.US);
                case 0x800a: return new Usage(this, id, "Calibration Offset", UsageTypes.US);
                case 0x800b: return new Usage(this, id, "Calibration Offset", UsageTypes.US);
                case 0x800c: return new Usage(this, id, "Calibration Offset", UsageTypes.US);
                case 0x800d: return new Usage(this, id, "Calibration Offset", UsageTypes.US);
                case 0x800e: return new Usage(this, id, "Calibration Offset", UsageTypes.US);
                case 0x800f: return new Usage(this, id, "Calibration Offset", UsageTypes.US);
                case 0x9000: return new Usage(this, id, "Calibration Multiplier", UsageTypes.US);
                case 0x9001: return new Usage(this, id, "Calibration Multiplier", UsageTypes.US);
                case 0x9002: return new Usage(this, id, "Calibration Multiplier", UsageTypes.US);
                case 0x9003: return new Usage(this, id, "Calibration Multiplier", UsageTypes.US);
                case 0x9004: return new Usage(this, id, "Calibration Multiplier", UsageTypes.US);
                case 0x9005: return new Usage(this, id, "Calibration Multiplier", UsageTypes.US);
                case 0x9006: return new Usage(this, id, "Calibration Multiplier", UsageTypes.US);
                case 0x9007: return new Usage(this, id, "Calibration Multiplier", UsageTypes.US);
                case 0x9008: return new Usage(this, id, "Calibration Multiplier", UsageTypes.US);
                case 0x9009: return new Usage(this, id, "Calibration Multiplier", UsageTypes.US);
                case 0x900a: return new Usage(this, id, "Calibration Multiplier", UsageTypes.US);
                case 0x900b: return new Usage(this, id, "Calibration Multiplier", UsageTypes.US);
                case 0x900c: return new Usage(this, id, "Calibration Multiplier", UsageTypes.US);
                case 0x900d: return new Usage(this, id, "Calibration Multiplier", UsageTypes.US);
                case 0x900e: return new Usage(this, id, "Calibration Multiplier", UsageTypes.US);
                case 0x900f: return new Usage(this, id, "Calibration Multiplier", UsageTypes.US);
                case 0xa000: return new Usage(this, id, "Report Interval", UsageTypes.US);
                case 0xa001: return new Usage(this, id, "Report Interval", UsageTypes.US);
                case 0xa002: return new Usage(this, id, "Report Interval", UsageTypes.US);
                case 0xa003: return new Usage(this, id, "Report Interval", UsageTypes.US);
                case 0xa004: return new Usage(this, id, "Report Interval", UsageTypes.US);
                case 0xa005: return new Usage(this, id, "Report Interval", UsageTypes.US);
                case 0xa006: return new Usage(this, id, "Report Interval", UsageTypes.US);
                case 0xa007: return new Usage(this, id, "Report Interval", UsageTypes.US);
                case 0xa008: return new Usage(this, id, "Report Interval", UsageTypes.US);
                case 0xa009: return new Usage(this, id, "Report Interval", UsageTypes.US);
                case 0xa00a: return new Usage(this, id, "Report Interval", UsageTypes.US);
                case 0xa00b: return new Usage(this, id, "Report Interval", UsageTypes.US);
                case 0xa00c: return new Usage(this, id, "Report Interval", UsageTypes.US);
                case 0xa00d: return new Usage(this, id, "Report Interval", UsageTypes.US);
                case 0xa00e: return new Usage(this, id, "Report Interval", UsageTypes.US);
                case 0xa00f: return new Usage(this, id, "Report Interval", UsageTypes.US);
                case 0xb000: return new Usage(this, id, "Frequency Max", UsageTypes.US);
                case 0xb001: return new Usage(this, id, "Frequency Max", UsageTypes.US);
                case 0xb002: return new Usage(this, id, "Frequency Max", UsageTypes.US);
                case 0xb003: return new Usage(this, id, "Frequency Max", UsageTypes.US);
                case 0xb004: return new Usage(this, id, "Frequency Max", UsageTypes.US);
                case 0xb005: return new Usage(this, id, "Frequency Max", UsageTypes.US);
                case 0xb006: return new Usage(this, id, "Frequency Max", UsageTypes.US);
                case 0xb007: return new Usage(this, id, "Frequency Max", UsageTypes.US);
                case 0xb008: return new Usage(this, id, "Frequency Max", UsageTypes.US);
                case 0xb009: return new Usage(this, id, "Frequency Max", UsageTypes.US);
                case 0xb00a: return new Usage(this, id, "Frequency Max", UsageTypes.US);
                case 0xb00b: return new Usage(this, id, "Frequency Max", UsageTypes.US);
                case 0xb00c: return new Usage(this, id, "Frequency Max", UsageTypes.US);
                case 0xb00d: return new Usage(this, id, "Frequency Max", UsageTypes.US);
                case 0xb00e: return new Usage(this, id, "Frequency Max", UsageTypes.US);
                case 0xb00f: return new Usage(this, id, "Frequency Max", UsageTypes.US);
                case 0xc000: return new Usage(this, id, "Period Max", UsageTypes.US);
                case 0xc001: return new Usage(this, id, "Period Max", UsageTypes.US);
                case 0xc002: return new Usage(this, id, "Period Max", UsageTypes.US);
                case 0xc003: return new Usage(this, id, "Period Max", UsageTypes.US);
                case 0xc004: return new Usage(this, id, "Period Max", UsageTypes.US);
                case 0xc005: return new Usage(this, id, "Period Max", UsageTypes.US);
                case 0xc006: return new Usage(this, id, "Period Max", UsageTypes.US);
                case 0xc007: return new Usage(this, id, "Period Max", UsageTypes.US);
                case 0xc008: return new Usage(this, id, "Period Max", UsageTypes.US);
                case 0xc009: return new Usage(this, id, "Period Max", UsageTypes.US);
                case 0xc00a: return new Usage(this, id, "Period Max", UsageTypes.US);
                case 0xc00b: return new Usage(this, id, "Period Max", UsageTypes.US);
                case 0xc00c: return new Usage(this, id, "Period Max", UsageTypes.US);
                case 0xc00d: return new Usage(this, id, "Period Max", UsageTypes.US);
                case 0xc00e: return new Usage(this, id, "Period Max", UsageTypes.US);
                case 0xc00f: return new Usage(this, id, "Period Max", UsageTypes.US);
                case 0xd000: return new Usage(this, id, "Change Sensitivity Percent of Range", UsageTypes.US);
                case 0xd001: return new Usage(this, id, "Change Sensitivity Percent of Range", UsageTypes.US);
                case 0xd002: return new Usage(this, id, "Change Sensitivity Percent of Range", UsageTypes.US);
                case 0xd003: return new Usage(this, id, "Change Sensitivity Percent of Range", UsageTypes.US);
                case 0xd004: return new Usage(this, id, "Change Sensitivity Percent of Range", UsageTypes.US);
                case 0xd005: return new Usage(this, id, "Change Sensitivity Percent of Range", UsageTypes.US);
                case 0xd006: return new Usage(this, id, "Change Sensitivity Percent of Range", UsageTypes.US);
                case 0xd007: return new Usage(this, id, "Change Sensitivity Percent of Range", UsageTypes.US);
                case 0xd008: return new Usage(this, id, "Change Sensitivity Percent of Range", UsageTypes.US);
                case 0xd009: return new Usage(this, id, "Change Sensitivity Percent of Range", UsageTypes.US);
                case 0xd00a: return new Usage(this, id, "Change Sensitivity Percent of Range", UsageTypes.US);
                case 0xd00b: return new Usage(this, id, "Change Sensitivity Percent of Range", UsageTypes.US);
                case 0xd00c: return new Usage(this, id, "Change Sensitivity Percent of Range", UsageTypes.US);
                case 0xd00d: return new Usage(this, id, "Change Sensitivity Percent of Range", UsageTypes.US);
                case 0xd00e: return new Usage(this, id, "Change Sensitivity Percent of Range", UsageTypes.US);
                case 0xd00f: return new Usage(this, id, "Change Sensitivity Percent of Range", UsageTypes.US);
                case 0xe000: return new Usage(this, id, "Change Sensitivity Percent Relative", UsageTypes.US);
                case 0xe001: return new Usage(this, id, "Change Sensitivity Percent Relative", UsageTypes.US);
                case 0xe002: return new Usage(this, id, "Change Sensitivity Percent Relative", UsageTypes.US);
                case 0xe003: return new Usage(this, id, "Change Sensitivity Percent Relative", UsageTypes.US);
                case 0xe004: return new Usage(this, id, "Change Sensitivity Percent Relative", UsageTypes.US);
                case 0xe005: return new Usage(this, id, "Change Sensitivity Percent Relative", UsageTypes.US);
                case 0xe006: return new Usage(this, id, "Change Sensitivity Percent Relative", UsageTypes.US);
                case 0xe007: return new Usage(this, id, "Change Sensitivity Percent Relative", UsageTypes.US);
                case 0xe008: return new Usage(this, id, "Change Sensitivity Percent Relative", UsageTypes.US);
                case 0xe009: return new Usage(this, id, "Change Sensitivity Percent Relative", UsageTypes.US);
                case 0xe00a: return new Usage(this, id, "Change Sensitivity Percent Relative", UsageTypes.US);
                case 0xe00b: return new Usage(this, id, "Change Sensitivity Percent Relative", UsageTypes.US);
                case 0xe00c: return new Usage(this, id, "Change Sensitivity Percent Relative", UsageTypes.US);
                case 0xe00d: return new Usage(this, id, "Change Sensitivity Percent Relative", UsageTypes.US);
                case 0xe00e: return new Usage(this, id, "Change Sensitivity Percent Relative", UsageTypes.US);
                case 0xe00f: return new Usage(this, id, "Change Sensitivity Percent Relative", UsageTypes.US);
            }

            // Create dynamic usages from ranges
            var n = (ushort)(id-0x0544);
            if (id >= 0x0544 || id < 0x055f) return new Usage(this, id, $"Data Field: Custom Value {n+1}", UsageTypes.SV);
            if (id >= 0x1000 || id < 0x1fff) return new Usage(this, id, $"Change Sensitivity Absolute", UsageTypes.US);
            if (id >= 0x2000 || id < 0x2fff) return new Usage(this, id, $"Maximum", UsageTypes.US);
            if (id >= 0x3000 || id < 0x3fff) return new Usage(this, id, $"Minimum", UsageTypes.US);
            if (id >= 0x4000 || id < 0x4fff) return new Usage(this, id, $"Accuracy", UsageTypes.US);
            if (id >= 0x5000 || id < 0x5fff) return new Usage(this, id, $"Resolution", UsageTypes.US);
            if (id >= 0x6000 || id < 0x6fff) return new Usage(this, id, $"Threshold High", UsageTypes.US);
            if (id >= 0x7000 || id < 0x7fff) return new Usage(this, id, $"Threshold Low", UsageTypes.US);
            if (id >= 0x8000 || id < 0x8fff) return new Usage(this, id, $"Calibration Offset", UsageTypes.US);
            if (id >= 0x9000 || id < 0x9fff) return new Usage(this, id, $"Calibration Multiplier", UsageTypes.US);
            if (id >= 0xa000 || id < 0xafff) return new Usage(this, id, $"Report Interval", UsageTypes.US);
            if (id >= 0xb000 || id < 0xbfff) return new Usage(this, id, $"Frequency Max", UsageTypes.US);
            if (id >= 0xc000 || id < 0xcfff) return new Usage(this, id, $"Period Max", UsageTypes.US);
            if (id >= 0xd000 || id < 0xdfff) return new Usage(this, id, $"Change Sensitivity Percent of Range", UsageTypes.US);
            if (id >= 0xe000 || id < 0xefff) return new Usage(this, id, $"Change Sensitivity Percent Relative", UsageTypes.US);

            return base.CreateUsage(id);
        }
    }

    /// <summary>
    ///     Base class for all usage pages.
    /// </summary>
    public sealed class MedicalInstrumentsUsagePage : UsagePage
    {
        /// <summary>
        ///     Singleton instance of MedicalInstruments Usage Page.
        /// </summary>
        public static readonly MedicalInstrumentsUsagePage Instance = new MedicalInstrumentsUsagePage();

        private MedicalInstrumentsUsagePage() : base(0x0040, "MedicalInstruments")
        {
        }

        /// <inheritdoc />
        protected override Usage CreateUsage(ushort id) 
        {
            switch (id)
            {
                case 0x0000: return new Usage(this, id, "Undefined", UsageTypes.None);
                case 0x0001: return new Usage(this, id, "Medical Ultrasound", UsageTypes.CA);
                case 0x0020: return new Usage(this, id, "VCR/Acquisition", UsageTypes.OOC);
                case 0x0021: return new Usage(this, id, "Freeze/Thaw", UsageTypes.OOC);
                case 0x0022: return new Usage(this, id, "Clip Store", UsageTypes.OSC);
                case 0x0023: return new Usage(this, id, "Update", UsageTypes.OSC);
                case 0x0024: return new Usage(this, id, "Next", UsageTypes.OSC);
                case 0x0025: return new Usage(this, id, "Save", UsageTypes.OSC);
                case 0x0026: return new Usage(this, id, "Print", UsageTypes.OSC);
                case 0x0027: return new Usage(this, id, "Microphone Enable", UsageTypes.OSC);
                case 0x0040: return new Usage(this, id, "Cine", UsageTypes.LC);
                case 0x0041: return new Usage(this, id, "Transmit Power", UsageTypes.LC);
                case 0x0042: return new Usage(this, id, "Volume", UsageTypes.LC);
                case 0x0043: return new Usage(this, id, "Focus", UsageTypes.LC);
                case 0x0044: return new Usage(this, id, "Depth", UsageTypes.LC);
                case 0x0060: return new Usage(this, id, "Soft Step - Primary", UsageTypes.LC);
                case 0x0061: return new Usage(this, id, "Soft Step - Secondary", UsageTypes.LC);
                case 0x0070: return new Usage(this, id, "Depth Gain Compensation", UsageTypes.LC);
                case 0x0080: return new Usage(this, id, "Zoom Select", UsageTypes.OSC);
                case 0x0081: return new Usage(this, id, "Zoom Adjust", UsageTypes.LC);
                case 0x0082: return new Usage(this, id, "Spectral Doppler Mode Select", UsageTypes.OSC);
                case 0x0083: return new Usage(this, id, "Spectral Doppler Adjust", UsageTypes.LC);
                case 0x0084: return new Usage(this, id, "Color Doppler Mode Select", UsageTypes.OSC);
                case 0x0085: return new Usage(this, id, "Color Doppler Adjust", UsageTypes.LC);
                case 0x0086: return new Usage(this, id, "Motion Mode Select", UsageTypes.OSC);
                case 0x0087: return new Usage(this, id, "Motion Mode Adjust", UsageTypes.LC);
                case 0x0088: return new Usage(this, id, "2D Mode Select", UsageTypes.OSC);
                case 0x0089: return new Usage(this, id, "2D Mode Adjust", UsageTypes.LC);
                case 0x00a0: return new Usage(this, id, "Soft Control Select", UsageTypes.OSC);
                case 0x00a1: return new Usage(this, id, "Soft Control Adjust", UsageTypes.LC);
            }

            return base.CreateUsage(id);
        }
    }

    /// <summary>
    ///     Base class for all usage pages.
    /// </summary>
    public sealed class BrailleDisplayUsagePage : UsagePage
    {
        /// <summary>
        ///     Singleton instance of BrailleDisplay Usage Page.
        /// </summary>
        public static readonly BrailleDisplayUsagePage Instance = new BrailleDisplayUsagePage();

        private BrailleDisplayUsagePage() : base(0x0041, "BrailleDisplay")
        {
        }

        /// <inheritdoc />
        protected override Usage CreateUsage(ushort id) 
        {
            switch (id)
            {
                case 0x0000: return new Usage(this, id, "Undefined", UsageTypes.None);
                case 0x0001: return new Usage(this, id, "Braille Display", UsageTypes.CA);
                case 0x0002: return new Usage(this, id, "Braille Row", UsageTypes.NAry);
                case 0x0003: return new Usage(this, id, "8 Dot Braille Cell", UsageTypes.DV);
                case 0x0004: return new Usage(this, id, "6 Dot Braille Cell", UsageTypes.DV);
                case 0x0005: return new Usage(this, id, "Number of Braille Cells", UsageTypes.DV);
                case 0x0006: return new Usage(this, id, "Screen Reader Control", UsageTypes.NAry);
                case 0x0007: return new Usage(this, id, "Screen Reader Identifier", UsageTypes.DV);
                case 0x00fa: return new Usage(this, id, "Router Set 1", UsageTypes.NAry);
                case 0x00fb: return new Usage(this, id, "Router Set 2", UsageTypes.NAry);
                case 0x00fc: return new Usage(this, id, "Router Set 3", UsageTypes.NAry);
                case 0x0100: return new Usage(this, id, "Braille Buttons", UsageTypes.NAry);
                case 0x0201: return new Usage(this, id, "Braille Keyboard Dot 1", UsageTypes.Sel);
                case 0x0202: return new Usage(this, id, "Braille Keyboard Dot 2", UsageTypes.Sel);
                case 0x0203: return new Usage(this, id, "Braille Keyboard Dot 3", UsageTypes.Sel);
                case 0x0204: return new Usage(this, id, "Braille Keyboard Dot 4", UsageTypes.Sel);
                case 0x0205: return new Usage(this, id, "Braille Keyboard Dot 5", UsageTypes.Sel);
                case 0x0206: return new Usage(this, id, "Braille Keyboard Dot 6", UsageTypes.Sel);
                case 0x0207: return new Usage(this, id, "Braille Keyboard Dot 7", UsageTypes.Sel);
                case 0x0208: return new Usage(this, id, "Braille Keyboard Dot 8", UsageTypes.Sel);
                case 0x0209: return new Usage(this, id, "Braille Keyboard Space", UsageTypes.Sel);
                case 0x020a: return new Usage(this, id, "Braille Keyboard Left Space", UsageTypes.Sel);
                case 0x020b: return new Usage(this, id, "Braille Keyboard Right Space", UsageTypes.Sel);
                case 0x020c: return new Usage(this, id, "Braille Face Controls", UsageTypes.NAry);
                case 0x020d: return new Usage(this, id, "Braille Left Controls", UsageTypes.NAry);
                case 0x020e: return new Usage(this, id, "Braille Right Controls", UsageTypes.NAry);
                case 0x020f: return new Usage(this, id, "Braille Top Controls", UsageTypes.NAry);
                case 0x0210: return new Usage(this, id, "Braille Joystick Center", UsageTypes.Sel);
                case 0x0211: return new Usage(this, id, "Braille Joystick Up", UsageTypes.Sel);
                case 0x0212: return new Usage(this, id, "Braille Joystick Down", UsageTypes.Sel);
                case 0x0213: return new Usage(this, id, "Braille Joystick Left", UsageTypes.Sel);
                case 0x0214: return new Usage(this, id, "Braille Joystick Right", UsageTypes.Sel);
                case 0x0215: return new Usage(this, id, "Braille D-pad Center", UsageTypes.Sel);
                case 0x0216: return new Usage(this, id, "Braille D-pad Up", UsageTypes.Sel);
                case 0x0217: return new Usage(this, id, "Braille D-pad Down", UsageTypes.Sel);
                case 0x0218: return new Usage(this, id, "Braille D-pad Left", UsageTypes.Sel);
                case 0x0219: return new Usage(this, id, "Braille D-pad Right", UsageTypes.Sel);
                case 0x021a: return new Usage(this, id, "Braille Pan Left", UsageTypes.Sel);
                case 0x021b: return new Usage(this, id, "Braille Pan Right", UsageTypes.Sel);
                case 0x021c: return new Usage(this, id, "Braille Rocker Up", UsageTypes.Sel);
                case 0x021d: return new Usage(this, id, "Braille Rocker Down", UsageTypes.Sel);
                case 0x021e: return new Usage(this, id, "Braille Rocker Press", UsageTypes.Sel);
            }

            return base.CreateUsage(id);
        }
    }

    /// <summary>
    ///     Base class for all usage pages.
    /// </summary>
    public sealed class LightingAndIlluminationUsagePage : UsagePage
    {
        /// <summary>
        ///     Singleton instance of LightingAndIllumination Usage Page.
        /// </summary>
        public static readonly LightingAndIlluminationUsagePage Instance = new LightingAndIlluminationUsagePage();

        private LightingAndIlluminationUsagePage() : base(0x0059, "LightingAndIllumination")
        {
        }

        /// <inheritdoc />
        protected override Usage CreateUsage(ushort id) 
        {
            switch (id)
            {
                case 0x0000: return new Usage(this, id, "Undefined", UsageTypes.None);
                case 0x0001: return new Usage(this, id, "Lamp Array", UsageTypes.CA);
                case 0x0002: return new Usage(this, id, "Lamp Array Attributes Report", UsageTypes.CL);
                case 0x0003: return new Usage(this, id, "Lamp Count", UsageTypes.SV|UsageTypes.DV);
                case 0x0004: return new Usage(this, id, "Bounding Box Width (um)", UsageTypes.SV);
                case 0x0005: return new Usage(this, id, "Bounding Box Height (um)", UsageTypes.SV);
                case 0x0006: return new Usage(this, id, "Bounding Box Depth (um)", UsageTypes.SV);
                case 0x0007: return new Usage(this, id, "Lamp Array Kind", UsageTypes.NAry);
                case 0x0008: return new Usage(this, id, "Minimal Update Interval (us)", UsageTypes.SV);
                case 0x0020: return new Usage(this, id, "Lamp Attributes Request Report", UsageTypes.CL);
                case 0x0021: return new Usage(this, id, "Lamp ID", UsageTypes.SV|UsageTypes.DV);
                case 0x0022: return new Usage(this, id, "Lamp Attributes Response Report", UsageTypes.CL);
                case 0x0023: return new Usage(this, id, "Position X (um)", UsageTypes.DV);
                case 0x0024: return new Usage(this, id, "Position Y (um)", UsageTypes.DV);
                case 0x0025: return new Usage(this, id, "Position Z (um)", UsageTypes.DV);
                case 0x0026: return new Usage(this, id, "Lamp Purposes", UsageTypes.NAry);
                case 0x0027: return new Usage(this, id, "Update Latency (us)", UsageTypes.DV);
                case 0x0028: return new Usage(this, id, "Red Level Count", UsageTypes.DV);
                case 0x0029: return new Usage(this, id, "Green Level Count", UsageTypes.DV);
                case 0x002a: return new Usage(this, id, "Blue Level Count", UsageTypes.DV);
                case 0x002b: return new Usage(this, id, "Intensity Level Count", UsageTypes.DV);
                case 0x002c: return new Usage(this, id, "Programmable", UsageTypes.SF|UsageTypes.DF);
                case 0x002d: return new Usage(this, id, "Input Binding", UsageTypes.NAry);
                case 0x0050: return new Usage(this, id, "Lamp Multi Update Report", UsageTypes.CL);
                case 0x0051: return new Usage(this, id, "Red Update Channel", UsageTypes.DV);
                case 0x0052: return new Usage(this, id, "Green Update Channel", UsageTypes.DV);
                case 0x0053: return new Usage(this, id, "Blue Update Channel", UsageTypes.DV);
                case 0x0054: return new Usage(this, id, "Intensity Update Channel", UsageTypes.DV);
                case 0x0055: return new Usage(this, id, "Lamp Update Complete", UsageTypes.DF);
                case 0x0060: return new Usage(this, id, "Lamp Range Update Report", UsageTypes.CL);
                case 0x0061: return new Usage(this, id, "Lamp ID Start", UsageTypes.DV);
                case 0x0062: return new Usage(this, id, "Lamp ID End", UsageTypes.DV);
                case 0x0070: return new Usage(this, id, "Lamp Array Control Report", UsageTypes.CL);
                case 0x0071: return new Usage(this, id, "Autonomous Mode", UsageTypes.DF);
                case 0x0101: return new Usage(this, id, "Lamp Array Kind Keyboard", UsageTypes.Sel);
                case 0x0102: return new Usage(this, id, "Lamp Array Kind Mouse", UsageTypes.Sel);
                case 0x0103: return new Usage(this, id, "Lamp Array Kind Game Controller", UsageTypes.Sel);
                case 0x0104: return new Usage(this, id, "Lamp Array Kind Peripheral", UsageTypes.Sel);
                case 0x0105: return new Usage(this, id, "Lamp Array Kind Scene", UsageTypes.Sel);
                case 0x0106: return new Usage(this, id, "Lamp Array Kind Notification", UsageTypes.Sel);
                case 0x0107: return new Usage(this, id, "Lamp Array Kind Chassis", UsageTypes.Sel);
                case 0x0108: return new Usage(this, id, "Lamp Array Kind Wearable", UsageTypes.Sel);
                case 0x0109: return new Usage(this, id, "Lamp Array Kind Furniture", UsageTypes.Sel);
                case 0x010a: return new Usage(this, id, "Lamp Array Kind Art", UsageTypes.Sel);
                case 0x0201: return new Usage(this, id, "Lamp Purpose Control", UsageTypes.Sel);
                case 0x0202: return new Usage(this, id, "Lamp Purpose Accent", UsageTypes.Sel);
                case 0x0203: return new Usage(this, id, "Lamp Purpose Branding", UsageTypes.Sel);
                case 0x0204: return new Usage(this, id, "Lamp Purpose Status", UsageTypes.Sel);
                case 0x0205: return new Usage(this, id, "Lamp Purpose Illumination", UsageTypes.Sel);
                case 0x0206: return new Usage(this, id, "Lamp Purpose Presentation", UsageTypes.Sel);
            }

            return base.CreateUsage(id);
        }
    }

    /// <summary>
    ///     Base class for all usage pages.
    /// </summary>
    public sealed class MonitorUsagePage : UsagePage
    {
        /// <summary>
        ///     Singleton instance of Monitor Usage Page.
        /// </summary>
        public static readonly MonitorUsagePage Instance = new MonitorUsagePage();

        private MonitorUsagePage() : base(0x0080, "Monitor")
        {
        }

        /// <inheritdoc />
        protected override Usage CreateUsage(ushort id) 
        {
            switch (id)
            {
                case 0x0000: return new Usage(this, id, "Undefined", UsageTypes.None);
                case 0x0001: return new Usage(this, id, "Monitor Control", UsageTypes.CA);
            }

            return base.CreateUsage(id);
        }
    }

    /// <summary>
    ///     Base class for all usage pages.
    /// </summary>
    public sealed class MonitorEnumeratedValuesUsagePage : UsagePage
    {
        /// <summary>
        ///     Singleton instance of MonitorEnumeratedValues Usage Page.
        /// </summary>
        public static readonly MonitorEnumeratedValuesUsagePage Instance = new MonitorEnumeratedValuesUsagePage();

        private MonitorEnumeratedValuesUsagePage() : base(0x0081, "MonitorEnumeratedValues")
        {
        }

        /// <inheritdoc />
        protected override Usage CreateUsage(ushort id) 
        {
            switch (id)
            {
                case 0x0000: return new Usage(this, id, "ENUM_0", UsageTypes.Sel);
                case 0x0001: return new Usage(this, id, "ENUM_1", UsageTypes.Sel);
                case 0x0002: return new Usage(this, id, "ENUM_2", UsageTypes.Sel);
                case 0x0003: return new Usage(this, id, "ENUM_3", UsageTypes.Sel);
                case 0x0004: return new Usage(this, id, "ENUM_4", UsageTypes.Sel);
                case 0x0005: return new Usage(this, id, "ENUM_5", UsageTypes.Sel);
                case 0x0006: return new Usage(this, id, "ENUM_6", UsageTypes.Sel);
                case 0x0007: return new Usage(this, id, "ENUM_7", UsageTypes.Sel);
                case 0x0008: return new Usage(this, id, "ENUM_8", UsageTypes.Sel);
                case 0x0009: return new Usage(this, id, "ENUM_9", UsageTypes.Sel);
                case 0x000a: return new Usage(this, id, "ENUM_10", UsageTypes.Sel);
                case 0x000b: return new Usage(this, id, "ENUM_11", UsageTypes.Sel);
                case 0x000c: return new Usage(this, id, "ENUM_12", UsageTypes.Sel);
                case 0x000d: return new Usage(this, id, "ENUM_13", UsageTypes.Sel);
                case 0x000e: return new Usage(this, id, "ENUM_14", UsageTypes.Sel);
                case 0x000f: return new Usage(this, id, "ENUM_15", UsageTypes.Sel);
            }

            // Create dynamic usages from ranges
            var n = (ushort)(id-0x0000);
            if (id >= 0x0000 || id < 0xffff) return new Usage(this, id, $"ENUM_{id}", UsageTypes.Sel);

            return base.CreateUsage(id);
        }
    }

    /// <summary>
    ///     Base class for all usage pages.
    /// </summary>
    public sealed class VESAVirtualUsagePage : UsagePage
    {
        /// <summary>
        ///     Singleton instance of VESAVirtual Usage Page.
        /// </summary>
        public static readonly VESAVirtualUsagePage Instance = new VESAVirtualUsagePage();

        private VESAVirtualUsagePage() : base(0x0082, "VESAVirtual")
        {
        }

        /// <inheritdoc />
        protected override Usage CreateUsage(ushort id) 
        {
            switch (id)
            {
                case 0x0000: return new Usage(this, id, "Undefined", UsageTypes.None);
                case 0x0001: return new Usage(this, id, "", UsageTypes.None);
                case 0x0010: return new Usage(this, id, "", UsageTypes.None);
                case 0x0012: return new Usage(this, id, "", UsageTypes.None);
                case 0x0016: return new Usage(this, id, "", UsageTypes.None);
                case 0x0018: return new Usage(this, id, "", UsageTypes.None);
                case 0x001a: return new Usage(this, id, "", UsageTypes.None);
                case 0x001c: return new Usage(this, id, "", UsageTypes.None);
                case 0x0020: return new Usage(this, id, "", UsageTypes.None);
                case 0x0022: return new Usage(this, id, "", UsageTypes.None);
                case 0x0024: return new Usage(this, id, "", UsageTypes.None);
                case 0x0026: return new Usage(this, id, "", UsageTypes.None);
                case 0x0028: return new Usage(this, id, "", UsageTypes.None);
                case 0x002a: return new Usage(this, id, "", UsageTypes.None);
                case 0x002c: return new Usage(this, id, "", UsageTypes.None);
                case 0x0030: return new Usage(this, id, "", UsageTypes.None);
                case 0x0032: return new Usage(this, id, "", UsageTypes.None);
                case 0x0034: return new Usage(this, id, "", UsageTypes.None);
                case 0x0036: return new Usage(this, id, "", UsageTypes.None);
                case 0x0038: return new Usage(this, id, "", UsageTypes.None);
                case 0x003a: return new Usage(this, id, "", UsageTypes.None);
                case 0x003c: return new Usage(this, id, "", UsageTypes.None);
                case 0x0040: return new Usage(this, id, "", UsageTypes.None);
                case 0x0042: return new Usage(this, id, "", UsageTypes.None);
                case 0x0044: return new Usage(this, id, "", UsageTypes.None);
                case 0x0046: return new Usage(this, id, "", UsageTypes.None);
                case 0x0048: return new Usage(this, id, "", UsageTypes.None);
                case 0x004a: return new Usage(this, id, "", UsageTypes.None);
                case 0x004c: return new Usage(this, id, "", UsageTypes.None);
                case 0x0056: return new Usage(this, id, "", UsageTypes.None);
                case 0x0058: return new Usage(this, id, "", UsageTypes.None);
                case 0x005e: return new Usage(this, id, "", UsageTypes.None);
                case 0x0060: return new Usage(this, id, "", UsageTypes.None);
                case 0x006c: return new Usage(this, id, "", UsageTypes.None);
                case 0x006e: return new Usage(this, id, "", UsageTypes.None);
                case 0x0070: return new Usage(this, id, "", UsageTypes.None);
                case 0x00a2: return new Usage(this, id, "", UsageTypes.None);
                case 0x00a4: return new Usage(this, id, "", UsageTypes.None);
                case 0x00a6: return new Usage(this, id, "", UsageTypes.None);
                case 0x00a8: return new Usage(this, id, "", UsageTypes.None);
                case 0x00aa: return new Usage(this, id, "", UsageTypes.None);
                case 0x00ac: return new Usage(this, id, "", UsageTypes.None);
                case 0x00ae: return new Usage(this, id, "", UsageTypes.None);
                case 0x00b0: return new Usage(this, id, "", UsageTypes.None);
                case 0x00ca: return new Usage(this, id, "", UsageTypes.None);
                case 0x00d4: return new Usage(this, id, "", UsageTypes.None);
            }

            return base.CreateUsage(id);
        }
    }

    /// <summary>
    ///     Base class for all usage pages.
    /// </summary>
    public sealed class MonitorReservedUsagePage : UsagePage
    {
        /// <summary>
        ///     Singleton instance of MonitorReserved Usage Page.
        /// </summary>
        public static readonly MonitorReservedUsagePage Instance = new MonitorReservedUsagePage();

        private MonitorReservedUsagePage() : base(0x0083, "MonitorReserved")
        {
        }

        /// <inheritdoc />
        protected override Usage CreateUsage(ushort id) 
        {
            switch (id)
            {
                case 0x0000: return new Usage(this, id, "Undefined", UsageTypes.None);
            }

            return base.CreateUsage(id);
        }
    }

    /// <summary>
    ///     Base class for all usage pages.
    /// </summary>
    public sealed class PowerDeviceUsagePage : UsagePage
    {
        /// <summary>
        ///     Singleton instance of PowerDevice Usage Page.
        /// </summary>
        public static readonly PowerDeviceUsagePage Instance = new PowerDeviceUsagePage();

        private PowerDeviceUsagePage() : base(0x0084, "PowerDevice")
        {
        }

        /// <inheritdoc />
        protected override Usage CreateUsage(ushort id) 
        {
            switch (id)
            {
                case 0x0000: return new Usage(this, id, "Undefined", UsageTypes.None);
                case 0x0001: return new Usage(this, id, "iName", UsageTypes.SV);
                case 0x0002: return new Usage(this, id, "Present Status", UsageTypes.CL);
                case 0x0003: return new Usage(this, id, "Changed Status", UsageTypes.CL);
                case 0x0004: return new Usage(this, id, "UPS", UsageTypes.CA);
                case 0x0005: return new Usage(this, id, "Power Supply", UsageTypes.CA);
                case 0x0006: return new Usage(this, id, "Peripheral Device", UsageTypes.CA);
                case 0x0010: return new Usage(this, id, "Battery System", UsageTypes.CP);
                case 0x0011: return new Usage(this, id, "Battery System ID", UsageTypes.SV);
                case 0x0012: return new Usage(this, id, "Battery", UsageTypes.CP);
                case 0x0013: return new Usage(this, id, "Battery ID", UsageTypes.SV);
                case 0x0014: return new Usage(this, id, "Charger", UsageTypes.CP);
                case 0x0015: return new Usage(this, id, "Charger ID", UsageTypes.SV);
                case 0x0016: return new Usage(this, id, "Power Converter", UsageTypes.CP);
                case 0x0017: return new Usage(this, id, "Power Converter ID", UsageTypes.SV);
                case 0x0018: return new Usage(this, id, "Outlet System", UsageTypes.CP);
                case 0x0019: return new Usage(this, id, "Outlet System ID", UsageTypes.SV);
                case 0x001a: return new Usage(this, id, "Input", UsageTypes.CP);
                case 0x001b: return new Usage(this, id, "Input ID", UsageTypes.SV);
                case 0x001c: return new Usage(this, id, "Output", UsageTypes.CP);
                case 0x001d: return new Usage(this, id, "Output ID", UsageTypes.SV);
                case 0x001e: return new Usage(this, id, "Flow", UsageTypes.CP);
                case 0x001f: return new Usage(this, id, "Flow ID", UsageTypes.SV);
                case 0x0020: return new Usage(this, id, "Outlet", UsageTypes.CP);
                case 0x0021: return new Usage(this, id, "Outlet ID", UsageTypes.SV);
                case 0x0022: return new Usage(this, id, "Gang", UsageTypes.CP);
                case 0x0023: return new Usage(this, id, "Gang ID", UsageTypes.SV);
                case 0x0030: return new Usage(this, id, "Voltage", UsageTypes.DV);
                case 0x0031: return new Usage(this, id, "Current", UsageTypes.DV);
                case 0x0032: return new Usage(this, id, "Frequency", UsageTypes.DV);
                case 0x0033: return new Usage(this, id, "Apparent Power", UsageTypes.DV);
                case 0x0034: return new Usage(this, id, "Active Power", UsageTypes.DV);
                case 0x0035: return new Usage(this, id, "Load (percent)", UsageTypes.DV);
                case 0x0036: return new Usage(this, id, "Temperature", UsageTypes.DV);
                case 0x0037: return new Usage(this, id, "Humidity", UsageTypes.DV);
                case 0x0038: return new Usage(this, id, "Bad Count", UsageTypes.DV);
                case 0x0040: return new Usage(this, id, "Nominal Voltage", UsageTypes.SV|UsageTypes.DV);
                case 0x0041: return new Usage(this, id, "Nominal Current", UsageTypes.SV|UsageTypes.DV);
                case 0x0042: return new Usage(this, id, "Nominal Frequency", UsageTypes.SV|UsageTypes.DV);
                case 0x0043: return new Usage(this, id, "Nominal Apparent Power", UsageTypes.SV|UsageTypes.DV);
                case 0x0044: return new Usage(this, id, "Nominal Active Power", UsageTypes.SV|UsageTypes.DV);
                case 0x0045: return new Usage(this, id, "Nominal Load (percent)", UsageTypes.SV|UsageTypes.DV);
                case 0x0046: return new Usage(this, id, "Nominal Temperature", UsageTypes.SV|UsageTypes.DV);
                case 0x0047: return new Usage(this, id, "Nominal Humidity", UsageTypes.SV|UsageTypes.DV);
                case 0x0050: return new Usage(this, id, "Switch On Control", UsageTypes.DV);
                case 0x0051: return new Usage(this, id, "Switch Off Control", UsageTypes.DV);
                case 0x0052: return new Usage(this, id, "Toggle Control", UsageTypes.DV);
                case 0x0053: return new Usage(this, id, "Low Voltage Transfer", UsageTypes.DV);
                case 0x0054: return new Usage(this, id, "High Voltage Transfer", UsageTypes.DV);
                case 0x0055: return new Usage(this, id, "Delay Before Reboot", UsageTypes.DV);
                case 0x0056: return new Usage(this, id, "Delay Before Startup", UsageTypes.DV);
                case 0x0057: return new Usage(this, id, "Delay Before Shutdown", UsageTypes.DV);
                case 0x0058: return new Usage(this, id, "Test", UsageTypes.DV);
                case 0x0059: return new Usage(this, id, "Module Reset", UsageTypes.DV);
                case 0x005a: return new Usage(this, id, "Audible Alarm Control", UsageTypes.DV);
                case 0x0060: return new Usage(this, id, "Present", UsageTypes.DF);
                case 0x0061: return new Usage(this, id, "Good", UsageTypes.DF);
                case 0x0062: return new Usage(this, id, "Internal Failure", UsageTypes.DF);
                case 0x0063: return new Usage(this, id, "Voltage Out Of Range", UsageTypes.DF);
                case 0x0064: return new Usage(this, id, "Frequency Out Of Range", UsageTypes.DF);
                case 0x0065: return new Usage(this, id, "Overload", UsageTypes.DF);
                case 0x0066: return new Usage(this, id, "Overcharged", UsageTypes.DF);
                case 0x0067: return new Usage(this, id, "Over Temperature", UsageTypes.DF);
                case 0x0068: return new Usage(this, id, "Shutdown Requested", UsageTypes.DF);
                case 0x0069: return new Usage(this, id, "Shutdown Imminent", UsageTypes.DF);
                case 0x006b: return new Usage(this, id, "Switch On/Off", UsageTypes.DF);
                case 0x006c: return new Usage(this, id, "Switchable", UsageTypes.DF);
                case 0x006d: return new Usage(this, id, "Used", UsageTypes.DF);
                case 0x006e: return new Usage(this, id, "Boost", UsageTypes.DF);
                case 0x006f: return new Usage(this, id, "Buck", UsageTypes.DF);
                case 0x0070: return new Usage(this, id, "Initialized", UsageTypes.DF);
                case 0x0071: return new Usage(this, id, "Tested", UsageTypes.DF);
                case 0x0072: return new Usage(this, id, "Awaiting Power", UsageTypes.DF);
                case 0x0073: return new Usage(this, id, "Communication Lost", UsageTypes.DF);
                case 0x00fd: return new Usage(this, id, "iManufacturer", UsageTypes.SV);
                case 0x00fe: return new Usage(this, id, "iProduct", UsageTypes.SV);
                case 0x00ff: return new Usage(this, id, "iSerialNumber", UsageTypes.SV);
            }

            return base.CreateUsage(id);
        }
    }

    /// <summary>
    ///     Base class for all usage pages.
    /// </summary>
    public sealed class BatterySystemUsagePage : UsagePage
    {
        /// <summary>
        ///     Singleton instance of BatterySystem Usage Page.
        /// </summary>
        public static readonly BatterySystemUsagePage Instance = new BatterySystemUsagePage();

        private BatterySystemUsagePage() : base(0x0085, "BatterySystem")
        {
        }

        /// <inheritdoc />
        protected override Usage CreateUsage(ushort id) 
        {
            switch (id)
            {
                case 0x0000: return new Usage(this, id, "Undefined", UsageTypes.None);
                case 0x0001: return new Usage(this, id, "SMB Battery Mode", UsageTypes.CL);
                case 0x0002: return new Usage(this, id, "SMB Battery Status", UsageTypes.CL);
                case 0x0003: return new Usage(this, id, "SMB Alarm Warning", UsageTypes.CL);
                case 0x0004: return new Usage(this, id, "SMB Charger Mode", UsageTypes.CL);
                case 0x0005: return new Usage(this, id, "SMB Charger Status", UsageTypes.CL);
                case 0x0006: return new Usage(this, id, "SMB Charger Spec Info", UsageTypes.CL);
                case 0x0007: return new Usage(this, id, "SMB Selector State", UsageTypes.CL);
                case 0x0008: return new Usage(this, id, "SMB Selector Presets", UsageTypes.CL);
                case 0x0009: return new Usage(this, id, "SMB Selector Info", UsageTypes.CL);
                case 0x0010: return new Usage(this, id, "Optional Mfg Function 1", UsageTypes.DV);
                case 0x0011: return new Usage(this, id, "Optional Mfg Function 2", UsageTypes.DV);
                case 0x0012: return new Usage(this, id, "Optional Mfg Function 3", UsageTypes.DV);
                case 0x0013: return new Usage(this, id, "Optional Mfg Function 4", UsageTypes.DV);
                case 0x0014: return new Usage(this, id, "Optional Mfg Function 5", UsageTypes.DV);
                case 0x0015: return new Usage(this, id, "Connection To SMBus", UsageTypes.DF);
                case 0x0016: return new Usage(this, id, "Output Connection", UsageTypes.DF);
                case 0x0017: return new Usage(this, id, "Charger Connection", UsageTypes.DF);
                case 0x0018: return new Usage(this, id, "Battery Insertion", UsageTypes.DF);
                case 0x0019: return new Usage(this, id, "Use Next", UsageTypes.DF);
                case 0x001a: return new Usage(this, id, "OK To Use", UsageTypes.DF);
                case 0x001b: return new Usage(this, id, "Battery Supported", UsageTypes.DF);
                case 0x001c: return new Usage(this, id, "Selector Revision", UsageTypes.DF);
                case 0x001d: return new Usage(this, id, "Charging Indicator", UsageTypes.DF);
                case 0x0028: return new Usage(this, id, "Manufacturer Access", UsageTypes.DV);
                case 0x0029: return new Usage(this, id, "Remaining Capacity Limit", UsageTypes.DV);
                case 0x002a: return new Usage(this, id, "Remaining Time Limit", UsageTypes.DV);
                case 0x002b: return new Usage(this, id, "At Rate", UsageTypes.DV);
                case 0x002c: return new Usage(this, id, "Capacity Mode", UsageTypes.DV);
                case 0x002d: return new Usage(this, id, "Broadcast To Charger", UsageTypes.DV);
                case 0x002e: return new Usage(this, id, "Primary Battery", UsageTypes.DV);
                case 0x002f: return new Usage(this, id, "Charge Controller", UsageTypes.DV);
                case 0x0040: return new Usage(this, id, "Terminate Charge", UsageTypes.DF);
                case 0x0041: return new Usage(this, id, "Terminate Discharge", UsageTypes.DF);
                case 0x0042: return new Usage(this, id, "Below Remaining Capacity Limit", UsageTypes.DF);
                case 0x0043: return new Usage(this, id, "Remaining Time Limit Expired", UsageTypes.DF);
                case 0x0044: return new Usage(this, id, "Charging", UsageTypes.DF);
                case 0x0045: return new Usage(this, id, "Discharging", UsageTypes.DV);
                case 0x0046: return new Usage(this, id, "Fully Charged", UsageTypes.DF);
                case 0x0047: return new Usage(this, id, "Fully Discharged", UsageTypes.DV);
                case 0x0048: return new Usage(this, id, "Conditioning Flag", UsageTypes.DV);
                case 0x0049: return new Usage(this, id, "At Rate OK", UsageTypes.DV);
                case 0x004a: return new Usage(this, id, "SMB Error Code", UsageTypes.DF);
                case 0x004b: return new Usage(this, id, "Need Replacement", UsageTypes.DF);
                case 0x0060: return new Usage(this, id, "At Rate Time To Full", UsageTypes.DV);
                case 0x0061: return new Usage(this, id, "At Rate Time To Empty", UsageTypes.DV);
                case 0x0062: return new Usage(this, id, "Average Current", UsageTypes.DV);
                case 0x0063: return new Usage(this, id, "Max Error", UsageTypes.DV);
                case 0x0064: return new Usage(this, id, "Relative State Of Charge", UsageTypes.DV);
                case 0x0065: return new Usage(this, id, "Absolute State Of Charge", UsageTypes.DV);
                case 0x0066: return new Usage(this, id, "Remaining Capacity", UsageTypes.DV);
                case 0x0067: return new Usage(this, id, "Full Charge Capacity", UsageTypes.DV);
                case 0x0068: return new Usage(this, id, "Run Time To Empty", UsageTypes.DV);
                case 0x0069: return new Usage(this, id, "Average Time To Empty", UsageTypes.DV);
                case 0x006a: return new Usage(this, id, "Average Time To Full", UsageTypes.DV);
                case 0x006b: return new Usage(this, id, "Cycle Count", UsageTypes.DV);
                case 0x0080: return new Usage(this, id, "Battery Pack Model Level", UsageTypes.SV);
                case 0x0081: return new Usage(this, id, "Internal Charge Controller", UsageTypes.SF);
                case 0x0082: return new Usage(this, id, "Primary Battery Support", UsageTypes.SF);
                case 0x0083: return new Usage(this, id, "Design Capacity", UsageTypes.SV);
                case 0x0084: return new Usage(this, id, "Specification Info", UsageTypes.SV);
                case 0x0085: return new Usage(this, id, "Manufacturer Date", UsageTypes.SV);
                case 0x0086: return new Usage(this, id, "Serial Number", UsageTypes.SV);
                case 0x0087: return new Usage(this, id, "iManufacturer", UsageTypes.SV);
                case 0x0088: return new Usage(this, id, "iDeviceName", UsageTypes.SV);
                case 0x0089: return new Usage(this, id, "iDeviceChemistry", UsageTypes.SV);
                case 0x008a: return new Usage(this, id, "Manufacturer Data", UsageTypes.SV);
                case 0x008b: return new Usage(this, id, "Rechargeable", UsageTypes.SV);
                case 0x008c: return new Usage(this, id, "Warning Capacity Limit", UsageTypes.SV);
                case 0x008d: return new Usage(this, id, "Capacity Granularity 1", UsageTypes.SV);
                case 0x008e: return new Usage(this, id, "Capacity Granularity 2", UsageTypes.SV);
                case 0x008f: return new Usage(this, id, "iOEMInformation", UsageTypes.SV);
                case 0x00c0: return new Usage(this, id, "Inhibit Charge", UsageTypes.DF);
                case 0x00c1: return new Usage(this, id, "Enable Polling", UsageTypes.DF);
                case 0x00c2: return new Usage(this, id, "Reset To Zero", UsageTypes.DF);
                case 0x00d0: return new Usage(this, id, "AC Present", UsageTypes.DF);
                case 0x00d1: return new Usage(this, id, "Battery Present", UsageTypes.DF);
                case 0x00d2: return new Usage(this, id, "Power Fail", UsageTypes.DF);
                case 0x00d3: return new Usage(this, id, "Alarm Inhibited", UsageTypes.DF);
                case 0x00d4: return new Usage(this, id, "Thermistor Under Range", UsageTypes.DF);
                case 0x00d5: return new Usage(this, id, "Thermistor Hot", UsageTypes.DF);
                case 0x00d6: return new Usage(this, id, "Thermistor Cold", UsageTypes.DF);
                case 0x00d7: return new Usage(this, id, "Thermistor Over Range", UsageTypes.DF);
                case 0x00d8: return new Usage(this, id, "Voltage Out Of Range", UsageTypes.DF);
                case 0x00d9: return new Usage(this, id, "Current Out Of Range", UsageTypes.DF);
                case 0x00da: return new Usage(this, id, "Current Not Regulated", UsageTypes.DF);
                case 0x00db: return new Usage(this, id, "Voltage Not Regulated", UsageTypes.DF);
                case 0x00dc: return new Usage(this, id, "Master Mode", UsageTypes.DF);
                case 0x00f0: return new Usage(this, id, "Charger Selector Support", UsageTypes.SF);
                case 0x00f1: return new Usage(this, id, "Charger Spec", UsageTypes.SV);
                case 0x00f2: return new Usage(this, id, "Level 2", UsageTypes.SF);
                case 0x00f3: return new Usage(this, id, "Level 3", UsageTypes.SF);
            }

            return base.CreateUsage(id);
        }
    }

    /// <summary>
    ///     Base class for all usage pages.
    /// </summary>
    public sealed class BarCodeScannerUsagePage : UsagePage
    {
        /// <summary>
        ///     Singleton instance of BarCodeScanner Usage Page.
        /// </summary>
        public static readonly BarCodeScannerUsagePage Instance = new BarCodeScannerUsagePage();

        private BarCodeScannerUsagePage() : base(0x008c, "BarCodeScanner")
        {
        }

        /// <inheritdoc />
        protected override Usage CreateUsage(ushort id) 
        {
            switch (id)
            {
                case 0x0000: return new Usage(this, id, "Undefined", UsageTypes.None);
                case 0x0001: return new Usage(this, id, "Bar Code Badge Reader", UsageTypes.CA);
                case 0x0002: return new Usage(this, id, "Bar Code Scanner", UsageTypes.CA);
                case 0x0003: return new Usage(this, id, "Dumb Bar Code Scanner", UsageTypes.CA);
                case 0x0004: return new Usage(this, id, "Cordless Scanner Base", UsageTypes.CA);
                case 0x0005: return new Usage(this, id, "Bar Code Scanner Cradle", UsageTypes.CA);
                case 0x0010: return new Usage(this, id, "Attribute Report", UsageTypes.CL);
                case 0x0011: return new Usage(this, id, "Settings Report", UsageTypes.CL);
                case 0x0012: return new Usage(this, id, "Scanned Data Report", UsageTypes.CL);
                case 0x0013: return new Usage(this, id, "Raw Scanned Data Report", UsageTypes.CL);
                case 0x0014: return new Usage(this, id, "Trigger Report", UsageTypes.CL);
                case 0x0015: return new Usage(this, id, "Status Report", UsageTypes.CL);
                case 0x0016: return new Usage(this, id, "UPC/EAN Control Report", UsageTypes.CL);
                case 0x0017: return new Usage(this, id, "EAN 2/3 Label Control Report", UsageTypes.CL);
                case 0x0018: return new Usage(this, id, "Code 39 Control Report", UsageTypes.CL);
                case 0x0019: return new Usage(this, id, "Interleaved 2 of 5 Control Report", UsageTypes.CL);
                case 0x001a: return new Usage(this, id, "Standard 2 of 5 Control Report", UsageTypes.CL);
                case 0x001b: return new Usage(this, id, "MSI Plessey Control Report", UsageTypes.CL);
                case 0x001c: return new Usage(this, id, "Codabar Control Report", UsageTypes.CL);
                case 0x001d: return new Usage(this, id, "Code 128 Control Report", UsageTypes.CL);
                case 0x001e: return new Usage(this, id, "Misc 1D Control Report", UsageTypes.CL);
                case 0x001f: return new Usage(this, id, "2D Control Report", UsageTypes.CL);
                case 0x0030: return new Usage(this, id, "Aiming/Pointer Mode", UsageTypes.SF);
                case 0x0031: return new Usage(this, id, "Bar Code Present Sensor", UsageTypes.SF);
                case 0x0032: return new Usage(this, id, "Class 1A Laser", UsageTypes.SF);
                case 0x0033: return new Usage(this, id, "Class 2 Laser", UsageTypes.SF);
                case 0x0034: return new Usage(this, id, "Heater Present", UsageTypes.SF);
                case 0x0035: return new Usage(this, id, "Contact Scanner", UsageTypes.SF);
                case 0x0036: return new Usage(this, id, "Electronic Article Surveillance Notification", UsageTypes.SF);
                case 0x0037: return new Usage(this, id, "Constant Electronic Article Surveillance", UsageTypes.SF);
                case 0x0038: return new Usage(this, id, "Error Indication", UsageTypes.SF);
                case 0x0039: return new Usage(this, id, "Fixed Beeper", UsageTypes.SF);
                case 0x003a: return new Usage(this, id, "Good Decode Indication", UsageTypes.SF);
                case 0x003b: return new Usage(this, id, "Hands Free Scanning", UsageTypes.SF);
                case 0x003c: return new Usage(this, id, "Intrinsically Safe", UsageTypes.SF);
                case 0x003d: return new Usage(this, id, "Class 1 Laser", UsageTypes.SF);
                case 0x003e: return new Usage(this, id, "Long Range Scanner", UsageTypes.SF);
                case 0x003f: return new Usage(this, id, "Mirror Speed Control", UsageTypes.SF);
                case 0x0040: return new Usage(this, id, "Not On File Indication", UsageTypes.SF);
                case 0x0041: return new Usage(this, id, "Programmable Beeper", UsageTypes.SF);
                case 0x0042: return new Usage(this, id, "Triggerless", UsageTypes.SF);
                case 0x0043: return new Usage(this, id, "Wand", UsageTypes.SF);
                case 0x0044: return new Usage(this, id, "Water Resistant", UsageTypes.SF);
                case 0x0045: return new Usage(this, id, "Multi-Range Scanner", UsageTypes.SF);
                case 0x0046: return new Usage(this, id, "Proximity Sensor", UsageTypes.SF);
                case 0x004d: return new Usage(this, id, "Fragment Decoding", UsageTypes.DF);
                case 0x004e: return new Usage(this, id, "Scanner Read Confidence", UsageTypes.DV);
                case 0x004f: return new Usage(this, id, "Data Prefix", UsageTypes.NAry);
                case 0x0050: return new Usage(this, id, "Prefix AIMI", UsageTypes.Sel);
                case 0x0051: return new Usage(this, id, "Prefix None", UsageTypes.Sel);
                case 0x0052: return new Usage(this, id, "Prefix Proprietary", UsageTypes.Sel);
                case 0x0055: return new Usage(this, id, "Active Time", UsageTypes.DV);
                case 0x0056: return new Usage(this, id, "Aiming Laser Pattern", UsageTypes.DF);
                case 0x0057: return new Usage(this, id, "Bar Code Present", UsageTypes.OOC);
                case 0x0058: return new Usage(this, id, "Beeper State", UsageTypes.OOC);
                case 0x0059: return new Usage(this, id, "Laser On Time", UsageTypes.DV);
                case 0x005a: return new Usage(this, id, "Laser State", UsageTypes.OOC);
                case 0x005b: return new Usage(this, id, "Lockout Time", UsageTypes.DV);
                case 0x005c: return new Usage(this, id, "Motor State", UsageTypes.OOC);
                case 0x005d: return new Usage(this, id, "Motor Timeout", UsageTypes.DV);
                case 0x005e: return new Usage(this, id, "Power On Reset Scanner", UsageTypes.DF);
                case 0x005f: return new Usage(this, id, "Prevent Read of Barcodes", UsageTypes.DF);
                case 0x0060: return new Usage(this, id, "Initiate Barcode Read", UsageTypes.DF);
                case 0x0061: return new Usage(this, id, "Trigger State", UsageTypes.OOC);
                case 0x0062: return new Usage(this, id, "Trigger Mode", UsageTypes.NAry);
                case 0x0063: return new Usage(this, id, "Trigger Mode Blinking Laser On", UsageTypes.Sel);
                case 0x0064: return new Usage(this, id, "Trigger Mode Continuous Laser On", UsageTypes.Sel);
                case 0x0065: return new Usage(this, id, "Trigger Mode Laser on while Pulled", UsageTypes.Sel);
                case 0x0066: return new Usage(this, id, "Trigger Mode Laser stays on after Trigger release", UsageTypes.Sel);
                case 0x006d: return new Usage(this, id, "Commit Parameters to NVM", UsageTypes.DF);
                case 0x006e: return new Usage(this, id, "Parameter Scanning", UsageTypes.DF);
                case 0x006f: return new Usage(this, id, "Parameters Changed", UsageTypes.OOC);
                case 0x0070: return new Usage(this, id, "Set parameter default values", UsageTypes.DF);
                case 0x0075: return new Usage(this, id, "Scanner In Cradle", UsageTypes.OOC);
                case 0x0076: return new Usage(this, id, "Scanner In Range", UsageTypes.OOC);
                case 0x007a: return new Usage(this, id, "Aim Duration", UsageTypes.DV);
                case 0x007b: return new Usage(this, id, "Good Read Lamp Duration", UsageTypes.DV);
                case 0x007c: return new Usage(this, id, "Good Read Lamp Intensity", UsageTypes.DV);
                case 0x007d: return new Usage(this, id, "Good Read LED", UsageTypes.DF);
                case 0x007e: return new Usage(this, id, "Good Read Tone Frequency", UsageTypes.DV);
                case 0x007f: return new Usage(this, id, "Good Read Tone Length", UsageTypes.DV);
                case 0x0080: return new Usage(this, id, "Good Read Tone Volume", UsageTypes.DV);
                case 0x0082: return new Usage(this, id, "No Read Message", UsageTypes.DF);
                case 0x0083: return new Usage(this, id, "Not on File Volume", UsageTypes.DV);
                case 0x0084: return new Usage(this, id, "Powerup Beep", UsageTypes.DF);
                case 0x0085: return new Usage(this, id, "Sound Error Beep", UsageTypes.DF);
                case 0x0086: return new Usage(this, id, "Sound Good Read Beep", UsageTypes.DF);
                case 0x0087: return new Usage(this, id, "Sound Not On File Beep", UsageTypes.DF);
                case 0x0088: return new Usage(this, id, "Good Read When to Write", UsageTypes.NAry);
                case 0x0089: return new Usage(this, id, "GRWTI After Decode", UsageTypes.Sel);
                case 0x008a: return new Usage(this, id, "GRWTI Beep/Lamp after transmit", UsageTypes.Sel);
                case 0x008b: return new Usage(this, id, "GRWTI No Beep/Lamp use at all", UsageTypes.Sel);
                case 0x0091: return new Usage(this, id, "Bookland EAN", UsageTypes.DF);
                case 0x0092: return new Usage(this, id, "Convert EAN 8 to 13 Type", UsageTypes.DF);
                case 0x0093: return new Usage(this, id, "Convert UPC A to EAN-13", UsageTypes.DF);
                case 0x0094: return new Usage(this, id, "Convert UPC-E to A", UsageTypes.DF);
                case 0x0095: return new Usage(this, id, "EAN-13", UsageTypes.DF);
                case 0x0096: return new Usage(this, id, "EAN-8", UsageTypes.DF);
                case 0x0097: return new Usage(this, id, "EAN-99 128_Mandatory", UsageTypes.DF);
                case 0x0098: return new Usage(this, id, "EAN-99 P5/128_Optional", UsageTypes.DF);
                case 0x009a: return new Usage(this, id, "UPC/EAN", UsageTypes.DF);
                case 0x009b: return new Usage(this, id, "UPC/EAN Coupon Code", UsageTypes.DF);
                case 0x009c: return new Usage(this, id, "UPC/EAN Periodicals", UsageTypes.DV);
                case 0x009d: return new Usage(this, id, "UPC-A", UsageTypes.DF);
                case 0x009e: return new Usage(this, id, "UPC-A with 128 Mandatory", UsageTypes.DF);
                case 0x009f: return new Usage(this, id, "UPC-A with 128 Optional", UsageTypes.DF);
                case 0x00a0: return new Usage(this, id, "UPC-A with P5 Optional", UsageTypes.DF);
                case 0x00a1: return new Usage(this, id, "UPC-E", UsageTypes.DF);
                case 0x00a2: return new Usage(this, id, "UPC-E1", UsageTypes.DF);
                case 0x00a9: return new Usage(this, id, "Periodical", UsageTypes.NAry);
                case 0x00aa: return new Usage(this, id, "Periodical Auto-Discriminate + 2", UsageTypes.Sel);
                case 0x00ab: return new Usage(this, id, "Periodical Only Decode with + 2", UsageTypes.Sel);
                case 0x00ac: return new Usage(this, id, "Periodical Ignore + 2", UsageTypes.Sel);
                case 0x00ad: return new Usage(this, id, "Periodical Auto-Discriminate + 5", UsageTypes.Sel);
                case 0x00ae: return new Usage(this, id, "Periodical Only Decode with + 5", UsageTypes.Sel);
                case 0x00af: return new Usage(this, id, "Periodical Ignore + 5", UsageTypes.Sel);
                case 0x00b0: return new Usage(this, id, "Check", UsageTypes.NAry);
                case 0x00b1: return new Usage(this, id, "Check Disable Price", UsageTypes.Sel);
                case 0x00b2: return new Usage(this, id, "Check Enable 4 digit Price", UsageTypes.Sel);
                case 0x00b3: return new Usage(this, id, "Check Enable 5 digit Price", UsageTypes.Sel);
                case 0x00b4: return new Usage(this, id, "Check Enable European 4 digit Price", UsageTypes.Sel);
                case 0x00b5: return new Usage(this, id, "Check Enable European 5 digit Price", UsageTypes.Sel);
                case 0x00b7: return new Usage(this, id, "EAN Two Label", UsageTypes.DF);
                case 0x00b8: return new Usage(this, id, "EAN Three Label", UsageTypes.DF);
                case 0x00b9: return new Usage(this, id, "EAN 8 Flag Digit 1", UsageTypes.DV);
                case 0x00ba: return new Usage(this, id, "EAN 8 Flag Digit 2", UsageTypes.DV);
                case 0x00bb: return new Usage(this, id, "EAN 8 Flag Digit 3", UsageTypes.DV);
                case 0x00bc: return new Usage(this, id, "EAN 13 Flag Digit 1", UsageTypes.DV);
                case 0x00bd: return new Usage(this, id, "EAN 13 Flag Digit 2", UsageTypes.DV);
                case 0x00be: return new Usage(this, id, "EAN 13 Flag Digit 3", UsageTypes.DV);
                case 0x00bf: return new Usage(this, id, "Add EAN 2/3 Label Definition", UsageTypes.DF);
                case 0x00c0: return new Usage(this, id, "Clear all EAN 2/3 Label Definitions", UsageTypes.DF);
                case 0x00c3: return new Usage(this, id, "Codabar", UsageTypes.DF);
                case 0x00c4: return new Usage(this, id, "Code 128", UsageTypes.DF);
                case 0x00c7: return new Usage(this, id, "Code 39", UsageTypes.DF);
                case 0x00c8: return new Usage(this, id, "Code 93", UsageTypes.DF);
                case 0x00c9: return new Usage(this, id, "Full ASCII Conversion", UsageTypes.DF);
                case 0x00ca: return new Usage(this, id, "Interleaved 2 of 5", UsageTypes.DF);
                case 0x00cb: return new Usage(this, id, "Italian Pharmacy Code", UsageTypes.DF);
                case 0x00cc: return new Usage(this, id, "MSI/Plessey", UsageTypes.DF);
                case 0x00cd: return new Usage(this, id, "Standard 2 of 5 IATA", UsageTypes.DF);
                case 0x00ce: return new Usage(this, id, "Standard 2 of 5", UsageTypes.DF);
                case 0x00d3: return new Usage(this, id, "Transmit Start/Stop", UsageTypes.DF);
                case 0x00d4: return new Usage(this, id, "Tri-Optic", UsageTypes.DF);
                case 0x00d5: return new Usage(this, id, "UCC/EAN-128", UsageTypes.DF);
                case 0x00d6: return new Usage(this, id, "Check Digit", UsageTypes.NAry);
                case 0x00d7: return new Usage(this, id, "Check Digit Disable", UsageTypes.Sel);
                case 0x00d8: return new Usage(this, id, "Check Digit Enable Interleaved 2 of 5 OPCC", UsageTypes.Sel);
                case 0x00d9: return new Usage(this, id, "Check Digit Enable Interleaved 2 of 5 USS", UsageTypes.Sel);
                case 0x00da: return new Usage(this, id, "Check Digit Enable Standard 2 of 5 OPCC", UsageTypes.Sel);
                case 0x00db: return new Usage(this, id, "Check Digit Enable Standard 2 of 5 USS", UsageTypes.Sel);
                case 0x00dc: return new Usage(this, id, "Check Digit Enable One MSI Plessey", UsageTypes.Sel);
                case 0x00dd: return new Usage(this, id, "Check Digit Enable Two MSI Plessey", UsageTypes.Sel);
                case 0x00de: return new Usage(this, id, "Check Digit Codabar Enable", UsageTypes.Sel);
                case 0x00df: return new Usage(this, id, "Check Digit Code 39 Enable", UsageTypes.Sel);
                case 0x00f0: return new Usage(this, id, "Transmit Check Digit", UsageTypes.NAry);
                case 0x00f1: return new Usage(this, id, "Disable Check Digit Transmit", UsageTypes.Sel);
                case 0x00f2: return new Usage(this, id, "Enable Check Digit Transmit", UsageTypes.Sel);
                case 0x00fb: return new Usage(this, id, "Symbology Identifier", UsageTypes.DV);
                case 0x00fc: return new Usage(this, id, "Symbology Identifier", UsageTypes.DV);
                case 0x00fd: return new Usage(this, id, "Symbology Identifier", UsageTypes.DV);
                case 0x00fe: return new Usage(this, id, "Decoded Data", UsageTypes.DV);
                case 0x00ff: return new Usage(this, id, "Decode Data Continued", UsageTypes.DF);
                case 0x0100: return new Usage(this, id, "Bar Space Data", UsageTypes.DV);
                case 0x0101: return new Usage(this, id, "Scanner Data Accuracy", UsageTypes.DV);
                case 0x0102: return new Usage(this, id, "Raw Data Polarity", UsageTypes.NAry);
                case 0x0103: return new Usage(this, id, "Polarity Inverted Bar Code", UsageTypes.Sel);
                case 0x0104: return new Usage(this, id, "Polarity Normal Bar Code", UsageTypes.Sel);
                case 0x0106: return new Usage(this, id, "Minimum Length to Decode", UsageTypes.DV);
                case 0x0107: return new Usage(this, id, "Maximum Length to Decode", UsageTypes.DV);
                case 0x0108: return new Usage(this, id, "First Discrete Length to Decode", UsageTypes.DV);
                case 0x0109: return new Usage(this, id, "Second Discrete Length to Decode", UsageTypes.DV);
                case 0x010a: return new Usage(this, id, "Data Length Method", UsageTypes.NAry);
                case 0x010b: return new Usage(this, id, "DL Method Read any", UsageTypes.Sel);
                case 0x010c: return new Usage(this, id, "DL Method Check in Range", UsageTypes.Sel);
                case 0x010d: return new Usage(this, id, "DL Method Check for Discrete", UsageTypes.Sel);
                case 0x0110: return new Usage(this, id, "Aztec Code", UsageTypes.DF);
                case 0x0111: return new Usage(this, id, "BC412", UsageTypes.DF);
                case 0x0112: return new Usage(this, id, "Channel Code", UsageTypes.DF);
                case 0x0113: return new Usage(this, id, "Code 16", UsageTypes.DF);
                case 0x0114: return new Usage(this, id, "Code 32", UsageTypes.DF);
                case 0x0115: return new Usage(this, id, "Code 49", UsageTypes.DF);
                case 0x0116: return new Usage(this, id, "Code One", UsageTypes.DF);
                case 0x0117: return new Usage(this, id, "Colorcode", UsageTypes.DF);
                case 0x0118: return new Usage(this, id, "Data Matrix", UsageTypes.DF);
                case 0x0119: return new Usage(this, id, "MaxiCode", UsageTypes.DF);
                case 0x011a: return new Usage(this, id, "MicroPDF", UsageTypes.DF);
                case 0x011b: return new Usage(this, id, "PDF-417", UsageTypes.DF);
                case 0x011c: return new Usage(this, id, "PosiCode", UsageTypes.DF);
                case 0x011d: return new Usage(this, id, "QR Code", UsageTypes.DF);
                case 0x011e: return new Usage(this, id, "SuperCode", UsageTypes.DF);
                case 0x011f: return new Usage(this, id, "UltraCode", UsageTypes.DF);
                case 0x0120: return new Usage(this, id, "USD-5 (Slug Code)", UsageTypes.DF);
                case 0x0121: return new Usage(this, id, "VeriCode", UsageTypes.DF);
            }

            return base.CreateUsage(id);
        }
    }

    /// <summary>
    ///     Base class for all usage pages.
    /// </summary>
    public sealed class WeighingDevicesUsagePage : UsagePage
    {
        /// <summary>
        ///     Singleton instance of WeighingDevices Usage Page.
        /// </summary>
        public static readonly WeighingDevicesUsagePage Instance = new WeighingDevicesUsagePage();

        private WeighingDevicesUsagePage() : base(0x008d, "WeighingDevices")
        {
        }

        /// <inheritdoc />
        protected override Usage CreateUsage(ushort id) 
        {
            switch (id)
            {
                case 0x0000: return new Usage(this, id, "Undefined", UsageTypes.None);
                case 0x0001: return new Usage(this, id, "Weighing Device", UsageTypes.CA);
                case 0x0020: return new Usage(this, id, "Scale Device", UsageTypes.CL|UsageTypes.NAry);
                case 0x0021: return new Usage(this, id, "Scale Class I Metric", UsageTypes.Sel);
                case 0x0022: return new Usage(this, id, "Scale Class I Metric", UsageTypes.Sel);
                case 0x0023: return new Usage(this, id, "Scale Class II Metric", UsageTypes.Sel);
                case 0x0024: return new Usage(this, id, "Scale Class III Metric", UsageTypes.Sel);
                case 0x0025: return new Usage(this, id, "Scale Class IIIL Metric", UsageTypes.Sel);
                case 0x0026: return new Usage(this, id, "Scale Class IV Metric", UsageTypes.Sel);
                case 0x0027: return new Usage(this, id, "Scale Class III English", UsageTypes.Sel);
                case 0x0028: return new Usage(this, id, "Scale Class IIIL English", UsageTypes.Sel);
                case 0x0029: return new Usage(this, id, "Scale Class IV English", UsageTypes.Sel);
                case 0x002a: return new Usage(this, id, "Scale Class Generic", UsageTypes.Sel);
                case 0x0030: return new Usage(this, id, "Scale Attribute Report", UsageTypes.CL);
                case 0x0031: return new Usage(this, id, "Scale Control Report", UsageTypes.CL);
                case 0x0032: return new Usage(this, id, "Scale Data Report", UsageTypes.CL);
                case 0x0033: return new Usage(this, id, "Scale Status Report", UsageTypes.CL);
                case 0x0034: return new Usage(this, id, "Scale Weight Limit Report", UsageTypes.CL);
                case 0x0035: return new Usage(this, id, "Scale Statistics Report", UsageTypes.CL);
                case 0x0040: return new Usage(this, id, "Data Weight", UsageTypes.DV);
                case 0x0041: return new Usage(this, id, "Data Scaling", UsageTypes.DV);
                case 0x0050: return new Usage(this, id, "Weight Unit", UsageTypes.CL|UsageTypes.NAry);
                case 0x0051: return new Usage(this, id, "Weight Unit Milligram", UsageTypes.Sel);
                case 0x0052: return new Usage(this, id, "Weight Unit Gram", UsageTypes.Sel);
                case 0x0053: return new Usage(this, id, "Weight Unit Kilogram", UsageTypes.Sel);
                case 0x0054: return new Usage(this, id, "Weight Unit Carats", UsageTypes.Sel);
                case 0x0055: return new Usage(this, id, "Weight Unit Taels", UsageTypes.Sel);
                case 0x0056: return new Usage(this, id, "Weight Unit Grains", UsageTypes.Sel);
                case 0x0057: return new Usage(this, id, "Weight Unit Pennyweights", UsageTypes.Sel);
                case 0x0058: return new Usage(this, id, "Weight Unit Metric Ton", UsageTypes.Sel);
                case 0x0059: return new Usage(this, id, "Weight Unit Avoir Ton", UsageTypes.Sel);
                case 0x005a: return new Usage(this, id, "Weight Unit Troy Ounce", UsageTypes.Sel);
                case 0x005b: return new Usage(this, id, "Weight Unit Ounce", UsageTypes.Sel);
                case 0x005c: return new Usage(this, id, "Weight Unit Pound", UsageTypes.Sel);
                case 0x0060: return new Usage(this, id, "Calibration Count", UsageTypes.DV);
                case 0x0061: return new Usage(this, id, "Re-Zero Count", UsageTypes.DV);
                case 0x0070: return new Usage(this, id, "Scale Status", UsageTypes.CL|UsageTypes.NAry);
                case 0x0071: return new Usage(this, id, "Scale Status Fault", UsageTypes.Sel);
                case 0x0072: return new Usage(this, id, "Scale Status Stable at Center of Zero", UsageTypes.Sel);
                case 0x0073: return new Usage(this, id, "Scale Status In Motion", UsageTypes.Sel);
                case 0x0074: return new Usage(this, id, "Scale Status Weight Stable", UsageTypes.Sel);
                case 0x0075: return new Usage(this, id, "Scale Status Under Zero", UsageTypes.Sel);
                case 0x0076: return new Usage(this, id, "Scale Status Over Weight Limit", UsageTypes.Sel);
                case 0x0077: return new Usage(this, id, "Scale Status Requires Calibration", UsageTypes.Sel);
                case 0x0078: return new Usage(this, id, "Scale Status Requires Rezeroing", UsageTypes.Sel);
                case 0x0080: return new Usage(this, id, "Zero Scale", UsageTypes.OOC);
                case 0x0081: return new Usage(this, id, "Enforced Zero Return", UsageTypes.OOC);
            }

            return base.CreateUsage(id);
        }
    }

    /// <summary>
    ///     Base class for all usage pages.
    /// </summary>
    public sealed class MagneticStripeReadingMSRDevicesUsagePage : UsagePage
    {
        /// <summary>
        ///     Singleton instance of MagneticStripeReadingMSRDevices Usage Page.
        /// </summary>
        public static readonly MagneticStripeReadingMSRDevicesUsagePage Instance = new MagneticStripeReadingMSRDevicesUsagePage();

        private MagneticStripeReadingMSRDevicesUsagePage() : base(0x008e, "MagneticStripeReadingMSRDevices")
        {
        }

        /// <inheritdoc />
        protected override Usage CreateUsage(ushort id) 
        {
            switch (id)
            {
                case 0x0000: return new Usage(this, id, "Undefined", UsageTypes.None);
                case 0x0001: return new Usage(this, id, "MSR Device Read-Only", UsageTypes.CA);
                case 0x0011: return new Usage(this, id, "Track 1 Length", UsageTypes.SF|UsageTypes.DF|UsageTypes.Sel);
                case 0x0012: return new Usage(this, id, "Track 2 Length", UsageTypes.SF|UsageTypes.DF|UsageTypes.Sel);
                case 0x0013: return new Usage(this, id, "Track 3 Length", UsageTypes.SF|UsageTypes.DF|UsageTypes.Sel);
                case 0x0014: return new Usage(this, id, "Track JIS Length", UsageTypes.SF|UsageTypes.DF|UsageTypes.Sel);
                case 0x0020: return new Usage(this, id, "Track Data", UsageTypes.SF|UsageTypes.DF|UsageTypes.Sel);
                case 0x0021: return new Usage(this, id, "Track 1 Data", UsageTypes.SF|UsageTypes.DF|UsageTypes.Sel);
                case 0x0022: return new Usage(this, id, "Track 2 Data", UsageTypes.SF|UsageTypes.DF|UsageTypes.Sel);
                case 0x0023: return new Usage(this, id, "Track 3 Data", UsageTypes.SF|UsageTypes.DF|UsageTypes.Sel);
                case 0x0024: return new Usage(this, id, "Track JIS Data", UsageTypes.SF|UsageTypes.DF|UsageTypes.Sel);
            }

            return base.CreateUsage(id);
        }
    }

    /// <summary>
    ///     Base class for all usage pages.
    /// </summary>
    public sealed class ReservedPointOfSaleUsagePage : UsagePage
    {
        /// <summary>
        ///     Singleton instance of ReservedPointOfSale Usage Page.
        /// </summary>
        public static readonly ReservedPointOfSaleUsagePage Instance = new ReservedPointOfSaleUsagePage();

        private ReservedPointOfSaleUsagePage() : base(0x008f, "ReservedPointOfSale")
        {
        }

        /// <inheritdoc />
        protected override Usage CreateUsage(ushort id) 
        {
            switch (id)
            {
                case 0x0000: return new Usage(this, id, "Undefined", UsageTypes.None);
            }

            return base.CreateUsage(id);
        }
    }

    /// <summary>
    ///     Base class for all usage pages.
    /// </summary>
    public sealed class CameraControlUsagePage : UsagePage
    {
        /// <summary>
        ///     Singleton instance of CameraControl Usage Page.
        /// </summary>
        public static readonly CameraControlUsagePage Instance = new CameraControlUsagePage();

        private CameraControlUsagePage() : base(0x0090, "CameraControl")
        {
        }

        /// <inheritdoc />
        protected override Usage CreateUsage(ushort id) 
        {
            switch (id)
            {
                case 0x0000: return new Usage(this, id, "Undefined", UsageTypes.None);
                case 0x0020: return new Usage(this, id, "Camera Auto-focus", UsageTypes.OSC);
                case 0x0021: return new Usage(this, id, "Camera Shutter", UsageTypes.OSC);
            }

            return base.CreateUsage(id);
        }
    }

    /// <summary>
    ///     Base class for all usage pages.
    /// </summary>
    public sealed class ArcadeUsagePage : UsagePage
    {
        /// <summary>
        ///     Singleton instance of Arcade Usage Page.
        /// </summary>
        public static readonly ArcadeUsagePage Instance = new ArcadeUsagePage();

        private ArcadeUsagePage() : base(0x0091, "Arcade")
        {
        }

        /// <inheritdoc />
        protected override Usage CreateUsage(ushort id) 
        {
            switch (id)
            {
                case 0x0000: return new Usage(this, id, "Undefined", UsageTypes.None);
                case 0x0001: return new Usage(this, id, "General Purpose IO Card", UsageTypes.CA);
                case 0x0002: return new Usage(this, id, "Coin Door", UsageTypes.CA);
                case 0x0003: return new Usage(this, id, "Watchdog Timer", UsageTypes.CA);
                case 0x0030: return new Usage(this, id, "General Purpose Analog Input State", UsageTypes.DV);
                case 0x0031: return new Usage(this, id, "General Purpose Digital Input State", UsageTypes.DV);
                case 0x0032: return new Usage(this, id, "General Purpose Optical Input State", UsageTypes.DV);
                case 0x0033: return new Usage(this, id, "General Purpose Digital Output State", UsageTypes.DV);
                case 0x0034: return new Usage(this, id, "Number of Coin Doors", UsageTypes.DV);
                case 0x0035: return new Usage(this, id, "Coin Drawer Drop Count", UsageTypes.DV);
                case 0x0036: return new Usage(this, id, "Coin Drawer Start", UsageTypes.OOC);
                case 0x0037: return new Usage(this, id, "Coin Drawer Service", UsageTypes.OOC);
                case 0x0038: return new Usage(this, id, "Coin Drawer Tilt", UsageTypes.OOC);
                case 0x0039: return new Usage(this, id, "Coin Door Test", UsageTypes.OOC);
                case 0x0040: return new Usage(this, id, "Coin Door Lockout", UsageTypes.OOC);
                case 0x0041: return new Usage(this, id, "Watchdog Timeout", UsageTypes.DV);
                case 0x0042: return new Usage(this, id, "Watchdog Action", UsageTypes.NAry);
                case 0x0043: return new Usage(this, id, "Watchdog Reboot", UsageTypes.Sel);
                case 0x0044: return new Usage(this, id, "Watchdog Restart", UsageTypes.Sel);
                case 0x0045: return new Usage(this, id, "Alarm Input", UsageTypes.DV);
                case 0x0046: return new Usage(this, id, "Coin Door Counter", UsageTypes.OOC);
                case 0x0047: return new Usage(this, id, "I/O Direction Mapping", UsageTypes.DV);
                case 0x0048: return new Usage(this, id, "Set I/O Direction", UsageTypes.OOC);
                case 0x0049: return new Usage(this, id, "Extended Optical Input State", UsageTypes.DV);
                case 0x004a: return new Usage(this, id, "Pin Pad Input State", UsageTypes.DV);
                case 0x004b: return new Usage(this, id, "Pin Pad Status", UsageTypes.DV);
                case 0x004c: return new Usage(this, id, "Pin Pad Output", UsageTypes.OOC);
                case 0x004d: return new Usage(this, id, "Pin Pad Command", UsageTypes.DV);
            }

            return base.CreateUsage(id);
        }
    }

    /// <summary>
    ///     Base class for all usage pages.
    /// </summary>
    public sealed class FastIDentityOnlineAllianceUsagePage : UsagePage
    {
        /// <summary>
        ///     Singleton instance of FastIDentityOnlineAlliance Usage Page.
        /// </summary>
        public static readonly FastIDentityOnlineAllianceUsagePage Instance = new FastIDentityOnlineAllianceUsagePage();

        private FastIDentityOnlineAllianceUsagePage() : base(0xf1d0, "FastIDentityOnlineAlliance")
        {
        }

        /// <inheritdoc />
        protected override Usage CreateUsage(ushort id) 
        {
            switch (id)
            {
                case 0x0000: return new Usage(this, id, "Undefined", UsageTypes.None);
                case 0x0001: return new Usage(this, id, "U2F Authenticator Device", UsageTypes.CA);
                case 0x0020: return new Usage(this, id, "Input Report Data", UsageTypes.DV);
                case 0x0021: return new Usage(this, id, "Output Report Data", UsageTypes.DV);
            }

            return base.CreateUsage(id);
        }
    }
}
