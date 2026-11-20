using System.Data;
using System.Globalization;
using System.Text.Json;
using MySql.Data.MySqlClient;

namespace Hanouty.Desktop.Bootstrap;

internal sealed partial class StockIssueValidation
{
    internal sealed record SupplierChoice(string Id, string Code, string Name)
    {
        public string Label => $"{Name} — {Code}";
    }
    internal sealed record AvoirArticle(string Id, string Code, string Name, decimal Cost, decimal Price)
    {
        public string Label => $"{Name} — {Code}";
    }
    internal sealed record AvoirLine(AvoirArticle Article, decimal Quantity, decimal Cost, decimal Price)
    {
        public string Label => Article.Label;
        public decimal CostNet => decimal.Round(Quantity * Cost, 2, MidpointRounding.AwayFromZero);
        public decimal PriceNet => decimal.Round(Quantity * Price, 2, MidpointRounding.AwayFromZero);
    }
    internal sealed record AvoirCommand(string OperationId, DateTime Date, SupplierChoice Supplier, string Notes, AvoirLine[] Lines);
    internal sealed class AvoirWriteRefusedException(string message, Exception inner) : InvalidOperationException(message, inner);
    internal SupplierAvoirWorkflow OpenAvoirWorkflow(string actor, Func<string> readPin, string? directory = null, Action? afterCommit = null) =>
        new(this, actor, readPin, connectionString, directory, afterCommit);

    internal SupplierChoice[] AvoirSuppliers()
    {
        using var db = Open();
        using var command = new MySqlCommand("SELECT ID_FOURNISSEUR,CODE_FOURNISSEUR,FOURNISSEUR FROM TABLE_FOURNISSEURS ORDER BY FOURNISSEUR,ID_FOURNISSEUR", db);
        using var row = command.ExecuteReader(); var result = new List<SupplierChoice>();
        while (row.Read())
            if (!row.IsDBNull(0) && !row.IsDBNull(2) && !string.IsNullOrWhiteSpace(row.GetString(0)) && row.GetString(0) != "0")
                result.Add(new SupplierChoice(row.GetString(0), row.IsDBNull(1) ? "" : row.GetString(1), row.GetString(2)));
        return result.GroupBy(item => item.Id, StringComparer.OrdinalIgnoreCase).Where(group => group.Count() == 1).Select(group => group.Single()).ToArray();
    }
    internal AvoirArticle[] AvoirArticles()
    {
        using var db = Open();
        using var command = new MySqlCommand("SELECT ID_ARTICLE,Code,Article,PRIX_A,PRIX_V_1 FROM TABLE_ARTICLES ORDER BY Article,ID_ARTICLE", db);
        using var row = command.ExecuteReader(); var result = new List<AvoirArticle>();
        while (row.Read())
            if (!row.IsDBNull(0) && !row.IsDBNull(2) && !row.IsDBNull(3) && !row.IsDBNull(4))
                result.Add(new AvoirArticle(row.GetString(0), row.IsDBNull(1) ? "" : row.GetString(1), row.GetString(2), row.GetDecimal(3), row.GetDecimal(4)));
        return result.GroupBy(item => item.Id, StringComparer.Ordinal).Where(group => group.Count() == 1).Select(group => group.Single()).ToArray();
    }

