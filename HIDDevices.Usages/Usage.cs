// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;

namespace DevDecoder.HIDDevices;

/// <summary>
///     Class Usage. This class cannot be inherited.
///     Implements the <see cref="IEquatable{T}" /> interface.
///     A HID Usage.
/// </summary>
/// <seealso cref="IEquatable{T}" />
/// <see href="https://www.usb.org/document-library/hid-usage-tables-112" />
public sealed class Usage : IEquatable<Usage>
{
    internal Usage(UsagePage page, ushort id, string name, UsageTypes types)
    {
        Page = page;
        Id = id;
        Name = name;
        Types = UsageType.Get(types);
    }

    /// <summary>
    ///     Gets the page.
    /// </summary>
    /// <value>The page.</value>
    public UsagePage Page { get; }

    /// <summary>
    ///     Gets the identifier.
    /// </summary>
    /// <value>The identifier.</value>
    public ushort Id { get; }

    /// <summary>
    ///     Gets the full identifier (includes the <see cref="Page" /> <see cref="UsagePage.Id" />).
    /// </summary>
    /// <value>The full identifier.</value>
    public uint FullId => (uint)((Page.Id << 16) + Id);

    /// <summary>
    ///     Gets the name.
    /// </summary>
    /// <value>The name.</value>
    public string Name { get; }

    /// <summary>
    ///     Gets the full name (includes the <see cref="Page" /> <see cref="UsagePage.Name" />).
    /// </summary>
    /// <value>The full name.</value>
    public string FullName => $"{Page.Name}: {Name}";

    /// <summary>
    ///     Gets the types.
    /// </summary>
    /// <value>The types.</value>
    public IReadOnlyCollection<UsageType> Types { get; }

    /// <inheritdoc />
    public bool Equals(Usage? other) =>
        other is not null &&
        (ReferenceEquals(this, other) || (Page.Equals(other.Page) && Id == other.Id));

    /// <summary>
    ///     Gets the usage with the <see cref="usage">specified usage enum</see>.
    /// </summary>
    /// <param name="usage">The usage enum.</param>
    /// <returns>Usage.</returns>
    public static Usage Get(Enum usage) => Get(Convert.ToUInt32(usage));

    /// <summary>
    ///     Gets the usage with the <see cref="fullId">specified full identifier</see>.
    /// </summary>
    /// <param name="fullId">The full identifier.</param>
    /// <returns>Usage.</returns>
    public static Usage Get(uint fullId) => UsagePage.Get(fullId).GetUsage((ushort)(fullId & 0xFFFF));

    /// <summary>
    ///     Implements the == operator.
    /// </summary>
    /// <param name="left">The left.</param>
    /// <param name="right">The right.</param>
    /// <returns>The result of the operator.</returns>
    public static bool operator ==(Usage? left, Usage? right) => Equals(left, right);

    /// <summary>
    ///     Implements the != operator.
    /// </summary>
    /// <param name="left">The left.</param>
    /// <param name="right">The right.</param>
    /// <returns>The result of the operator.</returns>
    public static bool operator !=(Usage? left, Usage? right) => !Equals(left, right);

    /// <summary>
    ///     Performs an implicit conversion from <see cref="Usage" /> to <see cref="uint" />.
    /// </summary>
    /// <param name="usage">The usage.</param>
    /// <returns>The result of the conversion.</returns>
    public static implicit operator uint(Usage usage) => usage.FullId;

    /// <summary>
    ///     Performs an implicit conversion from <see cref="uint" /> to <see cref="Usage" />.
    /// </summary>
    /// <param name="usage">The usage.</param>
    /// <returns>The result of the conversion.</returns>
    public static implicit operator Usage(uint usage) => Get(usage);

    /// <summary>
    ///     Performs an implicit conversion from <see cref="Enum" /> to <see cref="Usage" />.
    /// </summary>
    /// <param name="usage">The usage.</param>
    /// <returns>The result of the conversion.</returns>
    public static implicit operator Usage(Enum usage) => Get(usage);

    /// <inheritdoc />
    public override bool Equals(object? obj) => ReferenceEquals(this, obj) || (obj is Usage other && Equals(other));

    /// <inheritdoc />
    public override int GetHashCode() => HashCode.Combine(Page, Id);

    /// <inheritdoc />
    public override string ToString() => $"{Page} - {Name}";
}
