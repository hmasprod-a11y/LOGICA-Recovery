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
