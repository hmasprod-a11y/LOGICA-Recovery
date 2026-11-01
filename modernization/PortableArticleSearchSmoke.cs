using System;
using System.Collections.Generic;
using System.Data;
using LOGICA.ApplicationLayer.Checkout;
using LOGICA.Infrastructure.Checkout;

internal static class PortableArticleSearchSmoke
{
    private static void Check(int length, int[] tabs, string expected)
    {
        var events = new List<string>();
        int tabReads = 0;
        CheckoutArticleSearchService.Search(
            delegate { events.Add("length"); return length; },
            delegate {
                tabReads++;
                events.Add("tab" + tabReads);
                return tabs[Math.Min(tabReads - 1, tabs.Length - 1)];
            },
            delegate { events.Add("list"); },
            delegate { events.Add("images"); });
        string actual = String.Join(",", events.ToArray());
        if (actual != expected)
            throw new Exception("Portable article search route changed: " + actual +
                " expected " + expected);
    }

    public static int Run()
    {
        Check(2, new[] { 0 }, "length");
        Check(3, new[] { 0 }, "length,tab1,list");
        Check(3, new[] { 1 }, "length,tab1,tab2,images");
        Check(3, new[] { 2 }, "length,tab1,tab2");
        Check(3, new[] { 2, 1 }, "length,tab1,tab2,images");
        const string term = "O'Hara";
        string list = CheckoutArticleSearchQueryText.List();
        string images = CheckoutArticleSearchQueryText.Images();
        if (!list.Contains("Article like @search") || !list.Contains("Code like @search") ||
            !images.Contains("Article like @search") || !images.Contains("Images <> '0.png'") ||
            list.Contains(term) || images.Contains(term) ||
            CheckoutArticleSearchQueryText.Pattern(term) != "%O'Hara%")
            throw new Exception("Portable article search parameterization changed");
        string barcode = CheckoutArticleSearchQueryText.ExactBarcode();
        if (barcode != "select * from TABLE_ARTICLES WHERE Code = @code" ||
            barcode.Contains("O'Hara") || barcode.Contains("ORDER BY") || barcode.Contains("LIKE"))
            throw new Exception("Portable scanned barcode lookup must be parameterized exact equality");
        DataTable matches = new DataTable();
        matches.Columns.Add("Article");
        matches.Rows.Add("first");
        matches.Rows.Add("variant");
        if (CheckoutBarcodeSelectionService.Select(matches, delegate(DataTable rows) { return 1; }) != matches.Rows[1])
            throw new Exception("Portable duplicate selection did not preserve selected DataRow");
        if (CheckoutBarcodeSelectionService.Select(matches, delegate(DataTable rows) { return -1; }) != null)
            throw new Exception("Portable duplicate cancel must not select a product");
        matches.Rows.RemoveAt(1);
        if (CheckoutBarcodeSelectionService.Select(matches, null) != matches.Rows[0])
            throw new Exception("Portable single barcode legacy behavior changed");
        Console.WriteLine("PASS .NET 10 portable checkout article search: routing, read order, parameterized search and exact barcode lookup");
        return 0;
    }
}
