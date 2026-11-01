using System;
using System.Data;
using System.Globalization;
using LOGICA.ApplicationLayer.Purchasing;

internal static class ReceiptArticleSearchFilterSmoke
{
    private static int assertions;

    private static void Check(DataTable catalogue, string term, string expectedId)
    {
        var view = new DataView(catalogue);
        view.RowFilter = ReceiptArticleSearchFilter.Build(term);
        assertions++;
        if (view.Count != (expectedId == null ? 0 : 1) ||
            (expectedId != null && !String.Equals(
                (string)view[0]["ID_ARTICLE"], expectedId, StringComparison.Ordinal)))
            throw new Exception("Receipt literal search mismatch for " + term +
                ": expected " + (expectedId ?? "<none>") + ", found " + view.Count);
    }

    internal static int Run()
    {
        CultureInfo original = CultureInfo.CurrentCulture;
        assertions = 0;
        try
        {
            var catalogue = new DataTable();
            catalogue.Columns.Add("ID_ARTICLE", typeof(string));
            catalogue.Columns.Add("Article", typeof(string));
            catalogue.Columns.Add("Code", typeof(string));
            catalogue.Rows.Add("1", "O'Brien", "ABC");
            catalogue.Rows.Add("2", "100% Cotton", "COT");
            catalogue.Rows.Add("3", "Star* Product", "STAR");
            catalogue.Rows.Add("4", "[Bracket] Item", "BRK");
            catalogue.Rows.Add("5", "Normal article", "CODE-5");
            catalogue.AcceptChanges();
            foreach (string culture in new[] { "fr-MA", "fr-FR", "en-US" })
            {
                CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo(culture);
                Check(catalogue, "O'Brien", "1");
                Check(catalogue, "%", "2");
                Check(catalogue, "*", "3");
                Check(catalogue, "[", "4");
                Check(catalogue, "]", "4");
                Check(catalogue, "CODE-5", "5");
                Check(catalogue, "Cotton", "2");
                Check(catalogue, "' OR 1=1 OR '", null);
                Check(catalogue, "not-in-catalogue", null);
                var all = new DataView(catalogue);
                all.RowFilter = ReceiptArticleSearchFilter.Build(null);
                assertions++;
                if (all.Count != catalogue.Rows.Count)
                    throw new Exception("Null receipt search must retain all catalogue articles");
            }
            assertions++;
            if (catalogue.Rows.Count != 5 || catalogue.Rows[0].RowState != DataRowState.Unchanged)
                throw new Exception("Receipt search must not modify catalogue data");
            Console.WriteLine("PASS real receipt article search filter: " + assertions +
                " assertions; literal apostrophes, wildcards, brackets, code and injection across cultures");
            return 0;
        }
        catch (Exception error) { Console.Error.WriteLine(error); return 1; }
        finally { CultureInfo.CurrentCulture = original; }
    }
}
