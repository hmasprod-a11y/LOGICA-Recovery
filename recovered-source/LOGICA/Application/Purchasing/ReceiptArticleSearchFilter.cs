using System;
using System.Text;

namespace LOGICA.ApplicationLayer.Purchasing
{
    // DataView.RowFilter is a DataColumn expression, not SQL. Treat user search
    // as literal text; LIKE wildcards and expression quotes must be escaped.
    internal static class ReceiptArticleSearchFilter
    {
        internal static string Build(string search)
        {
            var escaped = new StringBuilder();
            foreach (char character in search ?? String.Empty)
            {
                switch (character)
                {
                    case '\'': escaped.Append("''"); break;
                    case '%': escaped.Append("[%]"); break;
                    case '*': escaped.Append("[*]"); break;
                    case '[': escaped.Append("[[]"); break;
                    case ']': escaped.Append("[]]"); break;
                    default: escaped.Append(character); break;
                }
            }
            string pattern = "'%" + escaped + "%'";
            return "Article LIKE " + pattern + " OR Code LIKE " + pattern;
        }
    }
}
