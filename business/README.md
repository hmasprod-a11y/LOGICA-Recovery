# Hanouty business operations: isolated preview boundary

This is a **new opt-in**, read-only business layer. It does **not** replace or invoke LOGICA's working purchase/stock workflows. No SQL, WinForms, MySQL connector, migration, stock mutation or license changes are included. The new catalogue validation is a snapshot check, not a transactional consistency guarantee.

- `PurchaseReceiptPreviewService`: validates a supplier receipt and aggregates quantities/cost by exact `ID_ARTICLE` identity (not barcode), preserving duplicate-barcode variants and fractional decimal values. A conflicting barcode for one ID fails closed.
- `StockCountVarianceService`: compares physical counts with recorded stock, separately reporting shortage and surplus without adjusting stock. Negative *recorded* stock is allowed because it may exist in legacy data; negative physical counts are rejected.
- `StockCountCoverageService`: compares a physical stocktake against an authoritative catalogue snapshot by exact article ID, reporting missing and unknown articles explicitly. An uncounted product is **never** treated as counted zero; `IsComplete` is false until every baseline ID is accounted for and no unknown ID exists. This is preview-only and does not authorize posting.
- `PurchaseReceiptCatalogueValidationService`: compares an already validated receipt against a caller-supplied authoritative catalogue snapshot by exact `ID_ARTICLE`, detecting unknown IDs and changed barcodes. Duplicate barcodes across different IDs are valid; duplicate catalogue IDs fail closed. This check is advisory until a reviewed integration owns the transaction and revalidation boundary.
- `StockCountAdjustmentProposalService`: produces read-only, non-zero adjustment deltas only when the full baseline is physically counted and no unknown articles remain. A proposal is not an authorization or database command.
- All services return read-only snapshots. Nothing is committed. Integration with the real purchase UI/database requires a separate, reviewed design and isolated MariaDB tests. Re-read authoritative catalogue and stock inside the final posting transaction before committing; these previews cannot establish a lock or guarantee freshness.

Regression gates:
- Windows/.NET Framework compiler: `powershell -File scripts/test-catalogue-core.ps1` (included in existing Domain characterization workflow).
- .NET 10: `dotnet run --project business/Hanouty.BusinessOperations.Smoke.csproj -c Release`.

**Coordination request to QA / Modern Core owners:** please add the standalone .NET 10 command to a future shared Linux CI workflow after review. Do not edit `modernization/CoreSources.props` or shared workflows from Track B. Do not claim MariaDB integration: this preview has no database adapter.
