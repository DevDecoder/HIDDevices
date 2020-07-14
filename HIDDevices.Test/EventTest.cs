// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

using System.Linq;
using Microsoft.Extensions.Logging;
using Xunit;
using Xunit.Abstractions;

namespace HIDDevices.Test
{
    public class EventTest
    {
        public EventTest(ITestOutputHelper outputHelper)
        {
            OutputHelper = outputHelper;
            Logger = OutputHelper.ToLogger<EventTest>();
        }

        private ITestOutputHelper OutputHelper { get; }
        private ILogger<EventTest> Logger { get; }

        // [Fact]
        public void EventAllTest()
        {
            Assert.NotEmpty(Event.All);
            Assert.Equal(Event.All.Count, Event.All.Select(e => e.Id).Distinct().Count());
            Assert.DoesNotContain(Event.All, e => string.IsNullOrWhiteSpace(e.Message));
            Assert.DoesNotContain(Event.All, e => string.IsNullOrWhiteSpace(e.Description));

            // The library provides fully described Event IDs, with localisable resources, for easy filtering of logs.
            // The full list of events can be found in the Event.All collection.
            foreach (var @event in Event.All)
            {
                Logger.LogInformation(@event, @event.Description);
            }
        }
    }
}
