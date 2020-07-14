![.NET Core](https://github.com/DevDecoder/HIDDevices/workflows/.NET%20Core/badge.svg)
![Nuget](https://img.shields.io/nuget/v/HIDDevices)
![Nuget (with prereleases)](https://img.shields.io/nuget/vpre/HIDDevices)

# Description
This library provides a cross-platform service for asynchronously accessing HID devices, such as Gamepads, Joysticks and Multi-axis controllers and programmable button pads.  It support Plug & Play, correctly identifying when controllers are added and removed, and Reactive frameworks.

**NOTE**: This project is currently in a beta state, meaning it is still subject to frequent breaking changes as they API matures.  As such the documentation is not in a final form and below is just some quick notes to help you get started.

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

There is a [sample program](HIDDevices.Sample) included which demonstrates using the library in a dependency injection scenario.

## Devices

### Initialisation
To start monitoring controllers add the following code:

```csharp
using var devices = new Devices(CreateLogger<Devices>());
```

**Note** this instantiates a new instance of the [Devices](HIDDevices/Devices.cs) class which immediately starts listening for new HID devices.  In practice you should only ever create one of these.  The [Devices](HIDDevices/Devices.cs) class implements `IDisposable` for asynchronous disposal, which cleans up all listeners.

Alternatively, the library is fully compatible with Dependency injection frameworks.  Register the service as a Singleton (so only one instance is created) using code similar to:
```csharp
services.AddSingleton<Devices>();
...
var controllers = serviceProvider.GetService<Devices>();
```

Modern DI frameworks should correctly handle instantiation and disposal automatically.

### Logging
The `Devices` constructor accepts an `ILogger<Devices` for logging, this is normally injected via dependency injection, but an example of a simple logger can be found in the [samples](HIDDevices.Sample) - [SimpleConsoleLogger](HIDDevices.Sample/SimpleConsoleLogger.cs).


### Detecting changes in devices
The Devices service implements a `IObservableCache<Device, string>` property which can be subscribed to detect add/update/remove events for devices.  For more information on `IObservableCache<,>`, and how to consume them, see [DynamicData](https://github.com/reactiveui/DynamicData). e.g.

```csharp
using var subscription = controllers.Connect().Subscribe(changeSet => { ... });
```

### Detecting changes in controls
Each `Device` classs implements  `IObservable<IList<ControlChange>>` which can be used to obserbe changes in control values.  They also implement `IReadOnlyDictionary<Control, ControlChange>`, which can be used to find the last observed state of the Device's controls.  For convenience you can look for control changes across all devices using the `Watch` method.  e.g.

```csharp
using var subscription2 =controllers
    // Watch for control changes only
    .Watch()
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

# TODO

* More documentation, examples
* Support Output to devices
* More Tests!
* Improved Documentation on public properties.

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