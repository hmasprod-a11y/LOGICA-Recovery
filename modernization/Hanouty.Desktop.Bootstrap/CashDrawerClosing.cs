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
        decimal ClientCash, decimal SupplierCash, decimal Expenses, decimal NetSales, bool PerCashier)
    {
        public decimal Expected => Opening + CashSales + ClientCash - SupplierCash - Expenses;
    }

    public Summary Read(string cashier, string pin, bool perCashier = false, string? approvalPin = null)
    {
        using var connection = Open();
        using var transaction = connection.BeginTransaction(IsolationLevel.Serializable);
        return Read(connection, transaction, cashier, pin, perCashier, approvalPin);
    }

    public Summary Close(string cashier, string pin, Summary reviewed, string? approvalPin = null)
    {
        using var connection = Open();
        using var transaction = connection.BeginTransaction(IsolationLevel.Serializable);
        var current = Read(connection, transaction, cashier, pin, reviewed.PerCashier, approvalPin);
        if (reviewed != current) throw new InvalidOperationException("Les mouvements ont changé. Actualisez la clôture.");
        long rows = 0;
        foreach (var table in Tables)
        {
            using var command = new MySqlCommand(
                $"UPDATE {table} SET {ClosingColumn(current.PerCashier)} = @number{Scope(table, current.PerCashier)}",
                connection, transaction);
            command.Parameters.AddWithValue("@cashier", cashier);
            command.Parameters.AddWithValue("@number", current.Number.ToString(CultureInfo.InvariantCulture));
            rows += command.ExecuteNonQuery();
        }
        if (rows != current.Rows) throw new InvalidOperationException("Les mouvements ont changé.");
        transaction.Commit();
        return current;
    }

    public void SetOpening(string cashier, string pin, decimal amount)
    {
        if (amount < 0 || decimal.Round(amount, 2) != amount)
            throw new ArgumentOutOfRangeException(nameof(amount));
        using var connection = Open();
        using var transaction = connection.BeginTransaction(IsolationLevel.Serializable);
        using var command = new MySqlCommand("", connection, transaction);
        Authorize(command, cashier, pin);
        if (Convert.ToInt64(Scalar(command,
                "SELECT COUNT(*) FROM TABLE_PARAMETRES WHERE OBJET='FONDS_CAISSE'")) != 1)
            throw new InvalidOperationException("Fond de caisse absent ou ambigu.");
        command.Parameters.Clear();
        command.Parameters.AddWithValue("@amount", amount.ToString("0.00", CultureInfo.InvariantCulture));
        command.CommandText = "UPDATE TABLE_PARAMETRES SET VALEUR=@amount WHERE OBJET='FONDS_CAISSE'";
        command.ExecuteNonQuery();
        transaction.Commit();
    }

    private static object? Scalar(MySqlCommand command, string sql)
    {
        command.CommandText = sql;
        return command.ExecuteScalar();
    }

    private static void Authorize(MySqlCommand command, string cashier, string pin, string? approvalPin = null)
    {
        if (string.IsNullOrWhiteSpace(cashier) || string.IsNullOrWhiteSpace(pin))
            throw new UnauthorizedAccessException("Authentification requise.");
        foreach (var table in Tables.Concat(["TABLE_PARAMETRES", "TABLE_PASS"]))
        {
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@table", table);
            if (!Equals(Scalar(command, "SELECT ENGINE FROM information_schema.TABLES WHERE TABLE_SCHEMA=DATABASE() AND TABLE_NAME=@table"), "InnoDB"))
                throw new InvalidOperationException("Schéma transactionnel de clôture incomplet.");
        }
        command.Parameters.Clear();
        command.Parameters.AddWithValue("@cashier", cashier);
        command.Parameters.AddWithValue("@pin", pin);
        if (Convert.ToInt64(Scalar(command, "SELECT COUNT(*) FROM TABLE_PASS WHERE BINARY ListUser=BINARY @cashier")) != 1)
            throw new UnauthorizedAccessException("Compte caissier invalide.");

        var permission = Convert.ToString(Scalar(command,
            "SELECT CLOTURE FROM TABLE_PASS WHERE BINARY ListUser=BINARY @cashier AND BINARY ListPass=BINARY @pin"));
        var role = permission switch
        {
            "ACCES MANAGER" => "MANAGER",
            "ACCES ADMIN" => "ADMIN",
            _ => null
        };
        if (permission != "VISIBLE")
        {
            if (role is null || string.IsNullOrWhiteSpace(approvalPin))
                throw new UnauthorizedAccessException("Clôture non autorisée pour cet utilisateur.");
            command.Parameters.AddWithValue("@role", role);
            command.Parameters.AddWithValue("@approval", approvalPin);
            if (Convert.ToInt64(Scalar(command,
                "SELECT COUNT(*) FROM TABLE_PASS WHERE BINARY Catégorie=BINARY @role AND BINARY ListPass=BINARY @approval")) != 1)
                throw new UnauthorizedAccessException("Code d’autorisation invalide.");
        }
        command.Parameters.Clear();
    }

    public string? RequiredApprovalRole(string cashier, string pin)
    {
        using var connection = Open();
        using var command = new MySqlCommand(
            "SELECT CLOTURE FROM TABLE_PASS WHERE BINARY ListUser=BINARY @cashier AND BINARY ListPass=BINARY @pin",
            connection);
        command.Parameters.AddWithValue("@cashier", cashier);
        command.Parameters.AddWithValue("@pin", pin);
        return Convert.ToString(command.ExecuteScalar()) switch
        {
            "ACCES MANAGER" => "MANAGER",
            "ACCES ADMIN" => "ADMIN",
            _ => null
        };
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

    private static Summary Read(MySqlConnection connection, MySqlTransaction transaction, string cashier, string pin, bool cashierOnly, string? approvalPin)
    {
        using var command = new MySqlCommand("", connection, transaction);
        Authorize(command, cashier, pin, approvalPin);
        decimal Amount(string sql) => Convert.ToDecimal(Scalar(command, sql), CultureInfo.InvariantCulture);

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
        if (!cashierOnly && perCashier && Amount("SELECT COUNT(*) FROM TABLE_VENTES_JOURNAL WHERE CLOTURE_GLOBALE IS NULL AND CLOTURE_CAISSIER IS NULL") > 0)
            throw new InvalidOperationException("Clôturez d’abord les caissiers comme dans LOGICA.");

        var rawOpening = Setting("FONDS_CAISSE");
        if (!decimal.TryParse(rawOpening.Replace(',', '.'), NumberStyles.AllowDecimalPoint,
                CultureInfo.InvariantCulture, out var opening) || opening < 0)
            throw new InvalidOperationException("Fond de caisse invalide.");
        command.Parameters.AddWithValue("@cashier", cashier);
        var column = ClosingColumn(cashierOnly);
        long rows = 0;
        long previous = 0;
        foreach (var table in Tables)
        {
            rows += (long)Amount($"SELECT COUNT(*) FROM {table}{Scope(table, cashierOnly)}");
            previous = Math.Max(previous, (long)Amount($"SELECT COALESCE(MAX(CAST({column} AS UNSIGNED)), 0) FROM {table}{ActorScope(table, cashierOnly, " WHERE ")}"));
        }
        if (Amount($"SELECT COUNT(*) FROM TABLE_VENTES_JOURNAL{Scope("TABLE_VENTES_JOURNAL", cashierOnly)} AND DATES IS NOT NULL") == 0)
            throw new InvalidOperationException("Aucune vente ouverte à clôturer.");
        decimal Sum(string table, string column, string condition = "") =>
            Amount($"SELECT COALESCE(SUM({column}), 0) FROM {table}{Scope(table, cashierOnly)}{condition}");
        const string cash = " AND MODE_P = 'ESPECES'";
        return new Summary(checked(previous + 1), rows, opening,
            Sum("TABLE_VENTES_REGLEMENTS", "MONTANT", cash),
            Sum("TABLE_CLIENTS_REGLE", "MONTANT", cash),
            Sum("TABLE_FOURNISSEURS_REGLE", "MONTANT", cash),
            Sum("TABLE_DEPENSES", "MONTANT"),
            Sum("TABLE_VENTES_JOURNAL", "TOTAL_NET", " AND OPERATION IN ('VENTE','RETOUR REMBOURSEMENT')"), cashierOnly);
    }
    private static string ClosingColumn(bool cashierOnly) =>
        cashierOnly ? "CLOTURE_CAISSIER" : "CLOTURE_GLOBALE";

    private static string Scope(string table, bool cashierOnly) =>
        $" WHERE {ClosingColumn(cashierOnly)} IS NULL{ActorScope(table, cashierOnly, " AND ")}";

    private static string ActorScope(string table, bool cashierOnly, string separator)
    {
        if (!cashierOnly) return "";
        var actor = table is "TABLE_DEPENSES" or "TABLE_CLIENTS_REGLE" or "TABLE_FOURNISSEURS_REGLE"
            ? "UTILISATEUR" : "CAISSIER";
        return $"{separator}BINARY {actor}=BINARY @cashier";
    }
}
