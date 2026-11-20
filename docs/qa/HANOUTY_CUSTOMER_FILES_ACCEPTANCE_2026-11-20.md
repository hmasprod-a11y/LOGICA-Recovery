# Customer files, opening credit and existing credit sales

Based on integration `ce1d035fca7737a5c3159a99ced047e0bdc02ad5` (PR136). This batch is not a commercial release or completion of all LOGICA customer functions.

## Original authority

- `Form_3_VENTE.CREATION_ACCES` / `Button_CLIENTS_Click`: `TABLE_PASS.CLIENTS`, VISIBLE / INVISIBLE / ACCES MANAGER / ACCES ADMIN. A requested MANAGER requires that exact role; ADMIN does not substitute.
- `Form_5_CLIENTS.Button12_Click`: generated `CL` plus a minimum of six digits from `TABLE_NUM.CLIENT`, optional unique nonempty code, full metadata and a separate opening credit. Creation advances CLIENT, never the ticket counter CL.
- `Form_5_CLIENTS_MODIFICATION_CREDIT_INITIAL.Button_SAVE_Click`: original opening-credit history and customer update in one transaction. `input/recovered-original.sql` defines `CREDIT_INITIAL` as DECIMAL(19,4) and original history values as DOUBLE. Opening credit retains four decimal places and allows either sign.

## Connected implementation

The cashier navigation opens Fichiers clients only in a stable authenticated session with an empty basket. Module entry checks original permissions, including exact role PIN when applicable. Each write requests a fresh cashier PIN and rechecks permissions and role under transaction. Reentrant payment, cashier change and logout are blocked while the manager is open.

The directory provides literal name/telephone/code search and explicit selection, a full metadata editor, a separate touch opening-credit editor and readonly opening history. Fields include code, name, date, ICE, address, city, country, telephone, notes and existing seller. The opening keypad supports four decimals and a sign button only for this opted-in use; cash, quantity and existing keypad callers retain their restrictions. Editing a search invalidates its selection. Over 200 matches require a narrower query.

Creation, metadata update and opening adjustment have an immutable operation UUID and payload. The original write, history where applicable, numbering and additive journal commit together. Updates compare the full reviewed customer snapshot before writing. Code conflicts, stale snapshots, invalid PIN, changed rights, wrong exact role and journal/history failures leave no partial write.

A local exclusive workflow lease prevents two windows/processes overwriting one recovery file. The file contains the immutable request, no PIN. After a lost acknowledgement, reopening replays the same durable operation instead of allocating another number. A refused recovery PIN retains that request because a previous attempt may already have committed. Successful own-operation replay cannot grant a new write. A directory refresh can still be refused if its permission was revoked.

The actual new file is selected by the existing credit-sale dialog and flows to the existing debt journal and statement. Customer administration does not create cash movements, stock movements or ticket numbers.

## Schema deployment

`input/migrations/20261120-customer-file-operations.sql` is an explicit additive InnoDB journal migration. Production startup does not apply it or change original customer tables. Back up the intended database before a separately authorized migration. Disposable acceptance applies the exact embedded migration only to its isolated fixture. It also extends that fixture to the original customer columns; this is not production schema initialization.

## Executed acceptance

`VerifyCustomerFiles` in `DisposableCustomerFilesAcceptance.cs` runs in the existing disposable WPF/MariaDB suite after cash, card, discount and credit checks. It drives actual create/opening dialogs, touch keypad and fresh PIN. It tests metadata and concurrency refusals at the SQL boundary, injected history/journal rollback, exact-role revocation, duplicate replay, wrong PIN during restart recovery, exclusive lease, unchanged cash/stock and a real new-customer credit sale and statement.

Evidence: `w2-customer-files.json` (17 required assertions) and `customer-files-opening-balance.png`. W2 refuses missing assertions. The standalone launcher verifies this report; backup/restore compares full metadata, original opening history and every journal payload/result alongside previous financial checks. WPF regression exercises signed four-decimal entry and cancellation in fr-FR/en-US and confirms the default keypad has no sign action.

## Remaining gaps

This batch does not implement original customer deletion, editable identity rewriting, all customer document/history/export screens, partial returns, credit returns, or physical printer verification. Generated identity is immutable here so existing financial references cannot be orphaned. Those differences remain visible work, not inferred acceptance from a green test.
