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
        int freshness = BusinessSnapshotFreshnessSmoke.Run();
        if (freshness != 0) return freshness;
        int revalidation = BusinessRevalidationSmoke.Run();
        if (revalidation != 0) return revalidation;
        int movement = StockMovementAuditSmoke.Run();
        if (movement != 0) return movement;
        return PurchaseOrderReceiptReconciliationSmoke.Run(); }
}
