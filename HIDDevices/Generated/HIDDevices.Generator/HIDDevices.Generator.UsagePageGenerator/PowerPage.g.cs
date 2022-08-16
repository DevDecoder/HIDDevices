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
    //     Power Usage Page.
    // </summary>
    [Description("Power Usage Page")]
    public enum PowerPage : uint
    {
        // <summary>
        //     Undefined Usage.
        // </summary>
        [Description("Undefined")]
        Undefined = 0x00840000,

        // <summary>
        //     iName Usage.
        // </summary>
        [Description("iName")]
        IName = 0x00840001,

        // <summary>
        //     Present Status Usage.
        // </summary>
        [Description("Present Status")]
        PresentStatus = 0x00840002,

        // <summary>
        //     Changed Status Usage.
        // </summary>
        [Description("Changed Status")]
        ChangedStatus = 0x00840003,

        // <summary>
        //     UPS Usage.
        // </summary>
        [Description("UPS")]
        UPS = 0x00840004,

        // <summary>
        //     Power Supply Usage.
        // </summary>
        [Description("Power Supply")]
        PowerSupply = 0x00840005,

        // <summary>
        //     Battery System Usage.
        // </summary>
        [Description("Battery System")]
        BatterySystem = 0x00840010,

        // <summary>
        //     Battery System Id Usage.
        // </summary>
        [Description("Battery System Id")]
        BatterySystemId = 0x00840011,

        // <summary>
        //     Battery Usage.
        // </summary>
        [Description("Battery")]
        Battery = 0x00840012,

        // <summary>
        //     Battery Id Usage.
        // </summary>
        [Description("Battery Id")]
        BatteryId = 0x00840013,

        // <summary>
        //     Charger Usage.
        // </summary>
        [Description("Charger")]
        Charger = 0x00840014,

        // <summary>
        //     Charger Id Usage.
        // </summary>
        [Description("Charger Id")]
        ChargerId = 0x00840015,

        // <summary>
        //     Power Converter Usage.
        // </summary>
        [Description("Power Converter")]
        PowerConverter = 0x00840016,

        // <summary>
        //     Power Converter Id Usage.
        // </summary>
        [Description("Power Converter Id")]
        PowerConverterId = 0x00840017,

        // <summary>
        //     Outlet System Usage.
        // </summary>
        [Description("Outlet System")]
        OutletSystem = 0x00840018,

        // <summary>
        //     Outlet System Id Usage.
        // </summary>
        [Description("Outlet System Id")]
        OutletSystemId = 0x00840019,

        // <summary>
        //     Input Usage.
        // </summary>
        [Description("Input")]
        Input = 0x0084001a,

        // <summary>
        //     Input Id Usage.
        // </summary>
        [Description("Input Id")]
        InputId = 0x0084001b,

        // <summary>
        //     Output Usage.
        // </summary>
        [Description("Output")]
        Output = 0x0084001c,

        // <summary>
        //     Output Id Usage.
        // </summary>
        [Description("Output Id")]
        OutputId = 0x0084001d,

        // <summary>
        //     Flow Usage.
        // </summary>
        [Description("Flow")]
        Flow = 0x0084001e,

        // <summary>
        //     Flow Id Usage.
        // </summary>
        [Description("Flow Id")]
        FlowId = 0x0084001f,

        // <summary>
        //     Outlet Usage.
        // </summary>
        [Description("Outlet")]
        Outlet = 0x00840020,

        // <summary>
        //     Outlet Id Usage.
        // </summary>
        [Description("Outlet Id")]
        OutletId = 0x00840021,

        // <summary>
        //     Gang Usage.
        // </summary>
        [Description("Gang")]
        Gang = 0x00840022,

        // <summary>
        //     Gang Id Usage.
        // </summary>
        [Description("Gang Id")]
        GangId = 0x00840023,

        // <summary>
        //     Power Summary Usage.
        // </summary>
        [Description("Power Summary")]
        PowerSummary = 0x00840024,

        // <summary>
        //     Power Summary Id Usage.
        // </summary>
        [Description("Power Summary Id")]
        PowerSummaryId = 0x00840025,

        // <summary>
        //     Voltage Usage.
        // </summary>
        [Description("Voltage")]
        Voltage = 0x00840030,

        // <summary>
        //     Current Usage.
        // </summary>
        [Description("Current")]
        Current = 0x00840031,

        // <summary>
        //     Frequency Usage.
        // </summary>
        [Description("Frequency")]
        Frequency = 0x00840032,

        // <summary>
        //     Apparent Power Usage.
        // </summary>
        [Description("Apparent Power")]
        ApparentPower = 0x00840033,

        // <summary>
        //     Active Power Usage.
        // </summary>
        [Description("Active Power")]
        ActivePower = 0x00840034,

        // <summary>
        //     Percent Load Usage.
        // </summary>
        [Description("Percent Load")]
        PercentLoad = 0x00840035,

        // <summary>
        //     Temperature Usage.
        // </summary>
        [Description("Temperature")]
        Temperature = 0x00840036,

        // <summary>
        //     Humidity Usage.
        // </summary>
        [Description("Humidity")]
        Humidity = 0x00840037,

        // <summary>
        //     Bad Count Usage.
        // </summary>
        [Description("Bad Count")]
        BadCount = 0x00840038,

        // <summary>
        //     Config Voltage Usage.
        // </summary>
        [Description("Config Voltage")]
        ConfigVoltage = 0x00840040,

        // <summary>
        //     Config Current Usage.
        // </summary>
        [Description("Config Current")]
        ConfigCurrent = 0x00840041,

        // <summary>
        //     Config Frequency Usage.
        // </summary>
        [Description("Config Frequency")]
        ConfigFrequency = 0x00840042,

        // <summary>
        //     Config Apparent Power Usage.
        // </summary>
        [Description("Config Apparent Power")]
        ConfigApparentPower = 0x00840043,

        // <summary>
        //     Config Active Power Usage.
        // </summary>
        [Description("Config Active Power")]
        ConfigActivePower = 0x00840044,

        // <summary>
        //     Config Percent Load Usage.
        // </summary>
        [Description("Config Percent Load")]
        ConfigPercentLoad = 0x00840045,

        // <summary>
        //     Config Temperature Usage.
        // </summary>
        [Description("Config Temperature")]
        ConfigTemperature = 0x00840046,

        // <summary>
        //     Config Humidity Usage.
        // </summary>
        [Description("Config Humidity")]
        ConfigHumidity = 0x00840047,

        // <summary>
        //     Switch On Control Usage.
        // </summary>
        [Description("Switch On Control")]
        SwitchOnControl = 0x00840050,

        // <summary>
        //     Switch Off Control Usage.
        // </summary>
        [Description("Switch Off Control")]
        SwitchOffControl = 0x00840051,

        // <summary>
        //     Toggle Control Usage.
        // </summary>
        [Description("Toggle Control")]
        ToggleControl = 0x00840052,

        // <summary>
        //     Low Voltage Transfer Usage.
        // </summary>
        [Description("Low Voltage Transfer")]
        LowVoltageTransfer = 0x00840053,

        // <summary>
        //     High Voltage Transfer Usage.
        // </summary>
        [Description("High Voltage Transfer")]
        HighVoltageTransfer = 0x00840054,

        // <summary>
        //     Delay Before Reboot Usage.
        // </summary>
        [Description("Delay Before Reboot")]
        DelayBeforeReboot = 0x00840055,

        // <summary>
        //     Delay Before Startup Usage.
        // </summary>
        [Description("Delay Before Startup")]
        DelayBeforeStartup = 0x00840056,

        // <summary>
        //     Delay Before Shutdown Usage.
        // </summary>
        [Description("Delay Before Shutdown")]
        DelayBeforeShutdown = 0x00840057,

        // <summary>
        //     Test Usage.
        // </summary>
        [Description("Test")]
        Test = 0x00840058,

        // <summary>
        //     Module Reset Usage.
        // </summary>
        [Description("Module Reset")]
        ModuleReset = 0x00840059,

        // <summary>
        //     Audible Alarm Control Usage.
        // </summary>
        [Description("Audible Alarm Control")]
        AudibleAlarmControl = 0x0084005a,

        // <summary>
        //     Present Usage.
        // </summary>
        [Description("Present")]
        Present = 0x00840060,

        // <summary>
        //     Good Usage.
        // </summary>
        [Description("Good")]
        Good = 0x00840061,

        // <summary>
        //     Internal Failure Usage.
        // </summary>
        [Description("Internal Failure")]
        InternalFailure = 0x00840062,

        // <summary>
        //     Voltag Out Of Range Usage.
        // </summary>
        [Description("Voltag Out Of Range")]
        VoltagOutOfRange = 0x00840063,

        // <summary>
        //     Frequency Out Of Range Usage.
        // </summary>
        [Description("Frequency Out Of Range")]
        FrequencyOutOfRange = 0x00840064,

        // <summary>
        //     Overload Usage.
        // </summary>
        [Description("Overload")]
        Overload = 0x00840065,

        // <summary>
        //     Over Charged Usage.
        // </summary>
        [Description("Over Charged")]
        OverCharged = 0x00840066,

        // <summary>
        //     Over Temperature Usage.
        // </summary>
        [Description("Over Temperature")]
        OverTemperature = 0x00840067,

        // <summary>
        //     Shutdown Requested Usage.
        // </summary>
        [Description("Shutdown Requested")]
        ShutdownRequested = 0x00840068,

        // <summary>
        //     Shutdown Imminent Usage.
        // </summary>
        [Description("Shutdown Imminent")]
        ShutdownImminent = 0x00840069,

        // <summary>
        //     Switch On/Off Usage.
        // </summary>
        [Description("Switch On/Off")]
        SwitchOnOff = 0x0084006b,

        // <summary>
        //     Switchable Usage.
        // </summary>
        [Description("Switchable")]
        Switchable = 0x0084006c,

        // <summary>
        //     Used Usage.
        // </summary>
        [Description("Used")]
        Used = 0x0084006d,

        // <summary>
        //     Boost Usage.
        // </summary>
        [Description("Boost")]
        Boost = 0x0084006e,

        // <summary>
        //     Buck Usage.
        // </summary>
        [Description("Buck")]
        Buck = 0x0084006f,

        // <summary>
        //     Initialized Usage.
        // </summary>
        [Description("Initialized")]
        Initialized = 0x00840070,

        // <summary>
        //     Tested Usage.
        // </summary>
        [Description("Tested")]
        Tested = 0x00840071,

        // <summary>
        //     Awaiting Power Usage.
        // </summary>
        [Description("Awaiting Power")]
        AwaitingPower = 0x00840072,

        // <summary>
        //     Communication Lost Usage.
        // </summary>
        [Description("Communication Lost")]
        CommunicationLost = 0x00840073,

        // <summary>
        //     iManufacturer Usage.
        // </summary>
        [Description("iManufacturer")]
        IManufacturer = 0x008400fd,

        // <summary>
        //     iProduct Usage.
        // </summary>
        [Description("iProduct")]
        IProduct = 0x008400fe,

        // <summary>
        //     iSerialNumber Usage.
        // </summary>
        [Description("iSerialNumber")]
        ISerialNumber = 0x008400ff
    }
}
