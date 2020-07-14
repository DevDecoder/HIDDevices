// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

using System;

namespace HIDDevices
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = true)]
    public sealed class UsageTypeAttribute : Attribute
    {
        internal UsageTypeAttribute(UsageTypeGroup usageTypeGroup) => UsageTypeGroup = usageTypeGroup;

        public UsageTypeGroup UsageTypeGroup { get; }
    }
}
