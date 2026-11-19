using System.Data;
using System.Globalization;
using Hanouty.ArchitectureBridge;
using Hanouty.Checkout.MariaDb;
using MySql.Data.MySqlClient;

namespace Hanouty.Desktop.Bootstrap;

internal static class LogicaWaitingSale
{
    internal sealed record Waiting(string Id, string Cashier, string Date, decimal Total)
    {
        public string Label => $"{Id} · {Cashier} · {Date} · {Total:N2} MAD";
    }

    internal static Waiting[] List(Func<MySqlConnection> connections)
    {
        using var connection = connections();
        if (connection.State != ConnectionState.Open) connection.Open();
        using var command = new MySqlCommand("""
            SELECT V, MAX(Caissier), MAX(Dates), SUM(TOTAL_NET)
            FROM TABLE_ATTENTE GROUP BY V ORDER BY MAX(Dates) DESC, V DESC
            """, connection);
        using var rows = command.ExecuteReader();
        var sales = new List<Waiting>();
        while (rows.Read())
            sales.Add(new Waiting(Convert.ToString(rows.GetValue(0), CultureInfo.InvariantCulture)!,
                Convert.ToString(rows.GetValue(1)) ?? "", Convert.ToString(rows.GetValue(2)) ?? "", rows.GetDecimal(3)));
        return sales.ToArray();
    }

    internal static CheckoutBatchLine[] Read(Func<MySqlConnection> connections, string id)
    {
        using var connection = connections();
        if (connection.State != ConnectionState.Open) connection.Open();
        using var transaction = connection.BeginTransaction();
        InventoryDocumentValidation.RequireTransactionalTables(connection, transaction, "TABLE_ATTENTE", "TABLE_ARTICLES");
        using var command = new MySqlCommand(
            "SELECT ID_ARTICLE, Qté, Remise, ID_CLIENT, PRIX_V, TOTAL_NET FROM TABLE_ATTENTE WHERE V=@id ORDER BY ID FOR UPDATE",
            connection, transaction);
        command.Parameters.AddWithValue("@id", id);
        var lines = new List<CheckoutBatchLine>();
        var saved = new Dictionary<string, (decimal Price, decimal Discount, decimal Net)>(StringComparer.Ordinal);
        using (var rows = command.ExecuteReader())
        {
            while (rows.Read())
            {
                var quantity = rows.GetDecimal(1);
                var discount = rows.GetDecimal(2);
                var customer = Convert.ToString(rows.GetValue(3));
                var article = rows.GetString(0);
                if (quantity <= 0 || quantity > int.MaxValue || decimal.Truncate(quantity) != quantity ||
                    discount < 0m || discount > 100m || (customer != "0" && !string.IsNullOrEmpty(customer)) ||
                    !saved.TryAdd(article, (rows.GetDecimal(4), discount, rows.GetDecimal(5))))
                    throw new InvalidOperationException("Reprenez ce panier dans LOGICA pour conserver ses conditions d’origine.");
                lines.Add(new CheckoutBatchLine(article, (int)quantity));
            }
        }
        if (lines.Count == 0 || lines.Select(x => x.ArticleId).Distinct(StringComparer.OrdinalIgnoreCase).Count() != lines.Count)
            throw new InvalidOperationException("Vente en attente indisponible ou contenant des lignes en double.");
        var current = MariaDbCashCheckoutServices.ReadCashSaleBasketInTransaction(connection, transaction, lines);
        if (current.Any(line => saved[line.ArticleId] != (line.UnitPrice, line.DiscountPercent, line.Amount)))
            throw new InvalidOperationException("Les conditions du panier en attente ont changé. Reprenez-le dans LOGICA.");
        transaction.Commit();
        return lines.ToArray();
    }

    internal static string Save(Func<MySqlConnection> connections, IReadOnlyList<CheckoutBatchLine> basket,
        string cashier, string register, ApprovedManualDiscount? manualDiscount = null)
    {
        if (basket.Count == 0) throw new InvalidOperationException("Le panier est vide.");
        using var connection = connections();
        if (connection.State != ConnectionState.Open) connection.Open();
        using var transaction = connection.BeginTransaction(IsolationLevel.Serializable);
        InventoryDocumentValidation.RequireTransactionalTables(connection, transaction, "TABLE_ATTENTE", "TABLE_ARTICLES");
        MariaDbCashCheckoutServices.ValidateManualDiscountForWaiting(manualDiscount, cashier, register,
            basket, connection, transaction);
        var now = DateTime.Now;
        var id = now.ToString("HHmmssfffffff", CultureInfo.InvariantCulture).TrimStart('0');
        if (id.Length == 0) id = "0";
        using var existing = new MySqlCommand("SELECT V FROM TABLE_ATTENTE WHERE V=@id FOR UPDATE", connection, transaction);
        existing.Parameters.AddWithValue("@id", id);
        if (existing.ExecuteScalar() is not null)
            throw new InvalidOperationException("Numéro d’attente déjà utilisé, réessayez.");
        var priced = MariaDbCashCheckoutServices.ReadCashSaleBasketInTransaction(connection, transaction, basket, manualDiscount);

        foreach (var line in priced)
        {
            using var command = new MySqlCommand("""
                INSERT INTO TABLE_ATTENTE
                  (Dates, Heure, ID_ARTICLE, Code, Article, Famille, PRIX_A, PRIX_MP, PRIX_V, Qté,
                   Remise, TOTAL_NET, Caissier, TAUX_TVA, PRINTER, PRINTER_DUPLICATA, GROUPE, V, POSTE,
                   ID_CLIENT, CODE_CLIENT, CLIENT)
                SELECT @date, @time, ID_ARTICLE, Code, Article, Famille, PRIX_A, PRIX_MP, @price, @quantity,
                       @discount, @amount, @cashier, TAUX_TVA, PRINTER, PRINTER_DUPLICATA, GROUPE, @id, @register, '0', '0', ''
                FROM TABLE_ARTICLES WHERE BINARY ID_ARTICLE=BINARY @article
                """, connection, transaction);
            command.Parameters.AddWithValue("@date", now.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));
            command.Parameters.AddWithValue("@time", now.ToString("HH:mm:ss", CultureInfo.InvariantCulture));
            command.Parameters.AddWithValue("@price", line.UnitPrice);
            command.Parameters.AddWithValue("@quantity", line.Quantity);
            command.Parameters.AddWithValue("@discount", line.DiscountPercent);
            command.Parameters.AddWithValue("@amount", line.Amount);
            command.Parameters.AddWithValue("@cashier", cashier);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@register", register);
            command.Parameters.AddWithValue("@article", line.ArticleId);
            if (command.ExecuteNonQuery() != 1)
                throw new InvalidOperationException("Le prix ou l’article a changé. Vérifiez le panier.");
        }
        transaction.Commit();
        return id;
    }
}
