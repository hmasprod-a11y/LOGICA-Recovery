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
using LOGICA.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace LOGICA;

[DesignerGenerated]
public class Form_6_DEPENSES : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("DataGridView1")]
	private DataGridView _DataGridView1;

	[AccessedThroughProperty("ListBox1")]
	private ListBox _ListBox1;

	[AccessedThroughProperty("FlowLayoutPanel1")]
	private FlowLayoutPanel _FlowLayoutPanel1;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("Label_TABLE")]
	private Label _Label_TABLE;

	[AccessedThroughProperty("Panel_INFO")]
	private Panel _Panel_INFO;

	[AccessedThroughProperty("Label_BOTTOM")]
	private Label _Label_BOTTOM;

	[AccessedThroughProperty("Label_LEFT")]
	private Label _Label_LEFT;

	[AccessedThroughProperty("Label_RIGHT")]
	private Label _Label_RIGHT;

	[AccessedThroughProperty("Label_INDEX")]
	private Label _Label_INDEX;

	[AccessedThroughProperty("Label_TOP")]
	private Label _Label_TOP;

	[AccessedThroughProperty("Button_CLOSE")]
	private Button _Button_CLOSE;

	[AccessedThroughProperty("Button_SAVE")]
	private Button _Button_SAVE;

	[AccessedThroughProperty("TabControl1")]
	private TabControl _TabControl1;

	[AccessedThroughProperty("TabPage1")]
	private TabPage _TabPage1;

	[AccessedThroughProperty("DateTimePicker_DATE")]
	private DateTimePicker _DateTimePicker_DATE;

	[AccessedThroughProperty("Label10")]
	private Label _Label10;

	[AccessedThroughProperty("Text_ID")]
	private TextBox _Text_ID;

	[AccessedThroughProperty("Text_MONTANT")]
	private TextBox _Text_MONTANT;

	[AccessedThroughProperty("Text_DEPENSE")]
	private TextBox _Text_DEPENSE;

	[AccessedThroughProperty("Label12")]
	private Label _Label12;

	[AccessedThroughProperty("Text_UTILISATEUR")]
	private TextBox _Text_UTILISATEUR;

	[AccessedThroughProperty("Label13")]
	private Label _Label13;

	[AccessedThroughProperty("Label16")]
	private Label _Label16;

	[AccessedThroughProperty("Button_ADD")]
	private Button _Button_ADD;

	[AccessedThroughProperty("Panel_FIND")]
	private Panel _Panel_FIND;

	[AccessedThroughProperty("Panel_DATES")]
	private Panel _Panel_DATES;

	[AccessedThroughProperty("DateTime1_FIND")]
	private DateTimePicker _DateTime1_FIND;

	[AccessedThroughProperty("Picture_FIND_DATES")]
	private PictureBox _Picture_FIND_DATES;

	[AccessedThroughProperty("DateTime2_FIND")]
	private DateTimePicker _DateTime2_FIND;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	[AccessedThroughProperty("Check_FIND_DATE")]
	private CheckBox _Check_FIND_DATE;

	[AccessedThroughProperty("Check_FIND_EXACTE")]
	private CheckBox _Check_FIND_EXACTE;

	[AccessedThroughProperty("Panel2")]
	private Panel _Panel2;

	[AccessedThroughProperty("Combo_FIND")]
	private ComboBox _Combo_FIND;

	[AccessedThroughProperty("Picture_REFRESH")]
	private PictureBox _Picture_REFRESH;

	[AccessedThroughProperty("Picture_FIND")]
	private PictureBox _Picture_FIND;

	[AccessedThroughProperty("Text_FIND")]
	private TextBox _Text_FIND;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Label14")]
	private Label _Label14;

	[AccessedThroughProperty("Label15")]
	private Label _Label15;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label4141")]
	private Label _Label4141;

	[AccessedThroughProperty("Text_PRINTER_CL")]
	private TextBox _Text_PRINTER_CL;

	[AccessedThroughProperty("Button_PrintRapport")]
	private Button _Button_PrintRapport;

	[AccessedThroughProperty("Button_ConsRapport")]
	private Button _Button_ConsRapport;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Label9")]
	private Label _Label9;

	[AccessedThroughProperty("Button_OK")]
	private Button _Button_OK;

	[AccessedThroughProperty("DateTimePicker2")]
	private DateTimePicker _DateTimePicker2;

	[AccessedThroughProperty("DateTimePicker1")]
	private DateTimePicker _DateTimePicker1;

	[AccessedThroughProperty("Print_DEPENSES")]
	private PrintDocument _Print_DEPENSES;

	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	[AccessedThroughProperty("DataGridView2")]
	private DataGridView _DataGridView2;

	[AccessedThroughProperty("COL_1")]
	private DataGridViewTextBoxColumn _COL_1;

	[AccessedThroughProperty("COL_2")]
	private DataGridViewTextBoxColumn _COL_2;

	[AccessedThroughProperty("COL_3")]
	private DataGridViewTextBoxColumn _COL_3;

	[AccessedThroughProperty("Picture_EXPORT")]
	private PictureBox _Picture_EXPORT;

	[AccessedThroughProperty("Button24")]
	private Button _Button24;

	[AccessedThroughProperty("Panel_CLAVIER")]
	private Panel _Panel_CLAVIER;

	[AccessedThroughProperty("TableLayoutPanel2")]
	private TableLayoutPanel _TableLayoutPanel2;

	[AccessedThroughProperty("Butt_")]
	private Button_CLAVIER_NOSELECT _Butt_;

	[AccessedThroughProperty("Butt_1")]
	private Button_CLAVIER_NOSELECT _Butt_1;

	[AccessedThroughProperty("Butt_2")]
	private Button_CLAVIER_NOSELECT _Butt_2;

	[AccessedThroughProperty("Butt_3")]
	private Button_CLAVIER_NOSELECT _Butt_3;

	[AccessedThroughProperty("Butt_4")]
	private Button_CLAVIER_NOSELECT _Butt_4;

	[AccessedThroughProperty("Butt_5")]
	private Button_CLAVIER_NOSELECT _Butt_5;

	[AccessedThroughProperty("Butt_6")]
	private Button_CLAVIER_NOSELECT _Butt_6;

	[AccessedThroughProperty("Butt_7")]
	private Button_CLAVIER_NOSELECT _Butt_7;

	[AccessedThroughProperty("Butt_8")]
	private Button_CLAVIER_NOSELECT _Butt_8;

	[AccessedThroughProperty("Butt_0")]
	private Button_CLAVIER_NOSELECT _Butt_0;

	[AccessedThroughProperty("Butt_9")]
	private Button_CLAVIER_NOSELECT _Butt_9;

	[AccessedThroughProperty("Butt_DOT")]
	private Button_CLAVIER_NOSELECT _Butt_DOT;

	[AccessedThroughProperty("TableLayoutPanel1")]
	private TableLayoutPanel _TableLayoutPanel1;

	[AccessedThroughProperty("Butt_DRAFT")]
	private Button_CLAVIER_NOSELECT _Butt_DRAFT;

	[AccessedThroughProperty("Butt_BACK")]
	private Button_CLAVIER_NOSELECT _Butt_BACK;

	[AccessedThroughProperty("Dates")]
	private DataGridViewTextBoxColumn _Dates;

	[AccessedThroughProperty("UTILISATEUR")]
	private DataGridViewTextBoxColumn _UTILISATEUR;

	[AccessedThroughProperty("DEPENSE")]
	private DataGridViewTextBoxColumn _DEPENSE;

	[AccessedThroughProperty("Montant")]
	private DataGridViewTextBoxColumn _Montant;

	[AccessedThroughProperty("supp")]
	private DataGridViewImageColumn _supp;

	[AccessedThroughProperty("Button_CLAVIER")]
	private Button_CLAVIER_NOSELECT _Button_CLAVIER;

	private MySqlDataAdapter DA;

	private DataTable DT;

	private int x;

	private int y;

	private Point newpoint;

	private object _sql;

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
			DataGridViewCellEventHandler val = DataGridView1_CellClick;
			DataGridViewCellEventHandler val2 = DataGridView1_CellContentClick;
			if (_DataGridView1 != null)
			{
				_DataGridView1.CellClick -= val;
				_DataGridView1.CellContentClick -= val2;
			}
			_DataGridView1 = value;
			if (_DataGridView1 != null)
			{
				_DataGridView1.CellClick += val;
				_DataGridView1.CellContentClick += val2;
			}
		}
	}

	internal virtual ListBox ListBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ListBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ListBox1 = value;
		}
	}

	internal virtual FlowLayoutPanel FlowLayoutPanel1
	{
		[DebuggerNonUserCode]
		get
		{
			return _FlowLayoutPanel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_FlowLayoutPanel1 = value;
		}
	}

	internal virtual Label Label5
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label5 = value;
		}
	}

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

	internal virtual Panel Panel_INFO
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel_INFO;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel_INFO = value;
		}
	}

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

	internal virtual Label Label_INDEX
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_INDEX;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_INDEX = value;
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
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			MouseEventHandler val = Label_TOP_MouseMove;
			MouseEventHandler val2 = Label_TOP_MouseDown;
			if (_Label_TOP != null)
			{
				((Control)_Label_TOP).MouseMove -= val;
				((Control)_Label_TOP).MouseDown -= val2;
			}
			_Label_TOP = value;
			if (_Label_TOP != null)
			{
				((Control)_Label_TOP).MouseMove += val;
				((Control)_Label_TOP).MouseDown += val2;
			}
		}
	}

	internal virtual Button Button_CLOSE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_CLOSE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_CLOSE_Click;
			if (_Button_CLOSE != null)
			{
				((Control)_Button_CLOSE).Click -= eventHandler;
			}
			_Button_CLOSE = value;
			if (_Button_CLOSE != null)
			{
				((Control)_Button_CLOSE).Click += eventHandler;
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

	internal virtual TabControl TabControl1
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabControl1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabControl1 = value;
		}
	}

	internal virtual TabPage TabPage1
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabPage1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabPage1 = value;
		}
	}

	internal virtual DateTimePicker DateTimePicker_DATE
	{
		[DebuggerNonUserCode]
		get
		{
			return _DateTimePicker_DATE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DateTimePicker_DATE = value;
		}
	}

	internal virtual Label Label10
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label10 = value;
		}
	}

	internal virtual TextBox Text_ID
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_ID;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_ID = value;
		}
	}

	internal virtual TextBox Text_MONTANT
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_MONTANT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			EventHandler eventHandler = Text_TEL_TextChanged;
			KeyPressEventHandler val = Text_TEL_KeyPress;
			if (_Text_MONTANT != null)
			{
				((Control)_Text_MONTANT).TextChanged -= eventHandler;
				((Control)_Text_MONTANT).KeyPress -= val;
			}
			_Text_MONTANT = value;
			if (_Text_MONTANT != null)
			{
				((Control)_Text_MONTANT).TextChanged += eventHandler;
				((Control)_Text_MONTANT).KeyPress += val;
			}
		}
	}

	internal virtual TextBox Text_DEPENSE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_DEPENSE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			KeyPressEventHandler val = Text_DEPENSE_KeyPress;
			if (_Text_DEPENSE != null)
			{
				((Control)_Text_DEPENSE).KeyPress -= val;
			}
			_Text_DEPENSE = value;
			if (_Text_DEPENSE != null)
			{
				((Control)_Text_DEPENSE).KeyPress += val;
			}
		}
	}

	internal virtual Label Label12
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label12 = value;
		}
	}

	internal virtual TextBox Text_UTILISATEUR
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_UTILISATEUR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_UTILISATEUR = value;
		}
	}

	internal virtual Label Label13
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label13 = value;
		}
	}

	internal virtual Label Label16
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label16;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label16 = value;
		}
	}

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

	internal virtual Panel Panel_DATES
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel_DATES;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel_DATES = value;
		}
	}

	internal virtual DateTimePicker DateTime1_FIND
	{
		[DebuggerNonUserCode]
		get
		{
			return _DateTime1_FIND;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DateTime1_FIND = value;
		}
	}

	internal virtual PictureBox Picture_FIND_DATES
	{
		[DebuggerNonUserCode]
		get
		{
			return _Picture_FIND_DATES;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Picture_FIND_DATES_Click;
			if (_Picture_FIND_DATES != null)
			{
				((Control)_Picture_FIND_DATES).Click -= eventHandler;
			}
			_Picture_FIND_DATES = value;
			if (_Picture_FIND_DATES != null)
			{
				((Control)_Picture_FIND_DATES).Click += eventHandler;
			}
		}
	}

	internal virtual DateTimePicker DateTime2_FIND
	{
		[DebuggerNonUserCode]
		get
		{
			return _DateTime2_FIND;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DateTime2_FIND = value;
		}
	}

	internal virtual PictureBox PictureBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox1 = value;
		}
	}

	internal virtual CheckBox Check_FIND_DATE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Check_FIND_DATE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Check_FIND_DATE_CheckedChanged;
			if (_Check_FIND_DATE != null)
			{
				_Check_FIND_DATE.CheckedChanged -= eventHandler;
			}
			_Check_FIND_DATE = value;
			if (_Check_FIND_DATE != null)
			{
				_Check_FIND_DATE.CheckedChanged += eventHandler;
			}
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

	internal virtual Label Label15
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label15 = value;
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

	internal virtual Label Label4141
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label4141;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label4141 = value;
		}
	}

	internal virtual TextBox Text_PRINTER_CL
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_PRINTER_CL;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_PRINTER_CL = value;
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

	internal virtual Button Button_ConsRapport
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_ConsRapport;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_ConsRapport_Click;
			if (_Button_ConsRapport != null)
			{
				((Control)_Button_ConsRapport).Click -= eventHandler;
			}
			_Button_ConsRapport = value;
			if (_Button_ConsRapport != null)
			{
				((Control)_Button_ConsRapport).Click += eventHandler;
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

	internal virtual PrintDocument Print_DEPENSES
	{
		[DebuggerNonUserCode]
		get
		{
			return _Print_DEPENSES;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			PrintPageEventHandler val = Print_Recette_Globale_PrintPage;
			if (_Print_DEPENSES != null)
			{
				_Print_DEPENSES.PrintPage -= val;
			}
			_Print_DEPENSES = value;
			if (_Print_DEPENSES != null)
			{
				_Print_DEPENSES.PrintPage += val;
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

	internal virtual DataGridView DataGridView2
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridView2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGridView2 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn COL_1
	{
		[DebuggerNonUserCode]
		get
		{
			return _COL_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_COL_1 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn COL_2
	{
		[DebuggerNonUserCode]
		get
		{
			return _COL_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_COL_2 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn COL_3
	{
		[DebuggerNonUserCode]
		get
		{
			return _COL_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_COL_3 = value;
		}
	}

	internal virtual PictureBox Picture_EXPORT
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

	internal virtual Button Button24
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button24;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button24_Click;
			if (_Button24 != null)
			{
				((Control)_Button24).Click -= eventHandler;
			}
			_Button24 = value;
			if (_Button24 != null)
			{
				((Control)_Button24).Click += eventHandler;
			}
		}
	}

	internal virtual Panel Panel_CLAVIER
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel_CLAVIER;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel_CLAVIER = value;
		}
	}

	internal virtual TableLayoutPanel TableLayoutPanel2
	{
		[DebuggerNonUserCode]
		get
		{
			return _TableLayoutPanel2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TableLayoutPanel2 = value;
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Butt_ = value;
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click;
			if (_Butt_1 != null)
			{
				((Control)_Butt_1).Click -= eventHandler;
			}
			_Butt_1 = value;
			if (_Butt_1 != null)
			{
				((Control)_Butt_1).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click;
			if (_Butt_2 != null)
			{
				((Control)_Butt_2).Click -= eventHandler;
			}
			_Butt_2 = value;
			if (_Butt_2 != null)
			{
				((Control)_Butt_2).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click;
			if (_Butt_3 != null)
			{
				((Control)_Butt_3).Click -= eventHandler;
			}
			_Butt_3 = value;
			if (_Butt_3 != null)
			{
				((Control)_Butt_3).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click;
			if (_Butt_4 != null)
			{
				((Control)_Butt_4).Click -= eventHandler;
			}
			_Butt_4 = value;
			if (_Butt_4 != null)
			{
				((Control)_Butt_4).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_5
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click;
			if (_Butt_5 != null)
			{
				((Control)_Butt_5).Click -= eventHandler;
			}
			_Butt_5 = value;
			if (_Butt_5 != null)
			{
				((Control)_Butt_5).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_6
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click;
			if (_Butt_6 != null)
			{
				((Control)_Butt_6).Click -= eventHandler;
			}
			_Butt_6 = value;
			if (_Butt_6 != null)
			{
				((Control)_Butt_6).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_7
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click;
			if (_Butt_7 != null)
			{
				((Control)_Butt_7).Click -= eventHandler;
			}
			_Butt_7 = value;
			if (_Butt_7 != null)
			{
				((Control)_Butt_7).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_8
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click;
			if (_Butt_8 != null)
			{
				((Control)_Butt_8).Click -= eventHandler;
			}
			_Butt_8 = value;
			if (_Butt_8 != null)
			{
				((Control)_Butt_8).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_0
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click;
			if (_Butt_0 != null)
			{
				((Control)_Butt_0).Click -= eventHandler;
			}
			_Butt_0 = value;
			if (_Butt_0 != null)
			{
				((Control)_Butt_0).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_9
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click;
			if (_Butt_9 != null)
			{
				((Control)_Butt_9).Click -= eventHandler;
			}
			_Butt_9 = value;
			if (_Butt_9 != null)
			{
				((Control)_Butt_9).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_DOT
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_DOT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click;
			if (_Butt_DOT != null)
			{
				((Control)_Butt_DOT).Click -= eventHandler;
			}
			_Butt_DOT = value;
			if (_Butt_DOT != null)
			{
				((Control)_Butt_DOT).Click += eventHandler;
			}
		}
	}

	internal virtual TableLayoutPanel TableLayoutPanel1
	{
		[DebuggerNonUserCode]
		get
		{
			return _TableLayoutPanel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TableLayoutPanel1 = value;
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_DRAFT
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_DRAFT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_DRAFT_Click;
			if (_Butt_DRAFT != null)
			{
				((Control)_Butt_DRAFT).Click -= eventHandler;
			}
			_Butt_DRAFT = value;
			if (_Butt_DRAFT != null)
			{
				((Control)_Butt_DRAFT).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_BACK
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_BACK;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_BACK_Click;
			if (_Butt_BACK != null)
			{
				((Control)_Butt_BACK).Click -= eventHandler;
			}
			_Butt_BACK = value;
			if (_Butt_BACK != null)
			{
				((Control)_Butt_BACK).Click += eventHandler;
			}
		}
	}

	internal virtual DataGridViewTextBoxColumn Dates
	{
		[DebuggerNonUserCode]
		get
		{
			return _Dates;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Dates = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn UTILISATEUR
	{
		[DebuggerNonUserCode]
		get
		{
			return _UTILISATEUR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UTILISATEUR = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn DEPENSE
	{
		[DebuggerNonUserCode]
		get
		{
			return _DEPENSE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DEPENSE = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Montant
	{
		[DebuggerNonUserCode]
		get
		{
			return _Montant;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Montant = value;
		}
	}

	internal virtual DataGridViewImageColumn supp
	{
		[DebuggerNonUserCode]
		get
		{
			return _supp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_supp = value;
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Button_CLAVIER
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_CLAVIER;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_CLAVIER_Click;
			if (_Button_CLAVIER != null)
			{
				((Control)_Button_CLAVIER).Click -= eventHandler;
			}
			_Button_CLAVIER = value;
			if (_Button_CLAVIER != null)
			{
				((Control)_Button_CLAVIER).Click += eventHandler;
			}
		}
	}

	public Form_6_DEPENSES()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected Obj, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected Obj, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected Obj, but got Unknown
		((Form)this).Load += Form1_Load;
		((Control)this).KeyDown += me_KeyDown;
		((Form)this).FormClosed += Form_6_MOUVEMENTS_STOCK_FormClosed;
		__ENCAddToList(this);
		DA = new MySqlDataAdapter();
		DT = new DataTable();
		newpoint = default;
		_sql = "";
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
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected Obj, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected Obj, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected Obj, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected Obj, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected Obj, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected Obj, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected Obj, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected Obj, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected Obj, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected Obj, but got Unknown
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected Obj, but got Unknown
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected Obj, but got Unknown
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected Obj, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected Obj, but got Unknown
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected Obj, but got Unknown
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected Obj, but got Unknown
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected Obj, but got Unknown
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected Obj, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected Obj, but got Unknown
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected Obj, but got Unknown
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Expected Obj, but got Unknown
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected Obj, but got Unknown
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Expected Obj, but got Unknown
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Expected Obj, but got Unknown
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Expected Obj, but got Unknown
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Expected Obj, but got Unknown
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected Obj, but got Unknown
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Expected Obj, but got Unknown
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Expected Obj, but got Unknown
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Expected Obj, but got Unknown
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Expected Obj, but got Unknown
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Expected Obj, but got Unknown
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected Obj, but got Unknown
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Expected Obj, but got Unknown
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Expected Obj, but got Unknown
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Expected Obj, but got Unknown
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Expected Obj, but got Unknown
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Expected Obj, but got Unknown
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Expected Obj, but got Unknown
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Expected Obj, but got Unknown
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Expected Obj, but got Unknown
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Expected Obj, but got Unknown
		//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d5: Expected Obj, but got Unknown
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Expected Obj, but got Unknown
		//IL_02e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ed: Expected Obj, but got Unknown
		//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f9: Expected Obj, but got Unknown
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0305: Expected Obj, but got Unknown
		//IL_0307: Unknown result type (might be due to invalid IL or missing references)
		//IL_0311: Expected Obj, but got Unknown
		//IL_0313: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Expected Obj, but got Unknown
		//IL_031f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0329: Expected Obj, but got Unknown
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0335: Expected Obj, but got Unknown
		//IL_0337: Unknown result type (might be due to invalid IL or missing references)
		//IL_0341: Expected Obj, but got Unknown
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_034d: Expected Obj, but got Unknown
		//IL_034f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0359: Expected Obj, but got Unknown
		//IL_035b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0365: Expected Obj, but got Unknown
		//IL_0367: Unknown result type (might be due to invalid IL or missing references)
		//IL_0371: Expected Obj, but got Unknown
		//IL_0373: Unknown result type (might be due to invalid IL or missing references)
		//IL_037d: Expected Obj, but got Unknown
		//IL_037f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0389: Expected Obj, but got Unknown
		//IL_038b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0395: Expected Obj, but got Unknown
		//IL_0397: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a1: Expected Obj, but got Unknown
		//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ad: Expected Obj, but got Unknown
		//IL_03af: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b9: Expected Obj, but got Unknown
		//IL_03bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c5: Expected Obj, but got Unknown
		//IL_03c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d1: Expected Obj, but got Unknown
		//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dd: Expected Obj, but got Unknown
		//IL_03df: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e9: Expected Obj, but got Unknown
		//IL_03eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f5: Expected Obj, but got Unknown
		//IL_0512: Unknown result type (might be due to invalid IL or missing references)
		//IL_051c: Expected Obj, but got Unknown
		//IL_0606: Unknown result type (might be due to invalid IL or missing references)
		//IL_0610: Expected Obj, but got Unknown
		//IL_06c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d3: Expected Obj, but got Unknown
		//IL_0956: Unknown result type (might be due to invalid IL or missing references)
		//IL_0960: Expected Obj, but got Unknown
		//IL_0987: Unknown result type (might be due to invalid IL or missing references)
		//IL_098d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a8b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a95: Expected Obj, but got Unknown
		//IL_0cce: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd8: Expected Obj, but got Unknown
		//IL_0d9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da7: Expected Obj, but got Unknown
		//IL_0e69: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e73: Expected Obj, but got Unknown
		//IL_0f3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f44: Expected Obj, but got Unknown
		//IL_1018: Unknown result type (might be due to invalid IL or missing references)
		//IL_1022: Expected Obj, but got Unknown
		//IL_10ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_10f4: Expected Obj, but got Unknown
		//IL_1118: Unknown result type (might be due to invalid IL or missing references)
		//IL_1122: Expected Obj, but got Unknown
		//IL_1156: Unknown result type (might be due to invalid IL or missing references)
		//IL_115c: Unknown result type (might be due to invalid IL or missing references)
		//IL_120a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1214: Expected Obj, but got Unknown
		//IL_1238: Unknown result type (might be due to invalid IL or missing references)
		//IL_1242: Expected Obj, but got Unknown
		//IL_127a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1280: Unknown result type (might be due to invalid IL or missing references)
		//IL_130b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1315: Expected Obj, but got Unknown
		//IL_1503: Unknown result type (might be due to invalid IL or missing references)
		//IL_1509: Unknown result type (might be due to invalid IL or missing references)
		//IL_15fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1607: Expected Obj, but got Unknown
		//IL_1619: Unknown result type (might be due to invalid IL or missing references)
		//IL_1623: Expected Obj, but got Unknown
		//IL_1635: Unknown result type (might be due to invalid IL or missing references)
		//IL_163f: Expected Obj, but got Unknown
		//IL_1651: Unknown result type (might be due to invalid IL or missing references)
		//IL_165b: Expected Obj, but got Unknown
		//IL_166d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1677: Expected Obj, but got Unknown
		//IL_1689: Unknown result type (might be due to invalid IL or missing references)
		//IL_1693: Expected Obj, but got Unknown
		//IL_16a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_16af: Expected Obj, but got Unknown
		//IL_16c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_16cb: Expected Obj, but got Unknown
		//IL_16dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_16e7: Expected Obj, but got Unknown
		//IL_16f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1703: Expected Obj, but got Unknown
		//IL_1715: Unknown result type (might be due to invalid IL or missing references)
		//IL_171f: Expected Obj, but got Unknown
		//IL_189c: Unknown result type (might be due to invalid IL or missing references)
		//IL_18a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_18c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_18d2: Expected Obj, but got Unknown
		//IL_18e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_18ee: Expected Obj, but got Unknown
		//IL_1900: Unknown result type (might be due to invalid IL or missing references)
		//IL_190a: Expected Obj, but got Unknown
		//IL_191c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1926: Expected Obj, but got Unknown
		//IL_1938: Unknown result type (might be due to invalid IL or missing references)
		//IL_1942: Expected Obj, but got Unknown
		//IL_1954: Unknown result type (might be due to invalid IL or missing references)
		//IL_195e: Expected Obj, but got Unknown
		//IL_1a00: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a0a: Expected Obj, but got Unknown
		//IL_1a41: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a47: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b15: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b1f: Expected Obj, but got Unknown
		//IL_1b53: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b59: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b81: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c42: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c4c: Expected Obj, but got Unknown
		//IL_1c81: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c87: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ca9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1caf: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d70: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d7a: Expected Obj, but got Unknown
		//IL_1daf: Unknown result type (might be due to invalid IL or missing references)
		//IL_1db5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dd7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ddd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ea8: Expected Obj, but got Unknown
		//IL_1edc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ee2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f04: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fcb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fd5: Expected Obj, but got Unknown
		//IL_200a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2010: Unknown result type (might be due to invalid IL or missing references)
		//IL_2032: Unknown result type (might be due to invalid IL or missing references)
		//IL_2038: Unknown result type (might be due to invalid IL or missing references)
		//IL_20f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_2103: Expected Obj, but got Unknown
		//IL_2138: Unknown result type (might be due to invalid IL or missing references)
		//IL_213e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2160: Unknown result type (might be due to invalid IL or missing references)
		//IL_2166: Unknown result type (might be due to invalid IL or missing references)
		//IL_2227: Unknown result type (might be due to invalid IL or missing references)
		//IL_2231: Expected Obj, but got Unknown
		//IL_2264: Unknown result type (might be due to invalid IL or missing references)
		//IL_226a: Unknown result type (might be due to invalid IL or missing references)
		//IL_228c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2292: Unknown result type (might be due to invalid IL or missing references)
		//IL_2353: Unknown result type (might be due to invalid IL or missing references)
		//IL_235d: Expected Obj, but got Unknown
		//IL_2391: Unknown result type (might be due to invalid IL or missing references)
		//IL_2397: Unknown result type (might be due to invalid IL or missing references)
		//IL_23b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_23bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_2480: Unknown result type (might be due to invalid IL or missing references)
		//IL_248a: Expected Obj, but got Unknown
		//IL_24c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_24c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_24ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_24f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_25b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_25bb: Expected Obj, but got Unknown
		//IL_25ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_25f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_2617: Unknown result type (might be due to invalid IL or missing references)
		//IL_261d: Unknown result type (might be due to invalid IL or missing references)
		//IL_26de: Unknown result type (might be due to invalid IL or missing references)
		//IL_26e8: Expected Obj, but got Unknown
		//IL_2720: Unknown result type (might be due to invalid IL or missing references)
		//IL_2726: Unknown result type (might be due to invalid IL or missing references)
		//IL_27b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_27bb: Expected Obj, but got Unknown
		//IL_2831: Unknown result type (might be due to invalid IL or missing references)
		//IL_2837: Unknown result type (might be due to invalid IL or missing references)
		//IL_285d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2867: Expected Obj, but got Unknown
		//IL_2879: Unknown result type (might be due to invalid IL or missing references)
		//IL_2883: Expected Obj, but got Unknown
		//IL_2922: Unknown result type (might be due to invalid IL or missing references)
		//IL_292c: Expected Obj, but got Unknown
		//IL_2950: Unknown result type (might be due to invalid IL or missing references)
		//IL_295a: Expected Obj, but got Unknown
		//IL_297d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2983: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a44: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a4e: Expected Obj, but got Unknown
		//IL_2a72: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a7c: Expected Obj, but got Unknown
		//IL_2a9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2aa4: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b28: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b32: Expected Obj, but got Unknown
		//IL_2b56: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b60: Expected Obj, but got Unknown
		//IL_2b8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b90: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c36: Expected Obj, but got Unknown
		//IL_2cc8: Unknown result type (might be due to invalid IL or missing references)
		//IL_2cd2: Expected Obj, but got Unknown
		//IL_2d4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d57: Expected Obj, but got Unknown
		//IL_2dc1: Unknown result type (might be due to invalid IL or missing references)
		//IL_2dcb: Expected Obj, but got Unknown
		//IL_2e53: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e5d: Expected Obj, but got Unknown
		//IL_2ed8: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ee2: Expected Obj, but got Unknown
		//IL_2f8b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f95: Expected Obj, but got Unknown
		//IL_303e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3048: Expected Obj, but got Unknown
		//IL_30f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_30fb: Expected Obj, but got Unknown
		//IL_32a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_32b3: Expected Obj, but got Unknown
		//IL_33fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_3408: Expected Obj, but got Unknown
		//IL_34b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_34ba: Expected Obj, but got Unknown
		//IL_354e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3558: Expected Obj, but got Unknown
		//IL_35d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_35da: Expected Obj, but got Unknown
		//IL_3667: Unknown result type (might be due to invalid IL or missing references)
		//IL_3671: Expected Obj, but got Unknown
		//IL_3716: Unknown result type (might be due to invalid IL or missing references)
		//IL_3720: Expected Obj, but got Unknown
		//IL_3930: Unknown result type (might be due to invalid IL or missing references)
		//IL_393a: Expected Obj, but got Unknown
		//IL_3a09: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a13: Expected Obj, but got Unknown
		//IL_3aa9: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ab3: Expected Obj, but got Unknown
		//IL_3b60: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b6a: Expected Obj, but got Unknown
		//IL_3c22: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c2c: Expected Obj, but got Unknown
		//IL_3cf4: Unknown result type (might be due to invalid IL or missing references)
		//IL_3cfe: Expected Obj, but got Unknown
		//IL_3dc2: Unknown result type (might be due to invalid IL or missing references)
		//IL_3dcc: Expected Obj, but got Unknown
		//IL_3e94: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e9e: Expected Obj, but got Unknown
		//IL_3f55: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f5f: Expected Obj, but got Unknown
		//IL_4095: Unknown result type (might be due to invalid IL or missing references)
		//IL_409f: Expected Obj, but got Unknown
		//IL_4162: Unknown result type (might be due to invalid IL or missing references)
		//IL_416c: Expected Obj, but got Unknown
		//IL_4231: Unknown result type (might be due to invalid IL or missing references)
		//IL_423b: Expected Obj, but got Unknown
		//IL_428c: Unknown result type (might be due to invalid IL or missing references)
		//IL_4292: Unknown result type (might be due to invalid IL or missing references)
		//IL_4324: Unknown result type (might be due to invalid IL or missing references)
		//IL_432e: Expected Obj, but got Unknown
		//IL_43cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_43d5: Expected Obj, but got Unknown
		//IL_453e: Unknown result type (might be due to invalid IL or missing references)
		//IL_4548: Expected Obj, but got Unknown
		//IL_46e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_46ea: Expected Obj, but got Unknown
		//IL_46fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_4707: Expected Obj, but got Unknown
		//IL_47c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_47cd: Expected Obj, but got Unknown
		//IL_47e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_47ea: Expected Obj, but got Unknown
		//IL_48ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_48d4: Expected Obj, but got Unknown
		//IL_48f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_4902: Expected Obj, but got Unknown
		//IL_499c: Unknown result type (might be due to invalid IL or missing references)
		//IL_49a6: Expected Obj, but got Unknown
		//IL_4b8f: Unknown result type (might be due to invalid IL or missing references)
		//IL_4b99: Expected Obj, but got Unknown
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		DataGridViewCellStyle val3 = new DataGridViewCellStyle();
		DataGridViewCellStyle val4 = new DataGridViewCellStyle();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form_6_DEPENSES));
		Label5 = new Label();
		DataGridView1 = new DataGridView();
		Dates = new DataGridViewTextBoxColumn();
		UTILISATEUR = new DataGridViewTextBoxColumn();
		DEPENSE = new DataGridViewTextBoxColumn();
		Montant = new DataGridViewTextBoxColumn();
		supp = new DataGridViewImageColumn();
		FlowLayoutPanel1 = new FlowLayoutPanel();
		ListBox1 = new ListBox();
		Label_TABLE = new Label();
		Panel_INFO = new Panel();
		Label_BOTTOM = new Label();
		Label_LEFT = new Label();
		Label_RIGHT = new Label();
		Label_INDEX = new Label();
		Label_TOP = new Label();
		Button_CLOSE = new Button();
		Button_SAVE = new Button();
		TabControl1 = new TabControl();
		TabPage1 = new TabPage();
		Panel_CLAVIER = new Panel();
		TableLayoutPanel2 = new TableLayoutPanel();
		Butt_ = new Button_CLAVIER_NOSELECT();
		Butt_1 = new Button_CLAVIER_NOSELECT();
		Butt_2 = new Button_CLAVIER_NOSELECT();
		Butt_3 = new Button_CLAVIER_NOSELECT();
		Butt_4 = new Button_CLAVIER_NOSELECT();
		Butt_5 = new Button_CLAVIER_NOSELECT();
		Butt_6 = new Button_CLAVIER_NOSELECT();
		Butt_7 = new Button_CLAVIER_NOSELECT();
		Butt_8 = new Button_CLAVIER_NOSELECT();
		Butt_0 = new Button_CLAVIER_NOSELECT();
		Butt_9 = new Button_CLAVIER_NOSELECT();
		Butt_DOT = new Button_CLAVIER_NOSELECT();
		TableLayoutPanel1 = new TableLayoutPanel();
		Butt_DRAFT = new Button_CLAVIER_NOSELECT();
		Butt_BACK = new Button_CLAVIER_NOSELECT();
		Button24 = new Button();
		Text_ID = new TextBox();
		DateTimePicker_DATE = new DateTimePicker();
		Text_MONTANT = new TextBox();
		Text_DEPENSE = new TextBox();
		Text_UTILISATEUR = new TextBox();
		Label10 = new Label();
		Label12 = new Label();
		Label13 = new Label();
		Label16 = new Label();
		Panel_FIND = new Panel();
		Picture_EXPORT = new PictureBox();
		Panel_DATES = new Panel();
		DateTime1_FIND = new DateTimePicker();
		Picture_FIND_DATES = new PictureBox();
		DateTime2_FIND = new DateTimePicker();
		PictureBox1 = new PictureBox();
		Check_FIND_DATE = new CheckBox();
		Check_FIND_EXACTE = new CheckBox();
		Panel2 = new Panel();
		Combo_FIND = new ComboBox();
		Picture_REFRESH = new PictureBox();
		Picture_FIND = new PictureBox();
		Text_FIND = new TextBox();
		Label1 = new Label();
		Label14 = new Label();
		Label15 = new Label();
		Label2 = new Label();
		Label4141 = new Label();
		Text_PRINTER_CL = new TextBox();
		Label3 = new Label();
		Label9 = new Label();
		Button_OK = new Button();
		DateTimePicker2 = new DateTimePicker();
		DateTimePicker1 = new DateTimePicker();
		Print_DEPENSES = new PrintDocument();
		Panel1 = new Panel();
		DataGridView2 = new DataGridView();
		COL_1 = new DataGridViewTextBoxColumn();
		COL_2 = new DataGridViewTextBoxColumn();
		COL_3 = new DataGridViewTextBoxColumn();
		Button_PrintRapport = new Button();
		Button_ConsRapport = new Button();
		Button_ADD = new Button();
		Button_CLAVIER = new Button_CLAVIER_NOSELECT();
		((ISupportInitialize)DataGridView1).BeginInit();
		((Control)FlowLayoutPanel1).SuspendLayout();
		((Control)Panel_INFO).SuspendLayout();
		((Control)TabControl1).SuspendLayout();
		((Control)TabPage1).SuspendLayout();
		((Control)Panel_CLAVIER).SuspendLayout();
		((Control)TableLayoutPanel2).SuspendLayout();
		((Control)TableLayoutPanel1).SuspendLayout();
		((Control)Panel_FIND).SuspendLayout();
		((ISupportInitialize)Picture_EXPORT).BeginInit();
		((Control)Panel_DATES).SuspendLayout();
		((ISupportInitialize)Picture_FIND_DATES).BeginInit();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)Panel2).SuspendLayout();
		((ISupportInitialize)Picture_REFRESH).BeginInit();
		((ISupportInitialize)Picture_FIND).BeginInit();
		((Control)Panel1).SuspendLayout();
		((ISupportInitialize)DataGridView2).BeginInit();
		((Control)this).SuspendLayout();
		((Control)Label5).BackColor = Color.White;
		Label5.FlatStyle = (FlatStyle)0;
		((Control)Label5).Font = new Font("Cambria", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label5).ForeColor = Color.FromArgb(64, 64, 64);
		Label label = Label5;
		Point location = new Point(346, 112);
		((Control)label).Location = location;
		((Control)Label5).Name = "Label5";
		Label label2 = Label5;
		Size size = new Size(36, 19);
		((Control)label2).Size = size;
		((Control)Label5).TabIndex = 715;
		Label5.Text = "DH";
		Label5.TextAlign = (ContentAlignment)4;
		DataGridView1.AllowUserToAddRows = false;
		((Control)DataGridView1).Anchor = (AnchorStyles)15;
		DataGridView1.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)16;
		DataGridView1.BackgroundColor = Color.White;
		val.Alignment = (DataGridViewContentAlignment)16;
		val.BackColor = SystemColors.Control;
		val.Font = new Font("Calibri", 11.25f, (FontStyle)1);
		val.ForeColor = SystemColors.WindowText;
		val.SelectionBackColor = SystemColors.Highlight;
		val.SelectionForeColor = SystemColors.HighlightText;
		val.WrapMode = (DataGridViewTriState)1;
		DataGridView1.ColumnHeadersDefaultCellStyle = val;
		DataGridView1.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		DataGridView1.Columns.AddRange(new DataGridViewColumn[5]
		{
			(DataGridViewColumn)Dates,
			(DataGridViewColumn)UTILISATEUR,
			(DataGridViewColumn)DEPENSE,
			(DataGridViewColumn)Montant,
			(DataGridViewColumn)supp
		});
		val2.Alignment = (DataGridViewContentAlignment)16;
		val2.BackColor = SystemColors.Window;
		val2.Font = new Font("Lucida Console", 10f);
		val2.ForeColor = SystemColors.ControlText;
		val2.SelectionBackColor = SystemColors.Highlight;
		val2.SelectionForeColor = SystemColors.HighlightText;
		val2.WrapMode = (DataGridViewTriState)2;
		DataGridView1.DefaultCellStyle = val2;
		DataGridView1.EditMode = (DataGridViewEditMode)4;
		DataGridView dataGridView = DataGridView1;
		location = new Point(0, 30);
		((Control)dataGridView).Location = location;
		((Control)DataGridView1).Name = "DataGridView1";
		DataGridView1.RowHeadersVisible = false;
		DataGridView1.RowHeadersWidth = 20;
		DataGridView dataGridView2 = DataGridView1;
		size = new Size(1025, 610);
		((Control)dataGridView2).Size = size;
		((Control)DataGridView1).TabIndex = 695;
		((DataGridViewColumn)Dates).DataPropertyName = "DATES";
		((DataGridViewColumn)Dates).FillWeight = 99.61929f;
		((DataGridViewColumn)Dates).HeaderText = "DATES";
		((DataGridViewColumn)Dates).Name = "Dates";
		Dates.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)UTILISATEUR).DataPropertyName = "UTILISATEUR";
		((DataGridViewColumn)UTILISATEUR).FillWeight = 99.61929f;
		((DataGridViewColumn)UTILISATEUR).HeaderText = "UTILISATEUR";
		((DataGridViewColumn)UTILISATEUR).Name = "UTILISATEUR";
		((DataGridViewColumn)DEPENSE).DataPropertyName = "DEPENSE";
		((DataGridViewColumn)DEPENSE).FillWeight = 99.61929f;
		((DataGridViewColumn)DEPENSE).HeaderText = "DEPENSE";
		((DataGridViewColumn)DEPENSE).Name = "DEPENSE";
		DEPENSE.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)Montant).DataPropertyName = "MONTANT";
		((DataGridViewColumn)Montant).FillWeight = 99.61929f;
		((DataGridViewColumn)Montant).HeaderText = "MONTANT";
		((DataGridViewColumn)Montant).Name = "Montant";
		((DataGridViewColumn)supp).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)supp).HeaderText = "";
		supp.Image = (Image)(object)Resources.Picture_SUPP_Image;
		((DataGridViewColumn)supp).Name = "supp";
		((DataGridViewColumn)supp).Resizable = (DataGridViewTriState)1;
		((DataGridViewColumn)supp).Width = 40;
		((ScrollableControl)FlowLayoutPanel1).AutoScroll = true;
		((Panel)FlowLayoutPanel1).BorderStyle = (BorderStyle)1;
		((Control)FlowLayoutPanel1).Controls.Add((Control)(object)ListBox1);
		((Control)FlowLayoutPanel1).Font = new Font("Tahoma", 7f);
		FlowLayoutPanel flowLayoutPanel = FlowLayoutPanel1;
		location = new Point(394, 14);
		((Control)flowLayoutPanel).Location = location;
		FlowLayoutPanel flowLayoutPanel2 = FlowLayoutPanel1;
		Padding margin = new Padding(0);
		((Control)flowLayoutPanel2).Margin = margin;
		((Control)FlowLayoutPanel1).Name = "FlowLayoutPanel1";
		FlowLayoutPanel flowLayoutPanel3 = FlowLayoutPanel1;
		size = new Size(257, 341);
		((Control)flowLayoutPanel3).Size = size;
		((Control)FlowLayoutPanel1).TabIndex = 707;
		((ListControl)ListBox1).FormattingEnabled = true;
		ListBox1.ItemHeight = 11;
		ListBox listBox = ListBox1;
		location = new Point(3, 3);
		((Control)listBox).Location = location;
		((Control)ListBox1).Name = "ListBox1";
		ListBox listBox2 = ListBox1;
		size = new Size(115, 136);
		((Control)listBox2).Size = size;
		((Control)ListBox1).TabIndex = 62;
		((Control)ListBox1).Visible = false;
		((Control)Label_TABLE).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label_TABLE).Dock = (DockStyle)1;
		((Control)Label_TABLE).Font = new Font("Tahoma", 9f, (FontStyle)1);
		((Control)Label_TABLE).ForeColor = Color.White;
		Label label_TABLE = Label_TABLE;
		location = new Point(0, 0);
		((Control)label_TABLE).Location = location;
		((Control)Label_TABLE).Name = "Label_TABLE";
		Label label_TABLE2 = Label_TABLE;
		size = new Size(1025, 30);
		((Control)label_TABLE2).Size = size;
		((Control)Label_TABLE).TabIndex = 1040;
		Label_TABLE.Text = "DEPENSES";
		Label_TABLE.TextAlign = (ContentAlignment)16;
		((Control)Panel_INFO).Anchor = (AnchorStyles)1;
		((Control)Panel_INFO).BackColor = Color.White;
		Panel_INFO.BorderStyle = (BorderStyle)1;
		((Control)Panel_INFO).Controls.Add((Control)(object)Button_CLAVIER);
		((Control)Panel_INFO).Controls.Add((Control)(object)Label_BOTTOM);
		((Control)Panel_INFO).Controls.Add((Control)(object)Label_LEFT);
		((Control)Panel_INFO).Controls.Add((Control)(object)Label_RIGHT);
		((Control)Panel_INFO).Controls.Add((Control)(object)Label_INDEX);
		((Control)Panel_INFO).Controls.Add((Control)(object)Label_TOP);
		((Control)Panel_INFO).Controls.Add((Control)(object)Button_CLOSE);
		((Control)Panel_INFO).Controls.Add((Control)(object)Button_SAVE);
		((Control)Panel_INFO).Controls.Add((Control)(object)TabControl1);
		Panel panel_INFO = Panel_INFO;
		location = new Point(175, 65);
		((Control)panel_INFO).Location = location;
		((Control)Panel_INFO).Name = "Panel_INFO";
		Panel panel_INFO2 = Panel_INFO;
		size = new Size(675, 508);
		((Control)panel_INFO2).Size = size;
		((Control)Panel_INFO).TabIndex = 1043;
		((Control)Panel_INFO).Visible = false;
		((Control)Label_BOTTOM).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label_BOTTOM).Cursor = Cursors.Hand;
		((Control)Label_BOTTOM).Dock = (DockStyle)2;
		((Control)Label_BOTTOM).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label_BOTTOM).ForeColor = Color.White;
		Label label_BOTTOM = Label_BOTTOM;
		location = new Point(4, 502);
		((Control)label_BOTTOM).Location = location;
		((Control)Label_BOTTOM).Name = "Label_BOTTOM";
		Label label_BOTTOM2 = Label_BOTTOM;
		size = new Size(665, 4);
		((Control)label_BOTTOM2).Size = size;
		((Control)Label_BOTTOM).TabIndex = 866;
		Label_BOTTOM.TextAlign = (ContentAlignment)16;
		((Control)Label_LEFT).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label_LEFT).Cursor = Cursors.Hand;
		((Control)Label_LEFT).Dock = (DockStyle)3;
		((Control)Label_LEFT).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label_LEFT).ForeColor = Color.White;
		Label label_LEFT = Label_LEFT;
		location = new Point(0, 24);
		((Control)label_LEFT).Location = location;
		((Control)Label_LEFT).Name = "Label_LEFT";
		Label label_LEFT2 = Label_LEFT;
		size = new Size(4, 482);
		((Control)label_LEFT2).Size = size;
		((Control)Label_LEFT).TabIndex = 865;
		Label_LEFT.TextAlign = (ContentAlignment)16;
		((Control)Label_RIGHT).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label_RIGHT).Cursor = Cursors.Hand;
		((Control)Label_RIGHT).Dock = (DockStyle)4;
		((Control)Label_RIGHT).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label_RIGHT).ForeColor = Color.White;
		Label label_RIGHT = Label_RIGHT;
		location = new Point(669, 24);
		((Control)label_RIGHT).Location = location;
		((Control)Label_RIGHT).Name = "Label_RIGHT";
		Label label_RIGHT2 = Label_RIGHT;
		size = new Size(4, 482);
		((Control)label_RIGHT2).Size = size;
		((Control)Label_RIGHT).TabIndex = 864;
		Label_RIGHT.TextAlign = (ContentAlignment)16;
		((Control)Label_INDEX).Anchor = (AnchorStyles)9;
		((Control)Label_INDEX).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label_INDEX).Cursor = Cursors.Hand;
		((Control)Label_INDEX).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label_INDEX).ForeColor = Color.White;
		Label label_INDEX = Label_INDEX;
		location = new Point(637, 0);
		((Control)label_INDEX).Location = location;
		((Control)Label_INDEX).Name = "Label_INDEX";
		Label label_INDEX2 = Label_INDEX;
		size = new Size(36, 24);
		((Control)label_INDEX2).Size = size;
		((Control)Label_INDEX).TabIndex = 863;
		Label_INDEX.Text = "-";
		Label_INDEX.TextAlign = (ContentAlignment)64;
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
		size = new Size(673, 24);
		((Control)label_TOP2).Size = size;
		((Control)Label_TOP).TabIndex = 862;
		Label_TOP.Text = "-";
		Label_TOP.TextAlign = (ContentAlignment)16;
		((ButtonBase)Button_CLOSE).BackColor = Color.Red;
		((Control)Button_CLOSE).Cursor = Cursors.Hand;
		((ButtonBase)Button_CLOSE).FlatStyle = (FlatStyle)0;
		((Control)Button_CLOSE).Font = new Font("Tahoma", 11.25f, (FontStyle)1);
		((Control)Button_CLOSE).ForeColor = Color.White;
		((ButtonBase)Button_CLOSE).Image = (Image)componentResourceManager.GetObject("Button_CLOSE.Image");
		((ButtonBase)Button_CLOSE).ImageAlign = (ContentAlignment)16;
		Button button_CLOSE = Button_CLOSE;
		location = new Point(7, 468);
		((Control)button_CLOSE).Location = location;
		Button button_CLOSE2 = Button_CLOSE;
		margin = new Padding(0);
		((Control)button_CLOSE2).Margin = margin;
		((Control)Button_CLOSE).Name = "Button_CLOSE";
		Button button_CLOSE3 = Button_CLOSE;
		size = new Size(156, 30);
		((Control)button_CLOSE3).Size = size;
		((Control)Button_CLOSE).TabIndex = 682;
		((ButtonBase)Button_CLOSE).Text = "  Fermer";
		((ButtonBase)Button_CLOSE).UseVisualStyleBackColor = false;
		((ButtonBase)Button_SAVE).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Button_SAVE).Cursor = Cursors.Hand;
		((ButtonBase)Button_SAVE).FlatStyle = (FlatStyle)0;
		((Control)Button_SAVE).Font = new Font("Tahoma", 11.25f, (FontStyle)1);
		((Control)Button_SAVE).ForeColor = Color.White;
		((ButtonBase)Button_SAVE).Image = (Image)componentResourceManager.GetObject("Button_SAVE.Image");
		((ButtonBase)Button_SAVE).ImageAlign = (ContentAlignment)16;
		Button button_SAVE = Button_SAVE;
		location = new Point(507, 469);
		((Control)button_SAVE).Location = location;
		Button button_SAVE2 = Button_SAVE;
		margin = new Padding(0);
		((Control)button_SAVE2).Margin = margin;
		((Control)Button_SAVE).Name = "Button_SAVE";
		Button button_SAVE3 = Button_SAVE;
		size = new Size(156, 30);
		((Control)button_SAVE3).Size = size;
		((Control)Button_SAVE).TabIndex = 3;
		((ButtonBase)Button_SAVE).Text = "Enregistrer";
		((ButtonBase)Button_SAVE).UseVisualStyleBackColor = false;
		((Control)TabControl1).Controls.Add((Control)(object)TabPage1);
		((Control)TabControl1).Font = new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		TabControl tabControl = TabControl1;
		size = new Size(60, 28);
		tabControl.ItemSize = size;
		TabControl tabControl2 = TabControl1;
		location = new Point(3, 26);
		((Control)tabControl2).Location = location;
		((Control)TabControl1).Name = "TabControl1";
		TabControl1.SelectedIndex = 0;
		TabControl tabControl3 = TabControl1;
		size = new Size(666, 439);
		((Control)tabControl3).Size = size;
		((Control)TabControl1).TabIndex = 0;
		TabPage1.BackColor = Color.White;
		((Control)TabPage1).Controls.Add((Control)(object)Panel_CLAVIER);
		((Control)TabPage1).Controls.Add((Control)(object)Button24);
		((Control)TabPage1).Controls.Add((Control)(object)Text_ID);
		((Control)TabPage1).Controls.Add((Control)(object)DateTimePicker_DATE);
		((Control)TabPage1).Controls.Add((Control)(object)Label5);
		((Control)TabPage1).Controls.Add((Control)(object)FlowLayoutPanel1);
		((Control)TabPage1).Controls.Add((Control)(object)Text_MONTANT);
		((Control)TabPage1).Controls.Add((Control)(object)Text_DEPENSE);
		((Control)TabPage1).Controls.Add((Control)(object)Text_UTILISATEUR);
		((Control)TabPage1).Controls.Add((Control)(object)Label10);
		((Control)TabPage1).Controls.Add((Control)(object)Label12);
		((Control)TabPage1).Controls.Add((Control)(object)Label13);
		((Control)TabPage1).Controls.Add((Control)(object)Label16);
		TabPage tabPage = TabPage1;
		location = new Point(4, 32);
		tabPage.Location = location;
		((Control)TabPage1).Name = "TabPage1";
		TabPage tabPage2 = TabPage1;
		margin = new Padding(3);
		((Control)tabPage2).Padding = margin;
		TabPage tabPage3 = TabPage1;
		size = new Size(658, 403);
		((Control)tabPage3).Size = size;
		TabPage1.TabIndex = 0;
		((Control)Panel_CLAVIER).Controls.Add((Control)(object)TableLayoutPanel2);
		((Control)Panel_CLAVIER).Controls.Add((Control)(object)TableLayoutPanel1);
		Panel panel_CLAVIER = Panel_CLAVIER;
		location = new Point(131, 140);
		((Control)panel_CLAVIER).Location = location;
		((Control)Panel_CLAVIER).Name = "Panel_CLAVIER";
		Panel panel_CLAVIER2 = Panel_CLAVIER;
		size = new Size(257, 214);
		((Control)panel_CLAVIER2).Size = size;
		((Control)Panel_CLAVIER).TabIndex = 1057;
		((Control)TableLayoutPanel2).BackColor = Color.White;
		TableLayoutPanel2.ColumnCount = 3;
		TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle((SizeType)2, 25f));
		TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle((SizeType)2, 25f));
		TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle((SizeType)2, 25f));
		TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle((SizeType)1, 20f));
		TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle((SizeType)1, 20f));
		TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle((SizeType)1, 20f));
		TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle((SizeType)1, 20f));
		TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle((SizeType)1, 20f));
		TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle((SizeType)1, 20f));
		TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle((SizeType)1, 20f));
		TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle((SizeType)1, 20f));
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_, 0, 3);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_1, 0, 2);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_2, 1, 2);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_3, 2, 2);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_4, 0, 1);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_5, 1, 1);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_6, 2, 1);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_7, 0, 0);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_8, 1, 0);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_0, 1, 3);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_9, 2, 0);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_DOT, 2, 3);
		((Control)TableLayoutPanel2).Dock = (DockStyle)5;
		((Control)TableLayoutPanel2).ForeColor = Color.Black;
		TableLayoutPanel tableLayoutPanel = TableLayoutPanel2;
		location = new Point(0, 0);
		((Control)tableLayoutPanel).Location = location;
		((Control)TableLayoutPanel2).Name = "TableLayoutPanel2";
		TableLayoutPanel tableLayoutPanel2 = TableLayoutPanel2;
		margin = new Padding(1);
		((Control)tableLayoutPanel2).Padding = margin;
		TableLayoutPanel2.RowCount = 4;
		TableLayoutPanel2.RowStyles.Add(new RowStyle((SizeType)2, 25f));
		TableLayoutPanel2.RowStyles.Add(new RowStyle((SizeType)2, 25f));
		TableLayoutPanel2.RowStyles.Add(new RowStyle((SizeType)2, 25f));
		TableLayoutPanel2.RowStyles.Add(new RowStyle((SizeType)2, 25f));
		TableLayoutPanel2.RowStyles.Add(new RowStyle((SizeType)1, 20f));
		TableLayoutPanel2.RowStyles.Add(new RowStyle((SizeType)1, 20f));
		TableLayoutPanel tableLayoutPanel3 = TableLayoutPanel2;
		size = new Size(190, 214);
		((Control)tableLayoutPanel3).Size = size;
		((Control)TableLayoutPanel2).TabIndex = 1052;
		((ButtonBase)Butt_).BackColor = Color.Transparent;
		((Control)Butt_).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_).Cursor = Cursors.Hand;
		((Control)Butt_).Dock = (DockStyle)5;
		((ButtonBase)Butt_).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_).FlatStyle = (FlatStyle)0;
		((Control)Butt_).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_).ForeColor = Color.Black;
		Button_CLAVIER_NOSELECT butt_ = Butt_;
		location = new Point(2, 161);
		((Control)butt_).Location = location;
		Button_CLAVIER_NOSELECT butt_2 = Butt_;
		margin = new Padding(1);
		((Control)butt_2).Margin = margin;
		((Control)Butt_).Name = "Butt_";
		Button_CLAVIER_NOSELECT butt_3 = Butt_;
		size = new Size(60, 51);
		((Control)butt_3).Size = size;
		((Control)Butt_).TabIndex = 791;
		((ButtonBase)Butt_).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_1).BackColor = Color.Transparent;
		((Control)Butt_1).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_1).CausesValidation = false;
		((Control)Butt_1).Cursor = Cursors.Hand;
		((Control)Butt_1).Dock = (DockStyle)5;
		((ButtonBase)Butt_1).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_1).FlatStyle = (FlatStyle)0;
		((Control)Butt_1).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_1).ForeColor = Color.Black;
		Button_CLAVIER_NOSELECT butt_4 = Butt_1;
		location = new Point(2, 108);
		((Control)butt_4).Location = location;
		Button_CLAVIER_NOSELECT butt_5 = Butt_1;
		margin = new Padding(1);
		((Control)butt_5).Margin = margin;
		((Control)Butt_1).Name = "Butt_1";
		Button_CLAVIER_NOSELECT butt_6 = Butt_1;
		margin = new Padding(1);
		((Control)butt_6).Padding = margin;
		Button_CLAVIER_NOSELECT butt_7 = Butt_1;
		size = new Size(60, 51);
		((Control)butt_7).Size = size;
		((Control)Butt_1).TabIndex = 775;
		((ButtonBase)Butt_1).Text = "1";
		((ButtonBase)Butt_1).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_2).BackColor = Color.Transparent;
		((Control)Butt_2).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_2).Cursor = Cursors.Hand;
		((Control)Butt_2).Dock = (DockStyle)5;
		((ButtonBase)Butt_2).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_2).FlatStyle = (FlatStyle)0;
		((Control)Butt_2).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_2).ForeColor = Color.Black;
		Button_CLAVIER_NOSELECT butt_8 = Butt_2;
		location = new Point(64, 108);
		((Control)butt_8).Location = location;
		Button_CLAVIER_NOSELECT butt_9 = Butt_2;
		margin = new Padding(1);
		((Control)butt_9).Margin = margin;
		((Control)Butt_2).Name = "Butt_2";
		Button_CLAVIER_NOSELECT butt_10 = Butt_2;
		margin = new Padding(1);
		((Control)butt_10).Padding = margin;
		Button_CLAVIER_NOSELECT butt_11 = Butt_2;
		size = new Size(60, 51);
		((Control)butt_11).Size = size;
		((Control)Butt_2).TabIndex = 774;
		((ButtonBase)Butt_2).Text = "2";
		((ButtonBase)Butt_2).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_3).BackColor = Color.Transparent;
		((Control)Butt_3).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_3).Cursor = Cursors.Hand;
		((Control)Butt_3).Dock = (DockStyle)5;
		((ButtonBase)Butt_3).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_3).FlatStyle = (FlatStyle)0;
		((Control)Butt_3).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_3).ForeColor = Color.Black;
		Button_CLAVIER_NOSELECT butt_12 = Butt_3;
		location = new Point(126, 108);
		((Control)butt_12).Location = location;
		Button_CLAVIER_NOSELECT butt_13 = Butt_3;
		margin = new Padding(1);
		((Control)butt_13).Margin = margin;
		((Control)Butt_3).Name = "Butt_3";
		Button_CLAVIER_NOSELECT butt_14 = Butt_3;
		margin = new Padding(1);
		((Control)butt_14).Padding = margin;
		Button_CLAVIER_NOSELECT butt_15 = Butt_3;
		size = new Size(62, 51);
		((Control)butt_15).Size = size;
		((Control)Butt_3).TabIndex = 777;
		((ButtonBase)Butt_3).Text = "3";
		((ButtonBase)Butt_3).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_4).BackColor = Color.Transparent;
		((Control)Butt_4).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_4).Cursor = Cursors.Hand;
		((Control)Butt_4).Dock = (DockStyle)5;
		((ButtonBase)Butt_4).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_4).FlatStyle = (FlatStyle)0;
		((Control)Butt_4).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_4).ForeColor = Color.Black;
		Button_CLAVIER_NOSELECT butt_16 = Butt_4;
		location = new Point(2, 55);
		((Control)butt_16).Location = location;
		Button_CLAVIER_NOSELECT butt_17 = Butt_4;
		margin = new Padding(1);
		((Control)butt_17).Margin = margin;
		((Control)Butt_4).Name = "Butt_4";
		Button_CLAVIER_NOSELECT butt_18 = Butt_4;
		margin = new Padding(1);
		((Control)butt_18).Padding = margin;
		Button_CLAVIER_NOSELECT butt_19 = Butt_4;
		size = new Size(60, 51);
		((Control)butt_19).Size = size;
		((Control)Butt_4).TabIndex = 779;
		((ButtonBase)Butt_4).Text = "4";
		((ButtonBase)Butt_4).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_5).BackColor = Color.Transparent;
		((Control)Butt_5).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_5).Cursor = Cursors.Hand;
		((Control)Butt_5).Dock = (DockStyle)5;
		((ButtonBase)Butt_5).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_5).FlatStyle = (FlatStyle)0;
		((Control)Butt_5).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_5).ForeColor = Color.Black;
		Button_CLAVIER_NOSELECT butt_20 = Butt_5;
		location = new Point(64, 55);
		((Control)butt_20).Location = location;
		Button_CLAVIER_NOSELECT butt_21 = Butt_5;
		margin = new Padding(1);
		((Control)butt_21).Margin = margin;
		((Control)Butt_5).Name = "Butt_5";
		Button_CLAVIER_NOSELECT butt_22 = Butt_5;
		margin = new Padding(1);
		((Control)butt_22).Padding = margin;
		Button_CLAVIER_NOSELECT butt_23 = Butt_5;
		size = new Size(60, 51);
		((Control)butt_23).Size = size;
		((Control)Butt_5).TabIndex = 778;
		((ButtonBase)Butt_5).Text = "5";
		((ButtonBase)Butt_5).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_6).BackColor = Color.Transparent;
		((Control)Butt_6).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_6).Cursor = Cursors.Hand;
		((Control)Butt_6).Dock = (DockStyle)5;
		((ButtonBase)Butt_6).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_6).FlatStyle = (FlatStyle)0;
		((Control)Butt_6).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_6).ForeColor = Color.Black;
		Button_CLAVIER_NOSELECT butt_24 = Butt_6;
		location = new Point(126, 55);
		((Control)butt_24).Location = location;
		Button_CLAVIER_NOSELECT butt_25 = Butt_6;
		margin = new Padding(1);
		((Control)butt_25).Margin = margin;
		((Control)Butt_6).Name = "Butt_6";
		Button_CLAVIER_NOSELECT butt_26 = Butt_6;
		margin = new Padding(1);
		((Control)butt_26).Padding = margin;
		Button_CLAVIER_NOSELECT butt_27 = Butt_6;
		size = new Size(62, 51);
		((Control)butt_27).Size = size;
		((Control)Butt_6).TabIndex = 780;
		((ButtonBase)Butt_6).Text = "6";
		((ButtonBase)Butt_6).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_7).BackColor = Color.Transparent;
		((Control)Butt_7).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_7).Cursor = Cursors.Hand;
		((Control)Butt_7).Dock = (DockStyle)5;
		((ButtonBase)Butt_7).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_7).FlatStyle = (FlatStyle)0;
		((Control)Butt_7).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_7).ForeColor = Color.Black;
		Button_CLAVIER_NOSELECT butt_28 = Butt_7;
		location = new Point(2, 2);
		((Control)butt_28).Location = location;
		Button_CLAVIER_NOSELECT butt_29 = Butt_7;
		margin = new Padding(1);
		((Control)butt_29).Margin = margin;
		((Control)Butt_7).Name = "Butt_7";
		Button_CLAVIER_NOSELECT butt_30 = Butt_7;
		margin = new Padding(1);
		((Control)butt_30).Padding = margin;
		Button_CLAVIER_NOSELECT butt_31 = Butt_7;
		size = new Size(60, 51);
		((Control)butt_31).Size = size;
		((Control)Butt_7).TabIndex = 781;
		((ButtonBase)Butt_7).Text = "7";
		((ButtonBase)Butt_7).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_8).BackColor = Color.Transparent;
		((Control)Butt_8).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_8).Cursor = Cursors.Hand;
		((Control)Butt_8).Dock = (DockStyle)5;
		((ButtonBase)Butt_8).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_8).FlatStyle = (FlatStyle)0;
		((Control)Butt_8).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_8).ForeColor = Color.Black;
		Button_CLAVIER_NOSELECT butt_32 = Butt_8;
		location = new Point(64, 2);
		((Control)butt_32).Location = location;
		Button_CLAVIER_NOSELECT butt_33 = Butt_8;
		margin = new Padding(1);
		((Control)butt_33).Margin = margin;
		((Control)Butt_8).Name = "Butt_8";
		Button_CLAVIER_NOSELECT butt_34 = Butt_8;
		margin = new Padding(1);
		((Control)butt_34).Padding = margin;
		Button_CLAVIER_NOSELECT butt_35 = Butt_8;
		size = new Size(60, 51);
		((Control)butt_35).Size = size;
		((Control)Butt_8).TabIndex = 783;
		((ButtonBase)Butt_8).Text = "8";
		((ButtonBase)Butt_8).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_0).BackColor = Color.Transparent;
		((Control)Butt_0).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_0).Cursor = Cursors.Hand;
		((Control)Butt_0).Dock = (DockStyle)5;
		((ButtonBase)Butt_0).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_0).FlatStyle = (FlatStyle)0;
		((Control)Butt_0).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_0).ForeColor = Color.Black;
		Button_CLAVIER_NOSELECT butt_36 = Butt_0;
		location = new Point(64, 161);
		((Control)butt_36).Location = location;
		Button_CLAVIER_NOSELECT butt_37 = Butt_0;
		margin = new Padding(1);
		((Control)butt_37).Margin = margin;
		((Control)Butt_0).Name = "Butt_0";
		Button_CLAVIER_NOSELECT butt_38 = Butt_0;
		margin = new Padding(1);
		((Control)butt_38).Padding = margin;
		Button_CLAVIER_NOSELECT butt_39 = Butt_0;
		size = new Size(60, 51);
		((Control)butt_39).Size = size;
		((Control)Butt_0).TabIndex = 784;
		((ButtonBase)Butt_0).Text = "0";
		((ButtonBase)Butt_0).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_9).BackColor = Color.Transparent;
		((Control)Butt_9).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_9).Cursor = Cursors.Hand;
		((Control)Butt_9).Dock = (DockStyle)5;
		((ButtonBase)Butt_9).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_9).FlatStyle = (FlatStyle)0;
		((Control)Butt_9).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_9).ForeColor = Color.Black;
		Button_CLAVIER_NOSELECT butt_40 = Butt_9;
		location = new Point(126, 2);
		((Control)butt_40).Location = location;
		Button_CLAVIER_NOSELECT butt_41 = Butt_9;
		margin = new Padding(1);
		((Control)butt_41).Margin = margin;
		((Control)Butt_9).Name = "Butt_9";
		Button_CLAVIER_NOSELECT butt_42 = Butt_9;
		margin = new Padding(1);
		((Control)butt_42).Padding = margin;
		Button_CLAVIER_NOSELECT butt_43 = Butt_9;
		size = new Size(62, 51);
		((Control)butt_43).Size = size;
		((Control)Butt_9).TabIndex = 782;
		((ButtonBase)Butt_9).Text = "9";
		((ButtonBase)Butt_9).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_DOT).BackColor = Color.Transparent;
		((Control)Butt_DOT).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_DOT).Cursor = Cursors.Hand;
		((Control)Butt_DOT).Dock = (DockStyle)5;
		((ButtonBase)Butt_DOT).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_DOT).FlatStyle = (FlatStyle)0;
		((Control)Butt_DOT).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_DOT).ForeColor = Color.Black;
		Button_CLAVIER_NOSELECT butt_DOT = Butt_DOT;
		location = new Point(126, 161);
		((Control)butt_DOT).Location = location;
		Button_CLAVIER_NOSELECT butt_DOT2 = Butt_DOT;
		margin = new Padding(1);
		((Control)butt_DOT2).Margin = margin;
		((Control)Butt_DOT).Name = "Butt_DOT";
		Button_CLAVIER_NOSELECT butt_DOT3 = Butt_DOT;
		size = new Size(62, 51);
		((Control)butt_DOT3).Size = size;
		((Control)Butt_DOT).TabIndex = 790;
		((ButtonBase)Butt_DOT).Text = ".";
		((ButtonBase)Butt_DOT).UseVisualStyleBackColor = false;
		((Control)TableLayoutPanel1).BackColor = Color.White;
		TableLayoutPanel1.ColumnCount = 1;
		TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
		TableLayoutPanel1.Controls.Add((Control)(object)Butt_DRAFT, 0, 1);
		TableLayoutPanel1.Controls.Add((Control)(object)Butt_BACK, 0, 0);
		((Control)TableLayoutPanel1).Dock = (DockStyle)4;
		TableLayoutPanel tableLayoutPanel4 = TableLayoutPanel1;
		location = new Point(190, 0);
		((Control)tableLayoutPanel4).Location = location;
		((Control)TableLayoutPanel1).Name = "TableLayoutPanel1";
		TableLayoutPanel tableLayoutPanel5 = TableLayoutPanel1;
		margin = new Padding(1);
		((Control)tableLayoutPanel5).Padding = margin;
		TableLayoutPanel1.RowCount = 2;
		TableLayoutPanel1.RowStyles.Add(new RowStyle((SizeType)2, 50f));
		TableLayoutPanel1.RowStyles.Add(new RowStyle((SizeType)2, 50f));
		TableLayoutPanel tableLayoutPanel6 = TableLayoutPanel1;
		size = new Size(67, 214);
		((Control)tableLayoutPanel6).Size = size;
		((Control)TableLayoutPanel1).TabIndex = 1053;
		((ButtonBase)Butt_DRAFT).BackColor = Color.Transparent;
		((Control)Butt_DRAFT).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_DRAFT).Cursor = Cursors.Hand;
		((Control)Butt_DRAFT).Dock = (DockStyle)5;
		((ButtonBase)Butt_DRAFT).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_DRAFT).FlatStyle = (FlatStyle)0;
		((Control)Butt_DRAFT).Font = new Font("Calibri", 12f, (FontStyle)1);
		((Control)Butt_DRAFT).ForeColor = Color.Black;
		((ButtonBase)Butt_DRAFT).Image = (Image)componentResourceManager.GetObject("Butt_DRAFT.Image");
		Button_CLAVIER_NOSELECT butt_DRAFT = Butt_DRAFT;
		location = new Point(2, 108);
		((Control)butt_DRAFT).Location = location;
		Button_CLAVIER_NOSELECT butt_DRAFT2 = Butt_DRAFT;
		margin = new Padding(1);
		((Control)butt_DRAFT2).Margin = margin;
		((Control)Butt_DRAFT).Name = "Butt_DRAFT";
		Button_CLAVIER_NOSELECT butt_DRAFT3 = Butt_DRAFT;
		size = new Size(63, 104);
		((Control)butt_DRAFT3).Size = size;
		((Control)Butt_DRAFT).TabIndex = 771;
		((ButtonBase)Butt_DRAFT).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_BACK).BackColor = Color.Transparent;
		((Control)Butt_BACK).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_BACK).Cursor = Cursors.Hand;
		((Control)Butt_BACK).Dock = (DockStyle)5;
		((ButtonBase)Butt_BACK).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_BACK).FlatStyle = (FlatStyle)0;
		((Control)Butt_BACK).Font = new Font("Calibri", 20.25f, (FontStyle)1);
		((Control)Butt_BACK).ForeColor = Color.Black;
		((ButtonBase)Butt_BACK).Image = (Image)componentResourceManager.GetObject("Butt_BACK.Image");
		Button_CLAVIER_NOSELECT butt_BACK = Butt_BACK;
		location = new Point(2, 2);
		((Control)butt_BACK).Location = location;
		Button_CLAVIER_NOSELECT butt_BACK2 = Butt_BACK;
		margin = new Padding(1);
		((Control)butt_BACK2).Margin = margin;
		((Control)Butt_BACK).Name = "Butt_BACK";
		Button_CLAVIER_NOSELECT butt_BACK3 = Butt_BACK;
		size = new Size(63, 104);
		((Control)butt_BACK3).Size = size;
		((Control)Butt_BACK).TabIndex = 770;
		((ButtonBase)Butt_BACK).UseVisualStyleBackColor = false;
		((ButtonBase)Button24).BackColor = Color.Transparent;
		((Control)Button24).Cursor = Cursors.Hand;
		((Control)Button24).Font = new Font("Tahoma", 11.25f, (FontStyle)1);
		((Control)Button24).ForeColor = Color.Green;
		((ButtonBase)Button24).Image = (Image)componentResourceManager.GetObject("Button24.Image");
		Button button = Button24;
		location = new Point(623, 327);
		((Control)button).Location = location;
		Button button2 = Button24;
		margin = new Padding(0);
		((Control)button2).Margin = margin;
		((Control)Button24).Name = "Button24";
		Button button3 = Button24;
		size = new Size(27, 27);
		((Control)button3).Size = size;
		((Control)Button24).TabIndex = 971;
		((ButtonBase)Button24).UseVisualStyleBackColor = false;
		((TextBoxBase)Text_ID).BackColor = Color.FromArgb(224, 224, 224);
		((TextBoxBase)Text_ID).BorderStyle = (BorderStyle)1;
		((Control)Text_ID).Enabled = false;
		((Control)Text_ID).Font = new Font("Segoe UI", 12f, (FontStyle)1);
		TextBox text_ID = Text_ID;
		location = new Point(131, 15);
		((Control)text_ID).Location = location;
		((Control)Text_ID).Name = "Text_ID";
		TextBox text_ID2 = Text_ID;
		size = new Size(32, 26);
		((Control)text_ID2).Size = size;
		((Control)Text_ID).TabIndex = 2;
		Text_ID.TextAlign = (HorizontalAlignment)2;
		((Control)Text_ID).Visible = false;
		DateTimePicker_DATE.CustomFormat = "yyyy-MM-dd";
		((Control)DateTimePicker_DATE).Font = new Font("Segoe UI", 12f, (FontStyle)1);
		DateTimePicker_DATE.Format = (DateTimePickerFormat)2;
		DateTimePicker dateTimePicker_DATE = DateTimePicker_DATE;
		location = new Point(130, 14);
		((Control)dateTimePicker_DATE).Location = location;
		((Control)DateTimePicker_DATE).Name = "DateTimePicker_DATE";
		DateTimePicker dateTimePicker_DATE2 = DateTimePicker_DATE;
		size = new Size(258, 26);
		((Control)dateTimePicker_DATE2).Size = size;
		((Control)DateTimePicker_DATE).TabIndex = 970;
		((Control)Text_MONTANT).Font = new Font("Segoe UI", 12f, (FontStyle)1);
		TextBox text_MONTANT = Text_MONTANT;
		location = new Point(130, 109);
		((Control)text_MONTANT).Location = location;
		((Control)Text_MONTANT).Name = "Text_MONTANT";
		TextBox text_MONTANT2 = Text_MONTANT;
		size = new Size(258, 26);
		((Control)text_MONTANT2).Size = size;
		((Control)Text_MONTANT).TabIndex = 4;
		((Control)Text_DEPENSE).Font = new Font("Segoe UI", 12f, (FontStyle)1);
		TextBox text_DEPENSE = Text_DEPENSE;
		location = new Point(130, 78);
		((Control)text_DEPENSE).Location = location;
		((Control)Text_DEPENSE).Name = "Text_DEPENSE";
		TextBox text_DEPENSE2 = Text_DEPENSE;
		size = new Size(258, 26);
		((Control)text_DEPENSE2).Size = size;
		((Control)Text_DEPENSE).TabIndex = 5;
		((TextBoxBase)Text_UTILISATEUR).BackColor = Color.White;
		((Control)Text_UTILISATEUR).Enabled = false;
		((Control)Text_UTILISATEUR).Font = new Font("Segoe UI", 12f, (FontStyle)1);
		TextBox text_UTILISATEUR = Text_UTILISATEUR;
		location = new Point(130, 46);
		((Control)text_UTILISATEUR).Location = location;
		((Control)Text_UTILISATEUR).Name = "Text_UTILISATEUR";
		TextBox text_UTILISATEUR2 = Text_UTILISATEUR;
		size = new Size(258, 26);
		((Control)text_UTILISATEUR2).Size = size;
		((Control)Text_UTILISATEUR).TabIndex = 2;
		((Control)Label10).BackColor = SystemColors.Control;
		((Control)Label10).Font = new Font("Segoe UI", 10f, (FontStyle)1);
		((Control)Label10).ForeColor = Color.Black;
		Label label3 = Label10;
		location = new Point(17, 14);
		((Control)label3).Location = location;
		((Control)Label10).Name = "Label10";
		Label label4 = Label10;
		size = new Size(107, 26);
		((Control)label4).Size = size;
		((Control)Label10).TabIndex = 396;
		Label10.Text = "DATE";
		Label10.TextAlign = (ContentAlignment)16;
		((Control)Label12).BackColor = SystemColors.Control;
		((Control)Label12).Font = new Font("Segoe UI", 10f, (FontStyle)1);
		((Control)Label12).ForeColor = Color.Black;
		Label label5 = Label12;
		location = new Point(17, 46);
		((Control)label5).Location = location;
		((Control)Label12).Name = "Label12";
		Label label6 = Label12;
		size = new Size(107, 26);
		((Control)label6).Size = size;
		((Control)Label12).TabIndex = 399;
		Label12.Text = "UTILISATEUR";
		Label12.TextAlign = (ContentAlignment)16;
		((Control)Label13).BackColor = SystemColors.Control;
		((Control)Label13).Font = new Font("Segoe UI", 10f, (FontStyle)1);
		((Control)Label13).ForeColor = Color.Black;
		Label label7 = Label13;
		location = new Point(17, 78);
		((Control)label7).Location = location;
		((Control)Label13).Name = "Label13";
		Label label8 = Label13;
		size = new Size(107, 26);
		((Control)label8).Size = size;
		((Control)Label13).TabIndex = 401;
		Label13.Text = "DEPENSE";
		Label13.TextAlign = (ContentAlignment)16;
		((Control)Label16).BackColor = SystemColors.Control;
		((Control)Label16).Font = new Font("Segoe UI", 10f, (FontStyle)1);
		((Control)Label16).ForeColor = Color.Black;
		Label label9 = Label16;
		location = new Point(17, 109);
		((Control)label9).Location = location;
		((Control)Label16).Name = "Label16";
		Label label10 = Label16;
		size = new Size(107, 26);
		((Control)label10).Size = size;
		((Control)Label16).TabIndex = 403;
		Label16.Text = "MONTANT";
		Label16.TextAlign = (ContentAlignment)16;
		((Control)Panel_FIND).Anchor = (AnchorStyles)13;
		((Control)Panel_FIND).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Panel_FIND).Controls.Add((Control)(object)Picture_EXPORT);
		((Control)Panel_FIND).Controls.Add((Control)(object)Panel_DATES);
		((Control)Panel_FIND).Controls.Add((Control)(object)Check_FIND_DATE);
		((Control)Panel_FIND).Controls.Add((Control)(object)Check_FIND_EXACTE);
		((Control)Panel_FIND).Controls.Add((Control)(object)Panel2);
		Panel panel_FIND = Panel_FIND;
		location = new Point(143, 0);
		((Control)panel_FIND).Location = location;
		((Control)Panel_FIND).Name = "Panel_FIND";
		Panel panel_FIND2 = Panel_FIND;
		size = new Size(882, 30);
		((Control)panel_FIND2).Size = size;
		((Control)Panel_FIND).TabIndex = 1045;
		((Control)Picture_EXPORT).Anchor = (AnchorStyles)9;
		((Control)Picture_EXPORT).Cursor = Cursors.Hand;
		Picture_EXPORT.Image = (Image)componentResourceManager.GetObject("Picture_EXPORT.Image");
		PictureBox picture_EXPORT = Picture_EXPORT;
		location = new Point(852, 3);
		((Control)picture_EXPORT).Location = location;
		((Control)Picture_EXPORT).Name = "Picture_EXPORT";
		PictureBox picture_EXPORT2 = Picture_EXPORT;
		size = new Size(27, 24);
		((Control)picture_EXPORT2).Size = size;
		Picture_EXPORT.SizeMode = (PictureBoxSizeMode)4;
		Picture_EXPORT.TabIndex = 1046;
		Picture_EXPORT.TabStop = false;
		((Control)Panel_DATES).Controls.Add((Control)(object)DateTime1_FIND);
		((Control)Panel_DATES).Controls.Add((Control)(object)Picture_FIND_DATES);
		((Control)Panel_DATES).Controls.Add((Control)(object)DateTime2_FIND);
		((Control)Panel_DATES).Controls.Add((Control)(object)PictureBox1);
		Panel panel_DATES = Panel_DATES;
		location = new Point(417, 3);
		((Control)panel_DATES).Location = location;
		((Control)Panel_DATES).Name = "Panel_DATES";
		Panel panel_DATES2 = Panel_DATES;
		size = new Size(334, 24);
		((Control)panel_DATES2).Size = size;
		((Control)Panel_DATES).TabIndex = 1043;
		DateTime1_FIND.CustomFormat = "yyyy/MM/dd  HH:mm:ss";
		((Control)DateTime1_FIND).Font = new Font("Tahoma", 9f);
		DateTime1_FIND.Format = (DateTimePickerFormat)2;
		DateTimePicker dateTime1_FIND = DateTime1_FIND;
		location = new Point(1, 1);
		((Control)dateTime1_FIND).Location = location;
		((Control)DateTime1_FIND).Name = "DateTime1_FIND";
		DateTimePicker dateTime1_FIND2 = DateTime1_FIND;
		size = new Size(92, 22);
		((Control)dateTime1_FIND2).Size = size;
		((Control)DateTime1_FIND).TabIndex = 1038;
		DateTimePicker dateTime1_FIND3 = DateTime1_FIND;
		DateTime value = new DateTime(2000, 1, 1, 13, 59, 0, 0);
		dateTime1_FIND3.Value = value;
		((Control)Picture_FIND_DATES).Cursor = Cursors.Hand;
		Picture_FIND_DATES.Image = (Image)componentResourceManager.GetObject("Picture_FIND_DATES.Image");
		PictureBox picture_FIND_DATES = Picture_FIND_DATES;
		location = new Point(226, 3);
		((Control)picture_FIND_DATES).Location = location;
		((Control)Picture_FIND_DATES).Name = "Picture_FIND_DATES";
		PictureBox picture_FIND_DATES2 = Picture_FIND_DATES;
		size = new Size(27, 19);
		((Control)picture_FIND_DATES2).Size = size;
		Picture_FIND_DATES.SizeMode = (PictureBoxSizeMode)4;
		Picture_FIND_DATES.TabIndex = 1042;
		Picture_FIND_DATES.TabStop = false;
		DateTime2_FIND.CustomFormat = "yyyy/MM/dd  HH:mm:ss";
		((Control)DateTime2_FIND).Font = new Font("Tahoma", 9f);
		DateTime2_FIND.Format = (DateTimePickerFormat)2;
		DateTimePicker dateTime2_FIND = DateTime2_FIND;
		location = new Point(128, 1);
		((Control)dateTime2_FIND).Location = location;
		((Control)DateTime2_FIND).Name = "DateTime2_FIND";
		DateTimePicker dateTime2_FIND2 = DateTime2_FIND;
		size = new Size(92, 22);
		((Control)dateTime2_FIND2).Size = size;
		((Control)DateTime2_FIND).TabIndex = 1039;
		PictureBox1.Image = (Image)componentResourceManager.GetObject("PictureBox1.Image");
		PictureBox pictureBox = PictureBox1;
		location = new Point(93, 1);
		((Control)pictureBox).Location = location;
		((Control)PictureBox1).Name = "PictureBox1";
		PictureBox pictureBox2 = PictureBox1;
		size = new Size(35, 22);
		((Control)pictureBox2).Size = size;
		PictureBox1.SizeMode = (PictureBoxSizeMode)4;
		PictureBox1.TabIndex = 1040;
		PictureBox1.TabStop = false;
		((ButtonBase)Check_FIND_DATE).AutoSize = true;
		((Control)Check_FIND_DATE).Font = new Font("Tahoma", 9f);
		((Control)Check_FIND_DATE).ForeColor = Color.White;
		CheckBox check_FIND_DATE = Check_FIND_DATE;
		location = new Point(332, 6);
		((Control)check_FIND_DATE).Location = location;
		((Control)Check_FIND_DATE).Name = "Check_FIND_DATE";
		CheckBox check_FIND_DATE2 = Check_FIND_DATE;
		size = new Size(80, 18);
		((Control)check_FIND_DATE2).Size = size;
		((Control)Check_FIND_DATE).TabIndex = 1041;
		((ButtonBase)Check_FIND_DATE).Text = "avec date";
		((ButtonBase)Check_FIND_DATE).UseVisualStyleBackColor = true;
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
		((Control)Panel2).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Panel2).BackgroundImageLayout = (ImageLayout)4;
		((Control)Panel2).Controls.Add((Control)(object)Combo_FIND);
		((Control)Panel2).Controls.Add((Control)(object)Picture_REFRESH);
		((Control)Panel2).Controls.Add((Control)(object)Picture_FIND);
		((Control)Panel2).Controls.Add((Control)(object)Text_FIND);
		((Control)Panel2).Controls.Add((Control)(object)Label1);
		((Control)Panel2).Controls.Add((Control)(object)Label14);
		((Control)Panel2).Controls.Add((Control)(object)Label15);
		((Control)Panel2).Controls.Add((Control)(object)Label2);
		Panel panel = Panel2;
		location = new Point(3, 3);
		((Control)panel).Location = location;
		((Control)Panel2).Name = "Panel2";
		Panel panel2 = Panel2;
		size = new Size(254, 24);
		((Control)panel2).Size = size;
		((Control)Panel2).TabIndex = 1035;
		Combo_FIND.BackColor = Color.FromArgb(22, 106, 238);
		Combo_FIND.DropDownStyle = (ComboBoxStyle)2;
		Combo_FIND.DropDownWidth = 100;
		Combo_FIND.FlatStyle = (FlatStyle)0;
		((Control)Combo_FIND).Font = new Font("Tahoma", 9f);
		Combo_FIND.ForeColor = Color.White;
		((ListControl)Combo_FIND).FormattingEnabled = true;
		Combo_FIND.Items.AddRange(new object[3] { "UTILISATEUR", "DEPENSE", "DATES" });
		ComboBox combo_FIND = Combo_FIND;
		location = new Point(0, 1);
		((Control)combo_FIND).Location = location;
		((Control)Combo_FIND).Name = "Combo_FIND";
		ComboBox combo_FIND2 = Combo_FIND;
		size = new Size(75, 22);
		((Control)combo_FIND2).Size = size;
		((Control)Combo_FIND).TabIndex = 1038;
		((Control)Picture_REFRESH).Cursor = Cursors.Hand;
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
		((Control)Picture_FIND).Cursor = Cursors.Hand;
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
		location = new Point(81, 5);
		((Control)text_FIND).Location = location;
		((Control)Text_FIND).Name = "Text_FIND";
		TextBox text_FIND2 = Text_FIND;
		size = new Size(100, 15);
		((Control)text_FIND2).Size = size;
		((Control)Text_FIND).TabIndex = 708;
		((Control)Label1).BackColor = Color.FromArgb(227, 227, 227);
		((Control)Label1).Cursor = Cursors.Hand;
		((Control)Label1).Dock = (DockStyle)2;
		((Control)Label1).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label1).ForeColor = Color.White;
		Label label11 = Label1;
		location = new Point(1, 23);
		((Control)label11).Location = location;
		((Control)Label1).Name = "Label1";
		Label label12 = Label1;
		size = new Size(252, 1);
		((Control)label12).Size = size;
		((Control)Label1).TabIndex = 1000;
		Label1.TextAlign = (ContentAlignment)16;
		((Control)Label14).BackColor = Color.FromArgb(227, 227, 227);
		((Control)Label14).Cursor = Cursors.Hand;
		((Control)Label14).Dock = (DockStyle)3;
		((Control)Label14).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label14).ForeColor = Color.White;
		Label label13 = Label14;
		location = new Point(0, 1);
		((Control)label13).Location = location;
		((Control)Label14).Name = "Label14";
		Label label14 = Label14;
		size = new Size(1, 23);
		((Control)label14).Size = size;
		((Control)Label14).TabIndex = 999;
		Label14.TextAlign = (ContentAlignment)16;
		((Control)Label15).BackColor = Color.FromArgb(227, 227, 227);
		((Control)Label15).Cursor = Cursors.Hand;
		((Control)Label15).Dock = (DockStyle)4;
		((Control)Label15).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label15).ForeColor = Color.White;
		Label label15 = Label15;
		location = new Point(253, 1);
		((Control)label15).Location = location;
		((Control)Label15).Name = "Label15";
		Label label16 = Label15;
		size = new Size(1, 23);
		((Control)label16).Size = size;
		((Control)Label15).TabIndex = 998;
		Label15.TextAlign = (ContentAlignment)16;
		((Control)Label2).BackColor = Color.FromArgb(227, 227, 227);
		((Control)Label2).Cursor = Cursors.Hand;
		((Control)Label2).Dock = (DockStyle)1;
		((Control)Label2).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label2).ForeColor = Color.White;
		Label label17 = Label2;
		location = new Point(0, 0);
		((Control)label17).Location = location;
		((Control)Label2).Name = "Label2";
		Label label18 = Label2;
		size = new Size(254, 1);
		((Control)label18).Size = size;
		((Control)Label2).TabIndex = 997;
		Label2.Text = "-";
		Label2.TextAlign = (ContentAlignment)16;
		((Control)Label4141).Anchor = (AnchorStyles)10;
		((Control)Label4141).BackColor = Color.Red;
		((Control)Label4141).Font = new Font("Segoe UI", 9.75f, (FontStyle)3);
		((Control)Label4141).ForeColor = Color.White;
		Label label19 = Label4141;
		location = new Point(695, 614);
		((Control)label19).Location = location;
		((Control)Label4141).Name = "Label4141";
		Label label20 = Label4141;
		size = new Size(330, 26);
		((Control)label20).Size = size;
		((Control)Label4141).TabIndex = 1064;
		Label4141.TextAlign = (ContentAlignment)64;
		((Control)Label4141).Visible = false;
		TextBox text_PRINTER_CL = Text_PRINTER_CL;
		location = new Point(361, 656);
		((Control)text_PRINTER_CL).Location = location;
		((Control)Text_PRINTER_CL).Name = "Text_PRINTER_CL";
		TextBox text_PRINTER_CL2 = Text_PRINTER_CL;
		size = new Size(107, 20);
		((Control)text_PRINTER_CL2).Size = size;
		((Control)Text_PRINTER_CL).TabIndex = 1076;
		Text_PRINTER_CL.Text = "Text_PRINTER_CL";
		((Control)Text_PRINTER_CL).Visible = false;
		((Control)Label3).Anchor = (AnchorStyles)10;
		((Control)Label3).BackColor = Color.WhiteSmoke;
		((Control)Label3).Font = new Font("Segoe UI", 9.75f, (FontStyle)1);
		((Control)Label3).ForeColor = Color.FromArgb(64, 64, 64);
		Label label21 = Label3;
		location = new Point(514, 665);
		((Control)label21).Location = location;
		((Control)Label3).Name = "Label3";
		Label label22 = Label3;
		size = new Size(27, 24);
		((Control)label22).Size = size;
		((Control)Label3).TabIndex = 1072;
		Label3.Text = "A";
		Label3.TextAlign = (ContentAlignment)16;
		((Control)Label9).Anchor = (AnchorStyles)10;
		((Control)Label9).BackColor = Color.WhiteSmoke;
		((Control)Label9).Font = new Font("Segoe UI", 9.75f, (FontStyle)1);
		((Control)Label9).ForeColor = Color.FromArgb(64, 64, 64);
		Label label23 = Label9;
		location = new Point(514, 641);
		((Control)label23).Location = location;
		((Control)Label9).Name = "Label9";
		Label label24 = Label9;
		size = new Size(27, 24);
		((Control)label24).Size = size;
		((Control)Label9).TabIndex = 1073;
		Label9.Text = "De";
		Label9.TextAlign = (ContentAlignment)16;
		((Control)Button_OK).Anchor = (AnchorStyles)10;
		((Control)Button_OK).Cursor = Cursors.Hand;
		((Control)Button_OK).Font = new Font("Tahoma", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Button_OK).ForeColor = Color.FromArgb(2, 45, 162);
		((ButtonBase)Button_OK).ImageAlign = (ContentAlignment)16;
		Button button_OK = Button_OK;
		location = new Point(681, 640);
		((Control)button_OK).Location = location;
		Button button_OK2 = Button_OK;
		margin = new Padding(0);
		((Control)button_OK2).Margin = margin;
		((Control)Button_OK).Name = "Button_OK";
		Button button_OK3 = Button_OK;
		size = new Size(44, 50);
		((Control)button_OK3).Size = size;
		((Control)Button_OK).TabIndex = 1071;
		((ButtonBase)Button_OK).Text = "OK";
		((ButtonBase)Button_OK).UseVisualStyleBackColor = true;
		((Control)DateTimePicker2).Anchor = (AnchorStyles)10;
		DateTimePicker2.CustomFormat = "yyyy/MM/dd  HH:mm:ss";
		((Control)DateTimePicker2).Font = new Font("Segoe UI", 11f, (FontStyle)1);
		DateTimePicker2.Format = (DateTimePickerFormat)2;
		DateTimePicker dateTimePicker = DateTimePicker2;
		location = new Point(545, 666);
		((Control)dateTimePicker).Location = location;
		((Control)DateTimePicker2).Name = "DateTimePicker2";
		DateTimePicker dateTimePicker2 = DateTimePicker2;
		size = new Size(133, 24);
		((Control)dateTimePicker2).Size = size;
		((Control)DateTimePicker2).TabIndex = 1069;
		((Control)DateTimePicker1).Anchor = (AnchorStyles)10;
		DateTimePicker1.CustomFormat = "yyyy/MM/dd  HH:mm:ss";
		((Control)DateTimePicker1).Font = new Font("Segoe UI", 11f, (FontStyle)1);
		DateTimePicker1.Format = (DateTimePickerFormat)2;
		DateTimePicker dateTimePicker3 = DateTimePicker1;
		location = new Point(545, 641);
		((Control)dateTimePicker3).Location = location;
		((Control)DateTimePicker1).Name = "DateTimePicker1";
		DateTimePicker dateTimePicker4 = DateTimePicker1;
		size = new Size(133, 24);
		((Control)dateTimePicker4).Size = size;
		((Control)DateTimePicker1).TabIndex = 1070;
		((Control)Panel1).Controls.Add((Control)(object)DataGridView2);
		Panel panel3 = Panel1;
		location = new Point(213, 132);
		((Control)panel3).Location = location;
		((Control)Panel1).Name = "Panel1";
		Panel panel4 = Panel1;
		size = new Size(599, 428);
		((Control)panel4).Size = size;
		((Control)Panel1).TabIndex = 1077;
		((Control)Panel1).Visible = false;
		DataGridView2.AllowUserToAddRows = false;
		DataGridView2.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		DataGridView2.Columns.AddRange(new DataGridViewColumn[3]
		{
			(DataGridViewColumn)COL_1,
			(DataGridViewColumn)COL_2,
			(DataGridViewColumn)COL_3
		});
		val3.Alignment = (DataGridViewContentAlignment)16;
		val3.BackColor = SystemColors.Window;
		val3.Font = new Font("Lucida Console", 8f);
		val3.ForeColor = SystemColors.ControlText;
		val3.SelectionBackColor = SystemColors.Highlight;
		val3.SelectionForeColor = SystemColors.HighlightText;
		val3.WrapMode = (DataGridViewTriState)2;
		DataGridView2.DefaultCellStyle = val3;
		DataGridView dataGridView3 = DataGridView2;
		location = new Point(5, 3);
		((Control)dataGridView3).Location = location;
		((Control)DataGridView2).Name = "DataGridView2";
		DataGridView dataGridView4 = DataGridView2;
		size = new Size(570, 264);
		((Control)dataGridView4).Size = size;
		((Control)DataGridView2).TabIndex = 382;
		((DataGridViewColumn)COL_1).HeaderText = "COL_1";
		((DataGridViewColumn)COL_1).Name = "COL_1";
		((DataGridViewColumn)COL_1).Resizable = (DataGridViewTriState)1;
		COL_1.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)COL_1).Width = 180;
		((DataGridViewColumn)COL_2).HeaderText = "COL_2";
		((DataGridViewColumn)COL_2).Name = "COL_2";
		((DataGridViewColumn)COL_2).Width = 140;
		val4.Format = "N2";
		val4.NullValue = null;
		((DataGridViewColumn)COL_3).DefaultCellStyle = val4;
		((DataGridViewColumn)COL_3).HeaderText = "COL_3";
		((DataGridViewColumn)COL_3).Name = "COL_3";
		((DataGridViewColumn)COL_3).Width = 180;
		((Control)Button_PrintRapport).Anchor = (AnchorStyles)10;
		((Control)Button_PrintRapport).Cursor = Cursors.Hand;
		((Control)Button_PrintRapport).Font = new Font("Tahoma", 9f, (FontStyle)1);
		((ButtonBase)Button_PrintRapport).Image = (Image)componentResourceManager.GetObject("Button_PrintRapport.Image");
		((ButtonBase)Button_PrintRapport).ImageAlign = (ContentAlignment)16;
		Button button_PrintRapport = Button_PrintRapport;
		location = new Point(892, 640);
		((Control)button_PrintRapport).Location = location;
		((Control)Button_PrintRapport).Name = "Button_PrintRapport";
		Button button_PrintRapport2 = Button_PrintRapport;
		size = new Size(130, 50);
		((Control)button_PrintRapport2).Size = size;
		((Control)Button_PrintRapport).TabIndex = 1074;
		((ButtonBase)Button_PrintRapport).Text = "   IMPRIMER";
		((ButtonBase)Button_PrintRapport).UseVisualStyleBackColor = true;
		((Control)Button_ConsRapport).Anchor = (AnchorStyles)10;
		((Control)Button_ConsRapport).Cursor = Cursors.Hand;
		((Control)Button_ConsRapport).Font = new Font("Tahoma", 9f, (FontStyle)1);
		((ButtonBase)Button_ConsRapport).Image = (Image)componentResourceManager.GetObject("Button_ConsRapport.Image");
		((ButtonBase)Button_ConsRapport).ImageAlign = (ContentAlignment)16;
		Button button_ConsRapport = Button_ConsRapport;
		location = new Point(756, 640);
		((Control)button_ConsRapport).Location = location;
		((Control)Button_ConsRapport).Name = "Button_ConsRapport";
		Button button_ConsRapport2 = Button_ConsRapport;
		size = new Size(130, 50);
		((Control)button_ConsRapport2).Size = size;
		((Control)Button_ConsRapport).TabIndex = 1075;
		((ButtonBase)Button_ConsRapport).Text = "    CONSULTER";
		((ButtonBase)Button_ConsRapport).UseVisualStyleBackColor = true;
		((Control)Button_ADD).Anchor = (AnchorStyles)6;
		((ButtonBase)Button_ADD).BackColor = Color.FromArgb(0, 192, 0);
		((Control)Button_ADD).Cursor = Cursors.Hand;
		((ButtonBase)Button_ADD).FlatStyle = (FlatStyle)0;
		((Control)Button_ADD).Font = new Font("Tahoma", 11.25f, (FontStyle)1);
		((Control)Button_ADD).ForeColor = Color.White;
		((ButtonBase)Button_ADD).Image = (Image)componentResourceManager.GetObject("Button_ADD.Image");
		((ButtonBase)Button_ADD).ImageAlign = (ContentAlignment)16;
		Button button_ADD = Button_ADD;
		location = new Point(0, 646);
		((Control)button_ADD).Location = location;
		((Control)Button_ADD).Name = "Button_ADD";
		Button button_ADD2 = Button_ADD;
		size = new Size(191, 40);
		((Control)button_ADD2).Size = size;
		((Control)Button_ADD).TabIndex = 1044;
		((ButtonBase)Button_ADD).Text = "   Nouveau";
		((ButtonBase)Button_ADD).UseVisualStyleBackColor = false;
		((Control)Button_CLAVIER).BackgroundImage = (Image)componentResourceManager.GetObject("Button_CLAVIER.BackgroundImage");
		((Control)Button_CLAVIER).BackgroundImageLayout = (ImageLayout)4;
		((ButtonBase)Button_CLAVIER).ImeMode = (ImeMode)0;
		Button_CLAVIER_NOSELECT button_CLAVIER = Button_CLAVIER;
		location = new Point(318, 468);
		((Control)button_CLAVIER).Location = location;
		((Control)Button_CLAVIER).Name = "Button_CLAVIER";
		Button_CLAVIER_NOSELECT button_CLAVIER2 = Button_CLAVIER;
		size = new Size(36, 31);
		((Control)button_CLAVIER2).Size = size;
		((Control)Button_CLAVIER).TabIndex = 1028;
		((ButtonBase)Button_CLAVIER).UseVisualStyleBackColor = true;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).BackColor = Color.White;
		size = new Size(1025, 692);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)Text_PRINTER_CL);
		((Control)this).Controls.Add((Control)(object)Label3);
		((Control)this).Controls.Add((Control)(object)Label9);
		((Control)this).Controls.Add((Control)(object)DateTimePicker2);
		((Control)this).Controls.Add((Control)(object)DateTimePicker1);
		((Control)this).Controls.Add((Control)(object)Label4141);
		((Control)this).Controls.Add((Control)(object)Panel_FIND);
		((Control)this).Controls.Add((Control)(object)Button_ADD);
		((Control)this).Controls.Add((Control)(object)Label_TABLE);
		((Control)this).Controls.Add((Control)(object)Panel_INFO);
		((Control)this).Controls.Add((Control)(object)Panel1);
		((Control)this).Controls.Add((Control)(object)DataGridView1);
		((Control)this).Controls.Add((Control)(object)Button_PrintRapport);
		((Control)this).Controls.Add((Control)(object)Button_ConsRapport);
		((Control)this).Controls.Add((Control)(object)Button_OK);
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Form)this).KeyPreview = true;
		((Control)this).Name = "Form_6_DEPENSES";
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).WindowState = (FormWindowState)2;
		((ISupportInitialize)DataGridView1).EndInit();
		((Control)FlowLayoutPanel1).ResumeLayout(false);
		((Control)Panel_INFO).ResumeLayout(false);
		((Control)TabControl1).ResumeLayout(false);
		((Control)TabPage1).ResumeLayout(false);
		((Control)TabPage1).PerformLayout();
		((Control)Panel_CLAVIER).ResumeLayout(false);
		((Control)TableLayoutPanel2).ResumeLayout(false);
		((Control)TableLayoutPanel1).ResumeLayout(false);
		((Control)Panel_FIND).ResumeLayout(false);
		((Control)Panel_FIND).PerformLayout();
		((ISupportInitialize)Picture_EXPORT).EndInit();
		((Control)Panel_DATES).ResumeLayout(false);
		((ISupportInitialize)Picture_FIND_DATES).EndInit();
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)Panel2).ResumeLayout(false);
		((Control)Panel2).PerformLayout();
		((ISupportInitialize)Picture_REFRESH).EndInit();
		((ISupportInitialize)Picture_FIND).EndInit();
		((Control)Panel1).ResumeLayout(false);
		((ISupportInitialize)DataGridView2).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Label_TOP_MouseDown(object sender, MouseEventArgs e)
	{
		checked
		{
			x = Control.MousePosition.X - ((Control)Panel_INFO).Location.X;
			y = Control.MousePosition.Y - ((Control)Panel_INFO).Location.Y;
		}
	}

	private void Label_TOP_MouseMove(object sender, MouseEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Invalid comparison between Unknown and I4
		if ((int)e.Button == 1048576)
		{
			newpoint = Control.MousePosition;
			checked
			{
				newpoint.X -= x;
				newpoint.Y -= y;
				((Control)Panel_INFO).Location = newpoint;
				Application.DoEvents();
			}
		}
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

	private void Form_6_MOUVEMENTS_STOCK_FormClosed(object sender, FormClosedEventArgs e)
	{
		DT.Clear();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected Obj, but got Unknown
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected Obj, but got Unknown
		//IL_049a: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a1: Expected Obj, but got Unknown
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Expected Obj, but got Unknown
		//IL_033b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0341: Expected Obj, but got Unknown
		//IL_0355: Unknown result type (might be due to invalid IL or missing references)
		//IL_035b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0395: Unknown result type (might be due to invalid IL or missing references)
		//IL_039f: Expected Obj, but got Unknown
		checked
		{
			try
			{
				Combo_FIND.SelectedIndex = 0;
				DateTime1_FIND.Text = "01/01/2000";
				DateTime2_FIND.Text = Conversions.ToString(DateTime.Now.Date);
				DataGridView1.AutoGenerateColumns = false;
				DataGridView1.RowTemplate.Height = 30;
				DataGridView1.BackgroundColor = Color.White;
				DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(34, 34, 34);
				DataGridView1.DefaultCellStyle.SelectionBackColor = Color.Yellow;
				DataGridView1.DefaultCellStyle.SelectionForeColor = Color.Red;
				DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(221, 235, 247);
				DataGridView1.GridColor = Color.FromArgb(231, 231, 231);
				DataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10f, (FontStyle)1);
				DataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 10f, (FontStyle)0);
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
				DA = new MySqlDataAdapter("select * from     TABLE_DEPENSES             order by       ID      DESC", Module1.cn_SQL);
				DT = new DataTable();
				DT.Clear();
				((DbDataAdapter)(object)DA).Fill(DT);
				DataGridView1.DataSource = DT;
				TabControl1.SizeMode = (TabSizeMode)2;
				TabControl tabControl = TabControl1;
				Size itemSize = new Size((int)Math.Round((double)((Control)TabControl1).Width / (double)TabControl1.TabCount - 4.0), 28);
				tabControl.ItemSize = itemSize;
				StringReader stringReader = new StringReader(MyProject.Forms.Form_0_TEMPLATE.ListView1.Items[MyProject.Forms.Form_0_TEMPLATE.ListView1.FindItemWithText("DEPENSES", false, 0).Index].SubItems[1].Text);
				((Control)FlowLayoutPanel1).Controls.Clear();
				while (stringReader.Peek() != -1)
				{
					Button val = new Button();
					((ButtonBase)val).Text = stringReader.ReadLine();
					Padding margin = new Padding(0, 0, 0, 0);
					((Control)val).Margin = margin;
					((ButtonBase)val).FlatStyle = (FlatStyle)2;
					((Control)val).Width = 118;
					((Control)val).Height = 44;
					((Control)val).Cursor = Cursors.Hand;
					((Control)val).Font = new Font("Calibri", 10f, (FontStyle)1);
					((Control)val).Click += B_click;
					((Control)FlowLayoutPanel1).Controls.Add((Control)(object)val);
				}
				stringReader.Close();
				Text_PRINTER_CL.Text = File.ReadAllText(Application.StartupPath + "/PRINTER_CL.sni");
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
	}

	public void B_click(object sender, EventArgs e)
	{
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected Obj, but got Unknown
		try
		{
			Text_DEPENSE.Text = Conversions.ToString(NewLateBinding.LateGet(sender, null, "text", new object[0], null, null, null));
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

	private void Button_ADD_Click(object sender, EventArgs e)
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected Obj, but got Unknown
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected Obj, but got Unknown
		checked
		{
			try
			{
				((Control)Panel_INFO).Visible = true;
				((Control)Panel_INFO).BringToFront();
				Label_TOP.Text = "NOUVEAU";
				MySqlCommand val = new MySqlCommand();
				val.CommandText = "SELECT MAX(ID) From TABLE_DEPENSES   ";
				val.Connection = Module1.cn_SQL;
				val.CommandType = CommandType.Text;
				if (Module1.cn_SQL.State != ConnectionState.Open)
				{
					Module1.cn_SQL.Open();
				}
				int num = ((val.ExecuteScalar() == DBNull.Value) ? 1 : ((int)Math.Round(Conversions.ToDouble(val.ExecuteScalar()) + 1.0)));
				Module1.cn_SQL.Close();
				Text_ID.Text = Conversions.ToString(num);
				DateTimePicker_DATE.Text = Conversions.ToString(DateTime.Now.Date);
				Text_UTILISATEUR.Text = Module1._USERNAME;
				Text_DEPENSE.Text = "";
				Text_MONTANT.Text = "";
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
	}

	private void Text_TEL_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (((Operators.CompareString(Conversions.ToString(e.KeyChar), "0", TextCompare: false) < 0) | (Operators.CompareString(Conversions.ToString(e.KeyChar), "9", TextCompare: false) > 0)) & (e.KeyChar != '\b') & (e.KeyChar != '.') & (e.KeyChar != '-'))
		{
			e.Handled = true;
		}
	}

	private void Text_TEL_TextChanged(object sender, EventArgs e)
	{
	}

	private void Button_SAVE_Click(object sender, EventArgs e)
	{
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Expected Obj, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected Obj, but got Unknown
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			try
			{
				if (Operators.CompareString(Text_DEPENSE.Text, "", TextCompare: false) == 0)
				{
					MessageBox.Show("Veuillez remplir le champ -DEPENSE- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
				if (Operators.CompareString(Text_MONTANT.Text, "", TextCompare: false) == 0)
				{
					MessageBox.Show("Veuillez remplir le champ -MONTANT- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
				if (Operators.CompareString(Label_TOP.Text, "NOUVEAU", TextCompare: false) == 0)
				{
					DT.Rows.Add();
					int index = DT.Rows.Count - 1;
					DT.Rows[index]["ID"] = Text_ID.Text;
					DT.Rows[index]["DATES"] = DateTimePicker_DATE.Value;
					DT.Rows[index]["HEURE"] = DateTime.Now.ToString("HH:mm:ss");
					DT.Rows[index]["UTILISATEUR"] = Text_UTILISATEUR.Text;
					DT.Rows[index]["DEPENSE"] = Text_DEPENSE.Text;
					DT.Rows[index]["MONTANT"] = Text_MONTANT.Text;
					MySqlCommandBuilder val = new MySqlCommandBuilder(DA);
					((DbDataAdapter)(object)DA).Update(DT);
					DT.AcceptChanges();
					MessageBox.Show("Enregistré avec succès", "ok", (MessageBoxButtons)0, (MessageBoxIcon)64, (MessageBoxDefaultButton)0);
				}
				((Control)Panel_INFO).Hide();
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
	}

	private void Button_CLOSE_Click(object sender, EventArgs e)
	{
		((Control)Panel_INFO).Hide();
	}

	private void Text_DEPENSE_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (e.KeyChar == '\'')
		{
			e.Handled = true;
		}
	}

	private void Button34_Click(object sender, EventArgs e)
	{
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected Obj, but got Unknown
		try
		{
			Interaction.Shell(Application.StartupPath + "\\CLAVIER.exe");
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

	private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
	}

	private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Expected Obj, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Invalid comparison between Unknown and I4
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Expected Obj, but got Unknown
		try
		{
			if ((Operators.ConditionalCompareObjectEqual(e.ColumnIndex, Operators.SubtractObject(NewLateBinding.LateGet(sender, null, "ColumnCount", new object[0], null, null, null), 1), TextCompare: false) && e.RowIndex >= 0) ? true : false)
			{
				((Control)Panel_INFO).Hide();
				if ((int)MessageBox.Show("Voulez-vous vraiment supprimer ??", "Suppression", (MessageBoxButtons)1, (MessageBoxIcon)32, (MessageBoxDefaultButton)0) == 1)
				{
					string right = Conversions.ToString(Operators.ConcatenateObject("SUPPRESION | ", DataGridView1.Rows[((DataGridViewBand)DataGridView1.CurrentRow).Index].Cells[2].Value));
					File.AppendAllText(Application.StartupPath + "\\log.sni", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(Strings.Format(DateTime.Now, "ddMMyy HHmmss fff") + MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text, " | "), Module1._USERNAME), " | "), ((Control)this).Name), " | "), NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null)), " | "), right), "\r\n")), Encoding.UTF8);
					int position = ((ContainerControl)this).BindingContext[(object)DT].Position;
					DT.Rows[position].Delete();
					MySqlCommandBuilder val = new MySqlCommandBuilder(DA);
					((DbDataAdapter)(object)DA).Update(DT);
					DT.AcceptChanges();
					((ContainerControl)this).BindingContext[(object)DT].Position = position;
				}
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
				string right2 = "ERROR | ";
				File.AppendAllText(Application.StartupPath + "\\log_erreur.sni", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(text + " | ", MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text), " | "), Module1._USERNAME), " | "), ((Control)this).Name), " | "), NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null)), " | "), right2), " | "), ex2.ToString()), "\r\n"), "Ligne : "), fileLineNumber), "\r\n"), "\r\n"), "##########################################################################################################"), "\r\n")), Encoding.UTF8);
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

	private void Text_FIND_TextChanged(object sender, EventArgs e)
	{
		Picture_FIND_Click(RuntimeHelpers.GetObjectValue(sender), e);
	}

	private void Picture_FIND_DATES_Click(object sender, EventArgs e)
	{
		Picture_FIND_Click(RuntimeHelpers.GetObjectValue(sender), e);
	}

	private void Picture_FIND_Click(object sender, EventArgs e)
	{
		//IL_044b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0452: Expected Obj, but got Unknown
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected Obj, but got Unknown
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Expected Obj, but got Unknown
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Expected Obj, but got Unknown
		checked
		{
			try
			{
				if (Operators.CompareString(Combo_FIND.Text, "DATES", TextCompare: false) == 0)
				{
					DT.Clear();
					DA = new MySqlDataAdapter("select * from     TABLE_" + Label_TABLE.Text + "      Where       Dates   between   ' " + Strings.Format(DateTime1_FIND.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTime2_FIND.Value, "yyyy-MM-dd") + " '               order by   ID    desc ", Module1.cn_SQL);
					((DbDataAdapter)(object)DA).Fill(DT);
				}
				else
				{
					if (Check_FIND_DATE.Checked)
					{
						_sql = "        Dates   between   ' " + Strings.Format(DateTime1_FIND.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTime2_FIND.Value, "yyyy-MM-dd") + " '         AND     ";
					}
					else
					{
						_sql = "";
					}
					if (!Check_FIND_EXACTE.Checked)
					{
						DT.Clear();
						DA = new MySqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat("select * from     TABLE_" + Label_TABLE.Text, "      Where           "), _sql), "             ("), Combo_FIND.Text), "  like  '%"), Text_FIND.Text), "%'   )                                order by   ID    desc ")), Module1.cn_SQL);
						((DbDataAdapter)(object)DA).Fill(DT);
					}
					else if (Check_FIND_EXACTE.Checked)
					{
						DT.Clear();
						DA = new MySqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat("select * from     TABLE_" + Label_TABLE.Text, "      Where           "), _sql), "              ("), Combo_FIND.Text), "  like  '"), Text_FIND.Text), "'     )                                order by   ID    desc ")), Module1.cn_SQL);
						((DbDataAdapter)(object)DA).Fill(DT);
					}
				}
				DataGridView1.DataSource = DT;
				decimal num = 0m;
				int num2 = DataGridView1.Rows.Count - 1;
				int num3 = 0;
				while (true)
				{
					int num4 = num3;
					int num5 = num2;
					if (num4 > num5)
					{
						break;
					}
					num = Conversions.ToDecimal(Operators.AddObject(num, DataGridView1.Rows[num3].Cells["Montant"].Value));
					num3++;
				}
				Label4141.Text = "TOTAL_NET : " + Strings.FormatNumber(num) + " DH";
				if (Operators.CompareString(Text_FIND.Text, "", TextCompare: false) == 0)
				{
					((Control)Label4141).Visible = false;
				}
				else
				{
					((Control)Label4141).Visible = true;
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

	private void Picture_REFRESH_Click(object sender, EventArgs e)
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected Obj, but got Unknown
		try
		{
			Text_FIND.Text = "";
			DT.Clear();
			DA = new MySqlDataAdapter("select * from      TABLE_" + Label_TABLE.Text + "                  order by   ID    desc ", Module1.cn_SQL);
			((DbDataAdapter)(object)DA).Fill(DT);
			DataGridView1.DataSource = DT;
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

	private void Check_FIND_DATE_CheckedChanged(object sender, EventArgs e)
	{
		if (Check_FIND_DATE.Checked)
		{
			((Control)Panel_DATES).Visible = true;
		}
		else
		{
			((Control)Panel_DATES).Visible = false;
		}
	}

	private void Combo_FIND_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (Operators.CompareString(Combo_FIND.Text, "DATES", TextCompare: false) == 0)
		{
			((Control)Panel_DATES).Visible = true;
			((Control)Panel_DATES).Left = 78;
			Text_FIND.Text = "*";
		}
		else
		{
			((Control)Panel_DATES).Visible = false;
			((Control)Panel_DATES).Left = 417;
			Text_FIND.Text = "";
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
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected Obj, but got Unknown
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Expected Obj, but got Unknown
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Expected Obj, but got Unknown
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

	private void Print_Recette_Globale_PrintPage(object sender, PrintPageEventArgs e)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected Obj, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected Obj, but got Unknown
		//IL_008d: Expected Obj, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected Obj, but got Unknown
		//IL_0105: Expected Obj, but got Unknown
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected Obj, but got Unknown
		//IL_013f: Expected Obj, but got Unknown
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Expected Obj, but got Unknown
		//IL_0179: Expected Obj, but got Unknown
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected Obj, but got Unknown
		//IL_01b3: Expected Obj, but got Unknown
		//IL_05ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b4: Expected Obj, but got Unknown
		//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Expected Obj, but got Unknown
		//IL_0300: Expected Obj, but got Unknown
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_032d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0337: Expected Obj, but got Unknown
		//IL_0337: Expected Obj, but got Unknown
		//IL_0348: Unknown result type (might be due to invalid IL or missing references)
		//IL_034e: Expected Obj, but got Unknown
		//IL_03c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cb: Expected Obj, but got Unknown
		//IL_0420: Unknown result type (might be due to invalid IL or missing references)
		//IL_044e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0458: Expected Obj, but got Unknown
		//IL_0458: Expected Obj, but got Unknown
		//IL_0485: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bd: Expected Obj, but got Unknown
		//IL_04bd: Expected Obj, but got Unknown
		//IL_04d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0502: Unknown result type (might be due to invalid IL or missing references)
		//IL_050c: Expected Obj, but got Unknown
		//IL_050c: Expected Obj, but got Unknown
		checked
		{
			try
			{
				e.Graphics.FillRectangle((Brush)new SolidBrush(Color.Silver), 0, 0, 300, 15);
				string text = "RAPPORT DEPENSE";
				e.Graphics.DrawString(text, new Font("Lucida Console", 10f, (FontStyle)1), Brushes.Black, Convert.ToSingle(130f - e.Graphics.MeasureString(text, new Font("Lucida Console", 10f, (FontStyle)1)).Width / 2f), 0f, new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("Rapport :" + Strings.Format(DateTimePicker1.Value, "yyyy-MM-ddy") + "==>" + Strings.Format(DateTimePicker2.Value, "yyyy-MM-ddy"), new Font("Lucida Console", 6.4f, (FontStyle)0), Brushes.Black, 0f, 95f, new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("-----------------------------------------", new Font("Lucida Console", 8f, (FontStyle)0), Brushes.Black, 0f, 100f, new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("DEPENSE                      MONTANT  ", new Font("Lucida Console", 7f, (FontStyle)1), Brushes.Black, 0f, 110f, new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("-----------------------------------------", new Font("Lucida Console", 8f, (FontStyle)0), Brushes.Black, 0f, 120f, new StringFormat((StringFormatFlags)8192));
				int num = 0;
				string text2 = "";
				string text3 = "";
				int num2 = DataGridView2.RowCount - 1;
				num = 0;
				while (true)
				{
					int num3 = num;
					int num4 = num2;
					if (num3 > num4)
					{
						break;
					}
					text2 = text2 + Strings.LSet(DataGridView2.Rows[num].Cells["COL_1"].Value.ToString(), 22) + "|" + Environment.NewLine + Environment.NewLine;
					text3 = text3 + Strings.RSet(DataGridView2.Rows[num].Cells["COL_3"].Value.ToString(), 12) + "|" + Environment.NewLine + Environment.NewLine;
					num++;
				}
				e.Graphics.DrawString(text2, new Font("Lucida Console", 7f, (FontStyle)0), Brushes.Black, 0f, 130f, new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString(text3, new Font("Lucida Console", 7f, (FontStyle)0), Brushes.Black, 185f, 130f, new StringFormat((StringFormatFlags)8192));
				double num5 = 0.0;
				DataTable dataTable = new DataTable();
				MySqlDataAdapter val = new MySqlDataAdapter();
				dataTable.Clear();
				val = new MySqlDataAdapter("select sum(MONTANT) as n     from TABLE_DEPENSES WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " ' ", Module1.cn_SQL);
				((DbDataAdapter)(object)val).Fill(dataTable);
				num5 = Conversions.ToDouble(Strings.FormatNumber(Conversion.Val(dataTable.Rows[0]["n"].ToString())));
				e.Graphics.DrawString("-----------------------------------------", new Font("Lucida Console", 8f, (FontStyle)0), Brushes.Black, 0f, (float)(DataGridView2.Rows.Count * 20 + 130), new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("TOTAL NET: " + Strings.RSet(Conversions.ToString(num5), 8) + " DH", new Font("Lucida Console", 12f, (FontStyle)1), Brushes.Black, 0f, (float)(DataGridView2.Rows.Count * 20 + 140), new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("-----------------------------------------", new Font("Lucida Console", 8f, (FontStyle)0), Brushes.Black, 0f, (float)(DataGridView2.Rows.Count * 20 + 150), new StringFormat((StringFormatFlags)8192));
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
					string text4 = Strings.Format(DateTime.Now, "yyMMddHHmmssfff");
					Bitmap val2 = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, (PixelFormat)2498570);
					Graphics val3 = Graphics.FromImage((Image)(object)val2);
					val3.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, (CopyPixelOperation)13369376);
					((Image)val2).Save(Application.StartupPath + "\\tchak\\" + text4 + ".snidb", ImageFormat.Jpeg);
					val2 = null;
					string right = "ERROR | ";
					File.AppendAllText(Application.StartupPath + "\\log_erreur.sni", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(text4 + " | ", MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text), " | "), Module1._USERNAME), " | "), ((Control)this).Name), " | "), NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null)), " | "), right), " | "), ex2.ToString()), "\r\n"), "Ligne : "), fileLineNumber), "\r\n"), "\r\n"), "##########################################################################################################"), "\r\n")), Encoding.UTF8);
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
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected Obj, but got Unknown
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected Obj, but got Unknown
		try
		{
			DT.Clear();
			DA = new MySqlDataAdapter("select * from   TABLE_DEPENSES     Where  Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '    order by ID desc ", Module1.cn_SQL);
			((DbDataAdapter)(object)DA).Fill(DT);
			DataGridView1.DataSource = DT;
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

	private void Button_ConsRapport_Click(object sender, EventArgs e)
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected Obj, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected Obj, but got Unknown
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Expected Obj, but got Unknown
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Expected Obj, but got Unknown
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
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
				NewLateBinding.LateSet(sender, null, "enabled", new object[1] { false }, null, null);
				DataTable dataTable = new DataTable();
				MySqlDataAdapter val = new MySqlDataAdapter();
				DataGridView2.Rows.Clear();
				dataTable.Clear();
				val = new MySqlDataAdapter("select DEPENSE , MONTANT    from   TABLE_DEPENSES    Where    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '            ", Module1.cn_SQL);
				((DbDataAdapter)(object)val).Fill(dataTable);
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
					DataGridView2.Rows.Add(new object[3]
					{
						"  " + dataTable.Rows[num2]["DEPENSE"].ToString(),
						"",
						Strings.FormatNumber(Conversion.Val(dataTable.Rows[num2]["MONTANT"].ToString()))
					});
					num2++;
				}
				if (Operators.CompareString(Text_PRINTER_CL.Text, "0", TextCompare: false) != 0 && Operators.CompareString(Text_PRINTER_CL.Text, "", TextCompare: false) != 0)
				{
					Print_DEPENSES.PrinterSettings.PrinterName = Text_PRINTER_CL.Text;
				}
				int num5 = DataGridView2.Rows.Count * 20 + 200 + 20;
				Print_DEPENSES.DefaultPageSettings.PaperSize = new PaperSize("Custom", 264, num5);
				if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null), "Button_ConsRapport", TextCompare: false))
				{
					PrintPreviewDialog val2 = new PrintPreviewDialog();
					val2.Document = Print_DEPENSES;
					val2.PrintPreviewControl.Zoom = 2.0;
					((Form)val2).WindowState = (FormWindowState)2;
					((Form)val2).ShowDialog();
				}
				else if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null), "Button_PrintRapport", TextCompare: false))
				{
					Print_DEPENSES.Print();
				}
				NewLateBinding.LateSet(sender, null, "enabled", new object[1] { true }, null, null);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				StackTrace stackTrace = new StackTrace(ex2, fNeedFileInfo: true);
				StackFrame frame = stackTrace.GetFrame(stackTrace.FrameCount - 1);
				int fileLineNumber = frame.GetFileLineNumber();
				Module1._QUITTER_PATIENTER = true;
				Interaction.MsgBox(ex2.ToString());
				NewLateBinding.LateSet(sender, null, "enabled", new object[1] { true }, null, null);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void Button24_Click(object sender, EventArgs e)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected Obj, but got Unknown
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected Obj, but got Unknown
		((Form)MyProject.Forms.FormDialog_BLOC_NOTE).Text = "DEPENSES";
		((Form)MyProject.Forms.FormDialog_BLOC_NOTE).ShowDialog();
		StringReader stringReader = new StringReader(MyProject.Forms.Form_0_TEMPLATE.ListView1.Items[MyProject.Forms.Form_0_TEMPLATE.ListView1.FindItemWithText("DEPENSES", false, 0).Index].SubItems[1].Text);
		((Control)FlowLayoutPanel1).Controls.Clear();
		while (stringReader.Peek() != -1)
		{
			Button val = new Button();
			((ButtonBase)val).Text = stringReader.ReadLine();
			Padding margin = new Padding(0, 0, 0, 0);
			((Control)val).Margin = margin;
			((ButtonBase)val).FlatStyle = (FlatStyle)2;
			((Control)val).Width = 118;
			((Control)val).Height = 44;
			((Control)val).Cursor = Cursors.Hand;
			((Control)val).Font = new Font("Calibri", 10f, (FontStyle)1);
			((Control)val).Click += B_click;
			((Control)FlowLayoutPanel1).Controls.Add((Control)(object)val);
		}
		stringReader.Close();
	}

	private void Butt_Click(object sender, EventArgs e)
	{
		Text_MONTANT.Text = Conversions.ToString(Operators.AddObject(Text_MONTANT.Text, NewLateBinding.LateGet(sender, null, "text", new object[0], null, null, null)));
	}

	private void Butt_BACK_Click(object sender, EventArgs e)
	{
		int try0001_dispatch = -1;
		int num3 = default;
		int num = default;
		int num2 = default;
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					break;
				case 90:
					{
						num = num2;
						switch ((num3 <= -2) ? 1 : num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0001;
						}
						int num4 = num + 1;
						num = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 3:
							goto end_IL_0001_3;
						}
						goto default;
					}
					end_IL_0001_2:
					break;
				}
				num2 = 2;
				Text_MONTANT.Text = Text_MONTANT.Text.Remove(checked(Text_MONTANT.Text.Length - 1));
				break;
				end_IL_0001:;
			}
			catch (Exception ex) when ((num3 != 0) & (num == 0))
			{
				ProjectData.SetProjectError(ex);
				try0001_dispatch = 90;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void Butt_DRAFT_Click(object sender, EventArgs e)
	{
		Text_MONTANT.Text = "";
	}

	private void Button_CLAVIER_Click(object sender, EventArgs e)
	{
		try
		{
			Interaction.Shell(Application.StartupPath + "\\CLAVIER.exe");
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
