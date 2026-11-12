# HANOUTY net10 Architecture — legacy source dependency ledger (2026-11-05)

This ledger describes **compile-time linked source**, not a WinForms runtime requirement. The production target is an offline WPF/net10 host with local MariaDB. The original WinForms/net48 application remains a behavioral reference, never a release substitute.

## Production dependency chain

| Legacy source / boundary | net10 consumer | WPF consumer | Owner | Executable proof needed | Minimal removal |
|---|---|---|---|---|---|
| `Application/Checkout/CheckoutSelectionFlowService.cs`, barcode, image, variant snapshot and tile selection | `Hanouty.ArchitectureBridge` through `CoreSources.ArchitectureBridge.props` | `ProductionWpfProductSelection` via `CheckoutSession` | 01 architecture contract; 02 recovered Checkout source | ArchitectureBridge build, adapter tests, Windows WPF selection tests on one SHA | Move canonical, behavior-tested selection rules into shared net10 Core without forking types; remove linked legacy source only after parity |
| `Application/Checkout/CheckoutPosting*.cs`, transaction boundary, payment and stock posting | ArchitectureBridge legacy source link; **not** permission to write payments | `ProductionWpfCheckoutSubmission` delegates to `CheckoutSession.Submit` | 02 Checkout financial transaction; 01 boundary | Real isolated MariaDB atomic ticket/payment/journal/stock, exact-once and Unknown recovery | Keep single `IAuthorizedCheckoutPort` and `IAtomicCheckoutBatchPort` integration; remove linked posting source after net10 financial tests |
| `Application/Catalogue/CatalogueRowMapper.cs`, `CollectionDuplicatePrecheck.cs`, catalogue domain rules | ArchitectureBridge shared compile; Inventory real reader separately | `ProductionWpfCatalogueReader` maps one `CheckoutSession.Products` snapshot | 03 Inventory source; 01 graph | Strict nullable net10 compile, MariaDB reader, WPF list/photo/duplicate tests | Migrate mapper and validation to canonical shared Core/Inventory; no duplicate WPF DTO |
| `Application/Checkout/StockValidationModels.cs`, `StockValidationService.cs` | ArchitectureBridge shared compile | Submission through existing financial gate | 02 Checkout source; 03 stock policy | Strict net10 compile + isolated MariaDB rollback/stock contention | Migrate to typed modern stock boundary after V1 behavior characterization |
| `Application/Clients/*`, `Application/Cash/*`, `Domain/ILegacy*Semantics.cs` | ArchitectureBridge shared compile | No proved complete customer/cash-report WPF path | 01 boundary, 02 financial parity, 03 commercial operations | Domain characterization + WPF end-to-end workflows | Extract business rules into Core; preserve V1 reference until complete parity |
| `Infrastructure/Checkout/*Sql.cs`, `Infrastructure/Inventory/StockMovementQueryText.cs` | ArchitectureBridge source links | No direct WPF SQL access permitted | 02/03 infrastructure | Isolated MariaDB SQL and rollback tests | Consolidate SQL in canonical production MariaDB adapters |

## Confirmed compiler compatibility blocker

QA run `42009829541` job `127185718793` failed compiling the linked legacy files as net10 with `Nullable=enable`: CS860x/CS8618 in CatalogueRowMapper, StockValidationModels, CheckoutSelectionFlowService, CheckoutVariantSnapshotService, etc. Subsequent QA run `42014640733` job `127201981998` revealed that adding `#nullable enable` directly to old shared files breaks the older Domain characterization compiler (CS1024/CS1025 and syntax errors). Both compilers must pass **on the same reviewed source SHA**. Never suppress nullable diagnostics globally, never edit Checkout-owned files from Cell01 without agreement, and never treat a green legacy ZIP as WPF commercial acceptance.

## Integration invariants

- `WPF -> Architecture adapter -> ArchitectureBridge -> canonical Checkout/Inventory`; **never WPF -> Adapter -> WPF circular project reference**.
- Product selection only stages; durable operation ID is retained across uncertain outcomes; Unknown remains fail-closed.
- No second host, checkout session, authorization gate, DTO identity mapping or payment journal.
- Acceptance requires WPF net10 EXE on disposable local MariaDB, same-SHA Windows compile, financial exact-once/rollback/Unknown tests, and QA sign-off; `W2Accepted=false` until then.
