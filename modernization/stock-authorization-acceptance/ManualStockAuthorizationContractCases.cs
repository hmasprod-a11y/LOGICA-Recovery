using LOGICA.Application.Inventory;
using LOGICA.Infrastructure.Inventory;
using MySql.Data.MySqlClient;

// A controlled provider exercises the actual non-writing validation boundary.
// This fixture is NOT a persisted permission source and cannot enable the writer.
internal static class ManualStockAuthorizationContractCases
{
    private sealed class ScopedFixture : IManualStockAuthorization
    {
        internal MySqlConnection Connection;
        internal MySqlTransaction Transaction;
        internal int Calls;
        internal bool Revoked;
        internal bool ReturnNull;
        internal string Actor = "P0-USER";
        internal Exception Failure;
        public VerifiedManualStockActor VerifyForWrite(object connection, object transaction,
            string session, string requestedUser)
        {
            Calls++;
            Require(ReferenceEquals(connection, Connection) && ReferenceEquals(transaction, Transaction),
                "Provider must receive the exact active transaction.");
            Require(session == "fixture-session" && requestedUser == "P0-USER",
                "Provider must receive the exact requested session and actor.");
            if (Failure != null) throw Failure;
            if (Revoked) throw new UnauthorizedAccessException("Fixture grant revoked.");
            return ReturnNull ? null : new VerifiedManualStockActor(Actor);
        }
    }
    private static void Require(bool ok, string message)
    { if (!ok) throw new Exception(message); }
    private static void Denied(Action action)
    {
        try { action(); } catch (UnauthorizedAccessException) { return; }
        throw new Exception("Expected authorization context rejection.");
    }
    internal static void Run(MySqlConnection db)
    {
        var plan = StockAdjustmentPlan.Create("P0-ARTICLE", 10m, 12m, "contract fixture", "P0-USER");
        var source = new ScopedFixture { Connection = db };
        using (var tx = db.BeginTransaction()) {
            source.Transaction = tx;
            Action validate = () => StockAdjustmentWriter.ValidateAuthorizationContext(
                db, tx, plan, source, "fixture-session");
            validate(); // Only the non-writing context validation is enabled by this fixture.
            Require(source.Calls == 1, "Initial validation must call provider once.");
            source.Revoked = true;
            Denied(validate);
            Require(source.Calls == 2, "Revocation must re-query, never reuse prior actor.");
            source.Revoked = false;
            source.Actor = "ADMIN";
            Denied(validate);
            source.Actor = "p0-user";
            Denied(validate);
            source.ReturnNull = true;
            Denied(validate);
            source.ReturnNull = false;
            source.Actor = "P0-USER";
            source.Failure = new InvalidOperationException("fixture source unavailable");
            try { validate(); throw new Exception("Unavailable provider was accepted."); }
            catch (InvalidOperationException ex) {
                Require(ReferenceEquals(ex, source.Failure), "Provider failure must propagate without fallback.");
            }
            source.Failure = null;
            int calls = source.Calls;
            using (var detached = new MySqlConnection(db.ConnectionString)) {
                Denied(() => StockAdjustmentWriter.ValidateAuthorizationContext(
                    detached, tx, plan, source, "fixture-session"));
            }
            Denied(() => StockAdjustmentWriter.ValidateAuthorizationContext(
                db, tx, plan, source, ""));
            Require(source.Calls == calls, "Invalid context must not disclose session to provider.");
            tx.Commit(); // Even catch-and-commit cannot create stock/audit mutations.
        }
        int completedCalls = source.Calls;
        Denied(() => StockAdjustmentWriter.ValidateAuthorizationContext(
            db, source.Transaction, plan, source, "fixture-session"));
        Require(source.Calls == completedCalls, "Completed transaction must not invoke provider.");
        using var check = new MySqlCommand(
            "SELECT STOCK = 10 AND (SELECT COUNT(*) FROM TABLE_MOUVEMENTS_STOCK) = 0 " +
            "FROM TABLE_ARTICLES WHERE ID_ARTICLE='P0-ARTICLE'", db);
        Require(Convert.ToInt32(check.ExecuteScalar()) == 1, "Context validation mutated stock or audit.");
        Console.WriteLine("PASS actual non-writing validation: scoped fixture allow then revoke, actor mismatch, null result, provider failure and detached/completed transaction. No production grant mapping accepted.");
    }
}
