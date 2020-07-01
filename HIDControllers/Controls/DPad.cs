// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace HIDControllers.Controls
{
    /// <summary>
    ///     Class DPad. This class cannot be inherited.
    ///     Implements the <see cref="Control" />
    /// </summary>
    /// <seealso cref="Control" />
    public sealed class DPad : Control
    {
#pragma warning disable IDE0051 // Remove unused private members
        private DPad(Axis[] axes)
#pragma warning restore IDE0051 // Remove unused private members
            : base(axes[0].Controller)
        {
            UpAxis = axes[0];
            RightAxis = axes[1];
            DownAxis = axes[2];
            LeftAxis = axes[3];
            Name = $"DPad ({UpAxis}, {RightAxis}, {DownAxis}, {LeftAxis})";
        }

        /// <inheritdoc />
        public override IObservable<IList<ControlChange>> Changes => Controller.Changes
            .Select(l => l
                .Where(c => c.Control.Equals(UpAxis) || c.Control.Equals(RightAxis) ||
                            c.Control.Equals(DownAxis) || c.Control.Equals(LeftAxis)).ToList());

        public Axis UpAxis { get; }
        public Axis RightAxis { get; }
        public Axis DownAxis { get; }
        public Axis LeftAxis { get; }

        public bool IsUpPressed => UpAxis.Value > 0.5D;

        public bool IsRightPressed => RightAxis.Value > 0.5D;
        public bool IsDownPressed => DownAxis.Value > 0.5D;

        public bool IsLeftPressed => LeftAxis.Value > 0.5D;

        public bool IsPressed => IsUpPressed || IsRightPressed || IsDownPressed || IsLeftPressed;

        public Direction Direction
        {
            get
            {
                if (IsUpPressed)
                {
                    if (IsRightPressed)
                    {
                        return Direction.NorthEast;
                    }

                    if (IsLeftPressed)
                    {
                        return Direction.NorthWest;
                    }

                    return Direction.North;
                }

                if (IsDownPressed)
                {
                    if (IsRightPressed)
                    {
                        return Direction.SouthEast;
                    }

                    if (IsLeftPressed)
                    {
                        return Direction.SouthWest;
                    }

                    return Direction.South;
                }

                if (IsRightPressed)
                {
                    return Direction.East;
                }

                if (IsLeftPressed)
                {
                    return Direction.West;
                }

                return Direction.NotPressed;
            }
        }

        /// <inheritdoc />
        public override int Count => 4;

        /// <inheritdoc />
        public override Axis this[int index]
            => index switch
            {
                0 => UpAxis,
                1 => RightAxis,
                2 => DownAxis,
                3 => LeftAxis,
                _ => throw new IndexOutOfRangeException()
            };

        /// <inheritdoc />
        public override string Name { get; }

        /// <inheritdoc />
        public override IEnumerator<Axis> GetEnumerator()
        {
            yield return UpAxis;
            yield return RightAxis;
            yield return DownAxis;
            yield return LeftAxis;
        }

        /// <inheritdoc />
        public override string ToString() => Name;
    }
}
