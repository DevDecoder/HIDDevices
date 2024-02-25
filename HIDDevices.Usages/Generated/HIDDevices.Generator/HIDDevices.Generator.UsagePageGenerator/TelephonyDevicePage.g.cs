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
    //     Telephony Device Usage Page.
    // </summary>
    [Description("Telephony Device Usage Page")]
    public enum TelephonyDevicePage : uint
    {
        // <summary>
        //     Undefined Usage.
        // </summary>
        [Description("Undefined")]
        Undefined = 0x000b0000,

        // <summary>
        //     Phone Usage.
        // </summary>
        [Description("Phone")]
        Phone = 0x000b0001,

        // <summary>
        //     Answering Machine Usage.
        // </summary>
        [Description("Answering Machine")]
        AnsweringMachine = 0x000b0002,

        // <summary>
        //     Message Controls Usage.
        // </summary>
        [Description("Message Controls")]
        MessageControls = 0x000b0003,

        // <summary>
        //     Handset Usage.
        // </summary>
        [Description("Handset")]
        Handset = 0x000b0004,

        // <summary>
        //     Headset Usage.
        // </summary>
        [Description("Headset")]
        Headset = 0x000b0005,

        // <summary>
        //     Telephony Key Pad Usage.
        // </summary>
        [Description("Telephony Key Pad")]
        TelephonyKeyPad = 0x000b0006,

        // <summary>
        //     Programmable Button Usage.
        // </summary>
        [Description("Programmable Button")]
        ProgrammableButton = 0x000b0007,

        // <summary>
        //     Hook Switch Usage.
        // </summary>
        [Description("Hook Switch")]
        HookSwitch = 0x000b0020,

        // <summary>
        //     Flash Usage.
        // </summary>
        [Description("Flash")]
        Flash = 0x000b0021,

        // <summary>
        //     Feature Usage.
        // </summary>
        [Description("Feature")]
        Feature = 0x000b0022,

        // <summary>
        //     Hold Usage.
        // </summary>
        [Description("Hold")]
        Hold = 0x000b0023,

        // <summary>
        //     Redial Usage.
        // </summary>
        [Description("Redial")]
        Redial = 0x000b0024,

        // <summary>
        //     Transfer Usage.
        // </summary>
        [Description("Transfer")]
        Transfer = 0x000b0025,

        // <summary>
        //     Drop Usage.
        // </summary>
        [Description("Drop")]
        Drop = 0x000b0026,

        // <summary>
        //     Park Usage.
        // </summary>
        [Description("Park")]
        Park = 0x000b0027,

        // <summary>
        //     Forward Calls Usage.
        // </summary>
        [Description("Forward Calls")]
        ForwardCalls = 0x000b0028,

        // <summary>
        //     Alternate Function Usage.
        // </summary>
        [Description("Alternate Function")]
        AlternateFunction = 0x000b0029,

        // <summary>
        //     Line Usage.
        // </summary>
        [Description("Line")]
        Line = 0x000b002a,

        // <summary>
        //     Speaker Phone Usage.
        // </summary>
        [Description("Speaker Phone")]
        SpeakerPhone = 0x000b002b,

        // <summary>
        //     Conference Usage.
        // </summary>
        [Description("Conference")]
        Conference = 0x000b002c,

        // <summary>
        //     Ring Enable Usage.
        // </summary>
        [Description("Ring Enable")]
        RingEnable = 0x000b002d,

        // <summary>
        //     Ring Select Usage.
        // </summary>
        [Description("Ring Select")]
        RingSelect = 0x000b002e,

        // <summary>
        //     Phone Mute Usage.
        // </summary>
        [Description("Phone Mute")]
        PhoneMute = 0x000b002f,

        // <summary>
        //     Caller ID Usage.
        // </summary>
        [Description("Caller ID")]
        CallerID = 0x000b0030,

        // <summary>
        //     Send Usage.
        // </summary>
        [Description("Send")]
        Send = 0x000b0031,

        // <summary>
        //     Speed Dial Usage.
        // </summary>
        [Description("Speed Dial")]
        SpeedDial = 0x000b0050,

        // <summary>
        //     Store Number Usage.
        // </summary>
        [Description("Store Number")]
        StoreNumber = 0x000b0051,

        // <summary>
        //     Recall Number Usage.
        // </summary>
        [Description("Recall Number")]
        RecallNumber = 0x000b0052,

        // <summary>
        //     Phone Directory Usage.
        // </summary>
        [Description("Phone Directory")]
        PhoneDirectory = 0x000b0053,

        // <summary>
        //     Voice Mail Usage.
        // </summary>
        [Description("Voice Mail")]
        VoiceMail = 0x000b0070,

        // <summary>
        //     Screen Calls Usage.
        // </summary>
        [Description("Screen Calls")]
        ScreenCalls = 0x000b0071,

        // <summary>
        //     Do Not Disturb Usage.
        // </summary>
        [Description("Do Not Disturb")]
        DoNotDisturb = 0x000b0072,

        // <summary>
        //     Message Usage.
        // </summary>
        [Description("Message")]
        Message = 0x000b0073,

        // <summary>
        //     Answer On/Off Usage.
        // </summary>
        [Description("Answer On/Off")]
        AnswerOnOff = 0x000b0074,

        // <summary>
        //     Inside Dial Tone Usage.
        // </summary>
        [Description("Inside Dial Tone")]
        InsideDialTone = 0x000b0090,

        // <summary>
        //     Outside Dial Tone Usage.
        // </summary>
        [Description("Outside Dial Tone")]
        OutsideDialTone = 0x000b0091,

        // <summary>
        //     Inside Ring Tone Usage.
        // </summary>
        [Description("Inside Ring Tone")]
        InsideRingTone = 0x000b0092,

        // <summary>
        //     Outside Ring Tone Usage.
        // </summary>
        [Description("Outside Ring Tone")]
        OutsideRingTone = 0x000b0093,

        // <summary>
        //     Priority Ring Tone Usage.
        // </summary>
        [Description("Priority Ring Tone")]
        PriorityRingTone = 0x000b0094,

        // <summary>
        //     Inside Ringback Usage.
        // </summary>
        [Description("Inside Ringback")]
        InsideRingback = 0x000b0095,

        // <summary>
        //     Priority Ringback Usage.
        // </summary>
        [Description("Priority Ringback")]
        PriorityRingback = 0x000b0096,

        // <summary>
        //     Line Busy Tone Usage.
        // </summary>
        [Description("Line Busy Tone")]
        LineBusyTone = 0x000b0097,

        // <summary>
        //     Reorder Tone Usage.
        // </summary>
        [Description("Reorder Tone")]
        ReorderTone = 0x000b0098,

        // <summary>
        //     Call Waiting Tone Usage.
        // </summary>
        [Description("Call Waiting Tone")]
        CallWaitingTone = 0x000b0099,

        // <summary>
        //     Confirmation Tone 1 Usage.
        // </summary>
        [Description("Confirmation Tone 1")]
        ConfirmationTone1 = 0x000b009a,

        // <summary>
        //     Confirmation Tone 2 Usage.
        // </summary>
        [Description("Confirmation Tone 2")]
        ConfirmationTone2 = 0x000b009b,

        // <summary>
        //     Tones Off Usage.
        // </summary>
        [Description("Tones Off")]
        TonesOff = 0x000b009c,

        // <summary>
        //     Outside Ringback Usage.
        // </summary>
        [Description("Outside Ringback")]
        OutsideRingback = 0x000b009d,

        // <summary>
        //     Ringer Usage.
        // </summary>
        [Description("Ringer")]
        Ringer = 0x000b009e,

        // <summary>
        //     Phone Key 0 Usage.
        // </summary>
        [Description("Phone Key 0")]
        PhoneKey0 = 0x000b00b0,

        // <summary>
        //     Phone Key 1 Usage.
        // </summary>
        [Description("Phone Key 1")]
        PhoneKey1 = 0x000b00b1,

        // <summary>
        //     Phone Key 2 Usage.
        // </summary>
        [Description("Phone Key 2")]
        PhoneKey2 = 0x000b00b2,

        // <summary>
        //     Phone Key 3 Usage.
        // </summary>
        [Description("Phone Key 3")]
        PhoneKey3 = 0x000b00b3,

        // <summary>
        //     Phone Key 4 Usage.
        // </summary>
        [Description("Phone Key 4")]
        PhoneKey4 = 0x000b00b4,

        // <summary>
        //     Phone Key 5 Usage.
        // </summary>
        [Description("Phone Key 5")]
        PhoneKey5 = 0x000b00b5,

        // <summary>
        //     Phone Key 6 Usage.
        // </summary>
        [Description("Phone Key 6")]
        PhoneKey6 = 0x000b00b6,

        // <summary>
        //     Phone Key 7 Usage.
        // </summary>
        [Description("Phone Key 7")]
        PhoneKey7 = 0x000b00b7,

        // <summary>
        //     Phone Key 8 Usage.
        // </summary>
        [Description("Phone Key 8")]
        PhoneKey8 = 0x000b00b8,

        // <summary>
        //     Phone Key 9 Usage.
        // </summary>
        [Description("Phone Key 9")]
        PhoneKey9 = 0x000b00b9,

        // <summary>
        //     Phone Key Star Usage.
        // </summary>
        [Description("Phone Key Star")]
        PhoneKeyStar = 0x000b00ba,

        // <summary>
        //     Phone Key Pound Usage.
        // </summary>
        [Description("Phone Key Pound")]
        PhoneKeyPound = 0x000b00bb,

        // <summary>
        //     Phone Key A Usage.
        // </summary>
        [Description("Phone Key A")]
        PhoneKeyA = 0x000b00bc,

        // <summary>
        //     Phone Key B Usage.
        // </summary>
        [Description("Phone Key B")]
        PhoneKeyB = 0x000b00bd,

        // <summary>
        //     Phone Key C Usage.
        // </summary>
        [Description("Phone Key C")]
        PhoneKeyC = 0x000b00be,

        // <summary>
        //     Phone Key D Usage.
        // </summary>
        [Description("Phone Key D")]
        PhoneKeyD = 0x000b00bf,

        // <summary>
        //     Phone Call History Key Usage.
        // </summary>
        [Description("Phone Call History Key")]
        PhoneCallHistoryKey = 0x000b00c0,

        // <summary>
        //     Phone Caller ID Key Usage.
        // </summary>
        [Description("Phone Caller ID Key")]
        PhoneCallerIDKey = 0x000b00c1,

        // <summary>
        //     Phone Settings Key Usage.
        // </summary>
        [Description("Phone Settings Key")]
        PhoneSettingsKey = 0x000b00c2,

        // <summary>
        //     Host Control Usage.
        // </summary>
        [Description("Host Control")]
        HostControl = 0x000b00f0,

        // <summary>
        //     Host Available Usage.
        // </summary>
        [Description("Host Available")]
        HostAvailable = 0x000b00f1,

        // <summary>
        //     Host Call Active Usage.
        // </summary>
        [Description("Host Call Active")]
        HostCallActive = 0x000b00f2,

        // <summary>
        //     Activate Handset Audio Usage.
        // </summary>
        [Description("Activate Handset Audio")]
        ActivateHandsetAudio = 0x000b00f3,

        // <summary>
        //     Ring Type Usage.
        // </summary>
        [Description("Ring Type")]
        RingType = 0x000b00f4,

        // <summary>
        //     Re-dialable Phone Number Usage.
        // </summary>
        [Description("Re-dialable Phone Number")]
        RedialablePhoneNumber = 0x000b00f5,

        // <summary>
        //     Stop Ring Tone Usage.
        // </summary>
        [Description("Stop Ring Tone")]
        StopRingTone = 0x000b00f8,

        // <summary>
        //     PSTN Ring Tone Usage.
        // </summary>
        [Description("PSTN Ring Tone")]
        PSTNRingTone = 0x000b00f9,

        // <summary>
        //     Host Ring Tone Usage.
        // </summary>
        [Description("Host Ring Tone")]
        HostRingTone = 0x000b00fa,

        // <summary>
        //     Alert Sound Error Usage.
        // </summary>
        [Description("Alert Sound Error")]
        AlertSoundError = 0x000b00fb,

        // <summary>
        //     Alert Sound Confirm Usage.
        // </summary>
        [Description("Alert Sound Confirm")]
        AlertSoundConfirm = 0x000b00fc,

        // <summary>
        //     Alert Sound Notification Usage.
        // </summary>
        [Description("Alert Sound Notification")]
        AlertSoundNotification = 0x000b00fd,

        // <summary>
        //     Silent Ring Usage.
        // </summary>
        [Description("Silent Ring")]
        SilentRing = 0x000b00fe,

        // <summary>
        //     Email Message Waiting Usage.
        // </summary>
        [Description("Email Message Waiting")]
        EmailMessageWaiting = 0x000b0108,

        // <summary>
        //     Voicemail Message Waiting Usage.
        // </summary>
        [Description("Voicemail Message Waiting")]
        VoicemailMessageWaiting = 0x000b0109,

        // <summary>
        //     Host Hold Usage.
        // </summary>
        [Description("Host Hold")]
        HostHold = 0x000b010a,

        // <summary>
        //     Incoming Call History Count Usage.
        // </summary>
        [Description("Incoming Call History Count")]
        IncomingCallHistoryCount = 0x000b0110,

        // <summary>
        //     Outgoing Call History Count Usage.
        // </summary>
        [Description("Outgoing Call History Count")]
        OutgoingCallHistoryCount = 0x000b0111,

        // <summary>
        //     Incoming Call History Usage.
        // </summary>
        [Description("Incoming Call History")]
        IncomingCallHistory = 0x000b0112,

        // <summary>
        //     Outgoing Call History Usage.
        // </summary>
        [Description("Outgoing Call History")]
        OutgoingCallHistory = 0x000b0113,

        // <summary>
        //     Phone Locale Usage.
        // </summary>
        [Description("Phone Locale")]
        PhoneLocale = 0x000b0114,

        // <summary>
        //     Phone Time Second Usage.
        // </summary>
        [Description("Phone Time Second")]
        PhoneTimeSecond = 0x000b0140,

        // <summary>
        //     Phone Time Minute Usage.
        // </summary>
        [Description("Phone Time Minute")]
        PhoneTimeMinute = 0x000b0141,

        // <summary>
        //     Phone Time Hour Usage.
        // </summary>
        [Description("Phone Time Hour")]
        PhoneTimeHour = 0x000b0142,

        // <summary>
        //     Phone Date Day Usage.
        // </summary>
        [Description("Phone Date Day")]
        PhoneDateDay = 0x000b0143,

        // <summary>
        //     Phone Date Month Usage.
        // </summary>
        [Description("Phone Date Month")]
        PhoneDateMonth = 0x000b0144,

        // <summary>
        //     Phone Date Year Usage.
        // </summary>
        [Description("Phone Date Year")]
        PhoneDateYear = 0x000b0145,

        // <summary>
        //     Handset Nickname Usage.
        // </summary>
        [Description("Handset Nickname")]
        HandsetNickname = 0x000b0146,

        // <summary>
        //     Address Book ID Usage.
        // </summary>
        [Description("Address Book ID")]
        AddressBookID = 0x000b0147,

        // <summary>
        //     Call Duration Usage.
        // </summary>
        [Description("Call Duration")]
        CallDuration = 0x000b014a,

        // <summary>
        //     Dual Mode Phone Usage.
        // </summary>
        [Description("Dual Mode Phone")]
        DualModePhone = 0x000b014b
    }
}
