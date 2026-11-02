// Isolated production-method smoke for CatalogueCreationMovementWriter.
// Never touches an existing TABLE_ARTICLES or TABLE_MOUVEMENTS_STOCK.
// Requires a loopback logica_ci test account allowed to CREATE/DROP its own scratch schema.
using System;
using System.Data;
using System.Data.Common;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;

internal static class CatalogueCreationMariaDbSmoke
{
    private const BindingFlags Flags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static;
    private static void Require(bool condition, string message)
    {
        if (!condition) throw new InvalidOperationException(message);
    }

    private static void Execute(DbConnection connection, string sql)
    {
        using (DbCommand command = connection.CreateCommand())
        {
            command.CommandText = sql;
            command.ExecuteNonQuery();
        }
    }

    private static DbConnection NewConnection(Type connectionType, string connectionString)
    {
        return (DbConnection)Activator.CreateInstance(connectionType, new object[] { connectionString });
    }

    private static string WithDatabase(Type connectionType, string original, string database)
    {
        Type builderType = connectionType.Assembly.GetType("MySql.Data.MySqlClient.MySqlConnectionStringBuilder", true);
        // Recovered MySql.Data exposes a parameterless builder, not a string constructor.
        // Parsing via the base class preserves strict target validation on x86.
        DbConnectionStringBuilder builder = (DbConnectionStringBuilder)Activator.CreateInstance(builderType);
        builder.ConnectionString = original;
        builderType.GetProperty("Database").SetValue(builder, database, null);
        // Module1 defaults to CharacterSet=utf8 for normal offline shops. The CI
        // connection-string override omits it; preserve Arabic text in this
        // disposable scratch test by mirroring the production default.
        builderType.GetProperty("CharacterSet").SetValue(builder, "utf8", null);
        return builder.ToString();
    }

    private static void CheckRow(DbConnection connection, int index, string id, string code,
        string article, decimal quantity)
    {
        connection.Open();
        try
        {
            using (DbCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT DATES, HEURE, LIBELLE, ID_ARTICLE, CODE_ARTICLE, ARTICLE, QUANTITE " +
                    "FROM TABLE_MOUVEMENTS_STOCK ORDER BY SEQ LIMIT 1 OFFSET " +
                    index.ToString(CultureInfo.InvariantCulture);
                using (DbDataReader reader = command.ExecuteReader())
                {
                    Require(reader.Read(), "Missing movement row " + index);
                    Require(Regex.IsMatch(Convert.ToString(reader.GetValue(0)), @"^\d{4}-\d{2}-\d{2}$"),
                        "Date format changed");
                    Require(Regex.IsMatch(Convert.ToString(reader.GetValue(1)), @"^\d{2}:\d{2}:\d{2}$"),
                        "Time format changed");
                    Require(Convert.ToString(reader.GetValue(2)) == "Création d'article", "Movement label changed");
                    Require(Convert.ToString(reader.GetValue(3)) == id, "Wrong article ID");
                    Require(Convert.ToString(reader.GetValue(4)) == code, "Barcode was changed or interpreted as SQL");
                    Require(Convert.ToString(reader.GetValue(5)) == article, "Article name was changed");
                    Require(Convert.ToDecimal(reader.GetValue(6), CultureInfo.InvariantCulture) == quantity,
                        "Signed/fractional stock quantity changed");
                    Require(!reader.Read(), "Unexpected duplicate movement");
                }
            }
        }
        finally { connection.Close(); }
        Console.WriteLine("PASS production creation movement row " + index);
    }

    private static void Write(Type writer, DbConnection connection, string id, string code,
        string article, string stock)
    {
        MethodInfo method = writer.GetMethod("Write", Flags);
        Require(method != null, "Missing production CatalogueCreationMovementWriter.Write");
        int callbacks = 0;
        Func<string> readCode = delegate { Require(++callbacks == 1, "Code read order changed"); return code; };
        Func<string> readArticle = delegate { Require(++callbacks == 2, "Article read order changed"); return article; };
        Func<string> readStock = delegate { Require(++callbacks == 3, "Stock read order changed"); return stock; };
        method.Invoke(null, new object[] { id, readCode, readArticle, readStock, connection });
        Require(callbacks == 3, "Not all original form callbacks were evaluated");
        Require(connection.State == ConnectionState.Closed, "Original writer success-close behavior changed");
    }

    private static int Count(DbConnection connection)
    {
        connection.Open();
        try
        {
            using (DbCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT COUNT(*) FROM TABLE_MOUVEMENTS_STOCK";
                return Convert.ToInt32(command.ExecuteScalar(), CultureInfo.InvariantCulture);
            }
        }
        finally { connection.Close(); }
    }

