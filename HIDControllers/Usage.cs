// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

using System;

namespace HIDControllers
{
    public sealed class Usage : IEquatable<Usage>
    {
        internal Usage(UsagePage page, ushort id, string name)
        {
            Page = page;
            Id = id;
            Name = name;
        }

        public UsagePage Page { get; }
        public ushort Id { get; }
        public uint FullId => (uint)((Page.Id << 16) + Id);
        public string Name { get; }
        public string FullName => $"{Page.Name}: {Name}";

        public static Usage Get(uint id) => UsagePage.Get(id).GetUsage((ushort)(id & 0xFFFF));


        public static bool operator ==(Usage? left, Usage? right) => Equals(left, right);

        public static bool operator !=(Usage? left, Usage? right) => !Equals(left, right);

        public static implicit operator uint(Usage usage) => usage.FullId;
        public static implicit operator Usage(uint usage) => Get(usage);

        /// <inheritdoc />
        public bool Equals(Usage? other) =>
            !(other is null) &&
            (ReferenceEquals(this, other) || (Page.Equals(other.Page) && Id == other.Id));

        /// <inheritdoc />
        public override bool Equals(object? obj) => ReferenceEquals(this, obj) || (obj is Usage other && Equals(other));

        /// <inheritdoc />
        public override int GetHashCode() => HashCode.Combine(Page, Id);

        /// <inheritdoc />
        public override string ToString() => $"{Page} - {Name}";
    }
}
