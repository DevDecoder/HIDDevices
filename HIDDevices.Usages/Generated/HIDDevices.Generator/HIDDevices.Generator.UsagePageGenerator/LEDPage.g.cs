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
    //     LED Usage Page.
    // </summary>
    [Description("LED Usage Page")]
    public enum LEDPage : uint
    {
        // <summary>
        //     Undefined Usage.
        // </summary>
        [Description("Undefined")]
        Undefined = 0x00080000,

        // <summary>
        //     Num Lock Usage.
        // </summary>
        [Description("Num Lock")]
        NumLock = 0x00080001,

        // <summary>
        //     Caps Lock Usage.
        // </summary>
        [Description("Caps Lock")]
        CapsLock = 0x00080002,

        // <summary>
        //     Scroll Lock Usage.
        // </summary>
        [Description("Scroll Lock")]
        ScrollLock = 0x00080003,

        // <summary>
        //     Compose Usage.
        // </summary>
        [Description("Compose")]
        Compose = 0x00080004,

        // <summary>
        //     Kana Usage.
        // </summary>
        [Description("Kana")]
        Kana = 0x00080005,

        // <summary>
        //     Power Usage.
        // </summary>
        [Description("Power")]
        Power = 0x00080006,

        // <summary>
        //     Shift Usage.
        // </summary>
        [Description("Shift")]
        Shift = 0x00080007,

        // <summary>
        //     Do Not Disturb Usage.
        // </summary>
        [Description("Do Not Disturb")]
        DoNotDisturb = 0x00080008,

        // <summary>
        //     Mute Usage.
        // </summary>
        [Description("Mute")]
        Mute = 0x00080009,

        // <summary>
        //     Tone Enable Usage.
        // </summary>
        [Description("Tone Enable")]
        ToneEnable = 0x0008000a,

        // <summary>
        //     High Cut Filter Usage.
        // </summary>
        [Description("High Cut Filter")]
        HighCutFilter = 0x0008000b,

        // <summary>
        //     Low Cut Filter Usage.
        // </summary>
        [Description("Low Cut Filter")]
        LowCutFilter = 0x0008000c,

        // <summary>
        //     Equalizer Enable Usage.
        // </summary>
        [Description("Equalizer Enable")]
        EqualizerEnable = 0x0008000d,

        // <summary>
        //     Sound Field On Usage.
        // </summary>
        [Description("Sound Field On")]
        SoundFieldOn = 0x0008000e,

        // <summary>
        //     Surround On Usage.
        // </summary>
        [Description("Surround On")]
        SurroundOn = 0x0008000f,

        // <summary>
        //     Repeat Usage.
        // </summary>
        [Description("Repeat")]
        Repeat = 0x00080010,

        // <summary>
        //     Stereo Usage.
        // </summary>
        [Description("Stereo")]
        Stereo = 0x00080011,

        // <summary>
        //     Sampling Rate Detect Usage.
        // </summary>
        [Description("Sampling Rate Detect")]
        SamplingRateDetect = 0x00080012,

        // <summary>
        //     Spinning Usage.
        // </summary>
        [Description("Spinning")]
        Spinning = 0x00080013,

        // <summary>
        //     CAV Usage.
        // </summary>
        [Description("CAV")]
        CAV = 0x00080014,

        // <summary>
        //     CLV Usage.
        // </summary>
        [Description("CLV")]
        CLV = 0x00080015,

        // <summary>
        //     Recording Format Detect Usage.
        // </summary>
        [Description("Recording Format Detect")]
        RecordingFormatDetect = 0x00080016,

        // <summary>
        //     Off-Hook Usage.
        // </summary>
        [Description("Off-Hook")]
        OffHook = 0x00080017,

        // <summary>
        //     Ring Usage.
        // </summary>
        [Description("Ring")]
        Ring = 0x00080018,

        // <summary>
        //     Message Waiting Usage.
        // </summary>
        [Description("Message Waiting")]
        MessageWaiting = 0x00080019,

        // <summary>
        //     Data Mode Usage.
        // </summary>
        [Description("Data Mode")]
        DataMode = 0x0008001a,

        // <summary>
        //     Battery Operation Usage.
        // </summary>
        [Description("Battery Operation")]
        BatteryOperation = 0x0008001b,

        // <summary>
        //     Battery OK Usage.
        // </summary>
        [Description("Battery OK")]
        BatteryOK = 0x0008001c,

        // <summary>
        //     Battery Low Usage.
        // </summary>
        [Description("Battery Low")]
        BatteryLow = 0x0008001d,

        // <summary>
        //     Speaker Usage.
        // </summary>
        [Description("Speaker")]
        Speaker = 0x0008001e,

        // <summary>
        //     Headset Usage.
        // </summary>
        [Description("Headset")]
        Headset = 0x0008001f,

        // <summary>
        //     Hold Usage.
        // </summary>
        [Description("Hold")]
        Hold = 0x00080020,

        // <summary>
        //     Microphone Usage.
        // </summary>
        [Description("Microphone")]
        Microphone = 0x00080021,

        // <summary>
        //     Coverage Usage.
        // </summary>
        [Description("Coverage")]
        Coverage = 0x00080022,

        // <summary>
        //     Night Mode Usage.
        // </summary>
        [Description("Night Mode")]
        NightMode = 0x00080023,

        // <summary>
        //     Send Calls Usage.
        // </summary>
        [Description("Send Calls")]
        SendCalls = 0x00080024,

        // <summary>
        //     Call Pickup Usage.
        // </summary>
        [Description("Call Pickup")]
        CallPickup = 0x00080025,

        // <summary>
        //     Conference Usage.
        // </summary>
        [Description("Conference")]
        Conference = 0x00080026,

        // <summary>
        //     Stand-by Usage.
        // </summary>
        [Description("Stand-by")]
        Standby = 0x00080027,

        // <summary>
        //     Camera On Usage.
        // </summary>
        [Description("Camera On")]
        CameraOn = 0x00080028,

        // <summary>
        //     Camera Off Usage.
        // </summary>
        [Description("Camera Off")]
        CameraOff = 0x00080029,

        // <summary>
        //     On-Line Usage.
        // </summary>
        [Description("On-Line")]
        OnLine = 0x0008002a,

        // <summary>
        //     Off-Line Usage.
        // </summary>
        [Description("Off-Line")]
        OffLine = 0x0008002b,

        // <summary>
        //     Busy Usage.
        // </summary>
        [Description("Busy")]
        Busy = 0x0008002c,

        // <summary>
        //     Ready Usage.
        // </summary>
        [Description("Ready")]
        Ready = 0x0008002d,

        // <summary>
        //     Paper-Out Usage.
        // </summary>
        [Description("Paper-Out")]
        PaperOut = 0x0008002e,

        // <summary>
        //     Paper-Jam Usage.
        // </summary>
        [Description("Paper-Jam")]
        PaperJam = 0x0008002f,

        // <summary>
        //     Remote Usage.
        // </summary>
        [Description("Remote")]
        Remote = 0x00080030,

        // <summary>
        //     Forward Usage.
        // </summary>
        [Description("Forward")]
        Forward = 0x00080031,

        // <summary>
        //     Reverse Usage.
        // </summary>
        [Description("Reverse")]
        Reverse = 0x00080032,

        // <summary>
        //     Stop Usage.
        // </summary>
        [Description("Stop")]
        Stop = 0x00080033,

        // <summary>
        //     Rewind Usage.
        // </summary>
        [Description("Rewind")]
        Rewind = 0x00080034,

        // <summary>
        //     Fast Forward Usage.
        // </summary>
        [Description("Fast Forward")]
        FastForward = 0x00080035,

        // <summary>
        //     Play Usage.
        // </summary>
        [Description("Play")]
        Play = 0x00080036,

        // <summary>
        //     Pause Usage.
        // </summary>
        [Description("Pause")]
        Pause = 0x00080037,

        // <summary>
        //     Record Usage.
        // </summary>
        [Description("Record")]
        Record = 0x00080038,

        // <summary>
        //     Error Usage.
        // </summary>
        [Description("Error")]
        Error = 0x00080039,

        // <summary>
        //     Usage Selected Indicator Usage.
        // </summary>
        [Description("Usage Selected Indicator")]
        UsageSelectedIndicator = 0x0008003a,

        // <summary>
        //     Usage In Use Indicator Usage.
        // </summary>
        [Description("Usage In Use Indicator")]
        UsageInUseIndicator = 0x0008003b,

        // <summary>
        //     Usage Multi Mode Indicator Usage.
        // </summary>
        [Description("Usage Multi Mode Indicator")]
        UsageMultiModeIndicator = 0x0008003c,

        // <summary>
        //     Indicator On Usage.
        // </summary>
        [Description("Indicator On")]
        IndicatorOn = 0x0008003d,

        // <summary>
        //     Indicator Flash Usage.
        // </summary>
        [Description("Indicator Flash")]
        IndicatorFlash = 0x0008003e,

        // <summary>
        //     Indicator Slow Blink Usage.
        // </summary>
        [Description("Indicator Slow Blink")]
        IndicatorSlowBlink = 0x0008003f,

        // <summary>
        //     Indicator Fast Blink Usage.
        // </summary>
        [Description("Indicator Fast Blink")]
        IndicatorFastBlink = 0x00080040,

        // <summary>
        //     Indicator Off Usage.
        // </summary>
        [Description("Indicator Off")]
        IndicatorOff = 0x00080041,

        // <summary>
        //     Flash On Time Usage.
        // </summary>
        [Description("Flash On Time")]
        FlashOnTime = 0x00080042,

        // <summary>
        //     Slow Blink On Time Usage.
        // </summary>
        [Description("Slow Blink On Time")]
        SlowBlinkOnTime = 0x00080043,

        // <summary>
        //     Slow Blink Off Time Usage.
        // </summary>
        [Description("Slow Blink Off Time")]
        SlowBlinkOffTime = 0x00080044,

        // <summary>
        //     Fast Blink On Time Usage.
        // </summary>
        [Description("Fast Blink On Time")]
        FastBlinkOnTime = 0x00080045,

        // <summary>
        //     Fast Blink Off Time Usage.
        // </summary>
        [Description("Fast Blink Off Time")]
        FastBlinkOffTime = 0x00080046,

        // <summary>
        //     Usage Indicator Color Usage.
        // </summary>
        [Description("Usage Indicator Color")]
        UsageIndicatorColor = 0x00080047,

        // <summary>
        //     Indicator Red Usage.
        // </summary>
        [Description("Indicator Red")]
        IndicatorRed = 0x00080048,

        // <summary>
        //     Indicator Green Usage.
        // </summary>
        [Description("Indicator Green")]
        IndicatorGreen = 0x00080049,

        // <summary>
        //     Indicator Amber Usage.
        // </summary>
        [Description("Indicator Amber")]
        IndicatorAmber = 0x0008004a,

        // <summary>
        //     Generic Indicator Usage.
        // </summary>
        [Description("Generic Indicator")]
        GenericIndicator = 0x0008004b,

        // <summary>
        //     System Suspend Usage.
        // </summary>
        [Description("System Suspend")]
        SystemSuspend = 0x0008004c,

        // <summary>
        //     External Power Connected Usage.
        // </summary>
        [Description("External Power Connected")]
        ExternalPowerConnected = 0x0008004d,

        // <summary>
        //     Indicator Blue Usage.
        // </summary>
        [Description("Indicator Blue")]
        IndicatorBlue = 0x0008004e,

        // <summary>
        //     Indicator Orange Usage.
        // </summary>
        [Description("Indicator Orange")]
        IndicatorOrange = 0x0008004f,

        // <summary>
        //     Good Status Usage.
        // </summary>
        [Description("Good Status")]
        GoodStatus = 0x00080050,

        // <summary>
        //     Warning Status Usage.
        // </summary>
        [Description("Warning Status")]
        WarningStatus = 0x00080051,

        // <summary>
        //     RGB LED Usage.
        // </summary>
        [Description("RGB LED")]
        RGBLED = 0x00080052,

        // <summary>
        //     Red LED Channel Usage.
        // </summary>
        [Description("Red LED Channel")]
        RedLEDChannel = 0x00080053,

        // <summary>
        //     Blue LED Channel Usage.
        // </summary>
        [Description("Blue LED Channel")]
        BlueLEDChannel = 0x00080054,

        // <summary>
        //     Green LED Channel Usage.
        // </summary>
        [Description("Green LED Channel")]
        GreenLEDChannel = 0x00080055,

        // <summary>
        //     LED Intensity Usage.
        // </summary>
        [Description("LED Intensity")]
        LEDIntensity = 0x00080056,

        // <summary>
        //     System Microphone Mute Usage.
        // </summary>
        [Description("System Microphone Mute")]
        SystemMicrophoneMute = 0x00080057,

        // <summary>
        //     Player Indicator Usage.
        // </summary>
        [Description("Player Indicator")]
        PlayerIndicator = 0x00080060,

        // <summary>
        //     Player 1 Usage.
        // </summary>
        [Description("Player 1")]
        Player1 = 0x00080061,

        // <summary>
        //     Player 2 Usage.
        // </summary>
        [Description("Player 2")]
        Player2 = 0x00080062,

        // <summary>
        //     Player 3 Usage.
        // </summary>
        [Description("Player 3")]
        Player3 = 0x00080063,

        // <summary>
        //     Player 4 Usage.
        // </summary>
        [Description("Player 4")]
        Player4 = 0x00080064,

        // <summary>
        //     Player 5 Usage.
        // </summary>
        [Description("Player 5")]
        Player5 = 0x00080065,

        // <summary>
        //     Player 6 Usage.
        // </summary>
        [Description("Player 6")]
        Player6 = 0x00080066,

        // <summary>
        //     Player 7 Usage.
        // </summary>
        [Description("Player 7")]
        Player7 = 0x00080067,

        // <summary>
        //     Player 8 Usage.
        // </summary>
        [Description("Player 8")]
        Player8 = 0x00080068
    }
}
