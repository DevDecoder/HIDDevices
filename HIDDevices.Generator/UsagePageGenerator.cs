// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using Microsoft.CodeAnalysis;
using Newtonsoft.Json;

namespace HIDDevices.Generator;

[Generator]
public class UsagePageGenerator : ISourceGenerator
{
    private static readonly Uri s_emptyUri = new(string.Empty, UriKind.Relative);

    public void Initialize(GeneratorInitializationContext context)
    {
        // Nothing required.
    }

    public void Execute(GeneratorExecutionContext context)
    {
        var timestamp = DateTime.UtcNow;

        // Get the generation folder
        Debugger.Launch();

        // Get options
        var (specificationUri, jsonAttachmentUri, cacheFolder, projectDir, force) = GetOptions(context);

        // Try to get absolute Uri for cacheFolder
        var cache = cacheFolder.IsAbsoluteUri;
        if (!cache)
        {
            // Try to combine them into an absolute uri
            cache = projectDir.IsAbsoluteUri &&
                    cacheFolder != s_emptyUri &&
                    Uri.TryCreate(Path.Combine(projectDir.AbsolutePath, cacheFolder.OriginalString), UriKind.Absolute,
                        out cacheFolder);
        }

        // Check if caching folder already exists.
        if (cache && !Directory.Exists(cacheFolder.AbsolutePath))
        {
            try
            {
                // Try to create the folder
                Directory.CreateDirectory(cacheFolder.AbsolutePath);
            }
            catch (Exception exception)
            {
                context.Report(Diagnostics.CacheFolderCreationFailed, Location.None, cacheFolder, exception);
                cache = false;
            }
        }

        // Get absolute paths for cache files
        var cacheJson = s_emptyUri;
        var cachePdf = s_emptyUri;
        cache &= jsonAttachmentUri != s_emptyUri &&
                 specificationUri != s_emptyUri &&
                 Uri.TryCreate(Path.Combine(cacheFolder.AbsolutePath, jsonAttachmentUri.OriginalString),
                     UriKind.Absolute, out cacheJson) &&
                 Uri.TryCreate(Path.Combine(cacheFolder.AbsolutePath, Path.GetFileName(specificationUri.LocalPath)),
                     UriKind.Absolute, out cachePdf);

        // If we aren't caching, we must go to the original source.
        if (!cache)
        {
            // Blank caching file locations
            cacheJson = s_emptyUri;
            cachePdf = s_emptyUri;
            force = true;
            context.Report(Diagnostics.CachingDisabled, Location.None);
        }

        var tables = HidUsageTables.Empty;
        if (!force)
        {
            if (File.Exists(cacheJson.AbsolutePath))
            {
                // Load from the cached JSON.
                tables = LoadFromJson(context, cacheJson, context.CancellationToken);
            }
            else if (File.Exists(cachePdf.AbsolutePath))
            {
                tables = LoadFromPdf(context, cachePdf, cacheJson, context.CancellationToken);
            }
        }

        if (tables == HidUsageTables.Empty)
        {
            // Load from source, updating Cache if appropriate
            throw new NotImplementedException();
        }

        // TODO At this point we should have loaded the tables variable!!!
    }

    /// <summary>
    ///     Grabs various configuration options from build properties.
    /// </summary>
    /// <param name="context"></param>
    /// <returns></returns>
    private (Uri specificationUri, Uri jsonAttachmentUri, Uri cacheFolder, Uri projectDir, bool force)
        GetOptions(GeneratorExecutionContext context) =>
        (context.AnalyzerConfigOptions.GlobalOptions.TryGetValue("build_property.HIDUsageTablesPDF",
             out var hidUsageTablesPdf) &&
         Uri.TryCreate(hidUsageTablesPdf, UriKind.RelativeOrAbsolute, out var p)
                ? p
                : s_emptyUri,
            context.AnalyzerConfigOptions.GlobalOptions.TryGetValue("build_property.HIDUsageTablesJSON",
                out var hidUsageTablesJson) &&
            Uri.TryCreate(hidUsageTablesJson, UriKind.Relative, out var j)
                ? j
                : s_emptyUri,
            context.AnalyzerConfigOptions.GlobalOptions.TryGetValue("build_property.HIDUsageTablesCacheFolder",
                out var hidUsageTablesCacheFolder) &&
            Uri.TryCreate(hidUsageTablesCacheFolder, UriKind.RelativeOrAbsolute, out var c)
                ? c
                : s_emptyUri,
            context.AnalyzerConfigOptions.GlobalOptions.TryGetValue(
                "build_property.projectdir",
                out var pd) &&
            Uri.TryCreate(pd, UriKind.Absolute, out var pdu)
                ? pdu
                : Uri.TryCreate(Directory.GetCurrentDirectory(), UriKind.Absolute, out pdu)
                    ? pdu
                    : s_emptyUri,
            context.AnalyzerConfigOptions.GlobalOptions.TryGetValue("build_property.GenerateUsagesFromSource",
                out var generateUsagesFromSource) &&
            bool.TryParse(generateUsagesFromSource, out var generateUsagesFromSourceBool) &&
            generateUsagesFromSourceBool);

    /// <summary>
    ///     Loads Json from a cached PDF (and updates the cached JSON).
    /// </summary>
    /// <param name="context">The execution context.</param>
    /// <param name="pdfUri">The PDF cache file URI.</param>
    /// <param name="jsonUri">The JSON cache file URI.</param>
    /// <param name="cancellationToken">The <see cref="CancellationToken" />.</param>
    private HidUsageTables LoadFromPdf(GeneratorExecutionContext context, Uri pdfUri, Uri jsonUri,
        CancellationToken cancellationToken) =>
        throw new NotImplementedException();

    /// <summary>
    ///     Loads Json from a cached file.
    /// </summary>
    /// <param name="context">The execution context.</param>
    /// <param name="jsonUri">The JSON cache file URI.</param>
    /// <param name="contextCancellationToken"></param>
    /// <param name="cancellationToken">The <see cref="CancellationToken" />.</param>
    private HidUsageTables LoadFromJson(GeneratorExecutionContext context, Uri jsonUri,
        CancellationToken cancellationToken)
    {
        try
        {
            using var pdfFileStream = File.OpenRead(jsonUri.AbsolutePath);
            using var reader = new StreamReader(pdfFileStream);
            return JsonConvert.DeserializeObject<HidUsageTables>(reader.ReadToEnd()) ??
                   throw new NullReferenceException("The deserialization of JSON returned null.");
        }
        catch (Exception exception)
        {
            context.Report(Diagnostics.JsonDeserializationFailed, Location.None, exception);
            return HidUsageTables.Empty;
        }
    }

    /// <summary>
    ///     Loads Json from a stream.
    /// </summary>
    /// <param name="context">The execution context.</param>
    /// <param name="jsonStream">The JSON stream.</param>
    /// <param name="cancellationToken">The <see cref="CancellationToken" />.</param>
    private void Load(GeneratorExecutionContext context, Stream jsonStream,
        CancellationToken cancellationToken)
    {
    }
}
