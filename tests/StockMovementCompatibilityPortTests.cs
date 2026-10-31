using System;
using LOGICA.Domain;
using LOGICA.Infrastructure.Compatibility;
using Microsoft.VisualBasic.CompilerServices;

internal static class StockMovementCompatibilityPortTests
{
    private static void Check(string left, string right)
    {
        bool expected = Operators.CompareString(left, right, false) == 0;
        bool actual = VisualBasicStockMovementSemantics.Instance.EqualsText(left, right);
        if (actual != expected)
            throw new Exception("VB string comparison parity changed: " + left + " / " + right);
    }

    public static int Main()
    {
        string[] values = { null, "", " ", "DATES", "dates", "DateS", "ARTICLE", "é", "e", "İ", "I", "\t", "0", "00" };
        foreach (string left in values)
            foreach (string right in values)
                Check(left, right);
        Console.WriteLine("PASS stock movement legacy comparison adapter: " + (values.Length * values.Length) + " parity pairs");
        return 0;
    }
}
