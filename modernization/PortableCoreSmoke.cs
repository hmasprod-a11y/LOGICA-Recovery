using System;
using System.Collections.Generic;
using System.Globalization;
using LOGICA.Domain;
using LOGICA.ApplicationLayer.Cash;
using LOGICA.ApplicationLayer.Clients;
using LOGICA.ApplicationLayer.Checkout;
using LOGICA.ApplicationLayer.Inventory;
using LOGICA.ApplicationLayer.Catalogue;
using System.Data;

internal static class PortableCoreSmoke
{
    private sealed class CashSemantics : ILegacyCashSemantics
    {
        public bool IsTrimmedEmpty(object value) { return value == null || value.ToString().Trim() == ""; }
        public bool IsNumeric(object value) { double d; return double.TryParse(Convert.ToString(value), out d); }
        public decimal ToDecimal(string text) { return decimal.Parse(text, CultureInfo.InvariantCulture); }
        public bool IsCashPaymentMode(object value) { return Object.Equals(value, "ESPECES"); }
    }
    private sealed class SettlementSemantics : ILegacySettlementSemantics
    {
        public bool IsEmpty(string value) { return value == ""; }
        public double ParseAmount(string value) { return double.Parse(value, CultureInfo.InvariantCulture); }
        public double ToDouble(object value) { return Convert.ToDouble(value, CultureInfo.InvariantCulture); }
    }
    private sealed class Fields : IClientSettlementValidationContext
    {
        public string ClientId { get { return "C1"; } }
        public string ClientName { get { return "Client"; } }
        public string Amount { get { return "15"; } }
        public string PaymentMode { get { return "ESPECES"; } }
    }
    private sealed class CashContext : ICashRecountContext
    {
        public decimal Total;
        public int Rows;
        public void ResetBackground() { }
        public object ReadSenderText() { return "1"; }
        public void ResetSender() { throw new Exception("Unexpected reset"); }
        public string ReadDenomination(int index) { return "1"; }
        public void DisplayTotal(decimal total) { Total = total; }
        public int LastPaymentIndex { get { return 0; } }
        public object ReadPaymentMode(int index) { return "ESPECES"; }
        public void DisplayCashRow(int index, decimal total) { Rows++; }
    }
    private sealed class Store : ICheckoutPostingStore
    {
        public readonly List<string> Calls = new List<string>();
        public void ApplyStock(CheckoutStockLine line) { Calls.Add("stock"); }
        public void WriteHeader(TicketHeaderRecord header) { Calls.Add("header"); }
        public void WriteJournal(TicketJournalRecord journal) { Calls.Add("journal"); }
        public void WritePayment(TicketPaymentWrite payment) { Calls.Add("payment"); }
        public void Complete(CheckoutCompletionRecord completion) { Calls.Add("complete"); }
    }
    private sealed class InventorySemantics : ILegacyStockMovementSemantics
    {
        public bool EqualsText(string left, string right)
        {
            return String.Equals(left ?? "", right ?? "", StringComparison.Ordinal);
        }
    }
    private sealed class InventorySearch : IStockMovementSearchContext
    {
        public readonly List<string> Calls = new List<string>();
        public string ColumnValue = "ARTICLE", TextValue = "x";
        public bool Dates, ExactValue;
        public string Column { get { Calls.Add("column"); return ColumnValue; } }
        public string Text { get { Calls.Add("text"); return TextValue; } }
        public bool UseDates { get { Calls.Add("dateFlag"); return Dates; } }
        public bool Exact { get { Calls.Add("exact"); return ExactValue; } }
        public void LoadDateRange() { Calls.Add("date"); }
        public void SetDatePrefix() { Calls.Add("prefix"); }
        public void ClearDatePrefix() { Calls.Add("clear"); }
        public void LoadContains() { Calls.Add("contains"); }
        public void LoadExactLike() { Calls.Add("exactLoad"); }
        public void BindResults() { Calls.Add("bind"); }
    }
    private sealed class InventoryRefresh : IStockMovementRefreshContext
    {
        public readonly List<string> Calls = new List<string>();
        public void FocusSender() { Calls.Add("sender"); }
        public void ClearSearch() { Calls.Add("clear"); }
        public void FocusSearch() { Calls.Add("focus"); }
        public void ReloadAll() { Calls.Add("reload"); }
        public void BindResults() { Calls.Add("bind"); }
    }
    private static void Require(bool condition, string description)
    {
        if (!condition) throw new Exception(description);
    }
    public static int Main()
    {
        var cash = new CashSemantics();
        Require(CashDenominationTotal.Calculate(delegate(int i) { return "1"; }, cash) == 388.8m, "Cash total changed");
        var cashContext = new CashContext();
        CashRecountService.Recount(cashContext, cash);
        Require(cashContext.Total == 388.8m && cashContext.Rows == 1, "Cash recount changed");

        var settlement = new SettlementSemantics();
        Require(ClientSettlementValidationService.FirstWarning(new Fields(), settlement) == null, "Settlement validation changed");
        int reads = 0;
        Require(ClientSettlementSequence.NextId(delegate { reads++; return 5; }, settlement) == 6 && reads == 2,
            "Settlement sequence changed");

        var store = new Store();
        CheckoutPostingService.Post(store, new CheckoutPostingInput {
            ReadStock = delegate { return new[] { new CheckoutStockLine() }; },
            ReadHeader = delegate { return new TicketHeaderRecord(); },
            ReadJournal = delegate { return new TicketJournalRecord(); },
            ReadPayments = delegate { return new[] { new TicketPaymentWrite() }; },
            Print = delegate { store.Calls.Add("print"); },
            ReadCompletion = delegate { return new CheckoutCompletionRecord(); }
        });
        Require(String.Join(",", store.Calls.ToArray()) == "stock,header,journal,payment,print,complete",
            "Checkout posting order changed");
        var inventorySemantics = new InventorySemantics();
        var byDate = new InventorySearch { ColumnValue = "DATES" };
        StockMovementSearchService.Search(byDate, inventorySemantics);
        Require(String.Join(",", byDate.Calls.ToArray()) == "column,date,bind", "Inventory date path changed");
        var byText = new InventorySearch { Dates = true, ExactValue = true };
        StockMovementSearchService.Search(byText, inventorySemantics);
        Require(String.Join(",", byText.Calls.ToArray()) == "column,text,dateFlag,prefix,exact,exact,exactLoad,bind",
            "Inventory exact text path changed");
        var noText = new InventorySearch { TextValue = "" };
        StockMovementSearchService.Search(noText, inventorySemantics);
        Require(String.Join(",", noText.Calls.ToArray()) == "column,text,bind", "Inventory empty path changed");
        var refresh = new InventoryRefresh();
        StockMovementRefreshService.Refresh(refresh);
        Require(String.Join(",", refresh.Calls.ToArray()) == "sender,clear,focus,reload,bind",
            "Inventory refresh order changed");

        var catalogue = new DataTable();
        catalogue.Columns.Add("Code", typeof(string));
        catalogue.Rows.Add("123");
        int checkedRows = 0, missedRows = 0;
        DataRow duplicate = CollectionDuplicatePrecheck.FindFirst(2,
            delegate(int index) { return index == 1 ? "123" : "missing"; },
            delegate(object code) { checkedRows++; return Object.Equals(code, "123") ? catalogue : catalogue.Clone(); },
            delegate { missedRows++; });
        Require(Object.ReferenceEquals(duplicate, catalogue.Rows[0]) && checkedRows == 2 && missedRows == 1,
            "Catalogue duplicate precheck changed");
        Require(PortableCatalogueSmoke.Run() == 0, "Catalogue creation portable smoke failed");
        Require(PortableCheckoutSmoke.Run() == 0, "Checkout validation and pricing portable smoke failed");
        Require(PortablePostingSmoke.Run() == 0, "Checkout posting portable smoke failed");
        Require(PortableTransactionSmoke.Run() == 0, "Checkout transaction finalization portable smoke failed");
        Require(PortableSqlSmoke.Run() == 0, "Portable SQL boundary smoke failed");
        Require(PortableTicketSequenceSmoke.Run() == 0, "Portable ticket sequence smoke failed");
        Require(PortableTicketPostingSmoke.Run() == 0, "Portable ticket posting smoke failed");
        Require(PortablePaymentModeSmoke.Run() == 0, "Portable payment modes smoke failed");
        Console.WriteLine("PASS .NET 10 Linux core: cash, client settlement, checkout posting, checkout validation/pricing, stock movement, catalogue creation and duplicate precheck");
        return 0;
    }
}
