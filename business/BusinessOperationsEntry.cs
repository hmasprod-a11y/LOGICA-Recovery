internal static class BusinessOperationsEntry
{
    public static int Main() { int business = BusinessOperationsSmoke.Run();
        if (business != 0) return business;
        int coverage = StockCountCoverageSmoke.Run();
        if (coverage != 0) return coverage;
        int safety = BusinessOperationsSafetySmoke.Run();
        if (safety != 0) return safety;
        return PurchaseReceiptStockProjectionSmoke.Run(); }
}
