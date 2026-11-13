using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using MySql.Data.MySqlClient;

namespace Hanouty.Desktop.Bootstrap;

internal sealed class PurchaseReceiptDialog : Window
{
    internal PurchaseReceiptDialog(PurchaseReceiptValidation service,
        Func<PurchaseReceiptValidation.Receipt, bool> validate,
        Func<string, string, decimal, PurchaseReceiptValidation.Receipt?> createFromOrder,
        Func<PurchaseReceiptValidation.Receipt, bool> cancelReceipt,
        Func<string, string, decimal, string?> createOrder)
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
        var orderInputs = new StackPanel { Orientation = Orientation.Horizontal, Margin = new Thickness(0, 12, 0, 0) };
        top.Children.Add(new TextBlock { Text = "Nouveau bon depuis une commande validée", Margin = new Thickness(0, 12, 0, 0) });
        top.Children.Add(orderInputs);
        TextBox OrderField(string label)
        {
            var field = new TextBox { MinWidth = 140, MinHeight = 32, Margin = new Thickness(0, 0, 8, 0),
                ToolTip = label };
            System.Windows.Automation.AutomationProperties.SetName(field, label);
            var cell = new StackPanel();
            cell.Children.Add(new TextBlock { Text = label });
            cell.Children.Add(field);
            orderInputs.Children.Add(cell);
            return field;
        }
        var order = OrderField("Commande");
        var article = OrderField("Identifiant article");
        var quantity = OrderField("Quantité reçue");
        var create = new Button { Content = "Créer le bon", MinHeight = 32, Margin = new Thickness(0, 14, 0, 0) };
        orderInputs.Children.Add(create);
        var orderCreation = new StackPanel { Orientation = Orientation.Horizontal, Margin = new Thickness(0, 8, 0, 0) };
        var supplier = new TextBox { MinWidth = 160, MinHeight = 32, ToolTip = "Identifiant fournisseur" };
        System.Windows.Automation.AutomationProperties.SetName(supplier, "Identifiant fournisseur");
        var saveOrder = new Button { Content = "Créer et valider la commande", MinHeight = 32 };
        orderCreation.Children.Add(new TextBlock { Text = "Fournisseur", VerticalAlignment = VerticalAlignment.Center,
            Margin = new Thickness(0, 0, 8, 0) });
        orderCreation.Children.Add(supplier);
        orderCreation.Children.Add(saveOrder);
        top.Children.Add(orderCreation);
        top.Children.Add(summary);
        saveOrder.Click += (_, _) =>
        {
            if (!decimal.TryParse(quantity.Text.Trim().Replace(',', '.'),
                System.Globalization.NumberStyles.AllowDecimalPoint,
                System.Globalization.CultureInfo.InvariantCulture, out var amount) || amount <= 0)
            {
                summary.Text = "Saisissez l’article et la quantité commandée.";
                return;
            }
            saveOrder.IsEnabled = false;
            try
            {
                var id = createOrder(supplier.Text.Trim(), article.Text.Trim(), amount);
                if (id is not null)
                {
                    order.Text = id;
                    summary.Text = $"Commande {id} validée.";
                }
            }
            catch (Exception ex) when (ex is InvalidOperationException or ArgumentException or MySqlException or UnauthorizedAccessException or ArithmeticException)
            {
                summary.Text = "Commande non confirmée. Vérifiez le fournisseur, l’article et vos droits.";
            }
            finally { saveOrder.IsEnabled = true; }
        };

        var confirm = new Button { Content = "Valider la réception", MinHeight = 42,
            IsEnabled = false, Margin = new Thickness(0, 10, 0, 0) };
        var actions = new StackPanel { Orientation = Orientation.Horizontal };
        var cancel = new Button { Content = "Annuler le bon enregistré", MinHeight = 42,
            IsEnabled = false, Margin = new Thickness(12, 10, 0, 0) };
        actions.Children.Add(confirm);
        actions.Children.Add(cancel);
        DockPanel.SetDock(actions, Dock.Bottom);
        panel.Children.Add(actions);
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
            cancel.IsEnabled = false;
            summary.Text = "";
        }
        void Display(PurchaseReceiptValidation.Receipt receipt)
        {
            reviewed = receipt;
            lines.ItemsSource = receipt.Lines;
            summary.Text = $"{receipt.Id} — {receipt.Supplier} — {receipt.Lines.Count} article(s)";
            confirm.IsEnabled = true;
            cancel.IsEnabled = true;
        }

        create.Click += (_, _) =>
        {
            if (!decimal.TryParse(quantity.Text.Trim().Replace(',', '.'),
                System.Globalization.NumberStyles.AllowDecimalPoint,
                System.Globalization.CultureInfo.InvariantCulture, out var amount) || amount <= 0)
            {
                summary.Text = "Saisissez une quantité reçue positive.";
                return;
            }
            create.IsEnabled = false;
            try
            {
                var receipt = createFromOrder(order.Text.Trim(), article.Text.Trim(), amount);
                if (receipt is null) { summary.Text = "Création annulée."; return; }
                number.Text = receipt.Id;
                Display(receipt);
            }
            catch (Exception ex) when (ex is InvalidOperationException or ArgumentException or MySqlException or UnauthorizedAccessException)
            {
                Reset();
                summary.Text = ex is InvalidOperationException or ArgumentException ? ex.Message :
                    "Création non confirmée. Vérifiez la commande et les bons enregistrés.";
            }
            finally { create.IsEnabled = true; }
        };
        number.TextChanged += (_, _) => Reset();
        open.Click += (_, _) =>
        {
            Reset();
            try
            {
                Display(service.Read(number.Text.Trim()));
            }
            catch (Exception ex) when (ex is MySqlException or InvalidOperationException or ArgumentException)
            {
                summary.Text = "Impossible d’ouvrir ce bon de réception enregistré.";
            }
        };
        cancel.Click += (_, _) =>
        {
            if (reviewed is not { } document) return;
            cancel.IsEnabled = false;
            confirm.IsEnabled = false;
            try
            {
                if (cancelReceipt(document))
                {
                    number.Clear();
                    summary.Text = $"Bon {document.Id} annulé. Quantité libérée.";
                }
                else Display(document);
            }
            catch (Exception ex) when (ex is MySqlException or InvalidOperationException or UnauthorizedAccessException)
            {
                Reset();
                summary.Text = "Annulation non confirmée. Rouvrez le bon pour vérifier son état.";
            }
        };
        confirm.Click += (_, _) =>
        {
            if (reviewed is not { } document) return;
            confirm.IsEnabled = false;
            cancel.IsEnabled = false;
            try
            {
                if (validate(document))
                {
                    reviewed = null;
                    summary.Text = $"Bon {document.Id} validé. Stock et coûts mis à jour.";
                }
                else
                {
                    confirm.IsEnabled = true;
                    cancel.IsEnabled = true;
                    summary.Text = "Validation annulée. Aucun changement enregistré.";
                }
            }
            catch (UnauthorizedAccessException)
            {
                confirm.IsEnabled = true;
                cancel.IsEnabled = true;
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
