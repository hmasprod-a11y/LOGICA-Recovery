using System;
using System.Collections.Generic;
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
        string list = "select   *    from TABLE_ARTICLES   WHERE       Article like  '%" +
            term + "%'       or       Code like  '%" + term + "%'        order by Article asc ";
        string images = "select      *     from      TABLE_ARTICLES      WHERE    Article like  '%" +
            term + "%'     and   Images <> '0.png'         order by Article asc ";
        if (CheckoutArticleSearchQueryText.List(term) != list ||
            CheckoutArticleSearchQueryText.Images(term) != images)
            throw new Exception("Portable article search SQL changed");
        Console.WriteLine("PASS .NET 10 portable checkout article search: routing, read order and SQL parity");
        return 0;
    }
}
