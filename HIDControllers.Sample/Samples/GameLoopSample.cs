// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using HIDControllers.Devices;

namespace HIDControllers.Sample.Samples
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

            // OPTIONAL - this will block until the initial load of controllers completes, (or 1 second elapses)
            // Really we should deal with changes to controllers as they arrive (including initial load), however,
            // this (and it's more useful LoadAsync() counterpart) are here for convenience.
            controllers.Load(TimeSpan.FromSeconds(1));

            // Holds a connection to the current gamepad, we could get it now, but we'll do it in the inner loop
            // so that it can work dynamically.
            Gamepad? gamepad = null;
            var timestamp = Stopwatch.GetTimestamp();
            try
            {
                // Our 'game loop'
                while (true)
                {
                    // Sleep to simulate a game loop (we'll output values once 1 second, obviously a real game loop,
                    // would cycle approximately every 16ms (for 60fps).
                    Thread.Sleep(1000);

                    // If we haven't got a gamepad, or the current one has been disconnected, let's look for a new one
                    if (gamepad?.IsConnected != true)
                    {
                        if (gamepad != null)
                        {
                            Console.WriteLine($"{gamepad.Controller.Name} disconnected!");
                        }

                        // Find a controller that satisfies the requirements of being a gamepad, and connect to it.
                        gamepad = controllers.Connect<Gamepad>().FirstOrDefault();

                        if (gamepad?.IsConnected != true)
                        {
                            // Still not got any connection, although this may be due to the controller still opening the connection
                            // it should be available by the next iteration.
                            Console.WriteLine("Please plug in a gamepad!");
                            continue;
                        }

                        Console.WriteLine($"{gamepad.Controller.Name} connected!  Following controls were mapped - {string.Join(", ", gamepad.Mapping.Values)}");
                    }

                    // We can get all the changes since the last time we checked.
                    foreach (var change in gamepad.ChangesSince(timestamp))
                    {
                        Console.WriteLine(
                            $"  {change.Control.Name}: {change.PreviousValue:0.###} -> {change.Value:0.###} ({change.Elapsed.TotalMilliseconds:0.###}ms)");
                    }

                    // Update our timestamp
                    timestamp = Stopwatch.GetTimestamp();
                }
            }
            finally
            {
                // Ensure gamepad connection is disposed to stop listening to the gamepad
                if (gamepad != null)
                {
                    gamepad.Dispose();
                    Console.WriteLine($"{gamepad.Controller.Name} disconnected!");
                }
            }
        }
    }
}
