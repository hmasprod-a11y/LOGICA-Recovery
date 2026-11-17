using System;
using System.Collections.Generic;
using LOGICA.ApplicationLayer.Checkout;
using LOGICA.Domain;

internal static class PortablePaymentReadSmoke
{
    private sealed class Semantics : ILegacyCheckoutPaymentReadSemantics
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

    private static void Check(string operation, bool access, string change,
        string expectedKinds, string expectedEvents)
    {
        var events = new List<string>();
        var context = new TicketPaymentContext { TicketId = "portable" };
        IEnumerable<TicketPaymentWrite> rows = CheckoutPaymentReadService.Read(
            delegate { events.Add("operation"); return operation; },
            delegate { events.Add("context"); return context; },
            delegate { events.Add("access"); return access; },
            delegate { events.Add("count"); return 2; },
            delegate(int index) { events.Add("paid" + index); return index + 1; },
            delegate(int index) { events.Add("mode" + index); return "CARTE"; },
            delegate { events.Add("cash"); return "10"; },
            delegate { events.Add("change"); return change; },
            new Semantics());
        if (events.Count != 0)
            throw new Exception("Payment projection must remain lazy");
        var kinds = new List<string>();
        foreach (TicketPaymentWrite row in rows)
        {
            if (!Object.ReferenceEquals(row.Context, context))
                throw new Exception("Payment context was not reused");
            kinds.Add(row.Kind.ToString());
        }
        if (String.Join(",", kinds.ToArray()) != expectedKinds ||
            String.Join(",", events.ToArray()) != expectedEvents)
            throw new Exception("Portable payment projection changed: " +
                String.Join(",", kinds.ToArray()) + " [" + String.Join(",", events.ToArray()) + "]");
    }

    // Null UI/payment context is a P0 SOLDER failure: the projection is lazy,
    // but it must stop before producing a cash/tendered SQL write.
    private static void CheckMissingContext(string operation, string expectedEvents)
    {
        var events = new List<string>();
        IEnumerable<TicketPaymentWrite> rows = CheckoutPaymentReadService.Read(
            delegate { events.Add("operation"); return operation; },
            delegate { events.Add("context"); return null; },
            delegate { events.Add("access"); return false; },
            delegate { throw new Exception("No payment grid read expected"); },
            delegate(int index) { throw new Exception("No tender read expected"); },
            delegate(int index) { throw new Exception("No payment mode read expected"); },
            delegate { throw new Exception("No cash read expected"); },
            delegate { throw new Exception("No change read expected"); },
            new Semantics());
        if (events.Count != 0)
            throw new Exception("Payment context must not be read eagerly");
        bool rejected = false;
        int emitted = 0;
        try { foreach (TicketPaymentWrite row in rows) emitted++; }
        catch (InvalidOperationException ex) {
            rejected = ex.Message == "Checkout payment context reader returned null.";
        }
        if (!rejected || emitted != 0 ||
            String.Join(",", events.ToArray()) != expectedEvents)
            throw new Exception("Missing payment context must stop before SQL payment rows: " +
                String.Join(",", events.ToArray()));
    }

    public static int Run()
    {
        Check("VENTE", false, "-1", "Cash", "operation,context,access,cash");
        Check("VENTE", true, "-1", "Tendered,Tendered,Change",
            "operation,context,access,access,count,paid0,mode0,paid1,mode1,change,change");
        Check("RETOUR REMBOURSEMENT", true, "0", "Tendered,Tendered",
            "operation,operation,context,access,access,count,paid0,mode0,paid1,mode1,change");
        Check("DEVIS", true, "-1", "", "operation,operation");
        CheckMissingContext("VENTE", "operation,context");
        CheckMissingContext("RETOUR REMBOURSEMENT", "operation,operation,context");
        Console.WriteLine("PASS .NET 10 portable payment projection: lazy reads, cash/tender/change order");
        return 0;
    }
}
