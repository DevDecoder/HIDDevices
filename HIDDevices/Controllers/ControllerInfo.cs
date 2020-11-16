// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;

namespace DevDecoder.HIDDevices.Controllers
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

                var deviceAttributes = (IReadOnlyList<DeviceAttribute>)type
                    .GetCustomAttributes(typeof(DeviceAttribute), true)
                    .OfType<DeviceAttribute>()
                    .ToArray();

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
                private static readonly ConcurrentDictionary<Type, TypeConverter?> s_converterCache =
                    new ConcurrentDictionary<Type, TypeConverter?>();

                public readonly IReadOnlyList<ControlAttribute> Controls;
                public readonly TypeConverter? Converter;
                public readonly bool IsRequired;
                public readonly Type ReturnType;

                public PropertyData(PropertyInfo propertyInfo)
                {
                    ReturnType = propertyInfo.PropertyType;

                    var converterType = propertyInfo.GetCustomAttributes(typeof(TypeConverterAttribute), true)
                        .OfType<TypeConverterAttribute>()
                        .Select(attribute => Type.GetType(attribute.ConverterTypeName))
                        .FirstOrDefault();

                    if (converterType != null)
                    {
                        Converter = s_converterCache.GetOrAdd(converterType, t =>
                        {
                            // Optimisation, look for a static field called 'Instance' that returns an IControlConverter.
                            var instanceFieldInfo =
                                t.GetField("Instance", BindingFlags.Public | BindingFlags.Static);
                            TypeConverter? typeConverter = null;
                            if (instanceFieldInfo != null &&
                                typeof(TypeConverter).IsAssignableFrom(instanceFieldInfo.FieldType))
                            {
                                // Try to get the converter from the static instance
                                typeConverter = instanceFieldInfo.GetValue(null) as TypeConverter;
                            }

                            // Otherwise, try to create a new instance of the type.
                            typeConverter ??= Activator.CreateInstance(t, true) as TypeConverter;
                            return typeConverter;
                        });

                        if (Converter?.CanConvertFrom(typeof(double)) != true)
                        {
                            Converter = null;
                        }
                    }

                    // If we don't have a converter get the default from type converter.
                    if (Converter is null)
                    {
                        Converter = TypeDescriptor.GetConverter(ReturnType);
                        if (Converter?.CanConvertFrom(typeof(double)) != true)
                        {
                            Converter = null;
                        }
                    }

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
