using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using Hanouty.ArchitectureBridge;

namespace Hanouty.Desktop.Wpf;

internal sealed class CashDrawerCountDialog : Window
{
    private readonly List<TextBox> counts = new();
    private readonly TextBlock result = new() { FontSize = 18, Margin = new Thickness(0, 12, 0, 0) };

    private readonly Button? closeDrawer;
    private decimal? countedTotal;
    private readonly CheckBox cashierOnly = new() { Content = "Clôturer mon poste caissier", Margin = new Thickness(0, 8, 0, 0) };

    public CashDrawerCountDialog(Func<decimal, bool, bool>? closeCashDrawer, Func<decimal, bool>? setOpeningCash)
    {
        Title = setOpeningCash is not null ? "Fond de caisse" : "Comptage et clôture de caisse";
        Width = 350;
        SizeToContent = SizeToContent.Height;
        WindowStartupLocation = WindowStartupLocation.CenterOwner;
        var panel = new StackPanel { Margin = new Thickness(20) };
        foreach (var denomination in CashDrawerCount.Denominations)
        {
            var label = denomination.ToString("0.##", CultureInfo.CurrentCulture) + " MAD";
            var row = new DockPanel { Margin = new Thickness(0, 0, 0, 4) };
            var count = new TextBox { Text = "0", MinWidth = 90, HorizontalContentAlignment = HorizontalAlignment.Right };
            DockPanel.SetDock(count, Dock.Right);
            System.Windows.Automation.AutomationProperties.SetName(count, label);
            row.Children.Add(count);
            row.Children.Add(new TextBlock { Text = label, VerticalAlignment = VerticalAlignment.Center });
            counts.Add(count);
            count.TextChanged += (_, _) => RefreshTotal();
            panel.Children.Add(row);
        }
        panel.Children.Add(result);
        if (setOpeningCash is not null)
        {
            var opening = new Button { Content = "Enregistrer le montant compté comme fond de caisse",
                MinHeight = 36, Margin = new Thickness(0, 8, 0, 0) };
            opening.Click += (_, _) =>
            {
                if (countedTotal is decimal counted && setOpeningCash(counted)) Close();
            };
            panel.Children.Add(opening);
        }
        if (closeCashDrawer is not null)
        {
            panel.Children.Add(cashierOnly);
            closeDrawer = new Button { Content = "Préparer la clôture", MinHeight = 36, Margin = new Thickness(0, 12, 0, 0) };
            closeDrawer.Click += (_, _) =>
            {
                if (countedTotal is not decimal counted) return;
                closeDrawer.IsEnabled = false;
                if (closeCashDrawer(counted, cashierOnly.IsChecked == true)) Close();
                else RefreshTotal();
            };
            panel.Children.Add(closeDrawer);
        }
        var close = new Button { Content = "Fermer", IsCancel = true, MinHeight = 36, Margin = new Thickness(0, 12, 0, 0) };
        panel.Children.Add(close);
        Content = panel;
        RefreshTotal();
    }

    private void RefreshTotal()
    {
        countedTotal = null;
        if (closeDrawer is not null) closeDrawer.IsEnabled = false;
        var quantities = new int[counts.Count];
        for (var index = 0; index < counts.Count; index++)
        {
            var input = counts[index].Text.Trim();
            if (input.Length == 0) continue;
            if (!int.TryParse(input, NumberStyles.None, CultureInfo.CurrentCulture, out quantities[index]))
            {
                result.Text = "Saisir des quantités entières positives ou nulles.";
                return;
            }
        }
        countedTotal = CashDrawerCount.Calculate(quantities);
        result.Text = $"Total compté : {countedTotal:N2} MAD";
        if (closeDrawer is not null) closeDrawer.IsEnabled = true;
    }
}
