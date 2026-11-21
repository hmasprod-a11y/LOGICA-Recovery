using System.Data;
using System.Globalization;
using System.Text.Json;
using Hanouty.Desktop.Wpf;
using MySql.Data.MySqlClient;

namespace Hanouty.Desktop.Bootstrap;

// Form_5_CLIENTS and its separate opening-credit/history forms. No schema initialization.
internal sealed class CustomerFileStore(string connectionString, Action? afterCommit = null)
{
    internal sealed record Access(CustomerFileStore Owner, string Actor, string Permission, string Approver, string? Role);
    private MySqlConnection Open()
    {
        var cs = new MySqlConnectionStringBuilder(connectionString);
        if (cs.Server is not ("127.0.0.1" or "localhost" or "::1")) throw new InvalidOperationException("Base locale requise.");
        var connection = new MySqlConnection(connectionString); connection.Open(); return connection;
    }
    private static MySqlCommand Command(MySqlConnection db, MySqlTransaction tx, string sql, params (string, object)[] values)
    {
        var command = new MySqlCommand(sql, db, tx);
        foreach (var (key, value) in values) command.Parameters.AddWithValue(key, value);
        return command;
    }
    private static string Permission(MySqlConnection db, MySqlTransaction tx, string actor, bool locked)
    {
        InventoryDocumentValidation.RequireTransactionalTables(db, tx, "TABLE_PASS");
        using var command = Command(db, tx, "SELECT CLIENTS FROM TABLE_PASS WHERE BINARY ListUser=BINARY @actor" +
            (locked ? " FOR UPDATE" : ""), ("@actor", actor));
        using var reader = command.ExecuteReader();
        if (!reader.Read() || reader.IsDBNull(0)) throw new UnauthorizedAccessException("Droits clients indisponibles.");
        var value = reader.GetString(0);
        if (reader.Read() || value is not ("VISIBLE" or "ACCES MANAGER" or "ACCES ADMIN"))
            throw new UnauthorizedAccessException("Accès aux fichiers clients interdit.");
        return value;
    }
    internal Access Authorize(string actor, Func<string, string> rolePin)
    {
        using var db = Open(); using var tx = db.BeginTransaction(IsolationLevel.ReadCommitted);
        var permission = Permission(db, tx, actor, false);
        var role = permission == "ACCES MANAGER" ? "MANAGER" : permission == "ACCES ADMIN" ? "ADMIN" : null;
        var approver = actor;
        if (role is not null)
        {
            var pin = rolePin(role);
            try
            {
                if (string.IsNullOrWhiteSpace(pin)) throw new UnauthorizedAccessException("Autorisation client annulée.");
                using var command = Command(db, tx, "SELECT ListUser FROM TABLE_PASS WHERE BINARY Catégorie=BINARY @role AND BINARY ListPass=BINARY @pin",
                    ("@role", role), ("@pin", pin));
                using var reader = command.ExecuteReader();
                if (!reader.Read() || reader.IsDBNull(0)) throw new UnauthorizedAccessException("PIN du rôle demandé invalide.");
                approver = reader.GetString(0);
                if (reader.Read()) throw new UnauthorizedAccessException("Autorisation client ambiguë.");
            }
            finally { pin = ""; }
        }
        var access = new Access(this, actor, permission, approver, role);
        Check(access, db, tx); tx.Commit(); return access;
    }
    private void Check(Access access, MySqlConnection db, MySqlTransaction tx)
    {
        if (!ReferenceEquals(access.Owner, this)) throw new UnauthorizedAccessException("Session client étrangère.");
        // Same deterministic actor locking order as the financial discount grant.
        foreach (var user in new[] { access.Actor, access.Approver }.Distinct(StringComparer.Ordinal).OrderBy(x => x, StringComparer.Ordinal))
        {
            using var command = Command(db, tx, "SELECT Catégorie FROM TABLE_PASS WHERE BINARY ListUser=BINARY @id FOR UPDATE", ("@id", user));
            using var row = command.ExecuteReader();
            if (!row.Read() || row.IsDBNull(0) || row.GetString(0) is not ("ADMIN" or "MANAGER" or "UTILISATEUR") ||
                (user == access.Approver && access.Role is not null && row.GetString(0) != access.Role) || row.Read())
                throw new UnauthorizedAccessException("Le rôle ou la session client a changé.");
        }
        if (Permission(db, tx, access.Actor, true) != access.Permission) throw new UnauthorizedAccessException("Les droits clients ont changé.");
    }
    private const string Columns = "ID,ID_CLIENT,CODE_CLIENT,CLIENT,DATES,ICE,ADRESSE,VILLE,PAYS,TELEPHONE,NOTES,VENDEUR,CREDIT_INITIAL";
    private static CustomerFile Row(MySqlDataReader row)
    {
        string Text(int i) => row.IsDBNull(i) ? "" : Convert.ToString(row.GetValue(i), CultureInfo.InvariantCulture)!;
        return new CustomerFile(row.GetInt64(0), Text(1), new CustomerFileDraft(Text(2), Text(3),
            row.IsDBNull(4) ? DateTime.MinValue : Convert.ToDateTime(row.GetValue(4)).Date,
            Text(5), Text(6), Text(7), Text(8), Text(9), Text(10), Text(11), row.IsDBNull(12) ? 0m : row.GetDecimal(12)));
    }
    private static CustomerFile Read(MySqlConnection db, MySqlTransaction tx, string id)
    {
        using var command = Command(db, tx, "SELECT " + Columns + " FROM TABLE_CLIENTS WHERE ID_CLIENT=@id FOR UPDATE", ("@id", id));
        using var reader = command.ExecuteReader();
        if (!reader.Read()) throw new InvalidOperationException("Client introuvable.");
        var result = Row(reader);
        if (result.Id != id || reader.Read()) throw new InvalidOperationException("Identité client ambiguë.");
        return result;
    }
    internal IReadOnlyList<CustomerFile> Search(Access access, string query)
    {
        if (query.Length > 255 || query.Any(char.IsControl)) throw new ArgumentException("Précisez la recherche client.");
        using var db = Open(); using var tx = db.BeginTransaction(IsolationLevel.RepeatableRead); Check(access, db, tx);
        InventoryDocumentValidation.RequireTransactionalTables(db, tx, "TABLE_CLIENTS");
        var escaped = query.Replace("!", "!!").Replace("%", "!%").Replace("_", "!_");
        using var command = Command(db, tx, "SELECT " + Columns + " FROM TABLE_CLIENTS WHERE " +
            "(@empty=1 OR CLIENT LIKE @like ESCAPE '!' OR TELEPHONE LIKE @like ESCAPE '!' OR CODE_CLIENT=@code) ORDER BY ID DESC LIMIT 201",
            ("@empty", query.Length == 0 ? 1 : 0), ("@like", "%" + escaped + "%"), ("@code", query));
        var rows = new List<CustomerFile>(); using (var reader = command.ExecuteReader()) while (reader.Read()) rows.Add(Row(reader));
        if (rows.Count > 200) throw new InvalidOperationException("Plus de 200 clients : précisez la recherche.");
        tx.Commit(); return rows.AsReadOnly();
    }
    internal IReadOnlyList<string> Sellers(Access access)
    {
        using var db = Open(); using var tx = db.BeginTransaction(); Check(access, db, tx);
        using var command = Command(db, tx, "SELECT ListUser FROM TABLE_PASS WHERE Catégorie='UTILISATEUR' ORDER BY ListUser");
        var result = new List<string> { "" }; using (var reader = command.ExecuteReader()) while (reader.Read()) result.Add(reader.GetString(0));
        tx.Commit(); return result.AsReadOnly();
    }
    internal IReadOnlyList<CustomerOpeningHistory> History(Access access, string id)
    {
        using var db = Open(); using var tx = db.BeginTransaction(IsolationLevel.RepeatableRead); Check(access, db, tx);
        InventoryDocumentValidation.RequireTransactionalTables(db, tx, "TABLE_CLIENTS", "TABLE_CLIENTS_HISTORIQUE_CREDIT_INITIAL");
        Read(db, tx, id);
        using var command = Command(db, tx, "SELECT ID,DATES,HEURE,UTILISATEUR,ID_CLIENT,CLIENT,VALEUR_ANCIENNE,VALEUR_NOUVELLE " +
            "FROM TABLE_CLIENTS_HISTORIQUE_CREDIT_INITIAL WHERE BINARY ID_CLIENT=BINARY @id ORDER BY ID DESC", ("@id", id));
        var rows = new List<CustomerOpeningHistory>(); using (var reader = command.ExecuteReader()) while (reader.Read())
            rows.Add(new CustomerOpeningHistory(reader.GetInt64(0), Convert.ToDateTime(reader.GetValue(1)), Convert.ToString(reader.GetValue(2))!,
                reader.GetString(3), reader.GetString(4), reader.GetString(5), Convert.ToDecimal(reader.GetValue(6)), Convert.ToDecimal(reader.GetValue(7))));
        tx.Commit(); return rows.AsReadOnly();
    }
    internal CustomerFile Execute(Access access, CustomerFileCommand request, string pin)
    {
        var attempted = false;
        try { return ExecuteCore(access, request, pin, () => attempted = true); }
        catch (Exception ex) when (!attempted && ex is not OutOfMemoryException and not StackOverflowException)
        { throw new CustomerFileWriteRefusedException(ex.Message, ex); }
    }
    private CustomerFile ExecuteCore(Access access, CustomerFileCommand request, string pin, Action beforeCommit)
    {
        if (!Guid.TryParseExact(request.OperationId, "N", out _) || request.Kind is not ("CREATE" or "UPDATE" or "OPENING"))
            throw new ArgumentException("Opération client invalide.");
        var draft = request.Draft;
        if (request.Kind is "CREATE" or "UPDATE")
        {
            if (draft is null || string.IsNullOrWhiteSpace(draft.Name) || draft.Name.Trim().Length > 255 || draft.Code.Trim().Length > 255 ||
                draft.Date == DateTime.MinValue || draft.OpeningCredit != decimal.Round(draft.OpeningCredit, 4))
                throw new ArgumentException("Nom, date et crédit initial valides requis.");
            if (new[] { draft.Code, draft.Name, draft.Ice, draft.Telephone, draft.City, draft.Country, draft.Seller }.Any(value => value.Length > 255 || value.Any(char.IsControl)) ||
                draft.Address.Length > 255 || draft.Notes.Length > 255) throw new ArgumentException("Champ client trop long ou invalide.");
            draft = draft with { Code = draft.Code.Trim(), Name = draft.Name.Trim(), Date = draft.Date.Date };
            request = request with { Draft = draft };
        }
        if (request.Kind == "CREATE" && request.Expected is not null || request.Kind != "CREATE" && request.Expected is null ||
            request.Kind == "OPENING" && (request.OpeningCredit is null || decimal.Round(request.OpeningCredit.Value, 4) != request.OpeningCredit.Value))
            throw new ArgumentException("Revue client incomplète.");
        using var db = Open(); using var tx = db.BeginTransaction(IsolationLevel.Serializable);
        InventoryDocumentValidation.RequireTransactionalTables(db, tx, "TABLE_PASS", "TABLE_NUM", "TABLE_CLIENTS", "hanouty_customer_file_operations");
        if (!ReferenceEquals(access.Owner, this)) throw new UnauthorizedAccessException("Session client étrangère.");
        InventoryDocumentValidation.Authenticate(db, tx, access.Actor, pin, false);
        // TABLE_NUM serializes numbering and optional-code uniqueness for participating writers.
        long sequence;
        using (var command = Command(db, tx, "SELECT CLIENT FROM TABLE_NUM WHERE ID=0 FOR UPDATE"))
        using (var row = command.ExecuteReader())
        {
            if (!row.Read() || row.IsDBNull(0)) throw new InvalidOperationException("Compteur client indisponible.");
            var value = Convert.ToDecimal(row.GetValue(0));
            if (value < 0m || value != decimal.Truncate(value) || value > long.MaxValue - 1m || row.Read()) throw new InvalidOperationException("Compteur client invalide.");
            sequence = (long)value;
        }
        var payload = JsonSerializer.Serialize(request);
        using (var command = Command(db, tx, "SELECT ACTOR,PAYLOAD,RESULT FROM hanouty_customer_file_operations WHERE OPERATION_ID=@op FOR UPDATE", ("@op", request.OperationId)))
        using (var reader = command.ExecuteReader())
        {
            if (reader.Read())
            {
                if (reader.GetString(0) != access.Actor || reader.GetString(1) != payload) throw new InvalidOperationException("Cette référence a déjà servi à une autre modification.");
                var saved = JsonSerializer.Deserialize<CustomerFile>(reader.GetString(2))!;
                reader.Close(); beforeCommit(); tx.Commit(); return saved;
            }
        }
        // A committed own-operation retry is read-only recovery, even if entry
        // permission was revoked after commit. It cannot authorize a new write.
        Check(access, db, tx);
        CustomerFile result;
        if (request.Kind == "CREATE")
        {
            var id = "CL" + sequence.ToString("D6", CultureInfo.InvariantCulture);
            using (var duplicate = Command(db, tx, "SELECT COUNT(*) FROM TABLE_CLIENTS WHERE ID_CLIENT=@id", ("@id", id)))
                if (Convert.ToInt64(duplicate.ExecuteScalar()) != 0) throw new InvalidOperationException("Numéro client déjà utilisé.");
            long rowId;
            using (var command = Command(db, tx, "SELECT COALESCE(MAX(ID),0) FROM TABLE_CLIENTS FOR UPDATE")) rowId = checked(Convert.ToInt64(command.ExecuteScalar()) + 1);
            CheckCode(db, tx, draft!.Code, null);
            if (draft.Seller.Length != 0) CheckSeller(db, tx, draft.Seller);
            using var insert = DraftCommand(db, tx, "INSERT INTO TABLE_CLIENTS (" + Columns + ",ETAT) VALUES " +
                "(@row,@id,@code,@name,@date,@ice,@address,@city,@country,@phone,@notes,@seller,@opening,'VALIDER')", draft, rowId, id);
            if (insert.ExecuteNonQuery() != 1) throw new InvalidOperationException("Création du client non confirmée.");
            using var next = Command(db, tx, "UPDATE TABLE_NUM SET CLIENT=CLIENT+1 WHERE ID=0");
            if (next.ExecuteNonQuery() != 1) throw new InvalidOperationException("Compteur client non confirmé.");
            result = Read(db, tx, id);
        }
        else
        {
            var current = Read(db, tx, request.Expected!.Id);
            if (current != request.Expected) throw new InvalidOperationException("Le fichier ou le crédit initial a changé. Actualisez le client.");
            if (request.Kind == "UPDATE")
            {
                if (draft!.OpeningCredit != current.Details.OpeningCredit) throw new InvalidOperationException("Utilisez la modification séparée du crédit initial.");
                CheckCode(db, tx, draft.Code, current.RowId); if (draft.Seller.Length != 0) CheckSeller(db, tx, draft.Seller);
                using var update = DraftCommand(db, tx, "UPDATE TABLE_CLIENTS SET CODE_CLIENT=@code,CLIENT=@name,DATES=@date,ICE=@ice," +
                    "ADRESSE=@address,VILLE=@city,PAYS=@country,TELEPHONE=@phone,NOTES=@notes,VENDEUR=@seller,ETAT='VALIDER' WHERE ID=@row AND BINARY ID_CLIENT=BINARY @id",
                    draft, current.RowId, current.Id);
                if (update.ExecuteNonQuery() != 1) throw new InvalidOperationException("Modification client non confirmée.");
            }
            else
            {
                InventoryDocumentValidation.RequireTransactionalTables(db, tx, "TABLE_CLIENTS_HISTORIQUE_CREDIT_INITIAL");
                using var history = Command(db, tx, "INSERT INTO TABLE_CLIENTS_HISTORIQUE_CREDIT_INITIAL " +
                    "(DATES,HEURE,UTILISATEUR,ID_CLIENT,CLIENT,VALEUR_ANCIENNE,VALEUR_NOUVELLE) VALUES (@date,@time,@actor,@id,@name,@old,@new)",
                    ("@date", DateTime.Today), ("@time", DateTime.Now.ToString("HH:mm:ss", CultureInfo.InvariantCulture)), ("@actor", access.Actor),
                    ("@id", current.Id), ("@name", current.Details.Name), ("@old", current.Details.OpeningCredit), ("@new", request.OpeningCredit!.Value));
                if (history.ExecuteNonQuery() != 1) throw new InvalidOperationException("Historique du crédit initial non confirmé.");
                using var update = Command(db, tx, "UPDATE TABLE_CLIENTS SET CREDIT_INITIAL=@value WHERE ID=@row AND BINARY ID_CLIENT=BINARY @id",
                    ("@value", request.OpeningCredit.Value), ("@row", current.RowId), ("@id", current.Id));
                if (update.ExecuteNonQuery() != 1) throw new InvalidOperationException("Crédit initial non confirmé.");
            }
            result = Read(db, tx, current.Id);
        }
        using (var journal = Command(db, tx, "INSERT INTO hanouty_customer_file_operations " +
            "(OPERATION_ID,ACTOR,KIND,CUSTOMER_ID,PAYLOAD,RESULT,CREATED_UTC) VALUES (@op,@actor,@kind,@id,@payload,@result,UTC_TIMESTAMP(6))",
            ("@op", request.OperationId), ("@actor", access.Actor), ("@kind", request.Kind), ("@id", result.Id),
            ("@payload", payload), ("@result", JsonSerializer.Serialize(result))))
            if (journal.ExecuteNonQuery() != 1) throw new InvalidOperationException("Journal client non confirmé.");
        beforeCommit(); tx.Commit(); afterCommit?.Invoke(); return result;
    }
    private static MySqlCommand DraftCommand(MySqlConnection db, MySqlTransaction tx, string sql, CustomerFileDraft draft, long row, string id) =>
        Command(db, tx, sql, ("@row", row), ("@id", id), ("@code", draft.Code), ("@name", draft.Name), ("@date", draft.Date),
            ("@ice", draft.Ice), ("@address", draft.Address), ("@city", draft.City), ("@country", draft.Country), ("@phone", draft.Telephone),
            ("@notes", draft.Notes), ("@seller", draft.Seller), ("@opening", draft.OpeningCredit));
    private static void CheckCode(MySqlConnection db, MySqlTransaction tx, string code, long? excluded)
    {
        if (code.Length == 0) return;
        using var command = Command(db, tx, "SELECT ID FROM TABLE_CLIENTS WHERE CODE_CLIENT=@code AND (@excluded IS NULL OR ID<>@excluded) FOR UPDATE",
            ("@code", code), ("@excluded", (object?)excluded ?? DBNull.Value));
        using var reader = command.ExecuteReader(); if (reader.Read()) throw new InvalidOperationException("Ce code client est déjà utilisé.");
    }
    private static void CheckSeller(MySqlConnection db, MySqlTransaction tx, string seller)
    {
        using var command = Command(db, tx, "SELECT ListUser FROM TABLE_PASS WHERE BINARY ListUser=BINARY @seller AND Catégorie='UTILISATEUR'", ("@seller", seller));
        using var reader = command.ExecuteReader(); if (!reader.Read() || reader.Read()) throw new InvalidOperationException("Vendeur indisponible.");
    }
}
