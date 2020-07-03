// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using HIDControllers.Controls;
using HidSharp.Reports;

namespace HIDControllers
{
    public sealed class AxisType
    {
        private static readonly Dictionary<Usage, AxisType> s_usages = new Dictionary<Usage, AxisType>
        {
            {
                Usage.GenericDesktopX /* 0x00010030 */, new AxisType(Usage.GenericDesktopX, "X-axis", typeof(Joystick), 0.5D, 3, 0.1D,
                    Usage.GenericDesktopX,
                    Usage.GenericDesktopY)
            },
            {
                Usage.GenericDesktopY /* 0x00010031 */, new AxisType(Usage.GenericDesktopY, "Y-axis", typeof(Joystick), 0.5D, 3, 0.1D,
                    Usage.GenericDesktopX,
                    Usage.GenericDesktopY)
            },
            {Usage.GenericDesktopZ /* 0x00010032 */, new AxisType(Usage.GenericDesktopZ, "Z-axis", typeof(Slider), 0.5D, 3, 0.1D)},
            {
                Usage.GenericDesktopRx /* 0x00010033 */, new AxisType(Usage.GenericDesktopRx, "RX-axis",
                    typeof(Joystick), 0.5D, 3, 0.1D,
                    Usage.GenericDesktopRx,
                    Usage.GenericDesktopRy)
            },
            {
                Usage.GenericDesktopRy /* 0x00010034 */, new AxisType(Usage.GenericDesktopRy, "RY-axis",
                    typeof(Joystick), 0.5D, 3, 0.1D,
                    Usage.GenericDesktopRx,
                    Usage.GenericDesktopRy)
            },
            {Usage.GenericDesktopRz /* 0x00010035 */, new AxisType(Usage.GenericDesktopRz, "RZ-axis", typeof(Slider), 0.5D, 3, 0.1D)},
            {
                Usage.GenericDesktopSlider /* 0x00010036 */,
                new AxisType(Usage.GenericDesktopSlider, "Slider", typeof(Slider), 0D, 3, 0.4D)
            },

            {Usage.GenericDesktopDial /* 0x00010037 */, new AxisType(Usage.GenericDesktopDial, "Dial", typeof(Slider), 0D, 3, 0D)},
            {
                Usage.GenericDesktopWheel /* 0x00010038 */,
                new AxisType(Usage.GenericDesktopWheel, "Wheel", typeof(Slider), 0D, 3, 0D)
            },

            {
                Usage.GenericDesktopHatSwitch /* 0x00010039 */,
                new AxisType(Usage.GenericDesktopHatSwitch, "Hat", typeof(Hat), double.NaN, 3, 0D)
            },

            {
                Usage.GenericDesktopStart /* 0x0001003D */,
                new AxisType(Usage.GenericDesktopStart, "Start", typeof(Button), 0D, 0, 0D)
            },
            {
                Usage.GenericDesktopSelect /* 0x0001003E */,
                new AxisType(Usage.GenericDesktopSelect, "Select", typeof(Button), 0D, 0, 0D)
            },
            {
                Usage.GenericDesktopSystemControl /* 0x00010080 */,
                new AxisType(Usage.GenericDesktopSystemControl, "System Control", typeof(Button), 0D, 0, 0D)
            },
            {
                Usage.GenericDesktopDPadUp /* 0x00010090 */, new AxisType(Usage.GenericDesktopDPadUp, "D-Pad Up",
                    typeof(DPad), 0D, 0, 0D,
                    Usage.GenericDesktopDPadUp, Usage.GenericDesktopDPadRight, Usage.GenericDesktopDPadDown,
                    Usage.GenericDesktopDPadLeft)
            },
            {
                Usage.GenericDesktopDPadDown /* 0x00010091 */, new AxisType(Usage.GenericDesktopDPadDown, "D-Pad Down",
                    typeof(DPad), 0D, 0, 0D,
                    Usage.GenericDesktopDPadUp, Usage.GenericDesktopDPadRight, Usage.GenericDesktopDPadDown,
                    Usage.GenericDesktopDPadLeft)
            },
            {
                Usage.GenericDesktopDPadLeft /* 0x00010092 */, new AxisType(Usage.GenericDesktopDPadLeft, "D-Pad Left",
                    typeof(DPad), 0D, 0, 0D,
                    Usage.GenericDesktopDPadUp, Usage.GenericDesktopDPadRight, Usage.GenericDesktopDPadDown,
                    Usage.GenericDesktopDPadLeft)
            },
            {
                Usage.GenericDesktopDPadRight /* 0x00010093 */, new AxisType(Usage.GenericDesktopDPadRight,
                    "D-Pad Right",
                    typeof(DPad), 0D, 0, 0D,
                    Usage.GenericDesktopDPadUp, Usage.GenericDesktopDPadRight, Usage.GenericDesktopDPadDown,
                    Usage.GenericDesktopDPadLeft)
            }
        };

