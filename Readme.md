![Publish](https://github.com/DevDecoder/HIDDevices/workflows/Build%20and%20Publish/badge.svg)
![Nuget](https://img.shields.io/nuget/v/HIDDevices)

# Description
This library provides a cross-platform service for asynchronously accessing HID devices, such as Gamepads, Joysticks and Multi-axis controllers and programmable button pads.  It support Plug & Play, correctly identifying when controllers are added and removed, and Reactive frameworks.  It also allows the creation of custom Controller implementations which are matched automatically against devices for easy use.

**NOTE**: This project is currently based on [HIDSharp](https://www.zer7.com/software/hidsharp), but deliberately does not expose any of its library explicitly as it may well be replaced in future.

# Installation
The library is delivered via NuGet Package Manager:

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
var controllers = serviceProvider.GetService<Devices>();
```

Modern DI frameworks should correctly handle instantiation and disposal automatically, as well as suppplying a logger if registered.

### Logging
The `Devices` constructor accepts an [`ILogger<Devices>`](https://docs.microsoft.com/en-us/dotnet/api/microsoft.extensions.logging.ilogger-1?view=dotnet-plat-ext-3.1&viewFallbackFrom=netstandard-2.1) for logging, this is normally injected via dependency injection, but an example of a simple logger can be found in the [samples](HIDDevices.Sample) - [SimpleConsoleLogger](HIDDevices.Sample/SimpleConsoleLogger.cs).


### Detecting changes in devices
The Devices service implements a `IObservableCache<Device, string>` property which can be subscribed to detect add/update/remove events for devices.  For more information on `IObservableCache<,>`, and how to consume them, see [DynamicData](https://github.com/reactiveui/DynamicData). e.g.

```csharp
using var subscription = controllers.Connect().Subscribe(changeSet => { ... });
```

### Detecting changes in controls
Each `Device` classs implements  `IObservable<IList<ControlChange>>` which can be used to obserbe changes in control values.  They also implement `IReadOnlyDictionary<Control, ControlChange>`, which can be used to find the last observed state of the Device's controls. A control's value is always mapped to a value between 0 and 1, or `double.NaN` to indicate null.  For convenience you can look for control changes across all devices using the `ControlChanges` extension method.  e.g.

```csharp
using var subscription2 =controllers
    // Watch for control changes only
    .ControlChanges()
    .Subscribe(changes =>
    {
        ...
    });
```

## Controllers
The library contains a `Controller` concept which is effectively a device definition.  These are easy to define using attributes (see [Gamepad](HIDDevices/Controllers/Gamepad.cs) for a complete example).  Once matched they expose the latest values of the controller via easily accessed properties.  They can also be observed.  To listen for specific controllers from `Devices` use the `Controllers<TController>` extension method, e.g.

```csharp
using var subscription = devices.Controller<Gamepad>().Subscribe(gamepd => {...});            {
```

## Usages
The full HID Usage tables are exposed via the `Usages`, `UsagePages` and `UsageTypes` classes.  These take up ~20MB of memory on first reference, and take a short amount of time to fully initialise.  However, once initialised they are extremely quick and convenient to use.

# TODO

* More documentation, examples
* Support Output to devices
* More Tests!

### Testing status

The following controllers have been tested:
* Saitek X-52 Pro Flight Control System,
* Razer Sabertooth Elite
* Microsoft XBox One for Windows Controller (_**Note** that it appears XInput-compatible HID device driver only transmits events from the HID device whilst the current process has a focussed window, so console applications/background services don't appear to work!  This is not a bug in this library (after too many hours of investigation)._)

The following OS's have been tested:
* Windows 10 Pro 2004 (19041.330)
* Ubuntu (limited testing so far)

Please let me know if you've confirmed it as working with other devices/OS's.

# Acknowledgements

* https://www.usb.org/documents - All USB Specifications
* https://github.com/IntergatedCircuits/hid-usage-tables - for easily parsed HID Usage tables.
* It makes extensive use of [HIDSharp](https://www.zer7.com/software/hidsharp) (© Copyright 2012, James F. Bellinger, licensed under Apache License 2.0) _although this may be replaced in future versions_
* [Reactive Extensions](https://github.com/dotnet/reactive)
* [Dynamic Data](https://github.com/reactiveui/DynamicData).