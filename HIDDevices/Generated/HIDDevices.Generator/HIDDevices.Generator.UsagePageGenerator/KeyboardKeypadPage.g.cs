// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

// Specification revision: 1.3.0; generated at 2022-03-01 02:00:40Z.

#pragma warning disable CS0108 // Member hides inherited member; missing new keyword

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;

namespace DevDecoder.HIDDevices.Usages
{
    // <summary>
    //     Keyboard/Keypad Usage Page.
    // </summary>
    [Description("Keyboard/Keypad Usage Page")]
    public enum KeyboardKeypadPage : uint
    {
        // <summary>
        //     Undefined Usage.
        // </summary>
        [Description("Undefined")]
        Undefined = 0x00070000,

        // <summary>
        //     ErrorRollOver Usage.
        // </summary>
        [Description("ErrorRollOver")]
        ErrorRollOver = 0x00070001,

        // <summary>
        //     POSTFail Usage.
        // </summary>
        [Description("POSTFail")]
        POSTFail = 0x00070002,

        // <summary>
        //     ErrorUndefined Usage.
        // </summary>
        [Description("ErrorUndefined")]
        ErrorUndefined = 0x00070003,

        // <summary>
        //     Keyboard A Usage.
        // </summary>
        [Description("Keyboard A")]
        KeyboardA = 0x00070004,

        // <summary>
        //     Keyboard B Usage.
        // </summary>
        [Description("Keyboard B")]
        KeyboardB = 0x00070005,

        // <summary>
        //     Keyboard C Usage.
        // </summary>
        [Description("Keyboard C")]
        KeyboardC = 0x00070006,

        // <summary>
        //     Keyboard D Usage.
        // </summary>
        [Description("Keyboard D")]
        KeyboardD = 0x00070007,

        // <summary>
        //     Keyboard E Usage.
        // </summary>
        [Description("Keyboard E")]
        KeyboardE = 0x00070008,

        // <summary>
        //     Keyboard F Usage.
        // </summary>
        [Description("Keyboard F")]
        KeyboardF = 0x00070009,

        // <summary>
        //     Keyboard G Usage.
        // </summary>
        [Description("Keyboard G")]
        KeyboardG = 0x0007000a,

        // <summary>
        //     Keyboard H Usage.
        // </summary>
        [Description("Keyboard H")]
        KeyboardH = 0x0007000b,

        // <summary>
        //     Keyboard I Usage.
        // </summary>
        [Description("Keyboard I")]
        KeyboardI = 0x0007000c,

        // <summary>
        //     Keyboard J Usage.
        // </summary>
        [Description("Keyboard J")]
        KeyboardJ = 0x0007000d,

        // <summary>
        //     Keyboard K Usage.
        // </summary>
        [Description("Keyboard K")]
        KeyboardK = 0x0007000e,

        // <summary>
        //     Keyboard L Usage.
        // </summary>
        [Description("Keyboard L")]
        KeyboardL = 0x0007000f,

        // <summary>
        //     Keyboard M Usage.
        // </summary>
        [Description("Keyboard M")]
        KeyboardM = 0x00070010,

        // <summary>
        //     Keyboard N Usage.
        // </summary>
        [Description("Keyboard N")]
        KeyboardN = 0x00070011,

        // <summary>
        //     Keyboard O Usage.
        // </summary>
        [Description("Keyboard O")]
        KeyboardO = 0x00070012,

        // <summary>
        //     Keyboard P Usage.
        // </summary>
        [Description("Keyboard P")]
        KeyboardP = 0x00070013,

        // <summary>
        //     Keyboard Q Usage.
        // </summary>
        [Description("Keyboard Q")]
        KeyboardQ = 0x00070014,

        // <summary>
        //     Keyboard R Usage.
        // </summary>
        [Description("Keyboard R")]
        KeyboardR = 0x00070015,

        // <summary>
        //     Keyboard S Usage.
        // </summary>
        [Description("Keyboard S")]
        KeyboardS = 0x00070016,

        // <summary>
        //     Keyboard T Usage.
        // </summary>
        [Description("Keyboard T")]
        KeyboardT = 0x00070017,

        // <summary>
        //     Keyboard U Usage.
        // </summary>
        [Description("Keyboard U")]
        KeyboardU = 0x00070018,

        // <summary>
        //     Keyboard V Usage.
        // </summary>
        [Description("Keyboard V")]
        KeyboardV = 0x00070019,

        // <summary>
        //     Keyboard W Usage.
        // </summary>
        [Description("Keyboard W")]
        KeyboardW = 0x0007001a,

        // <summary>
        //     Keyboard X Usage.
        // </summary>
        [Description("Keyboard X")]
        KeyboardX = 0x0007001b,

