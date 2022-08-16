﻿// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using Newtonsoft.Json;

namespace HIDDevices.Generator;

/// <summary>
///     Generates HidUsages on-the-fly (according to a pattern) rather than at compile-time.
///     This is used primarily by the Button/Ordinal pages, where there are 65535 UsageIds (all 'pre-defined').
///     It would be silly (and wasteful) to pre-generate all of these, so rather it is done on demand.
/// </summary>
[JsonObject(MemberSerialization.OptIn)]
public class HidUsageGenerator
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="HidUsageGenerator" /> class.
    /// </summary>
    /// <param name="namePrefix">Name of every generated Usage.</param>
    /// <param name="startUsageId">First valid UsageId.</param>
    /// <param name="endUsageId">Last valid UsageId.</param>
    /// <param name="kinds">Kinds to associate with generated UsageIds.</param>
    public HidUsageGenerator(string namePrefix, ushort startUsageId, ushort endUsageId,
        IReadOnlyCollection<HidUsageKind> kinds)
    {
        NamePrefix = namePrefix;
        SafeNamePrefix = namePrefix.GetSafe();
        StartUsageId = startUsageId;
        EndUsageId = endUsageId;
        Kinds = kinds;
    }

    /// <summary>
    ///     Gets the Name all generated Usages shall have.
    /// </summary>
    [JsonProperty]
    public string NamePrefix { get; }

    /// <summary>
    ///     Gets the Safe Name all generated Usages shall have.
    /// </summary>
    public string SafeNamePrefix { get; }

    /// <summary>
    ///     Gets the first valid UsageId for this generator.  All IDs between <see cref="StartUsageId" /> and
    ///     <see cref="EndUsageId" /> (inclusive) are valid.
    /// </summary>
    [JsonProperty]
    public ushort StartUsageId { get; }

    /// <summary>
    ///     Gets the ast valid UsageId for this generator.  All IDs between <see cref="StartUsageId" /> and
    ///     <see cref="EndUsageId" /> (inclusive) are valid.
    /// </summary>
    [JsonProperty]
    public ushort EndUsageId { get; }

    /// <summary>
    ///     Gets the Usage kinds as defined the HID Usage Table. Most UsageIds will only have a single kind.
    /// </summary>
    [JsonProperty]
    public IReadOnlyCollection<HidUsageKind> Kinds { get; }

    /// <inheritdoc />
    public override string ToString() => $"[{StartUsageId}-{EndUsageId}]";
}
