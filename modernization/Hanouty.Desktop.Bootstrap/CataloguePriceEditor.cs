using System.Data;
using MySql.Data.MySqlClient;

namespace Hanouty.Desktop.Bootstrap;

internal sealed class CataloguePriceEditor(string connectionString)
{
    internal sealed record Price(string Id, string Name, decimal Amount);

    internal Price Read(string id)
    {
        using var connection = Open();
        using var transaction = connection.BeginTransaction();
        return Read(connection, transaction, id);
    }

    internal void Update(Price reviewed, decimal price, string actor, string pin)
    {
        if (price < 0 || decimal.Round(price, 2) != price)
            throw new ArgumentOutOfRangeException(nameof(price));
        using var connection = Open();
        using var transaction = connection.BeginTransaction(IsolationLevel.Serializable);
        InventoryDocumentValidation.RequireTransactionalTables(connection, transaction, "TABLE_PASS",
            "TABLE_ARTICLES", "hanouty_catalogue_price_audit");
        // Form_2_ARTICLES.FUN_CAT_ACCES reserves catalogue editing for ADMIN.
        using (var auth = new MySqlCommand(
            "SELECT ListPass, Catégorie FROM TABLE_PASS WHERE BINARY ListUser=BINARY @actor FOR UPDATE",
            connection, transaction))
        {
            auth.Parameters.AddWithValue("@actor", actor);
            using var reader = auth.ExecuteReader();
            if (string.IsNullOrWhiteSpace(pin) || !reader.Read() || reader.IsDBNull(0) || reader.IsDBNull(1) ||
                reader.GetString(0) != pin || reader.GetString(1) != "ADMIN" || reader.Read())
                throw new UnauthorizedAccessException("Modification du catalogue réservée à un administrateur.");
        }
        if (Read(connection, transaction, reviewed.Id, lockRow: true) != reviewed)
            throw new InvalidOperationException("Le prix ou l’article a changé. Rechargez l’article.");
        if (price == reviewed.Amount) return;
        using (var update = new MySqlCommand(
            "UPDATE TABLE_ARTICLES SET PRIX_V_1=@price WHERE BINARY ID_ARTICLE=BINARY @id",
            connection, transaction))
        {
            update.Parameters.AddWithValue("@price", price);
            update.Parameters.AddWithValue("@id", reviewed.Id);
            if (update.ExecuteNonQuery() != 1)
                throw new InvalidOperationException("Modification du prix refusée.");
        }
        if (Read(connection, transaction, reviewed.Id, lockRow: true).Amount != price)
            throw new InvalidOperationException("Le prix n’a pas été enregistré exactement.");
        using (var audit = new MySqlCommand(
            "INSERT INTO hanouty_catalogue_price_audit (ARTICLE_ID,ACTOR,PREVIOUS_PRICE,NEW_PRICE) " +
            "VALUES (@id,@actor,@before,@after)", connection, transaction))
        {
            audit.Parameters.AddWithValue("@id", reviewed.Id);
            audit.Parameters.AddWithValue("@actor", actor);
            audit.Parameters.AddWithValue("@before", reviewed.Amount);
            audit.Parameters.AddWithValue("@after", price);
            if (audit.ExecuteNonQuery() != 1) throw new InvalidOperationException("Historique de prix non enregistré.");
        }
        transaction.Commit();
    }

    private static Price Read(MySqlConnection connection, MySqlTransaction transaction, string id, bool lockRow = false)
    {
        if (string.IsNullOrWhiteSpace(id)) throw new ArgumentException("Identifiant article requis.", nameof(id));
        using var command = new MySqlCommand(
            "SELECT Article, PRIX_V_1 FROM TABLE_ARTICLES WHERE BINARY ID_ARTICLE=BINARY @id" +
            (lockRow ? " FOR UPDATE" : ""), connection, transaction);
        command.Parameters.AddWithValue("@id", id);
        using var reader = command.ExecuteReader();
        if (!reader.Read() || reader.IsDBNull(0) || reader.IsDBNull(1))
            throw new InvalidOperationException("Article ou prix introuvable.");
        var price = new Price(id, reader.GetString(0), reader.GetDecimal(1));
        if (reader.Read()) throw new InvalidOperationException("Identifiant article ambigu.");
        return price;
    }

    private MySqlConnection Open()
    {
        var settings = new MySqlConnectionStringBuilder(connectionString);
        if (settings.Server is not ("localhost" or "127.0.0.1" or "::1"))
            throw new InvalidOperationException("Base locale requise.");
        var connection = new MySqlConnection(connectionString);
        try { connection.Open(); return connection; }
        catch { connection.Dispose(); throw; }
    }
}
