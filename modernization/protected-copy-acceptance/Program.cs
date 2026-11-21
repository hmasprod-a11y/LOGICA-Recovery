using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using Hanouty.Desktop.Bootstrap;
using MySql.Data.MySqlClient;
using Hanouty.Checkout.MariaDb;
using Hanouty.ArchitectureBridge;

var root = Path.GetFullPath(args[0]);
var tools = Path.GetFullPath(args[1]);
var outRoot = Path.GetFullPath(args[2]); Directory.CreateDirectory(outRoot);
var secret = new SecureString(); foreach (var c in "copy-test-only") secret.AppendChar(c); secret.MakeReadOnly();
var credentials = new ProtectedCopyCredentials("root", secret);
if(Environment.GetEnvironmentVariable("HANOUTY_COPY_DISPOSABLE")!="I_ACKNOWLEDGE_DISPOSABLE_DB_ONLY")throw new Exception("Explicit disposable server marker required");
var copyPort=uint.Parse(Environment.GetEnvironmentVariable("HANOUTY_COPY_PORT")??"0");if(copyPort is 0 or >65535)throw new Exception("Explicit disposable port required");
var cs = new MySqlConnectionStringBuilder { Server="127.0.0.1", Port=copyPort, UserID="root", Password="copy-test-only", CharacterSet="utf8mb4", Pooling=false };
using var admin = new MySqlConnection(cs.ConnectionString); admin.Open();
void Sql(string sql) { using var cmd = new MySqlCommand(sql,admin); cmd.ExecuteNonQuery(); }
object Scalar(string sql) { using var cmd = new MySqlCommand(sql,admin); return cmd.ExecuteScalar()!; }
var suffix = Guid.NewGuid().ToString("N"); var sourceName="copy_fixture_"+suffix;
Sql("CREATE DATABASE `"+sourceName+"` CHARACTER SET utf8mb4"); admin.ChangeDatabase(sourceName);
var original = File.ReadAllText(Path.Combine(root,"input","recovered-original.sql"));
var names = new[] {"TABLE_PASS","TABLE_NUM","TABLE_ARTICLES","TABLE_PARAMETRES","TABLE_MODE_P","TABLE_VENTES_ENTETE","TABLE_VENTES_JOURNAL","TABLE_VENTES_REGLEMENTS","TABLE_MOUVEMENTS_STOCK","TABLE_CLIENTS","TABLE_FOURNISSEURS","TABLE_CLIENTS_REGLE","TABLE_FOURNISSEURS_REGLE","TABLE_INVENTAIRES_ENTETE","TABLE_INVENTAIRES_DETAILS","TABLE_COMMANDES_ENTETE","TABLE_COMMANDES_DETAILS","TABLE_RECEPTIONS_ENTETE","TABLE_RECEPTIONS_DETAILS","TABLE_SORTIES_ENTETE","TABLE_SORTIES_DETAILS","TABLE_DEPENSES","TABLE_01"};
foreach(var name in names) {
 var match=Regex.Match(original,@"CREATE TABLE\s+`"+Regex.Escape(name)+@"`\s*\([\s\S]*?;",RegexOptions.IgnoreCase);
 if(!match.Success) throw new Exception("Missing source DDL "+name);
 Sql(match.Value);
}
Sql("INSERT INTO TABLE_ARTICLES (ID_ARTICLE,Code,Article,PRIX_A,PRIX_MP,PRIX_V_1,STOCK) VALUES ('fixture','CODE-fixture','Lait été حليب',4,4,6,12)");
Sql("UPDATE TABLE_ARTICLES SET Famille='Food',TAUX_TVA=0,PROMOTION=0");
Sql("INSERT INTO TABLE_PASS (ListUser,ListPass,`Catégorie`) VALUES ('Admin été مسؤول','1234','ADMIN')");
Sql("SET SESSION sql_mode=CONCAT(@@sql_mode,',NO_AUTO_VALUE_ON_ZERO')");
Sql("INSERT INTO TABLE_NUM (ID,CL,CLIENT,INV,BC,BR,BS) VALUES (0,0,0,0,0,0,0)");
var migrations = Directory.GetFiles(Path.Combine(root,"input","migrations"),"*.sql").Select(file => {var text=File.ReadAllText(file).Replace("\r\n","\n");return new ProtectedCopyMigration(Path.GetFileName(file),text,Convert.ToHexString(SHA256.HashData(Encoding.UTF8.GetBytes(text))));}).ToArray();
ProtectedLocalCopyRequest Request(string label)=>new("127.0.0.1",copyPort,sourceName,"hanouty_"+label+suffix,Path.Combine(outRoot,label+suffix),tools,credentials,credentials,migrations);
var before=Convert.ToString(Scalar("SELECT CONCAT(COUNT(*),':',SUM(STOCK),':',HEX(MAX(Article))) FROM TABLE_ARTICLES"));
var success=await new ProtectedLocalCopyService().PrepareAsync(Request("ok"));
if(!success.Ready || !success.SourceUnchanged || File.Exists(Path.Combine(success.DataDirectory,"source-private.cnf"))) throw new Exception("Unsafe result");
using(var copied=new MySqlConnection(cs.ConnectionString)) { copied.Open(); copied.ChangeDatabase(success.Database); using var query=new MySqlCommand("SELECT Article,STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='fixture'",copied);using var rows=query.ExecuteReader();rows.Read();if(rows.GetString(0)!="Lait été حليب" || rows.GetDouble(1)!=12)throw new Exception("Copy bytes mismatch"); }
var copiedCs = new MySqlConnectionStringBuilder(cs.ConnectionString) { Database=success.Database };
var port=MariaDbCashCheckoutServices.CreatePostingPort(()=>new MySqlConnection(copiedCs.ConnectionString),"01",()=>"1234");
port.Commit(new AuthorizedCheckoutRequest("copy-sale", "Admin été مسؤول", "MAD", false, new[]{new CheckoutBatchLine("fixture",1)},new[]{new CheckoutPayment(CheckoutPaymentKind.Cash,6m)},6m));
using(var copied=new MySqlConnection(copiedCs.ConnectionString)) {
 copied.Open();
 using var check=new MySqlCommand("SELECT (SELECT COUNT(*) FROM TABLE_NUM WHERE ID=0 AND CL=1),(SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='fixture'),(SELECT SUM(MONTANT) FROM TABLE_VENTES_REGLEMENTS),(SELECT COUNT(*) FROM hanouty_checkout_operations)",copied);
 using var row=check.ExecuteReader();row.Read();if(row.GetInt64(0)!=1||row.GetDecimal(1)!=11m||row.GetDecimal(2)!=6m||row.GetInt64(3)!=1)throw new Exception("First checkout data invalid");
}
port.Commit(new AuthorizedCheckoutRequest("copy-sale", "Admin été مسؤول", "MAD", false, new[]{new CheckoutBatchLine("fixture",1)},new[]{new CheckoutPayment(CheckoutPaymentKind.Cash,6m)},6m));
var failed=Request("fault");try{await new ProtectedLocalCopyService(stage=>{if(stage=="import-verified")throw new InvalidOperationException("Injected failure after import.");}).PrepareAsync(failed);throw new Exception("Fault not refused");}catch(ProtectedLocalCopyException e)when(e.Message.Contains("Injected")){}
if(Convert.ToString(Scalar("SELECT CONCAT(COUNT(*),':',SUM(STOCK),':',HEX(MAX(Article))) FROM TABLE_ARTICLES"))!=before)throw new Exception("Source changed");
foreach(var unsafeRequest in new[]{Request("bad") with{DestinationDatabase=sourceName},Request("existing") with{DestinationDatabase=success.Database},Request("folder") with{NewDataDirectory=success.DataDirectory}}){try{await new ProtectedLocalCopyService().PrepareAsync(unsafeRequest);throw new Exception("Dangerous destination accepted");}catch(ProtectedLocalCopyException){}}
Sql("UPDATE TABLE_NUM SET ID=1 WHERE ID=0");
try{await new ProtectedLocalCopyService().PrepareAsync(Request("badcounter"));throw new Exception("Bad counter accepted");}catch(ProtectedLocalCopyException e)when(e.Message.Contains("Compteurs")){}
Sql("UPDATE TABLE_NUM SET ID=0 WHERE ID=1");
try{await new ProtectedLocalCopyService(stage=>{if(stage=="import-verified")Sql("UPDATE TABLE_ARTICLES SET STOCK=STOCK+1");}).PrepareAsync(Request("sourcechanged"));throw new Exception("Changed source accepted");}catch(ProtectedLocalCopyException e)when(e.Message.Contains("source a changé")){}
Sql("UPDATE TABLE_ARTICLES SET STOCK=STOCK-1");
var readUser="copy_read_"+suffix;
Sql("CREATE USER '"+readUser+"'@'127.0.0.1' IDENTIFIED BY 'copy-test-only'");
Sql("GRANT SELECT ON `"+sourceName+"`.* TO '"+readUser+"'@'127.0.0.1'");
var readOnly=await new ProtectedLocalCopyService().PrepareAsync(Request("readonly") with{Source=new ProtectedCopyCredentials(readUser,secret)});
if(!readOnly.Ready)throw new Exception("Read-only account failed");
var summary=new {Ready=true,SelectOnlySourceAccount=true,ProductionSaleOnCopy=true,OriginalAutoIncrementZeroPreserved=true,FirstCheckoutStockPaymentCounter=true,CheckoutReplay=true,SourceChangeRefused=true,InvalidOriginalCounterRefused=true,SourceUnchanged=true,OriginalSchemaFixture=true,Utf8Copy=true,InjectedAfterImportRefused=true,SameSchemaRefused=true,ExistingSchemaRefused=true,ExistingFolderRefused=true,TemporaryCredentialsRemoved=true,MigrationCount=migrations.Length,success.BackupSha256,success.JournalFile};
File.WriteAllText(Path.Combine(outRoot,"acceptance.json"),System.Text.Json.JsonSerializer.Serialize(summary,new System.Text.Json.JsonSerializerOptions{WriteIndented=true}));
Console.WriteLine(System.Text.Json.JsonSerializer.Serialize(summary));




