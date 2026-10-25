# LOGICA Recovery

Recovered original C# WinForms POS, targeting .NET Framework 4.8 and x86 Windows.

## Source and build

The authoritative, repaired code is committed in `recovered-source/`. The Windows workflow builds `recovered-source/LOGICA.csproj` directly; fixes are no longer confined to a temporary extracted copy. The input archives remain available as recovery backups.

C# repairs restore protected base calls, omitted nested Bunifu/WinForms/QRCode types, event argument types, valid collection access, enum operations and portable framework/DLL references. Runtime packaging preserves the assemblies resolved by the build. MySQL connection configuration now passes the server and port separately and supports `LOGICA_DB_CONNECTION_STRING`. The original return handler now stores stock movement quantities as typed numeric parameters: returning one item records `+1`, instead of the invalid string `--1`.

## Windows verification

See the [verified Windows run](https://github.com/hmasprod-a11y/LOGICA-Recovery/actions/runs/40233164525) for the exact status and retained artifacts. `LOGICA-Windows-complete` contains the EXE, config, DLLs, portable startup defaults, usage instructions and SHA-256 manifest. `LOGICA-build-diagnostics` contains the compiler log, individual test logs, JSON results and form renders.

The tests load the produced EXE and exercise its original methods against an isolated local MariaDB fixture database. They check basket totals, fractional/negative quantities, article field reset, monetary rounding, cash sale/refund persistence, stock and stock movements, ticket sequence, original form creation/layout and real EXE startup.

## Running with the original shop installation

Read [RUNNING.md](docs/RUNNING.md). The later supplied `Debug(1).zip` contains the original `bd` resources and an Access database disguised as `bd/config/configue.sni`. A separate SQL recovery export preserves all 125 application tables; all original row counts were verified on Windows, including 120 articles, 15 families and 11 sales tickets. The original MDB remains byte-for-byte unchanged. Its ZIP timestamp is January 2024, so it is a snapshot, not a guarantee of the latest shop data. Physical peripherals are not covered by these checks.

Use `Start-LOGICA.cmd` in the restored complete package. Its Windows PowerShell 5 launcher downloads and verifies the local server on first use, imports into a separate database without replacing existing data, then starts the EXE. The original machine activation mechanism is unchanged; the CI machine reaches its activation screen after the database connection succeeds. See `docs/RECOVERY.md`.
