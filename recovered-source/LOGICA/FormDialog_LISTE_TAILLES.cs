using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using LOGICA.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace LOGICA;

[DesignerGenerated]
public class FormDialog_LISTE_TAILLES : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Button_ADD")]
	private Button _Button_ADD;

	[AccessedThroughProperty("Text_TAILLE")]
	private TextBox _Text_TAILLE;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Text_CODE_TAILLE")]
	private TextBox _Text_CODE_TAILLE;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("DataGridView1")]
	private DataGridView _DataGridView1;

	[AccessedThroughProperty("ID")]
	private DataGridViewTextBoxColumn _ID;

	[AccessedThroughProperty("CODE_TAILLE")]
	private DataGridViewTextBoxColumn _CODE_TAILLE;

	[AccessedThroughProperty("TAILLE")]
	private DataGridViewTextBoxColumn _TAILLE;

	[AccessedThroughProperty("DataGridViewButtonColumn1")]
	private DataGridViewButtonColumn _DataGridViewButtonColumn1;

	private DataTable _DT_TEMP;

	private MySqlDataAdapter _DA_TEMP;

	internal virtual Button Button_ADD
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_ADD;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_ADD_Click;
			if (_Button_ADD != null)
			{
				((Control)_Button_ADD).Click -= eventHandler;
			}
			_Button_ADD = value;
			if (_Button_ADD != null)
			{
				((Control)_Button_ADD).Click += eventHandler;
			}
		}
	}

	internal virtual TextBox Text_TAILLE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_TAILLE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_TAILLE = value;
		}
	}

	internal virtual Label Label2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label2 = value;
		}
	}

	internal virtual TextBox Text_CODE_TAILLE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_CODE_TAILLE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			EventHandler eventHandler = Text_CODE_TAILLE_TextChanged;
			KeyPressEventHandler val = Text_CODE_TAILLE_KeyPress;
			if (_Text_CODE_TAILLE != null)
			{
				((Control)_Text_CODE_TAILLE).TextChanged -= eventHandler;
				((Control)_Text_CODE_TAILLE).KeyPress -= val;
			}
			_Text_CODE_TAILLE = value;
			if (_Text_CODE_TAILLE != null)
			{
				((Control)_Text_CODE_TAILLE).TextChanged += eventHandler;
				((Control)_Text_CODE_TAILLE).KeyPress += val;
			}
		}
	}

	internal virtual Label Label3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label3 = value;
		}
	}

	internal virtual DataGridView DataGridView1
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridView1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			DataGridViewCellPaintingEventHandler val = DataGridView1_CellPainting;
			DataGridViewCellEventHandler val2 = DataGridView1_CellContentClick;
			if (_DataGridView1 != null)
			{
				_DataGridView1.CellPainting -= val;
				_DataGridView1.CellContentClick -= val2;
			}
			_DataGridView1 = value;
			if (_DataGridView1 != null)
			{
				_DataGridView1.CellPainting += val;
				_DataGridView1.CellContentClick += val2;
			}
		}
	}

	internal virtual DataGridViewTextBoxColumn ID
	{
		[DebuggerNonUserCode]
		get
		{
			return _ID;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ID = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn CODE_TAILLE
	{
		[DebuggerNonUserCode]
		get
		{
			return _CODE_TAILLE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CODE_TAILLE = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn TAILLE
	{
		[DebuggerNonUserCode]
		get
		{
			return _TAILLE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TAILLE = value;
		}
	}

	internal virtual DataGridViewButtonColumn DataGridViewButtonColumn1
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridViewButtonColumn1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGridViewButtonColumn1 = value;
		}
	}

	public FormDialog_LISTE_TAILLES()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected Obj, but got Unknown
		((Form)this).Load += Form_ATTRIBUTIONS_Load;
		__ENCAddToList(this);
		_DT_TEMP = new DataTable();
		_DA_TEMP = new MySqlDataAdapter();
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
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected Obj, but got Unknown
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
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected Obj, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected Obj, but got Unknown
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected Obj, but got Unknown
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Expected Obj, but got Unknown
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Expected Obj, but got Unknown
		//IL_0495: Unknown result type (might be due to invalid IL or missing references)
		//IL_049f: Expected Obj, but got Unknown
		//IL_04c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cc: Expected Obj, but got Unknown
		//IL_074c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0756: Expected Obj, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FormDialog_LISTE_TAILLES));
		Text_TAILLE = new TextBox();
		Label2 = new Label();
		Text_CODE_TAILLE = new TextBox();
		Label3 = new Label();
		DataGridView1 = new DataGridView();
		Button_ADD = new Button();
		ID = new DataGridViewTextBoxColumn();
		CODE_TAILLE = new DataGridViewTextBoxColumn();
		TAILLE = new DataGridViewTextBoxColumn();
		DataGridViewButtonColumn1 = new DataGridViewButtonColumn();
		((ISupportInitialize)DataGridView1).BeginInit();
		((Control)this).SuspendLayout();
		((TextBoxBase)Text_TAILLE).BorderStyle = (BorderStyle)1;
		((Control)Text_TAILLE).Font = new Font("Segoe UI", 12f, (FontStyle)1);
		TextBox text_TAILLE = Text_TAILLE;
		Point location = new Point(131, 397);
		((Control)text_TAILLE).Location = location;
		((Control)Text_TAILLE).Name = "Text_TAILLE";
		TextBox text_TAILLE2 = Text_TAILLE;
		Size size = new Size(144, 26);
		((Control)text_TAILLE2).Size = size;
		((Control)Text_TAILLE).TabIndex = 705;
		((Control)Label2).BackColor = Color.WhiteSmoke;
		((Control)Label2).Font = new Font("Segoe UI", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label2).ForeColor = Color.FromArgb(64, 64, 64);
		Label label = Label2;
		location = new Point(12, 397);
		((Control)label).Location = location;
		((Control)Label2).Name = "Label2";
		Label label2 = Label2;
		size = new Size(113, 26);
		((Control)label2).Size = size;
		((Control)Label2).TabIndex = 704;
		Label2.Text = "TAILLE";
		Label2.TextAlign = (ContentAlignment)16;
		((TextBoxBase)Text_CODE_TAILLE).BorderStyle = (BorderStyle)1;
		((Control)Text_CODE_TAILLE).Font = new Font("Segoe UI", 12f, (FontStyle)1);
		TextBox text_CODE_TAILLE = Text_CODE_TAILLE;
		location = new Point(131, 365);
		((Control)text_CODE_TAILLE).Location = location;
		((Control)Text_CODE_TAILLE).Name = "Text_CODE_TAILLE";
		TextBox text_CODE_TAILLE2 = Text_CODE_TAILLE;
		size = new Size(144, 26);
		((Control)text_CODE_TAILLE2).Size = size;
		((Control)Text_CODE_TAILLE).TabIndex = 703;
		((Control)Label3).BackColor = Color.WhiteSmoke;
		((Control)Label3).Font = new Font("Segoe UI", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label3).ForeColor = Color.FromArgb(64, 64, 64);
		Label label3 = Label3;
		location = new Point(12, 365);
		((Control)label3).Location = location;
		((Control)Label3).Name = "Label3";
		Label label4 = Label3;
		size = new Size(113, 26);
		((Control)label4).Size = size;
		((Control)Label3).TabIndex = 702;
		Label3.Text = "CODE_TAILLE";
		Label3.TextAlign = (ContentAlignment)16;
		DataGridView1.AllowUserToAddRows = false;
		DataGridView1.AllowUserToDeleteRows = false;
		DataGridView1.AllowUserToResizeColumns = false;
		DataGridView1.AllowUserToResizeRows = false;
		DataGridView1.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)16;
		DataGridView1.BackgroundColor = Color.White;
		DataGridView1.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		DataGridView1.Columns.AddRange(new DataGridViewColumn[4]
		{
			(DataGridViewColumn)ID,
			(DataGridViewColumn)CODE_TAILLE,
			(DataGridViewColumn)TAILLE,
			(DataGridViewColumn)DataGridViewButtonColumn1
		});
		DataGridView1.EditMode = (DataGridViewEditMode)4;
		DataGridView dataGridView = DataGridView1;
		location = new Point(12, 12);
		((Control)dataGridView).Location = location;
		((Control)DataGridView1).Name = "DataGridView1";
		DataGridView1.RowHeadersVisible = false;
		DataGridView1.RowHeadersWidth = 20;
		DataGridView dataGridView2 = DataGridView1;
		size = new Size(312, 347);
		((Control)dataGridView2).Size = size;
		((Control)DataGridView1).TabIndex = 701;
		((ButtonBase)Button_ADD).BackColor = Color.FromArgb(0, 192, 0);
		((Control)Button_ADD).Cursor = Cursors.Hand;
		((ButtonBase)Button_ADD).FlatStyle = (FlatStyle)0;
		((Control)Button_ADD).Font = new Font("Tahoma", 11.25f, (FontStyle)1);
		((Control)Button_ADD).ForeColor = Color.White;
		((ButtonBase)Button_ADD).Image = (Image)componentResourceManager.GetObject("Button_ADD.Image");
		((ButtonBase)Button_ADD).ImageAlign = (ContentAlignment)16;
		Button button_ADD = Button_ADD;
		location = new Point(281, 365);
		((Control)button_ADD).Location = location;
		((Control)Button_ADD).Name = "Button_ADD";
		Button button_ADD2 = Button_ADD;
		size = new Size(43, 58);
		((Control)button_ADD2).Size = size;
		((Control)Button_ADD).TabIndex = 706;
		((ButtonBase)Button_ADD).UseVisualStyleBackColor = false;
		((DataGridViewColumn)ID).DataPropertyName = "ID";
		((DataGridViewColumn)ID).HeaderText = "ID";
		((DataGridViewColumn)ID).Name = "ID";
		((DataGridViewColumn)ID).Visible = false;
		((DataGridViewColumn)CODE_TAILLE).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)CODE_TAILLE).DataPropertyName = "CODE_TAILLE";
		((DataGridViewColumn)CODE_TAILLE).FillWeight = 99.61929f;
		((DataGridViewColumn)CODE_TAILLE).HeaderText = "CODE_TAILLE";
		((DataGridViewColumn)CODE_TAILLE).Name = "CODE_TAILLE";
		((DataGridViewColumn)CODE_TAILLE).Width = 110;
		((DataGridViewColumn)TAILLE).DataPropertyName = "TAILLE";
		((DataGridViewColumn)TAILLE).FillWeight = 99.61929f;
		((DataGridViewColumn)TAILLE).HeaderText = "TAILLE";
		((DataGridViewColumn)TAILLE).Name = "TAILLE";
		TAILLE.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)DataGridViewButtonColumn1).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)DataGridViewButtonColumn1).HeaderText = "";
		((DataGridViewColumn)DataGridViewButtonColumn1).Name = "DataGridViewButtonColumn1";
		((DataGridViewColumn)DataGridViewButtonColumn1).Resizable = (DataGridViewTriState)1;
		((DataGridViewColumn)DataGridViewButtonColumn1).SortMode = (DataGridViewColumnSortMode)1;
		((DataGridViewColumn)DataGridViewButtonColumn1).Width = 50;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).BackColor = Color.White;
		size = new Size(336, 437);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)Button_ADD);
		((Control)this).Controls.Add((Control)(object)Text_TAILLE);
		((Control)this).Controls.Add((Control)(object)DataGridView1);
		((Control)this).Controls.Add((Control)(object)Label2);
		((Control)this).Controls.Add((Control)(object)Label3);
		((Control)this).Controls.Add((Control)(object)Text_CODE_TAILLE);
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "FormDialog_LISTE_TAILLES";
		((Form)this).ShowIcon = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((ISupportInitialize)DataGridView1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public void _LOAD_DATA()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected Obj, but got Unknown
		MySqlCommand val = new MySqlCommand();
		if (Module1.cn_SQL.State != ConnectionState.Open)
		{
			Module1.cn_SQL.Open();
		}
		val.CommandText = "select     *      from    TABLE_LISTE_TAILLES      order by      CODE_TAILLE  asc          ";
		val.Connection = Module1.cn_SQL;
		MySqlDataReader val2 = val.ExecuteReader();
		DataGridView1.DataSource = null;
		DataGridView1.Rows.Clear();
		if (val2.HasRows)
		{
			while (val2.Read())
			{
				DataGridView1.Rows.Add(new object[3]
				{
					val2["ID"].ToString(),
					val2["CODE_TAILLE"].ToString(),
					val2["TAILLE"].ToString()
				});
			}
		}
		Module1.cn_SQL.Close();
	}

	private void Form_ATTRIBUTIONS_Load(object sender, EventArgs e)
	{
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected Obj, but got Unknown
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected Obj, but got Unknown
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Expected Obj, but got Unknown
		checked
		{
			try
			{
				DataGridView1.AutoGenerateColumns = false;
				DataGridView1.RowTemplate.Height = 35;
				DataGridView1.BackgroundColor = Color.White;
				DataGridView1.SelectionMode = (DataGridViewSelectionMode)1;
				DataGridView1.MultiSelect = false;
				DataGridView1.EditMode = (DataGridViewEditMode)4;
				DataGridView1.GridColor = Color.FromArgb(231, 231, 231);
				DataGridView1.ColumnHeadersBorderStyle = (DataGridViewHeaderBorderStyle)1;
				DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = (DataGridViewContentAlignment)16;
				DataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 11f, (FontStyle)1);
				DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(34, 34, 34);
				DataGridView1.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)0;
				DataGridView1.ColumnHeadersHeight = 30;
				DataGridView1.CellBorderStyle = (DataGridViewCellBorderStyle)5;
				DataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 11f, (FontStyle)0);
				DataGridView1.DefaultCellStyle.ForeColor = Color.FromArgb(34, 34, 34);
				DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(221, 235, 247);
				DataGridView1.RowsDefaultCellStyle.SelectionBackColor = Color.Yellow;
				DataGridView1.RowsDefaultCellStyle.SelectionForeColor = Color.Black;
				DataGridView1.RowHeadersWidth = 22;
				DataGridView1.ClipboardCopyMode = (DataGridViewClipboardCopyMode)0;
				int num = ((BaseCollection)DataGridView1.Columns).Count - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					DataGridView1.Columns[num2].SortMode = (DataGridViewColumnSortMode)2;
					num2++;
				}
				DataGridView1.EnableHeadersVisualStyles = false;
				_LOAD_DATA();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				StackTrace stackTrace = new StackTrace(ex2, fNeedFileInfo: true);
				StackFrame frame = stackTrace.GetFrame(stackTrace.FrameCount - 1);
				int fileLineNumber = frame.GetFileLineNumber();
				Interaction.MsgBox(ex2.Message + "\r\nLigne : " + Conversions.ToString(fileLineNumber) + "\r\n");
				try
				{
					string text = Strings.Format(DateTime.Now, "yyMMddHHmmssfff");
					Bitmap val = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, (PixelFormat)2498570);
					Graphics val2 = Graphics.FromImage((Image)(object)val);
					val2.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, (CopyPixelOperation)13369376);
					((Image)val).Save(Application.StartupPath + "\\tchak\\" + text + ".snidb", ImageFormat.Jpeg);
					val = null;
					string right = "ERROR | ";
					File.AppendAllText(Application.StartupPath + "\\log_erreur.sni", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(text + " | ", MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text), " | "), Module1._USERNAME), " | "), ((Control)this).Name), " | "), NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null)), " | "), right), " | "), ex2.ToString()), "\r\n"), "Ligne : "), fileLineNumber), "\r\n"), "\r\n"), "##########################################################################################################"), "\r\n")), Encoding.UTF8);
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3);
					Exception ex4 = ex3;
					ProjectData.ClearProjectError();
				}
				ProjectData.ClearProjectError();
			}
		}
	}

	private void Button_ADD_Click(object sender, EventArgs e)
	{
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Expected Obj, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected Obj, but got Unknown
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected Obj, but got Unknown
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Expected Obj, but got Unknown
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (Versioned.IsNumeric(Text_CODE_TAILLE.Text))
			{
				Text_CODE_TAILLE.Text = Conversion.Val(Text_CODE_TAILLE.Text).ToString("00");
				if (Operators.CompareString(Text_CODE_TAILLE.Text, "", TextCompare: false) == 0)
				{
					MessageBox.Show("Veuillez remplir le champ -CODE_TAILLE- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
				if (Operators.CompareString(Text_TAILLE.Text, "", TextCompare: false) == 0)
				{
					MessageBox.Show("Veuillez remplir le champ -TAILLE- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
				if (Text_CODE_TAILLE.Text.Length > 2)
				{
					MessageBox.Show("Veuillez remplir le champ -CODE_TAILLE- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
				DataTable dataTable = new DataTable();
				MySqlDataAdapter val = new MySqlDataAdapter();
				dataTable.Clear();
				val = new MySqlDataAdapter("select *     from TABLE_LISTE_TAILLES WHERE   CODE_TAILLE = '" + Text_CODE_TAILLE.Text + "'", Module1.cn_SQL);
				((DbDataAdapter)(object)val).Fill(dataTable);
				if (dataTable.Rows.Count != 0)
				{
					MessageBox.Show("Ce Code est déja utilisé ", "Attetion", (MessageBoxButtons)0, (MessageBoxIcon)48, (MessageBoxDefaultButton)0);
					return;
				}
				MySqlCommand val2 = new MySqlCommand();
				if (Module1.cn_SQL.State != ConnectionState.Open)
				{
					Module1.cn_SQL.Open();
				}
				val2.CommandText = "INSERT  INTO   TABLE_LISTE_TAILLES               ( CODE_TAILLE , TAILLE   )         values           ( '" + Text_CODE_TAILLE.Text + "'   ,'" + Text_TAILLE.Text + "'     )        ";
				val2.Connection = Module1.cn_SQL;
				val2.ExecuteNonQuery();
				Module1.cn_SQL.Close();
				_LOAD_DATA();
				MessageBox.Show("Enregistré avec succès", "ok", (MessageBoxButtons)0, (MessageBoxIcon)64, (MessageBoxDefaultButton)0);
				Text_CODE_TAILLE.Text = "";
				Text_TAILLE.Text = "";
			}
			else
			{
				Interaction.MsgBox("Erreur Code");
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			StackTrace stackTrace = new StackTrace(ex2, fNeedFileInfo: true);
			StackFrame frame = stackTrace.GetFrame(checked(stackTrace.FrameCount - 1));
			int fileLineNumber = frame.GetFileLineNumber();
			Interaction.MsgBox(ex2.Message + "\r\nLigne : " + Conversions.ToString(fileLineNumber) + "\r\n");
			try
			{
				string text = Strings.Format(DateTime.Now, "yyMMddHHmmssfff");
				Bitmap val3 = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, (PixelFormat)2498570);
				Graphics val4 = Graphics.FromImage((Image)(object)val3);
				val4.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, (CopyPixelOperation)13369376);
				((Image)val3).Save(Application.StartupPath + "\\tchak\\" + text + ".snidb", ImageFormat.Jpeg);
				val3 = null;
				string right = "ERROR | ";
				File.AppendAllText(Application.StartupPath + "\\log_erreur.sni", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(text + " | ", MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text), " | "), Module1._USERNAME), " | "), ((Control)this).Name), " | "), NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null)), " | "), right), " | "), ex2.ToString()), "\r\n"), "Ligne : "), fileLineNumber), "\r\n"), "\r\n"), "##########################################################################################################"), "\r\n")), Encoding.UTF8);
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				ProjectData.ClearProjectError();
			}
			ProjectData.ClearProjectError();
		}
	}

	private void DataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
	{
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Expected Obj, but got Unknown
		checked
		{
			try
			{
				if ((Operators.ConditionalCompareObjectEqual(e.ColumnIndex, Operators.SubtractObject(NewLateBinding.LateGet(sender, null, "ColumnCount", new object[0], null, null, null), 1), TextCompare: false) && e.RowIndex >= 0) ? true : false)
				{
					e.Paint(e.CellBounds, (DataGridViewPaintParts)127);
					Image image = MyProject.Forms.Form_0_TEMPLATE.Picture_SUPP.Image;
					int width = image.Width;
					int height = image.Height;
					double a = (double)e.CellBounds.Left + (double)(e.CellBounds.Width - width) / 2.0;
					double a2 = (double)e.CellBounds.Top + (double)(e.CellBounds.Height - width) / 2.0;
					Graphics graphics = e.Graphics;
					Rectangle rectangle = new Rectangle((int)Math.Round(a), (int)Math.Round(a2), width, height);
					graphics.DrawImage(image, rectangle);
					((HandledEventArgs)(object)e).Handled = true;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				StackTrace stackTrace = new StackTrace(ex2, fNeedFileInfo: true);
				StackFrame frame = stackTrace.GetFrame(stackTrace.FrameCount - 1);
				int fileLineNumber = frame.GetFileLineNumber();
				Interaction.MsgBox(ex2.Message + "\r\nLigne : " + Conversions.ToString(fileLineNumber) + "\r\n");
				try
				{
					string text = Strings.Format(DateTime.Now, "yyMMddHHmmssfff");
					Bitmap val = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, (PixelFormat)2498570);
					Graphics val2 = Graphics.FromImage((Image)(object)val);
					val2.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, (CopyPixelOperation)13369376);
					((Image)val).Save(Application.StartupPath + "\\tchak\\" + text + ".snidb", ImageFormat.Jpeg);
					val = null;
					string right = "ERROR | ";
					File.AppendAllText(Application.StartupPath + "\\log_erreur.sni", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(text + " | ", MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text), " | "), Module1._USERNAME), " | "), ((Control)this).Name), " | "), NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null)), " | "), right), " | "), ex2.ToString()), "\r\n"), "Ligne : "), fileLineNumber), "\r\n"), "\r\n"), "##########################################################################################################"), "\r\n")), Encoding.UTF8);
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3);
					Exception ex4 = ex3;
					ProjectData.ClearProjectError();
				}
				ProjectData.ClearProjectError();
			}
		}
	}

	private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Expected Obj, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Invalid comparison between Unknown and I4
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected Obj, but got Unknown
		try
		{
			if (((Operators.ConditionalCompareObjectEqual(e.ColumnIndex, Operators.SubtractObject(NewLateBinding.LateGet(sender, null, "ColumnCount", new object[0], null, null, null), 1), TextCompare: false) && e.RowIndex >= 0) ? true : false) && (int)MessageBox.Show("Voulez-vous vraiment supprimer ??", "Suppression", (MessageBoxButtons)1, (MessageBoxIcon)32, (MessageBoxDefaultButton)0) == 1)
			{
				MySqlCommand val = new MySqlCommand();
				if (Module1.cn_SQL.State != ConnectionState.Open)
				{
					Module1.cn_SQL.Open();
				}
				val.CommandText = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("Delete    from  TABLE_LISTE_TAILLES      WHERE     ID  = ", DataGridView1.Rows[((DataGridViewBand)DataGridView1.CurrentRow).Index].Cells["ID"].Value), "         "));
				val.Connection = Module1.cn_SQL;
				val.ExecuteNonQuery();
				Module1.cn_SQL.Close();
				_LOAD_DATA();
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			StackTrace stackTrace = new StackTrace(ex2, fNeedFileInfo: true);
			StackFrame frame = stackTrace.GetFrame(checked(stackTrace.FrameCount - 1));
			int fileLineNumber = frame.GetFileLineNumber();
			Interaction.MsgBox(ex2.Message + "\r\nLigne : " + Conversions.ToString(fileLineNumber) + "\r\n");
			try
			{
				string text = Strings.Format(DateTime.Now, "yyMMddHHmmssfff");
				Bitmap val2 = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, (PixelFormat)2498570);
				Graphics val3 = Graphics.FromImage((Image)(object)val2);
				val3.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, (CopyPixelOperation)13369376);
				((Image)val2).Save(Application.StartupPath + "\\tchak\\" + text + ".snidb", ImageFormat.Jpeg);
				val2 = null;
				string right = "ERROR | ";
				File.AppendAllText(Application.StartupPath + "\\log_erreur.sni", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(text + " | ", MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text), " | "), Module1._USERNAME), " | "), ((Control)this).Name), " | "), NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null)), " | "), right), " | "), ex2.ToString()), "\r\n"), "Ligne : "), fileLineNumber), "\r\n"), "\r\n"), "##########################################################################################################"), "\r\n")), Encoding.UTF8);
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				ProjectData.ClearProjectError();
			}
			ProjectData.ClearProjectError();
		}
	}

	private void Text_CODE_TAILLE_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (((Operators.CompareString(Conversions.ToString(e.KeyChar), "0", TextCompare: false) < 0) | (Operators.CompareString(Conversions.ToString(e.KeyChar), "9", TextCompare: false) > 0)) & (e.KeyChar != '\b') & (e.KeyChar != '.') & (e.KeyChar != '-'))
		{
			e.Handled = true;
		}
	}

	private void Text_CODE_TAILLE_TextChanged(object sender, EventArgs e)
	{
	}
}
