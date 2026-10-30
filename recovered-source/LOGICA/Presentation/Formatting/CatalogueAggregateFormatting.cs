using System;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using LOGICA.Domain;

namespace LOGICA.Presentation.Formatting
{
    internal static class CatalogueAggregateFormatting
    {
        public static string Count(object value)
        {
            if (value == DBNull.Value) return Conversions.ToString(0);
            return Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(value)));
        }

        public static string Money(object value)
        {
            if (value == DBNull.Value) return (Conversions.ToString(0) + " DH").PadLeft(20, '#');
            return (Conversions.ToString(MonetaryRounding.Round(Conversions.ToDecimal(value))) + " DH").PadLeft(20, '#');
        }
    }
}
