using System;using System.IO;using System.Reflection;using System.Data;using System.Windows.Forms;using System.Threading;using System.Diagnostics;using System.Text;using System.Runtime.InteropServices;using System.Collections.Generic;
class RecoveredCheck {
 delegate bool EnumProc(IntPtr w,IntPtr p);
 [DllImport("user32.dll")]static extern bool EnumWindows(EnumProc f,IntPtr p);
 [DllImport("user32.dll")]static extern bool EnumChildWindows(IntPtr w,EnumProc f,IntPtr p);
 [DllImport("user32.dll",CharSet=CharSet.Unicode)]static extern int GetClassName(IntPtr w,StringBuilder b,int n);
 [DllImport("user32.dll",CharSet=CharSet.Unicode)]static extern int GetWindowText(IntPtr w,StringBuilder b,int n);
 [DllImport("user32.dll")]static extern uint GetWindowThreadProcessId(IntPtr w,out uint p);
 [DllImport("user32.dll")]static extern bool PostMessage(IntPtr w,uint m,IntPtr a,IntPtr b);
 static volatile bool stop=false;static List<string> errors=new List<string>();
 static object Get(object o,string n){return o.GetType().GetProperty(n,BindingFlags.Instance|BindingFlags.NonPublic|BindingFlags.Public).GetValue(o,null);}
 static void Watch(){while(!stop){EnumWindows(delegate(IntPtr w,IntPtr x){uint pid;GetWindowThreadProcessId(w,out pid);if(pid!=Process.GetCurrentProcess().Id)return true;var b=new StringBuilder(100);GetClassName(w,b,100);if(b.ToString()!="#32770")return true;var all=new StringBuilder();EnumChildWindows(w,delegate(IntPtr c,IntPtr y){var text=new StringBuilder(600);GetWindowText(c,text,600);if(text.Length>0)all.Append(text+" ");return true;},IntPtr.Zero);lock(errors){errors.Add(all.ToString());}PostMessage(w,0x10,IntPtr.Zero,IntPtr.Zero);return true;},IntPtr.Zero);Thread.Sleep(100);}}
 [STAThread]static int Main(){var watcher=new Thread(Watch);watcher.IsBackground=true;watcher.Start();try{
 Application.EnableVisualStyles();var a=Assembly.LoadFrom(Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"LOGICA.exe"));
 var forms=a.GetType("LOGICA.My.MyProject",true).GetProperty("Forms",BindingFlags.NonPublic|BindingFlags.Static).GetValue(null,null);var form=(Form)Get(forms,"Form_0_TEMPLATE");var handle=form.Handle;
 var module=a.GetType("LOGICA.Module1",true);var connection=(IDbConnection)module.GetField("cn_SQL").GetValue(null);
 if(!connection.ConnectionString.Contains("logica_recovered_check"))throw new Exception("Wrong recovery test database");
 connection.Open();foreach(var entry in new[]{new[]{"TABLE_ARTICLES","120"},new[]{"TABLE_FAMILLES","15"},new[]{"TABLE_VENTES_ENTETE","11"},new[]{"TABLE_VENTES_JOURNAL","54"},new[]{"TABLE_VENTES_REGLEMENTS","11"}}){using(var c=connection.CreateCommand()){c.CommandText="SELECT COUNT(*) FROM "+entry[0];var count=Convert.ToInt32(c.ExecuteScalar());if(count!=int.Parse(entry[1]))throw new Exception("Recovered row count mismatch "+entry[0]);Console.WriteLine("PASS recovered "+entry[0]+" rows="+count);}}
 int verified=0;
 var inventory=File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"..","input","database-inventory.json"));
 foreach(System.Text.RegularExpressions.Match entry in System.Text.RegularExpressions.Regex.Matches(inventory,"\\\"([A-Za-z_][A-Za-z_0-9]*)\\\"\\s*:\\s*\\{\\s*\\\"rows\\\":\\s*(\\d+)")) {
  string table=entry.Groups[1].Value;int expected=int.Parse(entry.Groups[2].Value)+(table=="TABLE_PARAMETRES"?1:0);
  using(var c=connection.CreateCommand()){c.CommandText="SELECT COUNT(*) FROM `"+table+"`";if(Convert.ToInt32(c.ExecuteScalar())!=expected)throw new Exception("Original table row count mismatch: "+table);}
  verified++;
 }
 if(verified!=125)throw new Exception("Not all original data tables were checked: "+verified);
 Console.WriteLine("PASS all 125 original table row counts preserved (one documented compatibility setting added)");
 foreach(string column in new[]{"Catégorie","Qté"}) {
  using(var c=connection.CreateCommand()){
   c.CommandText=column=="Catégorie"?"SELECT `Catégorie` FROM TABLE_PASS LIMIT 0":"SELECT `Qté` FROM TABLE_01 LIMIT 0";
   using(var reader=c.ExecuteReader()){if(reader.GetName(0)!=column)throw new Exception("Accented database metadata is corrupted");}
  }
 }
 Console.WriteLine("PASS accented role and quantity column names are decoded correctly");
 connection.Close();form.Show();Application.DoEvents();
 if(((Control)Get(form,"Panel_TENTATIVE_CONNEXION")).Visible)throw new Exception("Original startup connection failure: "+((Control)Get(form,"Label_ERREUR")).Text);
 lock(errors){if(errors.Count>0)throw new Exception("Original startup modal errors: "+string.Join(" | ",errors.ToArray()));}
 Console.WriteLine("PASS original startup connected to recovered database; connection error panel hidden");bool activationVisible=((Control)Get(form,"Panel_clé")).Visible;
 bool expectDevelopment=Environment.GetEnvironmentVariable("LOGICA_EXPECT_DEVELOPMENT")=="1";
 if(expectDevelopment){
  var login=(Control)Get(forms,"Form_1_LOGIN");
  var home=(Control)Get(form,"Panel_HOME");
  if(activationVisible || !home.Controls.Contains(login) || !login.Visible || !((Control)Get(login,"Panel_login")).Visible)throw new Exception("Development did not reach the original user login");
  Console.WriteLine("PASS Debug reaches original user login; machine activation hidden; user authentication preserved");
  string adminPin;string adminName;
  connection.Open();
  using(var c=connection.CreateCommand()){
   c.CommandText="SELECT ListPass, ListUser FROM TABLE_PASS WHERE `Catégorie`='ADMIN' LIMIT 1";
   using(var reader=c.ExecuteReader()){if(!reader.Read())throw new Exception("No original administrator fixture");adminPin=reader.GetString(0);adminName=reader.GetString(1);}
  }
  connection.Close();
  var pin=(Control)Get(login,"Text_NUM");
  var method=login.GetType().GetMethod("Butt_ok_Click",BindingFlags.Instance|BindingFlags.NonPublic);
  foreach(string invalid in new[]{"invalid-test-pin","' OR 1=1 --"}){
   pin.Text=invalid;using(var button=new Button(){Name="CI_LOGIN"})method.Invoke(login,new object[]{button,EventArgs.Empty});
   if(!((Control)Get(login,"Panel_login")).Visible || module.GetField("_USERCATEGORIE").GetValue(null) as string=="ADMIN")throw new Exception("Invalid credentials were accepted");
  }
  Console.WriteLine("PASS wrong PIN and SQL-like input remain unauthenticated");
  pin.Text=adminPin;using(var button=new Button(){Name="CI_LOGIN"})method.Invoke(login,new object[]{button,EventArgs.Empty});
  lock(errors){if(errors.Count>0)throw new Exception("Login modal errors: "+string.Join(" | ",errors.ToArray()));}
  if((string)module.GetField("_USERCATEGORIE").GetValue(null)!="ADMIN" || (string)module.GetField("_USERNAME").GetValue(null)!=adminName || ((Control)Get(login,"Panel_login")).Visible || !((Control)Get(login,"Panel_menu")).Visible)throw new Exception("Real administrator login did not reach the menu");
  Console.WriteLine("PASS original administrator PIN reaches the menu with its role and permissions");
  string beforeConnection=connection.ConnectionString;
  var backoffice=Get(forms,"Form_00_BACKOFFICE");
  ((Control)Get(backoffice,"Label_DB_1")).Text="obsolete-host.invalid";
  backoffice.GetType().GetMethod("Button_RJ1_Click",BindingFlags.Instance|BindingFlags.NonPublic).Invoke(backoffice,new object[]{new Button(){Name="CI_BACKOFFICE"},EventArgs.Empty});
  if(!Object.ReferenceEquals(connection,module.GetField("cn_SQL").GetValue(null)) || connection.ConnectionString!=beforeConnection)throw new Exception("Backoffice replaced the portable database connection");
  Console.WriteLine("PASS Backoffice preserves active portable database endpoint and credentials");
  for(int repeat=0;repeat<2;repeat++){
   var config=(Form)Get(forms,"FormDialog_2_Configuration");config.Show();Application.DoEvents();
   var options=(ListView)Get(config,"ListView1");
   foreach(string key in new[]{"GROUPES","BLOCAGE_STOCK_INSUFFISANT","MODELE_TICKET"})if(options.FindItemWithText(key,false,0)==null)throw new Exception("Configuration missing "+key);
   if(((DataGridView)Get(config,"DataGridView_MODELE_TICKET")).Rows.Count!=5)throw new Exception("Receipt templates did not load exactly once");
   config.Close();
  }
  lock(errors){if(errors.Count>0)throw new Exception("Configuration errors: "+string.Join(" | ",errors.ToArray()));}
  Console.WriteLine("PASS configuration opens and reopens with stock/group options and receipt templates");
  var articles=(Form)Get(forms,"Form_2_ARTICLES");articles.Show();Application.DoEvents();
  var products=(DataGridView)Get(articles,"DataGridView1");
  if(products.Rows.Count!=30 || ((ComboBox)Get(articles,"Combo_FAMILLE")).Items.Count!=15)throw new Exception("Products or families failed to load");
  if(((Control)Get(articles,"TextBox_NBR_CODE_ARTICLE")).Text!="4")throw new Exception("Product barcode settings did not load");
  lock(errors){if(errors.Count>0)throw new Exception("Product page errors: "+string.Join(" | ",errors.ToArray()));}
  articles.Close();
  connection.Open();module.GetMethod("EnsureRecoveredSettings").Invoke(null,null);module.GetMethod("EnsureRecoveredSettings").Invoke(null,null);
  using(var c=connection.CreateCommand()){c.CommandText="SELECT COUNT(*) FROM TABLE_PARAMETRES WHERE OBJET IN ('GROUPES','GROUPES_LISTE')";if(Convert.ToInt32(c.ExecuteScalar())!=2)throw new Exception("Compatibility settings duplicated");}
  connection.Close();
  Console.WriteLine("PASS products page loads 30 original products and 15 families; missing settings upgrade is idempotent");


 }else{
  if(!activationVisible)throw new Exception("Release activation behavior changed");
  Console.WriteLine("PASS Release retains original machine activation");
 }
 form.Dispose();return 0;
 }catch(Exception e){Console.WriteLine("FAIL "+e);return 1;}finally{stop=true;}}
}

