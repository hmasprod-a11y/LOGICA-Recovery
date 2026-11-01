using System;
using System.Collections.Generic;
using LOGICA.Domain;
using LOGICA.ApplicationLayer.Cash;

internal static class CashCompatibilityPortTests
{
    private sealed class Spy : ILegacyCashSemantics
    {
        public readonly List<string> Calls = new List<string>();
        public bool Empty, Numeric = true, Match = true;
        public Exception Failure;
        public bool IsTrimmedEmpty(object value) { Calls.Add("empty"); return Empty; }
        public bool IsNumeric(object value) { Calls.Add("numeric"); return Numeric; }
        public decimal ToDecimal(string value)
        {
            Calls.Add("decimal:" + value);
            if (Failure != null) throw Failure;
            return decimal.Parse(value);
        }
        public bool IsCashPaymentMode(object value) { Calls.Add("mode:" + value); return Match; }
    }

    private sealed class Context : ICashRecountContext
    {
        public readonly List<string> Calls = new List<string>();
        public void ResetBackground() { Calls.Add("background"); }
        public object ReadSenderText() { Calls.Add("sender"); return "1"; }
        public void ResetSender() { Calls.Add("reset"); }
        public string ReadDenomination(int index) { Calls.Add("count" + index); return "1"; }
        public void DisplayTotal(decimal total) { Calls.Add("total:" + total); }
        public int LastPaymentIndex { get { Calls.Add("last"); return 1; } }
        public object ReadPaymentMode(int index) { Calls.Add("mode" + index); return "ESPECES"; }
        public void DisplayCashRow(int index, decimal total) { Calls.Add("row" + index); }
    }

    private static void Require(bool ok, string message) { if (!ok) throw new Exception(message); }

    public static int Main()
    {
        var spy = new Spy { Empty = true, Numeric = true };
        int reads = 0;
        Require(CashCountInputRules.ShouldReset(delegate { reads++; return "1"; }, spy), "Injected empty rule ignored");
        Require(reads == 2 && String.Join(",", spy.Calls.ToArray()) == "empty,numeric", "Eager double read changed");
        spy = new Spy { Empty = false, Numeric = false };
        Require(CashCountInputRules.ShouldReset(delegate { return "x"; }, spy), "Injected numeric rule ignored");
        spy = new Spy { Empty = false, Numeric = true };
        Require(!CashCountInputRules.ShouldReset(delegate { return "1"; }, spy), "Valid numeric count reset");

        spy = new Spy();
        var order = new List<int>();
        decimal total = CashDenominationTotal.Calculate(delegate(int index) { order.Add(index); return "1"; }, spy);
        Require(total == 388.8m && order.Count == 11 && spy.Calls.Count == 11, "Cash denominations not injected exactly once each");
        for (int i = 0; i < 11; i++) Require(order[i] == i, "Denomination order changed");

        spy = new Spy();
        var marker = new InvalidOperationException("conversion");
        spy.Failure = marker;
        Exception caught = null;
        try { CashDenominationTotal.Calculate(delegate(int index) { return "1"; }, spy); }
        catch (Exception e) { caught = e; }
        Require(Object.ReferenceEquals(marker, caught) && spy.Calls.Count == 1, "Conversion exception was wrapped or ignored");

        spy = new Spy { Match = false };
        var context = new Context();
        CashRecountService.Recount(context, spy);
        Require(!context.Calls.Contains("row0") && !context.Calls.Contains("row1"), "Cash payment mode port ignored");
        Require(spy.Calls.Count == 15 && spy.Calls[13] == "mode:ESPECES" && spy.Calls[14] == "mode:ESPECES",
            "Recount failed to use injected cash mode matching");
        spy = new Spy { Match = true };
        context = new Context();
        CashRecountService.Recount(context, spy);
        Require(context.Calls.Contains("row0") && context.Calls.Contains("row1"), "Matching cash rows not written");
        Console.WriteLine("PASS cash Domain/Application isolated from Visual Basic, WinForms and database");
        return 0;
    }
}
