using LOGICA.Application.Inventory;
using LOGICA.Infrastructure.Inventory;
using MySql.Data.MySqlClient;

// A fabricated adapter is never permission provenance, even if it returns
// a matching actor. The real persisted-grant SQL acceptance lives separately.
internal static class ManualStockAuthorizationContractCases
{
    private sealed class ForgedProvider : IManualStockAuthorization
    {
        internal int Calls;
        public VerifiedManualStockActor VerifyForWrite(object connection, object transaction,
            string session, string requestedUser)
        {
            Calls++;
            return new VerifiedManualStockActor(requestedUser);
        }
    }

    private static void Require(bool ok, string message)
    { if (!ok) throw new Exception(message); }

    private static void Denied(Action action)
    {
        try { action(); }
        catch (UnauthorizedAccessException) { return; }
        throw new Exception("Expected authorization rejection.");
    }

    internal static void Run(MySqlConnection db)
    {
        var plan = StockAdjustmentPlan.Create("P0-ARTICLE", 10m, 12m,
            "contract fixture", "P0-USER");
        var forged = new ForgedProvider();
        using (var tx = db.BeginTransaction())
        {
            Denied(() => StockAdjustmentWriter.ValidateAuthorizationContext(
                db, tx, plan, forged, "fixture-session"));
            Denied(() => StockAdjustmentWriter.ApplyAuthorized(
                db, tx, plan, forged, "fixture-session"));
            Require(forged.Calls == 0,
                "Writer must reject forged adapters before calling them.");
            Denied(() => StockAdjustmentWriter.ValidateAuthorizationContext(
                db, tx, plan, forged, ""));
            using (var detached = new MySqlConnection(db.ConnectionString))
                Denied(() => StockAdjustmentWriter.ValidateAuthorizationContext(
                    detached, tx, plan, forged, "fixture-session"));
            Require(forged.Calls == 0, "Invalid context leaked to forged adapter.");
            tx.Commit();
        }
        using (var check = new MySqlCommand(
            "SELECT STOCK = 10 AND (SELECT COUNT(*) FROM TABLE_MOUVEMENTS_STOCK) = 0 " +
            "FROM TABLE_ARTICLES WHERE ID_ARTICLE='P0-ARTICLE'", db))
            Require(Convert.ToInt32(check.ExecuteScalar()) == 1,
                "Forged provider changed stock or audit.");
        Console.WriteLine("PASS forged actor provider rejected before invocation; stock and audit unchanged.");
    }
}
