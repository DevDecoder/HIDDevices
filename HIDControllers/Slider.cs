// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

using HIDControllers.Controls;
using HidSharp.Reports;

namespace HIDControllers
{
    public sealed class Slider : Axis
    {
        /// <inheritdoc />
#pragma warning disable IDE0051 // Remove unused private members
        private Slider(AxisType type, Controller controller, DataItem dataItem) : base(type, controller, dataItem)
#pragma warning restore IDE0051 // Remove unused private members
        {
        }
    }
}
