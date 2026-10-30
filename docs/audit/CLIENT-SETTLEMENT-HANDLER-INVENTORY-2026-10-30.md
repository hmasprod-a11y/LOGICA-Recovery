# LOGICA — G1 inventory: customer settlement original-form behavior

Evidence source: `recovered-source/LOGICA/Form_5_CLIENTS_REGLE.cs` at PR #20 head `87d240af59112fa451f5f69306c8e6e42d055a81`.
This is a **source-based, partial inventory**. No production code changes. “Not tested” does not mean “missing”.

| Handler / lines at inspected commit | Existing implementation / side effects | Characterization / unresolved |
| --- | --- | --- |
| `_credit()` ~3296–3360 | Gets selected grid row's `ID_CLIENT`; queries `TABLE_VENTES_JOURNAL` for `CREDIT` and `RETOUR CREDIT`, `TABLE_CLIENTS.CREDIT_INITIAL`, `TABLE_CLIENTS_REGLE.MONTANT`. Uses `UNION ALL`, converts four values, calls `LOGICA.Domain.ClientCreditBalance.Calculate`; sets `_total_credit`. On exception shows `Erreur`; finally closes shared SQL connection. | Domain arithmetic characterized by PR #15; query correctness, signs, null/partial rows, SQL safety, shared connection under concurrency and real balances not accepted. |
| `Button12_Click` ~3439–3520 | Calls extracted `ClientSettlementValidationService.FirstWarning` and shows `Attention` on first warning; on `NOUVEAU`, `SELECT MAX(ID)`, legacy `NextId` callback, `DT.Rows.Add`, mapped fields, `MySqlCommandBuilder(DA).Update(DT)`, `DT.AcceptChanges`, success dialog and hides info panel. Catches exceptions, shows error and attempts screenshot/error log. | PRs #16–19 characterize guards/sequence/row writes. PR #20 CI passes one original-form INSERT with sentinel and closed connection. No proven transaction/atomic retry guarantee; duplicate ID possible. No failure-path acceptance, concurrent allocations or reconciliation acceptance. |
| `Button_CLIENT_Click` ~3689–3735 | Opens `Form_5_CLIENTS_LISTE`, then (if selected ID nonempty) performs four `MySqlDataAdapter` SELECTs, updates credit labels and `Text_CREDIT` with Domain arithmetic + `DH`. | PR #15 arithmetic reuse; customer-selection modal, SQL reads, formatting, exceptions and balance correctness lack full end-to-end acceptance. |
| `DataGridView1_CellClick` ~3225–3285 | Delete action asks confirmation, appends `log.sni`, deletes bound row and uses adapter `Update` / `AcceptChanges`; another action prints French/Arabic receipt using report printers. | Separate **high-risk** inventory needed for deletion authorizations, financial reconciliation and printer failures; no claim of acceptance. |

## Technical observations (do not silently fix under parity refactor)
1. SQL strings concatenate `ID_CLIENT` in `_credit()` and `Button_CLIENT_Click`: flag as injection/escaping risk needing isolated repro, separately scoped remediation and parity tests.
2. `SELECT MAX(ID)` followed by an insert is not an atomic concurrent sequence; legacy double scalar read is intentionally preserved in PR #17. Investigate separately without changing financial behavior until failure is reproduced.
3. The shared `Module1.cn_SQL` connection is closed in `_credit()` regardless of entry state; verify interaction with other callers before refactoring.
4. Deleted settlements and receipt printing are observable capabilities in original form. Do **not** list them as missing features; status is **untested** for business acceptance.
5. Original handler includes screen-capture-on-error and local logs; test failures carefully to avoid running against merchant data.

## Available test mapping
- `scripts/test-pos.ps1` at PR #20 head includes `client-settlement-save` in isolated Windows cases.
- `scripts/test-pos.cs` invokes the original `Button12_Click` against disposable `127.0.0.1:3307/logica_ci`, checks stored fields/next ID/sentinel and connection close.
- GitHub Windows run `41023211299`: completed success; log shows `client-settlement-save PASS`.
- The successful fixture covers one valid insert, **not** all table functions or failure/concurrency scenarios.

## Proposed next task, requires separate G2 baseline
Add an **isolated failure-path characterization** for the original settlement-save handler (e.g., DB insert rejection): assert what happens to the DataTable, dialog, DB row, and connection on failure without changing application code. Follow with retry/concurrency investigations on disposable databases only. Scope/prioritize independently, run the exact candidate SHA on Windows, review results before considering a functional repair.

## G1 status
**Partial verified source inventory — not complete product audit; not a claim of functional acceptance.**
No merge authorization.

Links:
- https://github.com/hmasprod-a11y/LOGICA-Recovery/pull/20
- https://github.com/hmasprod-a11y/LOGICA-Recovery/actions/runs/41023211299
