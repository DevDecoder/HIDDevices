// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

using System;
using System.Collections;
using System.Collections.Generic;
using HidSharp.Reports;

namespace HIDControllers.Controls
{
    public abstract class Control : IReadOnlyList<Axis>
    {
        protected Control(Controller controller) => Controller = controller;

        public abstract IObservable<IList<ControlChange>> Changes { get; }

        public Controller Controller { get; }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        public abstract string Name { get; }

        /// <inheritdoc />
        public abstract IEnumerator<Axis> GetEnumerator();

        /// <inheritdoc />
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        /// <inheritdoc />
        public abstract int Count { get; }

        /// <inheritdoc />
        public abstract Axis this[int index] { get; }

        internal static Axis Create(Controller controller, Usage usage, DataItem dataItem) =>
            AxisType.TryGet(usage, out var type)
                ? type.Create(controller, dataItem)
                : throw new NotSupportedException($"The {usage} usage is not supported!");
    }
}
