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
