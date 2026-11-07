# V1 cash-return characterization — Checkout PR #75

Status: **characterization only; NOT return acceptance or enablement**. Pinned cash baseline: Checkout 6c0f68f0, QA a675772d. Do not advance the accepted manifest automatically.

## Traced production behavior

* `Form_3_VENTE.cs` (`ReadCheckoutStock`): sends the signed `Qté` value from the workstation grid unchanged.
* `Form_3_VENTE.cs` (checkout handler): changes `RETOUR` to `RETOUR REMBOURSEMENT` when payment-mode access is disabled.
* `CheckoutPaymentReadService.Read`: for `RETOUR REMBOURSEMENT` without payment modes, writes a single cash row using the signed `Text_TOTAL_NET` string.
* `CheckoutStockWriter.Apply`: `UPDATE TABLE_ARTICLES SET STOCK = STOCK - @checkoutQuantity`; a negative quantity therefore increases stock. `StockMovementWriter` receives the same signed quantity.
* `CheckoutPaymentPostingService` and `MySqlCheckoutPostingStore`: forward payment rows to existing `TicketPaymentWriter` without sign normalization. The enclosing transaction owns rollback.
* `AuthorizedCheckoutMariaDbPort.Commit`: **still rejects** `IsReturn` before opening the transaction. No production return enabled by this document.

## Source-derived input/output examples (not executed SQL evidence)

| Input | V1 signed quantity | Signed line total | Cash payment | Stock delta |
|---|---:|---:|---:|---:|
| Sale, 1 unit at MAD 5.25 | +1 | +5.25 | +5.25 | -1 |
| Cash return, 1 unit at MAD 5.25 | -1 | -5.25 | -5.25 | +1 |
| Return writer fails before commit | -1 | -5.25 | rolled back | 0 |

The example presupposes a signed return total already computed by the legacy UI; it does **not** prove the UI's return rounding or original-price selection. Those must be characterized separately against the original implementation and disposable SQL.

## Required disposable MariaDB acceptance before enabling IsReturn

1. Create an exact-cash sale using the real writers and read back original ticket, lines, price, payment, movement, and stock.
2. Return exactly the sold quantity, with a durable original-ticket reference and authoritative original price, using the same transaction and writers; assert signed journal/header/payment and stock increment once.
3. Reject unknown original, second return, excess quantity, changed identity, and unauthorized PIN without any financial writes.
4. Inject a fault after payment write; assert rollback of stock, movements, header, journal, payment, completion and operation claim.
5. Retry identical operation ID, restart, and reconcile ambiguous commit via the existing Architecture gate/journal; assert no second refund.
6. Exercise two independent concurrent sessions returning the same original line; only one may commit.

## Contract gap requiring Architecture/QA decision

The current `AuthorizedCheckoutRequest` has `IsReturn` but no proven durable original-ticket reference or consumed-return ledger. The V1 writer path shown above does not itself establish original-sale linkage, over-return prevention, or the exact original-price rule. **Do not infer these protections from the sign rule**. Agree a minimal original reference/quantity-consumption contract and its durable storage/reconciliation with Architecture and QA before enabling the port. Do not create a competing DTO/gate or mutate a live store schema.

Mixed payment, tier pricing, discounts and credit are separate acceptance gates.
