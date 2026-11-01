using System;
using System.Collections.Generic;
using LOGICA.ApplicationLayer.Clients;
using LOGICA.Domain;

internal static class ClientSettlementSearchFlowTests
{
    private sealed class TraceContext : IClientSettlementSearchContext, IClientSettlementRefreshContext,
        IClientSettlementFilterLayoutContext, ILegacyClientSearchSemantics
    {
        internal readonly List<string> Calls = new List<string>();
        internal readonly Exception Failure = new InvalidOperationException("injected failure");
        internal int FailAt;
        internal bool Dates, ExactFlag, Checked, Reenter;
        internal string Selected = "ARTICLE";
        internal bool Visible;
        internal int Left = 11;
        internal string SearchText = "old";
        internal void Step(string call)
        {
            Calls.Add(call);
            if (FailAt == Calls.Count) throw Failure;
        }
        public string Column { get { Step("column"); return Selected; } }
        public bool UseDates { get { Step("useDates"); return Dates; } }
        public bool Exact { get { Step("exact"); return ExactFlag; } }
        public void LoadDateRange() { Step("dateRange"); }
        public void SetDatePrefix() { Step("datePrefix"); }
        public void ClearDatePrefix() { Step("clearPrefix"); }
        public void LoadContains() { Step("contains"); }
        public void LoadExactLike() { Step("exactLike"); }
        public void BindResults() { Step("bind"); }
        public void ClearSearch()
        {
            Step("clearSearch");
            SearchText = "";
            if (Reenter) Step("textChanged->search");
        }
        public void ReloadAll() { Step("reloadAll"); }
        public bool DateFilterChecked { get { Step("dateChecked"); return Checked; } }
        public string SelectedColumn { get { Step("selectedColumn"); return Selected; } }
        public void SetDatePanelVisible(bool visible) { Step("visible:" + visible); Visible = visible; }
        public void SetDatePanelLeft(int left) { Step("left:" + left); Left = left; }
        public void SetSearchText(string text)
        {
            Step("text:" + text);
            SearchText = text;
            if (Reenter) Step("textChanged->search");
        }
        public bool EqualsText(string left, string right)
        {
            Step("compare:" + right);
            return String.Equals(left, right, StringComparison.Ordinal);
        }
        public string FormatDate(DateTime date) { throw new NotSupportedException(); }
        public object Concat(object left, object right) { throw new NotSupportedException(); }
        public string ToText(object value) { throw new NotSupportedException(); }
    }

    // Independent copies of original Form_5_CLIENTS_REGLE event bodies.
    private static void OriginalSearch(TraceContext c)
    {
        if (c.EqualsText(c.Column, "DATES"))
            c.LoadDateRange();
        else
        {
            if (c.UseDates) c.SetDatePrefix();
            else c.ClearDatePrefix();
            if (!c.Exact) c.LoadContains();
            else if (c.Exact) c.LoadExactLike();
        }
        c.BindResults();
    }
    private static void OriginalRefresh(TraceContext c)
    {
        c.ClearSearch();
        c.ReloadAll();
        c.BindResults();
    }
    private static void OriginalDateCheck(TraceContext c)
    {
        if (c.DateFilterChecked) c.SetDatePanelVisible(true);
        else c.SetDatePanelVisible(false);
    }
    private static void OriginalColumnChange(TraceContext c)
    {
        if (c.EqualsText(c.SelectedColumn, "DATES"))
        {
            c.SetDatePanelVisible(true);
            c.SetDatePanelLeft(78);
            c.SetSearchText("*");
        }
        else
        {
            c.SetDatePanelVisible(false);
            c.SetDatePanelLeft(417);
            c.SetSearchText("");
        }
    }
    private static int assertions;
    private static void Check(int kind, string column, bool dates, bool exact, bool reenter, int failAt)
    {
        var original = new TraceContext { Selected = column, Dates = dates, ExactFlag = exact,
            Checked = dates, Reenter = reenter, FailAt = failAt };
        var extracted = new TraceContext { Selected = column, Dates = dates, ExactFlag = exact,
            Checked = dates, Reenter = reenter, FailAt = failAt };
        Exception first = null, second = null;
        try
        {
            if (kind == 0) OriginalSearch(original);
            else if (kind == 1) OriginalRefresh(original);
            else if (kind == 2) OriginalDateCheck(original);
            else OriginalColumnChange(original);
        }
        catch (Exception ex) { first = ex; }
        try
        {
            if (kind == 0) ClientSettlementSearchService.Search(extracted, extracted);
            else if (kind == 1) ClientSettlementRefreshService.Refresh(extracted);
            else if (kind == 2) ClientSettlementFilterLayoutService.DateCheckboxChanged(extracted);
            else ClientSettlementFilterLayoutService.ColumnChanged(extracted, extracted);
        }
        catch (Exception ex) { second = ex; }
        if (String.Join("|", original.Calls.ToArray()) != String.Join("|", extracted.Calls.ToArray()))
            throw new Exception("Call order changed in " + kind + ": " +
                String.Join("|", original.Calls.ToArray()) + " / " + String.Join("|", extracted.Calls.ToArray()));
        assertions++;
        if (original.Visible != extracted.Visible || original.Left != extracted.Left ||
            original.SearchText != extracted.SearchText)
            throw new Exception("Partial state changed in " + kind);
        assertions++;
        if ((first == null) != (second == null) ||
            (first != null && (!Object.ReferenceEquals(first, original.Failure) ||
                               !Object.ReferenceEquals(second, extracted.Failure))))
            throw new Exception("Exception identity or propagation changed in " + kind);
        assertions++;
    }
    public static int Main()
    {
        string[] columns = { "DATES", "dates", "ARTICLE", "", null, "CLIENT" };
        for (int kind = 0; kind < 4; kind++)
            foreach (string column in columns)
                foreach (bool dates in new[] { false, true })
                    foreach (bool exact in new[] { false, true })
                        foreach (bool reenter in new[] { false, true })
                            for (int failure = 0; failure <= 9; failure++)
                                Check(kind, column, dates, exact, reenter, failure);
        Console.WriteLine("PASS: " + assertions + " client settlement search/refresh/filter characterization assertions");
        return 0;
    }
}
