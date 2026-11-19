using System.Globalization;
using System.Windows;
using System.Windows.Controls;

namespace Hanouty.Desktop.Wpf;

public sealed class MixedPaymentDialog : Window
{
    public (decimal Cash, decimal Card)? Draft { get; private set; }

    public MixedPaymentDialog(decimal total)
    {
        if (total <= 0 || decimal.Round(total, 2) != total) throw new ArgumentOutOfRangeException(nameof(total));
        Title = "Paiement mixte";
        Width = 490;
        SizeToContent = SizeToContent.Height;
        MaxHeight = SystemParameters.WorkArea.Height;
        WindowStartupLocation = WindowStartupLocation.CenterOwner;
        var panel = new StackPanel { Margin = new Thickness(18) };
        panel.Children.Add(new TextBlock { Text = "TOTAL : " + total.ToString("N2") + " DH",
            FontSize = 26, FontWeight = FontWeights.Bold });
        var card = new TextBox { Text = "0", MinHeight = 40, FontSize = 22 };
        var cash = new TextBox { Text = "0", MinHeight = 40, FontSize = 22 };
        System.Windows.Automation.AutomationProperties.SetName(card, "Montant CARTE");
        System.Windows.Automation.AutomationProperties.SetName(cash, "Espèces reçues");
        TouchNumericEntry.Attach(card, "Montant réglé par CARTE");
        TouchNumericEntry.Attach(cash, "Espèces reçues");
        panel.Children.Add(new Label { Content = "Montant réglé par CARTE", Target = card });
        panel.Children.Add(card);
        panel.Children.Add(new Label { Content = "Espèces reçues", Target = cash });
        panel.Children.Add(cash);
        var cashTiles = new Grid();
        for (var column = 0; column < 4; column++) cashTiles.ColumnDefinitions.Add(new ColumnDefinition());
        for (var row = 0; row < 3; row++) cashTiles.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
        foreach (var (denomination, row, column) in new[] {
            (200m,0,0),(100m,0,1),(10m,0,2),(5m,0,3),
            (50m,1,0),(20m,1,1),(2m,1,2),(1m,1,3),(0.5m,2,2) })
        {
            var label = denomination.ToString("0.##", CultureInfo.CurrentCulture) + " DH";
            var button = new Button { Content = label, MinHeight = 44, Margin = new Thickness(2) };
            System.Windows.Automation.AutomationProperties.SetName(button, label);
            Grid.SetRow(button, row); Grid.SetColumn(button, column);
            if (denomination == 0.5m) Grid.SetColumnSpan(button, 2);
            else
            {
                var extension = denomination >= 20m ? "jpg" : "png";
                var uri = new Uri($"/Hanouty.Desktop.Wpf;component/Assets/Cash/{denomination.ToString("0", CultureInfo.InvariantCulture)}.{extension}", UriKind.Relative);
                var tile = new StackPanel();
                tile.Children.Add(new Image { Source = new System.Windows.Media.Imaging.BitmapImage(uri),
                    Height = 30, Stretch = System.Windows.Media.Stretch.Uniform });
                tile.Children.Add(new TextBlock { Text = label, HorizontalAlignment = HorizontalAlignment.Center });
                button.Content = tile;
            }
            button.Click += (_, _) =>
            {
                decimal.TryParse(cash.Text, NumberStyles.AllowDecimalPoint, CultureInfo.CurrentCulture, out var received);
                if (received <= decimal.MaxValue - denomination)
                    cash.Text = (received + denomination).ToString("0.##");
            };
            cashTiles.Children.Add(button);
        }
        panel.Children.Add(cashTiles);
        var remaining = new TextBlock { FontSize = 18, Margin = new Thickness(0, 8, 0, 0) };
        var feedback = new TextBlock { TextWrapping = TextWrapping.Wrap };
        panel.Children.Add(remaining);
        panel.Children.Add(feedback);
        bool Read(out decimal cardPaid, out decimal cashPaid)
        {
            var cardValid = decimal.TryParse(card.Text, NumberStyles.AllowDecimalPoint, CultureInfo.CurrentCulture, out cardPaid);
            var cashValid = decimal.TryParse(cash.Text, NumberStyles.AllowDecimalPoint, CultureInfo.CurrentCulture, out cashPaid);
            return cardValid && cashValid && cardPaid > 0m && cardPaid < total && cashPaid > 0m &&
                cashPaid <= decimal.MaxValue - cardPaid &&
                decimal.Round(cardPaid, 2) == cardPaid && decimal.Round(cashPaid, 2) == cashPaid;
        }
        void Refresh()
        {
            if (!Read(out var cardPaid, out var cashPaid)) { remaining.Text = ""; return; }
            var cashDue = total - cardPaid;
            remaining.Text = cashPaid >= cashDue ? "RENDU : " + (cashPaid - cashDue).ToString("N2") + " DH"
                : "RESTE : " + (cashDue - cashPaid).ToString("N2") + " DH";
        }
        card.TextChanged += (_, _) => Refresh();
        cash.TextChanged += (_, _) => Refresh();
        var confirm = new Button { Content = "Confirmer le paiement mixte", MinHeight = 48, IsDefault = true };
        confirm.Click += (_, _) =>
        {
            if (!Read(out var cardPaid, out var cashPaid) || cashPaid < total - cardPaid)
            {
                feedback.Text = "Saisissez la part CARTE et les espèces couvrant le reste.";
                return;
            }
            Draft = (cashPaid, cardPaid);
            DialogResult = true;
        };
        panel.Children.Add(confirm);
        panel.Children.Add(new Button { Content = "Annuler", MinHeight = 40, IsCancel = true });
        Content = new ScrollViewer { Content = panel, VerticalScrollBarVisibility = ScrollBarVisibility.Auto };
    }
}
