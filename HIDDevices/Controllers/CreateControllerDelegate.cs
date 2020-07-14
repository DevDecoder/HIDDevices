// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

using System.Diagnostics.CodeAnalysis;

namespace HIDDevices.Controllers
{
    [return: MaybeNull]
    public delegate T CreateControllerDelegate<out T>(Device device) where T : Controller?;
}
