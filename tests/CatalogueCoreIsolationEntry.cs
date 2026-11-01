internal static class CatalogueCoreIsolationEntry
{
    public static int Main() { int catalogue = PortableCatalogueSmoke.Run();
        if (catalogue != 0) return catalogue;
        int business = BusinessOperationsSmoke.Run();
        if (business != 0) return business;
        int coverage = StockCountCoverageSmoke.Run();
        if (coverage != 0) return coverage;
        int safety = BusinessOperationsSafetySmoke.Run();
        if (safety != 0) return safety;
        int projection = PurchaseReceiptStockProjectionSmoke.Run();
        if (projection != 0) return projection;
        return BusinessSnapshotFreshnessSmoke.Run(); }
}
