// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using HIDControllers;
using HidSharp;

namespace HIdControllers.Sample
{
    public class GameLoopSample : Sample
    {
        /// <inheritdoc />
        public override string Description =>
            "Demonstrates a classic synchronous game loop.";

        /// <inheritdoc />
        protected override void Execute()
        {
            // Create a singleton instance of the controllers object, that we should dispose
            // on closing the game, here we use a using block, but can obviously call controllers.Dispose()
            using var controllers = new Controllers();

            // Our 'game loop'
            while (true)
            {
                // Sleep for 20 ms to simulate a game loop w
                Thread.Sleep(20);

                // TODO
            }
        }
    }
}
