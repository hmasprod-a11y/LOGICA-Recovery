namespace LOGICA.Domain
{
    internal static class StockAvailability
    {
        public static bool IsBelowRequested(object availableStock, object requestedQuantity,
            ILegacyCheckoutSemantics legacy)
        {
            // VB object comparison is not equivalent to a decimal comparison.
            return legacy.IsStockBelow(availableStock, requestedQuantity);
        }
    }
}
