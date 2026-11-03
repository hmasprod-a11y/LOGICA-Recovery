// Real production ReceiptValidationClaim against a fresh disposable InnoDB schema.
// This is a transaction-contract regression, NOT evidence that legacy Form_6 is wired.
// Never connect to a shop database. Requires loopback logica_ci:3307 fixture.
using System;
using System.Data;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

internal static class ReceiptClaimMariaDbSmoke
{
    private static void Require(bool condition, string message)
    {
        if (!condition) throw new InvalidOperationException(message);
    }

    private static void Execute(MySqlConnection connection, MySqlTransaction transaction,
        string sql, params object[] parameters)
    {
        using (var command = new MySqlCommand(sql, connection, transaction))
        {
            for (int i = 0; i < parameters.Length; i += 2)
                command.Parameters.AddWithValue((string)parameters[i], parameters[i + 1]);
            command.ExecuteNonQuery();
        }
    }

    private static object Scalar(MySqlConnection connection, string sql)
    {
        using (var command = new MySqlCommand(sql, connection))
            return command.ExecuteScalar();
    }

    private static bool Claim(MethodInfo method, MySqlConnection connection,
        MySqlTransaction transaction, string receiptId)
    {
        try
        {
            return (bool)method.Invoke(null, new object[] { connection, transaction, receiptId });
        }
        catch (TargetInvocationException ex)
        {
            throw ex.InnerException ?? ex;
        }
    }

    private static void Post(MySqlConnection connection, MySqlTransaction transaction,
        string receiptId, string articleId, decimal quantity)
    {
        using (var update = new MySqlCommand(
            "UPDATE TABLE_ARTICLES SET STOCK = STOCK + @quantity WHERE ID_ARTICLE = @articleId",
            connection, transaction))
        {
            update.Parameters.AddWithValue("@quantity", quantity);
            update.Parameters.AddWithValue("@articleId", articleId);
            Require(update.ExecuteNonQuery() == 1, "Expected exactly one article stock update");
        }
        Execute(connection, transaction,
            "INSERT INTO TABLE_MOUVEMENTS_STOCK (ID_BR, ID_ARTICLE, QUANTITE) " +
            "VALUES (@receiptId, @articleId, @quantity)",
            "@receiptId", receiptId, "@articleId", articleId, "@quantity", quantity);
    }

    private static void Check(MySqlConnectionStringBuilder settings, string receiptId,
        string articleId, decimal stock, int movements, string state)
    {
        using (var connection = new MySqlConnection(settings.ConnectionString))
        {
            connection.Open();
            using (var command = new MySqlCommand(
                "SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE = @articleId", connection))
            {
                command.Parameters.AddWithValue("@articleId", articleId);
                Require(Convert.ToDecimal(command.ExecuteScalar(), CultureInfo.InvariantCulture) == stock,
                    "Unexpected stock for " + articleId);
            }
            using (var command = new MySqlCommand(
                "SELECT COUNT(*) FROM TABLE_MOUVEMENTS_STOCK WHERE ID_BR = @receiptId", connection))
            {
                command.Parameters.AddWithValue("@receiptId", receiptId);
                Require(Convert.ToInt32(command.ExecuteScalar(), CultureInfo.InvariantCulture) == movements,
                    "Movement was missing or duplicated for " + receiptId);
            }
            using (var command = new MySqlCommand(
                "SELECT ETAT FROM TABLE_RECEPTIONS_ENTETE WHERE ID_BR = @receiptId", connection))
            {
                command.Parameters.AddWithValue("@receiptId", receiptId);
                Require(Convert.ToString(command.ExecuteScalar()) == state,
                    "Unexpected receipt state for " + receiptId);
            }
        }
    }

