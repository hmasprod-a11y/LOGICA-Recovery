using System;
using System.Collections.Generic;
using System.Data;
using LOGICA.ApplicationLayer.Export;

internal static class LegacyGridExportProjectionTests
{
    private sealed class Column : ILegacyGridExportColumn
    {
        public bool IsExactTextBoxColumn { get; set; }
        public string HeaderText { get; set; }
        public Type ValueType { get; set; }
    }
    private sealed class Cell : ILegacyGridExportCell
    {
        public bool IsExactTextBoxCell { get; set; }
        public int ColumnIndex { get; set; }
        public object Stored;
        public bool FailOnRead;
        public int Writes;
        public object Value
        {
            get { if (FailOnRead) throw new InvalidOperationException("cell read"); return Stored; }
            set { Writes++; Stored = value; }
        }
    }
    private sealed class Row : ILegacyGridExportRow
    {
        public readonly List<ILegacyGridExportCell> Items = new List<ILegacyGridExportCell>();
        public IEnumerable<ILegacyGridExportCell> Cells { get { return Items; } }
    }
    private sealed class Source : ILegacyGridExportSource
    {
        public readonly List<ILegacyGridExportColumn> ColumnItems = new List<ILegacyGridExportColumn>();
        public readonly List<ILegacyGridExportRow> RowItems = new List<ILegacyGridExportRow>();
        public IEnumerable<ILegacyGridExportColumn> Columns { get { return ColumnItems; } }
        public IEnumerable<ILegacyGridExportRow> Rows { get { return RowItems; } }
    }
    private static Column Col(string name, bool text, Type type)
    {
        return new Column { HeaderText = name, IsExactTextBoxColumn = text, ValueType = type };
    }
    private static Cell Value(int index, bool text, object value)
    {
        return new Cell { ColumnIndex = index, IsExactTextBoxCell = text, Stored = value };
    }
    private static void Check(bool condition, string description)
    {
        if (!condition) throw new Exception("Legacy export changed: " + description);
    }
    public static int Main()
    {
        var source = new Source();
        source.ColumnItems.Add(Col("CODE", true, typeof(string)));
        source.ColumnItems.Add(Col("QTY", true, typeof(string)));
        source.ColumnItems.Add(Col("Button", false, typeof(string)));
        var row = new Row();
        var nullCell = Value(0, true, null);
        var quantity = Value(1, true, 12);
        var button = Value(2, false, "ignored");
        row.Items.Add(nullCell);
        row.Items.Add(quantity);
        row.Items.Add(button);
        source.RowItems.Add(row);
        source.RowItems.Add(new Row()); // The legacy grid includes the empty new-row.
        DataTable result = LegacyGridExportProjectionService.Project(source);
        Check(result.Columns.Count == 2 && result.Columns[0].ColumnName == "CODE" &&
            result.Columns[1].ColumnName == "QTY", "strict column selection/order");
        Check(result.Rows.Count == 2, "empty new-row must remain in export");
        Check((string)result.Rows[0][0] == "-" && (string)result.Rows[0][1] == "12",
            "null substitution and ToString conversion");
        Check((string)nullCell.Stored == "-" && nullCell.Writes == 1,
            "null cell mutated in original grid");
        Check(quantity.Writes == 0 && button.Writes == 0,
            "non-null and non-text cells not mutated");
        Check(result.Rows[1].IsNull(0) && result.Rows[1].IsNull(1),
            "empty row remains empty");

        var indexMismatch = new Source();
        indexMismatch.ColumnItems.Add(Col("Text", true, typeof(string)));
        indexMismatch.ColumnItems.Add(Col("Button", false, typeof(string)));
        indexMismatch.ColumnItems.Add(Col("Other", true, typeof(string)));
        var mismatchRow = new Row();
        mismatchRow.Items.Add(Value(2, true, "third"));
        indexMismatch.RowItems.Add(mismatchRow);
        bool threw = false;
        try { LegacyGridExportProjectionService.Project(indexMismatch); }
        catch (IndexOutOfRangeException) { threw = true; }
        Check(threw, "original cell index mapping must not be silently normalized");

        var failure = new Source();
        failure.ColumnItems.Add(Col("Text", true, typeof(string)));
        var badRow = new Row();
        var broken = Value(0, true, null);
        broken.FailOnRead = true;
        var after = Value(0, true, "should not read");
        badRow.Items.Add(broken);
        badRow.Items.Add(after);
        failure.RowItems.Add(badRow);
        threw = false;
        try { LegacyGridExportProjectionService.Project(failure); }
        catch (InvalidOperationException ex) { threw = ex.Message == "cell read"; }
        Check(threw && after.Writes == 0, "failure propagates without processing later cells");
        Console.WriteLine("PASS shared client/inventory export: column types, row order, null mutation, original index and failure boundaries");
        return 0;
    }
}
