using System.Globalization;
using System.Windows;
using System.Windows.Controls;

namespace Hanouty.Desktop.Wpf;

public sealed class CardPaymentDialog : Window
{
    public CardPaymentDialog(decimal total)
    {
        if (total <= 0 || decimal.Round(total, 2) != total) throw new ArgumentOutOfRangeException(nameof(total));
        Title = "Paiement CARTE";
        Width = 420;
        SizeToContent = SizeToContent.Height;
        ResizeMode = ResizeMode.NoResize;
        WindowStartupLocation = WindowStartupLocation.CenterOwner;
        var panel = new StackPanel { Margin = new Thickness(20) };
        panel.Children.Add(new TextBlock { Text = "Montant réglé par carte", FontSize = 18 });
        panel.Children.Add(new TextBlock { Text = total.ToString("N2", CultureInfo.CurrentCulture) + " DH",
            FontSize = 30, FontWeight = FontWeights.Bold, Margin = new Thickness(0, 12, 0, 12) });
        panel.Children.Add(new TextBlock { Text = "Confirmez le règlement déjà effectué.", TextWrapping = TextWrapping.Wrap });
        var confirm = new Button { Content = "Confirmer le paiement CARTE", MinHeight = 48, IsDefault = true,
            Margin = new Thickness(0, 14, 0, 4) };
        confirm.Click += (_, _) => DialogResult = true;
        panel.Children.Add(confirm);
        panel.Children.Add(new Button { Content = "Annuler", MinHeight = 40, IsCancel = true });
        Content = panel;
    }
}
