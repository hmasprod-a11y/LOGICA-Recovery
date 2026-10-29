# Stock movement search refactoring

## Current checkpoint

- Draft [PR #11](https://github.com/hmasprod-a11y/LOGICA-Recovery/pull/11), branch refactor/stock-movement-search, based on checkout PR #8 and independent of catalogue PR #10.
- Verified implementation: a7e9c976d74fa43e1dbf17d09500497dba81c8e3.
- [Windows run 40962003804](https://github.com/hmasprod-a11y/LOGICA-Recovery/actions/runs/40962003804) and independent runs 40962003801/40962009645 passed. No implementation verification remains pending.
- Search branch ordering is separated into Application.Inventory; original form context preserves DT/DA mutation, object prefix and query factories. Query/refresh SQL construction is already separated.
- Next bounded audit: refresh ordering (sender Focus, clear search with reentrant original TextChanged, search Focus, clear/reload all, bind). Write independent action/failure ordering tests before moving it; retain the original-handler refresh fixture and original catch.

## Priority and scope

LOGICA is working. Preserve behavior while separating query logic. No stock writes, shop data, activation, new features, UI redesign or migration.

## Protected behavior

The original-handler fixture covers inclusive date boundaries, contains LIKE, exact-checkbox LIKE (wildcards remain active), optional date prefix, empty-text retention, descending ID order, refresh clearing search/reloading all rows, original DT binding and closed adapter-owned connection. Four isolated fixture rows remain unchanged in count.

TextChanged invokes the original search handler; selecting DATES sets text and also searches. Preserve original event timing. _sql is object and must remain an object boundary in VB ConcatenateObject; do not narrow or normalize it.

## Evidence and history

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

## Search failure fixture pending

Add stock-movement-search-failure after successful search/refresh setup. Select a deliberately missing fixture column with optional dates and query through original TextChanged/explicit search callbacks. Require the original column error warning, prior results cleared in the same DT, grid still bound to that DT, a newly assigned DA retaining the attempted query, updated object date prefix and adapter-owned closed connection. Fixture row count remains four. Warning count is not fixed because original control events can also invoke search.

This protects the meaningful difference from empty search, which retains previous rows. No production code change; harness compilation passed locally. Full Windows baseline is pending before considering movement search orchestration extraction. Existing diagnostics remain within disposable CI files.

## Verified query failure and next application boundary

Windows run [40960626952](https://github.com/hmasprod-a11y/LOGICA-Recovery/actions/runs/40960626952) passed for a4fe6278362b911263d49802d647bba55731b4b4. The original query failure clears existing results in the same DT, retains newly assigned DA/query and date prefix, reports the expected warning and closes the adapter-owned connection. Independent run 40960632990 passed; prior checkout/build/launcher checks passed.

Next extraction can move only Picture_FIND_Click branch ordering into Application.Inventory using a narrow context interface. Retain lazy column/text/date/exact reads (including the original second exact-checkbox read), date mode ignoring text, empty search rebinding previous DT, prefix update before lookup, and no BindResults after a thrown lookup. A nested form context can preserve private DT/DA mutations and original query factories without reflection or new connection ownership. Write independent ordering/read/failure tests before rewiring the original handler. Refresh and outer catch stay separate.

## Search application flow extraction pending

Before rewiring the handler, StockMovementSearchService passed 89 standalone assertions locally: date branch avoids text reads; null/empty text rebinds old results; whitespace searches; optional prefix ordering; original second exact-checkbox read (including a changed second value); case-sensitive DATES comparison; first getter/load/bind exception identity and no later work.

Move only branch ordering into ApplicationLayer.Inventory with a narrow context. A nested form context retains private DT/DA assignments and exact query-factory calls, clears before adapter creation, assigns before Fill, updates the object prefix at the same point and binds only after successful execution. Outer UI catch, refresh, original events and connection ownership remain in place. Independent runner includes the new Application/Inventory folder. Full original-handler Windows regression is pending after wiring.

## Verified search application milestone

Windows run 40962003804 passed after service wiring at a7e9c976d74fa43e1dbf17d09500497dba81c8e3, including all original search/refresh/failure paths and existing checkout/build/launcher checks. Independent tests passed, including 89 branch/read-order/exception assertions. Revert that implementation commit to undo search-flow extraction. No stock mutation behavior was changed or claimed by this read-model slice.

## Refresh application flow extraction pending

Before rewiring refresh, StockMovementRefreshService passed 36 standalone assertions locally: sender focus, search clear, reentrant search callback, search focus, reload and binding order; first failure identity/no later actions; partial reload state preserved. The existing original-handler fixture already exercises refresh after date search and verifies final unfiltered descending results/search reset.

Move only refresh ordering into Application.Inventory with a separate narrow refresh context. A nested form context retains original late-bound sender Focus, Texts assignment triggering existing TextChanged, Control.Focus, DT.Clear, DA assignment before Fill and grid binding. Search service, query factories, outer catch and connection ownership remain unchanged. Full Windows regression is pending after wiring; no redundant standalone rerun of unchanged rules was needed.
