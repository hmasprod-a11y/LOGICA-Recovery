internal static class CatalogueCoreIsolationEntry
{
    public static int Main() { int catalogue = PortableCatalogueSmoke.Run();
        if (catalogue != 0) return catalogue;
        return BusinessOperationsSmoke.Run(); }
}
