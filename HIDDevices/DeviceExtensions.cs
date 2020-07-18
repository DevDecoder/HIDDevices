// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reactive.Linq;
using DynamicData;
using HIDDevices.Controllers;

namespace HIDDevices
{
    /// <summary>
    ///     Class DeviceExtensions implements various extension methods.
    /// </summary>
    public static class DeviceExtensions
    {
        /// <summary>
        ///     Gets a filtered observable of controllers of the <see cref="T">specified type</see>
        /// </summary>
        /// <typeparam name="T">The controller type.</typeparam>
        /// <param name="devices">The devices collection.</param>
        /// <param name="predicate">The optional predicate to filter controllers.</param>
        /// <returns>An observable of controllers.</returns>
        public static IObservable<T> Controllers<T>(this Devices devices, Func<T, bool>? predicate = null)
            where T : Controller
            => devices.Connect()
                .Flatten()
                .Where(change => change.Reason == ChangeReason.Add)
                .Select(change => change.Current)
                .Select(HIDDevices.Controllers.Controller.Create<T>)
                .Where(controller => controller != null && (predicate is null || predicate(controller)));

        /// <summary>
        ///     Gets a filtered observable of controllers of the <see cref="controllerType">specified type</see>
        /// </summary>
        /// <param name="devices">The devices collection.</param>
        /// <param name="controllerType">Type of the controller.</param>
        /// <param name="predicate">The optional predicate to filter controllers.</param>
        /// <returns>An observable of controllers.</returns>
        public static IObservable<Controller> Controllers(this Devices devices, Type controllerType,
            Func<Controller, bool>? predicate = null)
            => devices.Connect()
                .Flatten()
                .Where(change => change.Reason == ChangeReason.Add)
                .Select(change => change.Current)
                .Select(device => HIDDevices.Controllers.Controller.Create(device, controllerType)!)
                .Where(controller => controller != null && (predicate is null || predicate(controller)));

        /// <summary>
        ///     Gets a filtered observable of control changes.
        /// </summary>
        /// <param name="devices">The device collection.</param>
        /// <param name="predicate">
        ///     A function that returns <see langword="true" /> if the control should be monitored for changes;
        ///     otherwise <see langword="false" />.
        /// </param>
        /// <returns>A filtered observable of control changes.</returns>
        public static IObservable<IList<ControlChange>> ControlChanges(
            this Devices devices,
            Func<Control, bool>? predicate = null)
            => devices
                .Connect()
                .SelectMany(cs => cs)
                .Where(c => c.Reason != ChangeReason.Remove && (predicate is null || c.Current.Keys.Any(predicate)))
                .Select(c => c.Current)
                .SelectMany(c => c.Watch(predicate)
                    // Suppress errors so we don't stop listening on valid controllers - error will already have been logged.
                    .Catch((Exception _) => Observable.Empty<IList<ControlChange>>()))
                .Where(l => l.Count > 0);

        /// <summary>
        ///     Filters devices, such that the device must implement all supplied <see cref="usages" />.
        /// </summary>
        /// <param name="devices">The device collection.</param>
        /// <param name="usages">The required device usages.</param>
        /// <returns>A filtered observable of device change sets.</returns>
        public static IObservable<IChangeSet<Device, string>> DeviceUsagesAll(
            this Devices devices,
            params Usage[] usages)
            => devices.Connect(device => device.Usages.ContainsAll(usages));

        /// <summary>
        ///     Filters devices, such that the device must implement at least one of the supplied <see cref="usages" />.
        /// </summary>
        /// <param name="devices">The device collection.</param>
        /// <param name="usages">The required device usages.</param>
        /// <returns>A filtered observable of device change sets.</returns>
        public static IObservable<IChangeSet<Device, string>> DeviceUsagesAny(
            this Devices devices,
            params Usage[] usages)
            => devices.Connect(device => usages.Any(usage => device.Usages.Contains(usage)));

        /// <summary>
        ///     Filters devices, such that the device must have controls that implement all supplied <see cref="usages" />.
        /// </summary>
        /// <param name="devices">The device collection.</param>
        /// <param name="usages">The required device usages.</param>
        /// <returns>A filtered observable of device change sets.</returns>
        public static IObservable<IChangeSet<Device, string>> ControlUsagesAll(
            this Devices devices,
            params Usage[] usages)
            => devices.Connect(device =>
                usages.All(usage => device.Controls.Any(control => control.Usages.Contains(usage))));

        /// <summary>
        ///     Filters devices, such that the device must have controls that implement at least one of the supplied
        ///     <see cref="usages" />.
        /// </summary>
        /// <param name="devices">The device collection.</param>
        /// <param name="usages">The required device usages.</param>
        /// <returns>A filtered observable of device change sets.</returns>
        public static IObservable<IChangeSet<Device, string>> ControlUsagesAny(
            this Devices devices,
            params Usage[] usages)
            => devices.Connect(device =>
                usages.Any(usage => device.Controls.Any(control => control.Usages.Contains(usage))));

        /// <summary>
        ///     Creates a controller of the <see cref="T">specified type</see> from the <see cref="device">specified device</see>,
        ///     if possible.
        /// </summary>
        /// <typeparam name="T">The controller type</typeparam>
        /// <param name="device">The device.</param>
        /// <returns>
        ///     A controller of the <see cref="T">specified type</see>; otherwise <see langword="null" /> if the
        ///     <see cref="device">specified device</see> does not support the specified controller.
        /// </returns>
        [return: MaybeNull]
        public static T Controller<T>(this Device device) where T : Controller =>
            HIDDevices.Controllers.Controller.Create<T>(device);

        /// <summary>
        ///     Creates a controller of the <see cref="controllerType">specified type</see> from the
        ///     <see cref="device">specified device</see>, if possible.
        /// </summary>
        /// <param name="device">The device.</param>
        /// <param name="controllerType">Type of the controller.</param>
        /// <returns>
        ///     A controller of the <see cref="controllerType">specified type</see>; otherwise <see langword="null" /> if the
        ///     <see cref="device">specified device</see> does not support the specified controller.
        /// </returns>
        public static Controller? Controller(this Device device, Type controllerType) =>
            HIDDevices.Controllers.Controller.Create(device, controllerType);

        /// <summary>
        ///     Determines whether the <see cref="enumerable" /> contains all the <see cref="items">specified items</see>.
        /// </summary>
        /// <typeparam name="T">The item type</typeparam>
        /// <param name="enumerable">The enumerable.</param>
        /// <param name="items">The items.</param>
        /// <returns>
        ///     <see langword="true" /> if the <see cref="enumerable" /> contains all the
        ///     <see cref="items">specified items</see>; otherwise, <see langword="false" />.
        /// </returns>
        public static bool ContainsAll<T>(this IEnumerable<T> enumerable, params T[] items)
            => enumerable.ContainsAll(null!, items);

        /// <summary>
        ///     Determines whether the <see cref="enumerable" /> contains all the <see cref="items">specified items</see>.
        /// </summary>
        /// <typeparam name="T">The item type</typeparam>
        /// <param name="enumerable">The enumerable.</param>
        /// <param name="comparer">The comparer.</param>
        /// <param name="items">The items.</param>
        /// <returns>
        ///     <see langword="true" /> if the <see cref="enumerable" /> contains all the
        ///     <see cref="items">specified items</see>; otherwise, <see langword="false" />.
        /// </returns>
        public static bool ContainsAll<T>(
            this IEnumerable<T> enumerable,
            IEqualityComparer<T> comparer,
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
