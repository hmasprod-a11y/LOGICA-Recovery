namespace LOGICA.Infrastructure.Checkout
{
    // SQL and user-supplied text remain separate: the WinForms adapter binds @search.
    // Preserve legacy LIKE wildcard matching for percent and underscore.
    internal static class CheckoutArticleSearchQueryText
    {
        internal static string List()
        {
            return "select   *    from TABLE_ARTICLES   WHERE       Article like @search       or       Code like @search        order by Article asc ";
        }

        internal static string Images()
        {
            return "select      *     from      TABLE_ARTICLES      WHERE    Article like @search     and   Images <> '0.png'         order by Article asc ";
        }

        internal static string Pattern(string term)
        {
            return "%" + term + "%";
        }
    }
}
