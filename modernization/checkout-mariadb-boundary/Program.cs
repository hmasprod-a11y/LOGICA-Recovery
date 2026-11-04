using System;
using LOGICA.ApplicationLayer.Checkout;
using LOGICA.Infrastructure.Checkout;
using MySql.Data.MySqlClient;

namespace LOGICA.Infrastructure.Checkout
{
    internal static class Program
    {
        private static void Require(bool condition, string message)
        {
            if (!condition) throw new InvalidOperationException(message);
        }

        private static MySqlConnection NewConnection()
        {
            return new MySqlConnection(Environment.GetEnvironmentVariable("CHECKOUT_TEST_CONNECTION"));
        }

        private static void Main()
        {
            Require(!string.IsNullOrWhiteSpace(Environment.GetEnvironmentVariable("CHECKOUT_TEST_CONNECTION")),
                "Disposable CHECKOUT_TEST_CONNECTION is required.");
            var settings = new MySqlConnectionStringBuilder(Environment.GetEnvironmentVariable("CHECKOUT_TEST_CONNECTION"));
            Require(settings.Database == "checkout_disposable" &&
                (settings.Server == "127.0.0.1" || settings.Server == "localhost"),
                "Acceptance is restricted to the disposable loopback schema.");
            Require(typeof(AuthorizedCheckoutMariaDbPort).GetInterface("IAuthorizedCheckoutPort") != null,
                "Actual authorized financial port must compile against Architecture.");
            string key = "csharp-boundary-" + Guid.NewGuid().ToString("N");
            using (MySqlConnection connection = NewConnection())
            {
                MySqlCheckoutAtomicPostingBoundary boundary = new MySqlCheckoutAtomicPostingBoundary(connection);
                boundary.Open();
                boundary.BeginAndBind();
                Require(boundary.TryClaimOperation(key), "First claim must succeed.");
                boundary.Commit();
                boundary.Close();
            }
            MySqlCheckoutOperationJournal journal = new MySqlCheckoutOperationJournal(NewConnection);
            Require(journal.IsPersisted(key), "Committed C# operation must be durable.");
            using (MySqlConnection connection = NewConnection())
            {
                MySqlCheckoutAtomicPostingBoundary boundary = new MySqlCheckoutAtomicPostingBoundary(connection);
                boundary.Open();
                boundary.BeginAndBind();
                Require(!boundary.TryClaimOperation(key), "Duplicate C# operation must be rejected.");
                boundary.Rollback();
                boundary.Close();
            }
            string rolledBack = key + "-rollback";
            using (MySqlConnection connection = NewConnection())
            {
                MySqlCheckoutAtomicPostingBoundary boundary = new MySqlCheckoutAtomicPostingBoundary(connection);
                boundary.Open();
                boundary.BeginAndBind();
                Require(boundary.TryClaimOperation(rolledBack), "Rollback claim should begin.");
                boundary.Rollback();
                boundary.Close();
            }
            Require(!journal.IsPersisted(rolledBack), "Rolled back C# operation must not persist.");
            using (MySqlConnection connection = NewConnection())
            {
                MySqlCheckoutAtomicPostingBoundary boundary = new MySqlCheckoutAtomicPostingBoundary(connection);
                boundary.Open();
                boundary.BeginAndBind();
                Require(boundary.TryClaimOperation(rolledBack), "Retry after verified rollback must succeed.");
                boundary.Commit();
                boundary.Close();
            }
            Require(journal.IsPersisted(rolledBack), "Retry must be durable.");
            // A lost acknowledgement after COMMIT is not permission to repost.
            // The second connection must see the committed claim, and a third
            // connection must still reject it after the first was closed.
            using (MySqlConnection connection = NewConnection())
            {
                MySqlCheckoutAtomicPostingBoundary boundary = new MySqlCheckoutAtomicPostingBoundary(connection);
                boundary.Open();
                boundary.BeginAndBind();
                Require(!boundary.TryClaimOperation(key), "Lost-ack replay must not claim committed ID.");
                boundary.Rollback();
                boundary.Close();
            }
            Require(journal.IsPersisted(key), "Reconciliation must survive duplicate replay.");

            // A competing transaction must not create a second durable claim.
            // This is an actual two-connection InnoDB contention test, not a mock.
            string contested = key + "-contended";
            using (MySqlConnection first = NewConnection())
            using (MySqlConnection second = NewConnection())
            {
                var winner = new MySqlCheckoutAtomicPostingBoundary(first);
                winner.Open();
                winner.BeginAndBind();
                Require(winner.TryClaimOperation(contested), "First concurrent claim failed.");
                var loser = new MySqlCheckoutAtomicPostingBoundary(second);
                loser.Open();
                loser.BeginAndBind();
                using (var wait = new System.Threading.ManualResetEventSlim(false))
                {
                    bool duplicate = false;
                    Exception failure = null;
                    var contender = new System.Threading.Thread(() =>
                    {
                        try { duplicate = !loser.TryClaimOperation(contested); }
                        catch (Exception ex) { failure = ex; }
                        finally { wait.Set(); }
                    });
                    contender.IsBackground = true;
                    contender.Start();
                    Require(!wait.Wait(150), "Uncommitted claim was not isolated from concurrent cashier.");
                    winner.Commit();
                    winner.Close();
                    Require(wait.Wait(10000), "Concurrent claim did not settle after commit.");
                    if (failure != null) throw new InvalidOperationException("Concurrent claim failed.", failure);
                    Require(duplicate, "Second cashier acquired duplicate durable operation.");
                }
                loser.Rollback();
                loser.Close();
            }
            Require(journal.IsPersisted(contested), "Concurrent winning operation not durable.");

            // If the first cashier rolls back, a waiting cashier must be
            // allowed to claim the ID exactly once. This proves rollback
            // releases the InnoDB unique-key lock rather than poisoning retries.
            string rolledBackContested = key + "-contended-rollback";
            using (MySqlConnection first = NewConnection())
            using (MySqlConnection second = NewConnection())
            {
                var aborted = new MySqlCheckoutAtomicPostingBoundary(first);
                aborted.Open();
                aborted.BeginAndBind();
                Require(aborted.TryClaimOperation(rolledBackContested), "Initial rollback contender failed.");
                var successor = new MySqlCheckoutAtomicPostingBoundary(second);
                successor.Open();
                successor.BeginAndBind();
                using (var wait = new System.Threading.ManualResetEventSlim(false))
                {
                    bool claimed = false;
                    Exception failure = null;
                    var contender = new System.Threading.Thread(() =>
                    {
                        try { claimed = successor.TryClaimOperation(rolledBackContested); }
                        catch (Exception ex) { failure = ex; }
                        finally { wait.Set(); }
                    });
                    contender.IsBackground = true;
                    contender.Start();
                    Require(!wait.Wait(150), "Uncommitted rollback contender was not isolated.");
                    aborted.Rollback();
                    aborted.Close();
                    Require(wait.Wait(10000), "Successor did not settle after rollback.");
                    if (failure != null) throw new InvalidOperationException("Rollback contender failed.", failure);
                    Require(claimed, "Rollback did not release durable operation ID.");
                }
                successor.Commit();
                successor.Close();
            }
            Require(journal.IsPersisted(rolledBackContested),
                "Successor claim after rollback must be durable.");
            using (MySqlConnection connection = NewConnection())
            {
                var duplicate = new MySqlCheckoutAtomicPostingBoundary(connection);
                duplicate.Open();
                duplicate.BeginAndBind();
                Require(!duplicate.TryClaimOperation(rolledBackContested),
                    "Rollback successor must not be posted twice.");
                duplicate.Rollback();
                duplicate.Close();
            }

            // A malformed ID must never be inserted, even when the caller
            // has already begun a transaction.
            using (MySqlConnection connection = NewConnection())
            {
                MySqlCheckoutAtomicPostingBoundary boundary = new MySqlCheckoutAtomicPostingBoundary(connection);
                boundary.Open();
                boundary.BeginAndBind();
                bool rejected = false;
                try { boundary.TryClaimOperation(" invalid "); }
                catch (ArgumentException) { rejected = true; }
                Require(rejected, "Whitespace-surrounded operation ID must be rejected.");
                boundary.Rollback();
                boundary.Close();
            }

            // The durable journal must not mistake a missing operation for
            // an unknown database result; an actual connection error must
            // propagate instead of authorizing a retry.
            Require(!journal.IsPersisted("not-present-" + Guid.NewGuid().ToString("N")),
                "A never-submitted operation must be absent.");
            var unreachable = new MySqlCheckoutOperationJournal(() =>
                new MySqlConnection("Server=127.0.0.1;Port=1;Database=checkout_disposable;Uid=checkout_test;Pwd=checkout-test-only;SslMode=Disabled;Connection Timeout=1;"));
            bool connectionFailed = false;
            try { unreachable.IsPersisted(key); }
            catch (MySqlException) { connectionFailed = true; }
            Require(connectionFailed, "Unavailable journal must propagate unknown outcome.");

            // Real production stock/movement writers, with signed V1 sale/return.
            using (MySqlConnection db = NewConnection())
            {
                db.Open();
                using (MySqlCommand setup = db.CreateCommand())
                {
                    setup.CommandText = "CREATE TABLE TABLE_ARTICLES (ID_ARTICLE VARCHAR(64) PRIMARY KEY, STOCK DECIMAL(16,3) NOT NULL) ENGINE=InnoDB";
                    setup.ExecuteNonQuery();
                    setup.CommandText = "CREATE TABLE TABLE_MOUVEMENTS_STOCK (DATES VARCHAR(16), HEURE VARCHAR(16), LIBELLE VARCHAR(128), ID_ARTICLE VARCHAR(64), CODE_ARTICLE VARCHAR(64), ARTICLE VARCHAR(128), QUANTITE DECIMAL(16,3)) ENGINE=InnoDB";
                    setup.ExecuteNonQuery();
                    setup.CommandText = "INSERT INTO TABLE_ARTICLES VALUES ('CSharp-Stock',10)";
                    setup.ExecuteNonQuery();
                }
                using (MySqlTransaction tx = db.BeginTransaction())
                using (MySqlCommand cmd = db.CreateCommand())
                {
                    cmd.Transaction = tx;
                    CheckoutStockWriter.Apply(cmd, db, "SALE-1", "CSharp-Stock", "CODE", "Article", 2m);
                    CheckoutStockWriter.Apply(cmd, db, "RETURN-1", "CSharp-Stock", "CODE", "Article", -1m);
                    tx.Commit();
                }
                using (MySqlCommand check = db.CreateCommand())
                {
                    check.CommandText = "SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='CSharp-Stock'";
                    Require(Convert.ToDecimal(check.ExecuteScalar()) == 9m, "Sale/return stock parity failed.");
                    check.CommandText = "SELECT SUM(QUANTITE) FROM TABLE_MOUVEMENTS_STOCK WHERE ID_ARTICLE='CSharp-Stock'";
                    Require(Convert.ToDecimal(check.ExecuteScalar()) == -1m, "Signed movement parity failed.");
                }
                using (MySqlTransaction tx = db.BeginTransaction())
                using (MySqlCommand cmd = db.CreateCommand())
                {
                    cmd.Transaction = tx;
                    bool missingRejected = false;
                    try { CheckoutStockWriter.Apply(cmd, db, "BAD", "missing", "CODE", "Article", 3m); }
                    catch (InvalidOperationException) { missingRejected = true; }
                    Require(missingRejected, "Missing article must fail closed.");
                    CheckoutStockWriter.Apply(cmd, db, "ROLLBACK", "CSharp-Stock", "CODE", "Article", 4m);
                    tx.Rollback();
                }
                using (MySqlCommand check = db.CreateCommand())
                {
                    check.CommandText = "SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='CSharp-Stock'";
                    Require(Convert.ToDecimal(check.ExecuteScalar()) == 9m, "Rollback changed stock.");
                    check.CommandText = "SELECT COUNT(*) FROM TABLE_MOUVEMENTS_STOCK WHERE LIBELLE='TICKET | ROLLBACK'";
                    Require(Convert.ToInt64(check.ExecuteScalar()) == 0, "Rollback left movement.");
                    bool noTxRejected = false;
                    try { CheckoutStockWriter.Apply(check, db, "NO-TX", "CSharp-Stock", "CODE", "Article", 1m); }
                    catch (InvalidOperationException) { noTxRejected = true; }
                    Require(noTxRejected, "Writer accepted no transaction.");
                }
            }
            VerifyProductionPosting();
            VerifyAuthorizedPortTransaction();
            Console.WriteLine("PASS production C# stock sale/return, movement, missing article and rollback.");
            Console.WriteLine("PASS production C# MariaDB boundary: commit, replay, rollback, invalid ID and unknown reconciliation.");
        }
        private static void Sql(string sql)
        {
            using (var db = NewConnection())
            {
                db.Open();
                using (var cmd = db.CreateCommand()) { cmd.CommandText = sql; cmd.ExecuteNonQuery(); }
            }
        }

