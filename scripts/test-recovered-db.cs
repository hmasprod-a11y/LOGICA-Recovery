using MySql.Data.MySqlClient;
using System;using System.IO;using System.Reflection;using System.Data;using System.Windows.Forms;using System.Threading;using System.Diagnostics;using System.Text;using System.Runtime.InteropServices;using System.Collections.Generic;
class RecoveredCheck {
 delegate bool EnumProc(IntPtr w,IntPtr p);
 [DllImport("user32.dll")]static extern bool EnumWindows(EnumProc f,IntPtr p);
 [DllImport("user32.dll")]static extern bool EnumChildWindows(IntPtr w,EnumProc f,IntPtr p);
 [DllImport("user32.dll",CharSet=CharSet.Unicode)]static extern int GetClassName(IntPtr w,StringBuilder b,int n);
 [DllImport("user32.dll",CharSet=CharSet.Unicode)]static extern int GetWindowText(IntPtr w,StringBuilder b,int n);
 [DllImport("user32.dll")]static extern uint GetWindowThreadProcessId(IntPtr w,out uint p);
 [DllImport("user32.dll")]static extern IntPtr SendMessage(IntPtr window,uint message,IntPtr wParam,IntPtr lParam);
 [DllImport("user32.dll")]static extern bool PostMessage(IntPtr w,uint m,IntPtr a,IntPtr b);
 static int saved=0;static int productSaved=0;static volatile bool stop=false;static List<string> errors=new List<string>();
 static object Get(object o,string n){return o.GetType().GetProperty(n,BindingFlags.Instance|BindingFlags.NonPublic|BindingFlags.Public).GetValue(o,null);}
 static void Watch(){while(!stop){EnumWindows(delegate(IntPtr w,IntPtr x){uint pid;GetWindowThreadProcessId(w,out pid);if(pid!=Process.GetCurrentProcess().Id)return true;var b=new StringBuilder(100);GetClassName(w,b,100);if(b.ToString()!="#32770")return true;var all=new StringBuilder();EnumChildWindows(w,delegate(IntPtr c,IntPtr y){var text=new StringBuilder(600);GetWindowText(c,text,600);if(text.Length>0)all.Append(text+" ");return true;},IntPtr.Zero);lock(errors){if(all.ToString().Contains("Modifié avec succès"))saved++;else if(all.ToString().Contains("Enregistré avec succès"))productSaved++;else errors.Add(all.ToString());}PostMessage(w,0x10,IntPtr.Zero,IntPtr.Zero);return true;},IntPtr.Zero);Thread.Sleep(100);}}

