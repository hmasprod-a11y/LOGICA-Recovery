using System;
using System.IO;
using System.Reflection;
using System.Globalization;
using System.Windows.Forms;
using System.Drawing;
using System.Data;
class PosSmoke {
 const BindingFlags Flags=BindingFlags.Public|BindingFlags.NonPublic|BindingFlags.Instance|BindingFlags.Static;
 static object Get(object o,string name){return o.GetType().GetProperty(name,Flags).GetValue(o,null);}
 static void Eq(decimal actual,decimal expected,string label){if(actual!=expected)throw new Exception(label+" expected="+expected+" actual="+actual);Console.WriteLine("PASS "+label+" = "+actual);}
 static void Basket(Assembly assembly) {
  var module=assembly.GetType("LOGICA.Module1",true);
  using(var connection=(IDbConnection)module.GetField("cn_SQL").GetValue(null)) {
   if(!connection.ConnectionString.Contains("127.0.0.1") || !connection.ConnectionString.Contains("logica_ci"))throw new Exception("Test requires isolated database");
   connection.Open();
   var command=connection.CreateCommand();
   command.CommandText="CREATE TABLE IF NOT EXISTS TABLE_CI_TEST (TOTAL_NET DECIMAL(14,4));";command.ExecuteNonQuery();connection.Close();
   var forms=assembly.GetType("LOGICA.My.MyProject",true).GetProperty("Forms",Flags).GetValue(null,null);
   var template=Get(forms,"Form_0_TEMPLATE");
   ((Control)Get(template,"Label_POSTE")).Text="CI_TEST";
   using(var sale=(Form)Activator.CreateInstance(assembly.GetType("LOGICA.Form_3_VENTE",true))) {
    var grid=(DataGridView)Get(sale,"DataGridView1");grid.AllowUserToAddRows=false;
    ((Control)Get(sale,"Combo_PORT")).Text="";
    decimal[][] scenarios={new[]{2m,25m,3m,22.5m,47.5m,5m},new[]{0m,0m,0m,0m,0m,0m},new[]{-1m,-12.35m,0m,0m,-12.35m,-1m},new[]{1.25m,15.625m,0m,0m,15.625m,1.25m}};
    foreach(var data in scenarios) {
     connection.Open();command.CommandText="TRUNCATE TABLE TABLE_CI_TEST";command.ExecuteNonQuery();
     grid.Rows.Clear();
     for(int i=0;i<4;i+=2) if(data[i]!=0m){
      command.CommandText="INSERT INTO TABLE_CI_TEST VALUES ("+data[i+1].ToString(CultureInfo.InvariantCulture)+")";command.ExecuteNonQuery();
      int row=grid.Rows.Add();grid.Rows[row].Cells["Qté"].Value=data[i];grid.Rows[row].Cells["TOTAL_NET"].Value=data[i+1];
     }
     connection.Close();
     sale.GetType().GetMethod("Text_TOTAL_NET_Click").Invoke(sale,new object[]{sale,EventArgs.Empty});
     Eq(decimal.Parse(((Control)Get(sale,"Text_TOTAL_NET")).Text),Math.Round(data[4],2),"original POS database basket total");
     Eq(decimal.Parse(((Control)Get(sale,"Label_NBR_ARTICLES")).Text),data[5],"original POS quantity total");
    }
    string[] fields={"Text_ID_ARTICLE","Text_CODE","Text_ARTICLE","Text_FAMILLE","Text_PRIX_A","Text_PRIX_MP","Text_PRIXV","Text_TAUX_TVA","Text_PROMOTION","Text_PRINTER","Text_PRINTER_DUPLICATA","Text_GROUPE","Text_PRIX_QTE","Text_PRIX_QTE_MIN"};
    foreach(var name in fields)((Control)Get(sale,name)).Text="123";
    sale.GetType().GetMethod("_effacer_article_attributions").Invoke(sale,null);
    foreach(var name in fields)if(((Control)Get(sale,name)).Text!="")throw new Exception("Article reset failed: "+name);
    Console.WriteLine("PASS original POS clears 14 article fields");
   }
  }
 }
 static void Sql(IDbConnection connection,string sql) {using(var c=connection.CreateCommand()){c.CommandText=sql;c.ExecuteNonQuery();}}
 static decimal Scalar(IDbConnection connection,string sql) {using(var c=connection.CreateCommand()){c.CommandText=sql;return Convert.ToDecimal(c.ExecuteScalar());}}
 static void SetText(object form,string name,string value){((Control)Get(form,name)).Text=value;}
 static void Checkout(Assembly assembly) {
  CultureInfo.CurrentCulture=CultureInfo.GetCultureInfo("en-US");
  var module=assembly.GetType("LOGICA.Module1",true);
  var connection=(IDbConnection)module.GetField("cn_SQL").GetValue(null);
  if(!connection.ConnectionString.Contains("127.0.0.1") || !connection.ConnectionString.Contains("logica_ci"))throw new Exception("Checkout test requires isolated database");
  connection.Open();
  string columns="ID_ARTICLE,Code,Article,Famille,PRIX_A,PRIX_MP,PRIX_V,Qté,Remise,TOTAL_NET,TAUX_TVA,GROUPE";
  string journal="ID_TICKET,Ticket,Dates,Heure,"+columns+",Caissier,Vendeur,ID_CLIENT,CODE_CLIENT,CLIENT,POSTE,OPERATION,NOTES,NOTES_TYPE_PRIX,NOTES_MODE_P";
  string header="ID_TICKET,TICKET,DATES,CAISSIER,ID_CLIENT,CODE_CLIENT,CLIENT,POSTE,Total_NET,OPERATION";
  string payments="ID_TICKET,TICKET,DATES,CAISSIER,ID_CLIENT,CODE_CLIENT,CLIENT,POSTE,MONTANT,MODE_P,OPERATION,NOTES_REMARQUE";
  string[] tables={"TABLE_CI_TEST","TABLE_VENTES_JOURNAL","TABLE_VENTES_ENTETE","TABLE_VENTES_REGLEMENTS","TABLE_MOUVEMENTS_STOCK"};
  string[] schemas={columns+",PRINTER,PRINTER_DUPLICATA",journal,header,payments,"DATES,HEURE,LIBELLE,ID_ARTICLE,CODE_ARTICLE,ARTICLE,QUANTITE"};
  for(int i=0;i<tables.Length;i++) {
   Sql(connection,"DROP TABLE IF EXISTS "+tables[i]);
   string defs="ID INT AUTO_INCREMENT PRIMARY KEY";
   foreach(var col in schemas[i].Split(','))defs+=",`"+col+"` VARCHAR(255) DEFAULT ''";
   Sql(connection,"CREATE TABLE "+tables[i]+" ("+defs+") ENGINE=InnoDB");
  }
  Sql(connection,"DROP TABLE IF EXISTS TABLE_ARTICLES; CREATE TABLE TABLE_ARTICLES (ID_ARTICLE INT, Code VARCHAR(30), Article VARCHAR(100), STOCK DECIMAL(14,3)) ENGINE=InnoDB; INSERT INTO TABLE_ARTICLES VALUES (1,'CI001','CI product',10)");
  Sql(connection,"DROP TABLE IF EXISTS TABLE_NUM; CREATE TABLE TABLE_NUM (ID INT, CL INT) ENGINE=InnoDB; INSERT INTO TABLE_NUM VALUES (0,1)");
  connection.Close();
  var forms=assembly.GetType("LOGICA.My.MyProject",true).GetProperty("Forms",Flags).GetValue(null,null);
  var template=Get(forms,"Form_0_TEMPLATE");SetText(template,"Label_POSTE","CI_TEST");
  var list=(ListView)Get(template,"ListView1");list.Items.Add("BLOCAGE_STOCK_INSUFFISANT").SubItems.Add("False");
  using(var sale=(Form)Activator.CreateInstance(assembly.GetType("LOGICA.Form_3_VENTE",true))) {
   var grid=(DataGridView)Get(sale,"DataGridView1");grid.AllowUserToAddRows=false;
   foreach(var n in new[]{"Check_CHOIX_VENDEUR","Check_CHOIX_CLIENT","Check_ACCES_MODEP","Check_ACCES_RFID"})Get(sale,n).GetType().GetProperty("Checked").SetValue(Get(sale,n),false,null);
   Get(sale,"Check_STOCK").GetType().GetProperty("Checked").SetValue(Get(sale,"Check_STOCK"),true,null);
   SetText(sale,"Combo_PORT","");SetText(sale,"Text_HEURE_RETARD","0");SetText(sale,"Text_PRINTER_SOLDER","0");SetText(sale,"Button_CAISSIER","CI cashier");
   foreach(int quantity in new[]{2,-1}) {
    connection.Open();
    Sql(connection,"INSERT INTO TABLE_CI_TEST ("+columns+",PRINTER,PRINTER_DUPLICATA) VALUES ('1','CI001','CI product','Test','5','5','12.5','"+quantity+"','0','"+(quantity*12.5m).ToString(CultureInfo.InvariantCulture)+"','0','','0','0')");
    connection.Close();
    grid.DataSource=null;grid.Rows.Clear();int row=grid.Rows.Add();
    grid.Rows[row].Cells["Qté"].Value=quantity;grid.Rows[row].Cells["TOTAL_NET"].Value=quantity*12.5m;
    grid.Rows[row].Cells["ID_ARTICLE"].Value=1;grid.Rows[row].Cells["Code"].Value="CI001";grid.Rows[row].Cells["Article"].Value="CI product";
    grid.Rows[row].Cells["PRINTER"].Value="0";grid.Rows[row].Cells["PRINTER_DUPLICATA"].Value="0";
    SetText(sale,"Button_OPERATION",quantity>0?"VENTE":"RETOUR");
    sale.GetType().GetMethod("Text_TOTAL_NET_Click").Invoke(sale,new object[]{sale,EventArgs.Empty});
    using(var sender=new Button(){Name="CI_CASH_CHECKOUT"})sale.GetType().GetMethod("Button_Click",Flags).Invoke(sale,new object[]{sender,EventArgs.Empty});
    connection.Open();
    Eq(Scalar(connection,"SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE=1"),quantity>0?8m:9m,"original checkout stock after "+(quantity>0?"sale":"return"));
    Eq(Scalar(connection,"SELECT COUNT(*) FROM TABLE_VENTES_ENTETE"),quantity>0?1m:2m,"original checkout ticket persisted");
    Eq(Scalar(connection,"SELECT COUNT(*) FROM TABLE_VENTES_JOURNAL"),quantity>0?1m:2m,"original checkout sales journal persisted");
    Eq(Scalar(connection,"SELECT SUM(MONTANT) FROM TABLE_VENTES_REGLEMENTS"),quantity>0?25m:12.5m,"original checkout cash payment/refund persisted");
    Eq(Scalar(connection,"SELECT COUNT(*) FROM TABLE_CI_TEST"),0m,"original checkout clears basket in database");
    Eq(Scalar(connection,"SELECT CL FROM TABLE_NUM WHERE ID=0"),quantity>0?2m:3m,"original checkout increments ticket sequence");
    Eq(Scalar(connection,"SELECT SUM(QUANTITE) FROM TABLE_MOUVEMENTS_STOCK"),quantity>0?-2m:-1m,"original checkout stock movements persisted");
    connection.Close();
   }
  }
 }

