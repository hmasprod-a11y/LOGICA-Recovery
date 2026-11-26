# Existing devis, delivery notes and invoices

Base integration: `d56becd568a64fa3acf775d3342458549a56f6cd`. This batch provides consultation and original validation of existing documents; it does not close all document functionality.

## Original source authority

- Entry: `Form_8_gestion.Button_DEVIS_Click`, `Button_BL_Click`, `Button_FACTURES_Click`.
- Fields: each document form's `DataGridView1_CellClick` loads its original header and detail tables, customer identity, dates, user, notes, state and persisted HT/TVA/TTC/discount totals.
- Validation: `Form_900_DEVIS.cs:9310/9313`, `Form_9000_BL.cs:10091/10094`, `Form_90000_FACTURE.cs:10128/10131`. Their transactions update only header/detail ETAT to VALIDER. They do not post cash, stock or customer debt. The new store preserves those effects.
- Rights: each `FUN_CAT_ACCES` permits ADMIN/MANAGER validation and disables it for UTILISATEUR. Consultation remains available to those authenticated categories. Fresh validating actor PIN and the same role are checked inside the transaction.
- Print fields: original print handlers reload customer CLIENT/ICE/ADRESSE and use persisted document lines and totals. The new data preview does so too. Original RDLC layouts remain separate, below.

## Implementation and acceptance

`BusinessDocumentStore` has a fixed table/identity mapping for the three original document kinds, parameterized literal search and inclusive final calendar day. It rejects duplicate document identities, ambiguous/missing customers, inconsistent line/header customer data and mismatched persisted tax totals. It never creates or alters production schema. The recovered SQL has ID-only definitions for these document tables; a database missing the original runtime columns is not silently upgraded.

The WPF directory shows dated headers and their details, selected explicitly. Changing search/type/date invalidates the selected detail and its print/validation entry. Validation compares a canonical snapshot under transaction, authenticates a manager/admin with a new PIN, changes header and every detail atomically, and allows equivalent validated readback after a lost acknowledgement without another effect. No numbering or financial/stock mutation is introduced.

`DisposableBusinessDocumentsAcceptance.VerifyBusinessDocuments` runs after customer-file acceptance. It creates fixtures only in the existing disposable test suite, covers all three kinds and original totals/customer text, end-of-day and SQL-literal search, user/PIN/stale refusal, injected detail-update rollback, idempotent validation readback, mismatched totals, unchanged cash/stock/ticket counters, real WPF directory consultation/selection invalidation and a real preview window. It produces `w2-business-documents.json` (13 assertions) and `business-documents-directory.png`.

Locally executed with a dedicated owned MariaDB process on port33089, restored from the earlier disposable acceptance dump. Result: PASS for SQL and actual WPF directory/preview acceptance. No store database or other test process was touched. Financial Bootstrap build passed; one existing nullable adapter warning remains.

## Root integration hooks

Only new files are supplied. The integration owner must wire the common files:

1. Add a navigation button `Documents` using `OpenBusinessDocuments_Click`, enabled only during a financial session. `MainWindow.Documents.cs` supplies `ConfigureBusinessDocuments` and `ShowBusinessDocuments`.
2. Add `_businessDocumentsOpen` to existing WPF reentrant payment/logout/cashier/customer-file guards. PIN entry must remain available to the active document validation.
3. In the financial Host add a `businessDocumentsOpen` context flag to `CanChangeContext`. Configure the action only for a stable authenticated cashier and empty basket. Set/clear that flag in try/finally. Construct `BusinessDocumentStore(settings.ConnectionString, actor)` and `BusinessDocumentsWorkflow(store, Active, () => window.PromptCashierPin(actor))`; open `BusinessDocumentsDialog` with Owner=window. `Active` must compare the captured actor, financial session, no uncertain/busy/pending checkout and empty basket, while allowing its own document-modal flag.
4. Call `VerifyBusinessDocuments(settings,pin)` immediately after `VerifyCustomerFiles` in the existing disposable acceptance. Require all13 JSON assertions in W2 before PASS. Fixture tables are not production migrations.

## Remaining gaps — do not overstate

New document creation/edit/delete, original number assignment and transformations between devis/BL/invoice are not implemented here. These still need original total/price/tax rules and their own exact-once mutation design. The new FlowDocument data preview is not a replacement for original RDLC layouts, business branding, footer, amount-in-words, PDF/Word/Excel export or physical printer acceptance. Original templates `LOGICA.Report_4_DEVIS.rdlc`, `LOGICA.Report_5_BL.rdlc`, `LOGICA.Report_6_FACTURE.rdlc` remain the required print-parity authority. This batch must not be presented as a complete invoice subsystem or commercial print acceptance.
