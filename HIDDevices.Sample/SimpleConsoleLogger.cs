// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

using System;
using System.Reactive.Disposables;
using Microsoft.Extensions.Logging;

namespace HIDDevices.Sample
{
    public class SimpleConsoleLogger : ILogger
    {
        public readonly string Name;

        public SimpleConsoleLogger(string name)
        {
            Name = name;
        }

        /// <inheritdoc />
        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            if (!IsEnabled(logLevel))
            {
                return;
            }

            var message = formatter(state, exception);

            if (!string.IsNullOrEmpty(message))
            {
                Console.WriteLine(message);
            }
        }

        /// <inheritdoc />
        public bool IsEnabled(LogLevel logLevel) => LogLevel <= logLevel;

        public LogLevel LogLevel { get; set; } = LogLevel.Information;

        /// <inheritdoc />
        public IDisposable BeginScope<TState>(TState state) => Disposable.Empty;
    }
}