        // <summary>
        //     Keyboard Y Usage.
        // </summary>
        [Description("Keyboard Y")]
        KeyboardY = 0x0007001c,

        // <summary>
        //     Keyboard Z Usage.
        // </summary>
        [Description("Keyboard Z")]
        KeyboardZ = 0x0007001d,

        // <summary>
        //     Keyboard 1 and Bang Usage.
        // </summary>
        [Description("Keyboard 1 and Bang")]
        Keyboard1AndBang = 0x0007001e,

        // <summary>
        //     Keyboard 2 and At Usage.
        // </summary>
        [Description("Keyboard 2 and At")]
        Keyboard2AndAt = 0x0007001f,

        // <summary>
        //     Keyboard 3 And Hash Usage.
        // </summary>
        [Description("Keyboard 3 And Hash")]
        Keyboard3AndHash = 0x00070020,

        // <summary>
        //     Keyboard 4 and Dollar Usage.
        // </summary>
        [Description("Keyboard 4 and Dollar")]
        Keyboard4AndDollar = 0x00070021,

        // <summary>
        //     Keyboard 5 and Percent Usage.
        // </summary>
        [Description("Keyboard 5 and Percent")]
        Keyboard5AndPercent = 0x00070022,

        // <summary>
        //     Keyboard 6 and Caret Usage.
        // </summary>
        [Description("Keyboard 6 and Caret")]
        Keyboard6AndCaret = 0x00070023,

        // <summary>
        //     Keyboard 7 and Ampersand Usage.
        // </summary>
        [Description("Keyboard 7 and Ampersand")]
        Keyboard7AndAmpersand = 0x00070024,

        // <summary>
        //     Keyboard 8 and Star Usage.
        // </summary>
        [Description("Keyboard 8 and Star")]
        Keyboard8AndStar = 0x00070025,

        // <summary>
        //     Keyboard 9 and Left Bracket Usage.
        // </summary>
        [Description("Keyboard 9 and Left Bracket")]
        Keyboard9AndLeftBracket = 0x00070026,

        // <summary>
        //     Keyboard 0 and Right Bracket Usage.
        // </summary>
        [Description("Keyboard 0 and Right Bracket")]
        Keyboard0AndRightBracket = 0x00070027,

        // <summary>
        //     Keyboard Return Enter Usage.
        // </summary>
        [Description("Keyboard Return Enter")]
        KeyboardReturnEnter = 0x00070028,

        // <summary>
        //     Keyboard Escape Usage.
        // </summary>
        [Description("Keyboard Escape")]
        KeyboardEscape = 0x00070029,

        // <summary>
        //     Keyboard Delete Usage.
        // </summary>
        [Description("Keyboard Delete")]
        KeyboardDelete = 0x0007002a,

        // <summary>
        //     Keyboard Tab Usage.
        // </summary>
        [Description("Keyboard Tab")]
        KeyboardTab = 0x0007002b,

        // <summary>
        //     Keyboard Spacebar Usage.
        // </summary>
        [Description("Keyboard Spacebar")]
        KeyboardSpacebar = 0x0007002c,

        // <summary>
        //     Keyboard Dash and Underscore Usage.
        // </summary>
        [Description("Keyboard Dash and Underscore")]
        KeyboardDashAndUnderscore = 0x0007002d,

        // <summary>
        //     Keyboard Equals and Plus Usage.
        // </summary>
        [Description("Keyboard Equals and Plus")]
        KeyboardEqualsAndPlus = 0x0007002e,

        // <summary>
        //     Keyboard Left Brace Usage.
        // </summary>
        [Description("Keyboard Left Brace")]
        KeyboardLeftBrace = 0x0007002f,

        // <summary>
        //     Keyboard Right Brace Usage.
        // </summary>
        [Description("Keyboard Right Brace")]
        KeyboardRightBrace = 0x00070030,

        // <summary>
        //     Keyboard Pipe and Slash Usage.
        // </summary>
        [Description("Keyboard Pipe and Slash")]
        KeyboardPipeAndSlash = 0x00070031,

        // <summary>
        //     Keyboard Non-US Usage.
        // </summary>
        [Description("Keyboard Non-US")]
        KeyboardNonUS = 0x00070032,

        // <summary>
        //     Keyboard SemiColon and Colon Usage.
        // </summary>
        [Description("Keyboard SemiColon and Colon")]
        KeyboardSemiColonAndColon = 0x00070033,

        // <summary>
        //     Keyboard Left Apos and Double Usage.
        // </summary>
        [Description("Keyboard Left Apos and Double")]
        KeyboardLeftAposAndDouble = 0x00070034,

