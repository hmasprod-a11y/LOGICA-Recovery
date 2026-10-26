using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Threading;

class DumpShim
{
 static string Quote(string s){return "\""+s.Replace("\"","\\\"")+"\"";}
 static int Main(string[] args)
 {
  string options=args.First(a=>a.StartsWith("--defaults-file=")).Substring("--defaults-file=".Length);
  // The only granted SID must be the executing account. Do not read credentials.
  var sid=WindowsIdentity.GetCurrent().User;
  var rules=File.GetAccessControl(options).GetAccessRules(true,true,typeof(SecurityIdentifier));
  foreach(FileSystemAccessRule rule in rules)if(rule.AccessControlType==AccessControlType.Allow&&!rule.IdentityReference.Equals(sid))return 91;
  if(args.Any(a=>a.StartsWith("--password")))return 92;
  string mode=Environment.GetEnvironmentVariable("LOGICA_DUMP_SHIM_MODE");
  if(mode=="failure"||mode=="incomplete")
  {
   string result=args.First(a=>a.StartsWith("--result-file=")).Substring("--result-file=".Length);
   File.WriteAllText(result,"incomplete SQL");
   File.WriteAllText(Environment.GetEnvironmentVariable("LOGICA_DUMP_CASE_MARKER"),mode);return mode=="failure"?7:0;
  }
  File.WriteAllText(Environment.GetEnvironmentVariable("LOGICA_DUMP_REACHED"),"locked");
  for(int i=0;i<1000&&!File.Exists(Environment.GetEnvironmentVariable("LOGICA_DUMP_RELEASE"));i++)Thread.Sleep(20);
  var start=new ProcessStartInfo(Environment.GetEnvironmentVariable("LOGICA_DUMP_REAL"),string.Join(" ",args.Select(Quote)));
  start.UseShellExecute=false;start.CreateNoWindow=true;
  using(var p=Process.Start(start)){p.WaitForExit();return p.ExitCode;}
 }
}
