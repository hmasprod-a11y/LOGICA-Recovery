# Hanouty W1 shared contracts — Architecture PR #95

Status: **proposed for cross-track acceptance**; bridge code exists, production MariaDB and WPF adapters are NOT wired yet. Superseded only by an explicit Issue #94 decision.

## Catalogue
`ICatalogueReader` returns `ProductSummary(ArticleId, Barcode, DisplayName, ImagePath, VariantId)` with stable nonempty ArticleId. ListAll includes all products, even without barcode/image. ImageProducts filters nonblank ImagePath; **Inventory must additionally verify that the image is actually available** before supplying that field (a path alone is not proof). Barcode can be empty. FindBarcode and RefreshBarcode return all matching variants, never silently pick the first; RefreshArticle looks up stable article ID. Duplicate IDs in ListAll are rejected. No SQL in WPF.

## Checkout
`CheckoutComposition` requires concrete catalogue, variant chooser, `IAtomicCheckoutBatchPort`, and `ICheckoutOperationJournal`. No empty/mock fallback. `CreateCheckoutBatch()` stages barcode/photo selections, revalidates identities and calls AddBatch once with stable operationId. Checkout owner implements **real** atomic cart/transaction semantics, durable unique operation ID, rollback and journal lookup; bridge cannot guarantee database atomicity. `Lookup(operationId)` returns Persisted, Absent or Unknown. Unknown must keep the UI blocked. Only Persisted/Absent can reconcile and unlock. Never auto-retry on thrown AddBatch. WPF must not generate a new operation ID for a timed-out submission.

## Ownership / acceptance
Inventory #88: MariaDB reader, image existence verification and legacy schema mapping. Checkout #75: transaction, deduplication, durable journal, pricing/stock, return. WPF #96: inject these real adapters in composition root and bind actual UI commands; no EmptyCatalogueReader/PreviewProductSelection in real sale. QA #93: isolated MariaDB, exact-SHA Windows .NET 10 end-to-end and power-loss/acknowledgement tests. Architecture #95: stable contracts, selection orchestration and integration safety; does not modify other tracks.

Acceptance W1 requires actual MariaDB → Application → WPF list/photo/barcode/variant interaction; W2 requires WPF → durable cart/payment/stock transaction. Bridge tests alone do not satisfy either gate. No main/release merge or real shop database access.