        // <summary>
        //     Keyboard Grave Accent and Tilde Usage.
        // </summary>
        [Description("Keyboard Grave Accent and Tilde")]
        KeyboardGraveAccentAndTilde = 0x00070035,

        // <summary>
        //     Keyboard Comma Usage.
        // </summary>
        [Description("Keyboard Comma")]
        KeyboardComma = 0x00070036,

        // <summary>
        //     Keyboard Period Usage.
        // </summary>
        [Description("Keyboard Period")]
        KeyboardPeriod = 0x00070037,

        // <summary>
        //     Keyboard QuestionMark Usage.
        // </summary>
        [Description("Keyboard QuestionMark")]
        KeyboardQuestionMark = 0x00070038,

        // <summary>
        //     Keyboard Caps Lock Usage.
        // </summary>
        [Description("Keyboard Caps Lock")]
        KeyboardCapsLock = 0x00070039,

        // <summary>
        //     Keyboard F1 Usage.
        // </summary>
        [Description("Keyboard F1")]
        KeyboardF1 = 0x0007003a,

        // <summary>
        //     Keyboard F2 Usage.
        // </summary>
        [Description("Keyboard F2")]
        KeyboardF2 = 0x0007003b,

        // <summary>
        //     Keyboard F3 Usage.
        // </summary>
        [Description("Keyboard F3")]
        KeyboardF3 = 0x0007003c,

        // <summary>
        //     Keyboard F4 Usage.
        // </summary>
        [Description("Keyboard F4")]
        KeyboardF4 = 0x0007003d,

        // <summary>
        //     Keyboard F5 Usage.
        // </summary>
        [Description("Keyboard F5")]
        KeyboardF5 = 0x0007003e,

        // <summary>
        //     Keyboard F6 Usage.
        // </summary>
        [Description("Keyboard F6")]
        KeyboardF6 = 0x0007003f,

        // <summary>
        //     Keyboard F7 Usage.
        // </summary>
        [Description("Keyboard F7")]
        KeyboardF7 = 0x00070040,

        // <summary>
        //     Keyboard F8 Usage.
        // </summary>
        [Description("Keyboard F8")]
        KeyboardF8 = 0x00070041,

        // <summary>
        //     Keyboard F9 Usage.
        // </summary>
        [Description("Keyboard F9")]
        KeyboardF9 = 0x00070042,

        // <summary>
        //     Keyboard F10 Usage.
        // </summary>
        [Description("Keyboard F10")]
        KeyboardF10 = 0x00070043,

        // <summary>
        //     Keyboard F11 Usage.
        // </summary>
        [Description("Keyboard F11")]
        KeyboardF11 = 0x00070044,

        // <summary>
        //     Keyboard F12 Usage.
        // </summary>
        [Description("Keyboard F12")]
        KeyboardF12 = 0x00070045,

        // <summary>
        //     Keyboard PrintScreen Usage.
        // </summary>
        [Description("Keyboard PrintScreen")]
        KeyboardPrintScreen = 0x00070046,

        // <summary>
        //     Keyboard Scroll Lock Usage.
        // </summary>
        [Description("Keyboard Scroll Lock")]
        KeyboardScrollLock = 0x00070047,

        // <summary>
        //     Keyboard Pause Usage.
        // </summary>
        [Description("Keyboard Pause")]
        KeyboardPause = 0x00070048,

        // <summary>
        //     Keyboard Insert Usage.
        // </summary>
        [Description("Keyboard Insert")]
        KeyboardInsert = 0x00070049,

        // <summary>
        //     Keyboard Home Usage.
        // </summary>
        [Description("Keyboard Home")]
        KeyboardHome = 0x0007004a,

        // <summary>
        //     Keyboard PageUp Usage.
        // </summary>
        [Description("Keyboard PageUp")]
        KeyboardPageUp = 0x0007004b,

        // <summary>
        //     Keyboard Delete Forward Usage.
        // </summary>
        [Description("Keyboard Delete Forward")]
        KeyboardDeleteForward = 0x0007004c,

        // <summary>
        //     Keyboard End Usage.
        // </summary>
        [Description("Keyboard End")]
        KeyboardEnd = 0x0007004d,

        // <summary>
        //     Keyboard PageDown Usage.
        // </summary>
        [Description("Keyboard PageDown")]
        KeyboardPageDown = 0x0007004e,

        // <summary>
        //     Keyboard RightArrow Usage.
        // </summary>
        [Description("Keyboard RightArrow")]
        KeyboardRightArrow = 0x0007004f,

        // <summary>
        //     Keyboard LeftArrow Usage.
        // </summary>
        [Description("Keyboard LeftArrow")]
        KeyboardLeftArrow = 0x00070050,

