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
    //     Consumer Usage Page.
    // </summary>
    [Description("Consumer Usage Page")]
    public enum ConsumerPage : uint
    {
        // <summary>
        //     Undefined Usage.
        // </summary>
        [Description("Undefined")]
        Undefined = 0x000c0000,

        // <summary>
        //     Consumer Control Usage.
        // </summary>
        [Description("Consumer Control")]
        ConsumerControl = 0x000c0001,

        // <summary>
        //     Numeric Key Pad Usage.
        // </summary>
        [Description("Numeric Key Pad")]
        NumericKeyPad = 0x000c0002,

        // <summary>
        //     Programmable Buttons Usage.
        // </summary>
        [Description("Programmable Buttons")]
        ProgrammableButtons = 0x000c0003,

        // <summary>
        //     Microphone Usage.
        // </summary>
        [Description("Microphone")]
        Microphone = 0x000c0004,

        // <summary>
        //     Headphone Usage.
        // </summary>
        [Description("Headphone")]
        Headphone = 0x000c0005,

        // <summary>
        //     Graphic Equalizer Usage.
        // </summary>
        [Description("Graphic Equalizer")]
        GraphicEqualizer = 0x000c0006,

        // <summary>
        //     +10 Usage.
        // </summary>
        [Description("+10")]
        _10 = 0x000c0020,

        // <summary>
        //     +100 Usage.
        // </summary>
        [Description("+100")]
        _100 = 0x000c0021,

        // <summary>
        //     AM/PM Usage.
        // </summary>
        [Description("AM/PM")]
        AMPM = 0x000c0022,

        // <summary>
        //     Power Usage.
        // </summary>
        [Description("Power")]
        Power = 0x000c0030,

        // <summary>
        //     Reset Usage.
        // </summary>
        [Description("Reset")]
        Reset = 0x000c0031,

        // <summary>
        //     Sleep Usage.
        // </summary>
        [Description("Sleep")]
        Sleep = 0x000c0032,

        // <summary>
        //     Sleep After Usage.
        // </summary>
        [Description("Sleep After")]
        SleepAfter = 0x000c0033,

        // <summary>
        //     Sleep Mode Usage.
        // </summary>
        [Description("Sleep Mode")]
        SleepMode = 0x000c0034,

        // <summary>
        //     Illumination Usage.
        // </summary>
        [Description("Illumination")]
        Illumination = 0x000c0035,

        // <summary>
        //     Function Buttons Usage.
        // </summary>
        [Description("Function Buttons")]
        FunctionButtons = 0x000c0036,

        // <summary>
        //     Menu Usage.
        // </summary>
        [Description("Menu")]
        Menu = 0x000c0040,

        // <summary>
        //     Menu Pick Usage.
        // </summary>
        [Description("Menu Pick")]
        MenuPick = 0x000c0041,

        // <summary>
        //     Menu Up Usage.
        // </summary>
        [Description("Menu Up")]
        MenuUp = 0x000c0042,

        // <summary>
        //     Menu Down Usage.
        // </summary>
        [Description("Menu Down")]
        MenuDown = 0x000c0043,

        // <summary>
        //     Menu Left Usage.
        // </summary>
        [Description("Menu Left")]
        MenuLeft = 0x000c0044,

        // <summary>
        //     Menu Right Usage.
        // </summary>
        [Description("Menu Right")]
        MenuRight = 0x000c0045,

        // <summary>
        //     Menu Escape Usage.
        // </summary>
        [Description("Menu Escape")]
        MenuEscape = 0x000c0046,

        // <summary>
        //     Menu Value Increase Usage.
        // </summary>
        [Description("Menu Value Increase")]
        MenuValueIncrease = 0x000c0047,

        // <summary>
        //     Menu Value Decrease Usage.
        // </summary>
        [Description("Menu Value Decrease")]
        MenuValueDecrease = 0x000c0048,

        // <summary>
        //     Data On Screen Usage.
        // </summary>
        [Description("Data On Screen")]
        DataOnScreen = 0x000c0060,

        // <summary>
        //     Closed Caption Usage.
        // </summary>
        [Description("Closed Caption")]
        ClosedCaption = 0x000c0061,

        // <summary>
        //     Closed Caption Select Usage.
        // </summary>
        [Description("Closed Caption Select")]
        ClosedCaptionSelect = 0x000c0062,

        // <summary>
        //     VCR/TV Usage.
        // </summary>
        [Description("VCR/TV")]
        VCRTV = 0x000c0063,

        // <summary>
        //     Broadcast Mode Usage.
        // </summary>
        [Description("Broadcast Mode")]
        BroadcastMode = 0x000c0064,

        // <summary>
        //     Snapshot Usage.
        // </summary>
        [Description("Snapshot")]
        Snapshot = 0x000c0065,

        // <summary>
        //     Still Usage.
        // </summary>
        [Description("Still")]
        Still = 0x000c0066,

        // <summary>
        //     Picture-in-Picture Toggle Usage.
        // </summary>
        [Description("Picture-in-Picture Toggle")]
        PictureinPictureToggle = 0x000c0067,

        // <summary>
        //     Picture-in-Picture Swap Usage.
        // </summary>
        [Description("Picture-in-Picture Swap")]
        PictureinPictureSwap = 0x000c0068,

        // <summary>
        //     Red Menu Button Usage.
        // </summary>
        [Description("Red Menu Button")]
        RedMenuButton = 0x000c0069,

        // <summary>
        //     Green Menu Button Usage.
        // </summary>
        [Description("Green Menu Button")]
        GreenMenuButton = 0x000c006a,

        // <summary>
        //     Blue Menu Button Usage.
        // </summary>
        [Description("Blue Menu Button")]
        BlueMenuButton = 0x000c006b,

        // <summary>
        //     Yellow Menu Button Usage.
        // </summary>
        [Description("Yellow Menu Button")]
        YellowMenuButton = 0x000c006c,

        // <summary>
        //     Aspect Usage.
        // </summary>
        [Description("Aspect")]
        Aspect = 0x000c006d,

        // <summary>
        //     3D Mode Select Usage.
        // </summary>
        [Description("3D Mode Select")]
        _3DModeSelect = 0x000c006e,

        // <summary>
        //     Display Brightness Increment Usage.
        // </summary>
        [Description("Display Brightness Increment")]
        DisplayBrightnessIncrement = 0x000c006f,

        // <summary>
        //     Display Brightness Decrement Usage.
        // </summary>
        [Description("Display Brightness Decrement")]
        DisplayBrightnessDecrement = 0x000c0070,

        // <summary>
        //     Display Brightness Usage.
        // </summary>
        [Description("Display Brightness")]
        DisplayBrightness = 0x000c0071,

        // <summary>
        //     Display Backlight Toggle Usage.
        // </summary>
        [Description("Display Backlight Toggle")]
        DisplayBacklightToggle = 0x000c0072,

        // <summary>
        //     Display Set Brightness to Minimum Usage.
        // </summary>
        [Description("Display Set Brightness to Minimum")]
        DisplaySetBrightnessToMinimum = 0x000c0073,

        // <summary>
        //     Display Set Brightness to Maximum Usage.
        // </summary>
        [Description("Display Set Brightness to Maximum")]
        DisplaySetBrightnessToMaximum = 0x000c0074,

        // <summary>
        //     Display Set Auto Brightness Usage.
        // </summary>
        [Description("Display Set Auto Brightness")]
        DisplaySetAutoBrightness = 0x000c0075,

        // <summary>
        //     Camera Access Enabled Usage.
        // </summary>
        [Description("Camera Access Enabled")]
        CameraAccessEnabled = 0x000c0076,

        // <summary>
        //     Camera Access Disabled Usage.
        // </summary>
        [Description("Camera Access Disabled")]
        CameraAccessDisabled = 0x000c0077,

        // <summary>
        //     Camera Access Toggle Usage.
        // </summary>
        [Description("Camera Access Toggle")]
        CameraAccessToggle = 0x000c0078,

        // <summary>
        //     Keyboard Brightness Increment Usage.
        // </summary>
        [Description("Keyboard Brightness Increment")]
        KeyboardBrightnessIncrement = 0x000c0079,

        // <summary>
        //     Keyboard Brightness Decrement Usage.
        // </summary>
        [Description("Keyboard Brightness Decrement")]
        KeyboardBrightnessDecrement = 0x000c007a,

        // <summary>
        //     Keyboard Backlight Set Level Usage.
        // </summary>
        [Description("Keyboard Backlight Set Level")]
        KeyboardBacklightSetLevel = 0x000c007b,

        // <summary>
        //     Keyboard Backlight OOC Usage.
        // </summary>
        [Description("Keyboard Backlight OOC")]
        KeyboardBacklightOOC = 0x000c007c,

        // <summary>
        //     Keyboard Backlight Set Minimum Usage.
        // </summary>
        [Description("Keyboard Backlight Set Minimum")]
        KeyboardBacklightSetMinimum = 0x000c007d,

        // <summary>
        //     Keyboard Backlight Set Maximum Usage.
        // </summary>
        [Description("Keyboard Backlight Set Maximum")]
        KeyboardBacklightSetMaximum = 0x000c007e,

        // <summary>
        //     Keyboard Backlight Auto Usage.
        // </summary>
        [Description("Keyboard Backlight Auto")]
        KeyboardBacklightAuto = 0x000c007f,

        // <summary>
        //     Selection Usage.
        // </summary>
        [Description("Selection")]
        Selection = 0x000c0080,

        // <summary>
        //     Assign Selection Usage.
        // </summary>
        [Description("Assign Selection")]
        AssignSelection = 0x000c0081,

        // <summary>
        //     Mode Step Usage.
        // </summary>
        [Description("Mode Step")]
        ModeStep = 0x000c0082,

        // <summary>
        //     Recall Last Usage.
        // </summary>
        [Description("Recall Last")]
        RecallLast = 0x000c0083,

        // <summary>
        //     Enter Channel Usage.
        // </summary>
        [Description("Enter Channel")]
        EnterChannel = 0x000c0084,

        // <summary>
        //     Order Movie Usage.
        // </summary>
        [Description("Order Movie")]
        OrderMovie = 0x000c0085,

        // <summary>
        //     Channel Usage.
        // </summary>
        [Description("Channel")]
        Channel = 0x000c0086,

        // <summary>
        //     Media Selection Usage.
        // </summary>
        [Description("Media Selection")]
        MediaSelection = 0x000c0087,

        // <summary>
        //     Media Select Computer Usage.
        // </summary>
        [Description("Media Select Computer")]
        MediaSelectComputer = 0x000c0088,

        // <summary>
        //     Media Select TV Usage.
        // </summary>
        [Description("Media Select TV")]
        MediaSelectTV = 0x000c0089,

        // <summary>
        //     Media Select WWW Usage.
        // </summary>
        [Description("Media Select WWW")]
        MediaSelectWWW = 0x000c008a,

        // <summary>
        //     Media Select DVD Usage.
        // </summary>
        [Description("Media Select DVD")]
        MediaSelectDVD = 0x000c008b,

        // <summary>
        //     Media Select Telephone Usage.
        // </summary>
        [Description("Media Select Telephone")]
        MediaSelectTelephone = 0x000c008c,

        // <summary>
        //     Media Select Program Guide Usage.
        // </summary>
        [Description("Media Select Program Guide")]
        MediaSelectProgramGuide = 0x000c008d,

        // <summary>
        //     Media Select Video Phone Usage.
        // </summary>
        [Description("Media Select Video Phone")]
        MediaSelectVideoPhone = 0x000c008e,

        // <summary>
        //     Media Select Games Usage.
        // </summary>
        [Description("Media Select Games")]
        MediaSelectGames = 0x000c008f,

        // <summary>
        //     Media Select Messages Usage.
        // </summary>
        [Description("Media Select Messages")]
        MediaSelectMessages = 0x000c0090,

        // <summary>
        //     Media Select CD Usage.
        // </summary>
        [Description("Media Select CD")]
        MediaSelectCD = 0x000c0091,

        // <summary>
        //     Media Select VCR Usage.
        // </summary>
        [Description("Media Select VCR")]
        MediaSelectVCR = 0x000c0092,

        // <summary>
        //     Media Select Tuner Usage.
        // </summary>
        [Description("Media Select Tuner")]
        MediaSelectTuner = 0x000c0093,

        // <summary>
        //     Quit Usage.
        // </summary>
        [Description("Quit")]
        Quit = 0x000c0094,

        // <summary>
        //     Help Usage.
        // </summary>
        [Description("Help")]
        Help = 0x000c0095,

        // <summary>
        //     Media Select Tape Usage.
        // </summary>
        [Description("Media Select Tape")]
        MediaSelectTape = 0x000c0096,

        // <summary>
        //     Media Select Cable Usage.
        // </summary>
        [Description("Media Select Cable")]
        MediaSelectCable = 0x000c0097,

        // <summary>
        //     Media Select Satellite Usage.
        // </summary>
        [Description("Media Select Satellite")]
        MediaSelectSatellite = 0x000c0098,

        // <summary>
        //     Media Select Security Usage.
        // </summary>
        [Description("Media Select Security")]
        MediaSelectSecurity = 0x000c0099,

        // <summary>
        //     Media Select Home Usage.
        // </summary>
        [Description("Media Select Home")]
        MediaSelectHome = 0x000c009a,

        // <summary>
        //     Media Select Call Usage.
        // </summary>
        [Description("Media Select Call")]
        MediaSelectCall = 0x000c009b,

        // <summary>
        //     Channel Increment Usage.
        // </summary>
        [Description("Channel Increment")]
        ChannelIncrement = 0x000c009c,

        // <summary>
        //     Channel Decrement Usage.
        // </summary>
        [Description("Channel Decrement")]
        ChannelDecrement = 0x000c009d,

        // <summary>
        //     Media Select SAP Usage.
        // </summary>
        [Description("Media Select SAP")]
        MediaSelectSAP = 0x000c009e,

        // <summary>
        //     VCR Plus Usage.
        // </summary>
        [Description("VCR Plus")]
        VCRPlus = 0x000c00a0,

        // <summary>
        //     Once Usage.
        // </summary>
        [Description("Once")]
        Once = 0x000c00a1,

        // <summary>
        //     Daily Usage.
        // </summary>
        [Description("Daily")]
        Daily = 0x000c00a2,

        // <summary>
        //     Weekly Usage.
        // </summary>
        [Description("Weekly")]
        Weekly = 0x000c00a3,

        // <summary>
        //     Monthly Usage.
        // </summary>
        [Description("Monthly")]
        Monthly = 0x000c00a4,

        // <summary>
        //     Play Usage.
        // </summary>
        [Description("Play")]
        Play = 0x000c00b0,

        // <summary>
        //     Pause Usage.
        // </summary>
        [Description("Pause")]
        Pause = 0x000c00b1,

        // <summary>
        //     Record Usage.
        // </summary>
        [Description("Record")]
        Record = 0x000c00b2,

        // <summary>
        //     Fast Forward Usage.
        // </summary>
        [Description("Fast Forward")]
        FastForward = 0x000c00b3,

        // <summary>
        //     Rewind Usage.
        // </summary>
        [Description("Rewind")]
        Rewind = 0x000c00b4,

        // <summary>
        //     Scan Next Track Usage.
        // </summary>
        [Description("Scan Next Track")]
        ScanNextTrack = 0x000c00b5,

        // <summary>
        //     Scan Previous Track Usage.
        // </summary>
        [Description("Scan Previous Track")]
        ScanPreviousTrack = 0x000c00b6,

        // <summary>
        //     Stop Usage.
        // </summary>
        [Description("Stop")]
        Stop = 0x000c00b7,

        // <summary>
        //     Eject Usage.
        // </summary>
        [Description("Eject")]
        Eject = 0x000c00b8,

        // <summary>
        //     Random Play Usage.
        // </summary>
        [Description("Random Play")]
        RandomPlay = 0x000c00b9,

        // <summary>
        //     Select Disc Usage.
        // </summary>
        [Description("Select Disc")]
        SelectDisc = 0x000c00ba,

        // <summary>
        //     Enter Disc Usage.
        // </summary>
        [Description("Enter Disc")]
        EnterDisc = 0x000c00bb,

        // <summary>
        //     Repeat Usage.
        // </summary>
        [Description("Repeat")]
        Repeat = 0x000c00bc,

        // <summary>
        //     Tracking Usage.
        // </summary>
        [Description("Tracking")]
        Tracking = 0x000c00bd,

        // <summary>
        //     Track Normal Usage.
        // </summary>
        [Description("Track Normal")]
        TrackNormal = 0x000c00be,

        // <summary>
        //     Slow Tracking Usage.
        // </summary>
        [Description("Slow Tracking")]
        SlowTracking = 0x000c00bf,

        // <summary>
        //     Frame Forward Usage.
        // </summary>
        [Description("Frame Forward")]
        FrameForward = 0x000c00c0,

        // <summary>
        //     Frame Back Usage.
        // </summary>
        [Description("Frame Back")]
        FrameBack = 0x000c00c1,

        // <summary>
        //     Mark Usage.
        // </summary>
        [Description("Mark")]
        Mark = 0x000c00c2,

        // <summary>
        //     Clear Mark Usage.
        // </summary>
        [Description("Clear Mark")]
        ClearMark = 0x000c00c3,

        // <summary>
        //     Repeat From Mark Usage.
        // </summary>
        [Description("Repeat From Mark")]
        RepeatFromMark = 0x000c00c4,

        // <summary>
        //     Return To Mark Usage.
        // </summary>
        [Description("Return To Mark")]
        ReturnToMark = 0x000c00c5,

        // <summary>
        //     Search Mark Forward Usage.
        // </summary>
        [Description("Search Mark Forward")]
        SearchMarkForward = 0x000c00c6,

        // <summary>
        //     Search Mark Backwards Usage.
        // </summary>
        [Description("Search Mark Backwards")]
        SearchMarkBackwards = 0x000c00c7,

        // <summary>
        //     Counter Reset Usage.
        // </summary>
        [Description("Counter Reset")]
        CounterReset = 0x000c00c8,

        // <summary>
        //     Show Counter Usage.
        // </summary>
        [Description("Show Counter")]
        ShowCounter = 0x000c00c9,

        // <summary>
        //     Tracking Increment Usage.
        // </summary>
        [Description("Tracking Increment")]
        TrackingIncrement = 0x000c00ca,

        // <summary>
        //     Tracking Decrement Usage.
        // </summary>
        [Description("Tracking Decrement")]
        TrackingDecrement = 0x000c00cb,

        // <summary>
        //     Stop/Eject Usage.
        // </summary>
        [Description("Stop/Eject")]
        StopEject = 0x000c00cc,

        // <summary>
        //     Play/Pause Usage.
        // </summary>
        [Description("Play/Pause")]
        PlayPause = 0x000c00cd,

        // <summary>
        //     Play/Skip Usage.
        // </summary>
        [Description("Play/Skip")]
        PlaySkip = 0x000c00ce,

        // <summary>
        //     Voice Command Usage.
        // </summary>
        [Description("Voice Command")]
        VoiceCommand = 0x000c00cf,

        // <summary>
        //     Invoke Capture Interface Usage.
        // </summary>
        [Description("Invoke Capture Interface")]
        InvokeCaptureInterface = 0x000c00d0,

        // <summary>
        //     Start or Stop Game Recording Usage.
        // </summary>
        [Description("Start or Stop Game Recording")]
        StartOrStopGameRecording = 0x000c00d1,

        // <summary>
        //     Historical Game Capture Usage.
        // </summary>
        [Description("Historical Game Capture")]
        HistoricalGameCapture = 0x000c00d2,

        // <summary>
        //     Capture Game Screenshot Usage.
        // </summary>
        [Description("Capture Game Screenshot")]
        CaptureGameScreenshot = 0x000c00d3,

        // <summary>
        //     Show or Hide Recording Indicator Usage.
        // </summary>
        [Description("Show or Hide Recording Indicator")]
        ShowOrHideRecordingIndicator = 0x000c00d4,

        // <summary>
        //     Start or Stop Microphone Capture Usage.
        // </summary>
        [Description("Start or Stop Microphone Capture")]
        StartOrStopMicrophoneCapture = 0x000c00d5,

        // <summary>
        //     Start or Stop Camera Capture Usage.
        // </summary>
        [Description("Start or Stop Camera Capture")]
        StartOrStopCameraCapture = 0x000c00d6,

        // <summary>
        //     Start or Stop Game Broadcast Usage.
        // </summary>
        [Description("Start or Stop Game Broadcast")]
        StartOrStopGameBroadcast = 0x000c00d7,

        // <summary>
        //     Start or Stop Voice Dictation Session Usage.
        // </summary>
        [Description("Start or Stop Voice Dictation Session")]
        StartOrStopVoiceDictationSession = 0x000c00d8,

        // <summary>
        //     Invoke/Dismiss Emoji Picker Usage.
        // </summary>
        [Description("Invoke/Dismiss Emoji Picker")]
        InvokeDismissEmojiPicker = 0x000c00d9,

        // <summary>
        //     Volume Usage.
        // </summary>
        [Description("Volume")]
        Volume = 0x000c00e0,

        // <summary>
        //     Balance Usage.
        // </summary>
        [Description("Balance")]
        Balance = 0x000c00e1,

        // <summary>
        //     Mute Usage.
        // </summary>
        [Description("Mute")]
        Mute = 0x000c00e2,

        // <summary>
        //     Bass Usage.
        // </summary>
        [Description("Bass")]
        Bass = 0x000c00e3,

        // <summary>
        //     Treble Usage.
        // </summary>
        [Description("Treble")]
        Treble = 0x000c00e4,

        // <summary>
        //     Bass Boost Usage.
        // </summary>
        [Description("Bass Boost")]
        BassBoost = 0x000c00e5,

        // <summary>
        //     Surround Mode Usage.
        // </summary>
        [Description("Surround Mode")]
        SurroundMode = 0x000c00e6,

        // <summary>
        //     Loudness Usage.
        // </summary>
        [Description("Loudness")]
        Loudness = 0x000c00e7,

        // <summary>
        //     MPX Usage.
        // </summary>
        [Description("MPX")]
        MPX = 0x000c00e8,

        // <summary>
        //     Volume Increment Usage.
        // </summary>
        [Description("Volume Increment")]
        VolumeIncrement = 0x000c00e9,

        // <summary>
        //     Volume Decrement Usage.
        // </summary>
        [Description("Volume Decrement")]
        VolumeDecrement = 0x000c00ea,

        // <summary>
        //     Speed Select Usage.
        // </summary>
        [Description("Speed Select")]
        SpeedSelect = 0x000c00f0,

        // <summary>
        //     Playback Speed Usage.
        // </summary>
        [Description("Playback Speed")]
        PlaybackSpeed = 0x000c00f1,

        // <summary>
        //     Standard Play Usage.
        // </summary>
        [Description("Standard Play")]
        StandardPlay = 0x000c00f2,

        // <summary>
        //     Long Play Usage.
        // </summary>
        [Description("Long Play")]
        LongPlay = 0x000c00f3,

        // <summary>
        //     Extended Play Usage.
        // </summary>
        [Description("Extended Play")]
        ExtendedPlay = 0x000c00f4,

        // <summary>
        //     Slow Usage.
        // </summary>
        [Description("Slow")]
        Slow = 0x000c00f5,

        // <summary>
        //     Fan Enable Usage.
        // </summary>
        [Description("Fan Enable")]
        FanEnable = 0x000c0100,

        // <summary>
        //     Fan Speed Usage.
        // </summary>
        [Description("Fan Speed")]
        FanSpeed = 0x000c0101,

        // <summary>
        //     Light Enable Usage.
        // </summary>
        [Description("Light Enable")]
        LightEnable = 0x000c0102,

        // <summary>
        //     Light Illumination Level Usage.
        // </summary>
        [Description("Light Illumination Level")]
        LightIlluminationLevel = 0x000c0103,

        // <summary>
        //     Climate Control Enable Usage.
        // </summary>
        [Description("Climate Control Enable")]
        ClimateControlEnable = 0x000c0104,

        // <summary>
        //     Room Temperature Usage.
        // </summary>
        [Description("Room Temperature")]
        RoomTemperature = 0x000c0105,

        // <summary>
        //     Security Enable Usage.
        // </summary>
        [Description("Security Enable")]
        SecurityEnable = 0x000c0106,

        // <summary>
        //     Fire Alarm Usage.
        // </summary>
        [Description("Fire Alarm")]
        FireAlarm = 0x000c0107,

        // <summary>
        //     Police Alarm Usage.
        // </summary>
        [Description("Police Alarm")]
        PoliceAlarm = 0x000c0108,

        // <summary>
        //     Proximity Usage.
        // </summary>
        [Description("Proximity")]
        Proximity = 0x000c0109,

        // <summary>
        //     Motion Usage.
        // </summary>
        [Description("Motion")]
        Motion = 0x000c010a,

        // <summary>
        //     Duress Alarm Usage.
        // </summary>
        [Description("Duress Alarm")]
        DuressAlarm = 0x000c010b,

        // <summary>
        //     Holdup Alarm Usage.
        // </summary>
        [Description("Holdup Alarm")]
        HoldupAlarm = 0x000c010c,

        // <summary>
        //     Medical Alarm Usage.
        // </summary>
        [Description("Medical Alarm")]
        MedicalAlarm = 0x000c010d,

        // <summary>
        //     Balance Right Usage.
        // </summary>
        [Description("Balance Right")]
        BalanceRight = 0x000c0150,

        // <summary>
        //     Balance Left Usage.
        // </summary>
        [Description("Balance Left")]
        BalanceLeft = 0x000c0151,

        // <summary>
        //     Bass Increment Usage.
        // </summary>
        [Description("Bass Increment")]
        BassIncrement = 0x000c0152,

        // <summary>
        //     Bass Decrement Usage.
        // </summary>
        [Description("Bass Decrement")]
        BassDecrement = 0x000c0153,

        // <summary>
        //     Treble Increment Usage.
        // </summary>
        [Description("Treble Increment")]
        TrebleIncrement = 0x000c0154,

        // <summary>
        //     Treble Decrement Usage.
        // </summary>
        [Description("Treble Decrement")]
        TrebleDecrement = 0x000c0155,

        // <summary>
        //     Speaker System Usage.
        // </summary>
        [Description("Speaker System")]
        SpeakerSystem = 0x000c0160,

        // <summary>
        //     Channel Left Usage.
        // </summary>
        [Description("Channel Left")]
        ChannelLeft = 0x000c0161,

        // <summary>
        //     Channel Right Usage.
        // </summary>
        [Description("Channel Right")]
        ChannelRight = 0x000c0162,

        // <summary>
        //     Channel Center Usage.
        // </summary>
        [Description("Channel Center")]
        ChannelCenter = 0x000c0163,

        // <summary>
        //     Channel Front Usage.
        // </summary>
        [Description("Channel Front")]
        ChannelFront = 0x000c0164,

        // <summary>
        //     Channel Center Front Usage.
        // </summary>
        [Description("Channel Center Front")]
        ChannelCenterFront = 0x000c0165,

        // <summary>
        //     Channel Side Usage.
        // </summary>
        [Description("Channel Side")]
        ChannelSide = 0x000c0166,

        // <summary>
        //     Channel Surround Usage.
        // </summary>
        [Description("Channel Surround")]
        ChannelSurround = 0x000c0167,

        // <summary>
        //     Channel Low Frequency Enhancement Usage.
        // </summary>
        [Description("Channel Low Frequency Enhancement")]
        ChannelLowFrequencyEnhancement = 0x000c0168,

        // <summary>
        //     Channel Top Usage.
        // </summary>
        [Description("Channel Top")]
        ChannelTop = 0x000c0169,

        // <summary>
        //     Channel Unknown Usage.
        // </summary>
        [Description("Channel Unknown")]
        ChannelUnknown = 0x000c016a,

        // <summary>
        //     Sub-channel Usage.
        // </summary>
        [Description("Sub-channel")]
        Subchannel = 0x000c0170,

        // <summary>
        //     Sub-channel Increment Usage.
        // </summary>
        [Description("Sub-channel Increment")]
        SubchannelIncrement = 0x000c0171,

        // <summary>
        //     Sub-channel Decrement Usage.
        // </summary>
        [Description("Sub-channel Decrement")]
        SubchannelDecrement = 0x000c0172,

        // <summary>
        //     Alternate Audio Increment Usage.
        // </summary>
        [Description("Alternate Audio Increment")]
        AlternateAudioIncrement = 0x000c0173,

        // <summary>
        //     Alternate Audio Decrement Usage.
        // </summary>
        [Description("Alternate Audio Decrement")]
        AlternateAudioDecrement = 0x000c0174,

        // <summary>
        //     Application Launch Buttons Usage.
        // </summary>
        [Description("Application Launch Buttons")]
        ApplicationLaunchButtons = 0x000c0180,

        // <summary>
        //     AL Launch Button Configuration Tool Usage.
        // </summary>
        [Description("AL Launch Button Configuration Tool")]
        ALLaunchButtonConfigurationTool = 0x000c0181,

        // <summary>
        //     AL Programmable Button Configuration Usage.
        // </summary>
        [Description("AL Programmable Button Configuration")]
        ALProgrammableButtonConfiguration = 0x000c0182,

        // <summary>
        //     AL Consumer Control Configuration Usage.
        // </summary>
        [Description("AL Consumer Control Configuration")]
        ALConsumerControlConfiguration = 0x000c0183,

        // <summary>
        //     AL Word Processor Usage.
        // </summary>
        [Description("AL Word Processor")]
        ALWordProcessor = 0x000c0184,

        // <summary>
        //     AL Text Editor Usage.
        // </summary>
        [Description("AL Text Editor")]
        ALTextEditor = 0x000c0185,

        // <summary>
        //     AL Spreadsheet Usage.
        // </summary>
        [Description("AL Spreadsheet")]
        ALSpreadsheet = 0x000c0186,

        // <summary>
        //     AL Graphics Editor Usage.
        // </summary>
        [Description("AL Graphics Editor")]
        ALGraphicsEditor = 0x000c0187,

        // <summary>
        //     AL Presentation App Usage.
        // </summary>
        [Description("AL Presentation App")]
        ALPresentationApp = 0x000c0188,

        // <summary>
        //     AL Database App Usage.
        // </summary>
        [Description("AL Database App")]
        ALDatabaseApp = 0x000c0189,

        // <summary>
        //     AL Email Reader Usage.
        // </summary>
        [Description("AL Email Reader")]
        ALEmailReader = 0x000c018a,

        // <summary>
        //     AL Newsreader Usage.
        // </summary>
        [Description("AL Newsreader")]
        ALNewsreader = 0x000c018b,

        // <summary>
        //     AL Voicemail Usage.
        // </summary>
        [Description("AL Voicemail")]
        ALVoicemail = 0x000c018c,

        // <summary>
        //     AL Contacts/Address Book Usage.
        // </summary>
        [Description("AL Contacts/Address Book")]
        ALContactsAddressBook = 0x000c018d,

        // <summary>
        //     AL Calendar/Schedule Usage.
        // </summary>
        [Description("AL Calendar/Schedule")]
        ALCalendarSchedule = 0x000c018e,

        // <summary>
        //     AL Task/Project Manager Usage.
        // </summary>
        [Description("AL Task/Project Manager")]
        ALTaskProjectManager = 0x000c018f,

        // <summary>
        //     AL Log/Journal/Timecard Usage.
        // </summary>
        [Description("AL Log/Journal/Timecard")]
        ALLogJournalTimecard = 0x000c0190,

        // <summary>
        //     AL Checkbook/Finance Usage.
        // </summary>
        [Description("AL Checkbook/Finance")]
        ALCheckbookFinance = 0x000c0191,

        // <summary>
        //     AL Calculator Usage.
        // </summary>
        [Description("AL Calculator")]
        ALCalculator = 0x000c0192,

        // <summary>
        //     AL A/V Capture/Playback Usage.
        // </summary>
        [Description("AL A/V Capture/Playback")]
        ALAVCapturePlayback = 0x000c0193,

        // <summary>
        //     AL Local Machine Browser Usage.
        // </summary>
        [Description("AL Local Machine Browser")]
        ALLocalMachineBrowser = 0x000c0194,

        // <summary>
        //     AL LAN/WAN Browser Usage.
        // </summary>
        [Description("AL LAN/WAN Browser")]
        ALLANWANBrowser = 0x000c0195,

        // <summary>
        //     AL Internet Browser Usage.
        // </summary>
        [Description("AL Internet Browser")]
        ALInternetBrowser = 0x000c0196,

        // <summary>
        //     AL Remote Networking/ISP Connect Usage.
        // </summary>
        [Description("AL Remote Networking/ISP Connect")]
        ALRemoteNetworkingISPConnect = 0x000c0197,

        // <summary>
        //     AL Network Conference Usage.
        // </summary>
        [Description("AL Network Conference")]
        ALNetworkConference = 0x000c0198,

        // <summary>
        //     AL Network Chat Usage.
        // </summary>
        [Description("AL Network Chat")]
        ALNetworkChat = 0x000c0199,

        // <summary>
        //     AL Telephony/Dialer Usage.
        // </summary>
        [Description("AL Telephony/Dialer")]
        ALTelephonyDialer = 0x000c019a,

        // <summary>
        //     AL Logon Usage.
        // </summary>
        [Description("AL Logon")]
        ALLogon = 0x000c019b,

        // <summary>
        //     AL Logoff Usage.
        // </summary>
        [Description("AL Logoff")]
        ALLogoff = 0x000c019c,

        // <summary>
        //     AL Logon/Logoff Usage.
        // </summary>
        [Description("AL Logon/Logoff")]
        ALLogonLogoff = 0x000c019d,

        // <summary>
        //     AL Terminal Lock/Screensaver Usage.
        // </summary>
        [Description("AL Terminal Lock/Screensaver")]
        ALTerminalLockScreensaver = 0x000c019e,

        // <summary>
        //     AL Control Panel Usage.
        // </summary>
        [Description("AL Control Panel")]
        ALControlPanel = 0x000c019f,

        // <summary>
        //     AL Command Line Processor/Run Usage.
        // </summary>
        [Description("AL Command Line Processor/Run")]
        ALCommandLineProcessorRun = 0x000c01a0,

        // <summary>
        //     AL Process/Task Manager Usage.
        // </summary>
        [Description("AL Process/Task Manager")]
        ALProcessTaskManager = 0x000c01a1,

        // <summary>
        //     AL Select Task/Application Usage.
        // </summary>
        [Description("AL Select Task/Application")]
        ALSelectTaskApplication = 0x000c01a2,

        // <summary>
        //     AL Next Task/Application Usage.
        // </summary>
        [Description("AL Next Task/Application")]
        ALNextTaskApplication = 0x000c01a3,

        // <summary>
        //     AL Previous Task/Application Usage.
        // </summary>
        [Description("AL Previous Task/Application")]
        ALPreviousTaskApplication = 0x000c01a4,

        // <summary>
        //     AL Preemptive Halt Task/Application Usage.
        // </summary>
        [Description("AL Preemptive Halt Task/Application")]
        ALPreemptiveHaltTaskApplication = 0x000c01a5,

        // <summary>
        //     AL Integrated Help Center Usage.
        // </summary>
        [Description("AL Integrated Help Center")]
        ALIntegratedHelpCenter = 0x000c01a6,

        // <summary>
        //     AL Documents Usage.
        // </summary>
        [Description("AL Documents")]
        ALDocuments = 0x000c01a7,

        // <summary>
        //     AL Thesaurus Usage.
        // </summary>
        [Description("AL Thesaurus")]
        ALThesaurus = 0x000c01a8,

        // <summary>
        //     AL Dictionary Usage.
        // </summary>
        [Description("AL Dictionary")]
        ALDictionary = 0x000c01a9,

        // <summary>
        //     AL Desktop Usage.
        // </summary>
        [Description("AL Desktop")]
        ALDesktop = 0x000c01aa,

        // <summary>
        //     AL Spell Check Usage.
        // </summary>
        [Description("AL Spell Check")]
        ALSpellCheck = 0x000c01ab,

        // <summary>
        //     AL Grammar Check Usage.
        // </summary>
        [Description("AL Grammar Check")]
        ALGrammarCheck = 0x000c01ac,

        // <summary>
        //     AL Wireless Status Usage.
        // </summary>
        [Description("AL Wireless Status")]
        ALWirelessStatus = 0x000c01ad,

        // <summary>
        //     AL Keyboard Layout Usage.
        // </summary>
        [Description("AL Keyboard Layout")]
        ALKeyboardLayout = 0x000c01ae,

        // <summary>
        //     AL Virus Protection Usage.
        // </summary>
        [Description("AL Virus Protection")]
        ALVirusProtection = 0x000c01af,

        // <summary>
        //     AL Encryption Usage.
        // </summary>
        [Description("AL Encryption")]
        ALEncryption = 0x000c01b0,

        // <summary>
        //     AL Screen Saver Usage.
        // </summary>
        [Description("AL Screen Saver")]
        ALScreenSaver = 0x000c01b1,

        // <summary>
        //     AL Alarms Usage.
        // </summary>
        [Description("AL Alarms")]
        ALAlarms = 0x000c01b2,

        // <summary>
        //     AL Clock Usage.
        // </summary>
        [Description("AL Clock")]
        ALClock = 0x000c01b3,

        // <summary>
        //     AL File Browser Usage.
        // </summary>
        [Description("AL File Browser")]
        ALFileBrowser = 0x000c01b4,

        // <summary>
        //     AL Power Status Usage.
        // </summary>
        [Description("AL Power Status")]
        ALPowerStatus = 0x000c01b5,

        // <summary>
        //     AL Image Browser Usage.
        // </summary>
        [Description("AL Image Browser")]
        ALImageBrowser = 0x000c01b6,

        // <summary>
        //     AL Audio Browser Usage.
        // </summary>
        [Description("AL Audio Browser")]
        ALAudioBrowser = 0x000c01b7,

        // <summary>
        //     AL Movie Browser Usage.
        // </summary>
        [Description("AL Movie Browser")]
        ALMovieBrowser = 0x000c01b8,

        // <summary>
        //     AL Digital Rights Manager Usage.
        // </summary>
        [Description("AL Digital Rights Manager")]
        ALDigitalRightsManager = 0x000c01b9,

        // <summary>
        //     AL Digital Wallet Usage.
        // </summary>
        [Description("AL Digital Wallet")]
        ALDigitalWallet = 0x000c01ba,

        // <summary>
        //     AL Instant Messaging Usage.
        // </summary>
        [Description("AL Instant Messaging")]
        ALInstantMessaging = 0x000c01bc,

        // <summary>
        //     AL OEM Features/ Tips/Tutorial Browser Usage.
        // </summary>
        [Description("AL OEM Features/ Tips/Tutorial Browser")]
        ALOEMFeaturesTipsTutorialBrowser = 0x000c01bd,

        // <summary>
        //     AL OEM Help Usage.
        // </summary>
        [Description("AL OEM Help")]
        ALOEMHelp = 0x000c01be,

        // <summary>
        //     AL Online Community Usage.
        // </summary>
        [Description("AL Online Community")]
        ALOnlineCommunity = 0x000c01bf,

        // <summary>
        //     AL Entertainment Content Browser Usage.
        // </summary>
        [Description("AL Entertainment Content Browser")]
        ALEntertainmentContentBrowser = 0x000c01c0,

        // <summary>
        //     AL Online Shopping Browser Usage.
        // </summary>
        [Description("AL Online Shopping Browser")]
        ALOnlineShoppingBrowser = 0x000c01c1,

        // <summary>
        //     AL SmartCard Information/Help Usage.
        // </summary>
        [Description("AL SmartCard Information/Help")]
        ALSmartCardInformationHelp = 0x000c01c2,

        // <summary>
        //     AL Market Monitor/Finance Browser Usage.
        // </summary>
        [Description("AL Market Monitor/Finance Browser")]
        ALMarketMonitorFinanceBrowser = 0x000c01c3,

        // <summary>
        //     AL Customized Corporate News Browser Usage.
        // </summary>
        [Description("AL Customized Corporate News Browser")]
        ALCustomizedCorporateNewsBrowser = 0x000c01c4,

        // <summary>
        //     AL Online Activity Browser Usage.
        // </summary>
        [Description("AL Online Activity Browser")]
        ALOnlineActivityBrowser = 0x000c01c5,

        // <summary>
        //     AL Research/Search Browser Usage.
        // </summary>
        [Description("AL Research/Search Browser")]
        ALResearchSearchBrowser = 0x000c01c6,

        // <summary>
        //     AL Audio Player Usage.
        // </summary>
        [Description("AL Audio Player")]
        ALAudioPlayer = 0x000c01c7,

        // <summary>
        //     AL Message Status Usage.
        // </summary>
        [Description("AL Message Status")]
        ALMessageStatus = 0x000c01c8,

        // <summary>
        //     AL Contact Sync Usage.
        // </summary>
        [Description("AL Contact Sync")]
        ALContactSync = 0x000c01c9,

        // <summary>
        //     AL Navigation Usage.
        // </summary>
        [Description("AL Navigation")]
        ALNavigation = 0x000c01ca,

        // <summary>
        //     AL Context‐aware Desktop Assistant Usage.
        // </summary>
        [Description("AL Context‐aware Desktop Assistant")]
        ALContextawareDesktopAssistant = 0x000c01cb,

        // <summary>
        //     Generic GUI Application Controls Usage.
        // </summary>
        [Description("Generic GUI Application Controls")]
        GenericGUIApplicationControls = 0x000c0200,

        // <summary>
        //     AC New Usage.
        // </summary>
        [Description("AC New")]
        ACNew = 0x000c0201,

        // <summary>
        //     AC Open Usage.
        // </summary>
        [Description("AC Open")]
        ACOpen = 0x000c0202,

        // <summary>
        //     AC Close Usage.
        // </summary>
        [Description("AC Close")]
        ACClose = 0x000c0203,

        // <summary>
        //     AC Exit Usage.
        // </summary>
        [Description("AC Exit")]
        ACExit = 0x000c0204,

        // <summary>
        //     AC Maximize Usage.
        // </summary>
        [Description("AC Maximize")]
        ACMaximize = 0x000c0205,

        // <summary>
        //     AC Minimize Usage.
        // </summary>
        [Description("AC Minimize")]
        ACMinimize = 0x000c0206,

        // <summary>
        //     AC Save Usage.
        // </summary>
        [Description("AC Save")]
        ACSave = 0x000c0207,

        // <summary>
        //     AC Print Usage.
        // </summary>
        [Description("AC Print")]
        ACPrint = 0x000c0208,

        // <summary>
        //     AC Properties Usage.
        // </summary>
        [Description("AC Properties")]
        ACProperties = 0x000c0209,

        // <summary>
        //     AC Undo Usage.
        // </summary>
        [Description("AC Undo")]
        ACUndo = 0x000c021a,

        // <summary>
        //     AC Copy Usage.
        // </summary>
        [Description("AC Copy")]
        ACCopy = 0x000c021b,

        // <summary>
        //     AC Cut Usage.
        // </summary>
        [Description("AC Cut")]
        ACCut = 0x000c021c,

        // <summary>
        //     AC Paste Usage.
        // </summary>
        [Description("AC Paste")]
        ACPaste = 0x000c021d,

        // <summary>
        //     AC Select All Usage.
        // </summary>
        [Description("AC Select All")]
        ACSelectAll = 0x000c021e,

        // <summary>
        //     AC Find Usage.
        // </summary>
        [Description("AC Find")]
        ACFind = 0x000c021f,

        // <summary>
        //     AC Find and Replace Usage.
        // </summary>
        [Description("AC Find and Replace")]
        ACFindAndReplace = 0x000c0220,

        // <summary>
        //     AC Search Usage.
        // </summary>
        [Description("AC Search")]
        ACSearch = 0x000c0221,

        // <summary>
        //     AC Go To Usage.
        // </summary>
        [Description("AC Go To")]
        ACGoTo = 0x000c0222,

        // <summary>
        //     AC Home Usage.
        // </summary>
        [Description("AC Home")]
        ACHome = 0x000c0223,

        // <summary>
        //     AC Back Usage.
        // </summary>
        [Description("AC Back")]
        ACBack = 0x000c0224,

        // <summary>
        //     AC Forward Usage.
        // </summary>
        [Description("AC Forward")]
        ACForward = 0x000c0225,

        // <summary>
        //     AC Stop Usage.
        // </summary>
        [Description("AC Stop")]
        ACStop = 0x000c0226,

        // <summary>
        //     AC Refresh Usage.
        // </summary>
        [Description("AC Refresh")]
        ACRefresh = 0x000c0227,

        // <summary>
        //     AC Previous Link Usage.
        // </summary>
        [Description("AC Previous Link")]
        ACPreviousLink = 0x000c0228,

        // <summary>
        //     AC Next Link Usage.
        // </summary>
        [Description("AC Next Link")]
        ACNextLink = 0x000c0229,

        // <summary>
        //     AC Bookmarks Usage.
        // </summary>
        [Description("AC Bookmarks")]
        ACBookmarks = 0x000c022a,

        // <summary>
        //     AC History Usage.
        // </summary>
        [Description("AC History")]
        ACHistory = 0x000c022b,

        // <summary>
        //     AC Subscriptions Usage.
        // </summary>
        [Description("AC Subscriptions")]
        ACSubscriptions = 0x000c022c,

        // <summary>
        //     AC Zoom In Usage.
        // </summary>
        [Description("AC Zoom In")]
        ACZoomIn = 0x000c022d,

        // <summary>
        //     AC Zoom Out Usage.
        // </summary>
        [Description("AC Zoom Out")]
        ACZoomOut = 0x000c022e,

        // <summary>
        //     AC Zoom Usage.
        // </summary>
        [Description("AC Zoom")]
        ACZoom = 0x000c022f,

        // <summary>
        //     AC Full Screen View Usage.
        // </summary>
        [Description("AC Full Screen View")]
        ACFullScreenView = 0x000c0230,

        // <summary>
        //     AC Normal View Usage.
        // </summary>
        [Description("AC Normal View")]
        ACNormalView = 0x000c0231,

        // <summary>
        //     AC View Toggle Usage.
        // </summary>
        [Description("AC View Toggle")]
        ACViewToggle = 0x000c0232,

        // <summary>
        //     AC Scroll Up Usage.
        // </summary>
        [Description("AC Scroll Up")]
        ACScrollUp = 0x000c0233,

        // <summary>
        //     AC Scroll Down Usage.
        // </summary>
        [Description("AC Scroll Down")]
        ACScrollDown = 0x000c0234,

        // <summary>
        //     AC Scroll Usage.
        // </summary>
        [Description("AC Scroll")]
        ACScroll = 0x000c0235,

        // <summary>
        //     AC Pan Left Usage.
        // </summary>
        [Description("AC Pan Left")]
        ACPanLeft = 0x000c0236,

        // <summary>
        //     AC Pan Right Usage.
        // </summary>
        [Description("AC Pan Right")]
        ACPanRight = 0x000c0237,

        // <summary>
        //     AC Pan Usage.
        // </summary>
        [Description("AC Pan")]
        ACPan = 0x000c0238,

        // <summary>
        //     AC New Window Usage.
        // </summary>
        [Description("AC New Window")]
        ACNewWindow = 0x000c0239,

        // <summary>
        //     AC Tile Horizontally Usage.
        // </summary>
        [Description("AC Tile Horizontally")]
        ACTileHorizontally = 0x000c023a,

        // <summary>
        //     AC Tile Vertically Usage.
        // </summary>
        [Description("AC Tile Vertically")]
        ACTileVertically = 0x000c023b,

        // <summary>
        //     AC Format Usage.
        // </summary>
        [Description("AC Format")]
        ACFormat = 0x000c023c,

        // <summary>
        //     AC Edit Usage.
        // </summary>
        [Description("AC Edit")]
        ACEdit = 0x000c023d,

        // <summary>
        //     AC Bold Usage.
        // </summary>
        [Description("AC Bold")]
        ACBold = 0x000c023e,

        // <summary>
        //     AC Italics Usage.
        // </summary>
        [Description("AC Italics")]
        ACItalics = 0x000c023f,

        // <summary>
        //     AC Underline Usage.
        // </summary>
        [Description("AC Underline")]
        ACUnderline = 0x000c0240,

        // <summary>
        //     AC Strikethrough Usage.
        // </summary>
        [Description("AC Strikethrough")]
        ACStrikethrough = 0x000c0241,

        // <summary>
        //     AC Subscript Usage.
        // </summary>
        [Description("AC Subscript")]
        ACSubscript = 0x000c0242,

        // <summary>
        //     AC Superscript Usage.
        // </summary>
        [Description("AC Superscript")]
        ACSuperscript = 0x000c0243,

        // <summary>
        //     AC All Caps Usage.
        // </summary>
        [Description("AC All Caps")]
        ACAllCaps = 0x000c0244,

        // <summary>
        //     AC Rotate Usage.
        // </summary>
        [Description("AC Rotate")]
        ACRotate = 0x000c0245,

        // <summary>
        //     AC Resize Usage.
        // </summary>
        [Description("AC Resize")]
        ACResize = 0x000c0246,

        // <summary>
        //     AC Flip Horizontal Usage.
        // </summary>
        [Description("AC Flip Horizontal")]
        ACFlipHorizontal = 0x000c0247,

        // <summary>
        //     AC Flip Vertical Usage.
        // </summary>
        [Description("AC Flip Vertical")]
        ACFlipVertical = 0x000c0248,

        // <summary>
        //     AC Mirror Horizontal Usage.
        // </summary>
        [Description("AC Mirror Horizontal")]
        ACMirrorHorizontal = 0x000c0249,

        // <summary>
        //     AC Mirror Vertical Usage.
        // </summary>
        [Description("AC Mirror Vertical")]
        ACMirrorVertical = 0x000c024a,

        // <summary>
        //     AC Font Select Usage.
        // </summary>
        [Description("AC Font Select")]
        ACFontSelect = 0x000c024b,

        // <summary>
        //     AC Font Color Usage.
        // </summary>
        [Description("AC Font Color")]
        ACFontColor = 0x000c024c,

        // <summary>
        //     AC Font Size Usage.
        // </summary>
        [Description("AC Font Size")]
        ACFontSize = 0x000c024d,

        // <summary>
        //     AC Justify Left Usage.
        // </summary>
        [Description("AC Justify Left")]
        ACJustifyLeft = 0x000c024e,

        // <summary>
        //     AC Justify Center H Usage.
        // </summary>
        [Description("AC Justify Center H")]
        ACJustifyCenterH = 0x000c024f,

        // <summary>
        //     AC Justify Right Usage.
        // </summary>
        [Description("AC Justify Right")]
        ACJustifyRight = 0x000c0250,

        // <summary>
        //     AC Justify Block H Usage.
        // </summary>
        [Description("AC Justify Block H")]
        ACJustifyBlockH = 0x000c0251,

        // <summary>
        //     AC Justify Top Usage.
        // </summary>
        [Description("AC Justify Top")]
        ACJustifyTop = 0x000c0252,

        // <summary>
        //     AC Justify Center V Usage.
        // </summary>
        [Description("AC Justify Center V")]
        ACJustifyCenterV = 0x000c0253,

        // <summary>
        //     AC Justify Bottom Usage.
        // </summary>
        [Description("AC Justify Bottom")]
        ACJustifyBottom = 0x000c0254,

        // <summary>
        //     AC Justify Block V Usage.
        // </summary>
        [Description("AC Justify Block V")]
        ACJustifyBlockV = 0x000c0255,

        // <summary>
        //     AC Indent Decrease Usage.
        // </summary>
        [Description("AC Indent Decrease")]
        ACIndentDecrease = 0x000c0256,

        // <summary>
        //     AC Indent Increase Usage.
        // </summary>
        [Description("AC Indent Increase")]
        ACIndentIncrease = 0x000c0257,

        // <summary>
        //     AC Numbered List Usage.
        // </summary>
        [Description("AC Numbered List")]
        ACNumberedList = 0x000c0258,

        // <summary>
        //     AC Restart Numbering Usage.
        // </summary>
        [Description("AC Restart Numbering")]
        ACRestartNumbering = 0x000c0259,

        // <summary>
        //     AC Bulleted List Usage.
        // </summary>
        [Description("AC Bulleted List")]
        ACBulletedList = 0x000c025a,

        // <summary>
        //     AC Promote Usage.
        // </summary>
        [Description("AC Promote")]
        ACPromote = 0x000c025b,

        // <summary>
        //     AC Demote Usage.
        // </summary>
        [Description("AC Demote")]
        ACDemote = 0x000c025c,

        // <summary>
        //     AC Yes Usage.
        // </summary>
        [Description("AC Yes")]
        ACYes = 0x000c025d,

        // <summary>
        //     AC No Usage.
        // </summary>
        [Description("AC No")]
        ACNo = 0x000c025e,

        // <summary>
        //     AC Cancel Usage.
        // </summary>
        [Description("AC Cancel")]
        ACCancel = 0x000c025f,

        // <summary>
        //     AC Catalog Usage.
        // </summary>
        [Description("AC Catalog")]
        ACCatalog = 0x000c0260,

        // <summary>
        //     AC Buy/Checkout Usage.
        // </summary>
        [Description("AC Buy/Checkout")]
        ACBuyCheckout = 0x000c0261,

        // <summary>
        //     AC Add to Cart Usage.
        // </summary>
        [Description("AC Add to Cart")]
        ACAddToCart = 0x000c0262,

        // <summary>
        //     AC Expand Usage.
        // </summary>
        [Description("AC Expand")]
        ACExpand = 0x000c0263,

        // <summary>
        //     AC Expand All Usage.
        // </summary>
        [Description("AC Expand All")]
        ACExpandAll = 0x000c0264,

        // <summary>
        //     AC Collapse Usage.
        // </summary>
        [Description("AC Collapse")]
        ACCollapse = 0x000c0265,

        // <summary>
        //     AC Collapse All Usage.
        // </summary>
        [Description("AC Collapse All")]
        ACCollapseAll = 0x000c0266,

        // <summary>
        //     AC Print Preview Usage.
        // </summary>
        [Description("AC Print Preview")]
        ACPrintPreview = 0x000c0267,

        // <summary>
        //     AC Paste Special Usage.
        // </summary>
        [Description("AC Paste Special")]
        ACPasteSpecial = 0x000c0268,

        // <summary>
        //     AC Insert Mode Usage.
        // </summary>
        [Description("AC Insert Mode")]
        ACInsertMode = 0x000c0269,

        // <summary>
        //     AC Delete Usage.
        // </summary>
        [Description("AC Delete")]
        ACDelete = 0x000c026a,

        // <summary>
        //     AC Lock Usage.
        // </summary>
        [Description("AC Lock")]
        ACLock = 0x000c026b,

        // <summary>
        //     AC Unlock Usage.
        // </summary>
        [Description("AC Unlock")]
        ACUnlock = 0x000c026c,

        // <summary>
        //     AC Protect Usage.
        // </summary>
        [Description("AC Protect")]
        ACProtect = 0x000c026d,

        // <summary>
        //     AC Unprotect Usage.
        // </summary>
        [Description("AC Unprotect")]
        ACUnprotect = 0x000c026e,

        // <summary>
        //     AC Attach Comment Usage.
        // </summary>
        [Description("AC Attach Comment")]
        ACAttachComment = 0x000c026f,

        // <summary>
        //     AC Delete Comment Usage.
        // </summary>
        [Description("AC Delete Comment")]
        ACDeleteComment = 0x000c0270,

        // <summary>
        //     AC View Comment Usage.
        // </summary>
        [Description("AC View Comment")]
        ACViewComment = 0x000c0271,

        // <summary>
        //     AC Select Word Usage.
        // </summary>
        [Description("AC Select Word")]
        ACSelectWord = 0x000c0272,

        // <summary>
        //     AC Select Sentence Usage.
        // </summary>
        [Description("AC Select Sentence")]
        ACSelectSentence = 0x000c0273,

        // <summary>
        //     AC Select Paragraph Usage.
        // </summary>
        [Description("AC Select Paragraph")]
        ACSelectParagraph = 0x000c0274,

        // <summary>
        //     AC Select Column Usage.
        // </summary>
        [Description("AC Select Column")]
        ACSelectColumn = 0x000c0275,

        // <summary>
        //     AC Select Row Usage.
        // </summary>
        [Description("AC Select Row")]
        ACSelectRow = 0x000c0276,

        // <summary>
        //     AC Select Table Usage.
        // </summary>
        [Description("AC Select Table")]
        ACSelectTable = 0x000c0277,

        // <summary>
        //     AC Select Object Usage.
        // </summary>
        [Description("AC Select Object")]
        ACSelectObject = 0x000c0278,

        // <summary>
        //     AC Redo/Repeat Usage.
        // </summary>
        [Description("AC Redo/Repeat")]
        ACRedoRepeat = 0x000c0279,

        // <summary>
        //     AC Sort Usage.
        // </summary>
        [Description("AC Sort")]
        ACSort = 0x000c027a,

        // <summary>
        //     AC Sort Ascending Usage.
        // </summary>
        [Description("AC Sort Ascending")]
        ACSortAscending = 0x000c027b,

        // <summary>
        //     AC Sort Descending Usage.
        // </summary>
        [Description("AC Sort Descending")]
        ACSortDescending = 0x000c027c,

        // <summary>
        //     AC Filter Usage.
        // </summary>
        [Description("AC Filter")]
        ACFilter = 0x000c027d,

        // <summary>
        //     AC Set Clock Usage.
        // </summary>
        [Description("AC Set Clock")]
        ACSetClock = 0x000c027e,

        // <summary>
        //     AC View Clock Usage.
        // </summary>
        [Description("AC View Clock")]
        ACViewClock = 0x000c027f,

        // <summary>
        //     AC Select Time Zone Usage.
        // </summary>
        [Description("AC Select Time Zone")]
        ACSelectTimeZone = 0x000c0280,

        // <summary>
        //     AC Edit Time Zones Usage.
        // </summary>
        [Description("AC Edit Time Zones")]
        ACEditTimeZones = 0x000c0281,

        // <summary>
        //     AC Set Alarm Usage.
        // </summary>
        [Description("AC Set Alarm")]
        ACSetAlarm = 0x000c0282,

        // <summary>
        //     AC Clear Alarm Usage.
        // </summary>
        [Description("AC Clear Alarm")]
        ACClearAlarm = 0x000c0283,

        // <summary>
        //     AC Snooze Alarm Usage.
        // </summary>
        [Description("AC Snooze Alarm")]
        ACSnoozeAlarm = 0x000c0284,

        // <summary>
        //     AC Reset Alarm Usage.
        // </summary>
        [Description("AC Reset Alarm")]
        ACResetAlarm = 0x000c0285,

        // <summary>
        //     AC Synchronize Usage.
        // </summary>
        [Description("AC Synchronize")]
        ACSynchronize = 0x000c0286,

        // <summary>
        //     AC Send/Receive Usage.
        // </summary>
        [Description("AC Send/Receive")]
        ACSendReceive = 0x000c0287,

        // <summary>
        //     AC Send To Usage.
        // </summary>
        [Description("AC Send To")]
        ACSendTo = 0x000c0288,

        // <summary>
        //     AC Reply Usage.
        // </summary>
        [Description("AC Reply")]
        ACReply = 0x000c0289,

        // <summary>
        //     AC Reply All Usage.
        // </summary>
        [Description("AC Reply All")]
        ACReplyAll = 0x000c028a,

        // <summary>
        //     AC Forward Msg Usage.
        // </summary>
        [Description("AC Forward Msg")]
        ACForwardMsg = 0x000c028b,

        // <summary>
        //     AC Send Usage.
        // </summary>
        [Description("AC Send")]
        ACSend = 0x000c028c,

        // <summary>
        //     AC Attach File Usage.
        // </summary>
        [Description("AC Attach File")]
        ACAttachFile = 0x000c028d,

        // <summary>
        //     AC Upload Usage.
        // </summary>
        [Description("AC Upload")]
        ACUpload = 0x000c028e,

        // <summary>
        //     AC Download (Save Target As) Usage.
        // </summary>
        [Description("AC Download (Save Target As)")]
        ACDownloadSaveTargetAs = 0x000c028f,

        // <summary>
        //     AC Set Borders Usage.
        // </summary>
        [Description("AC Set Borders")]
        ACSetBorders = 0x000c0290,

        // <summary>
        //     AC Insert Row Usage.
        // </summary>
        [Description("AC Insert Row")]
        ACInsertRow = 0x000c0291,

        // <summary>
        //     AC Insert Column Usage.
        // </summary>
        [Description("AC Insert Column")]
        ACInsertColumn = 0x000c0292,

        // <summary>
        //     AC Insert File Usage.
        // </summary>
        [Description("AC Insert File")]
        ACInsertFile = 0x000c0293,

        // <summary>
        //     AC Insert Picture Usage.
        // </summary>
        [Description("AC Insert Picture")]
        ACInsertPicture = 0x000c0294,

        // <summary>
        //     AC Insert Object Usage.
        // </summary>
        [Description("AC Insert Object")]
        ACInsertObject = 0x000c0295,

        // <summary>
        //     AC Insert Symbol Usage.
        // </summary>
        [Description("AC Insert Symbol")]
        ACInsertSymbol = 0x000c0296,

        // <summary>
        //     AC Save and Close Usage.
        // </summary>
        [Description("AC Save and Close")]
        ACSaveAndClose = 0x000c0297,

        // <summary>
        //     AC Rename Usage.
        // </summary>
        [Description("AC Rename")]
        ACRename = 0x000c0298,

        // <summary>
        //     AC Merge Usage.
        // </summary>
        [Description("AC Merge")]
        ACMerge = 0x000c0299,

        // <summary>
        //     AC Split Usage.
        // </summary>
        [Description("AC Split")]
        ACSplit = 0x000c029a,

        // <summary>
        //     AC Disribute Horizontally Usage.
        // </summary>
        [Description("AC Disribute Horizontally")]
        ACDisributeHorizontally = 0x000c029b,

        // <summary>
        //     AC Distribute Vertically Usage.
        // </summary>
        [Description("AC Distribute Vertically")]
        ACDistributeVertically = 0x000c029c,

        // <summary>
        //     AC Next Keyboard Layout Select Usage.
        // </summary>
        [Description("AC Next Keyboard Layout Select")]
        ACNextKeyboardLayoutSelect = 0x000c029d,

        // <summary>
        //     AC Navigation Guidance Usage.
        // </summary>
        [Description("AC Navigation Guidance")]
        ACNavigationGuidance = 0x000c029e,

        // <summary>
        //     AC Desktop Show All Windows Usage.
        // </summary>
        [Description("AC Desktop Show All Windows")]
        ACDesktopShowAllWindows = 0x000c029f,

        // <summary>
        //     AC Soft Key Left Usage.
        // </summary>
        [Description("AC Soft Key Left")]
        ACSoftKeyLeft = 0x000c02a0,

        // <summary>
        //     AC Soft Key Right Usage.
        // </summary>
        [Description("AC Soft Key Right")]
        ACSoftKeyRight = 0x000c02a1,

        // <summary>
        //     AC Desktop Show All Applications Usage.
        // </summary>
        [Description("AC Desktop Show All Applications")]
        ACDesktopShowAllApplications = 0x000c02a2,

        // <summary>
        //     AC Idle Keep Alive Usage.
        // </summary>
        [Description("AC Idle Keep Alive")]
        ACIdleKeepAlive = 0x000c02b0,

        // <summary>
        //     Extended Keyboard Attributes Collection Usage.
        // </summary>
        [Description("Extended Keyboard Attributes Collection")]
        ExtendedKeyboardAttributesCollection = 0x000c02c0,

        // <summary>
        //     Keyboard Form Factor Usage.
        // </summary>
        [Description("Keyboard Form Factor")]
        KeyboardFormFactor = 0x000c02c1,

        // <summary>
        //     Keyboard Key Type Usage.
        // </summary>
        [Description("Keyboard Key Type")]
        KeyboardKeyType = 0x000c02c2,

        // <summary>
        //     Keyboard Physical Layout Usage.
        // </summary>
        [Description("Keyboard Physical Layout")]
        KeyboardPhysicalLayout = 0x000c02c3,

        // <summary>
        //     Vendor‐Specific Keyboard Physical Layout Usage.
        // </summary>
        [Description("Vendor‐Specific Keyboard Physical Layout")]
        VendorSpecificKeyboardPhysicalLayout = 0x000c02c4,

        // <summary>
        //     Keyboard IETF Language Tag Index Usage.
        // </summary>
        [Description("Keyboard IETF Language Tag Index")]
        KeyboardIETFLanguageTagIndex = 0x000c02c5,

        // <summary>
        //     Implemented Keyboard Input Assist Controls Usage.
        // </summary>
        [Description("Implemented Keyboard Input Assist Controls")]
        ImplementedKeyboardInputAssistControls = 0x000c02c6,

        // <summary>
        //     Keyboard Input Assist Previous Usage.
        // </summary>
        [Description("Keyboard Input Assist Previous")]
        KeyboardInputAssistPrevious = 0x000c02c7,

        // <summary>
        //     Keyboard Input Assist Next Usage.
        // </summary>
        [Description("Keyboard Input Assist Next")]
        KeyboardInputAssistNext = 0x000c02c8,

        // <summary>
        //     Keyboard Input Assist Previous Group Usage.
        // </summary>
        [Description("Keyboard Input Assist Previous Group")]
        KeyboardInputAssistPreviousGroup = 0x000c02c9,

        // <summary>
        //     Keyboard Input Assist Next Group Usage.
        // </summary>
        [Description("Keyboard Input Assist Next Group")]
        KeyboardInputAssistNextGroup = 0x000c02ca,

        // <summary>
        //     Keyboard Input Assist Accept Usage.
        // </summary>
        [Description("Keyboard Input Assist Accept")]
        KeyboardInputAssistAccept = 0x000c02cb,

        // <summary>
        //     Keyboard Input Assist Cancel Usage.
        // </summary>
        [Description("Keyboard Input Assist Cancel")]
        KeyboardInputAssistCancel = 0x000c02cc,

        // <summary>
        //     Privacy Screen Toggle Usage.
        // </summary>
        [Description("Privacy Screen Toggle")]
        PrivacyScreenToggle = 0x000c02d0,

        // <summary>
        //     Privacy Screen Level Decrement Usage.
        // </summary>
        [Description("Privacy Screen Level Decrement")]
        PrivacyScreenLevelDecrement = 0x000c02d1,

        // <summary>
        //     Privacy Screen Level Increment Usage.
        // </summary>
        [Description("Privacy Screen Level Increment")]
        PrivacyScreenLevelIncrement = 0x000c02d2,

        // <summary>
        //     Privacy Screen Level Minimum Usage.
        // </summary>
        [Description("Privacy Screen Level Minimum")]
        PrivacyScreenLevelMinimum = 0x000c02d3,

        // <summary>
        //     Privacy Screen Level Maximum Usage.
        // </summary>
        [Description("Privacy Screen Level Maximum")]
        PrivacyScreenLevelMaximum = 0x000c02d4,

        // <summary>
        //     Contact Edited Usage.
        // </summary>
        [Description("Contact Edited")]
        ContactEdited = 0x000c0500,

        // <summary>
        //     Contact Added Usage.
        // </summary>
        [Description("Contact Added")]
        ContactAdded = 0x000c0501,

        // <summary>
        //     Contact Record Active Usage.
        // </summary>
        [Description("Contact Record Active")]
        ContactRecordActive = 0x000c0502,

        // <summary>
        //     Contact Index Usage.
        // </summary>
        [Description("Contact Index")]
        ContactIndex = 0x000c0503,

        // <summary>
        //     Contact Nickname Usage.
        // </summary>
        [Description("Contact Nickname")]
        ContactNickname = 0x000c0504,

        // <summary>
        //     Contact First Name Usage.
        // </summary>
        [Description("Contact First Name")]
        ContactFirstName = 0x000c0505,

        // <summary>
        //     Contact Last Name Usage.
        // </summary>
        [Description("Contact Last Name")]
        ContactLastName = 0x000c0506,

        // <summary>
        //     Contact Full Name Usage.
        // </summary>
        [Description("Contact Full Name")]
        ContactFullName = 0x000c0507,

        // <summary>
        //     Contact Phone Number Personal Usage.
        // </summary>
        [Description("Contact Phone Number Personal")]
        ContactPhoneNumberPersonal = 0x000c0508,

        // <summary>
        //     Contact Phone Number Business Usage.
        // </summary>
        [Description("Contact Phone Number Business")]
        ContactPhoneNumberBusiness = 0x000c0509,

        // <summary>
        //     Contact Phone Number Mobile Usage.
        // </summary>
        [Description("Contact Phone Number Mobile")]
        ContactPhoneNumberMobile = 0x000c050a,

        // <summary>
        //     Contact Phone Number Pager Usage.
        // </summary>
        [Description("Contact Phone Number Pager")]
        ContactPhoneNumberPager = 0x000c050b,

        // <summary>
        //     Contact Phone Number Fax Usage.
        // </summary>
        [Description("Contact Phone Number Fax")]
        ContactPhoneNumberFax = 0x000c050c,

        // <summary>
        //     Contact Phone Number Other Usage.
        // </summary>
        [Description("Contact Phone Number Other")]
        ContactPhoneNumberOther = 0x000c050d,

        // <summary>
        //     Contact Email Personal Usage.
        // </summary>
        [Description("Contact Email Personal")]
        ContactEmailPersonal = 0x000c050e,

        // <summary>
        //     Contact Email Business Usage.
        // </summary>
        [Description("Contact Email Business")]
        ContactEmailBusiness = 0x000c050f,

        // <summary>
        //     Contact Email Other Usage.
        // </summary>
        [Description("Contact Email Other")]
        ContactEmailOther = 0x000c0510,

        // <summary>
        //     Contact Email Main Usage.
        // </summary>
        [Description("Contact Email Main")]
        ContactEmailMain = 0x000c0511,

        // <summary>
        //     Contact Speed Dial Number Usage.
        // </summary>
        [Description("Contact Speed Dial Number")]
        ContactSpeedDialNumber = 0x000c0512,

        // <summary>
        //     Contact Status Flag Usage.
        // </summary>
        [Description("Contact Status Flag")]
        ContactStatusFlag = 0x000c0513,

        // <summary>
        //     Contact Misc. Usage.
        // </summary>
        [Description("Contact Misc.")]
        ContactMisc = 0x000c0514
    }
}
