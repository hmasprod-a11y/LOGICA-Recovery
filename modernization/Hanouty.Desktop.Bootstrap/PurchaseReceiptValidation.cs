using System.Data;
using System.Globalization;
using MySql.Data.MySqlClient;

namespace Hanouty.Desktop.Bootstrap;

internal sealed class PurchaseReceiptValidation(string connectionString)
{
    internal sealed record Line(string ArticleId, string ArticleName, decimal Quantity, decimal Cost, decimal SalePrice);
    internal sealed record Receipt(string Id, string SupplierId, string Supplier, IReadOnlyList<Line> Lines);

    internal Receipt Read(string id)
    {
        using var connection = Open();
        using var transaction = connection.BeginTransaction(IsolationLevel.RepeatableRead);
        return Read(connection, transaction, id, lockRows: false);
    }

    internal void Validate(Receipt reviewed, string actor, string pin)
    {
        using var connection = Open();
        using var transaction = connection.BeginTransaction(IsolationLevel.Serializable);
        InventoryDocumentValidation.RequireTransactionalTables(connection, transaction, "TABLE_PASS",
            "TABLE_RECEPTIONS_ENTETE", "TABLE_RECEPTIONS_DETAILS", "TABLE_FOURNISSEURS",
            "TABLE_ARTICLES", "TABLE_MOUVEMENTS_STOCK");
        InventoryDocumentValidation.Authenticate(connection, transaction, actor, pin, validationOnly: true);
        var current = Read(connection, transaction, reviewed.Id, lockRows: true);
        if (current.SupplierId != reviewed.SupplierId || current.Supplier != reviewed.Supplier ||
            !current.Lines.SequenceEqual(reviewed.Lines))
            throw new InvalidOperationException("La réception a changé. Rechargez le document.");

        using (var supplier = Command(connection, transaction,
            "SELECT ID_FOURNISSEUR FROM TABLE_FOURNISSEURS WHERE BINARY ID_FOURNISSEUR=BINARY @id FOR UPDATE",
            ("@id", current.SupplierId)))
        using (var reader = supplier.ExecuteReader())
            if (!reader.Read() || reader.Read()) throw new InvalidOperationException("Fournisseur absent ou ambigu.");

        void Write(string sql, int expected, params (string Name, object Value)[] values)
        {
            using var command = Command(connection, transaction, sql, values);
            if (command.ExecuteNonQuery() != expected)
                throw new InvalidOperationException("La réception a changé pendant la validation.");
        }

        var now = DateTime.Now;
        foreach (var line in current.Lines)
        {
            decimal stock;
            decimal oldAverage;
            string code;
            string name;
            using (var article = Command(connection, transaction,
                "SELECT STOCK, PRIX_MP, Code, Article FROM TABLE_ARTICLES WHERE BINARY ID_ARTICLE=BINARY @id FOR UPDATE",
                ("@id", line.ArticleId)))
            using (var reader = article.ExecuteReader())
            {
                if (!reader.Read() || reader.IsDBNull(0) || reader.IsDBNull(1) || reader.IsDBNull(3))
                    throw new InvalidOperationException("Article ou coût moyen manquant.");
                stock = reader.GetDecimal(0);
                oldAverage = reader.GetDecimal(1);
                code = reader.IsDBNull(2) ? "" : reader.GetString(2);
                name = reader.GetString(3);
                if (oldAverage < 0 || reader.Read()) throw new InvalidOperationException("Article ou coût moyen invalide.");
            }
            // LOGICA Form_6_RECEPTIONS rounds the inputs with FLOUSS before the weighted average.
            var stockBasis = Round(stock);
            var quantity = Round(line.Quantity);
            var cost = Round(line.Cost);
            var average = stock > 0
                ? Round((Round(oldAverage) * stockBasis + quantity * cost) / (stockBasis + quantity))
                : cost;
            Write("UPDATE TABLE_ARTICLES SET STOCK=STOCK+@qty, PRIX_A=@cost, PRIX_MP=@average, " +
                "PRIX_V_1=@sale, FOURNISSEUR=@supplier WHERE BINARY ID_ARTICLE=BINARY @id", 1,
                ("@qty", quantity), ("@cost", cost), ("@average", average), ("@sale", Round(line.SalePrice)),
                ("@supplier", current.Supplier), ("@id", line.ArticleId));
            var audit = $"Bon de Réception | {current.Id} [{actor}]";
            if (audit.Length > 255) throw new InvalidOperationException("Libellé de mouvement trop long.");
            Write("INSERT INTO TABLE_MOUVEMENTS_STOCK (DATES,HEURE,LIBELLE,ID_ARTICLE,CODE_ARTICLE,ARTICLE,QUANTITE) " +
                "VALUES (@date,@time,@label,@id,@code,@name,@qty)", 1,
                ("@date", now.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)),
                ("@time", now.ToString("HH:mm:ss", CultureInfo.InvariantCulture)),
                ("@label", audit), ("@id", line.ArticleId), ("@code", code), ("@name", name), ("@qty", quantity));
        }
        Write("UPDATE TABLE_RECEPTIONS_DETAILS SET ETAT='VALIDER' WHERE BINARY ID_BR=BINARY @id AND ETAT='ENREGISTRER'",
            current.Lines.Count, ("@id", current.Id));
        Write("UPDATE TABLE_RECEPTIONS_ENTETE SET ETAT='VALIDER' WHERE BINARY ID_BR=BINARY @id AND ETAT='ENREGISTRER'",
            1, ("@id", current.Id));
        transaction.Commit();
    }

    private static Receipt Read(MySqlConnection connection, MySqlTransaction transaction, string id, bool lockRows)
    {
        if (string.IsNullOrWhiteSpace(id)) throw new ArgumentException("Numéro de réception requis.", nameof(id));
        var locking = lockRows ? " FOR UPDATE" : "";
        string supplierId;
        string supplier;
        using (var header = Command(connection, transaction,
            "SELECT ID_FOURNISSEUR, FOURNISSEUR, ETAT FROM TABLE_RECEPTIONS_ENTETE WHERE BINARY ID_BR=BINARY @id" + locking,
            ("@id", id)))
        using (var reader = header.ExecuteReader())
        {
            if (!reader.Read() || reader.IsDBNull(0) || reader.IsDBNull(1) ||
                reader.IsDBNull(2) || reader.GetString(2) != "ENREGISTRER")
                throw new InvalidOperationException("Réception enregistrée introuvable.");
            supplierId = reader.GetString(0);
            supplier = reader.GetString(1);
            if (reader.Read() || string.IsNullOrWhiteSpace(supplierId) || string.IsNullOrWhiteSpace(supplier))
                throw new InvalidOperationException("Identité du bon ou du fournisseur invalide.");
        }
        var lines = new List<Line>();
        var seen = new HashSet<string>(StringComparer.Ordinal);
        using (var detail = Command(connection, transaction,
            "SELECT ID_ARTICLE, Article, `Qté`, PRIX_A, PRIX_V, ETAT, ID_FOURNISSEUR FROM TABLE_RECEPTIONS_DETAILS " +
            "WHERE BINARY ID_BR=BINARY @id ORDER BY BINARY ID_ARTICLE" + locking, ("@id", id)))
        using (var reader = detail.ExecuteReader())
            while (reader.Read())
            {
                for (var index = 0; index < reader.FieldCount; index++)
                    if (reader.IsDBNull(index)) throw new InvalidOperationException("Ligne de réception incomplète.");
                var line = new Line(reader.GetString(0), reader.GetString(1), reader.GetDecimal(2),
                    reader.GetDecimal(3), reader.GetDecimal(4));
                if (string.IsNullOrWhiteSpace(line.ArticleId) || !seen.Add(line.ArticleId) ||
                    Round(line.Quantity) <= 0 || line.Cost < 0 || line.SalePrice < 0 ||
                    reader.GetString(5) != "ENREGISTRER" || reader.GetString(6) != supplierId)
                    throw new InvalidOperationException("Ligne de réception invalide ou en double.");
                lines.Add(line);
            }
        if (lines.Count == 0) throw new InvalidOperationException("Réception vide.");
        return new Receipt(id, supplierId, supplier, lines.AsReadOnly());
    }

    private static decimal Round(decimal value) => Math.Round(value, 2, MidpointRounding.AwayFromZero);

    private MySqlConnection Open()
    {
        var endpoint = new MySqlConnectionStringBuilder(connectionString);
        if (endpoint.Server is not ("localhost" or "127.0.0.1" or "::1"))
            throw new InvalidOperationException("La réception nécessite une base MariaDB locale.");
        var connection = new MySqlConnection(connectionString);
        try { connection.Open(); return connection; }
        catch { connection.Dispose(); throw; }
    }

    private static MySqlCommand Command(MySqlConnection connection, MySqlTransaction transaction,
        string sql, params (string Name, object Value)[] values)
    {
        var command = new MySqlCommand(sql, connection, transaction);
        foreach (var (name, value) in values) command.Parameters.AddWithValue(name, value);
        return command;
    }
}