        // <summary>
        //     Keyboard DownArrow Usage.
        // </summary>
        [Description("Keyboard DownArrow")]
        KeyboardDownArrow = 0x00070051,

        // <summary>
        //     Keyboard UpArrow Usage.
        // </summary>
        [Description("Keyboard UpArrow")]
        KeyboardUpArrow = 0x00070052,

        // <summary>
        //     Keypad Num Lock and Clear Usage.
        // </summary>
        [Description("Keypad Num Lock and Clear")]
        KeypadNumLockAndClear = 0x00070053,

        // <summary>
        //     Keypad Forward Slash Usage.
        // </summary>
        [Description("Keypad Forward Slash")]
        KeypadForwardSlash = 0x00070054,

        // <summary>
        //     Keypad Star Usage.
        // </summary>
        [Description("Keypad Star")]
        KeypadStar = 0x00070055,

        // <summary>
        //     Keyboard Dash Usage.
        // </summary>
        [Description("Keyboard Dash")]
        KeyboardDash = 0x00070056,

        // <summary>
        //     Keypad Plus Usage.
        // </summary>
        [Description("Keypad Plus")]
        KeypadPlus = 0x00070057,

        // <summary>
        //     Keypad ENTER Usage.
        // </summary>
        [Description("Keypad ENTER")]
        KeypadENTER = 0x00070058,

        // <summary>
        //     Keypad 1 and End Usage.
        // </summary>
        [Description("Keypad 1 and End")]
        Keypad1AndEnd = 0x00070059,

        // <summary>
        //     Keypad 2 and Down Arrow Usage.
        // </summary>
        [Description("Keypad 2 and Down Arrow")]
        Keypad2AndDownArrow = 0x0007005a,

        // <summary>
        //     Keypad 3 and PageDn Usage.
        // </summary>
        [Description("Keypad 3 and PageDn")]
        Keypad3AndPageDn = 0x0007005b,

        // <summary>
        //     Keypad 4 and Left Arrow Usage.
        // </summary>
        [Description("Keypad 4 and Left Arrow")]
        Keypad4AndLeftArrow = 0x0007005c,

        // <summary>
        //     Keypad 5 Usage.
        // </summary>
        [Description("Keypad 5")]
        Keypad5 = 0x0007005d,

        // <summary>
        //     Keypad 6 and Right Arrow Usage.
        // </summary>
        [Description("Keypad 6 and Right Arrow")]
        Keypad6AndRightArrow = 0x0007005e,

        // <summary>
        //     Keypad 7 and Home Usage.
        // </summary>
        [Description("Keypad 7 and Home")]
        Keypad7AndHome = 0x0007005f,

        // <summary>
        //     Keypad 8 and Up Arrow Usage.
        // </summary>
        [Description("Keypad 8 and Up Arrow")]
        Keypad8AndUpArrow = 0x00070060,

        // <summary>
        //     Keypad 9 and PageUp Usage.
        // </summary>
        [Description("Keypad 9 and PageUp")]
        Keypad9AndPageUp = 0x00070061,

        // <summary>
        //     Keypad 0 and Insert Usage.
        // </summary>
        [Description("Keypad 0 and Insert")]
        Keypad0AndInsert = 0x00070062,

        // <summary>
        //     Keypad Period Usage.
        // </summary>
        [Description("Keypad Period")]
        KeypadPeriod = 0x00070063,

        // <summary>
        //     Keyboard Non-US Slash Bar Usage.
        // </summary>
        [Description("Keyboard Non-US Slash Bar")]
        KeyboardNonUSSlashBar = 0x00070064,

        // <summary>
        //     Keyboard Application Usage.
        // </summary>
        [Description("Keyboard Application")]
        KeyboardApplication = 0x00070065,

        // <summary>
        //     Keyboard Power Usage.
        // </summary>
        [Description("Keyboard Power")]
        KeyboardPower = 0x00070066,

        // <summary>
        //     Keypad Equals Usage.
        // </summary>
        [Description("Keypad Equals")]
        KeypadEquals = 0x00070067,

        // <summary>
        //     Keyboard F13 Usage.
        // </summary>
        [Description("Keyboard F13")]
        KeyboardF13 = 0x00070068,

        // <summary>
        //     Keyboard F14 Usage.
        // </summary>
        [Description("Keyboard F14")]
        KeyboardF14 = 0x00070069,

        // <summary>
        //     Keyboard F15 Usage.
        // </summary>
        [Description("Keyboard F15")]
        KeyboardF15 = 0x0007006a,

