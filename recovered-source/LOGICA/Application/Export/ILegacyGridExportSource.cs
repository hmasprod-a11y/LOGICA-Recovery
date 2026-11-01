using System;
using System.Collections.Generic;

namespace LOGICA.ApplicationLayer.Export
{
    // The WinForms adapter is the only component allowed to know about DataGridView.
    // These members deliberately expose the legacy iteration order and mutable cell values.
    internal interface ILegacyGridExportSource
    {
        IEnumerable<ILegacyGridExportColumn> Columns { get; }
        IEnumerable<ILegacyGridExportRow> Rows { get; }
    }

    internal interface ILegacyGridExportColumn
    {
        bool IsExactTextBoxColumn { get; }
        string HeaderText { get; }
        Type ValueType { get; }
    }

    internal interface ILegacyGridExportRow
    {
        IEnumerable<ILegacyGridExportCell> Cells { get; }
    }

    internal interface ILegacyGridExportCell
    {
        bool IsExactTextBoxCell { get; }
        int ColumnIndex { get; }
        object Value { get; set; }
    }
}
