// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace DevDecoder.HIDDevices;

public sealed class UsageType : IEquatable<UsageType>
{
    private static readonly ConcurrentDictionary<UsageTypes, IReadOnlyCollection<UsageType>>
        s_usageTypes = new();

    /// <summary>
    ///     The Linear Control usage type.
    /// </summary>
    public static readonly UsageType LC = new(UsageTypes.LC, UsageTypeGroup.Controls, "LC",
        "Linear Control");

    /// <summary>
    ///     The On/Off Control usage type.
    /// </summary>
    public static readonly UsageType OOC = new(UsageTypes.OOC, UsageTypeGroup.Controls, "OOC",
        "On/Off Control");

    /// <summary>
    ///     The Momentary Control usage type.
    /// </summary>
    public static readonly UsageType MC = new(UsageTypes.MC, UsageTypeGroup.Controls, "MC",
        "Momentary Control");

    /// <summary>
    ///     The One Shot Control usage type.
    /// </summary>
    public static readonly UsageType OSC = new(UsageTypes.OSC, UsageTypeGroup.Controls, "OSC",
        "One Shot Control");

    /// <summary>
    ///     The Re-trigger Control usage type.
    /// </summary>
    public static readonly UsageType RTC = new(UsageTypes.RTC, UsageTypeGroup.Controls, "RTC",
        "Re-trigger Control");

    /// <summary>
    ///     The Selector usage type.
    /// </summary>
    public static readonly UsageType Sel = new(UsageTypes.Sel, UsageTypeGroup.Data, "Sel", "Selector");

    /// <summary>
    ///     The Static Value usage type.
    /// </summary>
    public static readonly UsageType SV = new(UsageTypes.SV, UsageTypeGroup.Data, "SV", "Static Value");

    /// <summary>
    ///     The Static Flag usage type.
    /// </summary>
    public static readonly UsageType SF = new(UsageTypes.SF, UsageTypeGroup.Data, "SF", "Static Flag");

    /// <summary>
    ///     The Dynamic Value usage type.
    /// </summary>
    public static readonly UsageType DV = new(UsageTypes.DV, UsageTypeGroup.Data, "DV", "Dynamic Value");

    /// <summary>
    ///     The Dynamic Flag usage type.
    /// </summary>
    public static readonly UsageType DF = new(UsageTypes.DF, UsageTypeGroup.Data, "DF", "Dynamic Flag");

    /// <summary>
    ///     The Dynamic Flag usage type.
    /// </summary>
    public static readonly UsageType BufferedBytes =
        new(UsageTypes.BufferedBytes, UsageTypeGroup.Data, "BufferedBytes", "Buffered Bytes");

    /// <summary>
    ///     The Named Array usage type.
    /// </summary>
    public static readonly UsageType NAry = new(UsageTypes.NAry, UsageTypeGroup.Collections, "NAry",
        "Named Array");

    /// <summary>
    ///     The Application Collection usage type.
    /// </summary>
    public static readonly UsageType CA = new(UsageTypes.CA, UsageTypeGroup.Collections, "CA",
        "Application Collection");

    /// <summary>
    ///     The Logical Collection usage type.
    /// </summary>
    public static readonly UsageType CL = new(UsageTypes.CL, UsageTypeGroup.Collections, "CL",
        "Logical Collection");

    /// <summary>
    ///     The Physical Collection usage type.
    /// </summary>
    public static readonly UsageType CP = new(UsageTypes.CP, UsageTypeGroup.Collections, "CP",
        "Physical Collection");

    /// <summary>
    ///     The Usage Switch usage type.
    /// </summary>
    public static readonly UsageType US = new(UsageTypes.US, UsageTypeGroup.Controls, "US",
        "Usage Switch");

    /// <summary>
    ///     The Usage Modifier usage type.
    /// </summary>
    public static readonly UsageType UM = new(UsageTypes.UM, UsageTypeGroup.Collections, "UM",
        "Usage Modifier");

    private UsageType(UsageTypes usageTypes, UsageTypeGroup usageTypeGroup, string name, string description)
    {
        UsageTypes = usageTypes;
        UsageTypeGroup = usageTypeGroup;
        Name = name;
        Description = description;
        s_usageTypes[usageTypes] = new[] { this };
    }

    /// <summary>
    ///     Gets the associated usage types enum.
    /// </summary>
    /// <value>The usage types.</value>
    public UsageTypes UsageTypes { get; }

    /// <summary>
    ///     Gets the usage type group.
    /// </summary>
    /// <value>The usage type group.</value>
    public UsageTypeGroup UsageTypeGroup { get; }

    /// <summary>
    ///     Gets the name.
    /// </summary>
    /// <value>The name.</value>
    public string Name { get; }

    /// <summary>
    ///     Gets the description.
    /// </summary>
    /// <value>The description.</value>
    public string Description { get; }

    /// <inheritdoc />
    public bool Equals(UsageType? other) =>
        other is not null &&
        (ReferenceEquals(this, other) || UsageTypes == other.UsageTypes);

    /// <inheritdoc />
    public override bool Equals(object? obj) =>
        ReferenceEquals(this, obj) || (obj is UsageType other && Equals(other));

    /// <inheritdoc />
    public override int GetHashCode() => (int)UsageTypes;

    /// <summary>
    ///     Implements the == operator.
    /// </summary>
    /// <param name="left">The left.</param>
    /// <param name="right">The right.</param>
    /// <returns>The result of the operator.</returns>
    public static bool operator ==(UsageType? left, UsageType? right) => Equals(left, right);

    /// <summary>
    ///     Implements the != operator.
    /// </summary>
    /// <param name="left">The left.</param>
    /// <param name="right">The right.</param>
    /// <returns>The result of the operator.</returns>
    public static bool operator !=(UsageType? left, UsageType? right) => !Equals(left, right);

    /// <summary>
    ///     Gets the specified usage types from the flag enum.
    /// </summary>
    /// <param name="usageTypes">The usage types.</param>
    /// <returns>A collection of <seealso cref="UsageType" />.</returns>
    public static IReadOnlyCollection<UsageType> Get(UsageTypes usageTypes)
        => usageTypes > UsageTypes.None
            ? s_usageTypes.GetOrAdd(
                usageTypes,
                u =>
                    Enum.GetValues(typeof(UsageTypes)).Cast<UsageTypes>()
                        .Where(flag => flag != 0 && (u & flag) != 0)
                        .Select(ut =>
                            s_usageTypes.TryGetValue(ut, out var usageType) ? usageType.SingleOrDefault() : null!)
                        .Where(ut => ut != null)
                        .ToArray())
            : Array.Empty<UsageType>();

    /// <summary>
    ///     Performs an implicit conversion from <see cref="UsageType" /> to <see cref="UsageTypes" />.
    /// </summary>
    /// <param name="usageType">Type of the usage.</param>
    /// <returns>The result of the conversion.</returns>
    public static implicit operator UsageTypes(UsageType usageType) => usageType.UsageTypes;

    /// <inheritdoc />
    public override string ToString() => Name;
}
