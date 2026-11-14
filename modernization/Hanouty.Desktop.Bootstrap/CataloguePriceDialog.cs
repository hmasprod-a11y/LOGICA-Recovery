using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using MySql.Data.MySqlClient;

namespace Hanouty.Desktop.Bootstrap;

internal sealed class CataloguePriceDialog : Window
{
    internal CataloguePriceDialog(CataloguePriceEditor service, Func<CataloguePriceEditor.Price, decimal, bool> save)
    {
        Title = "Prix du catalogue";
        Width = 460;
        SizeToContent = SizeToContent.Height;
        WindowStartupLocation = WindowStartupLocation.CenterOwner;
        var panel = new StackPanel { Margin = new Thickness(20) };
        var id = new TextBox { MinHeight = 36 };
        var price = new TextBox { MinHeight = 36, IsEnabled = false };
        System.Windows.Automation.AutomationProperties.SetName(id, "Identifiant de l’article");
        System.Windows.Automation.AutomationProperties.SetName(price, "Nouveau prix de vente");
        var open = new Button { Content = "Lire le prix", MinHeight = 36, Margin = new Thickness(0, 6, 0, 8) };
        var write = new Button { Content = "Enregistrer le prix", MinHeight = 36, Margin = new Thickness(0, 6, 0, 0), IsEnabled = false };
        var status = new TextBlock { TextWrapping = TextWrapping.Wrap, Margin = new Thickness(0, 8, 0, 0) };
        panel.Children.Add(new TextBlock { Text = "Identifiant de l’article" });
        panel.Children.Add(id);
        panel.Children.Add(open);
        panel.Children.Add(new TextBlock { Text = "Prix de vente (MAD)" });
        panel.Children.Add(price);
        panel.Children.Add(write);
        panel.Children.Add(status);
        Content = panel;

        CataloguePriceEditor.Price? reviewed = null;
        void Reset(string message)
        {
            reviewed = null;
            price.IsEnabled = false;
            write.IsEnabled = false;
            status.Text = message;
        }
        id.TextChanged += (_, _) => Reset("");
        open.Click += (_, _) =>
        {
            Reset("");
            try
            {
                reviewed = service.Read(id.Text.Trim());
                price.Text = reviewed.Amount.ToString("0.00", CultureInfo.CurrentCulture);
                status.Text = reviewed.Name;
                price.IsEnabled = true;
                write.IsEnabled = true;
            }
            catch (Exception ex) when (ex is ArgumentException or MySqlException or InvalidOperationException)
            {
                Reset("Article ou prix indisponible.");
            }
        };
        write.Click += (_, _) =>
        {
            if (reviewed is not { } snapshot ||
                !decimal.TryParse(price.Text.Trim().Replace(',', '.'), NumberStyles.AllowDecimalPoint,
                    CultureInfo.InvariantCulture, out var amount) ||
                amount < 0 || decimal.Round(amount, 2) != amount)
            {
                status.Text = "Saisissez un prix positif ou nul, à deux décimales.";
                return;
            }
            write.IsEnabled = false;
            try
            {
                if (save(snapshot, amount))
                    Reset($"Prix de {snapshot.Name} enregistré : {amount:N2} MAD.");
                else write.IsEnabled = true;
            }
            catch (UnauthorizedAccessException)
            {
                Reset("Modification réservée à un administrateur authentifié.");
            }
            catch (Exception ex) when (ex is MySqlException or InvalidOperationException)
            {
                Reset("Modification non confirmée. Relisez le prix avant de réessayer.");
            }
        };
    }
}
