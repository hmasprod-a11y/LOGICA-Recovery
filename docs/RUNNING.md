# LOGICA Windows recovery

This package contains the recovered original LOGICA WinForms program, targeting .NET Framework 4.8, x86. Extract the entire ZIP to a writable local directory and keep LOGICA.exe, LOGICA.exe.config, all DLLs and the .sni configuration files together. Start LOGICA.exe on Windows with .NET Framework 4.8 installed.

## Existing installation

Use the original installation's SQL database, `bd` directory, `.sni` settings and valid license files. These were not present in the supplied source/dependency archives. The included configuration defaults point to localhost and disable peripherals; they are not the original shop's settings. Copy the recovered program and libraries into a copy of the original installation, retaining its database/settings, before checking real transactions.

The database connection can be supplied with the `LOGICA_DB_CONNECTION_STRING` environment variable. Without it, the recovered program uses its existing connection fields and `CHEMIN_DB.sni`; the port is now passed separately as required by MySQL. `CHEMIN_FOLDER.sni` accepts the portable value `Application.StartupPath`.

## Verification

GitHub Actions builds the committed `recovered-source/LOGICA.csproj` on Windows. `scripts/test-pos.cs` loads the produced EXE and invokes original forms and business methods. Test data lives in an isolated MariaDB instance on 127.0.0.1:3307 in the `logica_ci` database. Fixtures cover only the SQL tables required by these tests and are not a recovered shop database.

The diagnostics artifact records each test's actual status, errors and rendered forms. Cash checkout/refund tests, when passing, verify ticket headers, sales journal, cash payment/refund records, stock changes and movements, cleared basket and incremented ticket numbers. They do not validate a physical printer, cash drawer, scale, RFID reader, a payment terminal, or the missing original shop database/license.

Do not replace the original database with CI fixtures. Test harness executables are removed from the delivered runtime.

## LOGICA 2.0 Beta RC1 — isolated trial only

This ZIP is **not an installer, upgrade, or production database migration**. Unzip it into a NEW, writable directory; never unpack it over an existing store installation. Before any trial involving a store, back up its original program folder, `.sni` files, license material and database, and test only with a separate copy of that database.

The beta package deliberately sets `CHEMIN_DB.sni` to `127.0.0.1`, `CHEMIN_FOLDER.sni` to `Application.StartupPath`, and all `PRINTER_*.sni` entries to `0`; it contains no copied license hash or previous runtime error log. **These defaults are not the store's printer or license configuration.** They must not be used to overwrite an existing installation's settings.

Before testing, obtain the `LOGICA-2.0-Beta-RC1-Windows-x86` GitHub Actions artifact, then run `verify-beta-rc.ps1` from the downloaded release directory to check the ZIP, file manifest and source-commit provenance without launching the program. A matching SHA-256 detects accidental changes but does not by itself authenticate the publisher; download from the trusted repository's Actions run.

The original Windows executable remains .NET Framework 4.8 x86. The separate .NET 10 project tests portable core components; it is **not** a .NET 10 replacement for the Windows POS. Windows Store, browser deployment, real payment terminals, cash drawers, barcode scanners and printers are not certified by these CI tests.
