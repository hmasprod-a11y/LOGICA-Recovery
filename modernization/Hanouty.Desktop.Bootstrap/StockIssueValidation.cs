using System.Data;
using MySql.Data.MySqlClient;

namespace Hanouty.Desktop.Bootstrap;

internal sealed class StockIssueValidation(string connectionString)
{
    internal sealed record Line(string ArticleId, string Code, string Article, decimal Quantity);

    internal sealed record Document(string Type, string Notes, Line[] Lines);
    internal sealed record Movement(string Reference, string Actor, string Reason, string Code,
        string Article, decimal Quantity, decimal? StockBefore, decimal? StockAfter, DateTime? ValidatedUtc);
    internal sealed record ValidationResult(Movement[] Movements, bool HistorySaved);

    internal sealed record ArticleChoice(string Id, string Code, string Name)
    {
        public string Label => $"{Name} — {Code} [{Id}]";

        internal bool Matches(string search) =>
            Name.Contains(search, StringComparison.CurrentCultureIgnoreCase) ||
            Code.Contains(search, StringComparison.OrdinalIgnoreCase) ||
            Id.Contains(search, StringComparison.OrdinalIgnoreCase);
    }

    internal ArticleChoice[] Articles()
    {
        using var connection = Open();
        using var command = new MySqlCommand("SELECT ID_ARTICLE, Code, Article FROM TABLE_ARTICLES ORDER BY Article, ID_ARTICLE", connection);
        using var reader = command.ExecuteReader();
        var result = new List<ArticleChoice>();
        while (reader.Read())
            result.Add(new ArticleChoice(reader.GetString(0), reader.IsDBNull(1) ? "" : reader.GetString(1), reader.GetString(2)));
        return result.ToArray();
    }

