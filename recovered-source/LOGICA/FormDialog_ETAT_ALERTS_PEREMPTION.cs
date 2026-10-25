using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using LOGICA.My;
using Microsoft.Reporting.WinForms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace LOGICA;

[DesignerGenerated]
public class FormDialog_ETAT_ALERTS_PEREMPTION : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Label_TABLE")]
	private Label _Label_TABLE;

	[AccessedThroughProperty("DataGridView1")]
	private DataGridView _DataGridView1;

	[AccessedThroughProperty("Button_RAPPORT")]
	private Button _Button_RAPPORT;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[AccessedThroughProperty("Button3")]
	private Button _Button3;

	[AccessedThroughProperty("NumericUpDown1")]
	private NumericUpDown _NumericUpDown1;

	[AccessedThroughProperty("NumericUpDown2")]
	private NumericUpDown _NumericUpDown2;

	[AccessedThroughProperty("ID_BR")]
	private DataGridViewTextBoxColumn _ID_BR;

	[AccessedThroughProperty("ID_ARTICLE")]
	private DataGridViewTextBoxColumn _ID_ARTICLE;

	[AccessedThroughProperty("Code")]
	private DataGridViewTextBoxColumn _Code;

	[AccessedThroughProperty("Article")]
	private DataGridViewTextBoxColumn _Article;

	[AccessedThroughProperty("DATE_PEREMPTION")]
	private DataGridViewTextBoxColumn _DATE_PEREMPTION;

	[AccessedThroughProperty("STOCK_RECEPTIONNE")]
	private DataGridViewTextBoxColumn _STOCK_RECEPTIONNE;

	[AccessedThroughProperty("N_LOT")]
	private DataGridViewTextBoxColumn _N_LOT;

	[AccessedThroughProperty("Stock_Actuel")]
	private DataGridViewTextBoxColumn _Stock_Actuel;

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

	internal virtual Button Button_RAPPORT
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_RAPPORT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_RAPPORT_Click;
			if (_Button_RAPPORT != null)
			{
				((Control)_Button_RAPPORT).Click -= eventHandler;
			}
			_Button_RAPPORT = value;
			if (_Button_RAPPORT != null)
			{
				((Control)_Button_RAPPORT).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button1_Click;
			if (_Button1 != null)
			{
				((Control)_Button1).Click -= eventHandler;
			}
			_Button1 = value;
			if (_Button1 != null)
			{
				((Control)_Button1).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button2_Click;
			if (_Button2 != null)
			{
				((Control)_Button2).Click -= eventHandler;
			}
			_Button2 = value;
			if (_Button2 != null)
			{
				((Control)_Button2).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button3_Click;
			if (_Button3 != null)
			{
				((Control)_Button3).Click -= eventHandler;
			}
			_Button3 = value;
			if (_Button3 != null)
			{
				((Control)_Button3).Click += eventHandler;
			}
		}
	}

	internal virtual NumericUpDown NumericUpDown1
	{
		[DebuggerNonUserCode]
		get
		{
			return _NumericUpDown1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_NumericUpDown1 = value;
		}
	}

	internal virtual NumericUpDown NumericUpDown2
	{
		[DebuggerNonUserCode]
		get
		{
			return _NumericUpDown2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_NumericUpDown2 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn ID_BR
	{
		[DebuggerNonUserCode]
		get
		{
			return _ID_BR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ID_BR = value;
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

	internal virtual DataGridViewTextBoxColumn DATE_PEREMPTION
	{
		[DebuggerNonUserCode]
		get
		{
			return _DATE_PEREMPTION;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DATE_PEREMPTION = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn STOCK_RECEPTIONNE
	{
		[DebuggerNonUserCode]
		get
		{
			return _STOCK_RECEPTIONNE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_STOCK_RECEPTIONNE = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn N_LOT
	{
		[DebuggerNonUserCode]
		get
		{
			return _N_LOT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_N_LOT = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Stock_Actuel
	{
		[DebuggerNonUserCode]
		get
		{
			return _Stock_Actuel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Stock_Actuel = value;
		}
	}

	[DebuggerNonUserCode]
	public FormDialog_ETAT_ALERTS_PEREMPTION()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		((Control)this).KeyDown += me_KeyDown;
		((Form)this).Load += Form_LES_ALERTS_Load;
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
		//IL_000e: Expected Obj, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected Obj, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected Obj, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected Obj, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected Obj, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected Obj, but got Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected Obj, but got Unknown
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected Obj, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected Obj, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected Obj, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected Obj, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected Obj, but got Unknown
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected Obj, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected Obj, but got Unknown
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected Obj, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected Obj, but got Unknown
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected Obj, but got Unknown
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected Obj, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected Obj, but got Unknown
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected Obj, but got Unknown
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Expected Obj, but got Unknown
		//IL_033b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0345: Expected Obj, but got Unknown
		//IL_046c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0476: Expected Obj, but got Unknown
		//IL_0489: Unknown result type (might be due to invalid IL or missing references)
		//IL_0493: Expected Obj, but got Unknown
		//IL_04cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0564: Unknown result type (might be due to invalid IL or missing references)
		//IL_056e: Expected Obj, but got Unknown
		//IL_0609: Unknown result type (might be due to invalid IL or missing references)
		//IL_0613: Expected Obj, but got Unknown
		//IL_06ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b8: Expected Obj, but got Unknown
		//IL_0751: Unknown result type (might be due to invalid IL or missing references)
		//IL_075b: Expected Obj, but got Unknown
		//IL_0835: Unknown result type (might be due to invalid IL or missing references)
		//IL_083f: Expected Obj, but got Unknown
		//IL_0c8b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c95: Expected Obj, but got Unknown
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FormDialog_ETAT_ALERTS_PEREMPTION));
		DataGridViewCellStyle val3 = new DataGridViewCellStyle();
		DataGridViewCellStyle val4 = new DataGridViewCellStyle();
		DataGridViewCellStyle val5 = new DataGridViewCellStyle();
		DataGridViewCellStyle val6 = new DataGridViewCellStyle();
		Label_TABLE = new Label();
		DataGridView1 = new DataGridView();
		Button_RAPPORT = new Button();
		Button1 = new Button();
		Button2 = new Button();
		Button3 = new Button();
		NumericUpDown1 = new NumericUpDown();
		NumericUpDown2 = new NumericUpDown();
		ID_BR = new DataGridViewTextBoxColumn();
		ID_ARTICLE = new DataGridViewTextBoxColumn();
		Code = new DataGridViewTextBoxColumn();
		Article = new DataGridViewTextBoxColumn();
		DATE_PEREMPTION = new DataGridViewTextBoxColumn();
		STOCK_RECEPTIONNE = new DataGridViewTextBoxColumn();
		N_LOT = new DataGridViewTextBoxColumn();
		Stock_Actuel = new DataGridViewTextBoxColumn();
		((ISupportInitialize)DataGridView1).BeginInit();
		((ISupportInitialize)NumericUpDown1).BeginInit();
		((ISupportInitialize)NumericUpDown2).BeginInit();
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
		Size size = new Size(1025, 30);
		((Control)label_TABLE2).Size = size;
		((Control)Label_TABLE).TabIndex = 1037;
		Label_TABLE.Text = "LES ALERTS PEREMPTION ( Les Receptions Valider)";
		Label_TABLE.TextAlign = (ContentAlignment)16;
		DataGridView1.AllowUserToAddRows = false;
		DataGridView1.AllowUserToDeleteRows = false;
		DataGridView1.AllowUserToResizeRows = false;
		DataGridView1.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)16;
		DataGridView1.BackgroundColor = Color.White;
		val.Alignment = (DataGridViewContentAlignment)16;
		val.BackColor = SystemColors.Control;
		val.Font = new Font("Calibri", 11f, (FontStyle)1);
		val.ForeColor = SystemColors.WindowText;
		val.SelectionBackColor = SystemColors.Highlight;
		val.SelectionForeColor = SystemColors.HighlightText;
		val.WrapMode = (DataGridViewTriState)1;
		DataGridView1.ColumnHeadersDefaultCellStyle = val;
		DataGridView1.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		DataGridView1.Columns.AddRange(new DataGridViewColumn[8]
		{
			(DataGridViewColumn)ID_BR,
			(DataGridViewColumn)ID_ARTICLE,
			(DataGridViewColumn)Code,
			(DataGridViewColumn)Article,
			(DataGridViewColumn)DATE_PEREMPTION,
			(DataGridViewColumn)STOCK_RECEPTIONNE,
			(DataGridViewColumn)N_LOT,
			(DataGridViewColumn)Stock_Actuel
		});
		val2.Alignment = (DataGridViewContentAlignment)16;
		val2.BackColor = SystemColors.Window;
		val2.Font = new Font("Arial Narrow", 15.75f);
		val2.ForeColor = SystemColors.ControlText;
		val2.SelectionBackColor = SystemColors.Highlight;
		val2.SelectionForeColor = SystemColors.HighlightText;
		val2.WrapMode = (DataGridViewTriState)2;
		DataGridView1.DefaultCellStyle = val2;
		((Control)DataGridView1).Dock = (DockStyle)1;
		DataGridView1.EditMode = (DataGridViewEditMode)4;
		DataGridView dataGridView = DataGridView1;
		location = new Point(0, 30);
		((Control)dataGridView).Location = location;
		((Control)DataGridView1).Name = "DataGridView1";
		DataGridView1.RowHeadersVisible = false;
		DataGridView1.RowHeadersWidth = 20;
		DataGridView dataGridView2 = DataGridView1;
		size = new Size(1025, 511);
		((Control)dataGridView2).Size = size;
		((Control)DataGridView1).TabIndex = 1041;
		((ButtonBase)Button_RAPPORT).BackColor = Color.White;
		((Control)Button_RAPPORT).Cursor = Cursors.Hand;
		((ButtonBase)Button_RAPPORT).FlatAppearance.BorderColor = Color.DarkGray;
		((ButtonBase)Button_RAPPORT).FlatStyle = (FlatStyle)0;
		((Control)Button_RAPPORT).Font = new Font("Calibri", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((ButtonBase)Button_RAPPORT).Image = (Image)componentResourceManager.GetObject("Button_RAPPORT.Image");
		((ButtonBase)Button_RAPPORT).ImageAlign = (ContentAlignment)16;
		Button button_RAPPORT = Button_RAPPORT;
		location = new Point(865, 638);
		((Control)button_RAPPORT).Location = location;
		Button button_RAPPORT2 = Button_RAPPORT;
		Padding margin = new Padding(0);
		((Control)button_RAPPORT2).Margin = margin;
		((Control)Button_RAPPORT).Name = "Button_RAPPORT";
		Button button_RAPPORT3 = Button_RAPPORT;
		size = new Size(151, 50);
		((Control)button_RAPPORT3).Size = size;
		((Control)Button_RAPPORT).TabIndex = 1042;
		((ButtonBase)Button_RAPPORT).Text = "Imprimer";
		((ButtonBase)Button_RAPPORT).TextAlign = (ContentAlignment)64;
		((ButtonBase)Button_RAPPORT).TextImageRelation = (TextImageRelation)4;
		((ButtonBase)Button_RAPPORT).UseVisualStyleBackColor = false;
		((Control)Button1).Font = new Font("Tahoma", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		Button button = Button1;
		location = new Point(3, 596);
		((Control)button).Location = location;
		((Control)Button1).Name = "Button1";
		Button button2 = Button1;
		size = new Size(171, 43);
		((Control)button2).Size = size;
		((Control)Button1).TabIndex = 1043;
		((ButtonBase)Button1).Text = "Aujourd'hui    - ";
		((ButtonBase)Button1).TextAlign = (ContentAlignment)16;
		((ButtonBase)Button1).UseVisualStyleBackColor = true;
		((Control)Button2).Font = new Font("Tahoma", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		Button button3 = Button2;
		location = new Point(3, 547);
		((Control)button3).Location = location;
		((Control)Button2).Name = "Button2";
		Button button4 = Button2;
		size = new Size(171, 43);
		((Control)button4).Size = size;
		((Control)Button2).TabIndex = 1044;
		((ButtonBase)Button2).Text = "Aujourd'hui";
		((ButtonBase)Button2).TextAlign = (ContentAlignment)16;
		((ButtonBase)Button2).UseVisualStyleBackColor = true;
		((Control)Button3).Font = new Font("Tahoma", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		Button button5 = Button3;
		location = new Point(3, 645);
		((Control)button5).Location = location;
		((Control)Button3).Name = "Button3";
		Button button6 = Button3;
		size = new Size(171, 43);
		((Control)button6).Size = size;
		((Control)Button3).TabIndex = 1045;
		((ButtonBase)Button3).Text = "Aujourd'hui    + ";
		((ButtonBase)Button3).TextAlign = (ContentAlignment)16;
		((ButtonBase)Button3).UseVisualStyleBackColor = true;
		((Control)NumericUpDown1).Font = new Font("Tahoma", 22.25f, (FontStyle)1);
		NumericUpDown numericUpDown = NumericUpDown1;
		location = new Point(180, 596);
		((Control)numericUpDown).Location = location;
		NumericUpDown numericUpDown2 = NumericUpDown1;
		decimal maximum = new decimal(new int[4] { 1000, 0, 0, 0 });
		numericUpDown2.Maximum = maximum;
		((Control)NumericUpDown1).Name = "NumericUpDown1";
		NumericUpDown numericUpDown3 = NumericUpDown1;
		size = new Size(112, 43);
		((Control)numericUpDown3).Size = size;
		((Control)NumericUpDown1).TabIndex = 1046;
		maximum = (NumericUpDown1.Value = new decimal(new int[4] { 1, 0, 0, 0 }));
		((Control)NumericUpDown2).Font = new Font("Tahoma", 22.25f, (FontStyle)1);
		NumericUpDown numericUpDown4 = NumericUpDown2;
		location = new Point(180, 645);
		((Control)numericUpDown4).Location = location;
		maximum = (NumericUpDown2.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 }));
		((Control)NumericUpDown2).Name = "NumericUpDown2";
		NumericUpDown numericUpDown5 = NumericUpDown2;
		size = new Size(112, 43);
		((Control)numericUpDown5).Size = size;
		((Control)NumericUpDown2).TabIndex = 1047;
		maximum = (NumericUpDown2.Value = new decimal(new int[4] { 1, 0, 0, 0 }));
		((DataGridViewColumn)ID_BR).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)ID_BR).HeaderText = "ID BR";
		((DataGridViewColumn)ID_BR).Name = "ID_BR";
		((DataGridViewColumn)ID_BR).Width = 80;
		((DataGridViewColumn)ID_ARTICLE).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)ID_ARTICLE).HeaderText = "ID_ARTICLE";
		((DataGridViewColumn)ID_ARTICLE).Name = "ID_ARTICLE";
		((DataGridViewColumn)Code).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)Code).FillWeight = 426.3959f;
		((DataGridViewColumn)Code).HeaderText = "Code";
		((DataGridViewColumn)Code).Name = "Code";
		((DataGridViewColumn)Code).Width = 120;
		val3.Format = "N2";
		val3.NullValue = null;
		((DataGridViewColumn)Article).DefaultCellStyle = val3;
		((DataGridViewColumn)Article).FillWeight = 45.60068f;
		((DataGridViewColumn)Article).HeaderText = "Article";
		((DataGridViewColumn)Article).Name = "Article";
		Article.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)DATE_PEREMPTION).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		val4.Format = "d";
		val4.NullValue = null;
		((DataGridViewColumn)DATE_PEREMPTION).DefaultCellStyle = val4;
		((DataGridViewColumn)DATE_PEREMPTION).FillWeight = 45.60068f;
		((DataGridViewColumn)DATE_PEREMPTION).HeaderText = "Date Péremption";
		((DataGridViewColumn)DATE_PEREMPTION).Name = "DATE_PEREMPTION";
		DATE_PEREMPTION.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)DATE_PEREMPTION).Width = 140;
		((DataGridViewColumn)STOCK_RECEPTIONNE).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		val5.Alignment = (DataGridViewContentAlignment)32;
		((DataGridViewColumn)STOCK_RECEPTIONNE).DefaultCellStyle = val5;
		((DataGridViewColumn)STOCK_RECEPTIONNE).HeaderText = "Stock Recéptionnée";
		((DataGridViewColumn)STOCK_RECEPTIONNE).Name = "STOCK_RECEPTIONNE";
		((DataGridViewColumn)STOCK_RECEPTIONNE).Width = 140;
		((DataGridViewColumn)N_LOT).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)N_LOT).HeaderText = "N° LOT";
		((DataGridViewColumn)N_LOT).Name = "N_LOT";
		((DataGridViewColumn)N_LOT).Width = 80;
		((DataGridViewColumn)Stock_Actuel).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		val6.Alignment = (DataGridViewContentAlignment)32;
		((DataGridViewColumn)Stock_Actuel).DefaultCellStyle = val6;
		((DataGridViewColumn)Stock_Actuel).HeaderText = "Stock Actuel";
		((DataGridViewColumn)Stock_Actuel).MinimumWidth = 2;
		((DataGridViewColumn)Stock_Actuel).Name = "Stock_Actuel";
		Stock_Actuel.SortMode = (DataGridViewColumnSortMode)2;
		((DataGridViewColumn)Stock_Actuel).Width = 120;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).BackColor = Color.White;
		size = new Size(1025, 692);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)NumericUpDown2);
		((Control)this).Controls.Add((Control)(object)NumericUpDown1);
		((Control)this).Controls.Add((Control)(object)Button3);
		((Control)this).Controls.Add((Control)(object)Button2);
		((Control)this).Controls.Add((Control)(object)Button1);
		((Control)this).Controls.Add((Control)(object)DataGridView1);
		((Control)this).Controls.Add((Control)(object)Label_TABLE);
		((Control)this).Controls.Add((Control)(object)Button_RAPPORT);
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Form)this).KeyPreview = true;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "Form_ETAT_ALERTS_PEREMPTION";
		((Form)this).StartPosition = (FormStartPosition)1;
		((ISupportInitialize)DataGridView1).EndInit();
		((ISupportInitialize)NumericUpDown1).EndInit();
		((ISupportInitialize)NumericUpDown2).EndInit();
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

	private void Form_LES_ALERTS_Load(object sender, EventArgs e)
	{
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected Obj, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected Obj, but got Unknown
		int try0001_dispatch = -1;
		checked
		{
			int num2 = default;
			int num = default;
			while (true)
			{
				try
				{
					/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
					switch (try0001_dispatch)
					{
					default:
					{
						ProjectData.ClearProjectError();
						num2 = 2;
						DataGridView1.AutoGenerateColumns = false;
						DataGridView1.RowTemplate.Height = 15;
						DataGridView1.DataSource = Module1._DT_TEMP;
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
						int num3 = ((BaseCollection)DataGridView1.Columns).Count - 1;
						int num4 = 0;
						while (true)
						{
							int num5 = num4;
							int num6 = num3;
							if (num5 > num6)
							{
								break;
							}
							DataGridView1.Columns[num4].SortMode = (DataGridViewColumnSortMode)2;
							num4++;
						}
						DataGridView1.AllowUserToAddRows = false;
						DataGridView1.AllowUserToDeleteRows = false;
						DataGridView1.AllowUserToOrderColumns = true;
						DataGridView1.AllowUserToResizeColumns = true;
						DataGridView1.AllowUserToResizeRows = false;
						Module1.dt1.Clear();
						goto end_IL_0001;
					}
					case 564:
						num = -1;
						switch (num2)
						{
						case 2:
							Interaction.MsgBox(Information.Err().Description);
							goto end_IL_0001;
						}
						break;
					}
				}
				catch (Exception ex) when ((num2 != 0) & (num == 0))
				{
					ProjectData.SetProjectError(ex);
					try0001_dispatch = 564;
					continue;
				}
				throw ProjectData.CreateProjectError(-2146828237);
				continue;
				end_IL_0001:
				break;
			}
			if (num != 0)
			{
				ProjectData.ClearProjectError();
			}
		}
	}

	private void Button_RAPPORT_Click(object sender, EventArgs e)
	{
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Expected Obj, but got Unknown
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Expected Obj, but got Unknown
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Expected Obj, but got Unknown
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Expected Obj, but got Unknown
		checked
		{
			try
			{
				if (DataGridView1.Rows.Count == 0)
				{
					NewLateBinding.LateSet(sender, null, "Enabled", new object[1] { true }, null, null);
					return;
				}
				string text = "";
				string text2 = "";
				string text3 = "";
				string text4 = "";
				string text5 = "";
				int num = DataGridView1.RowCount - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					text = text + Strings.Mid(DataGridView1.Rows[num2].Cells["CODE"].Value.ToString(), 1, 13) + Environment.NewLine + Environment.NewLine;
					text2 = text2 + Strings.Mid(DataGridView1.Rows[num2].Cells["Article"].Value.ToString().ToUpper(), 1, 30) + Environment.NewLine + Environment.NewLine;
					text4 = text4 + DataGridView1.Rows[num2].Cells["Stock_Actuel"].Value.ToString() + Environment.NewLine + Environment.NewLine;
					text5 = text5 + Conversions.ToDate(DataGridView1.Rows[num2].Cells["DATE_PEREMPTION"].Value).ToString("dd/MM/yyy") + Environment.NewLine + Environment.NewLine;
					num2++;
				}
				text = text.Remove(text.Length - 4);
				text2 = text2.Remove(text2.Length - 4);
				text4 = text4.Remove(text4.Length - 4);
				text5 = text5.Remove(text5.Length - 4);
				((Report)MyProject.Forms.Report_PEREMPTIONS.ReportViewer1.LocalReport).SetParameters(new ReportParameter("CODE", text));
				((Report)MyProject.Forms.Report_PEREMPTIONS.ReportViewer1.LocalReport).SetParameters(new ReportParameter("ARTICLE", text2));
				((Report)MyProject.Forms.Report_PEREMPTIONS.ReportViewer1.LocalReport).SetParameters(new ReportParameter("QTE", text4));
				((Report)MyProject.Forms.Report_PEREMPTIONS.ReportViewer1.LocalReport).SetParameters(new ReportParameter("DATE_PEREMPTION", text5));
				MyProject.Forms.Report_PEREMPTIONS.ReportViewer1.RefreshReport();
				MyProject.Forms.Report_PEREMPTIONS.ReportViewer1.SetDisplayMode((DisplayMode)1);
				MyProject.Forms.Report_PEREMPTIONS.ReportViewer1.ZoomMode = (ZoomMode)2;
				MyProject.Forms.Report_PEREMPTIONS.ReportViewer1.ZoomPercent = 25;
				((Control)MyProject.Forms.Report_PEREMPTIONS).Show();
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

	private void Button2_Click(object sender, EventArgs e)
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected Obj, but got Unknown
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected Obj, but got Unknown
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Expected Obj, but got Unknown
		//IL_0328: Unknown result type (might be due to invalid IL or missing references)
		//IL_032e: Invalid comparison between Unknown and I4
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
				MySqlDataAdapter val = new MySqlDataAdapter();
				DataTable dataTable2 = new DataTable();
				MySqlDataAdapter val2 = new MySqlDataAdapter();
				dataTable.Clear();
				val = new MySqlDataAdapter("select ID_BR,ID_ARTICLE,CODE,ARTICLE,DATE_PEREMPTION,Qté,N_LOT       from       TABLE_RECEPTIONS_DETAILS     WHERE       DATE_PEREMPTION      between   ' " + Strings.Format(DateTime.Now.Date, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTime.Now.Date, "yyyy-MM-dd") + " '        and       ETAT = 'VALIDER'        order by  DATE_PEREMPTION asc ", Module1.cn_SQL);
				((DbDataAdapter)(object)val).Fill(dataTable);
				DataGridView1.Rows.Clear();
				int num = dataTable.Rows.Count - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					DataGridView1.Rows.Add(new object[7]
					{
						dataTable.Rows[num2]["ID_BR"].ToString(),
						dataTable.Rows[num2]["ID_ARTICLE"].ToString(),
						dataTable.Rows[num2]["CODE"].ToString(),
						dataTable.Rows[num2]["ARTICLE"].ToString(),
						Conversions.ToDate(dataTable.Rows[num2]["DATE_PEREMPTION"]).ToString("dd/MM/yyy"),
						dataTable.Rows[num2]["Qté"].ToString(),
						dataTable.Rows[num2]["N_LOT"].ToString()
					});
					dataTable2.Clear();
					val2 = new MySqlDataAdapter("SELECT     STOCK         FROM   TABLE_ARTICLES     WHERE   ID_ARTICLE  =  '" + DataGridView1.Rows[num2].Cells["ID_ARTICLE"].Value.ToString() + "'          ", Module1.cn_SQL);
					((DbDataAdapter)(object)val2).Fill(dataTable2);
					if (dataTable2.Rows.Count == 0)
					{
						DataGridView1.Rows[num2].Cells["Stock_Actuel"].Value = "000";
					}
					else
					{
						DataGridView1.Rows[num2].Cells["Stock_Actuel"].Value = RuntimeHelpers.GetObjectValue(dataTable2.Rows[0]["STOCK"]);
					}
					num2++;
				}
				Module1._QUITTER_PATIENTER = true;
				if (DataGridView1.Rows.Count <= 0 || unchecked((int)MessageBox.Show("Voulez-vous ignorer les articles en rupture de stock ??", "Attention", (MessageBoxButtons)4, (MessageBoxIcon)32, (MessageBoxDefaultButton)0)) != 6)
				{
					return;
				}
				int num5 = DataGridView1.Rows.Count - 1;
				while (true)
				{
					int num6 = num5;
					int num4 = 0;
					if (num6 >= num4)
					{
						if (Conversion.Val(DataGridView1.Rows[num5].Cells["Stock_Actuel"].Value.ToString()) <= 0.0)
						{
							DataGridView1.Rows.RemoveAt(num5);
						}
						num5 += -1;
						continue;
					}
					break;
				}
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

	private void Button1_Click(object sender, EventArgs e)
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected Obj, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected Obj, but got Unknown
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Expected Obj, but got Unknown
		//IL_0346: Unknown result type (might be due to invalid IL or missing references)
		//IL_034c: Invalid comparison between Unknown and I4
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
				MySqlDataAdapter val = new MySqlDataAdapter();
				DataTable dataTable2 = new DataTable();
				MySqlDataAdapter val2 = new MySqlDataAdapter();
				dataTable.Clear();
				val = new MySqlDataAdapter("select ID_BR,ID_ARTICLE,CODE,ARTICLE,DATE_PEREMPTION,Qté,N_LOT            from       TABLE_RECEPTIONS_DETAILS     WHERE       DATE_PEREMPTION      between     ' " + Strings.Format(DateTime.Now.Date.AddDays(Convert.ToDouble(decimal.Negate(NumericUpDown1.Value))), "yyyy-MM-dd") + " '          And    ' " + Strings.Format(DateTime.Now.Date, "yyyy-MM-dd") + " '             and       ETAT = 'VALIDER'               order by  DATE_PEREMPTION asc ", Module1.cn_SQL);
				((DbDataAdapter)(object)val).Fill(dataTable);
				DataGridView1.Rows.Clear();
				int num = dataTable.Rows.Count - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					DataGridView1.Rows.Add(new object[7]
					{
						dataTable.Rows[num2]["ID_BR"].ToString(),
						dataTable.Rows[num2]["ID_ARTICLE"].ToString(),
						dataTable.Rows[num2]["CODE"].ToString(),
						dataTable.Rows[num2]["ARTICLE"].ToString(),
						Conversions.ToDate(dataTable.Rows[num2]["DATE_PEREMPTION"]).ToString("dd/MM/yyy"),
						dataTable.Rows[num2]["Qté"].ToString(),
						dataTable.Rows[num2]["N_LOT"].ToString()
					});
					dataTable2.Clear();
					val2 = new MySqlDataAdapter("SELECT     STOCK         FROM   TABLE_ARTICLES     WHERE   ID_ARTICLE  =  '" + DataGridView1.Rows[num2].Cells["ID_ARTICLE"].Value.ToString() + "'          ", Module1.cn_SQL);
					((DbDataAdapter)(object)val2).Fill(dataTable2);
					if (dataTable2.Rows.Count == 0)
					{
						DataGridView1.Rows[num2].Cells["Stock_Actuel"].Value = "";
					}
					else
					{
						DataGridView1.Rows[num2].Cells["Stock_Actuel"].Value = RuntimeHelpers.GetObjectValue(dataTable2.Rows[0]["STOCK"]);
					}
					num2++;
				}
				Module1._QUITTER_PATIENTER = true;
				if (DataGridView1.Rows.Count <= 0 || unchecked((int)MessageBox.Show("Voulez-vous ignorer les articles en rupture de stock ??", "Attention", (MessageBoxButtons)4, (MessageBoxIcon)32, (MessageBoxDefaultButton)0)) != 6)
				{
					return;
				}
				int num5 = DataGridView1.Rows.Count - 1;
				while (true)
				{
					int num6 = num5;
					int num4 = 0;
					if (num6 >= num4)
					{
						if (Conversion.Val(DataGridView1.Rows[num5].Cells["Stock_Actuel"].Value.ToString()) <= 0.0)
						{
							DataGridView1.Rows.RemoveAt(num5);
						}
						num5 += -1;
						continue;
					}
					break;
				}
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

	private void Button3_Click(object sender, EventArgs e)
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected Obj, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected Obj, but got Unknown
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Expected Obj, but got Unknown
		//IL_0341: Unknown result type (might be due to invalid IL or missing references)
		//IL_0347: Invalid comparison between Unknown and I4
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
				MySqlDataAdapter val = new MySqlDataAdapter();
				DataTable dataTable2 = new DataTable();
				MySqlDataAdapter val2 = new MySqlDataAdapter();
				dataTable.Clear();
				val = new MySqlDataAdapter("select ID_BR,ID_ARTICLE,CODE,ARTICLE,DATE_PEREMPTION,Qté,N_LOT        from       TABLE_RECEPTIONS_DETAILS     WHERE       DATE_PEREMPTION      between   ' " + Strings.Format(DateTime.Now.Date, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTime.Now.Date.AddDays(Convert.ToDouble(NumericUpDown2.Value)), "yyyy-MM-dd") + " '               and       ETAT = 'VALIDER'            order by  DATE_PEREMPTION asc ", Module1.cn_SQL);
				((DbDataAdapter)(object)val).Fill(dataTable);
				DataGridView1.Rows.Clear();
				int num = dataTable.Rows.Count - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					DataGridView1.Rows.Add(new object[7]
					{
						dataTable.Rows[num2]["ID_BR"].ToString(),
						dataTable.Rows[num2]["ID_ARTICLE"].ToString(),
						dataTable.Rows[num2]["CODE"].ToString(),
						dataTable.Rows[num2]["ARTICLE"].ToString(),
						Conversions.ToDate(dataTable.Rows[num2]["DATE_PEREMPTION"]).ToString("dd/MM/yyy"),
						dataTable.Rows[num2]["Qté"].ToString(),
						dataTable.Rows[num2]["N_LOT"].ToString()
					});
					dataTable2.Clear();
					val2 = new MySqlDataAdapter("SELECT     STOCK         FROM   TABLE_ARTICLES     WHERE   ID_ARTICLE  =  '" + DataGridView1.Rows[num2].Cells["ID_ARTICLE"].Value.ToString() + "'          ", Module1.cn_SQL);
					((DbDataAdapter)(object)val2).Fill(dataTable2);
					if (dataTable2.Rows.Count == 0)
					{
						DataGridView1.Rows[num2].Cells["Stock_Actuel"].Value = "";
					}
					else
					{
						DataGridView1.Rows[num2].Cells["Stock_Actuel"].Value = RuntimeHelpers.GetObjectValue(dataTable2.Rows[0]["STOCK"]);
					}
					num2++;
				}
				Module1._QUITTER_PATIENTER = true;
				if (DataGridView1.Rows.Count <= 0 || unchecked((int)MessageBox.Show("Voulez-vous ignorer les articles en rupture de stock ??", "Attention", (MessageBoxButtons)4, (MessageBoxIcon)32, (MessageBoxDefaultButton)0)) != 6)
				{
					return;
				}
				int num5 = DataGridView1.Rows.Count - 1;
				while (true)
				{
					int num6 = num5;
					int num4 = 0;
					if (num6 >= num4)
					{
						if (Conversion.Val(DataGridView1.Rows[num5].Cells["Stock_Actuel"].Value.ToString()) <= 0.0)
						{
							DataGridView1.Rows.RemoveAt(num5);
						}
						num5 += -1;
						continue;
					}
					break;
				}
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