        // <summary>
        //     Keyboard F16 Usage.
        // </summary>
        [Description("Keyboard F16")]
        KeyboardF16 = 0x0007006b,

        // <summary>
        //     Keyboard F17 Usage.
        // </summary>
        [Description("Keyboard F17")]
        KeyboardF17 = 0x0007006c,

        // <summary>
        //     Keyboard F18 Usage.
        // </summary>
        [Description("Keyboard F18")]
        KeyboardF18 = 0x0007006d,

        // <summary>
        //     Keyboard F19 Usage.
        // </summary>
        [Description("Keyboard F19")]
        KeyboardF19 = 0x0007006e,

        // <summary>
        //     Keyboard F20 Usage.
        // </summary>
        [Description("Keyboard F20")]
        KeyboardF20 = 0x0007006f,

        // <summary>
        //     Keyboard F21 Usage.
        // </summary>
        [Description("Keyboard F21")]
        KeyboardF21 = 0x00070070,

        // <summary>
        //     Keyboard F22 Usage.
        // </summary>
        [Description("Keyboard F22")]
        KeyboardF22 = 0x00070071,

        // <summary>
        //     Keyboard F23 Usage.
        // </summary>
        [Description("Keyboard F23")]
        KeyboardF23 = 0x00070072,

        // <summary>
        //     Keyboard F24 Usage.
        // </summary>
        [Description("Keyboard F24")]
        KeyboardF24 = 0x00070073,

        // <summary>
        //     Keyboard Execute Usage.
        // </summary>
        [Description("Keyboard Execute")]
        KeyboardExecute = 0x00070074,

        // <summary>
        //     Keyboard Help Usage.
        // </summary>
        [Description("Keyboard Help")]
        KeyboardHelp = 0x00070075,

        // <summary>
        //     Keyboard Menu Usage.
        // </summary>
        [Description("Keyboard Menu")]
        KeyboardMenu = 0x00070076,

        // <summary>
        //     Keyboard Select Usage.
        // </summary>
        [Description("Keyboard Select")]
        KeyboardSelect = 0x00070077,

        // <summary>
        //     Keyboard Stop Usage.
        // </summary>
        [Description("Keyboard Stop")]
        KeyboardStop = 0x00070078,

        // <summary>
        //     Keyboard Again Usage.
        // </summary>
        [Description("Keyboard Again")]
        KeyboardAgain = 0x00070079,

        // <summary>
        //     Keyboard Undo Usage.
        // </summary>
        [Description("Keyboard Undo")]
        KeyboardUndo = 0x0007007a,

        // <summary>
        //     Keyboard Cut Usage.
        // </summary>
        [Description("Keyboard Cut")]
        KeyboardCut = 0x0007007b,

        // <summary>
        //     Keyboard Copy Usage.
        // </summary>
        [Description("Keyboard Copy")]
        KeyboardCopy = 0x0007007c,

        // <summary>
        //     Keyboard Paste Usage.
        // </summary>
        [Description("Keyboard Paste")]
        KeyboardPaste = 0x0007007d,

        // <summary>
        //     Keyboard Find Usage.
        // </summary>
        [Description("Keyboard Find")]
        KeyboardFind = 0x0007007e,

        // <summary>
        //     Keyboard Mute Usage.
        // </summary>
        [Description("Keyboard Mute")]
        KeyboardMute = 0x0007007f,

        // <summary>
        //     Keyboard Volume Up Usage.
        // </summary>
        [Description("Keyboard Volume Up")]
        KeyboardVolumeUp = 0x00070080,

        // <summary>
        //     Keyboard Volume Down Usage.
        // </summary>
        [Description("Keyboard Volume Down")]
        KeyboardVolumeDown = 0x00070081,

        // <summary>
        //     Keyboard Locking Caps Lock Usage.
        // </summary>
        [Description("Keyboard Locking Caps Lock")]
        KeyboardLockingCapsLock = 0x00070082,

        // <summary>
        //     Keyboard Locking Num Lock Usage.
        // </summary>
        [Description("Keyboard Locking Num Lock")]
        KeyboardLockingNumLock = 0x00070083,

        // <summary>
        //     Keyboard Locking Scroll Lock Usage.
        // </summary>
        [Description("Keyboard Locking Scroll Lock")]
        KeyboardLockingScrollLock = 0x00070084,

        // <summary>
        //     Keypad Comma Usage.
        // </summary>
        [Description("Keypad Comma")]
        KeypadComma = 0x00070085,

        // <summary>
        //     Keypad Equal Sign Usage.
        // </summary>
        [Description("Keypad Equal Sign")]
        KeypadEqualSign = 0x00070086,

