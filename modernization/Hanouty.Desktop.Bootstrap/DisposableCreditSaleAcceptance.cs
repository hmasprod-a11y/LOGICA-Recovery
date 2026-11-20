#if HANOUTY_FINANCIAL
using System.Globalization;
using System.IO;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;
using Hanouty.ArchitectureBridge;
using Hanouty.Checkout.MariaDb;
using Hanouty.Desktop.Wpf;
using LOGICA.ApplicationLayer.Checkout;
using MySql.Data.MySqlClient;

namespace Hanouty.Desktop.Bootstrap;

internal static partial class DisposableCashSaleAcceptance
{
    private static void VerifyCreditSales(CatalogueSettings settings, string pin)
    {
        TraceStep("Credit sale fixture and negative cases");
        Sql(settings, """
            ALTER TABLE TABLE_CLIENTS ADD COLUMN IF NOT EXISTS TELEPHONE VARCHAR(64);
            INSERT INTO TABLE_CLIENTS (ID_CLIENT,CODE_CLIENT,CLIENT,CREDIT_INITIAL,TELEPHONE)
            VALUES ('CREDIT-NEW','C''100','Client d''été',0,'0612345678'),
                   ('CREDIT-OTHER','SECOND','Autre 100% client',0,'0623456789'),
                   ('CREDIT-DUP','DUP-A','Doublon A',0,''),('CREDIT-DUP','DUP-B','Doublon B',0,''),
                   ('CREDIT-CASE','CASE-A','Alias A',0,''),('credit-case','CASE-B','Alias B',0,'');
            INSERT INTO TABLE_ARTICLES
                (ID_ARTICLE,STOCK,Code,Article,Famille,PRIX_A,PRIX_MP,PRIX_V_1,TAUX_TVA,GROUPE,PROMOTION,PRIX_QTE,PRIX_QTE_MIN)
            VALUES ('CREDIT-ARTICLE',20,'CREDIT-CODE','Article crédit','Food',1,1,10,20,'G',10,8,3);
            """);
        MySqlConnection Connect() => new(settings.ConnectionString);
        var configuration = Path.Combine(AppContext.BaseDirectory, "gestion_credit.sni");
        var previous = File.Exists(configuration) ? File.ReadAllBytes(configuration) : null;
        void Enabled(bool value) => File.WriteAllText(configuration, value ? "True" : "False");
        string State() => string.Join("|", Snapshot(settings),
            Number(settings, "SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='CREDIT-ARTICLE'"),
            Number(settings, "SELECT COALESCE(SUM(MONTANT),0) FROM TABLE_VENTES_REGLEMENTS"));
        void Refused(Action action, string reason)
        {
            var before = State(); var denied = false;
            try { action(); }
            catch (Exception ex) when (ex is ArgumentException or InvalidOperationException or UnauthorizedAccessException or NotSupportedException)
            { denied = true; }
            catch (MySqlException ex) when (ex.Message.Contains("credit-rollback")) { denied = true; }
            Require(denied && State() == before, reason);
        }
        var customer = new CheckoutCustomerIdentity("CREDIT-NEW", "C'100", "Client d'été");
        var request = new AuthorizedCheckoutRequest("credit-negative", "O'Neil", "MAD", false,
            new[] { new CheckoutBatchLine("CREDIT-ARTICLE", 3) }, new[] { new CheckoutPayment(CheckoutPaymentKind.Credit, 21.60m) },
            21.60m, Customer: customer);
        IAuthorizedCheckoutPort Port(Func<string>? readPin = null) => MariaDbCashCheckoutServices.CreatePostingPort(
            Connect, "01", readPin ?? (() => pin), creditConfigurationDirectory: AppContext.BaseDirectory);
        CustomerCreditStatementRow Balance() => new CustomerCreditStatementReader(settings.ConnectionString)
            .Read(new DateTime(2000, 1, 1), DateTime.Today).Single(row => row.CustomerId == customer.Id);
        var drawer = new CashDrawerClosing(settings.ConnectionString);
        try
        {
            File.WriteAllText(configuration, "invalid-boolean");
            Require(!MariaDbCashCheckoutServices.IsCreditSaleEnabled(AppContext.BaseDirectory), "Malformed credit configuration enabled credit.");
            Enabled(false);
            Refused(() => Port().Commit(request), "Disabled credit posted financial rows.");
            Enabled(true);
            Refused(() => MariaDbCashCheckoutServices.CreatePostingPort(Connect, "01", () => pin).Commit(request),
                "An unconfigured production factory enabled credit.");
            Refused(() => Port().Commit(request with { Customer = null }), "Anonymous credit was accepted.");
            Refused(() => Port().Commit(request with { Customer = customer with { Id = "CREDIT-DUP", Code = "DUP-A", Name = "Doublon A" } }),
                "Ambiguous customer identity was accepted.");
            Refused(() => Port().Commit(request with { Customer = customer with { Id = "credit-case", Code = "CASE-B", Name = "Alias B" } }),
                "Case-colliding customer IDs could share debt under statement collation.");
            Refused(() => Port().Commit(request with { Customer = customer with { Name = "Forged name" } }),
                "UI-provided customer name replaced the live customer.");
            Refused(() => Port(() => "incorrect").Commit(request), "Wrong cashier PIN authorized credit.");
            Refused(() => Port().Commit(request with { Payments = new[] { new CheckoutPayment(CheckoutPaymentKind.Credit, 30m) } }),
                "Credit amount exceeded the actual net.");
            Refused(() => Port(() => { Enabled(false); return pin; }).Commit(request), "Credit disabled during PIN was not rolled back.");
            Enabled(true);
            Refused(() => Port(() => {
                Sql(settings, "UPDATE TABLE_CLIENTS SET CLIENT='Renamed' WHERE ID_CLIENT='CREDIT-NEW'"); return pin;
            }).Commit(request), "A renamed customer bypassed the reviewed credit identity.");
            Sql(settings, "UPDATE TABLE_CLIENTS SET CLIENT='Client d''été' WHERE ID_CLIENT='CREDIT-NEW'");
            Sql(settings, "CREATE TRIGGER credit_after_header AFTER INSERT ON TABLE_VENTES_ENTETE FOR EACH ROW SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT='credit-rollback'");
            try { Refused(() => Port().Commit(request), "Injected credit failure left stock/ticket/debt behind."); }
            finally { Sql(settings, "DROP TRIGGER credit_after_header"); }
            Require(MariaDbCashCheckoutServices.FindCreditCustomers(Connect, "C'100").Single().Id == customer.Id &&
                MariaDbCashCheckoutServices.FindCreditCustomers(Connect, "%").Single().Id == "CREDIT-OTHER" &&
                MariaDbCashCheckoutServices.FindCreditCustomers(Connect, "' OR 1=1 --").Count == 0 &&
                MariaDbCashCheckoutServices.FindCreditCustomers(Connect, "CASE-A").Count == 0,
                "Customer search lost literal matching or apostrophe safety.");

            var before = drawer.Read("O'Neil", pin);
            var host = CatalogueHost.CreateCashierWorkstation(settings, "01");
            string operation;
            try
            {
                Require(CashierEntry(host, "O'Neil", "01", "0", 0m, pin), "Credit cashier login failed.");
                host.ViewModel.ScannerText = "CREDIT-CODE"; host.ViewModel.ScanCommand.Execute(null);
                Require(host.Window.ChangeBasketQuantity(host.ViewModel.BasketLines.Single(), 3) && host.Window.RefreshTrustedBasketTotal(),
                    "Credit basket did not reuse the existing quantity/promotion quote.");
                Enabled(false); host.Window.RefreshCreditSaleAvailability();
                Require(((Button)host.Window.FindName("CreditSaleButton")).Visibility == Visibility.Collapsed && !host.Window.SellOnCredit(),
                    "Disabled credit UI remained available.");
                Enabled(true); host.Window.RefreshCreditSaleAvailability();
                var cancelledState = State();
                Require(!CreditThroughDialog(host, pin, customer.Id, confirm: false, out _) && State() == cancelledState && host.Session.PendingLines.Single().Quantity == 3,
                    "Cancelled customer-credit review changed the staged basket or ledger.");
                Require(CreditThroughDialog(host, pin, customer.Id, confirm: true, out operation), "Real credit UI did not commit.");
                Require(host.Session.PendingCount == 0 && host.ViewModel.PaymentContext is null &&
                    Number(settings, "SELECT COUNT(*) FROM TABLE_VENTES_ENTETE WHERE ID_TICKET=@id AND OPERATION='CREDIT' AND ID_CLIENT='CREDIT-NEW' AND CODE_CLIENT='C''100' AND CLIENT='Client d''été' AND Total_NET=21.60", operation) == 1 &&
                    Number(settings, "SELECT COUNT(*) FROM TABLE_VENTES_JOURNAL WHERE ID_TICKET=@id AND OPERATION='CREDIT' AND ID_CLIENT='CREDIT-NEW' AND Qté=3 AND Remise=10 AND PRIX_V=8 AND Total_NET=21.60", operation) == 1 &&
                    Number(settings, "SELECT COUNT(*) FROM TABLE_VENTES_REGLEMENTS WHERE ID_TICKET=@id", operation) == 0 &&
                    Number(settings, "SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='CREDIT-ARTICLE'") == 17m && Balance().Balance == 21.60m,
                    "Credit sale did not atomically persist stock/customer/debt without payment.");
                var afterCredit = drawer.Read("O'Neil", pin);
                Require(afterCredit.Expected == before.Expected && afterCredit.CashSales == before.CashSales &&
                    afterCredit.ClientCash == before.ClientCash && afterCredit.NetSales == before.NetSales,
                    "An unpaid credit incorrectly entered the cash drawer or paid-sale total.");
                using (var db = Open(settings))
                {
                    var ticket = LogicaPostedTicket.Read(db, operation, "O'Neil", "01");
                    Require(ticket is not null && ticket.Operation == "CREDIT" && ticket.CustomerId == customer.Id &&
                        ticket.CustomerName == customer.Name && ticket.FormatFrenchThreeColumnPayment(value => value.ToString("F2")).Count == 0 &&
                        ticket.FormatFrenchThreeColumnIdentity(true).Contains("* CLIENT    : Client d'été") &&
                        ticket.FormatFrenchThreeColumnIdentity(true).Contains("-------------------CREDIT------------------"),
                        "Credit receipt lost the original CREDIT/customer identity or invented payment.");
                    using var bitmap = new System.Drawing.Bitmap(304, 500);
                    using (var graphics = System.Drawing.Graphics.FromImage(bitmap))
                    {
                        graphics.Clear(System.Drawing.Color.White);
                        LogicaReceiptRenderer.Draw(graphics,
                            ticket!.FormatFrenchThreeColumnLines(value => value.ToString("0.###"), value => value.ToString("F2")).ToArray(),
                            ticket.Total.ToString("F2"), LogicaReceiptSummary.Format(ticket) +
                            string.Join("\r\n", ticket.FormatFrenchThreeColumnIdentity(true)));
                    }
                    bitmap.Save(Path.Combine(EvidenceDirectory, "credit-original-receipt.png"), System.Drawing.Imaging.ImageFormat.Png);
                }
                Require(ReceiptPrintRouting.Select("", true, "CREDIT", "USB", "FR_3C", out var copies) == ReceiptPrintRoute.FrenchThreeColumn && copies == 2,
                    "Credit receipt did not use the original two-copy route.");
                var persisted = State();
                Port().Commit(request with { OperationId = operation });
                Require(State() == persisted && Balance().Balance == 21.60m, "Credit duplicate increased the debt twice.");
                host.ViewModel.ScannerText = "CREDIT-CODE"; host.ViewModel.ScanCommand.Execute(null);
                Require(host.TrySetFinancialContext(new AuthorizedCheckoutPaymentContext("O'Neil", "MAD", false,
                    new[] { new CheckoutPayment(CheckoutPaymentKind.Cash, 10m) }, 9m)), "Next-customer cash context failed after credit.");
                ReviewThroughDialog(host, pin, true, () => host.ViewModel.CommitCommand.Execute(null));
                Require(host.Session.PendingCount == 0 && Balance().Balance == 21.60m &&
                    Number(settings, "SELECT COUNT(*) FROM TABLE_VENTES_JOURNAL WHERE ID_ARTICLE='CREDIT-ARTICLE' AND OPERATION='VENTE' AND ID_CLIENT='0' AND Total_NET=9") == 1,
                    "Customer credit identity leaked into the next paid sale.");
            }
            finally { host.Window.Close(); }
            var settlement = new CustomerSettlementWriter(settings.ConnectionString);
            Require(SettleNewCreditThroughDialog(settings, pin, customer.Id, "5") && Balance().Balance == 16.60m &&
                drawer.Read("O'Neil", pin).Expected == before.Expected + 14m,
                "Partial settlement of the newly posted credit did not match debt/cash.");
            var partialId = Convert.ToString(Value(settings, "SELECT ID_REGLE FROM TABLE_CLIENTS_REGLE WHERE ID_CLIENT='CREDIT-NEW' AND MONTANT=5"))!;
            var partial = new CustomerSettlementRequest(partialId, customer.Id, 5m, "ESPECES", "");
            Require(settlement.Record(partial, "O'Neil", pin) && Balance().Balance == 16.60m,
                "Repeated new-credit settlement changed the debt twice.");
            var lost = CatalogueHost.CreateCashierWorkstationWithAcknowledgementFault(settings, "01",
                () => throw new IOException("credit-ack-lost"));
            try
            {
                Require(CashierEntry(lost, "O'Neil", "01", "0", 0m, pin), "Lost-ack credit cashier failed login.");
                lost.ViewModel.ScannerText = "CREDIT-CODE"; lost.ViewModel.ScanCommand.Execute(null);
                Require(!CreditThroughDialog(lost, pin, customer.Id, confirm: true, out _) && lost.ViewModel.CheckoutUncertain &&
                    Balance().Balance == 25.60m && drawer.Read("O'Neil", pin).Expected == before.Expected + 14m,
                    "Lost acknowledgement duplicated credit or incorrectly entered cash.");
                lost.ViewModel.ReconcileCommand.Execute(null);
                ReviewThroughDialog(lost, pin, true);
                Require(!lost.ViewModel.CheckoutUncertain && lost.Session.PendingCount == 0 && Balance().Balance == 25.60m,
                    "Credit outcome review did not clear only the old draft.");
            }
            finally { lost.Window.Close(); }
            Require(SettleNewCreditThroughDialog(settings, pin, customer.Id, "25.60") && Balance().Balance == 0m && Balance().CreditSales == 30.60m &&
                Balance().Payments == 30.60m && drawer.Read("O'Neil", pin).Expected == before.Expected + 39.60m &&
                Number(settings, "SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='CREDIT-ARTICLE'") == 15m,
                "Credit sales, partial/full settlement, paid sale and stock did not reconcile.");
            var close = drawer.Read("O'Neil", pin); drawer.Close("O'Neil", pin, close);
            Require(Number(settings, "SELECT COUNT(*) FROM TABLE_VENTES_JOURNAL WHERE CLOTURE_GLOBALE IS NULL") == 0 &&
                Number(settings, "SELECT COUNT(*) FROM TABLE_CLIENTS_REGLE WHERE CLOTURE_GLOBALE IS NULL") == 0 && Balance().Balance == 0m,
                "Closing the credit/settlement cycle changed the customer debt or left unclosed rows.");
            var manualLines = new[] { new CheckoutBatchLine("CREDIT-ARTICLE", 3) };
            var manual = MariaDbCashCheckoutServices.ApplyManualDiscount(Connect,
                MariaDbCashCheckoutServices.AuthorizeManualDiscount(Connect, "O'Neil", "01", _ => ""),
                manualLines, null, null, true, 20m);
            var manualPort = MariaDbCashCheckoutServices.CreatePostingPort(Connect, "01", () => pin,
                readManualDiscount: () => manual, creditConfigurationDirectory: AppContext.BaseDirectory);
            manualPort.Commit(new AuthorizedCheckoutRequest("credit-manual-discount", "O'Neil", "MAD", false, manualLines,
                new[] { new CheckoutPayment(CheckoutPaymentKind.Credit, 19.20m) }, 19.20m,
                Customer: new CheckoutCustomerIdentity("CREDIT-OTHER", "SECOND", "Autre 100% client")));
            Require(Number(settings, "SELECT COUNT(*) FROM TABLE_VENTES_JOURNAL WHERE ID_TICKET='credit-manual-discount' AND Remise=20 AND Total_NET=19.20") == 1 &&
                Number(settings, "SELECT COUNT(*) FROM TABLE_VENTES_REGLEMENTS WHERE ID_TICKET='credit-manual-discount'") == 0 &&
                new CustomerCreditStatementReader(settings.ConnectionString).Read(new DateTime(2000, 1, 1), DateTime.Today)
                    .Single(row => row.CustomerId == "CREDIT-OTHER").Balance == 19.20m,
                "Authorized manual discount was lost or counted as cash on a credit sale.");
            Require(settlement.Record(new CustomerSettlementRequest("credit-manual-card-settlement", "CREDIT-OTHER", 19.20m, "CARTE", ""), "O'Neil", pin) &&
                drawer.Read("O'Neil", pin).ClientCash == 0m &&
                Number(settings, "SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='CREDIT-ARTICLE'") == 12m,
                "Card settlement of discounted credit incorrectly entered cash or changed stock.");
            drawer.Close("O'Neil", pin, drawer.Read("O'Neil", pin));
            File.WriteAllText(Path.Combine(EvidenceDirectory, "w2-credit-sales.json"), JsonSerializer.Serialize(new {
                OriginalConfiguration = true, AnonymousAndDuplicateCustomerDenied = true, ReviewedIdentityRechecked = true,
                FreshCashierPin = true, QueryAndSelectionInvalidation = true, ExplicitCreditConfirmation = true,
                AtomicDebtStockNoPayment = true, CashUnchangedAtCredit = true, ReceiptCustomerAndTwoCopies = true,
                DurableDuplicate = true, NextCashSaleAnonymous = true, NewDebtPartialAndFullSettlement = true,
                LostAcknowledgementReview = true, Rollback = true, ClosingAndStockReconciled = true, ManualDiscountCredit = true
            }, new JsonSerializerOptions { WriteIndented = true }));
        }
        finally
        {
            if (previous is null) File.Delete(configuration); else File.WriteAllBytes(configuration, previous);
        }
    }

