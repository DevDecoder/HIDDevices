// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using Newtonsoft.Json;

namespace HIDDevices.Generator;

/// <summary>
///     Represents a UsageId as defined by the HID specification.
/// </summary>
[JsonObject(MemberSerialization.OptIn)]
public class HidUsageId
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="HidUsageId" /> class.
    ///     Will automatically add it to the the <see cref="HidUsagePage" /> internal list.
    /// </summary>
    /// <param name="id">Id of new UsageId.</param>
    /// <param name="name">Name of the new UsageId.</param>
    /// <param name="kinds">Valid kinds for this UsageId.</param>
    [JsonConstructor]
    internal HidUsageId(ushort id, string name, IReadOnlyCollection<HidUsageKind> kinds)
    {
        Id = id;
        Name = name;
        Kinds = kinds;
    }

    /// <summary>
    ///     Gets the Usage Id as defined in the HID Usage Table.
    /// </summary>
    [JsonProperty]
    public ushort Id { get; }

    /// <summary>
    ///     Gets the Usage Name as defined in the HID Usage Table.
    /// </summary>
    [JsonProperty]
    public string Name { get; }

    /// <summary>
    ///     Gets the Usage kinds as defined in the HID Usage Table.
    ///     Most UsageIds will only have a single kind.
    /// </summary>
    [JsonProperty]
    public IReadOnlyCollection<HidUsageKind> Kinds { get; }

    /// <inheritdoc />
    public override string ToString() => $"{Name}[{Id:#,#}]";
}
