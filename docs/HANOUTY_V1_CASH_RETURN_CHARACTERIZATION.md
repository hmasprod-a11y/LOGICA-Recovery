# V1 cash-return characterization — Checkout PR #75

Status: **V1 historical characterization, not a standalone production acceptance**. Current production cash-return support must be evaluated against its own exact-SHA QA evidence; this document alone neither enables nor rejects it. Pinned cash baseline: Checkout 6c0f68f0, QA a675772d. Do not advance the accepted manifest automatically.

## Traced production behavior

* `Form_3_VENTE.cs` (`ReadCheckoutStock`): sends the signed `Qté` value from the workstation grid unchanged.
* `Form_3_VENTE.cs` (checkout handler): changes `RETOUR` to `RETOUR REMBOURSEMENT` when payment-mode access is disabled.
* `CheckoutPaymentReadService.Read`: for `RETOUR REMBOURSEMENT` without payment modes, writes a single cash row using the signed `Text_TOTAL_NET` string.
* `CheckoutStockWriter.Apply`: `UPDATE TABLE_ARTICLES SET STOCK = STOCK - @checkoutQuantity`; a negative quantity therefore increases stock. `StockMovementWriter` receives the same signed quantity.
* `CheckoutPaymentPostingService` and `MySqlCheckoutPostingStore`: forward payment rows to existing `TicketPaymentWriter` without sign normalization. The enclosing transaction owns rollback.
* `AuthorizedCheckoutMariaDbPort.Commit`: the current implementation does **not** reject `IsReturn` before opening the transaction; it restricts tender to single cash and delegates full-return validation to `MariaDbCashCheckoutPreparation.PrepareFullCashReturn` inside the transaction. The earlier historical characterization predated this implementation.

## Source-derived input/output examples (not executed SQL evidence)

| Input | V1 signed quantity | Signed line total | Cash payment | Stock delta |
|---|---:|---:|---:|---:|
| Sale, 1 unit at MAD 5.25 | +1 | +5.25 | +5.25 | -1 |
| Cash return, 1 unit at MAD 5.25 | -1 | -5.25 | -5.25 | +1 |
| Return writer fails before commit | -1 | -5.25 | rolled back | 0 |

The example presupposes a signed return total already computed by the legacy UI; it does **not** prove the UI's return rounding or original-price selection. Those must be characterized separately against the original implementation and disposable SQL.

## Disposable MariaDB acceptance requirements for the full-return path

1. Create an exact-cash sale using the real writers and read back original ticket, lines, price, payment, movement, and stock.
2. Return exactly the sold quantity, with a durable original-ticket reference and authoritative original price, using the same transaction and writers; assert signed journal/header/payment and stock increment once.
3. Reject unknown original, second return, excess quantity, changed identity, and unauthorized PIN without any financial writes.
4. Inject a fault after payment write; assert rollback of stock, movements, header, journal, payment, completion and operation claim.
5. Retry identical operation ID, restart, and reconcile ambiguous commit via the existing Architecture gate/journal; assert no second refund.
6. Exercise two independent concurrent sessions returning the same original line; only one may commit.

## Contract gap requiring Architecture/QA decision

The V1 signed-quantity writer path alone does not establish original-sale linkage, over-return prevention, or the exact original-price rule. **Do not infer these protections from the sign rule.** The current preparation explicitly checks `hanouty_cash_return_consumption` is InnoDB for a return, and dispatches to `PrepareFullCashReturn`; acceptance of the entire chain still depends on exact-SHA production QA evidence. Do not create a competing DTO/gate or mutate a live store schema.

Mixed payment, tier pricing, discounts and credit are separate acceptance gates.

## Inventory handoff — Checkout financial stock concurrency (2026-11-13)

Scope: Checkout owns **only** stock changes caused by an authorized financial sale/return. Inventory Cell03 owns inventory adjustment authorization and its own writer; Cell02 must not call or modify that writer. QA #93 integration baseline reported by owner: `2108f549`; cashier software acceptance is distinct from pending physical printer acceptance. Do not reinterpret this characterization as a new W2 acceptance run.

### Correction of historical return-port statement

The historical claim that `AuthorizedCheckoutMariaDbPort.Commit` unconditionally rejects `IsReturn` is obsolete at this Checkout SHA. The cash-only guard permits a verified full-ticket cash return; `MariaDbCashCheckoutPreparation` checks the transactional original-ticket claim table and calls `PrepareFullCashReturn`. This is a source-code correction, **not** a new end-to-end acceptance result. The financial sale/return stock writer remains the sole Checkout writer, and Inventory Cell03 must not duplicate it.

### Source-verified transaction invariants

