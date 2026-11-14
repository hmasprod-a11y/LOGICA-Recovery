using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Globalization;
using Hanouty.ArchitectureBridge;
using Hanouty.Desktop.Wpf.Presentation;

namespace Hanouty.Desktop.Wpf;

// Presentation only: caller must authorize cashier/register and resolve trusted
// basket amount through the existing Host before using any returned draft.
public sealed class CashierEntryDialog : Window
{
    private readonly TextBox _cashier = new() { MaxLength = 64, MinWidth = 240 };
    private readonly TextBox _register = new() { MaxLength = 64 };
    private readonly TextBox _tender = new() { MaxLength = 32, Text = "" };
    private readonly TextBlock _error = new() { TextWrapping = TextWrapping.Wrap };

    public (string Cashier, string Register, decimal CashMad)? Draft { get; private set; }

    // The displayed amount is supplied by Application; this dialog never calculates totals.
    // Fresh tender is required on every dialog invocation, including a second operation.
    public CashierEntryDialog(decimal? authoritativeTotalMad = null, CashierPaymentContext? context = null)
    {
        Title = context is null ? "Cashier session and cash tender" : "Paiement en espèces";
        if (context is not null)
        {
            _cashier.Text = context.CashierId;
            _register.Text = context.RegisterId;
            _cashier.IsReadOnly = true;
            _register.IsReadOnly = true;
            _tender.IsReadOnly = true;
        }
        Width = 420;
        SizeToContent = SizeToContent.Height;
        WindowStartupLocation = WindowStartupLocation.CenterOwner;
        ResizeMode = ResizeMode.NoResize;
        ShowInTaskbar = false;
        var panel = new StackPanel { Margin = new Thickness(20) };
        if (authoritativeTotalMad is decimal total)
            panel.Children.Add(new TextBlock {
                Text = $"Application total (MAD): {total.ToString("F2", System.Globalization.CultureInfo.InvariantCulture)}",
                FontWeight = FontWeights.SemiBold, TextWrapping = TextWrapping.Wrap
            });
        AddField(panel, "Cashier identity", _cashier);
        AddField(panel, "Register identity", _register);
        AddField(panel, "Cash MAD (decimal, no thousands separator)", _tender);
        if (context is not null && authoritativeTotalMad is decimal paymentTotal)
        {
            var change = new TextBlock { FontWeight = FontWeights.SemiBold, Margin = new Thickness(0, 8, 0, 0) };
            panel.Children.Add(change);
            _tender.TextChanged += (_, _) =>
            {
                if (!CashierEntryDraft.TryParse(_cashier.Text, _register.Text, _tender.Text,
                    out _, out _, out var received))
                {
                    change.Text = "";
                    return;
                }

                change.Text = received >= paymentTotal
                    ? $"Monnaie à rendre : {received - paymentTotal:N2} MAD"
                    : $"Montant manquant : {paymentTotal - received:N2} MAD";
            };
        }
        if (context is not null)
        {
            panel.Children.Add(new TextBlock { Text = "Billets et pièces", Margin = new Thickness(0, 10, 0, 4) });
            var cash = new UniformGrid { Columns = 4 };
            foreach (var denomination in CashDrawerCount.Denominations)
            {
                var label = denomination.ToString("0.##", CultureInfo.InvariantCulture) + " MAD";
                AddTouchButton(cash, label, () => AddDenomination(denomination));
            }
            panel.Children.Add(cash);

            var keypad = new UniformGrid { Columns = 3, Margin = new Thickness(0, 8, 0, 0) };
            foreach (var key in new[] { "7", "8", "9", "4", "5", "6", "1", "2", "3", ".", "0", "⌫" })
                AddTouchButton(keypad, key, () => EnterDigit(key));
            AddTouchButton(keypad, "Effacer", () => _tender.Clear());
            panel.Children.Add(keypad);
        }
        panel.Children.Add(_error);
        var actions = new StackPanel { Orientation = Orientation.Horizontal, Margin = new Thickness(0, 12, 0, 0) };
        var confirm = new Button { Content = "Review cash tender", MinHeight = 40, MinWidth = 160, IsDefault = true };
        var cancel = new Button { Content = "Cancel", MinHeight = 40, MinWidth = 90, IsCancel = true, Margin = new Thickness(8, 0, 0, 0) };
        confirm.Click += (_, _) => TryConfirm();
        _tender.TextChanged += (_, _) => _error.Text = "";
        _cashier.TextChanged += (_, _) => _error.Text = "";
        _register.TextChanged += (_, _) => _error.Text = "";
        actions.Children.Add(confirm);
        actions.Children.Add(cancel);
        panel.Children.Add(actions);
        MaxHeight = SystemParameters.WorkArea.Height;
        Content = new ScrollViewer { Content = panel, VerticalScrollBarVisibility = ScrollBarVisibility.Auto };
        Loaded += (_, _) => (context is null ? _cashier : _tender).Focus();
    }

    private static void AddTouchButton(Panel panel, string label, Action action)
    {
        var button = new Button { Content = label, MinHeight = 40, Margin = new Thickness(2), FontSize = 16 };
        button.Click += (_, _) => action();
        panel.Children.Add(button);
    }

    private void AddDenomination(decimal denomination)
    {
        var input = _tender.Text.TrimEnd('.');
        if (!decimal.TryParse(input, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out var current))
            current = 0m;
        if (current <= decimal.MaxValue - denomination)
            _tender.Text = (current + denomination).ToString("0.##", CultureInfo.InvariantCulture);
    }

    private void EnterDigit(string key)
    {
        var input = _tender.Text;
        if (key == "⌫")
        {
            if (input.Length > 0) _tender.Text = input[..^1];
            return;
        }

        if (key == ".")
        {
            if (!input.Contains('.')) _tender.Text = input.Length == 0 ? "0." : input + ".";
            return;
        }

        var next = input == "0" ? key : input + key;
        if (CashierEntryDraft.TryParse(_cashier.Text, _register.Text, next, out _, out _, out _))
            _tender.Text = next;
    }

    private static void AddField(Panel panel, string label, TextBox field)
    {
        panel.Children.Add(new TextBlock { Text = label, Margin = new Thickness(0, 8, 0, 4) });
        System.Windows.Automation.AutomationProperties.SetName(field, label);
        panel.Children.Add(field);
    }

    private void TryConfirm()
    {
        if (!CashierEntryDraft.TryParse(_cashier.Text, _register.Text, _tender.Text,
            out var cashier, out var register, out var tender))
        {
            _error.Text = "Enter cashier and register identities and a non-negative MAD amount with at most two decimal places.";
            return;
        }
        Draft = (cashier, register, tender);
        DialogResult = true;
    }
}
