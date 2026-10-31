using System;
using System.Collections.Generic;
using System.Globalization;
using LOGICA.Domain;
using LOGICA.ApplicationLayer.Cash;
using LOGICA.ApplicationLayer.Clients;
using LOGICA.ApplicationLayer.Checkout;

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
        Console.WriteLine("PASS .NET 10 Linux core: cash, client settlement, checkout posting");
        return 0;
    }
}
