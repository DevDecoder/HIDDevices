// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

using System;
using System.Diagnostics;
using HidSharp.Reports;

namespace HIDControllers
{
    public readonly struct ControlChange : IEquatable<ControlChange>
    {
        internal ControlChange(Control control, (DataValue value, long timestamp) value) : this()
        {
            Control = control;
            PreviousValue = double.NaN;
            Value = Control.Normalise(value.value.GetLogicalValue());
            Timestamp = value.timestamp;
        }

        private ControlChange(Control control, double previousValue, double value, long timestamp) : this()
        {
            Control = control;
            PreviousValue = previousValue;
            Value = value;
            Timestamp = timestamp;
        }

        public Control Control { get; }
        public double PreviousValue { get; }
        public double Value { get; }
        public long Timestamp { get; }

        public TimeSpan Elapsed => TimeSpan.FromSeconds(
            (double)(Stopwatch.GetTimestamp() - Timestamp) / Stopwatch.Frequency);

        internal ControlChange? Update((DataValue value, long timestamp) value)
        {
            var normalisedValue = Control.Normalise(value.value.GetLogicalValue());
            return normalisedValue.Equals(Value)
                ? (ControlChange?)null
                : new ControlChange(Control, Value, normalisedValue, value.timestamp);
        }

        /// <inheritdoc />
        public bool Equals(ControlChange other)
            => ReferenceEquals(Control, other.Control) &&
               PreviousValue.Equals(other.PreviousValue) &&
               Value.Equals(other.Value);

        /// <inheritdoc />
        public override bool Equals(object? obj) => obj is ControlChange other && Equals(other);

        /// <inheritdoc />
        public override int GetHashCode() => HashCode.Combine(Control, PreviousValue, Value);

        public static bool operator ==(ControlChange left, ControlChange right) => left.Equals(right);

        public static bool operator !=(ControlChange left, ControlChange right) => !left.Equals(right);

        /// <summary>
        ///     Creates a change that simulates the current value having changed from <seealso cref="double.NaN" />.
        /// </summary>
        /// <returns></returns>
        internal ControlChange Reset() => new ControlChange(Control, double.NaN, Value, Timestamp);
    }
}
