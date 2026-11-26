using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Microsoft.Win32;

namespace Hanouty.Desktop.Wpf;

public sealed class BackupRestoreDialog : Window
{
    public BackupRestoreDialog(
        Func<string, Task<string>> createBackupAsync,
        Func<string, Task> restoreBackupAsync)
    {
        ArgumentNullException.ThrowIfNull(createBackupAsync);
        ArgumentNullException.ThrowIfNull(restoreBackupAsync);

        Title = "Sauvegarde et restauration de la base";
        Width = 520;
        SizeToContent = SizeToContent.Height;
        WindowStartupLocation = WindowStartupLocation.CenterOwner;

        var defaultDir = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            "HANOUTY", "Backups");
        var folderBox = new TextBox { Text = defaultDir, Margin = new Thickness(0, 0, 0, 10) };
        var feedback = new TextBlock { TextWrapping = TextWrapping.Wrap, Margin = new Thickness(0, 10, 0, 0) };

        var backupBtn = new Button { Content = "Créer une sauvegarde (.sql + SHA-256)", MinHeight = 38, Margin = new Thickness(0, 0, 0, 8) };
        var restoreBtn = new Button { Content = "Restaurer depuis un fichier .sql...", MinHeight = 38 };

        backupBtn.Click += async (_, _) =>
        {
            backupBtn.IsEnabled = restoreBtn.IsEnabled = false;
            try
            {
                feedback.Text = "Sauvegarde en cours...";
                var summary = await createBackupAsync(folderBox.Text.Trim());
                feedback.Text = summary;
            }
            catch (Exception ex) when (ex is not OutOfMemoryException and not StackOverflowException)
            {
                feedback.Text = "Erreur de sauvegarde : " + ex.Message;
            }
            finally { backupBtn.IsEnabled = restoreBtn.IsEnabled = true; }
        };

        restoreBtn.Click += async (_, _) =>
        {
            var dlg = new OpenFileDialog
            {
                Filter = "Fichiers SQL (*.sql)|*.sql",
                InitialDirectory = Directory.Exists(folderBox.Text) ? folderBox.Text : defaultDir
            };
            if (dlg.ShowDialog() != true) return;
            if (MessageBox.Show(this,
                "Une sauvegarde de sécurité automatique sera créée avant la restauration. Continuer ?",
                "Confirmation de restauration", MessageBoxButton.YesNo, MessageBoxImage.Warning) != MessageBoxResult.Yes)
                return;

            backupBtn.IsEnabled = restoreBtn.IsEnabled = false;
            try
            {
                feedback.Text = "Restauration en cours...";
                await restoreBackupAsync(dlg.FileName);
                feedback.Text = "Restauration terminée avec succès. Redémarrez l'application.";
            }
            catch (Exception ex) when (ex is not OutOfMemoryException and not StackOverflowException)
            {
                feedback.Text = "Erreur de restauration : " + ex.Message;
            }
            finally { backupBtn.IsEnabled = restoreBtn.IsEnabled = true; }
        };

        var root = new StackPanel { Margin = new Thickness(18) };
        root.Children.Add(new Label { Content = "Dossier de sauvegarde" });
        root.Children.Add(folderBox);
        root.Children.Add(backupBtn);
        root.Children.Add(restoreBtn);
        root.Children.Add(feedback);
        Content = root;
    }
}
