using System.Data;
using System.Globalization;
using MySql.Data.MySqlClient;

namespace Hanouty.Desktop.Bootstrap;

internal sealed class InventoryDocumentValidation(string connectionString)
{
    private sealed record CountedLine(string Id, decimal Baseline, decimal Physical);
    private sealed record Article(string Code, string Name, decimal Stock);

    internal void Validate(string document, string actor, string pin,
        IReadOnlyDictionary<string, (decimal Baseline, decimal? Previous, decimal Physical)>? counted = null)
    {
        if (string.IsNullOrWhiteSpace(document) || string.IsNullOrWhiteSpace(actor) ||
            string.IsNullOrWhiteSpace(pin))
            throw new ArgumentException("Inventory document and authenticated operator are required.");
        var endpoint = new MySqlConnectionStringBuilder(connectionString);
        if (endpoint.Server is not ("localhost" or "127.0.0.1" or "::1"))
            throw new InvalidOperationException("Inventory validation requires a local database.");

        using var connection = new MySqlConnection(connectionString);
        connection.Open();
        using var transaction = connection.BeginTransaction(IsolationLevel.Serializable);

        MySqlCommand Command(string sql, params (string Name, object Value)[] parameters)
        {
            var command = new MySqlCommand(sql, connection, transaction);
            foreach (var (name, value) in parameters) command.Parameters.AddWithValue(name, value);
            return command;
        }

        void Write(string sql, int affected, params (string Name, object Value)[] parameters)
        {
            using var command = Command(sql, parameters);
            if (command.ExecuteNonQuery() != affected)
                throw new InvalidOperationException("Inventory changed before validation.");
        }

        foreach (var table in new[] { "TABLE_PASS", "TABLE_ARTICLES", "TABLE_MOUVEMENTS_STOCK",
            "TABLE_INVENTAIRES_ENTETE", "TABLE_INVENTAIRES_DETAILS" })
        {
            using var command = Command(
                "SELECT ENGINE FROM information_schema.TABLES WHERE TABLE_SCHEMA=DATABASE() AND TABLE_NAME=@table",
                ("@table", table));
            if (!Equals(command.ExecuteScalar(), "InnoDB"))
                throw new InvalidOperationException("Inventory requires the complete transactional LOGICA schema.");
        }

        // LOGICA Form_6_INVENTAIRES.FUN_CAT_ACCES grants document validation to
        // authenticated ADMIN and MANAGER; manual adjustment has its own rules.
        using (var command = Command(
            "SELECT ListPass, Catégorie FROM TABLE_PASS WHERE BINARY ListUser=BINARY @actor FOR UPDATE",
            ("@actor", actor)))
        using (var reader = command.ExecuteReader())
        {
            if (!reader.Read() || reader.IsDBNull(0) || reader.IsDBNull(1) ||
                !string.Equals(reader.GetString(0), pin, StringComparison.Ordinal) ||
                reader.GetString(1) is not ("ADMIN" or "MANAGER") || reader.Read())
                throw new UnauthorizedAccessException("Inventory document validation is not authorized.");
        }

        DateTime documentDate;
        using (var command = Command(
            "SELECT Dates, ETAT FROM TABLE_INVENTAIRES_ENTETE WHERE BINARY ID_INV=BINARY @id FOR UPDATE",
            ("@id", document)))
        using (var reader = command.ExecuteReader())
        {
            if (!reader.Read() || reader.IsDBNull(0) || reader.IsDBNull(1) ||
                reader.GetString(1) != "ENREGISTRER")
                throw new InvalidOperationException("Inventory document is not open.");
            documentDate = reader.GetDateTime(0).Date;
            if (reader.Read()) throw new InvalidOperationException("Inventory document identity is ambiguous.");
        }

        var lines = new SortedDictionary<string, CountedLine>(StringComparer.Ordinal);
        using (var command = Command(
            "SELECT ID_ARTICLE, STOCK_LOGIQUE, STOCK_PHYSIQUE, ETAT FROM TABLE_INVENTAIRES_DETAILS " +
            "WHERE BINARY ID_INV=BINARY @id ORDER BY BINARY ID_ARTICLE FOR UPDATE", ("@id", document)))
        using (var reader = command.ExecuteReader())
        {
            while (reader.Read())
            {
                if (reader.IsDBNull(0) || reader.IsDBNull(1) || (counted is null && reader.IsDBNull(2)) ||
                    reader.IsDBNull(3) || reader.GetString(3) != "ENREGISTRER")
                    throw new InvalidOperationException("Inventory contains uncounted or invalid lines.");
                var id = reader.GetString(0);
                var baseline = reader.GetDecimal(1);
                decimal? previous = reader.IsDBNull(2) ? null : reader.GetDecimal(2);
                var physical = previous.GetValueOrDefault();
                if (counted is not null)
                {
                    if (!counted.TryGetValue(id, out var reviewed) || reviewed.Baseline != baseline ||
                        reviewed.Previous != previous)
                        throw new InvalidOperationException("Inventory document changed since opening.");
                    physical = reviewed.Physical;
                }
                var line = new CountedLine(id, baseline, physical);
                if (string.IsNullOrWhiteSpace(line.Id) || line.Physical < 0 || !lines.TryAdd(line.Id, line))
                    throw new InvalidOperationException("Inventory contains duplicate or invalid articles.");
            }
        }
        if (lines.Count == 0 || (counted is not null && counted.Count != lines.Count)) throw new InvalidOperationException("Inventory document is empty.");

        // The historical inventory screen can count selected articles. Require
        // complete, fresh counts for every article belonging to this document.
        var articles = new Dictionary<string, Article>(StringComparer.Ordinal);
        foreach (var line in lines.Values)
        {
            using var command = Command(
                "SELECT Code, Article, STOCK FROM TABLE_ARTICLES WHERE BINARY ID_ARTICLE=BINARY @article FOR UPDATE",
                ("@article", line.Id));
            using var reader = command.ExecuteReader();
            if (!reader.Read() || reader.IsDBNull(2))
                throw new InvalidOperationException("Inventory article is missing.");
            var article = new Article(reader.IsDBNull(0) ? "" : reader.GetString(0),
                reader.IsDBNull(1) ? "" : reader.GetString(1), reader.GetDecimal(2));
            if (reader.Read() || article.Stock != line.Baseline)
                throw new InvalidOperationException("Inventory stock is stale or article identity is ambiguous.");
            articles.Add(line.Id, article);
        }

        var now = DateTime.Now;
        foreach (var line in lines.Values)
        {
            var article = articles[line.Id];
            if (counted is not null)
                Write("UPDATE TABLE_INVENTAIRES_DETAILS SET STOCK_PHYSIQUE=@quantity, ECART=@quantity-STOCK_LOGIQUE, " +
                    "VALEUR=(@quantity-STOCK_LOGIQUE)*PRIX_A, ETAT='VALIDER' " +
                    "WHERE BINARY ID_INV=BINARY @id AND BINARY ID_ARTICLE=BINARY @article AND ETAT='ENREGISTRER'",
                    1, ("@quantity", line.Physical), ("@id", document), ("@article", line.Id));
            Write("UPDATE TABLE_ARTICLES SET STOCK=@quantity, STOCK_INITIAL=@quantity, DATE_INVENTAIRE=@date " +
                "WHERE BINARY ID_ARTICLE=BINARY @article", 1,
                ("@quantity", line.Physical), ("@date", documentDate), ("@article", line.Id));
            var audit = $"Inventaire [{actor}] {document}: " +
                line.Baseline.ToString(CultureInfo.InvariantCulture) + " -> " +
                line.Physical.ToString(CultureInfo.InvariantCulture);
            if (audit.Length > 255) throw new InvalidOperationException("Inventory audit exceeds the LOGICA column.");
            Write("INSERT INTO TABLE_MOUVEMENTS_STOCK (DATES,HEURE,LIBELLE,ID_ARTICLE,CODE_ARTICLE,ARTICLE,QUANTITE) " +
                "VALUES (@date,@time,@audit,@article,@code,@name,@quantity)", 1,
                ("@date", now.Date), ("@time", now.ToString("HH:mm:ss", CultureInfo.InvariantCulture)),
                ("@audit", audit), ("@article", line.Id), ("@code", article.Code),
                ("@name", article.Name), ("@quantity", line.Physical.ToString(CultureInfo.InvariantCulture)));
        }
        if (counted is null)
            Write("UPDATE TABLE_INVENTAIRES_DETAILS SET ETAT='VALIDER' WHERE BINARY ID_INV=BINARY @id AND ETAT='ENREGISTRER'",
            lines.Count, ("@id", document));
        Write("UPDATE TABLE_INVENTAIRES_ENTETE SET ETAT='VALIDER' WHERE BINARY ID_INV=BINARY @id AND ETAT='ENREGISTRER'",
            1, ("@id", document));
        transaction.Commit();
    }
}
