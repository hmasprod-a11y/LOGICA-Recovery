# LOGICA POS 2.0 — Audit gate and baseline register (initial)
Date: 2026-10-30
Status: **INCOMPLETE / evidence register, not functional certification**.
Reference: Cahier des charges V1.0 (2026-10-29), §16–17 and §19–20.

## Non-negotiable workflow
**Audit → Baseline → Small Change → Tests → Review → Approved Merge → Next Task**.

LOGICA is the sole implementation baseline. TODO POS may inform later selective UX decisions, but its code/architecture must not replace LOGICA. Existing functionality must not be declared absent before inspection. Preserve current observable behavior during refactors; treat correctness changes as separate, proven-defect tasks. Avoid broad UI redesign/new features in stabilization. Never use merchant data as a disposable test database; keep licensing/activation unchanged. No automatic merges.

## Gates for every task
| Gate | Required evidence |
| --- | --- |
| G1 Audit | Actual original handler, module/file path, inputs/outputs, DB writes, exceptions, UI effects and known unknowns |
| G2 Baseline | Reproducible characterization test of current behavior, or documented blocked-verification reason |
| G3 Scope | One bounded change, risk level, rollback strategy; no unrelated features |
| G4 Tests | Targeted test plus Windows build / relevant integration test; provide exact run and commit |
| G5 Review | Diff review including persistence/permissions/connection/error and regression risks |
| G6 Merge | Human approval after all parent PRs pass; never auto-merge or bypass stacked dependencies |

A green build is *not* business-function acceptance. Do not extrapolate an isolated happy-path test to concurrency, printer devices, financial reconciliation, or real deployment.

## Verified current evidence (not an exhaustive product inventory)
| Area | Observed evidence | Status / unverified |
| --- | --- | --- |
| Original Windows application | Windows run #41023211299 completed successfully on branch `tests/client-settlement-save-acceptance`; stages include build, isolated DB POS exercise, recovered Access-data verification, portable runtime verification and artifact upload | CI-pass on that branch only; hardware and commercial acceptance unverified |
| Customer settlement save | PR #20 adds original-form test `client-settlement-save` in `scripts/test-pos.cs` and `scripts/test-pos.ps1`. Windows job log states `client-settlement-save PASS` and `PASS original client settlement accepted save: commandbuilder insert, next ID, row data, connection and sentinel` | Isolated `127.0.0.1:3307/logica_ci` only. Retry, duplicate IDs, simultaneous cashiers, reconciliation and printer failure NOT proven |
| Customer settlement rules | PRs #15–#19 extract original credit arithmetic, amount guard, sequence, row assignment and warning order as narrow behavior-preserving changes | Each PR is draft; financial sign correctness/transactions not established by extraction |
| Catalogue / stock movement / counted cash | PR #14 integrates prior extraction work (#10–#12); PR #8 covers checkout architecture | Review tests at exact head SHAs and integration dependency chain before claims of completion |
| UI / distribution / security / full inventory | No complete documented acceptance coverage established in this register | Needs G1 inventory across modules; do not label functions missing without testing |

### Evidence links
- PR #20: https://github.com/hmasprod-a11y/LOGICA-Recovery/pull/20
- Last checked successful Windows CI: https://github.com/hmasprod-a11y/LOGICA-Recovery/actions/runs/41023211299
- Windows job log: job `123955148455`; same run.
- PR #14: https://github.com/hmasprod-a11y/LOGICA-Recovery/pull/14
- PR #15–19: https://github.com/hmasprod-a11y/LOGICA-Recovery/pulls

## Immediate, bounded next work
1. Inventory the current `main` baseline: module by module, actual screens/handlers, DB tables, behavior and coverage. Record **working / defect reproduced / untested / refactor candidate**; do not equate undocumented with missing.
2. Audit dependency graph for draft stacked PRs #14–#20: record base/head SHA, test URLs and scope. Note: **PR #20 bases on PR #19, not main**.
3. Record passing CI per exact commit, and run fresh Windows tests on the *integrated candidate* before any merge decision. Request explicit human approval for merge.
4. Separately characterize real settlement failures / duplicate retries / concurrent ID allocation using disposable CI data before proposing persistence changes.
5. Only after approved inventory and regression baseline: continue small, behavior-preserving refactors ranked by operational risk.

## Task record template
- Task ID / requirement / priority:
- Original source and handler:
- Observable baseline (inputs, warnings, SQL, order, side effects):
- Status (working / reproduced defect / untested / refactor candidate):
- Isolated test and expected outcome:
- Scope and excluded changes:
- Windows run / head commit / artifacts:
- Diff review and known remaining risks:
- Approval / merge decision:

This register is intentionally conservative: its existence does **not** certify an exhaustive audit or authorize merging existing drafts.
