using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Text.Json;
using System.Windows;
using Hanouty.ArchitectureBridge;
using Hanouty.Desktop.Wpf.Presentation;
using MySql.Data.MySqlClient;

namespace Hanouty.Desktop.Bootstrap;

// Executable acceptance only: the cashier entry point and shop schemas are untouched.
internal static class DisposableCashSaleAcceptance
{
    private static string EvidenceDirectory = "";
    private static MySqlConnection Open(CatalogueSettings settings)
    {
        var db = new MySqlConnection(settings.ConnectionString);
        db.Open();
        return db;
    }

    private static void Require(bool value, string message)
    {
        if (!value) throw new InvalidOperationException(message);
    }

    private static void Sql(CatalogueSettings settings, string sql)
    {
        using var db = Open(settings);
        using var command = new MySqlCommand(sql, db);
        command.ExecuteNonQuery();
    }

    private static object Value(CatalogueSettings settings, string sql, string? operation = null)
    {
        using var db = Open(settings);
        using var command = new MySqlCommand(sql, db);
        if (operation is not null) command.Parameters.AddWithValue("@id", operation);
        return command.ExecuteScalar() ?? throw new InvalidOperationException("SQL scalar unavailable.");
    }

    private static decimal Number(CatalogueSettings settings, string sql, string? operation = null) =>
        Convert.ToDecimal(Value(settings, sql, operation), CultureInfo.InvariantCulture);

    private static string Snapshot(CatalogueSettings settings) => string.Join("|", new[] {
        "SELECT COUNT(*) FROM TABLE_VENTES_ENTETE",
        "SELECT COUNT(*) FROM TABLE_VENTES_JOURNAL",
        "SELECT COUNT(*) FROM TABLE_VENTES_REGLEMENTS",
        "SELECT COUNT(*) FROM TABLE_MOUVEMENTS_STOCK",
        "SELECT COUNT(*) FROM hanouty_checkout_operations",
        "SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='W2-Article'",
        "SELECT CL FROM TABLE_NUM", "SELECT COUNT(*) FROM TABLE_01"
    }.Select(q => Number(settings, q).ToString(CultureInfo.InvariantCulture)));

    private static CatalogueHost Host(CatalogueSettings settings, string pin, decimal amount = 5.25m, decimal? expectedTotal = null) =>
        CatalogueHost.CreateFinancial(settings, "01", () => pin,
            new AuthorizedCheckoutPaymentContext("O'Neil", "MAD", false,
                new[] { new CheckoutPayment(CheckoutPaymentKind.Cash, amount) }, expectedTotal ?? amount), null,
            ex => File.AppendAllText(Path.Combine(EvidenceDirectory, "posting-failures.txt"), ex + Environment.NewLine));

    private static void Select(CatalogueHost host)
    {
        host.ViewModel.ScannerText = "CODE'1";
        host.ViewModel.ScanCommand.Execute(null);
        Require(host.ViewModel.ScanFeedback == "Selection accepted" &&
            host.ViewModel.ScannerText == "" && host.Session.PendingCount == 1,
            "Actual WPF scanner command did not stage and acknowledge the real SQL article.");
        Require(host.ViewModel.CanCommit, "Actual contextual Host did not enable test cash command.");
    }

