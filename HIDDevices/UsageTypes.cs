// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

using System;
using System.ComponentModel;

namespace HIDDevices
{
    [Flags]
    public enum UsageTypes : ushort
    {
        None = 0,

        [UsageType(UsageTypeGroup.Controls)] [Description("Linear Control")]
        LC,

        [UsageType(UsageTypeGroup.Controls)] [Description("On/Off Control")]
        OOC,

        [UsageType(UsageTypeGroup.Controls)] [Description("Momentary Control")]
        MC,

        [UsageType(UsageTypeGroup.Controls)] [Description("One Shot Control")]
        OSC,

        [UsageType(UsageTypeGroup.Controls)] [Description("Re-trigger Control")]
        RTC,

        [UsageType(UsageTypeGroup.Data)] [Description("Selector")]
        Sel,

        [UsageType(UsageTypeGroup.Data)] [Description("Static Value")]
        SV,

        [UsageType(UsageTypeGroup.Data)] [Description("Static Flag")]
        SF,

        [UsageType(UsageTypeGroup.Data)] [Description("Dynamic Value")]
        DV,

        [UsageType(UsageTypeGroup.Data)] [Description("Dynamic Flag")]
        DF,

        [UsageType(UsageTypeGroup.Collection)] [Description("Named Array")]
        NAry,

        [UsageType(UsageTypeGroup.Collection)] [Description("Application Collection")]
        CA,

        [UsageType(UsageTypeGroup.Collection)] [Description("Logical Collection")]
        CL,

        [UsageType(UsageTypeGroup.Collection)] [Description("Physical Collection")]
        CP,

        [UsageType(UsageTypeGroup.Collection)] [Description("Usage Switch")]
        US,

        [UsageType(UsageTypeGroup.Collection)] [Description("Application Collection")]
        UM
    }
}
