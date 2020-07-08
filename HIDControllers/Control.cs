using System.ComponentModel;
using HidSharp.Reports;

namespace HIDControllers
{
    public class Control
    {
        public Controller Controller { get; }
        public uint Usage { get; }
        public string Name { get; }
        public double InitialValue { get; }

        private readonly int _minimumValue;
        private readonly int _maximumValue;

        /// <summary>
        /// Gets the button number, if a button; otherwise 0.
        /// </summary>
        public ushort ButtonNumber { get; }

        public Control(Controller controller, DataItem dataItem, uint usage)
        {
            Controller = controller;
            Usage = usage;

            // TODO
            Name = usage.ToString("X");
            InitialValue = double.NaN;

            // Calculate minimum & maximum
            _minimumValue = dataItem.LogicalMinimum;
            _maximumValue = dataItem.LogicalMaximum;

            // Some items don't report their min/max, so we create based on bit-depth
            if (_maximumValue <= _minimumValue)
            {
                _minimumValue = 0;
                _maximumValue = (1 << dataItem.TotalBits) - 1;
            }

            // Calculate button number (if Button)
            var buttonNumber = (int)usage - 0x90000;
            if (buttonNumber < 0 || buttonNumber > ushort.MaxValue) buttonNumber = 0;
            ButtonNumber = (ushort)buttonNumber;
        }

        internal double Normalise(int value) => value < _minimumValue || value > _maximumValue
            ? double.NaN
            : (value - _minimumValue) / (double)(_maximumValue - _minimumValue);

        /// <inheritdoc />
        public override string ToString() => Name;
    }
}
