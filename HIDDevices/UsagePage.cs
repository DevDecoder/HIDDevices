// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace HIDDevices
{
    /// <summary>
    ///     Class UsagePage. This class cannot be inherited.
    ///     Implements the <see cref="IEnumerable{T}" /> interface.
    ///     Implements the <see cref="IEquatable{T}" /> interface.
    ///     Base class for a collection of Usages.
    /// </summary>
    /// <seealso cref="IEnumerable{T}" />
    /// <seealso cref="IEquatable{T}" />
    /// <see href="https://www.usb.org/document-library/hid-usage-tables-112" />
    public partial class UsagePage : IEnumerable<Usage>, IEquatable<UsagePage>
    {
        protected readonly IReadOnlyDictionary<ushort, Usage> Usages;

        protected UsagePage(ushort id, string name, params (ushort id, string name, UsageTypes types)[] usages)
        {
            Id = id;
            Name = name;
            Usages = usages.ToDictionary(
                tuple => tuple.id,
                tuple => new Usage(this, tuple.id, tuple.name, tuple.types));
        }

        /// <summary>
        ///     Gets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public ushort Id { get; }

        /// <summary>
        ///     Gets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; }

        /// <inheritdoc />
        IEnumerator<Usage> IEnumerable<Usage>.GetEnumerator() => Usages.Values.GetEnumerator();

        /// <inheritdoc />
        public IEnumerator GetEnumerator() => ((IEnumerable)Usages.Values).GetEnumerator();

        /// <inheritdoc />
        public bool Equals(UsagePage? other) => !(other is null) && (ReferenceEquals(this, other) || Id == other.Id);

        /// <summary>
        ///     Gets the usage with the <see cref="id">specified identifier</see>.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>UsagePage.</returns>
        public static UsagePage Get(ushort id)
            => s_pages.TryGetValue(id, out var page)
                ? page
                : id < 0xFF00
                    ? new UsagePage(id, $"Reserved (0x{id:X2})")
                    : new UsagePage(id, $"Vendor-defined (0x{id:X2})");

        /// <summary>
        ///     Gets the usage with the <see cref="usage">specified usage enum</see>.
        /// </summary>
        /// <param name="usage">The usage.</param>
        /// <returns>UsagePage.</returns>
        public static UsagePage Get(Enum usage) => Get((ushort)(Convert.ToUInt32(usage) >> 16));

        /// <summary>
        ///     Gets the usage with the <see cref="fullId">specified full identifier</see>.
        /// </summary>
        /// <param name="fullId">The full identifier.</param>
        /// <returns>UsagePage.</returns>
        public static UsagePage Get(uint fullId) => Get((ushort)(fullId >> 16));

        /// <summary>
        ///     Gets the usage from this page with the <see cref="id">specified identifier</see>.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Usage.</returns>
        public virtual Usage GetUsage(ushort id) =>
            Usages.TryGetValue(id, out var usage)
                ? usage
                : new Usage(this, id, $"Undefined (0x{id:X2})", UsageTypes.None);

        /// <inheritdoc />
        public override bool Equals(object? obj) =>
            ReferenceEquals(this, obj) || (obj is UsagePage other && Equals(other));

        /// <inheritdoc />
        public override int GetHashCode() => Id;

        /// <summary>
        ///     Implements the == operator.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(UsagePage? left, UsagePage? right) => Equals(left, right);

        /// <summary>
        ///     Implements the != operator.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(UsagePage? left, UsagePage? right) => !Equals(left, right);

        /// <summary>
        ///     Performs an implicit conversion from <see cref="UsagePage" /> to <see cref="System.UInt16" />.
        /// </summary>
        /// <param name="page">The page.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator ushort(UsagePage page) => page.Id;

        /// <summary>
        ///     Performs an implicit conversion from <see cref="System.UInt16" /> to <see cref="UsagePage" />.
        /// </summary>
        /// <param name="page">The page.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator UsagePage(ushort page) => Get(page);

        /// <summary>
        ///     Performs an implicit conversion from <see cref="Enum" /> to <see cref="UsagePage" />.
        /// </summary>
        /// <param name="page">The page.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator UsagePage(Enum page) => Get(page);

        /// <inheritdoc />
        public override string ToString() => Name;
    }
}
