using System;
using LOGICA.Domain;

internal static class ClientCreditBalanceTests
{
    static void Equal(decimal actual, decimal expected, string name)
    {
        if (actual != expected) throw new Exception(name + ": expected " + expected + " actual " + actual);
    }

    static decimal Original(decimal sale, decimal returned, decimal opening, decimal paid)
    {
        return decimal.Subtract(decimal.Add(decimal.Add(sale, returned), opening), paid);
    }

    public static int Main()
    {
        decimal[][] scenarios = {
            new decimal[]{0m,0m,0m,0m},
            new decimal[]{100m,0m,0m,0m},
            new decimal[]{100m,-20m,15m,30m},
            new decimal[]{100m,20m,15m,30m},
            new decimal[]{-20m,5m,-10m,3m},
            new decimal[]{0.01m,0.02m,0.03m,0.04m},
            new decimal[]{100000000000000000m,-1m,20m,3m}
        };
        foreach (decimal[] s in scenarios)
            Equal(ClientCreditBalance.Calculate(s[0],s[1],s[2],s[3]),Original(s[0],s[1],s[2],s[3]),"balance parity");
        // Preserve legacy evaluation order: first addition overflows before a later payment could cancel it.
        bool overflow=false;
        try { ClientCreditBalance.Calculate(decimal.MaxValue,1m,0m,decimal.MaxValue); }
        catch (OverflowException) { overflow=true; }
        if (!overflow) throw new Exception("Legacy intermediate overflow was lost");
        Console.WriteLine("PASS client credit decimal calculation parity and intermediate overflow");
        return 0;
    }
}
