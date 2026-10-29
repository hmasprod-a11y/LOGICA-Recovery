# LOGICA: preserve behavior, then improve structure

## Priority agreed with the owner (2026-10-29)

LOGICA is the primary product and the owner reports that it works well. The first objective is to organize its code incrementally while preserving existing behavior. TODO POS is an optional reference for selected ideas, not the implementation base. New features and broad UI redesign follow stabilization.

The requirements list is a target inventory, not evidence that features are missing. No full rewrite, framework migration, database replacement or production-data migration is part of this first change.

## Inspected baseline

Repository commit: d4b13ca553b53c923fe8afd0eefd037b08206057.
This is a preliminary source inventory, not a complete audit or a new runtime certification.

| Area | Evidence | Current assessment | Next acceptance evidence |
| --- | --- | --- | --- |
| Windows build | recovered-source/LOGICA.csproj | net48, x86, WinForms; keep target | Full existing Windows build and POS workflow |
| Sales | recovered-source/LOGICA/Form_3_VENTE.cs (668747 bytes) | Large source file; extraction candidates need method-level inspection | Existing basket/checkout tests plus focused regression cases before moving logic |
| Catalogue | recovered-source/LOGICA/Form_2_ARTICLES.cs (646163 bytes) | Large source file; not proof of faulty behavior | Record representative product editing/import workflows before refactoring |
| Shared state and utilities | recovered-source/LOGICA/Module1.cs | Money, barcode, database connection and UI-dependent initialization coexist | Separate pure rules first; preserve legacy call sites |
| Existing regression checks | scripts/test-pos.cs | Basket, checkout/refund, rounding and form smoke checks exist | Execute against isolated fixture; expand failures/concurrency later |
| Existing CI | .github/workflows/windows-reference-diagnostic.yml | Builds source, provisions fixture, runs POS checks; repair step can commit generated repairs | Inspect actual branch run; do not infer success from workflow presence |
| Archive workflow | .github/workflows/build-recovered-source.yml | Builds archive, unlike the authoritative-source workflow | Do not use archive build as proof that current source passed |
| Peripherals | README.md | Real physical devices explicitly outside prior checks | Manual device acceptance on shop-equivalent hardware |

No AGENTS.md was present in the recursive repository tree at the inspected commit.
Credentials and activation behavior are not changed by this extraction.

## First implementation slice

Move the exact FLOUSS rounding expression into LOGICA.Domain.MonetaryRounding. Keep Module1.FLOUSS as the compatibility entry point, so existing callers remain intact. The SDK project automatically includes the new C# file.

Preserve both rounding away from zero and the existing culture-sensitive Visual Basic conversion. Removing that conversion or its dependency is a separate decision after compatibility review. The new type has no UI, database or Module1 dependency.

Add standalone characterization checks covering explicit expected values, positive and negative amounts, midpoint boundaries, large amounts, decimal limits and fr-MA/fr-FR/en-US cultures. The standalone runner compiles the production rule directly using Windows .NET Framework tooling. Existing POS tests still exercise the compatibility entry point in the built EXE.

## Ordered next slices

1. Verify the existing full Windows build, isolated checkout/refund fixture and baseline screens for this branch.
2. Inspect basket calculation and checkout methods. Map UI reads, database writes, stock movements, ticket numbering and printer calls before selecting the next extraction.
3. Add regression cases for the selected rule, then extract that one responsibility behind the existing form entry point.
4. Separate database access after transaction and error behavior is documented. Treat financial behavior changes as separate fixes.
5. Repeat for stock/catalogue; evaluate selected TODO ideas only after the relevant LOGICA area is protected.

Each slice must list original entry points, preserved behavior, tests actually run, limitations and a rollback commit. Changes stay on a review branch until accepted. A full requirement-by-requirement audit and effort estimates remain to be completed; file size alone is not an effort estimate.

## Progress: second slice (2026-10-29)

The owner reaffirmed that organizing code is the priority; the existing application is already working and tried in use. Database checks are regression protection only.

Inspected Form_3_VENTE.Text_TOTAL_NET_Click: database total -> display formatting -> grid quantity aggregation -> optional serial display. These boundaries remain unchanged.
Inspected Button_MODIF_QTE_Click: access check -> quantity dialog -> article price lookup -> quantity-tier selection -> net amount -> basket update -> total refresh.

Extracted the four identical net-amount expressions in Button_MODIF_QTE_Click into SalesLinePricing.CalculateNetAmount. Kept quantity-tier decisions, promotion input, sale/return branches, VB formatting, return double conversion, database writes and existing exceptions in the form. The calculation intentionally remains unrounded and retains intermediate decimal overflow. No new discount validation was introduced.

