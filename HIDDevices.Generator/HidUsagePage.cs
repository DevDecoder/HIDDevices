// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace HIDDevices.Generator;

/// <summary>
///     Represents a UsagePage as defined by the HID specification.
/// </summary>
[JsonObject(MemberSerialization.OptIn)]
public class HidUsagePage
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="HidUsagePage" /> class.
    ///     Used for both Defined and Generated UsagePages by JSON serialization.
    /// </summary>
    /// <param name="id">Id of the new Page.</param>
    /// <param name="name">Name of the new Page.</param>
    /// <param name="kind">Kind of UsagePage.</param>
    /// <param name="usageIds">The usage Ids.</param>
    /// <param name="usageIdGenerator">The optional generator.</param>
    [JsonConstructor]
    private HidUsagePage(ushort id, string name, HidUsagePageKind kind, IReadOnlyList<HidUsageId> usageIds,
        HidUsageGenerator? usageIdGenerator)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new ArgumentException("name can't be empty or null");
        }

        Id = id;
        Name = name;
        Kind = kind;
        UsageIds = usageIds;
        UsageIdGenerator = usageIdGenerator;
    }

    /// <summary>
    ///     Gets the Kind of UsagePage this is.
    ///     Dictates whether <see cref="UsageIds" /> or <see cref="UsageIdGenerator" /> are null.
    /// </summary>
    [JsonProperty]
    public HidUsagePageKind Kind { get; }

    /// <summary>
    ///     Gets the Page Id as defined in the HID Usage Table.
    /// </summary>
    [JsonProperty]
    public ushort Id { get; }

    /// <summary>
    ///     Gets the Page Name as defined in the HID Usage Table.
    /// </summary>
    [JsonProperty]
    public string Name { get; }

    /// <summary>
    ///     Gets the list of known <see cref="HidUsageId" />s that are associated with this <see cref="HidUsagePage" />.
    /// </summary>
    [JsonProperty]
    public IReadOnlyList<HidUsageId> UsageIds { get; }

    /// <summary>
    ///     Gets the alternative to list of Ids, where <see cref="HidUsageId" />s can be generated automatically.
    /// </summary>
    [JsonProperty]
    public HidUsageGenerator? UsageIdGenerator { get; }

    /// <inheritdoc />
    public override string ToString() => $"{Name}[{Id:#,#}]";
}
