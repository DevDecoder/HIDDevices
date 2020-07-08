using System;
using HidSharp.Reports;

namespace HIDControllers
{
    public readonly struct ControlChange : IEquatable<ControlChange>
    {
        internal ControlChange(Control control) : this()
        {
            Control = control;
            PreviousValue = double.NaN;
            Value = control.InitialValue;
        }

        private ControlChange(Control control, double previousValue, double value) : this()
        {
            Control = control;
            PreviousValue = previousValue;
            Value = value;
        }

        public Control Control { get; }
        public double PreviousValue { get; }
        public double Value { get; }

        internal ControlChange? Update(DataValue value)
        {
            var normalisedValue = Control.Normalise(value.GetLogicalValue());
            return normalisedValue.Equals(Value)
                ? (ControlChange?)null
                : new ControlChange(Control, Value, normalisedValue);
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
        /// Creates a change that simulates the current value having changed from <seealso cref="double.NaN"/>.
        /// </summary>
        /// <returns></returns>
        internal ControlChange Reset() => new ControlChange(Control, double.NaN, Value);
    }
}
