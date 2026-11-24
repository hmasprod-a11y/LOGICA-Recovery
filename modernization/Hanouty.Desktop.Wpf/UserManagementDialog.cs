using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using Hanouty.ArchitectureBridge;

namespace Hanouty.Desktop.Wpf;

public sealed class UserManagementDialog : Window
{
    private readonly DataGrid grid = new() { AutoGenerateColumns = false, IsReadOnly = true, MaxHeight = 220, Margin = new Thickness(0, 0, 0, 10) };
    private readonly TextBox usernameBox = new() { MinWidth = 160, Margin = new Thickness(0, 0, 0, 6) };
    private readonly PasswordBox pinBox = new() { MinWidth = 160, Margin = new Thickness(0, 0, 0, 6) };
    private readonly ComboBox roleBox = new() { MinWidth = 160, Margin = new Thickness(0, 0, 0, 8) };
    private readonly TextBlock feedback = new() { TextWrapping = TextWrapping.Wrap, Margin = new Thickness(0, 6, 0, 6) };

    public UserManagementDialog(
        Func<IReadOnlyList<HanoutyUserRecord>> loadUsers,
        Func<string, string, HanoutyRole, int> createUser,
        Action<int> deleteUser)
    {
        ArgumentNullException.ThrowIfNull(loadUsers);
        ArgumentNullException.ThrowIfNull(createUser);
        ArgumentNullException.ThrowIfNull(deleteUser);

        Title = "Gestion des utilisateurs et permissions";
        Width = 540;
        SizeToContent = SizeToContent.Height;
        WindowStartupLocation = WindowStartupLocation.CenterOwner;

        grid.Columns.Add(new DataGridTextColumn { Header = "ID", Binding = new System.Windows.Data.Binding("Id"), Width = 60 });
        grid.Columns.Add(new DataGridTextColumn { Header = "Utilisateur", Binding = new System.Windows.Data.Binding("Username"), Width = new DataGridLength(1, DataGridLengthUnitType.Star) });
        grid.Columns.Add(new DataGridTextColumn { Header = "Rôle", Binding = new System.Windows.Data.Binding("Role"), Width = 140 });

        roleBox.ItemsSource = new[] { HanoutyRole.Utilisateur, HanoutyRole.Manager, HanoutyRole.Admin };
        roleBox.SelectedItem = HanoutyRole.Utilisateur;

        void Refresh()
        {
            grid.ItemsSource = loadUsers();
        }

        var addBtn = new Button { Content = "Ajouter l'utilisateur", MinHeight = 36, Margin = new Thickness(0, 0, 8, 0) };
        addBtn.Click += (_, _) =>
        {
            try
            {
                var role = roleBox.SelectedItem is HanoutyRole r ? r : HanoutyRole.Utilisateur;
                createUser(usernameBox.Text, pinBox.Password, role);
                usernameBox.Clear();
                pinBox.Clear();
                feedback.Text = "Utilisateur enregistré.";
                Refresh();
            }
            catch (Exception ex) when (ex is ArgumentException or InvalidOperationException)
            {
                feedback.Text = ex.Message;
            }
        };

        var delBtn = new Button { Content = "Supprimer la sélection", MinHeight = 36 };
        delBtn.Click += (_, _) =>
        {
            if (grid.SelectedItem is not HanoutyUserRecord selected)
            {
                feedback.Text = "Sélectionnez un utilisateur.";
                return;
            }
            try
            {
                deleteUser(selected.Id);
                feedback.Text = $"Utilisateur {selected.Username} supprimé.";
                Refresh();
            }
            catch (Exception ex) when (ex is InvalidOperationException)
            {
                feedback.Text = ex.Message;
            }
        };

        var actions = new StackPanel { Orientation = Orientation.Horizontal };
        actions.Children.Add(addBtn);
        actions.Children.Add(delBtn);

        var root = new StackPanel { Margin = new Thickness(18) };
        root.Children.Add(grid);
        root.Children.Add(new Label { Content = "Nom d'utilisateur" });
        root.Children.Add(usernameBox);
        root.Children.Add(new Label { Content = "Code PIN" });
        root.Children.Add(pinBox);
        root.Children.Add(new Label { Content = "Catégorie / Rôle" });
        root.Children.Add(roleBox);
        root.Children.Add(actions);
        root.Children.Add(feedback);
        Content = root;

        Loaded += (_, _) => Refresh();
    }
}
