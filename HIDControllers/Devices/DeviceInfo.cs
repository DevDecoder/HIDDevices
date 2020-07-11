// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace HIDControllers.Devices
{
    public partial class Device
    {
        private class DeviceInfo
        {
            private static readonly ConcurrentDictionary<Type, DeviceInfo> s_infos =
                new ConcurrentDictionary<Type, DeviceInfo>();

            public readonly CreateDeviceDelegate<Device> CreateDevice;
            public readonly SupportsDeviceDelegate SupportsDevice;

            private DeviceInfo(
                CreateDeviceDelegate<Device> createDeviceDelegate,
                SupportsDeviceDelegate? supportsDeviceDelegate = null)
            {
                CreateDevice = createDeviceDelegate;
                SupportsDevice = supportsDeviceDelegate ?? (controller => createDeviceDelegate(controller) != null);
            }

            public static void Register(
                Type type,
                CreateDeviceDelegate<Device> createDeviceDelegate,
                SupportsDeviceDelegate? supportsDeviceDelegate = null)
                => s_infos[type] = new DeviceInfo(createDeviceDelegate, supportsDeviceDelegate);

            public static DeviceInfo? Get<T>() where T : Device => Get(typeof(T));

            public static DeviceInfo? Get(Type type)
            {
                if (s_infos.TryGetValue(type, out var deviceInfo))
                {
                    return deviceInfo;
                }

                if (!type.IsAssignableFrom(typeof(Device)))
                {
                    return null;
                }

                var deviceUsages = type.GetCustomAttributes(typeof(DeviceAttribute), true)
                    .OfType<DeviceAttribute>()
                    .SelectMany(a => a.Usages.Select(usage => ((Usage)usage, a.Required)))
                    .ToArray();

                var controlUsages = type.GetProperties()
                    .Select(property => new KeyValuePair<string, IReadOnlyList<(Usage, bool Required)>>(
                        property.Name,
                        property.GetCustomAttributes(typeof(DeviceAttribute), true)
                            .OfType<DeviceAttribute>()
                            .SelectMany(a => a.Usages.Select(usage => (Usage: (Usage)usage, a.Required)))
                            .ToArray()))
                    .ToDictionary(keyValuePair => keyValuePair.Key, keyValuePair => keyValuePair.Value);

                throw new NotImplementedException();

                return s_infos.GetOrAdd(type, deviceInfo);
            }
        }
    }
}