Local Windows checks: monetary rounding 60,039 assertions and sales line pricing 12,558 assertions passed. Cases include fractional/negative quantities, zero/100%/out-of-range discounts, unrounded fractions and overflow boundaries. Full branch CI must be checked after publication. Standalone rule tests do not exercise the modal quantity dialog or replace manual UI acceptance.

Rollback for this slice: revert its commit; the previous rounding extraction is independent. Next useful step: characterize quantity-dialog/price-tier behavior before extracting more of Button_MODIF_QTE_Click; map the checkout transaction before moving persistence.

## Progress: third slice (2026-10-29)

Verified the second slice with full Windows workflow 40812642731 (success).

Extracted the quantity-price decision from Button_MODIF_QTE_Click into SalesLinePricing.SelectQuantityPrice. A null result preserves the existing no-update behavior when the quantity price is zero or negative. Otherwise it selects the tier at/above the threshold and the standard price below it. The original double-based comparison is deliberately retained, including adjacent large-decimal precision behavior.

Merged the two identical price assignment / sale-or-return amount / adapter update branches into one guarded block. Access dialogs, absolute quantity acquisition, article lookup, promotion, formatting, return sign, total refresh and error handling stay in place.

Local tests: all previous tests passed plus 45 explicit quantity-price assertions across three cultures, covering below/equal/above threshold, fractional values, disabled tier, zero quantity/threshold, higher tier price, zero standard price, decimal limits, double precision and selected-price net calculation. Full Windows CI remains required after this commit. The modal quantity dialog has not been manually exercised in this session.

Rollback: revert this slice's commit. Next: characterize the quantity-edit interaction and map the checkout transaction boundaries before moving persistence; avoid treating database recovery as project work.

### Third-slice verification and checkout reconnaissance

Full Windows run 40813225057 passed, including build, existing POS checks and launcher/package checks. Domain checks passed for the implementation commit. Manual modal quantity-dialog interaction remains unverified.

Inspected Button_Click checkout sequence: transaction starts before ticket number read; stock and movement writes -> header -> journal -> payment rows -> CREATION_IMPRESSION -> clear basket -> increment number -> commit. Rollback is in the inner catch. This is a map of current source, not a change request. Before extracting persistence, add controlled-failure coverage for transaction behavior and inspect CREATION_IMPRESSION side effects. Do not move printing or alter financial behavior as an incidental cleanup.

## Progress: controlled checkout failure coverage (2026-10-29)

Added a checkout-rollback harness scenario before extracting persistence. It first establishes the existing sale/refund baseline, then injects a fixture-only journal-insert trigger failure after the original checkout has changed stock, inserted a movement and written a header. Assertions require the previous stock, movements, header/journal/payment counts and ticket sequence to survive unchanged, and the attempted basket to remain.

The probe refuses to run unless the connection is exactly 127.0.0.1:3307/logica_ci. The injected trigger is dropped in a finally block. A background watcher closes native error dialogs only on the isolated test's own UI thread while the injected call is active. A MEMORY-table marker proves that the injected journal trigger was reached exactly once, independently of the dialog text and transaction rollback. No global keyboard input is used.

Local harness compilation succeeded; runtime result must be obtained from full Windows CI. Production code is unchanged in this slice. This covers a specific mid-transaction failure, not printer failure, concurrency, all failure locations or manual UI acceptance.

### Verification infrastructure follow-up

Run 40813844703 built the application but failed while downloading the isolated MariaDB package (connection timeout), before POS tests. Its rerun then failed because the pre-existing repair/persist step attempted a non-fast-forward push after the earlier generated repair commit.

Changed the branch Windows verification workflow to build the already-committed authoritative source directly with read-only repository permissions. Recovery/repair remains an explicit script; verification no longer rewrites or commits source. This avoids unrelated project-file churn and makes retries test the requested revision. No production-code change was needed for either infrastructure failure.

The first runtime probe timed out at the error dialog; the existing normal checkout checks passed. Replaced the UI-thread timer with a bounded background watcher so native modal-loop behavior cannot prevent acknowledgement. Added a nontransactional trigger-attempt marker to distinguish the intended database failure from an unrelated earlier UI error. Local harness compilation passed; rerun runtime verification before claiming rollback coverage.

Final verification: Windows run 40822250487 succeeded. checkout-rollback PASS: trigger Attempts=1, stock=9, previous headers=2, journal rows=2, payments=12.5, retained basket rows=1, ticket sequence=3 and movement sum=-1. All existing POS, build, data-regression and portable-launcher checks also passed. Production behavior remains unchanged; this new coverage now protects a mid-transaction failure before further persistence extraction.

## Progress: stock-movement persistence boundary (2026-10-29)