- `AuthorizedCheckoutMariaDbPort.Commit` opens one `MySqlCheckoutAtomicPostingBoundary`, begins/binds its transaction, claims the operation ID, prepares cashier/PIN and authoritative pricing inside that same transaction, posts via `CheckoutPostingService.Post`, then commits. A duplicate operation claim returns without a second posting; after a commit attempt fails, outcome remains unknown and must be reconciled, not blindly retried.
- `MariaDbCashCheckoutPreparation.Prepare` requires InnoDB for `TABLE_ARTICLES`, `TABLE_MOUVEMENTS_STOCK`, receipt/payment/journal tables and the durable operation ledger. It locks `TABLE_NUM` and `TABLE_ARTICLES` with `FOR UPDATE`; a workstation basket already occupied is rejected rather than overwritten.
- `CheckoutStockWriter.Apply` issues `UPDATE TABLE_ARTICLES SET STOCK = STOCK - @checkoutQuantity WHERE ID_ARTICLE = @checkoutArticleId` in the caller's transaction, requires exactly one matching article, then appends `StockMovementWriter.Write` in that transaction. A positive sale quantity decreases stock; a negative refund quantity increases it. No second stock writer is allowed in the checkout posting path.
- Full-ticket cash refund evidence and the unique original-ticket consumption claim are checked in the posting transaction. Inventory adjustments must not mutate original-sale evidence or reuse financial operation IDs.

### Concurrent inventory operations — mandatory Cell03/QA contract

1. Inventory must use InnoDB and serialize any adjustment of the **same** `TABLE_ARTICLES` row with checkout's update/locked read, using the same canonical article identity. A stale UI stock snapshot cannot authorize a write; re-read the authoritative row under the adjustment transaction.
2. Inventory authorization (actor/session/grant) is separate from cashier/PIN authorization. A cashier payment is not an inventory adjustment grant, and an inventory grant must not bypass checkout's financial operation claim.
3. All participants should acquire locks in a consistent order when multiple article rows are involved, and must handle deadlock/lock-wait failure by aborting their own transaction. Never silently repeat a financial operation after an uncertain commit; reconcile its durable operation ID first.
4. A concurrent stock adjustment may change available stock between catalogue preview and payment. The authoritative checkout transaction revalidates article identity/pricing and writes stock atomically; QA must explicitly decide and test whether negative stock is permitted by the approved business policy. The current writer's SQL does **not** impose a `STOCK >= quantity` condition, so do not claim that insufficient stock is rejected.
5. Physical ticket printing is a post-commit hardware acceptance matter. A printer failure cannot cause a second financial stock movement or an automatic repost.

### Non-regression handoff (do not rerun accepted cashier acceptance)

QA should compare the already-accepted `2108f549` financial evidence to the Inventory integration SHA, then add **only new concurrency acceptance** on disposable MariaDB: one article, two connections, checkout stock update and authorized inventory adjustment contending for the same row; verify serialized final stock and distinct audit movement origins. Also verify an inventory transaction rollback leaves checkout stock and its financial receipt untouched. No real-shop data and no legacy ZIP as commercial Beta evidence.

## LOGICA negative-stock policy — source characterization (2026-11-14)

**Source evidence:** `recovered-source/LOGICA/Form_3_VENTE.cs` lines 12806–12816: on `VENTE` only, LOGICA checks the exact setting `BLOCAGE_STOCK_INSUFFISANT` equals the string `True`, then invokes `StockValidationService.FindFirstShortage(new MySqlStockAvailabilityLookup(Module1.cn_SQL), ReadStockValidationRows(), VisualBasicCheckoutSemantics.Instance)`. If a shortage exists it shows `stock insuffisant de l'article` and returns before posting. When the setting is not `True`, this branch does not block the sale. This is **conditional**, not an unconditional no-negative-stock rule.

**Modern production difference:** `recovered-source/LOGICA/Infrastructure/Checkout/CheckoutStockWriter.cs` line 28 executes `UPDATE TABLE_ARTICLES SET STOCK = STOCK - @checkoutQuantity WHERE ID_ARTICLE = @checkoutArticleId`, with no `STOCK >= @checkoutQuantity` predicate. `MariaDbCashCheckoutPreparation.Prepare` locks authoritative article rows inside the checkout transaction, but does not inspect `BLOCAGE_STOCK_INSUFFISANT` to reject shortages. Therefore current modern Checkout does not yet reproduce the enabled legacy blocking option. Do **not** unconditionally prohibit negative stock: that would also break the legacy configuration where the option is disabled.

**Reproducible acceptance cases (disposable MariaDB only, not executed by this characterization):** create article A with stock 1 and sale basket A quantity 2; authenticate a valid cashier/PIN/session. (1) With legacy setting `BLOCAGE_STOCK_INSUFFISANT=True`, expect refusal before any payment, ticket, stock or journal write; stock remains 1. (2) With setting `False`, expect the legacy shortage gate to be skipped; subsequent unrelated constraints may still reject posting, so verify signed stock and audit only if the transaction commits. (3) With setting `True`, A stock 2 and quantity 2, expect no shortage refusal. (4) With concurrent inventory adjustment of A from stock 2 to stock 1 before Checkout's locked validation, expect the enabled gate to reject quantity 2 using **fresh locked stock**, not the earlier UI snapshot. (5) A refund of an eligible original ticket must follow the distinct signed refund policy, not the VENTE-only shortage gate. Assert no duplicate stock movement and rollback of financial writes on refusal.

**Integration decision:** Cell03 must not implement this financial rule in the inventory writer; Cell02 owns the Checkout setting/validation. Supervisor owns supplier BC in QA #93; do not modify purchase files or QA branch concurrently. A code implementation of the enabled setting requires the verified configuration read contract and same-transaction stock validation; this note does not claim that feature is implemented or tested.
