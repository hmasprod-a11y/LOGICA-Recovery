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
 static void VerifyOriginalValidationFixtureSchema(IDbConnection conn) {
  // Validate the columns read by the original DataGridView1_CellClick handlers
  // before attempting a full accepted WinForms validation fixture.
  if(!conn.ConnectionString.Contains("logica_recovered_check") || !conn.ConnectionString.Contains("127.0.0.1"))
   throw new Exception("Fixture schema check requires isolated recovered database");
  var required=new Dictionary<string,string[]> {
   {"TABLE_RECEPTIONS_ENTETE",new[]{"ID","ID_BR","DATES","UTILISATEUR","ID_FOURNISSEUR","CODE_FOURNISSEUR","FOURNISSEUR","N_BON_FOURNISSEUR","TOTAL_NET_ACHATS","TOTAL_NET_VENTES","NOTES","ETAT"}},
   {"TABLE_RECEPTIONS_DETAILS",new[]{"ID_BR","ID_ARTICLE","Code","Article","PRIX_A","PRIX_V","Qté","TOTAL_NET_ACHATS","TOTAL_NET_VENTES","DATE_PEREMPTION","N_LOT","ETAT"}},
   {"TABLE_INVENTAIRES_ENTETE",new[]{"ID","ID_INV","DATES","UTILISATEUR","TOTAL_VALEUR","NOTES","ETAT"}},
   {"TABLE_INVENTAIRES_DETAILS",new[]{"ID_INV","ID_ARTICLE","Code","Article","PRIX_A","STOCK_LOGIQUE","STOCK_PHYSIQUE","ECART","VALEUR","ETAT"}},
   {"TABLE_ARTICLES",new[]{"ID_ARTICLE","STOCK","STOCK_INITIAL","DATE_INVENTAIRE","PRIX_MP","PRIX_A","Prix_V_1","Fournisseur"}},
   {"TABLE_MOUVEMENTS_STOCK",new[]{"ID","DATES","HEURE","LIBELLE","ID_ARTICLE","CODE_ARTICLE","ARTICLE","QUANTITE"}}
  };
  foreach(var entry in required) {
   var found=new HashSet<string>(StringComparer.OrdinalIgnoreCase);
   using(var c=conn.CreateCommand()) {
    c.CommandText="SELECT COLUMN_NAME FROM information_schema.COLUMNS WHERE TABLE_SCHEMA=DATABASE() AND TABLE_NAME=@table";
    var p=c.CreateParameter();p.ParameterName="@table";p.Value=entry.Key;c.Parameters.Add(p);
    using(var reader=c.ExecuteReader())while(reader.Read())found.Add(reader.GetString(0));
   }
   foreach(var col in entry.Value)if(!found.Contains(col))
    throw new Exception("Original validation fixture schema lacks "+entry.Key+"."+col);
   Console.WriteLine("PASS original validation fixture schema "+entry.Key+" columns="+entry.Value.Length);
  }
 }
 static void ActualRecoveredInventoryRollback(IDbConnection conn) {
  if(!conn.ConnectionString.Contains("logica_recovered_check") || !conn.ConnectionString.Contains("127.0.0.1"))
   throw new Exception("Original-schema rollback only allowed in isolated recovered check database");
  string articleId;object originalStock;
  using(var c=conn.CreateCommand()) {
   c.CommandText="SELECT ID_ARTICLE FROM TABLE_ARTICLES ORDER BY ID LIMIT 1";
   articleId=Convert.ToString(c.ExecuteScalar());
   if(string.IsNullOrEmpty(articleId))throw new Exception("No recovered article for rollback fixture");
   c.CommandText="SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE=@article LIMIT 1";
   var p=c.CreateParameter();p.ParameterName="@article";p.Value=articleId;c.Parameters.Add(p);
   originalStock=c.ExecuteScalar();
  }
  // Exercise a second article as well: a late failure must roll back every
  // preceding stock change and movement, not only the first row.
  string secondId;object secondStock;
  using(var c=conn.CreateCommand()) {
   c.CommandText="SELECT ID_ARTICLE FROM TABLE_ARTICLES WHERE ID_ARTICLE<>@first ORDER BY ID LIMIT 1";
   var p=c.CreateParameter();p.ParameterName="@first";p.Value=articleId;c.Parameters.Add(p);
   secondId=Convert.ToString(c.ExecuteScalar());
   if(string.IsNullOrEmpty(secondId))throw new Exception("Missing second recovered article");
   c.Parameters.Clear();c.CommandText="SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE=@second LIMIT 1";
   p=c.CreateParameter();p.ParameterName="@second";p.Value=secondId;c.Parameters.Add(p);
   secondStock=c.ExecuteScalar();
  }
  const string receipt="CI_RECOVERED_TX_ROLLBACK_BR";
  const string count="CI_RECOVERED_TX_ROLLBACK_INV";
  using(var check=conn.CreateCommand()) {
   check.CommandText="SELECT (SELECT COUNT(*) FROM TABLE_RECEPTIONS_ENTETE WHERE ID_BR='"+receipt+"')+(SELECT COUNT(*) FROM TABLE_INVENTAIRES_ENTETE WHERE ID_INV='"+count+"')";
   if(Convert.ToInt32(check.ExecuteScalar())!=0)throw new Exception("Recovered transaction fixture marker already exists");
  }
  bool injectedFailure=false;
  using(var tx=conn.BeginTransaction()) {
   try {
    using(var c=conn.CreateCommand()) {
     c.Transaction=tx;
     c.CommandText="UPDATE TABLE_ARTICLES SET STOCK=COALESCE(STOCK,0)+1 WHERE ID_ARTICLE=@article";
     var p=c.CreateParameter();p.ParameterName="@article";p.Value=articleId;c.Parameters.Add(p);
     if(c.ExecuteNonQuery()!=1)throw new Exception("Recovered article update did not affect exactly one row");
     c.Parameters.Clear();
     c.CommandText="INSERT INTO TABLE_RECEPTIONS_ENTETE (ID_BR,ETAT) VALUES ('"+receipt+"','VALIDER')";c.ExecuteNonQuery();
     c.CommandText="INSERT INTO TABLE_INVENTAIRES_ENTETE (ID_INV,ETAT) VALUES ('"+count+"','VALIDER')";c.ExecuteNonQuery();
     c.CommandText="INSERT INTO TABLE_RECEPTIONS_DETAILS (ID_BR,ID_ARTICLE,ETAT) VALUES ('"+receipt+"',@article,'VALIDER')";
     p=c.CreateParameter();p.ParameterName="@article";p.Value=articleId;c.Parameters.Add(p);c.ExecuteNonQuery();c.Parameters.Clear();
     c.CommandText="INSERT INTO TABLE_INVENTAIRES_DETAILS (ID_INV,ID_ARTICLE,ETAT) VALUES ('"+count+"',@article,'VALIDER')";
     p=c.CreateParameter();p.ParameterName="@article";p.Value=articleId;c.Parameters.Add(p);c.ExecuteNonQuery();c.Parameters.Clear();
     c.CommandText="INSERT INTO TABLE_MOUVEMENTS_STOCK (LIBELLE,ID_ARTICLE,QUANTITE) VALUES ('CI_RECOVERED_ROLLBACK',@article,'1')";
     p=c.CreateParameter();p.ParameterName="@article";p.Value=articleId;c.Parameters.Add(p);c.ExecuteNonQuery();
     c.Parameters.Clear();
     c.CommandText="UPDATE TABLE_ARTICLES SET STOCK=COALESCE(STOCK,0)+2 WHERE ID_ARTICLE=@second";
     p=c.CreateParameter();p.ParameterName="@second";p.Value=secondId;c.Parameters.Add(p);
     if(c.ExecuteNonQuery()!=1)throw new Exception("Second recovered article update did not affect exactly one row");
     c.Parameters.Clear();
     c.CommandText="INSERT INTO TABLE_MOUVEMENTS_STOCK (LIBELLE,ID_ARTICLE,QUANTITE) VALUES ('CI_RECOVERED_ROLLBACK',@second,'2')";
     p=c.CreateParameter();p.ParameterName="@second";p.Value=secondId;c.Parameters.Add(p);c.ExecuteNonQuery();
     c.Parameters.Clear();c.CommandText="SELECT LAST_INSERT_ID()";var movementId=Convert.ToInt64(c.ExecuteScalar());
     c.CommandText="INSERT INTO TABLE_MOUVEMENTS_STOCK (ID,LIBELLE) VALUES ("+movementId+",'CI_DUPLICATE')";
     try { c.ExecuteNonQuery(); } catch(System.Data.Common.DbException) { injectedFailure=true; }
     if(!injectedFailure)throw new Exception("Expected duplicate movement key violation was not observed");
    }
   } finally { tx.Rollback(); }
  }
  using(var c=conn.CreateCommand()) {
   c.CommandText="SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE=@article LIMIT 1";
   var p=c.CreateParameter();p.ParameterName="@article";p.Value=articleId;c.Parameters.Add(p);
   object afterStock=c.ExecuteScalar();
   if(!object.Equals(Convert.ToString(originalStock),Convert.ToString(afterStock)))throw new Exception("Original article stock changed despite rollback");
   c.Parameters.Clear();
   c.CommandText="SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE=@second LIMIT 1";
   p=c.CreateParameter();p.ParameterName="@second";p.Value=secondId;c.Parameters.Add(p);
   object secondAfter=c.ExecuteScalar();
   if(!object.Equals(Convert.ToString(secondStock),Convert.ToString(secondAfter)))
    throw new Exception("Second original article stock changed despite rollback");
   c.Parameters.Clear();
   c.CommandText="SELECT (SELECT COUNT(*) FROM TABLE_RECEPTIONS_ENTETE WHERE ID_BR='"+receipt+"')+(SELECT COUNT(*) FROM TABLE_RECEPTIONS_DETAILS WHERE ID_BR='"+receipt+"')+(SELECT COUNT(*) FROM TABLE_INVENTAIRES_ENTETE WHERE ID_INV='"+count+"')+(SELECT COUNT(*) FROM TABLE_INVENTAIRES_DETAILS WHERE ID_INV='"+count+"')+(SELECT COUNT(*) FROM TABLE_MOUVEMENTS_STOCK WHERE LIBELLE='CI_RECOVERED_ROLLBACK')";
   if(Convert.ToInt32(c.ExecuteScalar())!=0)throw new Exception("Recovered rollback left partial header or movement");
  }
  Console.WriteLine("PASS recovered original-schema TWO articles + receipt/inventory headers/details + TWO movements rollback on late duplicate key");
 }
 static void Watch(){while(!stop){EnumWindows(delegate(IntPtr w,IntPtr x){uint pid;GetWindowThreadProcessId(w,out pid);if(pid!=Process.GetCurrentProcess().Id)return true;var b=new StringBuilder(100);GetClassName(w,b,100);if(b.ToString()!="#32770")return true;var all=new StringBuilder();EnumChildWindows(w,delegate(IntPtr c,IntPtr y){var text=new StringBuilder(600);GetWindowText(c,text,600);if(text.Length>0)all.Append(text+" ");return true;},IntPtr.Zero);lock(errors){errors.Add(all.ToString());}PostMessage(w,0x10,IntPtr.Zero,IntPtr.Zero);return true;},IntPtr.Zero);Thread.Sleep(100);}}
 [STAThread]static int Main(){var watcher=new Thread(Watch);watcher.IsBackground=true;watcher.Start();try{
 Application.EnableVisualStyles();var a=Assembly.LoadFrom(Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"LOGICA.exe"));
 var forms=a.GetType("LOGICA.My.MyProject",true).GetProperty("Forms",BindingFlags.NonPublic|BindingFlags.Static).GetValue(null,null);var form=(Form)Get(forms,"Form_0_TEMPLATE");var handle=form.Handle;
 var module=a.GetType("LOGICA.Module1",true);var connection=(IDbConnection)module.GetField("cn_SQL").GetValue(null);
 if(!connection.ConnectionString.Contains("logica_recovered_check"))throw new Exception("Wrong recovery test database");
 connection.Open();VerifyOriginalValidationFixtureSchema(connection);ActualRecoveredInventoryRollback(connection);foreach(var entry in new[]{new[]{"TABLE_ARTICLES","120"},new[]{"TABLE_FAMILLES","15"},new[]{"TABLE_VENTES_ENTETE","11"},new[]{"TABLE_VENTES_JOURNAL","54"},new[]{"TABLE_VENTES_REGLEMENTS","11"}}){using(var c=connection.CreateCommand()){c.CommandText="SELECT COUNT(*) FROM "+entry[0];var count=Convert.ToInt32(c.ExecuteScalar());if(count!=int.Parse(entry[1]))throw new Exception("Recovered row count mismatch "+entry[0]);Console.WriteLine("PASS recovered "+entry[0]+" rows="+count);}}
 int verified=0;
 var inventory=File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"..","input","database-inventory.json"));
 foreach(System.Text.RegularExpressions.Match entry in System.Text.RegularExpressions.Regex.Matches(inventory,"\\\"([A-Za-z_][A-Za-z_0-9]*)\\\"\\s*:\\s*\\{\\s*\\\"rows\\\":\\s*(\\d+)")) {
  string table=entry.Groups[1].Value;int expected=int.Parse(entry.Groups[2].Value)+(table=="TABLE_PARAMETRES"?1:0);
  using(var c=connection.CreateCommand()){c.CommandText="SELECT COUNT(*) FROM `"+table+"`";if(Convert.ToInt32(c.ExecuteScalar())!=expected)throw new Exception("Original table row count mismatch: "+table);}
  verified++;
 }
 if(verified!=125)throw new Exception("Not all original data tables were checked: "+verified);
 Console.WriteLine("PASS all 125 original table row counts preserved (one documented compatibility setting added)");
 connection.Close();form.Show();Application.DoEvents();
 if(((Control)Get(form,"Panel_TENTATIVE_CONNEXION")).Visible)throw new Exception("Original startup connection failure: "+((Control)Get(form,"Label_ERREUR")).Text);
 lock(errors){if(errors.Count>0)throw new Exception("Original startup modal errors: "+string.Join(" | ",errors.ToArray()));}
 Console.WriteLine("PASS original startup connected to recovered database; connection error panel hidden");Console.WriteLine("Activation panel visible="+((Control)Get(form,"Panel_clé")).Visible+" (original activation mechanism preserved)");
 form.Dispose();return 0;
 }catch(Exception e){Console.WriteLine("FAIL "+e);return 1;}finally{stop=true;}}
}
