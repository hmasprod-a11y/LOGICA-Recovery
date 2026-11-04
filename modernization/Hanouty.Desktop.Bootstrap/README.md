# Actual Windows catalogue host

This executable composes the existing WPF window, Architecture session and
Inventory MariaDB reader without adding a circular project reference.

Run with `--catalogue-only`, `HANOUTY_CATALOGUE_CONNECTION` containing a
SELECT-only local account, and `HANOUTY_DATA_DIRECTORY` pointing to the legacy
data directory. It does not create or migrate a database.

The catalogue mode explicitly disables financial submission. It is a W1
candidate, never W2 acceptance or a commercial release. CreateProduction requires
caller-supplied actual posting and durable operation journal; there is no default
financial implementation. Cashier authorization, monetary parity, payments,
durable sale/return and rollback still require the Checkout integration.

`scripts/test-w1-bootstrap.ps1` opens this executable with a disposable MariaDB
fixture at exactly 127.0.0.1:3307/logica_ci. It verifies the visible WPF window,
real rows, real photo availability, barcode ambiguity, explicit selection into
the Architecture session, search and disabled checkout. It saves JSON evidence
and a rendering of the actual WPF window. SQL persistence is not mocked.

Exact source provenance for this first combined candidate:

- QA base: a9496887cf393a40b805f05ca04a177300e7662a
- Architecture: 5472194424720c092b3f5bceb4f29adae5b8706f
- WPF: 116c95a2e0e180b050afa20cc733aea01fa023f9
- Inventory: 563afc1e27976513b6c34b02807fd408054144bb

The Adapter regression catch accepts both existing duplicate-identity error
messages because Architecture now rejects the corrupt input before WPF mapping.
The test still fails when corrupt input is accepted.
