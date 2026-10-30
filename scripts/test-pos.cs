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
 static void EmptyValidationGuard(Assembly assembly) {
  // Characterize only the original empty-document early return, with no modal or DB writes.
  var forms=assembly.GetType("LOGICA.My.MyProject",true).GetProperty("Forms",Flags).GetValue(null,null);
  var template=Get(forms,"Form_0_TEMPLATE");
  var settings=(ListView)Get(template,"ListView1");
  if(settings.Items.Count==0 || settings.FindItemWithText("HT_TTC",false,0)==null)settings.Items.Add("HT_TTC").SubItems.Add("TTC");
  foreach(string formName in new[]{"Form_6_RECEPTIONS","Form_6_INVENTAIRES"}) {
   using(var form=(Form)Activator.CreateInstance(assembly.GetType("LOGICA."+formName,true))) {
    var rows=(DataGridView)Get(form,"DataGridView1");
    rows.AllowUserToAddRows=false;
    rows.Rows.Clear();
    var button=(Control)Get(form,"Button_VALIDER");
    button.Enabled=true;
    form.GetType().GetMethod("Button_VALIDER_Click",Flags).Invoke(form,new object[]{button,EventArgs.Empty});
    if(!button.Enabled)throw new Exception("Empty validation did not re-enable button: "+formName);
    if(rows.Rows.Count!=0)throw new Exception("Empty validation changed document grid: "+formName);
    Console.WriteLine("PASS original empty validation early-return "+formName);
    // The second original early return is an already-validated document. Avoid
    // the confirmation dialog and all database writes by exercising that guard.
    if(rows.Columns["ETAT"]==null)rows.Columns.Add("ETAT","ETAT");
    int row=rows.Rows.Add();
    rows.Rows[row].Cells["ETAT"].Value="VALIDER";
    rows.CurrentCell=rows.Rows[row].Cells["ETAT"];
    button.Enabled=true;
    form.GetType().GetMethod("Button_VALIDER_Click",Flags).Invoke(form,new object[]{button,EventArgs.Empty});
    if(!button.Enabled)throw new Exception("Validated document did not re-enable button: "+formName);
    if(rows.Rows.Count!=1 || Convert.ToString(rows.Rows[row].Cells["ETAT"].Value)!="VALIDER")
      throw new Exception("Validated document guard changed grid state: "+formName);
    Console.WriteLine("PASS original already-validated document guard "+formName);
   }
  }
 }
 static void InventoryTransactionPreflight(Assembly assembly) {
  // Preflight only: checks rollback support using separate isolated InnoDB tables.
  // It does not claim to invoke the original receipt/inventory validation handler.
  var module=assembly.GetType("LOGICA.Module1",true);
  using(var connection=(IDbConnection)module.GetField("cn_SQL").GetValue(null)) {
   if(!connection.ConnectionString.Contains("127.0.0.1") || !connection.ConnectionString.Contains("logica_ci"))
    throw new Exception("Transaction preflight requires isolated logica_ci database");
   connection.Open();
   // The isolated checkout fixture does not load the recovered receipt/inventory schema.
   // Do not report missing production tables or assert production table engines here.
   // This test proves only rollback on dedicated InnoDB fixture tables.
   Sql(connection,"DROP TABLE IF EXISTS TABLE_CI_TX_HEADER");
   Sql(connection,"DROP TABLE IF EXISTS TABLE_CI_TX_MOVEMENT");
   Sql(connection,"CREATE TABLE TABLE_CI_TX_HEADER (ID INT PRIMARY KEY, ETAT VARCHAR(20)) ENGINE=InnoDB");
   Sql(connection,"CREATE TABLE TABLE_CI_TX_MOVEMENT (ID INT PRIMARY KEY, QTY DECIMAL(12,2)) ENGINE=InnoDB");
   try {
    Sql(connection,"INSERT INTO TABLE_CI_TX_HEADER VALUES (1,'EN_COURS')");
    using(var tx=connection.BeginTransaction()) {
     using(var c=connection.CreateCommand()) {
      c.Transaction=tx;
      c.CommandText="UPDATE TABLE_CI_TX_HEADER SET ETAT='VALIDER' WHERE ID=1";c.ExecuteNonQuery();
      c.CommandText="INSERT INTO TABLE_CI_TX_MOVEMENT VALUES (1,2.50)";c.ExecuteNonQuery();
      c.CommandText="INSERT INTO TABLE_CI_TX_MOVEMENT VALUES (1,9.99)";
      bool failed=false;
      try{c.ExecuteNonQuery();}catch(System.Data.Common.DbException){failed=true;}
      if(!failed)throw new Exception("Duplicate movement failure did not trigger");
     }
     tx.Rollback();
    }
    Eq(Scalar(connection,"SELECT COUNT(*) FROM TABLE_CI_TX_MOVEMENT"),0m,"isolated movement rollback");
    Eq(Scalar(connection,"SELECT COUNT(*) FROM TABLE_CI_TX_HEADER WHERE ETAT='EN_COURS'"),1m,"isolated header rollback");
    Console.WriteLine("PASS isolated InnoDB rollback preflight; original tables and WinForms handlers NOT tested");
   } finally {
    Sql(connection,"DROP TABLE IF EXISTS TABLE_CI_TX_MOVEMENT");
    Sql(connection,"DROP TABLE IF EXISTS TABLE_CI_TX_HEADER");
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

 [STAThread] static int Main(string[] args) {
  try {
   Application.EnableVisualStyles();
   var assembly=Assembly.LoadFrom(Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"LOGICA.exe"));
   if(args[0]=="checkout-missing-stock-lookup") { Checkout(assembly,false,"stock-missing-lookup"); } else if(args[0]=="checkout-reject-stock") { Checkout(assembly,false,"reject-stock"); } else if(args[0]=="checkout-reject-stock-off") { Checkout(assembly,false,"reject-stock-off"); } else if(args[0]=="checkout-stock-exact") { Checkout(assembly,false,"stock-exact"); } else if(args[0]=="checkout-reject-total") { Checkout(assembly,false,"reject-total"); } else if(args[0]=="checkout-rounding-window") { Checkout(assembly,false,"rounding-window"); } else if(args[0]=="checkout-select-seller") { Checkout(assembly,false,"select-seller"); } else if(args[0]=="checkout-select-client") { Checkout(assembly,false,"select-client"); } else if(args[0]=="checkout-credit-client") { Checkout(assembly,false,"select-credit-client"); } else if(args[0]=="checkout-reject-sale") { Checkout(assembly,false,"reject-sale"); } else if(args[0]=="checkout-reject-return") { Checkout(assembly,false,"reject-return"); } else if(args[0]=="checkout-reject-empty") { Checkout(assembly,false,"reject-empty"); } else if(args[0]=="checkout-stock-off") { Checkout(assembly,false,"stock-off"); } else if(args[0]=="checkout-fractional") { Checkout(assembly,false,"fractional"); } else if(args[0]=="checkout-late-rollback") { Checkout(assembly,true,"cash",true); } else if(args[0]=="checkout-mixed") { Checkout(assembly,false,"mixed"); } else if(args[0]=="checkout-change") { Checkout(assembly,false,"change"); } else if(args[0]=="checkout-credit") { Checkout(assembly,false,"credit"); } else if(args[0]=="checkout-rollback") { Checkout(assembly,true); } else if(args[0]=="checkout") { Checkout(assembly); } else if(args[0]=="inventory-empty-validation") { EmptyValidationGuard(assembly); } else if(args[0]=="inventory-transaction-preflight") { InventoryTransactionPreflight(assembly); } else if(args[0]=="basket") { Basket(assembly); } else if(args[0]=="rounding") {
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
