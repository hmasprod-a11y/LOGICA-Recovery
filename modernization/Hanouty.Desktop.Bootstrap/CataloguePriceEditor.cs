using System.Data;
using MySql.Data.MySqlClient;

namespace Hanouty.Desktop.Bootstrap;

internal sealed class CataloguePriceEditor(string connectionString)
{
    internal sealed record Price(string Id, string Name, decimal Amount);

    internal IReadOnlyList<string> ReadFamilies()
    {
        using var connection = Open();
        using var command = new MySqlCommand(
            "SELECT DISTINCT BINARY Famille, Famille FROM TABLE_FAMILLES WHERE Famille IS NOT NULL AND TRIM(Famille)<>'' ORDER BY Famille", connection);
        using var reader = command.ExecuteReader();
        var families = new List<string>();
        while (reader.Read()) families.Add(reader.GetString(1));
        return families.AsReadOnly();
    }

    private static void RequireFamily(MySqlConnection connection, MySqlTransaction transaction, string family)
    {
        if (string.IsNullOrWhiteSpace(family))
            throw new ArgumentException("Choisissez une famille du catalogue.");
        using var command = new MySqlCommand(
            "SELECT Famille FROM TABLE_FAMILLES WHERE BINARY Famille=BINARY @family LIMIT 1 FOR UPDATE",
            connection, transaction);
        command.Parameters.AddWithValue("@family", family);
        if (command.ExecuteScalar() is not string)
            throw new InvalidOperationException("Cette famille n’est plus disponible. Rechargez le catalogue.");
    }

