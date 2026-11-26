using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using MySql.Data.MySqlClient;

namespace Hanouty.Checkout.MariaDb
{
    public sealed record CreditCustomer(string Id, string Code, string Name, string Telephone);

    public static partial class MariaDbCashCheckoutServices
    {
        // Original Form_3_VENTE loads this local LOGICA switch. A missing or
        // malformed setting cannot silently enable a new credit operation.
        public static bool IsCreditSaleEnabled(string configurationDirectory)
        {
            if (string.IsNullOrWhiteSpace(configurationDirectory)) return false;
            try
            {
                var file = Path.Combine(configurationDirectory, "gestion_credit.sni");
                return File.Exists(file) && Microsoft.VisualBasic.CompilerServices.Conversions.ToBoolean(File.ReadAllText(file));
            }
            catch (Exception ex) when (ex is IOException || ex is UnauthorizedAccessException ||
                ex is ArgumentException || ex is InvalidCastException) { return false; }
        }

        public static IReadOnlyList<CreditCustomer> FindCreditCustomers(Func<MySqlConnection> connections, string search)
        {
            search = search ?? "";
            if (search.Length > 128 || search.Any(character => char.IsControl(character) || char.IsSurrogate(character)))
                throw new ArgumentException("Précisez le nom, le téléphone ou le code client.");
            using var connection = LocalConnection(connections);
            connection.Open();
            using var transaction = connection.BeginTransaction(IsolationLevel.RepeatableRead);
            RequireInnoDb(connection, transaction, "TABLE_CLIENTS");
            // Same fields as Form_5_CLIENTS_LISTE. Wildcards remain literal and
            // identities are hidden selection keys rather than editable input.
            var escaped = search.Replace("!", "!!").Replace("%", "!%").Replace("_", "!_");
            using var command = new MySqlCommand("SELECT c.ID_CLIENT,c.CODE_CLIENT,c.CLIENT,c.TELEPHONE FROM TABLE_CLIENTS c " +
                "JOIN (SELECT ID_CLIENT FROM TABLE_CLIENTS GROUP BY ID_CLIENT HAVING COUNT(*)=1) u ON u.ID_CLIENT=c.ID_CLIENT " +
                "WHERE (@empty=1 OR c.CLIENT LIKE @pattern ESCAPE '!' OR c.TELEPHONE LIKE @pattern ESCAPE '!' " +
                "OR BINARY c.CODE_CLIENT=BINARY @code) ORDER BY c.CLIENT,BINARY c.ID_CLIENT LIMIT 201", connection, transaction);
            command.Parameters.AddWithValue("@empty", search.Length == 0 ? 1 : 0);
            command.Parameters.AddWithValue("@pattern", "%" + escaped + "%");
            command.Parameters.AddWithValue("@code", search);
            using var reader = command.ExecuteReader();
            var rows = new List<CreditCustomer>();
            while (reader.Read())
            {
                if (reader.IsDBNull(0) || reader.IsDBNull(2)) continue;
                var id = Convert.ToString(reader.GetValue(0));
                var name = Convert.ToString(reader.GetValue(2));
                if (string.IsNullOrWhiteSpace(id) || id == "0" || id != id.Trim() || id.Length > 64 ||
                    id.Any(character => char.IsControl(character) || char.IsSurrogate(character)) || string.IsNullOrWhiteSpace(name)) continue;
                rows.Add(new CreditCustomer(id, reader.IsDBNull(1) ? "" : Convert.ToString(reader.GetValue(1)), name,
                    reader.IsDBNull(3) ? "" : Convert.ToString(reader.GetValue(3))));
            }
            reader.Close();
            if (rows.Count > 200) throw new InvalidOperationException("Plus de 200 clients : précisez la recherche.");
            var duplicate = rows.GroupBy(row => row.Id, StringComparer.Ordinal).Where(group => group.Count() > 1)
                .Select(group => group.Key).ToHashSet(StringComparer.Ordinal);
            transaction.Commit();
            return Array.AsReadOnly(rows.Where(row => !duplicate.Contains(row.Id)).ToArray());
        }

        internal static CreditCustomer ReadCreditCustomer(MySqlConnection connection, MySqlTransaction transaction, string id)
        {
            RequireInnoDb(connection, transaction, "TABLE_CLIENTS");
            using var command = new MySqlCommand("SELECT ID_CLIENT,CODE_CLIENT,CLIENT,TELEPHONE FROM TABLE_CLIENTS " +
                // Use the same identifier collation as the existing credit
                // statement joins. Case/accent aliases must never share a debt.
                "WHERE ID_CLIENT=@id FOR UPDATE", connection, transaction);
            command.Parameters.AddWithValue("@id", id);
            using var reader = command.ExecuteReader();
            if (!reader.Read() || reader.IsDBNull(0) || reader.IsDBNull(2))
                throw new InvalidOperationException("Client introuvable. Choisissez à nouveau le client.");
            var result = new CreditCustomer(Convert.ToString(reader.GetValue(0)),
                reader.IsDBNull(1) ? "" : Convert.ToString(reader.GetValue(1)), Convert.ToString(reader.GetValue(2)),
                reader.IsDBNull(3) ? "" : Convert.ToString(reader.GetValue(3)));
            if (reader.Read() || string.IsNullOrWhiteSpace(result.Name))
                throw new InvalidOperationException("Identifiant client ambigu ou incomplet.");
            return result;
        }
    }
}
