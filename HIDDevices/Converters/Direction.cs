// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

namespace HIDDevices.Converters
{
    /// <summary>
    ///     Enum Direction indicates the possible directions of a Hat control.
    /// </summary>
    public enum Direction : byte
    {
        /// <summary>
        ///     The north direction (or up).
        /// </summary>
        North = 0,

        /// <summary>
        ///     The north east direction.
        /// </summary>
        NorthEast = 1,

        /// <summary>
        ///     The east direction.
        /// </summary>
        East = 2,

        /// <summary>
        ///     The south east direction.
        /// </summary>
        SouthEast = 3,

        /// <summary>
        ///     The south direction.
        /// </summary>
        South = 4,

        /// <summary>
        ///     The south west direction.
        /// </summary>
        SouthWest = 5,

        /// <summary>
        ///     The west direction.
        /// </summary>
        West = 6,

        /// <summary>
        ///     The north west direction.
        /// </summary>
        NorthWest = 7,

        /// <summary>
        ///     The hat is not pressed.
        /// </summary>
        NotPressed = 255
    }
}
