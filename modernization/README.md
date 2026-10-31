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
