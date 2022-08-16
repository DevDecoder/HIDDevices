// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
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
    [SuppressMessage("CodeQuality", "IDE0051:Remove unused private members", Justification = "Used during deserialization.")]
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
        UsageIdGenerator = usageIdGenerator;
        UsageIds = Normalize(usageIds).ToArray();
        SafeName = name.GetSafe();
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

    /// <summary>
    ///     The C# safe version of the name.
    /// </summary>
    public string SafeName { get; internal set; }

    /// <summary>
    ///     Places ids in numerical order, and ensures there is a '0' value.
    /// </summary>
    /// <param name="usageIds"></param>
    /// <returns></returns>
    private IEnumerable<HidUsageId> Normalize(IReadOnlyList<HidUsageId> usageIds)
    {
        var safeNames = new HashSet<string>();
        var first = true;
        foreach (var id in usageIds.OrderBy(i => i.Id))
        {
            if (first)
            {
                if (id.Id != 0)
                {
                    safeNames.Add(HidUsageId.Undefined.SafeName);
                    yield return HidUsageId.Undefined;
                }

                first = false;
            }

            var safeName = id.SafeName;
            if (safeNames.Contains(safeName))
            {
                var suffix = 1;
                string newName;
                do
                {
                    newName = safeName + ++suffix;
                } while (safeNames.Contains(newName));

                safeName = newName;
                id.SafeName = newName;
            }

            safeNames.Add(safeName);
            yield return id;
        }

        if (first)
        {
            yield return HidUsageId.Undefined;
        }
    }

    /// <inheritdoc />
    public override string ToString() => $"{Name}[{Id:#,#}]";
}
