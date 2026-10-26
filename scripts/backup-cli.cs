using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using LOGICA;

class BackupCli
{
 [STAThread] static int Main()
 {
  try {
   Application.EnableVisualStyles();
   var module=typeof(DatabaseBackup).Assembly.GetType("LOGICA.Module1",true);
   string connection=(string)module.GetMethod("DatabaseConnectionStringForMaintenance").Invoke(null,null);
   string root=AppDomain.CurrentDomain.BaseDirectory;
   string file=DatabaseBackup.Create(connection,Path.Combine(root,"bd","backup"),DatabaseBackup.FindServerBin(root));
   DatabaseBackup.Verify(file);
   Console.WriteLine("PASS sauvegarde MySQL et SHA256 : "+file);
   return 0;
  }
  catch(Exception) { Console.Error.WriteLine("Echec de sauvegarde. Aucune donnee effacee.");return 1; }
 }
}
