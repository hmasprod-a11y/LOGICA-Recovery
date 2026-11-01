# Hanouty POS V2.0 — code-first engineering backlog

Source of truth: LOGICA V1 requirements, current recovered Windows .NET Framework 4.8/x86 program, and Hanouty V2 code-first decisions. A green CI job is not a field acceptance test. Do not change customer databases, main, existing activation, or financial behavior without explicit approval and new tests.

| Priority | Workstream | Acceptance gate | Current evidence / next action |
| --- | --- | --- | --- |
| P0 | Checkout: stock, ticket, payment and transaction | Original Windows POS + isolated MariaDB, characterization, portable core and failure injection | Posting/finalization already extracted; continue targeted UI/data access boundaries |
| P0 | Checkout article search | List and image branches, three-character threshold, SQL text and exception timing match original | Routing extraction merged in PR #61; parameterized search with isolated MariaDB regression in follow-up PR |
| P0 | Inventory/catalogue | Stock movement, barcode variants, image selection, atomic edits | Existing partial coverage; image-only tiles now require a real, decodable image in both family and search flows; confirm Windows fixture CI and user acceptance |
| P0 | Cash, access control and audit | Permissions denial, cash reconciliation, audit and rollback tests | Cash recount partially portable; full role and session acceptance pending |
| P1 | Customers, suppliers, purchases, reports | Balance reconciliation and isolated database fixtures | Client settlement partially portable; remaining modules need inventory |
| P1 | Hanouty licensing | Signed offline licenses, safe issuer key storage, lifetime clock rollback nonblocking | Separate core exists; do not silently replace existing startup activation |
| P1 | Diagnostics and backups | Structured non-sensitive failures, backup/restore drill | Pending independent test fixtures |
| P1 | Branding, installer and UX | Complete Windows package, clean install, French/Arabic layouts, peripherals | Hardware and field acceptance deferred until code gates |

## Checkout article-search boundary

The legacy sale screen currently searches all products by Article or Code in list mode and filters only `Images <> '0.png'` in image mode. The original image mode showed items whose image files were missing by loading 0X.png. The image-only change deliberately removes those fake tiles in both family and search flows: missing, placeholder, invalid and unreadable images are skipped. Normal list mode still shows all matching products. This is an explicitly requested **functional change**; Windows fixture CI is required, followed by field acceptance.

PR #61 preserved unsafe SQL text as a characterization baseline. The follow-up security PR binds search input as a MySQL parameter in both list and image modes. It intentionally fixes quote handling and injection while retaining LIKE wildcard matching (`%` and `_`) and original image-mode SQL filtering. Isolated MariaDB tests must pass before merging; image-file existence and decode filtering is handled in the image-only follow-up; the SQL predicate remains unchanged to preserve database search compatibility.

## Exact barcode scan boundary (next checkout safety gate)

The sale scanner's `Button_FIND_Click` previously concatenated `Text_CODE.Text` into `WHERE Code = '...'`. This is now an exact `Code = @code` parameterized lookup. The original trimmed-empty guard, raw barcode parameter value, no `ORDER BY`, first-row selection, weighing/free-price dialogs, and `Button_GO_Click` sequence remain unchanged. In particular, this **does not** implement a new duplicate-barcode chooser or quantity policy. A separate UX decision and characterization test are required before changing the behavior when multiple articles share a barcode. The isolated MariaDB fixture checks quotes, injection attempts, LIKE metacharacters as literal barcode text, and multiple rows with the same barcode. No customer database is used.

## Next resume point

After the exact-barcode PR passes Windows/MariaDB and portable CI: characterize barcode duplicate selection and quantity increments in the original Windows sale screen, then implement the user-approved chooser without silently altering stock, payment, or ticket behavior. Inspect image-tab initial selection and search latency independently.


## Duplicate barcode scan — explicit variant selection (2026-11-01)

The exact parameterized `Code = @code` lookup still returns every matching row. The new portable `CheckoutBarcodeSelectionService` keeps the original row identity for zero/one matches, and requires an explicit index from a Windows-only chooser when multiple articles share a code. The chooser displays article name, code, ID and the currently selected price tier; Cancel/Escape returns without calling `Button_GO_Click`. No database write, quantity increment, ticket or stock posting occurs until an article is explicitly chosen. The selected original `DataRow` is passed to the unchanged weighing/free-price/posting sequence. This is an intentional UX change for duplicate codes; it does **not** add catalogue variants or change barcode creation.

Acceptance: isolated .NET Framework characterization (including cancel, bounds and exception propagation), portable .NET 10 smoke, Windows POS build, and isolated MariaDB duplicate lookup must pass. Manual keyboard/scanner and small-screen usability verification remains required before field release.
