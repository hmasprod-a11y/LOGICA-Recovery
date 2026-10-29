namespace LOGICA.Domain
{
    internal static class SalesLinePricing
    {
        public static decimal CalculateNetAmount(decimal unitPrice, decimal quantity, decimal discountPercent)
        {
            // Keep the original operation order and intermediate overflow behavior.
            return decimal.Subtract(decimal.Multiply(unitPrice, quantity),
                decimal.Divide(decimal.Multiply(decimal.Multiply(unitPrice, quantity), discountPercent), 100m));
        }
    }
}
