// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using HidSharp.Reports;

namespace HIDControllers
{
    public sealed class DeviceType
    {
        private static readonly Dictionary<Usage, DeviceType> s_usages = new Dictionary<Usage, DeviceType>
        {
            // NOTE Keyboard & Mice are locked down in windows to prevent insecure access via HID (e.g. by key-loggers)
            // Usage.GenericDesktopPointer /* 0x00010001 */
            // Usage.GenericDesktopMouse /* 0x00010002 */
            // Usage.GenericDesktopKeyboard /* 0x00010006 */
            // Usage.GenericDesktopKeypad /* 0x00010007 */
            {
                Usage.GenericDesktopJoystick /* 0x00010004 */,
                new DeviceType(Usage.GenericDesktopJoystick, Resources.DeviceTypeJoystick)
            },
            {
                Usage.GenericDesktopGamepad /* 0x00010005 */,
                new DeviceType(Usage.GenericDesktopJoystick, Resources.DeviceTypeGamepad)
            },
            {
                Usage.GenericDesktopMultiaxisController /* 0x00010008 */,
                new DeviceType(Usage.GenericDesktopMultiaxisController, Resources.DeviceTypeMultiAxisController)
            },
            {
                Usage.ConsumerConsumerControl /* 0x000C0001 */,
                new DeviceType(Usage.ConsumerConsumerControl, Resources.DeviceTypeConsumerController)
            },
            {
                Usage.ConsumerNumericKeypad /* 0x000C0002 */,
                new DeviceType(Usage.ConsumerNumericKeypad, Resources.DeviceTypeKeypad)
            },
            {
                Usage.ConsumerProgrammableButtons /* 0x000C0003 */,
                new DeviceType(Usage.ConsumerProgrammableButtons, Resources.DeviceTypeProgrammableButtons)
            }
        };

        private DeviceType(Usage usage, string name)
        {
            Usage = usage;
            Name = name;
        }

        public Usage Usage { get; }
        public string Name { get; }

        public static DeviceType? Get(Usage du) => s_usages.TryGetValue(du, out var t) ? t : null;

        public static bool TryGet(Usage du, out DeviceType type) => s_usages.TryGetValue(du, out type);

        public static bool SupportedUsage(Usage du) => s_usages.ContainsKey(du);
    }
}
