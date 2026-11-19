#if HANOUTY_FINANCIAL
using System.Globalization;
using System.IO;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;
using Hanouty.ArchitectureBridge;
using Hanouty.Checkout.MariaDb;
using Hanouty.Desktop.Wpf;
using MySql.Data.MySqlClient;

namespace Hanouty.Desktop.Bootstrap;

internal static partial class DisposableCashSaleAcceptance
{
    private static void VerifyManualDiscounts(CatalogueSettings settings, string pin)
    {
        // Fixture only. REMISE already belongs to the recovered LOGICA schema.
        Sql(settings, """
            ALTER TABLE TABLE_PASS ADD COLUMN IF NOT EXISTS REMISE VARCHAR(64) DEFAULT 'VISIBLE';
            UPDATE TABLE_PASS SET REMISE='VISIBLE';
            INSERT INTO TABLE_ARTICLES
                (ID_ARTICLE,STOCK,Code,Article,Famille,PRIX_A,PRIX_MP,PRIX_V_1,TAUX_TVA,GROUPE,PROMOTION,PRIX_QTE,PRIX_QTE_MIN)
            VALUES ('MANUAL-A',20,'MANUAL-A-CODE','Remise autorisée','Food',1,1,10,20,'G',10,8,3),
                   ('MANUAL-B',20,'MANUAL-B-CODE','Deuxième article','Food',1,1,20,20,'G',0,0,0);
            """);
        MySqlConnection Connect() => new(settings.ConnectionString);
        string ManualSnapshot() => string.Join("|", Snapshot(settings),
            Number(settings, "SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='MANUAL-A'"),
            Number(settings, "SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='MANUAL-B'"),
            Number(settings, "SELECT COALESCE(SUM(MONTANT),0) FROM TABLE_VENTES_REGLEMENTS"),
            Number(settings, "SELECT COALESCE(SUM(Total_NET),0) FROM TABLE_VENTES_JOURNAL"));
        var basket = new[] { new CheckoutBatchLine("MANUAL-A", 3), new CheckoutBatchLine("MANUAL-B", 1) };
        void Access(string value) => Sql(settings, "UPDATE TABLE_PASS SET REMISE='" + value + "' WHERE ListUser='O''Neil'");
        ManualDiscountAuthorization Grant(string? expectedRole = null, string? rolePin = null)
        {
            var calls = 0;
            var grant = MariaDbCashCheckoutServices.AuthorizeManualDiscount(Connect, "O'Neil", "01", role =>
            {
                calls++; Require(role == expectedRole, "Discount requested the wrong original LOGICA role.");
                return rolePin ?? "";
            });
            Require(calls == (expectedRole is null ? 0 : 1), "Unexpected discount PIN prompt count.");
            return grant;
        }
        void Refused(Action action, string reason)
        {
            var before = ManualSnapshot();
            var rejected = false;
            try { action(); }
            catch (Exception ex) when (ex is UnauthorizedAccessException or ArgumentException or InvalidOperationException)
            { rejected = true; }
            Require(rejected && before == ManualSnapshot(), reason);
        }
        ApprovedManualDiscount Apply(ManualDiscountAuthorization grant, string? article, bool percentage, decimal value,
            ApprovedManualDiscount? previous = null) => MariaDbCashCheckoutServices.ApplyManualDiscount(
                Connect, grant, basket, previous!, article!, percentage, value);
        var culture = CultureInfo.CurrentCulture;
        try
        {
            foreach (var name in new[] { "fr-FR", "en-US" })
            {
                CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo(name);
                var authorization = Grant();
                var preview = MariaDbCashCheckoutServices.PreviewManualDiscount(Connect, authorization, basket, null, null, true, 25m);
                Require(preview.Percentage == 25m && preview.NetTotal == 33m && preview.Savings == 11m,
                    "Global percentage must replace catalogue promotion at the quantity price.");
                var approval = Apply(authorization, null, true, 25m);
                Require(MariaDbCashCheckoutServices.ReadCashSaleTotal(Connect, basket, approval) == 33m,
                    "Approved manual percentage and trusted quote differ.");
                Refused(() => Apply(authorization, null, true, 10m), "A consumed review authorization was reused.");
                var selected = Apply(Grant(), "MANUAL-A", false, 6m);
                Require(selected.PercentageFor("MANUAL-A") == 25m && selected.PercentageFor("MANUAL-B") is null &&
                    MariaDbCashCheckoutServices.ReadCashSaleTotal(Connect, basket, selected) == 38m,
                    "Selected DH conversion or non-selected line differs from LOGICA.");
                var globalDh = Apply(Grant(), null, false, 4.16m);
                Require(globalDh.Lines.All(line => line.Percentage == 10m) &&
                    MariaDbCashCheckoutServices.ReadCashSaleTotal(Connect, basket, globalDh) == 39.60m,
                    "Global DH must divide by the current net 41.60 then replace percentages.");
                var reset = Apply(Grant(), null, true, 0m, approval);
                Require(MariaDbCashCheckoutServices.ReadCashSaleTotal(Connect, basket, reset) == 44m,
                    "Original reset-to-zero must replace existing promotions.");
                Require(MariaDbCashCheckoutServices.RetainManualDiscountForBasket(selected,
                    new[] { basket[1] }) is null, "Removed article retained a discount grant.");
                Refused(() => Apply(Grant(), null, true, 100.001m), "Raw percent above 100 was rounded into a valid discount.");
                Refused(() => Apply(Grant(), null, true, 100m), "A zero-net whole ticket was accepted.");
                Sql(settings, "UPDATE TABLE_ARTICLES SET PRIX_QTE=7.125 WHERE ID_ARTICLE='MANUAL-A'");
                var rounded = MariaDbCashCheckoutServices.ApplyManualDiscount(Connect, Grant(), new[] { basket[0] }, null,
                    "MANUAL-A", false, 1m);
                Require(rounded.PercentageFor("MANUAL-A") == 4.68m &&
                    MariaDbCashCheckoutServices.ReadCashSaleTotal(Connect, new[] { basket[0] }, rounded) == 20.37m,
                    "Selected DH conversion did not first round the original line gross to two decimals.");
                Sql(settings, "UPDATE TABLE_ARTICLES SET PRIX_QTE=8 WHERE ID_ARTICLE='MANUAL-A'");
            }
        }
        finally { CultureInfo.CurrentCulture = culture; }
        Access("INVISIBLE");
        Require(!MariaDbCashCheckoutServices.CanUseManualDiscount(Connect, "O'Neil"), "Invisible discount was exposed.");
        Refused(() => Grant(), "Invisible discount was authorized.");
        Access("ACCES MANAGER");
        Refused(() => Grant("MANAGER", "6789"), "ADMIN PIN incorrectly satisfied exact MANAGER access.");
        var manager = Apply(Grant("MANAGER", "5678"), null, true, 25m);
        Require(manager.Approver == "Test manager", "Wrong manager identity recorded in approval.");
        var managerRevoked = Grant("MANAGER", "5678");
        Sql(settings, "UPDATE TABLE_PASS SET Catégorie='UTILISATEUR' WHERE ListUser='Test manager'");
        Refused(() => Apply(managerRevoked, null, true, 25m), "A revoked manager role was still accepted.");
        Sql(settings, "UPDATE TABLE_PASS SET Catégorie='MANAGER' WHERE ListUser='Test manager'");
        Access("ACCES ADMIN");
        Refused(() => Grant("ADMIN", "5678"), "MANAGER PIN incorrectly satisfied ADMIN access.");
        Apply(Grant("ADMIN", "6789"), null, true, 25m);
        Access("VISIBLE");
        var scoped = Grant();
        var otherConnection = new MySqlConnectionStringBuilder(settings.ConnectionString) { Server = "localhost" };
        var scopeDenied = false;
        try { MariaDbCashCheckoutServices.PreviewManualDiscount(() => new MySqlConnection(otherConnection.ConnectionString),
            scoped, basket, null, null, true, 25m); }
        catch (UnauthorizedAccessException ex) when (ex.Message.Contains("autre base")) { scopeDenied = true; }
        Require(scopeDenied, "Manual approval was accepted under a different database connection scope.");
        var stale = Grant();
        var reviewed = MariaDbCashCheckoutServices.PreviewManualDiscount(Connect, stale, basket, null, null, true, 25m);
        Sql(settings, "UPDATE TABLE_ARTICLES SET PRIX_V_1=21 WHERE ID_ARTICLE='MANUAL-B'");
        Refused(() => MariaDbCashCheckoutServices.ApplyManualDiscount(Connect, stale, basket, null, null, true, 25m, reviewed),
            "A price change after preview was silently applied.");
        Sql(settings, "UPDATE TABLE_ARTICLES SET PRIX_V_1=20 WHERE ID_ARTICLE='MANUAL-B'");
        var manual = Apply(Grant(), null, true, 25m);
        var waiting = LogicaWaitingSale.Save(Connect, basket, "O'Neil", "01", manual);
        Access("ACCES MANAGER");
        Refused(() => MariaDbCashCheckoutServices.ReadWaitingBasketForAuthorizedResume(Connect, waiting, "O'Neil", "01", _ => "6789"),
            "Waiting discount resumed without its exact current permission.");
        var resumed = MariaDbCashCheckoutServices.ReadWaitingBasketForAuthorizedResume(Connect, waiting, "O'Neil", "01", _ => "5678");
        Require(resumed.Approval is not null && resumed.Lines.SequenceEqual(basket) &&
            MariaDbCashCheckoutServices.ReadCashSaleTotal(Connect, resumed.Lines, resumed.Approval) == 33m,
            "Waiting resume dropped manual conditions.");
        var port = MariaDbCashCheckoutServices.CreatePostingPort(Connect, "01", () => pin, () => waiting, () => resumed.Approval);
        var request = new AuthorizedCheckoutRequest("manual-approved-waiting", "O'Neil", "MAD", false,
            basket, new[] { new CheckoutPayment(CheckoutPaymentKind.Cash, 50m) }, 33m);
        Access("INVISIBLE");
        Refused(() => port.Commit(request), "Revoked manual permission still posted.");
        Access("ACCES MANAGER");
        port.Commit(request);
        var posted = ManualSnapshot();
        port.Commit(request);
        Require(ManualSnapshot() == posted && Number(settings, "SELECT COUNT(*) FROM TABLE_ATTENTE WHERE V=@id", waiting) == 0 &&
            Number(settings, "SELECT SUM(Total_NET) FROM TABLE_VENTES_JOURNAL WHERE ID_TICKET=@id", request.OperationId) == 33m &&
            Number(settings, "SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='MANUAL-A'") == 17m,
            "Manual waiting posting, atomic consumption or replay failed.");
        var unrelatedPort = MariaDbCashCheckoutServices.CreatePostingPort(Connect, "01", () => pin,
            readManualDiscount: () => resumed.Approval);
        var operationDenied = false;
        try { unrelatedPort.Commit(new AuthorizedCheckoutRequest("manual-other-operation", "O'Neil", "MAD", false,
            basket, new[] { new CheckoutPayment(CheckoutPaymentKind.Cash, 33m) }, 33m)); }
        catch (UnauthorizedAccessException ex) when (ex.Message.Contains("autre opération")) { operationDenied = true; }
        Require(operationDenied && ManualSnapshot() == posted, "One-operation manual approval was reused for another sale.");
        using (var db = Open(settings))
        {
            var ticket = LogicaPostedTicket.Read(db, request.OperationId, "O'Neil", "01");
            Require(ticket is not null && ticket.Total == 33m && ticket.Lines.All(line => line.Discount == 25m) &&
                ticket.Payments.Any(row => row.Mode == "ESPECES" && row.Amount == -17m),
                "Persisted manual-discount receipt lost the original net or change.");
        }
        Sql(settings, "UPDATE TABLE_ARTICLES SET PRIX_V_1=99,PRIX_QTE=88,PROMOTION=50 WHERE ID_ARTICLE='MANUAL-A'");
        var refund = PrepareWpfReturn(settings, pin, request.OperationId);
        try
        {
            Require(refund.Window.ConfirmReturnDraft() &&
                Number(settings, "SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='MANUAL-A'") == 20m &&
                Number(settings, "SELECT COUNT(*) FROM TABLE_VENTES_JOURNAL WHERE ID_ARTICLE='MANUAL-A' AND Qté=-3 AND PRIX_V=8 AND Remise=25 AND Total_NET=-18") == 1 &&
                Number(settings, "SELECT COUNT(*) FROM hanouty_cash_return_consumption WHERE original_ticket_id=@id", request.OperationId) == 1,
                "Manual refund did not preserve the original net/discount after catalogue changed.");
        }
        finally { refund.Window.Close(); }
        Sql(settings, "UPDATE TABLE_ARTICLES SET PRIX_V_1=10,PRIX_QTE=8,PROMOTION=10 WHERE ID_ARTICLE='MANUAL-A'");
        Access("VISIBLE");
        VerifyManualDiscountCashierUi(settings, pin);
        File.WriteAllText(Path.Combine(EvidenceDirectory, "w2-manual-discounts.json"), JsonSerializer.Serialize(new {
            ExactOriginalRoles = true, GlobalAndSelectedPercentAndDh = true, OriginalZeroReset = true,
            BothCultures = true, NonPositiveTicketRejected = true, PreviewPriceRaceRejected = true,
            FreshWaitingAuthorization = true, RevocationBeforePosting = true, AtomicWaitingConsumption = true,
            RevokedManagerRejected = true, DatabaseScopeBound = true, SelectedGrossRounding = true,
            OriginalReceiptNetAndChange = true, DurableReplay = true, DifferentOperationDenied = true,
            OriginalManualNetRefund = true,
            CashierTouchReviewAndPayment = true, BasketAndFixedPaymentVisible = true
        }, new JsonSerializerOptions { WriteIndented = true }));
    }

