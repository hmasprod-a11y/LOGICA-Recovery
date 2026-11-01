# QA Integration Probe — 2026-11-01 12:50 UTC

This is a disposable **test-only** combined snapshot, not a release or merge request.

Base release: `d645b27cf32b6e333438fed144aa4186dabbd661`

Source PR heads (exact):
- PR #70: `f8e4e86d86f746814f05a9d6d1ddffca138c530c` — 8 changed files
- PR #71: `5cd3757d379eb7e7a4ca4d994c69654208cc8899` — 3 changed files
- PR #72: `3c214afd49db82ab531b2c7ccbc5f9311a338e5e` — 21 changed files
- PR #73: `e04ecaba9b6d3c30c40bc89218a5364660f35b52` — 2 changed files

No source-file overlap was detected. Each changed blob was taken unchanged
from its respective PR head. CI on this branch is an integration gate only.
Do not deploy this branch or merge it to main/release automatically.

Required verification: Domain regression, portable .NET 10, shared dual-target
core, business smoke, Windows x86 POS, isolated MariaDB, launcher, release
integrity and packaging. Physical hardware and licensed store-workstation
acceptance remain outside CI and must be performed before production release.
