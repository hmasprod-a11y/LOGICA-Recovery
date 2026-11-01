# LOGICA portable core — compile-only migration gate

This directory does **not** migrate the Windows POS or replace its .NET Framework 4.8 runtime.

The linked production source files compile under .NET 10 without WinForms, Bunifu,
Microsoft.VisualBasic, MySQL, or any recovered database. The smoke test runs on Linux
with test-only implementations of the cash and settlement compatibility ports.
No production data or configuration is loaded.

Modules covered: cash recount, client settlement, checkout posting, and the
catalogue duplicate precheck, and stock movement search/refresh. Legacy adapters and UI remain in the original
Windows project; all existing behavioral tests and Windows CI still apply.

Run locally with the .NET 10 SDK:
- `dotnet build modernization/LOGICA.CorePortability.csproj -c Release`
- `dotnet run --project modernization/LOGICA.CoreSmoke.csproj -c Release`

This proves source portability for the selected subset only. It is not evidence
that Bunifu, device drivers, printing, or the full POS run on modern .NET.

Catalogue creation, row mapping, promotion and required-field validation are now linked from the original production files. Legacy VB formatting, Trim, Val and decimal conversion remain in the Windows-only compatibility adapter. Portable smoke exercises the ordered creation workflow, partial writes, failure boundaries and validation; no production database is used.

The original EAN-13 twelve-digit checksum now uses the same catalogue compatibility port for VB per-character conversion; the eleven-digit suffix remains portable and unchanged. Both barcode paths are exercised in the Linux smoke and Windows characterization suite.

Checkout pricing/stock validation milestone: original production sources for amount guards, selection, basket consistency, tier pricing and stock shortage are now linked into the portable .NET 10 core. VB conversion and object comparison remain behind `ILegacyCheckoutSemantics` in Windows Infrastructure. The portable smoke uses a test-only port and isolated stock lookup; Windows characterization compares the actual VB adapter against original expressions across cultures. This does not change database transactions, the UI or POS licensing.


Checkout posting boundary milestone: the original Application orchestration now delegates
stock, ticket header/journal, and payment streams to three separate production services.
Each stage retains lazy enumeration and original exception timing. A Windows failure-injection
matrix checks every read/write/print/completion boundary and verifies that no subsequent
operation runs after a failure. The same production services are linked into .NET 10 Linux
and exercised without VB, WinForms, MySQL or Bunifu. Transaction commit/rollback, printing,
license, and actual shop database ownership remain in the original Windows form.

Shared Excel export milestone: the original client settlement and stock movement screens
now call a single WinForms/ClosedXML infrastructure adapter. Their DataTable projection
runs in the portable Application layer, retaining exact textbox type selection,
null-to-dash cell mutation, original column indexing, new-row handling and failure
order. The same production projection is linked into .NET 10 Linux smoke tests;
Windows CI separately exercises real XLSX output for both grid types. Neither
POS database writes nor licensing, activation, printing or UI layout changed.
