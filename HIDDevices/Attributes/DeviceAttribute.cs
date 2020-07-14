// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HIDDevices
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public sealed class DeviceAttribute : Attribute
    {
        private Regex? _releaseNumberRegex;
        public DeviceAttribute(params uint[] usages) => Usages = usages;

        /// <summary>
        ///     Gets a list of valid usages, of which the device must match all.
        /// </summary>
        /// <remarks>If alternative usages are to be supported, then multiple attributes can be added.</remarks>
        public IReadOnlyList<uint> Usages { get; }

        /// <summary>
        ///     Gets or sets an optional Product ID; 0 if any ID is valid.
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        ///     Gets or sets an optional <see cref="Regex" /> to match a <see cref="Version" />; otherwise <see langword="null" />.
        /// </summary>
        public string? ReleaseNumberRegex { get; set; }

        internal bool Matches(Device device)
        {
            if ((ProductId > 0 && device.ProductId != ProductId) ||
                !Usages.All(usage => device.Usages.Contains((Usage)usage)))
            {
                return false;
            }

            var releaseNumberRegex = _releaseNumberRegex;
            if (releaseNumberRegex is null)
            {
                if (string.IsNullOrWhiteSpace(ReleaseNumberRegex))
                {
                    // No regex to match.
                    return true;
                }

                releaseNumberRegex = new Regex(ReleaseNumberRegex, RegexOptions.Compiled);
                _releaseNumberRegex = releaseNumberRegex;
            }

            return releaseNumberRegex.IsMatch(device.ReleaseNumber.ToString());
        }
    }
}
