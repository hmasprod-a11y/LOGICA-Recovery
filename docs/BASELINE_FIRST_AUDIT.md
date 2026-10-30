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
