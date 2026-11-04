# HANOUTY POS V2.0 — EXECUTION CONTRACT V3 / DELIVERY WAVES
**Effective:** 2026-11-04  
**Repository:** `hmasprod-a11y/LOGICA-Recovery`  
**Authority:** user-directed correction to execution, complementary to `docs/HANOUTY_MASTER_MODERNIZATION_V2.md` (PR #95) and functional LOGICA V1 (2026-10-29). If older instructions contradict the user's **final technology decision**, this contract wins for technical architecture, never for functional parity.  
**Status:** development contract on Architecture PR #95; not a commercial release approval.


## 2026-11-04 — One contextual WPF adapter in the existing financial Host

Architecture integrated WPF44ad5d84bd99308de9947269399dbf0a4bb647d3 into QA9448e50936a12fc768c0a05cdfe7abdfa14aa0bd. Existing CatalogueHost.CreateFinancial now calls AuthorizedWpfServiceRegistration.CreateSessionBound with the SAME catalogue, selection, financial submission and captured cash expectation. Removed the Host's private FinancialSessionSubmission duplicate (22 fewer lines); no new gate/session/DTO/Host.

The actual rendered acceptance now edits cashier, workstation, currency, amount and Card tender through CatalogueViewModel.PaymentContext/CommitCommand. It requires Invalidated with ZERO SQL changes, preserves the SAME pending selection and operation ID, restores the captured context after deterministic local rejection and commits once. This is runtime UI-to-production composition testing, not a mock port. Existing real SQL/payment rollback/process restart/Unknown/lost-ack assertions are retained; the workflow independently checks EditedContextRejected and SingleSessionBinding evidence.

Exact source set: QA9448e50936a12fc768c0a05cdfe7abdfa14aa0bd, WPF44ad5d84bd99308de9947269399dbf0a4bb647d3, Checkout e9d630d8adb9fb11f22cf08a96d05dcfbdcb9725, Architecture production5c73e78002f07121fdc85eb6272dcbd1bae5b31f. [Run41928626489](https://github.com/hmasprod-a11y/LOGICA-Recovery/actions/runs/41928626489) is SUCCESS on both Windows126919538177 and Ubuntu126919538656. Artifact13370487843 was downloaded and independently inspected: exact source manifest matches this set; EditedContextRejected=true and SingleSessionBinding=true alongside all real SQL/rollback/restart/Unknown/lost-ack assertions, W2Accepted=false.

The prior accepted QA56730439 now has all twelve distinct workflows successful, including legacy Windows41921580565 and real cash-slice41921571910. Checkoute9d630d8 has all FIVE distinct gates successful incl Windows41921575283/MariaDB41921574744. These older successes do not accept a new WPF pin automatically.

**Next remains WPF actual PIN/session/tender UI and an explicit reviewed reset after verified Persisted/Absent.** The new wrapper is NOT that UI and does not authenticate a user label. SQL preparation remains the sole authorization/pricing authority. Unknown stays locked; no automatic retry or default commercial financial entry. Inventory4e8f03ef still has no actor-scoped manual stock permission delivery. Actual Form_1_LOGIN.cs on that branch lines2102–2110 proves parameterized TABLE_PASS credential lookup and Module1 username/category; this does not establish a manual-stock grant. W2Accepted=false, W3/V1 parity and W4 gates remain open; no invented percentages.

## 2026-11-04 — Real rendered WPF cash-sale executable and Windows mapping correction

This supersedes the prior "combined executable absent" blocker. QA owns the one integration candidate; no end-user payment rollout is authorized.

- QA's initial runner2b754805 failed actual execution41914154405 because no local connection/database was configured. Supervisor completed the existing DisposableCashSaleAcceptance and workflow rather than adding another Host.
- The executable uses checksum-verified disposable MariaDB127.0.0.1:3307/logica_ci, creates EMPTY TABLE_01 and no financial rows, seeds only catalogue/credentials/sequence/operation ledger, shows the actual MainWindow, scans the authoritative article and calls the real ViewModel.CommitCommand.
- It asserts persisted ticket/detail/payment/stock/movement/sequence, same-ID duplicate, NEW EXE process restart without duplicate writes, wrong PIN/expected total/changed price denial, complete rollback after a real payment-insert trigger, Unknown journal lock, and persisted reconciliation after a fault injected ONLY AFTER the real production posting port commits. The fault seam is internal to the financial Host acceptance; it cannot replace real posting or writers. Default catalogue-only startup remains read-only.
- First rendered acceptance found a real production Windows failure: run41921055027 job126893357929, MariaDbCashCheckoutPreparation line68, DataRow column 'Catégorie' not found after credential query. Checkout e9d630d8adb9fb11f22cf08a96d05dcfbdcb9725 maps original legacy SQL identifiers through stable ASCII trusted_cashier/trusted_role/trusted_quantity aliases. No schema migration, role/PIN policy change or fallback grant.
- Exact new sources: QA5673043907c2eca7e74f0389d54364b888ee999e, Checkout e9d630d8adb9fb11f22cf08a96d05dcfbdcb9725, Architecture production5c73e78002f07121fdc85eb6272dcbd1bae5b31f, WPF0f8869220484100a0cbab18e768c8cf8160da6af. QA [run41921571910](https://github.com/hmasprod-a11y/LOGICA-Recovery/actions/runs/41921571910) is SUCCESS in BOTH jobs: Windows126895112260 executes the real rendered WPF cash slice and independently checks every report assertion, Ubuntu126895111630 executes real production financial SQL. The generated report records W2Accepted=false explicitly. Checkout same-SHA MariaDB41921574744 is SUCCESS; its four non-Windows distinct branch checks passed while final legacy net48 Windows41921575283 was still running at this checkpoint. The QA modern financial Windows result is complete; do not conflate it with unfinished legacy packaging.
- The older WPF claim that the financial Host lacks a contextual adapter was disproved by source: existing FinancialSessionSubmission wraps the SAME session/binding and implements both IContextualCheckoutSubmission and ICheckoutOutcomeReconciliation. Do not add a parallel session/adapter to solve that stale diagnosis.
- Earlier pending legacy Windows gates41911457416 and41911100941 are now SUCCESS. They do not establish acceptance of this new executable.

**Still open:** actual user PIN/session UI and an explicit cashier-reviewed reset after verified Absent/Persisted (Unknown must remain locked), broader V1 money/tender/returns/promotion/customer parity, manual-stock actor authorization, devices/printing/install/backup/restore/license/offline. Cash-slice evidence explicitly retains W2Accepted=false; do not promote it to all W2/V1/release. No percentage without counted inventories.

## 2026-11-04 — Empty-basket staging and actual financial Host composition

This checkpoint supersedes the existing-basket restriction in older progress snapshots below; it does not expand accepted V1 pricing or enable cashier rollout.

- Checkout `f87aada22d596838100e50c23e51a79f640b4ad4`: all FIVE distinct gates SUCCESS, actual MariaDB [41910634229](https://github.com/hmasprod-a11y/LOGICA-Recovery/actions/runs/41910634229), Windows [41910634249](https://github.com/hmasprod-a11y/LOGICA-Recovery/actions/runs/41910634249). The owner implemented staging request.Lines from authoritative article rows inside the existing transaction on fc630cc1. Supervisor fixed the obsolete preseeded-cart acceptance: real cash tests now start EMPTY; occupied cart refusal is tested separately, including retained contents; staged first line rolls back when a second article is absent; real after-payment rollback/auth/price/duplicate/culture checks pass. No permission to overwrite an existing basket.
- Existing QA Bootstrap now contains `CatalogueHost.CreateFinancial(settings, twoDigitWorkstation, transientPinProvider, AuthorizedCheckoutPaymentContext)`. It constructs the REAL Checkout public posting/journal factories, existing ProductionWpfServices.CreateFinancial, and the SAME MainWindow with contextual cash submission. Tender context is frozen; altered UI context is rejected. PIN stays solely in the transient Checkout callback; SQL remains the price/authorization authority. Financial source is compiled only when explicit CheckoutProductionProject is supplied; catalogue-only default remains read-only, no commercial payment entry enabled.
- Architecture `5c73e78002f07121fdc85eb6272dcbd1bae5b31f` fixes a concrete hidden lock: reconciliation now resolves BOTH AuthorizedCheckoutCommitGate and CheckoutSession through the existing production submission. Unknown/wrong operation IDs keep the lock. Adapter regressions prove persisted and absent lost acknowledgements can be reviewed and followed by a new operation without the old gate remaining poisoned. These controlled-port tests are NOT SQL financial acceptance.
- QA `3c786bf14dca9452176b40515ebccc7d7385db24`, Windows job [41911198842](https://github.com/hmasprod-a11y/LOGICA-Recovery/actions/runs/41911198842): actual Checkout library, WPF ffd5fb3a and financial Host build SUCCESS; full WPF suite and Architecture adapter regressions SUCCESS. Its final E2E step deliberately FAILS with QA_OWNER W2_NOT_ACCEPTED because no executable combined SQL runner exists. Do not call this overall workflow green.
- QA followup `43fb2a7d2ab778016d2285a2dd7f4f856d40cf15` adds missing disposable InnoDB ledger initialization using the reviewed Checkout fixture; this fixes the separate Ubuntu runner setup failure, not an application ledger bypass. Exact run [41911445934](https://github.com/hmasprod-a11y/LOGICA-Recovery/actions/runs/41911445934), Ubuntu job126859760726, is SUCCESS including actual production financial SQL. Its Windows E2E gate remains independently unaccepted.
- WPF ffd5fb3ae186bebab97ad5f989c70d1b301c528b is now compiled and actually tested in this composed graph. Branch legacy checks alone remain insufficient. PR97 6d34e061 remains the earlier catalogue-only source, not this financial composition.
- Inventory remains 4e8f03ef: no new production permission batch in its latest completed cycle. Manual stock configured AND actor-verified permission/audit/concurrency/rollback remain OPEN; sale authorization is not manual-stock permission.

**Next accountable output: QA93 executable runner**, referencing the existing Host and its real CreateFinancial, starts with EMPTY basket, invokes actual WPF selection/CommitCommand and reads header/detail/payment/stock/movement/operation SQL; then duplicate/restart, precommit rollback, wrong PIN/total and Unknown/reconciliation. WPF owns real transient PIN/session entry and safe UI recovery after reviewed rejection/rollback. No new Host/Gate/DTO or test-preparation substitute. W0/W1 remain accepted only on documented source sets; W2 combined acceptance, W3/V1 parity and W4 release/device/offline/license remain open. Percentages are unmeasurable without counted acceptance inventories.

## 2026-11-04 — Real cashier/price preparation delivered (current checkpoint)

QA #93 `58c7d80ef8c010302b2e8208bc03d3516be248bc` now has **ten distinct successful gates**, including Windows41876268261, actual W1 Host41876268549 and WPF41876268381. Do not reopen previous W1 source/provenance failures. WPF current21439705 adds ViewModel-to-authorized-gate regressions; legacy branch checks alone do not execute that new WPF test source until QA updates its pin.

Supervisor delivered Checkout #75 `3126509d26927a8609d2f94d1b0136260887f052` as one cohesive production batch:
- Concrete `MariaDbCashCheckoutPreparation` authenticates the existing TABLE_PASS PIN, exact cashier and original sales category using parameters within the actual posting transaction.
- Locks the original sequence, existing workstation basket and authoritative article rows; verifies requested identity/quantity, price/cost/tax, line total and exact cash tender. No UI price or caller-supplied user label is accepted as authority.
- Real `Hanouty.Checkout.MariaDb` net10 production library exports the **existing** Architecture posting and journal interfaces through `MariaDbCashCheckoutServices.CreatePostingPort` / `CreateOperationJournal`. It has explicit local connections and transient PIN provider; no automatic registration or default credential. The financial acceptance executable references this production library, not duplicated replacement source.
- Parameterized actual header/payment/journal writer values, preserving record mapping and VB conversion; original SQL characterization builders remain unchanged. Existing Windows project is preserved.
- Actual DB tests (not preparation fixtures) cover invalid/injection-shaped PIN, wrong cashier/category, stale price, underpayment, unsupported policy, remote endpoint, nontransactional table, failure after real payment insertion with full rollback, quoted names and exact fr-FR/en-US persistence/replay. MariaDB41881911922 and same-SHA Windows41881912322 **SUCCESS**.

Follow-up `43d2c363f5fef635609488060e0d84e22d3b5851` verifies the operation ledger is InnoDB **before** claim insertion and before reporting Persisted; a misconfigured nontransactional ledger must produce rejection/Unknown, never a durable false success. Actual MariaDB41882640469 and same-SHA Windows41882641284 **SUCCESS**; all five distinct Checkout gates accepted. QA57b27d58 independently passed real preparation41883653894, latest WPF21439705 suite41883672790 and actual W1 Host41883672703; its final legacy Windows41883672687 was finishing extracted ZIP smoke at this checkpoint. Keep W2=false until combined WPF financial acceptance.

**Scope is deliberately explicit:** anonymous MAD exact-cash standard-price sale over an existing validated basket. Promotion/tier/manual-discount, returns, change, named customer, additional sequence layouts and physical printing remain unaccepted for this new slice; their characterized legacy paths are preserved. No live schema migration.

**Remaining W2 critical path has changed:** trusted preparation code now EXISTS and is exercised with real credential/price tables. The next implementation is safe authoritative staging of WPF's in-memory cart into the workstation transaction, actual PIN/session UI and production composition registration with the real library, then combined WPF -> authorization -> persisted sale/payment/stock/journal, rollback/restart/unknown acceptance. Do not keep ordering another abstract preparation contract or claim a preexisting basket makes WPF end-to-end complete. Payment stays disabled until that combined acceptance.

Inventory actor-scoped manual-stock permission remains separate and unimplemented; a sale-role grant is not manual-stock authorization. W3/V1 parity and W4 installation/device/license/backup/offline gates remain unaccepted. No main/release, customer DB or licensing changes.

## 2026-11-04 — Verified financial execution and current integration checkpoint

- **Checkout #75 `2bcdc8c17b81b6391bd4afce3c0aa76a9370337b`: five distinct gates SUCCESS**, Windows 41872754790 and real MariaDB 41872754878 included. Actual `AuthorizedCheckoutMariaDbPort` is compiled and invoked in direct transaction tests: preparation receives active transaction; uncommitted operation invisible to another connection; real financial writers persist; duplicate skips preparation; denied preparation rolls back operation claim and business state. The preparation used by these tests is explicitly controlled fixture code, **not production cashier authentication**.
- Prior full production writer acceptance `995dc7fe`, run41862992819, is **SUCCESS**, no longer queued. Latest Checkout owner moved preparation into transaction on `287c450c`; its exact financial gate41865031946 also passed.
- Supervisor's three-file financial harness reservation is released; communicate edits through Issue94.
- WPF #96 `da75499e` adds the real authorized-envelope/financial-gate adapter and controlled regressions. Its three legacy gates passed but did not execute this WPF project. QA preview41873098419 exposed missing Architecture project (`MSB9008`); current QA `9a04ce6f` composes exact WPF da75499e + Architecture88c8c498 and linked production sources in an isolated workspace. **Do not present legacy green checks as acceptance of this WPF graph.**
- QA actual Host initially failed before execution due reserved PowerShell `$Host` and incorrect doubled checkout path. Supervisor fixed these in9568f8d. The real Host then executed successfully, but independent provenance verification failed on Windows line endings. My first CRLF edit introduced a parser error; corrected in7e458b4b, with mandatory early parser + LF/CRLF positive + wrong-SHA negative regressions. Latest actual-host and current WPF adapter runs must finish before final QA W1 claim.
- Inventory remains at4e8f03ef, green but no new commit in its latest cycle. Actor-scoped manual-stock authorization is unresolved. Failure to find code in default-branch search is not proof the source is absent: inspect the owned branch login and permissions code; never equate a caller-supplied UserId with authentication.
- **Still blocking W2:** concrete trusted cashier/authoritative-price preparation and actual WPF financial production registration, followed by combined authorized sale/restart/unknown acceptance. W3/V1 parity and W4 field/release gates remain blocked. No main/release, shop data or licensing changes.

## 2026-11-04 — Immediate delivery correction (supersedes stale status snapshots below)

**Execution:** Supervisor now also owns Architecture PR #95 in the current hourly supervision conversation; the previous standalone Architecture schedule is paused to avoid duplicate ownership. Checkout, Inventory, WPF and QA remain separate. All V1 scope and safety constraints remain binding.

**Verified:** QA #93 `906b166c0c48202e510eb3f28b3e80d1ad0759e4` has nine distinct successful gates including Windows 41860145234, WPF 41860145356, Adapter 41860145089 and real MariaDB 41860145241. WPF source `c84760ab` corrects empty-catalogue versus unavailable-reader assertions and preserves nested scanner input locking. Do not reopen resolved namespace collisions, ten legacy timeouts or this WPF fixture failure without new evidence. PR #97 `6d34e061` separately proves actual WPF/MariaDB host acceptance; QA must incorporate its reviewed source graph and preserve acknowledged-duplicate scanner reset before claiming unified W1.

**Concrete W2 blind spot found and changed:** Checkout #75 `995dc7fe08debc8cc3212eb21ebea8eab803a3c5` replaces empty posting-store/record substitutes in the existing MariaDB harness with 22 real production sources and compiles `AuthorizedCheckoutMariaDbPort` in net10 against pinned Architecture `f934763e`. It adds actual ticket/journal/cash payment/stock/movement/completion DB readback, durable duplicate replay, injected failure after payment and complete rollback, then retry after verified rollback. Run **41862992819 was queued at intervention checkpoint**; this change is NOT accepted until its actual compilation and database assertions pass. A test project compiling a port is not production WPF registration.

**Critical path, with one accountable owner per output:**
1. Supervisor completes/reviews the new real financial harness result and fixes failures, then releases the reserved three test/workflow files in Issue #94.
2. Checkout implements trusted cashier and authoritative pricing preparation using existing authenticated permission state, V1 pricing and existing financial writers; maintain one shared transaction and durable journal. Do not replace this with another DTO/gate or a test preparation fixture.
3. WPF maps the actual contextual command to the existing authorized envelope/gate and production posting adapter, preserving Unknown lock. Payment stays disabled until trusted posting acceptance.
4. QA validates the exact combined graph: WPF command -> authorized sale -> persisted ticket/payment/stock/journal -> duplicate/rollback/restart/unknown reconciliation. Reader-only and fixture-backed posting are not W2.
5. Inventory, current `4e8f03ef`, implements actor-scoped manual adjustment authorization, audit/concurrency/rollback independently; never invoke its separate manual adjustment transaction within Checkout.

**Follow-through:** updated active team automation prompts enforce these immediate tasks. `run_now` returned an inline prompt in the supervisor conversation, not a background worker; do not claim an independent wake or continuous worker. No status-only cycle counts as a production batch. Inspect latest HEAD and completed exact-SHA CI, fix the actual next failure, and advance independent owned code while CI waits. Missing root AGENTS.md (404) alone is not a development blocker. Scheduling remains hourly; actual execution depends on task and runner availability.

W2, W3 and W4 remain unaccepted. No main/release merge, commercial release, shop DB or licensing changes. Progress percentages remain unmeasurable without a counted V1/callsite ledger.

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
