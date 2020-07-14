// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

using System;
using System.Diagnostics.CodeAnalysis;

namespace HIDDevices.Converters
{
    public interface IControlConverter
    {
        Type Type { get; }
        object? ConvertTo(double value);
    }

    public interface IControlConverter<out T> : IControlConverter
    {
        Type IControlConverter.Type => typeof(T);
        object? IControlConverter.ConvertTo(double value) => ConvertTo(value);

        [return: MaybeNull]
        new T ConvertTo(double value);
    }
}