    private static void Seed(MySqlConnection connection, string receiptId, string articleId,
        string state = "ENREGISTRER", bool withDetails = true)
    {
        Execute(connection, null,
            "INSERT INTO TABLE_RECEPTIONS_ENTETE (ID_BR, ETAT) VALUES (@id, @state)",
            "@id", receiptId, "@state", state);
        Execute(connection, null,
            "INSERT INTO TABLE_ARTICLES (ID_ARTICLE, STOCK) VALUES (@id, 0)",
            "@id", articleId);
        if (withDetails)
            Execute(connection, null,
                "INSERT INTO TABLE_RECEPTIONS_DETAILS (ID_BR) VALUES (@id)",
                "@id", receiptId);
    }

    private static void Verify(MethodInfo method, MySqlConnectionStringBuilder scratch)
    {
        using (var connection = new MySqlConnection(scratch.ConnectionString))
        {
            connection.Open();
            Execute(connection, null,
                "CREATE TABLE TABLE_RECEPTIONS_ENTETE (" +
                "ID BIGINT NOT NULL AUTO_INCREMENT PRIMARY KEY, " +
                "ID_BR VARCHAR(96) NOT NULL, ETAT VARCHAR(32) NOT NULL, " +
                "UNIQUE KEY uq_receipt (ID_BR)) ENGINE=InnoDB");
            Execute(connection, null,
                "CREATE TABLE TABLE_RECEPTIONS_DETAILS (" +
                "SEQ BIGINT AUTO_INCREMENT PRIMARY KEY, ID_BR VARCHAR(96), " +
                "ETAT VARCHAR(32) NULL DEFAULT 'ENREGISTRER') ENGINE=InnoDB");
            Execute(connection, null,
                "CREATE TABLE TABLE_ARTICLES (ID_ARTICLE VARCHAR(96) PRIMARY KEY, " +
                "STOCK DECIMAL(18,3) NOT NULL) ENGINE=InnoDB");
            Execute(connection, null,
                "CREATE TABLE TABLE_MOUVEMENTS_STOCK (SEQ BIGINT AUTO_INCREMENT PRIMARY KEY, " +
                "ID_BR VARCHAR(96), ID_ARTICLE VARCHAR(96), QUANTITE DECIMAL(18,3)) ENGINE=InnoDB");
            Seed(connection, "BR'1", "ART-1");
            Seed(connection, "BR-2", "ART-2");
            Seed(connection, "BR-3", "ART-3");
            Seed(connection, "BR-CANCEL", "ART-CANCEL", "ANNULE");
            Seed(connection, "BR-DRAFT", "ART-DRAFT", "EN COURS");
            Seed(connection, "BR-UNKNOWN", "ART-UNKNOWN", "OTHER");
            Seed(connection, "BR-EMPTY", "ART-EMPTY", "ENREGISTRER", false);
            Seed(connection, "BR-LOCK", "ART-LOCK");
            Seed(connection, "BR-DETAIL-CANCEL", "ART-DETAIL-CANCEL");
            Seed(connection, "BR-DETAIL-VALID", "ART-DETAIL-VALID");
            Seed(connection, "BR-DETAIL-NULL", "ART-DETAIL-NULL");
            Seed(connection, "BR-DETAIL-MIX", "ART-DETAIL-MIX");
            Execute(connection, null,
                "UPDATE TABLE_RECEPTIONS_DETAILS SET ETAT = 'ANNULE' WHERE ID_BR = @id",
                "@id", "BR-DETAIL-CANCEL");
            Execute(connection, null,
                "UPDATE TABLE_RECEPTIONS_DETAILS SET ETAT = 'VALIDER' WHERE ID_BR = @id",
                "@id", "BR-DETAIL-VALID");
            Execute(connection, null,
                "UPDATE TABLE_RECEPTIONS_DETAILS SET ETAT = NULL WHERE ID_BR = @id",
                "@id", "BR-DETAIL-NULL");
            Execute(connection, null,
                "INSERT INTO TABLE_RECEPTIONS_DETAILS (ID_BR, ETAT) VALUES (@id, 'ANNULE')",
                "@id", "BR-DETAIL-MIX");

            using (var transaction = connection.BeginTransaction())
            {
                Require(Claim(method, connection, transaction, "BR'1"),
                    "Quoted receipt should claim exactly once");
                Post(connection, transaction, "BR'1", "ART-1", 2.500m);
                transaction.Commit();
            }
            using (var transaction = connection.BeginTransaction())
            {
                Require(!Claim(method, connection, transaction, "BR'1"),
                    "Second attempt must not reapply an already committed receipt");
                transaction.Rollback();
            }
            Check(scratch, "BR'1", "ART-1", 2.500m, 1, "VALIDER");

            // Two distinct database connections: the second must wait for the
            // first transaction's header lock, then refuse the already posted ID.
            using (var first = connection.BeginTransaction())
            {
                Require(Claim(method, connection, first, "BR-2"), "First concurrent claim failed");
                Post(connection, first, "BR-2", "ART-2", 7m);
                using (var started = new ManualResetEventSlim(false))
                {
                    Task<bool> contender = Task.Factory.StartNew(delegate
                    {
                        using (var secondConnection = new MySqlConnection(scratch.ConnectionString))
                        {
                            secondConnection.Open();
                            using (var second = secondConnection.BeginTransaction())
                            {
                                started.Set();
                                bool claimed = Claim(method, secondConnection, second, "BR-2");
                                if (claimed) Post(secondConnection, second, "BR-2", "ART-2", 7m);
                                second.Commit();
                                return claimed;
                            }
                        }
                    });
                    Require(started.Wait(TimeSpan.FromSeconds(5)), "Second connection did not start");
                    Thread.Sleep(300);
                    Require(!contender.IsCompleted, "Second client bypassed the uncommitted receipt claim");
                    first.Commit();
                    Require(contender.Wait(TimeSpan.FromSeconds(15)), "Second client remained blocked");
                    Require(!contender.Result, "Second client claimed the same receipt");
                }
            }
            Check(scratch, "BR-2", "ART-2", 7m, 1, "VALIDER");

            // The claim must lock persisted receipt details, not merely read
            // their existence. A second client cannot delete a detail while
            // the first claim transaction remains uncommitted.
            using (var first = connection.BeginTransaction())
            {
                Require(Claim(method, connection, first, "BR-LOCK"),
                    "Detail-lock fixture claim failed");
                using (var started = new ManualResetEventSlim(false))
                {
                    Task<bool> deletion = Task.Factory.StartNew(delegate
                    {
                        using (var secondConnection = new MySqlConnection(scratch.ConnectionString))
                        {
                            secondConnection.Open();
                            using (var second = secondConnection.BeginTransaction())
                            {
                                started.Set();
                                Execute(secondConnection, second,
                                    "DELETE FROM TABLE_RECEPTIONS_DETAILS WHERE ID_BR = @id",
                                    "@id", "BR-LOCK");
                                second.Rollback();
                                return true;
                            }
                        }
                    });
                    Require(started.Wait(TimeSpan.FromSeconds(5)),
                        "Detail deletion contender did not start");
                    Thread.Sleep(300);
                    Require(!deletion.IsCompleted,
                        "Concurrent detail deletion bypassed receipt claim lock");
                    first.Rollback();
                    Require(deletion.Wait(TimeSpan.FromSeconds(15)),
                        "Detail deletion contender remained blocked after rollback");
                    Require(deletion.Result, "Detail deletion contender failed");
                }
            }
            Check(scratch, "BR-LOCK", "ART-LOCK", 0m, 0, "ENREGISTRER");
            Require(Convert.ToInt32(Scalar(connection,
                "SELECT COUNT(*) FROM TABLE_RECEPTIONS_DETAILS WHERE ID_BR = 'BR-LOCK'"),
                CultureInfo.InvariantCulture) == 1,
                "Detail row was lost after both concurrent transactions rolled back");

            // A second editor must not flip a persisted detail's ETAT after
            // the first transaction has locked/validated all receipt lines.
            using (var first = connection.BeginTransaction())
            {
                Require(Claim(method, connection, first, "BR-LOCK"),
                    "Detail-state lock fixture claim failed");
                using (var started = new ManualResetEventSlim(false))
                {
                    Task<bool> edit = Task.Factory.StartNew(delegate
                    {
                        using (var secondConnection = new MySqlConnection(scratch.ConnectionString))
                        {
                            secondConnection.Open();
                            using (var second = secondConnection.BeginTransaction())
                            {
                                started.Set();
                                Execute(secondConnection, second,
                                    "UPDATE TABLE_RECEPTIONS_DETAILS SET ETAT = 'ANNULE' WHERE ID_BR = @id",
                                    "@id", "BR-LOCK");
                                second.Rollback();
                                return true;
                            }
                        }
                    });
                    Require(started.Wait(TimeSpan.FromSeconds(5)),
                        "Concurrent detail state editor did not start");
                    Thread.Sleep(300);
                    Require(!edit.IsCompleted,
                        "Concurrent detail state change bypassed receipt claim lock");
                    first.Rollback();
                    Require(edit.Wait(TimeSpan.FromSeconds(15)),
                        "Concurrent detail state editor remained blocked after rollback");
                    Require(edit.Result, "Concurrent detail state editor failed");
                }
            }
            Check(scratch, "BR-LOCK", "ART-LOCK", 0m, 0, "ENREGISTRER");
            Require(Convert.ToString(Scalar(connection,
                "SELECT ETAT FROM TABLE_RECEPTIONS_DETAILS WHERE ID_BR = 'BR-LOCK'")) == "ENREGISTRER",
                "Concurrent detail state editor changed the persisted line");

            // Inject failure after header claim and stock mutation. Rollback must
            // restore header, stock and movements together, allowing one retry.
            using (var transaction = connection.BeginTransaction())
            {
                Require(Claim(method, connection, transaction, "BR-3"), "Rollback fixture claim failed");
                Post(connection, transaction, "BR-3", "ART-3", 4m);
                transaction.Rollback();
            }
            Check(scratch, "BR-3", "ART-3", 0m, 0, "ENREGISTRER");
            using (var transaction = connection.BeginTransaction())
            {
                Require(Claim(method, connection, transaction, "BR-3"), "Retry after rollback failed");
                Post(connection, transaction, "BR-3", "ART-3", 4m);
                transaction.Commit();
            }
            Check(scratch, "BR-3", "ART-3", 4m, 1, "VALIDER");

            using (var transaction = connection.BeginTransaction())
            {
                Require(!Claim(method, connection, transaction, "MISSING"), "Missing receipt claimed");
                bool rejected = false;
                try { Claim(method, connection, transaction, "  "); }
                catch (ArgumentException) { rejected = true; }
                Require(rejected, "Blank receipt ID was not rejected");
                transaction.Rollback();
            }

            // An orphan header is not a valid receipt. Do not mark it validated
            // or alter stock when persisted receipt details are missing.
            using (var transaction = connection.BeginTransaction())
            {
                bool rejected = false;
                try { Claim(method, connection, transaction, "BR-EMPTY"); }
                catch (InvalidOperationException) { rejected = true; }
                Require(rejected, "Header-only receipt was accepted without persisted details");
                transaction.Rollback();
            }
            Check(scratch, "BR-EMPTY", "ART-EMPTY", 0m, 0, "ENREGISTRER");
            // A later legitimate receipt edit can add details and retry. The
            // earlier rejection must not poison the receipt's persisted state.
            Execute(connection, null,
                "INSERT INTO TABLE_RECEPTIONS_DETAILS (ID_BR) VALUES (@id)",
                "@id", "BR-EMPTY");
            using (var transaction = connection.BeginTransaction())
            {
                Require(Claim(method, connection, transaction, "BR-EMPTY"),
                    "Receipt with newly persisted detail could not retry");
                Post(connection, transaction, "BR-EMPTY", "ART-EMPTY", 1.250m);
                transaction.Commit();
            }
            Check(scratch, "BR-EMPTY", "ART-EMPTY", 1.250m, 1, "VALIDER");

            // Only the actual legacy pending state ENREGISTRER may post stock.
            // Cancelled/draft/unknown receipts must remain unchanged even if
            // a caller erroneously attempts to validate them.
            string[] blocked = { "BR-CANCEL", "BR-DRAFT", "BR-UNKNOWN" };
            string[] blockedArticles = { "ART-CANCEL", "ART-DRAFT", "ART-UNKNOWN" };
            string[] blockedStates = { "ANNULE", "EN COURS", "OTHER" };
            for (int i = 0; i < blocked.Length; i++)
            {
                using (var transaction = connection.BeginTransaction())
                {
                    bool rejected = false;
                    try { Claim(method, connection, transaction, blocked[i]); }
                    catch (InvalidOperationException) { rejected = true; }
                    Require(rejected, "Unsafe receipt state was accepted: " + blockedStates[i]);
                    transaction.Rollback();
                }
                Check(scratch, blocked[i], blockedArticles[i], 0m, 0, blockedStates[i]);
            }

            // Header state alone is insufficient: persisted lines may have
            // been cancelled, already validated, corrupted or mixed. A claim
            // must reject all such cases without changing header/stock/movement.
            string[] invalidDetails = {
                "BR-DETAIL-CANCEL", "BR-DETAIL-VALID",
                "BR-DETAIL-NULL", "BR-DETAIL-MIX"
            };
            string[] invalidDetailArticles = {
                "ART-DETAIL-CANCEL", "ART-DETAIL-VALID",
                "ART-DETAIL-NULL", "ART-DETAIL-MIX"
            };
            for (int i = 0; i < invalidDetails.Length; i++)
            {
                using (var transaction = connection.BeginTransaction())
                {
                    bool rejected = false;
                    try { Claim(method, connection, transaction, invalidDetails[i]); }
                    catch (InvalidOperationException) { rejected = true; }
                    Require(rejected, "Unsafe persisted receipt detail state accepted: " + invalidDetails[i]);
                    transaction.Rollback();
                }
                Check(scratch, invalidDetails[i], invalidDetailArticles[i],
                    0m, 0, "ENREGISTRER");
            }
            // After an authorized editor repairs the persisted detail state,
            // the same receipt must be claimable exactly once, not poisoned.
            Execute(connection, null,
                "UPDATE TABLE_RECEPTIONS_DETAILS SET ETAT = 'ENREGISTRER' WHERE ID_BR = @id",
                "@id", "BR-DETAIL-MIX");
            using (var transaction = connection.BeginTransaction())
            {
                Require(Claim(method, connection, transaction, "BR-DETAIL-MIX"),
                    "Repaired persisted receipt detail states could not retry");
                Post(connection, transaction, "BR-DETAIL-MIX", "ART-DETAIL-MIX", 3.125m);
                transaction.Commit();
            }
            Check(scratch, "BR-DETAIL-MIX", "ART-DETAIL-MIX",
                3.125m, 1, "VALIDER");

            // Nontransactional legacy tables cannot guarantee rollback.
            // Reject them before any receipt header or stock write.
            string[] protectedTables = {
                "TABLE_RECEPTIONS_ENTETE", "TABLE_RECEPTIONS_DETAILS",
                "TABLE_ARTICLES", "TABLE_MOUVEMENTS_STOCK"
            };
            foreach (string tableName in protectedTables)
            {
                // Identifiers come exclusively from this fixed in-source list.
                Execute(connection, null, "ALTER TABLE " + tableName + " ENGINE=MyISAM");
                using (var transaction = connection.BeginTransaction())
                {
                    bool rejected = false;
                    try { Claim(method, connection, transaction, "BR-3"); }
                    catch (InvalidOperationException) { rejected = true; }
                    Require(rejected, "Nontransactional table was accepted: " + tableName);
                    transaction.Rollback();
                }
                Execute(connection, null, "ALTER TABLE " + tableName + " ENGINE=InnoDB");
            }
            Check(scratch, "BR-3", "ART-3", 4m, 1, "VALIDER");

            // A UNIQUE(ID_BR, ETAT) composite index is not a unique receipt ID.
            // This scratch-only fixture must fail closed even without duplicates.
            Execute(connection, null, "ALTER TABLE TABLE_RECEPTIONS_ENTETE DROP INDEX uq_receipt");
            Execute(connection, null,
                "ALTER TABLE TABLE_RECEPTIONS_ENTETE ADD UNIQUE KEY uq_composite (ID_BR, ETAT)");
            using (var transaction = connection.BeginTransaction())
            {
                bool rejected = false;
                try { Claim(method, connection, transaction, "BR-3"); }
                catch (InvalidOperationException) { rejected = true; }
                Require(rejected, "Composite receipt index incorrectly accepted as unique ID_BR");
                transaction.Rollback();
            }
            Execute(connection, null, "ALTER TABLE TABLE_RECEPTIONS_ENTETE DROP INDEX uq_composite");

            // Deliberately insert duplicate headers in SCRATCH ONLY to ensure
            // the helper fails closed instead of posting stock.
            Execute(connection, null,
                "INSERT INTO TABLE_RECEPTIONS_ENTETE (ID_BR, ETAT) VALUES ('BR-DUP','EN_COURS'),('BR-DUP','EN_COURS')");
            using (var transaction = connection.BeginTransaction())
            {
                bool rejected = false;
                try { Claim(method, connection, transaction, "BR-DUP"); }
                catch (InvalidOperationException) { rejected = true; }
                Require(rejected, "Duplicate receipt header was accepted");
                transaction.Rollback();
            }
            Console.WriteLine("PASS receipt claim: quoted IDs, exact-once, two connections, detail row locks, rollback/retry, blocked header/detail states, mixed detail recovery, orphan header/recovery, invalid/duplicate headers, composite index, four MyISAM table rejections");
        }
    }

