namespace LOGICA.ApplicationLayer.Checkout;

internal enum ReceiptPrintRoute
{
    Disabled, Drawer, SerialSale, SerialReturn, FrenchThreeColumn,
    FrenchFourColumn, FrenchTwoLine, ArabicThreeColumn, ArabicFourColumn, Return
}

internal static class ReceiptPrintRouting
{
    // Form_3_VENTE.CREATION_IMPRESSION: customer printer only.
    internal static ReceiptPrintRoute Select(string printer, bool printRequested, string operation,
        string connection, string template, out int copies)
    {
        copies = 0;
        if (printer == "0") return ReceiptPrintRoute.Disabled;
        if (!printRequested) return ReceiptPrintRoute.Drawer;

        bool isReturn = operation.Contains("RETOUR");
        bool isCredit = operation == "CREDIT";
        if (operation != "VENTE" && !isCredit && !isReturn) return ReceiptPrintRoute.Disabled;
        var route = connection != "USB"
            ? (isReturn ? ReceiptPrintRoute.SerialReturn : ReceiptPrintRoute.SerialSale)
            : isReturn ? ReceiptPrintRoute.Return : template switch
            {
                "FR_3C" => ReceiptPrintRoute.FrenchThreeColumn,
                "FR_4C" => ReceiptPrintRoute.FrenchFourColumn,
                "FR_2L" => ReceiptPrintRoute.FrenchTwoLine,
                "AR_3C" => ReceiptPrintRoute.ArabicThreeColumn,
                "AR_4C" => ReceiptPrintRoute.ArabicFourColumn,
                _ => ReceiptPrintRoute.Disabled
            };
        if (route != ReceiptPrintRoute.Disabled) copies = isCredit || isReturn ? 2 : 1;
        return route;
    }
}
