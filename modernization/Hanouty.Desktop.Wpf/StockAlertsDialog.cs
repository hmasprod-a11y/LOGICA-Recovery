using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace Hanouty.Desktop.Wpf;

public sealed record StockAlertViewRow(string Code, string Article, decimal Stock, string ModeStock);

public sealed record ExpiryAlertViewRow(string Code, string Article, DateTime ExpiryDate, decimal Quantity, string LotNumber);

public sealed class StockAlertsDialog : Window
{
    public StockAlertsDialog(
        Func<decimal, IReadOnlyList<StockAlertViewRow>> loadLowStock,
        Func<DateTime, DateTime, IReadOnlyList<ExpiryAlertViewRow>> loadExpiring)
    {
        ArgumentNullException.ThrowIfNull(loadLowStock);
        ArgumentNullException.ThrowIfNull(loadExpiring);

        Title = "Alertes de stock et péremption";
        Width = 720;
        Height = 500;
        WindowStartupLocation = WindowStartupLocation.CenterOwner;

        var stockGrid = new DataGrid { AutoGenerateColumns = false, IsReadOnly = true };
        stockGrid.Columns.Add(new DataGridTextColumn { Header = "Code", Binding = new System.Windows.Data.Binding("Code"), Width = 130 });
        stockGrid.Columns.Add(new DataGridTextColumn { Header = "Article", Binding = new System.Windows.Data.Binding("Article"), Width = new DataGridLength(1, DataGridLengthUnitType.Star) });
        stockGrid.Columns.Add(new DataGridTextColumn { Header = "Stock", Binding = new System.Windows.Data.Binding("Stock"), Width = 90 });
        stockGrid.Columns.Add(new DataGridTextColumn { Header = "Mode", Binding = new System.Windows.Data.Binding("ModeStock"), Width = 130 });

        var expiryGrid = new DataGrid { AutoGenerateColumns = false, IsReadOnly = true };
        expiryGrid.Columns.Add(new DataGridTextColumn { Header = "Code", Binding = new System.Windows.Data.Binding("Code"), Width = 120 });
        expiryGrid.Columns.Add(new DataGridTextColumn { Header = "Article", Binding = new System.Windows.Data.Binding("Article"), Width = new DataGridLength(1, DataGridLengthUnitType.Star) });
        expiryGrid.Columns.Add(new DataGridTextColumn { Header = "Lot", Binding = new System.Windows.Data.Binding("LotNumber"), Width = 100 });
        expiryGrid.Columns.Add(new DataGridTextColumn { Header = "Péremption", Binding = new System.Windows.Data.Binding("ExpiryDate") { StringFormat = "yyyy-MM-dd" }, Width = 110 });
        expiryGrid.Columns.Add(new DataGridTextColumn { Header = "Qté", Binding = new System.Windows.Data.Binding("Quantity"), Width = 80 });

        var tabs = new TabControl { Margin = new Thickness(12) };
        tabs.Items.Add(new TabItem { Header = "Stock négatif / seuil", Content = stockGrid });
        tabs.Items.Add(new TabItem { Header = "Alertes péremption (30j)", Content = expiryGrid });
        Content = tabs;

        Loaded += (_, _) =>
        {
            stockGrid.ItemsSource = loadLowStock(0m);
            expiryGrid.ItemsSource = loadExpiring(DateTime.Today, DateTime.Today.AddDays(30));
        };
    }
}
