using System;
using System.Data;

namespace LOGICA.ApplicationLayer.Catalogue
{
    internal static class CollectionDuplicatePrecheck
    {
        public static DataRow FindFirst(int lastIndex, Func<int, object> readCode,
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