    private static void Seed(CatalogueSettings settings)
    {
        // CREATE (not DROP/REPLACE): a nonempty or previously used fixture fails.
        Sql(settings, """
CREATE TABLE hanouty_checkout_operations (
 operation_id VARCHAR(128) CHARACTER SET ascii COLLATE ascii_bin PRIMARY KEY,
 created_utc TIMESTAMP(6) NOT NULL DEFAULT CURRENT_TIMESTAMP(6)) ENGINE=InnoDB;
CREATE TABLE TABLE_ARTICLES (ID_ARTICLE VARCHAR(64) PRIMARY KEY, STOCK DECIMAL(16,3),
 Code VARCHAR(64),Article VARCHAR(128),Images TEXT,Famille TEXT,PRIX_A DECIMAL(16,3),
 PRIX_MP DECIMAL(16,3),PRIX_V_1 DECIMAL(16,3),TAUX_TVA DECIMAL(16,3),GROUPE TEXT,
 PROMOTION DECIMAL(16,3),PRIX_QTE DECIMAL(16,3)) ENGINE=InnoDB;
CREATE TABLE TABLE_MOUVEMENTS_STOCK (DATES VARCHAR(16),HEURE VARCHAR(16),LIBELLE VARCHAR(128),
 ID_ARTICLE VARCHAR(64),CODE_ARTICLE VARCHAR(64),ARTICLE VARCHAR(128),QUANTITE DECIMAL(16,3)) ENGINE=InnoDB;
CREATE TABLE TABLE_NUM (ID INT NOT NULL PRIMARY KEY,CL INT NOT NULL) ENGINE=InnoDB;
CREATE TABLE TABLE_PASS (ListUser VARCHAR(128),ListPass VARCHAR(256),Catégorie VARCHAR(64)) ENGINE=InnoDB;
CREATE TABLE TABLE_VENTES_ENTETE (ID_TICKET VARCHAR(64) PRIMARY KEY,TICKET TEXT,DATES TEXT,CAISSIER TEXT,ID_CLIENT TEXT,CODE_CLIENT TEXT,CLIENT TEXT,POSTE TEXT,Total_NET DECIMAL(16,3),OPERATION TEXT) ENGINE=InnoDB;
CREATE TABLE TABLE_01 (ID_ARTICLE VARCHAR(64),Code TEXT,Article TEXT,Famille TEXT,PRIX_A DECIMAL(16,3),PRIX_MP DECIMAL(16,3),PRIX_V DECIMAL(16,3),Qté DECIMAL(16,3),Remise DECIMAL(16,3),TOTAL_NET DECIMAL(16,3),TAUX_TVA DECIMAL(16,3),GROUPE TEXT) ENGINE=InnoDB;
CREATE TABLE TABLE_VENTES_JOURNAL (ID_TICKET VARCHAR(64),Ticket TEXT,Dates TEXT,Heure TEXT,ID_ARTICLE VARCHAR(64),Code TEXT,Article TEXT,Famille TEXT,PRIX_A DECIMAL(16,3),PRIX_MP DECIMAL(16,3),PRIX_V DECIMAL(16,3),Qté DECIMAL(16,3),Remise DECIMAL(16,3),Total_NET DECIMAL(16,3),TAUX_TVA DECIMAL(16,3),GROUPE TEXT,Caissier TEXT,Vendeur TEXT,ID_CLIENT TEXT,CODE_CLIENT TEXT,CLIENT TEXT,POSTE TEXT,OPERATION TEXT,NOTES TEXT,NOTES_TYPE_PRIX TEXT,NOTES_MODE_P TEXT) ENGINE=InnoDB;
CREATE TABLE TABLE_VENTES_REGLEMENTS (ID_TICKET VARCHAR(64),TICKET TEXT,DATES TEXT,CAISSIER TEXT,ID_CLIENT TEXT,CODE_CLIENT TEXT,CLIENT TEXT,POSTE TEXT,MONTANT DECIMAL(16,3),MODE_P TEXT,OPERATION TEXT,NOTES_REMARQUE TEXT) ENGINE=InnoDB;
INSERT INTO TABLE_ARTICLES VALUES ('W2-Article',100,'CODE''1','Lait d''été',NULL,'Food',1,1,5.25,20,'G',0,0);
INSERT INTO TABLE_PASS VALUES ('O''Neil','1234','UTILISATEUR');
INSERT INTO TABLE_NUM VALUES (0,1);
""");
        Require(Number(settings, "SELECT COUNT(*) FROM TABLE_01") == 0 &&
            Number(settings, "SELECT COUNT(*) FROM TABLE_VENTES_ENTETE") == 0 &&
            Number(settings, "SELECT COUNT(*) FROM TABLE_VENTES_REGLEMENTS") == 0,
            "Fixture must start without basket, sale or payment.");
    }

