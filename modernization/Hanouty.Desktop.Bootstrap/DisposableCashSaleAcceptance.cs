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
        "SELECT COUNT(*) FROM hanouty_cash_return_consumption",
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
            $"Actual WPF scanner failed: feedback='{host.ViewModel.ScanFeedback}', scanner='{host.ViewModel.ScannerText}', pending={host.Session.PendingCount}, state={host.Session.State}, catalogue={host.ViewModel.CatalogueAvailable}, cashierActive={host.ViewModel.FinancialSessionActive}, canSelect={host.ViewModel.CanSelectProduct}.");
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
CREATE TABLE hanouty_cash_return_consumption (original_ticket_id VARCHAR(64) NOT NULL PRIMARY KEY, return_operation_id VARCHAR(64) NOT NULL UNIQUE, consumed_quantity DECIMAL(16,3) NOT NULL) ENGINE=InnoDB;
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


    private static void ReviewThroughDialog(CatalogueHost host, string pin, bool confirm, Action? execute = null)
    {
        host.Window.Show();
        System.Windows.Controls.PasswordBox? entered = null;
        Exception? uiFailure = null;
        static IEnumerable<DependencyObject> Descendants(DependencyObject parent)
        {
            foreach (var child in LogicalTreeHelper.GetChildren(parent))
                if (child is DependencyObject item)
                {
                    yield return item;
                    foreach (var nested in Descendants(item)) yield return nested;
                }
        }
        host.Window.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.ApplicationIdle,
            new Action(() => {
                var dialog = Application.Current.Windows.Cast<Window>()
                    .SingleOrDefault(w => w.Owner == host.Window);
                try
                {
                    Require(dialog is not null && dialog.IsVisible, "Cashier PIN review dialog did not render.");
                    entered = Descendants(dialog!).OfType<System.Windows.Controls.PasswordBox>().Single();
                    entered.Password = pin;
                    if (confirm)
                        Descendants(dialog!).OfType<System.Windows.Controls.Button>()
                            .Single(b => b.IsDefault).RaiseEvent(new RoutedEventArgs(System.Windows.Controls.Button.ClickEvent));
                    else dialog!.Close();
                }
                catch (Exception ex) { uiFailure = ex; dialog?.Close(); }
            }));
        if (execute is not null) execute();
        else
        {
            var review = Descendants(host.Window).OfType<System.Windows.Controls.Button>().Single(b =>
                System.Windows.Automation.AutomationProperties.GetName(b) == "Review resolved checkout with cashier PIN");
            Require(review.IsEnabled, "Resolved review button is not enabled.");
            review.RaiseEvent(new RoutedEventArgs(System.Windows.Controls.Button.ClickEvent));
        }
        if (uiFailure is not null) throw new InvalidOperationException("PIN dialog acceptance failed.", uiFailure);
        Require(entered is not null && entered.Password.Length == 0,
            "PIN remained in the password control after review.");
    }


    private static bool CashierEntry(CatalogueHost host, string cashier, string register,
        string tender, decimal expectedTotal, string? pin = null, bool confirm = true,
        Action? duringEntry = null)
    {
        host.Window.Show();
        Exception? failure = null;
        System.Windows.Controls.PasswordBox? pinControl = null;
        static IEnumerable<DependencyObject> Children(DependencyObject root)
        {
            foreach (var child in LogicalTreeHelper.GetChildren(root))
                if (child is DependencyObject item) {
                    yield return item;
                    foreach (var nested in Children(item)) yield return nested;
                }
        }
        var timer = new System.Windows.Threading.DispatcherTimer {
            Interval = TimeSpan.FromMilliseconds(20)
        };
        var expires = DateTime.UtcNow.AddSeconds(8);
        if (pin is not null)
        {
            timer.Tick += (_, _) => {
                var modal = Application.Current.Windows.Cast<Window>()
                    .SingleOrDefault(w => w.Owner == host.Window);
                if (modal is null) return;
                var password = Children(modal).OfType<System.Windows.Controls.PasswordBox>().SingleOrDefault();
                if (password is null) {
                    if (DateTime.UtcNow > expires) { failure = new Exception("PIN modal timeout."); modal.Close(); timer.Stop(); }
                    return;
                }
                try {
                    Require(!host.Window.ShowCashierEntry() && !host.Window.EndFinancialSession(),
                        "PIN modal allowed nested cashier entry/logout.");
                    pinControl = password;
                    password.Password = pin;
                    Children(modal).OfType<System.Windows.Controls.Button>().Single(b => b.IsDefault)
                        .RaiseEvent(new RoutedEventArgs(System.Windows.Controls.Button.ClickEvent));
                }
                catch (Exception ex) { failure = ex; modal.Close(); }
                finally { timer.Stop(); }
            };
            timer.Start();
        }
        host.Window.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.ApplicationIdle,
            new Action(() => {
                var modal = Application.Current.Windows.Cast<Window>()
                    .SingleOrDefault(w => w.Owner == host.Window);
                try {
                    Require(modal is Hanouty.Desktop.Wpf.CashierEntryDialog,
                        "Actual cashier entry dialog did not render.");
                    Require(Children(modal!).OfType<System.Windows.Controls.TextBlock>().Any(t =>
                        t.Text.Contains("Application total (MAD): " + expectedTotal.ToString("F2", CultureInfo.InvariantCulture))),
                        "Dialog displayed a stale/UI-derived total.");
                    System.Windows.Controls.TextBox Field(string name) =>
                        Children(modal!).OfType<System.Windows.Controls.TextBox>().Single(t =>
                            System.Windows.Automation.AutomationProperties.GetName(t) == name);
                    Require(Field("Cash MAD (decimal, no thousands separator)").Text == "",
                        "Tender from an earlier operation was retained.");
                    Require(!host.Window.ShowCashierEntry() && !host.Window.EndFinancialSession(),
                        "Tender modal allowed nested entry/logout.");
                    Field("Cashier identity").Text = cashier;
                    Field("Register identity").Text = register;
                    Field("Cash MAD (decimal, no thousands separator)").Text = tender;
                    duringEntry?.Invoke();
                    if (confirm)
                        Children(modal!).OfType<System.Windows.Controls.Button>().Single(b => b.IsDefault)
                            .RaiseEvent(new RoutedEventArgs(System.Windows.Controls.Button.ClickEvent));
                    else modal!.Close();
                }
                catch (Exception ex) { failure = ex; modal?.Close(); }
            }));
        bool accepted;
        try { accepted = host.Window.ShowCashierEntry(); }
        finally { timer.Stop(); }
        if (failure is not null) throw new InvalidOperationException("Cashier entry UI acceptance failed.", failure);
        if (pin is not null)
            Require(pinControl is not null && pinControl.Password.Length == 0,
                "Expected cashier PIN dialog did not run or retained its credential.");
        return accepted;
    }

    private static void Verify(CatalogueSettings settings, string pin, CatalogueHost host, string evidence)
    {
        Require(host.Window.IsVisible && host.Window.IsLoaded, "Actual financial WPF window did not render.");
        var originalContext = host.ViewModel.PaymentContext ??
            throw new InvalidOperationException("Host cash context missing.");
        var basketBeforeEditedContexts = Snapshot(settings);
        foreach (var edited in new[] {
            originalContext with { CashierId = "forged-cashier" },
            originalContext with { RegisterId = "02" },
            originalContext with { CurrencyCode = "EUR" },
            originalContext with { TenderedAmount = 999m },
            originalContext with { TenderCode = "Card" }
        })
        {
            Select(host);
            var staged = Snapshot(settings);
            host.ViewModel.PaymentContext = edited;
            host.ViewModel.CommitCommand.Execute(null);
            var rejectedOperation = host.ViewModel.PendingOperationId;
            var rejectedSnapshot = Snapshot(settings);
            Require(host.ViewModel.CommitFeedback == "Cart invalidated — cashier must review" &&
                host.ViewModel.CheckoutUncertain && !host.ViewModel.CanCommit &&
                host.Session.PendingCount == 1 && host.Session.State == CheckoutCommitState.Ready &&
                rejectedOperation is not null && rejectedSnapshot == staged,
                $"Edited cashier context was not fail-closed: feedback='{host.ViewModel.CommitFeedback}', uncertain={host.ViewModel.CheckoutUncertain}, pending={host.Session.PendingCount}, state={host.Session.State}, operation='{rejectedOperation}', sqlUnchanged={rejectedSnapshot == staged}.");
            host.ViewModel.CommitCommand.Execute(null);
            Require(host.ViewModel.CheckoutUncertain && !host.ViewModel.CanCommit &&
                host.ViewModel.PendingOperationId == rejectedOperation && Snapshot(settings) == staged,
                "Locked edited-context operation was replayed or changed SQL.");
            host.ViewModel.ReconcileCommand.Execute(null);
            Require(host.ViewModel.ReviewedResolution == CheckoutResolution.Absent &&
                host.ViewModel.CheckoutUncertain && Snapshot(settings) == staged,
                "Rejected edited context must reconcile as absent while remaining locked for cashier review.");
            ReviewThroughDialog(host, pin, true);
            Require(!host.ViewModel.CheckoutUncertain && host.Session.PendingCount == 0 &&
                host.ViewModel.PendingOperationId is null && Snapshot(settings) == basketBeforeEditedContexts,
                "Authenticated UI review failed to discard only the rejected draft.");
            Require(host.TrySetFinancialContext(CashContext(originalContext.TenderedAmount, originalContext.TenderedAmount, originalContext.CashierId)),
                "Fresh cashier authorization could not be issued after reviewed rejection.");
        }
        Select(host);
        Require(host.ViewModel.CanCommit, "Fresh reviewed cashier context did not re-enable checkout.");

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
                Require(!denied.TrySetFinancialContext(new AuthorizedCheckoutPaymentContext("O'Neil", "MAD", false,
                    new[] { new CheckoutPayment(CheckoutPaymentKind.Cash, 10m) }, 5.25m)) &&
                    !denied.TryEndFinancialSession(), "Unknown outcome allowed context/session replacement.");
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
                ReviewThroughDialog(denied, pin, false);
                Require(denied.ViewModel.CheckoutUncertain && Snapshot(settings) == before,
                    "Cancelled PIN review must retain UI lock.");
                ReviewThroughDialog(denied, pin, true);
                Require(pinReads == 1 && denied.Session.PendingCount == 0 && Snapshot(settings) == before &&
                    !denied.ViewModel.CheckoutUncertain && denied.ViewModel.PendingOperationId is null,
                    "Verified UI review must clear only the old draft and operation identity.");
                Require(!denied.Window.ReviewResolvedCheckout(() => { pinReads++; return pin; }) &&
                    pinReads == 1, "Reviewed UI operation was authorized twice.");
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

        CatalogueHost InteractiveHost() => CatalogueHost.CreateInteractiveFinancial(settings, "01",
            new AuthorizedCheckoutPaymentContext("O'Neil", "MAD", false,
                new[] { new CheckoutPayment(CheckoutPaymentKind.Cash, 5.25m) }, 5.25m));
        foreach (var candidate in new[] { (Pin: "incorrect", Confirm: true), (Pin: pin, Confirm: false) })
        {
            var deniedUi = InteractiveHost();
            try
            {
                Select(deniedUi);
                var before = Snapshot(settings);
                ReviewThroughDialog(deniedUi, candidate.Pin, candidate.Confirm,
                    () => deniedUi.ViewModel.CommitCommand.Execute(null));
                Require(Snapshot(settings) == before && deniedUi.ViewModel.CheckoutUncertain &&
                    !deniedUi.ViewModel.CanCommit, "Initial PIN cancel/wrong PIN changed SQL or unlocked session.");
            }
            finally { deniedUi.Window.Close(); }
        }
        var interactive = InteractiveHost();
        try
        {
            Select(interactive);
            ReviewThroughDialog(interactive, pin, true,
                () => interactive.ViewModel.CommitCommand.Execute(null));
            Require(interactive.ViewModel.CommitFeedback == "Checkout committed" &&
                Number(settings, "SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='W2-Article'") == 96m,
                "Fresh masked cashier PIN did not authorize the real financial session.");
            var after = Snapshot(settings);
            interactive.ViewModel.CommitCommand.Execute(null);
            Require(Snapshot(settings) == after, "Interactive session replayed the completed basket.");
        }
        finally { interactive.Window.Close(); }


        // Regression: one Window, one CheckoutSession, different baskets/totals
        // and cashier credentials. No rebuilding Host to hide stale capture.
        AuthorizedCheckoutPaymentContext CashContext(decimal total, decimal tender, string cashier = "O'Neil") =>
            new(cashier, "MAD", false, new[] { new CheckoutPayment(CheckoutPaymentKind.Cash, tender) }, total);
        var originalPayments = new[] { new CheckoutPayment(CheckoutPaymentKind.Cash, 10m) };
        CatalogueHost? lifecycle = null;
        var lifecyclePin = pin;
        var lifecyclePinReads = 0;
        var lifecycleStock = Number(settings, "SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='W2-Article'");
        var lifecycleSales = Number(settings, "SELECT COUNT(*) FROM TABLE_VENTES_ENTETE");
        var lifecycleSequence = Number(settings, "SELECT CL FROM TABLE_NUM");
        lifecycle = CatalogueHost.CreateFinancial(settings, "01", () => {
            lifecyclePinReads++;
            Require(!lifecycle!.TrySetFinancialContext(CashContext(5.25m, 999m)) &&
                !lifecycle.TryEndFinancialSession(), "PIN reentry changed an in-flight context/session.");
            return lifecyclePin;
        }, new AuthorizedCheckoutPaymentContext("O'Neil", "MAD", false, originalPayments, 5.25m));
        try
        {
            var originalWindow = lifecycle.Window;
            var originalSession = lifecycle.Session;
            originalPayments[0] = new CheckoutPayment(CheckoutPaymentKind.Cash, 999m);
            Select(lifecycle);
            Require(!lifecycle.TryEndFinancialSession() &&
                !lifecycle.TrySetFinancialContext(CashContext(5.25m, 10m, "other-cashier")),
                "A staged basket was abandoned or transferred to another cashier.");
            lifecycle.ViewModel.CommitCommand.Execute(null);
            Require(lifecycle.ViewModel.CommitFeedback == "Checkout committed" &&
                lifecycle.ViewModel.PaymentContext is null && !lifecycle.ViewModel.CanCommit &&
                lifecyclePinReads == 1, "Completed sale retained reusable payment context.");
            var firstLifecycleId = Convert.ToString(Value(settings,
                "SELECT ID_TICKET FROM TABLE_VENTES_ENTETE WHERE TICKET='" +
                lifecycleSequence.ToString("000000", CultureInfo.InvariantCulture) + "'"))!;
            Require(Number(settings, "SELECT SUM(MONTANT) FROM TABLE_VENTES_REGLEMENTS WHERE ID_TICKET=@id", firstLifecycleId) == 5.25m &&
                Number(settings, "SELECT COUNT(*) FROM TABLE_VENTES_REGLEMENTS WHERE ID_TICKET=@id AND MONTANT=10", firstLifecycleId) == 1,
                "Caller-owned payment list changed the frozen first tender.");
            var afterFirst = Snapshot(settings);
            // Select the next basket BEFORE entering the new tender.
            lifecycle.ViewModel.ScannerText = "CODE'1";
            lifecycle.ViewModel.ScanCommand.Execute(null);
            Require(lifecycle.Session.PendingCount == 1 && !lifecycle.ViewModel.CanCommit,
                "Next basket must require a fresh explicit payment context.");
            lifecycle.ViewModel.CommitCommand.Execute(null);
            Require(Snapshot(settings) == afterFirst && lifecycle.ViewModel.PendingOperationId is null,
                "Old tender was reused for the next basket.");
            Require(lifecycle.TrySetFinancialContext(CashContext(10.50m, 20m)),
                "Ready same-cashier basket could not accept its new payment context.");
            lifecycle.ViewModel.ScannerText = "CODE'1";
            lifecycle.ViewModel.ScanCommand.Execute(null);
            lifecycle.ViewModel.CommitCommand.Execute(null);
            var secondLifecycleId = Convert.ToString(Value(settings,
                "SELECT ID_TICKET FROM TABLE_VENTES_ENTETE WHERE TICKET='" +
                (lifecycleSequence + 1).ToString("000000", CultureInfo.InvariantCulture) + "'"))!;
            Require(lifecycle.ViewModel.CommitFeedback == "Checkout committed" &&
                lifecycle.ViewModel.PaymentContext is null && lifecyclePinReads == 2 &&
                firstLifecycleId != secondLifecycleId &&
                ReferenceEquals(lifecycle.Window, originalWindow) && ReferenceEquals(lifecycle.Session, originalSession) &&
                Number(settings, "SELECT Total_NET FROM TABLE_VENTES_ENTETE WHERE ID_TICKET=@id", secondLifecycleId) == 10.50m &&
                Number(settings, "SELECT Qté FROM TABLE_VENTES_JOURNAL WHERE ID_TICKET=@id", secondLifecycleId) == 2m &&
                Number(settings, "SELECT COUNT(*) FROM TABLE_VENTES_REGLEMENTS WHERE ID_TICKET=@id AND MONTANT=20", secondLifecycleId) == 1 &&
                Number(settings, "SELECT COUNT(*) FROM TABLE_VENTES_REGLEMENTS WHERE ID_TICKET=@id AND MONTANT=-9.50", secondLifecycleId) == 1 &&
                Number(settings, "SELECT SUM(MONTANT) FROM TABLE_VENTES_REGLEMENTS WHERE ID_TICKET=@id", secondLifecycleId) == 10.50m &&
                Number(settings, "SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='W2-Article'") == lifecycleStock - 3m,
                "Same Host/session reused stale total/tender or lost quantity/operation identity.");

            Require(lifecycle.TryEndFinancialSession() &&
                lifecycle.ViewModel.PaymentContext is null && !lifecycle.ViewModel.CanCommit && !lifecycle.ViewModel.CanSelectProduct,
                "Empty resolved session could not be explicitly ended.");
            Sql(settings, "INSERT INTO TABLE_PASS VALUES ('Second cashier','4321','UTILISATEUR')");
            lifecyclePin = "4321";
            Require(lifecycle.TrySetFinancialContext(CashContext(5.25m, 5.25m, "Second cashier")),
                "New empty session could not accept a different cashier claim.");
            Select(lifecycle);
            var lastContext = lifecycle.ViewModel.PaymentContext;
            lifecycle.ViewModel.CommitCommand.Execute(null);
            Require(lifecycle.ViewModel.CommitFeedback == "Checkout committed" && lifecyclePinReads == 3 &&
                Number(settings, "SELECT COUNT(*) FROM TABLE_VENTES_ENTETE WHERE CAISSIER='Second cashier' AND Total_NET=5.25") == 1 &&
                Number(settings, "SELECT COUNT(*) FROM TABLE_VENTES_ENTETE") == lifecycleSales + 3 &&
                Number(settings, "SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='W2-Article'") == lifecycleStock - 4m,
                "New cashier was not independently authenticated on the same Host.");
            var beforeStaleContext = Snapshot(settings);
            lifecycle.ViewModel.PaymentContext = lastContext;
            lifecycle.ViewModel.CommitCommand.Execute(null);
            Require(Snapshot(settings) == beforeStaleContext && lifecyclePinReads == 3 &&
                lifecycle.ViewModel.CommitFeedback.Contains("invalidated", StringComparison.OrdinalIgnoreCase),
                "Restoring the consumed UI record bypassed the financial context boundary.");
            Require(lifecycle.Session.Scan("CODE'1").Outcome == SelectionOutcome.Selected,
                "Direct session regression could not stage its test article.");
            var directStaleRejected = false;
            try { lifecycle.Session.Submit(Guid.NewGuid().ToString("N")); }
            catch (InvalidOperationException) { directStaleRejected = true; }
            Require(directStaleRejected && Snapshot(settings) == beforeStaleContext &&
                lifecyclePinReads == 3, "Direct Application submission reused a consumed payment context.");
        }
        finally { lifecycle.Window.Close(); }


        // Actual workstation starts signed out. All session/tender input comes
        // through the real dialog registered in the existing composition root.
        var workstation = CatalogueHost.CreateCashierWorkstation(settings, "01");
        try
        {
            var before = Snapshot(settings);
            var stockBefore = Number(settings, "SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='W2-Article'");
            var salesBefore = Number(settings, "SELECT COUNT(*) FROM TABLE_VENTES_ENTETE");
            var sequenceBefore = Number(settings, "SELECT CL FROM TABLE_NUM");
            Require(!workstation.ViewModel.FinancialSessionActive && !workstation.ViewModel.CanSelectProduct &&
                !workstation.ViewModel.CanCommit, "Signed-out workstation enabled checkout.");
            Require(!CashierEntry(workstation, "O'Neil", "01", "0", 0m, confirm: false) &&
                Snapshot(settings) == before, "Cancelled login changed business SQL.");
            Require(!CashierEntry(workstation, "O'Neil", "01", "0", 0m, "incorrect") &&
                !workstation.ViewModel.FinancialSessionActive && Snapshot(settings) == before,
                "Wrong PIN activated signed-out cashier session.");
            Require(CashierEntry(workstation, "O'Neil", "01", "0", 0m, pin) &&
                workstation.ViewModel.FinancialSessionActive && workstation.ViewModel.PaymentContext is null &&
                workstation.ViewModel.CanSelectProduct && !workstation.ViewModel.CanCommit && Snapshot(settings) == before,
                "Authenticated empty session created a dummy financial operation or failed to activate.");

            void Stage(int count) {
                for (int n = 0; n < count; n++) {
                    workstation.ViewModel.ScannerText = "CODE'1";
                    workstation.ViewModel.ScanCommand.Execute(null);
                    Require(workstation.ViewModel.ScanFeedback == "Selection accepted",
                        "Authenticated workstation scan did not reach its single Application basket.");
                }
            }
            Stage(1);
            Require(!workstation.Window.EndFinancialSession(), "Logout abandoned a pending basket.");
            Require(!CashierEntry(workstation, "O'Neil", "02", "10", 5.25m) &&
                !CashierEntry(workstation, "Second cashier", "01", "10", 5.25m) &&
                !CashierEntry(workstation, "O'Neil", "01", "4", 5.25m) &&
                Snapshot(settings) == before, "Register/cashier/underpayment draft bypassed trusted Host.");
            Require(!CashierEntry(workstation, "O'Neil", "01", "10", 5.25m, duringEntry: () =>
                Sql(settings, "UPDATE TABLE_ARTICLES SET PRIX_V_1=6 WHERE ID_ARTICLE='W2-Article'")),
                "Price changed during modal entry but old quote was approved.");
            Sql(settings, "UPDATE TABLE_ARTICLES SET PRIX_V_1=5.25 WHERE ID_ARTICLE='W2-Article'");
            Require(CashierEntry(workstation, "O'Neil", "01", "10", 5.25m) &&
                workstation.ViewModel.CanCommit && Snapshot(settings) == before,
                "Fresh tender entry failed or wrote before payment confirmation.");
            ReviewThroughDialog(workstation, pin, true,
                () => workstation.ViewModel.CommitCommand.Execute(null));
            Require(workstation.ViewModel.CommitFeedback == "Checkout committed" &&
                workstation.ViewModel.PaymentContext is null, "First dialog-driven payment failed.");
            Stage(2);
            Require(!workstation.ViewModel.CanCommit &&
                CashierEntry(workstation, "O'Neil", "01", "20", 10.50m),
                "Second operation did not require/read a new Application total/tender.");
            ReviewThroughDialog(workstation, pin, true,
                () => workstation.ViewModel.CommitCommand.Execute(null));
            var first = Convert.ToString(Value(settings, "SELECT ID_TICKET FROM TABLE_VENTES_ENTETE WHERE TICKET='" +
                sequenceBefore.ToString("000000", CultureInfo.InvariantCulture) + "'"))!;
            var second = Convert.ToString(Value(settings, "SELECT ID_TICKET FROM TABLE_VENTES_ENTETE WHERE TICKET='" +
                (sequenceBefore + 1).ToString("000000", CultureInfo.InvariantCulture) + "'"))!;
            Require(first != second &&
                Number(settings, "SELECT Total_NET FROM TABLE_VENTES_ENTETE WHERE ID_TICKET=@id", first) == 5.25m &&
                Number(settings, "SELECT Total_NET FROM TABLE_VENTES_ENTETE WHERE ID_TICKET=@id", second) == 10.50m &&
                Number(settings, "SELECT COUNT(*) FROM TABLE_VENTES_REGLEMENTS WHERE ID_TICKET=@id AND MONTANT=20", second) == 1 &&
                Number(settings, "SELECT COUNT(*) FROM TABLE_VENTES_REGLEMENTS WHERE ID_TICKET=@id AND MONTANT=-9.5", second) == 1 &&
                Number(settings, "SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='W2-Article'") == stockBefore - 3 &&
                Number(settings, "SELECT COUNT(*) FROM TABLE_VENTES_ENTETE") == salesBefore + 2,
                "Dialog-driven same-Host operations lost quantity, total, change or exact-once identity.");
            Require(workstation.Window.EndFinancialSession() && !workstation.ViewModel.CanSelectProduct &&
                !workstation.ViewModel.CanCommit && workstation.ViewModel.PaymentContext is null,
                "Explicit UI logout failed to invalidate the cashier session.");
            var afterLogout = Snapshot(settings);
            Require(!CashierEntry(workstation, "Second cashier", "01", "0", 0m, "incorrect") &&
                !workstation.ViewModel.FinancialSessionActive && Snapshot(settings) == afterLogout,
                "Logout/login accepted a forged cashier credential.");
            Require(CashierEntry(workstation, "Second cashier", "01", "0", 0m, "4321"),
                "Actual cashier dialog could not reopen/re-authenticate after logout.");
            Stage(1);
            Require(CashierEntry(workstation, "Second cashier", "01", "5.25", 5.25m),
                "Second cashier tender entry failed.");
            ReviewThroughDialog(workstation, "4321", true,
                () => workstation.ViewModel.CommitCommand.Execute(null));
            Require(workstation.ViewModel.CommitFeedback == "Checkout committed" &&
                Number(settings, "SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='W2-Article'") == stockBefore - 4 &&
                Number(settings, "SELECT COUNT(*) FROM TABLE_VENTES_ENTETE") == salesBefore + 3,
                "Reauthenticated cashier sale failed on the same workstation.");
        }
        finally { workstation.Window.Close(); }

        // Exercise the complete production return route on this exact WPF Host + disposable InnoDB database.
        // First inject a failure after the refund payment insert: ticket, payment, stock,
        // operation journal, and the durable original-ticket claim must all roll back.
        var beforeRefundRollback = Snapshot(settings);
        Sql(settings, "CREATE TRIGGER w2_return_after_payment AFTER INSERT ON TABLE_VENTES_REGLEMENTS FOR EACH ROW SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT='w2-injected-return-after-payment'");
        try
        {
            var rejectedReturn = PrepareWpfReturn(settings, pin, operation);
            try
            {
                var refundWasRejected = !rejectedReturn.Window.ConfirmReturnDraft();
                Require(refundWasRejected && Snapshot(settings) == beforeRefundRollback &&
                    Number(settings, "SELECT COUNT(*) FROM hanouty_cash_return_consumption WHERE original_ticket_id=@id", operation) == 0,
                    "Injected WPF return failure did not roll back payment, stock, journal and original-ticket claim.");
            }
            finally { rejectedReturn.Window.Close(); }
        }
        finally { Sql(settings, "DROP TRIGGER w2_return_after_payment"); }

        var beforeFullRefund = Snapshot(settings);
        var stockBeforeFullRefund = Number(settings, "SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='W2-Article'");
        var headersBeforeFullRefund = Number(settings, "SELECT COUNT(*) FROM TABLE_VENTES_ENTETE");
        var journalBeforeFullRefund = Number(settings, "SELECT COUNT(*) FROM TABLE_VENTES_JOURNAL");
        var paymentsBeforeFullRefund = Number(settings, "SELECT COUNT(*) FROM TABLE_VENTES_REGLEMENTS");
        var movementsBeforeFullRefund = Number(settings, "SELECT COUNT(*) FROM TABLE_MOUVEMENTS_STOCK");
        var operationsBeforeFullRefund = Number(settings, "SELECT COUNT(*) FROM hanouty_checkout_operations");
        var refundHost = PrepareWpfReturn(settings, pin, operation);
        try
        {
            Require(refundHost.Window.ConfirmReturnDraft(),
                "Actual WPF full-ticket confirmation did not submit through the production Checkout gate: " +
                refundHost.ViewModel.CommitFeedback + "; session=" + refundHost.Session.State);
            Require(Number(settings, "SELECT COUNT(*) FROM TABLE_VENTES_ENTETE") == headersBeforeFullRefund + 1 &&
                Number(settings, "SELECT COUNT(*) FROM TABLE_VENTES_JOURNAL") == journalBeforeFullRefund + 1 &&
                Number(settings, "SELECT COUNT(*) FROM TABLE_VENTES_REGLEMENTS") == paymentsBeforeFullRefund + 1 &&
                Number(settings, "SELECT COUNT(*) FROM TABLE_MOUVEMENTS_STOCK") == movementsBeforeFullRefund + 1 &&
                Number(settings, "SELECT COUNT(*) FROM hanouty_checkout_operations") == operationsBeforeFullRefund + 1 &&
                Number(settings, "SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='W2-Article'") == stockBeforeFullRefund + 1 &&
                Number(settings, "SELECT COUNT(*) FROM TABLE_01") == 0,
                "WPF refund SQL readback did not show one atomic ticket/payment/journal/stock operation.");
        }
        finally { refundHost.Window.Close(); }

        var returnOperation = Convert.ToString(Value(settings,
            "SELECT return_operation_id FROM hanouty_cash_return_consumption WHERE original_ticket_id=@id", operation))!;
        Require(Number(settings, "SELECT consumed_quantity FROM hanouty_cash_return_consumption WHERE original_ticket_id=@id", operation) == 1m &&
            Number(settings, "SELECT COUNT(*) FROM hanouty_checkout_operations WHERE operation_id=@id", returnOperation) == 1 &&
            Number(settings, "SELECT COUNT(*) FROM TABLE_VENTES_JOURNAL WHERE ID_TICKET=@id AND ID_ARTICLE='W2-Article'", returnOperation) == 1 &&
            Number(settings, "SELECT COUNT(*) FROM TABLE_VENTES_REGLEMENTS WHERE ID_TICKET=@id AND MODE_P='ESPECES' AND ABS(MONTANT)=5.25", returnOperation) == 1 &&
            Number(settings, "SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='W2-Article'") == stockBeforeFullRefund + 1m,
            "Persisted original lines, exact cash amount, claim and restored stock do not reconcile.");

        // A second cashier UI must not even offer the consumed original receipt.
        var beforeDuplicateRefund = Snapshot(settings);
        var duplicateRefundHost = Host(settings, pin);
        try
        {
            duplicateRefundHost.Window.Show();
            Require(!duplicateRefundHost.Window.SearchOriginalSales(operation) &&
                (duplicateRefundHost.Window.FindName("OriginalSaleResults") as System.Windows.Controls.ListBox)?.Items.Count == 0 &&
                Snapshot(settings) == beforeDuplicateRefund,
                "Already-returned receipt remained available or a second WPF refund changed SQL.");
        }
        finally { duplicateRefundHost.Window.Close(); }

        File.WriteAllText(Path.Combine(evidence, "w2-cash-sale.json"), JsonSerializer.Serialize(new {
            Gate = "real WPF cash workstation", CashierDialogProductionBound = true, TrustedQuoteDisplayed = true, DialogTwoSalesSameHost = true, LogoutLoginUi = true, ModalPriceChangeRejected = true, Operation = operation, WindowLoaded = true, EditedContextRejected = true, SingleSessionBinding = true,
            ReviewCallbackAuthenticated = true, WrongReviewPinRejected = true,
            UnknownReviewBlocked = true, NoFinancialReplayOnReview = true, ExplicitReviewedUiReset = true, PinDialogRenderedAndCleared = true, InitialCashierPinUi = true, InitialPinCancelAndWrongRejected = true, CashChangeSql = true, SameHostDifferentTotals = true, PaymentContextConsumed = true, StaleContextBoundaryRejected = true, DirectSessionStaleRejected = true, ContextFrozenDuringPin = true, CashierSwitchAuthenticated = true, UnknownContextChangeBlocked = true, ChangeRowRollback = true,
            EmptyBasket = true, TicketPaymentStockSql = true, Duplicate = true, ProcessRestart = true,
            WrongPinRejected = true, WrongTotalRejected = true, StalePriceRejected = true,
            AfterPaymentRollback = true, UnknownJournalLocked = true, LostAcknowledgementPersisted = true, Reconciliation = true,
            FullCashReturnThroughWpfUi = true, FullCashReturnSqlReadback = true, FullCashReturnRollback = true, FullCashReturnIdempotency = true,
            W2Accepted = true, Remaining = "Partial returns, mixed tenders, discounts/credit, device parity, and commercial rollout acceptance"
        }));
    }

    private static CatalogueHost PrepareWpfReturn(CatalogueSettings settings, string pin, string originalTicket)
    {
        var host = Host(settings, pin);
        host.Window.Show();
        try
        {
            Require(host.Window.SearchOriginalSales(originalTicket),
                "Actual WPF Host did not find the persisted original cash ticket.");
            var resultList = host.Window.FindName("OriginalSaleResults") as System.Windows.Controls.ListBox ??
                throw new InvalidOperationException("WPF persisted-sale results control is missing.");
            var row = resultList.Items.Cast<OriginalSaleCandidate>()
                .Single(candidate => candidate.SaleId == originalTicket);
            resultList.SelectedItem = row;
            Require(host.Window.SelectOriginalSale(row),
                "Actual WPF Host refused the selected persisted original ticket.");
            return host;
        }
        catch
        {
            host.Window.Close();
            throw;
        }
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
