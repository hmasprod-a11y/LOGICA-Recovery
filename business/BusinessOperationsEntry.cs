internal static class BusinessOperationsEntry
{
    public static int Main() { int business = BusinessOperationsSmoke.Run();
        if (business != 0) return business;
        return StockCountCoverageSmoke.Run(); }
}
