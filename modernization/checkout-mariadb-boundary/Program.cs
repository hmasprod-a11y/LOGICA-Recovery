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
                    bool rejectedSelfReturn = false;
                    try
                    {
                        CashReturnConsumptionClaim.ClaimFullOriginal(
                            db, tx, "self-refund", "self-refund", 1m);
                    }
                    catch (InvalidOperationException)
                    {
                        rejectedSelfReturn = true;
                    }
                    Require(rejectedSelfReturn,
                        "Direct durable return claim must reject self-referential operation identity.");
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
            VerifyRealCashPreparation();
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

        private static Hanouty.ArchitectureBridge.AuthorizedCheckoutRequest TrustedRequest(string operation,
            string cashier = "O'Neil", decimal amount = 10.50m)
        {
            return new Hanouty.ArchitectureBridge.AuthorizedCheckoutRequest(operation, cashier, "MAD", false,
                new[] { new Hanouty.ArchitectureBridge.CheckoutBatchLine("CSharp-Stock", 2) },
                new[] { new Hanouty.ArchitectureBridge.CheckoutPayment(Hanouty.ArchitectureBridge.CheckoutPaymentKind.Cash, amount) },
                10.50m);
        }

        private static void SeedTrustedBasket()
        {
            Sql("DELETE FROM TABLE_01");
            Sql("INSERT INTO TABLE_01 VALUES ('CSharp-Stock','CODE''1','Lait d''été','Food',1,1,5.25,2,0,10.50,20,'G')");
        }

        private static void VerifyRealCashPreparation()
        {
            // Existing schema, actual credentials and actual prices in a disposable DB;
            // the production preparation implementation is used, not a test double.
            Sql("CREATE TABLE TABLE_PASS (ListUser VARCHAR(128), ListPass VARCHAR(256), Catégorie VARCHAR(64)) ENGINE=InnoDB");
            Sql("INSERT INTO TABLE_PASS VALUES ('O''Neil','1234','UTILISATEUR')");
            Sql("ALTER TABLE TABLE_NUM ADD ID INT NOT NULL DEFAULT 0");
            Sql("ALTER TABLE TABLE_ARTICLES ADD Code VARCHAR(64), ADD Article VARCHAR(128), ADD Famille VARCHAR(64), ADD PRIX_A DECIMAL(16,3), ADD PRIX_MP DECIMAL(16,3), ADD PRIX_V_1 DECIMAL(16,3), ADD TAUX_TVA DECIMAL(16,3), ADD GROUPE VARCHAR(64), ADD PROMOTION DECIMAL(16,3) DEFAULT 0, ADD PRIX_QTE DECIMAL(16,3) DEFAULT 0");
            Sql("UPDATE TABLE_ARTICLES SET STOCK=100,Code='CODE''1',Article='Lait d''été',Famille='Food',PRIX_A=1,PRIX_MP=1,PRIX_V_1=5.25,TAUX_TVA=20,GROUPE='G' WHERE ID_ARTICLE='CSharp-Stock'");
            Sql("DELETE FROM TABLE_01");
            var headers = Scalar("SELECT COUNT(*) FROM TABLE_VENTES_ENTETE");
            var payments = Scalar("SELECT COUNT(*) FROM TABLE_VENTES_REGLEMENTS");
            var stock = Scalar("SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='CSharp-Stock'");
            var journal = new MySqlCheckoutOperationJournal(NewConnection);
            var detailCount = Scalar("SELECT COUNT(*) FROM TABLE_VENTES_JOURNAL");
            var movementCount = Scalar("SELECT COUNT(*) FROM TABLE_MOUVEMENTS_STOCK");
            var sequenceValue = Scalar("SELECT CL FROM TABLE_NUM");

            var expectedBasketRows = 0;
            Action<string, Action> rejected = (operation, action) =>
            {
                bool denied = false;
                try { action(); }
                catch (UnauthorizedAccessException) { denied = true; }
                catch (InvalidOperationException) { denied = true; }
                catch (NotSupportedException) { denied = true; }
                Require(denied && !journal.IsPersisted(operation) &&
                    Scalar("SELECT COUNT(*) FROM TABLE_VENTES_ENTETE") == headers &&
                    Scalar("SELECT COUNT(*) FROM TABLE_VENTES_REGLEMENTS") == payments &&
                    Scalar("SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='CSharp-Stock'") == stock &&
                    Scalar("SELECT COUNT(*) FROM TABLE_01") == expectedBasketRows &&
                    Scalar("SELECT COUNT(*) FROM TABLE_VENTES_JOURNAL") == detailCount &&
                    Scalar("SELECT COUNT(*) FROM TABLE_MOUVEMENTS_STOCK") == movementCount &&
                    Scalar("SELECT CL FROM TABLE_NUM") == sequenceValue,
                    "Rejected trusted preparation changed financial/basket/claim state.");
            };
            var correct = Hanouty.Checkout.MariaDb.MariaDbCashCheckoutServices.CreatePostingPort(NewConnection, "01", () => "1234");
            // Preserve an unrelated existing cashier basket, including its values.
            SeedTrustedBasket();
            expectedBasketRows = 1;
            rejected("trusted-occupied", () => correct.Commit(TrustedRequest("trusted-occupied")));
            Require(Scalar("SELECT COUNT(*) FROM TABLE_01 WHERE ID_ARTICLE='CSharp-Stock' AND Qté=2 AND TOTAL_NET=10.50") == 1,
                "Occupied basket content was modified.");
            Sql("DELETE FROM TABLE_01");
            expectedBasketRows = 0;
            // Fail after staging a valid line; the staged row must roll back too.
            rejected("trusted-missing-article", () => correct.Commit(
                TrustedRequest("trusted-missing-article") with { Lines = new[] {
                    new Hanouty.ArchitectureBridge.CheckoutBatchLine("CSharp-Stock", 2),
                    new Hanouty.ArchitectureBridge.CheckoutBatchLine("missing-article", 1) } }));
            var reviewPinReads = 0;
            Hanouty.Checkout.MariaDb.MariaDbCashCheckoutServices.VerifyCashierSession(
                NewConnection, "O'Neil", () => { reviewPinReads++; return "1234"; });
            Require(reviewPinReads == 1 &&
                Scalar("SELECT COUNT(*) FROM TABLE_01") == 0 &&
                Scalar("SELECT COUNT(*) FROM TABLE_VENTES_ENTETE") == headers &&
                Scalar("SELECT COUNT(*) FROM TABLE_VENTES_REGLEMENTS") == payments &&
                Scalar("SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='CSharp-Stock'") == stock &&
                Scalar("SELECT CL FROM TABLE_NUM") == sequenceValue,
                "Real cashier reauthorization must consume PIN once and perform no business writes.");
            rejected("review-wrong-pin", () =>
                Hanouty.Checkout.MariaDb.MariaDbCashCheckoutServices.VerifyCashierSession(
                    NewConnection, "O'Neil", () => "incorrect"));
            rejected("review-wrong-identity", () =>
                Hanouty.Checkout.MariaDb.MariaDbCashCheckoutServices.VerifyCashierSession(
                    NewConnection, "other-cashier", () => "1234"));
            Func<decimal> preview = () =>
                Hanouty.Checkout.MariaDb.MariaDbCashCheckoutServices.ReadCashSaleTotal(
                    NewConnection, TrustedRequest("preview-only").Lines);
            Require(preview() == 10.50m &&
                Hanouty.Checkout.MariaDb.MariaDbCashCheckoutServices.ReadCashSaleTotal(
                    NewConnection, Array.Empty<Hanouty.ArchitectureBridge.CheckoutBatchLine>()) == 0m &&
                Scalar("SELECT COUNT(*) FROM TABLE_01") == 0 &&
                Scalar("SELECT COUNT(*) FROM TABLE_VENTES_ENTETE") == headers &&
                Scalar("SELECT COUNT(*) FROM TABLE_VENTES_REGLEMENTS") == payments &&
                Scalar("SELECT COUNT(*) FROM TABLE_MOUVEMENTS_STOCK") == movementCount &&
                Scalar("SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='CSharp-Stock'") == stock &&
                Scalar("SELECT CL FROM TABLE_NUM") == sequenceValue &&
                !journal.IsPersisted("preview-only"),
                "Read-only authoritative preview staged, claimed or wrote financial/stock state.");
            rejected("preview-duplicate-lines", () =>
                Hanouty.Checkout.MariaDb.MariaDbCashCheckoutServices.ReadCashSaleTotal(
                    NewConnection, new[] {
                        new Hanouty.ArchitectureBridge.CheckoutBatchLine("CSharp-Stock", 1),
                        new Hanouty.ArchitectureBridge.CheckoutBatchLine("CSharp-Stock", 1) }));
            rejected("preview-missing-article", () =>
                Hanouty.Checkout.MariaDb.MariaDbCashCheckoutServices.ReadCashSaleTotal(
                    NewConnection, new[] { new Hanouty.ArchitectureBridge.CheckoutBatchLine("not-present", 1) }));
            var badPin = Hanouty.Checkout.MariaDb.MariaDbCashCheckoutServices.CreatePostingPort(NewConnection, "01", () => "x' OR 1=1 --");
            rejected("trusted-bad-pin", () => badPin.Commit(TrustedRequest("trusted-bad-pin")));
            rejected("trusted-wrong-user", () => correct.Commit(TrustedRequest("trusted-wrong-user", "different")));
            Sql("UPDATE TABLE_PASS SET Catégorie='DISABLED'");
            rejected("review-disabled-category", () =>
                Hanouty.Checkout.MariaDb.MariaDbCashCheckoutServices.VerifyCashierSession(
                    NewConnection, "O'Neil", () => "1234"));
            rejected("trusted-denied-category", () => correct.Commit(TrustedRequest("trusted-denied-category")));
            Sql("UPDATE TABLE_PASS SET Catégorie='UTILISATEUR'");
            Sql("UPDATE TABLE_ARTICLES SET PRIX_V_1=6 WHERE ID_ARTICLE='CSharp-Stock'");
            Require(preview() == 12m, "Price preview must read current authoritative DB prices, not the UI expectation.");
            rejected("trusted-stale-price", () => correct.Commit(TrustedRequest("trusted-stale-price")));
            Sql("UPDATE TABLE_ARTICLES SET PRIX_V_1=5.25 WHERE ID_ARTICLE='CSharp-Stock'");
            rejected("trusted-underpaid", () => correct.Commit(TrustedRequest("trusted-underpaid", amount:10m)));
            Sql("UPDATE TABLE_ARTICLES SET PROMOTION=10 WHERE ID_ARTICLE='CSharp-Stock'");
            rejected("preview-unaccepted-policy", () => preview());
            rejected("trusted-unaccepted-policy", () => correct.Commit(TrustedRequest("trusted-unaccepted-policy")));
            Sql("UPDATE TABLE_ARTICLES SET PROMOTION=0 WHERE ID_ARTICLE='CSharp-Stock'");

            var remote = Hanouty.Checkout.MariaDb.MariaDbCashCheckoutServices.CreatePostingPort(
                () => new MySqlConnection("Server=192.0.2.1;Database=checkout_disposable;Uid=fixture;Pwd=fixture;"),
                "01", () => "1234");
            rejected("trusted-remote", () => remote.Commit(TrustedRequest("trusted-remote")));
            Sql("ALTER TABLE TABLE_PASS ENGINE=MyISAM");
            rejected("trusted-nontransactional", () => correct.Commit(TrustedRequest("trusted-nontransactional")));
            Sql("ALTER TABLE TABLE_PASS ENGINE=InnoDB");
            Sql("CREATE TRIGGER trusted_payment_failure AFTER INSERT ON TABLE_VENTES_REGLEMENTS FOR EACH ROW SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT='injected-after-real-payment'");
            bool paymentFailed = false;
            try { correct.Commit(TrustedRequest("trusted-payment-failure")); }
            catch (MySqlException ex) when (ex.Number == 1644) { paymentFailed = true; }
            finally { Sql("DROP TRIGGER trusted_payment_failure"); }
            Require(paymentFailed && !journal.IsPersisted("trusted-payment-failure") &&
                Scalar("SELECT COUNT(*) FROM TABLE_VENTES_ENTETE") == headers &&
                Scalar("SELECT COUNT(*) FROM TABLE_VENTES_REGLEMENTS") == payments &&
                Scalar("SELECT COUNT(*) FROM TABLE_VENTES_JOURNAL") == detailCount &&
                Scalar("SELECT COUNT(*) FROM TABLE_MOUVEMENTS_STOCK") == movementCount &&
                Scalar("SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='CSharp-Stock'") == stock &&
                Scalar("SELECT COUNT(*) FROM TABLE_01") == expectedBasketRows && Scalar("SELECT CL FROM TABLE_NUM") == sequenceValue,
                "Actual trusted cash payment failure did not roll back the complete transaction.");

            var previousCulture = System.Globalization.CultureInfo.CurrentCulture;
            try
            {
                foreach (string culture in new[] { "fr-FR", "en-US" })
                {
                    System.Globalization.CultureInfo.CurrentCulture = new System.Globalization.CultureInfo(culture);
                    Sql("DELETE FROM TABLE_01");
                    Require(Scalar("SELECT COUNT(*) FROM TABLE_01") == 0, "Cash acceptance must begin with an empty basket.");
                    string operation = "trusted-" + culture;
                    correct.Commit(TrustedRequest(operation));
                    Require(Hanouty.Checkout.MariaDb.MariaDbCashCheckoutServices.CreateOperationJournal(NewConnection).Lookup(operation) ==
                        Hanouty.ArchitectureBridge.CheckoutOperationOutcome.Persisted && journal.IsPersisted(operation) &&
                        Scalar("SELECT COUNT(*) FROM TABLE_VENTES_ENTETE WHERE ID_TICKET='" + operation + "' AND Total_NET=10.50") == 1 &&
                        Scalar("SELECT COUNT(*) FROM TABLE_VENTES_REGLEMENTS WHERE ID_TICKET='" + operation + "' AND MONTANT=10.50 AND CAISSIER='O''Neil'") == 1 &&
                        Scalar("SELECT COUNT(*) FROM TABLE_VENTES_JOURNAL WHERE ID_TICKET='" + operation + "' AND Caissier='O''Neil' AND Article='Lait d''été'") == 1 &&
                        Scalar("SELECT COUNT(*) FROM TABLE_01") == 0,
                        "Real authenticated cash sale failed culture or quoted-identity persistence.");
                    // Verify original-sale evidence using real persisted SQL rows
                    // and the same transaction; do not authorize a refund yet.
                    using (var evidenceDb = NewConnection())
                    {
                        evidenceDb.Open();
                        using (var evidenceTx = evidenceDb.BeginTransaction())
                        {
                            Require(CashReturnOriginalSaleEvidence.ReadExactCashTenderAmount(
                                evidenceDb, evidenceTx, operation) == 10.50m,
                                "Original sale exact-cash evidence differs from persisted payment.");
                            Require(CashReturnOriginalSaleEvidence.ReadOriginalFullQuantityLineAmount(
                                evidenceDb, evidenceTx, operation, "CSharp-Stock", 2m) == 10.50m,
                                "Original full-quantity line must use persisted paid price.");
                            // Price integrity must come from the persisted
                            // original journal, not from the current catalogue.
                            using (var originalPriceTamper = evidenceDb.CreateCommand())
                            {
                                originalPriceTamper.Transaction = evidenceTx;
                                originalPriceTamper.CommandText =
                                    "UPDATE TABLE_VENTES_JOURNAL SET PRIX_V=PRIX_V+0.01 " +
                                    "WHERE ID_TICKET=@id AND ID_ARTICLE='CSharp-Stock'";
                                originalPriceTamper.Parameters.AddWithValue("@id", operation);
                                Require(originalPriceTamper.ExecuteNonQuery() == 1,
                                    "Expected one original journal price to tamper.");
                            }
                            bool mismatchedOriginalPriceRejected = false;
                            try {
                                CashReturnOriginalSaleEvidence.ReadOriginalFullQuantityLineAmount(
                                    evidenceDb, evidenceTx, operation, "CSharp-Stock", 2m);
                            }
                            catch (InvalidOperationException) { mismatchedOriginalPriceRejected = true; }
                            Require(mismatchedOriginalPriceRejected,
                                "Original unit-price mismatch must reject cash refund evidence.");
                            using (var restoreOriginalPrice = evidenceDb.CreateCommand())
                            {
                                restoreOriginalPrice.Transaction = evidenceTx;
                                restoreOriginalPrice.CommandText =
                                    "UPDATE TABLE_VENTES_JOURNAL SET PRIX_V=PRIX_V-0.01 " +
                                    "WHERE ID_TICKET=@id AND ID_ARTICLE='CSharp-Stock'";
                                restoreOriginalPrice.Parameters.AddWithValue("@id", operation);
                                Require(restoreOriginalPrice.ExecuteNonQuery() == 1,
                                    "Expected original journal price restoration.");
                            }
                            bool zeroQuantityRejected = false;
                            try {
                                CashReturnOriginalSaleEvidence.ReadOriginalFullQuantityLineAmount(
                                    evidenceDb, evidenceTx, operation, "CSharp-Stock", 0m);
                            }
                            catch (InvalidOperationException) { zeroQuantityRejected = true; }
                            Require(zeroQuantityRejected,
                                "Zero-quantity original line cannot authorize a refund.");
                            bool overReturnRejected = false;
                            try {
                                CashReturnOriginalSaleEvidence.ReadOriginalFullQuantityLineAmount(
                                    evidenceDb, evidenceTx, operation, "CSharp-Stock", 3m);
                            }
                            catch (InvalidOperationException) { overReturnRejected = true; }
                            Require(overReturnRejected, "Over-return must fail before posting.");
                            bool missingLineRejected = false;
                            try {
                                CashReturnOriginalSaleEvidence.ReadOriginalFullQuantityLineAmount(
                                    evidenceDb, evidenceTx, operation, "missing-article", 2m);
                            }
                            catch (InvalidOperationException) { missingLineRejected = true; }
                            Require(missingLineRejected, "Missing original line must fail before posting.");
                            // Refunds with a discount are outside the first
                            // full-quantity exact-cash slice. Prove this using
                            // persisted journal rows, not caller-supplied prices.
                            using (var discountTamper = evidenceDb.CreateCommand())
                            {
                                discountTamper.Transaction = evidenceTx;
                                discountTamper.CommandText =
                                    "UPDATE TABLE_VENTES_JOURNAL SET Remise=1 " +
                                    "WHERE ID_TICKET=@id AND ID_ARTICLE='CSharp-Stock'";
                                discountTamper.Parameters.AddWithValue("@id", operation);
                                Require(discountTamper.ExecuteNonQuery() == 1,
                                    "Expected exactly one original journal line.");
                            }
                            bool discountedOriginalRejected = false;
                            try {
                                CashReturnOriginalSaleEvidence.ReadOriginalFullQuantityLineAmount(
                                    evidenceDb, evidenceTx, operation, "CSharp-Stock", 2m);
                            }
                            catch (InvalidOperationException) { discountedOriginalRejected = true; }
                            Require(discountedOriginalRejected,
                                "Discounted original must not enter exact-cash refund slice.");
                            using (var discountRestore = evidenceDb.CreateCommand())
                            {
                                discountRestore.Transaction = evidenceTx;
                                discountRestore.CommandText =
                                    "UPDATE TABLE_VENTES_JOURNAL SET Remise=0 " +
                                    "WHERE ID_TICKET=@id AND ID_ARTICLE='CSharp-Stock'";
                                discountRestore.Parameters.AddWithValue("@id", operation);
                                Require(discountRestore.ExecuteNonQuery() == 1,
                                    "Expected exactly one original journal line to restore.");
                            }
                            foreach (var invalidOriginal in new[] { " " + operation, operation + " ", operation + "\n" })
                            {
                                bool invalidReferenceRejected = false;
                                try {
                                    CashReturnOriginalSaleEvidence.ReadExactCashTenderAmount(
                                        evidenceDb, evidenceTx, invalidOriginal);
                                }
                                catch (InvalidOperationException) { invalidReferenceRejected = true; }
                                Require(invalidReferenceRejected,
                                    "Ambiguous original ticket reference must be rejected before refund.");
                            }
                            Require(decimal.Round(
                                CashReturnOriginalSaleEvidence.ReadExactCashTenderAmount(
                                    evidenceDb, evidenceTx, operation), 2,
                                MidpointRounding.AwayFromZero) == 10.50m,
                                "Original cash refund evidence must be whole-cent MAD.");
                            // Negative/corrupted original header must never qualify
                            // as a refundable sale even if the payment is intact.
                            using (var corruptHeader = evidenceDb.CreateCommand())
                            {
                                corruptHeader.Transaction = evidenceTx;
                                corruptHeader.CommandText =
                                    "UPDATE TABLE_VENTES_ENTETE SET Total_NET=-10.50 WHERE ID_TICKET=@id";
                                corruptHeader.Parameters.AddWithValue("@id", operation);
                                Require(corruptHeader.ExecuteNonQuery() == 1,
                                    "Expected one disposable original header to corrupt.");
                            }
                            bool invalidHeaderRejected = false;
                            try {
                                CashReturnOriginalSaleEvidence.ReadExactCashTenderAmount(
                                    evidenceDb, evidenceTx, operation);
                            }
                            catch (InvalidOperationException) { invalidHeaderRejected = true; }
                            Require(invalidHeaderRejected,
                                "Negative original header must not qualify for cash refund.");
                            using (var restoreHeader = evidenceDb.CreateCommand())
                            {
                                restoreHeader.Transaction = evidenceTx;
                                restoreHeader.CommandText =
                                    "UPDATE TABLE_VENTES_ENTETE SET Total_NET=10.50 WHERE ID_TICKET=@id";
                                restoreHeader.Parameters.AddWithValue("@id", operation);
                                Require(restoreHeader.ExecuteNonQuery() == 1,
                                    "Expected one disposable original header to restore.");
                            }
                            bool missingOriginalRejected = false;
                            try {
                                CashReturnOriginalSaleEvidence.ReadExactCashTenderAmount(
                                    evidenceDb, evidenceTx, operation + "-missing");
                            }
                            catch (InvalidOperationException) { missingOriginalRejected = true; }
                            Require(missingOriginalRejected,
                                "Missing original sale must not qualify for cash refund.");
                            // A wrong settlement must fail closed even when its
                            // header is valid. Mutate only inside the disposable
                            // transaction and roll it back before the next case.
                            using (var tamper = evidenceDb.CreateCommand())
                            {
                                tamper.Transaction = evidenceTx;
                                tamper.CommandText =
                                    "UPDATE TABLE_VENTES_REGLEMENTS SET MONTANT=MONTANT-0.01 " +
                                    "WHERE ID_TICKET=@id";
                                tamper.Parameters.AddWithValue("@id", operation);
                                Require(tamper.ExecuteNonQuery() == 1,
                                    "Expected exactly one original cash payment.");
                            }
                            bool mismatchedSettlementRejected = false;
                            try {
                                CashReturnOriginalSaleEvidence.ReadExactCashTenderAmount(
                                    evidenceDb, evidenceTx, operation);
                            }
                            catch (InvalidOperationException) { mismatchedSettlementRejected = true; }
                            Require(mismatchedSettlementRejected,
                                "Original header/payment mismatch must reject refund evidence.");
                            // A mixed/unsupported payment mode must never be
                            // accepted as an exact-cash original sale.
                            using (var tamperMode = evidenceDb.CreateCommand())
                            {
                                tamperMode.Transaction = evidenceTx;
                                tamperMode.CommandText =
                                    "UPDATE TABLE_VENTES_REGLEMENTS SET MONTANT=MONTANT+0.01, MODE_P='CARTE' " +
                                    "WHERE ID_TICKET=@id";
                                tamperMode.Parameters.AddWithValue("@id", operation);
                                Require(tamperMode.ExecuteNonQuery() == 1,
                                    "Expected one original payment to change its mode.");
                            }
                            bool nonCashOriginalRejected = false;
                            try {
                                CashReturnOriginalSaleEvidence.ReadExactCashTenderAmount(
                                    evidenceDb, evidenceTx, operation);
                            }
                            catch (InvalidOperationException) { nonCashOriginalRejected = true; }
                            Require(nonCashOriginalRejected,
                                "Non-cash original settlement must reject cash return evidence.");
                            evidenceTx.Rollback();
                        }
                    }
                    stock -= 2;
                    Require(Scalar("SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='CSharp-Stock'") == stock,
                        "Real trusted sale did not update stock exactly once.");
                    correct.Commit(TrustedRequest(operation));
                    Require(Scalar("SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='CSharp-Stock'") == stock,
                        "Real trusted duplicate changed stock.");
                }
            }
            finally { System.Globalization.CultureInfo.CurrentCulture = previousCulture; }
            // Real return path: same posting port, existing signed V1 writers,
            // persisted original sale, durable unique consumption, one InnoDB transaction.
            Sql("CREATE TABLE IF NOT EXISTS hanouty_cash_return_consumption (original_ticket_id VARCHAR(64) NOT NULL,return_operation_id VARCHAR(64) NOT NULL,consumed_quantity DECIMAL(16,3) NOT NULL,UNIQUE KEY uq_original (original_ticket_id),UNIQUE KEY uq_return (return_operation_id)) ENGINE=InnoDB");
            var refund = new Hanouty.ArchitectureBridge.AuthorizedCheckoutRequest(
                "refund-fr", "O'Neil", "MAD", true,
                new[] { new Hanouty.ArchitectureBridge.CheckoutBatchLine("CSharp-Stock", 2) },
                new[] { new Hanouty.ArchitectureBridge.CheckoutPayment(Hanouty.ArchitectureBridge.CheckoutPaymentKind.Cash, 10.50m) },
                10.50m, "trusted-fr-FR");
            Sql("UPDATE TABLE_ARTICLES SET PRIX_V_1=99 WHERE ID_ARTICLE='CSharp-Stock'");
            decimal stockBeforeRefund = Scalar("SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='CSharp-Stock'");
            // A trigger that silently alters the durable claim must abort the
            // entire refund before any signed stock/payment/journal is committed.
            Sql("CREATE TRIGGER refund_claim_mutation BEFORE INSERT ON hanouty_cash_return_consumption " +
                "FOR EACH ROW SET NEW.consumed_quantity=NEW.consumed_quantity+1");
            bool mutatedClaimRejected = false;
            try { correct.Commit(refund); }
            catch (InvalidOperationException ex) when (ex.Message.Contains("Persisted cash return consumption claim changed."))
            { mutatedClaimRejected = true; }
            finally { Sql("DROP TRIGGER refund_claim_mutation"); }
            Require(mutatedClaimRejected && !journal.IsPersisted("refund-fr") &&
                Scalar("SELECT COUNT(*) FROM hanouty_cash_return_consumption WHERE original_ticket_id='trusted-fr-FR'") == 0 &&
                Scalar("SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='CSharp-Stock'") == stockBeforeRefund &&
                Scalar("SELECT COUNT(*) FROM TABLE_VENTES_ENTETE WHERE ID_TICKET='refund-fr'") == 0,
                "Mutated durable return claim did not roll back refund and stock.");
            // A corrupted return-operation identity is equally dangerous: the
            // original ticket would be consumed under an unrelated operation.
            // The posting transaction must reject it without touching stock.
            Sql("CREATE TRIGGER refund_claim_identity_mutation BEFORE INSERT ON hanouty_cash_return_consumption " +
                "FOR EACH ROW SET NEW.return_operation_id='corrupted-refund-operation'");
            bool mutatedIdentityRejected = false;
            try { correct.Commit(refund); }
            catch (InvalidOperationException ex) when (ex.Message.Contains("Persisted cash return consumption claim changed."))
            { mutatedIdentityRejected = true; }
            finally { Sql("DROP TRIGGER refund_claim_identity_mutation"); }
            Require(mutatedIdentityRejected && !journal.IsPersisted("refund-fr") &&
                Scalar("SELECT COUNT(*) FROM hanouty_cash_return_consumption WHERE original_ticket_id='trusted-fr-FR'") == 0 &&
                Scalar("SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='CSharp-Stock'") == stockBeforeRefund &&
                Scalar("SELECT COUNT(*) FROM TABLE_VENTES_ENTETE WHERE ID_TICKET='refund-fr'") == 0,
                "Mutated return operation identity did not roll back refund and stock.");
            correct.Commit(refund);
            Require(journal.IsPersisted("refund-fr") &&
                Scalar("SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='CSharp-Stock'") == stockBeforeRefund + 2m &&
                Scalar("SELECT COUNT(*) FROM hanouty_cash_return_consumption WHERE original_ticket_id='trusted-fr-FR' AND return_operation_id='refund-fr' AND consumed_quantity=2") == 1 &&
                Scalar("SELECT COUNT(*) FROM TABLE_VENTES_ENTETE WHERE ID_TICKET='refund-fr' AND Total_NET=-10.50 AND OPERATION='RETOUR REMBOURSEMENT'") == 1 &&
                Scalar("SELECT COUNT(*) FROM TABLE_VENTES_REGLEMENTS WHERE ID_TICKET='refund-fr' AND MONTANT=-10.50 AND MODE_P='ESPECES'") == 1 &&
                Scalar("SELECT COUNT(*) FROM TABLE_VENTES_JOURNAL WHERE ID_TICKET='refund-fr' AND Qté=-2 AND Total_NET=-10.50") == 1,
                "Real cash return did not atomically persist signed header, payment, journal, stock and consumption.");
            correct.Commit(refund); // identical operation ID must be exactly once.
            Require(Scalar("SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='CSharp-Stock'") == stockBeforeRefund + 2m,
                "Duplicate refund operation changed stock.");
            // Rebase the rejection snapshot after the intentionally committed refund.
            // Otherwise a correct rejected return is compared to pre-refund sale totals.
            headers = Scalar("SELECT COUNT(*) FROM TABLE_VENTES_ENTETE");
            payments = Scalar("SELECT COUNT(*) FROM TABLE_VENTES_REGLEMENTS");
            stock = Scalar("SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='CSharp-Stock'");
            detailCount = Scalar("SELECT COUNT(*) FROM TABLE_VENTES_JOURNAL");
            movementCount = Scalar("SELECT COUNT(*) FROM TABLE_MOUVEMENTS_STOCK");
            sequenceValue = Scalar("SELECT CL FROM TABLE_NUM");
            var secondRefund = refund with { OperationId = "refund-different" };
            rejected("refund-same-original-new-operation", () => correct.Commit(secondRefund));
            rejected("refund-over-quantity", () => correct.Commit(refund with { OperationId = "refund-over", Lines = new[] { new Hanouty.ArchitectureBridge.CheckoutBatchLine("CSharp-Stock", 3) }, OriginalTicketId = "trusted-en-US" }));
            rejected("refund-missing-original", () => correct.Commit(refund with { OperationId = "refund-missing", OriginalTicketId = "missing-ticket" }));
            Require(!journal.IsPersisted("refund-different") && !journal.IsPersisted("refund-over") &&
                !journal.IsPersisted("refund-missing"), "Rejected refund left durable operation claim.");
            Sql("CREATE TRIGGER refund_payment_failure AFTER INSERT ON TABLE_VENTES_REGLEMENTS FOR EACH ROW SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT='refund-payment-rollback'");
            bool refundFailed = false;
            try { correct.Commit(refund with { OperationId = "refund-rollback", OriginalTicketId = "trusted-en-US" }); }
            catch (MySqlException ex) when (ex.Number == 1644) { refundFailed = true; }
            finally { Sql("DROP TRIGGER refund_payment_failure"); }
            Require(refundFailed && !journal.IsPersisted("refund-rollback") &&
                Scalar("SELECT COUNT(*) FROM hanouty_cash_return_consumption WHERE original_ticket_id='trusted-en-US'") == 0 &&
                Scalar("SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='CSharp-Stock'") == stockBeforeRefund + 2m &&
                Scalar("SELECT COUNT(*) FROM TABLE_VENTES_ENTETE WHERE ID_TICKET='refund-rollback'") == 0 &&
                Scalar("SELECT COUNT(*) FROM TABLE_VENTES_JOURNAL WHERE ID_TICKET='refund-rollback'") == 0,
                "Injected refund payment failure did not roll back claim, stock and receipt.");
            correct.Commit(refund with { OperationId = "refund-restart", OriginalTicketId = "trusted-en-US" });
            Require(journal.IsPersisted("refund-restart") &&
                Scalar("SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='CSharp-Stock'") == stockBeforeRefund + 4m,
                "Refund after failed transaction did not recover correctly.");
            Console.WriteLine("PASS real full-ticket cash refund, signed SQL, stock restoration, durable exact-once, duplicate, missing, over-return, rollback and restart.");
            // A nontransactional ledger must be rejected BEFORE a durable claim,
            // and must never be reported Persisted by the production journal.
            Sql("ALTER TABLE hanouty_checkout_operations ENGINE=MyISAM");
            try
            {
                bool refusedLedger = false;
                try { correct.Commit(TrustedRequest("trusted-invalid-ledger")); }
                catch (InvalidOperationException) { refusedLedger = true; }
                Require(refusedLedger &&
                    Scalar("SELECT COUNT(*) FROM hanouty_checkout_operations WHERE operation_id='trusted-invalid-ledger'") == 0 &&
                    Hanouty.Checkout.MariaDb.MariaDbCashCheckoutServices.CreateOperationJournal(NewConnection).Lookup("trusted-fr-FR") ==
                        Hanouty.ArchitectureBridge.CheckoutOperationOutcome.Unknown,
                    "Nontransactional ledger was written or falsely reported committed.");
            }
            finally { Sql("ALTER TABLE hanouty_checkout_operations ENGINE=InnoDB"); }
            Require(!journal.IsPersisted("trusted-invalid-ledger"), "Rejected ledger left a durable claim.");
            Console.WriteLine("PASS read-only authoritative price preview, shared posting rounding and no basket/claim/stock mutation.");
            Console.WriteLine("PASS REAL TABLE_PASS authentication + authoritative empty-basket staging; occupied basket preserved; denied PIN/category/stale price/underpayment roll back; quoted cashier/article and fr-FR/en-US exact cash persist once. WPF registration and broader V1 policy remain pending.");
        }

    }
}
