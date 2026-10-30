# Counted-cash refactoring: current checkpoint

- Draft PR #12, branch refactor/cash-counting-rules, based on checkout PR #8; independent of catalogue #10 and movement #11.
- Verified implementation: 532dbe84717eb88d2ed67b1966bec7930ebfc6e6.
- [Windows run 40966560485](https://github.com/hmasprod-a11y/LOGICA-Recovery/actions/runs/40966560485) and independent runs 40966560437/40966568154 passed. No implementation check is pending.
- Denomination arithmetic and input-reset decision are separated. Preserve mixed decimal/double math, eager repeated sender reads, culture and matching grid-row behavior.
- Next bounded step: test then extract counted-cash orchestration (background, reset, lazy calculation, total display, payment-row scan/update). Keep the exact ESPECES comparison, snapshot last index, per-match FormatNumber and partial failures. No financial Load, closing or persistence.

## Evidence and method history

# Counted-cash refactoring

## Priority and scope

Preserve the working LOGICA behavior while separating counted-cash arithmetic from WinForms. P0 cash scope, not a cash-session redesign. No financial writes, shop data, activation, UI redesign or new features. Independent draft branch based on checkout PR #8; catalogue #10 and movement #11 remain separate.

## Confirmed method audit

The counting formula is in FormDialog_COMPTER_CAISSE.TextBox_LostFocus, not Text_200_TextChanged (which is empty). This corrects the earlier reconnaissance note in the movement log. The handler first resets sender BackColor, eagerly checks VB trimmed emptiness/numeric state, normalizes invalid sender to 0, then reads eleven denomination controls.

The original formula sums 200/100/50/20/10/5/2/1 in decimal, converts to double, adds 0.5/0.2/0.1 portions in double, constructs decimal and uses VB FormatNumber. It updates all grid rows whose MODE_P matches ESPECES with binary VB comparison. Preserve mixed arithmetic/order/culture; do not silently switch to all-decimal math or normalize other inputs.

## Original-handler fixture

Add cash-counting without showing the dialog or invoking Load (Load queries financial data). Seven cases cover zero, one of every denomination, fractional coins, negative/fractional counts, invalid/space sender reset, white focus background, both ESPECES rows updated and other/case-different modes untouched. Other denomination text stays unchanged. No financial persistence, keyboard action or session operation is invoked.

Harness compilation passed locally. Full Windows baseline is pending before arithmetic extraction; malformed non-sender inputs and overflow/read failure need independent characterization.

## Verified baseline and denomination arithmetic extraction

Windows run [40964702869](https://github.com/hmasprod-a11y/LOGICA-Recovery/actions/runs/40964702869) passed for 1a14d0b8f8d7331d2dbca3606124fb8aba0321cb, including all seven original LostFocus scenarios and prior checkout/build/launcher checks.

Before rewiring the handler, CashDenominationTotal passed 759 standalone assertions across three cultures: known totals, seeded mixed arithmetic, exact denomination read order, every getter/conversion failure boundary, null/empty/numeric formatting and overflow. Retain the exact original decimal subtotal/double additions/decimal constructor expression.

Move only arithmetic to Domain.CashDenominationTotal.Calculate with deferred denomination readers. The form retains late-bound sender normalization/background, input access order, VB FormatNumber and all matching cash-row updates. No eager snapshot, new validation, all-decimal arithmetic, Load or financial persistence. Full Windows regression is pending after extraction.

## Verified arithmetic and input-rule extraction

Windows run [40965972702](https://github.com/hmasprod-a11y/LOGICA-Recovery/actions/runs/40965972702) passed for 926a48741e98876b7ecc4897e3c1614d6e857d54 after arithmetic extraction. Independent runs 40965972680/40965979425 passed, including 759 arithmetic assertions. Original normalization/formatting/cash-row and prior checkout/build/launcher checks passed.

Before changing the predicate, CashCountInputRules passed 117 standalone assertions across three cultures for null/blank/invalid/numeric values, VB object conversions, both eager text reads, changing second values and first/second getter exception identity. Extract only the reset decision with a deferred late-bound reader. Keep eager |, sender BackColor before the decision, late-bound reset to 0 afterward, arithmetic and cash-row update order. No new validation or input caching. Full Windows regression is pending after rule extraction.

## Verified counted-cash rules milestone

Windows run 40966560485 passed after input-rule extraction, with all original LostFocus scenarios and prior checkout/build/launcher checks. Independent tests passed, including 759 arithmetic and 117 input-rule assertions. No cash-session/financial mutation path is covered or changed. Revert 532dbe84717eb88d2ed67b1966bec7930ebfc6e6 to undo the latest rule extraction.

## Counted-cash orchestration extraction pending

Before wiring the handler, CashRecountService passed 214 standalone assertions for background/eager normalization/lazy denomination calculation/total display/payment scan order, exact ESPECES matches, empty grid, first getter/action failure identity and retained partial row updates.

Move only recount ordering into ApplicationLayer.Cash using a narrow context. A nested form context retains original late-bound background/text operations, denomination getters, VB FormatNumber for total and each matching row separately, checked last-index snapshot and raw payment-mode access. No eager snapshot, cached row formatting, financial Load/writes or new validation. Independent runner includes Application/Cash. Full original-handler Windows regression is pending after wiring.