    private static void VerifyManualDiscountCashierUi(CatalogueSettings settings, string pin)
    {
        var host = CatalogueHost.CreateCashierWorkstation(settings, "01");
        Exception? failure = null;
        var timeout = new System.Windows.Threading.DispatcherTimer { Interval = TimeSpan.FromSeconds(12) };
        timeout.Tick += (_, _) =>
        {
            timeout.Stop(); failure ??= new TimeoutException("Manual-discount cashier modal timed out.");
            foreach (var modal in Application.Current.Windows.Cast<Window>().Where(window => window != host.Window && window.IsVisible).Reverse().ToArray())
                modal.Close();
        };
        try
        {
            Require(CashierEntry(host, "O'Neil", "01", "0", 0m, pin), "Manual discount UI cashier login failed.");
            host.ViewModel.ScannerText = "MANUAL-B-CODE"; host.ViewModel.ScanCommand.Execute(null);
            Require(host.ViewModel.BasketLines.Single().NetAmountMad == 20m, "Manual UI scanner fixture failed.");
            host.Window.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.ApplicationIdle, new Action(() =>
            {
                var dialog = Application.Current.Windows.OfType<ManualDiscountDialog>().SingleOrDefault();
                try
                {
                    Require(dialog is not null, "Real manual discount modal did not open.");
                    Require(!host.Window.PayByCard() && !host.Window.EndFinancialSession() &&
                        !host.Window.ChangeBasketQuantity(host.ViewModel.BasketLines.Single(), 2),
                        "Nested payment/logout/quantity was accepted during manual review.");
                    var field = CatalogueControls<TextBox>(dialog!).Single();
                    Require(field.IsReadOnly, "Manual discount must use touch entry.");
                    host.Window.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.ApplicationIdle, new Action(() =>
                    {
                        var keypad = Application.Current.Windows.OfType<TouchNumericEntryDialog>().SingleOrDefault();
                        try
                        {
                            Require(keypad is not null, "Touching discount value did not open the shared keypad.");
                            var keys = CatalogueControls<Button>(keypad!).ToArray();
                            foreach (var key in new[] { "2", "5", "Appliquer" })
                                keys.Single(button => Equals(button.Content, key)).RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                        }
                        catch (Exception ex) { failure = ex; keypad?.Close(); }
                    }));
                    field.RaiseEvent(new System.Windows.Input.MouseButtonEventArgs(System.Windows.Input.Mouse.PrimaryDevice,
                        0, System.Windows.Input.MouseButton.Left) { RoutedEvent = UIElement.PreviewMouseLeftButtonDownEvent });
                    var apply = CatalogueControls<Button>(dialog!).Single(button => button.IsDefault);
                    Require(apply.IsEnabled && CatalogueControls<TextBlock>(dialog!).Any(block => block.Text.Contains("15,00") || block.Text.Contains("15.00")),
                        "Manual preview did not show the trusted amount before confirmation.");
                    apply.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                }
                catch (Exception ex) { failure = ex; dialog?.Close(); }
            }));
            timeout.Start();
            var applied = host.Window.ShowManualDiscount();
            timeout.Stop();
            Require(applied && failure is null &&
                host.ViewModel.BasketLines.Single().DiscountPercent == 25m && host.Window.RefreshTrustedBasketTotal() &&
                ((TextBlock)host.Window.FindName("TrustedBasketTotal")).Text == "15.00", "Manual modal did not refresh the real basket/total: " + failure);
            host.Window.UpdateLayout();
            var basket = (DataGrid)host.Window.FindName("CashierBasket");
            var payment = (FrameworkElement)host.Window.FindName("FixedPaymentPanel");
            Require(basket.ActualHeight >= 72 && basket.TranslatePoint(new Point(0, basket.ActualHeight), host.Window).Y <=
                payment.TranslatePoint(new Point(0, 0), host.Window).Y, "Real cashier basket is hidden behind payment.");
            var image = new System.Windows.Media.Imaging.RenderTargetBitmap((int)Math.Ceiling(host.Window.ActualWidth),
                (int)Math.Ceiling(host.Window.ActualHeight), 96, 96, System.Windows.Media.PixelFormats.Pbgra32);
            image.Render(host.Window);
            var encoder = new System.Windows.Media.Imaging.PngBitmapEncoder();
            encoder.Frames.Add(System.Windows.Media.Imaging.BitmapFrame.Create(image));
            using (var stream = File.Create(Path.Combine(EvidenceDirectory, "manual-discount-cashier-basket.png"))) encoder.Save(stream);
            host.Window.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.ApplicationIdle, new Action(() =>
            {
                var dialog = Application.Current.Windows.OfType<CashierEntryDialog>().SingleOrDefault();
                try
                {
                    Require(dialog is not null, "Discounted cash payment did not open from its fixed button.");
                    var buttons = CatalogueControls<Button>(dialog!).ToArray();
                    buttons.Single(button => System.Windows.Automation.AutomationProperties.GetName(button) == "20 MAD")
                        .RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                    Require(CatalogueControls<TextBlock>(dialog!).Any(block => block.Text == $"Monnaie à rendre : {5m:N2} MAD"),
                        "Discounted cash payment did not display actual change.");
                    buttons.Single(button => button.IsDefault).RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                }
                catch (Exception ex) { failure = ex; dialog?.Close(); }
            }));
            CatalogueControls<Button>(host.Window).Single(button =>
                System.Windows.Automation.AutomationProperties.GetName(button) == "Enter sale cash tender")
                .RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            Require(failure is null && host.ViewModel.CanCommit, "Discounted tender review failed: " + failure);
            ReviewThroughDialog(host, pin, true, () => host.ViewModel.CommitCommand.Execute(null));
            Require(host.Session.PendingCount == 0 && !host.ViewModel.CheckoutUncertain, "Discounted UI sale did not post.");
            host.ViewModel.ScannerText = "MANUAL-B-CODE"; host.ViewModel.ScanCommand.Execute(null);
            Require(host.ViewModel.BasketLines.Single().DiscountPercent == 0m &&
                host.ViewModel.BasketLines.Single().NetAmountMad == 20m,
                "Manual discount leaked into the next customer's basket.");
            Require(((TextBlock)host.Window.FindName("LastSaleSummary")).Text.Contains("5,00") ||
                ((TextBlock)host.Window.FindName("LastSaleSummary")).Text.Contains("5.00"),
                "Recorded change was not retained after sale for the cashier.");
            Sql(settings, "UPDATE TABLE_PASS SET REMISE='ACCES MANAGER' WHERE ListUser='O''Neil'");
            var roleSeen = false; var discountSeen = false;
            PasswordBox? roleControl = null;
            var approvalTimer = new System.Windows.Threading.DispatcherTimer { Interval = TimeSpan.FromMilliseconds(30) };
            approvalTimer.Tick += (_, _) =>
            {
                var modal = Application.Current.Windows.Cast<Window>().SingleOrDefault(window => window.Owner == host.Window && window.IsVisible);
                try
                {
                    if (!roleSeen && modal is not null && CatalogueControls<PasswordBox>(modal).SingleOrDefault() is { } secret)
                    {
                        roleSeen = true; roleControl = secret;
                        var buttons = CatalogueControls<Button>(modal).ToArray();
                        foreach (var key in "5678")
                            buttons.Single(button => System.Windows.Automation.AutomationProperties.GetName(button) == "PIN " + key)
                                .RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                        buttons.Single(button => button.IsDefault).RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                    }
                    else if (modal is ManualDiscountDialog discount)
                    {
                        discountSeen = true; approvalTimer.Stop();
                        CatalogueControls<TextBox>(discount).Single().Text = "10";
                        CatalogueControls<Button>(discount).Single(button => button.IsDefault).RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                    }
                }
                catch (Exception ex) { failure = ex; approvalTimer.Stop(); modal?.Close(); }
            };
            try
            {
                timeout.Start(); approvalTimer.Start();
                Require(host.Window.ShowManualDiscount() && failure is null && roleSeen && discountSeen &&
                    roleControl?.Password.Length == 0 && host.ViewModel.BasketLines.Single().NetAmountMad == 18m,
                    "Fresh exact-manager touch PIN did not authorize the real discount dialog: " + failure);
            }
            finally { approvalTimer.Stop(); timeout.Stop(); }
        }
        finally
        {
            timeout.Stop(); host.Window.Close();
            Sql(settings, "UPDATE TABLE_PASS SET REMISE='VISIBLE' WHERE ListUser='O''Neil'");
        }
    }
}
#endif
