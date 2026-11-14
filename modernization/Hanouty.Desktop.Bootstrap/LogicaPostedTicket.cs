using System.Data;
using MySql.Data.MySqlClient;

namespace Hanouty.Desktop.Bootstrap;

internal sealed record LogicaTicketLine(string Article, decimal Quantity, decimal UnitPrice, decimal Discount, decimal Net);
internal sealed record LogicaTicketPayment(string Mode, decimal Amount);

internal sealed record LogicaPostedTicket(string Number, string Date, string Cashier, string Register,
    string Operation, decimal Total, IReadOnlyList<LogicaTicketLine> Lines, IReadOnlyList<LogicaTicketPayment> Payments)
{
    internal IEnumerable<string> FormatFrenchThreeColumnLines(
        Func<decimal, string> formatQuantity, Func<decimal, string> formatAmount) =>
        Lines.Select(line => LOGICA.ApplicationLayer.Checkout.LogicaFrenchThreeColumn.Line(
            formatQuantity(line.Quantity), line.Article, formatAmount(line.Net)));

    internal IReadOnlyList<string> FormatFrenchThreeColumnCashPayment(Func<decimal, string> formatAmount)
    {
        if (Payments.Any(payment => payment.Mode != "ESPECES") ||
            Payments.Count(payment => payment.Amount > 0m) != 1 ||
            Payments.Count(payment => payment.Amount < 0m) > 1 ||
            Payments.Any(payment => payment.Amount == 0m))
            throw new InvalidOperationException("Expected one cash tender and at most one change row.");

        var tender = Payments.Single(payment => payment.Amount > 0m).Amount;
        var change = -Payments.Where(payment => payment.Amount < 0m).Sum(payment => payment.Amount);
        return new[]
        {
            LOGICA.ApplicationLayer.Checkout.LogicaFrenchThreeColumn.Payment("ESPECES", formatAmount(tender)),
            LOGICA.ApplicationLayer.Checkout.LogicaFrenchThreeColumn.Payment("RENDU", formatAmount(change))
        };
    }

    internal static LogicaPostedTicket? Read(MySqlConnection connection, string id, string cashier, string register)
    {
        using var transaction = connection.BeginTransaction(IsolationLevel.RepeatableRead);
        using var command = connection.CreateCommand();
        command.Transaction = transaction;
        command.Parameters.AddWithValue("@id", id);
        command.Parameters.AddWithValue("@cashier", cashier);
        command.Parameters.AddWithValue("@register", register);
        command.CommandText = """
            SELECT TICKET, DATES, CAISSIER, POSTE, OPERATION, Total_NET
            FROM TABLE_VENTES_ENTETE
            WHERE BINARY ID_TICKET = BINARY @id AND BINARY CAISSIER = BINARY @cashier
              AND BINARY POSTE = BINARY @register AND OPERATION = 'VENTE'
            """;
        string number, date, operation;
        decimal total;
        using (var reader = command.ExecuteReader())
        {
            if (!reader.Read()) return null;
            number = reader.GetString(0);
            date = Convert.ToString(reader.GetValue(1), System.Globalization.CultureInfo.InvariantCulture) ?? "";
            operation = reader.GetString(4);
            total = reader.GetDecimal(5);
        }

        command.CommandText = """
            SELECT Article, Qté, PRIX_V, Remise, Total_NET
            FROM TABLE_VENTES_JOURNAL WHERE BINARY ID_TICKET = BINARY @id
            ORDER BY BINARY ID_ARTICLE
            """;
        var lines = new List<LogicaTicketLine>();
        using (var reader = command.ExecuteReader())
            while (reader.Read())
                lines.Add(new LogicaTicketLine(reader.GetString(0), reader.GetDecimal(1), reader.GetDecimal(2),
                    reader.GetDecimal(3), reader.GetDecimal(4)));

        command.CommandText = """
            SELECT MODE_P, MONTANT FROM TABLE_VENTES_REGLEMENTS WHERE BINARY ID_TICKET = BINARY @id
            """;
        var payments = new List<LogicaTicketPayment>();
        using (var reader = command.ExecuteReader())
            while (reader.Read())
                payments.Add(new LogicaTicketPayment(reader.GetString(0), reader.GetDecimal(1)));

        if (lines.Count == 0 || payments.Count == 0 ||
            lines.Sum(line => line.Net) != total || payments.Sum(payment => payment.Amount) != total)
            return null;

        transaction.Commit();
        return new LogicaPostedTicket(number, date, cashier, register, operation, total,
            lines.AsReadOnly(), payments.AsReadOnly());
    }
}
