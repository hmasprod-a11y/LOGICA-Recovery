namespace LOGICA.Domain
{
    // Boundary for exact recovered checkout coercion, comparison and culture semantics.
    // Implemented in Windows Infrastructure; portable core supplies a separate test port.
    internal interface ILegacyCheckoutSemantics
    {
        bool EqualsText(string left, string right);
        double ToDouble(string value);
        decimal ToDecimal(string value);
        double Val(object value);
        bool IsStockBelow(object availableStock, object requestedQuantity);
    }
}
