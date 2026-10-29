using System;
using LOGICA.Domain;

internal static class CheckoutSignGuardsTests
{
    private static int assertions;
    private static void Check(string operation, double total, bool saleRejected, bool returnRejected)
    {
        assertions += 2;
        if (CheckoutSignGuards.RejectSale(operation, total) != saleRejected)
            throw new Exception("Sale predicate mismatch: " + operation + " " + total);
        if (CheckoutSignGuards.RejectReturn(operation, total) != returnRejected)
            throw new Exception("Return predicate mismatch: " + operation + " " + total);
    }

    public static int Main()
    {
        try
        {
            Check("VENTE", -25.0, true, false);
            Check("VENTE", -0.01, true, false);
            Check("VENTE", 0.0, false, false);
            Check("VENTE", 0.01, false, false);
            Check("VENTE", double.NaN, false, false);
            Check("VENTE", double.NegativeInfinity, true, false);
            Check("vente", -25.0, false, false);
            Check("VENTE ", -25.0, false, false);
            Check("RETOUR", 25.0, false, true);
            Check("RETOUR", 0.01, false, true);
            Check("RETOUR", 0.0, false, false);
            Check("RETOUR", -0.01, false, false);
            Check("RETOUR REMBOURSEMENT", 25.0, false, true);
            Check("AVOIR RETOUR", 25.0, false, true);
            Check("retour", 25.0, false, false);
            Check("RETOUR", double.PositiveInfinity, false, true);
            Check("CREDIT", -25.0, false, false);
            Check("", 25.0, false, false);
            // The legacy return predicate dereferences operation even when total is non-positive.
            // Keep this exception boundary rather than replacing Contains with null-safe logic.
            foreach (double total in new[] { -1.0, 0.0, 1.0 })
            {
                assertions++;
                bool threw = false;
                try { CheckoutSignGuards.RejectReturn(null, total); }
                catch (NullReferenceException) { threw = true; }
                if (!threw) throw new Exception("Expected legacy null-operation failure");
            }
            Check("PRE-RETOUR-POST", 1.0, false, true);
            Check("PRE-RETOUR-POST", -1.0, false, false);
            Check("VENTE", double.PositiveInfinity, false, false);
            Check("RETOUR", double.NaN, false, false);
            // Button_Click invokes VB Conversions.ToDouble before each extracted guard,
            // regardless of the operation text. Characterize the conversion boundary
            // without launching an unbounded modal form on the Windows runner.
            foreach (string operation in new[] { "VENTE", "RETOUR", "CREDIT", "" })
            {
                assertions++;
                bool failed = false;
                try
                {
                    CheckoutSignGuards.RejectSale(operation,
                        Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble("not-a-number"));
                }
                catch (InvalidCastException) { failed = true; }
                if (!failed) throw new Exception("Expected VB invalid-total conversion failure: " + operation);
            }
            Console.WriteLine("PASS checkout sign predicates: " + assertions + " assertions");
            return 0;
        }
        catch (Exception ex) { Console.Error.WriteLine(ex); return 1; }
    }
}
