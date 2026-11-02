using System;
using System.Collections.Generic;
using LOGICA.ApplicationLayer.Checkout;
using LOGICA.Domain;

internal static class PortablePostingSmoke
{
    private sealed class Store : ICheckoutPostingStore, ICheckoutTransactionFinalizer
    {
        internal readonly List<string> Events = new List<string>();
        internal bool FailSecondPayment;
        internal int PaymentCount;
        internal int CommitCount;
        internal int CloseCount;
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
        public void Commit() { CommitCount++; Events.Add("commit"); }
        public void Close() { CloseCount++; Events.Add("close"); }
    }
    private static IEnumerable<CheckoutStockLine> Stocks()
    {
        yield return new CheckoutStockLine { ArticleCode = "A" };
        yield return new CheckoutStockLine { ArticleCode = "B" };
    }
    private static IEnumerable<TicketPaymentWrite> Payments()
    {
        yield return new TicketPaymentWrite {
            AmountText = "1", Context = new TicketPaymentContext { TicketNumber = "T-1" } };
        yield return new TicketPaymentWrite {
            AmountText = "2", Context = new TicketPaymentContext { TicketNumber = "T-1" } };
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
    // Compose the real production payment reader with the real posting and
    // transaction-finalization services. The store is deliberately fake:
    // this verifies exact-once cash/refund semantics without shop DB writes.
    private sealed class PaymentSemantics : ILegacyCheckoutPaymentReadSemantics
    {
        public int CompareOperation(string actual, string expected)
        {
            return String.CompareOrdinal(actual, expected);
        }
        public bool IsNegativeChange(string value)
        {
            return value != null && value.StartsWith("-", StringComparison.Ordinal);
        }
    }

    private static CheckoutPostingInput ProjectedCashInput(
        Store store, string operation, string quantity, string amount,
        bool missingContext)
    {
        CheckoutPostingInput input = SingleCashInput(store, quantity, amount);
        input.ReadPayments = delegate {
            store.Events.Add("readPayments");
            return CheckoutPaymentReadService.Read(
                delegate { store.Events.Add("operation"); return operation; },
                delegate {
                    store.Events.Add("context");
                    return missingContext ? null :
                        new TicketPaymentContext { TicketNumber = "T-1" };
                },
                delegate { store.Events.Add("access"); return false; },
                delegate { throw new Exception("Cash sale must not read tender count"); },
                delegate(int index) { throw new Exception("Cash sale must not read tender amount"); },
                delegate(int index) { throw new Exception("Cash sale must not read tender mode"); },
                delegate { store.Events.Add("cash"); return amount; },
                delegate { throw new Exception("Cash sale must not read change"); },
                new PaymentSemantics());
        };
        return input;
    }

    // Exercise the actual payment-grid projection, not only a hand-built
    // TicketPaymentWrite. The modal supplies a single selected tender method.
    private static CheckoutPostingInput ProjectedTenderInput(Store store, object mode)
    {
        CheckoutPostingInput input = SingleCashInput(store, "1", "10.00");
        input.ReadPayments = delegate {
            store.Events.Add("readPayments");
            return CheckoutPaymentReadService.Read(
                delegate { store.Events.Add("operation"); return "VENTE"; },
                delegate { store.Events.Add("context");
                    return new TicketPaymentContext { TicketNumber = "T-1" }; },
                delegate { store.Events.Add("access"); return true; },
                delegate { store.Events.Add("count"); return 1; },
                delegate(int index) { store.Events.Add("paid" + index); return "10.00"; },
                delegate(int index) { store.Events.Add("mode" + index); return mode; },
                delegate { throw new Exception("Tendered sale must not read cash total"); },
                delegate { store.Events.Add("change"); return "0"; },
                new PaymentSemantics());
        };
        return input;
    }

    private static void Assert(Store store, string expected)
    {
        string actual = String.Join(",", store.Events.ToArray());
        if (actual != expected) throw new Exception("Portable posting order: " + actual + " expected " + expected);
    }
    private static void CheckInvalidReader(Store store, CheckoutPostingInput input, string message, string expected)
    {
        bool rejected = false;
        try { CheckoutTransactionFinalizationService.PostAndFinalize(store, input, store); }
        catch (InvalidOperationException ex) { rejected = ex.Message == message; }
        catch (NullReferenceException ex) { rejected = ex.Message == message; }
        if (!rejected) throw new Exception("Malformed checkout reader must fail at its original stage: " + message);
        Assert(store, expected);
        if (store.CommitCount != 0 || store.CloseCount != 0)
            throw new Exception("Malformed checkout reader must not commit or close: " + message);
    }
    public static int Run()
    {
        var success = new Store();
        CheckoutPostingService.Post(success, Input(success));
        Assert(success, "readStock,stock:A,stock:B,readHeader,header,readJournal,journal,readPayments,payment:1,payment:2,print,readCompletion,complete");

        var failed = new Store { FailSecondPayment = true };
        bool propagated = false;
        try { CheckoutTransactionFinalizationService.PostAndFinalize(failed, Input(failed), failed); }
        catch (InvalidOperationException ex) { propagated = ex.Message == "payment"; }
        if (!propagated) throw new Exception("Payment failure must propagate to the caller-owned transaction");
        Assert(failed, "readStock,stock:A,stock:B,readHeader,header,readJournal,journal,readPayments,payment:1,payment:2");
        if (failed.CommitCount != 0 || failed.CloseCount != 0)
            throw new Exception("Failed cash posting must not commit or close transaction");

        // P0 cash SOLDER regression: exactly one stock line and one cash
        // payment, followed by completion; never a second payment/stock write.
        var cash = new Store();
        CheckoutTransactionFinalizationService.PostAndFinalize(cash, SingleCashInput(cash, "1", "10.00"), cash);
        Assert(cash, "readStock,stock:CASH-ITEM,readHeader,header,readJournal,journal,readPayments,payment:10.00,print,readCompletion,complete,commit,close");
        if (cash.StockCount != 1 || cash.PaymentCount != 1 ||
            cash.LastPayment.Kind != TicketPaymentKind.Cash ||
            cash.LastPayment.Context.TicketNumber != "T-1" ||
            cash.CommitCount != 1 || cash.CloseCount != 1 ||
            Convert.ToString(cash.LastStock.BasketQuantity) != "1")
            throw new Exception("Single cash SOLDER must post one stock line and one cash payment");
        var refund = new Store();
        CheckoutTransactionFinalizationService.PostAndFinalize(refund, SingleCashInput(refund, "-1", "-10.00"), refund);
        if (refund.StockCount != 1 || refund.PaymentCount != 1 ||
            Convert.ToString(refund.LastStock.BasketQuantity) != "-1" ||
            refund.LastPayment.AmountText != "-10.00" ||
            refund.CommitCount != 1 || refund.CloseCount != 1)
            throw new Exception("Cash refund must preserve negative stock/payment signs");

        // P0: the *production* payment projection must post exactly one cash
        // row through the posting/finalization pipeline for both signs.
        var projectedSale = new Store();
        CheckoutTransactionFinalizationService.PostAndFinalize(projectedSale,
            ProjectedCashInput(projectedSale, "VENTE", "1", "12.35", false),
            projectedSale);
        Assert(projectedSale,
            "readStock,stock:CASH-ITEM,readHeader,header,readJournal,journal,readPayments,operation,context,access,cash,payment:12.35,print,readCompletion,complete,commit,close");
        if (projectedSale.StockCount != 1 || projectedSale.PaymentCount != 1 ||
            projectedSale.LastPayment.Kind != TicketPaymentKind.Cash ||
            projectedSale.LastPayment.Context.TicketNumber != "T-1" ||
            projectedSale.LastPayment.AmountText != "12.35" ||
            projectedSale.CommitCount != 1 || projectedSale.CloseCount != 1)
            throw new Exception("Projected cash sale must write stock/payment once");

        var projectedRefund = new Store();
        CheckoutTransactionFinalizationService.PostAndFinalize(projectedRefund,
            ProjectedCashInput(projectedRefund, "RETOUR REMBOURSEMENT", "-1", "-12.35", false),
            projectedRefund);
        Assert(projectedRefund,
            "readStock,stock:CASH-ITEM,readHeader,header,readJournal,journal,readPayments,operation,operation,context,access,cash,payment:-12.35,print,readCompletion,complete,commit,close");
        if (projectedRefund.StockCount != 1 || projectedRefund.PaymentCount != 1 ||
            projectedRefund.LastPayment.Kind != TicketPaymentKind.Cash ||
            projectedRefund.LastPayment.AmountText != "-12.35" ||
            Convert.ToString(projectedRefund.LastStock.BasketQuantity) != "-1" ||
            projectedRefund.CommitCount != 1 || projectedRefund.CloseCount != 1)
            throw new Exception("Projected cash refund must preserve the negative sign");

        var missingPaymentContext = new Store();
        CheckInvalidReader(missingPaymentContext,
            ProjectedCashInput(missingPaymentContext, "VENTE", "1", "12.35", true),
            "Checkout payment context reader returned null.",
            "readStock,stock:CASH-ITEM,readHeader,header,readJournal,journal,readPayments,operation,context");
        if (missingPaymentContext.PaymentCount != 0 || missingPaymentContext.StockCount != 1)
            throw new Exception("Missing payment context must not write any cash payment");

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

        // P0: malformed UI-derived payment and ticket readers must fail with
        // actionable errors, never a NullReferenceException or a committed sale.
        // Readers remain lazy and previous successful stock/payment writes are
        // still the responsibility of the caller-owned transaction rollback.
        var noStock = new Store();
        var noStockInput = Input(noStock);
        noStockInput.ReadStock = delegate { noStock.Events.Add("readStock"); return null; };
        CheckInvalidReader(noStock, noStockInput,
            "Checkout stock reader returned no collection.", "readStock");

        var nullStockLine = new Store();
        var nullStockInput = Input(nullStockLine);
        nullStockInput.ReadStock = delegate { nullStockLine.Events.Add("readStock"); return new CheckoutStockLine[] { null }; };
        CheckInvalidReader(nullStockLine, nullStockInput,
            "Checkout stock reader returned a null line.", "readStock");

        var noHeader = new Store();
        var noHeaderInput = Input(noHeader);
        noHeaderInput.ReadHeader = delegate { noHeader.Events.Add("readHeader"); return null; };
        CheckInvalidReader(noHeader, noHeaderInput,
            "Checkout header reader returned null.", "readStock,stock:A,stock:B,readHeader");

        var noJournal = new Store();
        var noJournalInput = Input(noJournal);
        noJournalInput.ReadJournal = delegate { noJournal.Events.Add("readJournal"); return null; };
        CheckInvalidReader(noJournal, noJournalInput,
            "Checkout journal reader returned null.", "readStock,stock:A,stock:B,readHeader,header,readJournal");

        var noPayments = new Store();
        var noPaymentsInput = Input(noPayments);
        noPaymentsInput.ReadPayments = delegate { noPayments.Events.Add("readPayments"); return null; };
        CheckInvalidReader(noPayments, noPaymentsInput,
            "Checkout payment reader returned no collection.",
            "readStock,stock:A,stock:B,readHeader,header,readJournal,journal,readPayments");

        var nullPayment = new Store();
        var nullPaymentInput = Input(nullPayment);
        nullPaymentInput.ReadPayments = delegate { nullPayment.Events.Add("readPayments"); return new TicketPaymentWrite[] { null }; };
        CheckInvalidReader(nullPayment, nullPaymentInput,
            "Checkout payment reader returned a null line.",
            "readStock,stock:A,stock:B,readHeader,header,readJournal,journal,readPayments");

        // SOLDER P0: callers can supply payment rows without going through
        // CheckoutPaymentReadService. Guard the actual SQL writer boundary too.
        // A missing context or selected tender mode must never reach WritePayment.
        var missingDirectContext = new Store();
        var missingDirectContextInput = Input(missingDirectContext);
        missingDirectContextInput.ReadPayments = delegate {
            missingDirectContext.Events.Add("readPayments");
            return new[] { new TicketPaymentWrite {
                Kind = TicketPaymentKind.Cash, AmountText = "10.00" } };
        };
        CheckInvalidReader(missingDirectContext, missingDirectContextInput,
            "Checkout payment line has no context.",
            "readStock,stock:A,stock:B,readHeader,header,readJournal,journal,readPayments");
        if (missingDirectContext.PaymentCount != 0)
            throw new Exception("Missing direct cash context reached the payment SQL writer");

        var missingTenderMode = new Store();
        var missingTenderModeInput = Input(missingTenderMode);
        missingTenderModeInput.ReadPayments = delegate {
            missingTenderMode.Events.Add("readPayments");
            return new[] { new TicketPaymentWrite {
                Kind = TicketPaymentKind.Tendered, Amount = "10.00",
                Context = new TicketPaymentContext { TicketNumber = "T-1" } } };
        };
        CheckInvalidReader(missingTenderMode, missingTenderModeInput,
            "Checkout tendered payment has no mode.",
            "readStock,stock:A,stock:B,readHeader,header,readJournal,journal,readPayments");
        if (missingTenderMode.PaymentCount != 0)
            throw new Exception("Missing tender mode reached the payment SQL writer");

        // A valid non-cash payment must still post exactly once in the
        // original stock -> ticket -> payment -> print -> commit sequence.
        var validTender = new Store();
        var validTenderInput = Input(validTender);
        validTenderInput.ReadPayments = delegate {
            validTender.Events.Add("readPayments");
            return new[] { new TicketPaymentWrite {
                Kind = TicketPaymentKind.Tendered, Amount = "10.00", Mode = "CARTE",
                Context = new TicketPaymentContext { TicketNumber = "T-1" } } };
        };
        CheckoutTransactionFinalizationService.PostAndFinalize(
            validTender, validTenderInput, validTender);
        Assert(validTender,
            "readStock,stock:A,stock:B,readHeader,header,readJournal,journal,readPayments,payment:,print,readCompletion,complete,commit,close");
        if (validTender.PaymentCount != 1 || validTender.StockCount != 2 ||
            validTender.LastPayment.Mode.ToString() != "CARTE" ||
            validTender.CommitCount != 1 || validTender.CloseCount != 1)
            throw new Exception("Valid tender posting changed exact-once semantics");

        // Streaming is intentional: a later malformed row must abort before
        // printing/commit, leaving rollback to the WinForms transaction owner.
        var lateInvalidTender = new Store();
        var lateInvalidTenderInput = Input(lateInvalidTender);
        lateInvalidTenderInput.ReadPayments = delegate {
            lateInvalidTender.Events.Add("readPayments");
            return new[] {
                new TicketPaymentWrite { Kind = TicketPaymentKind.Cash,
                    AmountText = "5.00", Context = new TicketPaymentContext { TicketNumber = "T-1" } },
                new TicketPaymentWrite { Kind = TicketPaymentKind.Tendered,
                    Amount = "5.00", Context = new TicketPaymentContext { TicketNumber = "T-1" } }
            };
        };
        CheckInvalidReader(lateInvalidTender, lateInvalidTenderInput,
            "Checkout tendered payment has no mode.",
            "readStock,stock:A,stock:B,readHeader,header,readJournal,journal,readPayments,payment:5.00");
        if (lateInvalidTender.PaymentCount != 1)
            throw new Exception("Streaming payment validation changed original row order");

        // The production grid reader must preserve its lazy access order,
        // and the posting writer must reject a blank mode before SQL/commit.
        var projectedBlankMode = new Store();
        CheckInvalidReader(projectedBlankMode,
            ProjectedTenderInput(projectedBlankMode, null),
            "Checkout tendered payment has no mode.",
            "readStock,stock:CASH-ITEM,readHeader,header,readJournal,journal,readPayments,operation,context,access,access,count,paid0,mode0");
        if (projectedBlankMode.PaymentCount != 0 ||
            projectedBlankMode.CommitCount != 0 || projectedBlankMode.CloseCount != 0)
            throw new Exception("Blank payment-grid mode must not reach SQL or commit");

        // Desktop's incomplete rows may contain DBNull.Value or a whitespace
        // caption, not only null. All are invalid payment methods.
        var projectedDbNullMode = new Store();
        CheckInvalidReader(projectedDbNullMode,
            ProjectedTenderInput(projectedDbNullMode, DBNull.Value),
            "Checkout tendered payment has no mode.",
            "readStock,stock:CASH-ITEM,readHeader,header,readJournal,journal,readPayments,operation,context,access,access,count,paid0,mode0");
        if (projectedDbNullMode.PaymentCount != 0)
            throw new Exception("DBNull payment-grid mode reached the SQL writer");
        var projectedWhitespaceMode = new Store();
        CheckInvalidReader(projectedWhitespaceMode,
            ProjectedTenderInput(projectedWhitespaceMode, "   "),
            "Checkout tendered payment has no mode.",
            "readStock,stock:CASH-ITEM,readHeader,header,readJournal,journal,readPayments,operation,context,access,access,count,paid0,mode0");
        if (projectedWhitespaceMode.PaymentCount != 0)
            throw new Exception("Whitespace payment-grid mode reached the SQL writer");

        var projectedCard = new Store();
        CheckoutTransactionFinalizationService.PostAndFinalize(projectedCard,
            ProjectedTenderInput(projectedCard, "CARTE"), projectedCard);
        Assert(projectedCard,
            "readStock,stock:CASH-ITEM,readHeader,header,readJournal,journal,readPayments,operation,context,access,access,count,paid0,mode0,payment:,change,print,readCompletion,complete,commit,close");
        if (projectedCard.PaymentCount != 1 || projectedCard.StockCount != 1 ||
            projectedCard.LastPayment.Kind != TicketPaymentKind.Tendered ||
            projectedCard.LastPayment.Mode.ToString() != "CARTE" ||
            projectedCard.CommitCount != 1 || projectedCard.CloseCount != 1)
            throw new Exception("Projected tender sale must post exactly once");

        // A blank amount in the real SOLDER grid is not a zero-valued sale.
        // Validate the actual SQL writer boundary before printing/commit, even
        // when a caller bypasses the payment projection and supplies records.
        foreach (string invalidCashAmount in new string[] { null, "", "  " })
        {
            var blankCash = new Store();
            var blankCashInput = SingleCashInput(blankCash, "1", invalidCashAmount);
            CheckInvalidReader(blankCash, blankCashInput,
                "Checkout cash/change payment has no amount.",
                "readStock,stock:CASH-ITEM,readHeader,header,readJournal,journal,readPayments");
            if (blankCash.PaymentCount != 0 || blankCash.CommitCount != 0)
                throw new Exception("Blank cash total reached SQL or committed");
        }

        foreach (object invalidTenderAmount in new object[] { null, DBNull.Value, "", "  " })
        {
            var blankTender = new Store();
            var blankTenderInput = Input(blankTender);
            blankTenderInput.ReadPayments = delegate {
                blankTender.Events.Add("readPayments");
                return new[] { new TicketPaymentWrite {
                    Kind = TicketPaymentKind.Tendered, Mode = "CARTE",
                    Amount = invalidTenderAmount,
                    Context = new TicketPaymentContext { TicketNumber = "T-1" } } };
            };
            CheckInvalidReader(blankTender, blankTenderInput,
                "Checkout tendered payment has no amount.",
                "readStock,stock:A,stock:B,readHeader,header,readJournal,journal,readPayments");
            if (blankTender.PaymentCount != 0 || blankTender.CommitCount != 0)
                throw new Exception("Blank card amount reached SQL or committed");
        }

        // Change/refund remains signed and zero cash is still a legitimate
        // string amount. No rounding, numeric parsing, or VB conversion is
        // introduced in this boundary.
        var zeroCash = new Store();
        CheckoutTransactionFinalizationService.PostAndFinalize(
            zeroCash, SingleCashInput(zeroCash, "1", "0.00"), zeroCash);
        if (zeroCash.PaymentCount != 1 || zeroCash.LastPayment.AmountText != "0.00" ||
            zeroCash.CommitCount != 1 || zeroCash.CloseCount != 1)
            throw new Exception("Valid zero cash amount must retain legacy semantics");

        var blankChange = new Store();
        var blankChangeInput = Input(blankChange);
        blankChangeInput.ReadPayments = delegate {
            blankChange.Events.Add("readPayments");
            return new[] { new TicketPaymentWrite {
                Kind = TicketPaymentKind.Change, AmountText = " ",
                Context = new TicketPaymentContext { TicketNumber = "T-1" } } };
        };
        CheckInvalidReader(blankChange, blankChangeInput,
            "Checkout cash/change payment has no amount.",
            "readStock,stock:A,stock:B,readHeader,header,readJournal,journal,readPayments");

        // A valid first payment followed by an incomplete card row must never
        // print, commit or close; the original Form rolls the transaction back.
        var lateBlankAmount = new Store();
        var lateBlankInput = Input(lateBlankAmount);
        lateBlankInput.ReadPayments = delegate {
            lateBlankAmount.Events.Add("readPayments");
            return new[] {
                new TicketPaymentWrite { Kind = TicketPaymentKind.Cash,
                    AmountText = "5.00", Context = new TicketPaymentContext { TicketNumber = "T-1" } },
                new TicketPaymentWrite { Kind = TicketPaymentKind.Tendered,
                    Mode = "CARTE", Amount = DBNull.Value,
                    Context = new TicketPaymentContext { TicketNumber = "T-1" } }
            };
        };
        CheckInvalidReader(lateBlankAmount, lateBlankInput,
            "Checkout tendered payment has no amount.",
            "readStock,stock:A,stock:B,readHeader,header,readJournal,journal,readPayments,payment:5.00");
        if (lateBlankAmount.PaymentCount != 1 || lateBlankAmount.CommitCount != 0)
            throw new Exception("Late invalid amount changed streaming/rollback contract");

        var noCompletion = new Store();
        var noCompletionInput = Input(noCompletion);
        noCompletionInput.ReadCompletion = delegate { noCompletion.Events.Add("readCompletion"); return null; };
        CheckInvalidReader(noCompletion, noCompletionInput,
            "Checkout completion reader returned null.",
            "readStock,stock:A,stock:B,readHeader,header,readJournal,journal,readPayments,payment:1,payment:2,print,readCompletion");

        Console.WriteLine("PASS portable checkout posting: ordered stock/ticket/payment, failure before print and completion; one cash sale/refund and fail-fast callback safety");
        return 0;
    }
}
