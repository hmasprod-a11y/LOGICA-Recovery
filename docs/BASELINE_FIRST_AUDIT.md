# LOGICA baseline-first audit — Cahier des Charges V1.0

Status: audit in progress; evidence map, not a claim that unspecified functionality is missing. LOGICA remains the authoritative working product. TODO POS is a selective UX reference only. Do not merge this draft branch to main without review.

## Mandatory method

1. Inventory the actual LOGICA source, forms, DB schema, existing workflows and available test fixtures **before** labeling a requirement missing.
2. Classify each requirement as **exists and verified**, **exists but needs repair**, **exists but needs test**, **needs internal refactor**, or **not found after audit**. Multiple classifications may apply to separate subpaths; absence of tests is not evidence of absence of a feature.
3. Record source path, baseline behavior, risk, test evidence, acceptance test, and effort estimate (or **unestimated pending audit**).
4. Preserve legacy behavior in small independent PRs. Any functional defect requires an independently documented failing baseline and an approved separate fix. No UI redesign, new feature, shop data modification, activation change, or framework migration in this workstream.
5. Keep CI on isolated data and check original WinForms behavior, not only extracted services. Treat physical devices, clean installation, concurrency, backup recovery and full security as unverified until explicitly tested.

## Initial evidence ledger (not a full module inventory)

| Requirement / module | Current classification | Evidence / source | Remaining acceptance and risk | Effort |
| --- | --- | --- | --- | --- |
| POS checkout and returns | Exists; selected paths verified; internal refactor ongoing | `Form_3_VENTE.cs`, `Application/Checkout`, `Infrastructure/Checkout`; draft #8; `scripts/test-pos.cs` | Unverified suspended sale, double click, devices, full chooser UX | Unestimated pending audit |
| Checkout invalid-total handling | Exists; selected error path characterized; needs full CI reconciliation | `Form_3_VENTE.Button_Click`; draft #9, original catch restores sender and opens VB message | Reconcile stacked branch against current #8 before merge; avoid changing caught-exception behavior | Unestimated pending audit |
| Product creation/edit, variants, catalogue totals | Exists; selected paths verified; internal refactor ongoing | `Form_2_ARTICLES.cs`, catalogue services, draft #10, `docs/CATALOGUE_REFACTORING.md` | Batch commit/rollback, image display, import/export, barcode chooser need targeted acceptance | Unestimated pending audit |
| Stock movement search and refresh | Exists; selected read paths verified; internal refactor ongoing | Draft #11, `docs/INVENTORY_REFACTORING.md` | Inventory write flows, count/adjustment traceability and negative-stock policy not audited | Unestimated pending audit |
| Counted cash | Exists; arithmetic and invalid-input behavior tested; internal refactor ongoing | Draft #12, `docs/CASH_REFACTORING.md` | Session lifecycle, income/expense reconciliation, cancellation rights not audited | Unestimated pending audit |
| Customer/supplier/purchase ledger | Needs audit and tests; **not classified missing** | Cahier sections 2, 6; `docs/REQUIREMENTS_STATUS.md` | Map forms, debt/settlement paths, reconcile balances before refactor | Unestimated pending audit |
| Users, roles, authentication and audit | Needs audit and tests; **not classified missing** | Cahier sections 2, 11 | Role matrix and forbidden-action tests; protect activation and secrets | Unestimated pending audit |
| Printers, scanner, drawer, scales | Needs hardware acceptance; **not classified missing** | Cahier section 12 | Verify physical devices and saved-sale behavior on printer failure | Unestimated pending audit |
| Backup, restore, install and update | Selected launcher checks only; needs audit | Cahier sections 10, 13; original recovered Access DB | Clean-machine install, safe upgrade, backup restore drill | Unestimated pending audit |
| UI/UX and TODO comparison | Deferred except demonstrated defects | Cahier section 8; TODO POS as selective reference | Audit existing controls and defects before proposing changes; no wholesale redesign | Unestimated pending audit |

## Verified scope versus complete acceptance

Latest independent draft PRs #8–#12 have selected passing Windows and/or domain CI runs. These establish tested paths only, not release readiness. `main` is the untouched baseline; stacked PRs are **not** a consolidated release candidate. `docs/REQUIREMENTS_STATUS.md` remains the detailed requirement-to-evidence index for catalogue/checkout.

## Next audit slices (ordered)