 [STAThread] static int Main(string[] args) {
  try {
   Application.EnableVisualStyles();
   var assembly=Assembly.LoadFrom(Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"LOGICA.exe"));
   if(args[0]=="checkout") { Checkout(assembly); } else if(args[0]=="basket") { Basket(assembly); } else if(args[0]=="rounding") {
    var method=assembly.GetType("LOGICA.Module1",true).GetMethod("FLOUSS");
    foreach(var culture in new[]{"fr-MA","fr-FR","en-US"}) {
     CultureInfo.CurrentCulture=CultureInfo.GetCultureInfo(culture);
     decimal[] values={0m,1.005m,12.345m,-1.005m,9999.995m};
     decimal[] expected={0m,1.01m,12.35m,-1.01m,10000m};
     for(int i=0;i<values.Length;i++) {
      var result=(decimal)method.Invoke(null,new object[]{values[i]});
      if(result!=expected[i])throw new Exception("FLOUSS incorrect: "+values[i]+" -> "+result);
      Console.WriteLine("PASS monetary rounding "+culture+" "+values[i]+" = "+result);
     }
    }
   } else {
    string name=args[0];
    using(var form=(Form)Activator.CreateInstance(assembly.GetType("LOGICA."+name,true))) {
     if(form.Controls.Count==0)throw new Exception("No controls initialized");
     Console.WriteLine("PASS original form constructor "+name+" controls="+form.Controls.Count);
     // Handle creation exercises native controls, Bunifu initialization and .sni loading.
     var handle=form.Handle;
     Console.WriteLine("PASS native window handle "+name+" "+handle);
     using(var bitmap=new Bitmap(Math.Max(1,form.Width),Math.Max(1,form.Height))) {
      form.DrawToBitmap(bitmap,new Rectangle(0,0,bitmap.Width,bitmap.Height));
      bitmap.Save(Path.Combine("..","results",name+".png"));
     }
     Console.WriteLine("PASS render original form "+name);
    }
   }
   return 0;
  } catch(Exception e) {Console.WriteLine("FAIL "+e); return 1;}
 }
}
