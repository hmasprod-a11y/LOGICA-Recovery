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
using System.Threading;
using System.Windows.Forms;
using LOGICA.My;
using Microsoft.Reporting.WinForms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace LOGICA;

[DesignerGenerated]
public class Form_8_gestion : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Button244")]
	private Button _Button244;

	[AccessedThroughProperty("Panel_INFO")]
	private Panel _Panel_INFO;

	[AccessedThroughProperty("Label_BOTTOM")]
	private Label _Label_BOTTOM;

	[AccessedThroughProperty("Label_LEFT")]
	private Label _Label_LEFT;

	[AccessedThroughProperty("Label_RIGHT")]
	private Label _Label_RIGHT;

	[AccessedThroughProperty("Label_TOP")]
	private Label _Label_TOP;

	[AccessedThroughProperty("PictureBox2")]
	private PictureBox _PictureBox2;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	[AccessedThroughProperty("Button_FACTURES")]
	private Button _Button_FACTURES;

	[AccessedThroughProperty("Button_BL")]
	private Button _Button_BL;

	[AccessedThroughProperty("Button_DEVIS")]
	private Button _Button_DEVIS;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[AccessedThroughProperty("DataGridView5")]
	private DataGridView _DataGridView5;

	[AccessedThroughProperty("DOCUMENT")]
	private DataGridViewTextBoxColumn _DOCUMENT;

	[AccessedThroughProperty("N_DOC")]
	private DataGridViewTextBoxColumn _N_DOC;

	[AccessedThroughProperty("CLIENT")]
	private DataGridViewTextBoxColumn _CLIENT;

	[AccessedThroughProperty("TOTAL_TTC")]
	private DataGridViewTextBoxColumn _TOTAL_TTC;

	[AccessedThroughProperty("TOTAL_HT")]
	private DataGridViewTextBoxColumn _TOTAL_HT;

	[AccessedThroughProperty("PictureBox3")]
	private PictureBox _PictureBox3;

	[AccessedThroughProperty("DateTime2_FIND")]
	private DateTimePicker _DateTime2_FIND;

	[AccessedThroughProperty("DateTime1_FIND")]
	private DateTimePicker _DateTime1_FIND;

	[AccessedThroughProperty("Panel_FIND")]
	private Panel _Panel_FIND;

	[AccessedThroughProperty("TableLayoutPanel1")]
	private TableLayoutPanel _TableLayoutPanel1;

	[AccessedThroughProperty("Panel0")]
	private Panel _Panel0;

	[AccessedThroughProperty("Panel")]
	private Panel _Panel;

	[AccessedThroughProperty("Button_DEPENSES")]
	private Button_RJ _Button_DEPENSES;

	[AccessedThroughProperty("Button_RENDEZ_VOUS")]
	private Button_RJ _Button_RENDEZ_VOUS;

	[AccessedThroughProperty("PictureBox9")]
	private PictureBox _PictureBox9;

	[AccessedThroughProperty("PictureBox10")]
	private PictureBox _PictureBox10;

	[AccessedThroughProperty("Button_ETAT_CREDIT_CLIENTS")]
	private Button_RJ _Button_ETAT_CREDIT_CLIENTS;

	[AccessedThroughProperty("Button_CLIENTS")]
	private Button_RJ _Button_CLIENTS;

	[AccessedThroughProperty("Button_CLIENTS_REGLEMENTS")]
	private Button_RJ _Button_CLIENTS_REGLEMENTS;

	[AccessedThroughProperty("PictureBox7")]
	private PictureBox _PictureBox7;

	[AccessedThroughProperty("PictureBox8")]
	private PictureBox _PictureBox8;

	[AccessedThroughProperty("Button_ETAT_CREDIT_FOURNISSEURS")]
	private Button_RJ _Button_ETAT_CREDIT_FOURNISSEURS;

	[AccessedThroughProperty("Button_FOURNISSEURS_REGLEMENTS")]
	private Button_RJ _Button_FOURNISSEURS_REGLEMENTS;

	[AccessedThroughProperty("Button_FOURNISSEURS")]
	private Button_RJ _Button_FOURNISSEURS;

	[AccessedThroughProperty("PictureBox4")]
	private PictureBox _PictureBox4;

	[AccessedThroughProperty("PictureBox5")]
	private PictureBox _PictureBox5;

	[AccessedThroughProperty("PictureBox6")]
	private PictureBox _PictureBox6;

	[AccessedThroughProperty("Button_MOUVEMENTS")]
	private Button_RJ _Button_MOUVEMENTS;

	[AccessedThroughProperty("Button_SORTIES")]
	private Button_RJ _Button_SORTIES;

	[AccessedThroughProperty("Button_INVENTAIRE")]
	private Button_RJ _Button_INVENTAIRE;

	[AccessedThroughProperty("Button_RECEPTIONS")]
	private Button_RJ _Button_RECEPTIONS;

	[AccessedThroughProperty("Button_NOMENCLATURE")]
	private Button_RJ _Button_NOMENCLATURE;

	[AccessedThroughProperty("Button_COMMANDES")]
	private Button_RJ _Button_COMMANDES;

	[AccessedThroughProperty("PictureBox11")]
	private PictureBox _PictureBox11;

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
			_Label_TOP = value;
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

	internal virtual Button Button_FACTURES
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_FACTURES;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_FACTURES_Click;
			if (_Button_FACTURES != null)
			{
				((Control)_Button_FACTURES).Click -= eventHandler;
			}
			_Button_FACTURES = value;
			if (_Button_FACTURES != null)
			{
				((Control)_Button_FACTURES).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button_BL
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_BL;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_BL_Click;
			if (_Button_BL != null)
			{
				((Control)_Button_BL).Click -= eventHandler;
			}
			_Button_BL = value;
			if (_Button_BL != null)
			{
				((Control)_Button_BL).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button_DEVIS
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_DEVIS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_DEVIS_Click;
			if (_Button_DEVIS != null)
			{
				((Control)_Button_DEVIS).Click -= eventHandler;
			}
			_Button_DEVIS = value;
			if (_Button_DEVIS != null)
			{
				((Control)_Button_DEVIS).Click += eventHandler;
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

	internal virtual DataGridView DataGridView5
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridView5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGridView5 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn DOCUMENT
	{
		[DebuggerNonUserCode]
		get
		{
			return _DOCUMENT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DOCUMENT = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn N_DOC
	{
		[DebuggerNonUserCode]
		get
		{
			return _N_DOC;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_N_DOC = value;
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

	internal virtual DataGridViewTextBoxColumn TOTAL_TTC
	{
		[DebuggerNonUserCode]
		get
		{
			return _TOTAL_TTC;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TOTAL_TTC = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn TOTAL_HT
	{
		[DebuggerNonUserCode]
		get
		{
			return _TOTAL_HT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TOTAL_HT = value;
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

	internal virtual Panel Panel0
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel0 = value;
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
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			EventHandler eventHandler = Panel_DoubleClick;
			PaintEventHandler val = Panel_Paint;
			if (_Panel != null)
			{
				((Control)_Panel).DoubleClick -= eventHandler;
				((Control)_Panel).Paint -= val;
			}
			_Panel = value;
			if (_Panel != null)
			{
				((Control)_Panel).DoubleClick += eventHandler;
				((Control)_Panel).Paint += val;
			}
		}
	}

	internal virtual Button_RJ Button_DEPENSES
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_DEPENSES;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_DEPENSES_Click;
			if (_Button_DEPENSES != null)
			{
				((Control)_Button_DEPENSES).Click -= eventHandler;
			}
			_Button_DEPENSES = value;
			if (_Button_DEPENSES != null)
			{
				((Control)_Button_DEPENSES).Click += eventHandler;
			}
		}
	}

	internal virtual Button_RJ Button_RENDEZ_VOUS
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_RENDEZ_VOUS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_RENDEZ_VOUS_Click;
			if (_Button_RENDEZ_VOUS != null)
			{
				((Control)_Button_RENDEZ_VOUS).Click -= eventHandler;
			}
			_Button_RENDEZ_VOUS = value;
			if (_Button_RENDEZ_VOUS != null)
			{
				((Control)_Button_RENDEZ_VOUS).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox PictureBox9
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox9 = value;
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

	internal virtual Button_RJ Button_ETAT_CREDIT_CLIENTS
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_ETAT_CREDIT_CLIENTS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_ETAT_CREDIT_CLIENTS_Click;
			if (_Button_ETAT_CREDIT_CLIENTS != null)
			{
				((Control)_Button_ETAT_CREDIT_CLIENTS).Click -= eventHandler;
			}
			_Button_ETAT_CREDIT_CLIENTS = value;
			if (_Button_ETAT_CREDIT_CLIENTS != null)
			{
				((Control)_Button_ETAT_CREDIT_CLIENTS).Click += eventHandler;
			}
		}
	}

	internal virtual Button_RJ Button_CLIENTS
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_CLIENTS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_CLIENTS_Click;
			if (_Button_CLIENTS != null)
			{
				((Control)_Button_CLIENTS).Click -= eventHandler;
			}
			_Button_CLIENTS = value;
			if (_Button_CLIENTS != null)
			{
				((Control)_Button_CLIENTS).Click += eventHandler;
			}
		}
	}

	internal virtual Button_RJ Button_CLIENTS_REGLEMENTS
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_CLIENTS_REGLEMENTS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_CLIENTS_REGLEMENTS_Click;
			if (_Button_CLIENTS_REGLEMENTS != null)
			{
				((Control)_Button_CLIENTS_REGLEMENTS).Click -= eventHandler;
			}
			_Button_CLIENTS_REGLEMENTS = value;
			if (_Button_CLIENTS_REGLEMENTS != null)
			{
				((Control)_Button_CLIENTS_REGLEMENTS).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox PictureBox7
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox7 = value;
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

	internal virtual Button_RJ Button_ETAT_CREDIT_FOURNISSEURS
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_ETAT_CREDIT_FOURNISSEURS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_ETAT_CREDIT_FOURNISSEURS_Click;
			if (_Button_ETAT_CREDIT_FOURNISSEURS != null)
			{
				((Control)_Button_ETAT_CREDIT_FOURNISSEURS).Click -= eventHandler;
			}
			_Button_ETAT_CREDIT_FOURNISSEURS = value;
			if (_Button_ETAT_CREDIT_FOURNISSEURS != null)
			{
				((Control)_Button_ETAT_CREDIT_FOURNISSEURS).Click += eventHandler;
			}
		}
	}

	internal virtual Button_RJ Button_FOURNISSEURS_REGLEMENTS
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_FOURNISSEURS_REGLEMENTS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_FOURNISSEURS_REGLEMENTS_Click;
			if (_Button_FOURNISSEURS_REGLEMENTS != null)
			{
				((Control)_Button_FOURNISSEURS_REGLEMENTS).Click -= eventHandler;
			}
			_Button_FOURNISSEURS_REGLEMENTS = value;
			if (_Button_FOURNISSEURS_REGLEMENTS != null)
			{
				((Control)_Button_FOURNISSEURS_REGLEMENTS).Click += eventHandler;
			}
		}
	}

	internal virtual Button_RJ Button_FOURNISSEURS
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_FOURNISSEURS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_FOURNISSEURS_Click;
			if (_Button_FOURNISSEURS != null)
			{
				((Control)_Button_FOURNISSEURS).Click -= eventHandler;
			}
			_Button_FOURNISSEURS = value;
			if (_Button_FOURNISSEURS != null)
			{
				((Control)_Button_FOURNISSEURS).Click += eventHandler;
			}
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

	internal virtual Button_RJ Button_MOUVEMENTS
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_MOUVEMENTS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_MOUVEMENTS_Click;
			if (_Button_MOUVEMENTS != null)
			{
				((Control)_Button_MOUVEMENTS).Click -= eventHandler;
			}
			_Button_MOUVEMENTS = value;
			if (_Button_MOUVEMENTS != null)
			{
				((Control)_Button_MOUVEMENTS).Click += eventHandler;
			}
		}
	}

	internal virtual Button_RJ Button_SORTIES
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_SORTIES;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_SORTIES_Click;
			if (_Button_SORTIES != null)
			{
				((Control)_Button_SORTIES).Click -= eventHandler;
			}
			_Button_SORTIES = value;
			if (_Button_SORTIES != null)
			{
				((Control)_Button_SORTIES).Click += eventHandler;
			}
		}
	}

	internal virtual Button_RJ Button_INVENTAIRE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_INVENTAIRE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_INVENTAIRE_Click;
			if (_Button_INVENTAIRE != null)
			{
				((Control)_Button_INVENTAIRE).Click -= eventHandler;
			}
			_Button_INVENTAIRE = value;
			if (_Button_INVENTAIRE != null)
			{
				((Control)_Button_INVENTAIRE).Click += eventHandler;
			}
		}
	}

	internal virtual Button_RJ Button_RECEPTIONS
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_RECEPTIONS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_RECEPTIONS_Click;
			if (_Button_RECEPTIONS != null)
			{
				((Control)_Button_RECEPTIONS).Click -= eventHandler;
			}
			_Button_RECEPTIONS = value;
			if (_Button_RECEPTIONS != null)
			{
				((Control)_Button_RECEPTIONS).Click += eventHandler;
			}
		}
	}

	internal virtual Button_RJ Button_NOMENCLATURE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_NOMENCLATURE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_NOMENCLATURE_Click;
			if (_Button_NOMENCLATURE != null)
			{
				((Control)_Button_NOMENCLATURE).Click -= eventHandler;
			}
			_Button_NOMENCLATURE = value;
			if (_Button_NOMENCLATURE != null)
			{
				((Control)_Button_NOMENCLATURE).Click += eventHandler;
			}
		}
	}

	internal virtual Button_RJ Button_COMMANDES
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_COMMANDES;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_COMMANDES_Click;
			if (_Button_COMMANDES != null)
			{
				((Control)_Button_COMMANDES).Click -= eventHandler;
			}
			_Button_COMMANDES = value;
			if (_Button_COMMANDES != null)
			{
				((Control)_Button_COMMANDES).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox PictureBox11
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox11 = value;
		}
	}

	[DebuggerNonUserCode]
	public Form_8_gestion()
	{
		((Control)this).Resize += Form_Resize;
		((Form)this).Load += Form_8_gestion_Load;
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
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected Obj, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected Obj, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected Obj, but got Unknown
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected Obj, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected Obj, but got Unknown
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected Obj, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected Obj, but got Unknown
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected Obj, but got Unknown
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
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected Obj, but got Unknown
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected Obj, but got Unknown
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected Obj, but got Unknown
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Expected Obj, but got Unknown
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected Obj, but got Unknown
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Expected Obj, but got Unknown
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Expected Obj, but got Unknown
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Expected Obj, but got Unknown
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Expected Obj, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form_8_gestion));
		Panel_FIND = new Panel();
		DateTime1_FIND = new DateTimePicker();
		PictureBox3 = new PictureBox();
		DateTime2_FIND = new DateTimePicker();
		DataGridView5 = new DataGridView();
		DOCUMENT = new DataGridViewTextBoxColumn();
		N_DOC = new DataGridViewTextBoxColumn();
		CLIENT = new DataGridViewTextBoxColumn();
		TOTAL_TTC = new DataGridViewTextBoxColumn();
		TOTAL_HT = new DataGridViewTextBoxColumn();
		Button2 = new Button();
		Panel_INFO = new Panel();
		PictureBox2 = new PictureBox();
		PictureBox1 = new PictureBox();
		Button_FACTURES = new Button();
		Button_BL = new Button();
		Button_DEVIS = new Button();
		Label_BOTTOM = new Label();
		Label_LEFT = new Label();
		Label_RIGHT = new Label();
		Label_TOP = new Label();
		Button244 = new Button();
		TableLayoutPanel1 = new TableLayoutPanel();
		Panel0 = new Panel();
		Panel = new Panel();
		Button_COMMANDES = new Button_RJ();
		PictureBox11 = new PictureBox();
		Button_NOMENCLATURE = new Button_RJ();
		Button_DEPENSES = new Button_RJ();
		Button_RENDEZ_VOUS = new Button_RJ();
		PictureBox9 = new PictureBox();
		PictureBox10 = new PictureBox();
		Button_ETAT_CREDIT_CLIENTS = new Button_RJ();
		Button_CLIENTS = new Button_RJ();
		Button_CLIENTS_REGLEMENTS = new Button_RJ();
		PictureBox7 = new PictureBox();
		PictureBox8 = new PictureBox();
		Button_ETAT_CREDIT_FOURNISSEURS = new Button_RJ();
		Button_FOURNISSEURS_REGLEMENTS = new Button_RJ();
		Button_FOURNISSEURS = new Button_RJ();
		PictureBox4 = new PictureBox();
		PictureBox5 = new PictureBox();
		PictureBox6 = new PictureBox();
		Button_MOUVEMENTS = new Button_RJ();
		Button_SORTIES = new Button_RJ();
		Button_INVENTAIRE = new Button_RJ();
		Button_RECEPTIONS = new Button_RJ();
		((Control)Panel_FIND).SuspendLayout();
		((ISupportInitialize)PictureBox3).BeginInit();
		((ISupportInitialize)DataGridView5).BeginInit();
		((Control)Panel_INFO).SuspendLayout();
		((ISupportInitialize)PictureBox2).BeginInit();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)TableLayoutPanel1).SuspendLayout();
		((Control)Panel0).SuspendLayout();
		((Control)Panel).SuspendLayout();
		((ISupportInitialize)PictureBox11).BeginInit();
		((ISupportInitialize)PictureBox9).BeginInit();
		((ISupportInitialize)PictureBox10).BeginInit();
		((ISupportInitialize)PictureBox7).BeginInit();
		((ISupportInitialize)PictureBox8).BeginInit();
		((ISupportInitialize)PictureBox4).BeginInit();
		((ISupportInitialize)PictureBox5).BeginInit();
		((ISupportInitialize)PictureBox6).BeginInit();
		((Control)this).SuspendLayout();
		((Control)Panel_FIND).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Panel_FIND).Controls.Add((Control)(object)DateTime1_FIND);
		((Control)Panel_FIND).Controls.Add((Control)(object)PictureBox3);
		((Control)Panel_FIND).Controls.Add((Control)(object)DateTime2_FIND);
		componentResourceManager.ApplyResources(Panel_FIND, "Panel_FIND");
		((Control)Panel_FIND).Name = "Panel_FIND";
		componentResourceManager.ApplyResources(DateTime1_FIND, "DateTime1_FIND");
		DateTime1_FIND.Format = (DateTimePickerFormat)2;
		((Control)DateTime1_FIND).Name = "DateTime1_FIND";
		DateTimePicker dateTime1_FIND = DateTime1_FIND;
		DateTime value = new DateTime(2021, 4, 7, 0, 0, 0, 0);
		dateTime1_FIND.Value = value;
		componentResourceManager.ApplyResources(PictureBox3, "PictureBox3");
		((Control)PictureBox3).Name = "PictureBox3";
		PictureBox3.TabStop = false;
		componentResourceManager.ApplyResources(DateTime2_FIND, "DateTime2_FIND");
		DateTime2_FIND.Format = (DateTimePickerFormat)2;
		((Control)DateTime2_FIND).Name = "DateTime2_FIND";
		DataGridView5.AllowUserToAddRows = false;
		DataGridView5.AllowUserToResizeColumns = false;
		DataGridView5.AllowUserToResizeRows = false;
		DataGridView5.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)16;
		DataGridView5.BackgroundColor = Color.White;
		DataGridView5.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		DataGridView5.Columns.AddRange(new DataGridViewColumn[5]
		{
			(DataGridViewColumn)DOCUMENT,
			(DataGridViewColumn)N_DOC,
			(DataGridViewColumn)CLIENT,
			(DataGridViewColumn)TOTAL_TTC,
			(DataGridViewColumn)TOTAL_HT
		});
		DataGridView5.EditMode = (DataGridViewEditMode)4;
		DataGridView5.EnableHeadersVisualStyles = false;
		componentResourceManager.ApplyResources(DataGridView5, "DataGridView5");
		((Control)DataGridView5).Name = "DataGridView5";
		DataGridView5.RowHeadersVisible = false;
		DataGridView5.SelectionMode = (DataGridViewSelectionMode)1;
		componentResourceManager.ApplyResources(DOCUMENT, "DOCUMENT");
		((DataGridViewColumn)DOCUMENT).Name = "DOCUMENT";
		componentResourceManager.ApplyResources(N_DOC, "N_DOC");
		((DataGridViewColumn)N_DOC).Name = "N_DOC";
		componentResourceManager.ApplyResources(CLIENT, "CLIENT");
		((DataGridViewColumn)CLIENT).Name = "CLIENT";
		componentResourceManager.ApplyResources(TOTAL_TTC, "TOTAL_TTC");
		((DataGridViewColumn)TOTAL_TTC).Name = "TOTAL_TTC";
		componentResourceManager.ApplyResources(TOTAL_HT, "TOTAL_HT");
		((DataGridViewColumn)TOTAL_HT).Name = "TOTAL_HT";
		((Control)Button2).Cursor = Cursors.Hand;
		((ButtonBase)Button2).FlatAppearance.BorderColor = Color.DarkGray;
		componentResourceManager.ApplyResources(Button2, "Button2");
		((Control)Button2).Name = "Button2";
		((ButtonBase)Button2).UseVisualStyleBackColor = true;
		((Control)Panel_INFO).BackColor = Color.White;
		Panel_INFO.BorderStyle = (BorderStyle)1;
		((Control)Panel_INFO).Controls.Add((Control)(object)PictureBox2);
		((Control)Panel_INFO).Controls.Add((Control)(object)PictureBox1);
		((Control)Panel_INFO).Controls.Add((Control)(object)Button_FACTURES);
		((Control)Panel_INFO).Controls.Add((Control)(object)Button_BL);
		((Control)Panel_INFO).Controls.Add((Control)(object)Button_DEVIS);
		((Control)Panel_INFO).Controls.Add((Control)(object)Label_BOTTOM);
		((Control)Panel_INFO).Controls.Add((Control)(object)Label_LEFT);
		((Control)Panel_INFO).Controls.Add((Control)(object)Label_RIGHT);
		((Control)Panel_INFO).Controls.Add((Control)(object)Label_TOP);
		componentResourceManager.ApplyResources(Panel_INFO, "Panel_INFO");
		((Control)Panel_INFO).Name = "Panel_INFO";
		componentResourceManager.ApplyResources(PictureBox2, "PictureBox2");
		((Control)PictureBox2).Name = "PictureBox2";
		PictureBox2.TabStop = false;
		componentResourceManager.ApplyResources(PictureBox1, "PictureBox1");
		((Control)PictureBox1).Name = "PictureBox1";
		PictureBox1.TabStop = false;
		((Control)Button_FACTURES).Cursor = Cursors.Hand;
		((ButtonBase)Button_FACTURES).FlatAppearance.BorderColor = Color.FromArgb(22, 106, 238);
		componentResourceManager.ApplyResources(Button_FACTURES, "Button_FACTURES");
		((Control)Button_FACTURES).Name = "Button_FACTURES";
		((ButtonBase)Button_FACTURES).UseVisualStyleBackColor = true;
		((Control)Button_BL).Cursor = Cursors.Hand;
		((ButtonBase)Button_BL).FlatAppearance.BorderColor = Color.FromArgb(22, 106, 238);
		componentResourceManager.ApplyResources(Button_BL, "Button_BL");
		((Control)Button_BL).Name = "Button_BL";
		((ButtonBase)Button_BL).UseVisualStyleBackColor = true;
		((Control)Button_DEVIS).Cursor = Cursors.Hand;
		((ButtonBase)Button_DEVIS).FlatAppearance.BorderColor = Color.FromArgb(22, 106, 238);
		componentResourceManager.ApplyResources(Button_DEVIS, "Button_DEVIS");
		((Control)Button_DEVIS).Name = "Button_DEVIS";
		((ButtonBase)Button_DEVIS).UseVisualStyleBackColor = true;
		((Control)Label_BOTTOM).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label_BOTTOM).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Label_BOTTOM, "Label_BOTTOM");
		((Control)Label_BOTTOM).ForeColor = Color.White;
		((Control)Label_BOTTOM).Name = "Label_BOTTOM";
		((Control)Label_LEFT).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label_LEFT).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Label_LEFT, "Label_LEFT");
		((Control)Label_LEFT).ForeColor = Color.White;
		((Control)Label_LEFT).Name = "Label_LEFT";
		((Control)Label_RIGHT).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label_RIGHT).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Label_RIGHT, "Label_RIGHT");
		((Control)Label_RIGHT).ForeColor = Color.White;
		((Control)Label_RIGHT).Name = "Label_RIGHT";
		((Control)Label_TOP).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label_TOP).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Label_TOP, "Label_TOP");
		((Control)Label_TOP).ForeColor = Color.White;
		((Control)Label_TOP).Name = "Label_TOP";
		componentResourceManager.ApplyResources(Button244, "Button244");
		((ButtonBase)Button244).BackColor = Color.Red;
		((Control)Button244).Cursor = Cursors.Hand;
		((Control)Button244).ForeColor = Color.White;
		((Control)Button244).Name = "Button244";
		((ButtonBase)Button244).UseVisualStyleBackColor = false;
		((Control)TableLayoutPanel1).BackColor = Color.White;
		componentResourceManager.ApplyResources(TableLayoutPanel1, "TableLayoutPanel1");
		TableLayoutPanel1.Controls.Add((Control)(object)Panel0, 0, 0);
		((Control)TableLayoutPanel1).Name = "TableLayoutPanel1";
		((Control)Panel0).Controls.Add((Control)(object)Button244);
		((Control)Panel0).Controls.Add((Control)(object)Panel);
		componentResourceManager.ApplyResources(Panel0, "Panel0");
		((Control)Panel0).Name = "Panel0";
		((Control)Panel).Controls.Add((Control)(object)Button_COMMANDES);
		((Control)Panel).Controls.Add((Control)(object)PictureBox11);
		((Control)Panel).Controls.Add((Control)(object)Button_NOMENCLATURE);
		((Control)Panel).Controls.Add((Control)(object)Button_DEPENSES);
		((Control)Panel).Controls.Add((Control)(object)Button_RENDEZ_VOUS);
		((Control)Panel).Controls.Add((Control)(object)PictureBox9);
		((Control)Panel).Controls.Add((Control)(object)PictureBox10);
		((Control)Panel).Controls.Add((Control)(object)Button_ETAT_CREDIT_CLIENTS);
		((Control)Panel).Controls.Add((Control)(object)Button_CLIENTS);
		((Control)Panel).Controls.Add((Control)(object)Button_CLIENTS_REGLEMENTS);
		((Control)Panel).Controls.Add((Control)(object)PictureBox7);
		((Control)Panel).Controls.Add((Control)(object)PictureBox8);
		((Control)Panel).Controls.Add((Control)(object)Button_ETAT_CREDIT_FOURNISSEURS);
		((Control)Panel).Controls.Add((Control)(object)Button_FOURNISSEURS_REGLEMENTS);
		((Control)Panel).Controls.Add((Control)(object)Button_FOURNISSEURS);
		((Control)Panel).Controls.Add((Control)(object)PictureBox4);
		((Control)Panel).Controls.Add((Control)(object)PictureBox5);
		((Control)Panel).Controls.Add((Control)(object)PictureBox6);
		((Control)Panel).Controls.Add((Control)(object)Button_MOUVEMENTS);
		((Control)Panel).Controls.Add((Control)(object)Button_SORTIES);
		((Control)Panel).Controls.Add((Control)(object)Button_INVENTAIRE);
		((Control)Panel).Controls.Add((Control)(object)Button_RECEPTIONS);
		((Control)Panel).Controls.Add((Control)(object)Panel_FIND);
		((Control)Panel).Controls.Add((Control)(object)Panel_INFO);
		((Control)Panel).Controls.Add((Control)(object)Button2);
		((Control)Panel).Controls.Add((Control)(object)DataGridView5);
		componentResourceManager.ApplyResources(Panel, "Panel");
		((Control)Panel).Name = "Panel";
		Button_COMMANDES._BackgroundColor = Color.White;
		Button_COMMANDES._BorderColor = Color.FromArgb(22, 106, 238);
		Button_COMMANDES._BorderRadius = 8;
		Button_COMMANDES._BorderSize = 2;
		Button_COMMANDES._TextColor = Color.Black;
		((ButtonBase)Button_COMMANDES).BackColor = Color.White;
		((Control)Button_COMMANDES).Cursor = Cursors.Hand;
		((ButtonBase)Button_COMMANDES).FlatAppearance.BorderSize = 0;
		componentResourceManager.ApplyResources(Button_COMMANDES, "Button_COMMANDES");
		((Control)Button_COMMANDES).ForeColor = Color.Black;
		((Control)Button_COMMANDES).Name = "Button_COMMANDES";
		((ButtonBase)Button_COMMANDES).UseVisualStyleBackColor = false;
		componentResourceManager.ApplyResources(PictureBox11, "PictureBox11");
		((Control)PictureBox11).Name = "PictureBox11";
		PictureBox11.TabStop = false;
		Button_NOMENCLATURE._BackgroundColor = Color.White;
		Button_NOMENCLATURE._BorderColor = Color.FromArgb(22, 106, 238);
		Button_NOMENCLATURE._BorderRadius = 8;
		Button_NOMENCLATURE._BorderSize = 2;
		Button_NOMENCLATURE._TextColor = Color.Black;
		((ButtonBase)Button_NOMENCLATURE).BackColor = Color.White;
		((Control)Button_NOMENCLATURE).Cursor = Cursors.Hand;
		((ButtonBase)Button_NOMENCLATURE).FlatAppearance.BorderSize = 0;
		componentResourceManager.ApplyResources(Button_NOMENCLATURE, "Button_NOMENCLATURE");
		((Control)Button_NOMENCLATURE).ForeColor = Color.Black;
		((Control)Button_NOMENCLATURE).Name = "Button_NOMENCLATURE";
		((ButtonBase)Button_NOMENCLATURE).UseVisualStyleBackColor = false;
		Button_DEPENSES._BackgroundColor = Color.White;
		Button_DEPENSES._BorderColor = Color.FromArgb(22, 106, 238);
		Button_DEPENSES._BorderRadius = 8;
		Button_DEPENSES._BorderSize = 2;
		Button_DEPENSES._TextColor = Color.Black;
		((ButtonBase)Button_DEPENSES).BackColor = Color.White;
		((Control)Button_DEPENSES).Cursor = Cursors.Hand;
		((ButtonBase)Button_DEPENSES).FlatAppearance.BorderSize = 0;
		componentResourceManager.ApplyResources(Button_DEPENSES, "Button_DEPENSES");
		((Control)Button_DEPENSES).ForeColor = Color.Black;
		((Control)Button_DEPENSES).Name = "Button_DEPENSES";
		((ButtonBase)Button_DEPENSES).UseVisualStyleBackColor = false;
		Button_RENDEZ_VOUS._BackgroundColor = Color.White;
		Button_RENDEZ_VOUS._BorderColor = Color.FromArgb(22, 106, 238);
		Button_RENDEZ_VOUS._BorderRadius = 8;
		Button_RENDEZ_VOUS._BorderSize = 2;
		Button_RENDEZ_VOUS._TextColor = Color.Black;
		((ButtonBase)Button_RENDEZ_VOUS).BackColor = Color.White;
		((Control)Button_RENDEZ_VOUS).Cursor = Cursors.Hand;
		((ButtonBase)Button_RENDEZ_VOUS).FlatAppearance.BorderSize = 0;
		componentResourceManager.ApplyResources(Button_RENDEZ_VOUS, "Button_RENDEZ_VOUS");
		((Control)Button_RENDEZ_VOUS).ForeColor = Color.Black;
		((Control)Button_RENDEZ_VOUS).Name = "Button_RENDEZ_VOUS";
		((ButtonBase)Button_RENDEZ_VOUS).UseVisualStyleBackColor = false;
		componentResourceManager.ApplyResources(PictureBox9, "PictureBox9");
		((Control)PictureBox9).Name = "PictureBox9";
		PictureBox9.TabStop = false;
		componentResourceManager.ApplyResources(PictureBox10, "PictureBox10");
		((Control)PictureBox10).Name = "PictureBox10";
		PictureBox10.TabStop = false;
		Button_ETAT_CREDIT_CLIENTS._BackgroundColor = Color.White;
		Button_ETAT_CREDIT_CLIENTS._BorderColor = Color.FromArgb(22, 106, 238);
		Button_ETAT_CREDIT_CLIENTS._BorderRadius = 8;
		Button_ETAT_CREDIT_CLIENTS._BorderSize = 2;
		Button_ETAT_CREDIT_CLIENTS._TextColor = Color.Black;
		((ButtonBase)Button_ETAT_CREDIT_CLIENTS).BackColor = Color.White;
		((Control)Button_ETAT_CREDIT_CLIENTS).Cursor = Cursors.Hand;
		((ButtonBase)Button_ETAT_CREDIT_CLIENTS).FlatAppearance.BorderSize = 0;
		componentResourceManager.ApplyResources(Button_ETAT_CREDIT_CLIENTS, "Button_ETAT_CREDIT_CLIENTS");
		((Control)Button_ETAT_CREDIT_CLIENTS).ForeColor = Color.Black;
		((Control)Button_ETAT_CREDIT_CLIENTS).Name = "Button_ETAT_CREDIT_CLIENTS";
		((ButtonBase)Button_ETAT_CREDIT_CLIENTS).UseVisualStyleBackColor = false;
		Button_CLIENTS._BackgroundColor = Color.White;
		Button_CLIENTS._BorderColor = Color.FromArgb(22, 106, 238);
		Button_CLIENTS._BorderRadius = 8;
		Button_CLIENTS._BorderSize = 2;
		Button_CLIENTS._TextColor = Color.Black;
		((ButtonBase)Button_CLIENTS).BackColor = Color.White;
		((Control)Button_CLIENTS).Cursor = Cursors.Hand;
		((ButtonBase)Button_CLIENTS).FlatAppearance.BorderSize = 0;
		componentResourceManager.ApplyResources(Button_CLIENTS, "Button_CLIENTS");
		((Control)Button_CLIENTS).ForeColor = Color.Black;
		((Control)Button_CLIENTS).Name = "Button_CLIENTS";
		((ButtonBase)Button_CLIENTS).UseVisualStyleBackColor = false;
		Button_CLIENTS_REGLEMENTS._BackgroundColor = Color.White;
		Button_CLIENTS_REGLEMENTS._BorderColor = Color.FromArgb(22, 106, 238);
		Button_CLIENTS_REGLEMENTS._BorderRadius = 8;
		Button_CLIENTS_REGLEMENTS._BorderSize = 2;
		Button_CLIENTS_REGLEMENTS._TextColor = Color.Black;
		((ButtonBase)Button_CLIENTS_REGLEMENTS).BackColor = Color.White;
		((Control)Button_CLIENTS_REGLEMENTS).Cursor = Cursors.Hand;
		((ButtonBase)Button_CLIENTS_REGLEMENTS).FlatAppearance.BorderSize = 0;
		componentResourceManager.ApplyResources(Button_CLIENTS_REGLEMENTS, "Button_CLIENTS_REGLEMENTS");
		((Control)Button_CLIENTS_REGLEMENTS).ForeColor = Color.Black;
		((Control)Button_CLIENTS_REGLEMENTS).Name = "Button_CLIENTS_REGLEMENTS";
		((ButtonBase)Button_CLIENTS_REGLEMENTS).UseVisualStyleBackColor = false;
		componentResourceManager.ApplyResources(PictureBox7, "PictureBox7");
		((Control)PictureBox7).Name = "PictureBox7";
		PictureBox7.TabStop = false;
		componentResourceManager.ApplyResources(PictureBox8, "PictureBox8");
		((Control)PictureBox8).Name = "PictureBox8";
		PictureBox8.TabStop = false;
		Button_ETAT_CREDIT_FOURNISSEURS._BackgroundColor = Color.White;
		Button_ETAT_CREDIT_FOURNISSEURS._BorderColor = Color.FromArgb(22, 106, 238);
		Button_ETAT_CREDIT_FOURNISSEURS._BorderRadius = 8;
		Button_ETAT_CREDIT_FOURNISSEURS._BorderSize = 2;
		Button_ETAT_CREDIT_FOURNISSEURS._TextColor = Color.Black;
		((ButtonBase)Button_ETAT_CREDIT_FOURNISSEURS).BackColor = Color.White;
		((Control)Button_ETAT_CREDIT_FOURNISSEURS).Cursor = Cursors.Hand;
		((ButtonBase)Button_ETAT_CREDIT_FOURNISSEURS).FlatAppearance.BorderSize = 0;
		componentResourceManager.ApplyResources(Button_ETAT_CREDIT_FOURNISSEURS, "Button_ETAT_CREDIT_FOURNISSEURS");
		((Control)Button_ETAT_CREDIT_FOURNISSEURS).ForeColor = Color.Black;
		((Control)Button_ETAT_CREDIT_FOURNISSEURS).Name = "Button_ETAT_CREDIT_FOURNISSEURS";
		((ButtonBase)Button_ETAT_CREDIT_FOURNISSEURS).UseVisualStyleBackColor = false;
		Button_FOURNISSEURS_REGLEMENTS._BackgroundColor = Color.White;
		Button_FOURNISSEURS_REGLEMENTS._BorderColor = Color.FromArgb(22, 106, 238);
		Button_FOURNISSEURS_REGLEMENTS._BorderRadius = 8;
		Button_FOURNISSEURS_REGLEMENTS._BorderSize = 2;
		Button_FOURNISSEURS_REGLEMENTS._TextColor = Color.Black;
		((ButtonBase)Button_FOURNISSEURS_REGLEMENTS).BackColor = Color.White;
		((Control)Button_FOURNISSEURS_REGLEMENTS).Cursor = Cursors.Hand;
		((ButtonBase)Button_FOURNISSEURS_REGLEMENTS).FlatAppearance.BorderSize = 0;
		componentResourceManager.ApplyResources(Button_FOURNISSEURS_REGLEMENTS, "Button_FOURNISSEURS_REGLEMENTS");
		((Control)Button_FOURNISSEURS_REGLEMENTS).ForeColor = Color.Black;
		((Control)Button_FOURNISSEURS_REGLEMENTS).Name = "Button_FOURNISSEURS_REGLEMENTS";
		((ButtonBase)Button_FOURNISSEURS_REGLEMENTS).UseVisualStyleBackColor = false;
		Button_FOURNISSEURS._BackgroundColor = Color.White;
		Button_FOURNISSEURS._BorderColor = Color.FromArgb(22, 106, 238);
		Button_FOURNISSEURS._BorderRadius = 8;
		Button_FOURNISSEURS._BorderSize = 2;
		Button_FOURNISSEURS._TextColor = Color.Black;
		((ButtonBase)Button_FOURNISSEURS).BackColor = Color.White;
		((Control)Button_FOURNISSEURS).Cursor = Cursors.Hand;
		((ButtonBase)Button_FOURNISSEURS).FlatAppearance.BorderSize = 0;
		componentResourceManager.ApplyResources(Button_FOURNISSEURS, "Button_FOURNISSEURS");
		((Control)Button_FOURNISSEURS).ForeColor = Color.Black;
		((Control)Button_FOURNISSEURS).Name = "Button_FOURNISSEURS";
		((ButtonBase)Button_FOURNISSEURS).UseVisualStyleBackColor = false;
		componentResourceManager.ApplyResources(PictureBox4, "PictureBox4");
		((Control)PictureBox4).Name = "PictureBox4";
		PictureBox4.TabStop = false;
		componentResourceManager.ApplyResources(PictureBox5, "PictureBox5");
		((Control)PictureBox5).Name = "PictureBox5";
		PictureBox5.TabStop = false;
		componentResourceManager.ApplyResources(PictureBox6, "PictureBox6");
		((Control)PictureBox6).Name = "PictureBox6";
		PictureBox6.TabStop = false;
		Button_MOUVEMENTS._BackgroundColor = Color.White;
		Button_MOUVEMENTS._BorderColor = Color.FromArgb(22, 106, 238);
		Button_MOUVEMENTS._BorderRadius = 8;
		Button_MOUVEMENTS._BorderSize = 2;
		Button_MOUVEMENTS._TextColor = Color.Black;
		((ButtonBase)Button_MOUVEMENTS).BackColor = Color.White;
		((Control)Button_MOUVEMENTS).Cursor = Cursors.Hand;
		((ButtonBase)Button_MOUVEMENTS).FlatAppearance.BorderSize = 0;
		componentResourceManager.ApplyResources(Button_MOUVEMENTS, "Button_MOUVEMENTS");
		((Control)Button_MOUVEMENTS).ForeColor = Color.Black;
		((Control)Button_MOUVEMENTS).Name = "Button_MOUVEMENTS";
		((ButtonBase)Button_MOUVEMENTS).UseVisualStyleBackColor = false;
		Button_SORTIES._BackgroundColor = Color.White;
		Button_SORTIES._BorderColor = Color.FromArgb(22, 106, 238);
		Button_SORTIES._BorderRadius = 8;
		Button_SORTIES._BorderSize = 2;
		Button_SORTIES._TextColor = Color.Black;
		((ButtonBase)Button_SORTIES).BackColor = Color.White;
		((Control)Button_SORTIES).Cursor = Cursors.Hand;
		((ButtonBase)Button_SORTIES).FlatAppearance.BorderSize = 0;
		componentResourceManager.ApplyResources(Button_SORTIES, "Button_SORTIES");
		((Control)Button_SORTIES).ForeColor = Color.Black;
		((Control)Button_SORTIES).Name = "Button_SORTIES";
		((ButtonBase)Button_SORTIES).UseVisualStyleBackColor = false;
		Button_INVENTAIRE._BackgroundColor = Color.White;
		Button_INVENTAIRE._BorderColor = Color.FromArgb(22, 106, 238);
		Button_INVENTAIRE._BorderRadius = 8;
		Button_INVENTAIRE._BorderSize = 2;
		Button_INVENTAIRE._TextColor = Color.Black;
		((ButtonBase)Button_INVENTAIRE).BackColor = Color.White;
		((Control)Button_INVENTAIRE).Cursor = Cursors.Hand;
		((ButtonBase)Button_INVENTAIRE).FlatAppearance.BorderSize = 0;
		componentResourceManager.ApplyResources(Button_INVENTAIRE, "Button_INVENTAIRE");
		((Control)Button_INVENTAIRE).ForeColor = Color.Black;
		((Control)Button_INVENTAIRE).Name = "Button_INVENTAIRE";
		((ButtonBase)Button_INVENTAIRE).UseVisualStyleBackColor = false;
		Button_RECEPTIONS._BackgroundColor = Color.White;
		Button_RECEPTIONS._BorderColor = Color.FromArgb(22, 106, 238);
		Button_RECEPTIONS._BorderRadius = 8;
		Button_RECEPTIONS._BorderSize = 2;
		Button_RECEPTIONS._TextColor = Color.Black;
		((ButtonBase)Button_RECEPTIONS).BackColor = Color.White;
		((Control)Button_RECEPTIONS).Cursor = Cursors.Hand;
		((ButtonBase)Button_RECEPTIONS).FlatAppearance.BorderSize = 0;
		componentResourceManager.ApplyResources(Button_RECEPTIONS, "Button_RECEPTIONS");
		((Control)Button_RECEPTIONS).ForeColor = Color.Black;
		((Control)Button_RECEPTIONS).Name = "Button_RECEPTIONS";
		((ButtonBase)Button_RECEPTIONS).UseVisualStyleBackColor = false;
		componentResourceManager.ApplyResources(this, "$this");
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Control)this).Controls.Add((Control)(object)TableLayoutPanel1);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Control)this).Name = "Form_8_gestion";
		((Form)this).WindowState = (FormWindowState)2;
		((Control)Panel_FIND).ResumeLayout(false);
		((ISupportInitialize)PictureBox3).EndInit();
		((ISupportInitialize)DataGridView5).EndInit();
		((Control)Panel_INFO).ResumeLayout(false);
		((Control)Panel_INFO).PerformLayout();
		((ISupportInitialize)PictureBox2).EndInit();
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)TableLayoutPanel1).ResumeLayout(false);
		((Control)Panel0).ResumeLayout(false);
		((Control)Panel).ResumeLayout(false);
		((Control)Panel).PerformLayout();
		((ISupportInitialize)PictureBox11).EndInit();
		((ISupportInitialize)PictureBox9).EndInit();
		((ISupportInitialize)PictureBox10).EndInit();
		((ISupportInitialize)PictureBox7).EndInit();
		((ISupportInitialize)PictureBox8).EndInit();
		((ISupportInitialize)PictureBox4).EndInit();
		((ISupportInitialize)PictureBox5).EndInit();
		((ISupportInitialize)PictureBox6).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void Form_Resize(object sender, EventArgs e)
	{
		Panel panel = Panel;
		Point location = checked(new Point((int)Math.Round((double)((Control)this).Width / 2.0 - (double)((Control)Panel).Width / 2.0), (int)Math.Round((double)((Control)this).Height / 2.0 - (double)((Control)Panel).Height / 2.0)));
		((Control)panel).Location = location;
	}

	private void Form_8_gestion_Load(object sender, EventArgs e)
	{
		if (Conversions.ToBoolean(MyProject.Forms.Form_0_TEMPLATE.TextBox_MODE_WINDOWS.Text))
		{
			((ButtonBase)Button244).Image = MyProject.Forms.Form_0_TEMPLATE.PictureBox_SORTIE.Image;
		}
		((Control)TableLayoutPanel1).Dock = (DockStyle)5;
	}

	private void Button244_Click(object sender, EventArgs e)
	{
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected Obj, but got Unknown
		try
		{
			((Form)MyProject.Forms.Form_1_LOGIN).Close();
			((Form)MyProject.Forms.Form_1_LOGIN).TopLevel = false;
			((Control)MyProject.Forms.Form_0_TEMPLATE.Panel_HOME).Controls.Clear();
			((Control)MyProject.Forms.Form_0_TEMPLATE.Panel_HOME).Controls.Add((Control)(object)MyProject.Forms.Form_1_LOGIN);
			((Control)MyProject.Forms.Form_1_LOGIN).Show();
			((Control)MyProject.Forms.Form_1_LOGIN.Panel_menu).BringToFront();
			((Control)MyProject.Forms.Form_1_LOGIN.Panel_menu).Show();
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

	private void Button_COMMANDES_Click(object sender, EventArgs e)
	{
		((Control)MyProject.Forms.Form_6_COMMANDES).Show();
		((Control)MyProject.Forms.Form_6_COMMANDES).BringToFront();
		((Form)MyProject.Forms.Form_6_COMMANDES).WindowState = (FormWindowState)0;
		((Form)MyProject.Forms.Form_6_COMMANDES).WindowState = (FormWindowState)2;
	}

	private void Button_RECEPTIONS_Click(object sender, EventArgs e)
	{
		((Control)MyProject.Forms.Form_6_RECEPTIONS).Show();
		((Control)MyProject.Forms.Form_6_RECEPTIONS).BringToFront();
		((Form)MyProject.Forms.Form_6_RECEPTIONS).WindowState = (FormWindowState)0;
		((Form)MyProject.Forms.Form_6_RECEPTIONS).WindowState = (FormWindowState)2;
	}

	private void Button_SORTIES_Click(object sender, EventArgs e)
	{
		((Control)MyProject.Forms.Form_6_SORTIES).Show();
		((Control)MyProject.Forms.Form_6_SORTIES).BringToFront();
		((Form)MyProject.Forms.Form_6_SORTIES).WindowState = (FormWindowState)0;
		((Form)MyProject.Forms.Form_6_SORTIES).WindowState = (FormWindowState)2;
	}

	private void Button_INVENTAIRE_Click(object sender, EventArgs e)
	{
		((Control)MyProject.Forms.Form_6_INVENTAIRES).Show();
		((Control)MyProject.Forms.Form_6_INVENTAIRES).BringToFront();
		((Form)MyProject.Forms.Form_6_INVENTAIRES).WindowState = (FormWindowState)0;
		((Form)MyProject.Forms.Form_6_INVENTAIRES).WindowState = (FormWindowState)2;
	}

	private void Button_MOUVEMENTS_Click(object sender, EventArgs e)
	{
		((Control)MyProject.Forms.Form_6_MOUVEMENTS_STOCK).Show();
		((Control)MyProject.Forms.Form_6_MOUVEMENTS_STOCK).BringToFront();
		((Form)MyProject.Forms.Form_6_MOUVEMENTS_STOCK).WindowState = (FormWindowState)0;
		((Form)MyProject.Forms.Form_6_MOUVEMENTS_STOCK).WindowState = (FormWindowState)2;
	}

	private void Button_FOURNISSEURS_Click(object sender, EventArgs e)
	{
		((Control)MyProject.Forms.Form_6_FOURNISSEURS).Show();
		((Control)MyProject.Forms.Form_6_FOURNISSEURS).BringToFront();
		((Form)MyProject.Forms.Form_6_FOURNISSEURS).WindowState = (FormWindowState)0;
		((Form)MyProject.Forms.Form_6_FOURNISSEURS).WindowState = (FormWindowState)2;
	}

	private void Button_FOURNISSEURS_REGLEMENTS_Click(object sender, EventArgs e)
	{
		((Control)MyProject.Forms.Form_6_FOURNISSEURS_REGLE).Show();
		((Control)MyProject.Forms.Form_6_FOURNISSEURS_REGLE).BringToFront();
		((Form)MyProject.Forms.Form_6_FOURNISSEURS_REGLE).WindowState = (FormWindowState)0;
		((Form)MyProject.Forms.Form_6_FOURNISSEURS_REGLE).WindowState = (FormWindowState)2;
	}

	private void Button_ETAT_CREDIT_FOURNISSEURS_Click(object sender, EventArgs e)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		((Component)(object)MyProject.Forms.Form_6_FOURNISSEURS_ETAT_CREDITS).Dispose();
		((Form)MyProject.Forms.Form_6_FOURNISSEURS_ETAT_CREDITS).ShowDialog();
	}

	private void Button_CLIENTS_Click(object sender, EventArgs e)
	{
		((Control)MyProject.Forms.Form_5_CLIENTS).Show();
		((Control)MyProject.Forms.Form_5_CLIENTS).BringToFront();
		((Form)MyProject.Forms.Form_5_CLIENTS).WindowState = (FormWindowState)0;
		((Form)MyProject.Forms.Form_5_CLIENTS).WindowState = (FormWindowState)2;
	}

	private void Button_CLIENTS_REGLEMENTS_Click(object sender, EventArgs e)
	{
		((Control)MyProject.Forms.Form_5_CLIENTS_REGLE).Show();
		((Control)MyProject.Forms.Form_5_CLIENTS_REGLE).BringToFront();
		((Form)MyProject.Forms.Form_5_CLIENTS_REGLE).WindowState = (FormWindowState)0;
		((Form)MyProject.Forms.Form_5_CLIENTS_REGLE).WindowState = (FormWindowState)2;
	}

	private void Button_ETAT_CREDIT_CLIENTS_Click(object sender, EventArgs e)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		((Component)(object)MyProject.Forms.Form_5_CLIENTS_ETAT_CREDITS).Dispose();
		((Form)MyProject.Forms.Form_5_CLIENTS_ETAT_CREDITS).ShowDialog();
	}

	private void Button_DEPENSES_Click(object sender, EventArgs e)
	{
		((Control)MyProject.Forms.Form_6_DEPENSES).Show();
		((Control)MyProject.Forms.Form_6_DEPENSES).BringToFront();
		((Form)MyProject.Forms.Form_6_DEPENSES).WindowState = (FormWindowState)0;
		((Form)MyProject.Forms.Form_6_DEPENSES).WindowState = (FormWindowState)2;
	}

	private void Button_RENDEZ_VOUS_Click(object sender, EventArgs e)
	{
		((Control)MyProject.Forms.Form_5_CLIENTS_RDV).Show();
		((Control)MyProject.Forms.Form_5_CLIENTS_RDV).BringToFront();
		((Form)MyProject.Forms.Form_5_CLIENTS_RDV).WindowState = (FormWindowState)0;
		((Form)MyProject.Forms.Form_5_CLIENTS_RDV).WindowState = (FormWindowState)2;
	}

	private void Button_NOMENCLATURE_Click(object sender, EventArgs e)
	{
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected Obj, but got Unknown
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected Obj, but got Unknown
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected Obj, but got Unknown
		//IL_0321: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Expected Obj, but got Unknown
		//IL_047a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0480: Expected Obj, but got Unknown
		//IL_0595: Unknown result type (might be due to invalid IL or missing references)
		//IL_059f: Expected Obj, but got Unknown
		//IL_07e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ec: Expected Obj, but got Unknown
		//IL_0808: Unknown result type (might be due to invalid IL or missing references)
		//IL_0812: Expected Obj, but got Unknown
		//IL_082e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0838: Expected Obj, but got Unknown
		//IL_0854: Unknown result type (might be due to invalid IL or missing references)
		//IL_085e: Expected Obj, but got Unknown
		//IL_087a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0884: Expected Obj, but got Unknown
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
				DataGridView5.Rows.Clear();
				DataTable dataTable = new DataTable();
				MySqlDataAdapter val = new MySqlDataAdapter();
				dataTable.Clear();
				val = new MySqlDataAdapter("select   sum(Total_NET) as n    from   TABLE_VENTES_JOURNAL         WHERE         Dates   between   ' " + Strings.Format(DateTime1_FIND.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTime2_FIND.Value, "yyyy-MM-dd") + " '              ", Module1.cn_SQL);
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
					DataGridView5.Rows.Add(new object[5]
					{
						"TICKET",
						"-",
						"-",
						dataTable.Rows[num2]["n"].ToString(),
						"0"
					});
					num2++;
				}
				dataTable.Clear();
				val = new MySqlDataAdapter("select    *     from   TABLE_DEVIS_ENTETE         WHERE         Dates   between   ' " + Strings.Format(DateTime1_FIND.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTime2_FIND.Value, "yyyy-MM-dd") + " '              ", Module1.cn_SQL);
				((DbDataAdapter)(object)val).Fill(dataTable);
				int num5 = dataTable.Rows.Count - 1;
				int num6 = 0;
				while (true)
				{
					int num7 = num6;
					int num4 = num5;
					if (num7 > num4)
					{
						break;
					}
					DataGridView5.Rows.Add(new object[5]
					{
						"DEVIS",
						dataTable.Rows[num6]["N_DEVIS"].ToString(),
						dataTable.Rows[num6]["CLIENT"].ToString(),
						dataTable.Rows[num6]["TOTAL_TTC_DOC"].ToString(),
						dataTable.Rows[num6]["TOTAL_HT_DOC"].ToString()
					});
					num6++;
				}
				dataTable.Clear();
				val = new MySqlDataAdapter("select    *     from   TABLE_BL_ENTETE         WHERE        Dates   between   ' " + Strings.Format(DateTime1_FIND.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTime2_FIND.Value, "yyyy-MM-dd") + " '            ", Module1.cn_SQL);
				((DbDataAdapter)(object)val).Fill(dataTable);
				int num8 = dataTable.Rows.Count - 1;
				int num9 = 0;
				while (true)
				{
					int num10 = num9;
					int num4 = num8;
					if (num10 > num4)
					{
						break;
					}
					DataGridView5.Rows.Add(new object[5]
					{
						"BL",
						dataTable.Rows[num9]["N_BL"].ToString(),
						dataTable.Rows[num9]["CLIENT"].ToString(),
						dataTable.Rows[num9]["TOTAL_TTC_DOC"].ToString(),
						dataTable.Rows[num9]["TOTAL_HT_DOC"].ToString()
					});
					num9++;
				}
				dataTable.Clear();
				val = new MySqlDataAdapter("select    *     from   TABLE_FACTURE_ENTETE         WHERE        Dates   between   ' " + Strings.Format(DateTime1_FIND.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTime2_FIND.Value, "yyyy-MM-dd") + " '            ", Module1.cn_SQL);
				((DbDataAdapter)(object)val).Fill(dataTable);
				int num11 = dataTable.Rows.Count - 1;
				int num12 = 0;
				while (true)
				{
					int num13 = num12;
					int num4 = num11;
					if (num13 > num4)
					{
						break;
					}
					DataGridView5.Rows.Add(new object[5]
					{
						"FACTURE",
						dataTable.Rows[num12]["N_FACTURE"].ToString(),
						dataTable.Rows[num12]["CLIENT"].ToString(),
						dataTable.Rows[num12]["TOTAL_TTC_DOC"].ToString(),
						dataTable.Rows[num12]["TOTAL_HT_DOC"].ToString()
					});
					num12++;
				}
				((Report)MyProject.Forms.Report_RAPPORT_IMPRESSION.ReportViewer1.LocalReport).SetParameters(new ReportParameter("DATES", DateTime1_FIND.Text + "-->" + DateTime2_FIND.Text));
				if (DataGridView5.RowCount != 0)
				{
					string text = "";
					string text2 = "";
					string text3 = "";
					string text4 = "";
					string text5 = "";
					int num14 = DataGridView5.RowCount - 1;
					int num15 = 0;
					while (true)
					{
						int num16 = num15;
						int num4 = num14;
						if (num16 > num4)
						{
							break;
						}
						text = text + DataGridView5.Rows[num15].Cells["DOCUMENT"].Value.ToString().ToUpper() + Environment.NewLine + Environment.NewLine;
						text2 = text2 + DataGridView5.Rows[num15].Cells["N_DOC"].Value.ToString().ToUpper() + Environment.NewLine + Environment.NewLine;
						text3 = text3 + Strings.Mid(DataGridView5.Rows[num15].Cells["CLIENT"].Value.ToString().ToUpper(), 1, 20) + Environment.NewLine + Environment.NewLine;
						text4 = text4 + Strings.FormatNumber(DataGridView5.Rows[num15].Cells["TOTAL_TTC"].Value.ToString()) + Environment.NewLine + Environment.NewLine;
						text5 = text5 + Strings.FormatNumber(DataGridView5.Rows[num15].Cells["TOTAL_HT"].Value.ToString()) + Environment.NewLine + Environment.NewLine;
						num15++;
					}
					text = text.Remove(text.Length - 4);
					text2 = text2.Remove(text2.Length - 4);
					text3 = text3.Remove(text3.Length - 4);
					text4 = text4.Remove(text4.Length - 4);
					text5 = text5.Remove(text5.Length - 4);
					((Report)MyProject.Forms.Report_RAPPORT_IMPRESSION.ReportViewer1.LocalReport).SetParameters(new ReportParameter("DOCUMENT", text));
					((Report)MyProject.Forms.Report_RAPPORT_IMPRESSION.ReportViewer1.LocalReport).SetParameters(new ReportParameter("N_DOC", text2));
					((Report)MyProject.Forms.Report_RAPPORT_IMPRESSION.ReportViewer1.LocalReport).SetParameters(new ReportParameter("CLIENT", text3));
					((Report)MyProject.Forms.Report_RAPPORT_IMPRESSION.ReportViewer1.LocalReport).SetParameters(new ReportParameter("TOTAL_TTC", text4));
					((Report)MyProject.Forms.Report_RAPPORT_IMPRESSION.ReportViewer1.LocalReport).SetParameters(new ReportParameter("TOTAL_HT", text5));
				}
				MyProject.Forms.Report_RAPPORT_IMPRESSION.ReportViewer1.RefreshReport();
				MyProject.Forms.Report_RAPPORT_IMPRESSION.ReportViewer1.SetDisplayMode((DisplayMode)1);
				MyProject.Forms.Report_RAPPORT_IMPRESSION.ReportViewer1.ZoomMode = (ZoomMode)2;
				MyProject.Forms.Report_RAPPORT_IMPRESSION.ReportViewer1.ZoomPercent = 25;
				((Control)MyProject.Forms.Report_RAPPORT_IMPRESSION).Show();
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

	private void Panel_Paint(object sender, PaintEventArgs e)
	{
	}

	private void Panel_DoubleClick(object sender, EventArgs e)
	{
		((Control)Panel_FIND).Visible = true;
		((Control)Panel_INFO).Visible = true;
		((Control)Button2).Visible = true;
	}

	private void Button_DEVIS_Click(object sender, EventArgs e)
	{
		((Control)MyProject.Forms.Form_900_DEVIS).Show();
		((Control)MyProject.Forms.Form_900_DEVIS).BringToFront();
		((Form)MyProject.Forms.Form_900_DEVIS).WindowState = (FormWindowState)0;
		((Form)MyProject.Forms.Form_900_DEVIS).WindowState = (FormWindowState)2;
	}

	private void Button_BL_Click(object sender, EventArgs e)
	{
		((Control)MyProject.Forms.Form_9000_BL).Show();
		((Control)MyProject.Forms.Form_9000_BL).BringToFront();
		((Form)MyProject.Forms.Form_9000_BL).WindowState = (FormWindowState)0;
		((Form)MyProject.Forms.Form_9000_BL).WindowState = (FormWindowState)2;
	}

	private void Button_FACTURES_Click(object sender, EventArgs e)
	{
		((Control)MyProject.Forms.Form_90000_FACTURE).Show();
		((Control)MyProject.Forms.Form_90000_FACTURE).BringToFront();
		((Form)MyProject.Forms.Form_90000_FACTURE).WindowState = (FormWindowState)0;
		((Form)MyProject.Forms.Form_90000_FACTURE).WindowState = (FormWindowState)2;
	}
}
