// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DynamicData;
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

            // Grab the controllers service
            var controllers = serviceProvider.GetService<Controllers>();

            // OPTIONALLY, we can wait for the initial load of controllers
            await controllers.LoadAsync().ConfigureAwait(false);
            logger.LogInformation("Initial controllers now loaded.");

            var button1PressedTcs = new TaskCompletionSource<bool>();
            var batch = 0;

            controllers.Updates.Subscribe(changeSet =>
            {
                var logBuilder = new StringBuilder();
                logBuilder.AppendLine("Controllers updated:");
                foreach (var change in changeSet)
                {
                    logBuilder.Append("  The ")
                        .Append(change.Current)
                        .Append(" Controller was ");
                    switch (change.Reason)
                    {
                        case ChangeReason.Add:
                            logBuilder.AppendLine("added.");
                            break;
                        case ChangeReason.Update:
                            logBuilder.AppendLine("updated.");
                            break;
                        case ChangeReason.Remove:
                            // Warning, the controller will be in the process of being disposed, so you should not access it's methods
                            // (ToString() is safe though, and is all that is being accessed above).
                            logBuilder.AppendLine("removed.");
                            break;
                    }
                }

                logger.LogInformation(logBuilder.ToString());
            });

            // Subscribe to all control changes
            controllers.Changes
                .Subscribe(changes =>
            {
                // Log the changes and look for a press of Button 1 on any controller.
                var pressed = false;
                var logBuilder = new StringBuilder();
                logBuilder.Append("Batch ").Append(++batch).AppendLine(":");
                foreach (var group in changes.GroupBy(c => c.Control.Controller))
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
                        if (b?.Number == 1 && change.NewValue > 0.5D)
                        {
                            pressed = true;
                        }
                    }
                }
                logger.LogInformation(logBuilder.ToString());

                if (pressed)
                {
                    // Setting the task completion source will cause the below await to complete.
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
