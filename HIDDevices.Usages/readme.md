[![Publish](https://github.com/DevDecoder/HIDDevices/workflows/Build%20and%20Publish/badge.svg)](https://github.com/DevDecoder/HIDDevices/actions?query=workflow%3A%22Build+and+Publish%22)
[![Nuget](https://img.shields.io/nuget/v/HIDDevices.Usages)](https://www.nuget.org/packages/HIDDevices.Usages/)

# Description

This library provides a cross-platform .NET Standard encoding of the [the USB HID Usage Tables](https://usb.org/hid). It
is a companion NuGet for [HIDDevices](https://www.nuget.org/packages/HIDDevices/), though it can be used on it's own.

The latest USB specification PDF URL that was used for auto-generation can be found in
[HIDUsageTablesPDF.url](https://github.com/DevDecoder/HIDDevices/blob/master/HIDUsageTablesPDF.url), and the generated files found in
[this folder](https://github.com/DevDecoder/HIDDevices/tree/master/HIDDevices.Usages/Generated/HIDDevices.Generator/HIDDevices.Generator.UsagePageGenerator)
explicitly state the current specification and generation date in their headers.

Publishing an updated NuGet whenever the specification changes is relatively quick, as the build process
can download the raw PDF from [usb.org](https://usb.org) and generate new code automatically. Unfortunately, I do not
monitor the specifications for updates, so please [create an issue](https://github.com/DevDecoder/HIDDevices/issues) if
you would like to prompt me to update - I usually respond quickly.

### Usages

For convenience, the full HID Usage tables are exposed and described via the `Usages`, `UsagePages` and `UsageTypes`
classes. These can be retrieved directly using the `uint` identifier or the convenience enums, all of which have
the `Page` suffix.

```csharp
// The enums can be cast to a Usage to retrieve full information about the Usage and its page.
Usage usage = ButtonPage.Button0;
Console.WriteLine($"Usage: {usage.Name}; Page: {usage.Page.Name}");
```
