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
    //     Auxiliary Display Usage Page.
    // </summary>
    [Description("Auxiliary Display Usage Page")]
    public enum AuxiliaryDisplayPage : uint
    {
        // <summary>
        //     Undefined Usage.
        // </summary>
        [Description("Undefined")]
        Undefined = 0x00140000,

        // <summary>
        //     Alphanumeric Display Usage.
        // </summary>
        [Description("Alphanumeric Display")]
        AlphanumericDisplay = 0x00140001,

        // <summary>
        //     Auxiliary Display Usage.
        // </summary>
        [Description("Auxiliary Display")]
        AuxiliaryDisplay = 0x00140002,

        // <summary>
        //     Display Attributes Report Usage.
        // </summary>
        [Description("Display Attributes Report")]
        DisplayAttributesReport = 0x00140020,

        // <summary>
        //     ASCII Character Set Usage.
        // </summary>
        [Description("ASCII Character Set")]
        ASCIICharacterSet = 0x00140021,

        // <summary>
        //     Data Read Back Usage.
        // </summary>
        [Description("Data Read Back")]
        DataReadBack = 0x00140022,

        // <summary>
        //     Font Read Back Usage.
        // </summary>
        [Description("Font Read Back")]
        FontReadBack = 0x00140023,

        // <summary>
        //     Display Control Report Usage.
        // </summary>
        [Description("Display Control Report")]
        DisplayControlReport = 0x00140024,

        // <summary>
        //     Clear Display Usage.
        // </summary>
        [Description("Clear Display")]
        ClearDisplay = 0x00140025,

        // <summary>
        //     Display Enable Usage.
        // </summary>
        [Description("Display Enable")]
        DisplayEnable = 0x00140026,

        // <summary>
        //     Screen Saver Delay Usage.
        // </summary>
        [Description("Screen Saver Delay")]
        ScreenSaverDelay = 0x00140027,

        // <summary>
        //     Screen Saver Enable Usage.
        // </summary>
        [Description("Screen Saver Enable")]
        ScreenSaverEnable = 0x00140028,

        // <summary>
        //     Vertical Scroll Usage.
        // </summary>
        [Description("Vertical Scroll")]
        VerticalScroll = 0x00140029,

        // <summary>
        //     Horizontal Scroll Usage.
        // </summary>
        [Description("Horizontal Scroll")]
        HorizontalScroll = 0x0014002a,

        // <summary>
        //     Character Report Usage.
        // </summary>
        [Description("Character Report")]
        CharacterReport = 0x0014002b,

        // <summary>
        //     Display Data Usage.
        // </summary>
        [Description("Display Data")]
        DisplayData = 0x0014002c,

        // <summary>
        //     Display Status Usage.
        // </summary>
        [Description("Display Status")]
        DisplayStatus = 0x0014002d,

        // <summary>
        //     Stat Not Ready Usage.
        // </summary>
        [Description("Stat Not Ready")]
        StatNotReady = 0x0014002e,

        // <summary>
        //     Stat Ready Usage.
        // </summary>
        [Description("Stat Ready")]
        StatReady = 0x0014002f,

        // <summary>
        //     Err Not a loadable character Usage.
        // </summary>
        [Description("Err Not a loadable character")]
        ErrNotALoadableCharacter = 0x00140030,

        // <summary>
        //     Err Font data cannot be read Usage.
        // </summary>
        [Description("Err Font data cannot be read")]
        ErrFontDataCannotBeRead = 0x00140031,

        // <summary>
        //     Cursor Position Report Usage.
        // </summary>
        [Description("Cursor Position Report")]
        CursorPositionReport = 0x00140032,

        // <summary>
        //     Row Usage.
        // </summary>
        [Description("Row")]
        Row = 0x00140033,

        // <summary>
        //     Column Usage.
        // </summary>
        [Description("Column")]
        Column = 0x00140034,

        // <summary>
        //     Rows Usage.
        // </summary>
        [Description("Rows")]
        Rows = 0x00140035,

        // <summary>
        //     Columns Usage.
        // </summary>
        [Description("Columns")]
        Columns = 0x00140036,

        // <summary>
        //     Cursor Pixel Positioning Usage.
        // </summary>
        [Description("Cursor Pixel Positioning")]
        CursorPixelPositioning = 0x00140037,

        // <summary>
        //     Cursor Mode Usage.
        // </summary>
        [Description("Cursor Mode")]
        CursorMode = 0x00140038,

        // <summary>
        //     Cursor Enable Usage.
        // </summary>
        [Description("Cursor Enable")]
        CursorEnable = 0x00140039,

        // <summary>
        //     Cursor Blink Usage.
        // </summary>
        [Description("Cursor Blink")]
        CursorBlink = 0x0014003a,

        // <summary>
        //     Font Report Usage.
        // </summary>
        [Description("Font Report")]
        FontReport = 0x0014003b,

        // <summary>
        //     Font Data Usage.
        // </summary>
        [Description("Font Data")]
        FontData = 0x0014003c,

        // <summary>
        //     Character Width Usage.
        // </summary>
        [Description("Character Width")]
        CharacterWidth = 0x0014003d,

        // <summary>
        //     Character Height Usage.
        // </summary>
        [Description("Character Height")]
        CharacterHeight = 0x0014003e,

        // <summary>
        //     Character Spacing Horizontal Usage.
        // </summary>
        [Description("Character Spacing Horizontal")]
        CharacterSpacingHorizontal = 0x0014003f,

        // <summary>
        //     Character Spacing Vertical Usage.
        // </summary>
        [Description("Character Spacing Vertical")]
        CharacterSpacingVertical = 0x00140040,

        // <summary>
        //     Unicode Character Set Usage.
        // </summary>
        [Description("Unicode Character Set")]
        UnicodeCharacterSet = 0x00140041,

        // <summary>
        //     Font 7-Segment Usage.
        // </summary>
        [Description("Font 7-Segment")]
        Font7Segment = 0x00140042,

        // <summary>
        //     7-Segment Direct Map Usage.
        // </summary>
        [Description("7-Segment Direct Map")]
        _7SegmentDirectMap = 0x00140043,

        // <summary>
        //     Font 14-Segment Usage.
        // </summary>
        [Description("Font 14-Segment")]
        Font14Segment = 0x00140044,

        // <summary>
        //     14-Segment Direct Map Usage.
        // </summary>
        [Description("14-Segment Direct Map")]
        _14SegmentDirectMap = 0x00140045,

        // <summary>
        //     Display Brightness Usage.
        // </summary>
        [Description("Display Brightness")]
        DisplayBrightness = 0x00140046,

        // <summary>
        //     Display Contrast Usage.
        // </summary>
        [Description("Display Contrast")]
        DisplayContrast = 0x00140047,

        // <summary>
        //     Character Attribute Usage.
        // </summary>
        [Description("Character Attribute")]
        CharacterAttribute = 0x00140048,

        // <summary>
        //     Attribute Readback Usage.
        // </summary>
        [Description("Attribute Readback")]
        AttributeReadback = 0x00140049,

        // <summary>
        //     Attribute Data Usage.
        // </summary>
        [Description("Attribute Data")]
        AttributeData = 0x0014004a,

        // <summary>
        //     Char Attr Enhance Usage.
        // </summary>
        [Description("Char Attr Enhance")]
        CharAttrEnhance = 0x0014004b,

        // <summary>
        //     Char Attr Underline Usage.
        // </summary>
        [Description("Char Attr Underline")]
        CharAttrUnderline = 0x0014004c,

        // <summary>
        //     Char Attr Blink Usage.
        // </summary>
        [Description("Char Attr Blink")]
        CharAttrBlink = 0x0014004d,

        // <summary>
        //     Bitmap Size X Usage.
        // </summary>
        [Description("Bitmap Size X")]
        BitmapSizeX = 0x00140080,

        // <summary>
        //     Bitmap Size Y Usage.
        // </summary>
        [Description("Bitmap Size Y")]
        BitmapSizeY = 0x00140081,

        // <summary>
        //     Max Blit Size Usage.
        // </summary>
        [Description("Max Blit Size")]
        MaxBlitSize = 0x00140082,

        // <summary>
        //     Bit Depth Format Usage.
        // </summary>
        [Description("Bit Depth Format")]
        BitDepthFormat = 0x00140083,

        // <summary>
        //     Display Orientation Usage.
        // </summary>
        [Description("Display Orientation")]
        DisplayOrientation = 0x00140084,

        // <summary>
        //     Palette Report Usage.
        // </summary>
        [Description("Palette Report")]
        PaletteReport = 0x00140085,

        // <summary>
        //     Palette Data Size Usage.
        // </summary>
        [Description("Palette Data Size")]
        PaletteDataSize = 0x00140086,

        // <summary>
        //     Palette Data Offset Usage.
        // </summary>
        [Description("Palette Data Offset")]
        PaletteDataOffset = 0x00140087,

        // <summary>
        //     Palette Data Usage.
        // </summary>
        [Description("Palette Data")]
        PaletteData = 0x00140088,

        // <summary>
        //     Blit Report Usage.
        // </summary>
        [Description("Blit Report")]
        BlitReport = 0x0014008a,

        // <summary>
        //     Blit Rectangle X1 Usage.
        // </summary>
        [Description("Blit Rectangle X1")]
        BlitRectangleX1 = 0x0014008b,

        // <summary>
        //     Blit Rectangle Y1 Usage.
        // </summary>
        [Description("Blit Rectangle Y1")]
        BlitRectangleY1 = 0x0014008c,

        // <summary>
        //     Blit Rectangle X2 Usage.
        // </summary>
        [Description("Blit Rectangle X2")]
        BlitRectangleX2 = 0x0014008d,

        // <summary>
        //     Blit Rectangle Y2 Usage.
        // </summary>
        [Description("Blit Rectangle Y2")]
        BlitRectangleY2 = 0x0014008e,

        // <summary>
        //     Blit Data Usage.
        // </summary>
        [Description("Blit Data")]
        BlitData = 0x0014008f,

        // <summary>
        //     Soft Button Usage.
        // </summary>
        [Description("Soft Button")]
        SoftButton = 0x00140090,

        // <summary>
        //     Soft Button ID Usage.
        // </summary>
        [Description("Soft Button ID")]
        SoftButtonID = 0x00140091,

        // <summary>
        //     Soft Button Side Usage.
        // </summary>
        [Description("Soft Button Side")]
        SoftButtonSide = 0x00140092,

        // <summary>
        //     Soft Button Offset 1 Usage.
        // </summary>
        [Description("Soft Button Offset 1")]
        SoftButtonOffset1 = 0x00140093,

        // <summary>
        //     Soft Button Offset 2 Usage.
        // </summary>
        [Description("Soft Button Offset 2")]
        SoftButtonOffset2 = 0x00140094,

        // <summary>
        //     Soft Button Report Usage.
        // </summary>
        [Description("Soft Button Report")]
        SoftButtonReport = 0x00140095,

        // <summary>
        //     Soft Keys Usage.
        // </summary>
        [Description("Soft Keys")]
        SoftKeys = 0x001400c2,

        // <summary>
        //     Display Data Extensions Usage.
        // </summary>
        [Description("Display Data Extensions")]
        DisplayDataExtensions = 0x001400cc,

        // <summary>
        //     Character Mapping Usage.
        // </summary>
        [Description("Character Mapping")]
        CharacterMapping = 0x001400cf,

        // <summary>
        //     Unicode Equivalent Usage.
        // </summary>
        [Description("Unicode Equivalent")]
        UnicodeEquivalent = 0x001400dd,

        // <summary>
        //     Character Page Mapping Usage.
        // </summary>
        [Description("Character Page Mapping")]
        CharacterPageMapping = 0x001400df,

        // <summary>
        //     Request Report Usage.
        // </summary>
        [Description("Request Report")]
        RequestReport = 0x001400ff
    }
}
