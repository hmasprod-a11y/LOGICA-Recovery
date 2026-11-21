#if HANOUTY_FINANCIAL
using System.IO;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;
using Hanouty.Desktop.Wpf.Presentation;

namespace Hanouty.Desktop.Bootstrap;
internal static partial class DisposableCashSaleAcceptance
{
    private static void VerifyPinOnlyLogin(CatalogueSettings settings)
    {
        Sql(settings, "INSERT INTO TABLE_PASS (ListUser,ListPass,Catégorie) VALUES ('Caissier d''été','2356','UTILISATEUR'),('مدير','2357','ADMIN'),('Shared first','2358','UTILISATEUR'),('Shared second','2358','ADMIN')");
        var host = CatalogueHost.CreateCashierWorkstation(settings, "01");
        host.Window.Show();
        try
        {
            var before = Snapshot(settings);
            foreach (var candidate in new[] { (Pin: "9998", Actor: "", Confirm: true), (Pin: "2356", Actor: "", Confirm: false),
                (Pin: "2358", Actor: "", Confirm: true), (Pin: "2356", Actor: "Caissier d'été", Confirm: true), (Pin: "2357", Actor: "مدير", Confirm: true) })
            {
                Exception? failure = null; PasswordBox? entered = null;
                host.Window.Dispatcher.BeginInvoke(DispatcherPriority.ApplicationIdle, new Action(() =>
                {
                    var dialog = Application.Current.Windows.Cast<Window>().SingleOrDefault(window => window.Owner == host.Window);
                    try
                    {
                        if (dialog is null) throw new InvalidOperationException("PIN-only login did not open.");
                        Require(dialog.Title == "Connexion à la caisse" && !CatalogueControls<TextBox>(dialog).Any(),
                            "Ordinary login still asks for typed cashier/register/tender.");
                        Require(!host.Window.ShowPinLogin() && !host.Window.EndFinancialSession(), "PIN login allowed nested session changes.");
                        entered = CatalogueControls<PasswordBox>(dialog!).Single();
                        foreach (var digit in candidate.Pin)
                            CatalogueControls<Button>(dialog).Single(button => System.Windows.Automation.AutomationProperties.GetName(button) == "PIN " + digit)
                                .RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                        if (candidate.Confirm) CatalogueControls<Button>(dialog).Single(button => button.IsDefault).RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                        else dialog.Close();
                    }
                    catch (Exception ex) { failure = ex; dialog?.Close(); }
                }));
                var accepted = host.Window.ShowPinLogin();
                if (failure is not null) throw new InvalidOperationException("Actual PIN-only login failed.", failure);
                Require(accepted == (candidate.Actor.Length > 0) && entered?.Password.Length == 0 && Snapshot(settings) == before,
                    "PIN login accepted wrong/shared/canceled code, retained the secret, or changed financial data.");
                if (accepted)
                {
                    Require(host.ViewModel.PaymentContext is { CashierId: var actor, RegisterId: "01", TenderedAmount: 0m } && actor == candidate.Actor &&
                        host.ViewModel.FinancialSessionActive && !host.ViewModel.CanCommit && host.Session.PendingCount == 0,
                        "PIN login did not bind the original Unicode cashier to the fixed register without payment authority.");
                    Require(host.Window.EndFinancialSession(), "Authenticated empty PIN session could not log out.");
                }
            }
            File.WriteAllText(Path.Combine(EvidenceDirectory, "w2-pin-login.json"), JsonSerializer.Serialize(new {
                OriginalPinIdentityLookup = true, ActualNumericKeypad = true, NoTypedIdentityOrRegister = true,
                FixedRegister = true, ArabicAndAccentIdentity = true, WrongCanceledAndSharedPinDenied = true,
                NestedSessionChangesDenied = true, MaskedControlCleared = true, NoFinancialAuthorityOrWrites = true
            }));
        }
        finally { host.Window.Close(); Sql(settings, "DELETE FROM TABLE_PASS WHERE ListUser IN ('Caissier d''été','مدير','Shared first','Shared second')"); }
    }
}
#endif
