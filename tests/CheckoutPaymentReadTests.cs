using System;
using System.Collections.Generic;
using System.Globalization;
using LOGICA.ApplicationLayer.Checkout;
using LOGICA.Infrastructure.Compatibility;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

internal static class CheckoutPaymentReadTests
{
    private sealed class Source
    {
        internal readonly List<string> Events = new List<string>();
        internal readonly Exception Failure = new InvalidOperationException("injected payment read failure");
        internal string FailAt;
        internal string[] Operations = { "VENTE" };
        internal bool[] AccessFlags = { true };
        internal object[] Amounts = { 5m, 7m };
        internal object[] Modes = { "CARTE", "ESPECES" };
        internal string[] Changes = { "-1", "-2" };
        internal string CashTotal = "12";
        internal int OperationReads, AccessReads, ChangeReads;
        private void Mark(string stage)
        {
            Events.Add(stage);
            if (FailAt == stage) throw Failure;
        }
        internal string Operation()
        {
            Mark("operation" + (++OperationReads));
            return Operations[Math.Min(OperationReads - 1, Operations.Length - 1)];
        }
        internal TicketPaymentContext Context()
        {
            Mark("context");
            return new TicketPaymentContext { TicketId = "T", TicketNumber = "42",
                Operation = "VENTE", Remark = "test" };
        }
        internal bool Access()
        {
            Mark("access" + (++AccessReads));
            return AccessFlags[Math.Min(AccessReads - 1, AccessFlags.Length - 1)];
        }
        internal int Count() { Mark("count"); return Modes.Length; }
        internal object Paid(int index) { Mark("paid" + index); return Amounts[index]; }
        internal object Mode(int index) { Mark("mode" + index); return Modes[index]; }
        internal string Cash() { Mark("cash"); return CashTotal; }
        internal string Change()
        {
            Mark("change" + (++ChangeReads));
            return Changes[Math.Min(ChangeReads - 1, Changes.Length - 1)];
        }
        internal Source Clone()
        {
            return new Source { FailAt = FailAt, Operations = Operations,
                AccessFlags = AccessFlags, Amounts = Amounts, Modes = Modes,
                Changes = Changes, CashTotal = CashTotal };
        }
    }

    // The original iterator, with UI reads represented by traceable callbacks.
    private static IEnumerable<TicketPaymentWrite> Legacy(Source source)
    {
        checked
        {
            if (Operators.CompareString(source.Operation(), "VENTE", TextCompare: false) == 0 ||
                Operators.CompareString(source.Operation(), "RETOUR REMBOURSEMENT", TextCompare: false) == 0)
            {
                TicketPaymentContext context = source.Context();
                if (!source.Access())
                {
                    yield return new TicketPaymentWrite { Kind = TicketPaymentKind.Cash,
                        Context = context, AmountText = source.Cash() };
                }
                else if (source.Access())
                {
                    int lastRow = source.Count() - 1;
                    int index = 0;
                    while (true)
                    {
                        int current = index;
                        int last = lastRow;
                        if (current > last) break;
                        yield return new TicketPaymentWrite { Kind = TicketPaymentKind.Tendered,
                            Context = context, Amount = source.Paid(index),
                            Mode = source.Mode(index) };
                        index++;
                    }
                    if (Conversion.Val(source.Change()) < 0.0)
                    {
                        yield return new TicketPaymentWrite { Kind = TicketPaymentKind.Change,
                            Context = context, AmountText = source.Change() };
                    }
                }
            }
        }
    }

    private static IEnumerable<TicketPaymentWrite> Extracted(Source source)
    {
        return CheckoutPaymentReadService.Read(source.Operation, source.Context,
            source.Access, source.Count, source.Paid, source.Mode, source.Cash,
            source.Change, VisualBasicCheckoutPaymentReadSemantics.Instance);
    }

    private static string Snapshot(IEnumerable<TicketPaymentWrite> payments, out Exception exception)
    {
        var result = new List<string>();
        TicketPaymentContext context = null;
        try
        {
            foreach (TicketPaymentWrite payment in payments)
            {
                if (context == null) context = payment.Context;
                if (!Object.ReferenceEquals(context, payment.Context))
                    throw new Exception("Payment context was not shared");
                result.Add(payment.Kind + ":" + Convert.ToString(payment.AmountText) +
                    ":" + Convert.ToString(payment.Amount) + ":" + Convert.ToString(payment.Mode));
            }
            exception = null;
            return "ok:" + String.Join("|", result.ToArray());
        }
        catch (Exception error)
        {
            exception = error;
            return "error:" + error.GetType().FullName + ":" + error.Message +
                ":" + String.Join("|", result.ToArray());
        }
    }

