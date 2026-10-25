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
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Bunifu.UI.WinForms;
using LOGICA.My;
using LOGICA.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace LOGICA;

[DesignerGenerated]
public class FormDialog_1_UTILISATEURS : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("DataGridView1")]
	private DataGridView _DataGridView1;

	[AccessedThroughProperty("Button8")]
	private Button _Button8;

	[AccessedThroughProperty("CheckBox6")]
	private CheckBox _CheckBox6;

	[AccessedThroughProperty("Panel_INFO")]
	private Panel _Panel_INFO;

	[AccessedThroughProperty("TabControl1")]
	private TabControl _TabControl1;

	[AccessedThroughProperty("TabPage10")]
	private TabPage _TabPage10;

	[AccessedThroughProperty("Label28")]
	private Label _Label28;

	[AccessedThroughProperty("Label14")]
	private Label _Label14;

	[AccessedThroughProperty("Panel6")]
	private Panel _Panel6;

	[AccessedThroughProperty("CheckBox12")]
	private CheckBox _CheckBox12;

	[AccessedThroughProperty("TextBox25")]
	private TextBox _TextBox25;

	[AccessedThroughProperty("Panel3")]
	private Panel _Panel3;

	[AccessedThroughProperty("TextBox10")]
	private TextBox _TextBox10;

	[AccessedThroughProperty("Text_ID")]
	private TextBox _Text_ID;

	[AccessedThroughProperty("Label10")]
	private Label _Label10;

	[AccessedThroughProperty("TabPage11")]
	private TabPage _TabPage11;

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

	[AccessedThroughProperty("Button11")]
	private Button _Button11;

	[AccessedThroughProperty("Button10")]
	private Button _Button10;

	[AccessedThroughProperty("Radio_UTILISATEUR")]
	private RadioButton _Radio_UTILISATEUR;

	[AccessedThroughProperty("Radio_MANAGER")]
	private RadioButton _Radio_MANAGER;

	[AccessedThroughProperty("Radio_ADMIN")]
	private RadioButton _Radio_ADMIN;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Label29")]
	private Label _Label29;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("Label30")]
	private Label _Label30;

	[AccessedThroughProperty("Label27")]
	private Label _Label27;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("PictureBox3")]
	private PictureBox _PictureBox3;

	[AccessedThroughProperty("PictureBox2")]
	private PictureBox _PictureBox2;

	[AccessedThroughProperty("Label_CATEGORIE")]
	private Label _Label_CATEGORIE;

	[AccessedThroughProperty("DataGridViewImageColumn1")]
	private DataGridViewImageColumn _DataGridViewImageColumn1;

	[AccessedThroughProperty("DataGridViewImageColumn2")]
	private DataGridViewImageColumn _DataGridViewImageColumn2;

	[AccessedThroughProperty("ListUser")]
	private DataGridViewTextBoxColumn _ListUser;

	[AccessedThroughProperty("ListPass")]
	private DataGridViewTextBoxColumn _ListPass;

	[AccessedThroughProperty("Catégorie")]
	private DataGridViewTextBoxColumn _Catégorie;

	[AccessedThroughProperty("supp")]
	private DataGridViewImageColumn _supp;

	[AccessedThroughProperty("modi")]
	private DataGridViewImageColumn _modi;

	[AccessedThroughProperty("GroupBox_FONCTIONS")]
	private Panel _GroupBox_FONCTIONS;

	[AccessedThroughProperty("Check_SELECT_ALL")]
	private CheckBox _Check_SELECT_ALL;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label39")]
	private Label _Label39;

	[AccessedThroughProperty("Combo_CLOTURE")]
	private ComboBox _Combo_CLOTURE;

	[AccessedThroughProperty("Combo_OPERATION")]
	private ComboBox _Combo_OPERATION;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Combo_CLIENTS")]
	private ComboBox _Combo_CLIENTS;

	[AccessedThroughProperty("Combo_REMISE")]
	private ComboBox _Combo_REMISE;

	[AccessedThroughProperty("Label55")]
	private Label _Label55;

	[AccessedThroughProperty("Label15")]
	private Label _Label15;

	[AccessedThroughProperty("Combo_DIRECTE")]
	private ComboBox _Combo_DIRECTE;

	[AccessedThroughProperty("Combo_MODIF_PRIX")]
	private ComboBox _Combo_MODIF_PRIX;

	[AccessedThroughProperty("Label57")]
	private Label _Label57;

	[AccessedThroughProperty("Label33")]
	private Label _Label33;

	[AccessedThroughProperty("Combo_SOLDER")]
	private ComboBox _Combo_SOLDER;

	[AccessedThroughProperty("Combo_MODIF_QTE")]
	private ComboBox _Combo_MODIF_QTE;

	[AccessedThroughProperty("Label58")]
	private Label _Label58;

	[AccessedThroughProperty("Label40")]
	private Label _Label40;

	[AccessedThroughProperty("Combo_ADDITION")]
	private ComboBox _Combo_ADDITION;

	[AccessedThroughProperty("Combo_PRIX")]
	private ComboBox _Combo_PRIX;

	[AccessedThroughProperty("Label43")]
	private Label _Label43;

	[AccessedThroughProperty("Label41")]
	private Label _Label41;

	[AccessedThroughProperty("Combo_ARTICLES")]
	private ComboBox _Combo_ARTICLES;

	[AccessedThroughProperty("Combo_DIVERS")]
	private ComboBox _Combo_DIVERS;

	[AccessedThroughProperty("Label45")]
	private Label _Label45;

	[AccessedThroughProperty("Label36")]
	private Label _Label36;

	[AccessedThroughProperty("Combo_DUPLICATA")]
	private ComboBox _Combo_DUPLICATA;

	[AccessedThroughProperty("Combo_CLIENTS_REGLEMENTS")]
	private ComboBox _Combo_CLIENTS_REGLEMENTS;

	[AccessedThroughProperty("Label44")]
	private Label _Label44;

	[AccessedThroughProperty("Label37")]
	private Label _Label37;

	[AccessedThroughProperty("Combo_FLASH")]
	private ComboBox _Combo_FLASH;

	[AccessedThroughProperty("Combo_SORTIES")]
	private ComboBox _Combo_SORTIES;

	[AccessedThroughProperty("Label42")]
	private Label _Label42;

	[AccessedThroughProperty("Label38")]
	private Label _Label38;

	[AccessedThroughProperty("Combo_TIROIR")]
	private ComboBox _Combo_TIROIR;

	[AccessedThroughProperty("Combo_RECEPTIONS")]
	private ComboBox _Combo_RECEPTIONS;

	[AccessedThroughProperty("Label46")]
	private Label _Label46;

	[AccessedThroughProperty("Label48")]
	private Label _Label48;

	[AccessedThroughProperty("Combo_ANNULATION")]
	private ComboBox _Combo_ANNULATION;

	[AccessedThroughProperty("Combo_DEPENSES")]
	private ComboBox _Combo_DEPENSES;

	[AccessedThroughProperty("Label47")]
	private Label _Label47;

	[AccessedThroughProperty("Label49")]
	private Label _Label49;

	[AccessedThroughProperty("Combo_RAPPORT")]
	private ComboBox _Combo_RAPPORT;

	[AccessedThroughProperty("BunifuPictureBox")]
	private BunifuPictureBox _BunifuPictureBox;

	[AccessedThroughProperty("BunifuPictureBox8")]
	private BunifuPictureBox _BunifuPictureBox8;

	[AccessedThroughProperty("BunifuPictureBox7")]
	private BunifuPictureBox _BunifuPictureBox7;

	[AccessedThroughProperty("BunifuPictureBox9")]
	private BunifuPictureBox _BunifuPictureBox9;

	[AccessedThroughProperty("BunifuPictureBox10")]
	private BunifuPictureBox _BunifuPictureBox10;

	[AccessedThroughProperty("BunifuPictureBox15")]
	private BunifuPictureBox _BunifuPictureBox15;

	[AccessedThroughProperty("BunifuPictureBox2")]
	private BunifuPictureBox _BunifuPictureBox2;

	[AccessedThroughProperty("BunifuPictureBox11")]
	private BunifuPictureBox _BunifuPictureBox11;

	[AccessedThroughProperty("BunifuPictureBox12")]
	private BunifuPictureBox _BunifuPictureBox12;

	[AccessedThroughProperty("BunifuPictureBox4")]
	private BunifuPictureBox _BunifuPictureBox4;

	[AccessedThroughProperty("BunifuPictureBox13")]
	private BunifuPictureBox _BunifuPictureBox13;

	[AccessedThroughProperty("BunifuPictureBox5")]
	private BunifuPictureBox _BunifuPictureBox5;

	[AccessedThroughProperty("BunifuPictureBox14")]
	private BunifuPictureBox _BunifuPictureBox14;

	[AccessedThroughProperty("BunifuPictureBox6")]
	private BunifuPictureBox _BunifuPictureBox6;

	[AccessedThroughProperty("BunifuPictureBox20")]
	private BunifuPictureBox _BunifuPictureBox20;

	[AccessedThroughProperty("BunifuPictureBox25")]
	private BunifuPictureBox _BunifuPictureBox25;

	[AccessedThroughProperty("BunifuPictureBox24")]
	private BunifuPictureBox _BunifuPictureBox24;

	[AccessedThroughProperty("BunifuPictureBox16")]
	private BunifuPictureBox _BunifuPictureBox16;

	[AccessedThroughProperty("BunifuPictureBox17")]
	private BunifuPictureBox _BunifuPictureBox17;

	[AccessedThroughProperty("BunifuPictureBox23")]
	private BunifuPictureBox _BunifuPictureBox23;

	[AccessedThroughProperty("BunifuPictureBox18")]
	private BunifuPictureBox _BunifuPictureBox18;

	[AccessedThroughProperty("BunifuPictureBox22")]
	private BunifuPictureBox _BunifuPictureBox22;

	[AccessedThroughProperty("BunifuPictureBox19")]
	private BunifuPictureBox _BunifuPictureBox19;

	[AccessedThroughProperty("BunifuPictureBox21")]
	private BunifuPictureBox _BunifuPictureBox21;

	[AccessedThroughProperty("BunifuPictureBox_USER")]
	private BunifuPictureBox _BunifuPictureBox_USER;

	[AccessedThroughProperty("FlowLayoutPanel1")]
	private FlowLayoutPanel _FlowLayoutPanel1;

	[AccessedThroughProperty("BunifuPictureBox2732")]
	private BunifuPictureBox _BunifuPictureBox2732;

	[AccessedThroughProperty("BunifuPictureBox1")]
	private BunifuPictureBox _BunifuPictureBox1;

	[AccessedThroughProperty("BunifuPictureBox3")]
	private BunifuPictureBox _BunifuPictureBox3;

	[AccessedThroughProperty("Text_LIEN_PICTURE")]
	private TextBox _Text_LIEN_PICTURE;

	[AccessedThroughProperty("BunifuPictureBox26")]
	private BunifuPictureBox _BunifuPictureBox26;

	[AccessedThroughProperty("BunifuCircleProgress1")]
	private BunifuCircleProgress _BunifuCircleProgress1;

	[AccessedThroughProperty("Button_CLAVIER")]
	private Button_CLAVIER_NOSELECT _Button_CLAVIER;

	[AccessedThroughProperty("Label11")]
	private Label _Label11;

	[AccessedThroughProperty("Label35")]
	private Label _Label35;

	private DataTable dtt;

	private MySqlDataAdapter daa;

	private int x;

	private int y;

	private Point newpoint;

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
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected Obj, but got Unknown
			DataGridViewCellFormattingEventHandler val = DataGridView1_CellFormatting;
			DataGridViewCellEventHandler val2 = DataGridView1_CellClick;
			DataGridViewCellEventHandler val3 = DataGridView1_CellContentClick;
			if (_DataGridView1 != null)
			{
				_DataGridView1.CellFormatting -= val;
				_DataGridView1.CellClick -= val2;
				_DataGridView1.CellContentClick -= val3;
			}
			_DataGridView1 = value;
			if (_DataGridView1 != null)
			{
				_DataGridView1.CellFormatting += val;
				_DataGridView1.CellClick += val2;
				_DataGridView1.CellContentClick += val3;
			}
		}
	}

	internal virtual Button Button8
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button8_Click;
			if (_Button8 != null)
			{
				((Control)_Button8).Click -= eventHandler;
			}
			_Button8 = value;
			if (_Button8 != null)
			{
				((Control)_Button8).Click += eventHandler;
			}
		}
	}

	internal virtual CheckBox CheckBox6
	{
		[DebuggerNonUserCode]
		get
		{
			return _CheckBox6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = CheckBox6_CheckedChanged;
			if (_CheckBox6 != null)
			{
				_CheckBox6.CheckedChanged -= eventHandler;
			}
			_CheckBox6 = value;
			if (_CheckBox6 != null)
			{
				_CheckBox6.CheckedChanged += eventHandler;
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

	internal virtual TabPage TabPage10
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabPage10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = TabPage10_Click;
			if (_TabPage10 != null)
			{
				((Control)_TabPage10).Click -= eventHandler;
			}
			_TabPage10 = value;
			if (_TabPage10 != null)
			{
				((Control)_TabPage10).Click += eventHandler;
			}
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

	internal virtual Panel Panel6
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel6 = value;
		}
	}

	internal virtual CheckBox CheckBox12
	{
		[DebuggerNonUserCode]
		get
		{
			return _CheckBox12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = CheckBox12_CheckedChanged;
			if (_CheckBox12 != null)
			{
				_CheckBox12.CheckedChanged -= eventHandler;
			}
			_CheckBox12 = value;
			if (_CheckBox12 != null)
			{
				_CheckBox12.CheckedChanged += eventHandler;
			}
		}
	}

	internal virtual TextBox TextBox25
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox25;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBox25 = value;
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

	internal virtual TextBox TextBox10
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBox10 = value;
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

	internal virtual TabPage TabPage11
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabPage11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabPage11 = value;
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

	internal virtual Button Button11
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button11_Click;
			if (_Button11 != null)
			{
				((Control)_Button11).Click -= eventHandler;
			}
			_Button11 = value;
			if (_Button11 != null)
			{
				((Control)_Button11).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button10
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button10_Click;
			if (_Button10 != null)
			{
				((Control)_Button10).Click -= eventHandler;
			}
			_Button10 = value;
			if (_Button10 != null)
			{
				((Control)_Button10).Click += eventHandler;
			}
		}
	}

	internal virtual RadioButton Radio_UTILISATEUR
	{
		[DebuggerNonUserCode]
		get
		{
			return _Radio_UTILISATEUR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Radio_Click;
			if (_Radio_UTILISATEUR != null)
			{
				((Control)_Radio_UTILISATEUR).Click -= eventHandler;
			}
			_Radio_UTILISATEUR = value;
			if (_Radio_UTILISATEUR != null)
			{
				((Control)_Radio_UTILISATEUR).Click += eventHandler;
			}
		}
	}

	internal virtual RadioButton Radio_MANAGER
	{
		[DebuggerNonUserCode]
		get
		{
			return _Radio_MANAGER;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Radio_Click;
			if (_Radio_MANAGER != null)
			{
				((Control)_Radio_MANAGER).Click -= eventHandler;
			}
			_Radio_MANAGER = value;
			if (_Radio_MANAGER != null)
			{
				((Control)_Radio_MANAGER).Click += eventHandler;
			}
		}
	}

	internal virtual RadioButton Radio_ADMIN
	{
		[DebuggerNonUserCode]
		get
		{
			return _Radio_ADMIN;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Radio_ADMIN_CheckedChanged;
			EventHandler eventHandler2 = Radio_Click;
			if (_Radio_ADMIN != null)
			{
				_Radio_ADMIN.CheckedChanged -= eventHandler;
				((Control)_Radio_ADMIN).Click -= eventHandler2;
			}
			_Radio_ADMIN = value;
			if (_Radio_ADMIN != null)
			{
				_Radio_ADMIN.CheckedChanged += eventHandler;
				((Control)_Radio_ADMIN).Click += eventHandler2;
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

	internal virtual Label Label6
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label6 = value;
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

	internal virtual Label Label_CATEGORIE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_CATEGORIE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_CATEGORIE = value;
		}
	}

	internal virtual DataGridViewImageColumn DataGridViewImageColumn1
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridViewImageColumn1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGridViewImageColumn1 = value;
		}
	}

	internal virtual DataGridViewImageColumn DataGridViewImageColumn2
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridViewImageColumn2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGridViewImageColumn2 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn ListUser
	{
		[DebuggerNonUserCode]
		get
		{
			return _ListUser;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ListUser = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn ListPass
	{
		[DebuggerNonUserCode]
		get
		{
			return _ListPass;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ListPass = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Catégorie
	{
		[DebuggerNonUserCode]
		get
		{
			return _Catégorie;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Catégorie = value;
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

	internal virtual DataGridViewImageColumn modi
	{
		[DebuggerNonUserCode]
		get
		{
			return _modi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_modi = value;
		}
	}

	internal virtual Panel GroupBox_FONCTIONS
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupBox_FONCTIONS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupBox_FONCTIONS = value;
		}
	}

	internal virtual CheckBox Check_SELECT_ALL
	{
		[DebuggerNonUserCode]
		get
		{
			return _Check_SELECT_ALL;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Check_SELECT_ALL_CheckedChanged;
			if (_Check_SELECT_ALL != null)
			{
				_Check_SELECT_ALL.CheckedChanged -= eventHandler;
			}
			_Check_SELECT_ALL = value;
			if (_Check_SELECT_ALL != null)
			{
				_Check_SELECT_ALL.CheckedChanged += eventHandler;
			}
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

	internal virtual Label Label39
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label39;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label39 = value;
		}
	}

	internal virtual ComboBox Combo_CLOTURE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Combo_CLOTURE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Combo_CLOTURE = value;
		}
	}

	internal virtual ComboBox Combo_OPERATION
	{
		[DebuggerNonUserCode]
		get
		{
			return _Combo_OPERATION;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Combo_OPERATION = value;
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

	internal virtual ComboBox Combo_CLIENTS
	{
		[DebuggerNonUserCode]
		get
		{
			return _Combo_CLIENTS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Combo_CLIENTS = value;
		}
	}

	internal virtual ComboBox Combo_REMISE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Combo_REMISE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Combo_REMISE = value;
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

	internal virtual ComboBox Combo_DIRECTE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Combo_DIRECTE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Combo_DIRECTE = value;
		}
	}

	internal virtual ComboBox Combo_MODIF_PRIX
	{
		[DebuggerNonUserCode]
		get
		{
			return _Combo_MODIF_PRIX;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Combo_MODIF_PRIX = value;
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

	internal virtual ComboBox Combo_SOLDER
	{
		[DebuggerNonUserCode]
		get
		{
			return _Combo_SOLDER;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Combo_SOLDER = value;
		}
	}

	internal virtual ComboBox Combo_MODIF_QTE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Combo_MODIF_QTE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Combo_MODIF_QTE = value;
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

	internal virtual Label Label40
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label40;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label40 = value;
		}
	}

	internal virtual ComboBox Combo_ADDITION
	{
		[DebuggerNonUserCode]
		get
		{
			return _Combo_ADDITION;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Combo_ADDITION = value;
		}
	}

	internal virtual ComboBox Combo_PRIX
	{
		[DebuggerNonUserCode]
		get
		{
			return _Combo_PRIX;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Combo_PRIX = value;
		}
	}

	internal virtual Label Label43
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label43;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label43 = value;
		}
	}

	internal virtual Label Label41
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label41;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label41 = value;
		}
	}

	internal virtual ComboBox Combo_ARTICLES
	{
		[DebuggerNonUserCode]
		get
		{
			return _Combo_ARTICLES;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Combo_ARTICLES = value;
		}
	}

	internal virtual ComboBox Combo_DIVERS
	{
		[DebuggerNonUserCode]
		get
		{
			return _Combo_DIVERS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Combo_DIVERS = value;
		}
	}

	internal virtual Label Label45
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label45;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label45 = value;
		}
	}

	internal virtual Label Label36
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label36;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label36 = value;
		}
	}

	internal virtual ComboBox Combo_DUPLICATA
	{
		[DebuggerNonUserCode]
		get
		{
			return _Combo_DUPLICATA;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Combo_DUPLICATA = value;
		}
	}

	internal virtual ComboBox Combo_CLIENTS_REGLEMENTS
	{
		[DebuggerNonUserCode]
		get
		{
			return _Combo_CLIENTS_REGLEMENTS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Combo_CLIENTS_REGLEMENTS = value;
		}
	}

	internal virtual Label Label44
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label44;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label44 = value;
		}
	}

	internal virtual Label Label37
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label37;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label37 = value;
		}
	}

	internal virtual ComboBox Combo_FLASH
	{
		[DebuggerNonUserCode]
		get
		{
			return _Combo_FLASH;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Combo_FLASH = value;
		}
	}

	internal virtual ComboBox Combo_SORTIES
	{
		[DebuggerNonUserCode]
		get
		{
			return _Combo_SORTIES;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Combo_SORTIES = value;
		}
	}

	internal virtual Label Label42
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label42;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label42 = value;
		}
	}

	internal virtual Label Label38
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label38;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label38 = value;
		}
	}

	internal virtual ComboBox Combo_TIROIR
	{
		[DebuggerNonUserCode]
		get
		{
			return _Combo_TIROIR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Combo_TIROIR = value;
		}
	}

	internal virtual ComboBox Combo_RECEPTIONS
	{
		[DebuggerNonUserCode]
		get
		{
			return _Combo_RECEPTIONS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Combo_RECEPTIONS = value;
		}
	}

	internal virtual Label Label46
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label46;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label46 = value;
		}
	}

	internal virtual Label Label48
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label48;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label48 = value;
		}
	}

	internal virtual ComboBox Combo_ANNULATION
	{
		[DebuggerNonUserCode]
		get
		{
			return _Combo_ANNULATION;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Combo_ANNULATION = value;
		}
	}

	internal virtual ComboBox Combo_DEPENSES
	{
		[DebuggerNonUserCode]
		get
		{
			return _Combo_DEPENSES;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Combo_DEPENSES = value;
		}
	}

	internal virtual Label Label47
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label47;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label47 = value;
		}
	}

	internal virtual Label Label49
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label49;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label49 = value;
		}
	}

	internal virtual ComboBox Combo_RAPPORT
	{
		[DebuggerNonUserCode]
		get
		{
			return _Combo_RAPPORT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Combo_RAPPORT = value;
		}
	}

	internal virtual BunifuPictureBox BunifuPictureBox
	{
		[DebuggerNonUserCode]
		get
		{
			return _BunifuPictureBox;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_BunifuPictureBox = value;
		}
	}

	internal virtual BunifuPictureBox BunifuPictureBox8
	{
		[DebuggerNonUserCode]
		get
		{
			return _BunifuPictureBox8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_BunifuPictureBox8 = value;
		}
	}

	internal virtual BunifuPictureBox BunifuPictureBox7
	{
		[DebuggerNonUserCode]
		get
		{
			return _BunifuPictureBox7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_BunifuPictureBox7 = value;
		}
	}

	internal virtual BunifuPictureBox BunifuPictureBox9
	{
		[DebuggerNonUserCode]
		get
		{
			return _BunifuPictureBox9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_BunifuPictureBox9 = value;
		}
	}

	internal virtual BunifuPictureBox BunifuPictureBox10
	{
		[DebuggerNonUserCode]
		get
		{
			return _BunifuPictureBox10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_BunifuPictureBox10 = value;
		}
	}

	internal virtual BunifuPictureBox BunifuPictureBox15
	{
		[DebuggerNonUserCode]
		get
		{
			return _BunifuPictureBox15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_BunifuPictureBox15 = value;
		}
	}

	internal virtual BunifuPictureBox BunifuPictureBox2
	{
		[DebuggerNonUserCode]
		get
		{
			return _BunifuPictureBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_BunifuPictureBox2 = value;
		}
	}

	internal virtual BunifuPictureBox BunifuPictureBox11
	{
		[DebuggerNonUserCode]
		get
		{
			return _BunifuPictureBox11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_BunifuPictureBox11 = value;
		}
	}

	internal virtual BunifuPictureBox BunifuPictureBox12
	{
		[DebuggerNonUserCode]
		get
		{
			return _BunifuPictureBox12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_BunifuPictureBox12 = value;
		}
	}

	internal virtual BunifuPictureBox BunifuPictureBox4
	{
		[DebuggerNonUserCode]
		get
		{
			return _BunifuPictureBox4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_BunifuPictureBox4 = value;
		}
	}

	internal virtual BunifuPictureBox BunifuPictureBox13
	{
		[DebuggerNonUserCode]
		get
		{
			return _BunifuPictureBox13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = BunifuPictureBox27_Click;
			if (_BunifuPictureBox13 != null)
			{
				((Control)_BunifuPictureBox13).Click -= eventHandler;
			}
			_BunifuPictureBox13 = value;
			if (_BunifuPictureBox13 != null)
			{
				((Control)_BunifuPictureBox13).Click += eventHandler;
			}
		}
	}

	internal virtual BunifuPictureBox BunifuPictureBox5
	{
		[DebuggerNonUserCode]
		get
		{
			return _BunifuPictureBox5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_BunifuPictureBox5 = value;
		}
	}

	internal virtual BunifuPictureBox BunifuPictureBox14
	{
		[DebuggerNonUserCode]
		get
		{
			return _BunifuPictureBox14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_BunifuPictureBox14 = value;
		}
	}

	internal virtual BunifuPictureBox BunifuPictureBox6
	{
		[DebuggerNonUserCode]
		get
		{
			return _BunifuPictureBox6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_BunifuPictureBox6 = value;
		}
	}

	internal virtual BunifuPictureBox BunifuPictureBox20
	{
		[DebuggerNonUserCode]
		get
		{
			return _BunifuPictureBox20;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_BunifuPictureBox20 = value;
		}
	}

	internal virtual BunifuPictureBox BunifuPictureBox25
	{
		[DebuggerNonUserCode]
		get
		{
			return _BunifuPictureBox25;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_BunifuPictureBox25 = value;
		}
	}

	internal virtual BunifuPictureBox BunifuPictureBox24
	{
		[DebuggerNonUserCode]
		get
		{
			return _BunifuPictureBox24;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_BunifuPictureBox24 = value;
		}
	}

	internal virtual BunifuPictureBox BunifuPictureBox16
	{
		[DebuggerNonUserCode]
		get
		{
			return _BunifuPictureBox16;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_BunifuPictureBox16 = value;
		}
	}

	internal virtual BunifuPictureBox BunifuPictureBox17
	{
		[DebuggerNonUserCode]
		get
		{
			return _BunifuPictureBox17;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_BunifuPictureBox17 = value;
		}
	}

	internal virtual BunifuPictureBox BunifuPictureBox23
	{
		[DebuggerNonUserCode]
		get
		{
			return _BunifuPictureBox23;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_BunifuPictureBox23 = value;
		}
	}

	internal virtual BunifuPictureBox BunifuPictureBox18
	{
		[DebuggerNonUserCode]
		get
		{
			return _BunifuPictureBox18;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_BunifuPictureBox18 = value;
		}
	}

	internal virtual BunifuPictureBox BunifuPictureBox22
	{
		[DebuggerNonUserCode]
		get
		{
			return _BunifuPictureBox22;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_BunifuPictureBox22 = value;
		}
	}

	internal virtual BunifuPictureBox BunifuPictureBox19
	{
		[DebuggerNonUserCode]
		get
		{
			return _BunifuPictureBox19;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_BunifuPictureBox19 = value;
		}
	}

	internal virtual BunifuPictureBox BunifuPictureBox21
	{
		[DebuggerNonUserCode]
		get
		{
			return _BunifuPictureBox21;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_BunifuPictureBox21 = value;
		}
	}

	internal virtual BunifuPictureBox BunifuPictureBox_USER
	{
		[DebuggerNonUserCode]
		get
		{
			return _BunifuPictureBox_USER;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = BunifuPictureBox_USER_Click;
			if (_BunifuPictureBox_USER != null)
			{
				((Control)_BunifuPictureBox_USER).Click -= eventHandler;
			}
			_BunifuPictureBox_USER = value;
			if (_BunifuPictureBox_USER != null)
			{
				((Control)_BunifuPictureBox_USER).Click += eventHandler;
			}
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

	internal virtual BunifuPictureBox BunifuPictureBox2732
	{
		[DebuggerNonUserCode]
		get
		{
			return _BunifuPictureBox2732;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = BunifuPictureBox27_Click;
			if (_BunifuPictureBox2732 != null)
			{
				((Control)_BunifuPictureBox2732).Click -= eventHandler;
			}
			_BunifuPictureBox2732 = value;
			if (_BunifuPictureBox2732 != null)
			{
				((Control)_BunifuPictureBox2732).Click += eventHandler;
			}
		}
	}

	internal virtual BunifuPictureBox BunifuPictureBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _BunifuPictureBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_BunifuPictureBox1 = value;
		}
	}

	internal virtual BunifuPictureBox BunifuPictureBox3
	{
		[DebuggerNonUserCode]
		get
		{
			return _BunifuPictureBox3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = BunifuPictureBox3_Click;
			if (_BunifuPictureBox3 != null)
			{
				((Control)_BunifuPictureBox3).Click -= eventHandler;
			}
			_BunifuPictureBox3 = value;
			if (_BunifuPictureBox3 != null)
			{
				((Control)_BunifuPictureBox3).Click += eventHandler;
			}
		}
	}

	internal virtual TextBox Text_LIEN_PICTURE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_LIEN_PICTURE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_LIEN_PICTURE = value;
		}
	}

	internal virtual BunifuPictureBox BunifuPictureBox26
	{
		[DebuggerNonUserCode]
		get
		{
			return _BunifuPictureBox26;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_BunifuPictureBox26 = value;
		}
	}

	internal virtual BunifuCircleProgress BunifuCircleProgress1
	{
		[DebuggerNonUserCode]
		get
		{
			return _BunifuCircleProgress1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_BunifuCircleProgress1 = value;
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
			_Label11 = value;
		}
	}

	internal virtual Label Label35
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label35;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label35 = value;
		}
	}

	public FormDialog_1_UTILISATEURS()
	{
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		((Form)this).Shown += Form_Shown;
		((Form)this).Load += FormDialog_UTILISATEURS_Load;
		((Control)this).HandleCreated += Form_1_LOGIN_HandleCreated;
		__ENCAddToList(this);
		dtt = new DataTable();
		daa = new MySqlDataAdapter();
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
		//IL_001e: Expected Obj, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected Obj, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected Obj, but got Unknown
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
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected Obj, but got Unknown
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected Obj, but got Unknown
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected Obj, but got Unknown
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected Obj, but got Unknown
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected Obj, but got Unknown
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Expected Obj, but got Unknown
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Expected Obj, but got Unknown
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected Obj, but got Unknown
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected Obj, but got Unknown
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Expected Obj, but got Unknown
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Expected Obj, but got Unknown
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected Obj, but got Unknown
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Expected Obj, but got Unknown
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected Obj, but got Unknown
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Expected Obj, but got Unknown
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
		//IL_03f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0401: Expected Obj, but got Unknown
		//IL_0403: Unknown result type (might be due to invalid IL or missing references)
		//IL_040d: Expected Obj, but got Unknown
		//IL_040f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0419: Expected Obj, but got Unknown
		//IL_041b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0425: Expected Obj, but got Unknown
		//IL_0427: Unknown result type (might be due to invalid IL or missing references)
		//IL_0431: Expected Obj, but got Unknown
		//IL_0433: Unknown result type (might be due to invalid IL or missing references)
		//IL_043d: Expected Obj, but got Unknown
		//IL_043f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0449: Expected Obj, but got Unknown
		//IL_044b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0455: Expected Obj, but got Unknown
		//IL_0457: Unknown result type (might be due to invalid IL or missing references)
		//IL_0461: Expected Obj, but got Unknown
		//IL_0463: Unknown result type (might be due to invalid IL or missing references)
		//IL_046d: Expected Obj, but got Unknown
		//IL_046f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0479: Expected Obj, but got Unknown
		//IL_047b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0485: Expected Obj, but got Unknown
		//IL_0487: Unknown result type (might be due to invalid IL or missing references)
		//IL_0491: Expected Obj, but got Unknown
		//IL_0493: Unknown result type (might be due to invalid IL or missing references)
		//IL_049d: Expected Obj, but got Unknown
		//IL_049f: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a9: Expected Obj, but got Unknown
		//IL_04ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b5: Expected Obj, but got Unknown
		//IL_04b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c1: Expected Obj, but got Unknown
		//IL_04c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cd: Expected Obj, but got Unknown
		//IL_04cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d9: Expected Obj, but got Unknown
		//IL_04db: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e5: Expected Obj, but got Unknown
		//IL_04e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f1: Expected Obj, but got Unknown
		//IL_04f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fd: Expected Obj, but got Unknown
		//IL_04ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0509: Expected Obj, but got Unknown
		//IL_050b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0515: Expected Obj, but got Unknown
		//IL_0517: Unknown result type (might be due to invalid IL or missing references)
		//IL_0521: Expected Obj, but got Unknown
		//IL_0523: Unknown result type (might be due to invalid IL or missing references)
		//IL_052d: Expected Obj, but got Unknown
		//IL_052f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0539: Expected Obj, but got Unknown
		//IL_053b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0545: Expected Obj, but got Unknown
		//IL_0547: Unknown result type (might be due to invalid IL or missing references)
		//IL_0551: Expected Obj, but got Unknown
		//IL_0553: Unknown result type (might be due to invalid IL or missing references)
		//IL_055d: Expected Obj, but got Unknown
		//IL_055f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0569: Expected Obj, but got Unknown
		//IL_056b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0575: Expected Obj, but got Unknown
		//IL_0577: Unknown result type (might be due to invalid IL or missing references)
		//IL_0581: Expected Obj, but got Unknown
		//IL_0583: Unknown result type (might be due to invalid IL or missing references)
		//IL_058d: Expected Obj, but got Unknown
		//IL_058f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0599: Expected Obj, but got Unknown
		//IL_059b: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a5: Expected Obj, but got Unknown
		//IL_05a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b1: Expected Obj, but got Unknown
		//IL_05b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bd: Expected Obj, but got Unknown
		//IL_05bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c9: Expected Obj, but got Unknown
		//IL_05cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d5: Expected Obj, but got Unknown
		//IL_05d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e1: Expected Obj, but got Unknown
		//IL_05e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ed: Expected Obj, but got Unknown
		//IL_0844: Unknown result type (might be due to invalid IL or missing references)
		//IL_084e: Expected Obj, but got Unknown
		//IL_0907: Unknown result type (might be due to invalid IL or missing references)
		//IL_0911: Expected Obj, but got Unknown
		//IL_0989: Unknown result type (might be due to invalid IL or missing references)
		//IL_0993: Expected Obj, but got Unknown
		//IL_2973: Unknown result type (might be due to invalid IL or missing references)
		//IL_297d: Expected Obj, but got Unknown
		//IL_29ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_29b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_29f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_29fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a22: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a28: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a58: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a5e: Unknown result type (might be due to invalid IL or missing references)
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FormDialog_1_UTILISATEURS));
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		DataGridViewCellStyle val3 = new DataGridViewCellStyle();
		DataGridViewCellStyle val4 = new DataGridViewCellStyle();
		DataGridView1 = new DataGridView();
		ListUser = new DataGridViewTextBoxColumn();
		ListPass = new DataGridViewTextBoxColumn();
		Catégorie = new DataGridViewTextBoxColumn();
		supp = new DataGridViewImageColumn();
		modi = new DataGridViewImageColumn();
		Panel_INFO = new Panel();
		Button_CLAVIER = new Button_CLAVIER_NOSELECT();
		TabControl1 = new TabControl();
		TabPage10 = new TabPage();
		FlowLayoutPanel1 = new FlowLayoutPanel();
		BunifuPictureBox2732 = new BunifuPictureBox();
		BunifuPictureBox1 = new BunifuPictureBox();
		BunifuPictureBox3 = new BunifuPictureBox();
		BunifuPictureBox13 = new BunifuPictureBox();
		BunifuPictureBox25 = new BunifuPictureBox();
		BunifuPictureBox7 = new BunifuPictureBox();
		BunifuPictureBox15 = new BunifuPictureBox();
		BunifuPictureBox10 = new BunifuPictureBox();
		BunifuPictureBox18 = new BunifuPictureBox();
		BunifuPictureBox2 = new BunifuPictureBox();
		BunifuPictureBox8 = new BunifuPictureBox();
		BunifuPictureBox16 = new BunifuPictureBox();
		BunifuPictureBox24 = new BunifuPictureBox();
		BunifuPictureBox = new BunifuPictureBox();
		BunifuPictureBox5 = new BunifuPictureBox();
		BunifuPictureBox23 = new BunifuPictureBox();
		BunifuPictureBox21 = new BunifuPictureBox();
		BunifuPictureBox19 = new BunifuPictureBox();
		BunifuPictureBox22 = new BunifuPictureBox();
		BunifuPictureBox17 = new BunifuPictureBox();
		BunifuPictureBox11 = new BunifuPictureBox();
		BunifuPictureBox20 = new BunifuPictureBox();
		BunifuPictureBox4 = new BunifuPictureBox();
		BunifuPictureBox14 = new BunifuPictureBox();
		BunifuPictureBox12 = new BunifuPictureBox();
		BunifuPictureBox6 = new BunifuPictureBox();
		BunifuPictureBox9 = new BunifuPictureBox();
		BunifuPictureBox26 = new BunifuPictureBox();
		Text_LIEN_PICTURE = new TextBox();
		Label_CATEGORIE = new Label();
		Radio_UTILISATEUR = new RadioButton();
		Radio_MANAGER = new RadioButton();
		Radio_ADMIN = new RadioButton();
		Label28 = new Label();
		Label14 = new Label();
		Panel6 = new Panel();
		CheckBox12 = new CheckBox();
		PictureBox3 = new PictureBox();
		Label27 = new Label();
		Label6 = new Label();
		TextBox25 = new TextBox();
		Label5 = new Label();
		Label3 = new Label();
		Panel3 = new Panel();
		PictureBox2 = new PictureBox();
		Text_ID = new TextBox();
		Label7 = new Label();
		Label30 = new Label();
		Label4 = new Label();
		TextBox10 = new TextBox();
		Label29 = new Label();
		Label10 = new Label();
		BunifuPictureBox_USER = new BunifuPictureBox();
		BunifuCircleProgress1 = new BunifuCircleProgress();
		TabPage11 = new TabPage();
		GroupBox_FONCTIONS = new Panel();
		Check_SELECT_ALL = new CheckBox();
		Label2 = new Label();
		Label39 = new Label();
		Combo_CLOTURE = new ComboBox();
		Combo_OPERATION = new ComboBox();
		Label1 = new Label();
		Combo_CLIENTS = new ComboBox();
		Combo_REMISE = new ComboBox();
		Label55 = new Label();
		Label15 = new Label();
		Combo_DIRECTE = new ComboBox();
		Combo_MODIF_PRIX = new ComboBox();
		Label57 = new Label();
		Label33 = new Label();
		Combo_SOLDER = new ComboBox();
		Combo_MODIF_QTE = new ComboBox();
		Label58 = new Label();
		Label40 = new Label();
		Combo_ADDITION = new ComboBox();
		Combo_PRIX = new ComboBox();
		Label43 = new Label();
		Label41 = new Label();
		Combo_ARTICLES = new ComboBox();
		Combo_DIVERS = new ComboBox();
		Label45 = new Label();
		Label36 = new Label();
		Combo_DUPLICATA = new ComboBox();
		Combo_CLIENTS_REGLEMENTS = new ComboBox();
		Label44 = new Label();
		Label37 = new Label();
		Combo_FLASH = new ComboBox();
		Combo_SORTIES = new ComboBox();
		Label42 = new Label();
		Label38 = new Label();
		Combo_TIROIR = new ComboBox();
		Combo_RECEPTIONS = new ComboBox();
		Label46 = new Label();
		Label48 = new Label();
		Combo_ANNULATION = new ComboBox();
		Combo_DEPENSES = new ComboBox();
		Label47 = new Label();
		Label49 = new Label();
		Combo_RAPPORT = new ComboBox();
		Label_BOTTOM = new Label();
		Label_LEFT = new Label();
		Label_RIGHT = new Label();
		Label_INDEX = new Label();
		Label_TOP = new Label();
		Button11 = new Button();
		Button10 = new Button();
		DataGridViewImageColumn1 = new DataGridViewImageColumn();
		DataGridViewImageColumn2 = new DataGridViewImageColumn();
		Button8 = new Button();
		CheckBox6 = new CheckBox();
		Label11 = new Label();
		Label35 = new Label();
		((ISupportInitialize)DataGridView1).BeginInit();
		((Control)Panel_INFO).SuspendLayout();
		((Control)TabControl1).SuspendLayout();
		((Control)TabPage10).SuspendLayout();
		((Control)FlowLayoutPanel1).SuspendLayout();
		((ISupportInitialize)BunifuPictureBox2732).BeginInit();
		((ISupportInitialize)BunifuPictureBox1).BeginInit();
		((ISupportInitialize)BunifuPictureBox3).BeginInit();
		((ISupportInitialize)BunifuPictureBox13).BeginInit();
		((ISupportInitialize)BunifuPictureBox25).BeginInit();
		((ISupportInitialize)BunifuPictureBox7).BeginInit();
		((ISupportInitialize)BunifuPictureBox15).BeginInit();
		((ISupportInitialize)BunifuPictureBox10).BeginInit();
		((ISupportInitialize)BunifuPictureBox18).BeginInit();
		((ISupportInitialize)BunifuPictureBox2).BeginInit();
		((ISupportInitialize)BunifuPictureBox8).BeginInit();
		((ISupportInitialize)BunifuPictureBox16).BeginInit();
		((ISupportInitialize)BunifuPictureBox24).BeginInit();
		((ISupportInitialize)BunifuPictureBox).BeginInit();
		((ISupportInitialize)BunifuPictureBox5).BeginInit();
		((ISupportInitialize)BunifuPictureBox23).BeginInit();
		((ISupportInitialize)BunifuPictureBox21).BeginInit();
		((ISupportInitialize)BunifuPictureBox19).BeginInit();
		((ISupportInitialize)BunifuPictureBox22).BeginInit();
		((ISupportInitialize)BunifuPictureBox17).BeginInit();
		((ISupportInitialize)BunifuPictureBox11).BeginInit();
		((ISupportInitialize)BunifuPictureBox20).BeginInit();
		((ISupportInitialize)BunifuPictureBox4).BeginInit();
		((ISupportInitialize)BunifuPictureBox14).BeginInit();
		((ISupportInitialize)BunifuPictureBox12).BeginInit();
		((ISupportInitialize)BunifuPictureBox6).BeginInit();
		((ISupportInitialize)BunifuPictureBox9).BeginInit();
		((ISupportInitialize)BunifuPictureBox26).BeginInit();
		((Control)Panel6).SuspendLayout();
		((ISupportInitialize)PictureBox3).BeginInit();
		((Control)Panel3).SuspendLayout();
		((ISupportInitialize)PictureBox2).BeginInit();
		((ISupportInitialize)BunifuPictureBox_USER).BeginInit();
		((Control)TabPage11).SuspendLayout();
		((Control)GroupBox_FONCTIONS).SuspendLayout();
		((Control)this).SuspendLayout();
		DataGridView1.AllowUserToAddRows = false;
		componentResourceManager.ApplyResources(DataGridView1, "DataGridView1");
		DataGridView1.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)16;
		DataGridView1.BackgroundColor = Color.White;
		DataGridView1.BorderStyle = (BorderStyle)2;
		val.Alignment = (DataGridViewContentAlignment)16;
		val.BackColor = SystemColors.Control;
		val.Font = new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		val.ForeColor = SystemColors.WindowText;
		val.SelectionBackColor = SystemColors.Highlight;
		val.SelectionForeColor = SystemColors.HighlightText;
		val.WrapMode = (DataGridViewTriState)1;
		DataGridView1.ColumnHeadersDefaultCellStyle = val;
		DataGridView1.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		DataGridView1.Columns.AddRange(new DataGridViewColumn[5]
		{
			(DataGridViewColumn)ListUser,
			(DataGridViewColumn)ListPass,
			(DataGridViewColumn)Catégorie,
			(DataGridViewColumn)supp,
			(DataGridViewColumn)modi
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
		((Control)DataGridView1).Name = "DataGridView1";
		val3.Alignment = (DataGridViewContentAlignment)16;
		val3.BackColor = SystemColors.Control;
		val3.Font = new Font("Tahoma", 8f);
		val3.ForeColor = SystemColors.WindowText;
		val3.SelectionBackColor = SystemColors.Highlight;
		val3.SelectionForeColor = SystemColors.HighlightText;
		val3.WrapMode = (DataGridViewTriState)1;
		DataGridView1.RowHeadersDefaultCellStyle = val3;
		DataGridView1.RowHeadersVisible = false;
		((DataGridViewColumn)ListUser).DataPropertyName = "ListUser";
		((DataGridViewColumn)ListUser).FillWeight = 73.17519f;
		componentResourceManager.ApplyResources(ListUser, "ListUser");
		((DataGridViewColumn)ListUser).Name = "ListUser";
		ListUser.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)ListPass).DataPropertyName = "ListPass";
		val4.NullValue = null;
		((DataGridViewColumn)ListPass).DefaultCellStyle = val4;
		((DataGridViewColumn)ListPass).FillWeight = 73.17519f;
		componentResourceManager.ApplyResources(ListPass, "ListPass");
		((DataGridViewColumn)ListPass).Name = "ListPass";
		ListPass.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)Catégorie).DataPropertyName = "Catégorie";
		((DataGridViewColumn)Catégorie).FillWeight = 73.17519f;
		componentResourceManager.ApplyResources(Catégorie, "Catégorie");
		((DataGridViewColumn)Catégorie).Name = "Catégorie";
		Catégorie.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)supp).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)supp).FillWeight = 152.2843f;
		supp.Image = (Image)(object)Resources.Picture_SUPP_Image;
		((DataGridViewColumn)supp).Name = "supp";
		((DataGridViewColumn)supp).Resizable = (DataGridViewTriState)1;
		componentResourceManager.ApplyResources(supp, "supp");
		((DataGridViewColumn)modi).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)modi).FillWeight = 128.1901f;
		modi.Image = (Image)(object)Resources.Picture_MODIF_Image;
		((DataGridViewColumn)modi).Name = "modi";
		((DataGridViewColumn)modi).Resizable = (DataGridViewTriState)1;
		componentResourceManager.ApplyResources(modi, "modi");
		((Control)Panel_INFO).BackColor = Color.White;
		Panel_INFO.BorderStyle = (BorderStyle)1;
		((Control)Panel_INFO).Controls.Add((Control)(object)Button_CLAVIER);
		((Control)Panel_INFO).Controls.Add((Control)(object)TabControl1);
		((Control)Panel_INFO).Controls.Add((Control)(object)Label_BOTTOM);
		((Control)Panel_INFO).Controls.Add((Control)(object)Label_LEFT);
		((Control)Panel_INFO).Controls.Add((Control)(object)Label_RIGHT);
		((Control)Panel_INFO).Controls.Add((Control)(object)Label_INDEX);
		((Control)Panel_INFO).Controls.Add((Control)(object)Label_TOP);
		((Control)Panel_INFO).Controls.Add((Control)(object)Button11);
		((Control)Panel_INFO).Controls.Add((Control)(object)Button10);
		componentResourceManager.ApplyResources(Panel_INFO, "Panel_INFO");
		((Control)Panel_INFO).Name = "Panel_INFO";
		componentResourceManager.ApplyResources(Button_CLAVIER, "Button_CLAVIER");
		((Control)Button_CLAVIER).Name = "Button_CLAVIER";
		((ButtonBase)Button_CLAVIER).UseVisualStyleBackColor = true;
		((Control)TabControl1).Controls.Add((Control)(object)TabPage10);
		((Control)TabControl1).Controls.Add((Control)(object)TabPage11);
		componentResourceManager.ApplyResources(TabControl1, "TabControl1");
		((Control)TabControl1).Name = "TabControl1";
		TabControl1.SelectedIndex = 0;
		TabPage10.BackColor = Color.White;
		((Control)TabPage10).Controls.Add((Control)(object)FlowLayoutPanel1);
		((Control)TabPage10).Controls.Add((Control)(object)Text_LIEN_PICTURE);
		((Control)TabPage10).Controls.Add((Control)(object)Label_CATEGORIE);
		((Control)TabPage10).Controls.Add((Control)(object)Radio_UTILISATEUR);
		((Control)TabPage10).Controls.Add((Control)(object)Radio_MANAGER);
		((Control)TabPage10).Controls.Add((Control)(object)Radio_ADMIN);
		((Control)TabPage10).Controls.Add((Control)(object)Label28);
		((Control)TabPage10).Controls.Add((Control)(object)Label14);
		((Control)TabPage10).Controls.Add((Control)(object)Panel6);
		((Control)TabPage10).Controls.Add((Control)(object)Panel3);
		((Control)TabPage10).Controls.Add((Control)(object)Label10);
		((Control)TabPage10).Controls.Add((Control)(object)BunifuPictureBox_USER);
		((Control)TabPage10).Controls.Add((Control)(object)BunifuCircleProgress1);
		componentResourceManager.ApplyResources(TabPage10, "TabPage10");
		((Control)TabPage10).Name = "TabPage10";
		componentResourceManager.ApplyResources(FlowLayoutPanel1, "FlowLayoutPanel1");
		((Control)FlowLayoutPanel1).Controls.Add((Control)(object)BunifuPictureBox2732);
		((Control)FlowLayoutPanel1).Controls.Add((Control)(object)BunifuPictureBox1);
		((Control)FlowLayoutPanel1).Controls.Add((Control)(object)BunifuPictureBox3);
		((Control)FlowLayoutPanel1).Controls.Add((Control)(object)BunifuPictureBox13);
		((Control)FlowLayoutPanel1).Controls.Add((Control)(object)BunifuPictureBox25);
		((Control)FlowLayoutPanel1).Controls.Add((Control)(object)BunifuPictureBox7);
		((Control)FlowLayoutPanel1).Controls.Add((Control)(object)BunifuPictureBox15);
		((Control)FlowLayoutPanel1).Controls.Add((Control)(object)BunifuPictureBox10);
		((Control)FlowLayoutPanel1).Controls.Add((Control)(object)BunifuPictureBox18);
		((Control)FlowLayoutPanel1).Controls.Add((Control)(object)BunifuPictureBox2);
		((Control)FlowLayoutPanel1).Controls.Add((Control)(object)BunifuPictureBox8);
		((Control)FlowLayoutPanel1).Controls.Add((Control)(object)BunifuPictureBox16);
		((Control)FlowLayoutPanel1).Controls.Add((Control)(object)BunifuPictureBox24);
		((Control)FlowLayoutPanel1).Controls.Add((Control)(object)BunifuPictureBox);
		((Control)FlowLayoutPanel1).Controls.Add((Control)(object)BunifuPictureBox5);
		((Control)FlowLayoutPanel1).Controls.Add((Control)(object)BunifuPictureBox23);
		((Control)FlowLayoutPanel1).Controls.Add((Control)(object)BunifuPictureBox21);
		((Control)FlowLayoutPanel1).Controls.Add((Control)(object)BunifuPictureBox19);
		((Control)FlowLayoutPanel1).Controls.Add((Control)(object)BunifuPictureBox22);
		((Control)FlowLayoutPanel1).Controls.Add((Control)(object)BunifuPictureBox17);
		((Control)FlowLayoutPanel1).Controls.Add((Control)(object)BunifuPictureBox11);
		((Control)FlowLayoutPanel1).Controls.Add((Control)(object)BunifuPictureBox20);
		((Control)FlowLayoutPanel1).Controls.Add((Control)(object)BunifuPictureBox4);
		((Control)FlowLayoutPanel1).Controls.Add((Control)(object)BunifuPictureBox14);
		((Control)FlowLayoutPanel1).Controls.Add((Control)(object)BunifuPictureBox12);
		((Control)FlowLayoutPanel1).Controls.Add((Control)(object)BunifuPictureBox6);
		((Control)FlowLayoutPanel1).Controls.Add((Control)(object)BunifuPictureBox9);
		((Control)FlowLayoutPanel1).Controls.Add((Control)(object)BunifuPictureBox26);
		((Control)FlowLayoutPanel1).Name = "FlowLayoutPanel1";
		BunifuPictureBox2732.AllowFocused = false;
		componentResourceManager.ApplyResources(BunifuPictureBox2732, "BunifuPictureBox2732");
		BunifuPictureBox2732.AutoSizeHeight = true;
		BunifuPictureBox2732.BorderRadius = 41;
		((Control)BunifuPictureBox2732).Cursor = Cursors.Hand;
		BunifuPictureBox2732.IsCircle = true;
		((Control)BunifuPictureBox2732).Name = "BunifuPictureBox2732";
		((PictureBox)BunifuPictureBox2732).TabStop = false;
		BunifuPictureBox2732.Type = (Bunifu.UI.WinForms.BunifuPictureBox.Types)0;
		BunifuPictureBox1.AllowFocused = false;
		componentResourceManager.ApplyResources(BunifuPictureBox1, "BunifuPictureBox1");
		BunifuPictureBox1.AutoSizeHeight = true;
		BunifuPictureBox1.BorderRadius = 41;
		((Control)BunifuPictureBox1).Cursor = Cursors.Hand;
		BunifuPictureBox1.IsCircle = true;
		((Control)BunifuPictureBox1).Name = "BunifuPictureBox1";
		((PictureBox)BunifuPictureBox1).TabStop = false;
		BunifuPictureBox1.Type = (Bunifu.UI.WinForms.BunifuPictureBox.Types)0;
		BunifuPictureBox3.AllowFocused = false;
		componentResourceManager.ApplyResources(BunifuPictureBox3, "BunifuPictureBox3");
		BunifuPictureBox3.AutoSizeHeight = true;
		BunifuPictureBox3.BorderRadius = 41;
		((Control)BunifuPictureBox3).Cursor = Cursors.Hand;
		BunifuPictureBox3.IsCircle = true;
		((Control)BunifuPictureBox3).Name = "BunifuPictureBox3";
		((PictureBox)BunifuPictureBox3).TabStop = false;
		BunifuPictureBox3.Type = (Bunifu.UI.WinForms.BunifuPictureBox.Types)0;
		BunifuPictureBox13.AllowFocused = false;
		componentResourceManager.ApplyResources(BunifuPictureBox13, "BunifuPictureBox13");
		BunifuPictureBox13.AutoSizeHeight = true;
		BunifuPictureBox13.BorderRadius = 41;
		((Control)BunifuPictureBox13).Cursor = Cursors.Hand;
		BunifuPictureBox13.IsCircle = true;
		((Control)BunifuPictureBox13).Name = "BunifuPictureBox13";
		((PictureBox)BunifuPictureBox13).TabStop = false;
		BunifuPictureBox13.Type = (Bunifu.UI.WinForms.BunifuPictureBox.Types)0;
		BunifuPictureBox25.AllowFocused = false;
		componentResourceManager.ApplyResources(BunifuPictureBox25, "BunifuPictureBox25");
		BunifuPictureBox25.AutoSizeHeight = true;
		BunifuPictureBox25.BorderRadius = 41;
		((Control)BunifuPictureBox25).Cursor = Cursors.Hand;
		BunifuPictureBox25.IsCircle = true;
		((Control)BunifuPictureBox25).Name = "BunifuPictureBox25";
		((PictureBox)BunifuPictureBox25).TabStop = false;
		BunifuPictureBox25.Type = (Bunifu.UI.WinForms.BunifuPictureBox.Types)0;
		BunifuPictureBox7.AllowFocused = false;
		componentResourceManager.ApplyResources(BunifuPictureBox7, "BunifuPictureBox7");
		BunifuPictureBox7.AutoSizeHeight = true;
		BunifuPictureBox7.BorderRadius = 41;
		((Control)BunifuPictureBox7).Cursor = Cursors.Hand;
		BunifuPictureBox7.IsCircle = true;
		((Control)BunifuPictureBox7).Name = "BunifuPictureBox7";
		((PictureBox)BunifuPictureBox7).TabStop = false;
		BunifuPictureBox7.Type = (Bunifu.UI.WinForms.BunifuPictureBox.Types)0;
		BunifuPictureBox15.AllowFocused = false;
		componentResourceManager.ApplyResources(BunifuPictureBox15, "BunifuPictureBox15");
		BunifuPictureBox15.AutoSizeHeight = true;
		BunifuPictureBox15.BorderRadius = 41;
		((Control)BunifuPictureBox15).Cursor = Cursors.Hand;
		BunifuPictureBox15.IsCircle = true;
		((Control)BunifuPictureBox15).Name = "BunifuPictureBox15";
		((PictureBox)BunifuPictureBox15).TabStop = false;
		BunifuPictureBox15.Type = (Bunifu.UI.WinForms.BunifuPictureBox.Types)0;
		BunifuPictureBox10.AllowFocused = false;
		componentResourceManager.ApplyResources(BunifuPictureBox10, "BunifuPictureBox10");
		BunifuPictureBox10.AutoSizeHeight = true;
		BunifuPictureBox10.BorderRadius = 41;
		((Control)BunifuPictureBox10).Cursor = Cursors.Hand;
		BunifuPictureBox10.IsCircle = true;
		((Control)BunifuPictureBox10).Name = "BunifuPictureBox10";
		((PictureBox)BunifuPictureBox10).TabStop = false;
		BunifuPictureBox10.Type = (Bunifu.UI.WinForms.BunifuPictureBox.Types)0;
		BunifuPictureBox18.AllowFocused = false;
		componentResourceManager.ApplyResources(BunifuPictureBox18, "BunifuPictureBox18");
		BunifuPictureBox18.AutoSizeHeight = true;
		BunifuPictureBox18.BorderRadius = 41;
		((Control)BunifuPictureBox18).Cursor = Cursors.Hand;
		BunifuPictureBox18.IsCircle = true;
		((Control)BunifuPictureBox18).Name = "BunifuPictureBox18";
		((PictureBox)BunifuPictureBox18).TabStop = false;
		BunifuPictureBox18.Type = (Bunifu.UI.WinForms.BunifuPictureBox.Types)0;
		BunifuPictureBox2.AllowFocused = false;
		componentResourceManager.ApplyResources(BunifuPictureBox2, "BunifuPictureBox2");
		BunifuPictureBox2.AutoSizeHeight = true;
		BunifuPictureBox2.BorderRadius = 41;
		((Control)BunifuPictureBox2).Cursor = Cursors.Hand;
		BunifuPictureBox2.IsCircle = true;
		((Control)BunifuPictureBox2).Name = "BunifuPictureBox2";
		((PictureBox)BunifuPictureBox2).TabStop = false;
		BunifuPictureBox2.Type = (Bunifu.UI.WinForms.BunifuPictureBox.Types)0;
		BunifuPictureBox8.AllowFocused = false;
		componentResourceManager.ApplyResources(BunifuPictureBox8, "BunifuPictureBox8");
		BunifuPictureBox8.AutoSizeHeight = true;
		BunifuPictureBox8.BorderRadius = 41;
		((Control)BunifuPictureBox8).Cursor = Cursors.Hand;
		BunifuPictureBox8.IsCircle = true;
		((Control)BunifuPictureBox8).Name = "BunifuPictureBox8";
		((PictureBox)BunifuPictureBox8).TabStop = false;
		BunifuPictureBox8.Type = (Bunifu.UI.WinForms.BunifuPictureBox.Types)0;
		BunifuPictureBox16.AllowFocused = false;
		componentResourceManager.ApplyResources(BunifuPictureBox16, "BunifuPictureBox16");
		BunifuPictureBox16.AutoSizeHeight = true;
		BunifuPictureBox16.BorderRadius = 41;
		((Control)BunifuPictureBox16).Cursor = Cursors.Hand;
		BunifuPictureBox16.IsCircle = true;
		((Control)BunifuPictureBox16).Name = "BunifuPictureBox16";
		((PictureBox)BunifuPictureBox16).TabStop = false;
		BunifuPictureBox16.Type = (Bunifu.UI.WinForms.BunifuPictureBox.Types)0;
		BunifuPictureBox24.AllowFocused = false;
		componentResourceManager.ApplyResources(BunifuPictureBox24, "BunifuPictureBox24");
		BunifuPictureBox24.AutoSizeHeight = true;
		BunifuPictureBox24.BorderRadius = 41;
		((Control)BunifuPictureBox24).Cursor = Cursors.Hand;
		BunifuPictureBox24.IsCircle = true;
		((Control)BunifuPictureBox24).Name = "BunifuPictureBox24";
		((PictureBox)BunifuPictureBox24).TabStop = false;
		BunifuPictureBox24.Type = (Bunifu.UI.WinForms.BunifuPictureBox.Types)0;
		BunifuPictureBox.AllowFocused = false;
		componentResourceManager.ApplyResources(BunifuPictureBox, "BunifuPictureBox");
		BunifuPictureBox.AutoSizeHeight = true;
		BunifuPictureBox.BorderRadius = 41;
		((Control)BunifuPictureBox).Cursor = Cursors.Hand;
		BunifuPictureBox.IsCircle = true;
		((Control)BunifuPictureBox).Name = "BunifuPictureBox";
		((PictureBox)BunifuPictureBox).TabStop = false;
		BunifuPictureBox.Type = (Bunifu.UI.WinForms.BunifuPictureBox.Types)0;
		BunifuPictureBox5.AllowFocused = false;
		componentResourceManager.ApplyResources(BunifuPictureBox5, "BunifuPictureBox5");
		BunifuPictureBox5.AutoSizeHeight = true;
		BunifuPictureBox5.BorderRadius = 41;
		((Control)BunifuPictureBox5).Cursor = Cursors.Hand;
		BunifuPictureBox5.IsCircle = true;
		((Control)BunifuPictureBox5).Name = "BunifuPictureBox5";
		((PictureBox)BunifuPictureBox5).TabStop = false;
		BunifuPictureBox5.Type = (Bunifu.UI.WinForms.BunifuPictureBox.Types)0;
		BunifuPictureBox23.AllowFocused = false;
		componentResourceManager.ApplyResources(BunifuPictureBox23, "BunifuPictureBox23");
		BunifuPictureBox23.AutoSizeHeight = true;
		BunifuPictureBox23.BorderRadius = 41;
		((Control)BunifuPictureBox23).Cursor = Cursors.Hand;
		BunifuPictureBox23.IsCircle = true;
		((Control)BunifuPictureBox23).Name = "BunifuPictureBox23";
		((PictureBox)BunifuPictureBox23).TabStop = false;
		BunifuPictureBox23.Type = (Bunifu.UI.WinForms.BunifuPictureBox.Types)0;
		BunifuPictureBox21.AllowFocused = false;
		componentResourceManager.ApplyResources(BunifuPictureBox21, "BunifuPictureBox21");
		BunifuPictureBox21.AutoSizeHeight = true;
		BunifuPictureBox21.BorderRadius = 41;
		((Control)BunifuPictureBox21).Cursor = Cursors.Hand;
		BunifuPictureBox21.IsCircle = true;
		((Control)BunifuPictureBox21).Name = "BunifuPictureBox21";
		((PictureBox)BunifuPictureBox21).TabStop = false;
		BunifuPictureBox21.Type = (Bunifu.UI.WinForms.BunifuPictureBox.Types)0;
		BunifuPictureBox19.AllowFocused = false;
		componentResourceManager.ApplyResources(BunifuPictureBox19, "BunifuPictureBox19");
		BunifuPictureBox19.AutoSizeHeight = true;
		BunifuPictureBox19.BorderRadius = 41;
		((Control)BunifuPictureBox19).Cursor = Cursors.Hand;
		BunifuPictureBox19.IsCircle = true;
		((Control)BunifuPictureBox19).Name = "BunifuPictureBox19";
		((PictureBox)BunifuPictureBox19).TabStop = false;
		BunifuPictureBox19.Type = (Bunifu.UI.WinForms.BunifuPictureBox.Types)0;
		BunifuPictureBox22.AllowFocused = false;
		componentResourceManager.ApplyResources(BunifuPictureBox22, "BunifuPictureBox22");
		BunifuPictureBox22.AutoSizeHeight = true;
		BunifuPictureBox22.BorderRadius = 41;
		((Control)BunifuPictureBox22).Cursor = Cursors.Hand;
		BunifuPictureBox22.IsCircle = true;
		((Control)BunifuPictureBox22).Name = "BunifuPictureBox22";
		((PictureBox)BunifuPictureBox22).TabStop = false;
		BunifuPictureBox22.Type = (Bunifu.UI.WinForms.BunifuPictureBox.Types)0;
		BunifuPictureBox17.AllowFocused = false;
		componentResourceManager.ApplyResources(BunifuPictureBox17, "BunifuPictureBox17");
		BunifuPictureBox17.AutoSizeHeight = true;
		BunifuPictureBox17.BorderRadius = 41;
		((Control)BunifuPictureBox17).Cursor = Cursors.Hand;
		BunifuPictureBox17.IsCircle = true;
		((Control)BunifuPictureBox17).Name = "BunifuPictureBox17";
		((PictureBox)BunifuPictureBox17).TabStop = false;
		BunifuPictureBox17.Type = (Bunifu.UI.WinForms.BunifuPictureBox.Types)0;
		BunifuPictureBox11.AllowFocused = false;
		componentResourceManager.ApplyResources(BunifuPictureBox11, "BunifuPictureBox11");
		BunifuPictureBox11.AutoSizeHeight = true;
		BunifuPictureBox11.BorderRadius = 41;
		((Control)BunifuPictureBox11).Cursor = Cursors.Hand;
		BunifuPictureBox11.IsCircle = true;
		((Control)BunifuPictureBox11).Name = "BunifuPictureBox11";
		((PictureBox)BunifuPictureBox11).TabStop = false;
		BunifuPictureBox11.Type = (Bunifu.UI.WinForms.BunifuPictureBox.Types)0;
		BunifuPictureBox20.AllowFocused = false;
		componentResourceManager.ApplyResources(BunifuPictureBox20, "BunifuPictureBox20");
		BunifuPictureBox20.AutoSizeHeight = true;
		BunifuPictureBox20.BorderRadius = 41;
		((Control)BunifuPictureBox20).Cursor = Cursors.Hand;
		BunifuPictureBox20.IsCircle = true;
		((Control)BunifuPictureBox20).Name = "BunifuPictureBox20";
		((PictureBox)BunifuPictureBox20).TabStop = false;
		BunifuPictureBox20.Type = (Bunifu.UI.WinForms.BunifuPictureBox.Types)0;
		BunifuPictureBox4.AllowFocused = false;
		componentResourceManager.ApplyResources(BunifuPictureBox4, "BunifuPictureBox4");
		BunifuPictureBox4.AutoSizeHeight = true;
		BunifuPictureBox4.BorderRadius = 41;
		((Control)BunifuPictureBox4).Cursor = Cursors.Hand;
		BunifuPictureBox4.IsCircle = true;
		((Control)BunifuPictureBox4).Name = "BunifuPictureBox4";
		((PictureBox)BunifuPictureBox4).TabStop = false;
		BunifuPictureBox4.Type = (Bunifu.UI.WinForms.BunifuPictureBox.Types)0;
		BunifuPictureBox14.AllowFocused = false;
		componentResourceManager.ApplyResources(BunifuPictureBox14, "BunifuPictureBox14");
		BunifuPictureBox14.AutoSizeHeight = true;
		BunifuPictureBox14.BorderRadius = 41;
		((Control)BunifuPictureBox14).Cursor = Cursors.Hand;
		BunifuPictureBox14.IsCircle = true;
		((Control)BunifuPictureBox14).Name = "BunifuPictureBox14";
		((PictureBox)BunifuPictureBox14).TabStop = false;
		BunifuPictureBox14.Type = (Bunifu.UI.WinForms.BunifuPictureBox.Types)0;
		BunifuPictureBox12.AllowFocused = false;
		componentResourceManager.ApplyResources(BunifuPictureBox12, "BunifuPictureBox12");
		BunifuPictureBox12.AutoSizeHeight = true;
		BunifuPictureBox12.BorderRadius = 41;
		((Control)BunifuPictureBox12).Cursor = Cursors.Hand;
		BunifuPictureBox12.IsCircle = true;
		((Control)BunifuPictureBox12).Name = "BunifuPictureBox12";
		((PictureBox)BunifuPictureBox12).TabStop = false;
		BunifuPictureBox12.Type = (Bunifu.UI.WinForms.BunifuPictureBox.Types)0;
		BunifuPictureBox6.AllowFocused = false;
		componentResourceManager.ApplyResources(BunifuPictureBox6, "BunifuPictureBox6");
		BunifuPictureBox6.AutoSizeHeight = true;
		BunifuPictureBox6.BorderRadius = 41;
		((Control)BunifuPictureBox6).Cursor = Cursors.Hand;
		BunifuPictureBox6.IsCircle = true;
		((Control)BunifuPictureBox6).Name = "BunifuPictureBox6";
		((PictureBox)BunifuPictureBox6).TabStop = false;
		BunifuPictureBox6.Type = (Bunifu.UI.WinForms.BunifuPictureBox.Types)0;
		BunifuPictureBox9.AllowFocused = false;
		componentResourceManager.ApplyResources(BunifuPictureBox9, "BunifuPictureBox9");
		BunifuPictureBox9.AutoSizeHeight = true;
		BunifuPictureBox9.BorderRadius = 41;
		((Control)BunifuPictureBox9).Cursor = Cursors.Hand;
		BunifuPictureBox9.IsCircle = true;
		((Control)BunifuPictureBox9).Name = "BunifuPictureBox9";
		((PictureBox)BunifuPictureBox9).TabStop = false;
		BunifuPictureBox9.Type = (Bunifu.UI.WinForms.BunifuPictureBox.Types)0;
		BunifuPictureBox26.AllowFocused = false;
		componentResourceManager.ApplyResources(BunifuPictureBox26, "BunifuPictureBox26");
		BunifuPictureBox26.AutoSizeHeight = true;
		BunifuPictureBox26.BorderRadius = 41;
		((Control)BunifuPictureBox26).Cursor = Cursors.Hand;
		BunifuPictureBox26.IsCircle = true;
		((Control)BunifuPictureBox26).Name = "BunifuPictureBox26";
		((PictureBox)BunifuPictureBox26).TabStop = false;
		BunifuPictureBox26.Type = (Bunifu.UI.WinForms.BunifuPictureBox.Types)0;
		((TextBoxBase)Text_LIEN_PICTURE).BackColor = Color.FromArgb(249, 249, 249);
		((TextBoxBase)Text_LIEN_PICTURE).BorderStyle = (BorderStyle)0;
		componentResourceManager.ApplyResources(Text_LIEN_PICTURE, "Text_LIEN_PICTURE");
		((Control)Text_LIEN_PICTURE).Name = "Text_LIEN_PICTURE";
		componentResourceManager.ApplyResources(Label_CATEGORIE, "Label_CATEGORIE");
		((Control)Label_CATEGORIE).Name = "Label_CATEGORIE";
		componentResourceManager.ApplyResources(Radio_UTILISATEUR, "Radio_UTILISATEUR");
		((ButtonBase)Radio_UTILISATEUR).FlatAppearance.BorderColor = Color.FromArgb(22, 106, 238);
		((ButtonBase)Radio_UTILISATEUR).FlatAppearance.CheckedBackColor = Color.Yellow;
		((Control)Radio_UTILISATEUR).Name = "Radio_UTILISATEUR";
		Radio_UTILISATEUR.TabStop = true;
		((ButtonBase)Radio_UTILISATEUR).UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(Radio_MANAGER, "Radio_MANAGER");
		((ButtonBase)Radio_MANAGER).FlatAppearance.BorderColor = Color.FromArgb(22, 106, 238);
		((ButtonBase)Radio_MANAGER).FlatAppearance.CheckedBackColor = Color.Yellow;
		((Control)Radio_MANAGER).Name = "Radio_MANAGER";
		Radio_MANAGER.TabStop = true;
		((ButtonBase)Radio_MANAGER).UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(Radio_ADMIN, "Radio_ADMIN");
		((ButtonBase)Radio_ADMIN).FlatAppearance.BorderColor = Color.FromArgb(22, 106, 238);
		((ButtonBase)Radio_ADMIN).FlatAppearance.CheckedBackColor = Color.Yellow;
		((Control)Radio_ADMIN).Name = "Radio_ADMIN";
		Radio_ADMIN.TabStop = true;
		((ButtonBase)Radio_ADMIN).UseVisualStyleBackColor = true;
		((Control)Label28).BackColor = SystemColors.Control;
		componentResourceManager.ApplyResources(Label28, "Label28");
		((Control)Label28).ForeColor = Color.DimGray;
		((Control)Label28).Name = "Label28";
		((Control)Label14).BackColor = SystemColors.Control;
		componentResourceManager.ApplyResources(Label14, "Label14");
		((Control)Label14).ForeColor = Color.DimGray;
		((Control)Label14).Name = "Label14";
		((Control)Panel6).BackColor = Color.White;
		componentResourceManager.ApplyResources(Panel6, "Panel6");
		((Control)Panel6).Controls.Add((Control)(object)CheckBox12);
		((Control)Panel6).Controls.Add((Control)(object)PictureBox3);
		((Control)Panel6).Controls.Add((Control)(object)Label27);
		((Control)Panel6).Controls.Add((Control)(object)Label6);
		((Control)Panel6).Controls.Add((Control)(object)TextBox25);
		((Control)Panel6).Controls.Add((Control)(object)Label5);
		((Control)Panel6).Controls.Add((Control)(object)Label3);
		((Control)Panel6).Name = "Panel6";
		componentResourceManager.ApplyResources(CheckBox12, "CheckBox12");
		((ButtonBase)CheckBox12).FlatAppearance.BorderSize = 0;
		((Control)CheckBox12).Name = "CheckBox12";
		((ButtonBase)CheckBox12).UseCompatibleTextRendering = true;
		((ButtonBase)CheckBox12).UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(PictureBox3, "PictureBox3");
		((Control)PictureBox3).Name = "PictureBox3";
		PictureBox3.TabStop = false;
		((Control)Label27).BackColor = Color.FromArgb(22, 106, 238);
		componentResourceManager.ApplyResources(Label27, "Label27");
		((Control)Label27).ForeColor = Color.White;
		((Control)Label27).Name = "Label27";
		((Control)Label6).BackColor = Color.FromArgb(22, 106, 238);
		componentResourceManager.ApplyResources(Label6, "Label6");
		((Control)Label6).ForeColor = Color.White;
		((Control)Label6).Name = "Label6";
		((TextBoxBase)TextBox25).BorderStyle = (BorderStyle)0;
		componentResourceManager.ApplyResources(TextBox25, "TextBox25");
		((Control)TextBox25).Name = "TextBox25";
		((Control)Label5).BackColor = Color.FromArgb(22, 106, 238);
		componentResourceManager.ApplyResources(Label5, "Label5");
		((Control)Label5).ForeColor = Color.White;
		((Control)Label5).Name = "Label5";
		((Control)Label3).BackColor = Color.FromArgb(22, 106, 238);
		componentResourceManager.ApplyResources(Label3, "Label3");
		((Control)Label3).ForeColor = Color.White;
		((Control)Label3).Name = "Label3";
		((Control)Panel3).BackColor = Color.White;
		componentResourceManager.ApplyResources(Panel3, "Panel3");
		((Control)Panel3).Controls.Add((Control)(object)PictureBox2);
		((Control)Panel3).Controls.Add((Control)(object)Text_ID);
		((Control)Panel3).Controls.Add((Control)(object)Label7);
		((Control)Panel3).Controls.Add((Control)(object)Label30);
		((Control)Panel3).Controls.Add((Control)(object)Label4);
		((Control)Panel3).Controls.Add((Control)(object)TextBox10);
		((Control)Panel3).Controls.Add((Control)(object)Label29);
		((Control)Panel3).Name = "Panel3";
		componentResourceManager.ApplyResources(PictureBox2, "PictureBox2");
		((Control)PictureBox2).Name = "PictureBox2";
		PictureBox2.TabStop = false;
		((TextBoxBase)Text_ID).BorderStyle = (BorderStyle)1;
		componentResourceManager.ApplyResources(Text_ID, "Text_ID");
		((Control)Text_ID).Name = "Text_ID";
		((Control)Label7).BackColor = Color.FromArgb(22, 106, 238);
		componentResourceManager.ApplyResources(Label7, "Label7");
		((Control)Label7).ForeColor = Color.White;
		((Control)Label7).Name = "Label7";
		((Control)Label30).BackColor = Color.FromArgb(22, 106, 238);
		componentResourceManager.ApplyResources(Label30, "Label30");
		((Control)Label30).ForeColor = Color.White;
		((Control)Label30).Name = "Label30";
		((Control)Label4).BackColor = Color.FromArgb(22, 106, 238);
		componentResourceManager.ApplyResources(Label4, "Label4");
		((Control)Label4).ForeColor = Color.White;
		((Control)Label4).Name = "Label4";
		((TextBoxBase)TextBox10).BorderStyle = (BorderStyle)0;
		componentResourceManager.ApplyResources(TextBox10, "TextBox10");
		((Control)TextBox10).Name = "TextBox10";
		((Control)Label29).BackColor = Color.FromArgb(22, 106, 238);
		componentResourceManager.ApplyResources(Label29, "Label29");
		((Control)Label29).ForeColor = Color.White;
		((Control)Label29).Name = "Label29";
		((Control)Label10).BackColor = SystemColors.Control;
		componentResourceManager.ApplyResources(Label10, "Label10");
		((Control)Label10).ForeColor = Color.DimGray;
		((Control)Label10).Name = "Label10";
		BunifuPictureBox_USER.AllowFocused = false;
		componentResourceManager.ApplyResources(BunifuPictureBox_USER, "BunifuPictureBox_USER");
		BunifuPictureBox_USER.AutoSizeHeight = true;
		BunifuPictureBox_USER.BorderRadius = 45;
		((Control)BunifuPictureBox_USER).Cursor = Cursors.Hand;
		BunifuPictureBox_USER.IsCircle = true;
		((Control)BunifuPictureBox_USER).Name = "BunifuPictureBox_USER";
		((PictureBox)BunifuPictureBox_USER).TabStop = false;
		BunifuPictureBox_USER.Type = (Bunifu.UI.WinForms.BunifuPictureBox.Types)0;
		BunifuCircleProgress1.Animated = true;
		BunifuCircleProgress1.AnimationInterval = 2;
		BunifuCircleProgress1.AnimationSpeed = 1;
		((Control)BunifuCircleProgress1).BackColor = Color.Transparent;
		BunifuCircleProgress1.CircleMargin = 11;
		componentResourceManager.ApplyResources(BunifuCircleProgress1, "BunifuCircleProgress1");
		((Control)BunifuCircleProgress1).ForeColor = Color.FromArgb(64, 64, 64);
		BunifuCircleProgress1.IsPercentage = false;
		BunifuCircleProgress1.LineProgressThickness = 10;
		BunifuCircleProgress1.LineThickness = 10;
		((Control)BunifuCircleProgress1).Name = "BunifuCircleProgress1";
		BunifuCircleProgress1.ProgressAnimationSpeed = 200;
		BunifuCircleProgress1.ProgressBackColor = Color.Gainsboro;
		BunifuCircleProgress1.ProgressColor = Color.DodgerBlue;
		BunifuCircleProgress1.ProgressColor2 = Color.DodgerBlue;
		BunifuCircleProgress1.ProgressEndCap = (Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles)1;
		BunifuCircleProgress1.ProgressFillStyle = (Bunifu.UI.WinForms.BunifuCircleProgress.FillStyles)0;
		BunifuCircleProgress1.ProgressStartCap = (Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles)1;
		BunifuCircleProgress1.SecondaryFont = new Font("Microsoft Sans Serif", 16f);
		BunifuCircleProgress1.SubScriptColor = Color.FromArgb(166, 166, 166);
		BunifuCircleProgress bunifuCircleProgress = BunifuCircleProgress1;
		Padding subScriptMargin = new Padding(5, -20, 0, 0);
		bunifuCircleProgress.SubScriptMargin = subScriptMargin;
		BunifuCircleProgress1.SubScriptText = ".00";
		BunifuCircleProgress1.SuperScriptColor = Color.FromArgb(166, 166, 166);
		BunifuCircleProgress bunifuCircleProgress2 = BunifuCircleProgress1;
		subScriptMargin = new Padding(5, 20, 0, 0);
		bunifuCircleProgress2.SuperScriptMargin = subScriptMargin;
		BunifuCircleProgress1.SuperScriptText = "";
		BunifuCircleProgress bunifuCircleProgress3 = BunifuCircleProgress1;
		subScriptMargin = new Padding(0, 5, 0, 0);
		bunifuCircleProgress3.TextMargin = subScriptMargin;
		BunifuCircleProgress1.Value = 30;
		BunifuCircleProgress1.ValueByTransition = 30;
		BunifuCircleProgress bunifuCircleProgress4 = BunifuCircleProgress1;
		subScriptMargin = new Padding(0, 5, 0, 0);
		bunifuCircleProgress4.ValueMargin = subScriptMargin;
		TabPage11.BackColor = Color.FromArgb(249, 249, 249);
		((Control)TabPage11).Controls.Add((Control)(object)GroupBox_FONCTIONS);
		componentResourceManager.ApplyResources(TabPage11, "TabPage11");
		((Control)TabPage11).Name = "TabPage11";
		componentResourceManager.ApplyResources(GroupBox_FONCTIONS, "GroupBox_FONCTIONS");
		((Control)GroupBox_FONCTIONS).Controls.Add((Control)(object)Label11);
		((Control)GroupBox_FONCTIONS).Controls.Add((Control)(object)Label35);
		((Control)GroupBox_FONCTIONS).Controls.Add((Control)(object)Check_SELECT_ALL);
		((Control)GroupBox_FONCTIONS).Controls.Add((Control)(object)Label2);
		((Control)GroupBox_FONCTIONS).Controls.Add((Control)(object)Combo_CLOTURE);
		((Control)GroupBox_FONCTIONS).Controls.Add((Control)(object)Combo_OPERATION);
		((Control)GroupBox_FONCTIONS).Controls.Add((Control)(object)Label1);
		((Control)GroupBox_FONCTIONS).Controls.Add((Control)(object)Combo_CLIENTS);
		((Control)GroupBox_FONCTIONS).Controls.Add((Control)(object)Combo_REMISE);
		((Control)GroupBox_FONCTIONS).Controls.Add((Control)(object)Label55);
		((Control)GroupBox_FONCTIONS).Controls.Add((Control)(object)Label15);
		((Control)GroupBox_FONCTIONS).Controls.Add((Control)(object)Combo_DIRECTE);
		((Control)GroupBox_FONCTIONS).Controls.Add((Control)(object)Combo_MODIF_PRIX);
		((Control)GroupBox_FONCTIONS).Controls.Add((Control)(object)Label57);
		((Control)GroupBox_FONCTIONS).Controls.Add((Control)(object)Label33);
		((Control)GroupBox_FONCTIONS).Controls.Add((Control)(object)Combo_SOLDER);
		((Control)GroupBox_FONCTIONS).Controls.Add((Control)(object)Combo_MODIF_QTE);
		((Control)GroupBox_FONCTIONS).Controls.Add((Control)(object)Label58);
		((Control)GroupBox_FONCTIONS).Controls.Add((Control)(object)Label40);
		((Control)GroupBox_FONCTIONS).Controls.Add((Control)(object)Combo_ADDITION);
		((Control)GroupBox_FONCTIONS).Controls.Add((Control)(object)Combo_PRIX);
		((Control)GroupBox_FONCTIONS).Controls.Add((Control)(object)Label43);
		((Control)GroupBox_FONCTIONS).Controls.Add((Control)(object)Label41);
		((Control)GroupBox_FONCTIONS).Controls.Add((Control)(object)Combo_ARTICLES);
		((Control)GroupBox_FONCTIONS).Controls.Add((Control)(object)Combo_DIVERS);
		((Control)GroupBox_FONCTIONS).Controls.Add((Control)(object)Label45);
		((Control)GroupBox_FONCTIONS).Controls.Add((Control)(object)Label36);
		((Control)GroupBox_FONCTIONS).Controls.Add((Control)(object)Combo_DUPLICATA);
		((Control)GroupBox_FONCTIONS).Controls.Add((Control)(object)Combo_CLIENTS_REGLEMENTS);
		((Control)GroupBox_FONCTIONS).Controls.Add((Control)(object)Label44);
		((Control)GroupBox_FONCTIONS).Controls.Add((Control)(object)Label37);
		((Control)GroupBox_FONCTIONS).Controls.Add((Control)(object)Combo_FLASH);
		((Control)GroupBox_FONCTIONS).Controls.Add((Control)(object)Combo_SORTIES);
		((Control)GroupBox_FONCTIONS).Controls.Add((Control)(object)Label42);
		((Control)GroupBox_FONCTIONS).Controls.Add((Control)(object)Label38);
		((Control)GroupBox_FONCTIONS).Controls.Add((Control)(object)Combo_TIROIR);
		((Control)GroupBox_FONCTIONS).Controls.Add((Control)(object)Combo_RECEPTIONS);
		((Control)GroupBox_FONCTIONS).Controls.Add((Control)(object)Label46);
		((Control)GroupBox_FONCTIONS).Controls.Add((Control)(object)Label48);
		((Control)GroupBox_FONCTIONS).Controls.Add((Control)(object)Combo_ANNULATION);
		((Control)GroupBox_FONCTIONS).Controls.Add((Control)(object)Combo_DEPENSES);
		((Control)GroupBox_FONCTIONS).Controls.Add((Control)(object)Label47);
		((Control)GroupBox_FONCTIONS).Controls.Add((Control)(object)Label49);
		((Control)GroupBox_FONCTIONS).Controls.Add((Control)(object)Combo_RAPPORT);
		((Control)GroupBox_FONCTIONS).Controls.Add((Control)(object)Label39);
		((Control)GroupBox_FONCTIONS).Name = "GroupBox_FONCTIONS";
		componentResourceManager.ApplyResources(Check_SELECT_ALL, "Check_SELECT_ALL");
		((Control)Check_SELECT_ALL).Name = "Check_SELECT_ALL";
		((ButtonBase)Check_SELECT_ALL).UseCompatibleTextRendering = true;
		((ButtonBase)Check_SELECT_ALL).UseVisualStyleBackColor = true;
		((Control)Label2).BackColor = Color.WhiteSmoke;
		componentResourceManager.ApplyResources(Label2, "Label2");
		((Control)Label2).ForeColor = Color.FromArgb(64, 64, 64);
		((Control)Label2).Name = "Label2";
		Label2.UseCompatibleTextRendering = true;
		componentResourceManager.ApplyResources(Label39, "Label39");
		((Control)Label39).Name = "Label39";
		Label39.UseCompatibleTextRendering = true;
		Combo_CLOTURE.DropDownStyle = (ComboBoxStyle)2;
		componentResourceManager.ApplyResources(Combo_CLOTURE, "Combo_CLOTURE");
		((ListControl)Combo_CLOTURE).FormattingEnabled = true;
		Combo_CLOTURE.Items.AddRange(new object[4]
		{
			componentResourceManager.GetString("Combo_CLOTURE.Items"),
			componentResourceManager.GetString("Combo_CLOTURE.Items1"),
			componentResourceManager.GetString("Combo_CLOTURE.Items2"),
			componentResourceManager.GetString("Combo_CLOTURE.Items3")
		});
		((Control)Combo_CLOTURE).Name = "Combo_CLOTURE";
		Combo_OPERATION.DropDownStyle = (ComboBoxStyle)2;
		componentResourceManager.ApplyResources(Combo_OPERATION, "Combo_OPERATION");
		((ListControl)Combo_OPERATION).FormattingEnabled = true;
		Combo_OPERATION.Items.AddRange(new object[4]
		{
			componentResourceManager.GetString("Combo_OPERATION.Items"),
			componentResourceManager.GetString("Combo_OPERATION.Items1"),
			componentResourceManager.GetString("Combo_OPERATION.Items2"),
			componentResourceManager.GetString("Combo_OPERATION.Items3")
		});
		((Control)Combo_OPERATION).Name = "Combo_OPERATION";
		((Control)Label1).BackColor = Color.WhiteSmoke;
		componentResourceManager.ApplyResources(Label1, "Label1");
		((Control)Label1).ForeColor = Color.FromArgb(64, 64, 64);
		((Control)Label1).Name = "Label1";
		Label1.UseCompatibleTextRendering = true;
		Combo_CLIENTS.DropDownStyle = (ComboBoxStyle)2;
		componentResourceManager.ApplyResources(Combo_CLIENTS, "Combo_CLIENTS");
		((ListControl)Combo_CLIENTS).FormattingEnabled = true;
		Combo_CLIENTS.Items.AddRange(new object[4]
		{
			componentResourceManager.GetString("Combo_CLIENTS.Items"),
			componentResourceManager.GetString("Combo_CLIENTS.Items1"),
			componentResourceManager.GetString("Combo_CLIENTS.Items2"),
			componentResourceManager.GetString("Combo_CLIENTS.Items3")
		});
		((Control)Combo_CLIENTS).Name = "Combo_CLIENTS";
		Combo_REMISE.DropDownStyle = (ComboBoxStyle)2;
		componentResourceManager.ApplyResources(Combo_REMISE, "Combo_REMISE");
		((ListControl)Combo_REMISE).FormattingEnabled = true;
		Combo_REMISE.Items.AddRange(new object[4]
		{
			componentResourceManager.GetString("Combo_REMISE.Items"),
			componentResourceManager.GetString("Combo_REMISE.Items1"),
			componentResourceManager.GetString("Combo_REMISE.Items2"),
			componentResourceManager.GetString("Combo_REMISE.Items3")
		});
		((Control)Combo_REMISE).Name = "Combo_REMISE";
		((Control)Label55).BackColor = Color.WhiteSmoke;
		componentResourceManager.ApplyResources(Label55, "Label55");
		((Control)Label55).ForeColor = Color.FromArgb(64, 64, 64);
		((Control)Label55).Name = "Label55";
		Label55.UseCompatibleTextRendering = true;
		((Control)Label15).BackColor = Color.WhiteSmoke;
		componentResourceManager.ApplyResources(Label15, "Label15");
		((Control)Label15).ForeColor = Color.FromArgb(64, 64, 64);
		((Control)Label15).Name = "Label15";
		Label15.UseCompatibleTextRendering = true;
		Combo_DIRECTE.DropDownStyle = (ComboBoxStyle)2;
		componentResourceManager.ApplyResources(Combo_DIRECTE, "Combo_DIRECTE");
		((ListControl)Combo_DIRECTE).FormattingEnabled = true;
		Combo_DIRECTE.Items.AddRange(new object[4]
		{
			componentResourceManager.GetString("Combo_DIRECTE.Items"),
			componentResourceManager.GetString("Combo_DIRECTE.Items1"),
			componentResourceManager.GetString("Combo_DIRECTE.Items2"),
			componentResourceManager.GetString("Combo_DIRECTE.Items3")
		});
		((Control)Combo_DIRECTE).Name = "Combo_DIRECTE";
		Combo_MODIF_PRIX.DropDownStyle = (ComboBoxStyle)2;
		componentResourceManager.ApplyResources(Combo_MODIF_PRIX, "Combo_MODIF_PRIX");
		((ListControl)Combo_MODIF_PRIX).FormattingEnabled = true;
		Combo_MODIF_PRIX.Items.AddRange(new object[4]
		{
			componentResourceManager.GetString("Combo_MODIF_PRIX.Items"),
			componentResourceManager.GetString("Combo_MODIF_PRIX.Items1"),
			componentResourceManager.GetString("Combo_MODIF_PRIX.Items2"),
			componentResourceManager.GetString("Combo_MODIF_PRIX.Items3")
		});
		((Control)Combo_MODIF_PRIX).Name = "Combo_MODIF_PRIX";
		((Control)Label57).BackColor = Color.WhiteSmoke;
		componentResourceManager.ApplyResources(Label57, "Label57");
		((Control)Label57).ForeColor = Color.FromArgb(64, 64, 64);
		((Control)Label57).Name = "Label57";
		Label57.UseCompatibleTextRendering = true;
		((Control)Label33).BackColor = Color.WhiteSmoke;
		componentResourceManager.ApplyResources(Label33, "Label33");
		((Control)Label33).ForeColor = Color.FromArgb(64, 64, 64);
		((Control)Label33).Name = "Label33";
		Label33.UseCompatibleTextRendering = true;
		Combo_SOLDER.DropDownStyle = (ComboBoxStyle)2;
		componentResourceManager.ApplyResources(Combo_SOLDER, "Combo_SOLDER");
		((ListControl)Combo_SOLDER).FormattingEnabled = true;
		Combo_SOLDER.Items.AddRange(new object[4]
		{
			componentResourceManager.GetString("Combo_SOLDER.Items"),
			componentResourceManager.GetString("Combo_SOLDER.Items1"),
			componentResourceManager.GetString("Combo_SOLDER.Items2"),
			componentResourceManager.GetString("Combo_SOLDER.Items3")
		});
		((Control)Combo_SOLDER).Name = "Combo_SOLDER";
		Combo_MODIF_QTE.DropDownStyle = (ComboBoxStyle)2;
		componentResourceManager.ApplyResources(Combo_MODIF_QTE, "Combo_MODIF_QTE");
		((ListControl)Combo_MODIF_QTE).FormattingEnabled = true;
		Combo_MODIF_QTE.Items.AddRange(new object[4]
		{
			componentResourceManager.GetString("Combo_MODIF_QTE.Items"),
			componentResourceManager.GetString("Combo_MODIF_QTE.Items1"),
			componentResourceManager.GetString("Combo_MODIF_QTE.Items2"),
			componentResourceManager.GetString("Combo_MODIF_QTE.Items3")
		});
		((Control)Combo_MODIF_QTE).Name = "Combo_MODIF_QTE";
		((Control)Label58).BackColor = Color.WhiteSmoke;
		componentResourceManager.ApplyResources(Label58, "Label58");
		((Control)Label58).ForeColor = Color.FromArgb(64, 64, 64);
		((Control)Label58).Name = "Label58";
		Label58.UseCompatibleTextRendering = true;
		((Control)Label40).BackColor = Color.WhiteSmoke;
		componentResourceManager.ApplyResources(Label40, "Label40");
		((Control)Label40).ForeColor = Color.FromArgb(64, 64, 64);
		((Control)Label40).Name = "Label40";
		Label40.UseCompatibleTextRendering = true;
		Combo_ADDITION.DropDownStyle = (ComboBoxStyle)2;
		componentResourceManager.ApplyResources(Combo_ADDITION, "Combo_ADDITION");
		((ListControl)Combo_ADDITION).FormattingEnabled = true;
		Combo_ADDITION.Items.AddRange(new object[4]
		{
			componentResourceManager.GetString("Combo_ADDITION.Items"),
			componentResourceManager.GetString("Combo_ADDITION.Items1"),
			componentResourceManager.GetString("Combo_ADDITION.Items2"),
			componentResourceManager.GetString("Combo_ADDITION.Items3")
		});
		((Control)Combo_ADDITION).Name = "Combo_ADDITION";
		Combo_PRIX.DropDownStyle = (ComboBoxStyle)2;
		componentResourceManager.ApplyResources(Combo_PRIX, "Combo_PRIX");
		((ListControl)Combo_PRIX).FormattingEnabled = true;
		Combo_PRIX.Items.AddRange(new object[4]
		{
			componentResourceManager.GetString("Combo_PRIX.Items"),
			componentResourceManager.GetString("Combo_PRIX.Items1"),
			componentResourceManager.GetString("Combo_PRIX.Items2"),
			componentResourceManager.GetString("Combo_PRIX.Items3")
		});
		((Control)Combo_PRIX).Name = "Combo_PRIX";
		((Control)Label43).BackColor = Color.WhiteSmoke;
		componentResourceManager.ApplyResources(Label43, "Label43");
		((Control)Label43).ForeColor = Color.FromArgb(64, 64, 64);
		((Control)Label43).Name = "Label43";
		Label43.UseCompatibleTextRendering = true;
		((Control)Label41).BackColor = Color.WhiteSmoke;
		componentResourceManager.ApplyResources(Label41, "Label41");
		((Control)Label41).ForeColor = Color.FromArgb(64, 64, 64);
		((Control)Label41).Name = "Label41";
		Label41.UseCompatibleTextRendering = true;
		Combo_ARTICLES.DropDownStyle = (ComboBoxStyle)2;
		componentResourceManager.ApplyResources(Combo_ARTICLES, "Combo_ARTICLES");
		((ListControl)Combo_ARTICLES).FormattingEnabled = true;
		Combo_ARTICLES.Items.AddRange(new object[4]
		{
			componentResourceManager.GetString("Combo_ARTICLES.Items"),
			componentResourceManager.GetString("Combo_ARTICLES.Items1"),
			componentResourceManager.GetString("Combo_ARTICLES.Items2"),
			componentResourceManager.GetString("Combo_ARTICLES.Items3")
		});
		((Control)Combo_ARTICLES).Name = "Combo_ARTICLES";
		Combo_DIVERS.DropDownStyle = (ComboBoxStyle)2;
		componentResourceManager.ApplyResources(Combo_DIVERS, "Combo_DIVERS");
		((ListControl)Combo_DIVERS).FormattingEnabled = true;
		Combo_DIVERS.Items.AddRange(new object[4]
		{
			componentResourceManager.GetString("Combo_DIVERS.Items"),
			componentResourceManager.GetString("Combo_DIVERS.Items1"),
			componentResourceManager.GetString("Combo_DIVERS.Items2"),
			componentResourceManager.GetString("Combo_DIVERS.Items3")
		});
		((Control)Combo_DIVERS).Name = "Combo_DIVERS";
		((Control)Label45).BackColor = Color.WhiteSmoke;
		componentResourceManager.ApplyResources(Label45, "Label45");
		((Control)Label45).ForeColor = Color.FromArgb(64, 64, 64);
		((Control)Label45).Name = "Label45";
		Label45.UseCompatibleTextRendering = true;
		((Control)Label36).BackColor = Color.WhiteSmoke;
		componentResourceManager.ApplyResources(Label36, "Label36");
		((Control)Label36).ForeColor = Color.FromArgb(64, 64, 64);
		((Control)Label36).Name = "Label36";
		Label36.UseCompatibleTextRendering = true;
		Combo_DUPLICATA.DropDownStyle = (ComboBoxStyle)2;
		componentResourceManager.ApplyResources(Combo_DUPLICATA, "Combo_DUPLICATA");
		((ListControl)Combo_DUPLICATA).FormattingEnabled = true;
		Combo_DUPLICATA.Items.AddRange(new object[4]
		{
			componentResourceManager.GetString("Combo_DUPLICATA.Items"),
			componentResourceManager.GetString("Combo_DUPLICATA.Items1"),
			componentResourceManager.GetString("Combo_DUPLICATA.Items2"),
			componentResourceManager.GetString("Combo_DUPLICATA.Items3")
		});
		((Control)Combo_DUPLICATA).Name = "Combo_DUPLICATA";
		Combo_CLIENTS_REGLEMENTS.DropDownStyle = (ComboBoxStyle)2;
		componentResourceManager.ApplyResources(Combo_CLIENTS_REGLEMENTS, "Combo_CLIENTS_REGLEMENTS");
		((ListControl)Combo_CLIENTS_REGLEMENTS).FormattingEnabled = true;
		Combo_CLIENTS_REGLEMENTS.Items.AddRange(new object[4]
		{
			componentResourceManager.GetString("Combo_CLIENTS_REGLEMENTS.Items"),
			componentResourceManager.GetString("Combo_CLIENTS_REGLEMENTS.Items1"),
			componentResourceManager.GetString("Combo_CLIENTS_REGLEMENTS.Items2"),
			componentResourceManager.GetString("Combo_CLIENTS_REGLEMENTS.Items3")
		});
		((Control)Combo_CLIENTS_REGLEMENTS).Name = "Combo_CLIENTS_REGLEMENTS";
		((Control)Label44).BackColor = Color.WhiteSmoke;
		componentResourceManager.ApplyResources(Label44, "Label44");
		((Control)Label44).ForeColor = Color.FromArgb(64, 64, 64);
		((Control)Label44).Name = "Label44";
		Label44.UseCompatibleTextRendering = true;
		((Control)Label37).BackColor = Color.WhiteSmoke;
		componentResourceManager.ApplyResources(Label37, "Label37");
		((Control)Label37).ForeColor = Color.FromArgb(64, 64, 64);
		((Control)Label37).Name = "Label37";
		Label37.UseCompatibleTextRendering = true;
		Combo_FLASH.DropDownStyle = (ComboBoxStyle)2;
		componentResourceManager.ApplyResources(Combo_FLASH, "Combo_FLASH");
		((ListControl)Combo_FLASH).FormattingEnabled = true;
		Combo_FLASH.Items.AddRange(new object[4]
		{
			componentResourceManager.GetString("Combo_FLASH.Items"),
			componentResourceManager.GetString("Combo_FLASH.Items1"),
			componentResourceManager.GetString("Combo_FLASH.Items2"),
			componentResourceManager.GetString("Combo_FLASH.Items3")
		});
		((Control)Combo_FLASH).Name = "Combo_FLASH";
		Combo_SORTIES.DropDownStyle = (ComboBoxStyle)2;
		componentResourceManager.ApplyResources(Combo_SORTIES, "Combo_SORTIES");
		((ListControl)Combo_SORTIES).FormattingEnabled = true;
		Combo_SORTIES.Items.AddRange(new object[4]
		{
			componentResourceManager.GetString("Combo_SORTIES.Items"),
			componentResourceManager.GetString("Combo_SORTIES.Items1"),
			componentResourceManager.GetString("Combo_SORTIES.Items2"),
			componentResourceManager.GetString("Combo_SORTIES.Items3")
		});
		((Control)Combo_SORTIES).Name = "Combo_SORTIES";
		((Control)Label42).BackColor = Color.WhiteSmoke;
		componentResourceManager.ApplyResources(Label42, "Label42");
		((Control)Label42).ForeColor = Color.FromArgb(64, 64, 64);
		((Control)Label42).Name = "Label42";
		Label42.UseCompatibleTextRendering = true;
		((Control)Label38).BackColor = Color.WhiteSmoke;
		componentResourceManager.ApplyResources(Label38, "Label38");
		((Control)Label38).ForeColor = Color.FromArgb(64, 64, 64);
		((Control)Label38).Name = "Label38";
		Label38.UseCompatibleTextRendering = true;
		Combo_TIROIR.DropDownStyle = (ComboBoxStyle)2;
		componentResourceManager.ApplyResources(Combo_TIROIR, "Combo_TIROIR");
		((ListControl)Combo_TIROIR).FormattingEnabled = true;
		Combo_TIROIR.Items.AddRange(new object[4]
		{
			componentResourceManager.GetString("Combo_TIROIR.Items"),
			componentResourceManager.GetString("Combo_TIROIR.Items1"),
			componentResourceManager.GetString("Combo_TIROIR.Items2"),
			componentResourceManager.GetString("Combo_TIROIR.Items3")
		});
		((Control)Combo_TIROIR).Name = "Combo_TIROIR";
		Combo_RECEPTIONS.DropDownStyle = (ComboBoxStyle)2;
		componentResourceManager.ApplyResources(Combo_RECEPTIONS, "Combo_RECEPTIONS");
		((ListControl)Combo_RECEPTIONS).FormattingEnabled = true;
		Combo_RECEPTIONS.Items.AddRange(new object[4]
		{
			componentResourceManager.GetString("Combo_RECEPTIONS.Items"),
			componentResourceManager.GetString("Combo_RECEPTIONS.Items1"),
			componentResourceManager.GetString("Combo_RECEPTIONS.Items2"),
			componentResourceManager.GetString("Combo_RECEPTIONS.Items3")
		});
		((Control)Combo_RECEPTIONS).Name = "Combo_RECEPTIONS";
		((Control)Label46).BackColor = Color.WhiteSmoke;
		componentResourceManager.ApplyResources(Label46, "Label46");
		((Control)Label46).ForeColor = Color.FromArgb(64, 64, 64);
		((Control)Label46).Name = "Label46";
		Label46.UseCompatibleTextRendering = true;
		((Control)Label48).BackColor = Color.WhiteSmoke;
		componentResourceManager.ApplyResources(Label48, "Label48");
		((Control)Label48).ForeColor = Color.FromArgb(64, 64, 64);
		((Control)Label48).Name = "Label48";
		Label48.UseCompatibleTextRendering = true;
		Combo_ANNULATION.DropDownStyle = (ComboBoxStyle)2;
		componentResourceManager.ApplyResources(Combo_ANNULATION, "Combo_ANNULATION");
		((ListControl)Combo_ANNULATION).FormattingEnabled = true;
		Combo_ANNULATION.Items.AddRange(new object[4]
		{
			componentResourceManager.GetString("Combo_ANNULATION.Items"),
			componentResourceManager.GetString("Combo_ANNULATION.Items1"),
			componentResourceManager.GetString("Combo_ANNULATION.Items2"),
			componentResourceManager.GetString("Combo_ANNULATION.Items3")
		});
		((Control)Combo_ANNULATION).Name = "Combo_ANNULATION";
		Combo_DEPENSES.DropDownStyle = (ComboBoxStyle)2;
		componentResourceManager.ApplyResources(Combo_DEPENSES, "Combo_DEPENSES");
		((ListControl)Combo_DEPENSES).FormattingEnabled = true;
		Combo_DEPENSES.Items.AddRange(new object[4]
		{
			componentResourceManager.GetString("Combo_DEPENSES.Items"),
			componentResourceManager.GetString("Combo_DEPENSES.Items1"),
			componentResourceManager.GetString("Combo_DEPENSES.Items2"),
			componentResourceManager.GetString("Combo_DEPENSES.Items3")
		});
		((Control)Combo_DEPENSES).Name = "Combo_DEPENSES";
		((Control)Label47).BackColor = Color.WhiteSmoke;
		componentResourceManager.ApplyResources(Label47, "Label47");
		((Control)Label47).ForeColor = Color.FromArgb(64, 64, 64);
		((Control)Label47).Name = "Label47";
		Label47.UseCompatibleTextRendering = true;
		((Control)Label49).BackColor = Color.WhiteSmoke;
		componentResourceManager.ApplyResources(Label49, "Label49");
		((Control)Label49).ForeColor = Color.FromArgb(64, 64, 64);
		((Control)Label49).Name = "Label49";
		Label49.UseCompatibleTextRendering = true;
		Combo_RAPPORT.DropDownStyle = (ComboBoxStyle)2;
		componentResourceManager.ApplyResources(Combo_RAPPORT, "Combo_RAPPORT");
		((ListControl)Combo_RAPPORT).FormattingEnabled = true;
		Combo_RAPPORT.Items.AddRange(new object[4]
		{
			componentResourceManager.GetString("Combo_RAPPORT.Items"),
			componentResourceManager.GetString("Combo_RAPPORT.Items1"),
			componentResourceManager.GetString("Combo_RAPPORT.Items2"),
			componentResourceManager.GetString("Combo_RAPPORT.Items3")
		});
		((Control)Combo_RAPPORT).Name = "Combo_RAPPORT";
		((Control)Label_BOTTOM).BackColor = Color.FromArgb(22, 106, 238);
		componentResourceManager.ApplyResources(Label_BOTTOM, "Label_BOTTOM");
		((Control)Label_BOTTOM).ForeColor = Color.White;
		((Control)Label_BOTTOM).Name = "Label_BOTTOM";
		Label_BOTTOM.UseCompatibleTextRendering = true;
		((Control)Label_LEFT).BackColor = Color.FromArgb(22, 106, 238);
		componentResourceManager.ApplyResources(Label_LEFT, "Label_LEFT");
		((Control)Label_LEFT).ForeColor = Color.White;
		((Control)Label_LEFT).Name = "Label_LEFT";
		Label_LEFT.UseCompatibleTextRendering = true;
		((Control)Label_RIGHT).BackColor = Color.FromArgb(22, 106, 238);
		componentResourceManager.ApplyResources(Label_RIGHT, "Label_RIGHT");
		((Control)Label_RIGHT).ForeColor = Color.White;
		((Control)Label_RIGHT).Name = "Label_RIGHT";
		Label_RIGHT.UseCompatibleTextRendering = true;
		componentResourceManager.ApplyResources(Label_INDEX, "Label_INDEX");
		((Control)Label_INDEX).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label_INDEX).ForeColor = Color.White;
		((Control)Label_INDEX).Name = "Label_INDEX";
		Label_INDEX.UseCompatibleTextRendering = true;
		((Control)Label_TOP).BackColor = Color.FromArgb(22, 106, 238);
		componentResourceManager.ApplyResources(Label_TOP, "Label_TOP");
		((Control)Label_TOP).ForeColor = Color.White;
		((Control)Label_TOP).Name = "Label_TOP";
		Label_TOP.UseCompatibleTextRendering = true;
		((ButtonBase)Button11).BackColor = Color.FromArgb(22, 106, 238);
		componentResourceManager.ApplyResources(Button11, "Button11");
		((Control)Button11).ForeColor = Color.White;
		((Control)Button11).Name = "Button11";
		((ButtonBase)Button11).UseCompatibleTextRendering = true;
		((ButtonBase)Button11).UseVisualStyleBackColor = false;
		((ButtonBase)Button10).BackColor = Color.Red;
		componentResourceManager.ApplyResources(Button10, "Button10");
		((Control)Button10).ForeColor = Color.White;
		((Control)Button10).Name = "Button10";
		((ButtonBase)Button10).UseCompatibleTextRendering = true;
		((ButtonBase)Button10).UseVisualStyleBackColor = false;
		((DataGridViewColumn)DataGridViewImageColumn1).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)DataGridViewImageColumn1).FillWeight = 152.2843f;
		DataGridViewImageColumn1.Image = (Image)(object)Resources.Picture_SUPP_Image;
		((DataGridViewColumn)DataGridViewImageColumn1).Name = "DataGridViewImageColumn1";
		((DataGridViewColumn)DataGridViewImageColumn1).Resizable = (DataGridViewTriState)1;
		componentResourceManager.ApplyResources(DataGridViewImageColumn1, "DataGridViewImageColumn1");
		((DataGridViewColumn)DataGridViewImageColumn2).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)DataGridViewImageColumn2).FillWeight = 128.1901f;
		DataGridViewImageColumn2.Image = (Image)(object)Resources.Picture_MODIF_Image;
		((DataGridViewColumn)DataGridViewImageColumn2).Name = "DataGridViewImageColumn2";
		((DataGridViewColumn)DataGridViewImageColumn2).Resizable = (DataGridViewTriState)1;
		componentResourceManager.ApplyResources(DataGridViewImageColumn2, "DataGridViewImageColumn2");
		componentResourceManager.ApplyResources(Button8, "Button8");
		((ButtonBase)Button8).BackColor = Color.FromArgb(0, 192, 0);
		((Control)Button8).ForeColor = Color.White;
		((Control)Button8).Name = "Button8";
		((ButtonBase)Button8).UseCompatibleTextRendering = true;
		((ButtonBase)Button8).UseVisualStyleBackColor = false;
		componentResourceManager.ApplyResources(CheckBox6, "CheckBox6");
		((ButtonBase)CheckBox6).BackColor = Color.Transparent;
		((ButtonBase)CheckBox6).FlatAppearance.BorderColor = Color.DarkGray;
		((ButtonBase)CheckBox6).FlatAppearance.CheckedBackColor = Color.FromArgb(167, 197, 237);
		((Control)CheckBox6).Name = "CheckBox6";
		((ButtonBase)CheckBox6).UseCompatibleTextRendering = true;
		((ButtonBase)CheckBox6).UseVisualStyleBackColor = false;
		componentResourceManager.ApplyResources(Label11, "Label11");
		((Control)Label11).Name = "Label11";
		((Control)Label35).BackColor = Color.WhiteSmoke;
		componentResourceManager.ApplyResources(Label35, "Label35");
		((Control)Label35).ForeColor = Color.FromArgb(64, 64, 64);
		((Control)Label35).Name = "Label35";
		Label35.UseCompatibleTextRendering = true;
		componentResourceManager.ApplyResources(this, "$this");
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).BackColor = Color.WhiteSmoke;
		((Control)this).Controls.Add((Control)(object)Panel_INFO);
		((Control)this).Controls.Add((Control)(object)Button8);
		((Control)this).Controls.Add((Control)(object)CheckBox6);
		((Control)this).Controls.Add((Control)(object)DataGridView1);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "FormDialog_1_UTILISATEURS";
		((Form)this).ShowIcon = false;
		((ISupportInitialize)DataGridView1).EndInit();
		((Control)Panel_INFO).ResumeLayout(false);
		((Control)TabControl1).ResumeLayout(false);
		((Control)TabPage10).ResumeLayout(false);
		((Control)TabPage10).PerformLayout();
		((Control)FlowLayoutPanel1).ResumeLayout(false);
		((ISupportInitialize)BunifuPictureBox2732).EndInit();
		((ISupportInitialize)BunifuPictureBox1).EndInit();
		((ISupportInitialize)BunifuPictureBox3).EndInit();
		((ISupportInitialize)BunifuPictureBox13).EndInit();
		((ISupportInitialize)BunifuPictureBox25).EndInit();
		((ISupportInitialize)BunifuPictureBox7).EndInit();
		((ISupportInitialize)BunifuPictureBox15).EndInit();
		((ISupportInitialize)BunifuPictureBox10).EndInit();
		((ISupportInitialize)BunifuPictureBox18).EndInit();
		((ISupportInitialize)BunifuPictureBox2).EndInit();
		((ISupportInitialize)BunifuPictureBox8).EndInit();
		((ISupportInitialize)BunifuPictureBox16).EndInit();
		((ISupportInitialize)BunifuPictureBox24).EndInit();
		((ISupportInitialize)BunifuPictureBox).EndInit();
		((ISupportInitialize)BunifuPictureBox5).EndInit();
		((ISupportInitialize)BunifuPictureBox23).EndInit();
		((ISupportInitialize)BunifuPictureBox21).EndInit();
		((ISupportInitialize)BunifuPictureBox19).EndInit();
		((ISupportInitialize)BunifuPictureBox22).EndInit();
		((ISupportInitialize)BunifuPictureBox17).EndInit();
		((ISupportInitialize)BunifuPictureBox11).EndInit();
		((ISupportInitialize)BunifuPictureBox20).EndInit();
		((ISupportInitialize)BunifuPictureBox4).EndInit();
		((ISupportInitialize)BunifuPictureBox14).EndInit();
		((ISupportInitialize)BunifuPictureBox12).EndInit();
		((ISupportInitialize)BunifuPictureBox6).EndInit();
		((ISupportInitialize)BunifuPictureBox9).EndInit();
		((ISupportInitialize)BunifuPictureBox26).EndInit();
		((Control)Panel6).ResumeLayout(false);
		((Control)Panel6).PerformLayout();
		((ISupportInitialize)PictureBox3).EndInit();
		((Control)Panel3).ResumeLayout(false);
		((Control)Panel3).PerformLayout();
		((ISupportInitialize)PictureBox2).EndInit();
		((ISupportInitialize)BunifuPictureBox_USER).EndInit();
		((Control)TabPage11).ResumeLayout(false);
		((Control)GroupBox_FONCTIONS).ResumeLayout(false);
		((Control)GroupBox_FONCTIONS).PerformLayout();
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

	private void CheckBox6_CheckedChanged(object sender, EventArgs e)
	{
		((Control)DataGridView1).Refresh();
	}

	private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
	}

	private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		//IL_0814: Unknown result type (might be due to invalid IL or missing references)
		//IL_081b: Expected Obj, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Invalid comparison between Unknown and I4
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Expected Obj, but got Unknown
		try
		{
			if ((Operators.ConditionalCompareObjectEqual(e.ColumnIndex, Operators.SubtractObject(NewLateBinding.LateGet(sender, null, "ColumnCount", new object[0], null, null, null), 2), TextCompare: false) && e.RowIndex >= 0) ? true : false)
			{
				((Control)Panel_INFO).Hide();
				if ((int)MessageBox.Show("Voulez-vous vraiment supprimer ??", "Suppression", (MessageBoxButtons)1, (MessageBoxIcon)32, (MessageBoxDefaultButton)0) == 1)
				{
					string right = Conversions.ToString(Operators.ConcatenateObject("SUPPRESION | ", DataGridView1.Rows[((DataGridViewBand)DataGridView1.CurrentRow).Index].Cells[0].Value));
					File.AppendAllText(Application.StartupPath + "\\log.sni", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(Strings.Format(DateTime.Now, "ddMMyy HHmmss fff") + MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text, " | "), Module1._USERNAME), " | "), ((Control)this).Name), " | "), NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null)), " | "), right), "\r\n")), Encoding.UTF8);
					int position = ((ContainerControl)this).BindingContext[(object)dtt].Position;
					dtt.Rows[position].Delete();
					MySqlCommandBuilder val = new MySqlCommandBuilder(daa);
					((DbDataAdapter)(object)daa).Update(dtt);
					dtt.AcceptChanges();
					((ContainerControl)this).BindingContext[(object)dtt].Position = position;
				}
			}
			if ((Operators.ConditionalCompareObjectEqual(e.ColumnIndex, Operators.SubtractObject(NewLateBinding.LateGet(sender, null, "ColumnCount", new object[0], null, null, null), 1), TextCompare: false) && e.RowIndex >= 0) ? true : false)
			{
				((Control)Panel_INFO).Visible = true;
				Label_INDEX.Text = Conversions.ToString(((DataGridViewBand)DataGridView1.CurrentRow).Index);
				Label_TOP.Text = "MODIFICATION";
				int position2 = ((ContainerControl)this).BindingContext[(object)dtt].Position;
				Text_ID.Text = Conversions.ToString(dtt.Rows[position2]["ID"]);
				TextBox10.Text = Conversions.ToString(dtt.Rows[position2]["ListUser"]);
				TextBox25.Text = Conversions.ToString(dtt.Rows[position2]["ListPass"]);
				Label_CATEGORIE.Text = Conversions.ToString(dtt.Rows[position2]["Catégorie"]);
				Combo_OPERATION.Text = Conversions.ToString(dtt.Rows[position2]["OPERATION"]);
				Combo_REMISE.Text = Conversions.ToString(dtt.Rows[position2]["REMISE"]);
				Combo_MODIF_PRIX.Text = Conversions.ToString(dtt.Rows[position2]["MODIF_PRIX"]);
				Combo_MODIF_QTE.Text = Conversions.ToString(dtt.Rows[position2]["MODIF_QTE"]);
				Combo_PRIX.Text = Conversions.ToString(dtt.Rows[position2]["PRIX"]);
				Combo_DIVERS.Text = Conversions.ToString(dtt.Rows[position2]["DIVERS"]);
				Combo_DUPLICATA.Text = Conversions.ToString(dtt.Rows[position2]["DUPLICATA"]);
				Combo_FLASH.Text = Conversions.ToString(dtt.Rows[position2]["FLASH"]);
				Combo_TIROIR.Text = Conversions.ToString(dtt.Rows[position2]["TIROIR"]);
				Combo_ANNULATION.Text = Conversions.ToString(dtt.Rows[position2]["ANNULATION"]);
				Combo_RAPPORT.Text = Conversions.ToString(dtt.Rows[position2]["RAPPORT"]);
				Combo_DEPENSES.Text = Conversions.ToString(dtt.Rows[position2]["DEPENSES"]);
				Combo_RECEPTIONS.Text = Conversions.ToString(dtt.Rows[position2]["RECEPTIONS"]);
				Combo_SORTIES.Text = Conversions.ToString(dtt.Rows[position2]["SORTIES"]);
				Combo_CLIENTS.Text = Conversions.ToString(dtt.Rows[position2]["CLIENTS"]);
				Combo_CLIENTS_REGLEMENTS.Text = Conversions.ToString(dtt.Rows[position2]["CLIENTS_REGLEMENTS"]);
				Combo_ARTICLES.Text = Conversions.ToString(dtt.Rows[position2]["ARTICLES"]);
				Combo_DIRECTE.Text = Conversions.ToString(dtt.Rows[position2]["DIRECTE"]);
				Combo_SOLDER.Text = Conversions.ToString(dtt.Rows[position2]["SOLDER"]);
				Combo_ADDITION.Text = Conversions.ToString(dtt.Rows[position2]["ADDITION"]);
				Combo_CLOTURE.Text = Conversions.ToString(dtt.Rows[position2]["CLOTURE"]);
				if (Operators.CompareString(Label_CATEGORIE.Text, "ADMIN", TextCompare: false) == 0)
				{
					Radio_ADMIN.Checked = true;
					Radio_Click(RuntimeHelpers.GetObjectValue(sender), (EventArgs)(object)e);
				}
				else if (Operators.CompareString(Label_CATEGORIE.Text, "MANAGER", TextCompare: false) == 0)
				{
					Radio_MANAGER.Checked = true;
					Radio_Click(RuntimeHelpers.GetObjectValue(sender), (EventArgs)(object)e);
				}
				else if (Operators.CompareString(Label_CATEGORIE.Text, "UTILISATEUR", TextCompare: false) == 0)
				{
					Radio_UTILISATEUR.Checked = true;
					Radio_Click(RuntimeHelpers.GetObjectValue(sender), (EventArgs)(object)e);
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

	private void DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
		if (!CheckBox6.Checked)
		{
			if (((e.ColumnIndex != -1 && Operators.CompareString(DataGridView1.Columns[e.ColumnIndex].Name, "ListPass", TextCompare: false) == 0) ? true : false) && ((ConvertEventArgs)e).Value != null)
			{
				((ConvertEventArgs)e).Value = new string('*', ((ConvertEventArgs)e).Value.ToString().Length);
			}
		}
		else if (((e.ColumnIndex != -1 && Operators.CompareString(DataGridView1.Columns[e.ColumnIndex].Name, "ListPass", TextCompare: false) == 0) ? true : false) && ((ConvertEventArgs)e).Value != null)
		{
			((ConvertEventArgs)e).Value = RuntimeHelpers.GetObjectValue(((ConvertEventArgs)e).Value);
		}
	}

	private void Form_1_LOGIN_HandleCreated(object sender, EventArgs e)
	{
		if (Operators.CompareString(MyProject.Forms.Form_0_TEMPLATE.Label_LANGUE.Text, "ar", TextCompare: false) == 0)
		{
			Thread.CurrentThread.CurrentUICulture = new CultureInfo("ar");
			((Control)this).Controls.Clear();
			InitializeComponent();
		}
	}

	private void Form_Shown(object sender, EventArgs e)
	{
		Panel panel_INFO = Panel_INFO;
		Point location = checked(new Point((int)Math.Round((double)((Control)DataGridView1).Width / 2.0 - (double)((Control)Panel_INFO).Width / 2.0), (int)Math.Round((double)((Control)DataGridView1).Height / 2.0 - (double)((Control)Panel_INFO).Height / 2.0)));
		((Control)panel_INFO).Location = location;
	}

	private void FormDialog_UTILISATEURS_Load(object sender, EventArgs e)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected Obj, but got Unknown
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected Obj, but got Unknown
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected Obj, but got Unknown
		dtt.Clear();
		daa = new MySqlDataAdapter("select * from      TABLE_PASS      order by Catégorie asc ", Module1.cn_SQL);
		((DbDataAdapter)(object)daa).Fill(dtt);
		DataGridView1.AutoGenerateColumns = false;
		DataGridView1.RowTemplate.Height = 35;
		DataGridView1.DataSource = dtt;
		DataGridView1.BackgroundColor = Color.White;
		DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(34, 34, 34);
		DataGridView1.DefaultCellStyle.SelectionBackColor = Color.Yellow;
		DataGridView1.DefaultCellStyle.SelectionForeColor = Color.Red;
		DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(221, 235, 247);
		DataGridView1.GridColor = Color.FromArgb(231, 231, 231);
		DataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11f, (FontStyle)1);
		DataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 11f, (FontStyle)0);
		DataGridView1.ColumnHeadersBorderStyle = (DataGridViewHeaderBorderStyle)1;
		DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = (DataGridViewContentAlignment)16;
		DataGridView1.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)0;
		DataGridView1.AutoResizeColumnHeadersHeight();
		DataGridView1.CellBorderStyle = (DataGridViewCellBorderStyle)5;
		DataGridView1.SelectionMode = (DataGridViewSelectionMode)1;
		DataGridView1.MultiSelect = true;
		DataGridView1.EditMode = (DataGridViewEditMode)4;
		DataGridView1.ClipboardCopyMode = (DataGridViewClipboardCopyMode)0;
		checked
		{
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
			TabControl1.SizeMode = (TabSizeMode)2;
			TabControl tabControl = TabControl1;
			Size itemSize = new Size((int)Math.Round((double)((Control)TabControl1).Width / (double)TabControl1.TabCount - 4.0), 30);
			tabControl.ItemSize = itemSize;
		}
	}

	private void Button11_Click(object sender, EventArgs e)
	{
		//IL_0cca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd1: Expected Obj, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected Obj, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected Obj, but got Unknown
		//IL_069c: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a3: Expected Obj, but got Unknown
		//IL_06fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0704: Expected Obj, but got Unknown
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected Obj, but got Unknown
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_079b: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a2: Expected Obj, but got Unknown
		//IL_0734: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05de: Expected Obj, but got Unknown
		//IL_060a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf1: Expected Obj, but got Unknown
		//IL_0c1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d2: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			try
			{
				if (Operators.CompareString(TextBox10.Text, "", TextCompare: false) == 0)
				{
					MessageBox.Show("Veuillez remplir le champ -User- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
				if (Operators.CompareString(TextBox25.Text, "", TextCompare: false) == 0)
				{
					MessageBox.Show("Veuillez remplir le champ -Pass- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
				if (Operators.CompareString(Label_CATEGORIE.Text, "", TextCompare: false) == 0)
				{
					MessageBox.Show("Veuillez remplir le champ -Catégorie- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
				if (Operators.CompareString(Label_TOP.Text, "NOUVEAU", TextCompare: false) == 0)
				{
					DataTable dataTable = new DataTable();
					MySqlDataAdapter val = new MySqlDataAdapter();
					dataTable.Clear();
					val = new MySqlDataAdapter("select ID,ListUser     from TABLE_PASS WHERE   ListUser = '" + TextBox10.Text + "'", Module1.cn_SQL);
					((DbDataAdapter)(object)val).Fill(dataTable);
					if (dataTable.Rows.Count != 0)
					{
						MessageBox.Show("Ce Code est déja utilisé", "Attetion", (MessageBoxButtons)0, (MessageBoxIcon)48, (MessageBoxDefaultButton)0);
						return;
					}
					dataTable.Clear();
					val = new MySqlDataAdapter("select ID,ListPass     from TABLE_PASS WHERE   ListPass = '" + TextBox25.Text + "'", Module1.cn_SQL);
					((DbDataAdapter)(object)val).Fill(dataTable);
					if (dataTable.Rows.Count != 0)
					{
						MessageBox.Show("Ce Code est déja utilisé", "Attetion", (MessageBoxButtons)0, (MessageBoxIcon)48, (MessageBoxDefaultButton)0);
						return;
					}
					dtt.Rows.Add();
					int index = dtt.Rows.Count - 1;
					dtt.Rows[index]["ID"] = Text_ID.Text;
					dtt.Rows[index]["ID_USER"] = Strings.Format(DateTime.Now, "ddMMyyHHmmssfff");
					dtt.Rows[index]["ListUser"] = Strings.Trim(TextBox10.Text);
					dtt.Rows[index]["ListPass"] = TextBox25.Text;
					dtt.Rows[index]["Catégorie"] = Label_CATEGORIE.Text;
					dtt.Rows[index]["OPERATION"] = Combo_OPERATION.Text;
					dtt.Rows[index]["REMISE"] = Combo_REMISE.Text;
					dtt.Rows[index]["MODIF_PRIX"] = Combo_MODIF_PRIX.Text;
					dtt.Rows[index]["MODIF_QTE"] = Combo_MODIF_QTE.Text;
					dtt.Rows[index]["PRIX"] = Combo_PRIX.Text;
					dtt.Rows[index]["DIVERS"] = Combo_DIVERS.Text;
					dtt.Rows[index]["DUPLICATA"] = Combo_DUPLICATA.Text;
					dtt.Rows[index]["FLASH"] = Combo_FLASH.Text;
					dtt.Rows[index]["TIROIR"] = Combo_TIROIR.Text;
					dtt.Rows[index]["ANNULATION"] = Combo_ANNULATION.Text;
					dtt.Rows[index]["RAPPORT"] = Combo_RAPPORT.Text;
					dtt.Rows[index]["DEPENSES"] = Combo_DEPENSES.Text;
					dtt.Rows[index]["RECEPTIONS"] = Combo_RECEPTIONS.Text;
					dtt.Rows[index]["SORTIES"] = Combo_SORTIES.Text;
					dtt.Rows[index]["CLIENTS"] = Combo_CLIENTS.Text;
					dtt.Rows[index]["CLIENTS_REGLEMENTS"] = Combo_CLIENTS_REGLEMENTS.Text;
					dtt.Rows[index]["ARTICLES"] = Combo_ARTICLES.Text;
					dtt.Rows[index]["DIRECTE"] = Combo_DIRECTE.Text;
					dtt.Rows[index]["SOLDER"] = Combo_SOLDER.Text;
					dtt.Rows[index]["ADDITION"] = Combo_ADDITION.Text;
					dtt.Rows[index]["CLOTURE"] = Combo_CLOTURE.Text;
					MySqlCommandBuilder val2 = new MySqlCommandBuilder(daa);
					((DbDataAdapter)(object)daa).Update(dtt);
					dtt.AcceptChanges();
					MessageBox.Show("Enregistré avec succès", "ok", (MessageBoxButtons)0, (MessageBoxIcon)64, (MessageBoxDefaultButton)0);
				}
				else if (Operators.CompareString(Label_TOP.Text, "MODIFICATION", TextCompare: false) == 0)
				{
					DataGridView1.CurrentCell = DataGridView1.Rows[Conversions.ToInteger(Label_INDEX.Text)].Cells[0];
					DataGridView1.Rows[Conversions.ToInteger(Label_INDEX.Text)].Selected = true;
					DataTable dataTable2 = new DataTable();
					MySqlDataAdapter val3 = new MySqlDataAdapter();
					dataTable2.Clear();
					val3 = new MySqlDataAdapter("select ID,ListUser     from TABLE_PASS WHERE   ListUser = '" + TextBox10.Text + "'   AND    ID <> " + Text_ID.Text + "    ", Module1.cn_SQL);
					((DbDataAdapter)(object)val3).Fill(dataTable2);
					if (dataTable2.Rows.Count != 0)
					{
						MessageBox.Show("Ce Code est déja utilisé", "Attetion", (MessageBoxButtons)0, (MessageBoxIcon)48, (MessageBoxDefaultButton)0);
						return;
					}
					dataTable2.Clear();
					val3 = new MySqlDataAdapter("select ID,ListPass     from TABLE_PASS WHERE   ListPass = '" + TextBox25.Text + "'   AND    ID <> " + Text_ID.Text + "    ", Module1.cn_SQL);
					((DbDataAdapter)(object)val3).Fill(dataTable2);
					if (dataTable2.Rows.Count != 0)
					{
						MessageBox.Show("Ce Code est déja utilisé", "Attetion", (MessageBoxButtons)0, (MessageBoxIcon)48, (MessageBoxDefaultButton)0);
						return;
					}
					int position = ((ContainerControl)this).BindingContext[(object)dtt].Position;
					dtt.Rows[position]["ID"] = Text_ID.Text;
					dtt.Rows[position]["ListUser"] = Strings.Trim(TextBox10.Text);
					dtt.Rows[position]["ListPass"] = TextBox25.Text;
					dtt.Rows[position]["Catégorie"] = Label_CATEGORIE.Text;
					dtt.Rows[position]["OPERATION"] = Combo_OPERATION.Text;
					dtt.Rows[position]["REMISE"] = Combo_REMISE.Text;
					dtt.Rows[position]["MODIF_PRIX"] = Combo_MODIF_PRIX.Text;
					dtt.Rows[position]["MODIF_QTE"] = Combo_MODIF_QTE.Text;
					dtt.Rows[position]["PRIX"] = Combo_PRIX.Text;
					dtt.Rows[position]["DIVERS"] = Combo_DIVERS.Text;
					dtt.Rows[position]["DUPLICATA"] = Combo_DUPLICATA.Text;
					dtt.Rows[position]["FLASH"] = Combo_FLASH.Text;
					dtt.Rows[position]["TIROIR"] = Combo_TIROIR.Text;
					dtt.Rows[position]["ANNULATION"] = Combo_ANNULATION.Text;
					dtt.Rows[position]["RAPPORT"] = Combo_RAPPORT.Text;
					dtt.Rows[position]["DEPENSES"] = Combo_DEPENSES.Text;
					dtt.Rows[position]["RECEPTIONS"] = Combo_RECEPTIONS.Text;
					dtt.Rows[position]["SORTIES"] = Combo_SORTIES.Text;
					dtt.Rows[position]["CLIENTS"] = Combo_CLIENTS.Text;
					dtt.Rows[position]["CLIENTS_REGLEMENTS"] = Combo_CLIENTS_REGLEMENTS.Text;
					dtt.Rows[position]["ARTICLES"] = Combo_ARTICLES.Text;
					dtt.Rows[position]["DIRECTE"] = Combo_DIRECTE.Text;
					dtt.Rows[position]["SOLDER"] = Combo_SOLDER.Text;
					dtt.Rows[position]["ADDITION"] = Combo_ADDITION.Text;
					dtt.Rows[position]["CLOTURE"] = Combo_CLOTURE.Text;
					MySqlCommandBuilder val4 = new MySqlCommandBuilder(daa);
					((DbDataAdapter)(object)daa).Update(dtt);
					dtt.AcceptChanges();
					MessageBox.Show("Modifié avec succès", "ok", (MessageBoxButtons)0, (MessageBoxIcon)64, (MessageBoxDefaultButton)0);
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

	private void Button10_Click(object sender, EventArgs e)
	{
		((Control)Panel_INFO).Visible = false;
	}

	private void Button8_Click(object sender, EventArgs e)
	{
		//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Expected Obj, but got Unknown
		checked
		{
			try
			{
				((Control)Panel_INFO).Visible = true;
				((Control)Panel_INFO).BringToFront();
				Label_TOP.Text = "NOUVEAU";
				int num = dtt.Rows.Count - 1;
				int num2 = 0;
				int num5 = default;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					if (Operators.ConditionalCompareObjectGreater(dtt.Rows[num2]["ID"], num5, TextCompare: false))
					{
						num5 = Conversions.ToInteger(dtt.Rows[num2]["ID"]);
					}
					num2++;
				}
				Text_ID.Text = Conversions.ToString(num5 + 1);
				TextBox10.Text = "";
				TextBox25.Text = "";
				Label_CATEGORIE.Text = "";
				Radio_ADMIN.Checked = false;
				Radio_MANAGER.Checked = false;
				Radio_UTILISATEUR.Checked = false;
				Combo_OPERATION.Text = null;
				Combo_REMISE.Text = null;
				Combo_MODIF_PRIX.Text = null;
				Combo_MODIF_QTE.Text = null;
				Combo_PRIX.Text = null;
				Combo_DIVERS.Text = null;
				Combo_DUPLICATA.Text = null;
				Combo_FLASH.Text = null;
				Combo_TIROIR.Text = null;
				Combo_ANNULATION.Text = null;
				Combo_RAPPORT.Text = null;
				Combo_DEPENSES.Text = null;
				Combo_RECEPTIONS.Text = null;
				Combo_SORTIES.Text = null;
				Combo_CLIENTS.Text = null;
				Combo_CLIENTS_REGLEMENTS.Text = null;
				Combo_ARTICLES.Text = null;
				Combo_ADDITION.Text = null;
				Combo_SOLDER.Text = null;
				Combo_DIRECTE.Text = null;
				Combo_CLOTURE.Text = null;
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

	private void CheckBox12_CheckedChanged(object sender, EventArgs e)
	{
		if (CheckBox12.Checked)
		{
			TextBox25.PasswordChar = '\0';
		}
		else if (!CheckBox12.Checked)
		{
			TextBox25.PasswordChar = '●';
		}
		((Control)TextBox25).Focus();
	}

	private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	private void Check_SELECT_ALL_CheckedChanged(object sender, EventArgs e)
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected Obj, but got Unknown
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected Obj, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		if (Check_SELECT_ALL.Checked)
		{
			foreach (Control control in ((Control)GroupBox_FONCTIONS).Controls)
			{
				Control val = control;
				if (val is ComboBox)
				{
					((ComboBox)val).Text = "VISIBLE";
				}
			}
		}
		if (Check_SELECT_ALL.Checked)
		{
			return;
		}
		foreach (Control control2 in ((Control)GroupBox_FONCTIONS).Controls)
		{
			Control val2 = control2;
			if (val2 is ComboBox)
			{
				((ComboBox)val2).Text = "INVISIBLE";
			}
		}
	}

	private void Button26_Click(object sender, EventArgs e)
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

	private void Radio_ADMIN_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void Radio_Click(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, null, "text", new object[0], null, null, null), "ADMIN", TextCompare: false))
		{
			Label_CATEGORIE.Text = Conversions.ToString(NewLateBinding.LateGet(sender, null, "text", new object[0], null, null, null));
			Combo_OPERATION.Text = "VISIBLE";
			Combo_REMISE.Text = "VISIBLE";
			Combo_MODIF_PRIX.Text = "VISIBLE";
			Combo_MODIF_QTE.Text = "VISIBLE";
			Combo_PRIX.Text = "VISIBLE";
			Combo_DIVERS.Text = "VISIBLE";
			Combo_DUPLICATA.Text = "VISIBLE";
			Combo_FLASH.Text = "VISIBLE";
			Combo_TIROIR.Text = "VISIBLE";
			Combo_ANNULATION.Text = "VISIBLE";
			Combo_RAPPORT.Text = "VISIBLE";
			Combo_DEPENSES.Text = "VISIBLE";
			Combo_RECEPTIONS.Text = "VISIBLE";
			Combo_SORTIES.Text = "VISIBLE";
			Combo_CLIENTS.Text = "VISIBLE";
			Combo_CLIENTS_REGLEMENTS.Text = "VISIBLE";
			Combo_ARTICLES.Text = "VISIBLE";
			Combo_ADDITION.Text = "VISIBLE";
			Combo_SOLDER.Text = "VISIBLE";
			Combo_DIRECTE.Text = "VISIBLE";
			Combo_CLOTURE.Text = "VISIBLE";
		}
		else if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, null, "text", new object[0], null, null, null), "MANAGER", TextCompare: false))
		{
			Label_CATEGORIE.Text = Conversions.ToString(NewLateBinding.LateGet(sender, null, "text", new object[0], null, null, null));
			Combo_OPERATION.Text = "VISIBLE";
			Combo_REMISE.Text = "VISIBLE";
			Combo_MODIF_PRIX.Text = "VISIBLE";
			Combo_MODIF_QTE.Text = "VISIBLE";
			Combo_PRIX.Text = "VISIBLE";
			Combo_DIVERS.Text = "VISIBLE";
			Combo_DUPLICATA.Text = "VISIBLE";
			Combo_FLASH.Text = "VISIBLE";
			Combo_TIROIR.Text = "VISIBLE";
			Combo_ANNULATION.Text = "VISIBLE";
			Combo_RAPPORT.Text = "VISIBLE";
			Combo_DEPENSES.Text = "INVISIBLE";
			Combo_RECEPTIONS.Text = "INVISIBLE";
			Combo_SORTIES.Text = "INVISIBLE";
			Combo_CLIENTS.Text = "INVISIBLE";
			Combo_CLIENTS_REGLEMENTS.Text = "INVISIBLE";
			Combo_ARTICLES.Text = "INVISIBLE";
			Combo_ADDITION.Text = "VISIBLE";
			Combo_SOLDER.Text = "VISIBLE";
			Combo_DIRECTE.Text = "VISIBLE";
			Combo_CLOTURE.Text = "VISIBLE";
		}
		else if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, null, "text", new object[0], null, null, null), "UTILISATEUR", TextCompare: false))
		{
			Label_CATEGORIE.Text = Conversions.ToString(NewLateBinding.LateGet(sender, null, "text", new object[0], null, null, null));
			Combo_OPERATION.Text = "VISIBLE";
			Combo_REMISE.Text = "INVISIBLE";
			Combo_MODIF_PRIX.Text = "INVISIBLE";
			Combo_MODIF_QTE.Text = "INVISIBLE";
			Combo_PRIX.Text = "INVISIBLE";
			Combo_DIVERS.Text = "INVISIBLE";
			Combo_DUPLICATA.Text = "INVISIBLE";
			Combo_FLASH.Text = "INVISIBLE";
			Combo_TIROIR.Text = "INVISIBLE";
			Combo_ANNULATION.Text = "VISIBLE";
			Combo_RAPPORT.Text = "VISIBLE";
			Combo_DEPENSES.Text = "INVISIBLE";
			Combo_RECEPTIONS.Text = "INVISIBLE";
			Combo_SORTIES.Text = "INVISIBLE";
			Combo_CLIENTS.Text = "INVISIBLE";
			Combo_CLIENTS_REGLEMENTS.Text = "INVISIBLE";
			Combo_ARTICLES.Text = "INVISIBLE";
			Combo_ADDITION.Text = "VISIBLE";
			Combo_SOLDER.Text = "VISIBLE";
			Combo_DIRECTE.Text = "VISIBLE";
			Combo_CLOTURE.Text = "INVISIBLE";
		}
	}

	private void TabPage10_Click(object sender, EventArgs e)
	{
	}

	private void FlowLayout_USER_Paint(object sender, PaintEventArgs e)
	{
	}

	private void BunifuPictureBox_USER_Click(object sender, EventArgs e)
	{
		((Control)FlowLayoutPanel1).BringToFront();
		((Control)FlowLayoutPanel1).Visible = true;
		FlowLayoutPanel flowLayoutPanel = FlowLayoutPanel1;
		Point point = new Point(637, 364);
		((Control)flowLayoutPanel).Size = (Size)point;
	}

	private void BunifuPictureBox27_Click(object sender, EventArgs e)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected Obj, but got Unknown
		((PictureBox)BunifuPictureBox_USER).Image = (Image)NewLateBinding.LateGet(sender, null, "image", new object[0], null, null, null);
		((Control)FlowLayoutPanel1).Visible = false;
	}

	private void BunifuPictureBox3_Click(object sender, EventArgs e)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected Obj, but got Unknown
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Invalid comparison between Unknown and I4
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected Obj, but got Unknown
		int try0001_dispatch = -1;
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
					OpenFileDialog val = new OpenFileDialog();
					if ((int)((CommonDialog)val).ShowDialog() == 1)
					{
						((PictureBox)BunifuPictureBox_USER).Image = Image.FromFile(((FileDialog)val).FileName);
						Bitmap val2 = new Bitmap(((Control)BunifuPictureBox_USER).Size.Width, ((Control)BunifuPictureBox_USER).Size.Height);
						BunifuPictureBox bunifuPictureBox_USER = BunifuPictureBox_USER;
						Rectangle rectangle = new Rectangle(0, 0, ((Control)BunifuPictureBox_USER).Width, ((Control)BunifuPictureBox_USER).Height);
						((Control)bunifuPictureBox_USER).DrawToBitmap(val2, rectangle);
						((PictureBox)BunifuPictureBox_USER).Image = (Image)(object)val2;
						Text_LIEN_PICTURE.Text = DateTime.Now.ToString("dd-MM-yyy HH-mm-ss-fffffff") + ".png";
					}
					((Control)FlowLayoutPanel1).Visible = false;
					goto end_IL_0001;
				}
				case 242:
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
				try0001_dispatch = 242;
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
