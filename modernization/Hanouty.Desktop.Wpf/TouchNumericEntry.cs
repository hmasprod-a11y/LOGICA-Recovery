using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;

namespace Hanouty.Desktop.Wpf;

public sealed class TouchNumericEntryDialog : Window
{
    public decimal? Value { get; private set; }

    public TouchNumericEntryDialog(string title, decimal initial, bool allowZero = false, int decimalPlaces = 2, bool allowNegative = false)
    {
        if (decimalPlaces is < 0 or > 4) throw new ArgumentOutOfRangeException(nameof(decimalPlaces));
        Title = title;
        Width = 360;
        SizeToContent = SizeToContent.Height;
        ResizeMode = ResizeMode.NoResize;
        WindowStartupLocation = WindowStartupLocation.CenterOwner;
        var culture = CultureInfo.CurrentCulture;
        var separator = culture.NumberFormat.NumberDecimalSeparator;
        var negative = culture.NumberFormat.NegativeSign;
        var styles = NumberStyles.AllowDecimalPoint | (allowNegative ? NumberStyles.AllowLeadingSign : NumberStyles.None);
        var numericFormat = decimalPlaces == 0 ? "0" : "0." + new string('#', decimalPlaces);
        var amount = new TextBox { Text = initial.ToString(numericFormat, culture), IsReadOnly = true,
            FontSize = 26, MinHeight = 44, Margin = new Thickness(0, 0, 0, 8) };
        var feedback = new TextBlock { TextWrapping = TextWrapping.Wrap };
        var panel = new StackPanel { Margin = new Thickness(16) };
        panel.Children.Add(amount);
        var keypad = new UniformGrid { Columns = 3 };
        var replace = true;
        // Same numeric key order as LOGICA FormDialog_calc / the cash-entry keypad.
        foreach (var key in new[] { "7", "8", "9", "4", "5", "6", "1", "2", "3", decimalPlaces == 0 ? "" : separator, "0", "⌫" })
        {
            var button = new Button { Content = key, IsEnabled = key.Length > 0, MinHeight = 48, FontSize = 20, Margin = new Thickness(2) };
            button.Click += (_, _) =>
            {
                feedback.Text = "";
                var input = amount.Text;
                if (key == "⌫")
                {
                    amount.Text = input.Length == 0 ? "" : input[..^1];
                    replace = false;
                    return;
                }
                if (replace) input = "";
                if (key == separator)
                {
                    if (input.Contains(separator)) return;
                    amount.Text = input.Length == 0 ? "0" + separator : input == negative ? negative + "0" + separator : input + separator;
                    replace = false;
                    return;
                }
                var next = input == "0" ? key : input == negative + "0" ? negative + key : input + key;
                var point = next.IndexOf(separator, StringComparison.Ordinal);
                if ((point < 0 || next.Length - point - separator.Length <= decimalPlaces) &&
                    decimal.TryParse(next, styles, culture, out _))
                {
                    amount.Text = next;
                    replace = false;
                }
            };
            keypad.Children.Add(button);
        }
        panel.Children.Add(keypad);
        var actions = new UniformGrid { Columns = allowNegative ? 4 : 3 };
        if (allowNegative)
        {
            var sign = new Button { Content = "±", MinHeight = 44 };
            sign.Click += (_, _) =>
            {
                amount.Text = amount.Text.StartsWith(negative, StringComparison.Ordinal) ? amount.Text[negative.Length..]
                    : negative + (amount.Text.Length == 0 ? "0" : amount.Text);
                replace = false;
            };
            actions.Children.Add(sign);
        }
        var clear = new Button { Content = "Effacer", MinHeight = 44 };
        clear.Click += (_, _) => { amount.Text = ""; replace = true; feedback.Text = ""; };
        var apply = new Button { Content = "Appliquer", MinHeight = 44, IsDefault = true };
        apply.Click += (_, _) =>
        {
            if (!decimal.TryParse(amount.Text, styles, culture, out var value) ||
                (!allowNegative && value < 0) || (!allowZero && value == 0) || decimal.Round(value, decimalPlaces) != value)
            {
                feedback.Text = allowZero ? "Saisissez une valeur positive ou nulle." : "Saisissez une valeur positive.";
                return;
            }
            Value = value;
            DialogResult = true;
        };
        var cancel = new Button { Content = "Annuler", MinHeight = 44, IsCancel = true };
        actions.Children.Add(clear);
        actions.Children.Add(apply);
        actions.Children.Add(cancel);
        panel.Children.Add(feedback);
        panel.Children.Add(actions);
        Content = panel;
    }
}

public static class TouchNumericEntry
{
    public static void Attach(TextBox field, string title, bool allowZero = false, int decimalPlaces = 2, bool allowNegative = false)
    {
        field.IsReadOnly = true;
        var opening = false;
        void Open()
        {
            if (opening || !field.IsEnabled) return;
            opening = true;
            try
            {
                decimal.TryParse(field.Text, NumberStyles.Number, CultureInfo.CurrentCulture, out var initial);
                var dialog = new TouchNumericEntryDialog(title, initial, allowZero, decimalPlaces, allowNegative) { Owner = Window.GetWindow(field) };
                if (dialog.ShowDialog() == true && dialog.Value is decimal value)
                    field.Text = value.ToString(decimalPlaces == 0 ? "0" : "0." + new string('#', decimalPlaces), CultureInfo.CurrentCulture);
            }
            finally { opening = false; }
        }
        field.PreviewMouseLeftButtonDown += (_, e) => { e.Handled = true; Open(); };
        field.PreviewKeyDown += (_, e) =>
        {
            if (e.Key is Key.Enter or Key.Space) { e.Handled = true; Open(); }
        };
    }
}
