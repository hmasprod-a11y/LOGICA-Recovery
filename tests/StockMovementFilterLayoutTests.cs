using System;
using System.Collections.Generic;
using LOGICA.Domain;
using LOGICA.ApplicationLayer.Inventory;

// Independent characterization oracle: copies the original two event bodies,
// not the extracted service implementation.
internal static class StockMovementFilterLayoutTests
{
    private sealed class Context : IStockMovementFilterLayoutContext
    {
        public readonly List<string> Calls = new List<string>();
        public readonly Exception Failure = new InvalidOperationException("injected UI event failure");
        public int FailAt;
        public bool Checked, Visible, Reenter;
        public string Column = "ARTICLE", Search = "old";
        public int Left = 19, Width = 21;

        private void Step(string name)
        {
            Calls.Add(name);
            if (FailAt == Calls.Count) throw Failure;
        }

        public bool DateFilterChecked { get { Step("checked"); return Checked; } }
        public string SelectedColumn { get { Step("column"); return Column; } }
        public void SetDatePanelVisible(bool visible)
        {
            Step("visible:" + visible);
            Visible = visible;
        }
        public void SetDatePanelLeft(int left)
        {
            Step("left:" + left);
            Left = left;
        }
        public void SetDatePanelWidth(int width)
        {
            Step("width:" + width);
            Width = width;
        }
        public void SetSearchText(string text)
        {
            Step("text:" + text);
            Search = text;
            // A control setter may synchronously trigger a search event.
            if (Reenter) Step("search-event");
        }
    }

    private sealed class Semantics : ILegacyStockMovementSemantics
    {
        private readonly Context context;
        public Semantics(Context context) { this.context = context; }
        public bool EqualsText(string left, string right)
        {
            context.Calls.Add("compare:" + right);
            if (context.FailAt == context.Calls.Count) throw context.Failure;
            return String.Equals(left, right, StringComparison.Ordinal);
        }
    }

    private static void OriginalDate(Context c)
    {
        if (c.DateFilterChecked) c.SetDatePanelVisible(true);
        else c.SetDatePanelVisible(false);
    }

    private static void OriginalColumn(Context c, Semantics semantics)
    {
        if (semantics.EqualsText(c.SelectedColumn, "DATES"))
        {
            c.SetDatePanelVisible(true);
            c.SetDatePanelLeft(127);
            c.SetDatePanelWidth(713);
            c.SetSearchText("*");
        }
        else
        {
            c.SetDatePanelVisible(false);
            c.SetDatePanelLeft(564);
            c.SetDatePanelWidth(276);
            c.SetSearchText("");
        }
    }

    private static int assertions;

    private static void Verify(bool dateEvent, bool checkedValue, string column, int failAt, bool reenter)
    {
        var expected = new Context { Checked = checkedValue, Column = column, FailAt = failAt, Reenter = reenter };
        var actual = new Context { Checked = checkedValue, Column = column, FailAt = failAt, Reenter = reenter };
        Exception expectedError = null, actualError = null;
        try
        {
            if (dateEvent) OriginalDate(expected);
            else OriginalColumn(expected, new Semantics(expected));
        }
        catch (Exception error) { expectedError = error; }
        try
        {
            if (dateEvent) StockMovementFilterLayoutService.DateCheckboxChanged(actual);
            else StockMovementFilterLayoutService.ColumnChanged(actual, new Semantics(actual));
        }
        catch (Exception error) { actualError = error; }

        string expectedCalls = String.Join("|", expected.Calls.ToArray());
        string actualCalls = String.Join("|", actual.Calls.ToArray());
        if (expectedCalls != actualCalls)
            throw new Exception("Original filter event order differs: " + expectedCalls + " vs " + actualCalls);
        assertions++;
        if (expected.Visible != actual.Visible || expected.Left != actual.Left ||
            expected.Width != actual.Width || expected.Search != actual.Search)
            throw new Exception("Filter panel/text partial state differs");
        assertions++;
        if ((expectedError == null) != (actualError == null) ||
            (expectedError != null && (!Object.ReferenceEquals(expectedError, expected.Failure) ||
                                       !Object.ReferenceEquals(actualError, actual.Failure))))
            throw new Exception("Filter exception identity or propagation differs");
        assertions++;
    }

    public static int Main()
    {
        foreach (bool checkedValue in new[] { false, true })
        {
            for (int failure = 0; failure <= 3; failure++)
                Verify(true, checkedValue, "DATES", failure, false);
        }
        foreach (string column in new[] { "DATES", "ARTICLE", "dates", "", null })
        {
            for (int failure = 0; failure <= 7; failure++)
            {
                Verify(false, false, column, failure, false);
                Verify(false, true, column, failure, true);
            }
        }
        Console.WriteLine("PASS inventory filter UI boundary: " + assertions +
            " original-oracle assertions across checkbox, column, exceptions and reentrant setters");
        return 0;
    }
}
