// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using DevDecoder.HIDDevices.Converters;

namespace DevDecoder.HIDDevices.Controllers;

/// <summary>
///     Class Gamepad defines a GamePad <seealso cref="Controller" />.
/// </summary>
/// <seealso cref="Controller" />
[Device(0x00010005 /* GenericDesktopPage.Gamepad */)]
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
    [Control(0x00010030 /* GenericDesktopPage.X */)]
    [Required]
    [TypeConverter(typeof(SignedConverter))]
    public double X => GetValue<double>();

    /// <summary>
    ///     Gets the y.
    /// </summary>
    /// <value>The y.</value>
    /// <remarks>Note: By convention, -1 indicates up, and 1 indicates down.</remarks>
    [Control(0x00010031 /* GenericDesktopPage.Y */)]
    [Required]
    [TypeConverter(typeof(SignedConverter))]
    public double Y => GetValue<double>();

    /// <summary>
    ///     Gets the rx.
    /// </summary>
    /// <value>The rx.</value>
    /// <remarks>Note: By convention, -1 indicates left, and 1 indicates right.</remarks>
    [Control(0x00010033 /* GenericDesktopPage.Rx */)]
    [TypeConverter(typeof(SignedConverter))]
    public double Rx => GetValue<double>();

    /// <summary>
    ///     Gets the ry.
    /// </summary>
    /// <value>The ry.</value>
    /// <remarks>Note: By convention, -1 indicates up, and 1 indicates down.</remarks>
    [Control(0x00010034 /* GenericDesktopPage.Ry */)]
    [TypeConverter(typeof(SignedConverter))]
    public double Ry => GetValue<double>();

    /// <summary>
    ///     Gets a value indicating whether this <see cref="Gamepad">gamepad's</see> start button is pressed.
    /// </summary>
    /// <value><see langword="true" /> if start is pressed; otherwise, <see langword="false" />.</value>
    [Control(0x0001003d /* GenericDesktopPage.Start */, Weight = 2)]
    [Control(0x00090008 /* ButtonPage.Button7 */)]
    public bool Start => GetValue<bool>();

    /// <summary>
    ///     Gets a value indicating whether this <see cref="Gamepad">gamepad's</see> select button is pressed.
    /// </summary>
    /// <value><see langword="true" /> if select is pressed; otherwise, <see langword="false" />.</value>
    [Control(0x0001003e /* GenericDesktopPage.Select */, Weight = 2)]
    [Control(0x00090007 /* ButtonPage.Button6 */)]
    public bool Select => GetValue<bool>();

    /// <summary>
    ///     Gets the left trigger value.
    /// </summary>
    /// <value>The left trigger.</value>
    /// <remarks>Note: 0 indicates not pressed, and 1 indicates fully depressed.</remarks>
    [Control(0x00010032 /* GenericDesktopPage.Z */)]
    [TypeConverter(typeof(LeftTriggerConverter))]
    public double LeftTrigger => GetValue<double>();

    /// <summary>
    ///     Gets the right trigger value.
    /// </summary>
    /// <value>The right trigger.</value>
    /// <remarks>Note: 0 indicates not pressed, and 1 indicates fully depressed.</remarks>
    [Control(0x00010032 /* GenericDesktopPage.Z */)]
    [TypeConverter(typeof(RightTriggerConverter))]
    public double RightTrigger => GetValue<double>();

    /// <summary>
    ///     Gets a value indicating whether the A Button is pressed.
    /// </summary>
    /// <value><see langword="true" /> if A Button is pressed; otherwise, <see langword="false" />.</value>
    [Control(0x00090001 /* ButtonPage.Button0 */)]
    [Required]
    public bool AButton => GetValue<bool>();

    /// <summary>
    ///     Gets a value indicating whether the B Button is pressed.
    /// </summary>
    /// <value><see langword="true" /> if B Button is pressed; otherwise, <see langword="false" />.</value>
    [Control(0x00090002 /* ButtonPage.Button1 */)]
    public bool BButton => GetValue<bool>();

    /// <summary>
    ///     Gets a value indicating whether the X Button is pressed.
    /// </summary>
    /// <value><see langword="true" /> if X Button is pressed; otherwise, <see langword="false" />.</value>
    [Control(0x00090003 /* ButtonPage.Button2 */)]
    public bool XButton => GetValue<bool>();

    /// <summary>
    ///     Gets a value indicating whether the Y Button is pressed.
    /// </summary>
    /// <value><see langword="true" /> if Y Button is pressed; otherwise, <see langword="false" />.</value>
    [Control(0x00090004 /* ButtonPage.Button3 */)]
    public bool YButton => GetValue<bool>();

    /// <summary>
    ///     Gets a value indicating whether the Left Bumper is pressed.
    /// </summary>
    /// <value><see langword="true" /> if Left Bumper is pressed; otherwise, <see langword="false" />.</value>
    [Control(0x00090005 /* ButtonPage.Button4 */)]
    public bool LeftBumper => GetValue<bool>();

    /// <summary>
    ///     Gets a value indicating whether the Right Bumper is pressed.
    /// </summary>
    /// <value><see langword="true" /> if Right Bumper is pressed; otherwise, <see langword="false" />.</value>
    [Control(0x00090006 /* ButtonPage.Button5 */)]
    public bool RightBumper => GetValue<bool>();

    /// <summary>
    ///     Gets a value indicating whether the Left Stick is pressed.
    /// </summary>
    /// <value><see langword="true" /> if Left Stick is pressed; otherwise, <see langword="false" />.</value>
    [Control(0x00090009 /* ButtonPage.Button8 */)]
    public bool LeftStick => GetValue<bool>();

    /// <summary>
    ///     Gets a value indicating whether the Right Stick is pressed.
    /// </summary>
    /// <value><see langword="true" /> if Right Stick is pressed; otherwise, <see langword="false" />.</value>
    [Control(0x0009000a /* ButtonPage.Button9 */)]
    public bool RightStick => GetValue<bool>();

    /// <summary>
    ///     Gets the hat direction.
    /// </summary>
    /// <value>The hat direction.</value>
    [Control(0x00010039 /* GenericDesktopPage.HatSwitch */)]
    [TypeConverter(typeof(DirectionConverter))]
    public Direction Hat => GetValue<Direction>();
}
