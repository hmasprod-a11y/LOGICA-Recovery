# Cell03 — multi-article purchase receipt quantity contract (proposal, awaiting BC approval)

Ownership: Cell03 PR#88. BC creation and integration: supervisor/QA PR#93. **Do not edit** PurchaseReceiptValidation, PurchaseReceiptDialog or Bootstrap. This file is a read-only design/test contract, **not** a receipt posting command.

## Existing reusable evidence (PR#88 HEAD 8016be3260c2b7433b2b1f2b201fa1e03e3fdc09)

- `PurchaseOrderReceiptReconciliationService.Compare` aggregates order lines by exact `ArticleId` and rejects conflicting barcode/unit cost for the same ID. It checks supplier identity, positive ordered quantity, nonnegative agreed unit cost, and exposes unexpected receipt articles, remaining quantities and cost variance.
- `PurchaseReceiptStockProjectionService.Build` requires unique receipt article IDs, strictly positive receipt quantities, consistent totals, catalogue identity and available stock snapshots. Its projection is explicitly read-only.
- These previews **do not** account for earlier posted partial deliveries, DB row locks, claim idempotency or authorization.

## Contract for BC owner approval before any posting

- BC identity: immutable order ID, supplier ID, line/article identity, unit, ordered quantity, currency/cost basis and document status. Do not infer fields or grants from legacy labels.
- Receipt identity: unique immutable receipt ID and BC ID, supplier, actor/session authorization provenance, per-article quantity in BC's canonical unit. One receipt may include multiple distinct articles; barcode is never a unique identity.
- For each BC line under transactional lock: `alreadyReceived = SUM(quantity of committed, non-reversed receipts for that BC line)`; require `0 <= alreadyReceived <= ordered`, `newQuantity > 0`, and `alreadyReceived + newQuantity <= ordered`. Reject unknown/duplicate article IDs, cross-supplier BC, mixed units without approved exact conversion, invalid status and decimal overflow.
- A partially delivered BC stays open with explicit remaining quantity. Replaying the same receipt ID returns the prior outcome without posting stock again; same ID with different payload is rejected. Two simultaneous receipts must not both consume the same remaining capacity.
- Lock BC header/lines and affected stock rows in deterministic order; re-read order and prior receipts **inside one InnoDB transaction**. Verify trusted actor and explicit receipt capability at the write boundary. Write receipt header/details, quantity accumulation, movements and stock **atomically**; assert affected rows; commit once or roll back everything.
- Never write to Checkout or manual Stock Writer. Never silently change agreed unit cost on receipt. Return/void reversal and over-receipt policy require explicit BC owner decision.

## Disposable test matrix (after BC contract approval)

| Scenario | Ordered | Previously received | New receipt | Expected |
| --- | --- | --- | --- | --- |
| Two articles, partial | A:10, B:8 | A:0, B:0 | A:4, B:3 | Accept; remaining A:6, B:5 |
| Subsequent delivery | A:10, B:8 | A:4, B:3 | A:6, B:5 | Accept; both remaining zero |
| Over-receipt | A:10 | A:7 | A:4 | Reject, no writes |
| Exact boundary | A:10 | A:7 | A:3 | Accept, remaining zero |
| Same receipt ID retry | A:10 | A:3 | replay original receipt | No second movement or stock change |
| Same receipt ID, changed payload | A:10 | A:3 | altered quantity | Reject |
| Concurrent deliveries | A:10 | A:6 | two receipts of A:3 | At most one succeeds |
| One invalid line in batch | A:10, B:8 | 0 | A:2, B:9 | Entire batch rolls back |
| Ambiguous shared barcode | A:10, B:8 | 0 | barcode only | Reject until exact article ID chosen |
| Missing authorization | A:10 | 0 | A:1 | Reject before writes |
| Different supplier | A:10 | 0 | A:1 under other supplier | Reject |
| Zero/negative/fractional invalid unit | A:10 | 0 | A:0 or A:-1 or unsupported unit | Reject |

**Acceptance gate:** require BC owner to confirm schema, receipt status semantics, authorization capability and idempotency key. Until then Cell03 may implement pure isolated invariant tests but must not activate SQL receipt posting. QA93 alone integrates after review.
