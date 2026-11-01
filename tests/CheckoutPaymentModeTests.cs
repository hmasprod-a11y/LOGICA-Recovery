using System;
using System.Collections.Generic;
using System.Globalization;
using LOGICA.ApplicationLayer.Checkout;
using LOGICA.Domain;
using LOGICA.Infrastructure.Compatibility;
using Microsoft.VisualBasic.CompilerServices;

internal static class CheckoutPaymentModeTests
{
    private sealed class Source
    {
        internal readonly List<string> Events = new List<string>();
        internal readonly Exception Failure = new InvalidOperationException("injected read failure");
        internal string FailAt;
        internal string[] Operations = { "VENTE" };
        internal bool[] AccessFlags = { true };
        internal object[] Modes = { "ESPECES" };
        internal int OperationReads, AccessReads;
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
        internal bool Access()
        {
            Mark("access" + (++AccessReads));
            return AccessFlags[Math.Min(AccessReads - 1, AccessFlags.Length - 1)];
        }
        internal int Count()
        {
            Mark("count");
            return Modes.Length;
        }
        internal object Mode(int index)
        {
            Mark("mode" + index);
            return Modes[index];
        }
        internal Source Clone()
        {
            return new Source { FailAt = FailAt, Operations = Operations,
                AccessFlags = AccessFlags, Modes = Modes };
        }
    }

    // Characterization oracle: exact original VB call sequence from Form_3_VENTE.
    private static string Legacy(Source source)
    {
        checked
        {
            string text2 = "";
            if (Operators.CompareString(source.Operation(), "VENTE", TextCompare: false) == 0 ||
                Operators.CompareString(source.Operation(), "RETOUR REMBOURSEMENT", TextCompare: false) == 0)
            {
                if (!source.Access())
                {
                    text2 = "ESPECES;";
                }
                else if (source.Access())
                {
                    int num8 = source.Count() - 1;
                    int num9 = 0;
                    while (true)
                    {
                        int num10 = num9;
                        int num4 = num8;
                        if (num10 > num4) break;
                        text2 = Conversions.ToString(Operators.AddObject(text2,
                            Operators.ConcatenateObject(source.Mode(num9), ";")));
                        num9++;
                    }
                }
            }
            return text2;
        }
    }

    private static string Extracted(Source source)
    {
        return CheckoutPaymentModeService.Read(
            source.Operation, source.Access, source.Count, source.Mode,
            VisualBasicCheckoutPaymentModeSemantics.Instance);
    }

    private static string Outcome(Func<string> action, out Exception exception)
    {
        try { exception = null; return "ok:" + action(); }
        catch (Exception error)
        {
            exception = error;
            return "error:" + error.GetType().FullName + ":" + error.Message;
        }
    }

    private static void Same(Source original, string label)
    {
        Source extracted = original.Clone();
        Exception oldException, newException;
        string before = Outcome(delegate { return Legacy(original); }, out oldException);
        string after = Outcome(delegate { return Extracted(extracted); }, out newException);
        string oldEvents = String.Join(",", original.Events.ToArray());
        string newEvents = String.Join(",", extracted.Events.ToArray());
        if (before != after || oldEvents != newEvents)
            throw new Exception(label + ": legacy=" + before + " [" + oldEvents +
                "] extracted=" + after + " [" + newEvents + "]");
        if (original.FailAt != null && oldException != null &&
            Object.ReferenceEquals(oldException, original.Failure) !=
            Object.ReferenceEquals(newException, extracted.Failure))
            throw new Exception(label + ": injected exception identity changed");
    }

    private sealed class FailingSemantics : ILegacyCheckoutPaymentModeSemantics
    {
        internal readonly Exception Failure = new InvalidOperationException("injected conversion failure");
        internal string FailAt;
        internal readonly List<string> Calls = new List<string>();
        private void Mark(string stage)
        {
            Calls.Add(stage);
            if (FailAt == stage) throw Failure;
        }
        public int CompareOperation(string actual, string expected)
        {
            Mark("compare");
            return Operators.CompareString(actual, expected, TextCompare: false);
        }
        public object Concatenate(object left, object right)
        {
            Mark("concat");
            return Operators.ConcatenateObject(left, right);
        }
        public object Add(object left, object right)
        {
            Mark("add");
            return Operators.AddObject(left, right);
        }
        public string ToText(object value)
        {
            Mark("text");
            return Conversions.ToString(value);
        }
    }

    private static void InjectConversionFailure(string stage)
    {
        var semantics = new FailingSemantics { FailAt = stage };
        var source = new Source();
        Exception caught = null;
        try
        {
            CheckoutPaymentModeService.Read(source.Operation, source.Access,
                source.Count, source.Mode, semantics);
        }
        catch (Exception error) { caught = error; }
        if (!Object.ReferenceEquals(caught, semantics.Failure))
            throw new Exception("Conversion exception identity changed at " + stage);
        if (semantics.Calls[semantics.Calls.Count - 1] != stage)
            throw new Exception("Unexpected conversion order at " + stage);
    }

    public static int Main()
    {
        CultureInfo oldCulture = CultureInfo.CurrentCulture;
        CultureInfo oldUiCulture = CultureInfo.CurrentUICulture;
        int cases = 0;
        try
        {
            string[][] operations = {
                new[] { "VENTE" }, new[] { "RETOUR REMBOURSEMENT" },
                new[] { "DEVIS" }, new[] { "vente" }, new string[] { null },
                new[] { "", "RETOUR REMBOURSEMENT" },
                new[] { "VENTE", "DEVIS" },
                new[] { "RETOUR REMBOURSEMENT", "VENTE" }
            };
            bool[][] accessFlags = {
                new[] { false }, new[] { true },
                new[] { false, true }, new[] { true, false }
            };
            object[][] modeSets = {
                new object[0], new object[] { "ESPECES" },
                new object[] { "CARTE", "BON" },
                new object[] { null, DBNull.Value },
                new object[] { 1, true }, new object[] { new object(), 3.5m },
                new object[] { "A;B", "é", -1.25 }
            };
            foreach (string culture in new[] { "en-US", "fr-FR", "tr-TR" })
            {
                CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo(culture);
                CultureInfo.CurrentUICulture = CultureInfo.GetCultureInfo(culture);
                foreach (string[] operation in operations)
                foreach (bool[] flags in accessFlags)
                foreach (object[] modes in modeSets)
                {
                    Same(new Source { Operations = operation, AccessFlags = flags,
                        Modes = modes }, culture + "/payment modes");
                    cases++;
                }
                foreach (string failure in new[] {
                    "operation1", "operation2", "access1", "access2",
                    "count", "mode0", "mode1"
                })
                {
                    var source = new Source { Operations = new[] { "DEVIS", "VENTE" },
                        AccessFlags = new[] { true, true },
                        Modes = new object[] { "CARTE", "ESPECES" }, FailAt = failure };
                    Same(source, culture + "/" + failure);
                    cases++;
                }
                foreach (string failure in new[] { "compare", "concat", "add", "text" })
                {
                    InjectConversionFailure(failure);
                    cases++;
                }
            }
            Console.WriteLine("PASS checkout payment modes: " + cases +
                " original VB parity cases in 3 cultures; read order and exception identity");
            return 0;
        }
        finally
        {
            CultureInfo.CurrentCulture = oldCulture;
            CultureInfo.CurrentUICulture = oldUiCulture;
        }
    }
}
