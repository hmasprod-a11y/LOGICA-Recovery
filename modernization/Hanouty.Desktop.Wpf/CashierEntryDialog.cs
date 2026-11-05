using System;
using System.Windows;
using System.Windows.Controls;
using Hanouty.Desktop.Wpf.Presentation;

namespace Hanouty.Desktop.Wpf;

// Presentation only: caller must authorize cashier/register and resolve trusted
// basket amount through the existing Host before using any returned draft.
public sealed class CashierEntryDialog : Window
{
    private readonly TextBox _cashier = new() { MaxLength = 64, MinWidth = 240 };
    private readonly TextBox _register = new() { MaxLength = 64 };
    private readonly TextBox _tender = new() { MaxLength = 32, Text = "0.00" };
    private readonly TextBlock _error = new() { TextWrapping = TextWrapping.Wrap };

    public (string Cashier, string Register, decimal CashMad)? Draft { get; private set; }

    public CashierEntryDialog()
    {
        Title = "Cashier session and cash tender";
        Width = 420;
        SizeToContent = SizeToContent.Height;
        WindowStartupLocation = WindowStartupLocation.CenterOwner;
        ResizeMode = ResizeMode.NoResize;
        ShowInTaskbar = false;
        var panel = new StackPanel { Margin = new Thickness(20) };
        AddField(panel, "Cashier identity", _cashier);
        AddField(panel, "Register identity", _register);
        AddField(panel, "Cash MAD (decimal, no thousands separator)", _tender);
        panel.Children.Add(_error);
        var actions = new StackPanel { Orientation = Orientation.Horizontal, Margin = new Thickness(0, 12, 0, 0) };
        var confirm = new Button { Content = "Review cash tender", MinHeight = 40, MinWidth = 160, IsDefault = true };
        var cancel = new Button { Content = "Cancel", MinHeight = 40, MinWidth = 90, IsCancel = true, Margin = new Thickness(8, 0, 0, 0) };
        confirm.Click += (_, _) => TryConfirm();
        actions.Children.Add(confirm);
        actions.Children.Add(cancel);
        panel.Children.Add(actions);
        Content = panel;
        Loaded += (_, _) => _cashier.Focus();
    }

    private static void AddField(Panel panel, string label, TextBox field)
    {
        panel.Children.Add(new TextBlock { Text = label, Margin = new Thickness(0, 8, 0, 4) });
        AutomationProperties.SetName(field, label);
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
