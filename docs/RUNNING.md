# LOGICA Windows recovery

This package contains the recovered original LOGICA WinForms program, targeting .NET Framework 4.8, x86. Extract the entire ZIP to a writable local directory and keep LOGICA.exe, LOGICA.exe.config, all DLLs and the .sni configuration files together. Start LOGICA.exe on Windows with .NET Framework 4.8 installed.

## Existing installation

Use the original installation's SQL database, `bd` directory, `.sni` settings and valid license files. These were not present in the supplied source/dependency archives. The included configuration defaults point to localhost and disable peripherals; they are not the original shop's settings. Copy the recovered program and libraries into a copy of the original installation, retaining its database/settings, before checking real transactions.

The database connection can be supplied with the `LOGICA_DB_CONNECTION_STRING` environment variable. Without it, the recovered program uses its existing connection fields and `CHEMIN_DB.sni`; the port is now passed separately as required by MySQL. `CHEMIN_FOLDER.sni` accepts the portable value `Application.StartupPath`.

## Verification

GitHub Actions builds the committed `recovered-source/LOGICA.csproj` on Windows. `scripts/test-pos.cs` loads the produced EXE and invokes original forms and business methods. Test data lives in an isolated MariaDB instance on 127.0.0.1:3307 in the `logica_ci` database. Fixtures cover only the SQL tables required by these tests and are not a recovered shop database.

The diagnostics artifact records each test's actual status, errors and rendered forms. Cash checkout/refund tests, when passing, verify ticket headers, sales journal, cash payment/refund records, stock changes and movements, cleared basket and incremented ticket numbers. They do not validate a physical printer, cash drawer, scale, RFID reader, a payment terminal, or the missing original shop database/license.

Do not replace the original database with CI fixtures. Test harness executables are removed from the delivered runtime.


## Updating an existing shop (not certified for production)

**Never extract `LOGICA-Windows-complete` directly over an existing installation.**
The complete first-install artifact includes default `.sni` settings and would
replace a shop's existing `CHEMIN_DB.sni` if forcibly extracted over it.
The packaging regression only proves preservation of files already present in
the *build output*; it does not protect an external shop folder from ZIP overwrite.

CI also produces `LOGICA-Windows-binaries-only-update`: an isolated candidate
containing `LOGICA.exe`, its root-level DLLs, and a warning README. Its
disposable-overlay test confirms the archive excludes `.sni`, `bd`, startup
scripts and `LOGICA.exe.config`, and that copying its files over a **fake**
shop directory preserves fake license, DB host, configuration and database.
It is **not** an automatic installer or a production-acceptance test.
Copying binaries without reviewing `LOGICA.exe.config` compatibility can
also break runtime binding redirects. Never test against a live shop.

Before any actual deployment: stop the application; back up and verify the
entire original installation and database; try the candidate against an
offline COPY of the installation; review dependencies and config compatibility;
run manual activation, transaction, return, and peripheral checks; obtain
explicit approval. Do not change the original shop's data or activation.
