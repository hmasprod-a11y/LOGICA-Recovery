# Selected-line partial cash return: bounded original-price policy

This batch follows full-return core commits4472e2b / ea5edeb. It changes core/API and isolated SQL acceptance only; WPF integration is a separate root-owned delivery.

## Source authority and deliberately bounded rounding

`FormDialog_RETOUR` copies original article, prices, discount, quantity and signed net into the return basket. `Form_3_VENTE` recalculates selected negative quantities through the existing line-pricing behavior. The modern posting path therefore uses persisted original prices/discounts, never current catalogue or entered prices.

The accepted subset is whole quantities where the original unit net from `SalesLinePricing.CalculateNetAmount(price,1,discount)` is already an exact cent and that unit net times the original quantity equals its persisted net. This permits exact source calculation on each selected quantity and exact cumulative original bounds. Fractional quantities and fractional-cent unit nets are refused before any consumption; no residual-cent redistribution is invented. An untouched original excluded from this partial policy remains eligible for its existing complete-ticket policy where that policy supports it. A positive refund is required; free lines can accompany a positive selected refund, not create a zero-value standalone payment.

## Cumulative original consumption

Explicit additive migration `input/migrations/20261120-partial-cash-return-consumption.sql` creates an InnoDB original-ticket/article ledger for cumulative returned quantity/net and last operation ID. No production startup applies it. Acceptance embeds and applies the exact migration only to its isolated disposable database.

The locked original header serializes full and partial operations across independent cashiers. The partial path refuses a prior full claim, compares every selected original/returned snapshot, enforces quantity/net bounds and atomically updates the per-line ledger with signed stock, receipt, payment, sequence and durable operation journal. The unique original/article index and persisted cumulative values are verified. Actual posting rereads all original settlement and line evidence under its own transaction.

Any partial consumption prevents a stale/new full-ticket refund through the existing original claim. Full candidates/preparation exclude partially consumed originals across cash/card/credit APIs; remaining cash lines use the partial API instead. Full-return behavior remains compatible with a database where the optional partial migration has not been installed. Nontransactional partial consumption is never treated as safe evidence.

## Desktop API contract

- `FindPartialCashReturnCandidatesByReceipt(connections,receipt)` returns `PartialCashReturnCandidate(SaleId,TicketNumber,ReceiptDate,Register,OriginalPaidMad,RemainingNetMad,Lines)`.
- Each line is `CheckoutOriginalReturnLineSnapshot(ArticleId,ArticleName,OriginalQuantity,OriginalUnitPrice,OriginalDiscountPercent,OriginalNet,ReturnedQuantity,ReturnedNet)`.
- `IsPartialCashReturnLineSupported(snapshot)` exposes the exact-cent/whole-quantity policy for presentation. The transaction independently repeats it.
- The UI selects explicit `CheckoutPartialReturnSelection(snapshot,quantity)` values and calls `PreparePartialCashReturnRequest(connections,newOperation,cashier,"MAD",originalId,selections)`.
- The prepared normal `AuthorizedCheckoutRequest` carries a `PartialCashReturn` reviewed snapshot. Gate and production preparation detach caller-owned selection lists before callbacks. The existing posting/reconciliation path must preserve this field.

Changing remaining quantities, original prices or the snapshot requires a new review. Unknown outcomes remain reconciled by the existing operation journal; never create a fresh operation solely because acknowledgement was lost.

## Executed production MariaDB acceptance

The existing complete boundary suite now includes `PartialCashReturnAcceptance.cs`. A two-article original contains3 units at net9 (10% original discount) and2 units at3, paid40 with change7. A selected one-unit return refunds9 and restores only that unit. The remaining24 restores all original cash33 and all5 units. The suite checks wrong PIN/category, forged snapshot/amount, cumulative overquantity/net corruption, stale full requests/candidates, old returned-quantity snapshots, after-payment rollback, replay and persisted reconciliation. Current catalogue changes do not alter return prices. Concurrent partial/partial and full/partial operations permit only one stale-review winner. An unsupported fractional-cent unit original refuses partial consumption and remains successfully refundable through its complete original path.

Architecture tests cover matching cash-only reviewed selections and caller-list freezing. Existing full cash, credit and card/mixed-original regression suites run unchanged before the new migration and all remain successful.

Remaining scope: partial credit/card, mixed-original cash reimbursement, fractional quantities/rounding policies outside this bounded proof, hardware and WPF end-to-end acceptance.
