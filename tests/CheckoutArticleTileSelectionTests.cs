using System;
using System.Data;
using System.Globalization;
using LOGICA.ApplicationLayer.Checkout;

internal static class CheckoutArticleTileSelectionTests
{
    private static DataTable Articles()
    {
        DataTable table = new DataTable();
        table.Columns.Add("ID_ARTICLE", typeof(string));
        table.Columns.Add("Code", typeof(string));
        table.Columns.Add("Article", typeof(string));
        table.Rows.Add("11", "SAME-001", "Small");
        table.Rows.Add("12", "SAME-001", "Large");
        table.Rows.Add("13", "OTHER", "Different code");
        return table;
    }

    private static void Require(bool value, string message)
    {
        if (!value) throw new Exception(message);
    }

    private static void Throws<T>(Action action) where T : Exception
    {
        try { action(); }
        catch (T) { return; }
        throw new Exception("Expected " + typeof(T).Name);
    }

    public static int Main()
    {
        int checks = 0;
        CultureInfo original = CultureInfo.CurrentCulture;
        try
        {
            foreach (string culture in new[] { "fr-MA", "fr-FR", "en-US" })
            {
                CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo(culture);
                DataTable source = Articles();
                CheckoutArticleTileReference small = CheckoutArticleTileSelectionService.TagFor(source.Rows[0]);
                CheckoutArticleTileReference large = CheckoutArticleTileSelectionService.TagFor(source.Rows[1]);
                Require(small.Code == "SAME-001" && small.ArticleId == "11" &&
                    small.ToString() == "SAME-001", "Tile must retain code and original ID");
                checks++;
                Require(CheckoutArticleTileSelectionService.FindExact(source, small) == source.Rows[0],
                    "Small tile must select its own article");
                checks++;
                Require(CheckoutArticleTileSelectionService.FindExact(source, large) == source.Rows[1],
                    "Large tile must select its own article, not the first barcode match");
                checks++;
                Require(CheckoutArticleTileSelectionService.FindExact(source,
                    new CheckoutArticleTileReference("SAME-001", "13")) == null,
                    "A different code with an existing ID must not match");
                checks++;
                Require(CheckoutArticleTileSelectionService.FindExact(source,
                    new CheckoutArticleTileReference("SAME-001", "missing")) == null,
                    "A removed tile's ID must fail closed");
                checks++;
                Require(CheckoutArticleTileSelectionService.FindExact(source,
                    new CheckoutArticleTileReference("other", "13")) == null,
                    "Barcode case changes must not silently redirect a tile");
                checks++;
                DataTable reversed = source.Clone();
                reversed.ImportRow(source.Rows[1]);
                reversed.ImportRow(source.Rows[0]);
                Require(CheckoutArticleTileSelectionService.FindExact(reversed, large) == reversed.Rows[0],
                    "Tile identity must not depend on query ordering");
                checks++;
                reversed.ImportRow(source.Rows[1]);
                Require(CheckoutArticleTileSelectionService.FindExact(reversed, large) == null,
                    "Ambiguous duplicate IDs must fail closed");
                checks++;
                reversed.Rows.Clear();
                Require(CheckoutArticleTileSelectionService.FindExact(reversed, large) == null,
                    "Empty scan must not post a sale");
                checks++;
                source.Rows[1]["Code"] = "UPDATED";
                Require(large.Code == "SAME-001" && large.ArticleId == "12",
                    "Tile tag must be an immutable snapshot");
                Require(CheckoutArticleTileSelectionService.FindExact(source, large) == null,
                    "Changed article barcode must not redirect to a different variant");
                checks += 2;
                Throws<ArgumentNullException>(delegate {
                    CheckoutArticleTileSelectionService.TagFor(null);
                });
                Throws<ArgumentNullException>(delegate {
                    CheckoutArticleTileSelectionService.FindExact(null, large);
                });
                Throws<ArgumentNullException>(delegate {
                    CheckoutArticleTileSelectionService.FindExact(source, null);
                });
                checks += 3;
            }
        }
        finally { CultureInfo.CurrentCulture = original; }
        Console.WriteLine("PASS checkout image tile article identity: " + checks +
            " cases across 3 cultures, duplicate barcode, missing ID, reordered rows and fail-closed ambiguity");
        return 0;
    }
}
