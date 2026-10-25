using System;
using System.Collections;
using System.Collections.Generic;
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
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace LOGICA;

[DesignerGenerated]
public class FormDialog_ETAT_INVENTAIRE : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Label_TABLE")]
	private Label _Label_TABLE;

	[AccessedThroughProperty("DataGridView1")]
	private DataGridView _DataGridView1;

	[AccessedThroughProperty("Panel8")]
	private Panel _Panel8;

	[AccessedThroughProperty("RadioButton2")]
	private RadioButton _RadioButton2;

	[AccessedThroughProperty("RadioButton1")]
	private RadioButton _RadioButton1;

	[AccessedThroughProperty("Label27")]
	private Label _Label27;

	[AccessedThroughProperty("Label28")]
	private Label _Label28;

	[AccessedThroughProperty("Label29")]
	private Label _Label29;

	[AccessedThroughProperty("Label30")]
	private Label _Label30;

	[AccessedThroughProperty("Button_OK")]
	private Button _Button_OK;

	[AccessedThroughProperty("Print_INV_PRE")]
	private PrintDocument _Print_INV_PRE;

	[AccessedThroughProperty("Button3")]
	private Button _Button3;

	[AccessedThroughProperty("ID_ARTICLE")]
	private DataGridViewTextBoxColumn _ID_ARTICLE;

	[AccessedThroughProperty("Code")]
	private DataGridViewTextBoxColumn _Code;

	[AccessedThroughProperty("Article")]
	private DataGridViewTextBoxColumn _Article;

	[AccessedThroughProperty("Famille")]
	private DataGridViewTextBoxColumn _Famille;

	[AccessedThroughProperty("DATE_INVENTAIRE")]
	private DataGridViewTextBoxColumn _DATE_INVENTAIRE;

	[AccessedThroughProperty("Stock")]
	private DataGridViewTextBoxColumn _Stock;

	[AccessedThroughProperty("Picture_EXPORT")]
	private Button_RJ _Picture_EXPORT;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Label9")]
	private Label _Label9;

	[AccessedThroughProperty("DateTimePicker1")]
	private DateTimePicker _DateTimePicker1;

	[AccessedThroughProperty("DateTimePicker2")]
	private DateTimePicker _DateTimePicker2;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("PictureBox8222")]
	private PictureBox _PictureBox8222;

	[AccessedThroughProperty("Button53322")]
	private Button _Button53322;

	private DataTable _DT_TEMP;

	private MySqlDataAdapter _DA_TEMP;

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

	internal virtual Panel Panel8
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel8 = value;
		}
	}

	internal virtual RadioButton RadioButton2
	{
		[DebuggerNonUserCode]
		get
		{
			return _RadioButton2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = RadioButton2_CheckedChanged;
			if (_RadioButton2 != null)
			{
				_RadioButton2.CheckedChanged -= eventHandler;
			}
			_RadioButton2 = value;
			if (_RadioButton2 != null)
			{
				_RadioButton2.CheckedChanged += eventHandler;
			}
		}
	}

	internal virtual RadioButton RadioButton1
	{
		[DebuggerNonUserCode]
		get
		{
			return _RadioButton1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RadioButton1 = value;
		}
	}

	internal virtual Label Label27
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label27;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label27 = value;
		}
	}

	internal virtual Label Label28
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label28;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label28 = value;
		}
	}

	internal virtual Label Label29
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label29;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label29 = value;
		}
	}

	internal virtual Label Label30
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label30;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label30 = value;
		}
	}

	internal virtual Button Button_OK
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_OK;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_OK_Click;
			if (_Button_OK != null)
			{
				((Control)_Button_OK).Click -= eventHandler;
			}
			_Button_OK = value;
			if (_Button_OK != null)
			{
				((Control)_Button_OK).Click += eventHandler;
			}
		}
	}

	internal virtual PrintDocument Print_INV_PRE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Print_INV_PRE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			PrintPageEventHandler val = Print_INV_PRE_PrintPage;
			if (_Print_INV_PRE != null)
			{
				_Print_INV_PRE.PrintPage -= val;
			}
			_Print_INV_PRE = value;
			if (_Print_INV_PRE != null)
			{
				_Print_INV_PRE.PrintPage += val;
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

	internal virtual DataGridViewTextBoxColumn DATE_INVENTAIRE
	{
		[DebuggerNonUserCode]
		get
		{
			return _DATE_INVENTAIRE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DATE_INVENTAIRE = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Stock
	{
		[DebuggerNonUserCode]
		get
		{
			return _Stock;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Stock = value;
		}
	}

	internal virtual Button_RJ Picture_EXPORT
	{
		[DebuggerNonUserCode]
		get
		{
			return _Picture_EXPORT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Picture_EXPORT_Click;
			if (_Picture_EXPORT != null)
			{
				((Control)_Picture_EXPORT).Click -= eventHandler;
			}
			_Picture_EXPORT = value;
			if (_Picture_EXPORT != null)
			{
				((Control)_Picture_EXPORT).Click += eventHandler;
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

	internal virtual Label Label9
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label9 = value;
		}
	}

	internal virtual DateTimePicker DateTimePicker1
	{
		[DebuggerNonUserCode]
		get
		{
			return _DateTimePicker1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DateTimePicker1 = value;
		}
	}

	internal virtual DateTimePicker DateTimePicker2
	{
		[DebuggerNonUserCode]
		get
		{
			return _DateTimePicker2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DateTimePicker2 = value;
		}
	}

	internal virtual Label Label1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label1 = value;
		}
	}

	internal virtual PictureBox PictureBox8222
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox8222;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox8222 = value;
		}
	}

	internal virtual Button Button53322
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button53322;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button53322_Click;
			if (_Button53322 != null)
			{
				((Control)_Button53322).Click -= eventHandler;
			}
			_Button53322 = value;
			if (_Button53322 != null)
			{
				((Control)_Button53322).Click += eventHandler;
			}
		}
	}

	public FormDialog_ETAT_INVENTAIRE()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected Obj, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		((Form)this).Load += Form_LES_ALERTS_Load;
		((Control)this).KeyDown += me_KeyDown;
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
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected Obj, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected Obj, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected Obj, but got Unknown
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected Obj, but got Unknown
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected Obj, but got Unknown
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected Obj, but got Unknown
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected Obj, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected Obj, but got Unknown
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected Obj, but got Unknown
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Expected Obj, but got Unknown
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected Obj, but got Unknown
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Expected Obj, but got Unknown
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected Obj, but got Unknown
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Expected Obj, but got Unknown
		//IL_0378: Unknown result type (might be due to invalid IL or missing references)
		//IL_0382: Expected Obj, but got Unknown
		//IL_07cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d7: Expected Obj, but got Unknown
		//IL_088c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0896: Expected Obj, but got Unknown
		//IL_094b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0955: Expected Obj, but got Unknown
		//IL_09de: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e8: Expected Obj, but got Unknown
		//IL_0a71: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7b: Expected Obj, but got Unknown
		//IL_0c75: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c7f: Expected Obj, but got Unknown
		//IL_0d41: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d4b: Expected Obj, but got Unknown
		//IL_0e09: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e13: Expected Obj, but got Unknown
		//IL_0ed5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0edf: Expected Obj, but got Unknown
		//IL_0f8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f94: Expected Obj, but got Unknown
		//IL_0fbf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc9: Expected Obj, but got Unknown
		//IL_0ffe: Unknown result type (might be due to invalid IL or missing references)
		//IL_1004: Unknown result type (might be due to invalid IL or missing references)
		//IL_10b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_10bc: Expected Obj, but got Unknown
		//IL_1105: Unknown result type (might be due to invalid IL or missing references)
		//IL_110b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1192: Unknown result type (might be due to invalid IL or missing references)
		//IL_119c: Expected Obj, but got Unknown
		//IL_126d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1277: Expected Obj, but got Unknown
		//IL_129a: Unknown result type (might be due to invalid IL or missing references)
		//IL_12a4: Expected Obj, but got Unknown
		//IL_12dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_12e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_141a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1424: Expected Obj, but got Unknown
		//IL_156b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1575: Expected Obj, but got Unknown
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		DataGridViewCellStyle val3 = new DataGridViewCellStyle();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FormDialog_ETAT_INVENTAIRE));
		Label_TABLE = new Label();
		DataGridView1 = new DataGridView();
		ID_ARTICLE = new DataGridViewTextBoxColumn();
		Code = new DataGridViewTextBoxColumn();
		Article = new DataGridViewTextBoxColumn();
		Famille = new DataGridViewTextBoxColumn();
		DATE_INVENTAIRE = new DataGridViewTextBoxColumn();
		Stock = new DataGridViewTextBoxColumn();
		Panel8 = new Panel();
		Label3 = new Label();
		Label9 = new Label();
		DateTimePicker1 = new DateTimePicker();
		DateTimePicker2 = new DateTimePicker();
		Label1 = new Label();
		RadioButton2 = new RadioButton();
		RadioButton1 = new RadioButton();
		Label27 = new Label();
		Label28 = new Label();
		Label29 = new Label();
		Label30 = new Label();
		Button_OK = new Button();
		Print_INV_PRE = new PrintDocument();
		Button3 = new Button();
		PictureBox8222 = new PictureBox();
		Button53322 = new Button();
		Picture_EXPORT = new Button_RJ();
		((ISupportInitialize)DataGridView1).BeginInit();
		((Control)Panel8).SuspendLayout();
		((ISupportInitialize)PictureBox8222).BeginInit();
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
		Size size = new Size(1025, 44);
		((Control)label_TABLE2).Size = size;
		((Control)Label_TABLE).TabIndex = 1037;
		Label_TABLE.Text = "ETAT INVENTAIRE";
		Label_TABLE.TextAlign = (ContentAlignment)16;
		DataGridView1.AllowUserToAddRows = false;
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
			(DataGridViewColumn)DATE_INVENTAIRE,
			(DataGridViewColumn)Stock
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
		location = new Point(0, 44);
		((Control)dataGridView).Location = location;
		((Control)DataGridView1).Name = "DataGridView1";
		DataGridView1.RowHeadersVisible = false;
		DataGridView1.RowHeadersWidth = 20;
		DataGridView dataGridView2 = DataGridView1;
		size = new Size(1025, 506);
		((Control)dataGridView2).Size = size;
		((Control)DataGridView1).TabIndex = 1041;
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
		((DataGridViewColumn)Famille).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)Famille).FillWeight = 45.60068f;
		((DataGridViewColumn)Famille).HeaderText = "Famille";
		((DataGridViewColumn)Famille).Name = "Famille";
		Famille.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)Famille).Width = 120;
		((DataGridViewColumn)DATE_INVENTAIRE).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)DATE_INVENTAIRE).HeaderText = "Date_Inventaire";
		((DataGridViewColumn)DATE_INVENTAIRE).Name = "DATE_INVENTAIRE";
		DATE_INVENTAIRE.SortMode = (DataGridViewColumnSortMode)2;
		((DataGridViewColumn)DATE_INVENTAIRE).Width = 120;
		((DataGridViewColumn)Stock).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)Stock).FillWeight = 45.60068f;
		((DataGridViewColumn)Stock).HeaderText = "Stock";
		((DataGridViewColumn)Stock).Name = "Stock";
		Stock.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)Stock).Width = 60;
		((Control)Panel8).BackColor = Color.White;
		((Control)Panel8).Controls.Add((Control)(object)Label3);
		((Control)Panel8).Controls.Add((Control)(object)Label9);
		((Control)Panel8).Controls.Add((Control)(object)DateTimePicker1);
		((Control)Panel8).Controls.Add((Control)(object)DateTimePicker2);
		((Control)Panel8).Controls.Add((Control)(object)Label1);
		((Control)Panel8).Controls.Add((Control)(object)RadioButton2);
		((Control)Panel8).Controls.Add((Control)(object)RadioButton1);
		((Control)Panel8).Controls.Add((Control)(object)Label27);
		((Control)Panel8).Controls.Add((Control)(object)Label28);
		((Control)Panel8).Controls.Add((Control)(object)Label29);
		((Control)Panel8).Controls.Add((Control)(object)Label30);
		((Control)Panel8).Controls.Add((Control)(object)Button_OK);
		Panel panel = Panel8;
		location = new Point(12, 556);
		((Control)panel).Location = location;
		((Control)Panel8).Name = "Panel8";
		Panel panel2 = Panel8;
		size = new Size(429, 124);
		((Control)panel2).Size = size;
		((Control)Panel8).TabIndex = 1048;
		((Control)Label3).BackColor = SystemColors.Control;
		((Control)Label3).Font = new Font("Segoe UI", 11.25f, (FontStyle)1);
		((Control)Label3).ForeColor = Color.Black;
		Label3.ImeMode = (ImeMode)0;
		Label label = Label3;
		location = new Point(7, 83);
		((Control)label).Location = location;
		((Control)Label3).Name = "Label3";
		Label label2 = Label3;
		size = new Size(32, 30);
		((Control)label2).Size = size;
		((Control)Label3).TabIndex = 1056;
		Label3.Text = "A";
		Label3.TextAlign = (ContentAlignment)16;
		((Control)Label9).BackColor = SystemColors.Control;
		((Control)Label9).Font = new Font("Segoe UI", 11.25f, (FontStyle)1);
		((Control)Label9).ForeColor = Color.Black;
		Label9.ImeMode = (ImeMode)0;
		Label label3 = Label9;
		location = new Point(7, 44);
		((Control)label3).Location = location;
		((Control)Label9).Name = "Label9";
		Label label4 = Label9;
		size = new Size(32, 30);
		((Control)label4).Size = size;
		((Control)Label9).TabIndex = 1057;
		Label9.Text = "De";
		Label9.TextAlign = (ContentAlignment)16;
		DateTimePicker1.CustomFormat = "yyyy/MM/dd  HH:mm:ss";
		((Control)DateTimePicker1).Font = new Font("Arial", 15f, (FontStyle)1);
		DateTimePicker1.Format = (DateTimePickerFormat)2;
		DateTimePicker dateTimePicker = DateTimePicker1;
		location = new Point(45, 44);
		((Control)dateTimePicker).Location = location;
		((Control)DateTimePicker1).Name = "DateTimePicker1";
		DateTimePicker dateTimePicker2 = DateTimePicker1;
		size = new Size(145, 30);
		((Control)dateTimePicker2).Size = size;
		((Control)DateTimePicker1).TabIndex = 1055;
		DateTimePicker2.CustomFormat = "yyyy/MM/dd  HH:mm:ss";
		((Control)DateTimePicker2).Font = new Font("Arial", 15f, (FontStyle)1);
		DateTimePicker2.Format = (DateTimePickerFormat)2;
		DateTimePicker dateTimePicker3 = DateTimePicker2;
		location = new Point(45, 83);
		((Control)dateTimePicker3).Location = location;
		((Control)DateTimePicker2).Name = "DateTimePicker2";
		DateTimePicker dateTimePicker4 = DateTimePicker2;
		size = new Size(145, 30);
		((Control)dateTimePicker4).Size = size;
		((Control)DateTimePicker2).TabIndex = 1054;
		((Control)Label1).BackColor = SystemColors.Control;
		((Control)Label1).Font = new Font("Segoe UI", 11.25f, (FontStyle)1);
		((Control)Label1).ForeColor = Color.Black;
		Label label5 = Label1;
		location = new Point(42, 9);
		((Control)label5).Location = location;
		((Control)Label1).Name = "Label1";
		Label label6 = Label1;
		size = new Size(148, 23);
		((Control)label6).Size = size;
		((Control)Label1).TabIndex = 1053;
		Label1.Text = "Date d'inventaire";
		Label1.TextAlign = (ContentAlignment)16;
		((ButtonBase)RadioButton2).AutoSize = true;
		RadioButton radioButton = RadioButton2;
		location = new Point(276, 35);
		((Control)radioButton).Location = location;
		((Control)RadioButton2).Name = "RadioButton2";
		RadioButton radioButton2 = RadioButton2;
		size = new Size(136, 17);
		((Control)radioButton2).Size = size;
		((Control)RadioButton2).TabIndex = 1048;
		RadioButton2.TabStop = true;
		((ButtonBase)RadioButton2).Text = "Les articles Non Traités";
		((ButtonBase)RadioButton2).UseVisualStyleBackColor = true;
		((ButtonBase)RadioButton1).AutoSize = true;
		RadioButton radioButton3 = RadioButton1;
		location = new Point(276, 13);
		((Control)radioButton3).Location = location;
		((Control)RadioButton1).Name = "RadioButton1";
		RadioButton radioButton4 = RadioButton1;
		size = new Size(114, 17);
		((Control)radioButton4).Size = size;
		((Control)RadioButton1).TabIndex = 1047;
		RadioButton1.TabStop = true;
		((ButtonBase)RadioButton1).Text = "Les articles Traités";
		((ButtonBase)RadioButton1).UseVisualStyleBackColor = true;
		((Control)Label27).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label27).Cursor = Cursors.Hand;
		((Control)Label27).Dock = (DockStyle)2;
		((Control)Label27).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label27).ForeColor = Color.White;
		Label label7 = Label27;
		location = new Point(1, 123);
		((Control)label7).Location = location;
		((Control)Label27).Name = "Label27";
		Label label8 = Label27;
		size = new Size(427, 1);
		((Control)label8).Size = size;
		((Control)Label27).TabIndex = 999;
		Label27.TextAlign = (ContentAlignment)16;
		((Control)Label28).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label28).Cursor = Cursors.Hand;
		((Control)Label28).Dock = (DockStyle)3;
		((Control)Label28).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label28).ForeColor = Color.White;
		Label label9 = Label28;
		location = new Point(0, 1);
		((Control)label9).Location = location;
		((Control)Label28).Name = "Label28";
		Label label10 = Label28;
		size = new Size(1, 123);
		((Control)label10).Size = size;
		((Control)Label28).TabIndex = 998;
		Label28.TextAlign = (ContentAlignment)16;
		((Control)Label29).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label29).Cursor = Cursors.Hand;
		((Control)Label29).Dock = (DockStyle)4;
		((Control)Label29).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label29).ForeColor = Color.White;
		Label label11 = Label29;
		location = new Point(428, 1);
		((Control)label11).Location = location;
		((Control)Label29).Name = "Label29";
		Label label12 = Label29;
		size = new Size(1, 123);
		((Control)label12).Size = size;
		((Control)Label29).TabIndex = 997;
		Label29.TextAlign = (ContentAlignment)16;
		((Control)Label30).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label30).Cursor = Cursors.Hand;
		((Control)Label30).Dock = (DockStyle)1;
		((Control)Label30).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label30).ForeColor = Color.White;
		Label label13 = Label30;
		location = new Point(0, 0);
		((Control)label13).Location = location;
		((Control)Label30).Name = "Label30";
		Label label14 = Label30;
		size = new Size(429, 1);
		((Control)label14).Size = size;
		((Control)Label30).TabIndex = 996;
		Label30.Text = "-";
		Label30.TextAlign = (ContentAlignment)16;
		((Control)Button_OK).Cursor = Cursors.Hand;
		((Control)Button_OK).Font = new Font("Tahoma", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Button_OK).ForeColor = Color.FromArgb(2, 45, 162);
		((ButtonBase)Button_OK).Image = (Image)componentResourceManager.GetObject("Button_OK.Image");
		((ButtonBase)Button_OK).ImageAlign = (ContentAlignment)16;
		Button button_OK = Button_OK;
		location = new Point(276, 69);
		((Control)button_OK).Location = location;
		Button button_OK2 = Button_OK;
		Padding margin = new Padding(0);
		((Control)button_OK2).Margin = margin;
		((Control)Button_OK).Name = "Button_OK";
		Button button_OK3 = Button_OK;
		size = new Size(133, 44);
		((Control)button_OK3).Size = size;
		((Control)Button_OK).TabIndex = 677;
		((ButtonBase)Button_OK).Text = "OK";
		((ButtonBase)Button_OK).UseVisualStyleBackColor = true;
		((ButtonBase)Button3).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Button3).Cursor = Cursors.Hand;
		((ButtonBase)Button3).FlatStyle = (FlatStyle)0;
		((Control)Button3).Font = new Font("Tahoma", 11.25f, (FontStyle)1);
		((Control)Button3).ForeColor = Color.White;
		((ButtonBase)Button3).ImageAlign = (ContentAlignment)16;
		Button button = Button3;
		location = new Point(802, 556);
		((Control)button).Location = location;
		Button button2 = Button3;
		margin = new Padding(0);
		((Control)button2).Margin = margin;
		((Control)Button3).Name = "Button3";
		Button button3 = Button3;
		size = new Size(214, 30);
		((Control)button3).Size = size;
		((Control)Button3).TabIndex = 1049;
		((ButtonBase)Button3).Text = "Imprimer";
		((ButtonBase)Button3).UseVisualStyleBackColor = false;
		((Control)PictureBox8222).BackColor = Color.Transparent;
		PictureBox8222.Image = (Image)componentResourceManager.GetObject("PictureBox8222.Image");
		PictureBox8222.ImeMode = (ImeMode)0;
		PictureBox pictureBox = PictureBox8222;
		location = new Point(893, 624);
		((Control)pictureBox).Location = location;
		((Control)PictureBox8222).Name = "PictureBox8222";
		PictureBox pictureBox2 = PictureBox8222;
		size = new Size(31, 23);
		((Control)pictureBox2).Size = size;
		PictureBox8222.SizeMode = (PictureBoxSizeMode)4;
		PictureBox8222.TabIndex = 1128;
		PictureBox8222.TabStop = false;
		((Control)PictureBox8222).Visible = false;
		((ButtonBase)Button53322).BackColor = Color.Red;
		((Control)Button53322).Cursor = Cursors.Hand;
		((ButtonBase)Button53322).FlatStyle = (FlatStyle)0;
		((Control)Button53322).Font = new Font("Tahoma", 11.25f, (FontStyle)1);
		((Control)Button53322).ForeColor = Color.White;
		((ButtonBase)Button53322).Image = (Image)componentResourceManager.GetObject("Button53322.Image");
		((ButtonBase)Button53322).ImageAlign = (ContentAlignment)16;
		Button button4 = Button53322;
		location = new Point(802, 650);
		((Control)button4).Location = location;
		Button button5 = Button53322;
		margin = new Padding(0);
		((Control)button5).Margin = margin;
		((Control)Button53322).Name = "Button53322";
		Button button6 = Button53322;
		size = new Size(214, 30);
		((Control)button6).Size = size;
		((Control)Button53322).TabIndex = 1127;
		((ButtonBase)Button53322).Text = "Remise à zéro";
		((ButtonBase)Button53322).UseVisualStyleBackColor = false;
		((Control)Button53322).Visible = false;
		Picture_EXPORT._BackgroundColor = Color.FromArgb(75, 141, 242);
		Picture_EXPORT._BorderColor = Color.White;
		Picture_EXPORT._BorderRadius = 16;
		Picture_EXPORT._BorderSize = 1;
		Picture_EXPORT._TextColor = Color.White;
		((Control)Picture_EXPORT).Anchor = (AnchorStyles)9;
		((ButtonBase)Picture_EXPORT).BackColor = Color.FromArgb(75, 141, 242);
		((ButtonBase)Picture_EXPORT).FlatAppearance.BorderSize = 0;
		((ButtonBase)Picture_EXPORT).FlatStyle = (FlatStyle)0;
		((Control)Picture_EXPORT).ForeColor = Color.White;
		((ButtonBase)Picture_EXPORT).Image = (Image)componentResourceManager.GetObject("Picture_EXPORT.Image");
		((ButtonBase)Picture_EXPORT).ImeMode = (ImeMode)0;
		Button_RJ picture_EXPORT = Picture_EXPORT;
		location = new Point(983, 6);
		((Control)picture_EXPORT).Location = location;
		((Control)Picture_EXPORT).Name = "Picture_EXPORT";
		Button_RJ picture_EXPORT2 = Picture_EXPORT;
		size = new Size(33, 33);
		((Control)picture_EXPORT2).Size = size;
		((Control)Picture_EXPORT).TabIndex = 1057;
		((ButtonBase)Picture_EXPORT).UseVisualStyleBackColor = false;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).BackColor = Color.White;
		size = new Size(1025, 692);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)PictureBox8222);
		((Control)this).Controls.Add((Control)(object)Button53322);
		((Control)this).Controls.Add((Control)(object)Picture_EXPORT);
		((Control)this).Controls.Add((Control)(object)Button3);
		((Control)this).Controls.Add((Control)(object)Panel8);
		((Control)this).Controls.Add((Control)(object)DataGridView1);
		((Control)this).Controls.Add((Control)(object)Label_TABLE);
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Form)this).KeyPreview = true;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "FormDialog_ETAT_INVENTAIRE";
		((Form)this).StartPosition = (FormStartPosition)1;
		((ISupportInitialize)DataGridView1).EndInit();
		((Control)Panel8).ResumeLayout(false);
		((Control)Panel8).PerformLayout();
		((ISupportInitialize)PictureBox8222).EndInit();
		((Control)this).ResumeLayout(false);
	}

	public void FUN_CAT_ACCES()
	{
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
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected Obj, but got Unknown
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected Obj, but got Unknown
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Expected Obj, but got Unknown
		checked
		{
			try
			{
				DataGridView1.AutoGenerateColumns = false;
				DataGridView1.RowTemplate.Height = 15;
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
				Module1.dt1.Clear();
				FUN_CAT_ACCES();
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

	private void Button_OK_Click(object sender, EventArgs e)
	{
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected Obj, but got Unknown
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected Obj, but got Unknown
		if (RadioButton1.Checked)
		{
			_DT_TEMP.Clear();
			_DA_TEMP = new MySqlDataAdapter("select ID_ARTICLE,CODE,ARTICLE,FAMILLE,DATE_INVENTAIRE,STOCK  from TABLE_ARTICLES     WHERE       DATE_INVENTAIRE     between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '           order by  FAMILLE,Article asc ", Module1.cn_SQL);
			((DbDataAdapter)(object)_DA_TEMP).Fill(_DT_TEMP);
		}
		else if (RadioButton2.Checked)
		{
			_DT_TEMP.Clear();
			_DA_TEMP = new MySqlDataAdapter("select ID_ARTICLE,CODE,ARTICLE,FAMILLE,DATE_INVENTAIRE,STOCK  from TABLE_ARTICLES     WHERE       DATE_INVENTAIRE     <   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     or     DATE_INVENTAIRE  >   ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '          order by  FAMILLE,Article asc ", Module1.cn_SQL);
			((DbDataAdapter)(object)_DA_TEMP).Fill(_DT_TEMP);
		}
		DataGridView1.Rows.Clear();
		checked
		{
			int num = _DT_TEMP.Rows.Count - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				DataGridView1.Rows.Add(new object[6]
				{
					_DT_TEMP.Rows[num2]["ID_ARTICLE"].ToString(),
					_DT_TEMP.Rows[num2]["Code"].ToString(),
					_DT_TEMP.Rows[num2]["Article"].ToString(),
					_DT_TEMP.Rows[num2]["Famille"].ToString(),
					Conversions.ToDate(_DT_TEMP.Rows[num2]["DATE_INVENTAIRE"].ToString()).ToString("dd/MM/yyy"),
					_DT_TEMP.Rows[num2]["STOCK"].ToString()
				});
				num2++;
			}
			DataGridView1.RowTemplate.Height = 15;
		}
	}

	private void Button3_Click(object sender, EventArgs e)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected Obj, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
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
				PrintPreviewDialog val = new PrintPreviewDialog();
				val.Document = Print_INV_PRE;
				val.PrintPreviewControl.Zoom = 2.0;
				((Form)val).WindowState = (FormWindowState)2;
				((Form)val).ShowDialog();
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

	private void Print_INV_PRE_PrintPage(object sender, PrintPageEventArgs e)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected Obj, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected Obj, but got Unknown
		//IL_008d: Expected Obj, but got Unknown
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected Obj, but got Unknown
		//IL_00c7: Expected Obj, but got Unknown
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected Obj, but got Unknown
		//IL_0101: Expected Obj, but got Unknown
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected Obj, but got Unknown
		//IL_013b: Expected Obj, but got Unknown
		//IL_035c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0363: Expected Obj, but got Unknown
		//IL_0262: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0285: Expected Obj, but got Unknown
		//IL_0285: Expected Obj, but got Unknown
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bb: Expected Obj, but got Unknown
		//IL_02bb: Expected Obj, but got Unknown
		checked
		{
			try
			{
				e.Graphics.FillRectangle((Brush)new SolidBrush(Color.Silver), 0, 0, 300, 15);
				string text = "Pré-inventaire";
				e.Graphics.DrawString(text, new Font("Lucida Console", 10f, (FontStyle)1), Brushes.Black, Convert.ToSingle(130f - e.Graphics.MeasureString(text, new Font("Lucida Console", 10f, (FontStyle)1)).Width / 2f), 0f, new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("-----------------------------------------", new Font("Lucida Console", 8f, (FontStyle)0), Brushes.Black, 0f, 100f, new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("Désignation          |Logique |Physique |  ", new Font("Lucida Console", 7f, (FontStyle)1), Brushes.Black, 0f, 110f, new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("-----------------------------------------", new Font("Lucida Console", 8f, (FontStyle)0), Brushes.Black, 0f, 120f, new StringFormat((StringFormatFlags)8192));
				int num = 0;
				string text2 = "";
				string text3 = "";
				string text4 = "";
				int num2 = DataGridView1.Rows.Count - 1;
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
					text3 = text3 + Strings.RSet(DataGridView1.Rows[num].Cells["stock"].Value.ToString(), 8) + "|" + Environment.NewLine + Environment.NewLine;
					num++;
				}
				e.Graphics.DrawString(text2, new Font("Lucida Console", 7f, (FontStyle)0), Brushes.Black, 0f, 130f, new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString(text3, new Font("Lucida Console", 7f, (FontStyle)0), Brushes.Black, 140f, 130f, new StringFormat((StringFormatFlags)8192));
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
			Module1._QUITTER_PATIENTER = true;
		}
	}

	private void Picture_EXPORT_Click(object sender, EventArgs e)
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
			Interaction.MsgBox(ex2.ToString());
			ProjectData.ClearProjectError();
		}
	}

	private void Button53322_Click(object sender, EventArgs e)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Invalid comparison between Unknown and I4
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Invalid comparison between Unknown and I4
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Invalid comparison between Unknown and I4
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected Obj, but got Unknown
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected Obj, but got Unknown
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		if ((int)MessageBox.Show("Si vous choisissez le bouton «\u202fRemise à zéro\u202f», tous les stocks de cette liste seront réinitialisés à zéro. ", "Attention", (MessageBoxButtons)1, (MessageBoxIcon)32, (MessageBoxDefaultButton)0) != 1 || (int)MessageBox.Show("Attention, Tous les changements seront effectués sur votre responsabilité.\r\nVoulez-vous vraiment Continuer ?", "Attention", (MessageBoxButtons)1, (MessageBoxIcon)32, (MessageBoxDefaultButton)0) != 1 || (int)MessageBox.Show("Voulez-vous vraiment réinitialiser les stocks à zéro ?", "Attention", (MessageBoxButtons)1, (MessageBoxIcon)32, (MessageBoxDefaultButton)0) != 1)
		{
			return;
		}
		string right = "Remise à zéro du stock | ETAT INVENTAIRE";
		File.AppendAllText(Application.StartupPath + "\\log.sni", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(Strings.Format(DateTime.Now, "ddMMyy HHmmss fff") + MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text, " | "), Module1._USERNAME), " | "), ((Control)this).Name), " | "), NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null)), " | "), right), "\r\n")), Encoding.UTF8);
		DataTable dataTable = new DataTable();
		MySqlDataAdapter val = new MySqlDataAdapter();
		checked
		{
			int num = DataGridView1.Rows.Count - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				dataTable.Clear();
				dataTable = new DataTable();
				val = new MySqlDataAdapter("UPDATE     TABLE_ARTICLES    SET STOCK   =  0 , DATE_INVENTAIRE   =  '" + DateTime.Now.Date.ToString("dd/MM/yyy") + "'  ,STOCK_INITIAL   =  0       WHERE        ID_ARTICLE = '" + DataGridView1.Rows[num2].Cells["ID_ARTICLE"].Value.ToString() + "'       ", Module1.cn_SQL);
				((DbDataAdapter)(object)val).Fill(dataTable);
				num2++;
			}
			MessageBox.Show("Modifié avec succès", "ok", (MessageBoxButtons)0, (MessageBoxIcon)64, (MessageBoxDefaultButton)0);
		}
	}

	private void RadioButton2_CheckedChanged(object sender, EventArgs e)
	{
		if (RadioButton2.Checked)
		{
			((Control)PictureBox8222).Visible = true;
			((Control)Button53322).Visible = true;
		}
		else
		{
			((Control)PictureBox8222).Visible = false;
			((Control)Button53322).Visible = false;
		}
	}
}
