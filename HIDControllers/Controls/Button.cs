// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

using System;
using HidSharp.Reports;

namespace HIDControllers.Controls
{
    public sealed class Button : Axis
    {
        /// <inheritdoc />
#pragma warning disable IDE0051 // Remove unused private members
        private Button(AxisType type, Controller controller, DataItem dataItem) : base(type, controller, dataItem)
#pragma warning restore IDE0051 // Remove unused private members
        {
            if (!IsBoolean)
            {
                throw new NotSupportedException(string.Format(Resources.ButtonNotBoolean, Controller, Name));
            }

            Number = (int)type.Usage - 0x00090000;
            if (Number < 1 || Number > 255)
            {
                throw new ArgumentOutOfRangeException(nameof(type), type,
                    string.Format(Resources.ButtonNumberUnknown, Controller, Name));
            }
        }

        public bool IsPressed => Value > 0.5;

        public int Number { get; }
    }
}
