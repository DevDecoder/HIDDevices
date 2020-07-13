// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HIDDevices.Sample
{
    public abstract class Sample : ISample
    {
        private readonly HashSet<string> _shortNames;

        protected Sample(string? fullName = null, params string[] shortNames)
        {
            FullName = fullName ?? GetFullName(GetType().Name);

            _shortNames = shortNames.Length > 0 ? new HashSet<string>(shortNames) : GetShortNames(FullName);
        }

        /// <inheritdoc />
        public string FullName { get; }

        /// <inheritdoc />
        public IReadOnlyCollection<string> ShortNames => _shortNames;

        /// <inheritdoc />
        public virtual Task ExecuteAsync(CancellationToken token = default) => Task.Run(Execute, token);

        /// <inheritdoc />
        public abstract string Description { get; }

        /// <summary>
        ///     Execute the example synchronously.
        /// </summary>
        protected virtual void Execute() { }

        /// <summary>
        ///     Gets a friendly full name
        /// </summary>
        /// <param name="typeName"></param>
        /// <returns></returns>
        protected static string GetFullName(string typeName)
        {
            var builder = new StringBuilder(typeName.Length + 5);
            var first = true;
            foreach (var c in typeName)
            {
                if (first)
                {
                    first = false;
                }
                else if (char.IsUpper(c))
                {
                    builder.Append(' ');
                }

                builder.Append(c);
            }

            var fullName = builder.ToString();
            if (fullName.EndsWith("Sample", StringComparison.InvariantCultureIgnoreCase))
            {
                fullName = fullName[..^6].TrimEnd();
            }

            return fullName;
        }

        /// <summary>
        ///     Gets some short names based on the first word and initials.
        /// </summary>
        /// <param name="fullName">The full name of the sample.</param>
        /// <returns>An array of short names.</returns>
        protected static HashSet<string> GetShortNames(string fullName)
        {
            var shortNames = new HashSet<string>(StringComparer.InvariantCultureIgnoreCase);
            var initials = new StringBuilder();
            var word = new StringBuilder();
            var titleCase = new StringBuilder();
            var afterSpace = true;
            var firstWord = true;
            foreach (var c in fullName)
            {
                if (char.GetUnicodeCategory(c) == UnicodeCategory.SpaceSeparator)
                {
                    afterSpace = true;
                    firstWord = false;
                    continue;
                }

                if (afterSpace)
                {
                    afterSpace = false;
                    var ch = char.ToUpperInvariant(c);
                    initials.Append(ch);
                    titleCase.Append(ch);
                }
                else
                {
                    titleCase.Append(c);
                }

                if (firstWord)
                {
                    word.Append(c);
                }
            }

            shortNames.Add(initials.ToString(0, 1));
            if (initials.Length > 1)
            {
                shortNames.Add(initials.ToString());
            }

            shortNames.Add(word.ToString());

            if (titleCase.Length < 10)
            {
                shortNames.Add(titleCase.ToString());
            }

            return shortNames;
        }
    }
}