1. Enumerate forms and corresponding SQL tables for customer/supplier/purchase, users/permissions, printer/settings and backup; record observed entry points and tests before estimating work.
2. Add isolated characterization tests for existing high-risk P0 behavior, prioritizing untested original paths over new abstractions.
3. Reconcile draft PR dependencies (#8 baseline; #9–#12 stacked/parallel) on a separate integration branch, verify all original-handler Windows checks and data regression, then review; do not merge automatically.
4. Record defects as separate, evidence-backed fixes; only then consider TODO UX ideas or broader UI work.

Source of priorities: user-supplied `LOGICA_POS_2_Cahier_des_Charges_V1` (2026-10-29), especially sections 16–20. This file documents an audit method and initial evidence, not completion of the requested exhaustive audit.

## Source-level inventory checkpoint — 2026-10-30

This checkpoint is based on inspecting actual recovered C# form files on the current draft #8 branch. **Presence of handlers and SQL table references proves an implementation surface exists, not that its behavior passes acceptance.** No missing-feature classification is made here.

| Module / file (under `recovered-source/LOGICA/`) | Observed code entry points | Referenced tables | Classification / next test |
| --- | --- | --- | --- |
| `Form_5_CLIENTS.cs` | Grid selection, edit buttons, search/filter handlers | `TABLE_CLIENTS`, `TABLE_CLIENTS_REGLE`, `TABLE_VENTES_ENTETE`, `TABLE_VENTES_JOURNAL`, `TABLE_PASS` | Exists, needs isolated create/edit/credit-history and permissions tests |
| `Form_5_CLIENTS_REGLE.cs` | Client selection, date filtering, refresh, export, payment handlers | `TABLE_CLIENTS_REGLE`, `TABLE_MODE_P`, `TABLE_VENTES_JOURNAL`, `TABLE_CLIENTS` | Exists, needs settlement and balance-reconciliation tests |
| `Form_6_FOURNISSEURS.cs` | Grid selection/edit and supplier detail handlers | `TABLE_FOURNISSEURS`, `TABLE_FOURNISSEURS_REGLE`, `TABLE_RECEPTIONS_ENTETE`, `TABLE_SORTIES_ENTETE` | Exists, needs supplier balance and payment tests |
| `Form_6_COMMANDES.cs` | `Form_Load`, `Button_SAVE_Click`, `Button_ADD_Click`, search and supplier selection | `TABLE_COMMANDES_ENTETE`, `TABLE_COMMANDES_DETAILS`, `TABLE_ARTICLES`, `TABLE_FOURNISSEURS` | Exists, needs order lifecycle tests |
| `Form_6_RECEPTIONS.cs` | `Button_SAVE_Click`, `Button_VALIDER_Click`, supplier selection and totals | `TABLE_RECEPTIONS_ENTETE`, `TABLE_RECEPTIONS_DETAILS`, `TABLE_MOUVEMENTS_STOCK`, `TABLE_ARTICLES` | Exists, high-risk receipt-to-stock atomicity and rollback tests |
| `Form_6_INVENTAIRES.cs` | `Button_SAVE_Click`, `Button_VALIDER_Click`, inventory-state and item search | `TABLE_INVENTAIRES_ENTETE`, `TABLE_INVENTAIRES_DETAILS`, `TABLE_MOUVEMENTS_STOCK`, `TABLE_ARTICLES` | Exists, high-risk stock adjustment/validation tests |
| `Form_1_LOGIN.cs` | Login initialization, `Butt_ok_Click`, navigation into sale/stock/journal/management | `TABLE_PASS` | Exists, needs role/credential/unauthorized-access characterization |
| `Form_9_PARAMETRE.cs` | Users, config, payment-method, database navigation buttons | `TABLE_PASS` | Exists, needs permission/settings/backup behavior audit |

**Next bounded implementation:** inspect `Form_6_RECEPTIONS.Button_VALIDER_Click` and `Form_6_INVENTAIRES.Button_VALIDER_Click` to identify their original transaction boundaries, stock movement write order, and failure recovery before introducing any extraction. Prepare a characterization fixture with an isolated DB and no actual store data. Record whether stock and journal updates are atomic; do not assume they are. Then continue with customer/supplier settlement paths and role checks.

The status in `docs/REQUIREMENTS_STATUS.md` is still partial and must be updated when new Windows characterization results exist. No source logic, schema, production records, UI or activation was changed by this inventory checkpoint.

## Receipt and inventory validation transaction review — 2026-10-30

Inspected actual `Button_VALIDER_Click` handlers in `Form_6_RECEPTIONS.cs` and `Form_6_INVENTAIRES.cs`. **Code-level observation only; rollback behavior has not yet been exercised in an isolated Windows/DB test.**

### Receipt validation (`Form_6_RECEPTIONS.Button_VALIDER_Click`)

- Disables validation button; exits early if list empty or current row already `VALIDER`; asks confirmation and selects the detail row.
- Opens `Module1.cn_SQL` if necessary, creates `MySqlTransaction` and assigns it to a reused `MySqlCommand`.
- For each detail row: reads `TABLE_ARTICLES.PRIX_MP` and `STOCK`; computes weighted purchase price using existing `Module1.FLOUSS` rounding when old stock > 0, otherwise uses current purchase price; updates article stock, purchase/sale prices and supplier; inserts a `TABLE_MOUVEMENTS_STOCK` row.
- After the loop, marks `TABLE_RECEPTIONS_ENTETE` and `TABLE_RECEPTIONS_DETAILS` `VALIDER`, then commits. Inner catch calls `Rollback` and displays a transaction error.
- **Risks requiring characterization:** SQL is assembled by concatenation (including supplier and row values); `Application.DoEvents()` inside an open transaction allows reentrant UI events; the code invokes `ExecuteNonQuery` for SELECT before `ExecuteScalar`; all referenced tables must use transactional storage for rollback. No claim yet about atomicity on runtime failure.

### Inventory validation (`Form_6_INVENTAIRES.Button_VALIDER_Click`)

- Same early empty/already-validated checks, confirmation, single connection/transaction and reused command pattern.
- For each detail row: updates `TABLE_ARTICLES.STOCK` and `STOCK_INITIAL` to `Stock_Physique`, sets `DATE_INVENTAIRE`; then inserts `TABLE_MOUVEMENTS_STOCK` with `LIBELLE='Inventaire'` and `QUANTITE=Stock_Physique` (absolute physical quantity as written, **not visibly a stock delta**).
- Marks `TABLE_INVENTAIRES_ENTETE` and `TABLE_INVENTAIRES_DETAILS` `VALIDER`, commits; inner catch rolls back and displays a transaction error.
- **Risks requiring characterization:** the movement quantity semantics might differ from a before/after delta requirement; do not silently change it. SQL concatenation and `Application.DoEvents()` inside transaction require separate risk review. Verify transactional table engines and failure rollback on an isolated DB.

### SAVE is a separate lifecycle boundary

Both forms also implement `Button_SAVE_Click` with document writes; the examined SAVE handlers contain no `BeginTransaction`/`Commit`/`Rollback` calls. This **does not prove** a failed save leaves partial data: trace any delegated calls and test failure boundaries before assigning defect status. Validation and save should be characterized separately.

### Next test acceptance (no production DB)

1. In isolated MariaDB, seed two article rows and one pending receipt/inventory header with details; capture pre-state of stock, prices, movement count and document status.
2. Exercise the **original** validation handler on Windows with a bounded dialog watcher, confirming both normal completion and injected failure on the second movement insert; after failure assert every captured value remains unchanged and no partial movement remains.
3. Record table engines and transaction attachment of every executed command. If rollback fails, open a separate bug report with reproducer; do not alter financial/inventory semantics in a refactor PR.
4. Characterize SAVE's header/detail write ordering separately, then consider a minimal behavior-preserving extraction.

No production code, database, or UI was modified in this checkpoint.

## Verified DB rollback preflight and next original-handler tests — 2026-10-30

Windows CI [40986857187](https://github.com/hmasprod-a11y/LOGICA-Recovery/actions/runs/40986857187) passed on commit `2660b3cc`. The isolated `inventory-transaction-preflight` verifies a deliberately failed second insert rolls back its dedicated InnoDB movement table (0 rows) and restores its dedicated header state (1 pending row). This **does not exercise** original receipt or inventory validation handlers. The recovered database audit independently listed `table_articles`, `table_mouvements_stock`, `table_receptions_entete`, `table_receptions_details`, `table_inventaires_entete`, and `table_inventaires_details` as **InnoDB**. Storage-engine support alone is not proof of each original form's transaction behavior.

Next characterization was added in `scripts/test-pos.cs` and registered in `scripts/test-pos.ps1` as `inventory-empty-validation`: invoke each actual `Button_VALIDER_Click` with an empty document list and verify the original handler returns without changing rows and re-enables the validation button. This is an early-return-only smoke test; it does not touch inventory records and must pass Windows CI before being treated as evidence. **Further acceptance:** original-form success and second-movement-failure scenarios on an independently constructed isolated receipt/inventory fixture, with bounded UI dialog handling and before/after DB comparisons.

## Original WinForms VALIDATE acceptance fixture design — 2026-10-30

**Latest verified baseline:** [Windows CI 40996836522](https://github.com/hmasprod-a11y/LOGICA-Recovery/actions/runs/40996836522) passed on `0f15b961`, including rollback of original-schema article, receipt/inventory header/detail and movement rows after an injected duplicate key. The later two-article test `471e2b5b` passed [Windows CI 40997598560](https://github.com/hmasprod-a11y/LOGICA-Recovery/actions/runs/40997598560). Neither test invokes original `Button_VALIDER_Click` on a nonempty, accepted document.

### Confirmed original-handler dependency order

1. `Form_6_RECEPTIONS` and `Form_6_INVENTAIRES` constructors initialize settings/forms (receipt requires `Form_0_TEMPLATE.ListView1` `HT_TTC`).
2. `DataGridView1` must contain a selected pending row with `ETAT != VALIDER` and `ID_BR` or `ID_INV`. Clicking **Yes** at `Voulez-vous vraiment Valider le Bon N° ...` triggers a synthetic `DataGridView1_CellClick` on column `cons` **before** `BeginTransaction`.
3. The cell-click handler reads the form's in-memory `DT` at the binding-context position, populates document header controls, then queries `TABLE_RECEPTIONS_DETAILS` / `TABLE_INVENTAIRES_DETAILS`, fills `DataGrid_BODY`, and recalculates totals. A fixture supplying only grid rows cannot prove this path: it must also provide a matching `DT` and isolated database header/detail records.
4. `Button_VALIDER_Click` then starts a transaction, processes each detail and inserts stock movements, marks both document tables validated, commits, and reloads the list. Receipt updates weighted purchase cost, prices, supplier and stock; inventory replaces physical/current/initial stock. Failure handling uses a modal, rollback and subsequent UI reload.
5. Existing early-return and **No** modal characterization is separately verified; do not conflate these with an accepted validation transaction.

### Safe next bounded test

- Construct the **isolated** `logica_ci` receipt/inventory schema and two-row pending-document fixture using captured original column shapes, without touching real data. Set `DT`/grid/binding context exactly as the original list loader would; initialize `HT_TTC` and other original runtime settings.
- Handle confirmation/validation/error dialogs using a scoped thread watcher and the existing per-process 60-second timeout; fail closed if an unexpected dialog appears, rather than clicking **Yes** indiscriminately.
- Capture pre-state for both articles (stock, `PRIX_MP`, `Prix_A`, `Prix_V_1`, `STOCK_INITIAL`, `DATE_INVENTAIRE`, supplier), both header/detail statuses and all movement rows. Verify normal accepted commit separately for receipt and inventory.
- Inject failure on the **second** movement insert; ensure the watcher dismisses the original handler's transaction-error dialog and that both products, both document status sets and all movements return to pre-state. Then separately verify the original form's button/error-state cleanup.
- If fixtures fail before `BeginTransaction` (e.g., `DataGridView1_CellClick`, missing configuration), classify as **harness prerequisite**, not a rollback defect. If original handler executes and rollback genuinely fails, open a separate behavior-fix PR rather than altering code in this audit.

**Scope note:** no evidence yet that the accepted/failed original WinForms posting path passes. Audit and fixture design are not acceptance results. Preserve all legacy financial, stock, and validation semantics pending characterization.

### Recovered receipt lot-field discrepancy — verified 2026-10-30

- [Windows run 41000041280](https://github.com/hmasprod-a11y/LOGICA-Recovery/actions/runs/41000041280) passed the original `LOGICA.exe` visible startup check, but failed the new original-handler schema prerequisite: `TABLE_RECEPTIONS_DETAILS.N_LOT` absent.
- Recovered Access SQL `input/recovered-original.sql` lacks this column. The original `Form_6_RECEPTIONS.DataGridView1_CellClick` **reads** `val6["N_LOT"]` when populating the receipt detail grid. This is a documented mismatch between recovered data and original executable expectations, not proof that the receipt posting handler failed.
- Additive isolated import compatibility migration in commit `68dbe135` appends `N_LOT varchar(255) DEFAULT ''` to `TABLE_RECEPTIONS_DETAILS`. It does not alter the original recovered SQL dump or existing receipt values.
- [Windows run 41000494090](https://github.com/hmasprod-a11y/LOGICA-Recovery/actions/runs/41000494090) **passed**, including visible real executable startup, the original-handler column prerequisite checks for all six receipt/inventory tables, two-article transaction rollback, isolated data verification, and packaging.
- **Boundary:** this proves isolated *schema compatibility* and independent rollback checks. No accepted, populated original WinForms `Button_VALIDER_Click` path has been verified yet. Prioritize executing that path with deliberately isolated document fixtures before claiming end-to-end validation or changing original handler code.
