// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Linq;

namespace HIDDevices
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    public sealed class ControlAttribute : Attribute
    {
        public ControlAttribute(params uint[] usages) => Usages = usages;

        public byte Weight { get; set; } = 1;

        /// <summary>
        ///     Gets a list of valid usages, of which the device must match all.
        /// </summary>
        /// <remarks>If alternative usages are to be supported, then multiple attributes can be added.</remarks>
        public IReadOnlyList<uint> Usages { get; }

        internal bool Matches(Control control) => Usages.All(usage => control.Usages.Contains((Usage)usage));
    }
}
