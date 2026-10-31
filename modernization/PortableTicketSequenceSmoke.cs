using System;
using LOGICA.Domain;
using LOGICA.ApplicationLayer.Checkout;
using LOGICA.Infrastructure.Checkout;

internal static class PortableTicketSequenceSmoke
{
    private sealed class Semantics : ILegacyCheckoutTicketSequenceSemantics
    {
        public string ZeroText() { return "0"; }
        public double ToDouble(object value) { return Convert.ToDouble(value); }
        public string FormatSequence(double value) { return value.ToString("000000",
            System.Globalization.CultureInfo.InvariantCulture); }
    }

    private sealed class Source : ICheckoutTicketSequenceSource
    {
        internal int PrepareCount, ReadCount;
        internal object First, Second;
        public void Prepare() { PrepareCount++; }
        public object ExecuteScalar() { return ++ReadCount == 1 ? First : Second; }
    }

    internal static int Run()
    {
        if (CheckoutTicketSequenceSql.SelectCurrent != "Select CL from TABLE_NUM  where ID = 0 ")
            throw new Exception("Ticket SQL changed");
        var twice = new Source { First = 1, Second = 42 };
        if (CheckoutTicketSequenceService.ReadCurrent(twice, new Semantics()) != "000042" ||
            twice.PrepareCount != 1 || twice.ReadCount != 2)
            throw new Exception("Portable ticket counter lost original double-read semantics");
        var zero = new Source { First = DBNull.Value, Second = 42 };
        if (CheckoutTicketSequenceService.ReadCurrent(zero, new Semantics()) != "0" ||
            zero.PrepareCount != 1 || zero.ReadCount != 1)
            throw new Exception("Portable ticket counter lost DBNull short circuit");
        Console.WriteLine("PASS .NET 10 portable ticket counter: original SQL, two-read and DBNull branches");
        return 0;
    }
}
