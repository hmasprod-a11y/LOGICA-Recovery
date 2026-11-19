using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using LOGICA.ApplicationLayer.Checkout;
using MySql.Data.MySqlClient;

namespace Hanouty.Desktop.Bootstrap;

internal static class LogicaCashReceiptPrinter
{


    internal static void Print(MySqlConnection connection, string directory, string operation, string cashier, string register)
    {
        var settings = LogicaReceiptSettings.Read(connection, directory)
            ?? throw new InvalidOperationException("Configuration du ticket LOGICA incomplète.");
        var route = ReceiptPrintRouting.Select(settings.Printer, true, "VENTE",
            settings.Connection, settings.Template, out _);
        if (settings.Printer == "0") return;
        if (route != ReceiptPrintRoute.FrenchThreeColumn)
            throw new InvalidOperationException("Ce modèle ou branchement LOGICA reste à raccorder.");

        var ticket = LogicaPostedTicket.Read(connection, operation, cashier, register)
            ?? throw new InvalidOperationException("Ticket enregistré introuvable.");
        using var command = connection.CreateCommand();
        command.CommandText = """
            SELECT OBJET, VALEUR FROM TABLE_PARAMETRES WHERE OBJET IN
            ('AFFICHER_MODE_P','AFFICHER_N_TICKET','AFFICHER_CODE_BARRE','PIED_TICKET')
            """;
        var options = new Dictionary<string, string>(StringComparer.Ordinal);
        using (var rows = command.ExecuteReader())
            while (rows.Read())
                options.Add(rows.GetString(0), rows.GetString(1));

        bool Flag(string name) => options.TryGetValue(name, out var value)
            ? Microsoft.VisualBasic.CompilerServices.Conversions.ToBoolean(value)
            : throw new InvalidOperationException("Paramètre LOGICA manquant : " + name);
        if (Flag("AFFICHER_CODE_BARRE"))
            throw new InvalidOperationException("Le QR du ticket LOGICA reste à raccorder.");
        if (!options.TryGetValue("PIED_TICKET", out var footer))
            throw new InvalidOperationException("Paramètre LOGICA manquant : PIED_TICKET.");

        static string Amount(decimal amount) => amount.ToString("0.00", CultureInfo.CurrentCulture);
        var lines = ticket.FormatFrenchThreeColumnLines(
            quantity => quantity.ToString("0.###", CultureInfo.CurrentCulture), Amount).ToArray();
        var payment = Flag("AFFICHER_MODE_P") ? ticket.FormatFrenchThreeColumnPayment(Amount) : Array.Empty<string>();
        var identity = ticket.FormatFrenchThreeColumnIdentity(Flag("AFFICHER_N_TICKET"));
        var tail = LogicaReceiptSummary.Format(ticket) + string.Join("\r\n", payment.Concat(identity)) + "\r\n" + footer + "\r\n" +
            DateTime.Now.ToString("            dd/MM/yyy HH:mm:ss", CultureInfo.CurrentCulture) +
            "(" + Microsoft.VisualBasic.Conversion.Val(register).ToString(CultureInfo.CurrentCulture) + ")";

        using var document = new PrintDocument { DocumentName = ticket.Number, PrintController = new StandardPrintController() };
        if (settings.Printer.Length != 0) document.PrinterSettings.PrinterName = settings.Printer;
        document.PrintPage += (_, page) => LogicaReceiptRenderer.Draw(
            page.Graphics ?? throw new InvalidOperationException("Surface d'impression indisponible."),
            lines, Amount(ticket.Total), tail);
        document.Print();
    }
}
