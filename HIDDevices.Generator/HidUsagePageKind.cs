// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace HIDDevices.Generator;

/// <summary>
///     Kinds of UsagePage.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum HidUsagePageKind
{
    /// <summary>
    ///     All Usages within Page are pre-defined.
    /// </summary>
    Defined,

    /// <summary>
    ///     Usages are generated on-demand (e.g. Ordinal/Button).
    /// </summary>
    Generated
}
