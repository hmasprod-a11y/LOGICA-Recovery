using System;
using System.Collections.Generic;
using LOGICA.ApplicationLayer.Checkout;

internal static class PortablePostingSmoke
{
    private sealed class Store : ICheckoutPostingStore
    {
        internal readonly List<string> Events = new List<string>();
        internal bool FailSecondPayment;
        internal int PaymentCount;
        internal int StockCount;
        internal TicketPaymentWrite LastPayment;
        internal CheckoutStockLine LastStock;
        public void ApplyStock(CheckoutStockLine line) { StockCount++; LastStock = line; Events.Add("stock:" + line.ArticleCode); }
        public void WriteHeader(TicketHeaderRecord header) { Events.Add("header"); }
        public void WriteJournal(TicketJournalRecord journal) { Events.Add("journal"); }
        public void WritePayment(TicketPaymentWrite payment)
        {
            PaymentCount++;
            LastPayment = payment;
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
        yield return new TicketPaymentWrite { AmountText = "1" };
        yield return new TicketPaymentWrite { AmountText = "2" };
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

    // Real production posting pipeline, with the one-cash-payment shape passed
    // by the WinForms SOLDER handler. Fake store: no shop database is touched.
    private static CheckoutPostingInput SingleCashInput(Store store, string quantity, string amount)
    {
        return new CheckoutPostingInput {
            ReadStock = delegate {
                store.Events.Add("readStock");
                return new[] { new CheckoutStockLine {
                    ArticleCode = "CASH-ITEM", ArticleId = "ARTICLE-1",
                    BasketQuantity = quantity, TicketNumber = "T-1" } };
            },
            ReadHeader = delegate { store.Events.Add("readHeader"); return new TicketHeaderRecord {
                TicketNumber = "T-1", Operation = quantity == "-1" ? "RETOUR REMBOURSEMENT" : "VENTE" }; },
            ReadJournal = delegate { store.Events.Add("readJournal"); return new TicketJournalRecord {
                TicketNumber = "T-1" }; },
            ReadPayments = delegate {
                store.Events.Add("readPayments");
                return new[] { new TicketPaymentWrite {
                    Kind = TicketPaymentKind.Cash, AmountText = amount,
                    Context = new TicketPaymentContext { TicketNumber = "T-1" } } };
            },
            Print = delegate { store.Events.Add("print"); },
            ReadCompletion = delegate { store.Events.Add("readCompletion");
                return new CheckoutCompletionRecord { TicketNumber = "T-1" }; }
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

        // P0 cash SOLDER regression: exactly one stock line and one cash
        // payment, followed by completion; never a second payment/stock write.
        var cash = new Store();
        CheckoutPostingService.Post(cash, SingleCashInput(cash, "1", "10.00"));
        Assert(cash, "readStock,stock:CASH-ITEM,readHeader,header,readJournal,journal,readPayments,payment:10.00,print,readCompletion,complete");
        if (cash.StockCount != 1 || cash.PaymentCount != 1 ||
            cash.LastPayment.Kind != TicketPaymentKind.Cash ||
            cash.LastPayment.Context.TicketNumber != "T-1" ||
            Convert.ToString(cash.LastStock.BasketQuantity) != "1")
            throw new Exception("Single cash SOLDER must post one stock line and one cash payment");
        var refund = new Store();
        CheckoutPostingService.Post(refund, SingleCashInput(refund, "-1", "-10.00"));
        if (refund.StockCount != 1 || refund.PaymentCount != 1 ||
            Convert.ToString(refund.LastStock.BasketQuantity) != "-1" ||
            refund.LastPayment.AmountText != "-10.00")
            throw new Exception("Cash refund must preserve negative stock/payment signs");

        // A missing late callback used to fail only AFTER stock and payment
        // writes. Reject it before the first mutation, without eagerly reading
        // any valid callback or changing the legacy success order.
        var incomplete = new Store();
        CheckoutPostingInput invalid = Input(incomplete);
        invalid.ReadCompletion = null;
        bool rejected = false;
        try { CheckoutPostingService.Post(incomplete, invalid); }
        catch (InvalidOperationException ex) {
            rejected = ex.Message == "Checkout posting requires all callbacks before stock writes.";
        }
        if (!rejected) throw new Exception("Missing completion callback must fail before stock");
        Assert(incomplete, "");
        invalid = Input(incomplete);
        invalid.ReadPayments = null;
        rejected = false;
        try { CheckoutPostingService.Post(incomplete, invalid); }
        catch (InvalidOperationException) { rejected = true; }
        if (!rejected) throw new Exception("Missing payment callback must fail before stock");
        Assert(incomplete, "");
        rejected = false;
        try { CheckoutPostingService.Post(null, Input(incomplete)); }
        catch (ArgumentNullException ex) { rejected = ex.ParamName == "store"; }
        if (!rejected) throw new Exception("Null posting store must fail before readers");
        Assert(incomplete, "");
        Console.WriteLine("PASS portable checkout posting: ordered stock/ticket/payment, failure before print and completion; one cash sale/refund and fail-fast callback safety");
        return 0;
    }
}
