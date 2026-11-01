# Hanouty POS V2.0 — Modernization Execution Plan
Date: 2026-11-01
Status: APPROVED DIRECTION / EXECUTION BACKLOG — NOT A PRODUCTION RELEASE
Baseline: release/logica-2.0-beta-rc1 (verify moving head before each integration)
Scope: LOGICA remains the behavior reference; Hanouty V2 is the modern product. No wholesale rewrite.

## Verified repository evidence
- PR #56 reports a unified Beta RC1 and successful Domain, Linux .NET 10 portable-core, and Windows POS + isolated MariaDB workflows at head c96d346c397ffc4c81a03afc2acd2a884c32d3c0. This is a documented checkpoint, not proof of current HEAD green.
- PRs #61–#68 cover checkout search, image eligibility, barcode parameterization, duplicate variant selection, basket identity and tile identity. Check actual merge status and CI for EACH before integrating; PR #68 explicitly says pending.
- Legacy Windows application is .NET Framework 4.8 x86. Portable core already has .NET 10 coverage. Preserve both until measured parity and hardware acceptance.
- Physical printer/scanner/cash drawer, real shop-data copy and licensing acceptance are not complete.

## Architecture decision (ADR-001)
1. Modernize incrementally; do not rewrite in Rust/Tauri or migrate all UI/database at once.
2. Extract testable Domain / Application boundaries with .NET 10 compatibility; Infrastructure adapters retain MySQL/MariaDB and legacy VB semantics until explicit migration acceptance.
3. Existing WinForms .NET Framework 4.8 x86 remains release baseline. A new .NET 10 Windows shell/UI is a separate opt-in prototype only after checkout parity and hardware contract tests.
4. SQLite is a candidate, NOT an approved database migration. Require a complete schema/data mapping, integrity, migration/rollback tests, multi-terminal concurrency decision and measured performance first.
5. Offline-first is mandatory. No required server, login, cloud or internet for selling. Local device interoperability is future opt-in and not in this batch.
6. Protect real shop DB, configuration, licensing, keys, ticket numbering, tax, stock, transaction and price/rounding behavior. No production activation bypass.
7. Every functional change has isolated regression + Windows build + MariaDB integration + .NET 10 smoke + license/package safety gates. No automatic merge to main or live deployment.

## High-impact execution wave (parallel reviewable tracks, sequential safe integration)
### W0 — Baseline & release gates (P0)
- [ ] Record exact current release head SHA, integration base, PR #56 and #61–#68 merge state and required CI conclusions; avoid stale descriptions.
- [ ] Produce dependency/branch map; identify duplicated or superseded PRs. Merge only verified green, non-overlapping changes into release candidate.
- [ ] Rebuild Windows x86 EXE + all DLLs, .NET 10 portable core, Domain characterization and isolated MariaDB; publish SHA256 manifest, safe update candidate, reproducible logs.
- [ ] Add regression gate verifying no overwritten settings/license/database and a rollback rehearsal using synthetic shop data.
Acceptance: all relevant gates green on SAME SHA; artifact hashes verified; main unchanged.

### W1 — Checkout correctness & security (P0)
- [ ] Integrate and validate parameterized list/image search, family filter, exact barcode lookup (PRs #62, #64, #67).
- [ ] Verify only real decodable images appear in image tiles; ordinary list includes image-less items (PR #63).
- [ ] Verify duplicate barcode chooser, exact ID_ARTICLE basket identity and image tile identity (PRs #65, #66, #68).
- [ ] Regression matrix: keyboard/scanner emulation, repeated scan, cancel/escape, sale/return, price tier, quantity, weighing, stale ID, zero/one/many matches, SQL special characters, fr-MA/fr-FR/en-US.
Acceptance: zero cross-variant stock/price/basket contamination; no unexpected posting on cancellation; original transaction behavior preserved.

### W2 — Financial and inventory invariants (P0)
- [ ] Characterize cash/tender/change, discounts, VAT, rounding, returns and ticket sequence against original executable semantics.
- [ ] Test stock movement posting and rollback under each simulated failure stage; no double post or partial sale.
- [ ] Validate customer debts, partial settlements, supplier balances, export and audit trail under multi-culture inputs.
Acceptance: exact parity with documented original or explicitly approved bug fix, isolated MariaDB fixtures and durable rollback evidence.

### W3 — Portable core expansion (P1)
- [ ] Inventory remaining WinForms business logic dependencies; prioritize checkout, purchase, inventory, customer and supplier workflows.
- [ ] Extract one behavior-preserving service per PR with legacy oracle tests and net48 + net10 compilation.
- [ ] Keep UI, SQL access and VisualBasic compatibility behind explicit adapters. No broad formatting-only churn.
Acceptance: measurable decrease in UI-owned business logic, stable API contracts and green CI per PR.

### W4 — New UI feasibility spike (P1, no replacement yet)
- [ ] Compare WPF / Avalonia / WinUI options against actual printer, barcode, cash drawer, x86 and offline packaging constraints.
- [ ] Implement a small separate .NET 10 proof of concept for catalog browsing + basket rendering using read-only/synthetic data.
- [ ] Benchmark cold start, memory, 1k/10k product search and keyboard-only checkout ergonomics.
Acceptance: evidence-based UI choice and no regression to legacy checkout.

### W5 — Data architecture & release hardening (P1)
- [ ] Write MariaDB-to-SQLite feasibility report; do not migrate live data.
- [ ] Validate backup/restore, corrupt DB recovery, versioned migrations, safe updater and local data retention.
- [ ] Create physical hardware acceptance checklist and shop-copy anonymization protocol; manual signoff required.
Acceptance: reproducible clean install and rollback, tested with synthetic data; physical gates marked BLOCKED until performed.

## Integration rules
- Work in small focused PRs, each referencing W0–W5 and recording source SHA, changed files, tests, workflow links, risk and rollback.
- Large wave means many impactful workstreams, not a single unreviewable mega-commit.
- If any gate fails: stop merge, diagnose actual log, repair and rerun; never mark a pending gate successful.
- Release branch only until verified. Do not auto-merge main, modify original shop data or deploy.
- Keep TODO/Safqah as optional UX/architecture research, not sources for unlicensed code.
- Hourly automation must inspect this plan, current branch head and open PRs, avoid duplicate tasks, and report only verified actions.

## Definition of Done
Same SHA: Domain + net10 + Windows x86 + isolated MariaDB + package/license/backup safety green; functional acceptance matrix complete; downloadable signed-or-hashed artifacts; manual hardware and real-shop-copy signoff before production.
