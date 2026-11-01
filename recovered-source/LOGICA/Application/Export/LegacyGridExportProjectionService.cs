using System.Data;

namespace LOGICA.ApplicationLayer.Export
{
    // Characterization of the original Excel projection in both the client settlement
    // and stock movement forms. Do not "fix" index mapping, null mutation, type
    // selection or empty/new row handling without separate behavior approval.
    internal static class LegacyGridExportProjectionService
    {
        internal static DataTable Project(ILegacyGridExportSource source)
        {
            DataTable dataTable = new DataTable();
            foreach (ILegacyGridExportColumn column in source.Columns)
            {
                if (column.IsExactTextBoxColumn)
                    dataTable.Columns.Add(column.HeaderText, column.ValueType);
            }
            foreach (ILegacyGridExportRow row in source.Rows)
            {
                dataTable.Rows.Add();
                foreach (ILegacyGridExportCell cell in row.Cells)
                {
                    if (cell.IsExactTextBoxCell)
                    {
                        if (cell.Value == null)
                            cell.Value = "-";
                        dataTable.Rows[checked(dataTable.Rows.Count - 1)][cell.ColumnIndex] =
                            cell.Value.ToString();
                    }
                }
            }
            return dataTable;
        }
    }
}
