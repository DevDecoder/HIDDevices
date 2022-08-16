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
    //     Physical Input Device Usage Page.
    // </summary>
    [Description("Physical Input Device Usage Page")]
    public enum PhysicalInputDevicePage : uint
    {
        // <summary>
        //     Undefined Usage.
        // </summary>
        [Description("Undefined")]
        Undefined = 0x000f0000,

        // <summary>
        //     Physical Input Device Usage.
        // </summary>
        [Description("Physical Input Device")]
        PhysicalInputDevice = 0x000f0001,

        // <summary>
        //     Normal Usage.
        // </summary>
        [Description("Normal")]
        Normal = 0x000f0020,

        // <summary>
        //     Set Effect Report Usage.
        // </summary>
        [Description("Set Effect Report")]
        SetEffectReport = 0x000f0021,

        // <summary>
        //     Effect Parameter Block Index Usage.
        // </summary>
        [Description("Effect Parameter Block Index")]
        EffectParameterBlockIndex = 0x000f0022,

        // <summary>
        //     Parameter Block Offset Usage.
        // </summary>
        [Description("Parameter Block Offset")]
        ParameterBlockOffset = 0x000f0023,

        // <summary>
        //     ROM Flag Usage.
        // </summary>
        [Description("ROM Flag")]
        ROMFlag = 0x000f0024,

        // <summary>
        //     Effect Type Usage.
        // </summary>
        [Description("Effect Type")]
        EffectType = 0x000f0025,

        // <summary>
        //     ET Constant-Force Usage.
        // </summary>
        [Description("ET Constant-Force")]
        ETConstantForce = 0x000f0026,

        // <summary>
        //     ET Ramp Usage.
        // </summary>
        [Description("ET Ramp")]
        ETRamp = 0x000f0027,

        // <summary>
        //     ET Custom-Force Usage.
        // </summary>
        [Description("ET Custom-Force")]
        ETCustomForce = 0x000f0028,

        // <summary>
        //     ET Square Usage.
        // </summary>
        [Description("ET Square")]
        ETSquare = 0x000f0030,

        // <summary>
        //     ET Sine Usage.
        // </summary>
        [Description("ET Sine")]
        ETSine = 0x000f0031,

        // <summary>
        //     ET Triangle Usage.
        // </summary>
        [Description("ET Triangle")]
        ETTriangle = 0x000f0032,

        // <summary>
        //     ET Sawtooth Up Usage.
        // </summary>
        [Description("ET Sawtooth Up")]
        ETSawtoothUp = 0x000f0033,

        // <summary>
        //     ET Sawtooth Down Usage.
        // </summary>
        [Description("ET Sawtooth Down")]
        ETSawtoothDown = 0x000f0034,

        // <summary>
        //     ET Spring Usage.
        // </summary>
        [Description("ET Spring")]
        ETSpring = 0x000f0040,

        // <summary>
        //     ET Damper Usage.
        // </summary>
        [Description("ET Damper")]
        ETDamper = 0x000f0041,

        // <summary>
        //     ET Inertia Usage.
        // </summary>
        [Description("ET Inertia")]
        ETInertia = 0x000f0042,

        // <summary>
        //     ET Friction Usage.
        // </summary>
        [Description("ET Friction")]
        ETFriction = 0x000f0043,

        // <summary>
        //     Duration Usage.
        // </summary>
        [Description("Duration")]
        Duration = 0x000f0050,

        // <summary>
        //     Sample Period Usage.
        // </summary>
        [Description("Sample Period")]
        SamplePeriod = 0x000f0051,

        // <summary>
        //     Gain Usage.
        // </summary>
        [Description("Gain")]
        Gain = 0x000f0052,

        // <summary>
        //     Trigger Button Usage.
        // </summary>
        [Description("Trigger Button")]
        TriggerButton = 0x000f0053,

        // <summary>
        //     Trigger Repeat Interval Usage.
        // </summary>
        [Description("Trigger Repeat Interval")]
        TriggerRepeatInterval = 0x000f0054,

        // <summary>
        //     Axes Enable Usage.
        // </summary>
        [Description("Axes Enable")]
        AxesEnable = 0x000f0055,

        // <summary>
        //     Direction Enable Usage.
        // </summary>
        [Description("Direction Enable")]
        DirectionEnable = 0x000f0056,

        // <summary>
        //     Direction Usage.
        // </summary>
        [Description("Direction")]
        Direction = 0x000f0057,

        // <summary>
        //     Type Specific Block Offset Usage.
        // </summary>
        [Description("Type Specific Block Offset")]
        TypeSpecificBlockOffset = 0x000f0058,

        // <summary>
        //     Block Type Usage.
        // </summary>
        [Description("Block Type")]
        BlockType = 0x000f0059,

        // <summary>
        //     Set Envelope Report Usage.
        // </summary>
        [Description("Set Envelope Report")]
        SetEnvelopeReport = 0x000f005a,

        // <summary>
        //     Attack Level Usage.
        // </summary>
        [Description("Attack Level")]
        AttackLevel = 0x000f005b,

        // <summary>
        //     Attack Time Usage.
        // </summary>
        [Description("Attack Time")]
        AttackTime = 0x000f005c,

        // <summary>
        //     Fade Level Usage.
        // </summary>
        [Description("Fade Level")]
        FadeLevel = 0x000f005d,

        // <summary>
        //     Fade Time Usage.
        // </summary>
        [Description("Fade Time")]
        FadeTime = 0x000f005e,

        // <summary>
        //     Set Condition Report Usage.
        // </summary>
        [Description("Set Condition Report")]
        SetConditionReport = 0x000f005f,

        // <summary>
        //     Center-Point Offset Usage.
        // </summary>
        [Description("Center-Point Offset")]
        CenterPointOffset = 0x000f0060,

        // <summary>
        //     Positive Coefficient Usage.
        // </summary>
        [Description("Positive Coefficient")]
        PositiveCoefficient = 0x000f0061,

        // <summary>
        //     Negative Coefficient Usage.
        // </summary>
        [Description("Negative Coefficient")]
        NegativeCoefficient = 0x000f0062,

        // <summary>
        //     Positive Saturation Usage.
        // </summary>
        [Description("Positive Saturation")]
        PositiveSaturation = 0x000f0063,

        // <summary>
        //     Negative Saturation Usage.
        // </summary>
        [Description("Negative Saturation")]
        NegativeSaturation = 0x000f0064,

        // <summary>
        //     Dead Band Usage.
        // </summary>
        [Description("Dead Band")]
        DeadBand = 0x000f0065,

        // <summary>
        //     Download Force Sample Usage.
        // </summary>
        [Description("Download Force Sample")]
        DownloadForceSample = 0x000f0066,

        // <summary>
        //     Isoch Custom-Force Enable Usage.
        // </summary>
        [Description("Isoch Custom-Force Enable")]
        IsochCustomForceEnable = 0x000f0067,

        // <summary>
        //     Custom-Force Data Report Usage.
        // </summary>
        [Description("Custom-Force Data Report")]
        CustomForceDataReport = 0x000f0068,

        // <summary>
        //     Custom-Force Data Usage.
        // </summary>
        [Description("Custom-Force Data")]
        CustomForceData = 0x000f0069,

        // <summary>
        //     Custom-Force Vendor Defined Data Usage.
        // </summary>
        [Description("Custom-Force Vendor Defined Data")]
        CustomForceVendorDefinedData = 0x000f006a,

        // <summary>
        //     Set Custom-Force Report Usage.
        // </summary>
        [Description("Set Custom-Force Report")]
        SetCustomForceReport = 0x000f006b,

        // <summary>
        //     Custom-Force Data Offset Usage.
        // </summary>
        [Description("Custom-Force Data Offset")]
        CustomForceDataOffset = 0x000f006c,

        // <summary>
        //     Sample Count Usage.
        // </summary>
        [Description("Sample Count")]
        SampleCount = 0x000f006d,

        // <summary>
        //     Set Periodic Report Usage.
        // </summary>
        [Description("Set Periodic Report")]
        SetPeriodicReport = 0x000f006e,

        // <summary>
        //     Offset Usage.
        // </summary>
        [Description("Offset")]
        Offset = 0x000f006f,

        // <summary>
        //     Magnitude Usage.
        // </summary>
        [Description("Magnitude")]
        Magnitude = 0x000f0070,

        // <summary>
        //     Phase Usage.
        // </summary>
        [Description("Phase")]
        Phase = 0x000f0071,

        // <summary>
        //     Period Usage.
        // </summary>
        [Description("Period")]
        Period = 0x000f0072,

        // <summary>
        //     Set Constant-Force Report Usage.
        // </summary>
        [Description("Set Constant-Force Report")]
        SetConstantForceReport = 0x000f0073,

        // <summary>
        //     Set Ramp-Force Report Usage.
        // </summary>
        [Description("Set Ramp-Force Report")]
        SetRampForceReport = 0x000f0074,

        // <summary>
        //     Ramp Start Usage.
        // </summary>
        [Description("Ramp Start")]
        RampStart = 0x000f0075,

        // <summary>
        //     Ramp End Usage.
        // </summary>
        [Description("Ramp End")]
        RampEnd = 0x000f0076,

        // <summary>
        //     Effect Operation Report Usage.
        // </summary>
        [Description("Effect Operation Report")]
        EffectOperationReport = 0x000f0077,

        // <summary>
        //     Effect Operation Usage.
        // </summary>
        [Description("Effect Operation")]
        EffectOperation = 0x000f0078,

        // <summary>
        //     Op Effect Start Usage.
        // </summary>
        [Description("Op Effect Start")]
        OpEffectStart = 0x000f0079,

        // <summary>
        //     Op Effect Start Solo Usage.
        // </summary>
        [Description("Op Effect Start Solo")]
        OpEffectStartSolo = 0x000f007a,

        // <summary>
        //     Op Effect Stop Usage.
        // </summary>
        [Description("Op Effect Stop")]
        OpEffectStop = 0x000f007b,

        // <summary>
        //     Loop Count Usage.
        // </summary>
        [Description("Loop Count")]
        LoopCount = 0x000f007c,

        // <summary>
        //     Device Gain Report Usage.
        // </summary>
        [Description("Device Gain Report")]
        DeviceGainReport = 0x000f007d,

        // <summary>
        //     Device Gain Usage.
        // </summary>
        [Description("Device Gain")]
        DeviceGain = 0x000f007e,

        // <summary>
        //     Parameter Block Pools Report Usage.
        // </summary>
        [Description("Parameter Block Pools Report")]
        ParameterBlockPoolsReport = 0x000f007f,

        // <summary>
        //     RAM Pool Size Usage.
        // </summary>
        [Description("RAM Pool Size")]
        RAMPoolSize = 0x000f0080,

        // <summary>
        //     ROM Pool Size Usage.
        // </summary>
        [Description("ROM Pool Size")]
        ROMPoolSize = 0x000f0081,

        // <summary>
        //     ROM Effect Block Count Usage.
        // </summary>
        [Description("ROM Effect Block Count")]
        ROMEffectBlockCount = 0x000f0082,

        // <summary>
        //     Simultaneous Effects Max Usage.
        // </summary>
        [Description("Simultaneous Effects Max")]
        SimultaneousEffectsMax = 0x000f0083,

        // <summary>
        //     Pool Alignment Usage.
        // </summary>
        [Description("Pool Alignment")]
        PoolAlignment = 0x000f0084,

        // <summary>
        //     Parameter Block Move Report Usage.
        // </summary>
        [Description("Parameter Block Move Report")]
        ParameterBlockMoveReport = 0x000f0085,

        // <summary>
        //     Move Source Usage.
        // </summary>
        [Description("Move Source")]
        MoveSource = 0x000f0086,

        // <summary>
        //     Move Destination Usage.
        // </summary>
        [Description("Move Destination")]
        MoveDestination = 0x000f0087,

        // <summary>
        //     Move Length Usage.
        // </summary>
        [Description("Move Length")]
        MoveLength = 0x000f0088,

        // <summary>
        //     Effect Parameter Block Load Report Usage.
        // </summary>
        [Description("Effect Parameter Block Load Report")]
        EffectParameterBlockLoadReport = 0x000f0089,

        // <summary>
        //     Effect Parameter Block Load Status Usage.
        // </summary>
        [Description("Effect Parameter Block Load Status")]
        EffectParameterBlockLoadStatus = 0x000f008b,

        // <summary>
        //     Block Load Success Usage.
        // </summary>
        [Description("Block Load Success")]
        BlockLoadSuccess = 0x000f008c,

        // <summary>
        //     Block Load Full Usage.
        // </summary>
        [Description("Block Load Full")]
        BlockLoadFull = 0x000f008d,

        // <summary>
        //     Block Load Error Usage.
        // </summary>
        [Description("Block Load Error")]
        BlockLoadError = 0x000f008e,

        // <summary>
        //     Block Handle Usage.
        // </summary>
        [Description("Block Handle")]
        BlockHandle = 0x000f008f,

        // <summary>
        //     Effect Parameter Block Free Report Usage.
        // </summary>
        [Description("Effect Parameter Block Free Report")]
        EffectParameterBlockFreeReport = 0x000f0090,

        // <summary>
        //     Type Specific Block Handle Usage.
        // </summary>
        [Description("Type Specific Block Handle")]
        TypeSpecificBlockHandle = 0x000f0091,

        // <summary>
        //     PID State Report Usage.
        // </summary>
        [Description("PID State Report")]
        PIDStateReport = 0x000f0092,

        // <summary>
        //     Effect Playing Usage.
        // </summary>
        [Description("Effect Playing")]
        EffectPlaying = 0x000f0094,

        // <summary>
        //     PID Device Control Report Usage.
        // </summary>
        [Description("PID Device Control Report")]
        PIDDeviceControlReport = 0x000f0095,

        // <summary>
        //     PID Device Control Usage.
        // </summary>
        [Description("PID Device Control")]
        PIDDeviceControl = 0x000f0096,

        // <summary>
        //     DC Enable Actuators Usage.
        // </summary>
        [Description("DC Enable Actuators")]
        DCEnableActuators = 0x000f0097,

        // <summary>
        //     DC Disable Actuators Usage.
        // </summary>
        [Description("DC Disable Actuators")]
        DCDisableActuators = 0x000f0098,

        // <summary>
        //     DC Stop All Effects Usage.
        // </summary>
        [Description("DC Stop All Effects")]
        DCStopAllEffects = 0x000f0099,

        // <summary>
        //     DC Reset Usage.
        // </summary>
        [Description("DC Reset")]
        DCReset = 0x000f009a,

        // <summary>
        //     DC Pause Usage.
        // </summary>
        [Description("DC Pause")]
        DCPause = 0x000f009b,

        // <summary>
        //     DC Continue Usage.
        // </summary>
        [Description("DC Continue")]
        DCContinue = 0x000f009c,

        // <summary>
        //     Device Paused Usage.
        // </summary>
        [Description("Device Paused")]
        DevicePaused = 0x000f009f,

        // <summary>
        //     Actuators Enabled Usage.
        // </summary>
        [Description("Actuators Enabled")]
        ActuatorsEnabled = 0x000f00a0,

        // <summary>
        //     Safety Switch Usage.
        // </summary>
        [Description("Safety Switch")]
        SafetySwitch = 0x000f00a4,

        // <summary>
        //     Actuator Override Switch Usage.
        // </summary>
        [Description("Actuator Override Switch")]
        ActuatorOverrideSwitch = 0x000f00a5,

        // <summary>
        //     Actuator Power Usage.
        // </summary>
        [Description("Actuator Power")]
        ActuatorPower = 0x000f00a6,

        // <summary>
        //     Start Delay Usage.
        // </summary>
        [Description("Start Delay")]
        StartDelay = 0x000f00a7,

        // <summary>
        //     Parameter Block Size Usage.
        // </summary>
        [Description("Parameter Block Size")]
        ParameterBlockSize = 0x000f00a8,

        // <summary>
        //     Device-Managed Pool Usage.
        // </summary>
        [Description("Device-Managed Pool")]
        DeviceManagedPool = 0x000f00a9,

        // <summary>
        //     Shared Parameter Blocks Usage.
        // </summary>
        [Description("Shared Parameter Blocks")]
        SharedParameterBlocks = 0x000f00aa,

        // <summary>
        //     Create New Effect Parameter Block Report Usage.
        // </summary>
        [Description("Create New Effect Parameter Block Report")]
        CreateNewEffectParameterBlockReport = 0x000f00ab,

        // <summary>
        //     RAM Pool Available Usage.
        // </summary>
        [Description("RAM Pool Available")]
        RAMPoolAvailable = 0x000f00ac
    }
}
