using System;

namespace LOGICA.Domain
{
    // Exact Visual Basic formatting and object concatenation for recovered stock SQL.
    // Do not normalize search terms, identifiers, spacing or dates here.
    internal interface ILegacyStockMovementQuerySemantics
    {
        string FormatDate(DateTime value);
        object Concat(object left, object right);
        string ToText(object value);
    }
}
