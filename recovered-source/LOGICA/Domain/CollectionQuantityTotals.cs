using System;
using Microsoft.VisualBasic.CompilerServices;

namespace LOGICA.Domain
{
    internal static class CollectionQuantityTotals
    {
        public static decimal Accumulate(int lastIndex, Func<int, object> readQuantity)
        {
            decimal total = 0m;
            checked
            {
                for (int index = 0; index <= lastIndex; index++)
                    total = Conversions.ToDecimal(Operators.AddObject(total, readQuantity(index)));
            }
            return total;
        }
    }
}
