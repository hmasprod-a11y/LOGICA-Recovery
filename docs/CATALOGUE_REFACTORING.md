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
