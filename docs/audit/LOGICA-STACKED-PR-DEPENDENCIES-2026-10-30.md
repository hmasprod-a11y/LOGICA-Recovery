# LOGICA POS 2.0 — Stacked draft PR dependency audit
Date: 2026-10-30. Scope: G1 Audit / G5 review; **documentation only**, not a merge authorization.

## Verified graph from GitHub PR metadata

```text
main
  └─ refactor/preserve-behavior-foundation
      └─ PR #14 integration/codex-refactors-20261030 (55 files changed)
          └─ PR #15 refactor/client-credit-calculation
              └─ PR #16 refactor/client-settlement-amount-guard
                  └─ PR #17 refactor/client-settlement-sequence
                      └─ PR #18 refactor/client-settlement-row-mapping
                          └─ PR #19 refactor/client-settlement-validation-flow
                              └─ PR #20 tests/client-settlement-save-acceptance

Separate documentation branch:
main └─ PR #21 audit/workflow-gates-baseline-20261030
     └─ this follow-up: stacked dependency review
```

Caution: the diagram's `main → refactor/preserve-behavior-foundation` line represents the branch hierarchy described by PR metadata, **not proof that the parent branch itself contains only changes already approved for main**. Its diff must be audited separately.

| PR | Base ref | Head SHA | Observed scope | Current decision |
|---|---|---|---|---|
| #14 | `refactor/preserve-behavior-foundation` | `2079d722` | Catalogue, stock movement, counted-cash integration; 55 changed files | Draft; review high change surface and upstream foundation |
| #15 | `integration/codex-refactors-20261030` | `f470b458` | Customer credit arithmetic extracted from WinForms | Draft; check correctness separately from parity |
| #16 | `refactor/client-credit-calculation` | `a7eeb569` | Original VB amount guard extracted | Draft; not equivalent to validating business correctness |
| #17 | `refactor/client-settlement-amount-guard` | `99da687e` | Legacy settlement ID computation | Draft; double-read / duplicate-ID exposure remains |
| #18 | `refactor/client-settlement-sequence` | `e9c1eaf` | Eleven-row-field write mapping and failure-order tests | Draft; persistence success only later tested in isolated CI |
| #19 | `refactor/client-settlement-row-mapping` | `e93e1d23` | Existing validation messages and guard order | Draft; no new functionality claimed |
| #20 | `refactor/client-settlement-validation-flow` | `87d240af` | Original form settlement-save acceptance fixture | Draft; `client-settlement-save PASS` on Windows run #41023211299; isolated successful write only |
| #21 | `main` | `310595e` | Initial workflow gates / evidence register | Draft; documentation only |

## What the latest PASS *does* and *does not* establish
Windows run: https://github.com/hmasprod-a11y/LOGICA-Recovery/actions/runs/41023211299

The completed Windows job successfully built and exercised the original POS and recovered-data portable checks. Job log explicitly contains:
- `client-settlement-save PASS`
- `PASS original client settlement accepted save: commandbuilder insert, next ID, row data, connection and sentinel`

The test uses `127.0.0.1:3307/logica_ci`, checks original sentinel preservation and one new persisted settlement, and proves neither concurrent writes nor repeated retry safety nor complete financial reconciliation. It cannot certify printer/cash-drawer hardware, other screens, permissions, or production stability.

## Required gates before approving any stacked merge
1. Inventory exact diff of `refactor/preserve-behavior-foundation` against `main` and document prerequisite decisions; current table **does not approve that foundation**.
2. Independently inspect PR #14's 55 files (including all production paths touched). Confirm no unrelated UI, activation, schema or merchant-data modifications.
3. Validate each subsequent PR on its *actual parent head SHA* with appropriate unit and Windows integration evidence; stale green runs on old SHAs are insufficient.
4. Verify the complete candidate tree on Windows after integration. Tests in intermediate branches are not proof of the final integrated tree.
5. Reproduce any proposed bug in a disposable DB before changing financial persistence, ID generation or business logic.
6. Require recorded human review and approval for merging. No auto-merge, force push, reset of main or shop data edits.

## Next executable G1 inventory candidate
`recovered-source/LOGICA/Form_5_CLIENTS_REGLE.cs`: enumerate entrypoints (`Button12_Click`, `Button_CLIENT_Click`, `_credit`), SQL reads/writes and UI effects, map existing tests to each path, identify uncovered error/retry/concurrency cases. Mark unknown paths **untested**, never **missing**. Keep this inventory separate from any code refactor.

## Sources
- https://github.com/hmasprod-a11y/LOGICA-Recovery/pull/14
- https://github.com/hmasprod-a11y/LOGICA-Recovery/pull/15
- https://github.com/hmasprod-a11y/LOGICA-Recovery/pull/16
- https://github.com/hmasprod-a11y/LOGICA-Recovery/pull/17
- https://github.com/hmasprod-a11y/LOGICA-Recovery/pull/18
- https://github.com/hmasprod-a11y/LOGICA-Recovery/pull/19
- https://github.com/hmasprod-a11y/LOGICA-Recovery/pull/20
- https://github.com/hmasprod-a11y/LOGICA-Recovery/pull/21

This is a dependency and test-evidence register, **not** a claim that all modules were inventoried or that mergeability was fully established.
