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
    //     Battery System Usage Page.
    // </summary>
    [Description("Battery System Usage Page")]
    public enum BatterySystemPage : uint
    {
        // <summary>
        //     Undefined Usage.
        // </summary>
        [Description("Undefined")]
        Undefined = 0x00850000,

        // <summary>
        //     Smart Battery Battery Mode Usage.
        // </summary>
        [Description("Smart Battery Battery Mode")]
        SmartBatteryBatteryMode = 0x00850001,

        // <summary>
        //     Smart Battery Battery Status Usage.
        // </summary>
        [Description("Smart Battery Battery Status")]
        SmartBatteryBatteryStatus = 0x00850002,

        // <summary>
        //     Smart Battery Alarm Warning Usage.
        // </summary>
        [Description("Smart Battery Alarm Warning")]
        SmartBatteryAlarmWarning = 0x00850003,

        // <summary>
        //     Smart Battery Charger Mode Usage.
        // </summary>
        [Description("Smart Battery Charger Mode")]
        SmartBatteryChargerMode = 0x00850004,

        // <summary>
        //     Smart Battery Charger Status Usage.
        // </summary>
        [Description("Smart Battery Charger Status")]
        SmartBatteryChargerStatus = 0x00850005,

        // <summary>
        //     Smart Battery Charger Spec Info Usage.
        // </summary>
        [Description("Smart Battery Charger Spec Info")]
        SmartBatteryChargerSpecInfo = 0x00850006,

        // <summary>
        //     Smart Battery Selector State Usage.
        // </summary>
        [Description("Smart Battery Selector State")]
        SmartBatterySelectorState = 0x00850007,

        // <summary>
        //     Smart Battery Selector Presets Usage.
        // </summary>
        [Description("Smart Battery Selector Presets")]
        SmartBatterySelectorPresets = 0x00850008,

        // <summary>
        //     Smart Battery Selector Info Usage.
        // </summary>
        [Description("Smart Battery Selector Info")]
        SmartBatterySelectorInfo = 0x00850009,

        // <summary>
        //     Optional Mfg Function 1 Usage.
        // </summary>
        [Description("Optional Mfg Function 1")]
        OptionalMfgFunction1 = 0x00850010,

        // <summary>
        //     Optional Mfg Function 2 Usage.
        // </summary>
        [Description("Optional Mfg Function 2")]
        OptionalMfgFunction2 = 0x00850011,

        // <summary>
        //     Optional Mfg Function 3 Usage.
        // </summary>
        [Description("Optional Mfg Function 3")]
        OptionalMfgFunction3 = 0x00850012,

        // <summary>
        //     Optional Mfg Function 4 Usage.
        // </summary>
        [Description("Optional Mfg Function 4")]
        OptionalMfgFunction4 = 0x00850013,

        // <summary>
        //     Optional Mfg Function 5 Usage.
        // </summary>
        [Description("Optional Mfg Function 5")]
        OptionalMfgFunction5 = 0x00850014,

        // <summary>
        //     Connection To SM Bus Usage.
        // </summary>
        [Description("Connection To SM Bus")]
        ConnectionToSMBus = 0x00850015,

        // <summary>
        //     Output Connection Usage.
        // </summary>
        [Description("Output Connection")]
        OutputConnection = 0x00850016,

        // <summary>
        //     Charger Connection Usage.
        // </summary>
        [Description("Charger Connection")]
        ChargerConnection = 0x00850017,

        // <summary>
        //     Battery Insertion Usage.
        // </summary>
        [Description("Battery Insertion")]
        BatteryInsertion = 0x00850018,

        // <summary>
        //     Use Next Usage.
        // </summary>
        [Description("Use Next")]
        UseNext = 0x00850019,

        // <summary>
        //     OK To Use Usage.
        // </summary>
        [Description("OK To Use")]
        OKToUse = 0x0085001a,

        // <summary>
        //     Battery Supported Usage.
        // </summary>
        [Description("Battery Supported")]
        BatterySupported = 0x0085001b,

        // <summary>
        //     Selector Revision Usage.
        // </summary>
        [Description("Selector Revision")]
        SelectorRevision = 0x0085001c,

        // <summary>
        //     Charging Indicator Usage.
        // </summary>
        [Description("Charging Indicator")]
        ChargingIndicator = 0x0085001d,

        // <summary>
        //     Manufacturer Access Usage.
        // </summary>
        [Description("Manufacturer Access")]
        ManufacturerAccess = 0x00850028,

        // <summary>
        //     Remaining Capacity Limit Usage.
        // </summary>
        [Description("Remaining Capacity Limit")]
        RemainingCapacityLimit = 0x00850029,

        // <summary>
        //     Remaining Time Limit Usage.
        // </summary>
        [Description("Remaining Time Limit")]
        RemainingTimeLimit = 0x0085002a,

        // <summary>
        //     At Rate Usage.
        // </summary>
        [Description("At Rate")]
        AtRate = 0x0085002b,

        // <summary>
        //     Capacity Mode Usage.
        // </summary>
        [Description("Capacity Mode")]
        CapacityMode = 0x0085002c,

        // <summary>
        //     Broadcast To Charger Usage.
        // </summary>
        [Description("Broadcast To Charger")]
        BroadcastToCharger = 0x0085002d,

        // <summary>
        //     Primary Battery Usage.
        // </summary>
        [Description("Primary Battery")]
        PrimaryBattery = 0x0085002e,

        // <summary>
        //     Charge Controller Usage.
        // </summary>
        [Description("Charge Controller")]
        ChargeController = 0x0085002f,

        // <summary>
        //     Terminate Charge Usage.
        // </summary>
        [Description("Terminate Charge")]
        TerminateCharge = 0x00850040,

        // <summary>
        //     Terminate Discharge Usage.
        // </summary>
        [Description("Terminate Discharge")]
        TerminateDischarge = 0x00850041,

        // <summary>
        //     Below Remaining Capacity Limit Usage.
        // </summary>
        [Description("Below Remaining Capacity Limit")]
        BelowRemainingCapacityLimit = 0x00850042,

        // <summary>
        //     Remaining Time Limit Expired Usage.
        // </summary>
        [Description("Remaining Time Limit Expired")]
        RemainingTimeLimitExpired = 0x00850043,

        // <summary>
        //     Charging Usage.
        // </summary>
        [Description("Charging")]
        Charging = 0x00850044,

        // <summary>
        //     Discharging Usage.
        // </summary>
        [Description("Discharging")]
        Discharging = 0x00850045,

        // <summary>
        //     Fully Charged Usage.
        // </summary>
        [Description("Fully Charged")]
        FullyCharged = 0x00850046,

        // <summary>
        //     Fully Discharged Usage.
        // </summary>
        [Description("Fully Discharged")]
        FullyDischarged = 0x00850047,

        // <summary>
        //     Conditioning Flag Usage.
        // </summary>
        [Description("Conditioning Flag")]
        ConditioningFlag = 0x00850048,

        // <summary>
        //     At Rate OK Usage.
        // </summary>
        [Description("At Rate OK")]
        AtRateOK = 0x00850049,

        // <summary>
        //     Smart Battery Error Code Usage.
        // </summary>
        [Description("Smart Battery Error Code")]
        SmartBatteryErrorCode = 0x0085004a,

        // <summary>
        //     Need Replacement Usage.
        // </summary>
        [Description("Need Replacement")]
        NeedReplacement = 0x0085004b,

        // <summary>
        //     At Rate Time To Full Usage.
        // </summary>
        [Description("At Rate Time To Full")]
        AtRateTimeToFull = 0x00850060,

        // <summary>
        //     At Rate Time To Empty Usage.
        // </summary>
        [Description("At Rate Time To Empty")]
        AtRateTimeToEmpty = 0x00850061,

        // <summary>
        //     Average Current Usage.
        // </summary>
        [Description("Average Current")]
        AverageCurrent = 0x00850062,

        // <summary>
        //     Max Error Usage.
        // </summary>
        [Description("Max Error")]
        MaxError = 0x00850063,

        // <summary>
        //     Relative State Of Charge Usage.
        // </summary>
        [Description("Relative State Of Charge")]
        RelativeStateOfCharge = 0x00850064,

        // <summary>
        //     Absolute State Of Charge Usage.
        // </summary>
        [Description("Absolute State Of Charge")]
        AbsoluteStateOfCharge = 0x00850065,

        // <summary>
        //     Remaining Capacity Usage.
        // </summary>
        [Description("Remaining Capacity")]
        RemainingCapacity = 0x00850066,

        // <summary>
        //     Full Charge Capacity Usage.
        // </summary>
        [Description("Full Charge Capacity")]
        FullChargeCapacity = 0x00850067,

        // <summary>
        //     Run Time To Empty Usage.
        // </summary>
        [Description("Run Time To Empty")]
        RunTimeToEmpty = 0x00850068,

        // <summary>
        //     Average Time To Empty Usage.
        // </summary>
        [Description("Average Time To Empty")]
        AverageTimeToEmpty = 0x00850069,

        // <summary>
        //     Average Time To Full Usage.
        // </summary>
        [Description("Average Time To Full")]
        AverageTimeToFull = 0x0085006a,

        // <summary>
        //     Cycle Count Usage.
        // </summary>
        [Description("Cycle Count")]
        CycleCount = 0x0085006b,

        // <summary>
        //     Battery Pack Model Level Usage.
        // </summary>
        [Description("Battery Pack Model Level")]
        BatteryPackModelLevel = 0x00850080,

        // <summary>
        //     Internal Charge Controller Usage.
        // </summary>
        [Description("Internal Charge Controller")]
        InternalChargeController = 0x00850081,

        // <summary>
        //     Primary Battery Support Usage.
        // </summary>
        [Description("Primary Battery Support")]
        PrimaryBatterySupport = 0x00850082,

        // <summary>
        //     Design Capacity Usage.
        // </summary>
        [Description("Design Capacity")]
        DesignCapacity = 0x00850083,

        // <summary>
        //     Specification Info Usage.
        // </summary>
        [Description("Specification Info")]
        SpecificationInfo = 0x00850084,

        // <summary>
        //     Manufacture Date Usage.
        // </summary>
        [Description("Manufacture Date")]
        ManufactureDate = 0x00850085,

        // <summary>
        //     Serial Number Usage.
        // </summary>
        [Description("Serial Number")]
        SerialNumber = 0x00850086,

        // <summary>
        //     iManufacturer Name Usage.
        // </summary>
        [Description("iManufacturer Name")]
        IManufacturerName = 0x00850087,

        // <summary>
        //     iDevice Name Usage.
        // </summary>
        [Description("iDevice Name")]
        IDeviceName = 0x00850088,

        // <summary>
        //     iDevice Chemistry Usage.
        // </summary>
        [Description("iDevice Chemistry")]
        IDeviceChemistry = 0x00850089,

        // <summary>
        //     Manufacturer Data Usage.
        // </summary>
        [Description("Manufacturer Data")]
        ManufacturerData = 0x0085008a,

        // <summary>
        //     Rechargable Usage.
        // </summary>
        [Description("Rechargable")]
        Rechargable = 0x0085008b,

        // <summary>
        //     Warning Capacity Limit Usage.
        // </summary>
        [Description("Warning Capacity Limit")]
        WarningCapacityLimit = 0x0085008c,

        // <summary>
        //     Capacity Granularity 1 Usage.
        // </summary>
        [Description("Capacity Granularity 1")]
        CapacityGranularity1 = 0x0085008d,

        // <summary>
        //     Capacity Granularity 2 Usage.
        // </summary>
        [Description("Capacity Granularity 2")]
        CapacityGranularity2 = 0x0085008e,

        // <summary>
        //     iOEM Information Usage.
        // </summary>
        [Description("iOEM Information")]
        IOEMInformation = 0x0085008f,

        // <summary>
        //     Inhibit Charge Usage.
        // </summary>
        [Description("Inhibit Charge")]
        InhibitCharge = 0x008500c0,

        // <summary>
        //     Enable Polling Usage.
        // </summary>
        [Description("Enable Polling")]
        EnablePolling = 0x008500c1,

        // <summary>
        //     Reset To Zero Usage.
        // </summary>
        [Description("Reset To Zero")]
        ResetToZero = 0x008500c2,

        // <summary>
        //     AC Present Usage.
        // </summary>
        [Description("AC Present")]
        ACPresent = 0x008500d0,

        // <summary>
        //     Battery Present Usage.
        // </summary>
        [Description("Battery Present")]
        BatteryPresent = 0x008500d1,

        // <summary>
        //     Power Fail Usage.
        // </summary>
        [Description("Power Fail")]
        PowerFail = 0x008500d2,

        // <summary>
        //     Alarm Inhibited Usage.
        // </summary>
        [Description("Alarm Inhibited")]
        AlarmInhibited = 0x008500d3,

        // <summary>
        //     Thermistor Under Range Usage.
        // </summary>
        [Description("Thermistor Under Range")]
        ThermistorUnderRange = 0x008500d4,

        // <summary>
        //     Thermistor Hot Usage.
        // </summary>
        [Description("Thermistor Hot")]
        ThermistorHot = 0x008500d5,

        // <summary>
        //     Thermistor Cold Usage.
        // </summary>
        [Description("Thermistor Cold")]
        ThermistorCold = 0x008500d6,

        // <summary>
        //     Thermistor Over Range Usage.
        // </summary>
        [Description("Thermistor Over Range")]
        ThermistorOverRange = 0x008500d7,

        // <summary>
        //     Voltage Out Of Range Usage.
        // </summary>
        [Description("Voltage Out Of Range")]
        VoltageOutOfRange = 0x008500d8,

        // <summary>
        //     Current Out Of Range Usage.
        // </summary>
        [Description("Current Out Of Range")]
        CurrentOutOfRange = 0x008500d9,

        // <summary>
        //     Current Not Regulated Usage.
        // </summary>
        [Description("Current Not Regulated")]
        CurrentNotRegulated = 0x008500da,

        // <summary>
        //     Voltage Not Regulated Usage.
        // </summary>
        [Description("Voltage Not Regulated")]
        VoltageNotRegulated = 0x008500db,

        // <summary>
        //     Master Mode Usage.
        // </summary>
        [Description("Master Mode")]
        MasterMode = 0x008500dc,

        // <summary>
        //     Charger Selector Support Usage.
        // </summary>
        [Description("Charger Selector Support")]
        ChargerSelectorSupport = 0x008500f0,

        // <summary>
        //     Charger Spec Usage.
        // </summary>
        [Description("Charger Spec")]
        ChargerSpec = 0x008500f1,

        // <summary>
        //     Level 2 Usage.
        // </summary>
        [Description("Level 2")]
        Level2 = 0x008500f2,

        // <summary>
        //     Level 3 Usage.
        // </summary>
        [Description("Level 3")]
        Level3 = 0x008500f3
    }
}