        // <summary>
        //     Keyboard International1 Usage.
        // </summary>
        [Description("Keyboard International1")]
        KeyboardInternational1 = 0x00070087,

        // <summary>
        //     Keyboard International2 Usage.
        // </summary>
        [Description("Keyboard International2")]
        KeyboardInternational2 = 0x00070088,

        // <summary>
        //     Keyboard International3 Usage.
        // </summary>
        [Description("Keyboard International3")]
        KeyboardInternational3 = 0x00070089,

        // <summary>
        //     Keyboard International4 Usage.
        // </summary>
        [Description("Keyboard International4")]
        KeyboardInternational4 = 0x0007008a,

        // <summary>
        //     Keyboard International5 Usage.
        // </summary>
        [Description("Keyboard International5")]
        KeyboardInternational5 = 0x0007008b,

        // <summary>
        //     Keyboard International6 Usage.
        // </summary>
        [Description("Keyboard International6")]
        KeyboardInternational6 = 0x0007008c,

        // <summary>
        //     Keyboard International7 Usage.
        // </summary>
        [Description("Keyboard International7")]
        KeyboardInternational7 = 0x0007008d,

        // <summary>
        //     Keyboard International8 Usage.
        // </summary>
        [Description("Keyboard International8")]
        KeyboardInternational8 = 0x0007008e,

        // <summary>
        //     Keyboard International9 Usage.
        // </summary>
        [Description("Keyboard International9")]
        KeyboardInternational9 = 0x0007008f,

        // <summary>
        //     Keyboard LANG1 Usage.
        // </summary>
        [Description("Keyboard LANG1")]
        KeyboardLANG1 = 0x00070090,

        // <summary>
        //     Keyboard LANG2 Usage.
        // </summary>
        [Description("Keyboard LANG2")]
        KeyboardLANG2 = 0x00070091,

        // <summary>
        //     Keyboard LANG3 Usage.
        // </summary>
        [Description("Keyboard LANG3")]
        KeyboardLANG3 = 0x00070092,

        // <summary>
        //     Keyboard LANG4 Usage.
        // </summary>
        [Description("Keyboard LANG4")]
        KeyboardLANG4 = 0x00070093,

        // <summary>
        //     Keyboard LANG5 Usage.
        // </summary>
        [Description("Keyboard LANG5")]
        KeyboardLANG5 = 0x00070094,

        // <summary>
        //     Keyboard LANG6 Usage.
        // </summary>
        [Description("Keyboard LANG6")]
        KeyboardLANG6 = 0x00070095,

        // <summary>
        //     Keyboard LANG7 Usage.
        // </summary>
        [Description("Keyboard LANG7")]
        KeyboardLANG7 = 0x00070096,

        // <summary>
        //     Keyboard LANG8 Usage.
        // </summary>
        [Description("Keyboard LANG8")]
        KeyboardLANG8 = 0x00070097,

        // <summary>
        //     Keyboard LANG9 Usage.
        // </summary>
        [Description("Keyboard LANG9")]
        KeyboardLANG9 = 0x00070098,

        // <summary>
        //     Keyboard Alternate Erase Usage.
        // </summary>
        [Description("Keyboard Alternate Erase")]
        KeyboardAlternateErase = 0x00070099,

        // <summary>
        //     Keyboard SysReq Attention Usage.
        // </summary>
        [Description("Keyboard SysReq Attention")]
        KeyboardSysReqAttention = 0x0007009a,

        // <summary>
        //     Keyboard Cancel Usage.
        // </summary>
        [Description("Keyboard Cancel")]
        KeyboardCancel = 0x0007009b,

        // <summary>
        //     Keyboard Clear Usage.
        // </summary>
        [Description("Keyboard Clear")]
        KeyboardClear = 0x0007009c,

        // <summary>
        //     Keyboard Prior Usage.
        // </summary>
        [Description("Keyboard Prior")]
        KeyboardPrior = 0x0007009d,

        // <summary>
        //     Keyboard Return Usage.
        // </summary>
        [Description("Keyboard Return")]
        KeyboardReturn = 0x0007009e,

        // <summary>
        //     Keyboard Separator Usage.
        // </summary>
        [Description("Keyboard Separator")]
        KeyboardSeparator = 0x0007009f,

        // <summary>
        //     Keyboard Out Usage.
        // </summary>
        [Description("Keyboard Out")]
        KeyboardOut = 0x000700a0,

        // <summary>
        //     Keyboard Oper Usage.
        // </summary>
        [Description("Keyboard Oper")]
        KeyboardOper = 0x000700a1,

        // <summary>
        //     Keyboard Clear Again Usage.
        // </summary>
        [Description("Keyboard Clear Again")]
        KeyboardClearAgain = 0x000700a2,

