using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace Hanouty.Desktop.Wpf;

public sealed record SalesStatisticsViewData(decimal TotalSalesNet, decimal TotalCost, decimal GrossMargin, int TicketCount, IReadOnlyList<TopArticleViewRow> TopArticles);

public sealed record TopArticleViewRow(string Code, string Article, decimal Quantity, decimal NetTotal);

public sealed class SalesStatisticsDialog : Window
{
    public SalesStatisticsDialog(Func<DateTime, DateTime, SalesStatisticsViewData> loadStats)
    {
        ArgumentNullException.ThrowIfNull(loadStats);
        Title = "Statistiques et marges (LOGICA)";
        Width = 680;
        Height = 500;
        WindowStartupLocation = WindowStartupLocation.CenterOwner;

        var fromPicker = new DatePicker { SelectedDate = DateTime.Today.AddDays(-30), Margin = new Thickness(0, 0, 8, 0) };
        var toPicker = new DatePicker { SelectedDate = DateTime.Today, Margin = new Thickness(0, 0, 8, 0) };
        var summaryText = new TextBlock { FontSize = 15, FontWeight = FontWeights.SemiBold, Margin = new Thickness(0, 10, 0, 10) };
        var grid = new DataGrid { AutoGenerateColumns = false, IsReadOnly = true };
        grid.Columns.Add(new DataGridTextColumn { Header = "Code", Binding = new System.Windows.Data.Binding("Code"), Width = 130 });
        grid.Columns.Add(new DataGridTextColumn { Header = "Article", Binding = new System.Windows.Data.Binding("Article"), Width = new DataGridLength(1, DataGridLengthUnitType.Star) });
        grid.Columns.Add(new DataGridTextColumn { Header = "Qté", Binding = new System.Windows.Data.Binding("Quantity"), Width = 90 });
        grid.Columns.Add(new DataGridTextColumn { Header = "Total Net (MAD)", Binding = new System.Windows.Data.Binding("NetTotal"), Width = 130 });

        void Refresh()
        {
            var data = loadStats(fromPicker.SelectedDate ?? DateTime.Today, toPicker.SelectedDate ?? DateTime.Today);
            summaryText.Text = $"Tickets: {data.TicketCount}  |  CA Net: {data.TotalSalesNet:N2} MAD  |  Coût: {data.TotalCost:N2} MAD  |  Marge brute: {data.GrossMargin:N2} MAD";
            grid.ItemsSource = data.TopArticles;
        }

        var refreshBtn = new Button { Content = "Actualiser", Padding = new Thickness(12, 4, 12, 4) };
        refreshBtn.Click += (_, _) => Refresh();

        var bar = new StackPanel { Orientation = Orientation.Horizontal, Margin = new Thickness(0, 0, 0, 8) };
        bar.Children.Add(new Label { Content = "Du:" });
        bar.Children.Add(fromPicker);
        bar.Children.Add(new Label { Content = "Au:" });
        bar.Children.Add(toPicker);
        bar.Children.Add(refreshBtn);

        var root = new DockPanel { Margin = new Thickness(16) };
        DockPanel.SetDock(bar, Dock.Top);
        DockPanel.SetDock(summaryText, Dock.Top);
        root.Children.Add(bar);
        root.Children.Add(summaryText);
        root.Children.Add(grid);
        Content = root;

        Loaded += (_, _) => Refresh();
    }
}