 static void CheckBasketIdentity(Assembly assembly,Type module,object template,IDbConnection connection) {
  var sql=(MySqlConnection)connection;
  string originalPost=((Control)Get(template,"Label_POSTE")).Text;
  if(!sql.Database.StartsWith("logica_recovered_check"))throw new Exception("Identity regression requires isolated database");
  sql.Open();
  using(var c=sql.CreateCommand()){c.CommandText="CREATE TABLE TABLE_CI_IDENTITY LIKE TABLE_01; ALTER TABLE TABLE_CI_IDENTITY AUTO_INCREMENT=100";c.ExecuteNonQuery();}
  sql.Close();
  // Reproduce the original identity mismatch with the same Connector/NET command builder.
  using(var oldAdapter=new MySqlDataAdapter("SELECT * FROM TABLE_CI_IDENTITY",sql))
  using(var oldBuilder=new MySqlCommandBuilder(oldAdapter)){
   var oldTable=new DataTable();oldAdapter.Fill(oldTable);var row=oldTable.NewRow();row["ID"]=1;row["Code"]="BASELINE";row["Qté"]=1;row["TOTAL_NET"]=12.35;oldTable.Rows.Add(row);oldAdapter.Update(oldTable);
   sql.Open();long stored;using(var c=sql.CreateCommand()){c.CommandText="SELECT ID FROM TABLE_CI_IDENTITY";stored=Convert.ToInt64(c.ExecuteScalar());}
   if(stored==Convert.ToInt64(row["ID"]))throw new Exception("Legacy identity mismatch was not reproduced");
   using(var c=sql.CreateCommand()){c.CommandText="DELETE FROM TABLE_CI_IDENTITY; ALTER TABLE TABLE_CI_IDENTITY AUTO_INCREMENT=200";c.ExecuteNonQuery();}sql.Close();
   Console.WriteLine("PASS reproduced original basket identity mismatch: local=1 server="+stored);
  }
  ((Control)Get(template,"Label_POSTE")).Text="CI_IDENTITY";
  try {
   for(int cycle=0;cycle<2;cycle++){
    var adapter=new MySqlDataAdapter("SELECT * FROM TABLE_CI_IDENTITY ORDER BY ID",sql);var table=new DataTable();adapter.Fill(table);
    module.GetField("da1").SetValue(null,adapter);module.GetField("dt1").SetValue(null,table);
    using(var sale=(Form)Activator.CreateInstance(assembly.GetType("LOGICA.Form_3_VENTE",true))){
     var grid=(DataGridView)Get(sale,"DataGridView1");grid.AutoGenerateColumns=false;grid.AllowUserToAddRows=false;grid.DataSource=table;
     ((Control)Get(sale,"Combo_PORT")).Text="";((Control)Get(sale,"Button_OPERATION")).Text="VENTE";
     var add=sale.GetType().GetMethod("Button_GO_Click",BindingFlags.Instance|BindingFlags.NonPublic);
     for(int click=0;click<3;click++){
      foreach(string name in new[]{"Text_ID_ARTICLE","Text_CODE","Text_ARTICLE","Text_FAMILLE","Text_GROUPE"})((Control)Get(sale,name)).Text=click<2?"CI_REPEAT":"CI_OTHER";
      foreach(string name in new[]{"Text_PRIX_A","Text_PRIX_MP","Text_TAUX_TVA","Text_PROMOTION","Text_PRIX_QTE","Text_PRIX_QTE_MIN"})((Control)Get(sale,name)).Text="0";
      ((Control)Get(sale,"Text_PRIXV")).Text="12.35";((Control)Get(sale,"Text_PRINTER")).Text="0";((Control)Get(sale,"Text_PRINTER_DUPLICATA")).Text="0";((Control)Get(sale,"Label_QTE")).Text="1";
      using(var button=new Button(){Name="CI_ADD_BASKET"})add.Invoke(sale,new object[]{button,EventArgs.Empty});
      lock(errors){if(errors.Count>0)throw new Exception("Basket update errors: "+string.Join(" | ",errors.ToArray()));}
      sql.Open();using(var c=sql.CreateCommand()){c.CommandText="SELECT ID FROM TABLE_CI_IDENTITY WHERE Code='CI_REPEAT'";if(Convert.ToInt64(c.ExecuteScalar())!=Convert.ToInt64(table.Rows[0]["ID"]))throw new Exception("Inserted basket ID is not synchronized");}sql.Close();
     }
     sql.Open();using(var c=sql.CreateCommand()){c.CommandText="SELECT COUNT(*),SUM(\x60Qté\x60),SUM(TOTAL_NET) FROM TABLE_CI_IDENTITY";using(var reader=c.ExecuteReader()){reader.Read();if(reader.GetInt32(0)!=2 || Convert.ToDecimal(reader.GetValue(1))!=3m || Math.Abs(Convert.ToDecimal(reader.GetValue(2))-37.05m)>0.00001m)throw new Exception("Repeated product quantity/total incorrect");}}
     using(var c=sql.CreateCommand()){c.CommandText="DELETE FROM TABLE_CI_IDENTITY";c.ExecuteNonQuery();}sql.Close();
    }
    adapter.Dispose();
   }
   Console.WriteLine("PASS repeated product adds and separate lines across two baskets with continuing AUTO_INCREMENT IDs");
   // Actual stale writes must still be rejected, rather than silently overwriting another change.
   using(var adapter=new MySqlDataAdapter("SELECT * FROM TABLE_CI_IDENTITY",sql))
   using(var builder=new MySqlCommandBuilder(adapter)){
    sql.Open();using(var c=sql.CreateCommand()){c.CommandText="INSERT INTO TABLE_CI_IDENTITY (Code,\x60Qté\x60,TOTAL_NET) VALUES ('STALE',1,12.35)";c.ExecuteNonQuery();}sql.Close();
    var table=new DataTable();adapter.Fill(table);module.GetField("da1").SetValue(null,adapter);module.GetField("dt1").SetValue(null,table);
    sql.Open();using(var c=sql.CreateCommand()){c.CommandText="UPDATE TABLE_CI_IDENTITY SET \x60Qté\x60=9 WHERE Code='STALE'";c.ExecuteNonQuery();}sql.Close();
    table.Rows[0]["Qté"]=2;bool rejected=false;
    try{module.GetMethod("SaveBasketChanges").Invoke(null,null);}catch(TargetInvocationException e){if(e.InnerException is DBConcurrencyException)rejected=true;else throw;}
    if(!rejected)throw new Exception("Real stale basket update was accepted");
    sql.Open();using(var c=sql.CreateCommand()){c.CommandText="SELECT \x60Qté\x60 FROM TABLE_CI_IDENTITY WHERE Code='STALE'";if(Convert.ToInt32(c.ExecuteScalar())!=9)throw new Exception("Concurrent quantity was overwritten");}sql.Close();
   }
   Console.WriteLine("PASS real concurrent basket changes remain protected");
  } finally {((Control)Get(template,"Label_POSTE")).Text=originalPost;if(sql.State==ConnectionState.Open)sql.Close();}
 }