        // <summary>
        //     Keyboard CrSel Props Usage.
        // </summary>
        [Description("Keyboard CrSel Props")]
        KeyboardCrSelProps = 0x000700a3,

        // <summary>
        //     Keyboard ExSel Usage.
        // </summary>
        [Description("Keyboard ExSel")]
        KeyboardExSel = 0x000700a4,

        // <summary>
        //     Keypad Double 0 Usage.
        // </summary>
        [Description("Keypad Double 0")]
        KeypadDouble0 = 0x000700b0,

        // <summary>
        //     Keypad Triple 0 Usage.
        // </summary>
        [Description("Keypad Triple 0")]
        KeypadTriple0 = 0x000700b1,

        // <summary>
        //     Thousands Separator Usage.
        // </summary>
        [Description("Thousands Separator")]
        ThousandsSeparator = 0x000700b2,

        // <summary>
        //     Decimal Separator Usage.
        // </summary>
        [Description("Decimal Separator")]
        DecimalSeparator = 0x000700b3,

        // <summary>
        //     Currency Unit Usage.
        // </summary>
        [Description("Currency Unit")]
        CurrencyUnit = 0x000700b4,

        // <summary>
        //     Currency Sub-unit Usage.
        // </summary>
        [Description("Currency Sub-unit")]
        CurrencySubunit = 0x000700b5,

        // <summary>
        //     Keypad Left Bracket Usage.
        // </summary>
        [Description("Keypad Left Bracket")]
        KeypadLeftBracket = 0x000700b6,

        // <summary>
        //     Keypad Right Bracket Usage.
        // </summary>
        [Description("Keypad Right Bracket")]
        KeypadRightBracket = 0x000700b7,

        // <summary>
        //     Keypad Left Brace Usage.
        // </summary>
        [Description("Keypad Left Brace")]
        KeypadLeftBrace = 0x000700b8,

        // <summary>
        //     Keypad Right Brace Usage.
        // </summary>
        [Description("Keypad Right Brace")]
        KeypadRightBrace = 0x000700b9,

        // <summary>
        //     Keypad Tab Usage.
        // </summary>
        [Description("Keypad Tab")]
        KeypadTab = 0x000700ba,

        // <summary>
        //     Keypad Backspace Usage.
        // </summary>
        [Description("Keypad Backspace")]
        KeypadBackspace = 0x000700bb,

        // <summary>
        //     Keypad A Usage.
        // </summary>
        [Description("Keypad A")]
        KeypadA = 0x000700bc,

        // <summary>
        //     Keypad B Usage.
        // </summary>
        [Description("Keypad B")]
        KeypadB = 0x000700bd,

        // <summary>
        //     Keypad C Usage.
        // </summary>
        [Description("Keypad C")]
        KeypadC = 0x000700be,

        // <summary>
        //     Keypad D Usage.
        // </summary>
        [Description("Keypad D")]
        KeypadD = 0x000700bf,

        // <summary>
        //     Keypad E Usage.
        // </summary>
        [Description("Keypad E")]
        KeypadE = 0x000700c0,

        // <summary>
        //     Keypad F Usage.
        // </summary>
        [Description("Keypad F")]
        KeypadF = 0x000700c1,

        // <summary>
        //     Keypad XOR Usage.
        // </summary>
        [Description("Keypad XOR")]
        KeypadXOR = 0x000700c2,

        // <summary>
        //     Keypad Caret Usage.
        // </summary>
        [Description("Keypad Caret")]
        KeypadCaret = 0x000700c3,

        // <summary>
        //     Keypad Percentage Usage.
        // </summary>
        [Description("Keypad Percentage")]
        KeypadPercentage = 0x000700c4,

        // <summary>
        //     Keypad Less Usage.
        // </summary>
        [Description("Keypad Less")]
        KeypadLess = 0x000700c5,

        // <summary>
        //     Keypad Greater Usage.
        // </summary>
        [Description("Keypad Greater")]
        KeypadGreater = 0x000700c6,

        // <summary>
        //     Keypad Ampersand Usage.
        // </summary>
        [Description("Keypad Ampersand")]
        KeypadAmpersand = 0x000700c7,

        // <summary>
        //     Keypad Double Ampersand Usage.
        // </summary>
        [Description("Keypad Double Ampersand")]
        KeypadDoubleAmpersand = 0x000700c8,

        // <summary>
        //     Keypad Bar Usage.
        // </summary>
        [Description("Keypad Bar")]
        KeypadBar = 0x000700c9,

        // <summary>
        //     Keypad Double Bar Usage.
        // </summary>
        [Description("Keypad Double Bar")]
        KeypadDoubleBar = 0x000700ca,

