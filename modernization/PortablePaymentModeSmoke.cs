using System;
using System.Collections.Generic;
using LOGICA.ApplicationLayer.Checkout;
using LOGICA.Domain;

internal static class PortablePaymentModeSmoke
{
    private sealed class PortableSemantics : ILegacyCheckoutPaymentModeSemantics
    {
        public int CompareOperation(string actual, string expected)
        {
            return String.CompareOrdinal(actual, expected);
        }
        public object Concatenate(object left, object right)
        {
            return Convert.ToString(left) + Convert.ToString(right);
        }
        public object Add(object left, object right)
        {
            return Convert.ToString(left) + Convert.ToString(right);
        }
        public string ToText(object value)
        {
            return Convert.ToString(value);
        }
    }

    private static void Check(string operation, bool access, object[] modes,
        string expected, string expectedEvents)
    {
        var events = new List<string>();
        string actual = CheckoutPaymentModeService.Read(
            delegate { events.Add("operation"); return operation; },
            delegate { events.Add("access"); return access; },
            delegate { events.Add("count"); return modes.Length; },
            delegate(int index) { events.Add("mode" + index); return modes[index]; },
            new PortableSemantics());
        if (actual != expected ||
            String.Join(",", events.ToArray()) != expectedEvents)
            throw new Exception("Portable payment modes changed: " + actual +
                " events " + String.Join(",", events.ToArray()));
    }

    public static int Run()
    {
        Check("VENTE", false, new object[] { "CARTE" },
            "ESPECES;", "operation,access");
        Check("VENTE", true, new object[] { "CARTE", "ESPECES" },
            "CARTE;ESPECES;", "operation,access,access,count,mode0,mode1");
        Check("RETOUR REMBOURSEMENT", true, new object[0],
            "", "operation,operation,access,access,count");
        Check("DEVIS", true, new object[] { "CARTE" },
            "", "operation,operation");
        Console.WriteLine("PASS .NET 10 portable checkout payment modes: branch/read-order contracts");
        return 0;
    }
}
