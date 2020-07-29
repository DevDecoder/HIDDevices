[![Publish](https://github.com/DevDecoder/HIDDevices/workflows/Build%20and%20Publish/badge.svg)](https://github.com/DevDecoder/HIDDevices/actions?query=workflow%3A%22Build+and+Publish%22)
[![Nuget](https://img.shields.io/nuget/v/HIDDevices)](https://www.nuget.org/packages/HIDDevices/)

# Description
This library provides a cross-platform service for asynchronously accessing HID devices, such as Gamepads, Joysticks and Multi-axis controllers and programmable button pads.  It support Plug & Play, correctly identifying when controllers are added and removed, and Reactive frameworks.  It also allows the creation of custom Controller implementations which are matched automatically against devices for easy use.

**NOTE**: The project is currently based on [HIDSharp](https://www.zer7.com/software/hidsharp), but deliberately does not expose any of its library explicitly as it may well be replaced in future.

# Installation
The library is [available via NuGet](https://www.nuget.org/packages?q=HIDDevices) and is delivered via NuGet Package Manager:

```
Install-Package HIDDevices
```

If you are targeting .NET Core, use the following command:

```
dotnet add package 
Install-Package HIDDevices
```

# Usage

There is a [sample program](HIDDevices.Sample) included which demonstrates using the library in various scenarios.

## Devices

### Initialisation
To start monitoring controllers add the following code:

```csharp
using var devices = new Devices();
```

**Note** this instantiates a new instance of the [Devices](HIDDevices/Devices.cs) class which immediately starts listening for new HID devices.  In practice you should only ever create one of these.  The [Devices](HIDDevices/Devices.cs) class implements `IDisposable` for asynchronous disposal, which cleans up all listeners.

Alternatively, the library is fully compatible with Dependency injection frameworks.  Register the service as a Singleton (so only one instance is created) using code similar to:
```csharp
services.AddSingleton<Devices>();
...
var devices = serviceProvider.GetService<Devices>();
```

Modern DI frameworks should correctly handle instantiation and disposal automatically, as well as suppplying a logger if registered.

### Logging
The `Devices` constructor accepts an [`ILogger<Devices>`](https://docs.microsoft.com/en-us/dotnet/api/microsoft.extensions.logging.ilogger-1?view=dotnet-plat-ext-3.1&viewFallbackFrom=netstandard-2.1) for logging, this is normally injected via dependency injection, but an example of a simple logger can be found in the [samples](HIDDevices.Sample) - [SimpleConsoleLogger](HIDDevices.Sample/SimpleConsoleLogger.cs).


### Detecting changes in devices
The Devices service implements a `IObservableCache<Device, string>` property which can be subscribed to, to detect add/update/remove events for devices.  For more information on `IObservableCache<,>`, and how to consume them, see [DynamicData](https://github.com/reactiveui/DynamicData). e.g.

```csharp
using var subscription = devices.Connect().Subscribe(changeSet => { ... });
```

The standard `Connect()` method retrieves an observable collection of all devices, but does not actually attempt to connect to them; which is useful when you only want to see what is known to the Operating System.  However, you can also use the `Connected()` extension method, which _does_ attempt to establish a working connection to the devices, and only includes devices that are _currently_ connected (_whilst_ they remain connected).  As such it is a subset of the observable collection returned by `Connect()`.  A disconnected device is one that is still connected to the system, but to which a connection can not be established by the library.  For example, Windows prevents access to Keyboard and Mouse devices, but they are still listed.  Devices that are physically disconnected (and hence not seen by the Operating System) will be removed from both collections.

Both methods accept a `predicate` that can be used to efficiently filter devices to only include those you are interested in, for example:

```csharp
using var subscription = 
    devices.Connected(
      device => device.UsagesAll(GenericDesktopPage.GamePad &&
                device.ControlUsagesAll(GenericDesktopPage.X, GenericDesktopPage.Y))
    .Subscribe()
```

This uses the `UsagesAll` extension method to filter devices that don't implement the `GamePad` usage, and the `ControlUsagesAll` extension method to only select devices that have controls that implement all the specified usages (i.e. must have an `X` and `Y` axis - which, according to the HID specs, all GamePads are supposed to expose, but there's no guarantee).  There are also `UsagesAny` and `ControlUsagesAny` extension methods; and `DeviceUsages*` and `ControlUsages*` extension methods that can be applied to `Devices` directly (and are equaivalent to calling `Connect(...)` with the appropriate delegate).  

Supplying a delegate to filter the `Connected()` extension method is particularly recommended as it prevents unneccessary connection attempts to devices which you are not interested in.

### Connecting to a device

Each `Device` classs implements `IObservable<IList<ControlChange>>` which can be used to obserbe changes in control values.  A connection to the device is not established unless there is at least one subscriber to this interface.  There is also an `IObservable<bool> ConnectionState` property that changes value when the device connects/disconnects; subscribing to the `ConnectionState` will also ensure that there is a subscription to the main observable - attempting a connection.  To see the current connection state, you can use the `IsConnected` property, which returns the instantaneous value, but doesn't attempt a connection itself.  Using the `Connected()` extension method on the `Devices` collection will also ensure there is a subscription, and hence connection attempt.

### Detecting changes in controls

  As mentioned above the `Device` object implements `IObservable<IList<ControlChange>>` which returns batches of changes reported by a device when subscribed to.  `Device` also implements `IReadOnlyDictionary<Control, ControlChange>`, which can be used to find the last observed state of the Device's controls - however this doesn't establish a connection itself, so you should first connect by subscribing to the `Device`. A control's value is always mapped to a value between 0 and 1, or `double.NaN` to indicate null.  For convenience you can look for control changes across all devices using the `ControlChanges` extension method.  e.g.

```csharp
using var subscription2 = devices
    // Watch for control changes only
    .ControlChanges()
    .Subscribe(changes =>
    {
        ...
    });
```

A `ControlChange` indicates the changed `Control`, the `PreviousValue` and the new `Value`.  It also indicates how stale the change is by having `Timestamp` and, the derived `Elapsed` properties.

**Note**: HID devices are not required to report their initial state on connection, and frequently do not.  It is common for the device to only report it's entire state the first time it communicate (e.g. on a button press); as such the `ControlChange` retrieved for a given `Control` may by a default struct until such a time as an update is received.  In such a cash the `Timestamp` property will be `0` (and so the `Elapsed` will be `Timeout.InfiniteTimeSpan`).

# Controllers
To make devices easier to consume, the library contains a `Controller` concept which is effectively a device definition.  These are easy to define using attributes (see [Gamepad](HIDDevices/Controllers/Gamepad.cs) for a complete example).

To create a new Controller definition, extend the `Controller` class, and, optionally add zero or more `DeviceAttribute` attributes.  The specified `DeviceAttribute`s must be satisfied for a `Device` to match the controller.  `DeviceAttribute`s can specify multiple `Usage`s, all of which must match, or multiple `DeviceAttribute`s can be used to provide alternatives.  They can also filter by Product ID, or Version, for example:

```csharp
// The following controller will match devices that have either the GamePad
// or the Joystick Usage (if the Joystick has a ReleaseNumber starting with '1.').
[Device(GenericDesktopPage.GamePad)]
[Device(GenericDesktopPage.Joystick, ReleaseNumberRegex = "1\\..*")]
public class Joystick : Controller { ... }
```

In a similar way, you can then indicate properties that you wish to bind to a `Device`'s `Control`, using the `ControlAttribute`.  Again, multiple usages on the same attribute must _all_ match, but multiple attributes can be specified per property.  Where multiple attributes are specified, a weighting can be given to indicate a preference during the matching process (see example below).

If a `RequiredAttribute` is placed on a Control Property, then a device that does not supply such a property will not be matched to the controller.

Finally, properties can be converted using `TypeConverter`s by specifying a `TypeConverterAttribute`.

```csharp
// The following example indicates a required control, that must match the 'GenericDesktopPage.X'.
// It also converts the normal 0->1 range of values to -1->1 using the 'SignedConverter'.
[Control(GenericDesktopPage.X)]
[Required]
[TypeConverter(typeof(SignedConverter))]
public double X => GetValue<double>();

// The following example matches controls with the 'GenericDesktopPage.Select' in preference
// to those with 'ButtonPage.Button7', a match is not required.
// A default converter is registered for booleans already which returns false for values < 0.5.
[Control(GenericDesktopPage.Select, Weight = 2)]
[Control(ButtonPage.Button7)]
public bool Select => GetValue<bool>();
```

To register a default type converter for control properties, use `Controller.RegisterDefaultTypeConverter`, e.g.
```csharp
// Note this registration occurs by default, but can be overriden with your own default converter.
Controller.RegisterDefaultTypeConverter(typeof(bool), BooleanConverter.Instance);
```

  Once a device is matched to a controller it exposes the latest values of the controller via easily accessed properties.  Changes can also be observed via the `Changes` property.  To listen for specific controllers from `Devices` use the `Controllers<TController>` extension method, e.g.

```csharp
// Holds a reference to the current gamepad, which is set asynchronously as they are detected.
Gamepad? gamepad = null;
var batch = 0;

// Controller to any gamepads as they are found
using var subscription = devices.Controllers<Gamepad>().Subscribe(g =>
{
    // If we already have a connected gamepad ignore any more.
    // ReSharper disable once AccessToDisposedClosure
    if (gamepad?.IsConnected == true)
    {
        return;
    }

    // Assign this gamepad and connect to it.
    gamepad = g;
    g.Connect();
});
```

As demonstrated, a `Controller` doesn't start listening for changes until you call the `Connect()` method on it.

# Usages
For convenience, the full HID Usage tables are exposed and described via the `Usages`, `UsagePages` and `UsageTypes` classes.  These can be retrieved either directly using the `uint` identifier, or using the convenience enums, all of which have the `Page` suffix, for which implicit casts are available.

```csharp
// The enums can be cast to a Usage to retrieve full information about the Usage and it's page.
Usage usage = ButtonPage.Button1;
Console.WriteLine($"Usage: {usage.Name}; Page: {usage.Page.Name}");
```

# TODO

* More documentation, examples
* Support Output to devices
* More Tests!
* Automate NuGet Release notes

### Testing status

The following controllers have been tested:
* Saitek X-52 Pro Flight Control System,
* Razer Sabertooth Elite
* Microsoft XBox One for Windows Controller (_**Note** that it appears XInput-compatible HID device driver only transmits events from the HID device whilst the current process has a focussed window, so console applications/background services don't appear to work!  This is not a bug in this library._)

The following OS's have been tested:
* Windows 10 Pro 2004 (19041.330)
* Ubuntu (limited testing so far)

Please let me know if you've confirmed it as working with other devices/OS's by raising an issue.

# Acknowledgements

* https://www.usb.org/documents - All USB Specifications
* https://github.com/IntergatedCircuits/hid-usage-tables - for easily parsed HID Usage tables.
* It makes extensive use of [HIDSharp](https://www.zer7.com/software/hidsharp) (© Copyright 2012, James F. Bellinger, licensed under Apache License 2.0) _although this may be replaced in future versions_
* [Reactive Extensions](https://github.com/dotnet/reactive)
* [Dynamic Data](https://github.com/reactiveui/DynamicData).