﻿// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace HIDDevices.Generator;

/// <summary>
///     Usage Kinds, as described in the HID Usage Tables.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[SuppressMessage("StyleCop.CSharp.DocumentationRules",
    "SA1602:Enumeration items should be documented", Justification = "Items self-explanatory.")]
public enum HidUsageKind
{
    // Button Kinds
    LC,
    OOC,
    MC,
    OSC,
    RTC,

    // Data Kinds
    Sel,
    SV,
    SF,
    DV,
    DF,
    BufferedBytes,

    // Collection Kinds.
    NAry,
    CA,
    CL,
    CP,
    US,
    UM
}
