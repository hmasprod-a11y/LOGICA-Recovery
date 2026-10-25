using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ClosedXML.Excel;
using LOGICA.My;
using Microsoft.Reporting.WinForms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace LOGICA;

[DesignerGenerated]
public class FormDialog_ETAT_ALERTES_STOCK : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Label_TABLE")]
	private Label _Label_TABLE;

	[AccessedThroughProperty("DataGridView1")]
	private DataGridView _DataGridView1;

	[AccessedThroughProperty("Label18")]
	private Label _Label18;

	[AccessedThroughProperty("Label_ALERTS_STOCK")]
	private Label _Label_ALERTS_STOCK;

	[AccessedThroughProperty("Label71")]
	private Label _Label71;

	[AccessedThroughProperty("Label_STOCK_NEGATIF")]
	private Label _Label_STOCK_NEGATIF;

	[AccessedThroughProperty("Button_CALC")]
	private Button _Button_CALC;

	[AccessedThroughProperty("ID_ARTICLE")]
	private DataGridViewTextBoxColumn _ID_ARTICLE;

	[AccessedThroughProperty("Code")]
	private DataGridViewTextBoxColumn _Code;

	[AccessedThroughProperty("Article")]
	private DataGridViewTextBoxColumn _Article;

	[AccessedThroughProperty("Famille")]
	private DataGridViewTextBoxColumn _Famille;

	[AccessedThroughProperty("STOCK_ACTUEL")]
	private DataGridViewTextBoxColumn _STOCK_ACTUEL;

	[AccessedThroughProperty("Alert")]
	private DataGridViewTextBoxColumn _Alert;

	private DataTable _DT_TEMP;

	private MySqlDataAdapter _DA_TEMP;

	private DataTable _DT_FAMILLE_FILTRAGE;

	private MySqlDataAdapter _DA_FAMILLE_FILTRAGE;

	internal virtual Label Label_TABLE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_TABLE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_TABLE = value;
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
			_DataGridView1 = value;
		}
	}

	internal virtual Label Label18
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label18;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label18 = value;
		}
	}

	internal virtual Label Label_ALERTS_STOCK
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_ALERTS_STOCK;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Label_ALERTS_Click;
			if (_Label_ALERTS_STOCK != null)
			{
				((Control)_Label_ALERTS_STOCK).Click -= eventHandler;
			}
			_Label_ALERTS_STOCK = value;
			if (_Label_ALERTS_STOCK != null)
			{
				((Control)_Label_ALERTS_STOCK).Click += eventHandler;
			}
		}
	}

	internal virtual Label Label71
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label71;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label71 = value;
		}
	}

	internal virtual Label Label_STOCK_NEGATIF
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_STOCK_NEGATIF;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Label_STOCK_NEGATIF_Click;
			if (_Label_STOCK_NEGATIF != null)
			{
				((Control)_Label_STOCK_NEGATIF).Click -= eventHandler;
			}
			_Label_STOCK_NEGATIF = value;
			if (_Label_STOCK_NEGATIF != null)
			{
				((Control)_Label_STOCK_NEGATIF).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button_CALC
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_CALC;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_CALC_Click;
			if (_Button_CALC != null)
			{
				((Control)_Button_CALC).Click -= eventHandler;
			}
			_Button_CALC = value;
			if (_Button_CALC != null)
			{
				((Control)_Button_CALC).Click += eventHandler;
			}
		}
	}

	internal virtual DataGridViewTextBoxColumn ID_ARTICLE
	{
		[DebuggerNonUserCode]
		get
		{
			return _ID_ARTICLE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ID_ARTICLE = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Code
	{
		[DebuggerNonUserCode]
		get
		{
			return _Code;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Code = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Article
	{
		[DebuggerNonUserCode]
		get
		{
			return _Article;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Article = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Famille
	{
		[DebuggerNonUserCode]
		get
		{
			return _Famille;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Famille = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn STOCK_ACTUEL
	{
		[DebuggerNonUserCode]
		get
		{
			return _STOCK_ACTUEL;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_STOCK_ACTUEL = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Alert
	{
		[DebuggerNonUserCode]
		get
		{
			return _Alert;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Alert = value;
		}
	}

	public FormDialog_ETAT_ALERTES_STOCK()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected Obj, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected Obj, but got Unknown
		((Form)this).Load += FormDialog_MODE_STOCK_Load;
		((Control)this).KeyDown += me_KeyDown;
		__ENCAddToList(this);
		_DT_TEMP = new DataTable();
		_DA_TEMP = new MySqlDataAdapter();
		_DT_FAMILLE_FILTRAGE = new DataTable();
		_DA_FAMILLE_FILTRAGE = new MySqlDataAdapter();
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
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected Obj, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected Obj, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected Obj, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected Obj, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected Obj, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected Obj, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected Obj, but got Unknown
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected Obj, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected Obj, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected Obj, but got Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected Obj, but got Unknown
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected Obj, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected Obj, but got Unknown
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected Obj, but got Unknown
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Expected Obj, but got Unknown
		//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Expected Obj, but got Unknown
		//IL_0400: Unknown result type (might be due to invalid IL or missing references)
		//IL_040a: Expected Obj, but got Unknown
		//IL_04e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04eb: Expected Obj, but got Unknown
		//IL_05c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cb: Expected Obj, but got Unknown
		//IL_06a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ac: Expected Obj, but got Unknown
		//IL_0b1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b25: Expected Obj, but got Unknown
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		DataGridViewCellStyle val3 = new DataGridViewCellStyle();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FormDialog_ETAT_ALERTES_STOCK));
		Label_TABLE = new Label();
		DataGridView1 = new DataGridView();
		Label18 = new Label();
		Label_ALERTS_STOCK = new Label();
		Label71 = new Label();
		Label_STOCK_NEGATIF = new Label();
		Button_CALC = new Button();
		ID_ARTICLE = new DataGridViewTextBoxColumn();
		Code = new DataGridViewTextBoxColumn();
		Article = new DataGridViewTextBoxColumn();
		Famille = new DataGridViewTextBoxColumn();
		STOCK_ACTUEL = new DataGridViewTextBoxColumn();
		Alert = new DataGridViewTextBoxColumn();
		((ISupportInitialize)DataGridView1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)Label_TABLE).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label_TABLE).Dock = (DockStyle)1;
		((Control)Label_TABLE).Font = new Font("Tahoma", 9f, (FontStyle)1);
		((Control)Label_TABLE).ForeColor = Color.White;
		Label label_TABLE = Label_TABLE;
		Point location = new Point(0, 0);
		((Control)label_TABLE).Location = location;
		((Control)Label_TABLE).Name = "Label_TABLE";
		Label label_TABLE2 = Label_TABLE;
		Size size = new Size(849, 30);
		((Control)label_TABLE2).Size = size;
		((Control)Label_TABLE).TabIndex = 1037;
		Label_TABLE.Text = "ALERTES STOCK";
		Label_TABLE.TextAlign = (ContentAlignment)16;
		DataGridView1.AllowUserToAddRows = false;
		DataGridView1.AllowUserToDeleteRows = false;
		DataGridView1.AllowUserToResizeColumns = false;
		DataGridView1.AllowUserToResizeRows = false;
		((Control)DataGridView1).Anchor = (AnchorStyles)15;
		DataGridView1.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)16;
		DataGridView1.BackgroundColor = Color.White;
		DataGridView1.BorderStyle = (BorderStyle)2;
		val.Alignment = (DataGridViewContentAlignment)16;
		val.BackColor = SystemColors.Control;
		val.Font = new Font("Calibri", 11f, (FontStyle)1);
		val.ForeColor = SystemColors.WindowText;
		val.SelectionBackColor = SystemColors.Highlight;
		val.SelectionForeColor = SystemColors.HighlightText;
		val.WrapMode = (DataGridViewTriState)1;
		DataGridView1.ColumnHeadersDefaultCellStyle = val;
		DataGridView1.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		DataGridView1.Columns.AddRange(new DataGridViewColumn[6]
		{
			(DataGridViewColumn)ID_ARTICLE,
			(DataGridViewColumn)Code,
			(DataGridViewColumn)Article,
			(DataGridViewColumn)Famille,
			(DataGridViewColumn)STOCK_ACTUEL,
			(DataGridViewColumn)Alert
		});
		val2.Alignment = (DataGridViewContentAlignment)16;
		val2.BackColor = SystemColors.Window;
		val2.Font = new Font("Arial Narrow", 15.75f);
		val2.ForeColor = SystemColors.ControlText;
		val2.SelectionBackColor = SystemColors.Highlight;
		val2.SelectionForeColor = SystemColors.HighlightText;
		val2.WrapMode = (DataGridViewTriState)2;
		DataGridView1.DefaultCellStyle = val2;
		DataGridView1.EditMode = (DataGridViewEditMode)4;
		DataGridView dataGridView = DataGridView1;
		location = new Point(1, 92);
		((Control)dataGridView).Location = location;
		((Control)DataGridView1).Name = "DataGridView1";
		DataGridView1.RowHeadersVisible = false;
		DataGridView1.RowHeadersWidth = 20;
		DataGridView dataGridView2 = DataGridView1;
		size = new Size(846, 470);
		((Control)dataGridView2).Size = size;
		((Control)DataGridView1).TabIndex = 1040;
		((Control)Label18).Anchor = (AnchorStyles)1;
		((Control)Label18).BackColor = Color.Transparent;
		((Control)Label18).Cursor = Cursors.Default;
		((Control)Label18).Font = new Font("Segoe UI", 8f, (FontStyle)1);
		((Control)Label18).ForeColor = Color.Black;
		Label18.ImeMode = (ImeMode)0;
		Label label = Label18;
		location = new Point(347, 55);
		((Control)label).Location = location;
		((Control)Label18).Name = "Label18";
		Label label2 = Label18;
		size = new Size(74, 29);
		((Control)label2).Size = size;
		((Control)Label18).TabIndex = 1041;
		Label18.Text = "Alerts Stock";
		Label18.TextAlign = (ContentAlignment)32;
		((Control)Label_ALERTS_STOCK).Anchor = (AnchorStyles)1;
		((Control)Label_ALERTS_STOCK).BackColor = Color.Transparent;
		((Control)Label_ALERTS_STOCK).Cursor = Cursors.Hand;
		((Control)Label_ALERTS_STOCK).Font = new Font("Segoe UI", 12f, (FontStyle)1);
		((Control)Label_ALERTS_STOCK).ForeColor = Color.Black;
		Label_ALERTS_STOCK.ImeMode = (ImeMode)0;
		Label label_ALERTS_STOCK = Label_ALERTS_STOCK;
		location = new Point(347, 37);
		((Control)label_ALERTS_STOCK).Location = location;
		((Control)Label_ALERTS_STOCK).Name = "Label_ALERTS_STOCK";
		Label label_ALERTS_STOCK2 = Label_ALERTS_STOCK;
		size = new Size(74, 20);
		((Control)label_ALERTS_STOCK2).Size = size;
		((Control)Label_ALERTS_STOCK).TabIndex = 1042;
		Label_ALERTS_STOCK.Text = "00";
		Label_ALERTS_STOCK.TextAlign = (ContentAlignment)2;
		((Control)Label71).Anchor = (AnchorStyles)1;
		((Control)Label71).BackColor = Color.Transparent;
		((Control)Label71).Cursor = Cursors.Default;
		((Control)Label71).Font = new Font("Segoe UI", 8f, (FontStyle)1);
		((Control)Label71).ForeColor = Color.Black;
		Label71.ImeMode = (ImeMode)0;
		Label label3 = Label71;
		location = new Point(427, 55);
		((Control)label3).Location = location;
		((Control)Label71).Name = "Label71";
		Label label4 = Label71;
		size = new Size(74, 29);
		((Control)label4).Size = size;
		((Control)Label71).TabIndex = 1043;
		Label71.Text = "Stock Négatif";
		Label71.TextAlign = (ContentAlignment)32;
		((Control)Label_STOCK_NEGATIF).Anchor = (AnchorStyles)1;
		((Control)Label_STOCK_NEGATIF).BackColor = Color.Transparent;
		((Control)Label_STOCK_NEGATIF).Cursor = Cursors.Hand;
		((Control)Label_STOCK_NEGATIF).Font = new Font("Segoe UI", 12f, (FontStyle)1);
		((Control)Label_STOCK_NEGATIF).ForeColor = Color.Black;
		Label_STOCK_NEGATIF.ImeMode = (ImeMode)0;
		Label label_STOCK_NEGATIF = Label_STOCK_NEGATIF;
		location = new Point(427, 37);
		((Control)label_STOCK_NEGATIF).Location = location;
		((Control)Label_STOCK_NEGATIF).Name = "Label_STOCK_NEGATIF";
		Label label_STOCK_NEGATIF2 = Label_STOCK_NEGATIF;
		size = new Size(74, 20);
		((Control)label_STOCK_NEGATIF2).Size = size;
		((Control)Label_STOCK_NEGATIF).TabIndex = 1044;
		Label_STOCK_NEGATIF.Text = "00";
		Label_STOCK_NEGATIF.TextAlign = (ContentAlignment)2;
		((Control)Button_CALC).ForeColor = Color.Red;
		((ButtonBase)Button_CALC).ImeMode = (ImeMode)0;
		Button button_CALC = Button_CALC;
		location = new Point(570, 37);
		((Control)button_CALC).Location = location;
		((Control)Button_CALC).Name = "Button_CALC";
		Button button_CALC2 = Button_CALC;
		size = new Size(83, 30);
		((Control)button_CALC2).Size = size;
		((Control)Button_CALC).TabIndex = 1045;
		((ButtonBase)Button_CALC).Text = "Button_CALC";
		((ButtonBase)Button_CALC).UseVisualStyleBackColor = true;
		((Control)Button_CALC).Visible = false;
		((DataGridViewColumn)ID_ARTICLE).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)ID_ARTICLE).DataPropertyName = "ID_ARTICLE";
		((DataGridViewColumn)ID_ARTICLE).HeaderText = "ID_ARTICLE";
		((DataGridViewColumn)ID_ARTICLE).Name = "ID_ARTICLE";
		((DataGridViewColumn)ID_ARTICLE).Visible = false;
		((DataGridViewColumn)Code).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)Code).DataPropertyName = "Code";
		((DataGridViewColumn)Code).FillWeight = 426.3959f;
		((DataGridViewColumn)Code).HeaderText = "Code";
		((DataGridViewColumn)Code).Name = "Code";
		((DataGridViewColumn)Code).Width = 120;
		((DataGridViewColumn)Article).DataPropertyName = "Article";
		val3.NullValue = null;
		((DataGridViewColumn)Article).DefaultCellStyle = val3;
		((DataGridViewColumn)Article).FillWeight = 45.60068f;
		((DataGridViewColumn)Article).HeaderText = "Article";
		((DataGridViewColumn)Article).MinimumWidth = 200;
		((DataGridViewColumn)Article).Name = "Article";
		Article.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)Famille).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)Famille).DataPropertyName = "Famille";
		((DataGridViewColumn)Famille).FillWeight = 45.60068f;
		((DataGridViewColumn)Famille).HeaderText = "Famille";
		((DataGridViewColumn)Famille).Name = "Famille";
		Famille.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)Famille).Width = 120;
		((DataGridViewColumn)STOCK_ACTUEL).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)STOCK_ACTUEL).DataPropertyName = "STOCK";
		((DataGridViewColumn)STOCK_ACTUEL).HeaderText = "STOCK ACTUEL";
		((DataGridViewColumn)STOCK_ACTUEL).Name = "STOCK_ACTUEL";
		STOCK_ACTUEL.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)STOCK_ACTUEL).Width = 80;
		((DataGridViewColumn)Alert).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)Alert).DataPropertyName = "Alert";
		((DataGridViewColumn)Alert).FillWeight = 45.60068f;
		((DataGridViewColumn)Alert).HeaderText = "Alert";
		((DataGridViewColumn)Alert).MinimumWidth = 2;
		((DataGridViewColumn)Alert).Name = "Alert";
		Alert.SortMode = (DataGridViewColumnSortMode)2;
		((DataGridViewColumn)Alert).Width = 50;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).BackColor = Color.White;
		size = new Size(849, 563);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)Button_CALC);
		((Control)this).Controls.Add((Control)(object)Label18);
		((Control)this).Controls.Add((Control)(object)Label_ALERTS_STOCK);
		((Control)this).Controls.Add((Control)(object)Label71);
		((Control)this).Controls.Add((Control)(object)Label_STOCK_NEGATIF);
		((Control)this).Controls.Add((Control)(object)DataGridView1);
		((Control)this).Controls.Add((Control)(object)Label_TABLE);
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Form)this).KeyPreview = true;
		((Control)this).Name = "FormDialog_ALERTES_STOCK";
		((Form)this).StartPosition = (FormStartPosition)1;
		((ISupportInitialize)DataGridView1).EndInit();
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

	private void FormDialog_MODE_STOCK_Load(object sender, EventArgs e)
	{
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected Obj, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected Obj, but got Unknown
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Expected Obj, but got Unknown
		checked
		{
			try
			{
				DataGridView1.AutoGenerateColumns = false;
				DataGridView1.RowTemplate.Height = 15;
				DataGridView1.DataSource = _DT_TEMP;
				DataGridView1.BackgroundColor = Color.White;
				DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(34, 34, 34);
				DataGridView1.DefaultCellStyle.SelectionBackColor = Color.Yellow;
				DataGridView1.DefaultCellStyle.SelectionForeColor = Color.Red;
				DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(221, 235, 247);
				DataGridView1.GridColor = Color.FromArgb(231, 231, 231);
				DataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11f, (FontStyle)1);
				DataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 9f, (FontStyle)0);
				DataGridView1.ColumnHeadersBorderStyle = (DataGridViewHeaderBorderStyle)1;
				DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = (DataGridViewContentAlignment)16;
				DataGridView1.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)0;
				DataGridView1.AutoResizeColumnHeadersHeight();
				DataGridView1.CellBorderStyle = (DataGridViewCellBorderStyle)5;
				DataGridView1.SelectionMode = (DataGridViewSelectionMode)1;
				DataGridView1.MultiSelect = true;
				DataGridView1.EditMode = (DataGridViewEditMode)4;
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
				DataGridView1.AllowUserToAddRows = false;
				DataGridView1.AllowUserToDeleteRows = false;
				DataGridView1.AllowUserToOrderColumns = true;
				DataGridView1.AllowUserToResizeColumns = true;
				DataGridView1.AllowUserToResizeRows = false;
				Button_CALC_Click(RuntimeHelpers.GetObjectValue(sender), e);
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

	private void Print_ETAT_STOCK_PrintPage(object sender, PrintPageEventArgs e)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected Obj, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected Obj, but got Unknown
		//IL_008d: Expected Obj, but got Unknown
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected Obj, but got Unknown
		//IL_00e0: Expected Obj, but got Unknown
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Expected Obj, but got Unknown
		//IL_011a: Expected Obj, but got Unknown
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected Obj, but got Unknown
		//IL_0154: Expected Obj, but got Unknown
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Expected Obj, but got Unknown
		//IL_018e: Expected Obj, but got Unknown
		//IL_044d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0454: Expected Obj, but got Unknown
		//IL_031c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0335: Unknown result type (might be due to invalid IL or missing references)
		//IL_033f: Expected Obj, but got Unknown
		//IL_033f: Expected Obj, but got Unknown
		//IL_0352: Unknown result type (might be due to invalid IL or missing references)
		//IL_036b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Expected Obj, but got Unknown
		//IL_0375: Expected Obj, but got Unknown
		//IL_0389: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ac: Expected Obj, but got Unknown
		//IL_03ac: Expected Obj, but got Unknown
		checked
		{
			try
			{
				e.Graphics.FillRectangle((Brush)new SolidBrush(Color.Silver), 0, 0, 300, 15);
				string text = "ETAT STOCK";
				e.Graphics.DrawString(text, new Font("Lucida Console", 10f, (FontStyle)1), Brushes.Black, Convert.ToSingle(130f - e.Graphics.MeasureString(text, new Font("Lucida Console", 10f, (FontStyle)1)).Width / 2f), 0f, new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("Rapport :" + Strings.Format(DateTime.Now, "dd/MM/yyyy"), new Font("Lucida Console", 6.4f, (FontStyle)0), Brushes.Black, 0f, 95f, new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("---------------------------------------------------------------------", new Font("Lucida Console", 8f, (FontStyle)0), Brushes.Black, 0f, 100f, new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("Article               STOCK       ALERT  ", new Font("Lucida Console", 7f, (FontStyle)1), Brushes.Black, 0f, 110f, new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("---------------------------------------------------------------------", new Font("Lucida Console", 8f, (FontStyle)0), Brushes.Black, 0f, 120f, new StringFormat((StringFormatFlags)8192));
				int num = 0;
				string text2 = "";
				string text3 = "";
				string text4 = "";
				int num2 = DataGridView1.RowCount - 1;
				num = 0;
				while (true)
				{
					int num3 = num;
					int num4 = num2;
					if (num3 > num4)
					{
						break;
					}
					text2 = text2 + Strings.LSet(DataGridView1.Rows[num].Cells["Article"].Value.ToString(), 22) + "|" + Environment.NewLine + Environment.NewLine;
					text3 = text3 + Strings.RSet(DataGridView1.Rows[num].Cells["STOCK_ACTUEL"].Value.ToString(), 6) + "|" + Environment.NewLine + Environment.NewLine;
					text4 = text4 + Strings.RSet(DataGridView1.Rows[num].Cells["ALERT"].Value.ToString(), 12) + "|" + Environment.NewLine + Environment.NewLine;
					num++;
				}
				e.Graphics.DrawString(text2, new Font("Lucida Console", 7f, (FontStyle)0), Brushes.Black, 0f, 130f, new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString(text3, new Font("Lucida Console", 7f, (FontStyle)0), Brushes.Black, 140f, 130f, new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString(text4, new Font("Lucida Console", 7f, (FontStyle)0), Brushes.Black, 185f, 130f, new StringFormat((StringFormatFlags)8192));
				Module1._QUITTER_PATIENTER = true;
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
					string text5 = Strings.Format(DateTime.Now, "yyMMddHHmmssfff");
					Bitmap val = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, (PixelFormat)2498570);
					Graphics val2 = Graphics.FromImage((Image)(object)val);
					val2.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, (CopyPixelOperation)13369376);
					((Image)val).Save(Application.StartupPath + "\\tchak\\" + text5 + ".snidb", ImageFormat.Jpeg);
					val = null;
					string right = "ERROR | ";
					File.AppendAllText(Application.StartupPath + "\\log_erreur.sni", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(text5 + " | ", MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text), " | "), Module1._USERNAME), " | "), ((Control)this).Name), " | "), NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null)), " | "), right), " | "), ex2.ToString()), "\r\n"), "Ligne : "), fileLineNumber), "\r\n"), "\r\n"), "##########################################################################################################"), "\r\n")), Encoding.UTF8);
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

	private void Button_ConsRapport_Click(object sender, EventArgs e)
	{
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Expected Obj, but got Unknown
		if (DataGridView1.Rows.Count == 0)
		{
			NewLateBinding.LateSet(sender, null, "Enabled", new object[1] { true }, null, null);
			return;
		}
		checked
		{
			try
			{
				Thread thread = new Thread([SpecialName] () =>
				{
					//IL_0009: Unknown result type (might be due to invalid IL or missing references)
					try
					{
						FormDialog_PATIENTER formDialog_PATIENTER = new FormDialog_PATIENTER();
						((Form)formDialog_PATIENTER).ShowDialog();
					}
					catch (Exception ex3)
					{
						ProjectData.SetProjectError(ex3);
						Exception e2 = ex3;
						StackTrace stackTrace2 = new StackTrace(e2, fNeedFileInfo: true);
						StackFrame frame2 = stackTrace2.GetFrame(stackTrace2.FrameCount - 1);
						int fileLineNumber2 = frame2.GetFileLineNumber();
						ProjectData.ClearProjectError();
					}
					Thread.Sleep(100);
				});
				thread.SetApartmentState(ApartmentState.STA);
				thread.IsBackground = true;
				thread.Start();
				DataTable dataTable = new DataTable();
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
					dataTable.Columns.Add(DataGridView1.Columns[num2].Name.ToString());
					dataTable.Columns[DataGridView1.Columns[num2].Name.ToString()].Caption = DataGridView1.Columns[num2].HeaderText.ToString();
					num2++;
				}
				int num5 = DataGridView1.Rows.Count - 1;
				int num6 = 0;
				while (true)
				{
					int num7 = num6;
					int num4 = num5;
					if (num7 > num4)
					{
						break;
					}
					dataTable.Rows.Add();
					int num8 = ((BaseCollection)DataGridView1.Columns).Count - 1;
					int num9 = 0;
					while (true)
					{
						int num10 = num9;
						num4 = num8;
						if (num10 > num4)
						{
							break;
						}
						if (DataGridView1.Rows[num6].Cells[num9].Value == DBNull.Value)
						{
							dataTable.Rows[num6][num9] = " ";
						}
						else
						{
							dataTable.Rows[num6][num9] = RuntimeHelpers.GetObjectValue(DataGridView1.Rows[num6].Cells[num9].Value);
						}
						num9++;
					}
					num6++;
				}
				ReportDataSource item = new ReportDataSource("DataSet1", dataTable);
				((Collection<ReportDataSource>)(object)MyProject.Forms.Report_ETAT_STOCK.ReportViewer1.LocalReport.DataSources).Clear();
				((Collection<ReportDataSource>)(object)MyProject.Forms.Report_ETAT_STOCK.ReportViewer1.LocalReport.DataSources).Add(item);
				MyProject.Forms.Report_ETAT_STOCK.ReportViewer1.RefreshReport();
				MyProject.Forms.Report_ETAT_STOCK.ReportViewer1.SetDisplayMode((DisplayMode)1);
				MyProject.Forms.Report_ETAT_STOCK.ReportViewer1.ZoomMode = (ZoomMode)2;
				MyProject.Forms.Report_ETAT_STOCK.ReportViewer1.ZoomPercent = 25;
				((Control)MyProject.Forms.Report_ETAT_STOCK).Show();
				Module1._QUITTER_PATIENTER = true;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				StackTrace stackTrace = new StackTrace(ex2, fNeedFileInfo: true);
				StackFrame frame = stackTrace.GetFrame(stackTrace.FrameCount - 1);
				int fileLineNumber = frame.GetFileLineNumber();
				Interaction.MsgBox(ex2.ToString());
				Module1._QUITTER_PATIENTER = true;
				ProjectData.ClearProjectError();
			}
		}
	}

	private void Button14_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected Obj, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Invalid comparison between Unknown and I4
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected Obj, but got Unknown
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected Obj, but got Unknown
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Expected Obj, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected Obj, but got Unknown
		try
		{
			SaveFileDialog val = new SaveFileDialog();
			((FileDialog)val).Filter = "Text Files (*.xlsx)|*.xlsx";
			((FileDialog)val).FileName = Label_TABLE.Text + "_" + DateTime.Now.ToString("dd-MM-yyy HH-mm-ss");
			if ((int)((CommonDialog)val).ShowDialog() != 1)
			{
				return;
			}
			DataTable dataTable = new DataTable();
			foreach (DataGridViewColumn item in (BaseCollection)DataGridView1.Columns)
			{
				DataGridViewColumn val2 = item;
				val2.ValueType = Type.GetType("System.String");
				if ((object)((object)val2).GetType() == typeof(DataGridViewTextBoxColumn))
				{
					dataTable.Columns.Add(val2.HeaderText, val2.ValueType);
				}
			}
			foreach (DataGridViewRow item2 in (IEnumerable)DataGridView1.Rows)
			{
				DataGridViewRow val3 = item2;
				dataTable.Rows.Add();
				foreach (DataGridViewCell item3 in (BaseCollection)val3.Cells)
				{
					DataGridViewCell val4 = item3;
					if ((object)((object)val4).GetType() == typeof(DataGridViewTextBoxCell))
					{
						if (val4.Value == null)
						{
							val4.Value = "-";
						}
						dataTable.Rows[checked(dataTable.Rows.Count - 1)][val4.ColumnIndex] = val4.Value.ToString();
					}
				}
			}
			XLWorkbook val5 = new XLWorkbook();
			try
			{
				val5.Worksheets.Add(dataTable, "Table");
				val5.SaveAs(((FileDialog)val).FileName + ".xlsx");
			}
			finally
			{
				((IDisposable)val5)?.Dispose();
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			StackTrace stackTrace = new StackTrace(ex2, fNeedFileInfo: true);
			StackFrame frame = stackTrace.GetFrame(checked(stackTrace.FrameCount - 1));
			int fileLineNumber = frame.GetFileLineNumber();
			Interaction.MsgBox(ex2.ToString());
			ProjectData.ClearProjectError();
		}
	}

	private void Button_CALC_Click(object sender, EventArgs e)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected Obj, but got Unknown
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Expected Obj, but got Unknown
		try
		{
			string text = "select    count(ID)  as N   from  TABLE_ARTICLES    WHERE       STOCK    <=  Alert   and   STOCK <> 0   and    (MODE_STOCK  = 'FINI'  or MODE_STOCK  = 'MATIERE PREMIERE')  ";
			string text2 = "select    count(ID)  as N   from  TABLE_ARTICLES    WHERE       STOCK    < 0   and    (MODE_STOCK  = 'FINI'  or MODE_STOCK  = 'MATIERE PREMIERE')  ";
			DataTable dataTable = new DataTable();
			MySqlDataAdapter val = new MySqlDataAdapter();
			dataTable.Clear();
			dataTable = new DataTable();
			val = new MySqlDataAdapter("        ( " + text + " )        UNION ALL     ( " + text2 + " )       ", Module1.cn_SQL);
			((DbDataAdapter)(object)val).Fill(dataTable);
			if (dataTable.Rows[0]["N"] == DBNull.Value)
			{
				Label_ALERTS_STOCK.Text = Conversions.ToString(0);
			}
			else
			{
				Label_ALERTS_STOCK.Text = Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["N"])));
			}
			if (dataTable.Rows[1]["N"] == DBNull.Value)
			{
				Label_STOCK_NEGATIF.Text = Conversions.ToString(0);
			}
			else
			{
				Label_STOCK_NEGATIF.Text = Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows[1]["N"])));
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
				string text3 = Strings.Format(DateTime.Now, "yyMMddHHmmssfff");
				Bitmap val2 = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, (PixelFormat)2498570);
				Graphics val3 = Graphics.FromImage((Image)(object)val2);
				val3.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, (CopyPixelOperation)13369376);
				((Image)val2).Save(Application.StartupPath + "\\tchak\\" + text3 + ".snidb", ImageFormat.Jpeg);
				val2 = null;
				string right = "ERROR | ";
				File.AppendAllText(Application.StartupPath + "\\log_erreur.sni", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(text3 + " | ", MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text), " | "), Module1._USERNAME), " | "), ((Control)this).Name), " | "), NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null)), " | "), right), " | "), ex2.ToString()), "\r\n"), "Ligne : "), fileLineNumber), "\r\n"), "\r\n"), "##########################################################################################################"), "\r\n")), Encoding.UTF8);
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

	private void Label_ALERTS_Click(object sender, EventArgs e)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		try
		{
			_DT_TEMP.Clear();
			_DA_TEMP = new MySqlDataAdapter("select    ID_ARTICLE,CODE,ARTICLE,FAMILLE,STOCK,ALERT     from TABLE_ARTICLES WHERE     STOCK    <=  Alert    and   STOCK <> 0   and    (MODE_STOCK  = 'FINI'  or MODE_STOCK  = 'MATIERE PREMIERE')   order by        Famille,Article      asc", Module1.cn_SQL);
			((DbDataAdapter)(object)_DA_TEMP).Fill(_DT_TEMP);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			StackTrace stackTrace = new StackTrace(ex2, fNeedFileInfo: true);
			StackFrame frame = stackTrace.GetFrame(checked(stackTrace.FrameCount - 1));
			int fileLineNumber = frame.GetFileLineNumber();
			Interaction.MsgBox(ex2.Message + "\r\nLigne : " + Conversions.ToString(fileLineNumber) + "\r\n");
			ProjectData.ClearProjectError();
		}
	}

	private void Label_STOCK_NEGATIF_Click(object sender, EventArgs e)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		try
		{
			_DT_TEMP.Clear();
			_DA_TEMP = new MySqlDataAdapter("select     ID_ARTICLE,CODE,ARTICLE,FAMILLE,STOCK,ALERT      from TABLE_ARTICLES WHERE      STOCK    < 0   and    (MODE_STOCK  = 'FINI'  or MODE_STOCK  = 'MATIERE PREMIERE')   order by        Famille,Article      asc", Module1.cn_SQL);
			((DbDataAdapter)(object)_DA_TEMP).Fill(_DT_TEMP);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			StackTrace stackTrace = new StackTrace(ex2, fNeedFileInfo: true);
			StackFrame frame = stackTrace.GetFrame(checked(stackTrace.FrameCount - 1));
			int fileLineNumber = frame.GetFileLineNumber();
			Interaction.MsgBox(ex2.Message + "\r\nLigne : " + Conversions.ToString(fileLineNumber) + "\r\n");
			ProjectData.ClearProjectError();
		}
	}
}
