// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HIDControllers;
using HIDControllers.Controls;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace HidControllers.Sample
{
    internal class Program
    {
        private static async Task Main()
        {
            // Dependency Injection sample, create a service provider.
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            // NOTE: ServiceProvider should be disposed asynchronously by most frameworks, however many examples don't show this,
            // Controllers also supports asynchronous disposal, and so should be disposed automatically by the service provider
            // when it is disposed.  If you create a Controllers object yourself, also use await using to ensure correct disposal.
            await using var serviceProvider = serviceCollection.BuildServiceProvider();

            // Get a logger
            var logger = serviceProvider.GetService<ILogger<Program>>();

            // The library provides fully described Event IDs, with localisable resources, for easy filtering of logs.
            // The full list of events can be found in the Event.All collection.
            foreach (var @event in Event.All)
            {
                logger.LogInformation(@event, @event.Description);
            }

            // Grab the controllers service
            var controllers = serviceProvider.GetService<Controllers>();

            // OPTIONALLY, we can wait for the initial load of controllers
            await controllers.LoadAsync().ConfigureAwait(false);
            logger.LogInformation("Initial controllers now loaded.");

            var button1PressedTcs = new TaskCompletionSource<bool>();
            var batch = 0;

            // Subscribe to all control changes
            controllers.Changes.Subscribe(l =>
            {
                var pressed = false;
                var logBuilder = new StringBuilder();
                logBuilder.Append("Batch ").Append(++batch).AppendLine(":");
                foreach (var group in l.GroupBy(c => c.Control.Controller))
                {
                    logBuilder.Append("  ").Append(group.Key).AppendLine(":");
                    foreach (var change in group)
                    {
                        logBuilder.Append("    ")
                            .Append(change.Control.Name)
                            .Append(": ")
                            .Append(change.OldValue.ToString("0.###"))
                            .Append(" -> ")
                            .AppendLine(change.NewValue.ToString("0.###"));

                        // Look for Button 1 being pressed
                        var b = change.Control as Button;
                        if (b?.Number == 1 && b.IsPressed)
                        {
                            pressed = true;
                        }
                    }
                }

                // Log the changes
                logger.LogInformation(logBuilder.ToString());

                if (pressed)
                {
                    button1PressedTcs.TrySetResult(true);
                }
            });

            // Wait on signal that Button 1 has been pressed
            await button1PressedTcs.Task.ConfigureAwait(false);

            logger.LogInformation("Finished");
        }

        private static void ConfigureServices(IServiceCollection services) =>
            // Configure logging and add the Controllers service as a singleton.
            services
                .AddLogging(configure => configure.AddConsole())
                .AddSingleton<Controllers>();
    }
}
