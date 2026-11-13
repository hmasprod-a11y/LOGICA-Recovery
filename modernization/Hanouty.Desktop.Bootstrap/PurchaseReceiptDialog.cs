using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using MySql.Data.MySqlClient;

namespace Hanouty.Desktop.Bootstrap;

internal sealed class PurchaseReceiptDialog : Window
{
    internal PurchaseReceiptDialog(PurchaseReceiptValidation service,
        Func<PurchaseReceiptValidation.Receipt, bool> validate)
    {
        Title = "Réception fournisseur";
        Width = 840;
        Height = 530;
        WindowStartupLocation = WindowStartupLocation.CenterOwner;
        var panel = new DockPanel { Margin = new Thickness(20) };
        var top = new StackPanel();
        DockPanel.SetDock(top, Dock.Top);
        panel.Children.Add(top);
        top.Children.Add(new TextBlock { Text = "Numéro du bon enregistré" });
        var number = new TextBox { MinHeight = 36, Margin = new Thickness(0, 5, 0, 6) };
        var open = new Button { Content = "Ouvrir le bon", MinHeight = 36 };
        var summary = new TextBlock { Margin = new Thickness(0, 10, 0, 8), TextWrapping = TextWrapping.Wrap };
        top.Children.Add(number);
        top.Children.Add(open);
        top.Children.Add(summary);

        var confirm = new Button { Content = "Valider la réception", MinHeight = 42,
            IsEnabled = false, Margin = new Thickness(0, 10, 0, 0) };
        DockPanel.SetDock(confirm, Dock.Bottom);
        panel.Children.Add(confirm);
        var lines = new DataGrid { AutoGenerateColumns = false, IsReadOnly = true, CanUserAddRows = false };
        lines.Columns.Add(new DataGridTextColumn { Header = "Article", Binding = new Binding("ArticleName"), Width = new DataGridLength(1, DataGridLengthUnitType.Star) });
        lines.Columns.Add(new DataGridTextColumn { Header = "Quantité", Binding = new Binding("Quantity") });
        lines.Columns.Add(new DataGridTextColumn { Header = "Prix d’achat", Binding = new Binding("Cost") });
        lines.Columns.Add(new DataGridTextColumn { Header = "Prix de vente", Binding = new Binding("SalePrice") });
        panel.Children.Add(lines);
        Content = panel;

        PurchaseReceiptValidation.Receipt? reviewed = null;
        void Reset()
        {
            reviewed = null;
            lines.ItemsSource = null;
            confirm.IsEnabled = false;
            summary.Text = "";
        }
        number.TextChanged += (_, _) => Reset();
        open.Click += (_, _) =>
        {
            Reset();
            try
            {
                reviewed = service.Read(number.Text.Trim());
                lines.ItemsSource = reviewed.Lines;
                summary.Text = $"{reviewed.Supplier} — {reviewed.Lines.Count} article(s)";
                confirm.IsEnabled = true;
            }
            catch (Exception ex) when (ex is MySqlException or InvalidOperationException or ArgumentException)
            {
                summary.Text = "Impossible d’ouvrir ce bon de réception enregistré.";
            }
        };
        confirm.Click += (_, _) =>
        {
            if (reviewed is not { } document) return;
            confirm.IsEnabled = false;
            try
            {
                if (validate(document))
                {
                    number.IsEnabled = false;
                    open.IsEnabled = false;
                    summary.Text = $"Bon {document.Id} validé. Stock et coûts mis à jour.";
                }
                else
                {
                    confirm.IsEnabled = true;
                    summary.Text = "Validation annulée. Aucun changement enregistré.";
                }
            }
            catch (UnauthorizedAccessException)
            {
                confirm.IsEnabled = true;
                summary.Text = "Validation réservée à un manager ou administrateur authentifié.";
            }
            catch (Exception ex) when (ex is MySqlException or InvalidOperationException or ArithmeticException)
            {
                Reset();
                summary.Text = "Validation non confirmée. Rouvrez le bon pour vérifier son état.";
            }
        };
    }
}
