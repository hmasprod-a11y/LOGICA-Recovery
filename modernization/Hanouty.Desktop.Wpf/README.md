# Hanouty WPF .NET 10 desktop migration — first executable shell

This is a **separate, non-commercial preview executable**. It does not replace the existing LOGICA cashier or claim functional parity.

- C# / net10.0-windows / WPF / MVVM; no WinForms, VB runtime, Bunifu, or direct SQL dependencies.
- The catalogue list and live text filter are wired to a ViewModel, with an `ICatalogueReader` port.
- The current `EmptyCatalogueReader` intentionally returns no products. It never invents catalogue data or connects to a shop.
- The existing WinForms cashier remains the only functional checkout until the application-owned catalogue/checkout contracts are integrated.
- No sales, stock, payments, printing, reporting, licensing or real MariaDB writes are enabled.

Build on a Windows runner with .NET 10 SDK:

```powershell
dotnet build modernization/Hanouty.Desktop.Wpf/Hanouty.Desktop.Wpf.csproj -c Release
```

Next acceptance batch: agree on the shared application catalogue query contract with Track 03; implement a local read-only MariaDB adapter using the existing schema and disposable test database; prove product list includes all products and image grid only image-backed products. Then integrate barcode and basket application contracts with Track 02. QA owns exact-SHA Windows build, hardware acceptance, release integration and packaging. No main/release merge.
