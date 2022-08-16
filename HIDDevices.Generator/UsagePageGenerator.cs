using System;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Text;

namespace HIDDevices.Generator
{
    [Generator]
    public class UsagePageGenerator : ISourceGenerator
    {
        public void Initialize(GeneratorInitializationContext context)
        {
            // TODO
        }

        private (Uri specificationUri, Uri jsonAttachmentUri, bool force)
            GetOptions(GeneratorExecutionContext context) =>
            (context.AnalyzerConfigOptions.GlobalOptions.TryGetValue("build_property.HIDUsageTablesPDF",
                 out var hidUsageTablesPdf) &&
             Uri.TryCreate(hidUsageTablesPdf, UriKind.RelativeOrAbsolute, out var p)
                    ? p
                    : new Uri(string.Empty, UriKind.Relative), context.AnalyzerConfigOptions.GlobalOptions.TryGetValue(
                                                                   "build_property.HIDUsageTablesJSON",
                                                                   out var hidUsageTablesJson) &&
                                                               Uri.TryCreate(hidUsageTablesJson, UriKind.Relative,
                                                                   out var j)
                    ? j
                    : new Uri(string.Empty, UriKind.Relative),
                context.AnalyzerConfigOptions.GlobalOptions.TryGetValue("build_property.GenerateUsagesFromSource",
                    out var generateUsagesFromSource) && bool.TryParse(generateUsagesFromSource,
                    out var generateUsagesFromSourceBool) &&
                generateUsagesFromSourceBool);

        public void Execute(GeneratorExecutionContext context)
        {
            var timestamp = DateTime.UtcNow;
            var (specificationUri, jsonAttachmentUri, force) = GetOptions(context);
            
            context.AddSource("dummy.cs", SourceText.From($@"
// Auto-generated at {timestamp:u}
// PDF: {specificationUri}
// JSON: {jsonAttachmentUri}
// force: {force}
 ", Encoding.UTF8));
        }
    }
}
