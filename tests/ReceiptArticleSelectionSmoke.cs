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

            Console.WriteLine("PASS real receipt article selection: " + assertions +
                " assertions; duplicate barcodes, exact grid IDs, stale/malformed identities");
            return 0;
        }
        catch (Exception ex) { Console.Error.WriteLine(ex); return 1; }
    }
}