    // Form_6_SORTIES: prices are editable signed values; quantities stay positive.
    // Never negate an AVOIR automatically: the original supplier statement subtracts
    // recorded signed outgoing totals, including ENREGISTRER documents. Its old
    // settlement form displayed the opposite sign; the shared reader uses the statement.
    internal string CreateAvoir(AvoirCommand request, string actor, string pin, Action? afterCommit = null)
    {
        var attemptedCommit = false;
        try { return Save(); }
        catch (Exception ex) when (!attemptedCommit && ex is not OutOfMemoryException and not StackOverflowException)
        { throw new AvoirWriteRefusedException(ex.Message, ex); }

        string Save()
        {
            if (!Guid.TryParseExact(request.OperationId, "N", out _) || request.Date == DateTime.MinValue || request.Date != request.Date.Date ||
                request.Supplier is null || string.IsNullOrWhiteSpace(request.Supplier.Id) || request.Supplier.Id == "0" ||
                string.IsNullOrWhiteSpace(request.Supplier.Name) || request.Notes.Length > 255 || request.Lines.Length == 0 ||
                request.Lines.Any(line => line.Quantity <= 0 || line.Quantity > 9999m || decimal.Round(line.Quantity, 2) != line.Quantity ||
                    decimal.Round(line.Cost, 2) != line.Cost || decimal.Round(line.Price, 2) != line.Price) ||
                request.Lines.Select(line => line.Article.Id).Distinct(StringComparer.Ordinal).Count() != request.Lines.Length)
                throw new InvalidOperationException("Fournisseur, date et lignes distinctes valides requis pour l’avoir.");
            using var db = Open(); using var tx = db.BeginTransaction(IsolationLevel.Serializable);
            InventoryDocumentValidation.RequireTransactionalTables(db, tx, "TABLE_PASS", "TABLE_NUM", "TABLE_ARTICLES",
                "TABLE_FOURNISSEURS", "TABLE_SORTIES_ENTETE", "TABLE_SORTIES_DETAILS", "hanouty_stock_issue_create_operations");
            InventoryDocumentValidation.Authenticate(db, tx, actor, pin, validationOnly: false);
            var payload = JsonSerializer.Serialize(request);
            using (var replay = Command("SELECT ACTOR,PAYLOAD,ISSUE_ID FROM hanouty_stock_issue_create_operations WHERE OPERATION_ID=@op FOR UPDATE", ("@op", request.OperationId)))
            using (var row = replay.ExecuteReader())
                if (row.Read())
                {
                    if (row.GetString(0) != actor || row.GetString(1) != payload) throw new InvalidOperationException("Cette référence appartient à une autre création.");
                    var stored = row.GetString(2); row.Close(); attemptedCommit = true; tx.Commit(); return stored;
                }
            using (var supplier = Command("SELECT ID_FOURNISSEUR,CODE_FOURNISSEUR,FOURNISSEUR FROM TABLE_FOURNISSEURS WHERE UPPER(ID_FOURNISSEUR)=UPPER(@id) FOR UPDATE", ("@id", request.Supplier.Id)))
            using (var row = supplier.ExecuteReader())
                if (!row.Read() || row.GetString(0) != request.Supplier.Id || (row.IsDBNull(1) ? "" : row.GetString(1)) != request.Supplier.Code || row.IsDBNull(2) ||
                    row.GetString(2) != request.Supplier.Name || row.Read()) throw new InvalidOperationException("Le fournisseur a changé. Sélectionnez-le de nouveau.");
            long sequence;
            using (var counter = Command("SELECT BS FROM TABLE_NUM WHERE ID=0 FOR UPDATE"))
            using (var row = counter.ExecuteReader())
            {
                if (!row.Read() || row.IsDBNull(0)) throw new InvalidOperationException("Compteur BS indisponible.");
                var value = Convert.ToDecimal(row.GetValue(0), CultureInfo.InvariantCulture);
                if (value < 1 || value != decimal.Truncate(value) || value > long.MaxValue - 1m || row.Read()) throw new InvalidOperationException("Compteur BS invalide.");
                sequence = (long)value;
            }
            var id = "BS" + sequence.ToString("D6", CultureInfo.InvariantCulture);
            using (var duplicate = Command("SELECT ID FROM TABLE_SORTIES_ENTETE WHERE ID_BS=@id FOR UPDATE", ("@id", id)))
            using (var row = duplicate.ExecuteReader()) if (row.Read()) throw new InvalidOperationException("Numéro de bon déjà utilisé.");
            long rowId;
            using (var next = Command("SELECT COALESCE(MAX(ID),0)+1 FROM TABLE_SORTIES_ENTETE FOR UPDATE")) rowId = Convert.ToInt64(next.ExecuteScalar());
            foreach (var line in request.Lines.OrderBy(line => line.Article.Id, StringComparer.Ordinal))
            {
                using var article = Command("SELECT Code,Article,PRIX_A,PRIX_V_1 FROM TABLE_ARTICLES WHERE BINARY ID_ARTICLE=BINARY @id FOR UPDATE", ("@id", line.Article.Id));
                using var row = article.ExecuteReader();
                if (!row.Read() || (row.IsDBNull(0) ? "" : row.GetString(0)) != line.Article.Code || row.IsDBNull(1) || row.GetString(1) != line.Article.Name ||
                    row.IsDBNull(2) || row.IsDBNull(3) || row.GetDecimal(2) != line.Article.Cost || row.GetDecimal(3) != line.Article.Price || row.Read())
                    throw new InvalidOperationException("Un article ou son prix de référence a changé. Reconstituez l’avoir.");
            }
            Write("""
                INSERT INTO TABLE_SORTIES_ENTETE (ID,ID_BS,Dates,UTILISATEUR,ID_FOURNISSEUR,CODE_FOURNISSEUR,FOURNISSEUR,TYPE,TOTAL_NET_ACHATS,TOTAL_NET_VENTES,NOTES,ETAT)
                VALUES (@row,@id,@date,@actor,@supplier,@code,@name,'AVOIR',@cost,@price,@notes,'ENREGISTRER')
                """, ("@row", rowId), ("@id", id), ("@date", request.Date), ("@actor", actor), ("@supplier", request.Supplier.Id),
                ("@code", request.Supplier.Code), ("@name", request.Supplier.Name), ("@cost", request.Lines.Sum(line => line.CostNet)),
                ("@price", request.Lines.Sum(line => line.PriceNet)), ("@notes", request.Notes));
            foreach (var line in request.Lines)
                Write("""
                    INSERT INTO TABLE_SORTIES_DETAILS (Dates,ID_BS,ID_FOURNISSEUR,CODE_FOURNISSEUR,FOURNISSEUR,TYPE,ID_ARTICLE,Code,Article,Prix_A,Prix_V,Qté,TOTAL_NET_ACHATS,TOTAL_NET_VENTES,ETAT)
                    VALUES (@date,@id,@supplier,@supplierCode,@supplierName,'AVOIR',@article,@code,@name,@cost,@price,@quantity,@costNet,@priceNet,'ENREGISTRER')
                    """, ("@date", request.Date), ("@id", id), ("@supplier", request.Supplier.Id), ("@supplierCode", request.Supplier.Code),
                    ("@supplierName", request.Supplier.Name), ("@article", line.Article.Id), ("@code", line.Article.Code), ("@name", line.Article.Name),
                    ("@cost", line.Cost), ("@price", line.Price), ("@quantity", line.Quantity), ("@costNet", line.CostNet), ("@priceNet", line.PriceNet));
            Write("UPDATE TABLE_NUM SET BS=BS+1 WHERE ID=0 AND BS=@sequence", ("@sequence", sequence));
            Write("INSERT INTO hanouty_stock_issue_create_operations (OPERATION_ID,ACTOR,ISSUE_ID,PAYLOAD,CREATED_UTC) VALUES (@op,@actor,@id,@payload,UTC_TIMESTAMP(6))",
                ("@op", request.OperationId), ("@actor", actor), ("@id", id), ("@payload", payload));
            attemptedCommit = true; tx.Commit(); afterCommit?.Invoke(); return id;

            MySqlCommand Command(string sql, params (string Name, object Value)[] values)
            {
                var command = new MySqlCommand(sql, db, tx);
                foreach (var (name, value) in values) command.Parameters.AddWithValue(name, value);
                return command;
            }
            void Write(string sql, params (string Name, object Value)[] values)
            { using var command = Command(sql, values); if (command.ExecuteNonQuery() != 1) throw new InvalidOperationException("Écriture de l’avoir incomplète."); }
        }
    }
}