    private static void Replay(CatalogueSettings settings, string pin, string operation)
    {
        var before = Snapshot(settings);
        var host = Host(settings, pin);
        try
        {
            Select(host);
            // Explicit stable-ID recovery uses the SAME production Application
            // session, never a new UI-generated ID or direct SQL writer.
            Require(host.Session.Submit(operation) == CheckoutBatchStatus.Committed,
                "Durable duplicate was not acknowledged by real production composition.");
            Require(Snapshot(settings) == before, "Duplicate/restart repeated financial writes.");
        }
        finally { host.Window.Close(); }
    }

    private static void Verify(CatalogueSettings settings, string pin, CatalogueHost host, string evidence)
    {
        Require(host.Window.IsVisible && host.Window.IsLoaded, "Actual financial WPF window did not render.");
        Select(host);
        var originalContext = host.ViewModel.PaymentContext ??
            throw new InvalidOperationException("Host cash context missing.");
        var staged = Snapshot(settings);
        string? rejectedOperation = null;
        foreach (var edited in new[] {
            originalContext with { CashierId = "forged-cashier" },
            originalContext with { RegisterId = "02" },
            originalContext with { CurrencyCode = "EUR" },
            originalContext with { TenderedAmount = 999m },
            originalContext with { TenderCode = "Card" }
        })
        {
            host.ViewModel.PaymentContext = edited;
            host.ViewModel.CommitCommand.Execute(null);
            rejectedOperation ??= host.ViewModel.PendingOperationId;
            Require(host.ViewModel.CommitFeedback == "Cart invalidated — cashier must review" &&
                !host.ViewModel.CheckoutUncertain && host.Session.PendingCount == 1 &&
                host.Session.State == CheckoutCommitState.Ready &&
                rejectedOperation is not null &&
                host.ViewModel.PendingOperationId == rejectedOperation && Snapshot(settings) == staged,
                "Edited UI cashier/register/currency/tender bypassed same-session authorization or changed SQL.");
        }
        // Explicitly restore the captured context after deterministic local
        // rejection, preserving the SAME basket and operation ID (no blind retry).
        host.ViewModel.PaymentContext = originalContext;
        host.ViewModel.CommitCommand.Execute(null);
        Require(host.ViewModel.CommitFeedback == "Checkout committed" && !host.ViewModel.CheckoutUncertain &&
            host.ViewModel.PendingOperationId is null && host.Session.PendingCount == 0,
            "Actual WPF cash command failed: " + host.ViewModel.CommitFeedback +
            "; session=" + host.Session.State + "; pending=" + host.ViewModel.PendingOperationId);
        // Successful UI intentionally clears PendingOperationId. Recover the
        // committed ID from durable SQL, rather than treating that reset as failure.
        Require(Number(settings, "SELECT COUNT(*) FROM hanouty_checkout_operations") == 1,
            "Expected one durable operation.");
        var operation = Convert.ToString(Value(settings, "SELECT operation_id FROM hanouty_checkout_operations"))!;
        Require(Number(settings, "SELECT COUNT(*) FROM TABLE_VENTES_ENTETE WHERE ID_TICKET=@id AND Total_NET=5.25 AND CAISSIER='O''Neil'", operation) == 1 &&
            Number(settings, "SELECT COUNT(*) FROM TABLE_VENTES_JOURNAL WHERE ID_TICKET=@id AND ID_ARTICLE='W2-Article' AND Qté=1 AND Total_NET=5.25 AND Article='Lait d''été'", operation) == 1 &&
            Number(settings, "SELECT COUNT(*) FROM TABLE_VENTES_REGLEMENTS WHERE ID_TICKET=@id AND MONTANT=5.25 AND MODE_P='ESPECES'", operation) == 1 &&
            Number(settings, "SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='W2-Article'") == 99 &&
            Number(settings, "SELECT COUNT(*) FROM TABLE_MOUVEMENTS_STOCK WHERE ID_ARTICLE='W2-Article'") == 1 &&
            Number(settings, "SELECT COUNT(*) FROM TABLE_01") == 0 &&
            Number(settings, "SELECT CL FROM TABLE_NUM") == 2,
            "Real ticket/detail/payment/stock/movement/sequence SQL readback failed.");
        Replay(settings, pin, operation);
        var restart = new ProcessStartInfo(Environment.ProcessPath!) { UseShellExecute = false };
        restart.ArgumentList.Add("--verify-disposable-cash-sale");
        restart.ArgumentList.Add(Path.Combine(evidence, "restart"));
        restart.Environment["HANOUTY_W2_REPLAY_OPERATION"] = operation;
        using (var process = Process.Start(restart) ?? throw new InvalidOperationException("Restart failed."))
        {
            if (!process.WaitForExit(60000)) { process.Kill(true); throw new TimeoutException("Restart acceptance timed out."); }
            Require(process.ExitCode == 0, "Fresh executable process failed duplicate/restart SQL acceptance.");
        }

        void Denied(string scenario, string candidatePin, decimal total = 5.25m)
        {
            var before = Snapshot(settings);
            var denied = Host(settings, candidatePin, total);
            try
            {
                Select(denied);
                denied.ViewModel.CommitCommand.Execute(null);
                Require(Snapshot(settings) == before && denied.ViewModel.CheckoutUncertain &&
                    !denied.ViewModel.CanCommit && denied.Session.State == CheckoutCommitState.OutcomeUnknown,
                    scenario + ": rejected/uncertain command changed SQL or unlocked checkout.");
                denied.ViewModel.ReconcileCommand.Execute(null);
                Require(denied.ViewModel.CommitFeedback.Contains("Sale absent", StringComparison.Ordinal) &&
                    denied.Session.State == CheckoutCommitState.Ready && denied.ViewModel.CheckoutUncertain,
                    scenario + ": verified rollback must reconcile both layers, retaining cashier review lock.");
                var reviewId = denied.ViewModel.PendingOperationId!;
                var pinReads = 0;
                Require(!denied.TryReviewResolvedCheckout(reviewId, CheckoutResolution.Unknown,
                    () => { pinReads++; return pin; }) && pinReads == 0,
                    "Unknown cannot authorize review or request PIN.");
                Require(!denied.TryReviewResolvedCheckout("wrong-operation", CheckoutResolution.Absent,
                    () => { pinReads++; return pin; }) && pinReads == 0,
                    "Unrelated operation cannot authorize review.");
                Require(!denied.TryReviewResolvedCheckout(reviewId, CheckoutResolution.Absent,
                    () => { pinReads++; return "incorrect"; }) && pinReads == 1 &&
                    denied.Session.PendingCount == 1 && Snapshot(settings) == before &&
                    denied.ViewModel.CheckoutUncertain,
                    "Wrong review PIN cleared draft or changed SQL.");
                Require(!denied.Window.ReviewResolvedCheckout(() => "") &&
                    denied.ViewModel.CheckoutUncertain && Snapshot(settings) == before,
                    "Cancelled PIN review must retain UI lock.");
                Require(denied.Window.ReviewResolvedCheckout(() => { pinReads++; return pin; }) &&
                    pinReads == 2 && denied.Session.PendingCount == 0 && Snapshot(settings) == before &&
                    !denied.ViewModel.CheckoutUncertain && denied.ViewModel.PendingOperationId is null,
                    "Verified UI review must clear only the old draft and operation identity.");
                Require(!denied.Window.ReviewResolvedCheckout(() => { pinReads++; return pin; }) &&
                    pinReads == 2, "Reviewed UI operation was authorized twice.");
                denied.ViewModel.CommitCommand.Execute(null);
                Require(Snapshot(settings) == before && denied.ViewModel.PendingOperationId is null,
                    "Reset UI replayed the discarded basket.");

            }
            finally { denied.Window.Close(); }
        }
        Denied("wrong PIN", "incorrect");
        Denied("incorrect tender/expected total", pin, 5m);
        Sql(settings, "UPDATE TABLE_ARTICLES SET PRIX_V_1=6 WHERE ID_ARTICLE='W2-Article'");
        try { Denied("changed authoritative price", pin); }
        finally { Sql(settings, "UPDATE TABLE_ARTICLES SET PRIX_V_1=5.25 WHERE ID_ARTICLE='W2-Article'"); }
        Sql(settings, "CREATE TRIGGER w2_after_payment AFTER INSERT ON TABLE_VENTES_REGLEMENTS FOR EACH ROW SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT='w2-injected-after-payment'");
        try { Denied("actual after-payment failure rollback", pin); }
        finally { Sql(settings, "DROP TRIGGER w2_after_payment"); }

        var beforeUnknown = Snapshot(settings);
        var uncertain = Host(settings, pin);
        try
        {
            Select(uncertain);
            Sql(settings, "ALTER TABLE hanouty_checkout_operations ENGINE=MyISAM");
            uncertain.ViewModel.CommitCommand.Execute(null);
            uncertain.ViewModel.ReconcileCommand.Execute(null);
            Require(uncertain.ViewModel.CheckoutUncertain && !uncertain.ViewModel.CanCommit &&
                uncertain.Session.State == CheckoutCommitState.OutcomeUnknown &&
                Snapshot(settings) == beforeUnknown, "Unknown journal authorized a write or unlocked checkout.");
            var unknownPinReads = 0;
            Require(!uncertain.TryReviewResolvedCheckout(uncertain.ViewModel.PendingOperationId!,
                CheckoutResolution.Absent, () => { unknownPinReads++; return pin; }) &&
                unknownPinReads == 0, "Unknown journal must not be reviewed as absent.");

            Sql(settings, "ALTER TABLE hanouty_checkout_operations ENGINE=InnoDB");
            uncertain.ViewModel.ReconcileCommand.Execute(null);
            Require(uncertain.Session.State == CheckoutCommitState.Ready &&
                uncertain.ViewModel.CheckoutUncertain, "Unknown resolution bypassed explicit cashier review.");
        }
        finally
        {
            Sql(settings, "ALTER TABLE hanouty_checkout_operations ENGINE=InnoDB");
            uncertain.Window.Close();
        }
        // Real SQL Commit succeeds before an injected caller acknowledgement fault.
        // No mock preparation, no-op writer or alternate transaction is used.
        var committedBeforeFault = Number(settings, "SELECT COUNT(*) FROM hanouty_checkout_operations");
        var lostAck = CatalogueHost.CreateFinancial(settings, "01", () => pin,
            new AuthorizedCheckoutPaymentContext("O'Neil", "MAD", false,
                new[] { new CheckoutPayment(CheckoutPaymentKind.Cash, 5.25m) }, 5.25m),
            () => throw new IOException("injected-after-real-commit-acknowledgement"));
        try
        {
            Select(lostAck);
            lostAck.ViewModel.CommitCommand.Execute(null);
            Require(lostAck.ViewModel.CheckoutUncertain && !lostAck.ViewModel.CanCommit &&
                lostAck.Session.State == CheckoutCommitState.OutcomeUnknown &&
                Number(settings, "SELECT COUNT(*) FROM hanouty_checkout_operations") == committedBeforeFault + 1 &&
                Number(settings, "SELECT COUNT(*) FROM TABLE_VENTES_ENTETE") == 2 &&
                Number(settings, "SELECT COUNT(*) FROM TABLE_VENTES_REGLEMENTS") == 2 &&
                Number(settings, "SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='W2-Article'") == 98,
                "Lost acknowledgement did not preserve real SQL commit and UI lock.");
            var committed = Snapshot(settings);
            lostAck.ViewModel.CommitCommand.Execute(null);
            Require(Snapshot(settings) == committed, "Unknown UI blindly repeated a committed sale.");
            lostAck.ViewModel.ReconcileCommand.Execute(null);
            Require(lostAck.ViewModel.CommitFeedback.Contains("Sale persisted", StringComparison.Ordinal) &&
                lostAck.Session.State == CheckoutCommitState.Ready && lostAck.ViewModel.CheckoutUncertain &&
                Snapshot(settings) == committed,
                "Lost acknowledgement failed persisted reconciliation or bypassed cashier review.");
            Require(!lostAck.Window.ReviewResolvedCheckout(() => "incorrect") &&
                lostAck.ViewModel.CheckoutUncertain && Snapshot(settings) == committed,
                "Wrong PIN unlocked persisted review.");
            Require(lostAck.Window.ReviewResolvedCheckout(() => pin) &&
                Snapshot(settings) == committed && !lostAck.ViewModel.CheckoutUncertain &&
                lostAck.ViewModel.PendingOperationId is null && lostAck.Session.PendingCount == 0,
                "Explicit persisted UI review must unlock only after authorization without financial replay.");
            lostAck.ViewModel.CommitCommand.Execute(null);
            Require(Snapshot(settings) == committed,
                "Reviewed persisted sale was repeated from the cleared UI.");

        }
        finally { lostAck.Window.Close(); }

        // V1 cash-change convention: gross positive tender + negative ESPECES
        // change, net equals the authoritative ticket. Fault on the second row
        // proves all writers share the same transaction.
        var beforeChange = Snapshot(settings);
        Sql(settings, "CREATE TRIGGER w2_change_failure AFTER INSERT ON TABLE_VENTES_REGLEMENTS FOR EACH ROW BEGIN IF NEW.MONTANT < 0 THEN SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT='w2-second-payment-row'; END IF; END");
        var failedChange = Host(settings, pin, 10m, 5.25m);
        try
        {
            Select(failedChange);
            failedChange.ViewModel.CommitCommand.Execute(null);
            Require(failedChange.ViewModel.CheckoutUncertain && Snapshot(settings) == beforeChange,
                "Second change-row failure did not roll back the whole financial transaction.");
        }
        finally { failedChange.Window.Close(); Sql(settings, "DROP TRIGGER w2_change_failure"); }

        var changeHost = Host(settings, pin, 10m, 5.25m);
        try
        {
            Select(changeHost);
            changeHost.ViewModel.CommitCommand.Execute(null);
            Require(changeHost.ViewModel.CommitFeedback == "Checkout committed",
                "Cash tender with change did not commit.");
            var changeOperation = Convert.ToString(Value(settings,
                "SELECT ID_TICKET FROM TABLE_VENTES_REGLEMENTS WHERE MONTANT=-4.75"))!;
            Require(Number(settings, "SELECT COUNT(*) FROM TABLE_VENTES_REGLEMENTS WHERE ID_TICKET=@id", changeOperation) == 2 &&
                Number(settings, "SELECT COUNT(*) FROM TABLE_VENTES_REGLEMENTS WHERE ID_TICKET=@id AND MONTANT=10 AND MODE_P='ESPECES'", changeOperation) == 1 &&
                Number(settings, "SELECT COUNT(*) FROM TABLE_VENTES_REGLEMENTS WHERE ID_TICKET=@id AND MONTANT=-4.75 AND MODE_P='ESPECES'", changeOperation) == 1 &&
                Number(settings, "SELECT SUM(MONTANT) FROM TABLE_VENTES_REGLEMENTS WHERE ID_TICKET=@id", changeOperation) == 5.25m &&
                Number(settings, "SELECT Total_NET FROM TABLE_VENTES_ENTETE WHERE ID_TICKET=@id", changeOperation) == 5.25m &&
                Number(settings, "SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='W2-Article'") == 97m,
                "V1 tender/change sign, net ticket or stock mismatch.");
            var afterChange = Snapshot(settings);
            var port = Hanouty.Checkout.MariaDb.MariaDbCashCheckoutServices.CreatePostingPort(
                () => new MySqlConnection(settings.ConnectionString), "01", () => pin);
            port.Commit(new AuthorizedCheckoutRequest(changeOperation, "O'Neil", "MAD", false,
                new[] { new CheckoutBatchLine("W2-Article", 1) },
                new[] { new CheckoutPayment(CheckoutPaymentKind.Cash, 10m) }, 5.25m));
            Require(Snapshot(settings) == afterChange, "Cash-change duplicate repeated financial writes.");
        }
        finally { changeHost.Window.Close(); }
        File.WriteAllText(Path.Combine(evidence, "w2-cash-sale.json"), JsonSerializer.Serialize(new {
            Gate = "real WPF exact-cash slice", Operation = operation, WindowLoaded = true, EditedContextRejected = true, SingleSessionBinding = true,
            ReviewCallbackAuthenticated = true, WrongReviewPinRejected = true,
            UnknownReviewBlocked = true, NoFinancialReplayOnReview = true, ExplicitReviewedUiReset = true, CashChangeSql = true, ChangeRowRollback = true,
            EmptyBasket = true, TicketPaymentStockSql = true, Duplicate = true, ProcessRestart = true,
            WrongPinRejected = true, WrongTotalRejected = true, StalePriceRejected = true,
            AfterPaymentRollback = true, UnknownJournalLocked = true, LostAcknowledgementPersisted = true, Reconciliation = true,
            W2Accepted = false, Remaining = "Initial cashier session entry and broader V1/device parity"
        }));
    }

