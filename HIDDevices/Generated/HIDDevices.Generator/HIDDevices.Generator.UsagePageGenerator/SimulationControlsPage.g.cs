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
    //     Simulation Controls Usage Page.
    // </summary>
    [Description("Simulation Controls Usage Page")]
    public enum SimulationControlsPage : uint
    {
        // <summary>
        //     Undefined Usage.
        // </summary>
        [Description("Undefined")]
        Undefined = 0x00020000,

        // <summary>
        //     Flight Simulation Device Usage.
        // </summary>
        [Description("Flight Simulation Device")]
        FlightSimulationDevice = 0x00020001,

        // <summary>
        //     Automobile Simulation Device Usage.
        // </summary>
        [Description("Automobile Simulation Device")]
        AutomobileSimulationDevice = 0x00020002,

        // <summary>
        //     Tank Simulation Device Usage.
        // </summary>
        [Description("Tank Simulation Device")]
        TankSimulationDevice = 0x00020003,

        // <summary>
        //     Spaceship Simulation Device Usage.
        // </summary>
        [Description("Spaceship Simulation Device")]
        SpaceshipSimulationDevice = 0x00020004,

        // <summary>
        //     Submarine Simulation Device Usage.
        // </summary>
        [Description("Submarine Simulation Device")]
        SubmarineSimulationDevice = 0x00020005,

        // <summary>
        //     Sailing Simulation Device Usage.
        // </summary>
        [Description("Sailing Simulation Device")]
        SailingSimulationDevice = 0x00020006,

        // <summary>
        //     Motorcycle Simulation Device Usage.
        // </summary>
        [Description("Motorcycle Simulation Device")]
        MotorcycleSimulationDevice = 0x00020007,

        // <summary>
        //     Sports Simulation Device Usage.
        // </summary>
        [Description("Sports Simulation Device")]
        SportsSimulationDevice = 0x00020008,

        // <summary>
        //     Airplane Simulation Device Usage.
        // </summary>
        [Description("Airplane Simulation Device")]
        AirplaneSimulationDevice = 0x00020009,

        // <summary>
        //     Helicopter Simulation Device Usage.
        // </summary>
        [Description("Helicopter Simulation Device")]
        HelicopterSimulationDevice = 0x0002000a,

        // <summary>
        //     Magic Carpet Simulation Device Usage.
        // </summary>
        [Description("Magic Carpet Simulation Device")]
        MagicCarpetSimulationDevice = 0x0002000b,

        // <summary>
        //     Bicycle Simulation Device Usage.
        // </summary>
        [Description("Bicycle Simulation Device")]
        BicycleSimulationDevice = 0x0002000c,

        // <summary>
        //     Flight Control Stick Usage.
        // </summary>
        [Description("Flight Control Stick")]
        FlightControlStick = 0x00020020,

        // <summary>
        //     Flight Stick Usage.
        // </summary>
        [Description("Flight Stick")]
        FlightStick = 0x00020021,

        // <summary>
        //     Cyclic Control Usage.
        // </summary>
        [Description("Cyclic Control")]
        CyclicControl = 0x00020022,

        // <summary>
        //     Cyclic Trim Usage.
        // </summary>
        [Description("Cyclic Trim")]
        CyclicTrim = 0x00020023,

        // <summary>
        //     Flight Yoke Usage.
        // </summary>
        [Description("Flight Yoke")]
        FlightYoke = 0x00020024,

        // <summary>
        //     Track Control Usage.
        // </summary>
        [Description("Track Control")]
        TrackControl = 0x00020025,

        // <summary>
        //     Aileron Usage.
        // </summary>
        [Description("Aileron")]
        Aileron = 0x000200b0,

        // <summary>
        //     Aileron Trim Usage.
        // </summary>
        [Description("Aileron Trim")]
        AileronTrim = 0x000200b1,

        // <summary>
        //     Anti-Torque Control Usage.
        // </summary>
        [Description("Anti-Torque Control")]
        AntiTorqueControl = 0x000200b2,

        // <summary>
        //     Autopilot Enable Usage.
        // </summary>
        [Description("Autopilot Enable")]
        AutopilotEnable = 0x000200b3,

        // <summary>
        //     Chaff Release Usage.
        // </summary>
        [Description("Chaff Release")]
        ChaffRelease = 0x000200b4,

        // <summary>
        //     Collective Control Usage.
        // </summary>
        [Description("Collective Control")]
        CollectiveControl = 0x000200b5,

        // <summary>
        //     Dive Brake Usage.
        // </summary>
        [Description("Dive Brake")]
        DiveBrake = 0x000200b6,

        // <summary>
        //     Electronic Countermeasures Usage.
        // </summary>
        [Description("Electronic Countermeasures")]
        ElectronicCountermeasures = 0x000200b7,

        // <summary>
        //     Elevator Usage.
        // </summary>
        [Description("Elevator")]
        Elevator = 0x000200b8,

        // <summary>
        //     Elevator Trim Usage.
        // </summary>
        [Description("Elevator Trim")]
        ElevatorTrim = 0x000200b9,

        // <summary>
        //     Rudder Usage.
        // </summary>
        [Description("Rudder")]
        Rudder = 0x000200ba,

        // <summary>
        //     Throttle Usage.
        // </summary>
        [Description("Throttle")]
        Throttle = 0x000200bb,

        // <summary>
        //     Flight Communications Usage.
        // </summary>
        [Description("Flight Communications")]
        FlightCommunications = 0x000200bc,

        // <summary>
        //     Flare Release Usage.
        // </summary>
        [Description("Flare Release")]
        FlareRelease = 0x000200bd,

        // <summary>
        //     Landing Gear Usage.
        // </summary>
        [Description("Landing Gear")]
        LandingGear = 0x000200be,

        // <summary>
        //     Toe Brake Usage.
        // </summary>
        [Description("Toe Brake")]
        ToeBrake = 0x000200bf,

        // <summary>
        //     Trigger Usage.
        // </summary>
        [Description("Trigger")]
        Trigger = 0x000200c0,

        // <summary>
        //     Weapons Arm Usage.
        // </summary>
        [Description("Weapons Arm")]
        WeaponsArm = 0x000200c1,

        // <summary>
        //     Weapons Select Usage.
        // </summary>
        [Description("Weapons Select")]
        WeaponsSelect = 0x000200c2,

        // <summary>
        //     Wing Flaps Usage.
        // </summary>
        [Description("Wing Flaps")]
        WingFlaps = 0x000200c3,

        // <summary>
        //     Accelerator Usage.
        // </summary>
        [Description("Accelerator")]
        Accelerator = 0x000200c4,

        // <summary>
        //     Brake Usage.
        // </summary>
        [Description("Brake")]
        Brake = 0x000200c5,

        // <summary>
        //     Clutch Usage.
        // </summary>
        [Description("Clutch")]
        Clutch = 0x000200c6,

        // <summary>
        //     Shifter Usage.
        // </summary>
        [Description("Shifter")]
        Shifter = 0x000200c7,

        // <summary>
        //     Steering Usage.
        // </summary>
        [Description("Steering")]
        Steering = 0x000200c8,

        // <summary>
        //     Turret Direction Usage.
        // </summary>
        [Description("Turret Direction")]
        TurretDirection = 0x000200c9,

        // <summary>
        //     Barrel Elevation Usage.
        // </summary>
        [Description("Barrel Elevation")]
        BarrelElevation = 0x000200ca,

        // <summary>
        //     Dive Plane Usage.
        // </summary>
        [Description("Dive Plane")]
        DivePlane = 0x000200cb,

        // <summary>
        //     Ballast Usage.
        // </summary>
        [Description("Ballast")]
        Ballast = 0x000200cc,

        // <summary>
        //     Bicycle Crank Usage.
        // </summary>
        [Description("Bicycle Crank")]
        BicycleCrank = 0x000200cd,

        // <summary>
        //     Handle Bars Usage.
        // </summary>
        [Description("Handle Bars")]
        HandleBars = 0x000200ce,

        // <summary>
        //     Front Brake Usage.
        // </summary>
        [Description("Front Brake")]
        FrontBrake = 0x000200cf,

        // <summary>
        //     Rear Brake Usage.
        // </summary>
        [Description("Rear Brake")]
        RearBrake = 0x000200d0
    }
}
