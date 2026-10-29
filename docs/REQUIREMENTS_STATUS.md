# Requirements and acceptance status

This is an evidence map for Cahier des Charges V1 (2026-10-29), not a declaration that untested features are missing. LOGICA is the working baseline. The current authorized priority is incremental internal organization with preserved behavior. New features, UI redesign, technology migration, shop-data edits and activation changes remain outside this refactor.

Verified catalogue implementation before the current pending slice: 9c34d75b6bdb9cb4517d0d1f876c165a453ea4d1, Windows run [40935603894](https://github.com/hmasprod-a11y/LOGICA-Recovery/actions/runs/40935603894). Later-row fixture baseline passed in run [40937242346](https://github.com/hmasprod-a11y/LOGICA-Recovery/actions/runs/40937242346). Collection precheck service a9997936f06de91907f9b519b19a9100d202c651 passed independent tests and full Windows run [40938837380](https://github.com/hmasprod-a11y/LOGICA-Recovery/actions/runs/40938837380). See CATALOGUE_REFACTORING.md for per-commit evidence.

Status vocabulary: **partial evidence** = specified paths have passed, not the whole requirement; **process applied** = development practice observed; **audit required** = no complete acceptance evidence recorded here; **deferred by priority** = intentionally not expanded during behavior-preserving refactoring.

| Spec | Requirement | Evidence/status | Remaining acceptance work and risk |
| --- | --- | --- | --- |
| 1 | Preserve working Windows product, offline core, maintainability | Partial evidence: Windows build/startup, checkout and catalogue fixtures; original framework retained | Whole-product offline and stability audit on representative installation |
| 2 | P0/P1 scope and priorities | Priority applied to existing checkout/catalogue internals | Inventory every module; do not infer feature absence from lack of new work |
| 3 | POS sale, return, payments, chooser, suspended sale, shared barcode | Partial evidence: sale/return, mixed/change/credit payment, seller/client guard, stock/total rejection and rollback fixtures | Suspended sale, shared barcode selection, permissions, printer failures and repeated-click acceptance need explicit mapping |
| 4 | Inventory movements, counts, adjustments, traceability | Partial evidence: checkout stock validation/posting and catalogue opening movement fixtures | Counts/adjustments, before/after/source/user completeness and negative-stock policies across modules |
| 5 | Catalogue, prices, variants, import/export, price history | Partial evidence: all 33 individual product fields, creation/edit differences, barcode/balance rules; collection early guards/duplicate checks and in-memory variant insertion/checksum | Successful batch commit/rollback, import/export, price history and full variant behavior; preserve batch transaction ownership |
| 6 | Customers, suppliers, purchases, debt and balances | Audit required; checkout client/credit routing is only narrow evidence | Full account reconciliation, partial settlement, orders/receipts and documented balance movements |
| 7 | Cash sessions, income/expense, payment configuration | Partial payment-path evidence only | Session lifecycle, cash differences, cancellation authorization and financial reconciliation |
| 8 | UI/UX, Arabic/French, touch, resolutions | Deferred by priority; existing form/layout smoke checks are not UX acceptance | Device/resolution/language/user acceptance; no redesign claimed |
| 9 | Presentation/Application/Domain/Infrastructure separation | In progress: checkout and catalogue services/rules/stores with independent tests | Remaining forms/modules; no whole-architecture completion claimed |
| 10 | Database consistency, migrations, backup/restore, secrets | Isolated fixture enforcement and selected transaction/failure tests applied | Schema/relations, migration plan, restore drill and credential handling audit; no shop-data repair authorized |
| 11 | Authentication, permissions, secrets, activation, audit | Audit required; catalogue edit audit append checked on one path | Full role matrix, forbidden-operation tests, session lock and sensitive change traceability; activation unchanged |
| 12 | Barcode reader, printers, drawer, scale, touch | No hardware acceptance claimed; barcode/balance arithmetic is software-only evidence | Tests on actual devices; saved sale survives printer failure |
| 13 | Installation, update, rollback | Partial evidence: Windows package/launcher/startup checks | Clean-machine install, safe upgrade/rollback preserving real data and recovery instructions |
| 14 | Performance and integrity targets | No timed acceptance benchmarks claimed | Define hardware/data volume; measure startup/cart/sale latency. Existing individual catalogue partial-save behavior is characterized, not silently corrected |
| 15 | Unit/integration/UI and user acceptance | Partial evidence: independent rules/services, isolated DB/original-handler fixtures, visible form smoke checks | Full coverage map including permissions, backup, devices, concurrency and user acceptance |
| 16 | Execution phases | Phase 2 architecture active in selected areas | Audits/phase-1 evidence are partial; phases 3-9 are not declared complete |
| 17 | Branch/PR review, tests, isolated data, decisions | Process applied: draft PR #8 and stacked #10, reviewable commits, progress logs, no auto merge/release | Human review remains required before merging; migration documentation when migrations are authorized |
| 18 | Web/Android/cloud/AI outside first Windows release | Scope respected | No implementation commitment added |
| 19 | Proven state versus commercial readiness | Working source/build/selected tests/packages evidenced | Commercial readiness, all screens, full security and real devices remain unproven here |
| 20 | Requirement-by-requirement audit with files, risks, acceptance and effort | This map starts that deliverable; selected source/test paths below | Complete function/module inventory, classify existing/fix/missing/test/refactor per requirement and estimate effort only after audit |

## Verified source and test boundaries

- Checkout: recovered-source/LOGICA/Domain, Application/Checkout and Infrastructure/Checkout; see docs/REFACTORING.md. Fixtures in scripts/test-pos.cs cover selected original sale/return/payment/failure paths.
- Catalogue: recovered-source/LOGICA/Form_2_ARTICLES.cs, Domain, Application/Catalogue, Presentation/Catalogue and Infrastructure/Catalogue; see docs/CATALOGUE_REFACTORING.md.
- Independent tests: tests/*Tests.cs via scripts/test-domain.ps1; production Windows behavior: scripts/test-pos.ps1 and .github/workflows/windows-reference-diagnostic.yml.
- Collection: early rejection/pre-transaction lookup evidence only. Transaction loop, rollback, DoEvents and SendKeys tail require a separately isolated strategy before broad execution/extraction.

No global completion percentage is calculated: requirements are not equally weighted, and existing functionality must be audited rather than counted as missing. Effort estimates remain unassigned for unaudited modules.

Latest additional evidence: variant checksum reuse 4e52a89910db459e3be5582e462506c966445216 passed Windows run [40944010253](https://github.com/hmasprod-a11y/LOGICA-Recovery/actions/runs/40944010253), including raw attributes, fractional/negative quantities, totals/reset/selection and duplicate rejection. This is in-memory variant coverage, not batch database transaction acceptance.

Collection quantity accumulation was subsequently separated at b6200a8de2d41897ae8042182cce083176d2aabc and passed [Windows run 40947592637](https://github.com/hmasprod-a11y/LOGICA-Recovery/actions/runs/40947592637) plus 111 independent raw-type/culture/failure assertions. This does not establish batch transaction acceptance. The catalogue resume checkpoint is concise; its detailed history is retained in docs/archive/CATALOGUE_REFACTORING_HISTORY.md.
