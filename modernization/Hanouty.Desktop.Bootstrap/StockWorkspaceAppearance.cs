using System.Windows;
namespace Hanouty.Desktop.Bootstrap;
internal static class StockWorkspaceAppearance
{
    internal static void Apply(Window window)
    {
        window.UseLayoutRounding = true;
        window.SourceInitialized += (_, _) => {
            if (window.Owner is not { } owner) return;
            window.Resources.MergedDictionaries.Add(owner.Resources);
            window.Background = owner.Background;
            window.FontFamily = owner.FontFamily;
            window.FontSize = owner.FontSize;
        };
    }
}
