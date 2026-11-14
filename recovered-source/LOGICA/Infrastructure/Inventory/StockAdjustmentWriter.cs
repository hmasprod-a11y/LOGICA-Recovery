using System;
using System.Data;
using System.Globalization;
using System.Text;
using MySql.Data.MySqlClient;
using LOGICA.Application.Inventory;

namespace LOGICA.Infrastructure.Inventory
{
    // Opt-in persisted permission contract. These tables must be provisioned by
    // an approved installer; the writer never creates or migrates shop schema.
    // The session token is a bearer secret, not a user name or ADMIN label.
    internal sealed class MariaDbManualStockAuthorization : IManualStockAuthorization
    {
        public VerifiedManualStockActor VerifyForWrite(object connection, object transaction,
            string authenticatedSessionId, string requestedUserId)
        {
            var db = connection as MySqlConnection;
            var tx = transaction as MySqlTransaction;
            if (db == null || tx == null || String.IsNullOrWhiteSpace(authenticatedSessionId) ||
                String.IsNullOrWhiteSpace(requestedUserId))
                throw new UnauthorizedAccessException("Authenticated inventory session required.");
            // Reject malformed bearer credentials before issuing a database query.
            // A UI-supplied actor label is never a substitute for a session secret.
            if (authenticatedSessionId.Length > 128 || requestedUserId.Length > 128 ||
                authenticatedSessionId != authenticatedSessionId.Trim() ||
                requestedUserId != requestedUserId.Trim())
                throw new UnauthorizedAccessException("Invalid inventory session or actor identity.");
            foreach (char c in authenticatedSessionId)
                if (Char.IsControl(c))
                    throw new UnauthorizedAccessException("Invalid inventory session credential.");
            foreach (char c in requestedUserId)
                if (Char.IsControl(c))
                    throw new UnauthorizedAccessException("Invalid inventory actor identity.");
            if (db.State != ConnectionState.Open || !Object.ReferenceEquals(tx.Connection, db))
                throw new UnauthorizedAccessException("Authorization requires the same open transaction.");
            if (!String.Equals(db.DataSource, "127.0.0.1", StringComparison.OrdinalIgnoreCase) &&
                !String.Equals(db.DataSource, "localhost", StringComparison.OrdinalIgnoreCase) &&
                !String.Equals(db.DataSource, "::1", StringComparison.OrdinalIgnoreCase))
                throw new UnauthorizedAccessException("Authorization requires local MariaDB.");
            using (var active = new MySqlCommand("SELECT @@in_transaction", db, tx))
            {
                if (Convert.ToInt32(active.ExecuteScalar(), CultureInfo.InvariantCulture) != 1)
                    throw new UnauthorizedAccessException("Authorization requires an active transaction.");
            }
            // FOR UPDATE must hold session/grant locks until stock+audit finish.
            // Nontransactional grant tables cannot provide that guarantee.
            using (var schema = new MySqlCommand(
                "SELECT TABLE_NAME, ENGINE FROM information_schema.TABLES " +
                "WHERE TABLE_SCHEMA=DATABASE() AND TABLE_NAME IN " +
                "('HANOUTY_AUTH_SESSIONS','HANOUTY_ACTOR_GRANTS')", db, tx))
            using (var reader = schema.ExecuteReader())
            {
                int count = 0;
                while (reader.Read())
                {
                    if (!String.Equals(Convert.ToString(reader.GetValue(1)), "InnoDB",
                        StringComparison.OrdinalIgnoreCase))
                        throw new UnauthorizedAccessException("Authorization storage requires InnoDB.");
                    count++;
                }
                if (count != 2)
                    throw new UnauthorizedAccessException("Authorization storage is not configured.");
            }
            // Both rows are locked in the caller's stock transaction. Revocation
            // and expiry are checked on the database clock, never on WPF state.
            VerifiedManualStockActor verified;
            using (var command = new MySqlCommand(
                "SELECT s.ACTOR_ID FROM HANOUTY_AUTH_SESSIONS s " +
                "INNER JOIN HANOUTY_ACTOR_GRANTS g ON BINARY g.ACTOR_ID=BINARY s.ACTOR_ID " +
                "WHERE BINARY s.SESSION_TOKEN=BINARY @token " +
                "AND BINARY s.ACTOR_ID=BINARY @actor " +
                "AND s.REVOKED_AT IS NULL AND s.EXPIRES_AT>UTC_TIMESTAMP() " +
                "AND BINARY g.PERMISSION_CODE=BINARY 'ManualStockAdjustment' " +
                "AND g.REVOKED_AT IS NULL AND (g.EXPIRES_AT IS NULL OR g.EXPIRES_AT>UTC_TIMESTAMP()) " +
                "FOR UPDATE", db, tx))
            {
                command.Parameters.AddWithValue("@token", authenticatedSessionId);
                command.Parameters.AddWithValue("@actor", requestedUserId);
                using (var reader = command.ExecuteReader())
                {
                    if (!reader.Read() || reader.IsDBNull(0))
                        throw new UnauthorizedAccessException("Manual stock grant missing, revoked or expired.");
                    string actor = Convert.ToString(reader.GetValue(0), CultureInfo.InvariantCulture);
                    if (reader.Read())
                        throw new UnauthorizedAccessException("Ambiguous manual stock permission.");
                    verified = new VerifiedManualStockActor(actor);
                }
            }
            // A filtered join can hide another actor using the same token, or
            // another state of the same grant. Check full unique keys after
            // locking the rows, while this transaction holds table metadata locks.
            using (var keys = new MySqlCommand(
                "SELECT COUNT(DISTINCT authority_keys.TABLE_NAME) FROM (" +
                "SELECT TABLE_NAME, INDEX_NAME FROM information_schema.STATISTICS " +
                "WHERE TABLE_SCHEMA=DATABASE() AND NON_UNIQUE=0 " +
                "AND TABLE_NAME IN ('HANOUTY_AUTH_SESSIONS','HANOUTY_ACTOR_GRANTS') " +
                "GROUP BY TABLE_NAME,INDEX_NAME HAVING COUNT(SUB_PART)=0 AND (" +
                "(TABLE_NAME='HANOUTY_AUTH_SESSIONS' AND COUNT(*)=1 AND MAX(COLUMN_NAME)='SESSION_TOKEN') OR " +
                "(TABLE_NAME='HANOUTY_ACTOR_GRANTS' AND COUNT(*)=2 AND " +
                "SUM(CASE WHEN COLUMN_NAME='ACTOR_ID' THEN 1 ELSE 0 END)=1 AND " +
                "SUM(CASE WHEN COLUMN_NAME='PERMISSION_CODE' THEN 1 ELSE 0 END)=1))) authority_keys",
                db, tx))
            {
                if (Convert.ToInt32(keys.ExecuteScalar(), CultureInfo.InvariantCulture) != 2)
                    throw new UnauthorizedAccessException("Session tokens and actor grants require unique keys.");
            }
            return verified;
        }
    }

