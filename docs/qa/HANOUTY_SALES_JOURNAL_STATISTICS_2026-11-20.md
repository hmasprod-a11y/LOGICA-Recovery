# Daily sales journal and essential statistics

Baseline `aebe1d1b3fd4b964301eba5375caa6e6743e1c2f`. New reader/workflow/contracts/dialog and a standalone SQL-backed Windows STA acceptance project. On21 November the supervisor recovered this isolated delivery and connected MainWindow/Host navigation, modal/session guards and the existing sale/return printer; see `HANOUTY_DAILY_STORE_BATCH_2026-11-21.md`.

## Original authority

- `Form_1_LOGIN.FUN_CAT_ACCES` around1847–1871: ADMIN/MANAGER can open JOURNAL; STATISTIQUES is ADMIN-only; UTILISATEUR has neither.
- `Form_3_VENTE_JOURNAL` daily report around10791: paid turnover is SUM(TOTAL_NET) for VENTE + RETOUR REMBOURSEMENT. Payment totals separately SUM(MONTANT) by MODE_P, retaining signed change/refunds.
- `Form_3_VENTE_ENTETE` displays original headers, distinct ticket counts, operations, payment modes and selected details.
- `Form_9_STATISTIQUES` around7238 uses the same paid-operation predicate for turnover; quantity grouping around7390 sums signed Qté. Credit is displayed separately here, never added to cash or paid turnover.

## Actual implementation

`SalesJournalReader.Authorize(actor,readPin,statistics)` requests a fresh actor PIN and grants only the exact original roles. Each options/read/detail/reprint read checks the original authenticated role again. Grants are bound to the reader instance; no PIN is retained. Connections explicitly use utf8mb4 and loopback only. All business access is SELECT under repeatable-read transactions; acceptance runs reads through a SELECT-only SQL user.

Filters: inclusive date range (implemented as >=start and <day-after-end), exact cashier/operation, associated payment mode and literal ticket/client/article/code search. %, _ and ! remain literal; all values are parameters. Ticket browse is capped at1000 with an explicit narrowing error; periods are limited to ten years. Editing filters invalidates existing selection/detail/reprint.

Totals are derived directly from original signed journal rows. Paid sales, paid returns and paid net remain separate from credit sales, signed credit returns and credit net. Quantities remain signed and fractional. Payments are aggregated separately from their own dates/modes, avoiding journal/payment join multiplication. A mode filter selects associated tickets but limits the payment table to that selected mode. Daily and cashier tables are available only in an ADMIN statistics dialog; the manager journal retains its original journal/finance capability.

Orphan original journal rows are not silently discarded. An unfiltered difference between paid journal net and ticket payment net is surfaced as a data-integrity warning, not forced to balance or called drawer cash. Customer settlements, expenses, opening cash and other drawer movements are not mixed into these ticket payment totals.

Selected details require the exact unchanged header and unique canonical identity, matching signed journal total and matching payment/credit semantics. Duplicate/case-alias headers cannot reprint. The workflow exposes an existing-print callback keyed by the selected original ID/cashier/register after rechecking its details and grant. Root owns wiring this callback to the same `LogicaPostedTicket`/original print factory, including its new signed-return support. No new invoice/template or terminal command is introduced.

## Root integration hook

Construct `SalesJournalReader(connectionString)`, call `Authorize(activeActor, freshPinCallback, statistics:false/true)`, then open `SalesJournalDialog(new SalesJournalWorkflow(reader,access,sameSessionActive,reprintCallback))`. The callback receives `SalesJournalTicket` and must use its persisted Id/Cashier/Register with the existing receipt reader and printer. Protect the modal against session/context changes as other management modules do. No shop schema migration is required.

## Executed acceptance

`modernization/sales-journal-acceptance/SalesJournalAcceptance.csproj` links the actual reader/workflow and references the actual WPF dialog. Environment `HANOUTY_JOURNAL_TEST_CONNECTION` must target loopback database `journal_disposable`; fixture setup uses its test owner, while actual reads use user `journal_reader` with SELECT only and password `journal-select-only`. The test server owner must provision that account/grant before execution. It is disposable fixture setup, never a shop-account installer.

The test seeds paid cash with signed change, mixed/card payment, paid return, credit/credit return, fractional quantities, another cashier, the final microsecond of the last day, excluded adjacent days, empty ranges and literal special characters. It drives actual admin and manager dialogs, selected detail modal, reprint callback, admin daily statistics and filter invalidation; saves journal/manager/statistics PNGs and required JSON assertions. Wrong PIN/role, revoked role, foreign session, forged selected total, duplicate/case-alias IDs, orphan journal discrepancy and unchanged complete-table checksums are asserted. Arabic and accented identities work; accent/Farsi-letter lookalikes cannot borrow a grant.

`journal-charset-proof.json` records client/connection/results character sets and fixture-only stored/parameter HEX. It demonstrates the observed implicit latin1 binary-parameter mismatch versus explicit utf8mb4, without logging PINs or changing role rules.

This is essential daily journal/statistics, not a claim that all original monthly charts, margins, seller/family analyses, exports or hardware printing have been migrated.
