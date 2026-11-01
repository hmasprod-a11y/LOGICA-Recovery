namespace LOGICA.Infrastructure.Checkout
{
    // Exact legacy SQL text is characterized before any parameterization.
    // The existing Form's data adapter owns execution; this class never executes SQL.
    internal static class CheckoutArticleSearchQueryText
    {
        internal static string List(string term)
        {
            return "select   *    from TABLE_ARTICLES   WHERE       Article like  '%" + term +
                "%'       or       Code like  '%" + term + "%'        order by Article asc ";
        }

        internal static string Images(string term)
        {
            return "select      *     from      TABLE_ARTICLES      WHERE    Article like  '%" +
                term + "%'     and   Images <> '0.png'         order by Article asc ";
        }
    }
}
