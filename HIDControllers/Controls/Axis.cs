// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using HidSharp.Reports;

namespace HIDControllers.Controls
{
    public class Axis : Control
    {
        private readonly int _maximum;

        private readonly int _minimum;

        private double _lastReportedValue;

        protected Axis(AxisType type, Controller controller, DataItem dataItem)
            : base(controller)
        {
            Type = type;
            _dataItem = dataItem;
            Value = _lastReportedValue = type.InitialValue;

            // WORKAROUND - Some devices don't report their min/max, so we create based on bit-depth
            _minimum = dataItem.LogicalMinimum;
            _maximum = dataItem.LogicalMaximum;
            if (_maximum <= _minimum)
            {
                _minimum = 0;
                _maximum = (1 << dataItem.TotalBits) - 1;
            }

            _sensitivity = type.Sensitivity;
            _deadZone = type.DeadZone;
        }

        /// <inheritdoc />
        public override IObservable<IList<ControlChange>> Changes => Controller.Changes
            .Select(l => l.Where(c => c.Control == this).ToList());

        public AxisType Type { get; }
        private readonly DataItem _dataItem;
        public override string Name => Type.Name;
        private int _sensitivity;

        public int Sensitivity
        {
            get => _sensitivity;
            set
            {
                if (value < 0 || value > 15)
                    throw new ArgumentOutOfRangeException(nameof(value), value, Resources.InvalidSensitivity);
                _sensitivity = value;
            }
        }

        private double _deadZone;

        public double DeadZone
        {
            get => _deadZone;
            set
            {
                if (value < 0D || value > 1D)
                    throw new ArgumentOutOfRangeException(nameof(value), value, Resources.InvalidDeadZone);
                _deadZone = value;
            }
        }

        public double Value { get; private set; }
        public bool IsBoolean => _dataItem.IsBoolean;

        /// <inheritdoc />
        public override int Count => 1;

        /// <inheritdoc />
        public override Axis this[int index] => index != 0 ? throw new IndexOutOfRangeException() : this;

        internal ControlChange? Set(DataValue value)
        {
            var v = value.GetLogicalValue();
            var f = v < _minimum || v > _maximum
                ? double.NaN
                : (v - _minimum) / (double)(_maximum - _minimum);

            // Adjust value based on dead zone or sensitivity.
            var dz = _deadZone;
            if (dz > 0 && Math.Abs(f - 0.5D) < dz) f = 0.5D;
            else f = Math.Round(f, Sensitivity);

            Value = f;
            var o = _lastReportedValue;
            if (double.IsNaN(o))
            {
                if (double.IsNaN(f))
                {
                    return null;
                }
            }
            else if (Math.Abs(f - o) < double.Epsilon)
            {
                return null;
            }

            _lastReportedValue = f;
            return new ControlChange(this, o, f);
        }

        /// <inheritdoc />
        public override IEnumerator<Axis> GetEnumerator()
        {
            yield return this;
        }

        /// <inheritdoc />
        public override string ToString() => Type.Name;
    }
}