        private static decimal Scalar(string sql)
        {
            using (var db = NewConnection())
            {
                db.Open();
                using (var cmd = db.CreateCommand()) { cmd.CommandText = sql; return Convert.ToDecimal(cmd.ExecuteScalar()); }
            }
        }

        private static CheckoutPostingInput Input(string id, bool injectFailure)
        {
            var date = new DateTime(2026, 1, 1, 12, 0, 0);
            return new CheckoutPostingInput
            {
                ReadStock = () => new[] { new CheckoutStockLine { TicketNumber = "1", ArticleId = "CSharp-Stock", ArticleCode = "CODE", ArticleName = "Article", BasketQuantity = 2m } },
                ReadHeader = () => new TicketHeaderRecord { TicketId = id, TicketNumber = "1", SaleDate = date, Cashier = "fixture-cashier", ClientId = "0", ClientCode = "0", ClientName = "Fixture", Workstation = "01", TotalText = "10", Operation = "VENTE" },
                ReadJournal = () => new TicketJournalRecord { TicketId = id, TicketNumber = "1", SaleDate = date, Workstation = "01", Cashier = "fixture-cashier", Seller = "fixture", ClientId = "0", ClientCode = "0", ClientName = "Fixture", Operation = "VENTE", PriceType = "DETAIL", PaymentModes = "ESPECES" },
                ReadPayments = () => new[] { new TicketPaymentWrite { Kind = TicketPaymentKind.Cash, AmountText = "10", Context = new TicketPaymentContext { TicketId = id, TicketNumber = "1", SaleDate = date, Cashier = "fixture-cashier", ClientId = "0", ClientCode = "0", ClientName = "Fixture", Workstation = "01", Operation = "VENTE", Remark = "" } } },
                // Fault after stock, header, journal AND payment have executed.
                // No physical printer side effect is allowed before Commit.
                Print = () => { if (injectFailure) throw new InvalidOperationException("injected-after-payment"); },
                ReadCompletion = () => new CheckoutCompletionRecord { Workstation = "01", TicketNumber = "1" }
            };
        }

