internal static class CheckoutCoreIsolationEntry
{
    public static int Main() { if (PortableCheckoutSmoke.Run() != 0) return 1; if (PortablePostingSmoke.Run() != 0) return 1; if (PortableTransactionSmoke.Run() != 0) return 1; return PortableTicketSequenceSmoke.Run(); }
}
