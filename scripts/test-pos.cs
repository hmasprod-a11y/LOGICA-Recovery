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
 static bool DeclineValidationDialog(uint threadId,string expectedDocument) {
  bool declined=false;
  EnumThreadWindows(threadId,delegate(IntPtr window,IntPtr unused) {
   var cls=new StringBuilder(128);GetClassName(window,cls,cls.Capacity);
   if(cls.ToString()!="#32770")return true;
   bool matching=false;
   EnumChildWindows(window,delegate(IntPtr child,IntPtr ignored) {
    var label=new StringBuilder(1024);GetWindowText(child,label,label.Capacity);
    if(label.ToString().Contains("Voulez-vous vraiment Valider") && label.ToString().Contains(expectedDocument))matching=true;
    return true;
   },IntPtr.Zero);
   // WM_COMMAND / IDNO=7. Explicitly decline; never accept a posting.
   if(matching)declined=PostMessage(window,0x0111,new IntPtr(7),IntPtr.Zero) || declined;
   return true;
  },IntPtr.Zero);
  return declined;
 }
 static void DeclinedValidationGuard(Assembly assembly) {
  var forms=assembly.GetType("LOGICA.My.MyProject",true).GetProperty("Forms",Flags).GetValue(null,null);
  var template=Get(forms,"Form_0_TEMPLATE");
  var settings=(ListView)Get(template,"ListView1");
  if(settings.Items.Count==0 || settings.FindItemWithText("HT_TTC",false,0)==null)
   settings.Items.Add("HT_TTC").SubItems.Add("TTC");
  foreach(string formName in new[]{"Form_6_RECEPTIONS","Form_6_INVENTAIRES"}) {
   using(var form=(Form)Activator.CreateInstance(assembly.GetType("LOGICA."+formName,true))) {
    var grid=(DataGridView)Get(form,"DataGridView1");
    grid.AllowUserToAddRows=false;grid.Rows.Clear();
    string idColumn=formName=="Form_6_RECEPTIONS"?"ID_BR":"ID_INV";
    if(grid.Columns["ETAT"]==null)grid.Columns.Add("ETAT","ETAT");
    if(grid.Columns[idColumn]==null)grid.Columns.Add(idColumn,idColumn);
    int row=grid.Rows.Add();grid.Rows[row].Cells["ETAT"].Value="EN_COURS";
    string document="CI_NO_"+(formName=="Form_6_RECEPTIONS"?"BR":"INV");
    grid.Rows[row].Cells[idColumn].Value=document;
    grid.CurrentCell=grid.Rows[row].Cells["ETAT"];
    var button=(Control)Get(form,"Button_VALIDER");button.Enabled=true;
    uint threadId=GetCurrentThreadId();int declineCount=0;
    using(var stop=new ManualResetEvent(false)) {
     var watcher=new Thread(delegate() {
      while(!stop.WaitOne(60))if(DeclineValidationDialog(threadId,document))Interlocked.Increment(ref declineCount);
     });watcher.IsBackground=true;watcher.Start();
     try { form.GetType().GetMethod("Button_VALIDER_Click",Flags).Invoke(form,new object[]{button,EventArgs.Empty}); }
     finally { stop.Set();if(!watcher.Join(2000))throw new Exception("Decline watcher did not stop"); }
    }
    if(declineCount==0)throw new Exception("No original decline confirmation observed: "+formName);
    if(!button.Enabled)throw new Exception("Declined validation left button disabled: "+formName);
    if(grid.Rows.Count!=1 || Convert.ToString(grid.Rows[row].Cells["ETAT"].Value)!="EN_COURS")
     throw new Exception("Declined validation changed original list: "+formName);
    Console.WriteLine("PASS original declined validation "+formName);
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

 static void StockMovementSearch(Assembly assembly,bool failQuery=false) {
  CultureInfo.CurrentCulture=CultureInfo.GetCultureInfo("en-US");
  var module=assembly.GetType("LOGICA.Module1",true);
  var connection=(IDbConnection)module.GetField("cn_SQL").GetValue(null);
  var fixture=new System.Data.Common.DbConnectionStringBuilder();fixture.ConnectionString=connection.ConnectionString;
  if(connection.Database!="logica_ci" || !fixture.ContainsKey("server") || Convert.ToString(fixture["server"])!="127.0.0.1" ||
     !fixture.ContainsKey("port") || Convert.ToInt32(fixture["port"])!=3307)
   throw new Exception("Movement search fixture requires exactly 127.0.0.1:3307/logica_ci");
  connection.Open();
  Sql(connection,"DROP TABLE IF EXISTS TABLE_MOUVEMENTS_STOCK; CREATE TABLE TABLE_MOUVEMENTS_STOCK (ID INT PRIMARY KEY,DATES DATE,CODE_ARTICLE VARCHAR(50),ARTICLE VARCHAR(100)) ENGINE=InnoDB; INSERT INTO TABLE_MOUVEMENTS_STOCK VALUES (1,'2026-01-01','ABC','Alpha'),(2,'2026-01-02','ABCX','Alpha extra'),(3,'2026-01-03','XYZ','Beta'),(4,'2026-01-04','ABC','Alpha')");
  connection.Close();
  using(var form=(Form)Activator.CreateInstance(assembly.GetType("LOGICA.Form_6_MOUVEMENTS_STOCK",true))) {
   SetText(form,"Label_TABLE","MOUVEMENTS_STOCK");
   ((DateTimePicker)Get(form,"DateTime1_FIND")).Value=new DateTime(2026,1,2);
   ((DateTimePicker)Get(form,"DateTime2_FIND")).Value=new DateTime(2026,1,3);
   var combo=(ComboBox)Get(form,"Combo_FIND");
   combo.Items.Add("CODE_ARTICLE");combo.Items.Add("DATES");
   var search=Get(form,"Text_FIND");var texts=search.GetType().GetProperty("Texts");
   var dateFlag=Get(form,"Check_FIND_DATE");var exactFlag=Get(form,"Check_FIND_EXACTE");
   Action<bool> setDate=delegate(bool value){dateFlag.GetType().GetProperty("Checked").SetValue(dateFlag,value,null);};
   Action<bool> setExact=delegate(bool value){exactFlag.GetType().GetProperty("Checked").SetValue(exactFlag,value,null);};
   Action<string> query=delegate(string text) {
    texts.SetValue(search,text,null); // Original TextChanged also invokes the search handler.
    using(var sender=new Button(){Name="CI_MOVEMENT_SEARCH"})
     form.GetType().GetMethod("Picture_FIND_Click",Flags).Invoke(form,new object[]{sender,EventArgs.Empty});
   };
   Action<string> expect=delegate(string ids) {
    var table=(DataTable)form.GetType().GetField("DT",Flags).GetValue(form);
    string actual="";foreach(DataRow row in table.Rows){if(actual.Length>0)actual+=",";actual+=Convert.ToString(row["ID"]);}
    if(actual!=ids)throw new Exception("Movement result order changed: expected "+ids+" actual "+actual);
    if(!Object.ReferenceEquals(((DataGridView)Get(form,"DataGridView1")).DataSource,table))
     throw new Exception("Movement grid no longer bound to original DT");
    if(connection.State!=ConnectionState.Closed)throw new Exception("Movement read left connection open");
    Console.WriteLine("PASS original movement result IDs "+ids);
   };
   combo.SelectedItem="CODE_ARTICLE";setDate(false);setExact(false);query("ABC");expect("4,2,1");
   setExact(true);query("ABC");expect("4,1");
   query("ABC%");expect("4,2,1"); // Exact mode still uses LIKE, preserving wildcard semantics.
   setExact(false);setDate(true);query("ABC");expect("2");
   query("");expect("2"); // Empty text keeps the previously loaded table.
   combo.SelectedItem="DATES";query("");expect("3,2");
   using(var sender=new Button(){Name="CI_MOVEMENT_REFRESH"})
    form.GetType().GetMethod("Picture_REFRESH_Click",Flags).Invoke(form,new object[]{sender,EventArgs.Empty});
   expect("4,3,2,1");
   if(Convert.ToString(texts.GetValue(search,null))!="")throw new Exception("Movement refresh did not clear search");
   if(failQuery) {
    var beforeTable=(DataTable)form.GetType().GetField("DT",Flags).GetValue(form);
    object beforeAdapter=form.GetType().GetField("DA",Flags).GetValue(form);
    combo.Items.Add("CI_MISSING_COLUMN");combo.SelectedItem="CI_MISSING_COLUMN";setDate(true);setExact(false);
    form.GetType().GetField("_sql",Flags).SetValue(form,"CI_BEFORE_FAILURE");
    int warnings=0;uint threadId=GetCurrentThreadId();
    using(var stop=new ManualResetEvent(false)) {
     var watcher=new Thread(delegate() {
      while(!stop.WaitOne(100))if(DismissInjectedFailure(threadId,"CI_MISSING_COLUMN"))Interlocked.Increment(ref warnings);
     });watcher.IsBackground=true;watcher.Start();
     try {query("ABC");}
     finally {stop.Set();if(!watcher.Join(2000))throw new Exception("Movement failure watcher did not stop");}
    }
    if(warnings<1)throw new Exception("Expected movement query failure warning");
    var afterTable=(DataTable)form.GetType().GetField("DT",Flags).GetValue(form);
    object afterAdapter=form.GetType().GetField("DA",Flags).GetValue(form);
    if(!Object.ReferenceEquals(beforeTable,afterTable) || afterTable.Rows.Count!=0)
     throw new Exception("Movement failure did not retain cleared DT");
    if(Object.ReferenceEquals(beforeAdapter,afterAdapter))throw new Exception("Movement failure did not keep newly assigned DA");
    var adapter=(System.Data.Common.DbDataAdapter)afterAdapter;
    if(!adapter.SelectCommand.CommandText.Contains("CI_MISSING_COLUMN") || !adapter.SelectCommand.CommandText.Contains("Dates   between"))
     throw new Exception("Movement failure adapter lost attempted query");
    string prefix=Convert.ToString(form.GetType().GetField("_sql",Flags).GetValue(form));
    if(!prefix.Contains("Dates   between") || !prefix.Contains("AND"))throw new Exception("Movement failure filter-prefix side effect changed");
    expect("");
    Console.WriteLine("PASS original movement lookup failure: prior results cleared, DT/grid reference retained, new adapter/query/prefix kept, warning and closed connection");
   }
  }
  connection.Open();Eq(Scalar(connection,"SELECT COUNT(*) FROM TABLE_MOUVEMENTS_STOCK"),4m,"movement search preserves fixture row count");connection.Close();
  Console.WriteLine("PASS original movement search: date boundaries, wildcard/exact LIKE, optional date, empty retention, refresh and descending order; isolated read-only fixture");
 }

 static void CountedCash(Assembly assembly) {
  CultureInfo.CurrentCulture=CultureInfo.GetCultureInfo("en-US");
  using(var form=(Form)Activator.CreateInstance(assembly.GetType("LOGICA.FormDialog_COMPTER_CAISSE",true))) {
   string[] inputs={"Text_200","Text_100","Text_50","Text_20","Text_10","Text_5","Text_2","Text_1","Text_0_5","Text_0_2","Text_0_1"};
   var grid=(DataGridView)Get(form,"DataGridView1");grid.AllowUserToAddRows=false;grid.Rows.Clear();
   string[] modes={"ESPECES","CARTE","ESPECES","especes"};
   foreach(string mode in modes) {int row=grid.Rows.Add();grid.Rows[row].Cells["MODE_P"].Value=mode;grid.Rows[row].Cells["CAISSE"].Value="CI_UNTOUCHED";}
   string[][] cases={
    new[]{"0","0","0","0","0","0","0","0","0","0","0"},
    new[]{"1","1","1","1","1","1","1","1","1","1","1"},
    new[]{"2","0","0","0","0","0","0","0","0","3","0"},
    new[]{"-1","0","0","0","0","0","0","0","0","0","1"},
    new[]{"0.5","0","0","0","0","0","0","0","0","0","0"},
    new[]{"abc","0","0","0","0","0","0","0","0","0","0"},
    new[]{"  ","0","0","0","0","0","0","0","0","0","0"}};
   decimal[] expected={0m,388.8m,400.6m,-199.9m,100m,0m,0m};
   var lostFocus=form.GetType().GetMethod("TextBox_LostFocus",Flags);
   for(int scenario=0;scenario<cases.Length;scenario++) {
    for(int index=0;index<inputs.Length;index++)SetText(form,inputs[index],cases[scenario][index]);
    SetText(form,"Text_TOTAL_ESPECES","CI_BEFORE_COUNT");
    foreach(DataGridViewRow row in grid.Rows)row.Cells["CAISSE"].Value="CI_UNTOUCHED";
    var sender=(Control)Get(form,"Text_200");sender.BackColor=Color.Yellow;
    lostFocus.Invoke(form,new object[]{sender,EventArgs.Empty});
    string total=((Control)Get(form,"Text_TOTAL_ESPECES")).Text;
    Eq(decimal.Parse(total),expected[scenario],"original counted cash scenario "+scenario);
    if(sender.BackColor!=Color.White)throw new Exception("Lost-focus background changed");
    if(sender.Text!=(scenario>=5?"0":cases[scenario][0]))throw new Exception("Count input normalization changed");
    for(int row=0;row<modes.Length;row++) {
     string actual=Convert.ToString(grid.Rows[row].Cells["CAISSE"].Value);
     if(actual!=(modes[row]=="ESPECES"?total:"CI_UNTOUCHED"))throw new Exception("Cash mode row update changed");
    }
    for(int index=1;index<inputs.Length;index++)
     if(((Control)Get(form,inputs[index])).Text!=cases[scenario][index])throw new Exception("Other denomination changed");
   }
   Console.WriteLine("PASS original counted cash: eleven denominations, mixed arithmetic, negative/fractional counts, invalid sender reset, exact cash rows and no Load/financial writes");
  }
 }

 static void CatalogueSaveGuards(Assembly assembly,bool collection=false,bool duplicate=false,bool laterDuplicate=false) {
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
  if(duplicate)cases=new[]{new[]{"CI_REQUIRED","CI\'s untouched","CI sentinel"}};
  foreach(var data in cases) {
   if(collection && data.Length!=3)continue;
   string codeField=collection?"Text_CODE_COLLECTION":"Text_CODE",articleField=collection?"Text_ARTICLE_COLLECTION":"Text_ARTICLE";
   using(var form=(Form)Activator.CreateInstance(assembly.GetType("LOGICA.Form_2_ARTICLES",true))) {
    SetText(form,codeField,data[0]);SetText(form,articleField,data[1]);
    if(duplicate) {
     foreach(string name in new[]{"Combo_FAMILLE_COLLECTION","Combo_FOURNISSEUR_COLLECTION"}) {
      var combo=(ComboBox)Get(form,name);combo.Items.Add("CI_FIXTURE");combo.SelectedIndex=combo.Items.Count-1;
     }
     SetText(form,"Text_PRIX_A_COLLECTION","1");SetText(form,"Text_PRIX_V_COLLECTION","2");
     SetText(form,"Text_REFERENCE_COLLECTION","CI_REFERENCE");SetText(form,"Label_TOP_COLLECTION","NOUVEAU");
     var grid=(DataGridView)Get(form,"DataGrid_COLLECTION");grid.AllowUserToAddRows=false;grid.Rows.Clear();
     if(laterDuplicate) {int first=grid.Rows.Add();grid.Rows[first].Cells[0].Value="CI_NEW_NO_MATCH";}
     int row=grid.Rows.Add();grid.Rows[row].Cells[0].Value="CI_KEEP";
     // A malformed unvisited code makes accidental continuation observable.
     if(laterDuplicate) {int last=grid.Rows.Add();grid.Rows[last].Cells[0].Value="CI_UNVISITED'";}
    }
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
      using(var sender=new Button(){Name="CI_CATALOGUE_SAVE"})form.GetType().GetMethod(collection?"Button_SAVE_COLLECTION_Click":"Button_SAVE_Click",Flags).Invoke(form,new object[]{sender,EventArgs.Empty});
     } finally {
      stop.Set();if(!watcher.Join(2000))throw new Exception("Catalogue guard watcher did not stop");
     }
    }
    if(observed==0)throw new Exception("Expected catalogue warning was not observed: "+data[2]);
    if(laterDuplicate) {
     var grid=(DataGridView)Get(form,"DataGrid_COLLECTION");
     if(grid.Rows.Count!=3 || grid.CurrentCell==null || grid.CurrentCell.RowIndex!=2)
      throw new Exception("Collection precheck no-match grid-selection timing changed");
    }
    if(data.Length==4 && ((Control)Get(form,"Text_PROMOTION")).Text!=data[3])throw new Exception("Promotion guard altered input");
    if(((Control)Get(form,codeField)).Text!=data[0] || ((Control)Get(form,articleField)).Text!=(duplicate?data[1].Replace("\'"," "):data[1]))
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
  Console.WriteLine(laterDuplicate?"PASS collection later-row duplicate: preceding no-match, early stop before malformed trailing code, legacy last-row selection and unchanged sentinels":duplicate?"PASS original collection duplicate code: article normalized, database sentinels/sequence unchanged and closed connection before transaction":collection?"PASS original collection required identifiers: four cases, unchanged text/sentinels and closed connection before batch work":"PASS catalogue required code/article and promotion guards: 10 cases; promotion empty/over-100 rejected, -1/0/100 reach image guard before normalization/persistence");
 }

 static void VerifyCatalogueRow(IDbConnection connection,bool edited,int expectedId=42,string expectedArticleId="ART000007",string expectedCode=null,string expectedBalance="NON") {
  string[][] strings={
   new[]{"ID_ARTICLE",expectedArticleId},new[]{"Code",expectedCode??(edited?"CI_EDIT":"CI_NEW")},new[]{"Article",edited?"CI s edited":"CI s item"},
   new[]{"Famille","CI_FAMILY"},new[]{"Sous_Famille","CI_SUBFAMILY"},new[]{"GROUPE","CI_GROUP"},new[]{"Description","CI_DESCRIPTION"},
   new[]{"UNITE","CI_UNIT"},new[]{"REFERENCE","CI_REFERENCE"},new[]{"FOURNISSEUR","CI_SUPPLIER"},new[]{"MODE_STOCK","CI_STOCK_MODE"},
   new[]{"PRINTER","CI_PRINTER"},new[]{"PRINTER_DUPLICATA","CI_DUPLICATE"},new[]{"Images","CI_UNCHANGED.png"},
   new[]{"Taille","CI_SIZE"},new[]{"Couleur","CI_COLOR"},new[]{"Emplacement","CI_LOCATION"},new[]{"FENETRE_PESAGE","CI_WEIGHING"},new[]{"BALANCE",expectedBalance}
  };
  using(var command=connection.CreateCommand()) {
   command.CommandText="SELECT * FROM TABLE_ARTICLES WHERE ID="+expectedId.ToString(CultureInfo.InvariantCulture);
   using(var row=command.ExecuteReader()) {
    if(!row.Read())throw new Exception("Missing catalogue mapping row");
    foreach(var field in strings)if(Convert.ToString(row[field[0]])!=field[1])throw new Exception("Catalogue mapping changed: "+field[0]);
    string[] numeric={"ID","Prix_A","PRIX_MP","PRIX_V_1","PRIX_V_2","PRIX_QTE","PRIX_QTE_MIN","STOCK","Alert","STOCK_INITIAL","TAUX_TVA","PROMOTION"};
    decimal[] expected={expectedId,10.25m,edited?88.5m:10.25m,20m,18m,16m,3m,7m,2m,edited?999m:7m,20m,5m};
    for(int index=0;index<numeric.Length;index++)if(Convert.ToDecimal(row[numeric[index]])!=expected[index])throw new Exception("Catalogue numeric mapping changed: "+numeric[index]);
    if(Convert.ToDateTime(row["DATES"])!=new DateTime(2026,1,2) ||
       Convert.ToDateTime(row["DATE_INVENTAIRE"])!=(edited?new DateTime(2020,3,4):new DateTime(2026,1,2)))
     throw new Exception("Catalogue date mapping changed");
    if(row.Read())throw new Exception("Duplicate catalogue identity");
   }
  }
  Console.WriteLine("PASS catalogue "+(edited?"edit":"create")+" all 33 persisted column values");
 }

 static void CatalogueCreateProduct(Assembly assembly,bool edit=false,bool duplicates=false,bool failMovement=false,bool failSequence=false,bool failInsert=false,bool failUpdate=false,bool emptyArticles=false,bool nullSequence=false,string balanceScenario=null) {
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
  if(emptyArticles)Sql(connection,"DELETE FROM TABLE_ARTICLES");
  if(nullSequence)Sql(connection,"UPDATE TABLE_NUM SET ARTICLE=NULL WHERE ID=0");
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
    if(balanceScenario!=null) {
     var balance=(ComboBox)Get(form,"Combo_BALANCE");balance.Items.Add("OUI");balance.SelectedIndex=balance.Items.Count-1;
     SetText(form,"TextBox_NBR_CODE_BALANCE","6");
     SetText(form,"Text_CODE",balanceScenario=="reject"?"CI_NOT_NUMERIC":"123");
    }
    string createAuditPath=Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"log.sni");
    string createAuditBefore=File.Exists(createAuditPath)?File.ReadAllText(createAuditPath):null;
    int observed=0;uint threadId=GetCurrentThreadId();
    using(var stop=new ManualResetEvent(false)) {
     var watcher=new Thread(delegate() {
      while(!stop.WaitOne(100))if(DismissInjectedFailure(threadId,failMovement?"CI_CATALOGUE_MOVE_FAILURE":failSequence?"CI_CATALOGUE_SEQUENCE_FAILURE":failInsert?"CI_CATALOGUE_INSERT_FAILURE":balanceScenario=="reject"?"Erreur Code Article":"Enregistré avec succès"))Interlocked.Increment(ref observed);
     });watcher.IsBackground=true;watcher.Start();
     try {
      using(var sender=new Button(){Name="CI_CATALOGUE_CREATE"})
       form.GetType().GetMethod("Button_SAVE_Click",Flags).Invoke(form,new object[]{sender,EventArgs.Empty});
     } finally {stop.Set();if(!watcher.Join(2000))throw new Exception("Catalogue create watcher did not stop");}
    }
    if(balanceScenario!=null) {
     bool rejected=balanceScenario=="reject";
     if(observed!=1)throw new Exception("Expected one balance branch warning");
     if(connection.State!=ConnectionState.Closed)throw new Exception("Balance branch left connection open");
     if(((Control)Get(form,"Text_ARTICLE")).Text!=" CI s item " ||
        ((Control)Get(form,"Text_CODE")).Text!=(rejected?"CI_NOT_NUMERIC":"000123"))
      throw new Exception("Balance normalization order or formatted code changed");
     if(table.Rows.Count!=(rejected?1:2) || table.GetChanges()!=null)
      throw new Exception("Balance branch changed accepted table state");
     if((File.Exists(createAuditPath)?File.ReadAllText(createAuditPath):null)!=createAuditBefore)
      throw new Exception("Balance branch appended edit audit");
     connection.Open();
     Eq(Scalar(connection,"SELECT COUNT(*) FROM TABLE_ARTICLES"),rejected?1m:2m,"catalogue balance article count");
     Eq(Scalar(connection,"SELECT COUNT(*) FROM TABLE_ARTICLES WHERE ID=41 AND Code='CI_KEEP' AND Article='CI sentinel'"),1m,"catalogue balance preserves existing article");
     Eq(Scalar(connection,"SELECT COUNT(*) FROM TABLE_MOUVEMENTS_STOCK"),rejected?0m:1m,"catalogue balance movement count");
     Eq(Scalar(connection,"SELECT ARTICLE FROM TABLE_NUM WHERE ID=0"),rejected?7m:8m,"catalogue balance sequence");
     if(!rejected) {
      VerifyCatalogueRow(connection,false,42,"ART000007","000123","OUI");
      Eq(Scalar(connection,"SELECT COUNT(*) FROM TABLE_MOUVEMENTS_STOCK WHERE ID_ARTICLE='ART000007' AND CODE_ARTICLE='000123' AND ARTICLE=' CI s item ' AND QUANTITE=7"),1m,"catalogue balance movement uses formatted code");
     }
     connection.Close();
     if(rejected) {
      if(((Control)Get(form,"Label_ARTICLES")).Text=="2")throw new Exception("Balance rejection refreshed aggregates");
     } else Eq(decimal.Parse(((Control)Get(form,"Label_ARTICLES")).Text),2m,"catalogue balance aggregate refresh");
     Console.WriteLine("PASS original catalogue balance "+balanceScenario+": article normalization precedes numeric guard; rejected writes skipped or formatted code persisted");
     return;
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
    if(emptyArticles || nullSequence) {
     int expectedId=emptyArticles?1:42,expectedCount=emptyArticles?1:2;
     string articleId=nullSequence?"0":"ART000007";
     if(observed!=1)throw new Exception("Expected catalogue scalar-edge success warning");
     if(table.Rows.Count!=expectedCount || table.Rows[expectedCount-1].RowState!=DataRowState.Unchanged)
      throw new Exception("Scalar-edge row identity/acceptance changed");
     if(connection.State!=ConnectionState.Closed)throw new Exception("Scalar-edge save left connection open");
     connection.Open();
     VerifyCatalogueRow(connection,false,expectedId,articleId);
     Eq(Scalar(connection,"SELECT COUNT(*) FROM TABLE_ARTICLES"),expectedCount,"catalogue scalar-edge article count");
     Eq(Scalar(connection,"SELECT COUNT(*) FROM TABLE_ARTICLES WHERE ID=41 AND Code='CI_KEEP' AND Article='CI sentinel'"),emptyArticles?0m:1m,"catalogue scalar-edge existing rows");
     Eq(Scalar(connection,"SELECT COUNT(*) FROM TABLE_MOUVEMENTS_STOCK WHERE ID_ARTICLE='"+articleId+"' AND CODE_ARTICLE=' CI_NEW ' AND ARTICLE=' CI s item ' AND QUANTITE=7"),1m,"catalogue scalar-edge movement identity");
     Eq(Scalar(connection,"SELECT COUNT(*) FROM TABLE_MOUVEMENTS_STOCK"),1m,"catalogue scalar-edge movement count");
     if(nullSequence)Eq(Scalar(connection,"SELECT COUNT(*) FROM TABLE_NUM WHERE ID=0 AND ARTICLE IS NULL"),1m,"catalogue null sequence remains null after increment");
     else Eq(Scalar(connection,"SELECT ARTICLE FROM TABLE_NUM WHERE ID=0"),8m,"catalogue scalar-edge sequence increment");
     connection.Close();
     Eq(decimal.Parse(((Control)Get(form,"Label_ARTICLES")).Text),expectedCount,"catalogue scalar-edge aggregate refresh");
     Console.WriteLine("PASS original catalogue scalar edges: emptyArticles="+emptyArticles+" nullSequence="+nullSequence+"; ID="+expectedId+" ID_ARTICLE="+articleId);
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
     if(failUpdate) {
      connection.Open();
      Sql(connection,"CREATE TRIGGER CI_CATALOGUE_FAIL_UPDATE BEFORE UPDATE ON TABLE_ARTICLES FOR EACH ROW SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT='CI_CATALOGUE_UPDATE_FAILURE'");
      connection.Close();
      SetText(form,"Label_ARTICLES","CI_BEFORE_EDIT");
     }
     string editAuditPath=Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"log.sni");
     string editAuditBefore=File.Exists(editAuditPath)?File.ReadAllText(editAuditPath):null;
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
       while(!stop.WaitOne(100))if(DismissInjectedFailure(threadId,failUpdate?"CI_CATALOGUE_UPDATE_FAILURE":"Modifié avec succès"))Interlocked.Increment(ref editsObserved);
      });watcher.IsBackground=true;watcher.Start();
      try {
       using(var sender=new Button(){Name="CI_CATALOGUE_EDIT"})
        form.GetType().GetMethod("Button_SAVE_Click",Flags).Invoke(form,new object[]{sender,EventArgs.Empty});
      } finally {stop.Set();if(!watcher.Join(2000))throw new Exception("Catalogue edit watcher did not stop");}
     }
     if(failUpdate) {
      if(editsObserved!=1)throw new Exception("Expected catalogue adapter update failure warning");
      if(connection.State!=ConnectionState.Closed)throw new Exception("Adapter-owned connection state after update failure changed");
      if(table.Rows.Count!=2 || table.Rows[0].RowState!=DataRowState.Unchanged || table.Rows[1].RowState!=DataRowState.Modified)
       throw new Exception("Update failure must retain unaccepted Modified row");
      if(Convert.ToString(table.Rows[1]["Code"])!="CI_EDIT" || Convert.ToDecimal(table.Rows[1]["PRIX_MP"])!=88.5m ||
         Convert.ToString(table.Rows[1]["Code",DataRowVersion.Original])!="CI_NEW")
       throw new Exception("Update failure changed mapped or original in-memory versions");
      if(((Control)Get(form,"Label_ARTICLES")).Text!="CI_BEFORE_EDIT")throw new Exception("Update failure refreshed aggregates");
      if((File.Exists(editAuditPath)?File.ReadAllText(editAuditPath):null)!=editAuditBefore)throw new Exception("Update failure appended audit");
      connection.Open();
      VerifyCatalogueRow(connection,false);
      Eq(Scalar(connection,"SELECT COUNT(*) FROM TABLE_ARTICLES"),2m,"catalogue update failure preserves article count");
      Eq(Scalar(connection,"SELECT COUNT(*) FROM TABLE_ARTICLES WHERE ID=41 AND Code='CI_KEEP' AND Article='CI sentinel'"),1m,"catalogue update failure preserves existing article");
      Eq(Scalar(connection,"SELECT COUNT(*) FROM TABLE_MOUVEMENTS_STOCK"),1m,"catalogue update failure adds no movement");
      Eq(Scalar(connection,"SELECT ARTICLE FROM TABLE_NUM WHERE ID=0"),8m,"catalogue update failure leaves sequence");
      Sql(connection,"DROP TRIGGER CI_CATALOGUE_FAIL_UPDATE");connection.Close();
      Console.WriteLine("PASS original catalogue adapter update failure: persisted creation values unchanged, mapped Modified row retained with Original version, closed connection, no audit or refresh");
      return;
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

 static void CollectionVariantInsertion(Assembly assembly) {
  CultureInfo.CurrentCulture=CultureInfo.GetCultureInfo("en-US");
  using(var form=(Form)Activator.CreateInstance(assembly.GetType("LOGICA.Form_2_ARTICLES",true))) {
   var sizes=(DataGridView)Get(form,"DataGridView_TAILLES");sizes.AllowUserToAddRows=false;sizes.Rows.Clear();
   int size=sizes.Rows.Add();sizes.Rows[size].Cells["CODE_TAILLE"].Value="01";sizes.Rows[size].Cells["TAILLE"].Value="M";
   // Resource-defined code columns can be hidden; select the display column in the fixture.
   sizes.Columns["TAILLE"].Visible=true;sizes.CurrentCell=sizes.Rows[size].Cells["TAILLE"];
   var colors=(DataGridView)Get(form,"DataGridView_COULEURS");colors.AllowUserToAddRows=false;colors.Rows.Clear();
   int color=colors.Rows.Add();colors.Rows[color].Cells["CODE_COULEUR"].Value="02";colors.Rows[color].Cells["COULEUR"].Value="Blue";
   colors.Columns["COULEUR"].Visible=true;colors.CurrentCell=colors.Rows[color].Cells["COULEUR"];
   var grid=(DataGridView)Get(form,"DataGrid_COLLECTION");grid.AllowUserToAddRows=false;grid.Rows.Clear();
   SetText(form,"Text_CODE_COLLECTION","221234");SetText(form,"Text_ARTICLE_COLLECTION"," CI's variant ");
   SetText(form,"Text_PRIX_A_COLLECTION","10");SetText(form,"Text_PRIX_V_COLLECTION","20");SetText(form,"Text_QTE_COLLECTION","1.25");
   var insert=form.GetType().GetMethod("Button_INSERER_Click",Flags);
   using(var sender=new Button(){Name="CI_VARIANT_INSERT"})insert.Invoke(form,new object[]{sender,EventArgs.Empty});
   if(grid.Rows.Count!=1)throw new Exception("Variant insertion did not append one row");
   for(int sample=0;sample<2;sample++) {
    if(sample==1) {
     colors.Rows[color].Cells["CODE_COULEUR"].Value="03";colors.Rows[color].Cells["COULEUR"].Value="Red";
     SetText(form,"Text_QTE_COLLECTION","-0.5");
     using(var sender=new Button(){Name="CI_VARIANT_SECOND"})insert.Invoke(form,new object[]{sender,EventArgs.Empty});
    }
    string payload=sample==0?"221234990102":"221234990103";
    int sum=0,weight=3;
    for(int index=payload.Length-1;index>=0;index--){sum+=(payload[index]-'0')*weight;weight=4-weight;}
    string expected=payload+((10-sum%10)%10).ToString(CultureInfo.InvariantCulture);
    var row=grid.Rows[sample];
    if(Convert.ToString(row.Cells["CODE_BARRE_LISTE"].Value)!=expected ||
       Convert.ToString(row.Cells["ARTICLE_LISTE"].Value)!=" CI's variant " ||
       Convert.ToString(row.Cells["TAILLE_LISTE"].Value)!="M" ||
       Convert.ToString(row.Cells["COULEUR_LISTE"].Value)!=(sample==0?"Blue":"Red"))
     throw new Exception("Variant barcode or raw attributes changed");
    Eq(Convert.ToDecimal(row.Cells["Qté_LISTE"].Value),sample==0?1.25m:-0.5m,"variant stored quantity");
    if(((Control)Get(form,"Text_QTE_COLLECTION")).Text!="0" || grid.CurrentCell.RowIndex!=sample)
     throw new Exception("Variant quantity reset/last-row selection changed");
    Eq(decimal.Parse(((Control)Get(form,"Label_TOTAL_QUANTITE_DOC")).Text),sample==0?1.25m:0.75m,"variant total quantity");
    Eq(decimal.Parse(((Control)Get(form,"Label_NBR_ARTICLES_DOC")).Text),sample+1,"variant row count");
    if(sample==0) {
     SetText(form,"Text_QTE_COLLECTION","2.5");
     int warnings=0;uint threadId=GetCurrentThreadId();
     using(var stop=new ManualResetEvent(false)) {
      var watcher=new Thread(delegate() {
       while(!stop.WaitOne(100))if(DismissInjectedFailure(threadId,"Le CODE_BARRE est déja utilisé"))Interlocked.Increment(ref warnings);
      });watcher.IsBackground=true;watcher.Start();
      try {using(var sender=new Button(){Name="CI_VARIANT_DUPLICATE"})insert.Invoke(form,new object[]{sender,EventArgs.Empty});}
      finally {stop.Set();if(!watcher.Join(2000))throw new Exception("Variant watcher did not stop");}
     }
     if(warnings!=1 || grid.Rows.Count!=1 || ((Control)Get(form,"Text_QTE_COLLECTION")).Text!="2.5" ||
        Convert.ToDecimal(grid.Rows[0].Cells["Qté_LISTE"].Value)!=1.25m ||
        decimal.Parse(((Control)Get(form,"Label_TOTAL_QUANTITE_DOC")).Text)!=1.25m)
      throw new Exception("Duplicate variant changed rows, totals or pending quantity");
    }
   }
   Console.WriteLine("PASS original variant insertion: independent barcode, five values, fractional/negative quantities, totals/reset/selection and duplicate rejection; no database writes");
  }
 }

 static void CollectionQuantityTotals(Assembly assembly) {
  CultureInfo.CurrentCulture=CultureInfo.GetCultureInfo("en-US");
  using(var form=(Form)Activator.CreateInstance(assembly.GetType("LOGICA.Form_2_ARTICLES",true))) {
   var grid=(DataGridView)Get(form,"DataGrid_COLLECTION");grid.AllowUserToAddRows=false;
   object[][] cases={new object[0],new object[]{1.25m,-0.5m},new object[]{"1.25","-0.5"},new object[]{2,(short)3,-1L},new object[]{0m}};
   decimal[] expected={0m,0.75m,0.75m,4m,0m};
   var calculate=form.GetType().GetMethod("Button_CALC_DOC_Click",Flags);
   for(int scenario=0;scenario<cases.Length;scenario++) {
    grid.Rows.Clear();
    for(int index=0;index<cases[scenario].Length;index++) {
     int row=grid.Rows.Add();
     grid.Rows[row].Cells["CODE_BARRE_LISTE"].Value="CI_TOTAL_"+index;
     grid.Rows[row].Cells["Qté_LISTE"].Value=cases[scenario][index];
    }
    SetText(form,"Label_TOTAL_QUANTITE_DOC","CI_BEFORE_TOTAL");SetText(form,"Label_NBR_ARTICLES_DOC","CI_BEFORE_COUNT");
    using(var sender=new Button(){Name="CI_COLLECTION_TOTALS"})calculate.Invoke(form,new object[]{sender,EventArgs.Empty});
    Eq(decimal.Parse(((Control)Get(form,"Label_TOTAL_QUANTITE_DOC")).Text),expected[scenario],"original collection total scenario "+scenario);
    Eq(decimal.Parse(((Control)Get(form,"Label_NBR_ARTICLES_DOC")).Text),cases[scenario].Length,"original collection count scenario "+scenario);
    if(grid.Rows.Count!=cases[scenario].Length)throw new Exception("Quantity total changed grid rows");
    for(int index=0;index<cases[scenario].Length;index++)
     if(!Object.Equals(grid.Rows[index].Cells["Qté_LISTE"].Value,cases[scenario][index]))
      throw new Exception("Quantity total changed raw cell values");
   }
   Console.WriteLine("PASS original collection quantity totals: empty, decimal, numeric string, integer and zero cells; display updated and raw rows unchanged");
  }
 }

 static void CatalogueAggregateRefresh(Assembly assembly,bool failLookup=false) {
  CultureInfo.CurrentCulture=CultureInfo.GetCultureInfo("en-US");
  var module=assembly.GetType("LOGICA.Module1",true);
  var connection=(IDbConnection)module.GetField("cn_SQL").GetValue(null);
  var fixture=new System.Data.Common.DbConnectionStringBuilder();fixture.ConnectionString=connection.ConnectionString;
  if(connection.Database!="logica_ci" || !fixture.ContainsKey("server") || Convert.ToString(fixture["server"])!="127.0.0.1" ||
     !fixture.ContainsKey("port") || Convert.ToInt32(fixture["port"])!=3307)
   throw new Exception("Aggregate fixture requires exactly 127.0.0.1:3307/logica_ci");
  connection.Open();
  Sql(connection,"DROP TABLE IF EXISTS TABLE_ARTICLES; CREATE TABLE TABLE_ARTICLES (ID INT PRIMARY KEY,Famille VARCHAR(30),STOCK DECIMAL(14,4),Alert DECIMAL(14,4),PROMOTION DECIMAL(14,4),PRIX_MP DECIMAL(14,4),PRIX_A DECIMAL(14,4),PRIX_V_1 DECIMAL(14,4),PRIX_QTE DECIMAL(14,4)) ENGINE=InnoDB");
  Sql(connection,"INSERT INTO TABLE_ARTICLES VALUES (1,'A',5,6,10,2,3,4,7),(2,'A',-2,0,0,2,3,4,0),(3,'A',0,2,5,0,8,0,0),(4,'B',3,1,0,0,4,6,2),(5,'B',2,2,1,1,0,0,0),(6,'B',1,0,0,4,5,7,0)");
  if(failLookup)Sql(connection,"ALTER TABLE TABLE_ARTICLES CHANGE PRIX_MP CI_MISSING_MP DECIMAL(14,4)");
  connection.Close();
  using(var form=(Form)Activator.CreateInstance(assembly.GetType("LOGICA.Form_2_ARTICLES",true))) {
   string[] labels={"Label_ARTICLES","Label_ALERTS_STOCK","Label_STOCK_NEGATIF","Label_PROMOTIONS","Label_VALEURSTOCK_MP","Label_VALEURSTOCK_MP_NON","Label_VALEURSTOCK_A","Label_VALEURSTOCK_A_NON","Label_VALEURSTOCK_V","Label_VALEURSTOCK_V_NON","Label_PRIX_QTE"};
   string[] filters=failLookup?new[]{null,"A"}:new[]{null,"","A","B","MISSING"};
   decimal[][] expected={new[]{6m,3m,1m,3m,16m,3m,32m,3m,45m,3m,2m},new[]{6m,3m,1m,3m,16m,3m,32m,3m,45m,3m,2m},new[]{3m,2m,1m,2m,10m,2m,15m,2m,20m,2m,1m},new[]{3m,1m,0m,1m,6m,1m,17m,1m,25m,1m,1m},new decimal[11]};
   for(int scenario=0;scenario<filters.Length;scenario++) {
    form.GetType().GetField("_FAMILLE_FILTRE",Flags).SetValue(form,filters[scenario]);
    form.GetType().GetField("_sql",Flags).SetValue(form,"CI_BEFORE_FILTER");
    foreach(string label in labels)SetText(form,label,"CI_BEFORE_REFRESH");
    int warnings=0;uint threadId=GetCurrentThreadId();
    using(var stop=new ManualResetEvent(false)) {
     Thread watcher=null;
     if(failLookup) {
      watcher=new Thread(delegate() {
       while(!stop.WaitOne(100))if(DismissInjectedFailure(threadId,"PRIX_MP"))Interlocked.Increment(ref warnings);
      });watcher.IsBackground=true;watcher.Start();
     }
     try {
      using(var sender=new Button(){Name="CI_AGGREGATE_REFRESH"})
       form.GetType().GetMethod("Button_CALC_Click",Flags).Invoke(form,new object[]{sender,EventArgs.Empty});
     } finally {stop.Set();if(watcher!=null && !watcher.Join(2000))throw new Exception("Aggregate failure watcher did not stop");}
    }
    if(failLookup) {
     if(warnings!=1)throw new Exception("Expected aggregate lookup warning");
     foreach(string label in labels)if(((Control)Get(form,label)).Text!="CI_BEFORE_REFRESH")throw new Exception("Failed aggregate lookup partially changed labels");
     string failedSql=Convert.ToString(form.GetType().GetField("_sql",Flags).GetValue(form));
     if(failedSql!=(scenario==0?"":"CI_BEFORE_FILTER"))throw new Exception("Aggregate failure changed filter side effect");
     if(connection.State!=ConnectionState.Closed)throw new Exception("Aggregate failure left adapter-owned connection open");
     continue;
    }
    for(int index=0;index<labels.Length;index++) {
     string value=((Control)Get(form,labels[index])).Text;
     if(index==4 || index==6 || index==8) {
      if(value.Length!=20 || !value.EndsWith(" DH",StringComparison.Ordinal))throw new Exception("Aggregate money mask changed");
      value=value.TrimStart('#');value=value.Substring(0,value.Length-3);
     }
     Eq(decimal.Parse(value),expected[scenario][index],"catalogue aggregate filter "+scenario+" "+labels[index]);
    }
    string sql=Convert.ToString(form.GetType().GetField("_sql",Flags).GetValue(form));
    if(sql!=(scenario<2?"":"CI_BEFORE_FILTER"))throw new Exception("Aggregate filter SQL-field side effect changed");
    if(connection.State!=ConnectionState.Closed)throw new Exception("Aggregate refresh left connection open");
   }
  }
  connection.Open();Eq(Scalar(connection,"SELECT COUNT(*) FROM TABLE_ARTICLES"),6m,"aggregate refresh leaves fixture rows unchanged");connection.Close();
  Console.WriteLine(failLookup?"PASS original aggregate lookup failure: unchanged eleven labels, expected warning, filter side effect and closed connection":"PASS original catalogue aggregates: all 11 outputs for null/empty/family/missing filters, NULL sums, legacy purchase exclusion, mask and connection state");
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


 static void ClientSettlementSave(Assembly assembly) {
  CultureInfo.CurrentCulture=CultureInfo.GetCultureInfo("en-US");
  var module=assembly.GetType("LOGICA.Module1",true);
  var connection=(IDbConnection)module.GetField("cn_SQL").GetValue(null);
  var builder=new System.Data.Common.DbConnectionStringBuilder { ConnectionString=connection.ConnectionString };
  if(connection.Database!="logica_ci" || !builder.ContainsKey("server") ||
     Convert.ToString(builder["server"])!="127.0.0.1" ||
     !builder.ContainsKey("port") || Convert.ToInt32(builder["port"])!=3307)
   throw new Exception("Client settlement fixture requires 127.0.0.1:3307/logica_ci");
  connection.Open();
  Sql(connection,"DROP TABLE IF EXISTS TABLE_CLIENTS_REGLE; CREATE TABLE TABLE_CLIENTS_REGLE ("+
    "ID INT PRIMARY KEY, DATES DATE, UTILISATEUR VARCHAR(100), ID_REGLE VARCHAR(100), "+
    "ID_CLIENT VARCHAR(50), CODE_CLIENT VARCHAR(50), CLIENT VARCHAR(100), "+
    "MONTANT DECIMAL(14,4), MODE_P VARCHAR(60), NOTES VARCHAR(100), ETAT VARCHAR(30)) ENGINE=InnoDB; "+
    "INSERT INTO TABLE_CLIENTS_REGLE (ID,DATES,UTILISATEUR,ID_REGLE,ID_CLIENT,CODE_CLIENT,CLIENT,MONTANT,MODE_P,NOTES,ETAT) "+
    "VALUES (7,'2026-01-01','CI_BEFORE','PREV','C0','OLD','Sentinel',5,'CARTE','keep','VALIDER')");
  connection.Close();
  var forms=assembly.GetType("LOGICA.My.MyProject",true).GetProperty("Forms",Flags).GetValue(null,null);
  var template=Get(forms,"Form_0_TEMPLATE");
  SetText(template,"Label_POSTE","CI_TEST");
  using(var form=(Form)Activator.CreateInstance(assembly.GetType("LOGICA.Form_5_CLIENTS_REGLE",true))) {
   var adapterType=connection.GetType().Assembly.GetType("MySql.Data.MySqlClient.MySqlDataAdapter",true);
   using(var adapter=(System.Data.Common.DbDataAdapter)Activator.CreateInstance(adapterType,new object[]{"SELECT * FROM TABLE_CLIENTS_REGLE",connection})) {
    var table=new DataTable();adapter.Fill(table);
    form.GetType().GetField("DT",Flags).SetValue(form,table);
    form.GetType().GetField("DA",Flags).SetValue(form,adapter);
    var client=Get(form,"Button_CLIENT");
    client.GetType().GetProperty("_ID_Button").SetValue(client,"C123",null);
    client.GetType().GetProperty("_CODE_Button").SetValue(client,"BC123",null);
    ((Control)client).Text="Test client";
    SetText(form,"Label_TOP","NOUVEAU");
    SetText(form,"Text_UTILISATEUR","CI_CASHIER");
    SetText(form,"TextBox_MONTANT","12.75");
    SetText(form,"Combo_MODE_P","ESPECES");
    SetText(form,"TextBox_NOTES","CI_TEST_NOTE");
    ((DateTimePicker)Get(form,"DateTimePicker_DATE")).Value=new DateTime(2026,1,3);
    int observed=0;uint threadId=GetCurrentThreadId();
    using(var stop=new ManualResetEvent(false)) {
     var watcher=new Thread(delegate() {
      while(!stop.WaitOne(60))
       if(DismissInjectedFailure(threadId,"Enregistré avec succès"))Interlocked.Increment(ref observed);
     });watcher.IsBackground=true;watcher.Start();
     try {form.GetType().GetMethod("Button12_Click",Flags).Invoke(form,new object[]{form,EventArgs.Empty});}
     finally {stop.Set();if(!watcher.Join(2000))throw new Exception("Settlement watcher did not stop");}
    }
    if(observed==0)throw new Exception("Original settlement success dialog was not observed");
    if(table.GetChanges()!=null || table.Rows.Count!=2)throw new Exception("Settlement adapter did not accept inserted row");
   }
  }
  if(connection.State!=ConnectionState.Closed)throw new Exception("Settlement save left connection open");
  connection.Open();
  Eq(Scalar(connection,"SELECT COUNT(*) FROM TABLE_CLIENTS_REGLE"),2m,"settlement preserves original row and adds one");
  Eq(Scalar(connection,"SELECT COUNT(*) FROM TABLE_CLIENTS_REGLE WHERE ID=7 AND ID_REGLE='PREV' AND MONTANT=5 AND NOTES='keep'"),1m,"settlement sentinel untouched");
  Eq(Scalar(connection,"SELECT COUNT(*) FROM TABLE_CLIENTS_REGLE WHERE ID=8 AND ID_CLIENT='C123' AND CODE_CLIENT='BC123' AND CLIENT='Test client' AND MONTANT=12.75 AND MODE_P='ESPECES' AND UTILISATEUR='CI_CASHIER' AND NOTES='CI_TEST_NOTE' AND ETAT='VALIDER' AND DATES='2026-01-03'"),1m,"settlement exact persisted fields");
  connection.Close();
  Console.WriteLine("PASS original client settlement accepted save: commandbuilder insert, next ID, row data, connection and sentinel");
 }

 [STAThread] static int Main(string[] args) {
  try {
   Application.EnableVisualStyles();
   var assembly=Assembly.LoadFrom(Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"LOGICA.exe"));
   if(args[0]=="client-settlement-save") { ClientSettlementSave(assembly); } else if(args[0]=="catalogue-aggregate-failure") { CatalogueAggregateRefresh(assembly,true); } else if(args[0]=="catalogue-aggregate-refresh") { CatalogueAggregateRefresh(assembly); } else if(args[0]=="collection-quantity-totals") { CollectionQuantityTotals(assembly); } else if(args[0]=="collection-variant-insert") { CollectionVariantInsertion(assembly); } else if(args[0]=="collection-duplicate-later") { CatalogueSaveGuards(assembly,true,true,true); } else if(args[0]=="collection-duplicate-code") { CatalogueSaveGuards(assembly,true,true); } else if(args[0]=="collection-save-guards") { CatalogueSaveGuards(assembly,true); } else if(args[0]=="catalogue-balance-reject") { CatalogueCreateProduct(assembly,balanceScenario:"reject"); } else if(args[0]=="catalogue-balance-format") { CatalogueCreateProduct(assembly,balanceScenario:"format"); } else if(args[0]=="catalogue-create-empty") { CatalogueCreateProduct(assembly,emptyArticles:true); } else if(args[0]=="catalogue-create-null-sequence") { CatalogueCreateProduct(assembly,nullSequence:true); } else if(args[0]=="catalogue-create-empty-null") { CatalogueCreateProduct(assembly,emptyArticles:true,nullSequence:true); } else if(args[0]=="catalogue-update-failure") { CatalogueCreateProduct(assembly,true,failUpdate:true); } else if(args[0]=="catalogue-insert-failure") { CatalogueCreateProduct(assembly,false,false,false,false,true); } else if(args[0]=="catalogue-sequence-failure") { CatalogueCreateProduct(assembly,false,false,false,true); } else if(args[0]=="catalogue-movement-failure") { CatalogueCreateProduct(assembly,false,false,true); } else if(args[0]=="catalogue-duplicates") { CatalogueCreateProduct(assembly,true,true); } else if(args[0]=="catalogue-edit") { CatalogueCreateProduct(assembly,true); } else if(args[0]=="catalogue-create") { CatalogueCreateProduct(assembly); } else if(args[0]=="catalogue-barcodes") { CatalogueGeneratedBarcodes(assembly); } else if(args[0]=="catalogue-save-guards") { CatalogueSaveGuards(assembly); } else if(args[0]=="catalogue-keys") { CatalogueKeys(assembly); } else if(args[0]=="cash-counting") { CountedCash(assembly); } else if(args[0]=="stock-movement-search-failure") { StockMovementSearch(assembly,true); } else if(args[0]=="stock-movement-search") { StockMovementSearch(assembly); } else if(args[0]=="checkout-missing-stock-lookup") { Checkout(assembly,false,"stock-missing-lookup"); } else if(args[0]=="checkout-reject-stock") { Checkout(assembly,false,"reject-stock"); } else if(args[0]=="checkout-reject-stock-off") { Checkout(assembly,false,"reject-stock-off"); } else if(args[0]=="checkout-stock-exact") { Checkout(assembly,false,"stock-exact"); } else if(args[0]=="checkout-reject-total") { Checkout(assembly,false,"reject-total"); } else if(args[0]=="checkout-rounding-window") { Checkout(assembly,false,"rounding-window"); } else if(args[0]=="checkout-select-seller") { Checkout(assembly,false,"select-seller"); } else if(args[0]=="checkout-select-client") { Checkout(assembly,false,"select-client"); } else if(args[0]=="checkout-credit-client") { Checkout(assembly,false,"select-credit-client"); } else if(args[0]=="checkout-reject-sale") { Checkout(assembly,false,"reject-sale"); } else if(args[0]=="checkout-reject-return") { Checkout(assembly,false,"reject-return"); } else if(args[0]=="checkout-reject-empty") { Checkout(assembly,false,"reject-empty"); } else if(args[0]=="checkout-stock-off") { Checkout(assembly,false,"stock-off"); } else if(args[0]=="checkout-fractional") { Checkout(assembly,false,"fractional"); } else if(args[0]=="checkout-late-rollback") { Checkout(assembly,true,"cash",true); } else if(args[0]=="checkout-mixed") { Checkout(assembly,false,"mixed"); } else if(args[0]=="checkout-change") { Checkout(assembly,false,"change"); } else if(args[0]=="checkout-credit") { Checkout(assembly,false,"credit"); } else if(args[0]=="checkout-rollback") { Checkout(assembly,true); } else if(args[0]=="checkout") { Checkout(assembly); } else if(args[0]=="inventory-decline-validation") { DeclinedValidationGuard(assembly); } else if(args[0]=="inventory-empty-validation") { EmptyValidationGuard(assembly); } else if(args[0]=="inventory-transaction-preflight") { InventoryTransactionPreflight(assembly); } else if(args[0]=="basket") { Basket(assembly); } else if(args[0]=="rounding") {
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