    internal string Create(DateTime date, string type, string notes, IReadOnlyDictionary<string, decimal> quantities,
        string actor, string pin)
    {
        if (type is not ("PERTE" or "TRANSFERT" or "AUTRE") || quantities.Count == 0 ||
            string.IsNullOrWhiteSpace(pin) || quantities.Values.Any(q => q <= 0 || decimal.Round(q, 2) != q))
            throw new InvalidOperationException("Date, type et lignes du bon requis.");
        using var connection = Open();
        using var transaction = connection.BeginTransaction(IsolationLevel.Serializable);
        InventoryDocumentValidation.RequireTransactionalTables(connection, transaction, "TABLE_PASS", "TABLE_NUM",
            "TABLE_ARTICLES", "TABLE_SORTIES_ENTETE", "TABLE_SORTIES_DETAILS");
        InventoryDocumentValidation.Authenticate(connection, transaction, actor, pin, validationOnly: false);

        using var counter = Command("SELECT BS FROM TABLE_NUM WHERE ID=0 FOR UPDATE");
        var sequence = Convert.ToInt64(counter.ExecuteScalar());
        if (sequence < 1) throw new InvalidOperationException("Compteur BS introuvable.");
        var id = "BS" + sequence.ToString("000000", System.Globalization.CultureInfo.InvariantCulture);
        using var nextRow = Command("SELECT COALESCE(MAX(ID),0)+1 FROM TABLE_SORTIES_ENTETE");
        var rowId = Convert.ToInt64(nextRow.ExecuteScalar());
        var lines = new List<(ArticleChoice Article, decimal Quantity, decimal Cost, decimal Price, decimal CostNet, decimal PriceNet)>();
        foreach (var (articleId, quantity) in quantities.OrderBy(x => x.Key, StringComparer.Ordinal))
        {
            using var article = Command(
                "SELECT Code, Article, PRIX_A, PRIX_V_1 FROM TABLE_ARTICLES WHERE BINARY ID_ARTICLE=BINARY @article FOR UPDATE",
                ("@article", articleId));
            using var row = article.ExecuteReader();
            if (!row.Read()) throw new InvalidOperationException("Article introuvable.");
            var choice = new ArticleChoice(articleId, row.IsDBNull(0) ? "" : row.GetString(0), row.GetString(1));
            var cost = row.GetDecimal(2);
            var price = row.GetDecimal(3);
            if (row.Read()) throw new InvalidOperationException("Article en double.");
            lines.Add((choice, quantity, Round(cost), Round(price), Round(quantity * cost), Round(quantity * price)));
        }

        Write("""
            INSERT INTO TABLE_SORTIES_ENTETE
            (ID, ID_BS, Dates, UTILISATEUR, ID_FOURNISSEUR, CODE_FOURNISSEUR, FOURNISSEUR, TYPE, TOTAL_NET_ACHATS, TOTAL_NET_VENTES, NOTES, ETAT)
            VALUES (@row, @id, @date, @actor, '0', '0', '', @type, @cost, @price, @notes, 'ENREGISTRER')
            """, ("@row", rowId), ("@id", id), ("@date", date.Date), ("@actor", actor), ("@type", type),
            ("@cost", lines.Sum(x => x.CostNet)), ("@price", lines.Sum(x => x.PriceNet)), ("@notes", notes));
        foreach (var line in lines)
            Write("""
                INSERT INTO TABLE_SORTIES_DETAILS
                (Dates, ID_BS, ID_FOURNISSEUR, CODE_FOURNISSEUR, FOURNISSEUR, TYPE, ID_ARTICLE, Code, Article,
                 Prix_A, Prix_V, Qté, TOTAL_NET_ACHATS, TOTAL_NET_VENTES, ETAT)
                VALUES (@date, @id, '0', '0', '', @type, @article, @code, @name, @cost, @price, @quantity,
                        @costNet, @priceNet, 'ENREGISTRER')
                """, ("@date", date.Date), ("@id", id), ("@type", type), ("@article", line.Article.Id),
                ("@code", line.Article.Code), ("@name", line.Article.Name), ("@cost", line.Cost), ("@price", line.Price),
                ("@quantity", line.Quantity), ("@costNet", line.CostNet), ("@priceNet", line.PriceNet));
        Write("UPDATE TABLE_NUM SET BS=BS+1 WHERE ID=0 AND BS=@sequence", ("@sequence", sequence));
        transaction.Commit();
        return id;

        static decimal Round(decimal value) => decimal.Round(value, 2, MidpointRounding.AwayFromZero);

        MySqlCommand Command(string sql, params (string Name, object Value)[] parameters)
        {
            var command = new MySqlCommand(sql, connection, transaction);
            foreach (var (name, value) in parameters) command.Parameters.AddWithValue(name, value);
            return command;
        }

        void Write(string sql, params (string Name, object Value)[] parameters)
        {
            using var command = Command(sql, parameters);
            if (command.ExecuteNonQuery() != 1) throw new InvalidOperationException("Écriture du bon incomplète.");
        }
    }

    internal Line[] Read(string id) => ReadForValidation(id).Lines;

    internal Document ReadForValidation(string id)
    {
        using var connection = Open();
        using var transaction = connection.BeginTransaction(IsolationLevel.RepeatableRead);
        var lines = ReadDocument(connection, transaction, id, false);
        transaction.Commit();
        return lines;
    }

    internal void Validate(string id, IReadOnlyList<Line> reviewed, string actor, string pin) =>
        Validate(id, reviewed, null, actor, pin);

    internal ValidationResult Validate(string id, Document reviewed, string actor, string pin) =>
        Validate(id, reviewed.Lines, reviewed, actor, pin);

