# Hanouty POS V2.0 — code-first engineering backlog

Source of truth: LOGICA V1 requirements, current recovered Windows .NET Framework 4.8/x86 program, and Hanouty V2 code-first decisions. A green CI job is not a field acceptance test. Do not change customer databases, main, existing activation, or financial behavior without explicit approval and new tests.

| Priority | Workstream | Acceptance gate | Current evidence / next action |
| --- | --- | --- | --- |
| P0 | Checkout: stock, ticket, payment and transaction | Original Windows POS + isolated MariaDB, characterization, portable core and failure injection | Posting/finalization already extracted; continue targeted UI/data access boundaries |
| P0 | Checkout article search | List and image branches, three-character threshold, SQL text and exception timing match original | Extract routing + SQL text without changing query semantics; cover .NET 10 and Windows |
| P0 | Inventory/catalogue | Stock movement, barcode variants, image selection, atomic edits | Existing partial coverage; verify missing-file image policy separately before functional change |
| P0 | Cash, access control and audit | Permissions denial, cash reconciliation, audit and rollback tests | Cash recount partially portable; full role and session acceptance pending |
| P1 | Customers, suppliers, purchases, reports | Balance reconciliation and isolated database fixtures | Client settlement partially portable; remaining modules need inventory |
| P1 | Hanouty licensing | Signed offline licenses, safe issuer key storage, lifetime clock rollback nonblocking | Separate core exists; do not silently replace existing startup activation |
| P1 | Diagnostics and backups | Structured non-sensitive failures, backup/restore drill | Pending independent test fixtures |
| P1 | Branding, installer and UX | Complete Windows package, clean install, French/Arabic layouts, peripherals | Hardware and field acceptance deferred until code gates |

## Checkout article-search boundary

The legacy sale screen currently searches all products by Article or Code in list mode and filters only `Images <> '0.png'` in image mode. The image mode can still show an item whose image file is missing (with a fallback image). This extraction preserves that behavior; the desired stricter image-only policy is a separate **functional change** requiring fixture and UI acceptance.

The original SQL concatenates raw search text, including quotes. The new query-text class deliberately preserves byte-for-byte SQL for parity, **not** because it is safe: parameterization and LIKE escaping require a separately approved behavior/security fix and database regression. Do not treat characterization as a security pass.

## Next resume point

After Windows and portable CI pass on the article-search PR: inspect sale search latency, parameterization risks, image-file existence policy, and duplicate-barcode chooser. Keep original checkout transaction and printer-failure behavior under explicit regression before any changes.
