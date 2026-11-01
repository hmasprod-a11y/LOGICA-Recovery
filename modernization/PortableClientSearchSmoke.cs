using System;
using LOGICA.Domain;
using LOGICA.ApplicationLayer.Clients;
using LOGICA.Infrastructure.Clients;

internal static class PortableClientSearchSmoke
{
    private sealed class Semantics : ILegacyClientSearchSemantics
    {
        public bool EqualsText(string left, string right) { return String.Equals(left, right, StringComparison.Ordinal); }
        public string FormatDate(DateTime date) { return date.ToString("yyyy-MM-dd"); }
        public object Concat(object left, object right) { return Convert.ToString(left) + Convert.ToString(right); }
        public string ToText(object value) { return Convert.ToString(value); }
    }
    private sealed class Context : IClientSettlementSearchContext, IClientSettlementRefreshContext, IClientSettlementFilterLayoutContext
    {
        public string Calls = "";
        public string Column { get { Calls += "C"; return "ARTICLE"; } }
        public bool UseDates { get { Calls += "D"; return true; } }
        public bool Exact { get { Calls += "E"; return false; } }
        public void LoadDateRange() { Calls += "R"; }
        public void SetDatePrefix() { Calls += "P"; }
        public void ClearDatePrefix() { Calls += "p"; }
        public void LoadContains() { Calls += "L"; }
        public void LoadExactLike() { Calls += "X"; }
        public void BindResults() { Calls += "B"; }
        public void ClearSearch() { Calls += "S"; }
        public void ReloadAll() { Calls += "A"; }
        public bool DateFilterChecked { get { Calls += "d"; return false; } }
        public string SelectedColumn { get { Calls += "c"; return "DATES"; } }
        public void SetDatePanelVisible(bool visible) { Calls += visible ? "V" : "v"; }
        public void SetDatePanelLeft(int left) { Calls += left == 78 ? "l" : "?"; }
        public void SetSearchText(string text) { Calls += text == "*" ? "T" : "?"; }
    }
    internal static void Verify()
    {
        var semantics = new Semantics();
        var context = new Context();
        ClientSettlementSearchService.Search(context, semantics);
        if (context.Calls != "CDPELB") throw new Exception("Portable client search flow changed: " + context.Calls);
        context.Calls = "";
        ClientSettlementRefreshService.Refresh(context);
        if (context.Calls != "SAB") throw new Exception("Portable client refresh changed");
        context.Calls = "";
        ClientSettlementFilterLayoutService.DateCheckboxChanged(context);
        ClientSettlementFilterLayoutService.ColumnChanged(context, semantics);
        if (context.Calls != "dvcVlT") throw new Exception("Portable client filter changed: " + context.Calls);
        string sql = ClientSettlementQueryText.Contains("CLIENTS_REGLE", "", "CLIENT", "x", semantics);
        if (sql.IndexOf("TABLE_CLIENTS_REGLE", StringComparison.Ordinal) < 0 ||
            sql.IndexOf("like  '%x%'", StringComparison.Ordinal) < 0)
            throw new Exception("Portable client SQL changed");
    }
}
