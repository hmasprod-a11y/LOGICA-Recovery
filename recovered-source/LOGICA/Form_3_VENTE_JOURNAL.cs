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
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Bunifu.UI.WinForms;
using ClosedXML.Excel;
using CustomControls.RJControls;
using LOGICA.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace LOGICA;

[DesignerGenerated]
public class Form_3_VENTE_JOURNAL : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	[AccessedThroughProperty("DataGridView2")]
	private DataGridView _DataGridView2;

	[AccessedThroughProperty("Label_TABLE")]
	private Label _Label_TABLE;

	[AccessedThroughProperty("DataGridView1")]
	private DataGridView _DataGridView1;

	[AccessedThroughProperty("Panel8")]
	private Panel _Panel8;

	[AccessedThroughProperty("DateTimePicker1")]
	private DateTimePicker _DateTimePicker1;

	[AccessedThroughProperty("DateTimePicker2")]
	private DateTimePicker _DateTimePicker2;

	[AccessedThroughProperty("Button244")]
	private Button _Button244;

	[AccessedThroughProperty("Print_Recette_Globale")]
	private PrintDocument _Print_Recette_Globale;

	[AccessedThroughProperty("Print_Recette_vendeur")]
	private PrintDocument _Print_Recette_vendeur;

	[AccessedThroughProperty("Button_OK")]
	private Button _Button_OK;

	[AccessedThroughProperty("Button_TOTAL_GLOBALE")]
	private Button _Button_TOTAL_GLOBALE;

	[AccessedThroughProperty("Label_TOTAL_NET")]
	private Label _Label_TOTAL_NET;

	[AccessedThroughProperty("Button_PrintRapport")]
	private Button _Button_PrintRapport;

	[AccessedThroughProperty("Button_ConsRapport")]
	private Button _Button_ConsRapport;

	[AccessedThroughProperty("Label_FAMILLES")]
	private Label _Label_FAMILLES;

	[AccessedThroughProperty("Label_VENDEURS")]
	private Label _Label_VENDEURS;

	[AccessedThroughProperty("Button_ConsVendeur")]
	private Button _Button_ConsVendeur;

	[AccessedThroughProperty("Button_PrintVendeur")]
	private Button _Button_PrintVendeur;

	[AccessedThroughProperty("Button14")]
	private Button _Button14;

	[AccessedThroughProperty("Button20")]
	private Button _Button20;

	[AccessedThroughProperty("Button5")]
	private Button _Button5;

	[AccessedThroughProperty("Print_Recette_vendeurGLOBALE")]
	private PrintDocument _Print_Recette_vendeurGLOBALE;

	[AccessedThroughProperty("Button_ConsGlobaleVendeur")]
	private Button _Button_ConsGlobaleVendeur;

	[AccessedThroughProperty("Panel4")]
	private Panel _Panel4;

	[AccessedThroughProperty("Print_Recette_Famille")]
	private PrintDocument _Print_Recette_Famille;

	[AccessedThroughProperty("Button_PrintFamille")]
	private Button _Button_PrintFamille;

	[AccessedThroughProperty("Button_ConsFamille")]
	private Button _Button_ConsFamille;

	[AccessedThroughProperty("TabControlEx1")]
	private TabControlEx _TabControlEx1;

	[AccessedThroughProperty("TabPage1")]
	private TabPage _TabPage1;

	[AccessedThroughProperty("TabPage2")]
	private TabPage _TabPage2;

	[AccessedThroughProperty("TabPage3")]
	private TabPage _TabPage3;

	[AccessedThroughProperty("TabPage5")]
	private TabPage _TabPage5;

	[AccessedThroughProperty("Button_MAIL_GLOBALE")]
	private Button _Button_MAIL_GLOBALE;

	[AccessedThroughProperty("Label_CAISSIER")]
	private Label _Label_CAISSIER;

	[AccessedThroughProperty("Button_ConsGlobaleCaissier")]
	private Button _Button_ConsGlobaleCaissier;

	[AccessedThroughProperty("Button_PrintCaissier")]
	private Button _Button_PrintCaissier;

	[AccessedThroughProperty("Button_ConsCaissier")]
	private Button _Button_ConsCaissier;

	[AccessedThroughProperty("Print_Recette_caissier")]
	private PrintDocument _Print_Recette_caissier;

	[AccessedThroughProperty("Print_Recette_caissierGLOBALE")]
	private PrintDocument _Print_Recette_caissierGLOBALE;

	[AccessedThroughProperty("Button_MAIL_CAISSIER")]
	private Button _Button_MAIL_CAISSIER;

	[AccessedThroughProperty("Timer1")]
	private System.Windows.Forms.Timer _Timer1;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[AccessedThroughProperty("Button4")]
	private Button _Button4;

	[AccessedThroughProperty("Button_ConsGlobaleFamille")]
	private Button _Button_ConsGlobaleFamille;

	[AccessedThroughProperty("Print_Recette_familleGLOBALE")]
	private PrintDocument _Print_Recette_familleGLOBALE;

	[AccessedThroughProperty("Button13")]
	private Button _Button13;

	[AccessedThroughProperty("COL_1")]
	private DataGridViewTextBoxColumn _COL_1;

	[AccessedThroughProperty("COL_2")]
	private DataGridViewTextBoxColumn _COL_2;

	[AccessedThroughProperty("COL_3")]
	private DataGridViewTextBoxColumn _COL_3;

	[AccessedThroughProperty("TabPage4")]
	private TabPage _TabPage4;

	[AccessedThroughProperty("Print_Recette_Client")]
	private PrintDocument _Print_Recette_Client;

	[AccessedThroughProperty("Print_Recette_clientGLOBALE")]
	private PrintDocument _Print_Recette_clientGLOBALE;

	[AccessedThroughProperty("Button_ConsGlobaleClients")]
	private Button _Button_ConsGlobaleClients;

	[AccessedThroughProperty("Button_PrintClients")]
	private Button _Button_PrintClients;

	[AccessedThroughProperty("Button_ConsClients")]
	private Button _Button_ConsClients;

	[AccessedThroughProperty("Label_CLIENTS")]
	private Label _Label_CLIENTS;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Label27")]
	private Label _Label27;

	[AccessedThroughProperty("Label28")]
	private Label _Label28;

	[AccessedThroughProperty("Label29")]
	private Label _Label29;

	[AccessedThroughProperty("Label30")]
	private Label _Label30;

	[AccessedThroughProperty("Label9")]
	private Label _Label9;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Label10")]
	private Label _Label10;

	[AccessedThroughProperty("Label11")]
	private Label _Label11;

	[AccessedThroughProperty("Label12")]
	private Label _Label12;

	[AccessedThroughProperty("TableLayoutPanel1")]
	private TableLayoutPanel _TableLayoutPanel1;

	[AccessedThroughProperty("Panel00")]
	private Panel _Panel00;

	[AccessedThroughProperty("Panel0")]
	private Panel _Panel0;

	[AccessedThroughProperty("ListBox_CAISSIERS")]
	private ListBox _ListBox_CAISSIERS;

	[AccessedThroughProperty("ListBox_RAPPORT_GLOBALE")]
	private ListBox _ListBox_RAPPORT_GLOBALE;

	[AccessedThroughProperty("Button_TOTAL_CAISSIER")]
	private Button _Button_TOTAL_CAISSIER;

	[AccessedThroughProperty("ListBox_VENDEURS")]
	private ListBox _ListBox_VENDEURS;

	[AccessedThroughProperty("ListBox_FAMILLES")]
	private ListBox _ListBox_FAMILLES;

	[AccessedThroughProperty("ListBox_CLIENTS")]
	private ListBox _ListBox_CLIENTS;

	[AccessedThroughProperty("Button_TOTAL_VENDEUR")]
	private Button _Button_TOTAL_VENDEUR;

	[AccessedThroughProperty("Button_TOTAL_FAMILLE")]
	private Button _Button_TOTAL_FAMILLE;

	[AccessedThroughProperty("Button_TOTAL_CLIENT")]
	private Button _Button_TOTAL_CLIENT;

	[AccessedThroughProperty("DataGridView3")]
	private DataGridView _DataGridView3;

	[AccessedThroughProperty("DataGridViewTextBoxColumn1")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn1;

	[AccessedThroughProperty("Button6")]
	private Button _Button6;

	[AccessedThroughProperty("Label4141")]
	private Label _Label4141;

	[AccessedThroughProperty("Label18")]
	private Label _Label18;

	[AccessedThroughProperty("Label19")]
	private Label _Label19;

	[AccessedThroughProperty("Label20")]
	private Label _Label20;

	[AccessedThroughProperty("Label21")]
	private Label _Label21;

	[AccessedThroughProperty("Label22")]
	private Label _Label22;

	[AccessedThroughProperty("Panel_CLOTURE")]
	private Panel _Panel_CLOTURE;

	[AccessedThroughProperty("Ticket")]
	private DataGridViewTextBoxColumn _Ticket;

	[AccessedThroughProperty("Dates")]
	private DataGridViewTextBoxColumn _Dates;

	[AccessedThroughProperty("Heure")]
	private DataGridViewTextBoxColumn _Heure;

	[AccessedThroughProperty("Article")]
	private DataGridViewTextBoxColumn _Article;

	[AccessedThroughProperty("PRIX_V")]
	private DataGridViewTextBoxColumn _PRIX_V;

	[AccessedThroughProperty("Qté")]
	private DataGridViewTextBoxColumn _Qté;

	[AccessedThroughProperty("Remise")]
	private DataGridViewTextBoxColumn _Remise;

	[AccessedThroughProperty("Total_NET")]
	private DataGridViewTextBoxColumn _Total_NET;

	[AccessedThroughProperty("Caissier")]
	private DataGridViewTextBoxColumn _Caissier;

	[AccessedThroughProperty("Vendeur")]
	private DataGridViewTextBoxColumn _Vendeur;

	[AccessedThroughProperty("CLIENT")]
	private DataGridViewTextBoxColumn _CLIENT;

	[AccessedThroughProperty("OPERATION")]
	private DataGridViewTextBoxColumn _OPERATION;

	[AccessedThroughProperty("Print_Recette_Jours")]
	private PrintDocument _Print_Recette_Jours;

	[AccessedThroughProperty("Button_ConsJOURS")]
	private Button _Button_ConsJOURS;

	[AccessedThroughProperty("Panel_FIND")]
	private Panel _Panel_FIND;

	[AccessedThroughProperty("Panel_DATES")]
	private Panel _Panel_DATES;

	[AccessedThroughProperty("DateTime2_FIND")]
	private DateTimePicker _DateTime2_FIND;

	[AccessedThroughProperty("DateTime1_FIND")]
	private DateTimePicker _DateTime1_FIND;

	[AccessedThroughProperty("Picture_FIND_DATES")]
	private PictureBox _Picture_FIND_DATES;

	[AccessedThroughProperty("PictureBox13")]
	private PictureBox _PictureBox13;

	[AccessedThroughProperty("Combo_FIND")]
	private BunifuDropdown _Combo_FIND;

	[AccessedThroughProperty("Picture_EXPORT")]
	private Button_RJ _Picture_EXPORT;

	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("Check_FIND_DATE")]
	private BunifuCheckBox _Check_FIND_DATE;

	[AccessedThroughProperty("Check_FIND_EXACTE")]
	private BunifuCheckBox _Check_FIND_EXACTE;

	[AccessedThroughProperty("Picture_REFRESH")]
	private Button_RJ _Picture_REFRESH;

	[AccessedThroughProperty("Picture_FIND")]
	private Button_RJ _Picture_FIND;

	[AccessedThroughProperty("Text_FIND")]
	private RJTextBox _Text_FIND;

	[AccessedThroughProperty("Panel_COLUMNS")]
	private Panel _Panel_COLUMNS;

	[AccessedThroughProperty("Button94545")]
	private Button _Button94545;

	[AccessedThroughProperty("Button187878")]
	private Button _Button187878;

	[AccessedThroughProperty("Label47")]
	private Label _Label47;

	[AccessedThroughProperty("Label48")]
	private Label _Label48;

	[AccessedThroughProperty("Label49")]
	private Label _Label49;

	[AccessedThroughProperty("Label51")]
	private Label _Label51;

	[AccessedThroughProperty("ListBox_COLUMNS")]
	private ListBox _ListBox_COLUMNS;

	[AccessedThroughProperty("Text_PRINTER_RAPPORT")]
	private TextBox _Text_PRINTER_RAPPORT;

	[AccessedThroughProperty("Text_mail")]
	private TextBox _Text_mail;

	[AccessedThroughProperty("Text_MAIL_TITRE")]
	private TextBox _Text_MAIL_TITRE;

	[AccessedThroughProperty("Button_MARGE")]
	private Button _Button_MARGE;

	private MySqlDataAdapter DA;

	private DataTable DT;

	public const string eClear = "\u001b@";

	public const string eCentre = "\u001ba1";

	public const string eLeft = "\u001ba0";

	public const string eRight = "\u001ba2";

	public const string eDrawer = "\u001b@\u001bp\0.}";

	public const string eCut = "\u001bi\r\n";

	public const string eSmlText = "\u001b!\u0001";

	public const string eNmlText = "\u001b!\0";

	public const string eInit = "\u001b!\0\r\u001bc6\u0001\u001bR3\r\n";

	public const string eBigCharOn = "\u001b!8";

	public const string eBigCharOff = "\u001b!\0";

	private RawPrinterHelper prn;

	private string PrintBuffer;

	private object _sql;

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
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected Obj, but got Unknown
			DataGridViewCellEventHandler val = DataGridView1_CellContentClick;
			DataGridViewBindingCompleteEventHandler val2 = DataGridView1_DataBindingComplete;
			DataGridViewCellMouseEventHandler val3 = DataGridView1_ColumnHeaderMouseDoubleClick;
			if (_DataGridView1 != null)
			{
				_DataGridView1.CellContentClick -= val;
				_DataGridView1.DataBindingComplete -= val2;
				_DataGridView1.ColumnHeaderMouseDoubleClick -= val3;
			}
			_DataGridView1 = value;
			if (_DataGridView1 != null)
			{
				_DataGridView1.CellContentClick += val;
				_DataGridView1.DataBindingComplete += val2;
				_DataGridView1.ColumnHeaderMouseDoubleClick += val3;
			}
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
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			PaintEventHandler val = Panel8_Paint;
			if (_Panel8 != null)
			{
				((Control)_Panel8).Paint -= val;
			}
			_Panel8 = value;
			if (_Panel8 != null)
			{
				((Control)_Panel8).Paint += val;
			}
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

	internal virtual PrintDocument Print_Recette_Globale
	{
		[DebuggerNonUserCode]
		get
		{
			return _Print_Recette_Globale;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			PrintPageEventHandler val = Print_Recette_Globale_PrintPage;
			if (_Print_Recette_Globale != null)
			{
				_Print_Recette_Globale.PrintPage -= val;
			}
			_Print_Recette_Globale = value;
			if (_Print_Recette_Globale != null)
			{
				_Print_Recette_Globale.PrintPage += val;
			}
		}
	}

	internal virtual PrintDocument Print_Recette_vendeur
	{
		[DebuggerNonUserCode]
		get
		{
			return _Print_Recette_vendeur;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			PrintPageEventHandler val = Print_Recette_vendeur_PrintPage;
			if (_Print_Recette_vendeur != null)
			{
				_Print_Recette_vendeur.PrintPage -= val;
			}
			_Print_Recette_vendeur = value;
			if (_Print_Recette_vendeur != null)
			{
				_Print_Recette_vendeur.PrintPage += val;
			}
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

	internal virtual Button Button_TOTAL_GLOBALE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_TOTAL_GLOBALE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_TOTAL_GLOBALE_Click;
			if (_Button_TOTAL_GLOBALE != null)
			{
				((Control)_Button_TOTAL_GLOBALE).Click -= eventHandler;
			}
			_Button_TOTAL_GLOBALE = value;
			if (_Button_TOTAL_GLOBALE != null)
			{
				((Control)_Button_TOTAL_GLOBALE).Click += eventHandler;
			}
		}
	}

	internal virtual Label Label_TOTAL_NET
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_TOTAL_NET;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_TOTAL_NET = value;
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

	internal virtual Label Label_FAMILLES
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_FAMILLES;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_FAMILLES = value;
		}
	}

	internal virtual Label Label_VENDEURS
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_VENDEURS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_VENDEURS = value;
		}
	}

	internal virtual Button Button_ConsVendeur
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_ConsVendeur;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_Click;
			if (_Button_ConsVendeur != null)
			{
				((Control)_Button_ConsVendeur).Click -= eventHandler;
			}
			_Button_ConsVendeur = value;
			if (_Button_ConsVendeur != null)
			{
				((Control)_Button_ConsVendeur).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button_PrintVendeur
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_PrintVendeur;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_Click;
			if (_Button_PrintVendeur != null)
			{
				((Control)_Button_PrintVendeur).Click -= eventHandler;
			}
			_Button_PrintVendeur = value;
			if (_Button_PrintVendeur != null)
			{
				((Control)_Button_PrintVendeur).Click += eventHandler;
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

	internal virtual PrintDocument Print_Recette_vendeurGLOBALE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Print_Recette_vendeurGLOBALE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			PrintPageEventHandler val = Print_Recette_vendeurGLOBALE_PrintPage;
			if (_Print_Recette_vendeurGLOBALE != null)
			{
				_Print_Recette_vendeurGLOBALE.PrintPage -= val;
			}
			_Print_Recette_vendeurGLOBALE = value;
			if (_Print_Recette_vendeurGLOBALE != null)
			{
				_Print_Recette_vendeurGLOBALE.PrintPage += val;
			}
		}
	}

	internal virtual Button Button_ConsGlobaleVendeur
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_ConsGlobaleVendeur;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_ConsGlobaleVendeur_Click;
			if (_Button_ConsGlobaleVendeur != null)
			{
				((Control)_Button_ConsGlobaleVendeur).Click -= eventHandler;
			}
			_Button_ConsGlobaleVendeur = value;
			if (_Button_ConsGlobaleVendeur != null)
			{
				((Control)_Button_ConsGlobaleVendeur).Click += eventHandler;
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

	internal virtual PrintDocument Print_Recette_Famille
	{
		[DebuggerNonUserCode]
		get
		{
			return _Print_Recette_Famille;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			PrintPageEventHandler val = Print_Recette_Famille_PrintPage;
			if (_Print_Recette_Famille != null)
			{
				_Print_Recette_Famille.PrintPage -= val;
			}
			_Print_Recette_Famille = value;
			if (_Print_Recette_Famille != null)
			{
				_Print_Recette_Famille.PrintPage += val;
			}
		}
	}

	internal virtual Button Button_PrintFamille
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_PrintFamille;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_ConsFamille_Click;
			if (_Button_PrintFamille != null)
			{
				((Control)_Button_PrintFamille).Click -= eventHandler;
			}
			_Button_PrintFamille = value;
			if (_Button_PrintFamille != null)
			{
				((Control)_Button_PrintFamille).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button_ConsFamille
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_ConsFamille;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_ConsFamille_Click;
			if (_Button_ConsFamille != null)
			{
				((Control)_Button_ConsFamille).Click -= eventHandler;
			}
			_Button_ConsFamille = value;
			if (_Button_ConsFamille != null)
			{
				((Control)_Button_ConsFamille).Click += eventHandler;
			}
		}
	}

	internal virtual TabControlEx TabControlEx1
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabControlEx1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabControlEx1 = value;
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

	internal virtual TabPage TabPage2
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabPage2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabPage2 = value;
		}
	}

	internal virtual TabPage TabPage3
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabPage3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabPage3 = value;
		}
	}

	internal virtual TabPage TabPage5
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabPage5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabPage5 = value;
		}
	}

	internal virtual Button Button_MAIL_GLOBALE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_MAIL_GLOBALE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_MAIL_GLOBALE_Click;
			if (_Button_MAIL_GLOBALE != null)
			{
				((Control)_Button_MAIL_GLOBALE).Click -= eventHandler;
			}
			_Button_MAIL_GLOBALE = value;
			if (_Button_MAIL_GLOBALE != null)
			{
				((Control)_Button_MAIL_GLOBALE).Click += eventHandler;
			}
		}
	}

	internal virtual Label Label_CAISSIER
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_CAISSIER;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_CAISSIER = value;
		}
	}

	internal virtual Button Button_ConsGlobaleCaissier
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_ConsGlobaleCaissier;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_ConsGlobaleCaissier_Click;
			if (_Button_ConsGlobaleCaissier != null)
			{
				((Control)_Button_ConsGlobaleCaissier).Click -= eventHandler;
			}
			_Button_ConsGlobaleCaissier = value;
			if (_Button_ConsGlobaleCaissier != null)
			{
				((Control)_Button_ConsGlobaleCaissier).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button_PrintCaissier
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_PrintCaissier;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button12_Click;
			if (_Button_PrintCaissier != null)
			{
				((Control)_Button_PrintCaissier).Click -= eventHandler;
			}
			_Button_PrintCaissier = value;
			if (_Button_PrintCaissier != null)
			{
				((Control)_Button_PrintCaissier).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button_ConsCaissier
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_ConsCaissier;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button12_Click;
			if (_Button_ConsCaissier != null)
			{
				((Control)_Button_ConsCaissier).Click -= eventHandler;
			}
			_Button_ConsCaissier = value;
			if (_Button_ConsCaissier != null)
			{
				((Control)_Button_ConsCaissier).Click += eventHandler;
			}
		}
	}

	internal virtual PrintDocument Print_Recette_caissier
	{
		[DebuggerNonUserCode]
		get
		{
			return _Print_Recette_caissier;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			PrintPageEventHandler val = Print_Recette_caissier_PrintPage;
			if (_Print_Recette_caissier != null)
			{
				_Print_Recette_caissier.PrintPage -= val;
			}
			_Print_Recette_caissier = value;
			if (_Print_Recette_caissier != null)
			{
				_Print_Recette_caissier.PrintPage += val;
			}
		}
	}

	internal virtual PrintDocument Print_Recette_caissierGLOBALE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Print_Recette_caissierGLOBALE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			PrintPageEventHandler val = Print_Recette_caissierGLOBALE_PrintPage;
			if (_Print_Recette_caissierGLOBALE != null)
			{
				_Print_Recette_caissierGLOBALE.PrintPage -= val;
			}
			_Print_Recette_caissierGLOBALE = value;
			if (_Print_Recette_caissierGLOBALE != null)
			{
				_Print_Recette_caissierGLOBALE.PrintPage += val;
			}
		}
	}

	internal virtual Button Button_MAIL_CAISSIER
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_MAIL_CAISSIER;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_MAIL_CAISSIER_Click;
			if (_Button_MAIL_CAISSIER != null)
			{
				((Control)_Button_MAIL_CAISSIER).Click -= eventHandler;
			}
			_Button_MAIL_CAISSIER = value;
			if (_Button_MAIL_CAISSIER != null)
			{
				((Control)_Button_MAIL_CAISSIER).Click += eventHandler;
			}
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

	internal virtual Button Button_ConsGlobaleFamille
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_ConsGlobaleFamille;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_ConsGlobaleFamille_click;
			if (_Button_ConsGlobaleFamille != null)
			{
				((Control)_Button_ConsGlobaleFamille).Click -= eventHandler;
			}
			_Button_ConsGlobaleFamille = value;
			if (_Button_ConsGlobaleFamille != null)
			{
				((Control)_Button_ConsGlobaleFamille).Click += eventHandler;
			}
		}
	}

	internal virtual PrintDocument Print_Recette_familleGLOBALE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Print_Recette_familleGLOBALE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			PrintPageEventHandler val = Print_Recette_familleGLOBALE_PrintPage;
			if (_Print_Recette_familleGLOBALE != null)
			{
				_Print_Recette_familleGLOBALE.PrintPage -= val;
			}
			_Print_Recette_familleGLOBALE = value;
			if (_Print_Recette_familleGLOBALE != null)
			{
				_Print_Recette_familleGLOBALE.PrintPage += val;
			}
		}
	}

	internal virtual Button Button13
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button13_Click;
			if (_Button13 != null)
			{
				((Control)_Button13).Click -= eventHandler;
			}
			_Button13 = value;
			if (_Button13 != null)
			{
				((Control)_Button13).Click += eventHandler;
			}
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

	internal virtual TabPage TabPage4
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabPage4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabPage4 = value;
		}
	}

	internal virtual PrintDocument Print_Recette_Client
	{
		[DebuggerNonUserCode]
		get
		{
			return _Print_Recette_Client;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			PrintPageEventHandler val = Print_Recette_Client_PrintPage;
			if (_Print_Recette_Client != null)
			{
				_Print_Recette_Client.PrintPage -= val;
			}
			_Print_Recette_Client = value;
			if (_Print_Recette_Client != null)
			{
				_Print_Recette_Client.PrintPage += val;
			}
		}
	}

	internal virtual PrintDocument Print_Recette_clientGLOBALE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Print_Recette_clientGLOBALE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			PrintPageEventHandler val = Print_Recette_clientGLOBALE_PrintPage;
			if (_Print_Recette_clientGLOBALE != null)
			{
				_Print_Recette_clientGLOBALE.PrintPage -= val;
			}
			_Print_Recette_clientGLOBALE = value;
			if (_Print_Recette_clientGLOBALE != null)
			{
				_Print_Recette_clientGLOBALE.PrintPage += val;
			}
		}
	}

	internal virtual Button Button_ConsGlobaleClients
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_ConsGlobaleClients;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_ConsGlobaleClients_Click;
			if (_Button_ConsGlobaleClients != null)
			{
				((Control)_Button_ConsGlobaleClients).Click -= eventHandler;
			}
			_Button_ConsGlobaleClients = value;
			if (_Button_ConsGlobaleClients != null)
			{
				((Control)_Button_ConsGlobaleClients).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button_PrintClients
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_PrintClients;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_ConsClients_Click;
			if (_Button_PrintClients != null)
			{
				((Control)_Button_PrintClients).Click -= eventHandler;
			}
			_Button_PrintClients = value;
			if (_Button_PrintClients != null)
			{
				((Control)_Button_PrintClients).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button_ConsClients
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_ConsClients;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_ConsClients_Click;
			if (_Button_ConsClients != null)
			{
				((Control)_Button_ConsClients).Click -= eventHandler;
			}
			_Button_ConsClients = value;
			if (_Button_ConsClients != null)
			{
				((Control)_Button_ConsClients).Click += eventHandler;
			}
		}
	}

	internal virtual Label Label_CLIENTS
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_CLIENTS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_CLIENTS = value;
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

	internal virtual Panel Panel00
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel00;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel00 = value;
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

	internal virtual ListBox ListBox_CAISSIERS
	{
		[DebuggerNonUserCode]
		get
		{
			return _ListBox_CAISSIERS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ListBox_CAISSIERS = value;
		}
	}

	internal virtual ListBox ListBox_RAPPORT_GLOBALE
	{
		[DebuggerNonUserCode]
		get
		{
			return _ListBox_RAPPORT_GLOBALE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ListBox_RAPPORT_GLOBALE_SelectedIndexChanged;
			if (_ListBox_RAPPORT_GLOBALE != null)
			{
				_ListBox_RAPPORT_GLOBALE.SelectedIndexChanged -= eventHandler;
			}
			_ListBox_RAPPORT_GLOBALE = value;
			if (_ListBox_RAPPORT_GLOBALE != null)
			{
				_ListBox_RAPPORT_GLOBALE.SelectedIndexChanged += eventHandler;
			}
		}
	}

	internal virtual Button Button_TOTAL_CAISSIER
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_TOTAL_CAISSIER;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_TOTAL_CAISSIER_Click;
			if (_Button_TOTAL_CAISSIER != null)
			{
				((Control)_Button_TOTAL_CAISSIER).Click -= eventHandler;
			}
			_Button_TOTAL_CAISSIER = value;
			if (_Button_TOTAL_CAISSIER != null)
			{
				((Control)_Button_TOTAL_CAISSIER).Click += eventHandler;
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
			_ListBox_VENDEURS = value;
		}
	}

	internal virtual ListBox ListBox_FAMILLES
	{
		[DebuggerNonUserCode]
		get
		{
			return _ListBox_FAMILLES;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ListBox_FAMILLES = value;
		}
	}

	internal virtual ListBox ListBox_CLIENTS
	{
		[DebuggerNonUserCode]
		get
		{
			return _ListBox_CLIENTS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ListBox_CLIENTS = value;
		}
	}

	internal virtual Button Button_TOTAL_VENDEUR
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_TOTAL_VENDEUR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_TOTAL_VENDEUR_Click;
			if (_Button_TOTAL_VENDEUR != null)
			{
				((Control)_Button_TOTAL_VENDEUR).Click -= eventHandler;
			}
			_Button_TOTAL_VENDEUR = value;
			if (_Button_TOTAL_VENDEUR != null)
			{
				((Control)_Button_TOTAL_VENDEUR).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button_TOTAL_FAMILLE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_TOTAL_FAMILLE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_TOTAL_FAMILLE_Click;
			if (_Button_TOTAL_FAMILLE != null)
			{
				((Control)_Button_TOTAL_FAMILLE).Click -= eventHandler;
			}
			_Button_TOTAL_FAMILLE = value;
			if (_Button_TOTAL_FAMILLE != null)
			{
				((Control)_Button_TOTAL_FAMILLE).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button_TOTAL_CLIENT
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_TOTAL_CLIENT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_TOTAL_CLIENT_Click;
			if (_Button_TOTAL_CLIENT != null)
			{
				((Control)_Button_TOTAL_CLIENT).Click -= eventHandler;
			}
			_Button_TOTAL_CLIENT = value;
			if (_Button_TOTAL_CLIENT != null)
			{
				((Control)_Button_TOTAL_CLIENT).Click += eventHandler;
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
			_DataGridView3 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn1
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridViewTextBoxColumn1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGridViewTextBoxColumn1 = value;
		}
	}

	internal virtual Button Button6
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button6_Click;
			if (_Button6 != null)
			{
				((Control)_Button6).Click -= eventHandler;
			}
			_Button6 = value;
			if (_Button6 != null)
			{
				((Control)_Button6).Click += eventHandler;
			}
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

	internal virtual Panel Panel_CLOTURE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel_CLOTURE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel_CLOTURE = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Ticket
	{
		[DebuggerNonUserCode]
		get
		{
			return _Ticket;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Ticket = value;
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

	internal virtual DataGridViewTextBoxColumn Heure
	{
		[DebuggerNonUserCode]
		get
		{
			return _Heure;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Heure = value;
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

	internal virtual DataGridViewTextBoxColumn PRIX_V
	{
		[DebuggerNonUserCode]
		get
		{
			return _PRIX_V;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PRIX_V = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Qté
	{
		[DebuggerNonUserCode]
		get
		{
			return _Qté;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Qté = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Remise
	{
		[DebuggerNonUserCode]
		get
		{
			return _Remise;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Remise = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Total_NET
	{
		[DebuggerNonUserCode]
		get
		{
			return _Total_NET;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Total_NET = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Caissier
	{
		[DebuggerNonUserCode]
		get
		{
			return _Caissier;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Caissier = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Vendeur
	{
		[DebuggerNonUserCode]
		get
		{
			return _Vendeur;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Vendeur = value;
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

	internal virtual DataGridViewTextBoxColumn OPERATION
	{
		[DebuggerNonUserCode]
		get
		{
			return _OPERATION;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_OPERATION = value;
		}
	}

	internal virtual PrintDocument Print_Recette_Jours
	{
		[DebuggerNonUserCode]
		get
		{
			return _Print_Recette_Jours;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			PrintPageEventHandler val = Print_Recette_Jour_PrintPage;
			if (_Print_Recette_Jours != null)
			{
				_Print_Recette_Jours.PrintPage -= val;
			}
			_Print_Recette_Jours = value;
			if (_Print_Recette_Jours != null)
			{
				_Print_Recette_Jours.PrintPage += val;
			}
		}
	}

	internal virtual Button Button_ConsJOURS
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_ConsJOURS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_ConsJOURS_Click;
			if (_Button_ConsJOURS != null)
			{
				((Control)_Button_ConsJOURS).Click -= eventHandler;
			}
			_Button_ConsJOURS = value;
			if (_Button_ConsJOURS != null)
			{
				((Control)_Button_ConsJOURS).Click += eventHandler;
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

	internal virtual BunifuDropdown Combo_FIND
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
				((ComboBox)_Combo_FIND).SelectedIndexChanged -= eventHandler;
			}
			_Combo_FIND = value;
			if (_Combo_FIND != null)
			{
				((ComboBox)_Combo_FIND).SelectedIndexChanged += eventHandler;
			}
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

	internal virtual BunifuCheckBox Check_FIND_DATE
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
			EventHandler<Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs> eventHandler = Check_FIND_DATE_CheckedChanged;
			EventHandler<Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs> eventHandler2 = Check_FIND_DATE_CheckedChanged;
			if (_Check_FIND_DATE != null)
			{
				_Check_FIND_DATE.CheckedChanged -= eventHandler;
				_Check_FIND_DATE.CheckedChanged -= eventHandler2;
			}
			_Check_FIND_DATE = value;
			if (_Check_FIND_DATE != null)
			{
				_Check_FIND_DATE.CheckedChanged += eventHandler;
				_Check_FIND_DATE.CheckedChanged += eventHandler2;
			}
		}
	}

	internal virtual BunifuCheckBox Check_FIND_EXACTE
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

	internal virtual Button_RJ Picture_REFRESH
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

	internal virtual Button_RJ Picture_FIND
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

	protected virtual RJTextBox Text_FIND
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
				_Text_FIND._TextChanged -= eventHandler;
			}
			_Text_FIND = value;
			if (_Text_FIND != null)
			{
				_Text_FIND._TextChanged += eventHandler;
			}
		}
	}

	internal virtual Panel Panel_COLUMNS
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel_COLUMNS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel_COLUMNS = value;
		}
	}

	internal virtual Button Button94545
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button94545;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button94545_Click;
			if (_Button94545 != null)
			{
				((Control)_Button94545).Click -= eventHandler;
			}
			_Button94545 = value;
			if (_Button94545 != null)
			{
				((Control)_Button94545).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button187878
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button187878;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button187878_Click;
			if (_Button187878 != null)
			{
				((Control)_Button187878).Click -= eventHandler;
			}
			_Button187878 = value;
			if (_Button187878 != null)
			{
				((Control)_Button187878).Click += eventHandler;
			}
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

	internal virtual Label Label51
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label51;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label51 = value;
		}
	}

	internal virtual ListBox ListBox_COLUMNS
	{
		[DebuggerNonUserCode]
		get
		{
			return _ListBox_COLUMNS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ListBox_COLUMNS = value;
		}
	}

	internal virtual TextBox Text_PRINTER_RAPPORT
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_PRINTER_RAPPORT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_PRINTER_RAPPORT = value;
		}
	}

	internal virtual TextBox Text_mail
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_mail;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_mail = value;
		}
	}

	internal virtual TextBox Text_MAIL_TITRE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_MAIL_TITRE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_MAIL_TITRE = value;
		}
	}

	internal virtual Button Button_MARGE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_MARGE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_MARGE_Click;
			if (_Button_MARGE != null)
			{
				((Control)_Button_MARGE).Click -= eventHandler;
			}
			_Button_MARGE = value;
			if (_Button_MARGE != null)
			{
				((Control)_Button_MARGE).Click += eventHandler;
			}
		}
	}

	public Form_3_VENTE_JOURNAL()
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected Obj, but got Unknown
		((Form)this).Load += Form_journal_Load;
		((Control)this).HandleCreated += Form_1_LOGIN_HandleCreated;
		((Form)this).Shown += Form_3_VENTE_JOURNAL_Shown;
		__ENCAddToList(this);
		DA = new MySqlDataAdapter();
		DT = new DataTable();
		prn = new RawPrinterHelper();
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
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected Obj, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected Obj, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected Obj, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected Obj, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected Obj, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected Obj, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected Obj, but got Unknown
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
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cf: Expected Obj, but got Unknown
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02db: Expected Obj, but got Unknown
		//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e7: Expected Obj, but got Unknown
		//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f3: Expected Obj, but got Unknown
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ff: Expected Obj, but got Unknown
		//IL_0301: Unknown result type (might be due to invalid IL or missing references)
		//IL_030b: Expected Obj, but got Unknown
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		//IL_0323: Expected Obj, but got Unknown
		//IL_0325: Unknown result type (might be due to invalid IL or missing references)
		//IL_032f: Expected Obj, but got Unknown
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_033b: Expected Obj, but got Unknown
		//IL_033d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0347: Expected Obj, but got Unknown
		//IL_0349: Unknown result type (might be due to invalid IL or missing references)
		//IL_0353: Expected Obj, but got Unknown
		//IL_0355: Unknown result type (might be due to invalid IL or missing references)
		//IL_035f: Expected Obj, but got Unknown
		//IL_0361: Unknown result type (might be due to invalid IL or missing references)
		//IL_036b: Expected Obj, but got Unknown
		//IL_036d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0377: Expected Obj, but got Unknown
		//IL_0379: Unknown result type (might be due to invalid IL or missing references)
		//IL_0383: Expected Obj, but got Unknown
		//IL_0385: Unknown result type (might be due to invalid IL or missing references)
		//IL_038f: Expected Obj, but got Unknown
		//IL_0391: Unknown result type (might be due to invalid IL or missing references)
		//IL_039b: Expected Obj, but got Unknown
		//IL_039d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a7: Expected Obj, but got Unknown
		//IL_03a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b3: Expected Obj, but got Unknown
		//IL_03b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bf: Expected Obj, but got Unknown
		//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cb: Expected Obj, but got Unknown
		//IL_03cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d7: Expected Obj, but got Unknown
		//IL_03d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e3: Expected Obj, but got Unknown
		//IL_03e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ef: Expected Obj, but got Unknown
		//IL_03f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fb: Expected Obj, but got Unknown
		//IL_03fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0407: Expected Obj, but got Unknown
		//IL_0409: Unknown result type (might be due to invalid IL or missing references)
		//IL_0413: Expected Obj, but got Unknown
		//IL_0415: Unknown result type (might be due to invalid IL or missing references)
		//IL_041f: Expected Obj, but got Unknown
		//IL_0421: Unknown result type (might be due to invalid IL or missing references)
		//IL_042b: Expected Obj, but got Unknown
		//IL_042d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0437: Expected Obj, but got Unknown
		//IL_0439: Unknown result type (might be due to invalid IL or missing references)
		//IL_0443: Expected Obj, but got Unknown
		//IL_0445: Unknown result type (might be due to invalid IL or missing references)
		//IL_044f: Expected Obj, but got Unknown
		//IL_0451: Unknown result type (might be due to invalid IL or missing references)
		//IL_045b: Expected Obj, but got Unknown
		//IL_045d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0467: Expected Obj, but got Unknown
		//IL_0469: Unknown result type (might be due to invalid IL or missing references)
		//IL_0473: Expected Obj, but got Unknown
		//IL_0475: Unknown result type (might be due to invalid IL or missing references)
		//IL_047f: Expected Obj, but got Unknown
		//IL_0481: Unknown result type (might be due to invalid IL or missing references)
		//IL_048b: Expected Obj, but got Unknown
		//IL_048d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0497: Expected Obj, but got Unknown
		//IL_0499: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a3: Expected Obj, but got Unknown
		//IL_04a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04af: Expected Obj, but got Unknown
		//IL_04b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bb: Expected Obj, but got Unknown
		//IL_04bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c7: Expected Obj, but got Unknown
		//IL_04c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d3: Expected Obj, but got Unknown
		//IL_04d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04df: Expected Obj, but got Unknown
		//IL_04e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04eb: Expected Obj, but got Unknown
		//IL_04ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f7: Expected Obj, but got Unknown
		//IL_04f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0503: Expected Obj, but got Unknown
		//IL_0505: Unknown result type (might be due to invalid IL or missing references)
		//IL_050f: Expected Obj, but got Unknown
		//IL_0511: Unknown result type (might be due to invalid IL or missing references)
		//IL_051b: Expected Obj, but got Unknown
		//IL_051d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0527: Expected Obj, but got Unknown
		//IL_0529: Unknown result type (might be due to invalid IL or missing references)
		//IL_0533: Expected Obj, but got Unknown
		//IL_0535: Unknown result type (might be due to invalid IL or missing references)
		//IL_053f: Expected Obj, but got Unknown
		//IL_0541: Unknown result type (might be due to invalid IL or missing references)
		//IL_054b: Expected Obj, but got Unknown
		//IL_054d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0557: Expected Obj, but got Unknown
		//IL_0559: Unknown result type (might be due to invalid IL or missing references)
		//IL_0563: Expected Obj, but got Unknown
		//IL_0565: Unknown result type (might be due to invalid IL or missing references)
		//IL_056f: Expected Obj, but got Unknown
		//IL_0571: Unknown result type (might be due to invalid IL or missing references)
		//IL_057b: Expected Obj, but got Unknown
		//IL_057d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0587: Expected Obj, but got Unknown
		//IL_0589: Unknown result type (might be due to invalid IL or missing references)
		//IL_0593: Expected Obj, but got Unknown
		//IL_0595: Unknown result type (might be due to invalid IL or missing references)
		//IL_059f: Expected Obj, but got Unknown
		//IL_05a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ab: Expected Obj, but got Unknown
		//IL_05ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b7: Expected Obj, but got Unknown
		//IL_05b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c3: Expected Obj, but got Unknown
		//IL_05c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cf: Expected Obj, but got Unknown
		//IL_05dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e7: Expected Obj, but got Unknown
		//IL_05e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f3: Expected Obj, but got Unknown
		//IL_05f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ff: Expected Obj, but got Unknown
		//IL_0601: Unknown result type (might be due to invalid IL or missing references)
		//IL_060b: Expected Obj, but got Unknown
		//IL_0625: Unknown result type (might be due to invalid IL or missing references)
		//IL_062f: Expected Obj, but got Unknown
		//IL_0631: Unknown result type (might be due to invalid IL or missing references)
		//IL_063b: Expected Obj, but got Unknown
		//IL_063d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0647: Expected Obj, but got Unknown
		//IL_0649: Unknown result type (might be due to invalid IL or missing references)
		//IL_0653: Expected Obj, but got Unknown
		//IL_0655: Unknown result type (might be due to invalid IL or missing references)
		//IL_065f: Expected Obj, but got Unknown
		//IL_0661: Unknown result type (might be due to invalid IL or missing references)
		//IL_066b: Expected Obj, but got Unknown
		//IL_066d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0677: Expected Obj, but got Unknown
		//IL_0679: Unknown result type (might be due to invalid IL or missing references)
		//IL_0683: Expected Obj, but got Unknown
		//IL_1171: Unknown result type (might be due to invalid IL or missing references)
		//IL_117b: Expected Obj, but got Unknown
		//IL_127c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1286: Expected Obj, but got Unknown
		//IL_17ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_17f4: Expected Obj, but got Unknown
		//IL_190b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1915: Expected Obj, but got Unknown
		//IL_1bd4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bde: Expected Obj, but got Unknown
		//IL_1bf9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bff: Unknown result type (might be due to invalid IL or missing references)
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form_3_VENTE_JOURNAL));
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		DataGridViewCellStyle val3 = new DataGridViewCellStyle();
		DataGridViewCellStyle val4 = new DataGridViewCellStyle();
		DataGridViewCellStyle val5 = new DataGridViewCellStyle();
		DataGridViewCellStyle val6 = new DataGridViewCellStyle();
		DataGridViewCellStyle val7 = new DataGridViewCellStyle();
		DataGridViewCellStyle val8 = new DataGridViewCellStyle();
		DataGridViewCellStyle val9 = new DataGridViewCellStyle();
		DataGridViewCellStyle val10 = new DataGridViewCellStyle();
		DataGridViewCellStyle val11 = new DataGridViewCellStyle();
		Panel4 = new Panel();
		Button_MARGE = new Button();
		Button6 = new Button();
		Label1 = new Label();
		Label10 = new Label();
		Label11 = new Label();
		Label12 = new Label();
		Button13 = new Button();
		Button4 = new Button();
		Button14 = new Button();
		Button2 = new Button();
		Panel8 = new Panel();
		Label3 = new Label();
		Label9 = new Label();
		Label27 = new Label();
		Label28 = new Label();
		Label29 = new Label();
		Label30 = new Label();
		Button20 = new Button();
		Button5 = new Button();
		Button_OK = new Button();
		DateTimePicker1 = new DateTimePicker();
		DateTimePicker2 = new DateTimePicker();
		Label_TABLE = new Label();
		DataGridView1 = new DataGridView();
		Ticket = new DataGridViewTextBoxColumn();
		Dates = new DataGridViewTextBoxColumn();
		Heure = new DataGridViewTextBoxColumn();
		Article = new DataGridViewTextBoxColumn();
		PRIX_V = new DataGridViewTextBoxColumn();
		Qté = new DataGridViewTextBoxColumn();
		Remise = new DataGridViewTextBoxColumn();
		Total_NET = new DataGridViewTextBoxColumn();
		Caissier = new DataGridViewTextBoxColumn();
		Vendeur = new DataGridViewTextBoxColumn();
		CLIENT = new DataGridViewTextBoxColumn();
		OPERATION = new DataGridViewTextBoxColumn();
		Panel1 = new Panel();
		DataGridView3 = new DataGridView();
		DataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
		DataGridView2 = new DataGridView();
		COL_1 = new DataGridViewTextBoxColumn();
		COL_2 = new DataGridViewTextBoxColumn();
		COL_3 = new DataGridViewTextBoxColumn();
		Print_Recette_Globale = new PrintDocument();
		Print_Recette_vendeur = new PrintDocument();
		Print_Recette_vendeurGLOBALE = new PrintDocument();
		Print_Recette_Famille = new PrintDocument();
		Print_Recette_caissier = new PrintDocument();
		Print_Recette_caissierGLOBALE = new PrintDocument();
		Timer1 = new System.Windows.Forms.Timer(components);
		Print_Recette_familleGLOBALE = new PrintDocument();
		Print_Recette_Client = new PrintDocument();
		Print_Recette_clientGLOBALE = new PrintDocument();
		TableLayoutPanel1 = new TableLayoutPanel();
		Panel00 = new Panel();
		TabControlEx1 = new TabControlEx();
		TabPage1 = new TabPage();
		Button_ConsJOURS = new Button();
		ListBox_RAPPORT_GLOBALE = new ListBox();
		Button_TOTAL_GLOBALE = new Button();
		Button_PrintRapport = new Button();
		Label_TOTAL_NET = new Label();
		Button_ConsRapport = new Button();
		Label18 = new Label();
		TabPage5 = new TabPage();
		Label19 = new Label();
		Button_TOTAL_CAISSIER = new Button();
		ListBox_CAISSIERS = new ListBox();
		Button_ConsGlobaleCaissier = new Button();
		Label_CAISSIER = new Label();
		Button_PrintCaissier = new Button();
		Button_ConsCaissier = new Button();
		TabPage3 = new TabPage();
		Label20 = new Label();
		Button_TOTAL_VENDEUR = new Button();
		ListBox_VENDEURS = new ListBox();
		Button_ConsGlobaleVendeur = new Button();
		Label_VENDEURS = new Label();
		Button_PrintVendeur = new Button();
		Button_ConsVendeur = new Button();
		TabPage2 = new TabPage();
		Label21 = new Label();
		Button_TOTAL_FAMILLE = new Button();
		ListBox_FAMILLES = new ListBox();
		Button_ConsGlobaleFamille = new Button();
		Label_FAMILLES = new Label();
		Button_PrintFamille = new Button();
		Button_ConsFamille = new Button();
		TabPage4 = new TabPage();
		Label22 = new Label();
		Button_TOTAL_CLIENT = new Button();
		ListBox_CLIENTS = new ListBox();
		Button_ConsGlobaleClients = new Button();
		Label_CLIENTS = new Label();
		Button_PrintClients = new Button();
		Button_ConsClients = new Button();
		Panel_CLOTURE = new Panel();
		Panel0 = new Panel();
		Panel_COLUMNS = new Panel();
		Button94545 = new Button();
		Button187878 = new Button();
		Label47 = new Label();
		Label48 = new Label();
		Label49 = new Label();
		Label51 = new Label();
		ListBox_COLUMNS = new ListBox();
		Button244 = new Button();
		Panel_FIND = new Panel();
		Panel_DATES = new Panel();
		DateTime2_FIND = new DateTimePicker();
		DateTime1_FIND = new DateTimePicker();
		Picture_FIND_DATES = new PictureBox();
		PictureBox13 = new PictureBox();
		Combo_FIND = new BunifuDropdown();
		Picture_EXPORT = new Button_RJ();
		Label8 = new Label();
		Label6 = new Label();
		Check_FIND_DATE = new BunifuCheckBox();
		Check_FIND_EXACTE = new BunifuCheckBox();
		Picture_REFRESH = new Button_RJ();
		Picture_FIND = new Button_RJ();
		Text_FIND = new RJTextBox();
		Label4141 = new Label();
		Print_Recette_Jours = new PrintDocument();
		Text_PRINTER_RAPPORT = new TextBox();
		Text_mail = new TextBox();
		Text_MAIL_TITRE = new TextBox();
		Button_MAIL_CAISSIER = new Button();
		Button_MAIL_GLOBALE = new Button();
		((Control)Panel4).SuspendLayout();
		((Control)Panel8).SuspendLayout();
		((ISupportInitialize)DataGridView1).BeginInit();
		((Control)Panel1).SuspendLayout();
		((ISupportInitialize)DataGridView3).BeginInit();
		((ISupportInitialize)DataGridView2).BeginInit();
		((Control)TableLayoutPanel1).SuspendLayout();
		((Control)Panel00).SuspendLayout();
		((Control)TabControlEx1).SuspendLayout();
		((Control)TabPage1).SuspendLayout();
		((Control)TabPage5).SuspendLayout();
		((Control)TabPage3).SuspendLayout();
		((Control)TabPage2).SuspendLayout();
		((Control)TabPage4).SuspendLayout();
		((Control)Panel0).SuspendLayout();
		((Control)Panel_COLUMNS).SuspendLayout();
		((Control)Panel_FIND).SuspendLayout();
		((Control)Panel_DATES).SuspendLayout();
		((ISupportInitialize)Picture_FIND_DATES).BeginInit();
		((ISupportInitialize)PictureBox13).BeginInit();
		((Control)this).SuspendLayout();
		componentResourceManager.ApplyResources(Panel4, "Panel4");
		((Control)Panel4).BackColor = Color.FromArgb(250, 250, 250);
		((Control)Panel4).Controls.Add((Control)(object)Button_MARGE);
		((Control)Panel4).Controls.Add((Control)(object)Button6);
		((Control)Panel4).Controls.Add((Control)(object)Label1);
		((Control)Panel4).Controls.Add((Control)(object)Label10);
		((Control)Panel4).Controls.Add((Control)(object)Label11);
		((Control)Panel4).Controls.Add((Control)(object)Label12);
		((Control)Panel4).Controls.Add((Control)(object)Button13);
		((Control)Panel4).Controls.Add((Control)(object)Button4);
		((Control)Panel4).Controls.Add((Control)(object)Button14);
		((Control)Panel4).Controls.Add((Control)(object)Button2);
		((Control)Panel4).Name = "Panel4";
		((Control)Button_MARGE).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Button_MARGE, "Button_MARGE");
		((Control)Button_MARGE).Name = "Button_MARGE";
		((ButtonBase)Button_MARGE).UseVisualStyleBackColor = true;
		((Control)Button6).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Button6, "Button6");
		((Control)Button6).ForeColor = SystemColors.ControlText;
		((Control)Button6).Name = "Button6";
		((ButtonBase)Button6).UseVisualStyleBackColor = true;
		((Control)Label1).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label1).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Label1, "Label1");
		((Control)Label1).ForeColor = Color.White;
		((Control)Label1).Name = "Label1";
		((Control)Label10).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label10).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Label10, "Label10");
		((Control)Label10).ForeColor = Color.White;
		((Control)Label10).Name = "Label10";
		((Control)Label11).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label11).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Label11, "Label11");
		((Control)Label11).ForeColor = Color.White;
		((Control)Label11).Name = "Label11";
		((Control)Label12).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label12).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Label12, "Label12");
		((Control)Label12).ForeColor = Color.White;
		((Control)Label12).Name = "Label12";
		((Control)Button13).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Button13, "Button13");
		((Control)Button13).Name = "Button13";
		((ButtonBase)Button13).UseVisualStyleBackColor = true;
		((Control)Button4).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Button4, "Button4");
		((Control)Button4).Name = "Button4";
		((ButtonBase)Button4).UseVisualStyleBackColor = true;
		((Control)Button14).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Button14, "Button14");
		((Control)Button14).ForeColor = SystemColors.ControlText;
		((Control)Button14).Name = "Button14";
		((ButtonBase)Button14).UseVisualStyleBackColor = true;
		((Control)Button2).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Button2, "Button2");
		((Control)Button2).Name = "Button2";
		((ButtonBase)Button2).UseVisualStyleBackColor = true;
		((Control)Panel8).BackColor = Color.FromArgb(250, 250, 250);
		((Control)Panel8).Controls.Add((Control)(object)Label3);
		((Control)Panel8).Controls.Add((Control)(object)Label9);
		((Control)Panel8).Controls.Add((Control)(object)Label27);
		((Control)Panel8).Controls.Add((Control)(object)Label28);
		((Control)Panel8).Controls.Add((Control)(object)Label29);
		((Control)Panel8).Controls.Add((Control)(object)Label30);
		((Control)Panel8).Controls.Add((Control)(object)Button20);
		((Control)Panel8).Controls.Add((Control)(object)Button5);
		((Control)Panel8).Controls.Add((Control)(object)Button_OK);
		((Control)Panel8).Controls.Add((Control)(object)DateTimePicker1);
		((Control)Panel8).Controls.Add((Control)(object)DateTimePicker2);
		componentResourceManager.ApplyResources(Panel8, "Panel8");
		((Control)Panel8).Name = "Panel8";
		((Control)Label3).BackColor = Color.WhiteSmoke;
		componentResourceManager.ApplyResources(Label3, "Label3");
		((Control)Label3).ForeColor = Color.FromArgb(64, 64, 64);
		((Control)Label3).Name = "Label3";
		((Control)Label9).BackColor = Color.WhiteSmoke;
		componentResourceManager.ApplyResources(Label9, "Label9");
		((Control)Label9).ForeColor = Color.FromArgb(64, 64, 64);
		((Control)Label9).Name = "Label9";
		((Control)Label27).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label27).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Label27, "Label27");
		((Control)Label27).ForeColor = Color.White;
		((Control)Label27).Name = "Label27";
		((Control)Label28).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label28).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Label28, "Label28");
		((Control)Label28).ForeColor = Color.White;
		((Control)Label28).Name = "Label28";
		((Control)Label29).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label29).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Label29, "Label29");
		((Control)Label29).ForeColor = Color.White;
		((Control)Label29).Name = "Label29";
		((Control)Label30).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label30).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Label30, "Label30");
		((Control)Label30).ForeColor = Color.White;
		((Control)Label30).Name = "Label30";
		((Control)Button20).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Button20, "Button20");
		((Control)Button20).ForeColor = Color.FromArgb(64, 64, 64);
		((Control)Button20).Name = "Button20";
		((ButtonBase)Button20).UseVisualStyleBackColor = true;
		((Control)Button5).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Button5, "Button5");
		((Control)Button5).ForeColor = Color.FromArgb(64, 64, 64);
		((Control)Button5).Name = "Button5";
		((ButtonBase)Button5).UseVisualStyleBackColor = true;
		((Control)Button_OK).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Button_OK, "Button_OK");
		((Control)Button_OK).ForeColor = Color.FromArgb(2, 45, 162);
		((Control)Button_OK).Name = "Button_OK";
		((ButtonBase)Button_OK).UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(DateTimePicker1, "DateTimePicker1");
		DateTimePicker1.Format = (DateTimePickerFormat)2;
		((Control)DateTimePicker1).Name = "DateTimePicker1";
		componentResourceManager.ApplyResources(DateTimePicker2, "DateTimePicker2");
		DateTimePicker2.Format = (DateTimePickerFormat)2;
		((Control)DateTimePicker2).Name = "DateTimePicker2";
		((Control)Label_TABLE).BackColor = Color.FromArgb(22, 106, 238);
		componentResourceManager.ApplyResources(Label_TABLE, "Label_TABLE");
		((Control)Label_TABLE).ForeColor = Color.White;
		((Control)Label_TABLE).Name = "Label_TABLE";
		DataGridView1.AllowUserToAddRows = false;
		DataGridView1.AllowUserToDeleteRows = false;
		DataGridView1.AllowUserToOrderColumns = true;
		DataGridView1.AllowUserToResizeRows = false;
		componentResourceManager.ApplyResources(DataGridView1, "DataGridView1");
		DataGridView1.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)16;
		DataGridView1.BackgroundColor = Color.White;
		val.Alignment = (DataGridViewContentAlignment)16;
		val.BackColor = SystemColors.Control;
		val.Font = new Font("Segoe UI", 11f, (FontStyle)1);
		val.ForeColor = SystemColors.WindowText;
		val.SelectionBackColor = SystemColors.Highlight;
		val.SelectionForeColor = SystemColors.HighlightText;
		val.WrapMode = (DataGridViewTriState)1;
		DataGridView1.ColumnHeadersDefaultCellStyle = val;
		DataGridView1.Columns.AddRange(new DataGridViewColumn[12]
		{
			(DataGridViewColumn)Ticket,
			(DataGridViewColumn)Dates,
			(DataGridViewColumn)Heure,
			(DataGridViewColumn)Article,
			(DataGridViewColumn)PRIX_V,
			(DataGridViewColumn)Qté,
			(DataGridViewColumn)Remise,
			(DataGridViewColumn)Total_NET,
			(DataGridViewColumn)Caissier,
			(DataGridViewColumn)Vendeur,
			(DataGridViewColumn)CLIENT,
			(DataGridViewColumn)OPERATION
		});
		val2.Alignment = (DataGridViewContentAlignment)16;
		val2.BackColor = SystemColors.Window;
		val2.Font = new Font("Segoe UI", 9.75f, (FontStyle)1);
		val2.ForeColor = SystemColors.ControlText;
		val2.SelectionBackColor = SystemColors.Highlight;
		val2.SelectionForeColor = SystemColors.HighlightText;
		val2.WrapMode = (DataGridViewTriState)2;
		DataGridView1.DefaultCellStyle = val2;
		DataGridView1.EditMode = (DataGridViewEditMode)4;
		((Control)DataGridView1).Name = "DataGridView1";
		DataGridView1.RowHeadersVisible = false;
		((DataGridViewColumn)Ticket).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)Ticket).DataPropertyName = "Ticket";
		componentResourceManager.ApplyResources(Ticket, "Ticket");
		((DataGridViewColumn)Ticket).Name = "Ticket";
		Ticket.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)Dates).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)Dates).DataPropertyName = "Dates";
		val3.NullValue = null;
		((DataGridViewColumn)Dates).DefaultCellStyle = val3;
		componentResourceManager.ApplyResources(Dates, "Dates");
		((DataGridViewColumn)Dates).Name = "Dates";
		Dates.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)Heure).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)Heure).DataPropertyName = "Heure";
		val4.Format = "T";
		val4.NullValue = null;
		((DataGridViewColumn)Heure).DefaultCellStyle = val4;
		componentResourceManager.ApplyResources(Heure, "Heure");
		((DataGridViewColumn)Heure).Name = "Heure";
		Heure.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)Article).DataPropertyName = "Article";
		componentResourceManager.ApplyResources(Article, "Article");
		((DataGridViewColumn)Article).Name = "Article";
		Article.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)PRIX_V).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)PRIX_V).DataPropertyName = "PRIX_V";
		val5.Alignment = (DataGridViewContentAlignment)64;
		val5.Format = "N2";
		val5.NullValue = null;
		((DataGridViewColumn)PRIX_V).DefaultCellStyle = val5;
		componentResourceManager.ApplyResources(PRIX_V, "PRIX_V");
		((DataGridViewColumn)PRIX_V).Name = "PRIX_V";
		PRIX_V.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)Qté).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)Qté).DataPropertyName = "Qté";
		val6.Alignment = (DataGridViewContentAlignment)64;
		((DataGridViewColumn)Qté).DefaultCellStyle = val6;
		componentResourceManager.ApplyResources(Qté, "Qté");
		((DataGridViewColumn)Qté).Name = "Qté";
		Qté.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)Remise).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)Remise).DataPropertyName = "Remise";
		val7.Alignment = (DataGridViewContentAlignment)64;
		((DataGridViewColumn)Remise).DefaultCellStyle = val7;
		componentResourceManager.ApplyResources(Remise, "Remise");
		((DataGridViewColumn)Remise).Name = "Remise";
		((DataGridViewColumn)Total_NET).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)Total_NET).DataPropertyName = "TOTAL_NET";
		val8.Alignment = (DataGridViewContentAlignment)64;
		val8.Format = "N2";
		val8.NullValue = null;
		((DataGridViewColumn)Total_NET).DefaultCellStyle = val8;
		componentResourceManager.ApplyResources(Total_NET, "Total_NET");
		((DataGridViewColumn)Total_NET).Name = "Total_NET";
		Total_NET.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)Caissier).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)Caissier).DataPropertyName = "Caissier";
		componentResourceManager.ApplyResources(Caissier, "Caissier");
		((DataGridViewColumn)Caissier).Name = "Caissier";
		Caissier.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)Vendeur).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)Vendeur).DataPropertyName = "Vendeur";
		componentResourceManager.ApplyResources(Vendeur, "Vendeur");
		((DataGridViewColumn)Vendeur).Name = "Vendeur";
		Vendeur.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)CLIENT).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)CLIENT).DataPropertyName = "CLIENT";
		componentResourceManager.ApplyResources(CLIENT, "CLIENT");
		((DataGridViewColumn)CLIENT).Name = "CLIENT";
		((DataGridViewColumn)OPERATION).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)OPERATION).DataPropertyName = "OPERATION";
		componentResourceManager.ApplyResources(OPERATION, "OPERATION");
		((DataGridViewColumn)OPERATION).Name = "OPERATION";
		((Control)Panel1).Controls.Add((Control)(object)DataGridView3);
		((Control)Panel1).Controls.Add((Control)(object)DataGridView2);
		componentResourceManager.ApplyResources(Panel1, "Panel1");
		((Control)Panel1).Name = "Panel1";
		DataGridView3.AllowUserToAddRows = false;
		DataGridView3.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		DataGridView3.Columns.AddRange(new DataGridViewColumn[1] { (DataGridViewColumn)DataGridViewTextBoxColumn1 });
		val9.Alignment = (DataGridViewContentAlignment)16;
		val9.BackColor = SystemColors.Window;
		val9.Font = new Font("Microsoft Sans Serif", 8f);
		val9.ForeColor = SystemColors.ControlText;
		val9.SelectionBackColor = SystemColors.Highlight;
		val9.SelectionForeColor = SystemColors.HighlightText;
		val9.WrapMode = (DataGridViewTriState)2;
		DataGridView3.DefaultCellStyle = val9;
		componentResourceManager.ApplyResources(DataGridView3, "DataGridView3");
		((Control)DataGridView3).Name = "DataGridView3";
		componentResourceManager.ApplyResources(DataGridViewTextBoxColumn1, "DataGridViewTextBoxColumn1");
		((DataGridViewColumn)DataGridViewTextBoxColumn1).Name = "DataGridViewTextBoxColumn1";
		((DataGridViewColumn)DataGridViewTextBoxColumn1).Resizable = (DataGridViewTriState)1;
		DataGridViewTextBoxColumn1.SortMode = (DataGridViewColumnSortMode)0;
		DataGridView2.AllowUserToAddRows = false;
		DataGridView2.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		DataGridView2.Columns.AddRange(new DataGridViewColumn[3]
		{
			(DataGridViewColumn)COL_1,
			(DataGridViewColumn)COL_2,
			(DataGridViewColumn)COL_3
		});
		val10.Alignment = (DataGridViewContentAlignment)16;
		val10.BackColor = SystemColors.Window;
		val10.Font = new Font("Microsoft Sans Serif", 8f);
		val10.ForeColor = SystemColors.ControlText;
		val10.SelectionBackColor = SystemColors.Highlight;
		val10.SelectionForeColor = SystemColors.HighlightText;
		val10.WrapMode = (DataGridViewTriState)2;
		DataGridView2.DefaultCellStyle = val10;
		componentResourceManager.ApplyResources(DataGridView2, "DataGridView2");
		((Control)DataGridView2).Name = "DataGridView2";
		componentResourceManager.ApplyResources(COL_1, "COL_1");
		((DataGridViewColumn)COL_1).Name = "COL_1";
		((DataGridViewColumn)COL_1).Resizable = (DataGridViewTriState)1;
		COL_1.SortMode = (DataGridViewColumnSortMode)0;
		componentResourceManager.ApplyResources(COL_2, "COL_2");
		((DataGridViewColumn)COL_2).Name = "COL_2";
		val11.Format = "N2";
		val11.NullValue = null;
		((DataGridViewColumn)COL_3).DefaultCellStyle = val11;
		componentResourceManager.ApplyResources(COL_3, "COL_3");
		((DataGridViewColumn)COL_3).Name = "COL_3";
		((Control)TableLayoutPanel1).BackColor = Color.White;
		componentResourceManager.ApplyResources(TableLayoutPanel1, "TableLayoutPanel1");
		TableLayoutPanel1.Controls.Add((Control)(object)Panel00, 0, 1);
		TableLayoutPanel1.Controls.Add((Control)(object)Panel0, 0, 0);
		((Control)TableLayoutPanel1).Name = "TableLayoutPanel1";
		((Control)Panel00).Controls.Add((Control)(object)TabControlEx1);
		((Control)Panel00).Controls.Add((Control)(object)Panel4);
		((Control)Panel00).Controls.Add((Control)(object)Panel8);
		((Control)Panel00).Controls.Add((Control)(object)Panel_CLOTURE);
		componentResourceManager.ApplyResources(Panel00, "Panel00");
		((Control)Panel00).Name = "Panel00";
		componentResourceManager.ApplyResources(TabControlEx1, "TabControlEx1");
		TabControlEx1.BackColor = Color.WhiteSmoke;
		((Control)TabControlEx1).Controls.Add((Control)(object)TabPage1);
		((Control)TabControlEx1).Controls.Add((Control)(object)TabPage5);
		((Control)TabControlEx1).Controls.Add((Control)(object)TabPage3);
		((Control)TabControlEx1).Controls.Add((Control)(object)TabPage2);
		((Control)TabControlEx1).Controls.Add((Control)(object)TabPage4);
		TabControlEx1.DrawMode = (TabDrawMode)1;
		TabControlEx1.HeaderAlignment = (ContentAlignment)16;
		TabControlEx1.HeaderBackColor = Color.WhiteSmoke;
		TabControlEx1.HeaderFont = new Font("Segoe UI", 12f);
		TabControlEx1.HeaderHeight = 29;
		TabControlEx tabControlEx = TabControlEx1;
		Padding headerPadding = new Padding(3, 0, 0, 0);
		tabControlEx.HeaderPadding = headerPadding;
		TabControlEx1.HeaderSelectedBackColor = Color.FromArgb(44, 53, 68);
		TabControlEx1.HeaderWidth = 150;
		TabControlEx1.Multiline = true;
		((Control)TabControlEx1).Name = "TabControlEx1";
		((TabControl)TabControlEx1).SelectedIndex = 0;
		TabControlEx1.SizeMode = (TabSizeMode)2;
		TabPage1.BackColor = Color.White;
		((Control)TabPage1).Controls.Add((Control)(object)Button_ConsJOURS);
		((Control)TabPage1).Controls.Add((Control)(object)ListBox_RAPPORT_GLOBALE);
		((Control)TabPage1).Controls.Add((Control)(object)Button_TOTAL_GLOBALE);
		((Control)TabPage1).Controls.Add((Control)(object)Button_PrintRapport);
		((Control)TabPage1).Controls.Add((Control)(object)Label_TOTAL_NET);
		((Control)TabPage1).Controls.Add((Control)(object)Button_ConsRapport);
		((Control)TabPage1).Controls.Add((Control)(object)Label18);
		componentResourceManager.ApplyResources(TabPage1, "TabPage1");
		((Control)TabPage1).Name = "TabPage1";
		componentResourceManager.ApplyResources(Button_ConsJOURS, "Button_ConsJOURS");
		((Control)Button_ConsJOURS).Name = "Button_ConsJOURS";
		((ButtonBase)Button_ConsJOURS).UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(ListBox_RAPPORT_GLOBALE, "ListBox_RAPPORT_GLOBALE");
		((ListControl)ListBox_RAPPORT_GLOBALE).FormattingEnabled = true;
		ListBox_RAPPORT_GLOBALE.Items.AddRange(new object[4]
		{
			componentResourceManager.GetString("ListBox_RAPPORT_GLOBALE.Items"),
			componentResourceManager.GetString("ListBox_RAPPORT_GLOBALE.Items1"),
			componentResourceManager.GetString("ListBox_RAPPORT_GLOBALE.Items2"),
			componentResourceManager.GetString("ListBox_RAPPORT_GLOBALE.Items3")
		});
		((Control)ListBox_RAPPORT_GLOBALE).Name = "ListBox_RAPPORT_GLOBALE";
		((Control)Button_TOTAL_GLOBALE).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Button_TOTAL_GLOBALE, "Button_TOTAL_GLOBALE");
		((Control)Button_TOTAL_GLOBALE).ForeColor = Color.FromArgb(2, 45, 162);
		((Control)Button_TOTAL_GLOBALE).Name = "Button_TOTAL_GLOBALE";
		((ButtonBase)Button_TOTAL_GLOBALE).UseVisualStyleBackColor = true;
		((Control)Button_PrintRapport).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Button_PrintRapport, "Button_PrintRapport");
		((Control)Button_PrintRapport).Name = "Button_PrintRapport";
		((ButtonBase)Button_PrintRapport).UseVisualStyleBackColor = true;
		((Control)Label_TOTAL_NET).BackColor = Color.White;
		Label_TOTAL_NET.BorderStyle = (BorderStyle)1;
		componentResourceManager.ApplyResources(Label_TOTAL_NET, "Label_TOTAL_NET");
		((Control)Label_TOTAL_NET).ForeColor = Color.FromArgb(2, 45, 162);
		((Control)Label_TOTAL_NET).Name = "Label_TOTAL_NET";
		((Control)Button_ConsRapport).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Button_ConsRapport, "Button_ConsRapport");
		((Control)Button_ConsRapport).Name = "Button_ConsRapport";
		((ButtonBase)Button_ConsRapport).UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(Label18, "Label18");
		((Control)Label18).ForeColor = Color.FromArgb(44, 53, 68);
		((Control)Label18).Name = "Label18";
		TabPage5.BackColor = Color.White;
		((Control)TabPage5).Controls.Add((Control)(object)Label19);
		((Control)TabPage5).Controls.Add((Control)(object)Button_TOTAL_CAISSIER);
		((Control)TabPage5).Controls.Add((Control)(object)ListBox_CAISSIERS);
		((Control)TabPage5).Controls.Add((Control)(object)Button_ConsGlobaleCaissier);
		((Control)TabPage5).Controls.Add((Control)(object)Label_CAISSIER);
		((Control)TabPage5).Controls.Add((Control)(object)Button_PrintCaissier);
		((Control)TabPage5).Controls.Add((Control)(object)Button_ConsCaissier);
		componentResourceManager.ApplyResources(TabPage5, "TabPage5");
		((Control)TabPage5).Name = "TabPage5";
		componentResourceManager.ApplyResources(Label19, "Label19");
		((Control)Label19).ForeColor = Color.FromArgb(44, 53, 68);
		((Control)Label19).Name = "Label19";
		((Control)Button_TOTAL_CAISSIER).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Button_TOTAL_CAISSIER, "Button_TOTAL_CAISSIER");
		((Control)Button_TOTAL_CAISSIER).ForeColor = Color.FromArgb(2, 45, 162);
		((Control)Button_TOTAL_CAISSIER).Name = "Button_TOTAL_CAISSIER";
		((ButtonBase)Button_TOTAL_CAISSIER).UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(ListBox_CAISSIERS, "ListBox_CAISSIERS");
		((ListControl)ListBox_CAISSIERS).FormattingEnabled = true;
		((Control)ListBox_CAISSIERS).Name = "ListBox_CAISSIERS";
		componentResourceManager.ApplyResources(Button_ConsGlobaleCaissier, "Button_ConsGlobaleCaissier");
		((Control)Button_ConsGlobaleCaissier).Name = "Button_ConsGlobaleCaissier";
		((ButtonBase)Button_ConsGlobaleCaissier).UseVisualStyleBackColor = true;
		((Control)Label_CAISSIER).BackColor = Color.White;
		Label_CAISSIER.BorderStyle = (BorderStyle)1;
		componentResourceManager.ApplyResources(Label_CAISSIER, "Label_CAISSIER");
		((Control)Label_CAISSIER).ForeColor = Color.FromArgb(2, 45, 162);
		((Control)Label_CAISSIER).Name = "Label_CAISSIER";
		((Control)Button_PrintCaissier).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Button_PrintCaissier, "Button_PrintCaissier");
		((Control)Button_PrintCaissier).Name = "Button_PrintCaissier";
		((ButtonBase)Button_PrintCaissier).UseVisualStyleBackColor = true;
		((Control)Button_ConsCaissier).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Button_ConsCaissier, "Button_ConsCaissier");
		((Control)Button_ConsCaissier).Name = "Button_ConsCaissier";
		((ButtonBase)Button_ConsCaissier).UseVisualStyleBackColor = true;
		TabPage3.BackColor = Color.White;
		((Control)TabPage3).Controls.Add((Control)(object)Label20);
		((Control)TabPage3).Controls.Add((Control)(object)Button_TOTAL_VENDEUR);
		((Control)TabPage3).Controls.Add((Control)(object)ListBox_VENDEURS);
		((Control)TabPage3).Controls.Add((Control)(object)Button_ConsGlobaleVendeur);
		((Control)TabPage3).Controls.Add((Control)(object)Label_VENDEURS);
		((Control)TabPage3).Controls.Add((Control)(object)Button_PrintVendeur);
		((Control)TabPage3).Controls.Add((Control)(object)Button_ConsVendeur);
		componentResourceManager.ApplyResources(TabPage3, "TabPage3");
		((Control)TabPage3).Name = "TabPage3";
		componentResourceManager.ApplyResources(Label20, "Label20");
		((Control)Label20).ForeColor = Color.FromArgb(44, 53, 68);
		((Control)Label20).Name = "Label20";
		((Control)Button_TOTAL_VENDEUR).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Button_TOTAL_VENDEUR, "Button_TOTAL_VENDEUR");
		((Control)Button_TOTAL_VENDEUR).ForeColor = Color.FromArgb(2, 45, 162);
		((Control)Button_TOTAL_VENDEUR).Name = "Button_TOTAL_VENDEUR";
		((ButtonBase)Button_TOTAL_VENDEUR).UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(ListBox_VENDEURS, "ListBox_VENDEURS");
		((ListControl)ListBox_VENDEURS).FormattingEnabled = true;
		((Control)ListBox_VENDEURS).Name = "ListBox_VENDEURS";
		componentResourceManager.ApplyResources(Button_ConsGlobaleVendeur, "Button_ConsGlobaleVendeur");
		((Control)Button_ConsGlobaleVendeur).Name = "Button_ConsGlobaleVendeur";
		((ButtonBase)Button_ConsGlobaleVendeur).UseVisualStyleBackColor = true;
		((Control)Label_VENDEURS).BackColor = Color.White;
		Label_VENDEURS.BorderStyle = (BorderStyle)1;
		componentResourceManager.ApplyResources(Label_VENDEURS, "Label_VENDEURS");
		((Control)Label_VENDEURS).ForeColor = Color.FromArgb(2, 45, 162);
		((Control)Label_VENDEURS).Name = "Label_VENDEURS";
		((Control)Button_PrintVendeur).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Button_PrintVendeur, "Button_PrintVendeur");
		((Control)Button_PrintVendeur).Name = "Button_PrintVendeur";
		((ButtonBase)Button_PrintVendeur).UseVisualStyleBackColor = true;
		((Control)Button_ConsVendeur).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Button_ConsVendeur, "Button_ConsVendeur");
		((Control)Button_ConsVendeur).Name = "Button_ConsVendeur";
		((ButtonBase)Button_ConsVendeur).UseVisualStyleBackColor = true;
		TabPage2.BackColor = Color.White;
		((Control)TabPage2).Controls.Add((Control)(object)Label21);
		((Control)TabPage2).Controls.Add((Control)(object)Button_TOTAL_FAMILLE);
		((Control)TabPage2).Controls.Add((Control)(object)ListBox_FAMILLES);
		((Control)TabPage2).Controls.Add((Control)(object)Button_ConsGlobaleFamille);
		((Control)TabPage2).Controls.Add((Control)(object)Label_FAMILLES);
		((Control)TabPage2).Controls.Add((Control)(object)Button_PrintFamille);
		((Control)TabPage2).Controls.Add((Control)(object)Button_ConsFamille);
		componentResourceManager.ApplyResources(TabPage2, "TabPage2");
		((Control)TabPage2).Name = "TabPage2";
		componentResourceManager.ApplyResources(Label21, "Label21");
		((Control)Label21).ForeColor = Color.FromArgb(44, 53, 68);
		((Control)Label21).Name = "Label21";
		((Control)Button_TOTAL_FAMILLE).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Button_TOTAL_FAMILLE, "Button_TOTAL_FAMILLE");
		((Control)Button_TOTAL_FAMILLE).ForeColor = Color.FromArgb(2, 45, 162);
		((Control)Button_TOTAL_FAMILLE).Name = "Button_TOTAL_FAMILLE";
		((ButtonBase)Button_TOTAL_FAMILLE).UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(ListBox_FAMILLES, "ListBox_FAMILLES");
		((ListControl)ListBox_FAMILLES).FormattingEnabled = true;
		((Control)ListBox_FAMILLES).Name = "ListBox_FAMILLES";
		componentResourceManager.ApplyResources(Button_ConsGlobaleFamille, "Button_ConsGlobaleFamille");
		((Control)Button_ConsGlobaleFamille).Name = "Button_ConsGlobaleFamille";
		((ButtonBase)Button_ConsGlobaleFamille).UseVisualStyleBackColor = true;
		((Control)Label_FAMILLES).BackColor = Color.White;
		Label_FAMILLES.BorderStyle = (BorderStyle)1;
		componentResourceManager.ApplyResources(Label_FAMILLES, "Label_FAMILLES");
		((Control)Label_FAMILLES).ForeColor = Color.FromArgb(2, 45, 162);
		((Control)Label_FAMILLES).Name = "Label_FAMILLES";
		((Control)Button_PrintFamille).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Button_PrintFamille, "Button_PrintFamille");
		((Control)Button_PrintFamille).Name = "Button_PrintFamille";
		((ButtonBase)Button_PrintFamille).UseVisualStyleBackColor = true;
		((Control)Button_ConsFamille).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Button_ConsFamille, "Button_ConsFamille");
		((Control)Button_ConsFamille).Name = "Button_ConsFamille";
		((ButtonBase)Button_ConsFamille).UseVisualStyleBackColor = true;
		TabPage4.BackColor = Color.White;
		((Control)TabPage4).Controls.Add((Control)(object)Label22);
		((Control)TabPage4).Controls.Add((Control)(object)Button_TOTAL_CLIENT);
		((Control)TabPage4).Controls.Add((Control)(object)ListBox_CLIENTS);
		((Control)TabPage4).Controls.Add((Control)(object)Button_ConsGlobaleClients);
		((Control)TabPage4).Controls.Add((Control)(object)Label_CLIENTS);
		((Control)TabPage4).Controls.Add((Control)(object)Button_PrintClients);
		((Control)TabPage4).Controls.Add((Control)(object)Button_ConsClients);
		componentResourceManager.ApplyResources(TabPage4, "TabPage4");
		((Control)TabPage4).Name = "TabPage4";
		componentResourceManager.ApplyResources(Label22, "Label22");
		((Control)Label22).ForeColor = Color.FromArgb(44, 53, 68);
		((Control)Label22).Name = "Label22";
		((Control)Button_TOTAL_CLIENT).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Button_TOTAL_CLIENT, "Button_TOTAL_CLIENT");
		((Control)Button_TOTAL_CLIENT).ForeColor = Color.FromArgb(2, 45, 162);
		((Control)Button_TOTAL_CLIENT).Name = "Button_TOTAL_CLIENT";
		((ButtonBase)Button_TOTAL_CLIENT).UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(ListBox_CLIENTS, "ListBox_CLIENTS");
		((ListControl)ListBox_CLIENTS).FormattingEnabled = true;
		((Control)ListBox_CLIENTS).Name = "ListBox_CLIENTS";
		componentResourceManager.ApplyResources(Button_ConsGlobaleClients, "Button_ConsGlobaleClients");
		((Control)Button_ConsGlobaleClients).Name = "Button_ConsGlobaleClients";
		((ButtonBase)Button_ConsGlobaleClients).UseVisualStyleBackColor = true;
		((Control)Label_CLIENTS).BackColor = Color.White;
		Label_CLIENTS.BorderStyle = (BorderStyle)1;
		componentResourceManager.ApplyResources(Label_CLIENTS, "Label_CLIENTS");
		((Control)Label_CLIENTS).ForeColor = Color.FromArgb(2, 45, 162);
		((Control)Label_CLIENTS).Name = "Label_CLIENTS";
		((Control)Button_PrintClients).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Button_PrintClients, "Button_PrintClients");
		((Control)Button_PrintClients).Name = "Button_PrintClients";
		((ButtonBase)Button_PrintClients).UseVisualStyleBackColor = true;
		((Control)Button_ConsClients).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Button_ConsClients, "Button_ConsClients");
		((Control)Button_ConsClients).Name = "Button_ConsClients";
		((ButtonBase)Button_ConsClients).UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(Panel_CLOTURE, "Panel_CLOTURE");
		((Control)Panel_CLOTURE).BackColor = Color.White;
		Panel_CLOTURE.BorderStyle = (BorderStyle)1;
		((Control)Panel_CLOTURE).Name = "Panel_CLOTURE";
		((Control)Panel0).Controls.Add((Control)(object)Panel_COLUMNS);
		((Control)Panel0).Controls.Add((Control)(object)Button244);
		((Control)Panel0).Controls.Add((Control)(object)Panel_FIND);
		((Control)Panel0).Controls.Add((Control)(object)Label4141);
		((Control)Panel0).Controls.Add((Control)(object)Panel1);
		((Control)Panel0).Controls.Add((Control)(object)DataGridView1);
		((Control)Panel0).Controls.Add((Control)(object)Label_TABLE);
		componentResourceManager.ApplyResources(Panel0, "Panel0");
		((Control)Panel0).Name = "Panel0";
		componentResourceManager.ApplyResources(Panel_COLUMNS, "Panel_COLUMNS");
		((Control)Panel_COLUMNS).Controls.Add((Control)(object)Button94545);
		((Control)Panel_COLUMNS).Controls.Add((Control)(object)Button187878);
		((Control)Panel_COLUMNS).Controls.Add((Control)(object)Label47);
		((Control)Panel_COLUMNS).Controls.Add((Control)(object)Label48);
		((Control)Panel_COLUMNS).Controls.Add((Control)(object)Label49);
		((Control)Panel_COLUMNS).Controls.Add((Control)(object)Label51);
		((Control)Panel_COLUMNS).Controls.Add((Control)(object)ListBox_COLUMNS);
		((Control)Panel_COLUMNS).Name = "Panel_COLUMNS";
		((ButtonBase)Button94545).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Button94545).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Button94545, "Button94545");
		((Control)Button94545).ForeColor = Color.White;
		((Control)Button94545).Name = "Button94545";
		((ButtonBase)Button94545).UseVisualStyleBackColor = false;
		((ButtonBase)Button187878).BackColor = Color.Red;
		((Control)Button187878).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Button187878, "Button187878");
		((Control)Button187878).ForeColor = Color.White;
		((Control)Button187878).Name = "Button187878";
		((ButtonBase)Button187878).UseVisualStyleBackColor = false;
		((Control)Label47).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label47).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Label47, "Label47");
		((Control)Label47).ForeColor = Color.White;
		((Control)Label47).Name = "Label47";
		((Control)Label48).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label48).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Label48, "Label48");
		((Control)Label48).ForeColor = Color.White;
		((Control)Label48).Name = "Label48";
		((Control)Label49).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label49).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Label49, "Label49");
		((Control)Label49).ForeColor = Color.White;
		((Control)Label49).Name = "Label49";
		((Control)Label51).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label51).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Label51, "Label51");
		((Control)Label51).ForeColor = Color.White;
		((Control)Label51).Name = "Label51";
		((ListControl)ListBox_COLUMNS).FormattingEnabled = true;
		ListBox_COLUMNS.Items.AddRange(new object[15]
		{
			componentResourceManager.GetString("ListBox_COLUMNS.Items"),
			componentResourceManager.GetString("ListBox_COLUMNS.Items1"),
			componentResourceManager.GetString("ListBox_COLUMNS.Items2"),
			componentResourceManager.GetString("ListBox_COLUMNS.Items3"),
			componentResourceManager.GetString("ListBox_COLUMNS.Items4"),
			componentResourceManager.GetString("ListBox_COLUMNS.Items5"),
			componentResourceManager.GetString("ListBox_COLUMNS.Items6"),
			componentResourceManager.GetString("ListBox_COLUMNS.Items7"),
			componentResourceManager.GetString("ListBox_COLUMNS.Items8"),
			componentResourceManager.GetString("ListBox_COLUMNS.Items9"),
			componentResourceManager.GetString("ListBox_COLUMNS.Items10"),
			componentResourceManager.GetString("ListBox_COLUMNS.Items11"),
			componentResourceManager.GetString("ListBox_COLUMNS.Items12"),
			componentResourceManager.GetString("ListBox_COLUMNS.Items13"),
			componentResourceManager.GetString("ListBox_COLUMNS.Items14")
		});
		componentResourceManager.ApplyResources(ListBox_COLUMNS, "ListBox_COLUMNS");
		((Control)ListBox_COLUMNS).Name = "ListBox_COLUMNS";
		componentResourceManager.ApplyResources(Button244, "Button244");
		((ButtonBase)Button244).BackColor = Color.Red;
		((Control)Button244).Cursor = Cursors.Hand;
		((Control)Button244).ForeColor = Color.White;
		((Control)Button244).Name = "Button244";
		((ButtonBase)Button244).UseVisualStyleBackColor = false;
		componentResourceManager.ApplyResources(Panel_FIND, "Panel_FIND");
		((Control)Panel_FIND).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Panel_FIND).Controls.Add((Control)(object)Panel_DATES);
		((Control)Panel_FIND).Controls.Add((Control)(object)Combo_FIND);
		((Control)Panel_FIND).Controls.Add((Control)(object)Picture_EXPORT);
		((Control)Panel_FIND).Controls.Add((Control)(object)Label8);
		((Control)Panel_FIND).Controls.Add((Control)(object)Label6);
		((Control)Panel_FIND).Controls.Add((Control)(object)Check_FIND_DATE);
		((Control)Panel_FIND).Controls.Add((Control)(object)Check_FIND_EXACTE);
		((Control)Panel_FIND).Controls.Add((Control)(object)Picture_REFRESH);
		((Control)Panel_FIND).Controls.Add((Control)(object)Picture_FIND);
		((Control)Panel_FIND).Controls.Add((Control)(object)Text_FIND);
		((Control)Panel_FIND).Name = "Panel_FIND";
		((Control)Panel_DATES).Controls.Add((Control)(object)DateTime2_FIND);
		((Control)Panel_DATES).Controls.Add((Control)(object)DateTime1_FIND);
		((Control)Panel_DATES).Controls.Add((Control)(object)Picture_FIND_DATES);
		((Control)Panel_DATES).Controls.Add((Control)(object)PictureBox13);
		componentResourceManager.ApplyResources(Panel_DATES, "Panel_DATES");
		((Control)Panel_DATES).Name = "Panel_DATES";
		componentResourceManager.ApplyResources(DateTime2_FIND, "DateTime2_FIND");
		DateTime2_FIND.Format = (DateTimePickerFormat)2;
		((Control)DateTime2_FIND).Name = "DateTime2_FIND";
		componentResourceManager.ApplyResources(DateTime1_FIND, "DateTime1_FIND");
		DateTime1_FIND.Format = (DateTimePickerFormat)2;
		((Control)DateTime1_FIND).Name = "DateTime1_FIND";
		componentResourceManager.ApplyResources(Picture_FIND_DATES, "Picture_FIND_DATES");
		((Control)Picture_FIND_DATES).Name = "Picture_FIND_DATES";
		Picture_FIND_DATES.TabStop = false;
		componentResourceManager.ApplyResources(PictureBox13, "PictureBox13");
		((Control)PictureBox13).Name = "PictureBox13";
		PictureBox13.TabStop = false;
		Combo_FIND.BackColor = Color.Transparent;
		Combo_FIND.BackgroundColor = Color.FromArgb(75, 141, 242);
		Combo_FIND.BorderColor = Color.White;
		Combo_FIND.BorderRadius = 13;
		Combo_FIND.Color = Color.White;
		Combo_FIND.Direction = (Bunifu.UI.WinForms.BunifuDropdown.Directions)1;
		Combo_FIND.DisabledBackColor = Color.FromArgb(240, 240, 240);
		Combo_FIND.DisabledBorderColor = Color.FromArgb(204, 204, 204);
		Combo_FIND.DisabledColor = Color.FromArgb(240, 240, 240);
		Combo_FIND.DisabledForeColor = Color.FromArgb(109, 109, 109);
		Combo_FIND.DisabledIndicatorColor = Color.DarkGray;
		Combo_FIND.DrawMode = (DrawMode)1;
		Combo_FIND.DropdownBorderThickness = (Bunifu.UI.WinForms.BunifuDropdown.BorderThickness)1;
		Combo_FIND.DropDownStyle = (ComboBoxStyle)2;
		Combo_FIND.DropDownTextAlign = (Bunifu.UI.WinForms.BunifuDropdown.TextAlign)0;
		((ComboBox)Combo_FIND).DropDownWidth = 150;
		Combo_FIND.FillDropDown = true;
		Combo_FIND.FillIndicator = false;
		componentResourceManager.ApplyResources(Combo_FIND, "Combo_FIND");
		Combo_FIND.ForeColor = Color.White;
		((ListControl)Combo_FIND).FormattingEnabled = true;
		Combo_FIND.Icon = null;
		Combo_FIND.IndicatorAlignment = (Bunifu.UI.WinForms.BunifuDropdown.Indicator)1;
		Combo_FIND.IndicatorColor = Color.White;
		Combo_FIND.IndicatorLocation = (Bunifu.UI.WinForms.BunifuDropdown.Indicator)1;
		Combo_FIND.ItemBackColor = Color.White;
		Combo_FIND.ItemBorderColor = Color.White;
		Combo_FIND.ItemForeColor = Color.Black;
		Combo_FIND.ItemHighLightColor = Color.DodgerBlue;
		Combo_FIND.ItemHighLightForeColor = Color.White;
		((ComboBox)Combo_FIND).Items.AddRange(new object[13]
		{
			componentResourceManager.GetString("Combo_FIND.Items"),
			componentResourceManager.GetString("Combo_FIND.Items1"),
			componentResourceManager.GetString("Combo_FIND.Items2"),
			componentResourceManager.GetString("Combo_FIND.Items3"),
			componentResourceManager.GetString("Combo_FIND.Items4"),
			componentResourceManager.GetString("Combo_FIND.Items5"),
			componentResourceManager.GetString("Combo_FIND.Items6"),
			componentResourceManager.GetString("Combo_FIND.Items7"),
			componentResourceManager.GetString("Combo_FIND.Items8"),
			componentResourceManager.GetString("Combo_FIND.Items9"),
			componentResourceManager.GetString("Combo_FIND.Items10"),
			componentResourceManager.GetString("Combo_FIND.Items11"),
			componentResourceManager.GetString("Combo_FIND.Items12")
		});
		Combo_FIND.ItemTopMargin = 3;
		((Control)Combo_FIND).Name = "Combo_FIND";
		Combo_FIND.TextAlignment = (Bunifu.UI.WinForms.BunifuDropdown.TextAlign)0;
		Combo_FIND.TextLeftMargin = 5;
		Picture_EXPORT._BackgroundColor = Color.FromArgb(75, 141, 242);
		Picture_EXPORT._BorderColor = Color.White;
		Picture_EXPORT._BorderRadius = 16;
		Picture_EXPORT._BorderSize = 1;
		Picture_EXPORT._TextColor = Color.White;
		componentResourceManager.ApplyResources(Picture_EXPORT, "Picture_EXPORT");
		((ButtonBase)Picture_EXPORT).BackColor = Color.FromArgb(75, 141, 242);
		((ButtonBase)Picture_EXPORT).FlatAppearance.BorderSize = 0;
		((Control)Picture_EXPORT).ForeColor = Color.White;
		((Control)Picture_EXPORT).Name = "Picture_EXPORT";
		((ButtonBase)Picture_EXPORT).UseVisualStyleBackColor = false;
		componentResourceManager.ApplyResources(Label8, "Label8");
		((Control)Label8).ForeColor = Color.White;
		((Control)Label8).Name = "Label8";
		componentResourceManager.ApplyResources(Label6, "Label6");
		((Control)Label6).ForeColor = Color.White;
		((Control)Label6).Name = "Label6";
		Check_FIND_DATE.AllowBindingControlAnimation = true;
		Check_FIND_DATE.AllowBindingControlColorChanges = false;
		Check_FIND_DATE.AllowBindingControlLocation = true;
		Check_FIND_DATE.AllowCheckBoxAnimation = false;
		Check_FIND_DATE.AllowCheckmarkAnimation = true;
		Check_FIND_DATE.AllowOnHoverStates = true;
		Check_FIND_DATE.AutoCheck = true;
		((Control)Check_FIND_DATE).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Check_FIND_DATE, "Check_FIND_DATE");
		Check_FIND_DATE.BindingControlPosition = (Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions)1;
		Check_FIND_DATE.BorderRadius = 12;
		Check_FIND_DATE.Checked = false;
		Check_FIND_DATE.CheckState = (Bunifu.UI.WinForms.BunifuCheckBox.CheckStates)1;
		((Control)Check_FIND_DATE).Cursor = Cursors.Default;
		Check_FIND_DATE.CustomCheckmarkImage = null;
		((Control)Check_FIND_DATE).Name = "Check_FIND_DATE";
		Check_FIND_DATE.OnCheck.BorderColor = Color.DodgerBlue;
		Check_FIND_DATE.OnCheck.BorderRadius = 12;
		Check_FIND_DATE.OnCheck.BorderThickness = 2;
		Check_FIND_DATE.OnCheck.CheckBoxColor = Color.DodgerBlue;
		Check_FIND_DATE.OnCheck.CheckmarkColor = Color.White;
		Check_FIND_DATE.OnCheck.CheckmarkThickness = 2;
		Check_FIND_DATE.OnDisable.BorderColor = Color.LightGray;
		Check_FIND_DATE.OnDisable.BorderRadius = 12;
		Check_FIND_DATE.OnDisable.BorderThickness = 2;
		Check_FIND_DATE.OnDisable.CheckBoxColor = Color.Transparent;
		Check_FIND_DATE.OnDisable.CheckmarkColor = Color.LightGray;
		Check_FIND_DATE.OnDisable.CheckmarkThickness = 2;
		Check_FIND_DATE.OnHoverChecked.BorderColor = Color.FromArgb(105, 181, 255);
		Check_FIND_DATE.OnHoverChecked.BorderRadius = 12;
		Check_FIND_DATE.OnHoverChecked.BorderThickness = 2;
		Check_FIND_DATE.OnHoverChecked.CheckBoxColor = Color.FromArgb(105, 181, 255);
		Check_FIND_DATE.OnHoverChecked.CheckmarkColor = Color.White;
		Check_FIND_DATE.OnHoverChecked.CheckmarkThickness = 2;
		Check_FIND_DATE.OnHoverUnchecked.BorderColor = Color.FromArgb(105, 181, 255);
		Check_FIND_DATE.OnHoverUnchecked.BorderRadius = 12;
		Check_FIND_DATE.OnHoverUnchecked.BorderThickness = 1;
		Check_FIND_DATE.OnHoverUnchecked.CheckBoxColor = Color.Transparent;
		Check_FIND_DATE.OnUncheck.BorderColor = Color.DarkGray;
		Check_FIND_DATE.OnUncheck.BorderRadius = 12;
		Check_FIND_DATE.OnUncheck.BorderThickness = 1;
		Check_FIND_DATE.OnUncheck.CheckBoxColor = Color.Transparent;
		Check_FIND_DATE.Style = (Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles)0;
		Check_FIND_DATE.ThreeState = false;
		Check_FIND_DATE.ToolTipText = null;
		Check_FIND_EXACTE.AllowBindingControlAnimation = true;
		Check_FIND_EXACTE.AllowBindingControlColorChanges = false;
		Check_FIND_EXACTE.AllowBindingControlLocation = true;
		Check_FIND_EXACTE.AllowCheckBoxAnimation = false;
		Check_FIND_EXACTE.AllowCheckmarkAnimation = true;
		Check_FIND_EXACTE.AllowOnHoverStates = true;
		Check_FIND_EXACTE.AutoCheck = true;
		((Control)Check_FIND_EXACTE).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Check_FIND_EXACTE, "Check_FIND_EXACTE");
		Check_FIND_EXACTE.BindingControlPosition = (Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions)1;
		Check_FIND_EXACTE.BorderRadius = 12;
		Check_FIND_EXACTE.Checked = false;
		Check_FIND_EXACTE.CheckState = (Bunifu.UI.WinForms.BunifuCheckBox.CheckStates)1;
		((Control)Check_FIND_EXACTE).Cursor = Cursors.Default;
		Check_FIND_EXACTE.CustomCheckmarkImage = null;
		((Control)Check_FIND_EXACTE).Name = "Check_FIND_EXACTE";
		Check_FIND_EXACTE.OnCheck.BorderColor = Color.DodgerBlue;
		Check_FIND_EXACTE.OnCheck.BorderRadius = 12;
		Check_FIND_EXACTE.OnCheck.BorderThickness = 2;
		Check_FIND_EXACTE.OnCheck.CheckBoxColor = Color.DodgerBlue;
		Check_FIND_EXACTE.OnCheck.CheckmarkColor = Color.White;
		Check_FIND_EXACTE.OnCheck.CheckmarkThickness = 2;
		Check_FIND_EXACTE.OnDisable.BorderColor = Color.LightGray;
		Check_FIND_EXACTE.OnDisable.BorderRadius = 12;
		Check_FIND_EXACTE.OnDisable.BorderThickness = 2;
		Check_FIND_EXACTE.OnDisable.CheckBoxColor = Color.Transparent;
		Check_FIND_EXACTE.OnDisable.CheckmarkColor = Color.LightGray;
		Check_FIND_EXACTE.OnDisable.CheckmarkThickness = 2;
		Check_FIND_EXACTE.OnHoverChecked.BorderColor = Color.FromArgb(105, 181, 255);
		Check_FIND_EXACTE.OnHoverChecked.BorderRadius = 12;
		Check_FIND_EXACTE.OnHoverChecked.BorderThickness = 2;
		Check_FIND_EXACTE.OnHoverChecked.CheckBoxColor = Color.FromArgb(105, 181, 255);
		Check_FIND_EXACTE.OnHoverChecked.CheckmarkColor = Color.White;
		Check_FIND_EXACTE.OnHoverChecked.CheckmarkThickness = 2;
		Check_FIND_EXACTE.OnHoverUnchecked.BorderColor = Color.FromArgb(105, 181, 255);
		Check_FIND_EXACTE.OnHoverUnchecked.BorderRadius = 12;
		Check_FIND_EXACTE.OnHoverUnchecked.BorderThickness = 1;
		Check_FIND_EXACTE.OnHoverUnchecked.CheckBoxColor = Color.Transparent;
		Check_FIND_EXACTE.OnUncheck.BorderColor = Color.DarkGray;
		Check_FIND_EXACTE.OnUncheck.BorderRadius = 12;
		Check_FIND_EXACTE.OnUncheck.BorderThickness = 1;
		Check_FIND_EXACTE.OnUncheck.CheckBoxColor = Color.Transparent;
		Check_FIND_EXACTE.Style = (Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles)0;
		Check_FIND_EXACTE.ThreeState = false;
		Check_FIND_EXACTE.ToolTipText = null;
		Picture_REFRESH._BackgroundColor = Color.FromArgb(75, 141, 242);
		Picture_REFRESH._BorderColor = Color.White;
		Picture_REFRESH._BorderRadius = 16;
		Picture_REFRESH._BorderSize = 1;
		Picture_REFRESH._TextColor = Color.White;
		((ButtonBase)Picture_REFRESH).BackColor = Color.FromArgb(75, 141, 242);
		((ButtonBase)Picture_REFRESH).FlatAppearance.BorderSize = 0;
		componentResourceManager.ApplyResources(Picture_REFRESH, "Picture_REFRESH");
		((Control)Picture_REFRESH).ForeColor = Color.White;
		((Control)Picture_REFRESH).Name = "Picture_REFRESH";
		((ButtonBase)Picture_REFRESH).UseVisualStyleBackColor = false;
		Picture_FIND._BackgroundColor = Color.FromArgb(75, 141, 242);
		Picture_FIND._BorderColor = Color.White;
		Picture_FIND._BorderRadius = 16;
		Picture_FIND._BorderSize = 1;
		Picture_FIND._TextColor = Color.White;
		((ButtonBase)Picture_FIND).BackColor = Color.FromArgb(75, 141, 242);
		((ButtonBase)Picture_FIND).FlatAppearance.BorderSize = 0;
		componentResourceManager.ApplyResources(Picture_FIND, "Picture_FIND");
		((Control)Picture_FIND).ForeColor = Color.White;
		((Control)Picture_FIND).Name = "Picture_FIND";
		((ButtonBase)Picture_FIND).UseVisualStyleBackColor = false;
		Text_FIND.BackColor = Color.FromArgb(75, 141, 242);
		Text_FIND.BorderColor = Color.White;
		Text_FIND.BorderFocusColor = Color.White;
		Text_FIND.BorderRadius = 16;
		Text_FIND.BorderSize = 1;
		componentResourceManager.ApplyResources(Text_FIND, "Text_FIND");
		Text_FIND.ForeColor = Color.White;
		Text_FIND.Multiline = false;
		((Control)Text_FIND).Name = "Text_FIND";
		Text_FIND.PasswordChar = false;
		Text_FIND.PlaceholderColor = Color.White;
		Text_FIND.PlaceholderText = "";
		Text_FIND.Texts = "";
		Text_FIND.UnderlinedStyle = false;
		componentResourceManager.ApplyResources(Label4141, "Label4141");
		((Control)Label4141).BackColor = Color.Red;
		((Control)Label4141).ForeColor = Color.White;
		((Control)Label4141).Name = "Label4141";
		componentResourceManager.ApplyResources(Text_PRINTER_RAPPORT, "Text_PRINTER_RAPPORT");
		((Control)Text_PRINTER_RAPPORT).Name = "Text_PRINTER_RAPPORT";
		componentResourceManager.ApplyResources(Text_mail, "Text_mail");
		((Control)Text_mail).Name = "Text_mail";
		((TextBoxBase)Text_MAIL_TITRE).BorderStyle = (BorderStyle)1;
		componentResourceManager.ApplyResources(Text_MAIL_TITRE, "Text_MAIL_TITRE");
		((Control)Text_MAIL_TITRE).Name = "Text_MAIL_TITRE";
		componentResourceManager.ApplyResources(Button_MAIL_CAISSIER, "Button_MAIL_CAISSIER");
		((Control)Button_MAIL_CAISSIER).Cursor = Cursors.Hand;
		((Control)Button_MAIL_CAISSIER).Name = "Button_MAIL_CAISSIER";
		((ButtonBase)Button_MAIL_CAISSIER).UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(Button_MAIL_GLOBALE, "Button_MAIL_GLOBALE");
		((Control)Button_MAIL_GLOBALE).Cursor = Cursors.Hand;
		((Control)Button_MAIL_GLOBALE).Name = "Button_MAIL_GLOBALE";
		((ButtonBase)Button_MAIL_GLOBALE).UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(this, "$this");
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).BackColor = SystemColors.Control;
		((Control)this).Controls.Add((Control)(object)TableLayoutPanel1);
		((Control)this).Controls.Add((Control)(object)Button_MAIL_CAISSIER);
		((Control)this).Controls.Add((Control)(object)Button_MAIL_GLOBALE);
		((Control)this).Controls.Add((Control)(object)Text_PRINTER_RAPPORT);
		((Control)this).Controls.Add((Control)(object)Text_mail);
		((Control)this).Controls.Add((Control)(object)Text_MAIL_TITRE);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Control)this).Name = "Form_3_VENTE_JOURNAL";
		((Form)this).WindowState = (FormWindowState)2;
		((Control)Panel4).ResumeLayout(false);
		((Control)Panel8).ResumeLayout(false);
		((ISupportInitialize)DataGridView1).EndInit();
		((Control)Panel1).ResumeLayout(false);
		((ISupportInitialize)DataGridView3).EndInit();
		((ISupportInitialize)DataGridView2).EndInit();
		((Control)TableLayoutPanel1).ResumeLayout(false);
		((Control)Panel00).ResumeLayout(false);
		((Control)TabControlEx1).ResumeLayout(false);
		((Control)TabPage1).ResumeLayout(false);
		((Control)TabPage5).ResumeLayout(false);
		((Control)TabPage3).ResumeLayout(false);
		((Control)TabPage2).ResumeLayout(false);
		((Control)TabPage4).ResumeLayout(false);
		((Control)Panel0).ResumeLayout(false);
		((Control)Panel_COLUMNS).ResumeLayout(false);
		((Control)Panel_FIND).ResumeLayout(false);
		((Control)Panel_FIND).PerformLayout();
		((Control)Panel_DATES).ResumeLayout(false);
		((ISupportInitialize)Picture_FIND_DATES).EndInit();
		((ISupportInitialize)PictureBox13).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public void FUN_CAT_ACCES()
	{
		if (Operators.CompareString(Module1._USERCATEGORIE, "ADMIN", TextCompare: false) == 0)
		{
			((Control)Button_MARGE).Visible = true;
		}
		else if (Operators.CompareString(Module1._USERCATEGORIE, "MANAGER", TextCompare: false) == 0)
		{
			((Control)Button_MARGE).Visible = false;
		}
		else if (Operators.CompareString(Module1._USERCATEGORIE, "UTILISATEUR", TextCompare: false) == 0)
		{
			((Control)Button_MARGE).Visible = false;
		}
	}

	public void _COLORISE_DATAGRID()
	{
		checked
		{
			int num = DataGridView1.Rows.Count - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 <= num4)
				{
					if (num2 == 0)
					{
						DataGridView1.Rows[num2].DefaultCellStyle.BackColor = Color.FromArgb(221, 235, 247);
					}
					else if (Operators.ConditionalCompareObjectEqual(DataGridView1.Rows[num2].Cells[0].Value, DataGridView1.Rows[num2 - 1].Cells[0].Value, TextCompare: false))
					{
						DataGridView1.Rows[num2].DefaultCellStyle.BackColor = DataGridView1.Rows[num2 - 1].DefaultCellStyle.BackColor;
					}
					else if (DataGridView1.Rows[num2 - 1].DefaultCellStyle.BackColor == Color.FromArgb(221, 235, 247))
					{
						DataGridView1.Rows[num2].DefaultCellStyle.BackColor = Color.White;
					}
					else
					{
						DataGridView1.Rows[num2].DefaultCellStyle.BackColor = Color.FromArgb(221, 235, 247);
					}
					num2++;
					continue;
				}
				break;
			}
		}
	}

	public void Start_Print_COM_CL()
	{
		PrintBuffer = "";
		prn.OpenPrint(Text_PRINTER_RAPPORT.Text);
	}

	public void Print_COM_CL(string Line)
	{
		prn.SendStringToPrinter(Text_PRINTER_RAPPORT.Text, Line + "\n");
	}

	public void EndPrint()
	{
		prn.ClosePrint();
	}

	public void Print_Recette_Globale_COM()
	{
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Expected Obj, but got Unknown
		//IL_0299: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Expected Obj, but got Unknown
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Expected Obj, but got Unknown
		//IL_056a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0570: Expected Obj, but got Unknown
		//IL_07e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e9: Expected Obj, but got Unknown
		//IL_085f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0865: Expected Obj, but got Unknown
		Start_Print_COM_CL();
		PrintBuffer = "";
		prn.OpenPrint(Text_PRINTER_RAPPORT.Text);
		Print_COM_CL("\u001b@\u001b!\0\r\u001bc6\u0001\u001bR3\r\n");
		Print_COM_CL("\n");
		Print_COM_CL("\u001b!8\u001ba1Recette Globale");
		Print_COM_CL("\n");
		Print_COM_CL("\u001b!\0\u001ba0Rapport :" + Strings.Format(DateTimePicker1.Value, "dd/MM/yyyy") + " ==> " + Strings.Format(DateTimePicker2.Value, "dd/MM/yyyy"));
		Print_COM_CL("\n");
		Print_COM_CL("\u001ba0\u001b!\0" + "-".PadRight(42, '-'));
		Print_COM_CL("\u001b!\0\r\u001bc6\u0001\u001bR3Article                   | Qte  | Total |");
		Print_COM_CL("\u001ba0\u001b!\0" + "-".PadRight(42, '-'));
		string text = "";
		checked
		{
			int num = DataGridView2.RowCount - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				text = Strings.LSet(DataGridView2.Rows[num2].Cells["COL_1"].Value.ToString(), 26) + Strings.RSet(DataGridView2.Rows[num2].Cells["COL_2"].Value.ToString() + "x", 6) + "  " + Strings.RSet(DataGridView2.Rows[num2].Cells["COL_3"].Value.ToString(), 8);
				Print_COM_CL("\u001b!\0\r\u001bc6\u0001\u001bR3" + text);
				num2++;
			}
			Print_COM_CL("\u001ba0\u001b!\0" + "-".PadRight(42, '-'));
			double num5 = 0.0;
			DataTable dataTable = new DataTable();
			MySqlDataAdapter val = new MySqlDataAdapter();
			dataTable.Clear();
			val = new MySqlDataAdapter("select sum(Total_NET) as n     from TABLE_VENTES_JOURNAL WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " ' ", Module1.cn_SQL);
			((DbDataAdapter)(object)val).Fill(dataTable);
			num5 = Conversions.ToDouble(Strings.FormatNumber(Conversion.Val(dataTable.Rows[0]["n"].ToString())));
			Print_COM_CL("\u001b!8\u001ba0TOTAL NET: " + Conversions.ToString(Math.Round(new decimal(num5), 2)) + " DH");
			Print_COM_CL("\u001ba0\u001b!\0" + "-".PadRight(42, '-'));
			Print_COM_CL("\n");
			Print_COM_CL("\u001ba0\u001b!\0---------------FINANCE----------------");
			MySqlDataAdapter val2 = new MySqlDataAdapter();
			DataTable dataTable2 = new DataTable();
			val2 = new MySqlDataAdapter("(select sum(MONTANT) as n     from    TABLE_VENTES_REGLEMENTS     WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '             And     MODE_P  = 'ESPECES'  )      UNION ALL        (select sum(MONTANT) as n from TABLE_VENTES_REGLEMENTS  WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '             And     MODE_P  = 'CARTE'  )       UNION ALL        (select sum(MONTANT) as n from   TABLE_VENTES_REGLEMENTS   WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '             And     MODE_P  = 'CHEQUE'  )     UNION ALL        (select sum(MONTANT) as n from   TABLE_VENTES_REGLEMENTS   WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '             And     MODE_P  = 'CREDIT'  )       UNION ALL        (select sum(MONTANT) as n from   TABLE_VENTES_REGLEMENTS   WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '             And     MODE_P  = 'AVOIR'  )       UNION ALL        (select sum(MONTANT) as n from   TABLE_VENTES_REGLEMENTS   WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '             And     MODE_P  = 'RETOUR'  )  ", Module1.cn_SQL);
			dataTable2 = new DataTable();
			dataTable2.Clear();
			((DbDataAdapter)(object)val2).Fill(dataTable2);
			double num6 = Conversion.Val(dataTable2.Rows[0]["n"].ToString());
			double num7 = Conversion.Val(dataTable2.Rows[1]["n"].ToString());
			double num8 = Conversion.Val(dataTable2.Rows[2]["n"].ToString());
			double num9 = Conversion.Val(dataTable2.Rows[3]["n"].ToString());
			double num10 = Conversion.Val(dataTable2.Rows[4]["n"].ToString());
			double num11 = Conversion.Val(dataTable2.Rows[5]["n"].ToString());
			Print_COM_CL("\u001ba0\u001b!\0- ESPECES       : " + Conversions.ToString(Math.Round(Conversions.ToDecimal(Strings.RSet(Strings.FormatNumber(num6), 8)), 2)) + " DH");
			Print_COM_CL("\u001ba0\u001b!\0- CARTE         : " + Conversions.ToString(Math.Round(Conversions.ToDecimal(Strings.RSet(Strings.FormatNumber(num7), 8)), 2)) + " DH");
			Print_COM_CL("\u001ba0\u001b!\0- CHEQUE        : " + Conversions.ToString(Math.Round(Conversions.ToDecimal(Strings.RSet(Strings.FormatNumber(num8), 8)), 2)) + " DH");
			Print_COM_CL("\u001ba0\u001b!\0- CREDIT        : " + Conversions.ToString(Math.Round(Conversions.ToDecimal(Strings.RSet(Strings.FormatNumber(num9), 8)), 2)) + " DH");
			Print_COM_CL("\u001ba0\u001b!\0- AVOIR         : " + Conversions.ToString(Math.Round(Conversions.ToDecimal(Strings.RSet(Strings.FormatNumber(num10), 8)), 2)) + " DH");
			Print_COM_CL("\u001ba0\u001b!\0- RETOUR        : " + Conversions.ToString(Math.Round(Conversions.ToDecimal(Strings.RSet(Strings.FormatNumber(num11), 8)), 2)) + " DH");
			Print_COM_CL("\n");
			Print_COM_CL("\u001ba0\u001b!\0--------------CAISSIERS----------------");
			MySqlDataAdapter val3 = new MySqlDataAdapter();
			DataTable dataTable3 = new DataTable();
			val3 = new MySqlDataAdapter("select Caissier, sum(TOTAL_NET) as TOTAL_NET    from   TABLE_VENTES_JOURNAL    Where           Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '         group by Caissier      ", Module1.cn_SQL);
			dataTable3 = new DataTable();
			dataTable3.Clear();
			((DbDataAdapter)(object)val3).Fill(dataTable3);
			string text2 = "";
			int num12 = dataTable3.Rows.Count - 1;
			int num13 = 0;
			while (true)
			{
				int num14 = num13;
				int num4 = num12;
				if (num14 > num4)
				{
					break;
				}
				text2 = text2 + "- " + Strings.LSet(dataTable3.Rows[num13]["Caissier"].ToString(), 14) + ": " + Conversions.ToString(Math.Round(Conversions.ToDecimal(Strings.RSet(Strings.FormatNumber(Conversion.Val(dataTable3.Rows[num13]["TOTAL_NET"].ToString())), 8)), 2)) + " DH" + Environment.NewLine + Environment.NewLine;
				num13++;
			}
			Print_COM_CL("\u001b!\0\r\u001bc6\u0001\u001bR3" + text2);
			Print_COM_CL("\n");
			Print_COM_CL("\u001ba1\u001b!\0" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
			Print_COM_CL("\n");
			Print_COM_CL("\n");
			Print_COM_CL("\n\n\u001bi\r\n\u001b@\u001bp\0.}");
			EndPrint();
			Module1._QUITTER_PATIENTER = true;
		}
	}

	public void Print_Recette_Jours_COM()
	{
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected Obj, but got Unknown
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Expected Obj, but got Unknown
		//IL_0337: Unknown result type (might be due to invalid IL or missing references)
		//IL_033d: Expected Obj, but got Unknown
		//IL_055e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0564: Expected Obj, but got Unknown
		//IL_07d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07dd: Expected Obj, but got Unknown
		//IL_0853: Unknown result type (might be due to invalid IL or missing references)
		//IL_0859: Expected Obj, but got Unknown
		Start_Print_COM_CL();
		PrintBuffer = "";
		prn.OpenPrint(Text_PRINTER_RAPPORT.Text);
		Print_COM_CL("\u001b@\u001b!\0\r\u001bc6\u0001\u001bR3\r\n");
		Print_COM_CL("\n");
		Print_COM_CL("\u001b!8\u001ba1Recette JOURS");
		Print_COM_CL("\n");
		Print_COM_CL("\u001b!\0\u001ba0Rapport :" + Strings.Format(DateTimePicker1.Value, "dd/MM/yyyy") + " ==> " + Strings.Format(DateTimePicker2.Value, "dd/MM/yyyy"));
		Print_COM_CL("\n");
		Print_COM_CL("\u001ba0\u001b!\0" + "-".PadRight(42, '-'));
		Print_COM_CL("\u001ba0\u001b!\0" + "-".PadRight(42, '-'));
		string text = "";
		checked
		{
			int num = DataGridView2.RowCount - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				text = Strings.LSet(DataGridView2.Rows[num2].Cells["COL_1"].Value.ToString(), 26) + Strings.RSet(DataGridView2.Rows[num2].Cells["COL_2"].Value.ToString() + "x", 6) + "  " + Strings.RSet(DataGridView2.Rows[num2].Cells["COL_3"].Value.ToString(), 8);
				Print_COM_CL("\u001b!\0\r\u001bc6\u0001\u001bR3" + text);
				num2++;
			}
			Print_COM_CL("\u001ba0\u001b!\0" + "-".PadRight(42, '-'));
			double num5 = 0.0;
			DataTable dataTable = new DataTable();
			MySqlDataAdapter val = new MySqlDataAdapter();
			dataTable.Clear();
			val = new MySqlDataAdapter("select sum(Total_NET) as n     from TABLE_VENTES_JOURNAL WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " ' ", Module1.cn_SQL);
			((DbDataAdapter)(object)val).Fill(dataTable);
			num5 = Conversions.ToDouble(Strings.FormatNumber(Conversion.Val(dataTable.Rows[0]["n"].ToString())));
			Print_COM_CL("\u001b!8\u001ba0TOTAL NET: " + Conversions.ToString(Math.Round(new decimal(num5), 2)) + " DH");
			Print_COM_CL("\u001ba0\u001b!\0" + "-".PadRight(42, '-'));
			Print_COM_CL("\n");
			Print_COM_CL("\u001ba0\u001b!\0---------------FINANCE----------------");
			MySqlDataAdapter val2 = new MySqlDataAdapter();
			DataTable dataTable2 = new DataTable();
			val2 = new MySqlDataAdapter("(select sum(MONTANT) as n     from    TABLE_VENTES_REGLEMENTS     WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '             And     MODE_P  = 'ESPECES'  )      UNION ALL        (select sum(MONTANT) as n from TABLE_VENTES_REGLEMENTS  WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '             And     MODE_P  = 'CARTE'  )       UNION ALL        (select sum(MONTANT) as n from   TABLE_VENTES_REGLEMENTS   WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '             And     MODE_P  = 'CHEQUE'  )     UNION ALL        (select sum(MONTANT) as n from   TABLE_VENTES_REGLEMENTS   WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '             And     MODE_P  = 'CREDIT'  )       UNION ALL        (select sum(MONTANT) as n from   TABLE_VENTES_REGLEMENTS   WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '             And     MODE_P  = 'AVOIR'  )       UNION ALL        (select sum(MONTANT) as n from   TABLE_VENTES_REGLEMENTS   WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '             And     MODE_P  = 'RETOUR'  )  ", Module1.cn_SQL);
			dataTable2 = new DataTable();
			dataTable2.Clear();
			((DbDataAdapter)(object)val2).Fill(dataTable2);
			double num6 = Conversion.Val(dataTable2.Rows[0]["n"].ToString());
			double num7 = Conversion.Val(dataTable2.Rows[1]["n"].ToString());
			double num8 = Conversion.Val(dataTable2.Rows[2]["n"].ToString());
			double num9 = Conversion.Val(dataTable2.Rows[3]["n"].ToString());
			double num10 = Conversion.Val(dataTable2.Rows[4]["n"].ToString());
			double num11 = Conversion.Val(dataTable2.Rows[5]["n"].ToString());
			Print_COM_CL("\u001ba0\u001b!\0- ESPECES       : " + Conversions.ToString(Math.Round(Conversions.ToDecimal(Strings.RSet(Strings.FormatNumber(num6), 8)), 2)) + " DH");
			Print_COM_CL("\u001ba0\u001b!\0- CARTE         : " + Conversions.ToString(Math.Round(Conversions.ToDecimal(Strings.RSet(Strings.FormatNumber(num7), 8)), 2)) + " DH");
			Print_COM_CL("\u001ba0\u001b!\0- CHEQUE        : " + Conversions.ToString(Math.Round(Conversions.ToDecimal(Strings.RSet(Strings.FormatNumber(num8), 8)), 2)) + " DH");
			Print_COM_CL("\u001ba0\u001b!\0- CREDIT        : " + Conversions.ToString(Math.Round(Conversions.ToDecimal(Strings.RSet(Strings.FormatNumber(num9), 8)), 2)) + " DH");
			Print_COM_CL("\u001ba0\u001b!\0- AVOIR         : " + Conversions.ToString(Math.Round(Conversions.ToDecimal(Strings.RSet(Strings.FormatNumber(num10), 8)), 2)) + " DH");
			Print_COM_CL("\u001ba0\u001b!\0- RETOUR        : " + Conversions.ToString(Math.Round(Conversions.ToDecimal(Strings.RSet(Strings.FormatNumber(num11), 8)), 2)) + " DH");
			Print_COM_CL("\n");
			Print_COM_CL("\u001ba0\u001b!\0--------------CAISSIERS----------------");
			MySqlDataAdapter val3 = new MySqlDataAdapter();
			DataTable dataTable3 = new DataTable();
			val3 = new MySqlDataAdapter("select Caissier, sum(TOTAL_NET) as TOTAL_NET    from   TABLE_VENTES_JOURNAL    Where           Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '         group by Caissier      ", Module1.cn_SQL);
			dataTable3 = new DataTable();
			dataTable3.Clear();
			((DbDataAdapter)(object)val3).Fill(dataTable3);
			string text2 = "";
			int num12 = dataTable3.Rows.Count - 1;
			int num13 = 0;
			while (true)
			{
				int num14 = num13;
				int num4 = num12;
				if (num14 > num4)
				{
					break;
				}
				text2 = text2 + "- " + Strings.LSet(dataTable3.Rows[num13]["Caissier"].ToString(), 14) + ": " + Conversions.ToString(Math.Round(Conversions.ToDecimal(Strings.RSet(Strings.FormatNumber(Conversion.Val(dataTable3.Rows[num13]["TOTAL_NET"].ToString())), 8)), 2)) + " DH" + Environment.NewLine + Environment.NewLine;
				num13++;
			}
			Print_COM_CL("\u001b!\0\r\u001bc6\u0001\u001bR3" + text2);
			Print_COM_CL("\n");
			Print_COM_CL("\u001ba1\u001b!\0" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
			Print_COM_CL("\n");
			Print_COM_CL("\n");
			Print_COM_CL("\n\n\u001bi\r\n\u001b@\u001bp\0.}");
			EndPrint();
			Module1._QUITTER_PATIENTER = true;
		}
	}

	public void Print_Recette_caissier_COM()
	{
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Expected Obj, but got Unknown
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02db: Expected Obj, but got Unknown
		//IL_037e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0384: Expected Obj, but got Unknown
		//IL_066b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0671: Expected Obj, but got Unknown
		Start_Print_COM_CL();
		PrintBuffer = "";
		prn.OpenPrint(Text_PRINTER_RAPPORT.Text);
		Print_COM_CL("\u001b@\u001b!\0\r\u001bc6\u0001\u001bR3\r\n");
		Print_COM_CL("\n");
		Print_COM_CL("\u001b!8\u001ba1RAPPORT CAISSIER");
		Print_COM_CL("\n");
		Print_COM_CL("\u001b!\0\u001ba0Caissier:" + ListBox_CAISSIERS.Text);
		Print_COM_CL("\u001b!\0\u001ba0Rapport :" + Strings.Format(DateTimePicker1.Value, "dd/MM/yyyy") + " ==> " + Strings.Format(DateTimePicker2.Value, "dd/MM/yyyy"));
		Print_COM_CL("\n");
		Print_COM_CL("\u001ba0\u001b!\0" + "-".PadRight(42, '-'));
		Print_COM_CL("\u001b!\0\r\u001bc6\u0001\u001bR3Article                   | Qte  | Total |");
		Print_COM_CL("\u001ba0\u001b!\0" + "-".PadRight(42, '-'));
		string text = "";
		checked
		{
			int num = DataGridView2.RowCount - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				text = Strings.LSet(DataGridView2.Rows[num2].Cells["COL_1"].Value.ToString(), 26) + Strings.RSet(DataGridView2.Rows[num2].Cells["COL_2"].Value.ToString() + "x", 6) + "  " + Strings.RSet(DataGridView2.Rows[num2].Cells["COL_3"].Value.ToString(), 8);
				Print_COM_CL("\u001b!\0\r\u001bc6\u0001\u001bR3" + text);
				num2++;
			}
			Print_COM_CL("\u001ba0\u001b!\0" + "-".PadRight(42, '-'));
			double num5 = 0.0;
			DataTable dataTable = new DataTable();
			MySqlDataAdapter val = new MySqlDataAdapter();
			dataTable.Clear();
			val = new MySqlDataAdapter("select sum(Total_NET) as n     from TABLE_VENTES_JOURNAL WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '      And     Caissier like  '" + Strings.Trim(ListBox_CAISSIERS.Text) + "'    ", Module1.cn_SQL);
			((DbDataAdapter)(object)val).Fill(dataTable);
			num5 = Conversions.ToDouble(Strings.FormatNumber(Conversion.Val(dataTable.Rows[0]["n"].ToString())));
			Print_COM_CL("\u001b!8\u001ba0TOTAL NET: " + Conversions.ToString(Math.Round(new decimal(num5), 2)) + " DH");
			Print_COM_CL("\u001ba0\u001b!\0" + "-".PadRight(42, '-'));
			Print_COM_CL("\n");
			Print_COM_CL("\u001ba0\u001b!\0---------------FINANCE----------------");
			MySqlDataAdapter val2 = new MySqlDataAdapter();
			DataTable dataTable2 = new DataTable();
			val2 = new MySqlDataAdapter("(select sum(MONTANT) as n     from    TABLE_VENTES_REGLEMENTS     WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '               And     Caissier like  '" + Strings.Trim(ListBox_CAISSIERS.Text) + "'                  And     MODE_P  = 'ESPECES'  )      UNION ALL        (select sum(MONTANT) as n from TABLE_VENTES_REGLEMENTS  WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '                  And     Caissier like  '" + Strings.Trim(ListBox_CAISSIERS.Text) + "'               And     MODE_P  = 'CARTE'  )       UNION ALL        (select sum(MONTANT) as n from   TABLE_VENTES_REGLEMENTS   WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '                And     Caissier like  '" + Strings.Trim(ListBox_CAISSIERS.Text) + "'                 And     MODE_P  = 'CHEQUE'  )     UNION ALL        (select sum(MONTANT) as n from   TABLE_VENTES_REGLEMENTS   WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '                  And     Caissier like  '" + Strings.Trim(ListBox_CAISSIERS.Text) + "'               And     MODE_P  = 'CREDIT'  )       UNION ALL        (select sum(MONTANT) as n from   TABLE_VENTES_REGLEMENTS   WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '                And     Caissier like  '" + Strings.Trim(ListBox_CAISSIERS.Text) + "'                 And     MODE_P  = 'AVOIR'  )         UNION ALL        (select sum(MONTANT) as n from   TABLE_VENTES_REGLEMENTS   WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '                And     Caissier like  '" + Strings.Trim(ListBox_CAISSIERS.Text) + "'                 And     MODE_P  = 'RETOUR'  )  ", Module1.cn_SQL);
			dataTable2 = new DataTable();
			dataTable2.Clear();
			((DbDataAdapter)(object)val2).Fill(dataTable2);
			double num6 = Conversion.Val(dataTable2.Rows[0]["n"].ToString());
			double num7 = Conversion.Val(dataTable2.Rows[1]["n"].ToString());
			double num8 = Conversion.Val(dataTable2.Rows[2]["n"].ToString());
			double num9 = Conversion.Val(dataTable2.Rows[3]["n"].ToString());
			double num10 = Conversion.Val(dataTable2.Rows[4]["n"].ToString());
			double num11 = Conversion.Val(dataTable2.Rows[5]["n"].ToString());
			Print_COM_CL("\u001ba0\u001b!\0- ESPECES       : " + Conversions.ToString(Math.Round(Conversions.ToDecimal(Strings.RSet(Strings.FormatNumber(num6), 8)), 2)) + " DH");
			Print_COM_CL("\u001ba0\u001b!\0- CARTE         : " + Conversions.ToString(Math.Round(Conversions.ToDecimal(Strings.RSet(Strings.FormatNumber(num7), 8)), 2)) + " DH");
			Print_COM_CL("\u001ba0\u001b!\0- CHEQUE        : " + Conversions.ToString(Math.Round(Conversions.ToDecimal(Strings.RSet(Strings.FormatNumber(num8), 8)), 2)) + " DH");
			Print_COM_CL("\u001ba0\u001b!\0- CREDIT        : " + Conversions.ToString(Math.Round(Conversions.ToDecimal(Strings.RSet(Strings.FormatNumber(num9), 8)), 2)) + " DH");
			Print_COM_CL("\u001ba0\u001b!\0- AVOIR         : " + Conversions.ToString(Math.Round(Conversions.ToDecimal(Strings.RSet(Strings.FormatNumber(num10), 8)), 2)) + " DH");
			Print_COM_CL("\u001ba0\u001b!\0- RETOUR        : " + Conversions.ToString(Math.Round(Conversions.ToDecimal(Strings.RSet(Strings.FormatNumber(num11), 8)), 2)) + " DH");
			Print_COM_CL("\n");
			Print_COM_CL("\n");
			Print_COM_CL("\u001ba1\u001b!\0" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
			Print_COM_CL("\n");
			Print_COM_CL("\n");
			Print_COM_CL("\n\n\u001bi\r\n\u001b@\u001bp\0.}");
			EndPrint();
			Module1._QUITTER_PATIENTER = true;
		}
	}

	public void Print_Recette_caissierGLOBALE_COM()
	{
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Expected Obj, but got Unknown
		//IL_0292: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Expected Obj, but got Unknown
		Start_Print_COM_CL();
		PrintBuffer = "";
		prn.OpenPrint(Text_PRINTER_RAPPORT.Text);
		Print_COM_CL("\u001b@\u001b!\0\r\u001bc6\u0001\u001bR3\r\n");
		Print_COM_CL("\n");
		Print_COM_CL("\u001b!8\u001ba1RAPPORT CAISSIER");
		Print_COM_CL("\n");
		Print_COM_CL("\u001b!\0\u001ba0Rapport :" + Strings.Format(DateTimePicker1.Value, "dd/MM/yyyy") + " ==> " + Strings.Format(DateTimePicker2.Value, "dd/MM/yyyy"));
		Print_COM_CL("\n");
		Print_COM_CL("\u001ba0\u001b!\0" + "-".PadRight(42, '-'));
		Print_COM_CL("\u001b!\0\r\u001bc6\u0001\u001bR3                          | Qte  | Total |");
		Print_COM_CL("\u001ba0\u001b!\0" + "-".PadRight(42, '-'));
		string text = "";
		checked
		{
			int num = DataGridView2.RowCount - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				text = Strings.LSet(DataGridView2.Rows[num2].Cells["COL_1"].Value.ToString(), 26) + Strings.RSet(DataGridView2.Rows[num2].Cells["COL_2"].Value.ToString() + "x", 6) + "  " + Strings.RSet(DataGridView2.Rows[num2].Cells["COL_3"].Value.ToString(), 8);
				Print_COM_CL("\u001b!\0\r\u001bc6\u0001\u001bR3" + text);
				num2++;
			}
			Print_COM_CL("\u001ba0\u001b!\0" + "-".PadRight(42, '-'));
			double num5 = 0.0;
			DataTable dataTable = new DataTable();
			MySqlDataAdapter val = new MySqlDataAdapter();
			dataTable.Clear();
			val = new MySqlDataAdapter("select sum(Total_NET) as n     from TABLE_VENTES_JOURNAL WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " ' ", Module1.cn_SQL);
			((DbDataAdapter)(object)val).Fill(dataTable);
			num5 = Conversions.ToDouble(Strings.FormatNumber(Conversion.Val(dataTable.Rows[0]["n"].ToString())));
			Print_COM_CL("\u001b!8\u001ba0TOTAL NET: " + Conversions.ToString(Math.Round(new decimal(num5), 2)) + " DH");
			Print_COM_CL("\u001ba0\u001b!\0" + "-".PadRight(42, '-'));
			Print_COM_CL("\n");
			Print_COM_CL("\n");
			Print_COM_CL("\n");
			Print_COM_CL("\u001ba1\u001b!\0" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
			Print_COM_CL("\n");
			Print_COM_CL("\n");
			Print_COM_CL("\n\n\u001bi\r\n\u001b@\u001bp\0.}");
			EndPrint();
			Module1._QUITTER_PATIENTER = true;
		}
	}

	public void Print_Recette_vendeur_COM()
	{
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Expected Obj, but got Unknown
		//IL_02cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d3: Expected Obj, but got Unknown
		Start_Print_COM_CL();
		PrintBuffer = "";
		prn.OpenPrint(Text_PRINTER_RAPPORT.Text);
		Print_COM_CL("\u001b@\u001b!\0\r\u001bc6\u0001\u001bR3\r\n");
		Print_COM_CL("\n");
		Print_COM_CL("\u001b!8\u001ba1RAPPORT VENDEUR");
		Print_COM_CL("\n");
		Print_COM_CL("\u001b!\0\u001ba0Vendeur :" + ListBox_VENDEURS.Text);
		Print_COM_CL("\u001b!\0\u001ba0Rapport :" + Strings.Format(DateTimePicker1.Value, "dd/MM/yyyy") + " ==> " + Strings.Format(DateTimePicker2.Value, "dd/MM/yyyy"));
		Print_COM_CL("\n");
		Print_COM_CL("\u001ba0\u001b!\0" + "-".PadRight(42, '-'));
		Print_COM_CL("\u001b!\0\r\u001bc6\u0001\u001bR3Article                   | Qte  | Total |");
		Print_COM_CL("\u001ba0\u001b!\0" + "-".PadRight(42, '-'));
		string text = "";
		checked
		{
			int num = DataGridView2.RowCount - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				text = Strings.LSet(DataGridView2.Rows[num2].Cells["COL_1"].Value.ToString(), 26) + Strings.RSet(DataGridView2.Rows[num2].Cells["COL_2"].Value.ToString() + "x", 6) + "  " + Strings.RSet(DataGridView2.Rows[num2].Cells["COL_3"].Value.ToString(), 8);
				Print_COM_CL("\u001b!\0\r\u001bc6\u0001\u001bR3" + text);
				num2++;
			}
			Print_COM_CL("\u001ba0\u001b!\0" + "-".PadRight(42, '-'));
			double num5 = 0.0;
			DataTable dataTable = new DataTable();
			MySqlDataAdapter val = new MySqlDataAdapter();
			dataTable.Clear();
			val = new MySqlDataAdapter("select sum(Total_NET) as n     from TABLE_VENTES_JOURNAL WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '        And      Vendeur like  '" + Strings.Trim(ListBox_VENDEURS.Text) + "'    ", Module1.cn_SQL);
			((DbDataAdapter)(object)val).Fill(dataTable);
			num5 = Conversions.ToDouble(Strings.FormatNumber(Conversion.Val(dataTable.Rows[0]["n"].ToString())));
			Print_COM_CL("\u001b!8\u001ba0TOTAL NET: " + Conversions.ToString(Math.Round(new decimal(num5), 2)) + " DH");
			Print_COM_CL("\u001ba0\u001b!\0" + "-".PadRight(42, '-'));
			Print_COM_CL("\n");
			Print_COM_CL("\n");
			Print_COM_CL("\n");
			Print_COM_CL("\u001ba1\u001b!\0" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
			Print_COM_CL("\n");
			Print_COM_CL("\n");
			Print_COM_CL("\n\n\u001bi\r\n\u001b@\u001bp\0.}");
			EndPrint();
			Module1._QUITTER_PATIENTER = true;
		}
	}

	public void Print_Recette_vendeurGLOBALE_COM()
	{
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Expected Obj, but got Unknown
		//IL_0292: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Expected Obj, but got Unknown
		Start_Print_COM_CL();
		PrintBuffer = "";
		prn.OpenPrint(Text_PRINTER_RAPPORT.Text);
		Print_COM_CL("\u001b@\u001b!\0\r\u001bc6\u0001\u001bR3\r\n");
		Print_COM_CL("\n");
		Print_COM_CL("\u001b!8\u001ba1RAPPORT VENDEUR");
		Print_COM_CL("\n");
		Print_COM_CL("\u001b!\0\u001ba0Rapport :" + Strings.Format(DateTimePicker1.Value, "dd/MM/yyyy") + " ==> " + Strings.Format(DateTimePicker2.Value, "dd/MM/yyyy"));
		Print_COM_CL("\n");
		Print_COM_CL("\u001ba0\u001b!\0" + "-".PadRight(42, '-'));
		Print_COM_CL("\u001b!\0\r\u001bc6\u0001\u001bR3                          | Qte  | Total |");
		Print_COM_CL("\u001ba0\u001b!\0" + "-".PadRight(42, '-'));
		string text = "";
		checked
		{
			int num = DataGridView2.RowCount - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				text = Strings.LSet(DataGridView2.Rows[num2].Cells["COL_1"].Value.ToString(), 26) + Strings.RSet(DataGridView2.Rows[num2].Cells["COL_2"].Value.ToString() + "x", 6) + "  " + Strings.RSet(DataGridView2.Rows[num2].Cells["COL_3"].Value.ToString(), 8);
				Print_COM_CL("\u001b!\0\r\u001bc6\u0001\u001bR3" + text);
				num2++;
			}
			Print_COM_CL("\u001ba0\u001b!\0" + "-".PadRight(42, '-'));
			double num5 = 0.0;
			DataTable dataTable = new DataTable();
			MySqlDataAdapter val = new MySqlDataAdapter();
			dataTable.Clear();
			val = new MySqlDataAdapter("select sum(Total_NET) as n     from TABLE_VENTES_JOURNAL WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " ' ", Module1.cn_SQL);
			((DbDataAdapter)(object)val).Fill(dataTable);
			num5 = Conversions.ToDouble(Strings.FormatNumber(Conversion.Val(dataTable.Rows[0]["n"].ToString())));
			Print_COM_CL("\u001b!8\u001ba0TOTAL NET: " + Conversions.ToString(Math.Round(new decimal(num5), 2)) + " DH");
			Print_COM_CL("\u001ba0\u001b!\0" + "-".PadRight(42, '-'));
			Print_COM_CL("\n");
			Print_COM_CL("\n");
			Print_COM_CL("\n");
			Print_COM_CL("\u001ba1\u001b!\0" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
			Print_COM_CL("\n");
			Print_COM_CL("\n");
			Print_COM_CL("\n\n\u001bi\r\n\u001b@\u001bp\0.}");
			EndPrint();
			Module1._QUITTER_PATIENTER = true;
		}
	}

	public void Print_Recette_Famille_COM()
	{
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Expected Obj, but got Unknown
		//IL_0292: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Expected Obj, but got Unknown
		Start_Print_COM_CL();
		PrintBuffer = "";
		prn.OpenPrint(Text_PRINTER_RAPPORT.Text);
		Print_COM_CL("\u001b@\u001b!\0\r\u001bc6\u0001\u001bR3\r\n");
		Print_COM_CL("\n");
		Print_COM_CL("\u001b!8\u001ba1RAPPORT FAMILLE");
		Print_COM_CL("\n");
		Print_COM_CL("\u001b!\0\u001ba0Rapport :" + Strings.Format(DateTimePicker1.Value, "dd/MM/yyyy") + " ==> " + Strings.Format(DateTimePicker2.Value, "dd/MM/yyyy"));
		Print_COM_CL("\n");
		Print_COM_CL("\u001ba0\u001b!\0" + "-".PadRight(42, '-'));
		Print_COM_CL("\u001b!\0\r\u001bc6\u0001\u001bR3Article                   | Qte  | Total |");
		Print_COM_CL("\u001ba0\u001b!\0" + "-".PadRight(42, '-'));
		string text = "";
		checked
		{
			int num = DataGridView2.RowCount - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				text = Strings.LSet(DataGridView2.Rows[num2].Cells["COL_1"].Value.ToString(), 26) + Strings.RSet(DataGridView2.Rows[num2].Cells["COL_2"].Value.ToString() + "x", 6) + "  " + Strings.RSet(DataGridView2.Rows[num2].Cells["COL_3"].Value.ToString(), 8);
				Print_COM_CL("\u001b!\0\r\u001bc6\u0001\u001bR3" + text);
				num2++;
			}
			Print_COM_CL("\u001ba0\u001b!\0" + "-".PadRight(42, '-'));
			double num5 = 0.0;
			DataTable dataTable = new DataTable();
			MySqlDataAdapter val = new MySqlDataAdapter();
			dataTable.Clear();
			val = new MySqlDataAdapter("select sum(Total_NET) as n     from TABLE_VENTES_JOURNAL WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " ' ", Module1.cn_SQL);
			((DbDataAdapter)(object)val).Fill(dataTable);
			num5 = Conversions.ToDouble(Strings.FormatNumber(Conversion.Val(dataTable.Rows[0]["n"].ToString())));
			Print_COM_CL("\u001b!8\u001ba0TOTAL NET: " + Conversions.ToString(Math.Round(new decimal(num5), 2)) + " DH");
			Print_COM_CL("\u001ba0\u001b!\0" + "-".PadRight(42, '-'));
			Print_COM_CL("\n");
			Print_COM_CL("\n");
			Print_COM_CL("\n");
			Print_COM_CL("\u001ba1\u001b!\0" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
			Print_COM_CL("\n");
			Print_COM_CL("\n");
			Print_COM_CL("\n\n\u001bi\r\n\u001b@\u001bp\0.}");
			EndPrint();
			Module1._QUITTER_PATIENTER = true;
		}
	}

	public void Print_Recette_familleGLOBALE_COM()
	{
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Expected Obj, but got Unknown
		//IL_0292: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Expected Obj, but got Unknown
		Start_Print_COM_CL();
		PrintBuffer = "";
		prn.OpenPrint(Text_PRINTER_RAPPORT.Text);
		Print_COM_CL("\u001b@\u001b!\0\r\u001bc6\u0001\u001bR3\r\n");
		Print_COM_CL("\n");
		Print_COM_CL("\u001b!8\u001ba1RAPPORT FAMILLE");
		Print_COM_CL("\n");
		Print_COM_CL("\u001b!\0\u001ba0Rapport :" + Strings.Format(DateTimePicker1.Value, "dd/MM/yyyy") + " ==> " + Strings.Format(DateTimePicker2.Value, "dd/MM/yyyy"));
		Print_COM_CL("\n");
		Print_COM_CL("\u001ba0\u001b!\0" + "-".PadRight(42, '-'));
		Print_COM_CL("\u001b!\0\r\u001bc6\u0001\u001bR3                          | Qte  | Total |");
		Print_COM_CL("\u001ba0\u001b!\0" + "-".PadRight(42, '-'));
		string text = "";
		checked
		{
			int num = DataGridView2.RowCount - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				text = Strings.LSet(DataGridView2.Rows[num2].Cells["COL_1"].Value.ToString(), 26) + Strings.RSet(DataGridView2.Rows[num2].Cells["COL_2"].Value.ToString() + "x", 6) + "  " + Strings.RSet(DataGridView2.Rows[num2].Cells["COL_3"].Value.ToString(), 8);
				Print_COM_CL("\u001b!\0\r\u001bc6\u0001\u001bR3" + text);
				num2++;
			}
			Print_COM_CL("\u001ba0\u001b!\0" + "-".PadRight(42, '-'));
			double num5 = 0.0;
			DataTable dataTable = new DataTable();
			MySqlDataAdapter val = new MySqlDataAdapter();
			dataTable.Clear();
			val = new MySqlDataAdapter("select sum(Total_NET) as n     from TABLE_VENTES_JOURNAL WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " ' ", Module1.cn_SQL);
			((DbDataAdapter)(object)val).Fill(dataTable);
			num5 = Conversions.ToDouble(Strings.FormatNumber(Conversion.Val(dataTable.Rows[0]["n"].ToString())));
			Print_COM_CL("\u001b!8\u001ba0TOTAL NET: " + Conversions.ToString(Math.Round(new decimal(num5), 2)) + " DH");
			Print_COM_CL("\u001ba0\u001b!\0" + "-".PadRight(42, '-'));
			Print_COM_CL("\n");
			Print_COM_CL("\n");
			Print_COM_CL("\n");
			Print_COM_CL("\u001ba1\u001b!\0" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
			Print_COM_CL("\n");
			Print_COM_CL("\n");
			Print_COM_CL("\n\n\u001bi\r\n\u001b@\u001bp\0.}");
			EndPrint();
			Module1._QUITTER_PATIENTER = true;
		}
	}

	public void Print_Recette_Client_COM()
	{
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Expected Obj, but got Unknown
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02db: Expected Obj, but got Unknown
		//IL_037e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0384: Expected Obj, but got Unknown
		//IL_05f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fa: Expected Obj, but got Unknown
		Start_Print_COM_CL();
		PrintBuffer = "";
		prn.OpenPrint(Text_PRINTER_RAPPORT.Text);
		Print_COM_CL("\u001b@\u001b!\0\r\u001bc6\u0001\u001bR3\r\n");
		Print_COM_CL("\n");
		Print_COM_CL("\u001b!8\u001ba1RAPPORT CLIENT");
		Print_COM_CL("\n");
		Print_COM_CL("\u001b!\0\u001ba0CLIENT  :" + ListBox_CLIENTS.Text);
		Print_COM_CL("\u001b!\0\u001ba0Rapport :" + Strings.Format(DateTimePicker1.Value, "dd/MM/yyyy") + " ==> " + Strings.Format(DateTimePicker2.Value, "dd/MM/yyyy"));
		Print_COM_CL("\n");
		Print_COM_CL("\u001ba0\u001b!\0" + "-".PadRight(42, '-'));
		Print_COM_CL("\u001b!\0\r\u001bc6\u0001\u001bR3Article                   | Qte  | Total |");
		Print_COM_CL("\u001ba0\u001b!\0" + "-".PadRight(42, '-'));
		string text = "";
		checked
		{
			int num = DataGridView2.RowCount - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				text = Strings.LSet(DataGridView2.Rows[num2].Cells["COL_1"].Value.ToString(), 26) + Strings.RSet(DataGridView2.Rows[num2].Cells["COL_2"].Value.ToString() + "x", 6) + "  " + Strings.RSet(DataGridView2.Rows[num2].Cells["COL_3"].Value.ToString(), 8);
				Print_COM_CL("\u001b!\0\r\u001bc6\u0001\u001bR3" + text);
				num2++;
			}
			Print_COM_CL("\u001ba0\u001b!\0" + "-".PadRight(42, '-'));
			double num5 = 0.0;
			DataTable dataTable = new DataTable();
			MySqlDataAdapter val = new MySqlDataAdapter();
			dataTable.Clear();
			val = new MySqlDataAdapter("select sum(Total_NET) as n     from TABLE_VENTES_JOURNAL WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '        And     Client like  '" + Strings.Trim(ListBox_CLIENTS.Text) + "'    ", Module1.cn_SQL);
			((DbDataAdapter)(object)val).Fill(dataTable);
			num5 = Conversions.ToDouble(Strings.FormatNumber(Conversion.Val(dataTable.Rows[0]["n"].ToString())));
			Print_COM_CL("\u001b!8\u001ba0TOTAL NET: " + Conversions.ToString(Math.Round(new decimal(num5), 2)) + " DH");
			Print_COM_CL("\u001ba0\u001b!\0" + "-".PadRight(42, '-'));
			Print_COM_CL("\n");
			Print_COM_CL("\u001ba0\u001b!\0---------------FINANCE----------------");
			MySqlDataAdapter val2 = new MySqlDataAdapter();
			DataTable dataTable2 = new DataTable();
			val2 = new MySqlDataAdapter("(select sum(MONTANT) as n     from    TABLE_VENTES_REGLEMENTS     WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '             And     Client like  '" + Strings.Trim(ListBox_CLIENTS.Text) + "'                  And     MODE_P  = 'ESPECES'  )      UNION ALL        (select sum(MONTANT) as n from TABLE_VENTES_REGLEMENTS  WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '               And      Client like  '" + Strings.Trim(ListBox_CLIENTS.Text) + "'                And     MODE_P  = 'CARTE'  )       UNION ALL        (select sum(MONTANT) as n from   TABLE_VENTES_REGLEMENTS   WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '              And     Client like  '" + Strings.Trim(ListBox_CLIENTS.Text) + "'                And     MODE_P  = 'CHEQUE'  )     UNION ALL        (select sum(MONTANT) as n from   TABLE_VENTES_REGLEMENTS   WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '              And     Client like  '" + Strings.Trim(ListBox_CLIENTS.Text) + "'                 And     MODE_P  = 'CREDIT'  )       UNION ALL        (select sum(MONTANT) as n from   TABLE_VENTES_REGLEMENTS   WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '              And     Client like  '" + Strings.Trim(ListBox_CLIENTS.Text) + "'                 And     MODE_P  = 'AVOIR'  )  ", Module1.cn_SQL);
			dataTable2 = new DataTable();
			dataTable2.Clear();
			((DbDataAdapter)(object)val2).Fill(dataTable2);
			double num6 = Conversion.Val(dataTable2.Rows[0]["n"].ToString());
			double num7 = Conversion.Val(dataTable2.Rows[1]["n"].ToString());
			double num8 = Conversion.Val(dataTable2.Rows[2]["n"].ToString());
			double num9 = Conversion.Val(dataTable2.Rows[3]["n"].ToString());
			double num10 = Conversion.Val(dataTable2.Rows[4]["n"].ToString());
			double num11 = Conversion.Val(dataTable2.Rows[5]["n"].ToString());
			Print_COM_CL("\u001ba0\u001b!\0- ESPECES       : " + Conversions.ToString(Math.Round(Conversions.ToDecimal(Strings.RSet(Strings.FormatNumber(num6), 8)), 2)) + " DH");
			Print_COM_CL("\u001ba0\u001b!\0- CARTE         : " + Conversions.ToString(Math.Round(Conversions.ToDecimal(Strings.RSet(Strings.FormatNumber(num7), 8)), 2)) + " DH");
			Print_COM_CL("\u001ba0\u001b!\0- CHEQUE        : " + Conversions.ToString(Math.Round(Conversions.ToDecimal(Strings.RSet(Strings.FormatNumber(num8), 8)), 2)) + " DH");
			Print_COM_CL("\u001ba0\u001b!\0- CREDIT        : " + Conversions.ToString(Math.Round(Conversions.ToDecimal(Strings.RSet(Strings.FormatNumber(num9), 8)), 2)) + " DH");
			Print_COM_CL("\u001ba0\u001b!\0- AVOIR         : " + Conversions.ToString(Math.Round(Conversions.ToDecimal(Strings.RSet(Strings.FormatNumber(num10), 8)), 2)) + " DH");
			Print_COM_CL("\u001ba0\u001b!\0- RETOUR        : " + Conversions.ToString(Math.Round(Conversions.ToDecimal(Strings.RSet(Strings.FormatNumber(num11), 8)), 2)) + " DH");
			Print_COM_CL("\n");
			Print_COM_CL("\n");
			Print_COM_CL("\u001ba1\u001b!\0" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
			Print_COM_CL("\n");
			Print_COM_CL("\n");
			Print_COM_CL("\n\n\u001bi\r\n\u001b@\u001bp\0.}");
			EndPrint();
			Module1._QUITTER_PATIENTER = true;
		}
	}

	public void Print_Recette_clientGLOBALE_COM()
	{
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Expected Obj, but got Unknown
		//IL_0292: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Expected Obj, but got Unknown
		Start_Print_COM_CL();
		PrintBuffer = "";
		prn.OpenPrint(Text_PRINTER_RAPPORT.Text);
		Print_COM_CL("\u001b@\u001b!\0\r\u001bc6\u0001\u001bR3\r\n");
		Print_COM_CL("\n");
		Print_COM_CL("\u001b!8\u001ba1RAPPORT CLIENT");
		Print_COM_CL("\n");
		Print_COM_CL("\u001b!\0\u001ba0Rapport :" + Strings.Format(DateTimePicker1.Value, "dd/MM/yyyy") + " ==> " + Strings.Format(DateTimePicker2.Value, "dd/MM/yyyy"));
		Print_COM_CL("\n");
		Print_COM_CL("\u001ba0\u001b!\0" + "-".PadRight(42, '-'));
		Print_COM_CL("\u001b!\0\r\u001bc6\u0001\u001bR3                          | Qte  | Total |");
		Print_COM_CL("\u001ba0\u001b!\0" + "-".PadRight(42, '-'));
		string text = "";
		checked
		{
			int num = DataGridView2.RowCount - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				text = Strings.LSet(DataGridView2.Rows[num2].Cells["COL_1"].Value.ToString(), 26) + Strings.RSet(DataGridView2.Rows[num2].Cells["COL_2"].Value.ToString() + "x", 6) + "  " + Strings.RSet(DataGridView2.Rows[num2].Cells["COL_3"].Value.ToString(), 8);
				Print_COM_CL("\u001b!\0\r\u001bc6\u0001\u001bR3" + text);
				num2++;
			}
			Print_COM_CL("\u001ba0\u001b!\0" + "-".PadRight(42, '-'));
			double num5 = 0.0;
			DataTable dataTable = new DataTable();
			MySqlDataAdapter val = new MySqlDataAdapter();
			dataTable.Clear();
			val = new MySqlDataAdapter("select sum(Total_NET) as n     from TABLE_VENTES_JOURNAL WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " ' ", Module1.cn_SQL);
			((DbDataAdapter)(object)val).Fill(dataTable);
			num5 = Conversions.ToDouble(Strings.FormatNumber(Conversion.Val(dataTable.Rows[0]["n"].ToString())));
			Print_COM_CL("\u001b!8\u001ba0TOTAL NET: " + Conversions.ToString(Math.Round(new decimal(num5), 2)) + " DH");
			Print_COM_CL("\u001ba0\u001b!\0" + "-".PadRight(42, '-'));
			Print_COM_CL("\n");
			Print_COM_CL("\n");
			Print_COM_CL("\n");
			Print_COM_CL("\u001ba1\u001b!\0" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
			Print_COM_CL("\n");
			Print_COM_CL("\n");
			Print_COM_CL("\n\n\u001bi\r\n\u001b@\u001bp\0.}");
			EndPrint();
			Module1._QUITTER_PATIENTER = true;
		}
	}

	private void Form_1_LOGIN_HandleCreated(object sender, EventArgs e)
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected Obj, but got Unknown
		if (Operators.CompareString(MyProject.Forms.Form_0_TEMPLATE.Label_LANGUE.Text, "ar", TextCompare: false) == 0)
		{
			Thread.CurrentThread.CurrentUICulture = new CultureInfo("ar");
			((Control)this).Controls.Clear();
			InitializeComponent();
			((Control)TabControlEx1).Font = new Font("Segoe UI", 14f, (FontStyle)1);
		}
	}

	private void Form_journal_Load(object sender, EventArgs e)
	{
		//IL_0a79: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a80: Expected Obj, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected Obj, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected Obj, but got Unknown
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected Obj, but got Unknown
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Expected Obj, but got Unknown
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Expected Obj, but got Unknown
		//IL_041a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0424: Expected Obj, but got Unknown
		//IL_043b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0445: Expected Obj, but got Unknown
		//IL_0844: Unknown result type (might be due to invalid IL or missing references)
		//IL_084e: Expected Obj, but got Unknown
		checked
		{
			try
			{
				Combo_FIND.SelectedIndex = 0;
				DateTime1_FIND.Text = "01/01/2000";
				DateTime2_FIND.Text = Conversions.ToString(DateTime.Now.Date);
				((Control)TableLayoutPanel1).Dock = (DockStyle)5;
				if (Conversions.ToBoolean(MyProject.Forms.Form_0_TEMPLATE.TextBox_MODE_WINDOWS.Text))
				{
					((ButtonBase)Button244).Image = MyProject.Forms.Form_0_TEMPLATE.PictureBox_SORTIE.Image;
				}
				DataTable dataTable = new DataTable();
				MySqlDataAdapter val = new MySqlDataAdapter();
				dataTable.Clear();
				val = new MySqlDataAdapter("select * from TABLE_PASS  order by ID asc", Module1.cn_SQL);
				((DbDataAdapter)(object)val).Fill(dataTable);
				ListBox_CAISSIERS.Items.Clear();
				ListBox_CAISSIERS.Items.Add((object)"GLOBALE CAISSIERS");
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
					ListBox_CAISSIERS.Items.Add((object)dataTable.Rows[num2]["ListUser"].ToString());
					num2++;
				}
				dataTable.Clear();
				val = new MySqlDataAdapter("select * from TABLE_PASS  where  Catégorie = 'UTILISATEUR'   order by ID asc", Module1.cn_SQL);
				((DbDataAdapter)(object)val).Fill(dataTable);
				ListBox_VENDEURS.Items.Clear();
				ListBox_VENDEURS.Items.Add((object)"GLOBALE VENDEURS");
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
					ListBox_VENDEURS.Items.Add((object)dataTable.Rows[num6]["ListUser"].ToString());
					num6++;
				}
				dataTable.Clear();
				val = new MySqlDataAdapter("select * from TABLE_FAMILLES order by Ordre asc", Module1.cn_SQL);
				((DbDataAdapter)(object)val).Fill(dataTable);
				ListBox_FAMILLES.Items.Clear();
				ListBox_FAMILLES.Items.Add((object)"GLOBALE FAMILLES");
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
					ListBox_FAMILLES.Items.Add((object)dataTable.Rows[num9]["Famille"].ToString());
					num9++;
				}
				dataTable.Clear();
				val = new MySqlDataAdapter("select * from TABLE_CLIENTS  order by ID asc", Module1.cn_SQL);
				((DbDataAdapter)(object)val).Fill(dataTable);
				ListBox_CLIENTS.Items.Clear();
				ListBox_CLIENTS.Items.Add((object)"GLOBALE CLIENTS");
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
					ListBox_CLIENTS.Items.Add((object)dataTable.Rows[num12]["CLIENT"].ToString());
					num12++;
				}
				ListBox_RAPPORT_GLOBALE.SelectedIndex = 0;
				ListBox_CAISSIERS.SelectedIndex = 0;
				ListBox_VENDEURS.SelectedIndex = 0;
				ListBox_FAMILLES.SelectedIndex = 0;
				ListBox_CLIENTS.SelectedIndex = 0;
				DataGridView1.AutoGenerateColumns = false;
				DataGridView1.RowTemplate.Height = 25;
				DataGridView1.DataSource = DT;
				DataGridView1.BackgroundColor = Color.White;
				DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(34, 34, 34);
				DataGridView1.DefaultCellStyle.SelectionBackColor = Color.Yellow;
				DataGridView1.DefaultCellStyle.SelectionForeColor = Color.Red;
				DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(221, 235, 247);
				DataGridView1.GridColor = Color.FromArgb(231, 231, 231);
				DataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9f, (FontStyle)1);
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
				int num14 = ((BaseCollection)DataGridView1.Columns).Count - 1;
				int num15 = 0;
				while (true)
				{
					int num16 = num15;
					int num4 = num14;
					if (num16 > num4)
					{
						break;
					}
					DataGridView1.Columns[num15].SortMode = (DataGridViewColumnSortMode)2;
					num15++;
				}
				DataGridView1.AllowUserToAddRows = false;
				DataGridView1.AllowUserToDeleteRows = false;
				DataGridView1.AllowUserToOrderColumns = true;
				DataGridView1.AllowUserToResizeColumns = true;
				DataGridView1.AllowUserToResizeRows = false;
				Text_mail.Text = MyProject.Forms.Form_0_TEMPLATE.ListView1.Items[MyProject.Forms.Form_0_TEMPLATE.ListView1.FindItemWithText("MAIL_ADRESSE", false, 0).Index].SubItems[1].Text;
				Text_MAIL_TITRE.Text = MyProject.Forms.Form_0_TEMPLATE.ListView1.Items[MyProject.Forms.Form_0_TEMPLATE.ListView1.FindItemWithText("MAIL_TITRE", false, 0).Index].SubItems[1].Text;
				int num17 = (int)Math.Round(Conversion.Val(MyProject.Forms.Form_0_TEMPLATE.ListView1.Items[MyProject.Forms.Form_0_TEMPLATE.ListView1.FindItemWithText("HEURE_RETARD", false, 0).Index].SubItems[1].Text));
				if (num17 != 0)
				{
					DataGridView1.Columns[2].HeaderText = "Heure(-" + Conversions.ToString(num17) + ")";
					if (DataGridView1.Rows.Count == 0)
					{
						Timer1.Enabled = true;
					}
				}
				Text_PRINTER_RAPPORT.Text = File.ReadAllText(Application.StartupPath + "/PRINTER_RAPPORT.sni");
				if (Conversions.ToBoolean(MyProject.Forms.Form_0_TEMPLATE.ListView1.Items[MyProject.Forms.Form_0_TEMPLATE.ListView1.FindItemWithText("GESTION_CLOTURE", false, 0).Index].SubItems[1].Text))
				{
					((Control)Panel_CLOTURE).Visible = true;
					((Control)Panel_CLOTURE).BringToFront();
					((Form)MyProject.Forms.FormDialog_CLOTURE).Close();
					((Form)MyProject.Forms.FormDialog_CLOTURE).TopLevel = false;
					((Control)Panel_CLOTURE).Controls.Clear();
					((Control)Panel_CLOTURE).Controls.Add((Control)(object)MyProject.Forms.FormDialog_CLOTURE);
					((Control)MyProject.Forms.FormDialog_CLOTURE).Show();
					((Control)MyProject.Forms.FormDialog_CLOTURE).Height = ((Control)Panel_CLOTURE).Height;
					MyProject.Forms.FormDialog_CLOTURE.Button_TOTAL_GLOBALE.PerformClick();
				}
				else
				{
					DT.Clear();
					DA = new MySqlDataAdapter("select * from   TABLE_VENTES_JOURNAL     Where  Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '    order by ID desc ", Module1.cn_SQL);
					((DbDataAdapter)(object)DA).Fill(DT);
				}
				DataGridView1.ClearSelection();
				try
				{
					string filePath = "zappSettings.json";
					SettingsManager settingsManager = new SettingsManager(filePath);
					List<Control> list = new List<Control>();
					list.Add((Control)(object)ListBox_RAPPORT_GLOBALE);
					List<Control> controls = list;
					settingsManager.LoadControls(((Control)this).Name, controls);
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					string text = Strings.Format(DateTime.Now, "yyMMddHHmmssfff");
					string right = "ERROR | ";
					File.AppendAllText(Application.StartupPath + "\\log_erreur.sni", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(text + " | ", MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text), " | "), Module1._USERNAME), " | "), ((Control)this).Name), " | "), NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null)), " | "), right), " | "), ex2.ToString()), "\r\n"), "Ligne : "), ""), "\r\n"), "\r\n"), "##########################################################################################################"), "\r\n")), Encoding.UTF8);
					ProjectData.ClearProjectError();
				}
				FUN_CAT_ACCES();
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				StackTrace stackTrace = new StackTrace(ex4, fNeedFileInfo: true);
				StackFrame frame = stackTrace.GetFrame(stackTrace.FrameCount - 1);
				int fileLineNumber = frame.GetFileLineNumber();
				Interaction.MsgBox(ex4.Message + "\r\nLigne : " + Conversions.ToString(fileLineNumber) + "\r\n");
				try
				{
					string text2 = Strings.Format(DateTime.Now, "yyMMddHHmmssfff");
					Bitmap val2 = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, (PixelFormat)2498570);
					Graphics val3 = Graphics.FromImage((Image)(object)val2);
					val3.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, (CopyPixelOperation)13369376);
					((Image)val2).Save(Application.StartupPath + "\\tchak\\" + text2 + ".snidb", ImageFormat.Jpeg);
					val2 = null;
					string right2 = "ERROR | ";
					File.AppendAllText(Application.StartupPath + "\\log_erreur.sni", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(text2 + " | ", MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text), " | "), Module1._USERNAME), " | "), ((Control)this).Name), " | "), NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null)), " | "), right2), " | "), ex4.ToString()), "\r\n"), "Ligne : "), fileLineNumber), "\r\n"), "\r\n"), "##########################################################################################################"), "\r\n")), Encoding.UTF8);
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

	private void Form_3_VENTE_JOURNAL_Shown(object sender, EventArgs e)
	{
		_COLORISE_DATAGRID();
	}

	private void Button244_Click(object sender, EventArgs e)
	{
		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Expected Obj, but got Unknown
		try
		{
			DT.Clear();
			try
			{
				string filePath = "zappSettings.json";
				SettingsManager settingsManager = new SettingsManager(filePath);
				List<Control> list = new List<Control>();
				list.Add((Control)(object)ListBox_RAPPORT_GLOBALE);
				List<Control> controls = list;
				settingsManager.SaveControls(((Control)this).Name, controls);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				string text = Strings.Format(DateTime.Now, "yyMMddHHmmssfff");
				string right = "ERROR | ";
				File.AppendAllText(Application.StartupPath + "\\log_erreur.sni", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(text + " | ", MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text), " | "), Module1._USERNAME), " | "), ((Control)this).Name), " | "), NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null)), " | "), right), " | "), ex2.ToString()), "\r\n"), "Ligne : "), ""), "\r\n"), "\r\n"), "##########################################################################################################"), "\r\n")), Encoding.UTF8);
				ProjectData.ClearProjectError();
			}
			((Form)MyProject.Forms.Form_1_LOGIN).Close();
			((Form)MyProject.Forms.Form_1_LOGIN).TopLevel = false;
			((Control)MyProject.Forms.Form_0_TEMPLATE.Panel_HOME).Controls.Clear();
			((Control)MyProject.Forms.Form_0_TEMPLATE.Panel_HOME).Controls.Add((Control)(object)MyProject.Forms.Form_1_LOGIN);
			((Control)MyProject.Forms.Form_1_LOGIN).Show();
			((Control)MyProject.Forms.Form_1_LOGIN.Panel_menu).BringToFront();
			((Control)MyProject.Forms.Form_1_LOGIN.Panel_menu).Show();
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			StackTrace stackTrace = new StackTrace(ex4, fNeedFileInfo: true);
			StackFrame frame = stackTrace.GetFrame(checked(stackTrace.FrameCount - 1));
			int fileLineNumber = frame.GetFileLineNumber();
			Interaction.MsgBox(ex4.Message + "\r\nLigne : " + Conversions.ToString(fileLineNumber) + "\r\n");
			try
			{
				string text2 = Strings.Format(DateTime.Now, "yyMMddHHmmssfff");
				Bitmap val = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, (PixelFormat)2498570);
				Graphics val2 = Graphics.FromImage((Image)(object)val);
				val2.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, (CopyPixelOperation)13369376);
				((Image)val).Save(Application.StartupPath + "\\tchak\\" + text2 + ".snidb", ImageFormat.Jpeg);
				val = null;
				string right2 = "ERROR | ";
				File.AppendAllText(Application.StartupPath + "\\log_erreur.sni", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(text2 + " | ", MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text), " | "), Module1._USERNAME), " | "), ((Control)this).Name), " | "), NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null)), " | "), right2), " | "), ex4.ToString()), "\r\n"), "Ligne : "), fileLineNumber), "\r\n"), "\r\n"), "##########################################################################################################"), "\r\n")), Encoding.UTF8);
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
		//IL_075f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0766: Expected Obj, but got Unknown
		//IL_038f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Expected Obj, but got Unknown
		//IL_040e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0415: Expected Obj, but got Unknown
		//IL_046e: Unknown result type (might be due to invalid IL or missing references)
		//IL_049c: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a6: Expected Obj, but got Unknown
		//IL_04a6: Expected Obj, but got Unknown
		//IL_04da: Unknown result type (might be due to invalid IL or missing references)
		//IL_0508: Unknown result type (might be due to invalid IL or missing references)
		//IL_0512: Expected Obj, but got Unknown
		//IL_0512: Expected Obj, but got Unknown
		//IL_0529: Unknown result type (might be due to invalid IL or missing references)
		//IL_0557: Unknown result type (might be due to invalid IL or missing references)
		//IL_0561: Expected Obj, but got Unknown
		//IL_0561: Expected Obj, but got Unknown
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0359: Unknown result type (might be due to invalid IL or missing references)
		//IL_0363: Expected Obj, but got Unknown
		//IL_0363: Expected Obj, but got Unknown
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Expected Obj, but got Unknown
		//IL_0281: Expected Obj, but got Unknown
		//IL_05d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0600: Unknown result type (might be due to invalid IL or missing references)
		//IL_060a: Expected Obj, but got Unknown
		//IL_060a: Expected Obj, but got Unknown
		//IL_062f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0662: Unknown result type (might be due to invalid IL or missing references)
		//IL_066c: Expected Obj, but got Unknown
		//IL_06b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06be: Expected Obj, but got Unknown
		//IL_06be: Expected Obj, but got Unknown
		checked
		{
			try
			{
				e.Graphics.FillRectangle((Brush)new SolidBrush(Color.Black), 0, 0, 260, 20);
				string text = "RAPPORT GLOBALE";
				e.Graphics.DrawString(text, new Font("Inconsolata Condensed", 13f, (FontStyle)1), Brushes.White, Convert.ToSingle(130f - e.Graphics.MeasureString(text, new Font("Inconsolata Condensed", 13f, (FontStyle)1)).Width / 2f), 0f, new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("Rapport :" + Strings.Format(DateTimePicker1.Value, "dd/MM/yyyy") + " ==> " + Strings.Format(DateTimePicker2.Value, "dd/MM/yyyy"), new Font("Inconsolata Condensed", 10f, (FontStyle)1), Brushes.Black, 0f, 80f, new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("-----------------------------------------", new Font("Inconsolata Condensed", 11f, (FontStyle)0), Brushes.Black, 0f, 100f, new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("Article                  Qté    TOTAL_NET  ", new Font("Inconsolata Condensed", 11f, (FontStyle)1), Brushes.Black, 0f, 110f, new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("-----------------------------------------", new Font("Inconsolata Condensed", 11f, (FontStyle)0), Brushes.Black, 0f, 120f, new StringFormat((StringFormatFlags)8192));
				string text2 = "";
				int num = 0;
				int num2 = DataGridView2.RowCount - 1;
				int num3 = 0;
				while (true)
				{
					int num4 = num3;
					int num5 = num2;
					if (num4 > num5)
					{
						break;
					}
					if (Operators.ConditionalCompareObjectEqual(DataGridView2.Rows[num3].Cells["COL_2"].Value, ".", TextCompare: false))
					{
						text2 = Strings.LSet(DataGridView2.Rows[num3].Cells["COL_1"].Value.ToString().PadRight(33, '-'), 33);
						e.Graphics.DrawString(text2, new Font("Inconsolata ExtraBold", 11f, (FontStyle)1), Brushes.Black, 0f, (float)(120 + num * 16 + 10), new StringFormat((StringFormatFlags)8192));
					}
					else
					{
						text2 = Strings.LSet(Conversions.ToString(DataGridView2.Rows[num3].Cells["COL_1"].Value), 26) + Strings.RSet(Conversions.ToString(DataGridView2.Rows[num3].Cells["COL_2"].Value), 6) + " " + Strings.RSet(Conversions.ToString(DataGridView2.Rows[num3].Cells["COL_3"].Value), 12);
						e.Graphics.DrawString(text2, new Font("Inconsolata Condensed", 10f, (FontStyle)1), Brushes.Black, 0f, (float)(120 + num * 16 + 10), new StringFormat((StringFormatFlags)8192));
					}
					num++;
					num3++;
				}
				double num6 = 0.0;
				DataTable dataTable = new DataTable();
				MySqlDataAdapter val = new MySqlDataAdapter();
				dataTable.Clear();
				val = new MySqlDataAdapter("select sum(Total_NET) as n     from TABLE_VENTES_JOURNAL WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '                     and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')          ", Module1.cn_SQL);
				((DbDataAdapter)(object)val).Fill(dataTable);
				num6 = Conversions.ToDouble(Strings.FormatNumber(Conversion.Val(dataTable.Rows[0]["n"].ToString())));
				e.Graphics.DrawString("-----------------------------------------", new Font("Inconsolata Condensed", 11f, (FontStyle)0), Brushes.Black, 0f, (float)(DataGridView2.Rows.Count * 16 + 130), new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("TOTAL NET: " + Strings.RSet(Conversions.ToString(num6) + " DH", 12), new Font("Inconsolata ExtraBold", 16f, (FontStyle)1), Brushes.Black, 0f, (float)(DataGridView2.Rows.Count * 16 + 140), new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("-----------------------------------------", new Font("Inconsolata Condensed", 11f, (FontStyle)0), Brushes.Black, 0f, (float)(DataGridView2.Rows.Count * 16 + 160), new StringFormat((StringFormatFlags)8192));
				string text3 = "";
				int num7 = DataGridView3.RowCount - 1;
				int num8 = 0;
				while (true)
				{
					int num9 = num8;
					int num5 = num7;
					if (num9 > num5)
					{
						break;
					}
					text3 = text3 + DataGridView3.Rows[num8].Cells[0].Value.ToString() + Environment.NewLine;
					num8++;
				}
				e.Graphics.DrawString(text3, new Font("Inconsolata Condensed", 11f, (FontStyle)1), Brushes.Black, 0f, (float)(DataGridView2.Rows.Count * 16 + 170), new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"), new Font("Inconsolata Condensed", 8f, (FontStyle)1), Brushes.Black, Convert.ToSingle(130f - e.Graphics.MeasureString(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"), new Font("Inconsolata Condensed", 8f, (FontStyle)1)).Width / 2f), (float)(DataGridView2.Rows.Count * 16 + 170 + DataGridView3.Rows.Count * 16), new StringFormat((StringFormatFlags)8192));
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

	private void Print_Recette_caissier_PrintPage(object sender, PrintPageEventArgs e)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected Obj, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected Obj, but got Unknown
		//IL_008d: Expected Obj, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected Obj, but got Unknown
		//IL_00d7: Expected Obj, but got Unknown
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected Obj, but got Unknown
		//IL_014f: Expected Obj, but got Unknown
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Expected Obj, but got Unknown
		//IL_0189: Expected Obj, but got Unknown
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected Obj, but got Unknown
		//IL_01c3: Expected Obj, but got Unknown
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Expected Obj, but got Unknown
		//IL_01fd: Expected Obj, but got Unknown
		//IL_07c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07cf: Expected Obj, but got Unknown
		//IL_03d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e0: Expected Obj, but got Unknown
		//IL_0477: Unknown result type (might be due to invalid IL or missing references)
		//IL_047e: Expected Obj, but got Unknown
		//IL_04d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0505: Unknown result type (might be due to invalid IL or missing references)
		//IL_050f: Expected Obj, but got Unknown
		//IL_050f: Expected Obj, but got Unknown
		//IL_0543: Unknown result type (might be due to invalid IL or missing references)
		//IL_0571: Unknown result type (might be due to invalid IL or missing references)
		//IL_057b: Expected Obj, but got Unknown
		//IL_057b: Expected Obj, but got Unknown
		//IL_0592: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ca: Expected Obj, but got Unknown
		//IL_05ca: Expected Obj, but got Unknown
		//IL_0384: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ad: Expected Obj, but got Unknown
		//IL_03ad: Expected Obj, but got Unknown
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Expected Obj, but got Unknown
		//IL_02cb: Expected Obj, but got Unknown
		//IL_063b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0669: Unknown result type (might be due to invalid IL or missing references)
		//IL_0673: Expected Obj, but got Unknown
		//IL_0673: Expected Obj, but got Unknown
		//IL_0698: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d5: Expected Obj, but got Unknown
		//IL_071d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0727: Expected Obj, but got Unknown
		//IL_0727: Expected Obj, but got Unknown
		checked
		{
			try
			{
				e.Graphics.FillRectangle((Brush)new SolidBrush(Color.Black), 0, 0, 260, 20);
				string text = "RAPPORT CAISSIER";
				e.Graphics.DrawString(text, new Font("Inconsolata Condensed", 13f, (FontStyle)1), Brushes.White, Convert.ToSingle(130f - e.Graphics.MeasureString(text, new Font("Inconsolata Condensed", 13f, (FontStyle)1)).Width / 2f), 0f, new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("Caissier: " + ListBox_CAISSIERS.Text, new Font("Inconsolata Condensed", 10f, (FontStyle)1), Brushes.Black, 0f, 85f, new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("Rapport :" + Strings.Format(DateTimePicker1.Value, "dd/MM/yyyy") + " ==> " + Strings.Format(DateTimePicker2.Value, "dd/MM/yyyy"), new Font("Inconsolata Condensed", 10f, (FontStyle)1), Brushes.Black, 0f, 95f, new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("-----------------------------------------", new Font("Inconsolata Condensed", 11f, (FontStyle)0), Brushes.Black, 0f, 100f, new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("Article                  Qté    TOTAL_NET  ", new Font("Inconsolata Condensed", 11f, (FontStyle)1), Brushes.Black, 0f, 110f, new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("-----------------------------------------", new Font("Inconsolata Condensed", 11f, (FontStyle)0), Brushes.Black, 0f, 120f, new StringFormat((StringFormatFlags)8192));
				string text2 = "";
				int num = 0;
				int num2 = DataGridView2.RowCount - 1;
				int num3 = 0;
				while (true)
				{
					int num4 = num3;
					int num5 = num2;
					if (num4 > num5)
					{
						break;
					}
					if (Operators.ConditionalCompareObjectEqual(DataGridView2.Rows[num3].Cells["COL_2"].Value, ".", TextCompare: false))
					{
						text2 = Strings.LSet(DataGridView2.Rows[num3].Cells["COL_1"].Value.ToString().PadRight(33, '-'), 33);
						e.Graphics.DrawString(text2, new Font("Inconsolata ExtraBold", 11f, (FontStyle)1), Brushes.Black, 0f, (float)(120 + num * 16 + 10), new StringFormat((StringFormatFlags)8192));
					}
					else
					{
						text2 = Strings.LSet(Conversions.ToString(DataGridView2.Rows[num3].Cells["COL_1"].Value), 26) + Strings.RSet(Conversions.ToString(DataGridView2.Rows[num3].Cells["COL_2"].Value), 6) + " " + Strings.RSet(Conversions.ToString(DataGridView2.Rows[num3].Cells["COL_3"].Value), 12);
						e.Graphics.DrawString(text2, new Font("Inconsolata Condensed", 10f, (FontStyle)1), Brushes.Black, 0f, (float)(120 + num * 16 + 10), new StringFormat((StringFormatFlags)8192));
					}
					num++;
					num3++;
				}
				double num6 = 0.0;
				DataTable dataTable = new DataTable();
				MySqlDataAdapter val = new MySqlDataAdapter();
				dataTable.Clear();
				val = new MySqlDataAdapter("select sum(Total_NET) as n     from TABLE_VENTES_JOURNAL WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '        And     Caissier like  '" + Strings.Trim(ListBox_CAISSIERS.Text) + "'         and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')       ", Module1.cn_SQL);
				((DbDataAdapter)(object)val).Fill(dataTable);
				num6 = Conversions.ToDouble(Strings.FormatNumber(Conversion.Val(dataTable.Rows[0]["n"].ToString())));
				e.Graphics.DrawString("-----------------------------------------", new Font("Inconsolata Condensed", 11f, (FontStyle)0), Brushes.Black, 0f, (float)(DataGridView2.Rows.Count * 16 + 130), new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("TOTAL NET: " + Strings.RSet(Conversions.ToString(num6) + " DH", 12), new Font("Inconsolata ExtraBold", 16f, (FontStyle)1), Brushes.Black, 0f, (float)(DataGridView2.Rows.Count * 16 + 140), new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("-----------------------------------------", new Font("Inconsolata Condensed", 11f, (FontStyle)0), Brushes.Black, 0f, (float)(DataGridView2.Rows.Count * 16 + 160), new StringFormat((StringFormatFlags)8192));
				string text3 = "";
				int num7 = DataGridView3.RowCount - 1;
				int num8 = 0;
				while (true)
				{
					int num9 = num8;
					int num5 = num7;
					if (num9 > num5)
					{
						break;
					}
					text3 = text3 + DataGridView3.Rows[num8].Cells[0].Value.ToString() + Environment.NewLine;
					num8++;
				}
				e.Graphics.DrawString(text3, new Font("Inconsolata Condensed", 11f, (FontStyle)1), Brushes.Black, 0f, (float)(DataGridView2.Rows.Count * 16 + 170), new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"), new Font("Inconsolata Condensed", 8f, (FontStyle)1), Brushes.Black, Convert.ToSingle(130f - e.Graphics.MeasureString(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"), new Font("Inconsolata Condensed", 8f, (FontStyle)1)).Width / 2f), (float)(DataGridView2.Rows.Count * 16 + 170 + DataGridView3.Rows.Count * 16), new StringFormat((StringFormatFlags)8192));
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

	private void Print_Recette_caissierGLOBALE_PrintPage(object sender, PrintPageEventArgs e)
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
		//IL_075f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0766: Expected Obj, but got Unknown
		//IL_038f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Expected Obj, but got Unknown
		//IL_040e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0415: Expected Obj, but got Unknown
		//IL_046e: Unknown result type (might be due to invalid IL or missing references)
		//IL_049c: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a6: Expected Obj, but got Unknown
		//IL_04a6: Expected Obj, but got Unknown
		//IL_04da: Unknown result type (might be due to invalid IL or missing references)
		//IL_0508: Unknown result type (might be due to invalid IL or missing references)
		//IL_0512: Expected Obj, but got Unknown
		//IL_0512: Expected Obj, but got Unknown
		//IL_0529: Unknown result type (might be due to invalid IL or missing references)
		//IL_0557: Unknown result type (might be due to invalid IL or missing references)
		//IL_0561: Expected Obj, but got Unknown
		//IL_0561: Expected Obj, but got Unknown
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0359: Unknown result type (might be due to invalid IL or missing references)
		//IL_0363: Expected Obj, but got Unknown
		//IL_0363: Expected Obj, but got Unknown
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Expected Obj, but got Unknown
		//IL_0281: Expected Obj, but got Unknown
		//IL_05d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0600: Unknown result type (might be due to invalid IL or missing references)
		//IL_060a: Expected Obj, but got Unknown
		//IL_060a: Expected Obj, but got Unknown
		//IL_062f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0662: Unknown result type (might be due to invalid IL or missing references)
		//IL_066c: Expected Obj, but got Unknown
		//IL_06b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06be: Expected Obj, but got Unknown
		//IL_06be: Expected Obj, but got Unknown
		checked
		{
			try
			{
				e.Graphics.FillRectangle((Brush)new SolidBrush(Color.Black), 0, 0, 260, 20);
				string text = "RAPPORT CAISSIER";
				e.Graphics.DrawString(text, new Font("Inconsolata Condensed", 13f, (FontStyle)1), Brushes.White, Convert.ToSingle(130f - e.Graphics.MeasureString(text, new Font("Inconsolata Condensed", 13f, (FontStyle)1)).Width / 2f), 0f, new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("Rapport :" + Strings.Format(DateTimePicker1.Value, "dd/MM/yyyy") + " ==> " + Strings.Format(DateTimePicker2.Value, "dd/MM/yyyy"), new Font("Inconsolata Condensed", 10f, (FontStyle)1), Brushes.Black, 0f, 80f, new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("-----------------------------------------", new Font("Inconsolata Condensed", 11f, (FontStyle)0), Brushes.Black, 0f, 100f, new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("Caissier                 Qté    TOTAL_NET  ", new Font("Inconsolata Condensed", 11f, (FontStyle)1), Brushes.Black, 0f, 110f, new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("-----------------------------------------", new Font("Inconsolata Condensed", 11f, (FontStyle)0), Brushes.Black, 0f, 120f, new StringFormat((StringFormatFlags)8192));
				string text2 = "";
				int num = 0;
				int num2 = DataGridView2.RowCount - 1;
				int num3 = 0;
				while (true)
				{
					int num4 = num3;
					int num5 = num2;
					if (num4 > num5)
					{
						break;
					}
					if (Operators.ConditionalCompareObjectEqual(DataGridView2.Rows[num3].Cells["COL_2"].Value, ".", TextCompare: false))
					{
						text2 = Strings.LSet(DataGridView2.Rows[num3].Cells["COL_1"].Value.ToString().PadRight(33, '-'), 33);
						e.Graphics.DrawString(text2, new Font("Inconsolata ExtraBold", 11f, (FontStyle)1), Brushes.Black, 0f, (float)(120 + num * 16 + 10), new StringFormat((StringFormatFlags)8192));
					}
					else
					{
						text2 = Strings.LSet(Conversions.ToString(DataGridView2.Rows[num3].Cells["COL_1"].Value), 26) + Strings.RSet(Conversions.ToString(DataGridView2.Rows[num3].Cells["COL_2"].Value), 6) + " " + Strings.RSet(Conversions.ToString(DataGridView2.Rows[num3].Cells["COL_3"].Value), 12);
						e.Graphics.DrawString(text2, new Font("Inconsolata Condensed", 10f, (FontStyle)1), Brushes.Black, 0f, (float)(120 + num * 16 + 10), new StringFormat((StringFormatFlags)8192));
					}
					num++;
					num3++;
				}
				double num6 = 0.0;
				DataTable dataTable = new DataTable();
				MySqlDataAdapter val = new MySqlDataAdapter();
				dataTable.Clear();
				val = new MySqlDataAdapter("select sum(Total_NET) as n     from TABLE_VENTES_JOURNAL WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '        and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')     ", Module1.cn_SQL);
				((DbDataAdapter)(object)val).Fill(dataTable);
				num6 = Conversions.ToDouble(Strings.FormatNumber(Conversion.Val(dataTable.Rows[0]["n"].ToString())));
				e.Graphics.DrawString("-----------------------------------------", new Font("Inconsolata Condensed", 11f, (FontStyle)0), Brushes.Black, 0f, (float)(DataGridView2.Rows.Count * 16 + 130), new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("TOTAL NET: " + Strings.RSet(Conversions.ToString(num6) + " DH", 12), new Font("Inconsolata ExtraBold", 16f, (FontStyle)1), Brushes.Black, 0f, (float)(DataGridView2.Rows.Count * 16 + 140), new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("-----------------------------------------", new Font("Inconsolata Condensed", 11f, (FontStyle)0), Brushes.Black, 0f, (float)(DataGridView2.Rows.Count * 16 + 160), new StringFormat((StringFormatFlags)8192));
				string text3 = "";
				int num7 = DataGridView3.RowCount - 1;
				int num8 = 0;
				while (true)
				{
					int num9 = num8;
					int num5 = num7;
					if (num9 > num5)
					{
						break;
					}
					text3 = text3 + DataGridView3.Rows[num8].Cells[0].Value.ToString() + Environment.NewLine;
					num8++;
				}
				e.Graphics.DrawString(text3, new Font("Inconsolata Condensed", 11f, (FontStyle)1), Brushes.Black, 0f, (float)(DataGridView2.Rows.Count * 16 + 170), new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"), new Font("Inconsolata Condensed", 8f, (FontStyle)1), Brushes.Black, Convert.ToSingle(130f - e.Graphics.MeasureString(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"), new Font("Inconsolata Condensed", 8f, (FontStyle)1)).Width / 2f), (float)(DataGridView2.Rows.Count * 16 + 170 + DataGridView3.Rows.Count * 16), new StringFormat((StringFormatFlags)8192));
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

	private void Print_Recette_vendeur_PrintPage(object sender, PrintPageEventArgs e)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected Obj, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected Obj, but got Unknown
		//IL_008d: Expected Obj, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected Obj, but got Unknown
		//IL_00d7: Expected Obj, but got Unknown
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected Obj, but got Unknown
		//IL_014f: Expected Obj, but got Unknown
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Expected Obj, but got Unknown
		//IL_0189: Expected Obj, but got Unknown
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected Obj, but got Unknown
		//IL_01c3: Expected Obj, but got Unknown
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Expected Obj, but got Unknown
		//IL_01fd: Expected Obj, but got Unknown
		//IL_07c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07cf: Expected Obj, but got Unknown
		//IL_03d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e0: Expected Obj, but got Unknown
		//IL_0477: Unknown result type (might be due to invalid IL or missing references)
		//IL_047e: Expected Obj, but got Unknown
		//IL_04d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0505: Unknown result type (might be due to invalid IL or missing references)
		//IL_050f: Expected Obj, but got Unknown
		//IL_050f: Expected Obj, but got Unknown
		//IL_0543: Unknown result type (might be due to invalid IL or missing references)
		//IL_0571: Unknown result type (might be due to invalid IL or missing references)
		//IL_057b: Expected Obj, but got Unknown
		//IL_057b: Expected Obj, but got Unknown
		//IL_0592: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ca: Expected Obj, but got Unknown
		//IL_05ca: Expected Obj, but got Unknown
		//IL_0384: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ad: Expected Obj, but got Unknown
		//IL_03ad: Expected Obj, but got Unknown
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Expected Obj, but got Unknown
		//IL_02cb: Expected Obj, but got Unknown
		//IL_063b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0669: Unknown result type (might be due to invalid IL or missing references)
		//IL_0673: Expected Obj, but got Unknown
		//IL_0673: Expected Obj, but got Unknown
		//IL_0698: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d5: Expected Obj, but got Unknown
		//IL_071d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0727: Expected Obj, but got Unknown
		//IL_0727: Expected Obj, but got Unknown
		checked
		{
			try
			{
				e.Graphics.FillRectangle((Brush)new SolidBrush(Color.Black), 0, 0, 260, 20);
				string text = "RAPPORT VENDEUR";
				e.Graphics.DrawString(text, new Font("Inconsolata Condensed", 13f, (FontStyle)1), Brushes.White, Convert.ToSingle(130f - e.Graphics.MeasureString(text, new Font("Inconsolata Condensed", 13f, (FontStyle)1)).Width / 2f), 0f, new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("Vendeur : " + ListBox_VENDEURS.Text, new Font("Inconsolata Condensed", 10f, (FontStyle)1), Brushes.Black, 0f, 85f, new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("Rapport :" + Strings.Format(DateTimePicker1.Value, "dd/MM/yyyy") + " ==> " + Strings.Format(DateTimePicker2.Value, "dd/MM/yyyy"), new Font("Inconsolata Condensed", 10f, (FontStyle)1), Brushes.Black, 0f, 95f, new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("-----------------------------------------", new Font("Inconsolata Condensed", 11f, (FontStyle)0), Brushes.Black, 0f, 100f, new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("Article                  Qté    TOTAL_NET  ", new Font("Inconsolata Condensed", 11f, (FontStyle)1), Brushes.Black, 0f, 110f, new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("-----------------------------------------", new Font("Inconsolata Condensed", 11f, (FontStyle)0), Brushes.Black, 0f, 120f, new StringFormat((StringFormatFlags)8192));
				string text2 = "";
				int num = 0;
				int num2 = DataGridView2.RowCount - 1;
				int num3 = 0;
				while (true)
				{
					int num4 = num3;
					int num5 = num2;
					if (num4 > num5)
					{
						break;
					}
					if (Operators.ConditionalCompareObjectEqual(DataGridView2.Rows[num3].Cells["COL_2"].Value, ".", TextCompare: false))
					{
						text2 = Strings.LSet(DataGridView2.Rows[num3].Cells["COL_1"].Value.ToString().PadRight(33, '-'), 33);
						e.Graphics.DrawString(text2, new Font("Inconsolata ExtraBold", 11f, (FontStyle)1), Brushes.Black, 0f, (float)(120 + num * 16 + 10), new StringFormat((StringFormatFlags)8192));
					}
					else
					{
						text2 = Strings.LSet(Conversions.ToString(DataGridView2.Rows[num3].Cells["COL_1"].Value), 26) + Strings.RSet(Conversions.ToString(DataGridView2.Rows[num3].Cells["COL_2"].Value), 6) + " " + Strings.RSet(Conversions.ToString(DataGridView2.Rows[num3].Cells["COL_3"].Value), 12);
						e.Graphics.DrawString(text2, new Font("Inconsolata Condensed", 10f, (FontStyle)1), Brushes.Black, 0f, (float)(120 + num * 16 + 10), new StringFormat((StringFormatFlags)8192));
					}
					num++;
					num3++;
				}
				double num6 = 0.0;
				DataTable dataTable = new DataTable();
				MySqlDataAdapter val = new MySqlDataAdapter();
				dataTable.Clear();
				val = new MySqlDataAdapter("select sum(Total_NET) as n     from TABLE_VENTES_JOURNAL WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '        And      Vendeur like  '" + Strings.Trim(ListBox_VENDEURS.Text) + "'           and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')     ", Module1.cn_SQL);
				((DbDataAdapter)(object)val).Fill(dataTable);
				num6 = Conversions.ToDouble(Strings.FormatNumber(Conversion.Val(dataTable.Rows[0]["n"].ToString())));
				e.Graphics.DrawString("-----------------------------------------", new Font("Inconsolata Condensed", 11f, (FontStyle)0), Brushes.Black, 0f, (float)(DataGridView2.Rows.Count * 16 + 130), new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("TOTAL NET: " + Strings.RSet(Conversions.ToString(num6) + " DH", 12), new Font("Inconsolata ExtraBold", 16f, (FontStyle)1), Brushes.Black, 0f, (float)(DataGridView2.Rows.Count * 16 + 140), new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("-----------------------------------------", new Font("Inconsolata Condensed", 11f, (FontStyle)0), Brushes.Black, 0f, (float)(DataGridView2.Rows.Count * 16 + 160), new StringFormat((StringFormatFlags)8192));
				string text3 = "";
				int num7 = DataGridView3.RowCount - 1;
				int num8 = 0;
				while (true)
				{
					int num9 = num8;
					int num5 = num7;
					if (num9 > num5)
					{
						break;
					}
					text3 = text3 + DataGridView3.Rows[num8].Cells[0].Value.ToString() + Environment.NewLine;
					num8++;
				}
				e.Graphics.DrawString(text3, new Font("Inconsolata Condensed", 11f, (FontStyle)1), Brushes.Black, 0f, (float)(DataGridView2.Rows.Count * 16 + 170), new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"), new Font("Inconsolata Condensed", 8f, (FontStyle)1), Brushes.Black, Convert.ToSingle(130f - e.Graphics.MeasureString(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"), new Font("Inconsolata Condensed", 8f, (FontStyle)1)).Width / 2f), (float)(DataGridView2.Rows.Count * 16 + 170 + DataGridView3.Rows.Count * 16), new StringFormat((StringFormatFlags)8192));
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

	private void Print_Recette_vendeurGLOBALE_PrintPage(object sender, PrintPageEventArgs e)
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
		//IL_075f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0766: Expected Obj, but got Unknown
		//IL_038f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Expected Obj, but got Unknown
		//IL_040e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0415: Expected Obj, but got Unknown
		//IL_046e: Unknown result type (might be due to invalid IL or missing references)
		//IL_049c: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a6: Expected Obj, but got Unknown
		//IL_04a6: Expected Obj, but got Unknown
		//IL_04da: Unknown result type (might be due to invalid IL or missing references)
		//IL_0508: Unknown result type (might be due to invalid IL or missing references)
		//IL_0512: Expected Obj, but got Unknown
		//IL_0512: Expected Obj, but got Unknown
		//IL_0529: Unknown result type (might be due to invalid IL or missing references)
		//IL_0557: Unknown result type (might be due to invalid IL or missing references)
		//IL_0561: Expected Obj, but got Unknown
		//IL_0561: Expected Obj, but got Unknown
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0359: Unknown result type (might be due to invalid IL or missing references)
		//IL_0363: Expected Obj, but got Unknown
		//IL_0363: Expected Obj, but got Unknown
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Expected Obj, but got Unknown
		//IL_0281: Expected Obj, but got Unknown
		//IL_05d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0600: Unknown result type (might be due to invalid IL or missing references)
		//IL_060a: Expected Obj, but got Unknown
		//IL_060a: Expected Obj, but got Unknown
		//IL_062f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0662: Unknown result type (might be due to invalid IL or missing references)
		//IL_066c: Expected Obj, but got Unknown
		//IL_06b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06be: Expected Obj, but got Unknown
		//IL_06be: Expected Obj, but got Unknown
		checked
		{
			try
			{
				e.Graphics.FillRectangle((Brush)new SolidBrush(Color.Black), 0, 0, 260, 20);
				string text = "RAPPORT VENDEUR";
				e.Graphics.DrawString(text, new Font("Inconsolata Condensed", 13f, (FontStyle)1), Brushes.White, Convert.ToSingle(130f - e.Graphics.MeasureString(text, new Font("Inconsolata Condensed", 13f, (FontStyle)1)).Width / 2f), 0f, new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("Rapport :" + Strings.Format(DateTimePicker1.Value, "dd/MM/yyyy") + " ==> " + Strings.Format(DateTimePicker2.Value, "dd/MM/yyyy"), new Font("Inconsolata Condensed", 10f, (FontStyle)1), Brushes.Black, 0f, 95f, new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("-----------------------------------------", new Font("Inconsolata Condensed", 11f, (FontStyle)0), Brushes.Black, 0f, 100f, new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("Vendeur                  Qté    TOTAL_NET  ", new Font("Inconsolata Condensed", 11f, (FontStyle)1), Brushes.Black, 0f, 110f, new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("-----------------------------------------", new Font("Inconsolata Condensed", 11f, (FontStyle)0), Brushes.Black, 0f, 120f, new StringFormat((StringFormatFlags)8192));
				string text2 = "";
				int num = 0;
				int num2 = DataGridView2.RowCount - 1;
				int num3 = 0;
				while (true)
				{
					int num4 = num3;
					int num5 = num2;
					if (num4 > num5)
					{
						break;
					}
					if (Operators.ConditionalCompareObjectEqual(DataGridView2.Rows[num3].Cells["COL_2"].Value, ".", TextCompare: false))
					{
						text2 = Strings.LSet(DataGridView2.Rows[num3].Cells["COL_1"].Value.ToString().PadRight(33, '-'), 33);
						e.Graphics.DrawString(text2, new Font("Inconsolata ExtraBold", 11f, (FontStyle)1), Brushes.Black, 0f, (float)(120 + num * 16 + 10), new StringFormat((StringFormatFlags)8192));
					}
					else
					{
						text2 = Strings.LSet(Conversions.ToString(DataGridView2.Rows[num3].Cells["COL_1"].Value), 26) + Strings.RSet(Conversions.ToString(DataGridView2.Rows[num3].Cells["COL_2"].Value), 6) + " " + Strings.RSet(Conversions.ToString(DataGridView2.Rows[num3].Cells["COL_3"].Value), 12);
						e.Graphics.DrawString(text2, new Font("Inconsolata Condensed", 10f, (FontStyle)1), Brushes.Black, 0f, (float)(120 + num * 16 + 10), new StringFormat((StringFormatFlags)8192));
					}
					num++;
					num3++;
				}
				double num6 = 0.0;
				DataTable dataTable = new DataTable();
				MySqlDataAdapter val = new MySqlDataAdapter();
				dataTable.Clear();
				val = new MySqlDataAdapter("select sum(Total_NET) as n     from TABLE_VENTES_JOURNAL WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '        and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')     ", Module1.cn_SQL);
				((DbDataAdapter)(object)val).Fill(dataTable);
				num6 = Conversions.ToDouble(Strings.FormatNumber(Conversion.Val(dataTable.Rows[0]["n"].ToString())));
				e.Graphics.DrawString("-----------------------------------------", new Font("Inconsolata Condensed", 11f, (FontStyle)0), Brushes.Black, 0f, (float)(DataGridView2.Rows.Count * 16 + 130), new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("TOTAL NET: " + Strings.RSet(Conversions.ToString(num6) + " DH", 12), new Font("Inconsolata ExtraBold", 16f, (FontStyle)1), Brushes.Black, 0f, (float)(DataGridView2.Rows.Count * 16 + 140), new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("-----------------------------------------", new Font("Inconsolata Condensed", 11f, (FontStyle)0), Brushes.Black, 0f, (float)(DataGridView2.Rows.Count * 16 + 160), new StringFormat((StringFormatFlags)8192));
				string text3 = "";
				int num7 = DataGridView3.RowCount - 1;
				int num8 = 0;
				while (true)
				{
					int num9 = num8;
					int num5 = num7;
					if (num9 > num5)
					{
						break;
					}
					text3 = text3 + DataGridView3.Rows[num8].Cells[0].Value.ToString() + Environment.NewLine;
					num8++;
				}
				e.Graphics.DrawString(text3, new Font("Inconsolata Condensed", 11f, (FontStyle)1), Brushes.Black, 0f, (float)(DataGridView2.Rows.Count * 16 + 170), new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"), new Font("Inconsolata Condensed", 8f, (FontStyle)1), Brushes.Black, Convert.ToSingle(130f - e.Graphics.MeasureString(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"), new Font("Inconsolata Condensed", 8f, (FontStyle)1)).Width / 2f), (float)(DataGridView2.Rows.Count * 16 + 170 + DataGridView3.Rows.Count * 16), new StringFormat((StringFormatFlags)8192));
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

	private void Print_Recette_Famille_PrintPage(object sender, PrintPageEventArgs e)
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
		//IL_077e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0785: Expected Obj, but got Unknown
		//IL_038f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Expected Obj, but got Unknown
		//IL_042d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0434: Expected Obj, but got Unknown
		//IL_048d: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c5: Expected Obj, but got Unknown
		//IL_04c5: Expected Obj, but got Unknown
		//IL_04f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0527: Unknown result type (might be due to invalid IL or missing references)
		//IL_0531: Expected Obj, but got Unknown
		//IL_0531: Expected Obj, but got Unknown
		//IL_0548: Unknown result type (might be due to invalid IL or missing references)
		//IL_0576: Unknown result type (might be due to invalid IL or missing references)
		//IL_0580: Expected Obj, but got Unknown
		//IL_0580: Expected Obj, but got Unknown
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0359: Unknown result type (might be due to invalid IL or missing references)
		//IL_0363: Expected Obj, but got Unknown
		//IL_0363: Expected Obj, but got Unknown
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Expected Obj, but got Unknown
		//IL_0281: Expected Obj, but got Unknown
		//IL_05f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_061f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0629: Expected Obj, but got Unknown
		//IL_0629: Expected Obj, but got Unknown
		//IL_064e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0681: Unknown result type (might be due to invalid IL or missing references)
		//IL_068b: Expected Obj, but got Unknown
		//IL_06d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06dd: Expected Obj, but got Unknown
		//IL_06dd: Expected Obj, but got Unknown
		checked
		{
			try
			{
				e.Graphics.FillRectangle((Brush)new SolidBrush(Color.Black), 0, 0, 260, 20);
				string text = "RAPPORT FAMILLE";
				e.Graphics.DrawString(text, new Font("Inconsolata Condensed", 10f, (FontStyle)1), Brushes.White, Convert.ToSingle(130f - e.Graphics.MeasureString(text, new Font("Inconsolata Condensed", 13f, (FontStyle)1)).Width / 2f), 0f, new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("Rapport :" + Strings.Format(DateTimePicker1.Value, "dd/MM/yyyy") + " ==> " + Strings.Format(DateTimePicker2.Value, "dd/MM/yyyy"), new Font("Inconsolata Condensed", 10f, (FontStyle)1), Brushes.Black, 0f, 95f, new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("-----------------------------------------", new Font("Inconsolata Condensed", 11f, (FontStyle)0), Brushes.Black, 0f, 100f, new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("Article                  Qté    TOTAL_NET  ", new Font("Inconsolata Condensed", 11f, (FontStyle)1), Brushes.Black, 0f, 110f, new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("-----------------------------------------", new Font("Inconsolata Condensed", 11f, (FontStyle)0), Brushes.Black, 0f, 120f, new StringFormat((StringFormatFlags)8192));
				string text2 = "";
				int num = 0;
				int num2 = DataGridView2.RowCount - 1;
				int num3 = 0;
				while (true)
				{
					int num4 = num3;
					int num5 = num2;
					if (num4 > num5)
					{
						break;
					}
					if (Operators.ConditionalCompareObjectEqual(DataGridView2.Rows[num3].Cells["COL_2"].Value, ".", TextCompare: false))
					{
						text2 = Strings.LSet(DataGridView2.Rows[num3].Cells["COL_1"].Value.ToString().PadRight(33, '-'), 33);
						e.Graphics.DrawString(text2, new Font("Inconsolata ExtraBold", 11f, (FontStyle)1), Brushes.Black, 0f, (float)(120 + num * 16 + 10), new StringFormat((StringFormatFlags)8192));
					}
					else
					{
						text2 = Strings.LSet(Conversions.ToString(DataGridView2.Rows[num3].Cells["COL_1"].Value), 26) + Strings.RSet(Conversions.ToString(DataGridView2.Rows[num3].Cells["COL_2"].Value), 6) + " " + Strings.RSet(Conversions.ToString(DataGridView2.Rows[num3].Cells["COL_3"].Value), 12);
						e.Graphics.DrawString(text2, new Font("Inconsolata Condensed", 10f, (FontStyle)1), Brushes.Black, 0f, (float)(120 + num * 16 + 10), new StringFormat((StringFormatFlags)8192));
					}
					num++;
					num3++;
				}
				double num6 = 0.0;
				DataTable dataTable = new DataTable();
				MySqlDataAdapter val = new MySqlDataAdapter();
				dataTable.Clear();
				val = new MySqlDataAdapter("select sum(Total_NET) as n     from TABLE_VENTES_JOURNAL WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '          And     Famille like  '" + Strings.Trim(ListBox_FAMILLES.Text) + "'      and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')     ", Module1.cn_SQL);
				((DbDataAdapter)(object)val).Fill(dataTable);
				num6 = Conversions.ToDouble(Strings.FormatNumber(Conversion.Val(dataTable.Rows[0]["n"].ToString())));
				e.Graphics.DrawString("-----------------------------------------", new Font("Inconsolata Condensed", 11f, (FontStyle)0), Brushes.Black, 0f, (float)(DataGridView2.Rows.Count * 16 + 130), new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("TOTAL NET: " + Strings.RSet(Conversions.ToString(num6) + " DH", 12), new Font("Inconsolata ExtraBold", 16f, (FontStyle)1), Brushes.Black, 0f, (float)(DataGridView2.Rows.Count * 16 + 140), new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("-----------------------------------------", new Font("Inconsolata Condensed", 11f, (FontStyle)0), Brushes.Black, 0f, (float)(DataGridView2.Rows.Count * 16 + 160), new StringFormat((StringFormatFlags)8192));
				string text3 = "";
				int num7 = DataGridView3.RowCount - 1;
				int num8 = 0;
				while (true)
				{
					int num9 = num8;
					int num5 = num7;
					if (num9 > num5)
					{
						break;
					}
					text3 = text3 + DataGridView3.Rows[num8].Cells[0].Value.ToString() + Environment.NewLine;
					num8++;
				}
				e.Graphics.DrawString(text3, new Font("Inconsolata Condensed", 11f, (FontStyle)1), Brushes.Black, 0f, (float)(DataGridView2.Rows.Count * 16 + 170), new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"), new Font("Inconsolata Condensed", 8f, (FontStyle)1), Brushes.Black, Convert.ToSingle(130f - e.Graphics.MeasureString(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"), new Font("Inconsolata Condensed", 8f, (FontStyle)1)).Width / 2f), (float)(DataGridView2.Rows.Count * 16 + 170 + DataGridView3.Rows.Count * 16), new StringFormat((StringFormatFlags)8192));
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

	private void Print_Recette_familleGLOBALE_PrintPage(object sender, PrintPageEventArgs e)
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
		//IL_075f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0766: Expected Obj, but got Unknown
		//IL_038f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Expected Obj, but got Unknown
		//IL_040e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0415: Expected Obj, but got Unknown
		//IL_046e: Unknown result type (might be due to invalid IL or missing references)
		//IL_049c: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a6: Expected Obj, but got Unknown
		//IL_04a6: Expected Obj, but got Unknown
		//IL_04da: Unknown result type (might be due to invalid IL or missing references)
		//IL_0508: Unknown result type (might be due to invalid IL or missing references)
		//IL_0512: Expected Obj, but got Unknown
		//IL_0512: Expected Obj, but got Unknown
		//IL_0529: Unknown result type (might be due to invalid IL or missing references)
		//IL_0557: Unknown result type (might be due to invalid IL or missing references)
		//IL_0561: Expected Obj, but got Unknown
		//IL_0561: Expected Obj, but got Unknown
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0359: Unknown result type (might be due to invalid IL or missing references)
		//IL_0363: Expected Obj, but got Unknown
		//IL_0363: Expected Obj, but got Unknown
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Expected Obj, but got Unknown
		//IL_0281: Expected Obj, but got Unknown
		//IL_05d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0600: Unknown result type (might be due to invalid IL or missing references)
		//IL_060a: Expected Obj, but got Unknown
		//IL_060a: Expected Obj, but got Unknown
		//IL_062f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0662: Unknown result type (might be due to invalid IL or missing references)
		//IL_066c: Expected Obj, but got Unknown
		//IL_06b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06be: Expected Obj, but got Unknown
		//IL_06be: Expected Obj, but got Unknown
		checked
		{
			try
			{
				e.Graphics.FillRectangle((Brush)new SolidBrush(Color.Black), 0, 0, 260, 20);
				string text = "RAPPORT FAMILLE";
				e.Graphics.DrawString(text, new Font("Inconsolata Condensed", 13f, (FontStyle)1), Brushes.White, Convert.ToSingle(130f - e.Graphics.MeasureString(text, new Font("Inconsolata Condensed", 13f, (FontStyle)1)).Width / 2f), 0f, new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("Rapport :" + Strings.Format(DateTimePicker1.Value, "dd/MM/yyyy") + " ==> " + Strings.Format(DateTimePicker2.Value, "dd/MM/yyyy"), new Font("Inconsolata Condensed", 10f, (FontStyle)1), Brushes.Black, 0f, 95f, new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("-----------------------------------------", new Font("Inconsolata Condensed", 11f, (FontStyle)0), Brushes.Black, 0f, 100f, new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("Famille                  Qté    TOTAL_NET  ", new Font("Inconsolata Condensed", 11f, (FontStyle)1), Brushes.Black, 0f, 110f, new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("-----------------------------------------", new Font("Inconsolata Condensed", 11f, (FontStyle)0), Brushes.Black, 0f, 120f, new StringFormat((StringFormatFlags)8192));
				string text2 = "";
				int num = 0;
				int num2 = DataGridView2.RowCount - 1;
				int num3 = 0;
				while (true)
				{
					int num4 = num3;
					int num5 = num2;
					if (num4 > num5)
					{
						break;
					}
					if (Operators.ConditionalCompareObjectEqual(DataGridView2.Rows[num3].Cells["COL_2"].Value, ".", TextCompare: false))
					{
						text2 = Strings.LSet(DataGridView2.Rows[num3].Cells["COL_1"].Value.ToString().PadRight(33, '-'), 33);
						e.Graphics.DrawString(text2, new Font("Inconsolata ExtraBold", 11f, (FontStyle)1), Brushes.Black, 0f, (float)(120 + num * 16 + 10), new StringFormat((StringFormatFlags)8192));
					}
					else
					{
						text2 = Strings.LSet(Conversions.ToString(DataGridView2.Rows[num3].Cells["COL_1"].Value), 26) + Strings.RSet(Conversions.ToString(DataGridView2.Rows[num3].Cells["COL_2"].Value), 6) + " " + Strings.RSet(Conversions.ToString(DataGridView2.Rows[num3].Cells["COL_3"].Value), 12);
						e.Graphics.DrawString(text2, new Font("Inconsolata Condensed", 10f, (FontStyle)1), Brushes.Black, 0f, (float)(120 + num * 16 + 10), new StringFormat((StringFormatFlags)8192));
					}
					num++;
					num3++;
				}
				double num6 = 0.0;
				DataTable dataTable = new DataTable();
				MySqlDataAdapter val = new MySqlDataAdapter();
				dataTable.Clear();
				val = new MySqlDataAdapter("select sum(Total_NET) as n     from TABLE_VENTES_JOURNAL WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '        and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')     ", Module1.cn_SQL);
				((DbDataAdapter)(object)val).Fill(dataTable);
				num6 = Conversions.ToDouble(Strings.FormatNumber(Conversion.Val(dataTable.Rows[0]["n"].ToString())));
				e.Graphics.DrawString("-----------------------------------------", new Font("Inconsolata Condensed", 11f, (FontStyle)0), Brushes.Black, 0f, (float)(DataGridView2.Rows.Count * 16 + 130), new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("TOTAL NET: " + Strings.RSet(Conversions.ToString(num6) + " DH", 12), new Font("Inconsolata ExtraBold", 16f, (FontStyle)1), Brushes.Black, 0f, (float)(DataGridView2.Rows.Count * 16 + 140), new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("-----------------------------------------", new Font("Inconsolata Condensed", 11f, (FontStyle)0), Brushes.Black, 0f, (float)(DataGridView2.Rows.Count * 16 + 160), new StringFormat((StringFormatFlags)8192));
				string text3 = "";
				int num7 = DataGridView3.RowCount - 1;
				int num8 = 0;
				while (true)
				{
					int num9 = num8;
					int num5 = num7;
					if (num9 > num5)
					{
						break;
					}
					text3 = text3 + DataGridView3.Rows[num8].Cells[0].Value.ToString() + Environment.NewLine;
					num8++;
				}
				e.Graphics.DrawString(text3, new Font("Inconsolata Condensed", 11f, (FontStyle)1), Brushes.Black, 0f, (float)(DataGridView2.Rows.Count * 16 + 170), new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"), new Font("Inconsolata Condensed", 8f, (FontStyle)1), Brushes.Black, Convert.ToSingle(130f - e.Graphics.MeasureString(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"), new Font("Inconsolata Condensed", 8f, (FontStyle)1)).Width / 2f), (float)(DataGridView2.Rows.Count * 16 + 170 + DataGridView3.Rows.Count * 16), new StringFormat((StringFormatFlags)8192));
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

	private void Print_Recette_Client_PrintPage(object sender, PrintPageEventArgs e)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected Obj, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected Obj, but got Unknown
		//IL_008d: Expected Obj, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected Obj, but got Unknown
		//IL_00d7: Expected Obj, but got Unknown
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected Obj, but got Unknown
		//IL_014f: Expected Obj, but got Unknown
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Expected Obj, but got Unknown
		//IL_0189: Expected Obj, but got Unknown
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected Obj, but got Unknown
		//IL_01c3: Expected Obj, but got Unknown
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Expected Obj, but got Unknown
		//IL_01fd: Expected Obj, but got Unknown
		//IL_07c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07cf: Expected Obj, but got Unknown
		//IL_03d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e0: Expected Obj, but got Unknown
		//IL_0477: Unknown result type (might be due to invalid IL or missing references)
		//IL_047e: Expected Obj, but got Unknown
		//IL_04d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0505: Unknown result type (might be due to invalid IL or missing references)
		//IL_050f: Expected Obj, but got Unknown
		//IL_050f: Expected Obj, but got Unknown
		//IL_0543: Unknown result type (might be due to invalid IL or missing references)
		//IL_0571: Unknown result type (might be due to invalid IL or missing references)
		//IL_057b: Expected Obj, but got Unknown
		//IL_057b: Expected Obj, but got Unknown
		//IL_0592: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ca: Expected Obj, but got Unknown
		//IL_05ca: Expected Obj, but got Unknown
		//IL_0384: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ad: Expected Obj, but got Unknown
		//IL_03ad: Expected Obj, but got Unknown
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Expected Obj, but got Unknown
		//IL_02cb: Expected Obj, but got Unknown
		//IL_063b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0669: Unknown result type (might be due to invalid IL or missing references)
		//IL_0673: Expected Obj, but got Unknown
		//IL_0673: Expected Obj, but got Unknown
		//IL_0698: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d5: Expected Obj, but got Unknown
		//IL_071d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0727: Expected Obj, but got Unknown
		//IL_0727: Expected Obj, but got Unknown
		checked
		{
			try
			{
				e.Graphics.FillRectangle((Brush)new SolidBrush(Color.Black), 0, 0, 260, 20);
				string text = "RAPPORT CLIENT";
				e.Graphics.DrawString(text, new Font("Inconsolata Condensed", 13f, (FontStyle)1), Brushes.White, Convert.ToSingle(130f - e.Graphics.MeasureString(text, new Font("Inconsolata Condensed", 13f, (FontStyle)1)).Width / 2f), 0f, new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("Client  : " + ListBox_CLIENTS.Text, new Font("Inconsolata Condensed", 10f, (FontStyle)1), Brushes.Black, 0f, 85f, new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("Rapport :" + Strings.Format(DateTimePicker1.Value, "dd/MM/yyyy") + " ==> " + Strings.Format(DateTimePicker2.Value, "dd/MM/yyyy"), new Font("Inconsolata Condensed", 10f, (FontStyle)1), Brushes.Black, 0f, 95f, new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("-----------------------------------------", new Font("Inconsolata Condensed", 11f, (FontStyle)0), Brushes.Black, 0f, 100f, new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("Article                  Qté    TOTAL_NET  ", new Font("Inconsolata Condensed", 11f, (FontStyle)1), Brushes.Black, 0f, 110f, new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("-----------------------------------------", new Font("Inconsolata Condensed", 11f, (FontStyle)0), Brushes.Black, 0f, 120f, new StringFormat((StringFormatFlags)8192));
				string text2 = "";
				int num = 0;
				int num2 = DataGridView2.RowCount - 1;
				int num3 = 0;
				while (true)
				{
					int num4 = num3;
					int num5 = num2;
					if (num4 > num5)
					{
						break;
					}
					if (Operators.ConditionalCompareObjectEqual(DataGridView2.Rows[num3].Cells["COL_2"].Value, ".", TextCompare: false))
					{
						text2 = Strings.LSet(DataGridView2.Rows[num3].Cells["COL_1"].Value.ToString().PadRight(33, '-'), 33);
						e.Graphics.DrawString(text2, new Font("Inconsolata ExtraBold", 11f, (FontStyle)1), Brushes.Black, 0f, (float)(120 + num * 16 + 10), new StringFormat((StringFormatFlags)8192));
					}
					else
					{
						text2 = Strings.LSet(Conversions.ToString(DataGridView2.Rows[num3].Cells["COL_1"].Value), 26) + Strings.RSet(Conversions.ToString(DataGridView2.Rows[num3].Cells["COL_2"].Value), 6) + " " + Strings.RSet(Conversions.ToString(DataGridView2.Rows[num3].Cells["COL_3"].Value), 12);
						e.Graphics.DrawString(text2, new Font("Inconsolata Condensed", 10f, (FontStyle)1), Brushes.Black, 0f, (float)(120 + num * 16 + 10), new StringFormat((StringFormatFlags)8192));
					}
					num++;
					num3++;
				}
				double num6 = 0.0;
				DataTable dataTable = new DataTable();
				MySqlDataAdapter val = new MySqlDataAdapter();
				dataTable.Clear();
				val = new MySqlDataAdapter("select sum(Total_NET) as n     from TABLE_VENTES_JOURNAL WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '        And     Client like  '" + Strings.Trim(ListBox_CLIENTS.Text) + "'          and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')      ", Module1.cn_SQL);
				((DbDataAdapter)(object)val).Fill(dataTable);
				num6 = Conversions.ToDouble(Strings.FormatNumber(Conversion.Val(dataTable.Rows[0]["n"].ToString())));
				e.Graphics.DrawString("-----------------------------------------", new Font("Inconsolata Condensed", 11f, (FontStyle)0), Brushes.Black, 0f, (float)(DataGridView2.Rows.Count * 16 + 130), new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("TOTAL NET: " + Strings.RSet(Conversions.ToString(num6) + " DH", 12), new Font("Inconsolata ExtraBold", 16f, (FontStyle)1), Brushes.Black, 0f, (float)(DataGridView2.Rows.Count * 16 + 140), new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("-----------------------------------------", new Font("Inconsolata Condensed", 11f, (FontStyle)0), Brushes.Black, 0f, (float)(DataGridView2.Rows.Count * 16 + 160), new StringFormat((StringFormatFlags)8192));
				string text3 = "";
				int num7 = DataGridView3.RowCount - 1;
				int num8 = 0;
				while (true)
				{
					int num9 = num8;
					int num5 = num7;
					if (num9 > num5)
					{
						break;
					}
					text3 = text3 + DataGridView3.Rows[num8].Cells[0].Value.ToString() + Environment.NewLine;
					num8++;
				}
				e.Graphics.DrawString(text3, new Font("Inconsolata Condensed", 11f, (FontStyle)1), Brushes.Black, 0f, (float)(DataGridView2.Rows.Count * 16 + 170), new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"), new Font("Inconsolata Condensed", 8f, (FontStyle)1), Brushes.Black, Convert.ToSingle(130f - e.Graphics.MeasureString(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"), new Font("Inconsolata Condensed", 8f, (FontStyle)1)).Width / 2f), (float)(DataGridView2.Rows.Count * 16 + 170 + DataGridView3.Rows.Count * 16), new StringFormat((StringFormatFlags)8192));
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

	private void Print_Recette_clientGLOBALE_PrintPage(object sender, PrintPageEventArgs e)
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
		//IL_075f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0766: Expected Obj, but got Unknown
		//IL_038f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Expected Obj, but got Unknown
		//IL_040e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0415: Expected Obj, but got Unknown
		//IL_046e: Unknown result type (might be due to invalid IL or missing references)
		//IL_049c: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a6: Expected Obj, but got Unknown
		//IL_04a6: Expected Obj, but got Unknown
		//IL_04da: Unknown result type (might be due to invalid IL or missing references)
		//IL_0508: Unknown result type (might be due to invalid IL or missing references)
		//IL_0512: Expected Obj, but got Unknown
		//IL_0512: Expected Obj, but got Unknown
		//IL_0529: Unknown result type (might be due to invalid IL or missing references)
		//IL_0557: Unknown result type (might be due to invalid IL or missing references)
		//IL_0561: Expected Obj, but got Unknown
		//IL_0561: Expected Obj, but got Unknown
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0359: Unknown result type (might be due to invalid IL or missing references)
		//IL_0363: Expected Obj, but got Unknown
		//IL_0363: Expected Obj, but got Unknown
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Expected Obj, but got Unknown
		//IL_0281: Expected Obj, but got Unknown
		//IL_05d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0600: Unknown result type (might be due to invalid IL or missing references)
		//IL_060a: Expected Obj, but got Unknown
		//IL_060a: Expected Obj, but got Unknown
		//IL_062f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0662: Unknown result type (might be due to invalid IL or missing references)
		//IL_066c: Expected Obj, but got Unknown
		//IL_06b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06be: Expected Obj, but got Unknown
		//IL_06be: Expected Obj, but got Unknown
		checked
		{
			try
			{
				e.Graphics.FillRectangle((Brush)new SolidBrush(Color.Black), 0, 0, 260, 20);
				string text = "RAPPORT CLIENT";
				e.Graphics.DrawString(text, new Font("Inconsolata Condensed", 13f, (FontStyle)1), Brushes.White, Convert.ToSingle(130f - e.Graphics.MeasureString(text, new Font("Inconsolata Condensed", 13f, (FontStyle)1)).Width / 2f), 0f, new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("Rapport :" + Strings.Format(DateTimePicker1.Value, "dd/MM/yyyy") + " ==> " + Strings.Format(DateTimePicker2.Value, "dd/MM/yyyy"), new Font("Inconsolata Condensed", 10f, (FontStyle)1), Brushes.Black, 0f, 95f, new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("-----------------------------------------", new Font("Inconsolata Condensed", 11f, (FontStyle)0), Brushes.Black, 0f, 100f, new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("Client                   Qté    TOTAL_NET  ", new Font("Inconsolata Condensed", 11f, (FontStyle)1), Brushes.Black, 0f, 110f, new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("-----------------------------------------", new Font("Inconsolata Condensed", 11f, (FontStyle)0), Brushes.Black, 0f, 120f, new StringFormat((StringFormatFlags)8192));
				string text2 = "";
				int num = 0;
				int num2 = DataGridView2.RowCount - 1;
				int num3 = 0;
				while (true)
				{
					int num4 = num3;
					int num5 = num2;
					if (num4 > num5)
					{
						break;
					}
					if (Operators.ConditionalCompareObjectEqual(DataGridView2.Rows[num3].Cells["COL_2"].Value, ".", TextCompare: false))
					{
						text2 = Strings.LSet(DataGridView2.Rows[num3].Cells["COL_1"].Value.ToString().PadRight(33, '-'), 33);
						e.Graphics.DrawString(text2, new Font("Inconsolata ExtraBold", 11f, (FontStyle)1), Brushes.Black, 0f, (float)(120 + num * 16 + 10), new StringFormat((StringFormatFlags)8192));
					}
					else
					{
						text2 = Strings.LSet(Conversions.ToString(DataGridView2.Rows[num3].Cells["COL_1"].Value), 26) + Strings.RSet(Conversions.ToString(DataGridView2.Rows[num3].Cells["COL_2"].Value), 6) + " " + Strings.RSet(Conversions.ToString(DataGridView2.Rows[num3].Cells["COL_3"].Value), 12);
						e.Graphics.DrawString(text2, new Font("Inconsolata Condensed", 10f, (FontStyle)1), Brushes.Black, 0f, (float)(120 + num * 16 + 10), new StringFormat((StringFormatFlags)8192));
					}
					num++;
					num3++;
				}
				double num6 = 0.0;
				DataTable dataTable = new DataTable();
				MySqlDataAdapter val = new MySqlDataAdapter();
				dataTable.Clear();
				val = new MySqlDataAdapter("select sum(Total_NET) as n     from TABLE_VENTES_JOURNAL WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '        and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')     ", Module1.cn_SQL);
				((DbDataAdapter)(object)val).Fill(dataTable);
				num6 = Conversions.ToDouble(Strings.FormatNumber(Conversion.Val(dataTable.Rows[0]["n"].ToString())));
				e.Graphics.DrawString("-----------------------------------------", new Font("Inconsolata Condensed", 11f, (FontStyle)0), Brushes.Black, 0f, (float)(DataGridView2.Rows.Count * 16 + 130), new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("TOTAL NET: " + Strings.RSet(Conversions.ToString(num6) + " DH", 12), new Font("Inconsolata ExtraBold", 16f, (FontStyle)1), Brushes.Black, 0f, (float)(DataGridView2.Rows.Count * 16 + 140), new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("-----------------------------------------", new Font("Inconsolata Condensed", 11f, (FontStyle)0), Brushes.Black, 0f, (float)(DataGridView2.Rows.Count * 16 + 160), new StringFormat((StringFormatFlags)8192));
				string text3 = "";
				int num7 = DataGridView3.RowCount - 1;
				int num8 = 0;
				while (true)
				{
					int num9 = num8;
					int num5 = num7;
					if (num9 > num5)
					{
						break;
					}
					text3 = text3 + DataGridView3.Rows[num8].Cells[0].Value.ToString() + Environment.NewLine;
					num8++;
				}
				e.Graphics.DrawString(text3, new Font("Inconsolata Condensed", 11f, (FontStyle)1), Brushes.Black, 0f, (float)(DataGridView2.Rows.Count * 16 + 170), new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"), new Font("Inconsolata Condensed", 8f, (FontStyle)1), Brushes.Black, Convert.ToSingle(130f - e.Graphics.MeasureString(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"), new Font("Inconsolata Condensed", 8f, (FontStyle)1)).Width / 2f), (float)(DataGridView2.Rows.Count * 16 + 170 + DataGridView3.Rows.Count * 16), new StringFormat((StringFormatFlags)8192));
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

	private void Button_TOTAL_GLOBALE_Click(object sender, EventArgs e)
	{
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected Obj, but got Unknown
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected Obj, but got Unknown
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected Obj, but got Unknown
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Expected Obj, but got Unknown
		try
		{
			DT.Clear();
			DA = new MySqlDataAdapter("select * from   TABLE_VENTES_JOURNAL     Where  Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '    order by ID desc ", Module1.cn_SQL);
			((DbDataAdapter)(object)DA).Fill(DT);
			DataGridView1.DataSource = DT;
			DataTable dataTable = new DataTable();
			MySqlDataAdapter val = new MySqlDataAdapter();
			dataTable.Clear();
			dataTable = new DataTable();
			val = new MySqlDataAdapter("select sum(Total_NET) as n from TABLE_VENTES_JOURNAL WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '            and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')                ", Module1.cn_SQL);
			((DbDataAdapter)(object)val).Fill(dataTable);
			Label_TOTAL_NET.Text = Strings.FormatNumber(Conversion.Val(dataTable.Rows[0]["n"].ToString()));
			_COLORISE_DATAGRID();
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

	public void Task_A()
	{
		FormDialog_PATIENTER formDialog_PATIENTER = new FormDialog_PATIENTER();
		Application.Run((Form)(object)formDialog_PATIENTER);
	}

	private void Button_ConsRapport_Click(object sender, EventArgs e)
	{
		//IL_3b06: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b0d: Expected Obj, but got Unknown
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected Obj, but got Unknown
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected Obj, but got Unknown
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected Obj, but got Unknown
		//IL_0709: Unknown result type (might be due to invalid IL or missing references)
		//IL_0710: Expected Obj, but got Unknown
		//IL_0788: Unknown result type (might be due to invalid IL or missing references)
		//IL_078f: Expected Obj, but got Unknown
		//IL_0799: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a0: Expected Obj, but got Unknown
		//IL_0860: Unknown result type (might be due to invalid IL or missing references)
		//IL_0867: Expected Obj, but got Unknown
		//IL_0994: Unknown result type (might be due to invalid IL or missing references)
		//IL_099b: Expected Obj, but got Unknown
		//IL_09ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b3: Expected Obj, but got Unknown
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Expected Obj, but got Unknown
		//IL_0aaa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab1: Expected Obj, but got Unknown
		//IL_0b28: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b2f: Expected Obj, but got Unknown
		//IL_05c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cc: Expected Obj, but got Unknown
		//IL_0c23: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c2a: Expected Obj, but got Unknown
		//IL_0ca1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca8: Expected Obj, but got Unknown
		//IL_0433: Unknown result type (might be due to invalid IL or missing references)
		//IL_043a: Expected Obj, but got Unknown
		//IL_0d9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da6: Expected Obj, but got Unknown
		//IL_0e1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e24: Expected Obj, but got Unknown
		//IL_1175: Unknown result type (might be due to invalid IL or missing references)
		//IL_117f: Expected Obj, but got Unknown
		//IL_0f75: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f7c: Expected Obj, but got Unknown
		//IL_0fec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ff3: Expected Obj, but got Unknown
		//IL_135a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1361: Expected Obj, but got Unknown
		//IL_1540: Unknown result type (might be due to invalid IL or missing references)
		//IL_154a: Expected Obj, but got Unknown
		//IL_1675: Unknown result type (might be due to invalid IL or missing references)
		//IL_167b: Expected Obj, but got Unknown
		//IL_16f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_16f8: Expected Obj, but got Unknown
		//IL_18ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_18d0: Expected Obj, but got Unknown
		//IL_1aa2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1aa8: Expected Obj, but got Unknown
		//IL_1c0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c11: Expected Obj, but got Unknown
		//IL_1d87: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d8e: Expected Obj, but got Unknown
		//IL_1f99: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fa3: Expected Obj, but got Unknown
		//IL_2145: Unknown result type (might be due to invalid IL or missing references)
		//IL_214f: Expected Obj, but got Unknown
		//IL_22ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_22f9: Expected Obj, but got Unknown
		//IL_249b: Unknown result type (might be due to invalid IL or missing references)
		//IL_24a5: Expected Obj, but got Unknown
		//IL_2b14: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b1b: Expected Obj, but got Unknown
		//IL_2c91: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c98: Expected Obj, but got Unknown
		//IL_25e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_25ea: Expected Obj, but got Unknown
		//IL_2649: Unknown result type (might be due to invalid IL or missing references)
		//IL_2650: Expected Obj, but got Unknown
		//IL_26c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_26c7: Expected Obj, but got Unknown
		//IL_271b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2722: Expected Obj, but got Unknown
		//IL_28af: Unknown result type (might be due to invalid IL or missing references)
		//IL_28b6: Expected Obj, but got Unknown
		//IL_29f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a00: Expected Obj, but got Unknown
		//IL_2f8e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f95: Expected Obj, but got Unknown
		//IL_305f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3066: Expected Obj, but got Unknown
		//IL_3316: Unknown result type (might be due to invalid IL or missing references)
		//IL_331d: Expected Obj, but got Unknown
		//IL_3573: Unknown result type (might be due to invalid IL or missing references)
		//IL_3579: Expected Obj, but got Unknown
		//IL_3699: Unknown result type (might be due to invalid IL or missing references)
		//IL_369f: Expected Obj, but got Unknown
		//IL_396c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3973: Expected Obj, but got Unknown
		//IL_39a2: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			try
			{
				if (Operators.CompareString(ListBox_RAPPORT_GLOBALE.Text, "Par Jours", TextCompare: false) == 0)
				{
					Button_ConsJOURS_Click(RuntimeHelpers.GetObjectValue(sender), e);
					return;
				}
				Thread thread = new Thread([SpecialName] () =>
				{
					//IL_0009: Unknown result type (might be due to invalid IL or missing references)
					try
					{
						FormDialog_PATIENTER formDialog_PATIENTER = new FormDialog_PATIENTER();
						((Form)formDialog_PATIENTER).ShowDialog();
					}
					catch (Exception ex5)
					{
						ProjectData.SetProjectError(ex5);
						Exception e2 = ex5;
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
				if (Operators.CompareString(ListBox_RAPPORT_GLOBALE.Text, "Sans Détails", TextCompare: false) != 0)
				{
					DataTable dataTable = new DataTable();
					MySqlDataAdapter val = new MySqlDataAdapter();
					dataTable.Clear();
					val = new MySqlDataAdapter("select DISTINCT Famille from TABLE_VENTES_JOURNAL   Where  Dates   between        ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '        And        ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '             and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')      ", Module1.cn_SQL);
					((DbDataAdapter)(object)val).Fill(dataTable);
					DataTable dataTable2 = new DataTable();
					MySqlDataAdapter val2 = new MySqlDataAdapter();
					DataGridView2.Rows.Clear();
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
							dataTable.Rows[num2]["Famille"].ToString(),
							".",
							""
						});
						if (Operators.CompareString(ListBox_RAPPORT_GLOBALE.Text, "Par Article", TextCompare: false) == 0)
						{
							dataTable2.Clear();
							val2 = new MySqlDataAdapter("select Article, sum(Qté) as Qté, sum(TOTAL_NET) as TOTAL_NET    from   TABLE_VENTES_JOURNAL    Where  Famille = '" + Strings.Trim(dataTable.Rows[num2]["Famille"].ToString()) + "'      and        Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '             and           (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')              group by Article      ", Module1.cn_SQL);
							((DbDataAdapter)(object)val2).Fill(dataTable2);
							int num5 = dataTable2.Rows.Count - 1;
							int num6 = 0;
							while (true)
							{
								int num7 = num6;
								num4 = num5;
								if (num7 > num4)
								{
									break;
								}
								DataGridView2.Rows.Add(new object[3]
								{
									"  " + dataTable2.Rows[num6]["Article"].ToString(),
									Strings.FormatNumber(Conversion.Val(dataTable2.Rows[num6]["Qté"].ToString())),
									Strings.FormatNumber(Conversion.Val(dataTable2.Rows[num6]["TOTAL_NET"].ToString()))
								});
								num6++;
							}
							dataTable2.Clear();
							val2 = new MySqlDataAdapter("select  sum(Qté) as Qté, sum(TOTAL_NET) as TOTAL_NET    from   TABLE_VENTES_JOURNAL    Where  Famille = '" + Strings.Trim(dataTable.Rows[num2]["Famille"].ToString()) + "'      and        Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '                and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')      ", Module1.cn_SQL);
							((DbDataAdapter)(object)val2).Fill(dataTable2);
							DataGridView2.Rows.Add(new object[3]
							{
								"* TOTAL FAMILLE *",
								"*" + Strings.FormatNumber(Conversion.Val(dataTable2.Rows[0]["Qté"].ToString())) + "*",
								"*" + Strings.FormatNumber(Conversion.Val(dataTable2.Rows[0]["TOTAL_NET"].ToString())) + "*"
							});
						}
						else if (Operators.CompareString(ListBox_RAPPORT_GLOBALE.Text, "Par Famille", TextCompare: false) == 0)
						{
							dataTable2.Clear();
							val2 = new MySqlDataAdapter("select  sum(Qté) as Qté, sum(TOTAL_NET) as TOTAL_NET    from   TABLE_VENTES_JOURNAL    Where  Famille = '" + Strings.Trim(dataTable.Rows[num2]["Famille"].ToString()) + "'      and        Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '                and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')      ", Module1.cn_SQL);
							((DbDataAdapter)(object)val2).Fill(dataTable2);
							DataGridView2.Rows.Add(new object[3]
							{
								"",
								Strings.FormatNumber(Conversion.Val(dataTable2.Rows[0]["Qté"].ToString())),
								Strings.FormatNumber(Conversion.Val(dataTable2.Rows[0]["TOTAL_NET"].ToString()))
							});
						}
						DataGridView2.Rows.Add(new object[3] { "", "", "" });
						num2++;
					}
				}
				else
				{
					DataGridView2.Rows.Clear();
				}
				DataGridView3.Rows.Clear();
				DataGridView3.Rows.Add(new object[1] { "                    FINANCE--------------" });
				DataTable dataTable3 = new DataTable();
				MySqlDataAdapter val3 = new MySqlDataAdapter();
				dataTable3.Clear();
				val3 = new MySqlDataAdapter("select   DISTINCT     MODE_P    from TABLE_VENTES_REGLEMENTS   Where  Dates   between        ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '        And        ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '       ", Module1.cn_SQL);
				((DbDataAdapter)(object)val3).Fill(dataTable3);
				MySqlDataAdapter val4 = new MySqlDataAdapter();
				DataTable dataTable4 = new DataTable();
				int num8 = dataTable3.Rows.Count - 1;
				int num9 = 0;
				while (true)
				{
					int num10 = num9;
					int num4 = num8;
					if (num10 > num4)
					{
						break;
					}
					val4 = new MySqlDataAdapter("select sum(MONTANT) as n     from    TABLE_VENTES_REGLEMENTS     WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '             And     MODE_P  = '" + Strings.Trim(dataTable3.Rows[num9]["MODE_P"].ToString()) + "'  ", Module1.cn_SQL);
					dataTable4 = new DataTable();
					dataTable4.Clear();
					((DbDataAdapter)(object)val4).Fill(dataTable4);
					double num11 = Conversion.Val(dataTable4.Rows[0]["n"].ToString());
					DataGridView3.Rows.Add(new object[1] { "                    " + Strings.LSet(dataTable3.Rows[num9]["MODE_P"].ToString(), 8) + ":" + Strings.RSet(Strings.FormatNumber(num11), 8) + " DH" });
					num9++;
				}
				DataGridView3.Rows.Add(new object[1] { "" });
				DataGridView3.Rows.Add(new object[1] { "" });
				MySqlDataAdapter val5 = new MySqlDataAdapter();
				DataTable dataTable5 = new DataTable();
				val5 = new MySqlDataAdapter("SELECT   valeur     as N          FROM   TABLE_PARAMETRES     where  OBJET = 'FONDS_CAISSE'       ", Module1.cn_SQL);
				dataTable5 = new DataTable();
				dataTable5.Clear();
				((DbDataAdapter)(object)val5).Fill(dataTable5);
				decimal num12 = new decimal(Conversion.Val(dataTable5.Rows[0]["n"].ToString()));
				if (decimal.Compare(num12, 0m) != 0)
				{
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("(+) FONDS DE CAISSE   : ", 29) + Strings.RSet(Strings.FormatNumber(num12), 8) + " DH" });
					DataGridView3.Rows.Add(new object[1] { "" });
					DataGridView3.Rows.Add(new object[1] { "" });
				}
				MySqlDataAdapter val6 = new MySqlDataAdapter();
				DataTable dataTable6 = new DataTable();
				val6 = new MySqlDataAdapter("SELECT    SUM(MONTANT)      as N          FROM   TABLE_CLIENTS_REGLE     WHERE       DATES   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '       ", Module1.cn_SQL);
				dataTable6 = new DataTable();
				dataTable6.Clear();
				((DbDataAdapter)(object)val6).Fill(dataTable6);
				decimal num13 = new decimal(Conversion.Val(dataTable6.Rows[0]["n"].ToString()));
				if (decimal.Compare(num13, 0m) != 0)
				{
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("(+) REGLE CLIENTS     : ", 29) + Strings.RSet(Strings.FormatNumber(num13), 8) + " DH" });
					DataGridView3.Rows.Add(new object[1] { "" });
					DataGridView3.Rows.Add(new object[1] { "" });
				}
				MySqlDataAdapter val7 = new MySqlDataAdapter();
				DataTable dataTable7 = new DataTable();
				val7 = new MySqlDataAdapter("SELECT    SUM(MONTANT)      as N          FROM   TABLE_FOURNISSEURS_REGLE     WHERE       DATES   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '       ", Module1.cn_SQL);
				dataTable7 = new DataTable();
				dataTable7.Clear();
				((DbDataAdapter)(object)val7).Fill(dataTable7);
				decimal num14 = new decimal(Conversion.Val(dataTable7.Rows[0]["n"].ToString()));
				if (decimal.Compare(num14, 0m) != 0)
				{
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("(-) REGLE FOURNISSEURS: ", 29) + Strings.RSet(Strings.FormatNumber(num14), 8) + " DH" });
					DataGridView3.Rows.Add(new object[1] { "" });
					DataGridView3.Rows.Add(new object[1] { "" });
				}
				MySqlDataAdapter val8 = new MySqlDataAdapter();
				DataTable dataTable8 = new DataTable();
				val8 = new MySqlDataAdapter(" select sum(Montant) as n                   FROM   TABLE_DEPENSES           WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '   ", Module1.cn_SQL);
				dataTable8 = new DataTable();
				dataTable8.Clear();
				((DbDataAdapter)(object)val8).Fill(dataTable8);
				decimal num15 = new decimal(Conversion.Val(dataTable8.Rows[0]["n"].ToString()));
				if (decimal.Compare(num15, 0m) != 0)
				{
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("(-) DEPENSES          : ", 29) + Strings.RSet(Strings.FormatNumber(num15), 8) + " DH" });
					DataGridView3.Rows.Add(new object[1] { "" });
					DataGridView3.Rows.Add(new object[1] { "" });
				}
				if ((decimal.Compare(num13, 0m) != 0) | (decimal.Compare(num15, 0m) != 0) | (decimal.Compare(num14, 0m) != 0) | (decimal.Compare(num12, 0m) != 0))
				{
					DataTable dataTable9 = new DataTable();
					MySqlDataAdapter val9 = new MySqlDataAdapter();
					val9 = new MySqlDataAdapter("select sum(Total_NET) as n     from TABLE_VENTES_JOURNAL WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '        and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')    ", Module1.cn_SQL);
					dataTable9 = new DataTable();
					dataTable9.Clear();
					((DbDataAdapter)(object)val9).Fill(dataTable9);
					decimal d = Conversions.ToDecimal(Strings.FormatNumber(Conversion.Val(dataTable9.Rows[0]["n"].ToString())));
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("(=) TOTAL             : ", 29) + Strings.RSet(Strings.FormatNumber(decimal.Subtract(decimal.Subtract(decimal.Add(decimal.Add(d, num12), num13), num14), num15)), 8) + " DH" });
					DataGridView3.Rows.Add(new object[1] { "" });
					DataGridView3.Rows.Add(new object[1] { "" });
				}
				Module1._DT_TEMP.Clear();
				Module1._DA_TEMP = new MySqlDataAdapter("select   CLIENT,MONTANT,MODE_P   from   TABLE_CLIENTS_REGLE    Where              Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '            ", Module1.cn_SQL);
				((DbDataAdapter)(object)Module1._DA_TEMP).Fill(Module1._DT_TEMP);
				if (Module1._DT_TEMP.Rows.Count > 0)
				{
					DataGridView3.Rows.Add(new object[1] { "---------DETAILLES REGL CLIENT-----------" });
				}
				int num16 = Module1._DT_TEMP.Rows.Count - 1;
				int num17 = 0;
				while (true)
				{
					int num18 = num17;
					int num4 = num16;
					if (num18 > num4)
					{
						break;
					}
					DataGridView3.Rows.Add(new object[1] { Module1._DT_TEMP.Rows[num17]["CLIENT"].ToString() + " : " + Module1._DT_TEMP.Rows[num17]["MODE_P"].ToString() + "-->" + Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(Module1._DT_TEMP.Rows[num17]["MONTANT"].ToString()))) });
					num17++;
				}
				DataGridView3.Rows.Add(new object[1] { "" });
				dataTable3.Clear();
				val3 = new MySqlDataAdapter("select MODE_P, sum(MONTANT) as MONTANT    from   TABLE_CLIENTS_REGLE    Where        Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '                        group by MODE_P      ", Module1.cn_SQL);
				((DbDataAdapter)(object)val3).Fill(dataTable3);
				if (dataTable3.Rows.Count > 0)
				{
					DataGridView3.Rows.Add(new object[1] { "                    FINANCE--------------" });
				}
				int num19 = dataTable3.Rows.Count - 1;
				int num20 = 0;
				while (true)
				{
					int num21 = num20;
					int num4 = num19;
					if (num21 > num4)
					{
						break;
					}
					DataGridView3.Rows.Add(new object[1] { "                    " + Strings.LSet(dataTable3.Rows[num20]["MODE_P"].ToString(), 8) + ":" + Strings.RSet(Strings.FormatNumber(dataTable3.Rows[num20]["MONTANT"].ToString()), 8) + " DH" });
					num20++;
				}
				DataGridView3.Rows.Add(new object[1] { "" });
				DataGridView3.Rows.Add(new object[1] { "" });
				Module1._DT_TEMP.Clear();
				Module1._DA_TEMP = new MySqlDataAdapter("select   DEPENSE,MONTANT    from   TABLE_DEPENSES    Where              Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '            ", Module1.cn_SQL);
				((DbDataAdapter)(object)Module1._DA_TEMP).Fill(Module1._DT_TEMP);
				if (Module1._DT_TEMP.Rows.Count > 0)
				{
					DataGridView3.Rows.Add(new object[1] { "----------DETAILLES DEPENSES-------------" });
				}
				int num22 = Module1._DT_TEMP.Rows.Count - 1;
				int num23 = 0;
				while (true)
				{
					int num24 = num23;
					int num4 = num22;
					if (num24 > num4)
					{
						break;
					}
					DataGridView3.Rows.Add(new object[1] { Module1._DT_TEMP.Rows[num23]["DEPENSE"].ToString() + " : " + Module1._DT_TEMP.Rows[num23]["MONTANT"].ToString() });
					num23++;
				}
				DataGridView3.Rows.Add(new object[1] { "" });
				DataGridView3.Rows.Add(new object[1] { "" });
				MySqlDataAdapter val10 = new MySqlDataAdapter();
				DataTable dataTable10 = new DataTable();
				val10 = new MySqlDataAdapter("select Caissier, sum(TOTAL_NET) as TOTAL_NET    from   TABLE_VENTES_JOURNAL    Where           Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '             and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')            group by Caissier      ", Module1.cn_SQL);
				dataTable10 = new DataTable();
				dataTable10.Clear();
				((DbDataAdapter)(object)val10).Fill(dataTable10);
				if (dataTable10.Rows.Count > 0)
				{
					DataGridView3.Rows.Add(new object[1] { "---------------CAISSIERS-----------------" });
					int num25 = dataTable10.Rows.Count - 1;
					int num26 = 0;
					while (true)
					{
						int num27 = num26;
						int num4 = num25;
						if (num27 > num4)
						{
							break;
						}
						DataGridView3.Rows.Add(new object[1] { Strings.LSet("- " + dataTable10.Rows[num26]["Caissier"].ToString(), 22) + ":      " + Strings.RSet(Strings.FormatNumber(Conversion.Val(dataTable10.Rows[num26]["TOTAL_NET"].ToString())), 8) + " DH" });
						num26++;
					}
					DataGridView3.Rows.Add(new object[1] { "" });
					DataGridView3.Rows.Add(new object[1] { "" });
				}
				val10 = new MySqlDataAdapter("select VENDEUR, sum(TOTAL_NET) as TOTAL_NET    from   TABLE_VENTES_JOURNAL    Where        VENDEUR <> ''        and      Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '             and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')            group by VENDEUR      ", Module1.cn_SQL);
				dataTable10 = new DataTable();
				dataTable10.Clear();
				((DbDataAdapter)(object)val10).Fill(dataTable10);
				if (dataTable10.Rows.Count > 0)
				{
					DataGridView3.Rows.Add(new object[1] { "---------------VENDEURS------------------" });
					int num28 = dataTable10.Rows.Count - 1;
					int num29 = 0;
					while (true)
					{
						int num30 = num29;
						int num4 = num28;
						if (num30 > num4)
						{
							break;
						}
						DataGridView3.Rows.Add(new object[1] { Strings.LSet("- " + dataTable10.Rows[num29]["VENDEUR"].ToString(), 22) + ":      " + Strings.RSet(Strings.FormatNumber(Conversion.Val(dataTable10.Rows[num29]["TOTAL_NET"].ToString())), 8) + " DH" });
						num29++;
					}
					DataGridView3.Rows.Add(new object[1] { "" });
					DataGridView3.Rows.Add(new object[1] { "" });
				}
				val10 = new MySqlDataAdapter("select GROUPE, sum(TOTAL_NET) as TOTAL_NET     from   TABLE_VENTES_JOURNAL    Where           Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '             and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')            group by GROUPE      ", Module1.cn_SQL);
				dataTable10 = new DataTable();
				dataTable10.Clear();
				((DbDataAdapter)(object)val10).Fill(dataTable10);
				if (dataTable10.Rows.Count > 0)
				{
					DataGridView3.Rows.Add(new object[1] { "---------------GROUPES-------------------" });
					int num31 = dataTable10.Rows.Count - 1;
					int num32 = 0;
					while (true)
					{
						int num33 = num32;
						int num4 = num31;
						if (num33 > num4)
						{
							break;
						}
						DataGridView3.Rows.Add(new object[1] { Strings.LSet("- " + dataTable10.Rows[num32]["GROUPE"].ToString(), 22) + ":      " + Strings.RSet(Strings.FormatNumber(Conversion.Val(dataTable10.Rows[num32]["TOTAL_NET"].ToString())), 8) + " DH" });
						num32++;
					}
					DataGridView3.Rows.Add(new object[1] { "" });
					DataGridView3.Rows.Add(new object[1] { "" });
				}
				MySqlDataAdapter val11 = new MySqlDataAdapter();
				DataTable dataTable11 = new DataTable();
				val11 = new MySqlDataAdapter("(select sum(Total_NET) as n from TABLE_VENTES_JOURNAL WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '            and            (OPERATION = 'RETOUR REMBOURSEMENT')     )    UNION ALL  (select sum(Total_NET) as n from TABLE_VENTES_JOURNAL WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '            and            (OPERATION = 'RETOUR AVOIR')    )       UNION ALL  (select sum(Total_NET) as n from TABLE_VENTES_JOURNAL WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '            and            (OPERATION = 'CREDIT')    )             UNION ALL  (select sum(Total_NET) as n from TABLE_VENTES_JOURNAL WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '            and            (OPERATION = 'RETOUR CREDIT')    )   ", Module1.cn_SQL);
				dataTable11 = new DataTable();
				dataTable11.Clear();
				((DbDataAdapter)(object)val11).Fill(dataTable11);
				decimal num34 = new decimal(Conversion.Val(dataTable11.Rows[0]["n"].ToString()));
				decimal num35 = new decimal(Conversion.Val(dataTable11.Rows[1]["n"].ToString()));
				decimal num36 = new decimal(Conversion.Val(dataTable11.Rows[2]["n"].ToString()));
				decimal num37 = new decimal(Conversion.Val(dataTable11.Rows[3]["n"].ToString()));
				if ((decimal.Compare(num34, 0m) != 0) | (decimal.Compare(num35, 0m) != 0) | (decimal.Compare(num36, 0m) != 0) | (decimal.Compare(num37, 0m) != 0))
				{
					DataGridView3.Rows.Add(new object[1] { "---------------ATTENTION-----------------" });
				}
				if (decimal.Compare(num34, 0m) != 0)
				{
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("RETOUR REMBOURSEMENT  : ", 29) + Strings.RSet(Conversions.ToString(num34), 8) + " DH" });
					Module1._DT_TEMP.Clear();
					Module1._DA_TEMP = new MySqlDataAdapter("select Article, sum(Qté) as Qté   from   TABLE_VENTES_JOURNAL    Where              Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '             and            (OPERATION = 'RETOUR REMBOURSEMENT')               group by Article      ", Module1.cn_SQL);
					((DbDataAdapter)(object)Module1._DA_TEMP).Fill(Module1._DT_TEMP);
					int num38 = Module1._DT_TEMP.Rows.Count - 1;
					int num39 = 0;
					while (true)
					{
						int num40 = num39;
						int num4 = num38;
						if (num40 > num4)
						{
							break;
						}
						DataGridView3.Rows.Add(new object[1] { "  " + Strings.LSet(Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(Module1._DT_TEMP.Rows[num39]["Qté"].ToString()))) + "x", 7) + Module1._DT_TEMP.Rows[num39]["Article"].ToString() });
						num39++;
					}
				}
				if (decimal.Compare(num35, 0m) != 0)
				{
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("RETOUR AVOIR          : ", 29) + Strings.RSet(Conversions.ToString(num35), 8) + " DH" });
					Module1._DT_TEMP.Clear();
					Module1._DA_TEMP = new MySqlDataAdapter("select Article, sum(Qté) as Qté   from   TABLE_VENTES_JOURNAL    Where              Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '             and            (OPERATION = 'RETOUR AVOIR')               group by Article      ", Module1.cn_SQL);
					((DbDataAdapter)(object)Module1._DA_TEMP).Fill(Module1._DT_TEMP);
					int num41 = Module1._DT_TEMP.Rows.Count - 1;
					int num42 = 0;
					while (true)
					{
						int num43 = num42;
						int num4 = num41;
						if (num43 > num4)
						{
							break;
						}
						DataGridView3.Rows.Add(new object[1] { "  " + Strings.LSet(Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(Module1._DT_TEMP.Rows[num42]["Qté"].ToString()))) + "x", 7) + Module1._DT_TEMP.Rows[num42]["Article"].ToString() });
						num42++;
					}
				}
				if (decimal.Compare(num36, 0m) != 0)
				{
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("CREDIT                : ", 29) + Strings.RSet(Conversions.ToString(num36), 8) + " DH" });
					Module1._DT_TEMP.Clear();
					Module1._DA_TEMP = new MySqlDataAdapter("select Article, sum(Qté) as Qté   from   TABLE_VENTES_JOURNAL    Where              Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '             and            (OPERATION = 'CREDIT')               group by Article      ", Module1.cn_SQL);
					((DbDataAdapter)(object)Module1._DA_TEMP).Fill(Module1._DT_TEMP);
					int num44 = Module1._DT_TEMP.Rows.Count - 1;
					int num45 = 0;
					while (true)
					{
						int num46 = num45;
						int num4 = num44;
						if (num46 > num4)
						{
							break;
						}
						DataGridView3.Rows.Add(new object[1] { "  " + Strings.LSet(Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(Module1._DT_TEMP.Rows[num45]["Qté"].ToString()))) + "x", 7) + Module1._DT_TEMP.Rows[num45]["Article"].ToString() });
						num45++;
					}
				}
				if (decimal.Compare(num37, 0m) != 0)
				{
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("RETOUR CREDIT         : ", 29) + Strings.RSet(Conversions.ToString(num37), 8) + " DH" });
					Module1._DT_TEMP.Clear();
					Module1._DA_TEMP = new MySqlDataAdapter("select Article, sum(Qté) as Qté   from   TABLE_VENTES_JOURNAL    Where              Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '             and            (OPERATION = 'RETOUR CREDIT')               group by Article      ", Module1.cn_SQL);
					((DbDataAdapter)(object)Module1._DA_TEMP).Fill(Module1._DT_TEMP);
					int num47 = Module1._DT_TEMP.Rows.Count - 1;
					int num48 = 0;
					while (true)
					{
						int num49 = num48;
						int num4 = num47;
						if (num49 > num4)
						{
							break;
						}
						DataGridView3.Rows.Add(new object[1] { "  " + Strings.LSet(Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(Module1._DT_TEMP.Rows[num48]["Qté"].ToString()))) + "x", 7) + Module1._DT_TEMP.Rows[num48]["Article"].ToString() });
						num48++;
					}
				}
				DataGridView3.Rows.Add(new object[1] { "" });
				DataGridView3.Rows.Add(new object[1] { "" });
				if (Operators.CompareString(MyProject.Forms.Form_0_TEMPLATE.Label_GESTION_TABLE.Text, "TABLE", TextCompare: false) == 0)
				{
					MySqlDataAdapter val12 = new MySqlDataAdapter();
					DataTable dataTable12 = new DataTable();
					decimal value = 0m;
					double num50 = Conversion.Val(File.ReadAllText(Module1._CHEMIN_FOLDER + "\\bd\\config\\TABLES_NBR.sni"));
					double num51 = 1.0;
					while (true)
					{
						double num52 = num51;
						double num53 = num50;
						if (!(num52 <= num53))
						{
							break;
						}
						val12 = new MySqlDataAdapter("Select sum(TOTAL_NET) as n      from TABLE_" + Strings.Format(num51, "00") + "  ", Module1.cn_SQL);
						dataTable12 = new DataTable();
						dataTable12.Clear();
						((DbDataAdapter)(object)val12).Fill(dataTable12);
						value = new decimal(Convert.ToDouble(value) + Conversion.Val(dataTable12.Rows[0]["n"].ToString()));
						num51++;
					}
					val12 = new MySqlDataAdapter("Select sum(TOTAL_NET) as n      from EMPORTER   ", Module1.cn_SQL);
					dataTable12 = new DataTable();
					dataTable12.Clear();
					((DbDataAdapter)(object)val12).Fill(dataTable12);
					value = new decimal(Convert.ToDouble(value) + Conversion.Val(dataTable12.Rows[0]["n"].ToString()));
					val12 = new MySqlDataAdapter("Select sum(TOTAL_NET) as n      from LIVRAISON   ", Module1.cn_SQL);
					dataTable12 = new DataTable();
					dataTable12.Clear();
					((DbDataAdapter)(object)val12).Fill(dataTable12);
					value = new decimal(Convert.ToDouble(value) + Conversion.Val(dataTable12.Rows[0]["n"].ToString()));
					if (decimal.Compare(value, 0m) != 0)
					{
						DataGridView3.Rows.Add(new object[1] { "---------------ATTENTION-----------------" });
						DataGridView3.Rows.Add(new object[1] { Strings.LSet("IL YA DES CMD EN COURS: ", 29) + Strings.RSet(Conversions.ToString(value), 8) + " DH" });
					}
					DataGridView3.Rows.Add(new object[1] { "" });
					DataGridView3.Rows.Add(new object[1] { "" });
					decimal num54 = 0m;
					val12 = new MySqlDataAdapter("Select sum(TOTAL_NET) as n      from TABLE_POUBELLE    Where  Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '  ", Module1.cn_SQL);
					dataTable12 = new DataTable();
					dataTable12.Clear();
					((DbDataAdapter)(object)val12).Fill(dataTable12);
					num54 = new decimal(Conversion.Val(dataTable12.Rows[0]["n"].ToString()));
					if (decimal.Compare(num54, 0m) != 0)
					{
						DataGridView3.Rows.Add(new object[1] { "---------------ATTENTION-----------------" });
						DataGridView3.Rows.Add(new object[1] { Strings.LSet("IL YA DES ANNULATIONS : ", 29) + Strings.RSet(Conversions.ToString(num54), 8) + " DH" });
						Module1._DT_TEMP.Clear();
						Module1._DA_TEMP = new MySqlDataAdapter("select Article, sum(Qté) as Qté   from   TABLE_POUBELLE    Where              Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '                        group by Article      ", Module1.cn_SQL);
						((DbDataAdapter)(object)Module1._DA_TEMP).Fill(Module1._DT_TEMP);
						int num55 = Module1._DT_TEMP.Rows.Count - 1;
						int num56 = 0;
						while (true)
						{
							int num57 = num56;
							int num4 = num55;
							if (num57 > num4)
							{
								break;
							}
							DataGridView3.Rows.Add(new object[1] { "  " + Strings.LSet(Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(Module1._DT_TEMP.Rows[num56]["Qté"].ToString()))) + "x", 7) + Module1._DT_TEMP.Rows[num56]["Article"].ToString() });
							num56++;
						}
					}
					DataGridView3.Rows.Add(new object[1] { "" });
					DataGridView3.Rows.Add(new object[1] { "" });
				}
				MySqlDataAdapter val13 = new MySqlDataAdapter();
				DataTable dataTable13 = new DataTable();
				val13 = new MySqlDataAdapter("(select sum(TOTAL_NET) as n     from    TABLE_VENTES_JOURNAL     WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '                and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')          And      (Notes LIKE 'TABLE%' OR Notes LIKE 'SUR PLACE%')    )      UNION ALL   (select sum(TOTAL_NET) as n     from    TABLE_VENTES_JOURNAL     WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '                  and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')         And     Notes  like 'EMPORTER%'  )      UNION ALL   (select sum(TOTAL_NET) as n     from    TABLE_VENTES_JOURNAL     WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '                and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')            And     Notes  like 'LIVRAISON%'  )       UNION ALL   (select sum(TOTAL_NET) as n     from    TABLE_VENTES_JOURNAL     WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '                and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')           And     Notes  like 'DIRECTE%'  )         ", Module1.cn_SQL);
				dataTable13 = new DataTable();
				dataTable13.Clear();
				((DbDataAdapter)(object)val13).Fill(dataTable13);
				double num58 = Conversion.Val(dataTable13.Rows[0]["n"].ToString());
				double num59 = Conversion.Val(dataTable13.Rows[1]["n"].ToString());
				double num60 = Conversion.Val(dataTable13.Rows[2]["n"].ToString());
				double num61 = Conversion.Val(dataTable13.Rows[3]["n"].ToString());
				if ((num58 != 0.0) | (num59 != 0.0) | (num60 != 0.0) | (num61 != 0.0))
				{
					DataGridView3.Rows.Add(new object[1] { "-----------------NOTES-------------------" });
				}
				if (num58 != 0.0)
				{
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("- SUR PLACE           : ", 29) + Strings.RSet(Strings.FormatNumber(num58), 8) + " DH" });
				}
				if (num59 != 0.0)
				{
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("- EMPORTER            : ", 29) + Strings.RSet(Strings.FormatNumber(num59), 8) + " DH" });
				}
				if (num60 != 0.0)
				{
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("- LIVRAISON           : ", 29) + Strings.RSet(Strings.FormatNumber(num60), 8) + " DH" });
				}
				if (num61 != 0.0)
				{
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("- DIRECTE             : ", 29) + Strings.RSet(Strings.FormatNumber(num61), 8) + " DH" });
				}
				DataGridView3.Rows.Add(new object[1] { "" });
				DataGridView3.Rows.Add(new object[1] { "" });
				MySqlDataAdapter val14 = new MySqlDataAdapter();
				DataTable dataTable14 = new DataTable();
				val14 = new MySqlDataAdapter("(select sum(TOTAL_NET) as n     from    TABLE_VENTES_JOURNAL     WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '                and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')          And      (NOTES_TYPE_PRIX = 'PRIX_1')    )      UNION ALL   (select sum(TOTAL_NET) as n     from    TABLE_VENTES_JOURNAL     WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '                  and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')         And     (NOTES_TYPE_PRIX = 'PRIX_2')  )         ", Module1.cn_SQL);
				dataTable14 = new DataTable();
				dataTable14.Clear();
				((DbDataAdapter)(object)val14).Fill(dataTable14);
				double num62 = Conversion.Val(dataTable14.Rows[0]["n"].ToString());
				double num63 = Conversion.Val(dataTable14.Rows[1]["n"].ToString());
				if ((num62 != 0.0) & (num63 != 0.0))
				{
					DataGridView3.Rows.Add(new object[1] { "-----------------NOTES-------------------" });
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("- PRIX_1              : ", 29) + Strings.RSet(Strings.FormatNumber(num62), 8) + " DH" });
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("- PRIX_2              : ", 29) + Strings.RSet(Strings.FormatNumber(num63), 8) + " DH" });
				}
				DataGridView3.Rows.Add(new object[1] { "" });
				DataGridView3.Rows.Add(new object[1] { "" });
				val11 = new MySqlDataAdapter("( select sum((PRIX_V*Qté)-TOTAL_NET) as n                    from TABLE_VENTES_JOURNAL WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '               AND     REMISE <  100 )      UNION ALL        ( select sum((PRIX_V*Qté)-TOTAL_NET) as n                  from TABLE_VENTES_JOURNAL WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '                 AND        REMISE = 100 ) UNION ALL (select sum(TOTAL_NET) as n       from TABLE_VENTES_JOURNAL WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '                     And       Famille = 'FAM_DIVERS' )  ", Module1.cn_SQL);
				dataTable11 = new DataTable();
				dataTable11.Clear();
				((DbDataAdapter)(object)val11).Fill(dataTable11);
				decimal num64 = new decimal(Conversion.Val(dataTable11.Rows[0]["n"].ToString()));
				decimal num65 = new decimal(Conversion.Val(dataTable11.Rows[1]["n"].ToString()));
				decimal num66 = new decimal(Conversion.Val(dataTable11.Rows[2]["n"].ToString()));
				if ((decimal.Compare(num64, 0m) != 0) | (decimal.Compare(num65, 0m) != 0) | (decimal.Compare(num66, 0m) != 0))
				{
					DataGridView3.Rows.Add(new object[1] { "---------------ATTENTION-----------------" });
				}
				if (decimal.Compare(num64, 0m) != 0)
				{
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("IL YA DES REMISE      : ", 29) + Strings.RSet(Conversions.ToString(num64), 8) + " DH" });
				}
				if (decimal.Compare(num65, 0m) != 0)
				{
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("IL YA DES OFFERT      : ", 29) + Strings.RSet(Conversions.ToString(num65), 8) + " DH" });
				}
				if (decimal.Compare(num66, 0m) != 0)
				{
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("IL YA DES DIVERS      : ", 29) + Strings.RSet(Conversions.ToString(num66), 8) + " DH" });
				}
				DataGridView3.Rows.Add(new object[1] { "" });
				DataGridView3.Rows.Add(new object[1] { "" });
				MySqlDataAdapter val15 = new MySqlDataAdapter();
				DataTable dataTable15 = new DataTable();
				val15 = new MySqlDataAdapter("(SELECT    count(id)      as N          FROM   TABLE_RECEPTIONS_ENTETE    WHERE       DATES   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '     )       UNION ALL    (SELECT    count(id)      as N          FROM   TABLE_SORTIES_ENTETE    WHERE       DATES   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '  )       UNION ALL    (SELECT    count(id)      as N          FROM   TABLE_INVENTAIRES_ENTETE    WHERE       DATES   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '  )  ", Module1.cn_SQL);
				dataTable15 = new DataTable();
				dataTable15.Clear();
				((DbDataAdapter)(object)val15).Fill(dataTable15);
				decimal num67 = new decimal(Conversion.Val(dataTable15.Rows[0]["n"].ToString()));
				decimal num68 = new decimal(Conversion.Val(dataTable15.Rows[1]["n"].ToString()));
				decimal num69 = new decimal(Conversion.Val(dataTable15.Rows[2]["n"].ToString()));
				if ((decimal.Compare(num67, 0m) != 0) | (decimal.Compare(num68, 0m) != 0) | (decimal.Compare(num69, 0m) != 0))
				{
					DataGridView3.Rows.Add(new object[1] { "---------------ATTENTION-----------------" });
				}
				if (decimal.Compare(num67, 0m) != 0)
				{
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("IL YA DES RECEPTIONS  : ", 29) + Strings.RSet(Conversions.ToString(num67), 8) });
				}
				if (decimal.Compare(num68, 0m) != 0)
				{
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("IL YA DES SORTIES     : ", 29) + Strings.RSet(Conversions.ToString(num68), 8) });
				}
				if (decimal.Compare(num69, 0m) != 0)
				{
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("IL YA DES INVENTAIRES : ", 29) + Strings.RSet(Conversions.ToString(num69), 8) });
				}
				DataGridView3.Rows.Add(new object[1] { "" });
				DataGridView3.Rows.Add(new object[1] { "" });
				if (Operators.CompareString(Text_PRINTER_RAPPORT.Text, "0", TextCompare: false) != 0 && Operators.CompareString(Text_PRINTER_RAPPORT.Text, "", TextCompare: false) != 0)
				{
					Print_Recette_Globale.PrinterSettings.PrinterName = Text_PRINTER_RAPPORT.Text;
				}
				if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null), "Button_ConsRapport", TextCompare: false))
				{
					PrintPreviewDialog val16 = new PrintPreviewDialog();
					val16.Document = Print_Recette_Globale;
					val16.PrintPreviewControl.Zoom = 2.0;
					((Form)val16).WindowState = (FormWindowState)2;
					((Form)val16).ShowDialog();
				}
				else if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null), "Button_PrintRapport", TextCompare: false))
				{
					if (Operators.CompareString(MyProject.Forms.Form_0_TEMPLATE.TextBox_BRANCHEMENT.Text, "USB", TextCompare: false) == 0)
					{
						Print_Recette_Globale.Print();
					}
					else
					{
						Print_Recette_Globale_COM();
					}
					Button_MAIL_GLOBALE_Click(RuntimeHelpers.GetObjectValue(sender), e);
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
				NewLateBinding.LateSet(sender, null, "enabled", new object[1] { true }, null, null);
				Interaction.MsgBox(ex2.Message + "\r\nLigne : " + Conversions.ToString(fileLineNumber) + "\r\n");
				try
				{
					string text = Strings.Format(DateTime.Now, "yyMMddHHmmssfff");
					Bitmap val17 = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, (PixelFormat)2498570);
					Graphics val18 = Graphics.FromImage((Image)(object)val17);
					val18.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, (CopyPixelOperation)13369376);
					((Image)val17).Save(Application.StartupPath + "\\tchak\\" + text + ".snidb", ImageFormat.Jpeg);
					val17 = null;
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

	private void Button_Click(object sender, EventArgs e)
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected Obj, but got Unknown
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected Obj, but got Unknown
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected Obj, but got Unknown
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Expected Obj, but got Unknown
		//IL_0417: Unknown result type (might be due to invalid IL or missing references)
		//IL_041e: Expected Obj, but got Unknown
		//IL_044d: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			try
			{
				if (Operators.CompareString(ListBox_VENDEURS.Text, "GLOBALE VENDEURS", TextCompare: false) == 0)
				{
					Button_ConsGlobaleVendeur_Click(RuntimeHelpers.GetObjectValue(sender), e);
					return;
				}
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
				dataTable.Clear();
				val = new MySqlDataAdapter("select DISTINCT Famille from TABLE_VENTES_JOURNAL   Where  Dates   between        ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '        And        ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '        And       Vendeur like  '" + Strings.Trim(ListBox_VENDEURS.Text) + "'                     and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')        ", Module1.cn_SQL);
				((DbDataAdapter)(object)val).Fill(dataTable);
				DataTable dataTable2 = new DataTable();
				MySqlDataAdapter val2 = new MySqlDataAdapter();
				DataGridView2.Rows.Clear();
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
						dataTable.Rows[num2]["Famille"].ToString(),
						".",
						""
					});
					dataTable2.Clear();
					val2 = new MySqlDataAdapter("select Article, sum(Qté) as QTé, sum(TOTAL_NET) as TOTAL_NET    from   TABLE_VENTES_JOURNAL    Where  Famille = '" + Strings.Trim(dataTable.Rows[num2]["Famille"].ToString()) + "'         And        Vendeur like  '" + Strings.Trim(ListBox_VENDEURS.Text) + "'     and    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '              and           (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')       group by Article      ", Module1.cn_SQL);
					((DbDataAdapter)(object)val2).Fill(dataTable2);
					int num5 = dataTable2.Rows.Count - 1;
					int num6 = 0;
					while (true)
					{
						int num7 = num6;
						num4 = num5;
						if (num7 > num4)
						{
							break;
						}
						DataGridView2.Rows.Add(new object[3]
						{
							"  " + dataTable2.Rows[num6]["Article"].ToString(),
							dataTable2.Rows[num6]["Qté"].ToString(),
							dataTable2.Rows[num6]["TOTAL_NET"].ToString()
						});
						num6++;
					}
					DataGridView2.Rows.Add(new object[3] { "", "", "" });
					num2++;
				}
				if (Operators.CompareString(Text_PRINTER_RAPPORT.Text, "0", TextCompare: false) != 0 && Operators.CompareString(Text_PRINTER_RAPPORT.Text, "", TextCompare: false) != 0)
				{
					Print_Recette_vendeur.PrinterSettings.PrinterName = Text_PRINTER_RAPPORT.Text;
				}
				if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null), "Button_ConsVendeur", TextCompare: false))
				{
					PrintPreviewDialog val3 = new PrintPreviewDialog();
					val3.Document = Print_Recette_vendeur;
					val3.PrintPreviewControl.Zoom = 2.0;
					((Form)val3).WindowState = (FormWindowState)2;
					((Form)val3).ShowDialog();
				}
				else if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null), "Button_PrintVendeur", TextCompare: false))
				{
					if (Operators.CompareString(MyProject.Forms.Form_0_TEMPLATE.TextBox_BRANCHEMENT.Text, "USB", TextCompare: false) == 0)
					{
						Print_Recette_vendeur.Print();
					}
					else
					{
						Print_Recette_vendeur_COM();
					}
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

	private void Button_OK_Click(object sender, EventArgs e)
	{
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected Obj, but got Unknown
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected Obj, but got Unknown
		try
		{
			DT.Clear();
			DA = new MySqlDataAdapter("select * from   TABLE_VENTES_JOURNAL     Where  Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '    order by ID desc ", Module1.cn_SQL);
			((DbDataAdapter)(object)DA).Fill(DT);
			DataGridView1.DataSource = DT;
			_COLORISE_DATAGRID();
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

	private void Button14_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected Obj, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Invalid comparison between Unknown and I4
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Expected Obj, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected Obj, but got Unknown
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected Obj, but got Unknown
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			try
			{
				SaveFileDialog val = new SaveFileDialog();
				((FileDialog)val).Filter = "Text Files (*.csv)|*.csv";
				((FileDialog)val).FileName = "JOURNAL_" + DateTime.Now.ToString("dd-MM-yyy HH-mm-ss");
				if (unchecked((int)((CommonDialog)val).ShowDialog()) != 1)
				{
					return;
				}
				DataTable dataTable = new DataTable();
				MySqlDataAdapter val2 = new MySqlDataAdapter();
				dataTable.Clear();
				dataTable = new DataTable();
				val2 = new MySqlDataAdapter("select   Ticket,Dates,Heure,Code,Article,Famille,PRIX_A,PRIX_MP,PRIX_V,Qté,Remise,TOTAL_NET,Caissier,Vendeur,CODE_CLIENT,CLIENT,POSTE,OPERATION,CLOTURE_CAISSIER,CLOTURE_GLOBALE,NOTES    from    TABLE_VENTES_JOURNAL   WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '   ", Module1.cn_SQL);
				((DbDataAdapter)(object)val2).Fill(dataTable);
				StringBuilder stringBuilder = new StringBuilder();
				string text = "";
				int num = dataTable.Columns.Count - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					text = text + dataTable.Columns[num2].ColumnName.ToString() + ";";
					num2++;
				}
				stringBuilder.AppendLine(text);
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
					string text2 = "";
					int num8 = dataTable.Columns.Count - 1;
					int num9 = 0;
					while (true)
					{
						int num10 = num9;
						num4 = num8;
						if (num10 > num4)
						{
							break;
						}
						text2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(text2, dataTable.Rows[num6][dataTable.Columns[num9].ColumnName.ToString()]), ";"));
						num9++;
					}
					stringBuilder.AppendLine(text2);
					num6++;
				}
				File.WriteAllText(((FileDialog)val).FileName, stringBuilder.ToString(), Encoding.Default);
				MessageBox.Show("Exportation avec succès", "ok", (MessageBoxButtons)0, (MessageBoxIcon)64, (MessageBoxDefaultButton)0);
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
					string text3 = Strings.Format(DateTime.Now, "yyMMddHHmmssfff");
					Bitmap val3 = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, (PixelFormat)2498570);
					Graphics val4 = Graphics.FromImage((Image)(object)val3);
					val4.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, (CopyPixelOperation)13369376);
					((Image)val3).Save(Application.StartupPath + "\\tchak\\" + text3 + ".snidb", ImageFormat.Jpeg);
					val3 = null;
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
	}

	private void Button5_Click(object sender, EventArgs e)
	{
		DateTimePicker1.Value = DateTimePicker1.Value.AddDays(-1.0);
		DateTimePicker2.Value = DateTimePicker2.Value.AddDays(-1.0);
	}

	private void Button20_Click(object sender, EventArgs e)
	{
		DateTimePicker1.Value = DateTimePicker1.Value.AddDays(1.0);
		DateTimePicker2.Value = DateTimePicker2.Value.AddDays(1.0);
	}

	private void Button_ConsFamille_Click(object sender, EventArgs e)
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected Obj, but got Unknown
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected Obj, but got Unknown
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Expected Obj, but got Unknown
		//IL_03c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c9: Expected Obj, but got Unknown
		//IL_03f8: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			try
			{
				if (Operators.CompareString(ListBox_FAMILLES.Text, "GLOBALE FAMILLES", TextCompare: false) == 0)
				{
					Button_ConsGlobaleFamille_click(RuntimeHelpers.GetObjectValue(sender), e);
					return;
				}
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
				dataTable.Clear();
				dataTable.Columns.Add("Famille");
				dataTable.Rows.Add(Strings.Trim(ListBox_FAMILLES.Text));
				DataTable dataTable2 = new DataTable();
				MySqlDataAdapter val2 = new MySqlDataAdapter();
				DataGridView2.Rows.Clear();
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
						dataTable.Rows[num2]["Famille"].ToString(),
						".",
						""
					});
					dataTable2.Clear();
					val2 = new MySqlDataAdapter("select Article, sum(Qté) as QTé, sum(TOTAL_NET) as TOTAL_NET    from   TABLE_VENTES_JOURNAL    Where  Famille = '" + Strings.Trim(dataTable.Rows[num2]["Famille"].ToString()) + "'         and    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '              and           (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')       group by Article      ", Module1.cn_SQL);
					((DbDataAdapter)(object)val2).Fill(dataTable2);
					int num5 = dataTable2.Rows.Count - 1;
					int num6 = 0;
					while (true)
					{
						int num7 = num6;
						num4 = num5;
						if (num7 > num4)
						{
							break;
						}
						DataGridView2.Rows.Add(new object[3]
						{
							"  " + dataTable2.Rows[num6]["Article"].ToString(),
							Strings.FormatNumber(Conversion.Val(dataTable2.Rows[num6]["Qté"].ToString())),
							Strings.FormatNumber(Conversion.Val(dataTable2.Rows[num6]["TOTAL_NET"].ToString()))
						});
						num6++;
					}
					DataGridView2.Rows.Add(new object[3] { "", "", "" });
					num2++;
				}
				if (Operators.CompareString(Text_PRINTER_RAPPORT.Text, "0", TextCompare: false) != 0 && Operators.CompareString(Text_PRINTER_RAPPORT.Text, "", TextCompare: false) != 0)
				{
					Print_Recette_Famille.PrinterSettings.PrinterName = Text_PRINTER_RAPPORT.Text;
				}
				if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null), "Button_ConsFamille", TextCompare: false))
				{
					PrintPreviewDialog val3 = new PrintPreviewDialog();
					val3.Document = Print_Recette_Famille;
					val3.PrintPreviewControl.Zoom = 2.0;
					((Form)val3).WindowState = (FormWindowState)2;
					((Form)val3).ShowDialog();
				}
				else if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null), "Button_PrintFamille", TextCompare: false))
				{
					if (Operators.CompareString(MyProject.Forms.Form_0_TEMPLATE.TextBox_BRANCHEMENT.Text, "USB", TextCompare: false) == 0)
					{
						Print_Recette_Famille.Print();
					}
					else
					{
						Print_Recette_Famille_COM();
					}
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

	private void Combo_FAMILLES_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	public void Button_MAIL_GLOBALE_Click(object sender, EventArgs e)
	{
		//IL_0708: Unknown result type (might be due to invalid IL or missing references)
		//IL_070f: Expected Obj, but got Unknown
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Expected Obj, but got Unknown
		//IL_0395: Unknown result type (might be due to invalid IL or missing references)
		//IL_039c: Expected Obj, but got Unknown
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Expected Obj, but got Unknown
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Expected Obj, but got Unknown
		checked
		{
			try
			{
				if (Operators.CompareString(Text_mail.Text, "", TextCompare: false) == 0)
				{
					return;
				}
				Thread thread = new Thread([SpecialName] () =>
				{
					//IL_0009: Unknown result type (might be due to invalid IL or missing references)
					try
					{
						FormDialog_PATIENTER formDialog_PATIENTER = new FormDialog_PATIENTER();
						((Form)formDialog_PATIENTER).ShowDialog();
					}
					catch (Exception ex5)
					{
						ProjectData.SetProjectError(ex5);
						Exception e2 = ex5;
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
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.AppendLine("<html><body><center>");
				stringBuilder.AppendLine("<table width='100%' border='1' cellpadding='6' cellspacing='0' style=' border: 1px solid rgb(22,106,238);'  >");
				stringBuilder.AppendLine("<tr width='100%'  align='center' valign='center' style='background-color: rgb(22,106,238);color: white; font-size : 25px;font-weight: bold; border: 2px solid rgb(22,106,238);' >RAPPORT GLOBALE</tr>");
				stringBuilder.AppendLine("<table width='100%' border='1' cellpadding='6' cellspacing='0' style=' border: 1px solid rgb(22,106,238);'   >");
				stringBuilder.AppendLine("<tr>");
				int num = ((BaseCollection)DataGridView2.Columns).Count - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					if (num2 == 0)
					{
						stringBuilder.AppendLine("<td align='left' valign='middle' style='background-color: yellow'   span='2' width='50%' >ARTICLE</td>");
					}
					if (num2 == 1)
					{
						stringBuilder.AppendLine("<td align='left' valign='middle' style='background-color: yellow'   span='2' width='25%' >QUANTITE</td>");
					}
					if (num2 == 2)
					{
						stringBuilder.AppendLine("<td align='left' valign='middle' style='background-color: yellow'   span='2' width='25%' >TOTAL NET</td>");
					}
					num2++;
				}
				stringBuilder.AppendLine("<tr>");
				int num5 = DataGridView2.Rows.Count - 1;
				int num6 = 0;
				while (true)
				{
					int num7 = num6;
					int num4 = num5;
					if (num7 > num4)
					{
						break;
					}
					stringBuilder.AppendLine("<tr>");
					foreach (DataGridViewCell item in (BaseCollection)DataGridView2.Rows[num6].Cells)
					{
						DataGridViewCell val = item;
						stringBuilder.AppendLine("<td align='left' valign='middle'>" + val.Value.ToString() + "</td>");
					}
					stringBuilder.AppendLine("</tr>");
					num6++;
				}
				stringBuilder.AppendLine("</table></center></body></html>");
				StringBuilder stringBuilder2 = new StringBuilder();
				stringBuilder2.AppendLine("<html><body><center>");
				stringBuilder2.AppendLine("<table width='100%' border='0' cellpadding='6' cellspacing='0' >");
				stringBuilder2.AppendLine("<tr>");
				int num8 = DataGridView3.Rows.Count - 1;
				int num9 = 0;
				while (true)
				{
					int num10 = num9;
					int num4 = num8;
					if (num10 > num4)
					{
						break;
					}
					stringBuilder2.AppendLine("<tr>");
					foreach (DataGridViewCell item2 in (BaseCollection)DataGridView3.Rows[num9].Cells)
					{
						DataGridViewCell val2 = item2;
						stringBuilder2.AppendLine("<td align='left' valign='middle'>" + val2.Value.ToString() + "</td>");
					}
					stringBuilder2.AppendLine("</tr>");
					num9++;
				}
				stringBuilder2.AppendLine("</table></center></body></html>");
				double num11 = 0.0;
				DataTable dataTable = new DataTable();
				MySqlDataAdapter val3 = new MySqlDataAdapter();
				dataTable.Clear();
				val3 = new MySqlDataAdapter("select sum(Total_NET) as n     from TABLE_VENTES_JOURNAL WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '        and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')     ", Module1.cn_SQL);
				((DbDataAdapter)(object)val3).Fill(dataTable);
				num11 = Conversions.ToDouble(Strings.FormatNumber(Conversion.Val(dataTable.Rows[0]["n"].ToString())));
				string text = "<br/><br/> <b style='background-color: White ;color: Black; font-size : 18px ; font-weight: bold'>● " + MyProject.Forms.Form_1_LOGIN.TextBox_ORGANISME.Text + Text_MAIL_TITRE.Text + "</b>";
				string text2 = "<br/><br/> <b style='background-color: White ;color: Black; font-size : 18px ; font-weight: bold'>● Date Rapport    : " + Strings.Format(DateTimePicker1.Value, "dd/MM/yyyy") + "  A  " + Strings.Format(DateTimePicker2.Value, "dd/MM/yyyy") + "</b>";
				string text3 = "<br/><br/> <b style='background-color: White ;color: Black; font-size : 18px ; font-weight: bold'>● Date Impression : " + Conversions.ToString(DateTime.Now) + "</b>";
				string text4 = "<br/><br/> <b style='background-color: White ;color: Black; font-size : 18px ; font-weight: bold'>● Total Net       : " + Strings.FormatNumber(Strings.RSet(Conversions.ToString(num11), 8)) + "  DH</b>";
				MailMessage mailMessage = new MailMessage();
				mailMessage.From = new MailAddress("logica.application@gmail.com");
				mailMessage.To.Add(Text_mail.Text);
				mailMessage.Subject = "Rapport Globale (" + MyProject.Forms.Form_1_LOGIN.TextBox_ORGANISME.Text + Text_MAIL_TITRE.Text + ") De " + Strings.Format(DateTimePicker1.Value, "dd/MM") + "  A  " + Strings.Format(DateTimePicker2.Value, "dd/MM");
				mailMessage.Body = text + text2 + text3 + text4 + "<br/><br/><br/><br/>" + stringBuilder.ToString() + "<br/><br/><br/><br/>" + stringBuilder2.ToString();
				mailMessage.IsBodyHtml = true;
				mailMessage.BodyEncoding = Encoding.UTF8;
				SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
				smtpClient.Port = 587;
				smtpClient.EnableSsl = true;
				smtpClient.Credentials = new NetworkCredential("logica.application@gmail.com", "uvwauedhmlgwqkwc");
				smtpClient.Send(mailMessage);
				Module1._QUITTER_PATIENTER = true;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				StackTrace stackTrace = new StackTrace(ex2, fNeedFileInfo: true);
				StackFrame frame = stackTrace.GetFrame(stackTrace.FrameCount - 1);
				int fileLineNumber = frame.GetFileLineNumber();
				Module1._QUITTER_PATIENTER = true;
				NewLateBinding.LateSet(sender, null, "enabled", new object[1] { true }, null, null);
				Interaction.MsgBox(ex2.Message + "\r\nLigne : " + Conversions.ToString(fileLineNumber) + "\r\n");
				try
				{
					string text5 = Strings.Format(DateTime.Now, "yyMMddHHmmssfff");
					Bitmap val4 = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, (PixelFormat)2498570);
					Graphics val5 = Graphics.FromImage((Image)(object)val4);
					val5.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, (CopyPixelOperation)13369376);
					((Image)val4).Save(Application.StartupPath + "\\tchak\\" + text5 + ".snidb", ImageFormat.Jpeg);
					val4 = null;
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

	public void Button_MAIL_CAISSIER_Click(object sender, EventArgs e)
	{
		//IL_0770: Unknown result type (might be due to invalid IL or missing references)
		//IL_0777: Expected Obj, but got Unknown
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Expected Obj, but got Unknown
		//IL_03b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bb: Expected Obj, but got Unknown
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Expected Obj, but got Unknown
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Expected Obj, but got Unknown
		checked
		{
			try
			{
				if (Operators.CompareString(Text_mail.Text, "", TextCompare: false) == 0)
				{
					return;
				}
				Thread thread = new Thread([SpecialName] () =>
				{
					//IL_0009: Unknown result type (might be due to invalid IL or missing references)
					try
					{
						FormDialog_PATIENTER formDialog_PATIENTER = new FormDialog_PATIENTER();
						((Form)formDialog_PATIENTER).ShowDialog();
					}
					catch (Exception ex5)
					{
						ProjectData.SetProjectError(ex5);
						Exception e2 = ex5;
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
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.AppendLine("<html><body><center>");
				stringBuilder.AppendLine("<table width='100%' border='1' cellpadding='6' cellspacing='0' style=' border: 1px solid rgb(22,106,238);'  >");
				stringBuilder.AppendLine("<tr width='100%'  align='center' valign='center' style='background-color: rgb(22,106,238);color: white; font-size : 25px;font-weight: bold; border: 2px solid rgb(22,106,238);' >RAPPORT CAISSIER</tr>");
				stringBuilder.AppendLine("<table width='100%' border='1' cellpadding='6' cellspacing='0' style=' border: 1px solid rgb(22,106,238);'   >");
				stringBuilder.AppendLine("<tr>");
				int num = ((BaseCollection)DataGridView2.Columns).Count - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					if (num2 == 0)
					{
						stringBuilder.AppendLine("<td align='left' valign='middle' style='background-color: yellow'   span='2' width='50%' >ARTICLE</td>");
					}
					if (num2 == 1)
					{
						stringBuilder.AppendLine("<td align='left' valign='middle' style='background-color: yellow'   span='2' width='25%' >QUANTITE</td>");
					}
					if (num2 == 2)
					{
						stringBuilder.AppendLine("<td align='left' valign='middle' style='background-color: yellow'   span='2' width='25%' >TOTAL NET</td>");
					}
					num2++;
				}
				stringBuilder.AppendLine("<tr>");
				int num5 = DataGridView2.Rows.Count - 1;
				int num6 = 0;
				while (true)
				{
					int num7 = num6;
					int num4 = num5;
					if (num7 > num4)
					{
						break;
					}
					stringBuilder.AppendLine("<tr>");
					foreach (DataGridViewCell item in (BaseCollection)DataGridView2.Rows[num6].Cells)
					{
						DataGridViewCell val = item;
						stringBuilder.AppendLine("<td align='left' valign='middle'>" + val.Value.ToString() + "</td>");
					}
					stringBuilder.AppendLine("</tr>");
					num6++;
				}
				stringBuilder.AppendLine("</table></center></body></html>");
				StringBuilder stringBuilder2 = new StringBuilder();
				stringBuilder2.AppendLine("<html><body><center>");
				stringBuilder2.AppendLine("<table width='100%' border='0' cellpadding='6' cellspacing='0' >");
				stringBuilder2.AppendLine("<tr>");
				int num8 = DataGridView3.Rows.Count - 1;
				int num9 = 0;
				while (true)
				{
					int num10 = num9;
					int num4 = num8;
					if (num10 > num4)
					{
						break;
					}
					stringBuilder2.AppendLine("<tr>");
					foreach (DataGridViewCell item2 in (BaseCollection)DataGridView3.Rows[num9].Cells)
					{
						DataGridViewCell val2 = item2;
						stringBuilder2.AppendLine("<td align='left' valign='middle'>" + val2.Value.ToString() + "</td>");
					}
					stringBuilder2.AppendLine("</tr>");
					num9++;
				}
				stringBuilder2.AppendLine("</table></center></body></html>");
				double num11 = 0.0;
				DataTable dataTable = new DataTable();
				MySqlDataAdapter val3 = new MySqlDataAdapter();
				dataTable.Clear();
				val3 = new MySqlDataAdapter("select sum(Total_NET) as n     from TABLE_VENTES_JOURNAL WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '        And     Caissier like  '" + Strings.Trim(ListBox_CAISSIERS.Text) + "'          and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')      ", Module1.cn_SQL);
				((DbDataAdapter)(object)val3).Fill(dataTable);
				num11 = Conversions.ToDouble(Strings.FormatNumber(Conversion.Val(dataTable.Rows[0]["n"].ToString())));
				string text = "<br/><br/> <b style='background-color: White ;color: Black; font-size : 18px ; font-weight: bold'>● " + MyProject.Forms.Form_1_LOGIN.TextBox_ORGANISME.Text + Text_MAIL_TITRE.Text + "</b>";
				string text2 = "<br/><br/> <b style='background-color: White;color: Black; font-size : 18px  ; font-weight: bold'>● Date Rapport    : " + Strings.Format(DateTimePicker1.Value, "dd/MM/yyyy") + "  A  " + Strings.Format(DateTimePicker2.Value, "dd/MM/yyyy") + "</b>";
				string text3 = "<br/><br/> <b style='background-color: White;color: Black; font-size : 18px  ; font-weight: bold'>● Date Impression : " + Conversions.ToString(DateTime.Now) + "</b>";
				string text4 = "<br/><br/> <b style='background-color: White;color: Black; font-size : 18px  ; font-weight: bold'>● Total Net : " + Strings.FormatNumber(Strings.RSet(Conversions.ToString(num11), 8)) + "  DH</b>";
				string text5 = "<br/><br/> <b style='background-color: White;color: Black; font-size : 18px  ; font-weight: bold'>● Caissier  : " + Strings.Trim(ListBox_CAISSIERS.Text) + "</b>";
				MailMessage mailMessage = new MailMessage();
				mailMessage.From = new MailAddress("logica.application@gmail.com");
				mailMessage.To.Add(Text_mail.Text);
				mailMessage.Subject = "Rapport " + Strings.Trim(ListBox_CAISSIERS.Text) + " (" + MyProject.Forms.Form_1_LOGIN.TextBox_ORGANISME.Text + Text_MAIL_TITRE.Text + ") De " + Strings.Format(DateTimePicker1.Value, "dd/MM") + "  A  " + Strings.Format(DateTimePicker2.Value, "dd/MM");
				mailMessage.Body = text + text2 + text3 + text4 + text5 + "<br/><br/><br/><br/>" + stringBuilder.ToString() + "<br/><br/><br/><br/>" + stringBuilder2.ToString();
				mailMessage.IsBodyHtml = true;
				mailMessage.BodyEncoding = Encoding.UTF8;
				SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
				smtpClient.Port = 587;
				smtpClient.EnableSsl = true;
				smtpClient.Credentials = new NetworkCredential("logica.application@gmail.com", "uvwauedhmlgwqkwc");
				smtpClient.Send(mailMessage);
				Module1._QUITTER_PATIENTER = true;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				StackTrace stackTrace = new StackTrace(ex2, fNeedFileInfo: true);
				StackFrame frame = stackTrace.GetFrame(stackTrace.FrameCount - 1);
				int fileLineNumber = frame.GetFileLineNumber();
				Module1._QUITTER_PATIENTER = true;
				NewLateBinding.LateSet(sender, null, "enabled", new object[1] { true }, null, null);
				Interaction.MsgBox(ex2.Message + "\r\nLigne : " + Conversions.ToString(fileLineNumber) + "\r\n");
				try
				{
					string text6 = Strings.Format(DateTime.Now, "yyMMddHHmmssfff");
					Bitmap val4 = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, (PixelFormat)2498570);
					Graphics val5 = Graphics.FromImage((Image)(object)val4);
					val5.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, (CopyPixelOperation)13369376);
					((Image)val4).Save(Application.StartupPath + "\\tchak\\" + text6 + ".snidb", ImageFormat.Jpeg);
					val4 = null;
					string right = "ERROR | ";
					File.AppendAllText(Application.StartupPath + "\\log_erreur.sni", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(text6 + " | ", MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text), " | "), Module1._USERNAME), " | "), ((Control)this).Name), " | "), NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null)), " | "), right), " | "), ex2.ToString()), "\r\n"), "Ligne : "), fileLineNumber), "\r\n"), "\r\n"), "##########################################################################################################"), "\r\n")), Encoding.UTF8);
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

	private void Combo_CAISSIERS_SelectedIndexChanged(object sender, EventArgs e)
	{
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Expected Obj, but got Unknown
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected Obj, but got Unknown
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected Obj, but got Unknown
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected Obj, but got Unknown
		try
		{
			if (ListBox_CAISSIERS.SelectedIndex != 0)
			{
				DT.Clear();
				DA = new MySqlDataAdapter("select * from   TABLE_VENTES_JOURNAL     Where  Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '       And     Caissier like  '" + Strings.Trim(ListBox_CAISSIERS.Text) + "'  order by ID desc ", Module1.cn_SQL);
				((DbDataAdapter)(object)DA).Fill(DT);
				DataGridView1.DataSource = DT;
				DataTable dataTable = new DataTable();
				MySqlDataAdapter val = new MySqlDataAdapter();
				dataTable.Clear();
				dataTable = new DataTable();
				val = new MySqlDataAdapter("select sum(Total_NET) as n from TABLE_VENTES_JOURNAL WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '       And     Caissier like  '" + Strings.Trim(ListBox_CAISSIERS.Text) + "'    ", Module1.cn_SQL);
				((DbDataAdapter)(object)val).Fill(dataTable);
				Label_CAISSIER.Text = Strings.FormatNumber(Conversion.Val(dataTable.Rows[0]["n"].ToString()));
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

	private void Button12_Click(object sender, EventArgs e)
	{
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected Obj, but got Unknown
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected Obj, but got Unknown
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected Obj, but got Unknown
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Expected Obj, but got Unknown
		//IL_0597: Unknown result type (might be due to invalid IL or missing references)
		//IL_059e: Expected Obj, but got Unknown
		//IL_0635: Unknown result type (might be due to invalid IL or missing references)
		//IL_063c: Expected Obj, but got Unknown
		//IL_0646: Unknown result type (might be due to invalid IL or missing references)
		//IL_064d: Expected Obj, but got Unknown
		//IL_044b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0452: Expected Obj, but got Unknown
		//IL_072d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0734: Expected Obj, but got Unknown
		//IL_0861: Unknown result type (might be due to invalid IL or missing references)
		//IL_0867: Expected Obj, but got Unknown
		//IL_08fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0903: Expected Obj, but got Unknown
		//IL_09f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_09fd: Expected Obj, but got Unknown
		//IL_0a93: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9a: Expected Obj, but got Unknown
		//IL_0b91: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b98: Expected Obj, but got Unknown
		//IL_0c2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c35: Expected Obj, but got Unknown
		//IL_0f10: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f17: Expected Obj, but got Unknown
		//IL_1111: Unknown result type (might be due to invalid IL or missing references)
		//IL_1118: Expected Obj, but got Unknown
		//IL_0d73: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d7a: Expected Obj, but got Unknown
		//IL_0e09: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e10: Expected Obj, but got Unknown
		//IL_1342: Unknown result type (might be due to invalid IL or missing references)
		//IL_134c: Expected Obj, but got Unknown
		//IL_150d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1517: Expected Obj, but got Unknown
		//IL_16d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_16e0: Expected Obj, but got Unknown
		//IL_18a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_18ab: Expected Obj, but got Unknown
		//IL_1f58: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f5f: Expected Obj, but got Unknown
		//IL_2159: Unknown result type (might be due to invalid IL or missing references)
		//IL_2160: Expected Obj, but got Unknown
		//IL_19e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_19f0: Expected Obj, but got Unknown
		//IL_1a4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a56: Expected Obj, but got Unknown
		//IL_1ac6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1acd: Expected Obj, but got Unknown
		//IL_1b21: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b28: Expected Obj, but got Unknown
		//IL_1cd4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cdb: Expected Obj, but got Unknown
		//IL_1e3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e44: Expected Obj, but got Unknown
		//IL_25d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_25d9: Expected Obj, but got Unknown
		//IL_282f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2835: Expected Obj, but got Unknown
		//IL_29b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_29be: Expected Obj, but got Unknown
		//IL_2c8b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c92: Expected Obj, but got Unknown
		//IL_2cc1: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			try
			{
				if (Operators.CompareString(ListBox_CAISSIERS.Text, "GLOBALE CAISSIERS", TextCompare: false) == 0)
				{
					Button_ConsGlobaleCaissier_Click(RuntimeHelpers.GetObjectValue(sender), e);
					return;
				}
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
				dataTable.Clear();
				val = new MySqlDataAdapter("select DISTINCT Famille from TABLE_VENTES_JOURNAL   Where  Dates   between        ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '        And        ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '        And     Caissier like  '" + Strings.Trim(ListBox_CAISSIERS.Text) + "'          and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')    ", Module1.cn_SQL);
				((DbDataAdapter)(object)val).Fill(dataTable);
				DataTable dataTable2 = new DataTable();
				MySqlDataAdapter val2 = new MySqlDataAdapter();
				DataGridView2.Rows.Clear();
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
						dataTable.Rows[num2]["Famille"].ToString(),
						".",
						""
					});
					dataTable2.Clear();
					val2 = new MySqlDataAdapter("select Article, sum(Qté) as QTé, sum(TOTAL_NET) as TOTAL_NET    from   TABLE_VENTES_JOURNAL    Where  Famille = '" + Strings.Trim(dataTable.Rows[num2]["Famille"].ToString()) + "'         And     Caissier like  '" + Strings.Trim(ListBox_CAISSIERS.Text) + "'    and    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '              and           (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')      group by Article      ", Module1.cn_SQL);
					((DbDataAdapter)(object)val2).Fill(dataTable2);
					int num5 = dataTable2.Rows.Count - 1;
					int num6 = 0;
					while (true)
					{
						int num7 = num6;
						num4 = num5;
						if (num7 > num4)
						{
							break;
						}
						DataGridView2.Rows.Add(new object[3]
						{
							"  " + dataTable2.Rows[num6]["Article"].ToString(),
							Strings.FormatNumber(Conversion.Val(dataTable2.Rows[num6]["Qté"].ToString())),
							Strings.FormatNumber(Conversion.Val(dataTable2.Rows[num6]["TOTAL_NET"].ToString()))
						});
						num6++;
					}
					dataTable2.Clear();
					val2 = new MySqlDataAdapter("select  sum(Qté) as Qté, sum(TOTAL_NET) as TOTAL_NET    from   TABLE_VENTES_JOURNAL    Where  Famille = '" + Strings.Trim(dataTable.Rows[num2]["Famille"].ToString()) + "'        And     Caissier like  '" + Strings.Trim(ListBox_CAISSIERS.Text) + "'       and        Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '                and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')      ", Module1.cn_SQL);
					((DbDataAdapter)(object)val2).Fill(dataTable2);
					DataGridView2.Rows.Add(new object[3]
					{
						"* TOTAL FAMILLE *",
						"*" + Strings.FormatNumber(Conversion.Val(dataTable2.Rows[0]["Qté"].ToString())) + "*",
						"*" + Strings.FormatNumber(Conversion.Val(dataTable2.Rows[0]["TOTAL_NET"].ToString())) + "*"
					});
					DataGridView2.Rows.Add(new object[3] { "", "", "" });
					num2++;
				}
				DataGridView3.Rows.Clear();
				DataGridView3.Rows.Add(new object[1] { "                    FINANCE--------------" });
				DataTable dataTable3 = new DataTable();
				MySqlDataAdapter val3 = new MySqlDataAdapter();
				dataTable3.Clear();
				val3 = new MySqlDataAdapter("select   DISTINCT     MODE_P    from TABLE_VENTES_REGLEMENTS   Where  Dates   between        ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '        And        ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '              And     Caissier like  '" + Strings.Trim(ListBox_CAISSIERS.Text) + "'                ", Module1.cn_SQL);
				((DbDataAdapter)(object)val3).Fill(dataTable3);
				MySqlDataAdapter val4 = new MySqlDataAdapter();
				DataTable dataTable4 = new DataTable();
				int num8 = dataTable3.Rows.Count - 1;
				int num9 = 0;
				while (true)
				{
					int num10 = num9;
					int num4 = num8;
					if (num10 > num4)
					{
						break;
					}
					val4 = new MySqlDataAdapter("select sum(MONTANT) as n     from    TABLE_VENTES_REGLEMENTS     WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '             And     MODE_P  = '" + Strings.Trim(dataTable3.Rows[num9]["MODE_P"].ToString()) + "'           And     Caissier like  '" + Strings.Trim(ListBox_CAISSIERS.Text) + "'             ", Module1.cn_SQL);
					dataTable4 = new DataTable();
					dataTable4.Clear();
					((DbDataAdapter)(object)val4).Fill(dataTable4);
					double num11 = Conversion.Val(dataTable4.Rows[0]["n"].ToString());
					DataGridView3.Rows.Add(new object[1] { "                    " + Strings.LSet(dataTable3.Rows[num9]["MODE_P"].ToString(), 8) + ":" + Strings.RSet(Strings.FormatNumber(num11), 8) + " DH" });
					num9++;
				}
				DataGridView3.Rows.Add(new object[1] { "" });
				DataGridView3.Rows.Add(new object[1] { "" });
				MySqlDataAdapter val5 = new MySqlDataAdapter();
				DataTable dataTable5 = new DataTable();
				val5 = new MySqlDataAdapter("SELECT    SUM(MONTANT)      as N          FROM   TABLE_CLIENTS_REGLE     WHERE       DATES   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '             And     Utilisateur like  '" + Strings.Trim(ListBox_CAISSIERS.Text) + "'                 ", Module1.cn_SQL);
				dataTable5 = new DataTable();
				dataTable5.Clear();
				((DbDataAdapter)(object)val5).Fill(dataTable5);
				decimal num12 = new decimal(Conversion.Val(dataTable5.Rows[0]["n"].ToString()));
				if (decimal.Compare(num12, 0m) != 0)
				{
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("(+) REGLE CLIENTS     : ", 29) + Strings.RSet(Strings.FormatNumber(num12), 8) + " DH" });
					DataGridView3.Rows.Add(new object[1] { "" });
					DataGridView3.Rows.Add(new object[1] { "" });
				}
				MySqlDataAdapter val6 = new MySqlDataAdapter();
				DataTable dataTable6 = new DataTable();
				val6 = new MySqlDataAdapter("SELECT    SUM(MONTANT)      as N          FROM   TABLE_FOURNISSEURS_REGLE     WHERE       DATES   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '              And     Utilisateur like  '" + Strings.Trim(ListBox_CAISSIERS.Text) + "'            ", Module1.cn_SQL);
				dataTable6 = new DataTable();
				dataTable6.Clear();
				((DbDataAdapter)(object)val6).Fill(dataTable6);
				decimal num13 = new decimal(Conversion.Val(dataTable6.Rows[0]["n"].ToString()));
				if (decimal.Compare(num13, 0m) != 0)
				{
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("(-) REGLE FOURNISSEURS: ", 29) + Strings.RSet(Strings.FormatNumber(num13), 8) + " DH" });
					DataGridView3.Rows.Add(new object[1] { "" });
					DataGridView3.Rows.Add(new object[1] { "" });
				}
				MySqlDataAdapter val7 = new MySqlDataAdapter();
				DataTable dataTable7 = new DataTable();
				val7 = new MySqlDataAdapter(" select sum(Montant) as n                   FROM   TABLE_DEPENSES           WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '             And     Utilisateur like  '" + Strings.Trim(ListBox_CAISSIERS.Text) + "'              ", Module1.cn_SQL);
				dataTable7 = new DataTable();
				dataTable7.Clear();
				((DbDataAdapter)(object)val7).Fill(dataTable7);
				decimal num14 = new decimal(Conversion.Val(dataTable7.Rows[0]["n"].ToString()));
				if (decimal.Compare(num14, 0m) != 0)
				{
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("(-) DEPENSES          : ", 29) + Strings.RSet(Strings.FormatNumber(num14), 8) + " DH" });
					DataGridView3.Rows.Add(new object[1] { "" });
					DataGridView3.Rows.Add(new object[1] { "" });
				}
				if ((decimal.Compare(num12, 0m) != 0) | (decimal.Compare(num14, 0m) != 0) | (decimal.Compare(num13, 0m) != 0))
				{
					DataTable dataTable8 = new DataTable();
					MySqlDataAdapter val8 = new MySqlDataAdapter();
					val8 = new MySqlDataAdapter("select sum(Total_NET) as n     from TABLE_VENTES_JOURNAL WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '           And     Caissier like  '" + Strings.Trim(ListBox_CAISSIERS.Text) + "'           and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')               ", Module1.cn_SQL);
					dataTable8 = new DataTable();
					dataTable8.Clear();
					((DbDataAdapter)(object)val8).Fill(dataTable8);
					decimal d = Conversions.ToDecimal(Strings.FormatNumber(Conversion.Val(dataTable8.Rows[0]["n"].ToString())));
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("(=) TOTAL             : ", 29) + Strings.RSet(Strings.FormatNumber(decimal.Subtract(decimal.Subtract(decimal.Add(d, num12), num13), num14)), 8) + " DH" });
					DataGridView3.Rows.Add(new object[1] { "" });
					DataGridView3.Rows.Add(new object[1] { "" });
				}
				MySqlDataAdapter val9 = new MySqlDataAdapter();
				DataTable dataTable9 = new DataTable();
				val9 = new MySqlDataAdapter("(select sum(Total_NET) as n from TABLE_VENTES_JOURNAL WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '               And     Caissier like  '" + Strings.Trim(ListBox_CAISSIERS.Text) + "'      and            (OPERATION = 'RETOUR REMBOURSEMENT')     )    UNION ALL  (select sum(Total_NET) as n from TABLE_VENTES_JOURNAL WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '            And     Caissier like  '" + Strings.Trim(ListBox_CAISSIERS.Text) + "'         and            (OPERATION = 'RETOUR AVOIR')    )       UNION ALL  (select sum(Total_NET) as n from TABLE_VENTES_JOURNAL WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '            And     Caissier like  '" + Strings.Trim(ListBox_CAISSIERS.Text) + "'         and            (OPERATION = 'CREDIT')    )          UNION ALL  (select sum(Total_NET) as n from TABLE_VENTES_JOURNAL WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '            And     Caissier like  '" + Strings.Trim(ListBox_CAISSIERS.Text) + "'         and            (OPERATION = 'RETOUR CREDIT')    )   ", Module1.cn_SQL);
				dataTable9 = new DataTable();
				dataTable9.Clear();
				((DbDataAdapter)(object)val9).Fill(dataTable9);
				decimal num15 = new decimal(Conversion.Val(dataTable9.Rows[0]["n"].ToString()));
				decimal num16 = new decimal(Conversion.Val(dataTable9.Rows[1]["n"].ToString()));
				decimal num17 = new decimal(Conversion.Val(dataTable9.Rows[2]["n"].ToString()));
				decimal num18 = new decimal(Conversion.Val(dataTable9.Rows[3]["n"].ToString()));
				if ((decimal.Compare(num15, 0m) != 0) | (decimal.Compare(num16, 0m) != 0) | (decimal.Compare(num17, 0m) != 0) | (decimal.Compare(num18, 0m) != 0))
				{
					DataGridView3.Rows.Add(new object[1] { "---------------ATTENTION-----------------" });
				}
				if (decimal.Compare(num15, 0m) != 0)
				{
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("RETOUR REMBOURSEMENT  : ", 29) + Strings.RSet(Conversions.ToString(num15), 8) + " DH" });
					Module1._DT_TEMP.Clear();
					Module1._DA_TEMP = new MySqlDataAdapter("select Article, sum(Qté) as Qté   from   TABLE_VENTES_JOURNAL    Where              Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '          And     Caissier like  '" + Strings.Trim(ListBox_CAISSIERS.Text) + "'         and            (OPERATION = 'RETOUR REMBOURSEMENT')               group by Article      ", Module1.cn_SQL);
					((DbDataAdapter)(object)Module1._DA_TEMP).Fill(Module1._DT_TEMP);
					int num19 = Module1._DT_TEMP.Rows.Count - 1;
					int num20 = 0;
					while (true)
					{
						int num21 = num20;
						int num4 = num19;
						if (num21 > num4)
						{
							break;
						}
						DataGridView3.Rows.Add(new object[1] { "  " + Strings.LSet(Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(Module1._DT_TEMP.Rows[num20]["Qté"].ToString()))) + "x", 7) + Module1._DT_TEMP.Rows[num20]["Article"].ToString() });
						num20++;
					}
				}
				if (decimal.Compare(num16, 0m) != 0)
				{
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("RETOUR AVOIR          : ", 29) + Strings.RSet(Conversions.ToString(num16), 8) + " DH" });
					Module1._DT_TEMP.Clear();
					Module1._DA_TEMP = new MySqlDataAdapter("select Article, sum(Qté) as Qté   from   TABLE_VENTES_JOURNAL    Where              Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '             And     Caissier like  '" + Strings.Trim(ListBox_CAISSIERS.Text) + "'      and            (OPERATION = 'RETOUR AVOIR')               group by Article      ", Module1.cn_SQL);
					((DbDataAdapter)(object)Module1._DA_TEMP).Fill(Module1._DT_TEMP);
					int num22 = Module1._DT_TEMP.Rows.Count - 1;
					int num23 = 0;
					while (true)
					{
						int num24 = num23;
						int num4 = num22;
						if (num24 > num4)
						{
							break;
						}
						DataGridView3.Rows.Add(new object[1] { "  " + Strings.LSet(Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(Module1._DT_TEMP.Rows[num23]["Qté"].ToString()))) + "x", 7) + Module1._DT_TEMP.Rows[num23]["Article"].ToString() });
						num23++;
					}
				}
				if (decimal.Compare(num17, 0m) != 0)
				{
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("CREDIT                : ", 29) + Strings.RSet(Conversions.ToString(num17), 8) + " DH" });
					Module1._DT_TEMP.Clear();
					Module1._DA_TEMP = new MySqlDataAdapter("select Article, sum(Qté) as Qté   from   TABLE_VENTES_JOURNAL    Where              Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '            And     Caissier like  '" + Strings.Trim(ListBox_CAISSIERS.Text) + "'       and            (OPERATION = 'CREDIT')               group by Article      ", Module1.cn_SQL);
					((DbDataAdapter)(object)Module1._DA_TEMP).Fill(Module1._DT_TEMP);
					int num25 = Module1._DT_TEMP.Rows.Count - 1;
					int num26 = 0;
					while (true)
					{
						int num27 = num26;
						int num4 = num25;
						if (num27 > num4)
						{
							break;
						}
						DataGridView3.Rows.Add(new object[1] { "  " + Strings.LSet(Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(Module1._DT_TEMP.Rows[num26]["Qté"].ToString()))) + "x", 7) + Module1._DT_TEMP.Rows[num26]["Article"].ToString() });
						num26++;
					}
				}
				if (decimal.Compare(num18, 0m) != 0)
				{
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("RETOUR CREDIT         : ", 29) + Strings.RSet(Conversions.ToString(num18), 8) + " DH" });
					Module1._DT_TEMP.Clear();
					Module1._DA_TEMP = new MySqlDataAdapter("select Article, sum(Qté) as Qté   from   TABLE_VENTES_JOURNAL    Where              Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '            And     Caissier like  '" + Strings.Trim(ListBox_CAISSIERS.Text) + "'       and            (OPERATION = 'RETOUR CREDIT')               group by Article      ", Module1.cn_SQL);
					((DbDataAdapter)(object)Module1._DA_TEMP).Fill(Module1._DT_TEMP);
					int num28 = Module1._DT_TEMP.Rows.Count - 1;
					int num29 = 0;
					while (true)
					{
						int num30 = num29;
						int num4 = num28;
						if (num30 > num4)
						{
							break;
						}
						DataGridView3.Rows.Add(new object[1] { "  " + Strings.LSet(Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(Module1._DT_TEMP.Rows[num29]["Qté"].ToString()))) + "x", 7) + Module1._DT_TEMP.Rows[num29]["Article"].ToString() });
						num29++;
					}
				}
				DataGridView3.Rows.Add(new object[1] { "" });
				DataGridView3.Rows.Add(new object[1] { "" });
				if (Operators.CompareString(MyProject.Forms.Form_0_TEMPLATE.Label_GESTION_TABLE.Text, "TABLE", TextCompare: false) == 0)
				{
					MySqlDataAdapter val10 = new MySqlDataAdapter();
					DataTable dataTable10 = new DataTable();
					decimal value = 0m;
					double num31 = Conversion.Val(File.ReadAllText(Module1._CHEMIN_FOLDER + "\\bd\\config\\TABLES_NBR.sni"));
					double num32 = 1.0;
					while (true)
					{
						double num33 = num32;
						double num34 = num31;
						if (!(num33 <= num34))
						{
							break;
						}
						val10 = new MySqlDataAdapter("Select sum(TOTAL_NET) as n      from TABLE_" + Strings.Format(num32, "00") + "  ", Module1.cn_SQL);
						dataTable10 = new DataTable();
						dataTable10.Clear();
						((DbDataAdapter)(object)val10).Fill(dataTable10);
						value = new decimal(Convert.ToDouble(value) + Conversion.Val(dataTable10.Rows[0]["n"].ToString()));
						num32++;
					}
					val10 = new MySqlDataAdapter("Select sum(TOTAL_NET) as n      from EMPORTER   ", Module1.cn_SQL);
					dataTable10 = new DataTable();
					dataTable10.Clear();
					((DbDataAdapter)(object)val10).Fill(dataTable10);
					value = new decimal(Convert.ToDouble(value) + Conversion.Val(dataTable10.Rows[0]["n"].ToString()));
					val10 = new MySqlDataAdapter("Select sum(TOTAL_NET) as n      from LIVRAISON   ", Module1.cn_SQL);
					dataTable10 = new DataTable();
					dataTable10.Clear();
					((DbDataAdapter)(object)val10).Fill(dataTable10);
					value = new decimal(Convert.ToDouble(value) + Conversion.Val(dataTable10.Rows[0]["n"].ToString()));
					if (decimal.Compare(value, 0m) != 0)
					{
						DataGridView3.Rows.Add(new object[1] { "---------------ATTENTION-----------------" });
						DataGridView3.Rows.Add(new object[1] { Strings.LSet("IL YA DES CMD EN COURS: ", 29) + Strings.RSet(Conversions.ToString(value), 8) + " DH" });
					}
					DataGridView3.Rows.Add(new object[1] { "" });
					DataGridView3.Rows.Add(new object[1] { "" });
					decimal num35 = 0m;
					val10 = new MySqlDataAdapter("Select sum(TOTAL_NET) as n      from TABLE_POUBELLE    Where  Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '           And     Caissier like  '" + Strings.Trim(ListBox_CAISSIERS.Text) + "'  ", Module1.cn_SQL);
					dataTable10 = new DataTable();
					dataTable10.Clear();
					((DbDataAdapter)(object)val10).Fill(dataTable10);
					num35 = new decimal(Conversion.Val(dataTable10.Rows[0]["n"].ToString()));
					if (decimal.Compare(num35, 0m) != 0)
					{
						DataGridView3.Rows.Add(new object[1] { "---------------ATTENTION-----------------" });
						DataGridView3.Rows.Add(new object[1] { Strings.LSet("IL YA DES ANNULATIONS : ", 29) + Strings.RSet(Conversions.ToString(num35), 8) + " DH" });
						Module1._DT_TEMP.Clear();
						Module1._DA_TEMP = new MySqlDataAdapter("select Article, sum(Qté) as Qté   from   TABLE_POUBELLE    Where              Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '                 And     Caissier like  '" + Strings.Trim(ListBox_CAISSIERS.Text) + "'                  group by Article      ", Module1.cn_SQL);
						((DbDataAdapter)(object)Module1._DA_TEMP).Fill(Module1._DT_TEMP);
						int num36 = Module1._DT_TEMP.Rows.Count - 1;
						int num37 = 0;
						while (true)
						{
							int num38 = num37;
							int num4 = num36;
							if (num38 > num4)
							{
								break;
							}
							DataGridView3.Rows.Add(new object[1] { "  " + Strings.LSet(Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(Module1._DT_TEMP.Rows[num37]["Qté"].ToString()))) + "x", 7) + Module1._DT_TEMP.Rows[num37]["Article"].ToString() });
							num37++;
						}
					}
					DataGridView3.Rows.Add(new object[1] { "" });
					DataGridView3.Rows.Add(new object[1] { "" });
				}
				MySqlDataAdapter val11 = new MySqlDataAdapter();
				DataTable dataTable11 = new DataTable();
				val11 = new MySqlDataAdapter("(select sum(TOTAL_NET) as n     from    TABLE_VENTES_JOURNAL     WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '                and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')         And  (Notes LIKE 'TABLE%' OR Notes LIKE 'SUR PLACE%')            And     Caissier like  '" + Strings.Trim(ListBox_CAISSIERS.Text) + "'        )      UNION ALL   (select sum(TOTAL_NET) as n     from    TABLE_VENTES_JOURNAL     WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '                and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')         And     Notes  like 'EMPORTER%'            And     Caissier like  '" + Strings.Trim(ListBox_CAISSIERS.Text) + "'     )      UNION ALL   (select sum(TOTAL_NET) as n     from    TABLE_VENTES_JOURNAL     WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '                and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')         And     Notes  like 'LIVRAISON%'           And     Caissier like  '" + Strings.Trim(ListBox_CAISSIERS.Text) + "'      )       UNION ALL   (select sum(TOTAL_NET) as n     from    TABLE_VENTES_JOURNAL     WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '                and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')         And     Notes  like 'DIRECTE%'            And     Caissier like  '" + Strings.Trim(ListBox_CAISSIERS.Text) + "'     )         ", Module1.cn_SQL);
				dataTable11 = new DataTable();
				dataTable11.Clear();
				((DbDataAdapter)(object)val11).Fill(dataTable11);
				double num39 = Conversion.Val(dataTable11.Rows[0]["n"].ToString());
				double num40 = Conversion.Val(dataTable11.Rows[1]["n"].ToString());
				double num41 = Conversion.Val(dataTable11.Rows[2]["n"].ToString());
				double num42 = Conversion.Val(dataTable11.Rows[3]["n"].ToString());
				if ((num39 != 0.0) | (num40 != 0.0) | (num41 != 0.0) | (num42 != 0.0))
				{
					DataGridView3.Rows.Add(new object[1] { "-----------------NOTES-------------------" });
				}
				if (num39 != 0.0)
				{
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("- SUR PLACE           : ", 29) + Strings.RSet(Strings.FormatNumber(num39), 8) + " DH" });
				}
				if (num40 != 0.0)
				{
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("- EMPORTER            : ", 29) + Strings.RSet(Strings.FormatNumber(num40), 8) + " DH" });
				}
				if (num41 != 0.0)
				{
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("- LIVRAISON           : ", 29) + Strings.RSet(Strings.FormatNumber(num41), 8) + " DH" });
				}
				if (num42 != 0.0)
				{
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("- DIRECTE             : ", 29) + Strings.RSet(Strings.FormatNumber(num42), 8) + " DH" });
				}
				DataGridView3.Rows.Add(new object[1] { "" });
				DataGridView3.Rows.Add(new object[1] { "" });
				val9 = new MySqlDataAdapter("( select sum((PRIX_V*Qté)-TOTAL_NET) as n                    from TABLE_VENTES_JOURNAL WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '           AND     REMISE <  100        And     Caissier like  '" + Strings.Trim(ListBox_CAISSIERS.Text) + "'              )      UNION ALL        ( select sum((PRIX_V*Qté)-TOTAL_NET) as n                  from TABLE_VENTES_JOURNAL WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '         AND       REMISE = 100            And     Caissier like  '" + Strings.Trim(ListBox_CAISSIERS.Text) + "'              ) UNION ALL (select sum(TOTAL_NET) as n       from TABLE_VENTES_JOURNAL WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '                     And       Famille = 'FAM_DIVERS'           And     Caissier like  '" + Strings.Trim(ListBox_CAISSIERS.Text) + "'              )  ", Module1.cn_SQL);
				dataTable9 = new DataTable();
				dataTable9.Clear();
				((DbDataAdapter)(object)val9).Fill(dataTable9);
				decimal num43 = new decimal(Conversion.Val(dataTable9.Rows[0]["n"].ToString()));
				decimal num44 = new decimal(Conversion.Val(dataTable9.Rows[1]["n"].ToString()));
				decimal num45 = new decimal(Conversion.Val(dataTable9.Rows[2]["n"].ToString()));
				if ((decimal.Compare(num43, 0m) != 0) | (decimal.Compare(num44, 0m) != 0) | (decimal.Compare(num45, 0m) != 0))
				{
					DataGridView3.Rows.Add(new object[1] { "---------------ATTENTION-----------------" });
				}
				if (decimal.Compare(num43, 0m) != 0)
				{
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("IL YA DES REMISE      : ", 29) + Strings.RSet(Conversions.ToString(num43), 8) + " DH" });
				}
				if (decimal.Compare(num44, 0m) != 0)
				{
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("IL YA DES OFFERT      : ", 29) + Strings.RSet(Conversions.ToString(num44), 8) + " DH" });
				}
				if (decimal.Compare(num45, 0m) != 0)
				{
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("IL YA DES DIVERS      : ", 29) + Strings.RSet(Conversions.ToString(num45), 8) + " DH" });
				}
				DataGridView3.Rows.Add(new object[1] { "" });
				DataGridView3.Rows.Add(new object[1] { "" });
				MySqlDataAdapter val12 = new MySqlDataAdapter();
				DataTable dataTable12 = new DataTable();
				val12 = new MySqlDataAdapter("(SELECT    count(id)      as N          FROM   TABLE_RECEPTIONS_ENTETE    WHERE       DATES   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '              And     Utilisateur like  '" + Strings.Trim(ListBox_CAISSIERS.Text) + "'               )       UNION ALL    (SELECT    count(id)      as N          FROM   TABLE_SORTIES_ENTETE    WHERE       DATES   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '          And     Utilisateur like  '" + Strings.Trim(ListBox_CAISSIERS.Text) + "'        )       UNION ALL    (SELECT    count(id)      as N          FROM   TABLE_INVENTAIRES_ENTETE    WHERE       DATES   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '           And     Utilisateur like  '" + Strings.Trim(ListBox_CAISSIERS.Text) + "'       )  ", Module1.cn_SQL);
				dataTable12 = new DataTable();
				dataTable12.Clear();
				((DbDataAdapter)(object)val12).Fill(dataTable12);
				decimal num46 = new decimal(Conversion.Val(dataTable12.Rows[0]["n"].ToString()));
				decimal num47 = new decimal(Conversion.Val(dataTable12.Rows[1]["n"].ToString()));
				decimal num48 = new decimal(Conversion.Val(dataTable12.Rows[2]["n"].ToString()));
				if ((decimal.Compare(num46, 0m) != 0) | (decimal.Compare(num47, 0m) != 0) | (decimal.Compare(num48, 0m) != 0))
				{
					DataGridView3.Rows.Add(new object[1] { "---------------ATTENTION-----------------" });
				}
				if (decimal.Compare(num46, 0m) != 0)
				{
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("IL YA DES RECEPTIONS  : ", 29) + Strings.RSet(Conversions.ToString(num46), 8) });
				}
				if (decimal.Compare(num47, 0m) != 0)
				{
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("IL YA DES SORTIES     : ", 29) + Strings.RSet(Conversions.ToString(num47), 8) });
				}
				if (decimal.Compare(num48, 0m) != 0)
				{
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("IL YA DES INVENTAIRES : ", 29) + Strings.RSet(Conversions.ToString(num48), 8) });
				}
				DataGridView3.Rows.Add(new object[1] { "" });
				DataGridView3.Rows.Add(new object[1] { "" });
				if (Operators.CompareString(Text_PRINTER_RAPPORT.Text, "0", TextCompare: false) != 0 && Operators.CompareString(Text_PRINTER_RAPPORT.Text, "", TextCompare: false) != 0)
				{
					Print_Recette_caissier.PrinterSettings.PrinterName = Text_PRINTER_RAPPORT.Text;
				}
				if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null), "Button_ConsCaissier", TextCompare: false))
				{
					PrintPreviewDialog val13 = new PrintPreviewDialog();
					val13.Document = Print_Recette_caissier;
					val13.PrintPreviewControl.Zoom = 2.0;
					((Form)val13).WindowState = (FormWindowState)2;
					((Form)val13).ShowDialog();
				}
				else if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null), "Button_PrintCaissier", TextCompare: false))
				{
					if (Operators.CompareString(MyProject.Forms.Form_0_TEMPLATE.TextBox_BRANCHEMENT.Text, "USB", TextCompare: false) == 0)
					{
						Print_Recette_caissier.Print();
					}
					else
					{
						Print_Recette_caissier_COM();
					}
					Button_MAIL_CAISSIER_Click(RuntimeHelpers.GetObjectValue(sender), e);
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

	private void Button_ConsGlobaleCaissier_Click(object sender, EventArgs e)
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected Obj, but got Unknown
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected Obj, but got Unknown
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected Obj, but got Unknown
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Expected Obj, but got Unknown
		//IL_030b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0312: Expected Obj, but got Unknown
		//IL_038a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0391: Expected Obj, but got Unknown
		//IL_039b: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a2: Expected Obj, but got Unknown
		//IL_0462: Unknown result type (might be due to invalid IL or missing references)
		//IL_0469: Expected Obj, but got Unknown
		//IL_0596: Unknown result type (might be due to invalid IL or missing references)
		//IL_059c: Expected Obj, but got Unknown
		//IL_0613: Unknown result type (might be due to invalid IL or missing references)
		//IL_0619: Expected Obj, but got Unknown
		//IL_070c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0713: Expected Obj, but got Unknown
		//IL_078a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0791: Expected Obj, but got Unknown
		//IL_0888: Unknown result type (might be due to invalid IL or missing references)
		//IL_088f: Expected Obj, but got Unknown
		//IL_0906: Unknown result type (might be due to invalid IL or missing references)
		//IL_090d: Expected Obj, but got Unknown
		//IL_0bc9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd0: Expected Obj, but got Unknown
		//IL_0d46: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d4d: Expected Obj, but got Unknown
		//IL_0a4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a52: Expected Obj, but got Unknown
		//IL_0ac2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac9: Expected Obj, but got Unknown
		//IL_0f58: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f62: Expected Obj, but got Unknown
		//IL_1104: Unknown result type (might be due to invalid IL or missing references)
		//IL_110e: Expected Obj, but got Unknown
		//IL_12ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_12b8: Expected Obj, but got Unknown
		//IL_145a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1464: Expected Obj, but got Unknown
		//IL_1ad3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ada: Expected Obj, but got Unknown
		//IL_1c50: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c57: Expected Obj, but got Unknown
		//IL_15a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_15a9: Expected Obj, but got Unknown
		//IL_1608: Unknown result type (might be due to invalid IL or missing references)
		//IL_160f: Expected Obj, but got Unknown
		//IL_167f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1686: Expected Obj, but got Unknown
		//IL_16da: Unknown result type (might be due to invalid IL or missing references)
		//IL_16e1: Expected Obj, but got Unknown
		//IL_186e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1875: Expected Obj, but got Unknown
		//IL_19b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_19bf: Expected Obj, but got Unknown
		//IL_2066: Unknown result type (might be due to invalid IL or missing references)
		//IL_206d: Expected Obj, but got Unknown
		//IL_22c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_22c9: Expected Obj, but got Unknown
		//IL_23e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_23ef: Expected Obj, but got Unknown
		//IL_26bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_26c3: Expected Obj, but got Unknown
		//IL_26f2: Unknown result type (might be due to invalid IL or missing references)
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
				dataTable.Clear();
				val = new MySqlDataAdapter("select DISTINCT     CAISSIER   from   TABLE_VENTES_JOURNAL         WHERE        Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '               and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')       ", Module1.cn_SQL);
				((DbDataAdapter)(object)val).Fill(dataTable);
				DataTable dataTable2 = new DataTable();
				MySqlDataAdapter val2 = new MySqlDataAdapter();
				DataGridView2.Rows.Clear();
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
					dataTable2.Clear();
					val2 = new MySqlDataAdapter("select  sum(Qté) as QTé, sum(TOTAL_NET) as TOTAL_NET    from   TABLE_VENTES_JOURNAL    Where     Caissier like  '" + dataTable.Rows[num2]["CAISSIER"].ToString() + "'     and        Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '                and           (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')     ", Module1.cn_SQL);
					((DbDataAdapter)(object)val2).Fill(dataTable2);
					DataGridView2.Rows.Add(new object[3]
					{
						dataTable.Rows[num2]["CAISSIER"].ToString(),
						Strings.FormatNumber(Conversion.Val(dataTable2.Rows[0]["QTé"].ToString())),
						Strings.FormatNumber(Conversion.Val(dataTable2.Rows[0]["TOTAL_NET"].ToString()))
					});
					DataGridView2.Rows.Add(new object[3] { "", "", "" });
					num2++;
				}
				DataGridView3.Rows.Clear();
				DataGridView3.Rows.Add(new object[1] { "                    FINANCE--------------" });
				DataTable dataTable3 = new DataTable();
				MySqlDataAdapter val3 = new MySqlDataAdapter();
				dataTable3.Clear();
				val3 = new MySqlDataAdapter("select   DISTINCT     MODE_P    from TABLE_VENTES_REGLEMENTS   Where  Dates   between        ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '        And        ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '       ", Module1.cn_SQL);
				((DbDataAdapter)(object)val3).Fill(dataTable3);
				MySqlDataAdapter val4 = new MySqlDataAdapter();
				DataTable dataTable4 = new DataTable();
				int num5 = dataTable3.Rows.Count - 1;
				int num6 = 0;
				while (true)
				{
					int num7 = num6;
					int num4 = num5;
					if (num7 > num4)
					{
						break;
					}
					val4 = new MySqlDataAdapter("select sum(MONTANT) as n     from    TABLE_VENTES_REGLEMENTS     WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '             And     MODE_P  = '" + Strings.Trim(dataTable3.Rows[num6]["MODE_P"].ToString()) + "'  ", Module1.cn_SQL);
					dataTable4 = new DataTable();
					dataTable4.Clear();
					((DbDataAdapter)(object)val4).Fill(dataTable4);
					double num8 = Conversion.Val(dataTable4.Rows[0]["n"].ToString());
					DataGridView3.Rows.Add(new object[1] { "                    " + Strings.LSet(dataTable3.Rows[num6]["MODE_P"].ToString(), 8) + ":" + Strings.RSet(Strings.FormatNumber(num8), 8) + " DH" });
					num6++;
				}
				DataGridView3.Rows.Add(new object[1] { "" });
				DataGridView3.Rows.Add(new object[1] { "" });
				MySqlDataAdapter val5 = new MySqlDataAdapter();
				DataTable dataTable5 = new DataTable();
				val5 = new MySqlDataAdapter("SELECT    SUM(MONTANT)      as N          FROM   TABLE_CLIENTS_REGLE     WHERE       DATES   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '       ", Module1.cn_SQL);
				dataTable5 = new DataTable();
				dataTable5.Clear();
				((DbDataAdapter)(object)val5).Fill(dataTable5);
				decimal num9 = new decimal(Conversion.Val(dataTable5.Rows[0]["n"].ToString()));
				if (decimal.Compare(num9, 0m) != 0)
				{
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("(+) REGLE CLIENTS     : ", 29) + Strings.RSet(Strings.FormatNumber(num9), 8) + " DH" });
					DataGridView3.Rows.Add(new object[1] { "" });
					DataGridView3.Rows.Add(new object[1] { "" });
				}
				MySqlDataAdapter val6 = new MySqlDataAdapter();
				DataTable dataTable6 = new DataTable();
				val6 = new MySqlDataAdapter("SELECT    SUM(MONTANT)      as N          FROM   TABLE_FOURNISSEURS_REGLE     WHERE       DATES   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '       ", Module1.cn_SQL);
				dataTable6 = new DataTable();
				dataTable6.Clear();
				((DbDataAdapter)(object)val6).Fill(dataTable6);
				decimal num10 = new decimal(Conversion.Val(dataTable6.Rows[0]["n"].ToString()));
				if (decimal.Compare(num10, 0m) != 0)
				{
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("(-) REGLE FOURNISSEURS: ", 29) + Strings.RSet(Strings.FormatNumber(num10), 8) + " DH" });
					DataGridView3.Rows.Add(new object[1] { "" });
					DataGridView3.Rows.Add(new object[1] { "" });
				}
				MySqlDataAdapter val7 = new MySqlDataAdapter();
				DataTable dataTable7 = new DataTable();
				val7 = new MySqlDataAdapter(" select sum(Montant) as n                   FROM   TABLE_DEPENSES           WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '   ", Module1.cn_SQL);
				dataTable7 = new DataTable();
				dataTable7.Clear();
				((DbDataAdapter)(object)val7).Fill(dataTable7);
				decimal num11 = new decimal(Conversion.Val(dataTable7.Rows[0]["n"].ToString()));
				if (decimal.Compare(num11, 0m) != 0)
				{
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("(-) DEPENSES          : ", 29) + Strings.RSet(Strings.FormatNumber(num11), 8) + " DH" });
					DataGridView3.Rows.Add(new object[1] { "" });
					DataGridView3.Rows.Add(new object[1] { "" });
				}
				if ((decimal.Compare(num9, 0m) != 0) | (decimal.Compare(num11, 0m) != 0) | (decimal.Compare(num10, 0m) != 0))
				{
					DataTable dataTable8 = new DataTable();
					MySqlDataAdapter val8 = new MySqlDataAdapter();
					val8 = new MySqlDataAdapter("select sum(Total_NET) as n     from TABLE_VENTES_JOURNAL WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '         and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')    ", Module1.cn_SQL);
					dataTable8 = new DataTable();
					dataTable8.Clear();
					((DbDataAdapter)(object)val8).Fill(dataTable8);
					decimal d = Conversions.ToDecimal(Strings.FormatNumber(Conversion.Val(dataTable8.Rows[0]["n"].ToString())));
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("(=) TOTAL             : ", 29) + Strings.RSet(Strings.FormatNumber(decimal.Subtract(decimal.Subtract(decimal.Add(d, num9), num10), num11)), 8) + " DH" });
					DataGridView3.Rows.Add(new object[1] { "" });
					DataGridView3.Rows.Add(new object[1] { "" });
				}
				MySqlDataAdapter val9 = new MySqlDataAdapter();
				DataTable dataTable9 = new DataTable();
				val9 = new MySqlDataAdapter("(select sum(Total_NET) as n from TABLE_VENTES_JOURNAL WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '            and            (OPERATION = 'RETOUR REMBOURSEMENT')     )    UNION ALL  (select sum(Total_NET) as n from TABLE_VENTES_JOURNAL WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '            and            (OPERATION = 'RETOUR AVOIR')    )       UNION ALL  (select sum(Total_NET) as n from TABLE_VENTES_JOURNAL WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '            and            (OPERATION = 'CREDIT')    )             UNION ALL  (select sum(Total_NET) as n from TABLE_VENTES_JOURNAL WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '            and            (OPERATION = 'RETOUR CREDIT')    )   ", Module1.cn_SQL);
				dataTable9 = new DataTable();
				dataTable9.Clear();
				((DbDataAdapter)(object)val9).Fill(dataTable9);
				decimal num12 = new decimal(Conversion.Val(dataTable9.Rows[0]["n"].ToString()));
				decimal num13 = new decimal(Conversion.Val(dataTable9.Rows[1]["n"].ToString()));
				decimal num14 = new decimal(Conversion.Val(dataTable9.Rows[2]["n"].ToString()));
				decimal num15 = new decimal(Conversion.Val(dataTable9.Rows[3]["n"].ToString()));
				if ((decimal.Compare(num12, 0m) != 0) | (decimal.Compare(num13, 0m) != 0) | (decimal.Compare(num14, 0m) != 0) | (decimal.Compare(num15, 0m) != 0))
				{
					DataGridView3.Rows.Add(new object[1] { "---------------ATTENTION-----------------" });
				}
				if (decimal.Compare(num12, 0m) != 0)
				{
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("RETOUR REMBOURSEMENT  : ", 29) + Strings.RSet(Conversions.ToString(num12), 8) + " DH" });
					Module1._DT_TEMP.Clear();
					Module1._DA_TEMP = new MySqlDataAdapter("select Article, sum(Qté) as Qté   from   TABLE_VENTES_JOURNAL    Where              Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '             and            (OPERATION = 'RETOUR REMBOURSEMENT')               group by Article      ", Module1.cn_SQL);
					((DbDataAdapter)(object)Module1._DA_TEMP).Fill(Module1._DT_TEMP);
					int num16 = Module1._DT_TEMP.Rows.Count - 1;
					int num17 = 0;
					while (true)
					{
						int num18 = num17;
						int num4 = num16;
						if (num18 > num4)
						{
							break;
						}
						DataGridView3.Rows.Add(new object[1] { "  " + Strings.LSet(Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(Module1._DT_TEMP.Rows[num17]["Qté"].ToString()))) + "x", 7) + Module1._DT_TEMP.Rows[num17]["Article"].ToString() });
						num17++;
					}
				}
				if (decimal.Compare(num13, 0m) != 0)
				{
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("RETOUR AVOIR          : ", 29) + Strings.RSet(Conversions.ToString(num13), 8) + " DH" });
					Module1._DT_TEMP.Clear();
					Module1._DA_TEMP = new MySqlDataAdapter("select Article, sum(Qté) as Qté   from   TABLE_VENTES_JOURNAL    Where              Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '             and            (OPERATION = 'RETOUR AVOIR')               group by Article      ", Module1.cn_SQL);
					((DbDataAdapter)(object)Module1._DA_TEMP).Fill(Module1._DT_TEMP);
					int num19 = Module1._DT_TEMP.Rows.Count - 1;
					int num20 = 0;
					while (true)
					{
						int num21 = num20;
						int num4 = num19;
						if (num21 > num4)
						{
							break;
						}
						DataGridView3.Rows.Add(new object[1] { "  " + Strings.LSet(Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(Module1._DT_TEMP.Rows[num20]["Qté"].ToString()))) + "x", 7) + Module1._DT_TEMP.Rows[num20]["Article"].ToString() });
						num20++;
					}
				}
				if (decimal.Compare(num14, 0m) != 0)
				{
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("CREDIT                : ", 29) + Strings.RSet(Conversions.ToString(num14), 8) + " DH" });
					Module1._DT_TEMP.Clear();
					Module1._DA_TEMP = new MySqlDataAdapter("select Article, sum(Qté) as Qté   from   TABLE_VENTES_JOURNAL    Where              Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '             and            (OPERATION = 'CREDIT')               group by Article      ", Module1.cn_SQL);
					((DbDataAdapter)(object)Module1._DA_TEMP).Fill(Module1._DT_TEMP);
					int num22 = Module1._DT_TEMP.Rows.Count - 1;
					int num23 = 0;
					while (true)
					{
						int num24 = num23;
						int num4 = num22;
						if (num24 > num4)
						{
							break;
						}
						DataGridView3.Rows.Add(new object[1] { "  " + Strings.LSet(Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(Module1._DT_TEMP.Rows[num23]["Qté"].ToString()))) + "x", 7) + Module1._DT_TEMP.Rows[num23]["Article"].ToString() });
						num23++;
					}
				}
				if (decimal.Compare(num15, 0m) != 0)
				{
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("RETOUR CREDIT         : ", 29) + Strings.RSet(Conversions.ToString(num15), 8) + " DH" });
					Module1._DT_TEMP.Clear();
					Module1._DA_TEMP = new MySqlDataAdapter("select Article, sum(Qté) as Qté   from   TABLE_VENTES_JOURNAL    Where              Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '             and            (OPERATION = 'RETOUR CREDIT')               group by Article      ", Module1.cn_SQL);
					((DbDataAdapter)(object)Module1._DA_TEMP).Fill(Module1._DT_TEMP);
					int num25 = Module1._DT_TEMP.Rows.Count - 1;
					int num26 = 0;
					while (true)
					{
						int num27 = num26;
						int num4 = num25;
						if (num27 > num4)
						{
							break;
						}
						DataGridView3.Rows.Add(new object[1] { "  " + Strings.LSet(Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(Module1._DT_TEMP.Rows[num26]["Qté"].ToString()))) + "x", 7) + Module1._DT_TEMP.Rows[num26]["Article"].ToString() });
						num26++;
					}
				}
				DataGridView3.Rows.Add(new object[1] { "" });
				DataGridView3.Rows.Add(new object[1] { "" });
				if (Operators.CompareString(MyProject.Forms.Form_0_TEMPLATE.Label_GESTION_TABLE.Text, "TABLE", TextCompare: false) == 0)
				{
					MySqlDataAdapter val10 = new MySqlDataAdapter();
					DataTable dataTable10 = new DataTable();
					decimal value = 0m;
					double num28 = Conversion.Val(File.ReadAllText(Module1._CHEMIN_FOLDER + "\\bd\\config\\TABLES_NBR.sni"));
					double num29 = 1.0;
					while (true)
					{
						double num30 = num29;
						double num31 = num28;
						if (!(num30 <= num31))
						{
							break;
						}
						val10 = new MySqlDataAdapter("Select sum(TOTAL_NET) as n      from TABLE_" + Strings.Format(num29, "00") + "  ", Module1.cn_SQL);
						dataTable10 = new DataTable();
						dataTable10.Clear();
						((DbDataAdapter)(object)val10).Fill(dataTable10);
						value = new decimal(Convert.ToDouble(value) + Conversion.Val(dataTable10.Rows[0]["n"].ToString()));
						num29++;
					}
					val10 = new MySqlDataAdapter("Select sum(TOTAL_NET) as n      from EMPORTER   ", Module1.cn_SQL);
					dataTable10 = new DataTable();
					dataTable10.Clear();
					((DbDataAdapter)(object)val10).Fill(dataTable10);
					value = new decimal(Convert.ToDouble(value) + Conversion.Val(dataTable10.Rows[0]["n"].ToString()));
					val10 = new MySqlDataAdapter("Select sum(TOTAL_NET) as n      from LIVRAISON   ", Module1.cn_SQL);
					dataTable10 = new DataTable();
					dataTable10.Clear();
					((DbDataAdapter)(object)val10).Fill(dataTable10);
					value = new decimal(Convert.ToDouble(value) + Conversion.Val(dataTable10.Rows[0]["n"].ToString()));
					if (decimal.Compare(value, 0m) != 0)
					{
						DataGridView3.Rows.Add(new object[1] { "---------------ATTENTION-----------------" });
						DataGridView3.Rows.Add(new object[1] { Strings.LSet("IL YA DES CMD EN COURS: ", 29) + Strings.RSet(Conversions.ToString(value), 8) + " DH" });
					}
					DataGridView3.Rows.Add(new object[1] { "" });
					DataGridView3.Rows.Add(new object[1] { "" });
					decimal num32 = 0m;
					val10 = new MySqlDataAdapter("Select sum(TOTAL_NET) as n      from TABLE_POUBELLE    Where  Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '  ", Module1.cn_SQL);
					dataTable10 = new DataTable();
					dataTable10.Clear();
					((DbDataAdapter)(object)val10).Fill(dataTable10);
					num32 = new decimal(Conversion.Val(dataTable10.Rows[0]["n"].ToString()));
					if (decimal.Compare(num32, 0m) != 0)
					{
						DataGridView3.Rows.Add(new object[1] { "---------------ATTENTION-----------------" });
						DataGridView3.Rows.Add(new object[1] { Strings.LSet("IL YA DES ANNULATIONS : ", 29) + Strings.RSet(Conversions.ToString(num32), 8) + " DH" });
						Module1._DT_TEMP.Clear();
						Module1._DA_TEMP = new MySqlDataAdapter("select Article, sum(Qté) as Qté   from   TABLE_POUBELLE    Where              Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '                       group by Article      ", Module1.cn_SQL);
						((DbDataAdapter)(object)Module1._DA_TEMP).Fill(Module1._DT_TEMP);
						int num33 = Module1._DT_TEMP.Rows.Count - 1;
						int num34 = 0;
						while (true)
						{
							int num35 = num34;
							int num4 = num33;
							if (num35 > num4)
							{
								break;
							}
							DataGridView3.Rows.Add(new object[1] { "  " + Strings.LSet(Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(Module1._DT_TEMP.Rows[num34]["Qté"].ToString()))) + "x", 7) + Module1._DT_TEMP.Rows[num34]["Article"].ToString() });
							num34++;
						}
					}
					DataGridView3.Rows.Add(new object[1] { "" });
					DataGridView3.Rows.Add(new object[1] { "" });
				}
				MySqlDataAdapter val11 = new MySqlDataAdapter();
				DataTable dataTable11 = new DataTable();
				val11 = new MySqlDataAdapter("(select sum(TOTAL_NET) as n     from    TABLE_VENTES_JOURNAL     WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '                and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')         And  (Notes LIKE 'TABLE%' OR Notes LIKE 'SUR PLACE%')    )      UNION ALL   (select sum(TOTAL_NET) as n     from    TABLE_VENTES_JOURNAL     WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '              and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')           And     Notes  like 'EMPORTER%'  )      UNION ALL   (select sum(TOTAL_NET) as n     from    TABLE_VENTES_JOURNAL     WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '                and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')         And     Notes  like 'LIVRAISON%'  )       UNION ALL   (select sum(TOTAL_NET) as n     from    TABLE_VENTES_JOURNAL     WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '                 and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')        And     Notes  like 'DIRECTE%'  )         ", Module1.cn_SQL);
				dataTable11 = new DataTable();
				dataTable11.Clear();
				((DbDataAdapter)(object)val11).Fill(dataTable11);
				double num36 = Conversion.Val(dataTable11.Rows[0]["n"].ToString());
				double num37 = Conversion.Val(dataTable11.Rows[1]["n"].ToString());
				double num38 = Conversion.Val(dataTable11.Rows[2]["n"].ToString());
				double num39 = Conversion.Val(dataTable11.Rows[3]["n"].ToString());
				if ((num36 != 0.0) | (num37 != 0.0) | (num38 != 0.0) | (num39 != 0.0))
				{
					DataGridView3.Rows.Add(new object[1] { "-----------------NOTES-------------------" });
				}
				if (num36 != 0.0)
				{
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("- SUR PLACE           : ", 29) + Strings.RSet(Strings.FormatNumber(num36), 8) + " DH" });
				}
				if (num37 != 0.0)
				{
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("- EMPORTER            : ", 29) + Strings.RSet(Strings.FormatNumber(num37), 8) + " DH" });
				}
				if (num38 != 0.0)
				{
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("- LIVRAISON           : ", 29) + Strings.RSet(Strings.FormatNumber(num38), 8) + " DH" });
				}
				if (num39 != 0.0)
				{
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("- DIRECTE             : ", 29) + Strings.RSet(Strings.FormatNumber(num39), 8) + " DH" });
				}
				DataGridView3.Rows.Add(new object[1] { "" });
				DataGridView3.Rows.Add(new object[1] { "" });
				val9 = new MySqlDataAdapter("( select sum((PRIX_V*Qté)-TOTAL_NET) as n                    from TABLE_VENTES_JOURNAL WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '          AND    REMISE <  100 )      UNION ALL        ( select sum((PRIX_V*Qté)-TOTAL_NET) as n                   from TABLE_VENTES_JOURNAL WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '              AND        REMISE = 100  ) UNION ALL (select sum(TOTAL_NET) as n       from TABLE_VENTES_JOURNAL WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '                    And       Famille = 'FAM_DIVERS' )  ", Module1.cn_SQL);
				dataTable9 = new DataTable();
				dataTable9.Clear();
				((DbDataAdapter)(object)val9).Fill(dataTable9);
				decimal num40 = new decimal(Conversion.Val(dataTable9.Rows[0]["n"].ToString()));
				decimal num41 = new decimal(Conversion.Val(dataTable9.Rows[1]["n"].ToString()));
				decimal num42 = new decimal(Conversion.Val(dataTable9.Rows[2]["n"].ToString()));
				if ((decimal.Compare(num40, 0m) != 0) | (decimal.Compare(num41, 0m) != 0) | (decimal.Compare(num42, 0m) != 0))
				{
					DataGridView3.Rows.Add(new object[1] { "---------------ATTENTION-----------------" });
				}
				if (decimal.Compare(num40, 0m) != 0)
				{
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("IL YA DES REMISE      : ", 29) + Strings.RSet(Conversions.ToString(num40), 8) + " DH" });
				}
				if (decimal.Compare(num41, 0m) != 0)
				{
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("IL YA DES OFFERT      : ", 29) + Strings.RSet(Conversions.ToString(num41), 8) + " DH" });
				}
				if (decimal.Compare(num42, 0m) != 0)
				{
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("IL YA DES DIVERS      : ", 29) + Strings.RSet(Conversions.ToString(num42), 8) + " DH" });
				}
				DataGridView3.Rows.Add(new object[1] { "" });
				DataGridView3.Rows.Add(new object[1] { "" });
				MySqlDataAdapter val12 = new MySqlDataAdapter();
				DataTable dataTable12 = new DataTable();
				val12 = new MySqlDataAdapter("(SELECT    count(id)      as N          FROM   TABLE_RECEPTIONS_ENTETE    WHERE       DATES   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '     )       UNION ALL    (SELECT    count(id)      as N          FROM   TABLE_SORTIES_ENTETE    WHERE       DATES   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '  )       UNION ALL    (SELECT    count(id)      as N          FROM   TABLE_INVENTAIRES_ENTETE    WHERE       DATES   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '  )  ", Module1.cn_SQL);
				dataTable12 = new DataTable();
				dataTable12.Clear();
				((DbDataAdapter)(object)val12).Fill(dataTable12);
				decimal num43 = new decimal(Conversion.Val(dataTable12.Rows[0]["n"].ToString()));
				decimal num44 = new decimal(Conversion.Val(dataTable12.Rows[1]["n"].ToString()));
				decimal num45 = new decimal(Conversion.Val(dataTable12.Rows[2]["n"].ToString()));
				if ((decimal.Compare(num43, 0m) != 0) | (decimal.Compare(num44, 0m) != 0) | (decimal.Compare(num45, 0m) != 0))
				{
					DataGridView3.Rows.Add(new object[1] { "---------------ATTENTION-----------------" });
				}
				if (decimal.Compare(num43, 0m) != 0)
				{
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("IL YA DES RECEPTIONS  : ", 29) + Strings.RSet(Conversions.ToString(num43), 8) });
				}
				if (decimal.Compare(num44, 0m) != 0)
				{
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("IL YA DES SORTIES     : ", 29) + Strings.RSet(Conversions.ToString(num44), 8) });
				}
				if (decimal.Compare(num45, 0m) != 0)
				{
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("IL YA DES INVENTAIRES : ", 29) + Strings.RSet(Conversions.ToString(num45), 8) });
				}
				DataGridView3.Rows.Add(new object[1] { "" });
				DataGridView3.Rows.Add(new object[1] { "" });
				if (Operators.CompareString(Text_PRINTER_RAPPORT.Text, "0", TextCompare: false) != 0 && Operators.CompareString(Text_PRINTER_RAPPORT.Text, "", TextCompare: false) != 0)
				{
					Print_Recette_caissierGLOBALE.PrinterSettings.PrinterName = Text_PRINTER_RAPPORT.Text;
				}
				if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null), "Button_ConsCaissier", TextCompare: false))
				{
					PrintPreviewDialog val13 = new PrintPreviewDialog();
					val13.Document = Print_Recette_caissierGLOBALE;
					val13.PrintPreviewControl.Zoom = 2.0;
					((Form)val13).WindowState = (FormWindowState)2;
					((Form)val13).ShowDialog();
				}
				else if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null), "Button_PrintCaissier", TextCompare: false))
				{
					if (Operators.CompareString(MyProject.Forms.Form_0_TEMPLATE.TextBox_BRANCHEMENT.Text, "USB", TextCompare: false) == 0)
					{
						Print_Recette_caissierGLOBALE.Print();
					}
					else
					{
						Print_Recette_caissierGLOBALE_COM();
					}
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

	private void Timer1_Tick(object sender, EventArgs e)
	{
		if (((ButtonBase)Button5).BackColor == Color.Red)
		{
			((ButtonBase)Button5).BackColor = Color.FromArgb(220, 232, 250);
		}
		else
		{
			((ButtonBase)Button5).BackColor = Color.Red;
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		((Form)MyProject.Forms.Form_3_VENTE_ENTETE).ShowDialog();
	}

	private void Button4_Click(object sender, EventArgs e)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		((Form)MyProject.Forms.JOURNAL_REGELEMENTS).ShowDialog();
	}

	private void Button3_Click(object sender, EventArgs e)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		((Component)(object)MyProject.Forms.FormDialog_CLOTURE).Dispose();
		((Form)MyProject.Forms.FormDialog_CLOTURE).ShowDialog();
	}

	private void Button13_Click(object sender, EventArgs e)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		((Form)MyProject.Forms.Form_3_VENTE_RETOURS).ShowDialog();
	}

	private void Button_ConsGlobaleFamille_click(object sender, EventArgs e)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected Obj, but got Unknown
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected Obj, but got Unknown
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected Obj, but got Unknown
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Expected Obj, but got Unknown
		//IL_0353: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Expected Obj, but got Unknown
		//IL_0389: Unknown result type (might be due to invalid IL or missing references)
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
				dataTable.Clear();
				val = new MySqlDataAdapter("select DISTINCT Famille from TABLE_VENTES_JOURNAL   Where  Dates   between        ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '        And        ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '             and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')    ", Module1.cn_SQL);
				((DbDataAdapter)(object)val).Fill(dataTable);
				DataTable dataTable2 = new DataTable();
				MySqlDataAdapter val2 = new MySqlDataAdapter();
				DataGridView2.Rows.Clear();
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
					dataTable2.Clear();
					val2 = new MySqlDataAdapter("select  sum(Qté) as QTé, sum(TOTAL_NET) as TOTAL_NET    from   TABLE_VENTES_JOURNAL    Where  Famille = '" + Strings.Trim(dataTable.Rows[num2]["Famille"].ToString()) + "'           and        Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '               and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')       ", Module1.cn_SQL);
					((DbDataAdapter)(object)val2).Fill(dataTable2);
					DataGridView2.Rows.Add(new object[3]
					{
						dataTable.Rows[num2]["Famille"].ToString(),
						Strings.FormatNumber(Conversion.Val(dataTable2.Rows[0]["Qté"].ToString())),
						Strings.FormatNumber(Conversion.Val(dataTable2.Rows[0]["TOTAL_NET"].ToString() + "*"))
					});
					DataGridView2.Rows.Add(new object[3] { "", "", "" });
					num2++;
				}
				if (Operators.CompareString(Text_PRINTER_RAPPORT.Text, "0", TextCompare: false) != 0 && Operators.CompareString(Text_PRINTER_RAPPORT.Text, "", TextCompare: false) != 0)
				{
					Print_Recette_familleGLOBALE.PrinterSettings.PrinterName = Text_PRINTER_RAPPORT.Text;
				}
				if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null), "Button_ConsFamille", TextCompare: false))
				{
					PrintPreviewDialog val3 = new PrintPreviewDialog();
					val3.Document = Print_Recette_familleGLOBALE;
					val3.PrintPreviewControl.Zoom = 2.0;
					((Form)val3).WindowState = (FormWindowState)2;
					((Form)val3).ShowDialog();
				}
				else if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null), "Button_PrintFamille", TextCompare: false))
				{
					if (Operators.CompareString(MyProject.Forms.Form_0_TEMPLATE.TextBox_BRANCHEMENT.Text, "USB", TextCompare: false) == 0)
					{
						Print_Recette_familleGLOBALE.Print();
					}
					else
					{
						Print_Recette_familleGLOBALE_COM();
					}
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

	private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
	}

	private void DataGridView1_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
	{
		if (((Control)Panel_COLUMNS).Visible)
		{
			((Control)Panel_COLUMNS).Visible = false;
		}
		else if (!((Control)Panel_COLUMNS).Visible)
		{
			((Control)Panel_COLUMNS).Visible = true;
			((Control)Panel_COLUMNS).BringToFront();
		}
	}

	private void DataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
	{
		int try0001_dispatch = -1;
		int num3 = default;
		int num = default;
		int num2 = default;
		int num5 = default;
		int num6 = default;
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				int num7;
				int num8;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0009;
				case 356:
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
							goto IL_0026;
						case 4:
							goto IL_0063;
						case 6:
							goto IL_0098;
						case 7:
							goto IL_00d9;
						case 5:
						case 8:
						case 9:
							goto IL_010d;
						default:
							goto end_IL_0001;
						case 10:
							goto end_IL_0001_2;
						}
						goto default;
					}
					IL_0098:
					num2 = 6;
					if (Operators.CompareString(DataGridView1.Rows[num5].Cells["OPERATION"].Value.ToString(), "CREDIT", TextCompare: false) == 0)
					{
						goto IL_00d9;
					}
					goto IL_010d;
					IL_00d9:
					num2 = 7;
					DataGridView1.Rows[num5].Cells["OPERATION"].Style.BackColor = Color.LawnGreen;
					goto IL_010d;
					IL_0063:
					num2 = 4;
					DataGridView1.Rows[num5].Cells["OPERATION"].Style.BackColor = Color.Red;
					goto IL_010d;
					IL_010d:
					num2 = 9;
					num5 = checked(num5 + 1);
					goto IL_0116;
					IL_0009:
					num2 = 2;
					num6 = checked(DataGridView1.Rows.Count - 1);
					num5 = 0;
					goto IL_0116;
					IL_0116:
					num7 = num5;
					num8 = num6;
					if (num7 > num8)
					{
						goto end_IL_0001_2;
					}
					goto IL_0026;
					IL_0026:
					num2 = 3;
					if (DataGridView1.Rows[num5].Cells["OPERATION"].Value.ToString().Contains("RETOUR"))
					{
						goto IL_0063;
					}
					goto IL_0098;
					end_IL_0001:
					break;
				}
			}
			catch (Exception ex) when ((num3 != 0) & (num == 0))
			{
				ProjectData.SetProjectError(ex);
				try0001_dispatch = 356;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_2:
			break;
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void Button_ConsGlobaleVendeur_Click(object sender, EventArgs e)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected Obj, but got Unknown
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected Obj, but got Unknown
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected Obj, but got Unknown
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected Obj, but got Unknown
		//IL_0355: Unknown result type (might be due to invalid IL or missing references)
		//IL_035c: Expected Obj, but got Unknown
		//IL_038b: Unknown result type (might be due to invalid IL or missing references)
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
				dataTable.Clear();
				val = new MySqlDataAdapter("select DISTINCT     Vendeur   from   TABLE_VENTES_JOURNAL         WHERE        Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '              and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')        ", Module1.cn_SQL);
				((DbDataAdapter)(object)val).Fill(dataTable);
				DataTable dataTable2 = new DataTable();
				MySqlDataAdapter val2 = new MySqlDataAdapter();
				DataGridView2.Rows.Clear();
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
					dataTable2.Clear();
					val2 = new MySqlDataAdapter("select  sum(Qté) as QTé, sum(TOTAL_NET) as TOTAL_NET    from   TABLE_VENTES_JOURNAL    Where     Vendeur like  '" + dataTable.Rows[num2]["Vendeur"].ToString() + "'     and        Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '               and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')       ", Module1.cn_SQL);
					((DbDataAdapter)(object)val2).Fill(dataTable2);
					DataGridView2.Rows.Add(new object[3]
					{
						dataTable.Rows[num2]["Vendeur"].ToString(),
						Strings.FormatNumber(Conversion.Val(dataTable2.Rows[0]["QTé"].ToString())),
						Strings.FormatNumber(Conversion.Val(dataTable2.Rows[0]["TOTAL_NET"].ToString()))
					});
					DataGridView2.Rows.Add(new object[3] { "", "", "" });
					num2++;
				}
				DataGridView3.Rows.Clear();
				if (Operators.CompareString(Text_PRINTER_RAPPORT.Text, "0", TextCompare: false) != 0 && Operators.CompareString(Text_PRINTER_RAPPORT.Text, "", TextCompare: false) != 0)
				{
					Print_Recette_vendeurGLOBALE.PrinterSettings.PrinterName = Text_PRINTER_RAPPORT.Text;
				}
				if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null), "Button_ConsVendeur", TextCompare: false))
				{
					PrintPreviewDialog val3 = new PrintPreviewDialog();
					val3.Document = Print_Recette_vendeurGLOBALE;
					val3.PrintPreviewControl.Zoom = 2.0;
					((Form)val3).WindowState = (FormWindowState)2;
					((Form)val3).ShowDialog();
				}
				else if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null), "Button_PrintVendeur", TextCompare: false))
				{
					if (Operators.CompareString(MyProject.Forms.Form_0_TEMPLATE.TextBox_BRANCHEMENT.Text, "USB", TextCompare: false) == 0)
					{
						Print_Recette_vendeurGLOBALE.Print();
					}
					else
					{
						Print_Recette_caissier_COM();
					}
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

	private void Combo_CLIENTS_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	private void Button_ConsClients_Click(object sender, EventArgs e)
	{
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected Obj, but got Unknown
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected Obj, but got Unknown
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected Obj, but got Unknown
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0290: Expected Obj, but got Unknown
		//IL_0416: Unknown result type (might be due to invalid IL or missing references)
		//IL_041d: Expected Obj, but got Unknown
		//IL_04b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bb: Expected Obj, but got Unknown
		//IL_04c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cb: Expected Obj, but got Unknown
		//IL_05aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b0: Expected Obj, but got Unknown
		//IL_075f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0766: Expected Obj, but got Unknown
		//IL_0795: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			try
			{
				if (Operators.CompareString(ListBox_CLIENTS.Text, "GLOBALE CLIENTS", TextCompare: false) == 0)
				{
					Button_ConsGlobaleClients_Click(RuntimeHelpers.GetObjectValue(sender), e);
					return;
				}
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
				dataTable.Clear();
				val = new MySqlDataAdapter("select DISTINCT Famille from TABLE_VENTES_JOURNAL   Where  Dates   between        ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '        And        ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '        And     Client like  '" + Strings.Trim(ListBox_CLIENTS.Text) + "'          and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')    ", Module1.cn_SQL);
				((DbDataAdapter)(object)val).Fill(dataTable);
				DataTable dataTable2 = new DataTable();
				MySqlDataAdapter val2 = new MySqlDataAdapter();
				DataGridView2.Rows.Clear();
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
						dataTable.Rows[num2]["Famille"].ToString(),
						".",
						""
					});
					dataTable2.Clear();
					val2 = new MySqlDataAdapter("select Article, sum(Qté) as QTé, sum(TOTAL_NET) as TOTAL_NET    from   TABLE_VENTES_JOURNAL    Where  Famille = '" + Strings.Trim(dataTable.Rows[num2]["Famille"].ToString()) + "'         And      Client like  '" + Strings.Trim(ListBox_CLIENTS.Text) + "'      and    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '             and           (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')       group by Article      ", Module1.cn_SQL);
					((DbDataAdapter)(object)val2).Fill(dataTable2);
					int num5 = dataTable2.Rows.Count - 1;
					int num6 = 0;
					while (true)
					{
						int num7 = num6;
						num4 = num5;
						if (num7 > num4)
						{
							break;
						}
						DataGridView2.Rows.Add(new object[3]
						{
							"  " + dataTable2.Rows[num6]["Article"].ToString(),
							Strings.FormatNumber(Conversion.Val(dataTable2.Rows[num6]["Qté"].ToString())),
							Math.Round(Conversions.ToDecimal(Strings.FormatNumber(Conversion.Val(dataTable2.Rows[num6]["TOTAL_NET"].ToString()))), 2)
						});
						num6++;
					}
					DataGridView2.Rows.Add(new object[3] { "", "", "" });
					num2++;
				}
				DataGridView3.Rows.Clear();
				DataGridView3.Rows.Add(new object[1] { "                    FINANCE--------------" });
				DataTable dataTable3 = new DataTable();
				MySqlDataAdapter val3 = new MySqlDataAdapter();
				dataTable3.Clear();
				val3 = new MySqlDataAdapter("select   DISTINCT     MODE_P    from TABLE_VENTES_REGLEMENTS   Where  Dates   between        ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '        And        ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '              And     Client like  '" + Strings.Trim(ListBox_CLIENTS.Text) + "'                ", Module1.cn_SQL);
				((DbDataAdapter)(object)val3).Fill(dataTable3);
				MySqlDataAdapter val4 = new MySqlDataAdapter();
				DataTable dataTable4 = new DataTable();
				int num8 = dataTable3.Rows.Count - 1;
				int num9 = 0;
				while (true)
				{
					int num10 = num9;
					int num4 = num8;
					if (num10 > num4)
					{
						break;
					}
					val4 = new MySqlDataAdapter("select sum(MONTANT) as n     from    TABLE_VENTES_REGLEMENTS     WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '             And     MODE_P  = '" + Strings.Trim(dataTable3.Rows[num9]["MODE_P"].ToString()) + "'                     And     Client like  '" + Strings.Trim(ListBox_CLIENTS.Text) + "'               ", Module1.cn_SQL);
					dataTable4 = new DataTable();
					dataTable4.Clear();
					((DbDataAdapter)(object)val4).Fill(dataTable4);
					double num11 = Conversion.Val(dataTable4.Rows[0]["n"].ToString());
					DataGridView3.Rows.Add(new object[1] { "                    " + Strings.LSet(dataTable3.Rows[num9]["MODE_P"].ToString(), 8) + ":" + Strings.RSet(Strings.FormatNumber(num11), 8) + " DH" });
					num9++;
				}
				DataGridView3.Rows.Add(new object[1] { "" });
				DataGridView3.Rows.Add(new object[1] { "" });
				if (Operators.CompareString(Text_PRINTER_RAPPORT.Text, "0", TextCompare: false) != 0 && Operators.CompareString(Text_PRINTER_RAPPORT.Text, "", TextCompare: false) != 0)
				{
					Print_Recette_Client.PrinterSettings.PrinterName = Text_PRINTER_RAPPORT.Text;
				}
				if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null), "Button_ConsClients", TextCompare: false))
				{
					PrintPreviewDialog val5 = new PrintPreviewDialog();
					val5.Document = Print_Recette_Client;
					val5.PrintPreviewControl.Zoom = 2.0;
					((Form)val5).WindowState = (FormWindowState)2;
					((Form)val5).ShowDialog();
				}
				else if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null), "Button_PrintClients", TextCompare: false))
				{
					if (Operators.CompareString(MyProject.Forms.Form_0_TEMPLATE.TextBox_BRANCHEMENT.Text, "USB", TextCompare: false) == 0)
					{
						Print_Recette_Client.Print();
					}
					else
					{
						Print_Recette_Client_COM();
					}
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

	private void Button_ConsGlobaleClients_Click(object sender, EventArgs e)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected Obj, but got Unknown
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected Obj, but got Unknown
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected Obj, but got Unknown
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected Obj, but got Unknown
		//IL_0365: Unknown result type (might be due to invalid IL or missing references)
		//IL_036c: Expected Obj, but got Unknown
		//IL_039b: Unknown result type (might be due to invalid IL or missing references)
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
				dataTable.Clear();
				val = new MySqlDataAdapter("select DISTINCT     CLIENT   from   TABLE_VENTES_JOURNAL         WHERE        Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '          ", Module1.cn_SQL);
				((DbDataAdapter)(object)val).Fill(dataTable);
				DataTable dataTable2 = new DataTable();
				MySqlDataAdapter val2 = new MySqlDataAdapter();
				DataGridView2.Rows.Clear();
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
					dataTable2.Clear();
					val2 = new MySqlDataAdapter("select  sum(Qté) as QTé, sum(TOTAL_NET) as TOTAL_NET    from   TABLE_VENTES_JOURNAL    Where     Client like  '" + dataTable.Rows[num2]["CLIENT"].ToString() + "'     and        Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '          ", Module1.cn_SQL);
					((DbDataAdapter)(object)val2).Fill(dataTable2);
					DataGridView2.Rows.Add(new object[3]
					{
						dataTable.Rows[num2]["CLIENT"].ToString(),
						Strings.FormatNumber(Conversion.Val(dataTable2.Rows[0]["QTé"].ToString())),
						Math.Round(Conversions.ToDecimal(Strings.FormatNumber(Conversion.Val(dataTable2.Rows[0]["TOTAL_NET"].ToString()))), 2)
					});
					DataGridView2.Rows.Add(new object[3] { "", "", "" });
					num2++;
				}
				DataGridView3.Rows.Clear();
				if (Operators.CompareString(Text_PRINTER_RAPPORT.Text, "0", TextCompare: false) != 0 && Operators.CompareString(Text_PRINTER_RAPPORT.Text, "", TextCompare: false) != 0)
				{
					Print_Recette_clientGLOBALE.PrinterSettings.PrinterName = Text_PRINTER_RAPPORT.Text;
				}
				if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null), "Button_ConsClients", TextCompare: false))
				{
					PrintPreviewDialog val3 = new PrintPreviewDialog();
					val3.Document = Print_Recette_clientGLOBALE;
					val3.PrintPreviewControl.Zoom = 2.0;
					((Form)val3).WindowState = (FormWindowState)2;
					((Form)val3).ShowDialog();
				}
				else if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null), "Button_PrintClients", TextCompare: false))
				{
					if (Operators.CompareString(MyProject.Forms.Form_0_TEMPLATE.TextBox_BRANCHEMENT.Text, "USB", TextCompare: false) == 0)
					{
						Print_Recette_clientGLOBALE.Print();
					}
					else
					{
						Print_Recette_clientGLOBALE_COM();
					}
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

	private void Panel8_Paint(object sender, PaintEventArgs e)
	{
	}

	private void ListBox_RAPPORT_GLOBALE_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	private void Button_TOTAL_CAISSIER_Click(object sender, EventArgs e)
	{
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Expected Obj, but got Unknown
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected Obj, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected Obj, but got Unknown
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Expected Obj, but got Unknown
		try
		{
			if (Operators.CompareString(ListBox_CAISSIERS.Text, "GLOBALE CAISSIERS", TextCompare: false) != 0)
			{
				DT.Clear();
				DA = new MySqlDataAdapter("select * from   TABLE_VENTES_JOURNAL     Where  Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '       And     Caissier like  '" + Strings.Trim(ListBox_CAISSIERS.Text) + "'       order by ID desc ", Module1.cn_SQL);
				((DbDataAdapter)(object)DA).Fill(DT);
				DataGridView1.DataSource = DT;
				DataTable dataTable = new DataTable();
				MySqlDataAdapter val = new MySqlDataAdapter();
				dataTable.Clear();
				dataTable = new DataTable();
				val = new MySqlDataAdapter("select sum(Total_NET) as n from TABLE_VENTES_JOURNAL WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '       And     Caissier like  '" + Strings.Trim(ListBox_CAISSIERS.Text) + "'          and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')         ", Module1.cn_SQL);
				((DbDataAdapter)(object)val).Fill(dataTable);
				Label_CAISSIER.Text = Strings.FormatNumber(Conversion.Val(dataTable.Rows[0]["n"].ToString()));
				_COLORISE_DATAGRID();
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

	private void Button_TOTAL_VENDEUR_Click(object sender, EventArgs e)
	{
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Expected Obj, but got Unknown
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected Obj, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected Obj, but got Unknown
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Expected Obj, but got Unknown
		try
		{
			if (Operators.CompareString(ListBox_VENDEURS.Text, "GLOBALE VENDEURS", TextCompare: false) != 0)
			{
				DT.Clear();
				DA = new MySqlDataAdapter("select * from   TABLE_VENTES_JOURNAL     Where  Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '       And     Vendeur like  '" + Strings.Trim(ListBox_VENDEURS.Text) + "'  order by ID desc ", Module1.cn_SQL);
				((DbDataAdapter)(object)DA).Fill(DT);
				DataGridView1.DataSource = DT;
				DataTable dataTable = new DataTable();
				MySqlDataAdapter val = new MySqlDataAdapter();
				dataTable.Clear();
				dataTable = new DataTable();
				val = new MySqlDataAdapter("select sum(Total_NET) as n from TABLE_VENTES_JOURNAL WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '       And     Vendeur like  '" + Strings.Trim(ListBox_VENDEURS.Text) + "'           and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')     ", Module1.cn_SQL);
				((DbDataAdapter)(object)val).Fill(dataTable);
				Label_VENDEURS.Text = Strings.FormatNumber(Conversion.Val(dataTable.Rows[0]["n"].ToString()));
				_COLORISE_DATAGRID();
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

	private void Button_TOTAL_FAMILLE_Click(object sender, EventArgs e)
	{
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Expected Obj, but got Unknown
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected Obj, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected Obj, but got Unknown
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Expected Obj, but got Unknown
		try
		{
			if (Operators.CompareString(ListBox_FAMILLES.Text, "GLOBALE FAMILLES", TextCompare: false) != 0)
			{
				DT.Clear();
				DA = new MySqlDataAdapter("select * from   TABLE_VENTES_JOURNAL     Where  Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '           And     Famille like  '" + Strings.Trim(ListBox_FAMILLES.Text) + "'   order by ID desc ", Module1.cn_SQL);
				((DbDataAdapter)(object)DA).Fill(DT);
				DataGridView1.DataSource = DT;
				DataTable dataTable = new DataTable();
				MySqlDataAdapter val = new MySqlDataAdapter();
				dataTable.Clear();
				dataTable = new DataTable();
				val = new MySqlDataAdapter("select sum(Total_NET) as n from TABLE_VENTES_JOURNAL WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '          And     Famille like  '" + Strings.Trim(ListBox_FAMILLES.Text) + "'          and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')      ", Module1.cn_SQL);
				((DbDataAdapter)(object)val).Fill(dataTable);
				Label_FAMILLES.Text = Strings.FormatNumber(Conversion.Val(dataTable.Rows[0]["n"].ToString()));
				_COLORISE_DATAGRID();
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

	private void Button_TOTAL_CLIENT_Click(object sender, EventArgs e)
	{
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Expected Obj, but got Unknown
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected Obj, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected Obj, but got Unknown
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Expected Obj, but got Unknown
		try
		{
			if (Operators.CompareString(ListBox_CLIENTS.Text, "GLOBALE CLIENTS", TextCompare: false) != 0)
			{
				DT.Clear();
				DA = new MySqlDataAdapter("select * from   TABLE_VENTES_JOURNAL     Where  Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '       And     Client like  '" + Strings.Trim(ListBox_CLIENTS.Text) + "'  order by ID desc ", Module1.cn_SQL);
				((DbDataAdapter)(object)DA).Fill(DT);
				DataGridView1.DataSource = DT;
				DataTable dataTable = new DataTable();
				MySqlDataAdapter val = new MySqlDataAdapter();
				dataTable.Clear();
				dataTable = new DataTable();
				val = new MySqlDataAdapter("select sum(Total_NET) as n from TABLE_VENTES_JOURNAL WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '       And     Client like  '" + Strings.Trim(ListBox_CLIENTS.Text) + "'          and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')      ", Module1.cn_SQL);
				((DbDataAdapter)(object)val).Fill(dataTable);
				Label_CLIENTS.Text = Strings.FormatNumber(Conversion.Val(dataTable.Rows[0]["n"].ToString()));
				_COLORISE_DATAGRID();
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

	private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	private void ListBox1_DoubleClick(object sender, EventArgs e)
	{
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected Obj, but got Unknown
		DataGridView1.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)1;
		DataGridViewTextBoxColumn val = new DataGridViewTextBoxColumn();
		((DataGridViewColumn)val).HeaderText = ListBox_COLUMNS.Text;
		((DataGridViewColumn)val).Name = ListBox_COLUMNS.Text;
		((DataGridViewColumn)val).DataPropertyName = ListBox_COLUMNS.Text;
		((DataGridViewColumn)val).Width = 150;
		val.SortMode = (DataGridViewColumnSortMode)2;
		DataGridView1.Columns.Insert(0, (DataGridViewColumn)(object)val);
	}

	private void Button6_Click(object sender, EventArgs e)
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected Obj, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected Obj, but got Unknown
		//IL_0591: Unknown result type (might be due to invalid IL or missing references)
		//IL_0597: Expected Obj, but got Unknown
		//IL_060f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0615: Expected Obj, but got Unknown
		//IL_06ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b2: Expected Obj, but got Unknown
		//IL_06e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ec: Invalid comparison between Unknown and I4
		//IL_0299: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Expected Obj, but got Unknown
		//IL_0457: Unknown result type (might be due to invalid IL or missing references)
		//IL_045d: Expected Obj, but got Unknown
		//IL_0822: Unknown result type (might be due to invalid IL or missing references)
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
				dataTable.Clear();
				val = new MySqlDataAdapter("select DISTINCT Famille from TABLE_VENTES_JOURNAL   Where  Dates   between        ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '        And        ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '       ", Module1.cn_SQL);
				((DbDataAdapter)(object)val).Fill(dataTable);
				DataTable dataTable2 = new DataTable();
				MySqlDataAdapter val2 = new MySqlDataAdapter();
				DataGridView2.Rows.Clear();
				DataGridView2.Rows.Add(new object[3] { "Article", "Qté", "Total_NET" });
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
					DataGridView2.Rows.Add(new object[5]
					{
						"- " + dataTable.Rows[num2]["Famille"].ToString().PadRight(20, '-'),
						"------------",
						"------------",
						"------------",
						"------------"
					});
					if (Operators.CompareString(ListBox_RAPPORT_GLOBALE.Text, "Par Article", TextCompare: false) == 0)
					{
						dataTable2.Clear();
						val2 = new MySqlDataAdapter("select Article, sum(Qté) as QTé, sum(TOTAL_NET) as TOTAL_NET    from   TABLE_VENTES_JOURNAL    Where  Famille = '" + Strings.Trim(dataTable.Rows[num2]["Famille"].ToString()) + "'      and        Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '         group by Article      ", Module1.cn_SQL);
						((DbDataAdapter)(object)val2).Fill(dataTable2);
						int num5 = dataTable2.Rows.Count - 1;
						int num6 = 0;
						while (true)
						{
							int num7 = num6;
							num4 = num5;
							if (num7 > num4)
							{
								break;
							}
							DataGridView2.Rows.Add(new object[3]
							{
								"  " + dataTable2.Rows[num6]["Article"].ToString(),
								Strings.FormatNumber(Conversion.Val(dataTable2.Rows[num6]["Qté"].ToString())),
								Strings.FormatNumber(Conversion.Val(dataTable2.Rows[num6]["TOTAL_NET"].ToString()))
							});
							num6++;
						}
					}
					if (Operators.CompareString(ListBox_RAPPORT_GLOBALE.Text, "Par Famille", TextCompare: false) == 0)
					{
						dataTable2.Clear();
						val2 = new MySqlDataAdapter("select  sum(Qté) as QTé, sum(TOTAL_NET) as TOTAL_NET    from   TABLE_VENTES_JOURNAL    Where  Famille = '" + Strings.Trim(dataTable.Rows[num2]["Famille"].ToString()) + "'      and        Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '          ", Module1.cn_SQL);
						((DbDataAdapter)(object)val2).Fill(dataTable2);
						DataGridView2.Rows.Add(new object[3]
						{
							"  *TOTAL FAMILLE*",
							Strings.FormatNumber(Conversion.Val(dataTable2.Rows[0]["Qté"].ToString())),
							Strings.FormatNumber(Conversion.Val(dataTable2.Rows[0]["TOTAL_NET"].ToString()))
						});
					}
					num2++;
				}
				DataGridView2.Rows.Add(new object[3] { "------------", "------------", "------------" });
				DataGridView2.Rows.Add(new object[3] { "------------", "------------", "------------" });
				double num8 = 0.0;
				DataTable dataTable3 = new DataTable();
				MySqlDataAdapter val3 = new MySqlDataAdapter();
				dataTable3.Clear();
				val3 = new MySqlDataAdapter("select sum(Total_NET) as n     from TABLE_VENTES_JOURNAL WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " ' ", Module1.cn_SQL);
				((DbDataAdapter)(object)val3).Fill(dataTable3);
				num8 = Conversions.ToDouble(Strings.FormatNumber(Conversion.Val(dataTable3.Rows[0]["n"].ToString())));
				DataGridView2.Rows.Add(new object[3]
				{
					"TOTAL NET: " + Strings.RSet(Conversions.ToString(num8), 8) + " DH",
					"------------",
					"------------"
				});
				Module1._QUITTER_PATIENTER = true;
				SaveFileDialog val4 = new SaveFileDialog();
				((FileDialog)val4).Filter = "Text Files (*.csv)|*.csv";
				((FileDialog)val4).FileName = "Spécial Viandal_" + DateTime.Now.ToString("dd-MM-yyy HH-mm-ss");
				if (unchecked((int)((CommonDialog)val4).ShowDialog()) == 1)
				{
					string separator = ";";
					StringBuilder stringBuilder = new StringBuilder();
					int num9 = DataGridView2.Rows.Count - 1;
					int num10 = 0;
					while (true)
					{
						int num11 = num10;
						int num4 = num9;
						if (num11 > num4)
						{
							break;
						}
						string[] array = new string[((BaseCollection)DataGridView2.Columns).Count - 1 + 1];
						if (num10.Equals(0))
						{
						}
						int num12 = ((BaseCollection)DataGridView2.Columns).Count - 1;
						int num13 = 0;
						while (true)
						{
							int num14 = num13;
							num4 = num12;
							if (num14 > num4)
							{
								break;
							}
							if (!DataGridView2.Rows[num10].IsNewRow)
							{
								array[num13] = DataGridView2[num13, num10].Value.ToString();
							}
							num13++;
						}
						if (!DataGridView2.Rows[num10].IsNewRow)
						{
							stringBuilder.AppendLine(string.Join(separator, array));
						}
						num10++;
					}
					File.WriteAllText(((FileDialog)val4).FileName, stringBuilder.ToString(), Encoding.Default);
					MessageBox.Show("exportation avec succès", "ok", (MessageBoxButtons)0, (MessageBoxIcon)64, (MessageBoxDefaultButton)0);
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
				Interaction.MsgBox(ex2.ToString());
				NewLateBinding.LateSet(sender, null, "enabled", new object[1] { true }, null, null);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void Button_ConsJOURS_Click(object sender, EventArgs e)
	{
		//IL_2889: Unknown result type (might be due to invalid IL or missing references)
		//IL_2890: Expected Obj, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected Obj, but got Unknown
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected Obj, but got Unknown
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Expected Obj, but got Unknown
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Expected Obj, but got Unknown
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Expected Obj, but got Unknown
		//IL_04e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ef: Expected Obj, but got Unknown
		//IL_0567: Unknown result type (might be due to invalid IL or missing references)
		//IL_056e: Expected Obj, but got Unknown
		//IL_0578: Unknown result type (might be due to invalid IL or missing references)
		//IL_057f: Expected Obj, but got Unknown
		//IL_0337: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Expected Obj, but got Unknown
		//IL_063f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0646: Expected Obj, but got Unknown
		//IL_0773: Unknown result type (might be due to invalid IL or missing references)
		//IL_077a: Expected Obj, but got Unknown
		//IL_07f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f8: Expected Obj, but got Unknown
		//IL_08ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f3: Expected Obj, but got Unknown
		//IL_096a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0971: Expected Obj, but got Unknown
		//IL_0a68: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a6f: Expected Obj, but got Unknown
		//IL_0ae6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aed: Expected Obj, but got Unknown
		//IL_0da9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0daf: Expected Obj, but got Unknown
		//IL_0e26: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e2c: Expected Obj, but got Unknown
		//IL_0c2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c32: Expected Obj, but got Unknown
		//IL_0ca2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca9: Expected Obj, but got Unknown
		//IL_0ffe: Unknown result type (might be due to invalid IL or missing references)
		//IL_1004: Expected Obj, but got Unknown
		//IL_1166: Unknown result type (might be due to invalid IL or missing references)
		//IL_116d: Expected Obj, but got Unknown
		//IL_12e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_12ea: Expected Obj, but got Unknown
		//IL_14f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_14ff: Expected Obj, but got Unknown
		//IL_16a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_16ab: Expected Obj, but got Unknown
		//IL_184b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1855: Expected Obj, but got Unknown
		//IL_1b14: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b1b: Expected Obj, but got Unknown
		//IL_1c91: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c98: Expected Obj, but got Unknown
		//IL_19f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a01: Expected Obj, but got Unknown
		//IL_20a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_20ae: Expected Obj, but got Unknown
		//IL_2304: Unknown result type (might be due to invalid IL or missing references)
		//IL_230a: Expected Obj, but got Unknown
		//IL_242a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2430: Expected Obj, but got Unknown
		//IL_26fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_2704: Expected Obj, but got Unknown
		//IL_2733: Unknown result type (might be due to invalid IL or missing references)
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
					catch (Exception ex5)
					{
						ProjectData.SetProjectError(ex5);
						Exception e2 = ex5;
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
				DataGridView2.Rows.Clear();
				DateTime date = Conversions.ToDate(DateTimePicker1.Text);
				DateTime date2 = Conversions.ToDate(DateTimePicker2.Text);
				int num = (int)DateAndTime.DateDiff(DateInterval.Day, date, date2);
				DateTime dateTime = Conversions.ToDate(DateTimePicker1.Text);
				int num2 = num;
				int num3 = 0;
				while (true)
				{
					int num4 = num3;
					int num5 = num2;
					if (num4 > num5)
					{
						break;
					}
					double num6 = 0.0;
					DataTable dataTable = new DataTable();
					MySqlDataAdapter val = new MySqlDataAdapter();
					dataTable.Clear();
					val = new MySqlDataAdapter("select sum(Total_NET) as n     from TABLE_VENTES_JOURNAL WHERE    Dates   between   ' " + Strings.Format(dateTime, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(dateTime, "yyyy-MM-dd") + " '                     and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')          ", Module1.cn_SQL);
					((DbDataAdapter)(object)val).Fill(dataTable);
					num6 = Conversions.ToDouble(Strings.FormatNumber(Conversion.Val(dataTable.Rows[0]["n"].ToString())));
					DataGridView2.Rows.Add(new object[3]
					{
						Strings.Format(dateTime, "ddd") + " " + Strings.Format(dateTime, "dd/MM/yyyy"),
						Strings.RSet(Strings.FormatNumber(num6) + " DH", 18),
						"."
					});
					DataTable dataTable2 = new DataTable();
					MySqlDataAdapter val2 = new MySqlDataAdapter();
					dataTable2.Clear();
					val2 = new MySqlDataAdapter("select   DISTINCT     MODE_P    from TABLE_VENTES_REGLEMENTS   Where  Dates   between        ' " + Strings.Format(dateTime, "yyyy-MM-dd") + " '        And        ' " + Strings.Format(dateTime, "yyyy-MM-dd") + " '       ", Module1.cn_SQL);
					((DbDataAdapter)(object)val2).Fill(dataTable2);
					MySqlDataAdapter val3 = new MySqlDataAdapter();
					DataTable dataTable3 = new DataTable();
					int num7 = dataTable2.Rows.Count - 1;
					int num8 = 0;
					while (true)
					{
						int num9 = num8;
						num5 = num7;
						if (num9 > num5)
						{
							break;
						}
						val3 = new MySqlDataAdapter("select sum(MONTANT) as n     from    TABLE_VENTES_REGLEMENTS     WHERE    Dates   between   ' " + Strings.Format(dateTime, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(dateTime, "yyyy-MM-dd") + " '             And     MODE_P  = '" + Strings.Trim(dataTable2.Rows[num8]["MODE_P"].ToString()) + "'  ", Module1.cn_SQL);
						dataTable3 = new DataTable();
						dataTable3.Clear();
						((DbDataAdapter)(object)val3).Fill(dataTable3);
						double num10 = Conversion.Val(dataTable3.Rows[0]["n"].ToString());
						DataGridView2.Rows.Add(new object[3]
						{
							"                  " + Strings.LSet(dataTable2.Rows[num8]["MODE_P"].ToString(), 8) + ":",
							Strings.RSet(Strings.FormatNumber(num10) + " DH", 18),
							""
						});
						num8++;
					}
					dateTime = dateTime.AddDays(1.0);
					num3++;
				}
				DataGridView2.Rows.Add(new object[3] { "", "", "" });
				DataGridView2.Rows.Add(new object[3] { "", "", "" });
				DataGridView3.Rows.Clear();
				DataGridView3.Rows.Add(new object[1] { "                    FINANCE--------------" });
				DataTable dataTable4 = new DataTable();
				MySqlDataAdapter val4 = new MySqlDataAdapter();
				dataTable4.Clear();
				val4 = new MySqlDataAdapter("select   DISTINCT     MODE_P    from TABLE_VENTES_REGLEMENTS   Where  Dates   between        ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '        And        ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '       ", Module1.cn_SQL);
				((DbDataAdapter)(object)val4).Fill(dataTable4);
				MySqlDataAdapter val5 = new MySqlDataAdapter();
				DataTable dataTable5 = new DataTable();
				int num11 = dataTable4.Rows.Count - 1;
				int num12 = 0;
				while (true)
				{
					int num13 = num12;
					int num5 = num11;
					if (num13 > num5)
					{
						break;
					}
					val5 = new MySqlDataAdapter("select sum(MONTANT) as n     from    TABLE_VENTES_REGLEMENTS     WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '             And     MODE_P  = '" + Strings.Trim(dataTable4.Rows[num12]["MODE_P"].ToString()) + "'  ", Module1.cn_SQL);
					dataTable5 = new DataTable();
					dataTable5.Clear();
					((DbDataAdapter)(object)val5).Fill(dataTable5);
					double num14 = Conversion.Val(dataTable5.Rows[0]["n"].ToString());
					DataGridView3.Rows.Add(new object[1] { "                    " + Strings.LSet(dataTable4.Rows[num12]["MODE_P"].ToString(), 8) + ":" + Strings.RSet(Strings.FormatNumber(num14), 8) + " DH" });
					num12++;
				}
				DataGridView3.Rows.Add(new object[1] { "" });
				DataGridView3.Rows.Add(new object[1] { "" });
				MySqlDataAdapter val6 = new MySqlDataAdapter();
				DataTable dataTable6 = new DataTable();
				val6 = new MySqlDataAdapter("SELECT    SUM(MONTANT)      as N          FROM   TABLE_CLIENTS_REGLE     WHERE       DATES   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '       ", Module1.cn_SQL);
				dataTable6 = new DataTable();
				dataTable6.Clear();
				((DbDataAdapter)(object)val6).Fill(dataTable6);
				decimal num15 = new decimal(Conversion.Val(dataTable6.Rows[0]["n"].ToString()));
				if (decimal.Compare(num15, 0m) != 0)
				{
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("(+) REGLE CLIENTS     : ", 29) + Strings.RSet(Strings.FormatNumber(num15), 8) + " DH" });
					DataGridView3.Rows.Add(new object[1] { "" });
					DataGridView3.Rows.Add(new object[1] { "" });
				}
				MySqlDataAdapter val7 = new MySqlDataAdapter();
				DataTable dataTable7 = new DataTable();
				val7 = new MySqlDataAdapter("SELECT    SUM(MONTANT)      as N          FROM   TABLE_FOURNISSEURS_REGLE     WHERE       DATES   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '       ", Module1.cn_SQL);
				dataTable7 = new DataTable();
				dataTable7.Clear();
				((DbDataAdapter)(object)val7).Fill(dataTable7);
				decimal num16 = new decimal(Conversion.Val(dataTable7.Rows[0]["n"].ToString()));
				if (decimal.Compare(num16, 0m) != 0)
				{
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("(-) REGLE FOURNISSEURS: ", 29) + Strings.RSet(Strings.FormatNumber(num16), 8) + " DH" });
					DataGridView3.Rows.Add(new object[1] { "" });
					DataGridView3.Rows.Add(new object[1] { "" });
				}
				MySqlDataAdapter val8 = new MySqlDataAdapter();
				DataTable dataTable8 = new DataTable();
				val8 = new MySqlDataAdapter(" select sum(Montant) as n                   FROM   TABLE_DEPENSES           WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '   ", Module1.cn_SQL);
				dataTable8 = new DataTable();
				dataTable8.Clear();
				((DbDataAdapter)(object)val8).Fill(dataTable8);
				decimal num17 = new decimal(Conversion.Val(dataTable8.Rows[0]["n"].ToString()));
				if (decimal.Compare(num17, 0m) != 0)
				{
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("(-) DEPENSES          : ", 29) + Strings.RSet(Strings.FormatNumber(num17), 8) + " DH" });
					DataGridView3.Rows.Add(new object[1] { "" });
					DataGridView3.Rows.Add(new object[1] { "" });
				}
				if ((decimal.Compare(num15, 0m) != 0) | (decimal.Compare(num17, 0m) != 0) | (decimal.Compare(num16, 0m) != 0))
				{
					DataTable dataTable9 = new DataTable();
					MySqlDataAdapter val9 = new MySqlDataAdapter();
					val9 = new MySqlDataAdapter("select sum(Total_NET) as n     from TABLE_VENTES_JOURNAL WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '        and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')    ", Module1.cn_SQL);
					dataTable9 = new DataTable();
					dataTable9.Clear();
					((DbDataAdapter)(object)val9).Fill(dataTable9);
					decimal d = Conversions.ToDecimal(Strings.FormatNumber(Conversion.Val(dataTable9.Rows[0]["n"].ToString())));
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("(=) TOTAL             : ", 29) + Strings.RSet(Strings.FormatNumber(decimal.Subtract(decimal.Subtract(decimal.Add(d, num15), num16), num17)), 8) + " DH" });
					DataGridView3.Rows.Add(new object[1] { "" });
					DataGridView3.Rows.Add(new object[1] { "" });
				}
				MySqlDataAdapter val10 = new MySqlDataAdapter();
				DataTable dataTable10 = new DataTable();
				val10 = new MySqlDataAdapter("select Caissier, sum(TOTAL_NET) as TOTAL_NET    from   TABLE_VENTES_JOURNAL    Where           Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '             and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')            group by Caissier      ", Module1.cn_SQL);
				dataTable10 = new DataTable();
				dataTable10.Clear();
				((DbDataAdapter)(object)val10).Fill(dataTable10);
				if (dataTable10.Rows.Count > 0)
				{
					DataGridView3.Rows.Add(new object[1] { "---------------CAISSIERS-----------------" });
					int num18 = dataTable10.Rows.Count - 1;
					int num19 = 0;
					while (true)
					{
						int num20 = num19;
						int num5 = num18;
						if (num20 > num5)
						{
							break;
						}
						DataGridView3.Rows.Add(new object[1] { Strings.LSet("- " + dataTable10.Rows[num19]["Caissier"].ToString(), 22) + ":      " + Strings.RSet(Strings.FormatNumber(Conversion.Val(dataTable10.Rows[num19]["TOTAL_NET"].ToString())), 8) + " DH" });
						num19++;
					}
					DataGridView3.Rows.Add(new object[1] { "" });
					DataGridView3.Rows.Add(new object[1] { "" });
				}
				val10 = new MySqlDataAdapter("select VENDEUR, sum(TOTAL_NET) as TOTAL_NET    from   TABLE_VENTES_JOURNAL    Where        VENDEUR <> ''        and      Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '             and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')            group by VENDEUR      ", Module1.cn_SQL);
				dataTable10 = new DataTable();
				dataTable10.Clear();
				((DbDataAdapter)(object)val10).Fill(dataTable10);
				if (dataTable10.Rows.Count > 0)
				{
					DataGridView3.Rows.Add(new object[1] { "---------------VENDEURS------------------" });
					int num21 = dataTable10.Rows.Count - 1;
					int num22 = 0;
					while (true)
					{
						int num23 = num22;
						int num5 = num21;
						if (num23 > num5)
						{
							break;
						}
						DataGridView3.Rows.Add(new object[1] { Strings.LSet("- " + dataTable10.Rows[num22]["VENDEUR"].ToString(), 22) + ":      " + Strings.RSet(Strings.FormatNumber(Conversion.Val(dataTable10.Rows[num22]["TOTAL_NET"].ToString())), 8) + " DH" });
						num22++;
					}
					DataGridView3.Rows.Add(new object[1] { "" });
					DataGridView3.Rows.Add(new object[1] { "" });
				}
				MySqlDataAdapter val11 = new MySqlDataAdapter();
				DataTable dataTable11 = new DataTable();
				val11 = new MySqlDataAdapter("(select sum(Total_NET) as n from TABLE_VENTES_JOURNAL WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '            and            (OPERATION = 'RETOUR REMBOURSEMENT')     )    UNION ALL  (select sum(Total_NET) as n from TABLE_VENTES_JOURNAL WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '            and            (OPERATION = 'RETOUR AVOIR')    )       UNION ALL  (select sum(Total_NET) as n from TABLE_VENTES_JOURNAL WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '            and            (OPERATION = 'CREDIT')    )             UNION ALL  (select sum(Total_NET) as n from TABLE_VENTES_JOURNAL WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '            and            (OPERATION = 'RETOUR CREDIT')    )   ", Module1.cn_SQL);
				dataTable11 = new DataTable();
				dataTable11.Clear();
				((DbDataAdapter)(object)val11).Fill(dataTable11);
				decimal num24 = new decimal(Conversion.Val(dataTable11.Rows[0]["n"].ToString()));
				decimal num25 = new decimal(Conversion.Val(dataTable11.Rows[1]["n"].ToString()));
				decimal num26 = new decimal(Conversion.Val(dataTable11.Rows[2]["n"].ToString()));
				decimal num27 = new decimal(Conversion.Val(dataTable11.Rows[3]["n"].ToString()));
				if ((decimal.Compare(num24, 0m) != 0) | (decimal.Compare(num25, 0m) != 0) | (decimal.Compare(num26, 0m) != 0) | (decimal.Compare(num27, 0m) != 0))
				{
					DataGridView3.Rows.Add(new object[1] { "---------------ATTENTION-----------------" });
				}
				if (decimal.Compare(num24, 0m) != 0)
				{
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("RETOUR REMBOURSEMENT  : ", 29) + Strings.RSet(Conversions.ToString(num24), 8) + " DH" });
					Module1._DT_TEMP.Clear();
					Module1._DA_TEMP = new MySqlDataAdapter("select Article, sum(Qté) as Qté   from   TABLE_VENTES_JOURNAL    Where              Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '             and            (OPERATION = 'RETOUR REMBOURSEMENT')               group by Article      ", Module1.cn_SQL);
					((DbDataAdapter)(object)Module1._DA_TEMP).Fill(Module1._DT_TEMP);
					int num28 = Module1._DT_TEMP.Rows.Count - 1;
					int num29 = 0;
					while (true)
					{
						int num30 = num29;
						int num5 = num28;
						if (num30 > num5)
						{
							break;
						}
						DataGridView3.Rows.Add(new object[1] { "  " + Strings.LSet(Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(Module1._DT_TEMP.Rows[num29]["Qté"].ToString()))) + "x", 7) + Module1._DT_TEMP.Rows[num29]["Article"].ToString() });
						num29++;
					}
				}
				if (decimal.Compare(num25, 0m) != 0)
				{
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("RETOUR AVOIR          : ", 29) + Strings.RSet(Conversions.ToString(num25), 8) + " DH" });
					Module1._DT_TEMP.Clear();
					Module1._DA_TEMP = new MySqlDataAdapter("select Article, sum(Qté) as Qté   from   TABLE_VENTES_JOURNAL    Where              Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '             and            (OPERATION = 'RETOUR AVOIR')               group by Article      ", Module1.cn_SQL);
					((DbDataAdapter)(object)Module1._DA_TEMP).Fill(Module1._DT_TEMP);
					int num31 = Module1._DT_TEMP.Rows.Count - 1;
					int num32 = 0;
					while (true)
					{
						int num33 = num32;
						int num5 = num31;
						if (num33 > num5)
						{
							break;
						}
						DataGridView3.Rows.Add(new object[1] { "  " + Strings.LSet(Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(Module1._DT_TEMP.Rows[num32]["Qté"].ToString()))) + "x", 7) + Module1._DT_TEMP.Rows[num32]["Article"].ToString() });
						num32++;
					}
				}
				if (decimal.Compare(num26, 0m) != 0)
				{
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("CREDIT                : ", 29) + Strings.RSet(Conversions.ToString(num26), 8) + " DH" });
					Module1._DT_TEMP.Clear();
					Module1._DA_TEMP = new MySqlDataAdapter("select Article, sum(Qté) as Qté   from   TABLE_VENTES_JOURNAL    Where              Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '             and            (OPERATION = 'CREDIT')               group by Article      ", Module1.cn_SQL);
					((DbDataAdapter)(object)Module1._DA_TEMP).Fill(Module1._DT_TEMP);
					int num34 = Module1._DT_TEMP.Rows.Count - 1;
					int num35 = 0;
					while (true)
					{
						int num36 = num35;
						int num5 = num34;
						if (num36 > num5)
						{
							break;
						}
						DataGridView3.Rows.Add(new object[1] { "  " + Strings.LSet(Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(Module1._DT_TEMP.Rows[num35]["Qté"].ToString()))) + "x", 7) + Module1._DT_TEMP.Rows[num35]["Article"].ToString() });
						num35++;
					}
				}
				if (decimal.Compare(num27, 0m) != 0)
				{
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("RETOUR CREDIT         : ", 29) + Strings.RSet(Conversions.ToString(num27), 8) + " DH" });
					Module1._DT_TEMP.Clear();
					Module1._DA_TEMP = new MySqlDataAdapter("select Article, sum(Qté) as Qté   from   TABLE_VENTES_JOURNAL    Where              Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '             and            (OPERATION = 'RETOUR CREDIT')               group by Article      ", Module1.cn_SQL);
					((DbDataAdapter)(object)Module1._DA_TEMP).Fill(Module1._DT_TEMP);
					int num37 = Module1._DT_TEMP.Rows.Count - 1;
					int num38 = 0;
					while (true)
					{
						int num39 = num38;
						int num5 = num37;
						if (num39 > num5)
						{
							break;
						}
						DataGridView3.Rows.Add(new object[1] { "  " + Strings.LSet(Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(Module1._DT_TEMP.Rows[num38]["Qté"].ToString()))) + "x", 7) + Module1._DT_TEMP.Rows[num38]["Article"].ToString() });
						num38++;
					}
				}
				DataGridView3.Rows.Add(new object[1] { "" });
				DataGridView3.Rows.Add(new object[1] { "" });
				MySqlDataAdapter val12 = new MySqlDataAdapter();
				DataTable dataTable12 = new DataTable();
				val12 = new MySqlDataAdapter("(select sum(TOTAL_NET) as n     from    TABLE_VENTES_JOURNAL     WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '                and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')          And      (Notes LIKE 'TABLE%' OR Notes LIKE 'SUR PLACE%')    )      UNION ALL   (select sum(TOTAL_NET) as n     from    TABLE_VENTES_JOURNAL     WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '                  and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')         And     Notes  like 'EMPORTER%'  )      UNION ALL   (select sum(TOTAL_NET) as n     from    TABLE_VENTES_JOURNAL     WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '                and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')            And     Notes  like 'LIVRAISON%'  )       UNION ALL   (select sum(TOTAL_NET) as n     from    TABLE_VENTES_JOURNAL     WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '                and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')           And     Notes  like 'DIRECTE%'  )         ", Module1.cn_SQL);
				dataTable12 = new DataTable();
				dataTable12.Clear();
				((DbDataAdapter)(object)val12).Fill(dataTable12);
				double num40 = Conversion.Val(dataTable12.Rows[0]["n"].ToString());
				double num41 = Conversion.Val(dataTable12.Rows[1]["n"].ToString());
				double num42 = Conversion.Val(dataTable12.Rows[2]["n"].ToString());
				double num43 = Conversion.Val(dataTable12.Rows[3]["n"].ToString());
				if ((num40 != 0.0) | (num41 != 0.0) | (num42 != 0.0) | (num43 != 0.0))
				{
					DataGridView3.Rows.Add(new object[1] { "-----------------NOTES-------------------" });
				}
				if (num40 != 0.0)
				{
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("- SUR PLACE           : ", 29) + Strings.RSet(Strings.FormatNumber(num40), 8) + " DH" });
				}
				if (num41 != 0.0)
				{
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("- EMPORTER            : ", 29) + Strings.RSet(Strings.FormatNumber(num41), 8) + " DH" });
				}
				if (num42 != 0.0)
				{
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("- LIVRAISON           : ", 29) + Strings.RSet(Strings.FormatNumber(num42), 8) + " DH" });
				}
				if (num43 != 0.0)
				{
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("- DIRECTE             : ", 29) + Strings.RSet(Strings.FormatNumber(num43), 8) + " DH" });
				}
				DataGridView3.Rows.Add(new object[1] { "" });
				DataGridView3.Rows.Add(new object[1] { "" });
				val11 = new MySqlDataAdapter("( select sum((PRIX_V*Qté)-TOTAL_NET) as n                    from TABLE_VENTES_JOURNAL WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '             AND    REMISE <  100 )      UNION ALL        ( select sum((PRIX_V*Qté)-TOTAL_NET) as n                   from TABLE_VENTES_JOURNAL WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '              AND       REMISE = 100 ) UNION ALL (select sum(TOTAL_NET) as n       from TABLE_VENTES_JOURNAL WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '             And       Famille = 'FAM_DIVERS' )  ", Module1.cn_SQL);
				dataTable11 = new DataTable();
				dataTable11.Clear();
				((DbDataAdapter)(object)val11).Fill(dataTable11);
				decimal num44 = new decimal(Conversion.Val(dataTable11.Rows[0]["n"].ToString()));
				decimal num45 = new decimal(Conversion.Val(dataTable11.Rows[1]["n"].ToString()));
				decimal num46 = new decimal(Conversion.Val(dataTable11.Rows[2]["n"].ToString()));
				if ((decimal.Compare(num44, 0m) != 0) | (decimal.Compare(num45, 0m) != 0) | (decimal.Compare(num46, 0m) != 0))
				{
					DataGridView3.Rows.Add(new object[1] { "---------------ATTENTION-----------------" });
				}
				if (decimal.Compare(num44, 0m) != 0)
				{
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("IL YA DES REMISE      : ", 29) + Strings.RSet(Conversions.ToString(num44), 8) + " DH" });
				}
				if (decimal.Compare(num45, 0m) != 0)
				{
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("IL YA DES OFFERT      : ", 29) + Strings.RSet(Conversions.ToString(num45), 8) + " DH" });
				}
				if (decimal.Compare(num46, 0m) != 0)
				{
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("IL YA DES DIVERS      : ", 29) + Strings.RSet(Conversions.ToString(num46), 8) + " DH" });
				}
				DataGridView3.Rows.Add(new object[1] { "" });
				DataGridView3.Rows.Add(new object[1] { "" });
				MySqlDataAdapter val13 = new MySqlDataAdapter();
				DataTable dataTable13 = new DataTable();
				val13 = new MySqlDataAdapter("(SELECT    count(id)      as N          FROM   TABLE_RECEPTIONS_ENTETE    WHERE       DATES   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '     )       UNION ALL    (SELECT    count(id)      as N          FROM   TABLE_SORTIES_ENTETE    WHERE       DATES   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '  )       UNION ALL    (SELECT    count(id)      as N          FROM   TABLE_INVENTAIRES_ENTETE    WHERE       DATES   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '  )  ", Module1.cn_SQL);
				dataTable13 = new DataTable();
				dataTable13.Clear();
				((DbDataAdapter)(object)val13).Fill(dataTable13);
				decimal num47 = new decimal(Conversion.Val(dataTable13.Rows[0]["n"].ToString()));
				decimal num48 = new decimal(Conversion.Val(dataTable13.Rows[1]["n"].ToString()));
				decimal num49 = new decimal(Conversion.Val(dataTable13.Rows[2]["n"].ToString()));
				if ((decimal.Compare(num47, 0m) != 0) | (decimal.Compare(num48, 0m) != 0) | (decimal.Compare(num49, 0m) != 0))
				{
					DataGridView3.Rows.Add(new object[1] { "---------------ATTENTION-----------------" });
				}
				if (decimal.Compare(num47, 0m) != 0)
				{
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("IL YA DES RECEPTIONS  : ", 29) + Strings.RSet(Conversions.ToString(num47), 8) });
				}
				if (decimal.Compare(num48, 0m) != 0)
				{
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("IL YA DES SORTIES     : ", 29) + Strings.RSet(Conversions.ToString(num48), 8) });
				}
				if (decimal.Compare(num49, 0m) != 0)
				{
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("IL YA DES INVENTAIRES : ", 29) + Strings.RSet(Conversions.ToString(num49), 8) });
				}
				DataGridView3.Rows.Add(new object[1] { "" });
				DataGridView3.Rows.Add(new object[1] { "" });
				if (Operators.CompareString(Text_PRINTER_RAPPORT.Text, "0", TextCompare: false) != 0 && Operators.CompareString(Text_PRINTER_RAPPORT.Text, "", TextCompare: false) != 0)
				{
					Print_Recette_Jours.PrinterSettings.PrinterName = Text_PRINTER_RAPPORT.Text;
				}
				if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null), "Button_ConsRapport", TextCompare: false))
				{
					PrintPreviewDialog val14 = new PrintPreviewDialog();
					val14.Document = Print_Recette_Jours;
					val14.PrintPreviewControl.Zoom = 2.0;
					((Form)val14).WindowState = (FormWindowState)2;
					((Form)val14).ShowDialog();
				}
				else if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null), "Button_PrintRapport", TextCompare: false))
				{
					if (Operators.CompareString(MyProject.Forms.Form_0_TEMPLATE.TextBox_BRANCHEMENT.Text, "USB", TextCompare: false) == 0)
					{
						Print_Recette_Jours.Print();
					}
					else
					{
						Print_Recette_Jours_COM();
					}
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
				NewLateBinding.LateSet(sender, null, "enabled", new object[1] { true }, null, null);
				Interaction.MsgBox(ex2.Message + "\r\nLigne : " + Conversions.ToString(fileLineNumber) + "\r\n");
				try
				{
					string text = Strings.Format(DateTime.Now, "yyMMddHHmmssfff");
					Bitmap val15 = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, (PixelFormat)2498570);
					Graphics val16 = Graphics.FromImage((Image)(object)val15);
					val16.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, (CopyPixelOperation)13369376);
					((Image)val15).Save(Application.StartupPath + "\\tchak\\" + text + ".snidb", ImageFormat.Jpeg);
					val15 = null;
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

	private void Print_Recette_Jour_PrintPage(object sender, PrintPageEventArgs e)
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
		//IL_06c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c7: Expected Obj, but got Unknown
		//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f7: Expected Obj, but got Unknown
		//IL_036f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0376: Expected Obj, but got Unknown
		//IL_03cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0407: Expected Obj, but got Unknown
		//IL_0407: Expected Obj, but got Unknown
		//IL_043b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0469: Unknown result type (might be due to invalid IL or missing references)
		//IL_0473: Expected Obj, but got Unknown
		//IL_0473: Expected Obj, but got Unknown
		//IL_048a: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c2: Expected Obj, but got Unknown
		//IL_04c2: Expected Obj, but got Unknown
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c4: Expected Obj, but got Unknown
		//IL_02c4: Expected Obj, but got Unknown
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Expected Obj, but got Unknown
		//IL_022b: Expected Obj, but got Unknown
		//IL_0533: Unknown result type (might be due to invalid IL or missing references)
		//IL_0561: Unknown result type (might be due to invalid IL or missing references)
		//IL_056b: Expected Obj, but got Unknown
		//IL_056b: Expected Obj, but got Unknown
		//IL_0590: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cd: Expected Obj, but got Unknown
		//IL_0615: Unknown result type (might be due to invalid IL or missing references)
		//IL_061f: Expected Obj, but got Unknown
		//IL_061f: Expected Obj, but got Unknown
		checked
		{
			try
			{
				e.Graphics.FillRectangle((Brush)new SolidBrush(Color.Black), 0, 0, 260, 20);
				string text = "RAPPORT JOURS";
				e.Graphics.DrawString(text, new Font("Inconsolata Condensed", 13f, (FontStyle)1), Brushes.White, Convert.ToSingle(130f - e.Graphics.MeasureString(text, new Font("Inconsolata Condensed", 13f, (FontStyle)1)).Width / 2f), 0f, new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("Rapport :" + Strings.Format(DateTimePicker1.Value, "dd/MM/yyyy") + " ==> " + Strings.Format(DateTimePicker2.Value, "dd/MM/yyyy"), new Font("Inconsolata Condensed", 10f, (FontStyle)1), Brushes.Black, 0f, 80f, new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("-----------------------------------------", new Font("Inconsolata Condensed", 11f, (FontStyle)0), Brushes.Black, 0f, 100f, new StringFormat((StringFormatFlags)8192));
				string text2 = "";
				int num = 0;
				int num2 = DataGridView2.RowCount - 1;
				int num3 = 0;
				while (true)
				{
					int num4 = num3;
					int num5 = num2;
					if (num4 > num5)
					{
						break;
					}
					if (Operators.ConditionalCompareObjectEqual(DataGridView2.Rows[num3].Cells["COL_3"].Value, ".", TextCompare: false))
					{
						text2 = Conversions.ToString(Operators.ConcatenateObject(DataGridView2.Rows[num3].Cells["COL_1"].Value, DataGridView2.Rows[num3].Cells["COL_2"].Value));
						e.Graphics.DrawString(text2, new Font("Inconsolata ExtraBold", 11f, (FontStyle)1), Brushes.Black, 0f, (float)(120 + num * 16 + 10), new StringFormat((StringFormatFlags)8192));
					}
					else
					{
						text2 = Conversions.ToString(Operators.ConcatenateObject(DataGridView2.Rows[num3].Cells["COL_1"].Value, DataGridView2.Rows[num3].Cells["COL_2"].Value));
						e.Graphics.DrawString(text2, new Font("Inconsolata Condensed", 10f, (FontStyle)1), Brushes.Black, 0f, (float)(120 + num * 16 + 10), new StringFormat((StringFormatFlags)8192));
					}
					num++;
					num3++;
				}
				double num6 = 0.0;
				DataTable dataTable = new DataTable();
				MySqlDataAdapter val = new MySqlDataAdapter();
				dataTable.Clear();
				val = new MySqlDataAdapter("select sum(Total_NET) as n     from TABLE_VENTES_JOURNAL WHERE    Dates   between   ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '           and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')      ", Module1.cn_SQL);
				((DbDataAdapter)(object)val).Fill(dataTable);
				num6 = Conversions.ToDouble(Strings.FormatNumber(Conversion.Val(dataTable.Rows[0]["n"].ToString())));
				e.Graphics.DrawString("-----------------------------------------", new Font("Inconsolata Condensed", 11f, (FontStyle)0), Brushes.Black, 0f, (float)(DataGridView2.Rows.Count * 16 + 130), new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("TOTAL NET: " + Strings.RSet(Conversions.ToString(num6) + " DH", 12), new Font("Inconsolata ExtraBold", 16f, (FontStyle)1), Brushes.Black, 0f, (float)(DataGridView2.Rows.Count * 16 + 140), new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("-----------------------------------------", new Font("Inconsolata Condensed", 11f, (FontStyle)0), Brushes.Black, 0f, (float)(DataGridView2.Rows.Count * 16 + 160), new StringFormat((StringFormatFlags)8192));
				string text3 = "";
				int num7 = DataGridView3.RowCount - 1;
				int num8 = 0;
				while (true)
				{
					int num9 = num8;
					int num5 = num7;
					if (num9 > num5)
					{
						break;
					}
					text3 = text3 + DataGridView3.Rows[num8].Cells[0].Value.ToString() + Environment.NewLine;
					num8++;
				}
				e.Graphics.DrawString(text3, new Font("Inconsolata Condensed", 11f, (FontStyle)1), Brushes.Black, 0f, (float)(DataGridView2.Rows.Count * 16 + 170), new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"), new Font("Inconsolata Condensed", 8f, (FontStyle)1), Brushes.Black, Convert.ToSingle(130f - e.Graphics.MeasureString(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"), new Font("Inconsolata Condensed", 8f, (FontStyle)1)).Width / 2f), (float)(DataGridView2.Rows.Count * 16 + 170 + DataGridView3.Rows.Count * 16), new StringFormat((StringFormatFlags)8192));
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
		//IL_039e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a5: Expected Obj, but got Unknown
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected Obj, but got Unknown
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Expected Obj, but got Unknown
		//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e7: Expected Obj, but got Unknown
		try
		{
			if (Operators.CompareString(Combo_FIND.Text, "DATES", TextCompare: false) == 0)
			{
				DT.Clear();
				DA = new MySqlDataAdapter("select * from     TABLE_" + Label_TABLE.Text + "      Where       Dates   between   ' " + Strings.Format(DateTime1_FIND.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTime2_FIND.Value, "yyyy-MM-dd") + " '               order by   ID    desc ", Module1.cn_SQL);
				((DbDataAdapter)(object)DA).Fill(DT);
			}
			else if (Operators.CompareString(Text_FIND.Texts, "", TextCompare: false) != 0)
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
					DA = new MySqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat("select * from     TABLE_" + Label_TABLE.Text, "      Where            "), _sql), "            ("), Combo_FIND.Text), "  like  '%"), Text_FIND.Texts), "%'   )                                order by   ID    desc ")), Module1.cn_SQL);
					((DbDataAdapter)(object)DA).Fill(DT);
				}
				else if (Check_FIND_EXACTE.Checked)
				{
					DT.Clear();
					DA = new MySqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat("select * from     TABLE_" + Label_TABLE.Text, "      Where            "), _sql), "            ("), Combo_FIND.Text), "  like  '"), Text_FIND.Texts), "'     )                                order by   ID    desc ")), Module1.cn_SQL);
					((DbDataAdapter)(object)DA).Fill(DT);
				}
			}
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

	public void Picture_REFRESH_Click(object sender, EventArgs e)
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected Obj, but got Unknown
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected Obj, but got Unknown
		try
		{
			NewLateBinding.LateCall(sender, null, "Focus", new object[0], null, null, null, IgnoreReturn: true);
			Text_FIND.Texts = "";
			((Control)Text_FIND).Focus();
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
			((Control)Panel_DATES).Left = 127;
			((Control)Panel_DATES).Width = 713;
			Text_FIND.Texts = "*";
		}
		else
		{
			((Control)Panel_DATES).Visible = false;
			((Control)Panel_DATES).Left = 564;
			((Control)Panel_DATES).Width = 276;
			Text_FIND.Texts = "";
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

	private void Button94545_Click(object sender, EventArgs e)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected Obj, but got Unknown
		DataGridView1.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)1;
		DataGridViewTextBoxColumn val = new DataGridViewTextBoxColumn();
		((DataGridViewColumn)val).HeaderText = ListBox_COLUMNS.Text;
		((DataGridViewColumn)val).Name = ListBox_COLUMNS.Text;
		((DataGridViewColumn)val).DataPropertyName = ListBox_COLUMNS.Text;
		((DataGridViewColumn)val).Width = 150;
		val.SortMode = (DataGridViewColumnSortMode)2;
		DataGridView1.Columns.Insert(0, (DataGridViewColumn)(object)val);
	}

	private void Button187878_Click(object sender, EventArgs e)
	{
		((Control)Panel_COLUMNS).Visible = false;
	}

	private void Button_MARGE_Click(object sender, EventArgs e)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		((Form)MyProject.Forms.Form_3_VENTE_MARGE).ShowDialog();
	}

	private void Check_FIND_DATE_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
	{
	}
}
