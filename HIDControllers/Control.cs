using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using HIDControllers.Pages;
using HidSharp.Reports;

namespace HIDControllers
{
    public class Control : IReadOnlyCollection<Usage>
    {
        public Controller Controller { get; }
        public int Index { get; }
        internal DataItem DataItem { get; }
        public string Name { get; }
        public string FullName { get; }
        public double InitialValue { get; }
        private readonly HashSet<Usage> _usages;

        private readonly int _minimumValue;
        private readonly int _maximumValue;

        /// <summary>
        /// Gets the button number, if a button; otherwise 0.
        /// </summary>
        public ushort ButtonNumber { get; }

        internal Control(Controller controller, DataValue value, int index)
        {
            Controller = controller;
            DataItem = value.DataItem;
            Index = index;
            _usages = new HashSet<Usage>(value.Usages.Select(Usage.Get));

            // Calculate minimum & maximum
            _minimumValue = DataItem.LogicalMinimum;
            _maximumValue = DataItem.LogicalMaximum;

            // Some items don't report their min/max, so we create based on bit-depth
            if (_maximumValue <= _minimumValue)
            {
                _minimumValue = 0;
                _maximumValue = (1 << DataItem.TotalBits) - 1;
            }

            // Make best effort guess at initial value.
            InitialValue = DataItem.HasNullState
                ? double.NaN
                : DataItem.IsRelative
                    ? 0D
                    : Normalise(_minimumValue + (int)Math.Floor((_maximumValue - _minimumValue) / 2D));

            // Calculate names
            Name = string.Join(", ", _usages.Select(u => u.Name));
            FullName = string.Join(", ", _usages.Select(u => u.FullName));

            // Calculate button number (if any)
            ButtonNumber = _usages.FirstOrDefault(u => u.Page == UsagePage.Button)?.Id ?? 0;
        }

        internal double Normalise(int value)
        {
            return value < _minimumValue || value > _maximumValue
                ? DataItem.HasNullState ? double.NaN : 0D
                : (value - _minimumValue) / (double)(_maximumValue - _minimumValue);
        }

        /// <inheritdoc />
        public IEnumerator<Usage> GetEnumerator() => _usages.GetEnumerator();

        /// <inheritdoc />
        public override string ToString() => FullName;

        /// <inheritdoc />
        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)_usages).GetEnumerator();

        /// <inheritdoc />
        public int Count => _usages.Count;

        public bool Contains(Usage usage) => _usages.Contains(usage);
    }
}
