# HANOUTY POS V2.0 — Binding Technical & Architectural Specification
**Version:** V2.0 — 2026-11-03  
**Authority:** [Master coordination Issue #94](https://github.com/hmasprod-a11y/LOGICA-Recovery/issues/94)  
**Functional specification retained:** V1 dated 2026-10-29. This document does **not** weaken, override, or delete original LOGICA functionality.

## 1. Product goal and non-negotiable constraint

LOGICA was a functioning, mature, offline Windows point-of-sale product. Hanouty modernization must retain that proven behavior while removing barriers to maintainability, testability, portability and long-term evolution. **A Windows build that compiles, a refactor into new files, and the number of commits are not modernization outcomes.**

The intended outcome is a modern **C# / .NET 10 LTS production application**, with clearly separated domain, application, infrastructure, and desktop layers, and parity against the original executable and database workflows. Retain **offline-first** and the existing local shop data model while migration is safely evaluated. Do not introduce cloud/service licensing requirements.

## 2. Grounded baseline at publication

The current Windows application project `recovered-source/LOGICA.csproj` explicitly targets `net48`, `x86`, and WinForms. It declares `LangVersion=14.0`, which does **not** upgrade its runtime. Legacy semantics remain, e.g. `Infrastructure/Compatibility/VisualBasicCatalogueSemantics.cs` references `Microsoft.VisualBasic` and `Microsoft.VisualBasic.CompilerServices`.

The shared core project `modernization/LOGICA.CoreCompatibility.csproj` targets `netstandard2.0;net10.0`, imports `CoreSources.props` and already compiles some production checkout/application/domain sources. This is a useful transition but **not** proof that the Windows EXE runs on .NET 10 or that its real event handlers use every extracted service.

Do not treat these as full-dependency audit results; independently inventory every binary, custom DLL, RDLC/reporting component, printer and barcode device integration before a Windows host migration.

## 3. Technology policy

| Layer | Final target | Temporary compatibility |
| --- | --- | --- |
| Language | C#, version supported by selected SDK/TFM | Legacy VB runtime semantics behind tested compatibility adapters |
| Windows runtime | Supported .NET 10 Windows Desktop target | `net48` and `x86` only as documented bridge |
| Domain | Pure money/discount/tax/rounding/identity/permissions/stock rules | Behavior-preserving facades |
| Application | Production-used checkout, catalogue, stock, receiving, payments and returns use cases; transaction orchestration | Incrementally wired WinForms actions |
| Infrastructure | Parameterized MariaDB/MySQL, storage, peripheral devices, reports, offline licensing | Schema adapters and narrowly scoped old provider compatibility |
| Desktop | **WPF on .NET 10 with MVVM**, UI-only input, navigation and presentation | Existing WinForms retained strictly as a tested temporary compatibility bridge; no new features or cosmetic investment |
| Tests | Unit + Windows event + isolated MariaDB + full workflow + ZIP/executable acceptance | Characterization of unchanged LOGICA behavior |

**Final owner decision (2026-11-03): WPF + MVVM on .NET 10 LTS is selected for the Windows host.** Do not reopen WinForms/WinUI 3/Electron/Flutter selection without a new explicit owner decision. Compatibility experiments for **printer, RDLC/report, barcode, native/x86 DLLs, offline licensing, memory, startup latency, touch/DPI/RTL** are acceptance gates for safe rollout, **not a reason to delay starting WPF production development**. Do **not** rewrite the product, switch programming language, rewrite the live DB schema, invest in WinForms cosmetics or add new business SQL/financial computations in old event handlers.

## 4. Architecture contract

- **Domain:** decimal money, rounding, discounts, taxes, stock eligibility, product identity and transaction invariants. No WinForms, MySQL or file IO references.
- **Application:** authorization, idempotency, checkout/return/catalogue/receipt/stock use cases and clear interfaces for persistence; actual call sites must consume these services.
- **Infrastructure:** legacy schema mapping, parameterized SQL, strict transaction boundaries, printing, images, licensing and locally stored configuration.
- **Desktop:** the new **WPF/MVVM .NET 10** host captures events and exposes observable state, calling Application use cases; no SQL or commercial rules in Views/ViewModels. Existing WinForms SQL/cash/stock business branches must progressively shrink until removed.
- **Test & release:** characterization, fault injection, real Windows events, recovery, rollback, offline startup and reproducible customer ZIP verification.

**A migrated feature requires a real production call site, functional equivalence tests, and an identified legacy call path removed or bypassed.** Merely adding portable code or a new helper is insufficient.

## 5. Mandatory migration and compatibility controls

1. Keep the legacy behavior as a golden baseline and test it before removing code. Record inputs/outputs for amount, discount, tax, rounding, barcode, return, stock and reporting decisions.
2. Replace VB `Conversions`, `Operators`, `Interaction`, `Strings` and hidden numeric conversions only after financial cross-culture and edge-case parity tests (not by bulk text substitution).
3. Keep SQL naming/encoding irregularities (`Qté`, `QtÃ©`, `QtÃƒÂ©`) at the infrastructure boundary; application and UI must use canonical typed fields. No automatic live-shop ALTER or silent deduplication.
4. For sale, return, purchase and manual stock changes enforce atomicity, fail-closed authorization, idempotency, concurrent-write safety, and tested rollback on isolated MariaDB.
5. Preserve all-products list, image-only tiles with actual photos, barcode including barcode-free image items, cash register/printing, labels, original reports, offline login and activation.
6. Before replacing the net48 host, audit native/x86-only libraries, Windows Forms dependencies, vendor licensing, RDLC reports, printer SDKs and installer behavior. Migrate by measured proof, not a deadline-only switch.
7. No production DB writes, no forced merge of stacked/conflicting PRs, no direct main/release merge by automations.

## 6. Three independent progress measures (never substitute one for another)

**Architecture migration:** measured from an inventoried denominator of real production call sites and dependencies. Each counted move needs a verified modern implementation **and** a wired original UI/workflow call site. Additionally track remaining VB-runtime usage, SQL-in-forms occurrences, x86-only dependencies, and whether the *Windows host itself* runs on .NET 10. A dual-targeted class library is partial progress only.

**Functional parity:** original behavior ledger; number of workflows backed by baseline characterization, integration tests and actual Windows event acceptance, divided by the total inventoried original workflows. Tests of isolated mock services alone do not count as end-to-end parity.

**Release readiness:** a gated matrix of live cashier login/licensing, actual checkout/return exactly-once, product create/edit with optional quantity-tier prices, inventory permissions, peripheral printing, DB migration/backup restore, updater/rollback, offline start, and packaged Windows x86/x64 compatibility. CI green is not equivalent to field acceptance.

**If a denominator is unknown, report “not measurable yet”.** Never substitute a subjective 70% figure or commit count for a measured migration percentage.

## 7. Required legacy feature ledger

Create and maintain a table with one row per baseline behavior: sales and returns; barcodes and barcode-free photos; product/variants; pricing and discounts; stock, manual adjustments, counts; purchasing and receiving; supplier and customer operations; invoices/tickets; printing and labels; cash/cashier management; reports; permissions; activation/offline license.

For every row record:
`legacy handler`, `baseline evidence`, `modern owner and implementation`, `actual UI call-site`, `dependencies removed`, `isolated MariaDB or peripheral acceptance`, `exact SHA`, `release state`.

Any function previously working in LOGICA that regresses during modernization is a **defect**, not a newly completed feature.

## 8. Phased engineering deliverables

- **A — Freeze characterization:** inventory production call sites, legacy data and device dependencies; immutable reference build and regression fixtures.
- **B — Portable production core:** transfer real business use cases to .NET 10 and prove the old Windows screen invokes them; preserve numerical equivalence.
- **C — Reliable infrastructure:** schema mapping, authorization and transaction policies, atomic sale/return/stock, restore/migration tests.
- **D — WPF runtime transition:** start a production-oriented .NET 10 WPF/MVVM host immediately, with actual Application-connected checkout/catalogue paths and dependency inventory; printer/report/device/offline-license acceptance gates safe rollout, then remove net48/x86 dependency when proven safe.
- **E — WPF functional migration:** migrate screens by complete user workflows and measurable V1 parity, without duplicating business logic or investing in WinForms visual redesign.
- **F — Commercial acceptance:** offline license, installer, rollback, all original functions and peripherals, reproducible builds, zero P0/P1 bugs.

Phases may overlap but are **not complete** until their acceptance outcomes are demonstrated.

## 9. Team ownership, cycle output and stop conditions

- **01 Supervision + architecture (PR #95):** own architecture measurement and portability boundary; audit team output and assign nonoverlapping work. Must also contribute reviewed production architecture improvements/tests.
- **02 Checkout Core (PR #75):** real production pricing/selection/payment/return call-site migrations and financial regression parity; coordinate Form edits with Desktop owner.
- **03 Inventory (PR #88):** product identity, transaction-backed stock/receiving, permission-denied manual stock adjustment, rollback and MariaDB concurrency evidence.
- **04 WPF Desktop (PR #90):** own new .NET 10 WPF/MVVM Windows host and actual Application-connected checkout/catalogue UI, search/barcode/list/image/DPI/RTL; retain only minimal temporary WinForms bridges needed for safe functional/device parity. No WinForms cosmetics.
- **05 QA (PR #93):** only integration branch owner, exact-SHA six gates, isolated MariaDB and extracted Windows EXE tests, field-acceptance matrix, trusted ZIP.

**Each development cycle is a LARGE, COHESIVE PRODUCTION BATCH**: claim several connected changes forming an actual end-to-end workflow, migrate business logic and wire the real call site, remove or isolate a measured legacy dependency, add focused grouped characterization/regression/integration tests, run relevant exact-SHA CI, publish SHA and link plus next substantial batch. Do not turn each tiny test, guard, report, or audit into its own cycle. If blocked, document a precise reproducible blocker and deliver a separate unblocked production batch; no report-only cycles. Team boundaries and contracts are coordinated through Issue #94.

**Release is BLOCKED** on unresolved critical stock permission bypass, real checkout/idempotency failure, unverified data safety, unproven offline licensing/cashier flow or broken printing. Preserve original functionality rather than masking failures with changed tests.

## 10. Acceptance checklist for future claims

- [ ] Functional baseline and feature inventory published with real denominators.
- [ ] Same production use case compiled and tested in modern core and called by Windows UI.
- [ ] Financial, stock and legacy DB schema parity proven for that migrated use case.
- [ ] Explicit reduction in forms/legacy dependencies measured and reviewed.
- [ ] Actual Windows exe and ZIP tested on the exact integration SHA.
- [ ] No P0/P1 regression and manual stock permission bypass resolved.
- [ ] No alteration of real shops' databases or unsupported activation policy changes.

**Guiding principle:** Keep what worked in LOGICA. Modernize the runtime, architecture, tests and user experience — not the bugs.

## 11. Binding executive synchronization — 2026-11-03

This section supersedes earlier conditional UI-selection language. The owner's final choice is **C# / .NET 10 LTS / WPF / MVVM / Clean Architecture / Modular Monolith / Domain-Application-Infrastructure / local MariaDB / fully offline / local licensing without mandatory server**. Preserve V1 functionality. Track ownership: #95 Architecture; #75 Checkout; #88 Inventory; #90 WPF Desktop; #93 sole QA Integration. No new WinForms/net48/VB.NET features, no cosmetic modernization of legacy UI, no alternative UI stack without owner approval, no automatic main/release merge, and no tests against real shop databases. All tracks must deliver large real-production batches with focused grouped tests, actual call-site proof, removed legacy coupling, exact-SHA CI, and reproducible blockers. A passing CI or audit-only commit does not establish architecture migration or release readiness.
