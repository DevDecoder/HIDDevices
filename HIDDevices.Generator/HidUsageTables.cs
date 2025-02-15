﻿// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Newtonsoft.Json;

// ReSharper disable UnusedMember.Global
namespace HIDDevices.Generator;

/// <summary>
///     Container to store all UsagePages and Usages as defined by HID Usage Tables document.
/// </summary>
[JsonObject(MemberSerialization.OptIn)]
public class HidUsageTables
{
    /// <summary>
    ///     Indicates an unloaded specification.
    /// </summary>
    public static HidUsageTables Empty = new();

    private HidUsageTables()
    {
        UsagePages = Array.Empty<HidUsagePage>();
        Version = new Version();
    }

    /// <summary>
    ///     Initializes a new instance of the <see cref="HidUsageTables" /> class.
    /// </summary>
    /// <param name="usagePages">All publicly documented UsagePages.</param>
    /// <param name="usageTableVersion">Version of the HID Usage Table.</param>
    /// <param name="usageTableRevision">Revision of the HID Usage Table.</param>
    /// <param name="usageTableSubRevisionInternal">Sub-revision of the HID Usage Table.</param>
    /// <param name="lastGenerated">Date of table generation.</param>
    [JsonConstructor]
    [SuppressMessage("CodeQuality", "IDE0051:Remove unused private members",
        Justification = "Used during deserialization.")]
    private HidUsageTables(
        IReadOnlyList<HidUsagePage> usagePages,
        ushort usageTableVersion,
        ushort usageTableRevision,
        ushort usageTableSubRevisionInternal,
        DateTime lastGenerated)
    {
        UsagePages = usagePages.OrderBy(p => p.Id).ToArray();

        UsageTableVersion = usageTableVersion;
        UsageTableRevision = usageTableRevision;
        UsageTableSubRevisionInternal = usageTableSubRevisionInternal;
        Version = new Version(UsageTableVersion, UsageTableRevision, usageTableSubRevisionInternal);

        LastGenerated = lastGenerated;
    }

    /// <summary>
    ///     Gets the Version of the table.
    /// </summary>
    [JsonProperty]
    public ushort UsageTableVersion { get; }

    /// <summary>
    ///     Gets the Revision of the table.
    /// </summary>
    [JsonProperty]
    public ushort UsageTableRevision { get; }

    /// <summary>
    ///     Gets the Sub-revision of the table.
    /// </summary>
    [JsonProperty]
    public ushort UsageTableSubRevisionInternal { get; }

    /// <summary>
    ///     The specification version
    /// </summary>
    public Version Version { get; }

    /// <summary>
    ///     Gets the date the table was generated.
    /// </summary>
    [JsonProperty]
    public DateTime LastGenerated { get; }

    /// <summary>
    ///     Gets the UsagePages of the table.
    /// </summary>
    [JsonProperty]
    public IReadOnlyList<HidUsagePage> UsagePages { get; }
}
