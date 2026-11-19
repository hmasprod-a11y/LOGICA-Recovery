using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Text.Json;
using System.Windows;
using Hanouty.ArchitectureBridge;
using Hanouty.Desktop.Wpf.Presentation;
using Hanouty.Desktop.Wpf;
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
                    .SingleOrDefault(w => w.Owner == host.Window &&
                        Descendants(w).OfType<System.Windows.Controls.PasswordBox>().Any());
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
        Action? duringEntry = null, bool fromPaymentPanel = false)
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
                    if (fromPaymentPanel)
                    {
                        Require(modal!.Title == "Paiement en espèces" &&
                            Field("Cashier identity").IsReadOnly && Field("Cashier identity").Text == cashier &&
                            Field("Register identity").IsReadOnly && Field("Register identity").Text == register,
                            "Payment panel did not preserve the active cashier and register.");
                    }
                    else
                    {
                        Field("Cashier identity").Text = cashier;
                        Field("Register identity").Text = register;
                    }
                    var tenderField = Field("Cash MAD (decimal, no thousands separator)");
                    if (fromPaymentPanel)
                    {
                        bool Displays(string expected) => Children(modal!).OfType<System.Windows.Controls.TextBlock>()
                            .Any(t => t.Text == expected);
                        Require(tenderField.IsReadOnly, "Touch payment unexpectedly required typing.");
                        void Touch(string label) => Children(modal!).OfType<System.Windows.Controls.Button>()
                            .Single(b => Equals(b.Content, label) ||
                                System.Windows.Automation.AutomationProperties.GetName(b) == label)
                            .RaiseEvent(new RoutedEventArgs(System.Windows.Controls.Button.ClickEvent));
                        Touch("Pavé numérique");
                        Touch("4");
                        Touch("Appliquer le montant");
                        Require(Displays($"Montant manquant : {1.25m:N2} MAD"), "Incorrect cash shortfall.");
                        Touch("Reste");
                        Require(Displays($"Monnaie à rendre : {0m:N2} MAD"), "Remainder did not fill the exact amount.");
                        Touch("Pavé numérique");
                        Touch("4");
                        Touch(".");
                        Touch("Appliquer le montant");
                        Require(tenderField.Text == "5.25", "Incomplete numeric draft replaced the payment.");
                        Touch("Fermer le pavé");
                        Touch("Effacer");
                        Touch("5 MAD");
                        Touch("5 MAD");
                        Require(tenderField.Text == tender, "Repeated denomination taps did not accumulate.");
                        Require(Displays($"Monnaie à rendre : {4.75m:N2} MAD"), "Incorrect cash change.");
                    }
                    else
                        tenderField.Text = tender;
                    duringEntry?.Invoke();
                    if (confirm)
                        Children(modal!).OfType<System.Windows.Controls.Button>().Single(b => b.IsDefault)
                            .RaiseEvent(new RoutedEventArgs(System.Windows.Controls.Button.ClickEvent));
                    else modal!.Close();
                }
                catch (Exception ex) { failure = ex; modal?.Close(); }
            }));
        bool accepted;
        try
        {
            if (fromPaymentPanel)
            {
                var button = Children(host.Window).OfType<System.Windows.Controls.Button>().Single(b =>
                    System.Windows.Automation.AutomationProperties.GetName(b) == "Enter sale cash tender");
                Require(button.IsEnabled, "Payment tender button was disabled for the active cashier.");
                button.RaiseEvent(new RoutedEventArgs(System.Windows.Controls.Button.ClickEvent));
                accepted = host.ViewModel.CanCommit;
            }
            else
                accepted = host.Window.ShowCashierEntry();
        }
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
            var reconciledSnapshot = Snapshot(settings);
            Require(host.ViewModel.ReviewedResolution == CheckoutResolution.Absent &&
                host.ViewModel.CheckoutUncertain && reconciledSnapshot == staged,
                $"Rejected-context reconciliation: resolution={host.ViewModel.ReviewedResolution}, uncertain={host.ViewModel.CheckoutUncertain}, pending={host.Session.PendingCount}, snapshotUnchanged={reconciledSnapshot == staged} (before='{staged}', after='{reconciledSnapshot}').");
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
            var emptySessionAccepted = CashierEntry(workstation, "O'Neil", "01", "0", 0m, pin);
            workstation.ViewModel.CommitCommand.Execute(null);
            var emptySessionSnapshot = Snapshot(settings);
            var emptySessionContext = workstation.ViewModel.PaymentContext;
            Require(emptySessionAccepted &&
                workstation.ViewModel.FinancialSessionActive &&
                emptySessionContext?.TenderedAmount == 0m &&
                workstation.ViewModel.PendingOperationId is null &&
                workstation.ViewModel.CanSelectProduct && !workstation.ViewModel.CanCommit &&
                emptySessionSnapshot == before,
                $"Authenticated zero-tender session failed safety: accepted={emptySessionAccepted}, active={workstation.ViewModel.FinancialSessionActive}, tender={emptySessionContext?.TenderedAmount.ToString(CultureInfo.InvariantCulture) ?? "null"}, operation={workstation.ViewModel.PendingOperationId ?? "null"}, canSelect={workstation.ViewModel.CanSelectProduct}, canCommit={workstation.ViewModel.CanCommit}, sqlUnchanged={emptySessionSnapshot == before}.");

            void Stage(int count) {
                for (int n = 0; n < count; n++) {
                    workstation.ViewModel.ScannerText = "CODE'1";
                    workstation.ViewModel.ScanCommand.Execute(null);
                    Require(workstation.ViewModel.ScanFeedback == "Selection accepted",
                        "Authenticated workstation scan did not reach its single Application basket.");
                    var displayedLine = workstation.ViewModel.BasketLines.Single();
                    Require(displayedLine.ArticleId == "W2-Article" &&
                        displayedLine.Quantity == n + 1 && displayedLine.UnitPriceMad == 5.25m,
                        "Cashier basket did not display the actual MariaDB-backed staged quantity and price.");
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
            Require(CashierEntry(workstation, "O'Neil", "01", "10", 5.25m, fromPaymentPanel: true) &&
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

            var twoArticleSequence = Number(settings, "SELECT CL FROM TABLE_NUM");
            var twoArticleSales = Number(settings, "SELECT COUNT(*) FROM TABLE_VENTES_ENTETE");
            var firstStock = Number(settings, "SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='W2-Article'");
            Sql(settings, "INSERT INTO TABLE_ARTICLES VALUES ('W2-Second',15,'W2-SECOND','Second test product',NULL,'Food',1,1,8,20,'G',0,0)");
            workstation.ViewModel.ReloadCatalogue();
            Stage(1);
            var originalLine = workstation.ViewModel.BasketLines.Single();
            Require(workstation.Window.ChangeBasketQuantity(originalLine, 2) &&
                !workstation.Window.ChangeBasketQuantity(originalLine, 3),
                "Cashier basket could not edit the selected quantity or accepted a stale row.");
            workstation.ViewModel.ScannerText = "W2-SECOND";
            workstation.ViewModel.ScanCommand.Execute(null);
            var removableLine = workstation.ViewModel.BasketLines.Single(line => line.ArticleId == "W2-Second");
            Require(workstation.Window.ChangeBasketQuantity(removableLine, 0) &&
                workstation.ViewModel.BasketLines.Count == 1,
                "Cashier basket did not remove the selected line.");
            workstation.ViewModel.ScannerText = "W2-SECOND";
            workstation.ViewModel.ScanCommand.Execute(null);
            var displayed = workstation.ViewModel.BasketLines.ToArray();
            Require(displayed.Length == 2 &&
                displayed.Any(line => line.ArticleId == "W2-Article" && line.Quantity == 2 && line.UnitPriceMad == 5.25m) &&
                displayed.Any(line => line.ArticleId == "W2-Second" && line.Quantity == 1 && line.UnitPriceMad == 8m),
                "Two scans did not show both authoritative basket lines.");
            Require(CashierEntry(workstation, "Second cashier", "01", "20", 18.50m),
                "Cashier dialog did not accept the authoritative total for both articles.");
            ReviewThroughDialog(workstation, "4321", true,
                () => workstation.ViewModel.CommitCommand.Execute(null));
            workstation.ViewModel.CommitCommand.Execute(null);
            var twoArticleTicket = Convert.ToString(Value(settings,
                "SELECT ID_TICKET FROM TABLE_VENTES_ENTETE WHERE TICKET='" +
                twoArticleSequence.ToString("000000", CultureInfo.InvariantCulture) + "'"))!;
            using (var ticketConnection = Open(settings))
            {
                var ticket = LogicaPostedTicket.Read(ticketConnection, twoArticleTicket, "Second cashier", "01");
                Require(ticket is not null && ticket.Total == 18.50m && ticket.Lines.Count == 2 &&
                    ticket.Payments.Any(payment => payment.Amount == 20m) &&
                    ticket.Payments.Any(payment => payment.Amount == -1.50m),
                    "Persisted print data does not preserve the two sale lines, tender and change.");
                Require(ticket!.FormatFrenchThreeColumnIdentity(true).SequenceEqual(new[]
                {
                    "* CAISSIER  : Second cashier.",
                    "* N° TICKET : " + twoArticleSequence.ToString("000000", CultureInfo.InvariantCulture)
                }) && ticket.FormatFrenchThreeColumnIdentity(false).SequenceEqual(new[] { "* CAISSIER  : Second cashier." }),
                    "Receipt identity did not honor the original ticket-number option.");
                var paymentLines = ticket.FormatFrenchThreeColumnCashPayment(
                    amount => amount.ToString("0.00", CultureInfo.InvariantCulture));
                Require(paymentLines.SequenceEqual(new[] { "* ESPECES   : 20.00 DH", "* RENDU     : 1.50 DH" }),
                    "The French three-column ticket did not preserve the cash tender and positive change display.");
                var renderedLines = ticket.FormatFrenchThreeColumnLines(
                    amount => amount.ToString("0.###", CultureInfo.InvariantCulture),
                    amount => amount.ToString("0.00", CultureInfo.InvariantCulture)).ToArray();
                Require(renderedLines.Length == 2 && renderedLines.All(line => line.Length == 43) &&
                    renderedLines.Any(line => line.Substring(7, 27).TrimEnd() == "Lait d'été"),
                    "The persisted ticket did not use the original French three-column layout.");
                Require(LogicaPostedTicket.Read(ticketConnection, twoArticleTicket, "O'Neil", "01") is null &&
                    LogicaPostedTicket.Read(ticketConnection, twoArticleTicket, "Second cashier", "02") is null,
                    "Ticket data escaped its authorized cashier or workstation.");
            }

            Require(Number(settings, "SELECT COUNT(*) FROM TABLE_VENTES_ENTETE") == twoArticleSales + 1 &&
                Number(settings, "SELECT Total_NET FROM TABLE_VENTES_ENTETE WHERE ID_TICKET=@id", twoArticleTicket) == 18.50m &&
                Number(settings, "SELECT COUNT(*) FROM TABLE_VENTES_JOURNAL WHERE ID_TICKET=@id", twoArticleTicket) == 2 &&
                Number(settings, "SELECT COUNT(*) FROM TABLE_VENTES_REGLEMENTS WHERE ID_TICKET=@id AND MONTANT=20", twoArticleTicket) == 1 &&
                Number(settings, "SELECT COUNT(*) FROM TABLE_VENTES_REGLEMENTS WHERE ID_TICKET=@id AND MONTANT=-1.5", twoArticleTicket) == 1 &&
                Number(settings, "SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='W2-Article'") == firstStock - 2 &&
                Number(settings, "SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='W2-Second'") == 14,
                "Two-article cashier sale did not persist exactly one ticket, tender, change and stock update.");
            Sql(settings, "DELETE FROM TABLE_ARTICLES WHERE ID_ARTICLE='W2-Second'");
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

        VerifyCashDrawerClosing(settings, pin);
        VerifyInventoryValidation(settings);
        VerifyPurchaseReceipt(settings);
        VerifyStockIssue(settings);
        VerifyWaitingSale(settings, pin);
        VerifyCataloguePrice(settings);
        VerifyCatalogueImport(settings);
        VerifyCustomerCreditStatement(settings, pin);
        VerifyCustomerSettlementRetry();
        VerifyCustomerSettlementPosting(settings, pin);
        VerifySupplierSettlementPosting(settings, pin);
        VerifyCardPayment(settings, pin);
        VerifyMixedPayment(settings, pin);
        VerifyDailyCashierCycle(settings, pin);
        VerifyInteractiveReturnCycle(settings, pin);

        File.WriteAllText(Path.Combine(evidence, "w2-cash-sale.json"), JsonSerializer.Serialize(new {
            Gate = "real WPF cash workstation", CashierDialogProductionBound = true, TrustedQuoteDisplayed = true, DialogTwoSalesSameHost = true, LogoutLoginUi = true, ModalPriceChangeRejected = true, Operation = operation, WindowLoaded = true, EditedContextRejected = true, SingleSessionBinding = true,
            ReviewCallbackAuthenticated = true, WrongReviewPinRejected = true,
            UnknownReviewBlocked = true, NoFinancialReplayOnReview = true, ExplicitReviewedUiReset = true, PinDialogRenderedAndCleared = true, InitialCashierPinUi = true, InitialPinCancelAndWrongRejected = true, CashChangeSql = true, SameHostDifferentTotals = true, PaymentContextConsumed = true, StaleContextBoundaryRejected = true, DirectSessionStaleRejected = true, ContextFrozenDuringPin = true, CashierSwitchAuthenticated = true, UnknownContextChangeBlocked = true, ChangeRowRollback = true,
            EmptyBasket = true, TicketPaymentStockSql = true, Duplicate = true, ProcessRestart = true,
            WrongPinRejected = true, WrongTotalRejected = true, StalePriceRejected = true,
            AfterPaymentRollback = true, UnknownJournalLocked = true, LostAcknowledgementPersisted = true, Reconciliation = true,
            FullCashReturnThroughWpfUi = true, FullCashReturnSqlReadback = true, FullCashReturnRollback = true, FullCashReturnIdempotency = true,
            CashDrawerSaleSurvivesPrinterFailure = true,
            CardPaymentThroughWpfUi = true, MixedPaymentThroughWpfUi = true, SameSessionCashCardCashAndClosing = true,
            PrintedReceiptReturnLookup = true, RefundLostAcknowledgementReview = true, CashChangeNetRefund = true,
            NextCustomerVisibleTotal = true,
            W2Accepted = true, Remaining = "Partial/card returns, discounts/credit sales, device parity, and commercial rollout acceptance"
        }));
    }


    private static IEnumerable<T> CatalogueControls<T>(DependencyObject parent) where T : DependencyObject
    {
        foreach (var child in LogicalTreeHelper.GetChildren(parent).OfType<DependencyObject>())
        {
            if (child is T control) yield return control;
            foreach (var nested in CatalogueControls<T>(child)) yield return nested;
        }
    }

    private static void TouchCataloguePrice(Window owner, System.Windows.Controls.TextBox field, decimal amount, bool confirm = true)
    {
        Require(field.IsReadOnly && field.IsEnabled, "Catalogue amount still requires a physical keyboard.");
        Exception? failure = null;
        owner.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.ApplicationIdle, new Action(() =>
        {
            var numeric = Application.Current.Windows.OfType<TouchNumericEntryDialog>().SingleOrDefault(window => window.Owner == owner);
            try
            {
                Require(numeric is not null, "Catalogue price did not open its numeric keypad.");
                var buttons = CatalogueControls<System.Windows.Controls.Button>(numeric!).ToArray();
                foreach (var digit in amount.ToString("0.##", CultureInfo.CurrentCulture))
                    buttons.Single(button => Equals(button.Content, digit.ToString()))
                        .RaiseEvent(new RoutedEventArgs(System.Windows.Controls.Button.ClickEvent));
                buttons.Single(button => Equals(button.Content, confirm ? "Appliquer" : "Annuler"))
                    .RaiseEvent(new RoutedEventArgs(System.Windows.Controls.Button.ClickEvent));
            }
            catch (Exception ex) { failure = ex; numeric?.Close(); }
        }));
        field.RaiseEvent(new System.Windows.Input.MouseButtonEventArgs(
            System.Windows.Input.Mouse.PrimaryDevice, 0, System.Windows.Input.MouseButton.Left)
            { RoutedEvent = UIElement.PreviewMouseLeftButtonDownEvent });
        if (failure is not null) throw new InvalidOperationException("Catalogue touch amount failed.", failure);
    }

    private static void VerifyCatalogueVariantChoice(CatalogueHost host, string variantId)
    {
        Exception? failure = null;
        host.Window.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.ApplicationIdle, new Action(() =>
        {
            var dialog = Application.Current.Windows.OfType<CataloguePriceDialog>().SingleOrDefault(window => window.Owner == host.Window);
            try
            {
                Require(dialog is not null, "Variant catalogue lookup did not open.");
                var fields = CatalogueControls<System.Windows.Controls.TextBox>(dialog!).ToArray();
                System.Windows.Controls.TextBox Field(string name) => fields.Single(field =>
                    System.Windows.Automation.AutomationProperties.GetName(field) == name);
                Field("Rechercher un article par nom ou code-barres").Text = "CARD'1";
                CatalogueControls<System.Windows.Controls.Button>(dialog!).Single(button => Equals(button.Content, "Rechercher les articles"))
                    .RaiseEvent(new RoutedEventArgs(System.Windows.Controls.Button.ClickEvent));
                var list = CatalogueControls<System.Windows.Controls.ListBox>(dialog!).Single();
                Require(list.Items.Count == 2 && list.SelectedItem is null &&
                    Field("Identifiant de l’article").Text == "" && !Field("Nouveau prix de vente").IsEnabled,
                    "Shared catalogue barcode silently selected a variant.");
                list.SelectedItem = list.Items.Cast<CataloguePriceEditor.ArticleChoice>().Single(row => row.Id == variantId);
                Require(Field("Identifiant de l’article").Text == variantId &&
                    decimal.Parse(Field("Nouveau prix de vente").Text, CultureInfo.CurrentCulture) == 11.25m,
                    "Explicit catalogue variant selection loaded another identity or price.");
                Field("Rechercher un article par nom ou code-barres").Text = "No such article";
                Require(list.Items.Count == 0 && Field("Identifiant de l’article").Text == "" &&
                    !Field("Nouveau prix de vente").IsEnabled &&
                    !CatalogueControls<System.Windows.Controls.Button>(dialog!).Single(button => Equals(button.Content, "Enregistrer le prix")).IsEnabled,
                    "Editing catalogue query retained an editable stale selection.");
            }
            catch (Exception ex) { failure = ex; }
            finally { dialog?.Close(); }
        }));
        CatalogueControls<System.Windows.Controls.Button>(host.Window).Single(button =>
            System.Windows.Automation.AutomationProperties.GetName(button) == "Open catalogue prices")
            .RaiseEvent(new RoutedEventArgs(System.Windows.Controls.Button.ClickEvent));
        if (failure is not null) throw new InvalidOperationException("Catalogue variant UI acceptance failed.", failure);
    }

    private static void RunCatalogueCardFromWindow(CatalogueSettings settings)
    {
        var host = CatalogueHost.CreateCashierWorkstation(settings, "01");
        host.Window.Show();
        try
        {
            Require(CashierEntry(host, "Test admin", "01", "0", 0m, "6789"), "Catalogue administrator could not sign in.");
            static IEnumerable<T> Controls<T>(DependencyObject parent) where T : DependencyObject
            {
                foreach (var child in LogicalTreeHelper.GetChildren(parent).OfType<DependencyObject>())
                {
                    if (child is T control) yield return control;
                    foreach (var nested in Controls<T>(child)) yield return nested;
                }
            }
            static void Click(System.Windows.Controls.Button button)
            {
                Require(button.IsEnabled, "Catalogue card control is disabled.");
                button.RaiseEvent(new RoutedEventArgs(System.Windows.Controls.Button.ClickEvent));
            }

            var step = 0;
            Exception? failure = null;
            var timer = new System.Windows.Threading.DispatcherTimer { Interval = TimeSpan.FromMilliseconds(75) };
            timer.Tick += (_, _) =>
            {
                timer.Stop();
                try
                {
                    if (step++ == 0)
                    {
                        var dialog = Application.Current.Windows.OfType<CataloguePriceDialog>()
                            .Single(window => window.IsVisible && window.Owner == host.Window);
                        System.Windows.Controls.TextBox Field(string name) =>
                            Controls<System.Windows.Controls.TextBox>(dialog).Single(field =>
                                System.Windows.Automation.AutomationProperties.GetName(field) == name);
                        System.Windows.Controls.Button Button(string text) =>
                            Controls<System.Windows.Controls.Button>(dialog).Single(button => Equals(button.Content, text));
                        foreach (var expander in Controls<System.Windows.Controls.Expander>(dialog)) expander.IsExpanded = true;
                        Field("Nom du nouvel article").Text = "Article d'essai";
                        Field("Code-barres du nouvel article").Text = "CARD'1";
                        System.Windows.Controls.ComboBox Family(string name) =>
                            Controls<System.Windows.Controls.ComboBox>(dialog).Single(field =>
                                System.Windows.Automation.AutomationProperties.GetName(field) == name);
                        var newFamily = Family("Famille du nouvel article");
                        Require(newFamily.Items.Cast<string>().SequenceEqual(new[] { "Food", "Test famille" }),
                            "Catalogue creation did not load LOGICA families.");
                        newFamily.SelectedItem = "Food";
                        TouchCataloguePrice(dialog, Field("Prix du nouvel article"), 9.75m);
                        timer.Start();
                        Click(Button("Créer l’article"));
                        Require(Field("Identifiant de l’article").Text == "ART000001", "Article creation did not display its ID.");
                        Click(Button("Charger la fiche"));
                        Require(Field("Nom de la fiche").Text == "Article d'essai", "Article card did not reload.");
                        Field("Nom de la fiche").Text = "Article corrigé";
                        Field("Description").Text = "Description d'essai";
                        Field("Référence").Text = "REF-1";
                        Field("Unité").Text = "Pièce";
                        Field("Emplacement").Text = "Rayon B";
                        Family("Famille de la fiche").SelectedItem = "Test famille";
                        timer.Start();
                        Click(Button("Enregistrer la fiche"));
                        Require(Controls<System.Windows.Controls.TextBlock>(dialog).Any(text =>
                            text.Text == "Fiche ART000001 enregistrée."), "Article card edit was not confirmed.");
                        Click(Button("Charger la fiche"));
                        Require(Field("Description").Text == "Description d'essai" && Field("Référence").Text == "REF-1" &&
                            Field("Unité").Text == "Pièce" && Field("Emplacement").Text == "Rayon B",
                            "Advanced catalogue fields did not reload from MariaDB.");
                        dialog.Close();
                    }
                    else
                    {
                        var prompt = Application.Current.Windows.Cast<Window>().Single(window =>
                            window.Owner == host.Window && window.IsVisible &&
                            Controls<System.Windows.Controls.PasswordBox>(window).Any());
                        Controls<System.Windows.Controls.PasswordBox>(prompt).Single().Password = "6789";
                        Click(Controls<System.Windows.Controls.Button>(prompt).Single(button => button.IsDefault));
                    }
                }
                catch (Exception ex)
                {
                    failure = ex;
                    foreach (var window in Application.Current.Windows.Cast<Window>()
                        .Where(window => window.Owner == host.Window && window.IsVisible).ToArray().Reverse())
                        window.Close();
                }
            };
            timer.Start();
            try
            {
                Click(Controls<System.Windows.Controls.Button>(host.Window).Single(button =>
                    System.Windows.Automation.AutomationProperties.GetName(button) == "Open catalogue prices"));
            }
            finally { timer.Stop(); }
            if (failure is not null) throw new InvalidOperationException("Catalogue card UI acceptance failed.", failure);
            Require(step == 3, "Catalogue creation and edit did not each request authorization.");
        }
        finally { host.Window.Close(); }
    }

    private static void VerifyCataloguePrice(CatalogueSettings settings)
    {
        Sql(settings, """
            CREATE TABLE IF NOT EXISTS hanouty_catalogue_price_audit (
                ID BIGINT NOT NULL AUTO_INCREMENT PRIMARY KEY,
                ARTICLE_ID VARCHAR(255) NOT NULL,
                ACTOR VARCHAR(255) NOT NULL,
                PREVIOUS_PRICE DECIMAL(19,4) NOT NULL,
                NEW_PRICE DECIMAL(19,4) NOT NULL,
                CHANGED_UTC TIMESTAMP(6) NOT NULL DEFAULT CURRENT_TIMESTAMP(6),
                KEY ix_catalogue_price_article (ARTICLE_ID, ID)
            ) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
            """);
        var editor = new CataloguePriceEditor(settings.ConnectionString);
        Sql(settings, """
            ALTER TABLE TABLE_NUM ADD ARTICLE INT NOT NULL DEFAULT 1;
            CREATE TABLE TABLE_FAMILLES (Famille VARCHAR(128)) ENGINE=InnoDB;
            INSERT INTO TABLE_FAMILLES VALUES ('Food'), ('Test famille');
            ALTER TABLE TABLE_ARTICLES ADD PRIX_V_2 DECIMAL(16,3), ADD DATES DATE, ADD ID INT NOT NULL AUTO_INCREMENT UNIQUE,
                ADD Description VARCHAR(255), ADD Reference VARCHAR(255), ADD Unite VARCHAR(255), ADD Emplacement VARCHAR(255);
            """);
        RunCatalogueCardFromWindow(settings);
        const string id = "ART000001";
        var card = editor.ReadCard(id);
        Require(card.Name == "Article corrigé" && card.Family == "Test famille" &&
            card.Details == new CataloguePriceEditor.CardDetails("Description d'essai", "REF-1", "Pièce", "Rayon B") &&
            Number(settings, "SELECT ARTICLE FROM TABLE_NUM WHERE ID=0") == 2 &&
            Number(settings, "SELECT COUNT(*) FROM TABLE_MOUVEMENTS_STOCK WHERE ID_ARTICLE='ART000001' AND QUANTITE=0") == 1 &&
            editor.Read(id).Amount == 9.75m, "Article controls did not preserve identity, price and opening movement.");
        try
        {
            editor.Create("Duplicated code", "CARD'1", "Food", 1m, "Test admin", "6789");
            throw new InvalidOperationException("Article creation accepted a duplicate barcode.");
        }
        catch (InvalidOperationException ex) when (ex.Message.StartsWith("Identifiant ou code-barres", StringComparison.Ordinal)) { }
        var original = editor.Read("W2-Article");
        var price = original.Amount + 1.25m;
        var before = Snapshot(settings);
        try
        {
            editor.Update(original, price, "Test manager", "5678");
            throw new InvalidOperationException("A non-administrator modified the catalogue price.");
        }
        catch (UnauthorizedAccessException) { }
        Sql(settings, "CREATE TRIGGER test_price_audit_failure BEFORE INSERT ON hanouty_catalogue_price_audit FOR EACH ROW SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT='price rollback'");
        try
        {
            editor.Update(original, price, "Test admin", "6789");
            throw new InvalidOperationException("Catalogue price ignored a failed audit.");
        }
        catch (MySqlException) { }
        finally { Sql(settings, "DROP TRIGGER test_price_audit_failure"); }
        Require(editor.Read("W2-Article") == original, "Failed audit left a price change behind.");

        var host = CatalogueHost.CreateCashierWorkstation(settings, "01");
        host.Window.Show();
        try
        {
            Require(CashierEntry(host, "Test admin", "01", "0", 0m, "6789"), "Price administrator could not sign in.");
            static IEnumerable<T> Controls<T>(DependencyObject parent) where T : DependencyObject
            {
                foreach (var child in LogicalTreeHelper.GetChildren(parent).OfType<DependencyObject>())
                {
                    if (child is T control) yield return control;
                    foreach (var descendant in Controls<T>(child)) yield return descendant;
                }
            }
            static void Click(System.Windows.Controls.Button button)
            {
                Require(button.IsEnabled, "Catalogue price control is disabled.");
                button.RaiseEvent(new RoutedEventArgs(System.Windows.Controls.Button.ClickEvent));
            }
            var step = 0;
            Exception? failure = null;
            var timer = new System.Windows.Threading.DispatcherTimer { Interval = TimeSpan.FromMilliseconds(75) };
            timer.Tick += (_, _) =>
            {
                timer.Stop();
                try
                {
                    if (step++ == 0)
                    {
                        var dialog = Application.Current.Windows.OfType<CataloguePriceDialog>()
                            .Single(window => window.IsVisible && window.Owner == host.Window);
                        System.Windows.Controls.TextBox Field(string name) =>
                            Controls<System.Windows.Controls.TextBox>(dialog).Single(field =>
                                System.Windows.Automation.AutomationProperties.GetName(field) == name);
                        System.Windows.Controls.Button Button(string text) =>
                            Controls<System.Windows.Controls.Button>(dialog).Single(button => Equals(button.Content, text));
                        Field("Rechercher un article par nom ou code-barres").Text = "CODE'1";
                        Controls<System.Windows.Controls.CheckBox>(dialog).Single(box =>
                            System.Windows.Automation.AutomationProperties.GetName(box) == "Recherche exacte du catalogue").IsChecked = true;
                        Click(Button("Rechercher les articles"));
                        var matches = Controls<System.Windows.Controls.ListBox>(dialog).Single();
                        Require(matches.SelectedItem is null && Field("Identifiant de l’article").IsReadOnly,
                            "Catalogue lookup auto-selected or exposed editable internal identity.");
                        matches.SelectedItem = matches.Items.Cast<CataloguePriceEditor.ArticleChoice>().Single(row => row.Id == "W2-Article");
                        Require(decimal.Parse(Field("Nouveau prix de vente").Text, CultureInfo.CurrentCulture) == original.Amount,
                            "Catalogue dialog displayed the wrong starting price.");
                        TouchCataloguePrice(dialog, Field("Nouveau prix de vente"), price + 1m, confirm: false);
                        Require(decimal.Parse(Field("Nouveau prix de vente").Text, CultureInfo.CurrentCulture) == original.Amount,
                            "Cancelling keypad changed the reviewed price.");
                        TouchCataloguePrice(dialog, Field("Nouveau prix de vente"), price);
                        dialog.UpdateLayout();
                        var image = new System.Windows.Media.Imaging.RenderTargetBitmap(
                            (int)Math.Ceiling(dialog.ActualWidth), (int)Math.Ceiling(dialog.ActualHeight),
                            96, 96, System.Windows.Media.PixelFormats.Pbgra32);
                        image.Render(dialog);
                        var encoder = new System.Windows.Media.Imaging.PngBitmapEncoder();
                        encoder.Frames.Add(System.Windows.Media.Imaging.BitmapFrame.Create(image));
                        using (var stream = File.Create(Path.Combine(EvidenceDirectory, "catalogue-search-touch-price.png"))) encoder.Save(stream);
                        timer.Start();
                        Click(Button("Enregistrer le prix"));
                        Require(Controls<System.Windows.Controls.TextBlock>(dialog).Any(text => text.Text.Contains("enregistré")),
                            "Catalogue dialog did not confirm the saved price.");
                        dialog.Close();
                    }
                    else
                    {
                        var prompt = Application.Current.Windows.Cast<Window>().Single(window =>
                            window.Owner == host.Window && window.IsVisible &&
                            Controls<System.Windows.Controls.PasswordBox>(window).Any());
                        Controls<System.Windows.Controls.PasswordBox>(prompt).Single().Password = "6789";
                        Click(Controls<System.Windows.Controls.Button>(prompt).Single(button => button.IsDefault));
                    }
                }
                catch (Exception ex)
                {
                    failure = ex;
                    foreach (var window in Application.Current.Windows.Cast<Window>()
                        .Where(window => window.Owner == host.Window && window.IsVisible).ToArray().Reverse())
                        window.Close();
                }
            };
            timer.Start();
            try
            {
                Click(Controls<System.Windows.Controls.Button>(host.Window).Single(button =>
                    System.Windows.Automation.AutomationProperties.GetName(button) == "Open catalogue prices"));
            }
            finally { timer.Stop(); }
            if (failure is not null) throw new InvalidOperationException("Catalogue price UI acceptance failed.", failure);
            Require(step == 2 && editor.Read("W2-Article").Amount == price && Snapshot(settings) == before &&
                Number(settings, "SELECT COUNT(*) FROM hanouty_catalogue_price_audit WHERE ARTICLE_ID='W2-Article' AND ACTOR='Test admin' AND NEW_PRICE-PREVIOUS_PRICE=1.25") == 1,
                "Catalogue price did not persist with its actor audit or changed stock.");
            host.ViewModel.ScannerText = "CARD'1";
            host.ViewModel.ScanCommand.Execute(null);
            Require(host.ViewModel.BasketLines.Single().ArticleId == "ART000001" &&
                host.ViewModel.BasketLines.Single().UnitPriceMad == 9.75m,
                "Cashier catalogue did not load the newly created article.");
            host.ViewModel.ScannerText = "CODE'1";
            host.ViewModel.ScanCommand.Execute(null);
            Require(host.ViewModel.BasketLines.Single(line => line.ArticleId == "W2-Article").UnitPriceMad == price && host.Window.RefreshTrustedBasketTotal(),
                "Cashier basket did not use the updated catalogue price.");
            try
            {
                editor.Update(original, price + 1m, "Test admin", "6789");
                throw new InvalidOperationException("A stale catalogue price was overwritten.");
            }
            catch (InvalidOperationException ex) when (ex.Message.StartsWith("Le prix ou l’article a changé.", StringComparison.Ordinal)) { }
        }
        finally { host.Window.Close(); }

        var variantId = editor.Create("Article corrigé — bleu", "CARD'1", "Test famille", 11.25m,
            "Test admin", "6789", variantOf: id);
        Require(variantId == "ART000002" && editor.ReadCard(variantId).Barcode == editor.ReadCard(id).Barcode,
            "Variant did not get its own LOGICA identity and shared barcode.");
        Require(editor.Search("CARD'1", exact: true).Articles.Select(row => row.Id).OrderBy(value => value)
                .SequenceEqual(new[] { id, variantId }.OrderBy(value => value)) &&
            editor.Search("corrigé", exact: false).Articles.Any(row => row.Id == id) &&
            editor.Search("' OR 1=1 --", exact: false).Articles.Count == 0,
            "Catalogue name/quoted-barcode search confused variants or interpreted SQL text.");
        try
        {
            Sql(settings, "UPDATE TABLE_ARTICLES SET Article='100%_ literal' WHERE ID_ARTICLE='ART000002'");
            Require(editor.Search("%_", exact: false).Articles.Single().Id == variantId,
                "Catalogue partial search interpreted literal wildcard characters.");
            Sql(settings, "UPDATE TABLE_ARTICLES SET ID_ARTICLE='art000001' WHERE ID_ARTICLE='ART000002'");
            Require(editor.Search("CARD'1", exact: true).Articles.Count == 0,
                "Ambiguous case-colliding catalogue identities were offered for editing.");
        }
        finally
        {
            Sql(settings, "UPDATE TABLE_ARTICLES SET ID_ARTICLE='ART000002',Article='Article corrigé — bleu' WHERE BINARY ID_ARTICLE=BINARY 'ART000002' OR BINARY ID_ARTICLE=BINARY 'art000001'");
        }
        var variantHost = CatalogueHost.CreateCashierWorkstation(settings, "01");
        try
        {
            Require(CashierEntry(variantHost, "Test admin", "01", "0", 0m, "6789"),
                "Variant cashier could not sign in.");
            variantHost.ViewModel.ScannerText = "CARD'1";
            variantHost.ViewModel.ScanCommand.Execute(null);
            Require(variantHost.ViewModel.BasketLines.Count == 0 &&
                variantHost.ViewModel.BarcodeCandidates.Count == 2,
                "Shared barcode silently selected one article.");
            variantHost.ViewModel.SelectedProduct = variantHost.ViewModel.BarcodeCandidates.Single(product => product.Id == variantId);
            variantHost.ViewModel.SelectCommand.Execute(null);
            Require(variantHost.ViewModel.BasketLines.Single().ArticleId == variantId &&
                variantHost.ViewModel.BasketLines.Single().UnitPriceMad == 11.25m,
                "Explicit variant selection did not stage the correct article and price.");
        }
        finally { variantHost.Window.Close(); }
    }

    private static void RunCatalogueImportFromWindow(CatalogueSettings settings, string file)
    {
        var pickerCalls = 0;
        var host = CatalogueHost.CreateCashierWorkstation(settings, "01", _ => { pickerCalls++; return file; });
        host.Window.Show();
        try
        {
            Require(CashierEntry(host, "Test admin", "01", "0", 0m, "6789"), "Catalogue import administrator could not sign in.");
            static IEnumerable<T> Controls<T>(DependencyObject parent) where T : DependencyObject
            {
                foreach (var child in LogicalTreeHelper.GetChildren(parent).OfType<DependencyObject>())
                {
                    if (child is T control) yield return control;
                    foreach (var nested in Controls<T>(child)) yield return nested;
                }
            }
            static void Click(System.Windows.Controls.Button button)
            {
                Require(button.IsEnabled, "Catalogue import control is disabled.");
                button.RaiseEvent(new RoutedEventArgs(System.Windows.Controls.Button.ClickEvent));
            }

            var step = 0;
            Exception? failure = null;
            var timer = new System.Windows.Threading.DispatcherTimer { Interval = TimeSpan.FromMilliseconds(75) };
            timer.Tick += (_, _) =>
            {
                timer.Stop();
                try
                {
                    var windows = Application.Current.Windows.Cast<Window>().Where(window => window.IsVisible).ToArray();
                    switch (step++)
                    {
                        case 0:
                            var dialog = windows.OfType<CataloguePriceDialog>().Single(window => window.Owner == host.Window);
                            var import = Controls<System.Windows.Controls.Button>(dialog).Single(button =>
                                Equals(button.Content, "Importer les articles Excel"));
                            timer.Start();
                            Click(import);
                            Require(Number(settings, "SELECT COUNT(*) FROM TABLE_ARTICLES WHERE Code IN ('000101','000102')") == 0,
                                "Closing the import preview wrote to the catalogue.");
                            timer.Start();
                            Click(import);
                            Require(Controls<System.Windows.Controls.TextBlock>(dialog).Any(text =>
                                text.Text == "2 article(s) importé(s)."), "Catalogue dialog did not confirm the import.");
                            dialog.Close();
                            break;
                        case 1:
                        case 2:
                            var review = windows.Single(window => window.Title == "Vérifier les articles à importer");
                            var grid = Controls<System.Windows.Controls.DataGrid>(review).Single();
                            Require(grid.Items.Count == 2 && Number(settings,
                                "SELECT COUNT(*) FROM TABLE_ARTICLES WHERE Code IN ('000101','000102')") == 0,
                                "Preview did not display the file without changing MariaDB.");
                            if (step == 2) review.Close();
                            else
                            {
                                timer.Start();
                                Click(Controls<System.Windows.Controls.Button>(review).Single(button =>
                                    Equals(button.Content, "Importer 2 article(s)")));
                            }
                            break;
                        case 3:
                            var prompt = windows.Single(window => window.Owner == host.Window &&
                                Controls<System.Windows.Controls.PasswordBox>(window).Any());
                            Require(Number(settings, "SELECT COUNT(*) FROM TABLE_ARTICLES WHERE Code IN ('000101','000102')") == 0,
                                "Import wrote before the administrator PIN was confirmed.");
                            Controls<System.Windows.Controls.PasswordBox>(prompt).Single().Password = "6789";
                            Click(Controls<System.Windows.Controls.Button>(prompt).Single(button => button.IsDefault));
                            break;
                    }
                }
                catch (Exception ex)
                {
                    failure ??= ex;
                    foreach (var window in Application.Current.Windows.Cast<Window>()
                        .Where(window => window.IsVisible && (window.Owner == host.Window ||
                            window.Owner is CataloguePriceDialog)).ToArray().Reverse()) window.Close();
                }
            };
            timer.Start();
            try
            {
                Click(Controls<System.Windows.Controls.Button>(host.Window).Single(button =>
                    System.Windows.Automation.AutomationProperties.GetName(button) == "Open catalogue prices"));
            }
            finally { timer.Stop(); }
            if (failure is not null) throw new InvalidOperationException("Catalogue import UI acceptance failed.", failure);
            Require(step == 4 && pickerCalls == 2, "Catalogue import did not exercise cancellation and approval.");
        }
        finally { host.Window.Close(); }
    }

    private static void VerifyCatalogueImport(CatalogueSettings settings)
    {
        var path = Path.Combine(EvidenceDirectory, "catalogue-import-test.xlsx");
        using (var workbook = new ClosedXML.Excel.XLWorkbook())
        {
            var sheet = workbook.Worksheets.Add("Feuil1");
            var headers = new[] { "Code", "Article", "Famille", "PRIX_A", "PRIX_V", "STOCK" };
            for (var index = 0; index < headers.Length; index++) sheet.Cell(1, index + 1).Value = headers[index];
            sheet.Cell(2, 1).Value = "000101";
            sheet.Cell(2, 2).Value = "Import d'essai";
            sheet.Cell(2, 3).Value = "Food";
            sheet.Cell(2, 4).Value = 4.25;
            sheet.Cell(2, 5).Value = "6,75";
            sheet.Cell(2, 6).Value = 2.5;
            sheet.Cell(3, 1).Value = "000102";
            sheet.Cell(3, 2).Value = "Second import";
            sheet.Cell(3, 3).Value = "Test famille";
            sheet.Cell(3, 4).Value = 7;
            sheet.Cell(3, 5).Value = 11;
            sheet.Cell(3, 6).Value = 0;
            workbook.SaveAs(path);
        }
        var lines = CatalogueWorkbook.Read(path);
        Require(lines.Count == 2 && lines[0].Barcode == "000101" && lines[0].Price == 6.75m &&
            lines[0].Stock == 2.5m, "Workbook import changed a barcode, amount or quantity.");
        var editor = new CataloguePriceEditor(settings.ConnectionString);
        var before = Number(settings, "SELECT ARTICLE FROM TABLE_NUM WHERE ID=0");
        var movements = Number(settings, "SELECT COUNT(*) FROM TABLE_MOUVEMENTS_STOCK");
        Sql(settings, "CREATE TRIGGER test_import_rollback BEFORE INSERT ON TABLE_MOUVEMENTS_STOCK FOR EACH ROW BEGIN IF NEW.CODE_ARTICLE='000102' THEN SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT='import rollback'; END IF; END");
        try
        {
            editor.Import(lines, "Test admin", "6789");
            throw new InvalidOperationException("Catalogue import ignored a second-row failure.");
        }
        catch (MySqlException) { }
        finally { Sql(settings, "DROP TRIGGER test_import_rollback"); }
        Require(Number(settings, "SELECT COUNT(*) FROM TABLE_ARTICLES WHERE Code IN ('000101','000102')") == 0 &&
            Number(settings, "SELECT ARTICLE FROM TABLE_NUM WHERE ID=0") == before &&
            Number(settings, "SELECT COUNT(*) FROM TABLE_MOUVEMENTS_STOCK") == movements,
            "A failed import left a partial catalogue, movement or sequence.");
        RunCatalogueImportFromWindow(settings, path);
        Require(Number(settings, "SELECT COUNT(DISTINCT ID_ARTICLE) FROM TABLE_ARTICLES WHERE Code IN ('000101','000102')") == 2 &&
            Number(settings, "SELECT ARTICLE FROM TABLE_NUM WHERE ID=0") == before + 2 &&
            Number(settings, "SELECT COUNT(*) FROM TABLE_MOUVEMENTS_STOCK") == movements + 2 &&
            Number(settings, "SELECT COUNT(*) FROM TABLE_ARTICLES WHERE Code='000101' AND PRIX_A=4.25 AND PRIX_MP=4.25 AND PRIX_V_1=6.75 AND PRIX_V_2=6.75 AND STOCK=2.5 AND STOCK_INITIAL=2.5 AND TAUX_TVA=20") == 1,
            "Workbook import did not commit stock, price and numbering together.");
    }

    private static void VerifyWaitingSale(CatalogueSettings settings, string pin)
    {
        Sql(settings, """
            ALTER TABLE TABLE_ARTICLES ADD PRINTER TEXT, ADD PRINTER_DUPLICATA TEXT;
            CREATE TABLE TABLE_ATTENTE (
                ID INT AUTO_INCREMENT PRIMARY KEY, Dates TEXT, Heure TEXT, ID_ARTICLE VARCHAR(64), Code TEXT, Article TEXT,
                Famille TEXT, PRIX_A DECIMAL(16,3), PRIX_MP DECIMAL(16,3), PRIX_V DECIMAL(16,3), Qté DECIMAL(16,3),
                Remise DECIMAL(16,3), TOTAL_NET DECIMAL(16,3), Caissier TEXT, TAUX_TVA DECIMAL(16,3), PRINTER TEXT,
                PRINTER_DUPLICATA TEXT, GROUPE TEXT, V BIGINT, POSTE TEXT, ID_CLIENT TEXT, CODE_CLIENT TEXT, CLIENT TEXT
            ) ENGINE=InnoDB;
            """);
        var before = Snapshot(settings);
        var id = LogicaWaitingSale.Save(() => new MySqlConnection(settings.ConnectionString),
            new[] { new CheckoutBatchLine("W2-Article", 2) }, "O'Neil", "01");
        Require(Number(settings, """
            SELECT COUNT(*) FROM TABLE_ATTENTE WHERE V=@id AND ID_ARTICLE='W2-Article'
                AND Caissier='O''Neil' AND POSTE='01' AND Qté=2 AND TOTAL_NET=PRIX_V*2
            """, id) == 1 && Snapshot(settings) == before,
            "Parking a sale did not preserve its LOGICA rows or changed posted sales and stock.");
        MySqlConnection Connect() => new(settings.ConnectionString);
        var parked = LogicaWaitingSale.List(Connect).Single(row => row.Id == id);
        var lines = LogicaWaitingSale.Read(Connect, id);
        Require(lines.Single().Quantity == 2 && parked.Cashier == "O'Neil", "The original waiting sale could not be loaded.");
        Sql(settings, "CREATE TABLE TABLE_02 LIKE TABLE_01");
        var first = Hanouty.Checkout.MariaDb.MariaDbCashCheckoutServices.CreatePostingPort(
            Connect, "01", () => "1234", () => id);
        var second = Hanouty.Checkout.MariaDb.MariaDbCashCheckoutServices.CreatePostingPort(
            Connect, "02", () => "1234", () => id);
        var request = new AuthorizedCheckoutRequest(Guid.NewGuid().ToString("N"), "O'Neil", "MAD", false,
            lines, new[] { new CheckoutPayment(CheckoutPaymentKind.Cash, parked.Total) }, parked.Total);

        try
        {
            first.Commit(request with { ExpectedTotal = parked.Total + 1m });
            throw new Exception("Invalid waiting-sale quote was accepted.");
        }
        catch (InvalidOperationException) { }
        Require(Snapshot(settings) == before && LogicaWaitingSale.Read(Connect, id).Length == 1,
            "Failed settlement consumed the waiting sale or changed the ledger.");

        var nextTicket = Number(settings, "SELECT CL FROM TABLE_NUM WHERE ID=0");
        var host = CatalogueHost.CreateCashierWorkstation(settings, "01");
        try
        {
            Require(CashierEntry(host, "O'Neil", "01", "0", 0m, pin),
                "Waiting sale operator could not sign in.");
            static IEnumerable<DependencyObject> Controls(DependencyObject root)
            {
                foreach (var child in LogicalTreeHelper.GetChildren(root).OfType<DependencyObject>())
                {
                    yield return child;
                    foreach (var descendant in Controls(child)) yield return descendant;
                }
            }
            static void Click(System.Windows.Controls.Button button) =>
                button.RaiseEvent(new RoutedEventArgs(System.Windows.Controls.Button.ClickEvent));

            Exception? restoreFailure = null;
            var restored = false;
            var timer = new System.Windows.Threading.DispatcherTimer { Interval = TimeSpan.FromMilliseconds(50) };
            timer.Tick += (_, _) =>
            {
                timer.Stop();
                var dialog = Application.Current.Windows.Cast<Window>()
                    .SingleOrDefault(window => window.Owner == host.Window && window.IsVisible);
                try
                {
                    Require(dialog?.Title == "Attentes", "Waiting sale list was not shown.");
                    var list = Controls(dialog!).OfType<System.Windows.Controls.ListBox>().Single();
                    list.SelectedItem = list.Items.Cast<LogicaWaitingSale.Waiting>().Single(item => item.Id == id);
                    Click(Controls(dialog!).OfType<System.Windows.Controls.Button>().Single(button => Equals(button.Content, "Reprendre")));
                    restored = true;
                }
                catch (Exception ex) { restoreFailure = ex; dialog?.Close(); }
            };
            timer.Start();
            try
            {
                Click(Controls(host.Window).OfType<System.Windows.Controls.Button>().Single(button => Equals(button.Content, "Attentes")));
            }
            finally { timer.Stop(); }
            Require(restored && restoreFailure is null &&
                host.ViewModel.BasketLines.Single().Quantity == 2 && Snapshot(settings) == before,
                $"Waiting sale UI did not restore the basket. {restoreFailure?.Message}");
            Require(CashierEntry(host, "O'Neil", "01", parked.Total.ToString("0.00", CultureInfo.InvariantCulture), parked.Total),
                "The restored waiting sale did not accept cash tender.");
            ReviewThroughDialog(host, pin, true, () =>
                Controls(host.Window).OfType<System.Windows.Controls.Button>()
                    .Single(button => Equals(System.Windows.Automation.AutomationProperties.GetName(button), "Complete checkout"))
                    .Command.Execute(null));
            Require(host.ViewModel.CommitFeedback == "Checkout committed", "The restored basket was not posted from WPF.");
        }
        finally { host.Window.Close(); }
        var ticketNumber = nextTicket.ToString("000000", CultureInfo.InvariantCulture);
        var postedId = Convert.ToString(Value(settings,
            "SELECT ID_TICKET FROM TABLE_VENTES_ENTETE WHERE TICKET=@id", ticketNumber));
        Require(!string.IsNullOrEmpty(postedId), "No durable ticket was posted for the resumed basket.");
        var posted = Snapshot(settings);
        try
        {
            second.Commit(request with { OperationId = Guid.NewGuid().ToString("N") });
            throw new Exception("A second workstation sold the same waiting basket.");
        }
        catch (InvalidOperationException) { }
        Require(Snapshot(settings) == posted &&
            Number(settings, "SELECT COUNT(*) FROM TABLE_ATTENTE WHERE V=@id", id) == 0 &&
            Number(settings, "SELECT COUNT(*) FROM TABLE_VENTES_ENTETE WHERE ID_TICKET=@id", postedId!) == 1,
            "A waiting sale was not consumed exactly once with its durable ticket.");
    }

    private static void VerifyStockIssue(CatalogueSettings settings)
    {
        Sql(settings, """
            ALTER TABLE TABLE_NUM ADD BS INT NOT NULL DEFAULT 1;
            ALTER TABLE TABLE_SORTIES_ENTETE ADD ID INT UNIQUE, ADD ID_BS VARCHAR(64) UNIQUE, ADD ETAT VARCHAR(32),
                ADD Dates DATE, ADD UTILISATEUR TEXT, ADD CODE_FOURNISSEUR TEXT, ADD FOURNISSEUR TEXT, ADD TYPE TEXT,
                ADD TOTAL_NET_VENTES DECIMAL(16,3), ADD NOTES TEXT;
            CREATE TABLE TABLE_SORTIES_DETAILS (ID_BS VARCHAR(64), ID_ARTICLE VARCHAR(64), Code TEXT, Article TEXT,
                Qté DECIMAL(16,3), ETAT VARCHAR(32), Dates DATE, ID_FOURNISSEUR TEXT, CODE_FOURNISSEUR TEXT, FOURNISSEUR TEXT,
                TYPE TEXT, Prix_A DECIMAL(16,3), Prix_V DECIMAL(16,3), TOTAL_NET_ACHATS DECIMAL(16,3), TOTAL_NET_VENTES DECIMAL(16,3)) ENGINE=InnoDB;
            INSERT INTO TABLE_SORTIES_ENTETE (ID_BS, ETAT) VALUES ('BS-TEST','ENREGISTRER'),('BS-ROLLBACK','ENREGISTRER');
            INSERT INTO TABLE_SORTIES_DETAILS (ID_BS, ID_ARTICLE, Code, Article, Qté, ETAT) VALUES
                ('BS-TEST','W2-Article','CODE''1','Lait d''été',2,'ENREGISTRER'),
                ('BS-ROLLBACK','W2-Article','CODE''1','Lait d''été',2,'ENREGISTRER'),
                ('BS-ROLLBACK','zz-missing','X','Absent',1,'ENREGISTRER');
            """);
        var service = new StockIssueValidation(settings.ConnectionString);
        var before = Number(settings, "SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='W2-Article'");
        var created = service.Create(DateTime.Today, "PERTE", "Test", new Dictionary<string, decimal>
        {
            ["W2-Article"] = 1m
        }, "Test manager", "5678");
        Require(created == "BS000001" && service.Read(created).Single().Quantity == 1m &&
            Number(settings, "SELECT BS FROM TABLE_NUM WHERE ID=0") == 2 &&
            Number(settings, "SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='W2-Article'") == before,
            "Creating a stock issue did not preserve its number, quantity or unposted stock.");
        var reviewed = service.Read("BS-TEST");
        try
        {
            service.Validate("BS-TEST", reviewed, "O'Neil", "1234");
            throw new Exception("Cashier validated a stock issue.");
        }
        catch (UnauthorizedAccessException) { }
        try
        {
            service.Validate("BS-ROLLBACK", service.Read("BS-ROLLBACK"), "Test manager", "5678");
            throw new Exception("Missing article accepted.");
        }
        catch (InvalidOperationException) { }
        Require(Number(settings, "SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='W2-Article'") == before &&
            Number(settings, "SELECT COUNT(*) FROM TABLE_MOUVEMENTS_STOCK WHERE LIBELLE LIKE 'Bon de Sortie | BS-%'") == 0,
            "Refused stock issue left a partial movement.");
        service.Validate("BS-TEST", reviewed, "Test manager", "5678");
        try
        {
            service.Validate("BS-TEST", reviewed, "Test manager", "5678");
            throw new Exception("Duplicate stock issue accepted.");
        }
        catch (InvalidOperationException) { }
        Require(Number(settings, "SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='W2-Article'") == before - 2 &&
            Number(settings, "SELECT COUNT(*) FROM TABLE_MOUVEMENTS_STOCK WHERE LIBELLE='Bon de Sortie | BS-TEST' AND QUANTITE=2") == 1 &&
            Number(settings, "SELECT COUNT(*) FROM TABLE_SORTIES_ENTETE WHERE ID_BS='BS-TEST' AND ETAT='VALIDER'") == 1 &&
            Number(settings, "SELECT COUNT(*) FROM TABLE_SORTIES_DETAILS WHERE ID_BS='BS-TEST' AND ETAT='VALIDER'") == 1,
            "Stock, movement and issue document diverged.");
    }

    private static void VerifyPurchaseReceipt(CatalogueSettings settings)
    {
        Sql(settings, """
            ALTER TABLE TABLE_ARTICLES ADD FOURNISSEUR VARCHAR(128);
            CREATE TABLE TABLE_FOURNISSEURS (ID_FOURNISSEUR VARCHAR(64)) ENGINE=InnoDB;
            CREATE TABLE TABLE_RECEPTIONS_ENTETE (ID_BR VARCHAR(64), ID_FOURNISSEUR VARCHAR(64), FOURNISSEUR VARCHAR(128), ETAT VARCHAR(24)) ENGINE=InnoDB;
            CREATE TABLE TABLE_RECEPTIONS_DETAILS (ID_BR VARCHAR(64), ID_FOURNISSEUR VARCHAR(64), ID_ARTICLE VARCHAR(64), Article VARCHAR(128), Qté DECIMAL(16,3), PRIX_A DECIMAL(16,3), PRIX_V DECIMAL(16,3), ETAT VARCHAR(24)) ENGINE=InnoDB;
            INSERT INTO TABLE_FOURNISSEURS VALUES ('SUP-TEST');
            INSERT INTO TABLE_RECEPTIONS_ENTETE VALUES ('BR-TEST','SUP-TEST','Fournisseur test','ENREGISTRER');
            INSERT INTO TABLE_RECEPTIONS_DETAILS SELECT 'BR-TEST','SUP-TEST',ID_ARTICLE,Article,2,11,15,'ENREGISTRER' FROM TABLE_ARTICLES WHERE ID_ARTICLE='W2-Article';
            """);
        var receipt = new PurchaseReceiptValidation(settings.ConnectionString);
        var preview = receipt.Read("BR-TEST");
        var before = Snapshot(settings);
        var oldStock = Number(settings, "SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='W2-Article'");
        var oldAverage = Number(settings, "SELECT PRIX_MP FROM TABLE_ARTICLES WHERE ID_ARTICLE='W2-Article'");
        try
        {
            receipt.Validate(preview, "O'Neil", "1234");
            throw new InvalidOperationException("A cashier validated a purchase receipt.");
        }
        catch (UnauthorizedAccessException) { }
        Sql(settings, "UPDATE TABLE_RECEPTIONS_DETAILS SET PRIX_A=12 WHERE ID_BR='BR-TEST'");
        try
        {
            receipt.Validate(preview, "Test manager", "5678");
            throw new InvalidOperationException("A stale purchase receipt was accepted.");
        }
        catch (InvalidOperationException ex) when (ex.Message.StartsWith("La réception a changé.", StringComparison.Ordinal)) { }
        Sql(settings, "UPDATE TABLE_RECEPTIONS_DETAILS SET PRIX_A=11 WHERE ID_BR='BR-TEST'");
        Sql(settings, "CREATE TRIGGER test_receipt_rollback BEFORE UPDATE ON TABLE_RECEPTIONS_ENTETE FOR EACH ROW SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT='receipt rollback'");
        try
        {
            receipt.Validate(preview, "Test manager", "5678");
            throw new InvalidOperationException("Purchase receipt ignored an injected failure.");
        }
        catch (MySqlException) { }
        finally { Sql(settings, "DROP TRIGGER test_receipt_rollback"); }
        Require(Snapshot(settings) == before &&
            Number(settings, "SELECT COUNT(*) FROM TABLE_RECEPTIONS_DETAILS WHERE ETAT='ENREGISTRER'") == 1,
            "Purchase receipt rollback left partial changes.");
        receipt.Validate(preview, "Test manager", "5678");
        var expectedAverage = Math.Round((oldAverage * oldStock + 22m) / (oldStock + 2m), 2,
            MidpointRounding.AwayFromZero);
        Require(Number(settings, "SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='W2-Article'") == oldStock + 2m &&
            Number(settings, "SELECT PRIX_MP FROM TABLE_ARTICLES WHERE ID_ARTICLE='W2-Article'") == expectedAverage &&
            Number(settings, "SELECT COUNT(*) FROM TABLE_ARTICLES WHERE ID_ARTICLE='W2-Article' AND PRIX_A=11 AND PRIX_V_1=15 AND FOURNISSEUR='Fournisseur test'") == 1 &&
            Number(settings, "SELECT COUNT(*) FROM TABLE_MOUVEMENTS_STOCK WHERE LIBELLE LIKE '%BR-TEST [Test manager]' AND QUANTITE=2") == 1 &&
            Number(settings, "SELECT COUNT(*) FROM TABLE_RECEPTIONS_ENTETE WHERE ETAT='VALIDER'") == 1 &&
            Number(settings, "SELECT COUNT(*) FROM TABLE_RECEPTIONS_DETAILS WHERE ETAT='VALIDER'") == 1,
            "Validated receipt did not preserve LOGICA's stock, pricing and movement rules.");
        try
        {
            receipt.Validate(preview, "Test manager", "5678");
            throw new InvalidOperationException("Purchase receipt was posted twice.");
        }
        catch (InvalidOperationException ex) when (ex.Message == "Réception enregistrée introuvable.") { }

        Sql(settings, """
            ALTER TABLE TABLE_NUM ADD BR INT NOT NULL DEFAULT 1;
            ALTER TABLE TABLE_RECEPTIONS_ENTETE ADD Dates DATE, ADD UTILISATEUR VARCHAR(128), ADD CODE_FOURNISSEUR VARCHAR(64), ADD TOTAL_NET_ACHATS DECIMAL(16,3), ADD TOTAL_NET_VENTES DECIMAL(16,3);
            ALTER TABLE TABLE_RECEPTIONS_DETAILS ADD Dates DATE, ADD CODE_FOURNISSEUR VARCHAR(64), ADD FOURNISSEUR VARCHAR(128), ADD Code VARCHAR(64), ADD TOTAL_NET_ACHATS DECIMAL(16,3), ADD TOTAL_NET_VENTES DECIMAL(16,3);
            CREATE TABLE TABLE_COMMANDES_ENTETE (ID_BC VARCHAR(64), ID_FOURNISSEUR VARCHAR(64), FOURNISSEUR VARCHAR(128), CODE_FOURNISSEUR VARCHAR(64), ETAT VARCHAR(24)) ENGINE=InnoDB;
            CREATE TABLE TABLE_COMMANDES_DETAILS (ID_BC VARCHAR(64), ID_FOURNISSEUR VARCHAR(64), ID_ARTICLE VARCHAR(64), Article VARCHAR(128), Code VARCHAR(64), Qté DECIMAL(16,3), PRIX_A DECIMAL(16,3), PRIX_V DECIMAL(16,3), ETAT VARCHAR(24)) ENGINE=InnoDB;
            INSERT INTO TABLE_COMMANDES_ENTETE VALUES ('BC-TEST','SUP-TEST','Fournisseur test','SUP','VALIDER');
            INSERT INTO TABLE_COMMANDES_DETAILS SELECT 'BC-TEST','SUP-TEST',ID_ARTICLE,Article,Code,5,13,19,'VALIDER' FROM TABLE_ARTICLES WHERE ID_ARTICLE='W2-Article';
            -- Apply to an isolated, backed-up LOGICA schema before creating receipts from orders.
            CREATE TABLE IF NOT EXISTS hanouty_purchase_receipt_order (
                RECEIPT_ID VARCHAR(255) COLLATE utf8mb4_bin NOT NULL,
                ORDER_ID VARCHAR(255) COLLATE utf8mb4_bin NOT NULL,
                ARTICLE_ID VARCHAR(255) COLLATE utf8mb4_bin NOT NULL,
                QUANTITY DECIMAL(18,2) NOT NULL,
                PRIMARY KEY (RECEIPT_ID),
                KEY ix_purchase_receipt_order_article (ORDER_ID, ARTICLE_ID),
                CONSTRAINT ck_purchase_receipt_order_quantity CHECK (QUANTITY > 0)
            ) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin;
            """);
        var startingStock = Number(settings, "SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='W2-Article'");
        RunPartialReceiptFromWindow(settings);
        var firstPartId = Convert.ToString(Value(settings, "SELECT RECEIPT_ID FROM hanouty_purchase_receipt_order WHERE ORDER_ID='BC-TEST'"));
        var reservedStock = Number(settings, "SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='W2-Article'");
        Require(firstPartId == "BR000001" && reservedStock == startingStock + 2m,
            "The receipt window did not create and validate the first part.");
        try
        {
            receipt.CreateFromOrder("BC-TEST", "W2-Article", 4m, "Test manager", "5678");
            throw new InvalidOperationException("Receipt exceeded the remaining order quantity.");
        }
        catch (InvalidOperationException ex) when (ex.Message.StartsWith("Quantité supérieure", StringComparison.Ordinal)) { }
        var beforeCancellation = Snapshot(settings);
        RunPartialReceiptFromWindow(settings, cancel: true);
        Require(Snapshot(settings) == beforeCancellation &&
            Number(settings, "SELECT COUNT(*) FROM hanouty_purchase_receipt_order WHERE RECEIPT_ID='BR000002'") == 0,
            "The receipt cancellation button did not release its reservation.");
        var cancelled = receipt.CreateFromOrder("BC-TEST", "W2-Article", 3m, "Test manager", "5678");
        Sql(settings, "CREATE TRIGGER test_receipt_cancel_failure BEFORE DELETE ON TABLE_RECEPTIONS_ENTETE FOR EACH ROW SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT='receipt cancel rollback'");
        try
        {
            receipt.Cancel(cancelled, "Test manager", "5678");
            throw new InvalidOperationException("Cancellation ignored an injected failure.");
        }
        catch (MySqlException) { }
        finally { Sql(settings, "DROP TRIGGER test_receipt_cancel_failure"); }
        Require(Number(settings, "SELECT COUNT(*) FROM hanouty_purchase_receipt_order WHERE RECEIPT_ID='BR000003'") == 1 &&
            Number(settings, "SELECT COUNT(*) FROM TABLE_RECEPTIONS_DETAILS WHERE ID_BR='BR000003'") == 1,
            "Cancellation rollback lost a reserved receipt.");
        receipt.Cancel(cancelled, "Test manager", "5678");
        Require(Snapshot(settings) == beforeCancellation &&
            Number(settings, "SELECT COUNT(*) FROM hanouty_purchase_receipt_order WHERE RECEIPT_ID='BR000003'") == 0 &&
            Number(settings, "SELECT COUNT(*) FROM TABLE_RECEPTIONS_ENTETE WHERE ID_BR='BR000003'") == 0 &&
            Number(settings, "SELECT COUNT(*) FROM TABLE_RECEPTIONS_DETAILS WHERE ID_BR='BR000003'") == 0,
            "Cancellation did not free the balance without moving stock.");
        var remainder = receipt.CreateFromOrder("BC-TEST", "W2-Article", 3m, "Test manager", "5678");
        receipt.Validate(remainder, "Test manager", "5678");
        Require(remainder.Id == "BR000004" &&
            Number(settings, "SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='W2-Article'") == startingStock + 5m &&
            Number(settings, "SELECT SUM(QUANTITY) FROM hanouty_purchase_receipt_order WHERE ORDER_ID='BC-TEST'") == 5m &&
            Number(settings, "SELECT BR FROM TABLE_NUM WHERE ID=0") == 5,
            "Two partial receipts did not exhaust the order and update the stock exactly once.");

        Sql(settings, """
            ALTER TABLE TABLE_NUM ADD BC INT NOT NULL DEFAULT 1;
            ALTER TABLE TABLE_FOURNISSEURS ADD FOURNISSEUR VARCHAR(128), ADD CODE_FOURNISSEUR VARCHAR(64);
            UPDATE TABLE_FOURNISSEURS SET FOURNISSEUR='Fournisseur test', CODE_FOURNISSEUR='SUP' WHERE ID_FOURNISSEUR='SUP-TEST';
            ALTER TABLE TABLE_COMMANDES_ENTETE ADD Dates DATE, ADD UTILISATEUR VARCHAR(128), ADD TOTAL_TTC_DOC DECIMAL(16,3),
                ADD TOTAL_TVA_DOC DECIMAL(16,3), ADD TOTAL_HT_DOC DECIMAL(16,3), ADD TOTAL_REMISE_DOC DECIMAL(16,3);
            ALTER TABLE TABLE_COMMANDES_DETAILS ADD Dates DATE, ADD CODE_FOURNISSEUR VARCHAR(64), ADD FOURNISSEUR VARCHAR(128),
                ADD PU_TTC DECIMAL(16,3), ADD TAUX_TVA DECIMAL(16,3), ADD PU_HT DECIMAL(16,3), ADD TOTAL_TTC DECIMAL(16,3),
                ADD TOTAL_TVA DECIMAL(16,3), ADD TOTAL_HT DECIMAL(16,3), ADD TAUX_REMISE DECIMAL(16,3);
            """);
        var salesBeforeOrder = Number(settings, "SELECT COUNT(*) FROM TABLE_VENTES_ENTETE");
        try
        {
            receipt.CreateOrder("SUP-TEST", "W2-Article", 4m, "O'Neil", "1234");
            throw new InvalidOperationException("Cashier validated a purchase order.");
        }
        catch (UnauthorizedAccessException) { }
        RunPartialReceiptFromWindow(settings, createOrder: true);
        const string newOrder = "BC000001";
        Require(Number(settings, "SELECT COUNT(*) FROM TABLE_VENTES_ENTETE") == salesBeforeOrder &&
            Number(settings, "SELECT BC FROM TABLE_NUM WHERE ID=0") == 2 &&
            Number(settings, "SELECT COUNT(*) FROM TABLE_COMMANDES_ENTETE WHERE ID_BC='BC000001' AND ETAT='VALIDER'") == 1 &&
            Number(settings, "SELECT COUNT(*) FROM TABLE_COMMANDES_DETAILS WHERE ID_BC='BC000001' AND ETAT='VALIDER' AND PU_TTC=13 AND Qté=4") == 1,
            "LOGICA fiscal order creation did not preserve the sequence, price or stock.");
        Require(Number(settings, "SELECT COUNT(*) FROM hanouty_purchase_receipt_order WHERE ORDER_ID=@id AND QUANTITY=2", newOrder) == 1 &&
            Number(settings, "SELECT COUNT(*) FROM TABLE_RECEPTIONS_DETAILS WHERE ID_BR='BR000005' AND ETAT='VALIDER' AND PRIX_A=13") == 1 &&
            Number(settings, "SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='W2-Article'") == startingStock + 7m,
            "The fiscal LOGICA order did not support a validated partial receipt.");

        Sql(settings, """
            -- Run after 20261113-purchase-receipt-order.sql. Existing reservations are preserved.
            ALTER TABLE hanouty_purchase_receipt_order
                DROP PRIMARY KEY, ADD PRIMARY KEY (RECEIPT_ID, ARTICLE_ID);
            ALTER TABLE TABLE_FOURNISSEURS ADD CREDIT_INITIAL DECIMAL(16,3);
            UPDATE TABLE_FOURNISSEURS SET CREDIT_INITIAL=10 WHERE ID_FOURNISSEUR='SUP-TEST';
            ALTER TABLE TABLE_FOURNISSEURS_REGLE ADD ID_FOURNISSEUR VARCHAR(64);
            INSERT INTO TABLE_FOURNISSEURS_REGLE (ID_FOURNISSEUR,MONTANT) VALUES ('SUP-TEST',8);
            CREATE TABLE TABLE_SORTIES_ENTETE (ID_FOURNISSEUR VARCHAR(64), TOTAL_NET_ACHATS DECIMAL(16,3)) ENGINE=InnoDB;
            INSERT INTO TABLE_SORTIES_ENTETE VALUES ('SUP-TEST',-3);
            INSERT INTO TABLE_ARTICLES (ID_ARTICLE,STOCK,Code,Article,Famille,PRIX_A,PRIX_MP,PRIX_V_1,TAUX_TVA,GROUPE,PROMOTION,PRIX_QTE)
            VALUES ('W2-PURCHASE-SECOND',4,'W2-PURCHASE','Autre produit','Food',7,7,10,20,'G',0,0);
            """);
        var accountBefore = receipt.ReadSupplierAccount("SUP-TEST");
        var beforeMultiStock = Number(settings, "SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='W2-Article'");
        RunPartialReceiptFromWindow(settings, createOrder: true, multipleLines: true);
        const string multiOrder = "BC000002";
        Require(multiOrder == "BC000002" &&
            Number(settings, "SELECT COUNT(*) FROM TABLE_COMMANDES_DETAILS WHERE ID_BC='BC000002' AND ETAT='VALIDER'") == 2,
            "Multi-line order did not store both articles under one LOGICA number.");
        Require(Number(settings, "SELECT COUNT(*) FROM hanouty_purchase_receipt_order WHERE ORDER_ID=@id", multiOrder) == 2,
            "Multi-line receipt did not reserve both articles.");
        var account = receipt.ReadSupplierAccount("SUP-TEST");
        Require(Number(settings, "SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='W2-Article'") == beforeMultiStock + 1 &&
            Number(settings, "SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='W2-PURCHASE-SECOND'") == 6 &&
            account.Opening == 10 && account.Outgoing == -3 && account.Payments == 8 &&
            account.Receipts == accountBefore.Receipts + 27 && account.Balance == accountBefore.Balance + 27,
            "Receipt or supplier account does not reconcile with LOGICA's signed movements.");

    }

    private static void RunPartialReceiptFromWindow(CatalogueSettings settings, bool cancel = false, bool createOrder = false, bool multipleLines = false)
    {
        var host = CatalogueHost.CreateCashierWorkstation(settings, "01");
        host.Window.Show();
        try
        {
            Require(CashierEntry(host, "Test manager", "01", "0", 0m, "5678"),
                "Receipt manager could not sign in.");
            static IEnumerable<T> Controls<T>(DependencyObject parent) where T : DependencyObject
            {
                foreach (var child in LogicalTreeHelper.GetChildren(parent).OfType<DependencyObject>())
                {
                    if (child is T control) yield return control;
                    foreach (var descendant in Controls<T>(child)) yield return descendant;
                }
            }
            static void Click(System.Windows.Controls.Button button)
            {
                Require(button.IsEnabled, "Receipt control is disabled.");
                button.RaiseEvent(new RoutedEventArgs(System.Windows.Controls.Button.ClickEvent));
            }

            var step = 0;
            Exception? failure = null;
            var timer = new System.Windows.Threading.DispatcherTimer { Interval = TimeSpan.FromMilliseconds(75) };
            timer.Tick += (_, _) =>
            {
                timer.Stop();
                try
                {
                    if (step++ == 0)
                    {
                        var window = Application.Current.Windows.OfType<PurchaseReceiptDialog>()
                            .Single(dialog => dialog.IsVisible && dialog.Owner == host.Window);
                        System.Windows.Controls.TextBox Field(string name) =>
                            Controls<System.Windows.Controls.TextBox>(window).Single(field =>
                                System.Windows.Automation.AutomationProperties.GetName(field) == name);
                        System.Windows.Controls.Button Button(string label) =>
                            Controls<System.Windows.Controls.Button>(window).Single(button => Equals(button.Content, label));
                        void AddLine(string id, string amount)
                        {
                            Field("Identifiant article").Text = id;
                            Field("Quantité reçue").Text = amount;
                            Click(Button("Ajouter la ligne"));
                        }
                        Field("Identifiant article").Text = "W2-Article";
                        if (createOrder)
                        {
                            Field("Identifiant fournisseur").Text = "SUP-TEST";
                            Field("Quantité reçue").Text = "4";
                            if (multipleLines)
                            {
                                AddLine("W2-Article", "2");
                                AddLine("W2-PURCHASE-SECOND", "3");
                            }
                            var beforeOrder = Snapshot(settings);
                            timer.Start();
                            Click(Button("Créer et valider la commande"));
                            Require(Field("Commande").Text == (multipleLines ? "BC000002" : "BC000001") && Snapshot(settings) == beforeOrder,
                                "The order button did not allocate the LOGICA number without moving stock.");
                        }
                        else Field("Commande").Text = "BC-TEST";
                        Field("Quantité reçue").Text = cancel ? "3" : "2";
                        if (multipleLines)
                        {
                            AddLine("W2-Article", "1");
                            AddLine("W2-PURCHASE-SECOND", "2");
                        }
                        var id = multipleLines ? "BR000006" : createOrder ? "BR000005" : cancel ? "BR000002" : "BR000001";
                        var before = Snapshot(settings);
                        timer.Start();
                        Click(Button("Créer le bon"));
                        Require(Snapshot(settings) == before &&
                            Number(settings, "SELECT COUNT(*) FROM TABLE_RECEPTIONS_ENTETE WHERE ID_BR=@id AND ETAT='ENREGISTRER'", id) == 1,
                            "Saving the receipt moved stock before confirmation.");
                        timer.Start();
                        Click(Button(cancel ? "Annuler le bon enregistré" : "Valider la réception"));
                        Require(Controls<System.Windows.Controls.TextBlock>(window).Any(text =>
                            text.Text == (cancel ? $"Bon {id} annulé. Quantité libérée." : $"Bon {id} validé. Stock et coûts mis à jour.")),
                            "Receipt screen did not confirm the saved receipt.");
                        if (multipleLines)
                        {
                            Click(Button("Solde fournisseur"));
                            Require(Controls<System.Windows.Controls.TextBlock>(window).Any(text => text.Text.Contains("Solde :")),
                                "The supplier account did not render from the real database.");
                        }
                        window.Close();
                    }
                    else if (cancel && step == 4)
                    {
                        var dialog = Application.Current.Windows.Cast<Window>().Single(window =>
                            window.Owner == host.Window && window.IsVisible && window.Title == "Annulation du bon");
                        Click(Controls<System.Windows.Controls.Button>(dialog).Single(button => Equals(button.Content, "Confirmer")));
                    }
                    else
                    {
                        var prompt = Application.Current.Windows.Cast<Window>().Single(window =>
                            window.Owner == host.Window && window.IsVisible &&
                            Controls<System.Windows.Controls.PasswordBox>(window).Any());
                        Controls<System.Windows.Controls.PasswordBox>(prompt).Single().Password = "5678";
                        if (cancel && step == 3) timer.Start();
                        Click(Controls<System.Windows.Controls.Button>(prompt).Single(button => button.IsDefault));
                    }
                }
                catch (Exception ex)
                {
                    failure = ex;
                    foreach (var window in Application.Current.Windows.Cast<Window>()
                        .Where(window => window.Owner == host.Window && window.IsVisible).ToArray().Reverse())
                        window.Close();
                }
            };
            timer.Start();
            try
            {
                Click(Controls<System.Windows.Controls.Button>(host.Window).Single(button =>
                    System.Windows.Automation.AutomationProperties.GetName(button) == "Open purchase receipt"));
            }
            finally { timer.Stop(); }
            if (failure is not null) throw new InvalidOperationException("Receipt window acceptance failed.", failure);
            Require(step == (cancel || createOrder ? 4 : 3), "Receipt UI did not complete creation and validation.");
        }
        finally { host.Window.Close(); }
    }

    private static void VerifyInventoryValidation(CatalogueSettings settings)
    {
        Sql(settings, """
            ALTER TABLE TABLE_ARTICLES ADD STOCK_INITIAL DECIMAL(16,3), ADD DATE_INVENTAIRE DATE;
            CREATE TABLE TABLE_INVENTAIRES_ENTETE (ID_INV VARCHAR(64), Dates DATE, ETAT VARCHAR(24), UTILISATEUR VARCHAR(128), TOTAL_VALEUR DECIMAL(16,3)) ENGINE=InnoDB;
            CREATE TABLE TABLE_INVENTAIRES_DETAILS (ID_INV VARCHAR(64), ID_ARTICLE VARCHAR(64), STOCK_LOGIQUE DECIMAL(16,3), STOCK_PHYSIQUE DECIMAL(16,3), ETAT VARCHAR(24), Article VARCHAR(128), ECART DECIMAL(16,3), VALEUR DECIMAL(16,3), PRIX_A DECIMAL(16,3), N_INV VARCHAR(64), Dates DATE, Code VARCHAR(64)) ENGINE=InnoDB;
            INSERT INTO TABLE_INVENTAIRES_ENTETE (ID_INV,Dates,ETAT) VALUES ('INV-TEST','2026-11-13','ENREGISTRER');
            INSERT INTO TABLE_INVENTAIRES_DETAILS (ID_INV,ID_ARTICLE,STOCK_LOGIQUE,STOCK_PHYSIQUE,ETAT,Article,ECART,VALEUR,PRIX_A) SELECT 'INV-TEST', ID_ARTICLE, STOCK, STOCK+2,'ENREGISTRER', Article, 0, 0, PRIX_A FROM TABLE_ARTICLES WHERE ID_ARTICLE='W2-Article';
            """);
        var validation = new InventoryDocumentValidation(settings.ConnectionString);
        var before = Snapshot(settings);
        // Incomplete count must fail closed before any stock or audit write.
        Sql(settings, "UPDATE TABLE_INVENTAIRES_DETAILS SET STOCK_PHYSIQUE=NULL WHERE ID_INV='INV-TEST'");
        try
        {
            validation.Validate("INV-TEST", "Test manager", "5678");
            throw new InvalidOperationException("Inventory accepted an incomplete physical count.");
        }
        catch (InvalidOperationException ex) when (ex.Message == "Inventory contains uncounted or invalid lines.") { }
        Require(Number(settings, "SELECT COUNT(*) FROM TABLE_MOUVEMENTS_STOCK WHERE LIBELLE LIKE 'Inventaire [Test manager] INV-TEST:%'") == 0 &&
            Number(settings, "SELECT COUNT(*) FROM TABLE_INVENTAIRES_ENTETE WHERE ID_INV='INV-TEST' AND ETAT='ENREGISTRER'") == 1,
            "Incomplete count wrote inventory stock or audit.");
        Sql(settings, "UPDATE TABLE_INVENTAIRES_DETAILS SET STOCK_PHYSIQUE=STOCK_LOGIQUE+2 WHERE ID_INV='INV-TEST'");
        Require(Snapshot(settings) == before, "Incomplete count rejection did not preserve the baseline.");

        // Real concurrent stock movement after document read must invalidate the count.
        Sql(settings, "UPDATE TABLE_ARTICLES SET STOCK=STOCK+1 WHERE ID_ARTICLE='W2-Article'");
        try
        {
            validation.Validate("INV-TEST", "Test manager", "5678");
            throw new InvalidOperationException("Inventory accepted stock changed after count.");
        }
        catch (InvalidOperationException ex) when (ex.Message.StartsWith("Inventory stock is stale", StringComparison.Ordinal)) { }
        Require(Number(settings, "SELECT COUNT(*) FROM TABLE_INVENTAIRES_ENTETE WHERE ID_INV='INV-TEST' AND ETAT='ENREGISTRER'") == 1 &&
            Number(settings, "SELECT COUNT(*) FROM TABLE_MOUVEMENTS_STOCK WHERE LIBELLE LIKE 'Inventaire [Test manager] INV-TEST:%'") == 0,
            "Concurrent stock change produced an inventory write.");
        Sql(settings, "UPDATE TABLE_ARTICLES SET STOCK=STOCK-1 WHERE ID_ARTICLE='W2-Article'");
        Require(Snapshot(settings) == before, "Concurrent stock test did not restore its baseline.");
        try
        {
            validation.Validate("INV-TEST", "O'Neil", "1234");
            throw new InvalidOperationException("Cashier validated inventory without the LOGICA role.");
        }
        catch (UnauthorizedAccessException) { }
        Require(Snapshot(settings) == before, "Denied inventory changed business tables.");
        Sql(settings, "UPDATE TABLE_INVENTAIRES_DETAILS SET STOCK_LOGIQUE=STOCK_LOGIQUE+1 WHERE ID_INV='INV-TEST'");
        try
        {
            validation.Validate("INV-TEST", "Test manager", "5678");
            throw new InvalidOperationException("Stale inventory was accepted.");
        }
        catch (InvalidOperationException ex) when (ex.Message.StartsWith("Inventory stock is stale", StringComparison.Ordinal)) { }
        Sql(settings, "UPDATE TABLE_INVENTAIRES_DETAILS SET STOCK_LOGIQUE=STOCK_LOGIQUE-1 WHERE ID_INV='INV-TEST'");
        Sql(settings, "CREATE TRIGGER inventory_failure BEFORE UPDATE ON TABLE_INVENTAIRES_ENTETE FOR EACH ROW SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT='inventory-rollback'");
        try
        {
            validation.Validate("INV-TEST", "Test manager", "5678");
            throw new InvalidOperationException("Inventory ignored the final write failure.");
        }
        catch (MySqlException) { }
        finally { Sql(settings, "DROP TRIGGER inventory_failure"); }
        Require(Snapshot(settings) == before &&
            Number(settings, "SELECT COUNT(*) FROM TABLE_INVENTAIRES_DETAILS WHERE ETAT='ENREGISTRER'") == 1,
            "Failed inventory left stock, movements or details partially updated.");
        var workflow = new InventoryCountWorkflow(settings.ConnectionString, "Test manager", () => "5678");
        var count = workflow.Open("INV-TEST").Lines.Single();
        Require(count.PhysicalQuantity is null && !workflow.Confirm("INV-TEST"),
            "An existing saved quantity bypassed the fresh count in WPF.");
        RunInventoryFromWindow(settings, count.ArticleId, count.ExpectedQuantity + 3);
        Require(
            Number(settings, "SELECT ECART FROM TABLE_INVENTAIRES_DETAILS WHERE ID_INV='INV-TEST'") == 3m,
            "The WPF workflow did not persist the new physical count.");
        Require(Number(settings, "SELECT COUNT(*) FROM TABLE_INVENTAIRES_ENTETE WHERE ETAT='VALIDER'") == 1 &&
            Number(settings, "SELECT COUNT(*) FROM TABLE_INVENTAIRES_DETAILS WHERE ETAT='VALIDER'") == 1 &&
            Number(settings, "SELECT COUNT(*) FROM TABLE_MOUVEMENTS_STOCK WHERE LIBELLE LIKE 'Inventaire [Test manager] INV-TEST:%'") == 1 &&
            Number(settings, "SELECT COUNT(*) FROM TABLE_ARTICLES a JOIN TABLE_INVENTAIRES_DETAILS d ON a.ID_ARTICLE=d.ID_ARTICLE WHERE a.STOCK=d.STOCK_PHYSIQUE AND a.STOCK_INITIAL=d.STOCK_PHYSIQUE") == 1,
            "Inventory did not update document, stock and actor audit together.");
        try
        {
            validation.Validate("INV-TEST", "Test manager", "5678");
            throw new InvalidOperationException("Inventory was validated twice.");
        }
        catch (InvalidOperationException ex) when (ex.Message == "Inventory document is not open.") { }

        Sql(settings, "ALTER TABLE TABLE_NUM ADD INV INT NOT NULL DEFAULT 1");
        var latestStock = Number(settings, "SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='W2-Article'");
        RunInventoryFromWindow(settings, "W2-Article", latestStock + 3, create: true);
        Require(Number(settings, "SELECT INV FROM TABLE_NUM WHERE ID=0") == 2 &&
            Number(settings, "SELECT COUNT(*) FROM TABLE_INVENTAIRES_ENTETE WHERE ID_INV='INV000001' AND UTILISATEUR='Test manager' AND ETAT='VALIDER'") == 1 &&
            Number(settings, "SELECT ECART FROM TABLE_INVENTAIRES_DETAILS WHERE ID_INV='INV000001'") == 3m &&
            Number(settings, "SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='W2-Article'") == latestStock + 3,
            "The WPF inventory did not create, number, count and validate a new LOGICA document.");
    }

    private static void RunInventoryFromWindow(CatalogueSettings settings, string articleId, decimal physical, bool create = false)
    {
        var host = CatalogueHost.CreateCashierWorkstation(settings, "01");
        host.Window.Show();
        try
        {
            Require(CashierEntry(host, "Test manager", "01", "0", 0m, "5678"),
                "Inventory manager could not open a cashier session.");
            static IEnumerable<T> Controls<T>(DependencyObject parent) where T : DependencyObject
            {
                foreach (var child in LogicalTreeHelper.GetChildren(parent).OfType<DependencyObject>())
                {
                    if (child is T control) yield return control;
                    foreach (var nested in Controls<T>(child)) yield return nested;
                }
            }
            static T Named<T>(DependencyObject root, string name) where T : DependencyObject =>
                Controls<T>(root).Single(control => System.Windows.Automation.AutomationProperties.GetName(control) == name);
            static void Click(System.Windows.Controls.Button button)
            {
                Require(button.IsEnabled, "Inventory control is disabled.");
                button.RaiseEvent(new RoutedEventArgs(System.Windows.Controls.Button.ClickEvent));
            }

            Exception? failure = null;
            var step = 0;
            var timer = new System.Windows.Threading.DispatcherTimer { Interval = TimeSpan.FromMilliseconds(75) };
            timer.Tick += (_, _) =>
            {
                timer.Stop();
                try
                {
                    var stage = step++;
                    if (stage == 0)
                    {
                        var dialog = Application.Current.Windows.OfType<Hanouty.Desktop.Wpf.InventoryCountWindow>()
                            .Single(window => window.Owner == host.Window && window.IsVisible);
                        if (create)
                        {
                            Named<System.Windows.Controls.TextBox>(dialog, "Article IDs for new inventory").Text = articleId;
                            timer.Start();
                            Click(Named<System.Windows.Controls.Button>(dialog, "Create inventory document"));
                        }
                        else
                        {
                            Named<System.Windows.Controls.TextBox>(dialog, "Inventory document identity").Text = "INV-TEST";
                            Click(Named<System.Windows.Controls.Button>(dialog, "Open inventory document"));
                        }
                        var confirm = Named<System.Windows.Controls.Button>(dialog, "Confirm inventory document");
                        Require(!confirm.IsEnabled, "Inventory confirmation was enabled before counting.");
                        Named<System.Windows.Controls.TextBox>(dialog, "Counted article identity").Text = articleId;
                        Named<System.Windows.Controls.TextBox>(dialog, "Physical stock quantity").Text =
                            physical.ToString(CultureInfo.InvariantCulture);
                        Click(Named<System.Windows.Controls.Button>(dialog, "Record physical quantity"));
                        var model = (InventoryCountViewModel)dialog.DataContext;
                        Require(model.Lines.Single().Difference == 3m, "Inventory screen did not show the counted difference.");
                        timer.Start();
                        Click(confirm);
                        Require(model.Status == "Document confirmé par Inventory",
                            "Inventory screen did not confirm the MariaDB document.");
                        dialog.Close();
                    }
                    else
                    {
                        var dialog = Application.Current.Windows.Cast<Window>()
                            .Single(window => window.Owner == host.Window && window.IsVisible &&
                                Controls<System.Windows.Controls.PasswordBox>(window).Any());
                        Controls<System.Windows.Controls.PasswordBox>(dialog).Single().Password = "5678";
                        Click(Controls<System.Windows.Controls.Button>(dialog).Single(button => button.IsDefault));
                    }
                }
                catch (Exception ex)
                {
                    failure = ex;
                    foreach (var window in Application.Current.Windows.Cast<Window>()
                        .Where(window => window.Owner == host.Window && window.IsVisible).ToArray().Reverse())
                        window.Close();
                }
            };
            timer.Start();
            try { Click(Named<System.Windows.Controls.Button>(host.Window, "Open physical inventory workflow")); }
            finally { timer.Stop(); }
            if (failure is not null) throw new InvalidOperationException("Inventory window acceptance failed.", failure);
            Require(step == (create ? 3 : 2), "Inventory window did not reach its authorization step.");
        }
        finally { host.Window.Close(); }
    }

    private static void VerifyReceiptSettings(CatalogueSettings settings)
    {
        var directory = Directory.CreateTempSubdirectory("hanouty-printer-");
        try
        {
            using var connection = new MySqlConnection(settings.ConnectionString);
            connection.Open();
            Require(LogicaReceiptSettings.Read(connection, directory.FullName) is null,
                "Missing workstation file was accepted.");
            var file = Path.Combine(directory.FullName, "PRINTER_CL.sni");
            File.WriteAllText(file, "0");
            Require(LogicaReceiptSettings.Read(connection, directory.FullName)?.Printer == "0",
                "Disabled LOGICA printer was not recognized.");
            File.WriteAllText(file, "");
            Sql(settings, "INSERT INTO TABLE_PARAMETRES VALUES ('BRANCHEMENT','USB'),('MODELE_TICKET','AR_4C')");
            Require(LogicaReceiptSettings.Read(connection, directory.FullName) ==
                new LogicaReceiptSettings("", "USB", "AR_4C"), "LOGICA settings did not preserve the default printer and Arabic template.");
            Sql(settings, "INSERT INTO TABLE_PARAMETRES VALUES ('MODELE_TICKET','FR_3C')");
            Require(LogicaReceiptSettings.Read(connection, directory.FullName) is null,
                "Conflicting ticket templates were accepted.");
            Sql(settings, "DELETE FROM TABLE_PARAMETRES WHERE OBJET IN ('BRANCHEMENT','MODELE_TICKET')");
        }
        finally { directory.Delete(recursive: true); }
    }

    private static void VerifyCashDrawerClosing(CatalogueSettings settings, string pin)
    {
        Sql(settings, """
            ALTER TABLE TABLE_PASS ADD CLOTURE VARCHAR(32);
            UPDATE TABLE_PASS SET CLOTURE='VISIBLE' WHERE ListUser='O''Neil';
            CREATE TABLE TABLE_PARAMETRES (OBJET VARCHAR(64), VALEUR VARCHAR(32)) ENGINE=InnoDB;
            INSERT INTO TABLE_PARAMETRES VALUES ('FONDS_CAISSE','100'),('GESTION_CLOTURE','True'),('CLOTURE_CAISSIER_OBLIGER','False');
            ALTER TABLE TABLE_VENTES_JOURNAL ADD CLOTURE_GLOBALE VARCHAR(32), ADD CLOTURE_CAISSIER VARCHAR(32);
            ALTER TABLE TABLE_VENTES_ENTETE ADD CLOTURE_GLOBALE VARCHAR(32);
            ALTER TABLE TABLE_VENTES_REGLEMENTS ADD CLOTURE_GLOBALE VARCHAR(32);
            CREATE TABLE TABLE_DEPENSES (ID INT PRIMARY KEY, DATES DATE, HEURE TIME, DEPENSE VARCHAR(128),
                MONTANT DECIMAL(16,3), CLOTURE_GLOBALE VARCHAR(32)) ENGINE=InnoDB;
            CREATE TABLE TABLE_CLIENTS_REGLE (MONTANT DECIMAL(16,3), MODE_P VARCHAR(32), CLOTURE_GLOBALE VARCHAR(32)) ENGINE=InnoDB;
            CREATE TABLE TABLE_FOURNISSEURS_REGLE (MONTANT DECIMAL(16,3), MODE_P VARCHAR(32), CLOTURE_GLOBALE VARCHAR(32)) ENGINE=InnoDB;
            CREATE TABLE TABLE_POUBELLE (CLOTURE_GLOBALE VARCHAR(32)) ENGINE=InnoDB;
            INSERT INTO TABLE_CLIENTS_REGLE VALUES (10,'ESPECES',NULL),(30,'CARTE',NULL);
            INSERT INTO TABLE_FOURNISSEURS_REGLE VALUES (4,'ESPECES',NULL);
            INSERT INTO TABLE_POUBELLE VALUES (NULL);
            """);
        VerifyReceiptSettings(settings);
        var closing = new CashDrawerClosing(settings.ConnectionString);
        RunCashDrawerFromWindow(settings, pin, opening: true);
        Require(Convert.ToString(Value(settings, "SELECT VALEUR FROM TABLE_PARAMETRES WHERE OBJET='FONDS_CAISSE'")) == "120.50",
            "Opening amount was not persisted to LOGICA's setting.");
        try
        {
            closing.SetOpening("O'Neil", "wrong", 1m);
            throw new InvalidOperationException("Opening amount accepted a wrong PIN.");
        }
        catch (UnauthorizedAccessException) { }
        var beforeSale = closing.Read("O'Neil", pin);
        var ticket = SellWithUnavailablePrinter(settings, pin);
        var afterSale = closing.Read("O'Neil", pin);
        Require(afterSale.CashSales - beforeSale.CashSales == 5.25m &&
            afterSale.Expected - beforeSale.Expected == 5.25m &&
            afterSale.Expenses == beforeSale.Expenses,
            "The committed sale changed the drawer beyond its cash payment.");
        try
        {
            closing.Read("O'Neil", "wrong");
            throw new InvalidOperationException("Closing accepted a wrong PIN.");
        }
        catch (UnauthorizedAccessException) { }
        Sql(settings, """
            ALTER TABLE TABLE_VENTES_ENTETE ADD CLOTURE_CAISSIER VARCHAR(32);
            ALTER TABLE TABLE_VENTES_REGLEMENTS ADD CLOTURE_CAISSIER VARCHAR(32);
            ALTER TABLE TABLE_DEPENSES ADD CLOTURE_CAISSIER VARCHAR(32), ADD UTILISATEUR VARCHAR(128);
            ALTER TABLE TABLE_CLIENTS_REGLE ADD CLOTURE_CAISSIER VARCHAR(32), ADD UTILISATEUR VARCHAR(128);
            ALTER TABLE TABLE_FOURNISSEURS_REGLE ADD CLOTURE_CAISSIER VARCHAR(32), ADD UTILISATEUR VARCHAR(128);
            ALTER TABLE TABLE_POUBELLE ADD CLOTURE_CAISSIER VARCHAR(32), ADD CAISSIER VARCHAR(128);
            UPDATE TABLE_CLIENTS_REGLE SET UTILISATEUR='O''Neil' WHERE MODE_P='ESPECES';
            UPDATE TABLE_FOURNISSEURS_REGLE SET UTILISATEUR='O''Neil';
            UPDATE TABLE_POUBELLE SET CAISSIER='O''Neil';
            UPDATE TABLE_PARAMETRES SET VALEUR='True' WHERE OBJET='CLOTURE_CAISSIER_OBLIGER';
            """);
        try
        {
            closing.Read("O'Neil", pin);
            throw new InvalidOperationException("Global closing bypassed the required cashier closing.");
        }
        catch (InvalidOperationException ex) when (ex.Message.StartsWith("Clôturez d’abord", StringComparison.Ordinal)) { }
        Sql(settings, "INSERT INTO TABLE_PASS VALUES ('Test manager','5678','MANAGER',NULL),('Test admin','6789','ADMIN',NULL)");
        VerifyCashExpense(settings, pin, closing);
        Sql(settings, "UPDATE TABLE_PASS SET CLOTURE='ACCES ADMIN' WHERE ListUser='O''Neil'");
        Require(closing.RequiredApprovalRole("O'Neil", pin) == "ADMIN", "Admin approval was not requested.");
        try
        {
            closing.Read("O'Neil", pin, perCashier: true, approvalPin: "5678");
            throw new InvalidOperationException("Manager approved an admin-only closing.");
        }
        catch (UnauthorizedAccessException) { }
        closing.Read("O'Neil", pin, perCashier: true, approvalPin: "6789");
        Sql(settings, "UPDATE TABLE_PASS SET CLOTURE='ACCES MANAGER' WHERE ListUser='O''Neil'");
        Require(closing.RequiredApprovalRole("O'Neil", pin) == "MANAGER", "Manager approval was not requested.");
        var cashierPreview = closing.Read("O'Neil", pin, perCashier: true, approvalPin: "5678");
        try
        {
            closing.Close("O'Neil", pin, cashierPreview);
            throw new InvalidOperationException("Closing committed without required manager approval.");
        }
        catch (UnauthorizedAccessException) { }
        closing.Close("O'Neil", pin, cashierPreview, "5678");
        Sql(settings, "UPDATE TABLE_PASS SET CLOTURE='VISIBLE' WHERE ListUser='O''Neil'");
        Require(cashierPreview.PerCashier && cashierPreview.Number == 1 &&
            Number(settings, "SELECT COUNT(*) FROM TABLE_VENTES_JOURNAL WHERE BINARY CAISSIER=BINARY 'O''Neil' AND CLOTURE_CAISSIER IS NULL") == 0 &&
            Number(settings, "SELECT COUNT(*) FROM TABLE_VENTES_JOURNAL WHERE BINARY CAISSIER=BINARY 'Second cashier' AND CLOTURE_CAISSIER IS NULL") > 0 &&
            Number(settings, "SELECT COUNT(*) FROM TABLE_VENTES_JOURNAL WHERE CLOTURE_GLOBALE IS NOT NULL") == 0,
            "Cashier closing affected another cashier or the global closing.");
        Sql(settings, "UPDATE TABLE_PASS SET CLOTURE='VISIBLE' WHERE ListUser='Second cashier'");
        var secondCashier = closing.Read("Second cashier", "4321", perCashier: true);
        closing.Close("Second cashier", "4321", secondCashier);
        var preview = closing.Read("O'Neil", pin);
        Require(preview.Number == 1 && preview.Opening == 120.50m &&
            preview.ClientCash == 10m && preview.SupplierCash == 4m && preview.Expenses == 3m &&
            preview.CashSales - beforeSale.CashSales == 5.25m &&
            preview.Expected - afterSale.Expected == -3m &&
            preview.Expected - beforeSale.Expected == 2.25m &&
            preview.Expected == 123.50m + preview.CashSales, "Cash closing did not reconcile the sale after printer failure.");
        Sql(settings, "CREATE TRIGGER test_closing_failure BEFORE UPDATE ON TABLE_POUBELLE FOR EACH ROW SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT='test-closing-rollback'");
        try
        {
            closing.Close("O'Neil", pin, preview);
            throw new InvalidOperationException("Closing ignored a failed final write.");
        }
        catch (MySqlException) { }
        finally { Sql(settings, "DROP TRIGGER test_closing_failure"); }
        Require(closing.Read("O'Neil", pin) == preview, "Closing left partial writes after rollback.");
        RunCashDrawerFromWindow(settings, pin, opening: false);
        Require(Number(settings, "SELECT COUNT(*) FROM TABLE_VENTES_JOURNAL WHERE CLOTURE_GLOBALE IS NULL") == 0 &&
            Number(settings, "SELECT COUNT(*) FROM TABLE_POUBELLE WHERE CLOTURE_GLOBALE='1'") == 1,
            "Closing did not mark the open documents with the same number.");
        Require(Number(settings, "SELECT COUNT(*) FROM TABLE_VENTES_ENTETE WHERE ID_TICKET=@id AND CLOTURE_GLOBALE='1'", ticket) == 1 &&
            Number(settings, "SELECT COUNT(*) FROM TABLE_VENTES_JOURNAL WHERE ID_TICKET=@id AND CLOTURE_GLOBALE='1'", ticket) == 1 &&
            Number(settings, "SELECT COUNT(*) FROM TABLE_VENTES_REGLEMENTS WHERE ID_TICKET=@id AND CLOTURE_GLOBALE='1'", ticket) == 2,
            "The sale, tender and change did not close under the same number.");
        try
        {
            closing.Close("O'Neil", pin, preview);
            throw new InvalidOperationException("Closing replay was accepted.");
        }
        catch (InvalidOperationException ex) when (ex.Message == "Aucune vente ouverte à clôturer.") { }
    }

    private static void VerifyCashExpense(CatalogueSettings settings, string pin, CashDrawerClosing closing)
    {
        Sql(settings, "ALTER TABLE TABLE_PASS ADD DEPENSES VARCHAR(32)");
        Sql(settings, "UPDATE TABLE_PASS SET DEPENSES='ACCES MANAGER' WHERE ListUser='O''Neil'");
        try
        {
            closing.RecordExpense("O'Neil", pin, "6789", DateTime.Today, "Refus", 3m);
            throw new InvalidOperationException("An admin PIN bypassed the manager expense grant.");
        }
        catch (UnauthorizedAccessException) { }

        Sql(settings, """
            CREATE TRIGGER refuse_expense BEFORE INSERT ON TABLE_DEPENSES FOR EACH ROW
            SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT='expense test rollback'
            """);
        try
        {
            closing.RecordExpense("O'Neil", pin, "5678", DateTime.Today, "Rollback", 3m);
            throw new InvalidOperationException("The injected expense failure was ignored.");
        }
        catch (MySqlException ex) when (ex.Message.Contains("expense test rollback", StringComparison.Ordinal)) { }
        finally { Sql(settings, "DROP TRIGGER refuse_expense"); }
        Require(Number(settings, "SELECT COUNT(*) FROM TABLE_DEPENSES") == 0, "A rejected expense was recorded.");

        var host = CatalogueHost.CreateCashierWorkstation(settings, "01");
        host.Window.Show();
        try
        {
            Require(CashierEntry(host, "O'Neil", "01", "0", 0m, pin), "Expense cashier sign-in failed.");
            var step = 0;
            Exception? failure = null;
            var timer = new System.Windows.Threading.DispatcherTimer { Interval = TimeSpan.FromMilliseconds(75) };
            static void Click(System.Windows.Controls.Button button) =>
                button.RaiseEvent(new RoutedEventArgs(System.Windows.Controls.Button.ClickEvent));
            timer.Tick += (_, _) =>
            {
                timer.Stop();
                var dialog = Application.Current.Windows.Cast<Window>()
                    .LastOrDefault(window => window.IsVisible && window.Owner == host.Window);
                try
                {
                    Require(dialog is not null, "Expense dialog did not open.");
                    if (step < 2)
                    {
                        var pinBox = Descendants(dialog!).OfType<System.Windows.Controls.PasswordBox>().Single();
                        pinBox.Password = step++ == 0 ? pin : "5678";
                        timer.Start();
                        Click(Descendants(dialog!).OfType<System.Windows.Controls.Button>().Single(button => button.IsDefault));
                        return;
                    }
                    Require(dialog is CashExpenseDialog, "Expense form did not open.");
                    var form = (System.Windows.Controls.StackPanel)dialog!.Content;
                    var inputs = form.Children.OfType<System.Windows.Controls.TextBox>().ToArray();
                    inputs[0].Text = "Transport";
                    inputs[1].Text = "3,00";
                    var save = form.Children.OfType<System.Windows.Controls.Button>().Single(button => button.IsDefault);
                    Click(save);
                    Click(save);
                    if (((CashExpenseDialog)dialog).SaveFailure is { } saveFailure)
                        throw new InvalidOperationException("Expense save failed: " + saveFailure.Message, saveFailure);
                    Require(!save.IsEnabled, "The expense form still permits submitting the same draft.");
                    step++;
                    dialog.Close();
                }
                catch (Exception ex)
                {
                    failure = ex;
                    dialog?.Close();
                }
            };
            timer.Start();
            try { Click((System.Windows.Controls.Button)host.Window.FindName("ExpensesButton")); }
            finally { timer.Stop(); }
            if (failure is not null) throw new InvalidOperationException("Expense UI acceptance failed.", failure);
            var totalExpenses = Number(settings, "SELECT COUNT(*) FROM TABLE_DEPENSES");
            var matchingExpenses = Number(settings, """
                SELECT COUNT(*) FROM TABLE_DEPENSES
                WHERE ID=1 AND UTILISATEUR='O''Neil' AND DEPENSE='Transport' AND MONTANT=3
                    AND DATES IS NOT NULL AND CLOTURE_CAISSIER IS NULL AND CLOTURE_GLOBALE IS NULL
                """);
            Require(step == 3 && matchingExpenses == 1 && totalExpenses == 1,
                $"Expense verification: completed steps={step}, matching rows={matchingExpenses}, total rows={totalExpenses}.");
        }
        finally { host.Window.Close(); }

        static IEnumerable<DependencyObject> Descendants(DependencyObject parent)
        {
            foreach (var child in LogicalTreeHelper.GetChildren(parent).OfType<DependencyObject>())
            {
                yield return child;
                foreach (var nested in Descendants(child)) yield return nested;
            }
        }
    }

    private static string SellWithUnavailablePrinter(CatalogueSettings settings, string pin)
    {
        var printerFile = Path.Combine(AppContext.BaseDirectory, "PRINTER_CL.sni");
        var printerName = "Hanouty-QA-Missing-" + Guid.NewGuid().ToString("N");
        using (var stream = new FileStream(printerFile, FileMode.CreateNew, FileAccess.Write))
        using (var writer = new StreamWriter(stream))
            writer.Write(printerName);

        try
        {
            Sql(settings, """
                INSERT INTO TABLE_PARAMETRES VALUES ('BRANCHEMENT','USB'), ('MODELE_TICKET','FR_3C'),
                    ('AFFICHER_MODE_P','True'), ('AFFICHER_N_TICKET','True'),
                    ('AFFICHER_CODE_BARRE','False'), ('PIED_TICKET','Test QA');
                """);
            var sequence = Number(settings, "SELECT CL FROM TABLE_NUM");
            var sales = Number(settings, "SELECT COUNT(*) FROM TABLE_VENTES_ENTETE");
            var stock = Number(settings, "SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='W2-Article'");
            var host = CatalogueHost.CreateCashierWorkstation(settings, "01");
            try
            {
                Require(CashierEntry(host, "O'Neil", "01", "0", 0m, pin),
                    "Printer failure test could not authenticate the cashier.");
                host.ViewModel.ScannerText = "CODE'1";
                host.ViewModel.ScanCommand.Execute(null);
                Require(host.ViewModel.BasketLines.Single().Quantity == 1 &&
                    CashierEntry(host, "O'Neil", "01", "10", 5.25m, fromPaymentPanel: true),
                    "Printer failure test could not stage the cash sale.");
                ReviewThroughDialog(host, pin, true, () => host.ViewModel.CommitCommand.Execute(null));

                var feedback = host.ViewModel.CommitFeedback;
                Require(feedback.StartsWith("Vente enregistrée. Impression impossible :", StringComparison.Ordinal) &&
                    feedback.Contains(printerName, StringComparison.Ordinal) &&
                    !host.ViewModel.CheckoutUncertain && host.ViewModel.BasketLines.Count == 0,
                    $"Expected the sale to complete despite the unavailable printer. Cashier feedback: '{feedback}'.");

                var ticket = Convert.ToString(Value(settings,
                    "SELECT ID_TICKET FROM TABLE_VENTES_ENTETE WHERE TICKET='" +
                    sequence.ToString("000000", CultureInfo.InvariantCulture) + "'"))!;
                Require(Number(settings, "SELECT COUNT(*) FROM TABLE_VENTES_ENTETE WHERE ID_TICKET=@id AND TOTAL_NET=5.25", ticket) == 1 &&
                    Number(settings, "SELECT COUNT(*) FROM TABLE_VENTES_JOURNAL WHERE ID_TICKET=@id", ticket) == 1 &&
                    Number(settings, "SELECT COUNT(*) FROM TABLE_VENTES_REGLEMENTS WHERE ID_TICKET=@id", ticket) == 2 &&
                    Number(settings, "SELECT SUM(MONTANT) FROM TABLE_VENTES_REGLEMENTS WHERE ID_TICKET=@id AND MODE_P='ESPECES'", ticket) == 5.25m &&
                    Number(settings, "SELECT COUNT(*) FROM TABLE_VENTES_ENTETE") == sales + 1 &&
                    Number(settings, "SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='W2-Article'") == stock - 1,
                    "Printer failure changed the committed ticket, stock, or cash.");
                var committed = Snapshot(settings);
                host.ViewModel.CommitCommand.Execute(null);
                Require(Snapshot(settings) == committed, "Retry after printer failure repeated a financial write.");
                return ticket;
            }
            finally { host.Window.Close(); }
        }
        finally
        {
            File.Delete(printerFile);
            Sql(settings, """
                DELETE FROM TABLE_PARAMETRES WHERE OBJET IN ('BRANCHEMENT','MODELE_TICKET',
                    'AFFICHER_MODE_P','AFFICHER_N_TICKET','AFFICHER_CODE_BARRE','PIED_TICKET');
                """);
        }
    }

    private static void RunCashDrawerFromWindow(CatalogueSettings settings, string pin, bool opening)
    {
        var host = CatalogueHost.CreateCashierWorkstation(settings, "01");
        host.Window.Show();
        try
        {
            Require(CashierEntry(host, "O'Neil", "01", "0", 0m, pin),
                "Cash drawer acceptance could not authenticate the cashier.");
            static IEnumerable<T> Controls<T>(DependencyObject parent) where T : DependencyObject
            {
                foreach (var child in LogicalTreeHelper.GetChildren(parent).OfType<DependencyObject>())
                {
                    if (child is T control) yield return control;
                    foreach (var nested in Controls<T>(child)) yield return nested;
                }
            }
            static void Click(System.Windows.Controls.Button button) =>
                button.RaiseEvent(new RoutedEventArgs(System.Windows.Controls.Button.ClickEvent));
            Exception? failure = null;
            var step = 0;
            var timer = new System.Windows.Threading.DispatcherTimer { Interval = TimeSpan.FromMilliseconds(75) };
            timer.Tick += (_, _) =>
            {
                timer.Stop();
                try
                {
                    var dialogs = Application.Current.Windows.Cast<Window>()
                        .Where(w => w.IsVisible && w.Owner == host.Window).ToArray();
                    var dialog = dialogs.Last();
                    switch (step++)
                    {
                        case 0:
                            Require(dialog.Title == (opening ? "Fond de caisse" : "Comptage et clôture de caisse"), "Cash count window was not rendered.");
                            var forbiddenAction = opening ? "Préparer la clôture" : "Enregistrer le montant compté comme fond de caisse";
                            Require(!Controls<System.Windows.Controls.Button>(dialog).Any(button => Equals(button.Content, forbiddenAction)),
                                "The cash drawer dialog exposed the other workflow.");
                            var counts = Controls<System.Windows.Controls.TextBox>(dialog).ToArray();
                            counts[1].Text = "1";
                            counts[3].Text = "1";
                            counts[8].Text = "1";
                            var action = Controls<System.Windows.Controls.Button>(dialog).Single(button =>
                                Equals(button.Content, opening ? "Enregistrer le montant compté comme fond de caisse"
                                    : "Préparer la clôture"));
                            timer.Start();
                            Click(action);
                            break;
                        case 1:
                            Controls<System.Windows.Controls.PasswordBox>(dialog).Single().Password = pin;
                            timer.Start();
                            Click(Controls<System.Windows.Controls.Button>(dialog).Single(button => button.IsDefault));
                            break;
                        case 2:
                            Require(dialog.Title == (opening ? "Fond de caisse" : "Clôture globale"),
                                "Cash drawer confirmation was not rendered.");
                            if (!opening) timer.Start();
                            Click(Controls<System.Windows.Controls.Button>(dialog).Single(button => Equals(button.Content, "Confirmer")));
                            break;
                        case 3:
                            Require(dialog.Title == "Clôture n° 1 enregistrée" &&
                                Controls<System.Windows.Controls.TextBlock>(dialog).Any(block =>
                                    block.Text.Contains("Écart") && block.Text.Contains("Compté")) &&
                                Controls<System.Windows.Controls.Button>(dialog).Any(button => Equals(button.Content, "Imprimer le rapport")),
                                "The committed close did not display its printable drawer report.");
                            dialog.Close();
                            break;
                    }
                }
                catch (Exception ex)
                {
                    failure = ex;
                    foreach (var window in Application.Current.Windows.Cast<Window>()
                        .Where(w => w.Owner == host.Window && w.IsVisible).ToArray().Reverse())
                        window.Close();
                }
            };
            timer.Start();
            try
            {
                var action = opening ? "Fond de caisse" : "Clôture de caisse";
                Click(Controls<System.Windows.Controls.Button>(host.Window).Single(button => Equals(button.Content, action)));
            }
            finally { timer.Stop(); }
            if (failure is not null) throw new InvalidOperationException($"Cash drawer UI acceptance failed at step {step}: {failure.Message}", failure);
            Require(step == (opening ? 3 : 4), "Cash drawer UI did not reach its final step.");
        }
        finally { host.Window.Close(); }
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

    private static void VerifyCustomerCreditStatement(CatalogueSettings settings, string pin)
    {
        Sql(settings, """
            CREATE TABLE TABLE_MODE_P (MODE_P VARCHAR(128)) ENGINE=InnoDB;
            INSERT INTO TABLE_MODE_P VALUES ('ESPECES'),('CARTE');
            ALTER TABLE TABLE_CLIENTS_REGLE ADD ID_CLIENT VARCHAR(64), ADD DATES DATETIME;
            DROP TABLE IF EXISTS TABLE_CLIENTS;
            CREATE TABLE TABLE_CLIENTS (ID_CLIENT VARCHAR(64), CLIENT VARCHAR(128), CREDIT_INITIAL DECIMAL(16,3)) ENGINE=InnoDB;
            INSERT INTO TABLE_CLIENTS VALUES ('CREDIT_FIXTURE','Client crédit',20),('EMPTY_FIXTURE','Sans opérations',NULL);
            INSERT INTO TABLE_VENTES_JOURNAL (ID_CLIENT,OPERATION,Total_NET,Dates)
            VALUES ('CREDIT_FIXTURE','CREDIT',100,'2026-01-02'),('CREDIT_FIXTURE','RETOUR CREDIT',-10,'2026-01-02'),
                   ('CREDIT_FIXTURE','CREDIT',900,'1999-01-01');
            INSERT INTO TABLE_CLIENTS_REGLE (ID_CLIENT,MONTANT,DATES) VALUES ('CREDIT_FIXTURE',30,'2026-01-02');
            """);
        var reader = new CustomerCreditStatementReader(settings.ConnectionString);
        var rows = reader.Read(new DateTime(2026, 1, 1), new DateTime(2026, 1, 31));
        var customer = rows.Single(row => row.CustomerId == "CREDIT_FIXTURE");
        Require(customer.OpeningCredit == 20m && customer.CreditSales == 100m &&
            customer.CreditReturns == -10m && customer.Payments == 30m && customer.Balance == 80m,
            "WPF credit reader did not preserve the LOGICA period and signed return calculation.");
        Require(rows.Single(row => row.CustomerId == "EMPTY_FIXTURE").Balance == 0m,
            "WPF credit reader did not handle an account without movements.");

        var reversedPeriodRejected = false;
        try { reader.Read(new DateTime(2026, 2, 1), new DateTime(2026, 1, 1)); }
        catch (ArgumentException) { reversedPeriodRejected = true; }
        Require(reversedPeriodRejected, "Customer credit reader accepted a reversed date range.");
        var singleDay = reader.Read(new DateTime(2026, 1, 2), new DateTime(2026, 1, 2))
            .Single(row => row.CustomerId == "CREDIT_FIXTURE");
        Require(singleDay.Balance == 80m, "Credit statement lost the inclusive single-day boundary.");
        var outside = reader.Read(new DateTime(2026, 2, 1), new DateTime(2026, 2, 28))
            .Single(row => row.CustomerId == "CREDIT_FIXTURE");
        Require(outside.Balance == 20m && outside.Payments == 0m && outside.CreditSales == 0m,
            "Credit statement did not preserve opening credit outside the movement period.");

        var dialog = new CustomerCreditStatementDialog(reader.Read);
        dialog.Show();
        try
        {
            // Exercise the dialog's production Loaded handler with its default period.
            var layout = (System.Windows.Controls.DockPanel)dialog.Content;
            var grid = layout.Children.OfType<System.Windows.Controls.DataGrid>().Single();
            Require(grid.Items.OfType<CustomerCreditStatementRow>().Any(row =>
                row.CustomerId == "CREDIT_FIXTURE"), "WPF credit statement did not display MariaDB rows.");
            Require(!grid.Items.OfType<CustomerCreditStatementRow>().Any(row =>
                row.CustomerId == "EMPTY_FIXTURE"), "WPF credit statement displayed a settled account.");
        }
        finally { dialog.Close(); }
        var workstation = Host(settings, pin);
        try
        {
            Require(CashierEntry(workstation, "O'Neil", "01", "0", 0m, pin),
                "Customer credit entry requires a real active cashier session.");
            static IEnumerable<DependencyObject> Children(DependencyObject parent)
            {
                foreach (var child in LogicalTreeHelper.GetChildren(parent).OfType<DependencyObject>())
                {
                    yield return child;
                    foreach (var descendant in Children(child)) yield return descendant;
                }
            }
            var entry = Children(workstation.Window).OfType<System.Windows.Controls.Button>()
                .Single(button => Equals(button.Content, "État des crédits clients"));
            Exception? failure = null;
            var opened = false;
            var timer = new System.Windows.Threading.DispatcherTimer
            {
                Interval = TimeSpan.FromMilliseconds(40)
            };
            timer.Tick += (_, _) =>
            {
                var openedDialog = Application.Current.Windows.OfType<CustomerCreditStatementDialog>().SingleOrDefault();
                if (openedDialog is null) return;
                timer.Stop();
                try
                {
                    var grid = ((System.Windows.Controls.DockPanel)openedDialog.Content).Children
                        .OfType<System.Windows.Controls.DataGrid>().Single();
                    Require(grid.Items.OfType<CustomerCreditStatementRow>().Any(row =>
                        row.CustomerId == "CREDIT_FIXTURE" && row.Balance == 80m),
                        "Cashier credit statement entry did not use the registered MariaDB reader.");
                    opened = true;
                }
                catch (Exception ex) { failure = ex; }
                finally { openedDialog.Close(); }
            };
            timer.Start();
            try
            {
                entry.RaiseEvent(new RoutedEventArgs(System.Windows.Controls.Button.ClickEvent));
            }
            finally { timer.Stop(); }
            if (failure is not null) throw failure;
            Require(opened, "Customer credit statement did not open from its cashier button.");
            Require(workstation.Window.EndFinancialSession(), "Empty cashier session could not be ended.");
            var deniedOpened = false;
            var denialTimer = new System.Windows.Threading.DispatcherTimer
            {
                Interval = TimeSpan.FromMilliseconds(40)
            };
            denialTimer.Tick += (_, _) =>
            {
                var deniedDialog = Application.Current.Windows.OfType<CustomerCreditStatementDialog>().SingleOrDefault();
                if (deniedDialog is null) return;
                deniedOpened = true;
                deniedDialog.Close();
            };
            denialTimer.Start();
            try { entry.RaiseEvent(new RoutedEventArgs(System.Windows.Controls.Button.ClickEvent)); }
            finally { denialTimer.Stop(); }
            Require(!deniedOpened, "Credit statement opened after cashier logout.");

        }
        finally { workstation.Window.Close(); }

        File.WriteAllText(Path.Combine(EvidenceDirectory, "customer-credit-statement.json"),
            JsonSerializer.Serialize(new { RealMariaDbReader = true, PeriodBalance = 80m,
                SignedReturn = true, EmptyAccount = true, WpfLoadedRows = true, CashierButtonEntry = true }));
    }

    private static void VerifyCustomerSettlementRetry()
    {
        var customer = new CustomerCreditStatementRow("RETRY_CLIENT", "Client", 0m, 80m, 0m, 0m, 80m);
        var requests = new List<CustomerSettlementRequest>();
        var dialog = new CustomerSettlementDialog(customer, new[] { "ESPECES", "CARTE" }, request =>
        {
            requests.Add(request);
            return false;
        });
        dialog.Show();
        try
        {
            var panel = (System.Windows.Controls.StackPanel)((System.Windows.Controls.ScrollViewer)dialog.Content).Content;
            var inputs = panel.Children.OfType<System.Windows.Controls.TextBox>().ToArray();
            var mode = panel.Children.OfType<System.Windows.Controls.ComboBox>().Single();
            var save = panel.Children.OfType<System.Windows.Controls.Button>().Single();
            var amount = inputs[0];
            var notes = inputs[1];
            amount.Text = "30";
            notes.Text = "Premier versement";
            mode.SelectedItem = "ESPECES";
            save.RaiseEvent(new RoutedEventArgs(System.Windows.Controls.Button.ClickEvent));
            Require(requests.Count == 1 && requests[0].Amount == 30m,
                "Settlement dialog did not submit the reviewed amount.");
            Require(amount.IsReadOnly && notes.IsReadOnly && !mode.IsEnabled,
                "Uncertain settlement left its financial payload editable.");
            // Programmatic edits model stale bindings while the first outcome is unknown.
            amount.Text = "80";
            notes.Text = "Changed payload";
            mode.SelectedItem = "CARTE";
            save.RaiseEvent(new RoutedEventArgs(System.Windows.Controls.Button.ClickEvent));
            Require(requests.Count == 2 && requests[0] == requests[1] &&
                requests[1].PaymentMode == "ESPECES" && requests[1].Notes == "Premier versement" &&
                !string.IsNullOrWhiteSpace(requests[1].OperationId),
                "Settlement retry changed its operation identity or financial payload.");
            amount.Text = "";
            mode.SelectedItem = null;
            save.RaiseEvent(new RoutedEventArgs(System.Windows.Controls.Button.ClickEvent));
            Require(requests.Count == 3 && requests[2] == requests[0],
                "Cleared input bindings prevented reconciliation of the original settlement.");

        }
        finally { dialog.Close(); }
        File.WriteAllText(Path.Combine(EvidenceDirectory, "customer-settlement-ui-retry.json"),
            JsonSerializer.Serialize(new { UiCallbackOnly = true, SameOperation = true,
                ImmutableAmount = true, ImmutableMode = true, ImmutableNotes = true }));
    }


    private static void VerifyCustomerSettlementPosting(CatalogueSettings settings, string pin)
    {
        Sql(settings, """
            ALTER TABLE TABLE_CLIENTS ADD CODE_CLIENT VARCHAR(64);
            UPDATE TABLE_CLIENTS SET CODE_CLIENT='CREDIT-CODE' WHERE ID_CLIENT='CREDIT_FIXTURE';
            ALTER TABLE TABLE_CLIENTS_REGLE ADD ID BIGINT NOT NULL AUTO_INCREMENT PRIMARY KEY,
                ADD ID_REGLE VARCHAR(64), ADD CODE_CLIENT VARCHAR(64), ADD CLIENT VARCHAR(128),
                ADD NOTES TEXT, ADD ETAT VARCHAR(32);
            UPDATE TABLE_PASS SET CLOTURE='VISIBLE' WHERE ListUser='O''Neil';
            """ + """
            CREATE TABLE IF NOT EXISTS hanouty_client_settlement_operations (
             OPERATION_ID VARCHAR(64) CHARACTER SET ascii COLLATE ascii_bin NOT NULL PRIMARY KEY,
             ACTOR VARCHAR(128) NOT NULL,
             CLIENT_ID VARCHAR(255) NOT NULL,
             AMOUNT DECIMAL(18,2) NOT NULL,
             PAYMENT_MODE VARCHAR(128) NOT NULL,
             NOTES TEXT NOT NULL,
             SETTLEMENT_ID BIGINT NOT NULL UNIQUE
            ) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
            
            """);
        var writer = new CustomerSettlementWriter(settings.ConnectionString);
        var reader = new CustomerCreditStatementReader(settings.ConnectionString);
        var closing = new CashDrawerClosing(settings.ConnectionString);
        decimal Balance() => reader.Read(new DateTime(2000, 1, 1), DateTime.Today)
            .Single(row => row.CustomerId == "CREDIT_FIXTURE").Balance;
        string State() => string.Join("|", new[] {
            Number(settings, "SELECT COUNT(*) FROM TABLE_CLIENTS_REGLE"),
            Number(settings, "SELECT COALESCE(SUM(MONTANT),0) FROM TABLE_CLIENTS_REGLE"),
            Number(settings, "SELECT COUNT(*) FROM hanouty_client_settlement_operations")
        });
        Require(writer.PaymentModes().SequenceEqual(new[] { "CARTE", "ESPECES" }),
            "Customer settlement did not use LOGICA payment modes.");
        void Rejected(CustomerSettlementRequest request, string enteredPin)
        {
            var before = State();
            var rejected = false;
            try { writer.Record(request, "O'Neil", enteredPin); }
            catch (Exception) { rejected = true; }
            Require(rejected && State() == before, "Rejected settlement changed financial rows.");
        }
        var draft = new CustomerSettlementRequest("SETTLEMENT-REJECTED", "CREDIT_FIXTURE", 30m, "ESPECES", "Premier");
        Rejected(draft, "wrong PIN");
        Rejected(draft with { Amount = 0m }, pin);
        Rejected(draft with { Amount = 1.001m }, pin);
        Rejected(draft with { CustomerId = "MISSING" }, pin);
        Rejected(draft with { PaymentMode = "MISSING" }, pin);

        Sql(settings, """
            CREATE TRIGGER fail_customer_settlement_journal BEFORE INSERT
            ON hanouty_client_settlement_operations FOR EACH ROW
            SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT='Synthetic settlement journal failure';
            """);
        try { Rejected(draft, pin); }
        finally { Sql(settings, "DROP TRIGGER fail_customer_settlement_journal"); }
        Require(Balance() == 80m, "Failed settlement changed the customer credit.");

        static IEnumerable<DependencyObject> Children(DependencyObject parent)
        {
            foreach (var child in LogicalTreeHelper.GetChildren(parent).OfType<DependencyObject>())
            {
                yield return child;
                foreach (var descendant in Children(child)) yield return descendant;
            }
        }
        string PayThroughHost(string digits)
        {
            var host = Host(settings, pin);
            Exception? failure = null;
            var paid = false;
            var refreshed = false;
            try
            {
                Require(CashierEntry(host, "O'Neil", "01", "0", 0m, pin), "Settlement cashier session failed.");
                host.Window.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.ApplicationIdle,
                    new Action(() =>
                    {
                        var statement = Application.Current.Windows.OfType<CustomerCreditStatementDialog>().SingleOrDefault();
                        try
                        {
                            Require(statement is not null, "Production credit statement did not open.");
                            var grid = Children(statement!).OfType<System.Windows.Controls.DataGrid>().Single();
                            grid.SelectedItem = grid.Items.OfType<CustomerCreditStatementRow>()
                                .Single(row => row.CustomerId == "CREDIT_FIXTURE");
                            host.Window.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.ApplicationIdle,
                                new Action(() =>
                                {
                                    var settlement = Application.Current.Windows.OfType<CustomerSettlementDialog>().SingleOrDefault();
                                    try
                                    {
                                        Require(settlement is not null, "Production settlement dialog did not open.");
                                        var buttons = Children(settlement!).OfType<System.Windows.Controls.Button>().ToArray();
                                        foreach (var digit in digits)
                                            buttons.Single(b => Equals(b.Content, digit.ToString()))
                                                .RaiseEvent(new RoutedEventArgs(System.Windows.Controls.Button.ClickEvent));
                                        Children(settlement!).OfType<System.Windows.Controls.ComboBox>().Single().SelectedItem = "ESPECES";
                                        settlement!.UpdateLayout();
                                        var image = new System.Windows.Media.Imaging.RenderTargetBitmap(
                                            (int)Math.Ceiling(settlement.ActualWidth), (int)Math.Ceiling(settlement.ActualHeight),
                                            96, 96, System.Windows.Media.PixelFormats.Pbgra32);
                                        image.Render(settlement);
                                        var encoder = new System.Windows.Media.Imaging.PngBitmapEncoder();
                                        encoder.Frames.Add(System.Windows.Media.Imaging.BitmapFrame.Create(image));
                                        using (var stream = File.Create(Path.Combine(EvidenceDirectory, "customer-settlement-" + digits + ".png")))
                                            encoder.Save(stream);
                                        var save = buttons.Single(b => Equals(b.Content, "Enregistrer"));
                                        // This opens the real Host PIN dialog and submits the production writer.
                                        ReviewThroughDialog(host, pin, true, () =>
                                            save.RaiseEvent(new RoutedEventArgs(System.Windows.Controls.Button.ClickEvent)));
                                        paid = settlement!.DialogResult == true;
                                    }
                                    catch (Exception ex) { failure = ex; settlement?.Close(); }
                                }));
                            Children(statement!).OfType<System.Windows.Controls.Button>()
                                .Single(b => Equals(b.Content, "Régler le client sélectionné"))
                                .RaiseEvent(new RoutedEventArgs(System.Windows.Controls.Button.ClickEvent));
                            var balance = Balance();
                            refreshed = balance == 0m
                                ? !grid.Items.OfType<CustomerCreditStatementRow>().Any(r => r.CustomerId == "CREDIT_FIXTURE")
                                : grid.Items.OfType<CustomerCreditStatementRow>().Any(r =>
                                    r.CustomerId == "CREDIT_FIXTURE" && r.Balance == balance);
                        }
                        catch (Exception ex) { failure = ex; }
                        finally { statement?.Close(); }
                    }));
                Children(host.Window).OfType<System.Windows.Controls.Button>()
                    .Single(b => Equals(b.Content, "État des crédits clients"))
                    .RaiseEvent(new RoutedEventArgs(System.Windows.Controls.Button.ClickEvent));
                if (failure is not null) throw new InvalidOperationException("Real WPF settlement failed.", failure);
                Require(paid && refreshed, "Settlement did not commit and refresh the production credit statement.");
            }
            finally { host.Window.Close(); }
            return Convert.ToString(Value(settings,
                "SELECT OPERATION_ID FROM hanouty_client_settlement_operations ORDER BY SETTLEMENT_ID DESC LIMIT 1"))!;
        }
        // Use LOGICA's global-closing configuration for this isolated reconciliation scenario.
        Sql(settings, "UPDATE TABLE_PARAMETRES SET VALEUR='False' WHERE OBJET='CLOTURE_CAISSIER_OBLIGER'");
        var before = closing.Read("O'Neil", pin);
        var firstId = PayThroughHost("30");
        Require(Balance() == 50m, "Partial settlement did not reduce credit from 80 to 50; observed " + Balance());
        var afterPartial = closing.Read("O'Neil", pin);
        Require(afterPartial.ClientCash == before.ClientCash + 30m && afterPartial.Expected == before.Expected + 30m,
            "Partial customer settlement did not reconcile with cash closing.");
        var replay = new CustomerSettlementRequest(firstId, "CREDIT_FIXTURE", 30m, "ESPECES", "");
        var state = State();
        Require(new CustomerSettlementWriter(settings.ConnectionString).Record(replay, "O'Neil", pin) &&
            State() == state && Balance() == 50m, "Restart/retry duplicated the customer settlement.");
        Rejected(replay with { Amount = 31m }, pin);
        Rejected(replay with { Notes = "Different payload" }, pin);
        PayThroughHost("50");
        Require(Balance() == 0m, "Full settlement did not clear customer credit.");
        var afterFull = closing.Read("O'Neil", pin);
        Require(afterFull.ClientCash == before.ClientCash + 80m && afterFull.Expected == before.Expected + 80m,
            "Full settlement did not reconcile with cash closing.");
        var rows = Number(settings, "SELECT COUNT(*) FROM TABLE_CLIENTS_REGLE");
        closing.Close("O'Neil", pin, afterFull);
        Require(Number(settings, "SELECT COUNT(*) FROM TABLE_CLIENTS_REGLE") == rows &&
            Number(settings, "SELECT COUNT(*) FROM TABLE_CLIENTS_REGLE WHERE ID_CLIENT='CREDIT_FIXTURE' AND ID_REGLE IS NOT NULL AND CLOTURE_GLOBALE IS NULL") == 0,
            "Cash closing did not preserve and close both settlement records.");
        Require(writer.Record(replay, "O'Neil", pin) && Number(settings, "SELECT COUNT(*) FROM TABLE_CLIENTS_REGLE") == rows,
            "A retry after cash closing duplicated or reopened a customer settlement.");
        File.WriteAllText(Path.Combine(EvidenceDirectory, "customer-settlement-posting.json"),
            JsonSerializer.Serialize(new { ProductionHostAndPin = true, TouchKeypad = true, Initial = 80m,
                PartialBalance = 50m, FinalBalance = 0m, CashIncrease = 80m, ExactOnce = true,
                Rollback = true, WrongPinDenied = true, ClosedRowsPreserved = true }));
    }

    private static void VerifySupplierSettlementPosting(CatalogueSettings settings, string pin)
    {
        Sql(settings, """
            INSERT INTO TABLE_FOURNISSEURS (ID_FOURNISSEUR,FOURNISSEUR,CODE_FOURNISSEUR,CREDIT_INITIAL)
                VALUES ('SUPPLIER_FIXTURE','Fournisseur règlement','SUP-REGLE',80);
            ALTER TABLE TABLE_FOURNISSEURS_REGLE ADD ID BIGINT NOT NULL AUTO_INCREMENT PRIMARY KEY,
                ADD DATES DATETIME, ADD ID_REGLE VARCHAR(64), ADD CODE_FOURNISSEUR VARCHAR(64),
                ADD FOURNISSEUR VARCHAR(128), ADD NOTES TEXT, ADD ETAT VARCHAR(32);
            UPDATE TABLE_PASS SET CLOTURE='VISIBLE' WHERE ListUser='O''Neil';
            -- A persisted sale fixture opens a new cash-closing scope after the customer scenario.
            INSERT INTO TABLE_VENTES_ENTETE (ID_TICKET,DATES,CAISSIER,Total_NET,OPERATION)
                VALUES ('SUPPLIER-CLOSE-FIXTURE','2026-01-02','O''Neil',10,'VENTE');
            INSERT INTO TABLE_VENTES_JOURNAL (ID_TICKET,DATES,Caissier,Total_NET,OPERATION)
                VALUES ('SUPPLIER-CLOSE-FIXTURE','2026-01-02','O''Neil',10,'VENTE');
            INSERT INTO TABLE_VENTES_REGLEMENTS (ID_TICKET,DATES,CAISSIER,MONTANT,MODE_P,OPERATION)
                VALUES ('SUPPLIER-CLOSE-FIXTURE','2026-01-02','O''Neil',10,'ESPECES','VENTE');
            CREATE TABLE IF NOT EXISTS hanouty_supplier_settlement_operations (
             OPERATION_ID VARCHAR(64) CHARACTER SET ascii COLLATE ascii_bin NOT NULL PRIMARY KEY,
             ACTOR VARCHAR(128) NOT NULL,
             SUPPLIER_ID VARCHAR(255) NOT NULL,
             AMOUNT DECIMAL(18,2) NOT NULL,
             PAYMENT_MODE VARCHAR(128) NOT NULL,
             NOTES TEXT NOT NULL,
             SETTLEMENT_ID BIGINT NOT NULL UNIQUE
            ) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
            
            """);
        var writer = new SupplierSettlementWriter(settings.ConnectionString);
        var closing = new CashDrawerClosing(settings.ConnectionString);
        decimal Balance() => writer.ReadAccounts()
            .Single(row => row.SupplierId == "SUPPLIER_FIXTURE").Balance;
        string State() => string.Join("|", new[] {
            Number(settings, "SELECT COUNT(*) FROM TABLE_FOURNISSEURS_REGLE"),
            Number(settings, "SELECT COALESCE(SUM(MONTANT),0) FROM TABLE_FOURNISSEURS_REGLE"),
            Number(settings, "SELECT COUNT(*) FROM hanouty_supplier_settlement_operations")
        });
        Require(writer.PaymentModes().SequenceEqual(new[] { "CARTE", "ESPECES" }),
            "Customer settlement did not use LOGICA payment modes.");
        void Rejected(SupplierSettlementRequest request, string enteredPin)
        {
            var before = State();
            var rejected = false;
            try { writer.Record(request, "O'Neil", enteredPin); }
            catch (Exception) { rejected = true; }
            Require(rejected && State() == before, "Rejected settlement changed financial rows.");
        }
        var draft = new SupplierSettlementRequest("SUPPLIER-SETTLEMENT-REJECTED", "SUPPLIER_FIXTURE", 30m, "ESPECES", "Premier");
        Rejected(draft, "wrong PIN");
        Rejected(draft with { Amount = 0m }, pin);
        Rejected(draft with { Amount = 1.001m }, pin);
        Rejected(draft with { SupplierId = "MISSING" }, pin);
        Rejected(draft with { PaymentMode = "MISSING" }, pin);

        Sql(settings, """
            CREATE TRIGGER fail_supplier_settlement_journal BEFORE INSERT
            ON hanouty_supplier_settlement_operations FOR EACH ROW
            SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT='Synthetic settlement journal failure';
            """);
        try { Rejected(draft, pin); }
        finally { Sql(settings, "DROP TRIGGER fail_supplier_settlement_journal"); }
        Require(Balance() == 80m, "Failed settlement changed the customer credit.");

        static IEnumerable<DependencyObject> Children(DependencyObject parent)
        {
            foreach (var child in LogicalTreeHelper.GetChildren(parent).OfType<DependencyObject>())
            {
                yield return child;
                foreach (var descendant in Children(child)) yield return descendant;
            }
        }
        string PayThroughHost(string digits)
        {
            var host = Host(settings, pin);
            Exception? failure = null;
            var paid = false;
            var refreshed = false;
            try
            {
                Require(CashierEntry(host, "O'Neil", "01", "0", 0m, pin), "Settlement cashier session failed.");
                host.Window.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.ApplicationIdle,
                    new Action(() =>
                    {
                        var statement = Application.Current.Windows.OfType<SupplierAccountsDialog>().SingleOrDefault();
                        try
                        {
                            Require(statement is not null, "Production credit statement did not open.");
                            var grid = Children(statement!).OfType<System.Windows.Controls.DataGrid>().Single();
                            grid.SelectedItem = grid.Items.OfType<SupplierSettlementRow>()
                                .Single(row => row.SupplierId == "SUPPLIER_FIXTURE");
                            host.Window.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.ApplicationIdle,
                                new Action(() =>
                                {
                                    var settlement = Application.Current.Windows.OfType<SupplierSettlementDialog>().SingleOrDefault();
                                    try
                                    {
                                        Require(settlement is not null, "Production settlement dialog did not open.");
                                        var buttons = Children(settlement!).OfType<System.Windows.Controls.Button>().ToArray();
                                        foreach (var digit in digits)
                                            buttons.Single(b => Equals(b.Content, digit.ToString()))
                                                .RaiseEvent(new RoutedEventArgs(System.Windows.Controls.Button.ClickEvent));
                                        Children(settlement!).OfType<System.Windows.Controls.ComboBox>().Single().SelectedItem = "ESPECES";
                                        settlement!.UpdateLayout();
                                        var image = new System.Windows.Media.Imaging.RenderTargetBitmap(
                                            (int)Math.Ceiling(settlement.ActualWidth), (int)Math.Ceiling(settlement.ActualHeight),
                                            96, 96, System.Windows.Media.PixelFormats.Pbgra32);
                                        image.Render(settlement);
                                        var encoder = new System.Windows.Media.Imaging.PngBitmapEncoder();
                                        encoder.Frames.Add(System.Windows.Media.Imaging.BitmapFrame.Create(image));
                                        using (var stream = File.Create(Path.Combine(EvidenceDirectory, "supplier-settlement-" + digits + ".png")))
                                            encoder.Save(stream);
                                        var save = buttons.Single(b => Equals(b.Content, "Enregistrer"));
                                        // This opens the real Host PIN dialog and submits the production writer.
                                        ReviewThroughDialog(host, pin, true, () =>
                                            save.RaiseEvent(new RoutedEventArgs(System.Windows.Controls.Button.ClickEvent)));
                                        paid = settlement!.DialogResult == true;
                                    }
                                    catch (Exception ex) { failure = ex; settlement?.Close(); }
                                }));
                            Children(statement!).OfType<System.Windows.Controls.Button>()
                                .Single(b => Equals(b.Content, "Régler le fournisseur sélectionné"))
                                .RaiseEvent(new RoutedEventArgs(System.Windows.Controls.Button.ClickEvent));
                            var balance = Balance();
                            refreshed = grid.Items.OfType<SupplierSettlementRow>().Any(r =>
                                r.SupplierId == "SUPPLIER_FIXTURE" && r.Balance == balance);
                        }
                        catch (Exception ex) { failure = ex; }
                        finally { statement?.Close(); }
                    }));
                Children(host.Window).OfType<System.Windows.Controls.Button>()
                    .Single(b => Equals(b.Content, "Comptes et règlements fournisseurs"))
                    .RaiseEvent(new RoutedEventArgs(System.Windows.Controls.Button.ClickEvent));
                if (failure is not null) throw new InvalidOperationException("Real WPF settlement failed.", failure);
                Require(paid && refreshed, "Settlement did not commit and refresh the production credit statement.");
            }
            finally { host.Window.Close(); }
            return Convert.ToString(Value(settings,
                "SELECT OPERATION_ID FROM hanouty_supplier_settlement_operations ORDER BY SETTLEMENT_ID DESC LIMIT 1"))!;
        }
        // Use LOGICA's global-closing configuration for this isolated reconciliation scenario.
        Sql(settings, "UPDATE TABLE_PARAMETRES SET VALEUR='False' WHERE OBJET='CLOTURE_CAISSIER_OBLIGER'");
        var before = closing.Read("O'Neil", pin);
        var firstId = PayThroughHost("30");
        Require(Balance() == 50m, "Partial settlement did not reduce credit from 80 to 50; observed " + Balance());
        var afterPartial = closing.Read("O'Neil", pin);
        Require(afterPartial.SupplierCash == before.SupplierCash + 30m && afterPartial.Expected == before.Expected - 30m,
            "Partial customer settlement did not reconcile with cash closing.");
        var replay = new SupplierSettlementRequest(firstId, "SUPPLIER_FIXTURE", 30m, "ESPECES", "");
        var state = State();
        Require(new SupplierSettlementWriter(settings.ConnectionString).Record(replay, "O'Neil", pin) &&
            State() == state && Balance() == 50m, "Restart/retry duplicated the customer settlement.");
        Rejected(replay with { Amount = 31m }, pin);
        Rejected(replay with { Notes = "Different payload" }, pin);
        PayThroughHost("50");
        Require(Balance() == 0m, "Full settlement did not clear customer credit.");
        var afterFull = closing.Read("O'Neil", pin);
        Require(afterFull.SupplierCash == before.SupplierCash + 80m && afterFull.Expected == before.Expected - 80m,
            "Full settlement did not reconcile with cash closing.");
        var rows = Number(settings, "SELECT COUNT(*) FROM TABLE_FOURNISSEURS_REGLE");
        closing.Close("O'Neil", pin, afterFull);
        Require(Number(settings, "SELECT COUNT(*) FROM TABLE_FOURNISSEURS_REGLE") == rows &&
            Number(settings, "SELECT COUNT(*) FROM TABLE_FOURNISSEURS_REGLE WHERE ID_FOURNISSEUR='SUPPLIER_FIXTURE' AND ID_REGLE IS NOT NULL AND CLOTURE_GLOBALE IS NULL") == 0,
            "Cash closing did not preserve and close both settlement records.");
        Require(writer.Record(replay, "O'Neil", pin) && Number(settings, "SELECT COUNT(*) FROM TABLE_FOURNISSEURS_REGLE") == rows,
            "A retry after cash closing duplicated or reopened a customer settlement.");
        File.WriteAllText(Path.Combine(EvidenceDirectory, "supplier-settlement-posting.json"),
            JsonSerializer.Serialize(new { ProductionHostAndPin = true, TouchKeypad = true, Initial = 80m,
                PartialBalance = 50m, FinalBalance = 0m, CashDecrease = 80m, ExactOnce = true,
                Rollback = true, WrongPinDenied = true, ClosedRowsPreserved = true }));
    }


    private static void VerifyCardPayment(CatalogueSettings settings, string pin)
    {
        var cardTotal = Number(settings, "SELECT PRIX_V_1 FROM TABLE_ARTICLES WHERE ID_ARTICLE='W2-Article'");
        Sql(settings, "DELETE FROM TABLE_PARAMETRES WHERE OBJET='FENETRE_MODE_P'; INSERT INTO TABLE_PARAMETRES VALUES ('FENETRE_MODE_P','False');");
        var port = Hanouty.Checkout.MariaDb.MariaDbCashCheckoutServices.CreatePostingPort(
            () => new MySqlConnection(settings.ConnectionString), "01", () => pin);
        var request = new AuthorizedCheckoutRequest("CARD-CONFIG-DENIED", "O'Neil", "MAD", false,
            new[] { new CheckoutBatchLine("W2-Article", 1) },
            new[] { new CheckoutPayment(CheckoutPaymentKind.Card, cardTotal) }, cardTotal);
        void Rejected(AuthorizedCheckoutRequest rejectedRequest, string expectedReason)
        {
            var before = Snapshot(settings);
            var rejected = false;
            try { port.Commit(rejectedRequest); }
            catch (Exception ex) when (ex.Message.Contains(expectedReason, StringComparison.Ordinal)) { rejected = true; }
            Require(rejected && Snapshot(settings) == before, "Rejected card posting changed financial or stock state.");
        }
        Rejected(request, "Les modes de paiement sont désactivés.");
        Sql(settings, "UPDATE TABLE_PARAMETRES SET VALEUR='True' WHERE OBJET='FENETRE_MODE_P'; DELETE FROM TABLE_MODE_P WHERE MODE_P='CARTE';");
        Rejected(request with { OperationId = "CARD-MODE-MISSING" }, "Le mode CARTE est absent");
        Sql(settings, "INSERT INTO TABLE_MODE_P VALUES ('CARTE')");
        Rejected(request with { OperationId = "CARD-OVERPAY", Payments = new[] { new CheckoutPayment(CheckoutPaymentKind.Card, cardTotal + 0.01m) } }, "Card amount must equal");
        Rejected(request with { OperationId = "CARD-UNDERPAY", Payments = new[] { new CheckoutPayment(CheckoutPaymentKind.Card, cardTotal - 0.01m) } }, "Card amount must equal");
        Rejected(request with { OperationId = "CARD-REFUND-DENIED", IsReturn = true, OriginalTicketId = "original-card" }, "cash refunds only");
        Sql(settings, """
            CREATE TRIGGER fail_card_payment BEFORE INSERT ON TABLE_VENTES_REGLEMENTS
            FOR EACH ROW SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT='Synthetic card payment failure';
            """);
        try { Rejected(request with { OperationId = "CARD-ROLLBACK" }, "Synthetic card payment failure"); }
        finally { Sql(settings, "DROP TRIGGER fail_card_payment"); }

        static IEnumerable<DependencyObject> Children(DependencyObject parent)
        {
            foreach (var child in LogicalTreeHelper.GetChildren(parent).OfType<DependencyObject>())
            {
                yield return child;
                foreach (var nested in Children(child)) yield return nested;
            }
        }
        (bool Accepted, string? Operation) FromButton(CatalogueHost host, bool confirm, string enteredPin)
        {
            Exception? failure = null;
            string? operation = null;
            var reviewed = false;
            System.Windows.Controls.PasswordBox? enteredPinControl = null;
            host.Window.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.ApplicationIdle, new Action(() =>
            {
                var dialog = Application.Current.Windows.OfType<CardPaymentDialog>().SingleOrDefault();
                try
                {
                    Require(dialog is not null && Children(dialog).OfType<System.Windows.Controls.TextBlock>()
                        .Any(block => block.Text == cardTotal.ToString("N2", CultureInfo.CurrentCulture) + " DH"),
                        "Card review did not display the authoritative total.");
                    Require(!host.Window.ShowCashierEntry() && !host.Window.EndFinancialSession(),
                        "Card review allowed cashier entry or logout.");
                    reviewed = true;
                    if (!confirm) { dialog!.Close(); return; }
                    host.Window.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.ApplicationIdle, new Action(() =>
                    {
                        var pinDialog = Application.Current.Windows.Cast<Window>()
                            .SingleOrDefault(w => w.Owner == host.Window &&
                                Children(w).OfType<System.Windows.Controls.PasswordBox>().Any());
                        try
                        {
                            Require(pinDialog is not null, "Card posting did not request a fresh cashier PIN.");
                            operation = host.ViewModel.PendingOperationId;
                            Require(!string.IsNullOrWhiteSpace(operation), "Card posting did not retain a stable operation ID.");
                            var password = Children(pinDialog!).OfType<System.Windows.Controls.PasswordBox>().Single();
                            enteredPinControl = password;
                            password.Password = enteredPin;
                            Children(pinDialog!).OfType<System.Windows.Controls.Button>().Single(button => button.IsDefault)
                                .RaiseEvent(new RoutedEventArgs(System.Windows.Controls.Button.ClickEvent));
                        }
                        catch (Exception ex) { failure = ex; pinDialog?.Close(); }
                    }));
                    Children(dialog!).OfType<System.Windows.Controls.Button>()
                        .Single(button => Equals(button.Content, "Confirmer le paiement CARTE"))
                        .RaiseEvent(new RoutedEventArgs(System.Windows.Controls.Button.ClickEvent));
                }
                catch (Exception ex) { failure = ex; dialog?.Close(); }
            }));
            var accepted = host.Window.PayByCard();
            if (failure is not null) throw new InvalidOperationException("Production card UI failed: " + failure.Message, failure);
            if (enteredPinControl is not null) Require(enteredPinControl.Password.Length == 0, "Card posting retained the cashier PIN.");
            Require(reviewed, "Card payment button did not open its review.");
            return (accepted, operation);
        }
        CatalogueHost Workstation()
        {
            var host = CatalogueHost.CreateCashierWorkstation(settings, "01");
            Require(CashierEntry(host, "O'Neil", "01", "0", 0m, pin), "Card test cashier login failed.");
            host.ViewModel.ScannerText = "CODE'1";
            host.ViewModel.ScanCommand.Execute(null);
            Require(host.Session.PendingCount == 1, "Card test did not stage the real scanner selection.");
            return host;
        }
        var deniedHost = Workstation();
        try
        {
            Sql(settings, "UPDATE TABLE_PARAMETRES SET VALEUR='False' WHERE OBJET='FENETRE_MODE_P'");
            var before = Snapshot(settings);
            Require(!deniedHost.Window.PayByCard() && Snapshot(settings) == before &&
                deniedHost.ViewModel.PendingOperationId is null,
                "Disabled payment modes minted a card operation.");
            Sql(settings, "UPDATE TABLE_PARAMETRES SET VALEUR='True' WHERE OBJET='FENETRE_MODE_P'");
            Require(!FromButton(deniedHost, false, pin).Accepted && Snapshot(settings) == before &&
                deniedHost.ViewModel.PendingOperationId is null, "Cancelled card review changed SQL or minted an operation.");
            Require(!FromButton(deniedHost, true, "wrong PIN").Accepted &&
                deniedHost.ViewModel.CheckoutUncertain && Snapshot(settings) == before,
                "Wrong card PIN changed financial state or unlocked an uncertain operation.");
        }
        finally { deniedHost.Window.Close(); }
        var stockBefore = Number(settings, "SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='W2-Article'");
        var successfulHost = Workstation();
        string committedOperation;
        try
        {
            var posted = FromButton(successfulHost, true, pin);
            Require(posted.Accepted && posted.Operation is not null &&
                successfulHost.ViewModel.PendingOperationId is null && successfulHost.Session.PendingCount == 0,
                "Card sale did not commit: " + successfulHost.ViewModel.CommitFeedback + "; pending=" + successfulHost.Session.PendingCount);
            committedOperation = posted.Operation!;
            Require(!successfulHost.Window.PayByCard(), "Consumed card payment context authorized a second operation.");
        }
        finally { successfulHost.Window.Close(); }
        Require(Number(settings, "SELECT COUNT(*) FROM TABLE_VENTES_ENTETE WHERE ID_TICKET=@id AND OPERATION='VENTE'", committedOperation) == 1 &&
            Number(settings, "SELECT COUNT(*) FROM TABLE_VENTES_REGLEMENTS WHERE ID_TICKET=@id AND MODE_P='CARTE' ", committedOperation) == 1 &&
            Number(settings, "SELECT COUNT(*) FROM TABLE_VENTES_REGLEMENTS WHERE ID_TICKET=@id AND MODE_P='ESPECES'", committedOperation) == 0 &&
            Number(settings, "SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='W2-Article'") == stockBefore - 1m,
            "Card receipt, payment and stock do not reconcile.");
        Require(Number(settings, "SELECT Total_NET FROM TABLE_VENTES_ENTETE WHERE ID_TICKET=@id", committedOperation) == cardTotal &&
            Number(settings, "SELECT MONTANT FROM TABLE_VENTES_REGLEMENTS WHERE ID_TICKET=@id", committedOperation) == cardTotal,
            "Persisted card amounts differ from the authoritative total.");
        var snapshot = Snapshot(settings);
        port.Commit(request with { OperationId = committedOperation });
        Require(Snapshot(settings) == snapshot, "Card retry duplicated the sale.");
        using (var db = Open(settings))
        {
            var ticket = LogicaPostedTicket.Read(db, committedOperation, "O'Neil", "01");
            var lines = ticket!.FormatFrenchThreeColumnPayment(value => value.ToString("0.00", CultureInfo.CurrentCulture));
            Require(lines.Count == 2 && lines[0].Contains("CARTE") && lines[1].Contains("RENDU"),
                "Persisted card payment could not render the original FR_3C payment summary.");
        }
        var closing = new CashDrawerClosing(settings.ConnectionString);
        var summary = closing.Read("O'Neil", pin);
        Require(summary.CashSales == 0m && summary.NetSales == cardTotal && summary.Expected == summary.Opening,
            "Card sale inflated expected physical cash.");
        closing.Close("O'Neil", pin, summary);
        Require(Number(settings, "SELECT COUNT(*) FROM TABLE_VENTES_REGLEMENTS WHERE ID_TICKET=@id AND CLOTURE_GLOBALE IS NOT NULL", committedOperation) == 1,
            "Card payment did not participate in global cash closing.");
        File.WriteAllText(Path.Combine(EvidenceDirectory, "w2-card-sale.json"),
            JsonSerializer.Serialize(new { ProductionButton = true, FreshPin = true, Amount = cardTotal,
                CardRows = 1, CashRows = 0, PhysicalCashIncrease = 0m, StockChange = -1m,
                ConfigurationDenied = true, ExactAmountOnly = true, Rollback = true, Replay = true,
                ActualBankTerminalTested = false }));
    }


    private static void VerifyMixedPayment(CatalogueSettings settings, string pin)
    {
        var previousCulture = CultureInfo.CurrentCulture;
        CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("fr-FR");
        try
        {
            var total = Number(settings, "SELECT PRIX_V_1 FROM TABLE_ARTICLES WHERE ID_ARTICLE='W2-Article'");
            const decimal cashReceived = 1m;
            Require(total > .5m, "Mixed fixture requires a positive card portion; observed total " + total);
            var cardPart = total - .5m;
            var change = cashReceived + cardPart - total;
            var port = Hanouty.Checkout.MariaDb.MariaDbCashCheckoutServices.CreatePostingPort(
                () => new MySqlConnection(settings.ConnectionString), "01", () => pin);
            var request = new AuthorizedCheckoutRequest("MIXED-TEST", "O'Neil", "MAD", false,
                new[] { new CheckoutBatchLine("W2-Article", 1) }, new[] {
                    new CheckoutPayment(CheckoutPaymentKind.Cash, cashReceived),
                    new CheckoutPayment(CheckoutPaymentKind.Card, cardPart) }, total);
            void Rejected(AuthorizedCheckoutRequest candidate, string reason)
            {
                var before = Snapshot(settings);
                var rejected = false;
                try { port.Commit(candidate); }
                catch (Exception ex) when (ex.Message.Contains(reason, StringComparison.Ordinal)) { rejected = true; }
                Require(rejected && Snapshot(settings) == before, "Rejected mixed payment changed SQL or stock.");
            }
            Sql(settings, "UPDATE TABLE_PARAMETRES SET VALEUR='False' WHERE OBJET='FENETRE_MODE_P'");
            Rejected(request with { OperationId = "MIXED-CONFIG" }, "modes de paiement sont désactivés");
            Sql(settings, "UPDATE TABLE_PARAMETRES SET VALEUR='True' WHERE OBJET='FENETRE_MODE_P'");
            Rejected(request with { OperationId = "MIXED-UNDER", Payments = new[] {
                new CheckoutPayment(CheckoutPaymentKind.Cash, .01m), new CheckoutPayment(CheckoutPaymentKind.Card, .01m) } },
                "Cash tender must cover");
            Rejected(request with { OperationId = "MIXED-CARD-EXCESS", Payments = new[] {
                new CheckoutPayment(CheckoutPaymentKind.Cash, 1m), new CheckoutPayment(CheckoutPaymentKind.Card, total) } },
                "Mixed card component must be below");
            Rejected(request with { OperationId = "MIXED-PRECISION", Payments = new[] {
                new CheckoutPayment(CheckoutPaymentKind.Cash, 5.001m), new CheckoutPayment(CheckoutPaymentKind.Card, cardPart) } },
                "Payment components require whole cents");
            Rejected(request with { OperationId = "MIXED-REFUND", IsReturn = true, OriginalTicketId = "original-mixed" },
                "cash refunds only");
            Sql(settings, """
                CREATE TRIGGER fail_mixed_card BEFORE INSERT ON TABLE_VENTES_REGLEMENTS FOR EACH ROW
                BEGIN
                    IF NEW.MODE_P='CARTE' THEN
                        SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT='Synthetic second-tender failure';
                    END IF;
                END;
                """);
            try { Rejected(request with { OperationId = "MIXED-ROLLBACK" }, "Synthetic second-tender failure"); }
            finally { Sql(settings, "DROP TRIGGER fail_mixed_card"); }

            static IEnumerable<DependencyObject> Children(DependencyObject parent)
            {
                foreach (var child in LogicalTreeHelper.GetChildren(parent).OfType<DependencyObject>())
                {
                    yield return child;
                    foreach (var nested in Children(child)) yield return nested;
                }
            }
            var mixedStockBefore = Number(settings, "SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE=\'W2-Article\'");
            var workstation = CatalogueHost.CreateCashierWorkstation(settings, "01");
            string? operation = null;
            try
            {
                Require(CashierEntry(workstation, "O'Neil", "01", "0", 0m, pin), "Mixed cashier login failed.");
                workstation.ViewModel.ScannerText = "CODE'1";
                workstation.ViewModel.ScanCommand.Execute(null);
                Require(workstation.Session.PendingCount == 1, "Mixed scanner did not stage the basket.");
                bool FromButton(bool confirm)
                {
                    Exception? failure = null;
                    System.Windows.Controls.PasswordBox? entered = null;
                    var reviewed = false;
                    workstation.Window.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.ApplicationIdle, new Action(() =>
                    {
                        var dialog = Application.Current.Windows.OfType<MixedPaymentDialog>().SingleOrDefault();
                        try
                        {
                            Require(dialog is not null, "Mixed payment review did not open.");
                            reviewed = true;
                            Require(!workstation.Window.PayByCard() && !workstation.Window.PayMixed() &&
                                !workstation.Window.EndFinancialSession(), "Mixed review allowed another payment/logout.");
                            if (!confirm) { dialog!.Close(); return; }
                            var cardField = Children(dialog!).OfType<System.Windows.Controls.TextBox>().Single(field =>
                                System.Windows.Automation.AutomationProperties.GetName(field) == "Montant CARTE");
                            Require(cardField.IsReadOnly, "Mixed card amount required physical typing.");
                            workstation.Window.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.ApplicationIdle, new Action(() =>
                            {
                                var numeric = Application.Current.Windows.OfType<TouchNumericEntryDialog>().SingleOrDefault();
                                try
                                {
                                    Require(numeric is not null, "Mixed card amount did not open the numeric keypad.");
                                    var keys = Children(numeric!).OfType<System.Windows.Controls.Button>().ToArray();
                                    foreach (var digit in cardPart.ToString("0.##", CultureInfo.CurrentCulture))
                                        keys.Single(button => Equals(button.Content, digit.ToString()))
                                            .RaiseEvent(new RoutedEventArgs(System.Windows.Controls.Button.ClickEvent));
                                    keys.Single(button => Equals(button.Content, "Appliquer"))
                                        .RaiseEvent(new RoutedEventArgs(System.Windows.Controls.Button.ClickEvent));
                                }
                                catch (Exception ex) { failure = ex; numeric?.Close(); }
                            }));
                            cardField.RaiseEvent(new System.Windows.Input.MouseButtonEventArgs(
                                System.Windows.Input.Mouse.PrimaryDevice, 0, System.Windows.Input.MouseButton.Left)
                                { RoutedEvent = UIElement.PreviewMouseLeftButtonDownEvent });
                            if (failure is not null) throw failure;
                            Children(dialog!).OfType<System.Windows.Controls.Button>()
                                .Single(button => System.Windows.Automation.AutomationProperties.GetName(button) == "1 DH")
                                .RaiseEvent(new RoutedEventArgs(System.Windows.Controls.Button.ClickEvent));
                            Require(Children(dialog!).OfType<System.Windows.Controls.TextBlock>().Any(block =>
                                block.Text == "RENDU : " + change.ToString("N2") + " DH"),
                                "Mixed review displayed incorrect French fractional change.");
                            workstation.Window.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.ApplicationIdle, new Action(() =>
                            {
                                var pinDialog = Application.Current.Windows.Cast<Window>().SingleOrDefault(window =>
                                    window.Owner == workstation.Window && Children(window).OfType<System.Windows.Controls.PasswordBox>().Any());
                                try
                                {
                                    Require(pinDialog is not null, "Mixed posting did not request PIN.");
                                    operation = workstation.ViewModel.PendingOperationId;
                                    entered = Children(pinDialog!).OfType<System.Windows.Controls.PasswordBox>().Single();
                                    entered.Password = pin;
                                    Children(pinDialog!).OfType<System.Windows.Controls.Button>().Single(button => button.IsDefault)
                                        .RaiseEvent(new RoutedEventArgs(System.Windows.Controls.Button.ClickEvent));
                                }
                                catch (Exception ex) { failure = ex; pinDialog?.Close(); }
                            }));
                            Children(dialog!).OfType<System.Windows.Controls.Button>()
                                .Single(button => Equals(button.Content, "Confirmer le paiement mixte"))
                                .RaiseEvent(new RoutedEventArgs(System.Windows.Controls.Button.ClickEvent));
                        }
                        catch (Exception ex) { failure = ex; dialog?.Close(); }
                    }));
                    var result = workstation.Window.PayMixed();
                    if (failure is not null) throw new InvalidOperationException("Mixed WPF flow failed: " + failure.Message, failure);
                    Require(reviewed, "Mixed payment entry did not open.");
                    if (entered is not null) Require(entered.Password.Length == 0, "Mixed PIN was retained.");
                    return result;
                }
                var beforeReview = Snapshot(settings);
                Require(!FromButton(false) && Snapshot(settings) == beforeReview &&
                    workstation.ViewModel.PendingOperationId is null, "Cancelled mixed payment changed SQL or operation identity.");
                Require(FromButton(true) && operation is not null && workstation.Session.PendingCount == 0 &&
                    !workstation.ViewModel.CheckoutUncertain, "Mixed sale did not commit: " + workstation.ViewModel.CommitFeedback);
            }
            finally { workstation.Window.Close(); }
            Require(Number(settings, "SELECT COUNT(*) FROM TABLE_VENTES_REGLEMENTS WHERE ID_TICKET=@id", operation) == 3 &&
                Number(settings, "SELECT MONTANT FROM TABLE_VENTES_REGLEMENTS WHERE ID_TICKET=@id AND MODE_P='CARTE'", operation) == cardPart &&
                Number(settings, "SELECT SUM(MONTANT) FROM TABLE_VENTES_REGLEMENTS WHERE ID_TICKET=@id AND MODE_P='ESPECES'", operation) == total - cardPart &&
                Number(settings, "SELECT MONTANT FROM TABLE_VENTES_REGLEMENTS WHERE ID_TICKET=@id AND MODE_P='ESPECES' AND MONTANT<0", operation) == -change,
                "Mixed cash/card/change rows do not reconcile.");
            Require(Number(settings, "SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE=\'W2-Article\'") == mixedStockBefore - 1m,
                "Mixed payment did not decrement stock exactly once.");
            var stable = Snapshot(settings);
            port.Commit(request with { OperationId = operation! });
            Require(Snapshot(settings) == stable, "Mixed replay duplicated posting.");
            using (var db = Open(settings))
            {
                var ticket = LogicaPostedTicket.Read(db, operation!, "O'Neil", "01");
                var printed = ticket!.FormatFrenchThreeColumnPayment(value => value.ToString("0.00"));
                Require(printed.Count == 3 && printed[0].Contains("ESPECES") && printed[1].Contains("CARTE") &&
                    printed[2].Contains(change.ToString("0.00")), "Mixed persisted receipt lost tender/change.");
            }
            var closing = new CashDrawerClosing(settings.ConnectionString);
            var summary = closing.Read("O'Neil", pin);
            Require(summary.CashSales == total - cardPart && summary.NetSales == total &&
                summary.Expected == summary.Opening + total - cardPart, "Mixed closing counted card as physical cash.");
            closing.Close("O'Neil", pin, summary);
            Require(Number(settings, "SELECT COUNT(*) FROM TABLE_VENTES_REGLEMENTS WHERE ID_TICKET=@id AND CLOTURE_GLOBALE IS NOT NULL", operation) == 3,
                "Mixed closing omitted a tender/change row.");
            port.Commit(request with { OperationId = operation! });
            Require(Number(settings, "SELECT COUNT(*) FROM TABLE_VENTES_REGLEMENTS WHERE ID_TICKET=@id", operation) == 3,
                "Mixed replay after closing duplicated payment rows.");
            File.WriteAllText(Path.Combine(EvidenceDirectory, "w2-mixed-sale.json"),
                JsonSerializer.Serialize(new { OriginalPaymentReadService = true, ProductionTouchAndPin = true,
                    Total = total, Card = cardPart, CashReceived = cashReceived, Change = change,
                    PhysicalCashIncrease = total - cardPart, RejectedUnderpayment = true, RollbackSecondTender = true,
                    ExactOnce = true, FrenchFractionalChange = true, ActualBankTerminalTested = false }));
        }
        finally { CultureInfo.CurrentCulture = previousCulture; }
    }



    private static void VerifyInteractiveReturnCycle(CatalogueSettings settings, string pin)
    {
        Sql(settings, """
            INSERT INTO TABLE_ARTICLES
                (ID_ARTICLE,STOCK,Code,Article,Famille,PRIX_A,PRIX_MP,PRIX_V_1,TAUX_TVA,GROUPE,PROMOTION,PRIX_QTE)
            VALUES ('RETURN-CYCLE',5,'RETURN-CODE','Cycle retour','Food',1,1,5.25,20,'G',0,0);
            """);
        var dropAcknowledgement = false;
        var host = CatalogueHost.CreateCashierWorkstationWithAcknowledgementFault(settings, "01", () =>
        {
            if (!dropAcknowledgement) return;
            dropAcknowledgement = false;
            throw new IOException("interactive-refund-after-real-commit");
        });
        Exception? failure = null;
        static IEnumerable<DependencyObject> Children(DependencyObject parent)
        {
            foreach (var child in LogicalTreeHelper.GetChildren(parent).OfType<DependencyObject>())
            {
                yield return child;
                foreach (var nested in Children(child)) yield return nested;
            }
        }
        void Capture(string filename)
        {
            host.Window.UpdateLayout();
            var image = new System.Windows.Media.Imaging.RenderTargetBitmap(
                (int)Math.Ceiling(host.Window.ActualWidth), (int)Math.Ceiling(host.Window.ActualHeight),
                96, 96, System.Windows.Media.PixelFormats.Pbgra32);
            image.Render(host.Window);
            var encoder = new System.Windows.Media.Imaging.PngBitmapEncoder();
            encoder.Frames.Add(System.Windows.Media.Imaging.BitmapFrame.Create(image));
            using var stream = File.Create(Path.Combine(EvidenceDirectory, filename));
            encoder.Save(stream);
        }
        string CashSale(decimal received = 5.25m)
        {
            ((System.Windows.Controls.RadioButton)host.Window.FindName("SalesSection")).IsChecked = true;
            host.ViewModel.ScannerText = "RETURN-CODE";
            host.ViewModel.ScanCommand.Execute(null);
            Require(host.Session.PendingCount == 1, "Return-cycle scanner did not prepare one sale.");
            Require(host.Window.RefreshTrustedBasketTotal() &&
                ((System.Windows.Controls.TextBlock)host.Window.FindName("TrustedBasketTotal")).Text.EndsWith("5.25", StringComparison.Ordinal),
                "Next customer lost the authoritative visible total before tender entry.");
            Capture("daily-next-customer-total.png");
            host.Window.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.ApplicationIdle, new Action(() =>
            {
                var dialog = Application.Current.Windows.OfType<CashierEntryDialog>().SingleOrDefault();
                try
                {
                    Require(dialog is not null && dialog.Title == "Paiement en espèces", "Return cycle forced another login.");
                    var buttons = Children(dialog!).OfType<System.Windows.Controls.Button>().ToArray();
                    void Touch(string label) => buttons.Single(button => Equals(button.Content, label))
                        .RaiseEvent(new RoutedEventArgs(System.Windows.Controls.Button.ClickEvent));
                    Touch("Pavé numérique");
                    foreach (var digit in received.ToString("0.##", CultureInfo.InvariantCulture)) Touch(digit.ToString());
                    Touch("Appliquer le montant");
                    buttons.Single(button => button.IsDefault).RaiseEvent(new RoutedEventArgs(System.Windows.Controls.Button.ClickEvent));
                }
                catch (Exception ex) { failure = ex; dialog?.Close(); }
            }));
            Children(host.Window).OfType<System.Windows.Controls.Button>().Single(button =>
                System.Windows.Automation.AutomationProperties.GetName(button) == "Enter sale cash tender")
                .RaiseEvent(new RoutedEventArgs(System.Windows.Controls.Button.ClickEvent));
            if (failure is not null) throw failure;
            string? operation = null;
            host.Window.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.ApplicationIdle,
                new Action(() => operation = host.ViewModel.PendingOperationId));
            ReviewThroughDialog(host, pin, true, () => host.ViewModel.CommitCommand.Execute(null));
            Require(operation is not null && !host.ViewModel.CheckoutUncertain && host.ViewModel.PaymentContext is null &&
                host.Session.PendingCount == 0 && host.ViewModel.FinancialSessionActive,
                "Return-cycle cash sale did not finish with consumed tender and active identity: " + host.ViewModel.CommitFeedback);
            return operation!;
        }
        try
        {
            Require(CashierEntry(host, "O'Neil", "01", "0", 0m, pin), "Return-cycle cashier login failed.");
            var original = CashSale(10m);
            Require(Number(settings, "SELECT SUM(MONTANT) FROM TABLE_VENTES_REGLEMENTS WHERE ID_TICKET=@id", original) == 5.25m &&
                Number(settings, "SELECT COUNT(*) FROM TABLE_VENTES_REGLEMENTS WHERE ID_TICKET=@id", original) == 2,
                "Return-cycle original did not retain received cash and signed change.");
            var receipt = Convert.ToString(Value(settings,
                "SELECT TICKET FROM TABLE_VENTES_ENTETE WHERE ID_TICKET=@id", original), CultureInfo.InvariantCulture)!;
            Require(receipt != original && !string.IsNullOrWhiteSpace(receipt), "Fixture lacks the printed receipt number.");
            ((System.Windows.Controls.RadioButton)host.Window.FindName("ReturnsSection")).IsChecked = true;
            ((System.Windows.Controls.TextBox)host.Window.FindName("OriginalSaleSearch")).Text = receipt;
            Children(host.Window).OfType<System.Windows.Controls.Button>().Single(button => Equals(button.Content, "Rechercher le ticket"))
                .RaiseEvent(new RoutedEventArgs(System.Windows.Controls.Button.ClickEvent));
            var results = (System.Windows.Controls.ListBox)host.Window.FindName("OriginalSaleResults");
            var candidate = results.Items.Cast<OriginalSaleCandidate>().Single(row => row.SaleId == original);
            results.SelectedItem = candidate;
            Children(host.Window).OfType<System.Windows.Controls.Button>().Single(button => Equals(button.Content, "Vérifier le ticket sélectionné"))
                .RaiseEvent(new RoutedEventArgs(System.Windows.Controls.Button.ClickEvent));
            Require(host.Window.SelectOriginalSale(candidate), "Printed receipt did not preserve canonical original identity.");
            Capture("daily-original-receipt-return.png");
            var before = Number(settings, "SELECT COUNT(*) FROM hanouty_checkout_operations");
            dropAcknowledgement = true;
            ReviewThroughDialog(host, pin, true, () => Children(host.Window).OfType<System.Windows.Controls.Button>()
                .Single(button => Equals(button.Content, "Rembourser le ticket en espèces"))
                .RaiseEvent(new RoutedEventArgs(System.Windows.Controls.Button.ClickEvent)));
            Require(host.ViewModel.CheckoutUncertain && !host.ViewModel.CanCommit &&
                host.ViewModel.PendingOperationId is not null &&
                Number(settings, "SELECT COUNT(*) FROM hanouty_checkout_operations") == before + 1 &&
                Number(settings, "SELECT COUNT(*) FROM hanouty_cash_return_consumption WHERE original_ticket_id=@id", original) == 1 &&
                Number(settings, "SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='RETURN-CYCLE'") == 5m,
                "Actual refund lost-acknowledgement did not persist exactly once and lock the UI: " + host.ViewModel.CommitFeedback +
                "; state=" + host.Session.State + "; operations=" + Number(settings, "SELECT COUNT(*) FROM hanouty_checkout_operations") +
                "; before=" + before + "; claim=" + Number(settings, "SELECT COUNT(*) FROM hanouty_cash_return_consumption WHERE original_ticket_id=@id", original) +
                "; stock=" + Number(settings, "SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE=\'RETURN-CYCLE\'"));
            var persisted = Snapshot(settings);
            Require(!host.Window.ConfirmReturnDraft() && Snapshot(settings) == persisted,
                "Uncertain refund repeated the financial write.");
            host.ViewModel.ReconcileCommand.Execute(null);
            Require(host.ViewModel.CheckoutUncertain && host.Session.State == CheckoutCommitState.Ready,
                "Refund reconciliation skipped explicit cashier review.");
            ReviewThroughDialog(host, "incorrect", true);
            Require(host.ViewModel.CheckoutUncertain && Snapshot(settings) == persisted,
                "Invalid PIN unlocked a persisted refund.");
            ReviewThroughDialog(host, pin, true);
            Require(!host.ViewModel.CheckoutUncertain && host.ViewModel.PendingOperationId is null &&
                host.Session.PendingCount == 0 && Snapshot(settings) == persisted,
                "Normal-login refund review failed or replayed the refund.");
            host.Window.SearchOriginalSales(receipt);
            Require(results.Items.Count == 0, "Consumed original was offered for another refund.");
            CashSale();
            Require(Number(settings, "SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='RETURN-CYCLE'") == 4m &&
                Number(settings, "SELECT COUNT(DISTINCT ID_TICKET) FROM TABLE_VENTES_JOURNAL WHERE ID_ARTICLE='RETURN-CYCLE'") == 3 &&
                Number(settings, "SELECT SUM(Total_NET) FROM TABLE_VENTES_JOURNAL WHERE ID_ARTICLE='RETURN-CYCLE'") == 5.25m,
                "Sale/refund/next-sale same-session cycle changed stock or money incorrectly.");
            Console.WriteLine("PASS: printed receipt -> same-session full cash refund -> lost acknowledgement -> fresh PIN review -> next customer; no duplicate refund.");
        }
        finally { host.Window.Close(); }
    }

    private static void VerifyDailyCashierCycle(CatalogueSettings settings, string pin)
    {
        const decimal price = 6.50m;
        Sql(settings, """
            INSERT INTO TABLE_ARTICLES
                (ID_ARTICLE,STOCK,Code,Article,Famille,PRIX_A,PRIX_MP,PRIX_V_1,TAUX_TVA,GROUPE,PROMOTION,PRIX_QTE)
            VALUES ('DAILY-CYCLE',10,'DAILY-CODE','Cycle caisse','Food',1,1,6.50,20,'G',0,0);
            """);
        var workstation = CatalogueHost.CreateCashierWorkstation(settings, "01");
        Exception? failure = null;
        System.Windows.Controls.PasswordBox? entered = null;
        var postingPins = 0;
        static IEnumerable<DependencyObject> Children(DependencyObject parent)
        {
            foreach (var child in LogicalTreeHelper.GetChildren(parent).OfType<DependencyObject>())
            {
                yield return child;
                foreach (var nested in Children(child)) yield return nested;
            }
        }
        void QueueTouchPin(Action? afterPin = null)
        {
            workstation.Window.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.ApplicationIdle, new Action(() =>
            {
                var dialog = Application.Current.Windows.Cast<Window>().SingleOrDefault(window =>
                    window.Owner == workstation.Window && Children(window).OfType<System.Windows.Controls.PasswordBox>().Any());
                try
                {
                    Require(dialog is not null, "Daily sale did not request a fresh cashier PIN.");
                    entered = Children(dialog!).OfType<System.Windows.Controls.PasswordBox>().Single();
                    var buttons = Children(dialog!).OfType<System.Windows.Controls.Button>().ToArray();
                    void Touch(string key) => buttons.Single(button =>
                        System.Windows.Automation.AutomationProperties.GetName(button) == "PIN " + key)
                        .RaiseEvent(new RoutedEventArgs(System.Windows.Controls.Button.ClickEvent));
                    Touch("0"); Touch("1");
                    Require(entered.Password == "01", "Touch PIN lost a leading zero.");
                    Touch("⌫");
                    Require(entered.Password == "0", "Touch PIN backspace changed the wrong digit.");
                    Touch("Effacer");
                    foreach (var key in pin) Touch(key.ToString());
                    postingPins++;
                    buttons.Single(button => button.IsDefault)
                        .RaiseEvent(new RoutedEventArgs(System.Windows.Controls.Button.ClickEvent));
                    afterPin?.Invoke();
                }
                catch (Exception ex) { failure = ex; dialog?.Close(); }
            }));
        }
        void Scan()
        {
            workstation.ViewModel.ScannerText = "DAILY-CODE";
            workstation.ViewModel.ScanCommand.Execute(null);
            Require(workstation.Session.PendingCount == 1 && workstation.ViewModel.FinancialSessionActive,
                "Daily cashier could not scan the next customer's basket.");
        }
        void RequireCommitted(string label)
        {
            if (failure is not null) throw new InvalidOperationException(label + ": " + failure.Message, failure);
            Require(workstation.Session.PendingCount == 0 && !workstation.ViewModel.CheckoutUncertain &&
                workstation.ViewModel.PaymentContext is null && workstation.ViewModel.FinancialSessionActive,
                label + " reused a payment authorization or lost the cashier session: " + workstation.ViewModel.CommitFeedback);
            Require(entered is not null && entered.Password.Length == 0, label + " retained the PIN.");
        }
        void CashSale()
        {
            Scan();
            var tenderOpened = false;
            workstation.Window.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.ApplicationIdle, new Action(() =>
            {
                var dialog = Application.Current.Windows.OfType<CashierEntryDialog>().SingleOrDefault();
                try
                {
                    Require(dialog is not null && dialog.Title == "Paiement en espèces",
                        "Next cash sale required cashier login instead of opening its payment review.");
                    tenderOpened = true;
                    var fields = Children(dialog!).OfType<System.Windows.Controls.TextBox>().ToArray();
                    var cashier = fields.Single(field => System.Windows.Automation.AutomationProperties.GetName(field) == "Cashier identity");
                    var received = fields.Single(field => System.Windows.Automation.AutomationProperties.GetName(field) == "Cash MAD (decimal, no thousands separator)");
                    Require(cashier.IsReadOnly && cashier.Text == "O'Neil" && received.IsReadOnly && received.Text == "",
                        "Next cash sale lost cashier identity or retained the prior customer's tender.");
                    var buttons = Children(dialog!).OfType<System.Windows.Controls.Button>().ToArray();
                    void Touch(string label) => buttons.Single(button => Equals(button.Content, label))
                        .RaiseEvent(new RoutedEventArgs(System.Windows.Controls.Button.ClickEvent));
                    Touch("Pavé numérique");
                    foreach (var key in price.ToString("0.##", CultureInfo.InvariantCulture)) Touch(key.ToString());
                    Touch("Appliquer le montant");
                    buttons.Single(button => button.IsDefault)
                        .RaiseEvent(new RoutedEventArgs(System.Windows.Controls.Button.ClickEvent));
                }
                catch (Exception ex) { failure = ex; dialog?.Close(); }
            }));
            var cashButton = Children(workstation.Window).OfType<System.Windows.Controls.Button>().Single(button =>
                System.Windows.Automation.AutomationProperties.GetName(button) == "Enter sale cash tender");
            cashButton.RaiseEvent(new RoutedEventArgs(System.Windows.Controls.Button.ClickEvent));
            if (failure is not null) throw new InvalidOperationException("Daily cash review failed: " + failure.Message, failure);
            Require(tenderOpened && workstation.ViewModel.CanCommit, "Daily cash panel did not obtain a fresh reviewed tender.");
            QueueTouchPin();
            workstation.ViewModel.CommitCommand.Execute(null);
            RequireCommitted("Daily cash sale");
        }
        try
        {
            Require(pin.All(char.IsDigit), "Daily touch-PIN fixture must use the synthetic numeric PIN.");
            Require(CashierEntry(workstation, "O'Neil", "01", "0", 0m, pin), "Daily cashier login failed.");
            CashSale();
            Scan();
            workstation.Window.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.ApplicationIdle, new Action(() =>
            {
                var dialog = Application.Current.Windows.OfType<CardPaymentDialog>().SingleOrDefault();
                try
                {
                    Require(dialog is not null, "Daily card review did not open.");
                    QueueTouchPin();
                    Children(dialog!).OfType<System.Windows.Controls.Button>()
                        .Single(button => Equals(button.Content, "Confirmer le paiement CARTE"))
                        .RaiseEvent(new RoutedEventArgs(System.Windows.Controls.Button.ClickEvent));
                }
                catch (Exception ex) { failure = ex; dialog?.Close(); }
            }));
            Require(workstation.Window.PayByCard(), "Daily card payment failed: " + workstation.ViewModel.CommitFeedback);
            RequireCommitted("Daily card sale");
            CashSale();
            Require(postingPins == 3 &&
                Number(settings, "SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='DAILY-CYCLE'") == 7m &&
                Number(settings, "SELECT COUNT(DISTINCT ID_TICKET) FROM TABLE_VENTES_JOURNAL WHERE ID_ARTICLE='DAILY-CYCLE'") == 3,
                "Daily cycle duplicated a sale, skipped fresh PIN or changed stock incorrectly.");
            var closing = new CashDrawerClosing(settings.ConnectionString);
            var summary = closing.Read("O'Neil", pin);
            Require(summary.CashSales == price * 2m && summary.NetSales == price * 3m &&
                summary.Expected == summary.Opening + price * 2m, "Cash/card/cash daily closing does not reconcile.");

            var reportSeen = false;
            void QueueClosingConfirmation()
            {
                workstation.Window.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.ApplicationIdle, new Action(() =>
                {
                    var confirmation = Application.Current.Windows.Cast<Window>()
                        .SingleOrDefault(window => window.Owner == workstation.Window && window.Title == "Clôture globale");
                    try
                    {
                        Require(confirmation is not null, "Daily cashier closing confirmation did not open after the consumed tender.");
                        Require(Children(confirmation!).OfType<System.Windows.Controls.TextBlock>().Any(block =>
                            block.Text.Contains("Écart : " + 0m.ToString("N2") + " MAD")),
                            "Daily closing did not display zero difference against counted cash.");
                        workstation.Window.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.ApplicationIdle, new Action(() =>
                        {
                            var report = Application.Current.Windows.Cast<Window>().SingleOrDefault(window =>
                                window.Owner == workstation.Window && window.Title.StartsWith("Clôture n°", StringComparison.Ordinal));
                            try
                            {
                                Require(report is not null && Children(report).OfType<System.Windows.Controls.TextBlock>().Any(block =>
                                    block.Text.Contains("Attendu : " + summary.Expected.ToString("N2") + " MAD")),
                                    "Daily cash closing did not display its persisted report.");
                                reportSeen = true;
                            }
                            catch (Exception ex) { failure = ex; }
                            finally { report?.Close(); }
                        }));
                        Children(confirmation!).OfType<System.Windows.Controls.Button>()
                            .Single(button => Equals(button.Content, "Confirmer"))
                            .RaiseEvent(new RoutedEventArgs(System.Windows.Controls.Button.ClickEvent));
                    }
                    catch (Exception ex) { failure = ex; confirmation?.Close(); }
                }));
            }
            workstation.Window.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.ApplicationIdle, new Action(() =>
            {
                var countDialog = Application.Current.Windows.Cast<Window>().SingleOrDefault(window =>
                    window.Owner == workstation.Window && window.Title == "Comptage et clôture de caisse");
                try
                {
                    Require(countDialog is not null, "Daily cash-count entry did not open.");
                    var remainder = summary.Expected;
                    foreach (var denomination in CashDrawerCount.Denominations)
                    {
                        var count = (int)decimal.Floor(remainder / denomination);
                        remainder -= count * denomination;
                        if (count == 0) continue;
                        var field = Children(countDialog!).OfType<System.Windows.Controls.TextBox>().Single(input =>
                            System.Windows.Automation.AutomationProperties.GetName(input) ==
                                denomination.ToString("0.##", CultureInfo.CurrentCulture) + " MAD");
                        Require(field.IsReadOnly, "Cash drawer count still required a physical keyboard.");
                        workstation.Window.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.ApplicationIdle, new Action(() =>
                        {
                            var numeric = Application.Current.Windows.OfType<TouchNumericEntryDialog>().SingleOrDefault();
                            try
                            {
                                Require(numeric is not null, "Cash note count did not open its integer keypad.");
                                var buttons = Children(numeric!).OfType<System.Windows.Controls.Button>().ToArray();
                                foreach (var digit in count.ToString(CultureInfo.InvariantCulture))
                                    buttons.Single(button => Equals(button.Content, digit.ToString()))
                                        .RaiseEvent(new RoutedEventArgs(System.Windows.Controls.Button.ClickEvent));
                                buttons.Single(button => Equals(button.Content, "Appliquer"))
                                    .RaiseEvent(new RoutedEventArgs(System.Windows.Controls.Button.ClickEvent));
                            }
                            catch (Exception ex) { failure = ex; numeric?.Close(); }
                        }));
                        field.RaiseEvent(new System.Windows.Input.MouseButtonEventArgs(
                            System.Windows.Input.Mouse.PrimaryDevice, 0, System.Windows.Input.MouseButton.Left)
                            { RoutedEvent = UIElement.PreviewMouseLeftButtonDownEvent });
                        if (failure is not null) throw failure;
                    }
                    Require(remainder == 0m, "Daily fixture cash could not be represented by LOGICA denominations.");
                    QueueTouchPin(QueueClosingConfirmation);
                    Children(countDialog!).OfType<System.Windows.Controls.Button>()
                        .Single(button => Equals(button.Content, "Préparer la clôture"))
                        .RaiseEvent(new RoutedEventArgs(System.Windows.Controls.Button.ClickEvent));
                }
                catch (Exception ex) { failure = ex; }
                finally { if (countDialog?.IsVisible == true) countDialog.Close(); }
            }));
            Children(workstation.Window).OfType<System.Windows.Controls.Button>()
                .Single(button => Equals(button.Content, "Clôture de caisse"))
                .RaiseEvent(new RoutedEventArgs(System.Windows.Controls.Button.ClickEvent));
            if (failure is not null) throw new InvalidOperationException("Daily closing UI failed: " + failure.Message, failure);
            Require(reportSeen && postingPins == 4 && entered?.Password.Length == 0 &&
                workstation.ViewModel.PaymentContext is null,
                "Daily closing reused a tender, omitted its report or did not erase its fresh PIN.");
            Require(Number(settings, """
                SELECT COUNT(*) FROM TABLE_VENTES_REGLEMENTS WHERE CLOTURE_GLOBALE IS NOT NULL
                AND ID_TICKET IN (SELECT ID_TICKET FROM TABLE_VENTES_JOURNAL WHERE ID_ARTICLE='DAILY-CYCLE')
                """) == 3, "Daily UI closing did not mark all three payments.");
            Require(workstation.Window.EndFinancialSession(), "Completed daily cashier could not sign out.");
            var beforeLogoutAttempt = Snapshot(settings);
            Require(!workstation.Window.PayByCard() && !workstation.Window.PayMixed() &&
                workstation.ViewModel.PaymentContext is null && !workstation.ViewModel.FinancialSessionActive &&
                Snapshot(settings) == beforeLogoutAttempt, "Signed-out cashier retained a payment authority.");
            File.WriteAllText(Path.Combine(EvidenceDirectory, "w2-daily-cashier-cycle.json"),
                JsonSerializer.Serialize(new { SingleLogin = true, SameWindow = true,
                    Sequence = new[] { "ESPECES", "CARTE", "ESPECES" }, FreshTouchPins = postingPins,
                    CountByTouch = true, ClosingFromCashierButton = true, PersistedReport = true,
                    FreshTenderEachSale = true, CashTotal = price * 2m, NetSales = price * 3m,
                    StockBefore = 10m, StockAfter = 7m, Closed = true, SignedOut = true }));
        }
        finally { workstation.Window.Close(); }
    }

    public static int Run(string evidenceDirectory)
    {
        EvidenceDirectory = evidenceDirectory;
        Directory.CreateDirectory(evidenceDirectory);
        try
        {
            var settings = CatalogueSettings.FromEnvironment();
            var cs = new MySqlConnectionStringBuilder(settings.ConnectionString);
            var launcherPort = Environment.GetEnvironmentVariable("HANOUTY_W2_DISPOSABLE_PORT");
            var expectedPort = launcherPort is null ? 3307 :
                int.TryParse(launcherPort, out var port) && port is > 0 and <= 65535 ? port : 0;
            Require(expectedPort > 0 && Environment.GetEnvironmentVariable("HANOUTY_W2_DISPOSABLE_MARKER") ==
                "I_ACKNOWLEDGE_DISPOSABLE_DB_ONLY" && cs.Server == "127.0.0.1" &&
                cs.Database == "logica_ci" && cs.Port == expectedPort,
                "W2 requires the explicitly disposable loopback logica_ci database on the expected test port.");
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
