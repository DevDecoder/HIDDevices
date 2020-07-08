// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using HIDControllers.OLD;
using Microsoft.Extensions.Logging;

namespace HIDControllers
{
    public sealed class Event
    {
        private static readonly Dictionary<int, Event> s_all = new Dictionary<int, Event>();

        public static readonly Event RefreshFailure =
            new Event(nameof(Resources.RefreshFailure), nameof(Resources.RefreshFailureDescription));

        public static readonly Event ControllerCreationFailure = new Event(LogLevel.Warning, nameof(Resources
            .ControllerCreationFailure), nameof(Resources.ControllerCreationFailureDescription));

        public static readonly Event ControllerAdd = new Event(LogLevel.Information, nameof(Resources.ControllerAdd),
            nameof(Resources.ControllerAddDescription));

        public static readonly Event ControllerRemove = new Event(LogLevel.Information, nameof(Resources
            .ControllerRemove), nameof(Resources.ControllerRemoveDescription));

        public static readonly Event ControllerUpdate = new Event(LogLevel.Information, nameof(Resources
            .ControllerUpdate), nameof(Resources.ControllerUpdateDescription));

        public static readonly Event ControllerStreamStopped = new Event(nameof(Resources.ControllerStreamStopped),
            nameof(Resources.ControllerStreamStoppedDescription));

        public static readonly Event ControllerInputParseFailure =
            new Event(nameof(Resources.ControllerInputParseFailure),
                nameof(Resources.ControllerInputParseFailureDescription));

        private static readonly ResourceManager s_resourceManager =
            new ResourceManager($"{nameof(HIDControllers)}.Resources", typeof(Event).Assembly);

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
