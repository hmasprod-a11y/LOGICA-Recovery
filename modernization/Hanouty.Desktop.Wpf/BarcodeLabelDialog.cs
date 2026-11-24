using System;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Hanouty.Desktop.Wpf;

public sealed class BarcodeLabelDialog : Window
{
    public BarcodeLabelDialog(string initialCode = "", string initialArticle = "", decimal initialPrice = 0m)
    {
        Title = "Impression d'étiquettes code-barres";
        Width = 420;
        SizeToContent = SizeToContent.Height;
        WindowStartupLocation = WindowStartupLocation.CenterOwner;

        var codeBox = new TextBox { Text = initialCode, Margin = new Thickness(0, 0, 0, 6) };
        var nameBox = new TextBox { Text = initialArticle, Margin = new Thickness(0, 0, 0, 6) };
        var priceBox = new TextBox { Text = initialPrice.ToString("0.00", CultureInfo.CurrentCulture), Margin = new Thickness(0, 0, 0, 8) };
        var copiesBox = new TextBox { Text = "1", Margin = new Thickness(0, 0, 0, 8) };
        var feedback = new TextBlock { TextWrapping = TextWrapping.Wrap, Margin = new Thickness(0, 6, 0, 0) };

        var previewBorder = new Border
        {
            BorderBrush = Brushes.Black,
            BorderThickness = new Thickness(1),
            Padding = new Thickness(10),
            Background = Brushes.White,
            Margin = new Thickness(0, 4, 0, 10)
        };
        var previewStack = new StackPanel { HorizontalAlignment = HorizontalAlignment.Center };
        var pName = new TextBlock { FontWeight = FontWeights.Bold, FontSize = 14, HorizontalAlignment = HorizontalAlignment.Center };
        var pCode = new TextBlock { FontFamily = new FontFamily("Consolas"), FontSize = 13, HorizontalAlignment = HorizontalAlignment.Center, Margin = new Thickness(0, 4, 0, 4) };
        var pPrice = new TextBlock { FontWeight = FontWeights.Bold, FontSize = 18, HorizontalAlignment = HorizontalAlignment.Center };
        previewStack.Children.Add(pName);
        previewStack.Children.Add(pCode);
        previewStack.Children.Add(pPrice);
        previewBorder.Child = previewStack;

        void UpdatePreview()
        {
            pName.Text = string.IsNullOrWhiteSpace(nameBox.Text) ? "ARTICLE" : nameBox.Text.Trim();
            pCode.Text = $"*{codeBox.Text.Trim()}*";
            pPrice.Text = decimal.TryParse(priceBox.Text, NumberStyles.Number, CultureInfo.CurrentCulture, out var pr)
                ? $"{pr:N2} MAD"
                : "0.00 MAD";
        }

        codeBox.TextChanged += (_, _) => UpdatePreview();
        nameBox.TextChanged += (_, _) => UpdatePreview();
        priceBox.TextChanged += (_, _) => UpdatePreview();
        UpdatePreview();

        var printBtn = new Button { Content = "Imprimer l'étiquette", MinHeight = 36 };
        printBtn.Click += (_, _) =>
        {
            if (string.IsNullOrWhiteSpace(codeBox.Text))
            {
                feedback.Text = "Saisissez un code-barres.";
                return;
            }
            if (!int.TryParse(copiesBox.Text, out var copies) || copies < 1 || copies > 200)
            {
                feedback.Text = "Nombre d'étiquettes invalide (1–200).";
                return;
            }
            try
            {
                var dlg = new PrintDialog();
                if (dlg.ShowDialog() != true) return;
                for (var i = 0; i < copies; i++)
                    dlg.PrintVisual(previewBorder, $"Étiquette {codeBox.Text.Trim()}");
                feedback.Text = $"{copies} étiquette(s) envoyée(s) à l'imprimante.";
            }
            catch (Exception ex) when (ex is not OutOfMemoryException and not StackOverflowException)
            {
                feedback.Text = "Erreur d'impression : " + ex.Message;
            }
        };

        var root = new StackPanel { Margin = new Thickness(18) };
        root.Children.Add(new Label { Content = "Code-barres" }); root.Children.Add(codeBox);
        root.Children.Add(new Label { Content = "Désignation" }); root.Children.Add(nameBox);
        root.Children.Add(new Label { Content = "Prix (MAD)" }); root.Children.Add(priceBox);
        root.Children.Add(new Label { Content = "Nombre d'étiquettes" }); root.Children.Add(copiesBox);
        root.Children.Add(previewBorder);
        root.Children.Add(printBtn);
        root.Children.Add(feedback);
        Content = root;
    }
}
