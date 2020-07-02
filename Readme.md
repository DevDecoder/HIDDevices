![.NET Core](https://github.com/DevDecoder/HIDControllers/workflows/.NET%20Core/badge.svg)
![Nuget](https://img.shields.io/nuget/v/HIDControllers)
![Nuget (with prereleases)](https://img.shields.io/nuget/vpre/HIDControllers)

# Description
This library provides a cross-platform service for asynchronously receiving input from HID devices, such as Gamepads, Joysticks and Multi-axis controllers and programmable button pads.  It support Plug & Play, correctly identifying when controllers are added and removed.

It makes extensive use of [HIDSharp](https://www.zer7.com/software/hidsharp) (© Copyright 2012 James F. Bellinger, licensed under Apache License 2.0) _although this may be replaced in future versions_, [Reactive Extensions](https://github.com/dotnet/reactive) and [Dynamic Data](https://github.com/reactiveui/DynamicData).

# Installation
The library is delivered via NuGet Package Manager:

```
Install-Package VkApi.Wrapper
```

If you are targeting .NET Core, use the following command:

```
dotnet add package VkApi.Wrapper
```

# Usage

There is a [sample program](HidControllers.Sample) included which demonstrates using the library in a dependency injection scenario.

## Controllers

### Initialisation
To start monitoring controllers add the following code:

```csharp
await using var controllers = new Controllers();
```

**Note** this instantiates a new instance of the [Controllers](HIDControllers\Controllers.cs) class which immediately starts listening for new HID devices.  In practice you should only ever create one of these.  The [Controllers](HIDControllers\Controllers.cs) class implements `IAsyncDisposable` for asynchronous disposal, which cleans up the listeners.

Alternatively, the library is fully compatible with Dependency injection frameworks.  Register the service as a Singleton (so only one instance is created) using code similar to:
```csharp
services.AddSingleton<Controllers>();
...
var controllers = serviceProvider.GetService<Controllers>();
```

Modern DI frameworks should correctly handle instantiation and disposal automatically.

### Detecting Changes
The Controllers service exposes a `Changes` property which is an observable of batches of changes `IObservable<IList<ControlChange>>`

# TODO

* More documentation, examples
* Expose observable for controller changes.
* More Tests!
* Improved Documentation on public properties.
* Revise public API to remove any HIDSharp dependencies, to allow separation in future versions.

### Testing status

The following controllers have been tested:
* Saitek X-52 Pro Flight Control System,
* Razer Sabertooth Elite

The following OS's have been tested:
* Windows 10 Pro 2004 (19041.330)
* Ubuntu (limited testing so far)

Please let me know if you've confirmed it as working with other devices/OS's.
