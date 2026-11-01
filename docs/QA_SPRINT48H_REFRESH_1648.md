# QA Sprint 48H — Unified refresh (2026-11-01 16:48 UTC)

This branch is a staging candidate ONLY, not an approved release. Its parent is PR #78 integration SHA 798aa65535fd78f5b9166573e730319715747cfc, which passed Windows POS + isolated MariaDB, Domain, .NET 10 and packaging. This refresh applies exact changed-file blobs from independently green heads, without merging release/main:

- Track C PR #77 d0eedd43e59f1a9b7c9ada61f43ded17b4fbe3db (3 UI/Windows POS regression files); prior failing test was corrected and its exact-head Windows run 41327437327 passed.
- Track B PR #72 9b6c280fec6ecd3ff422db722861b9f65d75f7f4 (7 changed files since frozen PR #78 source; includes real receipt screen, selection service, and regressions).
- Track A PR #75 2696246b99398b3d3d17c44cb5d52ba8b20ceee8 (5 changed files since frozen PR #78 source; includes barcode selection validation and regressions).
- Track D QA PR #73 8ce8e8ad62d9f189f94ee215411c9ee3c9a2150e already included in PR #78.

PR #74 stock movement flow is deliberately NOT added: it is stacked on an older Track B base and overlaps with latest #72 in business entry, smoke project, test-catalogue script and catalogue entry; not needed for the minimum testable legacy-compatible Windows release. Reconcile only after a separate reviewed merge and green combined gates.

**Release gate**: Windows x86 build; isolated MariaDB; POS sale/return/barcode/stock/printing characterization; real EXE startup; Domain regression; .NET 10 portable/dual-target; package integrity, DLLs, offline launcher and manifest. Check all on the exact combined commit. Hardware printer, barcode scanner, cash drawer, licensed field workstation, and production-like shop data remain UNVERIFIED. Do not bypass activation or edit real shop DB. No main/release merge.
