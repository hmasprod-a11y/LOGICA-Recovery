using Microsoft.VisualBasic;

namespace Hanouty.Desktop.Bootstrap;

internal static class LogicaReceiptSummary
{
    // Form_3_VENTE.Text_TOTAL_NET_Click sums quantities, including fractional units.
    // CL_FR_3C_PrintPage derives savings from gross minus persisted net, not Remise %.
    internal static string Format(LogicaPostedTicket ticket)
    {
        var quantity = ticket.Lines.Sum(line => line.Quantity);
        var gross = ticket.Lines.Sum(line => line.UnitPrice * line.Quantity);
        var savings = ticket.Lines.Sum(line => line.UnitPrice * line.Quantity - line.Net);
        var text = "* Nbr Articles: " + quantity.ToString(System.Globalization.CultureInfo.CurrentCulture) + "\r\n\r\n";
        if (savings > 0m)
        {
            if (gross <= 0m)
                throw new InvalidOperationException("Total brut incohérent pour la remise du ticket.");
            text += "* REMISE    : " + Strings.RSet(Strings.FormatNumber(savings), 8) +
                " DH / " + Strings.FormatNumber(savings / gross * 100m) + " %\r\n\r\n\r\n";
        }
        return text;
    }
}
