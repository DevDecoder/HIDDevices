// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace HIDDevices
{
    /// <summary>
    ///     Base class for all usage pages.
    /// </summary>
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

        public ushort Id { get; }
        public string Name { get; }

        /// <inheritdoc />
        IEnumerator<Usage> IEnumerable<Usage>.GetEnumerator() => Usages.Values.GetEnumerator();

        /// <inheritdoc />
        public IEnumerator GetEnumerator() => ((IEnumerable)Usages.Values).GetEnumerator();

        /// <inheritdoc />
        public bool Equals(UsagePage? other) => !(other is null) && (ReferenceEquals(this, other) || Id == other.Id);

        public static UsagePage Get(ushort id)
            => s_pages.TryGetValue(id, out var page)
                ? page
                : id < 0xFF00
                    ? new UsagePage(id, $"Reserved (0x{id:X2})")
                    : new UsagePage(id, $"Vendor-defined (0x{id:X2})");

        public static UsagePage Get(uint usage) => Get((ushort)(usage >> 16));

        public virtual Usage GetUsage(ushort id) =>
            Usages.TryGetValue(id, out var usage)
                ? usage
                : new Usage(this, id, $"Undefined (0x{id:X2})", UsageTypes.None);

        /// <inheritdoc />
        public override bool Equals(object? obj) =>
            ReferenceEquals(this, obj) || (obj is UsagePage other && Equals(other));

        /// <inheritdoc />
        public override int GetHashCode() => Id;

        public static bool operator ==(UsagePage? left, UsagePage? right) => Equals(left, right);

        public static bool operator !=(UsagePage? left, UsagePage? right) => !Equals(left, right);

        public static implicit operator ushort(UsagePage page) => page.Id;
        public static implicit operator UsagePage(ushort page) => Get(page);

        /// <inheritdoc />
        public override string ToString() => Name;
    }
}
