# Full original CARTE reimbursement: core and desktop boundary

Based on credit-return core commit4472e2b and the same existing financial transaction/journal.

## Original authority and scope

`FormDialog_calc.Button_SOLDER_Click` around3107 explicitly requires one selected payment mode for RETOUR REMBOURSEMENT and zero outstanding amount. `CheckoutPaymentReadService` projects the signed selected mode; `TicketPaymentWriter.WriteTendered` persists a signed amount and its mode. Therefore a return must not invent an automatic two-mode reversal of a mixed sale.

This batch supports a complete original CARTE or cash/CARTE mixed sale reimbursed through one explicitly selected CARTE mode for its full original net. For a mixed original, original cash remains in the drawer and the complete reimbursement is negative CARTE. This is a selected refund mode, not an automatic reversal of the original split. Cash reimbursement of a mixed original and partial returns remain separate.

No bank terminal is commanded. `ExternalCardRefundConfirmed` records the cashier's explicit assertion that the external reimbursement has been completed; it is not bank authorization or bank reconciliation. That flag is required only on a single-mode CARTE return and forbidden on ordinary sales/credit/cash envelopes.

## Core implementation

- `MariaDbCardReturns.cs` locks a unique anonymous VENTE header, the complete original line set and its original payment rows. One positive CARTE allocation, at most one received-cash row and one signed cash-change row must sum exactly to the original net in whole cents. Invalid modes, change, duplicate headers, named/debt originals and damaged lines are refused.
- `FindFullCardReturnCandidatesByReceipt` exposes full original net plus separate original net cash/card components for an explicit informed refund selection.
- `PrepareFullCardReturnRequest(..., externalRefundConfirmed: true)` prepares a complete immutable single-card envelope. It cannot prepare an unconfirmed refund.
- Posting rechecks original payment/line evidence, fresh cashier PIN and configured CARTE availability, then uses the existing original-ticket claim and the same stock/header/journal/payment/sequence/operation transaction. Current catalogue prices cannot determine the refund.
- A successful refund restores original stock, posts RETOUR REMBOURSEMENT and exactly one negative CARTE movement for the original total, with no drawer-cash movement. The payment remark retains the original reference and the external-confirmation marker.
- Strict existing cash-default evidence remains unchanged. A corrupted cash original cannot become refundable through its old cash entry simply because card refunds now exist.

## Verification

`CardReturnAcceptance.cs` is part of the complete existing production MariaDB boundary suite, after cash and credit acceptance. It executes both a CARTE original and a mixed original containing received cash and signed change; original10% promotion and two articles are preserved. It checks full net/card/cash reconciliation, stock restoration, single-mode behavior, confirmation/PIN/config/partial/amount refusals, a real after-payment trigger rollback, durable replay, consumed-original exclusion and restart journal lookup. The complete existing cash regression suite and credit suite must remain successful. Architecture tests exercise the confirmation/mode contract.

## Required desktop integration

Present the original receipt and net alongside original cash/card amounts. Explain that the selected reimbursement is the entire amount by CARTE, including when the original was mixed. Require explicit external-refund completion confirmation and a fresh cashier PIN. Submit through the existing gate and reconcile unknown database outcomes; do not reissue a bank reimbursement on database retry/review. Preserve this distinction in receipts and closing totals.

This is a core/API delivery, not a claim of WPF or physical payment-terminal acceptance. Partial returns and a single cash refund of mixed originals remain open.
