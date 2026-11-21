using System.ComponentModel;
using System.Windows;
using Hanouty.Desktop.Wpf.Presentation;

namespace Hanouty.Desktop.Wpf;

public partial class MainWindow
{
    private Func<bool>? _creditSale;
    private Func<bool>? _creditSaleEnabled;

    public void ConfigureCreditSales(Func<bool> submit, Func<bool> enabled)
    {
        if (_creditSale is not null) throw new InvalidOperationException("Credit sale already configured.");
        _creditSale = submit; _creditSaleEnabled = enabled;
        if (DataContext is CatalogueViewModel vm)
        {
            void Changed(object? sender, PropertyChangedEventArgs args)
            { if (args.PropertyName == nameof(CatalogueViewModel.FinancialSessionActive)) RefreshCreditSaleAvailability(); }
            vm.PropertyChanged += Changed;
            Closed += (_, _) => vm.PropertyChanged -= Changed;
        }
        Loaded += (_, _) => RefreshCreditSaleAvailability();
        RefreshCreditSaleAvailability();
    }

    public void RefreshCreditSaleAvailability()
    {
        var enabled = false;
        try { enabled = DataContext is CatalogueViewModel { FinancialSessionActive: true } && _creditSaleEnabled?.Invoke() == true; }
        catch (Exception ex) when (ex is not OutOfMemoryException and not StackOverflowException) { }
        CreditSaleButton.Visibility = enabled ? Visibility.Visible : Visibility.Collapsed;
    }

    public bool SellOnCredit() => PayAlternate(_creditSale);
    private void CreditSale_Click(object sender, RoutedEventArgs args) => SellOnCredit();
}