    // Opt-in writer. The caller owns Commit/Rollback and MUST NOT reuse a sale transaction.
    // Legacy WinForms is not yet wired to this entry point.
    internal static class StockAdjustmentWriter
    {
        // Fail closed at BOTH write entry points. No existing actor-scoped
        // ManualStockAdjustment grant has been wired/accepted. A user label,
        // ADMIN category or MODIF_QTE/global setting cannot mint that grant.
        // Keep the transaction implementation below for the future reviewed
        // integration, but it is deliberately unreachable through this API.
        private static void RequireVerifiedActorAuthorization()
        {
            throw new UnauthorizedAccessException(
                "Manual stock adjustment is disabled until verified actor-scoped authorization is configured.");
        }

        // Approved adapters must be wired by the trusted application composition root.
        // Never accept a grant supplied by a WPF command or from plan.UserId.
        // This gate is intentionally non-writing until a persisted actor-scoped
        // permission implementation is reviewed and configured.
        internal static VerifiedManualStockActor ValidateAuthorizationContext(MySqlConnection connection,
            MySqlTransaction transaction, StockAdjustmentPlan plan,
            IManualStockAuthorization authorization, string authenticatedSessionId)
        {
            if (connection == null || transaction == null || plan == null || authorization == null ||
                String.IsNullOrWhiteSpace(authenticatedSessionId))
                throw new UnauthorizedAccessException("Verified manual stock authorization context is required.");
            if (connection.State != ConnectionState.Open ||
                !Object.ReferenceEquals(transaction.Connection, connection))
                throw new UnauthorizedAccessException("Authorization must use the active stock transaction.");
            // Never disclose a session token or call a permission provider on a
            // remote/incorrect database endpoint. The grant and stock must share
            // the same verified local transaction.
            if (!String.Equals(connection.DataSource, "127.0.0.1", StringComparison.OrdinalIgnoreCase) &&
                !String.Equals(connection.DataSource, "localhost", StringComparison.OrdinalIgnoreCase) &&
                !String.Equals(connection.DataSource, "::1", StringComparison.OrdinalIgnoreCase))
                throw new UnauthorizedAccessException("Manual stock authorization requires local MariaDB.");
            // Connector/NET retains transaction.Connection after Commit/Dispose.
            // Reference equality alone therefore does not prove an active server transaction.
            // Read-only check; never begin/commit/repair a caller's transaction here.
            try
            {
                using (var active = new MySqlCommand("SELECT @@in_transaction", connection, transaction))
                {
                    if (Convert.ToInt32(active.ExecuteScalar(), CultureInfo.InvariantCulture) != 1)
                        throw new UnauthorizedAccessException("Authorization requires an active server transaction.");
                }
            }
            catch (InvalidOperationException)
            {
                // A completed/disposed Connector/NET transaction can retain a
                // Connection reference; never pass it to a permission provider.
                throw new UnauthorizedAccessException("Authorization requires an active server transaction.");
            }
            // Reject arbitrary caller-supplied adapters: a forged implementation
            // returning VerifiedManualStockActor is not permission provenance.
            if (authorization.GetType() != typeof(MariaDbManualStockAuthorization))
                throw new UnauthorizedAccessException("Only persisted MariaDB actor grants authorize stock writes.");
            VerifiedManualStockActor actor = authorization.VerifyForWrite(
                connection, transaction, authenticatedSessionId, plan.UserId);
            if (actor == null || !String.Equals(actor.UserId, plan.UserId, StringComparison.Ordinal))
                throw new UnauthorizedAccessException("Manual stock actor does not match the verified session.");
            // A provider must not commit or end the transaction while checking
            // the grant. The stock update and its audit require that same live
            // transaction, including any concurrent revocation locks.
            try
            {
                using (var activeAfterGrant = new MySqlCommand("SELECT @@in_transaction", connection, transaction))
                {
                    if (Convert.ToInt32(activeAfterGrant.ExecuteScalar(), CultureInfo.InvariantCulture) != 1)
                        throw new UnauthorizedAccessException("Authorization provider ended the stock transaction.");
                }
            }
            catch (InvalidOperationException)
            {
                throw new UnauthorizedAccessException("Authorization provider ended the stock transaction.");
            }
            return actor;
        }

