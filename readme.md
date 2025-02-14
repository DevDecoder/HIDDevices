[![GitHub tag](https://img.shields.io/github/tag/DevDecoder/HIDDevices?include_prereleases=&sort=semver&color=blue)](https://github.com/DevDecoder/HIDDevices/releases/)
[![License](https://img.shields.io/badge/License-Apache-blue)](#license)

[![Publish](https://github.com/DevDecoder/HIDDevices/workflows/Build%20and%20Publish%20HIDDevices/badge.svg)](https://github.com/DevDecoder/HIDDevices/actions?query=workflow:"Build+and+Publish+HIDDevices")
[![Nuget](https://img.shields.io/nuget/v/HIDDevices)](https://www.nuget.org/packages/HIDDevices/)<br/>
[![Publish](https://github.com/DevDecoder/HIDDevices/workflows/Build%20and%20Publish%20HIDDevices.Usages/badge.svg)](https://github.com/DevDecoder/HIDDevices/actions?query=workflow:"Build+and+Publish+HIDDevices.Usages")
[![Nuget](https://img.shields.io/nuget/v/HIDDevices.Usages)](https://www.nuget.org/packages/HIDDevices.Usages)

# Description

This library provides a cross-platform service for asynchronously accessing HID devices, such as Gamepads, Joysticks,
Multi-axis controllers, and programmable button pads. It supports Plug & Play, correctly identifying when controllers
are added and removed, and Reactive frameworks. It also allows the creation of custom Controller implementations, which
are matched automatically against devices for easy use.

Since [Version 4](#migrating-to-version-4), you can now install the
[HIDDevices.Usages](https://www.nuget.org/packages/HIDDevices.Usages) NuGet entirely independently, providing up-to-date
Usage Pages, generated directly from the [the USB HID Usage Tables](https://usb.org/hid). In the same way, you do not need
to include the [HIDDevices.Usages](https://www.nuget.org/packages/HIDDevices.Usages) NuGet to make use of the 
[HIDDevices](https://www.nuget.org/packages/HIDDevices/) NuGet.

## Important Notes

* The project is based on [HIDSharp](https://www.zer7.com/software/hidsharp) but deliberately does not expose any of its
  API explicitly, as I may replace it in a future version.
* Although the project isn't active, I refresh the usage tables on occasion and respond to issues if you
  raise them in the issue tracker.
* As the `Usage`s and `UsagePage`s are auto-generated they can change between versions
  whenever [the USB HID Usage Tables](https://usb.org/hid) are updated. This can cause breaking changes in your code, so
  be careful when updating versions of the NuGet. In particular, any time the HID tables are updated, I will update
  the minor version number (at least). Notable changes include from 2.0-2.1 when many of the 1-indexed usages were
  changed to 0-indexed, e.g. `ButtonPage.Button1` became `ButtonPage.Button0`; and when moving from version 2 to version
  3, when I changed the code generation algorithm and the source of truth was changed to directly reference the
  published PDF specification (see #6).
* The XInput-compatible HID device driver only transmits events from the HID device whilst the current process has a
  focussed window, so console applications/background services don't appear to work! This is not a bug in this library,
  although I have been unable to find where this 'feature' is documented. It affects the "Microsoft XBox One for Windows
  Controller".
* When changing from version 3.x to version 4.0, the `Usage`s and `UsagePage`s were split into their own NuGet, see
  "[Migrating to Version 4](#migrating-to-version-4)" for the justification and an explanation of breaking changes.

# Installation

The library is [available via NuGet](https://www.nuget.org/packages?q=HIDDevices) and is delivered via NuGet Package
Manager:

```
Install-Package HIDDevices
```

If you are targeting .NET Core, use the following command:

```
dotnet add package HIDDevices
```

Installing the `HIDDevices.Usages` NuGet is also _highly_ recommended.

# Usage

The [sample program](HIDDevices.Sample) demonstrates using the library in various scenarios.

## The HID Tables

The library accepts usage identifiers as a raw `uint`, however that is prone to error. As such, it was designed to work
alongside the [HIDDevices.Usages Nuget](HIDDevices.Usages/readme.md) which encodes
[the USB HID Usage Tables](https://usb.org/hid) into enumerations and types that can be implicitly converted to the raw
`uint` identifier. These types encode a lot of information and can add ~400kb to your deployed code size, so may not
be suitable for all projects. Using the raw `uint` identifier is always an option, especially when using with a
non-standard device.

## Devices

### Initialisation

To start monitoring controllers, add the following code:

```csharp
using var devices = new Devices();
```

**Note** This instantiates a new instance of the [Devices](HIDDevices/Devices.cs) class, which immediately starts
listening for new HID devices. In practice, you should only ever create one of these.
The [Devices](HIDDevices/Devices.cs) class implements `IDisposable` for asynchronous disposal, which cleans up all
listeners.

Alternatively, the library is fully compatible with Dependency injection frameworks. Register the service as a
Singleton (so only one instance is created) using code similar to:

```csharp
services.AddSingleton<Devices>();
...
var devices = serviceProvider.GetService<Devices>();
```

Modern DI frameworks should correctly handle instantiation and disposal automatically and supply a logger if registered.

### Logging

The `Devices` constructor accepts
an [`ILogger<Devices>`](https://docs.microsoft.com/en-us/dotnet/api/microsoft.extensions.logging.ilogger-1?view=dotnet-plat-ext-3.1&viewFallbackFrom=netstandard-2.1)
for logging, most often supplied via dependency injection, but you can find an example of a simple logger in
the [samples](HIDDevices.Sample) - [SimpleConsoleLogger](HIDDevices.Sample/SimpleConsoleLogger.cs).

### Detecting changes in devices

The Devices service implements an `IObservableCache<Device, string>` property, which publishes add/update/remove events
for devices. For more information on `IObservableCache<,>` and how to consume them,
see [DynamicData](https://github.com/reactiveui/DynamicData). e.g.

```csharp
using var subscription = devices.Connect().Subscribe(changeSet => { ... });
```

The standard `Connect()` method retrieves an observable collection of all devices but does not attempt to connect to
them, which is useful when you only want to see what is known to the Operating System. However, you can also use
the `Connected()` extension method, which _does_ attempt to establish a working connection to the devices, and only
includes devices that are _currently_ connected (_whilst_ they remain connected). It is a subset of the observable
collection returned by `Connect()`.

A disconnected device is connected to the system, but the library can not establish a connection to it. For example,
Windows prevents access to Keyboard and Mouse devices, but they are still listed. Devices that are physically
disconnected (and hence not seen by the Operating System) are absent from both collections.

Both methods accept a `predicate` that you can use to efficiently filter devices only to include those you are
interested in, for example:

```csharp
using var subscription = 
    devices.Connected(
      device => device.UsagesAll(GenericDesktopPage.GamePad &&
                device.ControlUsagesAll(GenericDesktopPage.X, GenericDesktopPage.Y))
    .Subscribe()
```

This uses the `UsagesAll` extension method to filter devices that don't implement the `GamePad` usage and
the `ControlUsagesAll` extension method to only select devices that have controls that implement all the specified
usages (i.e. must have an `X` and `Y` axis - which, according to the HID specs, all GamePads are supposed to expose, but
there's no guarantee). There are also `UsagesAny` and `ControlUsagesAny` extension methods and `DeviceUsages*`
and `ControlUsages*` extension methods that you can apply to `Devices` directly (and are equivalent to
calling `Connect(...)` with the appropriate delegate).

Supplying a delegate to filter the `Connected()` extension method is recommended to prevent unnecessary connection
attempts to devices you are not interested in.

### Connecting to a device

Each `Device` class implements `IObservable<IList<ControlChange>>`, which you can use to observe changes in control
values. A connection to the device is only established when there is at least one subscriber to this interface. There is
also an `IObservable<bool> ConnectionState` property that changes value when the device connects/disconnects;
subscribing to the `ConnectionState` will also ensure a subscription to the main observable - attempting a connection.
To see the current connection state, you can use the `IsConnected` property, which returns the instantaneous value but
doesn't attempt a connection. Using the `Connected()` extension method on the `Devices` collection will also ensure a
subscription and connection attempt.

### Detecting changes in controls

As mentioned above, the `Device` object implements `IObservable<IList<ControlChange>>`, which returns batches of changes
reported by a device when subscribed to. `Device` also implements `IReadOnlyDictionary<Control, ControlChange>`, which
you can use to find the last observed state of the Device's controls - however this doesn't establish a connection
itself, so you should first connect by subscribing to the `Device`. A control's value is always mapped to a value
between 0 and 1, or `double.NaN` to indicate null. You can look for control changes across all devices using
the `ControlChanges` extension method for convenience. e.g.

```csharp
using var subscription2 = devices
    // Watch for control changes only
    .ControlChanges()
    .Subscribe(changes =>
    {
        ...
    });
```

A `ControlChange` indicates the changed `Control`, the `PreviousValue` and the new `Value`. It also shows how stale the
change is by having `Timestamp` and the associated `Elapsed` properties.

**Note**: HID devices are not required to report their initial state on connection and frequently do not. It is typical
for the device only to report its entire state the first time it communicates (e.g. on a button press); as such,
the `ControlChange` retrieved for a given `Control` may be a default struct until such a time as an update is received.
In such a case the `Timestamp` property will be `0` (and the `Elapsed` will be `Timeout.InfiniteTimeSpan`).

# Controllers

To make devices simpler to consume, the library contains a `Controller` concept, effectively a device definition. These
are easy to define using attributes. See [Gamepad](HIDDevices/Controllers/Gamepad.cs) for a complete example, however,
this uses raw identifiers for
the usages due to the decision to not force inclusion of the usage tables. In your own code you can use the
corresponding encoded types, as we do below.

To create a new Controller definition, extend the `Controller` class and add zero or more `DeviceAttribute` attributes
optionally. The specified `DeviceAttribute`s must be satisfied for a `Device` to match the controller. `DeviceAttribute`
s can specify multiple `Usage`s, all of which must match, or you can use multiple `DeviceAttribute`s to provide
alternatives. They can also filter by Product ID or Version, for example:

```csharp
// The following controller will match devices that have either the GamePad
// or the Joystick Usage (if the Joystick has a ReleaseNumber starting with '1.').
[Device(GenericDesktopPage.GamePad)]
[Device(GenericDesktopPage.Joystick, ReleaseNumberRegex = "1\\..*")]
public class Joystick : Controller { ... }
```

Similarly, you can then indicate properties that you wish to bind to a `Device`'s `Control` using
the `ControlAttribute`. Again, multiple usages on the same attribute must _all_ match, but you can specify multiple
attributes per property. Where multiple attributes are selected, you can define a weighting to indicate a preference
during the matching process (see example below).

If a `RequiredAttribute` is placed on a Control Property, then a device that does not supply such a property will not be
matched to the controller.

Finally, you can automatically convert a property's type using `TypeConverter`s by specifying
a `TypeConverterAttribute`.

```csharp
// The following example indicates a required control matching the 'GenericDesktopPage.X'.
// It also converts the normal 0->1 range of values to -1->1 using the 'SignedConverter'.
[Control(GenericDesktopPage.X)]
[Required]
[TypeConverter(typeof(SignedConverter))]
public double X => GetValue<double>();

// The following example matches controls with the 'GenericDesktopPage.Select' in preference
// to those with 'ButtonPage.Button6', a match is not required.
// A default converter is registered for booleans already, which returns false for values < 0.5.
[Control(GenericDesktopPage.Select, Weight = 2)]
[Control(ButtonPage.Button6)]
public bool Select => GetValue<bool>();
```

To register a default type converter for control properties, use `Controller.RegisterDefaultTypeConverter`, e.g.

```csharp
// Note this registration occurs by default, but you can override it with a custom default converter.
Controller.RegisterDefaultTypeConverter(typeof(bool), BooleanConverter.Instance);
```

Once a device matches a controller, it exposes the latest values of the controller via easily accessed properties. You
can also observe changes via the `Changes` property. To listen for specific controllers from `Devices` use
the `Controllers<TController>` extension method, e.g.

```csharp
// Holds a reference to the current gamepad, which is set asynchronously as they are detected.
Gamepad? gamepad = null;
var batch = 0;

// Subscribe to any gamepads as they are found
using var subscription = devices.Controllers<Gamepad>().Subscribe(g =>
{
    // If we already have a connected gamepad, ignore any more.
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

# Migrating to Version 4

Until Version 4, the `HIDDevices.Usages` NuGet was not separate from the `HIDDevices` NuGet. This had the advantage of
much closer integration, however I decided to split the two for the following reasons:

1. The encoded tables are of use on their own in projects where the `HIDDevices` paradigm is not of interest.
2. The encoded tables take up a lot of code space, and may not be suitable for embedded projects, etc.

Although some features were removed due to the loose coupling, there is always a workaround available, largely due to
the ease of converting between the raw `uint` identifiers and the encoded types.

More specifically, the following changes were needed to separate the code bases:

* The [Gamepad](HIDDevices/Controllers/Gamepad.cs) controller now specifies the raw usage identifiers - this should be
  seamless to consumers of the class.
* The `Device` and `Control` classes `Usages` property is now of type `IReadOnlyCollection<uint>`. These raw identifiers
  can easily be cast to the `Usage` type to get further information.
* The `Control` class no longer exposes `Name`, `FullName`, or `ButtonNumber` properties; and, as a result, `ToString()`
  will no longer return a friendly name.

To support with migration, the following static methods have been added to the `Usage` type:

* `Usage.GetName(...)` now accepts one or more raw usage identifiers and returns one or more names (using the `Name` instance
  property).
* `Usage.GetFullName(...)` now accepts one or more raw usage identifiers and returns one or more full names (using
  the `FullName` instance property)..
* `Usage.GetButtonNumber(...)` now accepts one or more raw usage identifiers and returns the first button number, if any (
  using the `ButtonNumber` instance property)..

# TODO

* More documentation, examples
* Support Output to devices
* More Tests!
* Automate NuGet Release notes
* Automate code regeneration from GitHub Action.

## Testing status

The following controllers have been tested:

* Saitek X-52 Pro Flight Control System,
* Saitek Pro Flight X-56 Rhino Stick,
* Saitek Pro Flight X-56 Rhino Throttle,
* Razer Sabertooth Elite
* Microsoft XBox One for Windows Controller (_**Note** that XInput-compatible HID device driver only transmits events
  from the HID device whilst the current process has a focussed window, so console applications/background services
  don't appear to work! That is not usually an issue for games with a focused window, but it does affect the sample
  application. This is not a bug in this library._)

I have also tested the following OS's:

* Windows 10 Pro 2004 (19041.330)
* Windows 11 Pro 21H2 (10.0.22000.194)
* Ubuntu (limited testing so far)

Please let me know if you've confirmed it as working with other devices/OSs by raising an issue.

# Acknowledgements

* https://www.usb.org/documents - All USB Specifications
* https://github.com/IntergatedCircuits/hid-usage-tables - for easily parsed HID Usage tables, used until version 3.
* It makes extensive use of [HIDSharp](https://www.zer7.com/software/hidsharp) (© Copyright 2012, James F. Bellinger,
  licensed under Apache License 2.0) _although this may be replaced in future versions_
* [Reactive Extensions](https://github.com/dotnet/reactive)
* [Dynamic Data](https://github.com/reactiveui/DynamicData).
* [iTextSharp.LGPLv2.Core PDF library](https://github.com/VahidN/iTextSharp.LGPLv2.Core) - used to automatically extract the [JSON HID table](https://usb.org/hid) from the PDF
  specification in the version 3 generator.

