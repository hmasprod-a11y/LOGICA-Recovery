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

    public static int Run()
    {
        Check("VENTE", false, "-1", "Cash", "operation,context,access,cash");
        Check("VENTE", true, "-1", "Tendered,Tendered,Change",
            "operation,context,access,access,count,paid0,mode0,paid1,mode1,change,change");
        Check("RETOUR REMBOURSEMENT", true, "0", "Tendered,Tendered",
            "operation,operation,context,access,access,count,paid0,mode0,paid1,mode1,change");
        Check("DEVIS", true, "-1", "", "operation,operation");
        Console.WriteLine("PASS .NET 10 portable payment projection: lazy reads, cash/tender/change order");
        return 0;
    }
}
