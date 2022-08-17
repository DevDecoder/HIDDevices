// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

using System;
using System.Runtime.CompilerServices;
using Microsoft.Extensions.Logging;

namespace DevDecoder.HIDDevices;

internal static class LoggingExtensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void Log(this ILogger logger, Event @event, params object[] args) => @event.Log(logger, args);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void Log(this ILogger logger, Event @event, Exception exception, params object[] args) =>
        @event.Log(logger, exception, args);
}