        static AxisType()
        {
            for (var i = 1; i <= 256; i++)
            {
                var usage = (Usage)(0x00090000 + i);
                // Add first 256 Buttons  (Spec. allows for up to 65535, but that's ridiculous)
                s_usages[usage] = new AxisType(usage, "Button " + i, typeof(Button), 0D, 0, 0D);
            }
        }

        private AxisType(Usage usage, string name, Type type, double initialValue, int sensitivity, double deadZone, params Usage[] @group)
        {
            Usage = usage;
            Name = name;
            Type = type;
            InitialValue = initialValue;
            Sensitivity = sensitivity;
            DeadZone = deadZone;
            Group = group;
        }

        /// <summary>
        /// Gets the usage.
        /// </summary>
        /// <value>The usage.</value>
        internal Usage Usage { get; }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; }

        /// <summary>
        /// Gets the concrete type.
        /// </summary>
        /// <value>The type.</value>
        public Type Type { get; }

        /// <summary>
        /// Gets the default initial value.
        /// </summary>
        /// <value>The default initial value.</value>
        public double InitialValue { get; }

        /// <summary>
        /// Gets the default sensitivity.
        /// </summary>
        /// <value>The default sensitivity.</value>
        public int Sensitivity { get; }

        /// <summary>
        /// Gets the default dead zone.
        /// </summary>
        /// <value>The default dead zone.</value>
        public double DeadZone { get; }

        /// <summary>
        /// Gets the group usages.
        /// </summary>
        /// <value>The group.</value>
        internal IReadOnlyList<Usage> Group { get; }

        /// <summary>
        /// Gets a value indicating whether this instance is part of a group of axes.
        /// </summary>
        /// <value><see langword="true" /> if this instance is part of a group of axes.; otherwise, <see langword="false" />.</value>
        public bool IsGrouped => Group.Count > 0;

        internal Axis Create(Controller controller, DataItem dataItem)
        {
            var type = Type;
            if (Group.Count > 0)
            {
                type = typeof(Axis);
            }

            return (Axis)Activator.CreateInstance(
                type,
                BindingFlags.CreateInstance | BindingFlags.Instance | BindingFlags.NonPublic, null,
                new object[] { this, controller, dataItem }, null);
        }

        internal Control Create(Axis[] group)
        {
            if (Group.Count != group.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(group),
                    string.Format(Resources.ControlCreationFailure2, Group.Count, group.Length));
            }

            return (Control)Activator.CreateInstance(
                Type,
                BindingFlags.CreateInstance | BindingFlags.Instance | BindingFlags.NonPublic, null,
                new object[] { group }, null);
        }

        /// <summary>
        /// Tries to get the AxisType associated with the specified Usage.
        /// </summary>
        /// <param name="usage">The usage.</param>
        /// <param name="type">The type, if any.</param>
        /// <returns><see langword="true" /> if the specified usage is associated with an AxisType, <see langword="false" /> otherwise.</returns>
        internal static bool TryGet(Usage usage, [MaybeNullWhen(false)] out AxisType type) => s_usages.TryGetValue(usage, out type);

        /// <summary>
        /// Checks whether the specified usage is supported.
        /// </summary>
        /// <param name="usage">The usage.</param>
        /// <returns><see langword="true" /> if the specified usage is supported, <see langword="false" /> otherwise.</returns>
        internal static bool SupportedUsage(Usage usage) => s_usages.ContainsKey(usage);
    }
}
