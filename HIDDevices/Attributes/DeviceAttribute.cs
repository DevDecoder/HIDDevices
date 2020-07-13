// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;

namespace HIDDevices
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public sealed class DeviceAttribute : Attribute
    {
        public DeviceAttribute(params uint[] usages) => Usages = usages;

        public IReadOnlyList<uint> Usages { get; }

        public bool Required { get; set; }

        public int ProductId { get; set; }
        public string? VersionRegex { get; set; }
    }
}
