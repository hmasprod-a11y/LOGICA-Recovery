# HANOUTY POS — WPF standalone engineering candidate

Package mode and acceptance provenance are recorded in HANOUTY-MANIFEST.json.

## Financial package

A financial build includes the production Checkout project. Double-click opens
the real cashier workstation in a locked session. Cashier sign-in uses the local
MariaDB PIN flow. There is no demo cashier, default payment, or in-memory financial
fallback.

Configure these Windows user environment variables before first launch:
- HANOUTY_CATALOGUE_CONNECTION: local MariaDB connection string.
- HANOUTY_DATA_DIRECTORY: existing local data directory.
- HANOUTY_WORKSTATION: two-digit register ID (defaults to 01).

Only loopback MariaDB hosts are accepted. The executable never creates or migrates
a shop schema. Keep database credentials out of the package. The W2 acceptance
switch requires an explicit disposable-database marker and is reserved for CI.

The financial package gate runs the extracted EXE against a fresh disposable
MariaDB, checks sale/full-return SQL, rollback, duplicate/restart and unknown
outcome, then launches that same extracted EXE without arguments and verifies
the cashier window. This is an engineering candidate, not commercial release
approval.

## Catalogue-only diagnostic package

This explicit diagnostic build is read-only and cannot authorize payment. It is
not W2 acceptance.
