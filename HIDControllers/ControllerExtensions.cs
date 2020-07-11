// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using HIDControllers.Devices;

namespace HIDControllers
{
    public static class ControllerExtensions
    {
        public static IEnumerable<Controller> Supports<T>(this Controllers controllers) where T : Device
            => controllers.All
                .Where(Device.Supports<T>);

        public static IEnumerable<Controller> Supports(this Controllers controllers, Type deviceType)
            => controllers.All
                .Where(controller => Device.Supports(controller, deviceType));

        public static IEnumerable<T> Connect<T>(this Controllers controllers) where T : Device
            => controllers.All
                .Select(controller => Device.Create<T>(controller)!)
                .Where(device => device != null);

        public static IEnumerable<Device> Connect(this Controllers controllers, Type deviceType)
            => controllers.All
                .Select(controller => Device.Create(controller, deviceType)!)
                .Where(device => device != null);

        [return: MaybeNull]
        public static T Connect<T>(this Controller controller) where T : Device => Device.Create<T>(controller);

        public static Device? Connect(this Controller controller, Type deviceType) => Device.Create(controller, deviceType);

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
