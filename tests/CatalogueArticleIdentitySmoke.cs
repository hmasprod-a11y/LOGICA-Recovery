using System;
using System.Data;
using LOGICA.ApplicationLayer.Catalogue;

internal static class CatalogueArticleIdentitySmoke
{
    private static int assertions;
    private static void Check(bool value, string message)
    {
        assertions++;
        if (!value) throw new Exception("Catalogue identity regression: " + message);
    }

    private static DataTable Articles()
    {
        var table = new DataTable();
        table.Columns.Add("ID", typeof(int));
        table.Columns.Add("ID_ARTICLE", typeof(string));
        table.Columns.Add("Code", typeof(string));
        table.Columns.Add("Article", typeof(string));
        table.Rows.Add(1, "A", "DUP", "Alpha");
        table.Rows.Add(2, "B", "DUP", "Beta");
        return table;
    }

    internal static int Run()
    {
        assertions = 0;
        try
        {
            DataTable table = Articles();
            DataView sorted = new DataView(table);
            sorted.Sort = "Article DESC";
            DataRow clicked = sorted[0].Row;
            Check(Object.ReferenceEquals(clicked, table.Rows[1]), "sorted view displays Beta first");
            Check(Object.ReferenceEquals(CatalogueRowMapper.ResolveUniqueExistingRow(table, "2", "B"), clicked),
                "edit targets the clicked identity, not DataTable position zero");
            Check(Object.ReferenceEquals(CatalogueRowMapper.ResolveUniqueExistingRow(table, "1", "A"), table.Rows[0]),
                "original first product remains selectable");
            Check(CatalogueRowMapper.ResolveUniqueExistingRow(table, "2", "A") == null,
                "mixed database and article identities fail closed");
            Check(CatalogueRowMapper.ResolveUniqueExistingRow(table, "1", "B") == null,
                "reverse mixed identity fails closed");
            Check(CatalogueRowMapper.ResolveUniqueExistingRow(table, "2", "b") == null,
                "article IDs compare ordinally");
            Check(CatalogueRowMapper.ResolveUniqueExistingRow(table, "9", "B") == null,
                "stale database ID never selects a matching barcode");
            Check(CatalogueRowMapper.ResolveUniqueExistingRow(table, "", "B") == null,
                "blank database ID is rejected");
            Check(CatalogueRowMapper.ResolveUniqueExistingRow(table, "2", " ") == null,
                "blank article ID is rejected");
            Check(CatalogueRowMapper.ResolveUniqueExistingRow(null, "2", "B") == null,
                "missing table is rejected");

            DataView filtered = new DataView(table);
            filtered.RowFilter = "ID = 2";
            Check(filtered.Count == 1 && Object.ReferenceEquals(filtered[0].Row, table.Rows[1]),
                "filtered grid retains the exact underlying row");
            table.Rows.Add(3, "B", "OTHER", "Hidden duplicate ID");
            Check(CatalogueRowMapper.ResolveUniqueExistingRow(table, "2", "B") == null,
                "duplicate article ID hidden by filter blocks edit and delete");
            table.Rows.RemoveAt(2);
            table.Rows.Add(2, "C", "OTHER", "Hidden duplicate database ID");
            Check(CatalogueRowMapper.ResolveUniqueExistingRow(table, "2", "B") == null,
                "duplicate database ID hidden by filter blocks mutation");
            table.Rows.RemoveAt(2);
            table.Rows[1]["ID_ARTICLE"] = "CHANGED";
            Check(CatalogueRowMapper.ResolveUniqueExistingRow(table, "2", "B") == null,
                "identity change while edit dialog is open blocks save");
            Check(Object.ReferenceEquals(CatalogueRowMapper.ResolveUniqueExistingRow(table, "2", "CHANGED"), table.Rows[1]),
                "current exact identity remains valid");
            table.Rows[1].Delete();
            Check(CatalogueRowMapper.ResolveUniqueExistingRow(table, "2", "CHANGED") == null,
                "deleted row is never selected");

            DataTable invalid = new DataTable();
            invalid.Columns.Add("ID", typeof(int));
            Check(CatalogueRowMapper.ResolveUniqueExistingRow(invalid, "1", "A") == null,
                "incomplete schema fails closed");
            Check((string)table.Rows[0]["Code"] == "DUP" && (string)table.Rows[0]["Article"] == "Alpha",
                "duplicate barcode and original product data remain unchanged");
            Console.WriteLine("PASS catalogue article identity regression: " + assertions + " assertions");
            return 0;
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine(ex);
            return 1;
        }
    }
}
