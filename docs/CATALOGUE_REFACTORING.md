# Catalogue refactoring: current checkpoint

## Priority

LOGICA already works. Organize internals incrementally while preserving behavior. No shop-data/activation changes, UI redesign, new features, framework migration, automatic merge or release. TODO POS remains selective inspiration.

## Verified state

- Branch: refactor/catalogue-input-rules, draft PR [#10](https://github.com/hmasprod-a11y/LOGICA-Recovery/pull/10), stacked on draft #8.
- Latest implementation: 95384219e225ec976686fd188225367938953cee.
- [Windows run 40952781294](https://github.com/hmasprod-a11y/LOGICA-Recovery/actions/runs/40952781294) succeeded; independent runs 40952781377/40952787375 succeeded. No implementation verification remains pending.
- Current milestone separates aggregate SQL and UI-independent count/money formatting, retaining all eleven original labels/filter branches and 114 independent formatting assertions.
- Documentation-only checkpoint updates do not require another expensive Windows run.

## Completed boundaries

- Domain: rounding/pricing safeguards inherited from #8; catalogue required identifiers, promotion, balance code formatting, barcode checksum, raw collection quantity totals.
- Application/Catalogue: lazy 33-column row mapping, ordered creation flow, collection pre-transaction duplicate iteration.
- Infrastructure/Catalogue: original duplicate SQL, creation identity reads, adapter persistence, creation movement and sequence update.
- Presentation/Catalogue and Presentation/Input: lazy form adapter and shared numeric character filter.
- The form retains warnings, normalization/image work, error catch, refresh and batch transaction/UI work.

## Behavior protected by fixtures

Individual creation/edit: all 33 stored fields; legacy differences in average price, opening stock and inventory date; duplicate rejection; empty MAX/NULL sequence; movement/sequence/audit/refresh; adapter INSERT/UPDATE, movement and sequence failures.

Collection: early required guards, first/later duplicate rejection before transaction, raw-object lookup/selection timing, in-memory size/colour insertion, independent barcode, fractional/negative quantities, duplicate stop and quantity totals/reset/selection.

Original Windows checkout/build/launcher checks and independent rules/services tests passed with the latest implementation.

## Preserve explicitly

- VB conversions/culture, repeated scalar reads, checked casts, raw strings and lazy read order.
- Individual partial commits and Added/Modified in-memory rows on failure. No incidental transaction or cleanup fix.
- Batch transaction remains distinct; do not reuse individual helpers that close its connection.
- Batch DoEvents/Sleep and SendKeys tail remain untouched. Successful batch commit/rollback has not been accepted.
- Images, real hardware and whole-product commercial/security readiness are not claimed by these fixtures.

## Next bounded work

Before moving further refresh orchestration, characterize aggregate lookup failure through the original handler: unchanged label sentinels when Fill fails, original _sql side effect, adapter-owned connection state and error propagation to the existing warning/catch. Use only the strict isolated database; avoid changing raw family SQL escaping/validation as incidental cleanup. Successful output/formatting is already covered across all eleven labels. Batch transaction, physical devices and image handling remain separate boundaries.

## Evidence and history

- [Requirements evidence map](REQUIREMENTS_STATUS.md): partial evidence versus remaining acceptance, no global completion percentage.
- [Detailed method audit and per-commit history](archive/CATALOGUE_REFACTORING_HISTORY.md): original baselines, failures, fixture repairs, exact SQL/conversion boundaries and revert commits.
- Checkout continuation: [REFACTORING.md](REFACTORING.md).

## Aggregate refresh characterization pending

Add catalogue-aggregate-refresh on the strict isolated database. Six article rows distinguish negative/zero/positive stock, alert boundary, promotion, quantity tiers and positive/zero purchase/average/sale prices across families A/B. Verify all eleven original output labels for null, empty, A, B and missing-family filters; missing-family sums exercise DBNull display. Preserve 20-character masked DH displays and the original _sql reset only for null/empty family.

The fixture intentionally protects the original purchase-exclusion count that tests PRIX_MP rather than PRIX_A; do not correct it in this refactor. Require adapter-owned closed connection and unchanged row count. Production aggregate logic remains unchanged. Harness compilation passed locally; full Windows baseline is pending before query extraction.

## Verified aggregates and lookup extraction

Windows run [40949904984](https://github.com/hmasprod-a11y/LOGICA-Recovery/actions/runs/40949904984) passed for 76748dd461e1229bd057051505f81ec33157bb0b: all eleven outputs across null/empty/A/B/missing filters, NULL sums, money mask and _sql side effect. Independent run 40949910295 and prior regression checks passed.

Move only family-filter SQL assembly and the ordered eleven-query UNION/adapter Fill into Infrastructure.Catalogue.CatalogueAggregateLookup.Read. Preserve query order/text, raw family concatenation, original purchase exclusion using PRIX_MP, adapter-owned connection behavior and DataTable result. The form retains _sql reset, DBNull checks, conversions/FLOUSS, every label assignment and original catch. No parameterization, query correction, cache, transaction or UI redesign. Full Windows regression is pending after extraction.

## Verified aggregate lookup milestone

Windows run [40951282675](https://github.com/hmasprod-a11y/LOGICA-Recovery/actions/runs/40951282675) passed after aggregate SQL extraction at 01b0aa9494b56ec12b63533976dfce80c6432afe. Independent runs 40951282878/40951292006 passed. All eleven labels, filters/NULL sums/masks/_sql behavior and prior catalogue/checkout/build/launcher checks passed. No implementation verification remains pending. Revert that implementation commit to undo aggregate lookup extraction.

## Aggregate display formatter extraction pending

Before changing label branches, CatalogueAggregateFormatting tests passed 114 standalone assertions across three cultures for DBNull/null, raw numeric/string values, monetary midpoint rounding, 20-character #/DH mask, large values and equivalent exception types. All prior independent tests passed. Independent runner includes only the new UI-independent Presentation/Formatting folder, not the WinForms adapter folder.

Replace the eleven repeated count/money DBNull branches with formatter calls. Retain original label assignment order, per-row DataTable value access, _sql side effect, lookup/error catch and rounding rules. The formatter uses verified MonetaryRounding (the existing FLOUSS compatibility target). No display redesign or value normalization. Full Windows original-handler aggregate regression is pending after extraction.

## Verified aggregate display formatting

Windows run 40952781294 passed after formatting extraction at 95384219e225ec976686fd188225367938953cee. All eleven original aggregate outputs, family filters, NULL sums, monetary mask and prior catalogue/checkout/build/launcher checks passed. Independent runs passed, including 114 raw-value/culture/rounding/exception assertions. Revert that implementation commit to undo formatting extraction.

## Aggregate lookup failure fixture pending

Add catalogue-aggregate-failure using only 127.0.0.1:3307/logica_ci. After seeding six fixture rows, rename the fixture PRIX_MP column so the unchanged aggregate query fails. Invoke the original handler with null and nonempty family filters, require its PRIX_MP error warning, all eleven labels still at their prior sentinels, original _sql reset/non-reset behavior, adapter-owned closed connection and unchanged row count. This avoids changing production query validation/escaping and exercises failure before any label assignment.

Harness compilation passed locally. Full Windows failure-path verification is pending. Production source remains unchanged; normal aggregate fixtures retain their original schema and cases. The handler's existing diagnostics stay within disposable CI files.
