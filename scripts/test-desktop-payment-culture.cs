// Isolated WinForms payment-culture regression. No shop database, licensing or checkout writes.
using System;
using System.Globalization;
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

                // A second method inherits the exact due amount, never Conversion.Val's 10.
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

                // A malformed extreme payment must fail closed rather than crash the UI.
                grid.Rows.Clear();
                total.Text = "1";
                grid.Rows.Add(new object[] { 0m, decimal.MaxValue, 0m, "ESPECES", null });
                grid.Rows.Add(new object[] { 0m, 1m, 0m, "ESPECES", null });
                Recalculate(form);
                Expect(!solder.Enabled && remainder.Text == "", "Overflow left an actionable SOLDER state");
            }
            Console.WriteLine("PASS French decimal SOLDER, half-dirham coin, both keypads, DPI layout, returns and overflow");
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
