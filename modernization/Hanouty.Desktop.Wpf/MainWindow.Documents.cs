using System.Windows;
using Hanouty.Desktop.Wpf.Presentation;

namespace Hanouty.Desktop.Wpf;

public partial class MainWindow
{
    private Action? _openBusinessDocuments;
    private bool _businessDocumentsOpen;
    public void ConfigureBusinessDocuments(Action open) => _openBusinessDocuments = open;
    public bool ShowBusinessDocuments()
    {
        if (_businessDocumentsOpen || _customerFilesOpen || _manualDiscountOpen || _alternatePaymentOpen || _cashierEntryOpen || _reviewOpen || _logoutOpen || _pinOpen ||
            DataContext is not CatalogueViewModel { FinancialSessionActive: true, CheckoutBusy: false, CheckoutUncertain: false, PendingOperationId: null } ||
            _openBusinessDocuments is null) return false;
        _businessDocumentsOpen = true;
        try { _openBusinessDocuments(); return true; }
        finally { _businessDocumentsOpen = false; }
    }
    private void OpenBusinessDocuments_Click(object sender, RoutedEventArgs args) => ShowBusinessDocuments();
}