        // <summary>
        //     Keypad Colon Usage.
        // </summary>
        [Description("Keypad Colon")]
        KeypadColon = 0x000700cb,

        // <summary>
        //     Keypad Hash Usage.
        // </summary>
        [Description("Keypad Hash")]
        KeypadHash = 0x000700cc,

        // <summary>
        //     Keypad Space Usage.
        // </summary>
        [Description("Keypad Space")]
        KeypadSpace = 0x000700cd,

        // <summary>
        //     Keypad At Usage.
        // </summary>
        [Description("Keypad At")]
        KeypadAt = 0x000700ce,

        // <summary>
        //     Keypad Bang Usage.
        // </summary>
        [Description("Keypad Bang")]
        KeypadBang = 0x000700cf,

        // <summary>
        //     Keypad Memory Store Usage.
        // </summary>
        [Description("Keypad Memory Store")]
        KeypadMemoryStore = 0x000700d0,

        // <summary>
        //     Keypad Memory Recall Usage.
        // </summary>
        [Description("Keypad Memory Recall")]
        KeypadMemoryRecall = 0x000700d1,

        // <summary>
        //     Keypad Memory Clear Usage.
        // </summary>
        [Description("Keypad Memory Clear")]
        KeypadMemoryClear = 0x000700d2,

        // <summary>
        //     Keypad Memory Add Usage.
        // </summary>
        [Description("Keypad Memory Add")]
        KeypadMemoryAdd = 0x000700d3,

        // <summary>
        //     Keypad Memory Subtract Usage.
        // </summary>
        [Description("Keypad Memory Subtract")]
        KeypadMemorySubtract = 0x000700d4,

        // <summary>
        //     Keypad Memory Multiply Usage.
        // </summary>
        [Description("Keypad Memory Multiply")]
        KeypadMemoryMultiply = 0x000700d5,

        // <summary>
        //     Keypad Memory Divide Usage.
        // </summary>
        [Description("Keypad Memory Divide")]
        KeypadMemoryDivide = 0x000700d6,

        // <summary>
        //     Keypad Plus Minus Usage.
        // </summary>
        [Description("Keypad Plus Minus")]
        KeypadPlusMinus = 0x000700d7,

        // <summary>
        //     Keypad Clear Usage.
        // </summary>
        [Description("Keypad Clear")]
        KeypadClear = 0x000700d8,

        // <summary>
        //     Keypad Clear Entry Usage.
        // </summary>
        [Description("Keypad Clear Entry")]
        KeypadClearEntry = 0x000700d9,

        // <summary>
        //     Keypad Binary Usage.
        // </summary>
        [Description("Keypad Binary")]
        KeypadBinary = 0x000700da,

        // <summary>
        //     Keypad Octal Usage.
        // </summary>
        [Description("Keypad Octal")]
        KeypadOctal = 0x000700db,

        // <summary>
        //     Keypad Decimal Usage.
        // </summary>
        [Description("Keypad Decimal")]
        KeypadDecimal = 0x000700dc,

        // <summary>
        //     Keypad Hexadecimal Usage.
        // </summary>
        [Description("Keypad Hexadecimal")]
        KeypadHexadecimal = 0x000700dd,

        // <summary>
        //     Keyboard LeftControl Usage.
        // </summary>
        [Description("Keyboard LeftControl")]
        KeyboardLeftControl = 0x000700e0,

        // <summary>
        //     Keyboard LeftShift Usage.
        // </summary>
        [Description("Keyboard LeftShift")]
        KeyboardLeftShift = 0x000700e1,

        // <summary>
        //     Keyboard LeftAlt Usage.
        // </summary>
        [Description("Keyboard LeftAlt")]
        KeyboardLeftAlt = 0x000700e2,

        // <summary>
        //     Keyboard Left GUI Usage.
        // </summary>
        [Description("Keyboard Left GUI")]
        KeyboardLeftGUI = 0x000700e3,

        // <summary>
        //     Keyboard RightControl Usage.
        // </summary>
        [Description("Keyboard RightControl")]
        KeyboardRightControl = 0x000700e4,

        // <summary>
        //     Keyboard RightShift Usage.
        // </summary>
        [Description("Keyboard RightShift")]
        KeyboardRightShift = 0x000700e5,

        // <summary>
        //     Keyboard RightAlt Usage.
        // </summary>
        [Description("Keyboard RightAlt")]
        KeyboardRightAlt = 0x000700e6,

        // <summary>
        //     Keyboard Right GUI Usage.
        // </summary>
        [Description("Keyboard Right GUI")]
        KeyboardRightGUI = 0x000700e7
    }
}
