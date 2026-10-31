internal static class CheckoutCoreIsolationEntry
{
    public static int Main() { if (PortableCheckoutSmoke.Run() != 0) return 1; return PortablePostingSmoke.Run(); }
}
