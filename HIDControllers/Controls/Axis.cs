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
            DataItem = dataItem;
            Value = _lastReportedValue = double.NaN;

            // WORKAROUND - Some devices don't report their min/max, so we create based on bit-depth
            _minimum = dataItem.LogicalMinimum;
            _maximum = dataItem.LogicalMaximum;
            if (_maximum <= _minimum)
            {
                _minimum = 0;
                _maximum = (1 << dataItem.TotalBits) - 1;
            }

            Sensitivity = 0.01D; // TODO
        }

        /// <inheritdoc />
        public override IObservable<IList<ControlChange>> Changes => Controller.Changes
            .Select(l => l.Where(c => c.Control == this).ToList());

        public AxisType Type { get; }
        public DataItem DataItem { get; }
        public override string Name => Type.Name;
        public double Sensitivity { get; set; }
        public double Value { get; private set; }
        public bool IsBoolean => DataItem.IsBoolean;

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
            Value = f;
            var o = _lastReportedValue;
            if (double.IsNaN(o))
            {
                if (double.IsNaN(f))
                {
                    return null;
                }
            }
            else if (Math.Abs(f - _lastReportedValue) < Sensitivity)
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
