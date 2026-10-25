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
public class Form_5_CLIENTS_RDV : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("DataGridView1")]
	private DataGridView _DataGridView1;

	[AccessedThroughProperty("Button_ADD")]
	private Button _Button_ADD;

	[AccessedThroughProperty("Panel_INFO")]
	private Panel _Panel_INFO;

	[AccessedThroughProperty("Button_CLOSE")]
	private Button _Button_CLOSE;

	[AccessedThroughProperty("Button_SAVE")]
	private Button _Button_SAVE;

	[AccessedThroughProperty("Text_NOTE")]
	private TextBox _Text_NOTE;

	[AccessedThroughProperty("Text_TELEPHONE")]
	private TextBox _Text_TELEPHONE;

	[AccessedThroughProperty("Text_CLIENT")]
	private TextBox _Text_CLIENT;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	[AccessedThroughProperty("DateTimePicker_DATE")]
	private DateTimePicker _DateTimePicker_DATE;

	[AccessedThroughProperty("Label_BOTTOM")]
	private Label _Label_BOTTOM;

	[AccessedThroughProperty("Label_LEFT")]
	private Label _Label_LEFT;

	[AccessedThroughProperty("Label_RIGHT")]
	private Label _Label_RIGHT;

	[AccessedThroughProperty("Label_INDEX_ROW")]
	private Label _Label_INDEX_ROW;

	[AccessedThroughProperty("Label_TOP")]
	private Label _Label_TOP;

	[AccessedThroughProperty("Button34")]
	private Button _Button34;

	[AccessedThroughProperty("Panel_MOIS")]
	private Panel _Panel_MOIS;

	[AccessedThroughProperty("DataGridView2")]
	private DataGridView _DataGridView2;

	[AccessedThroughProperty("Label_INDEX_COLUMN")]
	private Label _Label_INDEX_COLUMN;

	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	[AccessedThroughProperty("Radio_MOIS_1")]
	private RadioButton _Radio_MOIS_1;

	[AccessedThroughProperty("Radio_MOIS_2")]
	private RadioButton _Radio_MOIS_2;

	[AccessedThroughProperty("Radio_MOIS_4")]
	private RadioButton _Radio_MOIS_4;

	[AccessedThroughProperty("Radio_MOIS_3")]
	private RadioButton _Radio_MOIS_3;

	[AccessedThroughProperty("Radio_MOIS_6")]
	private RadioButton _Radio_MOIS_6;

	[AccessedThroughProperty("Radio_MOIS_5")]
	private RadioButton _Radio_MOIS_5;

	[AccessedThroughProperty("Radio_MOIS_8")]
	private RadioButton _Radio_MOIS_8;

	[AccessedThroughProperty("Radio_MOIS_7")]
	private RadioButton _Radio_MOIS_7;

	[AccessedThroughProperty("Radio_MOIS_12")]
	private RadioButton _Radio_MOIS_12;

	[AccessedThroughProperty("Radio_MOIS_11")]
	private RadioButton _Radio_MOIS_11;

	[AccessedThroughProperty("Radio_MOIS_10")]
	private RadioButton _Radio_MOIS_10;

	[AccessedThroughProperty("Radio_MOIS_9")]
	private RadioButton _Radio_MOIS_9;

	[AccessedThroughProperty("Label_MOIS")]
	private Label _Label_MOIS;

	[AccessedThroughProperty("TextBox_ANNEE")]
	private TextBox _TextBox_ANNEE;

	[AccessedThroughProperty("Label9")]
	private Label _Label9;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("Label11")]
	private Label _Label11;

	[AccessedThroughProperty("Label10")]
	private Label _Label10;

	[AccessedThroughProperty("TableLayoutPanel1")]
	private TableLayoutPanel _TableLayoutPanel1;

	[AccessedThroughProperty("Panel_DETAILS")]
	private Panel _Panel_DETAILS;

	[AccessedThroughProperty("Label15")]
	private Label _Label15;

	[AccessedThroughProperty("Label14")]
	private Label _Label14;

	[AccessedThroughProperty("Label12")]
	private Label _Label12;

	[AccessedThroughProperty("Label13")]
	private Label _Label13;

	[AccessedThroughProperty("Label16")]
	private Label _Label16;

	[AccessedThroughProperty("Label19")]
	private Label _Label19;

	[AccessedThroughProperty("Label20")]
	private Label _Label20;

	[AccessedThroughProperty("Label17")]
	private Label _Label17;

	[AccessedThroughProperty("Label18")]
	private Label _Label18;

	[AccessedThroughProperty("PictureBox2")]
	private PictureBox _PictureBox2;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	[AccessedThroughProperty("PictureBox3")]
	private PictureBox _PictureBox3;

	[AccessedThroughProperty("Panel5")]
	private Panel _Panel5;

	[AccessedThroughProperty("PictureBox5")]
	private PictureBox _PictureBox5;

	[AccessedThroughProperty("Label21")]
	private Label _Label21;

	[AccessedThroughProperty("Label22")]
	private Label _Label22;

	[AccessedThroughProperty("Label23")]
	private Label _Label23;

	[AccessedThroughProperty("Label_CEMOIS")]
	private Label _Label_CEMOIS;

	[AccessedThroughProperty("Label_DEMAIN")]
	private Label _Label_DEMAIN;

	[AccessedThroughProperty("Label_AUJOURDHUI")]
	private Label _Label_AUJOURDHUI;

	[AccessedThroughProperty("Button_CALC")]
	private Button _Button_CALC;

	[AccessedThroughProperty("Text_HEURE_DEPART")]
	private TextBox _Text_HEURE_DEPART;

	[AccessedThroughProperty("PictureBox4")]
	private PictureBox _PictureBox4;

	[AccessedThroughProperty("Label24")]
	private Label _Label24;

	[AccessedThroughProperty("Button_EDIT")]
	private Button _Button_EDIT;

	[AccessedThroughProperty("TableLayoutPanel2")]
	private TableLayoutPanel _TableLayoutPanel2;

	[AccessedThroughProperty("Text_INTERVALE")]
	private TextBox _Text_INTERVALE;

	[AccessedThroughProperty("RadioButton1")]
	private RadioButton _RadioButton1;

	[AccessedThroughProperty("RadioButton4")]
	private RadioButton _RadioButton4;

	[AccessedThroughProperty("RadioButton3")]
	private RadioButton _RadioButton3;

	[AccessedThroughProperty("RadioButton2")]
	private RadioButton _RadioButton2;

	[AccessedThroughProperty("Column0")]
	private DataGridViewTextBoxColumn _Column0;

	[AccessedThroughProperty("Column1")]
	private DataGridViewTextBoxColumn _Column1;

	[AccessedThroughProperty("Column2")]
	private DataGridViewTextBoxColumn _Column2;

	[AccessedThroughProperty("Column3")]
	private DataGridViewTextBoxColumn _Column3;

	[AccessedThroughProperty("Column4")]
	private DataGridViewTextBoxColumn _Column4;

	[AccessedThroughProperty("Column5")]
	private DataGridViewTextBoxColumn _Column5;

	[AccessedThroughProperty("Column6")]
	private DataGridViewTextBoxColumn _Column6;

	[AccessedThroughProperty("Column7")]
	private DataGridViewTextBoxColumn _Column7;

	[AccessedThroughProperty("Column8")]
	private DataGridViewTextBoxColumn _Column8;

	[AccessedThroughProperty("Column9")]
	private DataGridViewTextBoxColumn _Column9;

	[AccessedThroughProperty("Column10")]
	private DataGridViewTextBoxColumn _Column10;

	[AccessedThroughProperty("Column11")]
	private DataGridViewTextBoxColumn _Column11;

	[AccessedThroughProperty("Column12")]
	private DataGridViewTextBoxColumn _Column12;

	[AccessedThroughProperty("Column13")]
	private DataGridViewTextBoxColumn _Column13;

	[AccessedThroughProperty("Column14")]
	private DataGridViewTextBoxColumn _Column14;

	[AccessedThroughProperty("Column15")]
	private DataGridViewTextBoxColumn _Column15;

	[AccessedThroughProperty("Column16")]
	private DataGridViewTextBoxColumn _Column16;

	[AccessedThroughProperty("Column17")]
	private DataGridViewTextBoxColumn _Column17;

	[AccessedThroughProperty("Column18")]
	private DataGridViewTextBoxColumn _Column18;

	[AccessedThroughProperty("Column19")]
	private DataGridViewTextBoxColumn _Column19;

	[AccessedThroughProperty("Column20")]
	private DataGridViewTextBoxColumn _Column20;

	[AccessedThroughProperty("Column21")]
	private DataGridViewTextBoxColumn _Column21;

	[AccessedThroughProperty("Column22")]
	private DataGridViewTextBoxColumn _Column22;

	[AccessedThroughProperty("Column23")]
	private DataGridViewTextBoxColumn _Column23;

	[AccessedThroughProperty("Column24")]
	private DataGridViewTextBoxColumn _Column24;

	[AccessedThroughProperty("Column25")]
	private DataGridViewTextBoxColumn _Column25;

	[AccessedThroughProperty("Column26")]
	private DataGridViewTextBoxColumn _Column26;

	[AccessedThroughProperty("Column27")]
	private DataGridViewTextBoxColumn _Column27;

	[AccessedThroughProperty("Column28")]
	private DataGridViewTextBoxColumn _Column28;

	[AccessedThroughProperty("Column29")]
	private DataGridViewTextBoxColumn _Column29;

	[AccessedThroughProperty("Column30")]
	private DataGridViewTextBoxColumn _Column30;

	[AccessedThroughProperty("Column31")]
	private DataGridViewTextBoxColumn _Column31;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[AccessedThroughProperty("ListBox_HEURE")]
	private ListBox _ListBox_HEURE;

	[AccessedThroughProperty("Button20")]
	private Button _Button20;

	[AccessedThroughProperty("Button5")]
	private Button _Button5;

	[AccessedThroughProperty("ListBox_VENDEURS")]
	private ListBox _ListBox_VENDEURS;

	[AccessedThroughProperty("DataGridView3")]
	private DataGridView _DataGridView3;

	[AccessedThroughProperty("Button244")]
	private Button _Button244;

	[AccessedThroughProperty("Label_INDEX")]
	private Label _Label_INDEX;

	[AccessedThroughProperty("Label33")]
	private Label _Label33;

	[AccessedThroughProperty("ID")]
	private DataGridViewTextBoxColumn _ID;

	[AccessedThroughProperty("CLIENT")]
	private DataGridViewTextBoxColumn _CLIENT;

	[AccessedThroughProperty("DATES")]
	private DataGridViewTextBoxColumn _DATES;

	[AccessedThroughProperty("HEURE")]
	private DataGridViewTextBoxColumn _HEURE;

	[AccessedThroughProperty("TELEPHONE")]
	private DataGridViewTextBoxColumn _TELEPHONE;

	[AccessedThroughProperty("NOTES")]
	private DataGridViewTextBoxColumn _NOTES;

	[AccessedThroughProperty("Button3")]
	private Button _Button3;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	private MySqlDataAdapter DA;

	private DataTable DT;

	private int x;

	private int y;

	private Point newpoint;

	public int _nbr_jours;

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
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected Obj, but got Unknown
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Expected Obj, but got Unknown
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Expected Obj, but got Unknown
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Expected Obj, but got Unknown
			EventHandler eventHandler = DataGridView1_MouseEnter;
			EventHandler eventHandler2 = DataGridView1_DoubleClick;
			DataGridViewCellEventHandler val = DataGridView1_CellDoubleClick;
			DataGridViewCellEventHandler val2 = DataGridView1_CellMouseEnter;
			DataGridViewCellEventHandler val3 = DataGridView1_CellClick;
			DataGridViewCellEventHandler val4 = DataGridView1_CellContentClick;
			if (_DataGridView1 != null)
			{
				((Control)_DataGridView1).MouseEnter -= eventHandler;
				((Control)_DataGridView1).DoubleClick -= eventHandler2;
				_DataGridView1.CellDoubleClick -= val;
				_DataGridView1.CellMouseEnter -= val2;
				_DataGridView1.CellClick -= val3;
				_DataGridView1.CellContentClick -= val4;
			}
			_DataGridView1 = value;
			if (_DataGridView1 != null)
			{
				((Control)_DataGridView1).MouseEnter += eventHandler;
				((Control)_DataGridView1).DoubleClick += eventHandler2;
				_DataGridView1.CellDoubleClick += val;
				_DataGridView1.CellMouseEnter += val2;
				_DataGridView1.CellClick += val3;
				_DataGridView1.CellContentClick += val4;
			}
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
			EventHandler eventHandler = Button11_Click;
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
			EventHandler eventHandler = Button12_Click;
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

	internal virtual TextBox Text_NOTE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_NOTE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			KeyPressEventHandler val = TextBox6_KeyPress;
			if (_Text_NOTE != null)
			{
				((Control)_Text_NOTE).KeyPress -= val;
			}
			_Text_NOTE = value;
			if (_Text_NOTE != null)
			{
				((Control)_Text_NOTE).KeyPress += val;
			}
		}
	}

	internal virtual TextBox Text_TELEPHONE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_TELEPHONE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_TELEPHONE = value;
		}
	}

	internal virtual TextBox Text_CLIENT
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_CLIENT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			KeyPressEventHandler val = TextBox2_KeyPress;
			if (_Text_CLIENT != null)
			{
				((Control)_Text_CLIENT).KeyPress -= val;
			}
			_Text_CLIENT = value;
			if (_Text_CLIENT != null)
			{
				((Control)_Text_CLIENT).KeyPress += val;
			}
		}
	}

	internal virtual Label Label4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label4 = value;
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

	internal virtual Label Label8
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label8 = value;
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

	internal virtual Label Label_INDEX_ROW
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_INDEX_ROW;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_INDEX_ROW = value;
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
			MouseEventHandler val = Label_TOP_MouseDown;
			MouseEventHandler val2 = Label_TOP_MouseMove;
			if (_Label_TOP != null)
			{
				((Control)_Label_TOP).MouseDown -= val;
				((Control)_Label_TOP).MouseMove -= val2;
			}
			_Label_TOP = value;
			if (_Label_TOP != null)
			{
				((Control)_Label_TOP).MouseDown += val;
				((Control)_Label_TOP).MouseMove += val2;
			}
		}
	}

	internal virtual Button Button34
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button34;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button34_Click;
			if (_Button34 != null)
			{
				((Control)_Button34).Click -= eventHandler;
			}
			_Button34 = value;
			if (_Button34 != null)
			{
				((Control)_Button34).Click += eventHandler;
			}
		}
	}

	internal virtual Panel Panel_MOIS
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel_MOIS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel_MOIS = value;
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

	internal virtual Label Label_INDEX_COLUMN
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_INDEX_COLUMN;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_INDEX_COLUMN = value;
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

	internal virtual RadioButton Radio_MOIS_1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Radio_MOIS_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Radio_MOIS_Click;
			EventHandler eventHandler2 = Radio_MOIS_CheckedChanged;
			if (_Radio_MOIS_1 != null)
			{
				((Control)_Radio_MOIS_1).Click -= eventHandler;
				_Radio_MOIS_1.CheckedChanged -= eventHandler2;
			}
			_Radio_MOIS_1 = value;
			if (_Radio_MOIS_1 != null)
			{
				((Control)_Radio_MOIS_1).Click += eventHandler;
				_Radio_MOIS_1.CheckedChanged += eventHandler2;
			}
		}
	}

	internal virtual RadioButton Radio_MOIS_2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Radio_MOIS_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Radio_MOIS_Click;
			EventHandler eventHandler2 = Radio_MOIS_CheckedChanged;
			if (_Radio_MOIS_2 != null)
			{
				((Control)_Radio_MOIS_2).Click -= eventHandler;
				_Radio_MOIS_2.CheckedChanged -= eventHandler2;
			}
			_Radio_MOIS_2 = value;
			if (_Radio_MOIS_2 != null)
			{
				((Control)_Radio_MOIS_2).Click += eventHandler;
				_Radio_MOIS_2.CheckedChanged += eventHandler2;
			}
		}
	}

	internal virtual RadioButton Radio_MOIS_4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Radio_MOIS_4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Radio_MOIS_Click;
			EventHandler eventHandler2 = Radio_MOIS_CheckedChanged;
			if (_Radio_MOIS_4 != null)
			{
				((Control)_Radio_MOIS_4).Click -= eventHandler;
				_Radio_MOIS_4.CheckedChanged -= eventHandler2;
			}
			_Radio_MOIS_4 = value;
			if (_Radio_MOIS_4 != null)
			{
				((Control)_Radio_MOIS_4).Click += eventHandler;
				_Radio_MOIS_4.CheckedChanged += eventHandler2;
			}
		}
	}

	internal virtual RadioButton Radio_MOIS_3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Radio_MOIS_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Radio_MOIS_Click;
			EventHandler eventHandler2 = Radio_MOIS_CheckedChanged;
			if (_Radio_MOIS_3 != null)
			{
				((Control)_Radio_MOIS_3).Click -= eventHandler;
				_Radio_MOIS_3.CheckedChanged -= eventHandler2;
			}
			_Radio_MOIS_3 = value;
			if (_Radio_MOIS_3 != null)
			{
				((Control)_Radio_MOIS_3).Click += eventHandler;
				_Radio_MOIS_3.CheckedChanged += eventHandler2;
			}
		}
	}

	internal virtual RadioButton Radio_MOIS_6
	{
		[DebuggerNonUserCode]
		get
		{
			return _Radio_MOIS_6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Radio_MOIS_Click;
			EventHandler eventHandler2 = Radio_MOIS_CheckedChanged;
			if (_Radio_MOIS_6 != null)
			{
				((Control)_Radio_MOIS_6).Click -= eventHandler;
				_Radio_MOIS_6.CheckedChanged -= eventHandler2;
			}
			_Radio_MOIS_6 = value;
			if (_Radio_MOIS_6 != null)
			{
				((Control)_Radio_MOIS_6).Click += eventHandler;
				_Radio_MOIS_6.CheckedChanged += eventHandler2;
			}
		}
	}

	internal virtual RadioButton Radio_MOIS_5
	{
		[DebuggerNonUserCode]
		get
		{
			return _Radio_MOIS_5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Radio_MOIS_Click;
			EventHandler eventHandler2 = Radio_MOIS_CheckedChanged;
			if (_Radio_MOIS_5 != null)
			{
				((Control)_Radio_MOIS_5).Click -= eventHandler;
				_Radio_MOIS_5.CheckedChanged -= eventHandler2;
			}
			_Radio_MOIS_5 = value;
			if (_Radio_MOIS_5 != null)
			{
				((Control)_Radio_MOIS_5).Click += eventHandler;
				_Radio_MOIS_5.CheckedChanged += eventHandler2;
			}
		}
	}

	internal virtual RadioButton Radio_MOIS_8
	{
		[DebuggerNonUserCode]
		get
		{
			return _Radio_MOIS_8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Radio_MOIS_Click;
			EventHandler eventHandler2 = Radio_MOIS_CheckedChanged;
			if (_Radio_MOIS_8 != null)
			{
				((Control)_Radio_MOIS_8).Click -= eventHandler;
				_Radio_MOIS_8.CheckedChanged -= eventHandler2;
			}
			_Radio_MOIS_8 = value;
			if (_Radio_MOIS_8 != null)
			{
				((Control)_Radio_MOIS_8).Click += eventHandler;
				_Radio_MOIS_8.CheckedChanged += eventHandler2;
			}
		}
	}

	internal virtual RadioButton Radio_MOIS_7
	{
		[DebuggerNonUserCode]
		get
		{
			return _Radio_MOIS_7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Radio_MOIS_Click;
			EventHandler eventHandler2 = Radio_MOIS_CheckedChanged;
			if (_Radio_MOIS_7 != null)
			{
				((Control)_Radio_MOIS_7).Click -= eventHandler;
				_Radio_MOIS_7.CheckedChanged -= eventHandler2;
			}
			_Radio_MOIS_7 = value;
			if (_Radio_MOIS_7 != null)
			{
				((Control)_Radio_MOIS_7).Click += eventHandler;
				_Radio_MOIS_7.CheckedChanged += eventHandler2;
			}
		}
	}

	internal virtual RadioButton Radio_MOIS_12
	{
		[DebuggerNonUserCode]
		get
		{
			return _Radio_MOIS_12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Radio_MOIS_Click;
			EventHandler eventHandler2 = Radio_MOIS_CheckedChanged;
			if (_Radio_MOIS_12 != null)
			{
				((Control)_Radio_MOIS_12).Click -= eventHandler;
				_Radio_MOIS_12.CheckedChanged -= eventHandler2;
			}
			_Radio_MOIS_12 = value;
			if (_Radio_MOIS_12 != null)
			{
				((Control)_Radio_MOIS_12).Click += eventHandler;
				_Radio_MOIS_12.CheckedChanged += eventHandler2;
			}
		}
	}

	internal virtual RadioButton Radio_MOIS_11
	{
		[DebuggerNonUserCode]
		get
		{
			return _Radio_MOIS_11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Radio_MOIS_Click;
			EventHandler eventHandler2 = Radio_MOIS_CheckedChanged;
			if (_Radio_MOIS_11 != null)
			{
				((Control)_Radio_MOIS_11).Click -= eventHandler;
				_Radio_MOIS_11.CheckedChanged -= eventHandler2;
			}
			_Radio_MOIS_11 = value;
			if (_Radio_MOIS_11 != null)
			{
				((Control)_Radio_MOIS_11).Click += eventHandler;
				_Radio_MOIS_11.CheckedChanged += eventHandler2;
			}
		}
	}

	internal virtual RadioButton Radio_MOIS_10
	{
		[DebuggerNonUserCode]
		get
		{
			return _Radio_MOIS_10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Radio_MOIS_Click;
			EventHandler eventHandler2 = Radio_MOIS_CheckedChanged;
			if (_Radio_MOIS_10 != null)
			{
				((Control)_Radio_MOIS_10).Click -= eventHandler;
				_Radio_MOIS_10.CheckedChanged -= eventHandler2;
			}
			_Radio_MOIS_10 = value;
			if (_Radio_MOIS_10 != null)
			{
				((Control)_Radio_MOIS_10).Click += eventHandler;
				_Radio_MOIS_10.CheckedChanged += eventHandler2;
			}
		}
	}

	internal virtual RadioButton Radio_MOIS_9
	{
		[DebuggerNonUserCode]
		get
		{
			return _Radio_MOIS_9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Radio_MOIS_Click;
			EventHandler eventHandler2 = Radio_MOIS_CheckedChanged;
			if (_Radio_MOIS_9 != null)
			{
				((Control)_Radio_MOIS_9).Click -= eventHandler;
				_Radio_MOIS_9.CheckedChanged -= eventHandler2;
			}
			_Radio_MOIS_9 = value;
			if (_Radio_MOIS_9 != null)
			{
				((Control)_Radio_MOIS_9).Click += eventHandler;
				_Radio_MOIS_9.CheckedChanged += eventHandler2;
			}
		}
	}

	internal virtual Label Label_MOIS
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_MOIS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_MOIS = value;
		}
	}

	internal virtual TextBox TextBox_ANNEE
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox_ANNEE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			EventHandler eventHandler = TextBox_ANNEE_TextChanged;
			KeyPressEventHandler val = TextBox_ANNEE_KeyPress;
			if (_TextBox_ANNEE != null)
			{
				((Control)_TextBox_ANNEE).TextChanged -= eventHandler;
				((Control)_TextBox_ANNEE).KeyPress -= val;
			}
			_TextBox_ANNEE = value;
			if (_TextBox_ANNEE != null)
			{
				((Control)_TextBox_ANNEE).TextChanged += eventHandler;
				((Control)_TextBox_ANNEE).KeyPress += val;
			}
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

	internal virtual Label Label7
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label7 = value;
		}
	}

	internal virtual Label Label11
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Label11_Click;
			if (_Label11 != null)
			{
				((Control)_Label11).Click -= eventHandler;
			}
			_Label11 = value;
			if (_Label11 != null)
			{
				((Control)_Label11).Click += eventHandler;
			}
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
			EventHandler eventHandler = Label10_Click;
			if (_Label10 != null)
			{
				((Control)_Label10).Click -= eventHandler;
			}
			_Label10 = value;
			if (_Label10 != null)
			{
				((Control)_Label10).Click += eventHandler;
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

	internal virtual Panel Panel_DETAILS
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel_DETAILS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel_DETAILS = value;
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

	internal virtual Label Label19
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label19;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label19 = value;
		}
	}

	internal virtual Label Label20
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label20;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label20 = value;
		}
	}

	internal virtual Label Label17
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label17;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label17 = value;
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

	internal virtual PictureBox PictureBox2
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox2 = value;
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

	internal virtual PictureBox PictureBox3
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox3 = value;
		}
	}

	internal virtual Panel Panel5
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel5 = value;
		}
	}

	internal virtual PictureBox PictureBox5
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox5 = value;
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
			EventHandler eventHandler = Label21_Click;
			if (_Label21 != null)
			{
				((Control)_Label21).Click -= eventHandler;
			}
			_Label21 = value;
			if (_Label21 != null)
			{
				((Control)_Label21).Click += eventHandler;
			}
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

	internal virtual Label Label_CEMOIS
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_CEMOIS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_CEMOIS = value;
		}
	}

	internal virtual Label Label_DEMAIN
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_DEMAIN;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_DEMAIN = value;
		}
	}

	internal virtual Label Label_AUJOURDHUI
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_AUJOURDHUI;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Label_AUJOURDHUI_Click;
			if (_Label_AUJOURDHUI != null)
			{
				((Control)_Label_AUJOURDHUI).Click -= eventHandler;
			}
			_Label_AUJOURDHUI = value;
			if (_Label_AUJOURDHUI != null)
			{
				((Control)_Label_AUJOURDHUI).Click += eventHandler;
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

	internal virtual TextBox Text_HEURE_DEPART
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_HEURE_DEPART;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_HEURE_DEPART = value;
		}
	}

	internal virtual PictureBox PictureBox4
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox4 = value;
		}
	}

	internal virtual Label Label24
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label24;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label24 = value;
		}
	}

	internal virtual Button Button_EDIT
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_EDIT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_EDIT_Click;
			if (_Button_EDIT != null)
			{
				((Control)_Button_EDIT).Click -= eventHandler;
			}
			_Button_EDIT = value;
			if (_Button_EDIT != null)
			{
				((Control)_Button_EDIT).Click += eventHandler;
			}
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

	internal virtual TextBox Text_INTERVALE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_INTERVALE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_INTERVALE = value;
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
			EventHandler eventHandler = RadioButton1_Click;
			EventHandler eventHandler2 = RadioButton1_CheckedChanged;
			if (_RadioButton1 != null)
			{
				((Control)_RadioButton1).Click -= eventHandler;
				_RadioButton1.CheckedChanged -= eventHandler2;
			}
			_RadioButton1 = value;
			if (_RadioButton1 != null)
			{
				((Control)_RadioButton1).Click += eventHandler;
				_RadioButton1.CheckedChanged += eventHandler2;
			}
		}
	}

	internal virtual RadioButton RadioButton4
	{
		[DebuggerNonUserCode]
		get
		{
			return _RadioButton4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = RadioButton4_Click;
			EventHandler eventHandler2 = RadioButton4_CheckedChanged;
			if (_RadioButton4 != null)
			{
				((Control)_RadioButton4).Click -= eventHandler;
				_RadioButton4.CheckedChanged -= eventHandler2;
			}
			_RadioButton4 = value;
			if (_RadioButton4 != null)
			{
				((Control)_RadioButton4).Click += eventHandler;
				_RadioButton4.CheckedChanged += eventHandler2;
			}
		}
	}

	internal virtual RadioButton RadioButton3
	{
		[DebuggerNonUserCode]
		get
		{
			return _RadioButton3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = RadioButton3_Click;
			EventHandler eventHandler2 = RadioButton3_CheckedChanged;
			if (_RadioButton3 != null)
			{
				((Control)_RadioButton3).Click -= eventHandler;
				_RadioButton3.CheckedChanged -= eventHandler2;
			}
			_RadioButton3 = value;
			if (_RadioButton3 != null)
			{
				((Control)_RadioButton3).Click += eventHandler;
				_RadioButton3.CheckedChanged += eventHandler2;
			}
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
			EventHandler eventHandler = RadioButton2_Click;
			EventHandler eventHandler2 = RadioButton2_CheckedChanged;
			if (_RadioButton2 != null)
			{
				((Control)_RadioButton2).Click -= eventHandler;
				_RadioButton2.CheckedChanged -= eventHandler2;
			}
			_RadioButton2 = value;
			if (_RadioButton2 != null)
			{
				((Control)_RadioButton2).Click += eventHandler;
				_RadioButton2.CheckedChanged += eventHandler2;
			}
		}
	}

	internal virtual DataGridViewTextBoxColumn Column0
	{
		[DebuggerNonUserCode]
		get
		{
			return _Column0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Column0 = value;
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

	internal virtual DataGridViewTextBoxColumn Column2
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

	internal virtual DataGridViewTextBoxColumn Column3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Column3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Column3 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Column4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Column4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Column4 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Column5
	{
		[DebuggerNonUserCode]
		get
		{
			return _Column5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Column5 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Column6
	{
		[DebuggerNonUserCode]
		get
		{
			return _Column6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Column6 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Column7
	{
		[DebuggerNonUserCode]
		get
		{
			return _Column7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Column7 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Column8
	{
		[DebuggerNonUserCode]
		get
		{
			return _Column8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Column8 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Column9
	{
		[DebuggerNonUserCode]
		get
		{
			return _Column9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Column9 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Column10
	{
		[DebuggerNonUserCode]
		get
		{
			return _Column10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Column10 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Column11
	{
		[DebuggerNonUserCode]
		get
		{
			return _Column11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Column11 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Column12
	{
		[DebuggerNonUserCode]
		get
		{
			return _Column12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Column12 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Column13
	{
		[DebuggerNonUserCode]
		get
		{
			return _Column13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Column13 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Column14
	{
		[DebuggerNonUserCode]
		get
		{
			return _Column14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Column14 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Column15
	{
		[DebuggerNonUserCode]
		get
		{
			return _Column15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Column15 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Column16
	{
		[DebuggerNonUserCode]
		get
		{
			return _Column16;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Column16 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Column17
	{
		[DebuggerNonUserCode]
		get
		{
			return _Column17;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Column17 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Column18
	{
		[DebuggerNonUserCode]
		get
		{
			return _Column18;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Column18 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Column19
	{
		[DebuggerNonUserCode]
		get
		{
			return _Column19;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Column19 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Column20
	{
		[DebuggerNonUserCode]
		get
		{
			return _Column20;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Column20 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Column21
	{
		[DebuggerNonUserCode]
		get
		{
			return _Column21;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Column21 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Column22
	{
		[DebuggerNonUserCode]
		get
		{
			return _Column22;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Column22 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Column23
	{
		[DebuggerNonUserCode]
		get
		{
			return _Column23;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Column23 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Column24
	{
		[DebuggerNonUserCode]
		get
		{
			return _Column24;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Column24 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Column25
	{
		[DebuggerNonUserCode]
		get
		{
			return _Column25;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Column25 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Column26
	{
		[DebuggerNonUserCode]
		get
		{
			return _Column26;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Column26 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Column27
	{
		[DebuggerNonUserCode]
		get
		{
			return _Column27;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Column27 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Column28
	{
		[DebuggerNonUserCode]
		get
		{
			return _Column28;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Column28 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Column29
	{
		[DebuggerNonUserCode]
		get
		{
			return _Column29;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Column29 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Column30
	{
		[DebuggerNonUserCode]
		get
		{
			return _Column30;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Column30 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Column31
	{
		[DebuggerNonUserCode]
		get
		{
			return _Column31;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Column31 = value;
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
			EventHandler eventHandler = Button2_Click_1;
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

	internal virtual ListBox ListBox_HEURE
	{
		[DebuggerNonUserCode]
		get
		{
			return _ListBox_HEURE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ListBox_HEURE = value;
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

	internal virtual Button Button5
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button5_Click;
			if (_Button5 != null)
			{
				((Control)_Button5).Click -= eventHandler;
			}
			_Button5 = value;
			if (_Button5 != null)
			{
				((Control)_Button5).Click += eventHandler;
			}
		}
	}

	internal virtual ListBox ListBox_VENDEURS
	{
		[DebuggerNonUserCode]
		get
		{
			return _ListBox_VENDEURS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ListBox_VENDEURS_SelectedIndexChanged;
			EventHandler eventHandler2 = ListBox_VENDEURS_DoubleClick;
			if (_ListBox_VENDEURS != null)
			{
				_ListBox_VENDEURS.SelectedIndexChanged -= eventHandler;
				((Control)_ListBox_VENDEURS).DoubleClick -= eventHandler2;
			}
			_ListBox_VENDEURS = value;
			if (_ListBox_VENDEURS != null)
			{
				_ListBox_VENDEURS.SelectedIndexChanged += eventHandler;
				((Control)_ListBox_VENDEURS).DoubleClick += eventHandler2;
			}
		}
	}

	internal virtual DataGridView DataGridView3
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridView3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			EventHandler eventHandler = DataGridView3_Click;
			DataGridViewCellEventHandler val = DataGridView3_CellContentClick;
			if (_DataGridView3 != null)
			{
				((Control)_DataGridView3).Click -= eventHandler;
				_DataGridView3.CellContentClick -= val;
			}
			_DataGridView3 = value;
			if (_DataGridView3 != null)
			{
				((Control)_DataGridView3).Click += eventHandler;
				_DataGridView3.CellContentClick += val;
			}
		}
	}

	internal virtual Button Button244
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button244;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button244_Click;
			if (_Button244 != null)
			{
				((Control)_Button244).Click -= eventHandler;
			}
			_Button244 = value;
			if (_Button244 != null)
			{
				((Control)_Button244).Click += eventHandler;
			}
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

	internal virtual Label Label33
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label33;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label33 = value;
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

	internal virtual DataGridViewTextBoxColumn CLIENT
	{
		[DebuggerNonUserCode]
		get
		{
			return _CLIENT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CLIENT = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn DATES
	{
		[DebuggerNonUserCode]
		get
		{
			return _DATES;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DATES = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn HEURE
	{
		[DebuggerNonUserCode]
		get
		{
			return _HEURE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_HEURE = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn TELEPHONE
	{
		[DebuggerNonUserCode]
		get
		{
			return _TELEPHONE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TELEPHONE = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn NOTES
	{
		[DebuggerNonUserCode]
		get
		{
			return _NOTES;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_NOTES = value;
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

	public Form_5_CLIENTS_RDV()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected Obj, but got Unknown
		((Control)this).KeyDown += me_KeyDown;
		((Control)this).Resize += Form_5_CLIENTS_RDV_Resize;
		((Form)this).Load += FormDialog_famille_Load;
		((Control)this).Resize += Form_1_LOGIN_Resize;
		__ENCAddToList(this);
		DA = new MySqlDataAdapter();
		DT = new DataTable();
		newpoint = default;
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
		//IL_0018: Expected Obj, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected Obj, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected Obj, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected Obj, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected Obj, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected Obj, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected Obj, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected Obj, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected Obj, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected Obj, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected Obj, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected Obj, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected Obj, but got Unknown
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected Obj, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected Obj, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected Obj, but got Unknown
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected Obj, but got Unknown
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected Obj, but got Unknown
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected Obj, but got Unknown
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected Obj, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected Obj, but got Unknown
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected Obj, but got Unknown
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected Obj, but got Unknown
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected Obj, but got Unknown
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Expected Obj, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected Obj, but got Unknown
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected Obj, but got Unknown
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Expected Obj, but got Unknown
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected Obj, but got Unknown
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected Obj, but got Unknown
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected Obj, but got Unknown
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Expected Obj, but got Unknown
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected Obj, but got Unknown
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Expected Obj, but got Unknown
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Expected Obj, but got Unknown
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Expected Obj, but got Unknown
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Expected Obj, but got Unknown
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Expected Obj, but got Unknown
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Expected Obj, but got Unknown
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Expected Obj, but got Unknown
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Expected Obj, but got Unknown
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Expected Obj, but got Unknown
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Expected Obj, but got Unknown
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Expected Obj, but got Unknown
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Expected Obj, but got Unknown
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Expected Obj, but got Unknown
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Expected Obj, but got Unknown
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Expected Obj, but got Unknown
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Expected Obj, but got Unknown
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Expected Obj, but got Unknown
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Expected Obj, but got Unknown
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Expected Obj, but got Unknown
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Expected Obj, but got Unknown
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected Obj, but got Unknown
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Expected Obj, but got Unknown
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Expected Obj, but got Unknown
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a2: Expected Obj, but got Unknown
		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Expected Obj, but got Unknown
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Expected Obj, but got Unknown
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c6: Expected Obj, but got Unknown
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d2: Expected Obj, but got Unknown
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02de: Expected Obj, but got Unknown
		//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Expected Obj, but got Unknown
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f6: Expected Obj, but got Unknown
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Expected Obj, but got Unknown
		//IL_0304: Unknown result type (might be due to invalid IL or missing references)
		//IL_030e: Expected Obj, but got Unknown
		//IL_0310: Unknown result type (might be due to invalid IL or missing references)
		//IL_031a: Expected Obj, but got Unknown
		//IL_031c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0326: Expected Obj, but got Unknown
		//IL_0328: Unknown result type (might be due to invalid IL or missing references)
		//IL_0332: Expected Obj, but got Unknown
		//IL_0334: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Expected Obj, but got Unknown
		//IL_0340: Unknown result type (might be due to invalid IL or missing references)
		//IL_034a: Expected Obj, but got Unknown
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0356: Expected Obj, but got Unknown
		//IL_0358: Unknown result type (might be due to invalid IL or missing references)
		//IL_0362: Expected Obj, but got Unknown
		//IL_0364: Unknown result type (might be due to invalid IL or missing references)
		//IL_036e: Expected Obj, but got Unknown
		//IL_0370: Unknown result type (might be due to invalid IL or missing references)
		//IL_037a: Expected Obj, but got Unknown
		//IL_037c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Expected Obj, but got Unknown
		//IL_0388: Unknown result type (might be due to invalid IL or missing references)
		//IL_0392: Expected Obj, but got Unknown
		//IL_0394: Unknown result type (might be due to invalid IL or missing references)
		//IL_039e: Expected Obj, but got Unknown
		//IL_03a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03aa: Expected Obj, but got Unknown
		//IL_03ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b6: Expected Obj, but got Unknown
		//IL_03b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c2: Expected Obj, but got Unknown
		//IL_03c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ce: Expected Obj, but got Unknown
		//IL_03d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03da: Expected Obj, but got Unknown
		//IL_03dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e6: Expected Obj, but got Unknown
		//IL_03e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f2: Expected Obj, but got Unknown
		//IL_03f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fe: Expected Obj, but got Unknown
		//IL_0400: Unknown result type (might be due to invalid IL or missing references)
		//IL_040a: Expected Obj, but got Unknown
		//IL_040c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0416: Expected Obj, but got Unknown
		//IL_0418: Unknown result type (might be due to invalid IL or missing references)
		//IL_0422: Expected Obj, but got Unknown
		//IL_0424: Unknown result type (might be due to invalid IL or missing references)
		//IL_042e: Expected Obj, but got Unknown
		//IL_0430: Unknown result type (might be due to invalid IL or missing references)
		//IL_043a: Expected Obj, but got Unknown
		//IL_043c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0446: Expected Obj, but got Unknown
		//IL_0448: Unknown result type (might be due to invalid IL or missing references)
		//IL_0452: Expected Obj, but got Unknown
		//IL_0454: Unknown result type (might be due to invalid IL or missing references)
		//IL_045e: Expected Obj, but got Unknown
		//IL_0460: Unknown result type (might be due to invalid IL or missing references)
		//IL_046a: Expected Obj, but got Unknown
		//IL_046c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0476: Expected Obj, but got Unknown
		//IL_0478: Unknown result type (might be due to invalid IL or missing references)
		//IL_0482: Expected Obj, but got Unknown
		//IL_0484: Unknown result type (might be due to invalid IL or missing references)
		//IL_048e: Expected Obj, but got Unknown
		//IL_0490: Unknown result type (might be due to invalid IL or missing references)
		//IL_049a: Expected Obj, but got Unknown
		//IL_049c: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a6: Expected Obj, but got Unknown
		//IL_04a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b2: Expected Obj, but got Unknown
		//IL_04b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04be: Expected Obj, but got Unknown
		//IL_04c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ca: Expected Obj, but got Unknown
		//IL_04cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d6: Expected Obj, but got Unknown
		//IL_04d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e2: Expected Obj, but got Unknown
		//IL_04e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ee: Expected Obj, but got Unknown
		//IL_04f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fa: Expected Obj, but got Unknown
		//IL_04fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0506: Expected Obj, but got Unknown
		//IL_0508: Unknown result type (might be due to invalid IL or missing references)
		//IL_0512: Expected Obj, but got Unknown
		//IL_0514: Unknown result type (might be due to invalid IL or missing references)
		//IL_051e: Expected Obj, but got Unknown
		//IL_0520: Unknown result type (might be due to invalid IL or missing references)
		//IL_052a: Expected Obj, but got Unknown
		//IL_052c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0536: Expected Obj, but got Unknown
		//IL_0538: Unknown result type (might be due to invalid IL or missing references)
		//IL_0542: Expected Obj, but got Unknown
		//IL_0544: Unknown result type (might be due to invalid IL or missing references)
		//IL_054e: Expected Obj, but got Unknown
		//IL_0550: Unknown result type (might be due to invalid IL or missing references)
		//IL_055a: Expected Obj, but got Unknown
		//IL_055c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0566: Expected Obj, but got Unknown
		//IL_0568: Unknown result type (might be due to invalid IL or missing references)
		//IL_0572: Expected Obj, but got Unknown
		//IL_0574: Unknown result type (might be due to invalid IL or missing references)
		//IL_057e: Expected Obj, but got Unknown
		//IL_0580: Unknown result type (might be due to invalid IL or missing references)
		//IL_058a: Expected Obj, but got Unknown
		//IL_058c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0596: Expected Obj, but got Unknown
		//IL_0598: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a2: Expected Obj, but got Unknown
		//IL_05a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ae: Expected Obj, but got Unknown
		//IL_05b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ba: Expected Obj, but got Unknown
		//IL_05bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c6: Expected Obj, but got Unknown
		//IL_05c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d2: Expected Obj, but got Unknown
		//IL_05d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05de: Expected Obj, but got Unknown
		//IL_05e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ea: Expected Obj, but got Unknown
		//IL_05ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f6: Expected Obj, but got Unknown
		//IL_05f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0602: Expected Obj, but got Unknown
		//IL_0604: Unknown result type (might be due to invalid IL or missing references)
		//IL_060e: Expected Obj, but got Unknown
		//IL_09e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f0: Expected Obj, but got Unknown
		//IL_0a9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa4: Expected Obj, but got Unknown
		//IL_0ace: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad8: Expected Obj, but got Unknown
		//IL_0b1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b20: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bad: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb7: Expected Obj, but got Unknown
		//IL_0be1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0beb: Expected Obj, but got Unknown
		//IL_0c29: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca9: Expected Obj, but got Unknown
		//IL_0d3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d49: Expected Obj, but got Unknown
		//IL_0df5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dff: Expected Obj, but got Unknown
		//IL_0e9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ea7: Expected Obj, but got Unknown
		//IL_0f3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f49: Expected Obj, but got Unknown
		//IL_0fb3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fbd: Expected Obj, but got Unknown
		//IL_1038: Unknown result type (might be due to invalid IL or missing references)
		//IL_1042: Expected Obj, but got Unknown
		//IL_10ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_10f8: Expected Obj, but got Unknown
		//IL_116d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1177: Expected Obj, but got Unknown
		//IL_13e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_13ec: Expected Obj, but got Unknown
		//IL_14ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_14d8: Expected Obj, but got Unknown
		//IL_1573: Unknown result type (might be due to invalid IL or missing references)
		//IL_157d: Expected Obj, but got Unknown
		//IL_163f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1649: Expected Obj, but got Unknown
		//IL_170e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1718: Expected Obj, but got Unknown
		//IL_17da: Unknown result type (might be due to invalid IL or missing references)
		//IL_17e4: Expected Obj, but got Unknown
		//IL_18ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_18b5: Expected Obj, but got Unknown
		//IL_1989: Unknown result type (might be due to invalid IL or missing references)
		//IL_1993: Expected Obj, but got Unknown
		//IL_1a5b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a65: Expected Obj, but got Unknown
		//IL_1a89: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a93: Expected Obj, but got Unknown
		//IL_1ac8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ace: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b86: Expected Obj, but got Unknown
		//IL_1baa: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bb4: Expected Obj, but got Unknown
		//IL_1bec: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bf2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ca7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cb1: Expected Obj, but got Unknown
		//IL_1cd5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cdf: Expected Obj, but got Unknown
		//IL_1e14: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e1e: Expected Obj, but got Unknown
		//IL_201c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2026: Expected Obj, but got Unknown
		//IL_20bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_20c9: Expected Obj, but got Unknown
		//IL_2194: Unknown result type (might be due to invalid IL or missing references)
		//IL_219e: Expected Obj, but got Unknown
		//IL_21e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_21ed: Expected Obj, but got Unknown
		//IL_2232: Unknown result type (might be due to invalid IL or missing references)
		//IL_223c: Expected Obj, but got Unknown
		//IL_2285: Unknown result type (might be due to invalid IL or missing references)
		//IL_228f: Expected Obj, but got Unknown
		//IL_2874: Unknown result type (might be due to invalid IL or missing references)
		//IL_287e: Expected Obj, but got Unknown
		//IL_2890: Unknown result type (might be due to invalid IL or missing references)
		//IL_289a: Expected Obj, but got Unknown
		//IL_28ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_28b6: Expected Obj, but got Unknown
		//IL_28c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_28d2: Expected Obj, but got Unknown
		//IL_2959: Unknown result type (might be due to invalid IL or missing references)
		//IL_295f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2996: Unknown result type (might be due to invalid IL or missing references)
		//IL_29a0: Expected Obj, but got Unknown
		//IL_2a5b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a65: Expected Obj, but got Unknown
		//IL_2a99: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bab: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bb5: Expected Obj, but got Unknown
		//IL_2be8: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bee: Unknown result type (might be due to invalid IL or missing references)
		//IL_2cfa: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d04: Expected Obj, but got Unknown
		//IL_2d38: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e54: Expected Obj, but got Unknown
		//IL_2e88: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e8e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fa0: Unknown result type (might be due to invalid IL or missing references)
		//IL_2faa: Expected Obj, but got Unknown
		//IL_2fbc: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fc6: Expected Obj, but got Unknown
		//IL_2fd8: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fe2: Expected Obj, but got Unknown
		//IL_2ff4: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ffe: Expected Obj, but got Unknown
		//IL_3010: Unknown result type (might be due to invalid IL or missing references)
		//IL_301a: Expected Obj, but got Unknown
		//IL_302c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3036: Expected Obj, but got Unknown
		//IL_3048: Unknown result type (might be due to invalid IL or missing references)
		//IL_3052: Expected Obj, but got Unknown
		//IL_3064: Unknown result type (might be due to invalid IL or missing references)
		//IL_306e: Expected Obj, but got Unknown
		//IL_3080: Unknown result type (might be due to invalid IL or missing references)
		//IL_308a: Expected Obj, but got Unknown
		//IL_309c: Unknown result type (might be due to invalid IL or missing references)
		//IL_30a6: Expected Obj, but got Unknown
		//IL_30b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_30c2: Expected Obj, but got Unknown
		//IL_30d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_30de: Expected Obj, but got Unknown
		//IL_30f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_30fa: Expected Obj, but got Unknown
		//IL_327f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3289: Expected Obj, but got Unknown
		//IL_3349: Unknown result type (might be due to invalid IL or missing references)
		//IL_3353: Expected Obj, but got Unknown
		//IL_3487: Unknown result type (might be due to invalid IL or missing references)
		//IL_3491: Expected Obj, but got Unknown
		//IL_35c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_35d0: Expected Obj, but got Unknown
		//IL_3708: Unknown result type (might be due to invalid IL or missing references)
		//IL_3712: Expected Obj, but got Unknown
		//IL_384a: Unknown result type (might be due to invalid IL or missing references)
		//IL_3854: Expected Obj, but got Unknown
		//IL_398c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3996: Expected Obj, but got Unknown
		//IL_3ace: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ad8: Expected Obj, but got Unknown
		//IL_3c10: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c1a: Expected Obj, but got Unknown
		//IL_3d52: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d5c: Expected Obj, but got Unknown
		//IL_3e94: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e9e: Expected Obj, but got Unknown
		//IL_3fd6: Unknown result type (might be due to invalid IL or missing references)
		//IL_3fe0: Expected Obj, but got Unknown
		//IL_4118: Unknown result type (might be due to invalid IL or missing references)
		//IL_4122: Expected Obj, but got Unknown
		//IL_4201: Unknown result type (might be due to invalid IL or missing references)
		//IL_420b: Expected Obj, but got Unknown
		//IL_42d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_42e3: Expected Obj, but got Unknown
		//IL_43b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_43bb: Expected Obj, but got Unknown
		//IL_448c: Unknown result type (might be due to invalid IL or missing references)
		//IL_4496: Expected Obj, but got Unknown
		//IL_4563: Unknown result type (might be due to invalid IL or missing references)
		//IL_456d: Expected Obj, but got Unknown
		//IL_4637: Unknown result type (might be due to invalid IL or missing references)
		//IL_4641: Expected Obj, but got Unknown
		//IL_46f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_46fb: Expected Obj, but got Unknown
		//IL_47d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_47e1: Expected Obj, but got Unknown
		//IL_4b81: Unknown result type (might be due to invalid IL or missing references)
		//IL_4b8b: Expected Obj, but got Unknown
		//IL_4c22: Unknown result type (might be due to invalid IL or missing references)
		//IL_4c2c: Expected Obj, but got Unknown
		//IL_4cd9: Unknown result type (might be due to invalid IL or missing references)
		//IL_4ce3: Expected Obj, but got Unknown
		//IL_4da8: Unknown result type (might be due to invalid IL or missing references)
		//IL_4db2: Expected Obj, but got Unknown
		//IL_4dd6: Unknown result type (might be due to invalid IL or missing references)
		//IL_4de0: Expected Obj, but got Unknown
		//IL_4e13: Unknown result type (might be due to invalid IL or missing references)
		//IL_4e19: Unknown result type (might be due to invalid IL or missing references)
		//IL_5117: Unknown result type (might be due to invalid IL or missing references)
		//IL_5121: Expected Obj, but got Unknown
		//IL_51bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_51c6: Expected Obj, but got Unknown
		//IL_525e: Unknown result type (might be due to invalid IL or missing references)
		//IL_5268: Expected Obj, but got Unknown
		//IL_530d: Unknown result type (might be due to invalid IL or missing references)
		//IL_5317: Expected Obj, but got Unknown
		//IL_539d: Unknown result type (might be due to invalid IL or missing references)
		//IL_53a7: Expected Obj, but got Unknown
		//IL_542d: Unknown result type (might be due to invalid IL or missing references)
		//IL_5437: Expected Obj, but got Unknown
		//IL_54cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_54d9: Expected Obj, but got Unknown
		//IL_5590: Unknown result type (might be due to invalid IL or missing references)
		//IL_559a: Expected Obj, but got Unknown
		//IL_5675: Unknown result type (might be due to invalid IL or missing references)
		//IL_567f: Expected Obj, but got Unknown
		//IL_5752: Unknown result type (might be due to invalid IL or missing references)
		//IL_575c: Expected Obj, but got Unknown
		//IL_5821: Unknown result type (might be due to invalid IL or missing references)
		//IL_582b: Expected Obj, but got Unknown
		//IL_58f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_58fa: Expected Obj, but got Unknown
		//IL_5994: Unknown result type (might be due to invalid IL or missing references)
		//IL_599e: Expected Obj, but got Unknown
		//IL_5a52: Unknown result type (might be due to invalid IL or missing references)
		//IL_5a5c: Expected Obj, but got Unknown
		//IL_5b10: Unknown result type (might be due to invalid IL or missing references)
		//IL_5b1a: Expected Obj, but got Unknown
		//IL_5d0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_5d17: Expected Obj, but got Unknown
		//IL_5dd2: Unknown result type (might be due to invalid IL or missing references)
		//IL_5ddc: Expected Obj, but got Unknown
		//IL_5ea8: Unknown result type (might be due to invalid IL or missing references)
		//IL_5eb2: Expected Obj, but got Unknown
		//IL_5f68: Unknown result type (might be due to invalid IL or missing references)
		//IL_5f72: Expected Obj, but got Unknown
		//IL_602b: Unknown result type (might be due to invalid IL or missing references)
		//IL_6035: Expected Obj, but got Unknown
		//IL_60dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_60e7: Expected Obj, but got Unknown
		//IL_6196: Unknown result type (might be due to invalid IL or missing references)
		//IL_61a0: Expected Obj, but got Unknown
		//IL_63bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_63c9: Expected Obj, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form_5_CLIENTS_RDV));
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		DataGridViewCellStyle val3 = new DataGridViewCellStyle();
		DataGridViewCellStyle val4 = new DataGridViewCellStyle();
		DataGridViewCellStyle val5 = new DataGridViewCellStyle();
		DataGridViewCellStyle val6 = new DataGridViewCellStyle();
		DataGridViewCellStyle val7 = new DataGridViewCellStyle();
		Panel_INFO = new Panel();
		Panel1 = new Panel();
		ListBox_VENDEURS = new ListBox();
		Button20 = new Button();
		Button5 = new Button();
		Button2 = new Button();
		Label2 = new Label();
		Label4 = new Label();
		Text_NOTE = new TextBox();
		Text_CLIENT = new TextBox();
		Text_TELEPHONE = new TextBox();
		Label8 = new Label();
		DateTimePicker_DATE = new DateTimePicker();
		ListBox_HEURE = new ListBox();
		Label_INDEX = new Label();
		Label_INDEX_COLUMN = new Label();
		Button34 = new Button();
		Label_BOTTOM = new Label();
		Label_LEFT = new Label();
		Label_RIGHT = new Label();
		Label_INDEX_ROW = new Label();
		Label_TOP = new Label();
		Button_CLOSE = new Button();
		Button_SAVE = new Button();
		Button_ADD = new Button();
		DataGridView1 = new DataGridView();
		Column0 = new DataGridViewTextBoxColumn();
		Column1 = new DataGridViewTextBoxColumn();
		Column2 = new DataGridViewTextBoxColumn();
		Column3 = new DataGridViewTextBoxColumn();
		Column4 = new DataGridViewTextBoxColumn();
		Column5 = new DataGridViewTextBoxColumn();
		Column6 = new DataGridViewTextBoxColumn();
		Column7 = new DataGridViewTextBoxColumn();
		Column8 = new DataGridViewTextBoxColumn();
		Column9 = new DataGridViewTextBoxColumn();
		Column10 = new DataGridViewTextBoxColumn();
		Column11 = new DataGridViewTextBoxColumn();
		Column12 = new DataGridViewTextBoxColumn();
		Column13 = new DataGridViewTextBoxColumn();
		Column14 = new DataGridViewTextBoxColumn();
		Column15 = new DataGridViewTextBoxColumn();
		Column16 = new DataGridViewTextBoxColumn();
		Column17 = new DataGridViewTextBoxColumn();
		Column18 = new DataGridViewTextBoxColumn();
		Column19 = new DataGridViewTextBoxColumn();
		Column20 = new DataGridViewTextBoxColumn();
		Column21 = new DataGridViewTextBoxColumn();
		Column22 = new DataGridViewTextBoxColumn();
		Column23 = new DataGridViewTextBoxColumn();
		Column24 = new DataGridViewTextBoxColumn();
		Column25 = new DataGridViewTextBoxColumn();
		Column26 = new DataGridViewTextBoxColumn();
		Column27 = new DataGridViewTextBoxColumn();
		Column28 = new DataGridViewTextBoxColumn();
		Column29 = new DataGridViewTextBoxColumn();
		Column30 = new DataGridViewTextBoxColumn();
		Column31 = new DataGridViewTextBoxColumn();
		Panel_MOIS = new Panel();
		Text_INTERVALE = new TextBox();
		TableLayoutPanel2 = new TableLayoutPanel();
		RadioButton4 = new RadioButton();
		RadioButton1 = new RadioButton();
		RadioButton3 = new RadioButton();
		RadioButton2 = new RadioButton();
		Text_HEURE_DEPART = new TextBox();
		TableLayoutPanel1 = new TableLayoutPanel();
		Radio_MOIS_1 = new RadioButton();
		Radio_MOIS_2 = new RadioButton();
		Radio_MOIS_3 = new RadioButton();
		Radio_MOIS_4 = new RadioButton();
		Radio_MOIS_5 = new RadioButton();
		Radio_MOIS_6 = new RadioButton();
		Radio_MOIS_7 = new RadioButton();
		Radio_MOIS_12 = new RadioButton();
		Radio_MOIS_8 = new RadioButton();
		Radio_MOIS_11 = new RadioButton();
		Radio_MOIS_9 = new RadioButton();
		Radio_MOIS_10 = new RadioButton();
		Label11 = new Label();
		Label10 = new Label();
		TextBox_ANNEE = new TextBox();
		Label1 = new Label();
		Label5 = new Label();
		Label7 = new Label();
		Label_MOIS = new Label();
		Label9 = new Label();
		DataGridView2 = new DataGridView();
		Panel_DETAILS = new Panel();
		Button3 = new Button();
		Button1 = new Button();
		Label33 = new Label();
		Button244 = new Button();
		DataGridView3 = new DataGridView();
		ID = new DataGridViewTextBoxColumn();
		CLIENT = new DataGridViewTextBoxColumn();
		DATES = new DataGridViewTextBoxColumn();
		HEURE = new DataGridViewTextBoxColumn();
		TELEPHONE = new DataGridViewTextBoxColumn();
		NOTES = new DataGridViewTextBoxColumn();
		Button_EDIT = new Button();
		PictureBox4 = new PictureBox();
		Label24 = new Label();
		PictureBox3 = new PictureBox();
		PictureBox2 = new PictureBox();
		PictureBox1 = new PictureBox();
		Label19 = new Label();
		Label17 = new Label();
		Label15 = new Label();
		Label14 = new Label();
		Label12 = new Label();
		Label13 = new Label();
		Label18 = new Label();
		Label20 = new Label();
		Label16 = new Label();
		Panel5 = new Panel();
		Label_CEMOIS = new Label();
		Label_DEMAIN = new Label();
		Label_AUJOURDHUI = new Label();
		Label23 = new Label();
		Label22 = new Label();
		PictureBox5 = new PictureBox();
		Label21 = new Label();
		Button_CALC = new Button();
		((Control)Panel_INFO).SuspendLayout();
		((Control)Panel1).SuspendLayout();
		((ISupportInitialize)DataGridView1).BeginInit();
		((Control)Panel_MOIS).SuspendLayout();
		((Control)TableLayoutPanel2).SuspendLayout();
		((Control)TableLayoutPanel1).SuspendLayout();
		((ISupportInitialize)DataGridView2).BeginInit();
		((Control)Panel_DETAILS).SuspendLayout();
		((ISupportInitialize)DataGridView3).BeginInit();
		((ISupportInitialize)PictureBox4).BeginInit();
		((ISupportInitialize)PictureBox3).BeginInit();
		((ISupportInitialize)PictureBox2).BeginInit();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)Panel5).SuspendLayout();
		((ISupportInitialize)PictureBox5).BeginInit();
		((Control)this).SuspendLayout();
		((Control)Panel_INFO).BackColor = Color.White;
		Panel_INFO.BorderStyle = (BorderStyle)1;
		((Control)Panel_INFO).Controls.Add((Control)(object)Panel1);
		((Control)Panel_INFO).Controls.Add((Control)(object)Label_INDEX);
		((Control)Panel_INFO).Controls.Add((Control)(object)Label_INDEX_COLUMN);
		((Control)Panel_INFO).Controls.Add((Control)(object)Button34);
		((Control)Panel_INFO).Controls.Add((Control)(object)Label_BOTTOM);
		((Control)Panel_INFO).Controls.Add((Control)(object)Label_LEFT);
		((Control)Panel_INFO).Controls.Add((Control)(object)Label_RIGHT);
		((Control)Panel_INFO).Controls.Add((Control)(object)Label_INDEX_ROW);
		((Control)Panel_INFO).Controls.Add((Control)(object)Label_TOP);
		((Control)Panel_INFO).Controls.Add((Control)(object)Button_CLOSE);
		((Control)Panel_INFO).Controls.Add((Control)(object)Button_SAVE);
		Panel panel_INFO = Panel_INFO;
		Point location = new Point(196, 200);
		((Control)panel_INFO).Location = location;
		((Control)Panel_INFO).Name = "Panel_INFO";
		Panel panel_INFO2 = Panel_INFO;
		Size size = new Size(633, 378);
		((Control)panel_INFO2).Size = size;
		((Control)Panel_INFO).TabIndex = 808;
		((Control)Panel_INFO).Visible = false;
		((Control)Panel1).BackColor = Color.White;
		((Control)Panel1).Controls.Add((Control)(object)ListBox_VENDEURS);
		((Control)Panel1).Controls.Add((Control)(object)Button20);
		((Control)Panel1).Controls.Add((Control)(object)Button5);
		((Control)Panel1).Controls.Add((Control)(object)Button2);
		((Control)Panel1).Controls.Add((Control)(object)Label2);
		((Control)Panel1).Controls.Add((Control)(object)Label4);
		((Control)Panel1).Controls.Add((Control)(object)Text_NOTE);
		((Control)Panel1).Controls.Add((Control)(object)Text_CLIENT);
		((Control)Panel1).Controls.Add((Control)(object)Text_TELEPHONE);
		((Control)Panel1).Controls.Add((Control)(object)Label8);
		((Control)Panel1).Controls.Add((Control)(object)DateTimePicker_DATE);
		((Control)Panel1).Controls.Add((Control)(object)ListBox_HEURE);
		Panel panel = Panel1;
		location = new Point(9, 30);
		((Control)panel).Location = location;
		((Control)Panel1).Name = "Panel1";
		Panel panel2 = Panel1;
		size = new Size(612, 298);
		((Control)panel2).Size = size;
		((Control)Panel1).TabIndex = 869;
		ListBox_VENDEURS.Font = new Font("Segoe UI", 12f, (FontStyle)1);
		((ListControl)ListBox_VENDEURS).FormattingEnabled = true;
		ListBox_VENDEURS.ItemHeight = 19;
		ListBox listBox_VENDEURS = ListBox_VENDEURS;
		location = new Point(326, 76);
		((Control)listBox_VENDEURS).Location = location;
		((Control)ListBox_VENDEURS).Name = "ListBox_VENDEURS";
		ListBox listBox_VENDEURS2 = ListBox_VENDEURS;
		size = new Size(283, 137);
		((Control)listBox_VENDEURS2).Size = size;
		((Control)ListBox_VENDEURS).TabIndex = 994;
		((Control)Button20).Cursor = Cursors.Hand;
		((ButtonBase)Button20).FlatStyle = (FlatStyle)0;
		((Control)Button20).Font = new Font("Tahoma", 10f, (FontStyle)1);
		((Control)Button20).ForeColor = Color.FromArgb(64, 64, 64);
		((ButtonBase)Button20).Image = (Image)componentResourceManager.GetObject("Button20.Image");
		((ButtonBase)Button20).ImageAlign = (ContentAlignment)64;
		((ButtonBase)Button20).ImeMode = (ImeMode)0;
		Button button = Button20;
		location = new Point(152, 12);
		((Control)button).Location = location;
		Button button2 = Button20;
		Padding margin = new Padding(0);
		((Control)button2).Margin = margin;
		((Control)Button20).Name = "Button20";
		Button button3 = Button20;
		size = new Size(37, 26);
		((Control)button3).Size = size;
		((Control)Button20).TabIndex = 993;
		((ButtonBase)Button20).TextImageRelation = (TextImageRelation)8;
		((ButtonBase)Button20).UseVisualStyleBackColor = true;
		((Control)Button5).Cursor = Cursors.Hand;
		((ButtonBase)Button5).FlatStyle = (FlatStyle)0;
		((Control)Button5).Font = new Font("Tahoma", 10f, (FontStyle)1);
		((Control)Button5).ForeColor = Color.FromArgb(64, 64, 64);
		((ButtonBase)Button5).Image = (Image)componentResourceManager.GetObject("Button5.Image");
		((ButtonBase)Button5).ImageAlign = (ContentAlignment)16;
		((ButtonBase)Button5).ImeMode = (ImeMode)0;
		Button button4 = Button5;
		location = new Point(3, 12);
		((Control)button4).Location = location;
		Button button5 = Button5;
		margin = new Padding(0);
		((Control)button5).Margin = margin;
		((Control)Button5).Name = "Button5";
		Button button6 = Button5;
		size = new Size(37, 26);
		((Control)button6).Size = size;
		((Control)Button5).TabIndex = 992;
		((ButtonBase)Button5).TextImageRelation = (TextImageRelation)4;
		((ButtonBase)Button5).UseVisualStyleBackColor = true;
		((ButtonBase)Button2).Image = (Image)componentResourceManager.GetObject("Button2.Image");
		((ButtonBase)Button2).ImageAlign = (ContentAlignment)16;
		Button button7 = Button2;
		location = new Point(568, 7);
		((Control)button7).Location = location;
		((Control)Button2).Name = "Button2";
		Button button8 = Button2;
		size = new Size(41, 36);
		((Control)button8).Size = size;
		((Control)Button2).TabIndex = 990;
		((ButtonBase)Button2).UseVisualStyleBackColor = true;
		((Control)Label2).BackColor = SystemColors.Control;
		((Control)Label2).Font = new Font("Segoe UI", 10f, (FontStyle)1);
		((Control)Label2).ForeColor = Color.Black;
		Label label = Label2;
		location = new Point(212, 44);
		((Control)label).Location = location;
		((Control)Label2).Name = "Label2";
		Label label2 = Label2;
		size = new Size(108, 26);
		((Control)label2).Size = size;
		((Control)Label2).TabIndex = 403;
		Label2.Text = "Téléphone";
		Label2.TextAlign = (ContentAlignment)16;
		((Control)Label4).BackColor = SystemColors.Control;
		((Control)Label4).Font = new Font("Segoe UI", 10f, (FontStyle)1);
		((Control)Label4).ForeColor = Color.Black;
		Label label3 = Label4;
		location = new Point(212, 221);
		((Control)label3).Location = location;
		((Control)Label4).Name = "Label4";
		Label label4 = Label4;
		size = new Size(108, 26);
		((Control)label4).Size = size;
		((Control)Label4).TabIndex = 404;
		Label4.Text = "Notes";
		Label4.TextAlign = (ContentAlignment)16;
		((Control)Text_NOTE).Font = new Font("Segoe UI", 12f, (FontStyle)1);
		TextBox text_NOTE = Text_NOTE;
		location = new Point(326, 221);
		((Control)text_NOTE).Location = location;
		Text_NOTE.Multiline = true;
		((Control)Text_NOTE).Name = "Text_NOTE";
		Text_NOTE.ScrollBars = (ScrollBars)2;
		TextBox text_NOTE2 = Text_NOTE;
		size = new Size(283, 74);
		((Control)text_NOTE2).Size = size;
		((Control)Text_NOTE).TabIndex = 7;
		((TextBoxBase)Text_CLIENT).BackColor = Color.White;
		((Control)Text_CLIENT).Font = new Font("Segoe UI", 12f, (FontStyle)1);
		TextBox text_CLIENT = Text_CLIENT;
		location = new Point(326, 12);
		((Control)text_CLIENT).Location = location;
		((Control)Text_CLIENT).Name = "Text_CLIENT";
		TextBox text_CLIENT2 = Text_CLIENT;
		size = new Size(239, 26);
		((Control)text_CLIENT2).Size = size;
		((Control)Text_CLIENT).TabIndex = 2;
		((Control)Text_TELEPHONE).Font = new Font("Segoe UI", 12f, (FontStyle)1);
		TextBox text_TELEPHONE = Text_TELEPHONE;
		location = new Point(326, 44);
		((Control)text_TELEPHONE).Location = location;
		((Control)Text_TELEPHONE).Name = "Text_TELEPHONE";
		TextBox text_TELEPHONE2 = Text_TELEPHONE;
		size = new Size(283, 26);
		((Control)text_TELEPHONE2).Size = size;
		((Control)Text_TELEPHONE).TabIndex = 4;
		((Control)Label8).BackColor = SystemColors.Control;
		((Control)Label8).Font = new Font("Segoe UI", 10f, (FontStyle)1);
		((Control)Label8).ForeColor = Color.Black;
		Label label5 = Label8;
		location = new Point(212, 12);
		((Control)label5).Location = location;
		((Control)Label8).Name = "Label8";
		Label label6 = Label8;
		size = new Size(108, 26);
		((Control)label6).Size = size;
		((Control)Label8).TabIndex = 399;
		Label8.Text = "Client";
		Label8.TextAlign = (ContentAlignment)16;
		DateTimePicker_DATE.CustomFormat = "yyyy-MM-dd";
		((Control)DateTimePicker_DATE).Font = new Font("Segoe UI", 12f, (FontStyle)1);
		DateTimePicker_DATE.Format = (DateTimePickerFormat)2;
		DateTimePicker dateTimePicker_DATE = DateTimePicker_DATE;
		location = new Point(43, 12);
		((Control)dateTimePicker_DATE).Location = location;
		((Control)DateTimePicker_DATE).Name = "DateTimePicker_DATE";
		DateTimePicker dateTimePicker_DATE2 = DateTimePicker_DATE;
		size = new Size(106, 26);
		((Control)dateTimePicker_DATE2).Size = size;
		((Control)DateTimePicker_DATE).TabIndex = 970;
		ListBox_HEURE.Font = new Font("Segoe UI", 12f, (FontStyle)1);
		((ListControl)ListBox_HEURE).FormattingEnabled = true;
		ListBox_HEURE.ItemHeight = 19;
		ListBox_HEURE.Items.AddRange(new object[37]
		{
			"06:00", "06:30", "07:00", "07:30", "08:00", "08:30", "09:00", "09:30", "10:00", "10:30",
			"11:00", "11:30", "12:00", "12:30", "13:00", "13:30", "14:00", "14:30", "15:00", "15:30",
			"16:00", "16:30", "17:00", "17:30", "18:00", "18:30", "19:00", "19:30", "20:00", "20:30",
			"21:00", "21:30", "22:00", "22:30", "23:00", "23:30", "00:00"
		});
		ListBox listBox_HEURE = ListBox_HEURE;
		location = new Point(3, 44);
		((Control)listBox_HEURE).Location = location;
		((Control)ListBox_HEURE).Name = "ListBox_HEURE";
		ListBox listBox_HEURE2 = ListBox_HEURE;
		size = new Size(186, 251);
		((Control)listBox_HEURE2).Size = size;
		((Control)ListBox_HEURE).TabIndex = 991;
		((Control)Label_INDEX).Anchor = (AnchorStyles)9;
		((Control)Label_INDEX).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label_INDEX).Cursor = Cursors.Hand;
		((Control)Label_INDEX).Font = new Font("Tahoma", 7f, (FontStyle)1);
		((Control)Label_INDEX).ForeColor = Color.White;
		Label_INDEX.ImeMode = (ImeMode)0;
		Label label_INDEX = Label_INDEX;
		location = new Point(580, 0);
		((Control)label_INDEX).Location = location;
		((Control)Label_INDEX).Name = "Label_INDEX";
		Label label_INDEX2 = Label_INDEX;
		size = new Size(51, 24);
		((Control)label_INDEX2).Size = size;
		((Control)Label_INDEX).TabIndex = 871;
		Label_INDEX.Text = "-";
		Label_INDEX.TextAlign = (ContentAlignment)64;
		((Control)Label_INDEX_COLUMN).Anchor = (AnchorStyles)9;
		((Control)Label_INDEX_COLUMN).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label_INDEX_COLUMN).Cursor = Cursors.Hand;
		((Control)Label_INDEX_COLUMN).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label_INDEX_COLUMN).ForeColor = Color.White;
		Label label_INDEX_COLUMN = Label_INDEX_COLUMN;
		location = new Point(526, 0);
		((Control)label_INDEX_COLUMN).Location = location;
		((Control)Label_INDEX_COLUMN).Name = "Label_INDEX_COLUMN";
		Label label_INDEX_COLUMN2 = Label_INDEX_COLUMN;
		size = new Size(36, 24);
		((Control)label_INDEX_COLUMN2).Size = size;
		((Control)Label_INDEX_COLUMN).TabIndex = 868;
		Label_INDEX_COLUMN.Text = "-";
		Label_INDEX_COLUMN.TextAlign = (ContentAlignment)64;
		((Control)Button34).BackgroundImage = (Image)componentResourceManager.GetObject("Button34.BackgroundImage");
		((Control)Button34).BackgroundImageLayout = (ImageLayout)4;
		Button button9 = Button34;
		location = new Point(297, 334);
		((Control)button9).Location = location;
		((Control)Button34).Name = "Button34";
		Button button10 = Button34;
		size = new Size(36, 31);
		((Control)button10).Size = size;
		((Control)Button34).TabIndex = 867;
		((ButtonBase)Button34).UseVisualStyleBackColor = true;
		((Control)Label_BOTTOM).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label_BOTTOM).Cursor = Cursors.Hand;
		((Control)Label_BOTTOM).Dock = (DockStyle)2;
		((Control)Label_BOTTOM).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label_BOTTOM).ForeColor = Color.White;
		Label label_BOTTOM = Label_BOTTOM;
		location = new Point(4, 372);
		((Control)label_BOTTOM).Location = location;
		((Control)Label_BOTTOM).Name = "Label_BOTTOM";
		Label label_BOTTOM2 = Label_BOTTOM;
		size = new Size(623, 4);
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
		size = new Size(4, 352);
		((Control)label_LEFT2).Size = size;
		((Control)Label_LEFT).TabIndex = 865;
		Label_LEFT.TextAlign = (ContentAlignment)16;
		((Control)Label_RIGHT).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label_RIGHT).Cursor = Cursors.Hand;
		((Control)Label_RIGHT).Dock = (DockStyle)4;
		((Control)Label_RIGHT).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label_RIGHT).ForeColor = Color.White;
		Label label_RIGHT = Label_RIGHT;
		location = new Point(627, 24);
		((Control)label_RIGHT).Location = location;
		((Control)Label_RIGHT).Name = "Label_RIGHT";
		Label label_RIGHT2 = Label_RIGHT;
		size = new Size(4, 352);
		((Control)label_RIGHT2).Size = size;
		((Control)Label_RIGHT).TabIndex = 864;
		Label_RIGHT.TextAlign = (ContentAlignment)16;
		((Control)Label_INDEX_ROW).Anchor = (AnchorStyles)9;
		((Control)Label_INDEX_ROW).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label_INDEX_ROW).Cursor = Cursors.Hand;
		((Control)Label_INDEX_ROW).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label_INDEX_ROW).ForeColor = Color.White;
		Label label_INDEX_ROW = Label_INDEX_ROW;
		location = new Point(487, 0);
		((Control)label_INDEX_ROW).Location = location;
		((Control)Label_INDEX_ROW).Name = "Label_INDEX_ROW";
		Label label_INDEX_ROW2 = Label_INDEX_ROW;
		size = new Size(36, 24);
		((Control)label_INDEX_ROW2).Size = size;
		((Control)Label_INDEX_ROW).TabIndex = 863;
		Label_INDEX_ROW.Text = "-";
		Label_INDEX_ROW.TextAlign = (ContentAlignment)64;
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
		size = new Size(631, 24);
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
		location = new Point(9, 333);
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
		location = new Point(465, 334);
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
		((Control)Button_ADD).Anchor = (AnchorStyles)6;
		((ButtonBase)Button_ADD).BackColor = Color.FromArgb(0, 192, 0);
		((Control)Button_ADD).Cursor = Cursors.Hand;
		((ButtonBase)Button_ADD).FlatStyle = (FlatStyle)0;
		((Control)Button_ADD).Font = new Font("Tahoma", 11.25f, (FontStyle)1);
		((Control)Button_ADD).ForeColor = Color.White;
		((ButtonBase)Button_ADD).Image = (Image)componentResourceManager.GetObject("Button_ADD.Image");
		((ButtonBase)Button_ADD).ImageAlign = (ContentAlignment)16;
		Button button_ADD = Button_ADD;
		location = new Point(6, 646);
		((Control)button_ADD).Location = location;
		((Control)Button_ADD).Name = "Button_ADD";
		Button button_ADD2 = Button_ADD;
		size = new Size(191, 40);
		((Control)button_ADD2).Size = size;
		((Control)Button_ADD).TabIndex = 806;
		((ButtonBase)Button_ADD).Text = "   Nouveau";
		((ButtonBase)Button_ADD).UseVisualStyleBackColor = false;
		DataGridView1.AllowUserToAddRows = false;
		DataGridView1.AllowUserToDeleteRows = false;
		DataGridView1.AllowUserToResizeColumns = false;
		DataGridView1.AllowUserToResizeRows = false;
		((Control)DataGridView1).Anchor = (AnchorStyles)15;
		DataGridView1.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)16;
		DataGridView1.BackgroundColor = Color.White;
		DataGridView1.BorderStyle = (BorderStyle)2;
		DataGridView1.CellBorderStyle = (DataGridViewCellBorderStyle)8;
		val.Alignment = (DataGridViewContentAlignment)32;
		val.BackColor = Color.FromArgb(247, 248, 250);
		val.Font = new Font("Calibri", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		val.ForeColor = SystemColors.WindowText;
		val.SelectionBackColor = SystemColors.Highlight;
		val.SelectionForeColor = SystemColors.HighlightText;
		val.WrapMode = (DataGridViewTriState)1;
		DataGridView1.ColumnHeadersDefaultCellStyle = val;
		DataGridView1.ColumnHeadersHeight = 44;
		DataGridView1.Columns.AddRange(new DataGridViewColumn[32]
		{
			(DataGridViewColumn)Column0,
			(DataGridViewColumn)Column1,
			(DataGridViewColumn)Column2,
			(DataGridViewColumn)Column3,
			(DataGridViewColumn)Column4,
			(DataGridViewColumn)Column5,
			(DataGridViewColumn)Column6,
			(DataGridViewColumn)Column7,
			(DataGridViewColumn)Column8,
			(DataGridViewColumn)Column9,
			(DataGridViewColumn)Column10,
			(DataGridViewColumn)Column11,
			(DataGridViewColumn)Column12,
			(DataGridViewColumn)Column13,
			(DataGridViewColumn)Column14,
			(DataGridViewColumn)Column15,
			(DataGridViewColumn)Column16,
			(DataGridViewColumn)Column17,
			(DataGridViewColumn)Column18,
			(DataGridViewColumn)Column19,
			(DataGridViewColumn)Column20,
			(DataGridViewColumn)Column21,
			(DataGridViewColumn)Column22,
			(DataGridViewColumn)Column23,
			(DataGridViewColumn)Column24,
			(DataGridViewColumn)Column25,
			(DataGridViewColumn)Column26,
			(DataGridViewColumn)Column27,
			(DataGridViewColumn)Column28,
			(DataGridViewColumn)Column29,
			(DataGridViewColumn)Column30,
			(DataGridViewColumn)Column31
		});
		val2.Alignment = (DataGridViewContentAlignment)16;
		val2.BackColor = SystemColors.Window;
		val2.Font = new Font("Tahoma", 8f);
		val2.ForeColor = SystemColors.ControlText;
		val2.SelectionBackColor = SystemColors.Highlight;
		val2.SelectionForeColor = SystemColors.HighlightText;
		val2.WrapMode = (DataGridViewTriState)2;
		DataGridView1.DefaultCellStyle = val2;
		DataGridView1.EditMode = (DataGridViewEditMode)4;
		DataGridView1.EnableHeadersVisualStyles = false;
		DataGridView dataGridView = DataGridView1;
		location = new Point(2, 109);
		((Control)dataGridView).Location = location;
		((Control)DataGridView1).Name = "DataGridView1";
		val3.Alignment = (DataGridViewContentAlignment)16;
		val3.Font = new Font("Tahoma", 8f);
		val3.ForeColor = SystemColors.WindowText;
		val3.SelectionBackColor = SystemColors.Highlight;
		val3.SelectionForeColor = SystemColors.HighlightText;
		val3.WrapMode = (DataGridViewTriState)1;
		DataGridView1.RowHeadersDefaultCellStyle = val3;
		DataGridView1.RowHeadersVisible = false;
		DataGridView dataGridView2 = DataGridView1;
		size = new Size(1021, 531);
		((Control)dataGridView2).Size = size;
		((Control)DataGridView1).TabIndex = 3;
		((DataGridViewColumn)Column0).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)Column0).HeaderText = "HEURE";
		((DataGridViewColumn)Column0).Name = "Column0";
		((DataGridViewColumn)Column0).Width = 50;
		val4.Alignment = (DataGridViewContentAlignment)32;
		val4.Font = new Font("Tahoma", 9.75f, (FontStyle)1);
		((DataGridViewColumn)Column1).DefaultCellStyle = val4;
		((DataGridViewColumn)Column1).HeaderText = "01";
		((DataGridViewColumn)Column1).Name = "Column1";
		val5.Alignment = (DataGridViewContentAlignment)32;
		val5.Font = new Font("Tahoma", 9.75f, (FontStyle)1);
		((DataGridViewColumn)Column2).DefaultCellStyle = val5;
		((DataGridViewColumn)Column2).HeaderText = "02";
		((DataGridViewColumn)Column2).Name = "Column2";
		val6.Alignment = (DataGridViewContentAlignment)32;
		val6.Font = new Font("Tahoma", 9.75f, (FontStyle)1);
		((DataGridViewColumn)Column3).DefaultCellStyle = val6;
		((DataGridViewColumn)Column3).HeaderText = "03";
		((DataGridViewColumn)Column3).Name = "Column3";
		val7.Alignment = (DataGridViewContentAlignment)32;
		val7.Font = new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((DataGridViewColumn)Column4).DefaultCellStyle = val7;
		((DataGridViewColumn)Column4).HeaderText = "04";
		((DataGridViewColumn)Column4).Name = "Column4";
		((DataGridViewColumn)Column5).HeaderText = "05";
		((DataGridViewColumn)Column5).Name = "Column5";
		((DataGridViewColumn)Column6).HeaderText = "06";
		((DataGridViewColumn)Column6).Name = "Column6";
		((DataGridViewColumn)Column7).HeaderText = "07";
		((DataGridViewColumn)Column7).Name = "Column7";
		((DataGridViewColumn)Column8).HeaderText = "08";
		((DataGridViewColumn)Column8).Name = "Column8";
		((DataGridViewColumn)Column9).HeaderText = "09";
		((DataGridViewColumn)Column9).Name = "Column9";
		((DataGridViewColumn)Column10).HeaderText = "10";
		((DataGridViewColumn)Column10).Name = "Column10";
		((DataGridViewColumn)Column11).HeaderText = "11";
		((DataGridViewColumn)Column11).Name = "Column11";
		((DataGridViewColumn)Column12).HeaderText = "12";
		((DataGridViewColumn)Column12).Name = "Column12";
		((DataGridViewColumn)Column13).HeaderText = "13";
		((DataGridViewColumn)Column13).Name = "Column13";
		((DataGridViewColumn)Column14).HeaderText = "14";
		((DataGridViewColumn)Column14).Name = "Column14";
		((DataGridViewColumn)Column15).HeaderText = "15";
		((DataGridViewColumn)Column15).Name = "Column15";
		((DataGridViewColumn)Column16).HeaderText = "16";
		((DataGridViewColumn)Column16).Name = "Column16";
		((DataGridViewColumn)Column17).HeaderText = "17";
		((DataGridViewColumn)Column17).Name = "Column17";
		((DataGridViewColumn)Column18).HeaderText = "18";
		((DataGridViewColumn)Column18).Name = "Column18";
		((DataGridViewColumn)Column19).HeaderText = "19";
		((DataGridViewColumn)Column19).Name = "Column19";
		((DataGridViewColumn)Column20).HeaderText = "20";
		((DataGridViewColumn)Column20).Name = "Column20";
		((DataGridViewColumn)Column21).HeaderText = "21";
		((DataGridViewColumn)Column21).Name = "Column21";
		((DataGridViewColumn)Column22).HeaderText = "22";
		((DataGridViewColumn)Column22).Name = "Column22";
		((DataGridViewColumn)Column23).HeaderText = "23";
		((DataGridViewColumn)Column23).Name = "Column23";
		((DataGridViewColumn)Column24).HeaderText = "24";
		((DataGridViewColumn)Column24).Name = "Column24";
		((DataGridViewColumn)Column25).HeaderText = "25";
		((DataGridViewColumn)Column25).Name = "Column25";
		((DataGridViewColumn)Column26).HeaderText = "26";
		((DataGridViewColumn)Column26).Name = "Column26";
		((DataGridViewColumn)Column27).HeaderText = "27";
		((DataGridViewColumn)Column27).Name = "Column27";
		((DataGridViewColumn)Column28).HeaderText = "28";
		((DataGridViewColumn)Column28).Name = "Column28";
		((DataGridViewColumn)Column29).HeaderText = "29";
		((DataGridViewColumn)Column29).Name = "Column29";
		((DataGridViewColumn)Column30).HeaderText = "30";
		((DataGridViewColumn)Column30).Name = "Column30";
		((DataGridViewColumn)Column31).HeaderText = "31";
		((DataGridViewColumn)Column31).Name = "Column31";
		((Control)Panel_MOIS).Anchor = (AnchorStyles)13;
		((Control)Panel_MOIS).BackColor = Color.White;
		((Control)Panel_MOIS).Controls.Add((Control)(object)Text_INTERVALE);
		((Control)Panel_MOIS).Controls.Add((Control)(object)TableLayoutPanel2);
		((Control)Panel_MOIS).Controls.Add((Control)(object)Text_HEURE_DEPART);
		((Control)Panel_MOIS).Controls.Add((Control)(object)TableLayoutPanel1);
		((Control)Panel_MOIS).Controls.Add((Control)(object)Label11);
		((Control)Panel_MOIS).Controls.Add((Control)(object)Label10);
		((Control)Panel_MOIS).Controls.Add((Control)(object)TextBox_ANNEE);
		((Control)Panel_MOIS).Controls.Add((Control)(object)Label1);
		((Control)Panel_MOIS).Controls.Add((Control)(object)Label5);
		((Control)Panel_MOIS).Controls.Add((Control)(object)Label7);
		((Control)Panel_MOIS).Controls.Add((Control)(object)Label_MOIS);
		((Control)Panel_MOIS).Controls.Add((Control)(object)Label9);
		Panel panel_MOIS = Panel_MOIS;
		location = new Point(2, 1);
		((Control)panel_MOIS).Location = location;
		((Control)Panel_MOIS).Name = "Panel_MOIS";
		Panel panel_MOIS2 = Panel_MOIS;
		size = new Size(1021, 102);
		((Control)panel_MOIS2).Size = size;
		((Control)Panel_MOIS).TabIndex = 1116;
		TextBox text_INTERVALE = Text_INTERVALE;
		location = new Point(607, 3);
		((Control)text_INTERVALE).Location = location;
		((Control)Text_INTERVALE).Name = "Text_INTERVALE";
		TextBox text_INTERVALE2 = Text_INTERVALE;
		size = new Size(37, 20);
		((Control)text_INTERVALE2).Size = size;
		((Control)Text_INTERVALE).TabIndex = 1141;
		Text_INTERVALE.Text = "15";
		((Control)Text_INTERVALE).Visible = false;
		TableLayoutPanel2.ColumnCount = 4;
		TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle((SizeType)2, 25.0025f));
		TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle((SizeType)2, 25.0025f));
		TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle((SizeType)2, 25.0025f));
		TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle((SizeType)2, 24.9925f));
		TableLayoutPanel2.Controls.Add((Control)(object)RadioButton4, 3, 0);
		TableLayoutPanel2.Controls.Add((Control)(object)RadioButton1, 0, 0);
		TableLayoutPanel2.Controls.Add((Control)(object)RadioButton3, 2, 0);
		TableLayoutPanel2.Controls.Add((Control)(object)RadioButton2, 1, 0);
		TableLayoutPanel tableLayoutPanel = TableLayoutPanel2;
		location = new Point(7, 74);
		((Control)tableLayoutPanel).Location = location;
		TableLayoutPanel tableLayoutPanel2 = TableLayoutPanel2;
		margin = new Padding(0);
		((Control)tableLayoutPanel2).Margin = margin;
		((Control)TableLayoutPanel2).Name = "TableLayoutPanel2";
		TableLayoutPanel2.RowCount = 1;
		TableLayoutPanel2.RowStyles.Add(new RowStyle((SizeType)2, 100f));
		TableLayoutPanel tableLayoutPanel3 = TableLayoutPanel2;
		size = new Size(78, 24);
		((Control)tableLayoutPanel3).Size = size;
		((Control)TableLayoutPanel2).TabIndex = 1122;
		RadioButton4.Appearance = (Appearance)1;
		((ButtonBase)RadioButton4).BackColor = Color.DarkGray;
		((Control)RadioButton4).Cursor = Cursors.Hand;
		((Control)RadioButton4).Dock = (DockStyle)5;
		((ButtonBase)RadioButton4).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)RadioButton4).FlatAppearance.CheckedBackColor = Color.FromArgb(22, 106, 238);
		((ButtonBase)RadioButton4).FlatStyle = (FlatStyle)0;
		((Control)RadioButton4).Font = new Font("Calibri", 9f, (FontStyle)1);
		((Control)RadioButton4).ForeColor = Color.White;
		RadioButton radioButton = RadioButton4;
		location = new Point(57, 0);
		((Control)radioButton).Location = location;
		RadioButton radioButton2 = RadioButton4;
		margin = new Padding(0);
		((Control)radioButton2).Margin = margin;
		((Control)RadioButton4).Name = "RadioButton4";
		RadioButton radioButton3 = RadioButton4;
		size = new Size(21, 24);
		((Control)radioButton3).Size = size;
		((Control)RadioButton4).TabIndex = 1145;
		RadioButton4.TabStop = true;
		((ButtonBase)RadioButton4).Text = "4";
		RadioButton4.TextAlign = (ContentAlignment)32;
		((ButtonBase)RadioButton4).UseVisualStyleBackColor = false;
		RadioButton1.Appearance = (Appearance)1;
		((ButtonBase)RadioButton1).BackColor = Color.DarkGray;
		((Control)RadioButton1).Cursor = Cursors.Hand;
		((Control)RadioButton1).Dock = (DockStyle)5;
		((ButtonBase)RadioButton1).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)RadioButton1).FlatAppearance.CheckedBackColor = Color.FromArgb(22, 106, 238);
		((ButtonBase)RadioButton1).FlatStyle = (FlatStyle)0;
		((Control)RadioButton1).Font = new Font("Calibri", 9f, (FontStyle)1);
		((Control)RadioButton1).ForeColor = Color.White;
		RadioButton radioButton4 = RadioButton1;
		location = new Point(0, 0);
		((Control)radioButton4).Location = location;
		RadioButton radioButton5 = RadioButton1;
		margin = new Padding(0);
		((Control)radioButton5).Margin = margin;
		((Control)RadioButton1).Name = "RadioButton1";
		RadioButton radioButton6 = RadioButton1;
		size = new Size(19, 24);
		((Control)radioButton6).Size = size;
		((Control)RadioButton1).TabIndex = 1142;
		RadioButton1.TabStop = true;
		((ButtonBase)RadioButton1).Text = "1";
		RadioButton1.TextAlign = (ContentAlignment)32;
		((ButtonBase)RadioButton1).UseVisualStyleBackColor = false;
		RadioButton3.Appearance = (Appearance)1;
		((ButtonBase)RadioButton3).BackColor = Color.DarkGray;
		((Control)RadioButton3).Cursor = Cursors.Hand;
		((Control)RadioButton3).Dock = (DockStyle)5;
		((ButtonBase)RadioButton3).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)RadioButton3).FlatAppearance.CheckedBackColor = Color.FromArgb(22, 106, 238);
		((ButtonBase)RadioButton3).FlatStyle = (FlatStyle)0;
		((Control)RadioButton3).Font = new Font("Calibri", 9f, (FontStyle)1);
		((Control)RadioButton3).ForeColor = Color.White;
		RadioButton radioButton7 = RadioButton3;
		location = new Point(38, 0);
		((Control)radioButton7).Location = location;
		RadioButton radioButton8 = RadioButton3;
		margin = new Padding(0);
		((Control)radioButton8).Margin = margin;
		((Control)RadioButton3).Name = "RadioButton3";
		RadioButton radioButton9 = RadioButton3;
		size = new Size(19, 24);
		((Control)radioButton9).Size = size;
		((Control)RadioButton3).TabIndex = 1144;
		RadioButton3.TabStop = true;
		((ButtonBase)RadioButton3).Text = "3";
		RadioButton3.TextAlign = (ContentAlignment)32;
		((ButtonBase)RadioButton3).UseVisualStyleBackColor = false;
		RadioButton2.Appearance = (Appearance)1;
		((ButtonBase)RadioButton2).BackColor = Color.DarkGray;
		((Control)RadioButton2).Cursor = Cursors.Hand;
		((Control)RadioButton2).Dock = (DockStyle)5;
		((ButtonBase)RadioButton2).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)RadioButton2).FlatAppearance.CheckedBackColor = Color.FromArgb(22, 106, 238);
		((ButtonBase)RadioButton2).FlatStyle = (FlatStyle)0;
		((Control)RadioButton2).Font = new Font("Calibri", 9f, (FontStyle)1);
		((Control)RadioButton2).ForeColor = Color.White;
		RadioButton radioButton10 = RadioButton2;
		location = new Point(19, 0);
		((Control)radioButton10).Location = location;
		RadioButton radioButton11 = RadioButton2;
		margin = new Padding(0);
		((Control)radioButton11).Margin = margin;
		((Control)RadioButton2).Name = "RadioButton2";
		RadioButton radioButton12 = RadioButton2;
		size = new Size(19, 24);
		((Control)radioButton12).Size = size;
		((Control)RadioButton2).TabIndex = 1143;
		RadioButton2.TabStop = true;
		((ButtonBase)RadioButton2).Text = "2";
		RadioButton2.TextAlign = (ContentAlignment)32;
		((ButtonBase)RadioButton2).UseVisualStyleBackColor = false;
		TextBox text_HEURE_DEPART = Text_HEURE_DEPART;
		location = new Point(564, 3);
		((Control)text_HEURE_DEPART).Location = location;
		((Control)Text_HEURE_DEPART).Name = "Text_HEURE_DEPART";
		TextBox text_HEURE_DEPART2 = Text_HEURE_DEPART;
		size = new Size(37, 20);
		((Control)text_HEURE_DEPART2).Size = size;
		((Control)Text_HEURE_DEPART).TabIndex = 1125;
		Text_HEURE_DEPART.Text = "10:00";
		((Control)Text_HEURE_DEPART).Visible = false;
		TableLayoutPanel1.ColumnCount = 12;
		TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle((SizeType)2, 8.333333f));
		TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle((SizeType)2, 8.333333f));
		TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle((SizeType)2, 8.333333f));
		TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle((SizeType)2, 8.333333f));
		TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle((SizeType)2, 8.333333f));
		TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle((SizeType)2, 8.333333f));
		TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle((SizeType)2, 8.333333f));
		TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle((SizeType)2, 8.333333f));
		TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle((SizeType)2, 8.333333f));
		TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle((SizeType)2, 8.333333f));
		TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle((SizeType)2, 8.333333f));
		TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle((SizeType)2, 8.333333f));
		TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle((SizeType)1, 20f));
		TableLayoutPanel1.Controls.Add((Control)(object)Radio_MOIS_1, 0, 0);
		TableLayoutPanel1.Controls.Add((Control)(object)Radio_MOIS_2, 1, 0);
		TableLayoutPanel1.Controls.Add((Control)(object)Radio_MOIS_3, 2, 0);
		TableLayoutPanel1.Controls.Add((Control)(object)Radio_MOIS_4, 3, 0);
		TableLayoutPanel1.Controls.Add((Control)(object)Radio_MOIS_5, 4, 0);
		TableLayoutPanel1.Controls.Add((Control)(object)Radio_MOIS_6, 5, 0);
		TableLayoutPanel1.Controls.Add((Control)(object)Radio_MOIS_7, 6, 0);
		TableLayoutPanel1.Controls.Add((Control)(object)Radio_MOIS_12, 11, 0);
		TableLayoutPanel1.Controls.Add((Control)(object)Radio_MOIS_8, 7, 0);
		TableLayoutPanel1.Controls.Add((Control)(object)Radio_MOIS_11, 10, 0);
		TableLayoutPanel1.Controls.Add((Control)(object)Radio_MOIS_9, 8, 0);
		TableLayoutPanel1.Controls.Add((Control)(object)Radio_MOIS_10, 9, 0);
		((Control)TableLayoutPanel1).Dock = (DockStyle)1;
		TableLayoutPanel tableLayoutPanel4 = TableLayoutPanel1;
		location = new Point(4, 24);
		((Control)tableLayoutPanel4).Location = location;
		((Control)TableLayoutPanel1).Name = "TableLayoutPanel1";
		TableLayoutPanel1.RowCount = 1;
		TableLayoutPanel1.RowStyles.Add(new RowStyle((SizeType)2, 100f));
		TableLayoutPanel tableLayoutPanel5 = TableLayoutPanel1;
		size = new Size(1013, 50);
		((Control)tableLayoutPanel5).Size = size;
		((Control)TableLayoutPanel1).TabIndex = 1121;
		Radio_MOIS_1.Appearance = (Appearance)1;
		((ButtonBase)Radio_MOIS_1).BackColor = Color.DarkGray;
		((Control)Radio_MOIS_1).Cursor = Cursors.Hand;
		((Control)Radio_MOIS_1).Dock = (DockStyle)5;
		((ButtonBase)Radio_MOIS_1).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Radio_MOIS_1).FlatAppearance.CheckedBackColor = Color.FromArgb(22, 106, 238);
		((ButtonBase)Radio_MOIS_1).FlatStyle = (FlatStyle)0;
		((Control)Radio_MOIS_1).Font = new Font("Segoe UI", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Radio_MOIS_1).ForeColor = Color.White;
		RadioButton radio_MOIS_ = Radio_MOIS_1;
		location = new Point(3, 3);
		((Control)radio_MOIS_).Location = location;
		((Control)Radio_MOIS_1).Name = "Radio_MOIS_1";
		RadioButton radio_MOIS_2 = Radio_MOIS_1;
		size = new Size(78, 44);
		((Control)radio_MOIS_2).Size = size;
		((Control)Radio_MOIS_1).TabIndex = 1121;
		((Control)Radio_MOIS_1).Tag = "1";
		((ButtonBase)Radio_MOIS_1).Text = "JANV.\r\n01";
		Radio_MOIS_1.TextAlign = (ContentAlignment)32;
		((ButtonBase)Radio_MOIS_1).UseVisualStyleBackColor = false;
		Radio_MOIS_2.Appearance = (Appearance)1;
		((ButtonBase)Radio_MOIS_2).BackColor = Color.DarkGray;
		((Control)Radio_MOIS_2).Cursor = Cursors.Hand;
		((Control)Radio_MOIS_2).Dock = (DockStyle)5;
		((ButtonBase)Radio_MOIS_2).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Radio_MOIS_2).FlatAppearance.CheckedBackColor = Color.FromArgb(22, 106, 238);
		((ButtonBase)Radio_MOIS_2).FlatStyle = (FlatStyle)0;
		((Control)Radio_MOIS_2).Font = new Font("Segoe UI", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Radio_MOIS_2).ForeColor = Color.White;
		RadioButton radio_MOIS_3 = Radio_MOIS_2;
		location = new Point(87, 3);
		((Control)radio_MOIS_3).Location = location;
		((Control)Radio_MOIS_2).Name = "Radio_MOIS_2";
		RadioButton radio_MOIS_4 = Radio_MOIS_2;
		size = new Size(78, 44);
		((Control)radio_MOIS_4).Size = size;
		((Control)Radio_MOIS_2).TabIndex = 1122;
		((Control)Radio_MOIS_2).Tag = "2";
		((ButtonBase)Radio_MOIS_2).Text = "FÉVR.\r\n02";
		Radio_MOIS_2.TextAlign = (ContentAlignment)32;
		((ButtonBase)Radio_MOIS_2).UseVisualStyleBackColor = false;
		Radio_MOIS_3.Appearance = (Appearance)1;
		((ButtonBase)Radio_MOIS_3).BackColor = Color.DarkGray;
		((Control)Radio_MOIS_3).Cursor = Cursors.Hand;
		((Control)Radio_MOIS_3).Dock = (DockStyle)5;
		((ButtonBase)Radio_MOIS_3).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Radio_MOIS_3).FlatAppearance.CheckedBackColor = Color.FromArgb(22, 106, 238);
		((ButtonBase)Radio_MOIS_3).FlatStyle = (FlatStyle)0;
		((Control)Radio_MOIS_3).Font = new Font("Segoe UI", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Radio_MOIS_3).ForeColor = Color.White;
		RadioButton radio_MOIS_5 = Radio_MOIS_3;
		location = new Point(171, 3);
		((Control)radio_MOIS_5).Location = location;
		((Control)Radio_MOIS_3).Name = "Radio_MOIS_3";
		RadioButton radio_MOIS_6 = Radio_MOIS_3;
		size = new Size(78, 44);
		((Control)radio_MOIS_6).Size = size;
		((Control)Radio_MOIS_3).TabIndex = 1123;
		((Control)Radio_MOIS_3).Tag = "3";
		((ButtonBase)Radio_MOIS_3).Text = "MARS.\r\n03";
		Radio_MOIS_3.TextAlign = (ContentAlignment)32;
		((ButtonBase)Radio_MOIS_3).UseVisualStyleBackColor = false;
		Radio_MOIS_4.Appearance = (Appearance)1;
		((ButtonBase)Radio_MOIS_4).BackColor = Color.DarkGray;
		((Control)Radio_MOIS_4).Cursor = Cursors.Hand;
		((Control)Radio_MOIS_4).Dock = (DockStyle)5;
		((ButtonBase)Radio_MOIS_4).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Radio_MOIS_4).FlatAppearance.CheckedBackColor = Color.FromArgb(22, 106, 238);
		((ButtonBase)Radio_MOIS_4).FlatStyle = (FlatStyle)0;
		((Control)Radio_MOIS_4).Font = new Font("Segoe UI", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Radio_MOIS_4).ForeColor = Color.White;
		RadioButton radio_MOIS_7 = Radio_MOIS_4;
		location = new Point(255, 3);
		((Control)radio_MOIS_7).Location = location;
		((Control)Radio_MOIS_4).Name = "Radio_MOIS_4";
		RadioButton radio_MOIS_8 = Radio_MOIS_4;
		size = new Size(78, 44);
		((Control)radio_MOIS_8).Size = size;
		((Control)Radio_MOIS_4).TabIndex = 1124;
		((Control)Radio_MOIS_4).Tag = "4";
		((ButtonBase)Radio_MOIS_4).Text = "AVR.\r\n04";
		Radio_MOIS_4.TextAlign = (ContentAlignment)32;
		((ButtonBase)Radio_MOIS_4).UseVisualStyleBackColor = false;
		Radio_MOIS_5.Appearance = (Appearance)1;
		((ButtonBase)Radio_MOIS_5).BackColor = Color.DarkGray;
		((Control)Radio_MOIS_5).Cursor = Cursors.Hand;
		((Control)Radio_MOIS_5).Dock = (DockStyle)5;
		((ButtonBase)Radio_MOIS_5).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Radio_MOIS_5).FlatAppearance.CheckedBackColor = Color.FromArgb(22, 106, 238);
		((ButtonBase)Radio_MOIS_5).FlatStyle = (FlatStyle)0;
		((Control)Radio_MOIS_5).Font = new Font("Segoe UI", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Radio_MOIS_5).ForeColor = Color.White;
		RadioButton radio_MOIS_9 = Radio_MOIS_5;
		location = new Point(339, 3);
		((Control)radio_MOIS_9).Location = location;
		((Control)Radio_MOIS_5).Name = "Radio_MOIS_5";
		RadioButton radio_MOIS_10 = Radio_MOIS_5;
		size = new Size(78, 44);
		((Control)radio_MOIS_10).Size = size;
		((Control)Radio_MOIS_5).TabIndex = 1125;
		((Control)Radio_MOIS_5).Tag = "5";
		((ButtonBase)Radio_MOIS_5).Text = "MAI.\r\n05";
		Radio_MOIS_5.TextAlign = (ContentAlignment)32;
		((ButtonBase)Radio_MOIS_5).UseVisualStyleBackColor = false;
		Radio_MOIS_6.Appearance = (Appearance)1;
		((ButtonBase)Radio_MOIS_6).BackColor = Color.DarkGray;
		((Control)Radio_MOIS_6).Cursor = Cursors.Hand;
		((Control)Radio_MOIS_6).Dock = (DockStyle)5;
		((ButtonBase)Radio_MOIS_6).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Radio_MOIS_6).FlatAppearance.CheckedBackColor = Color.FromArgb(22, 106, 238);
		((ButtonBase)Radio_MOIS_6).FlatStyle = (FlatStyle)0;
		((Control)Radio_MOIS_6).Font = new Font("Segoe UI", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Radio_MOIS_6).ForeColor = Color.White;
		RadioButton radio_MOIS_11 = Radio_MOIS_6;
		location = new Point(423, 3);
		((Control)radio_MOIS_11).Location = location;
		((Control)Radio_MOIS_6).Name = "Radio_MOIS_6";
		RadioButton radio_MOIS_12 = Radio_MOIS_6;
		size = new Size(78, 44);
		((Control)radio_MOIS_12).Size = size;
		((Control)Radio_MOIS_6).TabIndex = 1126;
		((Control)Radio_MOIS_6).Tag = "6";
		((ButtonBase)Radio_MOIS_6).Text = "JUIN.\r\n06";
		Radio_MOIS_6.TextAlign = (ContentAlignment)32;
		((ButtonBase)Radio_MOIS_6).UseVisualStyleBackColor = false;
		Radio_MOIS_7.Appearance = (Appearance)1;
		((ButtonBase)Radio_MOIS_7).BackColor = Color.DarkGray;
		((Control)Radio_MOIS_7).Cursor = Cursors.Hand;
		((Control)Radio_MOIS_7).Dock = (DockStyle)5;
		((ButtonBase)Radio_MOIS_7).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Radio_MOIS_7).FlatAppearance.CheckedBackColor = Color.FromArgb(22, 106, 238);
		((ButtonBase)Radio_MOIS_7).FlatStyle = (FlatStyle)0;
		((Control)Radio_MOIS_7).Font = new Font("Segoe UI", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Radio_MOIS_7).ForeColor = Color.White;
		RadioButton radio_MOIS_13 = Radio_MOIS_7;
		location = new Point(507, 3);
		((Control)radio_MOIS_13).Location = location;
		((Control)Radio_MOIS_7).Name = "Radio_MOIS_7";
		RadioButton radio_MOIS_14 = Radio_MOIS_7;
		size = new Size(78, 44);
		((Control)radio_MOIS_14).Size = size;
		((Control)Radio_MOIS_7).TabIndex = 1127;
		((Control)Radio_MOIS_7).Tag = "7";
		((ButtonBase)Radio_MOIS_7).Text = "JUIL.\r\n07";
		Radio_MOIS_7.TextAlign = (ContentAlignment)32;
		((ButtonBase)Radio_MOIS_7).UseVisualStyleBackColor = false;
		Radio_MOIS_12.Appearance = (Appearance)1;
		((ButtonBase)Radio_MOIS_12).BackColor = Color.DarkGray;
		((Control)Radio_MOIS_12).Cursor = Cursors.Hand;
		((Control)Radio_MOIS_12).Dock = (DockStyle)5;
		((ButtonBase)Radio_MOIS_12).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Radio_MOIS_12).FlatAppearance.CheckedBackColor = Color.FromArgb(22, 106, 238);
		((ButtonBase)Radio_MOIS_12).FlatStyle = (FlatStyle)0;
		((Control)Radio_MOIS_12).Font = new Font("Segoe UI", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Radio_MOIS_12).ForeColor = Color.White;
		RadioButton radio_MOIS_15 = Radio_MOIS_12;
		location = new Point(927, 3);
		((Control)radio_MOIS_15).Location = location;
		((Control)Radio_MOIS_12).Name = "Radio_MOIS_12";
		RadioButton radio_MOIS_16 = Radio_MOIS_12;
		size = new Size(83, 44);
		((Control)radio_MOIS_16).Size = size;
		((Control)Radio_MOIS_12).TabIndex = 1132;
		((Control)Radio_MOIS_12).Tag = "12";
		((ButtonBase)Radio_MOIS_12).Text = "DÉC.\r\n12";
		Radio_MOIS_12.TextAlign = (ContentAlignment)32;
		((ButtonBase)Radio_MOIS_12).UseVisualStyleBackColor = false;
		Radio_MOIS_8.Appearance = (Appearance)1;
		((ButtonBase)Radio_MOIS_8).BackColor = Color.DarkGray;
		((Control)Radio_MOIS_8).Cursor = Cursors.Hand;
		((Control)Radio_MOIS_8).Dock = (DockStyle)5;
		((ButtonBase)Radio_MOIS_8).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Radio_MOIS_8).FlatAppearance.CheckedBackColor = Color.FromArgb(22, 106, 238);
		((ButtonBase)Radio_MOIS_8).FlatStyle = (FlatStyle)0;
		((Control)Radio_MOIS_8).Font = new Font("Segoe UI", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Radio_MOIS_8).ForeColor = Color.White;
		RadioButton radio_MOIS_17 = Radio_MOIS_8;
		location = new Point(591, 3);
		((Control)radio_MOIS_17).Location = location;
		((Control)Radio_MOIS_8).Name = "Radio_MOIS_8";
		RadioButton radio_MOIS_18 = Radio_MOIS_8;
		size = new Size(78, 44);
		((Control)radio_MOIS_18).Size = size;
		((Control)Radio_MOIS_8).TabIndex = 1128;
		((Control)Radio_MOIS_8).Tag = "8";
		((ButtonBase)Radio_MOIS_8).Text = "AOUT.\r\n08";
		Radio_MOIS_8.TextAlign = (ContentAlignment)32;
		((ButtonBase)Radio_MOIS_8).UseVisualStyleBackColor = false;
		Radio_MOIS_11.Appearance = (Appearance)1;
		((ButtonBase)Radio_MOIS_11).BackColor = Color.DarkGray;
		((Control)Radio_MOIS_11).Cursor = Cursors.Hand;
		((Control)Radio_MOIS_11).Dock = (DockStyle)5;
		((ButtonBase)Radio_MOIS_11).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Radio_MOIS_11).FlatAppearance.CheckedBackColor = Color.FromArgb(22, 106, 238);
		((ButtonBase)Radio_MOIS_11).FlatStyle = (FlatStyle)0;
		((Control)Radio_MOIS_11).Font = new Font("Segoe UI", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Radio_MOIS_11).ForeColor = Color.White;
		RadioButton radio_MOIS_19 = Radio_MOIS_11;
		location = new Point(843, 3);
		((Control)radio_MOIS_19).Location = location;
		((Control)Radio_MOIS_11).Name = "Radio_MOIS_11";
		RadioButton radio_MOIS_20 = Radio_MOIS_11;
		size = new Size(78, 44);
		((Control)radio_MOIS_20).Size = size;
		((Control)Radio_MOIS_11).TabIndex = 1131;
		((Control)Radio_MOIS_11).Tag = "11";
		((ButtonBase)Radio_MOIS_11).Text = "NOV.\r\n11";
		Radio_MOIS_11.TextAlign = (ContentAlignment)32;
		((ButtonBase)Radio_MOIS_11).UseVisualStyleBackColor = false;
		Radio_MOIS_9.Appearance = (Appearance)1;
		((ButtonBase)Radio_MOIS_9).BackColor = Color.DarkGray;
		((Control)Radio_MOIS_9).Cursor = Cursors.Hand;
		((Control)Radio_MOIS_9).Dock = (DockStyle)5;
		((ButtonBase)Radio_MOIS_9).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Radio_MOIS_9).FlatAppearance.CheckedBackColor = Color.FromArgb(22, 106, 238);
		((ButtonBase)Radio_MOIS_9).FlatStyle = (FlatStyle)0;
		((Control)Radio_MOIS_9).Font = new Font("Segoe UI", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Radio_MOIS_9).ForeColor = Color.White;
		RadioButton radio_MOIS_21 = Radio_MOIS_9;
		location = new Point(675, 3);
		((Control)radio_MOIS_21).Location = location;
		((Control)Radio_MOIS_9).Name = "Radio_MOIS_9";
		RadioButton radio_MOIS_22 = Radio_MOIS_9;
		size = new Size(78, 44);
		((Control)radio_MOIS_22).Size = size;
		((Control)Radio_MOIS_9).TabIndex = 1129;
		((Control)Radio_MOIS_9).Tag = "9";
		((ButtonBase)Radio_MOIS_9).Text = "SEPT.\r\n09";
		Radio_MOIS_9.TextAlign = (ContentAlignment)32;
		((ButtonBase)Radio_MOIS_9).UseVisualStyleBackColor = false;
		Radio_MOIS_10.Appearance = (Appearance)1;
		((ButtonBase)Radio_MOIS_10).BackColor = Color.DarkGray;
		((Control)Radio_MOIS_10).Cursor = Cursors.Hand;
		((Control)Radio_MOIS_10).Dock = (DockStyle)5;
		((ButtonBase)Radio_MOIS_10).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Radio_MOIS_10).FlatAppearance.CheckedBackColor = Color.FromArgb(22, 106, 238);
		((ButtonBase)Radio_MOIS_10).FlatStyle = (FlatStyle)0;
		((Control)Radio_MOIS_10).Font = new Font("Segoe UI", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Radio_MOIS_10).ForeColor = Color.White;
		RadioButton radio_MOIS_23 = Radio_MOIS_10;
		location = new Point(759, 3);
		((Control)radio_MOIS_23).Location = location;
		((Control)Radio_MOIS_10).Name = "Radio_MOIS_10";
		RadioButton radio_MOIS_24 = Radio_MOIS_10;
		size = new Size(78, 44);
		((Control)radio_MOIS_24).Size = size;
		((Control)Radio_MOIS_10).TabIndex = 1130;
		((Control)Radio_MOIS_10).Tag = "10";
		((ButtonBase)Radio_MOIS_10).Text = "OCT.\r\n10";
		Radio_MOIS_10.TextAlign = (ContentAlignment)32;
		((ButtonBase)Radio_MOIS_10).UseVisualStyleBackColor = false;
		((Control)Label11).BackColor = Color.FromArgb(22, 106, 238);
		Label11.FlatStyle = (FlatStyle)0;
		((Control)Label11).Font = new Font("Calibri", 14.25f, (FontStyle)1);
		((Control)Label11).ForeColor = Color.White;
		Label label7 = Label11;
		location = new Point(170, 6);
		((Control)label7).Location = location;
		((Control)Label11).Name = "Label11";
		Label label8 = Label11;
		size = new Size(14, 15);
		((Control)label8).Size = size;
		((Control)Label11).TabIndex = 1140;
		Label11.Text = "-";
		Label11.TextAlign = (ContentAlignment)16;
		Label11.UseCompatibleTextRendering = true;
		((Control)Label10).BackColor = Color.FromArgb(22, 106, 238);
		Label10.FlatStyle = (FlatStyle)0;
		((Control)Label10).Font = new Font("Calibri", 14.25f, (FontStyle)1);
		((Control)Label10).ForeColor = Color.White;
		Label label9 = Label10;
		location = new Point(184, 6);
		((Control)label9).Location = location;
		((Control)Label10).Name = "Label10";
		Label label10 = Label10;
		size = new Size(14, 15);
		((Control)label10).Size = size;
		((Control)Label10).TabIndex = 1139;
		Label10.Text = "+";
		Label10.TextAlign = (ContentAlignment)16;
		Label10.UseCompatibleTextRendering = true;
		((TextBoxBase)TextBox_ANNEE).BackColor = Color.FromArgb(22, 106, 238);
		((TextBoxBase)TextBox_ANNEE).BorderStyle = (BorderStyle)0;
		((Control)TextBox_ANNEE).Font = new Font("Tahoma", 9f, (FontStyle)1);
		((TextBoxBase)TextBox_ANNEE).ForeColor = Color.White;
		TextBox textBox_ANNEE = TextBox_ANNEE;
		location = new Point(131, 6);
		((Control)textBox_ANNEE).Location = location;
		((Control)TextBox_ANNEE).Name = "TextBox_ANNEE";
		((TextBoxBase)TextBox_ANNEE).ReadOnly = true;
		TextBox textBox_ANNEE2 = TextBox_ANNEE;
		size = new Size(39, 15);
		((Control)textBox_ANNEE2).Size = size;
		((Control)TextBox_ANNEE).TabIndex = 1121;
		TextBox_ANNEE.Text = "2022";
		((Control)Label1).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label1).Cursor = Cursors.Hand;
		((Control)Label1).Dock = (DockStyle)2;
		((Control)Label1).Font = new Font("Tahoma", 9f, (FontStyle)1);
		((Control)Label1).ForeColor = Color.White;
		Label1.ImeMode = (ImeMode)0;
		Label label11 = Label1;
		location = new Point(4, 98);
		((Control)label11).Location = location;
		((Control)Label1).Name = "Label1";
		Label label12 = Label1;
		size = new Size(1013, 4);
		((Control)label12).Size = size;
		((Control)Label1).TabIndex = 1136;
		Label1.TextAlign = (ContentAlignment)16;
		((Control)Label5).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label5).Cursor = Cursors.Hand;
		((Control)Label5).Dock = (DockStyle)3;
		((Control)Label5).Font = new Font("Tahoma", 9f, (FontStyle)1);
		((Control)Label5).ForeColor = Color.White;
		Label5.ImeMode = (ImeMode)0;
		Label label13 = Label5;
		location = new Point(0, 24);
		((Control)label13).Location = location;
		((Control)Label5).Name = "Label5";
		Label label14 = Label5;
		size = new Size(4, 78);
		((Control)label14).Size = size;
		((Control)Label5).TabIndex = 1135;
		Label5.TextAlign = (ContentAlignment)16;
		((Control)Label7).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label7).Cursor = Cursors.Hand;
		((Control)Label7).Dock = (DockStyle)4;
		((Control)Label7).Font = new Font("Tahoma", 9f, (FontStyle)1);
		((Control)Label7).ForeColor = Color.White;
		Label7.ImeMode = (ImeMode)0;
		Label label15 = Label7;
		location = new Point(1017, 24);
		((Control)label15).Location = location;
		((Control)Label7).Name = "Label7";
		Label label16 = Label7;
		size = new Size(4, 78);
		((Control)label16).Size = size;
		((Control)Label7).TabIndex = 1134;
		Label7.TextAlign = (ContentAlignment)16;
		((Control)Label_MOIS).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label_MOIS).Font = new Font("Tahoma", 9f, (FontStyle)1);
		((Control)Label_MOIS).ForeColor = Color.White;
		Label label_MOIS = Label_MOIS;
		location = new Point(32, 5);
		((Control)label_MOIS).Location = location;
		((Control)Label_MOIS).Name = "Label_MOIS";
		Label label_MOIS2 = Label_MOIS;
		size = new Size(22, 15);
		((Control)label_MOIS2).Size = size;
		((Control)Label_MOIS).TabIndex = 1133;
		Label_MOIS.Text = "12";
		Label_MOIS.TextAlign = (ContentAlignment)32;
		Label_MOIS.UseCompatibleTextRendering = true;
		((Control)Label9).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label9).Cursor = Cursors.Hand;
		((Control)Label9).Dock = (DockStyle)1;
		((Control)Label9).Font = new Font("Tahoma", 9f, (FontStyle)1);
		((Control)Label9).ForeColor = Color.White;
		Label9.ImeMode = (ImeMode)0;
		Label label17 = Label9;
		location = new Point(0, 0);
		((Control)label17).Location = location;
		((Control)Label9).Name = "Label9";
		Label label18 = Label9;
		size = new Size(1021, 24);
		((Control)label18).Size = size;
		((Control)Label9).TabIndex = 1137;
		Label9.Text = "Mois      de l'année : ";
		Label9.TextAlign = (ContentAlignment)16;
		DataGridView2.AllowUserToAddRows = false;
		DataGridView2.AllowUserToDeleteRows = false;
		DataGridView2.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		DataGridView dataGridView3 = DataGridView2;
		location = new Point(777, 187);
		((Control)dataGridView3).Location = location;
		((Control)DataGridView2).Name = "DataGridView2";
		DataGridView2.ReadOnly = true;
		DataGridView dataGridView4 = DataGridView2;
		size = new Size(231, 150);
		((Control)dataGridView4).Size = size;
		((Control)DataGridView2).TabIndex = 1119;
		((Control)DataGridView2).Visible = false;
		((Control)Panel_DETAILS).Anchor = (AnchorStyles)1;
		((Control)Panel_DETAILS).BackColor = Color.White;
		((Control)Panel_DETAILS).Controls.Add((Control)(object)Button3);
		((Control)Panel_DETAILS).Controls.Add((Control)(object)Button1);
		((Control)Panel_DETAILS).Controls.Add((Control)(object)Label33);
		((Control)Panel_DETAILS).Controls.Add((Control)(object)Button244);
		((Control)Panel_DETAILS).Controls.Add((Control)(object)DataGridView3);
		((Control)Panel_DETAILS).Controls.Add((Control)(object)Button_EDIT);
		((Control)Panel_DETAILS).Controls.Add((Control)(object)PictureBox4);
		((Control)Panel_DETAILS).Controls.Add((Control)(object)Label24);
		((Control)Panel_DETAILS).Controls.Add((Control)(object)PictureBox3);
		((Control)Panel_DETAILS).Controls.Add((Control)(object)PictureBox2);
		((Control)Panel_DETAILS).Controls.Add((Control)(object)PictureBox1);
		((Control)Panel_DETAILS).Controls.Add((Control)(object)Label19);
		((Control)Panel_DETAILS).Controls.Add((Control)(object)Label17);
		((Control)Panel_DETAILS).Controls.Add((Control)(object)Label15);
		((Control)Panel_DETAILS).Controls.Add((Control)(object)Label14);
		((Control)Panel_DETAILS).Controls.Add((Control)(object)Label12);
		((Control)Panel_DETAILS).Controls.Add((Control)(object)Label13);
		((Control)Panel_DETAILS).Controls.Add((Control)(object)Label18);
		((Control)Panel_DETAILS).Controls.Add((Control)(object)Label20);
		((Control)Panel_DETAILS).Controls.Add((Control)(object)Label16);
		Panel panel_DETAILS = Panel_DETAILS;
		location = new Point(28, 275);
		((Control)panel_DETAILS).Location = location;
		((Control)Panel_DETAILS).Name = "Panel_DETAILS";
		Panel panel_DETAILS2 = Panel_DETAILS;
		size = new Size(386, 289);
		((Control)panel_DETAILS2).Size = size;
		((Control)Panel_DETAILS).TabIndex = 1122;
		((Control)Panel_DETAILS).Visible = false;
		((ButtonBase)Button3).Image = (Image)componentResourceManager.GetObject("Button3.Image");
		((ButtonBase)Button3).ImageAlign = (ContentAlignment)16;
		Button button11 = Button3;
		location = new Point(7, 247);
		((Control)button11).Location = location;
		((Control)Button3).Name = "Button3";
		Button button12 = Button3;
		size = new Size(111, 35);
		((Control)button12).Size = size;
		((Control)Button3).TabIndex = 1134;
		((ButtonBase)Button3).Text = "Nouveau";
		((ButtonBase)Button3).UseVisualStyleBackColor = true;
		((ButtonBase)Button1).Image = (Image)componentResourceManager.GetObject("Button1.Image");
		((ButtonBase)Button1).ImageAlign = (ContentAlignment)16;
		Button button13 = Button1;
		location = new Point(138, 247);
		((Control)button13).Location = location;
		((Control)Button1).Name = "Button1";
		Button button14 = Button1;
		size = new Size(111, 35);
		((Control)button14).Size = size;
		((Control)Button1).TabIndex = 1133;
		((ButtonBase)Button1).Text = "Supprimer";
		((ButtonBase)Button1).UseVisualStyleBackColor = true;
		((Control)Label33).BackColor = Color.Transparent;
		((Control)Label33).Font = new Font("Segoe UI", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label33).ForeColor = Color.FromArgb(64, 64, 64);
		Label label19 = Label33;
		location = new Point(165, 120);
		((Control)label19).Location = location;
		((Control)Label33).Name = "Label33";
		Label label20 = Label33;
		size = new Size(211, 102);
		((Control)label20).Size = size;
		((Control)Label33).TabIndex = 1130;
		Label33.Text = "-";
		((ButtonBase)Button244).BackColor = Color.Red;
		((Control)Button244).Cursor = Cursors.Hand;
		((ButtonBase)Button244).FlatStyle = (FlatStyle)0;
		((Control)Button244).Font = new Font("Tahoma", 12.25f, (FontStyle)1);
		((Control)Button244).ForeColor = Color.White;
		((ButtonBase)Button244).Image = (Image)componentResourceManager.GetObject("Button244.Image");
		((ButtonBase)Button244).ImeMode = (ImeMode)0;
		Button button15 = Button244;
		location = new Point(339, 0);
		((Control)button15).Location = location;
		Button button16 = Button244;
		margin = new Padding(0);
		((Control)button16).Margin = margin;
		((Control)Button244).Name = "Button244";
		Button button17 = Button244;
		size = new Size(43, 24);
		((Control)button17).Size = size;
		((Control)Button244).TabIndex = 1129;
		((ButtonBase)Button244).TextAlign = (ContentAlignment)2;
		((ButtonBase)Button244).UseVisualStyleBackColor = false;
		DataGridView3.AllowUserToAddRows = false;
		DataGridView3.AllowUserToDeleteRows = false;
		DataGridView3.AllowUserToResizeColumns = false;
		DataGridView3.AllowUserToResizeRows = false;
		((Control)DataGridView3).Anchor = (AnchorStyles)13;
		DataGridView3.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)16;
		DataGridView3.BackgroundColor = Color.White;
		DataGridView3.BorderStyle = (BorderStyle)2;
		DataGridView3.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		DataGridView3.Columns.AddRange(new DataGridViewColumn[6]
		{
			(DataGridViewColumn)ID,
			(DataGridViewColumn)CLIENT,
			(DataGridViewColumn)DATES,
			(DataGridViewColumn)HEURE,
			(DataGridViewColumn)TELEPHONE,
			(DataGridViewColumn)NOTES
		});
		DataGridView3.EditMode = (DataGridViewEditMode)4;
		DataGridView3.EnableHeadersVisualStyles = false;
		DataGridView dataGridView5 = DataGridView3;
		location = new Point(7, 27);
		((Control)dataGridView5).Location = location;
		((Control)DataGridView3).Name = "DataGridView3";
		DataGridView3.RowHeadersVisible = false;
		DataGridView3.SelectionMode = (DataGridViewSelectionMode)1;
		DataGridView dataGridView6 = DataGridView3;
		size = new Size(152, 195);
		((Control)dataGridView6).Size = size;
		((Control)DataGridView3).TabIndex = 1128;
		((DataGridViewColumn)ID).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)ID).HeaderText = "ID";
		((DataGridViewColumn)ID).MinimumWidth = 2;
		((DataGridViewColumn)ID).Name = "ID";
		((DataGridViewColumn)ID).Width = 2;
		((DataGridViewColumn)CLIENT).HeaderText = "CLIENT";
		((DataGridViewColumn)CLIENT).Name = "CLIENT";
		((DataGridViewColumn)DATES).HeaderText = "DATES";
		((DataGridViewColumn)DATES).Name = "DATES";
		((DataGridViewColumn)DATES).Visible = false;
		((DataGridViewColumn)HEURE).HeaderText = "HEURE";
		((DataGridViewColumn)HEURE).Name = "HEURE";
		((DataGridViewColumn)HEURE).Visible = false;
		((DataGridViewColumn)TELEPHONE).HeaderText = "TELEPHONE";
		((DataGridViewColumn)TELEPHONE).Name = "TELEPHONE";
		((DataGridViewColumn)TELEPHONE).Visible = false;
		((DataGridViewColumn)NOTES).HeaderText = "NOTES";
		((DataGridViewColumn)NOTES).Name = "NOTES";
		((DataGridViewColumn)NOTES).Visible = false;
		((ButtonBase)Button_EDIT).Image = (Image)componentResourceManager.GetObject("Button_EDIT.Image");
		((ButtonBase)Button_EDIT).ImageAlign = (ContentAlignment)16;
		Button button_EDIT = Button_EDIT;
		location = new Point(265, 247);
		((Control)button_EDIT).Location = location;
		((Control)Button_EDIT).Name = "Button_EDIT";
		Button button_EDIT2 = Button_EDIT;
		size = new Size(111, 35);
		((Control)button_EDIT2).Size = size;
		((Control)Button_EDIT).TabIndex = 989;
		((ButtonBase)Button_EDIT).Text = "Modifié";
		((ButtonBase)Button_EDIT).UseVisualStyleBackColor = true;
		PictureBox4.Image = (Image)componentResourceManager.GetObject("PictureBox4.Image");
		PictureBox pictureBox = PictureBox4;
		location = new Point(165, 87);
		((Control)pictureBox).Location = location;
		((Control)PictureBox4).Name = "PictureBox4";
		PictureBox pictureBox2 = PictureBox4;
		size = new Size(24, 30);
		((Control)pictureBox2).Size = size;
		PictureBox4.SizeMode = (PictureBoxSizeMode)4;
		PictureBox4.TabIndex = 1127;
		PictureBox4.TabStop = false;
		((Control)Label24).BackColor = Color.Transparent;
		((Control)Label24).Font = new Font("Segoe UI", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label24).ForeColor = Color.FromArgb(64, 64, 64);
		Label label21 = Label24;
		location = new Point(192, 87);
		((Control)label21).Location = location;
		((Control)Label24).Name = "Label24";
		Label label22 = Label24;
		size = new Size(184, 30);
		((Control)label22).Size = size;
		((Control)Label24).TabIndex = 1126;
		Label24.Text = "-";
		Label24.TextAlign = (ContentAlignment)16;
		PictureBox3.Image = (Image)componentResourceManager.GetObject("PictureBox3.Image");
		PictureBox pictureBox3 = PictureBox3;
		location = new Point(165, 57);
		((Control)pictureBox3).Location = location;
		((Control)PictureBox3).Name = "PictureBox3";
		PictureBox pictureBox4 = PictureBox3;
		size = new Size(24, 30);
		((Control)pictureBox4).Size = size;
		PictureBox3.SizeMode = (PictureBoxSizeMode)4;
		PictureBox3.TabIndex = 1125;
		PictureBox3.TabStop = false;
		PictureBox2.Image = (Image)componentResourceManager.GetObject("PictureBox2.Image");
		PictureBox pictureBox5 = PictureBox2;
		location = new Point(287, 27);
		((Control)pictureBox5).Location = location;
		((Control)PictureBox2).Name = "PictureBox2";
		PictureBox pictureBox6 = PictureBox2;
		size = new Size(24, 30);
		((Control)pictureBox6).Size = size;
		PictureBox2.SizeMode = (PictureBoxSizeMode)4;
		PictureBox2.TabIndex = 1124;
		PictureBox2.TabStop = false;
		PictureBox1.Image = (Image)componentResourceManager.GetObject("PictureBox1.Image");
		PictureBox pictureBox7 = PictureBox1;
		location = new Point(165, 27);
		((Control)pictureBox7).Location = location;
		((Control)PictureBox1).Name = "PictureBox1";
		PictureBox pictureBox8 = PictureBox1;
		size = new Size(24, 30);
		((Control)pictureBox8).Size = size;
		PictureBox1.SizeMode = (PictureBoxSizeMode)4;
		PictureBox1.TabIndex = 1123;
		PictureBox1.TabStop = false;
		((Control)Label19).BackColor = Color.Transparent;
		((Control)Label19).Font = new Font("Segoe UI", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label19).ForeColor = Color.FromArgb(64, 64, 64);
		Label label23 = Label19;
		location = new Point(192, 57);
		((Control)label23).Location = location;
		((Control)Label19).Name = "Label19";
		Label label24 = Label19;
		size = new Size(184, 30);
		((Control)label24).Size = size;
		((Control)Label19).TabIndex = 877;
		Label19.Text = "-";
		Label19.TextAlign = (ContentAlignment)16;
		((Control)Label17).BackColor = Color.Transparent;
		((Control)Label17).Font = new Font("Segoe UI", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label17).ForeColor = Color.FromArgb(64, 64, 64);
		Label label25 = Label17;
		location = new Point(311, 27);
		((Control)label25).Location = location;
		((Control)Label17).Name = "Label17";
		Label label26 = Label17;
		size = new Size(18, 30);
		((Control)label26).Size = size;
		((Control)Label17).TabIndex = 875;
		Label17.Text = "à";
		Label17.TextAlign = (ContentAlignment)16;
		((Control)Label15).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label15).Cursor = Cursors.Hand;
		((Control)Label15).Dock = (DockStyle)1;
		((Control)Label15).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label15).ForeColor = Color.White;
		Label label27 = Label15;
		location = new Point(4, 0);
		((Control)label27).Location = location;
		((Control)Label15).Name = "Label15";
		Label label28 = Label15;
		size = new Size(378, 24);
		((Control)label28).Size = size;
		((Control)Label15).TabIndex = 870;
		Label15.Text = "Rendez-vous";
		Label15.TextAlign = (ContentAlignment)16;
		((Control)Label14).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label14).Cursor = Cursors.Hand;
		((Control)Label14).Dock = (DockStyle)4;
		((Control)Label14).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label14).ForeColor = Color.White;
		Label label29 = Label14;
		location = new Point(382, 0);
		((Control)label29).Location = location;
		((Control)Label14).Name = "Label14";
		Label label30 = Label14;
		size = new Size(4, 285);
		((Control)label30).Size = size;
		((Control)Label14).TabIndex = 869;
		Label14.TextAlign = (ContentAlignment)16;
		((Control)Label12).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label12).Cursor = Cursors.Hand;
		((Control)Label12).Dock = (DockStyle)2;
		((Control)Label12).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label12).ForeColor = Color.White;
		Label label31 = Label12;
		location = new Point(4, 285);
		((Control)label31).Location = location;
		((Control)Label12).Name = "Label12";
		Label label32 = Label12;
		size = new Size(382, 4);
		((Control)label32).Size = size;
		((Control)Label12).TabIndex = 868;
		Label12.TextAlign = (ContentAlignment)16;
		((Control)Label13).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label13).Cursor = Cursors.Hand;
		((Control)Label13).Dock = (DockStyle)3;
		((Control)Label13).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label13).ForeColor = Color.White;
		Label label33 = Label13;
		location = new Point(0, 0);
		((Control)label33).Location = location;
		((Control)Label13).Name = "Label13";
		Label label34 = Label13;
		size = new Size(4, 289);
		((Control)label34).Size = size;
		((Control)Label13).TabIndex = 867;
		Label13.TextAlign = (ContentAlignment)16;
		((Control)Label18).BackColor = Color.Transparent;
		((Control)Label18).Font = new Font("Segoe UI", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label18).ForeColor = Color.FromArgb(64, 64, 64);
		Label label35 = Label18;
		location = new Point(210, 27);
		((Control)label35).Location = location;
		((Control)Label18).Name = "Label18";
		Label label36 = Label18;
		size = new Size(79, 30);
		((Control)label36).Size = size;
		((Control)Label18).TabIndex = 874;
		Label18.Text = "00/00/0000";
		Label18.TextAlign = (ContentAlignment)16;
		((Control)Label20).BackColor = Color.Transparent;
		((Control)Label20).Font = new Font("Segoe UI", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label20).ForeColor = Color.FromArgb(64, 64, 64);
		Label label37 = Label20;
		location = new Point(325, 27);
		((Control)label37).Location = location;
		((Control)Label20).Name = "Label20";
		Label label38 = Label20;
		size = new Size(51, 30);
		((Control)label38).Size = size;
		((Control)Label20).TabIndex = 876;
		Label20.Text = "00:00";
		Label20.TextAlign = (ContentAlignment)16;
		((Control)Label16).BackColor = Color.Transparent;
		((Control)Label16).Font = new Font("Segoe UI", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label16).ForeColor = Color.FromArgb(64, 64, 64);
		Label label39 = Label16;
		location = new Point(189, 27);
		((Control)label39).Location = location;
		((Control)Label16).Name = "Label16";
		Label label40 = Label16;
		size = new Size(28, 30);
		((Control)label40).Size = size;
		((Control)Label16).TabIndex = 871;
		Label16.Text = "Le";
		Label16.TextAlign = (ContentAlignment)16;
		((Control)Panel5).Anchor = (AnchorStyles)10;
		((Control)Panel5).BackColor = Color.DarkViolet;
		((Control)Panel5).Controls.Add((Control)(object)Label_CEMOIS);
		((Control)Panel5).Controls.Add((Control)(object)Label_DEMAIN);
		((Control)Panel5).Controls.Add((Control)(object)Label_AUJOURDHUI);
		((Control)Panel5).Controls.Add((Control)(object)Label23);
		((Control)Panel5).Controls.Add((Control)(object)Label22);
		((Control)Panel5).Controls.Add((Control)(object)PictureBox5);
		((Control)Panel5).Controls.Add((Control)(object)Label21);
		((Control)Panel5).ForeColor = Color.FromArgb(214, 214, 214);
		Panel panel3 = Panel5;
		location = new Point(622, 646);
		((Control)panel3).Location = location;
		((Control)Panel5).Name = "Panel5";
		Panel panel4 = Panel5;
		size = new Size(401, 40);
		((Control)panel4).Size = size;
		((Control)Panel5).TabIndex = 1123;
		((Control)Label_CEMOIS).BackColor = Color.Transparent;
		((Control)Label_CEMOIS).Font = new Font("Segoe UI", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label_CEMOIS).ForeColor = Color.WhiteSmoke;
		Label_CEMOIS.ImeMode = (ImeMode)0;
		Label label_CEMOIS = Label_CEMOIS;
		location = new Point(287, 16);
		((Control)label_CEMOIS).Location = location;
		((Control)Label_CEMOIS).Name = "Label_CEMOIS";
		Label label_CEMOIS2 = Label_CEMOIS;
		size = new Size(111, 20);
		((Control)label_CEMOIS2).Size = size;
		((Control)Label_CEMOIS).TabIndex = 794;
		Label_CEMOIS.Text = "0";
		Label_CEMOIS.TextAlign = (ContentAlignment)32;
		((Control)Label_DEMAIN).BackColor = Color.Transparent;
		((Control)Label_DEMAIN).Font = new Font("Segoe UI", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label_DEMAIN).ForeColor = Color.WhiteSmoke;
		Label_DEMAIN.ImeMode = (ImeMode)0;
		Label label_DEMAIN = Label_DEMAIN;
		location = new Point(168, 16);
		((Control)label_DEMAIN).Location = location;
		((Control)Label_DEMAIN).Name = "Label_DEMAIN";
		Label label_DEMAIN2 = Label_DEMAIN;
		size = new Size(111, 20);
		((Control)label_DEMAIN2).Size = size;
		((Control)Label_DEMAIN).TabIndex = 793;
		Label_DEMAIN.Text = "0";
		Label_DEMAIN.TextAlign = (ContentAlignment)32;
		((Control)Label_AUJOURDHUI).BackColor = Color.Transparent;
		((Control)Label_AUJOURDHUI).Cursor = Cursors.Hand;
		((Control)Label_AUJOURDHUI).Font = new Font("Segoe UI", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label_AUJOURDHUI).ForeColor = Color.WhiteSmoke;
		Label_AUJOURDHUI.ImeMode = (ImeMode)0;
		Label label_AUJOURDHUI = Label_AUJOURDHUI;
		location = new Point(49, 16);
		((Control)label_AUJOURDHUI).Location = location;
		((Control)Label_AUJOURDHUI).Name = "Label_AUJOURDHUI";
		Label label_AUJOURDHUI2 = Label_AUJOURDHUI;
		size = new Size(111, 20);
		((Control)label_AUJOURDHUI2).Size = size;
		((Control)Label_AUJOURDHUI).TabIndex = 792;
		Label_AUJOURDHUI.Text = "0";
		Label_AUJOURDHUI.TextAlign = (ContentAlignment)32;
		((Control)Label23).BackColor = Color.Transparent;
		((Control)Label23).Font = new Font("Segoe UI", 9.75f, (FontStyle)1);
		((Control)Label23).ForeColor = Color.WhiteSmoke;
		Label23.ImeMode = (ImeMode)0;
		Label label41 = Label23;
		location = new Point(287, -2);
		((Control)label41).Location = location;
		((Control)Label23).Name = "Label23";
		Label label42 = Label23;
		size = new Size(111, 20);
		((Control)label42).Size = size;
		((Control)Label23).TabIndex = 791;
		Label23.Text = "Ce mois";
		Label23.TextAlign = (ContentAlignment)32;
		((Control)Label22).BackColor = Color.Transparent;
		((Control)Label22).Font = new Font("Segoe UI", 9.75f, (FontStyle)1);
		((Control)Label22).ForeColor = Color.WhiteSmoke;
		Label22.ImeMode = (ImeMode)0;
		Label label43 = Label22;
		location = new Point(168, -1);
		((Control)label43).Location = location;
		((Control)Label22).Name = "Label22";
		Label label44 = Label22;
		size = new Size(111, 20);
		((Control)label44).Size = size;
		((Control)Label22).TabIndex = 790;
		Label22.Text = "Demain";
		Label22.TextAlign = (ContentAlignment)32;
		PictureBox5.Image = (Image)componentResourceManager.GetObject("PictureBox5.Image");
		PictureBox5.ImeMode = (ImeMode)0;
		PictureBox pictureBox9 = PictureBox5;
		location = new Point(0, 0);
		((Control)pictureBox9).Location = location;
		((Control)PictureBox5).Name = "PictureBox5";
		PictureBox pictureBox10 = PictureBox5;
		size = new Size(49, 39);
		((Control)pictureBox10).Size = size;
		PictureBox5.SizeMode = (PictureBoxSizeMode)4;
		PictureBox5.TabIndex = 789;
		PictureBox5.TabStop = false;
		((Control)Label21).BackColor = Color.Transparent;
		((Control)Label21).Cursor = Cursors.Hand;
		((Control)Label21).Font = new Font("Segoe UI", 9.75f, (FontStyle)1);
		((Control)Label21).ForeColor = Color.WhiteSmoke;
		Label21.ImeMode = (ImeMode)0;
		Label label45 = Label21;
		location = new Point(49, -1);
		((Control)label45).Location = location;
		((Control)Label21).Name = "Label21";
		Label label46 = Label21;
		size = new Size(111, 20);
		((Control)label46).Size = size;
		((Control)Label21).TabIndex = 389;
		Label21.Text = "Aujourd'hui";
		Label21.TextAlign = (ContentAlignment)32;
		((Control)Button_CALC).ForeColor = Color.Red;
		((ButtonBase)Button_CALC).ImeMode = (ImeMode)0;
		Button button_CALC = Button_CALC;
		location = new Point(469, 655);
		((Control)button_CALC).Location = location;
		((Control)Button_CALC).Name = "Button_CALC";
		Button button_CALC2 = Button_CALC;
		size = new Size(83, 30);
		((Control)button_CALC2).Size = size;
		((Control)Button_CALC).TabIndex = 1124;
		((ButtonBase)Button_CALC).Text = "Button_CALC";
		((ButtonBase)Button_CALC).UseVisualStyleBackColor = true;
		((Control)Button_CALC).Visible = false;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).BackColor = Color.White;
		size = new Size(1025, 692);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)Panel_DETAILS);
		((Control)this).Controls.Add((Control)(object)Panel_INFO);
		((Control)this).Controls.Add((Control)(object)Button_CALC);
		((Control)this).Controls.Add((Control)(object)Panel5);
		((Control)this).Controls.Add((Control)(object)DataGridView2);
		((Control)this).Controls.Add((Control)(object)Panel_MOIS);
		((Control)this).Controls.Add((Control)(object)Button_ADD);
		((Control)this).Controls.Add((Control)(object)DataGridView1);
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Form)this).KeyPreview = true;
		((Control)this).Name = "Form_5_CLIENTS_RDV";
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).WindowState = (FormWindowState)2;
		((Control)Panel_INFO).ResumeLayout(false);
		((Control)Panel1).ResumeLayout(false);
		((Control)Panel1).PerformLayout();
		((ISupportInitialize)DataGridView1).EndInit();
		((Control)Panel_MOIS).ResumeLayout(false);
		((Control)Panel_MOIS).PerformLayout();
		((Control)TableLayoutPanel2).ResumeLayout(false);
		((Control)TableLayoutPanel1).ResumeLayout(false);
		((ISupportInitialize)DataGridView2).EndInit();
		((Control)Panel_DETAILS).ResumeLayout(false);
		((ISupportInitialize)DataGridView3).EndInit();
		((ISupportInitialize)PictureBox4).EndInit();
		((ISupportInitialize)PictureBox3).EndInit();
		((ISupportInitialize)PictureBox2).EndInit();
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)Panel5).ResumeLayout(false);
		((ISupportInitialize)PictureBox5).EndInit();
		((Control)this).ResumeLayout(false);
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

	private void Form_1_LOGIN_Resize(object sender, EventArgs e)
	{
		Panel panel_DETAILS = Panel_DETAILS;
		Point location = checked(new Point((int)Math.Round((double)((Control)this).Width / 2.0 - (double)((Control)Panel_DETAILS).Width / 2.0), (int)Math.Round((double)((Control)this).Height / 2.0 - (double)((Control)Panel_DETAILS).Height / 2.0)));
		((Control)panel_DETAILS).Location = location;
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

	private void FormDialog_famille_Load(object sender, EventArgs e)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_04df: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e6: Expected Obj, but got Unknown
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected Obj, but got Unknown
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected Obj, but got Unknown
		//IL_0382: Unknown result type (might be due to invalid IL or missing references)
		//IL_0388: Expected Obj, but got Unknown
		checked
		{
			try
			{
				Module1._DT_TEMP.Clear();
				Module1._DA_TEMP = new MySqlDataAdapter("select * from TABLE_PASS  where  Catégorie = 'UTILISATEUR'   order by ID asc", Module1.cn_SQL);
				((DbDataAdapter)(object)Module1._DA_TEMP).Fill(Module1._DT_TEMP);
				ListBox_VENDEURS.Items.Clear();
				int num = Module1._DT_TEMP.Rows.Count - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					ListBox_VENDEURS.Items.Add((object)Module1._DT_TEMP.Rows[num2]["ListUser"].ToString());
					num2++;
				}
				DataGridView1.RowTemplate.Height = 40;
				DataGridView1.BackgroundColor = Color.White;
				DataGridView1.SelectionMode = (DataGridViewSelectionMode)0;
				DataGridView1.EditMode = (DataGridViewEditMode)4;
				DataGridView1.GridColor = Color.FromArgb(231, 231, 231);
				DataGridView1.ColumnHeadersBorderStyle = (DataGridViewHeaderBorderStyle)1;
				DataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 11f, (FontStyle)1);
				DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(34, 34, 34);
				DataGridView1.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)0;
				DataGridView1.DefaultCellStyle.Alignment = (DataGridViewContentAlignment)32;
				DataGridView1.CellBorderStyle = (DataGridViewCellBorderStyle)5;
				DataGridView1.DefaultCellStyle.Font = new Font("Calibri", 11f, (FontStyle)1);
				DataGridView1.DefaultCellStyle.ForeColor = Color.FromArgb(34, 34, 34);
				DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(221, 235, 247);
				DataGridView1.RowsDefaultCellStyle.SelectionBackColor = Color.Yellow;
				DataGridView1.RowsDefaultCellStyle.SelectionForeColor = Color.Black;
				DataGridView1.ClipboardCopyMode = (DataGridViewClipboardCopyMode)0;
				int num5 = ((BaseCollection)DataGridView1.Columns).Count - 1;
				int num6 = 0;
				while (true)
				{
					int num7 = num6;
					int num4 = num5;
					if (num7 > num4)
					{
						break;
					}
					DataGridView1.Columns[num6].SortMode = (DataGridViewColumnSortMode)2;
					num6++;
				}
				DataGridView1.EnableHeadersVisualStyles = false;
				DataGridView1.DefaultCellStyle.WrapMode = (DataGridViewTriState)1;
				DateTime t = Conversions.ToDate(Conversions.ToDate(Text_HEURE_DEPART.Text).ToString("HH:mm"));
				int num8 = Conversions.ToInteger(Text_INTERVALE.Text);
				ListBox_HEURE.Items.Clear();
				while (DateTime.Compare(t, Conversions.ToDate("23:00")) < 0)
				{
					ListBox_HEURE.Items.Add((object)t.ToString("HH:mm"));
					t = Conversions.ToDate(t.AddMinutes(num8).ToString("HH:mm"));
				}
				ListBox_HEURE.Items.Add((object)t.ToString("HH:mm"));
				((Control)TableLayoutPanel2).Width = ((Control)Radio_MOIS_1).Width;
				TextBox_ANNEE.Text = Conversions.ToString(DateAndTime.Year(DateAndTime.Now));
				RadioButton val = (RadioButton)TableLayoutPanel1.Controls["Radio_MOIS_" + Conversions.ToString(DateAndTime.Month(DateAndTime.Now))];
				val.PerformClick();
				int num9 = Conversions.ToInteger(DateTime.Now.Date.ToString("dd"));
				if ((num9 >= 1) & (num9 <= 7))
				{
					RadioButton1.PerformClick();
				}
				else if ((num9 >= 8) & (num9 <= 15))
				{
					RadioButton2.PerformClick();
				}
				else if ((num9 >= 16) & (num9 <= 23))
				{
					RadioButton3.PerformClick();
				}
				else if ((num9 >= 24) & (num9 <= _nbr_jours))
				{
					RadioButton4.PerformClick();
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

	private void Button_ADD_Click(object sender, EventArgs e)
	{
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Expected Obj, but got Unknown
		try
		{
			((Control)Panel_INFO).Visible = true;
			((Control)Panel_INFO).BringToFront();
			Label_TOP.Text = "NOUVEAU";
			Label_INDEX.Text = "";
			DateTimePicker_DATE.Text = Conversions.ToString(DateTime.Now.Date);
			ListBox_HEURE.Text = DataGridView1.Rows[((DataGridViewBand)DataGridView1.CurrentRow).Index].Cells[0].Value.ToString();
			Text_CLIENT.Text = "";
			Text_TELEPHONE.Text = "";
			Text_NOTE.Text = "";
			ListBox_VENDEURS.ClearSelected();
			string text = Conversions.ToString(DataGridView1.CurrentCell.ColumnIndex);
			string text2 = Conversions.ToString(DataGridView1.Rows[((DataGridViewBand)DataGridView1.CurrentRow).Index].Cells[0].Value);
			DateTimePicker_DATE.Text = Conversions.ToString(DataGridView1.CurrentCell.ColumnIndex) + "/" + Label_MOIS.Text + "/" + TextBox_ANNEE.Text;
			ListBox_HEURE.Text = text2;
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
				Bitmap val = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, (PixelFormat)2498570);
				Graphics val2 = Graphics.FromImage((Image)(object)val);
				val2.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, (CopyPixelOperation)13369376);
				((Image)val).Save(Application.StartupPath + "\\tchak\\" + text3 + ".snidb", ImageFormat.Jpeg);
				val = null;
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

	private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
	}

	private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected Obj, but got Unknown
		if (e.ColumnIndex == 0)
		{
			return;
		}
		if (Operators.ConditionalCompareObjectEqual(DataGridView1.Rows[DataGridView1.CurrentCell.RowIndex].Cells[DataGridView1.CurrentCell.ColumnIndex].Value, null, TextCompare: false))
		{
			((Control)Panel_DETAILS).Visible = false;
			return;
		}
		((Control)Panel_DETAILS).Visible = true;
		string[] array = DataGridView1.Rows[DataGridView1.CurrentCell.RowIndex].Cells[DataGridView1.CurrentCell.ColumnIndex].Tag.ToString().Split(new char[1] { '_' });
		MySqlCommand val = new MySqlCommand();
		val.CommandText = "SELECT       id,dates,heure,client,TELEPHONE,NOTES       From TABLE_CLIENTS_RDV   where   Dates   =   ' " + Strings.Format(Conversions.ToDate(array[0]), "yyyy-MM-dd") + " '      and      HEURE = '" + array[1] + "'        ";
		val.Connection = Module1.cn_SQL;
		val.CommandType = CommandType.Text;
		if (Module1.cn_SQL.State != ConnectionState.Open)
		{
			Module1.cn_SQL.Open();
		}
		MySqlDataReader val2 = val.ExecuteReader();
		if (val2.HasRows)
		{
			DataGridView3.Rows.Clear();
			while (val2.Read())
			{
				DataGridView3.Rows.Add(new object[6]
				{
					val2["id"].ToString(),
					val2["client"].ToString(),
					val2["dates"].ToString(),
					val2["heure"].ToString(),
					val2["TELEPHONE"].ToString(),
					val2["NOTES"].ToString()
				});
			}
		}
		val2.Close();
		Module1.cn_SQL.Close();
		Label18.Text = "";
		Label20.Text = "";
		Label19.Text = "";
		Label24.Text = "";
		DataGridView3_Click(RuntimeHelpers.GetObjectValue(sender), (EventArgs)(object)e);
	}

	private void DataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
	{
	}

	private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected Obj, but got Unknown
		try
		{
			if (e.ColumnIndex != 0)
			{
				((Control)Panel_DETAILS).Visible = false;
				Button_ADD_Click(RuntimeHelpers.GetObjectValue(sender), (EventArgs)(object)e);
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

	private void DataGridView1_DoubleClick(object sender, EventArgs e)
	{
	}

	private void Button12_Click(object sender, EventArgs e)
	{
		//IL_04e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ea: Expected Obj, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected Obj, but got Unknown
		//IL_0386: Unknown result type (might be due to invalid IL or missing references)
		//IL_038c: Expected Obj, but got Unknown
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Expected Obj, but got Unknown
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected Obj, but got Unknown
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			try
			{
				if (Operators.CompareString(Text_CLIENT.Text, "", TextCompare: false) == 0)
				{
					MessageBox.Show("Veuillez remplir le champ -CLIENT- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
				if (Operators.CompareString(Label_TOP.Text, "NOUVEAU", TextCompare: false) == 0)
				{
					MySqlCommand val = new MySqlCommand();
					val.CommandText = "SELECT MAX(ID) From TABLE_CLIENTS_RDV ";
					val.Connection = Module1.cn_SQL;
					val.CommandType = CommandType.Text;
					if (Module1.cn_SQL.State != ConnectionState.Open)
					{
						Module1.cn_SQL.Open();
					}
					int num = ((val.ExecuteScalar() == DBNull.Value) ? 1 : ((int)Math.Round(Conversions.ToDouble(val.ExecuteScalar()) + 1.0)));
					Module1.cn_SQL.Close();
					MySqlCommand val2 = new MySqlCommand();
					if (Module1.cn_SQL.State != ConnectionState.Open)
					{
						Module1.cn_SQL.Open();
					}
					val2.CommandText = "INSERT INTO   TABLE_CLIENTS_RDV  (ID, DATES,HEURE,CLIENT,TELEPHONE,NOTES) VALUES('" + Conversions.ToString(num) + "' ,'" + DateTimePicker_DATE.Text + "','" + ListBox_HEURE.Text + "','" + Text_CLIENT.Text + "','" + Text_TELEPHONE.Text + "','" + Text_NOTE.Text + "'     )      ";
					val2.Connection = Module1.cn_SQL;
					val2.CommandType = CommandType.Text;
					val2.ExecuteNonQuery();
					Module1.cn_SQL.Close();
					MessageBox.Show("Enregistré avec succès", "ok", (MessageBoxButtons)0, (MessageBoxIcon)64, (MessageBoxDefaultButton)0);
				}
				else if (Operators.CompareString(Label_TOP.Text, "MODIFICATION", TextCompare: false) == 0)
				{
					MySqlCommand val3 = new MySqlCommand();
					if (Module1.cn_SQL.State != ConnectionState.Open)
					{
						Module1.cn_SQL.Open();
					}
					val3.CommandText = "UPDATE     TABLE_CLIENTS_RDV  set   DATES='" + DateTimePicker_DATE.Text + "',HEURE='" + ListBox_HEURE.Text + "',CLIENT='" + Text_CLIENT.Text + "',TELEPHONE='" + Text_TELEPHONE.Text + "',NOTES='" + Text_NOTE.Text + "'    where    ID =  " + Label_INDEX.Text + "        ";
					val3.Connection = Module1.cn_SQL;
					val3.CommandType = CommandType.Text;
					val3.ExecuteNonQuery();
					Module1.cn_SQL.Close();
					MessageBox.Show("Modifié avec succès", "ok", (MessageBoxButtons)0, (MessageBoxIcon)64, (MessageBoxDefaultButton)0);
				}
				((Control)Panel_INFO).Hide();
				RadioButton val4 = (RadioButton)TableLayoutPanel1.Controls["Radio_MOIS_" + Label_MOIS.Text];
				val4.PerformClick();
				int num2 = Conversions.ToInteger(DateTime.Now.Date.ToString("dd"));
				if ((num2 >= 1) & (num2 <= 7))
				{
					RadioButton1.PerformClick();
				}
				else if ((num2 >= 8) & (num2 <= 15))
				{
					RadioButton2.PerformClick();
				}
				else if ((num2 >= 16) & (num2 <= 23))
				{
					RadioButton3.PerformClick();
				}
				else if ((num2 >= 24) & (num2 <= _nbr_jours))
				{
					RadioButton4.PerformClick();
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
					Bitmap val5 = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, (PixelFormat)2498570);
					Graphics val6 = Graphics.FromImage((Image)(object)val5);
					val6.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, (CopyPixelOperation)13369376);
					((Image)val5).Save(Application.StartupPath + "\\tchak\\" + text + ".snidb", ImageFormat.Jpeg);
					val5 = null;
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

	private void Button11_Click(object sender, EventArgs e)
	{
		((Control)Panel_INFO).Hide();
	}

	private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (e.KeyChar == '\'')
		{
			e.Handled = true;
		}
	}

	private void TextBox5_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (e.KeyChar == '\'')
		{
			e.Handled = true;
		}
	}

	private void TextBox8_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (e.KeyChar == '\'')
		{
			e.Handled = true;
		}
	}

	private void TextBox6_KeyPress(object sender, KeyPressEventArgs e)
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

	private void Form_5_CLIENTS_RDV_Resize(object sender, EventArgs e)
	{
		checked
		{
			((Control)Panel_INFO).Left = (int)Math.Round((double)((Control)this).Width / 2.0 - (double)((Control)Panel_INFO).Width / 2.0);
			((Control)Panel_INFO).Top = (int)Math.Round((double)((Control)this).Height / 2.0 - (double)((Control)Panel_INFO).Height / 2.0);
		}
	}

	private void Button_SUPPRESSION_ALL_Click(object sender, EventArgs e)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Invalid comparison between Unknown and I4
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected Obj, but got Unknown
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected Obj, but got Unknown
		if ((int)MessageBox.Show("Voulez-vous vraiment supprimer ??", "Suppression", (MessageBoxButtons)1, (MessageBoxIcon)32, (MessageBoxDefaultButton)0) == 1)
		{
			MySqlCommand val = new MySqlCommand();
			if (Module1.cn_SQL.State != ConnectionState.Open)
			{
				Module1.cn_SQL.Open();
			}
			val.CommandText = "Delete  *  from TABLE_CLIENTS_RDV      where    ID =  " + Label_INDEX.Text + "        ";
			val.Connection = Module1.cn_SQL;
			val.CommandType = CommandType.Text;
			val.ExecuteNonQuery();
			Module1.cn_SQL.Close();
			((Control)Panel_INFO).Hide();
			RadioButton val2 = (RadioButton)TableLayoutPanel1.Controls["Radio_MOIS_" + Label_MOIS.Text];
			val2.PerformClick();
			int num = Conversions.ToInteger(DateTime.Now.Date.ToString("dd"));
			if ((num >= 1) & (num <= 7))
			{
				RadioButton1.PerformClick();
			}
			else if ((num >= 8) & (num <= 15))
			{
				RadioButton2.PerformClick();
			}
			else if ((num >= 16) & (num <= 23))
			{
				RadioButton3.PerformClick();
			}
			else if ((num >= 24) & (num <= _nbr_jours))
			{
				RadioButton4.PerformClick();
			}
		}
	}

	private void Radio_MOIS_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void Radio_MOIS_Click(object sender, EventArgs e)
	{
		//IL_0447: Unknown result type (might be due to invalid IL or missing references)
		//IL_0451: Expected Obj, but got Unknown
		((Control)TableLayoutPanel2).Left = Conversions.ToInteger(Operators.AddObject(NewLateBinding.LateGet(sender, null, "left", new object[0], null, null, null), 4));
		Label_MOIS.Text = Conversions.ToString(NewLateBinding.LateGet(sender, null, "tag", new object[0], null, null, null));
		DateTime t = Conversions.ToDate(Conversions.ToDate(Text_HEURE_DEPART.Text).ToString("HH:mm"));
		int num = Conversions.ToInteger(Text_INTERVALE.Text);
		DataGridView1.Rows.Clear();
		while (DateTime.Compare(t, Conversions.ToDate("23:00")) < 0)
		{
			DataGridView1.Rows.Add(new object[1] { t.ToString("HH:mm") });
			t = Conversions.ToDate(t.AddMinutes(num).ToString("HH:mm"));
		}
		DataGridView1.Rows.Add(new object[1] { t.ToString("HH:mm") });
		int num2 = Conversions.ToInteger(Label_MOIS.Text);
		string value = num2.ToString("00");
		string text = TextBox_ANNEE.Text;
		value = Conversions.ToString(Conversions.ToDouble(value) + 1.0);
		if (Conversions.ToDouble(value) == 13.0)
		{
			value = Conversions.ToString(1);
			text = Conversions.ToString(Conversions.ToDouble(text) + 1.0);
		}
		DateTime dateTime = Conversions.ToDate("01/" + value + "/" + text);
		DateTime dateTime2 = DateAndTime.DateAdd("d", -1.0, dateTime);
		_nbr_jours = Conversions.ToInteger(dateTime2.ToString("dd"));
		checked
		{
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
				DataGridView1.Columns[num4].Visible = false;
				num4++;
			}
			int nbr_jours = _nbr_jours;
			int num7 = 0;
			while (true)
			{
				int num8 = num7;
				int num6 = nbr_jours;
				if (num8 > num6)
				{
					break;
				}
				DataGridView1.Columns[num7].Visible = true;
				num7++;
			}
			int num9 = ((BaseCollection)DataGridView1.Columns).Count - 1;
			int num10 = 1;
			while (true)
			{
				int num11 = num10;
				int num6 = num9;
				if (num11 > num6)
				{
					break;
				}
				string value2 = Conversions.ToString(((DataGridViewBand)DataGridView1.Columns[num10]).Index) + "/" + Conversions.ToString(num2) + "/" + dateTime2.ToString("yyy");
				if (DataGridView1.Columns[num10].Visible)
				{
					DataGridView1.Columns[num10].HeaderText = num10.ToString("00") + "\r\n" + Conversions.ToDate(value2).ToString("ddd");
					((DataGridViewCell)DataGridView1.Columns[num10].HeaderCell).Style.BackColor = Color.FromArgb(247, 248, 250);
				}
				if (DataGridView1.Columns[num10].HeaderText.Contains("dim"))
				{
					((DataGridViewCell)DataGridView1.Columns[num10].HeaderCell).Style.BackColor = Color.LightGreen;
				}
				num10++;
			}
			DT.Clear();
			DA = new MySqlDataAdapter("select * from   TABLE_CLIENTS_RDV     Where      (MONTH(Dates) = " + Label_MOIS.Text + " )     and              (year(Dates) = " + TextBox_ANNEE.Text + " )          order by ID desc ", Module1.cn_SQL);
			((DbDataAdapter)(object)DA).Fill(DT);
			DataGridView2.DataSource = DT;
			int num12 = DataGridView2.Rows.Count - 1;
			int num13 = 0;
			while (true)
			{
				int num14 = num13;
				int num6 = num12;
				if (num14 > num6)
				{
					break;
				}
				int num15 = Conversions.ToInteger(Conversions.ToDate(DataGridView2.Rows[num13].Cells[1].Value).ToString("dd"));
				int num16 = 0;
				int num17 = DataGridView1.Rows.Count - 1;
				int num18 = 0;
				while (true)
				{
					int num19 = num18;
					num6 = num17;
					if (num19 > num6)
					{
						break;
					}
					if (Operators.ConditionalCompareObjectEqual(DataGridView1.Rows[num18].Cells[0].Value, DataGridView2.Rows[num13].Cells[2].Value.ToString(), TextCompare: false))
					{
						num16 = num18;
						break;
					}
					num18++;
				}
				DataGridView1.Rows[num16].Cells[num15].Tag = Strings.Format(Conversions.ToDate(DataGridView2.Rows[num13].Cells[1].Value), "dd/MM/yyyy") + "_" + DataGridView2.Rows[num13].Cells[2].Value.ToString();
				if (DataGridView1.Rows[num16].Cells[num15].Value == DBNull.Value)
				{
					DataGridView1.Rows[num16].Cells[num15].Value = 1;
				}
				else
				{
					DataGridViewCell val = DataGridView1.Rows[num16].Cells[num15];
					val.Value = Operators.AddObject(val.Value, 1);
				}
				DataGridView1.Rows[num16].Cells[num15].Style.BackColor = Color.FromArgb(255, 128, 128);
				num13++;
			}
			DataGridView1.CurrentCell = DataGridView1.Rows[0].Cells[1];
			DataGridView1.Rows[0].Selected = true;
			Button_CALC_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}
	}

	private void TextBox_ANNEE_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (((Operators.CompareString(Conversions.ToString(e.KeyChar), "0", TextCompare: false) < 0) | (Operators.CompareString(Conversions.ToString(e.KeyChar), "9", TextCompare: false) > 0)) & (e.KeyChar != '\b') & (e.KeyChar != '.') & (e.KeyChar != '-'))
		{
			e.Handled = true;
		}
	}

	private void TextBox_ANNEE_TextChanged(object sender, EventArgs e)
	{
	}

	private void Label10_Click(object sender, EventArgs e)
	{
		TextBox_ANNEE.Text = Conversions.ToString(Conversion.Val(TextBox_ANNEE.Text) + 1.0);
	}

	private void Label11_Click(object sender, EventArgs e)
	{
		TextBox_ANNEE.Text = Conversions.ToString(Conversion.Val(TextBox_ANNEE.Text) - 1.0);
	}

	private void DataGridView1_MouseEnter(object sender, EventArgs e)
	{
	}

	private void Button_CALC_Click(object sender, EventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected Obj, but got Unknown
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Expected Obj, but got Unknown
		try
		{
			DataTable dataTable = new DataTable();
			MySqlDataAdapter val = new MySqlDataAdapter();
			dataTable.Clear();
			dataTable = new DataTable();
			val = new MySqlDataAdapter(" (SELECT count(ID)   as N  From TABLE_CLIENTS_RDV   where     Dates = ' " + Strings.Format(DateTime.Now.Date, "yyyy-MM-dd") + " '        )       UNION ALL         (SELECT count(ID)   as N  From TABLE_CLIENTS_RDV   where     Dates = ' " + Strings.Format(DateTime.Now.Date.AddDays(1.0), "yyyy-MM-dd") + " '     )      UNION ALL           (SELECT count(ID)   as N  From TABLE_CLIENTS_RDV   where    (MONTH(Dates) = " + Label_MOIS.Text + " )     and      (year(Dates) = " + TextBox_ANNEE.Text + " )      )        ", Module1.cn_SQL);
			((DbDataAdapter)(object)val).Fill(dataTable);
			if (dataTable.Rows[0]["N"] == DBNull.Value)
			{
				Label_AUJOURDHUI.Text = "";
			}
			else
			{
				Label_AUJOURDHUI.Text = Conversions.ToString(dataTable.Rows[0]["N"]);
			}
			if (dataTable.Rows[1]["N"] == DBNull.Value)
			{
				Label_DEMAIN.Text = "";
			}
			else
			{
				Label_DEMAIN.Text = Conversions.ToString(dataTable.Rows[1]["N"]);
			}
			if (dataTable.Rows[2]["N"] == DBNull.Value)
			{
				Label_CEMOIS.Text = "";
			}
			else
			{
				Label_CEMOIS.Text = Conversions.ToString(dataTable.Rows[2]["N"]);
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

	private void Button_EDIT_Click(object sender, EventArgs e)
	{
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Expected Obj, but got Unknown
		try
		{
			((Control)Panel_DETAILS).Visible = false;
			((Control)Panel_INFO).Visible = true;
			((Control)Panel_INFO).BringToFront();
			Label_INDEX.Text = DataGridView3.Rows[((DataGridViewBand)DataGridView3.CurrentRow).Index].Cells["ID"].Value.ToString();
			Label_TOP.Text = "MODIFICATION";
			DateTimePicker_DATE.Value = Conversions.ToDate(Label18.Text);
			ListBox_HEURE.Text = Label20.Text;
			Text_CLIENT.Text = Label19.Text;
			Text_TELEPHONE.Text = Label24.Text;
			Text_NOTE.Text = Label33.Text;
			ListBox_VENDEURS.ClearSelected();
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

	private void RadioButton1_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void RadioButton1_Click(object sender, EventArgs e)
	{
		checked
		{
			int num = ((BaseCollection)DataGridView1.Columns).Count - 1;
			int num2 = 1;
			int num4;
			while (true)
			{
				int num3 = num2;
				num4 = num;
				if (num3 > num4)
				{
					break;
				}
				DataGridView1.Columns[num2].Visible = false;
				num2++;
			}
			int num5 = 1;
			int num6;
			do
			{
				DataGridView1.Columns[num5].Visible = true;
				num5++;
				num6 = num5;
				num4 = 7;
			}
			while (num6 <= num4);
			DataGridView1.CurrentCell = DataGridView1.Rows[0].Cells[1];
			DataGridView1.Rows[0].Selected = true;
		}
	}

	private void RadioButton2_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void RadioButton2_Click(object sender, EventArgs e)
	{
		checked
		{
			int num = ((BaseCollection)DataGridView1.Columns).Count - 1;
			int num2 = 1;
			int num4;
			while (true)
			{
				int num3 = num2;
				num4 = num;
				if (num3 > num4)
				{
					break;
				}
				DataGridView1.Columns[num2].Visible = false;
				num2++;
			}
			int num5 = 8;
			int num6;
			do
			{
				DataGridView1.Columns[num5].Visible = true;
				num5++;
				num6 = num5;
				num4 = 15;
			}
			while (num6 <= num4);
			DataGridView1.CurrentCell = DataGridView1.Rows[0].Cells[8];
			DataGridView1.Rows[0].Selected = true;
		}
	}

	private void RadioButton3_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void RadioButton3_Click(object sender, EventArgs e)
	{
		checked
		{
			int num = ((BaseCollection)DataGridView1.Columns).Count - 1;
			int num2 = 1;
			int num4;
			while (true)
			{
				int num3 = num2;
				num4 = num;
				if (num3 > num4)
				{
					break;
				}
				DataGridView1.Columns[num2].Visible = false;
				num2++;
			}
			int num5 = 16;
			int num6;
			do
			{
				DataGridView1.Columns[num5].Visible = true;
				num5++;
				num6 = num5;
				num4 = 23;
			}
			while (num6 <= num4);
			DataGridView1.CurrentCell = DataGridView1.Rows[0].Cells[16];
			DataGridView1.Rows[0].Selected = true;
		}
	}

	private void RadioButton4_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void RadioButton4_Click(object sender, EventArgs e)
	{
		checked
		{
			int num = ((BaseCollection)DataGridView1.Columns).Count - 1;
			int num2 = 1;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				DataGridView1.Columns[num2].Visible = false;
				num2++;
			}
			int nbr_jours = _nbr_jours;
			int num5 = 24;
			while (true)
			{
				int num6 = num5;
				int num4 = nbr_jours;
				if (num6 > num4)
				{
					break;
				}
				DataGridView1.Columns[num5].Visible = true;
				num5++;
			}
			DataGridView1.CurrentCell = DataGridView1.Rows[0].Cells[24];
			DataGridView1.Rows[0].Selected = true;
		}
	}

	private void Button2_Click_1(object sender, EventArgs e)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		MyProject.Forms.Form_5_CLIENTS_LISTE.Label1.Text = ((Control)this).Name;
		((Form)MyProject.Forms.Form_5_CLIENTS_LISTE).ShowDialog();
	}

	private void Button5_Click(object sender, EventArgs e)
	{
		DateTimePicker_DATE.Value = DateTimePicker_DATE.Value.AddDays(-1.0);
	}

	private void Button20_Click(object sender, EventArgs e)
	{
		DateTimePicker_DATE.Value = DateTimePicker_DATE.Value.AddDays(1.0);
	}

	private void ListBox_VENDEURS_DoubleClick(object sender, EventArgs e)
	{
		if (Operators.CompareString(Text_NOTE.Text, "", TextCompare: false) == 0)
		{
			Text_NOTE.Text = ListBox_VENDEURS.Text + "\r\n";
		}
		else
		{
			Text_NOTE.Text = Text_NOTE.Text + "\r\n" + ListBox_VENDEURS.Text;
		}
	}

	private void ListBox_VENDEURS_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	private void DataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
	}

	private void DataGridView3_Click(object sender, EventArgs e)
	{
		Label18.Text = Conversions.ToDate(DataGridView3.Rows[((DataGridViewBand)DataGridView3.CurrentRow).Index].Cells["DATES"].Value.ToString()).ToString("dd/MM/yyy");
		Label20.Text = DataGridView3.Rows[((DataGridViewBand)DataGridView3.CurrentRow).Index].Cells["HEURE"].Value.ToString();
		Label19.Text = DataGridView3.Rows[((DataGridViewBand)DataGridView3.CurrentRow).Index].Cells["CLIENT"].Value.ToString();
		Label24.Text = DataGridView3.Rows[((DataGridViewBand)DataGridView3.CurrentRow).Index].Cells["TELEPHONE"].Value.ToString();
		Label33.Text = DataGridView3.Rows[((DataGridViewBand)DataGridView3.CurrentRow).Index].Cells["NOTES"].Value.ToString();
	}

	private void Button244_Click(object sender, EventArgs e)
	{
		((Control)Panel_DETAILS).Hide();
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Invalid comparison between Unknown and I4
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected Obj, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected Obj, but got Unknown
		if ((int)MessageBox.Show("Voulez-vous vraiment supprimer ??", "Suppression", (MessageBoxButtons)1, (MessageBoxIcon)32, (MessageBoxDefaultButton)0) == 1)
		{
			MySqlCommand val = new MySqlCommand();
			if (Module1.cn_SQL.State != ConnectionState.Open)
			{
				Module1.cn_SQL.Open();
			}
			val.CommandText = "Delete    from TABLE_CLIENTS_RDV      where    ID =  " + DataGridView3.Rows[((DataGridViewBand)DataGridView3.CurrentRow).Index].Cells["ID"].Value.ToString() + "        ";
			val.Connection = Module1.cn_SQL;
			val.CommandType = CommandType.Text;
			val.ExecuteNonQuery();
			Module1.cn_SQL.Close();
			((Control)Panel_INFO).Hide();
			RadioButton val2 = (RadioButton)TableLayoutPanel1.Controls["Radio_MOIS_" + Label_MOIS.Text];
			val2.PerformClick();
			int num = Conversions.ToInteger(DateTime.Now.Date.ToString("dd"));
			if ((num >= 1) & (num <= 7))
			{
				RadioButton1.PerformClick();
			}
			else if ((num >= 8) & (num <= 15))
			{
				RadioButton2.PerformClick();
			}
			else if ((num >= 16) & (num <= 23))
			{
				RadioButton3.PerformClick();
			}
			else if ((num >= 24) & (num <= _nbr_jours))
			{
				RadioButton4.PerformClick();
			}
			((Control)Panel_DETAILS).Visible = false;
		}
	}

	private void Button3_Click(object sender, EventArgs e)
	{
		Button_ADD.PerformClick();
		((Control)Panel_DETAILS).Visible = false;
	}

	private void Label_AUJOURDHUI_Click(object sender, EventArgs e)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		RadioButton val = (RadioButton)TableLayoutPanel1.Controls["Radio_MOIS_" + Conversions.ToString(DateAndTime.Month(DateAndTime.Now))];
		val.PerformClick();
		int num = Conversions.ToInteger(DateTime.Now.Date.ToString("dd"));
		checked
		{
			int num2 = ((BaseCollection)DataGridView1.Columns).Count - 1;
			int num3 = 1;
			while (true)
			{
				int num4 = num3;
				int num5 = num2;
				if (num4 > num5)
				{
					break;
				}
				DataGridView1.Columns[num3].Visible = false;
				num3++;
			}
			DataGridView1.Columns[num].Visible = true;
		}
	}

	private void Label21_Click(object sender, EventArgs e)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		RadioButton val = (RadioButton)TableLayoutPanel1.Controls["Radio_MOIS_" + Conversions.ToString(DateAndTime.Month(DateAndTime.Now))];
		val.PerformClick();
		int num = Conversions.ToInteger(DateTime.Now.Date.ToString("dd"));
		checked
		{
			int num2 = ((BaseCollection)DataGridView1.Columns).Count - 1;
			int num3 = 1;
			while (true)
			{
				int num4 = num3;
				int num5 = num2;
				if (num4 > num5)
				{
					break;
				}
				DataGridView1.Columns[num3].Visible = false;
				num3++;
			}
			DataGridView1.Columns[num].Visible = true;
		}
	}
}
