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
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Bunifu.UI.WinForms;
using LOGICA.My;
using Microsoft.Reporting.WinForms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;
using ThoughtWorks.QRCode.Codec;

namespace LOGICA;

[DesignerGenerated]
public class FormDialog_DUPLICATA : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("DataGridView1")]
	private DataGridView _DataGridView1;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[AccessedThroughProperty("Text_PRINTER_SOLDER")]
	private TextBox _Text_PRINTER_SOLDER;

	[AccessedThroughProperty("Text_TOTAL_NET")]
	private Label _Text_TOTAL_NET;

	[AccessedThroughProperty("Panel_FONCTIONS")]
	private Panel _Panel_FONCTIONS;

	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	[AccessedThroughProperty("Panel2")]
	private Panel _Panel2;

	[AccessedThroughProperty("Label18")]
	private Label _Label18;

	[AccessedThroughProperty("DataGridView_MODE_P")]
	private DataGridView _DataGridView_MODE_P;

	[AccessedThroughProperty("MONTANT")]
	private DataGridViewTextBoxColumn _MONTANT;

	[AccessedThroughProperty("MODE_P")]
	private DataGridViewTextBoxColumn _MODE_P;

	[AccessedThroughProperty("DataGridView3")]
	private DataGridView _DataGridView3;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("Label_CLIENT")]
	private Label _Label_CLIENT;

	[AccessedThroughProperty("Label11")]
	private Label _Label11;

	[AccessedThroughProperty("Label10")]
	private Label _Label10;

	[AccessedThroughProperty("Label9")]
	private Label _Label9;

	[AccessedThroughProperty("Label_DATES")]
	private Label _Label_DATES;

	[AccessedThroughProperty("Label14")]
	private Label _Label14;

	[AccessedThroughProperty("Label_N_TICKET")]
	private Label _Label_N_TICKET;

	[AccessedThroughProperty("Label_CAISSIER")]
	private Label _Label_CAISSIER;

	[AccessedThroughProperty("Label_NBR_ARTICLES")]
	private Label _Label_NBR_ARTICLES;

	[AccessedThroughProperty("Label_OPERATION")]
	private Label _Label_OPERATION;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("Label_ID_CLIENT")]
	private Label _Label_ID_CLIENT;

	[AccessedThroughProperty("Text_pied_doc")]
	private TextBox _Text_pied_doc;

	[AccessedThroughProperty("Button_ARABE_80")]
	private Button _Button_ARABE_80;

	[AccessedThroughProperty("Button_ARABE_A5")]
	private Button _Button_ARABE_A5;

	[AccessedThroughProperty("Button_A5")]
	private Button _Button_A5;

	[AccessedThroughProperty("Button_A4")]
	private Button _Button_A4;

	[AccessedThroughProperty("Article")]
	private DataGridViewTextBoxColumn _Article;

	[AccessedThroughProperty("PRIX_V")]
	private DataGridViewTextBoxColumn _PRIX_V;

	[AccessedThroughProperty("Qté")]
	private DataGridViewTextBoxColumn _Qté;

	[AccessedThroughProperty("Total_NET")]
	private DataGridViewTextBoxColumn _Total_NET;

	[AccessedThroughProperty("Code")]
	private DataGridViewTextBoxColumn _Code;

	[AccessedThroughProperty("REMISE")]
	private DataGridViewTextBoxColumn _REMISE;

	[AccessedThroughProperty("CL_AR_3C")]
	private PrintDocument _CL_AR_3C;

	[AccessedThroughProperty("CL_FR_3C")]
	private PrintDocument _CL_FR_3C;

	[AccessedThroughProperty("BON_RETOUR")]
	private PrintDocument _BON_RETOUR;

	[AccessedThroughProperty("CL_AR_4C")]
	private PrintDocument _CL_AR_4C;

	[AccessedThroughProperty("CL_FR_2L")]
	private PrintDocument _CL_FR_2L;

	[AccessedThroughProperty("CL_FR_4C")]
	private PrintDocument _CL_FR_4C;

	[AccessedThroughProperty("Button_AUJOURDHUIT")]
	private Button _Button_AUJOURDHUIT;

	[AccessedThroughProperty("BunifuDatePicker2")]
	private BunifuDatePicker _BunifuDatePicker2;

	[AccessedThroughProperty("PictureBox3")]
	private PictureBox _PictureBox3;

	[AccessedThroughProperty("BunifuDatePicker1")]
	private BunifuDatePicker _BunifuDatePicker1;

	[AccessedThroughProperty("Button_PRECEDENT")]
	private Button _Button_PRECEDENT;

	[AccessedThroughProperty("Button_SUIVANT")]
	private Button _Button_SUIVANT;

	[AccessedThroughProperty("ID_TICKET")]
	private DataGridViewTextBoxColumn _ID_TICKET;

	[AccessedThroughProperty("DataGridViewTextBoxColumn6")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn6;

	[AccessedThroughProperty("Column1")]
	private DataGridViewTextBoxColumn _Column1;

	[AccessedThroughProperty("Column2")]
	private DataGridViewTextBoxColumn _Column2;

	[AccessedThroughProperty("Client")]
	private DataGridViewTextBoxColumn _Client;

	private QRCodeEncoder QREncoder;

	private Image QRimg;

	private Bitmap QRbitmap;

	private Bitmap barcodeImage;

	private DataTable dt_duplicata;

	private MySqlDataAdapter da_duplicata;

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

	private string _string;

	private int nbr_ligne_CL;

	private decimal _total_credit;

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

	internal virtual TextBox Text_PRINTER_SOLDER
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_PRINTER_SOLDER;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_PRINTER_SOLDER = value;
		}
	}

	internal virtual Label Text_TOTAL_NET
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_TOTAL_NET;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_TOTAL_NET = value;
		}
	}

	internal virtual Panel Panel_FONCTIONS
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel_FONCTIONS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			PaintEventHandler val = Panel_FONCTIONS_Paint;
			if (_Panel_FONCTIONS != null)
			{
				((Control)_Panel_FONCTIONS).Paint -= val;
			}
			_Panel_FONCTIONS = value;
			if (_Panel_FONCTIONS != null)
			{
				((Control)_Panel_FONCTIONS).Paint += val;
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

	internal virtual DataGridView DataGridView_MODE_P
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridView_MODE_P;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGridView_MODE_P = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn MONTANT
	{
		[DebuggerNonUserCode]
		get
		{
			return _MONTANT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_MONTANT = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn MODE_P
	{
		[DebuggerNonUserCode]
		get
		{
			return _MODE_P;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_MODE_P = value;
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
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			DataGridViewCellEventHandler val = DataGridView3_CellClick;
			DataGridViewCellEventHandler val2 = DataGridView3_CellContentClick;
			if (_DataGridView3 != null)
			{
				_DataGridView3.CellClick -= val;
				_DataGridView3.CellContentClick -= val2;
			}
			_DataGridView3 = value;
			if (_DataGridView3 != null)
			{
				_DataGridView3.CellClick += val;
				_DataGridView3.CellContentClick += val2;
			}
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

	internal virtual Label Label_CLIENT
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_CLIENT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_CLIENT = value;
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

	internal virtual Label Label_DATES
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_DATES;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_DATES = value;
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

	internal virtual Label Label_N_TICKET
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_N_TICKET;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_N_TICKET = value;
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

	internal virtual Label Label_NBR_ARTICLES
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_NBR_ARTICLES;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_NBR_ARTICLES = value;
		}
	}

	internal virtual Label Label_OPERATION
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_OPERATION;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_OPERATION = value;
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

	internal virtual Label Label_ID_CLIENT
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_ID_CLIENT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_ID_CLIENT = value;
		}
	}

	internal virtual TextBox Text_pied_doc
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_pied_doc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_pied_doc = value;
		}
	}

	internal virtual Button Button_ARABE_80
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_ARABE_80;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_ARABE_80_Click;
			if (_Button_ARABE_80 != null)
			{
				((Control)_Button_ARABE_80).Click -= eventHandler;
			}
			_Button_ARABE_80 = value;
			if (_Button_ARABE_80 != null)
			{
				((Control)_Button_ARABE_80).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button_ARABE_A5
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_ARABE_A5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_ARABE_A5_Click;
			if (_Button_ARABE_A5 != null)
			{
				((Control)_Button_ARABE_A5).Click -= eventHandler;
			}
			_Button_ARABE_A5 = value;
			if (_Button_ARABE_A5 != null)
			{
				((Control)_Button_ARABE_A5).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button_A5
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_A5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_A5_Click;
			if (_Button_A5 != null)
			{
				((Control)_Button_A5).Click -= eventHandler;
			}
			_Button_A5 = value;
			if (_Button_A5 != null)
			{
				((Control)_Button_A5).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button_A4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_A4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_A4_Click;
			if (_Button_A4 != null)
			{
				((Control)_Button_A4).Click -= eventHandler;
			}
			_Button_A4 = value;
			if (_Button_A4 != null)
			{
				((Control)_Button_A4).Click += eventHandler;
			}
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

	internal virtual DataGridViewTextBoxColumn REMISE
	{
		[DebuggerNonUserCode]
		get
		{
			return _REMISE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_REMISE = value;
		}
	}

	internal virtual PrintDocument CL_AR_3C
	{
		[DebuggerNonUserCode]
		get
		{
			return _CL_AR_3C;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			PrintPageEventHandler val = CL_AR_3C_PrintPage;
			if (_CL_AR_3C != null)
			{
				_CL_AR_3C.PrintPage -= val;
			}
			_CL_AR_3C = value;
			if (_CL_AR_3C != null)
			{
				_CL_AR_3C.PrintPage += val;
			}
		}
	}

	internal virtual PrintDocument CL_FR_3C
	{
		[DebuggerNonUserCode]
		get
		{
			return _CL_FR_3C;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			PrintPageEventHandler val = CL_FR_3C_PrintPage;
			if (_CL_FR_3C != null)
			{
				_CL_FR_3C.PrintPage -= val;
			}
			_CL_FR_3C = value;
			if (_CL_FR_3C != null)
			{
				_CL_FR_3C.PrintPage += val;
			}
		}
	}

	internal virtual PrintDocument BON_RETOUR
	{
		[DebuggerNonUserCode]
		get
		{
			return _BON_RETOUR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			PrintPageEventHandler val = BON_RETOUR_PrintPage;
			if (_BON_RETOUR != null)
			{
				_BON_RETOUR.PrintPage -= val;
			}
			_BON_RETOUR = value;
			if (_BON_RETOUR != null)
			{
				_BON_RETOUR.PrintPage += val;
			}
		}
	}

	internal virtual PrintDocument CL_AR_4C
	{
		[DebuggerNonUserCode]
		get
		{
			return _CL_AR_4C;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			PrintPageEventHandler val = CL_AR_4C_PrintPage;
			if (_CL_AR_4C != null)
			{
				_CL_AR_4C.PrintPage -= val;
			}
			_CL_AR_4C = value;
			if (_CL_AR_4C != null)
			{
				_CL_AR_4C.PrintPage += val;
			}
		}
	}

	internal virtual PrintDocument CL_FR_2L
	{
		[DebuggerNonUserCode]
		get
		{
			return _CL_FR_2L;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			PrintPageEventHandler val = CL_FR_2L_PrintPage;
			if (_CL_FR_2L != null)
			{
				_CL_FR_2L.PrintPage -= val;
			}
			_CL_FR_2L = value;
			if (_CL_FR_2L != null)
			{
				_CL_FR_2L.PrintPage += val;
			}
		}
	}

	internal virtual PrintDocument CL_FR_4C
	{
		[DebuggerNonUserCode]
		get
		{
			return _CL_FR_4C;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			PrintPageEventHandler val = CL_FR_4C_PrintPage;
			if (_CL_FR_4C != null)
			{
				_CL_FR_4C.PrintPage -= val;
			}
			_CL_FR_4C = value;
			if (_CL_FR_4C != null)
			{
				_CL_FR_4C.PrintPage += val;
			}
		}
	}

	internal virtual Button Button_AUJOURDHUIT
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_AUJOURDHUIT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_AUJOURDHUIT_Click;
			if (_Button_AUJOURDHUIT != null)
			{
				((Control)_Button_AUJOURDHUIT).Click -= eventHandler;
			}
			_Button_AUJOURDHUIT = value;
			if (_Button_AUJOURDHUIT != null)
			{
				((Control)_Button_AUJOURDHUIT).Click += eventHandler;
			}
		}
	}

	internal virtual BunifuDatePicker BunifuDatePicker2
	{
		[DebuggerNonUserCode]
		get
		{
			return _BunifuDatePicker2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = BunifuDatePicker_ValueChanged;
			if (_BunifuDatePicker2 != null)
			{
				((DateTimePicker)_BunifuDatePicker2).ValueChanged -= eventHandler;
			}
			_BunifuDatePicker2 = value;
			if (_BunifuDatePicker2 != null)
			{
				((DateTimePicker)_BunifuDatePicker2).ValueChanged += eventHandler;
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

	internal virtual BunifuDatePicker BunifuDatePicker1
	{
		[DebuggerNonUserCode]
		get
		{
			return _BunifuDatePicker1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = BunifuDatePicker_ValueChanged;
			if (_BunifuDatePicker1 != null)
			{
				((DateTimePicker)_BunifuDatePicker1).ValueChanged -= eventHandler;
			}
			_BunifuDatePicker1 = value;
			if (_BunifuDatePicker1 != null)
			{
				((DateTimePicker)_BunifuDatePicker1).ValueChanged += eventHandler;
			}
		}
	}

	internal virtual Button Button_PRECEDENT
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_PRECEDENT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_PRECEDENT_Click;
			if (_Button_PRECEDENT != null)
			{
				((Control)_Button_PRECEDENT).Click -= eventHandler;
			}
			_Button_PRECEDENT = value;
			if (_Button_PRECEDENT != null)
			{
				((Control)_Button_PRECEDENT).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button_SUIVANT
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_SUIVANT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_SUIVANT_Click;
			if (_Button_SUIVANT != null)
			{
				((Control)_Button_SUIVANT).Click -= eventHandler;
			}
			_Button_SUIVANT = value;
			if (_Button_SUIVANT != null)
			{
				((Control)_Button_SUIVANT).Click += eventHandler;
			}
		}
	}

	internal virtual DataGridViewTextBoxColumn ID_TICKET
	{
		[DebuggerNonUserCode]
		get
		{
			return _ID_TICKET;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ID_TICKET = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn6
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridViewTextBoxColumn6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGridViewTextBoxColumn6 = value;
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

	internal virtual DataGridViewTextBoxColumn Client
	{
		[DebuggerNonUserCode]
		get
		{
			return _Client;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Client = value;
		}
	}

	public FormDialog_DUPLICATA()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		((Control)this).KeyDown += me_KeyDown;
		((Form)this).Load += FormDialog_DUPLICATA_Load;
		__ENCAddToList(this);
		dt_duplicata = new DataTable();
		da_duplicata = new MySqlDataAdapter();
		prn = new RawPrinterHelper();
		_string = "";
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
		//IL_0025: Expected Obj, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected Obj, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected Obj, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected Obj, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected Obj, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected Obj, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected Obj, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected Obj, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected Obj, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected Obj, but got Unknown
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected Obj, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected Obj, but got Unknown
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected Obj, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected Obj, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected Obj, but got Unknown
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected Obj, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected Obj, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected Obj, but got Unknown
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected Obj, but got Unknown
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected Obj, but got Unknown
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected Obj, but got Unknown
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected Obj, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected Obj, but got Unknown
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected Obj, but got Unknown
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected Obj, but got Unknown
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected Obj, but got Unknown
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected Obj, but got Unknown
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected Obj, but got Unknown
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected Obj, but got Unknown
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Expected Obj, but got Unknown
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Expected Obj, but got Unknown
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Expected Obj, but got Unknown
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Expected Obj, but got Unknown
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected Obj, but got Unknown
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Expected Obj, but got Unknown
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Expected Obj, but got Unknown
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Expected Obj, but got Unknown
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Expected Obj, but got Unknown
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected Obj, but got Unknown
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Expected Obj, but got Unknown
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Expected Obj, but got Unknown
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Expected Obj, but got Unknown
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Expected Obj, but got Unknown
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Expected Obj, but got Unknown
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Expected Obj, but got Unknown
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Expected Obj, but got Unknown
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Expected Obj, but got Unknown
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Expected Obj, but got Unknown
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Expected Obj, but got Unknown
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Expected Obj, but got Unknown
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Expected Obj, but got Unknown
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Expected Obj, but got Unknown
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Expected Obj, but got Unknown
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Expected Obj, but got Unknown
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_0293: Expected Obj, but got Unknown
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Expected Obj, but got Unknown
		//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Expected Obj, but got Unknown
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Expected Obj, but got Unknown
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Expected Obj, but got Unknown
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cf: Expected Obj, but got Unknown
		//IL_0356: Unknown result type (might be due to invalid IL or missing references)
		//IL_0360: Expected Obj, but got Unknown
		//IL_04a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b3: Expected Obj, but got Unknown
		//IL_04d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e1: Expected Obj, but got Unknown
		//IL_0519: Unknown result type (might be due to invalid IL or missing references)
		//IL_051f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0635: Unknown result type (might be due to invalid IL or missing references)
		//IL_063f: Expected Obj, but got Unknown
		//IL_0707: Unknown result type (might be due to invalid IL or missing references)
		//IL_0711: Expected Obj, but got Unknown
		//IL_0b18: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bfe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c08: Expected Obj, but got Unknown
		//IL_0cca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd4: Expected Obj, but got Unknown
		//IL_1013: Unknown result type (might be due to invalid IL or missing references)
		//IL_101d: Expected Obj, but got Unknown
		//IL_10d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_10df: Expected Obj, but got Unknown
		//IL_119b: Unknown result type (might be due to invalid IL or missing references)
		//IL_11a5: Expected Obj, but got Unknown
		//IL_126e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1278: Expected Obj, but got Unknown
		//IL_132f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1339: Expected Obj, but got Unknown
		//IL_13cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_13d6: Expected Obj, but got Unknown
		//IL_1492: Unknown result type (might be due to invalid IL or missing references)
		//IL_149c: Expected Obj, but got Unknown
		//IL_1558: Unknown result type (might be due to invalid IL or missing references)
		//IL_1562: Expected Obj, but got Unknown
		//IL_161a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1624: Expected Obj, but got Unknown
		//IL_16dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_16e6: Expected Obj, but got Unknown
		//IL_1803: Unknown result type (might be due to invalid IL or missing references)
		//IL_180d: Expected Obj, but got Unknown
		//IL_18aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_18b4: Expected Obj, but got Unknown
		//IL_1ad4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ade: Expected Obj, but got Unknown
		//IL_1b89: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b93: Expected Obj, but got Unknown
		//IL_1c4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c55: Expected Obj, but got Unknown
		//IL_1d0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d17: Expected Obj, but got Unknown
		//IL_1dd3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ddd: Expected Obj, but got Unknown
		//IL_1ecb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ed5: Expected Obj, but got Unknown
		//IL_1f1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f24: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fdc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fe6: Expected Obj, but got Unknown
		//IL_202f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2035: Unknown result type (might be due to invalid IL or missing references)
		//IL_20ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_20f7: Expected Obj, but got Unknown
		//IL_2140: Unknown result type (might be due to invalid IL or missing references)
		//IL_2146: Unknown result type (might be due to invalid IL or missing references)
		//IL_21fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_2208: Expected Obj, but got Unknown
		//IL_2251: Unknown result type (might be due to invalid IL or missing references)
		//IL_2257: Unknown result type (might be due to invalid IL or missing references)
		//IL_22e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_22f2: Expected Obj, but got Unknown
		//IL_232a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2330: Unknown result type (might be due to invalid IL or missing references)
		//IL_2447: Unknown result type (might be due to invalid IL or missing references)
		//IL_2451: Expected Obj, but got Unknown
		//IL_2482: Unknown result type (might be due to invalid IL or missing references)
		//IL_248c: Expected Obj, but got Unknown
		//IL_254c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2556: Expected Obj, but got Unknown
		//IL_268e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2698: Expected Obj, but got Unknown
		//IL_26c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_26d3: Expected Obj, but got Unknown
		//IL_27a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_27aa: Expected Obj, but got Unknown
		//IL_27ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_27d8: Expected Obj, but got Unknown
		//IL_280a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2810: Unknown result type (might be due to invalid IL or missing references)
		//IL_28a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_28ab: Expected Obj, but got Unknown
		//IL_28cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_28d9: Expected Obj, but got Unknown
		//IL_290e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2914: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c11: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c1b: Expected Obj, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FormDialog_DUPLICATA));
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
		Text_TOTAL_NET = new Label();
		Text_PRINTER_SOLDER = new TextBox();
		Button2 = new Button();
		DataGridView1 = new DataGridView();
		Article = new DataGridViewTextBoxColumn();
		PRIX_V = new DataGridViewTextBoxColumn();
		Qté = new DataGridViewTextBoxColumn();
		Total_NET = new DataGridViewTextBoxColumn();
		Code = new DataGridViewTextBoxColumn();
		REMISE = new DataGridViewTextBoxColumn();
		Panel_FONCTIONS = new Panel();
		DataGridView3 = new DataGridView();
		Panel1 = new Panel();
		Label6 = new Label();
		Label_ID_CLIENT = new Label();
		Label_OPERATION = new Label();
		Label_N_TICKET = new Label();
		Text_pied_doc = new TextBox();
		Label_CAISSIER = new Label();
		Label_NBR_ARTICLES = new Label();
		Label10 = new Label();
		Label9 = new Label();
		Label_CLIENT = new Label();
		DataGridView_MODE_P = new DataGridView();
		MONTANT = new DataGridViewTextBoxColumn();
		MODE_P = new DataGridViewTextBoxColumn();
		Panel2 = new Panel();
		Label18 = new Label();
		Label7 = new Label();
		Label11 = new Label();
		Label_DATES = new Label();
		Label14 = new Label();
		Button_ARABE_80 = new Button();
		Button_ARABE_A5 = new Button();
		Button_A5 = new Button();
		Button_A4 = new Button();
		CL_AR_3C = new PrintDocument();
		CL_FR_3C = new PrintDocument();
		BON_RETOUR = new PrintDocument();
		CL_AR_4C = new PrintDocument();
		CL_FR_2L = new PrintDocument();
		CL_FR_4C = new PrintDocument();
		Button_AUJOURDHUIT = new Button();
		BunifuDatePicker2 = new BunifuDatePicker();
		PictureBox3 = new PictureBox();
		BunifuDatePicker1 = new BunifuDatePicker();
		Button_PRECEDENT = new Button();
		Button_SUIVANT = new Button();
		ID_TICKET = new DataGridViewTextBoxColumn();
		DataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
		Column1 = new DataGridViewTextBoxColumn();
		Column2 = new DataGridViewTextBoxColumn();
		Client = new DataGridViewTextBoxColumn();
		((ISupportInitialize)DataGridView1).BeginInit();
		((Control)Panel_FONCTIONS).SuspendLayout();
		((ISupportInitialize)DataGridView3).BeginInit();
		((Control)Panel1).SuspendLayout();
		((ISupportInitialize)DataGridView_MODE_P).BeginInit();
		((Control)Panel2).SuspendLayout();
		((ISupportInitialize)PictureBox3).BeginInit();
		((Control)this).SuspendLayout();
		((Control)Text_TOTAL_NET).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Text_TOTAL_NET).Font = new Font("Segoe UI", 26f, (FontStyle)1);
		((Control)Text_TOTAL_NET).ForeColor = Color.White;
		Label text_TOTAL_NET = Text_TOTAL_NET;
		Point location = new Point(185, 12);
		((Control)text_TOTAL_NET).Location = location;
		((Control)Text_TOTAL_NET).Name = "Text_TOTAL_NET";
		Label text_TOTAL_NET2 = Text_TOTAL_NET;
		Size size = new Size(325, 43);
		((Control)text_TOTAL_NET2).Size = size;
		((Control)Text_TOTAL_NET).TabIndex = 986;
		Text_TOTAL_NET.TextAlign = (ContentAlignment)16;
		TextBox text_PRINTER_SOLDER = Text_PRINTER_SOLDER;
		location = new Point(243, 86);
		((Control)text_PRINTER_SOLDER).Location = location;
		((Control)Text_PRINTER_SOLDER).Name = "Text_PRINTER_SOLDER";
		TextBox text_PRINTER_SOLDER2 = Text_PRINTER_SOLDER;
		size = new Size(107, 20);
		((Control)text_PRINTER_SOLDER2).Size = size;
		((Control)Text_PRINTER_SOLDER).TabIndex = 979;
		Text_PRINTER_SOLDER.Text = "Text_PRINTER_SOLDER";
		((Control)Text_PRINTER_SOLDER).Visible = false;
		((ButtonBase)Button2).BackColor = Color.White;
		((Control)Button2).Cursor = Cursors.Hand;
		((ButtonBase)Button2).FlatAppearance.BorderColor = Color.RoyalBlue;
		((ButtonBase)Button2).FlatStyle = (FlatStyle)0;
		((Control)Button2).Font = new Font("Tahoma", 12.25f, (FontStyle)1);
		((Control)Button2).ForeColor = Color.RoyalBlue;
		((ButtonBase)Button2).Image = (Image)componentResourceManager.GetObject("Button2.Image");
		((ButtonBase)Button2).ImageAlign = (ContentAlignment)16;
		Button button = Button2;
		location = new Point(769, 589);
		((Control)button).Location = location;
		Button button2 = Button2;
		Padding margin = new Padding(0);
		((Control)button2).Margin = margin;
		((Control)Button2).Name = "Button2";
		Button button3 = Button2;
		size = new Size(150, 45);
		((Control)button3).Size = size;
		((Control)Button2).TabIndex = 802;
		((ButtonBase)Button2).Text = "  Imprimer";
		((ButtonBase)Button2).TextImageRelation = (TextImageRelation)4;
		((ButtonBase)Button2).UseVisualStyleBackColor = false;
		DataGridView1.AllowUserToAddRows = false;
		DataGridView1.AllowUserToDeleteRows = false;
		DataGridView1.AllowUserToResizeColumns = false;
		DataGridView1.AllowUserToResizeRows = false;
		DataGridView1.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)16;
		DataGridView1.BackgroundColor = Color.White;
		DataGridView1.BorderStyle = (BorderStyle)0;
		DataGridView1.CellBorderStyle = (DataGridViewCellBorderStyle)5;
		DataGridView1.ColumnHeadersBorderStyle = (DataGridViewHeaderBorderStyle)1;
		val.Alignment = (DataGridViewContentAlignment)16;
		val.BackColor = Color.FromArgb(22, 106, 238);
		val.Font = new Font("Tahoma", 9f, (FontStyle)1);
		val.ForeColor = Color.White;
		val.SelectionBackColor = SystemColors.Highlight;
		val.SelectionForeColor = SystemColors.HighlightText;
		val.WrapMode = (DataGridViewTriState)1;
		DataGridView1.ColumnHeadersDefaultCellStyle = val;
		DataGridView1.ColumnHeadersHeight = 30;
		DataGridView1.Columns.AddRange(new DataGridViewColumn[6]
		{
			(DataGridViewColumn)Article,
			(DataGridViewColumn)PRIX_V,
			(DataGridViewColumn)Qté,
			(DataGridViewColumn)Total_NET,
			(DataGridViewColumn)Code,
			(DataGridViewColumn)REMISE
		});
		val2.Alignment = (DataGridViewContentAlignment)16;
		val2.BackColor = SystemColors.Window;
		val2.Font = new Font("Calibri", 12f);
		val2.ForeColor = SystemColors.ControlText;
		val2.SelectionBackColor = SystemColors.Highlight;
		val2.SelectionForeColor = SystemColors.HighlightText;
		val2.WrapMode = (DataGridViewTriState)2;
		DataGridView1.DefaultCellStyle = val2;
		((Control)DataGridView1).Dock = (DockStyle)1;
		DataGridView1.EditMode = (DataGridViewEditMode)4;
		DataGridView dataGridView = DataGridView1;
		location = new Point(0, 0);
		((Control)dataGridView).Location = location;
		((Control)DataGridView1).Name = "DataGridView1";
		DataGridView1.ReadOnly = true;
		DataGridView1.RowHeadersVisible = false;
		DataGridView1.RowHeadersWidth = 11;
		DataGridView1.SelectionMode = (DataGridViewSelectionMode)1;
		DataGridView dataGridView2 = DataGridView1;
		size = new Size(531, 306);
		((Control)dataGridView2).Size = size;
		((Control)DataGridView1).TabIndex = 801;
		((DataGridViewColumn)Article).DataPropertyName = "Article";
		((DataGridViewColumn)Article).HeaderText = "Article";
		((DataGridViewColumn)Article).Name = "Article";
		((DataGridViewColumn)Article).ReadOnly = true;
		((DataGridViewColumn)Article).Resizable = (DataGridViewTriState)1;
		Article.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)PRIX_V).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)PRIX_V).DataPropertyName = "PRIX_V";
		val3.Format = "N2";
		val3.NullValue = null;
		((DataGridViewColumn)PRIX_V).DefaultCellStyle = val3;
		((DataGridViewColumn)PRIX_V).HeaderText = "PRIX_V";
		((DataGridViewColumn)PRIX_V).Name = "PRIX_V";
		((DataGridViewColumn)PRIX_V).ReadOnly = true;
		PRIX_V.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)PRIX_V).Width = 60;
		((DataGridViewColumn)Qté).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)Qté).DataPropertyName = "Qté";
		val4.NullValue = null;
		((DataGridViewColumn)Qté).DefaultCellStyle = val4;
		((DataGridViewColumn)Qté).HeaderText = "Qté";
		((DataGridViewColumn)Qté).Name = "Qté";
		((DataGridViewColumn)Qté).ReadOnly = true;
		Qté.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)Qté).Width = 50;
		((DataGridViewColumn)Total_NET).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)Total_NET).DataPropertyName = "Total_NET";
		val5.Format = "N2";
		val5.NullValue = null;
		((DataGridViewColumn)Total_NET).DefaultCellStyle = val5;
		((DataGridViewColumn)Total_NET).HeaderText = "Total_NET";
		((DataGridViewColumn)Total_NET).Name = "Total_NET";
		((DataGridViewColumn)Total_NET).ReadOnly = true;
		Total_NET.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)Total_NET).Width = 80;
		((DataGridViewColumn)Code).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)Code).DataPropertyName = "Code";
		((DataGridViewColumn)Code).HeaderText = "Code";
		((DataGridViewColumn)Code).MinimumWidth = 2;
		((DataGridViewColumn)Code).Name = "Code";
		((DataGridViewColumn)Code).ReadOnly = true;
		Code.SortMode = (DataGridViewColumnSortMode)2;
		((DataGridViewColumn)Code).Width = 2;
		((DataGridViewColumn)REMISE).DataPropertyName = "REMISE";
		((DataGridViewColumn)REMISE).HeaderText = "REMISE";
		((DataGridViewColumn)REMISE).Name = "REMISE";
		((DataGridViewColumn)REMISE).ReadOnly = true;
		((DataGridViewColumn)REMISE).Visible = false;
		((Control)Panel_FONCTIONS).BackColor = Color.FromArgb(22, 106, 238);
		Panel_FONCTIONS.BorderStyle = (BorderStyle)1;
		((Control)Panel_FONCTIONS).Controls.Add((Control)(object)DataGridView3);
		Panel panel_FONCTIONS = Panel_FONCTIONS;
		location = new Point(9, 82);
		((Control)panel_FONCTIONS).Location = location;
		((Control)Panel_FONCTIONS).Name = "Panel_FONCTIONS";
		Panel panel_FONCTIONS2 = Panel_FONCTIONS;
		margin = new Padding(2);
		((Control)panel_FONCTIONS2).Padding = margin;
		Panel panel_FONCTIONS3 = Panel_FONCTIONS;
		size = new Size(371, 549);
		((Control)panel_FONCTIONS3).Size = size;
		((Control)Panel_FONCTIONS).TabIndex = 1023;
		DataGridView3.AllowUserToAddRows = false;
		DataGridView3.AllowUserToDeleteRows = false;
		DataGridView3.AllowUserToResizeColumns = false;
		DataGridView3.AllowUserToResizeRows = false;
		DataGridView3.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)16;
		DataGridView3.BackgroundColor = Color.White;
		DataGridView3.BorderStyle = (BorderStyle)0;
		DataGridView3.CellBorderStyle = (DataGridViewCellBorderStyle)5;
		DataGridView3.ColumnHeadersBorderStyle = (DataGridViewHeaderBorderStyle)1;
		val6.Alignment = (DataGridViewContentAlignment)16;
		val6.BackColor = Color.FromArgb(22, 106, 238);
		val6.Font = new Font("Tahoma", 9f, (FontStyle)1);
		val6.ForeColor = Color.White;
		val6.SelectionBackColor = SystemColors.Highlight;
		val6.SelectionForeColor = SystemColors.HighlightText;
		val6.WrapMode = (DataGridViewTriState)1;
		DataGridView3.ColumnHeadersDefaultCellStyle = val6;
		DataGridView3.ColumnHeadersHeight = 30;
		DataGridView3.Columns.AddRange(new DataGridViewColumn[5]
		{
			(DataGridViewColumn)ID_TICKET,
			(DataGridViewColumn)DataGridViewTextBoxColumn6,
			(DataGridViewColumn)Column1,
			(DataGridViewColumn)Column2,
			(DataGridViewColumn)Client
		});
		val7.Alignment = (DataGridViewContentAlignment)16;
		val7.BackColor = SystemColors.Window;
		val7.Font = new Font("Calibri", 12f);
		val7.ForeColor = SystemColors.ControlText;
		val7.SelectionBackColor = SystemColors.Highlight;
		val7.SelectionForeColor = SystemColors.HighlightText;
		val7.WrapMode = (DataGridViewTriState)2;
		DataGridView3.DefaultCellStyle = val7;
		((Control)DataGridView3).Dock = (DockStyle)5;
		DataGridView3.EditMode = (DataGridViewEditMode)4;
		DataGridView3.EnableHeadersVisualStyles = false;
		DataGridView dataGridView3 = DataGridView3;
		location = new Point(2, 2);
		((Control)dataGridView3).Location = location;
		DataGridView3.MultiSelect = false;
		((Control)DataGridView3).Name = "DataGridView3";
		DataGridView3.ReadOnly = true;
		DataGridView3.RowHeadersVisible = false;
		DataGridView3.RowHeadersWidth = 11;
		DataGridView3.SelectionMode = (DataGridViewSelectionMode)1;
		DataGridView dataGridView4 = DataGridView3;
		size = new Size(365, 543);
		((Control)dataGridView4).Size = size;
		((Control)DataGridView3).TabIndex = 1037;
		((Control)Panel1).BackColor = Color.White;
		Panel1.BorderStyle = (BorderStyle)1;
		((Control)Panel1).Controls.Add((Control)(object)Label6);
		((Control)Panel1).Controls.Add((Control)(object)Label_ID_CLIENT);
		((Control)Panel1).Controls.Add((Control)(object)Label_OPERATION);
		((Control)Panel1).Controls.Add((Control)(object)Label_N_TICKET);
		((Control)Panel1).Controls.Add((Control)(object)Text_PRINTER_SOLDER);
		((Control)Panel1).Controls.Add((Control)(object)Text_pied_doc);
		((Control)Panel1).Controls.Add((Control)(object)Label_CAISSIER);
		((Control)Panel1).Controls.Add((Control)(object)Label_NBR_ARTICLES);
		((Control)Panel1).Controls.Add((Control)(object)Label10);
		((Control)Panel1).Controls.Add((Control)(object)Label9);
		((Control)Panel1).Controls.Add((Control)(object)Label_CLIENT);
		((Control)Panel1).Controls.Add((Control)(object)DataGridView_MODE_P);
		((Control)Panel1).Controls.Add((Control)(object)DataGridView1);
		((Control)Panel1).Controls.Add((Control)(object)Panel2);
		((Control)Panel1).Controls.Add((Control)(object)Label7);
		((Control)Panel1).Controls.Add((Control)(object)Label11);
		((Control)Panel1).Controls.Add((Control)(object)Label_DATES);
		((Control)Panel1).Controls.Add((Control)(object)Label14);
		Panel panel = Panel1;
		location = new Point(386, 82);
		((Control)panel).Location = location;
		((Control)Panel1).Name = "Panel1";
		Panel panel2 = Panel1;
		size = new Size(533, 504);
		((Control)panel2).Size = size;
		((Control)Panel1).TabIndex = 1024;
		((Control)Label6).BackColor = Color.Transparent;
		((Control)Label6).Font = new Font("Inconsolata", 9f, (FontStyle)1);
		((Control)Label6).ForeColor = Color.Black;
		Label6.ImeMode = (ImeMode)0;
		Label label = Label6;
		location = new Point(3, 396);
		((Control)label).Location = location;
		((Control)Label6).Name = "Label6";
		Label label2 = Label6;
		size = new Size(96, 14);
		((Control)label2).Size = size;
		((Control)Label6).TabIndex = 1047;
		Label6.Text = "* ID Client   :";
		Label6.TextAlign = (ContentAlignment)16;
		((Control)Label_ID_CLIENT).BackColor = Color.Transparent;
		((Control)Label_ID_CLIENT).Font = new Font("Inconsolata", 9f, (FontStyle)1);
		((Control)Label_ID_CLIENT).ForeColor = Color.Black;
		Label_ID_CLIENT.ImeMode = (ImeMode)0;
		Label label_ID_CLIENT = Label_ID_CLIENT;
		location = new Point(100, 396);
		((Control)label_ID_CLIENT).Location = location;
		((Control)Label_ID_CLIENT).Name = "Label_ID_CLIENT";
		Label label_ID_CLIENT2 = Label_ID_CLIENT;
		size = new Size(236, 14);
		((Control)label_ID_CLIENT2).Size = size;
		((Control)Label_ID_CLIENT).TabIndex = 1046;
		Label_ID_CLIENT.Text = "-";
		Label_ID_CLIENT.TextAlign = (ContentAlignment)16;
		((Control)Label_OPERATION).BackColor = Color.Transparent;
		((Control)Label_OPERATION).Font = new Font("Inconsolata", 9f, (FontStyle)1);
		((Control)Label_OPERATION).ForeColor = Color.Black;
		Label_OPERATION.ImeMode = (ImeMode)0;
		Label label_OPERATION = Label_OPERATION;
		location = new Point(400, 428);
		((Control)label_OPERATION).Location = location;
		((Control)Label_OPERATION).Name = "Label_OPERATION";
		Label label_OPERATION2 = Label_OPERATION;
		size = new Size(88, 26);
		((Control)label_OPERATION2).Size = size;
		((Control)Label_OPERATION).TabIndex = 1045;
		Label_OPERATION.Text = "-";
		Label_OPERATION.TextAlign = (ContentAlignment)16;
		((Control)Label_OPERATION).Visible = false;
		((Control)Label_N_TICKET).BackColor = Color.Transparent;
		((Control)Label_N_TICKET).Font = new Font("Inconsolata", 9f, (FontStyle)1);
		((Control)Label_N_TICKET).ForeColor = Color.Black;
		Label_N_TICKET.ImeMode = (ImeMode)0;
		Label label_N_TICKET = Label_N_TICKET;
		location = new Point(100, 462);
		((Control)label_N_TICKET).Location = location;
		((Control)Label_N_TICKET).Name = "Label_N_TICKET";
		Label label_N_TICKET2 = Label_N_TICKET;
		size = new Size(236, 14);
		((Control)label_N_TICKET2).Size = size;
		((Control)Label_N_TICKET).TabIndex = 1042;
		Label_N_TICKET.Text = "-";
		Label_N_TICKET.TextAlign = (ContentAlignment)16;
		((TextBoxBase)Text_pied_doc).BorderStyle = (BorderStyle)1;
		((Control)Text_pied_doc).Font = new Font("Microsoft Sans Serif", 10f);
		TextBox text_pied_doc = Text_pied_doc;
		location = new Point(120, 85);
		((Control)text_pied_doc).Location = location;
		Text_pied_doc.Multiline = true;
		((Control)Text_pied_doc).Name = "Text_pied_doc";
		TextBox text_pied_doc2 = Text_pied_doc;
		size = new Size(94, 31);
		((Control)text_pied_doc2).Size = size;
		((Control)Text_pied_doc).TabIndex = 1064;
		((Control)Text_pied_doc).Visible = false;
		((Control)Label_CAISSIER).BackColor = Color.Transparent;
		((Control)Label_CAISSIER).Font = new Font("Inconsolata", 9f, (FontStyle)1);
		((Control)Label_CAISSIER).ForeColor = Color.Black;
		Label_CAISSIER.ImeMode = (ImeMode)0;
		Label label_CAISSIER = Label_CAISSIER;
		location = new Point(100, 440);
		((Control)label_CAISSIER).Location = location;
		((Control)Label_CAISSIER).Name = "Label_CAISSIER";
		Label label_CAISSIER2 = Label_CAISSIER;
		size = new Size(236, 14);
		((Control)label_CAISSIER2).Size = size;
		((Control)Label_CAISSIER).TabIndex = 1041;
		Label_CAISSIER.Text = "-";
		Label_CAISSIER.TextAlign = (ContentAlignment)16;
		((Control)Label_NBR_ARTICLES).BackColor = Color.Transparent;
		((Control)Label_NBR_ARTICLES).Font = new Font("Inconsolata", 9f, (FontStyle)1);
		((Control)Label_NBR_ARTICLES).ForeColor = Color.Black;
		Label_NBR_ARTICLES.ImeMode = (ImeMode)0;
		Label label_NBR_ARTICLES = Label_NBR_ARTICLES;
		location = new Point(100, 374);
		((Control)label_NBR_ARTICLES).Location = location;
		((Control)Label_NBR_ARTICLES).Name = "Label_NBR_ARTICLES";
		Label label_NBR_ARTICLES2 = Label_NBR_ARTICLES;
		size = new Size(236, 14);
		((Control)label_NBR_ARTICLES2).Size = size;
		((Control)Label_NBR_ARTICLES).TabIndex = 1040;
		Label_NBR_ARTICLES.Text = "-";
		Label_NBR_ARTICLES.TextAlign = (ContentAlignment)16;
		((Control)Label10).BackColor = Color.Transparent;
		((Control)Label10).Font = new Font("Inconsolata", 9f, (FontStyle)1);
		((Control)Label10).ForeColor = Color.Black;
		Label10.ImeMode = (ImeMode)0;
		Label label3 = Label10;
		location = new Point(3, 440);
		((Control)label3).Location = location;
		((Control)Label10).Name = "Label10";
		Label label4 = Label10;
		size = new Size(96, 14);
		((Control)label4).Size = size;
		((Control)Label10).TabIndex = 1037;
		Label10.Text = "* Caissier    :";
		Label10.TextAlign = (ContentAlignment)16;
		((Control)Label9).BackColor = Color.Transparent;
		((Control)Label9).Font = new Font("Inconsolata", 9f, (FontStyle)1);
		((Control)Label9).ForeColor = Color.Black;
		Label9.ImeMode = (ImeMode)0;
		Label label5 = Label9;
		location = new Point(3, 418);
		((Control)label5).Location = location;
		((Control)Label9).Name = "Label9";
		Label label6 = Label9;
		size = new Size(96, 14);
		((Control)label6).Size = size;
		((Control)Label9).TabIndex = 1036;
		Label9.Text = "* Client      :";
		Label9.TextAlign = (ContentAlignment)16;
		((Control)Label_CLIENT).BackColor = Color.Transparent;
		((Control)Label_CLIENT).Font = new Font("Inconsolata", 9f, (FontStyle)1);
		((Control)Label_CLIENT).ForeColor = Color.Black;
		Label_CLIENT.ImeMode = (ImeMode)0;
		Label label_CLIENT = Label_CLIENT;
		location = new Point(100, 418);
		((Control)label_CLIENT).Location = location;
		((Control)Label_CLIENT).Name = "Label_CLIENT";
		Label label_CLIENT2 = Label_CLIENT;
		size = new Size(236, 14);
		((Control)label_CLIENT2).Size = size;
		((Control)Label_CLIENT).TabIndex = 1032;
		Label_CLIENT.Text = "-";
		Label_CLIENT.TextAlign = (ContentAlignment)16;
		DataGridView_MODE_P.AllowUserToAddRows = false;
		DataGridView_MODE_P.AllowUserToDeleteRows = false;
		DataGridView_MODE_P.AllowUserToResizeColumns = false;
		DataGridView_MODE_P.AllowUserToResizeRows = false;
		DataGridView_MODE_P.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)16;
		DataGridView_MODE_P.BackgroundColor = Color.White;
		DataGridView_MODE_P.BorderStyle = (BorderStyle)0;
		val8.Alignment = (DataGridViewContentAlignment)16;
		val8.BackColor = SystemColors.Control;
		val8.Font = new Font("Tahoma", 8f);
		val8.ForeColor = SystemColors.WindowText;
		val8.SelectionBackColor = SystemColors.Highlight;
		val8.SelectionForeColor = SystemColors.HighlightText;
		val8.WrapMode = (DataGridViewTriState)1;
		DataGridView_MODE_P.ColumnHeadersDefaultCellStyle = val8;
		DataGridView_MODE_P.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		DataGridView_MODE_P.Columns.AddRange(new DataGridViewColumn[2]
		{
			(DataGridViewColumn)MONTANT,
			(DataGridViewColumn)MODE_P
		});
		val9.Alignment = (DataGridViewContentAlignment)16;
		val9.BackColor = SystemColors.Window;
		val9.Font = new Font("Arial Narrow", 10f);
		val9.ForeColor = SystemColors.ControlText;
		val9.SelectionBackColor = SystemColors.Highlight;
		val9.SelectionForeColor = SystemColors.HighlightText;
		val9.WrapMode = (DataGridViewTriState)2;
		DataGridView_MODE_P.DefaultCellStyle = val9;
		DataGridView_MODE_P.EnableHeadersVisualStyles = false;
		DataGridView dataGridView_MODE_P = DataGridView_MODE_P;
		location = new Point(382, 375);
		((Control)dataGridView_MODE_P).Location = location;
		((Control)DataGridView_MODE_P).Name = "DataGridView_MODE_P";
		DataGridView_MODE_P.ReadOnly = true;
		DataGridView_MODE_P.RowHeadersVisible = false;
		DataGridView_MODE_P.RowHeadersWidth = 11;
		DataGridView_MODE_P.SelectionMode = (DataGridViewSelectionMode)1;
		DataGridView dataGridView_MODE_P2 = DataGridView_MODE_P;
		size = new Size(147, 125);
		((Control)dataGridView_MODE_P2).Size = size;
		((Control)DataGridView_MODE_P).TabIndex = 985;
		((DataGridViewColumn)MONTANT).DataPropertyName = "MONTANT";
		((DataGridViewColumn)MONTANT).HeaderText = "MONTANT";
		((DataGridViewColumn)MONTANT).Name = "MONTANT";
		((DataGridViewColumn)MONTANT).ReadOnly = true;
		((DataGridViewColumn)MODE_P).DataPropertyName = "MODE_P";
		((DataGridViewColumn)MODE_P).HeaderText = "MODE_P";
		((DataGridViewColumn)MODE_P).Name = "MODE_P";
		((DataGridViewColumn)MODE_P).ReadOnly = true;
		((Control)Panel2).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Panel2).Controls.Add((Control)(object)Label18);
		((Control)Panel2).Controls.Add((Control)(object)Text_TOTAL_NET);
		Panel panel3 = Panel2;
		location = new Point(2, 311);
		((Control)panel3).Location = location;
		((Control)Panel2).Name = "Panel2";
		Panel panel4 = Panel2;
		size = new Size(527, 60);
		((Control)panel4).Size = size;
		((Control)Panel2).TabIndex = 1031;
		((Control)Label18).BackColor = Color.Transparent;
		((Control)Label18).Font = new Font("Segoe UI", 20f, (FontStyle)1);
		((Control)Label18).ForeColor = Color.White;
		Label label7 = Label18;
		location = new Point(5, 15);
		((Control)label7).Location = location;
		((Control)Label18).Name = "Label18";
		Label label8 = Label18;
		size = new Size(172, 30);
		((Control)label8).Size = size;
		((Control)Label18).TabIndex = 689;
		Label18.Text = "TOTAL NET :";
		Label18.TextAlign = (ContentAlignment)16;
		((Control)Label7).BackColor = Color.Transparent;
		((Control)Label7).Font = new Font("Inconsolata", 9f, (FontStyle)1);
		((Control)Label7).ForeColor = Color.Black;
		Label7.ImeMode = (ImeMode)0;
		Label label9 = Label7;
		location = new Point(3, 374);
		((Control)label9).Location = location;
		((Control)Label7).Name = "Label7";
		Label label10 = Label7;
		size = new Size(96, 14);
		((Control)label10).Size = size;
		((Control)Label7).TabIndex = 1035;
		Label7.Text = "* Nbr Articles:";
		Label7.TextAlign = (ContentAlignment)16;
		((Control)Label11).BackColor = Color.Transparent;
		((Control)Label11).Font = new Font("Inconsolata", 9f, (FontStyle)1);
		((Control)Label11).ForeColor = Color.Black;
		Label11.ImeMode = (ImeMode)0;
		Label label11 = Label11;
		location = new Point(3, 462);
		((Control)label11).Location = location;
		((Control)Label11).Name = "Label11";
		Label label12 = Label11;
		size = new Size(96, 14);
		((Control)label12).Size = size;
		((Control)Label11).TabIndex = 1038;
		Label11.Text = "* N° Ticket   :";
		Label11.TextAlign = (ContentAlignment)16;
		((Control)Label_DATES).BackColor = Color.Transparent;
		((Control)Label_DATES).Font = new Font("Inconsolata", 9f, (FontStyle)1);
		((Control)Label_DATES).ForeColor = Color.Black;
		Label_DATES.ImeMode = (ImeMode)0;
		Label label_DATES = Label_DATES;
		location = new Point(100, 484);
		((Control)label_DATES).Location = location;
		((Control)Label_DATES).Name = "Label_DATES";
		Label label_DATES2 = Label_DATES;
		size = new Size(236, 14);
		((Control)label_DATES2).Size = size;
		((Control)Label_DATES).TabIndex = 1044;
		Label_DATES.Text = "-";
		Label_DATES.TextAlign = (ContentAlignment)16;
		((Control)Label14).BackColor = Color.Transparent;
		((Control)Label14).Font = new Font("Inconsolata", 9f, (FontStyle)1);
		((Control)Label14).ForeColor = Color.Black;
		Label14.ImeMode = (ImeMode)0;
		Label label13 = Label14;
		location = new Point(3, 484);
		((Control)label13).Location = location;
		((Control)Label14).Name = "Label14";
		Label label14 = Label14;
		size = new Size(96, 14);
		((Control)label14).Size = size;
		((Control)Label14).TabIndex = 1043;
		Label14.Text = "* Date        :";
		Label14.TextAlign = (ContentAlignment)16;
		((ButtonBase)Button_ARABE_80).BackColor = Color.White;
		((Control)Button_ARABE_80).Cursor = Cursors.Hand;
		((ButtonBase)Button_ARABE_80).FlatAppearance.BorderColor = Color.RoyalBlue;
		((ButtonBase)Button_ARABE_80).FlatStyle = (FlatStyle)0;
		((Control)Button_ARABE_80).Font = new Font("Calibri", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Button_ARABE_80).ForeColor = Color.RoyalBlue;
		((ButtonBase)Button_ARABE_80).ImageAlign = (ContentAlignment)16;
		Button button_ARABE_ = Button_ARABE_80;
		location = new Point(665, 589);
		((Control)button_ARABE_).Location = location;
		Button button_ARABE_2 = Button_ARABE_80;
		margin = new Padding(0);
		((Control)button_ARABE_2).Margin = margin;
		((Control)Button_ARABE_80).Name = "Button_ARABE_80";
		Button button_ARABE_3 = Button_ARABE_80;
		size = new Size(85, 45);
		((Control)button_ARABE_3).Size = size;
		((Control)Button_ARABE_80).TabIndex = 1070;
		((ButtonBase)Button_ARABE_80).Text = "Arabe 80";
		((ButtonBase)Button_ARABE_80).UseVisualStyleBackColor = false;
		((ButtonBase)Button_ARABE_A5).BackColor = Color.White;
		((Control)Button_ARABE_A5).Cursor = Cursors.Hand;
		((ButtonBase)Button_ARABE_A5).FlatAppearance.BorderColor = Color.RoyalBlue;
		((ButtonBase)Button_ARABE_A5).FlatStyle = (FlatStyle)0;
		((Control)Button_ARABE_A5).Font = new Font("Calibri", 12f, (FontStyle)1);
		((Control)Button_ARABE_A5).ForeColor = Color.RoyalBlue;
		((ButtonBase)Button_ARABE_A5).ImageAlign = (ContentAlignment)16;
		Button button_ARABE_A = Button_ARABE_A5;
		location = new Point(572, 589);
		((Control)button_ARABE_A).Location = location;
		Button button_ARABE_A2 = Button_ARABE_A5;
		margin = new Padding(0);
		((Control)button_ARABE_A2).Margin = margin;
		((Control)Button_ARABE_A5).Name = "Button_ARABE_A5";
		Button button_ARABE_A3 = Button_ARABE_A5;
		size = new Size(85, 45);
		((Control)button_ARABE_A3).Size = size;
		((Control)Button_ARABE_A5).TabIndex = 1069;
		((ButtonBase)Button_ARABE_A5).Text = "Arabe A5";
		((ButtonBase)Button_ARABE_A5).UseVisualStyleBackColor = false;
		((ButtonBase)Button_A5).BackColor = Color.White;
		((Control)Button_A5).Cursor = Cursors.Hand;
		((ButtonBase)Button_A5).FlatAppearance.BorderColor = Color.RoyalBlue;
		((ButtonBase)Button_A5).FlatStyle = (FlatStyle)0;
		((Control)Button_A5).Font = new Font("Tahoma", 12.25f, (FontStyle)1);
		((Control)Button_A5).ForeColor = Color.RoyalBlue;
		((ButtonBase)Button_A5).ImageAlign = (ContentAlignment)16;
		Button button_A = Button_A5;
		location = new Point(479, 589);
		((Control)button_A).Location = location;
		Button button_A2 = Button_A5;
		margin = new Padding(0);
		((Control)button_A2).Margin = margin;
		((Control)Button_A5).Name = "Button_A5";
		Button button_A3 = Button_A5;
		size = new Size(85, 45);
		((Control)button_A3).Size = size;
		((Control)Button_A5).TabIndex = 1068;
		((ButtonBase)Button_A5).Text = "A5";
		((ButtonBase)Button_A5).UseVisualStyleBackColor = false;
		((ButtonBase)Button_A4).BackColor = Color.White;
		((Control)Button_A4).Cursor = Cursors.Hand;
		((ButtonBase)Button_A4).FlatAppearance.BorderColor = Color.RoyalBlue;
		((ButtonBase)Button_A4).FlatStyle = (FlatStyle)0;
		((Control)Button_A4).Font = new Font("Tahoma", 12.25f, (FontStyle)1);
		((Control)Button_A4).ForeColor = Color.RoyalBlue;
		((ButtonBase)Button_A4).ImageAlign = (ContentAlignment)16;
		Button button_A4 = Button_A4;
		location = new Point(386, 589);
		((Control)button_A4).Location = location;
		Button button_A5 = Button_A4;
		margin = new Padding(0);
		((Control)button_A5).Margin = margin;
		((Control)Button_A4).Name = "Button_A4";
		Button button_A6 = Button_A4;
		size = new Size(85, 45);
		((Control)button_A6).Size = size;
		((Control)Button_A4).TabIndex = 1067;
		((ButtonBase)Button_A4).Text = "A4";
		((ButtonBase)Button_A4).UseVisualStyleBackColor = false;
		((Control)Button_AUJOURDHUIT).Cursor = Cursors.Hand;
		((ButtonBase)Button_AUJOURDHUIT).FlatStyle = (FlatStyle)0;
		((Control)Button_AUJOURDHUIT).Font = new Font("Calibri", 12f, (FontStyle)1);
		((Control)Button_AUJOURDHUIT).ForeColor = Color.Black;
		Button button_AUJOURDHUIT = Button_AUJOURDHUIT;
		location = new Point(141, 9);
		((Control)button_AUJOURDHUIT).Location = location;
		Button button_AUJOURDHUIT2 = Button_AUJOURDHUIT;
		margin = new Padding(0);
		((Control)button_AUJOURDHUIT2).Margin = margin;
		((Control)Button_AUJOURDHUIT).Name = "Button_AUJOURDHUIT";
		Button button_AUJOURDHUIT3 = Button_AUJOURDHUIT;
		size = new Size(109, 29);
		((Control)button_AUJOURDHUIT3).Size = size;
		((Control)Button_AUJOURDHUIT).TabIndex = 1167;
		((ButtonBase)Button_AUJOURDHUIT).Text = "Aujourd'hui ";
		((ButtonBase)Button_AUJOURDHUIT).UseVisualStyleBackColor = true;
		((Control)BunifuDatePicker2).Anchor = (AnchorStyles)1;
		BunifuDatePicker2.BackColor = Color.Transparent;
		BunifuDatePicker2.BorderRadius = 2;
		BunifuDatePicker2.Color = Color.FromArgb(22, 106, 238);
		BunifuDatePicker2.DateBorderThickness = (Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness)1;
		BunifuDatePicker2.DateTextAlign = (Bunifu.UI.WinForms.BunifuDatePicker.TextAlign)0;
		BunifuDatePicker2.DisabledColor = Color.Gray;
		BunifuDatePicker2.DisplayWeekNumbers = false;
		BunifuDatePicker2.DPHeight = 0;
		((DateTimePicker)BunifuDatePicker2).DropDownAlign = (LeftRightAlignment)1;
		BunifuDatePicker2.FillDatePicker = false;
		BunifuDatePicker2.Font = new Font("Segoe UI", 11.25f, (FontStyle)1);
		BunifuDatePicker2.ForeColor = Color.Black;
		((DateTimePicker)BunifuDatePicker2).Format = (DateTimePickerFormat)2;
		BunifuDatePicker2.Icon = (Image)componentResourceManager.GetObject("BunifuDatePicker2.Icon");
		BunifuDatePicker2.IconColor = Color.Gray;
		BunifuDatePicker2.IconLocation = (Bunifu.UI.WinForms.BunifuDatePicker.Indicator)1;
		BunifuDatePicker2.LeftTextMargin = 5;
		BunifuDatePicker bunifuDatePicker = BunifuDatePicker2;
		location = new Point(212, 44);
		((Control)bunifuDatePicker).Location = location;
		BunifuDatePicker bunifuDatePicker2 = BunifuDatePicker2;
		size = new Size(4, 32);
		((Control)bunifuDatePicker2).MinimumSize = size;
		((Control)BunifuDatePicker2).Name = "BunifuDatePicker2";
		BunifuDatePicker bunifuDatePicker3 = BunifuDatePicker2;
		size = new Size(168, 32);
		((Control)bunifuDatePicker3).Size = size;
		((Control)BunifuDatePicker2).TabIndex = 1165;
		((Control)PictureBox3).Anchor = (AnchorStyles)1;
		PictureBox3.Image = (Image)componentResourceManager.GetObject("PictureBox3.Image");
		PictureBox3.ImeMode = (ImeMode)0;
		PictureBox pictureBox = PictureBox3;
		location = new Point(177, 44);
		((Control)pictureBox).Location = location;
		((Control)PictureBox3).Name = "PictureBox3";
		PictureBox pictureBox2 = PictureBox3;
		size = new Size(35, 32);
		((Control)pictureBox2).Size = size;
		PictureBox3.SizeMode = (PictureBoxSizeMode)3;
		PictureBox3.TabIndex = 1166;
		PictureBox3.TabStop = false;
		((Control)BunifuDatePicker1).Anchor = (AnchorStyles)1;
		BunifuDatePicker1.BackColor = Color.Transparent;
		BunifuDatePicker1.BorderRadius = 2;
		BunifuDatePicker1.Color = Color.FromArgb(22, 106, 238);
		BunifuDatePicker1.DateBorderThickness = (Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness)1;
		BunifuDatePicker1.DateTextAlign = (Bunifu.UI.WinForms.BunifuDatePicker.TextAlign)0;
		BunifuDatePicker1.DisabledColor = Color.Gray;
		BunifuDatePicker1.DisplayWeekNumbers = false;
		BunifuDatePicker1.DPHeight = 0;
		((DateTimePicker)BunifuDatePicker1).DropDownAlign = (LeftRightAlignment)1;
		BunifuDatePicker1.FillDatePicker = false;
		BunifuDatePicker1.Font = new Font("Segoe UI", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		BunifuDatePicker1.ForeColor = Color.Black;
		((DateTimePicker)BunifuDatePicker1).Format = (DateTimePickerFormat)2;
		BunifuDatePicker1.Icon = (Image)componentResourceManager.GetObject("BunifuDatePicker1.Icon");
		BunifuDatePicker1.IconColor = Color.Gray;
		BunifuDatePicker1.IconLocation = (Bunifu.UI.WinForms.BunifuDatePicker.Indicator)1;
		BunifuDatePicker1.LeftTextMargin = 5;
		BunifuDatePicker bunifuDatePicker4 = BunifuDatePicker1;
		location = new Point(9, 44);
		((Control)bunifuDatePicker4).Location = location;
		BunifuDatePicker bunifuDatePicker5 = BunifuDatePicker1;
		size = new Size(4, 32);
		((Control)bunifuDatePicker5).MinimumSize = size;
		((Control)BunifuDatePicker1).Name = "BunifuDatePicker1";
		BunifuDatePicker bunifuDatePicker6 = BunifuDatePicker1;
		size = new Size(168, 32);
		((Control)bunifuDatePicker6).Size = size;
		((Control)BunifuDatePicker1).TabIndex = 1164;
		((Control)Button_PRECEDENT).Cursor = Cursors.Hand;
		((ButtonBase)Button_PRECEDENT).FlatStyle = (FlatStyle)0;
		((Control)Button_PRECEDENT).Font = new Font("Calibri", 12f, (FontStyle)1);
		((Control)Button_PRECEDENT).ForeColor = Color.Black;
		((ButtonBase)Button_PRECEDENT).Image = (Image)componentResourceManager.GetObject("Button_PRECEDENT.Image");
		((ButtonBase)Button_PRECEDENT).ImageAlign = (ContentAlignment)16;
		Button button_PRECEDENT = Button_PRECEDENT;
		location = new Point(9, 9);
		((Control)button_PRECEDENT).Location = location;
		Button button_PRECEDENT2 = Button_PRECEDENT;
		margin = new Padding(0);
		((Control)button_PRECEDENT2).Margin = margin;
		((Control)Button_PRECEDENT).Name = "Button_PRECEDENT";
		Button button_PRECEDENT3 = Button_PRECEDENT;
		size = new Size(120, 29);
		((Control)button_PRECEDENT3).Size = size;
		((Control)Button_PRECEDENT).TabIndex = 1162;
		((ButtonBase)Button_PRECEDENT).Text = "Hier";
		((ButtonBase)Button_PRECEDENT).UseVisualStyleBackColor = true;
		((Control)Button_SUIVANT).Cursor = Cursors.Hand;
		((ButtonBase)Button_SUIVANT).FlatStyle = (FlatStyle)0;
		((Control)Button_SUIVANT).Font = new Font("Calibri", 12f, (FontStyle)1);
		((Control)Button_SUIVANT).ForeColor = Color.Black;
		((ButtonBase)Button_SUIVANT).Image = (Image)componentResourceManager.GetObject("Button_SUIVANT.Image");
		((ButtonBase)Button_SUIVANT).ImageAlign = (ContentAlignment)64;
		Button button_SUIVANT = Button_SUIVANT;
		location = new Point(264, 9);
		((Control)button_SUIVANT).Location = location;
		Button button_SUIVANT2 = Button_SUIVANT;
		margin = new Padding(0);
		((Control)button_SUIVANT2).Margin = margin;
		((Control)Button_SUIVANT).Name = "Button_SUIVANT";
		Button button_SUIVANT3 = Button_SUIVANT;
		size = new Size(116, 29);
		((Control)button_SUIVANT3).Size = size;
		((Control)Button_SUIVANT).TabIndex = 1163;
		((ButtonBase)Button_SUIVANT).Text = "Demain";
		((ButtonBase)Button_SUIVANT).UseVisualStyleBackColor = true;
		((DataGridViewColumn)ID_TICKET).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)ID_TICKET).HeaderText = "ID_TICKET";
		((DataGridViewColumn)ID_TICKET).MinimumWidth = 2;
		((DataGridViewColumn)ID_TICKET).Name = "ID_TICKET";
		((DataGridViewColumn)ID_TICKET).ReadOnly = true;
		((DataGridViewColumn)ID_TICKET).Width = 2;
		((DataGridViewColumn)DataGridViewTextBoxColumn6).HeaderText = "N° Ticket";
		((DataGridViewColumn)DataGridViewTextBoxColumn6).MinimumWidth = 2;
		((DataGridViewColumn)DataGridViewTextBoxColumn6).Name = "DataGridViewTextBoxColumn6";
		((DataGridViewColumn)DataGridViewTextBoxColumn6).ReadOnly = true;
		val10.Alignment = (DataGridViewContentAlignment)64;
		val10.Format = "N2";
		val10.NullValue = null;
		((DataGridViewColumn)Column1).DefaultCellStyle = val10;
		((DataGridViewColumn)Column1).HeaderText = "Total Net";
		((DataGridViewColumn)Column1).Name = "Column1";
		((DataGridViewColumn)Column1).ReadOnly = true;
		((DataGridViewColumn)Column2).HeaderText = "Opération";
		((DataGridViewColumn)Column2).Name = "Column2";
		((DataGridViewColumn)Column2).ReadOnly = true;
		((DataGridViewColumn)Client).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)Client).HeaderText = "Client";
		((DataGridViewColumn)Client).Name = "Client";
		((DataGridViewColumn)Client).ReadOnly = true;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).BackColor = Color.White;
		size = new Size(1008, 637);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)Button_AUJOURDHUIT);
		((Control)this).Controls.Add((Control)(object)BunifuDatePicker2);
		((Control)this).Controls.Add((Control)(object)PictureBox3);
		((Control)this).Controls.Add((Control)(object)BunifuDatePicker1);
		((Control)this).Controls.Add((Control)(object)Button_PRECEDENT);
		((Control)this).Controls.Add((Control)(object)Button_SUIVANT);
		((Control)this).Controls.Add((Control)(object)Button_ARABE_80);
		((Control)this).Controls.Add((Control)(object)Button_ARABE_A5);
		((Control)this).Controls.Add((Control)(object)Button_A5);
		((Control)this).Controls.Add((Control)(object)Button_A4);
		((Control)this).Controls.Add((Control)(object)Button2);
		((Control)this).Controls.Add((Control)(object)Panel1);
		((Control)this).Controls.Add((Control)(object)Panel_FONCTIONS);
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Form)this).KeyPreview = true;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "FormDialog_DUPLICATA";
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).Text = "DUPLICATA";
		((ISupportInitialize)DataGridView1).EndInit();
		((Control)Panel_FONCTIONS).ResumeLayout(false);
		((ISupportInitialize)DataGridView3).EndInit();
		((Control)Panel1).ResumeLayout(false);
		((Control)Panel1).PerformLayout();
		((ISupportInitialize)DataGridView_MODE_P).EndInit();
		((Control)Panel2).ResumeLayout(false);
		((ISupportInitialize)PictureBox3).EndInit();
		((Control)this).ResumeLayout(false);
	}

	public void Start_Print_COM_CL()
	{
		PrintBuffer = "";
		prn.OpenPrint(Text_PRINTER_SOLDER.Text);
	}

	public void Print_COM_CL(string Line)
	{
		prn.SendStringToPrinter(Text_PRINTER_SOLDER.Text, Line + "\n");
	}

	public void EndPrint()
	{
		prn.ClosePrint();
	}

	public void CL_COM()
	{
		Start_Print_COM_CL();
		Print_COM_CL("\u001b!8\u001ba1" + MyProject.Forms.Form_1_LOGIN.TextBox_ORGANISME.Text);
		Print_COM_CL("\u001ba0\u001b!\0" + "-".PadRight(42, '-'));
		string text = "";
		checked
		{
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
				text = Strings.LSet(DataGridView1.Rows[num2].Cells["Qté"].Value.ToString() + "x", 4) + Strings.LSet(DataGridView1.Rows[num2].Cells["Article"].Value.ToString(), 30) + "  " + Conversions.ToString(Math.Round(Conversions.ToDecimal(Strings.RSet(Strings.FormatNumber(DataGridView1.Rows[num2].Cells["TOTAL_NET"].Value.ToString()), 6)), 2));
				Print_COM_CL("\u001b!\0\r\u001bc6\u0001\u001bR3" + text);
				num2++;
			}
			Print_COM_CL("\u001ba0\u001b!\0" + "-".PadRight(42, '-'));
			Print_COM_CL("\u001ba0\u001b!8TOTAL : " + Conversions.ToString(Math.Round(Conversions.ToDecimal(Text_TOTAL_NET.Text), 2)) + " DH");
			Print_COM_CL("\n");
			Print_COM_CL("\u001ba0\u001b!\0* N TICKET  : " + DataGridView1.Rows[0].Cells["Ticket"].Value.ToString());
			Print_COM_CL("\u001ba0\u001b!\0* CAISSIER  : " + DataGridView1.Rows[0].Cells["CAISSIER"].Value.ToString());
			Print_COM_CL("\u001ba0\u001b!\0* CLIENT    : " + Label_CLIENT.Text);
			Print_COM_CL("\u001ba0\u001b!\0" + "-".PadRight(42, '-'));
			Print_COM_CL("\u001b!8\u001b!\0\r\u001bc6\u0001\u001bR3\r\n\u001ba1MERCI DE VOTRE VISITE");
			Print_COM_CL("\n");
			Print_COM_CL("\u001ba1\u001b!\0" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
			Print_COM_CL("\n\n\u001bi\r\n\u001b@\u001bp\0.}");
			EndPrint();
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

	private void FormDialog_DUPLICATA_Load(object sender, EventArgs e)
	{
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected Obj, but got Unknown
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected Obj, but got Unknown
		//IL_047a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0481: Expected Obj, but got Unknown
		checked
		{
			try
			{
				Text_pied_doc.Text = MyProject.Forms.Form_0_TEMPLATE.ListView1.Items[MyProject.Forms.Form_0_TEMPLATE.ListView1.FindItemWithText("PIED_DOC", false, 0).Index].SubItems[1].Text;
				DataGridView1.AutoGenerateColumns = false;
				DataGridView1.RowTemplate.Height = 25;
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
				DataGridView_MODE_P.AutoGenerateColumns = false;
				DataGridView_MODE_P.SelectionMode = (DataGridViewSelectionMode)1;
				DataGridView_MODE_P.MultiSelect = false;
				DataGridView_MODE_P.ColumnHeadersDefaultCellStyle.Alignment = (DataGridViewContentAlignment)32;
				DataGridView_MODE_P.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
				DataGridView_MODE_P.RowTemplate.Height = 25;
				DataGridView_MODE_P.ColumnHeadersDefaultCellStyle.Alignment = (DataGridViewContentAlignment)16;
				DataGridView_MODE_P.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)0;
				DataGridView_MODE_P.Columns[0].DefaultCellStyle.WrapMode = (DataGridViewTriState)1;
				DataGridView_MODE_P.AutoSizeRowsMode = (DataGridViewAutoSizeRowsMode)7;
				DataGridView_MODE_P.ClipboardCopyMode = (DataGridViewClipboardCopyMode)0;
				int num5 = ((BaseCollection)DataGridView_MODE_P.Columns).Count - 1;
				int num6 = 0;
				while (true)
				{
					int num7 = num6;
					int num4 = num5;
					if (num7 > num4)
					{
						break;
					}
					DataGridView_MODE_P.Columns[num6].SortMode = (DataGridViewColumnSortMode)2;
					num6++;
				}
				DataGridView_MODE_P.EnableHeadersVisualStyles = false;
				Text_PRINTER_SOLDER.Text = File.ReadAllText(Application.StartupPath + "/PRINTER_CL.sni");
				BunifuDatePicker1_ValueChanged(RuntimeHelpers.GetObjectValue(sender), e);
				DataGridView1.DataSource = null;
				if (DataGridView3.Rows.Count > 0)
				{
					DataGridView3.Rows[0].Cells[0].Selected = true;
					DataGridView3_CellClick(null, null);
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

	private void CL_FR_3C_PrintPage(object sender, PrintPageEventArgs e)
	{
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected Obj, but got Unknown
		//IL_00c5: Expected Obj, but got Unknown
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Expected Obj, but got Unknown
		//IL_01ef: Expected Obj, but got Unknown
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Expected Obj, but got Unknown
		//IL_0259: Expected Obj, but got Unknown
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Expected Obj, but got Unknown
		//IL_02cc: Expected Obj, but got Unknown
		//IL_02e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_031e: Expected Obj, but got Unknown
		//IL_031e: Expected Obj, but got Unknown
		//IL_0839: Unknown result type (might be due to invalid IL or missing references)
		//IL_086a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0874: Expected Obj, but got Unknown
		//IL_0874: Expected Obj, but got Unknown
		checked
		{
			try
			{
				Graphics graphics = e.Graphics;
				Image image = MyProject.Forms.Form_3_VENTE.Picture_LOGO.Image;
				Rectangle rectangle = new Rectangle(((Control)MyProject.Forms.Form_3_VENTE.Picture_LOGO).Left, ((Control)MyProject.Forms.Form_3_VENTE.Picture_LOGO).Top, ((Control)MyProject.Forms.Form_3_VENTE.Picture_LOGO).Width, ((Control)MyProject.Forms.Form_3_VENTE.Picture_LOGO).Height);
				graphics.DrawImage(image, rectangle);
				e.Graphics.DrawString("-------------------------------------------", new Font("Inconsolata Condensed", 11f, (FontStyle)0), Brushes.Black, 0f, (float)((Control)MyProject.Forms.Form_3_VENTE.Panel_LOGO).Height, new StringFormat((StringFormatFlags)8192));
				string text = "";
				int num = 0;
				int num2 = DataGridView1.RowCount - 1;
				int num3 = 0;
				while (true)
				{
					int num4 = num3;
					int num5 = num2;
					if (num4 > num5)
					{
						break;
					}
					text = Strings.LSet(Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(DataGridView1.Rows[num3].Cells["Qté"].Value))) + "x", 7) + Strings.LSet(Conversions.ToString(DataGridView1.Rows[num3].Cells["Article"].Value), 27) + " " + Strings.RSet(Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(DataGridView1.Rows[num3].Cells["TOTAL_NET"].Value))), 8);
					e.Graphics.DrawString(text, new Font("Inconsolata Condensed", 11f, (FontStyle)1), Brushes.Black, 0f, (float)(((Control)MyProject.Forms.Form_3_VENTE.Panel_LOGO).Height + num * 16 + 10), new StringFormat((StringFormatFlags)8192));
					num++;
					num3++;
				}
				e.Graphics.DrawString("-------------------------------------------", new Font("Inconsolata Condensed", 11f, (FontStyle)0), Brushes.Black, 0f, (float)(((Control)MyProject.Forms.Form_3_VENTE.Panel_LOGO).Height + num * 16 + 10), new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("TOTAL NET: " + Strings.RSet(Text_TOTAL_NET.Text + " DH", 12), new Font("Inconsolata ExtraBold", 16f, (FontStyle)1), Brushes.Black, 0f, (float)(((Control)MyProject.Forms.Form_3_VENTE.Panel_LOGO).Height + num * 16 + 20), new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("-------------------------------------------", new Font("Inconsolata Condensed", 11f, (FontStyle)0), Brushes.Black, 0f, (float)(((Control)MyProject.Forms.Form_3_VENTE.Panel_LOGO).Height + num * 16 + 40), new StringFormat((StringFormatFlags)8192));
				_string = "";
				decimal num6 = 0m;
				decimal num7 = 0m;
				int num8 = dt_duplicata.Rows.Count - 1;
				int num9 = 0;
				while (true)
				{
					int num10 = num9;
					int num5 = num8;
					if (num10 > num5)
					{
						break;
					}
					num6 = Conversions.ToDecimal(Operators.AddObject(num6, Operators.SubtractObject(Operators.MultiplyObject(dt_duplicata.Rows[num9]["PRIX_V"], dt_duplicata.Rows[num9]["Qté"]), dt_duplicata.Rows[num9]["TOTAL_NET"])));
					num7 = Conversions.ToDecimal(Operators.AddObject(num7, Operators.MultiplyObject(dt_duplicata.Rows[num9]["PRIX_V"], dt_duplicata.Rows[num9]["Qté"])));
					num9++;
				}
				if (Convert.ToInt32(num6) > 0)
				{
					_string = _string + "* REMISE    : " + Strings.RSet(Strings.FormatNumber(num6), 8) + " DH\r\n";
					_string += "\r\n\r\n";
				}
				if (Operators.CompareString(Label_OPERATION.Text, "VENTE", TextCompare: false) == 0)
				{
					if (MyProject.Forms.Form_3_VENTE.CheckBox_AFFICHER_MODEP.Checked)
					{
						string text2 = "";
						int num11 = DataGridView_MODE_P.Rows.Count - 1;
						int num12 = 0;
						while (true)
						{
							int num13 = num12;
							int num5 = num11;
							if (num13 <= num5)
							{
								_string = _string + Strings.LSet(Conversions.ToString(Operators.ConcatenateObject("* ", DataGridView_MODE_P.Rows[num12].Cells["MODE_P"].Value)), 11) + " : " + Strings.RSet(Conversions.ToString(DataGridView_MODE_P.Rows[num12].Cells["MONTANT"].Value), 6) + " DH\r\n";
								num12++;
								continue;
							}
							break;
						}
					}
				}
				else if (Operators.CompareString(Label_OPERATION.Text, "CREDIT", TextCompare: false) == 0)
				{
					_string += "\r\n";
					_string += "-------------------------------------------\r\n";
					_string += "-------------------CREDIT------------------\r\n";
					_string += "-------------------------------------------\r\n";
					_string += "\r\n";
				}
				_string += "\r\n";
				if (Operators.CompareString(Label_CLIENT.Text, "", TextCompare: false) != 0)
				{
					_string = _string + "* CLIENT    : " + Label_CLIENT.Text + "\r\n";
					_string = _string + "* ID        : " + Label_ID_CLIENT.Text + "\r\n";
				}
				_string = _string + "* CAISSIER  : " + Label_CAISSIER.Text + "\r\n";
				if (MyProject.Forms.Form_3_VENTE.CheckBox_AFFICHER_N_TICKET.Checked)
				{
					_string = _string + "* N° TICKET : " + Conversions.ToString(Conversion.Val(Label_N_TICKET.Text)) + "\r\n";
				}
				_string += MyProject.Forms.Form_3_VENTE.Text_pied.Text;
				_string += "\r\n";
				_string = _string + "            " + Conversions.ToDate(Label_DATES.Text).ToString("dd/MM/yyy HH:mm:ss") + "\r\n";
				_string += "\r\n";
				_string += "-------------------------------------------\r\n";
				_string += "-------------TICKET DUPLICATA--------------\r\n";
				_string += "-------------------------------------------\r\n";
				_string += "\r\n";
				_string += "\r\n\r\n";
				e.Graphics.DrawString(_string, new Font("Inconsolata Condensed", 11f, (FontStyle)1), Brushes.Black, 0f, (float)(((Control)MyProject.Forms.Form_3_VENTE.Panel_LOGO).Height + num * 16 + 50), new StringFormat((StringFormatFlags)8192));
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

	private void CL_FR_4C_PrintPage(object sender, PrintPageEventArgs e)
	{
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected Obj, but got Unknown
		//IL_00c5: Expected Obj, but got Unknown
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected Obj, but got Unknown
		//IL_0111: Expected Obj, but got Unknown
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected Obj, but got Unknown
		//IL_015e: Expected Obj, but got Unknown
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Expected Obj, but got Unknown
		//IL_02b8: Expected Obj, but got Unknown
		//IL_02e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_031b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0325: Expected Obj, but got Unknown
		//IL_0325: Expected Obj, but got Unknown
		//IL_035d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0391: Unknown result type (might be due to invalid IL or missing references)
		//IL_039b: Expected Obj, but got Unknown
		//IL_039b: Expected Obj, but got Unknown
		//IL_03b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f0: Expected Obj, but got Unknown
		//IL_03f0: Expected Obj, but got Unknown
		//IL_09f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a36: Expected Obj, but got Unknown
		//IL_0a36: Expected Obj, but got Unknown
		checked
		{
			try
			{
				Graphics graphics = e.Graphics;
				Image image = MyProject.Forms.Form_3_VENTE.Picture_LOGO.Image;
				Rectangle rectangle = new Rectangle(((Control)MyProject.Forms.Form_3_VENTE.Picture_LOGO).Left, ((Control)MyProject.Forms.Form_3_VENTE.Picture_LOGO).Top, ((Control)MyProject.Forms.Form_3_VENTE.Picture_LOGO).Width, ((Control)MyProject.Forms.Form_3_VENTE.Picture_LOGO).Height);
				graphics.DrawImage(image, rectangle);
				e.Graphics.DrawString("-------------------------------------------", new Font("Inconsolata Condensed", 11f, (FontStyle)0), Brushes.Black, 0f, (float)((Control)MyProject.Forms.Form_3_VENTE.Panel_LOGO).Height, new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("Désignation           Qté     Prix    Total  ", new Font("Inconsolata Condensed", 11f, (FontStyle)0), Brushes.Black, 0f, (float)(((Control)MyProject.Forms.Form_3_VENTE.Panel_LOGO).Height + 7), new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("-------------------------------------------", new Font("Inconsolata Condensed", 11f, (FontStyle)0), Brushes.Black, 0f, (float)(((Control)MyProject.Forms.Form_3_VENTE.Panel_LOGO).Height + 15), new StringFormat((StringFormatFlags)8192));
				string text = "";
				int num = 0;
				int num2 = DataGridView1.RowCount - 1;
				int num3 = 0;
				while (true)
				{
					int num4 = num3;
					int num5 = num2;
					if (num4 > num5)
					{
						break;
					}
					text = Strings.LSet(Conversions.ToString(DataGridView1.Rows[num3].Cells["Article"].Value), 20) + Strings.RSet(Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(DataGridView1.Rows[num3].Cells["Qté"].Value))), 6) + Strings.RSet(Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(DataGridView1.Rows[num3].Cells["Prix_V"].Value))), 8) + Strings.RSet(Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(DataGridView1.Rows[num3].Cells["TOTAL_NET"].Value))), 9);
					e.Graphics.DrawString(text, new Font("Inconsolata Condensed", 11f, (FontStyle)1), Brushes.Black, 0f, (float)(((Control)MyProject.Forms.Form_3_VENTE.Panel_LOGO).Height + num * 16 + 10 + 20), new StringFormat((StringFormatFlags)8192));
					num++;
					num3++;
				}
				e.Graphics.DrawString("-------------------------------------------", new Font("Inconsolata Condensed", 11f, (FontStyle)0), Brushes.Black, 0f, (float)(((Control)MyProject.Forms.Form_3_VENTE.Panel_LOGO).Height + num * 16 + 10 + 20), new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("TOTAL NET: " + Strings.RSet(Text_TOTAL_NET.Text + " DH", 12), new Font("Inconsolata ExtraBold", 16f, (FontStyle)1), Brushes.Black, 0f, (float)(((Control)MyProject.Forms.Form_3_VENTE.Panel_LOGO).Height + num * 16 + 20 + 20), new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("-------------------------------------------", new Font("Inconsolata Condensed", 11f, (FontStyle)0), Brushes.Black, 0f, (float)(((Control)MyProject.Forms.Form_3_VENTE.Panel_LOGO).Height + num * 16 + 40 + 20), new StringFormat((StringFormatFlags)8192));
				_string = "";
				_string = _string + "* Nbr Articles: " + Label_NBR_ARTICLES.Text + "\r\n";
				_string += "\r\n";
				decimal num6 = 0m;
				decimal num7 = 0m;
				int num8 = dt_duplicata.Rows.Count - 1;
				int num9 = 0;
				while (true)
				{
					int num10 = num9;
					int num5 = num8;
					if (num10 > num5)
					{
						break;
					}
					num6 = Conversions.ToDecimal(Operators.AddObject(num6, Operators.SubtractObject(Operators.MultiplyObject(dt_duplicata.Rows[num9]["PRIX_V"], dt_duplicata.Rows[num9]["Qté"]), dt_duplicata.Rows[num9]["TOTAL_NET"])));
					num7 = Conversions.ToDecimal(Operators.AddObject(num7, Operators.MultiplyObject(dt_duplicata.Rows[num9]["PRIX_V"], dt_duplicata.Rows[num9]["Qté"])));
					num9++;
				}
				if (decimal.Compare(num6, 0m) > 0)
				{
					_string = _string + "* REMISE    : " + Strings.RSet(Strings.FormatNumber(num6), 8) + " DH / " + Strings.FormatNumber(decimal.Multiply(decimal.Divide(num6, num7), 100m)) + " %\r\n";
					_string += "\r\n\r\n";
				}
				if (Operators.CompareString(Label_OPERATION.Text, "VENTE", TextCompare: false) == 0)
				{
					if (MyProject.Forms.Form_3_VENTE.CheckBox_AFFICHER_MODEP.Checked)
					{
						string text2 = "";
						int num11 = DataGridView_MODE_P.Rows.Count - 1;
						int num12 = 0;
						while (true)
						{
							int num13 = num12;
							int num5 = num11;
							if (num13 <= num5)
							{
								_string = _string + Strings.LSet(Conversions.ToString(Operators.ConcatenateObject("* ", DataGridView_MODE_P.Rows[num12].Cells["MODE_P"].Value)), 11) + " : " + Strings.RSet(Conversions.ToString(DataGridView_MODE_P.Rows[num12].Cells["MONTANT"].Value), 6) + " DH\r\n";
								num12++;
								continue;
							}
							break;
						}
					}
				}
				else if (Operators.CompareString(Label_OPERATION.Text, "CREDIT", TextCompare: false) == 0)
				{
					_string += "\r\n";
					_string += "-------------------------------------------\r\n";
					_string += "-------------------CREDIT------------------\r\n";
					_string += "-------------------------------------------\r\n";
					_string += "\r\n";
				}
				_string += "\r\n";
				if (Operators.CompareString(Label_CLIENT.Text, "", TextCompare: false) != 0)
				{
					_string = _string + "* CLIENT    : " + Label_CLIENT.Text + "\r\n";
					_string = _string + "* ID        : " + Label_ID_CLIENT.Text + "\r\n";
				}
				_string = _string + "* CAISSIER  : " + Label_CAISSIER.Text + "\r\n";
				if (MyProject.Forms.Form_3_VENTE.CheckBox_AFFICHER_N_TICKET.Checked)
				{
					_string = _string + "* N° TICKET : " + Conversions.ToString(Conversion.Val(Label_N_TICKET.Text)) + "\r\n";
				}
				_string += "\r\n";
				_string += MyProject.Forms.Form_3_VENTE.Text_pied.Text;
				_string += "\r\n";
				_string = _string + "            " + DateTime.Now.ToString("dd/MM/yyy HH:mm:ss") + "(" + Conversions.ToString(Conversion.Val(MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text)) + ")\r\n";
				_string += "\r\n";
				_string += "-------------------------------------------\r\n";
				_string += "-------------TICKET DUPLICATA--------------\r\n";
				_string += "-------------------------------------------\r\n";
				_string += "\r\n";
				_string += "\r\n\r\n";
				e.Graphics.DrawString(_string, new Font("Inconsolata Condensed", 11f, (FontStyle)1), Brushes.Black, 0f, (float)(((Control)MyProject.Forms.Form_3_VENTE.Panel_LOGO).Height + num * 16 + 50 + 20), new StringFormat((StringFormatFlags)8192));
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

	private void CL_FR_2L_PrintPage(object sender, PrintPageEventArgs e)
	{
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected Obj, but got Unknown
		//IL_00c5: Expected Obj, but got Unknown
		//IL_050f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0540: Unknown result type (might be due to invalid IL or missing references)
		//IL_054a: Expected Obj, but got Unknown
		//IL_054a: Expected Obj, but got Unknown
		//IL_0582: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bd: Expected Obj, but got Unknown
		//IL_05bd: Expected Obj, but got Unknown
		//IL_05d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0605: Unknown result type (might be due to invalid IL or missing references)
		//IL_060f: Expected Obj, but got Unknown
		//IL_060f: Expected Obj, but got Unknown
		//IL_04a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04df: Expected Obj, but got Unknown
		//IL_04df: Expected Obj, but got Unknown
		//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Expected Obj, but got Unknown
		//IL_032b: Expected Obj, but got Unknown
		//IL_0c17: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c48: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c52: Expected Obj, but got Unknown
		//IL_0c52: Expected Obj, but got Unknown
		checked
		{
			try
			{
				Graphics graphics = e.Graphics;
				Image image = MyProject.Forms.Form_3_VENTE.Picture_LOGO.Image;
				Rectangle rectangle = new Rectangle(((Control)MyProject.Forms.Form_3_VENTE.Picture_LOGO).Left, ((Control)MyProject.Forms.Form_3_VENTE.Picture_LOGO).Top, ((Control)MyProject.Forms.Form_3_VENTE.Picture_LOGO).Width, ((Control)MyProject.Forms.Form_3_VENTE.Picture_LOGO).Height);
				graphics.DrawImage(image, rectangle);
				e.Graphics.DrawString("-------------------------------------------", new Font("Inconsolata Condensed", 11f, (FontStyle)0), Brushes.Black, 0f, (float)((Control)MyProject.Forms.Form_3_VENTE.Panel_LOGO).Height, new StringFormat((StringFormatFlags)8192));
				string text = "";
				int num = 0;
				int num2 = DataGridView1.RowCount - 1;
				int num3 = 0;
				while (true)
				{
					int num4 = num3;
					int num5 = num2;
					if (num4 > num5)
					{
						break;
					}
					if (Operators.ConditionalCompareObjectGreater(DataGridView1.Rows[num3].Cells["REMISE"].Value, 0, TextCompare: false))
					{
						text = Strings.LSet(Conversions.ToString(DataGridView1.Rows[num3].Cells["Article"].Value), 33) + " " + Strings.RSet(Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(DataGridView1.Rows[num3].Cells["TOTAL_NET"].Value))), 8) + "\r\n" + Strings.LSet(Conversions.ToString(DataGridView1.Rows[num3].Cells["CODE"].Value), 29) + Strings.RSet(Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(DataGridView1.Rows[num3].Cells["Qté"].Value))), 4) + "x" + Strings.RSet(Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(DataGridView1.Rows[num3].Cells["Prix_V"].Value))), 8) + "\r\n" + Strings.RSet("(REMISE" + Strings.RSet(Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(DataGridView1.Rows[num3].Cells["REMISE"].Value))), 6) + "%)", 42);
						e.Graphics.DrawString(text, new Font("Inconsolata Condensed", 11f, (FontStyle)1), Brushes.Black, 0f, (float)(((Control)MyProject.Forms.Form_3_VENTE.Panel_LOGO).Height + num * 16 + 10), new StringFormat((StringFormatFlags)8192));
						num += 3;
					}
					else
					{
						text = Strings.LSet(Conversions.ToString(DataGridView1.Rows[num3].Cells["Article"].Value), 33) + " " + Strings.RSet(Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(DataGridView1.Rows[num3].Cells["TOTAL_NET"].Value))), 8) + "\r\n" + Strings.LSet(Conversions.ToString(DataGridView1.Rows[num3].Cells["CODE"].Value), 29) + Strings.RSet(Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(DataGridView1.Rows[num3].Cells["Qté"].Value))), 4) + "x" + Strings.RSet(Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(DataGridView1.Rows[num3].Cells["Prix_V"].Value))), 8);
						e.Graphics.DrawString(text, new Font("Inconsolata Condensed", 11f, (FontStyle)1), Brushes.Black, 0f, (float)(((Control)MyProject.Forms.Form_3_VENTE.Panel_LOGO).Height + num * 16 + 10), new StringFormat((StringFormatFlags)8192));
						num += 2;
					}
					num3++;
				}
				e.Graphics.DrawString("-------------------------------------------", new Font("Inconsolata Condensed", 11f, (FontStyle)0), Brushes.Black, 0f, (float)(((Control)MyProject.Forms.Form_3_VENTE.Panel_LOGO).Height + num * 16 + 10), new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("TOTAL NET: " + Strings.RSet(Text_TOTAL_NET.Text + " DH", 12), new Font("Inconsolata ExtraBold", 16f, (FontStyle)1), Brushes.Black, 0f, (float)(((Control)MyProject.Forms.Form_3_VENTE.Panel_LOGO).Height + num * 16 + 20), new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("-------------------------------------------", new Font("Inconsolata Condensed", 11f, (FontStyle)0), Brushes.Black, 0f, (float)(((Control)MyProject.Forms.Form_3_VENTE.Panel_LOGO).Height + num * 16 + 40), new StringFormat((StringFormatFlags)8192));
				_string = "";
				_string = _string + "* Nbr Articles: " + Label_NBR_ARTICLES.Text + "\r\n";
				_string += "\r\n";
				decimal num6 = 0m;
				decimal num7 = 0m;
				int num8 = dt_duplicata.Rows.Count - 1;
				int num9 = 0;
				while (true)
				{
					int num10 = num9;
					int num5 = num8;
					if (num10 > num5)
					{
						break;
					}
					num6 = Conversions.ToDecimal(Operators.AddObject(num6, Operators.SubtractObject(Operators.MultiplyObject(dt_duplicata.Rows[num9]["PRIX_V"], dt_duplicata.Rows[num9]["Qté"]), dt_duplicata.Rows[num9]["TOTAL_NET"])));
					num7 = Conversions.ToDecimal(Operators.AddObject(num7, Operators.MultiplyObject(dt_duplicata.Rows[num9]["PRIX_V"], dt_duplicata.Rows[num9]["Qté"])));
					num9++;
				}
				if (decimal.Compare(num6, 0m) > 0)
				{
					_string = _string + "* REMISE    : " + Strings.RSet(Strings.FormatNumber(num6), 8) + " DH / " + Strings.FormatNumber(decimal.Multiply(decimal.Divide(num6, num7), 100m)) + " %\r\n";
					_string += "\r\n\r\n";
				}
				if (Operators.CompareString(Label_OPERATION.Text, "VENTE", TextCompare: false) == 0)
				{
					if (MyProject.Forms.Form_3_VENTE.CheckBox_AFFICHER_MODEP.Checked)
					{
						string text2 = "";
						int num11 = DataGridView_MODE_P.Rows.Count - 1;
						int num12 = 0;
						while (true)
						{
							int num13 = num12;
							int num5 = num11;
							if (num13 <= num5)
							{
								_string = _string + Strings.LSet(Conversions.ToString(Operators.ConcatenateObject("* ", DataGridView_MODE_P.Rows[num12].Cells["MODE_P"].Value)), 11) + " : " + Strings.RSet(Conversions.ToString(DataGridView_MODE_P.Rows[num12].Cells["MONTANT"].Value), 6) + " DH\r\n";
								num12++;
								continue;
							}
							break;
						}
					}
				}
				else if (Operators.CompareString(Label_OPERATION.Text, "CREDIT", TextCompare: false) == 0)
				{
					_string += "\r\n";
					_string += "-------------------------------------------\r\n";
					_string += "-------------------CREDIT------------------\r\n";
					_string += "-------------------------------------------\r\n";
					_string += "\r\n";
				}
				_string += "\r\n";
				if (Operators.CompareString(Label_CLIENT.Text, "", TextCompare: false) != 0)
				{
					_string = _string + "* CLIENT    : " + Label_CLIENT.Text + "\r\n";
					_string = _string + "* ID        : " + Label_ID_CLIENT.Text + "\r\n";
				}
				_string = _string + "* CAISSIER  : " + Label_CAISSIER.Text + "\r\n";
				if (MyProject.Forms.Form_3_VENTE.CheckBox_AFFICHER_N_TICKET.Checked)
				{
					_string = _string + "* N° TICKET : " + Conversions.ToString(Conversion.Val(Label_N_TICKET.Text)) + "\r\n";
				}
				_string += "\r\n";
				_string += MyProject.Forms.Form_3_VENTE.Text_pied.Text;
				_string += "\r\n";
				_string = _string + "            " + DateTime.Now.ToString("dd/MM/yyy HH:mm:ss") + "(" + Conversions.ToString(Conversion.Val(MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text)) + ")\r\n";
				_string += "\r\n";
				_string += "-------------------------------------------\r\n";
				_string += "-------------TICKET DUPLICATA--------------\r\n";
				_string += "-------------------------------------------\r\n";
				_string += "\r\n";
				_string += "\r\n\r\n";
				e.Graphics.DrawString(_string, new Font("Inconsolata Condensed", 11f, (FontStyle)1), Brushes.Black, 0f, (float)(((Control)MyProject.Forms.Form_3_VENTE.Panel_LOGO).Height + num * 16 + 50), new StringFormat((StringFormatFlags)8192));
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

	private void CL_AR_3C_PrintPage(object sender, PrintPageEventArgs e)
	{
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected Obj, but got Unknown
		//IL_00c5: Expected Obj, but got Unknown
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected Obj, but got Unknown
		//IL_010e: Expected Obj, but got Unknown
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected Obj, but got Unknown
		//IL_015b: Expected Obj, but got Unknown
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Expected Obj, but got Unknown
		//IL_027a: Expected Obj, but got Unknown
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e7: Expected Obj, but got Unknown
		//IL_02e7: Expected Obj, but got Unknown
		//IL_031f: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0359: Expected Obj, but got Unknown
		//IL_0359: Expected Obj, but got Unknown
		//IL_0370: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ae: Expected Obj, but got Unknown
		//IL_03ae: Expected Obj, but got Unknown
		//IL_0918: Unknown result type (might be due to invalid IL or missing references)
		//IL_0948: Unknown result type (might be due to invalid IL or missing references)
		//IL_0952: Expected Obj, but got Unknown
		//IL_0952: Expected Obj, but got Unknown
		checked
		{
			try
			{
				Graphics graphics = e.Graphics;
				Image image = MyProject.Forms.Form_3_VENTE.Picture_LOGO.Image;
				Rectangle rectangle = new Rectangle(((Control)MyProject.Forms.Form_3_VENTE.Picture_LOGO).Left, ((Control)MyProject.Forms.Form_3_VENTE.Picture_LOGO).Top, ((Control)MyProject.Forms.Form_3_VENTE.Picture_LOGO).Width, ((Control)MyProject.Forms.Form_3_VENTE.Picture_LOGO).Height);
				graphics.DrawImage(image, rectangle);
				e.Graphics.DrawString("----------------------------------------------", new Font("Kawkab Mono", 7f, (FontStyle)0), Brushes.Black, 0f, (float)((Control)MyProject.Forms.Form_3_VENTE.Panel_LOGO).Height, new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("كمية |البضاعة              |الثمن  |المجموع              ", new Font("Kawkab Mono", 6f, (FontStyle)0), Brushes.Black, 260f, (float)(((Control)MyProject.Forms.Form_3_VENTE.Panel_LOGO).Height + 10), new StringFormat((StringFormatFlags)1));
				e.Graphics.DrawString("----------------------------------------------", new Font("Kawkab Mono", 7f, (FontStyle)0), Brushes.Black, 0f, (float)(((Control)MyProject.Forms.Form_3_VENTE.Panel_LOGO).Height + 18), new StringFormat((StringFormatFlags)8192));
				string text = "";
				int num = 0;
				int num2 = DataGridView1.RowCount - 1;
				int num3 = 0;
				while (true)
				{
					int num4 = num3;
					int num5 = num2;
					if (num4 > num5)
					{
						break;
					}
					text = Strings.LSet(Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(DataGridView1.Rows[num3].Cells["Qté"].Value))), 4) + Strings.LSet(Conversions.ToString(DataGridView1.Rows[num3].Cells["Article"].Value), 26) + "  " + Strings.LSet(Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(DataGridView1.Rows[num3].Cells["TOTAL_NET"].Value))), 7);
					e.Graphics.DrawString(text, new Font("Kawkab Mono", 7f, (FontStyle)1), Brushes.Black, 260f, (float)(((Control)MyProject.Forms.Form_3_VENTE.Panel_LOGO).Height + num * 16 + 10 + 20), new StringFormat((StringFormatFlags)1));
					num++;
					num3++;
				}
				e.Graphics.DrawString("----------------------------------------------", new Font("Kawkab Mono", 7f, (FontStyle)0), Brushes.Black, 0f, (float)(((Control)MyProject.Forms.Form_3_VENTE.Panel_LOGO).Height + num * 16 + 10 + 20), new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("المجموع : " + Strings.LSet(Text_TOTAL_NET.Text + " درهم", 15), new Font("Kawkab Mono", 11f, (FontStyle)1), Brushes.Black, 260f, (float)(((Control)MyProject.Forms.Form_3_VENTE.Panel_LOGO).Height + num * 16 + 20 + 20), new StringFormat((StringFormatFlags)1));
				e.Graphics.DrawString("----------------------------------------------", new Font("Kawkab Mono", 7f, (FontStyle)0), Brushes.Black, 0f, (float)(((Control)MyProject.Forms.Form_3_VENTE.Panel_LOGO).Height + num * 16 + 40 + 20), new StringFormat((StringFormatFlags)8192));
				_string = "";
				_string = _string + "* مجموع الكمية : " + Label_NBR_ARTICLES.Text + "\r\n";
				_string += "\r\n";
				decimal num6 = 0m;
				decimal num7 = 0m;
				int num8 = dt_duplicata.Rows.Count - 1;
				int num9 = 0;
				while (true)
				{
					int num10 = num9;
					int num5 = num8;
					if (num10 > num5)
					{
						break;
					}
					num6 = Conversions.ToDecimal(Operators.AddObject(num6, Operators.SubtractObject(Operators.MultiplyObject(dt_duplicata.Rows[num9]["PRIX_V"], dt_duplicata.Rows[num9]["Qté"]), dt_duplicata.Rows[num9]["TOTAL_NET"])));
					num7 = Conversions.ToDecimal(Operators.AddObject(num7, Operators.MultiplyObject(dt_duplicata.Rows[num9]["PRIX_V"], dt_duplicata.Rows[num9]["Qté"])));
					num9++;
				}
				if (decimal.Compare(num6, 0m) > 0)
				{
					_string = _string + "* تخفيض    : " + Strings.RSet(Strings.FormatNumber(num6), 8) + " DH / " + Strings.FormatNumber(decimal.Multiply(decimal.Divide(num6, num7), 100m)) + " %\r\n";
					_string += "\r\n\r\n";
				}
				if (Operators.CompareString(Label_OPERATION.Text, "VENTE", TextCompare: false) == 0)
				{
					if (MyProject.Forms.Form_3_VENTE.CheckBox_AFFICHER_MODEP.Checked)
					{
						string text2 = "";
						int num11 = DataGridView_MODE_P.Rows.Count - 1;
						int num12 = 0;
						while (true)
						{
							int num13 = num12;
							int num5 = num11;
							if (num13 <= num5)
							{
								_string = _string + Strings.LSet(Conversions.ToString(Operators.ConcatenateObject("* ", DataGridView_MODE_P.Rows[num12].Cells["MODE_P"].Value)), 11) + " : " + Strings.RSet(Conversions.ToString(DataGridView_MODE_P.Rows[num12].Cells["MONTANT"].Value), 6) + " DH\r\n";
								num12++;
								continue;
							}
							break;
						}
					}
				}
				else if (Operators.CompareString(Label_OPERATION.Text, "CREDIT", TextCompare: false) == 0)
				{
					_string += "\r\n";
					_string += "-------------------------------------------\r\n";
					_string += "-------------------CREDIT------------------\r\n";
					_string += "-------------------------------------------\r\n";
					_string += "\r\n";
				}
				_string += "\r\n";
				if (Operators.CompareString(Label_CLIENT.Text, "", TextCompare: false) != 0)
				{
					_string = _string + "* الزبون    : " + Label_CLIENT.Text + "\r\n";
					_string = _string + "* الرقم     : " + Label_ID_CLIENT.Text + "\r\n";
				}
				_string = _string + "* رقم الفاتورة : " + Conversions.ToString(Conversion.Val(Label_N_TICKET.Text)) + "\r\n";
				_string = _string + "* البائع       : " + Label_CAISSIER.Text + "\r\n";
				_string += "\r\n";
				_string += MyProject.Forms.Form_3_VENTE.Text_pied.Text;
				_string += "\r\n";
				_string = _string + "         " + DateTime.Now.ToString("dd/MM/yyy HH:mm:ss") + "(" + Conversions.ToString(Conversion.Val(MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text)) + ")\r\n";
				e.Graphics.DrawString(_string, new Font("Kawkab Mono", 7f, (FontStyle)1), Brushes.Black, 260f, (float)(((Control)MyProject.Forms.Form_3_VENTE.Panel_LOGO).Height + num * 16 + 50 + 20), new StringFormat((StringFormatFlags)1));
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

	private void CL_AR_4C_PrintPage(object sender, PrintPageEventArgs e)
	{
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected Obj, but got Unknown
		//IL_00c5: Expected Obj, but got Unknown
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected Obj, but got Unknown
		//IL_010e: Expected Obj, but got Unknown
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected Obj, but got Unknown
		//IL_015b: Expected Obj, but got Unknown
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d8: Expected Obj, but got Unknown
		//IL_02d8: Expected Obj, but got Unknown
		//IL_0307: Unknown result type (might be due to invalid IL or missing references)
		//IL_033b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0345: Expected Obj, but got Unknown
		//IL_0345: Expected Obj, but got Unknown
		//IL_037d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b7: Expected Obj, but got Unknown
		//IL_03b7: Expected Obj, but got Unknown
		//IL_03ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_0402: Unknown result type (might be due to invalid IL or missing references)
		//IL_040c: Expected Obj, but got Unknown
		//IL_040c: Expected Obj, but got Unknown
		//IL_0976: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b0: Expected Obj, but got Unknown
		//IL_09b0: Expected Obj, but got Unknown
		checked
		{
			try
			{
				Graphics graphics = e.Graphics;
				Image image = MyProject.Forms.Form_3_VENTE.Picture_LOGO.Image;
				Rectangle rectangle = new Rectangle(((Control)MyProject.Forms.Form_3_VENTE.Picture_LOGO).Left, ((Control)MyProject.Forms.Form_3_VENTE.Picture_LOGO).Top, ((Control)MyProject.Forms.Form_3_VENTE.Picture_LOGO).Width, ((Control)MyProject.Forms.Form_3_VENTE.Picture_LOGO).Height);
				graphics.DrawImage(image, rectangle);
				e.Graphics.DrawString("----------------------------------------------", new Font("Kawkab Mono", 7f, (FontStyle)0), Brushes.Black, 0f, (float)((Control)MyProject.Forms.Form_3_VENTE.Panel_LOGO).Height, new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("كمية |البضاعة              |الثمن  |المجموع              ", new Font("Kawkab Mono", 6f, (FontStyle)0), Brushes.Black, 260f, (float)(((Control)MyProject.Forms.Form_3_VENTE.Panel_LOGO).Height + 10), new StringFormat((StringFormatFlags)1));
				e.Graphics.DrawString("----------------------------------------------", new Font("Kawkab Mono", 7f, (FontStyle)0), Brushes.Black, 0f, (float)(((Control)MyProject.Forms.Form_3_VENTE.Panel_LOGO).Height + 18), new StringFormat((StringFormatFlags)8192));
				string text = "";
				int num = 0;
				int num2 = DataGridView1.RowCount - 1;
				int num3 = 0;
				while (true)
				{
					int num4 = num3;
					int num5 = num2;
					if (num4 > num5)
					{
						break;
					}
					text = Strings.LSet(Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(DataGridView1.Rows[num3].Cells["Qté"].Value))), 4) + Strings.LSet(Conversions.ToString(DataGridView1.Rows[num3].Cells["Article"].Value), 18) + "  " + Strings.LSet(Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(DataGridView1.Rows[num3].Cells["Prix_V"].Value))), 7) + Strings.LSet(Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(DataGridView1.Rows[num3].Cells["TOTAL_NET"].Value))), 7);
					e.Graphics.DrawString(text, new Font("Kawkab Mono", 7f, (FontStyle)1), Brushes.Black, 260f, (float)(((Control)MyProject.Forms.Form_3_VENTE.Panel_LOGO).Height + num * 16 + 10 + 20), new StringFormat((StringFormatFlags)1));
					num++;
					num3++;
				}
				e.Graphics.DrawString("----------------------------------------------", new Font("Kawkab Mono", 7f, (FontStyle)0), Brushes.Black, 0f, (float)(((Control)MyProject.Forms.Form_3_VENTE.Panel_LOGO).Height + num * 16 + 10 + 20), new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("المجموع : " + Strings.LSet(Text_TOTAL_NET.Text + " درهم", 15), new Font("Kawkab Mono", 11f, (FontStyle)1), Brushes.Black, 260f, (float)(((Control)MyProject.Forms.Form_3_VENTE.Panel_LOGO).Height + num * 16 + 20 + 20), new StringFormat((StringFormatFlags)1));
				e.Graphics.DrawString("----------------------------------------------", new Font("Kawkab Mono", 7f, (FontStyle)0), Brushes.Black, 0f, (float)(((Control)MyProject.Forms.Form_3_VENTE.Panel_LOGO).Height + num * 16 + 40 + 20), new StringFormat((StringFormatFlags)8192));
				_string = "";
				_string = _string + "* مجموع الكمية : " + Label_NBR_ARTICLES.Text + "\r\n";
				_string += "\r\n";
				decimal num6 = 0m;
				decimal num7 = 0m;
				int num8 = dt_duplicata.Rows.Count - 1;
				int num9 = 0;
				while (true)
				{
					int num10 = num9;
					int num5 = num8;
					if (num10 > num5)
					{
						break;
					}
					num6 = Conversions.ToDecimal(Operators.AddObject(num6, Operators.SubtractObject(Operators.MultiplyObject(dt_duplicata.Rows[num9]["PRIX_V"], dt_duplicata.Rows[num9]["Qté"]), dt_duplicata.Rows[num9]["TOTAL_NET"])));
					num7 = Conversions.ToDecimal(Operators.AddObject(num7, Operators.MultiplyObject(dt_duplicata.Rows[num9]["PRIX_V"], dt_duplicata.Rows[num9]["Qté"])));
					num9++;
				}
				if (decimal.Compare(num6, 0m) > 0)
				{
					_string = _string + "* تخفيض    : " + Strings.RSet(Strings.FormatNumber(num6), 8) + " DH / " + Strings.FormatNumber(decimal.Multiply(decimal.Divide(num6, num7), 100m)) + " %\r\n";
					_string += "\r\n\r\n";
				}
				if (Operators.CompareString(Label_OPERATION.Text, "VENTE", TextCompare: false) == 0)
				{
					if (MyProject.Forms.Form_3_VENTE.CheckBox_AFFICHER_MODEP.Checked)
					{
						string text2 = "";
						int num11 = DataGridView_MODE_P.Rows.Count - 1;
						int num12 = 0;
						while (true)
						{
							int num13 = num12;
							int num5 = num11;
							if (num13 <= num5)
							{
								_string = _string + Strings.LSet(Conversions.ToString(Operators.ConcatenateObject("* ", DataGridView_MODE_P.Rows[num12].Cells["MODE_P"].Value)), 11) + " : " + Strings.RSet(Conversions.ToString(DataGridView_MODE_P.Rows[num12].Cells["MONTANT"].Value), 6) + " DH\r\n";
								num12++;
								continue;
							}
							break;
						}
					}
				}
				else if (Operators.CompareString(Label_OPERATION.Text, "CREDIT", TextCompare: false) == 0)
				{
					_string += "\r\n";
					_string += "-------------------------------------------\r\n";
					_string += "-------------------CREDIT------------------\r\n";
					_string += "-------------------------------------------\r\n";
					_string += "\r\n";
				}
				_string += "\r\n";
				if (Operators.CompareString(Label_CLIENT.Text, "", TextCompare: false) != 0)
				{
					_string = _string + "* الزبون    : " + Label_CLIENT.Text + "\r\n";
					_string = _string + "* الرقم     : " + Label_ID_CLIENT.Text + "\r\n";
				}
				_string = _string + "* رقم الفاتورة : " + Conversions.ToString(Conversion.Val(Label_N_TICKET.Text)) + "\r\n";
				_string = _string + "* البائع       : " + Label_CAISSIER.Text + "\r\n";
				_string += "\r\n";
				_string += MyProject.Forms.Form_3_VENTE.Text_pied.Text;
				_string += "\r\n";
				_string = _string + "         " + DateTime.Now.ToString("dd/MM/yyy HH:mm:ss") + "(" + Conversions.ToString(Conversion.Val(MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text)) + ")\r\n";
				e.Graphics.DrawString(_string, new Font("Kawkab Mono", 7f, (FontStyle)1), Brushes.Black, 260f, (float)(((Control)MyProject.Forms.Form_3_VENTE.Panel_LOGO).Height + num * 16 + 50 + 20), new StringFormat((StringFormatFlags)1));
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

	private void BON_RETOUR_PrintPage(object sender, PrintPageEventArgs e)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected Obj, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected Obj, but got Unknown
		//IL_0093: Expected Obj, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected Obj, but got Unknown
		//IL_00cd: Expected Obj, but got Unknown
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Expected Obj, but got Unknown
		//IL_01f3: Expected Obj, but got Unknown
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Expected Obj, but got Unknown
		//IL_025a: Expected Obj, but got Unknown
		//IL_0292: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Expected Obj, but got Unknown
		//IL_02cd: Expected Obj, but got Unknown
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0315: Unknown result type (might be due to invalid IL or missing references)
		//IL_031f: Expected Obj, but got Unknown
		//IL_031f: Expected Obj, but got Unknown
		//IL_0439: Unknown result type (might be due to invalid IL or missing references)
		//IL_046a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0474: Expected Obj, but got Unknown
		//IL_0474: Expected Obj, but got Unknown
		checked
		{
			try
			{
				e.Graphics.FillRectangle((Brush)new SolidBrush(Color.Black), 0, 0, 260, 20);
				string text = Label_OPERATION.Text;
				e.Graphics.DrawString(text, new Font("Lucida Console", 12f, (FontStyle)1), Brushes.White, Convert.ToSingle(130f - e.Graphics.MeasureString(text, new Font("Lucida Console", 12f, (FontStyle)1)).Width / 2f), 2f, new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("-------------------------------------------", new Font("Inconsolata Condensed", 11f, (FontStyle)0), Brushes.Black, 0f, 80f, new StringFormat((StringFormatFlags)8192));
				string text2 = "";
				int num = 0;
				int num2 = DataGridView1.RowCount - 1;
				int num3 = 0;
				while (true)
				{
					int num4 = num3;
					int num5 = num2;
					if (num4 > num5)
					{
						break;
					}
					text2 = Strings.LSet(Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(DataGridView1.Rows[num3].Cells["Qté"].Value))) + "x", 7) + Strings.LSet(Conversions.ToString(DataGridView1.Rows[num3].Cells["Article"].Value), 27) + " " + Strings.RSet(Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(DataGridView1.Rows[num3].Cells["TOTAL_NET"].Value))), 8);
					e.Graphics.DrawString(text2, new Font("Inconsolata Condensed", 11f, (FontStyle)1), Brushes.Black, 0f, (float)(((Control)MyProject.Forms.Form_3_VENTE.Panel_LOGO).Height + num * 16 + 10), new StringFormat((StringFormatFlags)8192));
					num++;
					num3++;
				}
				e.Graphics.DrawString("-------------------------------------------", new Font("Inconsolata Condensed", 11f, (FontStyle)0), Brushes.Black, 0f, (float)(((Control)MyProject.Forms.Form_3_VENTE.Panel_LOGO).Height + num * 16 + 10), new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("TOTAL NET: " + Strings.RSet(Text_TOTAL_NET.Text + " DH", 12), new Font("Inconsolata ExtraBold", 16f, (FontStyle)1), Brushes.Black, 0f, (float)(((Control)MyProject.Forms.Form_3_VENTE.Panel_LOGO).Height + num * 16 + 20), new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("-------------------------------------------", new Font("Inconsolata Condensed", 11f, (FontStyle)0), Brushes.Black, 0f, (float)(((Control)MyProject.Forms.Form_3_VENTE.Panel_LOGO).Height + num * 16 + 40), new StringFormat((StringFormatFlags)8192));
				text = "";
				text += "\r\n";
				if (Operators.CompareString(Label_CLIENT.Text, "", TextCompare: false) != 0)
				{
					text = text + "* CLIENT    : " + Label_CLIENT.Text + "\r\n";
					text = text + "* ID        : " + Label_ID_CLIENT.Text + "\r\n";
				}
				text = text + "* N° TICKET : " + Label_N_TICKET.Text + "\r\n";
				text = text + "* CAISSIER  : " + Label_CAISSIER.Text + "\r\n";
				text += "\r\n";
				text += MyProject.Forms.Form_3_VENTE.Text_pied.Text;
				text += "\r\n";
				text = text + "            " + Conversions.ToDate(Label_DATES.Text).ToString("dd/MM/yyy HH:mm:ss") + "\r\n";
				e.Graphics.DrawString(text, new Font("Inconsolata Condensed", 11f, (FontStyle)1), Brushes.Black, 0f, (float)(((Control)MyProject.Forms.Form_3_VENTE.Panel_LOGO).Height + num * 16 + 50), new StringFormat((StringFormatFlags)8192));
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
		//IL_07d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e0: Expected Obj, but got Unknown
		//IL_03f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ff: Expected Obj, but got Unknown
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected Obj, but got Unknown
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Expected Obj, but got Unknown
		//IL_04da: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e4: Expected Obj, but got Unknown
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Expected Obj, but got Unknown
		//IL_0562: Unknown result type (might be due to invalid IL or missing references)
		//IL_056c: Expected Obj, but got Unknown
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Expected Obj, but got Unknown
		//IL_05ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f4: Expected Obj, but got Unknown
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_034d: Expected Obj, but got Unknown
		//IL_0672: Unknown result type (might be due to invalid IL or missing references)
		//IL_067c: Expected Obj, but got Unknown
		//IL_06fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0704: Expected Obj, but got Unknown
		try
		{
			NewLateBinding.LateSet(sender, null, "Enabled", new object[1] { false }, null, null);
			if (DataGridView1.Rows.Count == 0)
			{
				NewLateBinding.LateSet(sender, null, "Enabled", new object[1] { true }, null, null);
				return;
			}
			if (Operators.CompareString(Label_OPERATION.Text, "VENTE", TextCompare: false) == 0)
			{
				if (Operators.CompareString(MyProject.Forms.Form_0_TEMPLATE.TextBox_BRANCHEMENT.Text, "USB", TextCompare: false) == 0)
				{
					if (Operators.CompareString(MyProject.Forms.Form_3_VENTE.Text_MODELE_TICKET.Text, "FR_3C", TextCompare: false) == 0)
					{
						if (Operators.CompareString(Text_PRINTER_SOLDER.Text, "", TextCompare: false) != 0)
						{
							CL_FR_3C.PrinterSettings.PrinterName = Text_PRINTER_SOLDER.Text;
						}
						CL_FR_3C.PrintController = (PrintController)new StandardPrintController();
						CL_FR_3C.Print();
					}
					else if (Operators.CompareString(MyProject.Forms.Form_3_VENTE.Text_MODELE_TICKET.Text, "FR_4C", TextCompare: false) == 0)
					{
						if (Operators.CompareString(Text_PRINTER_SOLDER.Text, "", TextCompare: false) != 0)
						{
							CL_FR_4C.PrinterSettings.PrinterName = Text_PRINTER_SOLDER.Text;
						}
						CL_FR_4C.PrintController = (PrintController)new StandardPrintController();
						CL_FR_4C.Print();
					}
					else if (Operators.CompareString(MyProject.Forms.Form_3_VENTE.Text_MODELE_TICKET.Text, "FR_2L", TextCompare: false) == 0)
					{
						if (Operators.CompareString(Text_PRINTER_SOLDER.Text, "", TextCompare: false) != 0)
						{
							CL_FR_2L.PrinterSettings.PrinterName = Text_PRINTER_SOLDER.Text;
						}
						CL_FR_2L.PrintController = (PrintController)new StandardPrintController();
						CL_FR_2L.Print();
					}
					else if (Operators.CompareString(MyProject.Forms.Form_3_VENTE.Text_MODELE_TICKET.Text, "AR_3C", TextCompare: false) == 0)
					{
						if (Operators.CompareString(Text_PRINTER_SOLDER.Text, "", TextCompare: false) != 0)
						{
							CL_AR_3C.PrinterSettings.PrinterName = Text_PRINTER_SOLDER.Text;
						}
						CL_AR_3C.PrintController = (PrintController)new StandardPrintController();
						CL_AR_3C.Print();
					}
					else if (Operators.CompareString(MyProject.Forms.Form_3_VENTE.Text_MODELE_TICKET.Text, "AR_4C", TextCompare: false) == 0)
					{
						if (Operators.CompareString(Text_PRINTER_SOLDER.Text, "", TextCompare: false) != 0)
						{
							CL_AR_4C.PrinterSettings.PrinterName = Text_PRINTER_SOLDER.Text;
						}
						CL_AR_4C.PrintController = (PrintController)new StandardPrintController();
						CL_AR_4C.Print();
					}
				}
				else
				{
					CL_COM();
				}
			}
			else if (Label_OPERATION.Text.Contains("RETOUR"))
			{
				if (Operators.CompareString(MyProject.Forms.Form_0_TEMPLATE.TextBox_BRANCHEMENT.Text, "USB", TextCompare: false) == 0)
				{
					if (Operators.CompareString(Text_PRINTER_SOLDER.Text, "", TextCompare: false) != 0)
					{
						CL_FR_3C.PrinterSettings.PrinterName = Text_PRINTER_SOLDER.Text;
					}
					BON_RETOUR.PrintController = (PrintController)new StandardPrintController();
					BON_RETOUR.Print();
					BON_RETOUR.Print();
				}
			}
			else if (Operators.CompareString(Label_OPERATION.Text, "CREDIT", TextCompare: false) == 0)
			{
				if (Operators.CompareString(MyProject.Forms.Form_0_TEMPLATE.TextBox_BRANCHEMENT.Text, "USB", TextCompare: false) == 0)
				{
					if (Operators.CompareString(MyProject.Forms.Form_3_VENTE.Text_MODELE_TICKET.Text, "FR_3C", TextCompare: false) == 0)
					{
						if (Operators.CompareString(Text_PRINTER_SOLDER.Text, "", TextCompare: false) != 0)
						{
							CL_FR_3C.PrinterSettings.PrinterName = Text_PRINTER_SOLDER.Text;
						}
						CL_FR_3C.PrintController = (PrintController)new StandardPrintController();
						CL_FR_3C.Print();
					}
					else if (Operators.CompareString(MyProject.Forms.Form_3_VENTE.Text_MODELE_TICKET.Text, "FR_4C", TextCompare: false) == 0)
					{
						if (Operators.CompareString(Text_PRINTER_SOLDER.Text, "", TextCompare: false) != 0)
						{
							CL_FR_4C.PrinterSettings.PrinterName = Text_PRINTER_SOLDER.Text;
						}
						CL_FR_4C.PrintController = (PrintController)new StandardPrintController();
						CL_FR_4C.Print();
					}
					else if (Operators.CompareString(MyProject.Forms.Form_3_VENTE.Text_MODELE_TICKET.Text, "FR_2L", TextCompare: false) == 0)
					{
						if (Operators.CompareString(Text_PRINTER_SOLDER.Text, "", TextCompare: false) != 0)
						{
							CL_FR_2L.PrinterSettings.PrinterName = Text_PRINTER_SOLDER.Text;
						}
						CL_FR_2L.PrintController = (PrintController)new StandardPrintController();
						CL_FR_2L.Print();
					}
					else if (Operators.CompareString(MyProject.Forms.Form_3_VENTE.Text_MODELE_TICKET.Text, "AR_3C", TextCompare: false) == 0)
					{
						if (Operators.CompareString(Text_PRINTER_SOLDER.Text, "", TextCompare: false) != 0)
						{
							CL_AR_3C.PrinterSettings.PrinterName = Text_PRINTER_SOLDER.Text;
						}
						CL_AR_3C.PrintController = (PrintController)new StandardPrintController();
						CL_AR_3C.Print();
					}
					else if (Operators.CompareString(MyProject.Forms.Form_3_VENTE.Text_MODELE_TICKET.Text, "AR_4C", TextCompare: false) == 0)
					{
						if (Operators.CompareString(Text_PRINTER_SOLDER.Text, "", TextCompare: false) != 0)
						{
							CL_AR_4C.PrinterSettings.PrinterName = Text_PRINTER_SOLDER.Text;
						}
						CL_AR_4C.PrintController = (PrintController)new StandardPrintController();
						CL_AR_4C.Print();
					}
				}
				else
				{
					CL_COM();
					CL_COM();
				}
			}
			NewLateBinding.LateSet(sender, null, "enabled", new object[1] { true }, null, null);
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
		NewLateBinding.LateSet(sender, null, "Enabled", new object[1] { true }, null, null);
	}

	private void BunifuDatePicker1_ValueChanged(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected Obj, but got Unknown
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected Obj, but got Unknown
		DataTable dataTable = new DataTable();
		MySqlDataAdapter val = new MySqlDataAdapter();
		dataTable.Clear();
		val = new MySqlDataAdapter("select       ID_TICKET,  Ticket , TOTAL_NET , OPERATION    from   TABLE_VENTES_ENTETE     Where  Dates   between   ' " + Strings.Format(((DateTimePicker)BunifuDatePicker1).Value, "yyyy-MM-dd") + " '         And    ' " + Strings.Format(((DateTimePicker)BunifuDatePicker1).Value, "yyyy-MM-dd") + " '      order by ID DESC    ", Module1.cn_SQL);
		((DbDataAdapter)(object)val).Fill(dataTable);
		DataGridView3.Rows.Clear();
		checked
		{
			int num = dataTable.Rows.Count - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 <= num4)
				{
					DataGridView3.Rows.Add(new object[4]
					{
						dataTable.Rows[num2]["ID_TICKET"].ToString(),
						dataTable.Rows[num2]["Ticket"].ToString(),
						Conversions.ToDecimal(dataTable.Rows[num2]["TOTAL_NET"].ToString()),
						dataTable.Rows[num2]["OPERATION"].ToString()
					});
					num2++;
					continue;
				}
				break;
			}
		}
	}

	private void Button5_Click(object sender, EventArgs e)
	{
		((DateTimePicker)BunifuDatePicker1).Value = ((DateTimePicker)BunifuDatePicker1).Value.AddDays(-1.0);
	}

	private void Button20_Click(object sender, EventArgs e)
	{
		((DateTimePicker)BunifuDatePicker1).Value = ((DateTimePicker)BunifuDatePicker1).Value.AddDays(1.0);
	}

	private void DUPLICATA_AVOIR_PrintPage(object sender, PrintPageEventArgs e)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected Obj, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected Obj, but got Unknown
		//IL_0093: Expected Obj, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected Obj, but got Unknown
		//IL_00cd: Expected Obj, but got Unknown
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Expected Obj, but got Unknown
		//IL_01f3: Expected Obj, but got Unknown
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Expected Obj, but got Unknown
		//IL_025a: Expected Obj, but got Unknown
		//IL_0292: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Expected Obj, but got Unknown
		//IL_02cd: Expected Obj, but got Unknown
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0315: Unknown result type (might be due to invalid IL or missing references)
		//IL_031f: Expected Obj, but got Unknown
		//IL_031f: Expected Obj, but got Unknown
		//IL_0439: Unknown result type (might be due to invalid IL or missing references)
		//IL_046a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0474: Expected Obj, but got Unknown
		//IL_0474: Expected Obj, but got Unknown
		checked
		{
			try
			{
				e.Graphics.FillRectangle((Brush)new SolidBrush(Color.Black), 0, 0, 260, 20);
				string text = Label_OPERATION.Text;
				e.Graphics.DrawString(text, new Font("Lucida Console", 12f, (FontStyle)1), Brushes.White, Convert.ToSingle(130f - e.Graphics.MeasureString(text, new Font("Lucida Console", 12f, (FontStyle)1)).Width / 2f), 2f, new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("-------------------------------------------", new Font("Inconsolata Condensed", 11f, (FontStyle)0), Brushes.Black, 0f, 80f, new StringFormat((StringFormatFlags)8192));
				string text2 = "";
				int num = 0;
				int num2 = DataGridView1.RowCount - 1;
				int num3 = 0;
				while (true)
				{
					int num4 = num3;
					int num5 = num2;
					if (num4 > num5)
					{
						break;
					}
					text2 = Strings.LSet(Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(DataGridView1.Rows[num3].Cells["Qté"].Value))) + "x", 7) + Strings.LSet(Conversions.ToString(DataGridView1.Rows[num3].Cells["Article"].Value), 27) + " " + Strings.RSet(Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(DataGridView1.Rows[num3].Cells["TOTAL_NET"].Value))), 8);
					e.Graphics.DrawString(text2, new Font("Inconsolata Condensed", 11f, (FontStyle)1), Brushes.Black, 0f, (float)(((Control)MyProject.Forms.Form_3_VENTE.Panel_LOGO).Height + num * 16 + 10), new StringFormat((StringFormatFlags)8192));
					num++;
					num3++;
				}
				e.Graphics.DrawString("-------------------------------------------", new Font("Inconsolata Condensed", 11f, (FontStyle)0), Brushes.Black, 0f, (float)(((Control)MyProject.Forms.Form_3_VENTE.Panel_LOGO).Height + num * 16 + 10), new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("TOTAL NET: " + Strings.RSet(Text_TOTAL_NET.Text + " DH", 12), new Font("Inconsolata ExtraBold", 16f, (FontStyle)1), Brushes.Black, 0f, (float)(((Control)MyProject.Forms.Form_3_VENTE.Panel_LOGO).Height + num * 16 + 20), new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("-------------------------------------------", new Font("Inconsolata Condensed", 11f, (FontStyle)0), Brushes.Black, 0f, (float)(((Control)MyProject.Forms.Form_3_VENTE.Panel_LOGO).Height + num * 16 + 40), new StringFormat((StringFormatFlags)8192));
				text = "";
				text += "\r\n";
				if (Operators.CompareString(Label_CLIENT.Text, "", TextCompare: false) != 0)
				{
					text = text + "* CLIENT    : " + Label_CLIENT.Text + "\r\n";
					text = text + "* ID        : " + Label_ID_CLIENT.Text + "\r\n";
				}
				text = text + "* N° TICKET : " + Label_N_TICKET.Text + "\r\n";
				text = text + "* CAISSIER  : " + Label_CAISSIER.Text + "\r\n";
				text += "\r\n";
				text += MyProject.Forms.Form_3_VENTE.Text_pied.Text;
				text += "\r\n";
				text = text + "            " + Conversions.ToDate(Label_DATES.Text).ToString("dd/MM/yyy HH:mm:ss") + "\r\n";
				e.Graphics.DrawString(text, new Font("Inconsolata Condensed", 11f, (FontStyle)1), Brushes.Black, 0f, (float)(((Control)MyProject.Forms.Form_3_VENTE.Panel_LOGO).Height + num * 16 + 50), new StringFormat((StringFormatFlags)8192));
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

	private void Panel_FONCTIONS_Paint(object sender, PaintEventArgs e)
	{
	}

	private void DataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
	}

	private void DataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected Obj, but got Unknown
		//IL_0462: Unknown result type (might be due to invalid IL or missing references)
		//IL_0468: Expected Obj, but got Unknown
		//IL_04c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ca: Expected Obj, but got Unknown
		//IL_058a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0590: Expected Obj, but got Unknown
		try
		{
			dt_duplicata.Clear();
			da_duplicata = new MySqlDataAdapter("select  CODE,ARTICLE,PRIX_V,Qté,REMISE,TOTAL_NET,ID_CLIENT,CLIENT,CAISSIER,Ticket,DATES,Heure,OPERATION    from   TABLE_VENTES_JOURNAL     Where    ID_TICKET  = '" + Strings.Trim(Conversions.ToString(DataGridView3.Rows[((DataGridViewBand)DataGridView3.CurrentRow).Index].Cells[0].Value)) + "'         and  Dates   between   ' " + Strings.Format(((DateTimePicker)BunifuDatePicker1).Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(((DateTimePicker)BunifuDatePicker1).Value, "yyyy-MM-dd") + " '   ", Module1.cn_SQL);
			((DbDataAdapter)(object)da_duplicata).Fill(dt_duplicata);
			DataGridView1.DataSource = dt_duplicata;
			if (dt_duplicata.Rows.Count != 0)
			{
				decimal num = (from DataGridViewRow row in (IEnumerable)DataGridView1.Rows
					where decimal.Compare(Conversions.ToDecimal(row.Cells["Qté"].Value), 0m) != 0
					select row).Sum([SpecialName] (DataGridViewRow row) => Conversions.ToDecimal(row.Cells["Qté"].Value));
				Label_NBR_ARTICLES.Text = Conversions.ToString(num);
				if (Operators.CompareString(dt_duplicata.Rows[0]["CLIENT"].ToString(), "", TextCompare: false) != 0)
				{
					Label_ID_CLIENT.Text = dt_duplicata.Rows[0]["ID_CLIENT"].ToString();
					Label_CLIENT.Text = dt_duplicata.Rows[0]["CLIENT"].ToString().ToUpper();
				}
				else
				{
					Label_ID_CLIENT.Text = "";
					Label_CLIENT.Text = "";
				}
				Label_CAISSIER.Text = dt_duplicata.Rows[0]["CAISSIER"].ToString();
				Label_N_TICKET.Text = dt_duplicata.Rows[0]["Ticket"].ToString();
				Label_DATES.Text = Conversions.ToDate(dt_duplicata.Rows[0]["DATES"].ToString()).ToString("dd/MM/yyy") + " " + dt_duplicata.Rows[0]["HEURE"].ToString();
				Label_OPERATION.Text = dt_duplicata.Rows[0]["OPERATION"].ToString();
			}
			else
			{
				Label_NBR_ARTICLES.Text = "";
				Label_ID_CLIENT.Text = "";
				Label_CLIENT.Text = "";
				Label_CAISSIER.Text = "";
				Label_N_TICKET.Text = "";
				Label_DATES.Text = "";
				Label_OPERATION.Text = "";
			}
			double num2 = 0.0;
			if (Module1.cn_SQL.State != ConnectionState.Open)
			{
				Module1.cn_SQL.Open();
			}
			MySqlCommand val = new MySqlCommand("select sum(TOTAL_NET) as n     from     TABLE_VENTES_JOURNAL     Where    ID_TICKET  = '" + Strings.Trim(Conversions.ToString(DataGridView3.Rows[((DataGridViewBand)DataGridView3.CurrentRow).Index].Cells[0].Value)) + "'           and  Dates   between   ' " + Strings.Format(((DateTimePicker)BunifuDatePicker1).Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(((DateTimePicker)BunifuDatePicker1).Value, "yyyy-MM-dd") + " '   ", Module1.cn_SQL);
			num2 = ((val.ExecuteScalar() != DBNull.Value) ? Conversions.ToDouble(val.ExecuteScalar()) : 0.0);
			Module1.cn_SQL.Close();
			Text_TOTAL_NET.Text = Strings.FormatNumber(num2);
			DataTable dataTable = new DataTable();
			MySqlDataAdapter val2 = new MySqlDataAdapter();
			dataTable.Clear();
			val2 = new MySqlDataAdapter("select  MONTANT,MODE_P    from   TABLE_VENTES_REGLEMENTS     Where    ID_TICKET  = '" + Strings.Trim(Conversions.ToString(DataGridView3.Rows[((DataGridViewBand)DataGridView3.CurrentRow).Index].Cells[0].Value)) + "'         and  Dates   between   ' " + Strings.Format(((DateTimePicker)BunifuDatePicker1).Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(((DateTimePicker)BunifuDatePicker1).Value, "yyyy-MM-dd") + " '   ", Module1.cn_SQL);
			((DbDataAdapter)(object)val2).Fill(dataTable);
			DataGridView_MODE_P.DataSource = dataTable;
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

	private void Button_A4_Click(object sender, EventArgs e)
	{
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected Obj, but got Unknown
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected Obj, but got Unknown
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Expected Obj, but got Unknown
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Expected Obj, but got Unknown
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Expected Obj, but got Unknown
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Expected Obj, but got Unknown
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Expected Obj, but got Unknown
		//IL_0346: Unknown result type (might be due to invalid IL or missing references)
		//IL_0350: Expected Obj, but got Unknown
		//IL_0375: Unknown result type (might be due to invalid IL or missing references)
		//IL_037f: Expected Obj, but got Unknown
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c8: Expected Obj, but got Unknown
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0307: Expected Obj, but got Unknown
		//IL_04d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e0: Expected Obj, but got Unknown
		checked
		{
			try
			{
				if (DataGridView1.Rows.Count == 0)
				{
					NewLateBinding.LateSet(sender, null, "Enabled", new object[1] { true }, null, null);
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
				MemoryStream memoryStream = new MemoryStream();
				MyProject.Forms.Form_3_VENTE.Picture_LOGO.Image.Save((Stream)memoryStream, ImageFormat.Jpeg);
				byte[] inArray = memoryStream.ToArray();
				string text = Convert.ToBase64String(inArray);
				string text2 = text;
				text = null;
				memoryStream.Dispose();
				((Report)MyProject.Forms.Report_TICKET_A4.ReportViewer1.LocalReport).SetParameters(new ReportParameter("ReportLogo", text2, true));
				((Report)MyProject.Forms.Report_TICKET_A4.ReportViewer1.LocalReport).SetParameters(new ReportParameter("ReportLogoMimeType", "image/jpeg", true));
				Microsoft.Reporting.WinForms.LocalReport val = MyProject.Forms.Report_TICKET_A4.ReportViewer1.LocalReport;
				string text3;
				if ((Operators.CompareString(Label_OPERATION.Text, "VENTE", TextCompare: false) == 0) | (Operators.CompareString(Label_OPERATION.Text, "CREDIT", TextCompare: false) == 0))
				{
					text3 = "BON DE LIVRAISON";
				}
				else
				{
					text3 = (Label_OPERATION.Text.Contains("RETOUR") ? "BON D'AVOIR" : "");
				}
				((Report)val).SetParameters(new ReportParameter("TITRE_DOC", text3));
				((Report)MyProject.Forms.Report_TICKET_A4.ReportViewer1.LocalReport).SetParameters(new ReportParameter("NUM", Label_N_TICKET.Text));
				((Report)MyProject.Forms.Report_TICKET_A4.ReportViewer1.LocalReport).SetParameters(new ReportParameter("DATES", "Le " + Conversions.ToDate(Label_DATES.Text).ToString("dd/MM/yyy HH:mm:ss")));
				DataTable dataTable = new DataTable();
				MySqlDataAdapter val2 = new MySqlDataAdapter();
				dataTable.Clear();
				val2 = new MySqlDataAdapter("select    ID_CLIENT,CLIENT,ICE,ADRESSE   from TABLE_CLIENTS     Where    ID_CLIENT = '" + Label_ID_CLIENT.Text + "'        ", Module1.cn_SQL);
				((DbDataAdapter)(object)val2).Fill(dataTable);
				if (dataTable.Rows.Count != 0)
				{
					((Report)MyProject.Forms.Report_TICKET_A4.ReportViewer1.LocalReport).SetParameters(new ReportParameter("CLIENT", dataTable.Rows[0]["CLIENT"].ToString() + " (" + dataTable.Rows[0]["ID_CLIENT"].ToString() + ")"));
					((Report)MyProject.Forms.Report_TICKET_A4.ReportViewer1.LocalReport).SetParameters(new ReportParameter("ADRESSE", dataTable.Rows[0]["ADRESSE"].ToString()));
				}
				((Report)MyProject.Forms.Report_TICKET_A4.ReportViewer1.LocalReport).SetParameters(new ReportParameter("TOTAL_NET", Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(Text_TOTAL_NET.Text))) + " DH"));
				((Report)MyProject.Forms.Report_TICKET_A4.ReportViewer1.LocalReport).SetParameters(new ReportParameter("PIED_DOC", Text_pied_doc.Text));
				DataTable dataTable2 = new DataTable();
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
					dataTable2.Columns.Add(DataGridView1.Columns[num2].Name.ToString());
					dataTable2.Columns[DataGridView1.Columns[num2].Name.ToString()].Caption = DataGridView1.Columns[num2].HeaderText.ToString();
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
					dataTable2.Rows.Add();
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
						dataTable2.Rows[num6][num9] = DataGridView1.Rows[num6].Cells[num9].Value.ToString();
						num9++;
					}
					num6++;
				}
				ReportDataSource item = new ReportDataSource("DataSet1", dataTable2);
				((Collection<ReportDataSource>)(object)MyProject.Forms.Report_TICKET_A4.ReportViewer1.LocalReport.DataSources).Clear();
				((Collection<ReportDataSource>)(object)MyProject.Forms.Report_TICKET_A4.ReportViewer1.LocalReport.DataSources).Add(item);
				MyProject.Forms.Report_TICKET_A4.ReportViewer1.RefreshReport();
				MyProject.Forms.Report_TICKET_A4.ReportViewer1.SetDisplayMode((DisplayMode)1);
				MyProject.Forms.Report_TICKET_A4.ReportViewer1.ZoomMode = (ZoomMode)2;
				MyProject.Forms.Report_TICKET_A4.ReportViewer1.ZoomPercent = 25;
				((Control)MyProject.Forms.Report_TICKET_A4).Show();
				Module1._QUITTER_PATIENTER = true;
				((Control)MyProject.Forms.Report_TICKET_A4).Show();
				((Form)MyProject.Forms.Report_TICKET_A4).TopMost = true;
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

	private void Button_A5_Click(object sender, EventArgs e)
	{
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected Obj, but got Unknown
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected Obj, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected Obj, but got Unknown
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Expected Obj, but got Unknown
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Expected Obj, but got Unknown
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Expected Obj, but got Unknown
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02de: Expected Obj, but got Unknown
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Expected Obj, but got Unknown
		//IL_0345: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Expected Obj, but got Unknown
		//IL_0374: Unknown result type (might be due to invalid IL or missing references)
		//IL_037e: Expected Obj, but got Unknown
		//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ad: Expected Obj, but got Unknown
		//IL_03eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f5: Expected Obj, but got Unknown
		//IL_041a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0424: Expected Obj, but got Unknown
		//IL_04ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b6: Expected Obj, but got Unknown
		//IL_047c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0486: Expected Obj, but got Unknown
		//IL_0610: Unknown result type (might be due to invalid IL or missing references)
		//IL_0617: Expected Obj, but got Unknown
		checked
		{
			try
			{
				if (DataGridView1.Rows.Count == 0)
				{
					NewLateBinding.LateSet(sender, null, "Enabled", new object[1] { true }, null, null);
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
				MemoryStream memoryStream = new MemoryStream();
				MyProject.Forms.Form_3_VENTE.Picture_LOGO.Image.Save((Stream)memoryStream, ImageFormat.Jpeg);
				byte[] inArray = memoryStream.ToArray();
				string text = Convert.ToBase64String(inArray);
				string text2 = text;
				text = null;
				memoryStream.Dispose();
				((Report)MyProject.Forms.Report_TICKET_A5.ReportViewer1.LocalReport).SetParameters(new ReportParameter("ReportLogo", text2, true));
				((Report)MyProject.Forms.Report_TICKET_A5.ReportViewer1.LocalReport).SetParameters(new ReportParameter("ReportLogoMimeType", "image/jpeg", true));
				QREncoder = new QRCodeEncoder();
				QREncoder.QRCodeForegroundColor = Color.Black;
				QREncoder.QRCodeBackgroundColor = Color.White;
				QREncoder.QRCodeScale = 2;
				QREncoder.QRCodeVersion = 1;
				QREncoder.QRCodeEncodeMode = (ThoughtWorks.QRCode.Codec.QRCodeEncoder.ENCODE_MODE)2;
				QREncoder.QRCodeErrorCorrect = (ThoughtWorks.QRCode.Codec.QRCodeEncoder.ERROR_CORRECTION)0;
				QRimg = (Image)(object)QREncoder.Encode(Strings.Trim(Conversions.ToString(DataGridView3.Rows[((DataGridViewBand)DataGridView3.CurrentRow).Index].Cells["ID_TICKET"].Value)));
				QRbitmap = new Bitmap(QRimg);
				barcodeImage = QRbitmap;
				MemoryStream memoryStream2 = new MemoryStream();
				((Image)barcodeImage).Save((Stream)memoryStream2, ImageFormat.Jpeg);
				byte[] inArray2 = memoryStream2.ToArray();
				string text3 = Convert.ToBase64String(inArray2);
				string text4 = text3;
				text3 = null;
				memoryStream2.Dispose();
				((Report)MyProject.Forms.Report_TICKET_A5.ReportViewer1.LocalReport).SetParameters(new ReportParameter("ReportLogo_QR", text4, true));
				((Report)MyProject.Forms.Report_TICKET_A5.ReportViewer1.LocalReport).SetParameters(new ReportParameter("ReportLogoMimeType_QR", "image/jpeg", true));
				Microsoft.Reporting.WinForms.LocalReport val = MyProject.Forms.Report_TICKET_A5.ReportViewer1.LocalReport;
				string text5;
				if ((Operators.CompareString(Label_OPERATION.Text, "VENTE", TextCompare: false) == 0) | (Operators.CompareString(Label_OPERATION.Text, "CREDIT", TextCompare: false) == 0))
				{
					text5 = "BON DE LIVRAISON";
				}
				else
				{
					text5 = (Label_OPERATION.Text.Contains("RETOUR") ? "BON D'AVOIR" : "");
				}
				((Report)val).SetParameters(new ReportParameter("TITRE_DOC", text5));
				((Report)MyProject.Forms.Report_TICKET_A5.ReportViewer1.LocalReport).SetParameters(new ReportParameter("NUM", Label_N_TICKET.Text));
				((Report)MyProject.Forms.Report_TICKET_A5.ReportViewer1.LocalReport).SetParameters(new ReportParameter("DATES", Conversions.ToDate(Label_DATES.Text).ToString("dd/MM/yyy HH:mm:ss")));
				((Report)MyProject.Forms.Report_TICKET_A5.ReportViewer1.LocalReport).SetParameters(new ReportParameter("CAISSIER", Label_CAISSIER.Text));
				((Report)MyProject.Forms.Report_TICKET_A5.ReportViewer1.LocalReport).SetParameters(new ReportParameter("CLIENT", Label_CLIENT.Text));
				((Report)MyProject.Forms.Report_TICKET_A5.ReportViewer1.LocalReport).SetParameters(new ReportParameter("TOTAL_NET", Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(Text_TOTAL_NET.Text))) + " DH"));
				((Report)MyProject.Forms.Report_TICKET_A5.ReportViewer1.LocalReport).SetParameters(new ReportParameter("NBR_ARTICLES", Label_NBR_ARTICLES.Text));
				if (Operators.CompareString(Label_ID_CLIENT.Text, "", TextCompare: false) != 0)
				{
					_credit();
					((Report)MyProject.Forms.Report_TICKET_A5.ReportViewer1.LocalReport).SetParameters(new ReportParameter("CREDIT", Conversions.ToString(_total_credit) + " DH"));
				}
				((Report)MyProject.Forms.Report_TICKET_A5.ReportViewer1.LocalReport).SetParameters(new ReportParameter("PIED_DOC", Text_pied_doc.Text));
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
						dataTable.Rows[num6][num9] = DataGridView1.Rows[num6].Cells[num9].Value.ToString();
						num9++;
					}
					num6++;
				}
				ReportDataSource item = new ReportDataSource("DataSet1", dataTable);
				((Collection<ReportDataSource>)(object)MyProject.Forms.Report_TICKET_A5.ReportViewer1.LocalReport.DataSources).Clear();
				((Collection<ReportDataSource>)(object)MyProject.Forms.Report_TICKET_A5.ReportViewer1.LocalReport.DataSources).Add(item);
				MyProject.Forms.Report_TICKET_A5.ReportViewer1.RefreshReport();
				MyProject.Forms.Report_TICKET_A5.ReportViewer1.SetDisplayMode((DisplayMode)1);
				MyProject.Forms.Report_TICKET_A5.ReportViewer1.ZoomMode = (ZoomMode)2;
				MyProject.Forms.Report_TICKET_A5.ReportViewer1.ZoomPercent = 25;
				((Control)MyProject.Forms.Report_TICKET_A5).Show();
				Module1._QUITTER_PATIENTER = true;
				((Control)MyProject.Forms.Report_TICKET_A5).Show();
				((Form)MyProject.Forms.Report_TICKET_A5).TopMost = true;
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

	private void Button_ARABE_A5_Click(object sender, EventArgs e)
	{
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected Obj, but got Unknown
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected Obj, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected Obj, but got Unknown
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Expected Obj, but got Unknown
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Expected Obj, but got Unknown
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Expected Obj, but got Unknown
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02de: Expected Obj, but got Unknown
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Expected Obj, but got Unknown
		//IL_0345: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Expected Obj, but got Unknown
		//IL_0374: Unknown result type (might be due to invalid IL or missing references)
		//IL_037e: Expected Obj, but got Unknown
		//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ad: Expected Obj, but got Unknown
		//IL_03eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f5: Expected Obj, but got Unknown
		//IL_041a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0424: Expected Obj, but got Unknown
		//IL_04ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b6: Expected Obj, but got Unknown
		//IL_047c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0486: Expected Obj, but got Unknown
		//IL_0610: Unknown result type (might be due to invalid IL or missing references)
		//IL_0617: Expected Obj, but got Unknown
		checked
		{
			try
			{
				if (DataGridView1.Rows.Count == 0)
				{
					NewLateBinding.LateSet(sender, null, "Enabled", new object[1] { true }, null, null);
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
				MemoryStream memoryStream = new MemoryStream();
				MyProject.Forms.Form_3_VENTE.Picture_LOGO.Image.Save((Stream)memoryStream, ImageFormat.Jpeg);
				byte[] inArray = memoryStream.ToArray();
				string text = Convert.ToBase64String(inArray);
				string text2 = text;
				text = null;
				memoryStream.Dispose();
				((Report)MyProject.Forms.Report_TICKET_A5_ARABE.ReportViewer1.LocalReport).SetParameters(new ReportParameter("ReportLogo", text2, true));
				((Report)MyProject.Forms.Report_TICKET_A5_ARABE.ReportViewer1.LocalReport).SetParameters(new ReportParameter("ReportLogoMimeType", "image/jpeg", true));
				QREncoder = new QRCodeEncoder();
				QREncoder.QRCodeForegroundColor = Color.Black;
				QREncoder.QRCodeBackgroundColor = Color.White;
				QREncoder.QRCodeScale = 2;
				QREncoder.QRCodeVersion = 1;
				QREncoder.QRCodeEncodeMode = (ThoughtWorks.QRCode.Codec.QRCodeEncoder.ENCODE_MODE)2;
				QREncoder.QRCodeErrorCorrect = (ThoughtWorks.QRCode.Codec.QRCodeEncoder.ERROR_CORRECTION)0;
				QRimg = (Image)(object)QREncoder.Encode(Strings.Trim(Conversions.ToString(DataGridView3.Rows[((DataGridViewBand)DataGridView3.CurrentRow).Index].Cells["ID_TICKET"].Value)));
				QRbitmap = new Bitmap(QRimg);
				barcodeImage = QRbitmap;
				MemoryStream memoryStream2 = new MemoryStream();
				((Image)barcodeImage).Save((Stream)memoryStream2, ImageFormat.Jpeg);
				byte[] inArray2 = memoryStream2.ToArray();
				string text3 = Convert.ToBase64String(inArray2);
				string text4 = text3;
				text3 = null;
				memoryStream2.Dispose();
				((Report)MyProject.Forms.Report_TICKET_A5_ARABE.ReportViewer1.LocalReport).SetParameters(new ReportParameter("ReportLogo_QR", text4, true));
				((Report)MyProject.Forms.Report_TICKET_A5_ARABE.ReportViewer1.LocalReport).SetParameters(new ReportParameter("ReportLogoMimeType_QR", "image/jpeg", true));
				Microsoft.Reporting.WinForms.LocalReport val = MyProject.Forms.Report_TICKET_A5_ARABE.ReportViewer1.LocalReport;
				string text5;
				if ((Operators.CompareString(Label_OPERATION.Text, "VENTE", TextCompare: false) == 0) | (Operators.CompareString(Label_OPERATION.Text, "CREDIT", TextCompare: false) == 0))
				{
					text5 = "فاتورة البيع";
				}
				else
				{
					text5 = (Label_OPERATION.Text.Contains("RETOUR") ? "ورقة رجوع" : "");
				}
				((Report)val).SetParameters(new ReportParameter("TITRE_DOC", text5));
				((Report)MyProject.Forms.Report_TICKET_A5_ARABE.ReportViewer1.LocalReport).SetParameters(new ReportParameter("NUM", Label_N_TICKET.Text));
				((Report)MyProject.Forms.Report_TICKET_A5_ARABE.ReportViewer1.LocalReport).SetParameters(new ReportParameter("DATES", Conversions.ToDate(Label_DATES.Text).ToString("dd/MM/yyy HH:mm:ss")));
				((Report)MyProject.Forms.Report_TICKET_A5_ARABE.ReportViewer1.LocalReport).SetParameters(new ReportParameter("CAISSIER", Label_CAISSIER.Text));
				((Report)MyProject.Forms.Report_TICKET_A5_ARABE.ReportViewer1.LocalReport).SetParameters(new ReportParameter("CLIENT", Label_CLIENT.Text));
				((Report)MyProject.Forms.Report_TICKET_A5_ARABE.ReportViewer1.LocalReport).SetParameters(new ReportParameter("TOTAL_NET", " درهم" + Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(Text_TOTAL_NET.Text)))));
				((Report)MyProject.Forms.Report_TICKET_A5_ARABE.ReportViewer1.LocalReport).SetParameters(new ReportParameter("NBR_ARTICLES", Label_NBR_ARTICLES.Text));
				if (Operators.CompareString(Label_ID_CLIENT.Text, "", TextCompare: false) != 0)
				{
					_credit();
					((Report)MyProject.Forms.Report_TICKET_A5_ARABE.ReportViewer1.LocalReport).SetParameters(new ReportParameter("CREDIT", " درهم " + Conversions.ToString(_total_credit)));
				}
				((Report)MyProject.Forms.Report_TICKET_A5_ARABE.ReportViewer1.LocalReport).SetParameters(new ReportParameter("PIED_DOC", Text_pied_doc.Text));
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
						dataTable.Rows[num6][num9] = DataGridView1.Rows[num6].Cells[num9].Value.ToString();
						num9++;
					}
					num6++;
				}
				ReportDataSource item = new ReportDataSource("DataSet1", dataTable);
				((Collection<ReportDataSource>)(object)MyProject.Forms.Report_TICKET_A5_ARABE.ReportViewer1.LocalReport.DataSources).Clear();
				((Collection<ReportDataSource>)(object)MyProject.Forms.Report_TICKET_A5_ARABE.ReportViewer1.LocalReport.DataSources).Add(item);
				MyProject.Forms.Report_TICKET_A5_ARABE.ReportViewer1.RefreshReport();
				MyProject.Forms.Report_TICKET_A5_ARABE.ReportViewer1.SetDisplayMode((DisplayMode)1);
				MyProject.Forms.Report_TICKET_A5_ARABE.ReportViewer1.ZoomMode = (ZoomMode)2;
				MyProject.Forms.Report_TICKET_A5_ARABE.ReportViewer1.ZoomPercent = 25;
				((Control)MyProject.Forms.Report_TICKET_A5_ARABE).Show();
				Module1._QUITTER_PATIENTER = true;
				((Control)MyProject.Forms.Report_TICKET_A5_ARABE).Show();
				((Form)MyProject.Forms.Report_TICKET_A5_ARABE).TopMost = true;
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

	private void Button_ARABE_80_Click(object sender, EventArgs e)
	{
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected Obj, but got Unknown
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected Obj, but got Unknown
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Expected Obj, but got Unknown
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected Obj, but got Unknown
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Expected Obj, but got Unknown
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Expected Obj, but got Unknown
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Expected Obj, but got Unknown
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Expected Obj, but got Unknown
		//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Expected Obj, but got Unknown
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Expected Obj, but got Unknown
		//IL_0337: Unknown result type (might be due to invalid IL or missing references)
		//IL_0341: Expected Obj, but got Unknown
		//IL_049c: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a3: Expected Obj, but got Unknown
		//IL_050d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0514: Expected Obj, but got Unknown
		//IL_055a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0564: Expected Obj, but got Unknown
		checked
		{
			try
			{
				if (DataGridView1.Rows.Count == 0)
				{
					NewLateBinding.LateSet(sender, null, "Enabled", new object[1] { true }, null, null);
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
				MemoryStream memoryStream = new MemoryStream();
				MyProject.Forms.Form_3_VENTE.Picture_LOGO.Image.Save((Stream)memoryStream, ImageFormat.Jpeg);
				byte[] inArray = memoryStream.ToArray();
				string text = Convert.ToBase64String(inArray);
				string text2 = text;
				text = null;
				memoryStream.Dispose();
				((Report)MyProject.Forms.Report_TICKET_80_ARABE.ReportViewer1.LocalReport).SetParameters(new ReportParameter("ReportLogo", text2, true));
				((Report)MyProject.Forms.Report_TICKET_80_ARABE.ReportViewer1.LocalReport).SetParameters(new ReportParameter("ReportLogoMimeType", "image/jpeg", true));
				((Report)MyProject.Forms.Report_TICKET_80_ARABE.ReportViewer1.LocalReport).SetParameters(new ReportParameter("NUM", Label_N_TICKET.Text));
				((Report)MyProject.Forms.Report_TICKET_80_ARABE.ReportViewer1.LocalReport).SetParameters(new ReportParameter("DATES", Conversions.ToDate(Label_DATES.Text).ToString("dd/MM/yyy HH:mm:ss")));
				((Report)MyProject.Forms.Report_TICKET_80_ARABE.ReportViewer1.LocalReport).SetParameters(new ReportParameter("CAISSIER", Label_CAISSIER.Text));
				((Report)MyProject.Forms.Report_TICKET_80_ARABE.ReportViewer1.LocalReport).SetParameters(new ReportParameter("CLIENT", Label_CLIENT.Text));
				DataTable dataTable = new DataTable();
				MySqlDataAdapter val = new MySqlDataAdapter();
				dataTable.Clear();
				val = new MySqlDataAdapter("select    ID_CLIENT,CLIENT,ICE,ADRESSE   from TABLE_CLIENTS     Where    ID_CLIENT = '" + Label_ID_CLIENT.Text + "'        ", Module1.cn_SQL);
				((DbDataAdapter)(object)val).Fill(dataTable);
				if (dataTable.Rows.Count != 0)
				{
					((Report)MyProject.Forms.Report_TICKET_80_ARABE.ReportViewer1.LocalReport).SetParameters(new ReportParameter("CLIENT", dataTable.Rows[0]["CLIENT"].ToString() + " (" + dataTable.Rows[0]["ID_CLIENT"].ToString() + ")"));
				}
				((Report)MyProject.Forms.Report_TICKET_80_ARABE.ReportViewer1.LocalReport).SetParameters(new ReportParameter("TOTAL_NET", Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(Text_TOTAL_NET.Text))) + " DH"));
				if (Operators.CompareString(Label_ID_CLIENT.Text, "", TextCompare: false) != 0)
				{
					_credit();
					((Report)MyProject.Forms.Report_TICKET_80_ARABE.ReportViewer1.LocalReport).SetParameters(new ReportParameter("CREDIT", " درهم " + Conversions.ToString(_total_credit)));
				}
				DataTable dataTable2 = new DataTable();
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
					dataTable2.Columns.Add(DataGridView1.Columns[num2].Name.ToString());
					dataTable2.Columns[DataGridView1.Columns[num2].Name.ToString()].Caption = DataGridView1.Columns[num2].HeaderText.ToString();
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
					dataTable2.Rows.Add();
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
						dataTable2.Rows[num6][num9] = DataGridView1.Rows[num6].Cells[num9].Value.ToString();
						num9++;
					}
					num6++;
				}
				ReportDataSource item = new ReportDataSource("DataSet1", dataTable2);
				((Collection<ReportDataSource>)(object)MyProject.Forms.Report_TICKET_80_ARABE.ReportViewer1.LocalReport.DataSources).Clear();
				((Collection<ReportDataSource>)(object)MyProject.Forms.Report_TICKET_80_ARABE.ReportViewer1.LocalReport.DataSources).Add(item);
				int num11 = 224 + 25 * DataGridView1.Rows.Count + 25 + 50 + 100 + 10000;
				PageSettings val2 = new PageSettings();
				val2.Margins.Top = 1;
				val2.Margins.Bottom = 1;
				val2.Margins.Left = 1;
				val2.Margins.Right = 1;
				val2.PaperSize = new PaperSize("Custom", 320, num11);
				MyProject.Forms.Report_TICKET_80_ARABE.ReportViewer1.SetPageSettings(val2);
				MyProject.Forms.Report_TICKET_80_ARABE.ReportViewer1.RefreshReport();
				MyProject.Forms.Report_TICKET_80_ARABE.ReportViewer1.SetDisplayMode((DisplayMode)1);
				MyProject.Forms.Report_TICKET_80_ARABE.ReportViewer1.ZoomMode = (ZoomMode)2;
				MyProject.Forms.Report_TICKET_80_ARABE.ReportViewer1.ZoomPercent = 100;
				((Control)MyProject.Forms.Report_TICKET_80_ARABE).Show();
				Module1._QUITTER_PATIENTER = true;
				((Control)MyProject.Forms.Report_TICKET_80_ARABE).Show();
				((Form)MyProject.Forms.Report_TICKET_80_ARABE).TopMost = true;
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

	public void _credit()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected Obj, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected Obj, but got Unknown
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected Obj, but got Unknown
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Expected Obj, but got Unknown
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected Obj, but got Unknown
		DataTable dataTable = new DataTable();
		MySqlDataAdapter val = new MySqlDataAdapter();
		dataTable.Clear();
		val = new MySqlDataAdapter("SELECT    SUM(TOTAL_NET)      as N          FROM   TABLE_VENTES_JOURNAL     WHERE          ID_CLIENT  =  '" + Label_ID_CLIENT.Text + "'        AND      OPERATION  =  'CREDIT'          ", Module1.cn_SQL);
		((DbDataAdapter)(object)val).Fill(dataTable);
		decimal num = 0m;
		num = ((dataTable.Rows[0]["N"] != DBNull.Value) ? Conversions.ToDecimal(Strings.FormatNumber(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["N"]))) : Conversions.ToDecimal(Strings.FormatNumber(0)));
		dataTable.Clear();
		val = new MySqlDataAdapter("SELECT    SUM(TOTAL_NET)      as N          FROM   TABLE_VENTES_JOURNAL     WHERE          ID_CLIENT  =  '" + Label_ID_CLIENT.Text + "'       AND    OPERATION  =  'RETOUR CREDIT'        ", Module1.cn_SQL);
		((DbDataAdapter)(object)val).Fill(dataTable);
		decimal num2 = 0m;
		num2 = ((dataTable.Rows[0]["N"] != DBNull.Value) ? Conversions.ToDecimal(Strings.FormatNumber(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["N"]))) : Conversions.ToDecimal(Strings.FormatNumber(0)));
		dataTable.Clear();
		val = new MySqlDataAdapter("SELECT    CREDIT_INITIAL     as N          FROM   TABLE_CLIENTS     WHERE          ID_CLIENT  =  '" + Label_ID_CLIENT.Text + "'             ", Module1.cn_SQL);
		((DbDataAdapter)(object)val).Fill(dataTable);
		decimal num3 = 0m;
		num3 = ((dataTable.Rows[0]["N"] != DBNull.Value) ? Conversions.ToDecimal(Strings.FormatNumber(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["N"]))) : Conversions.ToDecimal(Strings.FormatNumber(0)));
		dataTable.Clear();
		val = new MySqlDataAdapter("select    SUM(MONTANT)      as N           from   TABLE_CLIENTS_REGLE       WHERE         ID_CLIENT  =  '" + Label_ID_CLIENT.Text + "'                 ", Module1.cn_SQL);
		((DbDataAdapter)(object)val).Fill(dataTable);
		decimal num4 = 0m;
		_total_credit = decimal.Subtract(d2: (dataTable.Rows[0]["N"] != DBNull.Value) ? Conversions.ToDecimal(Strings.FormatNumber(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["N"]))) : Conversions.ToDecimal(Strings.FormatNumber(0)), d1: decimal.Add(decimal.Add(num, num2), num3));
	}

	private void Button_AUJOURDHUIT_Click(object sender, EventArgs e)
	{
		((DateTimePicker)BunifuDatePicker1).Value = DateTime.Now.Date;
		((DateTimePicker)BunifuDatePicker2).Value = DateTime.Now.Date;
	}

	private void Button_PRECEDENT_Click(object sender, EventArgs e)
	{
		((DateTimePicker)BunifuDatePicker1).Value = ((DateTimePicker)BunifuDatePicker1).Value.AddDays(-1.0);
		((DateTimePicker)BunifuDatePicker2).Value = ((DateTimePicker)BunifuDatePicker2).Value.AddDays(-1.0);
	}

	private void Button_SUIVANT_Click(object sender, EventArgs e)
	{
		((DateTimePicker)BunifuDatePicker1).Value = ((DateTimePicker)BunifuDatePicker1).Value.AddDays(1.0);
		((DateTimePicker)BunifuDatePicker2).Value = ((DateTimePicker)BunifuDatePicker2).Value.AddDays(1.0);
	}

	private void BunifuDatePicker_ValueChanged(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected Obj, but got Unknown
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected Obj, but got Unknown
		DataTable dataTable = new DataTable();
		MySqlDataAdapter val = new MySqlDataAdapter();
		dataTable.Clear();
		val = new MySqlDataAdapter("select       ID_TICKET,  Ticket , TOTAL_NET , OPERATION ,Client   from   TABLE_VENTES_ENTETE     Where  Dates   between   ' " + Strings.Format(((DateTimePicker)BunifuDatePicker1).Value, "yyyy-MM-dd") + " '         And    ' " + Strings.Format(((DateTimePicker)BunifuDatePicker2).Value, "yyyy-MM-dd") + " '                   order by ID DESC    ", Module1.cn_SQL);
		((DbDataAdapter)(object)val).Fill(dataTable);
		DataGridView3.Rows.Clear();
		checked
		{
			int num = dataTable.Rows.Count - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 <= num4)
				{
					DataGridView3.Rows.Add(new object[5]
					{
						dataTable.Rows[num2]["ID_TICKET"].ToString(),
						dataTable.Rows[num2]["Ticket"].ToString(),
						Conversions.ToDecimal(dataTable.Rows[num2]["TOTAL_NET"].ToString()),
						dataTable.Rows[num2]["OPERATION"].ToString(),
						dataTable.Rows[num2]["Client"].ToString()
					});
					num2++;
					continue;
				}
				break;
			}
		}
	}
}
