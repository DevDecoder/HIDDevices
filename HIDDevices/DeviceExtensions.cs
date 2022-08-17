// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reactive.Linq;
using DevDecoder.HIDDevices.Controllers;
using DynamicData;

namespace DevDecoder.HIDDevices;

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
    public static IObservable<T> Controllers<T>(this IObservableCache<Device, string> devices,
        Func<T, bool>? predicate = null)
        where T : Controller
        => devices.Connect()
            .Flatten()
            .Where(change => change.Reason == ChangeReason.Add)
            .Select(change => change.Current)
#pragma warning disable CS8621 // Nullability of reference types in return type doesn't match the target delegate (possibly because of nullability attributes).
            .Select(HIDDevices.Controllers.Controller.Create<T>)
#pragma warning restore CS8621 // Nullability of reference types in return type doesn't match the target delegate (possibly because of nullability attributes).
            .Where(controller => controller != null && (predicate is null || predicate(controller)));

    /// <summary>
    ///     Gets a filtered observable of controllers of the <see cref="controllerType">specified type</see>
    /// </summary>
    /// <param name="devices">The devices collection.</param>
    /// <param name="controllerType">Type of the controller.</param>
    /// <param name="predicate">The optional predicate to filter controllers.</param>
    /// <returns>An observable of controllers.</returns>
    public static IObservable<Controller> Controllers(this IObservableCache<Device, string> devices,
        Type controllerType,
        Func<Controller, bool>? predicate = null)
        => devices.Connect()
            .Flatten()
            .Where(change => change.Reason == ChangeReason.Add)
            .Select(change => HIDDevices.Controllers.Controller.Create(change.Current, controllerType)!)
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
        this IObservableCache<Device, string> devices,
        Func<Control, bool>? predicate = null)
        => devices
            .Connect()
            .Flatten()
            .Where(change =>
                change.Reason != ChangeReason.Remove && (predicate is null || change.Current.Keys.Any(predicate)))
            .SelectMany(change => change.Current.Watch(predicate)
                // Suppress errors so we don't stop listening on valid controllers - error will already have been logged.
                .Catch((Exception _) => Observable.Empty<IList<ControlChange>>()))
            .Where(l => l.Count > 0);

    public static IObservable<IChangeSet<Device, string>> Connected(this IObservableCache<Device, string> devices,
        Func<Device, bool>? predicate = null)
        => ObservableChangeSet.Create<Device, string>(sourceCache
                    => devices.Connect(predicate)
                        .Flatten()
                        .SelectMany(change => change.Reason == ChangeReason.Remove
                            ? new[] {(device: change.Current, isConnected: false)}.ToObservable()
                            : change.Current.ConnectionState.Select(isConnected =>
                                (device: change.Current, isConnected)))
                        .Subscribe(tuple =>
                        {
                            if (tuple.isConnected)
                            {
                                sourceCache.AddOrUpdate(tuple.device);
                            }
                            else
                            {
                                sourceCache.Remove(tuple.device);
                            }
                        }),
                device => device.DevicePath)
            .AsObservableCache()
            .Connect();

    /// <summary>
    ///     Filters devices, such that the device must implement all supplied <see cref="usages" />.
    /// </summary>
    /// <param name="devices">The device collection.</param>
    /// <param name="usages">The required device usages.</param>
    /// <returns>A filtered observable of device change sets.</returns>
    public static IObservable<IChangeSet<Device, string>> DeviceUsagesAll(
        this IObservableCache<Device, string> devices,
        params Usage[] usages)
        => devices.Connect(device => device.UsagesAll(usages));

    /// <summary>
    ///     Filters devices, such that the device must implement at least one of the supplied <see cref="usages" />.
    /// </summary>
    /// <param name="devices">The device collection.</param>
    /// <param name="usages">The required device usages.</param>
    /// <returns>A filtered observable of device change sets.</returns>
    public static IObservable<IChangeSet<Device, string>> DeviceUsagesAny(
        this IObservableCache<Device, string> devices,
        params Usage[] usages)
        => devices.Connect(device => device.UsagesAny(usages));

    /// <summary>
    ///     Filters devices, such that the device must have controls that implement all supplied <see cref="usages" />.
    /// </summary>
    /// <param name="devices">The device collection.</param>
    /// <param name="usages">The required device usages.</param>
    /// <returns>A filtered observable of device change sets.</returns>
    public static IObservable<IChangeSet<Device, string>> ControlUsagesAll(
        this IObservableCache<Device, string> devices,
        params Usage[] usages)
        => devices.Connect(device => device.ControlUsagesAll(usages));

    /// <summary>
    ///     Filters devices, such that the device must have controls that implement at least one of the supplied
    ///     <see cref="usages" />.
    /// </summary>
    /// <param name="devices">The device collection.</param>
    /// <param name="usages">The required device usages.</param>
    /// <returns>A filtered observable of device change sets.</returns>
    public static IObservable<IChangeSet<Device, string>> ControlUsagesAny(
        this IObservableCache<Device, string> devices,
        params Usage[] usages)
        => devices.Connect(device => device.ControlUsagesAny(usages));

    /// <summary>
    ///     Checks that the device implements all supplied <see cref="usages" />.
    /// </summary>
    /// <param name="device">The device.</param>
    /// <param name="usages">The required device usages.</param>
    /// <returns>
    ///     <see langword="true" /> if the specified device implements all the supplied usages; otherwise
    ///     <see langword="false" />.
    /// </returns>
    public static bool UsagesAll(
        this Device device,
        params Usage[] usages)
        => device.Usages.ContainsAll(usages);

    /// <summary>
    ///     Checks that the device implements at least one of the supplied <see cref="usages" />.
    /// </summary>
    /// <param name="device">The device.</param>
    /// <param name="usages">The required device usages.</param>
    /// <returns>
    ///     <see langword="true" /> if the specified device implements at least one of the supplied usages; otherwise
    ///     <see langword="false" />.
    /// </returns>
    public static bool UsagesAny(
        this Device device,
        params Usage[] usages)
        => usages.Any(usage => device.Usages.Contains(usage));

    /// <summary>
    ///     Checks that the device has controls that implement all the supplied <see cref="usages" />.
    /// </summary>
    /// <param name="device">The device.</param>
    /// <param name="usages">The required device usages.</param>
    /// <returns>
    ///     <see langword="true" /> if the specified device has controls that implement all the supplied usages; otherwise
    ///     <see langword="false" />.
    /// </returns>
    public static bool ControlUsagesAll(
        this Device device,
        params Usage[] usages)
        => usages.All(usage => device.Controls.Any(control => control.Usages.Contains(usage)));

    /// <summary>
    ///     Checks that the device has controls that implement at least one of the supplied
    ///     <see cref="usages" />.
    /// </summary>
    /// <param name="device">The device.</param>
    /// <param name="usages">The required device usages.</param>
    /// <returns>
    ///     <see langword="true" /> if the specified device has controls that implement at least one of the supplied
    ///     usages; otherwise <see langword="false" />.
    /// </returns>
    public static bool ControlUsagesAny(
        this Device device,
        params Usage[] usages)
        => usages.Any(usage => device.Controls.Any(control => control.Usages.Contains(usage)));

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
