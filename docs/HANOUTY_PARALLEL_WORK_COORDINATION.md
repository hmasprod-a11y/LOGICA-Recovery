# Hanouty V2 — Parallel Work Coordination

Updated: 2026-11-01. Shared coordination reference for both hourly development tracks.

## Ownership
- Track A — Modern Core / Checkout: PR #70, branch `feature/hanouty-modern-core-dual-target`. Owns `modernization/LOGICA.CoreCompatibility.csproj`, `modernization/CoreSources.props`, `modernization/PortableCheckoutSmoke.cs`, `recovered-source/LOGICA/Application/Checkout/CheckoutVariantSnapshotService.cs`, `scripts/test-checkout-core.ps1`, and `.github/workflows/hanouty-modern-core-compatibility.yml`.
- Track B — Commercial workflows: Inventory/Catalogue, purchase/supplier workflows and related tests. Create a different branch and PR. Do not edit Track A-owned files without explicit PR coordination.
- Shared areas (checkout/inventory stock posting, SQL schemas, packaging, CI): announce intended files and dependencies in PR description before editing. One integration owner at a time; rebase on exact release HEAD before merge.

## Every hourly development cycle
1. Inspect release head, open PRs, last CI conclusions and other track's changed files. Never rely on old claims.
2. Implement a meaningful reviewable batch of code fixes/features AND associated regression tests in parallel.
3. Fix any failing required gate, not just report it. Test Windows legacy build, Domain isolation, .NET 10 and isolated MariaDB where relevant.
4. Publish PR, exact SHA, test run links, outstanding blockers and file ownership changes.
5. No direct production DB edits, activation changes, automatic merges to release/main, or changes to offline-first behavior.

## Current integration
- Release baseline at coordination creation: `d645b27cf32b6e333438fed144aa4186dabbd661`.
- Track A PR #70: https://github.com/hmasprod-a11y/LOGICA-Recovery/pull/70
- Planning-only PR #69: https://github.com/hmasprod-a11y/LOGICA-Recovery/pull/69
- Both tracks must check for newer PRs and update this coordination file through a reviewed change if ownership changes.
