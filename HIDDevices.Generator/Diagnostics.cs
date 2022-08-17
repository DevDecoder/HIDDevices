// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.CodeAnalysis;

namespace HIDDevices.Generator;

public static class Diagnostics
{
    // ReSharper disable ArrangeObjectCreationWhenTypeEvident - See https://github.com/dotnet/roslyn-analyzers/issues/5957
#pragma warning disable IDE0090 // Use 'new(...)'
    public static readonly DiagnosticDescriptor Cancelled = new DiagnosticDescriptor(
        "HUT0001",
        "Cancelled",
        "Generation was cancelled",
        "Generation",
        DiagnosticSeverity.Error,
        true);

    public static readonly DiagnosticDescriptor CacheFolderCreationFailed = new DiagnosticDescriptor(
        "HUT1001",
        "Could not find/create HID Usage Table Caching folder",
        "Folder {0} could not be created: {1}",
        "Caching",
        DiagnosticSeverity.Warning,
        true);


    public static readonly DiagnosticDescriptor CachingDisabled = new DiagnosticDescriptor(
        "HUT1002",
        "Caching disabled",
        "Caching disabled as cache file locations could not be determined",
        "Caching",
        DiagnosticSeverity.Warning,
        true);

    public static readonly DiagnosticDescriptor JsonDeserializationFailed = new DiagnosticDescriptor(
        "HUT2001",
        "JSON Deserialization Failure",
        "Deserialization of the JSON HID USage Tables failed: {0}",
        "Deserialization",
        DiagnosticSeverity.Error,
        true);

    public static readonly DiagnosticDescriptor JsonAttachmentNotFound = new DiagnosticDescriptor(
        "HUT2002",
        "JSON attachment not found in PDF file",
        "Could not find the JSON attachment in '{0}'",
        "Deserialization",
        DiagnosticSeverity.Error,
        true);

    public static readonly DiagnosticDescriptor JsonExtractionFailed = new DiagnosticDescriptor(
        "HUT2003",
        "Error extracting JSON attachment from PDF file",
        "Extracting the JSON attachment from '{0}' failed: {1}",
        "Deserialization",
        DiagnosticSeverity.Error,
        true);
    // ReSharper restore ArrangeObjectCreationWhenTypeEvident
#pragma warning restore IDE0090 // Use 'new(...)'

    /// <summary>
    ///     Adds a <see cref="Diagnostic" /> to the users compilation based on a <see cref="DiagnosticDescriptor" />.
    /// </summary>
    /// <param name="context">The execution context.</param>
    /// <param name="descriptor">The diagnostic descriptor.</param>
    /// <param name="location"></param>
    /// <param name="messageArgs"></param>
    /// <remarks>
    ///     The severity of the diagnostic may cause the compilation to fail, depending on the <see cref="Compilation" />
    ///     settings.
    /// </remarks>
    /// <seealso cref="GeneratorExecutionContext.ReportDiagnostic(Diagnostic)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void Report(this GeneratorExecutionContext context, DiagnosticDescriptor descriptor,
        Location location, params object[] messageArgs)
        => context.ReportDiagnostic(Diagnostic.Create(descriptor, location, messageArgs));

    /// <summary>
    ///     Get's a C#-safe version of a name.
    /// </summary>
    /// <param name="unsafe"></param>
    /// <returns></returns>
    public static string GetSafe(this string @unsafe)
    {
        // Create safe name
        var builder = new StringBuilder(@unsafe.Length);
        var afterSpace = true;
        foreach (var ch in @unsafe)
        {
            switch (char.GetUnicodeCategory(ch))
            {
                case UnicodeCategory.UppercaseLetter:
                case UnicodeCategory.LowercaseLetter:
                case UnicodeCategory.TitlecaseLetter:
                case UnicodeCategory.ModifierLetter:
                case UnicodeCategory.OtherLetter:
                    // Always allowed in C# class names
                    break;

                case UnicodeCategory.ConnectorPunctuation:
                    // Language specification allows '_' as first character.
                    if (builder.Length < 1 && ch != '_')
                    {
                        continue;
                    }

                    break;

                case UnicodeCategory.LetterNumber:
                case UnicodeCategory.NonSpacingMark:
                case UnicodeCategory.SpacingCombiningMark:
                case UnicodeCategory.DecimalDigitNumber:
                case UnicodeCategory.Format:
                    // Only valid after first character, so add a '_' prefix.
                    if (builder.Length < 1)
                    {
                        builder.Append('_');
                    }

                    break;

                case UnicodeCategory.SpaceSeparator:
                    afterSpace = true;
                    continue;
                default:
                    // Skip characters
                    continue;
            }

            char c;
            if (afterSpace)
            {
                afterSpace = false;
                c = char.ToUpperInvariant(ch);
            }
            else
            {
                c = ch;
            }

            builder.Append(c);
        }

        return builder.ToString();
    }

    public static IndentStringBuilder AppendComment(this IndentStringBuilder builder, string comment,
        bool cStyle = false)
    {
        if (cStyle)
        {
            builder.AppendLine("/*").Indent(" *").AppendLine(comment).Outdent().AppendLine(" */");
        }
        else
        {
            builder.Indent("// ").AppendLine(comment).Outdent();
        }

        return builder;
    }

    public static IndentStringBuilder AppendSummary(this IndentStringBuilder builder, string comment)
        => builder.Indent("// ").AppendLine("<summary>").Indent().AppendLine(comment).Outdent().AppendLine("</summary>")
            .Outdent();

    public static IndentStringBuilder AppendDescription(this IndentStringBuilder builder, string description)
        => builder.Append("[Description(").AppendQuoted(description).AppendLine(")]");

    public static IndentStringBuilder OpenBrace(this IndentStringBuilder builder)
        => builder.AppendLine("{").Indent();

    public static IndentStringBuilder CloseBrace(this IndentStringBuilder builder)
        => builder.Outdent().AppendLine("}");
}
