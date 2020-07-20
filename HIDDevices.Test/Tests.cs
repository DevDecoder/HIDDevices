// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

using System;
using System.Linq;
using System.Reactive.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Xunit;
using Xunit.Abstractions;

namespace HIDDevices.Test
{
    public class Tests
    {
        public Tests(ITestOutputHelper outputHelper)
        {
            OutputHelper = outputHelper;
            Logger = OutputHelper.ToLogger<Tests>();
        }

        private ITestOutputHelper OutputHelper { get; }
        private ILogger<Tests> Logger { get; }

        [Fact]
        public void EventAllTest()
        {
            Assert.NotEmpty(Event.All);
            Assert.Equal(Event.All.Count, Event.All.Select(e => e.Id).Distinct().Count());
            Assert.DoesNotContain(Event.All, e => string.IsNullOrWhiteSpace(e.Format));
            Assert.DoesNotContain(Event.All, e => string.IsNullOrWhiteSpace(e.Description));

            // The library provides fully described Event IDs, with localisable resources, for easy filtering of logs.
            // The full list of events can be found in the Event.All collection.
            foreach (var @event in Event.All)
            {
                Logger.LogInformation(@event, @event.Description);
            }
        }

        [Fact]
        public async Task TestLoadAsync()
        {
            var refreshCount = 0;
            using var devices = new Devices(OutputHelper.ToLogger<Devices>());
            using var _ = devices.Refreshing
                .Do(r => Logger.LogInformation($"Refreshing is {r}"))
                .Where(r => !r)
                // ReSharper disable once VariableHidesOuterVariable
                .Subscribe(_ => Interlocked.Increment(ref refreshCount));

            Assert.Equal(0, refreshCount);
            var initial = await devices.LoadAsync().ConfigureAwait(false);
            OutputHelper.WriteLine($"{initial.Count} controllers");
            Assert.Equal(1, refreshCount);

            // Repeated calls to LoadAsync should complete immediately, giving the same result
            // (assuming there's no change in the underlying devices which triggers an auto-refresh)
            var repeat = await devices.LoadAsync().ConfigureAwait(false);
            Assert.Equal(initial, repeat);
            Assert.Equal(1, refreshCount);
        }
    }
}
