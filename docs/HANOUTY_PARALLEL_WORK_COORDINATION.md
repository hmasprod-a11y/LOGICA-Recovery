# Hanouty V2 — Parallel Work Coordination

Updated: 2026-11-01. Shared coordination reference for four independent development tracks.

## Ownership
- Track A — Modern Core / Checkout: PR #70, branch `feature/hanouty-modern-core-dual-target`. Owns `modernization/LOGICA.CoreCompatibility.csproj`, `modernization/CoreSources.props`, `modernization/PortableCheckoutSmoke.cs`, `recovered-source/LOGICA/Application/Checkout/CheckoutVariantSnapshotService.cs`, `scripts/test-checkout-core.ps1`, and `.github/workflows/hanouty-modern-core-compatibility.yml`.
- Track B — Commercial workflows: Inventory/Catalogue, purchase/supplier workflows and related tests. PR #72, branch `feature/hanouty-business-receipts-stockcount-20261101`. Do not edit Track A-owned files without explicit PR coordination.
- Track C — Desktop WinForms and UI/UX: PR #71, branch `feature/hanouty-desktop-sales-contrast`. Owns screen presentation and UI regression scripts; do not modify checkout core without Track A review.
- Track D — QA, Windows verification, CI and packaging: PR #73, branch `qa/release-artifact-success-gate-20261101`. Owns release verification and artifact gates; coordinate workflow changes before editing.
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

## Checkout / inventory integration boundary (2026-11-01)
- Track A added `CheckoutVariantSnapshotService.ResolveChosenVariant(currentMatches, displayed, selectedIndex)` on PR #70. The displayed variant list is a read-only snapshot, and the selected ID must be re-resolved against the current result set. Index -1 means cancellation; stale, missing or ambiguous identity yields no row. This service does not post sales, change stock or query a database.
- Track B PR #72 has read-only purchasing/stock-count preview services. Do not wire their stock adjustments into Checkout or change posting semantics until a reviewed contract identifies the stock movement owner, transaction boundaries, and isolated MariaDB integration tests.
- Track C may consume the snapshot selection contract in UI only after coordination on legacy barcode selection behavior; no silent first-match for duplicate barcodes.
- Track D should verify .NET Framework independent checkout isolation, Windows POS, .NET 10 smoke and packaging for PR #70 before recommending merge. No cross-track files were edited in this batch.

## Modern checkout UI outcome contract (2026-11-01)
- Track A added `CheckoutVariantSnapshotService.EvaluateChoice(currentMatches, displayed, selectedIndex)` in PR #70. This is a read-only API with `CheckoutVariantChoiceStatus` = Selected, Cancelled, Missing, Ambiguous, InvalidCandidates and a non-null `SelectedRow` only on Selected.
- Track C may display separate messages for cancelled, stale, duplicate and invalid result sets, but must coordinate before wiring it into WinForms. The legacy `ResolveChosenVariant` and checkout posting flow are intentionally unchanged.
- Track B continues to own catalogue identity and inventory mutation; Track A's choice result never updates quantity, price, stock or the database. Track D should check Domain isolated Windows, .NET 10 portable and Windows POS gates before integration.

## Modern checkout identity hardening (2026-11-01, Track A)
- Track A hardens only `CheckoutVariantSnapshotService.Read` and `EvaluateChoice` and their portable smoke assertions. No WinForms, Inventory, Purchasing, MariaDB, shared CI or release files changed.
- Read-only snapshot excludes `DataRowState.Deleted` rows before accessing columns; a blank `ID_ARTICLE` is invalid, but an empty `Code` remains valid for image-only catalogue articles.
- Typed choice detects the same `ID_ARTICLE` repeated with different barcode values as Ambiguous; it scans all active rows so any malformed candidate takes precedence as InvalidCandidates even if an earlier duplicate exists. It never mutates stock, price or the live query.
- Track B owns catalogue identity writes and inventory transactions; Track C owns user-facing choice handling; Track D owns Windows/MariaDB release gates. Please review these outcome semantics before UI integration. No automatic cross-track merge.

## Modern checkout resolution parity (2026-11-01, Track A)
- Track A now routes `Resolve` and `ResolveChosenVariant` through the same read-only candidate validation as `EvaluateChoice`. These APIs still return `DataRow` on an exact match or `null` on cancellation/stale/unsafe results, but now fail closed for pending-deleted rows, duplicate `ID_ARTICLE` (even under a different barcode), unrelated corrupt rows and incomplete candidate schemas.
- `EvaluateChoice` retains the typed outcome contract; a live result missing `Code` or `ID_ARTICLE` is `InvalidCandidates`, not an unhandled lookup exception. `Read` still requires valid catalogue columns and IDs. Valid image-only products with an empty barcode remain selectable.
- Scope: only `recovered-source/LOGICA/Application/Checkout/CheckoutVariantSnapshotService.cs`, `modernization/PortableCheckoutSmoke.cs` and this Track A coordination document. Track B owns catalogue identity/stock mutations, Track C owns WinForms wiring, Track D owns release/MariaDB CI. No production database, pricing, activation, or cross-track workflow files changed.
- Integration caution: Track C should use `EvaluateChoice` to distinguish invalid/stale/ambiguous outcomes rather than infer them from `Resolve` returning null; request review before wiring to legacy checkout.

## Image-tile checkout revalidation parity (2026-11-01, Track A)
- Reserved Track A files: `recovered-source/LOGICA/Application/Checkout/CheckoutArticleTileSelectionService.cs`, `modernization/PortableCheckoutSmoke.cs` and this coordination document. Checked open PR #69/#71/#72/#73 changed-file lists before editing; no overlap.
- Proven gap in original `FindExact`: it could return a pending-deleted row or match an ID whose barcode was changed, and unrelated corrupt candidates were not rejected. `FindExact` now delegates to the shared, read-only typed choice validation via `EvaluateExact`. A valid exact ID+barcode remains selectable even when other articles share its barcode; reused IDs, duplicate IDs, corrupt result sets and pending deletions fail closed.
- `TagFor` rejects deleted/detached rows, missing columns and incomplete identities, but retains the existing barcode `ToString()` compatibility and valid empty-barcode image tiles. No stock, pricing, database, activation or legacy WinForms changes.
- Track B (#72) retains catalogue/stock writes. Track C (#71) owns UI integration and should review `EvaluateExact` outcomes before changing screens. Track D (#73) owns CI/MariaDB/release packaging; no shared CI files modified. The new regressions run through existing portable checkout smoke, .NET 10 and Windows gates. No merges to release/main.
