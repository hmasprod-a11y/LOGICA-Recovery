using System.Data;
using System.Globalization;
using MySql.Data.MySqlClient;

namespace Hanouty.Desktop.Bootstrap;

internal sealed class InventoryDocumentValidation(string connectionString)
{
    private sealed record CountedLine(string Id, decimal Baseline, decimal Physical);
    private sealed record Article(string Code, string Name, decimal Stock);

    internal static void Authenticate(MySqlConnection connection, MySqlTransaction transaction,
        string actor, string pin, bool validationOnly)
    {
        using var command = new MySqlCommand(
            "SELECT ListPass, Catégorie FROM TABLE_PASS WHERE BINARY ListUser=BINARY @actor FOR UPDATE",
            connection, transaction);
        command.Parameters.AddWithValue("@actor", actor);
        using var reader = command.ExecuteReader();
        if (!reader.Read() || reader.IsDBNull(0) || reader.IsDBNull(1) ||
            !string.Equals(reader.GetString(0), pin, StringComparison.Ordinal) ||
            (validationOnly ? reader.GetString(1) is not ("ADMIN" or "MANAGER") :
                reader.GetString(1) is not ("ADMIN" or "MANAGER" or "UTILISATEUR")) || reader.Read())
            throw new UnauthorizedAccessException("Inventory operation is not authorized.");
    }

    internal string Create(IReadOnlyList<string> articleIds, string actor, string pin)
    {
        if (string.IsNullOrWhiteSpace(actor) || string.IsNullOrWhiteSpace(pin) ||
            articleIds.Count == 0 || articleIds.Any(string.IsNullOrWhiteSpace) ||
            articleIds.Distinct(StringComparer.Ordinal).Count() != articleIds.Count)
            throw new ArgumentException("Inventory requires distinct articles and an authenticated operator.");
        using var connection = OpenLocal();
        using var transaction = connection.BeginTransaction(IsolationLevel.Serializable);
        RequireTransactionalTables(connection, transaction, "TABLE_NUM", "TABLE_PASS", "TABLE_ARTICLES",
            "TABLE_INVENTAIRES_ENTETE", "TABLE_INVENTAIRES_DETAILS");
        Authenticate(connection, transaction, actor, pin, validationOnly: false);

        MySqlCommand Command(string sql, params (string Name, object Value)[] parameters)
        {
            var command = new MySqlCommand(sql, connection, transaction);
            foreach (var (name, value) in parameters) command.Parameters.AddWithValue(name, value);
            return command;
        }
        void Write(string sql, params (string Name, object Value)[] parameters)
        {
            using var command = Command(sql, parameters);
            if (command.ExecuteNonQuery() != 1)
                throw new InvalidOperationException("Inventory document could not be saved.");
        }

        long number;
        using (var sequence = Command("SELECT INV FROM TABLE_NUM WHERE ID=0 FOR UPDATE"))
        using (var reader = sequence.ExecuteReader())
        {
            if (!reader.Read() || reader.IsDBNull(0))
                throw new InvalidOperationException("Inventory numbering is unavailable.");
            number = reader.GetInt64(0);
            if (number < 0 || reader.Read())
                throw new InvalidOperationException("Inventory numbering is invalid.");
        }
        var id = "INV" + number.ToString("D6", CultureInfo.InvariantCulture);
        using (var duplicate = Command(
            "SELECT COUNT(*) FROM TABLE_INVENTAIRES_ENTETE WHERE BINARY ID_INV=BINARY @id", ("@id", id)))
            if (Convert.ToInt64(duplicate.ExecuteScalar(), CultureInfo.InvariantCulture) != 0)
                throw new InvalidOperationException("The inventory number is already used.");

        var date = DateTime.Today;
        Write("INSERT INTO TABLE_INVENTAIRES_ENTETE (Dates, ID_INV, UTILISATEUR, TOTAL_VALEUR, ETAT) " +
            "VALUES (@date,@id,@actor,0,'ENREGISTRER')", ("@date", date), ("@id", id), ("@actor", actor));
        foreach (var articleId in articleIds.OrderBy(value => value, StringComparer.Ordinal))
        {
            string code;
            string name;
            decimal stock;
            decimal cost;
            using (var article = Command(
                "SELECT Code, Article, STOCK, PRIX_A FROM TABLE_ARTICLES WHERE BINARY ID_ARTICLE=BINARY @article FOR UPDATE",
                ("@article", articleId)))
            using (var reader = article.ExecuteReader())
            {
                if (!reader.Read() || reader.IsDBNull(2) || reader.IsDBNull(3))
                    throw new InvalidOperationException("Inventory article or its baseline is missing.");
                code = reader.IsDBNull(0) ? "" : reader.GetString(0);
                name = reader.IsDBNull(1) ? "" : reader.GetString(1);
                stock = reader.GetDecimal(2);
                cost = reader.GetDecimal(3);
                if (reader.Read()) throw new InvalidOperationException("Inventory article identity is ambiguous.");
            }
            Write("INSERT INTO TABLE_INVENTAIRES_DETAILS " +
                "(Dates,ID_INV,N_INV,ID_ARTICLE,Code,Article,PRIX_A,STOCK_LOGIQUE,STOCK_PHYSIQUE,ECART,VALEUR,ETAT) " +
                "VALUES (@date,@id,'',@article,@code,@name,@cost,@stock,NULL,NULL,NULL,'ENREGISTRER')",
                ("@date", date), ("@id", id), ("@article", articleId), ("@code", code),
                ("@name", name), ("@cost", cost), ("@stock", stock));
        }
        Write("UPDATE TABLE_NUM SET INV=INV+1 WHERE ID=0 AND INV=@number", ("@number", number));
        transaction.Commit();
        return id;
    }

