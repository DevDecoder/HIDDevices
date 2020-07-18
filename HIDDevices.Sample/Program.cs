// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

using System;
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

            ISample? sample;
            if (args.Length != 1 ||
                (sample = Array.Find(samples, s => s.ShortNames.Contains(args[0]))) is null)
            {
                var assemblyName = assembly.GetName().Name;
                // We appear to have a cry for help!
                Console.WriteLine(Resources.SampleExecutor, assemblyName);
                Console.WriteLine();

                do
                {
                    Console.WriteLine(Resources.SelectSample);

                    // Create instances of all sample classes
                    foreach (var s in samples)
                    {
                        Console.WriteLine(
                            Resources.SampleDescription, Environment.NewLine,
                            string.Join('|', s.ShortNames),
                            s.FullName,
                            s.Description);
                    }

                    if (!Environment.UserInteractive)
                    {
                        return;
                    }

                    var option = Console.ReadLine();
                    sample = Array.Find(samples, s => s.ShortNames.Contains(option));
                } while (sample is null);
            }

            Console.WriteLine(Resources.RunningSample, sample.FullName);
            Console.WriteLine();
            await sample.ExecuteAsync().ConfigureAwait(false);
        }
    }
}
