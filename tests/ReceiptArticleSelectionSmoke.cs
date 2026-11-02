using System;
using System.Data;
using LOGICA.ApplicationLayer.Purchasing;

internal static class ReceiptArticleSelectionSmoke
{
    private static int assertions;

    private static void Check(bool condition, string label)
    {
        assertions++;
        if (!condition) throw new Exception("Receipt article selection: " + label);
    }

    private static DataTable Matches()
    {
        var table = new DataTable();
        table.Columns.Add("ID_ARTICLE", typeof(string));
        table.Columns.Add("Code", typeof(string));
        table.Columns.Add("Article", typeof(string));
        table.Columns.Add("STOCK", typeof(decimal));
        table.Rows.Add("A", "SAME", "First", 10m);
        table.Rows.Add("B", "SAME", "Second", 20m);
        return table;
    }

    internal static int Run()
    {
        assertions = 0;
        try
        {
            var duplicates = Matches();
            Check(ReceiptArticleSelectionService.Resolve(duplicates, null) == null,
                "barcode-only lookup refuses two variants");
            DataRow second = ReceiptArticleSelectionService.Resolve(duplicates, "B");
            Check(Object.ReferenceEquals(second, duplicates.Rows[1]) &&
                (decimal)second["STOCK"] == 20m,
                "explicit grid ID picks second variant, never first");
            Check(Object.ReferenceEquals(ReceiptArticleSelectionService.Resolve(duplicates, "A"),
                duplicates.Rows[0]), "explicit first variant remains valid");
            Check(ReceiptArticleSelectionService.Resolve(duplicates, "b") == null,
                "article ID matching is ordinal and case sensitive");
            Check(ReceiptArticleSelectionService.Resolve(duplicates, "STALE") == null,
                "deleted or changed grid ID cannot select another variant");
            Check(duplicates.Rows[0]["Article"].ToString() == "First" &&
                duplicates.Rows[1]["Article"].ToString() == "Second",
                "selection never modifies catalogue rows");

            var unique = Matches();
            unique.Rows.RemoveAt(1);
            Check(Object.ReferenceEquals(ReceiptArticleSelectionService.Resolve(unique, null),
                unique.Rows[0]), "single barcode match works without grid");
            Check(Object.ReferenceEquals(ReceiptArticleSelectionService.Resolve(unique, "A"),
                unique.Rows[0]), "single explicit match works");
            Check(ReceiptArticleSelectionService.Resolve(unique, "B") == null,
                "stale grid ID does not fall back to unique barcode");

            // Real receipt UI: a vanished clicked grid row is not an unknown
            // barcode scan and must not open the create-article dialog.
            Check(ReceiptArticleSelectionService.CanOfferCreation(unique.Clone(), null),
                "unknown scanner barcode may retain original create-article prompt");
            Check(!ReceiptArticleSelectionService.CanOfferCreation(unique.Clone(), "A"),
                "vanished explicit grid ID cannot offer article creation");
            Check(!ReceiptArticleSelectionService.CanOfferCreation(unique, null),
                "existing barcode cannot offer creation");
            Check(!ReceiptArticleSelectionService.CanOfferCreation(duplicates, "B"),
                "explicit existing variant cannot offer creation");
            Check(!ReceiptArticleSelectionService.CanOfferCreation(duplicates, null),
                "duplicate barcode cannot offer creation");
            Check(!ReceiptArticleSelectionService.CanOfferCreation(unique.Clone(), ""),
                "empty but explicit grid identity cannot offer creation");
            bool missingLookupRejected = false;
            try { ReceiptArticleSelectionService.CanOfferCreation(null, "A"); }
            catch (ArgumentNullException) { missingLookupRejected = true; }
            Check(missingLookupRejected, "missing fresh lookup cannot offer creation");

            var empty = unique.Clone();
            Check(ReceiptArticleSelectionService.Resolve(empty, null) == null,
                "unknown barcode returns no row");
            Check(ReceiptArticleSelectionService.Resolve(empty, "A") == null,
                "unknown selected article returns no row");

            // The local barcode query is expected to contain exactly one Code.
            // A corrupt/mixed query must not assign an unrelated variant's
            // purchase price, even when an explicit grid ID was supplied.
            var mixedCodes = Matches();
            mixedCodes.Rows[1]["Code"] = "OTHER";
            Check(ReceiptArticleSelectionService.Resolve(mixedCodes, "A") == null,
                "mixed barcode lookup rejects first explicit variant");
            Check(ReceiptArticleSelectionService.Resolve(mixedCodes, "B") == null,
                "mixed barcode lookup rejects second explicit variant");
            Check(ReceiptArticleSelectionService.Resolve(mixedCodes, null) == null,
                "mixed barcode lookup rejects scanner selection");
            Check(ReceiptArticleSelectionService.Resolve(mixedCodes, "MISSING") == null,
                "mixed barcode lookup never falls back to another article");
            // Real WinForms Find button must distinguish an empty scanner from
            // an explicit grid-selected article without a barcode. The latter
            // must reach the existing local Code='' query and exact ID resolver.
            Check(!ReceiptArticleSelectionService.ShouldLookupBarcode("", null),
                "empty scanner does not read or select an arbitrary blank-code article");
            Check(!ReceiptArticleSelectionService.ShouldLookupBarcode("  ", null),
                "whitespace-only scanner is ignored");
            Check(!ReceiptArticleSelectionService.ShouldLookupBarcode(null, null),
                "null scanner value is ignored");
            Check(ReceiptArticleSelectionService.ShouldLookupBarcode("KNOWN", null),
                "ordinary scanner still queries catalogue");
            Check(ReceiptArticleSelectionService.ShouldLookupBarcode("KNOWN", "A"),
                "explicit grid article with barcode still queries catalogue");
            Check(ReceiptArticleSelectionService.ShouldLookupBarcode("", "B"),
                "explicit barcode-free grid article must reach exact ID lookup");
            Check(ReceiptArticleSelectionService.ShouldLookupBarcode(null, "B"),
                "explicit ID remains distinguishable from empty scanner input");
            Check(ReceiptArticleSelectionService.ShouldLookupBarcode(" ", "B"),
                "explicit grid identity retains whitespace Code exactly");
            Check(ReceiptArticleSelectionService.ShouldLookupBarcode("", ""),
                "malformed explicit ID is still sent to fail-closed resolver");
            var barcodeFreeSingle = Matches();
            barcodeFreeSingle.Rows.RemoveAt(1);
            barcodeFreeSingle.Rows[0]["Code"] = "";
            Check(Object.ReferenceEquals(ReceiptArticleSelectionService.Resolve(
                barcodeFreeSingle, "A"), barcodeFreeSingle.Rows[0]),
                "single barcode-free product can be selected by explicit ID");
            Check(ReceiptArticleSelectionService.Resolve(barcodeFreeSingle, "MISSING") == null,
                "stale explicit ID cannot select barcode-free product");
            Check(!ReceiptArticleSelectionService.CanOfferCreation(barcodeFreeSingle.Clone(), "A"),
                "disappeared barcode-free grid article cannot trigger create prompt");

            // Production receipt Add button: selecting a blank-Code article
            // in the grid must be able to create a receipt line. A blank scan
            // or a stale selection must never gain that authorization.
            Check(ReceiptArticleSelectionService.CanAddResolvedArticle("A", "SAME", false),
                "normal scanner-resolved barcode still adds a receipt line");
            Check(ReceiptArticleSelectionService.CanAddResolvedArticle("A", "SAME", true),
                "explicit barcode grid article still adds a receipt line");
            Check(ReceiptArticleSelectionService.CanAddResolvedArticle("A", "", true),
                "exact-ID grid choice permits a barcode-free receipt line");
            Check(!ReceiptArticleSelectionService.CanAddResolvedArticle("A", "", false),
                "empty scanner result cannot add a barcode-free receipt line");
            Check(!ReceiptArticleSelectionService.CanAddResolvedArticle("", "", true),
                "empty grid identity never authorizes blank barcode");
            Check(!ReceiptArticleSelectionService.CanAddResolvedArticle(" ", "", true),
                "whitespace grid identity never authorizes blank barcode");
            Check(!ReceiptArticleSelectionService.CanAddResolvedArticle(null, "", true),
                "missing grid identity never authorizes blank barcode");
            Check(!ReceiptArticleSelectionService.CanAddResolvedArticle("A", null, true),
                "null barcode from corrupt catalogue is not a blank-code product");
            Check(!ReceiptArticleSelectionService.CanAddResolvedArticle("A", null, false),
                "null scanner barcode cannot add a receipt line");
            Check(!ReceiptArticleSelectionService.CanAddResolvedArticle("", "KNOWN", false),
                "stale cleared article identity cannot add even with old barcode");
            Check(ReceiptArticleSelectionService.CanAddResolvedArticle("A", " ", true),
                "exact grid selection preserves legitimate whitespace Code as stored");
            Check(ReceiptArticleSelectionService.CanAddResolvedArticle("A", " ", false),
                "existing nonempty Code guard preserves legacy nonblank behavior");
            DataRow blankResolved = ReceiptArticleSelectionService.Resolve(barcodeFreeSingle, "A");
            Check(blankResolved != null &&
                ReceiptArticleSelectionService.CanAddResolvedArticle(
                    Convert.ToString(blankResolved["ID_ARTICLE"]), Convert.ToString(blankResolved["Code"]), true),
                "fresh exact-ID blank-Code resolution reaches receipt Add guard");
            Check(ReceiptArticleSelectionService.Resolve(barcodeFreeSingle, "STALE") == null &&
                !ReceiptArticleSelectionService.CanAddResolvedArticle("", "", false),
                "vanished selected article never authorizes a receipt line");
            Check(!ReceiptArticleSelectionService.ShouldLookupBarcode("", null) &&
                !ReceiptArticleSelectionService.CanAddResolvedArticle("", "", false),
                "empty scanner is blocked at both lookup and receipt Add");

            var blankCodes = Matches();
            blankCodes.Rows[0]["Code"] = "";
            blankCodes.Rows[1]["Code"] = "";
            Check(Object.ReferenceEquals(ReceiptArticleSelectionService.Resolve(blankCodes, "B"),
                blankCodes.Rows[1]), "explicit image-free blank-code article retains exact ID");
            Check(ReceiptArticleSelectionService.Resolve(blankCodes, null) == null,
                "ambiguous blank-code scan cannot silently select first article");
            var ordinalCodes = Matches();
            ordinalCodes.Rows[1]["Code"] = "same";
            Check(ReceiptArticleSelectionService.Resolve(ordinalCodes, "A") == null,
                "barcode matching remains ordinal and case-sensitive");
            ordinalCodes.Rows[1]["Code"] = "SAME ";
            Check(ReceiptArticleSelectionService.Resolve(ordinalCodes, "B") == null,
                "barcode matching does not silently trim variant identity");

            var duplicateId = Matches();
            duplicateId.Rows[1]["ID_ARTICLE"] = "A";
            Check(ReceiptArticleSelectionService.Resolve(duplicateId, "A") == null,
                "duplicate article identity fails closed even for explicit selection");
            Check(ReceiptArticleSelectionService.Resolve(duplicateId, null) == null,
                "duplicate identity fails closed for barcode-only lookup");

            var invalid = Matches();
            invalid.Rows[1]["ID_ARTICLE"] = " ";
            Check(ReceiptArticleSelectionService.Resolve(invalid, "A") == null,
                "malformed unrelated article blocks unsafe selection");
            var missingCode = Matches();
            missingCode.Rows[1]["Code"] = DBNull.Value;
            Check(ReceiptArticleSelectionService.Resolve(missingCode, "A") == null,
                "null barcode candidate fails closed");
            var deleted = Matches();
            deleted.AcceptChanges();
            deleted.Rows[1].Delete();
            Check(ReceiptArticleSelectionService.Resolve(deleted, "A") == null,
                "pending deleted row fails closed");
            var missingColumn = new DataTable();
            missingColumn.Columns.Add("ID_ARTICLE");
            missingColumn.Rows.Add("A");
            Check(ReceiptArticleSelectionService.Resolve(missingColumn, "A") == null,
                "missing barcode schema fails closed");

            bool threw = false;
            try { ReceiptArticleSelectionService.Resolve(null, null); }
            catch (ArgumentNullException) { threw = true; }
            Check(threw, "null snapshot rejected");

            // The real receipt validation button must not post stock for a
            // different document when the grid binding cursor is stale.
            Check(ReceiptDocumentSelectionGuard.Matches("BR-42", "BR-42"),
                "confirmed and loaded receipt identities agree");
            Check(!ReceiptDocumentSelectionGuard.Matches("BR-42", "BR-43"),
                "different receipt must never be validated");
            Check(!ReceiptDocumentSelectionGuard.Matches("BR-42", "br-42"),
                "receipt identity comparison is ordinal");
            Check(!ReceiptDocumentSelectionGuard.Matches("BR-42", null),
                "missing loaded receipt must fail closed");
            Check(!ReceiptDocumentSelectionGuard.Matches(null, "BR-42"),
                "missing confirmed receipt must fail closed");
            Check(!ReceiptDocumentSelectionGuard.Matches(" ", " "),
                "blank receipt identifiers cannot validate");
            Check(!ReceiptDocumentSelectionGuard.Matches("BR-42 ", "BR-42"),
                "whitespace changes identity rather than silently trimming");
            Check(ReceiptDocumentSelectionGuard.MayValidate(
                "BR-42", "BR-42", "ENREGISTRER", "ENREGISTRER"),
                "only matching unvalidated receipt can reach stock posting");
            Check(!ReceiptDocumentSelectionGuard.MayValidate(
                "BR-42", "BR-43", "ENREGISTRER", "ENREGISTRER"),
                "different confirmed document blocked before transaction");
            Check(!ReceiptDocumentSelectionGuard.MayValidate(
                "BR-42", "BR-42", "VALIDER", "ENREGISTRER"),
                "already validated displayed receipt blocked");
            Check(!ReceiptDocumentSelectionGuard.MayValidate(
                "BR-42", "BR-42", "ENREGISTRER", "VALIDER"),
                "receipt validated between display and consultation blocked");
            Check(ReceiptDocumentSelectionGuard.MayValidate(
                "BR-42", "BR-42", "EN_COURS", "EN_COURS"),
                "original EN_COURS confirmation path remains valid");
            Check(!ReceiptDocumentSelectionGuard.MayValidate(
                "BR-42", "BR-42", "ENREGISTRER", null),
                "missing consulted state blocked");
            Check(ReceiptDocumentSelectionGuard.MayValidate(
                "BR-42", "BR-42", "enregistrer", "ENREGISTRER"),
                "legacy non-validated states are not newly restricted");
            Check(!ReceiptDocumentSelectionGuard.MayValidate(
                "", "", "ENREGISTRER", "ENREGISTRER"),
                "empty receipt ID cannot validate even with matching state");


            // The WinForms receipt grid may be sorted or filtered independently
            // from DT.Rows and BindingContext.Position. The clicked DataRowView
            // is authoritative for consultation, modification and deletion.
            var receipts = new DataTable();
            receipts.Columns.Add("ID_BR", typeof(string));
            receipts.Columns.Add("ETAT", typeof(string));
            receipts.Rows.Add("BR-001", "ENREGISTRER");
            receipts.Rows.Add("BR-002", "VALIDER");
            receipts.Rows.Add("BR-003", "ENREGISTRER");
            receipts.AcceptChanges();
            DataView receiptView = receipts.DefaultView;
            receiptView.Sort = "ID_BR DESC";
            Check(Object.ReferenceEquals(ReceiptDocumentSelectionGuard.ResolveBoundRow(
                receiptView[0], "BR-003"), receipts.Rows[2]),
                "descending sorted click resolves actual third record, not DT.Rows[0]");
            Check(Object.ReferenceEquals(ReceiptDocumentSelectionGuard.ResolveBoundRow(
                receiptView[2], "BR-001"), receipts.Rows[0]),
                "descending sorted click resolves first record at displayed index two");
            Check(ReceiptDocumentSelectionGuard.ResolveBoundRow(receiptView[0], "BR-001") == null,
                "mismatched displayed receipt ID cannot consult another row");
            receiptView.RowFilter = "ETAT = 'ENREGISTRER'";
            Check(receiptView.Count == 2 && Object.ReferenceEquals(
                ReceiptDocumentSelectionGuard.ResolveBoundRow(receiptView[1], "BR-001"), receipts.Rows[0]),
                "filtered grid retains bound identity after removing middle row");
            Check(ReceiptDocumentSelectionGuard.ResolveBoundRow(null, "BR-001") == null,
                "unbound grid row fails closed");
            Check(ReceiptDocumentSelectionGuard.ResolveBoundRow(receiptView[0], null) == null,
                "missing visible ID fails closed");
            Check(ReceiptDocumentSelectionGuard.ResolveBoundRow(receiptView[0], "br-003") == null,
                "receipt ID is case-sensitive");
            receipts.Rows[2]["ID_BR"] = "BR-CHANGED";
            Check(ReceiptDocumentSelectionGuard.ResolveBoundRow(receiptView[0], "BR-003") == null,
                "edited bound identity cannot retain stale visible ID");
            Check(ReceiptDocumentSelectionGuard.ResolveBoundRow(receiptView[0], "BR-CHANGED") == receipts.Rows[2],
                "updated bound identity resolves only under its current ID");
            receipts.Rows[2].Delete();
            Check(ReceiptDocumentSelectionGuard.ResolveBoundRow(
                receipts.DefaultView.Count > 0 ? receipts.DefaultView[0] : null, "BR-CHANGED") == null,
                "deleted record cannot be resolved through a stale receipt ID");
            var missingReceiptId = new DataTable();
            missingReceiptId.Columns.Add("ETAT", typeof(string));
            missingReceiptId.Rows.Add("ENREGISTRER");
            Check(ReceiptDocumentSelectionGuard.ResolveBoundRow(missingReceiptId.DefaultView[0], "BR-001") == null,
                "missing receipt ID schema fails closed");

            // Production consultation/modification/delete uses the bound
            // header's ID_BR to load or mutate receipt detail rows. Duplicate
            // header numbers (even filtered out) would target multiple receipts.
            var duplicateHeaders = new DataTable();
            duplicateHeaders.Columns.Add("ID", typeof(string));
            duplicateHeaders.Columns.Add("ID_BR", typeof(string));
            duplicateHeaders.Columns.Add("ETAT", typeof(string));
            duplicateHeaders.Rows.Add("1", "BR-100", "ENREGISTRER");
            duplicateHeaders.Rows.Add("2", "BR-200", "ENREGISTRER");
            duplicateHeaders.AcceptChanges();
            var duplicateHeaderView = duplicateHeaders.DefaultView;
            duplicateHeaderView.RowFilter = "ID = '1'";
            Check(Object.ReferenceEquals(ReceiptDocumentSelectionGuard.ResolveBoundRow(
                duplicateHeaderView[0], "BR-100"), duplicateHeaders.Rows[0]),
                "unique filtered receipt remains selectable");
            duplicateHeaders.Rows.Add("3", "BR-100", "ENREGISTRER");
            Check(duplicateHeaderView.Count == 1 &&
                ReceiptDocumentSelectionGuard.ResolveBoundRow(
                    duplicateHeaderView[0], "BR-100") == null,
                "hidden duplicate receipt number blocks detail SQL by ID_BR");
            duplicateHeaders.Rows[2].Delete();
            Check(Object.ReferenceEquals(ReceiptDocumentSelectionGuard.ResolveBoundRow(
                duplicateHeaderView[0], "BR-100"), duplicateHeaders.Rows[0]),
                "deleted duplicate receipt number no longer blocks selection");
            duplicateHeaders.Rows.Add("1", "BR-OTHER", "ENREGISTRER");
            Check(ReceiptDocumentSelectionGuard.ResolveBoundRow(
                duplicateHeaderView[0], "BR-100") == null,
                "duplicate database record ID blocks bound receipt selection");
            duplicateHeaders.Rows[2].Delete();
            Check(Object.ReferenceEquals(ReceiptDocumentSelectionGuard.ResolveBoundRow(
                duplicateHeaderView[0], "BR-100"), duplicateHeaders.Rows[0]),
                "deleted duplicate record ID restores exact bound selection");
            // Clear the filter before testing a NULL ID; otherwise the row
            // disappears from the view and the test would fail at the indexer.
            duplicateHeaderView.RowFilter = "";
            duplicateHeaders.Rows[0]["ID"] = DBNull.Value;
            Check(ReceiptDocumentSelectionGuard.ResolveBoundRow(
                duplicateHeaderView[0], "BR-100") == null,
                "missing bound database record ID fails closed");
            duplicateHeaders.Rows[0]["ID"] = "1";
            Check(Object.ReferenceEquals(ReceiptDocumentSelectionGuard.ResolveBoundRow(
                duplicateHeaderView[0], "BR-100"), duplicateHeaders.Rows[0]),
                "restored unique receipt remains selectable");

            // Real MODIFICATION save used Label_INDEX + BindingContext.Position,
            // which can target a different record after sorting/filtering.
            // Exact ID and receipt number must select one unvalidated DT row.
            var editableReceipts = new DataTable();
            editableReceipts.Columns.Add("ID", typeof(string));
            editableReceipts.Columns.Add("ID_BR", typeof(string));
            editableReceipts.Columns.Add("ETAT", typeof(string));
            editableReceipts.Rows.Add("10", "BR-A", "ENREGISTRER");
            editableReceipts.Rows.Add("11", "BR-B", "ENREGISTRER");
            editableReceipts.Rows.Add("12", "BR-C", "VALIDER");
            editableReceipts.AcceptChanges();
            DataView editableView = editableReceipts.DefaultView;
            editableView.Sort = "ID_BR DESC";
            Check(Object.ReferenceEquals(ReceiptDocumentSelectionGuard.ResolveEditableRow(
                editableReceipts, "10", "BR-A"), editableReceipts.Rows[0]),
                "sorted modification resolves original database row, not visible index");
            editableView.RowFilter = "ID_BR <> 'BR-B'";
            Check(Object.ReferenceEquals(ReceiptDocumentSelectionGuard.ResolveEditableRow(
                editableReceipts, "11", "BR-B"), editableReceipts.Rows[1]),
                "filtered grid does not retarget a previously opened receipt");
            Check(ReceiptDocumentSelectionGuard.ResolveEditableRow(
                editableReceipts, "11", "BR-A") == null,
                "mismatched receipt number cannot update another record");
            Check(ReceiptDocumentSelectionGuard.ResolveEditableRow(
                editableReceipts, "12", "BR-C") == null,
                "validated receipt cannot be reverted to ENREGISTRER by stale edit");
            Check(ReceiptDocumentSelectionGuard.ResolveEditableRow(
                editableReceipts, "999", "BR-A") == null,
                "deleted or missing record cannot be silently replaced");
            Check(ReceiptDocumentSelectionGuard.ResolveEditableRow(
                editableReceipts, "10", "br-a") == null,
                "receipt edit identity uses ordinal comparison");
            Check(ReceiptDocumentSelectionGuard.ResolveEditableRow(
                editableReceipts, "", "BR-A") == null,
                "blank database record ID cannot authorize edit");
            Check(ReceiptDocumentSelectionGuard.ResolveEditableRow(
                editableReceipts, "10", "") == null,
                "blank receipt number cannot authorize edit");
            Check(ReceiptDocumentSelectionGuard.ResolveEditableRow(
                null, "10", "BR-A") == null,
                "missing bound snapshot cannot authorize edit");
            editableReceipts.Rows.Add("10", "BR-OTHER", "ENREGISTRER");
            Check(ReceiptDocumentSelectionGuard.ResolveEditableRow(
                editableReceipts, "10", "BR-A") == null,
                "duplicate database record ID blocks edit even if number matches");
            editableReceipts.Rows[3].Delete();
            Check(Object.ReferenceEquals(ReceiptDocumentSelectionGuard.ResolveEditableRow(
                editableReceipts, "10", "BR-A"), editableReceipts.Rows[0]),
                "deleted duplicate record does not block valid existing row");
            editableReceipts.Rows[0]["ID_BR"] = "BR-RENUMBERED";
            Check(ReceiptDocumentSelectionGuard.ResolveEditableRow(
                editableReceipts, "10", "BR-A") == null,
                "changed bound receipt number blocks stale modification");
            Check(Object.ReferenceEquals(ReceiptDocumentSelectionGuard.ResolveEditableRow(
                editableReceipts, "10", "BR-RENUMBERED"), editableReceipts.Rows[0]),
                "fresh receipt number permits exact edit of original record");
            editableReceipts.Rows.Add("99", "BR-RENUMBERED", "ENREGISTRER");
            Check(ReceiptDocumentSelectionGuard.ResolveEditableRow(
                editableReceipts, "10", "BR-RENUMBERED") == null,
                "duplicate receipt numbers block detail-row overwrite");
            editableReceipts.Rows[3].Delete();
            Check(Object.ReferenceEquals(ReceiptDocumentSelectionGuard.ResolveEditableRow(
                editableReceipts, "10", "BR-RENUMBERED"), editableReceipts.Rows[0]),
                "deleted duplicate receipt number no longer blocks exact edit");
            editableReceipts.Rows[0]["ETAT"] = "";
            Check(ReceiptDocumentSelectionGuard.ResolveEditableRow(
                editableReceipts, "10", "BR-RENUMBERED") == null,
                "missing receipt state blocks stale modification");
            editableReceipts.Rows[0]["ETAT"] = "ENREGISTRER";
            Check(Object.ReferenceEquals(ReceiptDocumentSelectionGuard.ResolveEditableRow(
                editableReceipts, "10", "BR-RENUMBERED"), editableReceipts.Rows[0]),
                "restored original editable state remains supported");
            var missingEditableSchema = new DataTable();
            missingEditableSchema.Columns.Add("ID");
            missingEditableSchema.Rows.Add("10");
            Check(ReceiptDocumentSelectionGuard.ResolveEditableRow(
                missingEditableSchema, "10", "BR-A") == null,
                "missing state/receipt schema cannot authorize edit");

            // A corrupt header with a NULL state or number still occupies its
            // primary identity. The old loop skipped it, allowing a different
            // receipt with that ID to be edited and its detail rows overwritten.
            var corruptHeaders = new DataTable();
            corruptHeaders.Columns.Add("ID", typeof(string));
            corruptHeaders.Columns.Add("ID_BR", typeof(string));
            corruptHeaders.Columns.Add("ETAT", typeof(string));
            corruptHeaders.Rows.Add("5", "BR-5", "ENREGISTRER");
            corruptHeaders.AcceptChanges();
            Check(Object.ReferenceEquals(ReceiptDocumentSelectionGuard.ResolveEditableRow(
                corruptHeaders, "5", "BR-5"), corruptHeaders.Rows[0]),
                "unique editable receipt baseline");
            corruptHeaders.Rows.Add("5", "BR-OTHER", DBNull.Value);
            Check(ReceiptDocumentSelectionGuard.ResolveEditableRow(
                corruptHeaders, "5", "BR-5") == null,
                "NULL-state duplicate record ID cannot bypass edit identity check");
            corruptHeaders.Rows[1].Delete();
            corruptHeaders.Rows.Add("5", DBNull.Value, "ENREGISTRER");
            Check(ReceiptDocumentSelectionGuard.ResolveEditableRow(
                corruptHeaders, "5", "BR-5") == null,
                "NULL-number duplicate record ID cannot bypass edit identity check");
            corruptHeaders.Rows[1].Delete();
            corruptHeaders.Rows.Add(DBNull.Value, "BR-5", "ENREGISTRER");
            Check(ReceiptDocumentSelectionGuard.ResolveEditableRow(
                corruptHeaders, "5", "BR-5") == null,
                "NULL-ID duplicate receipt number cannot overwrite details");
            corruptHeaders.Rows[1].Delete();
            corruptHeaders.Rows[0]["ETAT"] = DBNull.Value;
            Check(ReceiptDocumentSelectionGuard.ResolveEditableRow(
                corruptHeaders, "5", "BR-5") == null,
                "NULL state on target receipt cannot authorize edit");
            corruptHeaders.Rows[0]["ETAT"] = "ENREGISTRER";
            Check(Object.ReferenceEquals(ReceiptDocumentSelectionGuard.ResolveEditableRow(
                corruptHeaders, "5", "BR-5"), corruptHeaders.Rows[0]),
                "restored target state allows unique edit");
            corruptHeaders.Rows.Add("6", "BR-6", "VALIDER");
            Check(Object.ReferenceEquals(ReceiptDocumentSelectionGuard.ResolveEditableRow(
                corruptHeaders, "5", "BR-5"), corruptHeaders.Rows[0]),
                "unrelated validated receipt does not block a valid edit");

            // Actual receipt Add button: reject invalid text before legacy VB
            // decimal conversion and before a line can be inserted. The core
            // accepts caller-supplied parsing so the Windows edge keeps its
            // Microsoft.VisualBasic culture and numeric semantics unchanged.
            int receiptConversions = 0;
            Func<string, bool> isReceiptNumeric = delegate(string input) {
                decimal ignored;
                return Decimal.TryParse(input, System.Globalization.NumberStyles.Number,
                    System.Globalization.CultureInfo.InvariantCulture, out ignored);
            };
            Func<string, decimal> convertReceipt = delegate(string input) {
                receiptConversions++;
                return Decimal.Parse(input, System.Globalization.NumberStyles.Number,
                    System.Globalization.CultureInfo.InvariantCulture);
            };
            decimal parsedReceiptNumber;
            Check(!ReceiptLineGridGuard.TryReadReceiptNumber(null, true, isReceiptNumeric,
                convertReceipt, out parsedReceiptNumber) && parsedReceiptNumber == 0m && receiptConversions == 0,
                "missing receipt quantity is rejected before conversion");
            Check(!ReceiptLineGridGuard.TryReadReceiptNumber("  ", true, isReceiptNumeric,
                convertReceipt, out parsedReceiptNumber) && receiptConversions == 0,
                "whitespace receipt quantity is rejected before conversion");
            Check(!ReceiptLineGridGuard.TryReadReceiptNumber("bad", true, isReceiptNumeric,
                convertReceipt, out parsedReceiptNumber) && receiptConversions == 0,
                "malformed receipt quantity cannot reach VB decimal conversion");
            Check(!ReceiptLineGridGuard.TryReadReceiptNumber("-0.01", true, isReceiptNumeric,
                convertReceipt, out parsedReceiptNumber) && parsedReceiptNumber == 0m,
                "negative fractional quantity is rejected even when legacy Val truncates to zero");
            Check(!ReceiptLineGridGuard.TryReadReceiptNumber("-2", true, isReceiptNumeric,
                convertReceipt, out parsedReceiptNumber), "negative whole receipt quantity is rejected");
            Check(ReceiptLineGridGuard.TryReadReceiptNumber("0", true, isReceiptNumeric,
                convertReceipt, out parsedReceiptNumber) && parsedReceiptNumber == 0m,
                "legacy zero quantity remains accepted");
            Check(ReceiptLineGridGuard.TryReadReceiptNumber("2.75", true, isReceiptNumeric,
                convertReceipt, out parsedReceiptNumber) && parsedReceiptNumber == 2.75m,
                "positive fractional receipt quantity is preserved exactly");
            Check(ReceiptLineGridGuard.TryReadReceiptNumber("-1.25", false, isReceiptNumeric,
                convertReceipt, out parsedReceiptNumber) && parsedReceiptNumber == -1.25m,
                "legacy signed purchase and sale prices remain accepted");
            Check(!ReceiptLineGridGuard.TryReadReceiptNumber("", false, isReceiptNumeric,
                convertReceipt, out parsedReceiptNumber), "empty receipt price is rejected");
            Check(!ReceiptLineGridGuard.TryReadReceiptNumber("N/A", false, isReceiptNumeric,
                convertReceipt, out parsedReceiptNumber), "malformed receipt price is rejected");
            int invalidReceiptDelegates = 0;
            try { ReceiptLineGridGuard.TryReadReceiptNumber("1", true, null,
                convertReceipt, out parsedReceiptNumber); }
            catch (ArgumentNullException) { invalidReceiptDelegates++; }
            try { ReceiptLineGridGuard.TryReadReceiptNumber("1", true, isReceiptNumeric,
                null, out parsedReceiptNumber); }
            catch (ArgumentNullException) { invalidReceiptDelegates++; }
            Check(invalidReceiptDelegates == 2, "missing numeric callbacks fail closed");
            var receiptConversionError = new InvalidOperationException("legacy conversion failure");
            Exception observedReceiptConversionError = null;
            try { ReceiptLineGridGuard.TryReadReceiptNumber("1", true, isReceiptNumeric,
                delegate(string input) { throw receiptConversionError; }, out parsedReceiptNumber); }
            catch (Exception error) { observedReceiptConversionError = error; }
            Check(Object.ReferenceEquals(receiptConversionError, observedReceiptConversionError),
                "unexpected VB numeric conversion errors propagate without inserting a line");
            Console.WriteLine("PASS receipt add numeric preflight: invalid, fractional, zero, prices and conversion errors");

            // Save preflight: the original UI checked stale total labels before
            // EndEdit/recalculation, rejecting a valid first line or saving a
            // previous amount. The production button now uses this sequence.
            var saveStages = new System.Collections.Generic.List<string>();
            bool readyToSave = ReceiptLineGridGuard.PrepareForSave(
                delegate { saveStages.Add("edit"); return true; },
                delegate { saveStages.Add("lines"); },
                delegate { saveStages.Add("document"); });
            Check(readyToSave && String.Join(",", saveStages.ToArray()) == "edit,lines,document",
                "receipt save commits current edit then recalculates lines and document in order");
            // Edited grid lines and imported rows also go through the same
            // receipt numeric guard before document totals or SQL persistence.
            saveStages.Clear();
            Check(!ReceiptLineGridGuard.PrepareForSave(
                delegate { saveStages.Add("edit"); return ReceiptLineGridGuard.TryReadReceiptNumber(
                    "-0.01", true, isReceiptNumeric, convertReceipt, out parsedReceiptNumber); },
                delegate { saveStages.Add("lines"); },
                delegate { saveStages.Add("document"); }) &&
                String.Join(",", saveStages.ToArray()) == "edit",
                "manually edited negative fractional quantity aborts save before totals");
            saveStages.Clear();
            Check(!ReceiptLineGridGuard.PrepareForSave(
                delegate { saveStages.Add("edit"); return ReceiptLineGridGuard.TryReadReceiptNumber(
                    "", false, isReceiptNumeric, convertReceipt, out parsedReceiptNumber); },
                delegate { saveStages.Add("lines"); },
                delegate { saveStages.Add("document"); }) &&
                String.Join(",", saveStages.ToArray()) == "edit",
                "empty edited price aborts save before totals");
            saveStages.Clear();
            Check(ReceiptLineGridGuard.PrepareForSave(
                delegate { saveStages.Add("edit"); return ReceiptLineGridGuard.TryReadReceiptNumber(
                    "1.25", true, isReceiptNumeric, convertReceipt, out parsedReceiptNumber); },
                delegate { saveStages.Add("lines"); },
                delegate { saveStages.Add("document"); }) &&
                String.Join(",", saveStages.ToArray()) == "edit,lines,document",
                "valid fractional edited quantity retains original save ordering");
            saveStages.Clear();
            Check(ReceiptLineGridGuard.PrepareForSave(
                delegate { saveStages.Add("edit"); return ReceiptLineGridGuard.TryReadReceiptNumber(
                    "0", true, isReceiptNumeric, convertReceipt, out parsedReceiptNumber); },
                delegate { saveStages.Add("lines"); },
                delegate { saveStages.Add("document"); }) &&
                String.Join(",", saveStages.ToArray()) == "edit,lines,document",
                "legacy zero-quantity edited receipt retains save path");
            saveStages.Clear();
            Check(!ReceiptLineGridGuard.PrepareForSave(
                delegate { saveStages.Add("invalid-edit"); return false; },
                delegate { saveStages.Add("should-not-recalculate"); },
                delegate { saveStages.Add("should-not-recalculate-document"); }) &&
                saveStages.Count == 1 && saveStages[0] == "invalid-edit",
                "invalid edit stops receipt save without recomputing stale totals");
            var editFailure = new InvalidOperationException("edit failed");
            Exception observedSaveFailure = null;
            try {
                ReceiptLineGridGuard.PrepareForSave(
                    delegate { throw editFailure; }, delegate { }, delegate { });
            } catch (Exception error) { observedSaveFailure = error; }
            Check(Object.ReferenceEquals(editFailure, observedSaveFailure),
                "save preflight preserves original edit exception identity");
            var documentFailure = new InvalidOperationException("totals failed");
            observedSaveFailure = null;
            saveStages.Clear();
            try {
                ReceiptLineGridGuard.PrepareForSave(
                    delegate { saveStages.Add("edit"); return true; },
                    delegate { saveStages.Add("lines"); },
                    delegate { throw documentFailure; });
            } catch (Exception error) { observedSaveFailure = error; }
            Check(Object.ReferenceEquals(documentFailure, observedSaveFailure) &&
                String.Join(",", saveStages.ToArray()) == "edit,lines",
                "document-total failure propagates without authorizing save");
            int rejectedSaveDelegates = 0;
            try { ReceiptLineGridGuard.PrepareForSave(null, delegate { }, delegate { }); }
            catch (ArgumentNullException) { rejectedSaveDelegates++; }
            try { ReceiptLineGridGuard.PrepareForSave(delegate { return true; }, null, delegate { }); }
            catch (ArgumentNullException) { rejectedSaveDelegates++; }
            try { ReceiptLineGridGuard.PrepareForSave(delegate { return true; }, delegate { }, null); }
            catch (ArgumentNullException) { rejectedSaveDelegates++; }
            Check(rejectedSaveDelegates == 3, "missing save callbacks fail before any receipt mutation");

            // The real receipt line grid must honor the clicked/edited row,
            // not CurrentCell, and must recheck article identity after a modal.
            // Keyboard Enter and CellEnter now use the same explicit event-row
            // bounds as mouse clicks; a stale CurrentCell must not be used.
            Check(ReceiptLineGridGuard.HasExistingRow(2, 3),
                "keyboard selection may target last filtered result");
            Check(!ReceiptLineGridGuard.HasExistingRow(-1, 3),
                "keyboard selection cannot act on a column header");
            Check(!ReceiptLineGridGuard.HasExistingRow(0, 0),
                "keyboard selection cannot act on empty results");
            Check(!ReceiptLineGridGuard.HasExistingRow(3, 3),
                "keyboard selection cannot act on stale out-of-range cell");

            Check(ReceiptLineGridGuard.HasExistingRow(0, 2),
                "first receipt line is selectable");
            Check(ReceiptLineGridGuard.HasExistingRow(1, 2),
                "second clicked receipt line is selectable even when CurrentCell is first");
            Check(!ReceiptLineGridGuard.HasExistingRow(-1, 2),
                "column-header event is not a receipt line");
            Check(!ReceiptLineGridGuard.HasExistingRow(2, 2),
                "row index equal to count is not a receipt line");
            Check(!ReceiptLineGridGuard.HasExistingRow(0, 0),
                "empty receipt grid cannot select a line");
            Check(!ReceiptLineGridGuard.HasExistingRow(int.MaxValue, 2),
                "out-of-range event index cannot delete a line");
            Check(ReceiptLineGridGuard.MatchesLine("ARTICLE-2", "DUP",
                "ARTICLE-2", "DUP"), "clicked line identity survives modal");
            Check(!ReceiptLineGridGuard.MatchesLine("ARTICLE-2", "DUP",
                "ARTICLE-1", "DUP"), "same barcode must not delete another article");
            Check(!ReceiptLineGridGuard.MatchesLine("ARTICLE-2", "DUP",
                "ARTICLE-2", "NEW"), "changed barcode invalidates modal delete");
            Check(!ReceiptLineGridGuard.MatchesLine("ARTICLE-2", "DUP",
                "article-2", "DUP"), "line article identity is ordinal");
            Check(!ReceiptLineGridGuard.MatchesLine(null, "DUP",
                "ARTICLE-2", "DUP"), "missing article ID cannot authorize delete");
            Check(!ReceiptLineGridGuard.MatchesLine("  ", "DUP",
                "  ", "DUP"), "blank article ID cannot authorize delete");
            Check(ReceiptLineGridGuard.MatchesLine("IMAGE-ONLY", "",
                "IMAGE-ONLY", ""), "receipt line with blank barcode retains identity");
            Check(!ReceiptLineGridGuard.MatchesLine("IMAGE-ONLY", "",
                "IMAGE-ONLY", "CHANGED"), "blank-to-filled barcode invalidates stale delete");

            Console.WriteLine("PASS real receipt article selection: " + assertions +
                " assertions; duplicate barcodes, exact grid IDs, stale/malformed identities");
            return 0;
        }
        catch (Exception ex) { Console.Error.WriteLine(ex); return 1; }
    }
}
