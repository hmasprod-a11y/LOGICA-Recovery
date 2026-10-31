# LOGICA 2.0 Beta RC1 — Windows x86 release candidate

This is a **candidate for isolated acceptance**, not an automatic upgrade or a production-approved release.

## What is included

- The recovered Windows Forms POS targeting **.NET Framework 4.8, x86**, with original runtime DLLs and launcher scripts.
- The integrated, behavior-preserving Domain/Application/Infrastructure refactors and compatibility adapters.
- A separate **.NET 10 portability test core** for selected logic. The Windows POS itself has **not** been migrated to .NET 10, the web, or Microsoft Store.
- No production shop database, store credentials, or original license.

## Download and verification

1. Open the latest **successful** Windows run for PR #56 in GitHub Actions.
2. Download artifact `LOGICA-2.0-Beta-RC1-Windows-x86`. It contains:
   - `LOGICA-2.0-Beta-RC1-Windows-x86.zip` — the full Windows runtime directory.
   - `SHA256SUMS.txt` — SHA-256 of that ZIP.
   - `LOGICA-2.0-Beta-RC1-file-manifest.json` — per-file hashes and sizes.
   - `verify-beta-rc.ps1` — offline, read-only verifier for the complete ZIP and manifest.
3. Keep the four release files together and run `powershell.exe -NoProfile -File .\\verify-beta-rc.ps1` in the downloaded artifact folder. The verifier checks the ZIP SHA-256, every file hash/size, manifest path safety, required runtime files, build provenance, and empty license state **without extracting or executing the application**. Do not run a ZIP that fails verification.
   - Alternatively, use `pwsh -File .\\verify-beta-rc.ps1` on systems with PowerShell 7.
   - Hashes detect corruption and mismatches; they **do not independently authenticate the publisher**. Obtain all four files from the same trusted GitHub Actions run and verify its source commit.
4. Extract into a **new folder**, not over an existing working installation. Follow `RUNNING.md` inside the package.
5. Keep all DLLs, configuration files, and launcher scripts together. Test using a **copy** of store data, never the original database.

The build includes an automated gate that checks the executable, DLLs, launchers, absence of persisted test DB credentials/data, per-file hashes, ZIP extraction, and rejection of a deliberately modified file. An additional independent offline verifier is tested against isolated malformed ZIP, checksum, manifest and license fixtures. It also checks provenance: commit, net48, x86, and no original shop database.

## Acceptance gates

- Windows build of original POS and isolated MariaDB POS tests: **required**.
- Recovered-data verification and portable launcher check: **required**.
- Release ZIP verification and tamper detection: **required**.
- Domain characterization tests: **required**.
- .NET 10 Linux portable-core build and smoke tests: **required**.
- Physical hardware (receipt printer, barcode scanner, cash drawer, payment peripherals), original license and realistic store backup: **manual checks still required before production**.

Do **not** merge into `main`, overwrite a shop database, or replace the working installation merely because CI is green. Release approval requires review of the complete integrated diff and a rollback plan for the shop installation.

## Rollback

Keep the original application folder and its original configuration, valid license, database and backups untouched. If the candidate fails, stop it and return to the original installation; never use CI test fixtures to restore production data.

## Sources

- Release candidate branch: `release/logica-2.0-beta-rc1`.
- Review: PR #56, targeting `integration/codex-refactors-20261030`.
- Release gate: `scripts/test-release-candidate.ps1`.
- Package and independent ZIP verification: `scripts/package-beta-rc.ps1` and `scripts/verify-beta-rc.ps1`.
- Isolated negative regression cases: `scripts/test-beta-release-verifier.ps1`.
- Windows workflow: `.github/workflows/windows-reference-diagnostic.yml`.
