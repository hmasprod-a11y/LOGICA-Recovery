# QA Integration Probe — 2026-11-01 12:50 UTC (revised after negative-fixture CI failure)

Disposable combined snapshot only; **not** a production release or merge.

Base release: `d645b27cf32b6e333438fed144aa4186dabbd661`

Source PR heads (exact):
- PR #70: `f8e4e86d86f746814f05a9d6d1ddffca138c530c` — 8 files
- PR #71: `5cd3757d379eb7e7a4ca4d994c69654208cc8899` — 3 files
- PR #72: `3c214afd49db82ab531b2c7ccbc5f9311a338e5e` — 21 files
- PR #73: `2a9f6ce18f20f8ba47698278f48c08a8180f5ad7` — 2 files

No overlapping paths across these four source PRs. The first QA commit
`e04ecaba` failed its Windows policy regression gate because three new
negative fixtures accidentally used literal backslash-n, and an existing
test expected a different validation error. PR #73 commit `2a9f6ce`
corrected the fixtures and added a positive name-first upload regression.
This probe replaces only the QA script blob with that corrected version.

Verify Domain regression, portable .NET 10, dual-target shared core,
Business Operations, Windows POS x86, isolated MariaDB, launcher and
release integrity before treating this combined snapshot as CI-green.
Hardware and licensed workstation field acceptance remain outstanding.
No automatic merges to release/main or production database changes.
