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
public class FormDialog_ETAT_STOCK : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Label_TABLE")]
	private Label _Label_TABLE;

	[AccessedThroughProperty("DataGridView1")]
	private DataGridView _DataGridView1;

	[AccessedThroughProperty("Button_PrintRapport")]
	private Button _Button_PrintRapport;

	[AccessedThroughProperty("Panel_FIND")]
	private Panel _Panel_FIND;

	[AccessedThroughProperty("Check_FIND_EXACTE")]
	private CheckBox _Check_FIND_EXACTE;

	[AccessedThroughProperty("Panel8")]
	private Panel _Panel8;

	[AccessedThroughProperty("Combo_FIND")]
	private ComboBox _Combo_FIND;

	[AccessedThroughProperty("Picture_REFRESH")]
	private PictureBox _Picture_REFRESH;

	[AccessedThroughProperty("Picture_FIND")]
	private PictureBox _Picture_FIND;

	[AccessedThroughProperty("Text_FIND")]
	private TextBox _Text_FIND;

	[AccessedThroughProperty("Label14")]
	private Label _Label14;

	[AccessedThroughProperty("Label21")]
	private Label _Label21;

	[AccessedThroughProperty("Label22")]
	private Label _Label22;

	[AccessedThroughProperty("Label23")]
	private Label _Label23;

	[AccessedThroughProperty("Button4")]
	private Button _Button4;

	[AccessedThroughProperty("Button14")]
	private Button _Button14;

	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	[AccessedThroughProperty("Panel119898")]
	private Panel _Panel119898;

	[AccessedThroughProperty("DataGridView_FILTRAGE")]
	private DataGridView _DataGridView_FILTRAGE;

	[AccessedThroughProperty("Column2")]
	private DataGridViewButtonColumn _Column2;

	[AccessedThroughProperty("Panel2")]
	private Panel _Panel2;

	[AccessedThroughProperty("Button_RJ38787")]
	private Button_RJ _Button_RJ38787;

	[AccessedThroughProperty("Button_RJ16576")]
	private Button_RJ _Button_RJ16576;

	[AccessedThroughProperty("Panel4")]
	private Panel _Panel4;

	[AccessedThroughProperty("TextBox14343")]
	private TextBox _TextBox14343;

	[AccessedThroughProperty("Label55")]
	private Label _Label55;

	[AccessedThroughProperty("Label56")]
	private Label _Label56;

	[AccessedThroughProperty("Label57")]
	private Label _Label57;

	[AccessedThroughProperty("Label58")]
	private Label _Label58;

	[AccessedThroughProperty("ID_ARTICLE")]
	private DataGridViewTextBoxColumn _ID_ARTICLE;

	[AccessedThroughProperty("REFERENCE")]
	private DataGridViewTextBoxColumn _REFERENCE;

	[AccessedThroughProperty("Code")]
	private DataGridViewTextBoxColumn _Code;

	[AccessedThroughProperty("Article")]
	private DataGridViewTextBoxColumn _Article;

	[AccessedThroughProperty("Famille")]
	private DataGridViewTextBoxColumn _Famille;

	[AccessedThroughProperty("DATE_INVENTAIRE")]
	private DataGridViewTextBoxColumn _DATE_INVENTAIRE;

	[AccessedThroughProperty("STOCK_INITIAL")]
	private DataGridViewTextBoxColumn _STOCK_INITIAL;

	[AccessedThroughProperty("STOCK_RECEPT")]
	private DataGridViewTextBoxColumn _STOCK_RECEPT;

	[AccessedThroughProperty("STOCK_SORTIE")]
	private DataGridViewTextBoxColumn _STOCK_SORTIE;

	[AccessedThroughProperty("STOCK_VENDU")]
	private DataGridViewTextBoxColumn _STOCK_VENDU;

	[AccessedThroughProperty("STOCK_PREVU")]
	private DataGridViewTextBoxColumn _STOCK_PREVU;

	[AccessedThroughProperty("STOCK_ACTUEL")]
	private DataGridViewTextBoxColumn _STOCK_ACTUEL;

	[AccessedThroughProperty("Alert")]
	private DataGridViewTextBoxColumn _Alert;

	[AccessedThroughProperty("Check_IGNORER_ZERO")]
	private CheckBox _Check_IGNORER_ZERO;

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

	internal virtual Button Button_PrintRapport
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_PrintRapport;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_ConsRapport_Click;
			if (_Button_PrintRapport != null)
			{
				((Control)_Button_PrintRapport).Click -= eventHandler;
			}
			_Button_PrintRapport = value;
			if (_Button_PrintRapport != null)
			{
				((Control)_Button_PrintRapport).Click += eventHandler;
			}
		}
	}

	internal virtual Panel Panel_FIND
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel_FIND;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel_FIND = value;
		}
	}

	internal virtual CheckBox Check_FIND_EXACTE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Check_FIND_EXACTE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Check_FIND_EXACTE = value;
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

	internal virtual ComboBox Combo_FIND
	{
		[DebuggerNonUserCode]
		get
		{
			return _Combo_FIND;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Combo_FIND_SelectedIndexChanged;
			if (_Combo_FIND != null)
			{
				_Combo_FIND.SelectedIndexChanged -= eventHandler;
			}
			_Combo_FIND = value;
			if (_Combo_FIND != null)
			{
				_Combo_FIND.SelectedIndexChanged += eventHandler;
			}
		}
	}

	internal virtual PictureBox Picture_REFRESH
	{
		[DebuggerNonUserCode]
		get
		{
			return _Picture_REFRESH;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Picture_REFRESH_Click;
			if (_Picture_REFRESH != null)
			{
				((Control)_Picture_REFRESH).Click -= eventHandler;
			}
			_Picture_REFRESH = value;
			if (_Picture_REFRESH != null)
			{
				((Control)_Picture_REFRESH).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox Picture_FIND
	{
		[DebuggerNonUserCode]
		get
		{
			return _Picture_FIND;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Picture_FIND_Click;
			if (_Picture_FIND != null)
			{
				((Control)_Picture_FIND).Click -= eventHandler;
			}
			_Picture_FIND = value;
			if (_Picture_FIND != null)
			{
				((Control)_Picture_FIND).Click += eventHandler;
			}
		}
	}

	internal virtual TextBox Text_FIND
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_FIND;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Text_FIND_TextChanged;
			if (_Text_FIND != null)
			{
				((Control)_Text_FIND).TextChanged -= eventHandler;
			}
			_Text_FIND = value;
			if (_Text_FIND != null)
			{
				((Control)_Text_FIND).TextChanged += eventHandler;
			}
		}
	}

	internal virtual Label Label14
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label14 = value;
		}
	}

	internal virtual Label Label21
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label21;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label21 = value;
		}
	}

	internal virtual Label Label22
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label22;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label22 = value;
		}
	}

	internal virtual Label Label23
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label23;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label23 = value;
		}
	}

	internal virtual Button Button4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button4_Click;
			if (_Button4 != null)
			{
				((Control)_Button4).Click -= eventHandler;
			}
			_Button4 = value;
			if (_Button4 != null)
			{
				((Control)_Button4).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button14
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button14_Click;
			if (_Button14 != null)
			{
				((Control)_Button14).Click -= eventHandler;
			}
			_Button14 = value;
			if (_Button14 != null)
			{
				((Control)_Button14).Click += eventHandler;
			}
		}
	}

	internal virtual Panel Panel1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel1 = value;
		}
	}

	internal virtual Panel Panel119898
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel119898;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel119898 = value;
		}
	}

	internal virtual DataGridView DataGridView_FILTRAGE
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridView_FILTRAGE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			DataGridViewCellEventHandler val = DataGridView_FILTRAGE_CellClick;
			DataGridViewCellEventHandler val2 = DataGridView_FILTRAGE_CellContentClick;
			if (_DataGridView_FILTRAGE != null)
			{
				_DataGridView_FILTRAGE.CellClick -= val;
				_DataGridView_FILTRAGE.CellContentClick -= val2;
			}
			_DataGridView_FILTRAGE = value;
			if (_DataGridView_FILTRAGE != null)
			{
				_DataGridView_FILTRAGE.CellClick += val;
				_DataGridView_FILTRAGE.CellContentClick += val2;
			}
		}
	}

	internal virtual DataGridViewButtonColumn Column2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Column2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Column2 = value;
		}
	}

	internal virtual Panel Panel2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel2 = value;
		}
	}

	internal virtual Button_RJ Button_RJ38787
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_RJ38787;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_RJ38787_Click;
			if (_Button_RJ38787 != null)
			{
				((Control)_Button_RJ38787).Click -= eventHandler;
			}
			_Button_RJ38787 = value;
			if (_Button_RJ38787 != null)
			{
				((Control)_Button_RJ38787).Click += eventHandler;
			}
		}
	}

	internal virtual Button_RJ Button_RJ16576
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_RJ16576;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_RJ16576_Click;
			if (_Button_RJ16576 != null)
			{
				((Control)_Button_RJ16576).Click -= eventHandler;
			}
			_Button_RJ16576 = value;
			if (_Button_RJ16576 != null)
			{
				((Control)_Button_RJ16576).Click += eventHandler;
			}
		}
	}

	internal virtual Panel Panel4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel4 = value;
		}
	}

	internal virtual TextBox TextBox14343
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox14343;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = TextBox14343_TextChanged;
			if (_TextBox14343 != null)
			{
				((Control)_TextBox14343).TextChanged -= eventHandler;
			}
			_TextBox14343 = value;
			if (_TextBox14343 != null)
			{
				((Control)_TextBox14343).TextChanged += eventHandler;
			}
		}
	}

	internal virtual Label Label55
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label55;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label55 = value;
		}
	}

	internal virtual Label Label56
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label56;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label56 = value;
		}
	}

	internal virtual Label Label57
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label57;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label57 = value;
		}
	}

	internal virtual Label Label58
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label58;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label58 = value;
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

	internal virtual DataGridViewTextBoxColumn REFERENCE
	{
		[DebuggerNonUserCode]
		get
		{
			return _REFERENCE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_REFERENCE = value;
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

	internal virtual DataGridViewTextBoxColumn STOCK_INITIAL
	{
		[DebuggerNonUserCode]
		get
		{
			return _STOCK_INITIAL;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_STOCK_INITIAL = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn STOCK_RECEPT
	{
		[DebuggerNonUserCode]
		get
		{
			return _STOCK_RECEPT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_STOCK_RECEPT = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn STOCK_SORTIE
	{
		[DebuggerNonUserCode]
		get
		{
			return _STOCK_SORTIE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_STOCK_SORTIE = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn STOCK_VENDU
	{
		[DebuggerNonUserCode]
		get
		{
			return _STOCK_VENDU;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_STOCK_VENDU = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn STOCK_PREVU
	{
		[DebuggerNonUserCode]
		get
		{
			return _STOCK_PREVU;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_STOCK_PREVU = value;
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

	internal virtual CheckBox Check_IGNORER_ZERO
	{
		[DebuggerNonUserCode]
		get
		{
			return _Check_IGNORER_ZERO;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Check_IGNORER_ZERO = value;
		}
	}

	public FormDialog_ETAT_STOCK()
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
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected Obj, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
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
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected Obj, but got Unknown
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected Obj, but got Unknown
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected Obj, but got Unknown
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected Obj, but got Unknown
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected Obj, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected Obj, but got Unknown
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected Obj, but got Unknown
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected Obj, but got Unknown
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected Obj, but got Unknown
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected Obj, but got Unknown
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected Obj, but got Unknown
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Expected Obj, but got Unknown
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Expected Obj, but got Unknown
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Expected Obj, but got Unknown
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Expected Obj, but got Unknown
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Expected Obj, but got Unknown
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected Obj, but got Unknown
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Expected Obj, but got Unknown
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected Obj, but got Unknown
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Expected Obj, but got Unknown
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Expected Obj, but got Unknown
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Expected Obj, but got Unknown
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Expected Obj, but got Unknown
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Expected Obj, but got Unknown
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Expected Obj, but got Unknown
		//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Expected Obj, but got Unknown
		//IL_0406: Unknown result type (might be due to invalid IL or missing references)
		//IL_0410: Expected Obj, but got Unknown
		//IL_0526: Unknown result type (might be due to invalid IL or missing references)
		//IL_0530: Expected Obj, but got Unknown
		//IL_0ab5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0abf: Expected Obj, but got Unknown
		//IL_0ad2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0adc: Expected Obj, but got Unknown
		//IL_0c67: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c71: Expected Obj, but got Unknown
		//IL_0d16: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d20: Expected Obj, but got Unknown
		//IL_0f30: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f3a: Expected Obj, but got Unknown
		//IL_1002: Unknown result type (might be due to invalid IL or missing references)
		//IL_100c: Expected Obj, but got Unknown
		//IL_1091: Unknown result type (might be due to invalid IL or missing references)
		//IL_109b: Expected Obj, but got Unknown
		//IL_1148: Unknown result type (might be due to invalid IL or missing references)
		//IL_1152: Expected Obj, but got Unknown
		//IL_120a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1214: Expected Obj, but got Unknown
		//IL_12dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_12e6: Expected Obj, but got Unknown
		//IL_13aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_13b4: Expected Obj, but got Unknown
		//IL_147c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1486: Expected Obj, but got Unknown
		//IL_154d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1557: Expected Obj, but got Unknown
		//IL_1581: Unknown result type (might be due to invalid IL or missing references)
		//IL_158b: Expected Obj, but got Unknown
		//IL_1643: Unknown result type (might be due to invalid IL or missing references)
		//IL_164d: Expected Obj, but got Unknown
		//IL_1671: Unknown result type (might be due to invalid IL or missing references)
		//IL_167b: Expected Obj, but got Unknown
		//IL_16b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_16b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_197e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1988: Expected Obj, but got Unknown
		//IL_1a0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a16: Expected Obj, but got Unknown
		//IL_1bf2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bfc: Expected Obj, but got Unknown
		//IL_1d2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d35: Expected Obj, but got Unknown
		//IL_1eb8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ec2: Expected Obj, but got Unknown
		//IL_1f77: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f81: Expected Obj, but got Unknown
		//IL_2051: Unknown result type (might be due to invalid IL or missing references)
		//IL_205b: Expected Obj, but got Unknown
		//IL_212a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2134: Expected Obj, but got Unknown
		//IL_2204: Unknown result type (might be due to invalid IL or missing references)
		//IL_220e: Expected Obj, but got Unknown
		//IL_2362: Unknown result type (might be due to invalid IL or missing references)
		//IL_236c: Expected Obj, but got Unknown
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		DataGridViewCellStyle val3 = new DataGridViewCellStyle();
		DataGridViewCellStyle val4 = new DataGridViewCellStyle();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FormDialog_ETAT_STOCK));
		DataGridViewCellStyle val5 = new DataGridViewCellStyle();
		DataGridViewCellStyle val6 = new DataGridViewCellStyle();
		Label_TABLE = new Label();
		DataGridView1 = new DataGridView();
		ID_ARTICLE = new DataGridViewTextBoxColumn();
		REFERENCE = new DataGridViewTextBoxColumn();
		Code = new DataGridViewTextBoxColumn();
		Article = new DataGridViewTextBoxColumn();
		Famille = new DataGridViewTextBoxColumn();
		DATE_INVENTAIRE = new DataGridViewTextBoxColumn();
		STOCK_INITIAL = new DataGridViewTextBoxColumn();
		STOCK_RECEPT = new DataGridViewTextBoxColumn();
		STOCK_SORTIE = new DataGridViewTextBoxColumn();
		STOCK_VENDU = new DataGridViewTextBoxColumn();
		STOCK_PREVU = new DataGridViewTextBoxColumn();
		STOCK_ACTUEL = new DataGridViewTextBoxColumn();
		Alert = new DataGridViewTextBoxColumn();
		Button_PrintRapport = new Button();
		Panel_FIND = new Panel();
		Check_IGNORER_ZERO = new CheckBox();
		Check_FIND_EXACTE = new CheckBox();
		Panel8 = new Panel();
		Combo_FIND = new ComboBox();
		Picture_REFRESH = new PictureBox();
		Picture_FIND = new PictureBox();
		Text_FIND = new TextBox();
		Label14 = new Label();
		Label21 = new Label();
		Label22 = new Label();
		Label23 = new Label();
		Button4 = new Button();
		Button14 = new Button();
		Panel1 = new Panel();
		Panel119898 = new Panel();
		DataGridView_FILTRAGE = new DataGridView();
		Column2 = new DataGridViewButtonColumn();
		Panel2 = new Panel();
		Button_RJ38787 = new Button_RJ();
		Button_RJ16576 = new Button_RJ();
		Panel4 = new Panel();
		TextBox14343 = new TextBox();
		Label55 = new Label();
		Label56 = new Label();
		Label57 = new Label();
		Label58 = new Label();
		((ISupportInitialize)DataGridView1).BeginInit();
		((Control)Panel_FIND).SuspendLayout();
		((Control)Panel8).SuspendLayout();
		((ISupportInitialize)Picture_REFRESH).BeginInit();
		((ISupportInitialize)Picture_FIND).BeginInit();
		((Control)Panel1).SuspendLayout();
		((Control)Panel119898).SuspendLayout();
		((ISupportInitialize)DataGridView_FILTRAGE).BeginInit();
		((Control)Panel2).SuspendLayout();
		((Control)Panel4).SuspendLayout();
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
		Label_TABLE.Text = "ETAT_STOCK";
		Label_TABLE.TextAlign = (ContentAlignment)16;
		DataGridView1.AllowUserToAddRows = false;
		DataGridView1.AllowUserToDeleteRows = false;
		DataGridView1.AllowUserToResizeColumns = false;
		DataGridView1.AllowUserToResizeRows = false;
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
		DataGridView1.Columns.AddRange(new DataGridViewColumn[13]
		{
			(DataGridViewColumn)ID_ARTICLE,
			(DataGridViewColumn)REFERENCE,
			(DataGridViewColumn)Code,
			(DataGridViewColumn)Article,
			(DataGridViewColumn)Famille,
			(DataGridViewColumn)DATE_INVENTAIRE,
			(DataGridViewColumn)STOCK_INITIAL,
			(DataGridViewColumn)STOCK_RECEPT,
			(DataGridViewColumn)STOCK_SORTIE,
			(DataGridViewColumn)STOCK_VENDU,
			(DataGridViewColumn)STOCK_PREVU,
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
		((Control)DataGridView1).Dock = (DockStyle)5;
		DataGridView1.EditMode = (DataGridViewEditMode)4;
		DataGridView dataGridView = DataGridView1;
		location = new Point(200, 0);
		((Control)dataGridView).Location = location;
		((Control)DataGridView1).Name = "DataGridView1";
		DataGridView1.RowHeadersVisible = false;
		DataGridView1.RowHeadersWidth = 20;
		DataGridView dataGridView2 = DataGridView1;
		size = new Size(818, 589);
		((Control)dataGridView2).Size = size;
		((Control)DataGridView1).TabIndex = 1040;
		((DataGridViewColumn)ID_ARTICLE).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)ID_ARTICLE).DataPropertyName = "ID_ARTICLE";
		((DataGridViewColumn)ID_ARTICLE).HeaderText = "ID_ARTICLE";
		((DataGridViewColumn)ID_ARTICLE).MinimumWidth = 2;
		((DataGridViewColumn)ID_ARTICLE).Name = "ID_ARTICLE";
		((DataGridViewColumn)ID_ARTICLE).Width = 2;
		((DataGridViewColumn)REFERENCE).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)REFERENCE).DataPropertyName = "REFERENCE";
		((DataGridViewColumn)REFERENCE).HeaderText = "Référence";
		((DataGridViewColumn)REFERENCE).Name = "REFERENCE";
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
		((DataGridViewColumn)DATE_INVENTAIRE).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)DATE_INVENTAIRE).DataPropertyName = "DATE_INVENTAIRE";
		val4.Format = "d";
		val4.NullValue = null;
		((DataGridViewColumn)DATE_INVENTAIRE).DefaultCellStyle = val4;
		((DataGridViewColumn)DATE_INVENTAIRE).HeaderText = "Date Inventaire";
		((DataGridViewColumn)DATE_INVENTAIRE).Name = "DATE_INVENTAIRE";
		DATE_INVENTAIRE.SortMode = (DataGridViewColumnSortMode)2;
		((DataGridViewColumn)DATE_INVENTAIRE).Width = 80;
		((DataGridViewColumn)STOCK_INITIAL).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)STOCK_INITIAL).DataPropertyName = "STOCK_INITIAL";
		((DataGridViewColumn)STOCK_INITIAL).HeaderText = "STOCK INITIAL";
		((DataGridViewColumn)STOCK_INITIAL).Name = "STOCK_INITIAL";
		STOCK_INITIAL.SortMode = (DataGridViewColumnSortMode)2;
		((DataGridViewColumn)STOCK_INITIAL).Width = 60;
		((DataGridViewColumn)STOCK_RECEPT).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)STOCK_RECEPT).HeaderText = "STOCK RECEPT";
		((DataGridViewColumn)STOCK_RECEPT).Name = "STOCK_RECEPT";
		((DataGridViewColumn)STOCK_RECEPT).Width = 60;
		((DataGridViewColumn)STOCK_SORTIE).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)STOCK_SORTIE).HeaderText = "STOCK SORTIE";
		((DataGridViewColumn)STOCK_SORTIE).Name = "STOCK_SORTIE";
		((DataGridViewColumn)STOCK_SORTIE).Width = 60;
		((DataGridViewColumn)STOCK_VENDU).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)STOCK_VENDU).HeaderText = "STOCK VENDU";
		((DataGridViewColumn)STOCK_VENDU).Name = "STOCK_VENDU";
		((DataGridViewColumn)STOCK_VENDU).Width = 60;
		((DataGridViewColumn)STOCK_PREVU).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)STOCK_PREVU).HeaderText = "STOCK PREVU";
		((DataGridViewColumn)STOCK_PREVU).MinimumWidth = 2;
		((DataGridViewColumn)STOCK_PREVU).Name = "STOCK_PREVU";
		((DataGridViewColumn)STOCK_PREVU).Width = 60;
		((DataGridViewColumn)STOCK_ACTUEL).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)STOCK_ACTUEL).DataPropertyName = "STOCK";
		((DataGridViewColumn)STOCK_ACTUEL).HeaderText = "STOCK ACTUEL";
		((DataGridViewColumn)STOCK_ACTUEL).Name = "STOCK_ACTUEL";
		STOCK_ACTUEL.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)STOCK_ACTUEL).Width = 60;
		((DataGridViewColumn)Alert).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)Alert).DataPropertyName = "Alert";
		((DataGridViewColumn)Alert).FillWeight = 45.60068f;
		((DataGridViewColumn)Alert).HeaderText = "Alert";
		((DataGridViewColumn)Alert).MinimumWidth = 2;
		((DataGridViewColumn)Alert).Name = "Alert";
		Alert.SortMode = (DataGridViewColumnSortMode)2;
		((DataGridViewColumn)Alert).Width = 50;
		((Control)Button_PrintRapport).Anchor = (AnchorStyles)10;
		((Control)Button_PrintRapport).Cursor = Cursors.Hand;
		((Control)Button_PrintRapport).Font = new Font("Tahoma", 9f, (FontStyle)1);
		((ButtonBase)Button_PrintRapport).Image = (Image)componentResourceManager.GetObject("Button_PrintRapport.Image");
		((ButtonBase)Button_PrintRapport).ImageAlign = (ContentAlignment)16;
		Button button_PrintRapport = Button_PrintRapport;
		location = new Point(690, 644);
		((Control)button_PrintRapport).Location = location;
		((Control)Button_PrintRapport).Name = "Button_PrintRapport";
		Button button_PrintRapport2 = Button_PrintRapport;
		size = new Size(160, 37);
		((Control)button_PrintRapport2).Size = size;
		((Control)Button_PrintRapport).TabIndex = 1050;
		((ButtonBase)Button_PrintRapport).Text = "IMPRIMER";
		((ButtonBase)Button_PrintRapport).UseVisualStyleBackColor = true;
		((Control)Panel_FIND).Anchor = (AnchorStyles)13;
		((Control)Panel_FIND).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Panel_FIND).Controls.Add((Control)(object)Check_IGNORER_ZERO);
		((Control)Panel_FIND).Controls.Add((Control)(object)Check_FIND_EXACTE);
		((Control)Panel_FIND).Controls.Add((Control)(object)Panel8);
		Panel panel_FIND = Panel_FIND;
		location = new Point(143, 0);
		((Control)panel_FIND).Location = location;
		((Control)Panel_FIND).Name = "Panel_FIND";
		Panel panel_FIND2 = Panel_FIND;
		size = new Size(882, 30);
		((Control)panel_FIND2).Size = size;
		((Control)Panel_FIND).TabIndex = 1050;
		((ButtonBase)Check_IGNORER_ZERO).AutoSize = true;
		Check_IGNORER_ZERO.Checked = true;
		Check_IGNORER_ZERO.CheckState = (CheckState)1;
		((Control)Check_IGNORER_ZERO).Font = new Font("Tahoma", 9f);
		((Control)Check_IGNORER_ZERO).ForeColor = Color.White;
		CheckBox check_IGNORER_ZERO = Check_IGNORER_ZERO;
		location = new Point(342, 6);
		((Control)check_IGNORER_ZERO).Location = location;
		((Control)Check_IGNORER_ZERO).Name = "Check_IGNORER_ZERO";
		CheckBox check_IGNORER_ZERO2 = Check_IGNORER_ZERO;
		size = new Size(126, 18);
		((Control)check_IGNORER_ZERO2).Size = size;
		((Control)Check_IGNORER_ZERO).TabIndex = 1040;
		((ButtonBase)Check_IGNORER_ZERO).Text = "Ignorer stock zéro";
		((ButtonBase)Check_IGNORER_ZERO).UseVisualStyleBackColor = true;
		((ButtonBase)Check_FIND_EXACTE).AutoSize = true;
		((Control)Check_FIND_EXACTE).Font = new Font("Tahoma", 9f);
		((Control)Check_FIND_EXACTE).ForeColor = Color.White;
		CheckBox check_FIND_EXACTE = Check_FIND_EXACTE;
		location = new Point(263, 6);
		((Control)check_FIND_EXACTE).Location = location;
		((Control)Check_FIND_EXACTE).Name = "Check_FIND_EXACTE";
		CheckBox check_FIND_EXACTE2 = Check_FIND_EXACTE;
		size = new Size(63, 18);
		((Control)check_FIND_EXACTE2).Size = size;
		((Control)Check_FIND_EXACTE).TabIndex = 1038;
		((ButtonBase)Check_FIND_EXACTE).Text = "exacte";
		((ButtonBase)Check_FIND_EXACTE).UseVisualStyleBackColor = true;
		((Control)Panel8).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Panel8).BackgroundImageLayout = (ImageLayout)4;
		((Control)Panel8).Controls.Add((Control)(object)Combo_FIND);
		((Control)Panel8).Controls.Add((Control)(object)Picture_REFRESH);
		((Control)Panel8).Controls.Add((Control)(object)Picture_FIND);
		((Control)Panel8).Controls.Add((Control)(object)Text_FIND);
		((Control)Panel8).Controls.Add((Control)(object)Label14);
		((Control)Panel8).Controls.Add((Control)(object)Label21);
		((Control)Panel8).Controls.Add((Control)(object)Label22);
		((Control)Panel8).Controls.Add((Control)(object)Label23);
		Panel panel = Panel8;
		location = new Point(3, 3);
		((Control)panel).Location = location;
		((Control)Panel8).Name = "Panel8";
		Panel panel2 = Panel8;
		size = new Size(254, 24);
		((Control)panel2).Size = size;
		((Control)Panel8).TabIndex = 1035;
		Combo_FIND.BackColor = Color.FromArgb(22, 106, 238);
		Combo_FIND.DropDownStyle = (ComboBoxStyle)2;
		Combo_FIND.DropDownWidth = 100;
		Combo_FIND.FlatStyle = (FlatStyle)0;
		((Control)Combo_FIND).Font = new Font("Tahoma", 9f);
		Combo_FIND.ForeColor = Color.White;
		((ListControl)Combo_FIND).FormattingEnabled = true;
		Combo_FIND.Items.AddRange(new object[4] { "REFERENCE", "ARTICLE", "FOURNISSEUR", "MODE_STOCK" });
		ComboBox combo_FIND = Combo_FIND;
		location = new Point(0, 1);
		((Control)combo_FIND).Location = location;
		((Control)Combo_FIND).Name = "Combo_FIND";
		ComboBox combo_FIND2 = Combo_FIND;
		size = new Size(52, 22);
		((Control)combo_FIND2).Size = size;
		((Control)Combo_FIND).TabIndex = 1038;
		Picture_REFRESH.Image = (Image)componentResourceManager.GetObject("Picture_REFRESH.Image");
		PictureBox picture_REFRESH = Picture_REFRESH;
		location = new Point(220, 3);
		((Control)picture_REFRESH).Location = location;
		((Control)Picture_REFRESH).Name = "Picture_REFRESH";
		PictureBox picture_REFRESH2 = Picture_REFRESH;
		size = new Size(27, 19);
		((Control)picture_REFRESH2).Size = size;
		Picture_REFRESH.SizeMode = (PictureBoxSizeMode)4;
		Picture_REFRESH.TabIndex = 1037;
		Picture_REFRESH.TabStop = false;
		Picture_FIND.Image = (Image)componentResourceManager.GetObject("Picture_FIND.Image");
		PictureBox picture_FIND = Picture_FIND;
		location = new Point(187, 3);
		((Control)picture_FIND).Location = location;
		((Control)Picture_FIND).Name = "Picture_FIND";
		PictureBox picture_FIND2 = Picture_FIND;
		size = new Size(27, 19);
		((Control)picture_FIND2).Size = size;
		Picture_FIND.SizeMode = (PictureBoxSizeMode)4;
		Picture_FIND.TabIndex = 1038;
		Picture_FIND.TabStop = false;
		((TextBoxBase)Text_FIND).BackColor = Color.FromArgb(22, 106, 238);
		((TextBoxBase)Text_FIND).BorderStyle = (BorderStyle)0;
		((Control)Text_FIND).Font = new Font("Tahoma", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)Text_FIND).ForeColor = Color.White;
		TextBox text_FIND = Text_FIND;
		location = new Point(58, 5);
		((Control)text_FIND).Location = location;
		((Control)Text_FIND).Name = "Text_FIND";
		TextBox text_FIND2 = Text_FIND;
		size = new Size(123, 15);
		((Control)text_FIND2).Size = size;
		((Control)Text_FIND).TabIndex = 708;
		((Control)Label14).BackColor = Color.FromArgb(227, 227, 227);
		((Control)Label14).Cursor = Cursors.Hand;
		((Control)Label14).Dock = (DockStyle)2;
		((Control)Label14).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label14).ForeColor = Color.White;
		Label label = Label14;
		location = new Point(1, 23);
		((Control)label).Location = location;
		((Control)Label14).Name = "Label14";
		Label label2 = Label14;
		size = new Size(252, 1);
		((Control)label2).Size = size;
		((Control)Label14).TabIndex = 1000;
		Label14.TextAlign = (ContentAlignment)16;
		((Control)Label21).BackColor = Color.FromArgb(227, 227, 227);
		((Control)Label21).Cursor = Cursors.Hand;
		((Control)Label21).Dock = (DockStyle)3;
		((Control)Label21).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label21).ForeColor = Color.White;
		Label label3 = Label21;
		location = new Point(0, 1);
		((Control)label3).Location = location;
		((Control)Label21).Name = "Label21";
		Label label4 = Label21;
		size = new Size(1, 23);
		((Control)label4).Size = size;
		((Control)Label21).TabIndex = 999;
		Label21.TextAlign = (ContentAlignment)16;
		((Control)Label22).BackColor = Color.FromArgb(227, 227, 227);
		((Control)Label22).Cursor = Cursors.Hand;
		((Control)Label22).Dock = (DockStyle)4;
		((Control)Label22).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label22).ForeColor = Color.White;
		Label label5 = Label22;
		location = new Point(253, 1);
		((Control)label5).Location = location;
		((Control)Label22).Name = "Label22";
		Label label6 = Label22;
		size = new Size(1, 23);
		((Control)label6).Size = size;
		((Control)Label22).TabIndex = 998;
		Label22.TextAlign = (ContentAlignment)16;
		((Control)Label23).BackColor = Color.FromArgb(227, 227, 227);
		((Control)Label23).Cursor = Cursors.Hand;
		((Control)Label23).Dock = (DockStyle)1;
		((Control)Label23).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label23).ForeColor = Color.White;
		Label label7 = Label23;
		location = new Point(0, 0);
		((Control)label7).Location = location;
		((Control)Label23).Name = "Label23";
		Label label8 = Label23;
		size = new Size(254, 1);
		((Control)label8).Size = size;
		((Control)Label23).TabIndex = 997;
		Label23.Text = "-";
		Label23.TextAlign = (ContentAlignment)16;
		((Control)Button4).Anchor = (AnchorStyles)6;
		((ButtonBase)Button4).BackColor = Color.White;
		((Control)Button4).Cursor = Cursors.Hand;
		((Control)Button4).Font = new Font("Tahoma", 9f, (FontStyle)1);
		((Control)Button4).ForeColor = Color.FromArgb(64, 64, 64);
		((ButtonBase)Button4).Image = (Image)componentResourceManager.GetObject("Button4.Image");
		((ButtonBase)Button4).ImageAlign = (ContentAlignment)16;
		Button button = Button4;
		location = new Point(4, 644);
		((Control)button).Location = location;
		((Control)Button4).Name = "Button4";
		Button button2 = Button4;
		size = new Size(290, 37);
		((Control)button2).Size = size;
		((Control)Button4).TabIndex = 1057;
		((ButtonBase)Button4).Text = "Calculer les Mouvements de Stock";
		((ButtonBase)Button4).UseVisualStyleBackColor = true;
		((Control)Button14).Anchor = (AnchorStyles)10;
		((Control)Button14).Cursor = Cursors.Hand;
		((Control)Button14).Font = new Font("Tahoma", 9f, (FontStyle)1);
		((Control)Button14).ForeColor = SystemColors.ControlText;
		((ButtonBase)Button14).Image = (Image)componentResourceManager.GetObject("Button14.Image");
		((ButtonBase)Button14).ImageAlign = (ContentAlignment)16;
		Button button3 = Button14;
		location = new Point(853, 644);
		((Control)button3).Location = location;
		Button button4 = Button14;
		Padding margin = new Padding(0);
		((Control)button4).Margin = margin;
		((Control)Button14).Name = "Button14";
		Button button5 = Button14;
		size = new Size(160, 37);
		((Control)button5).Size = size;
		((Control)Button14).TabIndex = 1058;
		((ButtonBase)Button14).Text = "EXPORTER";
		((ButtonBase)Button14).UseVisualStyleBackColor = true;
		((Control)Panel1).Anchor = (AnchorStyles)15;
		Panel1.BorderStyle = (BorderStyle)2;
		((Control)Panel1).Controls.Add((Control)(object)DataGridView1);
		((Control)Panel1).Controls.Add((Control)(object)Panel119898);
		Panel panel3 = Panel1;
		location = new Point(2, 33);
		((Control)panel3).Location = location;
		((Control)Panel1).Name = "Panel1";
		Panel panel4 = Panel1;
		size = new Size(1022, 593);
		((Control)panel4).Size = size;
		((Control)Panel1).TabIndex = 1059;
		((Control)Panel119898).BackColor = Color.White;
		((Control)Panel119898).Controls.Add((Control)(object)DataGridView_FILTRAGE);
		((Control)Panel119898).Controls.Add((Control)(object)Panel2);
		((Control)Panel119898).Dock = (DockStyle)3;
		Panel panel5 = Panel119898;
		location = new Point(0, 0);
		((Control)panel5).Location = location;
		((Control)Panel119898).Name = "Panel119898";
		Panel panel6 = Panel119898;
		size = new Size(200, 589);
		((Control)panel6).Size = size;
		((Control)Panel119898).TabIndex = 1;
		DataGridView_FILTRAGE.AllowUserToAddRows = false;
		DataGridView_FILTRAGE.AllowUserToDeleteRows = false;
		DataGridView_FILTRAGE.AllowUserToResizeColumns = false;
		DataGridView_FILTRAGE.AllowUserToResizeRows = false;
		DataGridView_FILTRAGE.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)16;
		DataGridView_FILTRAGE.BackgroundColor = Color.White;
		DataGridView_FILTRAGE.BorderStyle = (BorderStyle)2;
		DataGridView_FILTRAGE.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		DataGridView_FILTRAGE.ColumnHeadersVisible = false;
		DataGridView_FILTRAGE.Columns.AddRange(new DataGridViewColumn[1] { (DataGridViewColumn)Column2 });
		((Control)DataGridView_FILTRAGE).Dock = (DockStyle)5;
		DataGridView_FILTRAGE.EditMode = (DataGridViewEditMode)4;
		DataGridView_FILTRAGE.EnableHeadersVisualStyles = false;
		DataGridView dataGridView_FILTRAGE = DataGridView_FILTRAGE;
		location = new Point(0, 43);
		((Control)dataGridView_FILTRAGE).Location = location;
		((Control)DataGridView_FILTRAGE).Name = "DataGridView_FILTRAGE";
		DataGridView_FILTRAGE.ReadOnly = true;
		DataGridView_FILTRAGE.RowHeadersVisible = false;
		val5.Font = new Font("Segoe UI", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		DataGridView_FILTRAGE.RowsDefaultCellStyle = val5;
		DataGridView_FILTRAGE.SelectionMode = (DataGridViewSelectionMode)1;
		DataGridView dataGridView_FILTRAGE2 = DataGridView_FILTRAGE;
		size = new Size(200, 546);
		((Control)dataGridView_FILTRAGE2).Size = size;
		((Control)DataGridView_FILTRAGE).TabIndex = 1049;
		((DataGridViewColumn)Column2).DataPropertyName = "FAMILLE";
		val6.Alignment = (DataGridViewContentAlignment)16;
		val6.BackColor = Color.White;
		val6.Font = new Font("Segoe UI", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val6.SelectionBackColor = Color.Yellow;
		val6.SelectionForeColor = Color.Black;
		val6.WrapMode = (DataGridViewTriState)1;
		Column2.DefaultCellStyle = val6;
		((DataGridViewColumn)Column2).HeaderText = "Column2";
		((DataGridViewColumn)Column2).Name = "Column2";
		((DataGridViewColumn)Column2).ReadOnly = true;
		((DataGridViewColumn)Column2).Resizable = (DataGridViewTriState)1;
		((DataGridViewColumn)Column2).SortMode = (DataGridViewColumnSortMode)1;
		((Control)Panel2).Controls.Add((Control)(object)Button_RJ38787);
		((Control)Panel2).Controls.Add((Control)(object)Button_RJ16576);
		((Control)Panel2).Controls.Add((Control)(object)Panel4);
		((Control)Panel2).Dock = (DockStyle)1;
		Panel panel7 = Panel2;
		location = new Point(0, 0);
		((Control)panel7).Location = location;
		((Control)Panel2).Name = "Panel2";
		Panel panel8 = Panel2;
		size = new Size(200, 43);
		((Control)panel8).Size = size;
		((Control)Panel2).TabIndex = 1;
		Button_RJ38787._BackgroundColor = Color.FromArgb(22, 106, 238);
		Button_RJ38787._BorderColor = Color.FromArgb(22, 106, 238);
		Button_RJ38787._BorderRadius = 16;
		Button_RJ38787._BorderSize = 1;
		Button_RJ38787._TextColor = Color.White;
		((ButtonBase)Button_RJ38787).BackColor = Color.FromArgb(22, 106, 238);
		((ButtonBase)Button_RJ38787).FlatAppearance.BorderSize = 0;
		((ButtonBase)Button_RJ38787).FlatStyle = (FlatStyle)0;
		((Control)Button_RJ38787).ForeColor = Color.White;
		((ButtonBase)Button_RJ38787).Image = (Image)componentResourceManager.GetObject("Button_RJ38787.Image");
		((ButtonBase)Button_RJ38787).ImeMode = (ImeMode)0;
		Button_RJ button_RJ = Button_RJ38787;
		location = new Point(164, 4);
		((Control)button_RJ).Location = location;
		((Control)Button_RJ38787).Name = "Button_RJ38787";
		Button_RJ button_RJ2 = Button_RJ38787;
		size = new Size(33, 33);
		((Control)button_RJ2).Size = size;
		((Control)Button_RJ38787).TabIndex = 1056;
		((ButtonBase)Button_RJ38787).UseVisualStyleBackColor = false;
		Button_RJ16576._BackgroundColor = Color.FromArgb(22, 106, 238);
		Button_RJ16576._BorderColor = Color.FromArgb(22, 106, 238);
		Button_RJ16576._BorderRadius = 16;
		Button_RJ16576._BorderSize = 1;
		Button_RJ16576._TextColor = Color.White;
		((ButtonBase)Button_RJ16576).BackColor = Color.FromArgb(22, 106, 238);
		((ButtonBase)Button_RJ16576).FlatAppearance.BorderSize = 0;
		((ButtonBase)Button_RJ16576).FlatStyle = (FlatStyle)0;
		((Control)Button_RJ16576).ForeColor = Color.White;
		((ButtonBase)Button_RJ16576).Image = (Image)componentResourceManager.GetObject("Button_RJ16576.Image");
		((ButtonBase)Button_RJ16576).ImeMode = (ImeMode)0;
		Button_RJ button_RJ3 = Button_RJ16576;
		location = new Point(129, 4);
		((Control)button_RJ3).Location = location;
		((Control)Button_RJ16576).Name = "Button_RJ16576";
		Button_RJ button_RJ4 = Button_RJ16576;
		size = new Size(33, 33);
		((Control)button_RJ4).Size = size;
		((Control)Button_RJ16576).TabIndex = 1;
		((ButtonBase)Button_RJ16576).UseVisualStyleBackColor = false;
		((Control)Panel4).BackColor = Color.White;
		((Control)Panel4).BackgroundImageLayout = (ImageLayout)4;
		((Control)Panel4).Controls.Add((Control)(object)TextBox14343);
		((Control)Panel4).Controls.Add((Control)(object)Label55);
		((Control)Panel4).Controls.Add((Control)(object)Label56);
		((Control)Panel4).Controls.Add((Control)(object)Label57);
		((Control)Panel4).Controls.Add((Control)(object)Label58);
		Panel panel9 = Panel4;
		location = new Point(3, 9);
		((Control)panel9).Location = location;
		((Control)Panel4).Name = "Panel4";
		Panel panel10 = Panel4;
		size = new Size(125, 24);
		((Control)panel10).Size = size;
		((Control)Panel4).TabIndex = 1055;
		((TextBoxBase)TextBox14343).BackColor = Color.White;
		((TextBoxBase)TextBox14343).BorderStyle = (BorderStyle)0;
		((Control)TextBox14343).Font = new Font("Tahoma", 9f);
		((TextBoxBase)TextBox14343).ForeColor = Color.Black;
		TextBox textBox = TextBox14343;
		location = new Point(5, 5);
		((Control)textBox).Location = location;
		((Control)TextBox14343).Name = "TextBox14343";
		TextBox textBox2 = TextBox14343;
		size = new Size(113, 15);
		((Control)textBox2).Size = size;
		((Control)TextBox14343).TabIndex = 708;
		((Control)Label55).BackColor = Color.FromArgb(227, 227, 227);
		((Control)Label55).Cursor = Cursors.Hand;
		((Control)Label55).Dock = (DockStyle)2;
		((Control)Label55).Font = new Font("Tahoma", 9f, (FontStyle)1);
		((Control)Label55).ForeColor = Color.White;
		Label55.ImeMode = (ImeMode)0;
		Label label9 = Label55;
		location = new Point(1, 23);
		((Control)label9).Location = location;
		((Control)Label55).Name = "Label55";
		Label label10 = Label55;
		size = new Size(123, 1);
		((Control)label10).Size = size;
		((Control)Label55).TabIndex = 1000;
		Label55.TextAlign = (ContentAlignment)16;
		((Control)Label56).BackColor = Color.FromArgb(227, 227, 227);
		((Control)Label56).Cursor = Cursors.Hand;
		((Control)Label56).Dock = (DockStyle)3;
		((Control)Label56).Font = new Font("Tahoma", 9f, (FontStyle)1);
		((Control)Label56).ForeColor = Color.White;
		Label56.ImeMode = (ImeMode)0;
		Label label11 = Label56;
		location = new Point(0, 1);
		((Control)label11).Location = location;
		((Control)Label56).Name = "Label56";
		Label label12 = Label56;
		size = new Size(1, 23);
		((Control)label12).Size = size;
		((Control)Label56).TabIndex = 999;
		Label56.TextAlign = (ContentAlignment)16;
		((Control)Label57).BackColor = Color.FromArgb(227, 227, 227);
		((Control)Label57).Cursor = Cursors.Hand;
		((Control)Label57).Dock = (DockStyle)4;
		((Control)Label57).Font = new Font("Tahoma", 9f, (FontStyle)1);
		((Control)Label57).ForeColor = Color.White;
		Label57.ImeMode = (ImeMode)0;
		Label label13 = Label57;
		location = new Point(124, 1);
		((Control)label13).Location = location;
		((Control)Label57).Name = "Label57";
		Label label14 = Label57;
		size = new Size(1, 23);
		((Control)label14).Size = size;
		((Control)Label57).TabIndex = 998;
		Label57.TextAlign = (ContentAlignment)16;
		((Control)Label58).BackColor = Color.FromArgb(227, 227, 227);
		((Control)Label58).Cursor = Cursors.Hand;
		((Control)Label58).Dock = (DockStyle)1;
		((Control)Label58).Font = new Font("Tahoma", 9f, (FontStyle)1);
		((Control)Label58).ForeColor = Color.White;
		Label58.ImeMode = (ImeMode)0;
		Label label15 = Label58;
		location = new Point(0, 0);
		((Control)label15).Location = location;
		((Control)Label58).Name = "Label58";
		Label label16 = Label58;
		size = new Size(125, 1);
		((Control)label16).Size = size;
		((Control)Label58).TabIndex = 997;
		Label58.Text = "-";
		Label58.TextAlign = (ContentAlignment)16;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).BackColor = Color.White;
		size = new Size(1025, 692);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)Panel1);
		((Control)this).Controls.Add((Control)(object)Button14);
		((Control)this).Controls.Add((Control)(object)Button4);
		((Control)this).Controls.Add((Control)(object)Panel_FIND);
		((Control)this).Controls.Add((Control)(object)Label_TABLE);
		((Control)this).Controls.Add((Control)(object)Button_PrintRapport);
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Form)this).KeyPreview = true;
		((Control)this).Name = "FormDialog_ETAT_STOCK";
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).WindowState = (FormWindowState)2;
		((ISupportInitialize)DataGridView1).EndInit();
		((Control)Panel_FIND).ResumeLayout(false);
		((Control)Panel_FIND).PerformLayout();
		((Control)Panel8).ResumeLayout(false);
		((Control)Panel8).PerformLayout();
		((ISupportInitialize)Picture_REFRESH).EndInit();
		((ISupportInitialize)Picture_FIND).EndInit();
		((Control)Panel1).ResumeLayout(false);
		((Control)Panel119898).ResumeLayout(false);
		((ISupportInitialize)DataGridView_FILTRAGE).EndInit();
		((Control)Panel2).ResumeLayout(false);
		((Control)Panel4).ResumeLayout(false);
		((Control)Panel4).PerformLayout();
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
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Expected Obj, but got Unknown
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Expected Obj, but got Unknown
		//IL_03ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f5: Expected Obj, but got Unknown
		//IL_031a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Expected Obj, but got Unknown
		checked
		{
			try
			{
				Combo_FIND.SelectedIndex = 0;
				DataGridView1.AutoGenerateColumns = false;
				DataGridView1.RowTemplate.Height = 15;
				DataGridView1.DataSource = _DT_TEMP;
				DataGridView1.BackgroundColor = Color.White;
				DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(34, 34, 34);
				DataGridView1.DefaultCellStyle.SelectionBackColor = Color.Yellow;
				DataGridView1.DefaultCellStyle.SelectionForeColor = Color.Red;
				DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(221, 235, 247);
				DataGridView1.GridColor = Color.FromArgb(231, 231, 231);
				DataGridView1.EnableHeadersVisualStyles = false;
				((DataGridViewCell)DataGridView1.Columns[5].HeaderCell).Style.BackColor = Color.Yellow;
				((DataGridViewCell)DataGridView1.Columns[6].HeaderCell).Style.BackColor = Color.Yellow;
				((DataGridViewCell)DataGridView1.Columns[7].HeaderCell).Style.BackColor = Color.Yellow;
				((DataGridViewCell)DataGridView1.Columns[8].HeaderCell).Style.BackColor = Color.Yellow;
				((DataGridViewCell)DataGridView1.Columns[10].HeaderCell).Style.BackColor = Color.Tomato;
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
				_DT_TEMP.Clear();
				((Control)Panel119898).Width = 200;
				_DT_FAMILLE_FILTRAGE.Clear();
				_DA_FAMILLE_FILTRAGE = new MySqlDataAdapter("select FAMILLE from     TABLE_FAMILLES          order by  FAMILLE    asc ", Module1.cn_SQL);
				((DbDataAdapter)(object)_DA_FAMILLE_FILTRAGE).Fill(_DT_FAMILLE_FILTRAGE);
				DataGridView_FILTRAGE.RowTemplate.Height = 40;
				DataGridView_FILTRAGE.DataSource = _DT_FAMILLE_FILTRAGE;
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

	private void Button1_Click(object sender, EventArgs e)
	{
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

	private void Button_PRINT_A4_Click(object sender, EventArgs e)
	{
	}

	private void Text_FIND_TextChanged(object sender, EventArgs e)
	{
		Picture_FIND_Click(RuntimeHelpers.GetObjectValue(sender), e);
	}

	private void Picture_FIND_Click(object sender, EventArgs e)
	{
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Expected Obj, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected Obj, but got Unknown
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected Obj, but got Unknown
		try
		{
			string text = "";
			if (Check_IGNORER_ZERO.Checked)
			{
				text = "AND   STOCK <> 0";
			}
			if (!Check_FIND_EXACTE.Checked)
			{
				_DT_TEMP.Clear();
				_DA_TEMP = new MySqlDataAdapter("select * from     TABLE_ARTICLES      Where          (" + Combo_FIND.Text + "  like  '%" + Text_FIND.Text + "%'   )                " + text + "                          order by   ID    desc ", Module1.cn_SQL);
				((DbDataAdapter)(object)_DA_TEMP).Fill(_DT_TEMP);
			}
			else if (Check_FIND_EXACTE.Checked)
			{
				_DT_TEMP.Clear();
				_DA_TEMP = new MySqlDataAdapter("select * from     TABLE_ARTICLES      Where          (" + Combo_FIND.Text + "  like  '" + Text_FIND.Text + "'     )                   " + text + "                       order by   ID    desc ", Module1.cn_SQL);
				((DbDataAdapter)(object)_DA_TEMP).Fill(_DT_TEMP);
			}
			DataGridView1.DataSource = _DT_TEMP;
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
				string text2 = Strings.Format(DateTime.Now, "yyMMddHHmmssfff");
				Bitmap val = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, (PixelFormat)2498570);
				Graphics val2 = Graphics.FromImage((Image)(object)val);
				val2.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, (CopyPixelOperation)13369376);
				((Image)val).Save(Application.StartupPath + "\\tchak\\" + text2 + ".snidb", ImageFormat.Jpeg);
				val = null;
				string right = "ERROR | ";
				File.AppendAllText(Application.StartupPath + "\\log_erreur.sni", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(text2 + " | ", MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text), " | "), Module1._USERNAME), " | "), ((Control)this).Name), " | "), NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null)), " | "), right), " | "), ex2.ToString()), "\r\n"), "Ligne : "), fileLineNumber), "\r\n"), "\r\n"), "##########################################################################################################"), "\r\n")), Encoding.UTF8);
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

	private void Picture_REFRESH_Click(object sender, EventArgs e)
	{
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected Obj, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		try
		{
			Text_FIND.Text = "";
			string text = "";
			if (Check_IGNORER_ZERO.Checked)
			{
				text = "WHERE   STOCK <> 0";
			}
			_DT_TEMP.Clear();
			_DA_TEMP = new MySqlDataAdapter("select * from      TABLE_ARTICLES              " + text + "               order by   ID    desc ", Module1.cn_SQL);
			((DbDataAdapter)(object)_DA_TEMP).Fill(_DT_TEMP);
			DataGridView1.DataSource = _DT_TEMP;
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
				string text2 = Strings.Format(DateTime.Now, "yyMMddHHmmssfff");
				Bitmap val = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, (PixelFormat)2498570);
				Graphics val2 = Graphics.FromImage((Image)(object)val);
				val2.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, (CopyPixelOperation)13369376);
				((Image)val).Save(Application.StartupPath + "\\tchak\\" + text2 + ".snidb", ImageFormat.Jpeg);
				val = null;
				string right = "ERROR | ";
				File.AppendAllText(Application.StartupPath + "\\log_erreur.sni", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(text2 + " | ", MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text), " | "), Module1._USERNAME), " | "), ((Control)this).Name), " | "), NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null)), " | "), right), " | "), ex2.ToString()), "\r\n"), "Ligne : "), fileLineNumber), "\r\n"), "\r\n"), "##########################################################################################################"), "\r\n")), Encoding.UTF8);
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

	private void Combo_FIND_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	private void Button3_Click(object sender, EventArgs e)
	{
	}

	private void Button4_Click(object sender, EventArgs e)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected Obj, but got Unknown
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected Obj, but got Unknown
		//IL_02af: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Expected Obj, but got Unknown
		//IL_0435: Unknown result type (might be due to invalid IL or missing references)
		//IL_043b: Expected Obj, but got Unknown
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
					val = new MySqlDataAdapter("SELECT    SUM(Qté)      as N          FROM   TABLE_RECEPTIONS_DETAILS     WHERE   Dates   between   ' " + Strings.Format(Conversions.ToDate(DataGridView1.Rows[num2].Cells["DATE_INVENTAIRE"].Value.ToString()), "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTime.Now.Date, "yyyy-MM-dd") + " '         AND          ID_ARTICLE   =  '" + DataGridView1.Rows[num2].Cells["ID_ARTICLE"].Value.ToString() + "'      AND     ETAT='VALIDER'   ", Module1.cn_SQL);
					((DbDataAdapter)(object)val).Fill(dataTable);
					if (dataTable.Rows[0]["N"] == DBNull.Value)
					{
						DataGridView1.Rows[num2].Cells["STOCK_RECEPT"].Value = 0.0;
					}
					else
					{
						DataGridView1.Rows[num2].Cells["STOCK_RECEPT"].Value = Conversions.ToDouble(dataTable.Rows[0]["N"]);
					}
					dataTable.Clear();
					val = new MySqlDataAdapter("SELECT    SUM(Qté)      as N          FROM   TABLE_SORTIES_DETAILS     WHERE   Dates   between   ' " + Strings.Format(Conversions.ToDate(DataGridView1.Rows[num2].Cells["DATE_INVENTAIRE"].Value.ToString()), "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTime.Now.Date, "yyyy-MM-dd") + " '         AND          ID_ARTICLE   =  '" + DataGridView1.Rows[num2].Cells["ID_ARTICLE"].Value.ToString() + "'          AND     ETAT='VALIDER'     ", Module1.cn_SQL);
					((DbDataAdapter)(object)val).Fill(dataTable);
					if (dataTable.Rows[0]["N"] == DBNull.Value)
					{
						DataGridView1.Rows[num2].Cells["STOCK_SORTIE"].Value = 0.0;
					}
					else
					{
						DataGridView1.Rows[num2].Cells["STOCK_SORTIE"].Value = Conversions.ToDouble(dataTable.Rows[0]["N"]);
					}
					dataTable.Clear();
					val = new MySqlDataAdapter("SELECT    SUM(Qté)      as N          FROM   TABLE_VENTES_JOURNAL     WHERE   Dates   between   ' " + Strings.Format(Conversions.ToDate(DataGridView1.Rows[num2].Cells["DATE_INVENTAIRE"].Value.ToString()), "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTime.Now.Date, "yyyy-MM-dd") + " '         AND          ID_ARTICLE   =  '" + DataGridView1.Rows[num2].Cells["ID_ARTICLE"].Value.ToString() + "'         ", Module1.cn_SQL);
					((DbDataAdapter)(object)val).Fill(dataTable);
					if (dataTable.Rows[0]["N"] == DBNull.Value)
					{
						DataGridView1.Rows[num2].Cells["STOCK_VENDU"].Value = 0.0;
					}
					else
					{
						DataGridView1.Rows[num2].Cells["STOCK_VENDU"].Value = Conversions.ToDouble(dataTable.Rows[0]["N"]);
					}
					DataGridView1.Rows[num2].Cells["STOCK_PREVU"].Value = Operators.SubtractObject(Operators.AddObject(Operators.AddObject(DataGridView1.Rows[num2].Cells["STOCK_INITIAL"].Value, DataGridView1.Rows[num2].Cells["STOCK_RECEPT"].Value), DataGridView1.Rows[num2].Cells["STOCK_SORTIE"].Value), DataGridView1.Rows[num2].Cells["STOCK_VENDU"].Value);
					num2++;
				}
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

	private void Picture_EXPORT_Click(object sender, EventArgs e)
	{
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected Obj, but got Unknown
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Invalid comparison between Unknown and I4
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Expected Obj, but got Unknown
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Expected Obj, but got Unknown
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Expected Obj, but got Unknown
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected Obj, but got Unknown
		try
		{
			DataGridView1.Columns[4].ValueType = typeof(string);
			DataGridView1.Columns[5].ValueType = typeof(string);
			DataGridView1.Columns[6].ValueType = typeof(string);
			DataGridView1.Columns[7].ValueType = typeof(string);
			DataGridView1.Columns[8].ValueType = typeof(string);
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

	private void TextBox14343_TextChanged(object sender, EventArgs e)
	{
		Button_RJ16576_Click(RuntimeHelpers.GetObjectValue(sender), e);
	}

	private void Button_RJ16576_Click(object sender, EventArgs e)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected Obj, but got Unknown
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected Obj, but got Unknown
		try
		{
			_DT_FAMILLE_FILTRAGE.Clear();
			_DA_FAMILLE_FILTRAGE = new MySqlDataAdapter("select FAMILLE from     TABLE_FAMILLES      Where          (FAMILLE  like  '%" + TextBox14343.Text + "%'   )                                order by  FAMILLE    asc ", Module1.cn_SQL);
			((DbDataAdapter)(object)_DA_FAMILLE_FILTRAGE).Fill(_DT_FAMILLE_FILTRAGE);
			DataGridView_FILTRAGE.RowTemplate.Height = 40;
			DataGridView_FILTRAGE.DataSource = _DT_FAMILLE_FILTRAGE;
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

	private void Button_RJ38787_Click(object sender, EventArgs e)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected Obj, but got Unknown
		try
		{
			TextBox14343.Text = "";
			_DT_FAMILLE_FILTRAGE.Clear();
			_DA_FAMILLE_FILTRAGE = new MySqlDataAdapter("select   FAMILLE    from      TABLE_FAMILLES                  order by   FAMILLE    asc ", Module1.cn_SQL);
			((DbDataAdapter)(object)_DA_FAMILLE_FILTRAGE).Fill(_DT_FAMILLE_FILTRAGE);
			DataGridView_FILTRAGE.DataSource = _DT_FAMILLE_FILTRAGE;
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

	private void DataGridView_FILTRAGE_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
	}

	private void DataGridView_FILTRAGE_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected Obj, but got Unknown
		try
		{
			string right = "";
			if (Check_IGNORER_ZERO.Checked)
			{
				right = "AND   STOCK <> 0";
			}
			_DT_TEMP.Clear();
			_DA_TEMP = new MySqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select * from TABLE_ARTICLES WHERE Famille =  '", DataGridView_FILTRAGE.Rows[((DataGridViewBand)DataGridView_FILTRAGE.CurrentRow).Index].Cells[0].Value), "'       "), right), "           order by        Famille,Article      asc")), Module1.cn_SQL);
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
