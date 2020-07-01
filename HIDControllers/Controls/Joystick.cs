// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace HIDControllers.Controls
{
    public sealed class Joystick : Control
    {
#pragma warning disable IDE0051 // Remove unused private members
        private Joystick(Axis[] axes)
#pragma warning restore IDE0051 // Remove unused private members
            : base(axes[0].Controller)
        {
            XAxis = axes[0];
            YAxis = axes[1];
            Name = $"Joystick ({XAxis}, {YAxis})";
        }

        /// <inheritdoc />
        /// <inheritdoc />
        public override IObservable<IList<ControlChange>> Changes => Controller.Changes
            .Select(l => l
                .Where(c => c.Control.Equals(XAxis) || c.Control.Equals(YAxis)).ToList());

        public Axis XAxis { get; }
        public Axis YAxis { get; }

        public double X => XAxis.Value;
        public double Y => YAxis.Value;

        /// <inheritdoc />
        public override int Count => 2;

        /// <inheritdoc />
        public override Axis this[int index] =>
            index == 0
                ? XAxis
                : index == 1
                    ? YAxis
                    : throw new IndexOutOfRangeException();

        /// <inheritdoc />
        public override string Name { get; }

        /// <inheritdoc />
        public override IEnumerator<Axis> GetEnumerator()
        {
            yield return XAxis;
            yield return YAxis;
        }

        /// <inheritdoc />
        public override string ToString() => Name;
    }
}