Reviewed CREATION_IMPRESSION: it reads form configuration and dispatches physical USB/serial ticket, return and credit printing, including operation-dependent copies. It remains unchanged and is not an appropriate pure-rule extraction.

Selected a narrower persistence boundary: move the existing parameterized stock-movement INSERT from Button_Click into Infrastructure.Checkout.StockMovementWriter. The form still owns the transaction and stock update. The helper uses the exact caller command and connection, preserves parameter types/sign/date calls/ticket label, executes once, and clears parameters on the same successful path. It does not open/close connections, begin/commit/rollback, catch errors, or reference forms/Module1.

Coverage before extraction: existing sale/refund movement sums and the successful injected journal-failure rollback test. Extend checkout assertions to verify article identity and exact ticket labels as well. Full Windows verification is required for this slice; physical printing is not exercised.

Stock-movement slice verified: full Windows run 40822885285 passed, including sale/refund movement identity and ticket-reference checks, injected journal-failure rollback, build and all existing checks. Domain CI passed too. Revert commit c0c8c2b5c22c242813e180f57c78794e3e9f0b6a to undo this extraction. Next: inspect other persistence operations for a similarly bounded extraction without moving transaction ownership; do not combine parameterization or financial-behavior changes with structural moves.

## Progress: ticket-header persistence boundary (2026-10-29)

Extracted the existing TABLE_VENTES_ENTETE INSERT into Infrastructure.Checkout.TicketHeaderWriter, taking a plain TicketHeaderRecord rather than reading controls or Module1. The form captures the same header fields immediately before the write and retains the same date calculation, command/connection/transaction ownership, write order, errors and legacy SQL/culture conversion. SQL parameterization is deliberately outside this structural slice.

Pre-existing sale/refund tests and the successful injected journal failure cover header persistence and rollback. Extended the fixture checks to verify exact ticket number, signed net amount, cashier, workstation and operation for both sale and refund. Harness compilation succeeded locally. Full branch Windows verification is required before claiming this extraction passes.

Next boundary: journal INSERT ... SELECT or payment persistence, after enumerating the values read from the form. Keep the outer transaction in place; do not redesign printing or payment behavior incidentally.

Ticket-header slice verified: full Windows run 40823805091 succeeded. New assertions confirmed sale total 25 and refund total -12.5 with exact ticket/cashier/workstation/operation fields; checkout-rollback and all existing checks passed. Domain CI succeeded. Revert a51a5bd18f0cc2419a2600cd14d0d00cc28bd7c0 to undo this extraction.

## Progress: sales-journal persistence boundary (2026-10-29)

Moved the original TABLE_VENTES_JOURNAL INSERT ... SELECT into Infrastructure.Checkout.TicketJournalWriter. It receives a plain journal record captured at the existing call site and uses the caller's existing command/connection/transaction. Basket-table selection, copied columns, date/time formatting, seller/client/price/payment metadata, SQL and error propagation remain unchanged. The outer form still orchestrates stock -> header -> journal -> payments -> printing -> basket/sequence -> commit.

Existing successful checkout and mid-journal failure/rollback checks protect the boundary. Added explicit sale/refund assertions for signed journal total and quantity, copied product/price/discount fields, cashier/seller/workstation/operation and price/payment notes. Full Windows CI is required for the new slice; no physical printing or all-payment-mode claim is made.

Journal slice verified: full Windows run 40824761557 succeeded, including new journal signed-value/context/copy assertions, checkout-rollback and all existing checks. Domain CI succeeded. Revert d830affcb04d98770ead4fdae7a68a208ba0c95f to undo this extraction. Next: enumerate payment branches and add mixed-payment/change/credit coverage before moving payment persistence; cash-sale/refund coverage alone is insufficient for all branches.

## Progress: payment persistence branch characterization (2026-10-29)

Before moving payment writes, add checkout-mixed (15 card + 10 cash), checkout-change (30 tendered / -5 cash change on a 25 sale), and checkout-credit (CREDIT operation persists without payment rows). Each scenario uses the real checkout handler and verifies existing stock/header/journal/sequence behavior plus payment amounts and journal notes.

Mixed/change scenarios supply an accepted payment-dialog fixture: original Load/Shown/Activated and grid calculation callbacks are detached for this fixture instance, rows are seeded, and the modal is closed via its own Shown event. This deliberately covers checkout persistence after acceptance, not payment-dialog calculation/validation/interaction. The credit case starts from the accepted CREDIT operation and does not cover the human credit-confirmation dialog.

Production code is unchanged in this slice. Harness compilation passed locally; full Windows runtime checks remain required. Only after those branches are characterized should the payment writer be extracted without changing transaction ownership or SQL.

