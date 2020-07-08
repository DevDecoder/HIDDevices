// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using HIDControllers.OLD;
using HIDControllers.Pages;
using HidSharp.Reports;

namespace HIDControllers
{
    /// <summary>
    /// Base class for all usage pages.
    /// </summary>
    public partial class UsagePage : IEquatable<UsagePage>
    {
        private static Dictionary<ushort, UsagePage> s_pages;
        
        protected readonly Dictionary<ushort, Usage> _usages = new Dictionary<ushort, Usage>();
        public ushort Id { get; }
        public string Name { get; }
        
        protected UsagePage(ushort id, string name, bool store = false)
        {
            Id = id;
            Name = name;
            s_pages ??= new Dictionary<ushort, UsagePage>();
            if (store)
                s_pages[id] = this;
        }

        public static UsagePage Get(ushort id)
            => s_pages.TryGetValue(id, out var page)
                ? page
                : id < 0xFF00
                    ? new UsagePage(id, $"Reserved (0x{id:X2})")
                    : new UsagePage(id, $"Vendor-defined (0x{id:X2})");

        public static UsagePage Get(uint usage) => Get((ushort)(usage >> 16));

        public virtual Usage GetUsage(ushort id) =>
            _usages.TryGetValue(id, out var usage)
                ? usage
                : new Usage(this, id, $"Undefined (0x{id:X2})");

        internal Usage Create(ushort id, string name) => _usages[id] = new Usage(this, id, name);

        /// <inheritdoc />
        public bool Equals(UsagePage? other) => !(other is null) && (ReferenceEquals(this, other) || Id == other.Id);

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
