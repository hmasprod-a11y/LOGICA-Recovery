using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using Hanouty.ArchitectureBridge;

namespace Hanouty.Desktop.Wpf;
public sealed class PartialCashReturnDialog : Window
{
    public IReadOnlyList<CheckoutPartialReturnSelection>? Selections { get; private set; }
    public PartialCashReturnDialog(string ticketNumber, IReadOnlyList<CheckoutOriginalReturnLineSnapshot> lines,
        Func<CheckoutOriginalReturnLineSnapshot, bool> supported, Func<IReadOnlyList<CheckoutPartialReturnSelection>, decimal> quote)
    {
        Title = "Retour partiel espèces — " + ticketNumber; Width = 820; Height = 610; MinWidth = 620; MinHeight = 420;
        WindowStartupLocation = WindowStartupLocation.CenterOwner;
        var panel = new DockPanel { Margin = new Thickness(18) };
        var footer = new StackPanel(); DockPanel.SetDock(footer, Dock.Bottom); panel.Children.Add(footer);
        var amount = new TextBlock { FontSize = 25, FontWeight = FontWeights.Bold, Margin = new Thickness(0, 10, 0, 8) }; footer.Children.Add(amount);
        var review = new CheckBox { Content = "Je confirme les articles, les quantités et le remboursement espèces affiché.", Margin = new Thickness(0, 0, 0, 10) }; footer.Children.Add(review);
        var status = new TextBlock { TextWrapping = TextWrapping.Wrap }; footer.Children.Add(status);
        var save = new Button { Content = "Confirmer le retour partiel", IsDefault = true, MinHeight = 46, Margin = new Thickness(0, 8, 0, 0) }; footer.Children.Add(save);
        var cancel = new Button { Content = "Annuler", IsCancel = true, MinHeight = 38, Margin = new Thickness(0, 5, 0, 0) }; footer.Children.Add(cancel);
        var heading = new TextBlock { Text = "Ticket " + ticketNumber + "\nChoisissez uniquement les quantités à reprendre.", FontSize = 22, FontWeight = FontWeights.SemiBold, Margin = new Thickness(0, 0, 0, 12) };
        DockPanel.SetDock(heading, Dock.Top); panel.Children.Add(heading);
        var rows = new StackPanel(); panel.Children.Add(new ScrollViewer { Content = rows, VerticalScrollBarVisibility = ScrollBarVisibility.Auto });
        var inputs = new List<(CheckoutOriginalReturnLineSnapshot Line, TextBox Quantity)>();
        IReadOnlyList<CheckoutPartialReturnSelection> Read()
        {
            var selected = new List<CheckoutPartialReturnSelection>();
            foreach (var (line, field) in inputs)
            {
                if (!int.TryParse(field.Text, NumberStyles.None, CultureInfo.CurrentCulture, out var quantity) || quantity < 0 || quantity > line.OriginalQuantity - line.ReturnedQuantity)
                    throw new InvalidOperationException("Quantité supérieure au solde original ou invalide.");
                if (quantity != 0) selected.Add(new CheckoutPartialReturnSelection(line, quantity));
            }
            return selected.AsReadOnly();
        }
        decimal reviewedAmount = 0m;
        void Refresh()
        {
            review.IsChecked = false; save.IsEnabled = false; reviewedAmount = 0m;
            try
            {
                var selected = Read(); if (selected.Count == 0) { amount.Text = "À rembourser : 0,00 MAD"; return; }
                reviewedAmount = quote(selected); amount.Text = $"À rembourser : {reviewedAmount:N2} MAD"; status.Text = "Prix et remises du ticket original conservés.";
            }
            catch (Exception ex) { amount.Text = "Total à vérifier"; status.Text = ex.Message; }
        }
        foreach (var line in lines)
        {
            var grid = new Grid { Margin = new Thickness(0, 0, 0, 10) };
            grid.ColumnDefinitions.Add(new ColumnDefinition()); grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(140) });
            var enabled = supported(line) && line.OriginalQuantity > line.ReturnedQuantity;
            var label = new TextBlock { Text = $"{line.ArticleName}\nPrix original {line.OriginalUnitPrice:N2} MAD · remise {line.OriginalDiscountPercent:0.####}% · restant {line.OriginalQuantity - line.ReturnedQuantity:0.###}" +
                (enabled ? "" : "\nRetour complet uniquement pour cette ligne."), TextWrapping = TextWrapping.Wrap, VerticalAlignment = VerticalAlignment.Center };
            grid.Children.Add(label);
            var quantity = new TextBox { Text = "0", MinHeight = 44, FontSize = 22, IsEnabled = enabled, Margin = new Thickness(12, 0, 0, 0), VerticalContentAlignment = VerticalAlignment.Center };
            System.Windows.Automation.AutomationProperties.SetName(quantity, "Quantité retour " + line.ArticleId);
            TouchNumericEntry.Attach(quantity, "Quantité à reprendre", allowZero: true, decimalPlaces: 0);
            Grid.SetColumn(quantity, 1); grid.Children.Add(quantity); rows.Children.Add(grid); inputs.Add((line, quantity));
            quantity.TextChanged += (_, _) => Refresh();
        }
        review.Checked += (_, _) => save.IsEnabled = reviewedAmount > 0;
        review.Unchecked += (_, _) => save.IsEnabled = false;
        save.Click += (_, _) =>
        {
            try
            {
                var selected = Read(); var fresh = quote(selected);
                if (review.IsChecked != true || fresh <= 0 || fresh != reviewedAmount) { Refresh(); return; }
                Selections = selected; DialogResult = true;
            }
            catch (Exception ex) { review.IsChecked = false; save.IsEnabled = false; status.Text = ex.Message; }
        };
        Content = panel; Refresh();
    }
}
