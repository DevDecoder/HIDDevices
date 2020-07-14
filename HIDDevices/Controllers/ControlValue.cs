// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

using System;
using System.Diagnostics;
using HIDDevices.Converters;

namespace HIDDevices.Controllers
{
    public readonly struct ControlValue : IEquatable<ControlValue>
    {
        internal ControlValue(ControlChange change, ControlInfo info, object? value)
        {
            Debug.Assert(ReferenceEquals(change.Control, info.Control));
            Change = change;
            Info = info;
            Value = value;
        }

        public Type Type => Info.Type;
        public string PropertyName => Info.PropertyName;
        public Control Control => Info.Control;
        public long Timestamp => Change.Timestamp;
        public TimeSpan Elapsed => Change.Elapsed;
        public IControlConverter? Converter => Info.Converter;

        public ControlChange Change { get; }
        public ControlInfo Info { get; }
        public object? Value { get; }

        /// <inheritdoc />
        public bool Equals(ControlValue other) =>
            Change.Equals(other.Change) && Info.Equals(other.Info) && Equals(Value, other.Value);

        /// <inheritdoc />
        public override bool Equals(object? obj) => obj is ControlValue other && Equals(other);

        /// <inheritdoc />
        public override int GetHashCode() => HashCode.Combine(Change, Info, Value);

        public static bool operator ==(ControlValue left, ControlValue right) => left.Equals(right);

        public static bool operator !=(ControlValue left, ControlValue right) => !left.Equals(right);
    }
}
