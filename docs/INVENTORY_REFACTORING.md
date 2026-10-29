# Stock movement search refactoring

## Priority and scope

LOGICA is working. Preserve behavior while separating query logic from Form_6_MOUVEMENTS_STOCK. No movement writes, shop data, activation, new features, UI redesign or migration. This independent draft branch is based on verified checkout PR #8; catalogue PR #10 remains separate.

## Original method audit

The 68 KB form is a read/search/export view. Picture_FIND_Click supports date-only search, contains LIKE, exact-checkbox LIKE (wildcards still active), optional date prefix and descending ID order. Empty search text retains the previous DataTable. Refresh clears search text (whose original event also searches), clears DT, reloads all rows and rebinds the grid. Preserve these behaviors and event timing.

## First characterization

Add stock-movement-search on exactly 127.0.0.1:3307/logica_ci. Four dated rows distinguish inclusive date boundaries, contains mode, exact LIKE including a wildcard, optional date, empty-text retention and refresh ordering. Use original controls/events and handlers; assert original DT binding, closed connection and unchanged row count. TextChanged triggers original search as well as the explicit fixture invocation; date flag only toggles panel visibility, and selecting DATES sets search text.

Harness compilation passed locally. Full Windows baseline is pending; production source is unchanged. Before extracting query logic, inspect that runtime result and preserve raw SQL/VB concatenation, input-read order, DT.Clear placement, adapter settings and original catch.

## Verified baseline and query extraction

Windows run [40957237265](https://github.com/hmasprod-a11y/LOGICA-Recovery/actions/runs/40957237265) succeeded for cfe00845d13add61bf27f93b70e110c2b236e8bc with original search/refresh branches and existing checkout/build/launcher checks.

Move only adapter construction/query assembly into Infrastructure.Inventory.StockMovementQuery, including the optional date prefix. Retain exact SQL/LIKE/wildcards, VB date/object concatenation, descending order and adapter settings. The form still clears DT before constructing each adapter, assigns DA before Fill (including on query execution failure), binds DT, retains results on empty search and owns UI events/catch. No parameterization, validation or connection cleanup changes. Full Windows regression is pending after extraction; no redundant SQL-string mirror tests were added.

## Adapter factory signature repair

Windows run 40958553076 caught a compile-time narrowing mistake in the new Contains/ExactLike factory signatures: the original form's _sql field is object, not string. Preserve that object boundary, matching its original VB ConcatenateObject usage; do not add a caller cast/string conversion. Change only the two datePrefix parameters to object. Production behavior was not exercised in that failed build; independent rules passed. Full Windows validation must run after the corrected signature before this extraction is accepted.
