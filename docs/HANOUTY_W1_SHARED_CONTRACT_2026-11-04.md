# Hanouty W1 shared contracts — Architecture PR #95

Status: **proposed for cross-track acceptance**; bridge code exists, production MariaDB and WPF adapters are NOT wired yet. Superseded only by an explicit Issue #94 decision.

## Catalogue
`ICatalogueReader` returns `ProductSummary(ArticleId, Barcode, DisplayName, ImagePath, VariantId)` with stable nonempty ArticleId. ListAll includes all products, even without barcode/image. ImageProducts filters nonblank ImagePath; **Inventory must additionally verify that the image is actually available** before supplying that field (a path alone is not proof). Barcode can be empty. FindBarcode and RefreshBarcode return all matching variants, never silently pick the first; RefreshArticle looks up stable article ID. Duplicate IDs in ListAll are rejected. No SQL in WPF.

## Checkout
`CheckoutComposition` requires concrete catalogue, variant chooser, `IAtomicCheckoutBatchPort`, and `ICheckoutOperationJournal`. No empty/mock fallback. `CreateCheckoutBatch()` stages barcode/photo selections, revalidates identities and calls AddBatch once with stable operationId. Checkout owner implements **real** atomic cart/transaction semantics, durable unique operation ID, rollback and journal lookup; bridge cannot guarantee database atomicity. `Lookup(operationId)` returns Persisted, Absent or Unknown. Unknown must keep the UI blocked. Only Persisted/Absent can reconcile and unlock. Never auto-retry on thrown AddBatch. WPF must not generate a new operation ID for a timed-out submission.

## Ownership / acceptance
Inventory #88: MariaDB reader, image existence verification and legacy schema mapping. Checkout #75: transaction, deduplication, durable journal, pricing/stock, return. WPF #96: inject these real adapters in composition root and bind actual UI commands; no EmptyCatalogueReader/PreviewProductSelection in real sale. QA #93: isolated MariaDB, exact-SHA Windows .NET 10 end-to-end and power-loss/acknowledgement tests. Architecture #95: stable contracts, selection orchestration and integration safety; does not modify other tracks.

Acceptance W1 requires actual MariaDB → Application → WPF list/photo/barcode/variant interaction; W2 requires WPF → durable cart/payment/stock transaction. Bridge tests alone do not satisfy either gate. No main/release merge or real shop database access.

## WPF consumption checkpoint (Architecture PR #95, 2026-11-04)
Use the existing `CheckoutComposition` with concrete Inventory `ICatalogueReader`, WPF `ICheckoutVariantPrompt`, Checkout `IAtomicCheckoutBatchPort` and `ICheckoutOperationJournal`. Construct `var session = composition.CreateSession()` in the **actual WPF composition root**, not in a demo test. The session exposes `Products` and `ImageProducts` from the same validated catalogue snapshot; call `RefreshCatalogue()` after stock/catalogue changes. Call `Scan(barcode, quantity)` or `SelectImage(visibleProduct, quantity)`, then `Submit(stableOperationId)`. On a thrown write, do not retry or change ID: call `Reconcile()`; `Unknown` keeps the session locked. For `Invalidated`, explicitly `DiscardInvalidated()` before reselecting. Never use `EmptyCatalogueReader` or `PreviewProductSelection` in the real WPF sale path. No SQL in ViewModels.

This API is ready for integration, but WPF's actual call-site removal and isolated MariaDB end-to-end acceptance remain **unverified** until WPF and QA report their own exact SHAs and CI. `ImagePath` must represent an actually available image as guaranteed by Inventory; the bridge does not probe the filesystem.

## V1 quantity parity checkpoint
Repeated scans or image selections of the same stable ArticleId are aggregated into a single atomic checkout line with summed quantity, preserving first-selection order. Checked integer overflow aborts before calling the checkout port. This does not imply WPF production wiring or durable MariaDB acceptance.

## Architecture photo/variant consistency checkpoint (2026-11-04)
The existing `CheckoutComposition.CreateSession()` now checks an image tile against the current `ICatalogueReader.RefreshArticle(articleId)` row at selection and again immediately before atomic submission. It requires identical stable ArticleId, Barcode, VariantId and ImagePath, and an image still present. A changed photo/variant yields `InvalidCandidates` at selection or `Invalidated` before write; cashier explicitly calls `DiscardInvalidated()`, refreshes catalogue and reselects. The approved interface signatures remain unchanged. This protects UI staleness, **not** a substitute for the Checkout owner's transactional price/stock/authorization validation inside MariaDB. The reader must return a consistent current row, and WPF must call this session rather than a preview selection path.
