# Catalogue code organization

## Current resume checkpoint

- Verified implementation: 4e52a89910db459e3be5582e462506c966445216, draft PR #10 stacked on #8; no merge/release.
- Windows run [40944010253](https://github.com/hmasprod-a11y/LOGICA-Recovery/actions/runs/40944010253) and independent runs 40944010371/40944020561 passed. No implementation check remains pending.
- Variant insertion now reuses the verified twelve-digit checksum. Original insertion/duplicate/totals/reset/selection behavior is covered; collection transaction and SendKeys tail remain unchanged/unverified.
- Next bounded candidate: Button_CALC_DOC_Click quantity accumulation. Characterize empty grid and raw quantity types through the original handler before separating the VB AddObject/ToDecimal loop. Preserve FLOUSS and row-count display timing in the form.
- Requirements evidence map: REQUIREMENTS_STATUS.md; no global completion percentage is assigned.

## Priority and baseline

LOGICA is the working primary product. Organize existing code incrementally while preserving behavior; TODO POS is only a selective reference. Do not add features, migrate the framework or alter shop data.

Inspected baseline: ae273a3dc37cae4fd562af5b378a0b537ebbf86d, following the verified checkout milestone in PR #8. This catalogue slice is kept on its own review branch.

## Initial source inventory

Form_2_ARTICLES.cs is approximately 646 KB and 18,000 lines. It combines UI setup, product persistence, collection creation, images/barcodes, reports and repeated input handlers. File size is a navigation signal, not proof of faulty behavior.

- Button_SAVE_Click: individual product save; requires method-level data/transaction audit before any move.
- Button_SAVE_COLLECTION_Click: multi-product/variant insertion and stock initialization; higher risk, defer until fixture coverage exists.
- Image/report/device handlers: preserve resource and hardware behavior; not the first extraction.
- Thirteen identical numeric KeyPress handlers: bounded initial candidate, no database/hardware work.

Handlers: TextBox8_KeyPress, TextBox13_KeyPress, TextBox16_KeyPress, TextBox17_KeyPress, Text_PRIX_MP_KeyPress, Text_PRIX_V_2_KeyPress, Text_PROMOTION_KeyPress, Text_PRIX_A_COLLECTION_KeyPress, Text_PRIX_V_COLLECTION_KeyPress, Text_QTE_KeyPress, Text_CODE_COLLECTION_KeyPress, Text_PRIX_QTE_KeyPress, Text_PRIX_QTE_MIN_KeyPress.

## First characterization slice

Invoke every original handler directly on an original catalogue form instance, in fr-MA/fr-FR/en-US. Preserve ASCII digits, backspace, period and minus; reject comma, plus, whitespace, letters and non-ASCII digits. A pre-handled event must remain handled even when its character is otherwise allowed.

These are character filters, not complete-number validation or pasted-text checks. Some handlers include collection-code fields; do not change their existing policy based on their labels.

Production source is unchanged in this first commit. Harness compilation and full Windows runtime verification are required before extracting a reusable UI-independent input filter. Keep chooser/product-save behavior outside this slice.

## Verified baseline

Full Windows run 40852190847 succeeded. catalogue-keys passed 1,053 assertions across all 13 original handlers and three cultures; all existing checkout, build and launcher checks passed. Product source remains unchanged in this characterization commit.

Next: extract the shared character filter into a UI-independent Presentation/Input helper, replacing only the repeated predicate. Keep each handler's conditional assignment so an already-handled event is never reset. Add standalone policy tests, include that helper in the independent test runner, and rerun this catalogue fixture. Do not broaden input acceptance or add pasted-text validation in the same change.

## Shared-filter extraction

Move the exact repeated character predicate into Presentation.Input.NumericEntryFilter.ShouldBlock, which has no WinForms dependency. All 13 handlers retain their conditional Handled=true assignment, so an already-handled event remains handled. Preserve VB binary character comparison, editing keys and current blocked characters; do not add locale-aware comma acceptance or complete-number validation.

Add standalone tests for allowed editing/digit keys, ASCII boundaries, blocked non-ASCII digits and three cultures. Include Presentation/Input sources in the independent rules runner. Existing direct-handler fixture remains the integration safeguard. Full Windows runtime verification is required after extraction.

## Verified shared filter

Full Windows run 40853349901 succeeded after extraction. All 13 original handlers passed the same 1,053 assertions; standalone filter tests passed 90 assertions and all prior application/domain tests passed. Existing checkout/build/launcher checks also passed. Revert fb94ea99a4275ec1f09fd511f084c7d9d0450c75 to undo this extraction.

Next: map Button_SAVE_Click validation, normalization and persistence stages, then characterize rejected-input behavior before moving a save rule or database operation. Batch collection saving remains a separate higher-risk boundary.

## Individual-save audit and required identifiers

Button_SAVE_Click is approximately 346 lines. Stages: ordered required-field checks (code/article use VB Trim, most later fields use raw empty checks), promotion/image/group checks, article apostrophe replacement, optional balance-code formatting, image save with its own catch, then separate new/modification persistence and refresh.

Observed mapping differences must be preserved: creation fills PRIX_MP from purchase price, while modification fills it from the average-price control; inventory date/initial-stock sources also differ. No explicit transaction surrounds this individual-save handler; batch collection saving has a separate transaction. Do not unify mappings or add transaction behavior incidentally.

Add catalogue-save-guards for empty/space-only code and article. A strict isolated fixture holds article/movement/sequence sentinels; require the expected warning, unchanged field text (including an apostrophe before normalization), closed connection and unchanged sentinels. This covers early rejection only, not successful product save or later required fields. Product source remains unchanged pending runtime evidence.

## Verified required-identifier baseline

Windows run [40855066392](https://github.com/hmasprod-a11y/LOGICA-Recovery/actions/runs/40855066392) and independent rules run 40855075441 succeeded for 4db87c0935a638d12ae0e6fa41d71302ea96f49d. All four original-handler required-code/article cases passed: expected warning, text unchanged before normalization, connection closed, article/movement sentinels and sequence unchanged. Numeric handler characterization and existing checkout/build/launcher checks also passed. No production save logic has changed.

Next bounded slice: characterize the exact VB Trim/empty predicate independently before extracting the two required-identifier checks. Preserve ordered warnings and returns, all later raw-empty checks, and normalization timing. Do not substitute .NET Trim semantics or broaden this fixture into successful save coverage without separate database mapping fixtures. Creation/modification mapping and batch transaction differences remain deferred as recorded above.

## Required-identifier extraction

Extract only the first two Button_SAVE_Click predicates into Domain.CatalogueRequiredFields.IsMissingIdentifier. Retain VB Strings.Trim and binary empty comparison verbatim; warning text, evaluation order, returns, normalization and all later checks stay in the form. No persistence mapping changes.

The original-handler early rejection baseline passed before moving these predicates. Independent characterization passed locally: 393,243 assertions across fr-MA/fr-FR/en-US, with null/empty/spaces, literal identifiers, every UTF-16 code unit alone and space-padded against the legacy expression. Existing independent tests passed. Full Windows original-handler, checkout and build verification is pending for this extraction.

## Verified identifier extraction

Full Windows run [40883154526](https://github.com/hmasprod-a11y/LOGICA-Recovery/actions/runs/40883154526) succeeded for d7af8e8fcf2f2c22650ccf74d08de599b457d0c3. Original catalogue save warnings and no-write sentinels passed after extraction, as did numeric handler, checkout, build and launcher checks. Independent rules runs 40883154083 and 40883163814 also succeeded. Revert d7af8e8fcf2f2c22650ccf74d08de599b457d0c3 to undo this extraction.

Next candidate audited: promotion guard uses short-circuit OR between raw-empty comparison and VB decimal conversion >100. Negative values are currently accepted by this predicate, exactly 100 is accepted, and malformed nonempty values throw through the handler's existing catch. Do not normalize text, add a lower bound or change conversion culture. Before extracting it, extend the original-handler fixture through preceding required fields to cover empty/over-100 rejection and retain pre-normalization/no-write evidence. Accepted values and later image/group/save branches need a separate bounded fixture; this milestone does not verify successful product persistence.

## Promotion guard characterization

Extend catalogue-save-guards from four to ten original-handler cases. Supply preceding required fields using the original controls/events (audited handlers are empty except primary sale-price copying to tier two). Empty, 101 and 1000 must stop at PROMOTION; -1, 0 and 100 must reach the intentionally empty IMAGE guard. Every case requires unchanged identifier text before apostrophe normalization, unchanged promotion text, closed connection and unchanged isolated article/movement/sequence sentinels.

This accepted-promotion coverage deliberately stops at the next required-field warning; it does not claim successful product save or image handling. Harness compiles locally. Original promotion predicate remains unchanged until full Windows baseline passes. Fractional/culture conversion and malformed text need independent characterization before extraction.

## Verified promotion baseline and extraction

Full Windows run [40886209422](https://github.com/hmasprod-a11y/LOGICA-Recovery/actions/runs/40886209422) succeeded for baseline 67ad4efbc373a372c7ae19288c13085a756b0c50, with all ten original-handler guard cases and prior checks. Independent rules run 40886218283 also passed.

Extract the unchanged promotion predicate into Domain.CataloguePromotionRules.IsRejected. Retain raw-empty short circuit, VB decimal conversion, only the existing >100 upper bound, and propagation to the original form catch for malformed input. Warning/return stays in the handler; later image/group and persistence stages are untouched.

Before replacing the form predicate, 114 standalone assertions passed locally across three cultures for missing values, accepted negatives/zero/100, >100, decimal separators, whitespace, numeric boundaries and equivalent conversion exception types. All existing independent tests passed. Full Windows regression is pending for the extraction.

## Verified catalogue rules milestone

Full Windows run [40887800792](https://github.com/hmasprod-a11y/LOGICA-Recovery/actions/runs/40887800792) succeeded for 8564855d4adfba4a2467610a7d0fa3ca449943d5 after promotion extraction. Original-handler guard/numeric fixtures, checkout, build and launcher checks passed. Independent rules runs 40887800801 and 40887807809 succeeded. Revert 8564855d4adfba4a2467610a7d0fa3ca449943d5 to undo the promotion extraction.

Catalogue milestone now separates numeric input filtering, required identifier and promotion predicates with preserved behavior. Persistence remains in the original form pending successful-save coverage.

## Next bounded audit: generated barcode checksum

Button_GENERER_Click mixes random prefix generation and deterministic final check digits. The requested length 12 branch appends a digit using alternating weights 1,3 across 12 digits; requested length 11 appends a digit using weights 3,1 across 11 digits. Both finish with (10 - sum % 10) % 10. Random generation, requested length handling, focus and the existing Module1.getBits call in the 12-digit branch must remain in place.

Next: characterize the original generator for both requested lengths (result length, ASCII digits and independently computed checksum), then protect deterministic checksum cases before moving arithmetic. Do not redesign barcode formats, random generation or validation. Keep individual-save creation/modification mappings deferred; they differ in average price, inventory date and opening stock and require separate fixtures.

## Original barcode generator characterization

Add catalogue-barcodes to the isolated Windows harness. Invoke the original Button_GENERER_Click 24 times for each requested payload length 11 and 12; check final length, legacy 11 prefix, ASCII digits and a separate right-to-left alternating-weight checksum oracle. Random uniqueness is deliberately not asserted; preserve the original random/time behavior and getBits call. No product source changes in this baseline.

Harness compiles locally. Full original-handler Windows evidence is pending before arithmetic extraction. The check covers generated valid payloads only; malformed input behavior and other requested lengths remain outside this boundary.

## Verified generator baseline and checksum extraction

Original generator Windows run [40890985609](https://github.com/hmasprod-a11y/LOGICA-Recovery/actions/runs/40890985609) succeeded for 96b6473ae9dd326cae6ac8c6f73130e58169063b, including 48 original-handler samples and all prior checks. Independent run 40890995479 also passed.

Move deterministic arithmetic into Domain.CatalogueBarcodeChecksum: complete the twelve-digit payload array and calculate the eleven-digit payload suffix. Retain checked operations, VB/Convert digit conversion and slicing boundaries. The form retains random generation, requested-length branching, Module1.getBits call, append conversion and focus. Helpers are internal and called only after the original length conditions; no new validation or barcode policy is introduced.

Before replacing handler blocks, standalone tests passed locally: 8,406 assertions across three cultures using known vectors, all-zero/all-nine inputs, seeded valid payloads and byte-for-byte preservation of the array passed to getBits. All prior independent tests passed. Full original-handler Windows verification is pending after extraction. Invalid helper inputs are outside the production call boundary and are not claimed as covered.

## Verified barcode arithmetic

Full Windows run [40892782439](https://github.com/hmasprod-a11y/LOGICA-Recovery/actions/runs/40892782439) succeeded for d0e687be1734e04885fa122a337e223dab4a1353 after extraction. Original generator, catalogue guards, numeric input, checkout, build and launcher checks passed. Independent runs 40892782379 and 40892793315 passed, including 8,406 checksum assertions. Revert d0e687be1734e04885fa122a337e223dab4a1353 to undo the arithmetic extraction.

## Next boundary: individual product row mapping

The save handler assigns 33 catalogue columns to a DataRow, then uses the existing MySqlDataAdapter/CommandBuilder to persist. Preserve creation/edit differences: creation PRIX_MP comes from purchase price, DATE_INVENTAIRE from creation date and STOCK_INITIAL from current stock; edit uses the separate average-price, inventory-date and opening-stock controls. Code/article use VB Trim; prices/promotion use VB FormatNumber; minimum quantity uses Conversion.Val; many other values remain raw control text. Do not eagerly convert or unify these mappings.

Next work should establish isolated original-handler creation/edit persistence fixtures before moving row population. Prerequisites: bind a fixture DataTable and adapter to private DT/DA, supply the GROUPES setting in the template form, bypass image writing through matching current/previous image names, select the edit grid/binding position, and capture original warnings. Creation ordering is adapter update/AcceptChanges, stock movement, sequence increment, success warning, aggregate refresh. Edit ordering is duplicate-code and duplicate-ID checks, row update/AcceptChanges, success warning, audit log, aggregate refresh. Aggregate refresh queries require numeric catalogue columns; avoid a text-only fake schema that hides conversion behavior.

This is a coverage plan, not a verified save fixture. Existing guard tests stop before persistence and barcode tests have no database dependency. Keep new coverage isolated from shop files and preserve the absence of an individual-save transaction; test partial failures separately rather than silently adding atomicity.

## Original individual-create fixture

Add catalogue-create in the isolated Windows harness; production source remains unchanged. Use exactly 127.0.0.1:3307/logica_ci with 33 catalogue columns (correcting the earlier inventory count), numeric price/stock columns, date columns and a primary key. Bind the original form's private adapter/table, disable the group requirement in the fixture template, and keep current/previous image names equal so no image is written.

Exercise the original creation handler in en-US with deliberately different purchase/average prices, current/opening stock and creation/inventory dates. Require the success warning, accepted DataRow, unchanged existing article, new identity and normalized identifiers, legacy creation mapping differences, original raw movement text, one movement, sequence increment, closed connection and aggregate refresh. This validates a selected successful creation path only; edit, all 33 field values, duplicate guards and partial failures remain to be characterized before moving persistence mapping. Harness compiles locally; full Windows runtime baseline is pending.

## Verified creation baseline; edit fixture pending

Full Windows run [40896242712](https://github.com/hmasprod-a11y/LOGICA-Recovery/actions/runs/40896242712) succeeded for 1d1d2d42155dbc50d074987ce43bbfe2df778395. Original creation persisted purchase/average 10.25 despite average control 88.5, opening stock 7 despite opening control 999, and creation date as inventory date despite a separate inventory control. Identity, normalization, movement, sequence, accepted row, closed connection and aggregate refresh checks all passed. Independent run 40896252738 passed.

Add catalogue-edit as a separate isolated process: create the known article, bind the original grid/table at its selected row, invoke the original MODIFICATION path, then require average 88.5, opening stock 999 and separate inventory date 2020-03-04. Check selected identity, unchanged other article, accepted row, no extra movement/sequence increment, refresh and appended fixture audit log. This fixture exercises selected successful editing only; duplicate rejections, partial failures and complete column coverage remain separate. Harness compiles locally; full Windows edit baseline is pending. Production persistence source remains unchanged.

## Verified edit baseline; complete mapping coverage

Full Windows run [40897847088](https://github.com/hmasprod-a11y/LOGICA-Recovery/actions/runs/40897847088) succeeded for 396a6220a6f8b0faf2696f6197abe53c07ddad35. Original editing preserved the selected identity, stored average 88.5/opening stock 999/separate inventory date, accepted the row, appended audit, refreshed aggregates and left movement/sequence unchanged. Independent run 40897858714 passed.

Before moving row population, extend the existing creation/edit fixtures to assert all 33 persisted column values. Supply distinct metadata values through original controls (colour/size SelectedIndexChanged handlers are empty). Check string metadata/identifiers, all numeric values and both dates using a database reader after each original handler. No product source changes. Local harness compilation passed; full Windows evidence for expanded mapping coverage is pending. Duplicate rejection and failure ordering still need separate coverage; passing complete values is not evidence of transaction behavior.

## Verified complete mapping baseline and row-mapper extraction

Full Windows run [40899600623](https://github.com/hmasprod-a11y/LOGICA-Recovery/actions/runs/40899600623) succeeded for e3ccaa214aad24bcba9b54ace7adb286b91594f4: all 33 persisted values were checked after original creation and editing, along with movement/sequence/audit/refresh and earlier fixtures. Independent run 40899613064 passed.

Move the 33 DataRow assignments into ApplicationLayer.Catalogue.CatalogueRowMapper. A small Presentation.Catalogue adapter exposes original control text through ICatalogueRowInput properties; values are read at each original assignment, not snapshotted in advance. Keep new-row addition, binding-position selection, adapter persistence, AcceptChanges, stock movement, sequence, warnings, audit and refresh in the original form. Retain VB Trim/FormatNumber/Val, raw strings, creation/edit source differences and assignment order.

Before changing the handler, standalone mapper tests passed 69 assertions across three cultures for branch-specific values/types, repeated purchase/date/stock reads, lazy early failure, unchanged exception identity and already-applied preceding assignments. All existing independent tests passed. Independent runner now includes Application/Catalogue and System.Data; no WinForms/database dependency is introduced there. Full Windows original-handler regression is pending after extraction. Duplicate guards and database partial failures are not claimed as covered by this move.

## Verified row-mapper milestone

Full Windows run [40901326147](https://github.com/hmasprod-a11y/LOGICA-Recovery/actions/runs/40901326147) succeeded for 771b96def3736852a20dceb036b7a45c3b116d28. Logs confirm all 33 persisted values after creation and editing, original movement/sequence/audit/refresh, catalogue guards/barcodes and existing checkout/build/launcher checks. Independent rules runs 40901326084 and 40901337620 passed, including the 69 mapper assertions. Revert 771b96def3736852a20dceb036b7a45c3b116d28 to undo this extraction.

Next bounded coverage: duplicate-code rejection on creation and editing, then duplicate-ID_ARTICLE rejection on editing. These original SQL checks happen before row mapping; edit selects the grid row first. Characterize the expected warning, unchanged persisted rows/DT states, unchanged movement/sequence, and no success warning/audit. Preserve pre-check article apostrophe normalization and exact raw code SQL comparison. In the isolated fixture add a distinct competing identity/code so the second duplicate check can be reached independently. Only after this baseline consider moving duplicate lookup SQL behind a store boundary. Do not change SQL escaping, transaction ownership or failure cleanup as incidental refactoring.

## Duplicate guard characterization

Add catalogue-duplicates as its own isolated process after known creation/edit setup. Seed the competing row with a distinct ID_ARTICLE. Invoke unchanged original guards for creation duplicate code, edit duplicate code and edit duplicate ID_ARTICLE with a noncompeting code. Require the expected competing-article/identity warning, pre-check apostrophe normalization, unchanged raw code, unchanged DataTable values/row states, all 33 persisted target values, unchanged competing row, no new movement/sequence and no audit append.

Original SQL and product logic remain unchanged. Harness compiles locally; full Windows baseline is pending. These tests characterize duplicate rejection, not race-proof uniqueness or database failure cleanup. Keep raw SQL comparison and duplicate check order when extracting lookup code later.

## Verified duplicate baseline and lookup extraction

Full Windows run [40904525569](https://github.com/hmasprod-a11y/LOGICA-Recovery/actions/runs/40904525569) succeeded for dbf3ba4a446e61225c34113c003c5779fa67b87d, including all three original duplicate guards and existing catalogue/checkout/build checks. Independent run 40904541912 passed.

Move only the three SQL adapter Fill operations to Infrastructure.Catalogue.CatalogueDuplicateLookup. Preserve SQL text and raw values verbatim, caller-supplied DataTables, original Clear calls, first-row Article access, warning/return order and adapter-managed connection opening/closing. The form retains the decisions and row mapping/persistence workflow. Remove the unused default adapter constructions; each actual query still constructs its own adapter as before. Do not add parameterization, disposal policy, transactions, validation or exception handling in this extraction.

Pre-move isolated fixtures cover empty lookup results through creation/edit success and matching results through three rejection paths. Full Windows verification is pending after the move; no redundant standalone SQL-string mirror test was added. Database exceptions/partial failures remain a separate coverage boundary.

## Verified duplicate lookup; partial movement-failure baseline

Full Windows run [40906139855](https://github.com/hmasprod-a11y/LOGICA-Recovery/actions/runs/40906139855) succeeded for 63d009360ca0902dd14c37155b684dbf7453011b after SQL extraction; independent runs 40906139522 and 40906149715 also passed. Revert that implementation commit to undo duplicate lookup extraction.

Add catalogue-movement-failure in the strictly isolated creation fixture. An isolated BEFORE INSERT trigger rejects only the movement write after adapter persistence and AcceptChanges. Require the original error warning, all 33 article values still persisted/accepted, no movement or sequence increment, no aggregate refresh and the original open-connection state on this failure path; then explicitly remove the fixture trigger and close the connection. This characterizes the absence of an individual-save transaction without introducing one or changing failure cleanup. Production code is unchanged in this test commit.

Harness compilation passed locally. Full Windows injected-failure evidence is pending. The original catch may attempt its normal diagnostic capture within CI's disposable application directory; no shop files or database are used. Sequence-write and adapter-write failures remain separate boundaries.

## Verified partial failure; creation movement extraction

Full Windows run [40907390787](https://github.com/hmasprod-a11y/LOGICA-Recovery/actions/runs/40907390787) succeeded for 4e76db749437897079398a2c048c4a45fc379481. The injected movement failure confirms article persistence/AcceptChanges precede the movement, sequence and refresh are skipped, and the connection remains open until fixture cleanup. Independent run 40907399118 passed; all prior catalogue/checkout/build checks passed.

Extract only creation's movement command into Infrastructure.Catalogue.CatalogueCreationMovementWriter. Keep the exact SQL, two separate clock reads, raw code/article/stock reads after opening (deferred callbacks), execute-before-close ordering and existing open connection on failure. The original form still owns row persistence, sequence increment, warnings, error catch and refresh. No transaction or cleanup policy is added; this is preservation of observed behavior, not a partial-save fix.

Pre-move success and injected-failure fixtures protect this boundary. Full Windows regression is pending after extraction. Next: characterize sequence-write failure separately before moving the sequence command or combining creation steps.

## Verified movement writer; sequence failure characterization

Full Windows run [40909460145](https://github.com/hmasprod-a11y/LOGICA-Recovery/actions/runs/40909460145) succeeded for f8f630d7cd65009d1356eb85a9c476643d71ed8e after movement extraction. Original success/rejection/partial-failure paths and prior catalogue/checkout/build checks passed. Independent runs 40909460003 and 40909471394 passed. Revert that implementation commit to undo the movement writer extraction.

Add catalogue-sequence-failure using a strictly isolated BEFORE UPDATE trigger on TABLE_NUM. After the original article and movement writes, require the injected sequence warning, all 33 persisted article values and accepted row, exactly one committed movement with original raw values, unchanged sequence 7, skipped refresh and original open connection. Remove the trigger and close the fixture connection explicitly afterward. Existing movement-failure coverage is retained.

Only fixture/test code changes here. Local harness compilation passed; full Windows runtime evidence for sequence failure is pending. Do not move the sequence update until this baseline passes, and do not add transactions or change the original failure cleanup policy incidentally.

## Verified sequence failure and writer extraction

Full Windows run [40910202833](https://github.com/hmasprod-a11y/LOGICA-Recovery/actions/runs/40910202833) succeeded for f38ba3dff062d8d51ec728847344ff8acf340521. The sequence failure path retains the committed/accepted article and movement, leaves sequence unchanged, skips refresh and preserves the open connection until fixture cleanup. Earlier success, movement-failure, catalogue and checkout/build checks also passed. Independent run 40910214727 passed.

Extract only the article sequence update into Infrastructure.Catalogue.CatalogueSequenceWriter.AdvanceArticle. Reuse the original MySqlCommand, preserve open-before-command assignment, exact SQL including absence of WHERE, execute-before-close and open connection on failure. The form still calls it after movement completion and before success warning/refresh. No transaction, disposal or cleanup change.

Success and injected sequence-failure fixtures passed before this move. Full Windows regression is pending after extraction. The current fixture contains one sequence row; do not claim multi-row coverage even though the unchanged legacy SQL updates every row. Adapter persistence failures and creation ID reads remain separate boundaries.

## Verified sequence writer milestone

Full Windows run 40911101295 succeeded after sequence extraction at 6ecfe1465a871a1414102989e7864edc5e8757f0. Both injected movement and sequence failures retain their documented original partial-commit/connection behavior; successful creation/edit, duplicate rejection, all catalogue and checkout/build/launcher checks passed. Independent rules passed. Revert that implementation commit to undo sequence extraction.

Adapter write failure is the next distinct boundary: before actual insert, the new row has already been added/populated; before actual update, the selected row has been changed in memory. A database rejection may therefore leave Added/Modified data in DT even though no row was persisted. Characterize actual states, deferred errors, connection closure and absence of success/audit/movement/sequence effects before relocating adapter Update/AcceptChanges. Keep fixture trigger cleanup explicit and never introduce rollback semantics into this refactor.

## Adapter INSERT failure characterization

Add catalogue-insert-failure with a strictly isolated BEFORE INSERT trigger on TABLE_ARTICLES installed after the sentinel seed. Invoke original creation through its error catch and require the injected warning, unchanged database/sentinel, no movement or sequence increment, no refresh/audit, and the mapped in-memory row retained as Added rather than accepted. Assert the adapter-owned connection is closed after failure; record this separately from the open connection observed for direct movement/sequence commands. Remove the fixture trigger explicitly.

Production logic is unchanged. Harness compilation passed locally; these state expectations require full Windows verification before they are treated as observed baseline. Adapter UPDATE failure remains next, followed by a bounded Update/AcceptChanges extraction only after both failure paths pass.

## Verified adapter INSERT failure; UPDATE fixture pending

Full Windows run [40914441049](https://github.com/hmasprod-a11y/LOGICA-Recovery/actions/runs/40914441049) succeeded for 237d72bcbe3ca903a20ee7a1de9b1576ba8915f4. INSERT failure leaves database/sentinel unchanged, retains the populated Added row, closes the adapter-owned connection, and skips movement/sequence/audit/refresh. Independent run 40914450788 passed; prior checks passed.

Add catalogue-update-failure after successful creation setup. A strictly isolated BEFORE UPDATE trigger rejects the original adapter update. Require all 33 persisted creation values unchanged, the mapped target row retained as Modified with its original Code version intact, unchanged other row/movement/sequence, adapter-owned closed connection, and no edit audit or aggregate refresh. Explicitly drop the fixture trigger afterward. Local harness compilation passed; full Windows UPDATE-failure baseline is pending. Production adapter code remains unchanged until that baseline passes.

## Verified adapter failures; persistence extraction

Full Windows run [40916050829](https://github.com/hmasprod-a11y/LOGICA-Recovery/actions/runs/40916050829) succeeded for 90310469ef32978b81ac6e6ceb120a0bf9d8e703. INSERT failure retains Added row with no persisted insert; UPDATE failure retains Modified row/original version with all 33 persisted creation values unchanged. Both adapter-owned connections close and skip later side effects. Independent run 40916062662 and all prior checks passed.

Extract the two identical save-only command-builder/adapter Update/DT.AcceptChanges blocks into Infrastructure.Catalogue.CatalogueRowPersistence.UpdateAndAccept. Preserve command-builder association/lifetime policy (no new disposal), adapter settings, Update-before-AcceptChanges and exception propagation to the original catch. Do not include delete/batch handlers or add transactions/rollback. The form retains new/edit row selection/population and all surrounding workflow.

Pre-move success and both injected adapter failure fixtures protect this boundary. Full Windows regression is pending after extraction. Next audit: creation MAX(ID) and ARTICLE-number reads, preserving their repeated ExecuteScalar calls and VB/null behavior; cover empty and populated source tables before moving those reads.

## Verified adapter persistence milestone

Full Windows run 40917622281 succeeded after persistence extraction at 4758f51739271f88647eba58f2efddb4677e52a2. Both injected adapter failures retain Added/Modified rows and original database values/connection behavior; all 33 successful creation/edit values and previous catalogue/checkout/build/launcher checks passed. Independent rules passed. Revert that implementation commit to undo UpdateAndAccept extraction.

Creation scalar audit: MAX(ID) query checks ExecuteScalar against DBNull then calls ExecuteScalar again for nonempty results, adds 1 using VB double conversion and checked rounded int conversion. ARTICLE query similarly reads twice when non-DBNull, formats ART plus six-digit VB number; DBNull produces string 0. Empty/missing sequence row can return null rather than DBNull, so treat missing-row behavior separately and do not infer it from NULL-column coverage. The original command is reused later for the sequence update.

## Original creation scalar-edge fixtures

Add isolated catalogue-create-empty, catalogue-create-null-sequence and catalogue-create-empty-null cases. Before invoking original creation, remove only the fixture article seed and/or set the existing ID=0 sequence column to SQL NULL. Generalize the complete 33-column verifier to accept the expected numeric/article identifiers.

Require empty MAX(ID) to produce numeric ID 1, SQL NULL ARTICLE to produce string ID_ARTICLE 0, all 33 product values, matching movement identity, accepted row, closed connection and aggregate refresh. Preserve SQL NULL after the unchanged sequence increment (NULL+1 remains NULL). Existing populated fixture still requires ID 42/ART000007 and sequence 8. Missing sequence row is deliberately not conflated with a NULL column.

Production scalar reads remain unchanged. Harness compilation passed locally; Windows runtime evidence for these edge expectations is pending before extraction.

## Verified scalar edges and identity-reader extraction

Full Windows run [40920925847](https://github.com/hmasprod-a11y/LOGICA-Recovery/actions/runs/40920925847) succeeded for 8224f4f61c01b9456ad07ba664ae9ee105aa600d. Empty article, SQL NULL sequence and combined cases passed alongside the populated baseline, complete mapping, failures and all prior checks. Independent run 40920938953 passed.

Move the two creation scalar queries into Infrastructure.Catalogue.CatalogueCreationIdentityReader, retaining the original caller-created command for both reads and the later sequence update. Preserve SQL/CommandType, repeated ExecuteScalar evaluations, DBNull comparisons, VB formatting/conversions, checked rounded int cast, separate open/close boundaries and original no-finally error behavior. Do not cache scalar results or alter identifier generation.

Full Windows regression is pending after extraction. Missing sequence row, numeric overflow and scalar database errors remain unclaimed boundaries; exact legacy expressions are retained. No new standalone SQL/conversion mirror tests were added because original-handler database fixtures protect the moved paths.

## Verified creation identity reads; next application boundary

Full Windows run 40922446590 succeeded after identity extraction at 12123406e2ec2340b9ea082d595109af2f5bc7b6, including populated, empty MAX, SQL NULL sequence and combined cases, complete row mapping and all failure/regression checks. Independent rules passed. Revert that implementation commit to undo identity-reader extraction.

Next audit candidate: after the duplicate-code guard, creation follows numeric identity read, article identity read, add/populate new row, adapter persistence/acceptance, movement write and sequence advance. A bounded application service may own that order using an injected store and the existing lazy input adapter; infrastructure must retain one reused command and existing connection/error semantics. Characterize lazy read timing, first-failure propagation, no later effects and unchanged partial writes with a fake store before moving orchestration. Keep UI warnings/refresh and image/normalization before this boundary. Do not extend the first service extraction into edit/delete/batch workflows.

## Creation application service

Before rewiring the form, add CatalogueCreationService/ICatalogueCreationStore and pass 63 standalone assertions locally: exact identity/append/persist/movement/sequence order, no early input reads, first store failure identity, no later effects, retained Added/accepted rows and mapping failure before persistence. All prior independent tests passed.

Move only the post-duplicate-check creation block to this service. MySqlCatalogueCreationStore delegates to the verified identity/persistence/movement/sequence helpers, retains one command for both scalar reads and sequence update, and appends to the existing DataTable. Keep the existing lazy input adapter. The form retains normalization/image work, duplicate guard and warning, success warning, edit path, outer catch and refresh. No transaction, connection ownership or exception cleanup changes.

Full Windows original-handler regression is pending after service wiring. Fake-store tests protect application order, not SQL/connection internals; existing isolated database fixtures cover those. Edit/delete/batch orchestration is outside this service.

## Verified creation application milestone

Full Windows run 40925725827 succeeded after service wiring at 51350bf1f6ab3fb1e974e5a4f1bfdd383e14080e. Original creation/edit, all 33 values, duplicate guards, empty/NULL identifiers, four injected database failure boundaries, catalogue input/barcodes and prior checkout/build/launcher checks passed. Independent tests passed, including 63 creation-order/failure assertions. Revert that implementation commit to undo this service wiring.

The next remaining individual-save rule worth auditing is optional balance-code formatting: after article apostrophe normalization, Combo_BALANCE == OUI first uses Versioned.IsNumeric(Text_CODE.Text), then rounds Conversion.Val of requested width, then formats Conversion.Val(code) with a VB-generated zero mask. Numeric rejection warns before image write/database persistence. Existing fixtures use NON, so do not claim coverage or extract this branch without new original-handler evidence. Do not substitute decimal parsing, pad-left or a new barcode policy.

## Original balance-code branch fixtures

Add catalogue-balance-reject and catalogue-balance-format through the original save handler with OUI enabled and width 6. Nonnumeric CI_NOT_NUMERIC must warn after article apostrophe normalization but before identity reads/row addition/persistence; numeric 123 must become 000123 and reach the unchanged creation workflow. Verify normalized controls, unchanged sentinel, row state, movement/sequence/refresh boundaries and all 33 persisted fields for the accepted case, including BALANCE=OUI and formatted code in the movement. Keep current/previous image names identical; no hardware or image write is involved.

Production code remains unchanged. Local harness compilation passed; full Windows baseline is pending. Culture-dependent numeric/format edge cases require independent characterization before extracting the original VB rule.

## Verified balance baseline and rule extraction

Full Windows run [40928825469](https://github.com/hmasprod-a11y/LOGICA-Recovery/actions/runs/40928825469) succeeded for fc0f5431aa5a0f6d7c504ea77561f9aea68b9cc1, including original numeric rejection and formatted successful creation. Independent run 40928834535 and all prior checks passed.

Before rewiring the handler, standalone BalanceCodeFormatting tests passed 705 assertions across three cultures for original numeric detection, Val parsing, midpoint width rounding, checked width overflow, zero-mask formatting, exception identity and deferred code-read timing. All prior independent tests passed.

Move only Versioned.IsNumeric and the width/Val/format expression into Domain.BalanceCodeFormatting. Retain the form's OUI condition, warning/return, article normalization before this branch and later image/save behavior. Read code via a callback only after width conversion, preserving failures before that read. No new validation or pad-left policy. Full Windows regression is pending after extraction.

## Verified balance formatting and collection method audit

Full Windows run [40930424747](https://github.com/hmasprod-a11y/LOGICA-Recovery/actions/runs/40930424747) succeeded after balance extraction at d20933471f15bde44fe6ce0ebc12ee5f07d36306; independent runs 40930424748/40930432814 passed, including 705 balance assertions. Prior catalogue/checkout/build checks passed.

Button_SAVE_COLLECTION_Click is 186 lines. Ordered required fields precede article apostrophe normalization. It checks duplicate grid codes before opening a transaction, then loops per row through MAX/sequence reads, direct article INSERT, movement INSERT and sequence UPDATE. Commit/rollback and DoEvents/Sleep/grid selection are batch-specific and must not reuse individual helpers that close connections. Its tail hides the panel, refreshes aggregates, focuses search and uses SendKeys; avoid running that tail in a normal desktop fixture without a bounded UI isolation strategy.

Add collection-save-guards through the existing strictly isolated guard harness. Four original-handler cases (empty/spaces code/article) must warn with exact field order, retain control text before normalization, keep the connection closed and leave article/movement/sequence sentinels unchanged. Collection code TextChanged is empty; no transaction or SendKeys tail is reached. Production collection source remains unchanged.

Local harness compilation passed. Full Windows baseline is pending. After it passes, reuse the existing exact CatalogueRequiredFields predicate only for the two matching collection identifier checks. Batch persistence/rollback coverage remains separate; do not broaden this guard slice into a transaction rewrite.

## Verified collection guards and exact rule reuse

Full Windows run [40931935559](https://github.com/hmasprod-a11y/LOGICA-Recovery/actions/runs/40931935559) succeeded for 43a0026c24ac7fca3616dd91af72beb5a449e395, including all four original collection identifier rejection cases; independent run 40931945535 and prior checks passed.

Replace only the collection handler's first two VB Trim/empty predicates with the already-tested CatalogueRequiredFields.IsMissingIdentifier. Preserve warning text/order, return points, pre-normalization field text, all later raw-empty guards, transaction loop and UI tail. No batch SQL or transaction code moves. Existing standalone identifier tests already exercise this exact helper; no duplicate mirror tests were added. Full Windows regression is pending after reuse.

Next bounded coverage: collection duplicate lookup rejection before transaction. Supply valid earlier fields and a single competing grid code, verify normalization and unchanged sentinels without reaching the SendKeys tail. Successful batch commit/rollback remains outside this slice.

## Verified collection rule reuse; duplicate guard baseline

Full Windows run 40933111877 succeeded after collection identifier rule reuse at a659ab855a490190ce345fac8b4e1bc6fbe1f0cc; independent tests and all prior regression checks passed.

Add collection-duplicate-code through the original collection save handler. Supply valid required fields and one grid code matching the isolated article sentinel; require the competing-article warning, original apostrophe normalization, unchanged raw input code, closed connection and unchanged article/movement/sequence sentinels. The expected early return precedes transaction creation and SendKeys. Production source is unchanged. Local harness compilation passed; full Windows test-only baseline is pending.

## Verified collection duplicate baseline and lookup extraction

Full Windows run [40933913412](https://github.com/hmasprod-a11y/LOGICA-Recovery/actions/runs/40933913412) succeeded for a909adad9f23b6d30e37bd6a536ad54073492b0b, including original collection duplicate rejection before transaction. Independent run 40933922292 and prior regression checks passed.

Move only the collection pre-transaction adapter Fill query into CatalogueDuplicateLookup.FillCollectionCode. Accept the raw grid-cell object and preserve nested VB ConcatenateObject/Conversions.ToString and exact SQL/trailing spaces. Retain table Clear, first matching Article warning, early return, per-row loop and grid selection in the form. The helper relies on adapter-managed connection behavior and adds no explicit close/transaction handling; do not reuse individual creation readers/writers inside the batch transaction.

Full Windows regression is pending after extraction. Successful batch insertion/rollback and unusual raw object cells remain unclaimed boundaries. Next bounded fixture: reach the pre-transaction duplicate check at a later grid row, verifying first-match early termination and no persistence without executing the SendKeys tail.

## Verified collection lookup; later-row early-stop fixture

Full Windows run [40935603894](https://github.com/hmasprod-a11y/LOGICA-Recovery/actions/runs/40935603894) succeeded for 9c34d75b6bdb9cb4517d0d1f876c165a453ea4d1 after collection lookup extraction. Independent runs 40935603906/40935612213 and prior regression checks passed.

Add collection-duplicate-later with three grid rows: a nonmatching code, the competing sentinel code, then an intentionally malformed trailing code that must never be queried. Require the expected duplicate warning, unchanged database sentinels/sequence/connection and original last-row selection after the preceding no-match. This covers the no-match branch and early termination without entering transaction or SendKeys. Original product source is unchanged.

Local harness compilation passed. Full Windows evidence is pending. After verification, a bounded precheck service may own row iteration only if grid-row reads, last-row selection timing, first-match stop and exception propagation remain explicit; transaction work is still deferred.

## Verified later-row rejection; precheck application extraction

Full Windows run [40937242346](https://github.com/hmasprod-a11y/LOGICA-Recovery/actions/runs/40937242346) succeeded for 5fdbb3c6ce086cfdbb99529547d12ebe28ce3278, including preceding no-match/later duplicate and unvisited malformed trailing code. Independent run 40937251045 and prior checks passed.

Before moving the loop, standalone CollectionDuplicatePrecheck tests passed 45 assertions for raw code object identity, read/lookup/no-match selection ordering, first-match termination, empty range and read/lookup/selection failure identity without later work. All prior independent tests passed.

Move only pre-transaction duplicate iteration into this ApplicationLayer service. The form supplies a snapshot last index, lazy grid-cell reads, the verified lookup, and an explicit callback retaining its two original last-row selection operations. The form retains exact warning/return and the entire transaction/UI tail. Service returns the original first matching DataRow for raw Article access; no input normalization or new policy. Full Windows regression is pending after wiring. Batch insertion/commit/rollback remains unverified and unchanged.

## Verified precheck service; next variant audit

Windows run 40938837380 succeeded after precheck service wiring at a9997936f06de91907f9b519b19a9100d202c651; independent tests passed, including 45 ordering/raw-object/exception assertions. Original first/later duplicate fixtures and all prior checks passed. Revert that implementation commit to undo precheck wiring.

Button_INSERER_Click validates raw-empty code, six-character length, raw-empty article and prices, constructs code + 99 + size-code + colour-code using VB object concatenation, converts quantity to decimal, then repeats the same twelve-digit checksum arithmetic already extracted elsewhere. It checks existing grid codes, only then calls IsNumeric(quantity), appends five grid values, refreshes totals, resets quantity to 0 and selects the last row. Preserve quantity conversion before numeric guard, object conversions and UI timing; do not silently add validation.

Next fixture should supply original size/colour grids and a valid twelve-digit payload, verify independent check digit, five appended values, totals, reset and duplicate rejection with unchanged rows. Audit grid event callbacks before setup. Full batch commit/rollback is not needed to test this in-memory path and remains deferred.

## Original in-memory variant insertion fixture

Add collection-variant-insert invoking unchanged Button_INSERER_Click. Original size/colour grids have no attached callbacks; supply size 01/M and colours 02/Blue then 03/Red with prefix 221234. Verify the 13-digit code using an independent right-to-left checksum oracle, all five grid values (including unnormalized article apostrophe/spaces), fractional 1.25 and accepted negative -0.5 quantities, total 0.75, row counts, quantity reset and last-row selection.

Between valid inserts, retry the same size/colour with quantity 2.5 and require the original duplicate warning, unchanged row/total and pending quantity left at 2.5. No database calls, transaction or SendKeys tail are involved in this method. Production source remains unchanged.

Local harness compilation passed; full Windows original-handler baseline is pending before reusing CatalogueBarcodeChecksum in this second caller. Malformed size/colour/quantity paths are not claimed by this valid-payload slice.

## Variant fixture setup repair

Windows run 40941830978 failed only collection-variant-insert during fixture selection: CurrentCell cannot target an invisible cell. The failure occurred in the harness before Button_INSERER_Click; resource-defined first code columns were selected by index. Existing catalogue/checkout cases passed; independent run 40941838830 passed. No production defect or checksum regression is established by this setup failure.

Select explicit visible TAILLE/COULEUR display columns for the fixture's current size/colour rows. Keep code values in their original named columns for the handler's reads. Production source remains unchanged; rerun the justified Windows baseline with this fixture correction before extraction.

## Verified variant baseline and checksum reuse

Full Windows run [40943309383](https://github.com/hmasprod-a11y/LOGICA-Recovery/actions/runs/40943309383) succeeded for d9124550679f74d6091e825d4eca79131ae3d76e after fixture cell selection repair. Original variant insertion, fractional/negative quantities, duplicate warning, totals/reset/selection and all prior checks passed. Independent run 40943318037 passed.

Replace only Button_INSERER_Click's repeated twelve-digit checksum arithmetic with the verified CatalogueBarcodeChecksum.CompleteTwelveDigitPayload(text). Keep payload construction, quantity conversion before checksum, getBits call, suffix append, duplicate scan, later IsNumeric check and grid/total/reset/selection order. Retain the loop locals still used by the duplicate scan. No barcode format, quantity validation or UI changes.

Full Windows original-handler regression is pending after reuse. Existing independent checksum assertions cover the reused helper; no duplicate mirror tests or redundant local rerun was added for unchanged helper code.

## Verified variant checksum reuse

Full Windows run 40944010253 succeeded after checksum reuse at 4e52a89910db459e3be5582e462506c966445216. Original variant insertion, fractional/negative quantities, duplicate warning, totals/reset/selection and all prior catalogue/checkout/build/launcher checks passed. Independent rules passed. Revert that implementation commit to undo the second checksum caller change.

Next quantity-total audit: Button_CALC_DOC_Click snapshots the last grid index, starts decimal zero, and applies Conversions.ToDecimal(Operators.AddObject(total, raw cell value)) for each row. It then uses FLOUSS for display and reads current grid row count. Preserve raw-object VB conversion and exception timing; do not replace it with a decimal cast/LINQ Sum or move the later count read ahead of accumulation. A no-database original-handler fixture can characterize empty, numeric and string quantity cells before extraction.

## Original collection quantity-total fixture

Add collection-quantity-totals invoking unchanged Button_CALC_DOC_Click for an empty grid, fractional/negative decimals, numeric strings, mixed integral types and a zero cell. Require both total/count labels to replace sentinels with expected values, and every raw cell value and row count to remain unchanged. No database writes or keyboard actions are involved.

Harness compilation passed locally. Full Windows baseline is pending before moving the accumulation loop. DBNull/malformed cells and deferred read exceptions need independent characterization against the exact legacy expression; do not infer blanket decimal-cast behavior from these valid cases. FLOUSS and the later current-row-count read must stay at their original UI points.

## Verified total baseline and accumulation extraction

Full Windows run [40946117541](https://github.com/hmasprod-a11y/LOGICA-Recovery/actions/runs/40946117541) succeeded for ff84b4b992c925fb0c8fdc19f6095e3f48a47697, including original empty/decimal/string/integral/zero grid totals and unchanged raw cells. Independent run 40946122815 and all prior checks passed.

Before wiring the handler, standalone CollectionQuantityTotals tests passed 111 assertions across three cultures against the legacy raw-object addition/conversion behavior, including null/DBNull, malformed strings, mixed numeric types, nonfinite/overflow values, empty range and first-failure read timing/exception identity. All prior independent tests passed.

Move only accumulation to Domain.CollectionQuantityTotals.Accumulate using a snapshotted last index and lazy cell reader. Keep FLOUSS/display conversion, later current row-count read, labels and original catch in the form. Preserve AddObject then ToDecimal at each row, with no eager parsing, LINQ sum or normalization. Full Windows regression is pending after extraction.