    private static void Same(Source source, string label)
    {
        Source extracted = source.Clone();
        Exception beforeException, afterException;
        string before = Snapshot(Legacy(source), out beforeException);
        string after = Snapshot(Extracted(extracted), out afterException);
        string oldEvents = String.Join(",", source.Events.ToArray());
        string newEvents = String.Join(",", extracted.Events.ToArray());
        if (before != after || oldEvents != newEvents)
            throw new Exception(label + ": legacy=" + before + " [" + oldEvents +
                "] extracted=" + after + " [" + newEvents + "]");
        if (source.FailAt != null && beforeException != null &&
            Object.ReferenceEquals(beforeException, source.Failure) !=
            Object.ReferenceEquals(afterException, extracted.Failure))
            throw new Exception(label + ": exception identity changed");
    }

    private static void PartialEnumeration()
    {
        var original = new Source();
        var extracted = original.Clone();
        IEnumerator<TicketPaymentWrite> oldItems = Legacy(original).GetEnumerator();
        IEnumerator<TicketPaymentWrite> newItems = Extracted(extracted).GetEnumerator();
        try
        {
            if (original.Events.Count != 0 || extracted.Events.Count != 0)
                throw new Exception("Payment source eagerly evaluated before MoveNext");
            for (int i = 0; i < 4; i++)
            {
                bool before = oldItems.MoveNext(), after = newItems.MoveNext();
                if (before != after || (before && oldItems.Current.Kind != newItems.Current.Kind) ||
                    String.Join(",", original.Events.ToArray()) != String.Join(",", extracted.Events.ToArray()))
                    throw new Exception("Payment iterator yielded different results or read order at " + i);
            }
        }
        finally { oldItems.Dispose(); newItems.Dispose(); }
    }

    public static int Main()
    {
        CultureInfo oldCulture = CultureInfo.CurrentCulture;
        CultureInfo oldUiCulture = CultureInfo.CurrentUICulture;
        int cases = 0;
        try
        {
            string[][] operations = { new[] { "VENTE" },
                new[] { "RETOUR REMBOURSEMENT" }, new[] { "DEVIS" },
                new[] { "DEVIS", "VENTE" }, new string[] { null } };
            bool[][] flags = { new[] { false }, new[] { true },
                new[] { false, true }, new[] { true, false } };
            object[][] modes = { new object[0], new object[] { "CARTE" },
                new object[] { "CARTE", DBNull.Value }, new object[] { 7, null } };
            string[][] changes = { new[] { "0" }, new[] { "-1.5" },
                new[] { "-1,5" }, new[] { "abc" }, new string[] { null },
                new[] { "-2", "updated" } };
            foreach (string culture in new[] { "en-US", "fr-FR", "tr-TR" })
            {
                CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo(culture);
                CultureInfo.CurrentUICulture = CultureInfo.GetCultureInfo(culture);
                foreach (string[] operation in operations)
                foreach (bool[] flag in flags)
                foreach (object[] mode in modes)
                foreach (string[] change in changes)
                {
                    var amounts = new object[mode.Length];
                    for (int i = 0; i < amounts.Length; i++) amounts[i] = i + 1;
                    Same(new Source { Operations = operation, AccessFlags = flag,
                        Modes = mode, Amounts = amounts, Changes = change },
                        culture + "/payment iterator");
                    cases++;
                }
                foreach (string stage in new[] { "operation1", "operation2", "context",
                    "access1", "access2", "count", "paid0", "mode0", "paid1",
                    "mode1", "change1", "change2" })
                {
                    Same(new Source { Operations = new[] { "DEVIS", "VENTE" },
                        AccessFlags = new[] { true, true }, FailAt = stage },
                        culture + "/" + stage);
                    cases++;
                }
                Same(new Source { AccessFlags = new[] { false }, FailAt = "cash" },
                    culture + "/cash failure");
                cases++;
                PartialEnumeration();
                cases++;
            }
            Console.WriteLine("PASS checkout payment projection: " + cases +
                " VB parity cases across 3 cultures, streaming order and exception identity");
            return 0;
        }
        finally
        {
            CultureInfo.CurrentCulture = oldCulture;
            CultureInfo.CurrentUICulture = oldUiCulture;
        }
    }
}
