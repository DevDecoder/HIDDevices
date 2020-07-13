// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace HIDDevices
{
    public partial class Controller
    {
        private class ControllerInfo
        {
            private static readonly ConcurrentDictionary<Type, ControllerInfo> s_infos =
                new ConcurrentDictionary<Type, ControllerInfo>();

            public readonly CreateControllerDelegate<Controller> CreateController;
            public readonly SupportsControllerDelegate SupportsController;

            private ControllerInfo(
                CreateControllerDelegate<Controller> createControllerDelegate,
                SupportsControllerDelegate? supportsControllerDelegate = null)
            {
                CreateController = createControllerDelegate;
                SupportsController = supportsControllerDelegate ?? (controller => createControllerDelegate(controller) != null);
            }

            public static void Register(
                Type type,
                CreateControllerDelegate<Controller> createControllerDelegate,
                SupportsControllerDelegate? supportsDeviceDelegate = null)
                => s_infos[type] = new ControllerInfo(createControllerDelegate, supportsDeviceDelegate);

            public static ControllerInfo? Get<T>() where T : Controller => Get(typeof(T));

            public static ControllerInfo? Get(Type type)
            {
                if (s_infos.TryGetValue(type, out var deviceInfo))
                {
                    return deviceInfo;
                }

                if (!type.IsAssignableFrom(typeof(Controller)))
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