 static void CheckPictureSales(Assembly assembly,Type module,object template,IDbConnection connection){
  var sql=(MySqlConnection)connection;string root=AppDomain.CurrentDomain.BaseDirectory;
  string directory=Path.Combine(root,"bd","images");Directory.CreateDirectory(directory);
  string photo=Path.Combine(directory,"CI wide photo.png");
  using(var bitmap=new System.Drawing.Bitmap(1000,200)){using(var g=System.Drawing.Graphics.FromImage(bitmap))g.Clear(System.Drawing.Color.Red);bitmap.Save(photo,System.Drawing.Imaging.ImageFormat.Png);}
  File.WriteAllText(Path.Combine(directory,"CI corrupt photo.png"),"invalid-image-test");
  sql.Open();using(var c=sql.CreateCommand()){
   c.CommandText="CREATE TABLE TABLE_CI_PICTURES LIKE TABLE_01; UPDATE TABLE_ARTICLES SET Famille=@family,Images='CI wide photo.png' WHERE Code='CI_RECOVERED_PRODUCT'; INSERT INTO TABLE_ARTICLES (ID_ARTICLE,Code,Article,Famille,Images,PRIX_V_1,PRIX_V_2,PRIX_A,PRIX_MP,TAUX_TVA,PROMOTION,PRINTER,PRINTER_DUPLICATA,FENETRE_PESAGE,PRIX_QTE,PRIX_QTE_MIN) VALUES ('CI_IMG_MISSING','CI_IMG_MISSING','CI image placeholder',@family,'0.png',5,5,0,0,0,0,'0','0','',0,0),('CI_IMG_CORRUPT','CI_IMG_CORRUPT','CI image corrupt',@family,'CI corrupt photo.png',6,6,0,0,0,0,'0','0','',0,0)";
   c.Parameters.AddWithValue("@family","CI pictures' category");c.ExecuteNonQuery();
  }sql.Close();
  string oldPost=((Control)Get(template,"Label_POSTE")).Text;string oldFolder=(string)module.GetField("_CHEMIN_FOLDER").GetValue(null);
  ((Control)Get(template,"Label_POSTE")).Text="CI_PICTURES";module.GetField("_CHEMIN_FOLDER").SetValue(null,Path.Combine(root,"old-computer-location"));
  try{
   using(var sale=(Form)Activator.CreateInstance(assembly.GetType("LOGICA.Form_3_VENTE",true)))
   using(var adapter=new MySqlDataAdapter("SELECT * FROM TABLE_CI_PICTURES",sql)){
    var table=new DataTable();adapter.Fill(table);module.GetField("da1").SetValue(null,adapter);module.GetField("dt1").SetValue(null,table);
    var grid=(DataGridView)Get(sale,"DataGridView1");grid.AutoGenerateColumns=false;grid.AllowUserToAddRows=false;grid.DataSource=table;
    var events=(System.ComponentModel.EventHandlerList)typeof(System.ComponentModel.Component).GetProperty("Events",BindingFlags.Instance|BindingFlags.NonPublic).GetValue(sale,null);
    var loadKey=typeof(Form).GetField("EVENT_LOAD",BindingFlags.Static|BindingFlags.NonPublic).GetValue(null);events.RemoveHandler(loadKey,events[loadKey]);
    ((TabControl)Get(sale,"TabControl2")).SelectedIndex=1;
    ((Control)Get(sale,"Button_PRIX")).Text="PRIX_1";((Control)Get(sale,"Button_OPERATION")).Text="VENTE";((Control)Get(sale,"Combo_PORT")).Text="";
    ((Control)Get(sale,"Text_THEME")).BackColor=System.Drawing.Color.FromArgb(22,106,238);
    ((Control)Get(sale,"TabControl2")).BringToFront();
    sale.Show();Application.DoEvents();
    var familyMethod=sale.GetType().GetMethod("FAM2_click");var flow=(FlowLayoutPanel)Get(sale,"FlowLayout_ARTICLES");
    using(var family=new Button(){Text="CI pictures' category"})familyMethod.Invoke(sale,new object[]{family,EventArgs.Empty});
    if(flow.Controls.Count!=3)throw new Exception("Picture category did not render all photo/missing/corrupt products");
    Button photoTile=null;foreach(Button tile in flow.Controls){if(tile.Image==null || tile.Image.Size!=new System.Drawing.Size(96,64))throw new Exception("Picture tile missing fitted image");if(Convert.ToString(tile.Tag)=="CI_RECOVERED_PRODUCT")photoTile=tile;}
    if(photoTile==null)throw new Exception("Real photo tile missing");
    var thumbnail=(System.Drawing.Bitmap)photoTile.Image;var center=thumbnail.GetPixel(48,32);var corner=thumbnail.GetPixel(1,1);
    if(center.R<230 || center.G>30 || corner.ToArgb()!=System.Drawing.Color.White.ToArgb())throw new Exception("Wide photo was distorted or failed to load from portable path");
    using(var unlocked=new FileStream(photo,FileMode.Open,FileAccess.ReadWrite,FileShare.None)){}
    using(var preview=new System.Drawing.Bitmap(Math.Max(1,flow.Width),Math.Max(1,Math.Min(flow.Height,160)))){flow.DrawToBitmap(preview,new System.Drawing.Rectangle(0,0,preview.Width,preview.Height));preview.Save(Path.Combine(root,"..","results","picture-tiles.png"));}
    for(int click=0;click<2;click++){((Control)Get(sale,"Label_QTE")).Text="1";typeof(Control).GetMethod("OnClick",BindingFlags.Instance|BindingFlags.NonPublic).Invoke(photoTile,new object[]{EventArgs.Empty});Application.DoEvents();}
    var oldTile=flow.Controls[0];using(var family=new Button(){Text="CI pictures' category"})familyMethod.Invoke(sale,new object[]{family,EventArgs.Empty});if(!oldTile.IsDisposed)throw new Exception("Old image tiles were not disposed");
    var search=(Control)Get(sale,"Text_FIND");search.Text="CI_IMG_MISSING";Application.DoEvents();
    if(flow.Controls.Count!=1 || Convert.ToString(flow.Controls[0].Tag)!="CI_IMG_MISSING")throw new Exception("Picture search hides a product with 0.png");
    ((Control)Get(sale,"Label_QTE")).Text="1";typeof(Control).GetMethod("OnClick",BindingFlags.Instance|BindingFlags.NonPublic).Invoke(flow.Controls[0],new object[]{EventArgs.Empty});Application.DoEvents();
    search.Text="CI_IMG_CORRUPT";Application.DoEvents();if(flow.Controls.Count!=1)throw new Exception("Corrupt photo product disappeared");
    ((Control)Get(sale,"Label_QTE")).Text="1";((Button)flow.Controls[0]).PerformClick();
    lock(errors){if(errors.Count>0)throw new Exception("Picture sales errors: "+string.Join(" | ",errors.ToArray()));}
    sql.Open();using(var c=sql.CreateCommand()){c.CommandText="SELECT COUNT(*),SUM(\x60Qté\x60),SUM(TOTAL_NET) FROM TABLE_CI_PICTURES";using(var reader=c.ExecuteReader()){reader.Read();Console.WriteLine("Picture sale saved lines="+reader.GetValue(0)+" quantity="+reader.GetValue(1)+" total="+reader.GetValue(2));if(Convert.ToInt32(reader.GetValue(0))!=3 || Convert.ToDecimal(reader.GetValue(1))!=4m || Convert.ToDecimal(reader.GetValue(2))!=35m)throw new Exception("Picture clicks did not save correct basket quantities and prices");}}sql.Close();
    Console.WriteLine("PASS picture category/search render real, missing and corrupt photos; wide image keeps aspect ratio; source file stays unlocked");
    Console.WriteLine("PASS clicking picture twice and placeholder/corrupt tiles persists 3 lines, 4 items, total 35");
   }
  }finally{((Control)Get(template,"Label_POSTE")).Text=oldPost;module.GetField("_CHEMIN_FOLDER").SetValue(null,oldFolder);if(sql.State==ConnectionState.Open)sql.Close();}
 }

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
   var stock=Get(config,"CheckBox_me_STOCK");
   bool desired=repeat==0;
   stock.GetType().GetProperty("Checked").SetValue(stock,desired,null);
   config.GetType().GetMethod("Button_SAVE_Click",BindingFlags.Instance|BindingFlags.NonPublic).Invoke(config,new object[]{new Button(){Name="CI_SAVE"},EventArgs.Empty});
   connection.Open();using(var c=connection.CreateCommand()){c.CommandText="SELECT VALEUR FROM TABLE_PARAMETRES WHERE OBJET='GESTION_STOCK'";if(Convert.ToBoolean(c.ExecuteScalar())!=desired)throw new Exception("Stock setting was not saved");}connection.Close();
   config.Close();
  }
  lock(errors){if(errors.Count>0)throw new Exception("Configuration errors: "+string.Join(" | ",errors.ToArray()));}
  if(saved!=2)throw new Exception("Settings save did not confirm success");
  Console.WriteLine("PASS configuration opens, saves stock option, restores it and reopens with receipt templates");
  login.GetType().GetMethod("Button_STOCK_Click",BindingFlags.Instance|BindingFlags.NonPublic).Invoke(login,new object[]{new Button(){Name="CI_STOCK"},EventArgs.Empty});
  Application.DoEvents();var articles=(Form)Get(forms,"Form_2_ARTICLES");
  foreach(Form opened in Application.OpenForms)if(opened.GetType().Name=="FormDialog_PATIENTER" && opened.Visible)throw new Exception("Loading dialog remained open after stock navigation");
  var products=(DataGridView)Get(articles,"DataGridView1");
  lock(errors){if(errors.Count>0)throw new Exception("Products load errors: "+string.Join(" | ",errors.ToArray()));}
  Console.WriteLine("Products loaded rows="+products.Rows.Count+" families="+((ComboBox)Get(articles,"Combo_FAMILLE")).Items.Count);
  if(products.Rows.Count!=30 || ((ComboBox)Get(articles,"Combo_FAMILLE")).Items.Count!=15)throw new Exception("Products or families failed to load");
  if(((Control)Get(articles,"TextBox_NBR_CODE_ARTICLE")).Text!="4")throw new Exception("Product barcode settings did not load");
  lock(errors){if(errors.Count>0)throw new Exception("Product page errors: "+string.Join(" | ",errors.ToArray()));}
  string imageDirectory=Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"bd","images");Directory.CreateDirectory(imageDirectory);
  if(!File.Exists(Path.Combine(imageDirectory,"0"))){using(var image=new System.Drawing.Bitmap(2,2))image.Save(Path.Combine(imageDirectory,"0"),System.Drawing.Imaging.ImageFormat.Png);}
  articles.GetType().GetMethod("Button_ADD_Click",BindingFlags.Instance|BindingFlags.Public).Invoke(articles,new object[]{new Button(){Name="CI_ADD"},EventArgs.Empty});
  ((Control)Get(articles,"Text_CODE")).Text="CI_RECOVERED_PRODUCT";
  ((Control)Get(articles,"Text_ARTICLE")).Text="CI recovered editor test";
  ((ComboBox)Get(articles,"Combo_FAMILLE")).SelectedIndex=0;
  ((Control)Get(articles,"Text_PRIX_A")).Text="7";
  ((Control)Get(articles,"Text_PRIX_V")).Text="12";
  articles.GetType().GetMethod("Button_SAVE_Click",BindingFlags.Instance|BindingFlags.NonPublic).Invoke(articles,new object[]{new Button(){Name="CI_SAVE_PRODUCT"},EventArgs.Empty});
  lock(errors){if(errors.Count>0)throw new Exception("Add product errors: "+string.Join(" | ",errors.ToArray()));}
  connection.Open();using(var c=connection.CreateCommand()){c.CommandText="SELECT COUNT(*) FROM TABLE_ARTICLES WHERE Code='CI_RECOVERED_PRODUCT' AND Prix_A=7 AND PRIX_V_1=12";if(Convert.ToInt32(c.ExecuteScalar())!=1 || productSaved!=1)throw new Exception("Original product save failed");}connection.Close();
  Console.WriteLine("PASS original Add and Save product handlers persist a new product and prices in isolated database");
  articles.Close();
  connection.Open();using(var c=connection.CreateCommand()){c.CommandText="SELECT COUNT(*) FROM TABLE_ARTICLES WHERE CAST(DATES AS CHAR)='1900-01-00 00:00:00'";if(Convert.ToInt32(c.ExecuteScalar())!=1)throw new Exception("Original incomplete date was changed");}
  module.GetMethod("EnsureRecoveredSettings").Invoke(null,null);module.GetMethod("EnsureRecoveredSettings").Invoke(null,null);
  using(var c=connection.CreateCommand()){c.CommandText="SELECT COUNT(*) FROM TABLE_PARAMETRES WHERE OBJET IN ('GROUPES','GROUPES_LISTE')";if(Convert.ToInt32(c.ExecuteScalar())!=2)throw new Exception("Compatibility settings duplicated");}
  connection.Close();
  Console.WriteLine("PASS products page loads 30 original products and 15 families; missing settings upgrade is idempotent");
  CheckBasketIdentity(a,module,form,connection);
  CheckPictureSales(a,module,form,connection);


 }else{
  if(!activationVisible)throw new Exception("Release activation behavior changed");
  Console.WriteLine("PASS Release retains original machine activation");
 }
 form.Dispose();return 0;
 }catch(Exception e){Console.WriteLine("FAIL "+e);return 1;}finally{stop=true;}}
}

