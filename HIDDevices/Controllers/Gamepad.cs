// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using DevDecoder.HIDDevices.Converters;
using DevDecoder.HIDDevices.Usages;

namespace DevDecoder.HIDDevices.Controllers;

/// <summary>
///     Class Gamepad defines a GamePad <seealso cref="Controller" />.
/// </summary>
/// <seealso cref="Controller" />
[Device(GenericDesktopPage.Gamepad)]
public class Gamepad : Controller
{
    /// <inheritdoc />
    protected Gamepad(Device device, params ControlInfo[] controls)
        : base(device, controls)
    {
    }

    /// <summary>
    ///     Gets the x.
    /// </summary>
    /// <value>The x.</value>
    /// <remarks>Note: By convention, -1 indicates left, and 1 indicates right.</remarks>
    [Control(GenericDesktopPage.X)]
    [Required]
    [TypeConverter(typeof(SignedConverter))]
    public double X => GetValue<double>();

    /// <summary>
    ///     Gets the y.
    /// </summary>
    /// <value>The y.</value>
    /// <remarks>Note: By convention, -1 indicates up, and 1 indicates down.</remarks>
    [Control(GenericDesktopPage.Y)]
    [Required]
    [TypeConverter(typeof(SignedConverter))]
    public double Y => GetValue<double>();

    /// <summary>
    ///     Gets the rx.
    /// </summary>
    /// <value>The rx.</value>
    /// <remarks>Note: By convention, -1 indicates left, and 1 indicates right.</remarks>
    [Control(GenericDesktopPage.Rx)]
    [TypeConverter(typeof(SignedConverter))]
    public double Rx => GetValue<double>();

    /// <summary>
    ///     Gets the ry.
    /// </summary>
    /// <value>The ry.</value>
    /// <remarks>Note: By convention, -1 indicates up, and 1 indicates down.</remarks>
    [Control(GenericDesktopPage.Ry)]
    [TypeConverter(typeof(SignedConverter))]
    public double Ry => GetValue<double>();

    /// <summary>
    ///     Gets a value indicating whether this <see cref="Gamepad">gamepad's</see> start button is pressed.
    /// </summary>
    /// <value><see langword="true" /> if start is pressed; otherwise, <see langword="false" />.</value>
    [Control(GenericDesktopPage.Start, Weight = 2)]
    [Control(ButtonPage.Button7)]
    public bool Start => GetValue<bool>();

    /// <summary>
    ///     Gets a value indicating whether this <see cref="Gamepad">gamepad's</see> select button is pressed.
    /// </summary>
    /// <value><see langword="true" /> if select is pressed; otherwise, <see langword="false" />.</value>
    [Control(GenericDesktopPage.Select, Weight = 2)]
    [Control(ButtonPage.Button6)]
    public bool Select => GetValue<bool>();

    /// <summary>
    ///     Gets the left trigger value.
    /// </summary>
    /// <value>The left trigger.</value>
    /// <remarks>Note: 0 indicates not pressed, and 1 indicates fully depressed.</remarks>
    [Control(GenericDesktopPage.Z)]
    [TypeConverter(typeof(LeftTriggerConverter))]
    public double LeftTrigger => GetValue<double>();

    /// <summary>
    ///     Gets the right trigger value.
    /// </summary>
    /// <value>The right trigger.</value>
    /// <remarks>Note: 0 indicates not pressed, and 1 indicates fully depressed.</remarks>
    [Control(GenericDesktopPage.Z)]
    [TypeConverter(typeof(RightTriggerConverter))]
    public double RightTrigger => GetValue<double>();

    /// <summary>
    ///     Gets a value indicating whether the A Button is pressed.
    /// </summary>
    /// <value><see langword="true" /> if A Button is pressed; otherwise, <see langword="false" />.</value>
    [Control(ButtonPage.Button0)]
    [Required]
    public bool AButton => GetValue<bool>();

    /// <summary>
    ///     Gets a value indicating whether the B Button is pressed.
    /// </summary>
    /// <value><see langword="true" /> if B Button is pressed; otherwise, <see langword="false" />.</value>
    [Control(ButtonPage.Button1)]
    public bool BButton => GetValue<bool>();

    /// <summary>
    ///     Gets a value indicating whether the X Button is pressed.
    /// </summary>
    /// <value><see langword="true" /> if X Button is pressed; otherwise, <see langword="false" />.</value>
    [Control(ButtonPage.Button2)]
    public bool XButton => GetValue<bool>();

    /// <summary>
    ///     Gets a value indicating whether the Y Button is pressed.
    /// </summary>
    /// <value><see langword="true" /> if Y Button is pressed; otherwise, <see langword="false" />.</value>
    [Control(ButtonPage.Button3)]
    public bool YButton => GetValue<bool>();

    /// <summary>
    ///     Gets a value indicating whether the Left Bumper is pressed.
    /// </summary>
    /// <value><see langword="true" /> if Left Bumper is pressed; otherwise, <see langword="false" />.</value>
    [Control(ButtonPage.Button4)]
    public bool LeftBumper => GetValue<bool>();

    /// <summary>
    ///     Gets a value indicating whether the Right Bumper is pressed.
    /// </summary>
    /// <value><see langword="true" /> if Right Bumper is pressed; otherwise, <see langword="false" />.</value>
    [Control(ButtonPage.Button5)]
    public bool RightBumper => GetValue<bool>();

    /// <summary>
    ///     Gets a value indicating whether the Left Stick is pressed.
    /// </summary>
    /// <value><see langword="true" /> if Left Stick is pressed; otherwise, <see langword="false" />.</value>
    [Control(ButtonPage.Button8)]
    public bool LeftStick => GetValue<bool>();

    /// <summary>
    ///     Gets a value indicating whether the Right Stick is pressed.
    /// </summary>
    /// <value><see langword="true" /> if Right Stick is pressed; otherwise, <see langword="false" />.</value>
    [Control(ButtonPage.Button9)]
    public bool RightStick => GetValue<bool>();

    /// <summary>
    ///     Gets the hat direction.
    /// </summary>
    /// <value>The hat direction.</value>
    [Control(GenericDesktopPage.HatSwitch)]
    [TypeConverter(typeof(DirectionConverter))]
    public Direction Hat => GetValue<Direction>();
}
