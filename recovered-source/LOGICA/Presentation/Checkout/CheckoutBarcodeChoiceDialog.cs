using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace LOGICA.Presentation.Checkout
{
    // Windows-only adapter: keep modal selection out of the portable checkout core.
    internal static class CheckoutBarcodeChoiceDialog
    {
        internal static int Choose(DataTable matches, string priceColumn)
        {
            using (Form dialog = new Form())
            {
                dialog.Text = "Hanouty — choisir un article";
                dialog.ClientSize = new Size(650, 380);
                dialog.MinimumSize = dialog.Size;
                dialog.FormBorderStyle = FormBorderStyle.FixedDialog;
                dialog.MaximizeBox = false;
                dialog.MinimizeBox = false;
                dialog.ShowInTaskbar = false;
                dialog.StartPosition = FormStartPosition.CenterScreen;

                Label heading = new Label();
                heading.Text = "Plusieurs articles utilisent ce code-barres. Choisissez l'article à vendre :";
                heading.SetBounds(18, 16, 615, 40);
                heading.AutoSize = false;

                ListBox list = new ListBox();
                list.SetBounds(18, 62, 614, 240);
                list.IntegralHeight = false;
                list.Font = new Font("Segoe UI", 10f);
                list.HorizontalScrollbar = true;
                foreach (DataRow row in matches.Rows)
                    list.Items.Add(Describe(row, priceColumn));

                Button confirm = new Button();
                confirm.Text = "Choisir cet article";
                confirm.SetBounds(444, 323, 188, 38);
                confirm.DialogResult = DialogResult.OK;
                confirm.Enabled = false;

                Button cancel = new Button();
                cancel.Text = "Annuler";
                cancel.SetBounds(330, 323, 105, 38);
                cancel.DialogResult = DialogResult.Cancel;

                list.SelectedIndexChanged += delegate { confirm.Enabled = list.SelectedIndex >= 0; };
                list.DoubleClick += delegate {
                    if (list.SelectedIndex >= 0) { dialog.DialogResult = DialogResult.OK; dialog.Close(); }
                };
                dialog.Controls.Add(heading);
                dialog.Controls.Add(list);
                dialog.Controls.Add(confirm);
                dialog.Controls.Add(cancel);
                dialog.AcceptButton = confirm;
                dialog.CancelButton = cancel;
                dialog.Shown += delegate { list.Focus(); };
                return dialog.ShowDialog() == DialogResult.OK ? list.SelectedIndex : -1;
            }
        }

        // Display only the active price tier; the actual posting still reads the
        // selected original DataRow, never this presentation string.
        internal static string Describe(DataRow row, string priceColumn)
        {
            string id = Value(row, "ID_ARTICLE");
            string name = Value(row, "Article");
            string code = Value(row, "Code");
            string price = !String.IsNullOrEmpty(priceColumn) ? Value(row, priceColumn) : "";
            return name + "   |   " + code + "   |   ID: " + id +
                (price.Length == 0 ? "" : "   |   Prix: " + price);
        }

        private static string Value(DataRow row, string column)
        {
            return row.Table.Columns.Contains(column) && !row.IsNull(column)
                ? Convert.ToString(row[column]) : "";
        }
    }
}
