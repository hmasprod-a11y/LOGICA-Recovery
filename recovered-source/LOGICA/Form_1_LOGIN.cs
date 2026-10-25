using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using LOGICA.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using MySql.Data.MySqlClient;

namespace LOGICA;

[DesignerGenerated]
public class Form_1_LOGIN : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("LinkLabel1")]
	private LinkLabel _LinkLabel1;

	[AccessedThroughProperty("PictureBox_QUITTER")]
	private PictureBox _PictureBox_QUITTER;

	[AccessedThroughProperty("Panel_menu")]
	private Panel _Panel_menu;

	[AccessedThroughProperty("PictureBox13")]
	private PictureBox _PictureBox13;

	[AccessedThroughProperty("PictureBox12")]
	private PictureBox _PictureBox12;

	[AccessedThroughProperty("Panel_login")]
	private Panel _Panel_login;

	[AccessedThroughProperty("Panel5")]
	private Panel _Panel5;

	[AccessedThroughProperty("Text_NUM")]
	private TextBox _Text_NUM;

	[AccessedThroughProperty("PictureBox8")]
	private PictureBox _PictureBox8;

	[AccessedThroughProperty("PictureBox10")]
	private PictureBox _PictureBox10;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	[AccessedThroughProperty("Label_erreur")]
	private Label _Label_erreur;

	[AccessedThroughProperty("XdxToolStripMenuItem")]
	private ToolStripMenuItem _XdxToolStripMenuItem;

	[AccessedThroughProperty("CheckBox1")]
	private CheckBox _CheckBox1;

	[AccessedThroughProperty("Panel")]
	private Panel _Panel;

	[AccessedThroughProperty("TableLayoutPanel1")]
	private TableLayoutPanel _TableLayoutPanel1;

	[AccessedThroughProperty("TextBox_ORGANISME")]
	private TextBox _TextBox_ORGANISME;

	[AccessedThroughProperty("Panel3")]
	private Panel _Panel3;

	[AccessedThroughProperty("Button_JOURNAL")]
	private Button _Button_JOURNAL;

	[AccessedThroughProperty("Button_PARAMETRES")]
	private Button _Button_PARAMETRES;

	[AccessedThroughProperty("Button_VENTE")]
	private Button _Button_VENTE;

	[AccessedThroughProperty("Button_STOCK")]
	private Button _Button_STOCK;

	[AccessedThroughProperty("Button_GESTION")]
	private Button _Button_GESTION;

	[AccessedThroughProperty("Button_STATISTIQUES")]
	private Button _Button_STATISTIQUES;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("PictureBox2")]
	private PictureBox _PictureBox2;

	[AccessedThroughProperty("Panel_CLAVIER")]
	private Panel _Panel_CLAVIER;

	[AccessedThroughProperty("Butt_7")]
	private Button_MBGlassButton _Butt_7;

	[AccessedThroughProperty("Butt_BACK")]
	private Button_MBGlassButton _Butt_BACK;

	[AccessedThroughProperty("Butt_DOT")]
	private Button_MBGlassButton _Butt_DOT;

	[AccessedThroughProperty("Butt_DRAFT")]
	private Button_MBGlassButton _Butt_DRAFT;

	[AccessedThroughProperty("Butt_0")]
	private Button_MBGlassButton _Butt_0;

	[AccessedThroughProperty("Butt_ok")]
	private Button_MBGlassButton _Butt_ok;

	[AccessedThroughProperty("Butt_00")]
	private Button_MBGlassButton _Butt_00;

	[AccessedThroughProperty("Butt_9")]
	private Button_MBGlassButton _Butt_9;

	[AccessedThroughProperty("Butt_1")]
	private Button_MBGlassButton _Butt_1;

	[AccessedThroughProperty("Butt_8")]
	private Button_MBGlassButton _Butt_8;

	[AccessedThroughProperty("Butt_2")]
	private Button_MBGlassButton _Butt_2;

	[AccessedThroughProperty("Butt_3")]
	private Button_MBGlassButton _Butt_3;

	[AccessedThroughProperty("Butt_6")]
	private Button_MBGlassButton _Butt_6;

	[AccessedThroughProperty("Butt_4")]
	private Button_MBGlassButton _Butt_4;

	[AccessedThroughProperty("Butt_5")]
	private Button_MBGlassButton _Butt_5;

	[AccessedThroughProperty("PictureBox3")]
	private PictureBox _PictureBox3;

	[AccessedThroughProperty("MbGlassButton1")]
	private Button_MBGlassButton _MbGlassButton1;

	[AccessedThroughProperty("Text_LICENCE_DATE")]
	private TextBox _Text_LICENCE_DATE;

	[AccessedThroughProperty("PictureBox100")]
	private PictureBox _PictureBox100;

	internal virtual LinkLabel LinkLabel1
	{
		[DebuggerNonUserCode]
		get
		{
			return _LinkLabel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			LinkLabelLinkClickedEventHandler val = LinkLabel1_LinkClicked;
			if (_LinkLabel1 != null)
			{
				_LinkLabel1.LinkClicked -= val;
			}
			_LinkLabel1 = value;
			if (_LinkLabel1 != null)
			{
				_LinkLabel1.LinkClicked += val;
			}
		}
	}

	internal virtual PictureBox PictureBox_QUITTER
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox_QUITTER;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = PictureBox_QUITTER_Click;
			if (_PictureBox_QUITTER != null)
			{
				((Control)_PictureBox_QUITTER).Click -= eventHandler;
			}
			_PictureBox_QUITTER = value;
			if (_PictureBox_QUITTER != null)
			{
				((Control)_PictureBox_QUITTER).Click += eventHandler;
			}
		}
	}

	internal virtual Panel Panel_menu
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel_menu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel_menu = value;
		}
	}

	internal virtual PictureBox PictureBox13
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox13 = value;
		}
	}

	internal virtual PictureBox PictureBox12
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = PictureBox12_Click;
			if (_PictureBox12 != null)
			{
				((Control)_PictureBox12).Click -= eventHandler;
			}
			_PictureBox12 = value;
			if (_PictureBox12 != null)
			{
				((Control)_PictureBox12).Click += eventHandler;
			}
		}
	}

	internal virtual Panel Panel_login
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel_login;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel_login = value;
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

	internal virtual TextBox Text_NUM
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_NUM;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected Obj, but got Unknown
			EventHandler eventHandler = Text_NUM_Enter;
			KeyPressEventHandler val = Text_NUM_KeyPress;
			KeyEventHandler val2 = Text_NUM_KeyDown;
			if (_Text_NUM != null)
			{
				((Control)_Text_NUM).Enter -= eventHandler;
				((Control)_Text_NUM).KeyPress -= val;
				((Control)_Text_NUM).KeyDown -= val2;
			}
			_Text_NUM = value;
			if (_Text_NUM != null)
			{
				((Control)_Text_NUM).Enter += eventHandler;
				((Control)_Text_NUM).KeyPress += val;
				((Control)_Text_NUM).KeyDown += val2;
			}
		}
	}

	internal virtual PictureBox PictureBox8
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox8 = value;
		}
	}

	internal virtual PictureBox PictureBox10
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox10 = value;
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
			EventHandler eventHandler = PictureBox1_Click;
			if (_PictureBox1 != null)
			{
				((Control)_PictureBox1).Click -= eventHandler;
			}
			_PictureBox1 = value;
			if (_PictureBox1 != null)
			{
				((Control)_PictureBox1).Click += eventHandler;
			}
		}
	}

	internal virtual Label Label_erreur
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_erreur;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_erreur = value;
		}
	}

	internal virtual ToolStripMenuItem XdxToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _XdxToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XdxToolStripMenuItem = value;
		}
	}

	internal virtual CheckBox CheckBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _CheckBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = CheckBox1_CheckedChanged;
			if (_CheckBox1 != null)
			{
				_CheckBox1.CheckedChanged -= eventHandler;
			}
			_CheckBox1 = value;
			if (_CheckBox1 != null)
			{
				_CheckBox1.CheckedChanged += eventHandler;
			}
		}
	}

	internal virtual Panel Panel
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel = value;
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

	internal virtual TextBox TextBox_ORGANISME
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox_ORGANISME;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBox_ORGANISME = value;
		}
	}

	internal virtual Panel Panel3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel3 = value;
		}
	}

	internal virtual Button Button_JOURNAL
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_JOURNAL;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_MouseLeave;
			EventHandler eventHandler2 = Button_MouseHover;
			EventHandler eventHandler3 = Button_JOURNAL_Click;
			if (_Button_JOURNAL != null)
			{
				((Control)_Button_JOURNAL).MouseLeave -= eventHandler;
				((Control)_Button_JOURNAL).MouseEnter -= eventHandler2;
				((Control)_Button_JOURNAL).Click -= eventHandler3;
			}
			_Button_JOURNAL = value;
			if (_Button_JOURNAL != null)
			{
				((Control)_Button_JOURNAL).MouseLeave += eventHandler;
				((Control)_Button_JOURNAL).MouseEnter += eventHandler2;
				((Control)_Button_JOURNAL).Click += eventHandler3;
			}
		}
	}

	internal virtual Button Button_PARAMETRES
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_PARAMETRES;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_MouseLeave;
			EventHandler eventHandler2 = Button_MouseHover;
			EventHandler eventHandler3 = Button_PARAMETRES_Click;
			if (_Button_PARAMETRES != null)
			{
				((Control)_Button_PARAMETRES).MouseLeave -= eventHandler;
				((Control)_Button_PARAMETRES).MouseEnter -= eventHandler2;
				((Control)_Button_PARAMETRES).Click -= eventHandler3;
			}
			_Button_PARAMETRES = value;
			if (_Button_PARAMETRES != null)
			{
				((Control)_Button_PARAMETRES).MouseLeave += eventHandler;
				((Control)_Button_PARAMETRES).MouseEnter += eventHandler2;
				((Control)_Button_PARAMETRES).Click += eventHandler3;
			}
		}
	}

	internal virtual Button Button_VENTE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_VENTE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_MouseLeave;
			EventHandler eventHandler2 = Button_VENTE_Click;
			EventHandler eventHandler3 = Button_MouseHover;
			if (_Button_VENTE != null)
			{
				((Control)_Button_VENTE).MouseLeave -= eventHandler;
				((Control)_Button_VENTE).Click -= eventHandler2;
				((Control)_Button_VENTE).MouseEnter -= eventHandler3;
			}
			_Button_VENTE = value;
			if (_Button_VENTE != null)
			{
				((Control)_Button_VENTE).MouseLeave += eventHandler;
				((Control)_Button_VENTE).Click += eventHandler2;
				((Control)_Button_VENTE).MouseEnter += eventHandler3;
			}
		}
	}

	internal virtual Button Button_STOCK
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_STOCK;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_MouseLeave;
			EventHandler eventHandler2 = Button_MouseHover;
			EventHandler eventHandler3 = Button_STOCK_Click;
			if (_Button_STOCK != null)
			{
				((Control)_Button_STOCK).MouseLeave -= eventHandler;
				((Control)_Button_STOCK).MouseEnter -= eventHandler2;
				((Control)_Button_STOCK).Click -= eventHandler3;
			}
			_Button_STOCK = value;
			if (_Button_STOCK != null)
			{
				((Control)_Button_STOCK).MouseLeave += eventHandler;
				((Control)_Button_STOCK).MouseEnter += eventHandler2;
				((Control)_Button_STOCK).Click += eventHandler3;
			}
		}
	}

	internal virtual Button Button_GESTION
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_GESTION;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_MouseLeave;
			EventHandler eventHandler2 = Button_MouseHover;
			EventHandler eventHandler3 = Button_GESTION_Click;
			if (_Button_GESTION != null)
			{
				((Control)_Button_GESTION).MouseLeave -= eventHandler;
				((Control)_Button_GESTION).MouseEnter -= eventHandler2;
				((Control)_Button_GESTION).Click -= eventHandler3;
			}
			_Button_GESTION = value;
			if (_Button_GESTION != null)
			{
				((Control)_Button_GESTION).MouseLeave += eventHandler;
				((Control)_Button_GESTION).MouseEnter += eventHandler2;
				((Control)_Button_GESTION).Click += eventHandler3;
			}
		}
	}

	internal virtual Button Button_STATISTIQUES
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_STATISTIQUES;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_MouseLeave;
			EventHandler eventHandler2 = Button_MouseHover;
			EventHandler eventHandler3 = Button_STATISTIQUES_Click;
			if (_Button_STATISTIQUES != null)
			{
				((Control)_Button_STATISTIQUES).MouseLeave -= eventHandler;
				((Control)_Button_STATISTIQUES).MouseEnter -= eventHandler2;
				((Control)_Button_STATISTIQUES).Click -= eventHandler3;
			}
			_Button_STATISTIQUES = value;
			if (_Button_STATISTIQUES != null)
			{
				((Control)_Button_STATISTIQUES).MouseLeave += eventHandler;
				((Control)_Button_STATISTIQUES).MouseEnter += eventHandler2;
				((Control)_Button_STATISTIQUES).Click += eventHandler3;
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

	internal virtual Button_MBGlassButton Butt_7
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

	internal virtual Button_MBGlassButton Butt_BACK
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

	internal virtual Button_MBGlassButton Butt_DOT
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
			EventHandler eventHandler = Butt_DOT_Click;
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

	internal virtual Button_MBGlassButton Butt_DRAFT
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

	internal virtual Button_MBGlassButton Butt_0
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

	internal virtual Button_MBGlassButton Butt_ok
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_ok;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_ok_Click;
			if (_Butt_ok != null)
			{
				((Control)_Butt_ok).Click -= eventHandler;
			}
			_Butt_ok = value;
			if (_Butt_ok != null)
			{
				((Control)_Butt_ok).Click += eventHandler;
			}
		}
	}

	internal virtual Button_MBGlassButton Butt_00
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_00;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click;
			if (_Butt_00 != null)
			{
				((Control)_Butt_00).Click -= eventHandler;
			}
			_Butt_00 = value;
			if (_Butt_00 != null)
			{
				((Control)_Butt_00).Click += eventHandler;
			}
		}
	}

	internal virtual Button_MBGlassButton Butt_9
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

	internal virtual Button_MBGlassButton Butt_1
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

	internal virtual Button_MBGlassButton Butt_8
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

	internal virtual Button_MBGlassButton Butt_2
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

	internal virtual Button_MBGlassButton Butt_3
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

	internal virtual Button_MBGlassButton Butt_6
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

	internal virtual Button_MBGlassButton Butt_4
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

	internal virtual Button_MBGlassButton Butt_5
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

	internal virtual Button_MBGlassButton MbGlassButton1
	{
		[DebuggerNonUserCode]
		get
		{
			return _MbGlassButton1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_MbGlassButton1 = value;
		}
	}

	internal virtual TextBox Text_LICENCE_DATE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_LICENCE_DATE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_LICENCE_DATE = value;
		}
	}

	internal virtual PictureBox PictureBox100
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox100;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox100 = value;
		}
	}

	[DebuggerNonUserCode]
	public Form_1_LOGIN()
	{
		((Control)this).Resize += Form_1_LOGIN_Resize;
		((Control)this).HandleCreated += Form_1_LOGIN_HandleCreated;
		((Form)this).Load += Form_1_LOGIN_Load;
		((Form)this).Shown += Form_login_Shown;
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
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected Obj, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected Obj, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected Obj, but got Unknown
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected Obj, but got Unknown
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected Obj, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected Obj, but got Unknown
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected Obj, but got Unknown
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected Obj, but got Unknown
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Expected Obj, but got Unknown
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected Obj, but got Unknown
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected Obj, but got Unknown
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected Obj, but got Unknown
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected Obj, but got Unknown
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected Obj, but got Unknown
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Expected Obj, but got Unknown
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected Obj, but got Unknown
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected Obj, but got Unknown
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Expected Obj, but got Unknown
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected Obj, but got Unknown
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Expected Obj, but got Unknown
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Expected Obj, but got Unknown
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected Obj, but got Unknown
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Expected Obj, but got Unknown
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Expected Obj, but got Unknown
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Expected Obj, but got Unknown
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Expected Obj, but got Unknown
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Expected Obj, but got Unknown
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Expected Obj, but got Unknown
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Expected Obj, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form_1_LOGIN));
		LinkLabel1 = new LinkLabel();
		Panel_login = new Panel();
		Panel_CLAVIER = new Panel();
		Butt_7 = new Button_MBGlassButton();
		Butt_BACK = new Button_MBGlassButton();
		Butt_DOT = new Button_MBGlassButton();
		Butt_DRAFT = new Button_MBGlassButton();
		Butt_0 = new Button_MBGlassButton();
		Butt_ok = new Button_MBGlassButton();
		Butt_00 = new Button_MBGlassButton();
		Butt_9 = new Button_MBGlassButton();
		Butt_1 = new Button_MBGlassButton();
		Butt_8 = new Button_MBGlassButton();
		Butt_2 = new Button_MBGlassButton();
		Butt_3 = new Button_MBGlassButton();
		Butt_6 = new Button_MBGlassButton();
		Butt_4 = new Button_MBGlassButton();
		Butt_5 = new Button_MBGlassButton();
		Panel5 = new Panel();
		PictureBox3 = new PictureBox();
		Label1 = new Label();
		CheckBox1 = new CheckBox();
		Label_erreur = new Label();
		Text_NUM = new TextBox();
		MbGlassButton1 = new Button_MBGlassButton();
		PictureBox8 = new PictureBox();
		PictureBox10 = new PictureBox();
		PictureBox2 = new PictureBox();
		Panel_menu = new Panel();
		Panel3 = new Panel();
		Button_JOURNAL = new Button();
		Button_PARAMETRES = new Button();
		Button_VENTE = new Button();
		Button_STOCK = new Button();
		Button_GESTION = new Button();
		Button_STATISTIQUES = new Button();
		PictureBox1 = new PictureBox();
		PictureBox13 = new PictureBox();
		XdxToolStripMenuItem = new ToolStripMenuItem();
		Panel = new Panel();
		Text_LICENCE_DATE = new TextBox();
		TextBox_ORGANISME = new TextBox();
		PictureBox12 = new PictureBox();
		PictureBox_QUITTER = new PictureBox();
		TableLayoutPanel1 = new TableLayoutPanel();
		PictureBox100 = new PictureBox();
		((Control)Panel_login).SuspendLayout();
		((Control)Panel_CLAVIER).SuspendLayout();
		((Control)Panel5).SuspendLayout();
		((ISupportInitialize)PictureBox3).BeginInit();
		((ISupportInitialize)PictureBox8).BeginInit();
		((ISupportInitialize)PictureBox10).BeginInit();
		((ISupportInitialize)PictureBox2).BeginInit();
		((Control)Panel_menu).SuspendLayout();
		((Control)Panel3).SuspendLayout();
		((ISupportInitialize)PictureBox1).BeginInit();
		((ISupportInitialize)PictureBox13).BeginInit();
		((Control)Panel).SuspendLayout();
		((ISupportInitialize)PictureBox12).BeginInit();
		((ISupportInitialize)PictureBox_QUITTER).BeginInit();
		((Control)TableLayoutPanel1).SuspendLayout();
		((ISupportInitialize)PictureBox100).BeginInit();
		((Control)this).SuspendLayout();
		componentResourceManager.ApplyResources(LinkLabel1, "LinkLabel1");
		((Control)LinkLabel1).Name = "LinkLabel1";
		LinkLabel1.TabStop = true;
		((Control)Panel_login).Controls.Add((Control)(object)Panel_CLAVIER);
		((Control)Panel_login).Controls.Add((Control)(object)Panel5);
		((Control)Panel_login).Controls.Add((Control)(object)PictureBox8);
		((Control)Panel_login).Controls.Add((Control)(object)PictureBox10);
		((Control)Panel_login).Controls.Add((Control)(object)PictureBox2);
		componentResourceManager.ApplyResources(Panel_login, "Panel_login");
		((Control)Panel_login).Name = "Panel_login";
		((Control)Panel_CLAVIER).Controls.Add((Control)(object)Butt_7);
		((Control)Panel_CLAVIER).Controls.Add((Control)(object)Butt_BACK);
		((Control)Panel_CLAVIER).Controls.Add((Control)(object)Butt_DOT);
		((Control)Panel_CLAVIER).Controls.Add((Control)(object)Butt_DRAFT);
		((Control)Panel_CLAVIER).Controls.Add((Control)(object)Butt_0);
		((Control)Panel_CLAVIER).Controls.Add((Control)(object)Butt_ok);
		((Control)Panel_CLAVIER).Controls.Add((Control)(object)Butt_00);
		((Control)Panel_CLAVIER).Controls.Add((Control)(object)Butt_9);
		((Control)Panel_CLAVIER).Controls.Add((Control)(object)Butt_1);
		((Control)Panel_CLAVIER).Controls.Add((Control)(object)Butt_8);
		((Control)Panel_CLAVIER).Controls.Add((Control)(object)Butt_2);
		((Control)Panel_CLAVIER).Controls.Add((Control)(object)Butt_3);
		((Control)Panel_CLAVIER).Controls.Add((Control)(object)Butt_6);
		((Control)Panel_CLAVIER).Controls.Add((Control)(object)Butt_4);
		((Control)Panel_CLAVIER).Controls.Add((Control)(object)Butt_5);
		componentResourceManager.ApplyResources(Panel_CLAVIER, "Panel_CLAVIER");
		((Control)Panel_CLAVIER).Name = "Panel_CLAVIER";
		((ButtonBase)Butt_7).BackColor = Color.Transparent;
		Butt_7.BaseColor = Color.FromArgb(232, 239, 249);
		Butt_7.BaseStrokeColor = Color.Silver;
		((Control)Butt_7).Cursor = Cursors.Hand;
		((ButtonBase)Butt_7).FlatAppearance.BorderSize = 0;
		componentResourceManager.ApplyResources(Butt_7, "Butt_7");
		Butt_7.GlowingingSpeed = 5;
		Button_MBGlassButton butt_ = Butt_7;
		Size imageSize = new Size(24, 24);
		butt_.ImageSize = imageSize;
		Button_MBGlassButton butt_2 = Butt_7;
		Point menuListPosition = new Point(0, 0);
		butt_2.MenuListPosition = menuListPosition;
		((Control)Butt_7).Name = "Butt_7";
		Butt_7.OnColor = Color.FromArgb(22, 106, 238);
		Butt_7.OnStrokeColor = Color.Gray;
		Butt_7.PressColor = Color.Yellow;
		Butt_7.PressStrokeColor = Color.Gray;
		Butt_7.Radius = 22;
		((ButtonBase)Butt_7).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_BACK).BackColor = Color.Transparent;
		Butt_BACK.BaseColor = Color.FromArgb(255, 192, 192);
		Butt_BACK.BaseStrokeColor = Color.FromArgb(100, 255, 192, 192);
		((Control)Butt_BACK).Cursor = Cursors.Hand;
		((ButtonBase)Butt_BACK).FlatAppearance.BorderSize = 0;
		componentResourceManager.ApplyResources(Butt_BACK, "Butt_BACK");
		Butt_BACK.GlowingingSpeed = 5;
		Button_MBGlassButton butt_BACK = Butt_BACK;
		imageSize = new Size(24, 24);
		butt_BACK.ImageSize = imageSize;
		Button_MBGlassButton butt_BACK2 = Butt_BACK;
		menuListPosition = new Point(0, 0);
		butt_BACK2.MenuListPosition = menuListPosition;
		((Control)Butt_BACK).Name = "Butt_BACK";
		Butt_BACK.OnColor = Color.FromArgb(22, 106, 238);
		Butt_BACK.OnStrokeColor = Color.Gray;
		Butt_BACK.PressColor = Color.Yellow;
		Butt_BACK.PressStrokeColor = Color.Gray;
		Butt_BACK.Radius = 22;
		((ButtonBase)Butt_BACK).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_DOT).BackColor = Color.Transparent;
		Butt_DOT.BaseColor = Color.FromArgb(232, 239, 249);
		Butt_DOT.BaseStrokeColor = Color.Silver;
		((Control)Butt_DOT).Cursor = Cursors.Hand;
		((ButtonBase)Butt_DOT).FlatAppearance.BorderSize = 0;
		componentResourceManager.ApplyResources(Butt_DOT, "Butt_DOT");
		Butt_DOT.GlowingingSpeed = 5;
		Button_MBGlassButton butt_DOT = Butt_DOT;
		imageSize = new Size(24, 24);
		butt_DOT.ImageSize = imageSize;
		Button_MBGlassButton butt_DOT2 = Butt_DOT;
		menuListPosition = new Point(0, 0);
		butt_DOT2.MenuListPosition = menuListPosition;
		((Control)Butt_DOT).Name = "Butt_DOT";
		Butt_DOT.OnColor = Color.FromArgb(22, 106, 238);
		Butt_DOT.OnStrokeColor = Color.Gray;
		Butt_DOT.PressColor = Color.Yellow;
		Butt_DOT.PressStrokeColor = Color.Gray;
		Butt_DOT.Radius = 22;
		((ButtonBase)Butt_DOT).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_DRAFT).BackColor = Color.Transparent;
		Butt_DRAFT.BaseColor = Color.FromArgb(232, 239, 249);
		Butt_DRAFT.BaseStrokeColor = Color.Silver;
		((Control)Butt_DRAFT).Cursor = Cursors.Hand;
		((ButtonBase)Butt_DRAFT).FlatAppearance.BorderSize = 0;
		componentResourceManager.ApplyResources(Butt_DRAFT, "Butt_DRAFT");
		Butt_DRAFT.GlowingingSpeed = 5;
		Button_MBGlassButton butt_DRAFT = Butt_DRAFT;
		imageSize = new Size(24, 24);
		butt_DRAFT.ImageSize = imageSize;
		Button_MBGlassButton butt_DRAFT2 = Butt_DRAFT;
		menuListPosition = new Point(0, 0);
		butt_DRAFT2.MenuListPosition = menuListPosition;
		((Control)Butt_DRAFT).Name = "Butt_DRAFT";
		Butt_DRAFT.OnColor = Color.FromArgb(22, 106, 238);
		Butt_DRAFT.OnStrokeColor = Color.Gray;
		Butt_DRAFT.PressColor = Color.Yellow;
		Butt_DRAFT.PressStrokeColor = Color.Gray;
		Butt_DRAFT.Radius = 22;
		((ButtonBase)Butt_DRAFT).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_0).BackColor = Color.Transparent;
		Butt_0.BaseColor = Color.FromArgb(232, 239, 249);
		Butt_0.BaseStrokeColor = Color.Silver;
		((Control)Butt_0).Cursor = Cursors.Hand;
		((ButtonBase)Butt_0).FlatAppearance.BorderSize = 0;
		componentResourceManager.ApplyResources(Butt_0, "Butt_0");
		Butt_0.GlowingingSpeed = 5;
		Button_MBGlassButton butt_3 = Butt_0;
		imageSize = new Size(24, 24);
		butt_3.ImageSize = imageSize;
		Button_MBGlassButton butt_4 = Butt_0;
		menuListPosition = new Point(0, 0);
		butt_4.MenuListPosition = menuListPosition;
		((Control)Butt_0).Name = "Butt_0";
		Butt_0.OnColor = Color.FromArgb(22, 106, 238);
		Butt_0.OnStrokeColor = Color.Gray;
		Butt_0.PressColor = Color.Yellow;
		Butt_0.PressStrokeColor = Color.Gray;
		Butt_0.Radius = 22;
		((ButtonBase)Butt_0).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_ok).BackColor = Color.Transparent;
		Butt_ok.BaseColor = Color.LightSkyBlue;
		Butt_ok.BaseStrokeColor = Color.FromArgb(100, 135, 206, 250);
		((Control)Butt_ok).Cursor = Cursors.Hand;
		((ButtonBase)Butt_ok).FlatAppearance.BorderSize = 0;
		componentResourceManager.ApplyResources(Butt_ok, "Butt_ok");
		Butt_ok.GlowingingSpeed = 5;
		Button_MBGlassButton butt_ok = Butt_ok;
		imageSize = new Size(24, 24);
		butt_ok.ImageSize = imageSize;
		Button_MBGlassButton butt_ok2 = Butt_ok;
		menuListPosition = new Point(0, 0);
		butt_ok2.MenuListPosition = menuListPosition;
		((Control)Butt_ok).Name = "Butt_ok";
		Butt_ok.OnColor = Color.FromArgb(22, 106, 238);
		Butt_ok.OnStrokeColor = Color.Gray;
		Butt_ok.PressColor = Color.Yellow;
		Butt_ok.PressStrokeColor = Color.Gray;
		Butt_ok.Radius = 22;
		((ButtonBase)Butt_ok).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_00).BackColor = Color.Transparent;
		Butt_00.BaseColor = Color.FromArgb(232, 239, 249);
		Butt_00.BaseStrokeColor = Color.Silver;
		((Control)Butt_00).Cursor = Cursors.Hand;
		((ButtonBase)Butt_00).FlatAppearance.BorderSize = 0;
		componentResourceManager.ApplyResources(Butt_00, "Butt_00");
		Butt_00.GlowingingSpeed = 5;
		Button_MBGlassButton butt_5 = Butt_00;
		imageSize = new Size(24, 24);
		butt_5.ImageSize = imageSize;
		Button_MBGlassButton butt_6 = Butt_00;
		menuListPosition = new Point(0, 0);
		butt_6.MenuListPosition = menuListPosition;
		((Control)Butt_00).Name = "Butt_00";
		Butt_00.OnColor = Color.FromArgb(22, 106, 238);
		Butt_00.OnStrokeColor = Color.Gray;
		Butt_00.PressColor = Color.Yellow;
		Butt_00.PressStrokeColor = Color.Gray;
		Butt_00.Radius = 22;
		((ButtonBase)Butt_00).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_9).BackColor = Color.Transparent;
		Butt_9.BaseColor = Color.FromArgb(232, 239, 249);
		Butt_9.BaseStrokeColor = Color.Silver;
		((Control)Butt_9).Cursor = Cursors.Hand;
		((ButtonBase)Butt_9).FlatAppearance.BorderSize = 0;
		componentResourceManager.ApplyResources(Butt_9, "Butt_9");
		Butt_9.GlowingingSpeed = 5;
		Button_MBGlassButton butt_7 = Butt_9;
		imageSize = new Size(24, 24);
		butt_7.ImageSize = imageSize;
		Button_MBGlassButton butt_8 = Butt_9;
		menuListPosition = new Point(0, 0);
		butt_8.MenuListPosition = menuListPosition;
		((Control)Butt_9).Name = "Butt_9";
		Butt_9.OnColor = Color.FromArgb(22, 106, 238);
		Butt_9.OnStrokeColor = Color.Gray;
		Butt_9.PressColor = Color.Yellow;
		Butt_9.PressStrokeColor = Color.Gray;
		Butt_9.Radius = 22;
		((ButtonBase)Butt_9).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_1).BackColor = Color.Transparent;
		Butt_1.BaseColor = Color.FromArgb(232, 239, 249);
		Butt_1.BaseStrokeColor = Color.Silver;
		((Control)Butt_1).Cursor = Cursors.Hand;
		((ButtonBase)Butt_1).FlatAppearance.BorderSize = 0;
		componentResourceManager.ApplyResources(Butt_1, "Butt_1");
		Butt_1.GlowingingSpeed = 5;
		Button_MBGlassButton butt_9 = Butt_1;
		imageSize = new Size(24, 24);
		butt_9.ImageSize = imageSize;
		Button_MBGlassButton butt_10 = Butt_1;
		menuListPosition = new Point(0, 0);
		butt_10.MenuListPosition = menuListPosition;
		((Control)Butt_1).Name = "Butt_1";
		Butt_1.OnColor = Color.FromArgb(22, 106, 238);
		Butt_1.OnStrokeColor = Color.Gray;
		Butt_1.PressColor = Color.Yellow;
		Butt_1.PressStrokeColor = Color.Gray;
		Butt_1.Radius = 22;
		((ButtonBase)Butt_1).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_8).BackColor = Color.Transparent;
		Butt_8.BaseColor = Color.FromArgb(232, 239, 249);
		Butt_8.BaseStrokeColor = Color.Silver;
		((Control)Butt_8).Cursor = Cursors.Hand;
		((ButtonBase)Butt_8).FlatAppearance.BorderSize = 0;
		componentResourceManager.ApplyResources(Butt_8, "Butt_8");
		Butt_8.GlowingingSpeed = 5;
		Button_MBGlassButton butt_11 = Butt_8;
		imageSize = new Size(24, 24);
		butt_11.ImageSize = imageSize;
		Button_MBGlassButton butt_12 = Butt_8;
		menuListPosition = new Point(0, 0);
		butt_12.MenuListPosition = menuListPosition;
		((Control)Butt_8).Name = "Butt_8";
		Butt_8.OnColor = Color.FromArgb(22, 106, 238);
		Butt_8.OnStrokeColor = Color.Gray;
		Butt_8.PressColor = Color.Yellow;
		Butt_8.PressStrokeColor = Color.Gray;
		Butt_8.Radius = 22;
		((ButtonBase)Butt_8).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_2).BackColor = Color.Transparent;
		Butt_2.BaseColor = Color.FromArgb(232, 239, 249);
		Butt_2.BaseStrokeColor = Color.Silver;
		((Control)Butt_2).Cursor = Cursors.Hand;
		((ButtonBase)Butt_2).FlatAppearance.BorderSize = 0;
		componentResourceManager.ApplyResources(Butt_2, "Butt_2");
		Butt_2.GlowingingSpeed = 5;
		Button_MBGlassButton butt_13 = Butt_2;
		imageSize = new Size(24, 24);
		butt_13.ImageSize = imageSize;
		Button_MBGlassButton butt_14 = Butt_2;
		menuListPosition = new Point(0, 0);
		butt_14.MenuListPosition = menuListPosition;
		((Control)Butt_2).Name = "Butt_2";
		Butt_2.OnColor = Color.FromArgb(22, 106, 238);
		Butt_2.OnStrokeColor = Color.Gray;
		Butt_2.PressColor = Color.Yellow;
		Butt_2.PressStrokeColor = Color.Gray;
		Butt_2.Radius = 22;
		((ButtonBase)Butt_2).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_3).BackColor = Color.Transparent;
		Butt_3.BaseColor = Color.FromArgb(232, 239, 249);
		Butt_3.BaseStrokeColor = Color.Silver;
		((Control)Butt_3).Cursor = Cursors.Hand;
		((ButtonBase)Butt_3).FlatAppearance.BorderSize = 0;
		componentResourceManager.ApplyResources(Butt_3, "Butt_3");
		Butt_3.GlowingingSpeed = 5;
		Button_MBGlassButton butt_15 = Butt_3;
		imageSize = new Size(24, 24);
		butt_15.ImageSize = imageSize;
		Button_MBGlassButton butt_16 = Butt_3;
		menuListPosition = new Point(0, 0);
		butt_16.MenuListPosition = menuListPosition;
		((Control)Butt_3).Name = "Butt_3";
		Butt_3.OnColor = Color.FromArgb(22, 106, 238);
		Butt_3.OnStrokeColor = Color.Gray;
		Butt_3.PressColor = Color.Yellow;
		Butt_3.PressStrokeColor = Color.Gray;
		Butt_3.Radius = 22;
		((ButtonBase)Butt_3).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_6).BackColor = Color.Transparent;
		Butt_6.BaseColor = Color.FromArgb(232, 239, 249);
		Butt_6.BaseStrokeColor = Color.Silver;
		((Control)Butt_6).Cursor = Cursors.Hand;
		((ButtonBase)Butt_6).FlatAppearance.BorderSize = 0;
		componentResourceManager.ApplyResources(Butt_6, "Butt_6");
		Butt_6.GlowingingSpeed = 5;
		Button_MBGlassButton butt_17 = Butt_6;
		imageSize = new Size(24, 24);
		butt_17.ImageSize = imageSize;
		Button_MBGlassButton butt_18 = Butt_6;
		menuListPosition = new Point(0, 0);
		butt_18.MenuListPosition = menuListPosition;
		((Control)Butt_6).Name = "Butt_6";
		Butt_6.OnColor = Color.FromArgb(22, 106, 238);
		Butt_6.OnStrokeColor = Color.Gray;
		Butt_6.PressColor = Color.Yellow;
		Butt_6.PressStrokeColor = Color.Gray;
		Butt_6.Radius = 22;
		((ButtonBase)Butt_6).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_4).BackColor = Color.Transparent;
		Butt_4.BaseColor = Color.FromArgb(232, 239, 249);
		Butt_4.BaseStrokeColor = Color.Silver;
		((Control)Butt_4).Cursor = Cursors.Hand;
		((ButtonBase)Butt_4).FlatAppearance.BorderSize = 0;
		componentResourceManager.ApplyResources(Butt_4, "Butt_4");
		Butt_4.GlowingingSpeed = 5;
		Button_MBGlassButton butt_19 = Butt_4;
		imageSize = new Size(24, 24);
		butt_19.ImageSize = imageSize;
		Button_MBGlassButton butt_20 = Butt_4;
		menuListPosition = new Point(0, 0);
		butt_20.MenuListPosition = menuListPosition;
		((Control)Butt_4).Name = "Butt_4";
		Butt_4.OnColor = Color.FromArgb(22, 106, 238);
		Butt_4.OnStrokeColor = Color.Gray;
		Butt_4.PressColor = Color.Yellow;
		Butt_4.PressStrokeColor = Color.Gray;
		Butt_4.Radius = 22;
		((ButtonBase)Butt_4).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_5).BackColor = Color.Transparent;
		Butt_5.BaseColor = Color.FromArgb(232, 239, 249);
		Butt_5.BaseStrokeColor = Color.Silver;
		((Control)Butt_5).Cursor = Cursors.Hand;
		((ButtonBase)Butt_5).FlatAppearance.BorderSize = 0;
		componentResourceManager.ApplyResources(Butt_5, "Butt_5");
		Butt_5.GlowingingSpeed = 5;
		Button_MBGlassButton butt_21 = Butt_5;
		imageSize = new Size(24, 24);
		butt_21.ImageSize = imageSize;
		Button_MBGlassButton butt_22 = Butt_5;
		menuListPosition = new Point(0, 0);
		butt_22.MenuListPosition = menuListPosition;
		((Control)Butt_5).Name = "Butt_5";
		Butt_5.OnColor = Color.FromArgb(22, 106, 238);
		Butt_5.OnStrokeColor = Color.Gray;
		Butt_5.PressColor = Color.Yellow;
		Butt_5.PressStrokeColor = Color.Gray;
		Butt_5.Radius = 22;
		((ButtonBase)Butt_5).UseVisualStyleBackColor = false;
		((Control)Panel5).BackColor = Color.Transparent;
		((Control)Panel5).Controls.Add((Control)(object)PictureBox3);
		((Control)Panel5).Controls.Add((Control)(object)Label1);
		((Control)Panel5).Controls.Add((Control)(object)CheckBox1);
		((Control)Panel5).Controls.Add((Control)(object)Label_erreur);
		((Control)Panel5).Controls.Add((Control)(object)Text_NUM);
		((Control)Panel5).Controls.Add((Control)(object)MbGlassButton1);
		componentResourceManager.ApplyResources(Panel5, "Panel5");
		((Control)Panel5).Name = "Panel5";
		componentResourceManager.ApplyResources(PictureBox3, "PictureBox3");
		((Control)PictureBox3).Name = "PictureBox3";
		PictureBox3.TabStop = false;
		componentResourceManager.ApplyResources(Label1, "Label1");
		((Control)Label1).Name = "Label1";
		componentResourceManager.ApplyResources(CheckBox1, "CheckBox1");
		((Control)CheckBox1).Cursor = Cursors.Hand;
		((ButtonBase)CheckBox1).FlatAppearance.BorderSize = 0;
		((Control)CheckBox1).Name = "CheckBox1";
		((ButtonBase)CheckBox1).UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(Label_erreur, "Label_erreur");
		((Control)Label_erreur).BackColor = Color.Transparent;
		((Control)Label_erreur).ForeColor = Color.Red;
		((Control)Label_erreur).Name = "Label_erreur";
		((TextBoxBase)Text_NUM).BorderStyle = (BorderStyle)0;
		componentResourceManager.ApplyResources(Text_NUM, "Text_NUM");
		((Control)Text_NUM).Name = "Text_NUM";
		((ButtonBase)MbGlassButton1).BackColor = Color.Transparent;
		MbGlassButton1.BaseColor = Color.White;
		MbGlassButton1.BaseStrokeColor = Color.Silver;
		((Control)MbGlassButton1).Cursor = Cursors.Hand;
		((ButtonBase)MbGlassButton1).FlatAppearance.BorderSize = 0;
		componentResourceManager.ApplyResources(MbGlassButton1, "MbGlassButton1");
		MbGlassButton1.GlowingingSpeed = 5;
		Button_MBGlassButton mbGlassButton = MbGlassButton1;
		imageSize = new Size(24, 24);
		mbGlassButton.ImageSize = imageSize;
		Button_MBGlassButton mbGlassButton2 = MbGlassButton1;
		menuListPosition = new Point(0, 0);
		mbGlassButton2.MenuListPosition = menuListPosition;
		((Control)MbGlassButton1).Name = "MbGlassButton1";
		MbGlassButton1.OnColor = Color.White;
		MbGlassButton1.OnStrokeColor = Color.FromArgb(100, 0, 77, 0);
		MbGlassButton1.PressColor = Color.White;
		MbGlassButton1.PressStrokeColor = Color.FromArgb(100, 0, 77, 0);
		MbGlassButton1.Radius = 33;
		((ButtonBase)MbGlassButton1).UseVisualStyleBackColor = false;
		componentResourceManager.ApplyResources(PictureBox8, "PictureBox8");
		((Control)PictureBox8).Name = "PictureBox8";
		PictureBox8.TabStop = false;
		componentResourceManager.ApplyResources(PictureBox10, "PictureBox10");
		((Control)PictureBox10).Name = "PictureBox10";
		PictureBox10.TabStop = false;
		componentResourceManager.ApplyResources(PictureBox2, "PictureBox2");
		((Control)PictureBox2).Name = "PictureBox2";
		PictureBox2.TabStop = false;
		((Control)Panel_menu).Controls.Add((Control)(object)Panel3);
		((Control)Panel_menu).Controls.Add((Control)(object)PictureBox1);
		((Control)Panel_menu).Controls.Add((Control)(object)PictureBox13);
		componentResourceManager.ApplyResources(Panel_menu, "Panel_menu");
		((Control)Panel_menu).Name = "Panel_menu";
		((Control)Panel3).Controls.Add((Control)(object)Button_JOURNAL);
		((Control)Panel3).Controls.Add((Control)(object)Button_PARAMETRES);
		((Control)Panel3).Controls.Add((Control)(object)Button_VENTE);
		((Control)Panel3).Controls.Add((Control)(object)Button_STOCK);
		((Control)Panel3).Controls.Add((Control)(object)Button_GESTION);
		((Control)Panel3).Controls.Add((Control)(object)Button_STATISTIQUES);
		componentResourceManager.ApplyResources(Panel3, "Panel3");
		((Control)Panel3).Name = "Panel3";
		componentResourceManager.ApplyResources(Button_JOURNAL, "Button_JOURNAL");
		((Control)Button_JOURNAL).Cursor = Cursors.Hand;
		((ButtonBase)Button_JOURNAL).FlatAppearance.BorderSize = 0;
		((Control)Button_JOURNAL).ForeColor = SystemColors.ControlDarkDark;
		((Control)Button_JOURNAL).Name = "Button_JOURNAL";
		((ButtonBase)Button_JOURNAL).UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(Button_PARAMETRES, "Button_PARAMETRES");
		((Control)Button_PARAMETRES).Cursor = Cursors.Hand;
		((ButtonBase)Button_PARAMETRES).FlatAppearance.BorderSize = 0;
		((Control)Button_PARAMETRES).ForeColor = SystemColors.ControlDarkDark;
		((Control)Button_PARAMETRES).Name = "Button_PARAMETRES";
		((ButtonBase)Button_PARAMETRES).UseVisualStyleBackColor = true;
		((ButtonBase)Button_VENTE).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Button_VENTE, "Button_VENTE");
		((Control)Button_VENTE).Cursor = Cursors.Hand;
		((ButtonBase)Button_VENTE).FlatAppearance.BorderSize = 0;
		((ButtonBase)Button_VENTE).FlatAppearance.MouseDownBackColor = Color.White;
		((ButtonBase)Button_VENTE).FlatAppearance.MouseOverBackColor = Color.White;
		((Control)Button_VENTE).ForeColor = SystemColors.ControlDarkDark;
		((Control)Button_VENTE).Name = "Button_VENTE";
		((ButtonBase)Button_VENTE).UseVisualStyleBackColor = false;
		((ButtonBase)Button_STOCK).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Button_STOCK, "Button_STOCK");
		((Control)Button_STOCK).Cursor = Cursors.Hand;
		((ButtonBase)Button_STOCK).FlatAppearance.BorderSize = 0;
		((Control)Button_STOCK).ForeColor = SystemColors.ControlDarkDark;
		((Control)Button_STOCK).Name = "Button_STOCK";
		((ButtonBase)Button_STOCK).UseVisualStyleBackColor = false;
		componentResourceManager.ApplyResources(Button_GESTION, "Button_GESTION");
		((Control)Button_GESTION).Cursor = Cursors.Hand;
		((ButtonBase)Button_GESTION).FlatAppearance.BorderSize = 0;
		((Control)Button_GESTION).ForeColor = SystemColors.ControlDarkDark;
		((Control)Button_GESTION).Name = "Button_GESTION";
		((ButtonBase)Button_GESTION).UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(Button_STATISTIQUES, "Button_STATISTIQUES");
		((Control)Button_STATISTIQUES).Cursor = Cursors.Hand;
		((ButtonBase)Button_STATISTIQUES).FlatAppearance.BorderSize = 0;
		((Control)Button_STATISTIQUES).ForeColor = SystemColors.ControlDarkDark;
		((Control)Button_STATISTIQUES).Name = "Button_STATISTIQUES";
		((ButtonBase)Button_STATISTIQUES).UseVisualStyleBackColor = true;
		((Control)PictureBox1).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(PictureBox1, "PictureBox1");
		((Control)PictureBox1).Name = "PictureBox1";
		PictureBox1.TabStop = false;
		componentResourceManager.ApplyResources(PictureBox13, "PictureBox13");
		((Control)PictureBox13).Name = "PictureBox13";
		PictureBox13.TabStop = false;
		((ToolStripItem)XdxToolStripMenuItem).Name = "XdxToolStripMenuItem";
		componentResourceManager.ApplyResources(XdxToolStripMenuItem, "XdxToolStripMenuItem");
		componentResourceManager.ApplyResources(Panel, "Panel");
		((Control)Panel).BackColor = Color.Transparent;
		((Control)Panel).Controls.Add((Control)(object)Text_LICENCE_DATE);
		((Control)Panel).Controls.Add((Control)(object)TextBox_ORGANISME);
		((Control)Panel).Controls.Add((Control)(object)PictureBox12);
		((Control)Panel).Controls.Add((Control)(object)LinkLabel1);
		((Control)Panel).Controls.Add((Control)(object)PictureBox_QUITTER);
		((Control)Panel).Controls.Add((Control)(object)Panel_login);
		((Control)Panel).Controls.Add((Control)(object)Panel_menu);
		((Control)Panel).Controls.Add((Control)(object)PictureBox100);
		((Control)Panel).Name = "Panel";
		componentResourceManager.ApplyResources(Text_LICENCE_DATE, "Text_LICENCE_DATE");
		((Control)Text_LICENCE_DATE).Name = "Text_LICENCE_DATE";
		componentResourceManager.ApplyResources(TextBox_ORGANISME, "TextBox_ORGANISME");
		((Control)TextBox_ORGANISME).Name = "TextBox_ORGANISME";
		componentResourceManager.ApplyResources(PictureBox12, "PictureBox12");
		((Control)PictureBox12).Name = "PictureBox12";
		PictureBox12.TabStop = false;
		componentResourceManager.ApplyResources(PictureBox_QUITTER, "PictureBox_QUITTER");
		((Control)PictureBox_QUITTER).Cursor = Cursors.Hand;
		((Control)PictureBox_QUITTER).Name = "PictureBox_QUITTER";
		PictureBox_QUITTER.TabStop = false;
		((Control)TableLayoutPanel1).BackColor = Color.White;
		componentResourceManager.ApplyResources(TableLayoutPanel1, "TableLayoutPanel1");
		TableLayoutPanel1.Controls.Add((Control)(object)Panel, 0, 0);
		((Control)TableLayoutPanel1).Name = "TableLayoutPanel1";
		componentResourceManager.ApplyResources(PictureBox100, "PictureBox100");
		((Control)PictureBox100).Name = "PictureBox100";
		PictureBox100.TabStop = false;
		componentResourceManager.ApplyResources(this, "$this");
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).BackColor = SystemColors.Control;
		((Control)this).Controls.Add((Control)(object)TableLayoutPanel1);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Control)this).Name = "Form_1_LOGIN";
		((Form)this).WindowState = (FormWindowState)2;
		((Control)Panel_login).ResumeLayout(false);
		((Control)Panel_CLAVIER).ResumeLayout(false);
		((Control)Panel5).ResumeLayout(false);
		((Control)Panel5).PerformLayout();
		((ISupportInitialize)PictureBox3).EndInit();
		((ISupportInitialize)PictureBox8).EndInit();
		((ISupportInitialize)PictureBox10).EndInit();
		((ISupportInitialize)PictureBox2).EndInit();
		((Control)Panel_menu).ResumeLayout(false);
		((Control)Panel3).ResumeLayout(false);
		((ISupportInitialize)PictureBox1).EndInit();
		((ISupportInitialize)PictureBox13).EndInit();
		((Control)Panel).ResumeLayout(false);
		((Control)Panel).PerformLayout();
		((ISupportInitialize)PictureBox12).EndInit();
		((ISupportInitialize)PictureBox_QUITTER).EndInit();
		((Control)TableLayoutPanel1).ResumeLayout(false);
		((ISupportInitialize)PictureBox100).EndInit();
		((Control)this).ResumeLayout(false);
	}

	public void FUN_CAT_ACCES()
	{
		if (Operators.CompareString(Module1._USERCATEGORIE, "ADMIN", TextCompare: false) == 0)
		{
			((Control)Button_VENTE).Enabled = true;
			((Control)Button_STOCK).Enabled = true;
			((Control)Button_JOURNAL).Enabled = true;
			((Control)Button_GESTION).Enabled = true;
			((Control)Button_STATISTIQUES).Enabled = true;
			((Control)Button_PARAMETRES).Enabled = true;
		}
		else if (Operators.CompareString(Module1._USERCATEGORIE, "MANAGER", TextCompare: false) == 0)
		{
			((Control)Button_VENTE).Enabled = true;
			((Control)Button_STOCK).Enabled = true;
			((Control)Button_JOURNAL).Enabled = true;
			((Control)Button_GESTION).Enabled = true;
			((Control)Button_STATISTIQUES).Enabled = false;
			((Control)Button_PARAMETRES).Enabled = false;
		}
		else if (Operators.CompareString(Module1._USERCATEGORIE, "UTILISATEUR", TextCompare: false) == 0)
		{
			((Control)Button_VENTE).Enabled = true;
			((Control)Button_STOCK).Enabled = false;
			((Control)Button_JOURNAL).Enabled = false;
			((Control)Button_GESTION).Enabled = false;
			((Control)Button_STATISTIQUES).Enabled = false;
			((Control)Button_PARAMETRES).Enabled = false;
		}
	}

	private void Form_1_LOGIN_Resize(object sender, EventArgs e)
	{
		((Control)Panel).Anchor = (AnchorStyles)0;
		Panel panel = Panel;
		Point location = checked(new Point((int)Math.Round((double)((Control)this).Width / 2.0 - (double)((Control)Panel).Width / 2.0), (int)Math.Round((double)((Control)this).Height / 2.0 - (double)((Control)Panel).Height / 2.0)));
		((Control)panel).Location = location;
	}

	private void Form_1_LOGIN_HandleCreated(object sender, EventArgs e)
	{
		if (Operators.CompareString(MyProject.Forms.Form_0_TEMPLATE.Label_LANGUE.Text, "ar", TextCompare: false) == 0)
		{
			Thread.CurrentThread.CurrentUICulture = new CultureInfo("ar");
			((Control)this).Controls.Clear();
			InitializeComponent();
			PictureBox100.Image = (Image)(object)MyProject.Forms.Form_0_TEMPLATE.logo_ar_login;
		}
	}

	private void Form_1_LOGIN_Load(object sender, EventArgs e)
	{
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected Obj, but got Unknown
		try
		{
			((Control)TableLayoutPanel1).Dock = (DockStyle)5;
			FUN_CAT_ACCES();
			if (Conversions.ToBoolean(MyProject.Forms.Form_0_TEMPLATE.TextBox_MODE_WINDOWS.Text))
			{
				((Control)PictureBox_QUITTER).Visible = false;
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

	private void Form_login_Shown(object sender, EventArgs e)
	{
		((Control)Text_NUM).Focus();
		((Form)this).Activate();
	}

	private void Text_NUM_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (e.KeyChar == '\'')
		{
			e.Handled = true;
		}
	}

	private void Butt_Click(object sender, EventArgs e)
	{
		Text_NUM.Text = Conversions.ToString(Operators.AddObject(Text_NUM.Text, NewLateBinding.LateGet(sender, null, "text", new object[0], null, null, null)));
		((TextBoxBase)Text_NUM).SelectionStart = Text_NUM.Text.Length;
		((Control)Text_NUM).Focus();
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
					goto IL_0009;
				case 142:
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
							goto IL_0009;
						case 3:
							goto IL_0039;
						case 4:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 5:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_0009:
					num2 = 2;
					Text_NUM.Text = Text_NUM.Text.Remove(checked(Text_NUM.Text.Length - 1));
					goto IL_0039;
					IL_0039:
					num2 = 3;
					((TextBoxBase)Text_NUM).SelectionStart = Text_NUM.Text.Length;
					break;
					end_IL_0001_2:
					break;
				}
				num2 = 4;
				((Control)Text_NUM).Focus();
				break;
				end_IL_0001:;
			}
			catch (Exception ex) when ((num3 != 0) & (num == 0))
			{
				ProjectData.SetProjectError(ex);
				try0001_dispatch = 142;
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
		Text_NUM.Text = "";
		((TextBoxBase)Text_NUM).SelectionStart = Text_NUM.Text.Length;
		((Control)Text_NUM).Focus();
	}

	private void Butt_DOT_Click(object sender, EventArgs e)
	{
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected Obj, but got Unknown
		try
		{
			Interaction.Shell(Application.StartupPath + "\\CLAVIER.exe");
			((TextBoxBase)Text_NUM).SelectionStart = Text_NUM.Text.Length;
			((Control)Text_NUM).Focus();
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

	private void Butt_ok_Click(object sender, EventArgs e)
	{
		//IL_03d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03de: Expected Obj, but got Unknown
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected Obj, but got Unknown
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected Obj, but got Unknown
		try
		{
			if (Operators.CompareString(Text_NUM.Text, Conversions.ToString(Conversions.ToDouble(Strings.Mid(DateTime.Now.ToString("HHmm"), 4, 1)) + 1.0) + Conversions.ToString(Conversions.ToDouble(Strings.Mid(DateTime.Now.ToString("HHmm"), 1, 1)) + 1.0) + Conversions.ToString(Conversions.ToDouble(Strings.Mid(DateTime.Now.ToString("HHmm"), 3, 1)) + 1.0) + Conversions.ToString(Conversions.ToDouble(Strings.Mid(DateTime.Now.ToString("HHmm"), 2, 1)) + 1.0), TextCompare: false) == 0)
			{
				((Control)Panel_login).Visible = false;
				((Control)Panel_menu).Visible = true;
				((Control)Panel_menu).BringToFront();
				Module1._USERNAME = "root";
				Module1._USERCATEGORIE = "root";
			}
			DataTable dataTable = new DataTable();
			MySqlDataAdapter val = new MySqlDataAdapter();
			MySqlCommand loginCommand = new MySqlCommand("SELECT ListUser, `Catégorie` AS UserCategory FROM TABLE_PASS WHERE ListPass = @password", Module1.cn_SQL);
			loginCommand.Parameters.AddWithValue("@password", Strings.Trim(Text_NUM.Text));
			val = new MySqlDataAdapter(loginCommand);
			dataTable = new DataTable();
			dataTable.Clear();
			((DbDataAdapter)(object)val).Fill(dataTable);
			if (dataTable.Rows.Count != 0)
			{
				Module1._USERNAME = Conversions.ToString(dataTable.Rows[0]["ListUser"]);
				Module1._USERCATEGORIE = Conversions.ToString(dataTable.Rows[0]["UserCategory"]);
				((Control)Panel_login).Visible = false;
				if ((Operators.CompareString(Module1._USERCATEGORIE, "ADMIN", TextCompare: false) == 0) | (Operators.CompareString(Module1._USERCATEGORIE, "MANAGER", TextCompare: false) == 0))
				{
					((Control)Panel_menu).Visible = true;
					((Control)Panel_menu).BringToFront();
				}
				else if (Operators.CompareString(Module1._USERCATEGORIE, "UTILISATEUR", TextCompare: false) == 0)
				{
					Button_VENTE_Click(RuntimeHelpers.GetObjectValue(sender), e);
				}
				FUN_CAT_ACCES();
				string right = "LOGIN | ";
				File.AppendAllText(Application.StartupPath + "\\log.sni", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(Strings.Format(DateTime.Now, "ddMMyy HHmmss fff") + MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text, " | "), Module1._USERNAME), " | "), ((Control)this).Name), " | "), NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null)), " | "), right), "\r\n")), Encoding.UTF8);
			}
			else
			{
				Text_NUM.Text = "";
				((Control)Label_erreur).Visible = true;
				((TextBoxBase)Text_NUM).SelectionStart = Text_NUM.Text.Length;
				((Control)Text_NUM).Focus();
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

	private void PictureBox_QUITTER_Click(object sender, EventArgs e)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		((Form)MyProject.Forms.FormDialog_QUITTER).ShowDialog();
	}

	private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		((Control)MyProject.Forms.FormDialog_info).Show();
	}

	private void PictureBox12_Click(object sender, EventArgs e)
	{
		((Control)MyProject.Forms.FormDialog_info).Show();
	}

	private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		((Control)MyProject.Forms.FormDialog_info).Show();
	}

	private void Text_NUM_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Invalid comparison between Unknown and I4
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected Obj, but got Unknown
		try
		{
			if ((int)e.KeyCode == 13)
			{
				Butt_ok_Click(RuntimeHelpers.GetObjectValue(sender), (EventArgs)(object)e);
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

	private void PictureBox1_Click(object sender, EventArgs e)
	{
		Application.Restart();
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);

	private void Text_NUM_Enter(object sender, EventArgs e)
	{
		if (((Computer)MyProject.Computer).Keyboard.CapsLock)
		{
			keybd_event(20, 20, 1, 0);
			keybd_event(20, 20, 3, 0);
		}
	}

	private void CheckBox1_CheckedChanged(object sender, EventArgs e)
	{
		if (CheckBox1.Checked)
		{
			Text_NUM.PasswordChar = '\0';
		}
		else if (!CheckBox1.Checked)
		{
			Text_NUM.PasswordChar = '●';
		}
		((Control)Text_NUM).Focus();
	}

	private void Button_VENTE_Click(object sender, EventArgs e)
	{
		FormDialog_PATIENTER waiting = new FormDialog_PATIENTER();
		checked
		{
			try
			{
				waiting.Show();
				waiting.Refresh();
				NewLateBinding.LateSet(sender, null, "Enabled", new object[1] { false }, null, null);
				if (Operators.CompareString(MyProject.Forms.Form_0_TEMPLATE.Text_ara_reg.Text, MyProject.Forms.Form_0_TEMPLATE.Text_ara_disk.Text, TextCompare: false) == 0)
				{
					((Form)MyProject.Forms.Form_3_VENTE).Close();
					((Form)MyProject.Forms.Form_3_VENTE).TopLevel = false;
					((Control)MyProject.Forms.Form_0_TEMPLATE.Panel_HOME).Controls.Clear();
					((Control)MyProject.Forms.Form_0_TEMPLATE.Panel_HOME).Controls.Add((Control)(object)MyProject.Forms.Form_3_VENTE);
					((Control)MyProject.Forms.Form_3_VENTE).Show();
					NewLateBinding.LateSet(sender, null, "Enabled", new object[1] { true }, null, null);
					string right = "ACCES | ";
					File.AppendAllText(Application.StartupPath + "\\log.sni", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(Strings.Format(DateTime.Now, "ddMMyy HHmmss fff") + MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text, " | "), Module1._USERNAME), " | "), ((Control)this).Name), " | "), NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null)), " | "), right), "\r\n")), Encoding.UTF8);
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
			finally
			{
				waiting.Close();
				waiting.Dispose();
				if (sender is Control control) control.Enabled = true;
			}
		}
	}

	private void Button_STOCK_Click(object sender, EventArgs e)
	{
		FormDialog_PATIENTER waiting = new FormDialog_PATIENTER();
		checked
		{
			try
			{
				waiting.Show();
				waiting.Refresh();
				NewLateBinding.LateSet(sender, null, "Enabled", new object[1] { false }, null, null);
				((Form)MyProject.Forms.Form_2_ARTICLES).Close();
				((Form)MyProject.Forms.Form_2_ARTICLES).TopLevel = false;
				((Control)MyProject.Forms.Form_0_TEMPLATE.Panel_HOME).Controls.Clear();
				((Control)MyProject.Forms.Form_0_TEMPLATE.Panel_HOME).Controls.Add((Control)(object)MyProject.Forms.Form_2_ARTICLES);
				((Control)MyProject.Forms.Form_2_ARTICLES).Show();
				NewLateBinding.LateSet(sender, null, "Enabled", new object[1] { true }, null, null);
				string right = "ACCES | ";
				File.AppendAllText(Application.StartupPath + "\\log.sni", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(Strings.Format(DateTime.Now, "ddMMyy HHmmss fff") + MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text, " | "), Module1._USERNAME), " | "), ((Control)this).Name), " | "), NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null)), " | "), right), "\r\n")), Encoding.UTF8);
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
			finally
			{
				waiting.Close();
				waiting.Dispose();
				if (sender is Control control) control.Enabled = true;
			}
		}
	}

	private void Button_JOURNAL_Click(object sender, EventArgs e)
	{
		NewLateBinding.LateSet(sender, null, "Enabled", new object[1] { false }, null, null);
		((Form)MyProject.Forms.Form_3_VENTE_JOURNAL).Close();
		((Form)MyProject.Forms.Form_3_VENTE_JOURNAL).TopLevel = false;
		((Control)MyProject.Forms.Form_0_TEMPLATE.Panel_HOME).Controls.Clear();
		((Control)MyProject.Forms.Form_0_TEMPLATE.Panel_HOME).Controls.Add((Control)(object)MyProject.Forms.Form_3_VENTE_JOURNAL);
		((Control)MyProject.Forms.Form_3_VENTE_JOURNAL).Show();
		NewLateBinding.LateSet(sender, null, "Enabled", new object[1] { true }, null, null);
		string right = "ACCES | ";
		File.AppendAllText(Application.StartupPath + "\\log.sni", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(Strings.Format(DateTime.Now, "ddMMyy HHmmss fff") + MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text, " | "), Module1._USERNAME), " | "), ((Control)this).Name), " | "), NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null)), " | "), right), "\r\n")), Encoding.UTF8);
	}

	private void Button_GESTION_Click(object sender, EventArgs e)
	{
		NewLateBinding.LateSet(sender, null, "Enabled", new object[1] { false }, null, null);
		((Form)MyProject.Forms.Form_8_gestion).Close();
		((Form)MyProject.Forms.Form_8_gestion).TopLevel = false;
		((Control)MyProject.Forms.Form_0_TEMPLATE.Panel_HOME).Controls.Clear();
		((Control)MyProject.Forms.Form_0_TEMPLATE.Panel_HOME).Controls.Add((Control)(object)MyProject.Forms.Form_8_gestion);
		((Control)MyProject.Forms.Form_8_gestion).Show();
		NewLateBinding.LateSet(sender, null, "Enabled", new object[1] { true }, null, null);
		string right = "ACCES | ";
		File.AppendAllText(Application.StartupPath + "\\log.sni", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(Strings.Format(DateTime.Now, "ddMMyy HHmmss fff") + MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text, " | "), Module1._USERNAME), " | "), ((Control)this).Name), " | "), NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null)), " | "), right), "\r\n")), Encoding.UTF8);
	}

	private void Button_PARAMETRES_Click(object sender, EventArgs e)
	{
		FormDialog_PATIENTER waiting = new FormDialog_PATIENTER();
		checked
		{
			try
			{
				waiting.Show();
				waiting.Refresh();
				NewLateBinding.LateSet(sender, null, "Enabled", new object[1] { false }, null, null);
				((Form)MyProject.Forms.Form_9_PARAMETRE).Close();
				((Form)MyProject.Forms.Form_9_PARAMETRE).TopLevel = false;
				((Control)MyProject.Forms.Form_0_TEMPLATE.Panel_HOME).Controls.Clear();
				((Control)MyProject.Forms.Form_0_TEMPLATE.Panel_HOME).Controls.Add((Control)(object)MyProject.Forms.Form_9_PARAMETRE);
				((Control)MyProject.Forms.Form_9_PARAMETRE).Show();
				NewLateBinding.LateSet(sender, null, "Enabled", new object[1] { true }, null, null);
				string right = "ACCES | ";
				File.AppendAllText(Application.StartupPath + "\\log.sni", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(Strings.Format(DateTime.Now, "ddMMyy HHmmss fff") + MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text, " | "), Module1._USERNAME), " | "), ((Control)this).Name), " | "), NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null)), " | "), right), "\r\n")), Encoding.UTF8);
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
			finally
			{
				waiting.Close();
				waiting.Dispose();
				if (sender is Control control) control.Enabled = true;
			}
		}
	}

	private void Button_STATISTIQUES_Click(object sender, EventArgs e)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			NewLateBinding.LateSet(sender, null, "Enabled", new object[1] { false }, null, null);
			((Form)MyProject.Forms.Form_9_STATISTIQUES).ShowDialog();
			NewLateBinding.LateSet(sender, null, "Enabled", new object[1] { true }, null, null);
			string right = "ACCES | ";
			File.AppendAllText(Application.StartupPath + "\\log.sni", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(Strings.Format(DateTime.Now, "ddMMyy HHmmss fff") + MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text, " | "), Module1._USERNAME), " | "), ((Control)this).Name), " | "), NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null)), " | "), right), "\r\n")), Encoding.UTF8);
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

	private void Button_MouseHover(object sender, EventArgs e)
	{
		NewLateBinding.LateSet(sender, null, "ImageAlign", new object[1] { (object)(ContentAlignment)2 }, null, null);
	}

	private void Button_MouseLeave(object sender, EventArgs e)
	{
		NewLateBinding.LateSet(sender, null, "ImageAlign", new object[1] { (object)(ContentAlignment)32 }, null, null);
	}
}

