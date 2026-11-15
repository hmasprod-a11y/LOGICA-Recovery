using System.Data;
using MySql.Data.MySqlClient;

namespace Hanouty.Desktop.Bootstrap;

internal sealed class StockIssueValidation(string connectionString)
{
    internal sealed record Line(string ArticleId, string Code, string Article, decimal Quantity);

    internal sealed record ArticleChoice(string Id, string Code, string Name)
    {
        public string Label => Name + " — " + Code;
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
