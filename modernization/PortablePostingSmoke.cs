using System;
using System.Collections.Generic;
using LOGICA.ApplicationLayer.Checkout;

internal static class PortablePostingSmoke
{
    private sealed class Store : ICheckoutPostingStore
    {
        internal readonly List<string> Events = new List<string>();
        internal bool FailSecondPayment;
        public void ApplyStock(CheckoutStockLine line) { Events.Add("stock:" + line.ArticleCode); }
        public void WriteHeader(TicketHeaderRecord header) { Events.Add("header"); }
        public void WriteJournal(TicketJournalRecord journal) { Events.Add("journal"); }
        public void WritePayment(TicketPaymentWrite payment)
        {
            Events.Add("payment:" + payment.AmountText);
            if (FailSecondPayment && payment.AmountText == "2") throw new InvalidOperationException("payment");
        }
        public void Complete(CheckoutCompletionRecord completion) { Events.Add("complete"); }
    }
    private static IEnumerable<CheckoutStockLine> Stocks()
    {
        yield return new CheckoutStockLine { ArticleCode = "A" };
        yield return new CheckoutStockLine { ArticleCode = "B" };
    }
    private static IEnumerable<TicketPaymentWrite> Payments()
    {
        yield return Payment("1");
        yield return Payment("2");
    }
    private static TicketPaymentWrite Payment(string amount)
    {
        return new TicketPaymentWrite {
            Kind = TicketPaymentKind.Cash,
            Context = new TicketPaymentContext { TicketId = "portable-posting", TicketNumber = "1", SaleDate = new DateTime(2026, 1, 1), Cashier = "portable-posting", ClientId = "0", ClientCode = "0", ClientName = "Client", Workstation = "01", Operation = "VENTE", Remark = "" },
            AmountText = amount
        };
    }
    private static CheckoutPostingInput Input(Store store)
    {
        return new CheckoutPostingInput {
            ReadStock = delegate { store.Events.Add("readStock"); return Stocks(); },
            ReadHeader = delegate { store.Events.Add("readHeader"); return new TicketHeaderRecord(); },
            ReadJournal = delegate { store.Events.Add("readJournal"); return new TicketJournalRecord(); },
            ReadPayments = delegate { store.Events.Add("readPayments"); return Payments(); },
            Print = delegate { store.Events.Add("print"); },
            ReadCompletion = delegate { store.Events.Add("readCompletion"); return new CheckoutCompletionRecord(); }
        };
    }
    private static void Assert(Store store, string expected)
    {
        string actual = String.Join(",", store.Events.ToArray());
        if (actual != expected) throw new Exception("Portable posting order: " + actual + " expected " + expected);
    }
    public static int Run()
    {
        var success = new Store();
        CheckoutPostingService.Post(success, Input(success));
        Assert(success, "readStock,stock:A,stock:B,readHeader,header,readJournal,journal,readPayments,payment:1,payment:2,print,readCompletion,complete");

        var failed = new Store { FailSecondPayment = true };
        bool propagated = false;
        try { CheckoutPostingService.Post(failed, Input(failed)); }
        catch (InvalidOperationException ex) { propagated = ex.Message == "payment"; }
        if (!propagated) throw new Exception("Payment failure must propagate to the caller-owned transaction");
        Assert(failed, "readStock,stock:A,stock:B,readHeader,header,readJournal,journal,readPayments,payment:1,payment:2");
        var invalid = new Store();
        var invalidInput = Input(invalid);
        invalidInput.ReadPayments = delegate { invalid.Events.Add("readPayments"); return new[] { new TicketPaymentWrite { Kind = TicketPaymentKind.Cash, AmountText = "1" } }; };
        bool missingContextRejected = false;
        try { CheckoutPostingService.Post(invalid, invalidInput); }
        catch (InvalidOperationException ex) { missingContextRejected = ex.Message == "Checkout payment line has no context."; }
        if (!missingContextRejected) throw new Exception("Checkout payment without context must fail closed.");
        Assert(invalid, "readStock,stock:A,stock:B,readHeader,header,readJournal,journal,readPayments");
        Console.WriteLine("PASS portable checkout posting: ordered stock/ticket/payment, missing context denial, failure before print and completion");
        return 0;
    }
}
