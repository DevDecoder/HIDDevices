// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace HIDDevices
{
    public static class DeviceExtensions
    {
        public static IEnumerable<Device> Supports<T>(this Devices devices) where T : Controller
            => devices.All
                .Where(Controller.Supports<T>);

        public static IEnumerable<Device> Supports(this Devices devices, Type controllerType)
            => devices.All
                .Where(device => Controller.Supports(device, controllerType));

        public static IEnumerable<T> Connect<T>(this Devices controllers) where T : Controller
            => controllers.All
                .Select(device => Controller.Create<T>(device)!)
                .Where(controller => controller != null);

        public static IEnumerable<Controller> Connect(this Devices controllers, Type controllerType)
            => controllers.All
                .Select(device => Controller.Create(device, controllerType)!)
                .Where(controller => controller != null);

        [return: MaybeNull]
        public static T Connect<T>(this Device device) where T : Controller => Controller.Create<T>(device);

        public static Controller? Connect(this Device device, Type controllerType) => Controller.Create(device, controllerType);

        public static bool ContainsAll<T>(this IEnumerable<T> enumerable, params T[] items)
            => enumerable.ContainsAll(null!, items);

        public static bool ContainsAll<T>(this IEnumerable<T> enumerable, IEqualityComparer<T> comparer,
            params T[] items)
        {
            if (items.Length < 1)
            {
                return true;
            }

            if (items.Length < 2)
            {
                return enumerable.Contains(items[0], comparer);
            }

            var hashSet = new HashSet<T>(items, comparer);
            foreach (var item in enumerable)
            {
                hashSet.Remove(item);
                if (hashSet.Count < 1)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
