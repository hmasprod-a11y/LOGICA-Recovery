# HANOUTY POS V2.0 — EXECUTION CONTRACT V3 / DELIVERY WAVES
**Effective:** 2026-11-04  
**Repository:** `hmasprod-a11y/LOGICA-Recovery`  
**Authority:** user-directed correction to execution, complementary to `docs/HANOUTY_MASTER_MODERNIZATION_V2.md` (PR #95) and functional LOGICA V1 (2026-10-29). If older instructions contradict the user's **final technology decision**, this contract wins for technical architecture, never for functional parity.  
**Status:** development contract on Architecture PR #95; not a commercial release approval.

## 2026-11-04 03:08 UTC — Binding corrective addendum V3.1 (latest evidence overrides stale §1 snapshot)

This addendum updates execution **and acceptance**, not the user-approved product scope. Sections 0, 2–6 and functional LOGICA V1 continue to apply. The section 1 SHAs, old WPF EmptyCatalogueReader diagnosis, and historical WPF preview failure are **historical baselines**, not current blockers. Do not undo completed fixes or reopen architecture selection.

### Current verified heads / status (all draft unless otherwise stated)
| Owner | Reviewed head | Evidence | Correct next blocker |
|---|---|---|---|
| 01 Architecture PR #95 | `038dbbf89b52fe1daadec785c77242d73db0928f` | Windows, portable .NET10, Core success; typed catalogue snapshot, checkout session, repeated scan/overflow guards and regressions | Real adapter implementations + WPF production composition remain unproven; interfaces must be consumed rather than reinvented |
| 02 Checkout PR #75 | `367f05160ac1ff1c33f00a0d1e07b72c460b5ff7` | 5/5 CI successful incl Windows and domain; atomic posting/claim/rollback plus catalogue pricing integrity safeguards | Real disposable-MariaDB boundary with durable idempotency, WPF invocation, legacy money parity and failure injection not accepted |
| 03 Inventory PR #88 / stacked #92 | `a8144451e79c0f0664ab6de5c88dbfaabf53e7aa` | Core, portable, article and domain green; **Windows FAIL** run [41763273059](https://github.com/hmasprod-a11y/LOGICA-Recovery/actions/runs/41763273059) | Now errors remain in `Form_2_Familles.cs`, `Form_3_VENTE_ENTETE.cs` and possibly more unqualified `Application` calls, not only former `Form_2_ARTICLES.cs`. Fix entire observed compiler diagnostic batch, then rerun same-head Windows CI |
| 04 WPF PR #96 | `87185f178bb3bd56c253931bb77a1f416923b7b1` | new touch/image tile guards; portable and core green, Windows in progress at inspection | `MainWindow(ICatalogueReader,IProductSelection)` now **requires injected services**, and `App.ResolveServices` fails closed if unregistered: do not claim old MainWindow uses `EmptyCatalogueReader`. No verified real production registration, local MariaDB adapter, or committed sale |
| 05 QA PR #93 | `7382dd99b575dba734f0e5f9b302b65ce71f171c` | 7/7 workflows green incl WPF preview on selected pinned source `5a9c72e` | WPF preview is now BEHIND PR #96 head `87185f1`; fresh exact-pair WPF + **real DB** W1 acceptance and W2 sale/rollback pending. Green preview != integrated W1/W2 |

The numbers `35%` or `70%` are estimates **not audit-backed feature percentages**; do not report them as objective completion. QA must produce a V1 parity ledger with exact countable accepted criteria (implemented/accepted/blocked/not started) and sources. No commercial-readiness percentage until this exists.

### Supervisor corrective decisions — executable now
**Decision D1 (one integration plane):** retain PR #93 `integration/hanouty-qa-desktop-inventory-20261102` as sole QA integration destination. No force merges of stacked/dirty #91/#92, no `main`/`release` mutation. Before integrating, QA records exact branch SHAs, file conflicts, acceptance gates and rollback point. Pin latest reviewed WPF SHA for preview only; never present older green pin as latest HEAD.

**Decision D2 (W0 hard gate / Inventory owner):** immediately triage *all* CS0234 `LOGICA.Application` vs `System.Windows.Forms.Application` compilation errors from same Windows CI log, including Familles, VENTE_ENTETE and any following diagnostics, and apply qualified names or non-invasive alias in each impacted source once. Run real Windows build, correct any cascading errors, preserve original behavior. Source scan without a green Windows build does not close W0. Track04 must explicitly authorize shared desktop form edits or take ownership; coordinate on Issue #94 and continue work on unblocked inventory adapter.

**Decision D3 (W1 / real catalogue first):** Architecture owns ONE contract in `docs/HANOUTY_W1_SHARED_CONTRACT_2026-11-04.md` and associated production interfaces. Explicit mapping needed between Architecture `ProductSummary(ArticleId,Barcode,DisplayName,ImagePath,VariantId)` and WPF local `ProductSummary(Id,Name,Barcode,ImagePath)`; do not silently introduce a second independent reader or discard variant identity. Inventory delivers parameterized READ-ONLY disposable MariaDB adapter implementing one agreed interface, including stable IDs, missing photos, duplicate barcodes and empty/null rules. WPF registers it in **actual** `App.ResolveServices` composition root; do not install demo fallback and do not show blank catalogue as completed deployment. QA on SAME reviewed source set must start real WPF EXE with disposable local MariaDB and prove product list/photo-only/scan. **No W1 acceptance from standalone ViewModel tests**.

**Decision D4 (W2 / complete sale):** Checkout adapts its existing atomic posting service to the *same* Architecture atomic batch/journal interfaces using persistent unique key and single caller-owned MariaDB transaction, including stock+payments+returns, unknown commit reconciliation and restart deduplication. WPF wires real cart/pay/quantity/remove/return commands and preserves scanned barcode on rejected selection; no money arithmetic in XAML. QA exercises exact real WPF → local MariaDB → persisted checkout and rollback, including two-click duplicate, crash/timeout/unknown commit and explicit cashier authorization. No in-memory or fake service accepted.

**Decision D5 (safety and stock):** Stock changes require verified actor authorization at write boundary, not just global feature flag; use disposable database, check duplicate article identities and simultaneous updates, preserve audit and fail-closed rollback. No access to shops' live databases, license bypass, implicit auto migration, weakened regression checks or physical-device acceptance claims.

**Decision D6 (pace & evidence):** Every delivery cycle must leave a coherent production-code + regression batch (or QA exact-source integration job), push SHA and inspect the completed CI on the same SHA; if CI fails, work the precise failure, not a new report. Dependence on another team is not an excuse to avoid independently implementable tests/adapters. Supervisor reconciles Issue #94 after new evidence, with corrected facts and ownership; do not send users misleading chat titles or assess team activity from a single automation run.

### Exit-criteria ledger — independent gates, not blended
- **W0 BLOCKED** until inventory's own Windows CI green AND QA reviewed-source preview remains green.
- **W1 BLOCKED** until real MariaDB rows shown in actual WPF EXE with photo and duplicate barcode semantics verified; no placeholder or unregistered host.
- **W2 BLOCKED** until persisted exactly-once authorized sale/return and rollback/reconciliation via WPF in disposable MariaDB.
- **W3 BLOCKED** until all V1 modules, PIN/security, reports, printer/labels, customers, suppliers, purchases and stock accepted feature by feature.
- **W4 BLOCKED** until installed x64 .NET10 offline WPF candidate, restore/rollback, local license and actual shop-hardware acceptance are signed off.

All five teams may advance nonblocked independent work in parallel. A passing legacy Windows build, portable core gate or WPF preview is valuable evidence but does not by itself close W1–W4.

---

## 0. Non-negotiable target / fixed decisions

C# / .NET 10 LTS / **WPF + MVVM** / Clean Architecture + Modular Monolith / Domain + Application + Infrastructure / **local MariaDB** / 100% offline / locally validated licensing without mandatory server. **WPF is decided**: do not reopen WinUI/Flutter/React selection; do not rebuild legacy WinForms as the new product. Preserve the known-good LOGICA behavior, local DB, barcode/photo/cart, sale/return/totals, suppliers/purchases, stock/counts, receipts/prints/labels, customers, reports, cashier permissions, local activation. Transitional `net48` WinForms exists ONLY as executable regression baseline until the new host passes field acceptance.

Do not change real shop DB or license state, bypass activation, merge to `main`/`release`, add competing QA integration branches, or fabricate progress percentages. User-facing release readiness remains **BLOCKED** until end-to-end acceptance. Tests on mocks/ports alone are not a completed UI migration.

## 1. Verified baseline as of 2026-11-04 00:18 Africa/Casablanca

| Track | Branch/PR exact head | Verified evidence | Open defect/dependency |
|---|---|---|---|
| 01 Architecture | PR #95 `a90272dc9a2fe6659fa1d71b62e4b233a81465ba` | Windows/.NET10/Core gates GREEN | `CheckoutBatchController` ports are not implemented against actual sale/cart or WPF |
| 02 Checkout | PR #75 `ab4cb3cd30d0d998339317506bc887aeccaab68e` | Windows/.NET10/Domain/Core GREEN | no proven WPF → full transactional checkout posting/return |
| 03 Inventory | PR #88 `e3f2e695b2ced53d287ed6a97fb474e49f61abbf` | Domain/.NET10/Core/Article GREEN | Windows build FAIL: `Form_2_ARTICLES.cs` resolves `Application.StartupPath` as `LOGICA.Application`; stock manual edit permission not yet authenticated at writer |
| 04 Desktop | WPF draft PR #96 `c64b4a2b7acf9870dc7745c12ff0393f9054b4ea` | legacy Windows/Core/portable gates GREEN on head | `MainWindow.xaml.cs` still constructs `new EmptyCatalogueReader()`; default selection `PreviewProductSelection`; NO production catalogue/checkout adapter |
| 05 QA | single PR #93 `0fb3322a322810340912a67b2a38d568c29b612e` | six legacy workflows GREEN incl Windows [41744215115](https://github.com/hmasprod-a11y/LOGICA-Recovery/actions/runs/41744215115) | WPF preview [41744206624](https://github.com/hmasprod-a11y/LOGICA-Recovery/actions/runs/41744206624) FAIL photo-only test; workflow pins OLD WPF `d98a05c`, not PR #96 head |
 
Do not assume these SHAs remain current; inspect the latest PR HEAD and exact-head CI **at the start of every cycle**.

## 2. Single engineering objective / explicit definition of done

**First real vertical slice:** start the .NET10 WPF EXE offline against **disposable local MariaDB** → load real catalogue (all products in list; photo tiles only if an actual image is available; barcode-free image products allowed) → scan barcode and explicitly choose duplicate variants → add real article to real cart once → compute original-equivalent unit price/tax/discount/rounding/totals (also return sign) → authorize cashier → commit exactly one sale and associated stock/payment/receipt atomically → query DB for persisted sale/stock → simulate failure and prove full rollback → restart and prove no duplicate transaction. **No fake/in-memory catalogue or mock checkout port may be substituted in the acceptance test.**

Exclude live store data. All destructive scenarios use temporary schema and disposable credentials. Do not ship until license, printing and physical peripheral tests separately pass.

## 3. Delivery Waves — strict critical path

### W0 — stabilize proof, do not scatter work (parallel Tracks 03+05)
- **QA [owner: #93]** pin reviewed **current** WPF #96 SHA in a two-source-provenance Windows test, not an old preview; re-run WPF MVVM, barcode/photo, executable startup, ZIP extraction with a single source pair and verify artifact digest. Keep old six legacy gates green. Explicitly reproduce photo-only test mismatch against latest production rules before editing assertions. Paths: `.github/workflows/qa-wpf-windows-preview.yml`, `scripts/verify-beta-rc.ps1`, QA-only tests. No WPF implementation edits.
- **Inventory [owner: #88]** fix the `Application.StartupPath` namespace collision with fully qualified `System.Windows.Forms.Application.StartupPath` (or equivalent targeted alias) in owned affected form references, preserving exact paths; add a build/source regression to catch collision; run Windows build. Do **not** refactor catalogue or change SQL as a workaround. Coordinate any shared `Form_2_ARTICLES.cs` edits with Track04 and QA.
- **Gate W0:** QA same-sha Windows WPF test + six old gates GREEN, Inventory Windows GREEN, no merged changes to main/release. If any gate fails, attach exact job, step, reproducible lines and fix *that* cause.

### W1 — build real WPF catalogue vertical slice (parallel preparatory work, one approved contract)
- **Architecture [owner: #95]** author/version the one shared interfaces/data contracts: `ICatalogueReader` / article DTO with stable ID, name, barcode, photo path/availability, variant identity, and a single `ICheckoutArticlePort`/`IAtomicCheckoutBatchPort` composition model. Prove .NET10 compile, no WinForms/MySQL dependencies in Application/WPF. Provide registration/composition root design; no new duplicate catalogue abstractions.
- **Inventory [owner: #88]** implement actual catalogue **Application-facing reader + Infrastructure MariaDB adapter** satisfying the approved contract. Legacy schema-compatible, parameterized, read-only, stable article identity, barcode NULL/empty distinctions, actual photo availability. Isolated MariaDB fixtures: zero rows, barcode-free item, duplicate barcodes, no-image, corrupt identity, connection failure. No SQL in WPF.
- **Desktop [owner: #96]** consume approved catalogue reader in real `MainWindow` composition; **remove** `new EmptyCatalogueReader()` from production host (retain only as test fixture if helpful). Ensure MVVM binding, reload, scanner, list/image filter, duplicate choice, RTL/DPI and keyboard events. WinForms does not get new features here.
- **QA:** WPF executable with isolated MariaDB reads **real rows**; verify all product rows and photo-only tiles; stop if still an empty placeholder.
- **Gate W1:** WPF launches with offline MariaDB and real product list/images on exact same source set; fail-closed errors; tests inspect persisted DB seed and UI result. No checkout claims yet.

### W2 — real cart and transactional checkout path (parallel Track02 implementation and Track04 UI; review interfaces first)
- **Checkout [owner: #75]** implement the **real** approved port backed by production Checkout services and MariaDB transaction, support stable line identity, duplicate-variant selection, line quantity updates, price/tax/discount/rounding, signed returns and payment. Idempotency key / no blind retries; rollback on stock, payment, receipt and persistence failure. Existing posted services are to be reused, not rewritten into a disconnected prototype. Exact legacy sale/return amount parity tests with edge cases.
- **Architecture [owner: #95]** integrate existing `CheckoutBatchController` with reviewed application port and DI without duplicating Checkout business rules. Verify atomic batch staging, concurrency and no stale article acceptance.
- **Desktop [owner: #96]** WPF ViewModel commands call **real** port for add-to-cart/update/delete/complete sale; remove `PreviewProductSelection` from production path; do not calculate money in XAML or ViewModel.
- **Inventory:** provide stock write authorization/identity and transaction contract, coordinate Checkout ownership to avoid double decrement.
- **QA:** end-to-end WPF click/scan → cart → completion → SQL persisted record exactly once; injectable failures prove rollback. Then sale return parity.
- **Gate W2:** exact real .NET10 Windows EXE + isolated MariaDB tests for sale, return, duplicate barcode, photo item and repeated confirmation. No test doubles for persistence, and no WPF checkout placeholder.

### W3 — preserve every V1 business function + security/peripherals
- **Inventory:** unauthorized **manual stock edit** must fail at write boundary even if the UI setting is manipulated; enforce configured policy **AND verified actor permission**, with safe failure on unknown actor, duplicate product identity and stale stock. Exercise MariaDB simultaneous writes, negative stock policy, audit-before/after reason/user and full rollback. Supplier receipts, purchases and stock count parity.
- **Desktop:** catalogue create/edit with optional `PRIX_QTE`/`QTE_MIN`, refunds, clients/suppliers, cash drawer, keyboard, DPI, Arabic/French/RTL, touch; no loss from LOGICA.
- **QA:** feature ledger baseline→WPF real coverage for articles, barcode and photos, sales/returns, payments, customers, suppliers, inventory/count, purchases/receipts, reports, tickets, printer and labels, cash, permissions, offline licensing. Distinguish software smoke vs physical printer/scanner/label testing.
- **Gate W3:** V1 feature-by-feature acceptance, restored DB backup and rollback, security and permissions, no P0/P1 defect.

### W4 — signed-off Windows beta release
- QA ONLY integrates reviewed green commits into existing PR #93, never force-merges stacked #91/#92. Publish x64 .NET10 WPF customer candidate + manifest/hash + offline bootstrap + isolated schema/backup recovery and field validation checklist. Test hardware and offline local licensing with actual authorized cashier. Preserve verified old WinForms package as rollback reference until new candidate accepted.
- **Gate W4:** actual human authorized PIN/cashier login and print/label/peripheral checks, offline startup, safe update and rollback, no open P0/P1. Commercial release is blocked until then.

## 4. Owned files and contract handoff

| Track | Can edit without cross-owner approval | Must coordinate |
|---|---|---|
| 01 Architecture | `modernization/architecture/**`, architecture docs/contracts in owned namespace | all shared interfaces and DI composition |
| 02 Checkout | `recovered-source/LOGICA/Application/Checkout/**`, `Domain` checkout owned source, checkout regression projects | WPF composition and stock posting |
| 03 Inventory | `Application/Catalogue/**`, `Infrastructure/Inventory/**`, owned stock/catalogue tests | shared `Form_2_ARTICLES.cs` and checkout stock posting |
| 04 Desktop | `modernization/Hanouty.Desktop.Wpf/**`, WPF executable tests | Application DTO/ports and shared legacy form |
| 05 QA | `scripts/verify-*`, QA-specific Windows/MariaDB tests, WPF preview workflow, integration branch | cherry-picks of any team source |

Contracts first: Architect posts exactly one DTO+API contract to Issue #94, Checkout/Inventory/Desktop acknowledge field semantics and ownership, then each writes its side; QA tests exact combined SHAs. Avoid serial waiting for unrelated work: each team has tests/fixtures to create in parallel.

## 5. Delivery accountability — every hourly cycle

Each track must implement a **substantial coherent batch** of production code and its associated relevant tests (or QA's real CI/packaging acceptance) before counting progress. A comment, audit, plan, green CI from prior SHA, or unused stub is NOT a delivery. State:
1. latest baseline SHA, owned file changes, exact PR/commit;
2. what **real production call site** moved and what legacy/placeholder path was removed;
3. new failing-before/passing-after regression including exact workflow run URL;
4. reproducible blocker (if any) and next independently executable batch;
5. no live DB or activation modifications.

Only supervisor sends cross-team summary. No branch merges to main/release without user request. GitHub Actions and team automations can run hourly, but status must not imply continuous workers or completed tasks without commits.

## 6. Progress measurement and irreversible safety rules

Track **three different denominators**: (a) **architecture** = number of inventoried original business production call sites demonstrably invoked through .NET10 WPF + removed legacy dependency; (b) **functional** = V1 features accepted end-to-end on real new host, not mocks; (c) **release** = completed exact-SHA platform/device/license/data/rollback gates. If missing inventories, report "not measurable yet", not an invented percentage.

Do not weaken tests to turn CI green; reproduce/fix the production issue or an erroneous fixture with evidence. No auto DB migrations, no fake credentials, no force merge, no P0 bypass, no hidden background execution promises. The contract is complete only when the user can operate the original business workflows safely on the new Windows host.
