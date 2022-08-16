// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

using System.Runtime.CompilerServices;
using Microsoft.CodeAnalysis;

namespace HIDDevices.Generator;

public static class Diagnostics
{
    public static readonly DiagnosticDescriptor CacheFolderCreationFailed = new(
        "HUT1001",
        "Could not find/create HID Usage Table Caching folder",
        "Folder {0} could not be created: {1}",
        "Caching",
        DiagnosticSeverity.Warning,
        true);


    public static readonly DiagnosticDescriptor CachingDisabled = new(
        "HUT1002",
        "Caching disabled",
        "Caching disabled as cache file locations could not be determined",
        "Caching",
        DiagnosticSeverity.Warning,
        true);

    public static readonly DiagnosticDescriptor JsonDeserializationFailed = new(
        "HUT2001",
        "JSON Deserialization Failure",
        "Deserialization of the JSON HID USage Tables failed: {0}",
        "Deserialization",
        DiagnosticSeverity.Error,
        true);

    /// <summary>
    ///     Adds a <see cref="Diagnostic" /> to the users compilation based on a <see cref="DiagnosticDescriptor" />.
    /// </summary>
    /// <param name="context">The execution context.</param>
    /// <param name="descriptor">The diagnostic descriptor.</param>
    /// <param name="location"></param>
    /// <param name="messageArgs"></param>
    /// <remarks>
    ///     The severity of the diagnostic may cause the compilation to fail, depending on the <see cref="Compilation" />
    ///     settings.
    /// </remarks>
    /// <seealso cref="GeneratorExecutionContext.ReportDiagnostic(Diagnostic)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void Report(this GeneratorExecutionContext context, DiagnosticDescriptor descriptor,
        Location location, params object[] messageArgs)
        => context.ReportDiagnostic(Diagnostic.Create(descriptor, location, messageArgs));
}