    [STAThread]
    private static int Main()
    {
        DbConnection administration = null;
        string scratch = "logica_ci_catalogue_" + Guid.NewGuid().ToString("N").Substring(0, 12);
        bool created = false;
        try
        {
            Assembly assembly = Assembly.LoadFrom(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "LOGICA.exe"));
            Type module = assembly.GetType("LOGICA.Module1", true);
            DbConnection configured = (DbConnection)module.GetField("cn_SQL", Flags).GetValue(null);
            string original = configured.ConnectionString;
            Type connectionType = configured.GetType();
            Type builderType = connectionType.Assembly.GetType("MySql.Data.MySqlClient.MySqlConnectionStringBuilder", true);
            // Recovered MySql.Data exposes a parameterless builder, not a string constructor.
            // Parsing via the base class preserves strict target validation on x86.
            DbConnectionStringBuilder builder = (DbConnectionStringBuilder)Activator.CreateInstance(builderType);
            builder.ConnectionString = original;
            string server = Convert.ToString(builderType.GetProperty("Server").GetValue(builder, null));
            string database = Convert.ToString(builderType.GetProperty("Database").GetValue(builder, null));
            uint port = Convert.ToUInt32(builderType.GetProperty("Port").GetValue(builder, null),
                CultureInfo.InvariantCulture);
            Require((string.Equals(server, "127.0.0.1", StringComparison.OrdinalIgnoreCase) ||
                string.Equals(server, "localhost", StringComparison.OrdinalIgnoreCase)) &&
                string.Equals(database, "logica_ci", StringComparison.OrdinalIgnoreCase) &&
                port == 3307,
                "Refusing non-loopback/non-disposable/non-CI-port MariaDB connection");
            administration = NewConnection(connectionType, original);
            administration.Open();
            // New, random scratch database; CREATE without IF NOT EXISTS fails closed on collision.
            Execute(administration, "CREATE DATABASE `" + scratch + "` CHARACTER SET utf8mb4");
            created = true;
            string scratchConnectionString = WithDatabase(connectionType, original, scratch);
            using (DbConnection connection = NewConnection(connectionType, scratchConnectionString))
            {
                connection.Open();
                Execute(connection, "CREATE TABLE TABLE_MOUVEMENTS_STOCK (" +
                    "SEQ INT NOT NULL AUTO_INCREMENT PRIMARY KEY, DATES VARCHAR(16), HEURE VARCHAR(16), " +
                    "LIBELLE VARCHAR(128), ID_ARTICLE VARCHAR(128), CODE_ARTICLE VARCHAR(128), " +
                    "ARTICLE VARCHAR(255), QUANTITE DECIMAL(18,3))");
                connection.Close();
                Type writer = assembly.GetType("LOGICA.Infrastructure.Catalogue.CatalogueCreationMovementWriter", true);
                Write(writer, connection, "ART-1", "SKU'O-1", "L'eau d'orange", "12.500");
                Require(Count(connection) == 1, "First create movement was not exactly once");
                CheckRow(connection, 0, "ART-1", "SKU'O-1", "L'eau d'orange", 12.500m);
                Write(writer, connection, "ART-2", "", "منتوج بدون باركود", "0");
                Require(Count(connection) == 2, "Image-only article movement lost");
                CheckRow(connection, 1, "ART-2", "", "منتوج بدون باركود", 0m);
                Write(writer, connection, "ART-3", "' OR 1=1 --", "x'); DROP TABLE TABLE_MOUVEMENTS_STOCK; --", "-2.750");
                Require(Count(connection) == 3, "Quoted text changed movement count");
                CheckRow(connection, 2, "ART-3", "' OR 1=1 --",
                    "x'); DROP TABLE TABLE_MOUVEMENTS_STOCK; --", -2.750m);

                // Failed callback must not insert a movement. The legacy failure path
                // leaves the connection open; the harness closes it, without changing production.
                MethodInfo method = writer.GetMethod("Write", Flags);
                Func<string> readCode = delegate { return "FAILED"; };
                Func<string> throwArticle = delegate { throw new InvalidOperationException("Injected form read failure"); };
                Func<string> readStock = delegate { return "1"; };
                bool rejected = false;
                try { method.Invoke(null, new object[] { "ART-FAIL", readCode, throwArticle, readStock, connection }); }
                catch (TargetInvocationException ex) { rejected = ex.InnerException is InvalidOperationException; }
                Require(rejected, "Injected callback failure not propagated");
                if (connection.State == ConnectionState.Open) connection.Close();
                Require(Count(connection) == 3, "Failed callback persisted a movement");
                Write(writer, connection, "ART-4", "RETRY", "Successful retry", "3.125");
                Require(Count(connection) == 4, "Retry inserted zero or duplicate movements");
                CheckRow(connection, 3, "ART-4", "RETRY", "Successful retry", 3.125m);
            }
            Console.WriteLine("PASS production CatalogueCreationMovementWriter: 4 exact rows, quoted/Arabic/blank/signed quantities, failure and retry");
            return 0;
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine(ex);
            return 1;
        }
        finally
        {
            if (administration != null)
            {
                try
                {
                    if (created)
                    {
                        if (administration.State != ConnectionState.Open) administration.Open();
                        Execute(administration, "DROP DATABASE `" + scratch + "`");
                    }
                }
                catch (Exception cleanup) { throw new InvalidOperationException("Scratch schema cleanup failed", cleanup); }
                finally { administration.Dispose(); }
            }
        }
    }
}
