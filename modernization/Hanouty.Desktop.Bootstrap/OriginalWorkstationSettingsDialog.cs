using System.Globalization;
using Hanouty.Desktop.Wpf;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using Microsoft.VisualBasic.CompilerServices;
namespace Hanouty.Desktop.Bootstrap;
internal sealed class OriginalWorkstationSettingsWorkflow(OriginalWorkstationSettingsStore store)
{
    internal OriginalWorkstationSettingsSnapshot Load()=>store.Load();
    internal OriginalWorkstationSettingsSnapshot Save(OriginalWorkstationSettingsSnapshot expected,IReadOnlyDictionary<string,string> values)=>store.Save(expected,values);
}
internal sealed class OriginalWorkstationSettingsDialog : Window
{
    private readonly OriginalWorkstationSettingsWorkflow workflow;
    private OriginalWorkstationSettingsSnapshot snapshot;
    private readonly Dictionary<string,FrameworkElement> editors=new(StringComparer.Ordinal);
    private readonly TextBlock status=new(){TextWrapping=TextWrapping.Wrap,Margin=new Thickness(12)};
    internal OriginalWorkstationSettingsDialog(OriginalWorkstationSettingsWorkflow workflow)
    {
        this.workflow=workflow;snapshot=workflow.Load();Title="Paramètres LOGICA du poste";Width=850;Height=700;MinWidth=650;MinHeight=500;WindowStartupLocation=WindowStartupLocation.CenterOwner;
        var root=new DockPanel{Margin=new Thickness(14)};Content=root;
        var footer=new StackPanel();DockPanel.SetDock(footer,Dock.Bottom);root.Children.Add(footer);footer.Children.Add(status);
        var buttons=new StackPanel{Orientation=Orientation.Horizontal,HorizontalAlignment=HorizontalAlignment.Right};footer.Children.Add(buttons);
        Button Action(string label,RoutedEventHandler action){var button=new Button{Content=label,MinWidth=135,Height=46,Margin=new Thickness(5)};button.Click+=action;buttons.Children.Add(button);return button;}
        Action("Recharger",(_,_)=>{try{snapshot=workflow.Load();Fill();status.Text="Paramètres relus.";}catch(Exception e){status.Text=e.Message;}});
        Action("Enregistrer",(_,_)=>Save());Action("Fermer",(_,_)=>Close());
        var title=new TextBlock{Text="Paramètres du poste — session ADMIN",FontSize=24,Margin=new Thickness(4,0,4,15)};DockPanel.SetDock(title,Dock.Top);root.Children.Add(title);
        var tabs=new TabControl();root.Children.Add(tabs);
        foreach(var group in OriginalWorkstationSettingsStore.Definitions.GroupBy(d=>d.Section)){
            var panel=new StackPanel{Margin=new Thickness(15)};tabs.Items.Add(new TabItem{Header=group.Key,Content=new ScrollViewer{Content=panel,VerticalScrollBarVisibility=ScrollBarVisibility.Auto}});
            foreach(var setting in group){
                var label=new TextBlock{Text=setting.Label,Margin=new Thickness(0,12,0,6),FontSize=17};panel.Children.Add(label);
                FrameworkElement editor=setting.Kind=="bool"?new CheckBox{Content="Activé",FontSize=17,MinHeight=38}:new TextBox{FontSize=18,MinHeight=44,AcceptsReturn=setting.Kind=="text",TextWrapping=TextWrapping.Wrap};
                if(setting.Kind=="money")TouchNumericEntry.Attach((TextBox)editor,setting.Label,allowZero:true);
                System.Windows.Automation.AutomationProperties.SetName(editor,setting.Key);editors.Add(setting.Key,editor);panel.Children.Add(editor);
                if(setting.Kind is "template" or "connection")panel.Children.Add(new TextBlock{Text=setting.Kind=="template"?"Modèle raccordé : FR_3C":"Branchement raccordé : USB",Foreground=Brushes.DimGray});
            }
        }
        Fill();
    }
    private void Fill()
    {
        foreach(var pair in editors){
            var exists=snapshot.Values.TryGetValue(pair.Key,out var value);pair.Value.IsEnabled=exists;
            if(pair.Value is CheckBox flag){try{flag.IsChecked=exists&&Conversions.ToBoolean(value);}catch{flag.IsChecked=false;flag.IsEnabled=false;}}
            else if(pair.Value is TextBox text)text.Text=pair.Key=="FONDS_CAISSE"&&decimal.TryParse(value,NumberStyles.Number,CultureInfo.InvariantCulture,out var amount)?amount.ToString("0.##",CultureInfo.CurrentCulture):value??"Paramètre manquant — préparation requise";
        }
        status.Text=snapshot.MissingKeys.Count==0?"La session ADMIN actuelle suffit. Aucun PIN supplémentaire.":"À l’enregistrement : initialisation explicite des paramètres absents selon LOGICA (stock manuel et clôtures désactivés, fonds 0).";
    }
    private void Save()
    {
        try{
            var values=new Dictionary<string,string>(StringComparer.Ordinal);
            foreach(var pair in editors.Where(p=>p.Value.IsEnabled))values.Add(pair.Key,pair.Value is CheckBox flag?(Conversions.ToBoolean(snapshot.Values[pair.Key])==(flag.IsChecked==true)?snapshot.Values[pair.Key]:Conversions.ToString(flag.IsChecked==true)):pair.Key=="FONDS_CAISSE"?decimal.Parse(((TextBox)pair.Value).Text,NumberStyles.Number,CultureInfo.CurrentCulture).ToString("0.##",CultureInfo.InvariantCulture):((TextBox)pair.Value).Text);
            snapshot=workflow.Save(snapshot,values);Fill();status.Text="Paramètres enregistrés et vérifiés.";
        }catch(Exception e){status.Text=e.Message;}
    }
}


