// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

// Specification revision: 1.3.0; generated at 2022-03-01 02:00:40Z.

#pragma warning disable CS0108 // Member hides inherited member; missing new keyword

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;

namespace DevDecoder.HIDDevices.Usages
{
    // <summary>
    //     Game Controls Usage Page.
    // </summary>
    [Description("Game Controls Usage Page")]
    public enum GameControlsPage : uint
    {
        // <summary>
        //     Undefined Usage.
        // </summary>
        [Description("Undefined")]
        Undefined = 0x00050000,

        // <summary>
        //     3D Game Controller Usage.
        // </summary>
        [Description("3D Game Controller")]
        _3DGameController = 0x00050001,

        // <summary>
        //     Pinball Device Usage.
        // </summary>
        [Description("Pinball Device")]
        PinballDevice = 0x00050002,

        // <summary>
        //     Gun Device Usage.
        // </summary>
        [Description("Gun Device")]
        GunDevice = 0x00050003,

        // <summary>
        //     Point of View Usage.
        // </summary>
        [Description("Point of View")]
        PointOfView = 0x00050020,

        // <summary>
        //     Turn Right/Left Usage.
        // </summary>
        [Description("Turn Right/Left")]
        TurnRightLeft = 0x00050021,

        // <summary>
        //     Pitch Forward/Backward Usage.
        // </summary>
        [Description("Pitch Forward/Backward")]
        PitchForwardBackward = 0x00050022,

        // <summary>
        //     Roll Right/Left Usage.
        // </summary>
        [Description("Roll Right/Left")]
        RollRightLeft = 0x00050023,

        // <summary>
        //     Move Right/Left Usage.
        // </summary>
        [Description("Move Right/Left")]
        MoveRightLeft = 0x00050024,

        // <summary>
        //     Move Forward/Backward Usage.
        // </summary>
        [Description("Move Forward/Backward")]
        MoveForwardBackward = 0x00050025,

        // <summary>
        //     Move Up/Down Usage.
        // </summary>
        [Description("Move Up/Down")]
        MoveUpDown = 0x00050026,

        // <summary>
        //     Lean Right/Left Usage.
        // </summary>
        [Description("Lean Right/Left")]
        LeanRightLeft = 0x00050027,

        // <summary>
        //     Lean Forward/Backward Usage.
        // </summary>
        [Description("Lean Forward/Backward")]
        LeanForwardBackward = 0x00050028,

        // <summary>
        //     Height of POV Usage.
        // </summary>
        [Description("Height of POV")]
        HeightOfPOV = 0x00050029,

        // <summary>
        //     Flipper Usage.
        // </summary>
        [Description("Flipper")]
        Flipper = 0x0005002a,

        // <summary>
        //     Secondary Flipper Usage.
        // </summary>
        [Description("Secondary Flipper")]
        SecondaryFlipper = 0x0005002b,

        // <summary>
        //     Bump Usage.
        // </summary>
        [Description("Bump")]
        Bump = 0x0005002c,

        // <summary>
        //     New Game Usage.
        // </summary>
        [Description("New Game")]
        NewGame = 0x0005002d,

        // <summary>
        //     Shoot Ball Usage.
        // </summary>
        [Description("Shoot Ball")]
        ShootBall = 0x0005002e,

        // <summary>
        //     Player Usage.
        // </summary>
        [Description("Player")]
        Player = 0x0005002f,

        // <summary>
        //     Gun Bolt Usage.
        // </summary>
        [Description("Gun Bolt")]
        GunBolt = 0x00050030,

        // <summary>
        //     Gun Clip Usage.
        // </summary>
        [Description("Gun Clip")]
        GunClip = 0x00050031,

        // <summary>
        //     Gun Selector Usage.
        // </summary>
        [Description("Gun Selector")]
        GunSelector = 0x00050032,

        // <summary>
        //     Gun Single Shot Usage.
        // </summary>
        [Description("Gun Single Shot")]
        GunSingleShot = 0x00050033,

        // <summary>
        //     Gun Burst Usage.
        // </summary>
        [Description("Gun Burst")]
        GunBurst = 0x00050034,

        // <summary>
        //     Gun Automatic Usage.
        // </summary>
        [Description("Gun Automatic")]
        GunAutomatic = 0x00050035,

        // <summary>
        //     Gun Safety Usage.
        // </summary>
        [Description("Gun Safety")]
        GunSafety = 0x00050036,

        // <summary>
        //     Gamepad Fire/Jump Usage.
        // </summary>
        [Description("Gamepad Fire/Jump")]
        GamepadFireJump = 0x00050037,

        // <summary>
        //     Gamepad Trigger Usage.
        // </summary>
        [Description("Gamepad Trigger")]
        GamepadTrigger = 0x00050039,

        // <summary>
        //     Form-fitting Gamepad Usage.
        // </summary>
        [Description("Form-fitting Gamepad")]
        FormfittingGamepad = 0x0005003a
    }
}
