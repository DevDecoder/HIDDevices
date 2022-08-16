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
    //     Barcode Scanner Usage Page.
    // </summary>
    [Description("Barcode Scanner Usage Page")]
    public enum BarcodeScannerPage : uint
    {
        // <summary>
        //     Undefined Usage.
        // </summary>
        [Description("Undefined")]
        Undefined = 0x008c0000,

        // <summary>
        //     Barcode Badge Reader Usage.
        // </summary>
        [Description("Barcode Badge Reader")]
        BarcodeBadgeReader = 0x008c0001,

        // <summary>
        //     Barcode Scanner Usage.
        // </summary>
        [Description("Barcode Scanner")]
        BarcodeScanner = 0x008c0002,

        // <summary>
        //     Dumb Bar Code Scanner Usage.
        // </summary>
        [Description("Dumb Bar Code Scanner")]
        DumbBarCodeScanner = 0x008c0003,

        // <summary>
        //     Cordless Scanner Base Usage.
        // </summary>
        [Description("Cordless Scanner Base")]
        CordlessScannerBase = 0x008c0004,

        // <summary>
        //     Bar Code Scanner Cradle Usage.
        // </summary>
        [Description("Bar Code Scanner Cradle")]
        BarCodeScannerCradle = 0x008c0005,

        // <summary>
        //     Attribute Report Usage.
        // </summary>
        [Description("Attribute Report")]
        AttributeReport = 0x008c0010,

        // <summary>
        //     Settings Report Usage.
        // </summary>
        [Description("Settings Report")]
        SettingsReport = 0x008c0011,

        // <summary>
        //     Scanned Data Report Usage.
        // </summary>
        [Description("Scanned Data Report")]
        ScannedDataReport = 0x008c0012,

        // <summary>
        //     Raw Scanned Data Report Usage.
        // </summary>
        [Description("Raw Scanned Data Report")]
        RawScannedDataReport = 0x008c0013,

        // <summary>
        //     Trigger Report Usage.
        // </summary>
        [Description("Trigger Report")]
        TriggerReport = 0x008c0014,

        // <summary>
        //     Status Report Usage.
        // </summary>
        [Description("Status Report")]
        StatusReport = 0x008c0015,

        // <summary>
        //     UPC/EAN Control Report Usage.
        // </summary>
        [Description("UPC/EAN Control Report")]
        UPCEANControlReport = 0x008c0016,

        // <summary>
        //     EAN 2/3 Label Control Report Usage.
        // </summary>
        [Description("EAN 2/3 Label Control Report")]
        EAN23LabelControlReport = 0x008c0017,

        // <summary>
        //     Code 39 Control Report Usage.
        // </summary>
        [Description("Code 39 Control Report")]
        Code39ControlReport = 0x008c0018,

        // <summary>
        //     Interleaved 2 of 5 Control Report Usage.
        // </summary>
        [Description("Interleaved 2 of 5 Control Report")]
        Interleaved2Of5ControlReport = 0x008c0019,

        // <summary>
        //     Standard 2 of 5 Control Report Usage.
        // </summary>
        [Description("Standard 2 of 5 Control Report")]
        Standard2Of5ControlReport = 0x008c001a,

        // <summary>
        //     MSI Plessey Control Report Usage.
        // </summary>
        [Description("MSI Plessey Control Report")]
        MSIPlesseyControlReport = 0x008c001b,

        // <summary>
        //     Codabar Control Report Usage.
        // </summary>
        [Description("Codabar Control Report")]
        CodabarControlReport = 0x008c001c,

        // <summary>
        //     Code 128 Control Report Usage.
        // </summary>
        [Description("Code 128 Control Report")]
        Code128ControlReport = 0x008c001d,

        // <summary>
        //     Misc 1D Control Report Usage.
        // </summary>
        [Description("Misc 1D Control Report")]
        Misc1DControlReport = 0x008c001e,

        // <summary>
        //     2D Control Report Usage.
        // </summary>
        [Description("2D Control Report")]
        _2DControlReport = 0x008c001f,

        // <summary>
        //     Aiming/Pointer Mode Usage.
        // </summary>
        [Description("Aiming/Pointer Mode")]
        AimingPointerMode = 0x008c0030,

        // <summary>
        //     Bar Code Present Sensor Usage.
        // </summary>
        [Description("Bar Code Present Sensor")]
        BarCodePresentSensor = 0x008c0031,

        // <summary>
        //     Class 1A Laser Usage.
        // </summary>
        [Description("Class 1A Laser")]
        Class1ALaser = 0x008c0032,

        // <summary>
        //     Class 2 Laser Usage.
        // </summary>
        [Description("Class 2 Laser")]
        Class2Laser = 0x008c0033,

        // <summary>
        //     Heater Present Usage.
        // </summary>
        [Description("Heater Present")]
        HeaterPresent = 0x008c0034,

        // <summary>
        //     Contact Scanner Usage.
        // </summary>
        [Description("Contact Scanner")]
        ContactScanner = 0x008c0035,

        // <summary>
        //     Electronic Article Surveillance Notification Usage.
        // </summary>
        [Description("Electronic Article Surveillance Notification")]
        ElectronicArticleSurveillanceNotification = 0x008c0036,

        // <summary>
        //     Constant Electronic Article Surveillance Usage.
        // </summary>
        [Description("Constant Electronic Article Surveillance")]
        ConstantElectronicArticleSurveillance = 0x008c0037,

        // <summary>
        //     Error Indication Usage.
        // </summary>
        [Description("Error Indication")]
        ErrorIndication = 0x008c0038,

        // <summary>
        //     Fixed Beeper Usage.
        // </summary>
        [Description("Fixed Beeper")]
        FixedBeeper = 0x008c0039,

        // <summary>
        //     Good Decode Indication Usage.
        // </summary>
        [Description("Good Decode Indication")]
        GoodDecodeIndication = 0x008c003a,

        // <summary>
        //     Hands Free Scanning Usage.
        // </summary>
        [Description("Hands Free Scanning")]
        HandsFreeScanning = 0x008c003b,

        // <summary>
        //     Intrinsically Safe Usage.
        // </summary>
        [Description("Intrinsically Safe")]
        IntrinsicallySafe = 0x008c003c,

        // <summary>
        //     Klasse Eins Laser Usage.
        // </summary>
        [Description("Klasse Eins Laser")]
        KlasseEinsLaser = 0x008c003d,

        // <summary>
        //     Long Range Scanner Usage.
        // </summary>
        [Description("Long Range Scanner")]
        LongRangeScanner = 0x008c003e,

        // <summary>
        //     Mirror Speed Control Usage.
        // </summary>
        [Description("Mirror Speed Control")]
        MirrorSpeedControl = 0x008c003f,

        // <summary>
        //     Not On File Indication Usage.
        // </summary>
        [Description("Not On File Indication")]
        NotOnFileIndication = 0x008c0040,

        // <summary>
        //     Programmable Beeper Usage.
        // </summary>
        [Description("Programmable Beeper")]
        ProgrammableBeeper = 0x008c0041,

        // <summary>
        //     Triggerless Usage.
        // </summary>
        [Description("Triggerless")]
        Triggerless = 0x008c0042,

        // <summary>
        //     Wand Usage.
        // </summary>
        [Description("Wand")]
        Wand = 0x008c0043,

        // <summary>
        //     Water Resistant Usage.
        // </summary>
        [Description("Water Resistant")]
        WaterResistant = 0x008c0044,

        // <summary>
        //     Multi-Range Scanner Usage.
        // </summary>
        [Description("Multi-Range Scanner")]
        MultiRangeScanner = 0x008c0045,

        // <summary>
        //     Proximity Sensor Usage.
        // </summary>
        [Description("Proximity Sensor")]
        ProximitySensor = 0x008c0046,

        // <summary>
        //     Fragment Decoding Usage.
        // </summary>
        [Description("Fragment Decoding")]
        FragmentDecoding = 0x008c004d,

        // <summary>
        //     Scanner Read Confidence Usage.
        // </summary>
        [Description("Scanner Read Confidence")]
        ScannerReadConfidence = 0x008c004e,

        // <summary>
        //     Data Prefix Usage.
        // </summary>
        [Description("Data Prefix")]
        DataPrefix = 0x008c004f,

        // <summary>
        //     Prefix AIMI Usage.
        // </summary>
        [Description("Prefix AIMI")]
        PrefixAIMI = 0x008c0050,

        // <summary>
        //     Prefix None Usage.
        // </summary>
        [Description("Prefix None")]
        PrefixNone = 0x008c0051,

        // <summary>
        //     Prefix Proprietary Usage.
        // </summary>
        [Description("Prefix Proprietary")]
        PrefixProprietary = 0x008c0052,

        // <summary>
        //     Active Time Usage.
        // </summary>
        [Description("Active Time")]
        ActiveTime = 0x008c0055,

        // <summary>
        //     Aiming Laser Pattern Usage.
        // </summary>
        [Description("Aiming Laser Pattern")]
        AimingLaserPattern = 0x008c0056,

        // <summary>
        //     Bar Code Present Usage.
        // </summary>
        [Description("Bar Code Present")]
        BarCodePresent = 0x008c0057,

        // <summary>
        //     Beeper State Usage.
        // </summary>
        [Description("Beeper State")]
        BeeperState = 0x008c0058,

        // <summary>
        //     Laser On Time Usage.
        // </summary>
        [Description("Laser On Time")]
        LaserOnTime = 0x008c0059,

        // <summary>
        //     Laser State Usage.
        // </summary>
        [Description("Laser State")]
        LaserState = 0x008c005a,

        // <summary>
        //     Lockout Time Usage.
        // </summary>
        [Description("Lockout Time")]
        LockoutTime = 0x008c005b,

        // <summary>
        //     Motor State Usage.
        // </summary>
        [Description("Motor State")]
        MotorState = 0x008c005c,

        // <summary>
        //     Motor Timeout Usage.
        // </summary>
        [Description("Motor Timeout")]
        MotorTimeout = 0x008c005d,

        // <summary>
        //     Power On Reset Scanner Usage.
        // </summary>
        [Description("Power On Reset Scanner")]
        PowerOnResetScanner = 0x008c005e,

        // <summary>
        //     Prevent Read of Barcodes Usage.
        // </summary>
        [Description("Prevent Read of Barcodes")]
        PreventReadOfBarcodes = 0x008c005f,

        // <summary>
        //     Initiate Barcode Read Usage.
        // </summary>
        [Description("Initiate Barcode Read")]
        InitiateBarcodeRead = 0x008c0060,

        // <summary>
        //     Trigger State Usage.
        // </summary>
        [Description("Trigger State")]
        TriggerState = 0x008c0061,

        // <summary>
        //     Trigger Mode Usage.
        // </summary>
        [Description("Trigger Mode")]
        TriggerMode = 0x008c0062,

        // <summary>
        //     Trigger Mode Blinking Laser On Usage.
        // </summary>
        [Description("Trigger Mode Blinking Laser On")]
        TriggerModeBlinkingLaserOn = 0x008c0063,

        // <summary>
        //     Trigger Mode Continuous Laser On Usage.
        // </summary>
        [Description("Trigger Mode Continuous Laser On")]
        TriggerModeContinuousLaserOn = 0x008c0064,

        // <summary>
        //     Trigger Mode Laser on while Pulled Usage.
        // </summary>
        [Description("Trigger Mode Laser on while Pulled")]
        TriggerModeLaserOnWhilePulled = 0x008c0065,

        // <summary>
        //     Trigger Mode Laser stays on after release Usage.
        // </summary>
        [Description("Trigger Mode Laser stays on after release")]
        TriggerModeLaserStaysOnAfterRelease = 0x008c0066,

        // <summary>
        //     Commit Parameters to NVM Usage.
        // </summary>
        [Description("Commit Parameters to NVM")]
        CommitParametersToNVM = 0x008c006d,

        // <summary>
        //     Parameter Scanning Usage.
        // </summary>
        [Description("Parameter Scanning")]
        ParameterScanning = 0x008c006e,

        // <summary>
        //     Parameters Changed Usage.
        // </summary>
        [Description("Parameters Changed")]
        ParametersChanged = 0x008c006f,

        // <summary>
        //     Set parameter default values Usage.
        // </summary>
        [Description("Set parameter default values")]
        SetParameterDefaultValues = 0x008c0070,

        // <summary>
        //     Scanner In Cradle Usage.
        // </summary>
        [Description("Scanner In Cradle")]
        ScannerInCradle = 0x008c0075,

        // <summary>
        //     Scanner In Range Usage.
        // </summary>
        [Description("Scanner In Range")]
        ScannerInRange = 0x008c0076,

        // <summary>
        //     Aim Duration Usage.
        // </summary>
        [Description("Aim Duration")]
        AimDuration = 0x008c007a,

        // <summary>
        //     Good Read Lamp Duration Usage.
        // </summary>
        [Description("Good Read Lamp Duration")]
        GoodReadLampDuration = 0x008c007b,

        // <summary>
        //     Good Read Lamp Intensity Usage.
        // </summary>
        [Description("Good Read Lamp Intensity")]
        GoodReadLampIntensity = 0x008c007c,

        // <summary>
        //     Good Read LED Usage.
        // </summary>
        [Description("Good Read LED")]
        GoodReadLED = 0x008c007d,

        // <summary>
        //     Good Read Tone Frequency Usage.
        // </summary>
        [Description("Good Read Tone Frequency")]
        GoodReadToneFrequency = 0x008c007e,

        // <summary>
        //     Good Read Tone Length Usage.
        // </summary>
        [Description("Good Read Tone Length")]
        GoodReadToneLength = 0x008c007f,

        // <summary>
        //     Good Read Tone Volume Usage.
        // </summary>
        [Description("Good Read Tone Volume")]
        GoodReadToneVolume = 0x008c0080,

        // <summary>
        //     No Read Message Usage.
        // </summary>
        [Description("No Read Message")]
        NoReadMessage = 0x008c0082,

        // <summary>
        //     Not on File Volume Usage.
        // </summary>
        [Description("Not on File Volume")]
        NotOnFileVolume = 0x008c0083,

        // <summary>
        //     Powerup Beep Usage.
        // </summary>
        [Description("Powerup Beep")]
        PowerupBeep = 0x008c0084,

        // <summary>
        //     Sound Error Beep Usage.
        // </summary>
        [Description("Sound Error Beep")]
        SoundErrorBeep = 0x008c0085,

        // <summary>
        //     Sound Good Read Beep Usage.
        // </summary>
        [Description("Sound Good Read Beep")]
        SoundGoodReadBeep = 0x008c0086,

        // <summary>
        //     Sound Not On File Beep Usage.
        // </summary>
        [Description("Sound Not On File Beep")]
        SoundNotOnFileBeep = 0x008c0087,

        // <summary>
        //     Good Read When to Write Usage.
        // </summary>
        [Description("Good Read When to Write")]
        GoodReadWhenToWrite = 0x008c0088,

        // <summary>
        //     GRWTI After Decode Usage.
        // </summary>
        [Description("GRWTI After Decode")]
        GRWTIAfterDecode = 0x008c0089,

        // <summary>
        //     GRWTI Beep/Lamp after transmit Usage.
        // </summary>
        [Description("GRWTI Beep/Lamp after transmit")]
        GRWTIBeepLampAfterTransmit = 0x008c008a,

        // <summary>
        //     GRWTI No Beep/Lamp use at all Usage.
        // </summary>
        [Description("GRWTI No Beep/Lamp use at all")]
        GRWTINoBeepLampUseAtAll = 0x008c008b,

        // <summary>
        //     Bookland EAN Usage.
        // </summary>
        [Description("Bookland EAN")]
        BooklandEAN = 0x008c0091,

        // <summary>
        //     Convert EAN 8 to 13 Type Usage.
        // </summary>
        [Description("Convert EAN 8 to 13 Type")]
        ConvertEAN8To13Type = 0x008c0092,

        // <summary>
        //     Convert UPC A to EAN-13 Usage.
        // </summary>
        [Description("Convert UPC A to EAN-13")]
        ConvertUPCAToEAN13 = 0x008c0093,

        // <summary>
        //     Convert UPC-E to A Usage.
        // </summary>
        [Description("Convert UPC-E to A")]
        ConvertUPCEToA = 0x008c0094,

        // <summary>
        //     EAN-13 Usage.
        // </summary>
        [Description("EAN-13")]
        EAN13 = 0x008c0095,

        // <summary>
        //     EAN-8 Usage.
        // </summary>
        [Description("EAN-8")]
        EAN8 = 0x008c0096,

        // <summary>
        //     EAN-99 128 Mandatory Usage.
        // </summary>
        [Description("EAN-99 128 Mandatory")]
        EAN99128Mandatory = 0x008c0097,

        // <summary>
        //     EAN-99 P5/128 Optional Usage.
        // </summary>
        [Description("EAN-99 P5/128 Optional")]
        EAN99P5128Optional = 0x008c0098,

        // <summary>
        //     Enable EAN Two Label Usage.
        // </summary>
        [Description("Enable EAN Two Label")]
        EnableEANTwoLabel = 0x008c0099,

        // <summary>
        //     UPC/EAN Usage.
        // </summary>
        [Description("UPC/EAN")]
        UPCEAN = 0x008c009a,

        // <summary>
        //     UPC/EAN Coupon Code Usage.
        // </summary>
        [Description("UPC/EAN Coupon Code")]
        UPCEANCouponCode = 0x008c009b,

        // <summary>
        //     UPC/EAN Periodicals Usage.
        // </summary>
        [Description("UPC/EAN Periodicals")]
        UPCEANPeriodicals = 0x008c009c,

        // <summary>
        //     UPC-A Usage.
        // </summary>
        [Description("UPC-A")]
        UPCA = 0x008c009d,

        // <summary>
        //     UPC-A with 128 Mandatory Usage.
        // </summary>
        [Description("UPC-A with 128 Mandatory")]
        UPCAWith128Mandatory = 0x008c009e,

        // <summary>
        //     UPC-A with 128 Optional Usage.
        // </summary>
        [Description("UPC-A with 128 Optional")]
        UPCAWith128Optional = 0x008c009f,

        // <summary>
        //     UPC-A with P5 Optional Usage.
        // </summary>
        [Description("UPC-A with P5 Optional")]
        UPCAWithP5Optional = 0x008c00a0,

        // <summary>
        //     UPC-E Usage.
        // </summary>
        [Description("UPC-E")]
        UPCE = 0x008c00a1,

        // <summary>
        //     UPC-E1 Usage.
        // </summary>
        [Description("UPC-E1")]
        UPCE1 = 0x008c00a2,

        // <summary>
        //     Periodical Usage.
        // </summary>
        [Description("Periodical")]
        Periodical = 0x008c00a9,

        // <summary>
        //     Periodical Auto-Discriminate +2 Usage.
        // </summary>
        [Description("Periodical Auto-Discriminate +2")]
        PeriodicalAutoDiscriminate2 = 0x008c00aa,

        // <summary>
        //     Periodical Only Decode with +2 Usage.
        // </summary>
        [Description("Periodical Only Decode with +2")]
        PeriodicalOnlyDecodeWith2 = 0x008c00ab,

        // <summary>
        //     Periodical Ignore +2 Usage.
        // </summary>
        [Description("Periodical Ignore +2")]
        PeriodicalIgnore2 = 0x008c00ac,

        // <summary>
        //     Periodical Auto-Discriminate +5 Usage.
        // </summary>
        [Description("Periodical Auto-Discriminate +5")]
        PeriodicalAutoDiscriminate5 = 0x008c00ad,

        // <summary>
        //     Periodical Only Decode with +5 Usage.
        // </summary>
        [Description("Periodical Only Decode with +5")]
        PeriodicalOnlyDecodeWith5 = 0x008c00ae,

        // <summary>
        //     Periodical Ignore +5 Usage.
        // </summary>
        [Description("Periodical Ignore +5")]
        PeriodicalIgnore5 = 0x008c00af,

        // <summary>
        //     Check Usage.
        // </summary>
        [Description("Check")]
        Check = 0x008c00b0,

        // <summary>
        //     Check Disable Price Usage.
        // </summary>
        [Description("Check Disable Price")]
        CheckDisablePrice = 0x008c00b1,

        // <summary>
        //     Check Enable 4 digit Price Usage.
        // </summary>
        [Description("Check Enable 4 digit Price")]
        CheckEnable4DigitPrice = 0x008c00b2,

        // <summary>
        //     Check Enable 5 digit Price Usage.
        // </summary>
        [Description("Check Enable 5 digit Price")]
        CheckEnable5DigitPrice = 0x008c00b3,

        // <summary>
        //     Check Enable European 4 digit Price Usage.
        // </summary>
        [Description("Check Enable European 4 digit Price")]
        CheckEnableEuropean4DigitPrice = 0x008c00b4,

        // <summary>
        //     Check Enable European 5 digit Price Usage.
        // </summary>
        [Description("Check Enable European 5 digit Price")]
        CheckEnableEuropean5DigitPrice = 0x008c00b5,

        // <summary>
        //     EAN Two Label Usage.
        // </summary>
        [Description("EAN Two Label")]
        EANTwoLabel = 0x008c00b7,

        // <summary>
        //     EAN Three Label Usage.
        // </summary>
        [Description("EAN Three Label")]
        EANThreeLabel = 0x008c00b8,

        // <summary>
        //     EAN 8 Flag Digit 1 Usage.
        // </summary>
        [Description("EAN 8 Flag Digit 1")]
        EAN8FlagDigit1 = 0x008c00b9,

        // <summary>
        //     EAN 8 Flag Digit 2 Usage.
        // </summary>
        [Description("EAN 8 Flag Digit 2")]
        EAN8FlagDigit2 = 0x008c00ba,

        // <summary>
        //     EAN 8 Flag Digit 3 Usage.
        // </summary>
        [Description("EAN 8 Flag Digit 3")]
        EAN8FlagDigit3 = 0x008c00bb,

        // <summary>
        //     EAN 13 Flag Digit 1 Usage.
        // </summary>
        [Description("EAN 13 Flag Digit 1")]
        EAN13FlagDigit1 = 0x008c00bc,

        // <summary>
        //     EAN 13 Flag Digit 2 Usage.
        // </summary>
        [Description("EAN 13 Flag Digit 2")]
        EAN13FlagDigit2 = 0x008c00bd,

        // <summary>
        //     EAN 13 Flag Digit 3 Usage.
        // </summary>
        [Description("EAN 13 Flag Digit 3")]
        EAN13FlagDigit3 = 0x008c00be,

        // <summary>
        //     Add EAN 2/3 Label Definition Usage.
        // </summary>
        [Description("Add EAN 2/3 Label Definition")]
        AddEAN23LabelDefinition = 0x008c00bf,

        // <summary>
        //     Clear all EAN 2/3 Label Definitions Usage.
        // </summary>
        [Description("Clear all EAN 2/3 Label Definitions")]
        ClearAllEAN23LabelDefinitions = 0x008c00c0,

        // <summary>
        //     Codabar Usage.
        // </summary>
        [Description("Codabar")]
        Codabar = 0x008c00c3,

        // <summary>
        //     Code 128 Usage.
        // </summary>
        [Description("Code 128")]
        Code128 = 0x008c00c4,

        // <summary>
        //     Code 39 Usage.
        // </summary>
        [Description("Code 39")]
        Code39 = 0x008c00c7,

        // <summary>
        //     Code 93 Usage.
        // </summary>
        [Description("Code 93")]
        Code93 = 0x008c00c8,

        // <summary>
        //     Full ASCII Conversion Usage.
        // </summary>
        [Description("Full ASCII Conversion")]
        FullASCIIConversion = 0x008c00c9,

        // <summary>
        //     Interleaved 2 of 5 Usage.
        // </summary>
        [Description("Interleaved 2 of 5")]
        Interleaved2Of5 = 0x008c00ca,

        // <summary>
        //     Italian Pharmacy Code Usage.
        // </summary>
        [Description("Italian Pharmacy Code")]
        ItalianPharmacyCode = 0x008c00cb,

        // <summary>
        //     MSI/Plessey Usage.
        // </summary>
        [Description("MSI/Plessey")]
        MSIPlessey = 0x008c00cc,

        // <summary>
        //     Standard 2 of 5 IATA Usage.
        // </summary>
        [Description("Standard 2 of 5 IATA")]
        Standard2Of5IATA = 0x008c00cd,

        // <summary>
        //     Standard 2 of 5 Usage.
        // </summary>
        [Description("Standard 2 of 5")]
        Standard2Of5 = 0x008c00ce,

        // <summary>
        //     Transmit Start/Stop Usage.
        // </summary>
        [Description("Transmit Start/Stop")]
        TransmitStartStop = 0x008c00d3,

        // <summary>
        //     Tri-Optic Usage.
        // </summary>
        [Description("Tri-Optic")]
        TriOptic = 0x008c00d4,

        // <summary>
        //     UCC/EAN-128 Usage.
        // </summary>
        [Description("UCC/EAN-128")]
        UCCEAN128 = 0x008c00d5,

        // <summary>
        //     Check Digit Usage.
        // </summary>
        [Description("Check Digit")]
        CheckDigit = 0x008c00d6,

        // <summary>
        //     Check Digit Disable Usage.
        // </summary>
        [Description("Check Digit Disable")]
        CheckDigitDisable = 0x008c00d7,

        // <summary>
        //     Check Digit Enable Interleaved 2 of 5 OPCC Usage.
        // </summary>
        [Description("Check Digit Enable Interleaved 2 of 5 OPCC")]
        CheckDigitEnableInterleaved2Of5OPCC = 0x008c00d8,

        // <summary>
        //     Check Digit Enable Interleaved 2 of 5 USS Usage.
        // </summary>
        [Description("Check Digit Enable Interleaved 2 of 5 USS")]
        CheckDigitEnableInterleaved2Of5USS = 0x008c00d9,

        // <summary>
        //     Check Digit Enable Standard 2 of 5 OPCC Usage.
        // </summary>
        [Description("Check Digit Enable Standard 2 of 5 OPCC")]
        CheckDigitEnableStandard2Of5OPCC = 0x008c00da,

        // <summary>
        //     Check Digit Enable Standard 2 of 5 USS Usage.
        // </summary>
        [Description("Check Digit Enable Standard 2 of 5 USS")]
        CheckDigitEnableStandard2Of5USS = 0x008c00db,

        // <summary>
        //     Check Digit Enable One MSI Plessey Usage.
        // </summary>
        [Description("Check Digit Enable One MSI Plessey")]
        CheckDigitEnableOneMSIPlessey = 0x008c00dc,

        // <summary>
        //     Check Digit Enable Two MSI Plessey Usage.
        // </summary>
        [Description("Check Digit Enable Two MSI Plessey")]
        CheckDigitEnableTwoMSIPlessey = 0x008c00dd,

        // <summary>
        //     Check Digit Codabar Enable Usage.
        // </summary>
        [Description("Check Digit Codabar Enable")]
        CheckDigitCodabarEnable = 0x008c00de,

        // <summary>
        //     Check Digit Code 39 Enable Usage.
        // </summary>
        [Description("Check Digit Code 39 Enable")]
        CheckDigitCode39Enable = 0x008c00df,

        // <summary>
        //     Transmit Check Digit Usage.
        // </summary>
        [Description("Transmit Check Digit")]
        TransmitCheckDigit = 0x008c00f0,

        // <summary>
        //     Disable Check Digit Transmit Usage.
        // </summary>
        [Description("Disable Check Digit Transmit")]
        DisableCheckDigitTransmit = 0x008c00f1,

        // <summary>
        //     Enable Check Digit Transmit Usage.
        // </summary>
        [Description("Enable Check Digit Transmit")]
        EnableCheckDigitTransmit = 0x008c00f2,

        // <summary>
        //     Symbology Identifier 1 Usage.
        // </summary>
        [Description("Symbology Identifier 1")]
        SymbologyIdentifier1 = 0x008c00fb,

        // <summary>
        //     Symbology Identifier 2 Usage.
        // </summary>
        [Description("Symbology Identifier 2")]
        SymbologyIdentifier2 = 0x008c00fc,

        // <summary>
        //     Symbology Identifier 3 Usage.
        // </summary>
        [Description("Symbology Identifier 3")]
        SymbologyIdentifier3 = 0x008c00fd,

        // <summary>
        //     Decoded Data Usage.
        // </summary>
        [Description("Decoded Data")]
        DecodedData = 0x008c00fe,

        // <summary>
        //     Decode Data Continued Usage.
        // </summary>
        [Description("Decode Data Continued")]
        DecodeDataContinued = 0x008c00ff,

        // <summary>
        //     Bar Space Data Usage.
        // </summary>
        [Description("Bar Space Data")]
        BarSpaceData = 0x008c0100,

        // <summary>
        //     Scanner Data Accuracy Usage.
        // </summary>
        [Description("Scanner Data Accuracy")]
        ScannerDataAccuracy = 0x008c0101,

        // <summary>
        //     Raw Data Polarity Usage.
        // </summary>
        [Description("Raw Data Polarity")]
        RawDataPolarity = 0x008c0102,

        // <summary>
        //     Polarity Inverted Bar Code Usage.
        // </summary>
        [Description("Polarity Inverted Bar Code")]
        PolarityInvertedBarCode = 0x008c0103,

        // <summary>
        //     Polarity Normal Bar Code Usage.
        // </summary>
        [Description("Polarity Normal Bar Code")]
        PolarityNormalBarCode = 0x008c0104,

        // <summary>
        //     Minimum Length to Decode Usage.
        // </summary>
        [Description("Minimum Length to Decode")]
        MinimumLengthToDecode = 0x008c0106,

        // <summary>
        //     Maximum Length to Decode Usage.
        // </summary>
        [Description("Maximum Length to Decode")]
        MaximumLengthToDecode = 0x008c0107,

        // <summary>
        //     Discrete Length to Decode 1 Usage.
        // </summary>
        [Description("Discrete Length to Decode 1")]
        DiscreteLengthToDecode1 = 0x008c0108,

        // <summary>
        //     Discrete Length to Decode 2 Usage.
        // </summary>
        [Description("Discrete Length to Decode 2")]
        DiscreteLengthToDecode2 = 0x008c0109,

        // <summary>
        //     Data Length Method Usage.
        // </summary>
        [Description("Data Length Method")]
        DataLengthMethod = 0x008c010a,

        // <summary>
        //     DL Method Read any Usage.
        // </summary>
        [Description("DL Method Read any")]
        DLMethodReadAny = 0x008c010b,

        // <summary>
        //     DL Method Check in Range Usage.
        // </summary>
        [Description("DL Method Check in Range")]
        DLMethodCheckInRange = 0x008c010c,

        // <summary>
        //     DL Method Check for Discrete Usage.
        // </summary>
        [Description("DL Method Check for Discrete")]
        DLMethodCheckForDiscrete = 0x008c010d,

        // <summary>
        //     Aztec Code Usage.
        // </summary>
        [Description("Aztec Code")]
        AztecCode = 0x008c0110,

        // <summary>
        //     BC412 Usage.
        // </summary>
        [Description("BC412")]
        BC412 = 0x008c0111,

        // <summary>
        //     Channel Code Usage.
        // </summary>
        [Description("Channel Code")]
        ChannelCode = 0x008c0112,

        // <summary>
        //     Code 16 Usage.
        // </summary>
        [Description("Code 16")]
        Code16 = 0x008c0113,

        // <summary>
        //     Code 32 Usage.
        // </summary>
        [Description("Code 32")]
        Code32 = 0x008c0114,

        // <summary>
        //     Code 49 Usage.
        // </summary>
        [Description("Code 49")]
        Code49 = 0x008c0115,

        // <summary>
        //     Code One Usage.
        // </summary>
        [Description("Code One")]
        CodeOne = 0x008c0116,

        // <summary>
        //     Colorcode Usage.
        // </summary>
        [Description("Colorcode")]
        Colorcode = 0x008c0117,

        // <summary>
        //     Data Matrix Usage.
        // </summary>
        [Description("Data Matrix")]
        DataMatrix = 0x008c0118,

        // <summary>
        //     MaxiCode Usage.
        // </summary>
        [Description("MaxiCode")]
        MaxiCode = 0x008c0119,

        // <summary>
        //     MicroPDF Usage.
        // </summary>
        [Description("MicroPDF")]
        MicroPDF = 0x008c011a,

        // <summary>
        //     PDF-417 Usage.
        // </summary>
        [Description("PDF-417")]
        PDF417 = 0x008c011b,

        // <summary>
        //     PosiCode Usage.
        // </summary>
        [Description("PosiCode")]
        PosiCode = 0x008c011c,

        // <summary>
        //     QR Code Usage.
        // </summary>
        [Description("QR Code")]
        QRCode = 0x008c011d,

        // <summary>
        //     SuperCode Usage.
        // </summary>
        [Description("SuperCode")]
        SuperCode = 0x008c011e,

        // <summary>
        //     UltraCode Usage.
        // </summary>
        [Description("UltraCode")]
        UltraCode = 0x008c011f,

        // <summary>
        //     USD-5 (Slug Code) Usage.
        // </summary>
        [Description("USD-5 (Slug Code)")]
        USD5SlugCode = 0x008c0120,

        // <summary>
        //     VeriCode Usage.
        // </summary>
        [Description("VeriCode")]
        VeriCode = 0x008c0121
    }
}
