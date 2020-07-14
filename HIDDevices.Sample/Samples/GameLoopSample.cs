// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using HIDDevices.Controllers;

namespace HIDDevices.Sample.Samples
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
            using var controllers = new Devices();

            // OPTIONAL - this will block until the initial load of controllers completes, (or 1 second elapses)
            // Really we should deal with changes to controllers as they arrive (including initial load), however,
            // this (and it's more useful LoadAsync() counterpart) are here for convenience.
            controllers.Load(TimeSpan.FromSeconds(1));

            Console.WriteLine("Press A Button to exit!");

            // Holds a connection to the current gamepad, we could get it now, but we'll do it in the inner loop
            // so that it can work dynamically.
            Gamepad? gamepad = null;
            var timestamp = 0L;
            var batch = 0;
            try
            {
                // Our 'game loop'
                while (true)
                {
                    // Sleep to simulate a game loop.
                    Thread.Sleep(15);

                    // If we haven't got a gamepad, or the current one has been disconnected, let's look for a new one
                    if (gamepad?.IsConnected != true)
                    {
                        if (gamepad != null)
                        {
                            Console.WriteLine($"{gamepad.Name} disconnected!");
                        }

                        // Find a controller that satisfies the requirements of being a gamepad, and connect to it.
                        gamepad = controllers.Connect<Gamepad>().FirstOrDefault();
                        if (gamepad is null)
                        {
                            Console.WriteLine("Please plug in a gamepad!");
                            continue;
                        }

                        Console.WriteLine(
                            $"{gamepad.Name} found!  Following controls were mapped:");
                        foreach (var (control, infos) in gamepad.Mapping)
                        {
                            Console.WriteLine($"  {control.Name} => {string.Join(", ", infos.Select(info => info.PropertyName))}");
                        }

                        batch = 0;
                    }

                    // Look for any changes
                    var changes = gamepad.ChangesSince(timestamp);
                    if (changes.Count > 0)
                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Batch {++batch}");
                        foreach (var value in changes)
                        {
                            // We should update our timestamp to the last change we see.
                            if (timestamp < value.Timestamp) timestamp = value.Timestamp;
                            var valueStr = value.Value switch
                            {
                                bool b => b ? "Pressed" : "Not Pressed",
                                double d => d.ToString("F3"),
                                null => "<null>",
                                _ => value.Value.ToString()
                            };
                            Console.WriteLine(
                                $"  {value.PropertyName}: {valueStr} ({value.Elapsed.TotalMilliseconds:F3}ms)");
                        }
                    }

                    // Or directly access controls
                    if (gamepad.AButton)
                    {
                        Console.WriteLine("A Button pressed, finishing.");
                        return;
                    }
                }
            }
            finally
            {
                // Ensure gamepad connection is disposed to stop listening to the gamepad
                if (gamepad != null)
                {
                    gamepad.Dispose();
                    Console.WriteLine($"{gamepad.Device.Name} disconnected!");
                }
            }
        }
    }
}
