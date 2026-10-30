using System;
using Microsoft.VisualBasic;

namespace LOGICA.Domain
{
    internal static class SalesLinePricing
    {
        public static decimal? SelectQuantityPrice(decimal absoluteQuantity, decimal minimumQuantity,
            decimal quantityPrice, decimal standardPrice)
        {
            // A disabled quantity price leaves the edited row unchanged in the legacy form.
            if (Conversion.Val(quantityPrice) <= 0.0)
                return null;

            // Preserve the legacy double comparison, including its precision boundaries.
            return Convert.ToDouble(absoluteQuantity) >= Conversion.Val(minimumQuantity)
                ? quantityPrice : standardPrice;
        }

        public static decimal CalculateNetAmount(decimal unitPrice, decimal quantity, decimal discountPercent)
        {
            // Keep the original operation order and intermediate overflow behavior.
            return decimal.Subtract(decimal.Multiply(unitPrice, quantity),
                decimal.Divide(decimal.Multiply(decimal.Multiply(unitPrice, quantity), discountPercent), 100m));
        }
    }
}
