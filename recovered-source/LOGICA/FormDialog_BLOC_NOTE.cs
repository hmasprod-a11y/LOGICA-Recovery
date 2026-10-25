using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using LOGICA.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace LOGICA;

[DesignerGenerated]
public class FormDialog_BLOC_NOTE : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Label_BOTTOM")]
	private Label _Label_BOTTOM;

	[AccessedThroughProperty("Label_LEFT")]
	private Label _Label_LEFT;

	[AccessedThroughProperty("Label_RIGHT")]
	private Label _Label_RIGHT;

	[AccessedThroughProperty("Label_TOP")]
	private Label _Label_TOP;

	[AccessedThroughProperty("DataGridView_pied")]
	private DataGridView _DataGridView_pied;

	[AccessedThroughProperty("Column1")]
	private DataGridViewTextBoxColumn _Column1;

	[AccessedThroughProperty("Button20")]
	private Button _Button20;

	[AccessedThroughProperty("Button_SAVE")]
	private Button _Button_SAVE;

	internal virtual Label Label_BOTTOM
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_BOTTOM;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_BOTTOM = value;
		}
	}

	internal virtual Label Label_LEFT
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_LEFT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_LEFT = value;
		}
	}

	internal virtual Label Label_RIGHT
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_RIGHT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_RIGHT = value;
		}
	}

	internal virtual Label Label_TOP
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_TOP;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_TOP = value;
		}
	}

	internal virtual DataGridView DataGridView_pied
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridView_pied;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGridView_pied = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Column1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Column1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Column1 = value;
		}
	}

	internal virtual Button Button20
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button20;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button20_Click;
			if (_Button20 != null)
			{
				((Control)_Button20).Click -= eventHandler;
			}
			_Button20 = value;
			if (_Button20 != null)
			{
				((Control)_Button20).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button_SAVE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_SAVE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_SAVE_Click;
			if (_Button_SAVE != null)
			{
				((Control)_Button_SAVE).Click -= eventHandler;
			}
			_Button_SAVE = value;
			if (_Button_SAVE != null)
			{
				((Control)_Button_SAVE).Click += eventHandler;
			}
		}
	}

	[DebuggerNonUserCode]
	public FormDialog_BLOC_NOTE()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected Obj, but got Unknown
		((Form)this).Load += FormDialog_BLOC_NOTE_Load;
		((Control)this).KeyDown += me_KeyDown;
		__ENCAddToList(this);
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	private static void __ENCAddToList(object value)
	{
		checked
		{
			lock (__ENCList)
			{
				if (__ENCList.Count == __ENCList.Capacity)
				{
					int num = 0;
					int num2 = __ENCList.Count - 1;
					int num3 = 0;
					while (true)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						WeakReference weakReference = __ENCList[num3];
						if (weakReference.IsAlive)
						{
							if (num3 != num)
							{
								__ENCList[num] = __ENCList[num3];
							}
							num++;
						}
						num3++;
					}
					__ENCList.RemoveRange(num, __ENCList.Count - num);
					__ENCList.Capacity = __ENCList.Count;
				}
				__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if ((disposing && components != null) ? true : false)
			{
				components.Dispose();
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected Obj, but got Unknown
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected Obj, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected Obj, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected Obj, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected Obj, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected Obj, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected Obj, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected Obj, but got Unknown
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected Obj, but got Unknown
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Expected Obj, but got Unknown
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Expected Obj, but got Unknown
		//IL_0344: Unknown result type (might be due to invalid IL or missing references)
		//IL_034e: Expected Obj, but got Unknown
		//IL_0452: Unknown result type (might be due to invalid IL or missing references)
		//IL_045c: Expected Obj, but got Unknown
		//IL_04fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0504: Expected Obj, but got Unknown
		//IL_058c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0592: Unknown result type (might be due to invalid IL or missing references)
		//IL_063b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0645: Expected Obj, but got Unknown
		//IL_0670: Unknown result type (might be due to invalid IL or missing references)
		//IL_067a: Expected Obj, but got Unknown
		//IL_06b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_075f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0769: Expected Obj, but got Unknown
		//IL_078c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0796: Expected Obj, but got Unknown
		//IL_07cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_090a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0914: Expected Obj, but got Unknown
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FormDialog_BLOC_NOTE));
		Label_BOTTOM = new Label();
		Label_LEFT = new Label();
		Label_RIGHT = new Label();
		Label_TOP = new Label();
		DataGridView_pied = new DataGridView();
		Column1 = new DataGridViewTextBoxColumn();
		Button20 = new Button();
		Button_SAVE = new Button();
		((ISupportInitialize)DataGridView_pied).BeginInit();
		((Control)this).SuspendLayout();
		((Control)Label_BOTTOM).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label_BOTTOM).Cursor = Cursors.Hand;
		((Control)Label_BOTTOM).Dock = (DockStyle)2;
		((Control)Label_BOTTOM).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label_BOTTOM).ForeColor = Color.White;
		Label label_BOTTOM = Label_BOTTOM;
		Point location = new Point(4, 414);
		((Control)label_BOTTOM).Location = location;
		((Control)Label_BOTTOM).Name = "Label_BOTTOM";
		Label label_BOTTOM2 = Label_BOTTOM;
		Size size = new Size(337, 4);
		((Control)label_BOTTOM2).Size = size;
		((Control)Label_BOTTOM).TabIndex = 988;
		Label_BOTTOM.TextAlign = (ContentAlignment)16;
		((Control)Label_LEFT).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label_LEFT).Cursor = Cursors.Hand;
		((Control)Label_LEFT).Dock = (DockStyle)3;
		((Control)Label_LEFT).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label_LEFT).ForeColor = Color.White;
		Label label_LEFT = Label_LEFT;
		location = new Point(0, 4);
		((Control)label_LEFT).Location = location;
		((Control)Label_LEFT).Name = "Label_LEFT";
		Label label_LEFT2 = Label_LEFT;
		size = new Size(4, 414);
		((Control)label_LEFT2).Size = size;
		((Control)Label_LEFT).TabIndex = 987;
		Label_LEFT.TextAlign = (ContentAlignment)16;
		((Control)Label_RIGHT).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label_RIGHT).Cursor = Cursors.Hand;
		((Control)Label_RIGHT).Dock = (DockStyle)4;
		((Control)Label_RIGHT).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label_RIGHT).ForeColor = Color.White;
		Label label_RIGHT = Label_RIGHT;
		location = new Point(341, 4);
		((Control)label_RIGHT).Location = location;
		((Control)Label_RIGHT).Name = "Label_RIGHT";
		Label label_RIGHT2 = Label_RIGHT;
		size = new Size(4, 414);
		((Control)label_RIGHT2).Size = size;
		((Control)Label_RIGHT).TabIndex = 986;
		Label_RIGHT.TextAlign = (ContentAlignment)16;
		((Control)Label_TOP).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label_TOP).Cursor = Cursors.Hand;
		((Control)Label_TOP).Dock = (DockStyle)1;
		((Control)Label_TOP).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label_TOP).ForeColor = Color.White;
		Label label_TOP = Label_TOP;
		location = new Point(0, 0);
		((Control)label_TOP).Location = location;
		((Control)Label_TOP).Name = "Label_TOP";
		Label label_TOP2 = Label_TOP;
		size = new Size(345, 4);
		((Control)label_TOP2).Size = size;
		((Control)Label_TOP).TabIndex = 985;
		Label_TOP.Text = "-";
		Label_TOP.TextAlign = (ContentAlignment)16;
		DataGridView_pied.AllowUserToResizeColumns = false;
		DataGridView_pied.AllowUserToResizeRows = false;
		DataGridView_pied.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)16;
		DataGridView_pied.BackgroundColor = Color.White;
		DataGridView_pied.CellBorderStyle = (DataGridViewCellBorderStyle)8;
		DataGridView_pied.ColumnHeadersBorderStyle = (DataGridViewHeaderBorderStyle)1;
		val.Alignment = (DataGridViewContentAlignment)16;
		val.BackColor = Color.FromArgb(22, 106, 238);
		val.Font = new Font("Tahoma", 9f, (FontStyle)1);
		val.ForeColor = Color.White;
		val.SelectionBackColor = SystemColors.Highlight;
		val.SelectionForeColor = SystemColors.HighlightText;
		val.WrapMode = (DataGridViewTriState)1;
		DataGridView_pied.ColumnHeadersDefaultCellStyle = val;
		DataGridView_pied.ColumnHeadersHeight = 30;
		DataGridView_pied.ColumnHeadersVisible = false;
		DataGridView_pied.Columns.AddRange(new DataGridViewColumn[1] { (DataGridViewColumn)Column1 });
		val2.Alignment = (DataGridViewContentAlignment)16;
		val2.BackColor = SystemColors.Window;
		val2.Font = new Font("Lucida Console", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val2.ForeColor = SystemColors.ControlText;
		val2.SelectionBackColor = SystemColors.Highlight;
		val2.SelectionForeColor = SystemColors.HighlightText;
		val2.WrapMode = (DataGridViewTriState)2;
		DataGridView_pied.DefaultCellStyle = val2;
		DataGridView_pied.EditMode = (DataGridViewEditMode)0;
		DataGridView_pied.EnableHeadersVisualStyles = false;
		DataGridView_pied.GridColor = SystemColors.ButtonFace;
		DataGridView dataGridView_pied = DataGridView_pied;
		location = new Point(9, 9);
		((Control)dataGridView_pied).Location = location;
		DataGridView dataGridView_pied2 = DataGridView_pied;
		Padding margin = new Padding(0);
		((Control)dataGridView_pied2).Margin = margin;
		((Control)DataGridView_pied).Name = "DataGridView_pied";
		DataGridView_pied.RowHeadersVisible = false;
		DataGridView_pied.RowHeadersWidth = 11;
		DataGridView dataGridView_pied3 = DataGridView_pied;
		size = new Size(326, 341);
		((Control)dataGridView_pied3).Size = size;
		((Control)DataGridView_pied).TabIndex = 995;
		((DataGridViewColumn)Column1).HeaderText = "Column1";
		((DataGridViewColumn)Column1).Name = "Column1";
		((Control)Button20).Cursor = Cursors.Hand;
		((Control)Button20).Font = new Font("Tahoma", 12.25f, (FontStyle)1);
		((Control)Button20).ForeColor = Color.FromArgb(2, 45, 162);
		((ButtonBase)Button20).Image = (Image)componentResourceManager.GetObject("Button20.Image");
		((ButtonBase)Button20).ImageAlign = (ContentAlignment)16;
		Button button = Button20;
		location = new Point(304, 324);
		((Control)button).Location = location;
		Button button2 = Button20;
		margin = new Padding(0);
		((Control)button2).Margin = margin;
		((Control)Button20).Name = "Button20";
		Button button3 = Button20;
		size = new Size(30, 25);
		((Control)button3).Size = size;
		((Control)Button20).TabIndex = 997;
		((ButtonBase)Button20).UseCompatibleTextRendering = true;
		((ButtonBase)Button20).UseVisualStyleBackColor = true;
		((ButtonBase)Button_SAVE).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Button_SAVE).Cursor = Cursors.Hand;
		((ButtonBase)Button_SAVE).FlatStyle = (FlatStyle)0;
		((Control)Button_SAVE).Font = new Font("Tahoma", 11.25f, (FontStyle)1);
		((Control)Button_SAVE).ForeColor = Color.White;
		((ButtonBase)Button_SAVE).Image = (Image)componentResourceManager.GetObject("Button_SAVE.Image");
		((ButtonBase)Button_SAVE).ImageAlign = (ContentAlignment)16;
		Button button_SAVE = Button_SAVE;
		location = new Point(81, 355);
		((Control)button_SAVE).Location = location;
		Button button_SAVE2 = Button_SAVE;
		margin = new Padding(0);
		((Control)button_SAVE2).Margin = margin;
		((Control)Button_SAVE).Name = "Button_SAVE";
		Button button_SAVE3 = Button_SAVE;
		size = new Size(177, 54);
		((Control)button_SAVE3).Size = size;
		((Control)Button_SAVE).TabIndex = 1061;
		((ButtonBase)Button_SAVE).Text = "Enregistrer";
		((ButtonBase)Button_SAVE).UseVisualStyleBackColor = false;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).BackColor = Color.White;
		size = new Size(345, 418);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)Button20);
		((Control)this).Controls.Add((Control)(object)DataGridView_pied);
		((Control)this).Controls.Add((Control)(object)Label_BOTTOM);
		((Control)this).Controls.Add((Control)(object)Label_LEFT);
		((Control)this).Controls.Add((Control)(object)Label_RIGHT);
		((Control)this).Controls.Add((Control)(object)Label_TOP);
		((Control)this).Controls.Add((Control)(object)Button_SAVE);
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Form)this).KeyPreview = true;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "FormDialog_BLOC_NOTE";
		((Form)this).ShowIcon = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((ISupportInitialize)DataGridView_pied).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void me_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Invalid comparison between Unknown and I4
		if ((int)e.KeyCode == 27)
		{
			((Form)this).Close();
		}
	}

	private void FormDialog_BLOC_NOTE_Load(object sender, EventArgs e)
	{
		DataGridView_pied.Rows.Clear();
		string text = "";
		StringReader stringReader = new StringReader(Strings.Trim(MyProject.Forms.Form_0_TEMPLATE.ListView1.Items[MyProject.Forms.Form_0_TEMPLATE.ListView1.FindItemWithText(((Form)this).Text, false, 0).Index].SubItems[1].Text));
		while (stringReader.Peek() != -1)
		{
			DataGridView_pied.Rows.Add(new object[1] { stringReader.ReadLine() });
		}
		stringReader.Close();
	}

	private void Button201_Click(object sender, EventArgs e)
	{
	}

	private void Button20_Click(object sender, EventArgs e)
	{
		try
		{
			DataGridView_pied.Rows.RemoveAt(DataGridView_pied.CurrentCell.RowIndex);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception e2 = ex;
			StackTrace stackTrace = new StackTrace(e2, fNeedFileInfo: true);
			StackFrame frame = stackTrace.GetFrame(checked(stackTrace.FrameCount - 1));
			int fileLineNumber = frame.GetFileLineNumber();
			ProjectData.ClearProjectError();
		}
	}

	private void Button_SAVE_Click(object sender, EventArgs e)
	{
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected Obj, but got Unknown
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			try
			{
				string text = "";
				int num = DataGridView_pied.Rows.Count - 2;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					if (Conversions.ToBoolean(Operators.OrObject(DataGridView_pied.Rows[num2].Cells[0].Value == DBNull.Value, Operators.CompareObjectEqual(DataGridView_pied.Rows[num2].Cells[0].Value, null, TextCompare: false))))
					{
						DataGridView_pied.Rows[num2].Cells[0].Value = " ";
					}
					text = text + DataGridView_pied.Rows[num2].Cells[0].Value.ToString() + "\r\n";
					num2++;
				}
				MySqlCommand val = new MySqlCommand();
				if (Module1.cn_SQL.State != ConnectionState.Open)
				{
					Module1.cn_SQL.Open();
				}
				val.CommandText = "UPDATE     TABLE_PARAMETRES    SET    VALEUR = '" + text + "'     where  OBJET = '" + ((Form)this).Text + "'      ";
				val.Connection = Module1.cn_SQL;
				val.ExecuteNonQuery();
				MyProject.Forms.Form_0_TEMPLATE.ListView1.Items[MyProject.Forms.Form_0_TEMPLATE.ListView1.FindItemWithText(((Form)this).Text, false, 0).Index].SubItems[1].Text = text;
				MessageBox.Show("Modifié avec succès", "ok", (MessageBoxButtons)0, (MessageBoxIcon)64, (MessageBoxDefaultButton)0);
				((Form)this).Close();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				StackTrace stackTrace = new StackTrace(ex2, fNeedFileInfo: true);
				StackFrame frame = stackTrace.GetFrame(stackTrace.FrameCount - 1);
				int fileLineNumber = frame.GetFileLineNumber();
				Interaction.MsgBox(ex2.ToString());
				ProjectData.ClearProjectError();
			}
		}
	}
}
