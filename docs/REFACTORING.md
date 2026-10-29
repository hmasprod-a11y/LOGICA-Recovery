# LOGICA: preserve behavior, then improve structure

## Priority agreed with the owner (2026-10-29)

LOGICA is the primary product and the owner reports that it works well. The first objective is to organize its code incrementally while preserving existing behavior. TODO POS is an optional reference for selected ideas, not the implementation base. New features and broad UI redesign follow stabilization.

The requirements list is a target inventory, not evidence that features are missing. No full rewrite, framework migration, database replacement or production-data migration is part of this first change.

## Inspected baseline

Repository commit: d4b13ca553b53c923fe8afd0eefd037b08206057.
This is a preliminary source inventory, not a complete audit or a new runtime certification.

| Area | Evidence | Current assessment | Next acceptance evidence |
| --- | --- | --- | --- |
| Windows build | recovered-source/LOGICA.csproj | net48, x86, WinForms; keep target | Full existing Windows build and POS workflow |
| Sales | recovered-source/LOGICA/Form_3_VENTE.cs (668747 bytes) | Large source file; extraction candidates need method-level inspection | Existing basket/checkout tests plus focused regression cases before moving logic |
| Catalogue | recovered-source/LOGICA/Form_2_ARTICLES.cs (646163 bytes) | Large source file; not proof of faulty behavior | Record representative product editing/import workflows before refactoring |
| Shared state and utilities | recovered-source/LOGICA/Module1.cs | Money, barcode, database connection and UI-dependent initialization coexist | Separate pure rules first; preserve legacy call sites |
| Existing regression checks | scripts/test-pos.cs | Basket, checkout/refund, rounding and form smoke checks exist | Execute against isolated fixture; expand failures/concurrency later |
| Existing CI | .github/workflows/windows-reference-diagnostic.yml | Builds source, provisions fixture, runs POS checks; repair step can commit generated repairs | Inspect actual branch run; do not infer success from workflow presence |
| Archive workflow | .github/workflows/build-recovered-source.yml | Builds archive, unlike the authoritative-source workflow | Do not use archive build as proof that current source passed |
| Peripherals | README.md | Real physical devices explicitly outside prior checks | Manual device acceptance on shop-equivalent hardware |

No AGENTS.md was present in the recursive repository tree at the inspected commit.
Credentials and activation behavior are not changed by this extraction.

## First implementation slice

Move the exact FLOUSS rounding expression into LOGICA.Domain.MonetaryRounding. Keep Module1.FLOUSS as the compatibility entry point, so existing callers remain intact. The SDK project automatically includes the new C# file.

Preserve both rounding away from zero and the existing culture-sensitive Visual Basic conversion. Removing that conversion or its dependency is a separate decision after compatibility review. The new type has no UI, database or Module1 dependency.

Add standalone characterization checks covering explicit expected values, positive and negative amounts, midpoint boundaries, large amounts, decimal limits and fr-MA/fr-FR/en-US cultures. The standalone runner compiles the production rule directly using Windows .NET Framework tooling. Existing POS tests still exercise the compatibility entry point in the built EXE.

## Ordered next slices

1. Verify the existing full Windows build, isolated checkout/refund fixture and baseline screens for this branch.
2. Inspect basket calculation and checkout methods. Map UI reads, database writes, stock movements, ticket numbering and printer calls before selecting the next extraction.
3. Add regression cases for the selected rule, then extract that one responsibility behind the existing form entry point.
4. Separate database access after transaction and error behavior is documented. Treat financial behavior changes as separate fixes.
5. Repeat for stock/catalogue; evaluate selected TODO ideas only after the relevant LOGICA area is protected.

Each slice must list original entry points, preserved behavior, tests actually run, limitations and a rollback commit. Changes stay on a review branch until accepted. A full requirement-by-requirement audit and effort estimates remain to be completed; file size alone is not an effort estimate.

## Progress: second slice (2026-10-29)

The owner reaffirmed that organizing code is the priority; the existing application is already working and tried in use. Database checks are regression protection only.

Inspected Form_3_VENTE.Text_TOTAL_NET_Click: database total -> display formatting -> grid quantity aggregation -> optional serial display. These boundaries remain unchanged.
Inspected Button_QTE_Click: access check -> quantity dialog -> article price lookup -> quantity-tier selection -> net amount -> basket update -> total refresh.

Extracted the four identical net-amount expressions in Button_QTE_Click into SalesLinePricing.CalculateNetAmount. Kept quantity-tier decisions, promotion input, sale/return branches, VB formatting, return double conversion, database writes and existing exceptions in the form. The calculation intentionally remains unrounded and retains intermediate decimal overflow. No new discount validation was introduced.

Local Windows checks: monetary rounding 60,039 assertions and sales line pricing 12,558 assertions passed. Cases include fractional/negative quantities, zero/100%/out-of-range discounts, unrounded fractions and overflow boundaries. Full branch CI must be checked after publication. Standalone rule tests do not exercise the modal quantity dialog or replace manual UI acceptance.

Rollback for this slice: revert its commit; the previous rounding extraction is independent. Next useful step: characterize quantity-dialog/price-tier behavior before extracting more of Button_QTE_Click; map the checkout transaction before moving persistence.
