using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using Hanouty.Desktop.Wpf.Presentation;

namespace Hanouty.Desktop.Wpf;

public sealed record ManualDiscountChoice(string? ArticleId, bool Percentage, decimal Value);
public sealed record ManualDiscountPreviewData(decimal Percentage, decimal NetTotal, decimal Savings);
public interface IManualDiscountReview : IDisposable
{
    ManualDiscountPreviewData Preview(ManualDiscountChoice choice);
    bool Apply(ManualDiscountChoice choice);
}

public sealed class ManualDiscountDialog : Window
{
    public ManualDiscountChoice? Choice { get; private set; }

    public ManualDiscountDialog(IReadOnlyList<BasketDisplayLine> basket, string? selectedId,
        Func<ManualDiscountChoice, ManualDiscountPreviewData> preview)
    {
        Title = "Remise"; Width = 460; SizeToContent = SizeToContent.Height;
        WindowStartupLocation = WindowStartupLocation.CenterOwner;
        ResizeMode = ResizeMode.NoResize; ShowInTaskbar = false;
        var panel = new StackPanel { Margin = new Thickness(20) };
        panel.Children.Add(new TextBlock { Text = "Remplacer la remise actuelle", FontSize = 22, FontWeight = FontWeights.SemiBold });
        var global = new RadioButton { Content = "Tout le ticket", GroupName = "DiscountScope", IsChecked = true, MinHeight = 38 };
        var selectedLine = basket.SingleOrDefault(line => line.ArticleId == selectedId);
        var article = new RadioButton { Content = new TextBlock {
                Text = selectedLine is null ? "Article sélectionné" : selectedLine.ArticleName,
                TextWrapping = TextWrapping.Wrap, MaxWidth = 375 },
            GroupName = "DiscountScope", IsEnabled = selectedLine is not null, MinHeight = 38 };
        System.Windows.Automation.AutomationProperties.SetName(article, "Remise sur l’article sélectionné");
        panel.Children.Add(global); panel.Children.Add(article);
        var percentage = new RadioButton { Content = "Pourcentage (%)", GroupName = "DiscountUnit", IsChecked = true, MinHeight = 38 };
        var money = new RadioButton { Content = "Montant (DH)", GroupName = "DiscountUnit", MinHeight = 38 };
        var units = new System.Windows.Controls.Primitives.UniformGrid { Columns = 2 };
        units.Children.Add(percentage); units.Children.Add(money); panel.Children.Add(units);
        var amount = new TextBox { MinHeight = 46, FontSize = 24, Margin = new Thickness(0, 6, 0, 10) };
        System.Windows.Automation.AutomationProperties.SetName(amount, "Valeur de la remise");
        TouchNumericEntry.Attach(amount, "Valeur de la remise", allowZero: true);
        panel.Children.Add(amount);
        var rate = new TextBlock { TextWrapping = TextWrapping.Wrap };
        var savings = new TextBlock { TextWrapping = TextWrapping.Wrap };
        var net = new TextBlock { TextWrapping = TextWrapping.Wrap, FontSize = 22, FontWeight = FontWeights.SemiBold,
            Margin = new Thickness(0, 5, 0, 8) };
        var status = new TextBlock { Text = "Touchez le champ pour saisir la remise.", TextWrapping = TextWrapping.Wrap };
        panel.Children.Add(rate); panel.Children.Add(savings); panel.Children.Add(net); panel.Children.Add(status);
        var apply = new Button { Content = "Appliquer la remise", IsDefault = true, MinHeight = 44,
            IsEnabled = false, Margin = new Thickness(0, 10, 0, 0) };
        var reset = new Button { Content = "Remettre tout le ticket à 0 %", MinHeight = 44, Margin = new Thickness(0, 6, 0, 0) };
        var cancel = new Button { Content = "Annuler", IsCancel = true, MinHeight = 44, Margin = new Thickness(0, 6, 0, 0) };
        panel.Children.Add(apply); panel.Children.Add(reset); panel.Children.Add(cancel);
        ManualDiscountChoice? lastShownChoice = null;
        ManualDiscountPreviewData? lastShownQuote = null;
        ManualDiscountChoice? ReadChoice()
        {
            if (!decimal.TryParse(amount.Text, NumberStyles.AllowDecimalPoint, CultureInfo.CurrentCulture, out var value) ||
                value < 0m || (percentage.IsChecked == true && value > 100m))
                return null;
            return new ManualDiscountChoice(article.IsChecked == true ? selectedId : null,
                percentage.IsChecked == true, value);
        }
        void Refresh()
        {
            apply.IsEnabled = false; rate.Text = ""; savings.Text = ""; net.Text = "";
            if (ReadChoice() is not { } choice)
            {
                status.Text = "Saisissez une valeur valide ; le pourcentage est compris entre 0 et 100.";
                return;
            }
            try
            {
                var quote = preview(choice);
                lastShownChoice = choice;
                lastShownQuote = quote;
                rate.Text = $"Taux retenu : {quote.Percentage:0.##} %";
                savings.Text = $"Remise totale du ticket : {quote.Savings:N2} MAD";
                net.Text = $"À encaisser : {quote.NetTotal:N2} MAD";
                status.Text = "La remise remplace le taux des lignes choisies.";
                apply.IsEnabled = true;
            }
            catch (Exception ex) when (ex is not OutOfMemoryException and not StackOverflowException)
            {
                status.Text = ex is ArgumentException or InvalidOperationException or UnauthorizedAccessException
                    ? ex.Message : "Le calcul de la remise est indisponible.";
            }
        }
        amount.TextChanged += (_, _) => Refresh();
        global.Checked += (_, _) => Refresh(); article.Checked += (_, _) => Refresh();
        percentage.Checked += (_, _) => Refresh(); money.Checked += (_, _) => Refresh();
        apply.Click += (_, _) =>
        {
            var shownChoice = lastShownChoice;
            var shownQuote = lastShownQuote;
            Refresh();
            if (apply.IsEnabled && ReadChoice() is { } choice)
            {
                if (shownQuote is not null && shownChoice == choice && shownQuote != lastShownQuote)
                {
                    status.Text = "Le montant a changé. Vérifiez le nouveau net et confirmez à nouveau.";
                    return;
                }
                Choice = choice; DialogResult = true;
            }
        };
        reset.Click += (_, _) =>
        {
            global.IsChecked = true; percentage.IsChecked = true; amount.Text = "0";
            apply.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
        };
        MaxHeight = SystemParameters.WorkArea.Height;
        Content = new ScrollViewer { Content = panel, VerticalScrollBarVisibility = ScrollBarVisibility.Auto };
    }
}
