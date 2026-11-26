# Role 04: FR_3C receipt summary

Baseline: PR93 `13eeabc55e2333f2c00c127d4e04b36520bbf88f`.
Branch: `feature/desktop-receipt-summary-20261118`.

## Production change

The existing `CatalogueHost.Financial.PrintCommittedSale` callback calls `LogicaCashReceiptPrinter.Print` after persistence. That printer now adds the original quantity and savings summary from the same `LogicaPostedTicket` used for its lines and total. No new posting, retry, database write, shared host change or parallel integration branch.

Original authority: `recovered-source/LOGICA/Form_3_VENTE.cs`, `CL_FR_3C_PrintPage` lines 13214–13236; `Text_TOTAL_NET_Click` lines 14557–14562. Article count is the sum of quantities (including fractions), not the number of rows. Savings are sum(unit price * quantity - net), displayed only when positive; percentage is savings/gross*100. Preserve VB FormatNumber/RSet and the workstation culture's decimal settings. Reject inconsistent positive savings with nonpositive gross before spooling.

The existing drawing code is extracted into `LogicaReceiptRenderer` without changing fonts, coordinates, logo or spacing. Both PrintPage and the acceptance preview call it. The newly added summary length can expose the existing single-page paper-height limitation; long receipts still need a separate pagination/paper-length batch.

## Verification

- Local Windows .NET 10.0.403: 17 assertions passed, French/English cultures configured with two decimal places; fractional counts, gross/net discounts independent of the Remise column, no discount, zero gross, negative savings, rounding, identity and cash-change formatting, invalid gross rejection.
- Financial Bootstrap build succeeded: 0 errors, 13 warnings (NuGet vulnerability metadata access and pre-existing nullable diagnostics).
- Production renderer bitmap inspected and shown in a WPF acceptance window. Evidence is synthetic: two lines, 2.5 units, gross 30 MAD, net 27 MAD, savings 3 MAD / 10%.
- This is NOT a cashier transaction or a physical-printer acceptance. No spooler, paper output, DB or store data touched by this fixture. Installed font substitution is visible in the preview; original Inconsolata fonts and paper geometry need device validation.

Run:

```powershell
dotnet run --project modernization/receipt-printing-acceptance -- evidence
# Add --show to inspect the same rendered image in a WPF window.
dotnet build modernization/Hanouty.Desktop.Bootstrap -m:1 -p:CheckoutProductionProject=<absolute-path>/modernization/checkout-mariadb-production/CheckoutMariaDbProduction.csproj
```

## Remaining

Supervisor review/integration and exact integrated CI; real saved discounted sale through WPF and physical USB printer with original fonts/paper; QR option, other ticket templates, serial routes and long-receipt pagination remain outside this batch. No numeric input was added, so this batch does not claim numeric-keypad completion. Customer settlement remains exclusively with the supervisor.