        private static void Post(string operation, string ticket, bool fail)
        {
            using (var db = NewConnection())
            {
                CheckoutAtomicPostingService.Execute(new MySqlCheckoutAtomicPostingBoundary(db),
                    Input(ticket, fail), operation, new CheckoutCommitProgress());
            }
        }

        private static void SeedBasket()
        {
            Sql("INSERT INTO TABLE_01 VALUES ('CSharp-Stock','CODE','Article','Food',1,1,5,2,0,10,0,'G')");
        }

        private static void VerifyProductionPosting()
        {
            // These disposable tables reproduce the columns consumed by the
            // actual legacy writers; no replacement posting store is compiled.
            Sql("CREATE TABLE TABLE_VENTES_ENTETE (ID_TICKET VARCHAR(64) PRIMARY KEY,TICKET TEXT,DATES TEXT,CAISSIER TEXT,ID_CLIENT TEXT,CODE_CLIENT TEXT,CLIENT TEXT,POSTE TEXT,Total_NET DECIMAL(16,3),OPERATION TEXT) ENGINE=InnoDB");
            Sql("CREATE TABLE TABLE_01 (ID_ARTICLE VARCHAR(64),Code TEXT,Article TEXT,Famille TEXT,PRIX_A DECIMAL(16,3),PRIX_MP DECIMAL(16,3),PRIX_V DECIMAL(16,3),Qté DECIMAL(16,3),Remise DECIMAL(16,3),TOTAL_NET DECIMAL(16,3),TAUX_TVA DECIMAL(16,3),GROUPE TEXT) ENGINE=InnoDB");
            Sql("CREATE TABLE TABLE_VENTES_JOURNAL (ID_TICKET VARCHAR(64),Ticket TEXT,Dates TEXT,Heure TEXT,ID_ARTICLE VARCHAR(64),Code TEXT,Article TEXT,Famille TEXT,PRIX_A DECIMAL(16,3),PRIX_MP DECIMAL(16,3),PRIX_V DECIMAL(16,3),Qté DECIMAL(16,3),Remise DECIMAL(16,3),Total_NET DECIMAL(16,3),TAUX_TVA DECIMAL(16,3),GROUPE TEXT,Caissier TEXT,Vendeur TEXT,ID_CLIENT TEXT,CODE_CLIENT TEXT,CLIENT TEXT,POSTE TEXT,OPERATION TEXT,NOTES TEXT,NOTES_TYPE_PRIX TEXT,NOTES_MODE_P TEXT) ENGINE=InnoDB");
            Sql("CREATE TABLE TABLE_VENTES_REGLEMENTS (ID_TICKET VARCHAR(64),TICKET TEXT,DATES TEXT,CAISSIER TEXT,ID_CLIENT TEXT,CODE_CLIENT TEXT,CLIENT TEXT,POSTE TEXT,MONTANT DECIMAL(16,3),MODE_P TEXT,OPERATION TEXT,NOTES_REMARQUE TEXT) ENGINE=InnoDB");
            Sql("CREATE TABLE TABLE_NUM (CL INT NOT NULL) ENGINE=InnoDB");
            Sql("INSERT INTO TABLE_NUM VALUES (1)");
            SeedBasket();
            Post("production-sale", "production-ticket", false);
            Require(Scalar("SELECT COUNT(*) FROM TABLE_VENTES_ENTETE WHERE ID_TICKET='production-ticket' AND Total_NET=10") == 1, "Actual ticket header not persisted.");
            Require(Scalar("SELECT COUNT(*) FROM TABLE_VENTES_JOURNAL WHERE ID_TICKET='production-ticket' AND Qté=2 AND Total_NET=10") == 1, "Actual sale journal not persisted.");
            Require(Scalar("SELECT SUM(MONTANT) FROM TABLE_VENTES_REGLEMENTS WHERE ID_TICKET='production-ticket'") == 10, "Actual cash payment not persisted.");
            Require(Scalar("SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='CSharp-Stock'") == 7, "Sale stock must decrement exactly once.");
            Require(Scalar("SELECT COUNT(*) FROM TABLE_01") == 0 && Scalar("SELECT CL FROM TABLE_NUM") == 2, "Completion did not clear basket/advance sequence.");
            Require(new MySqlCheckoutOperationJournal(NewConnection).IsPersisted("production-sale"), "Financial operation claim missing.");

            SeedBasket();
            Post("production-sale", "must-not-post", false);
            Require(Scalar("SELECT COUNT(*) FROM TABLE_VENTES_ENTETE") == 1 &&
                Scalar("SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='CSharp-Stock'") == 7 &&
                Scalar("SELECT COUNT(*) FROM TABLE_01") == 1, "Duplicate replay changed sale, stock or basket.");

            var movements = Scalar("SELECT COUNT(*) FROM TABLE_MOUVEMENTS_STOCK");
            bool failed = false;
            try { Post("production-rollback", "rolledback-ticket", true); }
            catch (InvalidOperationException ex) when (ex.Message == "injected-after-payment") { failed = true; }
            Require(failed, "Fault injection did not execute after actual payment writer.");
            Require(Scalar("SELECT COUNT(*) FROM TABLE_VENTES_ENTETE") == 1 &&
                Scalar("SELECT COUNT(*) FROM TABLE_VENTES_JOURNAL") == 1 &&
                Scalar("SELECT COUNT(*) FROM TABLE_VENTES_REGLEMENTS") == 1, "Rollback retained financial rows.");
            Require(Scalar("SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='CSharp-Stock'") == 7 &&
                Scalar("SELECT COUNT(*) FROM TABLE_MOUVEMENTS_STOCK") == movements &&
                Scalar("SELECT COUNT(*) FROM TABLE_01") == 1 && Scalar("SELECT CL FROM TABLE_NUM") == 2,
                "Rollback changed stock, movement, basket or sequence.");
            Require(!new MySqlCheckoutOperationJournal(NewConnection).IsPersisted("production-rollback"), "Rolled back financial claim survived.");
            Post("production-rollback", "retried-ticket", false);
            Require(Scalar("SELECT COUNT(*) FROM TABLE_VENTES_ENTETE") == 2 &&
                Scalar("SELECT COUNT(*) FROM TABLE_VENTES_REGLEMENTS") == 2 &&
                Scalar("SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='CSharp-Stock'") == 5,
                "Retry after verified rollback failed financial persistence.");
            Console.WriteLine("PASS actual production posting: ticket/payment/journal/stock/completion, durable duplicate and rollback after payment. Trusted authorization and WPF W2 acceptance remain pending.");
        }

