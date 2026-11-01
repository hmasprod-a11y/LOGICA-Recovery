internal static class BusinessOperationsEntry
{
    public static int Main() { int business = BusinessOperationsSmoke.Run();
        if (business != 0) return business;
        int coverage = StockCountCoverageSmoke.Run();
        if (coverage != 0) return coverage;
        int safety = BusinessOperationsSafetySmoke.Run();
        if (safety != 0) return safety;
        int projection = PurchaseReceiptStockProjectionSmoke.Run();
        if (projection != 0) return projection;
        int freshness = BusinessSnapshotFreshnessSmoke.Run();
        if (freshness != 0) return freshness;
        return BusinessRevalidationSmoke.Run(); }
}
