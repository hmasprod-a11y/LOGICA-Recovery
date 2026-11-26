# Full original credit return: core and integration boundary

Baseline: development integration `d56becd568a64fa3acf775d3342458549a56f6cd`.

## Original behavior

`recovered-source/LOGICA/Form_3_VENTE.cs`, `Button_ClickCore` / `Button_SOLDER_CREDIT` around lines12930–12942 chooses CREDIT for a nonnegative total and RETOUR CREDIT for a negative total. The existing posting service writes signed stock/header/journal data; a credit return reduces customer debt and does not issue a cash/payment movement. The existing customer statement already includes CREDIT and RETOUR CREDIT.

## Implemented core

- `MariaDbCreditReturns.cs` reads and locks a unique original CREDIT header and every original journal line, preserving the original customer, price, discount and net. A case alias, damaged identity, missing line, inconsistent customer or any original payment row is refused.
- A unique current customer identity must still exist; its later name or catalogue-price changes do not rewrite the persisted original snapshot.
- `FindFullCreditReturnCandidatesByReceipt` accepts printed ticket or canonical original ID, with explicit candidate selection. Damaged/consumed originals are excluded.
- `PrepareFullCreditReturnRequest` builds the complete reviewed customer/line/debt envelope without writing or consuming the ticket.
- Posting reauthenticates the cashier, requires enabled original credit configuration, rereads original evidence and uses the existing InnoDB consumption claim and financial operation journal. One original can be returned once across cash/credit entry points.
- Existing shared return staging writes negative quantities/net using the original values. RETOUR CREDIT carries the named customer and has no payment rows; cash-return behavior retains its existing policy.
- The original stock, ticket sequence, header, signed debt journal, consumption and operation journal commit together. Failure rolls everything back. Existing operation reconciliation determines persisted/absent/unknown after interruption.

## Executed verification

`modernization/checkout-mariadb-boundary/CreditReturnAcceptance.cs` is included in the existing production MariaDB boundary suite. It executes a two-article named credit sale with an original10% promotion and a full return, then checks exact stock restoration, zero debt, unchanged cash/payments, original identity and signed quantities. It refuses wrong PIN, disabled configuration, changed reviewed identity, partial line set, caller amount and damaged original customer; a real journal trigger injects rollback. Later catalogue-price and customer-name changes cannot alter the original return. Durable duplicate, second consumption refusal, excluded consumed candidates and persisted journal reconciliation are asserted. The complete preexisting cash/refund/boundary suite also runs.

Architecture tests additionally allow only a referenced, named single-credit return envelope; anonymous, missing-original and mixed cash/credit envelopes remain invalid.

## Required desktop integration

The WPF returns section must offer a separate credit-original selection using the new candidate API, display its original customer and debt reduction, explicitly confirm that no cash is refunded, and request a fresh cashier PIN. Submit the prepared envelope through the existing session/gate and reconcile uncertain outcomes with its durable journal. No new parallel posting engine or payment collection is required.

This core delivery alone does not claim WPF end-to-end acceptance. Partial credit returns, card/mixed refunds and physical printer acceptance remain separate work.
