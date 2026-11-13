using System.Windows;
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
    private void Confirm_Click(object sender, RoutedEventArgs e) => Model.Confirm();
}
