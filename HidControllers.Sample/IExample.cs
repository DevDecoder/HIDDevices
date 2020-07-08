// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace HidControllers.Sample
{
    public interface IExample
    {
        string FullName { get; }
        IReadOnlyCollection<string> ShortNames { get; }
        Task ExecuteAsync(CancellationToken token = default);
    }
}
