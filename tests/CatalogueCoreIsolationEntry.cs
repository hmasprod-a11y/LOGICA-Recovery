internal static class CatalogueCoreIsolationEntry
{
    public static int Main() { int catalogue = PortableCatalogueSmoke.Run();
        if (catalogue != 0) return catalogue;
        int business = BusinessOperationsSmoke.Run();
        if (business != 0) return business;
        return StockCountCoverageSmoke.Run(); }
}
