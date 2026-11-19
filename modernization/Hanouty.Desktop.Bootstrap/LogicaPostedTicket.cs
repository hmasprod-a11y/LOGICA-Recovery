using System.Data;
using MySql.Data.MySqlClient;

namespace Hanouty.Desktop.Bootstrap;

internal sealed record LogicaTicketLine(string Article, decimal Quantity, decimal UnitPrice, decimal Discount, decimal Net);
internal sealed record LogicaTicketPayment(string Mode, decimal Amount);

internal sealed record LogicaPostedTicket(string Number, string Date, string Cashier, string Register,
    string Operation, string Seller, decimal Total, IReadOnlyList<LogicaTicketLine> Lines, IReadOnlyList<LogicaTicketPayment> Payments)
{
    internal string CustomerId { get; init; } = "0";
    internal string CustomerCode { get; init; } = "0";
    internal string CustomerName { get; init; } = "";
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

    internal IReadOnlyList<string> FormatFrenchThreeColumnPayment(Func<decimal, string> formatAmount)
    {
        if (Operation == "CREDIT")
        {
            if (Payments.Count != 0) throw new InvalidOperationException("Un crédit ne doit pas contenir d’encaissement.");
            return Array.Empty<string>();
        }
        if (Payments.Any(payment => payment.Mode == "CARTE"))
        {
            var card = Payments.Where(payment => payment.Mode == "CARTE").ToArray();
            var cash = Payments.Where(payment => payment.Mode == "ESPECES" && payment.Amount > 0m).ToArray();
            var change = Payments.Where(payment => payment.Mode == "ESPECES" && payment.Amount < 0m).ToArray();
            if (card.Length != 1 || card[0].Amount <= 0m || cash.Length > 1 || change.Length > 1 ||
                Payments.Any(payment => payment.Mode is not ("CARTE" or "ESPECES") || payment.Amount == 0m) ||
                Payments.Sum(payment => payment.Amount) != Total ||
                (cash.Length == 0 && (change.Length != 0 || card[0].Amount != Total)) ||
                (cash.Length == 1 && card[0].Amount >= Total))
                throw new InvalidOperationException("Invalid persisted cash/card allocation.");
            var result = new List<string>();
            if (cash.Length == 1)
                result.Add(LOGICA.ApplicationLayer.Checkout.LogicaFrenchThreeColumn.Payment("ESPECES", formatAmount(cash[0].Amount)));
            result.Add(LOGICA.ApplicationLayer.Checkout.LogicaFrenchThreeColumn.Payment("CARTE", formatAmount(card[0].Amount)));
            result.Add(LOGICA.ApplicationLayer.Checkout.LogicaFrenchThreeColumn.Payment("RENDU",
                formatAmount(-change.Sum(payment => payment.Amount))));
            return result;
        }
        return FormatFrenchThreeColumnCashPayment(formatAmount);
    }

    internal IEnumerable<string> FormatFrenchThreeColumnIdentity(bool showTicketNumber)
    {
        if (Operation == "CREDIT") yield return "-------------------CREDIT------------------";
        if (CustomerId != "0" && CustomerName.Length != 0)
        {
            yield return "* CLIENT    : " + CustomerName;
            yield return "* ID        : " + CustomerId;
        }
        yield return LOGICA.ApplicationLayer.Checkout.LogicaFrenchThreeColumn.Cashier(Cashier, Seller);
        if (showTicketNumber)
            yield return LOGICA.ApplicationLayer.Checkout.LogicaFrenchThreeColumn.TicketNumber(Number);
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
            SELECT TICKET, DATES, CAISSIER, POSTE, OPERATION, Total_NET, ID_CLIENT, CODE_CLIENT, CLIENT
            FROM TABLE_VENTES_ENTETE
            WHERE BINARY ID_TICKET = BINARY @id AND BINARY CAISSIER = BINARY @cashier
              AND BINARY POSTE = BINARY @register AND BINARY OPERATION IN ('VENTE','CREDIT')
            """;
        string number, date, operation;
        string customerId, customerCode, customerName;
        decimal total;
        using (var reader = command.ExecuteReader())
        {
            if (!reader.Read()) return null;
            number = reader.GetString(0);
            date = Convert.ToString(reader.GetValue(1), System.Globalization.CultureInfo.InvariantCulture) ?? "";
            operation = reader.GetString(4);
            total = reader.GetDecimal(5);
            customerId = reader.IsDBNull(6) ? "0" : Convert.ToString(reader.GetValue(6))!;
            customerCode = reader.IsDBNull(7) ? "0" : Convert.ToString(reader.GetValue(7))!;
            customerName = reader.IsDBNull(8) ? "" : Convert.ToString(reader.GetValue(8))!;
            if (reader.Read()) return null;
        }

        command.CommandText = """
            SELECT Article, Qté, PRIX_V, Remise, Total_NET, Vendeur, OPERATION, ID_CLIENT, CODE_CLIENT, CLIENT
            FROM TABLE_VENTES_JOURNAL WHERE BINARY ID_TICKET = BINARY @id
            ORDER BY BINARY ID_ARTICLE
            """;
        var lines = new List<LogicaTicketLine>();
        string? seller = null;
        using (var reader = command.ExecuteReader())
        {
            while (reader.Read())
            {
                if (operation == "CREDIT" && (reader.IsDBNull(6) || reader.IsDBNull(7) || reader.IsDBNull(8) || reader.IsDBNull(9) ||
                    reader.GetString(6) != operation || Convert.ToString(reader.GetValue(7)) != customerId ||
                    Convert.ToString(reader.GetValue(8)) != customerCode || reader.GetString(9) != customerName)) return null;
                var rowSeller = reader.IsDBNull(5) ? "" : reader.GetString(5);
                if (seller is not null && seller != rowSeller) return null;
                seller = rowSeller;
                lines.Add(new LogicaTicketLine(reader.GetString(0), reader.GetDecimal(1), reader.GetDecimal(2),
                    reader.GetDecimal(3), reader.GetDecimal(4)));
            }
        }

        command.CommandText = """
            SELECT MODE_P, MONTANT FROM TABLE_VENTES_REGLEMENTS WHERE BINARY ID_TICKET = BINARY @id
            """;
        var payments = new List<LogicaTicketPayment>();
        using (var reader = command.ExecuteReader())
            while (reader.Read())
                payments.Add(new LogicaTicketPayment(reader.GetString(0), reader.GetDecimal(1)));

        if (lines.Count == 0 || total <= 0m || lines.Sum(line => line.Net) != total ||
            (operation == "CREDIT" ? payments.Count != 0 || customerId == "0" || string.IsNullOrWhiteSpace(customerName)
                : payments.Count == 0 || payments.Sum(payment => payment.Amount) != total))
            return null;

        transaction.Commit();
        return new LogicaPostedTicket(number, date, cashier, register, operation, seller ?? "", total,
            lines.AsReadOnly(), payments.AsReadOnly()) { CustomerId = customerId, CustomerCode = customerCode, CustomerName = customerName };
    }
}
