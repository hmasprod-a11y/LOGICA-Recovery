using System.Data;
using Hanouty.Desktop.Wpf;
using MySql.Data.MySqlClient;

namespace Hanouty.Desktop.Bootstrap;

internal sealed class CustomerSettlementWriter(string connectionString)
{
    internal string[] PaymentModes()
    {
        using var connection = Open();
        using var command = new MySqlCommand("SELECT MODE_P FROM TABLE_MODE_P ORDER BY MODE_P", connection);
        using var reader = command.ExecuteReader();
        var modes = new List<string>();
        while (reader.Read())
            if (!reader.IsDBNull(0) && !string.IsNullOrWhiteSpace(reader.GetString(0)))
                modes.Add(reader.GetString(0));
        return modes.Distinct(StringComparer.Ordinal).ToArray();
    }

    internal bool Record(CustomerSettlementRequest request, string actor, string pin)
    {
        if (string.IsNullOrWhiteSpace(request.OperationId) || request.OperationId.Length > 64 ||
            string.IsNullOrWhiteSpace(request.CustomerId) || string.IsNullOrWhiteSpace(request.PaymentMode) ||
            request.Amount <= 0 || decimal.Round(request.Amount, 2) != request.Amount || string.IsNullOrWhiteSpace(pin))
            throw new ArgumentException("Règlement incomplet.");
        using var connection = Open();
        using var transaction = connection.BeginTransaction(IsolationLevel.Serializable);
        InventoryDocumentValidation.RequireTransactionalTables(connection, transaction, "TABLE_PASS", "TABLE_CLIENTS",
            "TABLE_CLIENTS_REGLE", "TABLE_MODE_P", "hanouty_client_settlement_operations");
        InventoryDocumentValidation.Authenticate(connection, transaction, actor, pin, validationOnly: false);
        // Serialize allocation of LOGICA's MAX(ID)+1 across all participating settlement writers.
        using var ids = Command("SELECT ID FROM TABLE_CLIENTS_REGLE ORDER BY ID FOR UPDATE");
        long next = 1;
        using (var rows = ids.ExecuteReader())
            while (rows.Read())
                if (!rows.IsDBNull(0)) next = Math.Max(next, checked(rows.GetInt64(0) + 1));

        using var prior = Command("""
            SELECT ACTOR, CLIENT_ID, AMOUNT, PAYMENT_MODE, NOTES, SETTLEMENT_ID
            FROM hanouty_client_settlement_operations WHERE OPERATION_ID=@operation FOR UPDATE
            """, ("@operation", request.OperationId));
        long? persisted = null;
        using (var rows = prior.ExecuteReader())
        {
            if (rows.Read())
            {
                if (rows.GetString(0) != actor || rows.GetString(1) != request.CustomerId ||
                    rows.GetDecimal(2) != request.Amount || rows.GetString(3) != request.PaymentMode ||
                    rows.GetString(4) != request.Notes)
                    throw new InvalidOperationException("L’opération existe avec un autre contenu.");
                persisted = rows.GetInt64(5);
            }
        }
        if (persisted is long saved)
        {
            using var verify = Command("""
                SELECT ID_REGLE,ID_CLIENT,UTILISATEUR,MONTANT,MODE_P,NOTES,ETAT
                FROM TABLE_CLIENTS_REGLE WHERE ID=@id FOR UPDATE
                """, ("@id", saved), ("@operation", request.OperationId), ("@client", request.CustomerId),
                ("@actor", actor), ("@amount", request.Amount), ("@mode", request.PaymentMode), ("@notes", request.Notes));
            using var row = verify.ExecuteReader();
            if (!row.Read() || row.GetString(0) != request.OperationId || row.GetString(1) != request.CustomerId ||
                row.GetString(2) != actor || row.GetDecimal(3) != request.Amount || row.GetString(4) != request.PaymentMode ||
                row.GetString(5) != request.Notes || row.GetString(6) != "VALIDER" || row.Read())
                throw new InvalidOperationException("Le règlement enregistré doit être vérifié.");
            row.Close();
            transaction.Commit();
            return true;
        }

        using var mode = Command("SELECT MODE_P FROM TABLE_MODE_P WHERE BINARY MODE_P=BINARY @mode FOR UPDATE",
            ("@mode", request.PaymentMode));
        using (var rows = mode.ExecuteReader())
            if (!rows.Read() || rows.Read()) throw new InvalidOperationException("Mode de paiement indisponible.");

        using var client = Command("SELECT CODE_CLIENT, CLIENT FROM TABLE_CLIENTS WHERE BINARY ID_CLIENT=BINARY @client FOR UPDATE",
            ("@client", request.CustomerId));
        string code, name;
        using (var row = client.ExecuteReader())
        {
            if (!row.Read()) throw new InvalidOperationException("Client introuvable.");
            code = row.IsDBNull(0) ? "" : Convert.ToString(row.GetValue(0))!;
            name = row.GetString(1);
            if (row.Read()) throw new InvalidOperationException("Identifiant client ambigu.");
        }

        using var insert = Command("""
            INSERT INTO TABLE_CLIENTS_REGLE
              (ID, DATES, UTILISATEUR, ID_REGLE, ID_CLIENT, CODE_CLIENT, CLIENT, MONTANT, MODE_P, NOTES, ETAT)
            VALUES (@id, @date, @actor, @operation, @client, @code, @name, @amount, @mode, @notes, 'VALIDER')
            """, ("@id", next), ("@date", DateTime.Now), ("@actor", actor), ("@operation", request.OperationId),
            ("@client", request.CustomerId), ("@code", code), ("@name", name), ("@amount", request.Amount),
            ("@mode", request.PaymentMode), ("@notes", request.Notes));
        if (insert.ExecuteNonQuery() != 1) throw new InvalidOperationException("Règlement non enregistré.");
        using var journal = Command("""
            INSERT INTO hanouty_client_settlement_operations
            (OPERATION_ID, ACTOR, CLIENT_ID, AMOUNT, PAYMENT_MODE, NOTES, SETTLEMENT_ID)
            VALUES (@operation, @actor, @client, @amount, @mode, @notes, @id)
            """, ("@operation", request.OperationId), ("@actor", actor), ("@client", request.CustomerId),
            ("@amount", request.Amount), ("@mode", request.PaymentMode), ("@notes", request.Notes), ("@id", next));
        if (journal.ExecuteNonQuery() != 1) throw new InvalidOperationException("Journal non enregistré.");
        transaction.Commit();
        return true;

        MySqlCommand Command(string sql, params (string Name, object Value)[] parameters)
        {
            var command = new MySqlCommand(sql, connection, transaction);
            foreach (var (name, value) in parameters) command.Parameters.AddWithValue(name, value);
            return command;
        }
    }

    private MySqlConnection Open()
    {
        var settings = new MySqlConnectionStringBuilder(connectionString);
        if (settings.Server is not ("127.0.0.1" or "localhost" or "::1"))
            throw new InvalidOperationException("Base locale requise.");
        var connection = new MySqlConnection(connectionString);
        try { connection.Open(); return connection; }
        catch { connection.Dispose(); throw; }
    }
}
