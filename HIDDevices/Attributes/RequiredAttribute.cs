// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

using System;

namespace HIDDevices
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Class)]
    public sealed class RequiredAttribute : Attribute
    {
    }
}
