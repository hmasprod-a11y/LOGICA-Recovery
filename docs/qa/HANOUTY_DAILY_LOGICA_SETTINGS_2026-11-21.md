# Original daily ticket/payment settings

Baseline source `d435a3786115d3023fe103f42377044eb244fbdb` (PR140). This batch adds separate settings Store/Workflow/DTO/Dialog and SQL/WPF acceptance. It does not modify the local printer chooser, main window, financial Host or receipt reader/printer/renderer.

## Original authority and accepted keys

`Form_1_LOGIN.FUN_CAT_ACCES` gives PARAMETRES to ADMIN only. `FormDialog_2_Configuration` selects MODELE_TICKET/BRANCHEMENT and FENETRE_MODE_P and updates existing TABLE_PARAMETRES rows by key. `FormDialog_3_Configuration_Suite` uses tags AFFICHER_MODE_P, AFFICHER_N_TICKET, AFFICHER_CODE_BARRE and PIED_TICKET. The existing production receipt factory reads the same flags/footer, and payment availability reads FENETRE_MODE_P.

This delivery edits exactly those seven existing keys. The booleans retain original `Conversions.ToBoolean` / `Conversions.ToString` semantics. An unchanged raw representation such as -1 is preserved rather than silently normalized. Only deliberately changed boolean keys are written in the original True/False representation. The footer retains Unicode and explicit line breaks, subject to the actual VALEUR column length and printable-control validation.

Only FR_3C and USB can be newly selected in this scoped dialog. An already stored unsupported model/connection can remain unchanged while other options are edited, with an explicit warning. FR_4C/Arabic/serial or other routes are not advertised as connected by this delivery. PRINTER_CL.sni and workstation-local printer profiles are untouched.

## Transaction and recovery behavior

The store uses utf8mb4 and loopback only. A new access grant requires an actual ADMIN/PIN; every read rechecks ADMIN and each save requests a fresh current PIN. Access is bound to the store instance. The seven rows must exist once, with exact canonical keys and non-null valid values, in transactional tables. Missing/duplicate/case-alias keys are refused; no schema/row creation happens at production startup.

Saving locks and compares an ordinal raw-value revision and the reviewed typed state, updates only changed keys in one transaction, then rereads the exact desired values before commit. A conflicting admin edit is not overwritten. Trigger failures or altered readback roll back all key changes. Other parameters and business tables are untouched.

A lost acknowledgement retains the immutable expected/desired pair in the open workflow. Retrying with a fresh PIN verifies an already desired state without another UPDATE. Wrong/cancelled recovery PIN retains pending verification. The explicit Relire action discards the draft only after a successful current read. A fresh application/workflow reads the persisted actual configuration. This is deterministic configuration-setting recovery, not a parallel financial posting journal.

## Root integration hook

Create `DailyLogicaSettingsStore(connectionString)`, call `Authorize(activeAdminActor,freshPinCallback)`, then open `DailyLogicaSettingsDialog(new DailyLogicaSettingsWorkflow(store,access,sameStableContext,freshPinCallback))`. Root owns combining this with the existing printer selection entry and protecting the modal/session. Refresh payment-mode availability afterward; existing receipt settings are read on the next print/reprint. No store-data migration is required.

## Actual acceptance

`modernization/daily-settings-acceptance/DailySettingsAcceptance.csproj` references the real WPF dialog and production store/workflow, plus the existing payment-availability and receipt-settings/routing implementations. The environment must explicitly target loopback database settings_disposable. Only the acceptance fixture creates its tables and test accounts; it never targets a shop schema.

The actual WPF dialog saves FR_3C/USB, original flags and a multiline French/Arabic footer. SQL assertions verify ADMIN/PIN/Arabic/accent exact identities, unchanged original raw boolean, unsupported-route preservation, unrelated and business data unchanged, stale snapshot refusal, multi-key trigger rollback, tampered readback, lost acknowledgement followed by wrong/cancelled PIN and duplicate-free verification, fresh-store persistence, role revocation and duplicate/missing keys. The saved values reach the existing card availability reader and FrenchThreeColumn receipt route. Evidence is `daily-logica-settings-acceptance.json` and `daily-logica-settings-wpf.png`.

Hardware printing and every other original configuration page remain outside this scoped evidence; no unsupported template or replacement printer setup is claimed.
