using System;

namespace LOGICA.Domain
{
    internal static class CashDenominationTotal
    {
        // Input order: 200,100,50,20,10,5,2,1,0.5,0.2,0.1.
        // Preserve the original decimal subtotal, double fractional addition and decimal construction.
        public static decimal Calculate(Func<int, string> readCount, ILegacyCashSemantics semantics)
        {
            return new decimal(Convert.ToDouble(decimal.Add(decimal.Add(decimal.Add(decimal.Add(decimal.Add(decimal.Add(decimal.Add(decimal.Add(0m, decimal.Multiply(semantics.ToDecimal(readCount(0)), 200m)), decimal.Multiply(semantics.ToDecimal(readCount(1)), 100m)), decimal.Multiply(semantics.ToDecimal(readCount(2)), 50m)), decimal.Multiply(semantics.ToDecimal(readCount(3)), 20m)), decimal.Multiply(semantics.ToDecimal(readCount(4)), 10m)), decimal.Multiply(semantics.ToDecimal(readCount(5)), 5m)), decimal.Multiply(semantics.ToDecimal(readCount(6)), 2m)), decimal.Multiply(semantics.ToDecimal(readCount(7)), 1m))) + Convert.ToDouble(semantics.ToDecimal(readCount(8))) * 0.5 + Convert.ToDouble(semantics.ToDecimal(readCount(9))) * 0.2 + Convert.ToDouble(semantics.ToDecimal(readCount(10))) * 0.1);
        }
    }
}
