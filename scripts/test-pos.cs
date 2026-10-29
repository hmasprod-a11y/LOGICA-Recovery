using System;
using System.IO;
using System.Reflection;
using System.Globalization;
using System.Windows.Forms;
using System.Drawing;
using System.Data;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
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
     Eq(decimal.Parse(((Control)Get(sale,"Text_TOTAL_NET")).Text),Math.Round(data[4],2,MidpointRounding.AwayFromZero),"original POS database basket total");
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
 delegate bool WindowVisitor(IntPtr window, IntPtr parameter);
 [DllImport("kernel32.dll")] static extern uint GetCurrentThreadId();
 [DllImport("user32.dll")] static extern bool EnumThreadWindows(uint threadId, WindowVisitor visitor, IntPtr parameter);
 [DllImport("user32.dll")] static extern bool EnumChildWindows(IntPtr parent, WindowVisitor visitor, IntPtr parameter);
 [DllImport("user32.dll",CharSet=CharSet.Unicode)] static extern int GetWindowText(IntPtr window, StringBuilder text, int maximum);
 [DllImport("user32.dll",CharSet=CharSet.Unicode)] static extern int GetClassName(IntPtr window, StringBuilder text, int maximum);
 [DllImport("user32.dll")] static extern bool PostMessage(IntPtr window, uint message, IntPtr wParam, IntPtr lParam);
 static bool DismissInjectedFailure(uint threadId,string expectedText=null) {
  bool dismissed=false;
  EnumThreadWindows(threadId,delegate(IntPtr window,IntPtr unused) {
   var name=new StringBuilder(256);GetClassName(window,name,name.Capacity);
   if(name.ToString()!="#32770")return true;
   if(expectedText!=null) {
    bool matched=false;
    EnumChildWindows(window,delegate(IntPtr child,IntPtr parameter) {
     var text=new StringBuilder(4096);GetWindowText(child,text,text.Capacity);
     if(text.ToString().Contains(expectedText))matched=true;
     return true;
    },IntPtr.Zero);
    if(!matched)return true;
   }
   // Scoped to the isolated test thread during the injected-failure call.
   // A nontransactional fixture marker separately proves that our trigger was reached.
   dismissed=PostMessage(window,0x0010,IntPtr.Zero,IntPtr.Zero) || dismissed;
   return true;
  },IntPtr.Zero);
  return dismissed;
 }
 static Form PreparePaymentFixture(object forms,Type module,decimal total,string settlement) {
  var dialog=(Form)Get(forms,"FormDialog_calc");
  // Exercise checkout persistence with an accepted dialog fixture, not payment-dialog UX.
  var events=(EventHandlerList)typeof(Component).GetProperty("Events",BindingFlags.Instance|BindingFlags.NonPublic).GetValue(dialog,null);
  foreach(var keyName in new[]{"EVENT_LOAD","EVENT_SHOWN","EVENT_ACTIVATED"}) {
   var field=typeof(Form).GetField(keyName,BindingFlags.Static|BindingFlags.NonPublic);
   if(field!=null){var key=field.GetValue(null);events.RemoveHandler(key,events[key]);}
  }
  var grid=(DataGridView)Get(dialog,"DataGridView_CALC");
  var changed=(DataGridViewCellEventHandler)Delegate.CreateDelegate(typeof(DataGridViewCellEventHandler),dialog,dialog.GetType().GetMethod("DataGridView1_CellValueChanged",Flags));
  grid.CellValueChanged-=changed;
  grid.AllowUserToAddRows=false;grid.Rows.Clear();
  SetText(dialog,"Text_TOTAL_NET",total.ToString(CultureInfo.InvariantCulture));
  if(settlement=="mixed") {
   grid.Rows.Add(new object[]{15m,15m,0m,"CARTE",null});
   grid.Rows.Add(new object[]{10m,10m,0m,"ESPECES",null});
   SetText(dialog,"Button_RESTE","0");
  } else {
   grid.Rows.Add(new object[]{25m,30m,5m,"ESPECES",null});
   SetText(dialog,"Button_RESTE","-5");
  }
  SetText(dialog,"Text_REMARQUE","CI accepted payment fixture");
  dialog.Shown+=delegate {
   module.GetField("_quittersolder",Flags).SetValue(null,false);
   dialog.DialogResult=DialogResult.OK;
   dialog.Close();
  };
  return dialog;
 }
 static Form PrepareSelectionFixture(object forms,bool seller,Action<Form> onShown) {
  var dialog=(Form)Get(forms,seller?"Form_5_VENDEURS_LISTE":"Form_5_CLIENTS_LISTE");
  // Isolate the checkout routing contract from chooser data loading and selection UX.
  var events=(EventHandlerList)typeof(Component).GetProperty("Events",BindingFlags.Instance|BindingFlags.NonPublic).GetValue(dialog,null);
  foreach(var keyName in new[]{"EVENT_LOAD","EVENT_SHOWN","EVENT_ACTIVATED"}) {
   var field=typeof(Form).GetField(keyName,BindingFlags.Static|BindingFlags.NonPublic);
   if(field!=null){var key=field.GetValue(null);events.RemoveHandler(key,events[key]);}
  }
  dialog.Shown+=delegate {
   onShown(dialog);
   dialog.DialogResult=DialogResult.Cancel;
   dialog.Close();
  };
  return dialog;
 }
 static void Checkout(Assembly assembly,bool rollbackProbe=false,string settlement="cash",bool lateFailure=false) {
  CultureInfo.CurrentCulture=CultureInfo.GetCultureInfo("en-US");
  var module=assembly.GetType("LOGICA.Module1",true);
  var connection=(IDbConnection)module.GetField("cn_SQL").GetValue(null);
  if(!connection.ConnectionString.Contains("127.0.0.1") || !connection.ConnectionString.Contains("logica_ci"))throw new Exception("Checkout test requires isolated database");
  if(rollbackProbe) {
   var fixture=new System.Data.Common.DbConnectionStringBuilder();
   fixture.ConnectionString=connection.ConnectionString;
   if(connection.Database!="logica_ci" || !fixture.ContainsKey("server") || Convert.ToString(fixture["server"])!="127.0.0.1" ||
      !fixture.ContainsKey("port") || Convert.ToInt32(fixture["port"])!=3307)
    throw new Exception("Rollback probe requires exactly 127.0.0.1:3307/logica_ci");
  }
  connection.Open();
  decimal initialStock=settlement=="stock-exact"?2m:(settlement.StartsWith("reject-stock")?1m:10m);
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
  if(initialStock!=10m)Sql(connection,"UPDATE TABLE_ARTICLES SET STOCK="+initialStock.ToString(CultureInfo.InvariantCulture));
  if(settlement=="stock-missing-lookup")Eq(Scalar(connection,"SELECT COUNT(*) FROM TABLE_ARTICLES WHERE Code='CI_MISSING'"),0m,"missing stock lookup fixture has no match");
  Sql(connection,"DROP TABLE IF EXISTS TABLE_NUM; CREATE TABLE TABLE_NUM (ID INT, CL INT) ENGINE=InnoDB; INSERT INTO TABLE_NUM VALUES (0,1)");
  connection.Close();
  var forms=assembly.GetType("LOGICA.My.MyProject",true).GetProperty("Forms",Flags).GetValue(null,null);
  var template=Get(forms,"Form_0_TEMPLATE");SetText(template,"Label_POSTE","CI_TEST");
  var list=(ListView)Get(template,"ListView1");list.Items.Add("BLOCAGE_STOCK_INSUFFISANT").SubItems.Add("False");
  bool stockGuard=settlement.StartsWith("reject-stock") || settlement=="stock-exact" || settlement=="stock-missing-lookup";
  if(stockGuard) {
   list.FindItemWithText("BLOCAGE_STOCK_INSUFFISANT",false,0).SubItems[1].Text="True";
   var basketModel=new DataTable();
   basketModel.Columns.Add("Code",typeof(string));basketModel.Columns.Add("Qté",typeof(decimal));
   basketModel.Rows.Add(settlement=="stock-missing-lookup"?"CI_MISSING":"CI001",2m);
   module.GetField("dt1",Flags).SetValue(null,basketModel);
  }
  int scenario=0;
  foreach(decimal quantity in rollbackProbe?new[]{2m,-1m,2m}:((settlement=="cash" || settlement=="stock-off")?new[]{2m,-1m}:(settlement=="fractional"?new[]{1.25m}:new[]{2m}))) {
  bool injectFailure=rollbackProbe && scenario++==2;
  using(var sale=(Form)Activator.CreateInstance(assembly.GetType("LOGICA.Form_3_VENTE",true))) {
   var grid=(DataGridView)Get(sale,"DataGridView1");grid.AllowUserToAddRows=false;
   foreach(var n in new[]{"Check_CHOIX_VENDEUR","Check_CHOIX_CLIENT","Check_ACCES_MODEP","Check_ACCES_RFID"})Get(sale,n).GetType().GetProperty("Checked").SetValue(Get(sale,n),false,null);
   bool stockEnabled=settlement!="stock-off" && settlement!="reject-stock-off";
   Get(sale,"Check_STOCK").GetType().GetProperty("Checked").SetValue(Get(sale,"Check_STOCK"),stockEnabled,null);
   bool paymentDialog=settlement=="mixed" || settlement=="change";
   Get(sale,"Check_ACCES_MODEP").GetType().GetProperty("Checked").SetValue(Get(sale,"Check_ACCES_MODEP"),paymentDialog,null);
   SetText(sale,"Combo_PORT","");SetText(sale,"Text_HEURE_RETARD","0");SetText(sale,"Text_PRINTER_SOLDER","0");SetText(sale,"Button_CAISSIER","CI cashier");SetText(sale,"Button_VENDEUR","CI vendor");SetText(sale,"Button_PRIX","PRIX_1");
    connection.Open();
    Sql(connection,"INSERT INTO TABLE_CI_TEST ("+columns+",PRINTER,PRINTER_DUPLICATA) VALUES ('1','CI001','CI product','Test','5','5','12.5','"+quantity+"','0','"+(quantity*12.5m).ToString(CultureInfo.InvariantCulture)+"','0','','0','0')");
    connection.Close();
    grid.DataSource=null;grid.Rows.Clear();int row=grid.Rows.Add();
    grid.Rows[row].Cells["Qté"].Value=quantity;grid.Rows[row].Cells["TOTAL_NET"].Value=quantity*12.5m;
    grid.Rows[row].Cells["ID_ARTICLE"].Value=1;grid.Rows[row].Cells["Code"].Value="CI001";grid.Rows[row].Cells["Article"].Value="CI product";
    grid.Rows[row].Cells["PRINTER"].Value="0";grid.Rows[row].Cells["PRINTER_DUPLICATA"].Value="0";
    SetText(sale,"Button_OPERATION",settlement=="credit"?"CREDIT":(quantity>0?"VENTE":"RETOUR"));
    sale.GetType().GetMethod("Text_TOTAL_NET_Click").Invoke(sale,new object[]{sale,EventArgs.Empty});
    bool rejected=settlement.StartsWith("reject-");
    bool selection=settlement.StartsWith("select-");
    int selectionShown=0;
    bool selectionContextCorrect=false;
    Form selectionDialog=null;
    if(selection) {
     bool seller=settlement=="select-seller";
     SetText(sale,seller?"Button_VENDEUR":"Button_CLIENT","");
     string requiredFlag=seller?"Check_CHOIX_VENDEUR":"Check_CHOIX_CLIENT";
     if(settlement!="select-credit-client")Get(sale,requiredFlag).GetType().GetProperty("Checked").SetValue(Get(sale,requiredFlag),true,null);
     selectionDialog=PrepareSelectionFixture(forms,seller,delegate(Form dialog) {
      selectionShown++;
      selectionContextCorrect=seller || ((Control)Get(dialog,"Label1")).Text==sale.Name;
     });
    }
    if(settlement=="reject-sale")SetText(sale,"Text_TOTAL_NET","-25");
    if(settlement=="reject-return") { SetText(sale,"Button_OPERATION","RETOUR");SetText(sale,"Text_TOTAL_NET","25"); }
    if(settlement=="reject-empty")grid.Rows.Clear();
    if(settlement=="reject-total")grid.Rows[0].Cells["TOTAL_NET"].Value=27m;
    if(settlement=="rounding-window")grid.Rows[0].Cells["TOTAL_NET"].Value=25.4m;
    bool senderEnabled=false;
    Form acceptedPayment=paymentDialog?PreparePaymentFixture(forms,module,quantity*12.5m,settlement):null;
    int dismissedErrors=0;
    using(var stopWatcher=new ManualResetEvent(false)) {
     uint threadId=GetCurrentThreadId();
     Thread watcher=null;
     if(injectFailure) {
      connection.Open();
      Sql(connection,"DROP TABLE IF EXISTS TABLE_CI_ROLLBACK_PROBE; CREATE TABLE TABLE_CI_ROLLBACK_PROBE (Attempts INT, PaymentRows INT, BasketRows INT) ENGINE=MEMORY; INSERT INTO TABLE_CI_ROLLBACK_PROBE VALUES (0,0,0)");
      Sql(connection,"CREATE TRIGGER CI_ROLLBACK_PROBE BEFORE "+(lateFailure?"UPDATE ON TABLE_NUM":"INSERT ON TABLE_VENTES_JOURNAL")+" FOR EACH ROW BEGIN UPDATE TABLE_CI_ROLLBACK_PROBE SET Attempts=Attempts+1, PaymentRows=(SELECT COUNT(*) FROM TABLE_VENTES_REGLEMENTS), BasketRows=(SELECT COUNT(*) FROM TABLE_CI_TEST); SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'CI_ROLLBACK_PROBE'; END");
      connection.Close();
     }
     if(injectFailure || (rejected && settlement!="reject-empty")) {
      string expectedDialog=rejected?(settlement=="reject-sale"?"Positif":(settlement=="reject-total"?"Le Total Net":(settlement.StartsWith("reject-stock")?"stock insuffisant":"(RETOUR)"))):null;
      watcher=new Thread(delegate() {
       while(!stopWatcher.WaitOne(100)) {
        if(DismissInjectedFailure(threadId,expectedDialog))Interlocked.Increment(ref dismissedErrors);
       }
      });
      watcher.IsBackground=true;
      watcher.Start();
     }
     try {
      using(var sender=new Button(){Name=settlement=="select-credit-client"?"Button_SOLDER_CREDIT":"CI_CASH_CHECKOUT"}) {
       sale.GetType().GetMethod("Button_Click",Flags).Invoke(sale,new object[]{sender,EventArgs.Empty});
       senderEnabled=sender.Enabled;
      }
     } finally {
      if(acceptedPayment!=null)acceptedPayment.Dispose();
      if(selectionDialog!=null)selectionDialog.Dispose();
      stopWatcher.Set();
      if(watcher!=null && !watcher.Join(2000))throw new Exception("Checkout dialog watcher did not stop");
      if(injectFailure) {
       if(connection.State!=ConnectionState.Open)connection.Open();
       Sql(connection,"DROP TRIGGER IF EXISTS CI_ROLLBACK_PROBE");
      }
     }
    }
    if(connection.State!=ConnectionState.Open)connection.Open();
    if(rejected || selection) {
     if(!senderEnabled)throw new Exception("Rejected checkout did not re-enable sender");
     if(rejected && (settlement=="reject-empty"?dismissedErrors!=0:dismissedErrors==0))throw new Exception("Unexpected rejection dialog behavior");
     if(selection && (selectionShown!=1 || !selectionContextCorrect))throw new Exception("Selection routing or caller context changed");
     Eq(Scalar(connection,"SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE=1"),initialStock,"rejection preserves stock");
     Eq(Scalar(connection,"SELECT COUNT(*) FROM TABLE_VENTES_ENTETE"),0m,"rejection writes no header");
     Eq(Scalar(connection,"SELECT COUNT(*) FROM TABLE_VENTES_JOURNAL"),0m,"rejection writes no journal");
     Eq(Scalar(connection,"SELECT COUNT(*) FROM TABLE_VENTES_REGLEMENTS"),0m,"rejection writes no payment");
     Eq(Scalar(connection,"SELECT COUNT(*) FROM TABLE_MOUVEMENTS_STOCK"),0m,"rejection writes no movement");
     Eq(Scalar(connection,"SELECT COUNT(*) FROM TABLE_CI_TEST"),1m,"rejection retains database basket");
     Eq(Scalar(connection,"SELECT CL FROM TABLE_NUM WHERE ID=0"),1m,"rejection preserves ticket sequence");
     connection.Close();
     Console.WriteLine("PASS "+settlement+" leaves persistence unchanged and sender enabled");
     continue;
    }
    if(injectFailure) {
     if(dismissedErrors==0)throw new Exception("Injected checkout error was not observed");
     Eq(Scalar(connection,"SELECT Attempts FROM TABLE_CI_ROLLBACK_PROBE"),1m,"injected failure trigger reached");
     if(lateFailure) {
      Eq(Scalar(connection,"SELECT PaymentRows FROM TABLE_CI_ROLLBACK_PROBE"),3m,"late failure occurs after attempted payment insert");
      Eq(Scalar(connection,"SELECT BasketRows FROM TABLE_CI_ROLLBACK_PROBE"),0m,"late failure occurs after attempted basket clear");
     }
     Sql(connection,"DROP TABLE TABLE_CI_ROLLBACK_PROBE");
     Eq(Scalar(connection,"SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE=1"),9m,"rollback preserves stock");
     Eq(Scalar(connection,"SELECT COUNT(*) FROM TABLE_VENTES_ENTETE"),2m,"rollback removes attempted header");
     Eq(Scalar(connection,"SELECT COUNT(*) FROM TABLE_VENTES_JOURNAL"),2m,"rollback preserves prior journal");
     Eq(Scalar(connection,"SELECT SUM(MONTANT) FROM TABLE_VENTES_REGLEMENTS"),12.5m,"rollback preserves payments");
     Eq(Scalar(connection,"SELECT COUNT(*) FROM TABLE_CI_TEST"),1m,"rollback retains basket");
     Eq(Scalar(connection,"SELECT CL FROM TABLE_NUM WHERE ID=0"),3m,"rollback preserves ticket sequence");
     Eq(Scalar(connection,"SELECT SUM(QUANTITE) FROM TABLE_MOUVEMENTS_STOCK"),-1m,"rollback removes attempted stock movement");
     connection.Close();
     Console.WriteLine(lateFailure?"PASS late failure rolls back payment and basket completion":"PASS injected journal failure rolls back checkout");
     continue;
    }
    Eq(Scalar(connection,"SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE=1"),!stockEnabled?initialStock:(quantity>0?initialStock-quantity:initialStock-1m),"original checkout stock after "+(quantity>0?"sale":"return"));
    Eq(Scalar(connection,"SELECT COUNT(*) FROM TABLE_VENTES_ENTETE"),quantity>0?1m:2m,"original checkout ticket persisted");
    string expectedTicket=quantity>0?"000001":"000002";
    string expectedOperation=settlement=="credit"?"CREDIT":(quantity>0?"VENTE":"RETOUR REMBOURSEMENT");
    string expectedPaymentNotes=settlement=="mixed"?"CARTE;ESPECES;":(settlement=="credit"?"":"ESPECES;");
    Eq(Scalar(connection,"SELECT Total_NET FROM TABLE_VENTES_ENTETE WHERE TICKET='"+expectedTicket+"'"),Math.Round(quantity*12.5m,2,MidpointRounding.AwayFromZero),"header total and ticket preserved");
    Eq(Scalar(connection,"SELECT COUNT(*) FROM TABLE_VENTES_ENTETE WHERE TICKET='"+expectedTicket+"' AND CAISSIER='CI cashier' AND POSTE='CI_TEST' AND OPERATION='"+expectedOperation+"'"),1m,"header cashier workstation operation preserved");
    Eq(Scalar(connection,"SELECT COUNT(*) FROM TABLE_VENTES_JOURNAL"),quantity>0?1m:2m,"original checkout sales journal persisted");
    Eq(Scalar(connection,"SELECT TOTAL_NET FROM TABLE_VENTES_JOURNAL WHERE Ticket='"+expectedTicket+"'"),quantity*12.5m,"journal signed line total preserved");
    Eq(Scalar(connection,"SELECT Qté FROM TABLE_VENTES_JOURNAL WHERE Ticket='"+expectedTicket+"'"),quantity,"journal signed quantity preserved");
    Eq(Scalar(connection,"SELECT COUNT(*) FROM TABLE_VENTES_JOURNAL WHERE Ticket='"+expectedTicket+"' AND Code='CI001' AND Article='CI product' AND PRIX_V='12.5' AND Remise='0'"),1m,"journal basket fields copied");
    Eq(Scalar(connection,"SELECT COUNT(*) FROM TABLE_VENTES_JOURNAL WHERE Ticket='"+expectedTicket+"' AND Caissier='CI cashier' AND Vendeur='CI vendor' AND POSTE='CI_TEST' AND OPERATION='"+expectedOperation+"' AND NOTES_TYPE_PRIX='PRIX_1' AND NOTES_MODE_P='"+expectedPaymentNotes+"'"),1m,"journal checkout context preserved");
    Eq(Scalar(connection,"SELECT COALESCE(SUM(MONTANT),0) FROM TABLE_VENTES_REGLEMENTS"),settlement=="credit"?0m:(quantity>0?Math.Round(quantity*12.5m,2,MidpointRounding.AwayFromZero):12.5m),"checkout net payment preserved");
    if(settlement=="mixed") {
     Eq(Scalar(connection,"SELECT COUNT(*) FROM TABLE_VENTES_REGLEMENTS"),2m,"mixed payment row count");
     Eq(Scalar(connection,"SELECT SUM(MONTANT) FROM TABLE_VENTES_REGLEMENTS WHERE MODE_P='CARTE'"),15m,"mixed card amount");
     Eq(Scalar(connection,"SELECT SUM(MONTANT) FROM TABLE_VENTES_REGLEMENTS WHERE MODE_P='ESPECES'"),10m,"mixed cash amount");
    } else if(settlement=="change") {
     Eq(Scalar(connection,"SELECT COUNT(*) FROM TABLE_VENTES_REGLEMENTS"),2m,"overpayment and cash change rows");
     Eq(Scalar(connection,"SELECT COUNT(*) FROM TABLE_VENTES_REGLEMENTS WHERE MONTANT='30'"),1m,"tendered cash preserved");
     Eq(Scalar(connection,"SELECT COUNT(*) FROM TABLE_VENTES_REGLEMENTS WHERE MONTANT='-5' AND MODE_P='ESPECES'"),1m,"negative cash change preserved");
    } else if(settlement=="credit") {
     Eq(Scalar(connection,"SELECT COUNT(*) FROM TABLE_VENTES_REGLEMENTS"),0m,"credit does not create payment rows");
    }
    Eq(Scalar(connection,"SELECT COUNT(*) FROM TABLE_CI_TEST"),0m,"original checkout clears basket in database");
    Eq(Scalar(connection,"SELECT CL FROM TABLE_NUM WHERE ID=0"),quantity>0?2m:3m,"original checkout increments ticket sequence");
    Eq(Scalar(connection,"SELECT COALESCE(SUM(QUANTITE),0) FROM TABLE_MOUVEMENTS_STOCK"),!stockEnabled?0m:(quantity>0?-quantity:-1m),"original checkout stock movements persisted");
    Eq(Scalar(connection,"SELECT COUNT(*) FROM TABLE_MOUVEMENTS_STOCK WHERE ID_ARTICLE='1' AND CODE_ARTICLE='CI001' AND ARTICLE='CI product'"),!stockEnabled?0m:(quantity>0?1m:2m),"movement article identity preserved");
    Eq(Scalar(connection,"SELECT COUNT(*) FROM TABLE_MOUVEMENTS_STOCK WHERE LIBELLE="+(quantity>0?"'TICKET | 000001'":"'TICKET | 000002'")),stockEnabled?1m:0m,"movement ticket reference preserved");
    connection.Close();
   }
  }
 }

 static void CatalogueSaveGuards(Assembly assembly) {
  var module=assembly.GetType("LOGICA.Module1",true);
  var connection=(IDbConnection)module.GetField("cn_SQL").GetValue(null);
  var fixture=new System.Data.Common.DbConnectionStringBuilder();fixture.ConnectionString=connection.ConnectionString;
  if(connection.Database!="logica_ci" || !fixture.ContainsKey("server") || Convert.ToString(fixture["server"])!="127.0.0.1" ||
     !fixture.ContainsKey("port") || Convert.ToInt32(fixture["port"])!=3307)
   throw new Exception("Catalogue guard fixture requires exactly 127.0.0.1:3307/logica_ci");
  connection.Open();
  Sql(connection,"DROP TABLE IF EXISTS TABLE_ARTICLES; CREATE TABLE TABLE_ARTICLES (ID INT, Code VARCHAR(50), Article VARCHAR(100)) ENGINE=InnoDB; INSERT INTO TABLE_ARTICLES VALUES (1,'CI_KEEP','CI sentinel')");
  Sql(connection,"DROP TABLE IF EXISTS TABLE_MOUVEMENTS_STOCK; CREATE TABLE TABLE_MOUVEMENTS_STOCK (ID INT) ENGINE=InnoDB; INSERT INTO TABLE_MOUVEMENTS_STOCK VALUES (1)");
  Sql(connection,"DROP TABLE IF EXISTS TABLE_NUM; CREATE TABLE TABLE_NUM (ID INT, ARTICLE INT) ENGINE=InnoDB; INSERT INTO TABLE_NUM VALUES (0,7)");
  connection.Close();
  string[][] cases={new[]{"","CI's untouched","-Code-"},new[]{"  ","CI's untouched","-Code-"},new[]{"CI_REQUIRED","","-Article-"},new[]{"CI_REQUIRED","  ","-Article-"},new[]{"CI_REQUIRED","CI's untouched","-PROMOTION-",""},new[]{"CI_REQUIRED","CI's untouched","-PROMOTION-","101"},new[]{"CI_REQUIRED","CI's untouched","-PROMOTION-","1000"},new[]{"CI_REQUIRED","CI's untouched","-IMAGE-","-1"},new[]{"CI_REQUIRED","CI's untouched","-IMAGE-","0"},new[]{"CI_REQUIRED","CI's untouched","-IMAGE-","100"}};
  foreach(var data in cases) {
   using(var form=(Form)Activator.CreateInstance(assembly.GetType("LOGICA.Form_2_ARTICLES",true))) {
    SetText(form,"Text_CODE",data[0]);SetText(form,"Text_ARTICLE",data[1]);
    if(data.Length==4) {
     // Reach promotion with original controls/events; stop at image for accepted values.
     foreach(string name in new[]{"Combo_FAMILLE","Combo_PRINTER","Combo_TAUX_TVA"}) {
      var combo=(ComboBox)Get(form,name);combo.Items.Add("CI_FIXTURE");combo.SelectedIndex=combo.Items.Count-1;
     }
     foreach(string name in new[]{"Text_PRIX_A","Text_PRIX_MP","Text_PRIX_V","Text_PRIX_V_2","Text_PRIX_QTE","Text_PRIX_QTE_MIN","Text_STOCK","Text_ALERT"})
      SetText(form,name,"1");
     SetText(form,"Text_DATE_CREATION","2026-01-01");
     SetText(form,"Text_LIEN_PICTURE","");
     SetText(form,"Text_PROMOTION",data[3]);
    }
    int observed=0;
    uint threadId=GetCurrentThreadId();
    using(var stop=new ManualResetEvent(false)) {
     var watcher=new Thread(delegate() {
      while(!stop.WaitOne(100))if(DismissInjectedFailure(threadId,data[2]))Interlocked.Increment(ref observed);
     });
     watcher.IsBackground=true;watcher.Start();
     try {
      using(var sender=new Button(){Name="CI_CATALOGUE_SAVE"})form.GetType().GetMethod("Button_SAVE_Click",Flags).Invoke(form,new object[]{sender,EventArgs.Empty});
     } finally {
      stop.Set();if(!watcher.Join(2000))throw new Exception("Catalogue guard watcher did not stop");
     }
    }
    if(observed==0)throw new Exception("Expected catalogue warning was not observed: "+data[2]);
    if(data.Length==4 && ((Control)Get(form,"Text_PROMOTION")).Text!=data[3])throw new Exception("Promotion guard altered input");
    if(((Control)Get(form,"Text_CODE")).Text!=data[0] || ((Control)Get(form,"Text_ARTICLE")).Text!=data[1])
     throw new Exception("Rejected catalogue save normalized text prematurely");
    if(connection.State!=ConnectionState.Closed)throw new Exception("Required-field rejection left database connection open");
    connection.Open();
    Eq(Scalar(connection,"SELECT COUNT(*) FROM TABLE_ARTICLES WHERE ID=1 AND Code='CI_KEEP' AND Article='CI sentinel'"),1m,"catalogue guard preserves article sentinel");
    Eq(Scalar(connection,"SELECT COUNT(*) FROM TABLE_ARTICLES"),1m,"catalogue guard creates no article");
    Eq(Scalar(connection,"SELECT COUNT(*) FROM TABLE_MOUVEMENTS_STOCK"),1m,"catalogue guard creates no movement");
    Eq(Scalar(connection,"SELECT ARTICLE FROM TABLE_NUM WHERE ID=0"),7m,"catalogue guard preserves sequence");
    connection.Close();
   }
  }
  Console.WriteLine("PASS catalogue required code/article and promotion guards: 10 cases; promotion empty/over-100 rejected, -1/0/100 reach image guard before normalization/persistence");
 }

 static void VerifyCatalogueRow(IDbConnection connection,bool edited) {
  string[][] strings={
   new[]{"ID_ARTICLE","ART000007"},new[]{"Code",edited?"CI_EDIT":"CI_NEW"},new[]{"Article",edited?"CI s edited":"CI s item"},
   new[]{"Famille","CI_FAMILY"},new[]{"Sous_Famille","CI_SUBFAMILY"},new[]{"GROUPE","CI_GROUP"},new[]{"Description","CI_DESCRIPTION"},
   new[]{"UNITE","CI_UNIT"},new[]{"REFERENCE","CI_REFERENCE"},new[]{"FOURNISSEUR","CI_SUPPLIER"},new[]{"MODE_STOCK","CI_STOCK_MODE"},
   new[]{"PRINTER","CI_PRINTER"},new[]{"PRINTER_DUPLICATA","CI_DUPLICATE"},new[]{"Images","CI_UNCHANGED.png"},
   new[]{"Taille","CI_SIZE"},new[]{"Couleur","CI_COLOR"},new[]{"Emplacement","CI_LOCATION"},new[]{"FENETRE_PESAGE","CI_WEIGHING"},new[]{"BALANCE","NON"}
  };
  using(var command=connection.CreateCommand()) {
   command.CommandText="SELECT * FROM TABLE_ARTICLES WHERE ID=42";
   using(var row=command.ExecuteReader()) {
    if(!row.Read())throw new Exception("Missing catalogue mapping row");
    foreach(var field in strings)if(Convert.ToString(row[field[0]])!=field[1])throw new Exception("Catalogue mapping changed: "+field[0]);
    string[] numeric={"ID","Prix_A","PRIX_MP","PRIX_V_1","PRIX_V_2","PRIX_QTE","PRIX_QTE_MIN","STOCK","Alert","STOCK_INITIAL","TAUX_TVA","PROMOTION"};
    decimal[] expected={42m,10.25m,edited?88.5m:10.25m,20m,18m,16m,3m,7m,2m,edited?999m:7m,20m,5m};
    for(int index=0;index<numeric.Length;index++)if(Convert.ToDecimal(row[numeric[index]])!=expected[index])throw new Exception("Catalogue numeric mapping changed: "+numeric[index]);
    if(Convert.ToDateTime(row["DATES"])!=new DateTime(2026,1,2) ||
       Convert.ToDateTime(row["DATE_INVENTAIRE"])!=(edited?new DateTime(2020,3,4):new DateTime(2026,1,2)))
     throw new Exception("Catalogue date mapping changed");
    if(row.Read())throw new Exception("Duplicate catalogue identity");
   }
  }
  Console.WriteLine("PASS catalogue "+(edited?"edit":"create")+" all 33 persisted column values");
 }

 static void CatalogueCreateProduct(Assembly assembly,bool edit=false,bool duplicates=false,bool failMovement=false,bool failSequence=false,bool failInsert=false) {
  CultureInfo.CurrentCulture=CultureInfo.GetCultureInfo("en-US");
  var module=assembly.GetType("LOGICA.Module1",true);
  var connection=(IDbConnection)module.GetField("cn_SQL").GetValue(null);
  var fixture=new System.Data.Common.DbConnectionStringBuilder();fixture.ConnectionString=connection.ConnectionString;
  if(connection.Database!="logica_ci" || !fixture.ContainsKey("server") || Convert.ToString(fixture["server"])!="127.0.0.1" ||
     !fixture.ContainsKey("port") || Convert.ToInt32(fixture["port"])!=3307)
   throw new Exception("Catalogue create fixture requires exactly 127.0.0.1:3307/logica_ci");
  connection.Open();
  Sql(connection,"DROP TABLE IF EXISTS TABLE_ARTICLES; CREATE TABLE TABLE_ARTICLES (`ID` INT PRIMARY KEY,`ID_ARTICLE` VARCHAR(100) DEFAULT '',`Code` VARCHAR(100) DEFAULT '',`Article` VARCHAR(100) DEFAULT '',`Famille` VARCHAR(100) DEFAULT '',`Sous_Famille` VARCHAR(100) DEFAULT '',`GROUPE` VARCHAR(100) DEFAULT '',`Description` VARCHAR(100) DEFAULT '',`Prix_A` DECIMAL(14,4) DEFAULT 0,`PRIX_MP` DECIMAL(14,4) DEFAULT 0,`PRIX_V_1` DECIMAL(14,4) DEFAULT 0,`PRIX_V_2` DECIMAL(14,4) DEFAULT 0,`PRIX_QTE` DECIMAL(14,4) DEFAULT 0,`PRIX_QTE_MIN` DECIMAL(14,4) DEFAULT 0,`STOCK` DECIMAL(14,4) DEFAULT 0,`Alert` DECIMAL(14,4) DEFAULT 0,`DATES` DATE,`DATE_INVENTAIRE` DATE,`STOCK_INITIAL` DECIMAL(14,4) DEFAULT 0,`TAUX_TVA` DECIMAL(14,4) DEFAULT 0,`UNITE` VARCHAR(100) DEFAULT '',`REFERENCE` VARCHAR(100) DEFAULT '',`FOURNISSEUR` VARCHAR(100) DEFAULT '',`MODE_STOCK` VARCHAR(100) DEFAULT '',`PRINTER` VARCHAR(100) DEFAULT '',`PRINTER_DUPLICATA` VARCHAR(100) DEFAULT '',`Images` VARCHAR(100) DEFAULT '',`Taille` VARCHAR(100) DEFAULT '',`Couleur` VARCHAR(100) DEFAULT '',`Emplacement` VARCHAR(100) DEFAULT '',`PROMOTION` DECIMAL(14,4) DEFAULT 0,`FENETRE_PESAGE` VARCHAR(100) DEFAULT '',`BALANCE` VARCHAR(100) DEFAULT '') ENGINE=InnoDB; INSERT INTO TABLE_ARTICLES (ID,ID_ARTICLE,Code,Article) VALUES (41,'ART_CI_KEEP','CI_KEEP','CI sentinel')");
  Sql(connection,"DROP TABLE IF EXISTS TABLE_MOUVEMENTS_STOCK; CREATE TABLE TABLE_MOUVEMENTS_STOCK (DATES DATE,HEURE TIME,LIBELLE VARCHAR(100),ID_ARTICLE VARCHAR(100),CODE_ARTICLE VARCHAR(100),ARTICLE VARCHAR(100),QUANTITE DECIMAL(14,4)) ENGINE=InnoDB");
  Sql(connection,"DROP TABLE IF EXISTS TABLE_NUM; CREATE TABLE TABLE_NUM (ID INT PRIMARY KEY, ARTICLE INT) ENGINE=InnoDB; INSERT INTO TABLE_NUM VALUES (0,7)");
  if(failMovement)Sql(connection,"CREATE TRIGGER CI_CATALOGUE_FAIL_MOVEMENT BEFORE INSERT ON TABLE_MOUVEMENTS_STOCK FOR EACH ROW SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT='CI_CATALOGUE_MOVE_FAILURE'");
  if(failSequence)Sql(connection,"CREATE TRIGGER CI_CATALOGUE_FAIL_SEQUENCE BEFORE UPDATE ON TABLE_NUM FOR EACH ROW SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT='CI_CATALOGUE_SEQUENCE_FAILURE'");
  if(failInsert)Sql(connection,"CREATE TRIGGER CI_CATALOGUE_FAIL_INSERT BEFORE INSERT ON TABLE_ARTICLES FOR EACH ROW SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT='CI_CATALOGUE_INSERT_FAILURE'");
  connection.Close();
  var forms=assembly.GetType("LOGICA.My.MyProject",true).GetProperty("Forms",Flags).GetValue(null,null);
  var template=Get(forms,"Form_0_TEMPLATE");
  ((ListView)Get(template,"ListView1")).Items.Add("GROUPES").SubItems.Add("False");
  using(var form=(Form)Activator.CreateInstance(assembly.GetType("LOGICA.Form_2_ARTICLES",true))) {
   var adapterType=connection.GetType().Assembly.GetType("MySql.Data.MySqlClient.MySqlDataAdapter",true);
   using(var adapter=(System.Data.Common.DbDataAdapter)Activator.CreateInstance(adapterType,new object[]{"SELECT * FROM TABLE_ARTICLES",connection})) {
    var table=new DataTable();adapter.Fill(table);
    form.GetType().GetField("DT",Flags).SetValue(form,table);
    form.GetType().GetField("DA",Flags).SetValue(form,adapter);
    foreach(string name in new[]{"Combo_FAMILLE","Combo_PRINTER","Combo_TAUX_TVA","Combo_BALANCE"}) {
     var combo=(ComboBox)Get(form,name);
     combo.Items.Add(name=="Combo_BALANCE"?"NON":name=="Combo_TAUX_TVA"?"20":"CI_FIXTURE");combo.SelectedIndex=combo.Items.Count-1;
    }
    SetText(form,"Label_TOP","NOUVEAU");
    SetText(form,"Text_CODE"," CI_NEW ");SetText(form,"Text_ARTICLE"," CI's item ");
    SetText(form,"Text_PRIX_A","10.25");SetText(form,"Text_PRIX_MP","88.5");
    SetText(form,"Text_PRIX_V","20");SetText(form,"Text_PRIX_V_2","18");
    SetText(form,"Text_PRIX_QTE","16");SetText(form,"Text_PRIX_QTE_MIN","3");
    SetText(form,"Text_STOCK","7");SetText(form,"Text_STOCK_INITIAL","999");SetText(form,"Text_ALERT","2");
    SetText(form,"Text_DATE_CREATION","2026-01-02");SetText(form,"Text_DATE_INVENTAIRE","2020-03-04");
    SetText(form,"Text_PROMOTION","5");
    SetText(form,"Text_LIEN_PICTURE","CI_UNCHANGED.png");SetText(form,"Text_LIEN_PICTURE_ANC","CI_UNCHANGED.png");
    string[][] textFields={
     new[]{"Combo_FAMILLE","CI_FAMILY"},new[]{"Text_SOUS_FAMILLE","CI_SUBFAMILY"},new[]{"Combo_GROUPES","CI_GROUP"},
     new[]{"Text_DESCRIPTION","CI_DESCRIPTION"},new[]{"Combo_UNITE","CI_UNIT"},new[]{"Text_REFERENCE","CI_REFERENCE"},
     new[]{"Combo_FOURNISSEUR","CI_SUPPLIER"},new[]{"Combo_MODE_STOCK","CI_STOCK_MODE"},new[]{"Combo_PRINTER","CI_PRINTER"},
     new[]{"Combo_PRINTER_DUPLICATA","CI_DUPLICATE"},new[]{"Combo_TAILLES","CI_SIZE"},new[]{"Combo_COULEURS","CI_COLOR"},
     new[]{"Text_EMPLACEMENT","CI_LOCATION"},new[]{"Combo_FENETRE_PESEE","CI_WEIGHING"}
    };
    foreach(var field in textFields) {
     var control=(Control)Get(form,field[0]);var combo=control as ComboBox;
     if(combo!=null){combo.Items.Add(field[1]);combo.SelectedIndex=combo.Items.Count-1;}else control.Text=field[1];
    }
    string createAuditPath=Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"log.sni");
    string createAuditBefore=File.Exists(createAuditPath)?File.ReadAllText(createAuditPath):null;
    int observed=0;uint threadId=GetCurrentThreadId();
    using(var stop=new ManualResetEvent(false)) {
     var watcher=new Thread(delegate() {
      while(!stop.WaitOne(100))if(DismissInjectedFailure(threadId,failMovement?"CI_CATALOGUE_MOVE_FAILURE":failSequence?"CI_CATALOGUE_SEQUENCE_FAILURE":failInsert?"CI_CATALOGUE_INSERT_FAILURE":"Enregistré avec succès"))Interlocked.Increment(ref observed);
     });watcher.IsBackground=true;watcher.Start();
     try {
      using(var sender=new Button(){Name="CI_CATALOGUE_CREATE"})
       form.GetType().GetMethod("Button_SAVE_Click",Flags).Invoke(form,new object[]{sender,EventArgs.Empty});
     } finally {stop.Set();if(!watcher.Join(2000))throw new Exception("Catalogue create watcher did not stop");}
    }
    if(failInsert) {
     if(observed!=1)throw new Exception("Expected catalogue adapter insert failure warning");
     if(connection.State!=ConnectionState.Closed)throw new Exception("Adapter-owned connection state after insert failure changed");
     if(table.Rows.Count!=2 || table.Rows[1].RowState!=DataRowState.Added)
      throw new Exception("Insert failure must retain unaccepted Added row");
     if(Convert.ToInt32(table.Rows[1]["ID"])!=42 || Convert.ToString(table.Rows[1]["Code"])!="CI_NEW" ||
        Convert.ToString(table.Rows[1]["Article"])!="CI s item" || Convert.ToDecimal(table.Rows[1]["PRIX_MP"])!=10.25m)
      throw new Exception("Insert failure lost mapped in-memory values");
     if((File.Exists(createAuditPath)?File.ReadAllText(createAuditPath):null)!=createAuditBefore)
      throw new Exception("Insert failure appended audit");
     if(((Control)Get(form,"Label_ARTICLES")).Text=="2")throw new Exception("Insert failure refreshed aggregates");
     connection.Open();
     Eq(Scalar(connection,"SELECT COUNT(*) FROM TABLE_ARTICLES"),1m,"catalogue insert failure persists no new article");
     Eq(Scalar(connection,"SELECT COUNT(*) FROM TABLE_ARTICLES WHERE ID=41 AND Code='CI_KEEP' AND Article='CI sentinel'"),1m,"catalogue insert failure preserves existing article");
     Eq(Scalar(connection,"SELECT COUNT(*) FROM TABLE_MOUVEMENTS_STOCK"),0m,"catalogue insert failure creates no movement");
     Eq(Scalar(connection,"SELECT ARTICLE FROM TABLE_NUM WHERE ID=0"),7m,"catalogue insert failure leaves sequence");
     Sql(connection,"DROP TRIGGER CI_CATALOGUE_FAIL_INSERT");connection.Close();
     Console.WriteLine("PASS original catalogue adapter insert failure: database unchanged, mapped Added row retained, adapter-owned connection closed, no audit/movement/sequence/refresh");
     return;
    }
    if(failMovement || failSequence) {
     if(observed!=1)throw new Exception("Expected catalogue injected failure warning");
     if(connection.State!=ConnectionState.Open)throw new Exception("Legacy movement failure connection state changed");
     if(table.Rows.Count!=2 || table.Rows[1].RowState!=DataRowState.Unchanged)throw new Exception("Legacy persisted row acceptance after failure changed");
     VerifyCatalogueRow(connection,false);
     Eq(Scalar(connection,"SELECT COUNT(*) FROM TABLE_ARTICLES"),2m,"catalogue partial failure retains inserted article");
     Eq(Scalar(connection,"SELECT COUNT(*) FROM TABLE_ARTICLES WHERE ID=41 AND Code='CI_KEEP' AND Article='CI sentinel'"),1m,"catalogue partial failure preserves existing article");
     Eq(Scalar(connection,"SELECT COUNT(*) FROM TABLE_MOUVEMENTS_STOCK"),failSequence?1m:0m,"catalogue partial failure movement count");
     if(failSequence)Eq(Scalar(connection,"SELECT COUNT(*) FROM TABLE_MOUVEMENTS_STOCK WHERE ID_ARTICLE='ART000007' AND CODE_ARTICLE=' CI_NEW ' AND ARTICLE=' CI s item ' AND QUANTITE=7"),1m,"catalogue sequence failure retains committed movement");
     Eq(Scalar(connection,"SELECT ARTICLE FROM TABLE_NUM WHERE ID=0"),7m,"catalogue partial failure does not advance sequence");
     if(((Control)Get(form,"Label_ARTICLES")).Text=="2")throw new Exception("Failed catalogue save unexpectedly refreshed aggregates");
     Sql(connection,failMovement?"DROP TRIGGER CI_CATALOGUE_FAIL_MOVEMENT":"DROP TRIGGER CI_CATALOGUE_FAIL_SEQUENCE");connection.Close();
     Console.WriteLine("PASS original catalogue "+(failMovement?"movement":"sequence")+" failure: article remains committed and accepted; "+(failSequence?"movement remains committed; ":"")+"sequence/refresh skipped; legacy open connection verified then fixture cleaned");
     return;
    }
    if(observed!=1)throw new Exception("Expected one catalogue creation success warning");
    if(table.Rows.Count!=2 || table.Rows[1].RowState!=DataRowState.Unchanged)throw new Exception("Legacy row acceptance changed");
    if(connection.State!=ConnectionState.Closed)throw new Exception("Catalogue create left connection open");
    connection.Open();
    Eq(Scalar(connection,"SELECT COUNT(*) FROM TABLE_ARTICLES WHERE ID=41 AND Code='CI_KEEP' AND Article='CI sentinel'"),1m,"catalogue create preserves existing article");
    Eq(Scalar(connection,"SELECT COUNT(*) FROM TABLE_ARTICLES"),2m,"catalogue create inserts one article");
    Eq(Scalar(connection,"SELECT COUNT(*) FROM TABLE_ARTICLES WHERE ID=42 AND ID_ARTICLE='ART000007' AND Code='CI_NEW' AND Article='CI s item'"),1m,"catalogue create identity and normalized identifiers");
    Eq(Scalar(connection,"SELECT Prix_A FROM TABLE_ARTICLES WHERE ID=42"),10.25m,"catalogue create purchase");
    Eq(Scalar(connection,"SELECT PRIX_MP FROM TABLE_ARTICLES WHERE ID=42"),10.25m,"catalogue create average uses purchase control");
    Eq(Scalar(connection,"SELECT PRIX_V_1 FROM TABLE_ARTICLES WHERE ID=42"),20m,"catalogue create sale price");
    Eq(Scalar(connection,"SELECT PRIX_V_2 FROM TABLE_ARTICLES WHERE ID=42"),18m,"catalogue create second sale price");
    Eq(Scalar(connection,"SELECT STOCK_INITIAL FROM TABLE_ARTICLES WHERE ID=42"),7m,"catalogue create opening uses current stock");
    Eq(Scalar(connection,"SELECT COUNT(*) FROM TABLE_ARTICLES WHERE ID=42 AND DATES='2026-01-02' AND DATE_INVENTAIRE='2026-01-02'"),1m,"catalogue create inventory date uses creation date");
    Eq(Scalar(connection,"SELECT COUNT(*) FROM TABLE_MOUVEMENTS_STOCK WHERE ID_ARTICLE='ART000007' AND CODE_ARTICLE=' CI_NEW ' AND ARTICLE=' CI s item ' AND QUANTITE=7"),1m,"catalogue create movement retains untrimmed controls");
    Eq(Scalar(connection,"SELECT COUNT(*) FROM TABLE_MOUVEMENTS_STOCK"),1m,"catalogue create single movement");
    Eq(Scalar(connection,"SELECT ARTICLE FROM TABLE_NUM WHERE ID=0"),8m,"catalogue create advances sequence");
    VerifyCatalogueRow(connection,false);
    connection.Close();
    Eq(decimal.Parse(((Control)Get(form,"Label_ARTICLES")).Text),2m,"catalogue create aggregate refresh");
    if(edit) {
     var grid=(DataGridView)Get(form,"DataGridView1");
     grid.BindingContext=form.BindingContext;grid.AutoGenerateColumns=true;grid.DataSource=table;
     form.BindingContext[table].Position=1;
     if(grid.Rows.Count<2)throw new Exception("Catalogue edit fixture grid did not bind");
     SetText(form,"Label_TOP","MODIFICATION");SetText(form,"Label_INDEX","1");
     SetText(form,"Text_ID","42");SetText(form,"Text_ID_ARTICLE","ART000007");
     SetText(form,"Text_CODE"," CI_EDIT ");SetText(form,"Text_ARTICLE"," CI's edited ");
     SetText(form,"Text_PRIX_MP","88.5");SetText(form,"Text_STOCK_INITIAL","999");
     SetText(form,"Text_DATE_INVENTAIRE","2020-03-04");
     int editsObserved=0;
     using(var stop=new ManualResetEvent(false)) {
      var watcher=new Thread(delegate() {
       while(!stop.WaitOne(100))if(DismissInjectedFailure(threadId,"Modifié avec succès"))Interlocked.Increment(ref editsObserved);
      });watcher.IsBackground=true;watcher.Start();
      try {
       using(var sender=new Button(){Name="CI_CATALOGUE_EDIT"})
        form.GetType().GetMethod("Button_SAVE_Click",Flags).Invoke(form,new object[]{sender,EventArgs.Empty});
      } finally {stop.Set();if(!watcher.Join(2000))throw new Exception("Catalogue edit watcher did not stop");}
     }
     if(editsObserved!=1)throw new Exception("Expected one catalogue edit success warning");
     if(table.Rows[1].RowState!=DataRowState.Unchanged)throw new Exception("Edited row was not accepted");
     if(connection.State!=ConnectionState.Closed)throw new Exception("Catalogue edit left connection open");
     connection.Open();
     Eq(Scalar(connection,"SELECT COUNT(*) FROM TABLE_ARTICLES"),2m,"catalogue edit inserts no article");
     Eq(Scalar(connection,"SELECT COUNT(*) FROM TABLE_ARTICLES WHERE ID=41 AND Code='CI_KEEP' AND Article='CI sentinel'"),1m,"catalogue edit preserves other article");
     Eq(Scalar(connection,"SELECT COUNT(*) FROM TABLE_ARTICLES WHERE ID=42 AND ID_ARTICLE='ART000007' AND Code='CI_EDIT' AND Article='CI s edited'"),1m,"catalogue edit targets selected identity");
     Eq(Scalar(connection,"SELECT Prix_A FROM TABLE_ARTICLES WHERE ID=42"),10.25m,"catalogue edit purchase retained");
     Eq(Scalar(connection,"SELECT PRIX_MP FROM TABLE_ARTICLES WHERE ID=42"),88.5m,"catalogue edit uses average control");
     Eq(Scalar(connection,"SELECT STOCK_INITIAL FROM TABLE_ARTICLES WHERE ID=42"),999m,"catalogue edit uses opening stock control");
     Eq(Scalar(connection,"SELECT COUNT(*) FROM TABLE_ARTICLES WHERE ID=42 AND DATES='2026-01-02' AND DATE_INVENTAIRE='2020-03-04'"),1m,"catalogue edit uses separate inventory date");
     Eq(Scalar(connection,"SELECT COUNT(*) FROM TABLE_MOUVEMENTS_STOCK"),1m,"catalogue edit adds no opening movement");
     Eq(Scalar(connection,"SELECT ARTICLE FROM TABLE_NUM WHERE ID=0"),8m,"catalogue edit leaves sequence");
     VerifyCatalogueRow(connection,true);
     connection.Close();
     Eq(decimal.Parse(((Control)Get(form,"Label_ARTICLES")).Text),2m,"catalogue edit aggregate refresh");
     string audit=File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"log.sni"));
     if(!audit.Contains("CI_CATALOGUE_EDIT") || !audit.Contains("MODIFICATION | ART000007"))
      throw new Exception("Catalogue edit audit was not appended");
     Console.WriteLine("PASS original catalogue edit mapping: selected row, separate average/opening/date controls, no movement/sequence increment and audit");
     if(duplicates) {
      object[][] before={table.Rows[0].ItemArray,table.Rows[1].ItemArray};
      string auditBefore=File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"log.sni"));
      string[][] rejections={
       new[]{"NOUVEAU","CI_KEEP","ART000007","CI sentinel"},
       new[]{"MODIFICATION","CI_KEEP","ART000007","CI sentinel"},
       new[]{"MODIFICATION"," CI_EDIT ","ART_CI_KEEP","Cet ID est déja utilisé"}
      };
      foreach(var rejection in rejections) {
       SetText(form,"Label_TOP",rejection[0]);SetText(form,"Label_INDEX","1");SetText(form,"Text_ID","42");
       SetText(form,"Text_CODE",rejection[1]);SetText(form,"Text_ID_ARTICLE",rejection[2]);
       SetText(form,"Text_ARTICLE"," CI's rejected ");
       int warnings=0;
       using(var stop=new ManualResetEvent(false)) {
        var watcher=new Thread(delegate() {
         while(!stop.WaitOne(100))if(DismissInjectedFailure(threadId,rejection[3]))Interlocked.Increment(ref warnings);
        });watcher.IsBackground=true;watcher.Start();
        try {
         using(var sender=new Button(){Name="CI_CATALOGUE_DUPLICATE"})
          form.GetType().GetMethod("Button_SAVE_Click",Flags).Invoke(form,new object[]{sender,EventArgs.Empty});
        } finally {stop.Set();if(!watcher.Join(2000))throw new Exception("Catalogue duplicate watcher did not stop");}
       }
       if(warnings!=1)throw new Exception("Expected exactly one duplicate warning");
       if(((Control)Get(form,"Text_ARTICLE")).Text!=" CI s rejected " || ((Control)Get(form,"Text_CODE")).Text!=rejection[1])
        throw new Exception("Duplicate guard normalization timing changed");
       if(table.Rows.Count!=2 || table.GetChanges()!=null)throw new Exception("Duplicate guard changed DataTable state");
       for(int rowIndex=0;rowIndex<2;rowIndex++)
        for(int column=0;column<table.Columns.Count;column++)
         if(!Object.Equals(table.Rows[rowIndex][column],before[rowIndex][column]))throw new Exception("Duplicate guard changed in-memory row values");
       if(File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"log.sni"))!=auditBefore)
        throw new Exception("Duplicate rejection appended audit");
       if(connection.State!=ConnectionState.Closed)throw new Exception("Duplicate rejection left connection open");
       connection.Open();
       VerifyCatalogueRow(connection,true);
       Eq(Scalar(connection,"SELECT COUNT(*) FROM TABLE_ARTICLES"),2m,"duplicate guard inserts no article");
       Eq(Scalar(connection,"SELECT COUNT(*) FROM TABLE_ARTICLES WHERE ID=41 AND ID_ARTICLE='ART_CI_KEEP' AND Code='CI_KEEP' AND Article='CI sentinel'"),1m,"duplicate guard preserves competing article");
       Eq(Scalar(connection,"SELECT COUNT(*) FROM TABLE_MOUVEMENTS_STOCK"),1m,"duplicate guard adds no movement");
       Eq(Scalar(connection,"SELECT ARTICLE FROM TABLE_NUM WHERE ID=0"),8m,"duplicate guard leaves sequence");
       connection.Close();
      }
      Console.WriteLine("PASS original catalogue duplicate guards: creation code, edit code and edit identity; normalized input but unchanged rows, audit, movement and sequence");
     }
    }
   }
  }
  Console.WriteLine("PASS original catalogue creation mapping: adapter persistence, legacy field differences, movement, sequence and refresh; isolated fixture only");
 }

 static void CatalogueGeneratedBarcodes(Assembly assembly) {
  using(var form=(Form)Activator.CreateInstance(assembly.GetType("LOGICA.Form_2_ARTICLES",true))) {
   var generate=form.GetType().GetMethod("Button_GENERER_Click",Flags);
   if(generate==null)throw new Exception("Missing catalogue generator");
   int assertions=0;
   foreach(int requested in new[]{11,12}) {
    SetText(form,"TextBox_NBR_CODE_ARTICLE",requested.ToString(CultureInfo.InvariantCulture));
    for(int sample=0;sample<24;sample++) {
     using(var sender=new Button(){Name="CI_CATALOGUE_GENERATE"})
      generate.Invoke(form,new object[]{sender,EventArgs.Empty});
     string code=((Control)Get(form,"Text_CODE")).Text;
     assertions++;
     if(code.Length!=requested+1)throw new Exception("Generated barcode length changed");
     assertions++;
     if(!code.StartsWith("11",StringComparison.Ordinal))throw new Exception("Legacy generated prefix changed");
     foreach(char digit in code) {
      assertions++;
      if(digit<'0' || digit>'9')throw new Exception("Generated barcode contains a non-ASCII digit");
     }
     // Independent oracle walks payload from right to left, starting at weight three.
     int sum=0,weight=3;
     for(int index=code.Length-2;index>=0;index--) {
      sum+=(code[index]-'0')*weight;weight=4-weight;
     }
     assertions++;
     if(code[code.Length-1]-'0'!=(10-sum%10)%10)
      throw new Exception("Generated barcode checksum changed for requested length "+requested);
    }
   }
   Console.WriteLine("PASS catalogue barcode generation: "+assertions+" assertions; 48 original-handler samples, lengths 11/12, ASCII prefix and independent check digit");
  }
 }

 static void CatalogueKeys(Assembly assembly) {
  CultureInfo original=CultureInfo.CurrentCulture;
  int assertions=0;
  try {
   using(var form=(Form)Activator.CreateInstance(assembly.GetType("LOGICA.Form_2_ARTICLES",true))) {
    string[] handlers={"TextBox8_KeyPress","TextBox13_KeyPress","TextBox16_KeyPress","TextBox17_KeyPress","Text_PRIX_MP_KeyPress","Text_PRIX_V_2_KeyPress","Text_PROMOTION_KeyPress","Text_PRIX_A_COLLECTION_KeyPress","Text_PRIX_V_COLLECTION_KeyPress","Text_QTE_KeyPress","Text_CODE_COLLECTION_KeyPress","Text_PRIX_QTE_KeyPress","Text_PRIX_QTE_MIN_KeyPress"};
    char[] allowed={'0','1','2','3','4','5','6','7','8','9','\b','.','-'};
    char[] blocked={'+',',',' ','a','e','\t','\r','\n','\0',(char)127,(char)0x0661,(char)0xff11};
    foreach(string culture in new[]{"fr-MA","fr-FR","en-US"}) {
     CultureInfo.CurrentCulture=CultureInfo.GetCultureInfo(culture);
     foreach(string handler in handlers) {
      var method=form.GetType().GetMethod(handler,Flags);
      if(method==null)throw new Exception("Missing catalogue handler: "+handler);
      foreach(char key in allowed) {
       var e=new KeyPressEventArgs(key);method.Invoke(form,new object[]{form,e});assertions++;
       if(e.Handled)throw new Exception(handler+" blocked a legacy allowed key");
      }
      foreach(char key in blocked) {
       var e=new KeyPressEventArgs(key);method.Invoke(form,new object[]{form,e});assertions++;
       if(!e.Handled)throw new Exception(handler+" accepted a legacy blocked key");
      }
      foreach(char key in new[]{'1','a'}) {
       var e=new KeyPressEventArgs(key){Handled=true};method.Invoke(form,new object[]{form,e});assertions++;
       if(!e.Handled)throw new Exception(handler+" cleared an existing handled state");
      }
     }
    }
   }
   Console.WriteLine("PASS catalogue numeric key handlers: "+assertions+" assertions across 13 original handlers; no product writes");
  } finally { CultureInfo.CurrentCulture=original; }
 }

 [STAThread] static int Main(string[] args) {
  try {
   Application.EnableVisualStyles();
   var assembly=Assembly.LoadFrom(Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"LOGICA.exe"));
   if(args[0]=="catalogue-insert-failure") { CatalogueCreateProduct(assembly,false,false,false,false,true); } else if(args[0]=="catalogue-sequence-failure") { CatalogueCreateProduct(assembly,false,false,false,true); } else if(args[0]=="catalogue-movement-failure") { CatalogueCreateProduct(assembly,false,false,true); } else if(args[0]=="catalogue-duplicates") { CatalogueCreateProduct(assembly,true,true); } else if(args[0]=="catalogue-edit") { CatalogueCreateProduct(assembly,true); } else if(args[0]=="catalogue-create") { CatalogueCreateProduct(assembly); } else if(args[0]=="catalogue-barcodes") { CatalogueGeneratedBarcodes(assembly); } else if(args[0]=="catalogue-save-guards") { CatalogueSaveGuards(assembly); } else if(args[0]=="catalogue-keys") { CatalogueKeys(assembly); } else if(args[0]=="checkout-missing-stock-lookup") { Checkout(assembly,false,"stock-missing-lookup"); } else if(args[0]=="checkout-reject-stock") { Checkout(assembly,false,"reject-stock"); } else if(args[0]=="checkout-reject-stock-off") { Checkout(assembly,false,"reject-stock-off"); } else if(args[0]=="checkout-stock-exact") { Checkout(assembly,false,"stock-exact"); } else if(args[0]=="checkout-reject-total") { Checkout(assembly,false,"reject-total"); } else if(args[0]=="checkout-rounding-window") { Checkout(assembly,false,"rounding-window"); } else if(args[0]=="checkout-select-seller") { Checkout(assembly,false,"select-seller"); } else if(args[0]=="checkout-select-client") { Checkout(assembly,false,"select-client"); } else if(args[0]=="checkout-credit-client") { Checkout(assembly,false,"select-credit-client"); } else if(args[0]=="checkout-reject-sale") { Checkout(assembly,false,"reject-sale"); } else if(args[0]=="checkout-reject-return") { Checkout(assembly,false,"reject-return"); } else if(args[0]=="checkout-reject-empty") { Checkout(assembly,false,"reject-empty"); } else if(args[0]=="checkout-stock-off") { Checkout(assembly,false,"stock-off"); } else if(args[0]=="checkout-fractional") { Checkout(assembly,false,"fractional"); } else if(args[0]=="checkout-late-rollback") { Checkout(assembly,true,"cash",true); } else if(args[0]=="checkout-mixed") { Checkout(assembly,false,"mixed"); } else if(args[0]=="checkout-change") { Checkout(assembly,false,"change"); } else if(args[0]=="checkout-credit") { Checkout(assembly,false,"credit"); } else if(args[0]=="checkout-rollback") { Checkout(assembly,true); } else if(args[0]=="checkout") { Checkout(assembly); } else if(args[0]=="basket") { Basket(assembly); } else if(args[0]=="rounding") {
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
     // Show layout without database-dependent Load callbacks; workflow tests invoke business methods separately.
     var events=(EventHandlerList)typeof(Component).GetProperty("Events",BindingFlags.Instance|BindingFlags.NonPublic).GetValue(form,null);
     foreach(var keyName in new[]{"EVENT_LOAD","EVENT_SHOWN","EVENT_ACTIVATED"}) {
      var field=typeof(Form).GetField(keyName,BindingFlags.Static|BindingFlags.NonPublic);
      if(field!=null){var key=field.GetValue(null);events.RemoveHandler(key,events[key]);}
     }
     form.Show();Application.DoEvents();
     using(var bitmap=new Bitmap(Math.Max(1,form.Width),Math.Max(1,form.Height))) {
      form.DrawToBitmap(bitmap,new Rectangle(0,0,bitmap.Width,bitmap.Height));
      bitmap.Save(Path.Combine("..","results",name+".png"));
     }
     Console.WriteLine("PASS visible original form layout (database Load callbacks detached) "+name);
    }
   }
   return 0;
  } catch(Exception e) {Console.WriteLine("FAIL "+e); return 1;}
 }
}
