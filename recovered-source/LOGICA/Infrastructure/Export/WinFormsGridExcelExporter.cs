using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using ClosedXML.Excel;
using LOGICA.ApplicationLayer.Export;

namespace LOGICA.Infrastructure.Export
{
    // Legacy WinForms and ClosedXML dependencies stay outside Application/Domain.
    internal static class WinFormsGridExcelExporter
    {
        internal static void Export(DataGridView grid, string filename)
        {
            DataTable data = LegacyGridExportProjectionService.Project(new GridSource(grid));
            using (XLWorkbook workbook = new XLWorkbook())
            {
                workbook.Worksheets.Add(data, "Table");
                workbook.SaveAs(filename);
            }
        }

        private sealed class GridSource : ILegacyGridExportSource
        {
            private readonly DataGridView grid;
            internal GridSource(DataGridView grid) { this.grid = grid; }
            public IEnumerable<ILegacyGridExportColumn> Columns
            {
                get
                {
                    foreach (DataGridViewColumn column in grid.Columns)
                        yield return new Column(column);
                }
            }
            public IEnumerable<ILegacyGridExportRow> Rows
            {
                get
                {
                    foreach (DataGridViewRow row in grid.Rows)
                        yield return new Row(row);
                }
            }
        }

        private sealed class Column : ILegacyGridExportColumn
        {
            private readonly DataGridViewColumn column;
            internal Column(DataGridViewColumn column) { this.column = column; }
            public bool IsExactTextBoxColumn { get { return column.GetType() == typeof(DataGridViewTextBoxColumn); } }
            public string HeaderText { get { return column.HeaderText; } }
            public Type ValueType { get { return column.ValueType; } }
        }

        private sealed class Row : ILegacyGridExportRow
        {
            private readonly DataGridViewRow row;
            internal Row(DataGridViewRow row) { this.row = row; }
            public IEnumerable<ILegacyGridExportCell> Cells
            {
                get
                {
                    foreach (DataGridViewCell cell in row.Cells)
                        yield return new Cell(cell);
                }
            }
        }

        private sealed class Cell : ILegacyGridExportCell
        {
            private readonly DataGridViewCell cell;
            internal Cell(DataGridViewCell cell) { this.cell = cell; }
            public bool IsExactTextBoxCell { get { return cell.GetType() == typeof(DataGridViewTextBoxCell); } }
            public int ColumnIndex { get { return cell.ColumnIndex; } }
            public object Value { get { return cell.Value; } set { cell.Value = value; } }
        }
    }
}
