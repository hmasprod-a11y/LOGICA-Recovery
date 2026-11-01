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

            // The real receipt line grid must honor the clicked/edited row,
            // not CurrentCell, and must recheck article identity after a modal.
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