    internal void Validate(string document, string actor, string pin,
        IReadOnlyDictionary<string, (decimal Baseline, decimal? Previous, decimal Physical)>? counted = null)
    {
        if (string.IsNullOrWhiteSpace(document) || string.IsNullOrWhiteSpace(actor) ||
            string.IsNullOrWhiteSpace(pin))
            throw new ArgumentException("Inventory document and authenticated operator are required.");
        using var connection = OpenLocal();
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

        RequireTransactionalTables(connection, transaction, "TABLE_PASS", "TABLE_ARTICLES",
            "TABLE_MOUVEMENTS_STOCK", "TABLE_INVENTAIRES_ENTETE", "TABLE_INVENTAIRES_DETAILS");

        Authenticate(connection, transaction, actor, pin, validationOnly: true);

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
                ("@date", now.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)), ("@time", now.ToString("HH:mm:ss", CultureInfo.InvariantCulture)),
                ("@audit", audit), ("@article", line.Id), ("@code", article.Code),
                ("@name", article.Name), ("@quantity", line.Physical.ToString(CultureInfo.InvariantCulture)));
        }
        if (counted is null)
            Write("UPDATE TABLE_INVENTAIRES_DETAILS SET ETAT='VALIDER' WHERE BINARY ID_INV=BINARY @id AND ETAT='ENREGISTRER'",
            lines.Count, ("@id", document));
        if (counted is null)
            Write("UPDATE TABLE_INVENTAIRES_ENTETE SET ETAT='VALIDER' WHERE BINARY ID_INV=BINARY @id AND ETAT='ENREGISTRER'",
                1, ("@id", document));
        else
            Write("UPDATE TABLE_INVENTAIRES_ENTETE SET ETAT='VALIDER', TOTAL_VALEUR=" +
                "(SELECT COALESCE(SUM(VALEUR),0) FROM TABLE_INVENTAIRES_DETAILS WHERE BINARY ID_INV=BINARY @id) " +
                "WHERE BINARY ID_INV=BINARY @id AND ETAT='ENREGISTRER'", 1, ("@id", document));
        transaction.Commit();
    }
    private MySqlConnection OpenLocal()
    {
        var endpoint = new MySqlConnectionStringBuilder(connectionString);
        if (endpoint.Server is not ("localhost" or "127.0.0.1" or "::1"))
            throw new InvalidOperationException("Inventory requires a local database.");
        var connection = new MySqlConnection(connectionString);
        try { connection.Open(); return connection; }
        catch { connection.Dispose(); throw; }
    }

    internal static void RequireTransactionalTables(MySqlConnection connection,
        MySqlTransaction transaction, params string[] tables)
    {
        using var command = new MySqlCommand(
            "SELECT ENGINE FROM information_schema.TABLES WHERE TABLE_SCHEMA=DATABASE() AND TABLE_NAME=@table",
            connection, transaction);
        var parameter = command.Parameters.AddWithValue("@table", "");
        foreach (var table in tables)
        {
            parameter.Value = table;
            if (!Equals(command.ExecuteScalar(), "InnoDB"))
                throw new InvalidOperationException("Inventory requires the complete transactional LOGICA schema.");
        }
    }
}
