# QA Sprint 48H — Unified refresh (2026-11-01 16:48 UTC)

This branch is a staging candidate ONLY, not an approved release. Its parent is PR #78 integration SHA 798aa65535fd78f5b9166573e730319715747cfc, which passed Windows POS + isolated MariaDB, Domain, .NET 10 and packaging. This refresh applies exact changed-file blobs from independently green heads, without merging release/main:

- Track C PR #77 d0eedd43e59f1a9b7c9ada61f43ded17b4fbe3db (3 UI/Windows POS regression files); prior failing test was corrected and its exact-head Windows run 41327437327 passed.
- Track B PR #72 9b6c280fec6ecd3ff422db722861b9f65d75f7f4 (7 changed files since frozen PR #78 source; includes real receipt screen, selection service, and regressions).
- Track A PR #75 2696246b99398b3d3d17c44cb5d52ba8b20ceee8 (5 changed files since frozen PR #78 source; includes barcode selection validation and regressions).
- Track D QA PR #73 8ce8e8ad62d9f189f94ee215411c9ee3c9a2150e already included in PR #78.

PR #74 stock movement flow is deliberately NOT added: it is stacked on an older Track B base and overlaps with latest #72 in business entry, smoke project, test-catalogue script and catalogue entry; not needed for the minimum testable legacy-compatible Windows release. Reconcile only after a separate reviewed merge and green combined gates.

**Release gate**: Windows x86 build; isolated MariaDB; POS sale/return/barcode/stock/printing characterization; real EXE startup; Domain regression; .NET 10 portable/dual-target; package integrity, DLLs, offline launcher and manifest. Check all on the exact combined commit. Hardware printer, barcode scanner, cash drawer, licensed field workstation, and production-like shop data remain UNVERIFIED. Do not bypass activation or edit real shop DB. No main/release merge.

## Extracted customer ZIP acceptance gate (2026-11-01)

The original Windows smoke previously exercised `dist/LOGICA.exe` and the `dist/Launch-LOGICA.ps1` launcher before packaging. The ZIP integrity gate extracted the ZIP and checked SHA256, but did not launch its extracted binaries. `scripts/test-extracted-release.ps1` now runs after ZIP creation in the Windows workflow and gates artifact uploads on both:

1. Re-run the packaged independent manifest/SHA/provenance verifier, extract the exact customer ZIP to a fresh Windows runner temporary directory, reject private DB state, and require the **packaged** `LOGICA.exe` to display a responsive WinForms main window against the already-isolated loopback CI database on port 3307.
2. Execute the **packaged** `Launch-LOGICA.ps1 -ServerBin <existing CI MariaDB> -Port 3308 -VerifyOnly` with a new temporary data directory. This uses no network download and checks the recovered original fixture's 120 products and 11 ticket headers. Temporary credentials and database files are deleted with the extraction; no production database is accessed.

This gate is an additional technical smoke, **not** a hardware/field test. Printer hardware, physical scanner, cash drawer, licensed machine, and representative shop data remain unverified. **Offline-first caveat:** a clean workstation without a local MariaDB server still needs the launcher's initial MariaDB download; the CI test supplies the server offline and does not prove zero-network first-run installation. Do not claim a fully offline cold install. No license bypass, shop data mutation, or merge into `main`/`release`.

The independent QA PR #81 overlaps the same ZIP collision files as this branch; do not merge both sets blindly. The separate PR #79 still fails three regression gates and remains excluded. Newer Track A/B/C heads must be re-evaluated on a combined SHA before inclusion; individual green gates do not authorize a release merge.


## 2026-11-01 — latest unified integration and field-smoke hardening

The previously verified exact candidate `f757a1333b76c09cd0ed9db2f114548b33298cdc` passed Windows/isolated MariaDB (Actions run 41353449011), Domain (41353448985), portable .NET 10 (41353449015), and modern compatibility (41353449057). Windows logs prove the **extracted** customer ZIP opened a responsive real WinForms window, preserved 86 immutable runtime files (EXE, DLLs, configuration, empty license placeholder, printer defaults and recovery SQL) after startup and the supplied local MariaDB launcher, rejected modification/deletion probes, and cleaned temporary plaintext MariaDB client credentials. This is a CI test of an isolated extracted copy, not a shop or hardware acceptance.

The next candidate integrates reviewed **bug fixes**, not a new POS product, from independently green track heads:
- Track B PR #72 `8a17cead8e98a699b548ca72254639e1b5c75db4`: correct receipt-grid totals for the edited row, remove only the clicked article line after identity recheck following confirmation, and avoid duplicate KeyPress handlers. Minimal shared guard and 14 new Domain assertions are included; unrelated Track B features are not wholesale copied.
- Track C PR #77 `a127c0bf5b05d1ef1195ed3c9dfb637c8e72615e`: preserve the original full product list, select no-barcode/no-photo articles by exact ID, reject stale/empty list selections, keep barcode scans on the legacy exact-barcode/duplicate-chooser path, and cover keypad/scanner/keyboard regressions. The existing QA Ctrl+F implementation and its stronger regression test are preserved; a duplicate test method introduced by the stacked diff was removed before final CI.

The integration must pass **all four gates again on the final exact branch head**, including the real Windows POS smoke, extracted ZIP and isolated MariaDB, before its artifact may replace the prior verified fallback. Do not treat the individual Track B/C artifacts as a unified release. PR #79 is excluded because three core gates fail; PR #81 overlaps ZIP verifier files; PR #74 and latest Track A #75 remain unmerged pending review. Known limitations: physical printer/scanner/drawer, licensed shop workstation, representative shop database, first-run without an existing MariaDB binary, and end-to-end blank-Code image checkout posting are NOT proven. The legacy checkout fallback is retained. No shop data, license logic, main or release branch was changed.
