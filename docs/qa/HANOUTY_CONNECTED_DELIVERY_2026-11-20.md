# Connected delivery batch — 20 November 2026

Baseline: integration `d56becd568a64fa3acf775d3342458549a56f6cd`. This batch combines executable functions, their cashier entry points and isolated acceptance; it is not complete LOGICA parity or commercial release approval.

## Installation and ordinary startup

`Install-Hanouty.cmd` invokes the per-user Windows PowerShell installer. The installer checks the accepted financial archive digest, manifest, every listed runtime file, executable digest and archive paths before selecting a new immutable application directory. Updates retain the old directory and pointer backup. Debug symbols outside the runtime manifest are omitted. Desktop/Start-menu shortcuts start the executable directly; a separate settings shortcut opens workstation configuration. No administrator privileges, database creation, database migration or database service installation is performed.

First ordinary financial startup without an explicit administrator/test environment opens the workstation setup dialog. It checks a local existing LOGICA database, data directory and two-digit workstation before saving. The connection string is protected using Windows DPAPI CurrentUser; its password is not stored as plaintext. The profile lives outside application versions. Later startups reload it. Invalid explicit environment settings do not silently fall back to another database. Setup cancellation does not start the cashier. A corrupt or foreign-user encrypted profile requires explicit setup again.

Acceptance drives the actual setup dialog against the disposable database, verifies encrypted save/reload, invalid-setting preservation, corrupt-ciphertext refusal and no financial writes. Installer acceptance runs the actual Windows PowerShell 5.1 path twice, verifies the previous version remains, and refuses a modified package without changing the active pointer. Retaining a previous version is not yet a complete user-operated rollback workflow. Offline licence enforcement and deployment/migration of a shop database remain separate gates.

## Credit and card full-ticket returns

The returns portal has explicit Cash/Credit/Card modes. Changing mode invalidates the searched original. Credit lookup displays the original customer and reduction of debt; Card lookup displays the original net. The generic return adapter uses the same authenticated session, financial gate, posting port and durable reconciliation as existing cash returns. The cash-only API keeps its cash restriction.

Credit confirmation states that debt is reduced, stock is restored and no cash is refunded. Card confirmation requires the operator to confirm reimbursement already performed on an external terminal; HANOUTY does not command that terminal. Both then request a fresh cashier PIN. Mode changes are refused during confirmation/PIN or an uncertain operation. SQL rechecks and consumes the complete original, preserves original prices/customer and performs atomic stock/debt/payment writes.

Original `FormDialog_calc.Button_SOLDER_Click` permits one return payment mode, not a split refund. A mixed original refunded by Card therefore creates one negative Card movement for the original net and leaves drawer cash unchanged. It does not reverse the original split. Source authority and core tests are in the credit/card return acceptance documents. Partial returns and cash reimbursement of mixed originals remain open.

`w2-full-return-modes.json` and two confirmation screenshots prove real cashier portal lookup, selection, cancellation without writes, explicit effect confirmation, fresh PIN, frozen mode, stock/debt/card reconciliation, unchanged cash and exclusion of a consumed original. Existing boundary tests additionally inject rollback, malformed evidence, duplicate consumption and durable recovery.

## Supplier AVOIR and account correction

The existing stock-issue directory opens a supplier AVOIR editor with original supplier/article selection, positive quantity, editable signed prices, visible signed total, explicit review and fresh PIN. Saving records the original BS number and ENREGISTRER header/details plus an operation journal atomically; stock changes only during the existing manager validation, with movement history. Lost acknowledgements retain the immutable request and local lease across restart. The explicit additive migration is `input/migrations/20261120-stock-issue-create-operations.sql`; startup never applies it to a shop.

Original LOGICA contains inconsistent displays: `Form_6_FOURNISSEURS` around6885–6895 subtracts outgoing totals, whereas `Form_6_FOURNISSEURS_REGLE` around3620 adds them. The shared modern account reader now follows the original account statement: opening + receipts − signed outgoing − payments. Positive AVOIR reduces debt; signed prices are not automatically negated. Original positive supplier advance payments remain allowed, including a negative resulting balance. Focused SQL/WPF acceptance covers both signs, validation, partial/exact/advance settlement, rollback and restart recovery.

The supplier acceptance also exposed a replay bug for accented settlement notes: SQL BINARY comparison converted the parameter differently from the persisted TEXT. Customer and supplier replay now lock the persisted row by numeric ID and compare all identity/payment/note/state fields exactly in managed code. A changed stored note is still refused; an exact Unicode replay cannot create a second payment.

## Business documents

The real cashier navigation opens existing devis, BL and invoices. Original persisted headers/lines/customer and HT/TVA/TTC/discount totals are reviewed. ADMIN/MANAGER validation updates header and lines atomically with fresh PIN and stale-snapshot checks; UTILISATEUR cannot validate. Directory edits revoke the printable selection. The data preview is not the original RDLC layout. Creation/edit/delete, numbering, transformations and original print-layout parity remain open; unfinished quote work is retained in its isolated worktree and is not counted as delivered.

## Acceptance boundary

The complete financial suite must pass on the published tree, including original cash/card/mixed/discount/credit/customer flows and new configuration/return/document/Unicode reports. Dedicated supplier AVOIR SQL and WPF suites and real installer acceptance are mandatory W2 steps. No failing guard is disabled to meet the deadline. Physical printing, final installation on a clean shop machine, licensing, complete requirement inventory and all remaining LOGICA functions still gate final delivery.
