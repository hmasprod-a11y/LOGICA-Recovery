using System.Windows;
using Hanouty.Desktop.Wpf.Presentation;

namespace Hanouty.Desktop.Wpf;
public partial class MainWindow
{
    private Action<bool>? _openSalesJournal;
    private Action? _openWorkstationSettings;
    public void ConfigureWorkstationSettings(Action open) => _openWorkstationSettings = open;
    public void ConfigureSalesJournal(Action<bool> open) => _openSalesJournal = open;
    public bool ShowSalesJournal(bool statistics = false)
    {
        if (_businessDocumentsOpen || _customerFilesOpen || _manualDiscountOpen || _alternatePaymentOpen ||
            _cashierEntryOpen || _reviewOpen || _logoutOpen || _pinOpen || _originalSaleLookupBusy ||
            DataContext is not CatalogueViewModel { FinancialSessionActive: true, CheckoutBusy: false, CheckoutUncertain: false, PendingOperationId: null } ||
            _openSalesJournal is null) return false;
        // Reuse the existing modal guard so all sale/session actions remain frozen.
        _businessDocumentsOpen = true;
        try { _openSalesJournal(statistics); return true; }
        finally { _businessDocumentsOpen = false; }
    }
    private void OpenSalesJournal_Click(object sender, RoutedEventArgs args) => ShowSalesJournal();
    private void OpenSalesStatistics_Click(object sender, RoutedEventArgs args) => ShowSalesJournal(true);
    private void OpenWorkstationSettings_Click(object sender, RoutedEventArgs args)
    {
        if (_openWorkstationSettings is null || _businessDocumentsOpen || _customerFilesOpen || _manualDiscountOpen ||
            _alternatePaymentOpen || _cashierEntryOpen || _reviewOpen || _logoutOpen || _pinOpen || _originalSaleLookupBusy ||
            DataContext is not CatalogueViewModel { FinancialSessionActive: true, CheckoutBusy: false, CheckoutUncertain: false, PendingOperationId: null }) return;
        _businessDocumentsOpen = true;
        try { _openWorkstationSettings(); }
        finally { _businessDocumentsOpen = false; }
    }
}
