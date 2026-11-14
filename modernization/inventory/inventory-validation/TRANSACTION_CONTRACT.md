# Inventory validation transaction — verified legacy mapping and safety gate

Source inspected: `recovered-source/LOGICA/Form_6_INVENTAIRES.cs` on PR#88 at `29f7ba59ad1a5ebcfa3327d3b673052bbdb79825`.

## Legacy behavior to preserve (NOT permission provenance)

The legacy validate handler begins `MySqlTransaction` on `Module1.cn_SQL` and, for each `DataGrid_BODY` row, sets `TABLE_ARTICLES.STOCK` and `STOCK_INITIAL` to `Stock_Physique` and `DATE_INVENTAIRE` to the selected date; inserts a `TABLE_MOUVEMENTS_STOCK` row labelled `Inventaire`; then sets `ETAT='VALIDER'` for matching `TABLE_INVENTAIRES_ENTETE` and `TABLE_INVENTAIRES_DETAILS`. Legacy SQL concatenates row values and does not establish the trusted actor/grant mapping.

## Production transaction contract (not activated)

1. Trusted authenticated session issues an immutable actor identity and an explicitly approved **inventory-validation capability**. UI labels, user-supplied actor IDs, global booleans and `ADMIN`/`MODIF_QTE` name guesses are not proof. Missing/expired/revoked/ambiguous capability **denies before writing**.
2. Start a single InnoDB transaction on the dedicated Inventory connection, not Checkout's writer. Lock the inventory header and all covered article rows with `SELECT ... FOR UPDATE` in deterministic article-ID order. Reject already validated header, duplicate/missing/unknown IDs, negative physical quantities and concurrent changes.
3. Re-read authoritative count detail lines and recorded baseline **inside the same transaction**. Reuse the semantics of `StockCountCoverageService.Compare` and `StockCountFreshnessService.Compare`: require full coverage and fresh baseline for **all articles including zero-delta lines**. Previews outside transaction are informational only.
4. Update each article's stock, initial stock and date; insert its movement with original/physical quantities and verified actor provenance. Parameterize all SQL and require exactly one affected article per stable ID.
5. Set header and detail validation state to `VALIDER` only after all writes succeed; require exact affected counts, commit once. Any error rolls back article stock, movements, header and details together. Duplicate/retry must not post twice.
6. Re-query all tables after commit in disposable MariaDB; verify rollback on stale/unknown/partial count, missing capability, duplicate validation and injected IDs. Do not accept legacy WinForms behavior as evidence of WPF production readiness.

## Existing reusable services

- `recovered-source/LOGICA/Application/Inventory/StockCountCoverageService.cs`
- `recovered-source/LOGICA/Application/Inventory/StockCountFreshnessService.cs`
- `recovered-source/LOGICA/Application/Inventory/StockCountAdjustmentProposalService.cs`

These are internal legacy C# helpers and **not** a production .NET10 DB writer. The authoritative session/capability mapping and target schema contract must be approved by Architecture/QA before any live validation endpoint is registered. Do not reuse the manual stock adjustment authorization merely by renaming its permission. No Checkout stock writer changes.

## QA93 selective handoff

This document is an audited mapping and fail-closed implementation contract only. It contains no executable transaction and claims no SQL acceptance. Cell03 owns the new inventory transaction; QA93 alone integrates reviewed production code when the authorization contract is approved.
