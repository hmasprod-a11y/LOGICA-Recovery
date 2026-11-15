using System.Data;
using MySql.Data.MySqlClient;

namespace Hanouty.Desktop.Bootstrap;

internal sealed class StockIssueValidation(string connectionString)
{
    internal sealed record Line(string ArticleId, string Code, string Article, decimal Quantity);

    internal Line[] Read(string id)
    {
        using var connection = Open();
        using var transaction = connection.BeginTransaction(IsolationLevel.RepeatableRead);
        var lines = ReadDocument(connection, transaction, id, false);
        transaction.Commit();
        return lines;
    }

    internal void Validate(string id, IReadOnlyList<Line> reviewed, string actor, string pin)
    {
        if (string.IsNullOrWhiteSpace(pin)) throw new UnauthorizedAccessException();
        using var connection = Open();
        using var transaction = connection.BeginTransaction(IsolationLevel.Serializable);
        InventoryDocumentValidation.RequireTransactionalTables(connection, transaction, "TABLE_PASS",
            "TABLE_ARTICLES", "TABLE_SORTIES_ENTETE", "TABLE_SORTIES_DETAILS", "TABLE_MOUVEMENTS_STOCK");
        InventoryDocumentValidation.Authenticate(connection, transaction, actor, pin, validationOnly: true);
        var lines = ReadDocument(connection, transaction, id, true);
        if (!lines.SequenceEqual(reviewed))
            throw new InvalidOperationException("Le bon a changé. Ouvrez-le de nouveau.");

        // LOGICA records a positive issue quantity in the journal and subtracts it from stock.
        var now = DateTime.Now;
        foreach (var line in lines)
        {
            Execute("UPDATE TABLE_ARTICLES SET STOCK = STOCK - @quantity WHERE BINARY ID_ARTICLE = BINARY @article", 1,
                ("@quantity", line.Quantity), ("@article", line.ArticleId));
            Execute("""
                INSERT INTO TABLE_MOUVEMENTS_STOCK (DATES, HEURE, LIBELLE, ID_ARTICLE, CODE_ARTICLE, ARTICLE, QUANTITE)
                VALUES (@date, @time, @label, @article, @code, @name, @quantity)
                """, 1, ("@date", now.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture)),
                ("@time", now.ToString("HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture)),
                ("@label", "Bon de Sortie | " + id), ("@article", line.ArticleId), ("@code", line.Code),
                ("@name", line.Article), ("@quantity", line.Quantity));
        }
        Execute("UPDATE TABLE_SORTIES_DETAILS SET ETAT='VALIDER' WHERE BINARY ID_BS=BINARY @id AND ETAT='ENREGISTRER'",
            lines.Length, ("@id", id));
        Execute("UPDATE TABLE_SORTIES_ENTETE SET ETAT='VALIDER' WHERE BINARY ID_BS=BINARY @id AND ETAT='ENREGISTRER'",
            1, ("@id", id));
        transaction.Commit();

        void Execute(string sql, int count, params (string Name, object Value)[] parameters)
        {
            using var command = new MySqlCommand(sql, connection, transaction);
            foreach (var (name, value) in parameters) command.Parameters.AddWithValue(name, value);
            if (command.ExecuteNonQuery() != count)
                throw new InvalidOperationException("Le bon ou un article n’a pas pu être validé.");
        }
    }

    private MySqlConnection Open()
    {
        var settings = new MySqlConnectionStringBuilder(connectionString);
        if (settings.Server is not ("localhost" or "127.0.0.1" or "::1"))
            throw new InvalidOperationException("Base de stock locale requise.");
        var connection = new MySqlConnection(connectionString);
        try { connection.Open(); return connection; }
        catch { connection.Dispose(); throw; }
    }

    private static Line[] ReadDocument(MySqlConnection connection, MySqlTransaction transaction, string id, bool locked)
    {
        var lockRows = locked ? " FOR UPDATE" : "";
        using var command = new MySqlCommand(
            "SELECT ETAT FROM TABLE_SORTIES_ENTETE WHERE BINARY ID_BS=BINARY @id" + lockRows, connection, transaction);
        command.Parameters.AddWithValue("@id", id);
        using (var header = command.ExecuteReader())
            if (!header.Read() || header.GetString(0) != "ENREGISTRER" || header.Read())
                throw new InvalidOperationException("Bon de sortie enregistré introuvable.");

        command.CommandText = """
            SELECT ID_ARTICLE, Code, Article, Qté, ETAT FROM TABLE_SORTIES_DETAILS
            WHERE BINARY ID_BS=BINARY @id ORDER BY BINARY ID_ARTICLE
            """ + lockRows;
        var lines = new List<Line>();
        using var reader = command.ExecuteReader();
        while (reader.Read())
        {
            var quantity = reader.GetDecimal(3);
            if (reader.GetString(4) != "ENREGISTRER" || quantity <= 0 ||
                decimal.Round(quantity, 2, MidpointRounding.AwayFromZero) != quantity)
                throw new InvalidOperationException("Ligne de sortie non valide.");
            lines.Add(new Line(reader.GetString(0), reader.IsDBNull(1) ? "" : reader.GetString(1), reader.GetString(2), quantity));
        }
        if (lines.Count == 0 || lines.Select(x => x.ArticleId).Distinct(StringComparer.Ordinal).Count() != lines.Count)
            throw new InvalidOperationException("Le bon doit contenir des articles distincts.");
        return lines.ToArray();
    }
}
