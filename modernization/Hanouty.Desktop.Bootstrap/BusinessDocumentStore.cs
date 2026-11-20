using System.Data;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using Hanouty.Desktop.Wpf;
using MySql.Data.MySqlClient;

namespace Hanouty.Desktop.Bootstrap;

// Form_900_DEVIS / Form_9000_BL / Form_90000_FACTURE consultation and validation.
// Original tables only. No startup schema creation, numbering, sales or stock posting.
internal sealed class BusinessDocumentStore(string connectionString, string actor)
{
    private static (string Header, string Lines, string Key) Tables(BusinessDocumentKind kind) => kind switch
    {
        BusinessDocumentKind.Devis => ("TABLE_DEVIS_ENTETE", "TABLE_DEVIS_DETAILS", "ID_DEVIS"),
        BusinessDocumentKind.BonLivraison => ("TABLE_BL_ENTETE", "TABLE_BL_DETAILS", "ID_BL"),
        BusinessDocumentKind.Facture => ("TABLE_FACTURE_ENTETE", "TABLE_FACTURE_DETAILS", "ID_FACTURE"),
        _ => throw new ArgumentOutOfRangeException(nameof(kind))
    };
    private MySqlConnection Open()
    {
        var cs = new MySqlConnectionStringBuilder(connectionString);
        if (cs.Server is not ("127.0.0.1" or "localhost" or "::1")) throw new InvalidOperationException("Base locale requise.");
        var db = new MySqlConnection(connectionString); db.Open(); return db;
    }
    private static MySqlCommand Command(MySqlConnection db, MySqlTransaction tx, string sql, params (string, object)[] values)
    {
        var command = new MySqlCommand(sql, db, tx);
        foreach (var (key, value) in values) command.Parameters.AddWithValue(key, value);
        return command;
    }
    private void RequireActor(MySqlConnection db, MySqlTransaction tx)
    {
        using var command = Command(db, tx, "SELECT Catégorie FROM TABLE_PASS WHERE BINARY ListUser=BINARY @actor FOR UPDATE", ("@actor", actor));
        using var reader = command.ExecuteReader();
        if (!reader.Read() || reader.IsDBNull(0) || reader.GetString(0) is not ("ADMIN" or "MANAGER" or "UTILISATEUR") || reader.Read())
            throw new UnauthorizedAccessException("Session documentaire indisponible.");
    }
    private static string HeaderColumns(string key) => $"ID,{key},DATES,ID_CLIENT,CODE_CLIENT,CLIENT,UTILISATEUR,NOTES,ETAT,TOTAL_HT_DOC,TOTAL_TVA_DOC,TOTAL_TTC_DOC,TOTAL_REMISE_DOC";
    private static string Text(MySqlDataReader row, int index) => row.IsDBNull(index) ? "" : row.GetString(index);
    private static BusinessDocumentHeader Header(MySqlDataReader row) => new(row.GetInt64(0), Text(row, 1), row.GetDateTime(2),
        Text(row, 3), Text(row, 4), Text(row, 5), Text(row, 6), Text(row, 7), Text(row, 8),
        row.GetDecimal(9), row.GetDecimal(10), row.GetDecimal(11), row.GetDecimal(12));
    internal IReadOnlyList<BusinessDocumentHeader> Search(BusinessDocumentKind kind, DateTime from, DateTime to, string search)
    {
        if (from.Year < 1000 || from.Date > to.Date || to.Date == DateTime.MaxValue.Date || search.Length > 255 || search.Any(char.IsControl))
            throw new ArgumentException("Période ou recherche invalide.");
        var tables = Tables(kind); using var db = Open(); using var tx = db.BeginTransaction(IsolationLevel.RepeatableRead);
        InventoryDocumentValidation.RequireTransactionalTables(db, tx, "TABLE_PASS", tables.Header); RequireActor(db, tx);
        var escaped = search.Replace("!", "!!").Replace("%", "!%").Replace("_", "!_");
        using var command = Command(db, tx, $"SELECT {HeaderColumns(tables.Key)} FROM {tables.Header} " +
            $"WHERE DATES>=@from AND DATES<@until AND (@empty=1 OR {tables.Key}=@number OR CLIENT LIKE @query ESCAPE '!' OR CODE_CLIENT=@number) ORDER BY ID DESC LIMIT 201",
            ("@from", from.Date), ("@until", to.Date.AddDays(1)), ("@empty", search.Length == 0 ? 1 : 0), ("@number", search), ("@query", "%" + escaped + "%"));
        var rows = new List<BusinessDocumentHeader>(); using (var reader = command.ExecuteReader()) while (reader.Read()) rows.Add(Header(reader));
        if (rows.Count > 200) throw new InvalidOperationException("Plus de 200 documents : précisez la recherche ou la période.");
        tx.Commit(); return rows.AsReadOnly();
    }
    internal BusinessDocumentSnapshot Read(BusinessDocumentKind kind, long rowId)
    {
        using var db = Open(); using var tx = db.BeginTransaction(IsolationLevel.RepeatableRead);
        RequireTables(db, tx, kind); RequireActor(db, tx); var result = ReadCore(db, tx, kind, rowId); tx.Commit(); return result;
    }
    private static void RequireTables(MySqlConnection db, MySqlTransaction tx, BusinessDocumentKind kind)
    {
        var tables = Tables(kind);
        InventoryDocumentValidation.RequireTransactionalTables(db, tx, "TABLE_PASS", "TABLE_CLIENTS", tables.Header, tables.Lines);
    }
    private static BusinessDocumentSnapshot ReadCore(MySqlConnection db, MySqlTransaction tx, BusinessDocumentKind kind, long rowId)
    {
        var tables = Tables(kind); BusinessDocumentHeader header;
        using (var command = Command(db, tx, $"SELECT {HeaderColumns(tables.Key)} FROM {tables.Header} WHERE ID=@id FOR UPDATE", ("@id", rowId)))
        using (var reader = command.ExecuteReader())
        {
            if (!reader.Read()) throw new InvalidOperationException("Document introuvable.");
            header = Header(reader); if (reader.Read() || string.IsNullOrWhiteSpace(header.Number)) throw new InvalidOperationException("Identité documentaire invalide.");
        }
        using (var duplicate = Command(db, tx, $"SELECT COUNT(*) FROM {tables.Header} WHERE {tables.Key}=@number", ("@number", header.Number)))
            if (Convert.ToInt64(duplicate.ExecuteScalar()) != 1) throw new InvalidOperationException("Numéro documentaire ambigu.");
        var lines = new List<BusinessDocumentLine>();
        using (var command = Command(db, tx, $"SELECT ID,ID_ARTICLE,Code,Article,PU_TTC,TAUX_TVA,PU_HT,`Qté`,TOTAL_TTC,TOTAL_TVA,TOTAL_HT,TAUX_REMISE,ETAT,ID_CLIENT,CODE_CLIENT,CLIENT FROM {tables.Lines} WHERE {tables.Key}=@number ORDER BY ID FOR UPDATE", ("@number", header.Number)))
        using (var reader = command.ExecuteReader()) while (reader.Read())
        {
            if (Text(reader, 13) != header.CustomerId || Text(reader, 14) != header.CustomerCode || Text(reader, 15) != header.Customer)
                throw new InvalidOperationException("Client différent entre entête et lignes.");
            lines.Add(new BusinessDocumentLine(reader.GetInt64(0), Text(reader, 1), Text(reader, 2), Text(reader, 3), reader.GetDecimal(4), reader.GetDecimal(5),
                reader.GetDecimal(6), reader.GetDecimal(7), reader.GetDecimal(8), reader.GetDecimal(9), reader.GetDecimal(10), reader.GetDecimal(11), Text(reader, 12)));
        }
        if (lines.Count == 0 || lines.Sum(x => x.TotalTtc) != header.TotalTtc || lines.Sum(x => x.TotalTax) != header.TotalTax || lines.Sum(x => x.TotalHt) != header.TotalHt)
            throw new InvalidOperationException("Document vide ou totaux d’entête différents des lignes persistées.");
        string customerName, ice, address;
        using (var command = Command(db, tx, "SELECT CLIENT,ICE,ADRESSE FROM TABLE_CLIENTS WHERE ID_CLIENT=@id FOR UPDATE", ("@id", header.CustomerId)))
        using (var reader = command.ExecuteReader())
        {
            if (!reader.Read()) throw new InvalidOperationException("Client du document introuvable.");
            customerName = Text(reader, 0); ice = Text(reader, 1); address = Text(reader, 2); if (reader.Read()) throw new InvalidOperationException("Client du document ambigu.");
        }
        // State is excluded only to permit safe readback after a lost validation acknowledgement.
        var payload = JsonSerializer.Serialize(new { kind, Header = header with { State = "" }, Lines = lines.Select(x => x with { State = "" }), customerName, ice, address });
        var revision = Convert.ToHexString(SHA256.HashData(Encoding.UTF8.GetBytes(payload)));
        return new(kind, header, lines.AsReadOnly(), customerName, ice, address, revision);
    }
    internal BusinessDocumentSnapshot Validate(BusinessDocumentSnapshot reviewed, string pin)
    {
        using var db = Open(); using var tx = db.BeginTransaction(IsolationLevel.Serializable); RequireTables(db, tx, reviewed.Kind);
        // All three original FUN_CAT_ACCES forms allow ADMIN/MANAGER validation, not UTILISATEUR.
        InventoryDocumentValidation.Authenticate(db, tx, actor, pin, validationOnly: true);
        var current = ReadCore(db, tx, reviewed.Kind, reviewed.Header.RowId);
        if (current.Revision != reviewed.Revision) throw new InvalidOperationException("Le document a changé. Consultez-le à nouveau.");
        if (current.Header.State == "VALIDER" && current.Lines.All(x => x.State == "VALIDER")) { tx.Commit(); return current; }
        if (reviewed.Header.State != "ENREGISTRER" || current.Header.State != "ENREGISTRER" || current.Lines.Any(x => x.State != "ENREGISTRER"))
            throw new InvalidOperationException("État documentaire non validable.");
        var tables = Tables(reviewed.Kind);
        using (var command = Command(db, tx, $"UPDATE {tables.Header} SET ETAT='VALIDER' WHERE ID=@id AND ETAT='ENREGISTRER'", ("@id", current.Header.RowId)))
            if (command.ExecuteNonQuery() != 1) throw new InvalidOperationException("Validation d’entête non confirmée.");
        using (var command = Command(db, tx, $"UPDATE {tables.Lines} SET ETAT='VALIDER' WHERE {tables.Key}=@number AND ETAT='ENREGISTRER'", ("@number", current.Header.Number)))
            if (command.ExecuteNonQuery() != current.Lines.Count) throw new InvalidOperationException("Validation des lignes non confirmée.");
        var result = ReadCore(db, tx, reviewed.Kind, current.Header.RowId); tx.Commit(); return result;
    }
}
