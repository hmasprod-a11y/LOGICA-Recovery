using System.ComponentModel;
using System.Windows;
using Hanouty.Desktop.Wpf.Presentation;

namespace Hanouty.Desktop.Wpf;

public partial class MainWindow
{
    private Func<IManualDiscountReview?>? _beginManualDiscount;
    private Func<bool>? _manualDiscountAvailable;
    private bool _manualDiscountOpen;

    public void ConfigureManualDiscounts(Func<IManualDiscountReview?> beginReview, Func<bool> available)
    {
        if (_beginManualDiscount is not null) throw new InvalidOperationException("Manual discount review already configured.");
        _beginManualDiscount = beginReview;
        _manualDiscountAvailable = available;
        if (DataContext is CatalogueViewModel vm)
        {
            void Changed(object? sender, PropertyChangedEventArgs args)
            {
                if (args.PropertyName == nameof(CatalogueViewModel.FinancialSessionActive))
                    RefreshManualDiscountAvailability();
            }
            vm.PropertyChanged += Changed;
            Closed += (_, _) => vm.PropertyChanged -= Changed;
        }
        Loaded += (_, _) => RefreshManualDiscountAvailability();
        RefreshManualDiscountAvailability();
    }

    private void RefreshManualDiscountAvailability()
    {
        var available = false;
        if (DataContext is CatalogueViewModel { FinancialSessionActive: true })
        {
            try { available = _manualDiscountAvailable?.Invoke() == true; }
            catch (Exception ex) when (ex is not OutOfMemoryException and not StackOverflowException) { }
        }
        ManualDiscountButton.Visibility = available ? Visibility.Visible : Visibility.Collapsed;
    }

    public bool ShowManualDiscount()
    {
        if (_manualDiscountOpen || _alternatePaymentOpen || _cashierEntryOpen || _reviewOpen || _logoutOpen ||
            _pinOpen || _trustedTotalReadBusy || _originalSaleLookupBusy || _beginManualDiscount is null ||
            DataContext is not CatalogueViewModel vm || !vm.FinancialSessionActive || vm.CheckoutBusy ||
            vm.CheckoutUncertain || vm.PendingOperationId is not null || vm.BasketLines.Count == 0)
            return false;
        RefreshManualDiscountAvailability();
        if (ManualDiscountButton.Visibility != Visibility.Visible) return false;
        _manualDiscountOpen = true;
        var applied = false;
        ManualDiscountStatus.Text = "";
        try
        {
            using var review = _beginManualDiscount();
            if (review is null) return false;
            var selected = CashierBasket.SelectedItem as BasketDisplayLine;
            var dialog = new ManualDiscountDialog(vm.BasketLines.ToArray(), selected?.ArticleId, review.Preview) { Owner = this };
            if (dialog.ShowDialog() != true || dialog.Choice is not { } choice) return false;
            applied = review.Apply(choice);
            ManualDiscountStatus.Text = applied ? "Remise appliquée. Revoyez le montant reçu." : "Remise non appliquée.";
            return applied;
        }
        catch (Exception ex) when (ex is not OutOfMemoryException and not StackOverflowException)
        {
            ManualDiscountStatus.Text = ex is ArgumentException or InvalidOperationException or UnauthorizedAccessException
                ? ex.Message : "La remise n’a pas été confirmée.";
            return false;
        }
        finally
        {
            _manualDiscountOpen = false;
            if (applied) { vm.RefreshBasketLines(); RefreshTrustedBasketTotal(); }
        }
    }

    public string PromptDiscountApprovalPin(string role)
    {
        if (role is not ("ADMIN" or "MANAGER") || _pinOpen || _logoutOpen ||
            DataContext is not CatalogueViewModel { FinancialSessionActive: true, CheckoutBusy: false, CheckoutUncertain: false } vm ||
            vm.PendingOperationId is not null) return "";
        return ReadPin("Autorisation de remise", $"Saisissez le PIN du rôle {role}.");
    }

    public void SetLastSaleSummary(string message) => LastSaleSummary.Text = message;

    private void RefreshCashierSessionLabel()
    {
        var identity = ReadSessionIdentity();
        CashierSessionLabel.Text = DataContext is CatalogueViewModel { FinancialSessionActive: true } && identity is not null
            ? $"Caisse {identity.RegisterId} · {identity.CashierId}" : "Session fermée";
    }

    private void ManualDiscount_Click(object sender, RoutedEventArgs args) => ShowManualDiscount();
}
