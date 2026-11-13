using System.Windows;
using System.Windows.Controls;
using System.Globalization;
using Hanouty.Desktop.Wpf.Presentation;

namespace Hanouty.Desktop.Wpf;

public partial class InventoryCountWindow : Window
{
    // Inventory supplies the only authorized implementation. Null is intentional
    // until the production contract is reviewed and connected by the Host.
    public InventoryCountWindow(IInventoryCountWorkflow? workflow = null)
    {
        InitializeComponent();
        DataContext = new InventoryCountViewModel(workflow);
    }
    private InventoryCountViewModel Model => (InventoryCountViewModel)DataContext;
    private void Open_Click(object sender, RoutedEventArgs e) => Model.Open();
    private void Record_Click(object sender, RoutedEventArgs e) => Model.Record();
    private void CountLine_Selected(object sender, SelectionChangedEventArgs e)
    {
        if (sender is DataGrid { SelectedItem: InventoryCountLine line })
        {
            Model.ArticleId = line.ArticleId;
            Model.PhysicalText = line.PhysicalQuantity?.ToString(CultureInfo.InvariantCulture) ?? "";
        }
    }

    private void Confirm_Click(object sender, RoutedEventArgs e)
    {
        if (!Model.CanConfirm) return;
        var documentId = Model.DocumentId;
        var response = MessageBox.Show(this,
            $"Confirmer définitivement l'inventaire {documentId} ? Les écarts seront soumis à Inventory.",
            "Confirmation inventaire", MessageBoxButton.YesNo, MessageBoxImage.Warning,
            MessageBoxResult.No);
        // The modal prompt must never authorize a document switched while open.
        if (response == MessageBoxResult.Yes && Model.CanConfirm && Model.DocumentId == documentId)
            Model.Confirm();
    }
}
