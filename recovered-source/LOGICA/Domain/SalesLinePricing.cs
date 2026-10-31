using System;

namespace LOGICA.Domain
{
    internal static class SalesLinePricing
    {
        public static decimal? SelectQuantityPrice(decimal absoluteQuantity, decimal minimumQuantity,
            decimal quantityPrice, decimal standardPrice, ILegacyCheckoutSemantics legacy)
        {
            // Keep VB Val(double) precision, disabled tier and short-circuit order.
            if (legacy.Val(quantityPrice) <= 0.0)
                return null;

            return Convert.ToDouble(absoluteQuantity) >= legacy.Val(minimumQuantity)
                ? quantityPrice : standardPrice;
        }

        public static decimal CalculateNetAmount(decimal unitPrice, decimal quantity, decimal discountPercent)
        {
            // Keep original decimal operation order and intermediate overflow behavior.
            return decimal.Subtract(decimal.Multiply(unitPrice, quantity),
                decimal.Divide(decimal.Multiply(decimal.Multiply(unitPrice, quantity), discountPercent), 100m));
        }
    }
}
