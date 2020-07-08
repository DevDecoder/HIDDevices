// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using HidSharp;

namespace HidControllers.Sample
{
    public class QuickTest //: IExample
    {
        /// <inheritdoc />
        public string FullName => nameof(QuickTest);

        /// <inheritdoc />
        public IReadOnlyCollection<string> ShortNames => new[] {"QT"};

        /// <inheritdoc />
        public async Task ExecuteAsync(CancellationToken token = default)
        {
            var device = DeviceList.Local.GetHidDeviceOrNull(1118, 767);
            await using var stream = device.Open();
            stream.ReadTimeout = Timeout.Infinite;

            var buffer = new byte[16];
            while (!token.IsCancellationRequested)
            {
                var read = await stream.ReadAsync(buffer, token).ConfigureAwait(false);
                Console.WriteLine($"Received {read} bytes: {string.Join(" ", buffer.Select(b => b.ToString("X2")))}");

            }
        }
    }
}
