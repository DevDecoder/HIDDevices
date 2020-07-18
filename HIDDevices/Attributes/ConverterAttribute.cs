// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Reflection;
using HIDDevices.Controllers;
using HIDDevices.Converters;

namespace HIDDevices
{
    /// <summary>
    ///     Class ConverterAttribute.
    ///     Attribute to attach to properties of <seealso cref="Controller" /> that also have at least one
    ///     <seealso cref="ControlAttribute" />,
    ///     to indicate how the raw control value should be converted to the property type.
    /// </summary>
    /// <seealso cref="Controller" />
    /// <seealso cref="ControlAttribute" />
    /// <seealso cref="Attribute" />
    [AttributeUsage(AttributeTargets.Property)]
    public sealed class ConverterAttribute : Attribute
    {
        private static readonly ConcurrentDictionary<Type, IControlConverter> s_converters =
            new ConcurrentDictionary<Type, IControlConverter>();

        /// <summary>
        ///     Initializes a new instance of the <see cref="ConverterAttribute" /> class.
        /// </summary>
        /// <param name="type">The type of the converter to use.</param>
        public ConverterAttribute(Type type) => Type = type;

        /// <summary>
        ///     Gets the type of the converter.
        /// </summary>
        /// <value>The type.</value>
        public Type Type { get; }

        internal IControlConverter GetInstance(Type returnType)
            => s_converters.GetOrAdd(Type, type =>
            {
                if (type.GetInterfaces().All(i => i != typeof(IControlConverter)))
                {
                    throw new InvalidOperationException(
                        $"The '{type}' type does not implement the {nameof(IControlConverter)} interface.");
                }

                // Optimisation, look for a static field called 'Instance' that returns an IControlConverter.
                var instanceFieldInfo = type.GetField("Instance", BindingFlags.Public | BindingFlags.Static);
                IControlConverter? converter = null;
                if (instanceFieldInfo != null &&
                    typeof(IControlConverter).IsAssignableFrom(instanceFieldInfo.FieldType))
                {
                    // Try to get the converter from the static instance
                    converter = instanceFieldInfo.GetValue(null) as IControlConverter;
                }

                // Otherwise, try to create a new instance of the type.
                converter ??= Activator.CreateInstance(type, true) as IControlConverter;

                // Create converter
                if (converter is null)
                {
                    throw new InvalidOperationException(
                        $"The '{type}' type does not implement the {nameof(IControlConverter)} interface.");
                }

                if (!returnType.IsAssignableFrom(converter.Type))
                {
                    throw new InvalidOperationException(
                        $"The '{type}' converter does not support conversion to the '{returnType}' type.");
                }

                return converter;
            });
    }
}
