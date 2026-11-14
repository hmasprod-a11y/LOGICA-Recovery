# Inventory → Architecture W1 MariaDB adapter

Project: modernization/inventory/Hanouty.Inventory.MariaDb/Hanouty.Inventory.MariaDb.csproj
Type: Hanouty.Inventory.MariaDb.MariaDbCatalogueReader : Hanouty.ArchitectureBridge.ICatalogueReader
Construction: new MariaDbCatalogueReader(selectOnlyLocalConnectionString, legacyDataDirectory)
The legacy image location is <legacyDataDirectory>/bd/images/<Images filename>.
Only existing regular image paths are exposed; absent/NULL/"0" photos produce null.
Article ID is TABLE_ARTICLES.ID_ARTICLE; barcode Code, label Article, photo Images.
Duplicate barcode matches are returned as multiple rows, never collapsed. Blank barcode is
not a unique product identity. RefreshArticle matches stable ID; no fallback by barcode.
All queries are SELECT with bound parameters. Configure a MariaDB SELECT-only account;
the adapter itself does not grant/revoke database privileges.
The authoritative VariantId remains null until a verified legacy variant column mapping
is approved; never infer it from row order. The WPF adapter maps ArticleId→Id and
DisplayName→Name while Architecture retains the authoritative ProductSummary.

This project references the EXISTING Architecture PR #95 project, absent from PR #88.
QA must combine exact reviewed PR #88 + #95 + #96 SHAs on integration PR #93,
compile this project and run isolated MariaDB/WPF tests. Do not count W1 accepted
until the real WPF EXE shows DB rows/photos/duplicate choice.
