using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DynamicData;
using HIDControllers;
using HIDControllers.Pages;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace HidControllers.Sample
{
    public class DependencyInjectionExample : IExample
    {
        /// <inheritdoc />
        public string FullName => "Dependency Injection Example";

        /// <inheritdoc />
        public IReadOnlyCollection<string> ShortNames { get; }
            = new[] { "D", "DI", "DependencyInjection" };

        /// <inheritdoc />
        public async Task ExecuteAsync(CancellationToken token = default)
        {
            // Create an example service provider (this may be done by your framework code already)
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            // NOTE: ServiceProvider should be disposed asynchronously by most frameworks, however many examples don't show this,
            // Controllers also supports asynchronous disposal, and so should be disposed automatically by the service provider
            // when it is disposed.  If you create a Controllers object yourself, also use await using to ensure correct disposal.
            await using var serviceProvider = serviceCollection.BuildServiceProvider();

            // Get the logger
            var logger = serviceProvider.GetService<ILogger<Program>>();

            // Grab the controllers service
            var controllers = serviceProvider.GetService<Controllers>();

            // Subscribe to changes in controllers
            using var controllerSubscription = controllers.Connect()
                .Subscribe(changeSet =>
                {
                    var logBuilder = new StringBuilder();
                    logBuilder.AppendLine("Controllers updated:");
                    var first = true;
                    foreach (var change in changeSet)
                    {
                        if (first) first = false;
                        else logBuilder.AppendLine(null);

                        var controller = change.Current;
                        logBuilder.Append("  The ")
                            .Append(controller)
                            .Append(" Controller  was ");
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
            using (controllers
                // Watch for button changes only
                .Watch(c => c.ButtonNumber > 0 && !c.Controller.Usages.Contains(GenericDesktopPage.Mouse))
                .Subscribe(changes =>
                {
                    // Log the changes and look for a press of Button 1 on any controller.
                    var logBuilder = new StringBuilder();
                    logBuilder.Append("Batch ").Append(++batch).AppendLine(":");
                    foreach (var group in changes.GroupBy(c => c.Control.Controller))
                    {
                        logBuilder.Append("  ").Append(group.Key).AppendLine(":");
                        foreach (var change in group)
                        {
                            logBuilder
                                .Append("    ")
                                .Append(change.Control.Name)
                                .Append(": ")
                                .Append(change.PreviousValue.ToString("0.###"))
                                .Append(" -> ")
                                .AppendLine(change.Value.ToString("0.###"));
                        }
                    }

                    logger.LogInformation(logBuilder.ToString());
                }))
            {
                // Subscribe to just button 1 change events, and trigger a task completion source when any are pressed.
                var button1PressedTcs = new TaskCompletionSource<bool>();
                using (controllers
                    // Watch for button changes only
                    .Watch(c => c.ButtonNumber == 1)
                    //&& !c.Controller.Usages.Contains(65538u))
                    .Subscribe(changes =>
                    {
                        if (changes.Any(c => c.Value > 0.5))
                            button1PressedTcs.TrySetResult(true);
                    }))
                {

                    // Wait on signal that Button 1 has been pressed
                    await button1PressedTcs.Task.ConfigureAwait(false);
                }
            }

            logger.LogInformation("Finished");
        }

        private static void ConfigureServices(IServiceCollection services) =>
            // Configure logging and add the Controllers service as a singleton.
            services
                .AddLogging(configure => configure.AddConsole())
                .AddSingleton<Controllers>();
    }
}
