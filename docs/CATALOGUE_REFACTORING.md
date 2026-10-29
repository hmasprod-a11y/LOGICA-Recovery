# Catalogue refactoring: current checkpoint

## Priority

LOGICA already works. Organize internals incrementally while preserving behavior. No shop-data/activation changes, UI redesign, new features, framework migration, automatic merge or release. TODO POS remains selective inspiration.

## Verified state

- Branch: refactor/catalogue-input-rules, draft PR [#10](https://github.com/hmasprod-a11y/LOGICA-Recovery/pull/10), stacked on draft #8.
- Latest implementation: b6200a8de2d41897ae8042182cce083176d2aabc.
- [Windows run 40947592637](https://github.com/hmasprod-a11y/LOGICA-Recovery/actions/runs/40947592637) succeeded; independent runs 40947592767/40947603866 succeeded. Implementation is verified; new aggregate fixture verification is pending.
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

Audit Button_CALC_Click catalogue aggregate refresh. Existing creation/edit fixtures prove that refresh executes and article count is correct, but not all eleven aggregate outputs/filter branches. Add isolated original-handler fixtures for every output and family filter before moving aggregate queries. Keep UI labels, formatting and original error behavior explicit. Do not broaden this into batch transaction or UI redesign.

## Evidence and history

- [Requirements evidence map](REQUIREMENTS_STATUS.md): partial evidence versus remaining acceptance, no global completion percentage.
- [Detailed method audit and per-commit history](archive/CATALOGUE_REFACTORING_HISTORY.md): original baselines, failures, fixture repairs, exact SQL/conversion boundaries and revert commits.
- Checkout continuation: [REFACTORING.md](REFACTORING.md).

## Aggregate refresh characterization pending

Add catalogue-aggregate-refresh on the strict isolated database. Six article rows distinguish negative/zero/positive stock, alert boundary, promotion, quantity tiers and positive/zero purchase/average/sale prices across families A/B. Verify all eleven original output labels for null, empty, A, B and missing-family filters; missing-family sums exercise DBNull display. Preserve 20-character masked DH displays and the original _sql reset only for null/empty family.

The fixture intentionally protects the original purchase-exclusion count that tests PRIX_MP rather than PRIX_A; do not correct it in this refactor. Require adapter-owned closed connection and unchanged row count. Production aggregate logic remains unchanged. Harness compilation passed locally; full Windows baseline is pending before query extraction.
