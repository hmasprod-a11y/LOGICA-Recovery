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

    internal sealed record ImportLine(string Name, string Barcode, string Family, decimal Cost, decimal Price, decimal Stock);

    internal string Create(string name, string barcode, string family, decimal price, string actor, string pin, string? variantOf = null)
    {
        using var connection = Open();
        using var transaction = connection.BeginTransaction(IsolationLevel.Serializable);
        RequireCreationAccess(connection, transaction, actor, pin);
        var id = Create(connection, transaction, new ImportLine(name, barcode, family, 0m, price, 0m), variantOf, imported: false);
        transaction.Commit();
        return id;
    }

    internal IReadOnlyList<string> Import(IReadOnlyList<ImportLine> lines, string actor, string pin)
    {
        if (lines.Count == 0 || lines.Any(line => string.IsNullOrWhiteSpace(line.Barcode)) ||
            lines.Select(line => line.Barcode).Distinct(StringComparer.Ordinal).Count() != lines.Count)
            throw new ArgumentException("Le fichier doit contenir des articles et des codes-barres distincts.");
        using var connection = Open();
        using var transaction = connection.BeginTransaction(IsolationLevel.Serializable);
        RequireCreationAccess(connection, transaction, actor, pin);
        var ids = new List<string>(lines.Count);
        foreach (var line in lines) ids.Add(Create(connection, transaction, line, variantOf: null, imported: true));
        transaction.Commit();
        return ids.AsReadOnly();
    }

    private static void RequireCreationAccess(MySqlConnection connection, MySqlTransaction transaction, string actor, string pin)
    {
        InventoryDocumentValidation.RequireTransactionalTables(connection, transaction, "TABLE_PASS",
            "TABLE_NUM", "TABLE_ARTICLES", "TABLE_MOUVEMENTS_STOCK", "TABLE_FAMILLES");
        Authorize(connection, transaction, actor, pin);
    }

    private static string Create(MySqlConnection connection, MySqlTransaction transaction,
        ImportLine line, string? variantOf, bool imported)
    {
        var (name, barcode, family, cost, price, stock) = line;
        if (string.IsNullOrWhiteSpace(name) || name.Length > 128 || barcode.Length > 128 ||
            family.Length > 128 || price < 0 || decimal.Round(price, 2) != price ||
            cost < 0 || decimal.Round(cost, 2) != cost || stock < 0 || decimal.Round(stock, 3) != stock)
            throw new ArgumentException("Vérifiez le nom, le code, la famille, les prix et le stock.");
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
        if (variantOf is not null)
        {
            var parent = ReadCard(connection, transaction, variantOf, true);
            if (string.IsNullOrEmpty(parent.Barcode) || family != parent.Family || barcode != parent.Barcode ||
                string.Equals(name, parent.Name, StringComparison.OrdinalIgnoreCase))
                throw new InvalidOperationException("La variante doit partager le code-barres et la famille de l’article source, avec un nom distinct.");
        }
        using (var duplicate = new MySqlCommand(
            "SELECT COUNT(*) FROM TABLE_ARTICLES WHERE BINARY ID_ARTICLE=BINARY @id OR " +
            "(@code<>'' AND BINARY Code=BINARY @code AND (@variant=0 OR Article=@name))", connection, transaction))
        {
            duplicate.Parameters.AddWithValue("@id", id);
            duplicate.Parameters.AddWithValue("@variant", variantOf is null ? 0 : 1);
            duplicate.Parameters.AddWithValue("@name", name);
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
            "VALUES (@id,@code,@name,@family,@cost,@cost,@price,@second,@stock,@stock,@tax,0,'0.png',@date,@date)",
            ("@id", id), ("@code", barcode), ("@name", name), ("@family", family),
            ("@price", price), ("@cost", cost), ("@stock", stock), ("@tax", imported ? 20m : 0m),
            ("@second", imported ? price : 0m), ("@date", now.Date));
        Write("INSERT INTO TABLE_MOUVEMENTS_STOCK (DATES,HEURE,LIBELLE,ID_ARTICLE,CODE_ARTICLE,ARTICLE,QUANTITE) " +
            "VALUES (@date,@time,'Création d''article',@id,@code,@name,@stock)",
            ("@date", now.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture)),
            ("@time", now.ToString("HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture)),
            ("@id", id), ("@code", barcode), ("@name", name), ("@stock", stock));
        Write("UPDATE TABLE_NUM SET ARTICLE=ARTICLE+1 WHERE ID=0 AND ARTICLE=@number", ("@number", number));
        return id;
    }

    internal sealed record CardDetails(string Description, string Reference, string Unit, string Location);
    internal sealed record Card(long RowId, string Id, string Name, string Barcode, string Family, CardDetails Details);

    internal Card ReadCard(string id)
    {
        using var connection = Open();
        using var transaction = connection.BeginTransaction();
        return ReadCard(connection, transaction, id, false);
    }

    internal void UpdateCard(Card reviewed, string name, string barcode, string family, CardDetails details, string actor, string pin)
    {
        if (string.IsNullOrWhiteSpace(name) || name.Length > 128 || barcode.Length > 128 || family.Length > 128)
            throw new ArgumentException("Vérifiez le nom, le code-barres et la famille.");
        using var connection = Open();
        using var transaction = connection.BeginTransaction(IsolationLevel.Serializable);
        InventoryDocumentValidation.RequireTransactionalTables(connection, transaction, "TABLE_PASS", "TABLE_ARTICLES");
        Authorize(connection, transaction, actor, pin);
        if (ReadCard(connection, transaction, reviewed.Id, true) != reviewed)
            throw new InvalidOperationException("La fiche a changé. Rechargez l’article.");
        var updated = reviewed with { Name = name, Barcode = barcode, Family = family, Details = details };
        if (updated == reviewed) return;
        var hasLocation = HasLocation(connection, transaction);
        if (!hasLocation && details.Location.Length != 0)
            throw new InvalidOperationException("L’emplacement n’est pas disponible dans ce schéma LOGICA.");
        if (new[] { details.Description, details.Reference, details.Unit, details.Location }.Any(value => value.Length > 255))
            throw new ArgumentException("Les champs de la fiche sont limités à 255 caractères.");
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
            "UPDATE TABLE_ARTICLES SET Article=@name, Code=@code, Famille=@family, " +
            "Description=@description, Reference=@reference, Unite=@unit" +
            (hasLocation ? ", Emplacement=@location " : " ") +
            "WHERE ID=@row AND BINARY ID_ARTICLE=BINARY @id", connection, transaction);
        update.Parameters.AddWithValue("@name", name);
        update.Parameters.AddWithValue("@code", barcode);
        update.Parameters.AddWithValue("@family", family);
        update.Parameters.AddWithValue("@description", details.Description);
        update.Parameters.AddWithValue("@reference", details.Reference);
        update.Parameters.AddWithValue("@unit", details.Unit);
        if (hasLocation) update.Parameters.AddWithValue("@location", details.Location);
        update.Parameters.AddWithValue("@row", reviewed.RowId);
        update.Parameters.AddWithValue("@id", reviewed.Id);
        if (update.ExecuteNonQuery() != 1 ||
            ReadCard(connection, transaction, reviewed.Id, true) != updated)
            throw new InvalidOperationException("Modification de la fiche non confirmée.");
        transaction.Commit();
    }

    private static bool HasLocation(MySqlConnection connection, MySqlTransaction transaction)
    {
        using var query = new MySqlCommand(
            "SELECT COUNT(*) FROM information_schema.COLUMNS WHERE TABLE_SCHEMA=DATABASE() " +
            "AND TABLE_NAME='TABLE_ARTICLES' AND COLUMN_NAME='Emplacement'", connection, transaction);
        return Convert.ToInt64(query.ExecuteScalar()) == 1;
    }

    private static Card ReadCard(MySqlConnection connection, MySqlTransaction transaction, string id, bool lockRow)
    {
        using var command = new MySqlCommand(
            "SELECT ID, Article, Code, Famille, Description, Reference, Unite, " +
            (HasLocation(connection, transaction) ? "Emplacement" : "NULL") +
            " FROM TABLE_ARTICLES WHERE BINARY ID_ARTICLE=BINARY @id" +
            (lockRow ? " FOR UPDATE" : ""), connection, transaction);
        command.Parameters.AddWithValue("@id", id);
        using var reader = command.ExecuteReader();
        if (!reader.Read() || reader.IsDBNull(0) || reader.IsDBNull(1))
            throw new InvalidOperationException("Fiche article introuvable.");
        string Field(int index) => reader.IsDBNull(index) ? "" : reader.GetString(index);
        var card = new Card(reader.GetInt64(0), id, reader.GetString(1), Field(2), Field(3),
            new CardDetails(Field(4), Field(5), Field(6), Field(7)));
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
