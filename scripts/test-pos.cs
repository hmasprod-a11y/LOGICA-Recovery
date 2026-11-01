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

 static void SharedExportProjection(Assembly assembly) {
  var exporter=assembly.GetType("LOGICA.Infrastructure.Export.WinFormsGridExcelExporter",true);
  var export=exporter.GetMethod("Export",Flags);
  if(export==null)throw new Exception("Shared export adapter missing");
  foreach(var category in new[]{"stock-movement","client-settlement"}) {
   using(var grid=new DataGridView()) {
    grid.AllowUserToAddRows=false;
    grid.Columns.Add(new DataGridViewTextBoxColumn { Name="CODE",HeaderText="CODE",ValueType=typeof(string) });
    grid.Columns.Add(new DataGridViewTextBoxColumn { Name="VALUE",HeaderText="VALUE",ValueType=typeof(string) });
    grid.Columns.Add(new DataGridViewButtonColumn { Name="ACTION",HeaderText="ACTION" });
    grid.Rows.Add(category,null,"ignored");
    string output=Path.Combine(Path.GetTempPath(),"logica-export-"+Guid.NewGuid().ToString("N")+".xlsx");
    try {
     export.Invoke(null,new object[]{grid,output});
     if(!File.Exists(output))throw new Exception("Export file missing: "+category);
     var bytes=File.ReadAllBytes(output);
     if(bytes.Length<100 || bytes[0]!=0x50 || bytes[1]!=0x4B)
      throw new Exception("Excel workbook is not a ZIP container: "+category);
     if((string)grid.Rows[0].Cells[1].Value!="-")
      throw new Exception("Legacy null mutation lost: "+category);
     Console.WriteLine("PASS "+category+" shared Excel exporter: workbook and null mutation");
    } finally {if(File.Exists(output))File.Delete(output);}
   }
  }
 }

 static void CheckoutBarcodeChooser(Assembly assembly) {
  var type=assembly.GetType("LOGICA.Presentation.Checkout.CheckoutBarcodeChoiceDialog",true);
  var choose=type.GetMethod("Choose",Flags);
  var describe=type.GetMethod("Describe",Flags);
  DataTable rows=new DataTable();
  foreach(string column in new[]{"ID_ARTICLE","Code","Article","Prix_V_1"})rows.Columns.Add(column);
  rows.Rows.Add("11","SAME-001","Small", "12.50");
  rows.Rows.Add("12","SAME-001","Large", "19.50");
  string label=(string)describe.Invoke(null,new object[]{rows.Rows[1],"Prix_V_1"});
  if(!label.Contains("Large") || !label.Contains("19.50") || !label.Contains("ID: 12"))
   throw new Exception("Duplicate barcode dialog does not display selected variant and active price");
  foreach(int expected in new[]{1,-1}) {
   bool found=false;
   using(var timer=new System.Windows.Forms.Timer()) {
    timer.Interval=100;
    timer.Tick+=delegate(object sender,EventArgs e) {
     Form dialog=null;
     foreach(Form open in Application.OpenForms)
      if(open.Text=="Hanouty — choisir un article") {dialog=open;break;}
     if(dialog==null)return;
     found=true;
     ListBox list=null;
     foreach(Control control in dialog.Controls)
      if(control is ListBox) {list=(ListBox)control;break;}
     if(list==null || list.Items.Count!=2)throw new Exception("Duplicate chooser missing product options");
     timer.Stop();
     if(expected==-1) ((Button)dialog.CancelButton).PerformClick();
     else {
      list.SelectedIndex=expected;
      ((Button)dialog.AcceptButton).PerformClick();
     }
    };
    timer.Start();
    int result=(int)choose.Invoke(null,new object[]{rows,"Prix_V_1"});
    timer.Stop();
    if(!found || result!=expected)throw new Exception("Duplicate chooser modal result mismatch: "+result+" expected "+expected);
   }
  }
  // Exercise the exact production Application service via the compiled net48 POS.
  // This is a non-posting fixture; no shop data or checkout rows are modified.
  var selection=assembly.GetType("LOGICA.ApplicationLayer.Checkout.CheckoutBarcodeSelectionService",true);
  var identity=selection.GetMethod("IsSameBasketArticle",Flags);
  Func<object,object,bool> identityEquals=delegate(object left,object right) {
   return Object.Equals(left,right);
  };
  bool same=(bool)identity.Invoke(null,new object[]{rows.Rows[0],"SAME-001","11",identityEquals});
  bool otherVariant=(bool)identity.Invoke(null,new object[]{rows.Rows[0],"SAME-001","12",identityEquals});
  bool otherCode=(bool)identity.Invoke(null,new object[]{rows.Rows[0],"OTHER","11",identityEquals});
  if(!same||otherVariant||otherCode)
   throw new Exception("Windows compiled checkout merges a different variant or loses same article identity");
  Console.WriteLine("PASS Windows duplicate barcode chooser: two variants, active price, selected row and Cancel");
 }

 static int SearchRows(IDbConnection connection, string sql, string pattern, string parameterName="@search") {
  using(var command=connection.CreateCommand()) {
   command.CommandText=sql;
   var parameter=command.CreateParameter();
   parameter.ParameterName=parameterName;
   parameter.Value=pattern;
   command.Parameters.Add(parameter);
   int count=0;
   using(var reader=command.ExecuteReader())while(reader.Read())count++;
   return count;
  }
 }
 static void CheckoutArticleSearchSql(Assembly assembly) {
  var query=assembly.GetType("LOGICA.Infrastructure.Checkout.CheckoutArticleSearchQueryText",true);
  var list=(string)query.GetMethod("List",Flags).Invoke(null,null);
  var images=(string)query.GetMethod("Images",Flags).Invoke(null,null);
  var pattern=query.GetMethod("Pattern",Flags);
  if(!list.Contains("Article like @search") || !list.Contains("Code like @search") ||
     !images.Contains("Article like @search") || !images.Contains("Images <> '0.png'"))
   throw new Exception("Production search query is not parameterized");
  var module=assembly.GetType("LOGICA.Module1",true);
  using(var connection=(IDbConnection)module.GetField("cn_SQL").GetValue(null)) {
   if(!connection.ConnectionString.Contains("127.0.0.1") || !connection.ConnectionString.Contains("logica_ci"))
    throw new Exception("Article search test requires isolated database");
   connection.Open();
   // Temporary table shadows recovered data on this connection only.
   Sql(connection,"CREATE TEMPORARY TABLE TABLE_ARTICLES (Article VARCHAR(120) CHARACTER SET utf8mb4, Code VARCHAR(50), Images VARCHAR(80))");
   try {
    Sql(connection,"INSERT INTO TABLE_ARTICLES VALUES ('Alpha O''Hara','ABC-001','photo.png'),('Alpha Percent%','ABC_002','0.png'),('Beta','XYZ-003','photo2.png'),('Quote X'' OR 1=1 --','X-004','0.png')");
    string[] terms={"Alpha","O'Hara","ABC-001","zzz' OR 1=1 -- ","%","_","Quote X'"};
    int[] expectedList={2,1,1,0,4,4,1};
    int[] expectedImages={1,1,0,0,2,2,0};
    for(int i=0;i<terms.Length;i++) {
     string value=(string)pattern.Invoke(null,new object[]{terms[i]});
     int actualList=SearchRows(connection,list,value);
     int actualImages=SearchRows(connection,images,value);
     if(actualList!=expectedList[i] || actualImages!=expectedImages[i])
      throw new Exception("Article search mismatch for "+terms[i]+": list="+actualList+" images="+actualImages);
    }
    // Scanner lookup must remain exact equality and preserve all matching rows
    // (the legacy UI takes the first row; duplicate-choice UX is a separate change).
    string barcodeSql=(string)query.GetMethod("ExactBarcode",Flags).Invoke(null,null);
    if(barcodeSql!="select * from TABLE_ARTICLES WHERE Code = @code")
     throw new Exception("Barcode scan SQL changed or contains unsafe text interpolation");
    Sql(connection,"INSERT INTO TABLE_ARTICLES VALUES ('Quote barcode','O''Hara','photo.png'),('Literal attack','x'' OR 1=1 --','photo.png')");
    string[] scanned={ "ABC-001", "ABC_002", "X-004", "ABC", "nope' OR 1=1 -- ", "%", "", "O'Hara", "x' OR 1=1 --" };
    int[] expected={ 1, 1, 1, 0, 0, 0, 0, 1, 1 };
    for(int i=0;i<scanned.Length;i++) {
     int actual=SearchRows(connection,barcodeSql,scanned[i],"@code");
     if(actual!=expected[i])
      throw new Exception("Exact barcode scan mismatch for "+scanned[i]+": "+actual+" expected "+expected[i]);
    }
    Sql(connection,"INSERT INTO TABLE_ARTICLES VALUES ('Duplicate variant','ABC-001','photo.png')");
    if(SearchRows(connection,barcodeSql,"ABC-001","@code")!=2)
     throw new Exception("Duplicate barcode lookup must retain both rows for future chooser");
    Console.WriteLine("PASS isolated MariaDB article search: 14 list/image checks + 10 exact barcode scans (quotes, injection, wildcard, duplicates)");
   } finally {Sql(connection,"DROP TEMPORARY TABLE IF EXISTS TABLE_ARTICLES");}
  }
 }


 static void CheckoutImageGrid(Assembly assembly) {
  var module=assembly.GetType("LOGICA.Module1",true);
  var field=module.GetField("_CHEMIN_FOLDER",Flags);
  object originalFolder=field.GetValue(null);
  string root=AppDomain.CurrentDomain.BaseDirectory.TrimEnd(Path.DirectorySeparatorChar);
  string images=Path.Combine(root,"bd","images");
  Directory.CreateDirectory(images);
  string good=Path.Combine(images,"hanouty_ci_real.png");
  string corrupt=Path.Combine(images,"hanouty_ci_corrupt.png");
  string missing=Path.Combine(images,"hanouty_ci_missing.png");
  if(File.Exists(good)||File.Exists(corrupt)||File.Exists(missing))
   throw new Exception("Image fixture paths unexpectedly occupied");
  try {
   field.SetValue(null,root);
   using(var bitmap=new Bitmap(2,2))bitmap.Save(good,System.Drawing.Imaging.ImageFormat.Png);
   File.WriteAllText(corrupt,"not a decodable image");
   var loader=assembly.GetType("LOGICA.Infrastructure.Checkout.CheckoutArticleImageLoader",true);
   var load=loader.GetMethod("Load",Flags);
   using(var image=(Bitmap)load.Invoke(null,new object[]{images,"hanouty_ci_real.png"}))
    if(image==null||image.Width!=2)throw new Exception("Real product image did not load");
   foreach(string name in new[]{"0.png","0X.png","hanouty_ci_missing.png","hanouty_ci_corrupt.png","../hanouty_ci_real.png",""})
    if(load.Invoke(null,new object[]{images,name})!=null)
     throw new Exception("Invalid product image generated a tile: "+name);
   using(var connection=(IDbConnection)module.GetField("cn_SQL",Flags).GetValue(null)) {
    if(!connection.ConnectionString.Contains("127.0.0.1")||!connection.ConnectionString.Contains("logica_ci"))
     throw new Exception("Image grid fixture requires isolated MariaDB");
    connection.Open();
    Sql(connection,"CREATE TEMPORARY TABLE TABLE_ARTICLES (ID_ARTICLE INT NOT NULL AUTO_INCREMENT PRIMARY KEY,Article VARCHAR(120),Code VARCHAR(60),Images VARCHAR(100),Famille VARCHAR(80),PRIX_V_1 DECIMAL(14,2))");
    try {
     Sql(connection,"INSERT INTO TABLE_ARTICLES (Article,Code,Images,Famille,PRIX_V_1) VALUES "+
      "('CI Item real','CI_IMAGE_REAL','hanouty_ci_real.png','CI_IMAGE',12.5),"+
      "('CI Item missing','CI_IMAGE_MISSING','hanouty_ci_missing.png','CI_IMAGE',10),"+
      "('CI Item placeholder','CI_IMAGE_DEFAULT','0.png','CI_IMAGE',10),"+
      "('CI Item corrupt','CI_IMAGE_CORRUPT','hanouty_ci_corrupt.png','CI_IMAGE',10),"+
      "('CI Item blank','CI_IMAGE_BLANK','','CI_IMAGE',10)");
     using(var sale=(Form)Activator.CreateInstance(assembly.GetType("LOGICA.Form_3_VENTE",true))) {
      var tiles=(FlowLayoutPanel)Get(sale,"FlowLayout_ARTICLES");
      using(var family=new Button(){Text="CI_IMAGE"}) {
       sale.GetType().GetMethod("FAM2_click",Flags).Invoke(sale,new object[]{family,EventArgs.Empty});
      }
      if(tiles.Controls.Count!=1||Convert.ToString(tiles.Controls[0].Tag)!="CI_IMAGE_REAL")
       throw new Exception("Family image grid includes missing/placeholder/corrupt products: "+tiles.Controls.Count);
      var tabs=(TabControl)Get(sale,"TabControl2");
      tabs.SelectedIndex=0;
      ((Control)Get(sale,"Text_FIND")).Text="CI Item";
      sale.GetType().GetMethod("Text_FIND_TextChanged",Flags).Invoke(sale,new object[]{sale,EventArgs.Empty});
      var list=(DataGridView)Get(sale,"DataGridView100");
      var listData=list.DataSource as DataTable;
      if(listData==null||listData.Rows.Count!=5)
       throw new Exception("List mode must retain all five products");
      tabs.SelectedIndex=1;
      sale.GetType().GetMethod("Text_FIND_TextChanged",Flags).Invoke(sale,new object[]{sale,EventArgs.Empty});
      if(tiles.Controls.Count!=1||Convert.ToString(tiles.Controls[0].Tag)!="CI_IMAGE_REAL")
       throw new Exception("Search image grid includes products without a valid photo: "+tiles.Controls.Count);
             // An apostrophe is valid in a family name. An SQL-looking family
       // must be treated as an exact literal, never as a WHERE expression.
       Sql(connection,"INSERT INTO TABLE_ARTICLES (Article,Code,Images,Famille,PRIX_V_1) VALUES "+
        "('CI quote','CI_FAMILY_QUOTE','hanouty_ci_real.png','CI''IMAGE',15),"+
        "('CI literal','CI_FAMILY_LITERAL','hanouty_ci_real.png','CI_IMAGE'' OR ''1''=''1',15)");
       string[][] families={
        new[]{"CI'IMAGE","CI_FAMILY_QUOTE","1"},
        new[]{"CI_IMAGE' OR '1'='1","CI_FAMILY_LITERAL","1"},
        new[]{"CI_IMAGE' OR 1=1 -- ","","0"},
        new[]{"CI_IMAGE","CI_IMAGE_REAL","1"}
       };
       foreach(string[] scenario in families) {
        using(var family=new Button(){Text=scenario[0]})
         sale.GetType().GetMethod("FAM2_click",Flags).Invoke(sale,new object[]{family,EventArgs.Empty});
        int expectedCount=int.Parse(scenario[2],CultureInfo.InvariantCulture);
        if(tiles.Controls.Count!=expectedCount ||
           (expectedCount==1 && Convert.ToString(tiles.Controls[0].Tag)!=scenario[1]))
         throw new Exception("Family filter leaked rows or lost literal match: "+scenario[0]+
          " tiles="+tiles.Controls.Count);
       }
       // Image tiles identify a specific article, unlike the scanner which may
       // intentionally open the duplicate-barcode chooser.
       Sql(connection,"INSERT INTO TABLE_ARTICLES (Article,Code,Images,Famille,PRIX_V_1) VALUES "+
        "('CI Duplicate small','CI_SHARED','hanouty_ci_real.png','CI_DUPLICATE',12.5),"+
        "('CI Duplicate large','CI_SHARED','hanouty_ci_real.png','CI_DUPLICATE',19.5)");
       using(var family=new Button(){Text="CI_DUPLICATE"})
        sale.GetType().GetMethod("FAM2_click",Flags).Invoke(sale,new object[]{family,EventArgs.Empty});
       if(tiles.Controls.Count!=2)throw new Exception("Duplicate barcode image tiles missing");
       var tileType=assembly.GetType("LOGICA.ApplicationLayer.Checkout.CheckoutArticleTileReference",true);
       var tileSelection=assembly.GetType("LOGICA.ApplicationLayer.Checkout.CheckoutArticleTileSelectionService",true);
       var findExact=tileSelection.GetMethod("FindExact",Flags);
       object firstTag=tiles.Controls[0].Tag,secondTag=tiles.Controls[1].Tag;
       if(!tileType.IsInstanceOfType(firstTag)||!tileType.IsInstanceOfType(secondTag))
        throw new Exception("Image tiles lost their exact article identity");
       string firstId=Convert.ToString(tileType.GetProperty("ArticleId",Flags).GetValue(firstTag,null));
       string secondId=Convert.ToString(tileType.GetProperty("ArticleId",Flags).GetValue(secondTag,null));
       if(firstId==secondId || Convert.ToString(firstTag)!="CI_SHARED" || Convert.ToString(secondTag)!="CI_SHARED")
        throw new Exception("Image tiles must share barcode but keep different article IDs");
       var matches=new DataTable();
       using(var command=connection.CreateCommand()) {
        command.CommandText="SELECT * FROM TABLE_ARTICLES WHERE Code = @code";
        var parameter=command.CreateParameter();
        parameter.ParameterName="@code";
        parameter.Value="CI_SHARED";
        command.Parameters.Add(parameter);
        using(var reader=command.ExecuteReader())matches.Load(reader);
       }
       if(matches.Rows.Count!=2)throw new Exception("Isolated duplicate-barcode fixture missing");
       foreach(object tag in new[]{firstTag,secondTag}) {
        var selected=(DataRow)findExact.Invoke(null,new object[]{matches,tag});
        string expectedId=Convert.ToString(tileType.GetProperty("ArticleId",Flags).GetValue(tag,null));
        if(selected==null || Convert.ToString(selected["ID_ARTICLE"])!=expectedId)
         throw new Exception("Clicked image tile resolves to a different article variant");
       }
       matches.Rows.RemoveAt(1);
       object removedTag=secondId==Convert.ToString(matches.Rows[0]["ID_ARTICLE"]) ? firstTag : secondTag;
       if(findExact.Invoke(null,new object[]{matches,removedTag})!=null)
        throw new Exception("Stale image tile silently selected another variant");
       // Image-only products have no barcode: the WinForms tile must resolve
       // by parameterized article ID and still validate its original tile identity.
       Sql(connection,"INSERT INTO TABLE_ARTICLES (Article,Code,Images,Famille,PRIX_V_1) VALUES "+
        "('CI Image only','','hanouty_ci_real.png','CI_IMAGE_ONLY',8.5)");
       using(var family=new Button(){Text="CI_IMAGE_ONLY"})
        sale.GetType().GetMethod("FAM2_click",Flags).Invoke(sale,new object[]{family,EventArgs.Empty});
       if(tiles.Controls.Count!=1||!tileType.IsInstanceOfType(tiles.Controls[0].Tag))
        throw new Exception("Image-only product must create a typed image tile");
       object imageOnlyTag=tiles.Controls[0].Tag;
       if(Convert.ToString(imageOnlyTag)!="")
        throw new Exception("Image-only tile must retain its empty barcode");
       string imageOnlyId=Convert.ToString(tileType.GetProperty("ArticleId",Flags).GetValue(imageOnlyTag,null));
       var imageSqlMethod=sale.GetType().GetMethod("ExactImageArticleSql",Flags);
       if(imageSqlMethod==null||!imageSqlMethod.IsStatic)
        throw new Exception("Image-only lookup SQL method missing");
       string imageSql=(string)imageSqlMethod.Invoke(null,null);
       if(imageSql!="select * from TABLE_ARTICLES WHERE ID_ARTICLE = @id")
        throw new Exception("Image-only lookup must use parameterized ID_ARTICLE");
       var imageRows=new DataTable();
       using(var cmd=connection.CreateCommand()) {
        cmd.CommandText=imageSql;
        var idParam=cmd.CreateParameter();
        idParam.ParameterName="@id";
        idParam.Value=imageOnlyId;
        cmd.Parameters.Add(idParam);
        using(var reader=cmd.ExecuteReader())imageRows.Load(reader);
       }
       var imageRow=(DataRow)findExact.Invoke(null,new object[]{imageRows,imageOnlyTag});
       if(imageRows.Rows.Count!=1||imageRow==null||
          Convert.ToString(imageRow["ID_ARTICLE"])!=imageOnlyId||
          Convert.ToString(imageRow["Code"])!="")
        throw new Exception("Image-only ID lookup did not resolve the exact empty-barcode product");
       // A deleted article must never resolve to another image tile.
       using(var cmd=connection.CreateCommand()) {
        cmd.CommandText="DELETE FROM TABLE_ARTICLES WHERE ID_ARTICLE = @id";
        var idParam=cmd.CreateParameter();
        idParam.ParameterName="@id";
        idParam.Value=imageOnlyId;
        cmd.Parameters.Add(idParam);
        cmd.ExecuteNonQuery();
       }
       imageRows.Clear();
       using(var cmd=connection.CreateCommand()) {
        cmd.CommandText=imageSql;
        var idParam=cmd.CreateParameter();
        idParam.ParameterName="@id";
        idParam.Value=imageOnlyId;
        cmd.Parameters.Add(idParam);
        using(var reader=cmd.ExecuteReader())imageRows.Load(reader);
       }
       if(imageRows.Rows.Count!=0||findExact.Invoke(null,new object[]{imageRows,imageOnlyTag})!=null)
        throw new Exception("Deleted image-only article must fail closed");
       // List-only products have neither a barcode nor a photo. They must
       // remain selectable in list mode and resolve through the same exact-ID
       // SQL as image tiles, without appearing in the image grid.
       Sql(connection,"INSERT INTO TABLE_ARTICLES (Article,Code,Images,Famille,PRIX_V_1) VALUES "+
        "('CI List no barcode','','','CI_LIST_ONLY',7.5)");
       tabs.SelectedIndex=0;
       ((Control)Get(sale,"Text_FIND")).Text="CI List no barcode";
       sale.GetType().GetMethod("Text_FIND_TextChanged",Flags).Invoke(sale,new object[]{sale,EventArgs.Empty});
       var listOnlyData=list.DataSource as DataTable;
       if(listOnlyData==null || listOnlyData.Rows.Count!=1 || Convert.ToString(listOnlyData.Rows[0]["Code"])!="")
        throw new Exception("Barcode-free article missing from the full product list");
       var listReference=sale.GetType().GetMethod("BlankBarcodeListArticleReference",Flags);
       var listTag=listReference.Invoke(null,new object[]{listOnlyData.Rows[0]});
       if(!tileType.IsInstanceOfType(listTag))
        throw new Exception("List-only article did not retain a typed exact identity");
       string listId=Convert.ToString(tileType.GetProperty("ArticleId",Flags).GetValue(listTag,null));
       var listLookup=new DataTable();
       using(var cmd=connection.CreateCommand()) {
        cmd.CommandText=imageSql;
        var id=cmd.CreateParameter();
        id.ParameterName="@id"; id.Value=listId; cmd.Parameters.Add(id);
        using(var reader=cmd.ExecuteReader())listLookup.Load(reader);
       }
       if(listLookup.Rows.Count!=1 || findExact.Invoke(null,new object[]{listLookup,listTag})==null)
        throw new Exception("Barcode-free list article failed exact-ID lookup");
       tabs.SelectedIndex=1;
       sale.GetType().GetMethod("Text_FIND_TextChanged",Flags).Invoke(sale,new object[]{sale,EventArgs.Empty});
       if(tiles.Controls.Count!=0)
        throw new Exception("Product without photo leaked into image grid");
       using(var cmd=connection.CreateCommand()) {
        cmd.CommandText="DELETE FROM TABLE_ARTICLES WHERE ID_ARTICLE = @id";
        var id=cmd.CreateParameter(); id.ParameterName="@id"; id.Value=listId; cmd.Parameters.Add(id);
        cmd.ExecuteNonQuery();
       }
       listLookup.Clear();
       using(var cmd=connection.CreateCommand()) {
        cmd.CommandText=imageSql;
        var id=cmd.CreateParameter(); id.ParameterName="@id"; id.Value=listId; cmd.Parameters.Add(id);
        using(var reader=cmd.ExecuteReader())listLookup.Load(reader);
       }
       if(listLookup.Rows.Count!=0 || findExact.Invoke(null,new object[]{listLookup,listTag})!=null)
        throw new Exception("Deleted barcode-free list article must not resolve another product");
       Console.WriteLine("PASS isolated MariaDB barcode-free list article: exact ID, no image tile and stale deletion");
       Console.WriteLine("PASS isolated MariaDB image-only tile: exact ID, blank barcode and stale deletion");
       Console.WriteLine("PASS isolated MariaDB image tiles: same barcode, distinct article IDs, exact selection and stale-tile rejection");
       Console.WriteLine("PASS original Windows POS: parameterized family tiles, quotes, literal SQL text and injection rejection");
       Console.WriteLine("PASS original Windows POS: family and search image tiles real-only; list still shows all 5 products");
     }
    } finally {Sql(connection,"DROP TEMPORARY TABLE IF EXISTS TABLE_ARTICLES");}
   }
  } finally {
   field.SetValue(null,originalFolder);
   if(File.Exists(good))File.Delete(good);
   if(File.Exists(corrupt))File.Delete(corrupt);
  }
 }

 static void SalesFamilyCaptionContrast(Assembly assembly) {
  // Shop-configured family colors may be white, yellow, or dark. The two
  // sales family panels must use a foreground with at least 4.5:1 contrast.
  var type=assembly.GetType("LOGICA.Form_3_VENTE",true);
  var chooser=type.GetMethod("ReadableFamilyCaptionColor",Flags);
  if(chooser==null || !chooser.IsStatic)throw new Exception("Family caption contrast helper missing");
  Color[] backgrounds={Color.White,Color.Yellow,Color.FromArgb(171,185,211),
                       Color.FromArgb(128,128,128),Color.Navy,Color.Black};
  Color[] expected={Color.Black,Color.Black,Color.Black,
                    Color.Black,Color.White,Color.White};
  for(int i=0;i<backgrounds.Length;i++) {
   Color foreground=(Color)chooser.Invoke(null,new object[]{backgrounds[i]});
   if(foreground.ToArgb()!=expected[i].ToArgb())
    throw new Exception("Configured family background "+backgrounds[i]+" produced unreadable foreground "+foreground);
  }
  // These buttons are created on data load, so no query, family membership,
  // barcode or image-filter behavior is changed by this visual-only rule.
  Console.WriteLine("PASS configurable sales family button caption contrast: six light/dark palettes");
 }

 static void SalesProductListSelectionContrast(Assembly assembly) {
  // The original list selects rows on light blue, but inherited selection text
  // can be white. Keep the original highlight and use a dark explicit caption.
  using(var form=(Form)Activator.CreateInstance(assembly.GetType("LOGICA.Form_3_VENTE",true))) {
   var grid=(DataGridView)Get(form,"DataGridView100");
   Action verify=delegate() {
    if(grid.RowsDefaultCellStyle.SelectionBackColor.ToArgb()!=Color.FromArgb(171,185,211).ToArgb())
     throw new Exception("Original light-blue product selection background changed");
    if(grid.RowsDefaultCellStyle.SelectionForeColor.ToArgb()!=Color.FromArgb(31,41,55).ToArgb())
     throw new Exception("Product selection text must be dark on light blue");
    if(grid.Columns.Count!=4 || grid.Columns["DataGridViewTextBoxColumn1"].DataPropertyName!="Article")
     throw new Exception("Product list columns or name binding changed");
   };
   verify();
   // Simulate a theme/style override; the Load helper must restore contrast.
   grid.RowsDefaultCellStyle.SelectionForeColor=Color.White;
   form.GetType().GetMethod("ApplyProductListSelectionContrast",Flags).Invoke(form,null);
   verify();
   Console.WriteLine("PASS product-list selected-row contrast and original bindings");
  }
 }

 static void SalesBlankBarcodeStockPreflight(Assembly assembly) {
  // Real isolated MariaDB: two different products can both have Code=''.
  // The stock guard must select the exact ID and fail closed on missing,
  // duplicated or unknown stock without touching any real shop database.
  var module=assembly.GetType("LOGICA.Module1",true);
  var connection=(IDbConnection)module.GetField("cn_SQL",Flags).GetValue(null);
  if(!connection.ConnectionString.Contains("127.0.0.1")||!connection.ConnectionString.Contains("logica_ci"))
   throw new Exception("Blank-code stock regression requires isolated logica_ci");
  var field=module.GetField("dt1",Flags);
  object original=field.GetValue(null);
  var basket=new DataTable();
  basket.Columns.Add("Code",typeof(string));basket.Columns.Add("ID_ARTICLE",typeof(string));
  basket.Columns.Add("Article",typeof(string));basket.Columns.Add("Qté",typeof(decimal));
  field.SetValue(null,basket);
  try {
   connection.Open();
   Sql(connection,"CREATE TEMPORARY TABLE TABLE_ARTICLES (ID_ARTICLE VARCHAR(40), Article VARCHAR(100), STOCK DECIMAL(14,2))");
   try {
    Sql(connection,"INSERT INTO TABLE_ARTICLES VALUES ('101','CI available',8),('102','CI shortage',1),('103','CI null stock',NULL)");
    using(var form=(Form)Activator.CreateInstance(assembly.GetType("LOGICA.Form_3_VENTE",true))) {
     var preflight=form.GetType().GetMethod("FindFirstBlankCodeStockShortage",Flags);
     var legacyRows=form.GetType().GetMethod("ReadStockValidationRows",Flags);
     if(preflight==null||legacyRows==null)throw new Exception("Blank-code exact-ID stock preflight missing");
     Func<string> check=delegate() {
      var shortage=preflight.Invoke(form,null);
      return shortage==null?null:Convert.ToString(shortage.GetType().GetProperty("ArticleName",Flags).GetValue(shortage,null));
     };
     basket.Rows.Add("","101","CI available",2m);
     if(check()!=null)throw new Exception("Available blank-Code article was rejected");
     basket.Rows.Add("","102","CI shortage",2m);
     if(check()!="CI shortage")throw new Exception("Blank-Code stock preflight selected unrelated article");
     basket.Rows.Clear();basket.Rows.Add("","404","CI missing",2m);
     if(check()!="CI missing")throw new Exception("Missing blank-Code article did not fail closed");
     basket.Rows.Clear();basket.Rows.Add("","103","CI unknown",2m);
     if(check()!="CI unknown")throw new Exception("NULL stock did not fail closed");
     basket.Rows.Clear();basket.Rows.Add("","","CI invalid",2m);
     if(check()!="CI invalid")throw new Exception("Empty article ID did not fail closed");
     basket.Rows.Clear();basket.Rows.Add("","101","CI duplicate",2m);
     Sql(connection,"INSERT INTO TABLE_ARTICLES VALUES ('101','CI duplicate identity',8)");
     if(check()!="CI duplicate")throw new Exception("Ambiguous article ID did not fail closed");
     basket.Rows.Clear();basket.Rows.Add("BAR-001","101","CI barcode",2m);
     if(check()!=null)throw new Exception("Exact-ID blank-code guard changed normal barcode path");
     int legacyCount=0;
     foreach(object row in (System.Collections.IEnumerable)legacyRows.Invoke(form,null))legacyCount++;
     if(legacyCount!=1)throw new Exception("Legacy stock guard lost nonempty barcode rows");
     basket.Rows.Add("","102","CI blank",2m);
     legacyCount=0;
     foreach(object row in (System.Collections.IEnumerable)legacyRows.Invoke(form,null))legacyCount++;
     if(legacyCount!=1)throw new Exception("Blank Code leaked into legacy first-barcode stock lookup");
    }
    Console.WriteLine("PASS isolated MariaDB blank-Code stock preflight: exact ID, shortage, missing, NULL, duplicate and legacy barcode isolation");
   } finally {Sql(connection,"DROP TEMPORARY TABLE IF EXISTS TABLE_ARTICLES");}
  } finally {field.SetValue(null,original);if(connection.State!=ConnectionState.Closed)connection.Close();}
 }

 static void SalesBlankBarcodePostingGuard(Assembly assembly) {
  // Regression for the real sales posting gate: a resolved image/list item with
  // empty Code must reach the basket, but manual/scanner blank input must not.
  var form=assembly.GetType("LOGICA.Form_3_VENTE",true);
  var guard=form.GetMethod("CanPostSelectedArticleWithoutBarcode",Flags);
  var tile=assembly.GetType("LOGICA.ApplicationLayer.Checkout.CheckoutArticleTileReference",true);
  var ctor=tile.GetConstructor(Flags,null,new[]{typeof(string),typeof(string)},null);
  if(guard==null||!guard.IsStatic||ctor==null)
   throw new Exception("Verified blank-barcode posting guard or tile constructor missing");
  object exact=ctor.Invoke(new object[]{"","IMG-001"});
  object other=ctor.Invoke(new object[]{"","IMG-002"});
  object barcode=ctor.Invoke(new object[]{"BAR-001","IMG-001"});
  object emptyId=ctor.Invoke(new object[]{"",""});
  object[][] cases={
   new object[]{"BAR-001","IMG-001",null,true},
   new object[]{"BAR-001","IMG-001",barcode,true},
   new object[]{"","IMG-001",exact,true},
   new object[]{"","IMG-001",null,false},
   new object[]{"","IMG-001",other,false},
   new object[]{"","img-001",exact,false},
   new object[]{"","IMG-001",barcode,false},
   new object[]{" ","IMG-001",exact,false},
   new object[]{null,"IMG-001",exact,false},
   new object[]{"","",exact,false},
   new object[]{"","IMG-001",emptyId,false}
  };
  for(int i=0;i<cases.Length;i++) {
   bool actual=(bool)guard.Invoke(null,new[]{cases[i][0],cases[i][1],cases[i][2]});
   if(actual!=(bool)cases[i][3])
    throw new Exception("Blank-barcode posting guard regression case "+i+" expected "+cases[i][3]+" actual "+actual);
  }
  Console.WriteLine("PASS original sales basket posting guard: 11 verified blank-code, stale-ID, manual and scanner cases");
 }

 static void SalesListSelectionFallback(Assembly assembly) {
  // The list includes barcode-free products even without a photo. Guard empty
  // selections and use the exact bound row rather than stale currency position.
  using(var form=(Form)Activator.CreateInstance(assembly.GetType("LOGICA.Form_3_VENTE",true))) {
   var list=(DataGridView)Get(form,"DataGridView100");
   var code=(TextBox)Get(form,"Text_CODE");
   var findButton=(Control)Get(form,"Button_FIND");
   var selected=form.GetType().GetMethod("SelectedProductListRow",Flags);
   var reference=form.GetType().GetMethod("BlankBarcodeListArticleReference",Flags);
   var click=form.GetType().GetMethod("DataGridView100_Click",Flags);
   var doubleClick=form.GetType().GetMethod("DataGridView100_DoubleClick",Flags);
   if(list==null||code==null||findButton==null||selected==null||reference==null||click==null||doubleClick==null)
    throw new Exception("Sales product-list selection handlers missing");
   var rows=new DataTable();
   foreach(string column in new[]{"ID_ARTICLE","Code","Article","PRIX_V_1"})rows.Columns.Add(column);
   rows.Rows.Add("101","","No barcode and no photo","8.50");
   rows.Rows.Add("102","BAR-102","Ordinary barcode","9.50");
   list.DataSource=rows;
   if(list.Rows.Count!=2)throw new Exception("Sales product list failed to bind two articles");
   list.CurrentCell=list.Rows[0].Cells[0];
   if(!Object.ReferenceEquals(selected.Invoke(form,null),rows.Rows[0]))
    throw new Exception("List selection did not resolve the first bound row");
   var tag=reference.Invoke(null,new object[]{rows.Rows[0]});
   var tagType=assembly.GetType("LOGICA.ApplicationLayer.Checkout.CheckoutArticleTileReference",true);
   if(!tagType.IsInstanceOfType(tag) || Convert.ToString(tagType.GetProperty("ArticleId",Flags).GetValue(tag,null))!="101" || Convert.ToString(tag)!="")
    throw new Exception("Barcode-free list row lost its exact article identity");
   findButton.Tag="CI_KEEP_TAG";
   findButton.Enabled=false;
   code.Text="KEEP-SCAN";
   doubleClick.Invoke(form,new object[]{list,EventArgs.Empty});
   if(code.Text!="KEEP-SCAN" || !Object.Equals(findButton.Tag,"CI_KEEP_TAG"))
    throw new Exception("Disabled lookup button must not post barcode-free list article");
   findButton.Enabled=true;
   findButton.Tag=null;
   code.Text="OLD-SCAN";
   click.Invoke(form,new object[]{list,EventArgs.Empty});
   if(code.Text!="")throw new Exception("List click retained a stale scanned barcode");
   list.CurrentCell=list.Rows[1].Cells[0];
   click.Invoke(form,new object[]{list,EventArgs.Empty});
   if(code.Text!="BAR-102" || reference.Invoke(null,new object[]{rows.Rows[1]})!=null)
    throw new Exception("Barcode list click must retain legacy exact-barcode route");
   rows.Rows[0]["ID_ARTICLE"]=DBNull.Value;
   if(reference.Invoke(null,new object[]{rows.Rows[0]})!=null)
    throw new Exception("Missing article ID must fail closed");
   rows.Rows[0]["ID_ARTICLE"]="101";
   var deletedRow=rows.Rows[0];
   deletedRow.Delete();
   if(reference.Invoke(null,new object[]{deletedRow})!=null)
    throw new Exception("Deleted list row must fail closed");
   list.DataSource=null;
   code.Text="KEEP-SCAN";
   doubleClick.Invoke(form,new object[]{list,EventArgs.Empty});
   if(code.Text!="KEEP-SCAN")
    throw new Exception("Empty list double-click rescanned an unrelated barcode");
  }
  Console.WriteLine("PASS list row identity: barcode-free article, legacy barcode, deleted/empty guards");
 }

 static void SalesSearchShortcut(Assembly assembly) {
  using(var form=(Form)Activator.CreateInstance(assembly.GetType("LOGICA.Form_3_VENTE",true))) {
   var search=(Control)Get(form,"Text_FIND");
   var tabs=(Control)Get(form,"TabControl2");
   var originalTag=tabs.Tag;
   var method=form.GetType().GetMethod("ProcessCmdKey",BindingFlags.Instance|BindingFlags.NonPublic|BindingFlags.DeclaredOnly);
   var searchProperty=form.GetType().GetProperty("Text_FIND",BindingFlags.Instance|BindingFlags.Public|BindingFlags.NonPublic);
   if(method==null || search==null || search.Parent==null || !search.Enabled || searchProperty==null)
    throw new Exception("Sales search shortcut or search field is unavailable");
   // An unshown WinForms form reports child.Visible=false because its parent is hidden.
   // Avoid Form.Show() here: it triggers the production Load path and database reads.
   // Swap in a visible, unattached test TextBox to exercise the REAL ProcessCmdKey
   // implementation, then restore the actual designer control and its event hooks.
   using(var probe=new TextBox()) {
    probe.Visible=true;
    searchProperty.SetValue(form,probe,null);
    try {
     var args=new object[]{new Message(),Keys.Control|Keys.F};
     if(!Object.Equals(method.Invoke(form,args),true))
      throw new Exception("Ctrl+F must be consumed when product search is available");
     if(!Object.Equals(tabs.Tag,originalTag))
      throw new Exception("Ctrl+F must not toggle the legacy on-screen keyboard");
     args=new object[]{new Message(),Keys.Control|Keys.G};
     if(Object.Equals(method.Invoke(form,args),true))
      throw new Exception("Unrelated Ctrl+G must remain available to legacy controls");
     args=new object[]{new Message(),Keys.Control|Keys.Shift|Keys.F};
     if(Object.Equals(method.Invoke(form,args),true))
      throw new Exception("Ctrl+Shift+F must retain its original key routing");
     args=new object[]{new Message(),Keys.Alt|Keys.F};
     if(Object.Equals(method.Invoke(form,args),true))
      throw new Exception("Alt+F must retain its original menu routing");
     searchProperty.SetValue(form,null,null);
     args=new object[]{new Message(),Keys.Control|Keys.F};
     if(Object.Equals(method.Invoke(form,args),true))
      throw new Exception("Missing search field must not swallow Ctrl+F");
     searchProperty.SetValue(form,probe,null);
     probe.ReadOnly=true;
     args=new object[]{new Message(),Keys.Control|Keys.F};
     if(Object.Equals(method.Invoke(form,args),true))
      throw new Exception("Ctrl+F must not swallow scanner input when search is read-only");
     probe.ReadOnly=false;
     probe.Visible=false;
     args=new object[]{new Message(),Keys.Control|Keys.F};
     if(Object.Equals(method.Invoke(form,args),true))
      throw new Exception("Ctrl+F must not be consumed when search is hidden");
     probe.Visible=true;
     // A disposed search field must never intercept scanner/legacy key input.
     using(var disposedProbe=new TextBox()) {
      disposedProbe.Dispose();
      searchProperty.SetValue(form,disposedProbe,null);
      args=new object[]{new Message(),Keys.Control|Keys.F};
      if(Object.Equals(method.Invoke(form,args),true))
       throw new Exception("Disposed search field must not consume Ctrl+F");
      searchProperty.SetValue(form,probe,null);
     }
     // The actual control must remain attached and bound after the probe is restored.
     if(searchProperty.GetValue(form,null)!=probe)
      throw new Exception("Search probe was unexpectedly detached before restoration");
     probe.Enabled=false;
     args=new object[]{new Message(),Keys.Control|Keys.F};
     if(Object.Equals(method.Invoke(form,args),true))
      throw new Exception("Ctrl+F must not consume barcode input when search is disabled");
    } finally {
     searchProperty.SetValue(form,search,null);
    }
   }
   if(!Object.ReferenceEquals(searchProperty.GetValue(form,null),search))
    throw new Exception("Original sales search control was not restored after shortcut regression");
   if(search.IsDisposed || search.Parent==null)
    throw new Exception("Shortcut regression must preserve the original search control and parent");
   Console.WriteLine("PASS Ctrl+F product-search shortcut leaves keyboard layout unchanged");
  }
 }

 static void SalesScannerEnterRouting(Assembly assembly) {
  // A barcode scanner sends a final Enter. It must dispatch exactly once and
  // suppress the original key press; blank input must never query MariaDB.
  using(var form=(Form)Activator.CreateInstance(assembly.GetType("LOGICA.Form_3_VENTE",true))) {
   var code=(TextBox)Get(form,"Text_CODE");
   var quantity=(Control)Get(form,"Label_QTE");
   var barcodeHandler=form.GetType().GetMethod("Text_CODE_KeyDown",Flags);
   var quantityHandler=form.GetType().GetMethod("Label_QTE_KeyDown",Flags);
   if(code==null||quantity==null||barcodeHandler==null||quantityHandler==null)
    throw new Exception("Sales scanner/quantity key handlers are missing");
   code.Text="";
   var ordinary=new KeyEventArgs(Keys.A);
   barcodeHandler.Invoke(form,new object[]{code,ordinary});
   if(ordinary.Handled||ordinary.SuppressKeyPress)
    throw new Exception("Ordinary barcode character must not be swallowed");
   foreach(var modifiedKey in new[]{Keys.Control|Keys.Enter,Keys.Shift|Keys.Enter,Keys.Alt|Keys.Enter}) {
    var modified=new KeyEventArgs(modifiedKey);
    barcodeHandler.Invoke(form,new object[]{code,modified});
    if(modified.Handled||modified.SuppressKeyPress)
     throw new Exception("Modified Enter must not initiate barcode lookup: "+modifiedKey);
   }
   var enter=new KeyEventArgs(Keys.Enter);
   barcodeHandler.Invoke(form,new object[]{code,enter});
   if(!enter.Handled||!enter.SuppressKeyPress)
    throw new Exception("Barcode Enter must be consumed after dispatch");
   if(code.Text!="")
    throw new Exception("Blank barcode Enter changed scanner input");
   var qtyOther=new KeyEventArgs(Keys.D1);
   quantityHandler.Invoke(form,new object[]{quantity,qtyOther});
   if(qtyOther.Handled||qtyOther.SuppressKeyPress)
    throw new Exception("Quantity numeric input must not be swallowed");
   foreach(var modifiedKey in new[]{Keys.Control|Keys.Enter,Keys.Shift|Keys.Enter,Keys.Alt|Keys.Enter}) {
    var modified=new KeyEventArgs(modifiedKey);
    quantityHandler.Invoke(form,new object[]{quantity,modified});
    if(modified.Handled||modified.SuppressKeyPress)
     throw new Exception("Modified Enter must not change quantity focus: "+modifiedKey);
   }
   var qtyEnter=new KeyEventArgs(Keys.Enter);
   quantityHandler.Invoke(form,new object[]{quantity,qtyEnter});
   if(!qtyEnter.Handled||!qtyEnter.SuppressKeyPress)
    throw new Exception("Quantity Enter must be consumed when returning to barcode");
   Console.WriteLine("PASS barcode and quantity Enter routing, scanner terminator suppressed, blank scan offline");
  }
 }

 static void SalesSearchClearRefresh(Assembly assembly) {
  // Test the real search-clear decision without invoking SQL or the Form.Load path.
  var method=assembly.GetType("LOGICA.Form_3_VENTE",true).GetMethod("ClearProductSearch",Flags);
  if(method==null||!method.IsStatic)throw new Exception("Search clear helper missing");
  using(var search=new TextBox()) {
   int textChanges=0, forcedRefreshes=0;
   search.TextChanged+=(sender,e)=>textChanges++;
   search.Text="milk";
   textChanges=0;
   Action force=()=>forcedRefreshes++;
   method.Invoke(null,new object[]{search,force});
   if(search.Text!=""||textChanges!=1||forcedRefreshes!=0)
    throw new Exception("Clearing nonempty search must refresh once via TextChanged");
   method.Invoke(null,new object[]{search,force});
   if(search.Text!=""||textChanges!=1||forcedRefreshes!=1)
    throw new Exception("Clearing empty search must force exactly one refresh");
   method.Invoke(null,new object[]{search,force});
   if(textChanges!=1||forcedRefreshes!=2)
    throw new Exception("Repeated empty search clear must not trigger duplicate refreshes");
  }
  Console.WriteLine("PASS sales search clear executes one refresh per click");
 }

 static void SalesQuantityKeypadAndCompactKeyboard(Assembly assembly) {
  // Exercise the production numeric keypad without opening the form or touching SQL.
  using(var form=(Form)Activator.CreateInstance(assembly.GetType("LOGICA.Form_3_VENTE",true))) {
   var quantity=(Control)Get(form,"Label_QTE");
   var qtyButton=form.GetType().GetMethod("Button_qte1_Click",Flags);
   var qtyKeyPress=form.GetType().GetMethod("Label_QTE_KeyPress",Flags);
   var qtyReset=form.GetType().GetMethod("Button_qteDRAFT_Click",Flags);
   var keyboardButton=form.GetType().GetMethod("Button_876_Click",Flags);
   var tabs=(Control)Get(form,"TabControl2");
   var keyboard=(Control)Get(form,"Panel_CLAVIER");
   var panel=(Control)Get(form,"Panel9");
   if(quantity==null||qtyButton==null||qtyReset==null||keyboardButton==null||
      tabs==null||keyboard==null||panel==null)
    throw new Exception("Sales quantity keypad or keyboard layout is missing");
   if(qtyKeyPress==null)throw new Exception("Quantity keyboard handler missing");
   var oldQty=quantity.Text;
   quantity.Text="23.5";
   var duplicateDecimal=new KeyPressEventArgs('.');
   qtyKeyPress.Invoke(form,new object[]{quantity,duplicateDecimal});
   if(!duplicateDecimal.Handled)throw new Exception("Physical keyboard must reject duplicate decimal separators");
   foreach(char allowed in new char[]{'4','\b'}) {
    var key=new KeyPressEventArgs(allowed);
    qtyKeyPress.Invoke(form,new object[]{quantity,key});
    if(key.Handled)throw new Exception("Quantity keyboard rejected legacy valid key: "+allowed);
   }
   var misplacedMinus=new KeyPressEventArgs('-');
   qtyKeyPress.Invoke(form,new object[]{quantity,misplacedMinus});
   if(!misplacedMinus.Handled)throw new Exception("Physical quantity keyboard accepted minus after digits");
   quantity.Text="";
   var leadingMinus=new KeyPressEventArgs('-');
   qtyKeyPress.Invoke(form,new object[]{quantity,leadingMinus});
   if(leadingMinus.Handled)throw new Exception("Legacy leading minus entry must remain available");
   quantity.Text="-2";
   var repeatedMinus=new KeyPressEventArgs('-');
   qtyKeyPress.Invoke(form,new object[]{quantity,repeatedMinus});
   if(!repeatedMinus.Handled)throw new Exception("Physical quantity keyboard accepted repeated minus");
   var invalidKey=new KeyPressEventArgs('X');
   qtyKeyPress.Invoke(form,new object[]{quantity,invalidKey});
   if(!invalidKey.Handled)throw new Exception("Quantity keyboard accepted nonnumeric input");
   var oldColor=quantity.BackColor;
   var oldHeight=tabs.Height;
   var oldTag=tabs.Tag;
   try {
    qtyReset.Invoke(form,new object[]{form,EventArgs.Empty});
    if(quantity.Text!="1"||quantity.BackColor!=Color.White)
     throw new Exception("Quantity reset must restore the original unit quantity");
    using(var digit=new Button()) {
     digit.Text="2";
     qtyButton.Invoke(form,new object[]{digit,EventArgs.Empty});
     if(quantity.Text!="2"||quantity.BackColor!=Color.Yellow)
      throw new Exception("First keypad digit must replace the default quantity");
     digit.Text="3";
     qtyButton.Invoke(form,new object[]{digit,EventArgs.Empty});
     if(quantity.Text!="23")
      throw new Exception("Numeric keypad must append digits rather than add values");
     digit.Text=".";
     qtyButton.Invoke(form,new object[]{digit,EventArgs.Empty});
     digit.Text="5";
     qtyButton.Invoke(form,new object[]{digit,EventArgs.Empty});
     if(quantity.Text!="23.5")
      throw new Exception("Fractional keypad input must preserve decimal text");
     digit.Text=".";
     qtyButton.Invoke(form,new object[]{digit,EventArgs.Empty});
     if(quantity.Text!="23.5")
      throw new Exception("Repeated decimal key must not create an invalid quantity");
     qtyReset.Invoke(form,new object[]{form,EventArgs.Empty});
     digit.Text=".";
     qtyButton.Invoke(form,new object[]{digit,EventArgs.Empty});
     digit.Text="5";
     qtyButton.Invoke(form,new object[]{digit,EventArgs.Empty});
     if(quantity.Text!="0.5")
      throw new Exception("Fractional quantity must start with a leading zero");
     // Unexpected button captions must not corrupt the numeric quantity.
     foreach(string invalid in new string[]{"", "X", "12", "-", ",", " "}) {
      string before=quantity.Text;
      digit.Text=invalid;
      qtyButton.Invoke(form,new object[]{digit,EventArgs.Empty});
      if(quantity.Text!=before)
       throw new Exception("Invalid keypad caption changed quantity: "+invalid);
     }
     qtyReset.Invoke(form,new object[]{form,EventArgs.Empty});
     digit.Text="7";
     qtyButton.Invoke(form,new object[]{digit,EventArgs.Empty});
     if(quantity.Text!="7")
      throw new Exception("Quantity reset must not concatenate with the old value");
    }
    // The original keyboard toggle subtracts keyboard height from the product
    // list, which could collapse it on a small screen or high DPI.
    tabs.Tag="";
    tabs.Height=keyboard.Height+10;
    int compactHeight=tabs.Height;
    keyboardButton.Invoke(form,new object[]{form,EventArgs.Empty});
    if(tabs.Height!=compactHeight||!Object.Equals(tabs.Tag,""))
     throw new Exception("Compact keyboard toggle must keep the list and state intact");
    tabs.Height=keyboard.Height+90;
    keyboardButton.Invoke(form,new object[]{form,EventArgs.Empty});
    if(tabs.Height!=80||!Object.Equals(tabs.Tag,"1"))
     throw new Exception("Normal keyboard toggle must retain the legacy height calculation");
    keyboardButton.Invoke(form,new object[]{form,EventArgs.Empty});
    if(tabs.Height!=keyboard.Height+90||!Object.Equals(tabs.Tag,""))
     throw new Exception("Closing keyboard must restore the exact pre-keyboard height at DPI scale");
    // Reopen and close at a different size; stale cached heights must not leak.
    tabs.Height=keyboard.Height+115;
    keyboardButton.Invoke(form,new object[]{form,EventArgs.Empty});
    if(tabs.Height!=105||!Object.Equals(tabs.Tag,"1"))
     throw new Exception("Keyboard must shrink the list by its actual height");
    keyboardButton.Invoke(form,new object[]{form,EventArgs.Empty});
    if(tabs.Height!=keyboard.Height+115||!Object.Equals(tabs.Tag,""))
     throw new Exception("Keyboard must restore the newly measured product list height");
    // The designer may leave Tag=null: the first click must OPEN, not restore Panel9.
    tabs.Tag=null;
    tabs.Height=keyboard.Height+90;
    keyboardButton.Invoke(form,new object[]{form,EventArgs.Empty});
    if(tabs.Height!=80||!Object.Equals(tabs.Tag,"1"))
     throw new Exception("Null initial keyboard tag must open without collapsing the list");
    keyboardButton.Invoke(form,new object[]{form,EventArgs.Empty});
    if(tabs.Height!=keyboard.Height+90||!Object.Equals(tabs.Tag,""))
     throw new Exception("Closing keyboard after null tag must restore initial list height");
    tabs.Tag=null;
    tabs.Height=keyboard.Height+10;
    keyboardButton.Invoke(form,new object[]{form,EventArgs.Empty});
    if(tabs.Height!=keyboard.Height+10||tabs.Tag!=null)
     throw new Exception("Compact keyboard with null tag must preserve original layout");
   } finally {
    quantity.Text=oldQty;
    quantity.BackColor=oldColor;
    tabs.Height=oldHeight;
    tabs.Tag=oldTag;
   }
   Console.WriteLine("PASS quantity digit/decimal/reset and compact/normal keyboard layout fallback");
  }
 }

 static void SalesProductNameRowDpi(Assembly assembly) {
  // The legacy product list disabled row resizing but did not wrap long article names.
  // Only visible rows should auto-size: the full catalogue may contain thousands of items.
  using(var form=(Form)Activator.CreateInstance(assembly.GetType("LOGICA.Form_3_VENTE",true))) {
   var list=(DataGridView)Get(form,"DataGridView100");
   if(list.AutoSizeRowsMode!=DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders)
    throw new Exception("Product list must size visible rows for wrapped names without scanning all products");
   var name=list.Columns["DataGridViewTextBoxColumn1"];
   if(name==null || name.DataPropertyName!="Article" || name.DefaultCellStyle.WrapMode!=DataGridViewTriState.True)
    throw new Exception("Article column must retain its binding and wrap long names");
   if(list.Columns.Count!=4 || list.Columns["Codeee"].DataPropertyName!="Code" ||
      list.Columns["Prix_VV"].DataPropertyName!="PRIX_V_1" ||
      list.Columns["Stock"].DataPropertyName!="Stock")
    throw new Exception("Product list columns or data bindings changed");
   if(list.AllowUserToAddRows || list.AllowUserToResizeRows)
    throw new Exception("Product list editing/row-resize behavior changed");
   Console.WriteLine("PASS visible product row autosizing, long-name wrapping, original four bindings");
  }
 }

 static void SalesProductListHeaderDpi(Assembly assembly) {
  // The product list previously froze captions at 30px during Load.
  // Verify the actual WinForms control stays ready for larger fonts/DPI,
  // without changing product-list columns or image-grid filtering.
  using(var form=(Form)Activator.CreateInstance(assembly.GetType("LOGICA.Form_3_VENTE",true))) {
   var list=(DataGridView)Get(form,"DataGridView100");
   if(list.ColumnHeadersHeightSizeMode!=DataGridViewColumnHeadersHeightSizeMode.AutoSize)
    throw new Exception("Product-list headers must auto-size after Windows font/DPI changes");
   if(list.ColumnHeadersDefaultCellStyle.WrapMode!=DataGridViewTriState.True)
    throw new Exception("Product-list header text must wrap instead of clipping");
   string[] names={"Codeee","DataGridViewTextBoxColumn1","Prix_VV","Stock"};
   string[] fields={"Code","Article","PRIX_V_1","Stock"};
   if(list.Columns.Count!=names.Length)
    throw new Exception("Product-list column count changed");
   for(int i=0;i<names.Length;i++) {
    if(list.Columns[i].Name!=names[i] || list.Columns[i].DataPropertyName!=fields[i])
     throw new Exception("Product-list identity/binding changed at column "+i);
   }
   if(list.AllowUserToAddRows)
    throw new Exception("Product-list add-row behavior changed");
   Console.WriteLine("PASS product-list auto-height, wrapped captions and original four bindings");
  }
 }

 static void SalesBasketHeaderDpi(Assembly assembly) {
  // The original Load set DisableResizing + one-time AutoResizeColumnHeadersHeight.
  // A font/DPI change could clip wrapped basket headers; AutoSize must persist.
  using(var form=(Form)Activator.CreateInstance(assembly.GetType("LOGICA.Form_3_VENTE",true))) {
   var grid=(DataGridView)Get(form,"DataGridView1");
   if(grid.ColumnHeadersHeightSizeMode!=DataGridViewColumnHeadersHeightSizeMode.AutoSize)
    throw new Exception("Basket headers must auto-size when Windows font/DPI changes");
   if(grid.ColumnHeadersDefaultCellStyle.WrapMode!=DataGridViewTriState.True)
    throw new Exception("Wrapped basket column captions were disabled");
   foreach(var name in new[]{"Article","Prix_V","Qté","TOTAL_NET"}) {
    if(grid.Columns[name]==null)throw new Exception("Basket header missing: "+name);
   }
   if(grid.AllowUserToAddRows)throw new Exception("Basket editing semantics changed");
   Console.WriteLine("PASS basket header auto-height for DPI/font scaling and unchanged columns");
  }
 }

 static void SalesBasketSelectionContrast(Assembly assembly) {
  // Exercise the actual WinForms form without database-dependent Load.
  using(var form=(Form)Activator.CreateInstance(assembly.GetType("LOGICA.Form_3_VENTE",true))) {
   var grid=(DataGridView)Get(form,"DataGridView1");
   Action verify=delegate() {
    if(grid.DefaultCellStyle.SelectionBackColor.ToArgb()!=Color.Yellow.ToArgb())
     throw new Exception("Original yellow basket selection highlight changed");
    if(grid.DefaultCellStyle.SelectionForeColor.ToArgb()!=Color.FromArgb(31,41,55).ToArgb())
     throw new Exception("Selected basket row text is not high-contrast dark slate");
    foreach(var column in new[]{"Article","Prix_V","Qté","TOTAL_NET"})
     if(grid.Columns[column]==null)throw new Exception("Basket column removed: "+column);
   };
   verify();
   // Legacy Load reapplies the palette after binding; assert it cannot restore red-on-yellow.
   grid.DefaultCellStyle.SelectionForeColor=Color.Red;
   form.GetType().GetMethod("ApplyBasketSelectionContrast",Flags).Invoke(form,null);
   verify();
   Console.WriteLine("PASS selected basket row contrast, yellow highlight and unchanged sales columns");
  }
 }

 static void SalesWhiteUtilityButtonContrast(Assembly assembly) {
  // The search action and eight white keyboard utility buttons had no explicit
  // foreground: inherited/theme foreground can become unreadable on white.
  using(var form=(Form)Activator.CreateInstance(assembly.GetType("LOGICA.Form_3_VENTE",true))) {
   foreach(var name in new[]{"Button_876","Button_CLAVIER_NOSELECT35","Button_CLAVIER_NOSELECT34",
      "Button_CLAVIER_NOSELECT25","Button_CLAVIER_NOSELECT24","Button_CLAVIER_NOSELECT23",
      "Button_CLAVIER_NOSELECT22","Button_CLAVIER_NOSELECT21","Button_CLAVIER_NOSELECT20"}) {
    var button=(Control)Get(form,name);
    if(button.BackColor.ToArgb()!=Color.White.ToArgb())
     throw new Exception(name+" original white background changed");
    if(button.ForeColor.GetBrightness()>=0.45f)
     throw new Exception(name+" inherited/light caption is unreadable on white");
    Console.WriteLine("PASS explicit white utility button contrast "+name);
   }
   var search=(Control)Get(form,"Text_FIND");
   if(search.BackColor.ToArgb()!=Color.White.ToArgb() || search.ForeColor.ToArgb()!=Color.Black.ToArgb())
    throw new Exception("Sales product search text colors changed");
   Console.WriteLine("PASS sales product search text colors unchanged");
  }
 }

 static void SalesKeyboardContrast(Assembly assembly) {
  // Language/keyboard toggles inherit a white table background; white captions disappeared.
  using(var form=(Form)Activator.CreateInstance(assembly.GetType("LOGICA.Form_3_VENTE",true))) {
   foreach(var name in new[]{"Butt_AR","Butt_DOT_AR","Butt_FR"}) {
    var button=(Control)Get(form,name);
    if(button.Parent==null || button.Parent.BackColor.ToArgb()!=Color.White.ToArgb())
     throw new Exception(name+" keyboard parent is no longer white");
    if(button.ForeColor.GetBrightness()>=0.45f)
     throw new Exception(name+" keyboard caption is too light for its white parent");
    if(name=="Butt_FR" && button.BackColor.ToArgb()!=Color.White.ToArgb())
     throw new Exception("French keyboard toggle background changed");
    if(name!="Butt_FR" && button.BackColor!=Color.Transparent)
     throw new Exception(name+" transparent keyboard background changed");
    Console.WriteLine("PASS readable keyboard toggle "+name+" foreground="+button.ForeColor);
   }
  }
 }

 static void SalesActionContrast(Assembly assembly) {
  // Regression for three sales actions whose original designer colors were white on white.
  using(var form=(Form)Activator.CreateInstance(assembly.GetType("LOGICA.Form_3_VENTE",true))) {
   foreach(var name in new[]{"Button2626","Button2121","Button1717"}) {
    var button=(Control)Get(form,name);
    if(button.BackColor.ToArgb()!=Color.White.ToArgb())
     throw new Exception(name+" background unexpectedly changed");
    if(button.ForeColor.GetBrightness()>=0.45f)
     throw new Exception(name+" has unreadable foreground on white background");
    Console.WriteLine("PASS readable sales action "+name+" foreground="+button.ForeColor);
   }
   var grid=(DataGridView)Get(form,"DataGridView1");
   foreach(var name in new[]{"Article","Prix_V","Qté","TOTAL_NET"})
    if(grid.Columns[name]==null)throw new Exception("Sales basket column missing: "+name);
   Console.WriteLine("PASS sales basket core columns unchanged");
  }
 }

 [STAThread] static int Main(string[] args) {
  try {
   Application.EnableVisualStyles();
   var assembly=Assembly.LoadFrom(Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"LOGICA.exe"));
   if(args[0]=="checkout-blank-barcode-stock") { SalesBlankBarcodeStockPreflight(assembly); } else if(args[0]=="checkout-blank-barcode-posting") { SalesBlankBarcodePostingGuard(assembly); } else if(args[0]=="checkout-list-selection") { SalesListSelectionFallback(assembly); } else if(args[0]=="checkout-quantity-keypad-dpi") { SalesQuantityKeypadAndCompactKeyboard(assembly); SalesSearchClearRefresh(assembly); } else if(args[0]=="checkout-scanner-enter") { SalesScannerEnterRouting(assembly); } else if(args[0]=="checkout-search-shortcut") { SalesSearchShortcut(assembly); } else if(args[0]=="checkout-family-caption-contrast") { SalesFamilyCaptionContrast(assembly); } else if(args[0]=="checkout-product-list-selection-contrast") { SalesProductListSelectionContrast(assembly); } else if(args[0]=="checkout-product-name-row-dpi") { SalesProductNameRowDpi(assembly); } else if(args[0]=="checkout-product-list-header-dpi") { SalesProductListHeaderDpi(assembly); } else if(args[0]=="checkout-basket-header-dpi") { SalesBasketHeaderDpi(assembly); } else if(args[0]=="checkout-basket-selection-contrast") { SalesBasketSelectionContrast(assembly); } else if(args[0]=="checkout-white-buttons-contrast") { SalesWhiteUtilityButtonContrast(assembly); } else if(args[0]=="checkout-keyboard-contrast") { SalesKeyboardContrast(assembly); } else if(args[0]=="checkout-contrast") { SalesActionContrast(assembly); } else if(args[0]=="checkout-barcode-chooser") { CheckoutBarcodeChooser(assembly); } else if(args[0]=="checkout-image-grid") { CheckoutImageGrid(assembly); } else if(args[0]=="checkout-article-search-sql") { CheckoutArticleSearchSql(assembly); } else if(args[0]=="shared-export-projection") { SharedExportProjection(assembly); } else if(args[0]=="catalogue-aggregate-failure") { CatalogueAggregateRefresh(assembly,true); } else if(args[0]=="catalogue-aggregate-refresh") { CatalogueAggregateRefresh(assembly); } else if(args[0]=="collection-quantity-totals") { CollectionQuantityTotals(assembly); } else if(args[0]=="collection-variant-insert") { CollectionVariantInsertion(assembly); } else if(args[0]=="collection-duplicate-later") { CatalogueSaveGuards(assembly,true,true,true); } else if(args[0]=="collection-duplicate-code") { CatalogueSaveGuards(assembly,true,true); } else if(args[0]=="collection-save-guards") { CatalogueSaveGuards(assembly,true); } else if(args[0]=="catalogue-balance-reject") { CatalogueCreateProduct(assembly,balanceScenario:"reject"); } else if(args[0]=="catalogue-balance-format") { CatalogueCreateProduct(assembly,balanceScenario:"format"); } else if(args[0]=="catalogue-create-empty") { CatalogueCreateProduct(assembly,emptyArticles:true); } else if(args[0]=="catalogue-create-null-sequence") { CatalogueCreateProduct(assembly,nullSequence:true); } else if(args[0]=="catalogue-create-empty-null") { CatalogueCreateProduct(assembly,emptyArticles:true,nullSequence:true); } else if(args[0]=="catalogue-update-failure") { CatalogueCreateProduct(assembly,true,failUpdate:true); } else if(args[0]=="catalogue-insert-failure") { CatalogueCreateProduct(assembly,false,false,false,false,true); } else if(args[0]=="catalogue-sequence-failure") { CatalogueCreateProduct(assembly,false,false,false,true); } else if(args[0]=="catalogue-movement-failure") { CatalogueCreateProduct(assembly,false,false,true); } else if(args[0]=="catalogue-duplicates") { CatalogueCreateProduct(assembly,true,true); } else if(args[0]=="catalogue-edit") { CatalogueCreateProduct(assembly,true); } else if(args[0]=="catalogue-create") { CatalogueCreateProduct(assembly); } else if(args[0]=="catalogue-barcodes") { CatalogueGeneratedBarcodes(assembly); } else if(args[0]=="catalogue-save-guards") { CatalogueSaveGuards(assembly); } else if(args[0]=="catalogue-keys") { CatalogueKeys(assembly); } else if(args[0]=="cash-counting") { CountedCash(assembly); } else if(args[0]=="stock-movement-search-failure") { StockMovementSearch(assembly,true); } else if(args[0]=="stock-movement-search") { StockMovementSearch(assembly); } else if(args[0]=="checkout-missing-stock-lookup") { Checkout(assembly,false,"stock-missing-lookup"); } else if(args[0]=="checkout-reject-stock") { Checkout(assembly,false,"reject-stock"); } else if(args[0]=="checkout-reject-stock-off") { Checkout(assembly,false,"reject-stock-off"); } else if(args[0]=="checkout-stock-exact") { Checkout(assembly,false,"stock-exact"); } else if(args[0]=="checkout-reject-total") { Checkout(assembly,false,"reject-total"); } else if(args[0]=="checkout-rounding-window") { Checkout(assembly,false,"rounding-window"); } else if(args[0]=="checkout-select-seller") { Checkout(assembly,false,"select-seller"); } else if(args[0]=="checkout-select-client") { Checkout(assembly,false,"select-client"); } else if(args[0]=="checkout-credit-client") { Checkout(assembly,false,"select-credit-client"); } else if(args[0]=="checkout-reject-sale") { Checkout(assembly,false,"reject-sale"); } else if(args[0]=="checkout-reject-return") { Checkout(assembly,false,"reject-return"); } else if(args[0]=="checkout-reject-empty") { Checkout(assembly,false,"reject-empty"); } else if(args[0]=="checkout-stock-off") { Checkout(assembly,false,"stock-off"); } else if(args[0]=="checkout-fractional") { Checkout(assembly,false,"fractional"); } else if(args[0]=="checkout-late-rollback") { Checkout(assembly,true,"cash",true); } else if(args[0]=="checkout-mixed") { Checkout(assembly,false,"mixed"); } else if(args[0]=="checkout-change") { Checkout(assembly,false,"change"); } else if(args[0]=="checkout-credit") { Checkout(assembly,false,"credit"); } else if(args[0]=="checkout-rollback") { Checkout(assembly,true); } else if(args[0]=="checkout") { Checkout(assembly); } else if(args[0]=="inventory-decline-validation") { DeclinedValidationGuard(assembly); } else if(args[0]=="inventory-empty-validation") { EmptyValidationGuard(assembly); } else if(args[0]=="inventory-transaction-preflight") { InventoryTransactionPreflight(assembly); } else if(args[0]=="basket") { Basket(assembly); } else if(args[0]=="rounding") {
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
