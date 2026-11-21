#if HANOUTY_FINANCIAL
using System.IO;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;
using Hanouty.ArchitectureBridge;
using Hanouty.Checkout.MariaDb;
using Hanouty.Desktop.Wpf;
using Hanouty.Desktop.Wpf.Presentation;
using MySql.Data.MySqlClient;

namespace Hanouty.Desktop.Bootstrap;
internal static partial class DisposableCashSaleAcceptance
{
    private static void VerifyPartialCashReturnUi(CatalogueSettings settings, string pin)
    {
        using (var stream = typeof(DisposableCashSaleAcceptance).Assembly.GetManifestResourceStream("Hanouty.PartialCashReturnMigration"))
        using (var reader = new StreamReader(stream ?? throw new InvalidOperationException("Partial return test migration missing."))) Sql(settings, reader.ReadToEnd());
        Func<MySqlConnection> connections = () => new MySqlConnection(settings.ConnectionString);
        var original = "partial-ui-" + Guid.NewGuid().ToString("N");
        var stock = Number(settings, "SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='CREDIT-ARTICLE'");
        var cash = Number(settings, "SELECT COALESCE(SUM(MONTANT),0) FROM TABLE_VENTES_REGLEMENTS WHERE MODE_P='ESPECES'");
        var port = MariaDbCashCheckoutServices.CreatePostingPort(connections, "01", () => pin);
        var saleLines = new[] { new CheckoutBatchLine("CREDIT-ARTICLE", 3) };
        var saleTotal = MariaDbCashCheckoutServices.ReadCashSaleBasket(connections, saleLines).Sum(line => line.Amount);
        port.Commit(new AuthorizedCheckoutRequest(original, "O'Neil", "MAD", false,
            saleLines, [new CheckoutPayment(CheckoutPaymentKind.Cash, saleTotal)], saleTotal));
        var host = CatalogueHost.CreateCashierWorkstation(settings, "01");
        try
        {
            Require(CashierEntry(host, "O'Neil", "01", "0", 0m, pin), "Partial return cashier login failed.");
            foreach (var quantity in new[] { 1, 2 })
            {
                Require(host.Window.SetReturnPaymentMode("PartialCash") && host.Window.SearchOriginalSales(original), "Partial return original lookup failed.");
                var list = (ListBox)host.Window.FindName("OriginalSaleResults");
                var selected = (OriginalSaleCandidate)list.Items[0]; list.SelectedItem = selected;
                Require(host.Window.SelectOriginalSale(selected), "Partial return original selection failed.");
                Exception? failure = null; var picked = false; var enteredPin = false;
                var timer = new DispatcherTimer { Interval = TimeSpan.FromMilliseconds(50) };
                var expires = DateTime.UtcNow.AddSeconds(15);
                timer.Tick += (_, _) =>
                {
                    var modal = Application.Current.Windows.Cast<Window>().SingleOrDefault(window => window.Owner == host.Window);
                    try
                    {
                        if (DateTime.UtcNow > expires) throw new TimeoutException("Partial return UI timed out.");
                        if (modal is PartialCashReturnDialog partial && !picked)
                        {
                            Require(!host.Window.SetReturnPaymentMode("Cash"), "Return mode changed while selecting quantities.");
                            var input = CatalogueControls<TextBox>(partial).Single();
                            TouchCataloguePrice(partial, input, quantity, true);
                            CatalogueControls<CheckBox>(partial).Single().IsChecked = true;
                            picked = true;
                            CatalogueControls<Button>(partial).Single(button => button.IsDefault).RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                        }
                        else if (modal is not null && CatalogueControls<PasswordBox>(modal).SingleOrDefault() is { } password && !enteredPin)
                        {
                            enteredPin = true; password.Password = pin;
                            CatalogueControls<Button>(modal).Single(button => button.IsDefault).RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                        }
                    }
                    catch (Exception ex) { failure = ex; timer.Stop(); modal?.Close(); }
                };
                timer.Start(); bool committed;
                try { committed = host.Window.ConfirmReturnDraft(); } finally { timer.Stop(); }
                if (failure is not null) throw new InvalidOperationException("Actual partial return UI failed.", failure);
                Require(committed && picked && enteredPin && !host.ViewModel.CheckoutUncertain && host.ViewModel.PendingOperationId is null,
                    "Partial return did not commit through quantity review and fresh PIN.");
                Require(Number(settings, "SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='CREDIT-ARTICLE'") == stock - (quantity == 1 ? 2 : 0) &&
                    Number(settings, "SELECT COALESCE(SUM(MONTANT),0) FROM TABLE_VENTES_REGLEMENTS WHERE MODE_P='ESPECES'") == cash + (quantity == 1 ? saleTotal * 2 / 3 : 0),
                    "Partial return did not restore exact remaining stock and cash.");
            }
            Require(MariaDbCashCheckoutServices.FindPartialCashReturnCandidatesByReceipt(connections, original).Count == 0 &&
                MariaDbCashCheckoutServices.FindFullCashReturnCandidatesByReceipt(connections, original).Count == 0,
                "Fully consumed original remained refundable.");
            File.WriteAllText(Path.Combine(EvidenceDirectory, "w2-partial-cash-return.json"), JsonSerializer.Serialize(new {
                ActualHost = true, OriginalTicketSelection = true, TouchQuantityKeypad = true, ExplicitReview = true,
                FreshPinEachReturn = true, TwoCumulativeReturns = true, OriginalStockAndCashRestored = true,
                FullyConsumedOriginalExcluded = true, ExactCentWholeQuantityScope = true
            }));
        }
        finally { host.Window.Close(); }
    }
}
#endif
