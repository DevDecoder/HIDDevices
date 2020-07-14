// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using HIDDevices.OLD;
using Microsoft.Extensions.Logging;

namespace HIDDevices
{
    public sealed class Event
    {
        private static readonly Dictionary<int, Event> s_all = new Dictionary<int, Event>();

        public static readonly Event RefreshFailure =
            new Event(nameof(Resources.RefreshFailure), nameof(Resources.RefreshFailureDescription));

        public static readonly Event DeviceCreationFailure = new Event(LogLevel.Warning, nameof(Resources
            .DeviceCreationFailure), nameof(Resources.DeviceCreationFailureDescription));

        public static readonly Event DeviceAdd = new Event(LogLevel.Information, nameof(Resources.DeviceAdd),
            nameof(Resources.DeviceAddDescription));

        public static readonly Event DeviceRemove = new Event(LogLevel.Information, nameof(Resources
            .DeviceRemove), nameof(Resources.DeviceRemoveDescription));

        public static readonly Event DeviceUpdate = new Event(LogLevel.Information, nameof(Resources
            .DeviceUpdate), nameof(Resources.DeviceUpdateDescription));

        public static readonly Event DeviceStreamStopped = new Event(nameof(Resources.DeviceStreamStopped),
            nameof(Resources.DeviceStreamStoppedDescription));

        public static readonly Event DeviceInputParseFailure =
            new Event(nameof(Resources.DeviceInputParseFailure),
                nameof(Resources.DeviceInputParseFailureDescription));

        private static readonly ResourceManager s_resourceManager =
            new ResourceManager($"{nameof(HIDDevices)}.Resources", typeof(Event).Assembly);

        private static int s_idCounter = 3500;

        private readonly string _descriptionResource;
        private readonly int _id;
        private readonly string _messageResource;

        public readonly LogLevel Level;

        private Event(string messageResource, string? descriptionResource = null)
            : this(LogLevel.Error, messageResource, descriptionResource)
        {
        }

        private Event(LogLevel level, string messageResource, string? descriptionResource = null)
        {
            _id = s_idCounter++;
            Level = level;
            _messageResource = messageResource;
            _descriptionResource = descriptionResource ?? messageResource;
            s_all[_id] = this;
        }

        public string Message => s_resourceManager.GetString(_messageResource);
        public string Description => s_resourceManager.GetString(_descriptionResource);
        public EventId Id => new EventId(_id, Description);

        public static IReadOnlyCollection<Event> All => s_all.Values;

        public static bool TryGet(int id, [MaybeNullWhen(false)] out Event? @event) =>
            s_all.TryGetValue(id, out @event);

        public static Event? Get(int id) => s_all.TryGetValue(id, out var @event) ? @event : null;

        internal static string GetString(string resourceName, CultureInfo? cultureInfo = null) =>
            s_resourceManager.GetString(resourceName, cultureInfo) ?? $"Unknown resource {resourceName}";

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Log(ILogger logger, params object[] args) => logger.Log(Level, Id, Message, args);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Log(ILogger logger, Exception? exception, params object[] args) =>
            logger.Log(Level, Id, exception, Message, args);

        /// <inheritdoc />
        public override string ToString() => Description;

        public static implicit operator EventId(Event @event) => @event.Id;
    }
}
