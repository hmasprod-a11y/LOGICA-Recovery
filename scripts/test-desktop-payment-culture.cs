// Isolated WinForms payment-culture regression. No shop database, licensing or checkout writes.
using System;
using System.Globalization;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

internal static class DesktopPaymentCultureSmoke
{
    private const BindingFlags Flags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance;
    private static object Get(object instance, string name)
    {
        PropertyInfo property = instance.GetType().GetProperty(name, Flags);
        if (property == null) throw new Exception("Missing cashier control: " + name);
        return property.GetValue(instance, null);
    }
    private static void Expect(bool condition, string message)
    {
        if (!condition) throw new Exception(message);
    }
    private static void Recalculate(Form form)
    {
        MethodInfo method = form.GetType().GetMethod("Button_calc_Click", Flags);
        Expect(method != null, "Payment calculation handler missing");
        method.Invoke(form, new object[] { form, EventArgs.Empty });
    }
    [STAThread]
    private static int Main()
    {
        CultureInfo original = Thread.CurrentThread.CurrentCulture;
        try
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("fr-FR");
            Application.EnableVisualStyles();
            Assembly assembly = Assembly.LoadFrom(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "LOGICA.exe"));
            using (Form form = (Form)Activator.CreateInstance(assembly.GetType("LOGICA.FormDialog_calc", true)))
            {
                DataGridView grid = (DataGridView)Get(form, "DataGridView_CALC");
                Control total = (Control)Get(form, "Text_TOTAL_NET");
                Control remainder = (Control)Get(form, "Button_RESTE");
                Control solder = (Control)Get(form, "Button_SOLDER");
                grid.AllowUserToAddRows = false;
                grid.Rows.Clear();

                // French cashier amount with a comma must keep all cents.
                total.Text = "20,50";
                grid.Rows.Add(new object[] { 20.50m, "10,25", 0m, "ESPECES", null });
                Recalculate(form);
                Expect(decimal.Parse(remainder.Text, CultureInfo.CurrentCulture) == 10.25m,
                    "Comma decimal remainder was truncated or rounded incorrectly");
                Expect(!solder.Enabled, "Partial French cash payment enabled SOLDER");

                // RESTE must ADD the outstanding amount to the selected method,
                // not replace the amount already entered (10,25 + 10,25).
                MethodInfo fillRemainder = form.GetType().GetMethod("Button_RESTE_Click", Flags);
                Expect(fillRemainder != null, "RESTE handler missing");
                grid.CurrentCell = grid.Rows[0].Cells[1];
                // A stale visible remainder must be recomputed from the grid.
                remainder.Text = "1,00";
                fillRemainder.Invoke(form, new object[] { remainder, EventArgs.Empty });
                Expect(Convert.ToDecimal(grid.Rows[0].Cells[1].Value) == 20.50m &&
                    decimal.Parse(remainder.Text, CultureInfo.CurrentCulture) == 0m && solder.Enabled,
                    "RESTE replaced a partial cash amount instead of completing it");
                // Restore the partial payment to test the second payment-method path.
                grid.Rows[0].Cells[1].Value = "10,25";
                Recalculate(form);

                // A second method inherits the exact due amount, never Conversion.Val's 10.
                // Even if the old displayed remainder was stale, the actual grid
                // is authoritative before creating the second payment row.
                remainder.Text = "999,99";
                MethodInfo add = form.GetType().GetMethod("FAM_click", Flags);
                Expect(add != null, "Payment-method click handler missing");
                using (Button method = new Button() { Text = "ESPECES" })
                    add.Invoke(form, new object[] { method, EventArgs.Empty });
                Expect(grid.Rows.Count == 2, "Valid payment method was not inserted");
                Expect(Convert.ToDecimal(grid.Rows[1].Cells[0].Value) == 10.25m,
                    "New payment method lost cents from a comma-decimal remainder");
                grid.Rows[1].Cells[1].Value = 10.25m;
                Recalculate(form);
                Expect(decimal.Parse(remainder.Text, CultureInfo.CurrentCulture) == 0m && solder.Enabled,
                    "Exact French mixed payment failed to settle");

                // Clicking the first method's non-editable cells must focus
                // THAT method's paid amount, not the last row of a split tender.
                MethodInfo clickRow = form.GetType().GetMethod("DataGridView_CALC_CellClick", Flags);
                Expect(clickRow != null, "Payment grid click handler missing");
                grid.CurrentCell = grid.Rows[1].Cells[1];
                clickRow.Invoke(form, new object[] { grid, new DataGridViewCellEventArgs(0, 0) });
                Expect(grid.CurrentCell.RowIndex == 0 && grid.CurrentCell.ColumnIndex == 1,
                    "Clicking first payment row redirected editing to last payment method");
                clickRow.Invoke(form, new object[] { grid, new DataGridViewCellEventArgs(2, 1) });
                Expect(grid.CurrentCell.RowIndex == 1 && grid.CurrentCell.ColumnIndex == 1,
                    "Clicking second payment row did not select its amount");

                // A completed/overpaid sale must retain its actual tendered cash.
                // RESTE must not erase the change, and another method must not
                // insert a negative due row after overpayment.
                grid.Rows[1].Cells[1].Value = 11m;
                Recalculate(form);
                Expect(decimal.Parse(remainder.Text, CultureInfo.CurrentCulture) == -0.75m,
                    "Overpaid split tender did not calculate change");
                grid.CurrentCell = grid.Rows[1].Cells[1];
                fillRemainder.Invoke(form, new object[] { remainder, EventArgs.Empty });
                Expect(Convert.ToDecimal(grid.Rows[1].Cells[1].Value) == 11m,
                    "RESTE silently erased cash change on an overpaid sale");
                int beforeOverpaidMethod = grid.Rows.Count;
                using (Button extra = new Button() { Text = "CARTE" })
                    add.Invoke(form, new object[] { extra, EventArgs.Empty });
                Expect(grid.Rows.Count == beforeOverpaidMethod,
                    "Overpaid sale created a negative-due payment method");
                grid.Rows[1].Cells[1].Value = 10.25m;
                Recalculate(form);

                // The real 0.5 coin button is captioned with a dot even under fr-FR.
                // The original Val/AddObject path could lose the half-dirham.
                MethodInfo coinClick = form.GetType().GetMethod("Button_DEVIS_Click", Flags);
                Expect(coinClick != null, "Cash denomination handler missing");
                grid.CurrentCell = grid.Rows[1].Cells[1];
                grid.Rows[1].Cells[1].Value = 10m;
                Button halfDirham = (Button)Get(form, "Button_DEVISE_0_5");
                Expect(halfDirham.Text == "0.5", "Unexpected original half-dirham caption");
                coinClick.Invoke(form, new object[] { halfDirham, EventArgs.Empty });
                Expect(Convert.ToDecimal(grid.Rows[1].Cells[1].Value) == 10.50m,
                    "Half-dirham coin was lost under French decimal culture");
                Expect(decimal.Parse(remainder.Text, CultureInfo.CurrentCulture) == -0.25m,
                    "Coin button failed to recalculate exact cents");
                using (Button invalidCoin = new Button() { Text = "not money" })
                    coinClick.Invoke(form, new object[] { invalidCoin, EventArgs.Empty });
                Expect(Convert.ToDecimal(grid.Rows[1].Cells[1].Value) == 10.50m,
                    "Invalid denomination modified cashier payment");

                // A denomination always belongs to ESPECES, even when the
                // cashier is editing a card/transfer line in a split payment.
                grid.Rows.Clear();
                total.Text = "20,50";
                grid.Rows.Add(new object[] { 20.50m, 10m, 0m, "CARTE", null });
                Recalculate(form);
                FlowLayoutPanel configuredMethods = (FlowLayoutPanel)Get(form, "FlowLayoutPanel_MODE_P");
                using (Button cashMethod = new Button() { Text = "ESPECES" })
                {
                    configuredMethods.Controls.Add(cashMethod);
                    grid.CurrentCell = grid.Rows[0].Cells[1];
                    coinClick.Invoke(form, new object[] { halfDirham, EventArgs.Empty });
                    Expect(grid.Rows.Count == 2 &&
                        Convert.ToDecimal(grid.Rows[0].Cells[1].Value) == 10m &&
                        Convert.ToDecimal(grid.Rows[1].Cells[1].Value) == 0.5m &&
                        grid.CurrentCell.RowIndex == 1,
                        "Cash coin modified card payment or failed to create cash row");
                    // Switching back to the card line must not redirect cash
                    // denomination input into the card tender.
                    grid.CurrentCell = grid.Rows[0].Cells[1];
                    coinClick.Invoke(form, new object[] { halfDirham, EventArgs.Empty });
                    Expect(grid.Rows.Count == 2 &&
                        Convert.ToDecimal(grid.Rows[0].Cells[1].Value) == 10m &&
                        Convert.ToDecimal(grid.Rows[1].Cells[1].Value) == 1m,
                        "Cash coin altered selected card instead of existing cash row");
                    configuredMethods.Controls.Remove(cashMethod);
                }
                // A positive cash denomination is not a refund entry.
                grid.Rows.Clear();
                total.Text = "-10,25";
                grid.Rows.Add(new object[] { -10.25m, -5m, 0m, "ESPECES", null });
                Recalculate(form);
                grid.CurrentCell = grid.Rows[0].Cells[1];
                coinClick.Invoke(form, new object[] { halfDirham, EventArgs.Empty });
                Expect(Convert.ToDecimal(grid.Rows[0].Cells[1].Value) == -5m,
                    "Positive cash denomination modified negative refund");

                // The decompiled 2pt captions must remain legible if the
                // original denomination bitmap resource is missing.
                halfDirham.BackgroundImage = null;
                MethodInfo fallbackCaptions = form.GetType().GetMethod("EnsureReadableDenominationButtons", Flags);
                Expect(fallbackCaptions != null, "Missing denomination caption fallback");
                fallbackCaptions.Invoke(form, null);
                Expect(halfDirham.Font.Size >= 11f &&
                    halfDirham.TextAlign == System.Drawing.ContentAlignment.MiddleCenter,
                    "Missing coin image leaves unreadable 2pt denomination caption");

                // Restore exact split tender for keypad tests below.
                grid.Rows.Clear();
                total.Text = "20,50";
                grid.Rows.Add(new object[] { 20.50m, 10.25m, 0m, "ESPECES", null });
                grid.Rows.Add(new object[] { 10.25m, 10.50m, 0m, "ESPECES", null });
                Recalculate(form);

                // Physical keypad dot maps to the active culture, and repeated
                // separators are rejected rather than creating invalid payment.
                MethodInfo keypress = form.GetType().GetMethod("TextBox_keyPress", Flags);
                Expect(keypress != null, "Physical keypad handler missing");
                using (TextBox editor = new TextBox())
                {
                    editor.Text = "1";
                    editor.SelectionStart = editor.Text.Length;
                    KeyPressEventArgs dot = new KeyPressEventArgs('.');
                    keypress.Invoke(form, new object[] { editor, dot });
                    Expect(!dot.Handled && dot.KeyChar == ',',
                        "French physical keypad dot was not normalized");
                    editor.Text = "1,2";
                    editor.SelectionStart = editor.Text.Length;
                    KeyPressEventArgs repeated = new KeyPressEventArgs('.');
                    keypress.Invoke(form, new object[] { editor, repeated });
                    Expect(repeated.Handled, "Duplicate French decimal separator accepted");
                }
                MethodInfo keypad = form.GetType().GetMethod("Butt_Click", Flags);
                Expect(keypad != null, "On-screen keypad handler missing");
                Control display = (Control)Get(form, "Label_NUM");
                display.Text = "";
                foreach (string digit in new[] { "0", ".", "2", "5" })
                    using (Button key = new Button() { Text = digit })
                        keypad.Invoke(form, new object[] { key, EventArgs.Empty });
                Expect(display.Text == "0,25", "On-screen keypad ignored French decimal separator");
                using (Button repeatedDot = new Button() { Text = "." })
                    keypad.Invoke(form, new object[] { repeatedDot, EventArgs.Empty });
                Expect(display.Text == "0,25", "On-screen keypad accepted duplicate decimal point");
                // Confirming the on-screen keypad must apply its amount directly
                // and recalculate, without synthetic SendKeys changing focus.
                display.Text = "10,25";
                grid.CurrentCell = grid.Rows[1].Cells[1];
                MethodInfo keypadOk = form.GetType().GetMethod("Button_CLAVIER_NOSELECT1_Click", Flags);
                Expect(keypadOk != null, "On-screen keypad confirmation handler missing");
                keypadOk.Invoke(form, new object[] { form, EventArgs.Empty });
                Expect(Convert.ToDecimal(grid.Rows[1].Cells[1].Value) == 10.25m &&
                    decimal.Parse(remainder.Text, CultureInfo.CurrentCulture) == 0m && solder.Enabled,
                    "On-screen keypad failed to replace the selected payment amount");

                // A valid cash method is still cash when legacy settings contain
                // lowercase labels, whitespace or a missing ESPECS.png icon.
                MethodInfo cashLookup = form.GetType().GetMethod("CashPaymentButton", Flags);
                Expect(cashLookup != null, "Cash method lookup missing");
                FlowLayoutPanel methods = (FlowLayoutPanel)Get(form, "FlowLayoutPanel_MODE_P");
                using (Button cash = new Button() { Name = "Button_especes", Text = " especes " })
                {
                    methods.Controls.Add(cash);
                    Expect(Object.ReferenceEquals(cashLookup.Invoke(form, null), cash),
                        "Case/space variant cash method was not available without an icon");
                    methods.Controls.Remove(cash);
                }
                // A lower-case cash label must NOT be treated as a card payment
                // and auto-filled; the cashier still enters the actual cash tendered.
                grid.Rows.Clear();
                total.Text = "20,50";
                Recalculate(form);
                using (Button cash = new Button() { Text = " especes " })
                    add.Invoke(form, new object[] { cash, EventArgs.Empty });
                Expect(grid.Rows.Count == 1 && Convert.ToDecimal(grid.Rows[0].Cells[1].Value) == 0m,
                    "Legacy lower-case cash was incorrectly auto-settled as noncash");

                // Wide payment-method flow must not be positioned off the left
                // edge when high DPI or many configured methods exceed the panel.
                Control panel = (Control)Get(form, "Panel_MODE_P");
                FlowLayoutPanel flow = (FlowLayoutPanel)Get(form, "FlowLayoutPanel_MODE_P");
                flow.AutoSize = false;
                panel.Width = 100;
                flow.Width = 300;
                MethodInfo shown = form.GetType().GetMethod("Form_Shown", Flags);
                Expect(shown != null, "Payment layout handler missing");
                shown.Invoke(form, new object[] { form, EventArgs.Empty });
                Expect(flow.Left >= 0, "High-DPI payment methods hidden off the left edge");
                // Resizing the payment panel must recompute alignment, not just Shown.
                flow.Width = 80;
                panel.Width = 300;
                Expect(flow.Left == (panel.ClientSize.Width - flow.Width) / 2,
                    "Payment methods were not recentered after a DPI/layout resize");
                panel.Width = 60;
                flow.Width = 300;
                Expect(flow.Left >= 0, "Resizing clipped the first payment method");

                // Incomplete totals cannot be silently converted into a zero-due row.
                total.Text = "";
                Recalculate(form);
                Expect(!solder.Enabled && remainder.Text == "", "Invalid total left SOLDER enabled");
                int rows = grid.Rows.Count;
                using (Button method = new Button() { Text = "ESPECES" })
                    add.Invoke(form, new object[] { method, EventArgs.Empty });
                Expect(grid.Rows.Count == rows, "Invalid remainder inserted a fake zero-due payment");

                // Negative values are intentional in the original return workflow.
                grid.Rows.Clear();
                total.Text = "-10,25";
                grid.Rows.Add(new object[] { -10.25m, -10.25m, 0m, "ESPECES", null });
                Recalculate(form);
                Expect(decimal.Parse(remainder.Text, CultureInfo.CurrentCulture) == 0m && solder.Enabled,
                    "Negative return payment no longer settles");
                // Over-refunding must not be silently rewritten as an exact refund.
                grid.Rows[0].Cells[1].Value = "-12,00";
                Recalculate(form);
                grid.CurrentCell = grid.Rows[0].Cells[1];
                fillRemainder.Invoke(form, new object[] { remainder, EventArgs.Empty });
                Expect(Convert.ToDecimal(grid.Rows[0].Cells[1].Value) == -12m,
                    "RESTE silently erased an over-refund");
                int beforeOverRefundMethod = grid.Rows.Count;
                using (Button extraRefund = new Button() { Text = "CARTE" })
                    add.Invoke(form, new object[] { extraRefund, EventArgs.Empty });
                Expect(grid.Rows.Count == beforeOverRefundMethod,
                    "Over-refund created a positive-due payment method");
                // Partial refunds must also be completed additively by RESTE.
                grid.Rows[0].Cells[1].Value = "-5,00";
                Recalculate(form);
                grid.CurrentCell = grid.Rows[0].Cells[1];
                fillRemainder.Invoke(form, new object[] { remainder, EventArgs.Empty });
                Expect(Convert.ToDecimal(grid.Rows[0].Cells[1].Value) == -10.25m &&
                    decimal.Parse(remainder.Text, CultureInfo.CurrentCulture) == 0m && solder.Enabled,
                    "RESTE failed to complete a partial negative refund");

                // Total normalization must preserve all cents even above Double\u0027s
                // exact integer range, and invalid input must remain invalid.
                MethodInfo normalize = form.GetType().GetMethod("NormalizePaymentTotal",
                    BindingFlags.NonPublic | BindingFlags.Static);
                Expect(normalize != null, "Decimal total normalizer missing");
                string exactLarge = (string)normalize.Invoke(null, new object[] { "9007199254740993,25" });
                Expect(decimal.Parse(exactLarge, CultureInfo.CurrentCulture) == 9007199254740993.25m,
                    "Payment dialog lost cents through a Double conversion");
                Expect((string)normalize.Invoke(null, new object[] { "not a total" }) == "",
                    "Malformed sale total was silently accepted");

                // A malformed extreme payment must fail closed rather than crash the UI.
                grid.Rows.Clear();
                total.Text = "1";
                grid.Rows.Add(new object[] { 0m, decimal.MaxValue, 0m, "ESPECES", null });
                grid.Rows.Add(new object[] { 0m, 1m, 0m, "ESPECES", null });
                Recalculate(form);
                Expect(!solder.Enabled && remainder.Text == "", "Overflow left an actionable SOLDER state");

                // Payment icons are cloned bitmaps owned by the dialog.
                // Closing it must release the native GDI+ resource.
                Bitmap ownedIcon = new Bitmap(2, 2);
                Button iconMethod = new Button() { Text = "ICON", Image = ownedIcon };
                ((FlowLayoutPanel)Get(form, "FlowLayoutPanel_MODE_P")).Controls.Add(iconMethod);
                form.Dispose();
                bool released = false;
                try { ownedIcon.GetPixel(0, 0); }
                catch (ArgumentException) { released = true; }
                catch (ObjectDisposedException) { released = true; }
                Expect(released, "Closing payment dialog leaked owned method icon");
            }
            Console.WriteLine("PASS French decimal SOLDER, exact large totals, cash-only coin routing, readable missing-image captions, icon disposal, overpayment/change/refund guards, stale-edit RESTE/method guards, clicked payment-row identity, keypad confirm, additive cash/refunds, half-dirham, dynamic DPI and overflow");
            return 0;
        }
        catch (Exception exception)
        {
            Console.Error.WriteLine(exception.ToString());
            return 1;
        }
        finally
        {
            Thread.CurrentThread.CurrentCulture = original;
        }
    }
}