Payment-branch verification: full Windows run 40825823679 passed. checkout-mixed saved 15 card + 10 cash; checkout-change saved tendered 30 plus -5 cash change; checkout-credit saved zero payment rows. All existing checkout/refund/rollback, domain, build, data-regression and launcher checks passed. These are accepted-input persistence tests, not payment-dialog UX tests. Next slice may now extract payment writes with all three branches covered.

## Progress: payment persistence boundary (2026-10-29)

After mixed/change/credit characterization passed, moved all three TABLE_VENTES_REGLEMENTS command bodies into Infrastructure.Checkout.TicketPaymentWriter (cash, tendered row, change). Keep separate methods to retain each original SQL shape and conversion path, including VB object concatenation for tendered modes and string conversion for cash/change amounts.

Capture unchanged ticket/client/cashier/workstation/operation/remark context once inside the original payable-operation guard. The form retains operation classification, payment-dialog acceptance, row iteration, negative-remainder condition, transaction ownership, ordering and printing. The writer receives no controls or Module1 reference and does not change connection lifetime or catch errors.

Existing cash/refund, mixed, change, credit and rollback tests cover this extraction. Full Windows CI is required before claiming runtime verification. This is a structural move; legacy SQL concatenation and its limitations are intentionally not changed here.

Payment-writer verification: full Windows run 40826687096 succeeded, including cash sale/refund, mixed card/cash, tendered/change, credit-without-payment and injected journal-failure rollback; all existing build/data/launcher checks passed. Domain CI succeeded. Revert 20f20c8110abf87444af1fe0cd233546bf95ddc1 to undo the payment extraction.

The main checkout writes now have explicit infrastructure boundaries for movements, headers, journal and payments. Remaining orchestration is still in the form. Next: characterize failure after payment writes, then isolate final basket/sequence completion and stock mutation without changing transaction ownership. A later application-service extraction should consume plain snapshots and keep hardware/UI callbacks explicit.

## Progress: late-checkout rollback characterization (2026-10-29)

Before moving final completion writes, add checkout-late-rollback. After establishing sale/refund baseline, inject a TABLE_NUM update failure after the attempted third payment has been inserted and the basket deleted. A nontransactional marker records PaymentRows=3 and BasketRows=0 at the failure boundary. Existing rollback assertions then require original payment sum, stock, header/journal, movement sum, sequence and retained basket to be restored.

The earlier journal-failure scenario remains separate. The same exact isolated-database guard and scoped dialog watcher apply. This tests transactional completion after payment persistence; it does not certify physical printing or process crashes. Production code is unchanged pending runtime characterization.

Late-failure baseline verified: full Windows run 40827404424 succeeded, including checkout-late-rollback. The test proves payment insertion and basket clearing occurred before the injected sequence-update failure, then verifies rollback restores previous financial records/stock and the basket.

## Progress: checkout completion persistence boundary (2026-10-29)

Move the exact final basket DELETE and ticket-sequence UPDATE into Infrastructure.Checkout.CheckoutCompletionWriter.Complete. Preserve statement order, SQL, legacy numeric ticket formatting and the caller's command/connection/transaction. The caller still prints before completion, commits immediately after it, and rolls back on failure. No transaction or connection lifetime is owned by the helper.

Both journal-stage and late-stage rollback characterization passed before this extraction. Full Windows CI must verify this new structural move. Next: isolate the remaining stock mutation, then evaluate a cohesive application-service boundary; keep UI/payment/hardware behavior explicit.

Completion-writer extraction verified: full Windows run 40827869841 passed, including journal-stage and late completion-stage rollback, all payment variants, sale/refund, build and existing checks. Domain CI passed. Revert 6d226a3077ba1679a65a39ac9e96ea473f0edef8 to undo this extraction. No production-data modification or merge performed.

## Progress: cohesive checkout stock boundary (2026-10-29)

Move the remaining stock UPDATE and its immediately-following movement into Infrastructure.Checkout.CheckoutStockWriter.Apply. Keep the exact legacy object concatenation, update-then-movement order, raw quantity/id values and shared command/connection/transaction. Reuse StockMovementWriter without changing its typed sign conversion. The form retains the Check_STOCK guard and row iteration.

Extend existing checkout characterization with a 1.25-unit sale: expect stock 8.75, movement -1.25, raw journal total 15.625 and rounded header/payment 15.63. Existing whole-unit sale/refund plus both failure boundaries remain enabled. Harness compilation passed locally; full Windows runtime verification is required for this slice.

The checkout writes now sit outside the form; orchestration and UI/hardware remain in it. Next evaluate a cohesive application service from these plain-context boundaries rather than moving unrelated features or changing financial rules.