    private ValidationResult Validate(string id, IReadOnlyList<Line> reviewedLines, Document? reviewed,
        string actor, string pin)
    {
        if (string.IsNullOrWhiteSpace(pin)) throw new UnauthorizedAccessException();
        using var connection = Open();
        using var transaction = connection.BeginTransaction(IsolationLevel.Serializable);
        InventoryDocumentValidation.RequireTransactionalTables(connection, transaction, "TABLE_PASS",
            "TABLE_ARTICLES", "TABLE_SORTIES_ENTETE", "TABLE_SORTIES_DETAILS", "TABLE_MOUVEMENTS_STOCK");
        InventoryDocumentValidation.Authenticate(connection, transaction, actor, pin, validationOnly: true);
        var document = ReadDocument(connection, transaction, id, true);
        var lines = document.Lines;
        if (!lines.SequenceEqual(reviewedLines) ||
            (reviewed is not null && (document.Type != reviewed.Type || document.Notes != reviewed.Notes)))
            throw new InvalidOperationException("Le bon a changé. Ouvrez-le de nouveau.");

        var saveHistory = HasMovementHistory(connection, transaction);
        if (saveHistory)
            InventoryDocumentValidation.RequireTransactionalTables(connection, transaction, "hanouty_stock_issue_history");

        // LOGICA records a positive issue quantity in the journal and subtracts it from stock.
        var validatedUtc = DateTime.UtcNow;
        var now = validatedUtc.ToLocalTime();
        var movements = new List<Movement>(lines.Length);
        var reason = string.IsNullOrWhiteSpace(document.Notes)
            ? document.Type
            : $"{document.Type} · {document.Notes}";
        foreach (var line in lines)
        {
            var stockBefore = ReadStock(line.ArticleId);
            Execute("UPDATE TABLE_ARTICLES SET STOCK = STOCK - @quantity WHERE BINARY ID_ARTICLE = BINARY @article", 1,
                ("@quantity", line.Quantity), ("@article", line.ArticleId));
            var stockAfter = ReadStock(line.ArticleId);
            Execute("""
                INSERT INTO TABLE_MOUVEMENTS_STOCK (DATES, HEURE, LIBELLE, ID_ARTICLE, CODE_ARTICLE, ARTICLE, QUANTITE)
                VALUES (@date, @time, @label, @article, @code, @name, @quantity)
                """, 1, ("@date", now.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture)),
                ("@time", now.ToString("HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture)),
                ("@label", "Bon de Sortie | " + id), ("@article", line.ArticleId), ("@code", line.Code),
                ("@name", line.Article), ("@quantity", line.Quantity));
            if (saveHistory)
                Execute("""
                    INSERT INTO hanouty_stock_issue_history
                    (ISSUE_ID, ARTICLE_ID, ACTOR, REASON, CODE, ARTICLE, QUANTITY, STOCK_BEFORE, STOCK_AFTER, VALIDATED_UTC)
                    VALUES (@id, @article, @actor, @reason, @code, @name, @quantity, @before, @after, @utc)
                    """, 1, ("@id", id), ("@article", line.ArticleId), ("@actor", actor),
                    ("@reason", reason), ("@code", line.Code), ("@name", line.Article),
                    ("@quantity", line.Quantity), ("@before", stockBefore), ("@after", stockAfter), ("@utc", validatedUtc));
            movements.Add(new Movement(id, actor, reason, line.Code, line.Article,
                line.Quantity, stockBefore, stockAfter, validatedUtc));
        }
        Execute("UPDATE TABLE_SORTIES_DETAILS SET ETAT='VALIDER' WHERE BINARY ID_BS=BINARY @id AND ETAT='ENREGISTRER'",
            lines.Length, ("@id", id));
        Execute("UPDATE TABLE_SORTIES_ENTETE SET ETAT='VALIDER' WHERE BINARY ID_BS=BINARY @id AND ETAT='ENREGISTRER'",
            1, ("@id", id));
        transaction.Commit();
        return new ValidationResult(movements.ToArray(), saveHistory);

        decimal ReadStock(string articleId)
        {
            using var command = new MySqlCommand(
                "SELECT STOCK FROM TABLE_ARTICLES WHERE BINARY ID_ARTICLE=BINARY @article FOR UPDATE",
                connection, transaction);
            command.Parameters.AddWithValue("@article", articleId);
            using var reader = command.ExecuteReader();
            if (!reader.Read() || reader.IsDBNull(0))
                throw new InvalidOperationException("Stock de l’article introuvable.");
            var stock = reader.GetDecimal(0);
            if (reader.Read())
                throw new InvalidOperationException("Article en double.");
            return stock;
        }

        void Execute(string sql, int count, params (string Name, object Value)[] parameters)
        {
            using var command = new MySqlCommand(sql, connection, transaction);
            foreach (var (name, value) in parameters) command.Parameters.AddWithValue(name, value);
            if (command.ExecuteNonQuery() != count)
                throw new InvalidOperationException("Le bon ou un article n’a pas pu être validé.");
        }
    }

    internal Movement[] ReadHistory(string id)
    {
        using var connection = Open();
        using var transaction = connection.BeginTransaction(IsolationLevel.RepeatableRead);
        var movements = new List<Movement>();
        if (HasMovementHistory(connection, transaction))
        {
            using var command = new MySqlCommand("""
                SELECT ISSUE_ID, ACTOR, REASON, CODE, ARTICLE, QUANTITY, STOCK_BEFORE, STOCK_AFTER, VALIDATED_UTC
                FROM hanouty_stock_issue_history
                WHERE ISSUE_ID = @id AND BINARY ISSUE_ID = BINARY @id
                ORDER BY ARTICLE_ID
                """, connection, transaction);
            command.Parameters.AddWithValue("@id", id);
            using var reader = command.ExecuteReader();
            while (reader.Read())
                movements.Add(new Movement(reader.GetString(0), reader.GetString(1), reader.GetString(2),
                    reader.GetString(3), reader.GetString(4), reader.GetDecimal(5), reader.GetDecimal(6),
                    reader.GetDecimal(7), DateTime.SpecifyKind(reader.GetDateTime(8), DateTimeKind.Utc)));
        }

        if (movements.Count == 0)
        {
            using var command = new MySqlCommand("""
                SELECT CODE_ARTICLE, ARTICLE, QUANTITE FROM TABLE_MOUVEMENTS_STOCK
                WHERE LIBELLE = @label AND BINARY LIBELLE = BINARY @label
                ORDER BY DATES, HEURE, ID_ARTICLE
                """, connection, transaction);
            command.Parameters.AddWithValue("@label", "Bon de Sortie | " + id);
            using var reader = command.ExecuteReader();
            while (reader.Read())
                movements.Add(new Movement(id, "", "",
                    reader.IsDBNull(0) ? "" : reader.GetString(0), reader.IsDBNull(1) ? "" : reader.GetString(1),
                    reader.GetDecimal(2), null, null, null));
        }
        transaction.Commit();
        return movements.ToArray();
    }

    private static bool HasMovementHistory(MySqlConnection connection, MySqlTransaction? transaction)
    {
        using var command = new MySqlCommand("""
            SELECT COUNT(*) FROM information_schema.TABLES
            WHERE TABLE_SCHEMA = DATABASE() AND TABLE_NAME = 'hanouty_stock_issue_history'
            """, connection, transaction);
        return Convert.ToInt32(command.ExecuteScalar()) == 1;
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

    private static Document ReadDocument(MySqlConnection connection, MySqlTransaction transaction, string id, bool locked)
    {
        var lockRows = locked ? " FOR UPDATE" : "";
        using var command = new MySqlCommand(
            "SELECT ETAT, TYPE, NOTES FROM TABLE_SORTIES_ENTETE WHERE BINARY ID_BS=BINARY @id" + lockRows, connection, transaction);
        command.Parameters.AddWithValue("@id", id);
        string type, notes;
        using (var header = command.ExecuteReader())
        {
            if (!header.Read() || header.GetString(0) != "ENREGISTRER")
                throw new InvalidOperationException("Bon de sortie enregistré introuvable.");
            type = header.IsDBNull(1) ? "" : header.GetString(1);
            notes = header.IsDBNull(2) ? "" : header.GetString(2);
            if (header.Read())
                throw new InvalidOperationException("Bon de sortie en double.");
        }

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
        return new Document(type, notes, lines.ToArray());
    }
}
