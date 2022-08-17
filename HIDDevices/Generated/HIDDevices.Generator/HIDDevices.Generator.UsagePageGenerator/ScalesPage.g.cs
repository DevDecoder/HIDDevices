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
    //     Scales Usage Page.
    // </summary>
    [Description("Scales Usage Page")]
    public enum ScalesPage : uint
    {
        // <summary>
        //     Undefined Usage.
        // </summary>
        [Description("Undefined")]
        Undefined = 0x008d0000,

        // <summary>
        //     Scales Usage.
        // </summary>
        [Description("Scales")]
        Scales = 0x008d0001,

        // <summary>
        //     Scale Device Usage.
        // </summary>
        [Description("Scale Device")]
        ScaleDevice = 0x008d0020,

        // <summary>
        //     Scale Class Usage.
        // </summary>
        [Description("Scale Class")]
        ScaleClass = 0x008d0021,

        // <summary>
        //     Scale Class I Metric Usage.
        // </summary>
        [Description("Scale Class I Metric")]
        ScaleClassIMetric = 0x008d0022,

        // <summary>
        //     Scale Class II Metric Usage.
        // </summary>
        [Description("Scale Class II Metric")]
        ScaleClassIIMetric = 0x008d0023,

        // <summary>
        //     Scale Class III Metric Usage.
        // </summary>
        [Description("Scale Class III Metric")]
        ScaleClassIIIMetric = 0x008d0024,

        // <summary>
        //     Scale Class IIIL Metric Usage.
        // </summary>
        [Description("Scale Class IIIL Metric")]
        ScaleClassIIILMetric = 0x008d0025,

        // <summary>
        //     Scale Class IV Metric Usage.
        // </summary>
        [Description("Scale Class IV Metric")]
        ScaleClassIVMetric = 0x008d0026,

        // <summary>
        //     Scale Class III English Usage.
        // </summary>
        [Description("Scale Class III English")]
        ScaleClassIIIEnglish = 0x008d0027,

        // <summary>
        //     Scale Class IIIL English Usage.
        // </summary>
        [Description("Scale Class IIIL English")]
        ScaleClassIIILEnglish = 0x008d0028,

        // <summary>
        //     Scale Class IV English Usage.
        // </summary>
        [Description("Scale Class IV English")]
        ScaleClassIVEnglish = 0x008d0029,

        // <summary>
        //     Scale Class Generic Usage.
        // </summary>
        [Description("Scale Class Generic")]
        ScaleClassGeneric = 0x008d002a,

        // <summary>
        //     Scale Attribute Report Usage.
        // </summary>
        [Description("Scale Attribute Report")]
        ScaleAttributeReport = 0x008d0030,

        // <summary>
        //     Scale Control Report Usage.
        // </summary>
        [Description("Scale Control Report")]
        ScaleControlReport = 0x008d0031,

        // <summary>
        //     Scale Data Report Usage.
        // </summary>
        [Description("Scale Data Report")]
        ScaleDataReport = 0x008d0032,

        // <summary>
        //     Scale Status Report Usage.
        // </summary>
        [Description("Scale Status Report")]
        ScaleStatusReport = 0x008d0033,

        // <summary>
        //     Scale Weight Limit Report Usage.
        // </summary>
        [Description("Scale Weight Limit Report")]
        ScaleWeightLimitReport = 0x008d0034,

        // <summary>
        //     Scale Statistics Report Usage.
        // </summary>
        [Description("Scale Statistics Report")]
        ScaleStatisticsReport = 0x008d0035,

        // <summary>
        //     Data Weight Usage.
        // </summary>
        [Description("Data Weight")]
        DataWeight = 0x008d0040,

        // <summary>
        //     Data Scaling Usage.
        // </summary>
        [Description("Data Scaling")]
        DataScaling = 0x008d0041,

        // <summary>
        //     Weight Unit Usage.
        // </summary>
        [Description("Weight Unit")]
        WeightUnit = 0x008d0050,

        // <summary>
        //     Weight Unit Milligram Usage.
        // </summary>
        [Description("Weight Unit Milligram")]
        WeightUnitMilligram = 0x008d0051,

        // <summary>
        //     Weight Unit Gram Usage.
        // </summary>
        [Description("Weight Unit Gram")]
        WeightUnitGram = 0x008d0052,

        // <summary>
        //     Weight Unit Kilogram Usage.
        // </summary>
        [Description("Weight Unit Kilogram")]
        WeightUnitKilogram = 0x008d0053,

        // <summary>
        //     Weight Unit Carats Usage.
        // </summary>
        [Description("Weight Unit Carats")]
        WeightUnitCarats = 0x008d0054,

        // <summary>
        //     Weight Unit Taels Usage.
        // </summary>
        [Description("Weight Unit Taels")]
        WeightUnitTaels = 0x008d0055,

        // <summary>
        //     Weight Unit Grains Usage.
        // </summary>
        [Description("Weight Unit Grains")]
        WeightUnitGrains = 0x008d0056,

        // <summary>
        //     Weight Unit Pennyweights Usage.
        // </summary>
        [Description("Weight Unit Pennyweights")]
        WeightUnitPennyweights = 0x008d0057,

        // <summary>
        //     Weight Unit Metric Ton Usage.
        // </summary>
        [Description("Weight Unit Metric Ton")]
        WeightUnitMetricTon = 0x008d0058,

        // <summary>
        //     Weight Unit Avoir Ton Usage.
        // </summary>
        [Description("Weight Unit Avoir Ton")]
        WeightUnitAvoirTon = 0x008d0059,

        // <summary>
        //     Weight Unit Troy Ounce Usage.
        // </summary>
        [Description("Weight Unit Troy Ounce")]
        WeightUnitTroyOunce = 0x008d005a,

        // <summary>
        //     Weight Unit Ounce Usage.
        // </summary>
        [Description("Weight Unit Ounce")]
        WeightUnitOunce = 0x008d005b,

        // <summary>
        //     Weight Unit Pound Usage.
        // </summary>
        [Description("Weight Unit Pound")]
        WeightUnitPound = 0x008d005c,

        // <summary>
        //     Calibration Count Usage.
        // </summary>
        [Description("Calibration Count")]
        CalibrationCount = 0x008d0060,

        // <summary>
        //     Re-Zero Count Usage.
        // </summary>
        [Description("Re-Zero Count")]
        ReZeroCount = 0x008d0061,

        // <summary>
        //     Scale Status Usage.
        // </summary>
        [Description("Scale Status")]
        ScaleStatus = 0x008d0070,

        // <summary>
        //     Scale Status Fault Usage.
        // </summary>
        [Description("Scale Status Fault")]
        ScaleStatusFault = 0x008d0071,

        // <summary>
        //     Scale Status Stable at Center of Zero Usage.
        // </summary>
        [Description("Scale Status Stable at Center of Zero")]
        ScaleStatusStableAtCenterOfZero = 0x008d0072,

        // <summary>
        //     Scale Status In Motion Usage.
        // </summary>
        [Description("Scale Status In Motion")]
        ScaleStatusInMotion = 0x008d0073,

        // <summary>
        //     Scale Status Weight Stable Usage.
        // </summary>
        [Description("Scale Status Weight Stable")]
        ScaleStatusWeightStable = 0x008d0074,

        // <summary>
        //     Scale Status Under Zero Usage.
        // </summary>
        [Description("Scale Status Under Zero")]
        ScaleStatusUnderZero = 0x008d0075,

        // <summary>
        //     Scale Status Over Weight Limit Usage.
        // </summary>
        [Description("Scale Status Over Weight Limit")]
        ScaleStatusOverWeightLimit = 0x008d0076,

        // <summary>
        //     Scale Status Requires Calibration Usage.
        // </summary>
        [Description("Scale Status Requires Calibration")]
        ScaleStatusRequiresCalibration = 0x008d0077,

        // <summary>
        //     Scale Status Requires Rezeroing Usage.
        // </summary>
        [Description("Scale Status Requires Rezeroing")]
        ScaleStatusRequiresRezeroing = 0x008d0078,

        // <summary>
        //     Zero Scale Usage.
        // </summary>
        [Description("Zero Scale")]
        ZeroScale = 0x008d0080,

        // <summary>
        //     Enforced Zero Return Usage.
        // </summary>
        [Description("Enforced Zero Return")]
        EnforcedZeroReturn = 0x008d0081
    }
}
