// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using HIDDevices.Converters;

namespace HIDDevices.Controllers
{
    public partial class Controller
    {
        private class ControllerInfo
        {
            private static readonly ConcurrentDictionary<Type, ControllerInfo> s_infos =
                new ConcurrentDictionary<Type, ControllerInfo>();

            private static readonly Type[] s_constructorTypes = {typeof(Device), typeof(ControlInfo[])};

            public readonly CreateControllerDelegate<Controller?> CreateController;

            private ControllerInfo(
                CreateControllerDelegate<Controller?> createControllerDelegate)
                => CreateController = createControllerDelegate;

            private ControllerInfo(
                ConstructorInfo constructor,
                IReadOnlyList<DeviceAttribute> deviceAttributes,
                IReadOnlyDictionary<string, PropertyData> propertyData)
                => CreateController = device =>
                {
                    var mapping = GetMapping(device, deviceAttributes, propertyData);
                    return mapping is null ||
                           !(constructor.Invoke(new object[] {device, mapping}) is Controller controller)
                        ? null
                        : controller;
                };

            // ReSharper disable once MemberHidesStaticFromOuterClass
            public static void Register(
                Type type,
                CreateControllerDelegate<Controller?> createControllerDelegate)
                => s_infos[type] = new ControllerInfo(createControllerDelegate);

            public static ControllerInfo? Get<T>() where T : Controller => Get(typeof(T));

            public static ControllerInfo Get(Type type)
            {
                if (s_infos.TryGetValue(type, out var controllerInfo))
                {
                    return controllerInfo;
                }

                if (!typeof(Controller).IsAssignableFrom(type))
                {
                    throw new ArgumentOutOfRangeException(nameof(type),
                        string.Format(Resources.ControllerInvalidType, type.Name, nameof(Controller)));
                }

                // Check for a valid constructor on the type
                var constructor = type.GetConstructor(
                    BindingFlags.CreateInstance | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic,
                    null,
                    s_constructorTypes,
                    null);

                if (constructor is null)
                {
                    throw new ArgumentOutOfRangeException(nameof(type),
                        string.Format(Resources.ControllerInvalidConstructor, type));
                }

                var deviceAttributes = (IReadOnlyList<DeviceAttribute>)(
                    // Only get device attributes if they're marked as required
                    type.GetCustomAttributes(typeof(RequiredAttribute), true)
                        .OfType<RequiredAttribute>()
                        .Any()
                        ? type.GetCustomAttributes(typeof(DeviceAttribute), true)
                            .OfType<DeviceAttribute>()
                            .ToArray()
                        : Array.Empty<DeviceAttribute>());

                // Grab all attributes on control properties
                var propertyData = (IReadOnlyDictionary<string, PropertyData>)type
                    .GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .ToDictionary(property => property.Name, property => new PropertyData(property));

                return s_infos.GetOrAdd(type, new ControllerInfo(constructor, deviceAttributes, propertyData));
            }

            private ControlInfo[]? GetMapping(
                Device device,
                IReadOnlyList<DeviceAttribute> deviceAttributes,
                IReadOnlyDictionary<string, PropertyData> controlPropertyAttributes)
            {
                // Confirm device matches
                if (!deviceAttributes.Any(da => da.Matches(device)))
                {
                    return null;
                }

                var controlCount = device.Count;
                var mapping = new List<ControlInfo>(controlCount);
                var controlScores = new Dictionary<Control, uint>(controlCount);
                foreach (var (propertyName, attributes) in controlPropertyAttributes)
                {
                    foreach (var control in device.Keys)
                    {
                        foreach (var controlAttribute in attributes.Controls.Where(controlAttribute =>
                            controlAttribute.Matches(control)))
                        {
                            if (!controlScores.TryGetValue(control, out var score))
                            {
                                score = 0;
                            }

                            controlScores[control] = score + controlAttribute.Weight;
                        }
                    }

                    var bestMatch = controlScores
                        .Where(kvp => kvp.Value > 0)
                        .OrderByDescending(kvp => kvp.Value)
                        .Select(kvp => kvp.Key)
                        .FirstOrDefault();

                    if (bestMatch != null)
                    {
                        mapping.Add(new ControlInfo(attributes.ReturnType, propertyName, bestMatch,
                            attributes.Converter));
                    }
                    else if (attributes.IsRequired)
                    {
                        // Required control missing
                        return null;
                    }

                    controlScores.Clear();
                }

                return mapping.ToArray();
            }

            private class PropertyData
            {
                public readonly IReadOnlyList<ControlAttribute> Controls;
                public readonly IControlConverter? Converter;
                public readonly bool IsRequired;
                public readonly Type ReturnType;

                public PropertyData(PropertyInfo propertyInfo)
                {
                    ReturnType = propertyInfo.PropertyType;

                    Converter = propertyInfo.GetCustomAttributes(typeof(ConverterAttribute), true)
                        .OfType<ConverterAttribute>()
                        .FirstOrDefault()
                        ?.GetInstance(ReturnType);
                    Controls = propertyInfo.GetCustomAttributes(typeof(ControlAttribute), true)
                        .OfType<ControlAttribute>()
                        .Where(a => a.Weight > 0)
                        .ToArray();
                    IsRequired = propertyInfo.GetCustomAttributes(typeof(RequiredAttribute), true)
                        .OfType<RequiredAttribute>()
                        .Any();
                }
            }
        }
    }
}
