using System;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows;
using Hanouty.ArchitectureBridge;
using Hanouty.Desktop.Wpf.Presentation;
using MySql.Data.MySqlClient;

namespace Hanouty.Desktop.Bootstrap;

// W2 is a separate, opt-in executable acceptance entry point, never the cashier startup path.
// The fixture is exclusively disposable; missing SQL/schema/authorization is a test failure.
internal static class DisposableCashSaleAcceptance
{
    public static int Run(string evidenceDirectory)
    {
        Directory.CreateDirectory(evidenceDirectory);
        try
        {
            var settings = CatalogueSettings.FromEnvironment();
            var cs = new MySqlConnectionStringBuilder(settings.ConnectionString);
            if (Environment.GetEnvironmentVariable("HANOUTY_W2_DISPOSABLE_MARKER") != "I_ACKNOWLEDGE_DISPOSABLE_DB_ONLY" ||
                cs.Server != "127.0.0.1" || cs.Database != "logica_ci" || cs.Port != 3307)
                throw new InvalidOperationException("W2 requires explicitly disposable 127.0.0.1:3307/logica_ci.");
            var pin = Environment.GetEnvironmentVariable("HANOUTY_W2_TEST_PIN");
            if (string.IsNullOrWhiteSpace(pin))
                throw new InvalidOperationException("W2 test cashier PIN was not provided.");
            var expected = decimal.Parse(Environment.GetEnvironmentVariable("HANOUTY_W2_EXPECTED_TOTAL") ??
                throw new InvalidOperationException("Fixture must provide authoritative expected total."),
                System.Globalization.CultureInfo.InvariantCulture);
            using var db = new MySqlConnection(settings.ConnectionString);
            db.Open();
            long Scalar(string sql)
            {
                using var command = new MySqlCommand(sql, db);
                return Convert.ToInt64(command.ExecuteScalar());
            }
            // An already occupied workstation must never be overwritten by test staging.
            if (Scalar("SELECT COUNT(*) FROM TABLE_XX") != 0)
                throw new InvalidOperationException("W2 fixture is not EMPTY: TABLE_XX contains a cashier basket.");
            if (Scalar("SELECT COUNT(*) FROM hanouty_checkout_operations") != 0)
                throw new InvalidOperationException("W2 fixture has existing operation journal entries.");
            var context = new AuthorizedCheckoutPaymentContext(
                Environment.GetEnvironmentVariable("HANOUTY_W2_CASHIER") ?? "qa-cashier",
                "MAD", false,
                new[] { new CheckoutPayment(CheckoutPaymentKind.Cash, expected) }, expected);
            var app = new Application { ShutdownMode = ShutdownMode.OnMainWindowClose };
            var host = CatalogueHost.CreateFinancial(settings, "01", () => pin, context);
            if (!host.ViewModel.CatalogueAvailable || host.ViewModel.VisibleProducts.Count == 0)
                throw new InvalidOperationException("Real WPF financial catalogue unavailable.");
            var product = host.ViewModel.VisibleProducts.Single(p =>
                p.Id == (Environment.GetEnvironmentVariable("HANOUTY_W2_ARTICLE_ID") ??
                    throw new InvalidOperationException("Fixture article identity required.")));
            host.ViewModel.SelectCommand.Execute(product);
            if (host.ViewModel.ScanFeedback != "Selection accepted" || host.Session.PendingCount != 1)
                throw new InvalidOperationException("WPF SelectCommand did not reach actual checkout session.");
            if (!host.ViewModel.CanCommit)
                throw new InvalidOperationException("Real financial WPF CommitCommand is disabled.");
            host.ViewModel.CommitCommand.Execute(null);
            var operation = host.ViewModel.PendingOperationId;
            if (string.IsNullOrWhiteSpace(operation))
                throw new InvalidOperationException("WPF did not allocate stable operation ID.");
            var journalCount = Scalar("SELECT COUNT(*) FROM hanouty_checkout_operations WHERE operation_id='" +
                MySqlHelper.EscapeString(operation) + "'");
            if (journalCount != 1)
                throw new InvalidOperationException("WPF command did not persist exactly one operation in SQL.");
            File.WriteAllText(Path.Combine(evidenceDirectory, "w2-cash-sale.json"),
                JsonSerializer.Serialize(new { Gate = "W2 partial executable", Operation = operation,
                    RealWpfSelection = true, SqlOperationCount = journalCount, W2Accepted = false }));
            // Header/detail/payment/stock, rollback and Unknown still require verified SQL assertions.
            throw new InvalidOperationException("QA_OWNER W2_NOT_ACCEPTED: journal persisted, but full ticket/payment/stock/rollback/Unknown assertions are not implemented.");
        }
        catch (Exception ex)
        {
            File.WriteAllText(Path.Combine(evidenceDirectory, "w2-failure.txt"), ex.ToString());
            Console.Error.WriteLine(ex);
            return 1;
        }
    }
}
