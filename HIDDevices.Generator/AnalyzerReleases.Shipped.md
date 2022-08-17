## Release 3.0

### New Rules

Rule ID | Category | Severity | Notes
--------|----------|----------|--------------------
HUT0001 | Generation | Info | Generation succeeded
HUT00FF | Generation | Error | Generation was cancelled
HUT1001 | Caching | Warning | Could not find/create HID Usage Table Caching folder.
HUT1002 | Caching | Warning | Caching disabled as cache file locations could not be determined.
HUT1003 | Caching | Error | PDF Not found
HUT2001 | Deserialization | Error | Deserialization of the JSON HID USage Tables failed.
HUT2002 | Deserialization | Error | JSON attachment not found in PDF file.
HUT2003 | Deserialization | Error | Error extracting JSON attachment from PDF file.

; See https://github.com/dotnet/roslyn-analyzers/blob/main/src/Microsoft.CodeAnalysis.Analyzers/ReleaseTrackingAnalyzers.Help.md for explanation