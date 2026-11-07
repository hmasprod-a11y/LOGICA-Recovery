using System;
using System.Data;

namespace LOGICA.ApplicationLayer.Catalogue
{
    internal static class CollectionDuplicatePrecheck
    {
        #if NET10_0_OR_GREATER
        public static DataRow? FindFirst(int lastIndex,
#else
        public static DataRow FindFirst(int lastIndex,
#endif Func<int, object> readCode,
            Func<object, DataTable> lookup, Action afterNoMatch)
        {
            checked
            {
                for (int index = 0; index <= lastIndex; index++)
                {
                    DataTable matches = lookup(readCode(index));
                    if (matches.Rows.Count != 0)
                        return matches.Rows[0];
                    afterNoMatch();
                }
                return null;
            }
        }
    }
}
