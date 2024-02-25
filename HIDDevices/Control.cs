// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Linq;
using HidSharp.Reports;

#pragma warning disable 618

namespace DevDecoder.HIDDevices;

/// <summary>
///     Class Control represents a single control (e.g. Button, slider, joystick axis) on a <see cref="Device" />.
/// </summary>
public class Control
{
    private readonly int _maximumValue;

    private readonly int _minimumValue;
    private readonly HashSet<uint> _usages;

    internal Control(Device device, DataValue value, int index)
    {
        Device = device;
        DataItem = value.DataItem;
        Index = index;
        _usages = new HashSet<uint>(value.Usages);

        // Calculate minimum & maximum
        _minimumValue = DataItem.LogicalMinimum;
        _maximumValue = DataItem.LogicalMaximum;

        // Some items don't report their min/max, so we create based on bit-depth
        if (_maximumValue <= _minimumValue)
        {
            _minimumValue = 0;
            _maximumValue = (1 << DataItem.ElementBits) - 1;
        }
    }

    /// <summary>
    ///     Gets the associated device.
    /// </summary>
    /// <value>The associated device.</value>
    public Device Device { get; }

    /// <summary>
    ///     Gets the unique index for the control.
    /// </summary>
    /// <value>The index.</value>
    public int Index { get; }

    /// <summary>
    ///     OBSOLETE - May be deprecated in future releases.
    ///     Gets the underlying <see cref="HidSharp.Reports.DataItem">Data Item</see> from the HIDSharp library.
    /// </summary>
    /// <value>The data item.</value>
    [Obsolete("Please do not rely on references to HIDSharp which may be deprecated in future releases.")]
    public DataItem DataItem { get; }

    /// <summary>
    ///     Gets a value indicating whether this control has a boolean value (0 or 1).
    /// </summary>
    /// <value><see langword="true" /> if this control is boolean; otherwise, <see langword="false" />.</value>
    public bool IsBoolean => DataItem.IsBoolean;

    /// <summary>
    ///     Gets a value indicating whether this control has a null state (represented by <see cref="double.NaN" />).
    /// </summary>
    /// <value><see langword="true" /> if this control has null state; otherwise, <see langword="false" />.</value>
    public bool HasNullState => DataItem.HasNullState;

    /// <summary>
    ///     Gets a value indicating whether this control has a preferred state.
    /// </summary>
    /// <value><see langword="true" /> if this control has a preferred state; otherwise, <see langword="false" />.</value>
    public bool HasPreferredState => DataItem.HasPreferredState;

    /// <summary>
    ///     Gets the total bits (<see cref="ElementBits" /> * <see cref="ElementCount" />).
    /// </summary>
    /// <value>The total bits.</value>
    public int TotalBits => DataItem.TotalBits;

    /// <summary>
    ///     Gets the element count.
    /// </summary>
    /// <value>The element count.</value>
    public int ElementCount => DataItem.ElementCount;

    /// <summary>
    ///     Gets the element bits.
    /// </summary>
    /// <value>The element bits.</value>
    public int ElementBits => DataItem.ElementBits;

    /// <summary>
    ///     Gets a value indicating whether this control is an array.
    /// </summary>
    /// <value><see langword="true" /> if this control is an array; otherwise, <see langword="false" />.</value>
    public bool IsArray => DataItem.IsArray;

    /// <summary>
    ///     Gets a value indicating whether this control is variable.
    /// </summary>
    /// <value><see langword="true" /> if this control is variable; otherwise, <see langword="false" />.</value>
    public bool IsVariable => DataItem.IsVariable;

    /// <summary>
    ///     Gets a value indicating whether this control is constant.
    /// </summary>
    /// <value><see langword="true" /> if this control is constant; otherwise, <see langword="false" />.</value>
    public bool IsConstant => DataItem.IsConstant;

    /// <summary>
    ///     Gets a value indicating whether this control is absolute.
    /// </summary>
    /// <value><see langword="true" /> if this control is absolute; otherwise, <see langword="false" />.</value>
    public bool IsAbsolute => DataItem.IsAbsolute;

    /// <summary>
    ///     Gets a value indicating whether this control is relative.
    /// </summary>
    /// <value><see langword="true" /> if this control is relative; otherwise, <see langword="false" />.</value>
    public bool IsRelative => DataItem.IsRelative;

    /// <summary>
    ///     Gets a value indicating whether this control represents a push button.
    /// </summary>
    /// <value><see langword="true" /> if this control is a push button; otherwise, <see langword="false" />.</value>
    /// <remarks>A momentary button where 0 indicates not pressed and 1 indicates pressed.</remarks>
    public bool IsPushButton => DataItem.ExpectedUsageType == ExpectedUsageType.PushButton;

    /// <summary>
    ///     Gets a value indicating whether this control represents a toggle button.
    /// </summary>
    /// <value><see langword="true" /> if this control is a toggle button; otherwise, <see langword="false" />.</value>
    /// <remarks>Toggle buttons maintain their state. 0 indicates not pressed, 1 indicates pressed.</remarks>
    public bool IsToggleButton => DataItem.ExpectedUsageType == ExpectedUsageType.ToggleButton;

    /// <summary>
    ///     Gets a value indicating whether this control represents a one shot.
    /// </summary>
    /// <value><see langword="true" /> if this control is a one shot; otherwise, <see langword="false" />.</value>
    /// <remarks>A 0-to-1 transition should activate the one-shot function.</remarks>
    public bool IsOneShot => DataItem.ExpectedUsageType == ExpectedUsageType.OneShot;

    /// <summary>
    ///     Gets a value indicating whether this control represent and up/down button.
    /// </summary>
    /// <value><see langword="true" /> if this control is an up/down; otherwise, <see langword="false" />.</value>
    /// <remarks>A 0 means down and a 1 means up, otherwise the value should remain in between (0.5).</remarks>
    public bool IsUpDown => DataItem.ExpectedUsageType == ExpectedUsageType.UpDown;

    /// <summary>
    ///     Gets the usages.
    /// </summary>
    /// <value>The usages.</value>
    public IReadOnlyCollection<uint> Usages => _usages;

    internal double Normalise(int value) =>
        value < _minimumValue || value > _maximumValue
            ? DataItem.HasNullState ? double.NaN : 0D
            : (value - _minimumValue) / (double)(_maximumValue - _minimumValue);

    /// <inheritdoc />
    public override string ToString() => string.Join(' ', _usages.Select(u => $"0x{u:X8}"));
}
