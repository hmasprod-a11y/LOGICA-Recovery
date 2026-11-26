using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using Hanouty.Desktop.Wpf;

namespace Hanouty.Desktop.Bootstrap;

internal sealed class DailyStockAdjustmentDialog : Window
{
    internal DailyStockAdjustmentService.Result? Saved { get; private set; }
    internal DailyStockAdjustmentDialog(DailyStockAdjustmentService service, DailyStockAdjustmentService.Authorization authorization, DailyStockReader.Article selected, string dataDirectory)
    {
        var workflow = new DailyStockAdjustmentWorkflow(service, authorization, dataDirectory);
        try
        {
            var pending = workflow.Pending;
            var snapshot = pending?.Expected ?? service.Preview(authorization, selected);
            Title = "Modifier le stock"; Width = 570; SizeToContent = SizeToContent.Height; MaxHeight = SystemParameters.WorkArea.Height;
            WindowStartupLocation = WindowStartupLocation.CenterOwner;
            var panel = new StackPanel { Margin = new Thickness(20) };
            panel.Children.Add(new TextBlock { Text = "Modifier le stock", FontSize = 26, FontWeight = FontWeights.SemiBold });
            panel.Children.Add(new TextBlock { Text = snapshot.Name + "\nCode : " + snapshot.Code, FontSize = 18, TextWrapping = TextWrapping.Wrap, Margin = new Thickness(0, 8, 0, 12) });
            var mode = new ComboBox { MinHeight = 42, ItemsSource = new[] { "Augmenter le stock", "Diminuer le stock", "Quantité réelle comptée" }, SelectedIndex = pending is null ? 0 : (int)pending.Mode };
            System.Windows.Automation.AutomationProperties.SetName(mode, "Action sur le stock");
            panel.Children.Add(new Label { Content = "Opération", Target = mode }); panel.Children.Add(mode);
            var quantity = new TextBox { Text = (pending?.Quantity ?? 1m).ToString("0.####", CultureInfo.CurrentCulture), MinHeight = 44, FontSize = 22 };
            TouchNumericEntry.Attach(quantity, "Quantité de stock", allowZero: true, decimalPlaces: 4);
            System.Windows.Automation.AutomationProperties.SetName(quantity, "Quantité de stock");
            panel.Children.Add(new Label { Content = "Quantité", Target = quantity }); panel.Children.Add(quantity);
            var reason = new ComboBox { MinHeight = 40, ItemsSource = new[] { "Correction de stock", "Entrée manuelle", "Sortie manuelle", "Comptage physique" }, SelectedIndex = 0 };
            if (pending is not null) { reason.ItemsSource = new[] { pending.Reason }; reason.SelectedIndex = 0; }
            System.Windows.Automation.AutomationProperties.SetName(reason, "Motif de l’ajustement");
            panel.Children.Add(new Label { Content = "Motif", Target = reason }); panel.Children.Add(reason);
            var preview = new TextBlock { FontSize = 20, FontWeight = FontWeights.SemiBold, Margin = new Thickness(0, 16, 0, 10), TextWrapping = TextWrapping.Wrap }; panel.Children.Add(preview);
            var feedback = new TextBlock { TextWrapping = TextWrapping.Wrap, Margin = new Thickness(0, 0, 0, 10) }; panel.Children.Add(feedback);
            var save = new Button { Content = pending is null ? "Confirmer le nouveau stock" : "Vérifier l’ajustement précédent", MinHeight = 46, IsDefault = true };
            var cancel = new Button { Content = "Annuler", MinHeight = 40, IsCancel = true, Margin = new Thickness(0, 6, 0, 0) }; panel.Children.Add(save); panel.Children.Add(cancel);
            DailyStockAdjustmentService.Command Command()
            {
                if (pending is not null) return pending;
                if (!decimal.TryParse(quantity.Text, NumberStyles.AllowDecimalPoint, CultureInfo.CurrentCulture, out var value) || reason.SelectedItem is not string motif || mode.SelectedIndex is < 0 or > 2)
                    throw new DailyStockAdjustmentService.RefusedException("Sélectionnez l’opération, la quantité et le motif.");
                return new DailyStockAdjustmentService.Command(Guid.NewGuid().ToString("N"), snapshot, (DailyStockAdjustmentService.AdjustmentMode)mode.SelectedIndex, value, motif);
            }
            void Refresh()
            {
                try
                {
                    var command = Command(); var after = DailyStockAdjustmentService.ProposedAfter(command);
                    if (snapshot.Stock < 0) throw new DailyStockAdjustmentService.RefusedException("Le stock actuel est négatif. Utilisez l’inventaire physique pour rétablir une quantité vérifiée.");
                    if (after < 0 || after == snapshot.Stock) throw new DailyStockAdjustmentService.RefusedException("Le nouveau stock doit être positif ou nul et différent du stock actuel.");
                    preview.Text = $"Stock actuel : {snapshot.Stock:0.####}\nVariation : {after - snapshot.Stock:+0.####;-0.####;0}\nNouveau stock : {after:0.####}";
                    feedback.Text = pending is null ? "La quantité et son mouvement seront enregistrés ensemble." : "Un ajustement interrompu doit être vérifié sans changer son contenu.";
                    save.IsEnabled = true;
                }
                catch (Exception ex) { preview.Text = $"Stock actuel : {snapshot.Stock:0.####}"; feedback.Text = ex.Message; save.IsEnabled = false; }
            }
            void Lock(bool locked) { mode.IsEnabled = quantity.IsEnabled = reason.IsEnabled = cancel.IsEnabled = !locked; }
            mode.SelectionChanged += (_, _) => Refresh(); quantity.TextChanged += (_, _) => Refresh(); reason.SelectionChanged += (_, _) => Refresh();
            save.Click += (_, _) =>
            {
                save.IsEnabled = false;
                try { pending ??= Command(); Lock(true); Saved = workflow.Execute(pending); pending = null; DialogResult = true; }
                catch (DailyStockAdjustmentService.RefusedException ex) { pending = workflow.Pending; Lock(pending is not null); feedback.Text = "Aucun changement appliqué. " + ex.Message; }
                catch (Exception ex) { pending = workflow.Pending ?? pending; Lock(pending is not null); feedback.Text = "Résultat à vérifier avant un autre ajustement. " + ex.Message; }
                finally { save.IsEnabled = true; save.Content = pending is null ? "Confirmer le nouveau stock" : "Vérifier l’ajustement précédent"; }
            };
            Closing += (_, args) => { if (workflow.Pending is not null) { args.Cancel = true; feedback.Text = "Vérifiez le même ajustement avant de fermer."; } };
            Closed += (_, _) => workflow.Dispose();
            Content = new ScrollViewer { Content = panel, VerticalScrollBarVisibility = ScrollBarVisibility.Auto };
            Lock(pending is not null); Refresh();
        }
        catch { workflow.Dispose(); throw; }
    }
}
