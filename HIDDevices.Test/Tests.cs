// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reactive.Linq;
using System.Threading;
using System.Threading.Tasks;
using DevDecoder.HIDDevices;
using DevDecoder.HIDDevices.Usages;
using Microsoft.Extensions.Logging;
using Xunit;
using Xunit.Abstractions;

[assembly:
    SuppressMessage("Usage", "CA2254:Template should be a static expression", Justification = "This is sample code")]

namespace HIDDevices.Test;

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
        // ReSharper disable ParameterOnlyUsedForPreconditionCheck.Local
        Assert.DoesNotContain(Event.All, e => string.IsNullOrWhiteSpace(e.Format));
        Assert.DoesNotContain(Event.All, e => string.IsNullOrWhiteSpace(e.Description));
        // ReSharper restore ParameterOnlyUsedForPreconditionCheck.Local

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
        var initial = await devices.LoadAsync().ConfigureAwait(true);
        OutputHelper.WriteLine($"{initial.Count} controllers");
        Assert.Equal(1, refreshCount);

        // Repeated calls to LoadAsync should complete immediately, giving the same result
        // (assuming there's no change in the underlying devices which triggers an auto-refresh)
        var repeat = await devices.LoadAsync().ConfigureAwait(true);
        Assert.Equal(initial, repeat);
        Assert.Equal(1, refreshCount);
    }

    [Fact]
    public void TestUndefinedUsage()
    {
        var usage = Usage.Get(0xffff);
        Assert.Equal("Reserved (0x0000) - Undefined (0xFFFF)", usage.ToString());
    }

    [Fact]
    public void TestControlAttribute()
    {
        // Confirm that the enum and raw value are identical.
        var attr1 = new ControlAttribute(ButtonPage.Button15);
        var attr2 = new ControlAttribute(0x00090010);
        Assert.Single(attr1.Usages);
        Assert.Single(attr2.Usages);
        Assert.Equal(attr1.Usages[0], attr2.Usages[0]);

        // Confirm that a user defined ID is accepted.
        var attr3 = new ControlAttribute(0x00090011);
        Usage usage = attr3.Usages[0];
        Assert.Equal(UsagePage.Button, usage.Page);
        Assert.Equal(17, usage.Id);

        Logger.LogInformation($"User defined usage: {usage}");
    }
}
