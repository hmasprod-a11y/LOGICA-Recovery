# Catalogue code organization

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
