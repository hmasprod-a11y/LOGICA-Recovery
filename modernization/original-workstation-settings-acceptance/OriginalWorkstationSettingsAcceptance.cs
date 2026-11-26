using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Threading;
using Hanouty.Desktop.Wpf;
using System.IO;
using System.Text.Json;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Hanouty.Desktop.Bootstrap;
using MySql.Data.MySqlClient;
internal static class OriginalWorkstationSettingsAcceptance
{
 [STAThread] static void Main(string[] args){
 var cs=new MySqlConnectionStringBuilder{Server="127.0.0.1",Port=33082,UserID="root",Password="settings-test-only",CharacterSet="utf8mb4",Pooling=false};
 using var db=new MySqlConnection(cs.ConnectionString);db.Open();
 void Sql(string text){using var cmd=new MySqlCommand(text,db);cmd.ExecuteNonQuery();}
 string Value(string text){using var cmd=new MySqlCommand(text,db);return Convert.ToString(cmd.ExecuteScalar())??"";}
 void Require(bool condition,string reason){if(!condition)throw new Exception(reason);}
 void Refused(Action action){try{action();}catch(Exception e)when(e is UnauthorizedAccessException or InvalidOperationException or ArgumentException or MySqlException){return;}throw new Exception("Expected refusal");}
 var schema="original_settings_"+Guid.NewGuid().ToString("N");Sql("CREATE DATABASE `"+schema+"` CHARACTER SET utf8mb4 COLLATE utf8mb4_bin");db.ChangeDatabase(schema);cs.Database=schema;
 Sql("CREATE TABLE TABLE_PASS (ListUser VARCHAR(128),ListPass VARCHAR(128),Catégorie VARCHAR(64)) ENGINE=InnoDB; CREATE TABLE TABLE_PARAMETRES (OBJET VARCHAR(128),VALEUR TEXT) ENGINE=InnoDB; INSERT INTO TABLE_PASS VALUES ('Admin été مسؤول','1234','ADMIN'),('Manager','5678','MANAGER'); INSERT INTO TABLE_PARAMETRES VALUES ('MODELE_TICKET','FR_3C'),('BRANCHEMENT','USB'),('AFFICHER_MODE_P','-1'),('AFFICHER_N_TICKET','True'),('AFFICHER_CODE_BARRE','False'),('PIED_TICKET','Merci'),('FENETRE_MODE_P','True')");
 string? actor="Admin été مسؤول",pin="1234";
 var store=new OriginalWorkstationSettingsStore(cs.ConnectionString,()=>actor,()=>pin);
 var initial=store.Load();Require(initial.MissingKeys.Count==4&&Value("SELECT COUNT(*) FROM TABLE_PARAMETRES")=="7","Load must not initialize");
 var desired=new Dictionary<string,string>(initial.Values){["MODIF_STOCK_MANUEL"]="True",["PIED_TICKET"]="Merci d'été شكرا"};
 var saved=store.Save(initial,desired);Require(saved.MissingKeys.Count==0&&saved.Values["AFFICHER_MODE_P"]=="-1"&&Value("SELECT COUNT(*) FROM TABLE_PARAMETRES")=="11","Initialization/raw flags");
 var replay=store.Save(initial,desired);Require(replay.Revision==saved.Revision,"Retry not reconciled");
 var stale=store.Load();Sql("UPDATE TABLE_PARAMETRES SET VALEUR='concurrent' WHERE OBJET='PIED_TICKET'");Refused(()=>store.Save(stale,new Dictionary<string,string>{{"PIED_TICKET","stale"}}));Require(Value("SELECT VALEUR FROM TABLE_PARAMETRES WHERE OBJET='PIED_TICKET'")=="concurrent","CAS overwritten");
 var current=store.Load();Sql("CREATE TRIGGER fail_original_settings BEFORE UPDATE ON TABLE_PARAMETRES FOR EACH ROW BEGIN IF NEW.OBJET='PIED_TICKET' THEN SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT='test rollback'; END IF; END");Refused(()=>store.Save(current,new Dictionary<string,string>{{"MODIF_STOCK_MANUEL","False"},{"PIED_TICKET","failure"}}));Sql("DROP TRIGGER fail_original_settings");Require(Value("SELECT VALEUR FROM TABLE_PARAMETRES WHERE OBJET='MODIF_STOCK_MANUEL'")=="True","Rollback incomplete");
 actor="Manager";pin="5678";Refused(()=>store.Load());actor="Admin été مسؤول";pin="wrong";Refused(()=>store.Load());pin="1234";
 var roleSnapshot=store.Load();Sql("UPDATE TABLE_PASS SET Catégorie='MANAGER' WHERE ListUser='Admin été مسؤول'");Refused(()=>store.Save(roleSnapshot,new Dictionary<string,string>{{"PIED_TICKET","denied"}}));Sql("UPDATE TABLE_PASS SET Catégorie='ADMIN' WHERE ListUser='Admin été مسؤول'");
 current=store.Load();actor="Admin ete مسؤول";Refused(()=>store.Save(current,new Dictionary<string,string>{{"PIED_TICKET","lookalike"}}));actor="Admin été مسؤول";
 Refused(()=>store.Save(store.Load(),new Dictionary<string,string>{{"NOM_MAGASIN","invented"}}));Refused(()=>store.Save(store.Load(),new Dictionary<string,string>{{"FONDS_CAISSE","-1"}}));
 var output=Path.GetFullPath(args[0]);Directory.CreateDirectory(output);
 var app=new Application();var window=new OriginalWorkstationSettingsDialog(new OriginalWorkstationSettingsWorkflow(store));window.Show();window.UpdateLayout();
 IEnumerable<DependencyObject> Children(DependencyObject parent){foreach(var child in LogicalTreeHelper.GetChildren(parent).OfType<DependencyObject>()){yield return child;foreach(var nested in Children(child))yield return nested;}}
 var tabs=Children(window).OfType<TabControl>().Single();tabs.SelectedIndex=3;window.UpdateLayout();
 var amountField=Children(window).OfType<TextBox>().Single(t=>System.Windows.Automation.AutomationProperties.GetName(t)=="FONDS_CAISSE");Require(amountField.IsReadOnly,"Amount must use keypad");
 bool keypadSeen=false;window.Dispatcher.BeginInvoke(DispatcherPriority.ApplicationIdle,new Action(()=>{var keypad=Application.Current.Windows.OfType<TouchNumericEntryDialog>().Single();keypadSeen=true;Children(keypad).OfType<Button>().Single(b=>Equals(b.Content,"7")).RaiseEvent(new RoutedEventArgs(Button.ClickEvent));Children(keypad).OfType<Button>().Single(b=>Equals(b.Content,"Appliquer")).RaiseEvent(new RoutedEventArgs(Button.ClickEvent));}));
 amountField.RaiseEvent(new MouseButtonEventArgs(Mouse.PrimaryDevice,0,MouseButton.Left){RoutedEvent=UIElement.PreviewMouseLeftButtonDownEvent});Require(keypadSeen&&amountField.Text=="7","Numeric keypad not functional");
 Children(window).OfType<Button>().Single(b=>Equals(b.Content,"Enregistrer")).RaiseEvent(new RoutedEventArgs(Button.ClickEvent));Require(Value("SELECT VALEUR FROM TABLE_PARAMETRES WHERE OBJET='FONDS_CAISSE'")=="7","Keypad save failed");window.UpdateLayout();
 var bitmap=new RenderTargetBitmap((int)window.ActualWidth,(int)window.ActualHeight,96,96,PixelFormats.Pbgra32);bitmap.Render(window);var encoder=new PngBitmapEncoder();encoder.Frames.Add(BitmapFrame.Create(bitmap));using(var file=File.Create(Path.Combine(output,"original-settings.png")))encoder.Save(file);window.Close();
 var proof=new{OriginalKeys=11,SessionPinNoAdditionalDialog=true,MissingDefaultsExplicitInsert=true,LoadReadOnly=true,StockManualEnabled=true,Utf8=true,RawMinusOnePreserved=true,Replay=true,StaleCasRefused=true,Rollback=true,WrongPinRefused=true,RoleRevocationRefused=true,LookalikeSessionRefused=true,InventedKeyRefused=true,NegativeOpeningRefused=true,WpfDialog=true,TouchOpeningAmountKeypad=true};File.WriteAllText(Path.Combine(output,"acceptance.json"),JsonSerializer.Serialize(proof,new JsonSerializerOptions{WriteIndented=true}));Console.WriteLine(JsonSerializer.Serialize(proof));
 }
}


