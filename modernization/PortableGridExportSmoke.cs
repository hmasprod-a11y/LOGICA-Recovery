using System;
using System.Collections.Generic;
using System.Data;
using LOGICA.ApplicationLayer.Export;

internal static class PortableGridExportSmoke
{
    private sealed class Column : ILegacyGridExportColumn
    {
        public bool IsExactTextBoxColumn { get { return true; } }
        public string HeaderText { get { return "ARTICLE"; } }
        public Type ValueType { get { return typeof(string); } }
    }
    private sealed class Cell : ILegacyGridExportCell
    {
        public bool IsExactTextBoxCell { get { return true; } }
        public int ColumnIndex { get { return 0; } }
        public object Value { get; set; }
    }
    private sealed class Row : ILegacyGridExportRow
    {
        private readonly Cell cell;
        public Row(Cell cell) { this.cell = cell; }
        public IEnumerable<ILegacyGridExportCell> Cells
        {
            get { yield return cell; }
        }
    }
    private sealed class Source : ILegacyGridExportSource
    {
        private readonly Cell cell;
        public Source(Cell cell) { this.cell = cell; }
        public IEnumerable<ILegacyGridExportColumn> Columns
        {
            get { yield return new Column(); }
        }
        public IEnumerable<ILegacyGridExportRow> Rows
        {
            get { yield return new Row(cell); }
        }
    }
    public static void Verify()
    {
        var cell = new Cell();
        DataTable table = LegacyGridExportProjectionService.Project(new Source(cell));
        if (table.Columns.Count != 1 || table.Rows.Count != 1 ||
            (string)table.Rows[0][0] != "-" || (string)cell.Value != "-")
            throw new Exception("Portable stock/client grid export projection changed");
    }
}
