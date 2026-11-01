using System;
using System.Collections.Generic;
using System.Globalization;
using LOGICA.ApplicationLayer.Checkout;
using LOGICA.Infrastructure.Checkout;

internal static class CheckoutArticleSearchTests
{
    private sealed class Scenario
    {
        internal readonly List<string> Events = new List<string>();
        internal readonly Exception Failure = new InvalidOperationException("injected article-search failure");
        internal int Length;
        internal int[] Tabs;
        internal string FailAt;
        private int tabReads;

        internal Scenario(int length, int[] tabs, string failAt)
        {
            Length = length;
            Tabs = tabs;
            FailAt = failAt;
        }

        private void Mark(string stage)
        {
            Events.Add(stage);
            if (FailAt == stage) throw Failure;
        }

        internal int ReadLength()
        {
            Mark("length");
            return Length;
        }

        internal int ReadTab()
        {
            tabReads++;
            Mark("tab" + tabReads);
            return Tabs[Math.Min(tabReads - 1, Tabs.Length - 1)];
        }

        internal void List() { Mark("list"); }
        internal void Images() { Mark("images"); }
        internal Scenario Clone() { return new Scenario(Length, Tabs, FailAt); }
    }

    // Exact pre-extraction branch order from Form_3_VENTE.Text_FIND_TextChanged.
    private static void Legacy(Scenario source)
    {
        checked
        {
            if (source.ReadLength() <= 2) return;
            if (source.ReadTab() == 0)
                source.List();
            else
            {
                if (source.ReadTab() != 1) return;
                source.Images();
            }
        }
    }

    private static void Extracted(Scenario source)
    {
        CheckoutArticleSearchService.Search(
            source.ReadLength, source.ReadTab, source.List, source.Images);
    }

    private static Exception Capture(Action action)
    {
        try { action(); return null; }
        catch (Exception error) { return error; }
    }

    private static void Same(int length, int[] tabs, string failure, string label)
    {
        var original = new Scenario(length, tabs, failure);
        var extracted = original.Clone();
        Exception before = Capture(delegate { Legacy(original); });
        Exception after = Capture(delegate { Extracted(extracted); });
        string oldEvents = String.Join(",", original.Events.ToArray());
        string newEvents = String.Join(",", extracted.Events.ToArray());
        if (oldEvents != newEvents ||
            (before == null) != (after == null) ||
            (before != null && (before.GetType() != after.GetType() ||
             before.Message != after.Message)))
            throw new Exception(label + ": original=" + oldEvents +
                " extracted=" + newEvents + " failure=" + failure);
        if (before != null &&
            (!Object.ReferenceEquals(before, original.Failure) ||
             !Object.ReferenceEquals(after, extracted.Failure)))
            throw new Exception(label + ": exception identity changed");
    }

    private static void CheckSql(string term)
    {
        // Characterization oracle: literal SQL from the recovered sale Form.
        string legacyList = "select   *    from TABLE_ARTICLES   WHERE       Article like  '%" +
            term + "%'       or       Code like  '%" + term + "%'        order by Article asc ";
        string legacyImages = "select      *     from      TABLE_ARTICLES      WHERE    Article like  '%" +
            term + "%'     and   Images <> '0.png'         order by Article asc ";
        if (legacyList != CheckoutArticleSearchQueryText.List(term) ||
            legacyImages != CheckoutArticleSearchQueryText.Images(term))
            throw new Exception("Article search SQL text changed for: " + term);
    }

    public static int Main()
    {
        int cases = 0;
        CultureInfo old = CultureInfo.CurrentCulture;
        CultureInfo oldUi = CultureInfo.CurrentUICulture;
        try
        {
            int[][] tabSequences = {
                new[] { 0 }, new[] { 1 }, new[] { 2 },
                new[] { 2, 1 }, new[] { 2, 0 },
                new[] { 1, 0 }, new[] { -1, 1 }
            };
            string[] failures = { null, "length", "tab1", "tab2", "list", "images" };
            foreach (string culture in new[] { "en-US", "fr-FR", "tr-TR" })
            {
                CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo(culture);
                CultureInfo.CurrentUICulture = CultureInfo.GetCultureInfo(culture);
                foreach (int length in new[] { 0, 1, 2, 3, 100 })
                foreach (int[] tabs in tabSequences)
                foreach (string failure in failures)
                {
                    Same(length, tabs, failure, culture + "/length " + length);
                    cases++;
                }
                foreach (string term in new[] {
                    "", "AB", "O'Hara", "%_\\", "é عربي", null
                })
                {
                    CheckSql(term);
                    cases++;
                }
            }
        }
        finally
        {
            CultureInfo.CurrentCulture = old;
            CultureInfo.CurrentUICulture = oldUi;
        }
        Console.WriteLine("PASS checkout article search: " + cases +
            " legacy route/SQL parity cases across 3 cultures, failures and repeated tab reads");
        return 0;
    }
}
