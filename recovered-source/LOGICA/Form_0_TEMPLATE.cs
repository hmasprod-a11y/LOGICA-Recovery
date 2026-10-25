using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Management;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using LOGICA.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using MySql.Data.MySqlClient;

namespace LOGICA;

[DesignerGenerated]
public class Form_0_TEMPLATE : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Panel_HOME")]
	private Panel _Panel_HOME;

	[AccessedThroughProperty("Panel_STATUT")]
	private Panel _Panel_STATUT;

	[AccessedThroughProperty("Label_CONNEXION")]
	private Label _Label_CONNEXION;

	[AccessedThroughProperty("Label_DB")]
	private Label _Label_DB;

	[AccessedThroughProperty("Label_DATE")]
	private Label _Label_DATE;

	[AccessedThroughProperty("Timer1")]
	private System.Windows.Forms.Timer _Timer1;

	[AccessedThroughProperty("Label_POSTE")]
	private Label _Label_POSTE;

	[AccessedThroughProperty("Label_USERNAME")]
	private Label _Label_USERNAME;

	[AccessedThroughProperty("Label_USERCATEGORIE")]
	private Label _Label_USERCATEGORIE;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	[AccessedThroughProperty("Label_FOLDER")]
	private Label _Label_FOLDER;

	[AccessedThroughProperty("Panel_clé")]
	private Panel _Panel_clé;

	[AccessedThroughProperty("Panel2")]
	private Panel _Panel2;

	[AccessedThroughProperty("Label11")]
	private Label _Label11;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	[AccessedThroughProperty("Button_coller")]
	private Button _Button_coller;

	[AccessedThroughProperty("MaskedText_acti")]
	private MaskedTextBox _MaskedText_acti;

	[AccessedThroughProperty("Button_copier")]
	private Button _Button_copier;

	[AccessedThroughProperty("Button_ok")]
	private Button _Button_ok;

	[AccessedThroughProperty("Text_ara_disk")]
	private TextBox _Text_ara_disk;

	[AccessedThroughProperty("Text_ara_reg")]
	private TextBox _Text_ara_reg;

	[AccessedThroughProperty("Label13")]
	private Label _Label13;

	[AccessedThroughProperty("Label12")]
	private Label _Label12;

	[AccessedThroughProperty("PictureBox100")]
	private PictureBox _PictureBox100;

	[AccessedThroughProperty("Button_end")]
	private Button _Button_end;

	[AccessedThroughProperty("TableLayoutPanel1")]
	private TableLayoutPanel _TableLayoutPanel1;

	[AccessedThroughProperty("Panel_FICHE")]
	private Panel _Panel_FICHE;

	[AccessedThroughProperty("TextBox2")]
	private TextBox _TextBox2;

	[AccessedThroughProperty("TextBox3")]
	private TextBox _TextBox3;

	[AccessedThroughProperty("Panel_TENTATIVE_CONNEXION")]
	private Panel _Panel_TENTATIVE_CONNEXION;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("PictureBox5")]
	private PictureBox _PictureBox5;

	[AccessedThroughProperty("PictureBox4")]
	private PictureBox _PictureBox4;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Panel5")]
	private Panel _Panel5;

	[AccessedThroughProperty("Text_SOLUTION")]
	private TextBox _Text_SOLUTION;

	[AccessedThroughProperty("Button1212")]
	private Button _Button1212;

	[AccessedThroughProperty("Label_GESTION_TABLE")]
	private Label _Label_GESTION_TABLE;

	[AccessedThroughProperty("Panel_CLAVIER")]
	private Panel _Panel_CLAVIER;

	[AccessedThroughProperty("TableLayoutPanel2")]
	private TableLayoutPanel _TableLayoutPanel2;

	[AccessedThroughProperty("Butt_DOT")]
	private Button_CLAVIER_NOSELECT _Butt_DOT;

	[AccessedThroughProperty("Butt_1")]
	private Button_CLAVIER_NOSELECT _Butt_1;

	[AccessedThroughProperty("Butt_2")]
	private Button_CLAVIER_NOSELECT _Butt_2;

	[AccessedThroughProperty("Butt_N")]
	private Button_CLAVIER_NOSELECT _Butt_N;

	[AccessedThroughProperty("Butt_3")]
	private Button_CLAVIER_NOSELECT _Butt_3;

	[AccessedThroughProperty("Butt_B")]
	private Button_CLAVIER_NOSELECT _Butt_B;

	[AccessedThroughProperty("Butt_4")]
	private Button_CLAVIER_NOSELECT _Butt_4;

	[AccessedThroughProperty("Butt_V")]
	private Button_CLAVIER_NOSELECT _Butt_V;

	[AccessedThroughProperty("Butt_5")]
	private Button_CLAVIER_NOSELECT _Butt_5;

	[AccessedThroughProperty("Butt_C")]
	private Button_CLAVIER_NOSELECT _Butt_C;

	[AccessedThroughProperty("Butt_6")]
	private Button_CLAVIER_NOSELECT _Butt_6;

	[AccessedThroughProperty("Butt_X")]
	private Button_CLAVIER_NOSELECT _Butt_X;

	[AccessedThroughProperty("Butt_7")]
	private Button_CLAVIER_NOSELECT _Butt_7;

	[AccessedThroughProperty("Butt_W")]
	private Button_CLAVIER_NOSELECT _Butt_W;

	[AccessedThroughProperty("Butt_8")]
	private Button_CLAVIER_NOSELECT _Butt_8;

	[AccessedThroughProperty("Butt_9")]
	private Button_CLAVIER_NOSELECT _Butt_9;

	[AccessedThroughProperty("Butt_0")]
	private Button_CLAVIER_NOSELECT _Butt_0;

	[AccessedThroughProperty("Butt_M")]
	private Button_CLAVIER_NOSELECT _Butt_M;

	[AccessedThroughProperty("Butt_A")]
	private Button_CLAVIER_NOSELECT _Butt_A;

	[AccessedThroughProperty("Butt_L")]
	private Button_CLAVIER_NOSELECT _Butt_L;

	[AccessedThroughProperty("Butt_Z")]
	private Button_CLAVIER_NOSELECT _Butt_Z;

	[AccessedThroughProperty("Butt_K")]
	private Button_CLAVIER_NOSELECT _Butt_K;

	[AccessedThroughProperty("Butt_E")]
	private Button_CLAVIER_NOSELECT _Butt_E;

	[AccessedThroughProperty("Butt_J")]
	private Button_CLAVIER_NOSELECT _Butt_J;

	[AccessedThroughProperty("Butt_R")]
	private Button_CLAVIER_NOSELECT _Butt_R;

	[AccessedThroughProperty("Butt_H")]
	private Button_CLAVIER_NOSELECT _Butt_H;

	[AccessedThroughProperty("Butt_T")]
	private Button_CLAVIER_NOSELECT _Butt_T;

	[AccessedThroughProperty("Butt_G")]
	private Button_CLAVIER_NOSELECT _Butt_G;

	[AccessedThroughProperty("Butt_Y")]
	private Button_CLAVIER_NOSELECT _Butt_Y;

	[AccessedThroughProperty("Butt_F")]
	private Button_CLAVIER_NOSELECT _Butt_F;

	[AccessedThroughProperty("Butt_U")]
	private Button_CLAVIER_NOSELECT _Butt_U;

	[AccessedThroughProperty("Butt_D")]
	private Button_CLAVIER_NOSELECT _Butt_D;

	[AccessedThroughProperty("Butt_I")]
	private Button_CLAVIER_NOSELECT _Butt_I;

	[AccessedThroughProperty("Butt_S")]
	private Button_CLAVIER_NOSELECT _Butt_S;

	[AccessedThroughProperty("Butt_O")]
	private Button_CLAVIER_NOSELECT _Butt_O;

	[AccessedThroughProperty("Butt_Q")]
	private Button_CLAVIER_NOSELECT _Butt_Q;

	[AccessedThroughProperty("Butt_P")]
	private Button_CLAVIER_NOSELECT _Butt_P;

	[AccessedThroughProperty("Butt_BACK")]
	private Button_CLAVIER_NOSELECT _Butt_BACK;

	[AccessedThroughProperty("Butt_DRAFT")]
	private Button_CLAVIER_NOSELECT _Butt_DRAFT;

	[AccessedThroughProperty("TableLayoutPanel3")]
	private TableLayoutPanel _TableLayoutPanel3;

	[AccessedThroughProperty("Butt_SPACE")]
	private Button_CLAVIER_NOSELECT _Butt_SPACE;

	[AccessedThroughProperty("RichText_insc")]
	private RichTextBox _RichText_insc;

	[AccessedThroughProperty("LinkLabel1")]
	private LinkLabel _LinkLabel1;

	[AccessedThroughProperty("Picture_ALERT")]
	private PictureBox _Picture_ALERT;

	[AccessedThroughProperty("Label_CONNEXION_STATUT")]
	private Label _Label_CONNEXION_STATUT;

	[AccessedThroughProperty("Label_LANGUE")]
	private Label _Label_LANGUE;

	[AccessedThroughProperty("Button_CLAVIER")]
	private Button_CLAVIER_NOSELECT _Button_CLAVIER;

	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	[AccessedThroughProperty("TextBox_MODE_WINDOWS")]
	private TextBox _TextBox_MODE_WINDOWS;

	[AccessedThroughProperty("TextBox_COMPOSITION_AUTO")]
	private TextBox _TextBox_COMPOSITION_AUTO;

	[AccessedThroughProperty("TextBox_BRANCHEMENT")]
	private TextBox _TextBox_BRANCHEMENT;

	[AccessedThroughProperty("ListView1")]
	private ListView _ListView1;

	[AccessedThroughProperty("OBJET")]
	private ColumnHeader _OBJET;

	[AccessedThroughProperty("VALEUR")]
	private ColumnHeader _VALEUR;

	[AccessedThroughProperty("PictureBox_SORTIE")]
	private PictureBox _PictureBox_SORTIE;

	[AccessedThroughProperty("PictureBox6")]
	private PictureBox _PictureBox6;

	[AccessedThroughProperty("Picture_EMPORTER")]
	private PictureBox _Picture_EMPORTER;

	[AccessedThroughProperty("Picture_LIVRAISON")]
	private PictureBox _Picture_LIVRAISON;

	[AccessedThroughProperty("Picture_MOVE")]
	private PictureBox _Picture_MOVE;

	[AccessedThroughProperty("Picture_CONS")]
	private PictureBox _Picture_CONS;

	[AccessedThroughProperty("Picture_PRINT")]
	private PictureBox _Picture_PRINT;

	[AccessedThroughProperty("Picture_PDF")]
	private PictureBox _Picture_PDF;

	[AccessedThroughProperty("Picture_SUPP")]
	private PictureBox _Picture_SUPP;

	[AccessedThroughProperty("Picture_DESACTIVER")]
	private PictureBox _Picture_DESACTIVER;

	[AccessedThroughProperty("Picture_MODIF")]
	private PictureBox _Picture_MODIF;

	[AccessedThroughProperty("Button1323234")]
	private Button _Button1323234;

	[AccessedThroughProperty("Label_ERREUR")]
	private Label _Label_ERREUR;

	public Bitmap logo_ar_login;

	public Bitmap logo_ar_vente;

	public Bitmap logo_ar_vente_logo;

	internal virtual Panel Panel_HOME
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel_HOME;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			EventHandler eventHandler = Panel_HOME_DoubleClick;
			PaintEventHandler val = Panel_HOME_Paint;
			if (_Panel_HOME != null)
			{
				((Control)_Panel_HOME).DoubleClick -= eventHandler;
				((Control)_Panel_HOME).Paint -= val;
			}
			_Panel_HOME = value;
			if (_Panel_HOME != null)
			{
				((Control)_Panel_HOME).DoubleClick += eventHandler;
				((Control)_Panel_HOME).Paint += val;
			}
		}
	}

	internal virtual Panel Panel_STATUT
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel_STATUT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel_STATUT = value;
		}
	}

	internal virtual Label Label_CONNEXION
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_CONNEXION;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_CONNEXION = value;
		}
	}

	internal virtual Label Label_DB
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_DB;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Label_DB_DoubleClick;
			EventHandler eventHandler2 = Label_DB_Click;
			if (_Label_DB != null)
			{
				((Control)_Label_DB).DoubleClick -= eventHandler;
				((Control)_Label_DB).Click -= eventHandler2;
			}
			_Label_DB = value;
			if (_Label_DB != null)
			{
				((Control)_Label_DB).DoubleClick += eventHandler;
				((Control)_Label_DB).Click += eventHandler2;
			}
		}
	}

	internal virtual Label Label_DATE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_DATE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_DATE = value;
		}
	}

	internal virtual System.Windows.Forms.Timer Timer1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer1_Tick;
			if (_Timer1 != null)
			{
				_Timer1.Tick -= eventHandler;
			}
			_Timer1 = value;
			if (_Timer1 != null)
			{
				_Timer1.Tick += eventHandler;
			}
		}
	}

	internal virtual Label Label_POSTE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_POSTE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Label_POSTE_DoubleClick;
			EventHandler eventHandler2 = Label_POSTE_Click;
			if (_Label_POSTE != null)
			{
				((Control)_Label_POSTE).DoubleClick -= eventHandler;
				((Control)_Label_POSTE).Click -= eventHandler2;
			}
			_Label_POSTE = value;
			if (_Label_POSTE != null)
			{
				((Control)_Label_POSTE).DoubleClick += eventHandler;
				((Control)_Label_POSTE).Click += eventHandler2;
			}
		}
	}

	internal virtual Label Label_USERNAME
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_USERNAME;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_USERNAME = value;
		}
	}

	internal virtual Label Label_USERCATEGORIE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_USERCATEGORIE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_USERCATEGORIE = value;
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

	internal virtual Label Label_FOLDER
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_FOLDER;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Label_FOLDER_DoubleClick;
			EventHandler eventHandler2 = Label_FOLDER_Click;
			if (_Label_FOLDER != null)
			{
				((Control)_Label_FOLDER).DoubleClick -= eventHandler;
				((Control)_Label_FOLDER).Click -= eventHandler2;
			}
			_Label_FOLDER = value;
			if (_Label_FOLDER != null)
			{
				((Control)_Label_FOLDER).DoubleClick += eventHandler;
				((Control)_Label_FOLDER).Click += eventHandler2;
			}
		}
	}

	internal virtual Panel Panel_clé
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel_clé;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel_clé = value;
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

	internal virtual Button Button_coller
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_coller;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_coller_Click;
			if (_Button_coller != null)
			{
				((Control)_Button_coller).Click -= eventHandler;
			}
			_Button_coller = value;
			if (_Button_coller != null)
			{
				((Control)_Button_coller).Click += eventHandler;
			}
		}
	}

	internal virtual MaskedTextBox MaskedText_acti
	{
		[DebuggerNonUserCode]
		get
		{
			return _MaskedText_acti;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_MaskedText_acti = value;
		}
	}

	internal virtual Button Button_copier
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_copier;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_copier_Click;
			if (_Button_copier != null)
			{
				((Control)_Button_copier).Click -= eventHandler;
			}
			_Button_copier = value;
			if (_Button_copier != null)
			{
				((Control)_Button_copier).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button_ok
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_ok;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_ok_Click;
			if (_Button_ok != null)
			{
				((Control)_Button_ok).Click -= eventHandler;
			}
			_Button_ok = value;
			if (_Button_ok != null)
			{
				((Control)_Button_ok).Click += eventHandler;
			}
		}
	}

	internal virtual TextBox Text_ara_disk
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_ara_disk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_ara_disk = value;
		}
	}

	internal virtual TextBox Text_ara_reg
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_ara_reg;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_ara_reg = value;
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

	internal virtual Button Button_end
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_end;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_end_Click;
			if (_Button_end != null)
			{
				((Control)_Button_end).Click -= eventHandler;
			}
			_Button_end = value;
			if (_Button_end != null)
			{
				((Control)_Button_end).Click += eventHandler;
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

	internal virtual Panel Panel_FICHE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel_FICHE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel_FICHE = value;
		}
	}

	internal virtual TextBox TextBox2
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBox2 = value;
		}
	}

	internal virtual TextBox TextBox3
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBox3 = value;
		}
	}

	internal virtual Panel Panel_TENTATIVE_CONNEXION
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel_TENTATIVE_CONNEXION;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel_TENTATIVE_CONNEXION = value;
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
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			PaintEventHandler val = Panel5_Paint;
			if (_Panel5 != null)
			{
				((Control)_Panel5).Paint -= val;
			}
			_Panel5 = value;
			if (_Panel5 != null)
			{
				((Control)_Panel5).Paint += val;
			}
		}
	}

	internal virtual TextBox Text_SOLUTION
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_SOLUTION;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_SOLUTION = value;
		}
	}

	internal virtual Button Button1212
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button1212;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button1212_Click;
			if (_Button1212 != null)
			{
				((Control)_Button1212).Click -= eventHandler;
			}
			_Button1212 = value;
			if (_Button1212 != null)
			{
				((Control)_Button1212).Click += eventHandler;
			}
		}
	}

	internal virtual Label Label_GESTION_TABLE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_GESTION_TABLE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_GESTION_TABLE = value;
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

	internal virtual Button_CLAVIER_NOSELECT Butt_N
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_N;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click;
			if (_Butt_N != null)
			{
				((Control)_Butt_N).Click -= eventHandler;
			}
			_Butt_N = value;
			if (_Butt_N != null)
			{
				((Control)_Butt_N).Click += eventHandler;
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

	internal virtual Button_CLAVIER_NOSELECT Butt_B
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_B;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click;
			if (_Butt_B != null)
			{
				((Control)_Butt_B).Click -= eventHandler;
			}
			_Butt_B = value;
			if (_Butt_B != null)
			{
				((Control)_Butt_B).Click += eventHandler;
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

	internal virtual Button_CLAVIER_NOSELECT Butt_V
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_V;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click;
			if (_Butt_V != null)
			{
				((Control)_Butt_V).Click -= eventHandler;
			}
			_Butt_V = value;
			if (_Butt_V != null)
			{
				((Control)_Butt_V).Click += eventHandler;
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

	internal virtual Button_CLAVIER_NOSELECT Butt_C
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_C;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click;
			if (_Butt_C != null)
			{
				((Control)_Butt_C).Click -= eventHandler;
			}
			_Butt_C = value;
			if (_Butt_C != null)
			{
				((Control)_Butt_C).Click += eventHandler;
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

	internal virtual Button_CLAVIER_NOSELECT Butt_X
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_X;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click;
			if (_Butt_X != null)
			{
				((Control)_Butt_X).Click -= eventHandler;
			}
			_Butt_X = value;
			if (_Butt_X != null)
			{
				((Control)_Butt_X).Click += eventHandler;
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

	internal virtual Button_CLAVIER_NOSELECT Butt_W
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_W;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click;
			if (_Butt_W != null)
			{
				((Control)_Butt_W).Click -= eventHandler;
			}
			_Butt_W = value;
			if (_Butt_W != null)
			{
				((Control)_Butt_W).Click += eventHandler;
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

	internal virtual Button_CLAVIER_NOSELECT Butt_M
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_M;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click;
			if (_Butt_M != null)
			{
				((Control)_Butt_M).Click -= eventHandler;
			}
			_Butt_M = value;
			if (_Butt_M != null)
			{
				((Control)_Butt_M).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_A
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_A;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click;
			if (_Butt_A != null)
			{
				((Control)_Butt_A).Click -= eventHandler;
			}
			_Butt_A = value;
			if (_Butt_A != null)
			{
				((Control)_Butt_A).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_L
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_L;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click;
			if (_Butt_L != null)
			{
				((Control)_Butt_L).Click -= eventHandler;
			}
			_Butt_L = value;
			if (_Butt_L != null)
			{
				((Control)_Butt_L).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_Z
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_Z;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click;
			if (_Butt_Z != null)
			{
				((Control)_Butt_Z).Click -= eventHandler;
			}
			_Butt_Z = value;
			if (_Butt_Z != null)
			{
				((Control)_Butt_Z).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_K
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_K;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click;
			if (_Butt_K != null)
			{
				((Control)_Butt_K).Click -= eventHandler;
			}
			_Butt_K = value;
			if (_Butt_K != null)
			{
				((Control)_Butt_K).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_E
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_E;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click;
			if (_Butt_E != null)
			{
				((Control)_Butt_E).Click -= eventHandler;
			}
			_Butt_E = value;
			if (_Butt_E != null)
			{
				((Control)_Butt_E).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_J
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_J;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click;
			if (_Butt_J != null)
			{
				((Control)_Butt_J).Click -= eventHandler;
			}
			_Butt_J = value;
			if (_Butt_J != null)
			{
				((Control)_Butt_J).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_R
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_R;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click;
			if (_Butt_R != null)
			{
				((Control)_Butt_R).Click -= eventHandler;
			}
			_Butt_R = value;
			if (_Butt_R != null)
			{
				((Control)_Butt_R).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_H
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_H;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click;
			if (_Butt_H != null)
			{
				((Control)_Butt_H).Click -= eventHandler;
			}
			_Butt_H = value;
			if (_Butt_H != null)
			{
				((Control)_Butt_H).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_T
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_T;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click;
			if (_Butt_T != null)
			{
				((Control)_Butt_T).Click -= eventHandler;
			}
			_Butt_T = value;
			if (_Butt_T != null)
			{
				((Control)_Butt_T).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_G
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_G;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click;
			if (_Butt_G != null)
			{
				((Control)_Butt_G).Click -= eventHandler;
			}
			_Butt_G = value;
			if (_Butt_G != null)
			{
				((Control)_Butt_G).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_Y
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_Y;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click;
			if (_Butt_Y != null)
			{
				((Control)_Butt_Y).Click -= eventHandler;
			}
			_Butt_Y = value;
			if (_Butt_Y != null)
			{
				((Control)_Butt_Y).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_F
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_F;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click;
			if (_Butt_F != null)
			{
				((Control)_Butt_F).Click -= eventHandler;
			}
			_Butt_F = value;
			if (_Butt_F != null)
			{
				((Control)_Butt_F).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_U
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_U;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click;
			if (_Butt_U != null)
			{
				((Control)_Butt_U).Click -= eventHandler;
			}
			_Butt_U = value;
			if (_Butt_U != null)
			{
				((Control)_Butt_U).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_D
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_D;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click;
			if (_Butt_D != null)
			{
				((Control)_Butt_D).Click -= eventHandler;
			}
			_Butt_D = value;
			if (_Butt_D != null)
			{
				((Control)_Butt_D).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_I
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_I;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click;
			if (_Butt_I != null)
			{
				((Control)_Butt_I).Click -= eventHandler;
			}
			_Butt_I = value;
			if (_Butt_I != null)
			{
				((Control)_Butt_I).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_S
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_S;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click;
			if (_Butt_S != null)
			{
				((Control)_Butt_S).Click -= eventHandler;
			}
			_Butt_S = value;
			if (_Butt_S != null)
			{
				((Control)_Butt_S).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_O
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_O;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click;
			if (_Butt_O != null)
			{
				((Control)_Butt_O).Click -= eventHandler;
			}
			_Butt_O = value;
			if (_Butt_O != null)
			{
				((Control)_Butt_O).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_Q
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_Q;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click;
			if (_Butt_Q != null)
			{
				((Control)_Butt_Q).Click -= eventHandler;
			}
			_Butt_Q = value;
			if (_Butt_Q != null)
			{
				((Control)_Butt_Q).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_P
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_P;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_Click;
			if (_Butt_P != null)
			{
				((Control)_Butt_P).Click -= eventHandler;
			}
			_Butt_P = value;
			if (_Butt_P != null)
			{
				((Control)_Butt_P).Click += eventHandler;
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

	internal virtual TableLayoutPanel TableLayoutPanel3
	{
		[DebuggerNonUserCode]
		get
		{
			return _TableLayoutPanel3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TableLayoutPanel3 = value;
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_SPACE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_SPACE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Butt_SPACE_Click;
			if (_Butt_SPACE != null)
			{
				((Control)_Butt_SPACE).Click -= eventHandler;
			}
			_Butt_SPACE = value;
			if (_Butt_SPACE != null)
			{
				((Control)_Butt_SPACE).Click += eventHandler;
			}
		}
	}

	internal virtual RichTextBox RichText_insc
	{
		[DebuggerNonUserCode]
		get
		{
			return _RichText_insc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = RichText_insc_TextChanged;
			if (_RichText_insc != null)
			{
				((Control)_RichText_insc).TextChanged -= eventHandler;
			}
			_RichText_insc = value;
			if (_RichText_insc != null)
			{
				((Control)_RichText_insc).TextChanged += eventHandler;
			}
		}
	}

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

	internal virtual PictureBox Picture_ALERT
	{
		[DebuggerNonUserCode]
		get
		{
			return _Picture_ALERT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Picture_ALERT_Click;
			if (_Picture_ALERT != null)
			{
				((Control)_Picture_ALERT).Click -= eventHandler;
			}
			_Picture_ALERT = value;
			if (_Picture_ALERT != null)
			{
				((Control)_Picture_ALERT).Click += eventHandler;
			}
		}
	}

	internal virtual Label Label_CONNEXION_STATUT
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_CONNEXION_STATUT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_CONNEXION_STATUT = value;
		}
	}

	internal virtual Label Label_LANGUE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_LANGUE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_LANGUE = value;
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

	internal virtual TextBox TextBox_MODE_WINDOWS
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox_MODE_WINDOWS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBox_MODE_WINDOWS = value;
		}
	}

	internal virtual TextBox TextBox_COMPOSITION_AUTO
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox_COMPOSITION_AUTO;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBox_COMPOSITION_AUTO = value;
		}
	}

	internal virtual TextBox TextBox_BRANCHEMENT
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox_BRANCHEMENT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBox_BRANCHEMENT = value;
		}
	}

	internal virtual ListView ListView1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ListView1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ListView1 = value;
		}
	}

	internal virtual ColumnHeader OBJET
	{
		[DebuggerNonUserCode]
		get
		{
			return _OBJET;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_OBJET = value;
		}
	}

	internal virtual ColumnHeader VALEUR
	{
		[DebuggerNonUserCode]
		get
		{
			return _VALEUR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_VALEUR = value;
		}
	}

	internal virtual PictureBox PictureBox_SORTIE
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox_SORTIE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox_SORTIE = value;
		}
	}

	internal virtual PictureBox PictureBox6
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox6 = value;
		}
	}

	internal virtual PictureBox Picture_EMPORTER
	{
		[DebuggerNonUserCode]
		get
		{
			return _Picture_EMPORTER;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Picture_EMPORTER = value;
		}
	}

	internal virtual PictureBox Picture_LIVRAISON
	{
		[DebuggerNonUserCode]
		get
		{
			return _Picture_LIVRAISON;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Picture_LIVRAISON = value;
		}
	}

	internal virtual PictureBox Picture_MOVE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Picture_MOVE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Picture_MOVE = value;
		}
	}

	internal virtual PictureBox Picture_CONS
	{
		[DebuggerNonUserCode]
		get
		{
			return _Picture_CONS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Picture_CONS = value;
		}
	}

	internal virtual PictureBox Picture_PRINT
	{
		[DebuggerNonUserCode]
		get
		{
			return _Picture_PRINT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Picture_PRINT = value;
		}
	}

	internal virtual PictureBox Picture_PDF
	{
		[DebuggerNonUserCode]
		get
		{
			return _Picture_PDF;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Picture_PDF = value;
		}
	}

	internal virtual PictureBox Picture_SUPP
	{
		[DebuggerNonUserCode]
		get
		{
			return _Picture_SUPP;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Picture_SUPP = value;
		}
	}

	internal virtual PictureBox Picture_DESACTIVER
	{
		[DebuggerNonUserCode]
		get
		{
			return _Picture_DESACTIVER;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Picture_DESACTIVER = value;
		}
	}

	internal virtual PictureBox Picture_MODIF
	{
		[DebuggerNonUserCode]
		get
		{
			return _Picture_MODIF;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Picture_MODIF = value;
		}
	}

	internal virtual Button Button1323234
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button1323234;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button1323234_Click;
			if (_Button1323234 != null)
			{
				((Control)_Button1323234).Click -= eventHandler;
			}
			_Button1323234 = value;
			if (_Button1323234 != null)
			{
				((Control)_Button1323234).Click += eventHandler;
			}
		}
	}

	internal virtual Label Label_ERREUR
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_ERREUR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_ERREUR = value;
		}
	}

	[DebuggerNonUserCode]
	public Form_0_TEMPLATE()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		((Control)this).KeyPress += Form_0_TEMPLATE_KeyPress;
		((Control)this).HandleCreated += Form_0_TEMPLATE_HandleCreated;
		((Form)this).Load += Form_0_TEMPLATE_Load;
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
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected Obj, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected Obj, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected Obj, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected Obj, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected Obj, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected Obj, but got Unknown
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected Obj, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected Obj, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected Obj, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected Obj, but got Unknown
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected Obj, but got Unknown
		//IL_0299: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Expected Obj, but got Unknown
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bb: Expected Obj, but got Unknown
		//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Expected Obj, but got Unknown
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d3: Expected Obj, but got Unknown
		//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Expected Obj, but got Unknown
		//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Expected Obj, but got Unknown
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f7: Expected Obj, but got Unknown
		//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Expected Obj, but got Unknown
		//IL_0305: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Expected Obj, but got Unknown
		//IL_0311: Unknown result type (might be due to invalid IL or missing references)
		//IL_031b: Expected Obj, but got Unknown
		//IL_031d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Expected Obj, but got Unknown
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_0333: Expected Obj, but got Unknown
		//IL_0335: Unknown result type (might be due to invalid IL or missing references)
		//IL_033f: Expected Obj, but got Unknown
		//IL_0341: Unknown result type (might be due to invalid IL or missing references)
		//IL_034b: Expected Obj, but got Unknown
		//IL_034d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0357: Expected Obj, but got Unknown
		//IL_0359: Unknown result type (might be due to invalid IL or missing references)
		//IL_0363: Expected Obj, but got Unknown
		//IL_0365: Unknown result type (might be due to invalid IL or missing references)
		//IL_036f: Expected Obj, but got Unknown
		//IL_0371: Unknown result type (might be due to invalid IL or missing references)
		//IL_037b: Expected Obj, but got Unknown
		//IL_037d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0387: Expected Obj, but got Unknown
		//IL_0395: Unknown result type (might be due to invalid IL or missing references)
		//IL_039f: Expected Obj, but got Unknown
		//IL_03a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ab: Expected Obj, but got Unknown
		//IL_03ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b7: Expected Obj, but got Unknown
		//IL_03b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c3: Expected Obj, but got Unknown
		//IL_03c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cf: Expected Obj, but got Unknown
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03db: Expected Obj, but got Unknown
		//IL_03dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e7: Expected Obj, but got Unknown
		//IL_03e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f3: Expected Obj, but got Unknown
		//IL_03f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ff: Expected Obj, but got Unknown
		//IL_0401: Unknown result type (might be due to invalid IL or missing references)
		//IL_040b: Expected Obj, but got Unknown
		//IL_040d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0417: Expected Obj, but got Unknown
		//IL_0419: Unknown result type (might be due to invalid IL or missing references)
		//IL_0423: Expected Obj, but got Unknown
		//IL_042b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Expected Obj, but got Unknown
		//IL_0437: Unknown result type (might be due to invalid IL or missing references)
		//IL_0441: Expected Obj, but got Unknown
		//IL_0443: Unknown result type (might be due to invalid IL or missing references)
		//IL_044d: Expected Obj, but got Unknown
		//IL_044f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0459: Expected Obj, but got Unknown
		//IL_045b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0465: Expected Obj, but got Unknown
		//IL_0467: Unknown result type (might be due to invalid IL or missing references)
		//IL_0471: Expected Obj, but got Unknown
		//IL_0473: Unknown result type (might be due to invalid IL or missing references)
		//IL_047d: Expected Obj, but got Unknown
		//IL_047f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0489: Expected Obj, but got Unknown
		//IL_048b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0495: Expected Obj, but got Unknown
		//IL_0497: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a1: Expected Obj, but got Unknown
		//IL_04a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ad: Expected Obj, but got Unknown
		//IL_04af: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b9: Expected Obj, but got Unknown
		//IL_04bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c5: Expected Obj, but got Unknown
		//IL_04c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d1: Expected Obj, but got Unknown
		//IL_04d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04dd: Expected Obj, but got Unknown
		//IL_04df: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e9: Expected Obj, but got Unknown
		//IL_04eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f5: Expected Obj, but got Unknown
		//IL_04f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0501: Expected Obj, but got Unknown
		//IL_0503: Unknown result type (might be due to invalid IL or missing references)
		//IL_050d: Expected Obj, but got Unknown
		//IL_050f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0519: Expected Obj, but got Unknown
		//IL_051b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0525: Expected Obj, but got Unknown
		//IL_0527: Unknown result type (might be due to invalid IL or missing references)
		//IL_0531: Expected Obj, but got Unknown
		//IL_0758: Unknown result type (might be due to invalid IL or missing references)
		//IL_0762: Expected Obj, but got Unknown
		//IL_08f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ff: Expected Obj, but got Unknown
		//IL_0942: Unknown result type (might be due to invalid IL or missing references)
		//IL_0948: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b57: Expected Obj, but got Unknown
		//IL_0bf5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bff: Expected Obj, but got Unknown
		//IL_0c8e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c98: Expected Obj, but got Unknown
		//IL_0d22: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d2c: Expected Obj, but got Unknown
		//IL_0f77: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f81: Expected Obj, but got Unknown
		//IL_10bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_10c7: Expected Obj, but got Unknown
		//IL_10d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_10e3: Expected Obj, but got Unknown
		//IL_10f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ff: Expected Obj, but got Unknown
		//IL_1111: Unknown result type (might be due to invalid IL or missing references)
		//IL_111b: Expected Obj, but got Unknown
		//IL_112d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1137: Expected Obj, but got Unknown
		//IL_1149: Unknown result type (might be due to invalid IL or missing references)
		//IL_1153: Expected Obj, but got Unknown
		//IL_1165: Unknown result type (might be due to invalid IL or missing references)
		//IL_116f: Expected Obj, but got Unknown
		//IL_1181: Unknown result type (might be due to invalid IL or missing references)
		//IL_118b: Expected Obj, but got Unknown
		//IL_119d: Unknown result type (might be due to invalid IL or missing references)
		//IL_11a7: Expected Obj, but got Unknown
		//IL_11b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_11c3: Expected Obj, but got Unknown
		//IL_11d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_11df: Expected Obj, but got Unknown
		//IL_11f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_11fb: Expected Obj, but got Unknown
		//IL_160f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1615: Unknown result type (might be due to invalid IL or missing references)
		//IL_163b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1645: Expected Obj, but got Unknown
		//IL_1657: Unknown result type (might be due to invalid IL or missing references)
		//IL_1661: Expected Obj, but got Unknown
		//IL_1673: Unknown result type (might be due to invalid IL or missing references)
		//IL_167d: Expected Obj, but got Unknown
		//IL_168f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1699: Expected Obj, but got Unknown
		//IL_16ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_16b5: Expected Obj, but got Unknown
		//IL_1757: Unknown result type (might be due to invalid IL or missing references)
		//IL_1761: Expected Obj, but got Unknown
		//IL_1798: Unknown result type (might be due to invalid IL or missing references)
		//IL_179e: Unknown result type (might be due to invalid IL or missing references)
		//IL_188a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1894: Expected Obj, but got Unknown
		//IL_18c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_18cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_19ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_19b5: Expected Obj, but got Unknown
		//IL_19e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_19ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_1acd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ad7: Expected Obj, but got Unknown
		//IL_1b0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b14: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bf3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bfd: Expected Obj, but got Unknown
		//IL_1c33: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c39: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d18: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d22: Expected Obj, but got Unknown
		//IL_1d59: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e48: Expected Obj, but got Unknown
		//IL_1e7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e84: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f63: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f6d: Expected Obj, but got Unknown
		//IL_1fa4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1faa: Unknown result type (might be due to invalid IL or missing references)
		//IL_2089: Unknown result type (might be due to invalid IL or missing references)
		//IL_2093: Expected Obj, but got Unknown
		//IL_20c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_20cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_21ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_21b8: Expected Obj, but got Unknown
		//IL_21ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_21f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_22d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_22de: Expected Obj, but got Unknown
		//IL_2314: Unknown result type (might be due to invalid IL or missing references)
		//IL_231a: Unknown result type (might be due to invalid IL or missing references)
		//IL_23f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_2403: Expected Obj, but got Unknown
		//IL_243a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2440: Unknown result type (might be due to invalid IL or missing references)
		//IL_251f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2529: Expected Obj, but got Unknown
		//IL_255f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2565: Unknown result type (might be due to invalid IL or missing references)
		//IL_2644: Unknown result type (might be due to invalid IL or missing references)
		//IL_264e: Expected Obj, but got Unknown
		//IL_2685: Unknown result type (might be due to invalid IL or missing references)
		//IL_268b: Unknown result type (might be due to invalid IL or missing references)
		//IL_276a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2774: Expected Obj, but got Unknown
		//IL_27aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_27b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_288f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2899: Expected Obj, but got Unknown
		//IL_28cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_28d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_29b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_29be: Expected Obj, but got Unknown
		//IL_29f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_29fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ad9: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ae3: Expected Obj, but got Unknown
		//IL_2b1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b20: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c16: Expected Obj, but got Unknown
		//IL_2c49: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d38: Expected Obj, but got Unknown
		//IL_2d6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d75: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e54: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e5e: Expected Obj, but got Unknown
		//IL_2e92: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e98: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f77: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f81: Expected Obj, but got Unknown
		//IL_2fb8: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fbe: Unknown result type (might be due to invalid IL or missing references)
		//IL_309d: Unknown result type (might be due to invalid IL or missing references)
		//IL_30a7: Expected Obj, but got Unknown
		//IL_30de: Unknown result type (might be due to invalid IL or missing references)
		//IL_30e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_31c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_31cd: Expected Obj, but got Unknown
		//IL_3204: Unknown result type (might be due to invalid IL or missing references)
		//IL_320a: Unknown result type (might be due to invalid IL or missing references)
		//IL_32e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_32f3: Expected Obj, but got Unknown
		//IL_332a: Unknown result type (might be due to invalid IL or missing references)
		//IL_3330: Unknown result type (might be due to invalid IL or missing references)
		//IL_340f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3419: Expected Obj, but got Unknown
		//IL_3450: Unknown result type (might be due to invalid IL or missing references)
		//IL_3456: Unknown result type (might be due to invalid IL or missing references)
		//IL_3535: Unknown result type (might be due to invalid IL or missing references)
		//IL_353f: Expected Obj, but got Unknown
		//IL_3576: Unknown result type (might be due to invalid IL or missing references)
		//IL_357c: Unknown result type (might be due to invalid IL or missing references)
		//IL_365b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3665: Expected Obj, but got Unknown
		//IL_369c: Unknown result type (might be due to invalid IL or missing references)
		//IL_36a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_3781: Unknown result type (might be due to invalid IL or missing references)
		//IL_378b: Expected Obj, but got Unknown
		//IL_37c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_37c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_38a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_38b1: Expected Obj, but got Unknown
		//IL_38e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_38ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_39cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_39d7: Expected Obj, but got Unknown
		//IL_3a0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a14: Unknown result type (might be due to invalid IL or missing references)
		//IL_3af3: Unknown result type (might be due to invalid IL or missing references)
		//IL_3afd: Expected Obj, but got Unknown
		//IL_3b34: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c19: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c23: Expected Obj, but got Unknown
		//IL_3c5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c60: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d49: Expected Obj, but got Unknown
		//IL_3d80: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d86: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e65: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e6f: Expected Obj, but got Unknown
		//IL_3ea6: Unknown result type (might be due to invalid IL or missing references)
		//IL_3eac: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f8b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f95: Expected Obj, but got Unknown
		//IL_3fc9: Unknown result type (might be due to invalid IL or missing references)
		//IL_3fcf: Unknown result type (might be due to invalid IL or missing references)
		//IL_40ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_40b8: Expected Obj, but got Unknown
		//IL_40ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_40f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_41d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_41de: Expected Obj, but got Unknown
		//IL_4201: Unknown result type (might be due to invalid IL or missing references)
		//IL_420b: Expected Obj, but got Unknown
		//IL_4230: Unknown result type (might be due to invalid IL or missing references)
		//IL_4236: Unknown result type (might be due to invalid IL or missing references)
		//IL_42f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_4301: Expected Obj, but got Unknown
		//IL_4324: Unknown result type (might be due to invalid IL or missing references)
		//IL_432e: Expected Obj, but got Unknown
		//IL_4354: Unknown result type (might be due to invalid IL or missing references)
		//IL_435a: Unknown result type (might be due to invalid IL or missing references)
		//IL_43e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_43ea: Expected Obj, but got Unknown
		//IL_43fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_4406: Expected Obj, but got Unknown
		//IL_4418: Unknown result type (might be due to invalid IL or missing references)
		//IL_4422: Expected Obj, but got Unknown
		//IL_447e: Unknown result type (might be due to invalid IL or missing references)
		//IL_4484: Unknown result type (might be due to invalid IL or missing references)
		//IL_44aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_44b4: Expected Obj, but got Unknown
		//IL_4553: Unknown result type (might be due to invalid IL or missing references)
		//IL_455d: Expected Obj, but got Unknown
		//IL_4580: Unknown result type (might be due to invalid IL or missing references)
		//IL_458a: Expected Obj, but got Unknown
		//IL_45ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_45b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_46ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_46b6: Expected Obj, but got Unknown
		//IL_46c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_46d2: Expected Obj, but got Unknown
		//IL_4784: Unknown result type (might be due to invalid IL or missing references)
		//IL_478e: Expected Obj, but got Unknown
		//IL_4834: Unknown result type (might be due to invalid IL or missing references)
		//IL_483e: Expected Obj, but got Unknown
		//IL_499b: Unknown result type (might be due to invalid IL or missing references)
		//IL_49a5: Expected Obj, but got Unknown
		//IL_4a61: Unknown result type (might be due to invalid IL or missing references)
		//IL_4a6b: Expected Obj, but got Unknown
		//IL_4b14: Unknown result type (might be due to invalid IL or missing references)
		//IL_4b1e: Expected Obj, but got Unknown
		//IL_4bad: Unknown result type (might be due to invalid IL or missing references)
		//IL_4bb7: Expected Obj, but got Unknown
		//IL_4be2: Unknown result type (might be due to invalid IL or missing references)
		//IL_4bec: Expected Obj, but got Unknown
		//IL_4cb9: Unknown result type (might be due to invalid IL or missing references)
		//IL_4cc3: Expected Obj, but got Unknown
		//IL_4d5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_4d69: Expected Obj, but got Unknown
		//IL_4e0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_4e15: Expected Obj, but got Unknown
		//IL_4eba: Unknown result type (might be due to invalid IL or missing references)
		//IL_4ec4: Expected Obj, but got Unknown
		//IL_528c: Unknown result type (might be due to invalid IL or missing references)
		//IL_5292: Unknown result type (might be due to invalid IL or missing references)
		//IL_52f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_52fe: Expected Obj, but got Unknown
		//IL_53ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_53c4: Expected Obj, but got Unknown
		//IL_546d: Unknown result type (might be due to invalid IL or missing references)
		//IL_5477: Expected Obj, but got Unknown
		//IL_5510: Unknown result type (might be due to invalid IL or missing references)
		//IL_551a: Expected Obj, but got Unknown
		//IL_55a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_55b3: Expected Obj, but got Unknown
		//IL_565c: Unknown result type (might be due to invalid IL or missing references)
		//IL_5666: Expected Obj, but got Unknown
		//IL_578a: Unknown result type (might be due to invalid IL or missing references)
		//IL_5794: Expected Obj, but got Unknown
		//IL_582c: Unknown result type (might be due to invalid IL or missing references)
		//IL_5836: Expected Obj, but got Unknown
		//IL_58c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_58cb: Expected Obj, but got Unknown
		//IL_59e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_59f1: Expected Obj, but got Unknown
		//IL_5a88: Unknown result type (might be due to invalid IL or missing references)
		//IL_5a92: Expected Obj, but got Unknown
		//IL_5b73: Unknown result type (might be due to invalid IL or missing references)
		//IL_5b7d: Expected Obj, but got Unknown
		//IL_5bf6: Unknown result type (might be due to invalid IL or missing references)
		//IL_5c00: Expected Obj, but got Unknown
		//IL_5c12: Unknown result type (might be due to invalid IL or missing references)
		//IL_5c1c: Expected Obj, but got Unknown
		//IL_608c: Unknown result type (might be due to invalid IL or missing references)
		//IL_6096: Expected Obj, but got Unknown
		//IL_6128: Unknown result type (might be due to invalid IL or missing references)
		//IL_6132: Expected Obj, but got Unknown
		//IL_61c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_61d1: Expected Obj, but got Unknown
		//IL_6273: Unknown result type (might be due to invalid IL or missing references)
		//IL_627d: Expected Obj, but got Unknown
		//IL_631f: Unknown result type (might be due to invalid IL or missing references)
		//IL_6329: Expected Obj, but got Unknown
		//IL_63c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_63d2: Expected Obj, but got Unknown
		//IL_6464: Unknown result type (might be due to invalid IL or missing references)
		//IL_646e: Expected Obj, but got Unknown
		//IL_6500: Unknown result type (might be due to invalid IL or missing references)
		//IL_650a: Expected Obj, but got Unknown
		//IL_6599: Unknown result type (might be due to invalid IL or missing references)
		//IL_65a3: Expected Obj, but got Unknown
		//IL_6631: Unknown result type (might be due to invalid IL or missing references)
		//IL_663b: Expected Obj, but got Unknown
		//IL_66ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_66d4: Expected Obj, but got Unknown
		//IL_6754: Unknown result type (might be due to invalid IL or missing references)
		//IL_675e: Expected Obj, but got Unknown
		//IL_67ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_6809: Expected Obj, but got Unknown
		//IL_68f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_6901: Expected Obj, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form_0_TEMPLATE));
		Panel_HOME = new Panel();
		LinkLabel1 = new LinkLabel();
		Panel_clé = new Panel();
		Button_end = new Button();
		PictureBox100 = new PictureBox();
		Panel_TENTATIVE_CONNEXION = new Panel();
		Label2 = new Label();
		Label1 = new Label();
		PictureBox5 = new PictureBox();
		PictureBox4 = new PictureBox();
		Panel_FICHE = new Panel();
		RichText_insc = new RichTextBox();
		Panel_CLAVIER = new Panel();
		TableLayoutPanel2 = new TableLayoutPanel();
		Butt_DOT = new Button_CLAVIER_NOSELECT();
		Butt_1 = new Button_CLAVIER_NOSELECT();
		Butt_2 = new Button_CLAVIER_NOSELECT();
		Butt_N = new Button_CLAVIER_NOSELECT();
		Butt_3 = new Button_CLAVIER_NOSELECT();
		Butt_B = new Button_CLAVIER_NOSELECT();
		Butt_4 = new Button_CLAVIER_NOSELECT();
		Butt_V = new Button_CLAVIER_NOSELECT();
		Butt_5 = new Button_CLAVIER_NOSELECT();
		Butt_C = new Button_CLAVIER_NOSELECT();
		Butt_6 = new Button_CLAVIER_NOSELECT();
		Butt_X = new Button_CLAVIER_NOSELECT();
		Butt_7 = new Button_CLAVIER_NOSELECT();
		Butt_W = new Button_CLAVIER_NOSELECT();
		Butt_8 = new Button_CLAVIER_NOSELECT();
		Butt_9 = new Button_CLAVIER_NOSELECT();
		Butt_0 = new Button_CLAVIER_NOSELECT();
		Butt_M = new Button_CLAVIER_NOSELECT();
		Butt_A = new Button_CLAVIER_NOSELECT();
		Butt_L = new Button_CLAVIER_NOSELECT();
		Butt_Z = new Button_CLAVIER_NOSELECT();
		Butt_K = new Button_CLAVIER_NOSELECT();
		Butt_E = new Button_CLAVIER_NOSELECT();
		Butt_J = new Button_CLAVIER_NOSELECT();
		Butt_R = new Button_CLAVIER_NOSELECT();
		Butt_H = new Button_CLAVIER_NOSELECT();
		Butt_T = new Button_CLAVIER_NOSELECT();
		Butt_G = new Button_CLAVIER_NOSELECT();
		Butt_Y = new Button_CLAVIER_NOSELECT();
		Butt_F = new Button_CLAVIER_NOSELECT();
		Butt_U = new Button_CLAVIER_NOSELECT();
		Butt_D = new Button_CLAVIER_NOSELECT();
		Butt_I = new Button_CLAVIER_NOSELECT();
		Butt_S = new Button_CLAVIER_NOSELECT();
		Butt_O = new Button_CLAVIER_NOSELECT();
		Butt_Q = new Button_CLAVIER_NOSELECT();
		Butt_P = new Button_CLAVIER_NOSELECT();
		Butt_BACK = new Button_CLAVIER_NOSELECT();
		Butt_DRAFT = new Button_CLAVIER_NOSELECT();
		TableLayoutPanel3 = new TableLayoutPanel();
		Butt_SPACE = new Button_CLAVIER_NOSELECT();
		Panel5 = new Panel();
		Button1212 = new Button();
		Text_SOLUTION = new TextBox();
		Label12 = new Label();
		Panel2 = new Panel();
		Label11 = new Label();
		Label6 = new Label();
		Label8 = new Label();
		Button_ok = new Button();
		Label13 = new Label();
		Button_copier = new Button();
		Button_coller = new Button();
		MaskedText_acti = new MaskedTextBox();
		TextBox2 = new TextBox();
		TextBox3 = new TextBox();
		Text_ara_reg = new TextBox();
		Text_ara_disk = new TextBox();
		Panel_STATUT = new Panel();
		Button_CLAVIER = new Button_CLAVIER_NOSELECT();
		Label_LANGUE = new Label();
		Label_CONNEXION_STATUT = new Label();
		Picture_ALERT = new PictureBox();
		Label_GESTION_TABLE = new Label();
		Label_FOLDER = new Label();
		PictureBox1 = new PictureBox();
		Label_USERCATEGORIE = new Label();
		Label_USERNAME = new Label();
		Label_POSTE = new Label();
		Label_DATE = new Label();
		Label_CONNEXION = new Label();
		Label_DB = new Label();
		Timer1 = new System.Windows.Forms.Timer(components);
		TableLayoutPanel1 = new TableLayoutPanel();
		Panel1 = new Panel();
		TextBox_MODE_WINDOWS = new TextBox();
		TextBox_COMPOSITION_AUTO = new TextBox();
		TextBox_BRANCHEMENT = new TextBox();
		ListView1 = new ListView();
		OBJET = new ColumnHeader();
		VALEUR = new ColumnHeader();
		PictureBox_SORTIE = new PictureBox();
		PictureBox6 = new PictureBox();
		Picture_EMPORTER = new PictureBox();
		Picture_LIVRAISON = new PictureBox();
		Picture_MOVE = new PictureBox();
		Picture_CONS = new PictureBox();
		Picture_PRINT = new PictureBox();
		Picture_PDF = new PictureBox();
		Picture_SUPP = new PictureBox();
		Picture_DESACTIVER = new PictureBox();
		Picture_MODIF = new PictureBox();
		Button1323234 = new Button();
		Label_ERREUR = new Label();
		((Control)Panel_HOME).SuspendLayout();
		((Control)Panel_clé).SuspendLayout();
		((ISupportInitialize)PictureBox100).BeginInit();
		((Control)Panel_TENTATIVE_CONNEXION).SuspendLayout();
		((ISupportInitialize)PictureBox5).BeginInit();
		((ISupportInitialize)PictureBox4).BeginInit();
		((Control)Panel_FICHE).SuspendLayout();
		((Control)Panel_CLAVIER).SuspendLayout();
		((Control)TableLayoutPanel2).SuspendLayout();
		((Control)TableLayoutPanel3).SuspendLayout();
		((Control)Panel5).SuspendLayout();
		((Control)Panel2).SuspendLayout();
		((Control)Panel_STATUT).SuspendLayout();
		((ISupportInitialize)Picture_ALERT).BeginInit();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)TableLayoutPanel1).SuspendLayout();
		((Control)Panel1).SuspendLayout();
		((ISupportInitialize)PictureBox_SORTIE).BeginInit();
		((ISupportInitialize)PictureBox6).BeginInit();
		((ISupportInitialize)Picture_EMPORTER).BeginInit();
		((ISupportInitialize)Picture_LIVRAISON).BeginInit();
		((ISupportInitialize)Picture_MOVE).BeginInit();
		((ISupportInitialize)Picture_CONS).BeginInit();
		((ISupportInitialize)Picture_PRINT).BeginInit();
		((ISupportInitialize)Picture_PDF).BeginInit();
		((ISupportInitialize)Picture_SUPP).BeginInit();
		((ISupportInitialize)Picture_DESACTIVER).BeginInit();
		((ISupportInitialize)Picture_MODIF).BeginInit();
		((Control)this).SuspendLayout();
		((Control)Panel_HOME).BackColor = Color.White;
		((Control)Panel_HOME).Controls.Add((Control)(object)LinkLabel1);
		((Control)Panel_HOME).Controls.Add((Control)(object)Panel_clé);
		((Control)Panel_HOME).Dock = (DockStyle)5;
		Panel panel_HOME = Panel_HOME;
		Point location = new Point(3, 3);
		((Control)panel_HOME).Location = location;
		((Control)Panel_HOME).Name = "Panel_HOME";
		Panel panel_HOME2 = Panel_HOME;
		Size size = new Size(1046, 682);
		((Control)panel_HOME2).Size = size;
		((Control)Panel_HOME).TabIndex = 29;
		((Control)LinkLabel1).Anchor = (AnchorStyles)6;
		((Label)LinkLabel1).AutoSize = true;
		((Control)LinkLabel1).Font = new Font("Arial Narrow", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		LinkLabel linkLabel = LinkLabel1;
		location = new Point(12, 657);
		((Control)linkLabel).Location = location;
		((Control)LinkLabel1).Name = "LinkLabel1";
		LinkLabel linkLabel2 = LinkLabel1;
		size = new Size(124, 16);
		((Control)linkLabel2).Size = size;
		((Control)LinkLabel1).TabIndex = 49;
		LinkLabel1.TabStop = true;
		LinkLabel1.Text = "© LÓGICA - À PROPOS";
		((Control)Panel_clé).Anchor = (AnchorStyles)0;
		((Control)Panel_clé).BackColor = Color.White;
		((Control)Panel_clé).Controls.Add((Control)(object)Button_end);
		((Control)Panel_clé).Controls.Add((Control)(object)PictureBox100);
		((Control)Panel_clé).Controls.Add((Control)(object)Panel_TENTATIVE_CONNEXION);
		((Control)Panel_clé).Controls.Add((Control)(object)Panel_FICHE);
		Panel panel_clé = Panel_clé;
		location = new Point(82, 58);
		((Control)panel_clé).Location = location;
		((Control)Panel_clé).Name = "Panel_clé";
		Panel panel_clé2 = Panel_clé;
		size = new Size(882, 596);
		((Control)panel_clé2).Size = size;
		((Control)Panel_clé).TabIndex = 48;
		((Control)Panel_clé).Visible = false;
		((ButtonBase)Button_end).BackColor = Color.Red;
		((Control)Button_end).Cursor = Cursors.Hand;
		((ButtonBase)Button_end).FlatStyle = (FlatStyle)0;
		((Control)Button_end).Font = new Font("Tahoma", 12.25f, (FontStyle)1);
		((Control)Button_end).ForeColor = Color.White;
		((ButtonBase)Button_end).ImageAlign = (ContentAlignment)2;
		Button button_end = Button_end;
		location = new Point(785, 0);
		((Control)button_end).Location = location;
		Button button_end2 = Button_end;
		Padding margin = new Padding(0);
		((Control)button_end2).Margin = margin;
		((Control)Button_end).Name = "Button_end";
		Button button_end3 = Button_end;
		size = new Size(97, 28);
		((Control)button_end3).Size = size;
		((Control)Button_end).TabIndex = 852;
		((ButtonBase)Button_end).Text = "X";
		((ButtonBase)Button_end).TextAlign = (ContentAlignment)2;
		((ButtonBase)Button_end).UseVisualStyleBackColor = false;
		PictureBox pictureBox = PictureBox100;
		location = new Point(323, 3);
		((Control)pictureBox).Location = location;
		((Control)PictureBox100).Name = "PictureBox100";
		PictureBox pictureBox2 = PictureBox100;
		size = new Size(236, 80);
		((Control)pictureBox2).Size = size;
		PictureBox100.SizeMode = (PictureBoxSizeMode)4;
		PictureBox100.TabIndex = 851;
		PictureBox100.TabStop = false;
		((Control)Panel_TENTATIVE_CONNEXION).BackColor = Color.White;
		((Control)Panel_TENTATIVE_CONNEXION).Controls.Add((Control)(object)Button1323234);
		((Control)Panel_TENTATIVE_CONNEXION).Controls.Add((Control)(object)Label_ERREUR);
		((Control)Panel_TENTATIVE_CONNEXION).Controls.Add((Control)(object)Label2);
		((Control)Panel_TENTATIVE_CONNEXION).Controls.Add((Control)(object)Label1);
		((Control)Panel_TENTATIVE_CONNEXION).Controls.Add((Control)(object)PictureBox5);
		((Control)Panel_TENTATIVE_CONNEXION).Controls.Add((Control)(object)PictureBox4);
		Panel panel_TENTATIVE_CONNEXION = Panel_TENTATIVE_CONNEXION;
		location = new Point(0, 85);
		((Control)panel_TENTATIVE_CONNEXION).Location = location;
		((Control)Panel_TENTATIVE_CONNEXION).Name = "Panel_TENTATIVE_CONNEXION";
		Panel panel_TENTATIVE_CONNEXION2 = Panel_TENTATIVE_CONNEXION;
		size = new Size(882, 511);
		((Control)panel_TENTATIVE_CONNEXION2).Size = size;
		((Control)Panel_TENTATIVE_CONNEXION).TabIndex = 853;
		((Control)Panel_TENTATIVE_CONNEXION).Visible = false;
		Label2.AutoSize = true;
		((Control)Label2).Font = new Font("Segoe UI", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label2).ForeColor = SystemColors.ControlDarkDark;
		Label label = Label2;
		location = new Point(284, 90);
		((Control)label).Location = location;
		((Control)Label2).Name = "Label2";
		Label label2 = Label2;
		size = new Size(305, 21);
		((Control)label2).Size = size;
		((Control)Label2).TabIndex = 855;
		Label2.Text = "Impossible d'accéder à la Base de Données";
		Label1.AutoSize = true;
		((Control)Label1).Font = new Font("Segoe UI", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label1).ForeColor = SystemColors.ControlDarkDark;
		Label label3 = Label1;
		location = new Point(308, 67);
		((Control)label3).Location = location;
		((Control)Label1).Name = "Label1";
		Label label4 = Label1;
		size = new Size(262, 21);
		((Control)label4).Size = size;
		((Control)Label1).TabIndex = 854;
		Label1.Text = "Vérifier votre connexion et réessayer";
		PictureBox5.Image = (Image)componentResourceManager.GetObject("PictureBox5.Image");
		PictureBox pictureBox3 = PictureBox5;
		location = new Point(323, 115);
		((Control)pictureBox3).Location = location;
		((Control)PictureBox5).Name = "PictureBox5";
		PictureBox pictureBox4 = PictureBox5;
		size = new Size(236, 277);
		((Control)pictureBox4).Size = size;
		PictureBox5.SizeMode = (PictureBoxSizeMode)4;
		PictureBox5.TabIndex = 853;
		PictureBox5.TabStop = false;
		PictureBox4.Image = (Image)componentResourceManager.GetObject("PictureBox4.Image");
		PictureBox pictureBox5 = PictureBox4;
		location = new Point(323, 16);
		((Control)pictureBox5).Location = location;
		((Control)PictureBox4).Name = "PictureBox4";
		PictureBox pictureBox6 = PictureBox4;
		size = new Size(236, 48);
		((Control)pictureBox6).Size = size;
		PictureBox4.SizeMode = (PictureBoxSizeMode)4;
		PictureBox4.TabIndex = 852;
		PictureBox4.TabStop = false;
		((Control)Panel_FICHE).BackColor = Color.White;
		((Control)Panel_FICHE).Controls.Add((Control)(object)RichText_insc);
		((Control)Panel_FICHE).Controls.Add((Control)(object)Panel_CLAVIER);
		((Control)Panel_FICHE).Controls.Add((Control)(object)Panel5);
		((Control)Panel_FICHE).Controls.Add((Control)(object)Label12);
		((Control)Panel_FICHE).Controls.Add((Control)(object)Panel2);
		((Control)Panel_FICHE).Controls.Add((Control)(object)Button_ok);
		((Control)Panel_FICHE).Controls.Add((Control)(object)Label13);
		((Control)Panel_FICHE).Controls.Add((Control)(object)Button_copier);
		((Control)Panel_FICHE).Controls.Add((Control)(object)Button_coller);
		((Control)Panel_FICHE).Controls.Add((Control)(object)MaskedText_acti);
		((Control)Panel_FICHE).Controls.Add((Control)(object)TextBox2);
		((Control)Panel_FICHE).Controls.Add((Control)(object)TextBox3);
		((Control)Panel_FICHE).Controls.Add((Control)(object)Text_ara_reg);
		((Control)Panel_FICHE).Controls.Add((Control)(object)Text_ara_disk);
		Panel panel_FICHE = Panel_FICHE;
		location = new Point(0, 85);
		((Control)panel_FICHE).Location = location;
		((Control)Panel_FICHE).Name = "Panel_FICHE";
		Panel panel_FICHE2 = Panel_FICHE;
		size = new Size(882, 493);
		((Control)panel_FICHE2).Size = size;
		((Control)Panel_FICHE).TabIndex = 49;
		((Control)Panel_FICHE).Visible = false;
		((TextBoxBase)RichText_insc).BorderStyle = (BorderStyle)1;
		RichText_insc.Font = new Font("Tahoma", 12f, (FontStyle)1);
		RichTextBox richText_insc = RichText_insc;
		location = new Point(204, 120);
		((Control)richText_insc).Location = location;
		RichText_insc.Multiline = false;
		((Control)RichText_insc).Name = "RichText_insc";
		RichTextBox richText_insc2 = RichText_insc;
		size = new Size(575, 27);
		((Control)richText_insc2).Size = size;
		((Control)RichText_insc).TabIndex = 1057;
		RichText_insc.Text = "";
		((Control)Panel_CLAVIER).Controls.Add((Control)(object)TableLayoutPanel2);
		((Control)Panel_CLAVIER).Controls.Add((Control)(object)TableLayoutPanel3);
		Panel panel_CLAVIER = Panel_CLAVIER;
		location = new Point(40, 264);
		((Control)panel_CLAVIER).Location = location;
		((Control)Panel_CLAVIER).Name = "Panel_CLAVIER";
		Panel panel_CLAVIER2 = Panel_CLAVIER;
		size = new Size(818, 213);
		((Control)panel_CLAVIER2).Size = size;
		((Control)Panel_CLAVIER).TabIndex = 1056;
		((Control)TableLayoutPanel2).BackColor = Color.FromArgb(51, 51, 51);
		TableLayoutPanel2.ColumnCount = 12;
		TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle((SizeType)2, 8.333335f));
		TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle((SizeType)2, 8.333335f));
		TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle((SizeType)2, 8.333335f));
		TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle((SizeType)2, 8.333335f));
		TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle((SizeType)2, 8.333335f));
		TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle((SizeType)2, 8.333335f));
		TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle((SizeType)2, 8.333335f));
		TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle((SizeType)2, 8.333335f));
		TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle((SizeType)2, 8.333335f));
		TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle((SizeType)2, 8.333335f));
		TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle((SizeType)2, 8.333335f));
		TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle((SizeType)2, 8.333335f));
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_DOT, 8, 3);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_1, 0, 0);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_2, 1, 0);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_N, 7, 3);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_3, 2, 0);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_B, 6, 3);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_4, 3, 0);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_V, 5, 3);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_5, 4, 0);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_C, 4, 3);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_6, 5, 0);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_X, 3, 3);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_7, 6, 0);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_W, 2, 3);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_8, 7, 0);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_9, 8, 0);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_0, 9, 0);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_M, 10, 2);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_A, 0, 1);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_L, 9, 2);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_Z, 1, 1);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_K, 8, 2);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_E, 2, 1);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_J, 7, 2);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_R, 3, 1);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_H, 6, 2);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_T, 4, 1);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_G, 5, 2);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_Y, 5, 1);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_F, 4, 2);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_U, 6, 1);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_D, 3, 2);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_I, 7, 1);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_S, 2, 2);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_O, 8, 1);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_Q, 1, 2);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_P, 9, 1);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_BACK, 11, 0);
		TableLayoutPanel2.Controls.Add((Control)(object)Butt_DRAFT, 11, 1);
		((Control)TableLayoutPanel2).Dock = (DockStyle)5;
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
		TableLayoutPanel tableLayoutPanel3 = TableLayoutPanel2;
		size = new Size(818, 162);
		((Control)tableLayoutPanel3).Size = size;
		((Control)TableLayoutPanel2).TabIndex = 1052;
		((ButtonBase)Butt_DOT).BackColor = Color.Transparent;
		((Control)Butt_DOT).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_DOT).Cursor = Cursors.Hand;
		((Control)Butt_DOT).Dock = (DockStyle)5;
		((ButtonBase)Butt_DOT).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_DOT).FlatStyle = (FlatStyle)0;
		((Control)Butt_DOT).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_DOT).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_DOT = Butt_DOT;
		location = new Point(537, 121);
		((Control)butt_DOT).Location = location;
		Button_CLAVIER_NOSELECT butt_DOT2 = Butt_DOT;
		margin = new Padding(0);
		((Control)butt_DOT2).Margin = margin;
		((Control)Butt_DOT).Name = "Butt_DOT";
		Button_CLAVIER_NOSELECT butt_DOT3 = Butt_DOT;
		size = new Size(67, 40);
		((Control)butt_DOT3).Size = size;
		((Control)Butt_DOT).TabIndex = 789;
		((ButtonBase)Butt_DOT).Text = ".";
		((ButtonBase)Butt_DOT).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_DOT).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_1).BackColor = Color.Transparent;
		((Control)Butt_1).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_1).CausesValidation = false;
		((Control)Butt_1).Cursor = Cursors.Hand;
		((Control)Butt_1).Dock = (DockStyle)5;
		((ButtonBase)Butt_1).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_1).FlatStyle = (FlatStyle)0;
		((Control)Butt_1).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_1).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_ = Butt_1;
		location = new Point(1, 1);
		((Control)butt_).Location = location;
		Button_CLAVIER_NOSELECT butt_2 = Butt_1;
		margin = new Padding(0);
		((Control)butt_2).Margin = margin;
		((Control)Butt_1).Name = "Butt_1";
		Button_CLAVIER_NOSELECT butt_3 = Butt_1;
		size = new Size(67, 40);
		((Control)butt_3).Size = size;
		((Control)Butt_1).TabIndex = 773;
		((ButtonBase)Butt_1).Text = "1";
		((ButtonBase)Butt_1).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_1).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_2).BackColor = Color.Transparent;
		((Control)Butt_2).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_2).Cursor = Cursors.Hand;
		((Control)Butt_2).Dock = (DockStyle)5;
		((ButtonBase)Butt_2).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_2).FlatStyle = (FlatStyle)0;
		((Control)Butt_2).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_2).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_4 = Butt_2;
		location = new Point(68, 1);
		((Control)butt_4).Location = location;
		Button_CLAVIER_NOSELECT butt_5 = Butt_2;
		margin = new Padding(0);
		((Control)butt_5).Margin = margin;
		((Control)Butt_2).Name = "Butt_2";
		Button_CLAVIER_NOSELECT butt_6 = Butt_2;
		size = new Size(67, 40);
		((Control)butt_6).Size = size;
		((Control)Butt_2).TabIndex = 772;
		((ButtonBase)Butt_2).Text = "2";
		((ButtonBase)Butt_2).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_2).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_N).BackColor = Color.Transparent;
		((Control)Butt_N).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_N).Cursor = Cursors.Hand;
		((Control)Butt_N).Dock = (DockStyle)5;
		((ButtonBase)Butt_N).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_N).FlatStyle = (FlatStyle)0;
		((Control)Butt_N).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_N).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_N = Butt_N;
		location = new Point(470, 121);
		((Control)butt_N).Location = location;
		Button_CLAVIER_NOSELECT butt_N2 = Butt_N;
		margin = new Padding(0);
		((Control)butt_N2).Margin = margin;
		((Control)Butt_N).Name = "Butt_N";
		Button_CLAVIER_NOSELECT butt_N3 = Butt_N;
		size = new Size(67, 40);
		((Control)butt_N3).Size = size;
		((Control)Butt_N).TabIndex = 768;
		((ButtonBase)Butt_N).Text = "N";
		((ButtonBase)Butt_N).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_N).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_3).BackColor = Color.Transparent;
		((Control)Butt_3).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_3).Cursor = Cursors.Hand;
		((Control)Butt_3).Dock = (DockStyle)5;
		((ButtonBase)Butt_3).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_3).FlatStyle = (FlatStyle)0;
		((Control)Butt_3).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_3).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_7 = Butt_3;
		location = new Point(135, 1);
		((Control)butt_7).Location = location;
		Button_CLAVIER_NOSELECT butt_8 = Butt_3;
		margin = new Padding(0);
		((Control)butt_8).Margin = margin;
		((Control)Butt_3).Name = "Butt_3";
		Button_CLAVIER_NOSELECT butt_9 = Butt_3;
		size = new Size(67, 40);
		((Control)butt_9).Size = size;
		((Control)Butt_3).TabIndex = 771;
		((ButtonBase)Butt_3).Text = "3";
		((ButtonBase)Butt_3).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_3).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_B).BackColor = Color.Transparent;
		((Control)Butt_B).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_B).Cursor = Cursors.Hand;
		((Control)Butt_B).Dock = (DockStyle)5;
		((ButtonBase)Butt_B).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_B).FlatStyle = (FlatStyle)0;
		((Control)Butt_B).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_B).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_B = Butt_B;
		location = new Point(403, 121);
		((Control)butt_B).Location = location;
		Button_CLAVIER_NOSELECT butt_B2 = Butt_B;
		margin = new Padding(0);
		((Control)butt_B2).Margin = margin;
		((Control)Butt_B).Name = "Butt_B";
		Button_CLAVIER_NOSELECT butt_B3 = Butt_B;
		size = new Size(67, 40);
		((Control)butt_B3).Size = size;
		((Control)Butt_B).TabIndex = 735;
		((ButtonBase)Butt_B).Text = "B";
		((ButtonBase)Butt_B).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_B).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_4).BackColor = Color.Transparent;
		((Control)Butt_4).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_4).Cursor = Cursors.Hand;
		((Control)Butt_4).Dock = (DockStyle)5;
		((ButtonBase)Butt_4).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_4).FlatStyle = (FlatStyle)0;
		((Control)Butt_4).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_4).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_10 = Butt_4;
		location = new Point(202, 1);
		((Control)butt_10).Location = location;
		Button_CLAVIER_NOSELECT butt_11 = Butt_4;
		margin = new Padding(0);
		((Control)butt_11).Margin = margin;
		((Control)Butt_4).Name = "Butt_4";
		Button_CLAVIER_NOSELECT butt_12 = Butt_4;
		size = new Size(67, 40);
		((Control)butt_12).Size = size;
		((Control)Butt_4).TabIndex = 776;
		((ButtonBase)Butt_4).Text = "4";
		((ButtonBase)Butt_4).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_4).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_V).BackColor = Color.Transparent;
		((Control)Butt_V).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_V).Cursor = Cursors.Hand;
		((Control)Butt_V).Dock = (DockStyle)5;
		((ButtonBase)Butt_V).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_V).FlatStyle = (FlatStyle)0;
		((Control)Butt_V).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_V).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_V = Butt_V;
		location = new Point(336, 121);
		((Control)butt_V).Location = location;
		Button_CLAVIER_NOSELECT butt_V2 = Butt_V;
		margin = new Padding(0);
		((Control)butt_V2).Margin = margin;
		((Control)Butt_V).Name = "Butt_V";
		Button_CLAVIER_NOSELECT butt_V3 = Butt_V;
		size = new Size(67, 40);
		((Control)butt_V3).Size = size;
		((Control)Butt_V).TabIndex = 766;
		((ButtonBase)Butt_V).Text = "V";
		((ButtonBase)Butt_V).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_V).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_5).BackColor = Color.Transparent;
		((Control)Butt_5).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_5).Cursor = Cursors.Hand;
		((Control)Butt_5).Dock = (DockStyle)5;
		((ButtonBase)Butt_5).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_5).FlatStyle = (FlatStyle)0;
		((Control)Butt_5).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_5).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_13 = Butt_5;
		location = new Point(269, 1);
		((Control)butt_13).Location = location;
		Button_CLAVIER_NOSELECT butt_14 = Butt_5;
		margin = new Padding(0);
		((Control)butt_14).Margin = margin;
		((Control)Butt_5).Name = "Butt_5";
		Button_CLAVIER_NOSELECT butt_15 = Butt_5;
		size = new Size(67, 40);
		((Control)butt_15).Size = size;
		((Control)Butt_5).TabIndex = 774;
		((ButtonBase)Butt_5).Text = "5";
		((ButtonBase)Butt_5).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_5).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_C).BackColor = Color.Transparent;
		((Control)Butt_C).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_C).Cursor = Cursors.Hand;
		((Control)Butt_C).Dock = (DockStyle)5;
		((ButtonBase)Butt_C).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_C).FlatStyle = (FlatStyle)0;
		((Control)Butt_C).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_C).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_C = Butt_C;
		location = new Point(269, 121);
		((Control)butt_C).Location = location;
		Button_CLAVIER_NOSELECT butt_C2 = Butt_C;
		margin = new Padding(0);
		((Control)butt_C2).Margin = margin;
		((Control)Butt_C).Name = "Butt_C";
		Button_CLAVIER_NOSELECT butt_C3 = Butt_C;
		size = new Size(67, 40);
		((Control)butt_C3).Size = size;
		((Control)Butt_C).TabIndex = 734;
		((ButtonBase)Butt_C).Text = "C";
		((ButtonBase)Butt_C).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_C).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_6).BackColor = Color.Transparent;
		((Control)Butt_6).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_6).Cursor = Cursors.Hand;
		((Control)Butt_6).Dock = (DockStyle)5;
		((ButtonBase)Butt_6).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_6).FlatStyle = (FlatStyle)0;
		((Control)Butt_6).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_6).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_16 = Butt_6;
		location = new Point(336, 1);
		((Control)butt_16).Location = location;
		Button_CLAVIER_NOSELECT butt_17 = Butt_6;
		margin = new Padding(0);
		((Control)butt_17).Margin = margin;
		((Control)Butt_6).Name = "Butt_6";
		Button_CLAVIER_NOSELECT butt_18 = Butt_6;
		size = new Size(67, 40);
		((Control)butt_18).Size = size;
		((Control)Butt_6).TabIndex = 777;
		((ButtonBase)Butt_6).Text = "6";
		((ButtonBase)Butt_6).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_6).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_X).BackColor = Color.Transparent;
		((Control)Butt_X).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_X).Cursor = Cursors.Hand;
		((Control)Butt_X).Dock = (DockStyle)5;
		((ButtonBase)Butt_X).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_X).FlatStyle = (FlatStyle)0;
		((Control)Butt_X).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_X).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_X = Butt_X;
		location = new Point(202, 121);
		((Control)butt_X).Location = location;
		Button_CLAVIER_NOSELECT butt_X2 = Butt_X;
		margin = new Padding(0);
		((Control)butt_X2).Margin = margin;
		((Control)Butt_X).Name = "Butt_X";
		Button_CLAVIER_NOSELECT butt_X3 = Butt_X;
		size = new Size(67, 40);
		((Control)butt_X3).Size = size;
		((Control)Butt_X).TabIndex = 764;
		((ButtonBase)Butt_X).Text = "X";
		((ButtonBase)Butt_X).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_X).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_7).BackColor = Color.Transparent;
		((Control)Butt_7).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_7).Cursor = Cursors.Hand;
		((Control)Butt_7).Dock = (DockStyle)5;
		((ButtonBase)Butt_7).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_7).FlatStyle = (FlatStyle)0;
		((Control)Butt_7).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_7).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_19 = Butt_7;
		location = new Point(403, 1);
		((Control)butt_19).Location = location;
		Button_CLAVIER_NOSELECT butt_20 = Butt_7;
		margin = new Padding(0);
		((Control)butt_20).Margin = margin;
		((Control)Butt_7).Name = "Butt_7";
		Button_CLAVIER_NOSELECT butt_21 = Butt_7;
		size = new Size(67, 40);
		((Control)butt_21).Size = size;
		((Control)Butt_7).TabIndex = 778;
		((ButtonBase)Butt_7).Text = "7";
		((ButtonBase)Butt_7).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_7).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_W).BackColor = Color.Transparent;
		((Control)Butt_W).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_W).Cursor = Cursors.Hand;
		((Control)Butt_W).Dock = (DockStyle)5;
		((ButtonBase)Butt_W).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_W).FlatStyle = (FlatStyle)0;
		((Control)Butt_W).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_W).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_W = Butt_W;
		location = new Point(135, 121);
		((Control)butt_W).Location = location;
		Button_CLAVIER_NOSELECT butt_W2 = Butt_W;
		margin = new Padding(0);
		((Control)butt_W2).Margin = margin;
		((Control)Butt_W).Name = "Butt_W";
		Button_CLAVIER_NOSELECT butt_W3 = Butt_W;
		size = new Size(67, 40);
		((Control)butt_W3).Size = size;
		((Control)Butt_W).TabIndex = 763;
		((ButtonBase)Butt_W).Text = "W";
		((ButtonBase)Butt_W).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_W).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_8).BackColor = Color.Transparent;
		((Control)Butt_8).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_8).Cursor = Cursors.Hand;
		((Control)Butt_8).Dock = (DockStyle)5;
		((ButtonBase)Butt_8).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_8).FlatStyle = (FlatStyle)0;
		((Control)Butt_8).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_8).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_22 = Butt_8;
		location = new Point(470, 1);
		((Control)butt_22).Location = location;
		Button_CLAVIER_NOSELECT butt_23 = Butt_8;
		margin = new Padding(0);
		((Control)butt_23).Margin = margin;
		((Control)Butt_8).Name = "Butt_8";
		Button_CLAVIER_NOSELECT butt_24 = Butt_8;
		size = new Size(67, 40);
		((Control)butt_24).Size = size;
		((Control)Butt_8).TabIndex = 779;
		((ButtonBase)Butt_8).Text = "8";
		((ButtonBase)Butt_8).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_8).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_9).BackColor = Color.Transparent;
		((Control)Butt_9).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_9).Cursor = Cursors.Hand;
		((Control)Butt_9).Dock = (DockStyle)5;
		((ButtonBase)Butt_9).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_9).FlatStyle = (FlatStyle)0;
		((Control)Butt_9).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_9).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_25 = Butt_9;
		location = new Point(537, 1);
		((Control)butt_25).Location = location;
		Button_CLAVIER_NOSELECT butt_26 = Butt_9;
		margin = new Padding(0);
		((Control)butt_26).Margin = margin;
		((Control)Butt_9).Name = "Butt_9";
		Button_CLAVIER_NOSELECT butt_27 = Butt_9;
		size = new Size(67, 40);
		((Control)butt_27).Size = size;
		((Control)Butt_9).TabIndex = 775;
		((ButtonBase)Butt_9).Text = "9";
		((ButtonBase)Butt_9).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_9).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_0).BackColor = Color.Transparent;
		((Control)Butt_0).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_0).Cursor = Cursors.Hand;
		((Control)Butt_0).Dock = (DockStyle)5;
		((ButtonBase)Butt_0).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_0).FlatStyle = (FlatStyle)0;
		((Control)Butt_0).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_0).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_28 = Butt_0;
		location = new Point(604, 1);
		((Control)butt_28).Location = location;
		Button_CLAVIER_NOSELECT butt_29 = Butt_0;
		margin = new Padding(0);
		((Control)butt_29).Margin = margin;
		((Control)Butt_0).Name = "Butt_0";
		Button_CLAVIER_NOSELECT butt_30 = Butt_0;
		size = new Size(67, 40);
		((Control)butt_30).Size = size;
		((Control)Butt_0).TabIndex = 781;
		((ButtonBase)Butt_0).Text = "0";
		((ButtonBase)Butt_0).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_0).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_M).BackColor = Color.Transparent;
		((Control)Butt_M).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_M).Cursor = Cursors.Hand;
		((Control)Butt_M).Dock = (DockStyle)5;
		((ButtonBase)Butt_M).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_M).FlatStyle = (FlatStyle)0;
		((Control)Butt_M).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_M).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_M = Butt_M;
		location = new Point(671, 81);
		((Control)butt_M).Location = location;
		Button_CLAVIER_NOSELECT butt_M2 = Butt_M;
		margin = new Padding(0);
		((Control)butt_M2).Margin = margin;
		((Control)Butt_M).Name = "Butt_M";
		Button_CLAVIER_NOSELECT butt_M3 = Butt_M;
		size = new Size(67, 40);
		((Control)butt_M3).Size = size;
		((Control)Butt_M).TabIndex = 762;
		((ButtonBase)Butt_M).Text = "M";
		((ButtonBase)Butt_M).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_M).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_A).BackColor = Color.Transparent;
		((Control)Butt_A).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_A).CausesValidation = false;
		((Control)Butt_A).Cursor = Cursors.Hand;
		((Control)Butt_A).Dock = (DockStyle)5;
		((ButtonBase)Butt_A).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_A).FlatStyle = (FlatStyle)0;
		((Control)Butt_A).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_A).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_A = Butt_A;
		location = new Point(1, 41);
		((Control)butt_A).Location = location;
		Button_CLAVIER_NOSELECT butt_A2 = Butt_A;
		margin = new Padding(0);
		((Control)butt_A2).Margin = margin;
		((Control)Butt_A).Name = "Butt_A";
		Button_CLAVIER_NOSELECT butt_A3 = Butt_A;
		size = new Size(67, 40);
		((Control)butt_A3).Size = size;
		((Control)Butt_A).TabIndex = 743;
		((ButtonBase)Butt_A).Text = "A";
		((ButtonBase)Butt_A).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_A).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_L).BackColor = Color.Transparent;
		((Control)Butt_L).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_L).Cursor = Cursors.Hand;
		((Control)Butt_L).Dock = (DockStyle)5;
		((ButtonBase)Butt_L).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_L).FlatStyle = (FlatStyle)0;
		((Control)Butt_L).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_L).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_L = Butt_L;
		location = new Point(604, 81);
		((Control)butt_L).Location = location;
		Button_CLAVIER_NOSELECT butt_L2 = Butt_L;
		margin = new Padding(0);
		((Control)butt_L2).Margin = margin;
		((Control)Butt_L).Name = "Butt_L";
		Button_CLAVIER_NOSELECT butt_L3 = Butt_L;
		size = new Size(67, 40);
		((Control)butt_L3).Size = size;
		((Control)Butt_L).TabIndex = 761;
		((ButtonBase)Butt_L).Text = "L";
		((ButtonBase)Butt_L).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_L).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_Z).BackColor = Color.Transparent;
		((Control)Butt_Z).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_Z).Cursor = Cursors.Hand;
		((Control)Butt_Z).Dock = (DockStyle)5;
		((ButtonBase)Butt_Z).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_Z).FlatStyle = (FlatStyle)0;
		((Control)Butt_Z).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_Z).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_Z = Butt_Z;
		location = new Point(68, 41);
		((Control)butt_Z).Location = location;
		Button_CLAVIER_NOSELECT butt_Z2 = Butt_Z;
		margin = new Padding(0);
		((Control)butt_Z2).Margin = margin;
		((Control)Butt_Z).Name = "Butt_Z";
		Button_CLAVIER_NOSELECT butt_Z3 = Butt_Z;
		size = new Size(67, 40);
		((Control)butt_Z3).Size = size;
		((Control)Butt_Z).TabIndex = 744;
		((ButtonBase)Butt_Z).Text = "Z";
		((ButtonBase)Butt_Z).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_Z).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_K).BackColor = Color.Transparent;
		((Control)Butt_K).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_K).Cursor = Cursors.Hand;
		((Control)Butt_K).Dock = (DockStyle)5;
		((ButtonBase)Butt_K).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_K).FlatStyle = (FlatStyle)0;
		((Control)Butt_K).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_K).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_K = Butt_K;
		location = new Point(537, 81);
		((Control)butt_K).Location = location;
		Button_CLAVIER_NOSELECT butt_K2 = Butt_K;
		margin = new Padding(0);
		((Control)butt_K2).Margin = margin;
		((Control)Butt_K).Name = "Butt_K";
		Button_CLAVIER_NOSELECT butt_K3 = Butt_K;
		size = new Size(67, 40);
		((Control)butt_K3).Size = size;
		((Control)Butt_K).TabIndex = 760;
		((ButtonBase)Butt_K).Text = "K";
		((ButtonBase)Butt_K).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_K).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_E).BackColor = Color.Transparent;
		((Control)Butt_E).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_E).Cursor = Cursors.Hand;
		((Control)Butt_E).Dock = (DockStyle)5;
		((ButtonBase)Butt_E).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_E).FlatStyle = (FlatStyle)0;
		((Control)Butt_E).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_E).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_E = Butt_E;
		location = new Point(135, 41);
		((Control)butt_E).Location = location;
		Button_CLAVIER_NOSELECT butt_E2 = Butt_E;
		margin = new Padding(0);
		((Control)butt_E2).Margin = margin;
		((Control)Butt_E).Name = "Butt_E";
		Button_CLAVIER_NOSELECT butt_E3 = Butt_E;
		size = new Size(67, 40);
		((Control)butt_E3).Size = size;
		((Control)Butt_E).TabIndex = 745;
		((ButtonBase)Butt_E).Text = "E";
		((ButtonBase)Butt_E).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_E).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_J).BackColor = Color.Transparent;
		((Control)Butt_J).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_J).Cursor = Cursors.Hand;
		((Control)Butt_J).Dock = (DockStyle)5;
		((ButtonBase)Butt_J).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_J).FlatStyle = (FlatStyle)0;
		((Control)Butt_J).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_J).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_J = Butt_J;
		location = new Point(470, 81);
		((Control)butt_J).Location = location;
		Button_CLAVIER_NOSELECT butt_J2 = Butt_J;
		margin = new Padding(0);
		((Control)butt_J2).Margin = margin;
		((Control)Butt_J).Name = "Butt_J";
		Button_CLAVIER_NOSELECT butt_J3 = Butt_J;
		size = new Size(67, 40);
		((Control)butt_J3).Size = size;
		((Control)Butt_J).TabIndex = 759;
		((ButtonBase)Butt_J).Text = "J";
		((ButtonBase)Butt_J).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_J).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_R).BackColor = Color.Transparent;
		((Control)Butt_R).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_R).Cursor = Cursors.Hand;
		((Control)Butt_R).Dock = (DockStyle)5;
		((ButtonBase)Butt_R).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_R).FlatStyle = (FlatStyle)0;
		((Control)Butt_R).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_R).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_R = Butt_R;
		location = new Point(202, 41);
		((Control)butt_R).Location = location;
		Button_CLAVIER_NOSELECT butt_R2 = Butt_R;
		margin = new Padding(0);
		((Control)butt_R2).Margin = margin;
		((Control)Butt_R).Name = "Butt_R";
		Button_CLAVIER_NOSELECT butt_R3 = Butt_R;
		size = new Size(67, 40);
		((Control)butt_R3).Size = size;
		((Control)Butt_R).TabIndex = 746;
		((ButtonBase)Butt_R).Text = "R";
		((ButtonBase)Butt_R).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_R).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_H).BackColor = Color.Transparent;
		((Control)Butt_H).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_H).Cursor = Cursors.Hand;
		((Control)Butt_H).Dock = (DockStyle)5;
		((ButtonBase)Butt_H).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_H).FlatStyle = (FlatStyle)0;
		((Control)Butt_H).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_H).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_H = Butt_H;
		location = new Point(403, 81);
		((Control)butt_H).Location = location;
		Button_CLAVIER_NOSELECT butt_H2 = Butt_H;
		margin = new Padding(0);
		((Control)butt_H2).Margin = margin;
		((Control)Butt_H).Name = "Butt_H";
		Button_CLAVIER_NOSELECT butt_H3 = Butt_H;
		size = new Size(67, 40);
		((Control)butt_H3).Size = size;
		((Control)Butt_H).TabIndex = 758;
		((ButtonBase)Butt_H).Text = "H";
		((ButtonBase)Butt_H).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_H).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_T).BackColor = Color.Transparent;
		((Control)Butt_T).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_T).Cursor = Cursors.Hand;
		((Control)Butt_T).Dock = (DockStyle)5;
		((ButtonBase)Butt_T).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_T).FlatStyle = (FlatStyle)0;
		((Control)Butt_T).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_T).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_T = Butt_T;
		location = new Point(269, 41);
		((Control)butt_T).Location = location;
		Button_CLAVIER_NOSELECT butt_T2 = Butt_T;
		margin = new Padding(0);
		((Control)butt_T2).Margin = margin;
		((Control)Butt_T).Name = "Butt_T";
		Button_CLAVIER_NOSELECT butt_T3 = Butt_T;
		size = new Size(67, 40);
		((Control)butt_T3).Size = size;
		((Control)Butt_T).TabIndex = 747;
		((ButtonBase)Butt_T).Text = "T";
		((ButtonBase)Butt_T).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_T).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_G).BackColor = Color.Transparent;
		((Control)Butt_G).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_G).Cursor = Cursors.Hand;
		((Control)Butt_G).Dock = (DockStyle)5;
		((ButtonBase)Butt_G).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_G).FlatStyle = (FlatStyle)0;
		((Control)Butt_G).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_G).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_G = Butt_G;
		location = new Point(336, 81);
		((Control)butt_G).Location = location;
		Button_CLAVIER_NOSELECT butt_G2 = Butt_G;
		margin = new Padding(0);
		((Control)butt_G2).Margin = margin;
		((Control)Butt_G).Name = "Butt_G";
		Button_CLAVIER_NOSELECT butt_G3 = Butt_G;
		size = new Size(67, 40);
		((Control)butt_G3).Size = size;
		((Control)Butt_G).TabIndex = 757;
		((ButtonBase)Butt_G).Text = "G";
		((ButtonBase)Butt_G).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_G).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_Y).BackColor = Color.Transparent;
		((Control)Butt_Y).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_Y).Cursor = Cursors.Hand;
		((Control)Butt_Y).Dock = (DockStyle)5;
		((ButtonBase)Butt_Y).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_Y).FlatStyle = (FlatStyle)0;
		((Control)Butt_Y).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_Y).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_Y = Butt_Y;
		location = new Point(336, 41);
		((Control)butt_Y).Location = location;
		Button_CLAVIER_NOSELECT butt_Y2 = Butt_Y;
		margin = new Padding(0);
		((Control)butt_Y2).Margin = margin;
		((Control)Butt_Y).Name = "Butt_Y";
		Button_CLAVIER_NOSELECT butt_Y3 = Butt_Y;
		size = new Size(67, 40);
		((Control)butt_Y3).Size = size;
		((Control)Butt_Y).TabIndex = 748;
		((ButtonBase)Butt_Y).Text = "Y";
		((ButtonBase)Butt_Y).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_Y).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_F).BackColor = Color.Transparent;
		((Control)Butt_F).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_F).Cursor = Cursors.Hand;
		((Control)Butt_F).Dock = (DockStyle)5;
		((ButtonBase)Butt_F).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_F).FlatStyle = (FlatStyle)0;
		((Control)Butt_F).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_F).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_F = Butt_F;
		location = new Point(269, 81);
		((Control)butt_F).Location = location;
		Button_CLAVIER_NOSELECT butt_F2 = Butt_F;
		margin = new Padding(0);
		((Control)butt_F2).Margin = margin;
		((Control)Butt_F).Name = "Butt_F";
		Button_CLAVIER_NOSELECT butt_F3 = Butt_F;
		size = new Size(67, 40);
		((Control)butt_F3).Size = size;
		((Control)Butt_F).TabIndex = 756;
		((ButtonBase)Butt_F).Text = "F";
		((ButtonBase)Butt_F).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_F).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_U).BackColor = Color.Transparent;
		((Control)Butt_U).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_U).Cursor = Cursors.Hand;
		((Control)Butt_U).Dock = (DockStyle)5;
		((ButtonBase)Butt_U).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_U).FlatStyle = (FlatStyle)0;
		((Control)Butt_U).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_U).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_U = Butt_U;
		location = new Point(403, 41);
		((Control)butt_U).Location = location;
		Button_CLAVIER_NOSELECT butt_U2 = Butt_U;
		margin = new Padding(0);
		((Control)butt_U2).Margin = margin;
		((Control)Butt_U).Name = "Butt_U";
		Button_CLAVIER_NOSELECT butt_U3 = Butt_U;
		size = new Size(67, 40);
		((Control)butt_U3).Size = size;
		((Control)Butt_U).TabIndex = 749;
		((ButtonBase)Butt_U).Text = "U";
		((ButtonBase)Butt_U).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_U).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_D).BackColor = Color.Transparent;
		((Control)Butt_D).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_D).Cursor = Cursors.Hand;
		((Control)Butt_D).Dock = (DockStyle)5;
		((ButtonBase)Butt_D).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_D).FlatStyle = (FlatStyle)0;
		((Control)Butt_D).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_D).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_D = Butt_D;
		location = new Point(202, 81);
		((Control)butt_D).Location = location;
		Button_CLAVIER_NOSELECT butt_D2 = Butt_D;
		margin = new Padding(0);
		((Control)butt_D2).Margin = margin;
		((Control)Butt_D).Name = "Butt_D";
		Button_CLAVIER_NOSELECT butt_D3 = Butt_D;
		size = new Size(67, 40);
		((Control)butt_D3).Size = size;
		((Control)Butt_D).TabIndex = 755;
		((ButtonBase)Butt_D).Text = "D";
		((ButtonBase)Butt_D).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_D).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_I).BackColor = Color.Transparent;
		((Control)Butt_I).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_I).Cursor = Cursors.Hand;
		((Control)Butt_I).Dock = (DockStyle)5;
		((ButtonBase)Butt_I).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_I).FlatStyle = (FlatStyle)0;
		((Control)Butt_I).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_I).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_I = Butt_I;
		location = new Point(470, 41);
		((Control)butt_I).Location = location;
		Button_CLAVIER_NOSELECT butt_I2 = Butt_I;
		margin = new Padding(0);
		((Control)butt_I2).Margin = margin;
		((Control)Butt_I).Name = "Butt_I";
		Button_CLAVIER_NOSELECT butt_I3 = Butt_I;
		size = new Size(67, 40);
		((Control)butt_I3).Size = size;
		((Control)Butt_I).TabIndex = 750;
		((ButtonBase)Butt_I).Text = "I";
		((ButtonBase)Butt_I).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_I).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_S).BackColor = Color.Transparent;
		((Control)Butt_S).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_S).Cursor = Cursors.Hand;
		((Control)Butt_S).Dock = (DockStyle)5;
		((ButtonBase)Butt_S).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_S).FlatStyle = (FlatStyle)0;
		((Control)Butt_S).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_S).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_S = Butt_S;
		location = new Point(135, 81);
		((Control)butt_S).Location = location;
		Button_CLAVIER_NOSELECT butt_S2 = Butt_S;
		margin = new Padding(0);
		((Control)butt_S2).Margin = margin;
		((Control)Butt_S).Name = "Butt_S";
		Button_CLAVIER_NOSELECT butt_S3 = Butt_S;
		size = new Size(67, 40);
		((Control)butt_S3).Size = size;
		((Control)Butt_S).TabIndex = 754;
		((ButtonBase)Butt_S).Text = "S";
		((ButtonBase)Butt_S).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_S).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_O).BackColor = Color.Transparent;
		((Control)Butt_O).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_O).Cursor = Cursors.Hand;
		((Control)Butt_O).Dock = (DockStyle)5;
		((ButtonBase)Butt_O).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_O).FlatStyle = (FlatStyle)0;
		((Control)Butt_O).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_O).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_O = Butt_O;
		location = new Point(537, 41);
		((Control)butt_O).Location = location;
		Button_CLAVIER_NOSELECT butt_O2 = Butt_O;
		margin = new Padding(0);
		((Control)butt_O2).Margin = margin;
		((Control)Butt_O).Name = "Butt_O";
		Button_CLAVIER_NOSELECT butt_O3 = Butt_O;
		size = new Size(67, 40);
		((Control)butt_O3).Size = size;
		((Control)Butt_O).TabIndex = 751;
		((ButtonBase)Butt_O).Text = "O";
		((ButtonBase)Butt_O).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_O).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_Q).BackColor = Color.Transparent;
		((Control)Butt_Q).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_Q).Cursor = Cursors.Hand;
		((Control)Butt_Q).Dock = (DockStyle)5;
		((ButtonBase)Butt_Q).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_Q).FlatStyle = (FlatStyle)0;
		((Control)Butt_Q).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_Q).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_Q = Butt_Q;
		location = new Point(68, 81);
		((Control)butt_Q).Location = location;
		Button_CLAVIER_NOSELECT butt_Q2 = Butt_Q;
		margin = new Padding(0);
		((Control)butt_Q2).Margin = margin;
		((Control)Butt_Q).Name = "Butt_Q";
		Button_CLAVIER_NOSELECT butt_Q3 = Butt_Q;
		size = new Size(67, 40);
		((Control)butt_Q3).Size = size;
		((Control)Butt_Q).TabIndex = 753;
		((ButtonBase)Butt_Q).Text = "Q";
		((ButtonBase)Butt_Q).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_Q).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_P).BackColor = Color.Transparent;
		((Control)Butt_P).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_P).Cursor = Cursors.Hand;
		((Control)Butt_P).Dock = (DockStyle)5;
		((ButtonBase)Butt_P).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_P).FlatStyle = (FlatStyle)0;
		((Control)Butt_P).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Butt_P).ForeColor = Color.White;
		Button_CLAVIER_NOSELECT butt_P = Butt_P;
		location = new Point(604, 41);
		((Control)butt_P).Location = location;
		Button_CLAVIER_NOSELECT butt_P2 = Butt_P;
		margin = new Padding(0);
		((Control)butt_P2).Margin = margin;
		((Control)Butt_P).Name = "Butt_P";
		Button_CLAVIER_NOSELECT butt_P3 = Butt_P;
		size = new Size(67, 40);
		((Control)butt_P3).Size = size;
		((Control)Butt_P).TabIndex = 752;
		((ButtonBase)Butt_P).Text = "P";
		((ButtonBase)Butt_P).TextAlign = (ContentAlignment)1;
		((ButtonBase)Butt_P).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_BACK).BackColor = Color.Transparent;
		((Control)Butt_BACK).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_BACK).Cursor = Cursors.Hand;
		((Control)Butt_BACK).Dock = (DockStyle)5;
		((ButtonBase)Butt_BACK).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_BACK).FlatStyle = (FlatStyle)0;
		((Control)Butt_BACK).Font = new Font("Calibri", 20.25f, (FontStyle)1);
		((Control)Butt_BACK).ForeColor = Color.White;
		((ButtonBase)Butt_BACK).Image = (Image)componentResourceManager.GetObject("Butt_BACK.Image");
		Button_CLAVIER_NOSELECT butt_BACK = Butt_BACK;
		location = new Point(738, 1);
		((Control)butt_BACK).Location = location;
		Button_CLAVIER_NOSELECT butt_BACK2 = Butt_BACK;
		margin = new Padding(0);
		((Control)butt_BACK2).Margin = margin;
		((Control)Butt_BACK).Name = "Butt_BACK";
		Button_CLAVIER_NOSELECT butt_BACK3 = Butt_BACK;
		size = new Size(79, 40);
		((Control)butt_BACK3).Size = size;
		((Control)Butt_BACK).TabIndex = 769;
		((ButtonBase)Butt_BACK).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_DRAFT).BackColor = Color.Transparent;
		((Control)Butt_DRAFT).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_DRAFT).Cursor = Cursors.Hand;
		((Control)Butt_DRAFT).Dock = (DockStyle)5;
		((ButtonBase)Butt_DRAFT).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_DRAFT).FlatStyle = (FlatStyle)0;
		((Control)Butt_DRAFT).Font = new Font("Calibri", 12f, (FontStyle)1);
		((Control)Butt_DRAFT).ForeColor = Color.White;
		((ButtonBase)Butt_DRAFT).Image = (Image)componentResourceManager.GetObject("Butt_DRAFT.Image");
		Button_CLAVIER_NOSELECT butt_DRAFT = Butt_DRAFT;
		location = new Point(738, 41);
		((Control)butt_DRAFT).Location = location;
		Button_CLAVIER_NOSELECT butt_DRAFT2 = Butt_DRAFT;
		margin = new Padding(0);
		((Control)butt_DRAFT2).Margin = margin;
		((Control)Butt_DRAFT).Name = "Butt_DRAFT";
		Button_CLAVIER_NOSELECT butt_DRAFT3 = Butt_DRAFT;
		size = new Size(79, 40);
		((Control)butt_DRAFT3).Size = size;
		((Control)Butt_DRAFT).TabIndex = 770;
		((ButtonBase)Butt_DRAFT).UseVisualStyleBackColor = false;
		((Control)TableLayoutPanel3).BackColor = Color.FromArgb(51, 51, 51);
		TableLayoutPanel3.ColumnCount = 3;
		TableLayoutPanel3.ColumnStyles.Add(new ColumnStyle((SizeType)1, 100f));
		TableLayoutPanel3.ColumnStyles.Add(new ColumnStyle((SizeType)2, 100f));
		TableLayoutPanel3.ColumnStyles.Add(new ColumnStyle((SizeType)1, 100f));
		TableLayoutPanel3.Controls.Add((Control)(object)Butt_SPACE, 1, 0);
		((Control)TableLayoutPanel3).Dock = (DockStyle)2;
		TableLayoutPanel tableLayoutPanel4 = TableLayoutPanel3;
		location = new Point(0, 162);
		((Control)tableLayoutPanel4).Location = location;
		((Control)TableLayoutPanel3).Name = "TableLayoutPanel3";
		TableLayoutPanel tableLayoutPanel5 = TableLayoutPanel3;
		margin = new Padding(1);
		((Control)tableLayoutPanel5).Padding = margin;
		TableLayoutPanel3.RowCount = 1;
		TableLayoutPanel3.RowStyles.Add(new RowStyle((SizeType)2, 100f));
		TableLayoutPanel tableLayoutPanel6 = TableLayoutPanel3;
		size = new Size(818, 51);
		((Control)tableLayoutPanel6).Size = size;
		((Control)TableLayoutPanel3).TabIndex = 1053;
		((ButtonBase)Butt_SPACE).BackColor = Color.Transparent;
		((Control)Butt_SPACE).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_SPACE).Cursor = Cursors.Hand;
		((Control)Butt_SPACE).Dock = (DockStyle)5;
		((ButtonBase)Butt_SPACE).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_SPACE).FlatStyle = (FlatStyle)0;
		((Control)Butt_SPACE).Font = new Font("Calibri", 20.25f, (FontStyle)1);
		((Control)Butt_SPACE).ForeColor = Color.Black;
		((ButtonBase)Butt_SPACE).Image = (Image)componentResourceManager.GetObject("Butt_SPACE.Image");
		Button_CLAVIER_NOSELECT butt_SPACE = Butt_SPACE;
		location = new Point(101, 1);
		((Control)butt_SPACE).Location = location;
		Button_CLAVIER_NOSELECT butt_SPACE2 = Butt_SPACE;
		margin = new Padding(0);
		((Control)butt_SPACE2).Margin = margin;
		((Control)Butt_SPACE).Name = "Butt_SPACE";
		Button_CLAVIER_NOSELECT butt_SPACE3 = Butt_SPACE;
		size = new Size(616, 49);
		((Control)butt_SPACE3).Size = size;
		((Control)Butt_SPACE).TabIndex = 785;
		((ButtonBase)Butt_SPACE).UseVisualStyleBackColor = false;
		((Control)Panel5).Controls.Add((Control)(object)Button1212);
		((Control)Panel5).Controls.Add((Control)(object)Text_SOLUTION);
		Panel panel = Panel5;
		location = new Point(48, 16);
		((Control)panel).Location = location;
		((Control)Panel5).Name = "Panel5";
		Panel panel2 = Panel5;
		size = new Size(787, 21);
		((Control)panel2).Size = size;
		((Control)Panel5).TabIndex = 855;
		((Control)Panel5).Visible = false;
		((Control)Button1212).Font = new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((ButtonBase)Button1212).Image = (Image)componentResourceManager.GetObject("Button1212.Image");
		((ButtonBase)Button1212).ImageAlign = (ContentAlignment)16;
		Button button = Button1212;
		location = new Point(551, 3);
		((Control)button).Location = location;
		((Control)Button1212).Name = "Button1212";
		Button button2 = Button1212;
		size = new Size(52, 43);
		((Control)button2).Size = size;
		((Control)Button1212).TabIndex = 229;
		((ButtonBase)Button1212).Text = "OK";
		((ButtonBase)Button1212).TextAlign = (ContentAlignment)64;
		((ButtonBase)Button1212).UseVisualStyleBackColor = true;
		((TextBoxBase)Text_SOLUTION).BorderStyle = (BorderStyle)1;
		((Control)Text_SOLUTION).Font = new Font("Tahoma", 21.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		TextBox text_SOLUTION = Text_SOLUTION;
		location = new Point(183, 3);
		((Control)text_SOLUTION).Location = location;
		((Control)Text_SOLUTION).Name = "Text_SOLUTION";
		TextBox text_SOLUTION2 = Text_SOLUTION;
		size = new Size(420, 43);
		((Control)text_SOLUTION2).Size = size;
		((Control)Text_SOLUTION).TabIndex = 0;
		Text_SOLUTION.TextAlign = (HorizontalAlignment)2;
		((Control)Label12).BackColor = Color.Transparent;
		Label12.BorderStyle = (BorderStyle)1;
		((Control)Label12).Cursor = Cursors.Hand;
		((Control)Label12).Font = new Font("Calibri", 14.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0);
		((Control)Label12).ForeColor = Color.Black;
		Label label5 = Label12;
		location = new Point(40, 120);
		((Control)label5).Location = location;
		((Control)Label12).Name = "Label12";
		Label label6 = Label12;
		size = new Size(158, 25);
		((Control)label6).Size = size;
		((Control)Label12).TabIndex = 222;
		Label12.Text = "Clé d'inscription  :";
		((Control)Panel2).Controls.Add((Control)(object)Label11);
		((Control)Panel2).Controls.Add((Control)(object)Label6);
		((Control)Panel2).Controls.Add((Control)(object)Label8);
		Panel panel3 = Panel2;
		location = new Point(231, 60);
		((Control)panel3).Location = location;
		((Control)Panel2).Name = "Panel2";
		Panel panel4 = Panel2;
		size = new Size(420, 49);
		((Control)panel4).Size = size;
		((Control)Panel2).TabIndex = 743;
		Label11.AutoSize = true;
		((Control)Label11).BackColor = Color.Transparent;
		((Control)Label11).Cursor = Cursors.Hand;
		((Control)Label11).Font = new Font("Cambria", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label11).ForeColor = Color.Red;
		Label label7 = Label11;
		location = new Point(13, 0);
		((Control)label7).Location = location;
		((Control)Label11).Name = "Label11";
		Label label8 = Label11;
		size = new Size(395, 15);
		((Control)label8).Size = size;
		((Control)Label11).TabIndex = 221;
		Label11.Text = "pour activer l'application, merci de Contacter l'équipe technique";
		Label6.AutoSize = true;
		((Control)Label6).BackColor = Color.Transparent;
		((Control)Label6).Cursor = Cursors.Hand;
		((Control)Label6).Font = new Font("Cambria", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label6).ForeColor = Color.Red;
		Label label9 = Label6;
		location = new Point(71, 17);
		((Control)label9).Location = location;
		((Control)Label6).Name = "Label6";
		Label label10 = Label6;
		size = new Size(278, 15);
		((Control)label10).Size = size;
		((Control)Label6).TabIndex = 741;
		Label6.Text = "ou appeler le numéro suivant :  0606620053";
		Label8.AutoSize = true;
		((Control)Label8).Cursor = Cursors.Hand;
		((Control)Label8).Font = new Font("Calibri", 11.25f);
		((Control)Label8).ForeColor = SystemColors.ScrollBar;
		Label label11 = Label8;
		location = new Point(134, 32);
		((Control)label11).Location = location;
		((Control)Label8).Name = "Label8";
		Label label12 = Label8;
		size = new Size(153, 18);
		((Control)label12).Size = size;
		((Control)Label8).TabIndex = 742;
		Label8.Text = "© LÓGICA - DEVELOPED";
		((Control)Button_ok).Font = new Font("Tahoma", 20.25f, (FontStyle)1);
		((Control)Button_ok).ForeColor = Color.FromArgb(2, 45, 162);
		((ButtonBase)Button_ok).Image = (Image)componentResourceManager.GetObject("Button_ok.Image");
		((ButtonBase)Button_ok).ImageAlign = (ContentAlignment)16;
		Button button_ok = Button_ok;
		location = new Point(369, 196);
		((Control)button_ok).Location = location;
		((Control)Button_ok).Name = "Button_ok";
		Button button_ok2 = Button_ok;
		size = new Size(145, 44);
		((Control)button_ok2).Size = size;
		((Control)Button_ok).TabIndex = 228;
		((ButtonBase)Button_ok).Text = "OK";
		((ButtonBase)Button_ok).UseVisualStyleBackColor = true;
		((Control)Label13).BackColor = Color.Transparent;
		Label13.BorderStyle = (BorderStyle)1;
		((Control)Label13).Cursor = Cursors.Hand;
		((Control)Label13).Font = new Font("Calibri", 14.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0);
		((Control)Label13).ForeColor = Color.Black;
		Label label13 = Label13;
		location = new Point(40, 153);
		((Control)label13).Location = location;
		((Control)Label13).Name = "Label13";
		Label label14 = Label13;
		size = new Size(158, 25);
		((Control)label14).Size = size;
		((Control)Label13).TabIndex = 223;
		Label13.Text = "Clé d'activation   :";
		((ButtonBase)Button_copier).FlatStyle = (FlatStyle)0;
		((ButtonBase)Button_copier).Image = (Image)componentResourceManager.GetObject("Button_copier.Image");
		Button button_copier = Button_copier;
		location = new Point(785, 120);
		((Control)button_copier).Location = location;
		((Control)Button_copier).Name = "Button_copier";
		Button button_copier2 = Button_copier;
		size = new Size(73, 27);
		((Control)button_copier2).Size = size;
		((Control)Button_copier).TabIndex = 737;
		((ButtonBase)Button_copier).Text = "Copier";
		((ButtonBase)Button_copier).TextImageRelation = (TextImageRelation)4;
		((ButtonBase)Button_copier).UseVisualStyleBackColor = true;
		((ButtonBase)Button_coller).FlatStyle = (FlatStyle)0;
		((ButtonBase)Button_coller).Image = (Image)componentResourceManager.GetObject("Button_coller.Image");
		Button button_coller = Button_coller;
		location = new Point(785, 153);
		((Control)button_coller).Location = location;
		((Control)Button_coller).Name = "Button_coller";
		Button button_coller2 = Button_coller;
		size = new Size(73, 27);
		((Control)button_coller2).Size = size;
		((Control)Button_coller).TabIndex = 741;
		((ButtonBase)Button_coller).Text = "Coller";
		((ButtonBase)Button_coller).TextImageRelation = (TextImageRelation)4;
		((ButtonBase)Button_coller).UseVisualStyleBackColor = true;
		((TextBoxBase)MaskedText_acti).BorderStyle = (BorderStyle)1;
		((Control)MaskedText_acti).Font = new Font("Tahoma", 12f, (FontStyle)1);
		MaskedTextBox maskedText_acti = MaskedText_acti;
		location = new Point(204, 153);
		((Control)maskedText_acti).Location = location;
		MaskedText_acti.Mask = "aaaa-aaaa-aaaa-aaaa-aaaa-aaaa-aaaa-aaaa-aaaa";
		((Control)MaskedText_acti).Name = "MaskedText_acti";
		MaskedTextBox maskedText_acti2 = MaskedText_acti;
		size = new Size(575, 27);
		((Control)maskedText_acti2).Size = size;
		((Control)MaskedText_acti).TabIndex = 739;
		MaskedText_acti.TextAlign = (HorizontalAlignment)2;
		((TextBoxBase)TextBox2).BackColor = Color.Red;
		TextBox textBox = TextBox2;
		location = new Point(829, 125);
		((Control)textBox).Location = location;
		((Control)TextBox2).Name = "TextBox2";
		TextBox textBox2 = TextBox2;
		size = new Size(10, 20);
		((Control)textBox2).Size = size;
		((Control)TextBox2).TabIndex = 227;
		((Control)TextBox2).Visible = false;
		((TextBoxBase)TextBox3).BackColor = Color.Red;
		TextBox textBox3 = TextBox3;
		location = new Point(829, 155);
		((Control)textBox3).Location = location;
		((Control)TextBox3).Name = "TextBox3";
		TextBox textBox4 = TextBox3;
		size = new Size(10, 20);
		((Control)textBox4).Size = size;
		((Control)TextBox3).TabIndex = 226;
		((Control)TextBox3).Visible = false;
		((TextBoxBase)Text_ara_reg).BackColor = Color.Red;
		TextBox text_ara_reg = Text_ara_reg;
		location = new Point(822, 153);
		((Control)text_ara_reg).Location = location;
		((Control)Text_ara_reg).Name = "Text_ara_reg";
		TextBox text_ara_reg2 = Text_ara_reg;
		size = new Size(10, 20);
		((Control)text_ara_reg2).Size = size;
		((Control)Text_ara_reg).TabIndex = 226;
		((Control)Text_ara_reg).Visible = false;
		((TextBoxBase)Text_ara_disk).BackColor = Color.Red;
		TextBox text_ara_disk = Text_ara_disk;
		location = new Point(822, 120);
		((Control)text_ara_disk).Location = location;
		((Control)Text_ara_disk).Name = "Text_ara_disk";
		TextBox text_ara_disk2 = Text_ara_disk;
		size = new Size(10, 20);
		((Control)text_ara_disk2).Size = size;
		((Control)Text_ara_disk).TabIndex = 227;
		((Control)Text_ara_disk).Visible = false;
		((Control)Panel_STATUT).BackColor = SystemColors.Control;
		((Control)Panel_STATUT).Controls.Add((Control)(object)Button_CLAVIER);
		((Control)Panel_STATUT).Controls.Add((Control)(object)Label_LANGUE);
		((Control)Panel_STATUT).Controls.Add((Control)(object)Label_CONNEXION_STATUT);
		((Control)Panel_STATUT).Controls.Add((Control)(object)Picture_ALERT);
		((Control)Panel_STATUT).Controls.Add((Control)(object)Label_GESTION_TABLE);
		((Control)Panel_STATUT).Controls.Add((Control)(object)Label_FOLDER);
		((Control)Panel_STATUT).Controls.Add((Control)(object)PictureBox1);
		((Control)Panel_STATUT).Controls.Add((Control)(object)Label_USERCATEGORIE);
		((Control)Panel_STATUT).Controls.Add((Control)(object)Label_USERNAME);
		((Control)Panel_STATUT).Controls.Add((Control)(object)Label_POSTE);
		((Control)Panel_STATUT).Controls.Add((Control)(object)Label_DATE);
		((Control)Panel_STATUT).Controls.Add((Control)(object)Label_CONNEXION);
		((Control)Panel_STATUT).Controls.Add((Control)(object)Label_DB);
		((Control)Panel_STATUT).Dock = (DockStyle)5;
		Panel panel_STATUT = Panel_STATUT;
		location = new Point(0, 688);
		((Control)panel_STATUT).Location = location;
		Panel panel_STATUT2 = Panel_STATUT;
		margin = new Padding(0);
		((Control)panel_STATUT2).Margin = margin;
		((Control)Panel_STATUT).Name = "Panel_STATUT";
		Panel panel_STATUT3 = Panel_STATUT;
		size = new Size(1052, 20);
		((Control)panel_STATUT3).Size = size;
		((Control)Panel_STATUT).TabIndex = 8;
		((Control)Button_CLAVIER).Anchor = (AnchorStyles)9;
		((Control)Button_CLAVIER).BackgroundImage = (Image)componentResourceManager.GetObject("Button_CLAVIER.BackgroundImage");
		((Control)Button_CLAVIER).BackgroundImageLayout = (ImageLayout)4;
		((ButtonBase)Button_CLAVIER).FlatAppearance.BorderSize = 0;
		((ButtonBase)Button_CLAVIER).FlatStyle = (FlatStyle)0;
		((ButtonBase)Button_CLAVIER).ImeMode = (ImeMode)0;
		Button_CLAVIER_NOSELECT button_CLAVIER = Button_CLAVIER;
		location = new Point(1017, 0);
		((Control)button_CLAVIER).Location = location;
		((Control)Button_CLAVIER).Name = "Button_CLAVIER";
		Button_CLAVIER_NOSELECT button_CLAVIER2 = Button_CLAVIER;
		size = new Size(36, 20);
		((Control)button_CLAVIER2).Size = size;
		((Control)Button_CLAVIER).TabIndex = 1030;
		((ButtonBase)Button_CLAVIER).UseVisualStyleBackColor = true;
		((Control)Label_LANGUE).Anchor = (AnchorStyles)9;
		((Control)Label_LANGUE).Font = new Font("Tahoma", 8f);
		((Control)Label_LANGUE).ForeColor = Color.Black;
		Label label_LANGUE = Label_LANGUE;
		location = new Point(988, 0);
		((Control)label_LANGUE).Location = location;
		((Control)Label_LANGUE).Name = "Label_LANGUE";
		Label label_LANGUE2 = Label_LANGUE;
		size = new Size(23, 20);
		((Control)label_LANGUE2).Size = size;
		((Control)Label_LANGUE).TabIndex = 1029;
		Label_LANGUE.Text = "-";
		Label_LANGUE.TextAlign = (ContentAlignment)32;
		((Control)Label_CONNEXION_STATUT).Anchor = (AnchorStyles)13;
		((Control)Label_CONNEXION_STATUT).Font = new Font("Calibri", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		Label label_CONNEXION_STATUT = Label_CONNEXION_STATUT;
		location = new Point(476, -2);
		((Control)label_CONNEXION_STATUT).Location = location;
		((Control)Label_CONNEXION_STATUT).Name = "Label_CONNEXION_STATUT";
		Label label_CONNEXION_STATUT2 = Label_CONNEXION_STATUT;
		size = new Size(101, 13);
		((Control)label_CONNEXION_STATUT2).Size = size;
		((Control)Label_CONNEXION_STATUT).TabIndex = 1028;
		Label_CONNEXION_STATUT.Text = "-";
		Label_CONNEXION_STATUT.TextAlign = (ContentAlignment)2;
		((Control)Picture_ALERT).Cursor = Cursors.Hand;
		Picture_ALERT.Image = (Image)componentResourceManager.GetObject("Picture_ALERT.Image");
		PictureBox picture_ALERT = Picture_ALERT;
		location = new Point(431, 0);
		((Control)picture_ALERT).Location = location;
		((Control)Picture_ALERT).Name = "Picture_ALERT";
		PictureBox picture_ALERT2 = Picture_ALERT;
		size = new Size(37, 20);
		((Control)picture_ALERT2).Size = size;
		Picture_ALERT.SizeMode = (PictureBoxSizeMode)4;
		Picture_ALERT.TabIndex = 1026;
		Picture_ALERT.TabStop = false;
		((Control)Picture_ALERT).Visible = false;
		((Control)Label_GESTION_TABLE).Font = new Font("Tahoma", 8f);
		((Control)Label_GESTION_TABLE).ForeColor = Color.Black;
		Label label_GESTION_TABLE = Label_GESTION_TABLE;
		location = new Point(363, 0);
		((Control)label_GESTION_TABLE).Location = location;
		((Control)Label_GESTION_TABLE).Name = "Label_GESTION_TABLE";
		Label label_GESTION_TABLE2 = Label_GESTION_TABLE;
		size = new Size(62, 20);
		((Control)label_GESTION_TABLE2).Size = size;
		((Control)Label_GESTION_TABLE).TabIndex = 1025;
		Label_GESTION_TABLE.Text = "-";
		Label_GESTION_TABLE.TextAlign = (ContentAlignment)32;
		((Control)Label_FOLDER).BackColor = Color.Transparent;
		((Control)Label_FOLDER).Font = new Font("Cambria", 7f);
		((Control)Label_FOLDER).ForeColor = Color.Black;
		Label label_FOLDER = Label_FOLDER;
		location = new Point(193, 9);
		((Control)label_FOLDER).Location = location;
		((Control)Label_FOLDER).Name = "Label_FOLDER";
		Label label_FOLDER2 = Label_FOLDER;
		size = new Size(170, 10);
		((Control)label_FOLDER2).Size = size;
		((Control)Label_FOLDER).TabIndex = 1022;
		Label_FOLDER.Text = "-";
		Label_FOLDER.TextAlign = (ContentAlignment)16;
		((Control)PictureBox1).Cursor = Cursors.Hand;
		PictureBox pictureBox7 = PictureBox1;
		location = new Point(0, 0);
		((Control)pictureBox7).Location = location;
		((Control)PictureBox1).Name = "PictureBox1";
		PictureBox pictureBox8 = PictureBox1;
		size = new Size(37, 20);
		((Control)pictureBox8).Size = size;
		PictureBox1.SizeMode = (PictureBoxSizeMode)4;
		PictureBox1.TabIndex = 0;
		PictureBox1.TabStop = false;
		((Control)Label_USERCATEGORIE).Anchor = (AnchorStyles)9;
		((Control)Label_USERCATEGORIE).Font = new Font("Cambria", 7f);
		Label label_USERCATEGORIE = Label_USERCATEGORIE;
		location = new Point(755, -1);
		((Control)label_USERCATEGORIE).Location = location;
		((Control)Label_USERCATEGORIE).Name = "Label_USERCATEGORIE";
		Label label_USERCATEGORIE2 = Label_USERCATEGORIE;
		size = new Size(131, 10);
		((Control)label_USERCATEGORIE2).Size = size;
		((Control)Label_USERCATEGORIE).TabIndex = 1021;
		Label_USERCATEGORIE.Text = "-";
		Label_USERCATEGORIE.TextAlign = (ContentAlignment)64;
		((Control)Label_USERNAME).Anchor = (AnchorStyles)9;
		((Control)Label_USERNAME).Font = new Font("Cambria", 7f);
		Label label_USERNAME = Label_USERNAME;
		location = new Point(755, 9);
		((Control)label_USERNAME).Location = location;
		((Control)Label_USERNAME).Name = "Label_USERNAME";
		Label label_USERNAME2 = Label_USERNAME;
		size = new Size(131, 10);
		((Control)label_USERNAME2).Size = size;
		((Control)Label_USERNAME).TabIndex = 1020;
		Label_USERNAME.Text = "-";
		Label_USERNAME.TextAlign = (ContentAlignment)64;
		((Control)Label_POSTE).Font = new Font("Tahoma", 8f);
		((Control)Label_POSTE).ForeColor = Color.Black;
		Label label_POSTE = Label_POSTE;
		location = new Point(153, 0);
		((Control)label_POSTE).Location = location;
		((Control)Label_POSTE).Name = "Label_POSTE";
		Label label_POSTE2 = Label_POSTE;
		size = new Size(40, 20);
		((Control)label_POSTE2).Size = size;
		((Control)Label_POSTE).TabIndex = 1009;
		Label_POSTE.Text = "-";
		Label_POSTE.TextAlign = (ContentAlignment)32;
		Label label_DATE = Label_DATE;
		location = new Point(37, 0);
		((Control)label_DATE).Location = location;
		((Control)Label_DATE).Name = "Label_DATE";
		Label label_DATE2 = Label_DATE;
		size = new Size(116, 20);
		((Control)label_DATE2).Size = size;
		((Control)Label_DATE).TabIndex = 1019;
		Label_DATE.Text = "-";
		Label_DATE.TextAlign = (ContentAlignment)16;
		((Control)Label_CONNEXION).Anchor = (AnchorStyles)13;
		((Control)Label_CONNEXION).Font = new Font("Tahoma", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		Label label_CONNEXION = Label_CONNEXION;
		location = new Point(476, 2);
		((Control)label_CONNEXION).Location = location;
		((Control)Label_CONNEXION).Name = "Label_CONNEXION";
		Label label_CONNEXION2 = Label_CONNEXION;
		size = new Size(101, 21);
		((Control)label_CONNEXION2).Size = size;
		((Control)Label_CONNEXION).TabIndex = 1017;
		Label_CONNEXION.Text = "●";
		Label_CONNEXION.TextAlign = (ContentAlignment)2;
		((Control)Label_DB).BackColor = Color.Transparent;
		((Control)Label_DB).Font = new Font("Cambria", 7f);
		((Control)Label_DB).ForeColor = Color.Black;
		Label label_DB = Label_DB;
		location = new Point(193, -1);
		((Control)label_DB).Location = location;
		((Control)Label_DB).Name = "Label_DB";
		Label label_DB2 = Label_DB;
		size = new Size(170, 10);
		((Control)label_DB2).Size = size;
		((Control)Label_DB).TabIndex = 1018;
		Label_DB.Text = "-";
		Label_DB.TextAlign = (ContentAlignment)16;
		Timer1.Enabled = true;
		Timer1.Interval = 1000;
		((Control)TableLayoutPanel1).BackColor = Color.FromArgb(22, 106, 238);
		TableLayoutPanel1.ColumnCount = 1;
		TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle((SizeType)2, 100f));
		TableLayoutPanel1.Controls.Add((Control)(object)Panel_STATUT, 0, 1);
		TableLayoutPanel1.Controls.Add((Control)(object)Panel_HOME, 0, 0);
		TableLayoutPanel tableLayoutPanel7 = TableLayoutPanel1;
		location = new Point(0, 0);
		((Control)tableLayoutPanel7).Location = location;
		((Control)TableLayoutPanel1).Name = "TableLayoutPanel1";
		TableLayoutPanel1.RowCount = 2;
		TableLayoutPanel1.RowStyles.Add(new RowStyle((SizeType)2, 100f));
		TableLayoutPanel1.RowStyles.Add(new RowStyle((SizeType)1, 20f));
		TableLayoutPanel tableLayoutPanel8 = TableLayoutPanel1;
		size = new Size(1052, 708);
		((Control)tableLayoutPanel8).Size = size;
		((Control)TableLayoutPanel1).TabIndex = 49;
		((Control)Panel1).Controls.Add((Control)(object)TextBox_MODE_WINDOWS);
		((Control)Panel1).Controls.Add((Control)(object)TextBox_COMPOSITION_AUTO);
		((Control)Panel1).Controls.Add((Control)(object)TextBox_BRANCHEMENT);
		((Control)Panel1).Controls.Add((Control)(object)ListView1);
		((Control)Panel1).Controls.Add((Control)(object)PictureBox_SORTIE);
		((Control)Panel1).Controls.Add((Control)(object)PictureBox6);
		((Control)Panel1).Controls.Add((Control)(object)Picture_EMPORTER);
		((Control)Panel1).Controls.Add((Control)(object)Picture_LIVRAISON);
		((Control)Panel1).Controls.Add((Control)(object)Picture_MOVE);
		((Control)Panel1).Controls.Add((Control)(object)Picture_CONS);
		((Control)Panel1).Controls.Add((Control)(object)Picture_PRINT);
		((Control)Panel1).Controls.Add((Control)(object)Picture_PDF);
		((Control)Panel1).Controls.Add((Control)(object)Picture_SUPP);
		((Control)Panel1).Controls.Add((Control)(object)Picture_DESACTIVER);
		((Control)Panel1).Controls.Add((Control)(object)Picture_MODIF);
		Panel panel5 = Panel1;
		location = new Point(1090, 3);
		((Control)panel5).Location = location;
		((Control)Panel1).Name = "Panel1";
		Panel panel6 = Panel1;
		size = new Size(270, 518);
		((Control)panel6).Size = size;
		((Control)Panel1).TabIndex = 50;
		((Control)Panel1).Visible = false;
		TextBox textBox_MODE_WINDOWS = TextBox_MODE_WINDOWS;
		location = new Point(16, 490);
		((Control)textBox_MODE_WINDOWS).Location = location;
		((Control)TextBox_MODE_WINDOWS).Name = "TextBox_MODE_WINDOWS";
		TextBox textBox_MODE_WINDOWS2 = TextBox_MODE_WINDOWS;
		size = new Size(134, 20);
		((Control)textBox_MODE_WINDOWS2).Size = size;
		((Control)TextBox_MODE_WINDOWS).TabIndex = 1090;
		TextBox_MODE_WINDOWS.Text = "MODE_WINDOWS";
		TextBox textBox_COMPOSITION_AUTO = TextBox_COMPOSITION_AUTO;
		location = new Point(16, 392);
		((Control)textBox_COMPOSITION_AUTO).Location = location;
		((Control)TextBox_COMPOSITION_AUTO).Name = "TextBox_COMPOSITION_AUTO";
		TextBox textBox_COMPOSITION_AUTO2 = TextBox_COMPOSITION_AUTO;
		size = new Size(134, 20);
		((Control)textBox_COMPOSITION_AUTO2).Size = size;
		((Control)TextBox_COMPOSITION_AUTO).TabIndex = 1089;
		TextBox_COMPOSITION_AUTO.Text = "COMPOSITION_AUTO";
		TextBox textBox_BRANCHEMENT = TextBox_BRANCHEMENT;
		location = new Point(16, 366);
		((Control)textBox_BRANCHEMENT).Location = location;
		((Control)TextBox_BRANCHEMENT).Name = "TextBox_BRANCHEMENT";
		TextBox textBox_BRANCHEMENT2 = TextBox_BRANCHEMENT;
		size = new Size(134, 20);
		((Control)textBox_BRANCHEMENT2).Size = size;
		((Control)TextBox_BRANCHEMENT).TabIndex = 1088;
		TextBox_BRANCHEMENT.Text = "BRANCHEMENT";
		ListView1.Activation = (ItemActivation)1;
		ListView1.Columns.AddRange(new ColumnHeader[2] { OBJET, VALEUR });
		ListView1.FullRowSelect = true;
		ListView listView = ListView1;
		location = new Point(16, 251);
		((Control)listView).Location = location;
		ListView1.MultiSelect = false;
		((Control)ListView1).Name = "ListView1";
		ListView listView2 = ListView1;
		size = new Size(250, 109);
		((Control)listView2).Size = size;
		((Control)ListView1).TabIndex = 1087;
		ListView1.UseCompatibleStateImageBehavior = false;
		ListView1.View = (View)1;
		((Control)ListView1).Visible = false;
		OBJET.Text = "OBJET";
		OBJET.Width = 163;
		VALEUR.Text = "VALEUR";
		VALEUR.Width = 55;
		((Control)PictureBox_SORTIE).Cursor = Cursors.Hand;
		PictureBox_SORTIE.Image = (Image)componentResourceManager.GetObject("PictureBox_SORTIE.Image");
		PictureBox pictureBox_SORTIE = PictureBox_SORTIE;
		location = new Point(51, 71);
		((Control)pictureBox_SORTIE).Location = location;
		((Control)PictureBox_SORTIE).Name = "PictureBox_SORTIE";
		PictureBox pictureBox_SORTIE2 = PictureBox_SORTIE;
		size = new Size(24, 24);
		((Control)pictureBox_SORTIE2).Size = size;
		PictureBox_SORTIE.TabIndex = 1042;
		PictureBox_SORTIE.TabStop = false;
		((Control)PictureBox_SORTIE).Visible = false;
		((Control)PictureBox6).Cursor = Cursors.Hand;
		PictureBox6.Image = (Image)componentResourceManager.GetObject("PictureBox6.Image");
		PictureBox pictureBox9 = PictureBox6;
		location = new Point(16, 182);
		((Control)pictureBox9).Location = location;
		((Control)PictureBox6).Name = "PictureBox6";
		PictureBox pictureBox10 = PictureBox6;
		size = new Size(37, 20);
		((Control)pictureBox10).Size = size;
		PictureBox6.SizeMode = (PictureBoxSizeMode)4;
		PictureBox6.TabIndex = 1026;
		PictureBox6.TabStop = false;
		((Control)Picture_EMPORTER).Cursor = Cursors.Hand;
		Picture_EMPORTER.Image = (Image)componentResourceManager.GetObject("Picture_EMPORTER.Image");
		PictureBox picture_EMPORTER = Picture_EMPORTER;
		location = new Point(182, 81);
		((Control)picture_EMPORTER).Location = location;
		((Control)Picture_EMPORTER).Name = "Picture_EMPORTER";
		PictureBox picture_EMPORTER2 = Picture_EMPORTER;
		size = new Size(70, 59);
		((Control)picture_EMPORTER2).Size = size;
		Picture_EMPORTER.SizeMode = (PictureBoxSizeMode)2;
		Picture_EMPORTER.TabIndex = 1035;
		Picture_EMPORTER.TabStop = false;
		((Control)Picture_EMPORTER).Visible = false;
		((Control)Picture_LIVRAISON).Cursor = Cursors.Hand;
		Picture_LIVRAISON.Image = (Image)componentResourceManager.GetObject("Picture_LIVRAISON.Image");
		PictureBox picture_LIVRAISON = Picture_LIVRAISON;
		location = new Point(182, 16);
		((Control)picture_LIVRAISON).Location = location;
		((Control)Picture_LIVRAISON).Name = "Picture_LIVRAISON";
		PictureBox picture_LIVRAISON2 = Picture_LIVRAISON;
		size = new Size(70, 59);
		((Control)picture_LIVRAISON2).Size = size;
		Picture_LIVRAISON.SizeMode = (PictureBoxSizeMode)2;
		Picture_LIVRAISON.TabIndex = 1034;
		Picture_LIVRAISON.TabStop = false;
		((Control)Picture_LIVRAISON).Visible = false;
		((Control)Picture_MOVE).Cursor = Cursors.Hand;
		Picture_MOVE.Image = (Image)componentResourceManager.GetObject("Picture_MOVE.Image");
		PictureBox picture_MOVE = Picture_MOVE;
		location = new Point(51, 110);
		((Control)picture_MOVE).Location = location;
		((Control)Picture_MOVE).Name = "Picture_MOVE";
		PictureBox picture_MOVE2 = Picture_MOVE;
		size = new Size(15, 15);
		((Control)picture_MOVE2).Size = size;
		Picture_MOVE.SizeMode = (PictureBoxSizeMode)2;
		Picture_MOVE.TabIndex = 1032;
		Picture_MOVE.TabStop = false;
		((Control)Picture_MOVE).Visible = false;
		((Control)Picture_CONS).Cursor = Cursors.Hand;
		Picture_CONS.Image = (Image)componentResourceManager.GetObject("Picture_CONS.Image");
		PictureBox picture_CONS = Picture_CONS;
		location = new Point(42, 148);
		((Control)picture_CONS).Location = location;
		((Control)Picture_CONS).Name = "Picture_CONS";
		PictureBox picture_CONS2 = Picture_CONS;
		size = new Size(24, 24);
		((Control)picture_CONS2).Size = size;
		Picture_CONS.TabIndex = 36;
		Picture_CONS.TabStop = false;
		((Control)Picture_CONS).Visible = false;
		((Control)Picture_PRINT).Cursor = Cursors.Hand;
		Picture_PRINT.Image = (Image)componentResourceManager.GetObject("Picture_PRINT.Image");
		PictureBox picture_PRINT = Picture_PRINT;
		location = new Point(16, 148);
		((Control)picture_PRINT).Location = location;
		((Control)Picture_PRINT).Name = "Picture_PRINT";
		PictureBox picture_PRINT2 = Picture_PRINT;
		size = new Size(24, 24);
		((Control)picture_PRINT2).Size = size;
		Picture_PRINT.TabIndex = 34;
		Picture_PRINT.TabStop = false;
		((Control)Picture_PRINT).Visible = false;
		((Control)Picture_PDF).Cursor = Cursors.Hand;
		Picture_PDF.Image = (Image)componentResourceManager.GetObject("Picture_PDF.Image");
		PictureBox picture_PDF = Picture_PDF;
		location = new Point(16, 110);
		((Control)picture_PDF).Location = location;
		((Control)Picture_PDF).Name = "Picture_PDF";
		PictureBox picture_PDF2 = Picture_PDF;
		size = new Size(24, 24);
		((Control)picture_PDF2).Size = size;
		Picture_PDF.TabIndex = 33;
		Picture_PDF.TabStop = false;
		((Control)Picture_PDF).Visible = false;
		((Control)Picture_SUPP).Cursor = Cursors.Hand;
		Picture_SUPP.Image = (Image)componentResourceManager.GetObject("Picture_SUPP.Image");
		PictureBox picture_SUPP = Picture_SUPP;
		location = new Point(16, 3);
		((Control)picture_SUPP).Location = location;
		((Control)Picture_SUPP).Name = "Picture_SUPP";
		PictureBox picture_SUPP2 = Picture_SUPP;
		size = new Size(24, 24);
		((Control)picture_SUPP2).Size = size;
		Picture_SUPP.TabIndex = 30;
		Picture_SUPP.TabStop = false;
		((Control)Picture_SUPP).Visible = false;
		((Control)Picture_DESACTIVER).Cursor = Cursors.Hand;
		Picture_DESACTIVER.Image = (Image)componentResourceManager.GetObject("Picture_DESACTIVER.Image");
		PictureBox picture_DESACTIVER = Picture_DESACTIVER;
		location = new Point(16, 79);
		((Control)picture_DESACTIVER).Location = location;
		((Control)Picture_DESACTIVER).Name = "Picture_DESACTIVER";
		PictureBox picture_DESACTIVER2 = Picture_DESACTIVER;
		size = new Size(24, 24);
		((Control)picture_DESACTIVER2).Size = size;
		Picture_DESACTIVER.TabIndex = 32;
		Picture_DESACTIVER.TabStop = false;
		((Control)Picture_DESACTIVER).Visible = false;
		((Control)Picture_MODIF).Cursor = Cursors.Hand;
		Picture_MODIF.Image = (Image)componentResourceManager.GetObject("Picture_MODIF.Image");
		PictureBox picture_MODIF = Picture_MODIF;
		location = new Point(16, 41);
		((Control)picture_MODIF).Location = location;
		((Control)Picture_MODIF).Name = "Picture_MODIF";
		PictureBox picture_MODIF2 = Picture_MODIF;
		size = new Size(24, 24);
		((Control)picture_MODIF2).Size = size;
		Picture_MODIF.TabIndex = 31;
		Picture_MODIF.TabStop = false;
		((Control)Picture_MODIF).Visible = false;
		((Control)Button1323234).Font = new Font("Calibri", 14f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		Button button3 = Button1323234;
		location = new Point(323, 470);
		((Control)button3).Location = location;
		((Control)Button1323234).Name = "Button1323234";
		Button button4 = Button1323234;
		size = new Size(236, 38);
		((Control)button4).Size = size;
		((Control)Button1323234).TabIndex = 860;
		((ButtonBase)Button1323234).Text = "Redémarrer le Système";
		((ButtonBase)Button1323234).UseVisualStyleBackColor = true;
		((Control)Label_ERREUR).BackColor = Color.Yellow;
		((Control)Label_ERREUR).Font = new Font("Calibri", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label_ERREUR).ForeColor = SystemColors.ActiveCaptionText;
		Label label_ERREUR = Label_ERREUR;
		location = new Point(3, 395);
		((Control)label_ERREUR).Location = location;
		((Control)Label_ERREUR).Name = "Label_ERREUR";
		Label label_ERREUR2 = Label_ERREUR;
		size = new Size(876, 72);
		((Control)label_ERREUR2).Size = size;
		((Control)Label_ERREUR).TabIndex = 859;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).BackColor = SystemColors.Control;
		size = new Size(1372, 752);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)Panel1);
		((Control)this).Controls.Add((Control)(object)TableLayoutPanel1);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Control)this).Name = "Form_0_TEMPLATE";
		((Form)this).Text = "LOGICA";
		((Form)this).WindowState = (FormWindowState)2;
		((Control)Panel_HOME).ResumeLayout(false);
		((Control)Panel_HOME).PerformLayout();
		((Control)Panel_clé).ResumeLayout(false);
		((ISupportInitialize)PictureBox100).EndInit();
		((Control)Panel_TENTATIVE_CONNEXION).ResumeLayout(false);
		((Control)Panel_TENTATIVE_CONNEXION).PerformLayout();
		((ISupportInitialize)PictureBox5).EndInit();
		((ISupportInitialize)PictureBox4).EndInit();
		((Control)Panel_FICHE).ResumeLayout(false);
		((Control)Panel_FICHE).PerformLayout();
		((Control)Panel_CLAVIER).ResumeLayout(false);
		((Control)TableLayoutPanel2).ResumeLayout(false);
		((Control)TableLayoutPanel3).ResumeLayout(false);
		((Control)Panel5).ResumeLayout(false);
		((Control)Panel5).PerformLayout();
		((Control)Panel2).ResumeLayout(false);
		((Control)Panel2).PerformLayout();
		((Control)Panel_STATUT).ResumeLayout(false);
		((ISupportInitialize)Picture_ALERT).EndInit();
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)TableLayoutPanel1).ResumeLayout(false);
		((Control)Panel1).ResumeLayout(false);
		((Control)Panel1).PerformLayout();
		((ISupportInitialize)PictureBox_SORTIE).EndInit();
		((ISupportInitialize)PictureBox6).EndInit();
		((ISupportInitialize)Picture_EMPORTER).EndInit();
		((ISupportInitialize)Picture_LIVRAISON).EndInit();
		((ISupportInitialize)Picture_MOVE).EndInit();
		((ISupportInitialize)Picture_CONS).EndInit();
		((ISupportInitialize)Picture_PRINT).EndInit();
		((ISupportInitialize)Picture_PDF).EndInit();
		((ISupportInitialize)Picture_SUPP).EndInit();
		((ISupportInitialize)Picture_DESACTIVER).EndInit();
		((ISupportInitialize)Picture_MODIF).EndInit();
		((Control)this).ResumeLayout(false);
	}

	[DllImport("kernel32.dll")]
	internal static extern bool SetLocaleInfo(uint Locale, uint LCType, string lpLCData);

	internal string GetVolumeSerial(string strDriveLetter = "c")
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected Obj, but got Unknown
		ManagementObject val = new ManagementObject($"win32_logicaldisk.deviceid=\"{strDriveLetter}:\"");
		val.Get();
		return ((ManagementBaseObject)val)["VolumeSerialNumber"].ToString();
	}

	public static object GetMotherbaordID()
	{
		string text = ".";
		object objectValue = RuntimeHelpers.GetObjectValue(Interaction.GetObject("winmgmts:{impersonationLevel=impersonate}!\\\\" + text + "\\root\\cimv2"));
		object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "ExecQuery", new object[1] { "Select * from        Win32_SystemEnclosure " }, null, null, null));
		IEnumerator enumerator = ((IEnumerable)objectValue2).GetEnumerator();
		try
		{
			if (enumerator.MoveNext())
			{
				object objectValue3 = RuntimeHelpers.GetObjectValue(enumerator.Current);
				return NewLateBinding.LateGet(objectValue3, null, "SerialNumber", new object[0], null, null, null);
			}
		}
		finally
		{
			IDisposable disposable = enumerator as IDisposable;
			if (disposable != null)
			{
				disposable.Dispose();
			}
		}
		return "";
	}

	public void _DEMO()
	{
	}

	public void _Tentative_Connect_Database()
	{
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected Obj, but got Unknown
		//IL_00c2: Expected Obj, but got Unknown
		int num = 0;
		int num2 = 3;
		bool flag = false;
		int millisecondsTimeout = 1000;
		if (!((ServerComputer)MyProject.Computer).FileSystem.DirectoryExists(Module1._CHEMIN_FOLDER + "\\bd"))
		{
			PictureBox100.Image = MyProject.Forms.Form_1_LOGIN.PictureBox100.Image;
			((Control)Panel_clé).Visible = true;
			((Control)Panel_TENTATIVE_CONNEXION).Visible = true;
			((Control)Panel_TENTATIVE_CONNEXION).BringToFront();
			Label label_ERREUR = Label_ERREUR;
			label_ERREUR.Text += "\r\nVeuillez vérifier le dossier bd.";
			return;
		}
		while ((num < num2) & !flag)
		{
			try
			{
				Module1.cn_SQL.Open();
				flag = true;
			}
			catch (MySqlException ex)
			{
				ProjectData.SetProjectError((Exception)ex);
				MySqlException ex2 = ex;
				num = checked(num + 1);
				switch (ex2.Number)
				{
				case -1:
				{
					PictureBox100.Image = MyProject.Forms.Form_1_LOGIN.PictureBox100.Image;
					((Control)Panel_clé).Visible = true;
					((Control)Panel_TENTATIVE_CONNEXION).Visible = true;
					((Control)Panel_TENTATIVE_CONNEXION).BringToFront();
					Label label_ERREUR = Label_ERREUR;
					label_ERREUR.Text = label_ERREUR.Text + "\r\nProblème de réseau ou timeout lors de la connexion à la base de données. Tentative " + Conversions.ToString(num) + "/maxRetries ";
					Thread.Sleep(millisecondsTimeout);
					ProjectData.ClearProjectError();
					break;
				}
				case 18456:
				{
					PictureBox100.Image = MyProject.Forms.Form_1_LOGIN.PictureBox100.Image;
					((Control)Panel_clé).Visible = true;
					((Control)Panel_TENTATIVE_CONNEXION).Visible = true;
					((Control)Panel_TENTATIVE_CONNEXION).BringToFront();
					Label label_ERREUR = Label_ERREUR;
					label_ERREUR.Text += "\r\nÉchec d'authentification. Vérifiez vos identifiants de connexion.";
					ProjectData.ClearProjectError();
					return;
				}
				default:
				{
					PictureBox100.Image = MyProject.Forms.Form_1_LOGIN.PictureBox100.Image;
					((Control)Panel_clé).Visible = true;
					((Control)Panel_TENTATIVE_CONNEXION).Visible = true;
					((Control)Panel_TENTATIVE_CONNEXION).BringToFront();
					Label label_ERREUR = Label_ERREUR;
					label_ERREUR.Text = label_ERREUR.Text + "\r\nErreur SQL : " + ((Exception)(object)ex2).Message + " Code : " + Conversions.ToString(ex2.Number);
					ProjectData.ClearProjectError();
					return;
				}
				}
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				PictureBox100.Image = MyProject.Forms.Form_1_LOGIN.PictureBox100.Image;
				((Control)Panel_clé).Visible = true;
				((Control)Panel_TENTATIVE_CONNEXION).Visible = true;
				((Control)Panel_TENTATIVE_CONNEXION).BringToFront();
				Label label_ERREUR = Label_ERREUR;
				label_ERREUR.Text = label_ERREUR.Text + "Une erreur inattendue s'est produite : " + ex4.Message;
				ProjectData.ClearProjectError();
				return;
			}
			finally
			{
				if (Module1.cn_SQL.State == ConnectionState.Open)
				{
					Module1.cn_SQL.Close();
				}
			}
		}
		if (!flag)
		{
			PictureBox100.Image = MyProject.Forms.Form_1_LOGIN.PictureBox100.Image;
			((Control)Panel_clé).Visible = true;
			((Control)Panel_TENTATIVE_CONNEXION).Visible = true;
			((Control)Panel_TENTATIVE_CONNEXION).BringToFront();
			Label label_ERREUR = Label_ERREUR;
			label_ERREUR.Text += "Impossible de se connecter à la base de données après plusieurs tentatives.";
		}
	}

	public bool IsNetworkAvailable()
	{
		return NetworkInterface.GetIsNetworkAvailable();
	}

	public bool PingServer(string serverAddress)
	{
		bool result;
		try
		{
			using Ping ping = new Ping();
			PingReply pingReply = ping.Send(serverAddress, 2000);
			result = pingReply.Status == IPStatus.Success;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			result = false;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	private void Form_0_TEMPLATE_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (e.KeyChar == '\'')
		{
			e.Handled = true;
		}
	}

	private void Form_0_TEMPLATE_HandleCreated(object sender, EventArgs e)
	{
		((Control)TableLayoutPanel1).Dock = (DockStyle)5;
		((Form)this).KeyPreview = true;
		Label_DB.Text = File.ReadAllText(Application.StartupPath + "/CHEMIN_DB.sni");
		Label_FOLDER.Text = File.ReadAllText(Application.StartupPath + "/CHEMIN_FOLDER.sni");
		Label_POSTE.Text = File.ReadAllText(Application.StartupPath + "/poste.sni");
		if (Operators.CompareString(Label_DB.Text, "Application.StartupPath", TextCompare: false) == 0)
		{
			Label_DB.Text = Application.StartupPath;
		}
		if (Operators.CompareString(Label_FOLDER.Text, "Application.StartupPath", TextCompare: false) == 0)
		{
			Label_FOLDER.Text = Application.StartupPath;
		}
	}

	private void Form_0_TEMPLATE_Load(object sender, EventArgs e)
	{
		//IL_092b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0932: Expected Obj, but got Unknown
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected Obj, but got Unknown
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Expected Obj, but got Unknown
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Expected Obj, but got Unknown
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Expected Obj, but got Unknown
		checked
		{
			try
			{
				_Tentative_Connect_Database();
				if (((Control)Panel_TENTATIVE_CONNEXION).Visible)
				{
					return;
				}
				MySqlCommand val = new MySqlCommand();
				if (Module1.cn_SQL.State != ConnectionState.Open)
				{
					Module1.cn_SQL.Open();
				}
				val.CommandText = "select    *     from     TABLE_PARAMETRES       ";
				val.Connection = Module1.cn_SQL;
				val.ExecuteNonQuery();
				ListView1.Items.Clear();
				MySqlDataReader val2 = val.ExecuteReader();
				if (val2.HasRows)
				{
					while (val2.Read())
					{
						ListView1.Items.Add(val2["OBJET"].ToString());
						ListView1.Items[ListView1.Items.Count - 1].SubItems.Add(val2["VALEUR"].ToString());
					}
				}
				val2.Close();
				Module1.cn_SQL.Close();
				TextBox_BRANCHEMENT.Text = ListView1.Items[ListView1.FindItemWithText("BRANCHEMENT", false, 0).Index].SubItems[1].Text;
				Label_LANGUE.Text = ListView1.Items[ListView1.FindItemWithText("LANGUE", false, 0).Index].SubItems[1].Text;
				if (Operators.CompareString(Label_LANGUE.Text, "ar", TextCompare: false) == 0)
				{
					logo_ar_login = (Bitmap)MyProject.Forms.Form_1_LOGIN.PictureBox100.Image;
					logo_ar_vente = (Bitmap)MyProject.Forms.Form_3_VENTE.PictureBox100.Image;
					logo_ar_vente_logo = (Bitmap)MyProject.Forms.Form_3_VENTE.Picture_LOGO.Image;
				}
				if (Operators.CompareString(File.ReadAllText(Application.StartupPath + "\\log_erreur.sni"), "", TextCompare: false) != 0)
				{
					((Control)Picture_ALERT).Visible = true;
				}
				TextBox_MODE_WINDOWS.Text = File.ReadAllText(Application.StartupPath + "/mode_windows.sni");
				Label_GESTION_TABLE.Text = "DIRECTE";
				try
				{
					string text = ListView1.Items[ListView1.FindItemWithText("THEME", false, 0).Index].SubItems[1].Text;
					string[] source = text.Split(new char[1] { ';' });
					if (source.Count() == 3)
					{
						ColorConverter colorConverter = new ColorConverter();
						Color backColor = (Color)colorConverter.ConvertFromString(ListView1.Items[ListView1.FindItemWithText("THEME", false, 0).Index].SubItems[1].Text);
						((Control)TableLayoutPanel1).BackColor = backColor;
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception e2 = ex;
					StackTrace stackTrace = new StackTrace(e2, fNeedFileInfo: true);
					StackFrame frame = stackTrace.GetFrame(stackTrace.FrameCount - 1);
					int fileLineNumber = frame.GetFileLineNumber();
					ProjectData.ClearProjectError();
				}
				try
				{
					Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\International", "sDecimal", ".");
					Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\International", "sDate", "/");
					Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\International", "sThousand", "\u00a0");
					Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\International", "sList", ";");
					Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\International", "sShortDate", "dd/MM/yyyy");
					Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\International", "sShortTime", "HH:mm");
				}
				catch (Exception ex2)
				{
					ProjectData.SetProjectError(ex2);
					Exception e3 = ex2;
					StackTrace stackTrace2 = new StackTrace(e3, fNeedFileInfo: true);
					StackFrame frame2 = stackTrace2.GetFrame(stackTrace2.FrameCount - 1);
					int fileLineNumber2 = frame2.GetFileLineNumber();
					ProjectData.ClearProjectError();
				}
				if (Operators.CompareString(Thread.CurrentThread.CurrentUICulture.NumberFormat.NumberDecimalSeparator, ".", TextCompare: false) != 0)
				{
					Application.DoEvents();
					Thread.Sleep(500);
					SetLocaleInfo(1024u, 14u, ".");
					SetLocaleInfo(1024u, 22u, ".");
				}
#if DEBUG
				// Development builds enter the existing user-login flow without machine activation.
				// No activation key or registry entry is generated or changed.
				bool canOpenUserLogin = true;
				((Form)this).Text = "LOGICA - Development";
#else
				Text_ara_disk.Text = GetVolumeSerial().ToString() + GetMotherbaordID().ToString().PadRight(10, '0').Replace(" ", "0")
					.Substring(0, 10);
				RichText_insc.Text = Module1.XOR_Encrypt(Text_ara_disk.Text, "siper");
				RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("svchost");
				Text_ara_reg.Text = Conversions.ToString(registryKey.GetValue("screenColorsF"));
				if (Operators.CompareString(Text_ara_reg.Text, "", TextCompare: false) == 0)
				{
					Text_ara_reg.Text = "vide";
				}
				bool canOpenUserLogin = Operators.CompareString(Text_ara_reg.Text, Text_ara_disk.Text, TextCompare: false) == 0;
#endif
				if (canOpenUserLogin)
				{
					((Control)Panel_clé).Visible = false;
					((Control)Panel_clé).SendToBack();
					((Form)MyProject.Forms.Form_1_LOGIN).Close();
					((Form)MyProject.Forms.Form_1_LOGIN).TopLevel = false;
					((Control)Panel_HOME).Controls.Clear();
					((Control)Panel_HOME).Controls.Add((Control)(object)MyProject.Forms.Form_1_LOGIN);
					((Control)MyProject.Forms.Form_1_LOGIN).Show();
					((Control)MyProject.Forms.Form_1_LOGIN.Panel_login).Visible = true;
					((Control)MyProject.Forms.Form_1_LOGIN.Panel_login).BringToFront();
				}
				else
				{
					((Control)Panel_clé).Visible = true;
					((Control)Panel_clé).BringToFront();
					((Control)Panel_FICHE).Visible = true;
					((Control)Panel_FICHE).BringToFront();
					PictureBox100.Image = MyProject.Forms.Form_1_LOGIN.PictureBox100.Image;
				}
				((TextBoxBase)RichText_insc).SelectionStart = 0;
				RichText_insc.SelectionLength = 4;
				RichText_insc.SelectionColor = Color.Tomato;
				((TextBoxBase)RichText_insc).SelectionStart = 4;
				RichText_insc.SelectionLength = 4;
				RichText_insc.SelectionColor = Color.Blue;
				((TextBoxBase)RichText_insc).SelectionStart = 8;
				RichText_insc.SelectionLength = 4;
				RichText_insc.SelectionColor = Color.Green;
				((TextBoxBase)RichText_insc).SelectionStart = 12;
				RichText_insc.SelectionLength = 4;
				RichText_insc.SelectionColor = Color.Black;
				((TextBoxBase)RichText_insc).SelectionStart = 16;
				RichText_insc.SelectionLength = 4;
				RichText_insc.SelectionColor = Color.Tomato;
				((TextBoxBase)RichText_insc).SelectionStart = 20;
				RichText_insc.SelectionLength = 4;
				RichText_insc.SelectionColor = Color.Blue;
				((TextBoxBase)RichText_insc).SelectionStart = 20;
				RichText_insc.SelectionLength = 4;
				RichText_insc.SelectionColor = Color.Green;
				((TextBoxBase)RichText_insc).SelectionStart = 24;
				RichText_insc.SelectionLength = 4;
				RichText_insc.SelectionColor = Color.Black;
				((TextBoxBase)RichText_insc).SelectionStart = 28;
				RichText_insc.SelectionLength = 4;
				RichText_insc.SelectionColor = Color.Tomato;
				((TextBoxBase)RichText_insc).SelectionStart = 32;
				RichText_insc.SelectionLength = 4;
				RichText_insc.SelectionColor = Color.Blue;
				((TextBoxBase)RichText_insc).SelectionStart = 36;
				RichText_insc.SelectionLength = 4;
				RichText_insc.SelectionColor = Color.Green;
				((TextBoxBase)RichText_insc).SelectAll();
				RichText_insc.SelectionAlignment = (HorizontalAlignment)2;
				if (Conversions.ToBoolean(TextBox_MODE_WINDOWS.Text))
				{
					((Form)this).FormBorderStyle = (FormBorderStyle)1;
				}
				_DEMO();
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				StackTrace stackTrace3 = new StackTrace(ex4, fNeedFileInfo: true);
				StackFrame frame3 = stackTrace3.GetFrame(stackTrace3.FrameCount - 1);
				int fileLineNumber3 = frame3.GetFileLineNumber();
				Interaction.MsgBox(ex4.Message + "\r\nLigne : " + Conversions.ToString(fileLineNumber3) + "\r\n");
				try
				{
					string text2 = Strings.Format(DateTime.Now, "yyMMddHHmmssfff");
					Bitmap val3 = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, (PixelFormat)2498570);
					Graphics val4 = Graphics.FromImage((Image)(object)val3);
					val4.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, (CopyPixelOperation)13369376);
					((Image)val3).Save(Application.StartupPath + "\\tchak\\" + text2 + ".snidb", ImageFormat.Jpeg);
					val3 = null;
					string right = "ERROR | ";
					File.AppendAllText(Application.StartupPath + "\\log_erreur.sni", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(Strings.Format(DateTime.Now, "ddMMyyHHmmssfff") + Label_POSTE.Text, " | "), Module1._USERNAME), " | "), ((Control)this).Name), " | "), NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null)), " | "), right), " | "), ex4.ToString()), "\r\n"), "Ligne : "), fileLineNumber3), "\r\n"), "\r\n"), "##########################################################################################################"), "\r\n")), Encoding.UTF8);
				}
				catch (Exception ex5)
				{
					ProjectData.SetProjectError(ex5);
					Exception ex6 = ex5;
					ProjectData.ClearProjectError();
				}
				ProjectData.ClearProjectError();
			}
		}
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		Label_DATE.Text = DateTime.Now.ToString("dd/MM/yyy HH:mm:ss");
		Label_USERNAME.Text = Module1._USERNAME;
		Label_USERCATEGORIE.Text = Module1._USERCATEGORIE;
	}

	private void Panel_HOME_Paint(object sender, PaintEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	private void Panel_HOME_DoubleClick(object sender, EventArgs e)
	{
		ProjectData.EndApp();
	}

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	private void PictureBox1_Click(object sender, EventArgs e)
	{
		ProjectData.EndApp();
	}

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	private void Button_end_Click(object sender, EventArgs e)
	{
		ProjectData.EndApp();
	}

	private void Button_copier_Click(object sender, EventArgs e)
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
				case 97:
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
							goto IL_001c;
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
					Clipboard.SetText(RichText_insc.Text);
					goto IL_001c;
					IL_001c:
					num2 = 3;
					((Control)RichText_insc).Focus();
					break;
					end_IL_0001_2:
					break;
				}
				num2 = 4;
				((TextBoxBase)RichText_insc).SelectAll();
				break;
				end_IL_0001:;
			}
			catch (Exception ex) when ((num3 != 0) & (num == 0))
			{
				ProjectData.SetProjectError(ex);
				try0001_dispatch = 97;
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

	private void Button_coller_Click(object sender, EventArgs e)
	{
		MaskedText_acti.Text = Clipboard.GetText();
	}

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	private void Button_ok_Click(object sender, EventArgs e)
	{
		//IL_072d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0734: Expected Obj, but got Unknown
		try
		{
			if (Operators.CompareString(MaskedText_acti.Text, "", TextCompare: false) != 0 && Operators.CompareString(MaskedText_acti.Text, "    -    -    -    -    -    -    -    ", TextCompare: false) != 0)
			{
				string[] array = Strings.Split(MaskedText_acti.Text, "-");
				string input = array[0] + array[1] + array[2] + array[3] + array[4] + array[5] + array[6] + array[7] + array[8];
				Text_ara_reg.Text = Module1.XOR_Decrypt(input, "retour");
				string text = Text_ara_reg.Text;
				if (Operators.CompareString(text, Text_ara_disk.Text, TextCompare: false) == 0)
				{
					RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("svchost");
					registryKey.SetValue("ColorDisplayAdvertising", "CD4318BH64154950756M");
					registryKey.SetValue("MSIPP-MK", "GG27287J73121626023A");
					registryKey.SetValue("screenColorsSize", "566646TE511024976090");
					registryKey.SetValue("ScreenZeros", "5U4045ARI15583870163");
					registryKey.SetValue("BufferBufferSize", "Z24917AG45437KO00655");
					registryKey.SetValue("BufferXxXXSize", "254958FR237634454988");
					registryKey.SetValue("BufferScreen", "KLD445EC006056C00433");
					registryKey.SetValue("ScreenBufferSizex", "DDD474CE001056C00900");
					registryKey.SetValue("Buffer", "AMD424BY102056C0055V");
					registryKey.SetValue("ScreenBufferSizes", "ZQD341NA002056C00410");
					registryKey.SetValue("screenColorX", "VRD681WE072056C00892");
					registryKey.SetValue("screenColorsX", "VRD271WP0K9056CI057K");
					registryKey.SetValue("screenColorDD", "RSD691ME006056C00775");
					registryKey.SetValue("ScreenTrim", "ISD7071EEI02056C0055");
					registryKey.SetValue("ScreenBufferSize", "ZZD471BN006056C00320");
					registryKey.SetValue("Colorscreen", "IO923737237823278744");
					registryKey.SetValue("screenColorsFull", "KJ78263E782637864233");
					registryKey.SetValue("screenColor", "CP989JJE867677773005");
					registryKey.SetValue("screenColorsF", Text_ara_reg.Text);
					registryKey.SetValue("ExtendedEditKeyCustom", "H9M339943M34M3M434M4");
					registryKey.SetValue("AdvIntDriverEnabled2", "K0982585088883299999");
					registryKey.SetValue("TrimLeadingZeros", "WOP29292929265553444");
					registryKey.SetValue("ScreenBufferSize", "M099XR32323246511111");
					registryKey.SetValue("ScreenBufferSizeZeros", "64FGG666");
					registryKey.SetValue("TrimLeadingZeros", "DD554545");
					registryKey.SetValue("AdvIntDriverEnabled2", "FH7767TH");
					registryKey.SetValue("ExtendedEditKeyCustom", "FF334F4C");
					registryKey.SetValue("{04598FC3-866C-11CF-AB7C-00AA0EC08FCF}", "80442449", RegistryValueKind.DWord);
					registryKey.SetValue("{04598FC4-866C-11CF-AB7C-00AA0EC08FCF}", "38650302", RegistryValueKind.DWord);
					registryKey.SetValue("{0776ae27-5ab9-4e18-9063-1836dE63117a}", "38650306", RegistryValueKind.DWord);
					registryKey.SetValue("{1EFB6597-857C-11D1-B16A-00C0FE283628}", "38650310", RegistryValueKind.DWord);
					registryKey.SetValue("{04598FC3-866C-11CF-AB7C-00AA0EC08FC3}", "38650314", RegistryValueKind.DWord);
					registryKey.SetValue("{04598FC4-866C-11CF-AB7C-00AA0EC08FC7}", "8650318", RegistryValueKind.DWord);
					registryKey.SetValue("{0776ae27-5ab9-4e18-9063-1836dE631175}", "8650322", RegistryValueKind.DWord);
					registryKey.SetValue("{1EFB6597-857C-11D1-B16A-00C0FE28362S}", "8650326", RegistryValueKind.DWord);
					registryKey.SetValue("{04598FC3-866C-11CF-AB7C-00AA0EC08FC5}", "8650330", RegistryValueKind.DWord);
					registryKey.SetValue("{04598FC4-866C-11CF-AB7C-00AA0EC08FC3}", "8650334", RegistryValueKind.DWord);
					registryKey.SetValue("{0776ae27-5ab9-4e18-9063-1836dE63117E}", "38650338", RegistryValueKind.DWord);
					registryKey.SetValue("{1EFB6597-857C-11D1-B16A-00C0FE28362R}", "38650342", RegistryValueKind.DWord);
					registryKey.SetValue("{04598FC3-866C-11CF-AB7C-00AA0EC08FCF}", "38650346", RegistryValueKind.DWord);
					registryKey.SetValue("{04598FC4-866C-11CF-AB7C-00AA0EC08FCF}", "38650350", RegistryValueKind.DWord);
					registryKey.SetValue("{0776ae27-5ab9-4e18-9063-1836dE63117a}", "38650354", RegistryValueKind.DWord);
					registryKey.SetValue("{1EFB6597-857C-11D1-B16A-00C0FE283628}", "38650358", RegistryValueKind.DWord);
					registryKey.SetValue("{04598FC3-866C-11CF-AB7C-359AD346581438650362}", "46565362", RegistryValueKind.DWord);
					registryKey.SetValue("{04598FC4-866C-11CF-AB7C-759AD386581438650366}", "86565366", RegistryValueKind.DWord);
					registryKey.SetValue("{0776ae27-5ab9-4e18-9063-5763D426581438650370}", "26565370", RegistryValueKind.DWord);
					registryKey.SetValue("{1EFB6597-857C-11D1-B16A-SFBCD466581438650374}", "66565374", RegistryValueKind.DWord);
					registryKey.SetValue("{04598FC3-866C-11CF-AB7C-559AD506581438650378}", "06565378", RegistryValueKind.DWord);
					registryKey.SetValue("{04598FC4-866C-11CF-AB7C-359AD546581438650382}", "46565382", RegistryValueKind.DWord);
					registryKey.SetValue("{0776ae27-5ab9-4e18-9063-E763D586581438650386}", "86565386", RegistryValueKind.DWord);
					registryKey.SetValue("{1EFB6597-857C-11D1-B16A-RFBCD626581438650390}", "26565390", RegistryValueKind.DWord);
					registryKey.SetValue("{04598FC3-866C-11CF-AB7C-F59AD666581438650394}", "66565394", RegistryValueKind.DWord);
					registryKey.SetValue("{04598FC4-866C-11CF-AB7C-F59AD706581438650398}", "06565398", RegistryValueKind.DWord);
					registryKey.SetValue("{0776ae27-5ab9-4e18-9063-a763D746581438650402}", "46565402", RegistryValueKind.DWord);
					registryKey.SetValue("{1EFB6597-857C-11D1-B16A-8FBCD786581438650406}", "86565406", RegistryValueKind.DWord);
					registryKey.SetValue("{04598FC3-866C-11CF-AB7C-359AD826581438650410}", "26565410", RegistryValueKind.DWord);
					registryKey.SetValue("{04598FC4-866C-11CF-AB7C-759AD866581438650414}", "66565414", RegistryValueKind.DWord);
					registryKey.SetValue("{0776ae27-5ab9-4e18-9063-5763D294581438650418}", "94565418", RegistryValueKind.DWord);
					registryKey.SetValue("{1EFB6597-857C-11D1-B16A-SFBCD254581438650422}", "54565422", RegistryValueKind.DWord);
					registryKey.SetValue("{04598FC3-866C-11CF-AB7C-559AD214581438650426}", "14565426", RegistryValueKind.DWord);
					registryKey.SetValue("{04598FC4-866C-11CF-AB7C-359AD174581438650430}", "74565430", RegistryValueKind.DWord);
					registryKey.SetValue("{0776ae27-5ab9-4e18-9063-E763D134581438650434}", "34565434", RegistryValueKind.DWord);
					registryKey.SetValue("{1EFB6597-857C-11D1-B16A-RFBCD9458143865T0438}", "45852438", RegistryValueKind.DWord);
					registryKey.SetValue("{04598FC3-866C-11CF-AB7C-F59AD54581438650E442}", "45850442", RegistryValueKind.DWord);
					registryKey.SetValue("{04598FC4-866C-11CF-AB7C-F59AD145814386504D46}", "45850846", RegistryValueKind.DWord);
					registryKey.SetValue("{0776ae27-5ab9-4e18-9063-a763D2658143865H0450}", "65850450", RegistryValueKind.DWord);
					registryKey.SetValue("{1EFB6597-857C-11D1-B16A-8FBCD665814386504G54}", "65850154", RegistryValueKind.DWord);
					registryKey.SetValue("{04598FC3-866C-11CF-AB7C-359AD106581438650458}", "06565458", RegistryValueKind.DWord);
					registryKey.SetValue("{04598FC4-866C-11CF-AB7C-759AD146581438650462}", "46565462", RegistryValueKind.DWord);
					registryKey.SetValue("{0776ae27-5ab9-4e18-9063-5763D186581438650466}", "86565466", RegistryValueKind.DWord);
					registryKey.SetValue("{1EFB6597-857C-11D1-B16A-SFBCD226581438650470}", "26565470", RegistryValueKind.DWord);
					registryKey.SetValue("{04598FC3-866C-11CF-AB7C-559AD266581438650474}", "66565474", RegistryValueKind.DWord);
					registryKey.SetValue("{04598FC4-866C-11CF-AB7C-359AD306581438650478}", "06526478", RegistryValueKind.DWord);
					registryKey.SetValue("{0776ae27-5ab9-4e18-9063-E763D346581438650482}", "46565482", RegistryValueKind.DWord);
					registryKey.SetValue("{1EFB6597-857C-11D1-B16A-RFBCD386581438650486}", "86565486", RegistryValueKind.DWord);
					Interaction.MsgBox("merci pour l'activation ,Redémarrer le programme", MsgBoxStyle.Information, "Activation");
					Application.Restart();
				}
				else if (Operators.CompareString(text, Text_ara_disk.Text, TextCompare: false) != 0)
				{
					Interaction.MsgBox("Clé d'activation est incorrecte", MsgBoxStyle.Critical, "Activation");
					ProjectData.EndApp();
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
				string text2 = Strings.Format(DateTime.Now, "yyMMddHHmmssfff");
				Bitmap val = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, (PixelFormat)2498570);
				Graphics val2 = Graphics.FromImage((Image)(object)val);
				val2.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, (CopyPixelOperation)13369376);
				((Image)val).Save(Application.StartupPath + "\\tchak\\" + text2 + ".snidb", ImageFormat.Jpeg);
				val = null;
				string right = "ERROR | ";
				File.AppendAllText(Application.StartupPath + "\\log_erreur.sni", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(Strings.Format(DateTime.Now, "ddMMyyHHmmssfff") + Label_POSTE.Text, " | "), Module1._USERNAME), " | "), ((Control)this).Name), " | "), NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null)), " | "), right), " | "), ex2.ToString()), "\r\n"), "Ligne : "), fileLineNumber), "\r\n"), "\r\n"), "##########################################################################################################"), "\r\n")), Encoding.UTF8);
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

	private void Button1212_Click(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected Obj, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected Obj, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected Obj, but got Unknown
		DataTable dataTable = new DataTable();
		MySqlDataAdapter val = new MySqlDataAdapter();
		val = new MySqlDataAdapter("select      SOLUTION       From    TABLE_LICENCE    WHERE     SOLUTION  =   '" + Strings.Trim(Text_SOLUTION.Text) + "'   ", Module1.cn_SQL);
		dataTable = new DataTable();
		dataTable.Clear();
		((DbDataAdapter)(object)val).Fill(dataTable);
		if (dataTable.Rows.Count != 0)
		{
			MySqlCommand val2 = new MySqlCommand();
			if (Module1.cn_SQL.State != ConnectionState.Open)
			{
				Module1.cn_SQL.Open();
			}
			val2.CommandText = "UPDATE     TABLE_LICENCE    SET      DATES = NULL   , IMPACT =   '' , SOLUTION =   ''             ";
			val2.Connection = Module1.cn_SQL;
			val2.ExecuteNonQuery();
			Module1.cn_SQL.Close();
			Interaction.MsgBox("merci pour l'activation ,Redémarrer le programme", MsgBoxStyle.Information, "Activation");
			Application.Restart();
		}
	}

	private void Panel5_Paint(object sender, PaintEventArgs e)
	{
	}

	private void Button1_Click(object sender, EventArgs e)
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
				File.AppendAllText(Application.StartupPath + "\\log_erreur.sni", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(Strings.Format(DateTime.Now, "ddMMyyHHmmssfff") + Label_POSTE.Text, " | "), Module1._USERNAME), " | "), ((Control)this).Name), " | "), NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null)), " | "), right), " | "), ex2.ToString()), "\r\n"), "Ligne : "), fileLineNumber), "\r\n"), "\r\n"), "##########################################################################################################"), "\r\n")), Encoding.UTF8);
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

	private void Butt_Click(object sender, EventArgs e)
	{
		SendKeys.Send(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("{", NewLateBinding.LateGet(sender, null, "text", new object[0], null, null, null)), "}")));
	}

	private void Butt_SPACE_Click(object sender, EventArgs e)
	{
		SendKeys.Send(" ");
	}

	private void Butt_BACK_Click(object sender, EventArgs e)
	{
		SendKeys.Send("{BACKSPACE}");
	}

	private void Butt_DRAFT_Click(object sender, EventArgs e)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected Obj, but got Unknown
		Control val = ((Control)this).Controls["Panel_FICHE"];
		foreach (Control control in val.Controls)
		{
			Control val2 = control;
			if (val2.Focused)
			{
				val2.Text = "";
			}
		}
	}

	private void RichText_insc_TextChanged(object sender, EventArgs e)
	{
	}

	private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		((Control)MyProject.Forms.FormDialog_info).Show();
	}

	private void Picture_ALERT_Click(object sender, EventArgs e)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		((Form)MyProject.Forms.FormDialog_ALERT_ERREUR).ShowDialog();
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

	private void Label_DB_Click(object sender, EventArgs e)
	{
	}

	private void Label_DB_DoubleClick(object sender, EventArgs e)
	{
		Process.Start("notepad.EXE", Application.StartupPath + "/CHEMIN_DB.sni");
	}

	private void Label_FOLDER_Click(object sender, EventArgs e)
	{
	}

	private void Label_FOLDER_DoubleClick(object sender, EventArgs e)
	{
		Process.Start("notepad.EXE", Application.StartupPath + "/CHEMIN_FOLDER.sni");
	}

	private void Label_POSTE_Click(object sender, EventArgs e)
	{
	}

	private void Label_POSTE_DoubleClick(object sender, EventArgs e)
	{
		Process.Start("notepad.EXE", Application.StartupPath + "/poste.sni");
	}

	private void Button1323234_Click(object sender, EventArgs e)
	{
		Application.Restart();
	}
}