        // Transaction-owning entry point for the new Application/WPF workflow.
        // The existing Apply overload remains available to an explicitly coordinated
        // caller-owned transaction; this method never shares a checkout transaction.
        internal static void Execute(string connectionString, StockAdjustmentPlan plan)
        {
            RequireVerifiedActorAuthorization();
            if (String.IsNullOrWhiteSpace(connectionString))
                throw new ArgumentException("A local database connection is required.", "connectionString");
            if (plan == null) throw new ArgumentNullException("plan");
            // Inventory manual adjustments are offline-only. Never send a write
            // connection to a remote host, even when a caller misconfigures WPF.
            var endpoint = new MySqlConnectionStringBuilder(connectionString);
            if (!String.Equals(endpoint.Server, "127.0.0.1", StringComparison.OrdinalIgnoreCase) &&
                !String.Equals(endpoint.Server, "localhost", StringComparison.OrdinalIgnoreCase) &&
                !String.Equals(endpoint.Server, "::1", StringComparison.OrdinalIgnoreCase))
                throw new InvalidOperationException("Manual stock adjustment requires local MariaDB.");
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted))
                {
                    try
                    {
                        Apply(connection, transaction, plan);
                        transaction.Commit();
                    }
                    catch
                    {
                        // Never commit a partially applied stock change or audit.
                        // Preserve the original exception even if the connection died.
                        try { transaction.Rollback(); } catch { }
                        throw;
                    }
                }
            }
        }

        // Explicit integration entry point: the trusted composition root must
        // supply the authenticated session and persisted-grant adapter.
        // This owns a standalone MANUAL adjustment transaction. Sale/return
        // stock posting remains exclusively owned by Checkout and must use
        // neither this method nor ApplyAuthorized.
        // Architecture has not approved a session issuer/V1 actor mapping.
        // Keep the proposed provider executable ONLY in an explicitly opted-in
        // disposable acceptance process. This switch never substitutes for a grant.
        private static void RequireDisposableAuthorizationProposal(string connectionString)
        {
            var endpoint = new MySqlConnectionStringBuilder(connectionString);
            if ((!String.Equals(endpoint.Server, "127.0.0.1", StringComparison.OrdinalIgnoreCase) &&
                 !String.Equals(endpoint.Server, "localhost", StringComparison.OrdinalIgnoreCase) &&
                 !String.Equals(endpoint.Server, "::1", StringComparison.OrdinalIgnoreCase)) ||
                endpoint.Port != 3307 ||
                !String.Equals(endpoint.Database, "logica_ci", StringComparison.Ordinal) ||
                !String.Equals(Environment.GetEnvironmentVariable("HANOUTY_MANUAL_STOCK_PROPOSAL_TEST_ONLY"),
                    "YES", StringComparison.Ordinal))
                throw new UnauthorizedAccessException(
                    "Manual stock authorization mapping is not approved for production.");
        }

        internal static void ExecuteAuthorized(string connectionString, StockAdjustmentPlan plan,
            IManualStockAuthorization authorization, string authenticatedSessionId)
        {
            if (String.IsNullOrWhiteSpace(connectionString))
                throw new ArgumentException("A local database connection is required.", "connectionString");
            if (plan == null || authorization == null || String.IsNullOrWhiteSpace(authenticatedSessionId))
                throw new UnauthorizedAccessException("Verified manual stock authorization context is required.");
            var endpoint = new MySqlConnectionStringBuilder(connectionString);
            if (!String.Equals(endpoint.Server, "127.0.0.1", StringComparison.OrdinalIgnoreCase) &&
                !String.Equals(endpoint.Server, "localhost", StringComparison.OrdinalIgnoreCase) &&
                !String.Equals(endpoint.Server, "::1", StringComparison.OrdinalIgnoreCase))
                throw new UnauthorizedAccessException("Manual stock adjustment requires local MariaDB.");
            RequireDisposableAuthorizationProposal(connectionString);
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted))
                {
                    try
                    {
                        ApplyAuthorized(connection, transaction, plan, authorization, authenticatedSessionId);
                        transaction.Commit();
                    }
                    catch
                    {
                        try { transaction.Rollback(); } catch { }
                        throw;
                    }
                }
            }
        }

        internal static void ApplyAuthorized(MySqlConnection connection, MySqlTransaction transaction,
            StockAdjustmentPlan plan, IManualStockAuthorization authorization,
            string authenticatedSessionId)
        {
            if (connection == null)
                throw new UnauthorizedAccessException("Manual stock proposal requires a disposable connection.");
            RequireDisposableAuthorizationProposal(connection.ConnectionString);
            var actor = ValidateAuthorizationContext(connection, transaction, plan, authorization, authenticatedSessionId);
            ApplyCore(connection, transaction, plan, actor);
        }

        internal static void Apply(MySqlConnection connection, MySqlTransaction transaction,
            StockAdjustmentPlan plan)
        {
            RequireVerifiedActorAuthorization();
        }

        private static void ApplyCore(MySqlConnection connection, MySqlTransaction transaction,
            StockAdjustmentPlan plan, VerifiedManualStockActor actor)
        {
            if (connection == null) throw new ArgumentNullException("connection");
            if (transaction == null) throw new ArgumentNullException("transaction");
            if (plan == null) throw new ArgumentNullException("plan");
            if (connection.State != ConnectionState.Open ||
                !Object.ReferenceEquals(transaction.Connection, connection))
                throw new InvalidOperationException("An open caller-owned transaction is required.");

            // Caller-owned transactions must obey the same offline-only boundary as Execute.
            // Check the actual open connection, not a caller-supplied connection string.
            if (!String.Equals(connection.DataSource, "127.0.0.1", StringComparison.OrdinalIgnoreCase) &&
                !String.Equals(connection.DataSource, "localhost", StringComparison.OrdinalIgnoreCase) &&
                !String.Equals(connection.DataSource, "::1", StringComparison.OrdinalIgnoreCase))
                throw new InvalidOperationException("Manual stock adjustment requires local MariaDB.");

            // A user ID in an audit string is not authenticated authorization.
            // Until the verified actor-scoped permission contract is connected,
            // this writer must remain internal and unavailable to untrusted UI callers.
            // Validate the audit payload before any database mutation. A too-long
            // reason/user must never leave an uncommittable stock update behind.
            string audit = "Ajustement [" + actor.UserId + "] " +
                plan.BeforeStock.ToString(CultureInfo.InvariantCulture) + " -> " +
                plan.AfterStock.ToString(CultureInfo.InvariantCulture) + " : " + plan.Reason;
            if (Encoding.UTF8.GetByteCount(audit) > 255)
                throw new InvalidOperationException("Stock adjustment audit exceeds legacy column size.");
            if (plan.ArticleId != plan.ArticleId.Trim() || plan.UserId != plan.UserId.Trim() ||
                plan.Reason != plan.Reason.Trim())
                throw new InvalidOperationException("Stock adjustment audit values must be normalized.");
            if (plan.ArticleId.Length > 128)
                throw new InvalidOperationException("Article identity exceeds supported length.");

            // Fail closed if rollback cannot cover both the stock row and its audit entry.
            using (var schema = new MySqlCommand(
                "SELECT TABLE_NAME, ENGINE FROM information_schema.TABLES WHERE TABLE_SCHEMA = DATABASE() " +
                "AND TABLE_NAME IN ('TABLE_ARTICLES','TABLE_MOUVEMENTS_STOCK','TABLE_PARAMETRES')",
                connection, transaction))
            using (var reader = schema.ExecuteReader())
            {
                int count = 0;
                while (reader.Read())
                {
                    if (!String.Equals(Convert.ToString(reader.GetValue(1)), "InnoDB",
                        StringComparison.OrdinalIgnoreCase))
                        throw new InvalidOperationException("Stock adjustment requires InnoDB.");
                    count++;
                }
                if (count != 3) throw new InvalidOperationException("Incomplete stock adjustment schema.");
            }

            // A global feature flag is NOT user authorization. Until the
            // Application layer provides a verified actor/role contract, the
            // transaction-owning entry point must not be exposed to untrusted
            // WPF commands as a general stock-edit API.
            // Without a unique article identity, a concurrent INSERT can create a
            // second row after our SELECT FOR UPDATE. The guarded UPDATE could then
            // mutate two products while a movement records only one. Refuse unsafe
            // legacy schemas rather than silently altering a customer's indexes.
            bool uniqueArticleId = false;
            using (var indexes = new MySqlCommand(
                "SELECT INDEX_NAME, COUNT(*) AS column_count, " +
                "SUM(CASE WHEN COLUMN_NAME = 'ID_ARTICLE' THEN 1 ELSE 0 END) AS matches " +
                "FROM information_schema.STATISTICS WHERE TABLE_SCHEMA = DATABASE() " +
                "AND TABLE_NAME = 'TABLE_ARTICLES' AND NON_UNIQUE = 0 " +
                "GROUP BY INDEX_NAME",
                connection, transaction))
            using (var reader = indexes.ExecuteReader())
            {
                while (reader.Read())
                {
                    if (Convert.ToInt32(reader.GetValue(1)) == 1 &&
                        Convert.ToInt32(reader.GetValue(2)) == 1)
                        uniqueArticleId = true;
                }
            }
            if (!uniqueArticleId)
                throw new InvalidOperationException(
                    "Manual stock adjustment requires a UNIQUE ID_ARTICLE index.");

            // Read the persisted permission inside the same transaction, not a stale UI flag.
            using (var permission = new MySqlCommand(
                "SELECT VALEUR FROM TABLE_PARAMETRES WHERE OBJET = 'MODIF_STOCK_MANUEL' FOR UPDATE",
                connection, transaction))
            using (var reader = permission.ExecuteReader())
            {
                if (!reader.Read()) throw new InvalidOperationException("Manual stock permission missing.");
                string value = reader.IsDBNull(0) ? null : Convert.ToString(reader.GetValue(0));
                if (reader.Read() || !String.Equals(value, "True", StringComparison.OrdinalIgnoreCase))
                    throw new InvalidOperationException("Manual stock adjustment disabled or ambiguous.");
            }

            string code, name;
            decimal current;
            using (var select = new MySqlCommand(
                "SELECT STOCK, Code, Article FROM TABLE_ARTICLES WHERE BINARY ID_ARTICLE = BINARY @id FOR UPDATE",
                connection, transaction))
            {
                select.Parameters.AddWithValue("@id", plan.ArticleId);
                using (var reader = select.ExecuteReader())
                {
                    if (!reader.Read()) throw new InvalidOperationException("Article not found.");
                    if (reader.IsDBNull(0)) throw new InvalidOperationException("Article stock is NULL.");
                    current = Convert.ToDecimal(reader.GetValue(0), CultureInfo.InvariantCulture);
                    code = reader.IsDBNull(1) ? "" : Convert.ToString(reader.GetValue(1));
                    name = reader.IsDBNull(2) ? "" : Convert.ToString(reader.GetValue(2));
                    if (reader.Read()) throw new InvalidOperationException("Duplicate article identity.");
                }
            }
            if (current != plan.BeforeStock)
                throw new InvalidOperationException("Stale stock snapshot; refresh before adjustment.");

            // A caller might catch an audit failure and accidentally commit its
            // outer transaction. A local savepoint makes the stock + audit pair
            // indivisible even under that misuse; caller still owns final commit.
            // A fixed savepoint name can overwrite a caller savepoint or an earlier
            // nested adjustment. Generate an SQL-safe identifier per invocation.
            string savepointName = "hanouty_sa_" + Guid.NewGuid().ToString("N");
            using (var savepoint = new MySqlCommand("SAVEPOINT " + savepointName, connection, transaction))
                savepoint.ExecuteNonQuery();
            try
            {
                using (var update = new MySqlCommand(
                    "UPDATE TABLE_ARTICLES SET STOCK = @after WHERE BINARY ID_ARTICLE = BINARY @id AND STOCK = @before",
                    connection, transaction))
                {
                    update.Parameters.AddWithValue("@after", plan.AfterStock);
                    update.Parameters.AddWithValue("@before", plan.BeforeStock);
                    update.Parameters.AddWithValue("@id", plan.ArticleId);
                    if (update.ExecuteNonQuery() != 1)
                        throw new InvalidOperationException("Concurrent stock change; rollback required.");
                }
    
                // A legacy STOCK column may round a decimal quantity on write.
                // Never record a movement delta that differs from the persisted stock.
                using (var verify = new MySqlCommand(
                    "SELECT STOCK FROM TABLE_ARTICLES WHERE BINARY ID_ARTICLE = BINARY @id FOR UPDATE",
                    connection, transaction))
                {
                    verify.Parameters.AddWithValue("@id", plan.ArticleId);
                    using (var reader = verify.ExecuteReader())
                    {
                        if (!reader.Read() || reader.IsDBNull(0) ||
                            Convert.ToDecimal(reader.GetValue(0), CultureInfo.InvariantCulture) != plan.AfterStock ||
                            reader.Read())
                            throw new InvalidOperationException(
                                "Persisted stock differs from adjustment; rollback required.");
                    }
                }

                // Legacy movement schema has no dedicated before/after/user columns.
                // Keep a bounded, explicit audit in LIBELLE without changing shop schema.
                using (var movement = new MySqlCommand(
                    "INSERT INTO TABLE_MOUVEMENTS_STOCK " +
                    "(DATES, HEURE, LIBELLE, ID_ARTICLE, CODE_ARTICLE, ARTICLE, QUANTITE) " +
                    "VALUES (@date, @time, @audit, @id, @code, @name, @delta)",
                    connection, transaction))
                {
                    // Use the same database UTC clock as session/grant expiry.
                    // A workstation clock/time-zone change must not falsify the
                    // movement timestamp or place it outside its grant window.
                    DateTime now;
                    using (var clock = new MySqlCommand("SELECT UTC_TIMESTAMP()", connection, transaction))
                        now = Convert.ToDateTime(clock.ExecuteScalar(), CultureInfo.InvariantCulture);
                    movement.Parameters.AddWithValue("@date", now);
                    movement.Parameters.AddWithValue("@time", now.ToString("HH:mm:ss", CultureInfo.InvariantCulture));
                    movement.Parameters.AddWithValue("@audit", audit);
                    movement.Parameters.AddWithValue("@id", plan.ArticleId);
                    movement.Parameters.AddWithValue("@code", code);
                    movement.Parameters.AddWithValue("@name", name);
                    movement.Parameters.AddWithValue("@delta", plan.Delta);
                    if (movement.ExecuteNonQuery() != 1)
                        throw new InvalidOperationException("Stock movement audit failed; rollback required.");
                }
                using (var release = new MySqlCommand("RELEASE SAVEPOINT " + savepointName, connection, transaction))
                    release.ExecuteNonQuery();
            }
            catch
            {
                // ROLLBACK TO retains the savepoint in MariaDB. Release it after
                // undoing the adjustment, so callers may continue the transaction.
                using (var rollback = new MySqlCommand("ROLLBACK TO SAVEPOINT " + savepointName, connection, transaction))
                    rollback.ExecuteNonQuery();
                using (var release = new MySqlCommand("RELEASE SAVEPOINT " + savepointName, connection, transaction))
                    release.ExecuteNonQuery();
                throw;
            }
        }
    }
}