    public static int Run(string evidenceDirectory)
    {
        EvidenceDirectory = evidenceDirectory;
        Directory.CreateDirectory(evidenceDirectory);
        try
        {
            var settings = CatalogueSettings.FromEnvironment();
            var cs = new MySqlConnectionStringBuilder(settings.ConnectionString);
            Require(Environment.GetEnvironmentVariable("HANOUTY_W2_DISPOSABLE_MARKER") ==
                "I_ACKNOWLEDGE_DISPOSABLE_DB_ONLY" && cs.Server == "127.0.0.1" &&
                cs.Database == "logica_ci" && cs.Port == 3307,
                "W2 requires explicitly disposable 127.0.0.1:3307/logica_ci.");
            var pin = Environment.GetEnvironmentVariable("HANOUTY_W2_TEST_PIN") ??
                throw new InvalidOperationException("Disposable fixture PIN required.");
            var replay = Environment.GetEnvironmentVariable("HANOUTY_W2_REPLAY_OPERATION");
            if (!string.IsNullOrWhiteSpace(replay))
            {
                Replay(settings, pin, replay);
                File.WriteAllText(Path.Combine(evidenceDirectory, "restart.json"),
                    JsonSerializer.Serialize(new { Operation = replay, NoDuplicateWrites = true }));
                return 0;
            }
            Seed(settings);
            var app = new Application { ShutdownMode = ShutdownMode.OnExplicitShutdown };
            var host = Host(settings, pin);
            var result = 1;
            host.Window.ContentRendered += (_, _) =>
            {
                try { Verify(settings, pin, host, evidenceDirectory); result = 0; }
                catch (Exception ex) { File.WriteAllText(Path.Combine(evidenceDirectory, "w2-failure.txt"), ex.ToString()); }
                finally { host.Window.Close(); app.Shutdown(); }
            };
            app.Run(host.Window);
            return result;
        }
        catch (Exception ex)
        {
            File.WriteAllText(Path.Combine(evidenceDirectory, "w2-failure.txt"), ex.ToString());
            return 1;
        }
    }
}
