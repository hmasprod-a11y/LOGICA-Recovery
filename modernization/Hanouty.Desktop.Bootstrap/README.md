# Actual Windows catalogue host

This executable composes the existing WPF window, Architecture session and
Inventory MariaDB reader without adding a circular project reference.

Double-click `Hanouty.Desktop.Bootstrap.exe` to open the safe read-only WPF
catalogue. `--catalogue-only` remains supported for existing acceptance scripts.
Before launching, configure `HANOUTY_CATALOGUE_CONNECTION` for a local
SELECT-only MariaDB account and `HANOUTY_DATA_DIRECTORY` for an existing local
data directory. For example, in PowerShell (replace the placeholders):

```powershell
$env:HANOUTY_CATALOGUE_CONNECTION = 'Server=127.0.0.1;Port=3306;Database=YOUR_TEST_DB;User ID=YOUR_READ_ONLY_USER;Password=YOUR_PASSWORD'
$env:HANOUTY_DATA_DIRECTORY = 'C:\\YOUR_TEST_DATA'
.\\Hanouty.Desktop.Bootstrap.exe
```

These process-scoped variables are only an example; a double-click from Explorer
requires the variables to be configured in the Windows user environment beforehand.
The executable does not create or migrate a database. Missing configuration
produces an actionable startup error, never a fake or unauthenticated checkout.

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
