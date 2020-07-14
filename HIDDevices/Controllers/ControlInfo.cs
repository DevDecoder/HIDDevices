// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

using System;
using HIDDevices.Converters;

namespace HIDDevices.Controllers
{
    public class ControlInfo
    {
        public ControlInfo(Type type, string propertyName, Control control, IControlConverter? converter)
        {
            Type = type;
            PropertyName = propertyName;
            Control = control;
            Converter = converter;
        }

        public Type Type { get; }
        public string PropertyName { get; }
        public Control Control { get; }
        public IControlConverter? Converter { get; }
    }

    public sealed class ControlInfo<T> : ControlInfo
    {
        public ControlInfo(string propertyName, Control control, IControlConverter? converter)
            : base(typeof(T), propertyName, control, converter)
        {
        }
    }
}
