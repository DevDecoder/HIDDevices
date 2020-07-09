// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.
#pragma warning disable CS0108 // Member hides inherited member; missing new keyword

namespace HIDControllers.Pages
{
    /// <summary>
    ///     Class defining the Undefined usage page.
    /// </summary>
    public sealed partial class UndefinedPage : UsagePage
    {
        /// <summary>
        ///     The singleton instance of UndefinedPage.
        /// </summary>
        public static readonly UndefinedPage Instance = new UndefinedPage(0x0000, "Undefined");

        /// <summary>
        ///     Undefined: Undefined Usage.
        /// </summary>
        public static readonly Usage Undefined = Instance.Create(0x0000, "Undefined");

        /// <inheritdoc />
        private UndefinedPage(ushort id, string name) : base(id, name, true)
        {
        }
    }

    /// <summary>
    ///     Class defining the Generic Desktop Controls usage page.
    /// </summary>
    public sealed partial class GenericDesktopPage : UsagePage
    {
        /// <summary>
        ///     The singleton instance of GenericDesktopPage.
        /// </summary>
        public static readonly GenericDesktopPage Instance = new GenericDesktopPage(0x0001, "Generic Desktop Controls");

        /// <summary>
        ///     GenericDesktop: Pointer Usage.
        /// </summary>
        public static readonly Usage Pointer = Instance.Create(0x0001, "Pointer");
        /// <summary>
        ///     GenericDesktop: Mouse Usage.
        /// </summary>
        public static readonly Usage Mouse = Instance.Create(0x0002, "Mouse");

        /// <summary>
        ///     GenericDesktop: Joystick Usage.
        /// </summary>
        public static readonly Usage Joystick = Instance.Create(0x0004, "Joystick");
        /// <summary>
        ///     GenericDesktop: Game Pad Usage.
        /// </summary>
        public static readonly Usage GamePad = Instance.Create(0x0005, "Game Pad");
        /// <summary>
        ///     GenericDesktop: Keyboard Usage.
        /// </summary>
        public static readonly Usage Keyboard = Instance.Create(0x0006, "Keyboard");
        /// <summary>
        ///     GenericDesktop: Keypad Usage.
        /// </summary>
        public static readonly Usage Keypad = Instance.Create(0x0007, "Keypad");
        /// <summary>
        ///     GenericDesktop: Multi-axis Controller Usage.
        /// </summary>
        public static readonly Usage MultiaxisController = Instance.Create(0x0008, "Multi-axis Controller");
        /// <summary>
        ///     GenericDesktop: Tablet PC System Controls Usage.
        /// </summary>
        public static readonly Usage TabletPCSystemControls = Instance.Create(0x0009, "Tablet PC System Controls");
        /// <summary>
        ///     GenericDesktop: Water Cooling Device Usage.
        /// </summary>
        public static readonly Usage WaterCoolingDevice = Instance.Create(0x000a, "Water Cooling Device");
        /// <summary>
        ///     GenericDesktop: Computer Chassis Device Usage.
        /// </summary>
        public static readonly Usage ComputerChassisDevice = Instance.Create(0x000b, "Computer Chassis Device");
        /// <summary>
        ///     GenericDesktop: Wireless Radio Controls Usage.
        /// </summary>
        public static readonly Usage WirelessRadioControls = Instance.Create(0x000c, "Wireless Radio Controls");
        /// <summary>
        ///     GenericDesktop: Portable Device Control Usage.
        /// </summary>
        public static readonly Usage PortableDeviceControl = Instance.Create(0x000d, "Portable Device Control");
        /// <summary>
        ///     GenericDesktop: System Multi-axis Controller Usage.
        /// </summary>
        public static readonly Usage SystemMultiaxisController = Instance.Create(0x000e, "System Multi-axis Controller");
        /// <summary>
        ///     GenericDesktop: Spatial Controller Usage.
        /// </summary>
        public static readonly Usage SpatialController = Instance.Create(0x000f, "Spatial Controller");
        /// <summary>
        ///     GenericDesktop: Assistive Control Usage.
        /// </summary>
        public static readonly Usage AssistiveControl = Instance.Create(0x0010, "Assistive Control");

        /// <summary>
        ///     GenericDesktop: X Usage.
        /// </summary>
        public static readonly Usage X = Instance.Create(0x0030, "X");
        /// <summary>
        ///     GenericDesktop: Y Usage.
        /// </summary>
        public static readonly Usage Y = Instance.Create(0x0031, "Y");
        /// <summary>
        ///     GenericDesktop: Z Usage.
        /// </summary>
        public static readonly Usage Z = Instance.Create(0x0032, "Z");
        /// <summary>
        ///     GenericDesktop: Rx Usage.
        /// </summary>
        public static readonly Usage Rx = Instance.Create(0x0033, "Rx");
        /// <summary>
        ///     GenericDesktop: Ry Usage.
        /// </summary>
        public static readonly Usage Ry = Instance.Create(0x0034, "Ry");
        /// <summary>
        ///     GenericDesktop: Rz Usage.
        /// </summary>
        public static readonly Usage Rz = Instance.Create(0x0035, "Rz");
        /// <summary>
        ///     GenericDesktop: Slider Usage.
        /// </summary>
        public static readonly Usage Slider = Instance.Create(0x0036, "Slider");
        /// <summary>
        ///     GenericDesktop: Dial Usage.
        /// </summary>
        public static readonly Usage Dial = Instance.Create(0x0037, "Dial");
        /// <summary>
        ///     GenericDesktop: Wheel Usage.
        /// </summary>
        public static readonly Usage Wheel = Instance.Create(0x0038, "Wheel");
        /// <summary>
        ///     GenericDesktop: Hat switch Usage.
        /// </summary>
        public static readonly Usage HatSwitch = Instance.Create(0x0039, "Hat switch");
        /// <summary>
        ///     GenericDesktop: Counter Buffer Usage.
        /// </summary>
        public static readonly Usage CounterBuffer = Instance.Create(0x003a, "Counter Buffer");
        /// <summary>
        ///     GenericDesktop: Byte Count Usage.
        /// </summary>
        public static readonly Usage ByteCount = Instance.Create(0x003b, "Byte Count");
        /// <summary>
        ///     GenericDesktop: Motion Wakeup Usage.
        /// </summary>
        public static readonly Usage MotionWakeup = Instance.Create(0x003c, "Motion Wakeup");
        /// <summary>
        ///     GenericDesktop: Start Usage.
        /// </summary>
        public static readonly Usage Start = Instance.Create(0x003d, "Start");
        /// <summary>
        ///     GenericDesktop: Select Usage.
        /// </summary>
        public static readonly Usage Select = Instance.Create(0x003e, "Select");

        /// <summary>
        ///     GenericDesktop: Vx Usage.
        /// </summary>
        public static readonly Usage Vx = Instance.Create(0x0040, "Vx");
        /// <summary>
        ///     GenericDesktop: Vy Usage.
        /// </summary>
        public static readonly Usage Vy = Instance.Create(0x0041, "Vy");
        /// <summary>
        ///     GenericDesktop: Vz Usage.
        /// </summary>
        public static readonly Usage Vz = Instance.Create(0x0042, "Vz");
        /// <summary>
        ///     GenericDesktop: Vbrx Usage.
        /// </summary>
        public static readonly Usage Vbrx = Instance.Create(0x0043, "Vbrx");
        /// <summary>
        ///     GenericDesktop: Vbry Usage.
        /// </summary>
        public static readonly Usage Vbry = Instance.Create(0x0044, "Vbry");
        /// <summary>
        ///     GenericDesktop: Vbrz Usage.
        /// </summary>
        public static readonly Usage Vbrz = Instance.Create(0x0045, "Vbrz");
        /// <summary>
        ///     GenericDesktop: Vno Usage.
        /// </summary>
        public static readonly Usage Vno = Instance.Create(0x0046, "Vno");
        /// <summary>
        ///     GenericDesktop: Feature Notification Usage.
        /// </summary>
        public static readonly Usage FeatureNotification = Instance.Create(0x0047, "Feature Notification");
        /// <summary>
        ///     GenericDesktop: Resolution Multiplier Usage.
        /// </summary>
        public static readonly Usage ResolutionMultiplier = Instance.Create(0x0048, "Resolution Multiplier");
        /// <summary>
        ///     GenericDesktop: Qx Usage.
        /// </summary>
        public static readonly Usage Qx = Instance.Create(0x0049, "Qx");
        /// <summary>
        ///     GenericDesktop: Qy Usage.
        /// </summary>
        public static readonly Usage Qy = Instance.Create(0x004a, "Qy");
        /// <summary>
        ///     GenericDesktop: Qz Usage.
        /// </summary>
        public static readonly Usage Qz = Instance.Create(0x004b, "Qz");
        /// <summary>
        ///     GenericDesktop: Qw Usage.
        /// </summary>
        public static readonly Usage Qw = Instance.Create(0x004c, "Qw");

        /// <summary>
        ///     GenericDesktop: System Control Usage.
        /// </summary>
        public static readonly Usage SystemControl = Instance.Create(0x0080, "System Control");
        /// <summary>
        ///     GenericDesktop: System Power Down Usage.
        /// </summary>
        public static readonly Usage SystemPowerDown = Instance.Create(0x0081, "System Power Down");
        /// <summary>
        ///     GenericDesktop: System Sleep Usage.
        /// </summary>
        public static readonly Usage SystemSleep = Instance.Create(0x0082, "System Sleep");
        /// <summary>
        ///     GenericDesktop: System Wake up Usage.
        /// </summary>
        public static readonly Usage SystemWakeUp = Instance.Create(0x0083, "System Wake up");
        /// <summary>
        ///     GenericDesktop: System Context Menu Usage.
        /// </summary>
        public static readonly Usage SystemContextMenu = Instance.Create(0x0084, "System Context Menu");
        /// <summary>
        ///     GenericDesktop: System Main Menu Usage.
        /// </summary>
        public static readonly Usage SystemMainMenu = Instance.Create(0x0085, "System Main Menu");
        /// <summary>
        ///     GenericDesktop: System App Menu Usage.
        /// </summary>
        public static readonly Usage SystemAppMenu = Instance.Create(0x0086, "System App Menu");
        /// <summary>
        ///     GenericDesktop: System Menu Help Usage.
        /// </summary>
        public static readonly Usage SystemMenuHelp = Instance.Create(0x0087, "System Menu Help");
        /// <summary>
        ///     GenericDesktop: System Menu Exit Usage.
        /// </summary>
        public static readonly Usage SystemMenuExit = Instance.Create(0x0088, "System Menu Exit");
        /// <summary>
        ///     GenericDesktop: System Menu Select Usage.
        /// </summary>
        public static readonly Usage SystemMenuSelect = Instance.Create(0x0089, "System Menu Select");
        /// <summary>
        ///     GenericDesktop: System Menu Right Usage.
        /// </summary>
        public static readonly Usage SystemMenuRight = Instance.Create(0x008a, "System Menu Right");
        /// <summary>
        ///     GenericDesktop: System Menu Left Usage.
        /// </summary>
        public static readonly Usage SystemMenuLeft = Instance.Create(0x008b, "System Menu Left");
        /// <summary>
        ///     GenericDesktop: System Menu Up Usage.
        /// </summary>
        public static readonly Usage SystemMenuUp = Instance.Create(0x008c, "System Menu Up");
        /// <summary>
        ///     GenericDesktop: System Menu Down Usage.
        /// </summary>
        public static readonly Usage SystemMenuDown = Instance.Create(0x008d, "System Menu Down");
        /// <summary>
        ///     GenericDesktop: System Cold Restart Usage.
        /// </summary>
        public static readonly Usage SystemColdRestart = Instance.Create(0x008e, "System Cold Restart");
        /// <summary>
        ///     GenericDesktop: System Warm Restart Usage.
        /// </summary>
        public static readonly Usage SystemWarmRestart = Instance.Create(0x008f, "System Warm Restart");
        /// <summary>
        ///     GenericDesktop: D-pad Up Usage.
        /// </summary>
        public static readonly Usage DpadUp = Instance.Create(0x0090, "D-pad Up");
        /// <summary>
        ///     GenericDesktop: D-pad Down Usage.
        /// </summary>
        public static readonly Usage DpadDown = Instance.Create(0x0091, "D-pad Down");
        /// <summary>
        ///     GenericDesktop: D-pad Right Usage.
        /// </summary>
        public static readonly Usage DpadRight = Instance.Create(0x0092, "D-pad Right");
        /// <summary>
        ///     GenericDesktop: D-pad Left Usage.
        /// </summary>
        public static readonly Usage DpadLeft = Instance.Create(0x0093, "D-pad Left");
        /// <summary>
        ///     GenericDesktop: Index Trigger Usage.
        /// </summary>
        public static readonly Usage IndexTrigger = Instance.Create(0x0094, "Index Trigger");
        /// <summary>
        ///     GenericDesktop: Palm Trigger Usage.
        /// </summary>
        public static readonly Usage PalmTrigger = Instance.Create(0x0095, "Palm Trigger");
        /// <summary>
        ///     GenericDesktop: Thumbstick Usage.
        /// </summary>
        public static readonly Usage Thumbstick = Instance.Create(0x0096, "Thumbstick");
        /// <summary>
        ///     GenericDesktop: System Function Shift Usage.
        /// </summary>
        public static readonly Usage SystemFunctionShift = Instance.Create(0x0097, "System Function Shift");
        /// <summary>
        ///     GenericDesktop: System Function Shift Lock Usage.
        /// </summary>
        public static readonly Usage SystemFunctionShiftLock = Instance.Create(0x0098, "System Function Shift Lock");
        /// <summary>
        ///     GenericDesktop: System Function Shift Lock Indicator Usage.
        /// </summary>
        public static readonly Usage SystemFunctionShiftLockIndicator = Instance.Create(0x0099, "System Function Shift Lock Indicator");
        /// <summary>
        ///     GenericDesktop: System Dismiss Notification Usage.
        /// </summary>
        public static readonly Usage SystemDismissNotification = Instance.Create(0x009a, "System Dismiss Notification");

        /// <summary>
        ///     GenericDesktop: System Dock Usage.
        /// </summary>
        public static readonly Usage SystemDock = Instance.Create(0x00a0, "System Dock");
        /// <summary>
        ///     GenericDesktop: System Undock Usage.
        /// </summary>
        public static readonly Usage SystemUndock = Instance.Create(0x00a1, "System Undock");
        /// <summary>
        ///     GenericDesktop: System Setup Usage.
        /// </summary>
        public static readonly Usage SystemSetup = Instance.Create(0x00a2, "System Setup");
        /// <summary>
        ///     GenericDesktop: System Break Usage.
        /// </summary>
        public static readonly Usage SystemBreak = Instance.Create(0x00a3, "System Break");
        /// <summary>
        ///     GenericDesktop: System Debugger Break Usage.
        /// </summary>
        public static readonly Usage SystemDebuggerBreak = Instance.Create(0x00a4, "System Debugger Break");
        /// <summary>
        ///     GenericDesktop: Application Break Usage.
        /// </summary>
        public static readonly Usage ApplicationBreak = Instance.Create(0x00a5, "Application Break");
        /// <summary>
        ///     GenericDesktop: Application Debugger Break Usage.
        /// </summary>
        public static readonly Usage ApplicationDebuggerBreak = Instance.Create(0x00a6, "Application Debugger Break");
        /// <summary>
        ///     GenericDesktop: System Speaker Mute Usage.
        /// </summary>
        public static readonly Usage SystemSpeakerMute = Instance.Create(0x00a7, "System Speaker Mute");
        /// <summary>
        ///     GenericDesktop: System Hibernate Usage.
        /// </summary>
        public static readonly Usage SystemHibernate = Instance.Create(0x00a8, "System Hibernate");

        /// <summary>
        ///     GenericDesktop: System Display Invert Usage.
        /// </summary>
        public static readonly Usage SystemDisplayInvert = Instance.Create(0x00b0, "System Display Invert");
        /// <summary>
        ///     GenericDesktop: System Display Internal Usage.
        /// </summary>
        public static readonly Usage SystemDisplayInternal = Instance.Create(0x00b1, "System Display Internal");
        /// <summary>
        ///     GenericDesktop: System Display External Usage.
        /// </summary>
        public static readonly Usage SystemDisplayExternal = Instance.Create(0x00b2, "System Display External");
        /// <summary>
        ///     GenericDesktop: System Display Both Usage.
        /// </summary>
        public static readonly Usage SystemDisplayBoth = Instance.Create(0x00b3, "System Display Both");
        /// <summary>
        ///     GenericDesktop: System Display Dual Usage.
        /// </summary>
        public static readonly Usage SystemDisplayDual = Instance.Create(0x00b4, "System Display Dual");
        /// <summary>
        ///     GenericDesktop: System Display Toggle Int/Ext Usage.
        /// </summary>
        public static readonly Usage SystemDisplayToggleIntExt = Instance.Create(0x00b5, "System Display Toggle Int/Ext");
        /// <summary>
        ///     GenericDesktop: System Display Swap Primary/Secondary Usage.
        /// </summary>
        public static readonly Usage SystemDisplaySwapPrimarySecondary = Instance.Create(0x00b6, "System Display Swap Primary/Secondary");
        /// <summary>
        ///     GenericDesktop: System Display LCD Autoscale Usage.
        /// </summary>
        public static readonly Usage SystemDisplayLCDAutoscale = Instance.Create(0x00b7, "System Display LCD Autoscale");

        /// <summary>
        ///     GenericDesktop: Sensor Zone Usage.
        /// </summary>
        public static readonly Usage SensorZone = Instance.Create(0x00c0, "Sensor Zone");
        /// <summary>
        ///     GenericDesktop: RPM Usage.
        /// </summary>
        public static readonly Usage RPM = Instance.Create(0x00c1, "RPM");
        /// <summary>
        ///     GenericDesktop: Coolant Level Usage.
        /// </summary>
        public static readonly Usage CoolantLevel = Instance.Create(0x00c2, "Coolant Level");
        /// <summary>
        ///     GenericDesktop: Coolant Critical Level Usage.
        /// </summary>
        public static readonly Usage CoolantCriticalLevel = Instance.Create(0x00c3, "Coolant Critical Level");
        /// <summary>
        ///     GenericDesktop: Coolant Pump Usage.
        /// </summary>
        public static readonly Usage CoolantPump = Instance.Create(0x00c4, "Coolant Pump");
        /// <summary>
        ///     GenericDesktop: Chassis Enclosure Usage.
        /// </summary>
        public static readonly Usage ChassisEnclosure = Instance.Create(0x00c5, "Chassis Enclosure");
        /// <summary>
        ///     GenericDesktop: Wireless Radio Button Usage.
        /// </summary>
        public static readonly Usage WirelessRadioButton = Instance.Create(0x00c6, "Wireless Radio Button");
        /// <summary>
        ///     GenericDesktop: Wireless Radio LED Usage.
        /// </summary>
        public static readonly Usage WirelessRadioLED = Instance.Create(0x00c7, "Wireless Radio LED");
        /// <summary>
        ///     GenericDesktop: Wireless Radio Slider Switch Usage.
        /// </summary>
        public static readonly Usage WirelessRadioSliderSwitch = Instance.Create(0x00c8, "Wireless Radio Slider Switch");
        /// <summary>
        ///     GenericDesktop: System Display Rotation Lock Button Usage.
        /// </summary>
        public static readonly Usage SystemDisplayRotationLockButton = Instance.Create(0x00c9, "System Display Rotation Lock Button");
        /// <summary>
        ///     GenericDesktop: System Display Rotation Lock Slider Switch Usage.
        /// </summary>
        public static readonly Usage SystemDisplayRotationLockSliderSwitch = Instance.Create(0x00ca, "System Display Rotation Lock Slider Switch");
        /// <summary>
        ///     GenericDesktop: Control Enable Usage.
        /// </summary>
        public static readonly Usage ControlEnable = Instance.Create(0x00cb, "Control Enable");

        /// <summary>
        ///     GenericDesktop: Undefined Usage.
        /// </summary>
        public static readonly Usage Undefined = Instance.Create(0x0000, "Undefined");

        /// <inheritdoc />
        private GenericDesktopPage(ushort id, string name) : base(id, name, true)
        {
        }
    }

    /// <summary>
    ///     Class defining the Simulation Controls usage page.
    /// </summary>
    public sealed partial class SimulationPage : UsagePage
    {
        /// <summary>
        ///     The singleton instance of SimulationPage.
        /// </summary>
        public static readonly SimulationPage Instance = new SimulationPage(0x0002, "Simulation Controls");

        /// <summary>
        ///     Simulation: Flight Simulation Device Usage.
        /// </summary>
        public static readonly Usage FlightSimulationDevice = Instance.Create(0x0001, "Flight Simulation Device");
        /// <summary>
        ///     Simulation: Automobile Simulation Device Usage.
        /// </summary>
        public static readonly Usage AutomobileSimulationDevice = Instance.Create(0x0002, "Automobile Simulation Device");
        /// <summary>
        ///     Simulation: Tank Simulation Device Usage.
        /// </summary>
        public static readonly Usage TankSimulationDevice = Instance.Create(0x0003, "Tank Simulation Device");
        /// <summary>
        ///     Simulation: Spaceship Simulation Device Usage.
        /// </summary>
        public static readonly Usage SpaceshipSimulationDevice = Instance.Create(0x0004, "Spaceship Simulation Device");
        /// <summary>
        ///     Simulation: Submarine Simulation Device Usage.
        /// </summary>
        public static readonly Usage SubmarineSimulationDevice = Instance.Create(0x0005, "Submarine Simulation Device");
        /// <summary>
        ///     Simulation: Sailing Simulation Device Usage.
        /// </summary>
        public static readonly Usage SailingSimulationDevice = Instance.Create(0x0006, "Sailing Simulation Device");
        /// <summary>
        ///     Simulation: Motorcycle Simulation Device Usage.
        /// </summary>
        public static readonly Usage MotorcycleSimulationDevice = Instance.Create(0x0007, "Motorcycle Simulation Device");
        /// <summary>
        ///     Simulation: Sports Simulation Device Usage.
        /// </summary>
        public static readonly Usage SportsSimulationDevice = Instance.Create(0x0008, "Sports Simulation Device");
        /// <summary>
        ///     Simulation: Airplane Simulation Device Usage.
        /// </summary>
        public static readonly Usage AirplaneSimulationDevice = Instance.Create(0x0009, "Airplane Simulation Device");
        /// <summary>
        ///     Simulation: Helicopter Simulation Device Usage.
        /// </summary>
        public static readonly Usage HelicopterSimulationDevice = Instance.Create(0x000a, "Helicopter Simulation Device");
        /// <summary>
        ///     Simulation: Magic Carpet Simulation Device Usage.
        /// </summary>
        public static readonly Usage MagicCarpetSimulationDevice = Instance.Create(0x000b, "Magic Carpet Simulation Device");
        /// <summary>
        ///     Simulation: Bicycle Simulation Device Usage.
        /// </summary>
        public static readonly Usage BicycleSimulationDevice = Instance.Create(0x000c, "Bicycle Simulation Device");

        /// <summary>
        ///     Simulation: Flight Control Stick Usage.
        /// </summary>
        public static readonly Usage FlightControlStick = Instance.Create(0x0020, "Flight Control Stick");
        /// <summary>
        ///     Simulation: Flight Stick Usage.
        /// </summary>
        public static readonly Usage FlightStick = Instance.Create(0x0021, "Flight Stick");
        /// <summary>
        ///     Simulation: Cyclic Control Usage.
        /// </summary>
        public static readonly Usage CyclicControl = Instance.Create(0x0022, "Cyclic Control");
        /// <summary>
        ///     Simulation: Cyclic Trim Usage.
        /// </summary>
        public static readonly Usage CyclicTrim = Instance.Create(0x0023, "Cyclic Trim");
        /// <summary>
        ///     Simulation: Flight Yoke Usage.
        /// </summary>
        public static readonly Usage FlightYoke = Instance.Create(0x0024, "Flight Yoke");
        /// <summary>
        ///     Simulation: Track Control Usage.
        /// </summary>
        public static readonly Usage TrackControl = Instance.Create(0x0025, "Track Control");

        /// <summary>
        ///     Simulation: Aileron Usage.
        /// </summary>
        public static readonly Usage Aileron = Instance.Create(0x00b0, "Aileron");
        /// <summary>
        ///     Simulation: Aileron Trim Usage.
        /// </summary>
        public static readonly Usage AileronTrim = Instance.Create(0x00b1, "Aileron Trim");
        /// <summary>
        ///     Simulation: Anti-Torque Control Usage.
        /// </summary>
        public static readonly Usage AntiTorqueControl = Instance.Create(0x00b2, "Anti-Torque Control");
        /// <summary>
        ///     Simulation: Autopilot Enable Usage.
        /// </summary>
        public static readonly Usage AutopilotEnable = Instance.Create(0x00b3, "Autopilot Enable");
        /// <summary>
        ///     Simulation: Chaff Release Usage.
        /// </summary>
        public static readonly Usage ChaffRelease = Instance.Create(0x00b4, "Chaff Release");
        /// <summary>
        ///     Simulation: Collective Control Usage.
        /// </summary>
        public static readonly Usage CollectiveControl = Instance.Create(0x00b5, "Collective Control");
        /// <summary>
        ///     Simulation: Dive Brake Usage.
        /// </summary>
        public static readonly Usage DiveBrake = Instance.Create(0x00b6, "Dive Brake");
        /// <summary>
        ///     Simulation: Electronic Countermeasures Usage.
        /// </summary>
        public static readonly Usage ElectronicCountermeasures = Instance.Create(0x00b7, "Electronic Countermeasures");
        /// <summary>
        ///     Simulation: Elevator Usage.
        /// </summary>
        public static readonly Usage Elevator = Instance.Create(0x00b8, "Elevator");
        /// <summary>
        ///     Simulation: Elevator Trim Usage.
        /// </summary>
        public static readonly Usage ElevatorTrim = Instance.Create(0x00b9, "Elevator Trim");
        /// <summary>
        ///     Simulation: Rudder Usage.
        /// </summary>
        public static readonly Usage Rudder = Instance.Create(0x00ba, "Rudder");
        /// <summary>
        ///     Simulation: Throttle Usage.
        /// </summary>
        public static readonly Usage Throttle = Instance.Create(0x00bb, "Throttle");
        /// <summary>
        ///     Simulation: Flight Communications Usage.
        /// </summary>
        public static readonly Usage FlightCommunications = Instance.Create(0x00bc, "Flight Communications");
        /// <summary>
        ///     Simulation: Flare Release Usage.
        /// </summary>
        public static readonly Usage FlareRelease = Instance.Create(0x00bd, "Flare Release");
        /// <summary>
        ///     Simulation: Landing Gear Usage.
        /// </summary>
        public static readonly Usage LandingGear = Instance.Create(0x00be, "Landing Gear");
        /// <summary>
        ///     Simulation: Toe Brake Usage.
        /// </summary>
        public static readonly Usage ToeBrake = Instance.Create(0x00bf, "Toe Brake");
        /// <summary>
        ///     Simulation: Trigger Usage.
        /// </summary>
        public static readonly Usage Trigger = Instance.Create(0x00c0, "Trigger");
        /// <summary>
        ///     Simulation: Weapons Arm Usage.
        /// </summary>
        public static readonly Usage WeaponsArm = Instance.Create(0x00c1, "Weapons Arm");
        /// <summary>
        ///     Simulation: Weapons Select Usage.
        /// </summary>
        public static readonly Usage WeaponsSelect = Instance.Create(0x00c2, "Weapons Select");
        /// <summary>
        ///     Simulation: Wing Flaps Usage.
        /// </summary>
        public static readonly Usage WingFlaps = Instance.Create(0x00c3, "Wing Flaps");
        /// <summary>
        ///     Simulation: Accelerator Usage.
        /// </summary>
        public static readonly Usage Accelerator = Instance.Create(0x00c4, "Accelerator");
        /// <summary>
        ///     Simulation: Brake Usage.
        /// </summary>
        public static readonly Usage Brake = Instance.Create(0x00c5, "Brake");
        /// <summary>
        ///     Simulation: Clutch Usage.
        /// </summary>
        public static readonly Usage Clutch = Instance.Create(0x00c6, "Clutch");
        /// <summary>
        ///     Simulation: Shifter Usage.
        /// </summary>
        public static readonly Usage Shifter = Instance.Create(0x00c7, "Shifter");
        /// <summary>
        ///     Simulation: Steering Usage.
        /// </summary>
        public static readonly Usage Steering = Instance.Create(0x00c8, "Steering");
        /// <summary>
        ///     Simulation: Turret Direction Usage.
        /// </summary>
        public static readonly Usage TurretDirection = Instance.Create(0x00c9, "Turret Direction");
        /// <summary>
        ///     Simulation: Barrel Elevation Usage.
        /// </summary>
        public static readonly Usage BarrelElevation = Instance.Create(0x00ca, "Barrel Elevation");
        /// <summary>
        ///     Simulation: Dive Plane Usage.
        /// </summary>
        public static readonly Usage DivePlane = Instance.Create(0x00cb, "Dive Plane");
        /// <summary>
        ///     Simulation: Ballast Usage.
        /// </summary>
        public static readonly Usage Ballast = Instance.Create(0x00cc, "Ballast");
        /// <summary>
        ///     Simulation: Bicycle Crank Usage.
        /// </summary>
        public static readonly Usage BicycleCrank = Instance.Create(0x00cd, "Bicycle Crank");
        /// <summary>
        ///     Simulation: Handle Bars Usage.
        /// </summary>
        public static readonly Usage HandleBars = Instance.Create(0x00ce, "Handle Bars");
        /// <summary>
        ///     Simulation: Front Brake Usage.
        /// </summary>
        public static readonly Usage FrontBrake = Instance.Create(0x00cf, "Front Brake");
        /// <summary>
        ///     Simulation: Rear Brake Usage.
        /// </summary>
        public static readonly Usage RearBrake = Instance.Create(0x00d0, "Rear Brake");

        /// <summary>
        ///     Simulation: Undefined Usage.
        /// </summary>
        public static readonly Usage Undefined = Instance.Create(0x0000, "Undefined");

        /// <inheritdoc />
        private SimulationPage(ushort id, string name) : base(id, name, true)
        {
        }
    }

    /// <summary>
    ///     Class defining the VR Controls usage page.
    /// </summary>
    public sealed partial class VRPage : UsagePage
    {
        /// <summary>
        ///     The singleton instance of VRPage.
        /// </summary>
        public static readonly VRPage Instance = new VRPage(0x0003, "VR Controls");

        /// <summary>
        ///     VR: Belt Usage.
        /// </summary>
        public static readonly Usage Belt = Instance.Create(0x0001, "Belt");
        /// <summary>
        ///     VR: Body Suit Usage.
        /// </summary>
        public static readonly Usage BodySuit = Instance.Create(0x0002, "Body Suit");
        /// <summary>
        ///     VR: Flexor Usage.
        /// </summary>
        public static readonly Usage Flexor = Instance.Create(0x0003, "Flexor");
        /// <summary>
        ///     VR: Glove Usage.
        /// </summary>
        public static readonly Usage Glove = Instance.Create(0x0004, "Glove");
        /// <summary>
        ///     VR: Head Tracker Usage.
        /// </summary>
        public static readonly Usage HeadTracker = Instance.Create(0x0005, "Head Tracker");
        /// <summary>
        ///     VR: Head Mounted Display Usage.
        /// </summary>
        public static readonly Usage HeadMountedDisplay = Instance.Create(0x0006, "Head Mounted Display");
        /// <summary>
        ///     VR: Hand Tracker Usage.
        /// </summary>
        public static readonly Usage HandTracker = Instance.Create(0x0007, "Hand Tracker");
        /// <summary>
        ///     VR: Oculometer Usage.
        /// </summary>
        public static readonly Usage Oculometer = Instance.Create(0x0008, "Oculometer");
        /// <summary>
        ///     VR: Vest Usage.
        /// </summary>
        public static readonly Usage Vest = Instance.Create(0x0009, "Vest");
        /// <summary>
        ///     VR: Animatronic Device Usage.
        /// </summary>
        public static readonly Usage AnimatronicDevice = Instance.Create(0x000a, "Animatronic Device");

        /// <summary>
        ///     VR: Stereo Enable Usage.
        /// </summary>
        public static readonly Usage StereoEnable = Instance.Create(0x0020, "Stereo Enable");
        /// <summary>
        ///     VR: Display Enable Usage.
        /// </summary>
        public static readonly Usage DisplayEnable = Instance.Create(0x0021, "Display Enable");

        /// <summary>
        ///     VR: Undefined Usage.
        /// </summary>
        public static readonly Usage Undefined = Instance.Create(0x0000, "Undefined");

        /// <inheritdoc />
        private VRPage(ushort id, string name) : base(id, name, true)
        {
        }
    }

    /// <summary>
    ///     Class defining the Sport Controls usage page.
    /// </summary>
    public sealed partial class SportPage : UsagePage
    {
        /// <summary>
        ///     The singleton instance of SportPage.
        /// </summary>
        public static readonly SportPage Instance = new SportPage(0x0004, "Sport Controls");

        /// <summary>
        ///     Sport: Baseball Bat Usage.
        /// </summary>
        public static readonly Usage BaseballBat = Instance.Create(0x0001, "Baseball Bat");
        /// <summary>
        ///     Sport: Golf Club Usage.
        /// </summary>
        public static readonly Usage GolfClub = Instance.Create(0x0002, "Golf Club");
        /// <summary>
        ///     Sport: Rowing Machine Usage.
        /// </summary>
        public static readonly Usage RowingMachine = Instance.Create(0x0003, "Rowing Machine");
        /// <summary>
        ///     Sport: Treadmill Usage.
        /// </summary>
        public static readonly Usage Treadmill = Instance.Create(0x0004, "Treadmill");

        /// <summary>
        ///     Sport: Oar Usage.
        /// </summary>
        public static readonly Usage Oar = Instance.Create(0x0030, "Oar");
        /// <summary>
        ///     Sport: Slope Usage.
        /// </summary>
        public static readonly Usage Slope = Instance.Create(0x0031, "Slope");
        /// <summary>
        ///     Sport: Rate Usage.
        /// </summary>
        public static readonly Usage Rate = Instance.Create(0x0032, "Rate");
        /// <summary>
        ///     Sport: Stick Speed Usage.
        /// </summary>
        public static readonly Usage StickSpeed = Instance.Create(0x0033, "Stick Speed");
        /// <summary>
        ///     Sport: Stick Face Angle Usage.
        /// </summary>
        public static readonly Usage StickFaceAngle = Instance.Create(0x0034, "Stick Face Angle");
        /// <summary>
        ///     Sport: Stick Heel/Toe Usage.
        /// </summary>
        public static readonly Usage StickHeelToe = Instance.Create(0x0035, "Stick Heel/Toe");
        /// <summary>
        ///     Sport: Stick Follow Through Usage.
        /// </summary>
        public static readonly Usage StickFollowThrough = Instance.Create(0x0036, "Stick Follow Through");
        /// <summary>
        ///     Sport: Stick Tempo Usage.
        /// </summary>
        public static readonly Usage StickTempo = Instance.Create(0x0037, "Stick Tempo");
        /// <summary>
        ///     Sport: Stick Type Usage.
        /// </summary>
        public static readonly Usage StickType = Instance.Create(0x0038, "Stick Type");
        /// <summary>
        ///     Sport: Stick Height Usage.
        /// </summary>
        public static readonly Usage StickHeight = Instance.Create(0x0039, "Stick Height");

        /// <summary>
        ///     Sport: Putter Usage.
        /// </summary>
        public static readonly Usage Putter = Instance.Create(0x0050, "Putter");
        /// <summary>
        ///     Sport: 1 Iron Usage.
        /// </summary>
        public static readonly Usage Iron = Instance.Create(0x0051, "1 Iron");
        /// <summary>
        ///     Sport: 2 Iron Usage.
        /// </summary>
        public static readonly Usage Iron2 = Instance.Create(0x0052, "2 Iron");
        /// <summary>
        ///     Sport: 3 Iron Usage.
        /// </summary>
        public static readonly Usage Iron3 = Instance.Create(0x0053, "3 Iron");
        /// <summary>
        ///     Sport: 4 Iron Usage.
        /// </summary>
        public static readonly Usage Iron4 = Instance.Create(0x0054, "4 Iron");
        /// <summary>
        ///     Sport: 5 Iron Usage.
        /// </summary>
        public static readonly Usage Iron5 = Instance.Create(0x0055, "5 Iron");
        /// <summary>
        ///     Sport: 6 Iron Usage.
        /// </summary>
        public static readonly Usage Iron6 = Instance.Create(0x0056, "6 Iron");
        /// <summary>
        ///     Sport: 7 Iron Usage.
        /// </summary>
        public static readonly Usage Iron7 = Instance.Create(0x0057, "7 Iron");
        /// <summary>
        ///     Sport: 8 Iron Usage.
        /// </summary>
        public static readonly Usage Iron8 = Instance.Create(0x0058, "8 Iron");
        /// <summary>
        ///     Sport: 9 Iron Usage.
        /// </summary>
        public static readonly Usage Iron9 = Instance.Create(0x0059, "9 Iron");
        /// <summary>
        ///     Sport: 10 Iron Usage.
        /// </summary>
        public static readonly Usage Iron10 = Instance.Create(0x005a, "10 Iron");
        /// <summary>
        ///     Sport: 11 Iron Usage.
        /// </summary>
        public static readonly Usage Iron11 = Instance.Create(0x005b, "11 Iron");
        /// <summary>
        ///     Sport: Sand Wedge Usage.
        /// </summary>
        public static readonly Usage SandWedge = Instance.Create(0x005c, "Sand Wedge");
        /// <summary>
        ///     Sport: Loft Wedge Usage.
        /// </summary>
        public static readonly Usage LoftWedge = Instance.Create(0x005d, "Loft Wedge");
        /// <summary>
        ///     Sport: Power Wedge Usage.
        /// </summary>
        public static readonly Usage PowerWedge = Instance.Create(0x005e, "Power Wedge");
        /// <summary>
        ///     Sport: 1 Wood Usage.
        /// </summary>
        public static readonly Usage Wood = Instance.Create(0x005f, "1 Wood");
        /// <summary>
        ///     Sport: 3 Wood Usage.
        /// </summary>
        public static readonly Usage Wood2 = Instance.Create(0x0060, "3 Wood");
        /// <summary>
        ///     Sport: 5 Wood Usage.
        /// </summary>
        public static readonly Usage Wood3 = Instance.Create(0x0061, "5 Wood");
        /// <summary>
        ///     Sport: 7 Wood Usage.
        /// </summary>
        public static readonly Usage Wood4 = Instance.Create(0x0062, "7 Wood");
        /// <summary>
        ///     Sport: 9 Wood Usage.
        /// </summary>
        public static readonly Usage Wood5 = Instance.Create(0x0063, "9 Wood");

        /// <summary>
        ///     Sport: Undefined Usage.
        /// </summary>
        public static readonly Usage Undefined = Instance.Create(0x0000, "Undefined");

        /// <inheritdoc />
        private SportPage(ushort id, string name) : base(id, name, true)
        {
        }
    }

    /// <summary>
    ///     Class defining the Game Controls usage page.
    /// </summary>
    public sealed partial class GamePage : UsagePage
    {
        /// <summary>
        ///     The singleton instance of GamePage.
        /// </summary>
        public static readonly GamePage Instance = new GamePage(0x0005, "Game Controls");

        /// <summary>
        ///     Game: 3D Game Controller Usage.
        /// </summary>
        public static readonly Usage DGameController = Instance.Create(0x0001, "3D Game Controller");
        /// <summary>
        ///     Game: Pinball Device Usage.
        /// </summary>
        public static readonly Usage PinballDevice = Instance.Create(0x0002, "Pinball Device");
        /// <summary>
        ///     Game: Gun Device Usage.
        /// </summary>
        public static readonly Usage GunDevice = Instance.Create(0x0003, "Gun Device");

        /// <summary>
        ///     Game: Point of View Usage.
        /// </summary>
        public static readonly Usage PointOfView = Instance.Create(0x0020, "Point of View");
        /// <summary>
        ///     Game: Turn Right/Left Usage.
        /// </summary>
        public static readonly Usage TurnRightLeft = Instance.Create(0x0021, "Turn Right/Left");
        /// <summary>
        ///     Game: Pitch Right/Left Usage.
        /// </summary>
        public static readonly Usage PitchRightLeft = Instance.Create(0x0022, "Pitch Right/Left");
        /// <summary>
        ///     Game: Roll Right/Left Usage.
        /// </summary>
        public static readonly Usage RollRightLeft = Instance.Create(0x0023, "Roll Right/Left");
        /// <summary>
        ///     Game: Move Right/Left Usage.
        /// </summary>
        public static readonly Usage MoveRightLeft = Instance.Create(0x0024, "Move Right/Left");
        /// <summary>
        ///     Game: Move Forward/Backward Usage.
        /// </summary>
        public static readonly Usage MoveForwardBackward = Instance.Create(0x0025, "Move Forward/Backward");
        /// <summary>
        ///     Game: Move Up/Down Usage.
        /// </summary>
        public static readonly Usage MoveUpDown = Instance.Create(0x0026, "Move Up/Down");
        /// <summary>
        ///     Game: Lean Right/Left Usage.
        /// </summary>
        public static readonly Usage LeanRightLeft = Instance.Create(0x0027, "Lean Right/Left");
        /// <summary>
        ///     Game: Lean Forward/Backward Usage.
        /// </summary>
        public static readonly Usage LeanForwardBackward = Instance.Create(0x0028, "Lean Forward/Backward");
        /// <summary>
        ///     Game: Height of POV Usage.
        /// </summary>
        public static readonly Usage HeightOfPOV = Instance.Create(0x0029, "Height of POV");
        /// <summary>
        ///     Game: Flipper Usage.
        /// </summary>
        public static readonly Usage Flipper = Instance.Create(0x002a, "Flipper");
        /// <summary>
        ///     Game: Secondary Flipper Usage.
        /// </summary>
        public static readonly Usage SecondaryFlipper = Instance.Create(0x002b, "Secondary Flipper");
        /// <summary>
        ///     Game: Bump Usage.
        /// </summary>
        public static readonly Usage Bump = Instance.Create(0x002c, "Bump");
        /// <summary>
        ///     Game: New Game Usage.
        /// </summary>
        public static readonly Usage NewGame = Instance.Create(0x002d, "New Game");
        /// <summary>
        ///     Game: Shoot Ball Usage.
        /// </summary>
        public static readonly Usage ShootBall = Instance.Create(0x002e, "Shoot Ball");
        /// <summary>
        ///     Game: Player Usage.
        /// </summary>
        public static readonly Usage Player = Instance.Create(0x002f, "Player");
        /// <summary>
        ///     Game: Gun Bolt Usage.
        /// </summary>
        public static readonly Usage GunBolt = Instance.Create(0x0030, "Gun Bolt");
        /// <summary>
        ///     Game: Gun Clip Usage.
        /// </summary>
        public static readonly Usage GunClip = Instance.Create(0x0031, "Gun Clip");
        /// <summary>
        ///     Game: Gun Selector Usage.
        /// </summary>
        public static readonly Usage GunSelector = Instance.Create(0x0032, "Gun Selector");
        /// <summary>
        ///     Game: Gun Single Shot Usage.
        /// </summary>
        public static readonly Usage GunSingleShot = Instance.Create(0x0033, "Gun Single Shot");
        /// <summary>
        ///     Game: Gun Burst Usage.
        /// </summary>
        public static readonly Usage GunBurst = Instance.Create(0x0034, "Gun Burst");
        /// <summary>
        ///     Game: Gun Automatic Usage.
        /// </summary>
        public static readonly Usage GunAutomatic = Instance.Create(0x0035, "Gun Automatic");
        /// <summary>
        ///     Game: Gun Safety Usage.
        /// </summary>
        public static readonly Usage GunSafety = Instance.Create(0x0036, "Gun Safety");
        /// <summary>
        ///     Game: Gamepad Fire/Jump Usage.
        /// </summary>
        public static readonly Usage GamepadFireJump = Instance.Create(0x0037, "Gamepad Fire/Jump");

        /// <summary>
        ///     Game: Gamepad Trigger Usage.
        /// </summary>
        public static readonly Usage GamepadTrigger = Instance.Create(0x0039, "Gamepad Trigger");
        /// <summary>
        ///     Game: Form-fitting Gamepad Usage.
        /// </summary>
        public static readonly Usage FormfittingGamepad = Instance.Create(0x003a, "Form-fitting Gamepad");

        /// <summary>
        ///     Game: Undefined Usage.
        /// </summary>
        public static readonly Usage Undefined = Instance.Create(0x0000, "Undefined");

        /// <inheritdoc />
        private GamePage(ushort id, string name) : base(id, name, true)
        {
        }
    }

    /// <summary>
    ///     Class defining the Generic Device Controls usage page.
    /// </summary>
    public sealed partial class GenericDevicePage : UsagePage
    {
        /// <summary>
        ///     The singleton instance of GenericDevicePage.
        /// </summary>
        public static readonly GenericDevicePage Instance = new GenericDevicePage(0x0006, "Generic Device Controls");

        /// <summary>
        ///     GenericDevice: Background Controls Usage.
        /// </summary>
        public static readonly Usage BackgroundControls = Instance.Create(0x0001, "Background Controls");

        /// <summary>
        ///     GenericDevice: Battery Strength Usage.
        /// </summary>
        public static readonly Usage BatteryStrength = Instance.Create(0x0020, "Battery Strength");
        /// <summary>
        ///     GenericDevice: Wireless Channel Usage.
        /// </summary>
        public static readonly Usage WirelessChannel = Instance.Create(0x0021, "Wireless Channel");
        /// <summary>
        ///     GenericDevice: Wireless ID Usage.
        /// </summary>
        public static readonly Usage WirelessID = Instance.Create(0x0022, "Wireless ID");
        /// <summary>
        ///     GenericDevice: Discover Wireless Control Usage.
        /// </summary>
        public static readonly Usage DiscoverWirelessControl = Instance.Create(0x0023, "Discover Wireless Control");
        /// <summary>
        ///     GenericDevice: Security Code Character Entered Usage.
        /// </summary>
        public static readonly Usage SecurityCodeCharacterEntered = Instance.Create(0x0024, "Security Code Character Entered");
        /// <summary>
        ///     GenericDevice: Security Code Character Erased Usage.
        /// </summary>
        public static readonly Usage SecurityCodeCharacterErased = Instance.Create(0x0025, "Security Code Character Erased");
        /// <summary>
        ///     GenericDevice: Security Code Cleared Usage.
        /// </summary>
        public static readonly Usage SecurityCodeCleared = Instance.Create(0x0026, "Security Code Cleared");
        /// <summary>
        ///     GenericDevice: Sequence ID Usage.
        /// </summary>
        public static readonly Usage SequenceID = Instance.Create(0x0027, "Sequence ID");
        /// <summary>
        ///     GenericDevice: Sequence ID Reset Usage.
        /// </summary>
        public static readonly Usage SequenceIDReset = Instance.Create(0x0028, "Sequence ID Reset");
        /// <summary>
        ///     GenericDevice: RF Signal Strength Usage.
        /// </summary>
        public static readonly Usage RFSignalStrength = Instance.Create(0x0029, "RF Signal Strength");
        /// <summary>
        ///     GenericDevice: Software Version Usage.
        /// </summary>
        public static readonly Usage SoftwareVersion = Instance.Create(0x002a, "Software Version");
        /// <summary>
        ///     GenericDevice: Protocol Version Usage.
        /// </summary>
        public static readonly Usage ProtocolVersion = Instance.Create(0x002b, "Protocol Version");
        /// <summary>
        ///     GenericDevice: Hardware Version Usage.
        /// </summary>
        public static readonly Usage HardwareVersion = Instance.Create(0x002c, "Hardware Version");
        /// <summary>
        ///     GenericDevice: Major Usage.
        /// </summary>
        public static readonly Usage Major = Instance.Create(0x002d, "Major");
        /// <summary>
        ///     GenericDevice: Minor Usage.
        /// </summary>
        public static readonly Usage Minor = Instance.Create(0x002e, "Minor");
        /// <summary>
        ///     GenericDevice: Revision Usage.
        /// </summary>
        public static readonly Usage Revision = Instance.Create(0x002f, "Revision");
        /// <summary>
        ///     GenericDevice: Handedness Usage.
        /// </summary>
        public static readonly Usage Handedness = Instance.Create(0x0030, "Handedness");
        /// <summary>
        ///     GenericDevice: Either Hand Usage.
        /// </summary>
        public static readonly Usage EitherHand = Instance.Create(0x0031, "Either Hand");
        /// <summary>
        ///     GenericDevice: Left Hand Usage.
        /// </summary>
        public static readonly Usage LeftHand = Instance.Create(0x0032, "Left Hand");
        /// <summary>
        ///     GenericDevice: Right Hand Usage.
        /// </summary>
        public static readonly Usage RightHand = Instance.Create(0x0033, "Right Hand");
        /// <summary>
        ///     GenericDevice: Both Hands Usage.
        /// </summary>
        public static readonly Usage BothHands = Instance.Create(0x0034, "Both Hands");

        /// <summary>
        ///     GenericDevice: Grip Pose Offset Usage.
        /// </summary>
        public static readonly Usage GripPoseOffset = Instance.Create(0x0040, "Grip Pose Offset");
        /// <summary>
        ///     GenericDevice: Pointer Pose Offset Usage.
        /// </summary>
        public static readonly Usage PointerPoseOffset = Instance.Create(0x0041, "Pointer Pose Offset");

        /// <summary>
        ///     GenericDevice: Undefined Usage.
        /// </summary>
        public static readonly Usage Undefined = Instance.Create(0x0000, "Undefined");

        /// <inheritdoc />
        private GenericDevicePage(ushort id, string name) : base(id, name, true)
        {
        }
    }

    /// <summary>
    ///     Class defining the Keyboard/Keypad usage page.
    /// </summary>
    public sealed partial class KeyboardKeypadPage : UsagePage
    {
        /// <summary>
        ///     The singleton instance of KeyboardKeypadPage.
        /// </summary>
        public static readonly KeyboardKeypadPage Instance = new KeyboardKeypadPage(0x0007, "Keyboard/Keypad");

        /// <summary>
        ///     KeyboardKeypad: None Usage.
        /// </summary>
        public static readonly Usage None = Instance.Create(0x0000, "None");
        /// <summary>
        ///     KeyboardKeypad: ErrorRollOver Usage.
        /// </summary>
        public static readonly Usage ErrorRollOver = Instance.Create(0x0001, "ErrorRollOver");
        /// <summary>
        ///     KeyboardKeypad: POSTFail Usage.
        /// </summary>
        public static readonly Usage POSTFail = Instance.Create(0x0002, "POSTFail");
        /// <summary>
        ///     KeyboardKeypad: ErrorUndefined Usage.
        /// </summary>
        public static readonly Usage ErrorUndefined = Instance.Create(0x0003, "ErrorUndefined");
        /// <summary>
        ///     KeyboardKeypad: a A Usage.
        /// </summary>
        public static readonly Usage AA = Instance.Create(0x0004, "a A");
        /// <summary>
        ///     KeyboardKeypad: b B Usage.
        /// </summary>
        public static readonly Usage BB = Instance.Create(0x0005, "b B");
        /// <summary>
        ///     KeyboardKeypad: c C Usage.
        /// </summary>
        public static readonly Usage CC = Instance.Create(0x0006, "c C");
        /// <summary>
        ///     KeyboardKeypad: d D Usage.
        /// </summary>
        public static readonly Usage DD = Instance.Create(0x0007, "d D");
        /// <summary>
        ///     KeyboardKeypad: e E Usage.
        /// </summary>
        public static readonly Usage EE = Instance.Create(0x0008, "e E");
        /// <summary>
        ///     KeyboardKeypad: f F Usage.
        /// </summary>
        public static readonly Usage FF = Instance.Create(0x0009, "f F");
        /// <summary>
        ///     KeyboardKeypad: g G Usage.
        /// </summary>
        public static readonly Usage GG = Instance.Create(0x000a, "g G");
        /// <summary>
        ///     KeyboardKeypad: h H Usage.
        /// </summary>
        public static readonly Usage HH = Instance.Create(0x000b, "h H");
        /// <summary>
        ///     KeyboardKeypad: i I Usage.
        /// </summary>
        public static readonly Usage II = Instance.Create(0x000c, "i I");
        /// <summary>
        ///     KeyboardKeypad: j J Usage.
        /// </summary>
        public static readonly Usage JJ = Instance.Create(0x000d, "j J");
        /// <summary>
        ///     KeyboardKeypad: k K Usage.
        /// </summary>
        public static readonly Usage KK = Instance.Create(0x000e, "k K");
        /// <summary>
        ///     KeyboardKeypad: l L Usage.
        /// </summary>
        public static readonly Usage LL = Instance.Create(0x000f, "l L");
        /// <summary>
        ///     KeyboardKeypad: m M Usage.
        /// </summary>
        public static readonly Usage MM = Instance.Create(0x0010, "m M");
        /// <summary>
        ///     KeyboardKeypad: n N Usage.
        /// </summary>
        public static readonly Usage NN = Instance.Create(0x0011, "n N");
        /// <summary>
        ///     KeyboardKeypad: o O Usage.
        /// </summary>
        public static readonly Usage OO = Instance.Create(0x0012, "o O");
        /// <summary>
        ///     KeyboardKeypad: p P Usage.
        /// </summary>
        public static readonly Usage PP = Instance.Create(0x0013, "p P");
        /// <summary>
        ///     KeyboardKeypad: q Q Usage.
        /// </summary>
        public static readonly Usage QQ = Instance.Create(0x0014, "q Q");
        /// <summary>
        ///     KeyboardKeypad: r R Usage.
        /// </summary>
        public static readonly Usage RR = Instance.Create(0x0015, "r R");
        /// <summary>
        ///     KeyboardKeypad: s S Usage.
        /// </summary>
        public static readonly Usage SS = Instance.Create(0x0016, "s S");
        /// <summary>
        ///     KeyboardKeypad: t T Usage.
        /// </summary>
        public static readonly Usage TT = Instance.Create(0x0017, "t T");
        /// <summary>
        ///     KeyboardKeypad: u U Usage.
        /// </summary>
        public static readonly Usage UU = Instance.Create(0x0018, "u U");
        /// <summary>
        ///     KeyboardKeypad: v V Usage.
        /// </summary>
        public static readonly Usage VV = Instance.Create(0x0019, "v V");
        /// <summary>
        ///     KeyboardKeypad: w W Usage.
        /// </summary>
        public static readonly Usage WW = Instance.Create(0x001a, "w W");
        /// <summary>
        ///     KeyboardKeypad: x X Usage.
        /// </summary>
        public static readonly Usage XX = Instance.Create(0x001b, "x X");
        /// <summary>
        ///     KeyboardKeypad: y Y Usage.
        /// </summary>
        public static readonly Usage YY = Instance.Create(0x001c, "y Y");
        /// <summary>
        ///     KeyboardKeypad: z Z Usage.
        /// </summary>
        public static readonly Usage ZZ = Instance.Create(0x001d, "z Z");
        /// <summary>
        ///     KeyboardKeypad: 1 ! Usage.
        /// </summary>
        public static readonly Usage KeyboardKeypad_1 = Instance.Create(0x001e, "1 !");
        /// <summary>
        ///     KeyboardKeypad: 2 @ Usage.
        /// </summary>
        public static readonly Usage KeyboardKeypad_2 = Instance.Create(0x001f, "2 @");
        /// <summary>
        ///     KeyboardKeypad: 3 # Usage.
        /// </summary>
        public static readonly Usage KeyboardKeypad_3 = Instance.Create(0x0020, "3 #");
        /// <summary>
        ///     KeyboardKeypad: 4 $ Usage.
        /// </summary>
        public static readonly Usage KeyboardKeypad_4 = Instance.Create(0x0021, "4 $");
        /// <summary>
        ///     KeyboardKeypad: 5 % Usage.
        /// </summary>
        public static readonly Usage KeyboardKeypad_5 = Instance.Create(0x0022, "5 %");
        /// <summary>
        ///     KeyboardKeypad: 6 ^ Usage.
        /// </summary>
        public static readonly Usage KeyboardKeypad_6 = Instance.Create(0x0023, "6 ^");
        /// <summary>
        ///     KeyboardKeypad: 7 & Usage.
        /// </summary>
        public static readonly Usage KeyboardKeypad_7 = Instance.Create(0x0024, "7 &");
        /// <summary>
        ///     KeyboardKeypad: 8 * Usage.
        /// </summary>
        public static readonly Usage KeyboardKeypad_8 = Instance.Create(0x0025, "8 *");
        /// <summary>
        ///     KeyboardKeypad: 9 ( Usage.
        /// </summary>
        public static readonly Usage KeyboardKeypad_9 = Instance.Create(0x0026, "9 (");
        /// <summary>
        ///     KeyboardKeypad: 0 ) Usage.
        /// </summary>
        public static readonly Usage KeyboardKeypad_0 = Instance.Create(0x0027, "0 )");
        /// <summary>
        ///     KeyboardKeypad: Enter Usage.
        /// </summary>
        public static readonly Usage Enter = Instance.Create(0x0028, "Enter");
        /// <summary>
        ///     KeyboardKeypad: Esc Usage.
        /// </summary>
        public static readonly Usage Esc = Instance.Create(0x0029, "Esc");
        /// <summary>
        ///     KeyboardKeypad: Backspace Usage.
        /// </summary>
        public static readonly Usage Backspace = Instance.Create(0x002a, "Backspace");
        /// <summary>
        ///     KeyboardKeypad: Tab Usage.
        /// </summary>
        public static readonly Usage Tab = Instance.Create(0x002b, "Tab");
        /// <summary>
        ///     KeyboardKeypad: Space Usage.
        /// </summary>
        public static readonly Usage Space = Instance.Create(0x002c, "Space");
        /// <summary>
        ///     KeyboardKeypad: - _ Usage.
        /// </summary>
        public static readonly Usage _ = Instance.Create(0x002d, "- _");
        /// <summary>
        ///     KeyboardKeypad: = + Usage.
        /// </summary>
        public static readonly Usage KeyboardKeypad_ = Instance.Create(0x002e, "= +");
        /// <summary>
        ///     KeyboardKeypad: [ { Usage.
        /// </summary>
        public static readonly Usage KeyboardKeypad_10 = Instance.Create(0x002f, "[ {");
        /// <summary>
        ///     KeyboardKeypad: ] } Usage.
        /// </summary>
        public static readonly Usage KeyboardKeypad_11 = Instance.Create(0x0030, "] }");
        /// <summary>
        ///     KeyboardKeypad: \ | Usage.
        /// </summary>
        public static readonly Usage KeyboardKeypad_12 = Instance.Create(0x0031, "\\ |");
        /// <summary>
        ///     KeyboardKeypad: # ~ Usage.
        /// </summary>
        public static readonly Usage KeyboardKeypad_13 = Instance.Create(0x0032, "# ~");
        /// <summary>
        ///     KeyboardKeypad: ; : Usage.
        /// </summary>
        public static readonly Usage KeyboardKeypad_14 = Instance.Create(0x0033, "; :");
        /// <summary>
        ///     KeyboardKeypad: '  Usage.
        /// </summary>
        public static readonly Usage KeyboardKeypad_15 = Instance.Create(0x0034, "' ");
        /// <summary>
        ///     KeyboardKeypad: ` ´ Usage.
        /// </summary>
        public static readonly Usage KeyboardKeypad_16 = Instance.Create(0x0035, "` ´");
        /// <summary>
        ///     KeyboardKeypad: , < Usage.
        /// </summary>
        public static readonly Usage KeyboardKeypad_17 = Instance.Create(0x0036, ", <");
        /// <summary>
        ///     KeyboardKeypad: . > Usage.
        /// </summary>
        public static readonly Usage KeyboardKeypad_18 = Instance.Create(0x0037, ". >");
        /// <summary>
        ///     KeyboardKeypad: / ? Usage.
        /// </summary>
        public static readonly Usage KeyboardKeypad_19 = Instance.Create(0x0038, "/ ?");
        /// <summary>
        ///     KeyboardKeypad: CapsLock Usage.
        /// </summary>
        public static readonly Usage CapsLock = Instance.Create(0x0039, "CapsLock");
        /// <summary>
        ///     KeyboardKeypad: F1 Usage.
        /// </summary>
        public static readonly Usage F1 = Instance.Create(0x003a, "F1");
        /// <summary>
        ///     KeyboardKeypad: F2 Usage.
        /// </summary>
        public static readonly Usage F2 = Instance.Create(0x003b, "F2");
        /// <summary>
        ///     KeyboardKeypad: F3 Usage.
        /// </summary>
        public static readonly Usage F3 = Instance.Create(0x003c, "F3");
        /// <summary>
        ///     KeyboardKeypad: F4 Usage.
        /// </summary>
        public static readonly Usage F4 = Instance.Create(0x003d, "F4");
        /// <summary>
        ///     KeyboardKeypad: F5 Usage.
        /// </summary>
        public static readonly Usage F5 = Instance.Create(0x003e, "F5");
        /// <summary>
        ///     KeyboardKeypad: F6 Usage.
        /// </summary>
        public static readonly Usage F6 = Instance.Create(0x003f, "F6");
        /// <summary>
        ///     KeyboardKeypad: F7 Usage.
        /// </summary>
        public static readonly Usage F7 = Instance.Create(0x0040, "F7");
        /// <summary>
        ///     KeyboardKeypad: F8 Usage.
        /// </summary>
        public static readonly Usage F8 = Instance.Create(0x0041, "F8");
        /// <summary>
        ///     KeyboardKeypad: F9 Usage.
        /// </summary>
        public static readonly Usage F9 = Instance.Create(0x0042, "F9");
        /// <summary>
        ///     KeyboardKeypad: F10 Usage.
        /// </summary>
        public static readonly Usage F10 = Instance.Create(0x0043, "F10");
        /// <summary>
        ///     KeyboardKeypad: F11 Usage.
        /// </summary>
        public static readonly Usage F11 = Instance.Create(0x0044, "F11");
        /// <summary>
        ///     KeyboardKeypad: F12 Usage.
        /// </summary>
        public static readonly Usage F12 = Instance.Create(0x0045, "F12");
        /// <summary>
        ///     KeyboardKeypad: PrintScreen SysRq Usage.
        /// </summary>
        public static readonly Usage PrintScreenSysRq = Instance.Create(0x0046, "PrintScreen SysRq");
        /// <summary>
        ///     KeyboardKeypad: ScrollLock Usage.
        /// </summary>
        public static readonly Usage ScrollLock = Instance.Create(0x0047, "ScrollLock");
        /// <summary>
        ///     KeyboardKeypad: Pause Usage.
        /// </summary>
        public static readonly Usage Pause = Instance.Create(0x0048, "Pause");
        /// <summary>
        ///     KeyboardKeypad: Insert Usage.
        /// </summary>
        public static readonly Usage Insert = Instance.Create(0x0049, "Insert");
        /// <summary>
        ///     KeyboardKeypad: Home Usage.
        /// </summary>
        public static readonly Usage Home = Instance.Create(0x004a, "Home");
        /// <summary>
        ///     KeyboardKeypad: PageUp Usage.
        /// </summary>
        public static readonly Usage PageUp = Instance.Create(0x004b, "PageUp");
        /// <summary>
        ///     KeyboardKeypad: Delete Usage.
        /// </summary>
        public static readonly Usage Delete = Instance.Create(0x004c, "Delete");
        /// <summary>
        ///     KeyboardKeypad: End Usage.
        /// </summary>
        public static readonly Usage End = Instance.Create(0x004d, "End");
        /// <summary>
        ///     KeyboardKeypad: PageDown Usage.
        /// </summary>
        public static readonly Usage PageDown = Instance.Create(0x004e, "PageDown");
        /// <summary>
        ///     KeyboardKeypad: RightArrow Usage.
        /// </summary>
        public static readonly Usage RightArrow = Instance.Create(0x004f, "RightArrow");
        /// <summary>
        ///     KeyboardKeypad: LeftArrow Usage.
        /// </summary>
        public static readonly Usage LeftArrow = Instance.Create(0x0050, "LeftArrow");
        /// <summary>
        ///     KeyboardKeypad: DownArrow Usage.
        /// </summary>
        public static readonly Usage DownArrow = Instance.Create(0x0051, "DownArrow");
        /// <summary>
        ///     KeyboardKeypad: UpArrow Usage.
        /// </summary>
        public static readonly Usage UpArrow = Instance.Create(0x0052, "UpArrow");
        /// <summary>
        ///     KeyboardKeypad: NumLock Clear Usage.
        /// </summary>
        public static readonly Usage NumLockClear = Instance.Create(0x0053, "NumLock Clear");
        /// <summary>
        ///     KeyboardKeypad: Keypad / Usage.
        /// </summary>
        public static readonly Usage Keypad = Instance.Create(0x0054, "Keypad /");
        /// <summary>
        ///     KeyboardKeypad: Keypad * Usage.
        /// </summary>
        public static readonly Usage Keypad2 = Instance.Create(0x0055, "Keypad *");
        /// <summary>
        ///     KeyboardKeypad: Keypad - Usage.
        /// </summary>
        public static readonly Usage Keypad3 = Instance.Create(0x0056, "Keypad -");
        /// <summary>
        ///     KeyboardKeypad: Keypad + Usage.
        /// </summary>
        public static readonly Usage Keypad4 = Instance.Create(0x0057, "Keypad +");
        /// <summary>
        ///     KeyboardKeypad: Keypad Enter Usage.
        /// </summary>
        public static readonly Usage KeypadEnter = Instance.Create(0x0058, "Keypad Enter");
        /// <summary>
        ///     KeyboardKeypad: Keypad 1 Usage.
        /// </summary>
        public static readonly Usage Keypad1 = Instance.Create(0x0059, "Keypad 1");
        /// <summary>
        ///     KeyboardKeypad: Keypad 2 Usage.
        /// </summary>
        public static readonly Usage Keypad22 = Instance.Create(0x005a, "Keypad 2");
        /// <summary>
        ///     KeyboardKeypad: Keypad 3 Usage.
        /// </summary>
        public static readonly Usage Keypad32 = Instance.Create(0x005b, "Keypad 3");
        /// <summary>
        ///     KeyboardKeypad: Keypad 4 Usage.
        /// </summary>
        public static readonly Usage Keypad42 = Instance.Create(0x005c, "Keypad 4");
        /// <summary>
        ///     KeyboardKeypad: Keypad 5 Usage.
        /// </summary>
        public static readonly Usage Keypad5 = Instance.Create(0x005d, "Keypad 5");
        /// <summary>
        ///     KeyboardKeypad: Keypad 6 Usage.
        /// </summary>
        public static readonly Usage Keypad6 = Instance.Create(0x005e, "Keypad 6");
        /// <summary>
        ///     KeyboardKeypad: Keypad 7 Usage.
        /// </summary>
        public static readonly Usage Keypad7 = Instance.Create(0x005f, "Keypad 7");
        /// <summary>
        ///     KeyboardKeypad: Keypad 8 Usage.
        /// </summary>
        public static readonly Usage Keypad8 = Instance.Create(0x0060, "Keypad 8");
        /// <summary>
        ///     KeyboardKeypad: Keypad 9 Usage.
        /// </summary>
        public static readonly Usage Keypad9 = Instance.Create(0x0061, "Keypad 9");
        /// <summary>
        ///     KeyboardKeypad: Keypad 0 Usage.
        /// </summary>
        public static readonly Usage Keypad0 = Instance.Create(0x0062, "Keypad 0");
        /// <summary>
        ///     KeyboardKeypad: Keypad . Usage.
        /// </summary>
        public static readonly Usage Keypad10 = Instance.Create(0x0063, "Keypad .");
        /// <summary>
        ///     KeyboardKeypad: \ | Usage.
        /// </summary>
        public static readonly Usage KeyboardKeypad_20 = Instance.Create(0x0064, "\\ |");
        /// <summary>
        ///     KeyboardKeypad: Application Usage.
        /// </summary>
        public static readonly Usage Application = Instance.Create(0x0065, "Application");
        /// <summary>
        ///     KeyboardKeypad: Power Usage.
        /// </summary>
        public static readonly Usage Power = Instance.Create(0x0066, "Power");
        /// <summary>
        ///     KeyboardKeypad: Keypad = Usage.
        /// </summary>
        public static readonly Usage Keypad11 = Instance.Create(0x0067, "Keypad =");
        /// <summary>
        ///     KeyboardKeypad: F13 Usage.
        /// </summary>
        public static readonly Usage F13 = Instance.Create(0x0068, "F13");
        /// <summary>
        ///     KeyboardKeypad: F14 Usage.
        /// </summary>
        public static readonly Usage F14 = Instance.Create(0x0069, "F14");
        /// <summary>
        ///     KeyboardKeypad: F15 Usage.
        /// </summary>
        public static readonly Usage F15 = Instance.Create(0x006a, "F15");
        /// <summary>
        ///     KeyboardKeypad: F16 Usage.
        /// </summary>
        public static readonly Usage F16 = Instance.Create(0x006b, "F16");
        /// <summary>
        ///     KeyboardKeypad: F17 Usage.
        /// </summary>
        public static readonly Usage F17 = Instance.Create(0x006c, "F17");
        /// <summary>
        ///     KeyboardKeypad: F18 Usage.
        /// </summary>
        public static readonly Usage F18 = Instance.Create(0x006d, "F18");
        /// <summary>
        ///     KeyboardKeypad: F19 Usage.
        /// </summary>
        public static readonly Usage F19 = Instance.Create(0x006e, "F19");
        /// <summary>
        ///     KeyboardKeypad: F20 Usage.
        /// </summary>
        public static readonly Usage F20 = Instance.Create(0x006f, "F20");
        /// <summary>
        ///     KeyboardKeypad: F21 Usage.
        /// </summary>
        public static readonly Usage F21 = Instance.Create(0x0070, "F21");
        /// <summary>
        ///     KeyboardKeypad: F22 Usage.
        /// </summary>
        public static readonly Usage F22 = Instance.Create(0x0071, "F22");
        /// <summary>
        ///     KeyboardKeypad: F23 Usage.
        /// </summary>
        public static readonly Usage F23 = Instance.Create(0x0072, "F23");
        /// <summary>
        ///     KeyboardKeypad: F24 Usage.
        /// </summary>
        public static readonly Usage F24 = Instance.Create(0x0073, "F24");
        /// <summary>
        ///     KeyboardKeypad: Execute Usage.
        /// </summary>
        public static readonly Usage Execute = Instance.Create(0x0074, "Execute");
        /// <summary>
        ///     KeyboardKeypad: Help Usage.
        /// </summary>
        public static readonly Usage Help = Instance.Create(0x0075, "Help");
        /// <summary>
        ///     KeyboardKeypad: Menu Usage.
        /// </summary>
        public static readonly Usage Menu = Instance.Create(0x0076, "Menu");
        /// <summary>
        ///     KeyboardKeypad: Select Usage.
        /// </summary>
        public static readonly Usage Select = Instance.Create(0x0077, "Select");
        /// <summary>
        ///     KeyboardKeypad: Stop Usage.
        /// </summary>
        public static readonly Usage Stop = Instance.Create(0x0078, "Stop");
        /// <summary>
        ///     KeyboardKeypad: Again Usage.
        /// </summary>
        public static readonly Usage Again = Instance.Create(0x0079, "Again");
        /// <summary>
        ///     KeyboardKeypad: Undo Usage.
        /// </summary>
        public static readonly Usage Undo = Instance.Create(0x007a, "Undo");
        /// <summary>
        ///     KeyboardKeypad: Cut Usage.
        /// </summary>
        public static readonly Usage Cut = Instance.Create(0x007b, "Cut");
        /// <summary>
        ///     KeyboardKeypad: Copy Usage.
        /// </summary>
        public static readonly Usage Copy = Instance.Create(0x007c, "Copy");
        /// <summary>
        ///     KeyboardKeypad: Paste Usage.
        /// </summary>
        public static readonly Usage Paste = Instance.Create(0x007d, "Paste");
        /// <summary>
        ///     KeyboardKeypad: Find Usage.
        /// </summary>
        public static readonly Usage Find = Instance.Create(0x007e, "Find");
        /// <summary>
        ///     KeyboardKeypad: Mute Usage.
        /// </summary>
        public static readonly Usage Mute = Instance.Create(0x007f, "Mute");
        /// <summary>
        ///     KeyboardKeypad: VolumeUp Usage.
        /// </summary>
        public static readonly Usage VolumeUp = Instance.Create(0x0080, "VolumeUp");
        /// <summary>
        ///     KeyboardKeypad: VolumeDown Usage.
        /// </summary>
        public static readonly Usage VolumeDown = Instance.Create(0x0081, "VolumeDown");
        /// <summary>
        ///     KeyboardKeypad: LockingCapsLock Usage.
        /// </summary>
        public static readonly Usage LockingCapsLock = Instance.Create(0x0082, "LockingCapsLock");
        /// <summary>
        ///     KeyboardKeypad: LockingNumLock Usage.
        /// </summary>
        public static readonly Usage LockingNumLock = Instance.Create(0x0083, "LockingNumLock");
        /// <summary>
        ///     KeyboardKeypad: LockingScrollLock Usage.
        /// </summary>
        public static readonly Usage LockingScrollLock = Instance.Create(0x0084, "LockingScrollLock");
        /// <summary>
        ///     KeyboardKeypad: Keypad , Usage.
        /// </summary>
        public static readonly Usage Keypad12 = Instance.Create(0x0085, "Keypad ,");
        /// <summary>
        ///     KeyboardKeypad: Keypad == Usage.
        /// </summary>
        public static readonly Usage Keypad13 = Instance.Create(0x0086, "Keypad ==");
        /// <summary>
        ///     KeyboardKeypad: International1 Usage.
        /// </summary>
        public static readonly Usage International1 = Instance.Create(0x0087, "International1");
        /// <summary>
        ///     KeyboardKeypad: International2 Usage.
        /// </summary>
        public static readonly Usage International2 = Instance.Create(0x0088, "International2");
        /// <summary>
        ///     KeyboardKeypad: International3 Usage.
        /// </summary>
        public static readonly Usage International3 = Instance.Create(0x0089, "International3");
        /// <summary>
        ///     KeyboardKeypad: International4 Usage.
        /// </summary>
        public static readonly Usage International4 = Instance.Create(0x008a, "International4");
        /// <summary>
        ///     KeyboardKeypad: International5 Usage.
        /// </summary>
        public static readonly Usage International5 = Instance.Create(0x008b, "International5");
        /// <summary>
        ///     KeyboardKeypad: International6 Usage.
        /// </summary>
        public static readonly Usage International6 = Instance.Create(0x008c, "International6");
        /// <summary>
        ///     KeyboardKeypad: International7 Usage.
        /// </summary>
        public static readonly Usage International7 = Instance.Create(0x008d, "International7");
        /// <summary>
        ///     KeyboardKeypad: International8 Usage.
        /// </summary>
        public static readonly Usage International8 = Instance.Create(0x008e, "International8");
        /// <summary>
        ///     KeyboardKeypad: International9 Usage.
        /// </summary>
        public static readonly Usage International9 = Instance.Create(0x008f, "International9");
        /// <summary>
        ///     KeyboardKeypad: LANG1 Usage.
        /// </summary>
        public static readonly Usage LANG1 = Instance.Create(0x0090, "LANG1");
        /// <summary>
        ///     KeyboardKeypad: LANG2 Usage.
        /// </summary>
        public static readonly Usage LANG2 = Instance.Create(0x0091, "LANG2");
        /// <summary>
        ///     KeyboardKeypad: LANG3 Usage.
        /// </summary>
        public static readonly Usage LANG3 = Instance.Create(0x0092, "LANG3");
        /// <summary>
        ///     KeyboardKeypad: LANG4 Usage.
        /// </summary>
        public static readonly Usage LANG4 = Instance.Create(0x0093, "LANG4");
        /// <summary>
        ///     KeyboardKeypad: LANG5 Usage.
        /// </summary>
        public static readonly Usage LANG5 = Instance.Create(0x0094, "LANG5");
        /// <summary>
        ///     KeyboardKeypad: LANG6 Usage.
        /// </summary>
        public static readonly Usage LANG6 = Instance.Create(0x0095, "LANG6");
        /// <summary>
        ///     KeyboardKeypad: LANG7 Usage.
        /// </summary>
        public static readonly Usage LANG7 = Instance.Create(0x0096, "LANG7");
        /// <summary>
        ///     KeyboardKeypad: LANG8 Usage.
        /// </summary>
        public static readonly Usage LANG8 = Instance.Create(0x0097, "LANG8");
        /// <summary>
        ///     KeyboardKeypad: LANG9 Usage.
        /// </summary>
        public static readonly Usage LANG9 = Instance.Create(0x0098, "LANG9");
        /// <summary>
        ///     KeyboardKeypad: Alternate Erase Usage.
        /// </summary>
        public static readonly Usage AlternateErase = Instance.Create(0x0099, "Alternate Erase");
        /// <summary>
        ///     KeyboardKeypad: SysReq Attention Usage.
        /// </summary>
        public static readonly Usage SysReqAttention = Instance.Create(0x009a, "SysReq Attention");
        /// <summary>
        ///     KeyboardKeypad: Cancel Usage.
        /// </summary>
        public static readonly Usage Cancel = Instance.Create(0x009b, "Cancel");
        /// <summary>
        ///     KeyboardKeypad: Clear Usage.
        /// </summary>
        public static readonly Usage Clear = Instance.Create(0x009c, "Clear");
        /// <summary>
        ///     KeyboardKeypad: Prior Usage.
        /// </summary>
        public static readonly Usage Prior = Instance.Create(0x009d, "Prior");
        /// <summary>
        ///     KeyboardKeypad: Return Usage.
        /// </summary>
        public static readonly Usage Return = Instance.Create(0x009e, "Return");
        /// <summary>
        ///     KeyboardKeypad: Separator Usage.
        /// </summary>
        public static readonly Usage Separator = Instance.Create(0x009f, "Separator");
        /// <summary>
        ///     KeyboardKeypad: Out Usage.
        /// </summary>
        public static readonly Usage Out = Instance.Create(0x00a0, "Out");
        /// <summary>
        ///     KeyboardKeypad: Oper Usage.
        /// </summary>
        public static readonly Usage Oper = Instance.Create(0x00a1, "Oper");
        /// <summary>
        ///     KeyboardKeypad: Clear Again Usage.
        /// </summary>
        public static readonly Usage ClearAgain = Instance.Create(0x00a2, "Clear Again");
        /// <summary>
        ///     KeyboardKeypad: CrSel Props Usage.
        /// </summary>
        public static readonly Usage CrSelProps = Instance.Create(0x00a3, "CrSel Props");
        /// <summary>
        ///     KeyboardKeypad: ExSel Usage.
        /// </summary>
        public static readonly Usage ExSel = Instance.Create(0x00a4, "ExSel");

        /// <summary>
        ///     KeyboardKeypad: Keypad 00 Usage.
        /// </summary>
        public static readonly Usage Keypad00 = Instance.Create(0x00b0, "Keypad 00");
        /// <summary>
        ///     KeyboardKeypad: Keypad 000 Usage.
        /// </summary>
        public static readonly Usage Keypad000 = Instance.Create(0x00b1, "Keypad 000");
        /// <summary>
        ///     KeyboardKeypad: 1000sSeparator Usage.
        /// </summary>
        public static readonly Usage SSeparator = Instance.Create(0x00b2, "1000sSeparator");
        /// <summary>
        ///     KeyboardKeypad: DecimalSeparator Usage.
        /// </summary>
        public static readonly Usage DecimalSeparator = Instance.Create(0x00b3, "DecimalSeparator");
        /// <summary>
        ///     KeyboardKeypad: CurrencyUnit Usage.
        /// </summary>
        public static readonly Usage CurrencyUnit = Instance.Create(0x00b4, "CurrencyUnit");
        /// <summary>
        ///     KeyboardKeypad: CurrencySubunit Usage.
        /// </summary>
        public static readonly Usage CurrencySubunit = Instance.Create(0x00b5, "CurrencySubunit");
        /// <summary>
        ///     KeyboardKeypad: Keypad ( Usage.
        /// </summary>
        public static readonly Usage Keypad14 = Instance.Create(0x00b6, "Keypad (");
        /// <summary>
        ///     KeyboardKeypad: Keypad ) Usage.
        /// </summary>
        public static readonly Usage Keypad15 = Instance.Create(0x00b7, "Keypad )");
        /// <summary>
        ///     KeyboardKeypad: Keypad { Usage.
        /// </summary>
        public static readonly Usage Keypad16 = Instance.Create(0x00b8, "Keypad {");
        /// <summary>
        ///     KeyboardKeypad: Keypad } Usage.
        /// </summary>
        public static readonly Usage Keypad17 = Instance.Create(0x00b9, "Keypad }");
        /// <summary>
        ///     KeyboardKeypad: Keypad Tab Usage.
        /// </summary>
        public static readonly Usage KeypadTab = Instance.Create(0x00ba, "Keypad Tab");
        /// <summary>
        ///     KeyboardKeypad: Keypad Backspace Usage.
        /// </summary>
        public static readonly Usage KeypadBackspace = Instance.Create(0x00bb, "Keypad Backspace");
        /// <summary>
        ///     KeyboardKeypad: Keypad A Usage.
        /// </summary>
        public static readonly Usage KeypadA = Instance.Create(0x00bc, "Keypad A");
        /// <summary>
        ///     KeyboardKeypad: Keypad B Usage.
        /// </summary>
        public static readonly Usage KeypadB = Instance.Create(0x00bd, "Keypad B");
        /// <summary>
        ///     KeyboardKeypad: Keypad C Usage.
        /// </summary>
        public static readonly Usage KeypadC = Instance.Create(0x00be, "Keypad C");
        /// <summary>
        ///     KeyboardKeypad: Keypad D Usage.
        /// </summary>
        public static readonly Usage KeypadD = Instance.Create(0x00bf, "Keypad D");
        /// <summary>
        ///     KeyboardKeypad: Keypad E Usage.
        /// </summary>
        public static readonly Usage KeypadE = Instance.Create(0x00c0, "Keypad E");
        /// <summary>
        ///     KeyboardKeypad: Keypad F Usage.
        /// </summary>
        public static readonly Usage KeypadF = Instance.Create(0x00c1, "Keypad F");
        /// <summary>
        ///     KeyboardKeypad: Keypad XOR Usage.
        /// </summary>
        public static readonly Usage KeypadXOR = Instance.Create(0x00c2, "Keypad XOR");
        /// <summary>
        ///     KeyboardKeypad: Keypad ^ Usage.
        /// </summary>
        public static readonly Usage Keypad18 = Instance.Create(0x00c3, "Keypad ^");
        /// <summary>
        ///     KeyboardKeypad: Keypad % Usage.
        /// </summary>
        public static readonly Usage Keypad19 = Instance.Create(0x00c4, "Keypad %");
        /// <summary>
        ///     KeyboardKeypad: Keypad < Usage.
        /// </summary>
        public static readonly Usage Keypad20 = Instance.Create(0x00c5, "Keypad <");
        /// <summary>
        ///     KeyboardKeypad: Keypad > Usage.
        /// </summary>
        public static readonly Usage Keypad21 = Instance.Create(0x00c6, "Keypad >");
        /// <summary>
        ///     KeyboardKeypad: Keypad & Usage.
        /// </summary>
        public static readonly Usage Keypad23 = Instance.Create(0x00c7, "Keypad &");
        /// <summary>
        ///     KeyboardKeypad: Keypad && Usage.
        /// </summary>
        public static readonly Usage Keypad24 = Instance.Create(0x00c8, "Keypad &&");
        /// <summary>
        ///     KeyboardKeypad: Keypad | Usage.
        /// </summary>
        public static readonly Usage Keypad25 = Instance.Create(0x00c9, "Keypad |");
        /// <summary>
        ///     KeyboardKeypad: Keypad || Usage.
        /// </summary>
        public static readonly Usage Keypad26 = Instance.Create(0x00ca, "Keypad ||");
        /// <summary>
        ///     KeyboardKeypad: Keypad : Usage.
        /// </summary>
        public static readonly Usage Keypad27 = Instance.Create(0x00cb, "Keypad :");
        /// <summary>
        ///     KeyboardKeypad: Keypad # Usage.
        /// </summary>
        public static readonly Usage Keypad28 = Instance.Create(0x00cc, "Keypad #");
        /// <summary>
        ///     KeyboardKeypad: Keypad Space Usage.
        /// </summary>
        public static readonly Usage KeypadSpace = Instance.Create(0x00cd, "Keypad Space");
        /// <summary>
        ///     KeyboardKeypad: Keypad @ Usage.
        /// </summary>
        public static readonly Usage Keypad29 = Instance.Create(0x00ce, "Keypad @");
        /// <summary>
        ///     KeyboardKeypad: Keypad ! Usage.
        /// </summary>
        public static readonly Usage Keypad30 = Instance.Create(0x00cf, "Keypad !");
        /// <summary>
        ///     KeyboardKeypad: Keypad MemoryStore Usage.
        /// </summary>
        public static readonly Usage KeypadMemoryStore = Instance.Create(0x00d0, "Keypad MemoryStore");
        /// <summary>
        ///     KeyboardKeypad: Keypad MemoryRecall Usage.
        /// </summary>
        public static readonly Usage KeypadMemoryRecall = Instance.Create(0x00d1, "Keypad MemoryRecall");
        /// <summary>
        ///     KeyboardKeypad: Keypad MemoryClear Usage.
        /// </summary>
        public static readonly Usage KeypadMemoryClear = Instance.Create(0x00d2, "Keypad MemoryClear");
        /// <summary>
        ///     KeyboardKeypad: Keypad MemoryAdd Usage.
        /// </summary>
        public static readonly Usage KeypadMemoryAdd = Instance.Create(0x00d3, "Keypad MemoryAdd");
        /// <summary>
        ///     KeyboardKeypad: Keypad MemorySubtract Usage.
        /// </summary>
        public static readonly Usage KeypadMemorySubtract = Instance.Create(0x00d4, "Keypad MemorySubtract");
        /// <summary>
        ///     KeyboardKeypad: Keypad MemoryMultiply Usage.
        /// </summary>
        public static readonly Usage KeypadMemoryMultiply = Instance.Create(0x00d5, "Keypad MemoryMultiply");
        /// <summary>
        ///     KeyboardKeypad: Keypad MemoryDivide Usage.
        /// </summary>
        public static readonly Usage KeypadMemoryDivide = Instance.Create(0x00d6, "Keypad MemoryDivide");
        /// <summary>
        ///     KeyboardKeypad: Keypad +/- Usage.
        /// </summary>
        public static readonly Usage Keypad31 = Instance.Create(0x00d7, "Keypad +/-");
        /// <summary>
        ///     KeyboardKeypad: Keypad Clear Usage.
        /// </summary>
        public static readonly Usage KeypadClear = Instance.Create(0x00d8, "Keypad Clear");
        /// <summary>
        ///     KeyboardKeypad: Keypad ClearEntry Usage.
        /// </summary>
        public static readonly Usage KeypadClearEntry = Instance.Create(0x00d9, "Keypad ClearEntry");
        /// <summary>
        ///     KeyboardKeypad: Keypad Binary Usage.
        /// </summary>
        public static readonly Usage KeypadBinary = Instance.Create(0x00da, "Keypad Binary");
        /// <summary>
        ///     KeyboardKeypad: Keypad Octal Usage.
        /// </summary>
        public static readonly Usage KeypadOctal = Instance.Create(0x00db, "Keypad Octal");
        /// <summary>
        ///     KeyboardKeypad: Keypad Decimal Usage.
        /// </summary>
        public static readonly Usage KeypadDecimal = Instance.Create(0x00dc, "Keypad Decimal");
        /// <summary>
        ///     KeyboardKeypad: Keypad Hexadecimal Usage.
        /// </summary>
        public static readonly Usage KeypadHexadecimal = Instance.Create(0x00dd, "Keypad Hexadecimal");

        /// <summary>
        ///     KeyboardKeypad: LeftCtrl Usage.
        /// </summary>
        public static readonly Usage LeftCtrl = Instance.Create(0x00e0, "LeftCtrl");
        /// <summary>
        ///     KeyboardKeypad: LeftShift Usage.
        /// </summary>
        public static readonly Usage LeftShift = Instance.Create(0x00e1, "LeftShift");
        /// <summary>
        ///     KeyboardKeypad: LeftAlt Usage.
        /// </summary>
        public static readonly Usage LeftAlt = Instance.Create(0x00e2, "LeftAlt");
        /// <summary>
        ///     KeyboardKeypad: LeftGUI Usage.
        /// </summary>
        public static readonly Usage LeftGUI = Instance.Create(0x00e3, "LeftGUI");
        /// <summary>
        ///     KeyboardKeypad: RightCtrl Usage.
        /// </summary>
        public static readonly Usage RightCtrl = Instance.Create(0x00e4, "RightCtrl");
        /// <summary>
        ///     KeyboardKeypad: RightShift Usage.
        /// </summary>
        public static readonly Usage RightShift = Instance.Create(0x00e5, "RightShift");
        /// <summary>
        ///     KeyboardKeypad: RightAlt Usage.
        /// </summary>
        public static readonly Usage RightAlt = Instance.Create(0x00e6, "RightAlt");
        /// <summary>
        ///     KeyboardKeypad: RightGUI Usage.
        /// </summary>
        public static readonly Usage RightGUI = Instance.Create(0x00e7, "RightGUI");

        /// <inheritdoc />
        private KeyboardKeypadPage(ushort id, string name) : base(id, name, true)
        {
        }
    }

    /// <summary>
    ///     Class defining the LEDs usage page.
    /// </summary>
    public sealed partial class LEDsPage : UsagePage
    {
        /// <summary>
        ///     The singleton instance of LEDsPage.
        /// </summary>
        public static readonly LEDsPage Instance = new LEDsPage(0x0008, "LEDs");

        /// <summary>
        ///     LEDs: Num Lock Usage.
        /// </summary>
        public static readonly Usage NumLock = Instance.Create(0x0001, "Num Lock");
        /// <summary>
        ///     LEDs: Caps Lock Usage.
        /// </summary>
        public static readonly Usage CapsLock = Instance.Create(0x0002, "Caps Lock");
        /// <summary>
        ///     LEDs: Scroll Lock Usage.
        /// </summary>
        public static readonly Usage ScrollLock = Instance.Create(0x0003, "Scroll Lock");
        /// <summary>
        ///     LEDs: Compose Usage.
        /// </summary>
        public static readonly Usage Compose = Instance.Create(0x0004, "Compose");
        /// <summary>
        ///     LEDs: Kana Usage.
        /// </summary>
        public static readonly Usage Kana = Instance.Create(0x0005, "Kana");
        /// <summary>
        ///     LEDs: Power Usage.
        /// </summary>
        public static readonly Usage Power = Instance.Create(0x0006, "Power");
        /// <summary>
        ///     LEDs: Shift Usage.
        /// </summary>
        public static readonly Usage Shift = Instance.Create(0x0007, "Shift");
        /// <summary>
        ///     LEDs: Do Not Disturb Usage.
        /// </summary>
        public static readonly Usage DoNotDisturb = Instance.Create(0x0008, "Do Not Disturb");
        /// <summary>
        ///     LEDs: Mute Usage.
        /// </summary>
        public static readonly Usage Mute = Instance.Create(0x0009, "Mute");
        /// <summary>
        ///     LEDs: Tone Enable Usage.
        /// </summary>
        public static readonly Usage ToneEnable = Instance.Create(0x000a, "Tone Enable");
        /// <summary>
        ///     LEDs: High Cut Filter Usage.
        /// </summary>
        public static readonly Usage HighCutFilter = Instance.Create(0x000b, "High Cut Filter");
        /// <summary>
        ///     LEDs: Low Cut Filter Usage.
        /// </summary>
        public static readonly Usage LowCutFilter = Instance.Create(0x000c, "Low Cut Filter");
        /// <summary>
        ///     LEDs: Equalizer Enable Usage.
        /// </summary>
        public static readonly Usage EqualizerEnable = Instance.Create(0x000d, "Equalizer Enable");
        /// <summary>
        ///     LEDs: Sound Field On Usage.
        /// </summary>
        public static readonly Usage SoundFieldOn = Instance.Create(0x000e, "Sound Field On");
        /// <summary>
        ///     LEDs: Surround On Usage.
        /// </summary>
        public static readonly Usage SurroundOn = Instance.Create(0x000f, "Surround On");
        /// <summary>
        ///     LEDs: Repeat Usage.
        /// </summary>
        public static readonly Usage Repeat = Instance.Create(0x0010, "Repeat");
        /// <summary>
        ///     LEDs: Stereo Usage.
        /// </summary>
        public static readonly Usage Stereo = Instance.Create(0x0011, "Stereo");
        /// <summary>
        ///     LEDs: Sampling Rate Detect Usage.
        /// </summary>
        public static readonly Usage SamplingRateDetect = Instance.Create(0x0012, "Sampling Rate Detect");
        /// <summary>
        ///     LEDs: Spinning Usage.
        /// </summary>
        public static readonly Usage Spinning = Instance.Create(0x0013, "Spinning");
        /// <summary>
        ///     LEDs: CAV Usage.
        /// </summary>
        public static readonly Usage CAV = Instance.Create(0x0014, "CAV");
        /// <summary>
        ///     LEDs: CLV Usage.
        /// </summary>
        public static readonly Usage CLV = Instance.Create(0x0015, "CLV");
        /// <summary>
        ///     LEDs: Recording Format Detect Usage.
        /// </summary>
        public static readonly Usage RecordingFormatDetect = Instance.Create(0x0016, "Recording Format Detect");
        /// <summary>
        ///     LEDs: Off-Hook Usage.
        /// </summary>
        public static readonly Usage OffHook = Instance.Create(0x0017, "Off-Hook");
        /// <summary>
        ///     LEDs: Ring Usage.
        /// </summary>
        public static readonly Usage Ring = Instance.Create(0x0018, "Ring");
        /// <summary>
        ///     LEDs: Message Waiting Usage.
        /// </summary>
        public static readonly Usage MessageWaiting = Instance.Create(0x0019, "Message Waiting");
        /// <summary>
        ///     LEDs: Data Mode Usage.
        /// </summary>
        public static readonly Usage DataMode = Instance.Create(0x001a, "Data Mode");
        /// <summary>
        ///     LEDs: Battery Operation Usage.
        /// </summary>
        public static readonly Usage BatteryOperation = Instance.Create(0x001b, "Battery Operation");
        /// <summary>
        ///     LEDs: Battery OK Usage.
        /// </summary>
        public static readonly Usage BatteryOK = Instance.Create(0x001c, "Battery OK");
        /// <summary>
        ///     LEDs: Battery Low Usage.
        /// </summary>
        public static readonly Usage BatteryLow = Instance.Create(0x001d, "Battery Low");
        /// <summary>
        ///     LEDs: Speaker Usage.
        /// </summary>
        public static readonly Usage Speaker = Instance.Create(0x001e, "Speaker");
        /// <summary>
        ///     LEDs: Head Set Usage.
        /// </summary>
        public static readonly Usage HeadSet = Instance.Create(0x001f, "Head Set");
        /// <summary>
        ///     LEDs: Hold Usage.
        /// </summary>
        public static readonly Usage Hold = Instance.Create(0x0020, "Hold");
        /// <summary>
        ///     LEDs: Microphone Usage.
        /// </summary>
        public static readonly Usage Microphone = Instance.Create(0x0021, "Microphone");
        /// <summary>
        ///     LEDs: Coverage Usage.
        /// </summary>
        public static readonly Usage Coverage = Instance.Create(0x0022, "Coverage");
        /// <summary>
        ///     LEDs: Night Mode Usage.
        /// </summary>
        public static readonly Usage NightMode = Instance.Create(0x0023, "Night Mode");
        /// <summary>
        ///     LEDs: Send Calls Usage.
        /// </summary>
        public static readonly Usage SendCalls = Instance.Create(0x0024, "Send Calls");
        /// <summary>
        ///     LEDs: Call Pickup Usage.
        /// </summary>
        public static readonly Usage CallPickup = Instance.Create(0x0025, "Call Pickup");
        /// <summary>
        ///     LEDs: Conference Usage.
        /// </summary>
        public static readonly Usage Conference = Instance.Create(0x0026, "Conference");
        /// <summary>
        ///     LEDs: Stand-by Usage.
        /// </summary>
        public static readonly Usage Standby = Instance.Create(0x0027, "Stand-by");
        /// <summary>
        ///     LEDs: Camera On Usage.
        /// </summary>
        public static readonly Usage CameraOn = Instance.Create(0x0028, "Camera On");
        /// <summary>
        ///     LEDs: Camera Off Usage.
        /// </summary>
        public static readonly Usage CameraOff = Instance.Create(0x0029, "Camera Off");
        /// <summary>
        ///     LEDs: On-Line Usage.
        /// </summary>
        public static readonly Usage OnLine = Instance.Create(0x002a, "On-Line");
        /// <summary>
        ///     LEDs: Off-Line Usage.
        /// </summary>
        public static readonly Usage OffLine = Instance.Create(0x002b, "Off-Line");
        /// <summary>
        ///     LEDs: Busy Usage.
        /// </summary>
        public static readonly Usage Busy = Instance.Create(0x002c, "Busy");
        /// <summary>
        ///     LEDs: Ready Usage.
        /// </summary>
        public static readonly Usage Ready = Instance.Create(0x002d, "Ready");
        /// <summary>
        ///     LEDs: Paper-Out Usage.
        /// </summary>
        public static readonly Usage PaperOut = Instance.Create(0x002e, "Paper-Out");
        /// <summary>
        ///     LEDs: Paper-Jam Usage.
        /// </summary>
        public static readonly Usage PaperJam = Instance.Create(0x002f, "Paper-Jam");
        /// <summary>
        ///     LEDs: Remote Usage.
        /// </summary>
        public static readonly Usage Remote = Instance.Create(0x0030, "Remote");
        /// <summary>
        ///     LEDs: Forward Usage.
        /// </summary>
        public static readonly Usage Forward = Instance.Create(0x0031, "Forward");
        /// <summary>
        ///     LEDs: Reverse Usage.
        /// </summary>
        public static readonly Usage Reverse = Instance.Create(0x0032, "Reverse");
        /// <summary>
        ///     LEDs: Stop Usage.
        /// </summary>
        public static readonly Usage Stop = Instance.Create(0x0033, "Stop");
        /// <summary>
        ///     LEDs: Rewind Usage.
        /// </summary>
        public static readonly Usage Rewind = Instance.Create(0x0034, "Rewind");
        /// <summary>
        ///     LEDs: Fast Forward Usage.
        /// </summary>
        public static readonly Usage FastForward = Instance.Create(0x0035, "Fast Forward");
        /// <summary>
        ///     LEDs: Play Usage.
        /// </summary>
        public static readonly Usage Play = Instance.Create(0x0036, "Play");
        /// <summary>
        ///     LEDs: Pause Usage.
        /// </summary>
        public static readonly Usage Pause = Instance.Create(0x0037, "Pause");
        /// <summary>
        ///     LEDs: Record Usage.
        /// </summary>
        public static readonly Usage Record = Instance.Create(0x0038, "Record");
        /// <summary>
        ///     LEDs: Error Usage.
        /// </summary>
        public static readonly Usage Error = Instance.Create(0x0039, "Error");
        /// <summary>
        ///     LEDs: Usage Selected Indicator Usage.
        /// </summary>
        public static readonly Usage UsageSelectedIndicator = Instance.Create(0x003a, "Usage Selected Indicator");
        /// <summary>
        ///     LEDs: Usage In Use Indicator Usage.
        /// </summary>
        public static readonly Usage UsageInUseIndicator = Instance.Create(0x003b, "Usage In Use Indicator");
        /// <summary>
        ///     LEDs: Usage Multi Mode Indicator Usage.
        /// </summary>
        public static readonly Usage UsageMultiModeIndicator = Instance.Create(0x003c, "Usage Multi Mode Indicator");
        /// <summary>
        ///     LEDs: Indicator On Usage.
        /// </summary>
        public static readonly Usage IndicatorOn = Instance.Create(0x003d, "Indicator On");
        /// <summary>
        ///     LEDs: Indicator Flash Usage.
        /// </summary>
        public static readonly Usage IndicatorFlash = Instance.Create(0x003e, "Indicator Flash");
        /// <summary>
        ///     LEDs: Indicator Slow Blink Usage.
        /// </summary>
        public static readonly Usage IndicatorSlowBlink = Instance.Create(0x003f, "Indicator Slow Blink");
        /// <summary>
        ///     LEDs: Indicator Fast Blink Usage.
        /// </summary>
        public static readonly Usage IndicatorFastBlink = Instance.Create(0x0040, "Indicator Fast Blink");
        /// <summary>
        ///     LEDs: Indicator Off Usage.
        /// </summary>
        public static readonly Usage IndicatorOff = Instance.Create(0x0041, "Indicator Off");
        /// <summary>
        ///     LEDs: Flash On Time Usage.
        /// </summary>
        public static readonly Usage FlashOnTime = Instance.Create(0x0042, "Flash On Time");
        /// <summary>
        ///     LEDs: Slow Blink On Time Usage.
        /// </summary>
        public static readonly Usage SlowBlinkOnTime = Instance.Create(0x0043, "Slow Blink On Time");
        /// <summary>
        ///     LEDs: Slow Blink Off Time Usage.
        /// </summary>
        public static readonly Usage SlowBlinkOffTime = Instance.Create(0x0044, "Slow Blink Off Time");
        /// <summary>
        ///     LEDs: Fast Blink On Time Usage.
        /// </summary>
        public static readonly Usage FastBlinkOnTime = Instance.Create(0x0045, "Fast Blink On Time");
        /// <summary>
        ///     LEDs: Fast Blink Off Time Usage.
        /// </summary>
        public static readonly Usage FastBlinkOffTime = Instance.Create(0x0046, "Fast Blink Off Time");
        /// <summary>
        ///     LEDs: Usage Indicator Color Usage.
        /// </summary>
        public static readonly Usage UsageIndicatorColor = Instance.Create(0x0047, "Usage Indicator Color");
        /// <summary>
        ///     LEDs: Indicator Red Usage.
        /// </summary>
        public static readonly Usage IndicatorRed = Instance.Create(0x0048, "Indicator Red");
        /// <summary>
        ///     LEDs: Indicator Green Usage.
        /// </summary>
        public static readonly Usage IndicatorGreen = Instance.Create(0x0049, "Indicator Green");
        /// <summary>
        ///     LEDs: Indicator Amber Usage.
        /// </summary>
        public static readonly Usage IndicatorAmber = Instance.Create(0x004a, "Indicator Amber");
        /// <summary>
        ///     LEDs: Generic Indicator Usage.
        /// </summary>
        public static readonly Usage GenericIndicator = Instance.Create(0x004b, "Generic Indicator");
        /// <summary>
        ///     LEDs: System Suspend Usage.
        /// </summary>
        public static readonly Usage SystemSuspend = Instance.Create(0x004c, "System Suspend");
        /// <summary>
        ///     LEDs: External Power Connected Usage.
        /// </summary>
        public static readonly Usage ExternalPowerConnected = Instance.Create(0x004d, "External Power Connected");
        /// <summary>
        ///     LEDs: Indicator Blue Usage.
        /// </summary>
        public static readonly Usage IndicatorBlue = Instance.Create(0x004e, "Indicator Blue");
        /// <summary>
        ///     LEDs: Indicator Orange Usage.
        /// </summary>
        public static readonly Usage IndicatorOrange = Instance.Create(0x004f, "Indicator Orange");
        /// <summary>
        ///     LEDs: Good Status Usage.
        /// </summary>
        public static readonly Usage GoodStatus = Instance.Create(0x0050, "Good Status");
        /// <summary>
        ///     LEDs: Warning Status Usage.
        /// </summary>
        public static readonly Usage WarningStatus = Instance.Create(0x0051, "Warning Status");
        /// <summary>
        ///     LEDs: RGB LED Usage.
        /// </summary>
        public static readonly Usage RGBLED = Instance.Create(0x0052, "RGB LED");
        /// <summary>
        ///     LEDs: Red LED Channel Usage.
        /// </summary>
        public static readonly Usage RedLEDChannel = Instance.Create(0x0053, "Red LED Channel");
        /// <summary>
        ///     LEDs: Green LED Channel Usage.
        /// </summary>
        public static readonly Usage GreenLEDChannel = Instance.Create(0x0054, "Green LED Channel");
        /// <summary>
        ///     LEDs: Blue LED Channel Usage.
        /// </summary>
        public static readonly Usage BlueLEDChannel = Instance.Create(0x0055, "Blue LED Channel");
        /// <summary>
        ///     LEDs: LED Intensity Usage.
        /// </summary>
        public static readonly Usage LEDIntensity = Instance.Create(0x0056, "LED Intensity");
        /// <summary>
        ///     LEDs: Player Indicator Usage.
        /// </summary>
        public static readonly Usage PlayerIndicator = Instance.Create(0x0060, "Player Indicator");
        /// <summary>
        ///     LEDs: Player 1 Usage.
        /// </summary>
        public static readonly Usage Player1 = Instance.Create(0x0061, "Player 1");
        /// <summary>
        ///     LEDs: Player 2 Usage.
        /// </summary>
        public static readonly Usage Player2 = Instance.Create(0x0062, "Player 2");
        /// <summary>
        ///     LEDs: Player 3 Usage.
        /// </summary>
        public static readonly Usage Player3 = Instance.Create(0x0063, "Player 3");
        /// <summary>
        ///     LEDs: Player 4 Usage.
        /// </summary>
        public static readonly Usage Player4 = Instance.Create(0x0064, "Player 4");
        /// <summary>
        ///     LEDs: Player 5 Usage.
        /// </summary>
        public static readonly Usage Player5 = Instance.Create(0x0065, "Player 5");
        /// <summary>
        ///     LEDs: Player 6 Usage.
        /// </summary>
        public static readonly Usage Player6 = Instance.Create(0x0066, "Player 6");
        /// <summary>
        ///     LEDs: Player 7 Usage.
        /// </summary>
        public static readonly Usage Player7 = Instance.Create(0x0067, "Player 7");
        /// <summary>
        ///     LEDs: Player 8 Usage.
        /// </summary>
        public static readonly Usage Player8 = Instance.Create(0x0068, "Player 8");

        /// <summary>
        ///     LEDs: Undefined Usage.
        /// </summary>
        public static readonly Usage Undefined = Instance.Create(0x0000, "Undefined");

        /// <inheritdoc />
        private LEDsPage(ushort id, string name) : base(id, name, true)
        {
        }
    }

    /// <summary>
    ///     Class defining the Button usage page.
    /// </summary>
    public sealed partial class ButtonPage : UsagePage
    {
        /// <summary>
        ///     The singleton instance of ButtonPage.
        /// </summary>
        public static readonly ButtonPage Instance = new ButtonPage(0x0009, "Button");

        /// <summary>
        ///     Button: No button pressed Usage.
        /// </summary>
        public static readonly Usage NoButtonPressed = Instance.Create(0x0000, "No button pressed");
        /// <summary>
        ///     Button: Button 1 Usage.
        /// </summary>
        public static readonly Usage Button1 = Instance.Create(0x0001, "Button 1");
        /// <summary>
        ///     Button: Button 2 Usage.
        /// </summary>
        public static readonly Usage Button2 = Instance.Create(0x0002, "Button 2");
        /// <summary>
        ///     Button: Button 3 Usage.
        /// </summary>
        public static readonly Usage Button3 = Instance.Create(0x0003, "Button 3");
        /// <summary>
        ///     Button: Button 4 Usage.
        /// </summary>
        public static readonly Usage Button4 = Instance.Create(0x0004, "Button 4");
        /// <summary>
        ///     Button: Button 5 Usage.
        /// </summary>
        public static readonly Usage Button5 = Instance.Create(0x0005, "Button 5");
        /// <summary>
        ///     Button: Button 6 Usage.
        /// </summary>
        public static readonly Usage Button6 = Instance.Create(0x0006, "Button 6");
        /// <summary>
        ///     Button: Button 7 Usage.
        /// </summary>
        public static readonly Usage Button7 = Instance.Create(0x0007, "Button 7");
        /// <summary>
        ///     Button: Button 8 Usage.
        /// </summary>
        public static readonly Usage Button8 = Instance.Create(0x0008, "Button 8");
        /// <summary>
        ///     Button: Button 9 Usage.
        /// </summary>
        public static readonly Usage Button9 = Instance.Create(0x0009, "Button 9");
        /// <summary>
        ///     Button: Button 10 Usage.
        /// </summary>
        public static readonly Usage Button10 = Instance.Create(0x000a, "Button 10");
        /// <summary>
        ///     Button: Button 11 Usage.
        /// </summary>
        public static readonly Usage Button11 = Instance.Create(0x000b, "Button 11");
        /// <summary>
        ///     Button: Button 12 Usage.
        /// </summary>
        public static readonly Usage Button12 = Instance.Create(0x000c, "Button 12");
        /// <summary>
        ///     Button: Button 13 Usage.
        /// </summary>
        public static readonly Usage Button13 = Instance.Create(0x000d, "Button 13");
        /// <summary>
        ///     Button: Button 14 Usage.
        /// </summary>
        public static readonly Usage Button14 = Instance.Create(0x000e, "Button 14");
        /// <summary>
        ///     Button: Button 15 Usage.
        /// </summary>
        public static readonly Usage Button15 = Instance.Create(0x000f, "Button 15");
        /// <summary>
        ///     Button: Button 16 Usage.
        /// </summary>
        public static readonly Usage Button16 = Instance.Create(0x0010, "Button 16");
        /// <summary>
        ///     Button: Button 17 Usage.
        /// </summary>
        public static readonly Usage Button17 = Instance.Create(0x0011, "Button 17");
        /// <summary>
        ///     Button: Button 18 Usage.
        /// </summary>
        public static readonly Usage Button18 = Instance.Create(0x0012, "Button 18");
        /// <summary>
        ///     Button: Button 19 Usage.
        /// </summary>
        public static readonly Usage Button19 = Instance.Create(0x0013, "Button 19");
        /// <summary>
        ///     Button: Button 20 Usage.
        /// </summary>
        public static readonly Usage Button20 = Instance.Create(0x0014, "Button 20");
        /// <summary>
        ///     Button: Button 21 Usage.
        /// </summary>
        public static readonly Usage Button21 = Instance.Create(0x0015, "Button 21");
        /// <summary>
        ///     Button: Button 22 Usage.
        /// </summary>
        public static readonly Usage Button22 = Instance.Create(0x0016, "Button 22");
        /// <summary>
        ///     Button: Button 23 Usage.
        /// </summary>
        public static readonly Usage Button23 = Instance.Create(0x0017, "Button 23");
        /// <summary>
        ///     Button: Button 24 Usage.
        /// </summary>
        public static readonly Usage Button24 = Instance.Create(0x0018, "Button 24");
        /// <summary>
        ///     Button: Button 25 Usage.
        /// </summary>
        public static readonly Usage Button25 = Instance.Create(0x0019, "Button 25");
        /// <summary>
        ///     Button: Button 26 Usage.
        /// </summary>
        public static readonly Usage Button26 = Instance.Create(0x001a, "Button 26");
        /// <summary>
        ///     Button: Button 27 Usage.
        /// </summary>
        public static readonly Usage Button27 = Instance.Create(0x001b, "Button 27");
        /// <summary>
        ///     Button: Button 28 Usage.
        /// </summary>
        public static readonly Usage Button28 = Instance.Create(0x001c, "Button 28");
        /// <summary>
        ///     Button: Button 29 Usage.
        /// </summary>
        public static readonly Usage Button29 = Instance.Create(0x001d, "Button 29");
        /// <summary>
        ///     Button: Button 30 Usage.
        /// </summary>
        public static readonly Usage Button30 = Instance.Create(0x001e, "Button 30");
        /// <summary>
        ///     Button: Button 31 Usage.
        /// </summary>
        public static readonly Usage Button31 = Instance.Create(0x001f, "Button 31");
        /// <summary>
        ///     Button: Button 32 Usage.
        /// </summary>
        public static readonly Usage Button32 = Instance.Create(0x0020, "Button 32");

        /// <inheritdoc />
        private ButtonPage(ushort id, string name) : base(id, name, true)
        {
        }

        /// <inheritdoc />
        public override Usage GetUsage(ushort id) 
        {
            if (Usages.TryGetValue(id, out var usage)) return usage;

            // Create dynamic usages on demand
            var n = (ushort)(id-0x1);
            if (id >= 0x0021 || id <= 0xffff) return new Usage(this, id, $"Button {n+1}");

            return base.GetUsage(id);
        }
    }

    /// <summary>
    ///     Class defining the Ordinal usage page.
    /// </summary>
    public sealed partial class OrdinalPage : UsagePage
    {
        /// <summary>
        ///     The singleton instance of OrdinalPage.
        /// </summary>
        public static readonly OrdinalPage Instance = new OrdinalPage(0x000a, "Ordinal");

        /// <summary>
        ///     Ordinal: Instance 1 Usage.
        /// </summary>
        public static readonly Usage Instance1 = Instance.Create(0x0001, "Instance 1");
        /// <summary>
        ///     Ordinal: Instance 2 Usage.
        /// </summary>
        public static readonly Usage Instance2 = Instance.Create(0x0002, "Instance 2");
        /// <summary>
        ///     Ordinal: Instance 3 Usage.
        /// </summary>
        public static readonly Usage Instance3 = Instance.Create(0x0003, "Instance 3");
        /// <summary>
        ///     Ordinal: Instance 4 Usage.
        /// </summary>
        public static readonly Usage Instance4 = Instance.Create(0x0004, "Instance 4");
        /// <summary>
        ///     Ordinal: Instance 5 Usage.
        /// </summary>
        public static readonly Usage Instance5 = Instance.Create(0x0005, "Instance 5");
        /// <summary>
        ///     Ordinal: Instance 6 Usage.
        /// </summary>
        public static readonly Usage Instance6 = Instance.Create(0x0006, "Instance 6");
        /// <summary>
        ///     Ordinal: Instance 7 Usage.
        /// </summary>
        public static readonly Usage Instance7 = Instance.Create(0x0007, "Instance 7");
        /// <summary>
        ///     Ordinal: Instance 8 Usage.
        /// </summary>
        public static readonly Usage Instance8 = Instance.Create(0x0008, "Instance 8");
        /// <summary>
        ///     Ordinal: Instance 9 Usage.
        /// </summary>
        public static readonly Usage Instance9 = Instance.Create(0x0009, "Instance 9");
        /// <summary>
        ///     Ordinal: Instance 10 Usage.
        /// </summary>
        public static readonly Usage Instance10 = Instance.Create(0x000a, "Instance 10");
        /// <summary>
        ///     Ordinal: Instance 11 Usage.
        /// </summary>
        public static readonly Usage Instance11 = Instance.Create(0x000b, "Instance 11");
        /// <summary>
        ///     Ordinal: Instance 12 Usage.
        /// </summary>
        public static readonly Usage Instance12 = Instance.Create(0x000c, "Instance 12");
        /// <summary>
        ///     Ordinal: Instance 13 Usage.
        /// </summary>
        public static readonly Usage Instance13 = Instance.Create(0x000d, "Instance 13");
        /// <summary>
        ///     Ordinal: Instance 14 Usage.
        /// </summary>
        public static readonly Usage Instance14 = Instance.Create(0x000e, "Instance 14");
        /// <summary>
        ///     Ordinal: Instance 15 Usage.
        /// </summary>
        public static readonly Usage Instance15 = Instance.Create(0x000f, "Instance 15");
        /// <summary>
        ///     Ordinal: Instance 16 Usage.
        /// </summary>
        public static readonly Usage Instance16 = Instance.Create(0x0010, "Instance 16");
        /// <summary>
        ///     Ordinal: Instance 17 Usage.
        /// </summary>
        public static readonly Usage Instance17 = Instance.Create(0x0011, "Instance 17");
        /// <summary>
        ///     Ordinal: Instance 18 Usage.
        /// </summary>
        public static readonly Usage Instance18 = Instance.Create(0x0012, "Instance 18");
        /// <summary>
        ///     Ordinal: Instance 19 Usage.
        /// </summary>
        public static readonly Usage Instance19 = Instance.Create(0x0013, "Instance 19");
        /// <summary>
        ///     Ordinal: Instance 20 Usage.
        /// </summary>
        public static readonly Usage Instance20 = Instance.Create(0x0014, "Instance 20");
        /// <summary>
        ///     Ordinal: Instance 21 Usage.
        /// </summary>
        public static readonly Usage Instance21 = Instance.Create(0x0015, "Instance 21");
        /// <summary>
        ///     Ordinal: Instance 22 Usage.
        /// </summary>
        public static readonly Usage Instance22 = Instance.Create(0x0016, "Instance 22");
        /// <summary>
        ///     Ordinal: Instance 23 Usage.
        /// </summary>
        public static readonly Usage Instance23 = Instance.Create(0x0017, "Instance 23");
        /// <summary>
        ///     Ordinal: Instance 24 Usage.
        /// </summary>
        public static readonly Usage Instance24 = Instance.Create(0x0018, "Instance 24");
        /// <summary>
        ///     Ordinal: Instance 25 Usage.
        /// </summary>
        public static readonly Usage Instance25 = Instance.Create(0x0019, "Instance 25");
        /// <summary>
        ///     Ordinal: Instance 26 Usage.
        /// </summary>
        public static readonly Usage Instance26 = Instance.Create(0x001a, "Instance 26");
        /// <summary>
        ///     Ordinal: Instance 27 Usage.
        /// </summary>
        public static readonly Usage Instance27 = Instance.Create(0x001b, "Instance 27");
        /// <summary>
        ///     Ordinal: Instance 28 Usage.
        /// </summary>
        public static readonly Usage Instance28 = Instance.Create(0x001c, "Instance 28");
        /// <summary>
        ///     Ordinal: Instance 29 Usage.
        /// </summary>
        public static readonly Usage Instance29 = Instance.Create(0x001d, "Instance 29");
        /// <summary>
        ///     Ordinal: Instance 30 Usage.
        /// </summary>
        public static readonly Usage Instance30 = Instance.Create(0x001e, "Instance 30");
        /// <summary>
        ///     Ordinal: Instance 31 Usage.
        /// </summary>
        public static readonly Usage Instance31 = Instance.Create(0x001f, "Instance 31");
        /// <summary>
        ///     Ordinal: Instance 32 Usage.
        /// </summary>
        public static readonly Usage Instance32 = Instance.Create(0x0020, "Instance 32");

        /// <summary>
        ///     Ordinal: Undefined Usage.
        /// </summary>
        public static readonly Usage Undefined = Instance.Create(0x0000, "Undefined");

        /// <inheritdoc />
        private OrdinalPage(ushort id, string name) : base(id, name, true)
        {
        }

        /// <inheritdoc />
        public override Usage GetUsage(ushort id) 
        {
            if (Usages.TryGetValue(id, out var usage)) return usage;

            // Create dynamic usages on demand
            var n = (ushort)(id-0x1);
            if (id >= 0x0021 || id <= 0xffff) return new Usage(this, id, $"Instance {n+1}");

            return base.GetUsage(id);
        }
    }

    /// <summary>
    ///     Class defining the Telephony usage page.
    /// </summary>
    public sealed partial class TelephonyPage : UsagePage
    {
        /// <summary>
        ///     The singleton instance of TelephonyPage.
        /// </summary>
        public static readonly TelephonyPage Instance = new TelephonyPage(0x000b, "Telephony");

        /// <summary>
        ///     Telephony: Phone Usage.
        /// </summary>
        public static readonly Usage Phone = Instance.Create(0x0001, "Phone");
        /// <summary>
        ///     Telephony: Answering Machine Usage.
        /// </summary>
        public static readonly Usage AnsweringMachine = Instance.Create(0x0002, "Answering Machine");
        /// <summary>
        ///     Telephony: Message Controls Usage.
        /// </summary>
        public static readonly Usage MessageControls = Instance.Create(0x0003, "Message Controls");
        /// <summary>
        ///     Telephony: Handset Usage.
        /// </summary>
        public static readonly Usage Handset = Instance.Create(0x0004, "Handset");
        /// <summary>
        ///     Telephony: Headset Usage.
        /// </summary>
        public static readonly Usage Headset = Instance.Create(0x0005, "Headset");
        /// <summary>
        ///     Telephony: Telephony Key Pad Usage.
        /// </summary>
        public static readonly Usage TelephonyKeyPad = Instance.Create(0x0006, "Telephony Key Pad");
        /// <summary>
        ///     Telephony: Programmable Button Usage.
        /// </summary>
        public static readonly Usage ProgrammableButton = Instance.Create(0x0007, "Programmable Button");

        /// <summary>
        ///     Telephony: Hook Switch Usage.
        /// </summary>
        public static readonly Usage HookSwitch = Instance.Create(0x0020, "Hook Switch");
        /// <summary>
        ///     Telephony: Flash Usage.
        /// </summary>
        public static readonly Usage Flash = Instance.Create(0x0021, "Flash");
        /// <summary>
        ///     Telephony: Feature Usage.
        /// </summary>
        public static readonly Usage Feature = Instance.Create(0x0022, "Feature");
        /// <summary>
        ///     Telephony: Hold Usage.
        /// </summary>
        public static readonly Usage Hold = Instance.Create(0x0023, "Hold");
        /// <summary>
        ///     Telephony: Redial Usage.
        /// </summary>
        public static readonly Usage Redial = Instance.Create(0x0024, "Redial");
        /// <summary>
        ///     Telephony: Transfer Usage.
        /// </summary>
        public static readonly Usage Transfer = Instance.Create(0x0025, "Transfer");
        /// <summary>
        ///     Telephony: Drop Usage.
        /// </summary>
        public static readonly Usage Drop = Instance.Create(0x0026, "Drop");
        /// <summary>
        ///     Telephony: Park Usage.
        /// </summary>
        public static readonly Usage Park = Instance.Create(0x0027, "Park");
        /// <summary>
        ///     Telephony: Forward Calls Usage.
        /// </summary>
        public static readonly Usage ForwardCalls = Instance.Create(0x0028, "Forward Calls");
        /// <summary>
        ///     Telephony: Alternate  Function Usage.
        /// </summary>
        public static readonly Usage AlternateFunction = Instance.Create(0x0029, "Alternate  Function");
        /// <summary>
        ///     Telephony: Line Usage.
        /// </summary>
        public static readonly Usage Line = Instance.Create(0x002a, "Line");
        /// <summary>
        ///     Telephony: Speaker Phone Usage.
        /// </summary>
        public static readonly Usage SpeakerPhone = Instance.Create(0x002b, "Speaker Phone");
        /// <summary>
        ///     Telephony: Conference Usage.
        /// </summary>
        public static readonly Usage Conference = Instance.Create(0x002c, "Conference");
        /// <summary>
        ///     Telephony: Ring Enable Usage.
        /// </summary>
        public static readonly Usage RingEnable = Instance.Create(0x002d, "Ring Enable");
        /// <summary>
        ///     Telephony: Ring Select Usage.
        /// </summary>
        public static readonly Usage RingSelect = Instance.Create(0x002e, "Ring Select");
        /// <summary>
        ///     Telephony: Phone Mute Usage.
        /// </summary>
        public static readonly Usage PhoneMute = Instance.Create(0x002f, "Phone Mute");
        /// <summary>
        ///     Telephony: Caller ID Usage.
        /// </summary>
        public static readonly Usage CallerID = Instance.Create(0x0030, "Caller ID");

        /// <summary>
        ///     Telephony: Speed Dial Usage.
        /// </summary>
        public static readonly Usage SpeedDial = Instance.Create(0x0050, "Speed Dial");
        /// <summary>
        ///     Telephony: Store Number Usage.
        /// </summary>
        public static readonly Usage StoreNumber = Instance.Create(0x0051, "Store Number");
        /// <summary>
        ///     Telephony: Recall Number Usage.
        /// </summary>
        public static readonly Usage RecallNumber = Instance.Create(0x0052, "Recall Number");
        /// <summary>
        ///     Telephony: Phone Directory Usage.
        /// </summary>
        public static readonly Usage PhoneDirectory = Instance.Create(0x0053, "Phone Directory");

        /// <summary>
        ///     Telephony: Voice Mail Usage.
        /// </summary>
        public static readonly Usage VoiceMail = Instance.Create(0x0070, "Voice Mail");
        /// <summary>
        ///     Telephony: Screen Calls Usage.
        /// </summary>
        public static readonly Usage ScreenCalls = Instance.Create(0x0071, "Screen Calls");
        /// <summary>
        ///     Telephony: Do Not Disturb Usage.
        /// </summary>
        public static readonly Usage DoNotDisturb = Instance.Create(0x0072, "Do Not Disturb");
        /// <summary>
        ///     Telephony: Message Usage.
        /// </summary>
        public static readonly Usage Message = Instance.Create(0x0073, "Message");
        /// <summary>
        ///     Telephony: Answer On/Off Usage.
        /// </summary>
        public static readonly Usage AnswerOnOff = Instance.Create(0x0074, "Answer On/Off");

        /// <summary>
        ///     Telephony: Inside Dial Tone Usage.
        /// </summary>
        public static readonly Usage InsideDialTone = Instance.Create(0x0090, "Inside Dial Tone");
        /// <summary>
        ///     Telephony: Outside Dial Tone Usage.
        /// </summary>
        public static readonly Usage OutsideDialTone = Instance.Create(0x0091, "Outside Dial Tone");
        /// <summary>
        ///     Telephony: Inside Ring Tone Usage.
        /// </summary>
        public static readonly Usage InsideRingTone = Instance.Create(0x0092, "Inside Ring Tone");
        /// <summary>
        ///     Telephony: Outside Ring Tone Usage.
        /// </summary>
        public static readonly Usage OutsideRingTone = Instance.Create(0x0093, "Outside Ring Tone");
        /// <summary>
        ///     Telephony: Priority Ring Tone Usage.
        /// </summary>
        public static readonly Usage PriorityRingTone = Instance.Create(0x0094, "Priority Ring Tone");
        /// <summary>
        ///     Telephony: Inside Ringback Usage.
        /// </summary>
        public static readonly Usage InsideRingback = Instance.Create(0x0095, "Inside Ringback");
        /// <summary>
        ///     Telephony: Priority Ringback Usage.
        /// </summary>
        public static readonly Usage PriorityRingback = Instance.Create(0x0096, "Priority Ringback");
        /// <summary>
        ///     Telephony: Line Busy Tone Usage.
        /// </summary>
        public static readonly Usage LineBusyTone = Instance.Create(0x0097, "Line Busy Tone");
        /// <summary>
        ///     Telephony: Reorder Tone Usage.
        /// </summary>
        public static readonly Usage ReorderTone = Instance.Create(0x0098, "Reorder Tone");
        /// <summary>
        ///     Telephony: Call Waiting Tone Usage.
        /// </summary>
        public static readonly Usage CallWaitingTone = Instance.Create(0x0099, "Call Waiting Tone");
        /// <summary>
        ///     Telephony: Confirmation Tone 1 Usage.
        /// </summary>
        public static readonly Usage ConfirmationTone1 = Instance.Create(0x009a, "Confirmation Tone 1");
        /// <summary>
        ///     Telephony: Confirmation Tone 2 Usage.
        /// </summary>
        public static readonly Usage ConfirmationTone2 = Instance.Create(0x009b, "Confirmation Tone 2");
        /// <summary>
        ///     Telephony: Tones Off Usage.
        /// </summary>
        public static readonly Usage TonesOff = Instance.Create(0x009c, "Tones Off");
        /// <summary>
        ///     Telephony: Outside Ringback Usage.
        /// </summary>
        public static readonly Usage OutsideRingback = Instance.Create(0x009d, "Outside Ringback");
        /// <summary>
        ///     Telephony: Ringer Usage.
        /// </summary>
        public static readonly Usage Ringer = Instance.Create(0x009e, "Ringer");

        /// <summary>
        ///     Telephony: Phone Key 0 Usage.
        /// </summary>
        public static readonly Usage PhoneKey0 = Instance.Create(0x00b0, "Phone Key 0");
        /// <summary>
        ///     Telephony: Phone Key 1 Usage.
        /// </summary>
        public static readonly Usage PhoneKey1 = Instance.Create(0x00b1, "Phone Key 1");
        /// <summary>
        ///     Telephony: Phone Key 2 Usage.
        /// </summary>
        public static readonly Usage PhoneKey2 = Instance.Create(0x00b2, "Phone Key 2");
        /// <summary>
        ///     Telephony: Phone Key 3 Usage.
        /// </summary>
        public static readonly Usage PhoneKey3 = Instance.Create(0x00b3, "Phone Key 3");
        /// <summary>
        ///     Telephony: Phone Key 4 Usage.
        /// </summary>
        public static readonly Usage PhoneKey4 = Instance.Create(0x00b4, "Phone Key 4");
        /// <summary>
        ///     Telephony: Phone Key 5 Usage.
        /// </summary>
        public static readonly Usage PhoneKey5 = Instance.Create(0x00b5, "Phone Key 5");
        /// <summary>
        ///     Telephony: Phone Key 6 Usage.
        /// </summary>
        public static readonly Usage PhoneKey6 = Instance.Create(0x00b6, "Phone Key 6");
        /// <summary>
        ///     Telephony: Phone Key 7 Usage.
        /// </summary>
        public static readonly Usage PhoneKey7 = Instance.Create(0x00b7, "Phone Key 7");
        /// <summary>
        ///     Telephony: Phone Key 8 Usage.
        /// </summary>
        public static readonly Usage PhoneKey8 = Instance.Create(0x00b8, "Phone Key 8");
        /// <summary>
        ///     Telephony: Phone Key 9 Usage.
        /// </summary>
        public static readonly Usage PhoneKey9 = Instance.Create(0x00b9, "Phone Key 9");
        /// <summary>
        ///     Telephony: Phone Key Star Usage.
        /// </summary>
        public static readonly Usage PhoneKeyStar = Instance.Create(0x00ba, "Phone Key Star");
        /// <summary>
        ///     Telephony: Phone Key Pound Usage.
        /// </summary>
        public static readonly Usage PhoneKeyPound = Instance.Create(0x00bb, "Phone Key Pound");
        /// <summary>
        ///     Telephony: Phone Key A Usage.
        /// </summary>
        public static readonly Usage PhoneKeyA = Instance.Create(0x00bc, "Phone Key A");
        /// <summary>
        ///     Telephony: Phone Key B Usage.
        /// </summary>
        public static readonly Usage PhoneKeyB = Instance.Create(0x00bd, "Phone Key B");
        /// <summary>
        ///     Telephony: Phone Key C Usage.
        /// </summary>
        public static readonly Usage PhoneKeyC = Instance.Create(0x00be, "Phone Key C");
        /// <summary>
        ///     Telephony: Phone Key D Usage.
        /// </summary>
        public static readonly Usage PhoneKeyD = Instance.Create(0x00bf, "Phone Key D");
        /// <summary>
        ///     Telephony: Phone Key Call History Usage.
        /// </summary>
        public static readonly Usage PhoneKeyCallHistory = Instance.Create(0x00c0, "Phone Key Call History");
        /// <summary>
        ///     Telephony: Phone Key Caller ID Usage.
        /// </summary>
        public static readonly Usage PhoneKeyCallerID = Instance.Create(0x00c1, "Phone Key Caller ID");
        /// <summary>
        ///     Telephony: Phone Key Settings Usage.
        /// </summary>
        public static readonly Usage PhoneKeySettings = Instance.Create(0x00c2, "Phone Key Settings");

        /// <summary>
        ///     Telephony: Host Control Usage.
        /// </summary>
        public static readonly Usage HostControl = Instance.Create(0x00f0, "Host Control");
        /// <summary>
        ///     Telephony: Host Available Usage.
        /// </summary>
        public static readonly Usage HostAvailable = Instance.Create(0x00f1, "Host Available");
        /// <summary>
        ///     Telephony: Host Call Active Usage.
        /// </summary>
        public static readonly Usage HostCallActive = Instance.Create(0x00f2, "Host Call Active");
        /// <summary>
        ///     Telephony: Activate Handset Audio Usage.
        /// </summary>
        public static readonly Usage ActivateHandsetAudio = Instance.Create(0x00f3, "Activate Handset Audio");
        /// <summary>
        ///     Telephony: Ring Type Usage.
        /// </summary>
        public static readonly Usage RingType = Instance.Create(0x00f4, "Ring Type");
        /// <summary>
        ///     Telephony: Re-dialable Phone Number Usage.
        /// </summary>
        public static readonly Usage RedialablePhoneNumber = Instance.Create(0x00f5, "Re-dialable Phone Number");

        /// <summary>
        ///     Telephony: Stop Ring Tone Usage.
        /// </summary>
        public static readonly Usage StopRingTone = Instance.Create(0x00f8, "Stop Ring Tone");
        /// <summary>
        ///     Telephony: PSTN Ring Tone Usage.
        /// </summary>
        public static readonly Usage PSTNRingTone = Instance.Create(0x00f9, "PSTN Ring Tone");
        /// <summary>
        ///     Telephony: Host Ring Tone Usage.
        /// </summary>
        public static readonly Usage HostRingTone = Instance.Create(0x00fa, "Host Ring Tone");
        /// <summary>
        ///     Telephony: Alert Sound Error Usage.
        /// </summary>
        public static readonly Usage AlertSoundError = Instance.Create(0x00fb, "Alert Sound Error");
        /// <summary>
        ///     Telephony: Alert Sound Confirm Usage.
        /// </summary>
        public static readonly Usage AlertSoundConfirm = Instance.Create(0x00fc, "Alert Sound Confirm");
        /// <summary>
        ///     Telephony: Alert Sound Notification Usage.
        /// </summary>
        public static readonly Usage AlertSoundNotification = Instance.Create(0x00fd, "Alert Sound Notification");
        /// <summary>
        ///     Telephony: Silent Ring Usage.
        /// </summary>
        public static readonly Usage SilentRing = Instance.Create(0x00fe, "Silent Ring");

        /// <summary>
        ///     Telephony: Email Message Waiting Usage.
        /// </summary>
        public static readonly Usage EmailMessageWaiting = Instance.Create(0x0108, "Email Message Waiting");
        /// <summary>
        ///     Telephony: Voicemail Message Waiting Usage.
        /// </summary>
        public static readonly Usage VoicemailMessageWaiting = Instance.Create(0x0109, "Voicemail Message Waiting");
        /// <summary>
        ///     Telephony: Host Hold Usage.
        /// </summary>
        public static readonly Usage HostHold = Instance.Create(0x010a, "Host Hold");

        /// <summary>
        ///     Telephony: Incoming Call History Count Usage.
        /// </summary>
        public static readonly Usage IncomingCallHistoryCount = Instance.Create(0x0110, "Incoming Call History Count");
        /// <summary>
        ///     Telephony: Outgoing Call History Count Usage.
        /// </summary>
        public static readonly Usage OutgoingCallHistoryCount = Instance.Create(0x0111, "Outgoing Call History Count");
        /// <summary>
        ///     Telephony: Incoming Call History Usage.
        /// </summary>
        public static readonly Usage IncomingCallHistory = Instance.Create(0x0112, "Incoming Call History");
        /// <summary>
        ///     Telephony: Outgoing Call History Usage.
        /// </summary>
        public static readonly Usage OutgoingCallHistory = Instance.Create(0x0113, "Outgoing Call History");
        /// <summary>
        ///     Telephony: Phone Locale Usage.
        /// </summary>
        public static readonly Usage PhoneLocale = Instance.Create(0x0114, "Phone Locale");

        /// <summary>
        ///     Telephony: Phone Time Second Usage.
        /// </summary>
        public static readonly Usage PhoneTimeSecond = Instance.Create(0x0140, "Phone Time Second");
        /// <summary>
        ///     Telephony: Phone Time Minute Usage.
        /// </summary>
        public static readonly Usage PhoneTimeMinute = Instance.Create(0x0141, "Phone Time Minute");
        /// <summary>
        ///     Telephony: Phone Time Hour Usage.
        /// </summary>
        public static readonly Usage PhoneTimeHour = Instance.Create(0x0142, "Phone Time Hour");
        /// <summary>
        ///     Telephony: Phone Time Day Usage.
        /// </summary>
        public static readonly Usage PhoneTimeDay = Instance.Create(0x0143, "Phone Time Day");
        /// <summary>
        ///     Telephony: Phone Time Month Usage.
        /// </summary>
        public static readonly Usage PhoneTimeMonth = Instance.Create(0x0144, "Phone Time Month");
        /// <summary>
        ///     Telephony: Phone Time Year Usage.
        /// </summary>
        public static readonly Usage PhoneTimeYear = Instance.Create(0x0145, "Phone Time Year");
        /// <summary>
        ///     Telephony: Handset Nickname Usage.
        /// </summary>
        public static readonly Usage HandsetNickname = Instance.Create(0x0146, "Handset Nickname");
        /// <summary>
        ///     Telephony: Address Book ID Usage.
        /// </summary>
        public static readonly Usage AddressBookID = Instance.Create(0x0147, "Address Book ID");

        /// <summary>
        ///     Telephony: Call Duration Usage.
        /// </summary>
        public static readonly Usage CallDuration = Instance.Create(0x014a, "Call Duration");
        /// <summary>
        ///     Telephony: Dual Mode Phone Usage.
        /// </summary>
        public static readonly Usage DualModePhone = Instance.Create(0x014b, "Dual Mode Phone");

        /// <summary>
        ///     Telephony: Undefined Usage.
        /// </summary>
        public static readonly Usage Undefined = Instance.Create(0x0000, "Undefined");

        /// <inheritdoc />
        private TelephonyPage(ushort id, string name) : base(id, name, true)
        {
        }
    }

    /// <summary>
    ///     Class defining the Consumer usage page.
    /// </summary>
    public sealed partial class ConsumerPage : UsagePage
    {
        /// <summary>
        ///     The singleton instance of ConsumerPage.
        /// </summary>
        public static readonly ConsumerPage Instance = new ConsumerPage(0x000c, "Consumer");

        /// <summary>
        ///     Consumer: Consumer Control Usage.
        /// </summary>
        public static readonly Usage ConsumerControl = Instance.Create(0x0001, "Consumer Control");
        /// <summary>
        ///     Consumer: Numeric Key Pad Usage.
        /// </summary>
        public static readonly Usage NumericKeyPad = Instance.Create(0x0002, "Numeric Key Pad");
        /// <summary>
        ///     Consumer: Programmable Buttons Usage.
        /// </summary>
        public static readonly Usage ProgrammableButtons = Instance.Create(0x0003, "Programmable Buttons");
        /// <summary>
        ///     Consumer: Microphone Usage.
        /// </summary>
        public static readonly Usage Microphone = Instance.Create(0x0004, "Microphone");
        /// <summary>
        ///     Consumer: Headphone Usage.
        /// </summary>
        public static readonly Usage Headphone = Instance.Create(0x0005, "Headphone");
        /// <summary>
        ///     Consumer: Graphic Equalizer Usage.
        /// </summary>
        public static readonly Usage GraphicEqualizer = Instance.Create(0x0006, "Graphic Equalizer");

        /// <summary>
        ///     Consumer: +10 Usage.
        /// </summary>
        public static readonly Usage Consumer_10 = Instance.Create(0x0020, "+10");
        /// <summary>
        ///     Consumer: +100 Usage.
        /// </summary>
        public static readonly Usage Consumer_100 = Instance.Create(0x0021, "+100");
        /// <summary>
        ///     Consumer: AM/PM Usage.
        /// </summary>
        public static readonly Usage AMPM = Instance.Create(0x0022, "AM/PM");

        /// <summary>
        ///     Consumer: Power Usage.
        /// </summary>
        public static readonly Usage Power = Instance.Create(0x0030, "Power");
        /// <summary>
        ///     Consumer: Reset Usage.
        /// </summary>
        public static readonly Usage Reset = Instance.Create(0x0031, "Reset");
        /// <summary>
        ///     Consumer: Sleep Usage.
        /// </summary>
        public static readonly Usage Sleep = Instance.Create(0x0032, "Sleep");
        /// <summary>
        ///     Consumer: Sleep After Usage.
        /// </summary>
        public static readonly Usage SleepAfter = Instance.Create(0x0033, "Sleep After");
        /// <summary>
        ///     Consumer: Sleep Mode Usage.
        /// </summary>
        public static readonly Usage SleepMode = Instance.Create(0x0034, "Sleep Mode");
        /// <summary>
        ///     Consumer: Illumination Usage.
        /// </summary>
        public static readonly Usage Illumination = Instance.Create(0x0035, "Illumination");
        /// <summary>
        ///     Consumer: Function Buttons Usage.
        /// </summary>
        public static readonly Usage FunctionButtons = Instance.Create(0x0036, "Function Buttons");

        /// <summary>
        ///     Consumer: Menu Usage.
        /// </summary>
        public static readonly Usage Menu = Instance.Create(0x0040, "Menu");
        /// <summary>
        ///     Consumer: Menu Pick Usage.
        /// </summary>
        public static readonly Usage MenuPick = Instance.Create(0x0041, "Menu Pick");
        /// <summary>
        ///     Consumer: Menu Up Usage.
        /// </summary>
        public static readonly Usage MenuUp = Instance.Create(0x0042, "Menu Up");
        /// <summary>
        ///     Consumer: Menu Down Usage.
        /// </summary>
        public static readonly Usage MenuDown = Instance.Create(0x0043, "Menu Down");
        /// <summary>
        ///     Consumer: Menu Left Usage.
        /// </summary>
        public static readonly Usage MenuLeft = Instance.Create(0x0044, "Menu Left");
        /// <summary>
        ///     Consumer: Menu Right Usage.
        /// </summary>
        public static readonly Usage MenuRight = Instance.Create(0x0045, "Menu Right");
        /// <summary>
        ///     Consumer: Menu Escape Usage.
        /// </summary>
        public static readonly Usage MenuEscape = Instance.Create(0x0046, "Menu Escape");
        /// <summary>
        ///     Consumer: Menu Value Increase Usage.
        /// </summary>
        public static readonly Usage MenuValueIncrease = Instance.Create(0x0047, "Menu Value Increase");
        /// <summary>
        ///     Consumer: Menu Value Decrease Usage.
        /// </summary>
        public static readonly Usage MenuValueDecrease = Instance.Create(0x0048, "Menu Value Decrease");

        /// <summary>
        ///     Consumer: Data On Screen Usage.
        /// </summary>
        public static readonly Usage DataOnScreen = Instance.Create(0x0060, "Data On Screen");
        /// <summary>
        ///     Consumer: Closed Caption Usage.
        /// </summary>
        public static readonly Usage ClosedCaption = Instance.Create(0x0061, "Closed Caption");
        /// <summary>
        ///     Consumer: Closed Caption Select Usage.
        /// </summary>
        public static readonly Usage ClosedCaptionSelect = Instance.Create(0x0062, "Closed Caption Select");
        /// <summary>
        ///     Consumer: VCR/TV Usage.
        /// </summary>
        public static readonly Usage VCRTV = Instance.Create(0x0063, "VCR/TV");
        /// <summary>
        ///     Consumer: Broadcast Mode Usage.
        /// </summary>
        public static readonly Usage BroadcastMode = Instance.Create(0x0064, "Broadcast Mode");
        /// <summary>
        ///     Consumer: Snapshot Usage.
        /// </summary>
        public static readonly Usage Snapshot = Instance.Create(0x0065, "Snapshot");
        /// <summary>
        ///     Consumer: Still Usage.
        /// </summary>
        public static readonly Usage Still = Instance.Create(0x0066, "Still");
        /// <summary>
        ///     Consumer: Picture-in-Picture Toggle Usage.
        /// </summary>
        public static readonly Usage PictureinPictureToggle = Instance.Create(0x0067, "Picture-in-Picture Toggle");
        /// <summary>
        ///     Consumer: Picture-in-Picture Swap Usage.
        /// </summary>
        public static readonly Usage PictureinPictureSwap = Instance.Create(0x0068, "Picture-in-Picture Swap");
        /// <summary>
        ///     Consumer: Red Menu Button Usage.
        /// </summary>
        public static readonly Usage RedMenuButton = Instance.Create(0x0069, "Red Menu Button");
        /// <summary>
        ///     Consumer: Green Menu Button Usage.
        /// </summary>
        public static readonly Usage GreenMenuButton = Instance.Create(0x006a, "Green Menu Button");
        /// <summary>
        ///     Consumer: Blue Menu Button Usage.
        /// </summary>
        public static readonly Usage BlueMenuButton = Instance.Create(0x006b, "Blue Menu Button");
        /// <summary>
        ///     Consumer: Yellow Menu Button Usage.
        /// </summary>
        public static readonly Usage YellowMenuButton = Instance.Create(0x006c, "Yellow Menu Button");
        /// <summary>
        ///     Consumer: Aspect Usage.
        /// </summary>
        public static readonly Usage Aspect = Instance.Create(0x006d, "Aspect");
        /// <summary>
        ///     Consumer: 3D Mode Select Usage.
        /// </summary>
        public static readonly Usage DModeSelect = Instance.Create(0x006e, "3D Mode Select");
        /// <summary>
        ///     Consumer: Display Brightness Increment Usage.
        /// </summary>
        public static readonly Usage DisplayBrightnessIncrement = Instance.Create(0x006f, "Display Brightness Increment");
        /// <summary>
        ///     Consumer: Display Brightness Decrement Usage.
        /// </summary>
        public static readonly Usage DisplayBrightnessDecrement = Instance.Create(0x0070, "Display Brightness Decrement");
        /// <summary>
        ///     Consumer: Display Brightness Usage.
        /// </summary>
        public static readonly Usage DisplayBrightness = Instance.Create(0x0071, "Display Brightness");
        /// <summary>
        ///     Consumer: Display Backlight Toggle Usage.
        /// </summary>
        public static readonly Usage DisplayBacklightToggle = Instance.Create(0x0072, "Display Backlight Toggle");
        /// <summary>
        ///     Consumer: Display Set Brightness to Minimum Usage.
        /// </summary>
        public static readonly Usage DisplaySetBrightnessToMinimum = Instance.Create(0x0073, "Display Set Brightness to Minimum");
        /// <summary>
        ///     Consumer: Display Set Brightness to Maximum Usage.
        /// </summary>
        public static readonly Usage DisplaySetBrightnessToMaximum = Instance.Create(0x0074, "Display Set Brightness to Maximum");
        /// <summary>
        ///     Consumer: Display Set Auto Brightness Usage.
        /// </summary>
        public static readonly Usage DisplaySetAutoBrightness = Instance.Create(0x0075, "Display Set Auto Brightness");
        /// <summary>
        ///     Consumer: Camera Access Enabled Usage.
        /// </summary>
        public static readonly Usage CameraAccessEnabled = Instance.Create(0x0076, "Camera Access Enabled");
        /// <summary>
        ///     Consumer: Camera Access Disabled Usage.
        /// </summary>
        public static readonly Usage CameraAccessDisabled = Instance.Create(0x0077, "Camera Access Disabled");
        /// <summary>
        ///     Consumer: Camera Access Toggle Usage.
        /// </summary>
        public static readonly Usage CameraAccessToggle = Instance.Create(0x0078, "Camera Access Toggle");
        /// <summary>
        ///     Consumer: Keyboard Brightness Increment Usage.
        /// </summary>
        public static readonly Usage KeyboardBrightnessIncrement = Instance.Create(0x0079, "Keyboard Brightness Increment");
        /// <summary>
        ///     Consumer: Keyboard Brightness Decrement Usage.
        /// </summary>
        public static readonly Usage KeyboardBrightnessDecrement = Instance.Create(0x007a, "Keyboard Brightness Decrement");
        /// <summary>
        ///     Consumer: Keyboard Backlight Set Level Usage.
        /// </summary>
        public static readonly Usage KeyboardBacklightSetLevel = Instance.Create(0x007b, "Keyboard Backlight Set Level");
        /// <summary>
        ///     Consumer: Keyboard Backlight Toggle Usage.
        /// </summary>
        public static readonly Usage KeyboardBacklightToggle = Instance.Create(0x007c, "Keyboard Backlight Toggle");
        /// <summary>
        ///     Consumer: Keyboard Backlight Set Minimum Usage.
        /// </summary>
        public static readonly Usage KeyboardBacklightSetMinimum = Instance.Create(0x007d, "Keyboard Backlight Set Minimum");
        /// <summary>
        ///     Consumer: Keyboard Backlight Set Maximum Usage.
        /// </summary>
        public static readonly Usage KeyboardBacklightSetMaximum = Instance.Create(0x007e, "Keyboard Backlight Set Maximum");
        /// <summary>
        ///     Consumer: Keyboard Backlight Auto Usage.
        /// </summary>
        public static readonly Usage KeyboardBacklightAuto = Instance.Create(0x007f, "Keyboard Backlight Auto");

        /// <summary>
        ///     Consumer: Selection Usage.
        /// </summary>
        public static readonly Usage Selection = Instance.Create(0x0080, "Selection");
        /// <summary>
        ///     Consumer: Assign Selection Usage.
        /// </summary>
        public static readonly Usage AssignSelection = Instance.Create(0x0081, "Assign Selection");
        /// <summary>
        ///     Consumer: Mode Step Usage.
        /// </summary>
        public static readonly Usage ModeStep = Instance.Create(0x0082, "Mode Step");
        /// <summary>
        ///     Consumer: Recall Last Usage.
        /// </summary>
        public static readonly Usage RecallLast = Instance.Create(0x0083, "Recall Last");
        /// <summary>
        ///     Consumer: Enter Channel Usage.
        /// </summary>
        public static readonly Usage EnterChannel = Instance.Create(0x0084, "Enter Channel");
        /// <summary>
        ///     Consumer: Order Movie Usage.
        /// </summary>
        public static readonly Usage OrderMovie = Instance.Create(0x0085, "Order Movie");
        /// <summary>
        ///     Consumer: Channel Usage.
        /// </summary>
        public static readonly Usage Channel = Instance.Create(0x0086, "Channel");
        /// <summary>
        ///     Consumer: Media Selection Usage.
        /// </summary>
        public static readonly Usage MediaSelection = Instance.Create(0x0087, "Media Selection");
        /// <summary>
        ///     Consumer: Media Select  Usage.
        /// </summary>
        public static readonly Usage MediaSelect = Instance.Create(0x0088, "Media Select ");
        /// <summary>
        ///     Consumer: Media Select TV Usage.
        /// </summary>
        public static readonly Usage MediaSelectTV = Instance.Create(0x0089, "Media Select TV");
        /// <summary>
        ///     Consumer: Media Select WWW Usage.
        /// </summary>
        public static readonly Usage MediaSelectWWW = Instance.Create(0x008a, "Media Select WWW");
        /// <summary>
        ///     Consumer: Media Select DVD Usage.
        /// </summary>
        public static readonly Usage MediaSelectDVD = Instance.Create(0x008b, "Media Select DVD");
        /// <summary>
        ///     Consumer: Media Select Telephone Usage.
        /// </summary>
        public static readonly Usage MediaSelectTelephone = Instance.Create(0x008c, "Media Select Telephone");
        /// <summary>
        ///     Consumer: Media Select Program Guide Usage.
        /// </summary>
        public static readonly Usage MediaSelectProgramGuide = Instance.Create(0x008d, "Media Select Program Guide");
        /// <summary>
        ///     Consumer: Media Select Video Phone Usage.
        /// </summary>
        public static readonly Usage MediaSelectVideoPhone = Instance.Create(0x008e, "Media Select Video Phone");
        /// <summary>
        ///     Consumer: Media Select Games Usage.
        /// </summary>
        public static readonly Usage MediaSelectGames = Instance.Create(0x008f, "Media Select Games");
        /// <summary>
        ///     Consumer: Media Select Messages Usage.
        /// </summary>
        public static readonly Usage MediaSelectMessages = Instance.Create(0x0090, "Media Select Messages");
        /// <summary>
        ///     Consumer: Media Select CD Usage.
        /// </summary>
        public static readonly Usage MediaSelectCD = Instance.Create(0x0091, "Media Select CD");
        /// <summary>
        ///     Consumer: Media Select VCR Usage.
        /// </summary>
        public static readonly Usage MediaSelectVCR = Instance.Create(0x0092, "Media Select VCR");
        /// <summary>
        ///     Consumer: Media Select Tuner Usage.
        /// </summary>
        public static readonly Usage MediaSelectTuner = Instance.Create(0x0093, "Media Select Tuner");
        /// <summary>
        ///     Consumer: Quit Usage.
        /// </summary>
        public static readonly Usage Quit = Instance.Create(0x0094, "Quit");
        /// <summary>
        ///     Consumer: Help Usage.
        /// </summary>
        public static readonly Usage Help = Instance.Create(0x0095, "Help");
        /// <summary>
        ///     Consumer: Media Select Tape Usage.
        /// </summary>
        public static readonly Usage MediaSelectTape = Instance.Create(0x0096, "Media Select Tape");
        /// <summary>
        ///     Consumer: Media Select Cable Usage.
        /// </summary>
        public static readonly Usage MediaSelectCable = Instance.Create(0x0097, "Media Select Cable");
        /// <summary>
        ///     Consumer: Media Select Satellite Usage.
        /// </summary>
        public static readonly Usage MediaSelectSatellite = Instance.Create(0x0098, "Media Select Satellite");
        /// <summary>
        ///     Consumer: Media Select Security Usage.
        /// </summary>
        public static readonly Usage MediaSelectSecurity = Instance.Create(0x0099, "Media Select Security");
        /// <summary>
        ///     Consumer: Media Select Home Usage.
        /// </summary>
        public static readonly Usage MediaSelectHome = Instance.Create(0x009a, "Media Select Home");
        /// <summary>
        ///     Consumer: Media Select Call Usage.
        /// </summary>
        public static readonly Usage MediaSelectCall = Instance.Create(0x009b, "Media Select Call");
        /// <summary>
        ///     Consumer: Channel Increment Usage.
        /// </summary>
        public static readonly Usage ChannelIncrement = Instance.Create(0x009c, "Channel Increment");
        /// <summary>
        ///     Consumer: Channel Decrement Usage.
        /// </summary>
        public static readonly Usage ChannelDecrement = Instance.Create(0x009d, "Channel Decrement");
        /// <summary>
        ///     Consumer: Media Select SAP Usage.
        /// </summary>
        public static readonly Usage MediaSelectSAP = Instance.Create(0x009e, "Media Select SAP");

        /// <summary>
        ///     Consumer: VCR Plus Usage.
        /// </summary>
        public static readonly Usage VCRPlus = Instance.Create(0x00a0, "VCR Plus");
        /// <summary>
        ///     Consumer: Once Usage.
        /// </summary>
        public static readonly Usage Once = Instance.Create(0x00a1, "Once");
        /// <summary>
        ///     Consumer: Daily Usage.
        /// </summary>
        public static readonly Usage Daily = Instance.Create(0x00a2, "Daily");
        /// <summary>
        ///     Consumer: Weekly Usage.
        /// </summary>
        public static readonly Usage Weekly = Instance.Create(0x00a3, "Weekly");
        /// <summary>
        ///     Consumer: Monthly Usage.
        /// </summary>
        public static readonly Usage Monthly = Instance.Create(0x00a4, "Monthly");

        /// <summary>
        ///     Consumer: Play Usage.
        /// </summary>
        public static readonly Usage Play = Instance.Create(0x00b0, "Play");
        /// <summary>
        ///     Consumer: Pause Usage.
        /// </summary>
        public static readonly Usage Pause = Instance.Create(0x00b1, "Pause");
        /// <summary>
        ///     Consumer: Record Usage.
        /// </summary>
        public static readonly Usage Record = Instance.Create(0x00b2, "Record");
        /// <summary>
        ///     Consumer: Fast Forward Usage.
        /// </summary>
        public static readonly Usage FastForward = Instance.Create(0x00b3, "Fast Forward");
        /// <summary>
        ///     Consumer: Rewind Usage.
        /// </summary>
        public static readonly Usage Rewind = Instance.Create(0x00b4, "Rewind");
        /// <summary>
        ///     Consumer: Scan Next Track Usage.
        /// </summary>
        public static readonly Usage ScanNextTrack = Instance.Create(0x00b5, "Scan Next Track");
        /// <summary>
        ///     Consumer: Scan Previous Track Usage.
        /// </summary>
        public static readonly Usage ScanPreviousTrack = Instance.Create(0x00b6, "Scan Previous Track");
        /// <summary>
        ///     Consumer: Stop Usage.
        /// </summary>
        public static readonly Usage Stop = Instance.Create(0x00b7, "Stop");
        /// <summary>
        ///     Consumer: Eject Usage.
        /// </summary>
        public static readonly Usage Eject = Instance.Create(0x00b8, "Eject");
        /// <summary>
        ///     Consumer: Random Play Usage.
        /// </summary>
        public static readonly Usage RandomPlay = Instance.Create(0x00b9, "Random Play");
        /// <summary>
        ///     Consumer: Select Disk Usage.
        /// </summary>
        public static readonly Usage SelectDisk = Instance.Create(0x00ba, "Select Disk");
        /// <summary>
        ///     Consumer: Enter Disk Usage.
        /// </summary>
        public static readonly Usage EnterDisk = Instance.Create(0x00bb, "Enter Disk");
        /// <summary>
        ///     Consumer: Repeat Usage.
        /// </summary>
        public static readonly Usage Repeat = Instance.Create(0x00bc, "Repeat");
        /// <summary>
        ///     Consumer: Tracking Usage.
        /// </summary>
        public static readonly Usage Tracking = Instance.Create(0x00bd, "Tracking");
        /// <summary>
        ///     Consumer: Track Normal Usage.
        /// </summary>
        public static readonly Usage TrackNormal = Instance.Create(0x00be, "Track Normal");
        /// <summary>
        ///     Consumer: Slow Tracking Usage.
        /// </summary>
        public static readonly Usage SlowTracking = Instance.Create(0x00bf, "Slow Tracking");
        /// <summary>
        ///     Consumer: Frame Forward Usage.
        /// </summary>
        public static readonly Usage FrameForward = Instance.Create(0x00c0, "Frame Forward");
        /// <summary>
        ///     Consumer: Frame Back Usage.
        /// </summary>
        public static readonly Usage FrameBack = Instance.Create(0x00c1, "Frame Back");
        /// <summary>
        ///     Consumer: Mark Usage.
        /// </summary>
        public static readonly Usage Mark = Instance.Create(0x00c2, "Mark");
        /// <summary>
        ///     Consumer: Clear Mark Usage.
        /// </summary>
        public static readonly Usage ClearMark = Instance.Create(0x00c3, "Clear Mark");
        /// <summary>
        ///     Consumer: Repeat From Mark Usage.
        /// </summary>
        public static readonly Usage RepeatFromMark = Instance.Create(0x00c4, "Repeat From Mark");
        /// <summary>
        ///     Consumer: Return To Mark Usage.
        /// </summary>
        public static readonly Usage ReturnToMark = Instance.Create(0x00c5, "Return To Mark");
        /// <summary>
        ///     Consumer: Search Mark Forward Usage.
        /// </summary>
        public static readonly Usage SearchMarkForward = Instance.Create(0x00c6, "Search Mark Forward");
        /// <summary>
        ///     Consumer: Search Mark Backwards Usage.
        /// </summary>
        public static readonly Usage SearchMarkBackwards = Instance.Create(0x00c7, "Search Mark Backwards");
        /// <summary>
        ///     Consumer: Counter Reset Usage.
        /// </summary>
        public static readonly Usage CounterReset = Instance.Create(0x00c8, "Counter Reset");
        /// <summary>
        ///     Consumer: Show Counter Usage.
        /// </summary>
        public static readonly Usage ShowCounter = Instance.Create(0x00c9, "Show Counter");
        /// <summary>
        ///     Consumer: Tracking Increment Usage.
        /// </summary>
        public static readonly Usage TrackingIncrement = Instance.Create(0x00ca, "Tracking Increment");
        /// <summary>
        ///     Consumer: Tracking Decrement Usage.
        /// </summary>
        public static readonly Usage TrackingDecrement = Instance.Create(0x00cb, "Tracking Decrement");
        /// <summary>
        ///     Consumer: Stop/Eject Usage.
        /// </summary>
        public static readonly Usage StopEject = Instance.Create(0x00cc, "Stop/Eject");
        /// <summary>
        ///     Consumer: Play/Pause Usage.
        /// </summary>
        public static readonly Usage PlayPause = Instance.Create(0x00cd, "Play/Pause");
        /// <summary>
        ///     Consumer: Play/Skip Usage.
        /// </summary>
        public static readonly Usage PlaySkip = Instance.Create(0x00ce, "Play/Skip");
        /// <summary>
        ///     Consumer: Voice Command Usage.
        /// </summary>
        public static readonly Usage VoiceCommand = Instance.Create(0x00cf, "Voice Command");
        /// <summary>
        ///     Consumer: Invoke Capture Interface Usage.
        /// </summary>
        public static readonly Usage InvokeCaptureInterface = Instance.Create(0x00d0, "Invoke Capture Interface");
        /// <summary>
        ///     Consumer: Start/Stop Game Recording Usage.
        /// </summary>
        public static readonly Usage StartStopGameRecording = Instance.Create(0x00d1, "Start/Stop Game Recording");
        /// <summary>
        ///     Consumer: Historical Game Capture Usage.
        /// </summary>
        public static readonly Usage HistoricalGameCapture = Instance.Create(0x00d2, "Historical Game Capture");
        /// <summary>
        ///     Consumer: Capture Game Screenshot Usage.
        /// </summary>
        public static readonly Usage CaptureGameScreenshot = Instance.Create(0x00d3, "Capture Game Screenshot");
        /// <summary>
        ///     Consumer: Show/Hide Recording Indicator Usage.
        /// </summary>
        public static readonly Usage ShowHideRecordingIndicator = Instance.Create(0x00d4, "Show/Hide Recording Indicator");
        /// <summary>
        ///     Consumer: Start/Stop Microphone Capture Usage.
        /// </summary>
        public static readonly Usage StartStopMicrophoneCapture = Instance.Create(0x00d5, "Start/Stop Microphone Capture");
        /// <summary>
        ///     Consumer: Start or Stop Camera Capture Usage.
        /// </summary>
        public static readonly Usage StartOrStopCameraCapture = Instance.Create(0x00d6, "Start or Stop Camera Capture");
        /// <summary>
        ///     Consumer: Start/Stop Game Broadcast Usage.
        /// </summary>
        public static readonly Usage StartStopGameBroadcast = Instance.Create(0x00d7, "Start/Stop Game Broadcast");

        /// <summary>
        ///     Consumer: Volume Usage.
        /// </summary>
        public static readonly Usage Volume = Instance.Create(0x00e0, "Volume");
        /// <summary>
        ///     Consumer: Balance Usage.
        /// </summary>
        public static readonly Usage Balance = Instance.Create(0x00e1, "Balance");
        /// <summary>
        ///     Consumer: Mute Usage.
        /// </summary>
        public static readonly Usage Mute = Instance.Create(0x00e2, "Mute");
        /// <summary>
        ///     Consumer: Bass Usage.
        /// </summary>
        public static readonly Usage Bass = Instance.Create(0x00e3, "Bass");
        /// <summary>
        ///     Consumer: Treble Usage.
        /// </summary>
        public static readonly Usage Treble = Instance.Create(0x00e4, "Treble");
        /// <summary>
        ///     Consumer: Bass Boost Usage.
        /// </summary>
        public static readonly Usage BassBoost = Instance.Create(0x00e5, "Bass Boost");
        /// <summary>
        ///     Consumer: Surround Mode Usage.
        /// </summary>
        public static readonly Usage SurroundMode = Instance.Create(0x00e6, "Surround Mode");
        /// <summary>
        ///     Consumer: Loudness Usage.
        /// </summary>
        public static readonly Usage Loudness = Instance.Create(0x00e7, "Loudness");
        /// <summary>
        ///     Consumer: MPX Usage.
        /// </summary>
        public static readonly Usage MPX = Instance.Create(0x00e8, "MPX");
        /// <summary>
        ///     Consumer: Volume Increment Usage.
        /// </summary>
        public static readonly Usage VolumeIncrement = Instance.Create(0x00e9, "Volume Increment");
        /// <summary>
        ///     Consumer: Volume Decrement Usage.
        /// </summary>
        public static readonly Usage VolumeDecrement = Instance.Create(0x00ea, "Volume Decrement");

        /// <summary>
        ///     Consumer: Speed Select Usage.
        /// </summary>
        public static readonly Usage SpeedSelect = Instance.Create(0x00f0, "Speed Select");
        /// <summary>
        ///     Consumer: Playback Speed Usage.
        /// </summary>
        public static readonly Usage PlaybackSpeed = Instance.Create(0x00f1, "Playback Speed");
        /// <summary>
        ///     Consumer: Standard Play Usage.
        /// </summary>
        public static readonly Usage StandardPlay = Instance.Create(0x00f2, "Standard Play");
        /// <summary>
        ///     Consumer: Long Play Usage.
        /// </summary>
        public static readonly Usage LongPlay = Instance.Create(0x00f3, "Long Play");
        /// <summary>
        ///     Consumer: Extended Play Usage.
        /// </summary>
        public static readonly Usage ExtendedPlay = Instance.Create(0x00f4, "Extended Play");
        /// <summary>
        ///     Consumer: Slow Usage.
        /// </summary>
        public static readonly Usage Slow = Instance.Create(0x00f5, "Slow");

        /// <summary>
        ///     Consumer: Fan Enable Usage.
        /// </summary>
        public static readonly Usage FanEnable = Instance.Create(0x0100, "Fan Enable");
        /// <summary>
        ///     Consumer: Fan Speed Usage.
        /// </summary>
        public static readonly Usage FanSpeed = Instance.Create(0x0101, "Fan Speed");
        /// <summary>
        ///     Consumer: Light Enable Usage.
        /// </summary>
        public static readonly Usage LightEnable = Instance.Create(0x0102, "Light Enable");
        /// <summary>
        ///     Consumer: Light Illumination Level Usage.
        /// </summary>
        public static readonly Usage LightIlluminationLevel = Instance.Create(0x0103, "Light Illumination Level");
        /// <summary>
        ///     Consumer: Climate Control Enable Usage.
        /// </summary>
        public static readonly Usage ClimateControlEnable = Instance.Create(0x0104, "Climate Control Enable");
        /// <summary>
        ///     Consumer: Room Temperature Usage.
        /// </summary>
        public static readonly Usage RoomTemperature = Instance.Create(0x0105, "Room Temperature");
        /// <summary>
        ///     Consumer: Security Enable Usage.
        /// </summary>
        public static readonly Usage SecurityEnable = Instance.Create(0x0106, "Security Enable");
        /// <summary>
        ///     Consumer: Fire Alarm Usage.
        /// </summary>
        public static readonly Usage FireAlarm = Instance.Create(0x0107, "Fire Alarm");
        /// <summary>
        ///     Consumer: Police Alarm Usage.
        /// </summary>
        public static readonly Usage PoliceAlarm = Instance.Create(0x0108, "Police Alarm");
        /// <summary>
        ///     Consumer: Proximity Usage.
        /// </summary>
        public static readonly Usage Proximity = Instance.Create(0x0109, "Proximity");
        /// <summary>
        ///     Consumer: Motion Usage.
        /// </summary>
        public static readonly Usage Motion = Instance.Create(0x010a, "Motion");
        /// <summary>
        ///     Consumer: Duress Alarm Usage.
        /// </summary>
        public static readonly Usage DuressAlarm = Instance.Create(0x010b, "Duress Alarm");
        /// <summary>
        ///     Consumer: Holdup Alarm Usage.
        /// </summary>
        public static readonly Usage HoldupAlarm = Instance.Create(0x010c, "Holdup Alarm");
        /// <summary>
        ///     Consumer: Medical Alarm Usage.
        /// </summary>
        public static readonly Usage MedicalAlarm = Instance.Create(0x010d, "Medical Alarm");

        /// <summary>
        ///     Consumer: Balance Right Usage.
        /// </summary>
        public static readonly Usage BalanceRight = Instance.Create(0x0150, "Balance Right");
        /// <summary>
        ///     Consumer: Balance Left Usage.
        /// </summary>
        public static readonly Usage BalanceLeft = Instance.Create(0x0151, "Balance Left");
        /// <summary>
        ///     Consumer: Bass Increment Usage.
        /// </summary>
        public static readonly Usage BassIncrement = Instance.Create(0x0152, "Bass Increment");
        /// <summary>
        ///     Consumer: Bass Decrement Usage.
        /// </summary>
        public static readonly Usage BassDecrement = Instance.Create(0x0153, "Bass Decrement");
        /// <summary>
        ///     Consumer: Treble Increment Usage.
        /// </summary>
        public static readonly Usage TrebleIncrement = Instance.Create(0x0154, "Treble Increment");
        /// <summary>
        ///     Consumer: Treble Decrement Usage.
        /// </summary>
        public static readonly Usage TrebleDecrement = Instance.Create(0x0155, "Treble Decrement");

        /// <summary>
        ///     Consumer: Speaker System Usage.
        /// </summary>
        public static readonly Usage SpeakerSystem = Instance.Create(0x0160, "Speaker System");
        /// <summary>
        ///     Consumer: Channel Left Usage.
        /// </summary>
        public static readonly Usage ChannelLeft = Instance.Create(0x0161, "Channel Left");
        /// <summary>
        ///     Consumer: Channel Right Usage.
        /// </summary>
        public static readonly Usage ChannelRight = Instance.Create(0x0162, "Channel Right");
        /// <summary>
        ///     Consumer: Channel Center Usage.
        /// </summary>
        public static readonly Usage ChannelCenter = Instance.Create(0x0163, "Channel Center");
        /// <summary>
        ///     Consumer: Channel Front Usage.
        /// </summary>
        public static readonly Usage ChannelFront = Instance.Create(0x0164, "Channel Front");
        /// <summary>
        ///     Consumer: Channel Center Front Usage.
        /// </summary>
        public static readonly Usage ChannelCenterFront = Instance.Create(0x0165, "Channel Center Front");
        /// <summary>
        ///     Consumer: Channel Side Usage.
        /// </summary>
        public static readonly Usage ChannelSide = Instance.Create(0x0166, "Channel Side");
        /// <summary>
        ///     Consumer: Channel Surround Usage.
        /// </summary>
        public static readonly Usage ChannelSurround = Instance.Create(0x0167, "Channel Surround");
        /// <summary>
        ///     Consumer: Channel Low Frequency Enhancement Usage.
        /// </summary>
        public static readonly Usage ChannelLowFrequencyEnhancement = Instance.Create(0x0168, "Channel Low Frequency Enhancement");
        /// <summary>
        ///     Consumer: Channel Top Usage.
        /// </summary>
        public static readonly Usage ChannelTop = Instance.Create(0x0169, "Channel Top");
        /// <summary>
        ///     Consumer: Channel Unknown Usage.
        /// </summary>
        public static readonly Usage ChannelUnknown = Instance.Create(0x016a, "Channel Unknown");

        /// <summary>
        ///     Consumer: Sub-channel Usage.
        /// </summary>
        public static readonly Usage Subchannel = Instance.Create(0x0170, "Sub-channel");
        /// <summary>
        ///     Consumer: Sub-channel Increment Usage.
        /// </summary>
        public static readonly Usage SubchannelIncrement = Instance.Create(0x0171, "Sub-channel Increment");
        /// <summary>
        ///     Consumer: Sub-channel Decrement Usage.
        /// </summary>
        public static readonly Usage SubchannelDecrement = Instance.Create(0x0172, "Sub-channel Decrement");
        /// <summary>
        ///     Consumer: Alternate Audio Increment Usage.
        /// </summary>
        public static readonly Usage AlternateAudioIncrement = Instance.Create(0x0173, "Alternate Audio Increment");
        /// <summary>
        ///     Consumer: Alternate Audio Decrement Usage.
        /// </summary>
        public static readonly Usage AlternateAudioDecrement = Instance.Create(0x0174, "Alternate Audio Decrement");

        /// <summary>
        ///     Consumer: Application Launch Buttons Usage.
        /// </summary>
        public static readonly Usage ApplicationLaunchButtons = Instance.Create(0x0180, "Application Launch Buttons");
        /// <summary>
        ///     Consumer: AL Launch Button Configuration Tool Usage.
        /// </summary>
        public static readonly Usage ALLaunchButtonConfigurationTool = Instance.Create(0x0181, "AL Launch Button Configuration Tool");
        /// <summary>
        ///     Consumer: AL Programmable Button Configuration Usage.
        /// </summary>
        public static readonly Usage ALProgrammableButtonConfiguration = Instance.Create(0x0182, "AL Programmable Button Configuration");
        /// <summary>
        ///     Consumer: AL Consumer Control Configuration Usage.
        /// </summary>
        public static readonly Usage ALConsumerControlConfiguration = Instance.Create(0x0183, "AL Consumer Control Configuration");
        /// <summary>
        ///     Consumer: AL Word Processor Usage.
        /// </summary>
        public static readonly Usage ALWordProcessor = Instance.Create(0x0184, "AL Word Processor");
        /// <summary>
        ///     Consumer: AL Text Editor Usage.
        /// </summary>
        public static readonly Usage ALTextEditor = Instance.Create(0x0185, "AL Text Editor");
        /// <summary>
        ///     Consumer: AL Spreadsheet Usage.
        /// </summary>
        public static readonly Usage ALSpreadsheet = Instance.Create(0x0186, "AL Spreadsheet");
        /// <summary>
        ///     Consumer: AL Graphics Editor Usage.
        /// </summary>
        public static readonly Usage ALGraphicsEditor = Instance.Create(0x0187, "AL Graphics Editor");
        /// <summary>
        ///     Consumer: AL Presentation App Usage.
        /// </summary>
        public static readonly Usage ALPresentationApp = Instance.Create(0x0188, "AL Presentation App");
        /// <summary>
        ///     Consumer: AL Database App Usage.
        /// </summary>
        public static readonly Usage ALDatabaseApp = Instance.Create(0x0189, "AL Database App");
        /// <summary>
        ///     Consumer: AL Email Reader Usage.
        /// </summary>
        public static readonly Usage ALEmailReader = Instance.Create(0x018a, "AL Email Reader");
        /// <summary>
        ///     Consumer: AL Newsreader Usage.
        /// </summary>
        public static readonly Usage ALNewsreader = Instance.Create(0x018b, "AL Newsreader");
        /// <summary>
        ///     Consumer: AL Voicemail Usage.
        /// </summary>
        public static readonly Usage ALVoicemail = Instance.Create(0x018c, "AL Voicemail");
        /// <summary>
        ///     Consumer: AL Contacts/Address Book Usage.
        /// </summary>
        public static readonly Usage ALContactsAddressBook = Instance.Create(0x018d, "AL Contacts/Address Book");
        /// <summary>
        ///     Consumer: AL Calendar/Schedule Usage.
        /// </summary>
        public static readonly Usage ALCalendarSchedule = Instance.Create(0x018e, "AL Calendar/Schedule");
        /// <summary>
        ///     Consumer: AL Task/Project Manager Usage.
        /// </summary>
        public static readonly Usage ALTaskProjectManager = Instance.Create(0x018f, "AL Task/Project Manager");
        /// <summary>
        ///     Consumer: AL Log/Journal/Timecard Usage.
        /// </summary>
        public static readonly Usage ALLogJournalTimecard = Instance.Create(0x0190, "AL Log/Journal/Timecard");
        /// <summary>
        ///     Consumer: AL Checkbook/Finance Usage.
        /// </summary>
        public static readonly Usage ALCheckbookFinance = Instance.Create(0x0191, "AL Checkbook/Finance");
        /// <summary>
        ///     Consumer: AL Calculator Usage.
        /// </summary>
        public static readonly Usage ALCalculator = Instance.Create(0x0192, "AL Calculator");
        /// <summary>
        ///     Consumer: AL A/V Capture/Playback Usage.
        /// </summary>
        public static readonly Usage ALAVCapturePlayback = Instance.Create(0x0193, "AL A/V Capture/Playback");
        /// <summary>
        ///     Consumer: AL Local Machine Browser Usage.
        /// </summary>
        public static readonly Usage ALLocalMachineBrowser = Instance.Create(0x0194, "AL Local Machine Browser");
        /// <summary>
        ///     Consumer: AL LAN/WAN Browser Usage.
        /// </summary>
        public static readonly Usage ALLANWANBrowser = Instance.Create(0x0195, "AL LAN/WAN Browser");
        /// <summary>
        ///     Consumer: AL Internet Browser Usage.
        /// </summary>
        public static readonly Usage ALInternetBrowser = Instance.Create(0x0196, "AL Internet Browser");
        /// <summary>
        ///     Consumer: AL Remote Networking/ISP Connect Usage.
        /// </summary>
        public static readonly Usage ALRemoteNetworkingISPConnect = Instance.Create(0x0197, "AL Remote Networking/ISP Connect");
        /// <summary>
        ///     Consumer: AL Network Conference Usage.
        /// </summary>
        public static readonly Usage ALNetworkConference = Instance.Create(0x0198, "AL Network Conference");
        /// <summary>
        ///     Consumer: AL Network Chat Usage.
        /// </summary>
        public static readonly Usage ALNetworkChat = Instance.Create(0x0199, "AL Network Chat");
        /// <summary>
        ///     Consumer: AL Telephony/Dialer Usage.
        /// </summary>
        public static readonly Usage ALTelephonyDialer = Instance.Create(0x019a, "AL Telephony/Dialer");
        /// <summary>
        ///     Consumer: AL Logon Usage.
        /// </summary>
        public static readonly Usage ALLogon = Instance.Create(0x019b, "AL Logon");
        /// <summary>
        ///     Consumer: AL Logoff Usage.
        /// </summary>
        public static readonly Usage ALLogoff = Instance.Create(0x019c, "AL Logoff");
        /// <summary>
        ///     Consumer: AL Logon/Logoff Usage.
        /// </summary>
        public static readonly Usage ALLogonLogoff = Instance.Create(0x019d, "AL Logon/Logoff");
        /// <summary>
        ///     Consumer: AL Terminal Lock/Screensaver Usage.
        /// </summary>
        public static readonly Usage ALTerminalLockScreensaver = Instance.Create(0x019e, "AL Terminal Lock/Screensaver");
        /// <summary>
        ///     Consumer: AL Control Panel Usage.
        /// </summary>
        public static readonly Usage ALControlPanel = Instance.Create(0x019f, "AL Control Panel");
        /// <summary>
        ///     Consumer: AL Command Line Processor/Run Usage.
        /// </summary>
        public static readonly Usage ALCommandLineProcessorRun = Instance.Create(0x01a0, "AL Command Line Processor/Run");
        /// <summary>
        ///     Consumer: AL Process/Task Manager Usage.
        /// </summary>
        public static readonly Usage ALProcessTaskManager = Instance.Create(0x01a1, "AL Process/Task Manager");
        /// <summary>
        ///     Consumer: AL Select Task/Application Usage.
        /// </summary>
        public static readonly Usage ALSelectTaskApplication = Instance.Create(0x01a2, "AL Select Task/Application");
        /// <summary>
        ///     Consumer: AL Next Task/Application Usage.
        /// </summary>
        public static readonly Usage ALNextTaskApplication = Instance.Create(0x01a3, "AL Next Task/Application");
        /// <summary>
        ///     Consumer: AL Previous Task/Application Usage.
        /// </summary>
        public static readonly Usage ALPreviousTaskApplication = Instance.Create(0x01a4, "AL Previous Task/Application");
        /// <summary>
        ///     Consumer: AL Preemptive Halt Task/Application Usage.
        /// </summary>
        public static readonly Usage ALPreemptiveHaltTaskApplication = Instance.Create(0x01a5, "AL Preemptive Halt Task/Application");
        /// <summary>
        ///     Consumer: AL Integrated Help Center Usage.
        /// </summary>
        public static readonly Usage ALIntegratedHelpCenter = Instance.Create(0x01a6, "AL Integrated Help Center");
        /// <summary>
        ///     Consumer: AL Documents Usage.
        /// </summary>
        public static readonly Usage ALDocuments = Instance.Create(0x01a7, "AL Documents");
        /// <summary>
        ///     Consumer: AL Thesaurus Usage.
        /// </summary>
        public static readonly Usage ALThesaurus = Instance.Create(0x01a8, "AL Thesaurus");
        /// <summary>
        ///     Consumer: AL Dictionary Usage.
        /// </summary>
        public static readonly Usage ALDictionary = Instance.Create(0x01a9, "AL Dictionary");
        /// <summary>
        ///     Consumer: AL Desktop Usage.
        /// </summary>
        public static readonly Usage ALDesktop = Instance.Create(0x01aa, "AL Desktop");
        /// <summary>
        ///     Consumer: AL Spell Check Usage.
        /// </summary>
        public static readonly Usage ALSpellCheck = Instance.Create(0x01ab, "AL Spell Check");
        /// <summary>
        ///     Consumer: AL Grammar Check Usage.
        /// </summary>
        public static readonly Usage ALGrammarCheck = Instance.Create(0x01ac, "AL Grammar Check");
        /// <summary>
        ///     Consumer: AL Wireless Status Usage.
        /// </summary>
        public static readonly Usage ALWirelessStatus = Instance.Create(0x01ad, "AL Wireless Status");
        /// <summary>
        ///     Consumer: AL Keyboard Layout Usage.
        /// </summary>
        public static readonly Usage ALKeyboardLayout = Instance.Create(0x01ae, "AL Keyboard Layout");
        /// <summary>
        ///     Consumer: AL Virus Protection Usage.
        /// </summary>
        public static readonly Usage ALVirusProtection = Instance.Create(0x01af, "AL Virus Protection");
        /// <summary>
        ///     Consumer: AL Encryption Usage.
        /// </summary>
        public static readonly Usage ALEncryption = Instance.Create(0x01b0, "AL Encryption");
        /// <summary>
        ///     Consumer: AL Screen Saver Usage.
        /// </summary>
        public static readonly Usage ALScreenSaver = Instance.Create(0x01b1, "AL Screen Saver");
        /// <summary>
        ///     Consumer: AL Alarms Usage.
        /// </summary>
        public static readonly Usage ALAlarms = Instance.Create(0x01b2, "AL Alarms");
        /// <summary>
        ///     Consumer: AL Clock Usage.
        /// </summary>
        public static readonly Usage ALClock = Instance.Create(0x01b3, "AL Clock");
        /// <summary>
        ///     Consumer: AL File Browser Usage.
        /// </summary>
        public static readonly Usage ALFileBrowser = Instance.Create(0x01b4, "AL File Browser");
        /// <summary>
        ///     Consumer: AL Power Status Usage.
        /// </summary>
        public static readonly Usage ALPowerStatus = Instance.Create(0x01b5, "AL Power Status");
        /// <summary>
        ///     Consumer: AL Image Browser Usage.
        /// </summary>
        public static readonly Usage ALImageBrowser = Instance.Create(0x01b6, "AL Image Browser");
        /// <summary>
        ///     Consumer: AL Audio Browser Usage.
        /// </summary>
        public static readonly Usage ALAudioBrowser = Instance.Create(0x01b7, "AL Audio Browser");
        /// <summary>
        ///     Consumer: AL Movie Browser Usage.
        /// </summary>
        public static readonly Usage ALMovieBrowser = Instance.Create(0x01b8, "AL Movie Browser");
        /// <summary>
        ///     Consumer: AL Digital Rights Manager Usage.
        /// </summary>
        public static readonly Usage ALDigitalRightsManager = Instance.Create(0x01b9, "AL Digital Rights Manager");
        /// <summary>
        ///     Consumer: AL Digital Wallet Usage.
        /// </summary>
        public static readonly Usage ALDigitalWallet = Instance.Create(0x01ba, "AL Digital Wallet");

        /// <summary>
        ///     Consumer: AL Instant Messaging Usage.
        /// </summary>
        public static readonly Usage ALInstantMessaging = Instance.Create(0x01bc, "AL Instant Messaging");
        /// <summary>
        ///     Consumer: AL OEM Features/Tips/Tutorial Browser Usage.
        /// </summary>
        public static readonly Usage ALOEMFeaturesTipsTutorialBrowser = Instance.Create(0x01bd, "AL OEM Features/Tips/Tutorial Browser");
        /// <summary>
        ///     Consumer: AL OEM Help Usage.
        /// </summary>
        public static readonly Usage ALOEMHelp = Instance.Create(0x01be, "AL OEM Help");
        /// <summary>
        ///     Consumer: AL Online Community Usage.
        /// </summary>
        public static readonly Usage ALOnlineCommunity = Instance.Create(0x01bf, "AL Online Community");
        /// <summary>
        ///     Consumer: AL Entertainment Content Browser Usage.
        /// </summary>
        public static readonly Usage ALEntertainmentContentBrowser = Instance.Create(0x01c0, "AL Entertainment Content Browser");
        /// <summary>
        ///     Consumer: AL Online Shopping Browser Usage.
        /// </summary>
        public static readonly Usage ALOnlineShoppingBrowser = Instance.Create(0x01c1, "AL Online Shopping Browser");
        /// <summary>
        ///     Consumer: AL SmartCard Information/Help Usage.
        /// </summary>
        public static readonly Usage ALSmartCardInformationHelp = Instance.Create(0x01c2, "AL SmartCard Information/Help");
        /// <summary>
        ///     Consumer: AL Market Monitor/Finance Browser Usage.
        /// </summary>
        public static readonly Usage ALMarketMonitorFinanceBrowser = Instance.Create(0x01c3, "AL Market Monitor/Finance Browser");
        /// <summary>
        ///     Consumer: AL Customized Corporate News Browser Usage.
        /// </summary>
        public static readonly Usage ALCustomizedCorporateNewsBrowser = Instance.Create(0x01c4, "AL Customized Corporate News Browser");
        /// <summary>
        ///     Consumer: AL Online Activity Browser Usage.
        /// </summary>
        public static readonly Usage ALOnlineActivityBrowser = Instance.Create(0x01c5, "AL Online Activity Browser");
        /// <summary>
        ///     Consumer: AL Research/Search Browser Usage.
        /// </summary>
        public static readonly Usage ALResearchSearchBrowser = Instance.Create(0x01c6, "AL Research/Search Browser");
        /// <summary>
        ///     Consumer: AL Audio Player Usage.
        /// </summary>
        public static readonly Usage ALAudioPlayer = Instance.Create(0x01c7, "AL Audio Player");
        /// <summary>
        ///     Consumer: AL Navigation Usage.
        /// </summary>
        public static readonly Usage ALNavigation = Instance.Create(0x01c8, "AL Navigation");

        /// <summary>
        ///     Consumer: AL Context-aware desktop assistant Usage.
        /// </summary>
        public static readonly Usage ALContextawareDesktopAssistant = Instance.Create(0x01cb, "AL Context-aware desktop assistant");

        /// <summary>
        ///     Consumer: Generic GUI Application Controls Usage.
        /// </summary>
        public static readonly Usage GenericGUIApplicationControls = Instance.Create(0x0200, "Generic GUI Application Controls");
        /// <summary>
        ///     Consumer: AC New Usage.
        /// </summary>
        public static readonly Usage ACNew = Instance.Create(0x0201, "AC New");
        /// <summary>
        ///     Consumer: AC Open Usage.
        /// </summary>
        public static readonly Usage ACOpen = Instance.Create(0x0202, "AC Open");
        /// <summary>
        ///     Consumer: AC Close Usage.
        /// </summary>
        public static readonly Usage ACClose = Instance.Create(0x0203, "AC Close");
        /// <summary>
        ///     Consumer: AC Exit Usage.
        /// </summary>
        public static readonly Usage ACExit = Instance.Create(0x0204, "AC Exit");
        /// <summary>
        ///     Consumer: AC Maximize Usage.
        /// </summary>
        public static readonly Usage ACMaximize = Instance.Create(0x0205, "AC Maximize");
        /// <summary>
        ///     Consumer: AC Minimize Usage.
        /// </summary>
        public static readonly Usage ACMinimize = Instance.Create(0x0206, "AC Minimize");
        /// <summary>
        ///     Consumer: AC Save Usage.
        /// </summary>
        public static readonly Usage ACSave = Instance.Create(0x0207, "AC Save");
        /// <summary>
        ///     Consumer: AC Print Usage.
        /// </summary>
        public static readonly Usage ACPrint = Instance.Create(0x0208, "AC Print");
        /// <summary>
        ///     Consumer: AC Properties Usage.
        /// </summary>
        public static readonly Usage ACProperties = Instance.Create(0x0209, "AC Properties");

        /// <summary>
        ///     Consumer: AC Undo Usage.
        /// </summary>
        public static readonly Usage ACUndo = Instance.Create(0x021a, "AC Undo");
        /// <summary>
        ///     Consumer: AC Copy Usage.
        /// </summary>
        public static readonly Usage ACCopy = Instance.Create(0x021b, "AC Copy");
        /// <summary>
        ///     Consumer: AC Cut Usage.
        /// </summary>
        public static readonly Usage ACCut = Instance.Create(0x021c, "AC Cut");
        /// <summary>
        ///     Consumer: AC Paste Usage.
        /// </summary>
        public static readonly Usage ACPaste = Instance.Create(0x021d, "AC Paste");
        /// <summary>
        ///     Consumer: AC Select All Usage.
        /// </summary>
        public static readonly Usage ACSelectAll = Instance.Create(0x021e, "AC Select All");
        /// <summary>
        ///     Consumer: AC Find Usage.
        /// </summary>
        public static readonly Usage ACFind = Instance.Create(0x021f, "AC Find");
        /// <summary>
        ///     Consumer: AC Find and Replace Usage.
        /// </summary>
        public static readonly Usage ACFindAndReplace = Instance.Create(0x0220, "AC Find and Replace");
        /// <summary>
        ///     Consumer: AC Search Usage.
        /// </summary>
        public static readonly Usage ACSearch = Instance.Create(0x0221, "AC Search");
        /// <summary>
        ///     Consumer: AC Go To Usage.
        /// </summary>
        public static readonly Usage ACGoTo = Instance.Create(0x0222, "AC Go To");
        /// <summary>
        ///     Consumer: AC Home Usage.
        /// </summary>
        public static readonly Usage ACHome = Instance.Create(0x0223, "AC Home");
        /// <summary>
        ///     Consumer: AC Back Usage.
        /// </summary>
        public static readonly Usage ACBack = Instance.Create(0x0224, "AC Back");
        /// <summary>
        ///     Consumer: AC Forward Usage.
        /// </summary>
        public static readonly Usage ACForward = Instance.Create(0x0225, "AC Forward");
        /// <summary>
        ///     Consumer: AC Stop Usage.
        /// </summary>
        public static readonly Usage ACStop = Instance.Create(0x0226, "AC Stop");
        /// <summary>
        ///     Consumer: AC Refresh Usage.
        /// </summary>
        public static readonly Usage ACRefresh = Instance.Create(0x0227, "AC Refresh");
        /// <summary>
        ///     Consumer: AC Previous Link Usage.
        /// </summary>
        public static readonly Usage ACPreviousLink = Instance.Create(0x0228, "AC Previous Link");
        /// <summary>
        ///     Consumer: AC Next Link Usage.
        /// </summary>
        public static readonly Usage ACNextLink = Instance.Create(0x0229, "AC Next Link");
        /// <summary>
        ///     Consumer: AC Bookmarks Usage.
        /// </summary>
        public static readonly Usage ACBookmarks = Instance.Create(0x022a, "AC Bookmarks");
        /// <summary>
        ///     Consumer: AC History Usage.
        /// </summary>
        public static readonly Usage ACHistory = Instance.Create(0x022b, "AC History");
        /// <summary>
        ///     Consumer: AC Subscriptions Usage.
        /// </summary>
        public static readonly Usage ACSubscriptions = Instance.Create(0x022c, "AC Subscriptions");
        /// <summary>
        ///     Consumer: AC Zoom In Usage.
        /// </summary>
        public static readonly Usage ACZoomIn = Instance.Create(0x022d, "AC Zoom In");
        /// <summary>
        ///     Consumer: AC Zoom Out Usage.
        /// </summary>
        public static readonly Usage ACZoomOut = Instance.Create(0x022e, "AC Zoom Out");
        /// <summary>
        ///     Consumer: AC Zoom Usage.
        /// </summary>
        public static readonly Usage ACZoom = Instance.Create(0x022f, "AC Zoom");
        /// <summary>
        ///     Consumer: AC Full Screen View Usage.
        /// </summary>
        public static readonly Usage ACFullScreenView = Instance.Create(0x0230, "AC Full Screen View");
        /// <summary>
        ///     Consumer: AC Normal View Usage.
        /// </summary>
        public static readonly Usage ACNormalView = Instance.Create(0x0231, "AC Normal View");
        /// <summary>
        ///     Consumer: AC View Toggle Usage.
        /// </summary>
        public static readonly Usage ACViewToggle = Instance.Create(0x0232, "AC View Toggle");
        /// <summary>
        ///     Consumer: AC Scroll Up Usage.
        /// </summary>
        public static readonly Usage ACScrollUp = Instance.Create(0x0233, "AC Scroll Up");
        /// <summary>
        ///     Consumer: AC Scroll Down Usage.
        /// </summary>
        public static readonly Usage ACScrollDown = Instance.Create(0x0234, "AC Scroll Down");
        /// <summary>
        ///     Consumer: AC Scroll Usage.
        /// </summary>
        public static readonly Usage ACScroll = Instance.Create(0x0235, "AC Scroll");
        /// <summary>
        ///     Consumer: AC Pan Left Usage.
        /// </summary>
        public static readonly Usage ACPanLeft = Instance.Create(0x0236, "AC Pan Left");
        /// <summary>
        ///     Consumer: AC Pan Right Usage.
        /// </summary>
        public static readonly Usage ACPanRight = Instance.Create(0x0237, "AC Pan Right");
        /// <summary>
        ///     Consumer: AC Pan Usage.
        /// </summary>
        public static readonly Usage ACPan = Instance.Create(0x0238, "AC Pan");
        /// <summary>
        ///     Consumer: AC New Window Usage.
        /// </summary>
        public static readonly Usage ACNewWindow = Instance.Create(0x0239, "AC New Window");
        /// <summary>
        ///     Consumer: AC Tile Horizontally Usage.
        /// </summary>
        public static readonly Usage ACTileHorizontally = Instance.Create(0x023a, "AC Tile Horizontally");
        /// <summary>
        ///     Consumer: AC Tile Vertically Usage.
        /// </summary>
        public static readonly Usage ACTileVertically = Instance.Create(0x023b, "AC Tile Vertically");
        /// <summary>
        ///     Consumer: AC Format Usage.
        /// </summary>
        public static readonly Usage ACFormat = Instance.Create(0x023c, "AC Format");
        /// <summary>
        ///     Consumer: AC Edit Usage.
        /// </summary>
        public static readonly Usage ACEdit = Instance.Create(0x023d, "AC Edit");
        /// <summary>
        ///     Consumer: AC Bold Usage.
        /// </summary>
        public static readonly Usage ACBold = Instance.Create(0x023e, "AC Bold");
        /// <summary>
        ///     Consumer: AC Italics Usage.
        /// </summary>
        public static readonly Usage ACItalics = Instance.Create(0x023f, "AC Italics");
        /// <summary>
        ///     Consumer: AC Underline Usage.
        /// </summary>
        public static readonly Usage ACUnderline = Instance.Create(0x0240, "AC Underline");
        /// <summary>
        ///     Consumer: AC Strikethrough Usage.
        /// </summary>
        public static readonly Usage ACStrikethrough = Instance.Create(0x0241, "AC Strikethrough");
        /// <summary>
        ///     Consumer: AC Subscript Usage.
        /// </summary>
        public static readonly Usage ACSubscript = Instance.Create(0x0242, "AC Subscript");
        /// <summary>
        ///     Consumer: AC Superscript Usage.
        /// </summary>
        public static readonly Usage ACSuperscript = Instance.Create(0x0243, "AC Superscript");
        /// <summary>
        ///     Consumer: AC All Caps Usage.
        /// </summary>
        public static readonly Usage ACAllCaps = Instance.Create(0x0244, "AC All Caps");
        /// <summary>
        ///     Consumer: AC Rotate Usage.
        /// </summary>
        public static readonly Usage ACRotate = Instance.Create(0x0245, "AC Rotate");
        /// <summary>
        ///     Consumer: AC Resize Usage.
        /// </summary>
        public static readonly Usage ACResize = Instance.Create(0x0246, "AC Resize");
        /// <summary>
        ///     Consumer: AC Flip Horizontal Usage.
        /// </summary>
        public static readonly Usage ACFlipHorizontal = Instance.Create(0x0247, "AC Flip Horizontal");
        /// <summary>
        ///     Consumer: AC Vertical Usage.
        /// </summary>
        public static readonly Usage ACVertical = Instance.Create(0x0248, "AC Vertical");
        /// <summary>
        ///     Consumer: AC Mirror Horizontal Usage.
        /// </summary>
        public static readonly Usage ACMirrorHorizontal = Instance.Create(0x0249, "AC Mirror Horizontal");
        /// <summary>
        ///     Consumer: AC Mirror Vertical Usage.
        /// </summary>
        public static readonly Usage ACMirrorVertical = Instance.Create(0x024a, "AC Mirror Vertical");
        /// <summary>
        ///     Consumer: AC Font Select Usage.
        /// </summary>
        public static readonly Usage ACFontSelect = Instance.Create(0x024b, "AC Font Select");
        /// <summary>
        ///     Consumer: AC Font Color Usage.
        /// </summary>
        public static readonly Usage ACFontColor = Instance.Create(0x024c, "AC Font Color");
        /// <summary>
        ///     Consumer: AC Font Size Usage.
        /// </summary>
        public static readonly Usage ACFontSize = Instance.Create(0x024d, "AC Font Size");
        /// <summary>
        ///     Consumer: AC Justify Left Usage.
        /// </summary>
        public static readonly Usage ACJustifyLeft = Instance.Create(0x024e, "AC Justify Left");
        /// <summary>
        ///     Consumer: AC Justify Center H Usage.
        /// </summary>
        public static readonly Usage ACJustifyCenterH = Instance.Create(0x024f, "AC Justify Center H");
        /// <summary>
        ///     Consumer: AC Justify Right Usage.
        /// </summary>
        public static readonly Usage ACJustifyRight = Instance.Create(0x0250, "AC Justify Right");
        /// <summary>
        ///     Consumer: AC Justify Block H Usage.
        /// </summary>
        public static readonly Usage ACJustifyBlockH = Instance.Create(0x0251, "AC Justify Block H");
        /// <summary>
        ///     Consumer: AC Justify Top Usage.
        /// </summary>
        public static readonly Usage ACJustifyTop = Instance.Create(0x0252, "AC Justify Top");
        /// <summary>
        ///     Consumer: AC Justify Center V Usage.
        /// </summary>
        public static readonly Usage ACJustifyCenterV = Instance.Create(0x0253, "AC Justify Center V");
        /// <summary>
        ///     Consumer: AC Justify Bottom Usage.
        /// </summary>
        public static readonly Usage ACJustifyBottom = Instance.Create(0x0254, "AC Justify Bottom");
        /// <summary>
        ///     Consumer: AC Justify Block V Usage.
        /// </summary>
        public static readonly Usage ACJustifyBlockV = Instance.Create(0x0255, "AC Justify Block V");
        /// <summary>
        ///     Consumer: AC Indent Decrease Usage.
        /// </summary>
        public static readonly Usage ACIndentDecrease = Instance.Create(0x0256, "AC Indent Decrease");
        /// <summary>
        ///     Consumer: AC Indent Increase Usage.
        /// </summary>
        public static readonly Usage ACIndentIncrease = Instance.Create(0x0257, "AC Indent Increase");
        /// <summary>
        ///     Consumer: AC Numbered List Usage.
        /// </summary>
        public static readonly Usage ACNumberedList = Instance.Create(0x0258, "AC Numbered List");
        /// <summary>
        ///     Consumer: AC Restart Numbering Usage.
        /// </summary>
        public static readonly Usage ACRestartNumbering = Instance.Create(0x0259, "AC Restart Numbering");
        /// <summary>
        ///     Consumer: AC Bulleted List Usage.
        /// </summary>
        public static readonly Usage ACBulletedList = Instance.Create(0x025a, "AC Bulleted List");
        /// <summary>
        ///     Consumer: AC Promote Usage.
        /// </summary>
        public static readonly Usage ACPromote = Instance.Create(0x025b, "AC Promote");
        /// <summary>
        ///     Consumer: AC Demote Usage.
        /// </summary>
        public static readonly Usage ACDemote = Instance.Create(0x025c, "AC Demote");
        /// <summary>
        ///     Consumer: AC Yes Usage.
        /// </summary>
        public static readonly Usage ACYes = Instance.Create(0x025d, "AC Yes");
        /// <summary>
        ///     Consumer: AC No Usage.
        /// </summary>
        public static readonly Usage ACNo = Instance.Create(0x025e, "AC No");
        /// <summary>
        ///     Consumer: AC Cancel Usage.
        /// </summary>
        public static readonly Usage ACCancel = Instance.Create(0x025f, "AC Cancel");
        /// <summary>
        ///     Consumer: AC Catalog Usage.
        /// </summary>
        public static readonly Usage ACCatalog = Instance.Create(0x0260, "AC Catalog");
        /// <summary>
        ///     Consumer: AC Buy/Checkout Usage.
        /// </summary>
        public static readonly Usage ACBuyCheckout = Instance.Create(0x0261, "AC Buy/Checkout");
        /// <summary>
        ///     Consumer: AC Add to Cart Usage.
        /// </summary>
        public static readonly Usage ACAddToCart = Instance.Create(0x0262, "AC Add to Cart");
        /// <summary>
        ///     Consumer: AC Expand Usage.
        /// </summary>
        public static readonly Usage ACExpand = Instance.Create(0x0263, "AC Expand");
        /// <summary>
        ///     Consumer: AC Expand All Usage.
        /// </summary>
        public static readonly Usage ACExpandAll = Instance.Create(0x0264, "AC Expand All");
        /// <summary>
        ///     Consumer: AC Collapse Usage.
        /// </summary>
        public static readonly Usage ACCollapse = Instance.Create(0x0265, "AC Collapse");
        /// <summary>
        ///     Consumer: AC Collapse All Usage.
        /// </summary>
        public static readonly Usage ACCollapseAll = Instance.Create(0x0266, "AC Collapse All");
        /// <summary>
        ///     Consumer: AC Print Preview Usage.
        /// </summary>
        public static readonly Usage ACPrintPreview = Instance.Create(0x0267, "AC Print Preview");
        /// <summary>
        ///     Consumer: AC Paste Special Usage.
        /// </summary>
        public static readonly Usage ACPasteSpecial = Instance.Create(0x0268, "AC Paste Special");
        /// <summary>
        ///     Consumer: AC Insert Mode Usage.
        /// </summary>
        public static readonly Usage ACInsertMode = Instance.Create(0x0269, "AC Insert Mode");
        /// <summary>
        ///     Consumer: AC Delete Usage.
        /// </summary>
        public static readonly Usage ACDelete = Instance.Create(0x026a, "AC Delete");
        /// <summary>
        ///     Consumer: AC Lock Usage.
        /// </summary>
        public static readonly Usage ACLock = Instance.Create(0x026b, "AC Lock");
        /// <summary>
        ///     Consumer: AC Unlock Usage.
        /// </summary>
        public static readonly Usage ACUnlock = Instance.Create(0x026c, "AC Unlock");
        /// <summary>
        ///     Consumer: AC Protect Usage.
        /// </summary>
        public static readonly Usage ACProtect = Instance.Create(0x026d, "AC Protect");
        /// <summary>
        ///     Consumer: AC Unprotect Usage.
        /// </summary>
        public static readonly Usage ACUnprotect = Instance.Create(0x026e, "AC Unprotect");
        /// <summary>
        ///     Consumer: AC Attach Comment Usage.
        /// </summary>
        public static readonly Usage ACAttachComment = Instance.Create(0x026f, "AC Attach Comment");
        /// <summary>
        ///     Consumer: AC Delete Comment Usage.
        /// </summary>
        public static readonly Usage ACDeleteComment = Instance.Create(0x0270, "AC Delete Comment");
        /// <summary>
        ///     Consumer: AC View Comment Usage.
        /// </summary>
        public static readonly Usage ACViewComment = Instance.Create(0x0271, "AC View Comment");
        /// <summary>
        ///     Consumer: AC Select Word Usage.
        /// </summary>
        public static readonly Usage ACSelectWord = Instance.Create(0x0272, "AC Select Word");
        /// <summary>
        ///     Consumer: AC Select Sentence Usage.
        /// </summary>
        public static readonly Usage ACSelectSentence = Instance.Create(0x0273, "AC Select Sentence");
        /// <summary>
        ///     Consumer: AC Select Paragraph Usage.
        /// </summary>
        public static readonly Usage ACSelectParagraph = Instance.Create(0x0274, "AC Select Paragraph");
        /// <summary>
        ///     Consumer: AC Select Column Usage.
        /// </summary>
        public static readonly Usage ACSelectColumn = Instance.Create(0x0275, "AC Select Column");
        /// <summary>
        ///     Consumer: AC Select Row Usage.
        /// </summary>
        public static readonly Usage ACSelectRow = Instance.Create(0x0276, "AC Select Row");
        /// <summary>
        ///     Consumer: AC Select Table Usage.
        /// </summary>
        public static readonly Usage ACSelectTable = Instance.Create(0x0277, "AC Select Table");
        /// <summary>
        ///     Consumer: AC Select Object Usage.
        /// </summary>
        public static readonly Usage ACSelectObject = Instance.Create(0x0278, "AC Select Object");
        /// <summary>
        ///     Consumer: AC Redo/Repeat Usage.
        /// </summary>
        public static readonly Usage ACRedoRepeat = Instance.Create(0x0279, "AC Redo/Repeat");
        /// <summary>
        ///     Consumer: AC Sort Usage.
        /// </summary>
        public static readonly Usage ACSort = Instance.Create(0x027a, "AC Sort");
        /// <summary>
        ///     Consumer: AC Sort Ascending Usage.
        /// </summary>
        public static readonly Usage ACSortAscending = Instance.Create(0x027b, "AC Sort Ascending");
        /// <summary>
        ///     Consumer: AC Sort Descending Usage.
        /// </summary>
        public static readonly Usage ACSortDescending = Instance.Create(0x027c, "AC Sort Descending");
        /// <summary>
        ///     Consumer: AC Filter Usage.
        /// </summary>
        public static readonly Usage ACFilter = Instance.Create(0x027d, "AC Filter");
        /// <summary>
        ///     Consumer: AC Set Clock Usage.
        /// </summary>
        public static readonly Usage ACSetClock = Instance.Create(0x027e, "AC Set Clock");
        /// <summary>
        ///     Consumer: AC View Clock Usage.
        /// </summary>
        public static readonly Usage ACViewClock = Instance.Create(0x027f, "AC View Clock");
        /// <summary>
        ///     Consumer: AC Select Time Zone Usage.
        /// </summary>
        public static readonly Usage ACSelectTimeZone = Instance.Create(0x0280, "AC Select Time Zone");
        /// <summary>
        ///     Consumer: AC Edit Time Zones Usage.
        /// </summary>
        public static readonly Usage ACEditTimeZones = Instance.Create(0x0281, "AC Edit Time Zones");
        /// <summary>
        ///     Consumer: AC Set Alarm Usage.
        /// </summary>
        public static readonly Usage ACSetAlarm = Instance.Create(0x0282, "AC Set Alarm");
        /// <summary>
        ///     Consumer: AC Clear Alarm Usage.
        /// </summary>
        public static readonly Usage ACClearAlarm = Instance.Create(0x0283, "AC Clear Alarm");
        /// <summary>
        ///     Consumer: AC Snooze Alarm Usage.
        /// </summary>
        public static readonly Usage ACSnoozeAlarm = Instance.Create(0x0284, "AC Snooze Alarm");
        /// <summary>
        ///     Consumer: AC Reset Alarm Usage.
        /// </summary>
        public static readonly Usage ACResetAlarm = Instance.Create(0x0285, "AC Reset Alarm");
        /// <summary>
        ///     Consumer: AC Synchronize Usage.
        /// </summary>
        public static readonly Usage ACSynchronize = Instance.Create(0x0286, "AC Synchronize");
        /// <summary>
        ///     Consumer: AC Send/Receive Usage.
        /// </summary>
        public static readonly Usage ACSendReceive = Instance.Create(0x0287, "AC Send/Receive");
        /// <summary>
        ///     Consumer: AC Send To Usage.
        /// </summary>
        public static readonly Usage ACSendTo = Instance.Create(0x0288, "AC Send To");
        /// <summary>
        ///     Consumer: AC Reply Usage.
        /// </summary>
        public static readonly Usage ACReply = Instance.Create(0x0289, "AC Reply");
        /// <summary>
        ///     Consumer: AC Reply All Usage.
        /// </summary>
        public static readonly Usage ACReplyAll = Instance.Create(0x028a, "AC Reply All");
        /// <summary>
        ///     Consumer: AC Forward Msg Usage.
        /// </summary>
        public static readonly Usage ACForwardMsg = Instance.Create(0x028b, "AC Forward Msg");
        /// <summary>
        ///     Consumer: AC Send Usage.
        /// </summary>
        public static readonly Usage ACSend = Instance.Create(0x028c, "AC Send");
        /// <summary>
        ///     Consumer: AC Attach File Usage.
        /// </summary>
        public static readonly Usage ACAttachFile = Instance.Create(0x028d, "AC Attach File");
        /// <summary>
        ///     Consumer: AC Upload Usage.
        /// </summary>
        public static readonly Usage ACUpload = Instance.Create(0x028e, "AC Upload");
        /// <summary>
        ///     Consumer: AC Download (Save Target As) Usage.
        /// </summary>
        public static readonly Usage ACDownloadSaveTargetAs = Instance.Create(0x028f, "AC Download (Save Target As)");
        /// <summary>
        ///     Consumer: AC Set Borders Usage.
        /// </summary>
        public static readonly Usage ACSetBorders = Instance.Create(0x0290, "AC Set Borders");
        /// <summary>
        ///     Consumer: AC Insert Row Usage.
        /// </summary>
        public static readonly Usage ACInsertRow = Instance.Create(0x0291, "AC Insert Row");
        /// <summary>
        ///     Consumer: AC Insert Column Usage.
        /// </summary>
        public static readonly Usage ACInsertColumn = Instance.Create(0x0292, "AC Insert Column");
        /// <summary>
        ///     Consumer: AC Insert File Usage.
        /// </summary>
        public static readonly Usage ACInsertFile = Instance.Create(0x0293, "AC Insert File");
        /// <summary>
        ///     Consumer: AC Insert Picture Usage.
        /// </summary>
        public static readonly Usage ACInsertPicture = Instance.Create(0x0294, "AC Insert Picture");
        /// <summary>
        ///     Consumer: AC Insert Object Usage.
        /// </summary>
        public static readonly Usage ACInsertObject = Instance.Create(0x0295, "AC Insert Object");
        /// <summary>
        ///     Consumer: AC Insert Symbol Usage.
        /// </summary>
        public static readonly Usage ACInsertSymbol = Instance.Create(0x0296, "AC Insert Symbol");
        /// <summary>
        ///     Consumer: AC Save and Close Usage.
        /// </summary>
        public static readonly Usage ACSaveAndClose = Instance.Create(0x0297, "AC Save and Close");
        /// <summary>
        ///     Consumer: AC Rename Usage.
        /// </summary>
        public static readonly Usage ACRename = Instance.Create(0x0298, "AC Rename");
        /// <summary>
        ///     Consumer: AC Merge Usage.
        /// </summary>
        public static readonly Usage ACMerge = Instance.Create(0x0299, "AC Merge");
        /// <summary>
        ///     Consumer: AC Split Usage.
        /// </summary>
        public static readonly Usage ACSplit = Instance.Create(0x029a, "AC Split");
        /// <summary>
        ///     Consumer: AC Distribute Horizontally Usage.
        /// </summary>
        public static readonly Usage ACDistributeHorizontally = Instance.Create(0x029b, "AC Distribute Horizontally");
        /// <summary>
        ///     Consumer: AC Distribute Vertically Usage.
        /// </summary>
        public static readonly Usage ACDistributeVertically = Instance.Create(0x029c, "AC Distribute Vertically");
        /// <summary>
        ///     Consumer: AC Next Keyboard Layout Select Usage.
        /// </summary>
        public static readonly Usage ACNextKeyboardLayoutSelect = Instance.Create(0x029d, "AC Next Keyboard Layout Select");
        /// <summary>
        ///     Consumer: AC Navigation Guidance Usage.
        /// </summary>
        public static readonly Usage ACNavigationGuidance = Instance.Create(0x029e, "AC Navigation Guidance");
        /// <summary>
        ///     Consumer: AC Desktop Show All Windows Usage.
        /// </summary>
        public static readonly Usage ACDesktopShowAllWindows = Instance.Create(0x029f, "AC Desktop Show All Windows");
        /// <summary>
        ///     Consumer: AC Desktop Show All Applications Usage.
        /// </summary>
        public static readonly Usage ACDesktopShowAllApplications = Instance.Create(0x02a0, "AC Desktop Show All Applications");

        /// <summary>
        ///     Consumer: Extended Keyboard Attributes Collection Usage.
        /// </summary>
        public static readonly Usage ExtendedKeyboardAttributesCollection = Instance.Create(0x02c0, "Extended Keyboard Attributes Collection");
        /// <summary>
        ///     Consumer: Keyboard Form Factor Usage.
        /// </summary>
        public static readonly Usage KeyboardFormFactor = Instance.Create(0x02c1, "Keyboard Form Factor");
        /// <summary>
        ///     Consumer: Keyboard Key Type Usage.
        /// </summary>
        public static readonly Usage KeyboardKeyType = Instance.Create(0x02c2, "Keyboard Key Type");
        /// <summary>
        ///     Consumer: Keyboard Physical Layout Usage.
        /// </summary>
        public static readonly Usage KeyboardPhysicalLayout = Instance.Create(0x02c3, "Keyboard Physical Layout");
        /// <summary>
        ///     Consumer: Vendor-Specific Keyboard Physical Layout Usage.
        /// </summary>
        public static readonly Usage VendorSpecificKeyboardPhysicalLayout = Instance.Create(0x02c4, "Vendor-Specific Keyboard Physical Layout");
        /// <summary>
        ///     Consumer: Keyboard IETF Language Tag Index Usage.
        /// </summary>
        public static readonly Usage KeyboardIETFLanguageTagIndex = Instance.Create(0x02c5, "Keyboard IETF Language Tag Index");
        /// <summary>
        ///     Consumer: Implemented Keyboard Input Assist Controls Usage.
        /// </summary>
        public static readonly Usage ImplementedKeyboardInputAssistControls = Instance.Create(0x02c6, "Implemented Keyboard Input Assist Controls");
        /// <summary>
        ///     Consumer: Keyboard Input Assist Previous Usage.
        /// </summary>
        public static readonly Usage KeyboardInputAssistPrevious = Instance.Create(0x02c7, "Keyboard Input Assist Previous");
        /// <summary>
        ///     Consumer: Keyboard Input Assist Next Usage.
        /// </summary>
        public static readonly Usage KeyboardInputAssistNext = Instance.Create(0x02c8, "Keyboard Input Assist Next");
        /// <summary>
        ///     Consumer: Keyboard Input Assist Previous Group Usage.
        /// </summary>
        public static readonly Usage KeyboardInputAssistPreviousGroup = Instance.Create(0x02c9, "Keyboard Input Assist Previous Group");
        /// <summary>
        ///     Consumer: Keyboard Input Assist Next Group Usage.
        /// </summary>
        public static readonly Usage KeyboardInputAssistNextGroup = Instance.Create(0x02ca, "Keyboard Input Assist Next Group");
        /// <summary>
        ///     Consumer: Keyboard Input Assist Accept Usage.
        /// </summary>
        public static readonly Usage KeyboardInputAssistAccept = Instance.Create(0x02cb, "Keyboard Input Assist Accept");
        /// <summary>
        ///     Consumer: Keyboard Input Assist Cancel Usage.
        /// </summary>
        public static readonly Usage KeyboardInputAssistCancel = Instance.Create(0x02cc, "Keyboard Input Assist Cancel");

        /// <summary>
        ///     Consumer: Undefined Usage.
        /// </summary>
        public static readonly Usage Undefined = Instance.Create(0x0000, "Undefined");

        /// <inheritdoc />
        private ConsumerPage(ushort id, string name) : base(id, name, true)
        {
        }
    }

    /// <summary>
    ///     Class defining the Digitizer usage page.
    /// </summary>
    public sealed partial class DigitizerPage : UsagePage
    {
        /// <summary>
        ///     The singleton instance of DigitizerPage.
        /// </summary>
        public static readonly DigitizerPage Instance = new DigitizerPage(0x000d, "Digitizer");

        /// <summary>
        ///     Digitizer: Digitizer Usage.
        /// </summary>
        public static readonly Usage Digitizer = Instance.Create(0x0001, "Digitizer");
        /// <summary>
        ///     Digitizer: Pen Usage.
        /// </summary>
        public static readonly Usage Pen = Instance.Create(0x0002, "Pen");
        /// <summary>
        ///     Digitizer: Light Pen Usage.
        /// </summary>
        public static readonly Usage LightPen = Instance.Create(0x0003, "Light Pen");
        /// <summary>
        ///     Digitizer: Touch Screen Usage.
        /// </summary>
        public static readonly Usage TouchScreen = Instance.Create(0x0004, "Touch Screen");
        /// <summary>
        ///     Digitizer: Touch Pad Usage.
        /// </summary>
        public static readonly Usage TouchPad = Instance.Create(0x0005, "Touch Pad");
        /// <summary>
        ///     Digitizer: White Board Usage.
        /// </summary>
        public static readonly Usage WhiteBoard = Instance.Create(0x0006, "White Board");
        /// <summary>
        ///     Digitizer: Coordinate Measuring Machine Usage.
        /// </summary>
        public static readonly Usage CoordinateMeasuringMachine = Instance.Create(0x0007, "Coordinate Measuring Machine");
        /// <summary>
        ///     Digitizer: 3D Digitizer Usage.
        /// </summary>
        public static readonly Usage DDigitizer = Instance.Create(0x0008, "3D Digitizer");
        /// <summary>
        ///     Digitizer: Stereo Plotter Usage.
        /// </summary>
        public static readonly Usage StereoPlotter = Instance.Create(0x0009, "Stereo Plotter");
        /// <summary>
        ///     Digitizer: Articulated Arm Usage.
        /// </summary>
        public static readonly Usage ArticulatedArm = Instance.Create(0x000a, "Articulated Arm");
        /// <summary>
        ///     Digitizer: Armature Usage.
        /// </summary>
        public static readonly Usage Armature = Instance.Create(0x000b, "Armature");
        /// <summary>
        ///     Digitizer: Multiple Point Digitizer Usage.
        /// </summary>
        public static readonly Usage MultiplePointDigitizer = Instance.Create(0x000c, "Multiple Point Digitizer");
        /// <summary>
        ///     Digitizer: Free Space Wand Usage.
        /// </summary>
        public static readonly Usage FreeSpaceWand = Instance.Create(0x000d, "Free Space Wand");
        /// <summary>
        ///     Digitizer: Device Configuration Usage.
        /// </summary>
        public static readonly Usage DeviceConfiguration = Instance.Create(0x000e, "Device Configuration");
        /// <summary>
        ///     Digitizer: Capacitive Heat Map Digitizer Usage.
        /// </summary>
        public static readonly Usage CapacitiveHeatMapDigitizer = Instance.Create(0x000f, "Capacitive Heat Map Digitizer");

        /// <summary>
        ///     Digitizer: Stylus Usage.
        /// </summary>
        public static readonly Usage Stylus = Instance.Create(0x0020, "Stylus");
        /// <summary>
        ///     Digitizer: Puck Usage.
        /// </summary>
        public static readonly Usage Puck = Instance.Create(0x0021, "Puck");
        /// <summary>
        ///     Digitizer: Finger Usage.
        /// </summary>
        public static readonly Usage Finger = Instance.Create(0x0022, "Finger");
        /// <summary>
        ///     Digitizer: Device Settings Usage.
        /// </summary>
        public static readonly Usage DeviceSettings = Instance.Create(0x0023, "Device Settings");
        /// <summary>
        ///     Digitizer: Character Gesture Usage.
        /// </summary>
        public static readonly Usage CharacterGesture = Instance.Create(0x0024, "Character Gesture");

        /// <summary>
        ///     Digitizer: Tip Pressure Usage.
        /// </summary>
        public static readonly Usage TipPressure = Instance.Create(0x0030, "Tip Pressure");
        /// <summary>
        ///     Digitizer: Barrel Pressure Usage.
        /// </summary>
        public static readonly Usage BarrelPressure = Instance.Create(0x0031, "Barrel Pressure");
        /// <summary>
        ///     Digitizer: In Range Usage.
        /// </summary>
        public static readonly Usage InRange = Instance.Create(0x0032, "In Range");
        /// <summary>
        ///     Digitizer: Touch Usage.
        /// </summary>
        public static readonly Usage Touch = Instance.Create(0x0033, "Touch");
        /// <summary>
        ///     Digitizer: Untouch Usage.
        /// </summary>
        public static readonly Usage Untouch = Instance.Create(0x0034, "Untouch");
        /// <summary>
        ///     Digitizer: Tap Usage.
        /// </summary>
        public static readonly Usage Tap = Instance.Create(0x0035, "Tap");
        /// <summary>
        ///     Digitizer: Quality Usage.
        /// </summary>
        public static readonly Usage Quality = Instance.Create(0x0036, "Quality");
        /// <summary>
        ///     Digitizer: Data Valid Usage.
        /// </summary>
        public static readonly Usage DataValid = Instance.Create(0x0037, "Data Valid");
        /// <summary>
        ///     Digitizer: Transducer Index Usage.
        /// </summary>
        public static readonly Usage TransducerIndex = Instance.Create(0x0038, "Transducer Index");
        /// <summary>
        ///     Digitizer: Tablet Function Keys Usage.
        /// </summary>
        public static readonly Usage TabletFunctionKeys = Instance.Create(0x0039, "Tablet Function Keys");
        /// <summary>
        ///     Digitizer: Program Change Keys Usage.
        /// </summary>
        public static readonly Usage ProgramChangeKeys = Instance.Create(0x003a, "Program Change Keys");
        /// <summary>
        ///     Digitizer: Battery Strength Usage.
        /// </summary>
        public static readonly Usage BatteryStrength = Instance.Create(0x003b, "Battery Strength");
        /// <summary>
        ///     Digitizer: Invert Usage.
        /// </summary>
        public static readonly Usage Invert = Instance.Create(0x003c, "Invert");
        /// <summary>
        ///     Digitizer: X Tilt Usage.
        /// </summary>
        public static readonly Usage XTilt = Instance.Create(0x003d, "X Tilt");
        /// <summary>
        ///     Digitizer: Y Tilt Usage.
        /// </summary>
        public static readonly Usage YTilt = Instance.Create(0x003e, "Y Tilt");
        /// <summary>
        ///     Digitizer: Azimuth Usage.
        /// </summary>
        public static readonly Usage Azimuth = Instance.Create(0x003f, "Azimuth");
        /// <summary>
        ///     Digitizer: Altitude Usage.
        /// </summary>
        public static readonly Usage Altitude = Instance.Create(0x0040, "Altitude");
        /// <summary>
        ///     Digitizer: Twist Usage.
        /// </summary>
        public static readonly Usage Twist = Instance.Create(0x0041, "Twist");
        /// <summary>
        ///     Digitizer: Tip Switch Usage.
        /// </summary>
        public static readonly Usage TipSwitch = Instance.Create(0x0042, "Tip Switch");
        /// <summary>
        ///     Digitizer: Secondary Tip Switch Usage.
        /// </summary>
        public static readonly Usage SecondaryTipSwitch = Instance.Create(0x0043, "Secondary Tip Switch");
        /// <summary>
        ///     Digitizer: Barrel Switch Usage.
        /// </summary>
        public static readonly Usage BarrelSwitch = Instance.Create(0x0044, "Barrel Switch");
        /// <summary>
        ///     Digitizer: Eraser Usage.
        /// </summary>
        public static readonly Usage Eraser = Instance.Create(0x0045, "Eraser");
        /// <summary>
        ///     Digitizer: Tablet Pick Usage.
        /// </summary>
        public static readonly Usage TabletPick = Instance.Create(0x0046, "Tablet Pick");
        /// <summary>
        ///     Digitizer: Touch Valid Usage.
        /// </summary>
        public static readonly Usage TouchValid = Instance.Create(0x0047, "Touch Valid");
        /// <summary>
        ///     Digitizer: Width Usage.
        /// </summary>
        public static readonly Usage Width = Instance.Create(0x0048, "Width");
        /// <summary>
        ///     Digitizer: Height Usage.
        /// </summary>
        public static readonly Usage Height = Instance.Create(0x0049, "Height");

        /// <summary>
        ///     Digitizer: Contact Identifier Usage.
        /// </summary>
        public static readonly Usage ContactIdentifier = Instance.Create(0x0051, "Contact Identifier");
        /// <summary>
        ///     Digitizer: Device Mode Usage.
        /// </summary>
        public static readonly Usage DeviceMode = Instance.Create(0x0052, "Device Mode");
        /// <summary>
        ///     Digitizer: Device Identifier Usage.
        /// </summary>
        public static readonly Usage DeviceIdentifier = Instance.Create(0x0053, "Device Identifier");
        /// <summary>
        ///     Digitizer: Contact Count Usage.
        /// </summary>
        public static readonly Usage ContactCount = Instance.Create(0x0054, "Contact Count");
        /// <summary>
        ///     Digitizer: Contact Count Maximum Usage.
        /// </summary>
        public static readonly Usage ContactCountMaximum = Instance.Create(0x0055, "Contact Count Maximum");
        /// <summary>
        ///     Digitizer: Scan Time Usage.
        /// </summary>
        public static readonly Usage ScanTime = Instance.Create(0x0056, "Scan Time");
        /// <summary>
        ///     Digitizer: Surface Width Usage.
        /// </summary>
        public static readonly Usage SurfaceWidth = Instance.Create(0x0057, "Surface Width");
        /// <summary>
        ///     Digitizer: Button Switch Usage.
        /// </summary>
        public static readonly Usage ButtonSwitch = Instance.Create(0x0058, "Button Switch");
        /// <summary>
        ///     Digitizer: Pad Type Usage.
        /// </summary>
        public static readonly Usage PadType = Instance.Create(0x0059, "Pad Type");
        /// <summary>
        ///     Digitizer: Secondary Barrel Switch Usage.
        /// </summary>
        public static readonly Usage SecondaryBarrelSwitch = Instance.Create(0x005a, "Secondary Barrel Switch");
        /// <summary>
        ///     Digitizer: Transducer Serial Number Usage.
        /// </summary>
        public static readonly Usage TransducerSerialNumber = Instance.Create(0x005b, "Transducer Serial Number");
        /// <summary>
        ///     Digitizer: Preferred Color Usage.
        /// </summary>
        public static readonly Usage PreferredColor = Instance.Create(0x005c, "Preferred Color");

        /// <summary>
        ///     Digitizer: Latency Mode Usage.
        /// </summary>
        public static readonly Usage LatencyMode = Instance.Create(0x0060, "Latency Mode");
        /// <summary>
        ///     Digitizer: Gesture Character Quality Usage.
        /// </summary>
        public static readonly Usage GestureCharacterQuality = Instance.Create(0x0061, "Gesture Character Quality");
        /// <summary>
        ///     Digitizer: Character Gesture Data Length Usage.
        /// </summary>
        public static readonly Usage CharacterGestureDataLength = Instance.Create(0x0062, "Character Gesture Data Length");
        /// <summary>
        ///     Digitizer: Character Gesture Data Usage.
        /// </summary>
        public static readonly Usage CharacterGestureData = Instance.Create(0x0063, "Character Gesture Data");
        /// <summary>
        ///     Digitizer: Gesture Character Encoding Usage.
        /// </summary>
        public static readonly Usage GestureCharacterEncoding = Instance.Create(0x0064, "Gesture Character Encoding");
        /// <summary>
        ///     Digitizer: UTF8 Character Gesture Encoding Usage.
        /// </summary>
        public static readonly Usage UTF8CharacterGestureEncoding = Instance.Create(0x0065, "UTF8 Character Gesture Encoding");
        /// <summary>
        ///     Digitizer: UTF16 Little Endian Character Gesture Encoding Usage.
        /// </summary>
        public static readonly Usage UTF16LittleEndianCharacterGestureEncoding = Instance.Create(0x0066, "UTF16 Little Endian Character Gesture Encoding");
        /// <summary>
        ///     Digitizer: UTF16 Big Endian Character Gesture Encoding Usage.
        /// </summary>
        public static readonly Usage UTF16BigEndianCharacterGestureEncoding = Instance.Create(0x0067, "UTF16 Big Endian Character Gesture Encoding");
        /// <summary>
        ///     Digitizer: UTF32 Little Endian Character Gesture Encoding Usage.
        /// </summary>
        public static readonly Usage UTF32LittleEndianCharacterGestureEncoding = Instance.Create(0x0068, "UTF32 Little Endian Character Gesture Encoding");
        /// <summary>
        ///     Digitizer: UTF32 Big Endian Character Gesture Encoding Usage.
        /// </summary>
        public static readonly Usage UTF32BigEndianCharacterGestureEncoding = Instance.Create(0x0069, "UTF32 Big Endian Character Gesture Encoding");
        /// <summary>
        ///     Digitizer: Gesture Character Enable Usage.
        /// </summary>
        public static readonly Usage GestureCharacterEnable = Instance.Create(0x006a, "Gesture Character Enable");
        /// <summary>
        ///     Digitizer: Capacitive Heat Map Protocol Vendor ID Usage.
        /// </summary>
        public static readonly Usage CapacitiveHeatMapProtocolVendorID = Instance.Create(0x006b, "Capacitive Heat Map Protocol Vendor ID");
        /// <summary>
        ///     Digitizer: Capacitive Heat Map Protocol Version Usage.
        /// </summary>
        public static readonly Usage CapacitiveHeatMapProtocolVersion = Instance.Create(0x006c, "Capacitive Heat Map Protocol Version");
        /// <summary>
        ///     Digitizer: Capacitive Heat Map Frame Data Usage.
        /// </summary>
        public static readonly Usage CapacitiveHeatMapFrameData = Instance.Create(0x006d, "Capacitive Heat Map Frame Data");

        /// <summary>
        ///     Digitizer: Transducer Software Info Usage.
        /// </summary>
        public static readonly Usage TransducerSoftwareInfo = Instance.Create(0x0090, "Transducer Software Info");
        /// <summary>
        ///     Digitizer: Transducer Vendor ID Usage.
        /// </summary>
        public static readonly Usage TransducerVendorID = Instance.Create(0x0091, "Transducer Vendor ID");
        /// <summary>
        ///     Digitizer: Transducer Product ID Usage.
        /// </summary>
        public static readonly Usage TransducerProductID = Instance.Create(0x0092, "Transducer Product ID");
        /// <summary>
        ///     Digitizer: Device Supported Protocols Usage.
        /// </summary>
        public static readonly Usage DeviceSupportedProtocols = Instance.Create(0x0093, "Device Supported Protocols");
        /// <summary>
        ///     Digitizer: Transducer Supported Protocols Usage.
        /// </summary>
        public static readonly Usage TransducerSupportedProtocols = Instance.Create(0x0094, "Transducer Supported Protocols");
        /// <summary>
        ///     Digitizer: No Protocol Usage.
        /// </summary>
        public static readonly Usage NoProtocol = Instance.Create(0x0095, "No Protocol");
        /// <summary>
        ///     Digitizer: Wacom AES Protocol Usage.
        /// </summary>
        public static readonly Usage WacomAESProtocol = Instance.Create(0x0096, "Wacom AES Protocol");
        /// <summary>
        ///     Digitizer: USI Protocol Usage.
        /// </summary>
        public static readonly Usage USIProtocol = Instance.Create(0x0097, "USI Protocol");
        /// <summary>
        ///     Digitizer: Microsoft Pen Protocol Usage.
        /// </summary>
        public static readonly Usage MicrosoftPenProtocol = Instance.Create(0x0098, "Microsoft Pen Protocol");

        /// <summary>
        ///     Digitizer: Supported Report Rates Usage.
        /// </summary>
        public static readonly Usage SupportedReportRates = Instance.Create(0x00a0, "Supported Report Rates");
        /// <summary>
        ///     Digitizer: Report Rate Usage.
        /// </summary>
        public static readonly Usage ReportRate = Instance.Create(0x00a1, "Report Rate");
        /// <summary>
        ///     Digitizer: Transducer Connected Usage.
        /// </summary>
        public static readonly Usage TransducerConnected = Instance.Create(0x00a2, "Transducer Connected");
        /// <summary>
        ///     Digitizer: Switch Disabled Usage.
        /// </summary>
        public static readonly Usage SwitchDisabled = Instance.Create(0x00a3, "Switch Disabled");
        /// <summary>
        ///     Digitizer: Switch Unimplemented Usage.
        /// </summary>
        public static readonly Usage SwitchUnimplemented = Instance.Create(0x00a4, "Switch Unimplemented");
        /// <summary>
        ///     Digitizer: Transducer Switches Usage.
        /// </summary>
        public static readonly Usage TransducerSwitches = Instance.Create(0x00a5, "Transducer Switches");

        /// <summary>
        ///     Digitizer: Undefined Usage.
        /// </summary>
        public static readonly Usage Undefined = Instance.Create(0x0000, "Undefined");

        /// <inheritdoc />
        private DigitizerPage(ushort id, string name) : base(id, name, true)
        {
        }
    }

    /// <summary>
    ///     Class defining the Haptics usage page.
    /// </summary>
    public sealed partial class HapticsPage : UsagePage
    {
        /// <summary>
        ///     The singleton instance of HapticsPage.
        /// </summary>
        public static readonly HapticsPage Instance = new HapticsPage(0x000e, "Haptics");

        /// <summary>
        ///     Haptics: Simple Haptic Controller Usage.
        /// </summary>
        public static readonly Usage SimpleHapticController = Instance.Create(0x0001, "Simple Haptic Controller");

        /// <summary>
        ///     Haptics: Waveform List Usage.
        /// </summary>
        public static readonly Usage WaveformList = Instance.Create(0x0010, "Waveform List");
        /// <summary>
        ///     Haptics: Duration List Usage.
        /// </summary>
        public static readonly Usage DurationList = Instance.Create(0x0011, "Duration List");

        /// <summary>
        ///     Haptics: Auto Trigger Usage.
        /// </summary>
        public static readonly Usage AutoTrigger = Instance.Create(0x0020, "Auto Trigger");
        /// <summary>
        ///     Haptics: Manual Trigger Usage.
        /// </summary>
        public static readonly Usage ManualTrigger = Instance.Create(0x0021, "Manual Trigger");
        /// <summary>
        ///     Haptics: Auto Trigger Associated Control Usage.
        /// </summary>
        public static readonly Usage AutoTriggerAssociatedControl = Instance.Create(0x0022, "Auto Trigger Associated Control");
        /// <summary>
        ///     Haptics: Intensity Usage.
        /// </summary>
        public static readonly Usage Intensity = Instance.Create(0x0023, "Intensity");
        /// <summary>
        ///     Haptics: Repeat Count Usage.
        /// </summary>
        public static readonly Usage RepeatCount = Instance.Create(0x0024, "Repeat Count");
        /// <summary>
        ///     Haptics: Retrigger Period Usage.
        /// </summary>
        public static readonly Usage RetriggerPeriod = Instance.Create(0x0025, "Retrigger Period");
        /// <summary>
        ///     Haptics: Waveform Vendor Page Usage.
        /// </summary>
        public static readonly Usage WaveformVendorPage = Instance.Create(0x0026, "Waveform Vendor Page");
        /// <summary>
        ///     Haptics: Waveform Vendor ID Usage.
        /// </summary>
        public static readonly Usage WaveformVendorID = Instance.Create(0x0027, "Waveform Vendor ID");
        /// <summary>
        ///     Haptics: Waveform Cutoff Time Usage.
        /// </summary>
        public static readonly Usage WaveformCutoffTime = Instance.Create(0x0028, "Waveform Cutoff Time");

        /// <summary>
        ///     Haptics: WAVEFORM_NONE Usage.
        /// </summary>
        public static readonly Usage WAVEFORM_NONE = Instance.Create(0x1001, "WAVEFORM_NONE");
        /// <summary>
        ///     Haptics: WAVEFORM_STOP Usage.
        /// </summary>
        public static readonly Usage WAVEFORM_STOP = Instance.Create(0x1002, "WAVEFORM_STOP");
        /// <summary>
        ///     Haptics: WAVEFORM_CLICK Usage.
        /// </summary>
        public static readonly Usage WAVEFORM_CLICK = Instance.Create(0x1003, "WAVEFORM_CLICK");
        /// <summary>
        ///     Haptics: WAVEFORM_BUZZ_CONTINUOUS Usage.
        /// </summary>
        public static readonly Usage WAVEFORM_BUZZ_CONTINUOUS = Instance.Create(0x1004, "WAVEFORM_BUZZ_CONTINUOUS");
        /// <summary>
        ///     Haptics: WAVEFORM_RUMBLE_CONTINUOUS Usage.
        /// </summary>
        public static readonly Usage WAVEFORM_RUMBLE_CONTINUOUS = Instance.Create(0x1005, "WAVEFORM_RUMBLE_CONTINUOUS");
        /// <summary>
        ///     Haptics: WAVEFORM_PRESS Usage.
        /// </summary>
        public static readonly Usage WAVEFORM_PRESS = Instance.Create(0x1006, "WAVEFORM_PRESS");
        /// <summary>
        ///     Haptics: WAVEFORM_RELEASE Usage.
        /// </summary>
        public static readonly Usage WAVEFORM_RELEASE = Instance.Create(0x1007, "WAVEFORM_RELEASE");

        /// <summary>
        ///     Haptics: Undefined Usage.
        /// </summary>
        public static readonly Usage Undefined = Instance.Create(0x0000, "Undefined");

        /// <inheritdoc />
        private HapticsPage(ushort id, string name) : base(id, name, true)
        {
        }
    }

    /// <summary>
    ///     Class defining the Physical Interface Device usage page.
    /// </summary>
    public sealed partial class PhysicalInterfaceDevicePage : UsagePage
    {
        /// <summary>
        ///     The singleton instance of PhysicalInterfaceDevicePage.
        /// </summary>
        public static readonly PhysicalInterfaceDevicePage Instance = new PhysicalInterfaceDevicePage(0x000f, "Physical Interface Device");

        /// <summary>
        ///     PhysicalInterfaceDevice: Physical Interface Device Usage.
        /// </summary>
        public static readonly Usage PhysicalInterfaceDevice = Instance.Create(0x0001, "Physical Interface Device");

        /// <summary>
        ///     PhysicalInterfaceDevice: Normal Usage.
        /// </summary>
        public static readonly Usage Normal = Instance.Create(0x0020, "Normal");
        /// <summary>
        ///     PhysicalInterfaceDevice: Set Effect Report Usage.
        /// </summary>
        public static readonly Usage SetEffectReport = Instance.Create(0x0021, "Set Effect Report");
        /// <summary>
        ///     PhysicalInterfaceDevice: Effect Block Index Usage.
        /// </summary>
        public static readonly Usage EffectBlockIndex = Instance.Create(0x0022, "Effect Block Index");
        /// <summary>
        ///     PhysicalInterfaceDevice: Parameter Block Offset Usage.
        /// </summary>
        public static readonly Usage ParameterBlockOffset = Instance.Create(0x0023, "Parameter Block Offset");
        /// <summary>
        ///     PhysicalInterfaceDevice: ROM Flag Usage.
        /// </summary>
        public static readonly Usage ROMFlag = Instance.Create(0x0024, "ROM Flag");
        /// <summary>
        ///     PhysicalInterfaceDevice: Effect Type Usage.
        /// </summary>
        public static readonly Usage EffectType = Instance.Create(0x0025, "Effect Type");
        /// <summary>
        ///     PhysicalInterfaceDevice: ET Constant Force Usage.
        /// </summary>
        public static readonly Usage ETConstantForce = Instance.Create(0x0026, "ET Constant Force");
        /// <summary>
        ///     PhysicalInterfaceDevice: ET Ramp Usage.
        /// </summary>
        public static readonly Usage ETRamp = Instance.Create(0x0027, "ET Ramp");
        /// <summary>
        ///     PhysicalInterfaceDevice: ET Custom Force Data Usage.
        /// </summary>
        public static readonly Usage ETCustomForceData = Instance.Create(0x0028, "ET Custom Force Data");

        /// <summary>
        ///     PhysicalInterfaceDevice: ET Square Usage.
        /// </summary>
        public static readonly Usage ETSquare = Instance.Create(0x0030, "ET Square");
        /// <summary>
        ///     PhysicalInterfaceDevice: ET Sine Usage.
        /// </summary>
        public static readonly Usage ETSine = Instance.Create(0x0031, "ET Sine");
        /// <summary>
        ///     PhysicalInterfaceDevice: ET Triangle Usage.
        /// </summary>
        public static readonly Usage ETTriangle = Instance.Create(0x0032, "ET Triangle");
        /// <summary>
        ///     PhysicalInterfaceDevice: ET Sawtooth Up Usage.
        /// </summary>
        public static readonly Usage ETSawtoothUp = Instance.Create(0x0033, "ET Sawtooth Up");
        /// <summary>
        ///     PhysicalInterfaceDevice: ET Sawtooth Down Usage.
        /// </summary>
        public static readonly Usage ETSawtoothDown = Instance.Create(0x0034, "ET Sawtooth Down");

        /// <summary>
        ///     PhysicalInterfaceDevice: ET Spring Usage.
        /// </summary>
        public static readonly Usage ETSpring = Instance.Create(0x0040, "ET Spring");
        /// <summary>
        ///     PhysicalInterfaceDevice: ET Damper Usage.
        /// </summary>
        public static readonly Usage ETDamper = Instance.Create(0x0041, "ET Damper");
        /// <summary>
        ///     PhysicalInterfaceDevice: ET Inertia Usage.
        /// </summary>
        public static readonly Usage ETInertia = Instance.Create(0x0042, "ET Inertia");
        /// <summary>
        ///     PhysicalInterfaceDevice: ET Friction Usage.
        /// </summary>
        public static readonly Usage ETFriction = Instance.Create(0x0043, "ET Friction");

        /// <summary>
        ///     PhysicalInterfaceDevice: Duration Usage.
        /// </summary>
        public static readonly Usage Duration = Instance.Create(0x0050, "Duration");
        /// <summary>
        ///     PhysicalInterfaceDevice: Sample Period Usage.
        /// </summary>
        public static readonly Usage SamplePeriod = Instance.Create(0x0051, "Sample Period");
        /// <summary>
        ///     PhysicalInterfaceDevice: Gain Usage.
        /// </summary>
        public static readonly Usage Gain = Instance.Create(0x0052, "Gain");
        /// <summary>
        ///     PhysicalInterfaceDevice: Trigger Button Usage.
        /// </summary>
        public static readonly Usage TriggerButton = Instance.Create(0x0053, "Trigger Button");
        /// <summary>
        ///     PhysicalInterfaceDevice: Trigger Repeat Interval Usage.
        /// </summary>
        public static readonly Usage TriggerRepeatInterval = Instance.Create(0x0054, "Trigger Repeat Interval");
        /// <summary>
        ///     PhysicalInterfaceDevice: Axes Enable Usage.
        /// </summary>
        public static readonly Usage AxesEnable = Instance.Create(0x0055, "Axes Enable");
        /// <summary>
        ///     PhysicalInterfaceDevice: Direction Enable Usage.
        /// </summary>
        public static readonly Usage DirectionEnable = Instance.Create(0x0056, "Direction Enable");
        /// <summary>
        ///     PhysicalInterfaceDevice: Direction Usage.
        /// </summary>
        public static readonly Usage Direction = Instance.Create(0x0057, "Direction");
        /// <summary>
        ///     PhysicalInterfaceDevice: Type Specific Block Offset Usage.
        /// </summary>
        public static readonly Usage TypeSpecificBlockOffset = Instance.Create(0x0058, "Type Specific Block Offset");
        /// <summary>
        ///     PhysicalInterfaceDevice: Block Type Usage.
        /// </summary>
        public static readonly Usage BlockType = Instance.Create(0x0059, "Block Type");
        /// <summary>
        ///     PhysicalInterfaceDevice: Set Envelope Report Usage.
        /// </summary>
        public static readonly Usage SetEnvelopeReport = Instance.Create(0x005a, "Set Envelope Report");
        /// <summary>
        ///     PhysicalInterfaceDevice: Attack Level Usage.
        /// </summary>
        public static readonly Usage AttackLevel = Instance.Create(0x005b, "Attack Level");
        /// <summary>
        ///     PhysicalInterfaceDevice: Attack Time Usage.
        /// </summary>
        public static readonly Usage AttackTime = Instance.Create(0x005c, "Attack Time");
        /// <summary>
        ///     PhysicalInterfaceDevice: Fade Level Usage.
        /// </summary>
        public static readonly Usage FadeLevel = Instance.Create(0x005d, "Fade Level");
        /// <summary>
        ///     PhysicalInterfaceDevice: Fade Time Usage.
        /// </summary>
        public static readonly Usage FadeTime = Instance.Create(0x005e, "Fade Time");
        /// <summary>
        ///     PhysicalInterfaceDevice: Set Condition Report Usage.
        /// </summary>
        public static readonly Usage SetConditionReport = Instance.Create(0x005f, "Set Condition Report");
        /// <summary>
        ///     PhysicalInterfaceDevice: CP Offset Usage.
        /// </summary>
        public static readonly Usage CPOffset = Instance.Create(0x0060, "CP Offset");
        /// <summary>
        ///     PhysicalInterfaceDevice: Positive Coefficient Usage.
        /// </summary>
        public static readonly Usage PositiveCoefficient = Instance.Create(0x0061, "Positive Coefficient");
        /// <summary>
        ///     PhysicalInterfaceDevice: Negative Coefficient Usage.
        /// </summary>
        public static readonly Usage NegativeCoefficient = Instance.Create(0x0062, "Negative Coefficient");
        /// <summary>
        ///     PhysicalInterfaceDevice: Positive Saturation Usage.
        /// </summary>
        public static readonly Usage PositiveSaturation = Instance.Create(0x0063, "Positive Saturation");
        /// <summary>
        ///     PhysicalInterfaceDevice: Negative Saturation Usage.
        /// </summary>
        public static readonly Usage NegativeSaturation = Instance.Create(0x0064, "Negative Saturation");
        /// <summary>
        ///     PhysicalInterfaceDevice: Dead Band Usage.
        /// </summary>
        public static readonly Usage DeadBand = Instance.Create(0x0065, "Dead Band");
        /// <summary>
        ///     PhysicalInterfaceDevice: Download Force Sample Usage.
        /// </summary>
        public static readonly Usage DownloadForceSample = Instance.Create(0x0066, "Download Force Sample");
        /// <summary>
        ///     PhysicalInterfaceDevice: Isoch Custom Force Enable Usage.
        /// </summary>
        public static readonly Usage IsochCustomForceEnable = Instance.Create(0x0067, "Isoch Custom Force Enable");
        /// <summary>
        ///     PhysicalInterfaceDevice: Custom Force Data Report Usage.
        /// </summary>
        public static readonly Usage CustomForceDataReport = Instance.Create(0x0068, "Custom Force Data Report");
        /// <summary>
        ///     PhysicalInterfaceDevice: Custom Force Data Usage.
        /// </summary>
        public static readonly Usage CustomForceData = Instance.Create(0x0069, "Custom Force Data");
        /// <summary>
        ///     PhysicalInterfaceDevice: Custom Force Vendor Defined Data Usage.
        /// </summary>
        public static readonly Usage CustomForceVendorDefinedData = Instance.Create(0x006a, "Custom Force Vendor Defined Data");
        /// <summary>
        ///     PhysicalInterfaceDevice: Set Custom Force Report Usage.
        /// </summary>
        public static readonly Usage SetCustomForceReport = Instance.Create(0x006b, "Set Custom Force Report");
        /// <summary>
        ///     PhysicalInterfaceDevice: Custom Force Data Offset Usage.
        /// </summary>
        public static readonly Usage CustomForceDataOffset = Instance.Create(0x006c, "Custom Force Data Offset");
        /// <summary>
        ///     PhysicalInterfaceDevice: Sample Count Usage.
        /// </summary>
        public static readonly Usage SampleCount = Instance.Create(0x006d, "Sample Count");
        /// <summary>
        ///     PhysicalInterfaceDevice: Set Periodic Report Usage.
        /// </summary>
        public static readonly Usage SetPeriodicReport = Instance.Create(0x006e, "Set Periodic Report");
        /// <summary>
        ///     PhysicalInterfaceDevice: Offset Usage.
        /// </summary>
        public static readonly Usage Offset = Instance.Create(0x006f, "Offset");
        /// <summary>
        ///     PhysicalInterfaceDevice: Magnitude Usage.
        /// </summary>
        public static readonly Usage Magnitude = Instance.Create(0x0070, "Magnitude");
        /// <summary>
        ///     PhysicalInterfaceDevice: Phase Usage.
        /// </summary>
        public static readonly Usage Phase = Instance.Create(0x0071, "Phase");
        /// <summary>
        ///     PhysicalInterfaceDevice: Period Usage.
        /// </summary>
        public static readonly Usage Period = Instance.Create(0x0072, "Period");
        /// <summary>
        ///     PhysicalInterfaceDevice: Set Constant Force Report Usage.
        /// </summary>
        public static readonly Usage SetConstantForceReport = Instance.Create(0x0073, "Set Constant Force Report");
        /// <summary>
        ///     PhysicalInterfaceDevice: Set Ramp Force Report Usage.
        /// </summary>
        public static readonly Usage SetRampForceReport = Instance.Create(0x0074, "Set Ramp Force Report");
        /// <summary>
        ///     PhysicalInterfaceDevice: Ramp Start Usage.
        /// </summary>
        public static readonly Usage RampStart = Instance.Create(0x0075, "Ramp Start");
        /// <summary>
        ///     PhysicalInterfaceDevice: Ramp End Usage.
        /// </summary>
        public static readonly Usage RampEnd = Instance.Create(0x0076, "Ramp End");
        /// <summary>
        ///     PhysicalInterfaceDevice: Effect Operation Report Usage.
        /// </summary>
        public static readonly Usage EffectOperationReport = Instance.Create(0x0077, "Effect Operation Report");
        /// <summary>
        ///     PhysicalInterfaceDevice: Effect Operation Usage.
        /// </summary>
        public static readonly Usage EffectOperation = Instance.Create(0x0078, "Effect Operation");
        /// <summary>
        ///     PhysicalInterfaceDevice: Op Effect Start Usage.
        /// </summary>
        public static readonly Usage OpEffectStart = Instance.Create(0x0079, "Op Effect Start");
        /// <summary>
        ///     PhysicalInterfaceDevice: Op Effect Start Solo Usage.
        /// </summary>
        public static readonly Usage OpEffectStartSolo = Instance.Create(0x007a, "Op Effect Start Solo");
        /// <summary>
        ///     PhysicalInterfaceDevice: Op Effect Stop Usage.
        /// </summary>
        public static readonly Usage OpEffectStop = Instance.Create(0x007b, "Op Effect Stop");
        /// <summary>
        ///     PhysicalInterfaceDevice: Loop Count Usage.
        /// </summary>
        public static readonly Usage LoopCount = Instance.Create(0x007c, "Loop Count");
        /// <summary>
        ///     PhysicalInterfaceDevice: Device Gain Report Usage.
        /// </summary>
        public static readonly Usage DeviceGainReport = Instance.Create(0x007d, "Device Gain Report");
        /// <summary>
        ///     PhysicalInterfaceDevice: Device Gain Usage.
        /// </summary>
        public static readonly Usage DeviceGain = Instance.Create(0x007e, "Device Gain");
        /// <summary>
        ///     PhysicalInterfaceDevice: PID Pool Report Usage.
        /// </summary>
        public static readonly Usage PIDPoolReport = Instance.Create(0x007f, "PID Pool Report");
        /// <summary>
        ///     PhysicalInterfaceDevice: RAM Pool Size Usage.
        /// </summary>
        public static readonly Usage RAMPoolSize = Instance.Create(0x0080, "RAM Pool Size");
        /// <summary>
        ///     PhysicalInterfaceDevice: ROM Pool Size Usage.
        /// </summary>
        public static readonly Usage ROMPoolSize = Instance.Create(0x0081, "ROM Pool Size");
        /// <summary>
        ///     PhysicalInterfaceDevice: ROM Effect Block Count Usage.
        /// </summary>
        public static readonly Usage ROMEffectBlockCount = Instance.Create(0x0082, "ROM Effect Block Count");
        /// <summary>
        ///     PhysicalInterfaceDevice: Simultaneous Effects Max Usage.
        /// </summary>
        public static readonly Usage SimultaneousEffectsMax = Instance.Create(0x0083, "Simultaneous Effects Max");
        /// <summary>
        ///     PhysicalInterfaceDevice: Pool Alignment Usage.
        /// </summary>
        public static readonly Usage PoolAlignment = Instance.Create(0x0084, "Pool Alignment");
        /// <summary>
        ///     PhysicalInterfaceDevice: PID Pool Move Report Usage.
        /// </summary>
        public static readonly Usage PIDPoolMoveReport = Instance.Create(0x0085, "PID Pool Move Report");
        /// <summary>
        ///     PhysicalInterfaceDevice: Move Source Usage.
        /// </summary>
        public static readonly Usage MoveSource = Instance.Create(0x0086, "Move Source");
        /// <summary>
        ///     PhysicalInterfaceDevice: Move Destination Usage.
        /// </summary>
        public static readonly Usage MoveDestination = Instance.Create(0x0087, "Move Destination");
        /// <summary>
        ///     PhysicalInterfaceDevice: Move Length Usage.
        /// </summary>
        public static readonly Usage MoveLength = Instance.Create(0x0088, "Move Length");
        /// <summary>
        ///     PhysicalInterfaceDevice: PID Block Load Report Usage.
        /// </summary>
        public static readonly Usage PIDBlockLoadReport = Instance.Create(0x0089, "PID Block Load Report");

        /// <summary>
        ///     PhysicalInterfaceDevice: Block Load Status Usage.
        /// </summary>
        public static readonly Usage BlockLoadStatus = Instance.Create(0x008b, "Block Load Status");
        /// <summary>
        ///     PhysicalInterfaceDevice: Block Load Success Usage.
        /// </summary>
        public static readonly Usage BlockLoadSuccess = Instance.Create(0x008c, "Block Load Success");
        /// <summary>
        ///     PhysicalInterfaceDevice: Block Load Full Usage.
        /// </summary>
        public static readonly Usage BlockLoadFull = Instance.Create(0x008d, "Block Load Full");
        /// <summary>
        ///     PhysicalInterfaceDevice: Block Load Error Usage.
        /// </summary>
        public static readonly Usage BlockLoadError = Instance.Create(0x008e, "Block Load Error");
        /// <summary>
        ///     PhysicalInterfaceDevice: Block Handle Usage.
        /// </summary>
        public static readonly Usage BlockHandle = Instance.Create(0x008f, "Block Handle");
        /// <summary>
        ///     PhysicalInterfaceDevice: PID Block Free Report Usage.
        /// </summary>
        public static readonly Usage PIDBlockFreeReport = Instance.Create(0x0090, "PID Block Free Report");
        /// <summary>
        ///     PhysicalInterfaceDevice: Type Specific Block Handle Usage.
        /// </summary>
        public static readonly Usage TypeSpecificBlockHandle = Instance.Create(0x0091, "Type Specific Block Handle");
        /// <summary>
        ///     PhysicalInterfaceDevice: PID State Report Usage.
        /// </summary>
        public static readonly Usage PIDStateReport = Instance.Create(0x0092, "PID State Report");

        /// <summary>
        ///     PhysicalInterfaceDevice: Effect Playing Usage.
        /// </summary>
        public static readonly Usage EffectPlaying = Instance.Create(0x0094, "Effect Playing");
        /// <summary>
        ///     PhysicalInterfaceDevice: PID Device Control Report Usage.
        /// </summary>
        public static readonly Usage PIDDeviceControlReport = Instance.Create(0x0095, "PID Device Control Report");
        /// <summary>
        ///     PhysicalInterfaceDevice: PID Device Control Usage.
        /// </summary>
        public static readonly Usage PIDDeviceControl = Instance.Create(0x0096, "PID Device Control");
        /// <summary>
        ///     PhysicalInterfaceDevice: DC Enable Actuators Usage.
        /// </summary>
        public static readonly Usage DCEnableActuators = Instance.Create(0x0097, "DC Enable Actuators");
        /// <summary>
        ///     PhysicalInterfaceDevice: DC Disable Actuators Usage.
        /// </summary>
        public static readonly Usage DCDisableActuators = Instance.Create(0x0098, "DC Disable Actuators");
        /// <summary>
        ///     PhysicalInterfaceDevice: DC Stop All Effects Usage.
        /// </summary>
        public static readonly Usage DCStopAllEffects = Instance.Create(0x0099, "DC Stop All Effects");
        /// <summary>
        ///     PhysicalInterfaceDevice: DC Device Reset Usage.
        /// </summary>
        public static readonly Usage DCDeviceReset = Instance.Create(0x009a, "DC Device Reset");
        /// <summary>
        ///     PhysicalInterfaceDevice: DC Device Pause Usage.
        /// </summary>
        public static readonly Usage DCDevicePause = Instance.Create(0x009b, "DC Device Pause");
        /// <summary>
        ///     PhysicalInterfaceDevice: DC Device Continue Usage.
        /// </summary>
        public static readonly Usage DCDeviceContinue = Instance.Create(0x009c, "DC Device Continue");

        /// <summary>
        ///     PhysicalInterfaceDevice: Device Paused Usage.
        /// </summary>
        public static readonly Usage DevicePaused = Instance.Create(0x009f, "Device Paused");
        /// <summary>
        ///     PhysicalInterfaceDevice: Actuators Enabled Usage.
        /// </summary>
        public static readonly Usage ActuatorsEnabled = Instance.Create(0x00a0, "Actuators Enabled");

        /// <summary>
        ///     PhysicalInterfaceDevice: Safety Switch Usage.
        /// </summary>
        public static readonly Usage SafetySwitch = Instance.Create(0x00a4, "Safety Switch");
        /// <summary>
        ///     PhysicalInterfaceDevice: Actuator Override Switch Usage.
        /// </summary>
        public static readonly Usage ActuatorOverrideSwitch = Instance.Create(0x00a5, "Actuator Override Switch");
        /// <summary>
        ///     PhysicalInterfaceDevice: Actuator Power Usage.
        /// </summary>
        public static readonly Usage ActuatorPower = Instance.Create(0x00a6, "Actuator Power");
        /// <summary>
        ///     PhysicalInterfaceDevice: Start Delay Usage.
        /// </summary>
        public static readonly Usage StartDelay = Instance.Create(0x00a7, "Start Delay");
        /// <summary>
        ///     PhysicalInterfaceDevice: Parameter Block Size Usage.
        /// </summary>
        public static readonly Usage ParameterBlockSize = Instance.Create(0x00a8, "Parameter Block Size");
        /// <summary>
        ///     PhysicalInterfaceDevice: Device Managed Pool Usage.
        /// </summary>
        public static readonly Usage DeviceManagedPool = Instance.Create(0x00a9, "Device Managed Pool");
        /// <summary>
        ///     PhysicalInterfaceDevice: Shared Parameter Blocks Usage.
        /// </summary>
        public static readonly Usage SharedParameterBlocks = Instance.Create(0x00aa, "Shared Parameter Blocks");
        /// <summary>
        ///     PhysicalInterfaceDevice: Create New Effect Report Usage.
        /// </summary>
        public static readonly Usage CreateNewEffectReport = Instance.Create(0x00ab, "Create New Effect Report");
        /// <summary>
        ///     PhysicalInterfaceDevice: RAM Pool Available Usage.
        /// </summary>
        public static readonly Usage RAMPoolAvailable = Instance.Create(0x00ac, "RAM Pool Available");

        /// <summary>
        ///     PhysicalInterfaceDevice: Undefined Usage.
        /// </summary>
        public static readonly Usage Undefined = Instance.Create(0x0000, "Undefined");

        /// <inheritdoc />
        private PhysicalInterfaceDevicePage(ushort id, string name) : base(id, name, true)
        {
        }
    }

    /// <summary>
    ///     Class defining the Unicode usage page.
    /// </summary>
    public sealed partial class UnicodePage : UsagePage
    {
        /// <summary>
        ///     The singleton instance of UnicodePage.
        /// </summary>
        public static readonly UnicodePage Instance = new UnicodePage(0x0010, "Unicode");

        /// <summary>
        ///     Unicode: Undefined Usage.
        /// </summary>
        public static readonly Usage Undefined = Instance.Create(0x0000, "Undefined");

        /// <inheritdoc />
        private UnicodePage(ushort id, string name) : base(id, name, true)
        {
        }
    }

    /// <summary>
    ///     Class defining the Eye and Head Trackers usage page.
    /// </summary>
    public sealed partial class EyeAndHeadTrackersPage : UsagePage
    {
        /// <summary>
        ///     The singleton instance of EyeAndHeadTrackersPage.
        /// </summary>
        public static readonly EyeAndHeadTrackersPage Instance = new EyeAndHeadTrackersPage(0x0012, "Eye and Head Trackers");

        /// <summary>
        ///     EyeAndHeadTrackers: Eye Tracker Usage.
        /// </summary>
        public static readonly Usage EyeTracker = Instance.Create(0x0001, "Eye Tracker");
        /// <summary>
        ///     EyeAndHeadTrackers: Head Tracker Usage.
        /// </summary>
        public static readonly Usage HeadTracker = Instance.Create(0x0002, "Head Tracker");

        /// <summary>
        ///     EyeAndHeadTrackers: Tracking Data Usage.
        /// </summary>
        public static readonly Usage TrackingData = Instance.Create(0x0010, "Tracking Data");
        /// <summary>
        ///     EyeAndHeadTrackers: Capabilities Usage.
        /// </summary>
        public static readonly Usage Capabilities = Instance.Create(0x0011, "Capabilities");
        /// <summary>
        ///     EyeAndHeadTrackers: Configuration Usage.
        /// </summary>
        public static readonly Usage Configuration = Instance.Create(0x0012, "Configuration");
        /// <summary>
        ///     EyeAndHeadTrackers: Status Usage.
        /// </summary>
        public static readonly Usage Status = Instance.Create(0x0013, "Status");
        /// <summary>
        ///     EyeAndHeadTrackers: Control Usage.
        /// </summary>
        public static readonly Usage Control = Instance.Create(0x0014, "Control");

        /// <summary>
        ///     EyeAndHeadTrackers: Sensor Timestamp Usage.
        /// </summary>
        public static readonly Usage SensorTimestamp = Instance.Create(0x0020, "Sensor Timestamp");
        /// <summary>
        ///     EyeAndHeadTrackers: Position X Usage.
        /// </summary>
        public static readonly Usage PositionX = Instance.Create(0x0021, "Position X");
        /// <summary>
        ///     EyeAndHeadTrackers: Position Y Usage.
        /// </summary>
        public static readonly Usage PositionY = Instance.Create(0x0022, "Position Y");
        /// <summary>
        ///     EyeAndHeadTrackers: Position Z Usage.
        /// </summary>
        public static readonly Usage PositionZ = Instance.Create(0x0023, "Position Z");
        /// <summary>
        ///     EyeAndHeadTrackers: Gaze Point Usage.
        /// </summary>
        public static readonly Usage GazePoint = Instance.Create(0x0024, "Gaze Point");
        /// <summary>
        ///     EyeAndHeadTrackers: Left Eye Position Usage.
        /// </summary>
        public static readonly Usage LeftEyePosition = Instance.Create(0x0025, "Left Eye Position");
        /// <summary>
        ///     EyeAndHeadTrackers: Right Eye Position Usage.
        /// </summary>
        public static readonly Usage RightEyePosition = Instance.Create(0x0026, "Right Eye Position");
        /// <summary>
        ///     EyeAndHeadTrackers: Head Position Usage.
        /// </summary>
        public static readonly Usage HeadPosition = Instance.Create(0x0027, "Head Position");
        /// <summary>
        ///     EyeAndHeadTrackers: Head Direction Point Usage.
        /// </summary>
        public static readonly Usage HeadDirectionPoint = Instance.Create(0x0028, "Head Direction Point");
        /// <summary>
        ///     EyeAndHeadTrackers: Rotation about X axis Usage.
        /// </summary>
        public static readonly Usage RotationAboutXAxis = Instance.Create(0x0029, "Rotation about X axis");
        /// <summary>
        ///     EyeAndHeadTrackers: Rotation about Y axis Usage.
        /// </summary>
        public static readonly Usage RotationAboutYAxis = Instance.Create(0x002a, "Rotation about Y axis");
        /// <summary>
        ///     EyeAndHeadTrackers: Rotation about Z axis Usage.
        /// </summary>
        public static readonly Usage RotationAboutZAxis = Instance.Create(0x002b, "Rotation about Z axis");

        /// <summary>
        ///     EyeAndHeadTrackers: Tracker Quality Usage.
        /// </summary>
        public static readonly Usage TrackerQuality = Instance.Create(0x0100, "Tracker Quality");
        /// <summary>
        ///     EyeAndHeadTrackers: Minimum Tracking Distance Usage.
        /// </summary>
        public static readonly Usage MinimumTrackingDistance = Instance.Create(0x0101, "Minimum Tracking Distance");
        /// <summary>
        ///     EyeAndHeadTrackers: Optimum Tracking Distance Usage.
        /// </summary>
        public static readonly Usage OptimumTrackingDistance = Instance.Create(0x0102, "Optimum Tracking Distance");
        /// <summary>
        ///     EyeAndHeadTrackers: Maximum Tracking Distance Usage.
        /// </summary>
        public static readonly Usage MaximumTrackingDistance = Instance.Create(0x0103, "Maximum Tracking Distance");
        /// <summary>
        ///     EyeAndHeadTrackers: Maximum Screen Plane Width Usage.
        /// </summary>
        public static readonly Usage MaximumScreenPlaneWidth = Instance.Create(0x0104, "Maximum Screen Plane Width");
        /// <summary>
        ///     EyeAndHeadTrackers: Maximum Screen Plane Height Usage.
        /// </summary>
        public static readonly Usage MaximumScreenPlaneHeight = Instance.Create(0x0105, "Maximum Screen Plane Height");

        /// <summary>
        ///     EyeAndHeadTrackers: Display Manufacturer ID Usage.
        /// </summary>
        public static readonly Usage DisplayManufacturerID = Instance.Create(0x0200, "Display Manufacturer ID");
        /// <summary>
        ///     EyeAndHeadTrackers: Display Product ID Usage.
        /// </summary>
        public static readonly Usage DisplayProductID = Instance.Create(0x0201, "Display Product ID");
        /// <summary>
        ///     EyeAndHeadTrackers: Display Serial Number Usage.
        /// </summary>
        public static readonly Usage DisplaySerialNumber = Instance.Create(0x0202, "Display Serial Number");
        /// <summary>
        ///     EyeAndHeadTrackers: Display Manufacturer Date Usage.
        /// </summary>
        public static readonly Usage DisplayManufacturerDate = Instance.Create(0x0203, "Display Manufacturer Date");
        /// <summary>
        ///     EyeAndHeadTrackers: Calibrated Screen Width Usage.
        /// </summary>
        public static readonly Usage CalibratedScreenWidth = Instance.Create(0x0204, "Calibrated Screen Width");
        /// <summary>
        ///     EyeAndHeadTrackers: Calibrated Screen Height Usage.
        /// </summary>
        public static readonly Usage CalibratedScreenHeight = Instance.Create(0x0205, "Calibrated Screen Height");

        /// <summary>
        ///     EyeAndHeadTrackers: Sampling Frequency Usage.
        /// </summary>
        public static readonly Usage SamplingFrequency = Instance.Create(0x0300, "Sampling Frequency");
        /// <summary>
        ///     EyeAndHeadTrackers: Configuration Status Usage.
        /// </summary>
        public static readonly Usage ConfigurationStatus = Instance.Create(0x0301, "Configuration Status");

        /// <summary>
        ///     EyeAndHeadTrackers: Device Mode Request Usage.
        /// </summary>
        public static readonly Usage DeviceModeRequest = Instance.Create(0x0400, "Device Mode Request");

        /// <summary>
        ///     EyeAndHeadTrackers: Undefined Usage.
        /// </summary>
        public static readonly Usage Undefined = Instance.Create(0x0000, "Undefined");

        /// <inheritdoc />
        private EyeAndHeadTrackersPage(ushort id, string name) : base(id, name, true)
        {
        }
    }

    /// <summary>
    ///     Class defining the Auxiliary Display usage page.
    /// </summary>
    public sealed partial class AuxiliaryDisplayPage : UsagePage
    {
        /// <summary>
        ///     The singleton instance of AuxiliaryDisplayPage.
        /// </summary>
        public static readonly AuxiliaryDisplayPage Instance = new AuxiliaryDisplayPage(0x0014, "Auxiliary Display");

        /// <summary>
        ///     AuxiliaryDisplay: Alphanumeric Display Usage.
        /// </summary>
        public static readonly Usage AlphanumericDisplay = Instance.Create(0x0001, "Alphanumeric Display");
        /// <summary>
        ///     AuxiliaryDisplay: Auxiliary Display Usage.
        /// </summary>
        public static readonly Usage AuxiliaryDisplay = Instance.Create(0x0002, "Auxiliary Display");
        /// <summary>
        ///     AuxiliaryDisplay: Display Attributes Report Usage.
        /// </summary>
        public static readonly Usage DisplayAttributesReport = Instance.Create(0x0020, "Display Attributes Report");
        /// <summary>
        ///     AuxiliaryDisplay: ASCII Character Set Usage.
        /// </summary>
        public static readonly Usage ASCIICharacterSet = Instance.Create(0x0021, "ASCII Character Set");
        /// <summary>
        ///     AuxiliaryDisplay: Data Read Back Usage.
        /// </summary>
        public static readonly Usage DataReadBack = Instance.Create(0x0022, "Data Read Back");
        /// <summary>
        ///     AuxiliaryDisplay: Font Read Back Usage.
        /// </summary>
        public static readonly Usage FontReadBack = Instance.Create(0x0023, "Font Read Back");
        /// <summary>
        ///     AuxiliaryDisplay: Display Control Report Usage.
        /// </summary>
        public static readonly Usage DisplayControlReport = Instance.Create(0x0024, "Display Control Report");
        /// <summary>
        ///     AuxiliaryDisplay: Clear Display Usage.
        /// </summary>
        public static readonly Usage ClearDisplay = Instance.Create(0x0025, "Clear Display");
        /// <summary>
        ///     AuxiliaryDisplay: Display Enable Usage.
        /// </summary>
        public static readonly Usage DisplayEnable = Instance.Create(0x0026, "Display Enable");
        /// <summary>
        ///     AuxiliaryDisplay: Screen Saver Delay Usage.
        /// </summary>
        public static readonly Usage ScreenSaverDelay = Instance.Create(0x0027, "Screen Saver Delay");
        /// <summary>
        ///     AuxiliaryDisplay: Screen Saver Enable Usage.
        /// </summary>
        public static readonly Usage ScreenSaverEnable = Instance.Create(0x0028, "Screen Saver Enable");
        /// <summary>
        ///     AuxiliaryDisplay: Vertical Scroll Usage.
        /// </summary>
        public static readonly Usage VerticalScroll = Instance.Create(0x0029, "Vertical Scroll");
        /// <summary>
        ///     AuxiliaryDisplay: Horizontal Scroll Usage.
        /// </summary>
        public static readonly Usage HorizontalScroll = Instance.Create(0x002a, "Horizontal Scroll");
        /// <summary>
        ///     AuxiliaryDisplay: Character Report Usage.
        /// </summary>
        public static readonly Usage CharacterReport = Instance.Create(0x002b, "Character Report");
        /// <summary>
        ///     AuxiliaryDisplay: Display Data Usage.
        /// </summary>
        public static readonly Usage DisplayData = Instance.Create(0x002c, "Display Data");
        /// <summary>
        ///     AuxiliaryDisplay: Display Status Usage.
        /// </summary>
        public static readonly Usage DisplayStatus = Instance.Create(0x002d, "Display Status");
        /// <summary>
        ///     AuxiliaryDisplay: Stat Not Ready Usage.
        /// </summary>
        public static readonly Usage StatNotReady = Instance.Create(0x002e, "Stat Not Ready");
        /// <summary>
        ///     AuxiliaryDisplay: Stat Ready Usage.
        /// </summary>
        public static readonly Usage StatReady = Instance.Create(0x002f, "Stat Ready");
        /// <summary>
        ///     AuxiliaryDisplay: Err Not a loadable character Usage.
        /// </summary>
        public static readonly Usage ErrNotALoadableCharacter = Instance.Create(0x0030, "Err Not a loadable character");
        /// <summary>
        ///     AuxiliaryDisplay: Err Font data cannot be read Usage.
        /// </summary>
        public static readonly Usage ErrFontDataCannotBeRead = Instance.Create(0x0031, "Err Font data cannot be read");
        /// <summary>
        ///     AuxiliaryDisplay: Cursor Position Report Usage.
        /// </summary>
        public static readonly Usage CursorPositionReport = Instance.Create(0x0032, "Cursor Position Report");
        /// <summary>
        ///     AuxiliaryDisplay: Row Usage.
        /// </summary>
        public static readonly Usage Row = Instance.Create(0x0033, "Row");
        /// <summary>
        ///     AuxiliaryDisplay: Column Usage.
        /// </summary>
        public static readonly Usage Column = Instance.Create(0x0034, "Column");
        /// <summary>
        ///     AuxiliaryDisplay: Rows Usage.
        /// </summary>
        public static readonly Usage Rows = Instance.Create(0x0035, "Rows");
        /// <summary>
        ///     AuxiliaryDisplay: Columns Usage.
        /// </summary>
        public static readonly Usage Columns = Instance.Create(0x0036, "Columns");
        /// <summary>
        ///     AuxiliaryDisplay: Cursor Pixel Positioning Usage.
        /// </summary>
        public static readonly Usage CursorPixelPositioning = Instance.Create(0x0037, "Cursor Pixel Positioning");
        /// <summary>
        ///     AuxiliaryDisplay: Cursor Mode Usage.
        /// </summary>
        public static readonly Usage CursorMode = Instance.Create(0x0038, "Cursor Mode");
        /// <summary>
        ///     AuxiliaryDisplay: Cursor Enable Usage.
        /// </summary>
        public static readonly Usage CursorEnable = Instance.Create(0x0039, "Cursor Enable");
        /// <summary>
        ///     AuxiliaryDisplay: Cursor Blink Usage.
        /// </summary>
        public static readonly Usage CursorBlink = Instance.Create(0x003a, "Cursor Blink");
        /// <summary>
        ///     AuxiliaryDisplay: Font Report Usage.
        /// </summary>
        public static readonly Usage FontReport = Instance.Create(0x003b, "Font Report");
        /// <summary>
        ///     AuxiliaryDisplay: Font Data Usage.
        /// </summary>
        public static readonly Usage FontData = Instance.Create(0x003c, "Font Data");
        /// <summary>
        ///     AuxiliaryDisplay: Character Width Usage.
        /// </summary>
        public static readonly Usage CharacterWidth = Instance.Create(0x003d, "Character Width");
        /// <summary>
        ///     AuxiliaryDisplay: Character Height Usage.
        /// </summary>
        public static readonly Usage CharacterHeight = Instance.Create(0x003e, "Character Height");
        /// <summary>
        ///     AuxiliaryDisplay: Character Spacing Horizontal Usage.
        /// </summary>
        public static readonly Usage CharacterSpacingHorizontal = Instance.Create(0x003f, "Character Spacing Horizontal");
        /// <summary>
        ///     AuxiliaryDisplay: Character Spacing Vertical Usage.
        /// </summary>
        public static readonly Usage CharacterSpacingVertical = Instance.Create(0x0040, "Character Spacing Vertical");
        /// <summary>
        ///     AuxiliaryDisplay: Unicode Character Set Usage.
        /// </summary>
        public static readonly Usage UnicodeCharacterSet = Instance.Create(0x0041, "Unicode Character Set");
        /// <summary>
        ///     AuxiliaryDisplay: Font 7-Segment Usage.
        /// </summary>
        public static readonly Usage Font7Segment = Instance.Create(0x0042, "Font 7-Segment");
        /// <summary>
        ///     AuxiliaryDisplay: 7-Segment Direct Map Usage.
        /// </summary>
        public static readonly Usage SegmentDirectMap = Instance.Create(0x0043, "7-Segment Direct Map");
        /// <summary>
        ///     AuxiliaryDisplay: Font 14-Segment Usage.
        /// </summary>
        public static readonly Usage Font14Segment = Instance.Create(0x0044, "Font 14-Segment");
        /// <summary>
        ///     AuxiliaryDisplay: 14-Segment Direct Map Usage.
        /// </summary>
        public static readonly Usage SegmentDirectMap2 = Instance.Create(0x0045, "14-Segment Direct Map");
        /// <summary>
        ///     AuxiliaryDisplay: Display Brightness Usage.
        /// </summary>
        public static readonly Usage DisplayBrightness = Instance.Create(0x0046, "Display Brightness");
        /// <summary>
        ///     AuxiliaryDisplay: Display Contrast Usage.
        /// </summary>
        public static readonly Usage DisplayContrast = Instance.Create(0x0047, "Display Contrast");
        /// <summary>
        ///     AuxiliaryDisplay: Character Attribute Usage.
        /// </summary>
        public static readonly Usage CharacterAttribute = Instance.Create(0x0048, "Character Attribute");
        /// <summary>
        ///     AuxiliaryDisplay: Attribute Readback Usage.
        /// </summary>
        public static readonly Usage AttributeReadback = Instance.Create(0x0049, "Attribute Readback");
        /// <summary>
        ///     AuxiliaryDisplay: Attribute Data Usage.
        /// </summary>
        public static readonly Usage AttributeData = Instance.Create(0x004a, "Attribute Data");
        /// <summary>
        ///     AuxiliaryDisplay: Char Attr Enhance Usage.
        /// </summary>
        public static readonly Usage CharAttrEnhance = Instance.Create(0x004b, "Char Attr Enhance");
        /// <summary>
        ///     AuxiliaryDisplay: Char Attr Underline Usage.
        /// </summary>
        public static readonly Usage CharAttrUnderline = Instance.Create(0x004c, "Char Attr Underline");
        /// <summary>
        ///     AuxiliaryDisplay: Char Attr Blink Usage.
        /// </summary>
        public static readonly Usage CharAttrBlink = Instance.Create(0x004d, "Char Attr Blink");
        /// <summary>
        ///     AuxiliaryDisplay: Bitmap Size X Usage.
        /// </summary>
        public static readonly Usage BitmapSizeX = Instance.Create(0x0080, "Bitmap Size X");
        /// <summary>
        ///     AuxiliaryDisplay: Bitmap Size Y Usage.
        /// </summary>
        public static readonly Usage BitmapSizeY = Instance.Create(0x0081, "Bitmap Size Y");
        /// <summary>
        ///     AuxiliaryDisplay: Max Blit Size Usage.
        /// </summary>
        public static readonly Usage MaxBlitSize = Instance.Create(0x0082, "Max Blit Size");
        /// <summary>
        ///     AuxiliaryDisplay: Bit Depth Format Usage.
        /// </summary>
        public static readonly Usage BitDepthFormat = Instance.Create(0x0083, "Bit Depth Format");
        /// <summary>
        ///     AuxiliaryDisplay: Display Orientation Usage.
        /// </summary>
        public static readonly Usage DisplayOrientation = Instance.Create(0x0084, "Display Orientation");
        /// <summary>
        ///     AuxiliaryDisplay: Palette Report Usage.
        /// </summary>
        public static readonly Usage PaletteReport = Instance.Create(0x0085, "Palette Report");
        /// <summary>
        ///     AuxiliaryDisplay: Palette Data Size Usage.
        /// </summary>
        public static readonly Usage PaletteDataSize = Instance.Create(0x0086, "Palette Data Size");
        /// <summary>
        ///     AuxiliaryDisplay: Palette Data Offset Usage.
        /// </summary>
        public static readonly Usage PaletteDataOffset = Instance.Create(0x0087, "Palette Data Offset");
        /// <summary>
        ///     AuxiliaryDisplay: Palette Data Usage.
        /// </summary>
        public static readonly Usage PaletteData = Instance.Create(0x0088, "Palette Data");
        /// <summary>
        ///     AuxiliaryDisplay: Blit Report Usage.
        /// </summary>
        public static readonly Usage BlitReport = Instance.Create(0x008a, "Blit Report");
        /// <summary>
        ///     AuxiliaryDisplay: Blit Rectangle X1 Usage.
        /// </summary>
        public static readonly Usage BlitRectangleX1 = Instance.Create(0x008b, "Blit Rectangle X1");
        /// <summary>
        ///     AuxiliaryDisplay: Blit Rectangle Y1 Usage.
        /// </summary>
        public static readonly Usage BlitRectangleY1 = Instance.Create(0x008c, "Blit Rectangle Y1");
        /// <summary>
        ///     AuxiliaryDisplay: Blit Rectangle X2 Usage.
        /// </summary>
        public static readonly Usage BlitRectangleX2 = Instance.Create(0x008d, "Blit Rectangle X2");
        /// <summary>
        ///     AuxiliaryDisplay: Blit Rectangle Y2 Usage.
        /// </summary>
        public static readonly Usage BlitRectangleY2 = Instance.Create(0x008e, "Blit Rectangle Y2");
        /// <summary>
        ///     AuxiliaryDisplay: Blit Data Usage.
        /// </summary>
        public static readonly Usage BlitData = Instance.Create(0x008f, "Blit Data");
        /// <summary>
        ///     AuxiliaryDisplay: Soft Button Usage.
        /// </summary>
        public static readonly Usage SoftButton = Instance.Create(0x0090, "Soft Button");
        /// <summary>
        ///     AuxiliaryDisplay: Soft Button ID Usage.
        /// </summary>
        public static readonly Usage SoftButtonID = Instance.Create(0x0091, "Soft Button ID");
        /// <summary>
        ///     AuxiliaryDisplay: Soft Button Side Usage.
        /// </summary>
        public static readonly Usage SoftButtonSide = Instance.Create(0x0092, "Soft Button Side");
        /// <summary>
        ///     AuxiliaryDisplay: Soft Button Offset 1 Usage.
        /// </summary>
        public static readonly Usage SoftButtonOffset1 = Instance.Create(0x0093, "Soft Button Offset 1");
        /// <summary>
        ///     AuxiliaryDisplay: Soft Button Offset 2 Usage.
        /// </summary>
        public static readonly Usage SoftButtonOffset2 = Instance.Create(0x0094, "Soft Button Offset 2");
        /// <summary>
        ///     AuxiliaryDisplay: Soft Button Report Usage.
        /// </summary>
        public static readonly Usage SoftButtonReport = Instance.Create(0x0095, "Soft Button Report");

        /// <summary>
        ///     AuxiliaryDisplay: Undefined Usage.
        /// </summary>
        public static readonly Usage Undefined = Instance.Create(0x0000, "Undefined");

        /// <inheritdoc />
        private AuxiliaryDisplayPage(ushort id, string name) : base(id, name, true)
        {
        }
    }

    /// <summary>
    ///     Class defining the Sensor usage page.
    /// </summary>
    public sealed partial class SensorPage : UsagePage
    {
        /// <summary>
        ///     The singleton instance of SensorPage.
        /// </summary>
        public static readonly SensorPage Instance = new SensorPage(0x0020, "Sensor");

        /// <summary>
        ///     Sensor: Sensor Usage.
        /// </summary>
        public static readonly Usage Sensor = Instance.Create(0x0001, "Sensor");

        /// <summary>
        ///     Sensor: Biometric Usage.
        /// </summary>
        public static readonly Usage Biometric = Instance.Create(0x0010, "Biometric");
        /// <summary>
        ///     Sensor: Biometric: Human Presence Usage.
        /// </summary>
        public static readonly Usage BiometricHumanPresence = Instance.Create(0x0011, "Biometric: Human Presence");
        /// <summary>
        ///     Sensor: Biometric: Human Proximity Usage.
        /// </summary>
        public static readonly Usage BiometricHumanProximity = Instance.Create(0x0012, "Biometric: Human Proximity");
        /// <summary>
        ///     Sensor: Biometric: Human Touch Usage.
        /// </summary>
        public static readonly Usage BiometricHumanTouch = Instance.Create(0x0013, "Biometric: Human Touch");
        /// <summary>
        ///     Sensor: Biometric: Blood Pressure Usage.
        /// </summary>
        public static readonly Usage BiometricBloodPressure = Instance.Create(0x0014, "Biometric: Blood Pressure");
        /// <summary>
        ///     Sensor: Biometric: Body Temperature Usage.
        /// </summary>
        public static readonly Usage BiometricBodyTemperature = Instance.Create(0x0015, "Biometric: Body Temperature");
        /// <summary>
        ///     Sensor: Biometric: Heart Rate Usage.
        /// </summary>
        public static readonly Usage BiometricHeartRate = Instance.Create(0x0016, "Biometric: Heart Rate");
        /// <summary>
        ///     Sensor: Biometric: Heart Rate Variability Usage.
        /// </summary>
        public static readonly Usage BiometricHeartRateVariability = Instance.Create(0x0017, "Biometric: Heart Rate Variability");
        /// <summary>
        ///     Sensor: Biometric: Peripheral Oxygen Saturation Usage.
        /// </summary>
        public static readonly Usage BiometricPeripheralOxygenSaturation = Instance.Create(0x0018, "Biometric: Peripheral Oxygen Saturation");
        /// <summary>
        ///     Sensor: Biometric: Respiratory Rate Usage.
        /// </summary>
        public static readonly Usage BiometricRespiratoryRate = Instance.Create(0x0019, "Biometric: Respiratory Rate");

        /// <summary>
        ///     Sensor: Electrical Usage.
        /// </summary>
        public static readonly Usage Electrical = Instance.Create(0x0020, "Electrical");
        /// <summary>
        ///     Sensor: Electrical: Capacitance Usage.
        /// </summary>
        public static readonly Usage ElectricalCapacitance = Instance.Create(0x0021, "Electrical: Capacitance");
        /// <summary>
        ///     Sensor: Electrical: Current Usage.
        /// </summary>
        public static readonly Usage ElectricalCurrent = Instance.Create(0x0022, "Electrical: Current");
        /// <summary>
        ///     Sensor: Electrical: Power Usage.
        /// </summary>
        public static readonly Usage ElectricalPower = Instance.Create(0x0023, "Electrical: Power");
        /// <summary>
        ///     Sensor: Electrical: Inductance Usage.
        /// </summary>
        public static readonly Usage ElectricalInductance = Instance.Create(0x0024, "Electrical: Inductance");
        /// <summary>
        ///     Sensor: Electrical: Resistance Usage.
        /// </summary>
        public static readonly Usage ElectricalResistance = Instance.Create(0x0025, "Electrical: Resistance");
        /// <summary>
        ///     Sensor: Electrical: Voltage Usage.
        /// </summary>
        public static readonly Usage ElectricalVoltage = Instance.Create(0x0026, "Electrical: Voltage");
        /// <summary>
        ///     Sensor: Electrical: Potentiometer Usage.
        /// </summary>
        public static readonly Usage ElectricalPotentiometer = Instance.Create(0x0027, "Electrical: Potentiometer");
        /// <summary>
        ///     Sensor: Electrical: Frequency Usage.
        /// </summary>
        public static readonly Usage ElectricalFrequency = Instance.Create(0x0028, "Electrical: Frequency");
        /// <summary>
        ///     Sensor: Electrical: Period Usage.
        /// </summary>
        public static readonly Usage ElectricalPeriod = Instance.Create(0x0029, "Electrical: Period");

        /// <summary>
        ///     Sensor: Environmental Usage.
        /// </summary>
        public static readonly Usage Environmental = Instance.Create(0x0030, "Environmental");
        /// <summary>
        ///     Sensor: Environmental: Atmospheric Pressure Usage.
        /// </summary>
        public static readonly Usage EnvironmentalAtmosphericPressure = Instance.Create(0x0031, "Environmental: Atmospheric Pressure");
        /// <summary>
        ///     Sensor: Environmental: Humidity Usage.
        /// </summary>
        public static readonly Usage EnvironmentalHumidity = Instance.Create(0x0032, "Environmental: Humidity");
        /// <summary>
        ///     Sensor: Environmental: Temperature Usage.
        /// </summary>
        public static readonly Usage EnvironmentalTemperature = Instance.Create(0x0033, "Environmental: Temperature");
        /// <summary>
        ///     Sensor: Environmental: Wind Direction Usage.
        /// </summary>
        public static readonly Usage EnvironmentalWindDirection = Instance.Create(0x0034, "Environmental: Wind Direction");
        /// <summary>
        ///     Sensor: Environmental: Wind Speed Usage.
        /// </summary>
        public static readonly Usage EnvironmentalWindSpeed = Instance.Create(0x0035, "Environmental: Wind Speed");
        /// <summary>
        ///     Sensor: Environmental: Air Quality Usage.
        /// </summary>
        public static readonly Usage EnvironmentalAirQuality = Instance.Create(0x0036, "Environmental: Air Quality");
        /// <summary>
        ///     Sensor: Environmental: Heat Index Usage.
        /// </summary>
        public static readonly Usage EnvironmentalHeatIndex = Instance.Create(0x0037, "Environmental: Heat Index");
        /// <summary>
        ///     Sensor: Environmental: Surface Temperature Usage.
        /// </summary>
        public static readonly Usage EnvironmentalSurfaceTemperature = Instance.Create(0x0038, "Environmental: Surface Temperature");
        /// <summary>
        ///     Sensor: Environmental: Volatile Organic Compounds Usage.
        /// </summary>
        public static readonly Usage EnvironmentalVolatileOrganicCompounds = Instance.Create(0x0039, "Environmental: Volatile Organic Compounds");

        /// <summary>
        ///     Sensor: Light Usage.
        /// </summary>
        public static readonly Usage Light = Instance.Create(0x0040, "Light");
        /// <summary>
        ///     Sensor: Light: Ambient Light Usage.
        /// </summary>
        public static readonly Usage LightAmbientLight = Instance.Create(0x0041, "Light: Ambient Light");
        /// <summary>
        ///     Sensor: Light: Consumer Infrared Usage.
        /// </summary>
        public static readonly Usage LightConsumerInfrared = Instance.Create(0x0042, "Light: Consumer Infrared");
        /// <summary>
        ///     Sensor: Light: Infrared Light Usage.
        /// </summary>
        public static readonly Usage LightInfraredLight = Instance.Create(0x0043, "Light: Infrared Light");
        /// <summary>
        ///     Sensor: Light: Visible Light Usage.
        /// </summary>
        public static readonly Usage LightVisibleLight = Instance.Create(0x0044, "Light: Visible Light");
        /// <summary>
        ///     Sensor: Light: Ultraviolet Light Usage.
        /// </summary>
        public static readonly Usage LightUltravioletLight = Instance.Create(0x0045, "Light: Ultraviolet Light");

        /// <summary>
        ///     Sensor: Location Usage.
        /// </summary>
        public static readonly Usage Location = Instance.Create(0x0050, "Location");
        /// <summary>
        ///     Sensor: Location: Broadcast Usage.
        /// </summary>
        public static readonly Usage LocationBroadcast = Instance.Create(0x0051, "Location: Broadcast");
        /// <summary>
        ///     Sensor: Location: Dead Reckoning Usage.
        /// </summary>
        public static readonly Usage LocationDeadReckoning = Instance.Create(0x0052, "Location: Dead Reckoning");
        /// <summary>
        ///     Sensor: Location: GPS Usage.
        /// </summary>
        public static readonly Usage LocationGPS = Instance.Create(0x0053, "Location: GPS");
        /// <summary>
        ///     Sensor: Location: Lookup Usage.
        /// </summary>
        public static readonly Usage LocationLookup = Instance.Create(0x0054, "Location: Lookup");
        /// <summary>
        ///     Sensor: Location: Other Usage.
        /// </summary>
        public static readonly Usage LocationOther = Instance.Create(0x0055, "Location: Other");
        /// <summary>
        ///     Sensor: Location: Static Usage.
        /// </summary>
        public static readonly Usage LocationStatic = Instance.Create(0x0056, "Location: Static");
        /// <summary>
        ///     Sensor: Location: Triangulation Usage.
        /// </summary>
        public static readonly Usage LocationTriangulation = Instance.Create(0x0057, "Location: Triangulation");

        /// <summary>
        ///     Sensor: Mechanical Usage.
        /// </summary>
        public static readonly Usage Mechanical = Instance.Create(0x0060, "Mechanical");
        /// <summary>
        ///     Sensor: Mechanical: Boolean Switch Usage.
        /// </summary>
        public static readonly Usage MechanicalBooleanSwitch = Instance.Create(0x0061, "Mechanical: Boolean Switch");
        /// <summary>
        ///     Sensor: Mechanical: Boolean Switch Array Usage.
        /// </summary>
        public static readonly Usage MechanicalBooleanSwitchArray = Instance.Create(0x0062, "Mechanical: Boolean Switch Array");
        /// <summary>
        ///     Sensor: Mechanical: Multivalue Switch Usage.
        /// </summary>
        public static readonly Usage MechanicalMultivalueSwitch = Instance.Create(0x0063, "Mechanical: Multivalue Switch");
        /// <summary>
        ///     Sensor: Mechanical: Force Usage.
        /// </summary>
        public static readonly Usage MechanicalForce = Instance.Create(0x0064, "Mechanical: Force");
        /// <summary>
        ///     Sensor: Mechanical: Pressure Usage.
        /// </summary>
        public static readonly Usage MechanicalPressure = Instance.Create(0x0065, "Mechanical: Pressure");
        /// <summary>
        ///     Sensor: Mechanical: Strain Usage.
        /// </summary>
        public static readonly Usage MechanicalStrain = Instance.Create(0x0066, "Mechanical: Strain");
        /// <summary>
        ///     Sensor: Mechanical: Weight Usage.
        /// </summary>
        public static readonly Usage MechanicalWeight = Instance.Create(0x0067, "Mechanical: Weight");
        /// <summary>
        ///     Sensor: Mechanical: Haptic Vibrator Usage.
        /// </summary>
        public static readonly Usage MechanicalHapticVibrator = Instance.Create(0x0068, "Mechanical: Haptic Vibrator");
        /// <summary>
        ///     Sensor: Mechanical: Hall Effect Switch Usage.
        /// </summary>
        public static readonly Usage MechanicalHallEffectSwitch = Instance.Create(0x0069, "Mechanical: Hall Effect Switch");

        /// <summary>
        ///     Sensor: Motion Usage.
        /// </summary>
        public static readonly Usage Motion = Instance.Create(0x0070, "Motion");
        /// <summary>
        ///     Sensor: Motion: Accelerometer 1D Usage.
        /// </summary>
        public static readonly Usage MotionAccelerometer1D = Instance.Create(0x0071, "Motion: Accelerometer 1D");
        /// <summary>
        ///     Sensor: Motion: Accelerometer 2D Usage.
        /// </summary>
        public static readonly Usage MotionAccelerometer2D = Instance.Create(0x0072, "Motion: Accelerometer 2D");
        /// <summary>
        ///     Sensor: Motion: Accelerometer 3D Usage.
        /// </summary>
        public static readonly Usage MotionAccelerometer3D = Instance.Create(0x0073, "Motion: Accelerometer 3D");
        /// <summary>
        ///     Sensor: Motion: Gyrometer 1D Usage.
        /// </summary>
        public static readonly Usage MotionGyrometer1D = Instance.Create(0x0074, "Motion: Gyrometer 1D");
        /// <summary>
        ///     Sensor: Motion: Gyrometer 2D Usage.
        /// </summary>
        public static readonly Usage MotionGyrometer2D = Instance.Create(0x0075, "Motion: Gyrometer 2D");
        /// <summary>
        ///     Sensor: Motion: Gyrometer 3D Usage.
        /// </summary>
        public static readonly Usage MotionGyrometer3D = Instance.Create(0x0076, "Motion: Gyrometer 3D");
        /// <summary>
        ///     Sensor: Motion: Motion Detector Usage.
        /// </summary>
        public static readonly Usage MotionMotionDetector = Instance.Create(0x0077, "Motion: Motion Detector");
        /// <summary>
        ///     Sensor: Motion: Speedometer Usage.
        /// </summary>
        public static readonly Usage MotionSpeedometer = Instance.Create(0x0078, "Motion: Speedometer");
        /// <summary>
        ///     Sensor: Motion: Accelerometer Usage.
        /// </summary>
        public static readonly Usage MotionAccelerometer = Instance.Create(0x0079, "Motion: Accelerometer");
        /// <summary>
        ///     Sensor: Motion: Gyrometer Usage.
        /// </summary>
        public static readonly Usage MotionGyrometer = Instance.Create(0x007a, "Motion: Gyrometer");
        /// <summary>
        ///     Sensor: Motion: Gravity Vector Usage.
        /// </summary>
        public static readonly Usage MotionGravityVector = Instance.Create(0x007b, "Motion: Gravity Vector");
        /// <summary>
        ///     Sensor: Motion: Linear Accelerometer Usage.
        /// </summary>
        public static readonly Usage MotionLinearAccelerometer = Instance.Create(0x007c, "Motion: Linear Accelerometer");

        /// <summary>
        ///     Sensor: Orientation Usage.
        /// </summary>
        public static readonly Usage Orientation = Instance.Create(0x0080, "Orientation");
        /// <summary>
        ///     Sensor: Orientation: Compass 1D Usage.
        /// </summary>
        public static readonly Usage OrientationCompass1D = Instance.Create(0x0081, "Orientation: Compass 1D");
        /// <summary>
        ///     Sensor: Orientation: Compass 2D Usage.
        /// </summary>
        public static readonly Usage OrientationCompass2D = Instance.Create(0x0082, "Orientation: Compass 2D");
        /// <summary>
        ///     Sensor: Orientation: Compass 3D Usage.
        /// </summary>
        public static readonly Usage OrientationCompass3D = Instance.Create(0x0083, "Orientation: Compass 3D");
        /// <summary>
        ///     Sensor: Orientation: Inclinometer 1D Usage.
        /// </summary>
        public static readonly Usage OrientationInclinometer1D = Instance.Create(0x0084, "Orientation: Inclinometer 1D");
        /// <summary>
        ///     Sensor: Orientation: Inclinometer 2D Usage.
        /// </summary>
        public static readonly Usage OrientationInclinometer2D = Instance.Create(0x0085, "Orientation: Inclinometer 2D");
        /// <summary>
        ///     Sensor: Orientation: Inclinometer 3D Usage.
        /// </summary>
        public static readonly Usage OrientationInclinometer3D = Instance.Create(0x0086, "Orientation: Inclinometer 3D");
        /// <summary>
        ///     Sensor: Orientation: Distance 1D Usage.
        /// </summary>
        public static readonly Usage OrientationDistance1D = Instance.Create(0x0087, "Orientation: Distance 1D");
        /// <summary>
        ///     Sensor: Orientation: Distance 2D Usage.
        /// </summary>
        public static readonly Usage OrientationDistance2D = Instance.Create(0x0088, "Orientation: Distance 2D");
        /// <summary>
        ///     Sensor: Orientation: Distance 3D Usage.
        /// </summary>
        public static readonly Usage OrientationDistance3D = Instance.Create(0x0089, "Orientation: Distance 3D");
        /// <summary>
        ///     Sensor: Orientation: Device Orientation Usage.
        /// </summary>
        public static readonly Usage OrientationDeviceOrientation = Instance.Create(0x008a, "Orientation: Device Orientation");
        /// <summary>
        ///     Sensor: Orientation: Compass Usage.
        /// </summary>
        public static readonly Usage OrientationCompass = Instance.Create(0x008b, "Orientation: Compass");
        /// <summary>
        ///     Sensor: Orientation: Inclinometer Usage.
        /// </summary>
        public static readonly Usage OrientationInclinometer = Instance.Create(0x008c, "Orientation: Inclinometer");
        /// <summary>
        ///     Sensor: Orientation: Distance Usage.
        /// </summary>
        public static readonly Usage OrientationDistance = Instance.Create(0x008d, "Orientation: Distance");
        /// <summary>
        ///     Sensor: Orientation: Relative Orientation Usage.
        /// </summary>
        public static readonly Usage OrientationRelativeOrientation = Instance.Create(0x008e, "Orientation: Relative Orientation");
        /// <summary>
        ///     Sensor: Orientation: Simple Orientation Usage.
        /// </summary>
        public static readonly Usage OrientationSimpleOrientation = Instance.Create(0x008f, "Orientation: Simple Orientation");
        /// <summary>
        ///     Sensor: Scanner Usage.
        /// </summary>
        public static readonly Usage Scanner = Instance.Create(0x0090, "Scanner");
        /// <summary>
        ///     Sensor: Scanner: Barcode Usage.
        /// </summary>
        public static readonly Usage ScannerBarcode = Instance.Create(0x0091, "Scanner: Barcode");
        /// <summary>
        ///     Sensor: Scanner: RFID Usage.
        /// </summary>
        public static readonly Usage ScannerRFID = Instance.Create(0x0092, "Scanner: RFID");
        /// <summary>
        ///     Sensor: Scanner: NFC Usage.
        /// </summary>
        public static readonly Usage ScannerNFC = Instance.Create(0x0093, "Scanner: NFC");

        /// <summary>
        ///     Sensor: Time Usage.
        /// </summary>
        public static readonly Usage Time = Instance.Create(0x00a0, "Time");
        /// <summary>
        ///     Sensor: Time: Alarm Timer Usage.
        /// </summary>
        public static readonly Usage TimeAlarmTimer = Instance.Create(0x00a1, "Time: Alarm Timer");
        /// <summary>
        ///     Sensor: Time: Real Time Clock Usage.
        /// </summary>
        public static readonly Usage TimeRealTimeClock = Instance.Create(0x00a2, "Time: Real Time Clock");

        /// <summary>
        ///     Sensor: Personal Activity Usage.
        /// </summary>
        public static readonly Usage PersonalActivity = Instance.Create(0x00b0, "Personal Activity");
        /// <summary>
        ///     Sensor: Personal Activity: Activity Detection Usage.
        /// </summary>
        public static readonly Usage PersonalActivityActivityDetection = Instance.Create(0x00b1, "Personal Activity: Activity Detection");
        /// <summary>
        ///     Sensor: Personal Activity: Device Position Usage.
        /// </summary>
        public static readonly Usage PersonalActivityDevicePosition = Instance.Create(0x00b2, "Personal Activity: Device Position");
        /// <summary>
        ///     Sensor: Personal Activity: Pedometer Usage.
        /// </summary>
        public static readonly Usage PersonalActivityPedometer = Instance.Create(0x00b3, "Personal Activity: Pedometer");
        /// <summary>
        ///     Sensor: Personal Activity: Step Detection Usage.
        /// </summary>
        public static readonly Usage PersonalActivityStepDetection = Instance.Create(0x00b4, "Personal Activity: Step Detection");

        /// <summary>
        ///     Sensor: Orientation Extended Usage.
        /// </summary>
        public static readonly Usage OrientationExtended = Instance.Create(0x00c0, "Orientation Extended");
        /// <summary>
        ///     Sensor: Orientation Extended: Geomagnetic Orientation Usage.
        /// </summary>
        public static readonly Usage OrientationExtendedGeomagneticOrientation = Instance.Create(0x00c1, "Orientation Extended: Geomagnetic Orientation");
        /// <summary>
        ///     Sensor: Orientation Extended: Magnetometer Usage.
        /// </summary>
        public static readonly Usage OrientationExtendedMagnetometer = Instance.Create(0x00c2, "Orientation Extended: Magnetometer");
        /// <summary>
        ///     Sensor: Other Usage.
        /// </summary>
        public static readonly Usage Other = Instance.Create(0x00e0, "Other");
        /// <summary>
        ///     Sensor: Other: Custom Usage.
        /// </summary>
        public static readonly Usage OtherCustom = Instance.Create(0x00e1, "Other: Custom");
        /// <summary>
        ///     Sensor: Other: Generic Usage.
        /// </summary>
        public static readonly Usage OtherGeneric = Instance.Create(0x00e2, "Other: Generic");
        /// <summary>
        ///     Sensor: Other: Generic Enumerator Usage.
        /// </summary>
        public static readonly Usage OtherGenericEnumerator = Instance.Create(0x00e3, "Other: Generic Enumerator");

        /// <summary>
        ///     Sensor: Event: Sensor State Usage.
        /// </summary>
        public static readonly Usage EventSensorState = Instance.Create(0x0201, "Event: Sensor State");
        /// <summary>
        ///     Sensor: Event: Sensor Event Usage.
        /// </summary>
        public static readonly Usage EventSensorEvent = Instance.Create(0x0202, "Event: Sensor Event");

        /// <summary>
        ///     Sensor: Property: Friendly Name Usage.
        /// </summary>
        public static readonly Usage PropertyFriendlyName = Instance.Create(0x0301, "Property: Friendly Name");
        /// <summary>
        ///     Sensor: Property: Persistent Unique ID Usage.
        /// </summary>
        public static readonly Usage PropertyPersistentUniqueID = Instance.Create(0x0302, "Property: Persistent Unique ID");
        /// <summary>
        ///     Sensor: Property: Sensor Status Usage.
        /// </summary>
        public static readonly Usage PropertySensorStatus = Instance.Create(0x0303, "Property: Sensor Status");
        /// <summary>
        ///     Sensor: Property: Minimum Report Interval Usage.
        /// </summary>
        public static readonly Usage PropertyMinimumReportInterval = Instance.Create(0x0304, "Property: Minimum Report Interval");
        /// <summary>
        ///     Sensor: Property: Sensor Manufacturer Usage.
        /// </summary>
        public static readonly Usage PropertySensorManufacturer = Instance.Create(0x0305, "Property: Sensor Manufacturer");
        /// <summary>
        ///     Sensor: Property: Sensor Model Usage.
        /// </summary>
        public static readonly Usage PropertySensorModel = Instance.Create(0x0306, "Property: Sensor Model");
        /// <summary>
        ///     Sensor: Property: Sensor Serial Number Usage.
        /// </summary>
        public static readonly Usage PropertySensorSerialNumber = Instance.Create(0x0307, "Property: Sensor Serial Number");
        /// <summary>
        ///     Sensor: Property: Sensor Description Usage.
        /// </summary>
        public static readonly Usage PropertySensorDescription = Instance.Create(0x0308, "Property: Sensor Description");
        /// <summary>
        ///     Sensor: Property: Sensor Connection Type Usage.
        /// </summary>
        public static readonly Usage PropertySensorConnectionType = Instance.Create(0x0309, "Property: Sensor Connection Type");
        /// <summary>
        ///     Sensor: Property: Sensor Device Path Usage.
        /// </summary>
        public static readonly Usage PropertySensorDevicePath = Instance.Create(0x030a, "Property: Sensor Device Path");
        /// <summary>
        ///     Sensor: Property: Sensor Hardware Revision Usage.
        /// </summary>
        public static readonly Usage PropertySensorHardwareRevision = Instance.Create(0x030b, "Property: Sensor Hardware Revision");
        /// <summary>
        ///     Sensor: Property: Sensor Firmware Revision Usage.
        /// </summary>
        public static readonly Usage PropertySensorFirmwareRevision = Instance.Create(0x030c, "Property: Sensor Firmware Revision");
        /// <summary>
        ///     Sensor: Property: Release Date Usage.
        /// </summary>
        public static readonly Usage PropertyReleaseDate = Instance.Create(0x030d, "Property: Release Date");
        /// <summary>
        ///     Sensor: Property: Report Interval Usage.
        /// </summary>
        public static readonly Usage PropertyReportInterval = Instance.Create(0x030e, "Property: Report Interval");
        /// <summary>
        ///     Sensor: Property: Change Sensitivity Absolute Usage.
        /// </summary>
        public static readonly Usage PropertyChangeSensitivityAbsolute = Instance.Create(0x030f, "Property: Change Sensitivity Absolute");
        /// <summary>
        ///     Sensor: Property: Change Sensitivity Percent of Range Usage.
        /// </summary>
        public static readonly Usage PropertyChangeSensitivityPercentOfRange = Instance.Create(0x0310, "Property: Change Sensitivity Percent of Range");
        /// <summary>
        ///     Sensor: Property: Change Sensitivity Percent Relative Usage.
        /// </summary>
        public static readonly Usage PropertyChangeSensitivityPercentRelative = Instance.Create(0x0311, "Property: Change Sensitivity Percent Relative");
        /// <summary>
        ///     Sensor: Property: Accuracy Usage.
        /// </summary>
        public static readonly Usage PropertyAccuracy = Instance.Create(0x0312, "Property: Accuracy");
        /// <summary>
        ///     Sensor: Property: Resolution Usage.
        /// </summary>
        public static readonly Usage PropertyResolution = Instance.Create(0x0313, "Property: Resolution");
        /// <summary>
        ///     Sensor: Property: Maximum Usage.
        /// </summary>
        public static readonly Usage PropertyMaximum = Instance.Create(0x0314, "Property: Maximum");
        /// <summary>
        ///     Sensor: Property: Minimum Usage.
        /// </summary>
        public static readonly Usage PropertyMinimum = Instance.Create(0x0315, "Property: Minimum");
        /// <summary>
        ///     Sensor: Property: Reporting State Usage.
        /// </summary>
        public static readonly Usage PropertyReportingState = Instance.Create(0x0316, "Property: Reporting State");
        /// <summary>
        ///     Sensor: Property: Sampling Rate Usage.
        /// </summary>
        public static readonly Usage PropertySamplingRate = Instance.Create(0x0317, "Property: Sampling Rate");
        /// <summary>
        ///     Sensor: Property: Response Curve Usage.
        /// </summary>
        public static readonly Usage PropertyResponseCurve = Instance.Create(0x0318, "Property: Response Curve");
        /// <summary>
        ///     Sensor: Property: Power State Usage.
        /// </summary>
        public static readonly Usage PropertyPowerState = Instance.Create(0x0319, "Property: Power State");
        /// <summary>
        ///     Sensor: Property: Maximum FIFO Events Usage.
        /// </summary>
        public static readonly Usage PropertyMaximumFIFOEvents = Instance.Create(0x031a, "Property: Maximum FIFO Events");
        /// <summary>
        ///     Sensor: Property: Report Latency Usage.
        /// </summary>
        public static readonly Usage PropertyReportLatency = Instance.Create(0x031b, "Property: Report Latency");
        /// <summary>
        ///     Sensor: Property: Flush FIFO Events Usage.
        /// </summary>
        public static readonly Usage PropertyFlushFIFOEvents = Instance.Create(0x031c, "Property: Flush FIFO Events");
        /// <summary>
        ///     Sensor: Property: Maximum Power Consumption Usage.
        /// </summary>
        public static readonly Usage PropertyMaximumPowerConsumption = Instance.Create(0x031d, "Property: Maximum Power Consumption");

        /// <summary>
        ///     Sensor: Data Field: Location Usage.
        /// </summary>
        public static readonly Usage DataFieldLocation = Instance.Create(0x0400, "Data Field: Location");
        /// <summary>
        ///     Sensor: Data Field: Altitude Antenna Sea Level Usage.
        /// </summary>
        public static readonly Usage DataFieldAltitudeAntennaSeaLevel = Instance.Create(0x0402, "Data Field: Altitude Antenna Sea Level");
        /// <summary>
        ///     Sensor: Data Field: Differential Reference Station ID Usage.
        /// </summary>
        public static readonly Usage DataFieldDifferentialReferenceStationID = Instance.Create(0x0403, "Data Field: Differential Reference Station ID");
        /// <summary>
        ///     Sensor: Data Field: Altitude Ellipsoid Error Usage.
        /// </summary>
        public static readonly Usage DataFieldAltitudeEllipsoidError = Instance.Create(0x0404, "Data Field: Altitude Ellipsoid Error");
        /// <summary>
        ///     Sensor: Data Field: Altitude Ellipsoid Usage.
        /// </summary>
        public static readonly Usage DataFieldAltitudeEllipsoid = Instance.Create(0x0405, "Data Field: Altitude Ellipsoid");
        /// <summary>
        ///     Sensor: Data Field: Altitude Sea Level Error Usage.
        /// </summary>
        public static readonly Usage DataFieldAltitudeSeaLevelError = Instance.Create(0x0406, "Data Field: Altitude Sea Level Error");
        /// <summary>
        ///     Sensor: Data Field: Altitude Sea Level Usage.
        /// </summary>
        public static readonly Usage DataFieldAltitudeSeaLevel = Instance.Create(0x0407, "Data Field: Altitude Sea Level");
        /// <summary>
        ///     Sensor: Data Field: Differential GPS Data Age Usage.
        /// </summary>
        public static readonly Usage DataFieldDifferentialGPSDataAge = Instance.Create(0x0408, "Data Field: Differential GPS Data Age");
        /// <summary>
        ///     Sensor: Data Field: Error Radius Usage.
        /// </summary>
        public static readonly Usage DataFieldErrorRadius = Instance.Create(0x0409, "Data Field: Error Radius");
        /// <summary>
        ///     Sensor: Data Field: Fix Quality Usage.
        /// </summary>
        public static readonly Usage DataFieldFixQuality = Instance.Create(0x040a, "Data Field: Fix Quality");
        /// <summary>
        ///     Sensor: Data Field: Fix Type Usage.
        /// </summary>
        public static readonly Usage DataFieldFixType = Instance.Create(0x040b, "Data Field: Fix Type");
        /// <summary>
        ///     Sensor: Data Field: Geoidal Separation Usage.
        /// </summary>
        public static readonly Usage DataFieldGeoidalSeparation = Instance.Create(0x040c, "Data Field: Geoidal Separation");
        /// <summary>
        ///     Sensor: Data Field: GPS Operation Mode Usage.
        /// </summary>
        public static readonly Usage DataFieldGPSOperationMode = Instance.Create(0x040d, "Data Field: GPS Operation Mode");
        /// <summary>
        ///     Sensor: Data Field: GPS Selection Mode Usage.
        /// </summary>
        public static readonly Usage DataFieldGPSSelectionMode = Instance.Create(0x040e, "Data Field: GPS Selection Mode");
        /// <summary>
        ///     Sensor: Data Field: GPS Status Usage.
        /// </summary>
        public static readonly Usage DataFieldGPSStatus = Instance.Create(0x040f, "Data Field: GPS Status");
        /// <summary>
        ///     Sensor: Data Field: Position Dilution of Precision Usage.
        /// </summary>
        public static readonly Usage DataFieldPositionDilutionOfPrecision = Instance.Create(0x0410, "Data Field: Position Dilution of Precision");
        /// <summary>
        ///     Sensor: Data Field: Horizontal Dilution of Precision Usage.
        /// </summary>
        public static readonly Usage DataFieldHorizontalDilutionOfPrecision = Instance.Create(0x0411, "Data Field: Horizontal Dilution of Precision");
        /// <summary>
        ///     Sensor: Data Field: Vertical Dilution of Precision Usage.
        /// </summary>
        public static readonly Usage DataFieldVerticalDilutionOfPrecision = Instance.Create(0x0412, "Data Field: Vertical Dilution of Precision");
        /// <summary>
        ///     Sensor: Data Field: Latitude Usage.
        /// </summary>
        public static readonly Usage DataFieldLatitude = Instance.Create(0x0413, "Data Field: Latitude");
        /// <summary>
        ///     Sensor: Data Field: Longitude Usage.
        /// </summary>
        public static readonly Usage DataFieldLongitude = Instance.Create(0x0414, "Data Field: Longitude");
        /// <summary>
        ///     Sensor: Data Field: True Heading Usage.
        /// </summary>
        public static readonly Usage DataFieldTrueHeading = Instance.Create(0x0415, "Data Field: True Heading");
        /// <summary>
        ///     Sensor: Data Field: Magnetic Heading Usage.
        /// </summary>
        public static readonly Usage DataFieldMagneticHeading = Instance.Create(0x0416, "Data Field: Magnetic Heading");
        /// <summary>
        ///     Sensor: Data Field: Magnetic Variation Usage.
        /// </summary>
        public static readonly Usage DataFieldMagneticVariation = Instance.Create(0x0417, "Data Field: Magnetic Variation");
        /// <summary>
        ///     Sensor: Data Field: Speed Usage.
        /// </summary>
        public static readonly Usage DataFieldSpeed = Instance.Create(0x0418, "Data Field: Speed");
        /// <summary>
        ///     Sensor: Data Field: Satellites in View Usage.
        /// </summary>
        public static readonly Usage DataFieldSatellitesInView = Instance.Create(0x0419, "Data Field: Satellites in View");
        /// <summary>
        ///     Sensor: Data Field: Satellites in View Azimuth Usage.
        /// </summary>
        public static readonly Usage DataFieldSatellitesInViewAzimuth = Instance.Create(0x041a, "Data Field: Satellites in View Azimuth");
        /// <summary>
        ///     Sensor: Data Field: Satellites in View Elevation Usage.
        /// </summary>
        public static readonly Usage DataFieldSatellitesInViewElevation = Instance.Create(0x041b, "Data Field: Satellites in View Elevation");
        /// <summary>
        ///     Sensor: Data Field: Satellites in View IDs Usage.
        /// </summary>
        public static readonly Usage DataFieldSatellitesInViewIDs = Instance.Create(0x041c, "Data Field: Satellites in View IDs");
        /// <summary>
        ///     Sensor: Data Field: Satellites in View PRNs Usage.
        /// </summary>
        public static readonly Usage DataFieldSatellitesInViewPRNs = Instance.Create(0x041d, "Data Field: Satellites in View PRNs");
        /// <summary>
        ///     Sensor: Data Field: Satellites in View S/N Ratios Usage.
        /// </summary>
        public static readonly Usage DataFieldSatellitesInViewSNRatios = Instance.Create(0x041e, "Data Field: Satellites in View S/N Ratios");
        /// <summary>
        ///     Sensor: Data Field: Satellites Used Count Usage.
        /// </summary>
        public static readonly Usage DataFieldSatellitesUsedCount = Instance.Create(0x041f, "Data Field: Satellites Used Count");
        /// <summary>
        ///     Sensor: Data Field: Satellites Used PRNs Usage.
        /// </summary>
        public static readonly Usage DataFieldSatellitesUsedPRNs = Instance.Create(0x0420, "Data Field: Satellites Used PRNs");
        /// <summary>
        ///     Sensor: Data Field: NMEA Sentence Usage.
        /// </summary>
        public static readonly Usage DataFieldNMEASentence = Instance.Create(0x0421, "Data Field: NMEA Sentence");
        /// <summary>
        ///     Sensor: Data Field: Address Line 1 Usage.
        /// </summary>
        public static readonly Usage DataFieldAddressLine1 = Instance.Create(0x0422, "Data Field: Address Line 1");
        /// <summary>
        ///     Sensor: Data Field: Address Line 2 Usage.
        /// </summary>
        public static readonly Usage DataFieldAddressLine2 = Instance.Create(0x0423, "Data Field: Address Line 2");
        /// <summary>
        ///     Sensor: Data Field: City Usage.
        /// </summary>
        public static readonly Usage DataFieldCity = Instance.Create(0x0424, "Data Field: City");
        /// <summary>
        ///     Sensor: Data Field: State or Province Usage.
        /// </summary>
        public static readonly Usage DataFieldStateOrProvince = Instance.Create(0x0425, "Data Field: State or Province");
        /// <summary>
        ///     Sensor: Data Field: Country or Region (ISO 3166) Usage.
        /// </summary>
        public static readonly Usage DataFieldCountryOrRegionISO3166 = Instance.Create(0x0426, "Data Field: Country or Region (ISO 3166)");
        /// <summary>
        ///     Sensor: Data Field: Postal Code Usage.
        /// </summary>
        public static readonly Usage DataFieldPostalCode = Instance.Create(0x0427, "Data Field: Postal Code");

        /// <summary>
        ///     Sensor: Property: Location Desired Accuracy Usage.
        /// </summary>
        public static readonly Usage PropertyLocationDesiredAccuracy = Instance.Create(0x042b, "Property: Location Desired Accuracy");

        /// <summary>
        ///     Sensor: Data Field: Environmental Usage.
        /// </summary>
        public static readonly Usage DataFieldEnvironmental = Instance.Create(0x0430, "Data Field: Environmental");
        /// <summary>
        ///     Sensor: Data Field: Atmospheric Pressure Usage.
        /// </summary>
        public static readonly Usage DataFieldAtmosphericPressure = Instance.Create(0x0431, "Data Field: Atmospheric Pressure");
        /// <summary>
        ///     Sensor: Data Field: Relative Humidity Usage.
        /// </summary>
        public static readonly Usage DataFieldRelativeHumidity = Instance.Create(0x0433, "Data Field: Relative Humidity");
        /// <summary>
        ///     Sensor: Data Field: Temperature Usage.
        /// </summary>
        public static readonly Usage DataFieldTemperature = Instance.Create(0x0434, "Data Field: Temperature");
        /// <summary>
        ///     Sensor: Data Field: Wind Direction Usage.
        /// </summary>
        public static readonly Usage DataFieldWindDirection = Instance.Create(0x0435, "Data Field: Wind Direction");
        /// <summary>
        ///     Sensor: Data Field: Wind Speed Usage.
        /// </summary>
        public static readonly Usage DataFieldWindSpeed = Instance.Create(0x0436, "Data Field: Wind Speed");
        /// <summary>
        ///     Sensor: Data Field: Air Quality Index Usage.
        /// </summary>
        public static readonly Usage DataFieldAirQualityIndex = Instance.Create(0x0437, "Data Field: Air Quality Index");
        /// <summary>
        ///     Sensor: Data Field: Equivalent CO2 Usage.
        /// </summary>
        public static readonly Usage DataFieldEquivalentCO2 = Instance.Create(0x0438, "Data Field: Equivalent CO2");
        /// <summary>
        ///     Sensor: Data Field: Volatile Organic Compound Concentration Usage.
        /// </summary>
        public static readonly Usage DataFieldVolatileOrganicCompoundConcentration = Instance.Create(0x0439, "Data Field: Volatile Organic Compound Concentration");

        /// <summary>
        ///     Sensor: Property: Environmental Usage.
        /// </summary>
        public static readonly Usage PropertyEnvironmental = Instance.Create(0x0440, "Property: Environmental");
        /// <summary>
        ///     Sensor: Property: Reference Pressure (default Sel  Usage.
        /// </summary>
        public static readonly Usage PropertyReferencePressureDefaultSel = Instance.Create(0x0441, "Property: Reference Pressure (default Sel ");

        /// <summary>
        ///     Sensor: Data Field: Motion Usage.
        /// </summary>
        public static readonly Usage DataFieldMotion = Instance.Create(0x0450, "Data Field: Motion");
        /// <summary>
        ///     Sensor: Data Field: Motion State Usage.
        /// </summary>
        public static readonly Usage DataFieldMotionState = Instance.Create(0x0451, "Data Field: Motion State");
        /// <summary>
        ///     Sensor: Data Field: Acceleration Usage.
        /// </summary>
        public static readonly Usage DataFieldAcceleration = Instance.Create(0x0452, "Data Field: Acceleration");
        /// <summary>
        ///     Sensor: Data Field: Acceleration Axis X Usage.
        /// </summary>
        public static readonly Usage DataFieldAccelerationAxisX = Instance.Create(0x0453, "Data Field: Acceleration Axis X");
        /// <summary>
        ///     Sensor: Data Field: Acceleration Axis Y Usage.
        /// </summary>
        public static readonly Usage DataFieldAccelerationAxisY = Instance.Create(0x0454, "Data Field: Acceleration Axis Y");
        /// <summary>
        ///     Sensor: Data Field: Acceleration Axis Z Usage.
        /// </summary>
        public static readonly Usage DataFieldAccelerationAxisZ = Instance.Create(0x0455, "Data Field: Acceleration Axis Z");
        /// <summary>
        ///     Sensor: Data Field: Angular Velocity Usage.
        /// </summary>
        public static readonly Usage DataFieldAngularVelocity = Instance.Create(0x0456, "Data Field: Angular Velocity");
        /// <summary>
        ///     Sensor: Data Field: Angular Velocity X about Axis Usage.
        /// </summary>
        public static readonly Usage DataFieldAngularVelocityXAboutAxis = Instance.Create(0x0457, "Data Field: Angular Velocity X about Axis");
        /// <summary>
        ///     Sensor: Data Field: Angular Velocity Y about Axis Usage.
        /// </summary>
        public static readonly Usage DataFieldAngularVelocityYAboutAxis = Instance.Create(0x0458, "Data Field: Angular Velocity Y about Axis");
        /// <summary>
        ///     Sensor: Data Field: Angular Velocity Z about Axis Usage.
        /// </summary>
        public static readonly Usage DataFieldAngularVelocityZAboutAxis = Instance.Create(0x0459, "Data Field: Angular Velocity Z about Axis");
        /// <summary>
        ///     Sensor: Data Field: Angular Position Usage.
        /// </summary>
        public static readonly Usage DataFieldAngularPosition = Instance.Create(0x045a, "Data Field: Angular Position");
        /// <summary>
        ///     Sensor: Data Field: Angular Position about X Axis Usage.
        /// </summary>
        public static readonly Usage DataFieldAngularPositionAboutXAxis = Instance.Create(0x045b, "Data Field: Angular Position about X Axis");
        /// <summary>
        ///     Sensor: Data Field: Angular Position about Y Axis Usage.
        /// </summary>
        public static readonly Usage DataFieldAngularPositionAboutYAxis = Instance.Create(0x045c, "Data Field: Angular Position about Y Axis");
        /// <summary>
        ///     Sensor: Data Field: Angular Position about Z Axis Usage.
        /// </summary>
        public static readonly Usage DataFieldAngularPositionAboutZAxis = Instance.Create(0x045d, "Data Field: Angular Position about Z Axis");
        /// <summary>
        ///     Sensor: Data Field: Motion Speed Usage.
        /// </summary>
        public static readonly Usage DataFieldMotionSpeed = Instance.Create(0x045e, "Data Field: Motion Speed");
        /// <summary>
        ///     Sensor: Data Field: Motion Intensity (percent) Usage.
        /// </summary>
        public static readonly Usage DataFieldMotionIntensityPercent = Instance.Create(0x045f, "Data Field: Motion Intensity (percent)");

        /// <summary>
        ///     Sensor: Data Field: Orientation Usage.
        /// </summary>
        public static readonly Usage DataFieldOrientation = Instance.Create(0x0470, "Data Field: Orientation");
        /// <summary>
        ///     Sensor: Data Field: Heading Usage.
        /// </summary>
        public static readonly Usage DataFieldHeading = Instance.Create(0x0471, "Data Field: Heading");
        /// <summary>
        ///     Sensor: Data Field: Heading X Axis Usage.
        /// </summary>
        public static readonly Usage DataFieldHeadingXAxis = Instance.Create(0x0472, "Data Field: Heading X Axis");
        /// <summary>
        ///     Sensor: Data Field: Heading Y Axis Usage.
        /// </summary>
        public static readonly Usage DataFieldHeadingYAxis = Instance.Create(0x0473, "Data Field: Heading Y Axis");
        /// <summary>
        ///     Sensor: Data Field: Heading Z Axis Usage.
        /// </summary>
        public static readonly Usage DataFieldHeadingZAxis = Instance.Create(0x0474, "Data Field: Heading Z Axis");
        /// <summary>
        ///     Sensor: Data Field: Heading Compensated Magnetic North Usage.
        /// </summary>
        public static readonly Usage DataFieldHeadingCompensatedMagneticNorth = Instance.Create(0x0475, "Data Field: Heading Compensated Magnetic North");
        /// <summary>
        ///     Sensor: Data Field: Heading Compensated True North Usage.
        /// </summary>
        public static readonly Usage DataFieldHeadingCompensatedTrueNorth = Instance.Create(0x0476, "Data Field: Heading Compensated True North");
        /// <summary>
        ///     Sensor: Data Field: Heading Magnetic North Usage.
        /// </summary>
        public static readonly Usage DataFieldHeadingMagneticNorth = Instance.Create(0x0477, "Data Field: Heading Magnetic North");
        /// <summary>
        ///     Sensor: Data Field: Heading True North Usage.
        /// </summary>
        public static readonly Usage DataFieldHeadingTrueNorth = Instance.Create(0x0478, "Data Field: Heading True North");
        /// <summary>
        ///     Sensor: Data Field: Distance Usage.
        /// </summary>
        public static readonly Usage DataFieldDistance = Instance.Create(0x0479, "Data Field: Distance");
        /// <summary>
        ///     Sensor: Data Field: Distance X Axis Usage.
        /// </summary>
        public static readonly Usage DataFieldDistanceXAxis = Instance.Create(0x047a, "Data Field: Distance X Axis");
        /// <summary>
        ///     Sensor: Data Field: Distance Y Axis Usage.
        /// </summary>
        public static readonly Usage DataFieldDistanceYAxis = Instance.Create(0x047b, "Data Field: Distance Y Axis");
        /// <summary>
        ///     Sensor: Data Field: Distance Z Axis Usage.
        /// </summary>
        public static readonly Usage DataFieldDistanceZAxis = Instance.Create(0x047c, "Data Field: Distance Z Axis");
        /// <summary>
        ///     Sensor: Data Field: Distance Out-of-Range Usage.
        /// </summary>
        public static readonly Usage DataFieldDistanceOutofRange = Instance.Create(0x047d, "Data Field: Distance Out-of-Range");
        /// <summary>
        ///     Sensor: Data Field: Tilt Usage.
        /// </summary>
        public static readonly Usage DataFieldTilt = Instance.Create(0x047e, "Data Field: Tilt");
        /// <summary>
        ///     Sensor: Data Field: Tilt X Axis Usage.
        /// </summary>
        public static readonly Usage DataFieldTiltXAxis = Instance.Create(0x047f, "Data Field: Tilt X Axis");
        /// <summary>
        ///     Sensor: Data Field: Tilt Y Axis Usage.
        /// </summary>
        public static readonly Usage DataFieldTiltYAxis = Instance.Create(0x0480, "Data Field: Tilt Y Axis");
        /// <summary>
        ///     Sensor: Data Field: Tilt Z Axis Usage.
        /// </summary>
        public static readonly Usage DataFieldTiltZAxis = Instance.Create(0x0481, "Data Field: Tilt Z Axis");
        /// <summary>
        ///     Sensor: Data Field: Rotation Matrix Usage.
        /// </summary>
        public static readonly Usage DataFieldRotationMatrix = Instance.Create(0x0482, "Data Field: Rotation Matrix");
        /// <summary>
        ///     Sensor: Data Field: Quaternion Usage.
        /// </summary>
        public static readonly Usage DataFieldQuaternion = Instance.Create(0x0483, "Data Field: Quaternion");
        /// <summary>
        ///     Sensor: Data Field: Magnetic Flux Usage.
        /// </summary>
        public static readonly Usage DataFieldMagneticFlux = Instance.Create(0x0484, "Data Field: Magnetic Flux");
        /// <summary>
        ///     Sensor: Data Field: Magnetic Flux X Axis Usage.
        /// </summary>
        public static readonly Usage DataFieldMagneticFluxXAxis = Instance.Create(0x0485, "Data Field: Magnetic Flux X Axis");
        /// <summary>
        ///     Sensor: Data Field: Magnetic Flux Y Axis Usage.
        /// </summary>
        public static readonly Usage DataFieldMagneticFluxYAxis = Instance.Create(0x0486, "Data Field: Magnetic Flux Y Axis");
        /// <summary>
        ///     Sensor: Data Field: Magnetic Flux Z Axis Usage.
        /// </summary>
        public static readonly Usage DataFieldMagneticFluxZAxis = Instance.Create(0x0487, "Data Field: Magnetic Flux Z Axis");
        /// <summary>
        ///     Sensor: Data Field: Magnetometer Accuracy Usage.
        /// </summary>
        public static readonly Usage DataFieldMagnetometerAccuracy = Instance.Create(0x0488, "Data Field: Magnetometer Accuracy");
        /// <summary>
        ///     Sensor: Data Field: Simple Orientation Direction Usage.
        /// </summary>
        public static readonly Usage DataFieldSimpleOrientationDirection = Instance.Create(0x0489, "Data Field: Simple Orientation Direction");

        /// <summary>
        ///     Sensor: Data Field: Mechanical Usage.
        /// </summary>
        public static readonly Usage DataFieldMechanical = Instance.Create(0x0490, "Data Field: Mechanical");
        /// <summary>
        ///     Sensor: Data Field: Boolean Switch State Usage.
        /// </summary>
        public static readonly Usage DataFieldBooleanSwitchState = Instance.Create(0x0491, "Data Field: Boolean Switch State");
        /// <summary>
        ///     Sensor: Data Field: Boolean Switch Array States Usage.
        /// </summary>
        public static readonly Usage DataFieldBooleanSwitchArrayStates = Instance.Create(0x0492, "Data Field: Boolean Switch Array States");
        /// <summary>
        ///     Sensor: Data Field: Multivalue Switch Value Usage.
        /// </summary>
        public static readonly Usage DataFieldMultivalueSwitchValue = Instance.Create(0x0493, "Data Field: Multivalue Switch Value");
        /// <summary>
        ///     Sensor: Data Field: Force Usage.
        /// </summary>
        public static readonly Usage DataFieldForce = Instance.Create(0x0494, "Data Field: Force");
        /// <summary>
        ///     Sensor: Data Field: Absolute Pressure Usage.
        /// </summary>
        public static readonly Usage DataFieldAbsolutePressure = Instance.Create(0x0495, "Data Field: Absolute Pressure");
        /// <summary>
        ///     Sensor: Data Field: Gauge Pressure Usage.
        /// </summary>
        public static readonly Usage DataFieldGaugePressure = Instance.Create(0x0496, "Data Field: Gauge Pressure");
        /// <summary>
        ///     Sensor: Data Field: Strain Usage.
        /// </summary>
        public static readonly Usage DataFieldStrain = Instance.Create(0x0497, "Data Field: Strain");
        /// <summary>
        ///     Sensor: Data Field: Weight Usage.
        /// </summary>
        public static readonly Usage DataFieldWeight = Instance.Create(0x0498, "Data Field: Weight");

        /// <summary>
        ///     Sensor: Property: Mechanical Usage.
        /// </summary>
        public static readonly Usage PropertyMechanical = Instance.Create(0x04a0, "Property: Mechanical");
        /// <summary>
        ///     Sensor: Property: Vibration State Usage.
        /// </summary>
        public static readonly Usage PropertyVibrationState = Instance.Create(0x04a1, "Property: Vibration State");
        /// <summary>
        ///     Sensor: Property: Forward Vibration Speed (percent) Usage.
        /// </summary>
        public static readonly Usage PropertyForwardVibrationSpeedPercent = Instance.Create(0x04a2, "Property: Forward Vibration Speed (percent)");
        /// <summary>
        ///     Sensor: Property: Backward Vibration Speed (percent) Usage.
        /// </summary>
        public static readonly Usage PropertyBackwardVibrationSpeedPercent = Instance.Create(0x04a3, "Property: Backward Vibration Speed (percent)");

        /// <summary>
        ///     Sensor: Data Field: Biometric Usage.
        /// </summary>
        public static readonly Usage DataFieldBiometric = Instance.Create(0x04b0, "Data Field: Biometric");
        /// <summary>
        ///     Sensor: Data Field: Human Presence Usage.
        /// </summary>
        public static readonly Usage DataFieldHumanPresence = Instance.Create(0x04b1, "Data Field: Human Presence");
        /// <summary>
        ///     Sensor: Data Field: Human Proximity Range Usage.
        /// </summary>
        public static readonly Usage DataFieldHumanProximityRange = Instance.Create(0x04b2, "Data Field: Human Proximity Range");
        /// <summary>
        ///     Sensor: Data Field: Human Proximity Out of Range Usage.
        /// </summary>
        public static readonly Usage DataFieldHumanProximityOutOfRange = Instance.Create(0x04b3, "Data Field: Human Proximity Out of Range");
        /// <summary>
        ///     Sensor: Data Field: Human Touch State Usage.
        /// </summary>
        public static readonly Usage DataFieldHumanTouchState = Instance.Create(0x04b4, "Data Field: Human Touch State");
        /// <summary>
        ///     Sensor: Data Field: Blood Pressure Usage.
        /// </summary>
        public static readonly Usage DataFieldBloodPressure = Instance.Create(0x04b5, "Data Field: Blood Pressure");
        /// <summary>
        ///     Sensor: Data Field: Blood Pressure Diastolic Usage.
        /// </summary>
        public static readonly Usage DataFieldBloodPressureDiastolic = Instance.Create(0x04b6, "Data Field: Blood Pressure Diastolic");
        /// <summary>
        ///     Sensor: Data Field: Blood Pressure Systolic Usage.
        /// </summary>
        public static readonly Usage DataFieldBloodPressureSystolic = Instance.Create(0x04b7, "Data Field: Blood Pressure Systolic");
        /// <summary>
        ///     Sensor: Data Field: Heart Rate (HeartbeatsPM) Usage.
        /// </summary>
        public static readonly Usage DataFieldHeartRateHeartbeatsPM = Instance.Create(0x04b8, "Data Field: Heart Rate (HeartbeatsPM)");
        /// <summary>
        ///     Sensor: Data Field: Resting Heart Rate (HeartbeatsPM) Usage.
        /// </summary>
        public static readonly Usage DataFieldRestingHeartRateHeartbeatsPM = Instance.Create(0x04b9, "Data Field: Resting Heart Rate (HeartbeatsPM)");
        /// <summary>
        ///     Sensor: Data Field: Heartbeat Interval Usage.
        /// </summary>
        public static readonly Usage DataFieldHeartbeatInterval = Instance.Create(0x04ba, "Data Field: Heartbeat Interval");
        /// <summary>
        ///     Sensor: Data Field: Respiratory Rate Usage.
        /// </summary>
        public static readonly Usage DataFieldRespiratoryRate = Instance.Create(0x04bb, "Data Field: Respiratory Rate");
        /// <summary>
        ///     Sensor: Data Field: SpO2 (percent) Usage.
        /// </summary>
        public static readonly Usage DataFieldSpO2Percent = Instance.Create(0x04bc, "Data Field: SpO2 (percent)");

        /// <summary>
        ///     Sensor: Data Field: Light Usage.
        /// </summary>
        public static readonly Usage DataFieldLight = Instance.Create(0x04d0, "Data Field: Light");
        /// <summary>
        ///     Sensor: Data Field: Illuminance Usage.
        /// </summary>
        public static readonly Usage DataFieldIlluminance = Instance.Create(0x04d1, "Data Field: Illuminance");
        /// <summary>
        ///     Sensor: Data Field: Color Temperature Usage.
        /// </summary>
        public static readonly Usage DataFieldColorTemperature = Instance.Create(0x04d2, "Data Field: Color Temperature");
        /// <summary>
        ///     Sensor: Data Field: Chromaticity Usage.
        /// </summary>
        public static readonly Usage DataFieldChromaticity = Instance.Create(0x04d3, "Data Field: Chromaticity");
        /// <summary>
        ///     Sensor: Data Field: Chromaticity X Usage.
        /// </summary>
        public static readonly Usage DataFieldChromaticityX = Instance.Create(0x04d4, "Data Field: Chromaticity X");
        /// <summary>
        ///     Sensor: Data Field: Chromaticity Y Usage.
        /// </summary>
        public static readonly Usage DataFieldChromaticityY = Instance.Create(0x04d5, "Data Field: Chromaticity Y");
        /// <summary>
        ///     Sensor: Data Field: Consumer IR Sentence Receive Usage.
        /// </summary>
        public static readonly Usage DataFieldConsumerIRSentenceReceive = Instance.Create(0x04d6, "Data Field: Consumer IR Sentence Receive");
        /// <summary>
        ///     Sensor: Data Field: Infrared Light Usage.
        /// </summary>
        public static readonly Usage DataFieldInfraredLight = Instance.Create(0x04d7, "Data Field: Infrared Light");
        /// <summary>
        ///     Sensor: Data Field: Red Light Usage.
        /// </summary>
        public static readonly Usage DataFieldRedLight = Instance.Create(0x04d8, "Data Field: Red Light");
        /// <summary>
        ///     Sensor: Data Field: Green Light Usage.
        /// </summary>
        public static readonly Usage DataFieldGreenLight = Instance.Create(0x04d9, "Data Field: Green Light");
        /// <summary>
        ///     Sensor: Data Field: Blue Light Usage.
        /// </summary>
        public static readonly Usage DataFieldBlueLight = Instance.Create(0x04da, "Data Field: Blue Light");
        /// <summary>
        ///     Sensor: Data Field: Ultraviolet A Light Usage.
        /// </summary>
        public static readonly Usage DataFieldUltravioletALight = Instance.Create(0x04db, "Data Field: Ultraviolet A Light");
        /// <summary>
        ///     Sensor: Data Field: Ultraviolet B Light Usage.
        /// </summary>
        public static readonly Usage DataFieldUltravioletBLight = Instance.Create(0x04dc, "Data Field: Ultraviolet B Light");
        /// <summary>
        ///     Sensor: Data Field: Ultraviolet Index Usage.
        /// </summary>
        public static readonly Usage DataFieldUltravioletIndex = Instance.Create(0x04dd, "Data Field: Ultraviolet Index");

        /// <summary>
        ///     Sensor: Property: Light Usage.
        /// </summary>
        public static readonly Usage PropertyLight = Instance.Create(0x04e0, "Property: Light");
        /// <summary>
        ///     Sensor: Property: Consumer IR Sentence Send Usage.
        /// </summary>
        public static readonly Usage PropertyConsumerIRSentenceSend = Instance.Create(0x04e1, "Property: Consumer IR Sentence Send");

        /// <summary>
        ///     Sensor: Data Field: Scanner Usage.
        /// </summary>
        public static readonly Usage DataFieldScanner = Instance.Create(0x04f0, "Data Field: Scanner");
        /// <summary>
        ///     Sensor: Data Field: RFID Tag 40 Bit Usage.
        /// </summary>
        public static readonly Usage DataFieldRFIDTag40Bit = Instance.Create(0x04f1, "Data Field: RFID Tag 40 Bit");
        /// <summary>
        ///     Sensor: Data Field: NFC Sentence Receive Usage.
        /// </summary>
        public static readonly Usage DataFieldNFCSentenceReceive = Instance.Create(0x04f2, "Data Field: NFC Sentence Receive");

        /// <summary>
        ///     Sensor: Property: Scanner Usage.
        /// </summary>
        public static readonly Usage PropertyScanner = Instance.Create(0x04f8, "Property: Scanner");
        /// <summary>
        ///     Sensor: Property: NFC Sentence Send Usage.
        /// </summary>
        public static readonly Usage PropertyNFCSentenceSend = Instance.Create(0x04f9, "Property: NFC Sentence Send");

        /// <summary>
        ///     Sensor: Data Field: Electrical Usage.
        /// </summary>
        public static readonly Usage DataFieldElectrical = Instance.Create(0x0500, "Data Field: Electrical");
        /// <summary>
        ///     Sensor: Data Field: Capacitance Usage.
        /// </summary>
        public static readonly Usage DataFieldCapacitance = Instance.Create(0x0501, "Data Field: Capacitance");
        /// <summary>
        ///     Sensor: Data Field: Current Usage.
        /// </summary>
        public static readonly Usage DataFieldCurrent = Instance.Create(0x0502, "Data Field: Current");
        /// <summary>
        ///     Sensor: Data Field: Electrical Power Usage.
        /// </summary>
        public static readonly Usage DataFieldElectricalPower = Instance.Create(0x0503, "Data Field: Electrical Power");
        /// <summary>
        ///     Sensor: Data Field: Inductance Usage.
        /// </summary>
        public static readonly Usage DataFieldInductance = Instance.Create(0x0504, "Data Field: Inductance");
        /// <summary>
        ///     Sensor: Data Field: Resistance Usage.
        /// </summary>
        public static readonly Usage DataFieldResistance = Instance.Create(0x0505, "Data Field: Resistance");
        /// <summary>
        ///     Sensor: Data Field: Voltage Usage.
        /// </summary>
        public static readonly Usage DataFieldVoltage = Instance.Create(0x0506, "Data Field: Voltage");
        /// <summary>
        ///     Sensor: Data Field: Frequency Usage.
        /// </summary>
        public static readonly Usage DataFieldFrequency = Instance.Create(0x0507, "Data Field: Frequency");
        /// <summary>
        ///     Sensor: Data Field: Period Usage.
        /// </summary>
        public static readonly Usage DataFieldPeriod = Instance.Create(0x0508, "Data Field: Period");
        /// <summary>
        ///     Sensor: Data Field: Percent of Range Usage.
        /// </summary>
        public static readonly Usage DataFieldPercentOfRange = Instance.Create(0x0509, "Data Field: Percent of Range");

        /// <summary>
        ///     Sensor: Data Field: Time Usage.
        /// </summary>
        public static readonly Usage DataFieldTime = Instance.Create(0x0520, "Data Field: Time");
        /// <summary>
        ///     Sensor: Data Field: Year Usage.
        /// </summary>
        public static readonly Usage DataFieldYear = Instance.Create(0x0521, "Data Field: Year");
        /// <summary>
        ///     Sensor: Data Field: Month Usage.
        /// </summary>
        public static readonly Usage DataFieldMonth = Instance.Create(0x0522, "Data Field: Month");
        /// <summary>
        ///     Sensor: Data Field: Day Usage.
        /// </summary>
        public static readonly Usage DataFieldDay = Instance.Create(0x0523, "Data Field: Day");
        /// <summary>
        ///     Sensor: Data Field: Day of Week Usage.
        /// </summary>
        public static readonly Usage DataFieldDayOfWeek = Instance.Create(0x0524, "Data Field: Day of Week");
        /// <summary>
        ///     Sensor: Data Field: Minute Usage.
        /// </summary>
        public static readonly Usage DataFieldMinute = Instance.Create(0x0526, "Data Field: Minute");
        /// <summary>
        ///     Sensor: Data Field: Second Usage.
        /// </summary>
        public static readonly Usage DataFieldSecond = Instance.Create(0x0527, "Data Field: Second");
        /// <summary>
        ///     Sensor: Data Field: Millisecond Usage.
        /// </summary>
        public static readonly Usage DataFieldMillisecond = Instance.Create(0x0528, "Data Field: Millisecond");
        /// <summary>
        ///     Sensor: Data Field: Timestamp Usage.
        /// </summary>
        public static readonly Usage DataFieldTimestamp = Instance.Create(0x0529, "Data Field: Timestamp");
        /// <summary>
        ///     Sensor: Data Field: Julian Day of Year Usage.
        /// </summary>
        public static readonly Usage DataFieldJulianDayOfYear = Instance.Create(0x052a, "Data Field: Julian Day of Year");
        /// <summary>
        ///     Sensor: Data Field: Time Since System Boot Usage.
        /// </summary>
        public static readonly Usage DataFieldTimeSinceSystemBoot = Instance.Create(0x052b, "Data Field: Time Since System Boot");

        /// <summary>
        ///     Sensor: Property: Time Usage.
        /// </summary>
        public static readonly Usage PropertyTime = Instance.Create(0x0530, "Property: Time");
        /// <summary>
        ///     Sensor: Property: Time Zone Offset from UTC Usage.
        /// </summary>
        public static readonly Usage PropertyTimeZoneOffsetFromUTC = Instance.Create(0x0531, "Property: Time Zone Offset from UTC");
        /// <summary>
        ///     Sensor: Property: Time Zone Name Usage.
        /// </summary>
        public static readonly Usage PropertyTimeZoneName = Instance.Create(0x0532, "Property: Time Zone Name");
        /// <summary>
        ///     Sensor: Property: Daylight Savings Time Observed Usage.
        /// </summary>
        public static readonly Usage PropertyDaylightSavingsTimeObserved = Instance.Create(0x0533, "Property: Daylight Savings Time Observed");
        /// <summary>
        ///     Sensor: Property: Time Trim Adjustment Usage.
        /// </summary>
        public static readonly Usage PropertyTimeTrimAdjustment = Instance.Create(0x0534, "Property: Time Trim Adjustment");
        /// <summary>
        ///     Sensor: Property: Arm Alarm Usage.
        /// </summary>
        public static readonly Usage PropertyArmAlarm = Instance.Create(0x0535, "Property: Arm Alarm");

        /// <summary>
        ///     Sensor: Data Field: Custom Usage.
        /// </summary>
        public static readonly Usage DataFieldCustom = Instance.Create(0x0540, "Data Field: Custom");
        /// <summary>
        ///     Sensor: Data Field: Custom Usage Usage.
        /// </summary>
        public static readonly Usage DataFieldCustomUsage = Instance.Create(0x0541, "Data Field: Custom Usage");
        /// <summary>
        ///     Sensor: Data Field: Custom Boolean Array Usage.
        /// </summary>
        public static readonly Usage DataFieldCustomBooleanArray = Instance.Create(0x0542, "Data Field: Custom Boolean Array");
        /// <summary>
        ///     Sensor: Data Field: Custom Value Usage.
        /// </summary>
        public static readonly Usage DataFieldCustomValue = Instance.Create(0x0543, "Data Field: Custom Value");
        /// <summary>
        ///     Sensor: Data Field: Custom Value 1 Usage.
        /// </summary>
        public static readonly Usage DataFieldCustomValue1 = Instance.Create(0x0544, "Data Field: Custom Value 1");
        /// <summary>
        ///     Sensor: Data Field: Custom Value 2 Usage.
        /// </summary>
        public static readonly Usage DataFieldCustomValue2 = Instance.Create(0x0545, "Data Field: Custom Value 2");
        /// <summary>
        ///     Sensor: Data Field: Custom Value 3 Usage.
        /// </summary>
        public static readonly Usage DataFieldCustomValue3 = Instance.Create(0x0546, "Data Field: Custom Value 3");
        /// <summary>
        ///     Sensor: Data Field: Custom Value 4 Usage.
        /// </summary>
        public static readonly Usage DataFieldCustomValue4 = Instance.Create(0x0547, "Data Field: Custom Value 4");
        /// <summary>
        ///     Sensor: Data Field: Custom Value 5 Usage.
        /// </summary>
        public static readonly Usage DataFieldCustomValue5 = Instance.Create(0x0548, "Data Field: Custom Value 5");
        /// <summary>
        ///     Sensor: Data Field: Custom Value 6 Usage.
        /// </summary>
        public static readonly Usage DataFieldCustomValue6 = Instance.Create(0x0549, "Data Field: Custom Value 6");
        /// <summary>
        ///     Sensor: Data Field: Custom Value 7 Usage.
        /// </summary>
        public static readonly Usage DataFieldCustomValue7 = Instance.Create(0x054a, "Data Field: Custom Value 7");
        /// <summary>
        ///     Sensor: Data Field: Custom Value 8 Usage.
        /// </summary>
        public static readonly Usage DataFieldCustomValue8 = Instance.Create(0x054b, "Data Field: Custom Value 8");
        /// <summary>
        ///     Sensor: Data Field: Custom Value 9 Usage.
        /// </summary>
        public static readonly Usage DataFieldCustomValue9 = Instance.Create(0x054c, "Data Field: Custom Value 9");
        /// <summary>
        ///     Sensor: Data Field: Custom Value 10 Usage.
        /// </summary>
        public static readonly Usage DataFieldCustomValue10 = Instance.Create(0x054d, "Data Field: Custom Value 10");
        /// <summary>
        ///     Sensor: Data Field: Custom Value 11 Usage.
        /// </summary>
        public static readonly Usage DataFieldCustomValue11 = Instance.Create(0x054e, "Data Field: Custom Value 11");
        /// <summary>
        ///     Sensor: Data Field: Custom Value 12 Usage.
        /// </summary>
        public static readonly Usage DataFieldCustomValue12 = Instance.Create(0x054f, "Data Field: Custom Value 12");
        /// <summary>
        ///     Sensor: Data Field: Custom Value 13 Usage.
        /// </summary>
        public static readonly Usage DataFieldCustomValue13 = Instance.Create(0x0550, "Data Field: Custom Value 13");
        /// <summary>
        ///     Sensor: Data Field: Custom Value 14 Usage.
        /// </summary>
        public static readonly Usage DataFieldCustomValue14 = Instance.Create(0x0551, "Data Field: Custom Value 14");
        /// <summary>
        ///     Sensor: Data Field: Custom Value 15 Usage.
        /// </summary>
        public static readonly Usage DataFieldCustomValue15 = Instance.Create(0x0552, "Data Field: Custom Value 15");
        /// <summary>
        ///     Sensor: Data Field: Custom Value 16 Usage.
        /// </summary>
        public static readonly Usage DataFieldCustomValue16 = Instance.Create(0x0553, "Data Field: Custom Value 16");
        /// <summary>
        ///     Sensor: Data Field: Custom Value 17 Usage.
        /// </summary>
        public static readonly Usage DataFieldCustomValue17 = Instance.Create(0x0554, "Data Field: Custom Value 17");
        /// <summary>
        ///     Sensor: Data Field: Custom Value 18 Usage.
        /// </summary>
        public static readonly Usage DataFieldCustomValue18 = Instance.Create(0x0555, "Data Field: Custom Value 18");
        /// <summary>
        ///     Sensor: Data Field: Custom Value 19 Usage.
        /// </summary>
        public static readonly Usage DataFieldCustomValue19 = Instance.Create(0x0556, "Data Field: Custom Value 19");
        /// <summary>
        ///     Sensor: Data Field: Custom Value 20 Usage.
        /// </summary>
        public static readonly Usage DataFieldCustomValue20 = Instance.Create(0x0557, "Data Field: Custom Value 20");
        /// <summary>
        ///     Sensor: Data Field: Custom Value 21 Usage.
        /// </summary>
        public static readonly Usage DataFieldCustomValue21 = Instance.Create(0x0558, "Data Field: Custom Value 21");
        /// <summary>
        ///     Sensor: Data Field: Custom Value 22 Usage.
        /// </summary>
        public static readonly Usage DataFieldCustomValue22 = Instance.Create(0x0559, "Data Field: Custom Value 22");
        /// <summary>
        ///     Sensor: Data Field: Custom Value 23 Usage.
        /// </summary>
        public static readonly Usage DataFieldCustomValue23 = Instance.Create(0x055a, "Data Field: Custom Value 23");
        /// <summary>
        ///     Sensor: Data Field: Custom Value 24 Usage.
        /// </summary>
        public static readonly Usage DataFieldCustomValue24 = Instance.Create(0x055b, "Data Field: Custom Value 24");
        /// <summary>
        ///     Sensor: Data Field: Custom Value 25 Usage.
        /// </summary>
        public static readonly Usage DataFieldCustomValue25 = Instance.Create(0x055c, "Data Field: Custom Value 25");
        /// <summary>
        ///     Sensor: Data Field: Custom Value 26 Usage.
        /// </summary>
        public static readonly Usage DataFieldCustomValue26 = Instance.Create(0x055d, "Data Field: Custom Value 26");
        /// <summary>
        ///     Sensor: Data Field: Custom Value 27 Usage.
        /// </summary>
        public static readonly Usage DataFieldCustomValue27 = Instance.Create(0x055e, "Data Field: Custom Value 27");
        /// <summary>
        ///     Sensor: Data Field: Custom Value 28 Usage.
        /// </summary>
        public static readonly Usage DataFieldCustomValue28 = Instance.Create(0x055f, "Data Field: Custom Value 28");

        /// <summary>
        ///     Sensor: Data Field: Custom Type ID Usage.
        /// </summary>
        public static readonly Usage DataFieldCustomTypeID = Instance.Create(0x05b0, "Data Field: Custom Type ID");

        /// <summary>
        ///     Sensor: Data Field: Personal Activity Usage.
        /// </summary>
        public static readonly Usage DataFieldPersonalActivity = Instance.Create(0x0590, "Data Field: Personal Activity");
        /// <summary>
        ///     Sensor: Data Field: Activity Type Usage.
        /// </summary>
        public static readonly Usage DataFieldActivityType = Instance.Create(0x0591, "Data Field: Activity Type");
        /// <summary>
        ///     Sensor: Data Field: Activity State Usage.
        /// </summary>
        public static readonly Usage DataFieldActivityState = Instance.Create(0x0592, "Data Field: Activity State");
        /// <summary>
        ///     Sensor: Data Field: Device Position Usage.
        /// </summary>
        public static readonly Usage DataFieldDevicePosition = Instance.Create(0x0592, "Data Field: Device Position");
        /// <summary>
        ///     Sensor: Data Field: Step Count Usage.
        /// </summary>
        public static readonly Usage DataFieldStepCount = Instance.Create(0x0594, "Data Field: Step Count");
        /// <summary>
        ///     Sensor: Data Field: Step Count Reset Usage.
        /// </summary>
        public static readonly Usage DataFieldStepCountReset = Instance.Create(0x0595, "Data Field: Step Count Reset");
        /// <summary>
        ///     Sensor: Data Field: Step Duration Usage.
        /// </summary>
        public static readonly Usage DataFieldStepDuration = Instance.Create(0x0596, "Data Field: Step Duration");
        /// <summary>
        ///     Sensor: Data Field: Step Type Usage.
        /// </summary>
        public static readonly Usage DataFieldStepType = Instance.Create(0x0597, "Data Field: Step Type");

        /// <summary>
        ///     Sensor: Property: Minimum Activity Detection Interval Usage.
        /// </summary>
        public static readonly Usage PropertyMinimumActivityDetectionInterval = Instance.Create(0x05a0, "Property: Minimum Activity Detection Interval");
        /// <summary>
        ///     Sensor: Property: Supported Activity Types Usage.
        /// </summary>
        public static readonly Usage PropertySupportedActivityTypes = Instance.Create(0x05a1, "Property: Supported Activity Types");
        /// <summary>
        ///     Sensor: Property: Subscribed Activity Types Usage.
        /// </summary>
        public static readonly Usage PropertySubscribedActivityTypes = Instance.Create(0x05a2, "Property: Subscribed Activity Types");
        /// <summary>
        ///     Sensor: Property: Supported Step Types Usage.
        /// </summary>
        public static readonly Usage PropertySupportedStepTypes = Instance.Create(0x05a3, "Property: Supported Step Types");
        /// <summary>
        ///     Sensor: Property: Subscribed Step Types Usage.
        /// </summary>
        public static readonly Usage PropertySubscribedStepTypes = Instance.Create(0x05a4, "Property: Subscribed Step Types");
        /// <summary>
        ///     Sensor: Property: Floor Height Usage.
        /// </summary>
        public static readonly Usage PropertyFloorHeight = Instance.Create(0x05a5, "Property: Floor Height");

        /// <summary>
        ///     Sensor: Data Field: Generic Usage.
        /// </summary>
        public static readonly Usage DataFieldGeneric = Instance.Create(0x0560, "Data Field: Generic");
        /// <summary>
        ///     Sensor: Data Field: Generic GUID or PROPERTYKEY Usage.
        /// </summary>
        public static readonly Usage DataFieldGenericGUIDOrPROPERTYKEY = Instance.Create(0x0561, "Data Field: Generic GUID or PROPERTYKEY");
        /// <summary>
        ///     Sensor: Data Field: Generic Category GUID Usage.
        /// </summary>
        public static readonly Usage DataFieldGenericCategoryGUID = Instance.Create(0x0562, "Data Field: Generic Category GUID");
        /// <summary>
        ///     Sensor: Data Field: Generic Type GUID Usage.
        /// </summary>
        public static readonly Usage DataFieldGenericTypeGUID = Instance.Create(0x0563, "Data Field: Generic Type GUID");
        /// <summary>
        ///     Sensor: Data Field: Generic Event PROPERTYKEY Usage.
        /// </summary>
        public static readonly Usage DataFieldGenericEventPROPERTYKEY = Instance.Create(0x0564, "Data Field: Generic Event PROPERTYKEY");
        /// <summary>
        ///     Sensor: Data Field: Generic Property PROPERTYKEY Usage.
        /// </summary>
        public static readonly Usage DataFieldGenericPropertyPROPERTYKEY = Instance.Create(0x0565, "Data Field: Generic Property PROPERTYKEY");
        /// <summary>
        ///     Sensor: Data Field: Generic Data Field PROPERTYKEY Usage.
        /// </summary>
        public static readonly Usage DataFieldGenericDataFieldPROPERTYKEY = Instance.Create(0x0566, "Data Field: Generic Data Field PROPERTYKEY");
        /// <summary>
        ///     Sensor: Data Field: Generic Event Usage.
        /// </summary>
        public static readonly Usage DataFieldGenericEvent = Instance.Create(0x0567, "Data Field: Generic Event");
        /// <summary>
        ///     Sensor: Data Field: Generic Property Usage.
        /// </summary>
        public static readonly Usage DataFieldGenericProperty = Instance.Create(0x0568, "Data Field: Generic Property");
        /// <summary>
        ///     Sensor: Data Field: Generic Data Field Usage.
        /// </summary>
        public static readonly Usage DataFieldGenericDataField = Instance.Create(0x0569, "Data Field: Generic Data Field");
        /// <summary>
        ///     Sensor: Data Field: Enumerator Table Row Index Usage.
        /// </summary>
        public static readonly Usage DataFieldEnumeratorTableRowIndex = Instance.Create(0x056a, "Data Field: Enumerator Table Row Index");
        /// <summary>
        ///     Sensor: Data Field: Enumerator Table Row Count Usage.
        /// </summary>
        public static readonly Usage DataFieldEnumeratorTableRowCount = Instance.Create(0x056b, "Data Field: Enumerator Table Row Count");
        /// <summary>
        ///     Sensor: Data Field: Generic GUID or PROPERTYKEY kind Usage.
        /// </summary>
        public static readonly Usage DataFieldGenericGUIDOrPROPERTYKEYKind = Instance.Create(0x056c, "Data Field: Generic GUID or PROPERTYKEY kind");
        /// <summary>
        ///     Sensor: Data Field: Generic GUID Usage.
        /// </summary>
        public static readonly Usage DataFieldGenericGUID = Instance.Create(0x056d, "Data Field: Generic GUID");
        /// <summary>
        ///     Sensor: Data Field: Generic PROPERTYKEY Usage.
        /// </summary>
        public static readonly Usage DataFieldGenericPROPERTYKEY = Instance.Create(0x056e, "Data Field: Generic PROPERTYKEY");
        /// <summary>
        ///     Sensor: Data Field: Generic Top Level Collection ID Usage.
        /// </summary>
        public static readonly Usage DataFieldGenericTopLevelCollectionID = Instance.Create(0x056f, "Data Field: Generic Top Level Collection ID");
        /// <summary>
        ///     Sensor: Data Field: Generic Report ID Usage.
        /// </summary>
        public static readonly Usage DataFieldGenericReportID = Instance.Create(0x0570, "Data Field: Generic Report ID");
        /// <summary>
        ///     Sensor: Data Field: Generic Report Item Position Index Usage.
        /// </summary>
        public static readonly Usage DataFieldGenericReportItemPositionIndex = Instance.Create(0x0571, "Data Field: Generic Report Item Position Index");
        /// <summary>
        ///     Sensor: Data Field: Generic Firmware VARTYPE Usage.
        /// </summary>
        public static readonly Usage DataFieldGenericFirmwareVARTYPE = Instance.Create(0x0572, "Data Field: Generic Firmware VARTYPE");
        /// <summary>
        ///     Sensor: Data Field: Generic Unit of Measure Usage.
        /// </summary>
        public static readonly Usage DataFieldGenericUnitOfMeasure = Instance.Create(0x0573, "Data Field: Generic Unit of Measure");
        /// <summary>
        ///     Sensor: Data Field: Generic Unit Exponent Usage.
        /// </summary>
        public static readonly Usage DataFieldGenericUnitExponent = Instance.Create(0x0574, "Data Field: Generic Unit Exponent");
        /// <summary>
        ///     Sensor: Data Field: Generic Report Size Usage.
        /// </summary>
        public static readonly Usage DataFieldGenericReportSize = Instance.Create(0x0575, "Data Field: Generic Report Size");
        /// <summary>
        ///     Sensor: Data Field: Generic Report Count Usage.
        /// </summary>
        public static readonly Usage DataFieldGenericReportCount = Instance.Create(0x0576, "Data Field: Generic Report Count");

        /// <summary>
        ///     Sensor: Property: Generic Usage.
        /// </summary>
        public static readonly Usage PropertyGeneric = Instance.Create(0x0580, "Property: Generic");
        /// <summary>
        ///     Sensor: Property: Enumerator Table Row Index Usage.
        /// </summary>
        public static readonly Usage PropertyEnumeratorTableRowIndex = Instance.Create(0x0581, "Property: Enumerator Table Row Index");
        /// <summary>
        ///     Sensor: Property: Enumerator Table Row Count Usage.
        /// </summary>
        public static readonly Usage PropertyEnumeratorTableRowCount = Instance.Create(0x0582, "Property: Enumerator Table Row Count");

        /// <summary>
        ///     Sensor: Sensor State: Undefined Usage.
        /// </summary>
        public static readonly Usage SensorStateUndefined = Instance.Create(0x0800, "Sensor State: Undefined");
        /// <summary>
        ///     Sensor: Sensor State: Ready Usage.
        /// </summary>
        public static readonly Usage SensorStateReady = Instance.Create(0x0801, "Sensor State: Ready");
        /// <summary>
        ///     Sensor: Sensor State: Not Available Usage.
        /// </summary>
        public static readonly Usage SensorStateNotAvailable = Instance.Create(0x0802, "Sensor State: Not Available");
        /// <summary>
        ///     Sensor: Sensor State: No Data Usage.
        /// </summary>
        public static readonly Usage SensorStateNoData = Instance.Create(0x0803, "Sensor State: No Data");
        /// <summary>
        ///     Sensor: Sensor State: Initializing Usage.
        /// </summary>
        public static readonly Usage SensorStateInitializing = Instance.Create(0x0804, "Sensor State: Initializing");
        /// <summary>
        ///     Sensor: Sensor State: Access Denied Usage.
        /// </summary>
        public static readonly Usage SensorStateAccessDenied = Instance.Create(0x0805, "Sensor State: Access Denied");
        /// <summary>
        ///     Sensor: Sensor State: Error Usage.
        /// </summary>
        public static readonly Usage SensorStateError = Instance.Create(0x0806, "Sensor State: Error");

        /// <summary>
        ///     Sensor: Sensor Event: Unknown Usage.
        /// </summary>
        public static readonly Usage SensorEventUnknown = Instance.Create(0x0810, "Sensor Event: Unknown");
        /// <summary>
        ///     Sensor: Sensor Event: State Changed Usage.
        /// </summary>
        public static readonly Usage SensorEventStateChanged = Instance.Create(0x0811, "Sensor Event: State Changed");
        /// <summary>
        ///     Sensor: Sensor Event: Property Changed Usage.
        /// </summary>
        public static readonly Usage SensorEventPropertyChanged = Instance.Create(0x0812, "Sensor Event: Property Changed");
        /// <summary>
        ///     Sensor: Sensor Event: Data Updated Usage.
        /// </summary>
        public static readonly Usage SensorEventDataUpdated = Instance.Create(0x0813, "Sensor Event: Data Updated");
        /// <summary>
        ///     Sensor: Sensor Event: Poll Response Usage.
        /// </summary>
        public static readonly Usage SensorEventPollResponse = Instance.Create(0x0814, "Sensor Event: Poll Response");
        /// <summary>
        ///     Sensor: Sensor Event: Change Sensitivity Usage.
        /// </summary>
        public static readonly Usage SensorEventChangeSensitivity = Instance.Create(0x0815, "Sensor Event: Change Sensitivity");
        /// <summary>
        ///     Sensor: Sensor Event: Range Maximum Reached Usage.
        /// </summary>
        public static readonly Usage SensorEventRangeMaximumReached = Instance.Create(0x0816, "Sensor Event: Range Maximum Reached");
        /// <summary>
        ///     Sensor: Sensor Event: Range Minimum Reached Usage.
        /// </summary>
        public static readonly Usage SensorEventRangeMinimumReached = Instance.Create(0x0817, "Sensor Event: Range Minimum Reached");
        /// <summary>
        ///     Sensor: Sensor Event: High Threshold Cross Upward Usage.
        /// </summary>
        public static readonly Usage SensorEventHighThresholdCrossUpward = Instance.Create(0x0818, "Sensor Event: High Threshold Cross Upward");
        /// <summary>
        ///     Sensor: Sensor Event: High Threshold Cross Downward Usage.
        /// </summary>
        public static readonly Usage SensorEventHighThresholdCrossDownward = Instance.Create(0x0819, "Sensor Event: High Threshold Cross Downward");
        /// <summary>
        ///     Sensor: Sensor Event: Low Threshold Cross Upward Usage.
        /// </summary>
        public static readonly Usage SensorEventLowThresholdCrossUpward = Instance.Create(0x081a, "Sensor Event: Low Threshold Cross Upward");
        /// <summary>
        ///     Sensor: Sensor Event: Low Threshold Cross Downward Usage.
        /// </summary>
        public static readonly Usage SensorEventLowThresholdCrossDownward = Instance.Create(0x081b, "Sensor Event: Low Threshold Cross Downward");
        /// <summary>
        ///     Sensor: Sensor Event: Zero Threshold Cross Upward Usage.
        /// </summary>
        public static readonly Usage SensorEventZeroThresholdCrossUpward = Instance.Create(0x081c, "Sensor Event: Zero Threshold Cross Upward");
        /// <summary>
        ///     Sensor: Sensor Event: Zero Threshold Cross Downward Usage.
        /// </summary>
        public static readonly Usage SensorEventZeroThresholdCrossDownward = Instance.Create(0x081d, "Sensor Event: Zero Threshold Cross Downward");
        /// <summary>
        ///     Sensor: Sensor Event: Period Exceeded Usage.
        /// </summary>
        public static readonly Usage SensorEventPeriodExceeded = Instance.Create(0x081e, "Sensor Event: Period Exceeded");
        /// <summary>
        ///     Sensor: Sensor Event: Frequency Exceeded Usage.
        /// </summary>
        public static readonly Usage SensorEventFrequencyExceeded = Instance.Create(0x081f, "Sensor Event: Frequency Exceeded");
        /// <summary>
        ///     Sensor: Sensor Event: Complex Trigger Usage.
        /// </summary>
        public static readonly Usage SensorEventComplexTrigger = Instance.Create(0x0820, "Sensor Event: Complex Trigger");

        /// <summary>
        ///     Sensor: Connection Type: Integrated Usage.
        /// </summary>
        public static readonly Usage ConnectionTypeIntegrated = Instance.Create(0x0830, "Connection Type: Integrated");
        /// <summary>
        ///     Sensor: Connection Type: Attached Usage.
        /// </summary>
        public static readonly Usage ConnectionTypeAttached = Instance.Create(0x0831, "Connection Type: Attached");
        /// <summary>
        ///     Sensor: Connection Type: External Usage.
        /// </summary>
        public static readonly Usage ConnectionTypeExternal = Instance.Create(0x0832, "Connection Type: External");

        /// <summary>
        ///     Sensor: Reporting State: Report No Events Usage.
        /// </summary>
        public static readonly Usage ReportingStateReportNoEvents = Instance.Create(0x0840, "Reporting State: Report No Events");
        /// <summary>
        ///     Sensor: Reporting State: Report All Events Usage.
        /// </summary>
        public static readonly Usage ReportingStateReportAllEvents = Instance.Create(0x0841, "Reporting State: Report All Events");
        /// <summary>
        ///     Sensor: Reporting State: Report Threshold Events Usage.
        /// </summary>
        public static readonly Usage ReportingStateReportThresholdEvents = Instance.Create(0x0842, "Reporting State: Report Threshold Events");
        /// <summary>
        ///     Sensor: Reporting State: Wake On No Events Usage.
        /// </summary>
        public static readonly Usage ReportingStateWakeOnNoEvents = Instance.Create(0x0843, "Reporting State: Wake On No Events");
        /// <summary>
        ///     Sensor: Reporting State: Wake On All Events Usage.
        /// </summary>
        public static readonly Usage ReportingStateWakeOnAllEvents = Instance.Create(0x0844, "Reporting State: Wake On All Events");
        /// <summary>
        ///     Sensor: Reporting State: Wake On Threshold Events Usage.
        /// </summary>
        public static readonly Usage ReportingStateWakeOnThresholdEvents = Instance.Create(0x0845, "Reporting State: Wake On Threshold Events");

        /// <summary>
        ///     Sensor: Power State: Undefined Usage.
        /// </summary>
        public static readonly Usage PowerStateUndefined = Instance.Create(0x0850, "Power State: Undefined");
        /// <summary>
        ///     Sensor: Power State: D0 Full Power Usage.
        /// </summary>
        public static readonly Usage PowerStateD0FullPower = Instance.Create(0x0851, "Power State: D0 Full Power");
        /// <summary>
        ///     Sensor: Power State: D1 Low Power Usage.
        /// </summary>
        public static readonly Usage PowerStateD1LowPower = Instance.Create(0x0852, "Power State: D1 Low Power");
        /// <summary>
        ///     Sensor: Power State: D2 Standby Power with Wakeup Usage.
        /// </summary>
        public static readonly Usage PowerStateD2StandbyPowerWithWakeup = Instance.Create(0x0853, "Power State: D2 Standby Power with Wakeup");
        /// <summary>
        ///     Sensor: Power State: D3 Sleep with Wakeup Usage.
        /// </summary>
        public static readonly Usage PowerStateD3SleepWithWakeup = Instance.Create(0x0854, "Power State: D3 Sleep with Wakeup");
        /// <summary>
        ///     Sensor: Power State: D4 Power Off Usage.
        /// </summary>
        public static readonly Usage PowerStateD4PowerOff = Instance.Create(0x0855, "Power State: D4 Power Off");

        /// <summary>
        ///     Sensor: Accuracy: Default Usage.
        /// </summary>
        public static readonly Usage AccuracyDefault = Instance.Create(0x0860, "Accuracy: Default");
        /// <summary>
        ///     Sensor: Accuracy: High Usage.
        /// </summary>
        public static readonly Usage AccuracyHigh = Instance.Create(0x0861, "Accuracy: High");
        /// <summary>
        ///     Sensor: Accuracy: Medium Usage.
        /// </summary>
        public static readonly Usage AccuracyMedium = Instance.Create(0x0862, "Accuracy: Medium");
        /// <summary>
        ///     Sensor: Accuracy: Low Usage.
        /// </summary>
        public static readonly Usage AccuracyLow = Instance.Create(0x0863, "Accuracy: Low");

        /// <summary>
        ///     Sensor: Fix Quality: No Fix Usage.
        /// </summary>
        public static readonly Usage FixQualityNoFix = Instance.Create(0x0870, "Fix Quality: No Fix");
        /// <summary>
        ///     Sensor: Fix Quality: GPS Usage.
        /// </summary>
        public static readonly Usage FixQualityGPS = Instance.Create(0x0871, "Fix Quality: GPS");
        /// <summary>
        ///     Sensor: Fix Quality: DGPS Usage.
        /// </summary>
        public static readonly Usage FixQualityDGPS = Instance.Create(0x0872, "Fix Quality: DGPS");

        /// <summary>
        ///     Sensor: Fix Type: No Fix Usage.
        /// </summary>
        public static readonly Usage FixTypeNoFix = Instance.Create(0x0880, "Fix Type: No Fix");
        /// <summary>
        ///     Sensor: Fix Type: GPS SPS Mode, Fix Valid Usage.
        /// </summary>
        public static readonly Usage FixTypeGPSSPSModeFixValid = Instance.Create(0x0881, "Fix Type: GPS SPS Mode, Fix Valid");
        /// <summary>
        ///     Sensor: Fix Type: DGPS SPS Mode, Fix Valid Usage.
        /// </summary>
        public static readonly Usage FixTypeDGPSSPSModeFixValid = Instance.Create(0x0882, "Fix Type: DGPS SPS Mode, Fix Valid");
        /// <summary>
        ///     Sensor: Fix Type: GPS PPS Mode, Fix Valid Usage.
        /// </summary>
        public static readonly Usage FixTypeGPSPPSModeFixValid = Instance.Create(0x0883, "Fix Type: GPS PPS Mode, Fix Valid");
        /// <summary>
        ///     Sensor: Fix Type: Real Time Kinematic Usage.
        /// </summary>
        public static readonly Usage FixTypeRealTimeKinematic = Instance.Create(0x0884, "Fix Type: Real Time Kinematic");
        /// <summary>
        ///     Sensor: Fix Type: Float RTK Usage.
        /// </summary>
        public static readonly Usage FixTypeFloatRTK = Instance.Create(0x0885, "Fix Type: Float RTK");
        /// <summary>
        ///     Sensor: Fix Type: Estimated (dead reckoned) Usage.
        /// </summary>
        public static readonly Usage FixTypeEstimatedDeadReckoned = Instance.Create(0x0886, "Fix Type: Estimated (dead reckoned)");
        /// <summary>
        ///     Sensor: Fix Type: Manual Input Mode Usage.
        /// </summary>
        public static readonly Usage FixTypeManualInputMode = Instance.Create(0x0887, "Fix Type: Manual Input Mode");
        /// <summary>
        ///     Sensor: Fix Type: Simulator Mode Usage.
        /// </summary>
        public static readonly Usage FixTypeSimulatorMode = Instance.Create(0x0888, "Fix Type: Simulator Mode");

        /// <summary>
        ///     Sensor: GPS Operation Mode: Manual Usage.
        /// </summary>
        public static readonly Usage GPSOperationModeManual = Instance.Create(0x0890, "GPS Operation Mode: Manual");
        /// <summary>
        ///     Sensor: GPS Operation Mode: Automatic Usage.
        /// </summary>
        public static readonly Usage GPSOperationModeAutomatic = Instance.Create(0x0891, "GPS Operation Mode: Automatic");

        /// <summary>
        ///     Sensor: GPS Selection Mode: Autonomous Usage.
        /// </summary>
        public static readonly Usage GPSSelectionModeAutonomous = Instance.Create(0x08a0, "GPS Selection Mode: Autonomous");
        /// <summary>
        ///     Sensor: GPS Selection Mode: DGPS Usage.
        /// </summary>
        public static readonly Usage GPSSelectionModeDGPS = Instance.Create(0x08a1, "GPS Selection Mode: DGPS");
        /// <summary>
        ///     Sensor: GPS Selection Mode: Estimated (dead reckoned) Usage.
        /// </summary>
        public static readonly Usage GPSSelectionModeEstimatedDeadReckoned = Instance.Create(0x08a2, "GPS Selection Mode: Estimated (dead reckoned)");
        /// <summary>
        ///     Sensor: GPS Selection Mode: Manual Input Usage.
        /// </summary>
        public static readonly Usage GPSSelectionModeManualInput = Instance.Create(0x08a3, "GPS Selection Mode: Manual Input");
        /// <summary>
        ///     Sensor: GPS Selection Mode: Simulator Usage.
        /// </summary>
        public static readonly Usage GPSSelectionModeSimulator = Instance.Create(0x08a4, "GPS Selection Mode: Simulator");
        /// <summary>
        ///     Sensor: GPS Selection Mode: Data Not Valid Usage.
        /// </summary>
        public static readonly Usage GPSSelectionModeDataNotValid = Instance.Create(0x08a5, "GPS Selection Mode: Data Not Valid");

        /// <summary>
        ///     Sensor: GPS Status: Data Valid Usage.
        /// </summary>
        public static readonly Usage GPSStatusDataValid = Instance.Create(0x08b0, "GPS Status: Data Valid");
        /// <summary>
        ///     Sensor: GPS Status: Data Not Valid Usage.
        /// </summary>
        public static readonly Usage GPSStatusDataNotValid = Instance.Create(0x08b1, "GPS Status: Data Not Valid");

        /// <summary>
        ///     Sensor: Day of Week: Sunday Usage.
        /// </summary>
        public static readonly Usage DayOfWeekSunday = Instance.Create(0x08c0, "Day of Week: Sunday");
        /// <summary>
        ///     Sensor: Day of Week: Monday Usage.
        /// </summary>
        public static readonly Usage DayOfWeekMonday = Instance.Create(0x08c1, "Day of Week: Monday");
        /// <summary>
        ///     Sensor: Day of Week: Tuesday Usage.
        /// </summary>
        public static readonly Usage DayOfWeekTuesday = Instance.Create(0x08c2, "Day of Week: Tuesday");
        /// <summary>
        ///     Sensor: Day of Week: Wednesday Usage.
        /// </summary>
        public static readonly Usage DayOfWeekWednesday = Instance.Create(0x08c3, "Day of Week: Wednesday");
        /// <summary>
        ///     Sensor: Day of Week: Thursday Usage.
        /// </summary>
        public static readonly Usage DayOfWeekThursday = Instance.Create(0x08c4, "Day of Week: Thursday");
        /// <summary>
        ///     Sensor: Day of Week: Friday Usage.
        /// </summary>
        public static readonly Usage DayOfWeekFriday = Instance.Create(0x08c5, "Day of Week: Friday");
        /// <summary>
        ///     Sensor: Day of Week: Saturday Usage.
        /// </summary>
        public static readonly Usage DayOfWeekSaturday = Instance.Create(0x08c6, "Day of Week: Saturday");

        /// <summary>
        ///     Sensor: Kind: Category Usage.
        /// </summary>
        public static readonly Usage KindCategory = Instance.Create(0x08d0, "Kind: Category");
        /// <summary>
        ///     Sensor: Kind: Type Usage.
        /// </summary>
        public static readonly Usage KindType = Instance.Create(0x08d1, "Kind: Type");
        /// <summary>
        ///     Sensor: Kind: Event Usage.
        /// </summary>
        public static readonly Usage KindEvent = Instance.Create(0x08d2, "Kind: Event");
        /// <summary>
        ///     Sensor: Kind: Property Usage.
        /// </summary>
        public static readonly Usage KindProperty = Instance.Create(0x08d3, "Kind: Property");
        /// <summary>
        ///     Sensor: Kind: Data Field Usage.
        /// </summary>
        public static readonly Usage KindDataField = Instance.Create(0x08d4, "Kind: Data Field");

        /// <summary>
        ///     Sensor: Magnetometer Accuracy: Low Usage.
        /// </summary>
        public static readonly Usage MagnetometerAccuracyLow = Instance.Create(0x08e0, "Magnetometer Accuracy: Low");
        /// <summary>
        ///     Sensor: Magnetometer Accuracy: Medium Usage.
        /// </summary>
        public static readonly Usage MagnetometerAccuracyMedium = Instance.Create(0x08e1, "Magnetometer Accuracy: Medium");
        /// <summary>
        ///     Sensor: Magnetometer Accuracy: High Usage.
        /// </summary>
        public static readonly Usage MagnetometerAccuracyHigh = Instance.Create(0x08e2, "Magnetometer Accuracy: High");

        /// <summary>
        ///     Sensor: Simple Orientation Direction: Not Rotated Usage.
        /// </summary>
        public static readonly Usage SimpleOrientationDirectionNotRotated = Instance.Create(0x08f0, "Simple Orientation Direction: Not Rotated");
        /// <summary>
        ///     Sensor: Simple Orientation Direction: Rotated 90 Degrees CCW Usage.
        /// </summary>
        public static readonly Usage SimpleOrientationDirectionRotated90DegreesCCW = Instance.Create(0x08f1, "Simple Orientation Direction: Rotated 90 Degrees CCW");
        /// <summary>
        ///     Sensor: Simple Orientation Direction: Rotated 180 Degrees CCW Usage.
        /// </summary>
        public static readonly Usage SimpleOrientationDirectionRotated180DegreesCCW = Instance.Create(0x08f2, "Simple Orientation Direction: Rotated 180 Degrees CCW");
        /// <summary>
        ///     Sensor: Simple Orientation Direction: Rotated 270 Degrees CCW Usage.
        /// </summary>
        public static readonly Usage SimpleOrientationDirectionRotated270DegreesCCW = Instance.Create(0x08f3, "Simple Orientation Direction: Rotated 270 Degrees CCW");
        /// <summary>
        ///     Sensor: Simple Orientation Direction: Face Up Usage.
        /// </summary>
        public static readonly Usage SimpleOrientationDirectionFaceUp = Instance.Create(0x08f4, "Simple Orientation Direction: Face Up");
        /// <summary>
        ///     Sensor: Simple Orientation Direction: Face Down Usage.
        /// </summary>
        public static readonly Usage SimpleOrientationDirectionFaceDown = Instance.Create(0x08f5, "Simple Orientation Direction: Face Down");

        /// <summary>
        ///     Sensor: VT_NULL: Empty Usage.
        /// </summary>
        public static readonly Usage VT_NULLEmpty = Instance.Create(0x0900, "VT_NULL: Empty");
        /// <summary>
        ///     Sensor: VT_BOOL: Boolean Usage.
        /// </summary>
        public static readonly Usage VT_BOOLBoolean = Instance.Create(0x0901, "VT_BOOL: Boolean");
        /// <summary>
        ///     Sensor: VT_UI1: Byte Usage.
        /// </summary>
        public static readonly Usage VT_UI1Byte = Instance.Create(0x0902, "VT_UI1: Byte");
        /// <summary>
        ///     Sensor: VT_I1: Character Usage.
        /// </summary>
        public static readonly Usage VT_I1Character = Instance.Create(0x0903, "VT_I1: Character");
        /// <summary>
        ///     Sensor: VT_UI2: Unsigned Short Usage.
        /// </summary>
        public static readonly Usage VT_UI2UnsignedShort = Instance.Create(0x0904, "VT_UI2: Unsigned Short");
        /// <summary>
        ///     Sensor: VT_I2: Short Usage.
        /// </summary>
        public static readonly Usage VT_I2Short = Instance.Create(0x0905, "VT_I2: Short");
        /// <summary>
        ///     Sensor: VT_UI4: Unsigned Long Usage.
        /// </summary>
        public static readonly Usage VT_UI4UnsignedLong = Instance.Create(0x0906, "VT_UI4: Unsigned Long");
        /// <summary>
        ///     Sensor: VT_I4: Long Usage.
        /// </summary>
        public static readonly Usage VT_I4Long = Instance.Create(0x0907, "VT_I4: Long");
        /// <summary>
        ///     Sensor: VT_UI8: Unsigned Long Long Usage.
        /// </summary>
        public static readonly Usage VT_UI8UnsignedLongLong = Instance.Create(0x0908, "VT_UI8: Unsigned Long Long");
        /// <summary>
        ///     Sensor: VT_I8: Long Long Usage.
        /// </summary>
        public static readonly Usage VT_I8LongLong = Instance.Create(0x0909, "VT_I8: Long Long");
        /// <summary>
        ///     Sensor: VT_R4: Float Usage.
        /// </summary>
        public static readonly Usage VT_R4Float = Instance.Create(0x090a, "VT_R4: Float");
        /// <summary>
        ///     Sensor: VT_R8: Double Usage.
        /// </summary>
        public static readonly Usage VT_R8Double = Instance.Create(0x090b, "VT_R8: Double");
        /// <summary>
        ///     Sensor: VT_WSTR: Wide String Usage.
        /// </summary>
        public static readonly Usage VT_WSTRWideString = Instance.Create(0x090c, "VT_WSTR: Wide String");
        /// <summary>
        ///     Sensor: VT_STR: Narrow String Usage.
        /// </summary>
        public static readonly Usage VT_STRNarrowString = Instance.Create(0x090d, "VT_STR: Narrow String");
        /// <summary>
        ///     Sensor: VT_CLSID: Guid Usage.
        /// </summary>
        public static readonly Usage VT_CLSIDGuid = Instance.Create(0x090e, "VT_CLSID: Guid");
        /// <summary>
        ///     Sensor: VT_VECTOR|VT_UI1: Opaque Structure Usage.
        /// </summary>
        public static readonly Usage VT_VECTORVT_UI1OpaqueStructure = Instance.Create(0x090f, "VT_VECTOR|VT_UI1: Opaque Structure");
        /// <summary>
        ///     Sensor: VT_F16E0: HID 16-bit Float e0 Usage.
        /// </summary>
        public static readonly Usage VT_F16E0HID16bitFloatE0 = Instance.Create(0x0910, "VT_F16E0: HID 16-bit Float e0");
        /// <summary>
        ///     Sensor: VT_F16E1: HID 16-bit Float e1 Usage.
        /// </summary>
        public static readonly Usage VT_F16E1HID16bitFloatE1 = Instance.Create(0x0911, "VT_F16E1: HID 16-bit Float e1");
        /// <summary>
        ///     Sensor: VT_F16E2: HID 16-bit Float e2 Usage.
        /// </summary>
        public static readonly Usage VT_F16E2HID16bitFloatE2 = Instance.Create(0x0912, "VT_F16E2: HID 16-bit Float e2");
        /// <summary>
        ///     Sensor: VT_F16E3: HID 16-bit Float e3 Usage.
        /// </summary>
        public static readonly Usage VT_F16E3HID16bitFloatE3 = Instance.Create(0x0913, "VT_F16E3: HID 16-bit Float e3");
        /// <summary>
        ///     Sensor: VT_F16E4: HID 16-bit Float e4 Usage.
        /// </summary>
        public static readonly Usage VT_F16E4HID16bitFloatE4 = Instance.Create(0x0914, "VT_F16E4: HID 16-bit Float e4");
        /// <summary>
        ///     Sensor: VT_F16E5: HID 16-bit Float e5 Usage.
        /// </summary>
        public static readonly Usage VT_F16E5HID16bitFloatE5 = Instance.Create(0x0915, "VT_F16E5: HID 16-bit Float e5");
        /// <summary>
        ///     Sensor: VT_F16E6: HID 16-bit Float e6 Usage.
        /// </summary>
        public static readonly Usage VT_F16E6HID16bitFloatE6 = Instance.Create(0x0916, "VT_F16E6: HID 16-bit Float e6");
        /// <summary>
        ///     Sensor: VT_F16E7: HID 16-bit Float e7 Usage.
        /// </summary>
        public static readonly Usage VT_F16E7HID16bitFloatE7 = Instance.Create(0x0917, "VT_F16E7: HID 16-bit Float e7");
        /// <summary>
        ///     Sensor: VT_F16E8: HID 16-bit Float e-8 Usage.
        /// </summary>
        public static readonly Usage VT_F16E8HID16bitFloatE8 = Instance.Create(0x0918, "VT_F16E8: HID 16-bit Float e-8");
        /// <summary>
        ///     Sensor: VT_F16E9: HID 16-bit Float e-7 Usage.
        /// </summary>
        public static readonly Usage VT_F16E9HID16bitFloatE7 = Instance.Create(0x0919, "VT_F16E9: HID 16-bit Float e-7");
        /// <summary>
        ///     Sensor: VT_F16EA: HID 16-bit Float e-6 Usage.
        /// </summary>
        public static readonly Usage VT_F16EAHID16bitFloatE6 = Instance.Create(0x091a, "VT_F16EA: HID 16-bit Float e-6");
        /// <summary>
        ///     Sensor: VT_F16EB: HID 16-bit Float e-5 Usage.
        /// </summary>
        public static readonly Usage VT_F16EBHID16bitFloatE5 = Instance.Create(0x091b, "VT_F16EB: HID 16-bit Float e-5");
        /// <summary>
        ///     Sensor: VT_F16EC: HID 16-bit Float e-4 Usage.
        /// </summary>
        public static readonly Usage VT_F16ECHID16bitFloatE4 = Instance.Create(0x091c, "VT_F16EC: HID 16-bit Float e-4");
        /// <summary>
        ///     Sensor: VT_F16ED: HID 16-bit Float e-3 Usage.
        /// </summary>
        public static readonly Usage VT_F16EDHID16bitFloatE3 = Instance.Create(0x091d, "VT_F16ED: HID 16-bit Float e-3");
        /// <summary>
        ///     Sensor: VT_F16EE: HID 16-bit Float e-2 Usage.
        /// </summary>
        public static readonly Usage VT_F16EEHID16bitFloatE2 = Instance.Create(0x091e, "VT_F16EE: HID 16-bit Float e-2");
        /// <summary>
        ///     Sensor: VT_F16EF: HID 16-bit Float e-1 Usage.
        /// </summary>
        public static readonly Usage VT_F16EFHID16bitFloatE1 = Instance.Create(0x091f, "VT_F16EF: HID 16-bit Float e-1");
        /// <summary>
        ///     Sensor: VT_F32E0: HID 32-bit Float e0 Usage.
        /// </summary>
        public static readonly Usage VT_F32E0HID32bitFloatE0 = Instance.Create(0x0920, "VT_F32E0: HID 32-bit Float e0");
        /// <summary>
        ///     Sensor: VT_F32E1: HID 32-bit Float e1 Usage.
        /// </summary>
        public static readonly Usage VT_F32E1HID32bitFloatE1 = Instance.Create(0x0921, "VT_F32E1: HID 32-bit Float e1");
        /// <summary>
        ///     Sensor: VT_F32E2: HID 32-bit Float e2 Usage.
        /// </summary>
        public static readonly Usage VT_F32E2HID32bitFloatE2 = Instance.Create(0x0922, "VT_F32E2: HID 32-bit Float e2");
        /// <summary>
        ///     Sensor: VT_F32E3: HID 32-bit Float e3 Usage.
        /// </summary>
        public static readonly Usage VT_F32E3HID32bitFloatE3 = Instance.Create(0x0923, "VT_F32E3: HID 32-bit Float e3");
        /// <summary>
        ///     Sensor: VT_F32E4: HID 32-bit Float e4 Usage.
        /// </summary>
        public static readonly Usage VT_F32E4HID32bitFloatE4 = Instance.Create(0x0924, "VT_F32E4: HID 32-bit Float e4");
        /// <summary>
        ///     Sensor: VT_F32E5: HID 32-bit Float e5 Usage.
        /// </summary>
        public static readonly Usage VT_F32E5HID32bitFloatE5 = Instance.Create(0x0925, "VT_F32E5: HID 32-bit Float e5");
        /// <summary>
        ///     Sensor: VT_F32E6: HID 32-bit Float e6 Usage.
        /// </summary>
        public static readonly Usage VT_F32E6HID32bitFloatE6 = Instance.Create(0x0926, "VT_F32E6: HID 32-bit Float e6");
        /// <summary>
        ///     Sensor: VT_F32E7: HID 32-bit Float e7 Usage.
        /// </summary>
        public static readonly Usage VT_F32E7HID32bitFloatE7 = Instance.Create(0x0927, "VT_F32E7: HID 32-bit Float e7");
        /// <summary>
        ///     Sensor: VT_F32E8: HID 32-bit Float e-8 Usage.
        /// </summary>
        public static readonly Usage VT_F32E8HID32bitFloatE8 = Instance.Create(0x0928, "VT_F32E8: HID 32-bit Float e-8");
        /// <summary>
        ///     Sensor: VT_F32E9: HID 32-bit Float e-7 Usage.
        /// </summary>
        public static readonly Usage VT_F32E9HID32bitFloatE7 = Instance.Create(0x0929, "VT_F32E9: HID 32-bit Float e-7");
        /// <summary>
        ///     Sensor: VT_F32EA: HID 32-bit Float e-6 Usage.
        /// </summary>
        public static readonly Usage VT_F32EAHID32bitFloatE6 = Instance.Create(0x092a, "VT_F32EA: HID 32-bit Float e-6");
        /// <summary>
        ///     Sensor: VT_F32EB: HID 32-bit Float e-5 Usage.
        /// </summary>
        public static readonly Usage VT_F32EBHID32bitFloatE5 = Instance.Create(0x092b, "VT_F32EB: HID 32-bit Float e-5");
        /// <summary>
        ///     Sensor: VT_F32EC: HID 32-bit Float e-4 Usage.
        /// </summary>
        public static readonly Usage VT_F32ECHID32bitFloatE4 = Instance.Create(0x092c, "VT_F32EC: HID 32-bit Float e-4");
        /// <summary>
        ///     Sensor: VT_F32ED: HID 32-bit Float e-3 Usage.
        /// </summary>
        public static readonly Usage VT_F32EDHID32bitFloatE3 = Instance.Create(0x092d, "VT_F32ED: HID 32-bit Float e-3");
        /// <summary>
        ///     Sensor: VT_F32EE: HID 32-bit Float e-2 Usage.
        /// </summary>
        public static readonly Usage VT_F32EEHID32bitFloatE2 = Instance.Create(0x092e, "VT_F32EE: HID 32-bit Float e-2");
        /// <summary>
        ///     Sensor: VT_F32EF: HID 32-bit Float e-1 Usage.
        /// </summary>
        public static readonly Usage VT_F32EFHID32bitFloatE1 = Instance.Create(0x092f, "VT_F32EF: HID 32-bit Float e-1");
        /// <summary>
        ///     Sensor: Activity Type: Unknown Usage.
        /// </summary>
        public static readonly Usage ActivityTypeUnknown = Instance.Create(0x0930, "Activity Type: Unknown");
        /// <summary>
        ///     Sensor: Activity Type: Stationary Usage.
        /// </summary>
        public static readonly Usage ActivityTypeStationary = Instance.Create(0x0931, "Activity Type: Stationary");
        /// <summary>
        ///     Sensor: Activity Type: Fidgeting Usage.
        /// </summary>
        public static readonly Usage ActivityTypeFidgeting = Instance.Create(0x0932, "Activity Type: Fidgeting");
        /// <summary>
        ///     Sensor: Activity Type: Walking Usage.
        /// </summary>
        public static readonly Usage ActivityTypeWalking = Instance.Create(0x0933, "Activity Type: Walking");
        /// <summary>
        ///     Sensor: Activity Type: Running Usage.
        /// </summary>
        public static readonly Usage ActivityTypeRunning = Instance.Create(0x0934, "Activity Type: Running");
        /// <summary>
        ///     Sensor: Activity Type: In Vehicle Usage.
        /// </summary>
        public static readonly Usage ActivityTypeInVehicle = Instance.Create(0x0935, "Activity Type: In Vehicle");
        /// <summary>
        ///     Sensor: Activity Type: Biking Usage.
        /// </summary>
        public static readonly Usage ActivityTypeBiking = Instance.Create(0x0936, "Activity Type: Biking");
        /// <summary>
        ///     Sensor: Activity Type: Idle Usage.
        /// </summary>
        public static readonly Usage ActivityTypeIdle = Instance.Create(0x0937, "Activity Type: Idle");

        /// <summary>
        ///     Sensor: Unit: Not Specified Usage.
        /// </summary>
        public static readonly Usage UnitNotSpecified = Instance.Create(0x0940, "Unit: Not Specified");
        /// <summary>
        ///     Sensor: Unit: Lux Usage.
        /// </summary>
        public static readonly Usage UnitLux = Instance.Create(0x0941, "Unit: Lux");
        /// <summary>
        ///     Sensor: Unit: Degrees Kelvin Usage.
        /// </summary>
        public static readonly Usage UnitDegreesKelvin = Instance.Create(0x0942, "Unit: Degrees Kelvin");
        /// <summary>
        ///     Sensor: Unit: Degrees Celsius Usage.
        /// </summary>
        public static readonly Usage UnitDegreesCelsius = Instance.Create(0x0943, "Unit: Degrees Celsius");
        /// <summary>
        ///     Sensor: Unit: Pascal Usage.
        /// </summary>
        public static readonly Usage UnitPascal = Instance.Create(0x0944, "Unit: Pascal");
        /// <summary>
        ///     Sensor: Unit: Newton Usage.
        /// </summary>
        public static readonly Usage UnitNewton = Instance.Create(0x0945, "Unit: Newton");
        /// <summary>
        ///     Sensor: Unit: Meters/Second Usage.
        /// </summary>
        public static readonly Usage UnitMetersSecond = Instance.Create(0x0946, "Unit: Meters/Second");
        /// <summary>
        ///     Sensor: Unit: Kilogram Usage.
        /// </summary>
        public static readonly Usage UnitKilogram = Instance.Create(0x0947, "Unit: Kilogram");
        /// <summary>
        ///     Sensor: Unit: Meter Usage.
        /// </summary>
        public static readonly Usage UnitMeter = Instance.Create(0x0948, "Unit: Meter");
        /// <summary>
        ///     Sensor: Unit: Meters/Second/Second Usage.
        /// </summary>
        public static readonly Usage UnitMetersSecondSecond = Instance.Create(0x0949, "Unit: Meters/Second/Second");
        /// <summary>
        ///     Sensor: Unit: Farad Usage.
        /// </summary>
        public static readonly Usage UnitFarad = Instance.Create(0x094a, "Unit: Farad");
        /// <summary>
        ///     Sensor: Unit: Ampere Usage.
        /// </summary>
        public static readonly Usage UnitAmpere = Instance.Create(0x094b, "Unit: Ampere");
        /// <summary>
        ///     Sensor: Unit: Watt Usage.
        /// </summary>
        public static readonly Usage UnitWatt = Instance.Create(0x094c, "Unit: Watt");
        /// <summary>
        ///     Sensor: Unit: Henry Usage.
        /// </summary>
        public static readonly Usage UnitHenry = Instance.Create(0x094d, "Unit: Henry");
        /// <summary>
        ///     Sensor: Unit: Ohm Usage.
        /// </summary>
        public static readonly Usage UnitOhm = Instance.Create(0x094e, "Unit: Ohm");
        /// <summary>
        ///     Sensor: Unit: Volt Usage.
        /// </summary>
        public static readonly Usage UnitVolt = Instance.Create(0x094f, "Unit: Volt");
        /// <summary>
        ///     Sensor: Unit: Hertz Usage.
        /// </summary>
        public static readonly Usage UnitHertz = Instance.Create(0x0950, "Unit: Hertz");
        /// <summary>
        ///     Sensor: Unit: Bar Usage.
        /// </summary>
        public static readonly Usage UnitBar = Instance.Create(0x0951, "Unit: Bar");
        /// <summary>
        ///     Sensor: Unit: Degrees Anti-clockwise Usage.
        /// </summary>
        public static readonly Usage UnitDegreesAnticlockwise = Instance.Create(0x0952, "Unit: Degrees Anti-clockwise");
        /// <summary>
        ///     Sensor: Unit: Degrees Clockwise Usage.
        /// </summary>
        public static readonly Usage UnitDegreesClockwise = Instance.Create(0x0953, "Unit: Degrees Clockwise");
        /// <summary>
        ///     Sensor: Unit: Degrees Usage.
        /// </summary>
        public static readonly Usage UnitDegrees = Instance.Create(0x0954, "Unit: Degrees");
        /// <summary>
        ///     Sensor: Unit: Degrees/Second Usage.
        /// </summary>
        public static readonly Usage UnitDegreesSecond = Instance.Create(0x0955, "Unit: Degrees/Second");
        /// <summary>
        ///     Sensor: Unit: Degrees/Second/Second Usage.
        /// </summary>
        public static readonly Usage UnitDegreesSecondSecond = Instance.Create(0x0956, "Unit: Degrees/Second/Second");
        /// <summary>
        ///     Sensor: Unit: Knot Usage.
        /// </summary>
        public static readonly Usage UnitKnot = Instance.Create(0x0957, "Unit: Knot");
        /// <summary>
        ///     Sensor: Unit: Percent Usage.
        /// </summary>
        public static readonly Usage UnitPercent = Instance.Create(0x0958, "Unit: Percent");
        /// <summary>
        ///     Sensor: Unit: Second Usage.
        /// </summary>
        public static readonly Usage UnitSecond = Instance.Create(0x0959, "Unit: Second");
        /// <summary>
        ///     Sensor: Unit: Millisecond Usage.
        /// </summary>
        public static readonly Usage UnitMillisecond = Instance.Create(0x095a, "Unit: Millisecond");
        /// <summary>
        ///     Sensor: Unit: G Usage.
        /// </summary>
        public static readonly Usage UnitG = Instance.Create(0x095b, "Unit: G");
        /// <summary>
        ///     Sensor: Unit: Bytes Usage.
        /// </summary>
        public static readonly Usage UnitBytes = Instance.Create(0x095c, "Unit: Bytes");
        /// <summary>
        ///     Sensor: Unit: Milligauss Usage.
        /// </summary>
        public static readonly Usage UnitMilligauss = Instance.Create(0x095d, "Unit: Milligauss");
        /// <summary>
        ///     Sensor: Unit: Bits Usage.
        /// </summary>
        public static readonly Usage UnitBits = Instance.Create(0x095e, "Unit: Bits");

        /// <summary>
        ///     Sensor: Activity State: No State Change Usage.
        /// </summary>
        public static readonly Usage ActivityStateNoStateChange = Instance.Create(0x0960, "Activity State: No State Change");
        /// <summary>
        ///     Sensor: Activity State: Start Activity Usage.
        /// </summary>
        public static readonly Usage ActivityStateStartActivity = Instance.Create(0x0961, "Activity State: Start Activity");
        /// <summary>
        ///     Sensor: Activity State: End Activity Usage.
        /// </summary>
        public static readonly Usage ActivityStateEndActivity = Instance.Create(0x0962, "Activity State: End Activity");

        /// <summary>
        ///     Sensor: Exponent 0: 1 Usage.
        /// </summary>
        public static readonly Usage Exponent01 = Instance.Create(0x0970, "Exponent 0: 1");
        /// <summary>
        ///     Sensor: Exponent 1: 10 Usage.
        /// </summary>
        public static readonly Usage Exponent110 = Instance.Create(0x0971, "Exponent 1: 10");
        /// <summary>
        ///     Sensor: Exponent 2: 100 Usage.
        /// </summary>
        public static readonly Usage Exponent2100 = Instance.Create(0x0972, "Exponent 2: 100");
        /// <summary>
        ///     Sensor: Exponent 3: 1 000 Usage.
        /// </summary>
        public static readonly Usage Exponent31000 = Instance.Create(0x0973, "Exponent 3: 1 000");
        /// <summary>
        ///     Sensor: Exponent 4: 10 000 Usage.
        /// </summary>
        public static readonly Usage Exponent410000 = Instance.Create(0x0974, "Exponent 4: 10 000");
        /// <summary>
        ///     Sensor: Exponent 5: 100 000 Usage.
        /// </summary>
        public static readonly Usage Exponent5100000 = Instance.Create(0x0975, "Exponent 5: 100 000");
        /// <summary>
        ///     Sensor: Exponent 6: 1 000 000 Usage.
        /// </summary>
        public static readonly Usage Exponent61000000 = Instance.Create(0x0976, "Exponent 6: 1 000 000");
        /// <summary>
        ///     Sensor: Exponent 7: 10 000 000 Usage.
        /// </summary>
        public static readonly Usage Exponent710000000 = Instance.Create(0x0977, "Exponent 7: 10 000 000");
        /// <summary>
        ///     Sensor: Exponent 8: 0.00 000 001 Usage.
        /// </summary>
        public static readonly Usage Exponent8000000001 = Instance.Create(0x0978, "Exponent 8: 0.00 000 001");
        /// <summary>
        ///     Sensor: Exponent 9: 0.0 000 001 Usage.
        /// </summary>
        public static readonly Usage Exponent900000001 = Instance.Create(0x0979, "Exponent 9: 0.0 000 001");
        /// <summary>
        ///     Sensor: Exponent A: 0.000 001 Usage.
        /// </summary>
        public static readonly Usage ExponentA0000001 = Instance.Create(0x097a, "Exponent A: 0.000 001");
        /// <summary>
        ///     Sensor: Exponent B: 0.00 001 Usage.
        /// </summary>
        public static readonly Usage ExponentB000001 = Instance.Create(0x097b, "Exponent B: 0.00 001");
        /// <summary>
        ///     Sensor: Exponent C: 0.0 001 Usage.
        /// </summary>
        public static readonly Usage ExponentC00001 = Instance.Create(0x097c, "Exponent C: 0.0 001");
        /// <summary>
        ///     Sensor: Exponent D: 0.001 Usage.
        /// </summary>
        public static readonly Usage ExponentD0001 = Instance.Create(0x097d, "Exponent D: 0.001");
        /// <summary>
        ///     Sensor: Exponent E: 0.01 Usage.
        /// </summary>
        public static readonly Usage ExponentE001 = Instance.Create(0x097e, "Exponent E: 0.01");
        /// <summary>
        ///     Sensor: Exponent F: 0.1 Usage.
        /// </summary>
        public static readonly Usage ExponentF01 = Instance.Create(0x097f, "Exponent F: 0.1");
        /// <summary>
        ///     Sensor: Device Position: Unknown Usage.
        /// </summary>
        public static readonly Usage DevicePositionUnknown = Instance.Create(0x0980, "Device Position: Unknown");
        /// <summary>
        ///     Sensor: Device Position: Unchanged Usage.
        /// </summary>
        public static readonly Usage DevicePositionUnchanged = Instance.Create(0x0981, "Device Position: Unchanged");
        /// <summary>
        ///     Sensor: Device Position: On Desk Usage.
        /// </summary>
        public static readonly Usage DevicePositionOnDesk = Instance.Create(0x0982, "Device Position: On Desk");
        /// <summary>
        ///     Sensor: Device Position: In Hand Usage.
        /// </summary>
        public static readonly Usage DevicePositionInHand = Instance.Create(0x0983, "Device Position: In Hand");
        /// <summary>
        ///     Sensor: Device Position: Moving in Bag Usage.
        /// </summary>
        public static readonly Usage DevicePositionMovingInBag = Instance.Create(0x0984, "Device Position: Moving in Bag");
        /// <summary>
        ///     Sensor: Device Position: Stationary in Bag Usage.
        /// </summary>
        public static readonly Usage DevicePositionStationaryInBag = Instance.Create(0x0985, "Device Position: Stationary in Bag");

        /// <summary>
        ///     Sensor: Step Type: Unknown Usage.
        /// </summary>
        public static readonly Usage StepTypeUnknown = Instance.Create(0x0990, "Step Type: Unknown");
        /// <summary>
        ///     Sensor: Step Type: Running Usage.
        /// </summary>
        public static readonly Usage StepTypeRunning = Instance.Create(0x0991, "Step Type: Running");
        /// <summary>
        ///     Sensor: Step Type: Walking Usage.
        /// </summary>
        public static readonly Usage StepTypeWalking = Instance.Create(0x0992, "Step Type: Walking");

        /// <summary>
        ///     Sensor: Change Sensitivity Absolute Usage.
        /// </summary>
        public static readonly Usage ChangeSensitivityAbsolute = Instance.Create(0x1000, "Change Sensitivity Absolute");
        /// <summary>
        ///     Sensor: Change Sensitivity Absolute Usage.
        /// </summary>
        public static readonly Usage ChangeSensitivityAbsolute2 = Instance.Create(0x1001, "Change Sensitivity Absolute");
        /// <summary>
        ///     Sensor: Change Sensitivity Absolute Usage.
        /// </summary>
        public static readonly Usage ChangeSensitivityAbsolute3 = Instance.Create(0x1002, "Change Sensitivity Absolute");
        /// <summary>
        ///     Sensor: Change Sensitivity Absolute Usage.
        /// </summary>
        public static readonly Usage ChangeSensitivityAbsolute4 = Instance.Create(0x1003, "Change Sensitivity Absolute");
        /// <summary>
        ///     Sensor: Change Sensitivity Absolute Usage.
        /// </summary>
        public static readonly Usage ChangeSensitivityAbsolute5 = Instance.Create(0x1004, "Change Sensitivity Absolute");
        /// <summary>
        ///     Sensor: Change Sensitivity Absolute Usage.
        /// </summary>
        public static readonly Usage ChangeSensitivityAbsolute6 = Instance.Create(0x1005, "Change Sensitivity Absolute");
        /// <summary>
        ///     Sensor: Change Sensitivity Absolute Usage.
        /// </summary>
        public static readonly Usage ChangeSensitivityAbsolute7 = Instance.Create(0x1006, "Change Sensitivity Absolute");
        /// <summary>
        ///     Sensor: Change Sensitivity Absolute Usage.
        /// </summary>
        public static readonly Usage ChangeSensitivityAbsolute8 = Instance.Create(0x1007, "Change Sensitivity Absolute");
        /// <summary>
        ///     Sensor: Change Sensitivity Absolute Usage.
        /// </summary>
        public static readonly Usage ChangeSensitivityAbsolute9 = Instance.Create(0x1008, "Change Sensitivity Absolute");
        /// <summary>
        ///     Sensor: Change Sensitivity Absolute Usage.
        /// </summary>
        public static readonly Usage ChangeSensitivityAbsolute10 = Instance.Create(0x1009, "Change Sensitivity Absolute");
        /// <summary>
        ///     Sensor: Change Sensitivity Absolute Usage.
        /// </summary>
        public static readonly Usage ChangeSensitivityAbsolute11 = Instance.Create(0x100a, "Change Sensitivity Absolute");
        /// <summary>
        ///     Sensor: Change Sensitivity Absolute Usage.
        /// </summary>
        public static readonly Usage ChangeSensitivityAbsolute12 = Instance.Create(0x100b, "Change Sensitivity Absolute");
        /// <summary>
        ///     Sensor: Change Sensitivity Absolute Usage.
        /// </summary>
        public static readonly Usage ChangeSensitivityAbsolute13 = Instance.Create(0x100c, "Change Sensitivity Absolute");
        /// <summary>
        ///     Sensor: Change Sensitivity Absolute Usage.
        /// </summary>
        public static readonly Usage ChangeSensitivityAbsolute14 = Instance.Create(0x100d, "Change Sensitivity Absolute");
        /// <summary>
        ///     Sensor: Change Sensitivity Absolute Usage.
        /// </summary>
        public static readonly Usage ChangeSensitivityAbsolute15 = Instance.Create(0x100e, "Change Sensitivity Absolute");
        /// <summary>
        ///     Sensor: Change Sensitivity Absolute Usage.
        /// </summary>
        public static readonly Usage ChangeSensitivityAbsolute16 = Instance.Create(0x100f, "Change Sensitivity Absolute");
        /// <summary>
        ///     Sensor: Change Sensitivity Absolute Usage.
        /// </summary>
        public static readonly Usage ChangeSensitivityAbsolute17 = Instance.Create(0x1010, "Change Sensitivity Absolute");
        /// <summary>
        ///     Sensor: Change Sensitivity Absolute Usage.
        /// </summary>
        public static readonly Usage ChangeSensitivityAbsolute18 = Instance.Create(0x1011, "Change Sensitivity Absolute");
        /// <summary>
        ///     Sensor: Change Sensitivity Absolute Usage.
        /// </summary>
        public static readonly Usage ChangeSensitivityAbsolute19 = Instance.Create(0x1012, "Change Sensitivity Absolute");
        /// <summary>
        ///     Sensor: Change Sensitivity Absolute Usage.
        /// </summary>
        public static readonly Usage ChangeSensitivityAbsolute20 = Instance.Create(0x1013, "Change Sensitivity Absolute");
        /// <summary>
        ///     Sensor: Change Sensitivity Absolute Usage.
        /// </summary>
        public static readonly Usage ChangeSensitivityAbsolute21 = Instance.Create(0x1014, "Change Sensitivity Absolute");
        /// <summary>
        ///     Sensor: Change Sensitivity Absolute Usage.
        /// </summary>
        public static readonly Usage ChangeSensitivityAbsolute22 = Instance.Create(0x1015, "Change Sensitivity Absolute");
        /// <summary>
        ///     Sensor: Change Sensitivity Absolute Usage.
        /// </summary>
        public static readonly Usage ChangeSensitivityAbsolute23 = Instance.Create(0x1016, "Change Sensitivity Absolute");
        /// <summary>
        ///     Sensor: Change Sensitivity Absolute Usage.
        /// </summary>
        public static readonly Usage ChangeSensitivityAbsolute24 = Instance.Create(0x1017, "Change Sensitivity Absolute");
        /// <summary>
        ///     Sensor: Change Sensitivity Absolute Usage.
        /// </summary>
        public static readonly Usage ChangeSensitivityAbsolute25 = Instance.Create(0x1018, "Change Sensitivity Absolute");
        /// <summary>
        ///     Sensor: Change Sensitivity Absolute Usage.
        /// </summary>
        public static readonly Usage ChangeSensitivityAbsolute26 = Instance.Create(0x1019, "Change Sensitivity Absolute");
        /// <summary>
        ///     Sensor: Change Sensitivity Absolute Usage.
        /// </summary>
        public static readonly Usage ChangeSensitivityAbsolute27 = Instance.Create(0x101a, "Change Sensitivity Absolute");
        /// <summary>
        ///     Sensor: Change Sensitivity Absolute Usage.
        /// </summary>
        public static readonly Usage ChangeSensitivityAbsolute28 = Instance.Create(0x101b, "Change Sensitivity Absolute");
        /// <summary>
        ///     Sensor: Change Sensitivity Absolute Usage.
        /// </summary>
        public static readonly Usage ChangeSensitivityAbsolute29 = Instance.Create(0x101c, "Change Sensitivity Absolute");
        /// <summary>
        ///     Sensor: Change Sensitivity Absolute Usage.
        /// </summary>
        public static readonly Usage ChangeSensitivityAbsolute30 = Instance.Create(0x101d, "Change Sensitivity Absolute");
        /// <summary>
        ///     Sensor: Change Sensitivity Absolute Usage.
        /// </summary>
        public static readonly Usage ChangeSensitivityAbsolute31 = Instance.Create(0x101e, "Change Sensitivity Absolute");
        /// <summary>
        ///     Sensor: Change Sensitivity Absolute Usage.
        /// </summary>
        public static readonly Usage ChangeSensitivityAbsolute32 = Instance.Create(0x101f, "Change Sensitivity Absolute");
        /// <summary>
        ///     Sensor: Maximum Usage.
        /// </summary>
        public static readonly Usage Maximum = Instance.Create(0x2000, "Maximum");
        /// <summary>
        ///     Sensor: Maximum Usage.
        /// </summary>
        public static readonly Usage Maximum2 = Instance.Create(0x2001, "Maximum");
        /// <summary>
        ///     Sensor: Maximum Usage.
        /// </summary>
        public static readonly Usage Maximum3 = Instance.Create(0x2002, "Maximum");
        /// <summary>
        ///     Sensor: Maximum Usage.
        /// </summary>
        public static readonly Usage Maximum4 = Instance.Create(0x2003, "Maximum");
        /// <summary>
        ///     Sensor: Maximum Usage.
        /// </summary>
        public static readonly Usage Maximum5 = Instance.Create(0x2004, "Maximum");
        /// <summary>
        ///     Sensor: Maximum Usage.
        /// </summary>
        public static readonly Usage Maximum6 = Instance.Create(0x2005, "Maximum");
        /// <summary>
        ///     Sensor: Maximum Usage.
        /// </summary>
        public static readonly Usage Maximum7 = Instance.Create(0x2006, "Maximum");
        /// <summary>
        ///     Sensor: Maximum Usage.
        /// </summary>
        public static readonly Usage Maximum8 = Instance.Create(0x2007, "Maximum");
        /// <summary>
        ///     Sensor: Maximum Usage.
        /// </summary>
        public static readonly Usage Maximum9 = Instance.Create(0x2008, "Maximum");
        /// <summary>
        ///     Sensor: Maximum Usage.
        /// </summary>
        public static readonly Usage Maximum10 = Instance.Create(0x2009, "Maximum");
        /// <summary>
        ///     Sensor: Maximum Usage.
        /// </summary>
        public static readonly Usage Maximum11 = Instance.Create(0x200a, "Maximum");
        /// <summary>
        ///     Sensor: Maximum Usage.
        /// </summary>
        public static readonly Usage Maximum12 = Instance.Create(0x200b, "Maximum");
        /// <summary>
        ///     Sensor: Maximum Usage.
        /// </summary>
        public static readonly Usage Maximum13 = Instance.Create(0x200c, "Maximum");
        /// <summary>
        ///     Sensor: Maximum Usage.
        /// </summary>
        public static readonly Usage Maximum14 = Instance.Create(0x200d, "Maximum");
        /// <summary>
        ///     Sensor: Maximum Usage.
        /// </summary>
        public static readonly Usage Maximum15 = Instance.Create(0x200e, "Maximum");
        /// <summary>
        ///     Sensor: Maximum Usage.
        /// </summary>
        public static readonly Usage Maximum16 = Instance.Create(0x200f, "Maximum");
        /// <summary>
        ///     Sensor: Maximum Usage.
        /// </summary>
        public static readonly Usage Maximum17 = Instance.Create(0x2010, "Maximum");
        /// <summary>
        ///     Sensor: Maximum Usage.
        /// </summary>
        public static readonly Usage Maximum18 = Instance.Create(0x2011, "Maximum");
        /// <summary>
        ///     Sensor: Maximum Usage.
        /// </summary>
        public static readonly Usage Maximum19 = Instance.Create(0x2012, "Maximum");
        /// <summary>
        ///     Sensor: Maximum Usage.
        /// </summary>
        public static readonly Usage Maximum20 = Instance.Create(0x2013, "Maximum");
        /// <summary>
        ///     Sensor: Maximum Usage.
        /// </summary>
        public static readonly Usage Maximum21 = Instance.Create(0x2014, "Maximum");
        /// <summary>
        ///     Sensor: Maximum Usage.
        /// </summary>
        public static readonly Usage Maximum22 = Instance.Create(0x2015, "Maximum");
        /// <summary>
        ///     Sensor: Maximum Usage.
        /// </summary>
        public static readonly Usage Maximum23 = Instance.Create(0x2016, "Maximum");
        /// <summary>
        ///     Sensor: Maximum Usage.
        /// </summary>
        public static readonly Usage Maximum24 = Instance.Create(0x2017, "Maximum");
        /// <summary>
        ///     Sensor: Maximum Usage.
        /// </summary>
        public static readonly Usage Maximum25 = Instance.Create(0x2018, "Maximum");
        /// <summary>
        ///     Sensor: Maximum Usage.
        /// </summary>
        public static readonly Usage Maximum26 = Instance.Create(0x2019, "Maximum");
        /// <summary>
        ///     Sensor: Maximum Usage.
        /// </summary>
        public static readonly Usage Maximum27 = Instance.Create(0x201a, "Maximum");
        /// <summary>
        ///     Sensor: Maximum Usage.
        /// </summary>
        public static readonly Usage Maximum28 = Instance.Create(0x201b, "Maximum");
        /// <summary>
        ///     Sensor: Maximum Usage.
        /// </summary>
        public static readonly Usage Maximum29 = Instance.Create(0x201c, "Maximum");
        /// <summary>
        ///     Sensor: Maximum Usage.
        /// </summary>
        public static readonly Usage Maximum30 = Instance.Create(0x201d, "Maximum");
        /// <summary>
        ///     Sensor: Maximum Usage.
        /// </summary>
        public static readonly Usage Maximum31 = Instance.Create(0x201e, "Maximum");
        /// <summary>
        ///     Sensor: Maximum Usage.
        /// </summary>
        public static readonly Usage Maximum32 = Instance.Create(0x201f, "Maximum");
        /// <summary>
        ///     Sensor: Minimum Usage.
        /// </summary>
        public static readonly Usage Minimum = Instance.Create(0x3000, "Minimum");
        /// <summary>
        ///     Sensor: Minimum Usage.
        /// </summary>
        public static readonly Usage Minimum2 = Instance.Create(0x3001, "Minimum");
        /// <summary>
        ///     Sensor: Minimum Usage.
        /// </summary>
        public static readonly Usage Minimum3 = Instance.Create(0x3002, "Minimum");
        /// <summary>
        ///     Sensor: Minimum Usage.
        /// </summary>
        public static readonly Usage Minimum4 = Instance.Create(0x3003, "Minimum");
        /// <summary>
        ///     Sensor: Minimum Usage.
        /// </summary>
        public static readonly Usage Minimum5 = Instance.Create(0x3004, "Minimum");
        /// <summary>
        ///     Sensor: Minimum Usage.
        /// </summary>
        public static readonly Usage Minimum6 = Instance.Create(0x3005, "Minimum");
        /// <summary>
        ///     Sensor: Minimum Usage.
        /// </summary>
        public static readonly Usage Minimum7 = Instance.Create(0x3006, "Minimum");
        /// <summary>
        ///     Sensor: Minimum Usage.
        /// </summary>
        public static readonly Usage Minimum8 = Instance.Create(0x3007, "Minimum");
        /// <summary>
        ///     Sensor: Minimum Usage.
        /// </summary>
        public static readonly Usage Minimum9 = Instance.Create(0x3008, "Minimum");
        /// <summary>
        ///     Sensor: Minimum Usage.
        /// </summary>
        public static readonly Usage Minimum10 = Instance.Create(0x3009, "Minimum");
        /// <summary>
        ///     Sensor: Minimum Usage.
        /// </summary>
        public static readonly Usage Minimum11 = Instance.Create(0x300a, "Minimum");
        /// <summary>
        ///     Sensor: Minimum Usage.
        /// </summary>
        public static readonly Usage Minimum12 = Instance.Create(0x300b, "Minimum");
        /// <summary>
        ///     Sensor: Minimum Usage.
        /// </summary>
        public static readonly Usage Minimum13 = Instance.Create(0x300c, "Minimum");
        /// <summary>
        ///     Sensor: Minimum Usage.
        /// </summary>
        public static readonly Usage Minimum14 = Instance.Create(0x300d, "Minimum");
        /// <summary>
        ///     Sensor: Minimum Usage.
        /// </summary>
        public static readonly Usage Minimum15 = Instance.Create(0x300e, "Minimum");
        /// <summary>
        ///     Sensor: Minimum Usage.
        /// </summary>
        public static readonly Usage Minimum16 = Instance.Create(0x300f, "Minimum");
        /// <summary>
        ///     Sensor: Minimum Usage.
        /// </summary>
        public static readonly Usage Minimum17 = Instance.Create(0x3010, "Minimum");
        /// <summary>
        ///     Sensor: Minimum Usage.
        /// </summary>
        public static readonly Usage Minimum18 = Instance.Create(0x3011, "Minimum");
        /// <summary>
        ///     Sensor: Minimum Usage.
        /// </summary>
        public static readonly Usage Minimum19 = Instance.Create(0x3012, "Minimum");
        /// <summary>
        ///     Sensor: Minimum Usage.
        /// </summary>
        public static readonly Usage Minimum20 = Instance.Create(0x3013, "Minimum");
        /// <summary>
        ///     Sensor: Minimum Usage.
        /// </summary>
        public static readonly Usage Minimum21 = Instance.Create(0x3014, "Minimum");
        /// <summary>
        ///     Sensor: Minimum Usage.
        /// </summary>
        public static readonly Usage Minimum22 = Instance.Create(0x3015, "Minimum");
        /// <summary>
        ///     Sensor: Minimum Usage.
        /// </summary>
        public static readonly Usage Minimum23 = Instance.Create(0x3016, "Minimum");
        /// <summary>
        ///     Sensor: Minimum Usage.
        /// </summary>
        public static readonly Usage Minimum24 = Instance.Create(0x3017, "Minimum");
        /// <summary>
        ///     Sensor: Minimum Usage.
        /// </summary>
        public static readonly Usage Minimum25 = Instance.Create(0x3018, "Minimum");
        /// <summary>
        ///     Sensor: Minimum Usage.
        /// </summary>
        public static readonly Usage Minimum26 = Instance.Create(0x3019, "Minimum");
        /// <summary>
        ///     Sensor: Minimum Usage.
        /// </summary>
        public static readonly Usage Minimum27 = Instance.Create(0x301a, "Minimum");
        /// <summary>
        ///     Sensor: Minimum Usage.
        /// </summary>
        public static readonly Usage Minimum28 = Instance.Create(0x301b, "Minimum");
        /// <summary>
        ///     Sensor: Minimum Usage.
        /// </summary>
        public static readonly Usage Minimum29 = Instance.Create(0x301c, "Minimum");
        /// <summary>
        ///     Sensor: Minimum Usage.
        /// </summary>
        public static readonly Usage Minimum30 = Instance.Create(0x301d, "Minimum");
        /// <summary>
        ///     Sensor: Minimum Usage.
        /// </summary>
        public static readonly Usage Minimum31 = Instance.Create(0x301e, "Minimum");
        /// <summary>
        ///     Sensor: Minimum Usage.
        /// </summary>
        public static readonly Usage Minimum32 = Instance.Create(0x301f, "Minimum");
        /// <summary>
        ///     Sensor: Accuracy Usage.
        /// </summary>
        public static readonly Usage Accuracy = Instance.Create(0x4000, "Accuracy");
        /// <summary>
        ///     Sensor: Accuracy Usage.
        /// </summary>
        public static readonly Usage Accuracy2 = Instance.Create(0x4001, "Accuracy");
        /// <summary>
        ///     Sensor: Accuracy Usage.
        /// </summary>
        public static readonly Usage Accuracy3 = Instance.Create(0x4002, "Accuracy");
        /// <summary>
        ///     Sensor: Accuracy Usage.
        /// </summary>
        public static readonly Usage Accuracy4 = Instance.Create(0x4003, "Accuracy");
        /// <summary>
        ///     Sensor: Accuracy Usage.
        /// </summary>
        public static readonly Usage Accuracy5 = Instance.Create(0x4004, "Accuracy");
        /// <summary>
        ///     Sensor: Accuracy Usage.
        /// </summary>
        public static readonly Usage Accuracy6 = Instance.Create(0x4005, "Accuracy");
        /// <summary>
        ///     Sensor: Accuracy Usage.
        /// </summary>
        public static readonly Usage Accuracy7 = Instance.Create(0x4006, "Accuracy");
        /// <summary>
        ///     Sensor: Accuracy Usage.
        /// </summary>
        public static readonly Usage Accuracy8 = Instance.Create(0x4007, "Accuracy");
        /// <summary>
        ///     Sensor: Accuracy Usage.
        /// </summary>
        public static readonly Usage Accuracy9 = Instance.Create(0x4008, "Accuracy");
        /// <summary>
        ///     Sensor: Accuracy Usage.
        /// </summary>
        public static readonly Usage Accuracy10 = Instance.Create(0x4009, "Accuracy");
        /// <summary>
        ///     Sensor: Accuracy Usage.
        /// </summary>
        public static readonly Usage Accuracy11 = Instance.Create(0x400a, "Accuracy");
        /// <summary>
        ///     Sensor: Accuracy Usage.
        /// </summary>
        public static readonly Usage Accuracy12 = Instance.Create(0x400b, "Accuracy");
        /// <summary>
        ///     Sensor: Accuracy Usage.
        /// </summary>
        public static readonly Usage Accuracy13 = Instance.Create(0x400c, "Accuracy");
        /// <summary>
        ///     Sensor: Accuracy Usage.
        /// </summary>
        public static readonly Usage Accuracy14 = Instance.Create(0x400d, "Accuracy");
        /// <summary>
        ///     Sensor: Accuracy Usage.
        /// </summary>
        public static readonly Usage Accuracy15 = Instance.Create(0x400e, "Accuracy");
        /// <summary>
        ///     Sensor: Accuracy Usage.
        /// </summary>
        public static readonly Usage Accuracy16 = Instance.Create(0x400f, "Accuracy");
        /// <summary>
        ///     Sensor: Accuracy Usage.
        /// </summary>
        public static readonly Usage Accuracy17 = Instance.Create(0x4010, "Accuracy");
        /// <summary>
        ///     Sensor: Accuracy Usage.
        /// </summary>
        public static readonly Usage Accuracy18 = Instance.Create(0x4011, "Accuracy");
        /// <summary>
        ///     Sensor: Accuracy Usage.
        /// </summary>
        public static readonly Usage Accuracy19 = Instance.Create(0x4012, "Accuracy");
        /// <summary>
        ///     Sensor: Accuracy Usage.
        /// </summary>
        public static readonly Usage Accuracy20 = Instance.Create(0x4013, "Accuracy");
        /// <summary>
        ///     Sensor: Accuracy Usage.
        /// </summary>
        public static readonly Usage Accuracy21 = Instance.Create(0x4014, "Accuracy");
        /// <summary>
        ///     Sensor: Accuracy Usage.
        /// </summary>
        public static readonly Usage Accuracy22 = Instance.Create(0x4015, "Accuracy");
        /// <summary>
        ///     Sensor: Accuracy Usage.
        /// </summary>
        public static readonly Usage Accuracy23 = Instance.Create(0x4016, "Accuracy");
        /// <summary>
        ///     Sensor: Accuracy Usage.
        /// </summary>
        public static readonly Usage Accuracy24 = Instance.Create(0x4017, "Accuracy");
        /// <summary>
        ///     Sensor: Accuracy Usage.
        /// </summary>
        public static readonly Usage Accuracy25 = Instance.Create(0x4018, "Accuracy");
        /// <summary>
        ///     Sensor: Accuracy Usage.
        /// </summary>
        public static readonly Usage Accuracy26 = Instance.Create(0x4019, "Accuracy");
        /// <summary>
        ///     Sensor: Accuracy Usage.
        /// </summary>
        public static readonly Usage Accuracy27 = Instance.Create(0x401a, "Accuracy");
        /// <summary>
        ///     Sensor: Accuracy Usage.
        /// </summary>
        public static readonly Usage Accuracy28 = Instance.Create(0x401b, "Accuracy");
        /// <summary>
        ///     Sensor: Accuracy Usage.
        /// </summary>
        public static readonly Usage Accuracy29 = Instance.Create(0x401c, "Accuracy");
        /// <summary>
        ///     Sensor: Accuracy Usage.
        /// </summary>
        public static readonly Usage Accuracy30 = Instance.Create(0x401d, "Accuracy");
        /// <summary>
        ///     Sensor: Accuracy Usage.
        /// </summary>
        public static readonly Usage Accuracy31 = Instance.Create(0x401e, "Accuracy");
        /// <summary>
        ///     Sensor: Accuracy Usage.
        /// </summary>
        public static readonly Usage Accuracy32 = Instance.Create(0x401f, "Accuracy");
        /// <summary>
        ///     Sensor: Resolution Usage.
        /// </summary>
        public static readonly Usage Resolution = Instance.Create(0x5000, "Resolution");
        /// <summary>
        ///     Sensor: Resolution Usage.
        /// </summary>
        public static readonly Usage Resolution2 = Instance.Create(0x5001, "Resolution");
        /// <summary>
        ///     Sensor: Resolution Usage.
        /// </summary>
        public static readonly Usage Resolution3 = Instance.Create(0x5002, "Resolution");
        /// <summary>
        ///     Sensor: Resolution Usage.
        /// </summary>
        public static readonly Usage Resolution4 = Instance.Create(0x5003, "Resolution");
        /// <summary>
        ///     Sensor: Resolution Usage.
        /// </summary>
        public static readonly Usage Resolution5 = Instance.Create(0x5004, "Resolution");
        /// <summary>
        ///     Sensor: Resolution Usage.
        /// </summary>
        public static readonly Usage Resolution6 = Instance.Create(0x5005, "Resolution");
        /// <summary>
        ///     Sensor: Resolution Usage.
        /// </summary>
        public static readonly Usage Resolution7 = Instance.Create(0x5006, "Resolution");
        /// <summary>
        ///     Sensor: Resolution Usage.
        /// </summary>
        public static readonly Usage Resolution8 = Instance.Create(0x5007, "Resolution");
        /// <summary>
        ///     Sensor: Resolution Usage.
        /// </summary>
        public static readonly Usage Resolution9 = Instance.Create(0x5008, "Resolution");
        /// <summary>
        ///     Sensor: Resolution Usage.
        /// </summary>
        public static readonly Usage Resolution10 = Instance.Create(0x5009, "Resolution");
        /// <summary>
        ///     Sensor: Resolution Usage.
        /// </summary>
        public static readonly Usage Resolution11 = Instance.Create(0x500a, "Resolution");
        /// <summary>
        ///     Sensor: Resolution Usage.
        /// </summary>
        public static readonly Usage Resolution12 = Instance.Create(0x500b, "Resolution");
        /// <summary>
        ///     Sensor: Resolution Usage.
        /// </summary>
        public static readonly Usage Resolution13 = Instance.Create(0x500c, "Resolution");
        /// <summary>
        ///     Sensor: Resolution Usage.
        /// </summary>
        public static readonly Usage Resolution14 = Instance.Create(0x500d, "Resolution");
        /// <summary>
        ///     Sensor: Resolution Usage.
        /// </summary>
        public static readonly Usage Resolution15 = Instance.Create(0x500e, "Resolution");
        /// <summary>
        ///     Sensor: Resolution Usage.
        /// </summary>
        public static readonly Usage Resolution16 = Instance.Create(0x500f, "Resolution");
        /// <summary>
        ///     Sensor: Resolution Usage.
        /// </summary>
        public static readonly Usage Resolution17 = Instance.Create(0x5010, "Resolution");
        /// <summary>
        ///     Sensor: Resolution Usage.
        /// </summary>
        public static readonly Usage Resolution18 = Instance.Create(0x5011, "Resolution");
        /// <summary>
        ///     Sensor: Resolution Usage.
        /// </summary>
        public static readonly Usage Resolution19 = Instance.Create(0x5012, "Resolution");
        /// <summary>
        ///     Sensor: Resolution Usage.
        /// </summary>
        public static readonly Usage Resolution20 = Instance.Create(0x5013, "Resolution");
        /// <summary>
        ///     Sensor: Resolution Usage.
        /// </summary>
        public static readonly Usage Resolution21 = Instance.Create(0x5014, "Resolution");
        /// <summary>
        ///     Sensor: Resolution Usage.
        /// </summary>
        public static readonly Usage Resolution22 = Instance.Create(0x5015, "Resolution");
        /// <summary>
        ///     Sensor: Resolution Usage.
        /// </summary>
        public static readonly Usage Resolution23 = Instance.Create(0x5016, "Resolution");
        /// <summary>
        ///     Sensor: Resolution Usage.
        /// </summary>
        public static readonly Usage Resolution24 = Instance.Create(0x5017, "Resolution");
        /// <summary>
        ///     Sensor: Resolution Usage.
        /// </summary>
        public static readonly Usage Resolution25 = Instance.Create(0x5018, "Resolution");
        /// <summary>
        ///     Sensor: Resolution Usage.
        /// </summary>
        public static readonly Usage Resolution26 = Instance.Create(0x5019, "Resolution");
        /// <summary>
        ///     Sensor: Resolution Usage.
        /// </summary>
        public static readonly Usage Resolution27 = Instance.Create(0x501a, "Resolution");
        /// <summary>
        ///     Sensor: Resolution Usage.
        /// </summary>
        public static readonly Usage Resolution28 = Instance.Create(0x501b, "Resolution");
        /// <summary>
        ///     Sensor: Resolution Usage.
        /// </summary>
        public static readonly Usage Resolution29 = Instance.Create(0x501c, "Resolution");
        /// <summary>
        ///     Sensor: Resolution Usage.
        /// </summary>
        public static readonly Usage Resolution30 = Instance.Create(0x501d, "Resolution");
        /// <summary>
        ///     Sensor: Resolution Usage.
        /// </summary>
        public static readonly Usage Resolution31 = Instance.Create(0x501e, "Resolution");
        /// <summary>
        ///     Sensor: Resolution Usage.
        /// </summary>
        public static readonly Usage Resolution32 = Instance.Create(0x501f, "Resolution");
        /// <summary>
        ///     Sensor: Threshold High Usage.
        /// </summary>
        public static readonly Usage ThresholdHigh = Instance.Create(0x6000, "Threshold High");
        /// <summary>
        ///     Sensor: Threshold High Usage.
        /// </summary>
        public static readonly Usage ThresholdHigh2 = Instance.Create(0x6001, "Threshold High");
        /// <summary>
        ///     Sensor: Threshold High Usage.
        /// </summary>
        public static readonly Usage ThresholdHigh3 = Instance.Create(0x6002, "Threshold High");
        /// <summary>
        ///     Sensor: Threshold High Usage.
        /// </summary>
        public static readonly Usage ThresholdHigh4 = Instance.Create(0x6003, "Threshold High");
        /// <summary>
        ///     Sensor: Threshold High Usage.
        /// </summary>
        public static readonly Usage ThresholdHigh5 = Instance.Create(0x6004, "Threshold High");
        /// <summary>
        ///     Sensor: Threshold High Usage.
        /// </summary>
        public static readonly Usage ThresholdHigh6 = Instance.Create(0x6005, "Threshold High");
        /// <summary>
        ///     Sensor: Threshold High Usage.
        /// </summary>
        public static readonly Usage ThresholdHigh7 = Instance.Create(0x6006, "Threshold High");
        /// <summary>
        ///     Sensor: Threshold High Usage.
        /// </summary>
        public static readonly Usage ThresholdHigh8 = Instance.Create(0x6007, "Threshold High");
        /// <summary>
        ///     Sensor: Threshold High Usage.
        /// </summary>
        public static readonly Usage ThresholdHigh9 = Instance.Create(0x6008, "Threshold High");
        /// <summary>
        ///     Sensor: Threshold High Usage.
        /// </summary>
        public static readonly Usage ThresholdHigh10 = Instance.Create(0x6009, "Threshold High");
        /// <summary>
        ///     Sensor: Threshold High Usage.
        /// </summary>
        public static readonly Usage ThresholdHigh11 = Instance.Create(0x600a, "Threshold High");
        /// <summary>
        ///     Sensor: Threshold High Usage.
        /// </summary>
        public static readonly Usage ThresholdHigh12 = Instance.Create(0x600b, "Threshold High");
        /// <summary>
        ///     Sensor: Threshold High Usage.
        /// </summary>
        public static readonly Usage ThresholdHigh13 = Instance.Create(0x600c, "Threshold High");
        /// <summary>
        ///     Sensor: Threshold High Usage.
        /// </summary>
        public static readonly Usage ThresholdHigh14 = Instance.Create(0x600d, "Threshold High");
        /// <summary>
        ///     Sensor: Threshold High Usage.
        /// </summary>
        public static readonly Usage ThresholdHigh15 = Instance.Create(0x600e, "Threshold High");
        /// <summary>
        ///     Sensor: Threshold High Usage.
        /// </summary>
        public static readonly Usage ThresholdHigh16 = Instance.Create(0x600f, "Threshold High");
        /// <summary>
        ///     Sensor: Threshold High Usage.
        /// </summary>
        public static readonly Usage ThresholdHigh17 = Instance.Create(0x6010, "Threshold High");
        /// <summary>
        ///     Sensor: Threshold High Usage.
        /// </summary>
        public static readonly Usage ThresholdHigh18 = Instance.Create(0x6011, "Threshold High");
        /// <summary>
        ///     Sensor: Threshold High Usage.
        /// </summary>
        public static readonly Usage ThresholdHigh19 = Instance.Create(0x6012, "Threshold High");
        /// <summary>
        ///     Sensor: Threshold High Usage.
        /// </summary>
        public static readonly Usage ThresholdHigh20 = Instance.Create(0x6013, "Threshold High");
        /// <summary>
        ///     Sensor: Threshold High Usage.
        /// </summary>
        public static readonly Usage ThresholdHigh21 = Instance.Create(0x6014, "Threshold High");
        /// <summary>
        ///     Sensor: Threshold High Usage.
        /// </summary>
        public static readonly Usage ThresholdHigh22 = Instance.Create(0x6015, "Threshold High");
        /// <summary>
        ///     Sensor: Threshold High Usage.
        /// </summary>
        public static readonly Usage ThresholdHigh23 = Instance.Create(0x6016, "Threshold High");
        /// <summary>
        ///     Sensor: Threshold High Usage.
        /// </summary>
        public static readonly Usage ThresholdHigh24 = Instance.Create(0x6017, "Threshold High");
        /// <summary>
        ///     Sensor: Threshold High Usage.
        /// </summary>
        public static readonly Usage ThresholdHigh25 = Instance.Create(0x6018, "Threshold High");
        /// <summary>
        ///     Sensor: Threshold High Usage.
        /// </summary>
        public static readonly Usage ThresholdHigh26 = Instance.Create(0x6019, "Threshold High");
        /// <summary>
        ///     Sensor: Threshold High Usage.
        /// </summary>
        public static readonly Usage ThresholdHigh27 = Instance.Create(0x601a, "Threshold High");
        /// <summary>
        ///     Sensor: Threshold High Usage.
        /// </summary>
        public static readonly Usage ThresholdHigh28 = Instance.Create(0x601b, "Threshold High");
        /// <summary>
        ///     Sensor: Threshold High Usage.
        /// </summary>
        public static readonly Usage ThresholdHigh29 = Instance.Create(0x601c, "Threshold High");
        /// <summary>
        ///     Sensor: Threshold High Usage.
        /// </summary>
        public static readonly Usage ThresholdHigh30 = Instance.Create(0x601d, "Threshold High");
        /// <summary>
        ///     Sensor: Threshold High Usage.
        /// </summary>
        public static readonly Usage ThresholdHigh31 = Instance.Create(0x601e, "Threshold High");
        /// <summary>
        ///     Sensor: Threshold High Usage.
        /// </summary>
        public static readonly Usage ThresholdHigh32 = Instance.Create(0x601f, "Threshold High");
        /// <summary>
        ///     Sensor: Threshold Low Usage.
        /// </summary>
        public static readonly Usage ThresholdLow = Instance.Create(0x7000, "Threshold Low");
        /// <summary>
        ///     Sensor: Threshold Low Usage.
        /// </summary>
        public static readonly Usage ThresholdLow2 = Instance.Create(0x7001, "Threshold Low");
        /// <summary>
        ///     Sensor: Threshold Low Usage.
        /// </summary>
        public static readonly Usage ThresholdLow3 = Instance.Create(0x7002, "Threshold Low");
        /// <summary>
        ///     Sensor: Threshold Low Usage.
        /// </summary>
        public static readonly Usage ThresholdLow4 = Instance.Create(0x7003, "Threshold Low");
        /// <summary>
        ///     Sensor: Threshold Low Usage.
        /// </summary>
        public static readonly Usage ThresholdLow5 = Instance.Create(0x7004, "Threshold Low");
        /// <summary>
        ///     Sensor: Threshold Low Usage.
        /// </summary>
        public static readonly Usage ThresholdLow6 = Instance.Create(0x7005, "Threshold Low");
        /// <summary>
        ///     Sensor: Threshold Low Usage.
        /// </summary>
        public static readonly Usage ThresholdLow7 = Instance.Create(0x7006, "Threshold Low");
        /// <summary>
        ///     Sensor: Threshold Low Usage.
        /// </summary>
        public static readonly Usage ThresholdLow8 = Instance.Create(0x7007, "Threshold Low");
        /// <summary>
        ///     Sensor: Threshold Low Usage.
        /// </summary>
        public static readonly Usage ThresholdLow9 = Instance.Create(0x7008, "Threshold Low");
        /// <summary>
        ///     Sensor: Threshold Low Usage.
        /// </summary>
        public static readonly Usage ThresholdLow10 = Instance.Create(0x7009, "Threshold Low");
        /// <summary>
        ///     Sensor: Threshold Low Usage.
        /// </summary>
        public static readonly Usage ThresholdLow11 = Instance.Create(0x700a, "Threshold Low");
        /// <summary>
        ///     Sensor: Threshold Low Usage.
        /// </summary>
        public static readonly Usage ThresholdLow12 = Instance.Create(0x700b, "Threshold Low");
        /// <summary>
        ///     Sensor: Threshold Low Usage.
        /// </summary>
        public static readonly Usage ThresholdLow13 = Instance.Create(0x700c, "Threshold Low");
        /// <summary>
        ///     Sensor: Threshold Low Usage.
        /// </summary>
        public static readonly Usage ThresholdLow14 = Instance.Create(0x700d, "Threshold Low");
        /// <summary>
        ///     Sensor: Threshold Low Usage.
        /// </summary>
        public static readonly Usage ThresholdLow15 = Instance.Create(0x700e, "Threshold Low");
        /// <summary>
        ///     Sensor: Threshold Low Usage.
        /// </summary>
        public static readonly Usage ThresholdLow16 = Instance.Create(0x700f, "Threshold Low");
        /// <summary>
        ///     Sensor: Threshold Low Usage.
        /// </summary>
        public static readonly Usage ThresholdLow17 = Instance.Create(0x7010, "Threshold Low");
        /// <summary>
        ///     Sensor: Threshold Low Usage.
        /// </summary>
        public static readonly Usage ThresholdLow18 = Instance.Create(0x7011, "Threshold Low");
        /// <summary>
        ///     Sensor: Threshold Low Usage.
        /// </summary>
        public static readonly Usage ThresholdLow19 = Instance.Create(0x7012, "Threshold Low");
        /// <summary>
        ///     Sensor: Threshold Low Usage.
        /// </summary>
        public static readonly Usage ThresholdLow20 = Instance.Create(0x7013, "Threshold Low");
        /// <summary>
        ///     Sensor: Threshold Low Usage.
        /// </summary>
        public static readonly Usage ThresholdLow21 = Instance.Create(0x7014, "Threshold Low");
        /// <summary>
        ///     Sensor: Threshold Low Usage.
        /// </summary>
        public static readonly Usage ThresholdLow22 = Instance.Create(0x7015, "Threshold Low");
        /// <summary>
        ///     Sensor: Threshold Low Usage.
        /// </summary>
        public static readonly Usage ThresholdLow23 = Instance.Create(0x7016, "Threshold Low");
        /// <summary>
        ///     Sensor: Threshold Low Usage.
        /// </summary>
        public static readonly Usage ThresholdLow24 = Instance.Create(0x7017, "Threshold Low");
        /// <summary>
        ///     Sensor: Threshold Low Usage.
        /// </summary>
        public static readonly Usage ThresholdLow25 = Instance.Create(0x7018, "Threshold Low");
        /// <summary>
        ///     Sensor: Threshold Low Usage.
        /// </summary>
        public static readonly Usage ThresholdLow26 = Instance.Create(0x7019, "Threshold Low");
        /// <summary>
        ///     Sensor: Threshold Low Usage.
        /// </summary>
        public static readonly Usage ThresholdLow27 = Instance.Create(0x701a, "Threshold Low");
        /// <summary>
        ///     Sensor: Threshold Low Usage.
        /// </summary>
        public static readonly Usage ThresholdLow28 = Instance.Create(0x701b, "Threshold Low");
        /// <summary>
        ///     Sensor: Threshold Low Usage.
        /// </summary>
        public static readonly Usage ThresholdLow29 = Instance.Create(0x701c, "Threshold Low");
        /// <summary>
        ///     Sensor: Threshold Low Usage.
        /// </summary>
        public static readonly Usage ThresholdLow30 = Instance.Create(0x701d, "Threshold Low");
        /// <summary>
        ///     Sensor: Threshold Low Usage.
        /// </summary>
        public static readonly Usage ThresholdLow31 = Instance.Create(0x701e, "Threshold Low");
        /// <summary>
        ///     Sensor: Threshold Low Usage.
        /// </summary>
        public static readonly Usage ThresholdLow32 = Instance.Create(0x701f, "Threshold Low");
        /// <summary>
        ///     Sensor: Calibration Offset Usage.
        /// </summary>
        public static readonly Usage CalibrationOffset = Instance.Create(0x8000, "Calibration Offset");
        /// <summary>
        ///     Sensor: Calibration Offset Usage.
        /// </summary>
        public static readonly Usage CalibrationOffset2 = Instance.Create(0x8001, "Calibration Offset");
        /// <summary>
        ///     Sensor: Calibration Offset Usage.
        /// </summary>
        public static readonly Usage CalibrationOffset3 = Instance.Create(0x8002, "Calibration Offset");
        /// <summary>
        ///     Sensor: Calibration Offset Usage.
        /// </summary>
        public static readonly Usage CalibrationOffset4 = Instance.Create(0x8003, "Calibration Offset");
        /// <summary>
        ///     Sensor: Calibration Offset Usage.
        /// </summary>
        public static readonly Usage CalibrationOffset5 = Instance.Create(0x8004, "Calibration Offset");
        /// <summary>
        ///     Sensor: Calibration Offset Usage.
        /// </summary>
        public static readonly Usage CalibrationOffset6 = Instance.Create(0x8005, "Calibration Offset");
        /// <summary>
        ///     Sensor: Calibration Offset Usage.
        /// </summary>
        public static readonly Usage CalibrationOffset7 = Instance.Create(0x8006, "Calibration Offset");
        /// <summary>
        ///     Sensor: Calibration Offset Usage.
        /// </summary>
        public static readonly Usage CalibrationOffset8 = Instance.Create(0x8007, "Calibration Offset");
        /// <summary>
        ///     Sensor: Calibration Offset Usage.
        /// </summary>
        public static readonly Usage CalibrationOffset9 = Instance.Create(0x8008, "Calibration Offset");
        /// <summary>
        ///     Sensor: Calibration Offset Usage.
        /// </summary>
        public static readonly Usage CalibrationOffset10 = Instance.Create(0x8009, "Calibration Offset");
        /// <summary>
        ///     Sensor: Calibration Offset Usage.
        /// </summary>
        public static readonly Usage CalibrationOffset11 = Instance.Create(0x800a, "Calibration Offset");
        /// <summary>
        ///     Sensor: Calibration Offset Usage.
        /// </summary>
        public static readonly Usage CalibrationOffset12 = Instance.Create(0x800b, "Calibration Offset");
        /// <summary>
        ///     Sensor: Calibration Offset Usage.
        /// </summary>
        public static readonly Usage CalibrationOffset13 = Instance.Create(0x800c, "Calibration Offset");
        /// <summary>
        ///     Sensor: Calibration Offset Usage.
        /// </summary>
        public static readonly Usage CalibrationOffset14 = Instance.Create(0x800d, "Calibration Offset");
        /// <summary>
        ///     Sensor: Calibration Offset Usage.
        /// </summary>
        public static readonly Usage CalibrationOffset15 = Instance.Create(0x800e, "Calibration Offset");
        /// <summary>
        ///     Sensor: Calibration Offset Usage.
        /// </summary>
        public static readonly Usage CalibrationOffset16 = Instance.Create(0x800f, "Calibration Offset");
        /// <summary>
        ///     Sensor: Calibration Offset Usage.
        /// </summary>
        public static readonly Usage CalibrationOffset17 = Instance.Create(0x8010, "Calibration Offset");
        /// <summary>
        ///     Sensor: Calibration Offset Usage.
        /// </summary>
        public static readonly Usage CalibrationOffset18 = Instance.Create(0x8011, "Calibration Offset");
        /// <summary>
        ///     Sensor: Calibration Offset Usage.
        /// </summary>
        public static readonly Usage CalibrationOffset19 = Instance.Create(0x8012, "Calibration Offset");
        /// <summary>
        ///     Sensor: Calibration Offset Usage.
        /// </summary>
        public static readonly Usage CalibrationOffset20 = Instance.Create(0x8013, "Calibration Offset");
        /// <summary>
        ///     Sensor: Calibration Offset Usage.
        /// </summary>
        public static readonly Usage CalibrationOffset21 = Instance.Create(0x8014, "Calibration Offset");
        /// <summary>
        ///     Sensor: Calibration Offset Usage.
        /// </summary>
        public static readonly Usage CalibrationOffset22 = Instance.Create(0x8015, "Calibration Offset");
        /// <summary>
        ///     Sensor: Calibration Offset Usage.
        /// </summary>
        public static readonly Usage CalibrationOffset23 = Instance.Create(0x8016, "Calibration Offset");
        /// <summary>
        ///     Sensor: Calibration Offset Usage.
        /// </summary>
        public static readonly Usage CalibrationOffset24 = Instance.Create(0x8017, "Calibration Offset");
        /// <summary>
        ///     Sensor: Calibration Offset Usage.
        /// </summary>
        public static readonly Usage CalibrationOffset25 = Instance.Create(0x8018, "Calibration Offset");
        /// <summary>
        ///     Sensor: Calibration Offset Usage.
        /// </summary>
        public static readonly Usage CalibrationOffset26 = Instance.Create(0x8019, "Calibration Offset");
        /// <summary>
        ///     Sensor: Calibration Offset Usage.
        /// </summary>
        public static readonly Usage CalibrationOffset27 = Instance.Create(0x801a, "Calibration Offset");
        /// <summary>
        ///     Sensor: Calibration Offset Usage.
        /// </summary>
        public static readonly Usage CalibrationOffset28 = Instance.Create(0x801b, "Calibration Offset");
        /// <summary>
        ///     Sensor: Calibration Offset Usage.
        /// </summary>
        public static readonly Usage CalibrationOffset29 = Instance.Create(0x801c, "Calibration Offset");
        /// <summary>
        ///     Sensor: Calibration Offset Usage.
        /// </summary>
        public static readonly Usage CalibrationOffset30 = Instance.Create(0x801d, "Calibration Offset");
        /// <summary>
        ///     Sensor: Calibration Offset Usage.
        /// </summary>
        public static readonly Usage CalibrationOffset31 = Instance.Create(0x801e, "Calibration Offset");
        /// <summary>
        ///     Sensor: Calibration Offset Usage.
        /// </summary>
        public static readonly Usage CalibrationOffset32 = Instance.Create(0x801f, "Calibration Offset");
        /// <summary>
        ///     Sensor: Calibration Multiplier Usage.
        /// </summary>
        public static readonly Usage CalibrationMultiplier = Instance.Create(0x9000, "Calibration Multiplier");
        /// <summary>
        ///     Sensor: Calibration Multiplier Usage.
        /// </summary>
        public static readonly Usage CalibrationMultiplier2 = Instance.Create(0x9001, "Calibration Multiplier");
        /// <summary>
        ///     Sensor: Calibration Multiplier Usage.
        /// </summary>
        public static readonly Usage CalibrationMultiplier3 = Instance.Create(0x9002, "Calibration Multiplier");
        /// <summary>
        ///     Sensor: Calibration Multiplier Usage.
        /// </summary>
        public static readonly Usage CalibrationMultiplier4 = Instance.Create(0x9003, "Calibration Multiplier");
        /// <summary>
        ///     Sensor: Calibration Multiplier Usage.
        /// </summary>
        public static readonly Usage CalibrationMultiplier5 = Instance.Create(0x9004, "Calibration Multiplier");
        /// <summary>
        ///     Sensor: Calibration Multiplier Usage.
        /// </summary>
        public static readonly Usage CalibrationMultiplier6 = Instance.Create(0x9005, "Calibration Multiplier");
        /// <summary>
        ///     Sensor: Calibration Multiplier Usage.
        /// </summary>
        public static readonly Usage CalibrationMultiplier7 = Instance.Create(0x9006, "Calibration Multiplier");
        /// <summary>
        ///     Sensor: Calibration Multiplier Usage.
        /// </summary>
        public static readonly Usage CalibrationMultiplier8 = Instance.Create(0x9007, "Calibration Multiplier");
        /// <summary>
        ///     Sensor: Calibration Multiplier Usage.
        /// </summary>
        public static readonly Usage CalibrationMultiplier9 = Instance.Create(0x9008, "Calibration Multiplier");
        /// <summary>
        ///     Sensor: Calibration Multiplier Usage.
        /// </summary>
        public static readonly Usage CalibrationMultiplier10 = Instance.Create(0x9009, "Calibration Multiplier");
        /// <summary>
        ///     Sensor: Calibration Multiplier Usage.
        /// </summary>
        public static readonly Usage CalibrationMultiplier11 = Instance.Create(0x900a, "Calibration Multiplier");
        /// <summary>
        ///     Sensor: Calibration Multiplier Usage.
        /// </summary>
        public static readonly Usage CalibrationMultiplier12 = Instance.Create(0x900b, "Calibration Multiplier");
        /// <summary>
        ///     Sensor: Calibration Multiplier Usage.
        /// </summary>
        public static readonly Usage CalibrationMultiplier13 = Instance.Create(0x900c, "Calibration Multiplier");
        /// <summary>
        ///     Sensor: Calibration Multiplier Usage.
        /// </summary>
        public static readonly Usage CalibrationMultiplier14 = Instance.Create(0x900d, "Calibration Multiplier");
        /// <summary>
        ///     Sensor: Calibration Multiplier Usage.
        /// </summary>
        public static readonly Usage CalibrationMultiplier15 = Instance.Create(0x900e, "Calibration Multiplier");
        /// <summary>
        ///     Sensor: Calibration Multiplier Usage.
        /// </summary>
        public static readonly Usage CalibrationMultiplier16 = Instance.Create(0x900f, "Calibration Multiplier");
        /// <summary>
        ///     Sensor: Calibration Multiplier Usage.
        /// </summary>
        public static readonly Usage CalibrationMultiplier17 = Instance.Create(0x9010, "Calibration Multiplier");
        /// <summary>
        ///     Sensor: Calibration Multiplier Usage.
        /// </summary>
        public static readonly Usage CalibrationMultiplier18 = Instance.Create(0x9011, "Calibration Multiplier");
        /// <summary>
        ///     Sensor: Calibration Multiplier Usage.
        /// </summary>
        public static readonly Usage CalibrationMultiplier19 = Instance.Create(0x9012, "Calibration Multiplier");
        /// <summary>
        ///     Sensor: Calibration Multiplier Usage.
        /// </summary>
        public static readonly Usage CalibrationMultiplier20 = Instance.Create(0x9013, "Calibration Multiplier");
        /// <summary>
        ///     Sensor: Calibration Multiplier Usage.
        /// </summary>
        public static readonly Usage CalibrationMultiplier21 = Instance.Create(0x9014, "Calibration Multiplier");
        /// <summary>
        ///     Sensor: Calibration Multiplier Usage.
        /// </summary>
        public static readonly Usage CalibrationMultiplier22 = Instance.Create(0x9015, "Calibration Multiplier");
        /// <summary>
        ///     Sensor: Calibration Multiplier Usage.
        /// </summary>
        public static readonly Usage CalibrationMultiplier23 = Instance.Create(0x9016, "Calibration Multiplier");
        /// <summary>
        ///     Sensor: Calibration Multiplier Usage.
        /// </summary>
        public static readonly Usage CalibrationMultiplier24 = Instance.Create(0x9017, "Calibration Multiplier");
        /// <summary>
        ///     Sensor: Calibration Multiplier Usage.
        /// </summary>
        public static readonly Usage CalibrationMultiplier25 = Instance.Create(0x9018, "Calibration Multiplier");
        /// <summary>
        ///     Sensor: Calibration Multiplier Usage.
        /// </summary>
        public static readonly Usage CalibrationMultiplier26 = Instance.Create(0x9019, "Calibration Multiplier");
        /// <summary>
        ///     Sensor: Calibration Multiplier Usage.
        /// </summary>
        public static readonly Usage CalibrationMultiplier27 = Instance.Create(0x901a, "Calibration Multiplier");
        /// <summary>
        ///     Sensor: Calibration Multiplier Usage.
        /// </summary>
        public static readonly Usage CalibrationMultiplier28 = Instance.Create(0x901b, "Calibration Multiplier");
        /// <summary>
        ///     Sensor: Calibration Multiplier Usage.
        /// </summary>
        public static readonly Usage CalibrationMultiplier29 = Instance.Create(0x901c, "Calibration Multiplier");
        /// <summary>
        ///     Sensor: Calibration Multiplier Usage.
        /// </summary>
        public static readonly Usage CalibrationMultiplier30 = Instance.Create(0x901d, "Calibration Multiplier");
        /// <summary>
        ///     Sensor: Calibration Multiplier Usage.
        /// </summary>
        public static readonly Usage CalibrationMultiplier31 = Instance.Create(0x901e, "Calibration Multiplier");
        /// <summary>
        ///     Sensor: Calibration Multiplier Usage.
        /// </summary>
        public static readonly Usage CalibrationMultiplier32 = Instance.Create(0x901f, "Calibration Multiplier");
        /// <summary>
        ///     Sensor: Report Interval Usage.
        /// </summary>
        public static readonly Usage ReportInterval = Instance.Create(0xa000, "Report Interval");
        /// <summary>
        ///     Sensor: Report Interval Usage.
        /// </summary>
        public static readonly Usage ReportInterval2 = Instance.Create(0xa001, "Report Interval");
        /// <summary>
        ///     Sensor: Report Interval Usage.
        /// </summary>
        public static readonly Usage ReportInterval3 = Instance.Create(0xa002, "Report Interval");
        /// <summary>
        ///     Sensor: Report Interval Usage.
        /// </summary>
        public static readonly Usage ReportInterval4 = Instance.Create(0xa003, "Report Interval");
        /// <summary>
        ///     Sensor: Report Interval Usage.
        /// </summary>
        public static readonly Usage ReportInterval5 = Instance.Create(0xa004, "Report Interval");
        /// <summary>
        ///     Sensor: Report Interval Usage.
        /// </summary>
        public static readonly Usage ReportInterval6 = Instance.Create(0xa005, "Report Interval");
        /// <summary>
        ///     Sensor: Report Interval Usage.
        /// </summary>
        public static readonly Usage ReportInterval7 = Instance.Create(0xa006, "Report Interval");
        /// <summary>
        ///     Sensor: Report Interval Usage.
        /// </summary>
        public static readonly Usage ReportInterval8 = Instance.Create(0xa007, "Report Interval");
        /// <summary>
        ///     Sensor: Report Interval Usage.
        /// </summary>
        public static readonly Usage ReportInterval9 = Instance.Create(0xa008, "Report Interval");
        /// <summary>
        ///     Sensor: Report Interval Usage.
        /// </summary>
        public static readonly Usage ReportInterval10 = Instance.Create(0xa009, "Report Interval");
        /// <summary>
        ///     Sensor: Report Interval Usage.
        /// </summary>
        public static readonly Usage ReportInterval11 = Instance.Create(0xa00a, "Report Interval");
        /// <summary>
        ///     Sensor: Report Interval Usage.
        /// </summary>
        public static readonly Usage ReportInterval12 = Instance.Create(0xa00b, "Report Interval");
        /// <summary>
        ///     Sensor: Report Interval Usage.
        /// </summary>
        public static readonly Usage ReportInterval13 = Instance.Create(0xa00c, "Report Interval");
        /// <summary>
        ///     Sensor: Report Interval Usage.
        /// </summary>
        public static readonly Usage ReportInterval14 = Instance.Create(0xa00d, "Report Interval");
        /// <summary>
        ///     Sensor: Report Interval Usage.
        /// </summary>
        public static readonly Usage ReportInterval15 = Instance.Create(0xa00e, "Report Interval");
        /// <summary>
        ///     Sensor: Report Interval Usage.
        /// </summary>
        public static readonly Usage ReportInterval16 = Instance.Create(0xa00f, "Report Interval");
        /// <summary>
        ///     Sensor: Report Interval Usage.
        /// </summary>
        public static readonly Usage ReportInterval17 = Instance.Create(0xa010, "Report Interval");
        /// <summary>
        ///     Sensor: Report Interval Usage.
        /// </summary>
        public static readonly Usage ReportInterval18 = Instance.Create(0xa011, "Report Interval");
        /// <summary>
        ///     Sensor: Report Interval Usage.
        /// </summary>
        public static readonly Usage ReportInterval19 = Instance.Create(0xa012, "Report Interval");
        /// <summary>
        ///     Sensor: Report Interval Usage.
        /// </summary>
        public static readonly Usage ReportInterval20 = Instance.Create(0xa013, "Report Interval");
        /// <summary>
        ///     Sensor: Report Interval Usage.
        /// </summary>
        public static readonly Usage ReportInterval21 = Instance.Create(0xa014, "Report Interval");
        /// <summary>
        ///     Sensor: Report Interval Usage.
        /// </summary>
        public static readonly Usage ReportInterval22 = Instance.Create(0xa015, "Report Interval");
        /// <summary>
        ///     Sensor: Report Interval Usage.
        /// </summary>
        public static readonly Usage ReportInterval23 = Instance.Create(0xa016, "Report Interval");
        /// <summary>
        ///     Sensor: Report Interval Usage.
        /// </summary>
        public static readonly Usage ReportInterval24 = Instance.Create(0xa017, "Report Interval");
        /// <summary>
        ///     Sensor: Report Interval Usage.
        /// </summary>
        public static readonly Usage ReportInterval25 = Instance.Create(0xa018, "Report Interval");
        /// <summary>
        ///     Sensor: Report Interval Usage.
        /// </summary>
        public static readonly Usage ReportInterval26 = Instance.Create(0xa019, "Report Interval");
        /// <summary>
        ///     Sensor: Report Interval Usage.
        /// </summary>
        public static readonly Usage ReportInterval27 = Instance.Create(0xa01a, "Report Interval");
        /// <summary>
        ///     Sensor: Report Interval Usage.
        /// </summary>
        public static readonly Usage ReportInterval28 = Instance.Create(0xa01b, "Report Interval");
        /// <summary>
        ///     Sensor: Report Interval Usage.
        /// </summary>
        public static readonly Usage ReportInterval29 = Instance.Create(0xa01c, "Report Interval");
        /// <summary>
        ///     Sensor: Report Interval Usage.
        /// </summary>
        public static readonly Usage ReportInterval30 = Instance.Create(0xa01d, "Report Interval");
        /// <summary>
        ///     Sensor: Report Interval Usage.
        /// </summary>
        public static readonly Usage ReportInterval31 = Instance.Create(0xa01e, "Report Interval");
        /// <summary>
        ///     Sensor: Report Interval Usage.
        /// </summary>
        public static readonly Usage ReportInterval32 = Instance.Create(0xa01f, "Report Interval");
        /// <summary>
        ///     Sensor: Frequency Max Usage.
        /// </summary>
        public static readonly Usage FrequencyMax = Instance.Create(0xb000, "Frequency Max");
        /// <summary>
        ///     Sensor: Frequency Max Usage.
        /// </summary>
        public static readonly Usage FrequencyMax2 = Instance.Create(0xb001, "Frequency Max");
        /// <summary>
        ///     Sensor: Frequency Max Usage.
        /// </summary>
        public static readonly Usage FrequencyMax3 = Instance.Create(0xb002, "Frequency Max");
        /// <summary>
        ///     Sensor: Frequency Max Usage.
        /// </summary>
        public static readonly Usage FrequencyMax4 = Instance.Create(0xb003, "Frequency Max");
        /// <summary>
        ///     Sensor: Frequency Max Usage.
        /// </summary>
        public static readonly Usage FrequencyMax5 = Instance.Create(0xb004, "Frequency Max");
        /// <summary>
        ///     Sensor: Frequency Max Usage.
        /// </summary>
        public static readonly Usage FrequencyMax6 = Instance.Create(0xb005, "Frequency Max");
        /// <summary>
        ///     Sensor: Frequency Max Usage.
        /// </summary>
        public static readonly Usage FrequencyMax7 = Instance.Create(0xb006, "Frequency Max");
        /// <summary>
        ///     Sensor: Frequency Max Usage.
        /// </summary>
        public static readonly Usage FrequencyMax8 = Instance.Create(0xb007, "Frequency Max");
        /// <summary>
        ///     Sensor: Frequency Max Usage.
        /// </summary>
        public static readonly Usage FrequencyMax9 = Instance.Create(0xb008, "Frequency Max");
        /// <summary>
        ///     Sensor: Frequency Max Usage.
        /// </summary>
        public static readonly Usage FrequencyMax10 = Instance.Create(0xb009, "Frequency Max");
        /// <summary>
        ///     Sensor: Frequency Max Usage.
        /// </summary>
        public static readonly Usage FrequencyMax11 = Instance.Create(0xb00a, "Frequency Max");
        /// <summary>
        ///     Sensor: Frequency Max Usage.
        /// </summary>
        public static readonly Usage FrequencyMax12 = Instance.Create(0xb00b, "Frequency Max");
        /// <summary>
        ///     Sensor: Frequency Max Usage.
        /// </summary>
        public static readonly Usage FrequencyMax13 = Instance.Create(0xb00c, "Frequency Max");
        /// <summary>
        ///     Sensor: Frequency Max Usage.
        /// </summary>
        public static readonly Usage FrequencyMax14 = Instance.Create(0xb00d, "Frequency Max");
        /// <summary>
        ///     Sensor: Frequency Max Usage.
        /// </summary>
        public static readonly Usage FrequencyMax15 = Instance.Create(0xb00e, "Frequency Max");
        /// <summary>
        ///     Sensor: Frequency Max Usage.
        /// </summary>
        public static readonly Usage FrequencyMax16 = Instance.Create(0xb00f, "Frequency Max");
        /// <summary>
        ///     Sensor: Frequency Max Usage.
        /// </summary>
        public static readonly Usage FrequencyMax17 = Instance.Create(0xb010, "Frequency Max");
        /// <summary>
        ///     Sensor: Frequency Max Usage.
        /// </summary>
        public static readonly Usage FrequencyMax18 = Instance.Create(0xb011, "Frequency Max");
        /// <summary>
        ///     Sensor: Frequency Max Usage.
        /// </summary>
        public static readonly Usage FrequencyMax19 = Instance.Create(0xb012, "Frequency Max");
        /// <summary>
        ///     Sensor: Frequency Max Usage.
        /// </summary>
        public static readonly Usage FrequencyMax20 = Instance.Create(0xb013, "Frequency Max");
        /// <summary>
        ///     Sensor: Frequency Max Usage.
        /// </summary>
        public static readonly Usage FrequencyMax21 = Instance.Create(0xb014, "Frequency Max");
        /// <summary>
        ///     Sensor: Frequency Max Usage.
        /// </summary>
        public static readonly Usage FrequencyMax22 = Instance.Create(0xb015, "Frequency Max");
        /// <summary>
        ///     Sensor: Frequency Max Usage.
        /// </summary>
        public static readonly Usage FrequencyMax23 = Instance.Create(0xb016, "Frequency Max");
        /// <summary>
        ///     Sensor: Frequency Max Usage.
        /// </summary>
        public static readonly Usage FrequencyMax24 = Instance.Create(0xb017, "Frequency Max");
        /// <summary>
        ///     Sensor: Frequency Max Usage.
        /// </summary>
        public static readonly Usage FrequencyMax25 = Instance.Create(0xb018, "Frequency Max");
        /// <summary>
        ///     Sensor: Frequency Max Usage.
        /// </summary>
        public static readonly Usage FrequencyMax26 = Instance.Create(0xb019, "Frequency Max");
        /// <summary>
        ///     Sensor: Frequency Max Usage.
        /// </summary>
        public static readonly Usage FrequencyMax27 = Instance.Create(0xb01a, "Frequency Max");
        /// <summary>
        ///     Sensor: Frequency Max Usage.
        /// </summary>
        public static readonly Usage FrequencyMax28 = Instance.Create(0xb01b, "Frequency Max");
        /// <summary>
        ///     Sensor: Frequency Max Usage.
        /// </summary>
        public static readonly Usage FrequencyMax29 = Instance.Create(0xb01c, "Frequency Max");
        /// <summary>
        ///     Sensor: Frequency Max Usage.
        /// </summary>
        public static readonly Usage FrequencyMax30 = Instance.Create(0xb01d, "Frequency Max");
        /// <summary>
        ///     Sensor: Frequency Max Usage.
        /// </summary>
        public static readonly Usage FrequencyMax31 = Instance.Create(0xb01e, "Frequency Max");
        /// <summary>
        ///     Sensor: Frequency Max Usage.
        /// </summary>
        public static readonly Usage FrequencyMax32 = Instance.Create(0xb01f, "Frequency Max");
        /// <summary>
        ///     Sensor: Period Max Usage.
        /// </summary>
        public static readonly Usage PeriodMax = Instance.Create(0xc000, "Period Max");
        /// <summary>
        ///     Sensor: Period Max Usage.
        /// </summary>
        public static readonly Usage PeriodMax2 = Instance.Create(0xc001, "Period Max");
        /// <summary>
        ///     Sensor: Period Max Usage.
        /// </summary>
        public static readonly Usage PeriodMax3 = Instance.Create(0xc002, "Period Max");
        /// <summary>
        ///     Sensor: Period Max Usage.
        /// </summary>
        public static readonly Usage PeriodMax4 = Instance.Create(0xc003, "Period Max");
        /// <summary>
        ///     Sensor: Period Max Usage.
        /// </summary>
        public static readonly Usage PeriodMax5 = Instance.Create(0xc004, "Period Max");
        /// <summary>
        ///     Sensor: Period Max Usage.
        /// </summary>
        public static readonly Usage PeriodMax6 = Instance.Create(0xc005, "Period Max");
        /// <summary>
        ///     Sensor: Period Max Usage.
        /// </summary>
        public static readonly Usage PeriodMax7 = Instance.Create(0xc006, "Period Max");
        /// <summary>
        ///     Sensor: Period Max Usage.
        /// </summary>
        public static readonly Usage PeriodMax8 = Instance.Create(0xc007, "Period Max");
        /// <summary>
        ///     Sensor: Period Max Usage.
        /// </summary>
        public static readonly Usage PeriodMax9 = Instance.Create(0xc008, "Period Max");
        /// <summary>
        ///     Sensor: Period Max Usage.
        /// </summary>
        public static readonly Usage PeriodMax10 = Instance.Create(0xc009, "Period Max");
        /// <summary>
        ///     Sensor: Period Max Usage.
        /// </summary>
        public static readonly Usage PeriodMax11 = Instance.Create(0xc00a, "Period Max");
        /// <summary>
        ///     Sensor: Period Max Usage.
        /// </summary>
        public static readonly Usage PeriodMax12 = Instance.Create(0xc00b, "Period Max");
        /// <summary>
        ///     Sensor: Period Max Usage.
        /// </summary>
        public static readonly Usage PeriodMax13 = Instance.Create(0xc00c, "Period Max");
        /// <summary>
        ///     Sensor: Period Max Usage.
        /// </summary>
        public static readonly Usage PeriodMax14 = Instance.Create(0xc00d, "Period Max");
        /// <summary>
        ///     Sensor: Period Max Usage.
        /// </summary>
        public static readonly Usage PeriodMax15 = Instance.Create(0xc00e, "Period Max");
        /// <summary>
        ///     Sensor: Period Max Usage.
        /// </summary>
        public static readonly Usage PeriodMax16 = Instance.Create(0xc00f, "Period Max");
        /// <summary>
        ///     Sensor: Period Max Usage.
        /// </summary>
        public static readonly Usage PeriodMax17 = Instance.Create(0xc010, "Period Max");
        /// <summary>
        ///     Sensor: Period Max Usage.
        /// </summary>
        public static readonly Usage PeriodMax18 = Instance.Create(0xc011, "Period Max");
        /// <summary>
        ///     Sensor: Period Max Usage.
        /// </summary>
        public static readonly Usage PeriodMax19 = Instance.Create(0xc012, "Period Max");
        /// <summary>
        ///     Sensor: Period Max Usage.
        /// </summary>
        public static readonly Usage PeriodMax20 = Instance.Create(0xc013, "Period Max");
        /// <summary>
        ///     Sensor: Period Max Usage.
        /// </summary>
        public static readonly Usage PeriodMax21 = Instance.Create(0xc014, "Period Max");
        /// <summary>
        ///     Sensor: Period Max Usage.
        /// </summary>
        public static readonly Usage PeriodMax22 = Instance.Create(0xc015, "Period Max");
        /// <summary>
        ///     Sensor: Period Max Usage.
        /// </summary>
        public static readonly Usage PeriodMax23 = Instance.Create(0xc016, "Period Max");
        /// <summary>
        ///     Sensor: Period Max Usage.
        /// </summary>
        public static readonly Usage PeriodMax24 = Instance.Create(0xc017, "Period Max");
        /// <summary>
        ///     Sensor: Period Max Usage.
        /// </summary>
        public static readonly Usage PeriodMax25 = Instance.Create(0xc018, "Period Max");
        /// <summary>
        ///     Sensor: Period Max Usage.
        /// </summary>
        public static readonly Usage PeriodMax26 = Instance.Create(0xc019, "Period Max");
        /// <summary>
        ///     Sensor: Period Max Usage.
        /// </summary>
        public static readonly Usage PeriodMax27 = Instance.Create(0xc01a, "Period Max");
        /// <summary>
        ///     Sensor: Period Max Usage.
        /// </summary>
        public static readonly Usage PeriodMax28 = Instance.Create(0xc01b, "Period Max");
        /// <summary>
        ///     Sensor: Period Max Usage.
        /// </summary>
        public static readonly Usage PeriodMax29 = Instance.Create(0xc01c, "Period Max");
        /// <summary>
        ///     Sensor: Period Max Usage.
        /// </summary>
        public static readonly Usage PeriodMax30 = Instance.Create(0xc01d, "Period Max");
        /// <summary>
        ///     Sensor: Period Max Usage.
        /// </summary>
        public static readonly Usage PeriodMax31 = Instance.Create(0xc01e, "Period Max");
        /// <summary>
        ///     Sensor: Period Max Usage.
        /// </summary>
        public static readonly Usage PeriodMax32 = Instance.Create(0xc01f, "Period Max");
        /// <summary>
        ///     Sensor: Change Sensitivity Percent of Range Usage.
        /// </summary>
        public static readonly Usage ChangeSensitivityPercentOfRange = Instance.Create(0xd000, "Change Sensitivity Percent of Range");
        /// <summary>
        ///     Sensor: Change Sensitivity Percent of Range Usage.
        /// </summary>
        public static readonly Usage ChangeSensitivityPercentOfRange2 = Instance.Create(0xd001, "Change Sensitivity Percent of Range");
        /// <summary>
        ///     Sensor: Change Sensitivity Percent of Range Usage.
        /// </summary>
        public static readonly Usage ChangeSensitivityPercentOfRange3 = Instance.Create(0xd002, "Change Sensitivity Percent of Range");
        /// <summary>
        ///     Sensor: Change Sensitivity Percent of Range Usage.
        /// </summary>
        public static readonly Usage ChangeSensitivityPercentOfRange4 = Instance.Create(0xd003, "Change Sensitivity Percent of Range");
        /// <summary>
        ///     Sensor: Change Sensitivity Percent of Range Usage.
        /// </summary>
        public static readonly Usage ChangeSensitivityPercentOfRange5 = Instance.Create(0xd004, "Change Sensitivity Percent of Range");
        /// <summary>
        ///     Sensor: Change Sensitivity Percent of Range Usage.
        /// </summary>
        public static readonly Usage ChangeSensitivityPercentOfRange6 = Instance.Create(0xd005, "Change Sensitivity Percent of Range");
        /// <summary>
        ///     Sensor: Change Sensitivity Percent of Range Usage.
        /// </summary>
        public static readonly Usage ChangeSensitivityPercentOfRange7 = Instance.Create(0xd006, "Change Sensitivity Percent of Range");
        /// <summary>
        ///     Sensor: Change Sensitivity Percent of Range Usage.
        /// </summary>
        public static readonly Usage ChangeSensitivityPercentOfRange8 = Instance.Create(0xd007, "Change Sensitivity Percent of Range");
        /// <summary>
        ///     Sensor: Change Sensitivity Percent of Range Usage.
        /// </summary>
        public static readonly Usage ChangeSensitivityPercentOfRange9 = Instance.Create(0xd008, "Change Sensitivity Percent of Range");
        /// <summary>
        ///     Sensor: Change Sensitivity Percent of Range Usage.
        /// </summary>
        public static readonly Usage ChangeSensitivityPercentOfRange10 = Instance.Create(0xd009, "Change Sensitivity Percent of Range");
        /// <summary>
        ///     Sensor: Change Sensitivity Percent of Range Usage.
        /// </summary>
        public static readonly Usage ChangeSensitivityPercentOfRange11 = Instance.Create(0xd00a, "Change Sensitivity Percent of Range");
        /// <summary>
        ///     Sensor: Change Sensitivity Percent of Range Usage.
        /// </summary>
        public static readonly Usage ChangeSensitivityPercentOfRange12 = Instance.Create(0xd00b, "Change Sensitivity Percent of Range");
        /// <summary>
        ///     Sensor: Change Sensitivity Percent of Range Usage.
        /// </summary>
        public static readonly Usage ChangeSensitivityPercentOfRange13 = Instance.Create(0xd00c, "Change Sensitivity Percent of Range");
        /// <summary>
        ///     Sensor: Change Sensitivity Percent of Range Usage.
        /// </summary>
        public static readonly Usage ChangeSensitivityPercentOfRange14 = Instance.Create(0xd00d, "Change Sensitivity Percent of Range");
        /// <summary>
        ///     Sensor: Change Sensitivity Percent of Range Usage.
        /// </summary>
        public static readonly Usage ChangeSensitivityPercentOfRange15 = Instance.Create(0xd00e, "Change Sensitivity Percent of Range");
        /// <summary>
        ///     Sensor: Change Sensitivity Percent of Range Usage.
        /// </summary>
        public static readonly Usage ChangeSensitivityPercentOfRange16 = Instance.Create(0xd00f, "Change Sensitivity Percent of Range");
        /// <summary>
        ///     Sensor: Change Sensitivity Percent of Range Usage.
        /// </summary>
        public static readonly Usage ChangeSensitivityPercentOfRange17 = Instance.Create(0xd010, "Change Sensitivity Percent of Range");
        /// <summary>
        ///     Sensor: Change Sensitivity Percent of Range Usage.
        /// </summary>
        public static readonly Usage ChangeSensitivityPercentOfRange18 = Instance.Create(0xd011, "Change Sensitivity Percent of Range");
        /// <summary>
        ///     Sensor: Change Sensitivity Percent of Range Usage.
        /// </summary>
        public static readonly Usage ChangeSensitivityPercentOfRange19 = Instance.Create(0xd012, "Change Sensitivity Percent of Range");
        /// <summary>
        ///     Sensor: Change Sensitivity Percent of Range Usage.
        /// </summary>
        public static readonly Usage ChangeSensitivityPercentOfRange20 = Instance.Create(0xd013, "Change Sensitivity Percent of Range");
        /// <summary>
        ///     Sensor: Change Sensitivity Percent of Range Usage.
        /// </summary>
        public static readonly Usage ChangeSensitivityPercentOfRange21 = Instance.Create(0xd014, "Change Sensitivity Percent of Range");
        /// <summary>
        ///     Sensor: Change Sensitivity Percent of Range Usage.
        /// </summary>
        public static readonly Usage ChangeSensitivityPercentOfRange22 = Instance.Create(0xd015, "Change Sensitivity Percent of Range");
        /// <summary>
        ///     Sensor: Change Sensitivity Percent of Range Usage.
        /// </summary>
        public static readonly Usage ChangeSensitivityPercentOfRange23 = Instance.Create(0xd016, "Change Sensitivity Percent of Range");
        /// <summary>
        ///     Sensor: Change Sensitivity Percent of Range Usage.
        /// </summary>
        public static readonly Usage ChangeSensitivityPercentOfRange24 = Instance.Create(0xd017, "Change Sensitivity Percent of Range");
        /// <summary>
        ///     Sensor: Change Sensitivity Percent of Range Usage.
        /// </summary>
        public static readonly Usage ChangeSensitivityPercentOfRange25 = Instance.Create(0xd018, "Change Sensitivity Percent of Range");
        /// <summary>
        ///     Sensor: Change Sensitivity Percent of Range Usage.
        /// </summary>
        public static readonly Usage ChangeSensitivityPercentOfRange26 = Instance.Create(0xd019, "Change Sensitivity Percent of Range");
        /// <summary>
        ///     Sensor: Change Sensitivity Percent of Range Usage.
        /// </summary>
        public static readonly Usage ChangeSensitivityPercentOfRange27 = Instance.Create(0xd01a, "Change Sensitivity Percent of Range");
        /// <summary>
        ///     Sensor: Change Sensitivity Percent of Range Usage.
        /// </summary>
        public static readonly Usage ChangeSensitivityPercentOfRange28 = Instance.Create(0xd01b, "Change Sensitivity Percent of Range");
        /// <summary>
        ///     Sensor: Change Sensitivity Percent of Range Usage.
        /// </summary>
        public static readonly Usage ChangeSensitivityPercentOfRange29 = Instance.Create(0xd01c, "Change Sensitivity Percent of Range");
        /// <summary>
        ///     Sensor: Change Sensitivity Percent of Range Usage.
        /// </summary>
        public static readonly Usage ChangeSensitivityPercentOfRange30 = Instance.Create(0xd01d, "Change Sensitivity Percent of Range");
        /// <summary>
        ///     Sensor: Change Sensitivity Percent of Range Usage.
        /// </summary>
        public static readonly Usage ChangeSensitivityPercentOfRange31 = Instance.Create(0xd01e, "Change Sensitivity Percent of Range");
        /// <summary>
        ///     Sensor: Change Sensitivity Percent of Range Usage.
        /// </summary>
        public static readonly Usage ChangeSensitivityPercentOfRange32 = Instance.Create(0xd01f, "Change Sensitivity Percent of Range");
        /// <summary>
        ///     Sensor: Change Sensitivity Percent Relative Usage.
        /// </summary>
        public static readonly Usage ChangeSensitivityPercentRelative = Instance.Create(0xe000, "Change Sensitivity Percent Relative");
        /// <summary>
        ///     Sensor: Change Sensitivity Percent Relative Usage.
        /// </summary>
        public static readonly Usage ChangeSensitivityPercentRelative2 = Instance.Create(0xe001, "Change Sensitivity Percent Relative");
        /// <summary>
        ///     Sensor: Change Sensitivity Percent Relative Usage.
        /// </summary>
        public static readonly Usage ChangeSensitivityPercentRelative3 = Instance.Create(0xe002, "Change Sensitivity Percent Relative");
        /// <summary>
        ///     Sensor: Change Sensitivity Percent Relative Usage.
        /// </summary>
        public static readonly Usage ChangeSensitivityPercentRelative4 = Instance.Create(0xe003, "Change Sensitivity Percent Relative");
        /// <summary>
        ///     Sensor: Change Sensitivity Percent Relative Usage.
        /// </summary>
        public static readonly Usage ChangeSensitivityPercentRelative5 = Instance.Create(0xe004, "Change Sensitivity Percent Relative");
        /// <summary>
        ///     Sensor: Change Sensitivity Percent Relative Usage.
        /// </summary>
        public static readonly Usage ChangeSensitivityPercentRelative6 = Instance.Create(0xe005, "Change Sensitivity Percent Relative");
        /// <summary>
        ///     Sensor: Change Sensitivity Percent Relative Usage.
        /// </summary>
        public static readonly Usage ChangeSensitivityPercentRelative7 = Instance.Create(0xe006, "Change Sensitivity Percent Relative");
        /// <summary>
        ///     Sensor: Change Sensitivity Percent Relative Usage.
        /// </summary>
        public static readonly Usage ChangeSensitivityPercentRelative8 = Instance.Create(0xe007, "Change Sensitivity Percent Relative");
        /// <summary>
        ///     Sensor: Change Sensitivity Percent Relative Usage.
        /// </summary>
        public static readonly Usage ChangeSensitivityPercentRelative9 = Instance.Create(0xe008, "Change Sensitivity Percent Relative");
        /// <summary>
        ///     Sensor: Change Sensitivity Percent Relative Usage.
        /// </summary>
        public static readonly Usage ChangeSensitivityPercentRelative10 = Instance.Create(0xe009, "Change Sensitivity Percent Relative");
        /// <summary>
        ///     Sensor: Change Sensitivity Percent Relative Usage.
        /// </summary>
        public static readonly Usage ChangeSensitivityPercentRelative11 = Instance.Create(0xe00a, "Change Sensitivity Percent Relative");
        /// <summary>
        ///     Sensor: Change Sensitivity Percent Relative Usage.
        /// </summary>
        public static readonly Usage ChangeSensitivityPercentRelative12 = Instance.Create(0xe00b, "Change Sensitivity Percent Relative");
        /// <summary>
        ///     Sensor: Change Sensitivity Percent Relative Usage.
        /// </summary>
        public static readonly Usage ChangeSensitivityPercentRelative13 = Instance.Create(0xe00c, "Change Sensitivity Percent Relative");
        /// <summary>
        ///     Sensor: Change Sensitivity Percent Relative Usage.
        /// </summary>
        public static readonly Usage ChangeSensitivityPercentRelative14 = Instance.Create(0xe00d, "Change Sensitivity Percent Relative");
        /// <summary>
        ///     Sensor: Change Sensitivity Percent Relative Usage.
        /// </summary>
        public static readonly Usage ChangeSensitivityPercentRelative15 = Instance.Create(0xe00e, "Change Sensitivity Percent Relative");
        /// <summary>
        ///     Sensor: Change Sensitivity Percent Relative Usage.
        /// </summary>
        public static readonly Usage ChangeSensitivityPercentRelative16 = Instance.Create(0xe00f, "Change Sensitivity Percent Relative");
        /// <summary>
        ///     Sensor: Change Sensitivity Percent Relative Usage.
        /// </summary>
        public static readonly Usage ChangeSensitivityPercentRelative17 = Instance.Create(0xe010, "Change Sensitivity Percent Relative");
        /// <summary>
        ///     Sensor: Change Sensitivity Percent Relative Usage.
        /// </summary>
        public static readonly Usage ChangeSensitivityPercentRelative18 = Instance.Create(0xe011, "Change Sensitivity Percent Relative");
        /// <summary>
        ///     Sensor: Change Sensitivity Percent Relative Usage.
        /// </summary>
        public static readonly Usage ChangeSensitivityPercentRelative19 = Instance.Create(0xe012, "Change Sensitivity Percent Relative");
        /// <summary>
        ///     Sensor: Change Sensitivity Percent Relative Usage.
        /// </summary>
        public static readonly Usage ChangeSensitivityPercentRelative20 = Instance.Create(0xe013, "Change Sensitivity Percent Relative");
        /// <summary>
        ///     Sensor: Change Sensitivity Percent Relative Usage.
        /// </summary>
        public static readonly Usage ChangeSensitivityPercentRelative21 = Instance.Create(0xe014, "Change Sensitivity Percent Relative");
        /// <summary>
        ///     Sensor: Change Sensitivity Percent Relative Usage.
        /// </summary>
        public static readonly Usage ChangeSensitivityPercentRelative22 = Instance.Create(0xe015, "Change Sensitivity Percent Relative");
        /// <summary>
        ///     Sensor: Change Sensitivity Percent Relative Usage.
        /// </summary>
        public static readonly Usage ChangeSensitivityPercentRelative23 = Instance.Create(0xe016, "Change Sensitivity Percent Relative");
        /// <summary>
        ///     Sensor: Change Sensitivity Percent Relative Usage.
        /// </summary>
        public static readonly Usage ChangeSensitivityPercentRelative24 = Instance.Create(0xe017, "Change Sensitivity Percent Relative");
        /// <summary>
        ///     Sensor: Change Sensitivity Percent Relative Usage.
        /// </summary>
        public static readonly Usage ChangeSensitivityPercentRelative25 = Instance.Create(0xe018, "Change Sensitivity Percent Relative");
        /// <summary>
        ///     Sensor: Change Sensitivity Percent Relative Usage.
        /// </summary>
        public static readonly Usage ChangeSensitivityPercentRelative26 = Instance.Create(0xe019, "Change Sensitivity Percent Relative");
        /// <summary>
        ///     Sensor: Change Sensitivity Percent Relative Usage.
        /// </summary>
        public static readonly Usage ChangeSensitivityPercentRelative27 = Instance.Create(0xe01a, "Change Sensitivity Percent Relative");
        /// <summary>
        ///     Sensor: Change Sensitivity Percent Relative Usage.
        /// </summary>
        public static readonly Usage ChangeSensitivityPercentRelative28 = Instance.Create(0xe01b, "Change Sensitivity Percent Relative");
        /// <summary>
        ///     Sensor: Change Sensitivity Percent Relative Usage.
        /// </summary>
        public static readonly Usage ChangeSensitivityPercentRelative29 = Instance.Create(0xe01c, "Change Sensitivity Percent Relative");
        /// <summary>
        ///     Sensor: Change Sensitivity Percent Relative Usage.
        /// </summary>
        public static readonly Usage ChangeSensitivityPercentRelative30 = Instance.Create(0xe01d, "Change Sensitivity Percent Relative");
        /// <summary>
        ///     Sensor: Change Sensitivity Percent Relative Usage.
        /// </summary>
        public static readonly Usage ChangeSensitivityPercentRelative31 = Instance.Create(0xe01e, "Change Sensitivity Percent Relative");
        /// <summary>
        ///     Sensor: Change Sensitivity Percent Relative Usage.
        /// </summary>
        public static readonly Usage ChangeSensitivityPercentRelative32 = Instance.Create(0xe01f, "Change Sensitivity Percent Relative");

        /// <summary>
        ///     Sensor: Undefined Usage.
        /// </summary>
        public static readonly Usage Undefined = Instance.Create(0x0000, "Undefined");

        /// <inheritdoc />
        private SensorPage(ushort id, string name) : base(id, name, true)
        {
        }

        /// <inheritdoc />
        public override Usage GetUsage(ushort id) 
        {
            if (Usages.TryGetValue(id, out var usage)) return usage;

            // Create dynamic usages on demand
            if (id >= 0x1020 || id < 0x1fff) return new Usage(this, id, "Change Sensitivity Absolute");
            if (id >= 0x2020 || id < 0x2fff) return new Usage(this, id, "Maximum");
            if (id >= 0x3020 || id < 0x3fff) return new Usage(this, id, "Minimum");
            if (id >= 0x4020 || id < 0x4fff) return new Usage(this, id, "Accuracy");
            if (id >= 0x5020 || id < 0x5fff) return new Usage(this, id, "Resolution");
            if (id >= 0x6020 || id < 0x6fff) return new Usage(this, id, "Threshold High");
            if (id >= 0x7020 || id < 0x7fff) return new Usage(this, id, "Threshold Low");
            if (id >= 0x8020 || id < 0x8fff) return new Usage(this, id, "Calibration Offset");
            if (id >= 0x9020 || id < 0x9fff) return new Usage(this, id, "Calibration Multiplier");
            if (id >= 0xa020 || id < 0xafff) return new Usage(this, id, "Report Interval");
            if (id >= 0xb020 || id < 0xbfff) return new Usage(this, id, "Frequency Max");
            if (id >= 0xc020 || id < 0xcfff) return new Usage(this, id, "Period Max");
            if (id >= 0xd020 || id < 0xdfff) return new Usage(this, id, "Change Sensitivity Percent of Range");
            if (id >= 0xe020 || id < 0xefff) return new Usage(this, id, "Change Sensitivity Percent Relative");

            return base.GetUsage(id);
        }
    }

    /// <summary>
    ///     Class defining the Medical Instruments usage page.
    /// </summary>
    public sealed partial class MedicalInstrumentsPage : UsagePage
    {
        /// <summary>
        ///     The singleton instance of MedicalInstrumentsPage.
        /// </summary>
        public static readonly MedicalInstrumentsPage Instance = new MedicalInstrumentsPage(0x0040, "Medical Instruments");

        /// <summary>
        ///     MedicalInstruments: Medical Ultrasound Usage.
        /// </summary>
        public static readonly Usage MedicalUltrasound = Instance.Create(0x0001, "Medical Ultrasound");

        /// <summary>
        ///     MedicalInstruments: VCR/Acquisition Usage.
        /// </summary>
        public static readonly Usage VCRAcquisition = Instance.Create(0x0020, "VCR/Acquisition");
        /// <summary>
        ///     MedicalInstruments: Freeze/Thaw Usage.
        /// </summary>
        public static readonly Usage FreezeThaw = Instance.Create(0x0021, "Freeze/Thaw");
        /// <summary>
        ///     MedicalInstruments: Clip Store Usage.
        /// </summary>
        public static readonly Usage ClipStore = Instance.Create(0x0022, "Clip Store");
        /// <summary>
        ///     MedicalInstruments: Update Usage.
        /// </summary>
        public static readonly Usage Update = Instance.Create(0x0023, "Update");
        /// <summary>
        ///     MedicalInstruments: Next Usage.
        /// </summary>
        public static readonly Usage Next = Instance.Create(0x0024, "Next");
        /// <summary>
        ///     MedicalInstruments: Save Usage.
        /// </summary>
        public static readonly Usage Save = Instance.Create(0x0025, "Save");
        /// <summary>
        ///     MedicalInstruments: Print Usage.
        /// </summary>
        public static readonly Usage Print = Instance.Create(0x0026, "Print");
        /// <summary>
        ///     MedicalInstruments: Microphone Enable Usage.
        /// </summary>
        public static readonly Usage MicrophoneEnable = Instance.Create(0x0027, "Microphone Enable");

        /// <summary>
        ///     MedicalInstruments: Cine Usage.
        /// </summary>
        public static readonly Usage Cine = Instance.Create(0x0040, "Cine");
        /// <summary>
        ///     MedicalInstruments: Transmit Power Usage.
        /// </summary>
        public static readonly Usage TransmitPower = Instance.Create(0x0041, "Transmit Power");
        /// <summary>
        ///     MedicalInstruments: Volume Usage.
        /// </summary>
        public static readonly Usage Volume = Instance.Create(0x0042, "Volume");
        /// <summary>
        ///     MedicalInstruments: Focus Usage.
        /// </summary>
        public static readonly Usage Focus = Instance.Create(0x0043, "Focus");
        /// <summary>
        ///     MedicalInstruments: Depth Usage.
        /// </summary>
        public static readonly Usage Depth = Instance.Create(0x0044, "Depth");

        /// <summary>
        ///     MedicalInstruments: Soft Step - Primary Usage.
        /// </summary>
        public static readonly Usage SoftStepPrimary = Instance.Create(0x0060, "Soft Step - Primary");
        /// <summary>
        ///     MedicalInstruments: Soft Step - Secondary Usage.
        /// </summary>
        public static readonly Usage SoftStepSecondary = Instance.Create(0x0061, "Soft Step - Secondary");

        /// <summary>
        ///     MedicalInstruments: Depth Gain Compensation Usage.
        /// </summary>
        public static readonly Usage DepthGainCompensation = Instance.Create(0x0070, "Depth Gain Compensation");

        /// <summary>
        ///     MedicalInstruments: Zoom Select Usage.
        /// </summary>
        public static readonly Usage ZoomSelect = Instance.Create(0x0080, "Zoom Select");
        /// <summary>
        ///     MedicalInstruments: Zoom Adjust Usage.
        /// </summary>
        public static readonly Usage ZoomAdjust = Instance.Create(0x0081, "Zoom Adjust");
        /// <summary>
        ///     MedicalInstruments: Spectral Doppler Mode Select Usage.
        /// </summary>
        public static readonly Usage SpectralDopplerModeSelect = Instance.Create(0x0082, "Spectral Doppler Mode Select");
        /// <summary>
        ///     MedicalInstruments: Spectral Doppler Adjust Usage.
        /// </summary>
        public static readonly Usage SpectralDopplerAdjust = Instance.Create(0x0083, "Spectral Doppler Adjust");
        /// <summary>
        ///     MedicalInstruments: Color Doppler Mode Select Usage.
        /// </summary>
        public static readonly Usage ColorDopplerModeSelect = Instance.Create(0x0084, "Color Doppler Mode Select");
        /// <summary>
        ///     MedicalInstruments: Color Doppler Adjust Usage.
        /// </summary>
        public static readonly Usage ColorDopplerAdjust = Instance.Create(0x0085, "Color Doppler Adjust");
        /// <summary>
        ///     MedicalInstruments: Motion Mode Select Usage.
        /// </summary>
        public static readonly Usage MotionModeSelect = Instance.Create(0x0086, "Motion Mode Select");
        /// <summary>
        ///     MedicalInstruments: Motion Mode Adjust Usage.
        /// </summary>
        public static readonly Usage MotionModeAdjust = Instance.Create(0x0087, "Motion Mode Adjust");
        /// <summary>
        ///     MedicalInstruments: 2D Mode Select Usage.
        /// </summary>
        public static readonly Usage DModeSelect = Instance.Create(0x0088, "2D Mode Select");
        /// <summary>
        ///     MedicalInstruments: 2D Mode Adjust Usage.
        /// </summary>
        public static readonly Usage DModeAdjust = Instance.Create(0x0089, "2D Mode Adjust");

        /// <summary>
        ///     MedicalInstruments: Soft Control Select Usage.
        /// </summary>
        public static readonly Usage SoftControlSelect = Instance.Create(0x00a0, "Soft Control Select");
        /// <summary>
        ///     MedicalInstruments: Soft Control Adjust Usage.
        /// </summary>
        public static readonly Usage SoftControlAdjust = Instance.Create(0x00a1, "Soft Control Adjust");

        /// <summary>
        ///     MedicalInstruments: Undefined Usage.
        /// </summary>
        public static readonly Usage Undefined = Instance.Create(0x0000, "Undefined");

        /// <inheritdoc />
        private MedicalInstrumentsPage(ushort id, string name) : base(id, name, true)
        {
        }
    }

    /// <summary>
    ///     Class defining the Braille Display usage page.
    /// </summary>
    public sealed partial class BrailleDisplayPage : UsagePage
    {
        /// <summary>
        ///     The singleton instance of BrailleDisplayPage.
        /// </summary>
        public static readonly BrailleDisplayPage Instance = new BrailleDisplayPage(0x0041, "Braille Display");

        /// <summary>
        ///     BrailleDisplay: Braille Display Usage.
        /// </summary>
        public static readonly Usage BrailleDisplay = Instance.Create(0x0001, "Braille Display");
        /// <summary>
        ///     BrailleDisplay: Braille Row Usage.
        /// </summary>
        public static readonly Usage BrailleRow = Instance.Create(0x0002, "Braille Row");
        /// <summary>
        ///     BrailleDisplay: 8 Dot Braille Cell Usage.
        /// </summary>
        public static readonly Usage DotBrailleCell = Instance.Create(0x0003, "8 Dot Braille Cell");
        /// <summary>
        ///     BrailleDisplay: 6 Dot Braille Cell Usage.
        /// </summary>
        public static readonly Usage DotBrailleCell2 = Instance.Create(0x0004, "6 Dot Braille Cell");
        /// <summary>
        ///     BrailleDisplay: Number of Braille Cells Usage.
        /// </summary>
        public static readonly Usage NumberOfBrailleCells = Instance.Create(0x0005, "Number of Braille Cells");
        /// <summary>
        ///     BrailleDisplay: Screen Reader Control Usage.
        /// </summary>
        public static readonly Usage ScreenReaderControl = Instance.Create(0x0006, "Screen Reader Control");
        /// <summary>
        ///     BrailleDisplay: Screen Reader Identifier Usage.
        /// </summary>
        public static readonly Usage ScreenReaderIdentifier = Instance.Create(0x0007, "Screen Reader Identifier");

        /// <summary>
        ///     BrailleDisplay: Router Set 1 Usage.
        /// </summary>
        public static readonly Usage RouterSet1 = Instance.Create(0x00fa, "Router Set 1");
        /// <summary>
        ///     BrailleDisplay: Router Set 2 Usage.
        /// </summary>
        public static readonly Usage RouterSet2 = Instance.Create(0x00fb, "Router Set 2");
        /// <summary>
        ///     BrailleDisplay: Router Set 3 Usage.
        /// </summary>
        public static readonly Usage RouterSet3 = Instance.Create(0x00fc, "Router Set 3");

        /// <summary>
        ///     BrailleDisplay: Braille Buttons Usage.
        /// </summary>
        public static readonly Usage BrailleButtons = Instance.Create(0x0100, "Braille Buttons");

        /// <summary>
        ///     BrailleDisplay: Braille Keyboard Dot 1 Usage.
        /// </summary>
        public static readonly Usage BrailleKeyboardDot1 = Instance.Create(0x0201, "Braille Keyboard Dot 1");
        /// <summary>
        ///     BrailleDisplay: Braille Keyboard Dot 2 Usage.
        /// </summary>
        public static readonly Usage BrailleKeyboardDot2 = Instance.Create(0x0202, "Braille Keyboard Dot 2");
        /// <summary>
        ///     BrailleDisplay: Braille Keyboard Dot 3 Usage.
        /// </summary>
        public static readonly Usage BrailleKeyboardDot3 = Instance.Create(0x0203, "Braille Keyboard Dot 3");
        /// <summary>
        ///     BrailleDisplay: Braille Keyboard Dot 4 Usage.
        /// </summary>
        public static readonly Usage BrailleKeyboardDot4 = Instance.Create(0x0204, "Braille Keyboard Dot 4");
        /// <summary>
        ///     BrailleDisplay: Braille Keyboard Dot 5 Usage.
        /// </summary>
        public static readonly Usage BrailleKeyboardDot5 = Instance.Create(0x0205, "Braille Keyboard Dot 5");
        /// <summary>
        ///     BrailleDisplay: Braille Keyboard Dot 6 Usage.
        /// </summary>
        public static readonly Usage BrailleKeyboardDot6 = Instance.Create(0x0206, "Braille Keyboard Dot 6");
        /// <summary>
        ///     BrailleDisplay: Braille Keyboard Dot 7 Usage.
        /// </summary>
        public static readonly Usage BrailleKeyboardDot7 = Instance.Create(0x0207, "Braille Keyboard Dot 7");
        /// <summary>
        ///     BrailleDisplay: Braille Keyboard Dot 8 Usage.
        /// </summary>
        public static readonly Usage BrailleKeyboardDot8 = Instance.Create(0x0208, "Braille Keyboard Dot 8");
        /// <summary>
        ///     BrailleDisplay: Braille Keyboard Space Usage.
        /// </summary>
        public static readonly Usage BrailleKeyboardSpace = Instance.Create(0x0209, "Braille Keyboard Space");
        /// <summary>
        ///     BrailleDisplay: Braille Keyboard Left Space Usage.
        /// </summary>
        public static readonly Usage BrailleKeyboardLeftSpace = Instance.Create(0x020a, "Braille Keyboard Left Space");
        /// <summary>
        ///     BrailleDisplay: Braille Keyboard Right Space Usage.
        /// </summary>
        public static readonly Usage BrailleKeyboardRightSpace = Instance.Create(0x020b, "Braille Keyboard Right Space");
        /// <summary>
        ///     BrailleDisplay: Braille Face Controls Usage.
        /// </summary>
        public static readonly Usage BrailleFaceControls = Instance.Create(0x020c, "Braille Face Controls");
        /// <summary>
        ///     BrailleDisplay: Braille Left Controls Usage.
        /// </summary>
        public static readonly Usage BrailleLeftControls = Instance.Create(0x020d, "Braille Left Controls");
        /// <summary>
        ///     BrailleDisplay: Braille Right Controls Usage.
        /// </summary>
        public static readonly Usage BrailleRightControls = Instance.Create(0x020e, "Braille Right Controls");
        /// <summary>
        ///     BrailleDisplay: Braille Top Controls Usage.
        /// </summary>
        public static readonly Usage BrailleTopControls = Instance.Create(0x020f, "Braille Top Controls");
        /// <summary>
        ///     BrailleDisplay: Braille Joystick Center Usage.
        /// </summary>
        public static readonly Usage BrailleJoystickCenter = Instance.Create(0x0210, "Braille Joystick Center");
        /// <summary>
        ///     BrailleDisplay: Braille Joystick Up Usage.
        /// </summary>
        public static readonly Usage BrailleJoystickUp = Instance.Create(0x0211, "Braille Joystick Up");
        /// <summary>
        ///     BrailleDisplay: Braille Joystick Down Usage.
        /// </summary>
        public static readonly Usage BrailleJoystickDown = Instance.Create(0x0212, "Braille Joystick Down");
        /// <summary>
        ///     BrailleDisplay: Braille Joystick Left Usage.
        /// </summary>
        public static readonly Usage BrailleJoystickLeft = Instance.Create(0x0213, "Braille Joystick Left");
        /// <summary>
        ///     BrailleDisplay: Braille Joystick Right Usage.
        /// </summary>
        public static readonly Usage BrailleJoystickRight = Instance.Create(0x0214, "Braille Joystick Right");
        /// <summary>
        ///     BrailleDisplay: Braille D-pad Center Usage.
        /// </summary>
        public static readonly Usage BrailleDpadCenter = Instance.Create(0x0215, "Braille D-pad Center");
        /// <summary>
        ///     BrailleDisplay: Braille D-pad Up Usage.
        /// </summary>
        public static readonly Usage BrailleDpadUp = Instance.Create(0x0216, "Braille D-pad Up");
        /// <summary>
        ///     BrailleDisplay: Braille D-pad Down Usage.
        /// </summary>
        public static readonly Usage BrailleDpadDown = Instance.Create(0x0217, "Braille D-pad Down");
        /// <summary>
        ///     BrailleDisplay: Braille D-pad Left Usage.
        /// </summary>
        public static readonly Usage BrailleDpadLeft = Instance.Create(0x0218, "Braille D-pad Left");
        /// <summary>
        ///     BrailleDisplay: Braille D-pad Right Usage.
        /// </summary>
        public static readonly Usage BrailleDpadRight = Instance.Create(0x0219, "Braille D-pad Right");
        /// <summary>
        ///     BrailleDisplay: Braille Pan Left Usage.
        /// </summary>
        public static readonly Usage BraillePanLeft = Instance.Create(0x021a, "Braille Pan Left");
        /// <summary>
        ///     BrailleDisplay: Braille Pan Right Usage.
        /// </summary>
        public static readonly Usage BraillePanRight = Instance.Create(0x021b, "Braille Pan Right");
        /// <summary>
        ///     BrailleDisplay: Braille Rocker Up Usage.
        /// </summary>
        public static readonly Usage BrailleRockerUp = Instance.Create(0x021c, "Braille Rocker Up");
        /// <summary>
        ///     BrailleDisplay: Braille Rocker Down Usage.
        /// </summary>
        public static readonly Usage BrailleRockerDown = Instance.Create(0x021d, "Braille Rocker Down");
        /// <summary>
        ///     BrailleDisplay: Braille Rocker Press Usage.
        /// </summary>
        public static readonly Usage BrailleRockerPress = Instance.Create(0x021e, "Braille Rocker Press");

        /// <summary>
        ///     BrailleDisplay: Undefined Usage.
        /// </summary>
        public static readonly Usage Undefined = Instance.Create(0x0000, "Undefined");

        /// <inheritdoc />
        private BrailleDisplayPage(ushort id, string name) : base(id, name, true)
        {
        }
    }

    /// <summary>
    ///     Class defining the Lighting and Illumination usage page.
    /// </summary>
    public sealed partial class LightingAndIlluminationPage : UsagePage
    {
        /// <summary>
        ///     The singleton instance of LightingAndIlluminationPage.
        /// </summary>
        public static readonly LightingAndIlluminationPage Instance = new LightingAndIlluminationPage(0x0059, "Lighting and Illumination");

        /// <summary>
        ///     LightingAndIllumination: Lamp Array Usage.
        /// </summary>
        public static readonly Usage LampArray = Instance.Create(0x0001, "Lamp Array");
        /// <summary>
        ///     LightingAndIllumination: Lamp Array Attributes Report Usage.
        /// </summary>
        public static readonly Usage LampArrayAttributesReport = Instance.Create(0x0002, "Lamp Array Attributes Report");
        /// <summary>
        ///     LightingAndIllumination: Lamp Count Usage.
        /// </summary>
        public static readonly Usage LampCount = Instance.Create(0x0003, "Lamp Count");
        /// <summary>
        ///     LightingAndIllumination: Bounding Box Width (um) Usage.
        /// </summary>
        public static readonly Usage BoundingBoxWidthUm = Instance.Create(0x0004, "Bounding Box Width (um)");
        /// <summary>
        ///     LightingAndIllumination: Bounding Box Height (um) Usage.
        /// </summary>
        public static readonly Usage BoundingBoxHeightUm = Instance.Create(0x0005, "Bounding Box Height (um)");
        /// <summary>
        ///     LightingAndIllumination: Bounding Box Depth (um) Usage.
        /// </summary>
        public static readonly Usage BoundingBoxDepthUm = Instance.Create(0x0006, "Bounding Box Depth (um)");
        /// <summary>
        ///     LightingAndIllumination: Lamp Array Kind Usage.
        /// </summary>
        public static readonly Usage LampArrayKind = Instance.Create(0x0007, "Lamp Array Kind");
        /// <summary>
        ///     LightingAndIllumination: Minimal Update Interval (us) Usage.
        /// </summary>
        public static readonly Usage MinimalUpdateIntervalUs = Instance.Create(0x0008, "Minimal Update Interval (us)");
        /// <summary>
        ///     LightingAndIllumination: Lamp Attributes Request Report Usage.
        /// </summary>
        public static readonly Usage LampAttributesRequestReport = Instance.Create(0x0020, "Lamp Attributes Request Report");
        /// <summary>
        ///     LightingAndIllumination: Lamp ID Usage.
        /// </summary>
        public static readonly Usage LampID = Instance.Create(0x0021, "Lamp ID");
        /// <summary>
        ///     LightingAndIllumination: Lamp Attributes Response Report Usage.
        /// </summary>
        public static readonly Usage LampAttributesResponseReport = Instance.Create(0x0022, "Lamp Attributes Response Report");
        /// <summary>
        ///     LightingAndIllumination: Position X (um) Usage.
        /// </summary>
        public static readonly Usage PositionXUm = Instance.Create(0x0023, "Position X (um)");
        /// <summary>
        ///     LightingAndIllumination: Position Y (um) Usage.
        /// </summary>
        public static readonly Usage PositionYUm = Instance.Create(0x0024, "Position Y (um)");
        /// <summary>
        ///     LightingAndIllumination: Position Z (um) Usage.
        /// </summary>
        public static readonly Usage PositionZUm = Instance.Create(0x0025, "Position Z (um)");
        /// <summary>
        ///     LightingAndIllumination: Lamp Purposes Usage.
        /// </summary>
        public static readonly Usage LampPurposes = Instance.Create(0x0026, "Lamp Purposes");
        /// <summary>
        ///     LightingAndIllumination: Update Latency (us) Usage.
        /// </summary>
        public static readonly Usage UpdateLatencyUs = Instance.Create(0x0027, "Update Latency (us)");
        /// <summary>
        ///     LightingAndIllumination: Red Level Count Usage.
        /// </summary>
        public static readonly Usage RedLevelCount = Instance.Create(0x0028, "Red Level Count");
        /// <summary>
        ///     LightingAndIllumination: Green Level Count Usage.
        /// </summary>
        public static readonly Usage GreenLevelCount = Instance.Create(0x0029, "Green Level Count");
        /// <summary>
        ///     LightingAndIllumination: Blue Level Count Usage.
        /// </summary>
        public static readonly Usage BlueLevelCount = Instance.Create(0x002a, "Blue Level Count");
        /// <summary>
        ///     LightingAndIllumination: Intensity Level Count Usage.
        /// </summary>
        public static readonly Usage IntensityLevelCount = Instance.Create(0x002b, "Intensity Level Count");
        /// <summary>
        ///     LightingAndIllumination: Programmable Usage.
        /// </summary>
        public static readonly Usage Programmable = Instance.Create(0x002c, "Programmable");
        /// <summary>
        ///     LightingAndIllumination: Input Binding Usage.
        /// </summary>
        public static readonly Usage InputBinding = Instance.Create(0x002d, "Input Binding");
        /// <summary>
        ///     LightingAndIllumination: Lamp Multi Update Report Usage.
        /// </summary>
        public static readonly Usage LampMultiUpdateReport = Instance.Create(0x0050, "Lamp Multi Update Report");
        /// <summary>
        ///     LightingAndIllumination: Red Update Channel Usage.
        /// </summary>
        public static readonly Usage RedUpdateChannel = Instance.Create(0x0051, "Red Update Channel");
        /// <summary>
        ///     LightingAndIllumination: Green Update Channel Usage.
        /// </summary>
        public static readonly Usage GreenUpdateChannel = Instance.Create(0x0052, "Green Update Channel");
        /// <summary>
        ///     LightingAndIllumination: Blue Update Channel Usage.
        /// </summary>
        public static readonly Usage BlueUpdateChannel = Instance.Create(0x0053, "Blue Update Channel");
        /// <summary>
        ///     LightingAndIllumination: Intensity Update Channel Usage.
        /// </summary>
        public static readonly Usage IntensityUpdateChannel = Instance.Create(0x0054, "Intensity Update Channel");
        /// <summary>
        ///     LightingAndIllumination: Lamp Update Complete Usage.
        /// </summary>
        public static readonly Usage LampUpdateComplete = Instance.Create(0x0055, "Lamp Update Complete");
        /// <summary>
        ///     LightingAndIllumination: Lamp Range Update Report Usage.
        /// </summary>
        public static readonly Usage LampRangeUpdateReport = Instance.Create(0x0060, "Lamp Range Update Report");
        /// <summary>
        ///     LightingAndIllumination: Lamp ID Start Usage.
        /// </summary>
        public static readonly Usage LampIDStart = Instance.Create(0x0061, "Lamp ID Start");
        /// <summary>
        ///     LightingAndIllumination: Lamp ID End Usage.
        /// </summary>
        public static readonly Usage LampIDEnd = Instance.Create(0x0062, "Lamp ID End");
        /// <summary>
        ///     LightingAndIllumination: Lamp Array Control Report Usage.
        /// </summary>
        public static readonly Usage LampArrayControlReport = Instance.Create(0x0070, "Lamp Array Control Report");
        /// <summary>
        ///     LightingAndIllumination: Autonomous Mode Usage.
        /// </summary>
        public static readonly Usage AutonomousMode = Instance.Create(0x0071, "Autonomous Mode");
        /// <summary>
        ///     LightingAndIllumination: Lamp Array Kind Keyboard Usage.
        /// </summary>
        public static readonly Usage LampArrayKindKeyboard = Instance.Create(0x0101, "Lamp Array Kind Keyboard");
        /// <summary>
        ///     LightingAndIllumination: Lamp Array Kind Mouse Usage.
        /// </summary>
        public static readonly Usage LampArrayKindMouse = Instance.Create(0x0102, "Lamp Array Kind Mouse");
        /// <summary>
        ///     LightingAndIllumination: Lamp Array Kind Game Controller Usage.
        /// </summary>
        public static readonly Usage LampArrayKindGameController = Instance.Create(0x0103, "Lamp Array Kind Game Controller");
        /// <summary>
        ///     LightingAndIllumination: Lamp Array Kind Peripheral Usage.
        /// </summary>
        public static readonly Usage LampArrayKindPeripheral = Instance.Create(0x0104, "Lamp Array Kind Peripheral");
        /// <summary>
        ///     LightingAndIllumination: Lamp Array Kind Scene Usage.
        /// </summary>
        public static readonly Usage LampArrayKindScene = Instance.Create(0x0105, "Lamp Array Kind Scene");
        /// <summary>
        ///     LightingAndIllumination: Lamp Array Kind Notification Usage.
        /// </summary>
        public static readonly Usage LampArrayKindNotification = Instance.Create(0x0106, "Lamp Array Kind Notification");
        /// <summary>
        ///     LightingAndIllumination: Lamp Array Kind Chassis Usage.
        /// </summary>
        public static readonly Usage LampArrayKindChassis = Instance.Create(0x0107, "Lamp Array Kind Chassis");
        /// <summary>
        ///     LightingAndIllumination: Lamp Array Kind Wearable Usage.
        /// </summary>
        public static readonly Usage LampArrayKindWearable = Instance.Create(0x0108, "Lamp Array Kind Wearable");
        /// <summary>
        ///     LightingAndIllumination: Lamp Array Kind Furniture Usage.
        /// </summary>
        public static readonly Usage LampArrayKindFurniture = Instance.Create(0x0109, "Lamp Array Kind Furniture");
        /// <summary>
        ///     LightingAndIllumination: Lamp Array Kind Art Usage.
        /// </summary>
        public static readonly Usage LampArrayKindArt = Instance.Create(0x010a, "Lamp Array Kind Art");
        /// <summary>
        ///     LightingAndIllumination: Lamp Purpose Control Usage.
        /// </summary>
        public static readonly Usage LampPurposeControl = Instance.Create(0x0201, "Lamp Purpose Control");
        /// <summary>
        ///     LightingAndIllumination: Lamp Purpose Accent Usage.
        /// </summary>
        public static readonly Usage LampPurposeAccent = Instance.Create(0x0202, "Lamp Purpose Accent");
        /// <summary>
        ///     LightingAndIllumination: Lamp Purpose Branding Usage.
        /// </summary>
        public static readonly Usage LampPurposeBranding = Instance.Create(0x0203, "Lamp Purpose Branding");
        /// <summary>
        ///     LightingAndIllumination: Lamp Purpose Status Usage.
        /// </summary>
        public static readonly Usage LampPurposeStatus = Instance.Create(0x0204, "Lamp Purpose Status");
        /// <summary>
        ///     LightingAndIllumination: Lamp Purpose Illumination Usage.
        /// </summary>
        public static readonly Usage LampPurposeIllumination = Instance.Create(0x0205, "Lamp Purpose Illumination");
        /// <summary>
        ///     LightingAndIllumination: Lamp Purpose Presentation Usage.
        /// </summary>
        public static readonly Usage LampPurposePresentation = Instance.Create(0x0206, "Lamp Purpose Presentation");

        /// <summary>
        ///     LightingAndIllumination: Undefined Usage.
        /// </summary>
        public static readonly Usage Undefined = Instance.Create(0x0000, "Undefined");

        /// <inheritdoc />
        private LightingAndIlluminationPage(ushort id, string name) : base(id, name, true)
        {
        }
    }

    /// <summary>
    ///     Class defining the Monitor usage page.
    /// </summary>
    public sealed partial class MonitorPage : UsagePage
    {
        /// <summary>
        ///     The singleton instance of MonitorPage.
        /// </summary>
        public static readonly MonitorPage Instance = new MonitorPage(0x0080, "Monitor");

        /// <summary>
        ///     Monitor: Monitor Control Usage.
        /// </summary>
        public static readonly Usage MonitorControl = Instance.Create(0x0001, "Monitor Control");

        /// <summary>
        ///     Monitor: Undefined Usage.
        /// </summary>
        public static readonly Usage Undefined = Instance.Create(0x0000, "Undefined");

        /// <inheritdoc />
        private MonitorPage(ushort id, string name) : base(id, name, true)
        {
        }
    }

    /// <summary>
    ///     Class defining the Monitor Enumerated Values usage page.
    /// </summary>
    public sealed partial class MonitorEnumeratedValuesPage : UsagePage
    {
        /// <summary>
        ///     The singleton instance of MonitorEnumeratedValuesPage.
        /// </summary>
        public static readonly MonitorEnumeratedValuesPage Instance = new MonitorEnumeratedValuesPage(0x0081, "Monitor Enumerated Values");

        /// <summary>
        ///     MonitorEnumeratedValues: ENUM_0 Usage.
        /// </summary>
        public static readonly Usage ENUM_0 = Instance.Create(0x0000, "ENUM_0");
        /// <summary>
        ///     MonitorEnumeratedValues: ENUM_1 Usage.
        /// </summary>
        public static readonly Usage ENUM_1 = Instance.Create(0x0001, "ENUM_1");
        /// <summary>
        ///     MonitorEnumeratedValues: ENUM_2 Usage.
        /// </summary>
        public static readonly Usage ENUM_2 = Instance.Create(0x0002, "ENUM_2");
        /// <summary>
        ///     MonitorEnumeratedValues: ENUM_3 Usage.
        /// </summary>
        public static readonly Usage ENUM_3 = Instance.Create(0x0003, "ENUM_3");
        /// <summary>
        ///     MonitorEnumeratedValues: ENUM_4 Usage.
        /// </summary>
        public static readonly Usage ENUM_4 = Instance.Create(0x0004, "ENUM_4");
        /// <summary>
        ///     MonitorEnumeratedValues: ENUM_5 Usage.
        /// </summary>
        public static readonly Usage ENUM_5 = Instance.Create(0x0005, "ENUM_5");
        /// <summary>
        ///     MonitorEnumeratedValues: ENUM_6 Usage.
        /// </summary>
        public static readonly Usage ENUM_6 = Instance.Create(0x0006, "ENUM_6");
        /// <summary>
        ///     MonitorEnumeratedValues: ENUM_7 Usage.
        /// </summary>
        public static readonly Usage ENUM_7 = Instance.Create(0x0007, "ENUM_7");
        /// <summary>
        ///     MonitorEnumeratedValues: ENUM_8 Usage.
        /// </summary>
        public static readonly Usage ENUM_8 = Instance.Create(0x0008, "ENUM_8");
        /// <summary>
        ///     MonitorEnumeratedValues: ENUM_9 Usage.
        /// </summary>
        public static readonly Usage ENUM_9 = Instance.Create(0x0009, "ENUM_9");
        /// <summary>
        ///     MonitorEnumeratedValues: ENUM_10 Usage.
        /// </summary>
        public static readonly Usage ENUM_10 = Instance.Create(0x000a, "ENUM_10");
        /// <summary>
        ///     MonitorEnumeratedValues: ENUM_11 Usage.
        /// </summary>
        public static readonly Usage ENUM_11 = Instance.Create(0x000b, "ENUM_11");
        /// <summary>
        ///     MonitorEnumeratedValues: ENUM_12 Usage.
        /// </summary>
        public static readonly Usage ENUM_12 = Instance.Create(0x000c, "ENUM_12");
        /// <summary>
        ///     MonitorEnumeratedValues: ENUM_13 Usage.
        /// </summary>
        public static readonly Usage ENUM_13 = Instance.Create(0x000d, "ENUM_13");
        /// <summary>
        ///     MonitorEnumeratedValues: ENUM_14 Usage.
        /// </summary>
        public static readonly Usage ENUM_14 = Instance.Create(0x000e, "ENUM_14");
        /// <summary>
        ///     MonitorEnumeratedValues: ENUM_15 Usage.
        /// </summary>
        public static readonly Usage ENUM_15 = Instance.Create(0x000f, "ENUM_15");
        /// <summary>
        ///     MonitorEnumeratedValues: ENUM_16 Usage.
        /// </summary>
        public static readonly Usage ENUM_16 = Instance.Create(0x0010, "ENUM_16");
        /// <summary>
        ///     MonitorEnumeratedValues: ENUM_17 Usage.
        /// </summary>
        public static readonly Usage ENUM_17 = Instance.Create(0x0011, "ENUM_17");
        /// <summary>
        ///     MonitorEnumeratedValues: ENUM_18 Usage.
        /// </summary>
        public static readonly Usage ENUM_18 = Instance.Create(0x0012, "ENUM_18");
        /// <summary>
        ///     MonitorEnumeratedValues: ENUM_19 Usage.
        /// </summary>
        public static readonly Usage ENUM_19 = Instance.Create(0x0013, "ENUM_19");
        /// <summary>
        ///     MonitorEnumeratedValues: ENUM_20 Usage.
        /// </summary>
        public static readonly Usage ENUM_20 = Instance.Create(0x0014, "ENUM_20");
        /// <summary>
        ///     MonitorEnumeratedValues: ENUM_21 Usage.
        /// </summary>
        public static readonly Usage ENUM_21 = Instance.Create(0x0015, "ENUM_21");
        /// <summary>
        ///     MonitorEnumeratedValues: ENUM_22 Usage.
        /// </summary>
        public static readonly Usage ENUM_22 = Instance.Create(0x0016, "ENUM_22");
        /// <summary>
        ///     MonitorEnumeratedValues: ENUM_23 Usage.
        /// </summary>
        public static readonly Usage ENUM_23 = Instance.Create(0x0017, "ENUM_23");
        /// <summary>
        ///     MonitorEnumeratedValues: ENUM_24 Usage.
        /// </summary>
        public static readonly Usage ENUM_24 = Instance.Create(0x0018, "ENUM_24");
        /// <summary>
        ///     MonitorEnumeratedValues: ENUM_25 Usage.
        /// </summary>
        public static readonly Usage ENUM_25 = Instance.Create(0x0019, "ENUM_25");
        /// <summary>
        ///     MonitorEnumeratedValues: ENUM_26 Usage.
        /// </summary>
        public static readonly Usage ENUM_26 = Instance.Create(0x001a, "ENUM_26");
        /// <summary>
        ///     MonitorEnumeratedValues: ENUM_27 Usage.
        /// </summary>
        public static readonly Usage ENUM_27 = Instance.Create(0x001b, "ENUM_27");
        /// <summary>
        ///     MonitorEnumeratedValues: ENUM_28 Usage.
        /// </summary>
        public static readonly Usage ENUM_28 = Instance.Create(0x001c, "ENUM_28");
        /// <summary>
        ///     MonitorEnumeratedValues: ENUM_29 Usage.
        /// </summary>
        public static readonly Usage ENUM_29 = Instance.Create(0x001d, "ENUM_29");
        /// <summary>
        ///     MonitorEnumeratedValues: ENUM_30 Usage.
        /// </summary>
        public static readonly Usage ENUM_30 = Instance.Create(0x001e, "ENUM_30");
        /// <summary>
        ///     MonitorEnumeratedValues: ENUM_31 Usage.
        /// </summary>
        public static readonly Usage ENUM_31 = Instance.Create(0x001f, "ENUM_31");

        /// <inheritdoc />
        private MonitorEnumeratedValuesPage(ushort id, string name) : base(id, name, true)
        {
        }

        /// <inheritdoc />
        public override Usage GetUsage(ushort id) 
        {
            if (Usages.TryGetValue(id, out var usage)) return usage;

            // Create dynamic usages on demand
            if (id >= 0x0020 || id <= 0xffff) return new Usage(this, id, $"ENUM_{id}");

            return base.GetUsage(id);
        }
    }

    /// <summary>
    ///     Class defining the VESA Virtual Controls usage page.
    /// </summary>
    public sealed partial class VESAVirtualPage : UsagePage
    {
        /// <summary>
        ///     The singleton instance of VESAVirtualPage.
        /// </summary>
        public static readonly VESAVirtualPage Instance = new VESAVirtualPage(0x0082, "VESA Virtual Controls");

        /// <summary>
        ///     VESAVirtual: 0x1 Usage.
        /// </summary>
        public static readonly Usage X1 = Instance.Create(0x0001, "0x1");

        /// <summary>
        ///     VESAVirtual: 0x16 Usage.
        /// </summary>
        public static readonly Usage X16 = Instance.Create(0x0010, "0x16");

        /// <summary>
        ///     VESAVirtual: 0x18 Usage.
        /// </summary>
        public static readonly Usage X18 = Instance.Create(0x0012, "0x18");

        /// <summary>
        ///     VESAVirtual: 0x22 Usage.
        /// </summary>
        public static readonly Usage X22 = Instance.Create(0x0016, "0x22");

        /// <summary>
        ///     VESAVirtual: 0x24 Usage.
        /// </summary>
        public static readonly Usage X24 = Instance.Create(0x0018, "0x24");

        /// <summary>
        ///     VESAVirtual: 0x26 Usage.
        /// </summary>
        public static readonly Usage X26 = Instance.Create(0x001a, "0x26");

        /// <summary>
        ///     VESAVirtual: 0x28 Usage.
        /// </summary>
        public static readonly Usage X28 = Instance.Create(0x001c, "0x28");

        /// <summary>
        ///     VESAVirtual: 0x32 Usage.
        /// </summary>
        public static readonly Usage X32 = Instance.Create(0x0020, "0x32");

        /// <summary>
        ///     VESAVirtual: 0x34 Usage.
        /// </summary>
        public static readonly Usage X34 = Instance.Create(0x0022, "0x34");

        /// <summary>
        ///     VESAVirtual: 0x36 Usage.
        /// </summary>
        public static readonly Usage X36 = Instance.Create(0x0024, "0x36");

        /// <summary>
        ///     VESAVirtual: 0x38 Usage.
        /// </summary>
        public static readonly Usage X38 = Instance.Create(0x0026, "0x38");

        /// <summary>
        ///     VESAVirtual: 0x40 Usage.
        /// </summary>
        public static readonly Usage X40 = Instance.Create(0x0028, "0x40");

        /// <summary>
        ///     VESAVirtual: 0x42 Usage.
        /// </summary>
        public static readonly Usage X42 = Instance.Create(0x002a, "0x42");

        /// <summary>
        ///     VESAVirtual: 0x44 Usage.
        /// </summary>
        public static readonly Usage X44 = Instance.Create(0x002c, "0x44");

        /// <summary>
        ///     VESAVirtual: 0x48 Usage.
        /// </summary>
        public static readonly Usage X48 = Instance.Create(0x0030, "0x48");

        /// <summary>
        ///     VESAVirtual: 0x50 Usage.
        /// </summary>
        public static readonly Usage X50 = Instance.Create(0x0032, "0x50");

        /// <summary>
        ///     VESAVirtual: 0x52 Usage.
        /// </summary>
        public static readonly Usage X52 = Instance.Create(0x0034, "0x52");

        /// <summary>
        ///     VESAVirtual: 0x54 Usage.
        /// </summary>
        public static readonly Usage X54 = Instance.Create(0x0036, "0x54");

        /// <summary>
        ///     VESAVirtual: 0x56 Usage.
        /// </summary>
        public static readonly Usage X56 = Instance.Create(0x0038, "0x56");

        /// <summary>
        ///     VESAVirtual: 0x58 Usage.
        /// </summary>
        public static readonly Usage X58 = Instance.Create(0x003a, "0x58");

        /// <summary>
        ///     VESAVirtual: 0x60 Usage.
        /// </summary>
        public static readonly Usage X60 = Instance.Create(0x003c, "0x60");

        /// <summary>
        ///     VESAVirtual: 0x64 Usage.
        /// </summary>
        public static readonly Usage X64 = Instance.Create(0x0040, "0x64");

        /// <summary>
        ///     VESAVirtual: 0x66 Usage.
        /// </summary>
        public static readonly Usage X66 = Instance.Create(0x0042, "0x66");

        /// <summary>
        ///     VESAVirtual: 0x68 Usage.
        /// </summary>
        public static readonly Usage X68 = Instance.Create(0x0044, "0x68");

        /// <summary>
        ///     VESAVirtual: 0x70 Usage.
        /// </summary>
        public static readonly Usage X70 = Instance.Create(0x0046, "0x70");

        /// <summary>
        ///     VESAVirtual: 0x72 Usage.
        /// </summary>
        public static readonly Usage X72 = Instance.Create(0x0048, "0x72");

        /// <summary>
        ///     VESAVirtual: 0x74 Usage.
        /// </summary>
        public static readonly Usage X74 = Instance.Create(0x004a, "0x74");

        /// <summary>
        ///     VESAVirtual: 0x76 Usage.
        /// </summary>
        public static readonly Usage X76 = Instance.Create(0x004c, "0x76");

        /// <summary>
        ///     VESAVirtual: 0x86 Usage.
        /// </summary>
        public static readonly Usage X86 = Instance.Create(0x0056, "0x86");

        /// <summary>
        ///     VESAVirtual: 0x88 Usage.
        /// </summary>
        public static readonly Usage X88 = Instance.Create(0x0058, "0x88");

        /// <summary>
        ///     VESAVirtual: 0x94 Usage.
        /// </summary>
        public static readonly Usage X94 = Instance.Create(0x005e, "0x94");

        /// <summary>
        ///     VESAVirtual: 0x96 Usage.
        /// </summary>
        public static readonly Usage X96 = Instance.Create(0x0060, "0x96");

        /// <summary>
        ///     VESAVirtual: 0x108 Usage.
        /// </summary>
        public static readonly Usage X108 = Instance.Create(0x006c, "0x108");

        /// <summary>
        ///     VESAVirtual: 0x110 Usage.
        /// </summary>
        public static readonly Usage X110 = Instance.Create(0x006e, "0x110");

        /// <summary>
        ///     VESAVirtual: 0x112 Usage.
        /// </summary>
        public static readonly Usage X112 = Instance.Create(0x0070, "0x112");

        /// <summary>
        ///     VESAVirtual: 0x162 Usage.
        /// </summary>
        public static readonly Usage X162 = Instance.Create(0x00a2, "0x162");

        /// <summary>
        ///     VESAVirtual: 0x164 Usage.
        /// </summary>
        public static readonly Usage X164 = Instance.Create(0x00a4, "0x164");

        /// <summary>
        ///     VESAVirtual: 0x166 Usage.
        /// </summary>
        public static readonly Usage X166 = Instance.Create(0x00a6, "0x166");

        /// <summary>
        ///     VESAVirtual: 0x168 Usage.
        /// </summary>
        public static readonly Usage X168 = Instance.Create(0x00a8, "0x168");

        /// <summary>
        ///     VESAVirtual: 0x170 Usage.
        /// </summary>
        public static readonly Usage X170 = Instance.Create(0x00aa, "0x170");

        /// <summary>
        ///     VESAVirtual: 0x172 Usage.
        /// </summary>
        public static readonly Usage X172 = Instance.Create(0x00ac, "0x172");

        /// <summary>
        ///     VESAVirtual: 0x174 Usage.
        /// </summary>
        public static readonly Usage X174 = Instance.Create(0x00ae, "0x174");

        /// <summary>
        ///     VESAVirtual: 0x176 Usage.
        /// </summary>
        public static readonly Usage X176 = Instance.Create(0x00b0, "0x176");

        /// <summary>
        ///     VESAVirtual: 0x202 Usage.
        /// </summary>
        public static readonly Usage X202 = Instance.Create(0x00ca, "0x202");

        /// <summary>
        ///     VESAVirtual: 0x212 Usage.
        /// </summary>
        public static readonly Usage X212 = Instance.Create(0x00d4, "0x212");

        /// <summary>
        ///     VESAVirtual: Undefined Usage.
        /// </summary>
        public static readonly Usage Undefined = Instance.Create(0x0000, "Undefined");

        /// <inheritdoc />
        private VESAVirtualPage(ushort id, string name) : base(id, name, true)
        {
        }
    }

    /// <summary>
    ///     Class defining the Monitor Reserved usage page.
    /// </summary>
    public sealed partial class MonitorReservedPage : UsagePage
    {
        /// <summary>
        ///     The singleton instance of MonitorReservedPage.
        /// </summary>
        public static readonly MonitorReservedPage Instance = new MonitorReservedPage(0x0083, "Monitor Reserved");

        /// <summary>
        ///     MonitorReserved: Undefined Usage.
        /// </summary>
        public static readonly Usage Undefined = Instance.Create(0x0000, "Undefined");

        /// <inheritdoc />
        private MonitorReservedPage(ushort id, string name) : base(id, name, true)
        {
        }
    }

    /// <summary>
    ///     Class defining the Power Device usage page.
    /// </summary>
    public sealed partial class PowerDevicePage : UsagePage
    {
        /// <summary>
        ///     The singleton instance of PowerDevicePage.
        /// </summary>
        public static readonly PowerDevicePage Instance = new PowerDevicePage(0x0084, "Power Device");

        /// <summary>
        ///     PowerDevice: iName Usage.
        /// </summary>
        public static readonly Usage IName = Instance.Create(0x0001, "iName");
        /// <summary>
        ///     PowerDevice: Present Status Usage.
        /// </summary>
        public static readonly Usage PresentStatus = Instance.Create(0x0002, "Present Status");
        /// <summary>
        ///     PowerDevice: Changed Status Usage.
        /// </summary>
        public static readonly Usage ChangedStatus = Instance.Create(0x0003, "Changed Status");
        /// <summary>
        ///     PowerDevice: UPS Usage.
        /// </summary>
        public static readonly Usage UPS = Instance.Create(0x0004, "UPS");
        /// <summary>
        ///     PowerDevice: Power Supply Usage.
        /// </summary>
        public static readonly Usage PowerSupply = Instance.Create(0x0005, "Power Supply");
        /// <summary>
        ///     PowerDevice: Peripheral Device Usage.
        /// </summary>
        public static readonly Usage PeripheralDevice = Instance.Create(0x0006, "Peripheral Device");

        /// <summary>
        ///     PowerDevice: Battery System Usage.
        /// </summary>
        public static readonly Usage BatterySystem = Instance.Create(0x0010, "Battery System");
        /// <summary>
        ///     PowerDevice: Battery System ID Usage.
        /// </summary>
        public static readonly Usage BatterySystemID = Instance.Create(0x0011, "Battery System ID");
        /// <summary>
        ///     PowerDevice: Battery Usage.
        /// </summary>
        public static readonly Usage Battery = Instance.Create(0x0012, "Battery");
        /// <summary>
        ///     PowerDevice: Battery ID Usage.
        /// </summary>
        public static readonly Usage BatteryID = Instance.Create(0x0013, "Battery ID");
        /// <summary>
        ///     PowerDevice: Charger Usage.
        /// </summary>
        public static readonly Usage Charger = Instance.Create(0x0014, "Charger");
        /// <summary>
        ///     PowerDevice: Charger ID Usage.
        /// </summary>
        public static readonly Usage ChargerID = Instance.Create(0x0015, "Charger ID");
        /// <summary>
        ///     PowerDevice: Power Converter Usage.
        /// </summary>
        public static readonly Usage PowerConverter = Instance.Create(0x0016, "Power Converter");
        /// <summary>
        ///     PowerDevice: Power Converter ID Usage.
        /// </summary>
        public static readonly Usage PowerConverterID = Instance.Create(0x0017, "Power Converter ID");
        /// <summary>
        ///     PowerDevice: Outlet System Usage.
        /// </summary>
        public static readonly Usage OutletSystem = Instance.Create(0x0018, "Outlet System");
        /// <summary>
        ///     PowerDevice: Outlet System ID Usage.
        /// </summary>
        public static readonly Usage OutletSystemID = Instance.Create(0x0019, "Outlet System ID");
        /// <summary>
        ///     PowerDevice: Input Usage.
        /// </summary>
        public static readonly Usage Input = Instance.Create(0x001a, "Input");
        /// <summary>
        ///     PowerDevice: Input ID Usage.
        /// </summary>
        public static readonly Usage InputID = Instance.Create(0x001b, "Input ID");
        /// <summary>
        ///     PowerDevice: Output Usage.
        /// </summary>
        public static readonly Usage Output = Instance.Create(0x001c, "Output");
        /// <summary>
        ///     PowerDevice: Output ID Usage.
        /// </summary>
        public static readonly Usage OutputID = Instance.Create(0x001d, "Output ID");
        /// <summary>
        ///     PowerDevice: Flow Usage.
        /// </summary>
        public static readonly Usage Flow = Instance.Create(0x001e, "Flow");
        /// <summary>
        ///     PowerDevice: Flow ID Usage.
        /// </summary>
        public static readonly Usage FlowID = Instance.Create(0x001f, "Flow ID");
        /// <summary>
        ///     PowerDevice: Outlet Usage.
        /// </summary>
        public static readonly Usage Outlet = Instance.Create(0x0020, "Outlet");
        /// <summary>
        ///     PowerDevice: Outlet ID Usage.
        /// </summary>
        public static readonly Usage OutletID = Instance.Create(0x0021, "Outlet ID");
        /// <summary>
        ///     PowerDevice: Gang Usage.
        /// </summary>
        public static readonly Usage Gang = Instance.Create(0x0022, "Gang");
        /// <summary>
        ///     PowerDevice: Gang ID Usage.
        /// </summary>
        public static readonly Usage GangID = Instance.Create(0x0023, "Gang ID");
        /// <summary>
        ///     PowerDevice: Power Summary Usage.
        /// </summary>
        public static readonly Usage PowerSummary = Instance.Create(0x0022, "Power Summary");
        /// <summary>
        ///     PowerDevice: Power Summary ID Usage.
        /// </summary>
        public static readonly Usage PowerSummaryID = Instance.Create(0x0023, "Power Summary ID");

        /// <summary>
        ///     PowerDevice: Voltage Usage.
        /// </summary>
        public static readonly Usage Voltage = Instance.Create(0x0030, "Voltage");
        /// <summary>
        ///     PowerDevice: Current Usage.
        /// </summary>
        public static readonly Usage Current = Instance.Create(0x0031, "Current");
        /// <summary>
        ///     PowerDevice: Frequency Usage.
        /// </summary>
        public static readonly Usage Frequency = Instance.Create(0x0032, "Frequency");
        /// <summary>
        ///     PowerDevice: Apparent Power Usage.
        /// </summary>
        public static readonly Usage ApparentPower = Instance.Create(0x0033, "Apparent Power");
        /// <summary>
        ///     PowerDevice: Active Power Usage.
        /// </summary>
        public static readonly Usage ActivePower = Instance.Create(0x0034, "Active Power");
        /// <summary>
        ///     PowerDevice: Load (percent) Usage.
        /// </summary>
        public static readonly Usage LoadPercent = Instance.Create(0x0035, "Load (percent)");
        /// <summary>
        ///     PowerDevice: Temperature Usage.
        /// </summary>
        public static readonly Usage Temperature = Instance.Create(0x0036, "Temperature");
        /// <summary>
        ///     PowerDevice: Humidity Usage.
        /// </summary>
        public static readonly Usage Humidity = Instance.Create(0x0037, "Humidity");
        /// <summary>
        ///     PowerDevice: Bad Count Usage.
        /// </summary>
        public static readonly Usage BadCount = Instance.Create(0x0038, "Bad Count");

        /// <summary>
        ///     PowerDevice: Nominal Voltage Usage.
        /// </summary>
        public static readonly Usage NominalVoltage = Instance.Create(0x0040, "Nominal Voltage");
        /// <summary>
        ///     PowerDevice: Nominal Current Usage.
        /// </summary>
        public static readonly Usage NominalCurrent = Instance.Create(0x0041, "Nominal Current");
        /// <summary>
        ///     PowerDevice: Nominal Frequency Usage.
        /// </summary>
        public static readonly Usage NominalFrequency = Instance.Create(0x0042, "Nominal Frequency");
        /// <summary>
        ///     PowerDevice: Nominal Apparent Power Usage.
        /// </summary>
        public static readonly Usage NominalApparentPower = Instance.Create(0x0043, "Nominal Apparent Power");
        /// <summary>
        ///     PowerDevice: Nominal Active Power Usage.
        /// </summary>
        public static readonly Usage NominalActivePower = Instance.Create(0x0044, "Nominal Active Power");
        /// <summary>
        ///     PowerDevice: Nominal Load (percent) Usage.
        /// </summary>
        public static readonly Usage NominalLoadPercent = Instance.Create(0x0045, "Nominal Load (percent)");
        /// <summary>
        ///     PowerDevice: Nominal Temperature Usage.
        /// </summary>
        public static readonly Usage NominalTemperature = Instance.Create(0x0046, "Nominal Temperature");
        /// <summary>
        ///     PowerDevice: Nominal Humidity Usage.
        /// </summary>
        public static readonly Usage NominalHumidity = Instance.Create(0x0047, "Nominal Humidity");

        /// <summary>
        ///     PowerDevice: Switch On Control Usage.
        /// </summary>
        public static readonly Usage SwitchOnControl = Instance.Create(0x0050, "Switch On Control");
        /// <summary>
        ///     PowerDevice: Switch Off Control Usage.
        /// </summary>
        public static readonly Usage SwitchOffControl = Instance.Create(0x0051, "Switch Off Control");
        /// <summary>
        ///     PowerDevice: Toggle Control Usage.
        /// </summary>
        public static readonly Usage ToggleControl = Instance.Create(0x0052, "Toggle Control");
        /// <summary>
        ///     PowerDevice: Low Voltage Transfer Usage.
        /// </summary>
        public static readonly Usage LowVoltageTransfer = Instance.Create(0x0053, "Low Voltage Transfer");
        /// <summary>
        ///     PowerDevice: High Voltage Transfer Usage.
        /// </summary>
        public static readonly Usage HighVoltageTransfer = Instance.Create(0x0054, "High Voltage Transfer");
        /// <summary>
        ///     PowerDevice: Delay Before Reboot Usage.
        /// </summary>
        public static readonly Usage DelayBeforeReboot = Instance.Create(0x0055, "Delay Before Reboot");
        /// <summary>
        ///     PowerDevice: Delay Before Startup Usage.
        /// </summary>
        public static readonly Usage DelayBeforeStartup = Instance.Create(0x0056, "Delay Before Startup");
        /// <summary>
        ///     PowerDevice: Delay Before Shutdown Usage.
        /// </summary>
        public static readonly Usage DelayBeforeShutdown = Instance.Create(0x0057, "Delay Before Shutdown");
        /// <summary>
        ///     PowerDevice: Test Usage.
        /// </summary>
        public static readonly Usage Test = Instance.Create(0x0058, "Test");
        /// <summary>
        ///     PowerDevice: Module Reset Usage.
        /// </summary>
        public static readonly Usage ModuleReset = Instance.Create(0x0059, "Module Reset");
        /// <summary>
        ///     PowerDevice: Audible Alarm Control Usage.
        /// </summary>
        public static readonly Usage AudibleAlarmControl = Instance.Create(0x005a, "Audible Alarm Control");

        /// <summary>
        ///     PowerDevice: Present Usage.
        /// </summary>
        public static readonly Usage Present = Instance.Create(0x0060, "Present");
        /// <summary>
        ///     PowerDevice: Good Usage.
        /// </summary>
        public static readonly Usage Good = Instance.Create(0x0061, "Good");
        /// <summary>
        ///     PowerDevice: Internal Failure Usage.
        /// </summary>
        public static readonly Usage InternalFailure = Instance.Create(0x0062, "Internal Failure");
        /// <summary>
        ///     PowerDevice: Voltage Out Of Range Usage.
        /// </summary>
        public static readonly Usage VoltageOutOfRange = Instance.Create(0x0063, "Voltage Out Of Range");
        /// <summary>
        ///     PowerDevice: Frequency Out Of Range Usage.
        /// </summary>
        public static readonly Usage FrequencyOutOfRange = Instance.Create(0x0064, "Frequency Out Of Range");
        /// <summary>
        ///     PowerDevice: Overload Usage.
        /// </summary>
        public static readonly Usage Overload = Instance.Create(0x0065, "Overload");
        /// <summary>
        ///     PowerDevice: Overcharged Usage.
        /// </summary>
        public static readonly Usage Overcharged = Instance.Create(0x0066, "Overcharged");
        /// <summary>
        ///     PowerDevice: Over Temperature Usage.
        /// </summary>
        public static readonly Usage OverTemperature = Instance.Create(0x0067, "Over Temperature");
        /// <summary>
        ///     PowerDevice: Shutdown Requested Usage.
        /// </summary>
        public static readonly Usage ShutdownRequested = Instance.Create(0x0068, "Shutdown Requested");
        /// <summary>
        ///     PowerDevice: Shutdown Imminent Usage.
        /// </summary>
        public static readonly Usage ShutdownImminent = Instance.Create(0x0069, "Shutdown Imminent");

        /// <summary>
        ///     PowerDevice: Switch On/Off Usage.
        /// </summary>
        public static readonly Usage SwitchOnOff = Instance.Create(0x006b, "Switch On/Off");
        /// <summary>
        ///     PowerDevice: Switchable Usage.
        /// </summary>
        public static readonly Usage Switchable = Instance.Create(0x006c, "Switchable");
        /// <summary>
        ///     PowerDevice: Used Usage.
        /// </summary>
        public static readonly Usage Used = Instance.Create(0x006d, "Used");
        /// <summary>
        ///     PowerDevice: Boost Usage.
        /// </summary>
        public static readonly Usage Boost = Instance.Create(0x006e, "Boost");
        /// <summary>
        ///     PowerDevice: Buck Usage.
        /// </summary>
        public static readonly Usage Buck = Instance.Create(0x006f, "Buck");
        /// <summary>
        ///     PowerDevice: Initialized Usage.
        /// </summary>
        public static readonly Usage Initialized = Instance.Create(0x0070, "Initialized");
        /// <summary>
        ///     PowerDevice: Tested Usage.
        /// </summary>
        public static readonly Usage Tested = Instance.Create(0x0071, "Tested");
        /// <summary>
        ///     PowerDevice: Awaiting Power Usage.
        /// </summary>
        public static readonly Usage AwaitingPower = Instance.Create(0x0072, "Awaiting Power");
        /// <summary>
        ///     PowerDevice: Communication Lost Usage.
        /// </summary>
        public static readonly Usage CommunicationLost = Instance.Create(0x0073, "Communication Lost");

        /// <summary>
        ///     PowerDevice: iManufacturer Usage.
        /// </summary>
        public static readonly Usage IManufacturer = Instance.Create(0x00fd, "iManufacturer");
        /// <summary>
        ///     PowerDevice: iProduct Usage.
        /// </summary>
        public static readonly Usage IProduct = Instance.Create(0x00fe, "iProduct");
        /// <summary>
        ///     PowerDevice: iSerialNumber Usage.
        /// </summary>
        public static readonly Usage ISerialNumber = Instance.Create(0x00ff, "iSerialNumber");

        /// <summary>
        ///     PowerDevice: Undefined Usage.
        /// </summary>
        public static readonly Usage Undefined = Instance.Create(0x0000, "Undefined");

        /// <inheritdoc />
        private PowerDevicePage(ushort id, string name) : base(id, name, true)
        {
        }
    }

    /// <summary>
    ///     Class defining the Battery System usage page.
    /// </summary>
    public sealed partial class BatterySystemPage : UsagePage
    {
        /// <summary>
        ///     The singleton instance of BatterySystemPage.
        /// </summary>
        public static readonly BatterySystemPage Instance = new BatterySystemPage(0x0085, "Battery System");

        /// <summary>
        ///     BatterySystem: SMB Battery Mode Usage.
        /// </summary>
        public static readonly Usage SMBBatteryMode = Instance.Create(0x0001, "SMB Battery Mode");
        /// <summary>
        ///     BatterySystem: SMB Battery Status Usage.
        /// </summary>
        public static readonly Usage SMBBatteryStatus = Instance.Create(0x0002, "SMB Battery Status");
        /// <summary>
        ///     BatterySystem: SMB Alarm Warning Usage.
        /// </summary>
        public static readonly Usage SMBAlarmWarning = Instance.Create(0x0003, "SMB Alarm Warning");
        /// <summary>
        ///     BatterySystem: SMB Charger Mode Usage.
        /// </summary>
        public static readonly Usage SMBChargerMode = Instance.Create(0x0004, "SMB Charger Mode");
        /// <summary>
        ///     BatterySystem: SMB Charger Status Usage.
        /// </summary>
        public static readonly Usage SMBChargerStatus = Instance.Create(0x0005, "SMB Charger Status");
        /// <summary>
        ///     BatterySystem: SMB Charger Spec Info Usage.
        /// </summary>
        public static readonly Usage SMBChargerSpecInfo = Instance.Create(0x0006, "SMB Charger Spec Info");
        /// <summary>
        ///     BatterySystem: SMB Selector State Usage.
        /// </summary>
        public static readonly Usage SMBSelectorState = Instance.Create(0x0007, "SMB Selector State");
        /// <summary>
        ///     BatterySystem: SMB Selector Presets Usage.
        /// </summary>
        public static readonly Usage SMBSelectorPresets = Instance.Create(0x0008, "SMB Selector Presets");
        /// <summary>
        ///     BatterySystem: SMB Selector Info Usage.
        /// </summary>
        public static readonly Usage SMBSelectorInfo = Instance.Create(0x0009, "SMB Selector Info");

        /// <summary>
        ///     BatterySystem: Optional Mfg Function 1 Usage.
        /// </summary>
        public static readonly Usage OptionalMfgFunction1 = Instance.Create(0x0010, "Optional Mfg Function 1");
        /// <summary>
        ///     BatterySystem: Optional Mfg Function 2 Usage.
        /// </summary>
        public static readonly Usage OptionalMfgFunction2 = Instance.Create(0x0011, "Optional Mfg Function 2");
        /// <summary>
        ///     BatterySystem: Optional Mfg Function 3 Usage.
        /// </summary>
        public static readonly Usage OptionalMfgFunction3 = Instance.Create(0x0012, "Optional Mfg Function 3");
        /// <summary>
        ///     BatterySystem: Optional Mfg Function 4 Usage.
        /// </summary>
        public static readonly Usage OptionalMfgFunction4 = Instance.Create(0x0013, "Optional Mfg Function 4");
        /// <summary>
        ///     BatterySystem: Optional Mfg Function 5 Usage.
        /// </summary>
        public static readonly Usage OptionalMfgFunction5 = Instance.Create(0x0014, "Optional Mfg Function 5");
        /// <summary>
        ///     BatterySystem: Connection To SMBus Usage.
        /// </summary>
        public static readonly Usage ConnectionToSMBus = Instance.Create(0x0015, "Connection To SMBus");
        /// <summary>
        ///     BatterySystem: Output Connection Usage.
        /// </summary>
        public static readonly Usage OutputConnection = Instance.Create(0x0016, "Output Connection");
        /// <summary>
        ///     BatterySystem: Charger Connection Usage.
        /// </summary>
        public static readonly Usage ChargerConnection = Instance.Create(0x0017, "Charger Connection");
        /// <summary>
        ///     BatterySystem: Battery Insertion Usage.
        /// </summary>
        public static readonly Usage BatteryInsertion = Instance.Create(0x0018, "Battery Insertion");
        /// <summary>
        ///     BatterySystem: Use Next Usage.
        /// </summary>
        public static readonly Usage UseNext = Instance.Create(0x0019, "Use Next");
        /// <summary>
        ///     BatterySystem: OK To Use Usage.
        /// </summary>
        public static readonly Usage OKToUse = Instance.Create(0x001a, "OK To Use");
        /// <summary>
        ///     BatterySystem: Battery Supported Usage.
        /// </summary>
        public static readonly Usage BatterySupported = Instance.Create(0x001b, "Battery Supported");
        /// <summary>
        ///     BatterySystem: Selector Revision Usage.
        /// </summary>
        public static readonly Usage SelectorRevision = Instance.Create(0x001c, "Selector Revision");
        /// <summary>
        ///     BatterySystem: Charging Indicator Usage.
        /// </summary>
        public static readonly Usage ChargingIndicator = Instance.Create(0x001d, "Charging Indicator");

        /// <summary>
        ///     BatterySystem: Manufacturer Access Usage.
        /// </summary>
        public static readonly Usage ManufacturerAccess = Instance.Create(0x0028, "Manufacturer Access");
        /// <summary>
        ///     BatterySystem: Remaining Capacity Limit Usage.
        /// </summary>
        public static readonly Usage RemainingCapacityLimit = Instance.Create(0x0029, "Remaining Capacity Limit");
        /// <summary>
        ///     BatterySystem: Remaining Time Limit Usage.
        /// </summary>
        public static readonly Usage RemainingTimeLimit = Instance.Create(0x002a, "Remaining Time Limit");
        /// <summary>
        ///     BatterySystem: At Rate Usage.
        /// </summary>
        public static readonly Usage AtRate = Instance.Create(0x002b, "At Rate");
        /// <summary>
        ///     BatterySystem: Capacity Mode Usage.
        /// </summary>
        public static readonly Usage CapacityMode = Instance.Create(0x002c, "Capacity Mode");
        /// <summary>
        ///     BatterySystem: Broadcast To Charger Usage.
        /// </summary>
        public static readonly Usage BroadcastToCharger = Instance.Create(0x002d, "Broadcast To Charger");
        /// <summary>
        ///     BatterySystem: Primary Battery Usage.
        /// </summary>
        public static readonly Usage PrimaryBattery = Instance.Create(0x002e, "Primary Battery");
        /// <summary>
        ///     BatterySystem: Charge Controller Usage.
        /// </summary>
        public static readonly Usage ChargeController = Instance.Create(0x002f, "Charge Controller");

        /// <summary>
        ///     BatterySystem: Terminate Charge Usage.
        /// </summary>
        public static readonly Usage TerminateCharge = Instance.Create(0x0040, "Terminate Charge");
        /// <summary>
        ///     BatterySystem: Terminate Discharge Usage.
        /// </summary>
        public static readonly Usage TerminateDischarge = Instance.Create(0x0041, "Terminate Discharge");
        /// <summary>
        ///     BatterySystem: Below Remaining Capacity Limit Usage.
        /// </summary>
        public static readonly Usage BelowRemainingCapacityLimit = Instance.Create(0x0042, "Below Remaining Capacity Limit");
        /// <summary>
        ///     BatterySystem: Remaining Time Limit Expired Usage.
        /// </summary>
        public static readonly Usage RemainingTimeLimitExpired = Instance.Create(0x0043, "Remaining Time Limit Expired");
        /// <summary>
        ///     BatterySystem: Charging Usage.
        /// </summary>
        public static readonly Usage Charging = Instance.Create(0x0044, "Charging");
        /// <summary>
        ///     BatterySystem: Discharging Usage.
        /// </summary>
        public static readonly Usage Discharging = Instance.Create(0x0045, "Discharging");
        /// <summary>
        ///     BatterySystem: Fully Charged Usage.
        /// </summary>
        public static readonly Usage FullyCharged = Instance.Create(0x0046, "Fully Charged");
        /// <summary>
        ///     BatterySystem: Fully Discharged Usage.
        /// </summary>
        public static readonly Usage FullyDischarged = Instance.Create(0x0047, "Fully Discharged");
        /// <summary>
        ///     BatterySystem: Conditioning Flag Usage.
        /// </summary>
        public static readonly Usage ConditioningFlag = Instance.Create(0x0048, "Conditioning Flag");
        /// <summary>
        ///     BatterySystem: At Rate OK Usage.
        /// </summary>
        public static readonly Usage AtRateOK = Instance.Create(0x0049, "At Rate OK");
        /// <summary>
        ///     BatterySystem: SMB Error Code Usage.
        /// </summary>
        public static readonly Usage SMBErrorCode = Instance.Create(0x004a, "SMB Error Code");
        /// <summary>
        ///     BatterySystem: Need Replacement Usage.
        /// </summary>
        public static readonly Usage NeedReplacement = Instance.Create(0x004b, "Need Replacement");

        /// <summary>
        ///     BatterySystem: At Rate Time To Full Usage.
        /// </summary>
        public static readonly Usage AtRateTimeToFull = Instance.Create(0x0060, "At Rate Time To Full");
        /// <summary>
        ///     BatterySystem: At Rate Time To Empty Usage.
        /// </summary>
        public static readonly Usage AtRateTimeToEmpty = Instance.Create(0x0061, "At Rate Time To Empty");
        /// <summary>
        ///     BatterySystem: Average Current Usage.
        /// </summary>
        public static readonly Usage AverageCurrent = Instance.Create(0x0062, "Average Current");
        /// <summary>
        ///     BatterySystem: Max Error Usage.
        /// </summary>
        public static readonly Usage MaxError = Instance.Create(0x0063, "Max Error");
        /// <summary>
        ///     BatterySystem: Relative State Of Charge Usage.
        /// </summary>
        public static readonly Usage RelativeStateOfCharge = Instance.Create(0x0064, "Relative State Of Charge");
        /// <summary>
        ///     BatterySystem: Absolute State Of Charge Usage.
        /// </summary>
        public static readonly Usage AbsoluteStateOfCharge = Instance.Create(0x0065, "Absolute State Of Charge");
        /// <summary>
        ///     BatterySystem: Remaining Capacity Usage.
        /// </summary>
        public static readonly Usage RemainingCapacity = Instance.Create(0x0066, "Remaining Capacity");
        /// <summary>
        ///     BatterySystem: Full Charge Capacity Usage.
        /// </summary>
        public static readonly Usage FullChargeCapacity = Instance.Create(0x0067, "Full Charge Capacity");
        /// <summary>
        ///     BatterySystem: Run Time To Empty Usage.
        /// </summary>
        public static readonly Usage RunTimeToEmpty = Instance.Create(0x0068, "Run Time To Empty");
        /// <summary>
        ///     BatterySystem: Average Time To Empty Usage.
        /// </summary>
        public static readonly Usage AverageTimeToEmpty = Instance.Create(0x0069, "Average Time To Empty");
        /// <summary>
        ///     BatterySystem: Average Time To Full Usage.
        /// </summary>
        public static readonly Usage AverageTimeToFull = Instance.Create(0x006a, "Average Time To Full");
        /// <summary>
        ///     BatterySystem: Cycle Count Usage.
        /// </summary>
        public static readonly Usage CycleCount = Instance.Create(0x006b, "Cycle Count");

        /// <summary>
        ///     BatterySystem: Battery Pack Model Level Usage.
        /// </summary>
        public static readonly Usage BatteryPackModelLevel = Instance.Create(0x0080, "Battery Pack Model Level");
        /// <summary>
        ///     BatterySystem: Internal Charge Controller Usage.
        /// </summary>
        public static readonly Usage InternalChargeController = Instance.Create(0x0081, "Internal Charge Controller");
        /// <summary>
        ///     BatterySystem: Primary Battery Support Usage.
        /// </summary>
        public static readonly Usage PrimaryBatterySupport = Instance.Create(0x0082, "Primary Battery Support");
        /// <summary>
        ///     BatterySystem: Design Capacity Usage.
        /// </summary>
        public static readonly Usage DesignCapacity = Instance.Create(0x0083, "Design Capacity");
        /// <summary>
        ///     BatterySystem: Specification Info Usage.
        /// </summary>
        public static readonly Usage SpecificationInfo = Instance.Create(0x0084, "Specification Info");
        /// <summary>
        ///     BatterySystem: Manufacturer Date Usage.
        /// </summary>
        public static readonly Usage ManufacturerDate = Instance.Create(0x0085, "Manufacturer Date");
        /// <summary>
        ///     BatterySystem: Serial Number Usage.
        /// </summary>
        public static readonly Usage SerialNumber = Instance.Create(0x0086, "Serial Number");
        /// <summary>
        ///     BatterySystem: iManufacturer Usage.
        /// </summary>
        public static readonly Usage IManufacturer = Instance.Create(0x0087, "iManufacturer");
        /// <summary>
        ///     BatterySystem: iDeviceName Usage.
        /// </summary>
        public static readonly Usage IDeviceName = Instance.Create(0x0088, "iDeviceName");
        /// <summary>
        ///     BatterySystem: iDeviceChemistry Usage.
        /// </summary>
        public static readonly Usage IDeviceChemistry = Instance.Create(0x0089, "iDeviceChemistry");
        /// <summary>
        ///     BatterySystem: Manufacturer Data Usage.
        /// </summary>
        public static readonly Usage ManufacturerData = Instance.Create(0x008a, "Manufacturer Data");
        /// <summary>
        ///     BatterySystem: Rechargeable Usage.
        /// </summary>
        public static readonly Usage Rechargeable = Instance.Create(0x008b, "Rechargeable");
        /// <summary>
        ///     BatterySystem: Warning Capacity Limit Usage.
        /// </summary>
        public static readonly Usage WarningCapacityLimit = Instance.Create(0x008c, "Warning Capacity Limit");
        /// <summary>
        ///     BatterySystem: Capacity Granularity 1 Usage.
        /// </summary>
        public static readonly Usage CapacityGranularity1 = Instance.Create(0x008d, "Capacity Granularity 1");
        /// <summary>
        ///     BatterySystem: Capacity Granularity 2 Usage.
        /// </summary>
        public static readonly Usage CapacityGranularity2 = Instance.Create(0x008e, "Capacity Granularity 2");
        /// <summary>
        ///     BatterySystem: iOEMInformation Usage.
        /// </summary>
        public static readonly Usage IOEMInformation = Instance.Create(0x008f, "iOEMInformation");

        /// <summary>
        ///     BatterySystem: Inhibit Charge Usage.
        /// </summary>
        public static readonly Usage InhibitCharge = Instance.Create(0x00c0, "Inhibit Charge");
        /// <summary>
        ///     BatterySystem: Enable Polling Usage.
        /// </summary>
        public static readonly Usage EnablePolling = Instance.Create(0x00c1, "Enable Polling");
        /// <summary>
        ///     BatterySystem: Reset To Zero Usage.
        /// </summary>
        public static readonly Usage ResetToZero = Instance.Create(0x00c2, "Reset To Zero");

        /// <summary>
        ///     BatterySystem: AC Present Usage.
        /// </summary>
        public static readonly Usage ACPresent = Instance.Create(0x00d0, "AC Present");
        /// <summary>
        ///     BatterySystem: Battery Present Usage.
        /// </summary>
        public static readonly Usage BatteryPresent = Instance.Create(0x00d1, "Battery Present");
        /// <summary>
        ///     BatterySystem: Power Fail Usage.
        /// </summary>
        public static readonly Usage PowerFail = Instance.Create(0x00d2, "Power Fail");
        /// <summary>
        ///     BatterySystem: Alarm Inhibited Usage.
        /// </summary>
        public static readonly Usage AlarmInhibited = Instance.Create(0x00d3, "Alarm Inhibited");
        /// <summary>
        ///     BatterySystem: Thermistor Under Range Usage.
        /// </summary>
        public static readonly Usage ThermistorUnderRange = Instance.Create(0x00d4, "Thermistor Under Range");
        /// <summary>
        ///     BatterySystem: Thermistor Hot Usage.
        /// </summary>
        public static readonly Usage ThermistorHot = Instance.Create(0x00d5, "Thermistor Hot");
        /// <summary>
        ///     BatterySystem: Thermistor Cold Usage.
        /// </summary>
        public static readonly Usage ThermistorCold = Instance.Create(0x00d6, "Thermistor Cold");
        /// <summary>
        ///     BatterySystem: Thermistor Over Range Usage.
        /// </summary>
        public static readonly Usage ThermistorOverRange = Instance.Create(0x00d7, "Thermistor Over Range");
        /// <summary>
        ///     BatterySystem: Voltage Out Of Range Usage.
        /// </summary>
        public static readonly Usage VoltageOutOfRange = Instance.Create(0x00d8, "Voltage Out Of Range");
        /// <summary>
        ///     BatterySystem: Current Out Of Range Usage.
        /// </summary>
        public static readonly Usage CurrentOutOfRange = Instance.Create(0x00d9, "Current Out Of Range");
        /// <summary>
        ///     BatterySystem: Current Not Regulated Usage.
        /// </summary>
        public static readonly Usage CurrentNotRegulated = Instance.Create(0x00da, "Current Not Regulated");
        /// <summary>
        ///     BatterySystem: Voltage Not Regulated Usage.
        /// </summary>
        public static readonly Usage VoltageNotRegulated = Instance.Create(0x00db, "Voltage Not Regulated");
        /// <summary>
        ///     BatterySystem: Master Mode Usage.
        /// </summary>
        public static readonly Usage MasterMode = Instance.Create(0x00dc, "Master Mode");

        /// <summary>
        ///     BatterySystem: Charger Selector Support Usage.
        /// </summary>
        public static readonly Usage ChargerSelectorSupport = Instance.Create(0x00f0, "Charger Selector Support");
        /// <summary>
        ///     BatterySystem: Charger Spec Usage.
        /// </summary>
        public static readonly Usage ChargerSpec = Instance.Create(0x00f1, "Charger Spec");
        /// <summary>
        ///     BatterySystem: Level 2 Usage.
        /// </summary>
        public static readonly Usage Level2 = Instance.Create(0x00f2, "Level 2");
        /// <summary>
        ///     BatterySystem: Level 3 Usage.
        /// </summary>
        public static readonly Usage Level3 = Instance.Create(0x00f3, "Level 3");

        /// <summary>
        ///     BatterySystem: Undefined Usage.
        /// </summary>
        public static readonly Usage Undefined = Instance.Create(0x0000, "Undefined");

        /// <inheritdoc />
        private BatterySystemPage(ushort id, string name) : base(id, name, true)
        {
        }
    }

    /// <summary>
    ///     Class defining the Bar Code Scanner usage page.
    /// </summary>
    public sealed partial class BarCodeScannerPage : UsagePage
    {
        /// <summary>
        ///     The singleton instance of BarCodeScannerPage.
        /// </summary>
        public static readonly BarCodeScannerPage Instance = new BarCodeScannerPage(0x008c, "Bar Code Scanner");

        /// <summary>
        ///     BarCodeScanner: Bar Code Badge Reader Usage.
        /// </summary>
        public static readonly Usage BarCodeBadgeReader = Instance.Create(0x0001, "Bar Code Badge Reader");
        /// <summary>
        ///     BarCodeScanner: Bar Code Scanner Usage.
        /// </summary>
        public static readonly Usage BarCodeScanner = Instance.Create(0x0002, "Bar Code Scanner");
        /// <summary>
        ///     BarCodeScanner: Dumb Bar Code Scanner Usage.
        /// </summary>
        public static readonly Usage DumbBarCodeScanner = Instance.Create(0x0003, "Dumb Bar Code Scanner");
        /// <summary>
        ///     BarCodeScanner: Cordless Scanner Base Usage.
        /// </summary>
        public static readonly Usage CordlessScannerBase = Instance.Create(0x0004, "Cordless Scanner Base");
        /// <summary>
        ///     BarCodeScanner: Bar Code Scanner Cradle Usage.
        /// </summary>
        public static readonly Usage BarCodeScannerCradle = Instance.Create(0x0005, "Bar Code Scanner Cradle");

        /// <summary>
        ///     BarCodeScanner: Attribute Report Usage.
        /// </summary>
        public static readonly Usage AttributeReport = Instance.Create(0x0010, "Attribute Report");
        /// <summary>
        ///     BarCodeScanner: Settings Report Usage.
        /// </summary>
        public static readonly Usage SettingsReport = Instance.Create(0x0011, "Settings Report");
        /// <summary>
        ///     BarCodeScanner: Scanned Data Report Usage.
        /// </summary>
        public static readonly Usage ScannedDataReport = Instance.Create(0x0012, "Scanned Data Report");
        /// <summary>
        ///     BarCodeScanner: Raw Scanned Data Report Usage.
        /// </summary>
        public static readonly Usage RawScannedDataReport = Instance.Create(0x0013, "Raw Scanned Data Report");
        /// <summary>
        ///     BarCodeScanner: Trigger Report Usage.
        /// </summary>
        public static readonly Usage TriggerReport = Instance.Create(0x0014, "Trigger Report");
        /// <summary>
        ///     BarCodeScanner: Status Report Usage.
        /// </summary>
        public static readonly Usage StatusReport = Instance.Create(0x0015, "Status Report");
        /// <summary>
        ///     BarCodeScanner: UPC/EAN Control Report Usage.
        /// </summary>
        public static readonly Usage UPCEANControlReport = Instance.Create(0x0016, "UPC/EAN Control Report");
        /// <summary>
        ///     BarCodeScanner: EAN 2/3 Label Control Report Usage.
        /// </summary>
        public static readonly Usage EAN23LabelControlReport = Instance.Create(0x0017, "EAN 2/3 Label Control Report");
        /// <summary>
        ///     BarCodeScanner: Code 39 Control Report Usage.
        /// </summary>
        public static readonly Usage Code39ControlReport = Instance.Create(0x0018, "Code 39 Control Report");
        /// <summary>
        ///     BarCodeScanner: Interleaved 2 of 5 Control Report Usage.
        /// </summary>
        public static readonly Usage Interleaved2Of5ControlReport = Instance.Create(0x0019, "Interleaved 2 of 5 Control Report");
        /// <summary>
        ///     BarCodeScanner: Standard 2 of 5 Control Report Usage.
        /// </summary>
        public static readonly Usage Standard2Of5ControlReport = Instance.Create(0x001a, "Standard 2 of 5 Control Report");
        /// <summary>
        ///     BarCodeScanner: MSI Plessey Control Report Usage.
        /// </summary>
        public static readonly Usage MSIPlesseyControlReport = Instance.Create(0x001b, "MSI Plessey Control Report");
        /// <summary>
        ///     BarCodeScanner: Codabar Control Report Usage.
        /// </summary>
        public static readonly Usage CodabarControlReport = Instance.Create(0x001c, "Codabar Control Report");
        /// <summary>
        ///     BarCodeScanner: Code 128 Control Report Usage.
        /// </summary>
        public static readonly Usage Code128ControlReport = Instance.Create(0x001d, "Code 128 Control Report");
        /// <summary>
        ///     BarCodeScanner: Misc 1D Control Report Usage.
        /// </summary>
        public static readonly Usage Misc1DControlReport = Instance.Create(0x001e, "Misc 1D Control Report");
        /// <summary>
        ///     BarCodeScanner: 2D Control Report Usage.
        /// </summary>
        public static readonly Usage DControlReport = Instance.Create(0x001f, "2D Control Report");

        /// <summary>
        ///     BarCodeScanner: Aiming/Pointer Mode Usage.
        /// </summary>
        public static readonly Usage AimingPointerMode = Instance.Create(0x0030, "Aiming/Pointer Mode");
        /// <summary>
        ///     BarCodeScanner: Bar Code Present Sensor Usage.
        /// </summary>
        public static readonly Usage BarCodePresentSensor = Instance.Create(0x0031, "Bar Code Present Sensor");
        /// <summary>
        ///     BarCodeScanner: Class 1A Laser Usage.
        /// </summary>
        public static readonly Usage Class1ALaser = Instance.Create(0x0032, "Class 1A Laser");
        /// <summary>
        ///     BarCodeScanner: Class 2 Laser Usage.
        /// </summary>
        public static readonly Usage Class2Laser = Instance.Create(0x0033, "Class 2 Laser");
        /// <summary>
        ///     BarCodeScanner: Heater Present Usage.
        /// </summary>
        public static readonly Usage HeaterPresent = Instance.Create(0x0034, "Heater Present");
        /// <summary>
        ///     BarCodeScanner: Contact Scanner Usage.
        /// </summary>
        public static readonly Usage ContactScanner = Instance.Create(0x0035, "Contact Scanner");
        /// <summary>
        ///     BarCodeScanner: Electronic Article Surveillance Notification Usage.
        /// </summary>
        public static readonly Usage ElectronicArticleSurveillanceNotification = Instance.Create(0x0036, "Electronic Article Surveillance Notification");
        /// <summary>
        ///     BarCodeScanner: Constant Electronic Article Surveillance Usage.
        /// </summary>
        public static readonly Usage ConstantElectronicArticleSurveillance = Instance.Create(0x0037, "Constant Electronic Article Surveillance");
        /// <summary>
        ///     BarCodeScanner: Error Indication Usage.
        /// </summary>
        public static readonly Usage ErrorIndication = Instance.Create(0x0038, "Error Indication");
        /// <summary>
        ///     BarCodeScanner: Fixed Beeper Usage.
        /// </summary>
        public static readonly Usage FixedBeeper = Instance.Create(0x0039, "Fixed Beeper");
        /// <summary>
        ///     BarCodeScanner: Good Decode Indication Usage.
        /// </summary>
        public static readonly Usage GoodDecodeIndication = Instance.Create(0x003a, "Good Decode Indication");
        /// <summary>
        ///     BarCodeScanner: Hands Free Scanning Usage.
        /// </summary>
        public static readonly Usage HandsFreeScanning = Instance.Create(0x003b, "Hands Free Scanning");
        /// <summary>
        ///     BarCodeScanner: Intrinsically Safe Usage.
        /// </summary>
        public static readonly Usage IntrinsicallySafe = Instance.Create(0x003c, "Intrinsically Safe");
        /// <summary>
        ///     BarCodeScanner: Class 1 Laser Usage.
        /// </summary>
        public static readonly Usage Class1Laser = Instance.Create(0x003d, "Class 1 Laser");
        /// <summary>
        ///     BarCodeScanner: Long Range Scanner Usage.
        /// </summary>
        public static readonly Usage LongRangeScanner = Instance.Create(0x003e, "Long Range Scanner");
        /// <summary>
        ///     BarCodeScanner: Mirror Speed Control Usage.
        /// </summary>
        public static readonly Usage MirrorSpeedControl = Instance.Create(0x003f, "Mirror Speed Control");
        /// <summary>
        ///     BarCodeScanner: Not On File Indication Usage.
        /// </summary>
        public static readonly Usage NotOnFileIndication = Instance.Create(0x0040, "Not On File Indication");
        /// <summary>
        ///     BarCodeScanner: Programmable Beeper Usage.
        /// </summary>
        public static readonly Usage ProgrammableBeeper = Instance.Create(0x0041, "Programmable Beeper");
        /// <summary>
        ///     BarCodeScanner: Triggerless Usage.
        /// </summary>
        public static readonly Usage Triggerless = Instance.Create(0x0042, "Triggerless");
        /// <summary>
        ///     BarCodeScanner: Wand Usage.
        /// </summary>
        public static readonly Usage Wand = Instance.Create(0x0043, "Wand");
        /// <summary>
        ///     BarCodeScanner: Water Resistant Usage.
        /// </summary>
        public static readonly Usage WaterResistant = Instance.Create(0x0044, "Water Resistant");
        /// <summary>
        ///     BarCodeScanner: Multi-Range Scanner Usage.
        /// </summary>
        public static readonly Usage MultiRangeScanner = Instance.Create(0x0045, "Multi-Range Scanner");
        /// <summary>
        ///     BarCodeScanner: Proximity Sensor Usage.
        /// </summary>
        public static readonly Usage ProximitySensor = Instance.Create(0x0046, "Proximity Sensor");

        /// <summary>
        ///     BarCodeScanner: Fragment Decoding Usage.
        /// </summary>
        public static readonly Usage FragmentDecoding = Instance.Create(0x004d, "Fragment Decoding");
        /// <summary>
        ///     BarCodeScanner: Scanner Read Confidence Usage.
        /// </summary>
        public static readonly Usage ScannerReadConfidence = Instance.Create(0x004e, "Scanner Read Confidence");
        /// <summary>
        ///     BarCodeScanner: Data Prefix Usage.
        /// </summary>
        public static readonly Usage DataPrefix = Instance.Create(0x004f, "Data Prefix");
        /// <summary>
        ///     BarCodeScanner: Prefix AIMI Usage.
        /// </summary>
        public static readonly Usage PrefixAIMI = Instance.Create(0x0050, "Prefix AIMI");
        /// <summary>
        ///     BarCodeScanner: Prefix None Usage.
        /// </summary>
        public static readonly Usage PrefixNone = Instance.Create(0x0051, "Prefix None");
        /// <summary>
        ///     BarCodeScanner: Prefix Proprietary Usage.
        /// </summary>
        public static readonly Usage PrefixProprietary = Instance.Create(0x0052, "Prefix Proprietary");

        /// <summary>
        ///     BarCodeScanner: Active Time Usage.
        /// </summary>
        public static readonly Usage ActiveTime = Instance.Create(0x0055, "Active Time");
        /// <summary>
        ///     BarCodeScanner: Aiming Laser Pattern Usage.
        /// </summary>
        public static readonly Usage AimingLaserPattern = Instance.Create(0x0056, "Aiming Laser Pattern");
        /// <summary>
        ///     BarCodeScanner: Bar Code Present Usage.
        /// </summary>
        public static readonly Usage BarCodePresent = Instance.Create(0x0057, "Bar Code Present");
        /// <summary>
        ///     BarCodeScanner: Beeper State Usage.
        /// </summary>
        public static readonly Usage BeeperState = Instance.Create(0x0058, "Beeper State");
        /// <summary>
        ///     BarCodeScanner: Laser On Time Usage.
        /// </summary>
        public static readonly Usage LaserOnTime = Instance.Create(0x0059, "Laser On Time");
        /// <summary>
        ///     BarCodeScanner: Laser State Usage.
        /// </summary>
        public static readonly Usage LaserState = Instance.Create(0x005a, "Laser State");
        /// <summary>
        ///     BarCodeScanner: Lockout Time Usage.
        /// </summary>
        public static readonly Usage LockoutTime = Instance.Create(0x005b, "Lockout Time");
        /// <summary>
        ///     BarCodeScanner: Motor State Usage.
        /// </summary>
        public static readonly Usage MotorState = Instance.Create(0x005c, "Motor State");
        /// <summary>
        ///     BarCodeScanner: Motor Timeout Usage.
        /// </summary>
        public static readonly Usage MotorTimeout = Instance.Create(0x005d, "Motor Timeout");
        /// <summary>
        ///     BarCodeScanner: Power On Reset Scanner Usage.
        /// </summary>
        public static readonly Usage PowerOnResetScanner = Instance.Create(0x005e, "Power On Reset Scanner");
        /// <summary>
        ///     BarCodeScanner: Prevent Read of Barcodes Usage.
        /// </summary>
        public static readonly Usage PreventReadOfBarcodes = Instance.Create(0x005f, "Prevent Read of Barcodes");
        /// <summary>
        ///     BarCodeScanner: Initiate Barcode Read Usage.
        /// </summary>
        public static readonly Usage InitiateBarcodeRead = Instance.Create(0x0060, "Initiate Barcode Read");
        /// <summary>
        ///     BarCodeScanner: Trigger State Usage.
        /// </summary>
        public static readonly Usage TriggerState = Instance.Create(0x0061, "Trigger State");
        /// <summary>
        ///     BarCodeScanner: Trigger Mode Usage.
        /// </summary>
        public static readonly Usage TriggerMode = Instance.Create(0x0062, "Trigger Mode");
        /// <summary>
        ///     BarCodeScanner: Trigger Mode Blinking Laser On Usage.
        /// </summary>
        public static readonly Usage TriggerModeBlinkingLaserOn = Instance.Create(0x0063, "Trigger Mode Blinking Laser On");
        /// <summary>
        ///     BarCodeScanner: Trigger Mode Continuous Laser On Usage.
        /// </summary>
        public static readonly Usage TriggerModeContinuousLaserOn = Instance.Create(0x0064, "Trigger Mode Continuous Laser On");
        /// <summary>
        ///     BarCodeScanner: Trigger Mode Laser on while Pulled Usage.
        /// </summary>
        public static readonly Usage TriggerModeLaserOnWhilePulled = Instance.Create(0x0065, "Trigger Mode Laser on while Pulled");
        /// <summary>
        ///     BarCodeScanner: Trigger Mode Laser stays on after Trigger release Usage.
        /// </summary>
        public static readonly Usage TriggerModeLaserStaysOnAfterTriggerRelease = Instance.Create(0x0066, "Trigger Mode Laser stays on after Trigger release");

        /// <summary>
        ///     BarCodeScanner: Commit Parameters to NVM Usage.
        /// </summary>
        public static readonly Usage CommitParametersToNVM = Instance.Create(0x006d, "Commit Parameters to NVM");
        /// <summary>
        ///     BarCodeScanner: Parameter Scanning Usage.
        /// </summary>
        public static readonly Usage ParameterScanning = Instance.Create(0x006e, "Parameter Scanning");
        /// <summary>
        ///     BarCodeScanner: Parameters Changed Usage.
        /// </summary>
        public static readonly Usage ParametersChanged = Instance.Create(0x006f, "Parameters Changed");
        /// <summary>
        ///     BarCodeScanner: Set parameter default values Usage.
        /// </summary>
        public static readonly Usage SetParameterDefaultValues = Instance.Create(0x0070, "Set parameter default values");

        /// <summary>
        ///     BarCodeScanner: Scanner In Cradle Usage.
        /// </summary>
        public static readonly Usage ScannerInCradle = Instance.Create(0x0075, "Scanner In Cradle");
        /// <summary>
        ///     BarCodeScanner: Scanner In Range Usage.
        /// </summary>
        public static readonly Usage ScannerInRange = Instance.Create(0x0076, "Scanner In Range");

        /// <summary>
        ///     BarCodeScanner: Aim Duration Usage.
        /// </summary>
        public static readonly Usage AimDuration = Instance.Create(0x007a, "Aim Duration");
        /// <summary>
        ///     BarCodeScanner: Good Read Lamp Duration Usage.
        /// </summary>
        public static readonly Usage GoodReadLampDuration = Instance.Create(0x007b, "Good Read Lamp Duration");
        /// <summary>
        ///     BarCodeScanner: Good Read Lamp Intensity Usage.
        /// </summary>
        public static readonly Usage GoodReadLampIntensity = Instance.Create(0x007c, "Good Read Lamp Intensity");
        /// <summary>
        ///     BarCodeScanner: Good Read LED Usage.
        /// </summary>
        public static readonly Usage GoodReadLED = Instance.Create(0x007d, "Good Read LED");
        /// <summary>
        ///     BarCodeScanner: Good Read Tone Frequency Usage.
        /// </summary>
        public static readonly Usage GoodReadToneFrequency = Instance.Create(0x007e, "Good Read Tone Frequency");
        /// <summary>
        ///     BarCodeScanner: Good Read Tone Length Usage.
        /// </summary>
        public static readonly Usage GoodReadToneLength = Instance.Create(0x007f, "Good Read Tone Length");
        /// <summary>
        ///     BarCodeScanner: Good Read Tone Volume Usage.
        /// </summary>
        public static readonly Usage GoodReadToneVolume = Instance.Create(0x0080, "Good Read Tone Volume");

        /// <summary>
        ///     BarCodeScanner: No Read Message Usage.
        /// </summary>
        public static readonly Usage NoReadMessage = Instance.Create(0x0082, "No Read Message");
        /// <summary>
        ///     BarCodeScanner: Not on File Volume Usage.
        /// </summary>
        public static readonly Usage NotOnFileVolume = Instance.Create(0x0083, "Not on File Volume");
        /// <summary>
        ///     BarCodeScanner: Powerup Beep Usage.
        /// </summary>
        public static readonly Usage PowerupBeep = Instance.Create(0x0084, "Powerup Beep");
        /// <summary>
        ///     BarCodeScanner: Sound Error Beep Usage.
        /// </summary>
        public static readonly Usage SoundErrorBeep = Instance.Create(0x0085, "Sound Error Beep");
        /// <summary>
        ///     BarCodeScanner: Sound Good Read Beep Usage.
        /// </summary>
        public static readonly Usage SoundGoodReadBeep = Instance.Create(0x0086, "Sound Good Read Beep");
        /// <summary>
        ///     BarCodeScanner: Sound Not On File Beep Usage.
        /// </summary>
        public static readonly Usage SoundNotOnFileBeep = Instance.Create(0x0087, "Sound Not On File Beep");
        /// <summary>
        ///     BarCodeScanner: Good Read When to Write Usage.
        /// </summary>
        public static readonly Usage GoodReadWhenToWrite = Instance.Create(0x0088, "Good Read When to Write");
        /// <summary>
        ///     BarCodeScanner: GRWTI After Decode Usage.
        /// </summary>
        public static readonly Usage GRWTIAfterDecode = Instance.Create(0x0089, "GRWTI After Decode");
        /// <summary>
        ///     BarCodeScanner: GRWTI Beep/Lamp after transmit Usage.
        /// </summary>
        public static readonly Usage GRWTIBeepLampAfterTransmit = Instance.Create(0x008a, "GRWTI Beep/Lamp after transmit");
        /// <summary>
        ///     BarCodeScanner: GRWTI No Beep/Lamp use at all Usage.
        /// </summary>
        public static readonly Usage GRWTINoBeepLampUseAtAll = Instance.Create(0x008b, "GRWTI No Beep/Lamp use at all");

        /// <summary>
        ///     BarCodeScanner: Bookland EAN Usage.
        /// </summary>
        public static readonly Usage BooklandEAN = Instance.Create(0x0091, "Bookland EAN");
        /// <summary>
        ///     BarCodeScanner: Convert EAN 8 to 13 Type Usage.
        /// </summary>
        public static readonly Usage ConvertEAN8To13Type = Instance.Create(0x0092, "Convert EAN 8 to 13 Type");
        /// <summary>
        ///     BarCodeScanner: Convert UPC A to EAN-13 Usage.
        /// </summary>
        public static readonly Usage ConvertUPCAToEAN13 = Instance.Create(0x0093, "Convert UPC A to EAN-13");
        /// <summary>
        ///     BarCodeScanner: Convert UPC-E to A Usage.
        /// </summary>
        public static readonly Usage ConvertUPCEToA = Instance.Create(0x0094, "Convert UPC-E to A");

        /// <summary>
        ///     BarCodeScanner: EAN-13 Usage.
        /// </summary>
        public static readonly Usage EAN13 = Instance.Create(0x0095, "EAN-13");
        /// <summary>
        ///     BarCodeScanner: EAN-8 Usage.
        /// </summary>
        public static readonly Usage EAN8 = Instance.Create(0x0096, "EAN-8");
        /// <summary>
        ///     BarCodeScanner: EAN-99 128_Mandatory Usage.
        /// </summary>
        public static readonly Usage EAN99128_Mandatory = Instance.Create(0x0097, "EAN-99 128_Mandatory");
        /// <summary>
        ///     BarCodeScanner: EAN-99 P5/128_Optional Usage.
        /// </summary>
        public static readonly Usage EAN99P5128_Optional = Instance.Create(0x0098, "EAN-99 P5/128_Optional");

        /// <summary>
        ///     BarCodeScanner: UPC/EAN Usage.
        /// </summary>
        public static readonly Usage UPCEAN = Instance.Create(0x009a, "UPC/EAN");
        /// <summary>
        ///     BarCodeScanner: UPC/EAN Coupon Code Usage.
        /// </summary>
        public static readonly Usage UPCEANCouponCode = Instance.Create(0x009b, "UPC/EAN Coupon Code");
        /// <summary>
        ///     BarCodeScanner: UPC/EAN Periodicals Usage.
        /// </summary>
        public static readonly Usage UPCEANPeriodicals = Instance.Create(0x009c, "UPC/EAN Periodicals");
        /// <summary>
        ///     BarCodeScanner: UPC-A Usage.
        /// </summary>
        public static readonly Usage UPCA = Instance.Create(0x009d, "UPC-A");
        /// <summary>
        ///     BarCodeScanner: UPC-A with 128 Mandatory Usage.
        /// </summary>
        public static readonly Usage UPCAWith128Mandatory = Instance.Create(0x009e, "UPC-A with 128 Mandatory");
        /// <summary>
        ///     BarCodeScanner: UPC-A with 128 Optional Usage.
        /// </summary>
        public static readonly Usage UPCAWith128Optional = Instance.Create(0x009f, "UPC-A with 128 Optional");
        /// <summary>
        ///     BarCodeScanner: UPC-A with P5 Optional Usage.
        /// </summary>
        public static readonly Usage UPCAWithP5Optional = Instance.Create(0x00a0, "UPC-A with P5 Optional");
        /// <summary>
        ///     BarCodeScanner: UPC-E Usage.
        /// </summary>
        public static readonly Usage UPCE = Instance.Create(0x00a1, "UPC-E");
        /// <summary>
        ///     BarCodeScanner: UPC-E1 Usage.
        /// </summary>
        public static readonly Usage UPCE1 = Instance.Create(0x00a2, "UPC-E1");

        /// <summary>
        ///     BarCodeScanner: Periodical Usage.
        /// </summary>
        public static readonly Usage Periodical = Instance.Create(0x00a9, "Periodical");
        /// <summary>
        ///     BarCodeScanner: Periodical Auto-Discriminate + 2 Usage.
        /// </summary>
        public static readonly Usage PeriodicalAutoDiscriminate2 = Instance.Create(0x00aa, "Periodical Auto-Discriminate + 2");
        /// <summary>
        ///     BarCodeScanner: Periodical Only Decode with + 2 Usage.
        /// </summary>
        public static readonly Usage PeriodicalOnlyDecodeWith2 = Instance.Create(0x00ab, "Periodical Only Decode with + 2");
        /// <summary>
        ///     BarCodeScanner: Periodical Ignore + 2 Usage.
        /// </summary>
        public static readonly Usage PeriodicalIgnore2 = Instance.Create(0x00ac, "Periodical Ignore + 2");
        /// <summary>
        ///     BarCodeScanner: Periodical Auto-Discriminate + 5 Usage.
        /// </summary>
        public static readonly Usage PeriodicalAutoDiscriminate5 = Instance.Create(0x00ad, "Periodical Auto-Discriminate + 5");
        /// <summary>
        ///     BarCodeScanner: Periodical Only Decode with + 5 Usage.
        /// </summary>
        public static readonly Usage PeriodicalOnlyDecodeWith5 = Instance.Create(0x00ae, "Periodical Only Decode with + 5");
        /// <summary>
        ///     BarCodeScanner: Periodical Ignore + 5 Usage.
        /// </summary>
        public static readonly Usage PeriodicalIgnore5 = Instance.Create(0x00af, "Periodical Ignore + 5");

        /// <summary>
        ///     BarCodeScanner: Check Usage.
        /// </summary>
        public static readonly Usage Check = Instance.Create(0x00b0, "Check");
        /// <summary>
        ///     BarCodeScanner: Check Disable Price Usage.
        /// </summary>
        public static readonly Usage CheckDisablePrice = Instance.Create(0x00b1, "Check Disable Price");
        /// <summary>
        ///     BarCodeScanner: Check Enable 4 digit Price Usage.
        /// </summary>
        public static readonly Usage CheckEnable4DigitPrice = Instance.Create(0x00b2, "Check Enable 4 digit Price");
        /// <summary>
        ///     BarCodeScanner: Check Enable 5 digit Price Usage.
        /// </summary>
        public static readonly Usage CheckEnable5DigitPrice = Instance.Create(0x00b3, "Check Enable 5 digit Price");
        /// <summary>
        ///     BarCodeScanner: Check Enable European 4 digit Price Usage.
        /// </summary>
        public static readonly Usage CheckEnableEuropean4DigitPrice = Instance.Create(0x00b4, "Check Enable European 4 digit Price");
        /// <summary>
        ///     BarCodeScanner: Check Enable European 5 digit Price Usage.
        /// </summary>
        public static readonly Usage CheckEnableEuropean5DigitPrice = Instance.Create(0x00b5, "Check Enable European 5 digit Price");

        /// <summary>
        ///     BarCodeScanner: EAN Two Label Usage.
        /// </summary>
        public static readonly Usage EANTwoLabel = Instance.Create(0x00b7, "EAN Two Label");
        /// <summary>
        ///     BarCodeScanner: EAN Three Label Usage.
        /// </summary>
        public static readonly Usage EANThreeLabel = Instance.Create(0x00b8, "EAN Three Label");
        /// <summary>
        ///     BarCodeScanner: EAN 8 Flag Digit 1 Usage.
        /// </summary>
        public static readonly Usage EAN8FlagDigit1 = Instance.Create(0x00b9, "EAN 8 Flag Digit 1");
        /// <summary>
        ///     BarCodeScanner: EAN 8 Flag Digit 2 Usage.
        /// </summary>
        public static readonly Usage EAN8FlagDigit2 = Instance.Create(0x00ba, "EAN 8 Flag Digit 2");
        /// <summary>
        ///     BarCodeScanner: EAN 8 Flag Digit 3 Usage.
        /// </summary>
        public static readonly Usage EAN8FlagDigit3 = Instance.Create(0x00bb, "EAN 8 Flag Digit 3");
        /// <summary>
        ///     BarCodeScanner: EAN 13 Flag Digit 1 Usage.
        /// </summary>
        public static readonly Usage EAN13FlagDigit1 = Instance.Create(0x00bc, "EAN 13 Flag Digit 1");
        /// <summary>
        ///     BarCodeScanner: EAN 13 Flag Digit 2 Usage.
        /// </summary>
        public static readonly Usage EAN13FlagDigit2 = Instance.Create(0x00bd, "EAN 13 Flag Digit 2");
        /// <summary>
        ///     BarCodeScanner: EAN 13 Flag Digit 3 Usage.
        /// </summary>
        public static readonly Usage EAN13FlagDigit3 = Instance.Create(0x00be, "EAN 13 Flag Digit 3");
        /// <summary>
        ///     BarCodeScanner: Add EAN 2/3 Label Definition Usage.
        /// </summary>
        public static readonly Usage AddEAN23LabelDefinition = Instance.Create(0x00bf, "Add EAN 2/3 Label Definition");
        /// <summary>
        ///     BarCodeScanner: Clear all EAN 2/3 Label Definitions Usage.
        /// </summary>
        public static readonly Usage ClearAllEAN23LabelDefinitions = Instance.Create(0x00c0, "Clear all EAN 2/3 Label Definitions");

        /// <summary>
        ///     BarCodeScanner: Codabar Usage.
        /// </summary>
        public static readonly Usage Codabar = Instance.Create(0x00c3, "Codabar");
        /// <summary>
        ///     BarCodeScanner: Code 128 Usage.
        /// </summary>
        public static readonly Usage Code128 = Instance.Create(0x00c4, "Code 128");

        /// <summary>
        ///     BarCodeScanner: Code 39 Usage.
        /// </summary>
        public static readonly Usage Code39 = Instance.Create(0x00c7, "Code 39");
        /// <summary>
        ///     BarCodeScanner: Code 93 Usage.
        /// </summary>
        public static readonly Usage Code93 = Instance.Create(0x00c8, "Code 93");
        /// <summary>
        ///     BarCodeScanner: Full ASCII Conversion Usage.
        /// </summary>
        public static readonly Usage FullASCIIConversion = Instance.Create(0x00c9, "Full ASCII Conversion");
        /// <summary>
        ///     BarCodeScanner: Interleaved 2 of 5 Usage.
        /// </summary>
        public static readonly Usage Interleaved2Of5 = Instance.Create(0x00ca, "Interleaved 2 of 5");
        /// <summary>
        ///     BarCodeScanner: Italian Pharmacy Code Usage.
        /// </summary>
        public static readonly Usage ItalianPharmacyCode = Instance.Create(0x00cb, "Italian Pharmacy Code");
        /// <summary>
        ///     BarCodeScanner: MSI/Plessey Usage.
        /// </summary>
        public static readonly Usage MSIPlessey = Instance.Create(0x00cc, "MSI/Plessey");
        /// <summary>
        ///     BarCodeScanner: Standard 2 of 5 IATA Usage.
        /// </summary>
        public static readonly Usage Standard2Of5IATA = Instance.Create(0x00cd, "Standard 2 of 5 IATA");
        /// <summary>
        ///     BarCodeScanner: Standard 2 of 5 Usage.
        /// </summary>
        public static readonly Usage Standard2Of5 = Instance.Create(0x00ce, "Standard 2 of 5");

        /// <summary>
        ///     BarCodeScanner: Transmit Start/Stop Usage.
        /// </summary>
        public static readonly Usage TransmitStartStop = Instance.Create(0x00d3, "Transmit Start/Stop");
        /// <summary>
        ///     BarCodeScanner: Tri-Optic Usage.
        /// </summary>
        public static readonly Usage TriOptic = Instance.Create(0x00d4, "Tri-Optic");
        /// <summary>
        ///     BarCodeScanner: UCC/EAN-128 Usage.
        /// </summary>
        public static readonly Usage UCCEAN128 = Instance.Create(0x00d5, "UCC/EAN-128");
        /// <summary>
        ///     BarCodeScanner: Check Digit Usage.
        /// </summary>
        public static readonly Usage CheckDigit = Instance.Create(0x00d6, "Check Digit");
        /// <summary>
        ///     BarCodeScanner: Check Digit Disable Usage.
        /// </summary>
        public static readonly Usage CheckDigitDisable = Instance.Create(0x00d7, "Check Digit Disable");
        /// <summary>
        ///     BarCodeScanner: Check Digit Enable Interleaved 2 of 5 OPCC Usage.
        /// </summary>
        public static readonly Usage CheckDigitEnableInterleaved2Of5OPCC = Instance.Create(0x00d8, "Check Digit Enable Interleaved 2 of 5 OPCC");
        /// <summary>
        ///     BarCodeScanner: Check Digit Enable Interleaved 2 of 5 USS Usage.
        /// </summary>
        public static readonly Usage CheckDigitEnableInterleaved2Of5USS = Instance.Create(0x00d9, "Check Digit Enable Interleaved 2 of 5 USS");
        /// <summary>
        ///     BarCodeScanner: Check Digit Enable Standard 2 of 5 OPCC Usage.
        /// </summary>
        public static readonly Usage CheckDigitEnableStandard2Of5OPCC = Instance.Create(0x00da, "Check Digit Enable Standard 2 of 5 OPCC");
        /// <summary>
        ///     BarCodeScanner: Check Digit Enable Standard 2 of 5 USS Usage.
        /// </summary>
        public static readonly Usage CheckDigitEnableStandard2Of5USS = Instance.Create(0x00db, "Check Digit Enable Standard 2 of 5 USS");
        /// <summary>
        ///     BarCodeScanner: Check Digit Enable One MSI Plessey Usage.
        /// </summary>
        public static readonly Usage CheckDigitEnableOneMSIPlessey = Instance.Create(0x00dc, "Check Digit Enable One MSI Plessey");
        /// <summary>
        ///     BarCodeScanner: Check Digit Enable Two MSI Plessey Usage.
        /// </summary>
        public static readonly Usage CheckDigitEnableTwoMSIPlessey = Instance.Create(0x00dd, "Check Digit Enable Two MSI Plessey");
        /// <summary>
        ///     BarCodeScanner: Check Digit Codabar Enable Usage.
        /// </summary>
        public static readonly Usage CheckDigitCodabarEnable = Instance.Create(0x00de, "Check Digit Codabar Enable");
        /// <summary>
        ///     BarCodeScanner: Check Digit Code 39 Enable Usage.
        /// </summary>
        public static readonly Usage CheckDigitCode39Enable = Instance.Create(0x00df, "Check Digit Code 39 Enable");

        /// <summary>
        ///     BarCodeScanner: Transmit Check Digit Usage.
        /// </summary>
        public static readonly Usage TransmitCheckDigit = Instance.Create(0x00f0, "Transmit Check Digit");
        /// <summary>
        ///     BarCodeScanner: Disable Check Digit Transmit Usage.
        /// </summary>
        public static readonly Usage DisableCheckDigitTransmit = Instance.Create(0x00f1, "Disable Check Digit Transmit");
        /// <summary>
        ///     BarCodeScanner: Enable Check Digit Transmit Usage.
        /// </summary>
        public static readonly Usage EnableCheckDigitTransmit = Instance.Create(0x00f2, "Enable Check Digit Transmit");

        /// <summary>
        ///     BarCodeScanner: Symbology Identifier Usage.
        /// </summary>
        public static readonly Usage SymbologyIdentifier = Instance.Create(0x00fb, "Symbology Identifier");
        /// <summary>
        ///     BarCodeScanner: Symbology Identifier Usage.
        /// </summary>
        public static readonly Usage SymbologyIdentifier2 = Instance.Create(0x00fc, "Symbology Identifier");
        /// <summary>
        ///     BarCodeScanner: Symbology Identifier Usage.
        /// </summary>
        public static readonly Usage SymbologyIdentifier3 = Instance.Create(0x00fd, "Symbology Identifier");
        /// <summary>
        ///     BarCodeScanner: Decoded Data Usage.
        /// </summary>
        public static readonly Usage DecodedData = Instance.Create(0x00fe, "Decoded Data");
        /// <summary>
        ///     BarCodeScanner: Decode Data Continued Usage.
        /// </summary>
        public static readonly Usage DecodeDataContinued = Instance.Create(0x00ff, "Decode Data Continued");
        /// <summary>
        ///     BarCodeScanner: Bar Space Data Usage.
        /// </summary>
        public static readonly Usage BarSpaceData = Instance.Create(0x0100, "Bar Space Data");
        /// <summary>
        ///     BarCodeScanner: Scanner Data Accuracy Usage.
        /// </summary>
        public static readonly Usage ScannerDataAccuracy = Instance.Create(0x0101, "Scanner Data Accuracy");
        /// <summary>
        ///     BarCodeScanner: Raw Data Polarity Usage.
        /// </summary>
        public static readonly Usage RawDataPolarity = Instance.Create(0x0102, "Raw Data Polarity");
        /// <summary>
        ///     BarCodeScanner: Polarity Inverted Bar Code Usage.
        /// </summary>
        public static readonly Usage PolarityInvertedBarCode = Instance.Create(0x0103, "Polarity Inverted Bar Code");
        /// <summary>
        ///     BarCodeScanner: Polarity Normal Bar Code Usage.
        /// </summary>
        public static readonly Usage PolarityNormalBarCode = Instance.Create(0x0104, "Polarity Normal Bar Code");

        /// <summary>
        ///     BarCodeScanner: Minimum Length to Decode Usage.
        /// </summary>
        public static readonly Usage MinimumLengthToDecode = Instance.Create(0x0106, "Minimum Length to Decode");
        /// <summary>
        ///     BarCodeScanner: Maximum Length to Decode Usage.
        /// </summary>
        public static readonly Usage MaximumLengthToDecode = Instance.Create(0x0107, "Maximum Length to Decode");
        /// <summary>
        ///     BarCodeScanner: First Discrete Length to Decode Usage.
        /// </summary>
        public static readonly Usage FirstDiscreteLengthToDecode = Instance.Create(0x0108, "First Discrete Length to Decode");
        /// <summary>
        ///     BarCodeScanner: Second Discrete Length to Decode Usage.
        /// </summary>
        public static readonly Usage SecondDiscreteLengthToDecode = Instance.Create(0x0109, "Second Discrete Length to Decode");
        /// <summary>
        ///     BarCodeScanner: Data Length Method Usage.
        /// </summary>
        public static readonly Usage DataLengthMethod = Instance.Create(0x010a, "Data Length Method");
        /// <summary>
        ///     BarCodeScanner: DL Method Read any Usage.
        /// </summary>
        public static readonly Usage DLMethodReadAny = Instance.Create(0x010b, "DL Method Read any");
        /// <summary>
        ///     BarCodeScanner: DL Method Check in Range Usage.
        /// </summary>
        public static readonly Usage DLMethodCheckInRange = Instance.Create(0x010c, "DL Method Check in Range");
        /// <summary>
        ///     BarCodeScanner: DL Method Check for Discrete Usage.
        /// </summary>
        public static readonly Usage DLMethodCheckForDiscrete = Instance.Create(0x010d, "DL Method Check for Discrete");

        /// <summary>
        ///     BarCodeScanner: Aztec Code Usage.
        /// </summary>
        public static readonly Usage AztecCode = Instance.Create(0x0110, "Aztec Code");
        /// <summary>
        ///     BarCodeScanner: BC412 Usage.
        /// </summary>
        public static readonly Usage BC412 = Instance.Create(0x0111, "BC412");
        /// <summary>
        ///     BarCodeScanner: Channel Code Usage.
        /// </summary>
        public static readonly Usage ChannelCode = Instance.Create(0x0112, "Channel Code");
        /// <summary>
        ///     BarCodeScanner: Code 16 Usage.
        /// </summary>
        public static readonly Usage Code16 = Instance.Create(0x0113, "Code 16");
        /// <summary>
        ///     BarCodeScanner: Code 32 Usage.
        /// </summary>
        public static readonly Usage Code32 = Instance.Create(0x0114, "Code 32");
        /// <summary>
        ///     BarCodeScanner: Code 49 Usage.
        /// </summary>
        public static readonly Usage Code49 = Instance.Create(0x0115, "Code 49");
        /// <summary>
        ///     BarCodeScanner: Code One Usage.
        /// </summary>
        public static readonly Usage CodeOne = Instance.Create(0x0116, "Code One");
        /// <summary>
        ///     BarCodeScanner: Colorcode Usage.
        /// </summary>
        public static readonly Usage Colorcode = Instance.Create(0x0117, "Colorcode");
        /// <summary>
        ///     BarCodeScanner: Data Matrix Usage.
        /// </summary>
        public static readonly Usage DataMatrix = Instance.Create(0x0118, "Data Matrix");
        /// <summary>
        ///     BarCodeScanner: MaxiCode Usage.
        /// </summary>
        public static readonly Usage MaxiCode = Instance.Create(0x0119, "MaxiCode");
        /// <summary>
        ///     BarCodeScanner: MicroPDF Usage.
        /// </summary>
        public static readonly Usage MicroPDF = Instance.Create(0x011a, "MicroPDF");
        /// <summary>
        ///     BarCodeScanner: PDF-417 Usage.
        /// </summary>
        public static readonly Usage PDF417 = Instance.Create(0x011b, "PDF-417");
        /// <summary>
        ///     BarCodeScanner: PosiCode Usage.
        /// </summary>
        public static readonly Usage PosiCode = Instance.Create(0x011c, "PosiCode");
        /// <summary>
        ///     BarCodeScanner: QR Code Usage.
        /// </summary>
        public static readonly Usage QRCode = Instance.Create(0x011d, "QR Code");
        /// <summary>
        ///     BarCodeScanner: SuperCode Usage.
        /// </summary>
        public static readonly Usage SuperCode = Instance.Create(0x011e, "SuperCode");
        /// <summary>
        ///     BarCodeScanner: UltraCode Usage.
        /// </summary>
        public static readonly Usage UltraCode = Instance.Create(0x011f, "UltraCode");
        /// <summary>
        ///     BarCodeScanner: USD-5 (Slug Code) Usage.
        /// </summary>
        public static readonly Usage USD5SlugCode = Instance.Create(0x0120, "USD-5 (Slug Code)");
        /// <summary>
        ///     BarCodeScanner: VeriCode Usage.
        /// </summary>
        public static readonly Usage VeriCode = Instance.Create(0x0121, "VeriCode");

        /// <summary>
        ///     BarCodeScanner: Undefined Usage.
        /// </summary>
        public static readonly Usage Undefined = Instance.Create(0x0000, "Undefined");

        /// <inheritdoc />
        private BarCodeScannerPage(ushort id, string name) : base(id, name, true)
        {
        }
    }

    /// <summary>
    ///     Class defining the Weighing Devices usage page.
    /// </summary>
    public sealed partial class WeighingDevicesPage : UsagePage
    {
        /// <summary>
        ///     The singleton instance of WeighingDevicesPage.
        /// </summary>
        public static readonly WeighingDevicesPage Instance = new WeighingDevicesPage(0x008d, "Weighing Devices");

        /// <summary>
        ///     WeighingDevices: Weighing Device Usage.
        /// </summary>
        public static readonly Usage WeighingDevice = Instance.Create(0x0001, "Weighing Device");

        /// <summary>
        ///     WeighingDevices: Scale Device Usage.
        /// </summary>
        public static readonly Usage ScaleDevice = Instance.Create(0x0020, "Scale Device");
        /// <summary>
        ///     WeighingDevices: Scale Class I Metric Usage.
        /// </summary>
        public static readonly Usage ScaleClassIMetric = Instance.Create(0x0021, "Scale Class I Metric");
        /// <summary>
        ///     WeighingDevices: Scale Class I Metric Usage.
        /// </summary>
        public static readonly Usage ScaleClassIMetric2 = Instance.Create(0x0022, "Scale Class I Metric");
        /// <summary>
        ///     WeighingDevices: Scale Class II Metric Usage.
        /// </summary>
        public static readonly Usage ScaleClassIIMetric = Instance.Create(0x0023, "Scale Class II Metric");
        /// <summary>
        ///     WeighingDevices: Scale Class III Metric Usage.
        /// </summary>
        public static readonly Usage ScaleClassIIIMetric = Instance.Create(0x0024, "Scale Class III Metric");
        /// <summary>
        ///     WeighingDevices: Scale Class IIIL Metric Usage.
        /// </summary>
        public static readonly Usage ScaleClassIIILMetric = Instance.Create(0x0025, "Scale Class IIIL Metric");
        /// <summary>
        ///     WeighingDevices: Scale Class IV Metric Usage.
        /// </summary>
        public static readonly Usage ScaleClassIVMetric = Instance.Create(0x0026, "Scale Class IV Metric");
        /// <summary>
        ///     WeighingDevices: Scale Class III English Usage.
        /// </summary>
        public static readonly Usage ScaleClassIIIEnglish = Instance.Create(0x0027, "Scale Class III English");
        /// <summary>
        ///     WeighingDevices: Scale Class IIIL English Usage.
        /// </summary>
        public static readonly Usage ScaleClassIIILEnglish = Instance.Create(0x0028, "Scale Class IIIL English");
        /// <summary>
        ///     WeighingDevices: Scale Class IV English Usage.
        /// </summary>
        public static readonly Usage ScaleClassIVEnglish = Instance.Create(0x0029, "Scale Class IV English");
        /// <summary>
        ///     WeighingDevices: Scale Class Generic Usage.
        /// </summary>
        public static readonly Usage ScaleClassGeneric = Instance.Create(0x002a, "Scale Class Generic");

        /// <summary>
        ///     WeighingDevices: Scale Attribute Report Usage.
        /// </summary>
        public static readonly Usage ScaleAttributeReport = Instance.Create(0x0030, "Scale Attribute Report");
        /// <summary>
        ///     WeighingDevices: Scale Control Report Usage.
        /// </summary>
        public static readonly Usage ScaleControlReport = Instance.Create(0x0031, "Scale Control Report");
        /// <summary>
        ///     WeighingDevices: Scale Data Report Usage.
        /// </summary>
        public static readonly Usage ScaleDataReport = Instance.Create(0x0032, "Scale Data Report");
        /// <summary>
        ///     WeighingDevices: Scale Status Report Usage.
        /// </summary>
        public static readonly Usage ScaleStatusReport = Instance.Create(0x0033, "Scale Status Report");
        /// <summary>
        ///     WeighingDevices: Scale Weight Limit Report Usage.
        /// </summary>
        public static readonly Usage ScaleWeightLimitReport = Instance.Create(0x0034, "Scale Weight Limit Report");
        /// <summary>
        ///     WeighingDevices: Scale Statistics Report Usage.
        /// </summary>
        public static readonly Usage ScaleStatisticsReport = Instance.Create(0x0035, "Scale Statistics Report");

        /// <summary>
        ///     WeighingDevices: Data Weight Usage.
        /// </summary>
        public static readonly Usage DataWeight = Instance.Create(0x0040, "Data Weight");
        /// <summary>
        ///     WeighingDevices: Data Scaling Usage.
        /// </summary>
        public static readonly Usage DataScaling = Instance.Create(0x0041, "Data Scaling");

        /// <summary>
        ///     WeighingDevices: Weight Unit Usage.
        /// </summary>
        public static readonly Usage WeightUnit = Instance.Create(0x0050, "Weight Unit");
        /// <summary>
        ///     WeighingDevices: Weight Unit Milligram Usage.
        /// </summary>
        public static readonly Usage WeightUnitMilligram = Instance.Create(0x0051, "Weight Unit Milligram");
        /// <summary>
        ///     WeighingDevices: Weight Unit Gram Usage.
        /// </summary>
        public static readonly Usage WeightUnitGram = Instance.Create(0x0052, "Weight Unit Gram");
        /// <summary>
        ///     WeighingDevices: Weight Unit Kilogram Usage.
        /// </summary>
        public static readonly Usage WeightUnitKilogram = Instance.Create(0x0053, "Weight Unit Kilogram");
        /// <summary>
        ///     WeighingDevices: Weight Unit Carats Usage.
        /// </summary>
        public static readonly Usage WeightUnitCarats = Instance.Create(0x0054, "Weight Unit Carats");
        /// <summary>
        ///     WeighingDevices: Weight Unit Taels Usage.
        /// </summary>
        public static readonly Usage WeightUnitTaels = Instance.Create(0x0055, "Weight Unit Taels");
        /// <summary>
        ///     WeighingDevices: Weight Unit Grains Usage.
        /// </summary>
        public static readonly Usage WeightUnitGrains = Instance.Create(0x0056, "Weight Unit Grains");
        /// <summary>
        ///     WeighingDevices: Weight Unit Pennyweights Usage.
        /// </summary>
        public static readonly Usage WeightUnitPennyweights = Instance.Create(0x0057, "Weight Unit Pennyweights");
        /// <summary>
        ///     WeighingDevices: Weight Unit Metric Ton Usage.
        /// </summary>
        public static readonly Usage WeightUnitMetricTon = Instance.Create(0x0058, "Weight Unit Metric Ton");
        /// <summary>
        ///     WeighingDevices: Weight Unit Avoir Ton Usage.
        /// </summary>
        public static readonly Usage WeightUnitAvoirTon = Instance.Create(0x0059, "Weight Unit Avoir Ton");
        /// <summary>
        ///     WeighingDevices: Weight Unit Troy Ounce Usage.
        /// </summary>
        public static readonly Usage WeightUnitTroyOunce = Instance.Create(0x005a, "Weight Unit Troy Ounce");
        /// <summary>
        ///     WeighingDevices: Weight Unit Ounce Usage.
        /// </summary>
        public static readonly Usage WeightUnitOunce = Instance.Create(0x005b, "Weight Unit Ounce");
        /// <summary>
        ///     WeighingDevices: Weight Unit Pound Usage.
        /// </summary>
        public static readonly Usage WeightUnitPound = Instance.Create(0x005c, "Weight Unit Pound");

        /// <summary>
        ///     WeighingDevices: Calibration Count Usage.
        /// </summary>
        public static readonly Usage CalibrationCount = Instance.Create(0x0060, "Calibration Count");
        /// <summary>
        ///     WeighingDevices: Re-Zero Count Usage.
        /// </summary>
        public static readonly Usage ReZeroCount = Instance.Create(0x0061, "Re-Zero Count");

        /// <summary>
        ///     WeighingDevices: Scale Status Usage.
        /// </summary>
        public static readonly Usage ScaleStatus = Instance.Create(0x0070, "Scale Status");
        /// <summary>
        ///     WeighingDevices: Scale Status Fault Usage.
        /// </summary>
        public static readonly Usage ScaleStatusFault = Instance.Create(0x0071, "Scale Status Fault");
        /// <summary>
        ///     WeighingDevices: Scale Status Stable at Center of Zero Usage.
        /// </summary>
        public static readonly Usage ScaleStatusStableAtCenterOfZero = Instance.Create(0x0072, "Scale Status Stable at Center of Zero");
        /// <summary>
        ///     WeighingDevices: Scale Status In Motion Usage.
        /// </summary>
        public static readonly Usage ScaleStatusInMotion = Instance.Create(0x0073, "Scale Status In Motion");
        /// <summary>
        ///     WeighingDevices: Scale Status Weight Stable Usage.
        /// </summary>
        public static readonly Usage ScaleStatusWeightStable = Instance.Create(0x0074, "Scale Status Weight Stable");
        /// <summary>
        ///     WeighingDevices: Scale Status Under Zero Usage.
        /// </summary>
        public static readonly Usage ScaleStatusUnderZero = Instance.Create(0x0075, "Scale Status Under Zero");
        /// <summary>
        ///     WeighingDevices: Scale Status Over Weight Limit Usage.
        /// </summary>
        public static readonly Usage ScaleStatusOverWeightLimit = Instance.Create(0x0076, "Scale Status Over Weight Limit");
        /// <summary>
        ///     WeighingDevices: Scale Status Requires Calibration Usage.
        /// </summary>
        public static readonly Usage ScaleStatusRequiresCalibration = Instance.Create(0x0077, "Scale Status Requires Calibration");
        /// <summary>
        ///     WeighingDevices: Scale Status Requires Rezeroing Usage.
        /// </summary>
        public static readonly Usage ScaleStatusRequiresRezeroing = Instance.Create(0x0078, "Scale Status Requires Rezeroing");

        /// <summary>
        ///     WeighingDevices: Zero Scale Usage.
        /// </summary>
        public static readonly Usage ZeroScale = Instance.Create(0x0080, "Zero Scale");
        /// <summary>
        ///     WeighingDevices: Enforced Zero Return Usage.
        /// </summary>
        public static readonly Usage EnforcedZeroReturn = Instance.Create(0x0081, "Enforced Zero Return");

        /// <summary>
        ///     WeighingDevices: Undefined Usage.
        /// </summary>
        public static readonly Usage Undefined = Instance.Create(0x0000, "Undefined");

        /// <inheritdoc />
        private WeighingDevicesPage(ushort id, string name) : base(id, name, true)
        {
        }
    }

    /// <summary>
    ///     Class defining the Magnetic Stripe Reading (MSR) Devices usage page.
    /// </summary>
    public sealed partial class MagneticStripeReadingMSRDevicesPage : UsagePage
    {
        /// <summary>
        ///     The singleton instance of MagneticStripeReadingMSRDevicesPage.
        /// </summary>
        public static readonly MagneticStripeReadingMSRDevicesPage Instance = new MagneticStripeReadingMSRDevicesPage(0x008e, "Magnetic Stripe Reading (MSR) Devices");

        /// <summary>
        ///     MagneticStripeReadingMSRDevices: MSR Device Read-Only Usage.
        /// </summary>
        public static readonly Usage MSRDeviceReadOnly = Instance.Create(0x0001, "MSR Device Read-Only");

        /// <summary>
        ///     MagneticStripeReadingMSRDevices: Track 1 Length Usage.
        /// </summary>
        public static readonly Usage Track1Length = Instance.Create(0x0011, "Track 1 Length");
        /// <summary>
        ///     MagneticStripeReadingMSRDevices: Track 2 Length Usage.
        /// </summary>
        public static readonly Usage Track2Length = Instance.Create(0x0012, "Track 2 Length");
        /// <summary>
        ///     MagneticStripeReadingMSRDevices: Track 3 Length Usage.
        /// </summary>
        public static readonly Usage Track3Length = Instance.Create(0x0013, "Track 3 Length");
        /// <summary>
        ///     MagneticStripeReadingMSRDevices: Track JIS Length Usage.
        /// </summary>
        public static readonly Usage TrackJISLength = Instance.Create(0x0014, "Track JIS Length");

        /// <summary>
        ///     MagneticStripeReadingMSRDevices: Track Data Usage.
        /// </summary>
        public static readonly Usage TrackData = Instance.Create(0x0020, "Track Data");
        /// <summary>
        ///     MagneticStripeReadingMSRDevices: Track 1 Data Usage.
        /// </summary>
        public static readonly Usage Track1Data = Instance.Create(0x0021, "Track 1 Data");
        /// <summary>
        ///     MagneticStripeReadingMSRDevices: Track 2 Data Usage.
        /// </summary>
        public static readonly Usage Track2Data = Instance.Create(0x0022, "Track 2 Data");
        /// <summary>
        ///     MagneticStripeReadingMSRDevices: Track 3 Data Usage.
        /// </summary>
        public static readonly Usage Track3Data = Instance.Create(0x0023, "Track 3 Data");
        /// <summary>
        ///     MagneticStripeReadingMSRDevices: Track JIS Data Usage.
        /// </summary>
        public static readonly Usage TrackJISData = Instance.Create(0x0024, "Track JIS Data");

        /// <summary>
        ///     MagneticStripeReadingMSRDevices: Undefined Usage.
        /// </summary>
        public static readonly Usage Undefined = Instance.Create(0x0000, "Undefined");

        /// <inheritdoc />
        private MagneticStripeReadingMSRDevicesPage(ushort id, string name) : base(id, name, true)
        {
        }
    }

    /// <summary>
    ///     Class defining the Reserved Point of Sale usage page.
    /// </summary>
    public sealed partial class ReservedPointOfSalePage : UsagePage
    {
        /// <summary>
        ///     The singleton instance of ReservedPointOfSalePage.
        /// </summary>
        public static readonly ReservedPointOfSalePage Instance = new ReservedPointOfSalePage(0x008f, "Reserved Point of Sale");

        /// <summary>
        ///     ReservedPointOfSale: Undefined Usage.
        /// </summary>
        public static readonly Usage Undefined = Instance.Create(0x0000, "Undefined");

        /// <inheritdoc />
        private ReservedPointOfSalePage(ushort id, string name) : base(id, name, true)
        {
        }
    }

    /// <summary>
    ///     Class defining the Camera Control usage page.
    /// </summary>
    public sealed partial class CameraControlPage : UsagePage
    {
        /// <summary>
        ///     The singleton instance of CameraControlPage.
        /// </summary>
        public static readonly CameraControlPage Instance = new CameraControlPage(0x0090, "Camera Control");

        /// <summary>
        ///     CameraControl: Camera Auto-focus Usage.
        /// </summary>
        public static readonly Usage CameraAutofocus = Instance.Create(0x0020, "Camera Auto-focus");
        /// <summary>
        ///     CameraControl: Camera Shutter Usage.
        /// </summary>
        public static readonly Usage CameraShutter = Instance.Create(0x0021, "Camera Shutter");

        /// <summary>
        ///     CameraControl: Undefined Usage.
        /// </summary>
        public static readonly Usage Undefined = Instance.Create(0x0000, "Undefined");

        /// <inheritdoc />
        private CameraControlPage(ushort id, string name) : base(id, name, true)
        {
        }
    }

    /// <summary>
    ///     Class defining the Arcade usage page.
    /// </summary>
    public sealed partial class ArcadePage : UsagePage
    {
        /// <summary>
        ///     The singleton instance of ArcadePage.
        /// </summary>
        public static readonly ArcadePage Instance = new ArcadePage(0x0091, "Arcade");

        /// <summary>
        ///     Arcade: General Purpose IO Card Usage.
        /// </summary>
        public static readonly Usage GeneralPurposeIOCard = Instance.Create(0x0001, "General Purpose IO Card");
        /// <summary>
        ///     Arcade: Coin Door Usage.
        /// </summary>
        public static readonly Usage CoinDoor = Instance.Create(0x0002, "Coin Door");
        /// <summary>
        ///     Arcade: Watchdog Timer Usage.
        /// </summary>
        public static readonly Usage WatchdogTimer = Instance.Create(0x0003, "Watchdog Timer");

        /// <summary>
        ///     Arcade: General Purpose Analog Input State Usage.
        /// </summary>
        public static readonly Usage GeneralPurposeAnalogInputState = Instance.Create(0x0030, "General Purpose Analog Input State");
        /// <summary>
        ///     Arcade: General Purpose Digital Input State Usage.
        /// </summary>
        public static readonly Usage GeneralPurposeDigitalInputState = Instance.Create(0x0031, "General Purpose Digital Input State");
        /// <summary>
        ///     Arcade: General Purpose Optical Input State Usage.
        /// </summary>
        public static readonly Usage GeneralPurposeOpticalInputState = Instance.Create(0x0032, "General Purpose Optical Input State");
        /// <summary>
        ///     Arcade: General Purpose Digital Output State Usage.
        /// </summary>
        public static readonly Usage GeneralPurposeDigitalOutputState = Instance.Create(0x0033, "General Purpose Digital Output State");
        /// <summary>
        ///     Arcade: Number of Coin Doors Usage.
        /// </summary>
        public static readonly Usage NumberOfCoinDoors = Instance.Create(0x0034, "Number of Coin Doors");
        /// <summary>
        ///     Arcade: Coin Drawer Drop Count Usage.
        /// </summary>
        public static readonly Usage CoinDrawerDropCount = Instance.Create(0x0035, "Coin Drawer Drop Count");
        /// <summary>
        ///     Arcade: Coin Drawer Start Usage.
        /// </summary>
        public static readonly Usage CoinDrawerStart = Instance.Create(0x0036, "Coin Drawer Start");
        /// <summary>
        ///     Arcade: Coin Drawer Service Usage.
        /// </summary>
        public static readonly Usage CoinDrawerService = Instance.Create(0x0037, "Coin Drawer Service");
        /// <summary>
        ///     Arcade: Coin Drawer Tilt Usage.
        /// </summary>
        public static readonly Usage CoinDrawerTilt = Instance.Create(0x0038, "Coin Drawer Tilt");
        /// <summary>
        ///     Arcade: Coin Door Test Usage.
        /// </summary>
        public static readonly Usage CoinDoorTest = Instance.Create(0x0039, "Coin Door Test");

        /// <summary>
        ///     Arcade: Coin Door Lockout Usage.
        /// </summary>
        public static readonly Usage CoinDoorLockout = Instance.Create(0x0040, "Coin Door Lockout");
        /// <summary>
        ///     Arcade: Watchdog Timeout Usage.
        /// </summary>
        public static readonly Usage WatchdogTimeout = Instance.Create(0x0041, "Watchdog Timeout");
        /// <summary>
        ///     Arcade: Watchdog Action Usage.
        /// </summary>
        public static readonly Usage WatchdogAction = Instance.Create(0x0042, "Watchdog Action");
        /// <summary>
        ///     Arcade: Watchdog Reboot Usage.
        /// </summary>
        public static readonly Usage WatchdogReboot = Instance.Create(0x0043, "Watchdog Reboot");
        /// <summary>
        ///     Arcade: Watchdog Restart Usage.
        /// </summary>
        public static readonly Usage WatchdogRestart = Instance.Create(0x0044, "Watchdog Restart");
        /// <summary>
        ///     Arcade: Alarm Input Usage.
        /// </summary>
        public static readonly Usage AlarmInput = Instance.Create(0x0045, "Alarm Input");
        /// <summary>
        ///     Arcade: Coin Door Counter Usage.
        /// </summary>
        public static readonly Usage CoinDoorCounter = Instance.Create(0x0046, "Coin Door Counter");
        /// <summary>
        ///     Arcade: I/O Direction Mapping Usage.
        /// </summary>
        public static readonly Usage IODirectionMapping = Instance.Create(0x0047, "I/O Direction Mapping");
        /// <summary>
        ///     Arcade: Set I/O Direction Usage.
        /// </summary>
        public static readonly Usage SetIODirection = Instance.Create(0x0048, "Set I/O Direction");
        /// <summary>
        ///     Arcade: Extended Optical Input State Usage.
        /// </summary>
        public static readonly Usage ExtendedOpticalInputState = Instance.Create(0x0049, "Extended Optical Input State");
        /// <summary>
        ///     Arcade: Pin Pad Input State Usage.
        /// </summary>
        public static readonly Usage PinPadInputState = Instance.Create(0x004a, "Pin Pad Input State");
        /// <summary>
        ///     Arcade: Pin Pad Status Usage.
        /// </summary>
        public static readonly Usage PinPadStatus = Instance.Create(0x004b, "Pin Pad Status");
        /// <summary>
        ///     Arcade: Pin Pad Output Usage.
        /// </summary>
        public static readonly Usage PinPadOutput = Instance.Create(0x004c, "Pin Pad Output");
        /// <summary>
        ///     Arcade: Pin Pad Command Usage.
        /// </summary>
        public static readonly Usage PinPadCommand = Instance.Create(0x004d, "Pin Pad Command");

        /// <summary>
        ///     Arcade: Undefined Usage.
        /// </summary>
        public static readonly Usage Undefined = Instance.Create(0x0000, "Undefined");

        /// <inheritdoc />
        private ArcadePage(ushort id, string name) : base(id, name, true)
        {
        }
    }

    /// <summary>
    ///     Class defining the Fast IDentity Online Alliance usage page.
    /// </summary>
    public sealed partial class FastIDentityOnlineAlliancePage : UsagePage
    {
        /// <summary>
        ///     The singleton instance of FastIDentityOnlineAlliancePage.
        /// </summary>
        public static readonly FastIDentityOnlineAlliancePage Instance = new FastIDentityOnlineAlliancePage(0xf1d0, "Fast IDentity Online Alliance");

        /// <summary>
        ///     FastIDentityOnlineAlliance: U2F Authenticator Device Usage.
        /// </summary>
        public static readonly Usage U2FAuthenticatorDevice = Instance.Create(0x0001, "U2F Authenticator Device");
        /// <summary>
        ///     FastIDentityOnlineAlliance: Input Report Data Usage.
        /// </summary>
        public static readonly Usage InputReportData = Instance.Create(0x0020, "Input Report Data");
        /// <summary>
        ///     FastIDentityOnlineAlliance: Output Report Data Usage.
        /// </summary>
        public static readonly Usage OutputReportData = Instance.Create(0x0021, "Output Report Data");

        /// <summary>
        ///     FastIDentityOnlineAlliance: Undefined Usage.
        /// </summary>
        public static readonly Usage Undefined = Instance.Create(0x0000, "Undefined");

        /// <inheritdoc />
        private FastIDentityOnlineAlliancePage(ushort id, string name) : base(id, name, true)
        {
        }
    }

}

namespace HIDControllers
{
    using System;
    using HIDControllers.Pages;

	/// <summary>
	///     Base class for all usage pages.
	/// </summary>
	public partial class UsagePage : IEquatable<UsagePage>
	{
        /// <summary>
        ///     Undefined Page
        /// </summary>
        public static readonly UndefinedPage Undefined = UndefinedPage.Instance;
        /// <summary>
        ///     Generic Desktop Controls Page
        /// </summary>
        public static readonly GenericDesktopPage GenericDesktop = GenericDesktopPage.Instance;
        /// <summary>
        ///     Simulation Controls Page
        /// </summary>
        public static readonly SimulationPage Simulation = SimulationPage.Instance;
        /// <summary>
        ///     VR Controls Page
        /// </summary>
        public static readonly VRPage VR = VRPage.Instance;
        /// <summary>
        ///     Sport Controls Page
        /// </summary>
        public static readonly SportPage Sport = SportPage.Instance;
        /// <summary>
        ///     Game Controls Page
        /// </summary>
        public static readonly GamePage Game = GamePage.Instance;
        /// <summary>
        ///     Generic Device Controls Page
        /// </summary>
        public static readonly GenericDevicePage GenericDevice = GenericDevicePage.Instance;
        /// <summary>
        ///     Keyboard/Keypad Page
        /// </summary>
        public static readonly KeyboardKeypadPage KeyboardKeypad = KeyboardKeypadPage.Instance;
        /// <summary>
        ///     LEDs Page
        /// </summary>
        public static readonly LEDsPage LEDs = LEDsPage.Instance;
        /// <summary>
        ///     Button Page
        /// </summary>
        public static readonly ButtonPage Button = ButtonPage.Instance;
        /// <summary>
        ///     Ordinal Page
        /// </summary>
        public static readonly OrdinalPage Ordinal = OrdinalPage.Instance;
        /// <summary>
        ///     Telephony Page
        /// </summary>
        public static readonly TelephonyPage Telephony = TelephonyPage.Instance;
        /// <summary>
        ///     Consumer Page
        /// </summary>
        public static readonly ConsumerPage Consumer = ConsumerPage.Instance;
        /// <summary>
        ///     Digitizer Page
        /// </summary>
        public static readonly DigitizerPage Digitizer = DigitizerPage.Instance;
        /// <summary>
        ///     Haptics Page
        /// </summary>
        public static readonly HapticsPage Haptics = HapticsPage.Instance;
        /// <summary>
        ///     Physical Interface Device Page
        /// </summary>
        public static readonly PhysicalInterfaceDevicePage PhysicalInterfaceDevice = PhysicalInterfaceDevicePage.Instance;
        /// <summary>
        ///     Unicode Page
        /// </summary>
        public static readonly UnicodePage Unicode = UnicodePage.Instance;
        /// <summary>
        ///     Eye and Head Trackers Page
        /// </summary>
        public static readonly EyeAndHeadTrackersPage EyeAndHeadTrackers = EyeAndHeadTrackersPage.Instance;
        /// <summary>
        ///     Auxiliary Display Page
        /// </summary>
        public static readonly AuxiliaryDisplayPage AuxiliaryDisplay = AuxiliaryDisplayPage.Instance;
        /// <summary>
        ///     Sensor Page
        /// </summary>
        public static readonly SensorPage Sensor = SensorPage.Instance;
        /// <summary>
        ///     Medical Instruments Page
        /// </summary>
        public static readonly MedicalInstrumentsPage MedicalInstruments = MedicalInstrumentsPage.Instance;
        /// <summary>
        ///     Braille Display Page
        /// </summary>
        public static readonly BrailleDisplayPage BrailleDisplay = BrailleDisplayPage.Instance;
        /// <summary>
        ///     Lighting and Illumination Page
        /// </summary>
        public static readonly LightingAndIlluminationPage LightingAndIllumination = LightingAndIlluminationPage.Instance;
        /// <summary>
        ///     Monitor Page
        /// </summary>
        public static readonly MonitorPage Monitor = MonitorPage.Instance;
        /// <summary>
        ///     Monitor Enumerated Values Page
        /// </summary>
        public static readonly MonitorEnumeratedValuesPage MonitorEnumeratedValues = MonitorEnumeratedValuesPage.Instance;
        /// <summary>
        ///     VESA Virtual Controls Page
        /// </summary>
        public static readonly VESAVirtualPage VESAVirtual = VESAVirtualPage.Instance;
        /// <summary>
        ///     Monitor Reserved Page
        /// </summary>
        public static readonly MonitorReservedPage MonitorReserved = MonitorReservedPage.Instance;
        /// <summary>
        ///     Power Device Page
        /// </summary>
        public static readonly PowerDevicePage PowerDevice = PowerDevicePage.Instance;
        /// <summary>
        ///     Battery System Page
        /// </summary>
        public static readonly BatterySystemPage BatterySystem = BatterySystemPage.Instance;
        /// <summary>
        ///     Bar Code Scanner Page
        /// </summary>
        public static readonly BarCodeScannerPage BarCodeScanner = BarCodeScannerPage.Instance;
        /// <summary>
        ///     Weighing Devices Page
        /// </summary>
        public static readonly WeighingDevicesPage WeighingDevices = WeighingDevicesPage.Instance;
        /// <summary>
        ///     Magnetic Stripe Reading (MSR) Devices Page
        /// </summary>
        public static readonly MagneticStripeReadingMSRDevicesPage MagneticStripeReadingMSRDevices = MagneticStripeReadingMSRDevicesPage.Instance;
        /// <summary>
        ///     Reserved Point of Sale Page
        /// </summary>
        public static readonly ReservedPointOfSalePage ReservedPointOfSale = ReservedPointOfSalePage.Instance;
        /// <summary>
        ///     Camera Control Page
        /// </summary>
        public static readonly CameraControlPage CameraControl = CameraControlPage.Instance;
        /// <summary>
        ///     Arcade Page
        /// </summary>
        public static readonly ArcadePage Arcade = ArcadePage.Instance;
        /// <summary>
        ///     Fast IDentity Online Alliance Page
        /// </summary>
        public static readonly FastIDentityOnlineAlliancePage FastIDentityOnlineAlliance = FastIDentityOnlineAlliancePage.Instance;
	}
}
#pragma warning restore CS0108 // Member hides inherited member; missing new keyword
