// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

using System;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DynamicData;
using HIDDevices.Controllers;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace HIDDevices.Sample.Samples
{
    public class DependencyInjectionSample : Sample
    {
        /// <inheritdoc />
        public override string Description =>
            "Demonstrates configuration of controllers in a dependency injection scenario.";

        /// <inheritdoc />
        public override async Task ExecuteAsync(CancellationToken token = default)
        {
            // Create an example service provider (this may be done by your framework code already)
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            // NOTE: ServiceProvider should be disposed asynchronously by most frameworks, however many examples don't show this,
            // Devices also supports asynchronous disposal, and so should be disposed automatically by the service provider
            // when it is disposed.  If you create a Devices object yourself, also use await using to ensure correct disposal.
            await using var serviceProvider = serviceCollection.BuildServiceProvider();

            // Get the logger
            var logger = serviceProvider.GetService<ILogger<DependencyInjectionSample>>();

            // Grab the controllers service
            var controllers = serviceProvider.GetService<Devices>();

            // Subscribe to changes in controllers
            using var subscription1 = controllers.Connect()
                .Subscribe(changeSet =>
                {
                    var logBuilder = new StringBuilder();
                    logBuilder.AppendLine("Devices updated:");
                    var first = true;
                    foreach (var change in changeSet)
                    {
                        if (first)
                        {
                            first = false;
                        }
                        else
                        {
                            logBuilder.AppendLine(null);
                        }

                        var controller = change.Current;
                        logBuilder.Append("  The ")
                            .Append(controller)
                            .Append(" Device  was ");
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

                        logBuilder.Append("    DevicePath: ")
                            .AppendLine(controller.DevicePath)
                            .Append("    Usages: ")
                            .AppendLine(string.Join(", ", controller.Usages))
                            .Append("    Controls: ")
                            .AppendLine(string.Join(", ", controller.Keys));
                    }

                    logger.LogInformation(logBuilder.ToString());
                });

            // Subscribe to all button control changes
            var batch = 0;
            using var subscription2 =controllers
                // Watch for button changes only
                .Watch()
                .Subscribe(changes =>
                {
                    // Log the changes and look for a press of Button 1 on any controller.
                    var logBuilder = new StringBuilder();
                    logBuilder.Append("Batch ").Append(++batch).AppendLine(":");
                    foreach (var group in changes.GroupBy(c => c.Control.Device))
                    {
                        logBuilder.Append("  ").Append(@group.Key).AppendLine(":");
                        foreach (var change in @group)
                        {
                            logBuilder
                                .Append("    ")
                                .Append(change.Control.Name)
                                .Append(": ")
                                .Append(change.PreviousValue.ToString("F3"))
                                .Append(" -> ")
                                .Append(change.Value.ToString("F3"))
                                .Append(" (")
                                .Append(change.Elapsed.TotalMilliseconds.ToString("0.###"))
                                .AppendLine("ms)");
                        }
                    }

                    logger.LogInformation(logBuilder.ToString());
                });

            // Subscribe to just button 1 change events, and trigger a task completion source when any are pressed.
            var button1PressedTcs = new TaskCompletionSource<bool>();
            using var subscription3 = controllers
                // Watch for button changes only
                .Watch(c => c.ButtonNumber == 1)
                //&& !c.Device.Usages.Contains(65538u))
                .Subscribe(changes =>
                {
                    if (changes.Any(c => c.Value > 0.5))
                    {
                        button1PressedTcs.TrySetResult(true);
                    }
                });

            /* TODO
            var gamepad = controllers.Connect<Gamepad>().FirstOrDefault();

            if (gamepad != null)
            {
                var builder = new StringBuilder();
                builder.AppendLine(
                    $"{gamepad.Name} found!  Following controls were mapped:");
                //- {string.Join(", ", gamepad.Mapping.Values.Select(ci => ci.PropertyName))}");
                foreach (var (control, infos) in gamepad.Mapping)
                {
                    builder.AppendLine(
                        $"  {control.Name} => {string.Join(", ", infos.Select(info => info.PropertyName))}");
                }

                logger.LogInformation(builder.ToString());

                gamepad.Subscribe(change =>
                {
                    var valueStr = change.Value switch
                    {
                        bool b => b ? "Pressed" : "Not Pressed",
                        double d => d.ToString("F3"),
                        null => "<null>",
                        _ => change.Value.ToString()
                    };
                    logger.LogInformation(
                        $"  {change.PropertyName}: {valueStr} ({change.Elapsed.TotalMilliseconds:F3}ms)");
                });
            }
            gamepad?.Dispose();
            */

            Console.WriteLine("Press Button 1 on any device to exit!");

            // Wait on signal that Button 1 has been pressed
            await button1PressedTcs.Task.ConfigureAwait(false);

            logger.LogInformation("Finished");
        }

        private static void ConfigureServices(IServiceCollection services) =>
            // Configure logging and add the Devices service as a singleton.
            services
                .AddLogging(configure => configure.AddConsole())
                .AddSingleton<Devices>();
    }
}
