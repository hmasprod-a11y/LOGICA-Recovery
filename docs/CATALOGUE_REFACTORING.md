# Catalogue refactoring: current checkpoint

## Priority

LOGICA already works. Organize internals incrementally while preserving behavior. No shop-data/activation changes, UI redesign, new features, framework migration, automatic merge or release. TODO POS remains selective inspiration.

## Verified state

- Branch: refactor/catalogue-input-rules, draft PR [#10](https://github.com/hmasprod-a11y/LOGICA-Recovery/pull/10), stacked on draft #8.
- Latest implementation: 01b0aa9494b56ec12b63533976dfce80c6432afe.
- [Windows run 40951282675](https://github.com/hmasprod-a11y/LOGICA-Recovery/actions/runs/40947592637) succeeded; independent runs 40951282878/40951292006 succeeded. Implementation is verified; new aggregate fixture verification is pending.
- Current change separates raw-object collection quantity accumulation. 111 standalone assertions cover cultures, empty values, conversion/overflow and lazy failure behavior; original-handler empty/decimal/string/integral/zero fixtures passed.
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

Aggregate SQL extraction is verified across all eleven outputs and null/empty/A/B/missing family filters. Next inspect the repeated count/money display conversions before extracting a UI-independent formatter. Preserve DBNull branches, VB Val/ToString, existing monetary rounding, 20-character # padding, DH suffix and partial label assignment order. Write independent culture/raw-value/exception tests before replacing any label branch; retain the original-handler aggregate fixture.

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
