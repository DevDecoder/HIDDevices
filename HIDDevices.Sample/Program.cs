// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace HIDDevices.Sample
{
    internal static class Program
    {
        private static async Task Main(string[] args)
        {
            var assembly = Assembly.GetExecutingAssembly();

            var samples = assembly
                .GetTypes()
                .Where(t => !t.IsAbstract &&
                            (t.IsValueType ||
                             (t.GetInterfaces().Contains(typeof(ISample)) &&
                              t.GetConstructor(Type.EmptyTypes) != null)))
                .Select(Activator.CreateInstance)
                .OfType<ISample>()
                .ToArray();

            ISample sample;
            if (args.Length != 1 ||
                (sample = samples.FirstOrDefault(s => s.ShortNames.Contains(args[0]))) is null)
            {
                var assemblyName = assembly.GetName().Name;
                var location = Path.GetFileName(assembly.Location) ?? assemblyName;
                // We appear to have a cry for help!
                Console.WriteLine($"{assemblyName} - Sample executor - Help");
                Console.WriteLine();

                // Create instances of all sample classes
                foreach (var s in samples)
                {
                    Console.WriteLine($"  {location} [{string.Join('|', s.ShortNames)}]");
                    Console.WriteLine($"    {s.FullName}");
                    Console.WriteLine($"    {s.Description}");
                    Console.WriteLine();
                }

                return;
            }

            Console.WriteLine($"Running {sample.FullName}...");
            Console.WriteLine();
            await sample.ExecuteAsync().ConfigureAwait(false);
        }
    }
}
