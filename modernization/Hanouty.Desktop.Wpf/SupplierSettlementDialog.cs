using System.Globalization;
using System.Windows;
using System.Windows.Controls;

namespace Hanouty.Desktop.Wpf;

public sealed record SupplierSettlementRequest(
    string OperationId, string SupplierId, decimal Amount, string PaymentMode, string Notes);

public sealed class SupplierSettlementDialog : Window
{
    private readonly TextBox amount = new() { MinWidth = 180, IsReadOnly = true };
    private readonly ComboBox mode = new() { MinWidth = 180 };
    private readonly TextBox notes = new() { MinHeight = 60, AcceptsReturn = true };
    private readonly TextBlock feedback = new() { TextWrapping = TextWrapping.Wrap };
    private readonly Button save = new() { Content = "Enregistrer", MinHeight = 36 };
    private readonly string operationId = Guid.NewGuid().ToString("N");
    private bool posting;
    private bool committed;
    private SupplierSettlementRequest? submittedRequest;

    public SupplierSettlementDialog(SupplierSettlementRow customer, IReadOnlyList<string> paymentModes,
        Func<SupplierSettlementRequest, bool> submit)
    {
        ArgumentNullException.ThrowIfNull(customer);
        ArgumentNullException.ThrowIfNull(paymentModes);
        ArgumentNullException.ThrowIfNull(submit);
        Title = "Règlement fournisseur";
        Width = 440;
        MaxHeight = SystemParameters.WorkArea.Height;
        SizeToContent = SizeToContent.Height;
        WindowStartupLocation = WindowStartupLocation.CenterOwner;
        var panel = new StackPanel { Margin = new Thickness(20) };
        panel.Children.Add(new TextBlock { Text = customer.Supplier, FontSize = 18 });
        panel.Children.Add(new TextBlock { Text = "Reliquat affiché : " +
            customer.Balance.ToString("N2", CultureInfo.CurrentCulture) + " DH" });
        panel.Children.Add(new Label { Content = "Montant", Target = amount });
        panel.Children.Add(amount);
        // Same numeric key order and cash denominations as LOGICA's FormDialog_calc.
        var numeric = new System.Windows.Controls.Primitives.UniformGrid { Columns = 3 };
        foreach (var key in new[] { "7", "8", "9", "4", "5", "6", "1", "2", "3", ".", "0", "⌫" })
        {
            var button = new Button { Content = key, MinHeight = 40, Margin = new Thickness(2) };
            button.Click += (_, _) =>
            {
                if (submittedRequest is not null || posting) return;
                var separator = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
                var input = amount.Text;
                if (key == "⌫") { if (input.Length > 0) amount.Text = input[..^1]; return; }
                if (key == ".")
                {
                    if (!input.Contains(separator)) amount.Text = (input.Length == 0 ? "0" : input) + separator;
                    return;
                }
                var next = input == "0" ? key : input + key;
                var decimalAt = next.IndexOf(separator, StringComparison.Ordinal);
                if ((decimalAt < 0 || next.Length - decimalAt - separator.Length <= 2) &&
                    decimal.TryParse(next, NumberStyles.AllowDecimalPoint, CultureInfo.CurrentCulture, out _))
                    amount.Text = next;
            };
            numeric.Children.Add(button);
        }
        panel.Children.Add(numeric);
        var cash = new Grid();
        for (var column = 0; column < 4; column++)
            cash.ColumnDefinitions.Add(new ColumnDefinition());
        for (var row = 0; row < 3; row++)
            cash.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
        foreach (var (denomination, row, column) in new[]
        {
            (200m, 0, 0), (100m, 0, 1), (10m, 0, 2), (5m, 0, 3),
            (50m, 1, 0), (20m, 1, 1), (2m, 1, 2), (1m, 1, 3), (0.5m, 2, 2)
        })
        {
            var label = denomination.ToString("0.##", CultureInfo.CurrentCulture) + " DH";
            var button = new Button { Content = label, MinHeight = 40, Margin = new Thickness(2) };
            System.Windows.Automation.AutomationProperties.SetName(button, label);
            Grid.SetRow(button, row);
            Grid.SetColumn(button, column);
            if (denomination == 0.5m) Grid.SetColumnSpan(button, 2);
            else
            {
                var extension = denomination >= 20m ? "jpg" : "png";
                var uri = new Uri($"/Hanouty.Desktop.Wpf;component/Assets/Cash/{denomination.ToString("0", CultureInfo.InvariantCulture)}.{extension}", UriKind.Relative);
                var tile = new StackPanel();
                tile.Children.Add(new Image {
                    Source = new System.Windows.Media.Imaging.BitmapImage(uri),
                    Height = 30, Stretch = System.Windows.Media.Stretch.Uniform });
                tile.Children.Add(new TextBlock { Text = label, HorizontalAlignment = HorizontalAlignment.Center });
                button.Content = tile;
            }
            button.Click += (_, _) =>
            {
                if (submittedRequest is not null || posting) return;
                decimal.TryParse(amount.Text, NumberStyles.AllowDecimalPoint, CultureInfo.CurrentCulture, out var current);
                if (current <= decimal.MaxValue - denomination)
                    amount.Text = (current + denomination).ToString("0.##", CultureInfo.CurrentCulture);
            };
            cash.Children.Add(button);
        }
        panel.Children.Add(cash);
        panel.Children.Add(new Label { Content = "Mode de paiement", Target = mode });
        mode.ItemsSource = paymentModes;
        panel.Children.Add(mode);
        panel.Children.Add(new Label { Content = "Notes", Target = notes });
        panel.Children.Add(notes);
        panel.Children.Add(feedback);
        panel.Children.Add(save);
        Content = new ScrollViewer { Content = panel, VerticalScrollBarVisibility = ScrollBarVisibility.Auto };
        save.Click += (_, _) =>
        {
            if (posting || committed) return;
            if (submittedRequest is null)
            {
                if (!decimal.TryParse(amount.Text, NumberStyles.Number, CultureInfo.CurrentCulture, out var value) || value <= 0 || decimal.Round(value, 2) != value)
                {
                    feedback.Text = "Veuillez remplir le champ -MONTANT- ";
                    return;
                }
                if (mode.SelectedItem is not string paymentMode || string.IsNullOrWhiteSpace(paymentMode))
                {
                    feedback.Text = "Veuillez remplir le champ -MODE_P- ";
                    return;
                }
                submittedRequest = new SupplierSettlementRequest(operationId, customer.SupplierId,
                    value, paymentMode, notes.Text);
            }
            posting = true;
            save.IsEnabled = false;
            try
            {
                amount.IsReadOnly = true;
                mode.IsEnabled = false;
                notes.IsReadOnly = true;
                committed = submit(submittedRequest);
                if (committed) { DialogResult = true; }
                else { feedback.Text = "Le règlement reste à confirmer. Réessayez avec la même opération."; }
            }
            catch (Exception)
            {
                feedback.Text = "Impossible de confirmer le règlement. Actualisez son état avant de réessayer.";
            }
            finally
            {
                posting = false;
                save.IsEnabled = !committed;
            }
        };
    }
}
