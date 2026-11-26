#if HANOUTY_FINANCIAL
using System.IO;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;
using Hanouty.ArchitectureBridge;
using Hanouty.Checkout.MariaDb;
using Hanouty.Desktop.Wpf;
using Hanouty.Desktop.Wpf.Presentation;
using MySql.Data.MySqlClient;

namespace Hanouty.Desktop.Bootstrap;
internal static partial class DisposableCashSaleAcceptance
{
    private static void VerifyFullReturnModes(CatalogueSettings settings, string pin)
    {
        TraceStep("Actual WPF credit-debt and externally confirmed card returns");
        var config = Path.Combine(AppContext.BaseDirectory, "gestion_credit.sni");
        var old = File.Exists(config) ? File.ReadAllBytes(config) : null;
        File.WriteAllText(config, "True");
        Func<MySqlConnection> connections = () => new MySqlConnection(settings.ConnectionString);
        var port = MariaDbCashCheckoutServices.CreatePostingPort(connections, "01", () => pin, creditConfigurationDirectory: AppContext.BaseDirectory);
        var customer = new CheckoutCustomerIdentity("CREDIT-NEW", "C'100", "Client d'été");
        var host = CatalogueHost.CreateCashierWorkstation(settings, "01");
        try
        {
            Require(CashierEntry(host, "O'Neil", "01", "0", 0m, pin), "Return-mode cashier login failed.");
            foreach (var mode in new[] { "Credit", "Card" })
            {
                var kind = mode == "Credit" ? CheckoutPaymentKind.Credit : CheckoutPaymentKind.Card;
                var original = "wpf-return-" + mode + "-" + Guid.NewGuid().ToString("N");
                var stock = Number(settings, "SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='CREDIT-ARTICLE'");
                var cash = Number(settings, "SELECT COALESCE(SUM(MONTANT),0) FROM TABLE_VENTES_REGLEMENTS WHERE MODE_P='ESPECES'");
                var card = Number(settings, "SELECT COALESCE(SUM(MONTANT),0) FROM TABLE_VENTES_REGLEMENTS WHERE MODE_P='CARTE'");
                var debt = Number(settings, "SELECT COALESCE(SUM(TOTAL_NET),0) FROM TABLE_VENTES_JOURNAL WHERE ID_CLIENT='CREDIT-NEW' AND OPERATION IN ('CREDIT','RETOUR CREDIT')");
                port.Commit(new AuthorizedCheckoutRequest(original, "O'Neil", "MAD", false,
                    new[] { new CheckoutBatchLine("CREDIT-ARTICLE", 1) }, new[] { new CheckoutPayment(kind, 9m) }, 9m,
                    Customer: kind == CheckoutPaymentKind.Credit ? customer : null));
                var posted = Snapshot(settings);
                Require(!FullReturnModeThroughUi(host, pin, mode, original, false, out _) && Snapshot(settings) == posted,
                    "Canceled return confirmation changed financial data.");
                Require(FullReturnModeThroughUi(host, pin, mode, original, true, out var operation), "Actual full-ticket return did not commit.");
                Require(Number(settings, "SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='CREDIT-ARTICLE'") == stock &&
                    Number(settings, "SELECT COALESCE(SUM(MONTANT),0) FROM TABLE_VENTES_REGLEMENTS WHERE MODE_P='ESPECES'") == cash &&
                    Number(settings, "SELECT COALESCE(SUM(MONTANT),0) FROM TABLE_VENTES_REGLEMENTS WHERE MODE_P='CARTE'") == card &&
                    Number(settings, "SELECT COALESCE(SUM(TOTAL_NET),0) FROM TABLE_VENTES_JOURNAL WHERE ID_CLIENT='CREDIT-NEW' AND OPERATION IN ('CREDIT','RETOUR CREDIT')") == debt &&
                    Number(settings, "SELECT COUNT(*) FROM hanouty_cash_return_consumption WHERE original_ticket_id=@id", original) == 1 &&
                    !host.ViewModel.CheckoutUncertain && host.ViewModel.PendingOperationId is null,
                    "WPF return did not restore stock/debt/card while preserving cash.");
                var snapshot = Snapshot(settings);
                Require(!host.Window.SearchOriginalSales(original) && Snapshot(settings) == snapshot,
                    "Consumed original remained available for a second refund.");
            }
            File.WriteAllText(Path.Combine(EvidenceDirectory, "w2-full-return-modes.json"), JsonSerializer.Serialize(new {
                CreditReturnUi = true, CardReturnUi = true, ExplicitDebtConfirmation = true, ExplicitExternalCardConfirmation = true,
                CanceledConfirmationNoWrite = true, FreshCashierPin = true, ModeFrozenDuringReview = true,
                CashUnchanged = true, DebtAndCardReconciled = true, OriginalStockRestored = true, ConsumedOriginalExcluded = true
            }));
        }
        finally { host.Window.Close(); if (old is null) File.Delete(config); else File.WriteAllBytes(config, old); }
    }
    private static bool FullReturnModeThroughUi(CatalogueHost host, string pin, string mode, string original, bool confirm, out string operation)
    {
        Require(host.Window.SetReturnPaymentMode(mode) && host.Window.SearchOriginalSales(original), "Return mode or original lookup unavailable.");
        var results = (ListBox)host.Window.FindName("OriginalSaleResults");
        var selected = results.Items.Cast<OriginalSaleCandidate>().Single(row => row.SaleId == original);
        results.SelectedItem = selected;
        Require(host.Window.SelectOriginalSale(selected), "Original return selection refused.");
        Exception? failure = null; string? captured = null; PasswordBox? entered = null;
        var watchdog = new System.Windows.Threading.DispatcherTimer { Interval = TimeSpan.FromSeconds(20) };
        watchdog.Tick += (_, _) => { failure ??= new TimeoutException("Return confirmation/PIN timed out."); watchdog.Stop(); foreach (var modal in host.Window.OwnedWindows.Cast<Window>().ToArray()) modal.Close(); };
        host.Window.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.ApplicationIdle, new Action(() =>
        {
            var dialog = host.Window.OwnedWindows.Cast<Window>().SingleOrDefault(window => window.Title == (mode == "Credit" ? "Confirmer le retour crédit" : "Confirmer le remboursement CARTE"));
            try
            {
                Require(dialog is not null && !host.Window.SetReturnPaymentMode("Cash"), "Explicit return review missing or mode changed inside it.");
                Require(CatalogueControls<TextBlock>(dialog!).Any(text => text.Text.Contains(mode == "Credit" ? "réduit la dette" : "terminal externe")), "Return financial effect was not explicitly reviewed.");
                if (!confirm) { dialog!.Close(); return; }
                dialog!.UpdateLayout();
                var bitmap = new System.Windows.Media.Imaging.RenderTargetBitmap((int)Math.Ceiling(dialog.ActualWidth), (int)Math.Ceiling(dialog.ActualHeight), 96, 96, System.Windows.Media.PixelFormats.Pbgra32);
                bitmap.Render(dialog); var png = new System.Windows.Media.Imaging.PngBitmapEncoder(); png.Frames.Add(System.Windows.Media.Imaging.BitmapFrame.Create(bitmap));
                using (var file = File.Create(Path.Combine(EvidenceDirectory, "full-return-" + mode.ToLowerInvariant() + ".png"))) png.Save(file);
                host.Window.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.ApplicationIdle, new Action(() =>
                {
                    var prompt = host.Window.OwnedWindows.Cast<Window>().SingleOrDefault(window => CatalogueControls<PasswordBox>(window).Any());
                    try
                    {
                        Require(prompt is not null && !host.Window.SetReturnPaymentMode("Cash"), "Fresh return PIN missing or mode changed during PIN.");
                        captured = host.ViewModel.PendingOperationId; entered = CatalogueControls<PasswordBox>(prompt!).Single(); entered.Password = pin;
                        CatalogueControls<Button>(prompt!).Single(button => button.IsDefault).RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                    }
                    catch (Exception ex) { failure = ex; prompt?.Close(); }
                }));
                CatalogueControls<Button>(dialog).Single(button => Equals(button.Content, "Confirmer")).RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            }
            catch (Exception ex) { failure = ex; dialog?.Close(); }
        }));
        watchdog.Start(); bool result;
        try { result = host.Window.ConfirmReturnDraft(); } finally { watchdog.Stop(); }
        if (failure is not null) throw new InvalidOperationException("Full return WPF acceptance failed.", failure);
        if (confirm) Require(captured is not null && entered?.Password.Length == 0, "Fresh return PIN/operation identity not cleared/captured.");
        operation = captured ?? ""; return result;
    }
}
#endif
