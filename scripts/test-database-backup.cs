using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using LOGICA;
using MySql.Data.MySqlClient;

class BackupCheck
{
 static string Source { get { return Environment.GetEnvironmentVariable("LOGICA_DB_CONNECTION_STRING"); } }
 static string Work { get { return Environment.GetEnvironmentVariable("LOGICA_BACKUP_TEST_ROOT"); } }
 static string Bin { get { return Environment.GetEnvironmentVariable("LOGICA_MYSQL_BIN"); } }
 static void Assert(bool value,string label) { if(!value)throw new Exception(label); Console.WriteLine("PASS "+label); }
 static void Sql(MySqlConnection c,string sql) { using(var cmd=c.CreateCommand()){cmd.CommandText=sql;cmd.ExecuteNonQuery();} }
 static object Scalar(MySqlConnection c,string sql) { using(var cmd=c.CreateCommand()){cmd.CommandText=sql;return cmd.ExecuteScalar();} }
 static MySqlConnection Open(string text) { var c=new MySqlConnection(text);c.Open();return c; }
 static string Q(string name) { return "`"+name.Replace("`","``")+"`"; }
 static Dictionary<string,string> Snapshot(MySqlConnection c)
 {
  var names=new List<string>();
  using(var cmd=c.CreateCommand()){cmd.CommandText="SHOW FULL TABLES";using(var r=cmd.ExecuteReader())while(r.Read())if(r.GetString(1)=="BASE TABLE")names.Add(r.GetString(0));}
  var result=new Dictionary<string,string>();
  foreach(var name in names){using(var cmd=c.CreateCommand()){cmd.CommandText="CHECKSUM TABLE "+Q(name)+" EXTENDED";using(var r=cmd.ExecuteReader()){r.Read();result[name]=Convert.ToString(r.GetValue(1));}}result[name]+="/"+Scalar(c,"SELECT COUNT(*) FROM "+Q(name));}
  return result;
 }
 static void Same(Dictionary<string,string> a,Dictionary<string,string> b,string label)
 { Assert(a.Count==b.Count&&a.All(p=>b.ContainsKey(p.Key)&&b[p.Key]==p.Value),label); }
 static void Fixtures(MySqlConnection c)
 {
  Sql(c,"SET SESSION sql_mode=''");
  foreach(var table in new[]{"TABLE_CI_BACKUP_A","TABLE_CI_BACKUP_B","TABLE_CI_BACKUP_EMPTY"})
   Sql(c,"CREATE TABLE "+Q(table)+" (ID INT AUTO_INCREMENT PRIMARY KEY,LABEL TEXT CHARACTER SET utf8mb4,MONEY DECIMAL(14,3),NOTES TEXT NULL,RAW_DATA BLOB,DAY DATE) ENGINE=InnoDB");
  foreach(var table in new[]{"TABLE_CI_BACKUP_A","TABLE_CI_BACKUP_B"})
   Sql(c,"INSERT INTO "+Q(table)+" (LABEL,MONEY,NOTES,RAW_DATA,DAY) VALUES ('زبون O''Brien',-12.345,NULL,0x0001275c00ff,'1900-01-00'),('éà',0.005,CONCAT('one',CHAR(10),'two'),0x01,'2026-10-26')");
  Sql(c,"CREATE VIEW CI_BACKUP_VIEW AS SELECT ID,MONEY FROM TABLE_CI_BACKUP_A");
  Sql(c,"CREATE PROCEDURE CI_BACKUP_PROC() READS SQL DATA SELECT COUNT(*) FROM TABLE_CI_BACKUP_A");
  Sql(c,"CREATE TRIGGER CI_BACKUP_INSERT BEFORE INSERT ON TABLE_CI_BACKUP_B FOR EACH ROW SET NEW.NOTES=COALESCE(NEW.NOTES,'trigger')");
  Sql(c,"CREATE EVENT CI_BACKUP_EVENT ON SCHEDULE AT '2099-01-01 00:00:00' DISABLE DO DELETE FROM TABLE_CI_BACKUP_EMPTY");
 }
 static string ResetThroughOriginalForm(string[] suffixes)
 {
  var module=typeof(DatabaseBackup).Assembly.GetType("LOGICA.Module1",true);
  // Force the real app to open its connection first: password masking must
  // not break subsequent backup authentication.
  var connection=(MySqlConnection)module.GetField("cn_SQL").GetValue(null);
  connection.Open();connection.Close();
  module.GetField("_CHEMIN_FOLDER").SetValue(null,Work);
  using(var form=(Form)Activator.CreateInstance(typeof(DatabaseBackup).Assembly.GetType("LOGICA.FormDialog_8_BASE_DONNEE",true)))
  {
   var list=(CheckedListBox)form.GetType().GetProperty("CheckedListBox1",BindingFlags.Instance|BindingFlags.Public|BindingFlags.NonPublic).GetValue(form,null);
   list.Items.Clear();foreach(var s in suffixes)list.Items.Add(s,true);
   try{return (string)form.GetType().GetMethod("BackupAndClearSelectedTables").Invoke(form,null);}
   catch(TargetInvocationException e){throw e.InnerException;}
  }
 }
 static void MustFail(Action work,string label)
 { bool failed=false;try{work();}catch{failed=true;}Assert(failed,label); }
 static void FailuresAndReset()
 {
  using(var c=Open(Source))
  {
   var before=Snapshot(c);
   MustFail(()=>DatabaseBackup.CreateAndClear(Source,Path.Combine(Work,"missing"),new[]{"TABLE_CI_BACKUP_A"},Path.Combine(Work,"no-tools")),"missing dump tool rejects reset");
   MustFail(()=>DatabaseBackup.CreateAndClear(Source,Path.Combine(Work,"unknown"),new[]{"TABLE_CI_BACKUP_A;DROP DATABASE x"},Bin),"unknown table rejects reset");
   Same(before,Snapshot(c),"preflight failures preserve every source table");
   Sql(c,"CREATE TABLE CI_NON_TRANSACTIONAL (ID INT) ENGINE=MyISAM");
   MustFail(()=>DatabaseBackup.Create(Source,Path.Combine(Work,"engine"),Bin),"non-transactional engine rejected");
   Sql(c,"DROP TABLE CI_NON_TRANSACTIONAL");
   foreach(string mode in new[]{"failure","incomplete"})
   {
    string folder=Path.Combine(Work,"fake-"+mode);Directory.CreateDirectory(folder);
    File.Copy(Path.Combine(Work,"DumpShim.exe"),Path.Combine(folder,"mariadb-dump.exe"),true);
    Environment.SetEnvironmentVariable("LOGICA_DUMP_SHIM_MODE",mode);
    string output=Path.Combine(Work,"rejected-"+mode);
    string marker=Path.Combine(Work,"shim-"+mode+"-reached");
    Environment.SetEnvironmentVariable("LOGICA_DUMP_CASE_MARKER",marker);
    var temporaryBefore=Directory.GetDirectories(Path.GetTempPath(),"logica-backup-*");
    MustFail(()=>DatabaseBackup.CreateAndClear(Source,output,new[]{"TABLE_CI_BACKUP_A"},folder),mode+" dump rejects deletion");
    Assert(File.Exists(marker),mode+" injector reached after credential ACL checks");
    Assert(!Directory.GetFiles(output).Any(),mode+" leaves no completed or partial backup");
    Assert(!Directory.GetDirectories(Path.GetTempPath(),"logica-backup-*").Except(temporaryBefore).Any(),mode+" cleans temporary credentials");
    Same(before,Snapshot(c),mode+" preserves all rows");
   }
   Environment.SetEnvironmentVariable("LOGICA_DUMP_SHIM_MODE",null);
   Sql(c,"CREATE TRIGGER CI_BACKUP_REJECT BEFORE DELETE ON TABLE_CI_BACKUP_B FOR EACH ROW SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT='CI forced deletion failure'");
   bool deletionFailed=false;
   try{ResetThroughOriginalForm(new[]{"CI_BACKUP_A","CI_BACKUP_B"});}
   catch(MySqlException error){deletionFailed=error.Message.Contains("CI forced deletion failure");}
   Assert(deletionFailed,"original reset path reports the injected second-table deletion failure");
   Same(before,Snapshot(c),"second-table failure rolls back first deletion and preserves all source rows");
   Assert(Directory.GetFiles(Path.Combine(Work,"bd","backup"),"*.sql").Length==1,"valid recovery backup retained after rollback");
   Sql(c,"DROP TRIGGER CI_BACKUP_REJECT");
   string good=ResetThroughOriginalForm(new[]{"CI_BACKUP_A","CI_BACKUP_B"});DatabaseBackup.Verify(good);
   Assert(Convert.ToInt32(Scalar(c,"SELECT COUNT(*) FROM TABLE_CI_BACKUP_A"))==0&&Convert.ToInt32(Scalar(c,"SELECT COUNT(*) FROM TABLE_CI_BACKUP_B"))==0,"original form reset clears exactly the selected tables");
   var after=Snapshot(c);before.Remove("TABLE_CI_BACKUP_A");before.Remove("TABLE_CI_BACKUP_B");after.Remove("TABLE_CI_BACKUP_A");after.Remove("TABLE_CI_BACKUP_B");Same(before,after,"successful reset preserves every unselected table");
  }
 }
 static object InvokeOriginal(Form form,string name,params object[] args)
 {
  try{return form.GetType().GetMethod(name).Invoke(form,args);}
  catch(TargetInvocationException error){throw error.InnerException;}
 }
 static void QuotedCredentialBackup()
 {
  using(var c=Open(Source))
  {
   var before=Snapshot(c);
   Sql(c,"DROP USER IF EXISTS 'ci_backup_options'@'127.0.0.1'");
   string password="Ci#\"\\line\n"+Guid.NewGuid().ToString("N");
   using(var command=c.CreateCommand())
   {
    command.CommandText="CREATE USER 'ci_backup_options'@'127.0.0.1' IDENTIFIED BY @password";
    command.Parameters.AddWithValue("@password",password);command.ExecuteNonQuery();
   }
   try
   {
    Sql(c,"GRANT ALL ON logica_backup_test.* TO 'ci_backup_options'@'127.0.0.1'");
    Sql(c,"GRANT SELECT ON mysql.proc TO 'ci_backup_options'@'127.0.0.1'");
    var configured=new MySqlConnectionStringBuilder(Source);configured.UserID="ci_backup_options";configured.Password=password;
    string file=DatabaseBackup.Create(configured.ConnectionString,Path.Combine(Work,"quoted credentials"),Bin);
    DatabaseBackup.Verify(file);
    Same(before,Snapshot(c),"backup authenticates with quotes, slash, comment marker and newline in password without modifying data");
   }
   finally{Sql(c,"DROP USER 'ci_backup_options'@'127.0.0.1'");}
  }
 }
 static void ManualAndShutdown()
 {
  string actualBin=Bin;
  using(var c=Open(Source))
  using(var form=(Form)Activator.CreateInstance(typeof(DatabaseBackup).Assembly.GetType("LOGICA.FormDialog_QUITTER",true)))
  {
   var before=Snapshot(c);
   string chosen=Path.Combine(Work,"manually selected backup.sql");
   string file=(string)InvokeOriginal(form,"CreateBackupAt",chosen);DatabaseBackup.Verify(file);
   Assert(file==chosen&&File.Exists(chosen),"original manual export respects chosen SQL filename and hash");
   string hash=File.ReadAllText(chosen+".sha256");
   MustFail(()=>InvokeOriginal(form,"CreateBackupAt",chosen),"manual export refuses overwriting an existing backup");
   MustFail(()=>InvokeOriginal(form,"CreateBackupAt",Path.Combine(Work,"unsafe.sni")),"SQL backup cannot masquerade as legacy Access SNI");
   Assert(File.ReadAllText(chosen+".sha256")==hash,"previous manually saved backup preserved");
   var check=form.GetType().GetProperty("CheckBox1",BindingFlags.Instance|BindingFlags.Public|BindingFlags.NonPublic).GetValue(form,null);
   check.GetType().GetProperty("Checked").SetValue(check,true,null);
   int shutdowns=0;Action shutdown=()=>shutdowns++;
   try
   {
    Environment.SetEnvironmentVariable("LOGICA_MYSQL_BIN",Path.Combine(Work,"missing-tools"));
    MustFail(()=>InvokeOriginal(form,"BackupBeforeShutdown",shutdown),"failed requested backup rejects shutdown");
    Assert(shutdowns==0,"shutdown action never runs after backup failure");
    int exits=0;Action exit=()=>exits++;
    MustFail(()=>InvokeOriginal(form,"BackupBeforeExit",exit),"failed requested backup rejects application exit");
    Assert(exits==0,"application exit action never runs after backup failure");
    Environment.SetEnvironmentVariable("LOGICA_MYSQL_BIN",actualBin);
    InvokeOriginal(form,"BackupBeforeShutdown",shutdown);
    Assert(shutdowns==1,"requested backup succeeds before shutdown action");
    InvokeOriginal(form,"BackupBeforeExit",exit);
    Assert(exits==1,"requested backup succeeds before application exit action");
    check.GetType().GetProperty("Checked").SetValue(check,false,null);
    Environment.SetEnvironmentVariable("LOGICA_MYSQL_BIN",Path.Combine(Work,"missing-tools"));
    InvokeOriginal(form,"BackupBeforeShutdown",shutdown);
    Assert(shutdowns==2,"unchecked backup option preserves original shutdown choice");
   }
   finally{Environment.SetEnvironmentVariable("LOGICA_MYSQL_BIN",actualBin);}
   Same(before,Snapshot(c),"manual and shutdown backups preserve every source row");
  }
 }
 static void ConcurrentWriters()
 {
  using(var c=Open(Source)) {
   Sql(c,"INSERT INTO TABLE_CI_BACKUP_A(ID,LABEL,MONEY) VALUES(1,'before',12.345)");
   Sql(c,"INSERT INTO TABLE_CI_BACKUP_B(ID,LABEL,MONEY) VALUES(1,'before',12.345)");
  }
  string shim=Path.Combine(Work,"gate");Directory.CreateDirectory(shim);
  File.Copy(Path.Combine(Work,"DumpShim.exe"),Path.Combine(shim,"mariadb-dump.exe"),true);
  Environment.SetEnvironmentVariable("LOGICA_DUMP_SHIM_MODE","gate");
  Environment.SetEnvironmentVariable("LOGICA_DUMP_REAL",Path.Combine(Bin,"mariadb-dump.exe"));
  string reached=Path.Combine(Work,"dump-ready"),release=Path.Combine(Work,"dump-release");
  Environment.SetEnvironmentVariable("LOGICA_DUMP_REACHED",reached);Environment.SetEnvironmentVariable("LOGICA_DUMP_RELEASE",release);
  var operation=Task.Run(()=>DatabaseBackup.CreateAndClear(Source,Path.Combine(Work,"concurrent"),new[]{"TABLE_CI_BACKUP_A"},shim));
  var watch=Stopwatch.StartNew();while(!File.Exists(reached)&&watch.ElapsedMilliseconds<20000&&!operation.IsCompleted)Thread.Sleep(20);
  Assert(File.Exists(reached),"backup holds locks before exporter gate");
  var updateStarted=new ManualResetEventSlim();var insertStarted=new ManualResetEventSlim();
  Task update=Task.Run(()=>{using(var c=Open(Source)){updateStarted.Set();Sql(c,"UPDATE TABLE_CI_BACKUP_B SET MONEY=99 WHERE ID=1");}});
  Task insert=Task.Run(()=>{using(var c=Open(Source)){insertStarted.Set();Sql(c,"INSERT INTO TABLE_CI_BACKUP_EMPTY(LABEL,MONEY) VALUES('after backup',1)");}});
  try
  {
   Assert(updateStarted.Wait(5000)&&insertStarted.Wait(5000),"concurrent writers connected");
   Thread.Sleep(500);
   Assert(!update.IsCompleted&&!insert.IsCompleted,"updates and inserts into empty-table gaps wait during backup");
  }
  finally{File.WriteAllText(release,"go");}
  Assert(operation.Wait(30000)&&update.Wait(10000)&&insert.Wait(10000),"writers resume only after reset completes");
  DatabaseBackup.Verify(operation.Result);
  File.WriteAllText(Path.Combine(Work,"concurrent-backup-path.txt"),operation.Result);
  using(var c=Open(Source))Assert(Convert.ToInt32(Scalar(c,"SELECT COUNT(*) FROM TABLE_CI_BACKUP_EMPTY"))==1,"post-backup write is retained");
  Environment.SetEnvironmentVariable("LOGICA_DUMP_SHIM_MODE",null);
 }
 [STAThread] static int Main(string[] args)
 {
  try
  {
   var safety=new MySqlConnectionStringBuilder(Source);
   if(safety.Server!="127.0.0.1"||safety.Port!=3307||safety.Database!="logica_backup_test")
    throw new Exception("Backup tests require the dedicated isolated loopback database");
   Application.EnableVisualStyles();Directory.CreateDirectory(Work);
   if(args[0]=="export")
   {
    using(var c=Open(Source))
    {
     bool legacyRejected=false;
     try{Sql(c,"BACKUP DATABASE logica_backup_test TO DISK='ci-invalid.sql'");}
     catch(MySqlException error){legacyRejected=error.Number==1064;}
     Assert(legacyRejected,"legacy SQL Server backup syntax reproduced as MariaDB syntax error");
     Fixtures(c);var before=Snapshot(c);
     string file=DatabaseBackup.Create(Source,Path.Combine(Work,"roundtrip with spaces"),Bin);DatabaseBackup.Verify(file);
     Same(before,Snapshot(c),"full backup leaves all original and fixture rows unchanged");
     File.WriteAllText(Path.Combine(Work,"backup-path.txt"),file);
     string corrupt=Path.Combine(Work,"tampered.sql");File.Copy(file,corrupt);File.Copy(file+".sha256",corrupt+".sha256");File.AppendAllText(corrupt,"tampered");
     MustFail(()=>DatabaseBackup.Verify(corrupt),"tampered dump rejected by SHA256");
    }
   }
   else if(args[0]=="compare")
   {
    var b=new MySqlConnectionStringBuilder(Source);b.Port=3309;
    using(var source=Open(Source))using(var restored=Open(b.ConnectionString))
    {
     var original=Snapshot(source);Same(original,Snapshot(restored),"restored rows/counts/checksums match all "+original.Count+" tables including binary, Unicode, NULL, zero dates and fractional money");
     foreach(var kind in new[]{"VIEWS","ROUTINES","TRIGGERS","EVENTS"})
      Assert(Convert.ToInt32(Scalar(source,"SELECT COUNT(*) FROM information_schema."+kind+" WHERE "+(kind=="VIEWS"?"TABLE_SCHEMA":kind=="ROUTINES"?"ROUTINE_SCHEMA":kind=="TRIGGERS"?"TRIGGER_SCHEMA":"EVENT_SCHEMA")+"=DATABASE()"))==Convert.ToInt32(Scalar(restored,"SELECT COUNT(*) FROM information_schema."+kind+" WHERE "+(kind=="VIEWS"?"TABLE_SCHEMA":kind=="ROUTINES"?"ROUTINE_SCHEMA":kind=="TRIGGERS"?"TRIGGER_SCHEMA":"EVENT_SCHEMA")+"=DATABASE()")),"restored "+kind+" count matches");
     foreach(var table in original.Keys) {
      string left,right;
      using(var cmd=source.CreateCommand()){cmd.CommandText="SHOW CREATE TABLE "+Q(table);using(var r=cmd.ExecuteReader()){r.Read();left=r.GetString(1);}}
      using(var cmd=restored.CreateCommand()){cmd.CommandText="SHOW CREATE TABLE "+Q(table);using(var r=cmd.ExecuteReader()){r.Read();right=r.GetString(1);}}
      Assert(left==right,"restored schema matches "+table);
     }
     Assert(Convert.ToInt32(Scalar(restored,"SELECT COUNT(*) FROM CI_BACKUP_VIEW"))==2,"restored view resolves on isolated server");
     Sql(restored,"CALL CI_BACKUP_PROC()");
     File.WriteAllText(Path.Combine(Work,"roundtrip-result.json"),new JavaScriptSerializer().Serialize(new{status="passed",tables=original.Count,restored_on_separate_server=true}));
    }
   }
   else if(args[0]=="reset") { FailuresAndReset(); QuotedCredentialBackup(); ManualAndShutdown(); ConcurrentWriters(); }
   else if(args[0]=="concurrent-restore")
   {
    var b=new MySqlConnectionStringBuilder(Source);b.Port=3309;
    using(var c=Open(b.ConnectionString))
    {
     Assert(Convert.ToInt32(Scalar(c,"SELECT COUNT(*) FROM TABLE_CI_BACKUP_EMPTY"))==0,"concurrent backup excludes later insert");
     Assert(Convert.ToDecimal(Scalar(c,"SELECT MONEY FROM TABLE_CI_BACKUP_B WHERE ID=1"))!=99m,"concurrent backup excludes later update");
    }
   }
   else throw new ArgumentException("Unknown mode");
   return 0;
  }
  catch(Exception e){Console.WriteLine("FAIL "+e);return 1;}
 }
}
