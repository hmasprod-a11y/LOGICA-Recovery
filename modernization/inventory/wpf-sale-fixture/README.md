# HANOUTY Cell03 → Cell04: deterministic fictitious scan fixture

**Disposable only.** Use a fresh local MariaDB database named `hanouty_wpf_fixture`, never a shop database. This fixture does not validate the WPF UI or financial checkout.

## Setup

1. Create a fresh isolated database `hanouty_wpf_fixture` on local MariaDB (loopback); do not run against `logica_ci` or any shop schema.
2. Run `fixture.sql` against that database using a dedicated test account. The script refuses to overwrite an existing `TABLE_ARTICLES`.
3. Create `<test-data>/bd/images/fixture-soap.png` from an actual small PNG (any valid PNG), and pass `<test-data>` as the `legacyDataDirectory` argument.
4. Instantiate the existing `Hanouty.Inventory.MariaDb.MariaDbCatalogueReader(connectionString, testDataDirectory)`. Use `ListAll()`, `FindBarcode(code)`, and `RefreshArticle(articleId)` as appropriate. For stock availability use the separate read-only `MariaDbInventorySnapshotReader(connectionString)`. Never decrement stock from either reader.

| Scan | Expected catalogue result | Stock/checkout expectation |
|---|---|---|
| `6900000000011` | Exactly `DEMO-SOAP`, with existing image path | 12 units; eligible for checkout subject to cashier/financial gates |
| `6900000000028` | Two candidates: `DEMO-RED` and `DEMO-BLUE` | **Do not auto-pick**; ask explicit variant/article choice; stock 5 and 7 |
| `6900000000035` | Exactly `DEMO-OOS`, no image | Stock 0; show unavailable, refuse normal positive-quantity sale |
| `6900000000042` | Exactly `DEMO-QUOTED`, no image | Stock 3; preserve name with apostrophe |
| `6900000000999` | No matches | Show not found; do not add basket line |
| `6900000000028' OR 1=1 --` | No matches | Never broaden SQL search |

`FindBarcode` intentionally returns **all** candidates for a shared barcode; the WPF selection flow owns explicit disambiguation. `ReadUniqueBarcode` must throw for that barcode. `RefreshArticle("DEMO-BLUE")` must return exactly the blue article. Image lookup only returns a path when the file exists under the supplied images folder. This is a **data/reader fixture**, not a claimed WPF acceptance.

## QA93 selective manifest

- `modernization/inventory/Hanouty.Inventory.MariaDb/MariaDbCatalogueReader.cs`
- `modernization/inventory/Hanouty.Inventory.MariaDb/MariaDbInventorySnapshotReader.cs`
- `modernization/inventory/Hanouty.Inventory.MariaDb/Hanouty.Inventory.MariaDb.csproj`
- `modernization/inventory/wpf-sale-fixture/fixture.sql` and this README
- Architecture dependency: existing `Hanouty.ArchitectureBridge.ICatalogueReader` and `ProductSummary` (do not duplicate contracts)

No Stock Writer, Checkout writer, QA workflow, production migration, or shop database changes.
