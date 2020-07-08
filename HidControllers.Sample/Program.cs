// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HidControllers.Sample
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            var names = new HashSet<string>(args.Where(a => !string.IsNullOrWhiteSpace(a)),
                StringComparer.InvariantCultureIgnoreCase);

            foreach (var example in typeof(Program).Assembly
                .GetTypes()
                .Where(t => t.GetInterfaces().Contains(typeof(IExample)))
                .Select(Activator.CreateInstance)
                .Cast<IExample>()
                .Where(example => names.Count < 1 || example.ShortNames.Any(names.Contains)))
            {
                Console.Clear();
                Console.WriteLine($"Running {example.FullName}...");
                Console.WriteLine();
                await example.ExecuteAsync().ConfigureAwait(false);
            }
        }
    }
}
