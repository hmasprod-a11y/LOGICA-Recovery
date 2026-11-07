using System;
using System.IO;
using LOGICA.Presentation.Checkout;

internal static class DesktopSolderSubmissionSmoke
{
    private static int assertions;
    private static void Check(bool ok, string name) { assertions++; if (!ok) throw new Exception(name); }
    private static void Throws(Action action)
    {
        bool thrown = false;
        try { action(); } catch (InvalidOperationException) { thrown = true; }
        Check(thrown, "invalid guard transition accepted");
    }
    private static void VerifySource(string s)
    {
        int wrapper=s.IndexOf("private void Button_Click(object sender, EventArgs e)",StringComparison.Ordinal);
        int core=s.IndexOf("private void Button_ClickCore(object sender, EventArgs e)",StringComparison.Ordinal);
        int post=s.IndexOf("CheckoutTransactionFinalizationService.PostAndFinalize(",StringComparison.Ordinal);
        int mark=s.IndexOf("_solderSubmissionGuard.MarkPostingAttempt();",StringComparison.Ordinal);
        int rollback=s.IndexOf("CheckoutTransactionBoundaryService.Rollback(checkoutBoundary);",StringComparison.Ordinal);
        int abort=rollback<0 ? -1 : s.IndexOf("return;",rollback,StringComparison.Ordinal);
        // Successful checkout resets the basket by binding a newly filled
        // DataTable; the old Clear() implementation is intentionally gone.
        int reset=s.IndexOf("Module1.dt1 = new DataTable();",post,StringComparison.Ordinal);
        int rebind=reset<0 ? -1 : s.IndexOf("DataGridView1.DataSource = Module1.dt1;",reset,StringComparison.Ordinal);
        int complete=s.IndexOf("_solderSubmissionGuard.MarkCompleted();",StringComparison.Ordinal);
        Check(wrapper>=0 && core>wrapper && core<post,"event wrapper missing");
        string entry=s.Substring(wrapper,core-wrapper);
        Check(entry.Contains("TryBegin()") && entry.Contains("RequiresReconciliation") &&
              entry.Contains("finally") && entry.Contains("EndAttempt()"),"reentrant click guard missing");
        Check(mark>core && mark<post,"posting latch must precede finalizer");
        Check(rollback>post && abort>rollback && abort<reset,"failure must abort before basket reset");
        Check(reset>post && rebind>reset && complete>rebind,
              "completion must follow successful new basket rebind");
        Check(s.Contains("catch (Exception rollbackFailure)"),"rollback error handling missing");
    }
    private static void TestGuard()
    {
        var g=new SolderSubmissionGuard();
        Check(g.TryBegin(),"first click");
        Check(!g.TryBegin(),"double click");
        g.EndAttempt();
        Check(g.TryBegin() && !g.RequiresReconciliation,"pre-posting validation retry");
        g.MarkPostingAttempt();
        Check(g.RequiresReconciliation,"ambiguous commit latch");
        g.EndAttempt();
        Check(!g.TryBegin(),"unknown commit must not retry");
        var h=new SolderSubmissionGuard();
        Throws(()=>h.MarkPostingAttempt());
        Throws(()=>h.MarkCompleted());
        Check(h.TryBegin(),"new checkout");
        h.MarkPostingAttempt();
        h.MarkCompleted();
        h.EndAttempt();
        Check(h.TryBegin(),"completed sale permits next checkout");
        h.EndAttempt();
    }
    public static int Main(string[] args)
    {
        try
        {
            if(args.Length!=1) throw new Exception("WinForms source path required");
            TestGuard();
            string s=File.ReadAllText(args[0]);
            VerifySource(s);
            string[] broken={
                s.Replace("_solderSubmissionGuard.MarkPostingAttempt();","/* removed */"),
                s.Replace("_solderSubmissionGuard.MarkCompleted();","/* removed */"),
                s.Replace("_solderSubmissionGuard.EndAttempt();","/* removed */"),
                s.Replace("catch (Exception rollbackFailure)","catch (InvalidOperationException rollbackFailure)")
            };
            foreach(string b in broken)
            {
                bool rejected=false;
                try { VerifySource(b); } catch(Exception) { rejected=true; }
                Check(rejected,"unsafe source fixture accepted");
            }
            Console.WriteLine("PASS: Desktop SOLDER guard runtime and source wiring; "+assertions+" assertions");
            return 0;
        }
        catch(Exception ex) { Console.Error.WriteLine("FAIL: "+ex); return 1; }
    }
}
