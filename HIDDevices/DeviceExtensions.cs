// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reactive.Linq;
using DynamicData;
using DynamicData.Alias;
using HIDDevices.Controllers;

namespace HIDDevices
{
    public static class DeviceExtensions
    {
        public static IObservable<T> Controller<T>(this Devices devices, Func<T, bool>? predicate = null)
            where T : Controller
            => devices.Connect()
                .Flatten()
                .Where(change => change.Reason == ChangeReason.Add)
                .Select(change => change.Current)
                .Select(Controllers.Controller.Create<T>)
                .Where(controller => controller != null && (predicate is null || predicate(controller)));

        public static IObservable<Controller> Controller(this Devices devices, Type controllerType,
            Func<Controller, bool>? predicate = null)
            => devices.Connect()
                .Flatten()
                .Where(change => change.Reason == ChangeReason.Add)
                .Select(change => change.Current)
                .Select(device => Controllers.Controller.Create(device, controllerType)!)
                .Where(controller => controller != null && (predicate is null || predicate(controller)));

        [return: MaybeNull]
        public static T Controller<T>(this Device device) where T : Controller => Controllers.Controller.Create<T>(device);

        public static Controller? Controller(this Device device, Type controllerType) =>
            Controllers.Controller.Create(device, controllerType);

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
