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

    private static bool HasFiscalOrderColumns(MySqlConnection connection, MySqlTransaction transaction)
    {
        using var command = Command(connection, transaction,
            "SELECT COUNT(*) FROM information_schema.COLUMNS WHERE TABLE_SCHEMA=DATABASE() " +
            "AND TABLE_NAME='TABLE_COMMANDES_DETAILS' AND COLUMN_NAME='PU_TTC'");
        return Convert.ToInt64(command.ExecuteScalar(), CultureInfo.InvariantCulture) == 1;
    }

    internal string CreateOrder(string supplierId, string articleId, decimal quantity, string actor, string pin)
    {
        if (string.IsNullOrWhiteSpace(supplierId) || string.IsNullOrWhiteSpace(articleId) ||
            quantity <= 0 || Round(quantity) != quantity)
            throw new ArgumentException("Fournisseur, article et quantité positive à deux décimales requis.");
        using var connection = Open();
        using var transaction = connection.BeginTransaction(IsolationLevel.Serializable);
        InventoryDocumentValidation.RequireTransactionalTables(connection, transaction, "TABLE_PASS", "TABLE_NUM",
            "TABLE_FOURNISSEURS", "TABLE_ARTICLES", "TABLE_COMMANDES_ENTETE", "TABLE_COMMANDES_DETAILS");
        // The WPF action explicitly creates and validates the order in one operation.
        InventoryDocumentValidation.Authenticate(connection, transaction, actor, pin, validationOnly: true);

        void Write(string sql, params (string Name, object Value)[] args)
        {
            using var command = Command(connection, transaction, sql, args);
            if (command.ExecuteNonQuery() != 1) throw new InvalidOperationException("Commande non enregistrée.");
        }

        string supplier;
        string supplierCode;
        using (var command = Command(connection, transaction,
            "SELECT FOURNISSEUR, CODE_FOURNISSEUR FROM TABLE_FOURNISSEURS WHERE BINARY ID_FOURNISSEUR=BINARY @id FOR UPDATE",
            ("@id", supplierId)))
        using (var reader = command.ExecuteReader())
        {
            if (!reader.Read() || reader.IsDBNull(0)) throw new InvalidOperationException("Fournisseur introuvable.");
            supplier = reader.GetString(0);
            supplierCode = reader.IsDBNull(1) ? "" : reader.GetString(1);
            if (string.IsNullOrWhiteSpace(supplier) || reader.Read())
                throw new InvalidOperationException("Fournisseur ambigu ou incomplet.");
        }

        decimal cost;
        decimal sale;
        decimal taxRate;
        string code;
        string article;
        using (var command = Command(connection, transaction,
            "SELECT Code, Article, PRIX_A, PRIX_V_1, TAUX_TVA FROM TABLE_ARTICLES WHERE BINARY ID_ARTICLE=BINARY @id FOR UPDATE",
            ("@id", articleId)))
        using (var reader = command.ExecuteReader())
        {
            if (!reader.Read() || reader.IsDBNull(1) || reader.IsDBNull(2) ||
                reader.IsDBNull(3) || reader.IsDBNull(4))
                throw new InvalidOperationException("Article introuvable ou incomplet.");
            code = reader.IsDBNull(0) ? "" : reader.GetString(0);
            article = reader.GetString(1);
            cost = Round(reader.GetDecimal(2));
            sale = Round(reader.GetDecimal(3));
            taxRate = reader.GetDecimal(4);
            if (reader.Read() || cost < 0 || sale < 0 || taxRate < 0)
                throw new InvalidOperationException("Article ambigu ou prix invalide.");
        }

        long number;
        using (var command = Command(connection, transaction, "SELECT BC FROM TABLE_NUM WHERE ID=0 FOR UPDATE"))
        using (var reader = command.ExecuteReader())
        {
            if (!reader.Read() || reader.IsDBNull(0)) throw new InvalidOperationException("Compteur BC absent.");
            number = reader.GetInt64(0);
            if (number < 0 || reader.Read()) throw new InvalidOperationException("Compteur BC invalide.");
        }
        var id = "BC" + number.ToString("D6", CultureInfo.InvariantCulture);
        using (var exists = Command(connection, transaction,
            "SELECT COUNT(*) FROM TABLE_COMMANDES_ENTETE WHERE BINARY ID_BC=BINARY @id", ("@id", id)))
            if (Convert.ToInt64(exists.ExecuteScalar(), CultureInfo.InvariantCulture) != 0)
                throw new InvalidOperationException("Le numéro BC est déjà utilisé.");

        var date = DateTime.Today;
        var purchase = Round(cost * quantity);
        var sales = Round(sale * quantity);
        var unitBeforeTax = Round(cost / (1m + taxRate / 100m));
        var beforeTax = Round(unitBeforeTax * quantity);
        var fiscal = HasFiscalOrderColumns(connection, transaction);
        var headerColumns = fiscal ? "TOTAL_TTC_DOC,TOTAL_TVA_DOC,TOTAL_HT_DOC,TOTAL_REMISE_DOC" :
            "TOTAL_NET_ACHATS,TOTAL_NET_VENTES";
        var headerValues = fiscal ? "@purchase,@tax,@beforeTax,0" : "@purchase,@sales";
        Write("INSERT INTO TABLE_COMMANDES_ENTETE " +
            $"(Dates,ID_BC,UTILISATEUR,ID_FOURNISSEUR,CODE_FOURNISSEUR,FOURNISSEUR,{headerColumns},ETAT) " +
            $"VALUES (@date,@id,@actor,@supplier,@supplierCode,@supplierName,{headerValues},'VALIDER')",
            ("@date", date), ("@id", id), ("@actor", actor), ("@supplier", supplierId),
            ("@supplierCode", supplierCode), ("@supplierName", supplier), ("@purchase", purchase),
            ("@sales", sales), ("@tax", purchase - beforeTax), ("@beforeTax", beforeTax));
        var detailColumns = fiscal ? "PU_TTC,TAUX_TVA,PU_HT,TOTAL_TTC,TOTAL_TVA,TOTAL_HT,TAUX_REMISE" :
            "PRIX_A,PRIX_V,TOTAL_NET_ACHATS,TOTAL_NET_VENTES";
        var detailValues = fiscal ? "@cost,@rate,@unitBeforeTax,@purchase,@tax,@beforeTax,0" : "@cost,@sale,@purchase,@sales";
        Write("INSERT INTO TABLE_COMMANDES_DETAILS " +
            $"(Dates,ID_BC,ID_FOURNISSEUR,CODE_FOURNISSEUR,FOURNISSEUR,ID_ARTICLE,Code,Article,`Qté`,{detailColumns},ETAT) " +
            $"VALUES (@date,@id,@supplier,@supplierCode,@supplierName,@articleId,@code,@article,@quantity,{detailValues},'VALIDER')",
            ("@date", date), ("@id", id), ("@supplier", supplierId), ("@supplierCode", supplierCode),
            ("@supplierName", supplier), ("@articleId", articleId), ("@code", code), ("@article", article),
            ("@quantity", quantity), ("@cost", cost), ("@sale", sale), ("@purchase", purchase), ("@sales", sales),
            ("@rate", taxRate), ("@unitBeforeTax", unitBeforeTax), ("@tax", purchase - beforeTax), ("@beforeTax", beforeTax));
        Write("UPDATE TABLE_NUM SET BC=BC+1 WHERE ID=0 AND BC=@number", ("@number", number));
        transaction.Commit();
        return id;
    }

    internal Receipt CreateFromOrder(string orderId, string articleId, decimal quantity, string actor, string pin)
    {
        if (string.IsNullOrWhiteSpace(orderId) || string.IsNullOrWhiteSpace(articleId) ||
            quantity <= 0 || Round(quantity) != quantity)
            throw new ArgumentException("Commande, article et quantité positive à deux décimales requis.");

        using var connection = Open();
        using var transaction = connection.BeginTransaction(IsolationLevel.Serializable);
        InventoryDocumentValidation.RequireTransactionalTables(connection, transaction, "TABLE_PASS", "TABLE_NUM",
            "TABLE_COMMANDES_ENTETE", "TABLE_COMMANDES_DETAILS", "TABLE_RECEPTIONS_ENTETE",
            "TABLE_RECEPTIONS_DETAILS", "hanouty_purchase_receipt_order");
        InventoryDocumentValidation.Authenticate(connection, transaction, actor, pin, validationOnly: false);

        MySqlCommand Query(string sql, params (string Name, object Value)[] args) =>
            Command(connection, transaction, sql, args);
        void Write(string sql, params (string Name, object Value)[] args)
        {
            using var command = Query(sql, args);
            if (command.ExecuteNonQuery() != 1)
                throw new InvalidOperationException("Le bon de réception n’a pas pu être créé.");
        }

        string supplierId;
        string supplierName;
        string supplierCode;
        using (var order = Query(
            "SELECT ID_FOURNISSEUR, FOURNISSEUR, CODE_FOURNISSEUR FROM TABLE_COMMANDES_ENTETE " +
            "WHERE BINARY ID_BC=BINARY @id AND ETAT='VALIDER' FOR UPDATE", ("@id", orderId)))
        using (var reader = order.ExecuteReader())
        {
            if (!reader.Read() || reader.IsDBNull(0) || reader.IsDBNull(1))
                throw new InvalidOperationException("Commande validée introuvable.");
            supplierId = reader.GetString(0);
            supplierName = reader.GetString(1);
            supplierCode = reader.IsDBNull(2) ? "" : reader.GetString(2);
            if (reader.Read() || string.IsNullOrWhiteSpace(supplierId) || string.IsNullOrWhiteSpace(supplierName))
                throw new InvalidOperationException("Commande ou fournisseur ambigu.");
        }

        var fiscalOrder = HasFiscalOrderColumns(connection, transaction);
        var priceColumns = fiscalOrder ? "PU_TTC, NULL" : "PRIX_A, PRIX_V";
        decimal ordered;
        decimal cost;
        decimal salePrice;
        string code;
        string articleName;
        using (var detail = Query(
            $"SELECT `Qté`, {priceColumns}, Code, Article FROM TABLE_COMMANDES_DETAILS " +
            "WHERE BINARY ID_BC=BINARY @order AND BINARY ID_ARTICLE=BINARY @article " +
            "AND BINARY ID_FOURNISSEUR=BINARY @supplier AND ETAT='VALIDER' FOR UPDATE",
            ("@order", orderId), ("@article", articleId), ("@supplier", supplierId)))
        using (var reader = detail.ExecuteReader())
        {
            if (!reader.Read() || reader.IsDBNull(0) || reader.IsDBNull(1) ||
                (!fiscalOrder && reader.IsDBNull(2)) || reader.IsDBNull(4))
                throw new InvalidOperationException("Ligne de commande introuvable ou incomplète.");
            ordered = Round(reader.GetDecimal(0));
            cost = Round(reader.GetDecimal(1));
            salePrice = fiscalOrder ? 0m : Round(reader.GetDecimal(2));
            code = reader.IsDBNull(3) ? "" : reader.GetString(3);
            articleName = reader.GetString(4);
            if (reader.Read() || cost < 0 || salePrice < 0)
                throw new InvalidOperationException("Ligne de commande ambiguë ou invalide.");
        }

        if (fiscalOrder)
        {
            InventoryDocumentValidation.RequireTransactionalTables(connection, transaction, "TABLE_ARTICLES");
            using var article = Query("SELECT PRIX_V_1 FROM TABLE_ARTICLES WHERE BINARY ID_ARTICLE=BINARY @id FOR UPDATE",
                ("@id", articleId));
            using var reader = article.ExecuteReader();
            if (!reader.Read() || reader.IsDBNull(0))
                throw new InvalidOperationException("Prix de vente de l’article introuvable.");
            salePrice = Round(reader.GetDecimal(0));
            if (salePrice < 0 || reader.Read())
                throw new InvalidOperationException("Prix de vente de l’article invalide.");
        }

        // Serialize reservations for an order through the locked LOGICA header.
        // A saved receipt reserves the balance before it is posted to stock.
        using (var reserved = Query(
            "SELECT COALESCE(SUM(QUANTITY),0) FROM hanouty_purchase_receipt_order " +
            "WHERE ORDER_ID=@order AND ARTICLE_ID=@article", ("@order", orderId), ("@article", articleId)))
            if (quantity > ordered - Convert.ToDecimal(reserved.ExecuteScalar(), CultureInfo.InvariantCulture))
                throw new InvalidOperationException("Quantité supérieure au reliquat de la commande.");

        long number;
        using (var counter = Query("SELECT BR FROM TABLE_NUM WHERE ID=0 FOR UPDATE"))
        using (var reader = counter.ExecuteReader())
        {
            if (!reader.Read() || reader.IsDBNull(0)) throw new InvalidOperationException("Compteur BR absent.");
            number = reader.GetInt64(0);
            if (number < 0 || reader.Read()) throw new InvalidOperationException("Compteur BR invalide.");
        }
        var receiptId = "BR" + number.ToString("D6", CultureInfo.InvariantCulture);
        using (var existing = Query(
            "SELECT COUNT(*) FROM TABLE_RECEPTIONS_ENTETE WHERE BINARY ID_BR=BINARY @id", ("@id", receiptId)))
            if (Convert.ToInt64(existing.ExecuteScalar(), CultureInfo.InvariantCulture) != 0)
                throw new InvalidOperationException("Le numéro BR est déjà utilisé.");

        var date = DateTime.Today;
        var purchaseTotal = Round(quantity * cost);
        var saleTotal = Round(quantity * salePrice);
        Write("INSERT INTO TABLE_RECEPTIONS_ENTETE " +
            "(Dates,ID_BR,UTILISATEUR,ID_FOURNISSEUR,CODE_FOURNISSEUR,FOURNISSEUR,TOTAL_NET_ACHATS,TOTAL_NET_VENTES,ETAT) " +
            "VALUES (@date,@id,@actor,@supplier,@code,@name,@purchase,@sales,'ENREGISTRER')",
            ("@date", date), ("@id", receiptId), ("@actor", actor), ("@supplier", supplierId),
            ("@code", supplierCode), ("@name", supplierName), ("@purchase", purchaseTotal), ("@sales", saleTotal));
        Write("INSERT INTO TABLE_RECEPTIONS_DETAILS " +
            "(Dates,ID_BR,ID_FOURNISSEUR,CODE_FOURNISSEUR,FOURNISSEUR,ID_ARTICLE,Code,Article,PRIX_A,PRIX_V,`Qté`," +
            "TOTAL_NET_ACHATS,TOTAL_NET_VENTES,ETAT) " +
            "VALUES (@date,@id,@supplier,@supplierCode,@supplierName,@article,@code,@name,@cost,@sale,@qty,@purchase,@sales,'ENREGISTRER')",
            ("@date", date), ("@id", receiptId), ("@supplier", supplierId), ("@supplierCode", supplierCode),
            ("@supplierName", supplierName), ("@article", articleId), ("@code", code), ("@name", articleName),
            ("@cost", cost), ("@sale", salePrice), ("@qty", quantity), ("@purchase", purchaseTotal), ("@sales", saleTotal));
        Write("INSERT INTO hanouty_purchase_receipt_order (RECEIPT_ID,ORDER_ID,ARTICLE_ID,QUANTITY) " +
            "VALUES (@receipt,@order,@article,@qty)",
            ("@receipt", receiptId), ("@order", orderId), ("@article", articleId), ("@qty", quantity));
        Write("UPDATE TABLE_NUM SET BR=BR+1 WHERE ID=0 AND BR=@number", ("@number", number));
        transaction.Commit();
        return new Receipt(receiptId, supplierId, supplierName,
            Array.AsReadOnly(new[] { new Line(articleId, articleName, quantity, cost, salePrice) }));
    }

    internal void Cancel(Receipt reviewed, string actor, string pin)
    {
        using var connection = Open();
        using var transaction = connection.BeginTransaction(IsolationLevel.Serializable);
        InventoryDocumentValidation.RequireTransactionalTables(connection, transaction, "TABLE_PASS",
            "TABLE_RECEPTIONS_ENTETE", "TABLE_RECEPTIONS_DETAILS", "hanouty_purchase_receipt_order");
        InventoryDocumentValidation.Authenticate(connection, transaction, actor, pin, validationOnly: true);
        var current = Read(connection, transaction, reviewed.Id, lockRows: true);
        RequireSameReceipt(reviewed, current);

        using (var reservation = Command(connection, transaction,
            "DELETE FROM hanouty_purchase_receipt_order WHERE RECEIPT_ID=@id", ("@id", current.Id)))
            if (reservation.ExecuteNonQuery() != 1)
                throw new InvalidOperationException("Seuls les bons réservés sur une commande peuvent être annulés ici.");

        using (var details = Command(connection, transaction,
            "DELETE FROM TABLE_RECEPTIONS_DETAILS WHERE BINARY ID_BR=BINARY @id AND ETAT='ENREGISTRER'", ("@id", current.Id)))
            if (details.ExecuteNonQuery() != current.Lines.Count)
                throw new InvalidOperationException("Les lignes ont changé. Rechargez le bon.");

        using (var header = Command(connection, transaction,
            "DELETE FROM TABLE_RECEPTIONS_ENTETE WHERE BINARY ID_BR=BINARY @id AND ETAT='ENREGISTRER'", ("@id", current.Id)))
            if (header.ExecuteNonQuery() != 1)
                throw new InvalidOperationException("Le bon a changé. Rechargez le document.");

        transaction.Commit();
    }

    private static void RequireSameReceipt(Receipt reviewed, Receipt current)
    {
        if (current.SupplierId != reviewed.SupplierId || current.Supplier != reviewed.Supplier ||
            !current.Lines.SequenceEqual(reviewed.Lines))
            throw new InvalidOperationException("La réception a changé. Rechargez le document.");
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
        VerifyOrderReservation(connection, transaction, current);
        RequireSameReceipt(reviewed, current);

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

    private static void VerifyOrderReservation(MySqlConnection connection, MySqlTransaction transaction, Receipt receipt)
    {
        using (var exists = Command(connection, transaction,
            "SELECT COUNT(*) FROM information_schema.TABLES WHERE TABLE_SCHEMA=DATABASE() AND TABLE_NAME='hanouty_purchase_receipt_order'"))
            if (Convert.ToInt64(exists.ExecuteScalar(), CultureInfo.InvariantCulture) == 0) return;
        InventoryDocumentValidation.RequireTransactionalTables(connection, transaction, "hanouty_purchase_receipt_order");
        using var command = Command(connection, transaction,
            "SELECT ARTICLE_ID, QUANTITY FROM hanouty_purchase_receipt_order WHERE RECEIPT_ID=@id FOR UPDATE",
            ("@id", receipt.Id));
        using var reader = command.ExecuteReader();
        if (!reader.Read()) return;
        if (receipt.Lines.Count != 1 || reader.GetString(0) != receipt.Lines[0].ArticleId ||
            reader.GetDecimal(1) != receipt.Lines[0].Quantity || reader.Read())
            throw new InvalidOperationException("Les lignes du bon ne correspondent plus à la réservation de commande.");
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
