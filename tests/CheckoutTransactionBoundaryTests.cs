using System;
using System.Collections.Generic;
using LOGICA.ApplicationLayer.Checkout;

// Characterization of the original Form_3_VENTE begin/commit/close/catch ordering.
// In particular, Begin is OUTSIDE the try, and rollback errors are not swallowed.
internal static class CheckoutTransactionBoundaryTests
{
    private sealed class Injected : Exception
    {
        internal Injected(string stage) : base(stage) { }
    }

    private sealed class Boundary : ICheckoutTransactionBoundary
    {
        internal readonly List<string> Events = new List<string>();
        internal bool InitiallyOpen;
        internal string FailAt;
        internal string RollbackFailAt;
        private void Mark(string stage)
        {
            Events.Add(stage);
            if (stage == FailAt || (stage == "rollback" && RollbackFailAt == stage))
                throw new Injected(stage);
        }
        public bool IsOpen { get { Mark("state"); return InitiallyOpen; } }
        public void Open() { Mark("open"); }
        public void BeginAndBind() { Mark("begin.bind"); }
        public void Commit() { Mark("commit"); }
        public void Close() { Mark("close"); }
        public void Rollback() { Mark("rollback"); }
        internal void Post() { Mark("post"); }
    }

    private static void LegacyBegin(Boundary boundary)
    {
        if (!boundary.IsOpen) boundary.Open();
        boundary.BeginAndBind();
    }

    private static void LegacyCommitAndClose(Boundary boundary)
    {
        boundary.Commit();
        boundary.Close();
    }

    private static string Execute(bool extracted, bool initiallyOpen, string failAt,
        string rollbackFailAt, bool waiting, out string events)
    {
        var boundary = new Boundary {
            InitiallyOpen = initiallyOpen, FailAt = failAt, RollbackFailAt = rollbackFailAt
        };
        try
        {
            // Deliberately before the try/catch that owns rollback in the Form.
            if (extracted) CheckoutTransactionBoundaryService.Begin(boundary);
            else LegacyBegin(boundary);
        }
        catch (Exception error)
        {
            events = String.Join(",", boundary.Events.ToArray());
            return "before-try:" + error.GetType().FullName + ":" + error.Message;
        }

        try
        {
            if (!waiting) boundary.Post();
            if (extracted) CheckoutTransactionBoundaryService.CommitAndClose(boundary);
            else LegacyCommitAndClose(boundary);
        }
        catch (Exception error)
        {
            try
            {
                if (extracted) CheckoutTransactionBoundaryService.Rollback(boundary);
                else boundary.Rollback();
            }
            catch (Exception rollbackError)
            {
                events = String.Join(",", boundary.Events.ToArray());
                return "rollback:" + rollbackError.GetType().FullName + ":" + rollbackError.Message;
            }
            events = String.Join(",", boundary.Events.ToArray());
            return "caught:" + error.GetType().FullName + ":" + error.Message;
        }
        events = String.Join(",", boundary.Events.ToArray());
        return "success";
    }

    private static void Compare(bool open, string failure, string rollbackFailure, bool waiting)
    {
        string oldEvents, newEvents;
        string oldResult = Execute(false, open, failure, rollbackFailure, waiting, out oldEvents);
        string newResult = Execute(true, open, failure, rollbackFailure, waiting, out newEvents);
        string label = "open=" + open + " failure=" + failure + " rollback=" + rollbackFailure
            + " waiting=" + waiting;
        if (oldResult != newResult || oldEvents != newEvents)
            throw new Exception(label + ": old " + oldResult + " [" + oldEvents +
                "] new " + newResult + " [" + newEvents + "]");
        if (failure == null && oldResult != "success")
            throw new Exception(label + ": unexpected failure");
        if (failure == "open" || failure == "begin.bind" || failure == "state")
        {
            if (oldEvents.IndexOf("rollback", StringComparison.Ordinal) >= 0)
                throw new Exception(label + ": begin failure incorrectly rolled back");
        }
        if (failure == "commit" && oldEvents.IndexOf("close", StringComparison.Ordinal) >= 0)
            throw new Exception(label + ": closed after failed commit");
        if (!waiting && failure == "post" && oldEvents.IndexOf("commit", StringComparison.Ordinal) >= 0)
            throw new Exception(label + ": committed after failed posting");
    }

    public static int Main()
    {
        string[] stages = { null, "state", "open", "begin.bind", "post", "commit", "close" };
        int cases = 0;
        foreach (bool initiallyOpen in new[] { false, true })
        foreach (bool waiting in new[] { false, true })
        foreach (string stage in stages)
        {
            Compare(initiallyOpen, stage, null, waiting);
            Compare(initiallyOpen, stage, "rollback", waiting);
            cases += 2;
        }
        Console.WriteLine("PASS checkout transaction boundary: " + cases +
            " legacy parity cases, including pre-try begin, commit/close and rollback failures");
        return 0;
    }
}
