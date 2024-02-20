// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

// Specification revision: 1.5.0; generated at 2024-01-08 23:33:15Z.

#pragma warning disable CS0108 // Member hides inherited member; missing new keyword

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;

namespace DevDecoder.HIDDevices
{
    using DevDecoder.HIDDevices.Pages;

    // <summary>
    //     Base class for all usage pages.
    // </summary>
    public partial class UsagePage
    {
        // <summary>
        //     Dictionary of all defined usage pages.
        // </summary>
        private static ConcurrentDictionary<ushort, UsagePage> s_pages =
                new ConcurrentDictionary<ushort, UsagePage>
                {
                    [0x0001] = GenericDesktopUsagePage.Instance,
                    [0x0002] = SimulationControlsUsagePage.Instance,
                    [0x0003] = VRControlsUsagePage.Instance,
                    [0x0004] = SportControlsUsagePage.Instance,
                    [0x0005] = GameControlsUsagePage.Instance,
                    [0x0006] = GenericDeviceControlsUsagePage.Instance,
                    [0x0007] = KeyboardKeypadUsagePage.Instance,
                    [0x0008] = LEDUsagePage.Instance,
                    [0x0009] = ButtonUsagePage.Instance,
                    [0x000a] = OrdinalUsagePage.Instance,
                    [0x000b] = TelephonyDeviceUsagePage.Instance,
                    [0x000c] = ConsumerUsagePage.Instance,
                    [0x000d] = DigitizersUsagePage.Instance,
                    [0x000e] = HapticsUsagePage.Instance,
                    [0x000f] = PhysicalInputDeviceUsagePage.Instance,
                    [0x0011] = SoCUsagePage.Instance,
                    [0x0012] = EyeAndHeadTrackersUsagePage.Instance,
                    [0x0014] = AuxiliaryDisplayUsagePage.Instance,
                    [0x0020] = SensorsUsagePage.Instance,
                    [0x0040] = MedicalInstrumentUsagePage.Instance,
                    [0x0041] = BrailleDisplayUsagePage.Instance,
                    [0x0059] = LightingAndIlluminationUsagePage.Instance,
                    [0x0080] = MonitorUsagePage.Instance,
                    [0x0081] = MonitorEnumeratedUsagePage.Instance,
                    [0x0082] = VESAVirtualControlsUsagePage.Instance,
                    [0x0084] = PowerUsagePage.Instance,
                    [0x0085] = BatterySystemUsagePage.Instance,
                    [0x008c] = BarcodeScannerUsagePage.Instance,
                    [0x008d] = ScalesUsagePage.Instance,
                    [0x008e] = MagneticStripeReaderUsagePage.Instance,
                    [0x0090] = CameraControlUsagePage.Instance,
                    [0x0091] = ArcadeUsagePage.Instance,
                    [0xf1d0] = FIDOAllianceUsagePage.Instance
                };

        // <summary>
        //     Generic Desktop Usage Page.
        // </summary>
        public static readonly GenericDesktopUsagePage GenericDesktop = GenericDesktopUsagePage.Instance;

        // <summary>
        //     Simulation Controls Usage Page.
        // </summary>
        public static readonly SimulationControlsUsagePage SimulationControls = SimulationControlsUsagePage.Instance;

        // <summary>
        //     VR Controls Usage Page.
        // </summary>
        public static readonly VRControlsUsagePage VRControls = VRControlsUsagePage.Instance;

        // <summary>
        //     Sport Controls Usage Page.
        // </summary>
        public static readonly SportControlsUsagePage SportControls = SportControlsUsagePage.Instance;

        // <summary>
        //     Game Controls Usage Page.
        // </summary>
        public static readonly GameControlsUsagePage GameControls = GameControlsUsagePage.Instance;

        // <summary>
        //     Generic Device Controls Usage Page.
        // </summary>
        public static readonly GenericDeviceControlsUsagePage GenericDeviceControls = GenericDeviceControlsUsagePage.Instance;

        // <summary>
        //     Keyboard/Keypad Usage Page.
        // </summary>
        public static readonly KeyboardKeypadUsagePage KeyboardKeypad = KeyboardKeypadUsagePage.Instance;

        // <summary>
        //     LED Usage Page.
        // </summary>
        public static readonly LEDUsagePage LED = LEDUsagePage.Instance;

        // <summary>
        //     Button Usage Page.
        // </summary>
        public static readonly ButtonUsagePage Button = ButtonUsagePage.Instance;