        private sealed class PreparationFixture : ITrustedCheckoutPostingPreparation
        {
            internal Func<Hanouty.ArchitectureBridge.AuthorizedCheckoutRequest, MySqlConnection, MySqlTransaction, CheckoutPostingInput> Callback;
            public CheckoutPostingInput Prepare(Hanouty.ArchitectureBridge.AuthorizedCheckoutRequest request,
                MySqlConnection connection, MySqlTransaction transaction) => Callback(request, connection, transaction);
        }

        private static Hanouty.ArchitectureBridge.AuthorizedCheckoutRequest Request(string operation)
        {
            return new Hanouty.ArchitectureBridge.AuthorizedCheckoutRequest(operation,
                "fixture-cashier", "MAD", false,
                new[] { new Hanouty.ArchitectureBridge.CheckoutBatchLine("CSharp-Stock", 2) },
                new[] { new Hanouty.ArchitectureBridge.CheckoutPayment(Hanouty.ArchitectureBridge.CheckoutPaymentKind.Cash, 10m) },
                10m);
        }

        private static void VerifyAuthorizedPortTransaction()
        {
            var calls = 0;
            var preparation = new PreparationFixture
            {
                Callback = (request, connection, transaction) =>
                {
                    calls++;
                    Require(connection.State == System.Data.ConnectionState.Open &&
                        transaction != null && ReferenceEquals(transaction.Connection, connection),
                        "Trusted preparation must receive the active posting connection/transaction.");
                    using (var command = connection.CreateCommand())
                    {
                        command.Transaction = transaction;
                        command.CommandText = "SELECT COUNT(*) FROM hanouty_checkout_operations WHERE operation_id=@id";
                        command.Parameters.AddWithValue("@id", request.OperationId);
                        Require(Convert.ToInt32(command.ExecuteScalar()) == 1,
                            "Preparation must see the operation claim in its transaction.");
                    }
                    Require(Scalar("SELECT COUNT(*) FROM hanouty_checkout_operations WHERE operation_id='port-sale'") == 0,
                        "Operation must not be committed before trusted preparation.");
                    return Input("port-ticket", false);
                }
            };
            var port = new AuthorizedCheckoutMariaDbPort(NewConnection, preparation);
            SeedBasket();
            port.Commit(Request("port-sale"));
            Require(calls == 1 && Scalar("SELECT COUNT(*) FROM TABLE_VENTES_ENTETE") == 3 &&
                Scalar("SELECT COUNT(*) FROM TABLE_VENTES_REGLEMENTS") == 3 &&
                Scalar("SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='CSharp-Stock'") == 3,
                "Actual authorized port failed production financial persistence.");
            port.Commit(Request("port-sale"));
            Require(calls == 1 && Scalar("SELECT COUNT(*) FROM TABLE_VENTES_ENTETE") == 3 &&
                Scalar("SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='CSharp-Stock'") == 3,
                "Duplicate authorized operation must skip preparation and writers.");

            var denied = new AuthorizedCheckoutMariaDbPort(NewConnection, new PreparationFixture
            {
                Callback = (request, connection, transaction) => throw new UnauthorizedAccessException("fixture-denied")
            });
            SeedBasket();
            bool rejected = false;
            try { denied.Commit(Request("port-denied")); }
            catch (UnauthorizedAccessException ex) when (ex.Message == "fixture-denied") { rejected = true; }
            Require(rejected && !new MySqlCheckoutOperationJournal(NewConnection).IsPersisted("port-denied") &&
                Scalar("SELECT COUNT(*) FROM TABLE_VENTES_ENTETE") == 3 &&
                Scalar("SELECT COUNT(*) FROM TABLE_VENTES_REGLEMENTS") == 3 &&
                Scalar("SELECT COUNT(*) FROM TABLE_01") == 1 &&
                Scalar("SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='CSharp-Stock'") == 3,
                "Denied preparation must roll back the claim and preserve all business state.");
            Console.WriteLine("PASS actual authorized port transaction, uncommitted claim isolation, duplicate preparation suppression and denied-preparation rollback; preparation is a TEST fixture, not production authentication.");
        }

    }
}
