// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using DevDecoder.HIDDevices.Controllers;

namespace DevDecoder.HIDDevices;

/// <summary>
///     Class DeviceAttribute. This class cannot be inherited.
///     Attribute that can optionally be added to a <seealso cref="Controller" /> descendent to limit the
///     <seealso cref="Device">Devices</seealso>
///     that can be matched by the controller.
/// </summary>
/// <remarks>
///     Note that multiple usages can be supplied, any value that can be converted to a <see langref="uint" />
///     is supported, which includes the Usage enums. Further, the value must be the full ID, and encode
///     the page and ID of the usage.
/// </remarks>
/// <seealso cref="Controller" />
/// <seealso cref="Device" />
/// <seealso cref="Attribute" />
/// <remarks>
///     Initializes a new instance of the <see cref="DeviceAttribute" /> class.
/// </remarks>
/// <param name="usages">The usages, all of which must match.</param>
[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
public sealed class DeviceAttribute(params object[] usages) : Attribute
{
    private Regex? _releaseNumberRegex;

    /// <summary>
    ///     Gets a list of valid usages, of which the device must match all.
    /// </summary>
    /// <remarks>If alternative usages are to be supported, then multiple attributes can be added.</remarks>
    public IReadOnlyList<uint> Usages { get; } = usages
        .Select(Convert.ToUInt32)
        .ToArray();

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
            !Usages.All(usage => device.Usages.Contains(usage)))
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