    [STAThread]
    private static int Main()
    {
        MySqlConnection administration = null;
        string scratchName = "logica_ci_receipt_" + Guid.NewGuid().ToString("N").Substring(0, 12);
        bool created = false;
        try
        {
            Assembly assembly = Assembly.LoadFrom(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "LOGICA.exe"));
            Type module = assembly.GetType("LOGICA.Module1", true);
            var configured = (MySqlConnection)module.GetField("cn_SQL",
                BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static).GetValue(null);
            var original = new MySqlConnectionStringBuilder();
            original.ConnectionString = configured.ConnectionString;
            Require((String.Equals(original.Server, "127.0.0.1", StringComparison.OrdinalIgnoreCase) ||
                String.Equals(original.Server, "localhost", StringComparison.OrdinalIgnoreCase)) &&
                String.Equals(original.Database, "logica_ci", StringComparison.OrdinalIgnoreCase) &&
                original.Port == 3307, "Refusing non-disposable/non-loopback/non-CI MariaDB");
            administration = new MySqlConnection(original.ConnectionString);
            administration.Open();
            Execute(administration, null, "CREATE DATABASE `" + scratchName + "` CHARACTER SET utf8mb4");
            created = true;
            var scratch = new MySqlConnectionStringBuilder();
            scratch.ConnectionString = original.ConnectionString;
            scratch.Database = scratchName;
            Type helper = assembly.GetType("LOGICA.Infrastructure.Purchasing.ReceiptValidationClaim", true);
            MethodInfo method = helper.GetMethod("TryClaim",
                BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static);
            Require(method != null, "Production receipt claim method not found");
            Verify(method, scratch);
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
                        Execute(administration, null, "DROP DATABASE `" + scratchName + "`");
                    }
                }
                catch (Exception cleanup)
                {
                    throw new InvalidOperationException("Disposable receipt schema cleanup failed", cleanup);
                }
                finally { administration.Dispose(); }
            }
        }
    }
}
