using MySql.Data.MySqlClient;

namespace Hanouty.Desktop.Bootstrap;

internal static class LogicaPinLogin
{
    // Form_1_LOGIN resolves the cashier from TABLE_PASS.ListPass. A shared PIN
    // must not silently select the first account, as the original implementation did.
    internal static string Resolve(Func<MySqlConnection> connections, string pin)
    {
        if (string.IsNullOrWhiteSpace(pin) || pin.Length > 256 || pin.Any(char.IsControl))
            throw new UnauthorizedAccessException("Code d’accès incorrect.");
        using var db = connections();
        if (new MySqlConnectionStringBuilder(db.ConnectionString).Server is not ("127.0.0.1" or "localhost" or "::1"))
            throw new InvalidOperationException("La connexion à la caisse doit rester locale.");
        db.Open();
        using var tx = db.BeginTransaction(System.Data.IsolationLevel.Serializable);
        using var command = new MySqlCommand("SELECT ListUser,ListPass,Catégorie FROM TABLE_PASS WHERE BINARY ListPass=BINARY @pin FOR UPDATE", db, tx);
        command.Parameters.AddWithValue("@pin", pin);
        using var rows = command.ExecuteReader();
        if (!rows.Read() || rows.IsDBNull(0) || rows.IsDBNull(1) || rows.IsDBNull(2))
            throw new UnauthorizedAccessException("Code d’accès incorrect.");
        var actor = rows.GetString(0);
        if (!string.Equals(rows.GetString(1), pin, StringComparison.Ordinal) ||
            rows.GetString(2) is not ("ADMIN" or "MANAGER" or "UTILISATEUR") ||
            string.IsNullOrWhiteSpace(actor) || actor.Length > 64 || actor != actor.Trim() || actor.Any(char.IsControl) || rows.Read())
            throw new UnauthorizedAccessException("Code d’accès incorrect ou partagé entre plusieurs utilisateurs.");
        rows.Close(); tx.Commit(); return actor;
    }
}
