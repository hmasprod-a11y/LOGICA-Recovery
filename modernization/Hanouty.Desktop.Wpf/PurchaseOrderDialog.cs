using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;

namespace Hanouty.Desktop.Wpf;

public sealed record PurchaseOrderViewRow(string OrderNumber, string Supplier, DateTime OrderDate, decimal Total, string Status);

public sealed record PurchaseOrderDraftLine(string ArticleId, string Code, string ArticleName, decimal Quantity, decimal UnitPrice);

public sealed class PurchaseOrderDialog : Window
{
    private readonly ObservableCollection<PurchaseOrderDraftLine> draftLines = new();
    private readonly TextBlock feedback = new() { TextWrapping = TextWrapping.Wrap, Margin = new Thickness(0, 6, 0, 6) };

    public PurchaseOrderDialog(
        Func<IReadOnlyList<PurchaseOrderViewRow>> loadOrders,
        Func<string, IReadOnlyList<PurchaseOrderDraftLine>, string> createOrder)
    {
        ArgumentNullException.ThrowIfNull(loadOrders);
        ArgumentNullException.ThrowIfNull(createOrder);

        Title = "Commandes fournisseurs (BC)";
        Width = 760;
        Height = 560;
        WindowStartupLocation = WindowStartupLocation.CenterOwner;

        var ordersGrid = new DataGrid { AutoGenerateColumns = false, IsReadOnly = true, MaxHeight = 190 };
        ordersGrid.Columns.Add(new DataGridTextColumn { Header = "N° BC", Binding = new System.Windows.Data.Binding("OrderNumber"), Width = 110 });
        ordersGrid.Columns.Add(new DataGridTextColumn { Header = "Fournisseur", Binding = new System.Windows.Data.Binding("Supplier"), Width = new DataGridLength(1, DataGridLengthUnitType.Star) });
        ordersGrid.Columns.Add(new DataGridTextColumn { Header = "Date", Binding = new System.Windows.Data.Binding("OrderDate") { StringFormat = "yyyy-MM-dd" }, Width = 110 });
        ordersGrid.Columns.Add(new DataGridTextColumn { Header = "Total (MAD)", Binding = new System.Windows.Data.Binding("Total") { StringFormat = "N2" }, Width = 110 });
        ordersGrid.Columns.Add(new DataGridTextColumn { Header = "État", Binding = new System.Windows.Data.Binding("Status"), Width = 100 });

        var supplierBox = new TextBox { MinWidth = 220 };
        var codeBox = new TextBox { Width = 110 };
        var nameBox = new TextBox { Width = 180 };
        var qtyBox = new TextBox { Width = 70, Text = "1" };
        var priceBox = new TextBox { Width = 80, Text = "0" };

        var draftGrid = new DataGrid { AutoGenerateColumns = false, IsReadOnly = true, MaxHeight = 140, ItemsSource = draftLines, Margin = new Thickness(0, 6, 0, 6) };
        draftGrid.Columns.Add(new DataGridTextColumn { Header = "Code", Binding = new System.Windows.Data.Binding("Code"), Width = 110 });
        draftGrid.Columns.Add(new DataGridTextColumn { Header = "Article", Binding = new System.Windows.Data.Binding("ArticleName"), Width = new DataGridLength(1, DataGridLengthUnitType.Star) });
        draftGrid.Columns.Add(new DataGridTextColumn { Header = "Qté", Binding = new System.Windows.Data.Binding("Quantity"), Width = 70 });
        draftGrid.Columns.Add(new DataGridTextColumn { Header = "PU", Binding = new System.Windows.Data.Binding("UnitPrice"), Width = 80 });

        var addLineBtn = new Button { Content = "Ajouter ligne", Margin = new Thickness(6, 0, 0, 0), Padding = new Thickness(10, 4, 10, 4) };
        addLineBtn.Click += (_, _) =>
        {
            if (string.IsNullOrWhiteSpace(nameBox.Text) ||
                !decimal.TryParse(qtyBox.Text, NumberStyles.Number, CultureInfo.CurrentCulture, out var q) || q <= 0 ||
                !decimal.TryParse(priceBox.Text, NumberStyles.Number, CultureInfo.CurrentCulture, out var p) || p < 0)
            {
                feedback.Text = "Saisissez un article, une quantité > 0 et un prix valide.";
                return;
            }
            draftLines.Add(new PurchaseOrderDraftLine(codeBox.Text.Trim(), codeBox.Text.Trim(), nameBox.Text.Trim(), q, p));
            codeBox.Clear();
            nameBox.Clear();
            feedback.Text = "";
        };

        var saveOrderBtn = new Button { Content = "Enregistrer la commande (BC)", MinHeight = 36, Margin = new Thickness(0, 6, 0, 0) };
        saveOrderBtn.Click += (_, _) =>
        {
            try
            {
                var bc = createOrder(supplierBox.Text, draftLines);
                draftLines.Clear();
                supplierBox.Clear();
                feedback.Text = $"Commande {bc} enregistrée.";
                ordersGrid.ItemsSource = loadOrders();
            }
            catch (Exception ex) when (ex is ArgumentException or InvalidOperationException)
            {
                feedback.Text = ex.Message;
            }
        };

        var lineEntry = new StackPanel { Orientation = Orientation.Horizontal, Margin = new Thickness(0, 6, 0, 0) };
        lineEntry.Children.Add(new Label { Content = "Code:" }); lineEntry.Children.Add(codeBox);
        lineEntry.Children.Add(new Label { Content = "Article:" }); lineEntry.Children.Add(nameBox);
        lineEntry.Children.Add(new Label { Content = "Qté:" }); lineEntry.Children.Add(qtyBox);
        lineEntry.Children.Add(new Label { Content = "PU:" }); lineEntry.Children.Add(priceBox);
        lineEntry.Children.Add(addLineBtn);

        var root = new StackPanel { Margin = new Thickness(16) };
        root.Children.Add(new TextBlock { Text = "Historique des commandes", FontWeight = FontWeights.SemiBold, Margin = new Thickness(0, 0, 0, 4) });
        root.Children.Add(ordersGrid);
        root.Children.Add(new Label { Content = "Fournisseur" });
        root.Children.Add(supplierBox);
        root.Children.Add(lineEntry);
        root.Children.Add(draftGrid);
        root.Children.Add(saveOrderBtn);
        root.Children.Add(feedback);
        Content = root;

        Loaded += (_, _) => ordersGrid.ItemsSource = loadOrders();
    }
}
