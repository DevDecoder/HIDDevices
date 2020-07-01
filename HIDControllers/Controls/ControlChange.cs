// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

namespace HIDControllers.Controls
{
    public class ControlChange
    {
        public ControlChange(Control control, double oldValue, double newValue)
        {
            Control = control;
            OldValue = oldValue;
            NewValue = newValue;
        }

        public Control Control { get; }
        public double OldValue { get; }
        public double NewValue { get; }

        /// <inheritdoc />
        public override string ToString() =>
            string.Format(Resources.ControlChange, Control.Controller, Control, OldValue, NewValue);
    }
}
