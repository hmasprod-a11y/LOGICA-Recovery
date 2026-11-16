using System.Data;
using System.Globalization;
using Hanouty.ArchitectureBridge;
using Hanouty.Checkout.MariaDb;
using MySql.Data.MySqlClient;

namespace Hanouty.Desktop.Bootstrap;

internal static class LogicaWaitingSale
{
    internal static string Save(Func<MySqlConnection> connections, IReadOnlyList<CheckoutBatchLine> basket,
        string cashier, string register)
    {
        if (basket.Count == 0) throw new InvalidOperationException("Le panier est vide.");
        var priced = MariaDbCashCheckoutServices.ReadCashSaleBasket(connections, basket);
        using var connection = connections();
        if (connection.State != ConnectionState.Open) connection.Open();
        using var transaction = connection.BeginTransaction(IsolationLevel.Serializable);
        InventoryDocumentValidation.RequireTransactionalTables(connection, transaction, "TABLE_ATTENTE", "TABLE_ARTICLES");
        var now = DateTime.Now;
        var id = now.ToString("HHmmssfffffff", CultureInfo.InvariantCulture).TrimStart('0');
        if (id.Length == 0) id = "0";
        using var existing = new MySqlCommand("SELECT V FROM TABLE_ATTENTE WHERE V=@id FOR UPDATE", connection, transaction);
        existing.Parameters.AddWithValue("@id", id);
        if (existing.ExecuteScalar() is not null)
            throw new InvalidOperationException("Numéro d’attente déjà utilisé, réessayez.");

        foreach (var line in priced)
        {
            using var command = new MySqlCommand("""
                INSERT INTO TABLE_ATTENTE
                  (Dates, Heure, ID_ARTICLE, Code, Article, Famille, PRIX_A, PRIX_MP, PRIX_V, Qté,
                   Remise, TOTAL_NET, Caissier, TAUX_TVA, PRINTER, PRINTER_DUPLICATA, GROUPE, V, POSTE,
                   ID_CLIENT, CODE_CLIENT, CLIENT)
                SELECT @date, @time, ID_ARTICLE, Code, Article, Famille, PRIX_A, PRIX_MP, @price, @quantity,
                       0, @amount, @cashier, TAUX_TVA, PRINTER, PRINTER_DUPLICATA, GROUPE, @id, @register, '0', '0', ''
                FROM TABLE_ARTICLES WHERE BINARY ID_ARTICLE=BINARY @article AND PRIX_V_1=@price
                """, connection, transaction);
            command.Parameters.AddWithValue("@date", now.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));
            command.Parameters.AddWithValue("@time", now.ToString("HH:mm:ss", CultureInfo.InvariantCulture));
            command.Parameters.AddWithValue("@price", line.UnitPrice);
            command.Parameters.AddWithValue("@quantity", line.Quantity);
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