        // <summary>
        //     Ordinal Usage Page.
        // </summary>
        public static readonly OrdinalUsagePage Ordinal = OrdinalUsagePage.Instance;

        // <summary>
        //     Telephony Device Usage Page.
        // </summary>
        public static readonly TelephonyDeviceUsagePage TelephonyDevice = TelephonyDeviceUsagePage.Instance;

        // <summary>
        //     Consumer Usage Page.
        // </summary>
        public static readonly ConsumerUsagePage Consumer = ConsumerUsagePage.Instance;

        // <summary>
        //     Digitizers Usage Page.
        // </summary>
        public static readonly DigitizersUsagePage Digitizers = DigitizersUsagePage.Instance;

        // <summary>
        //     Haptics Usage Page.
        // </summary>
        public static readonly HapticsUsagePage Haptics = HapticsUsagePage.Instance;

        // <summary>
        //     Physical Input Device Usage Page.
        // </summary>
        public static readonly PhysicalInputDeviceUsagePage PhysicalInputDevice = PhysicalInputDeviceUsagePage.Instance;

        // <summary>
        //     SoC Usage Page.
        // </summary>
        public static readonly SoCUsagePage SoC = SoCUsagePage.Instance;

        // <summary>
        //     Eye and Head Trackers Usage Page.
        // </summary>
        public static readonly EyeAndHeadTrackersUsagePage EyeAndHeadTrackers = EyeAndHeadTrackersUsagePage.Instance;

        // <summary>
        //     Auxiliary Display Usage Page.
        // </summary>
        public static readonly AuxiliaryDisplayUsagePage AuxiliaryDisplay = AuxiliaryDisplayUsagePage.Instance;

        // <summary>
        //     Sensors Usage Page.
        // </summary>
        public static readonly SensorsUsagePage Sensors = SensorsUsagePage.Instance;

        // <summary>
        //     Medical Instrument Usage Page.
        // </summary>
        public static readonly MedicalInstrumentUsagePage MedicalInstrument = MedicalInstrumentUsagePage.Instance;

        // <summary>
        //     Braille Display Usage Page.
        // </summary>
        public static readonly BrailleDisplayUsagePage BrailleDisplay = BrailleDisplayUsagePage.Instance;

        // <summary>
        //     Lighting And Illumination Usage Page.
        // </summary>
        public static readonly LightingAndIlluminationUsagePage LightingAndIllumination = LightingAndIlluminationUsagePage.Instance;

        // <summary>
        //     Monitor Usage Page.
        // </summary>
        public static readonly MonitorUsagePage Monitor = MonitorUsagePage.Instance;

        // <summary>
        //     Monitor Enumerated Usage Page.
        // </summary>
        public static readonly MonitorEnumeratedUsagePage MonitorEnumerated = MonitorEnumeratedUsagePage.Instance;

        // <summary>
        //     VESA Virtual Controls Usage Page.
        // </summary>
        public static readonly VESAVirtualControlsUsagePage VESAVirtualControls = VESAVirtualControlsUsagePage.Instance;

        // <summary>
        //     Power Usage Page.
        // </summary>
        public static readonly PowerUsagePage Power = PowerUsagePage.Instance;

        // <summary>
        //     Battery System Usage Page.
        // </summary>
        public static readonly BatterySystemUsagePage BatterySystem = BatterySystemUsagePage.Instance;

        // <summary>
        //     Barcode Scanner Usage Page.
        // </summary>
        public static readonly BarcodeScannerUsagePage BarcodeScanner = BarcodeScannerUsagePage.Instance;

        // <summary>
        //     Scales Usage Page.
        // </summary>
        public static readonly ScalesUsagePage Scales = ScalesUsagePage.Instance;

        // <summary>
        //     Magnetic Stripe Reader Usage Page.
        // </summary>
        public static readonly MagneticStripeReaderUsagePage MagneticStripeReader = MagneticStripeReaderUsagePage.Instance;

        // <summary>
        //     Camera Control Usage Page.
        // </summary>
        public static readonly CameraControlUsagePage CameraControl = CameraControlUsagePage.Instance;

        // <summary>
        //     Arcade Usage Page.
        // </summary>
        public static readonly ArcadeUsagePage Arcade = ArcadeUsagePage.Instance;

        // <summary>
        //     FIDO Alliance Usage Page.
        // </summary>
        public static readonly FIDOAllianceUsagePage FIDOAlliance = FIDOAllianceUsagePage.Instance;
    }
}
