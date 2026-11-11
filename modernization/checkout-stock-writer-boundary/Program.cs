using System;
using LOGICA.Infrastructure.Checkout;
using MySql.Data.MySqlClient;

namespace LOGICA.Infrastructure.Checkout
{
    internal static class Program
    {
        private static string ConnectionString;
        private static void Require(bool value, string reason)
        {
            if (!value) throw new InvalidOperationException(reason);
        }
        private static MySqlConnection Open()
        {
            var connection = new MySqlConnection(ConnectionString);
            connection.Open();
            return connection;
        }
        private static decimal Scalar(string sql)
        {
            using (var connection = Open())
            using (var command = new MySqlCommand(sql, connection))
                return Convert.ToDecimal(command.ExecuteScalar());
        }
        private static void Main()
        {
            ConnectionString = Environment.GetEnvironmentVariable("STOCK_WRITER_TEST_CONNECTION");
            Require(!String.IsNullOrWhiteSpace(ConnectionString), "Disposable STOCK_WRITER_TEST_CONNECTION is required.");
            var settings = new MySqlConnectionStringBuilder(ConnectionString);
            Require(settings.Database == "stock_writer_disposable" &&
                (settings.Server == "127.0.0.1" || settings.Server == "localhost"),
                "Acceptance is restricted to the disposable loopback stock_writer_disposable schema.");
            using (var connection = Open())
            using (var command = new MySqlCommand(@"
                DROP TABLE IF EXISTS TABLE_MOUVEMENTS_STOCK;
                DROP TABLE IF EXISTS TABLE_ARTICLES;
                CREATE TABLE TABLE_ARTICLES (
                    ID_ARTICLE VARCHAR(64) PRIMARY KEY,
                    STOCK DECIMAL(16,3) NOT NULL
                ) ENGINE=InnoDB;
                CREATE TABLE TABLE_MOUVEMENTS_STOCK (
                    DATES VARCHAR(16), HEURE VARCHAR(16), LIBELLE VARCHAR(128),
                    ID_ARTICLE VARCHAR(64), CODE_ARTICLE VARCHAR(64),
                    ARTICLE VARCHAR(128), QUANTITE DECIMAL(16,3)
                ) ENGINE=InnoDB;
                INSERT INTO TABLE_ARTICLES VALUES ('stock-1',10);", connection))
                command.ExecuteNonQuery();

            // No transaction and wrong-connection transactions must fail before either write.
            using (var connection = Open())
            using (var command = new MySqlCommand())
            {
                bool denied = false;
                try { CheckoutStockWriter.Apply(command, connection, "NO-TX", "stock-1", "B1", "Product", 1m); }
                catch (InvalidOperationException) { denied = true; }
                Require(denied, "Stock write without transaction must be rejected.");
            }
            using (var owner = Open())
            using (var wrong = Open())
            using (var transaction = owner.BeginTransaction())
            using (var command = owner.CreateCommand())
            {
                command.Transaction = transaction;
                bool denied = false;
                try { CheckoutStockWriter.Apply(command, wrong, "WRONG-CONNECTION", "stock-1", "B1", "Product", 1m); }
                catch (InvalidOperationException) { denied = true; }
                Require(denied, "Transaction from a different connection must be rejected.");
                transaction.Rollback();
            }
            Require(Scalar("SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='stock-1'") == 10m,
                "Rejected calls changed stock.");
            Require(Scalar("SELECT COUNT(*) FROM TABLE_MOUVEMENTS_STOCK") == 0,
                "Rejected calls wrote a stock movement.");

            // Sales subtract stock and record a negative movement in the same transaction.
            using (var connection = Open())
            using (var transaction = connection.BeginTransaction())
            using (var command = connection.CreateCommand())
            {
                command.Transaction = transaction;
                CheckoutStockWriter.Apply(command, connection, "SALE-1", "stock-1", "B1", "Product", 2m);
                transaction.Rollback();
            }
            Require(Scalar("SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='stock-1'") == 10m &&
                Scalar("SELECT COUNT(*) FROM TABLE_MOUVEMENTS_STOCK") == 0,
                "Rollback must restore stock and remove movement together.");

            using (var connection = Open())
            using (var transaction = connection.BeginTransaction())
            using (var command = connection.CreateCommand())
            {
                command.Transaction = transaction;
                CheckoutStockWriter.Apply(command, connection, "SALE-2", "stock-1", "B1", "Product", 2m);
                transaction.Commit();
            }
            Require(Scalar("SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='stock-1'") == 8m &&
                Scalar("SELECT COUNT(*) FROM TABLE_MOUVEMENTS_STOCK WHERE ID_ARTICLE='stock-1' AND QUANTITE=-2") == 1,
                "Committed sale must decrement stock and write one negative movement.");

            // A return uses the same signed V1 rule: negative basket quantity restores stock.
            using (var connection = Open())
            using (var transaction = connection.BeginTransaction())
            using (var command = connection.CreateCommand())
            {
                command.Transaction = transaction;
                CheckoutStockWriter.Apply(command, connection, "RETURN-1", "stock-1", "B1", "Product", -1m);
                transaction.Commit();
            }
            Require(Scalar("SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='stock-1'") == 9m &&
                Scalar("SELECT COUNT(*) FROM TABLE_MOUVEMENTS_STOCK WHERE ID_ARTICLE='stock-1' AND QUANTITE=1") == 1,
                "Committed return must restore stock and write one positive movement.");

            using (var connection = Open())
            using (var command = new MySqlCommand(@"
                CREATE TRIGGER reject_test_movement BEFORE INSERT ON TABLE_MOUVEMENTS_STOCK
                FOR EACH ROW BEGIN
                    IF NEW.LIBELLE = 'TICKET | FORCE-FAIL' THEN
                        SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT='intentional disposable test failure';
                    END IF;
                END;", connection))
                command.ExecuteNonQuery();
            using (var connection = Open())
            using (var transaction = connection.BeginTransaction())
            using (var command = connection.CreateCommand())
            {
                command.Transaction = transaction;
                bool failed = false;
                try { CheckoutStockWriter.Apply(command, connection, "FORCE-FAIL", "stock-1", "B1", "Product", 3m); }
                catch (MySqlException) { failed = true; }
                Require(failed, "Injected movement failure must reach the caller.");
                transaction.Rollback();
            }
            Require(Scalar("SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='stock-1'") == 9m &&
                Scalar("SELECT COUNT(*) FROM TABLE_MOUVEMENTS_STOCK") == 2,
                "A failed movement insert must roll back the stock update.");

            bool zeroRejected = false;
            using (var connection = Open())
            using (var transaction = connection.BeginTransaction())
            using (var command = connection.CreateCommand())
            {
                command.Transaction = transaction;
                try { CheckoutStockWriter.Apply(command, connection, "ZERO", "stock-1", "B1", "Product", 0m); }
                catch (InvalidOperationException) { zeroRejected = true; }
                transaction.Rollback();
            }
            Require(zeroRejected, "Zero-quantity stock movements must be rejected.");
            Console.WriteLine("PASS: CheckoutStockWriter uses the same active InnoDB transaction for stock and movement.");
        }
    }
}