    private static bool SettleNewCreditThroughDialog(CatalogueSettings settings, string pin, string customerId, string digits)
    {
        var host = CatalogueHost.CreateCashierWorkstation(settings, "01");
        Exception? failure = null; var paid = false;
        var timeout = new System.Windows.Threading.DispatcherTimer { Interval = TimeSpan.FromSeconds(12) };
        timeout.Tick += (_, _) =>
        {
            timeout.Stop(); failure ??= new TimeoutException("New-credit statement settlement did not finish.");
            foreach (var modal in host.Window.OwnedWindows.Cast<Window>().Reverse().ToArray()) modal.Close();
        };
        try
        {
            Require(CashierEntry(host, "O'Neil", "01", "0", 0m, pin), "New-credit settlement cashier login failed.");
            host.Window.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.ApplicationIdle, new Action(() =>
            {
                var statement = Application.Current.Windows.OfType<CustomerCreditStatementDialog>().SingleOrDefault();
                try
                {
                    Require(statement is not null, "New debt did not open in the existing customer statement.");
                    var grid = CatalogueControls<DataGrid>(statement!).Single();
                    grid.SelectedItem = grid.Items.OfType<CustomerCreditStatementRow>().Single(row => row.CustomerId == customerId);
                    host.Window.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.ApplicationIdle, new Action(() =>
                    {
                        var dialog = Application.Current.Windows.OfType<CustomerSettlementDialog>().SingleOrDefault();
                        try
                        {
                            Require(dialog is not null, "Selected new debt did not open its actual settlement dialog.");
                            var buttons = CatalogueControls<Button>(dialog!).ToArray();
                            foreach (var digit in digits)
                                buttons.Single(button => Equals(button.Content, digit.ToString())).RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                            CatalogueControls<ComboBox>(dialog!).Single().SelectedItem = "ESPECES";
                            ReviewThroughDialog(host, pin, true, () => buttons.Single(button => Equals(button.Content, "Enregistrer"))
                                .RaiseEvent(new RoutedEventArgs(Button.ClickEvent)));
                            paid = dialog!.DialogResult == true;
                        }
                        catch (Exception ex) { failure = ex; dialog?.Close(); }
                        finally { statement?.Close(); }
                    }));
                    CatalogueControls<Button>(statement!).Single(button => Equals(button.Content, "Régler le client sélectionné"))
                        .RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                }
                catch (Exception ex) { failure = ex; statement?.Close(); }
            }));
            timeout.Start();
            CatalogueControls<Button>(host.Window).Single(button => Equals(button.Content, "État des crédits clients"))
                .RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            if (failure is not null) throw new InvalidOperationException("New-credit settlement UI failed.", failure);
            return paid;
        }
        finally { timeout.Stop(); host.Window.Close(); }
    }

    private static bool CreditThroughDialog(CatalogueHost host, string pin, string customerId, bool confirm, out string operation, string searchCode = "C'100", string customerName = "Client d'été")
    {
        Exception? failure = null; string? captured = null; PasswordBox? entered = null;
        var watchdog = new System.Windows.Threading.DispatcherTimer { Interval = TimeSpan.FromSeconds(12) };
        watchdog.Tick += (_, _) =>
        {
            watchdog.Stop(); failure ??= new TimeoutException("Credit sale modal did not finish.");
            foreach (var child in host.Window.OwnedWindows.Cast<Window>().Reverse().ToArray()) child.Close();
        };
        host.Window.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.ApplicationIdle, new Action(() =>
        {
            var dialog = Application.Current.Windows.OfType<CreditSaleDialog>().SingleOrDefault();
            try
            {
                Require(dialog is not null, "Credit customer selector did not open.");
                var grid = CatalogueControls<DataGrid>(dialog!).Single();
                Require(grid.SelectedItem is null && !host.Window.PayByCard() && !host.Window.EndFinancialSession(),
                    "Credit selection preselected a client or allowed nested payment/logout.");
                var search = CatalogueControls<TextBox>(dialog!).Single();
                search.Text = searchCode;
                Require(grid.Items.Count == 0, "Edited credit search retained stale customer selection.");
                CatalogueControls<Button>(dialog!).Single(button => Equals(button.Content, "Rechercher"))
                    .RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                grid.SelectedItem = grid.Items.Cast<CreditCustomerChoice>().Single(row => row.Id == customerId);
                var approve = CatalogueControls<Button>(dialog!).Single(button => button.IsDefault);
                approve.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                Require(dialog!.Customer is null && Equals(approve.Content, "Confirmer le crédit") &&
                    CatalogueControls<TextBlock>(dialog!).Any(block => block.Text.Contains(customerName) && block.Text.Contains("Aucun encaissement")),
                    "Credit did not require explicit second review of customer and amount.");
                if (!confirm) { dialog.Close(); return; }
                dialog.UpdateLayout();
                var image = new System.Windows.Media.Imaging.RenderTargetBitmap((int)Math.Ceiling(dialog.ActualWidth),
                    (int)Math.Ceiling(dialog.ActualHeight), 96, 96, System.Windows.Media.PixelFormats.Pbgra32);
                image.Render(dialog); var encoder = new System.Windows.Media.Imaging.PngBitmapEncoder();
                encoder.Frames.Add(System.Windows.Media.Imaging.BitmapFrame.Create(image));
                var screenshot = host.ViewModel.BasketLines.Single().Quantity == 3m
                    ? "credit-customer-confirmation.png" : "credit-acknowledgement-review.png";
                using (var stream = File.Create(Path.Combine(EvidenceDirectory, screenshot))) encoder.Save(stream);
                host.Window.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.ApplicationIdle, new Action(() =>
                {
                    var prompt = host.Window.OwnedWindows.Cast<Window>().SingleOrDefault(window => CatalogueControls<PasswordBox>(window).Any());
                    try
                    {
                        Require(prompt is not null, "Credit did not request the real cashier PIN.");
                        captured = host.ViewModel.PendingOperationId;
                        entered = CatalogueControls<PasswordBox>(prompt!).Single();
                        var buttons = CatalogueControls<Button>(prompt!).ToArray();
                        foreach (var digit in pin)
                            buttons.Single(button => System.Windows.Automation.AutomationProperties.GetName(button) == "PIN " + digit)
                                .RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                        buttons.Single(button => button.IsDefault).RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                    }
                    catch (Exception ex) { failure = ex; prompt?.Close(); }
                }));
                approve.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            }
            catch (Exception ex) { failure = ex; dialog?.Close(); }
        }));
        watchdog.Start();
        bool result;
        try { result = host.Window.SellOnCredit(); }
        finally { watchdog.Stop(); }
        if (failure is not null) throw new InvalidOperationException("Credit UI acceptance failed.", failure);
        if (confirm) Require(captured is not null && entered?.Password.Length == 0, "Credit PIN or stable operation identity was not cleared/captured.");
        operation = captured ?? "";
        return result;
    }
}
#endif
