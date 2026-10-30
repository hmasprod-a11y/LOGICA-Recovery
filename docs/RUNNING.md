# LOGICA Windows recovery

This ZIP contains the recovered original LOGICA WinForms application (.NET Framework 4.8, x86). Extract **the entire archive** into a **new, writable folder** on Windows. Keep the EXE, config, DLLs, scripts, `.sni` files and `recovery/` folder together.

## Choose the correct startup mode

**A. New isolated recovery copy (not a live shop installation).** Launch `Start-LOGICA.cmd` from the extracted folder, **not** `LOGICA.exe` directly. The launcher (`Launch-LOGICA.ps1`) downloads and checksum-verifies MariaDB 10.11.14 on first use (Internet required), starts a local server on `127.0.0.1:3308`, and imports the bundled **recovered snapshot** from `recovery/recovered-original.sql` plus `recovery/mysql-compatibility.sql` into `logica_recovered`. It creates local `bd/mysql-data` and credentials on first use. Keep those files for subsequent launches. The recovered snapshot is **not a current shop database** and may not contain recent transactions. Never use it to replace a shop database.

**B. Existing shop installation.** **Back up and preserve the working installation first.** Keep the shop's original SQL database, `bd` directory, `.sni` settings, license files and peripherals configuration unchanged. Do not extract this ZIP over that installation, copy its default `.sni` files onto the shop settings, or run the recovery launcher against the shop's data. Validate any candidate EXE and DLLs in a separate copy with the correct shop connection and a safe database copy before considering deployment.

**Important:** The CI ZIP has `recovery/*.sql` snapshot files but **does not include a pre-initialized `bd/mysql-data` directory or the live shop database**. Its default `CHEMIN_DB.sni` points to `127.0.0.1`. Launching `LOGICA.exe` directly without a running, correctly configured database can therefore show a database connection error. A Windows build marked SUCCESS does **not** prove first-run installation or migration on a user's computer.

The connection can alternatively be supplied using `LOGICA_DB_CONNECTION_STRING`. Without it, the recovered program uses its existing connection fields and `CHEMIN_DB.sni`. `CHEMIN_FOLDER.sni` accepts `Application.StartupPath`.

## Verification and limits

GitHub Actions builds `recovered-source/LOGICA.csproj` on Windows. `scripts/test-pos.cs` invokes original forms and business methods against an **isolated** MariaDB database at `127.0.0.1:3307/logica_ci`. These fixtures cover only the required test tables, not a real shop installation.

When passing, the checkout/refund checks cover ticket headers, journal, payment/refund records, stock changes, basket clearing and ticket sequencing. They do **not** validate first-run setup on a clean PC, actual shop data, physical printers, cash drawers, scales, RFID, payment terminals, or licensing. Do not replace shop data with CI fixtures. The test harness EXE is excluded from the delivered runtime.

If startup fails, preserve the full extracted folder and the original installation separately; do not delete `bd`, reinitialize an existing database or overwrite settings. Inspect the launcher's error output and the database service/connection in the isolated copy before changing anything.
