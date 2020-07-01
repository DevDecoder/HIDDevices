// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

using System;
using HidSharp.Reports;

namespace HIDControllers.Controls
{
    public sealed class Hat : Axis
    {
        /// <inheritdoc />
#pragma warning disable IDE0051 // Remove unused private members
        private Hat(AxisType type, Controller controller, DataItem dataItem) : base(type, controller, dataItem)
#pragma warning restore IDE0051 // Remove unused private members
        {
            if ((dataItem.Flags & DataItemFlags.NullState) == 0)
            {
                throw new NotSupportedException(string.Format(Resources.HatNotNullable, controller));
            }
        }

        public bool IsPressed => !double.IsNaN(Value);

        public Direction Direction
        {
            get
            {
                var v = Value;
                return double.IsNaN(v)
                    ? Direction.NotPressed
                    : (Direction)Math.Clamp((int)Math.Round(Value * 7.0), 0, 7);
            }
        }
    }
}