    internal string Create(string name, string barcode, string family, decimal price, string actor, string pin)
    {
        if (string.IsNullOrWhiteSpace(name) || name.Length > 128 || barcode.Length > 128 ||
            family.Length > 128 || price < 0 || decimal.Round(price, 2) != price)
            throw new ArgumentException("Vérifiez le nom, le code, la famille et le prix.");

        using var connection = Open();
        using var transaction = connection.BeginTransaction(IsolationLevel.Serializable);
        InventoryDocumentValidation.RequireTransactionalTables(connection, transaction, "TABLE_PASS",
            "TABLE_NUM", "TABLE_ARTICLES", "TABLE_MOUVEMENTS_STOCK", "TABLE_FAMILLES");
        Authorize(connection, transaction, actor, pin);
        RequireFamily(connection, transaction, family);

        long number;
        using (var counter = new MySqlCommand("SELECT ARTICLE FROM TABLE_NUM WHERE ID=0 FOR UPDATE", connection, transaction))
        using (var reader = counter.ExecuteReader())
        {
            if (!reader.Read() || reader.IsDBNull(0))
                throw new InvalidOperationException("Compteur article indisponible.");
            number = reader.GetInt64(0);
            if (number < 0 || reader.Read())
                throw new InvalidOperationException("Compteur article invalide.");
        }

        var id = "ART" + number.ToString("D6", System.Globalization.CultureInfo.InvariantCulture);
        using (var duplicate = new MySqlCommand(
            "SELECT COUNT(*) FROM TABLE_ARTICLES WHERE BINARY ID_ARTICLE=BINARY @id OR " +
            "(@code<>'' AND BINARY Code=BINARY @code)", connection, transaction))
        {
            duplicate.Parameters.AddWithValue("@id", id);
            duplicate.Parameters.AddWithValue("@code", barcode);
            if (Convert.ToInt64(duplicate.ExecuteScalar()) != 0)
                throw new InvalidOperationException("Identifiant ou code-barres déjà utilisé.");
        }

        void Write(string sql, params (string Name, object Value)[] parameters)
        {
            using var command = new MySqlCommand(sql, connection, transaction);
            foreach (var (key, value) in parameters) command.Parameters.AddWithValue(key, value);
            if (command.ExecuteNonQuery() != 1)
                throw new InvalidOperationException("Création d’article non confirmée.");
        }

        var now = DateTime.Now;
        Write("INSERT INTO TABLE_ARTICLES (ID_ARTICLE,Code,Article,Famille,PRIX_A,PRIX_MP,PRIX_V_1,PRIX_V_2," +
            "STOCK,STOCK_INITIAL,TAUX_TVA,PROMOTION,Images,DATES,DATE_INVENTAIRE) " +
            "VALUES (@id,@code,@name,@family,0,0,@price,0,0,0,0,0,'0.png',@date,@date)",
            ("@id", id), ("@code", barcode), ("@name", name), ("@family", family),
            ("@price", price), ("@date", now.Date));
        Write("INSERT INTO TABLE_MOUVEMENTS_STOCK (DATES,HEURE,LIBELLE,ID_ARTICLE,CODE_ARTICLE,ARTICLE,QUANTITE) " +
            "VALUES (@date,@time,'Création d''article',@id,@code,@name,0)",
            ("@date", now.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture)),
            ("@time", now.ToString("HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture)),
            ("@id", id), ("@code", barcode), ("@name", name));
        Write("UPDATE TABLE_NUM SET ARTICLE=ARTICLE+1 WHERE ID=0 AND ARTICLE=@number", ("@number", number));
        transaction.Commit();
        return id;
    }

    internal sealed record Card(long RowId, string Id, string Name, string Barcode, string Family);

    internal Card ReadCard(string id)
    {
        using var connection = Open();
        using var transaction = connection.BeginTransaction();
        return ReadCard(connection, transaction, id, false);
    }

    internal void UpdateCard(Card reviewed, string name, string barcode, string family, string actor, string pin)
    {
        if (string.IsNullOrWhiteSpace(name) || name.Length > 128 || barcode.Length > 128 || family.Length > 128)
            throw new ArgumentException("Vérifiez le nom, le code-barres et la famille.");
        using var connection = Open();
        using var transaction = connection.BeginTransaction(IsolationLevel.Serializable);
        InventoryDocumentValidation.RequireTransactionalTables(connection, transaction, "TABLE_PASS", "TABLE_ARTICLES");
        Authorize(connection, transaction, actor, pin);
        if (ReadCard(connection, transaction, reviewed.Id, true) != reviewed)
            throw new InvalidOperationException("La fiche a changé. Rechargez l’article.");
        if (reviewed.Name == name && reviewed.Barcode == barcode && reviewed.Family == family) return;
        if (family != reviewed.Family)
        {
            InventoryDocumentValidation.RequireTransactionalTables(connection, transaction, "TABLE_FAMILLES");
            RequireFamily(connection, transaction, family);
        }

        if (barcode.Length != 0 && barcode != reviewed.Barcode)
        {
            using var duplicate = new MySqlCommand(
                "SELECT COUNT(*) FROM TABLE_ARTICLES WHERE BINARY Code=BINARY @code AND ID<>@row",
                connection, transaction);
            duplicate.Parameters.AddWithValue("@code", barcode);
            duplicate.Parameters.AddWithValue("@row", reviewed.RowId);
            if (Convert.ToInt64(duplicate.ExecuteScalar()) != 0)
                throw new InvalidOperationException("Ce code-barres est déjà utilisé.");
        }

        using var update = new MySqlCommand(
            "UPDATE TABLE_ARTICLES SET Article=@name, Code=@code, Famille=@family " +
            "WHERE ID=@row AND BINARY ID_ARTICLE=BINARY @id", connection, transaction);
        update.Parameters.AddWithValue("@name", name);
        update.Parameters.AddWithValue("@code", barcode);
        update.Parameters.AddWithValue("@family", family);
        update.Parameters.AddWithValue("@row", reviewed.RowId);
        update.Parameters.AddWithValue("@id", reviewed.Id);
        if (update.ExecuteNonQuery() != 1 ||
            ReadCard(connection, transaction, reviewed.Id, true) != (reviewed with { Name = name, Barcode = barcode, Family = family }))
            throw new InvalidOperationException("Modification de la fiche non confirmée.");
        transaction.Commit();
    }

    private static Card ReadCard(MySqlConnection connection, MySqlTransaction transaction, string id, bool lockRow)
    {
        using var command = new MySqlCommand(
            "SELECT ID, Article, Code, Famille FROM TABLE_ARTICLES WHERE BINARY ID_ARTICLE=BINARY @id" +
            (lockRow ? " FOR UPDATE" : ""), connection, transaction);
        command.Parameters.AddWithValue("@id", id);
        using var reader = command.ExecuteReader();
        if (!reader.Read() || reader.IsDBNull(0) || reader.IsDBNull(1))
            throw new InvalidOperationException("Fiche article introuvable.");
        var card = new Card(reader.GetInt64(0), id, reader.GetString(1),
            reader.IsDBNull(2) ? "" : reader.GetString(2), reader.IsDBNull(3) ? "" : reader.GetString(3));
        if (reader.Read()) throw new InvalidOperationException("Identifiant article ambigu.");
        return card;
    }

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
        Authorize(connection, transaction, actor, pin);
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

    private static void Authorize(MySqlConnection connection, MySqlTransaction transaction, string actor, string pin)
    {
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
