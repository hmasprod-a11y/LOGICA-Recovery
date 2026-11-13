using System.Data;
using System.Globalization;
using MySql.Data.MySqlClient;

namespace Hanouty.Desktop.Bootstrap;

internal sealed class CashDrawerClosing(string connectionString)
{
    private static readonly string[] Tables =
    [
        "TABLE_VENTES_JOURNAL", "TABLE_VENTES_ENTETE", "TABLE_VENTES_REGLEMENTS",
        "TABLE_DEPENSES", "TABLE_FOURNISSEURS_REGLE", "TABLE_CLIENTS_REGLE", "TABLE_POUBELLE"
    ];

    internal sealed record Summary(long Number, long Rows, decimal Opening, decimal CashSales,
        decimal ClientCash, decimal SupplierCash, decimal Expenses, decimal NetSales)
    {
        public decimal Expected => Opening + CashSales + ClientCash - SupplierCash - Expenses;
    }

    public Summary Read(string cashier, string pin)
    {
        using var connection = Open();
        using var transaction = connection.BeginTransaction(IsolationLevel.Serializable);
        return Read(connection, transaction, cashier, pin);
    }

    public Summary Close(string cashier, string pin, Summary reviewed)
    {
        using var connection = Open();
        using var transaction = connection.BeginTransaction(IsolationLevel.Serializable);
        var current = Read(connection, transaction, cashier, pin);
        if (reviewed != current) throw new InvalidOperationException("Les mouvements ont changé. Actualisez la clôture.");
        long rows = 0;
        foreach (var table in Tables)
        {
            using var command = new MySqlCommand(
                $"UPDATE {table} SET CLOTURE_GLOBALE = @number WHERE CLOTURE_GLOBALE IS NULL",
                connection, transaction);
            command.Parameters.AddWithValue("@number", current.Number.ToString(CultureInfo.InvariantCulture));
            rows += command.ExecuteNonQuery();
        }
        if (rows != current.Rows) throw new InvalidOperationException("Les mouvements ont changé.");
        transaction.Commit();
        return current;
    }

    private MySqlConnection Open()
    {
        var settings = new MySqlConnectionStringBuilder(connectionString);
        if (settings.Server is not ("127.0.0.1" or "localhost" or "::1"))
            throw new InvalidOperationException("Base MariaDB locale requise.");
        var connection = new MySqlConnection(connectionString);
        try { connection.Open(); return connection; }
        catch { connection.Dispose(); throw; }
    }

    private static Summary Read(MySqlConnection connection, MySqlTransaction transaction, string cashier, string pin)
    {
        if (string.IsNullOrWhiteSpace(cashier) || string.IsNullOrWhiteSpace(pin))
            throw new UnauthorizedAccessException("Authentification requise.");
        using var command = new MySqlCommand("", connection, transaction);
        object? Scalar(string sql)
        {
            command.CommandText = sql;
            return command.ExecuteScalar();
        }
        decimal Amount(string sql) => Convert.ToDecimal(Scalar(sql), CultureInfo.InvariantCulture);
        foreach (var table in Tables.Concat(["TABLE_PARAMETRES", "TABLE_PASS"]))
        {
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@table", table);
            if (!Equals(Scalar("SELECT ENGINE FROM information_schema.TABLES WHERE TABLE_SCHEMA=DATABASE() AND TABLE_NAME=@table"), "InnoDB"))
                throw new InvalidOperationException("Schéma transactionnel de clôture incomplet.");
        }
        command.Parameters.Clear();
        command.Parameters.AddWithValue("@cashier", cashier);
        command.Parameters.AddWithValue("@pin", pin);
        if (Amount("SELECT COUNT(*) FROM TABLE_PASS WHERE BINARY ListUser=BINARY @cashier") != 1 ||
            Amount("SELECT COUNT(*) FROM TABLE_PASS WHERE BINARY ListUser=BINARY @cashier AND BINARY ListPass=BINARY @pin AND BINARY CLOTURE=BINARY 'VISIBLE'") != 1)
            throw new UnauthorizedAccessException("Clôture non autorisée pour cet utilisateur.");

        string Setting(string name)
        {
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@setting", name);
            command.CommandText = "SELECT VALEUR FROM TABLE_PARAMETRES WHERE OBJET=@setting FOR UPDATE";
            using var reader = command.ExecuteReader();
            if (!reader.Read() || reader.IsDBNull(0)) throw new InvalidOperationException("Paramètre de caisse absent.");
            var value = reader.GetString(0);
            if (reader.Read()) throw new InvalidOperationException("Paramètre de caisse ambigu.");
            return value;
        }

        if (!bool.TryParse(Setting("GESTION_CLOTURE"), out var enabled) || !enabled)
            throw new InvalidOperationException("La clôture est désactivée.");
        if (!bool.TryParse(Setting("CLOTURE_CAISSIER_OBLIGER"), out var perCashier))
            throw new InvalidOperationException("Paramètre de clôture caissier invalide.");
        if (perCashier && Amount("SELECT COUNT(*) FROM TABLE_VENTES_JOURNAL WHERE CLOTURE_GLOBALE IS NULL AND CLOTURE_CAISSIER IS NULL") > 0)
            throw new InvalidOperationException("Clôturez d’abord les caissiers comme dans LOGICA.");

        var rawOpening = Setting("FONDS_CAISSE");
        if (!decimal.TryParse(rawOpening.Replace(',', '.'), NumberStyles.AllowDecimalPoint,
                CultureInfo.InvariantCulture, out var opening) || opening < 0)
            throw new InvalidOperationException("Fond de caisse invalide.");
        long rows = 0;
        long previous = 0;
        foreach (var table in Tables)
        {
            rows += (long)Amount($"SELECT COUNT(*) FROM {table} WHERE CLOTURE_GLOBALE IS NULL");
            previous = Math.Max(previous, (long)Amount($"SELECT COALESCE(MAX(CAST(CLOTURE_GLOBALE AS UNSIGNED)), 0) FROM {table}"));
        }
        if (Amount("SELECT COUNT(*) FROM TABLE_VENTES_JOURNAL WHERE CLOTURE_GLOBALE IS NULL AND DATES IS NOT NULL") == 0)
            throw new InvalidOperationException("Aucune vente ouverte à clôturer.");
        const string open = " WHERE CLOTURE_GLOBALE IS NULL";
        decimal Sum(string table, string column, string condition = "") =>
            Amount($"SELECT COALESCE(SUM({column}), 0) FROM {table}{open}{condition}");
        const string cash = " AND MODE_P = 'ESPECES'";
        return new Summary(checked(previous + 1), rows, opening,
            Sum("TABLE_VENTES_REGLEMENTS", "MONTANT", cash),
            Sum("TABLE_CLIENTS_REGLE", "MONTANT", cash),
            Sum("TABLE_FOURNISSEURS_REGLE", "MONTANT", cash),
            Sum("TABLE_DEPENSES", "MONTANT"),
            Sum("TABLE_VENTES_JOURNAL", "TOTAL_NET", " AND OPERATION IN ('VENTE','RETOUR REMBOURSEMENT')"));
    }
}
