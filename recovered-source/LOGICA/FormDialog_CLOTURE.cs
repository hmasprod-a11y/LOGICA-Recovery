using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using LOGICA.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace LOGICA;

[DesignerGenerated]
public class FormDialog_CLOTURE : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Button_CLOTURE_GLOBALE")]
	private Button _Button_CLOTURE_GLOBALE;

	[AccessedThroughProperty("Button_CLOTURE_CAISSIER")]
	private Button _Button_CLOTURE_CAISSIER;

	[AccessedThroughProperty("Label_TOTAL_NET_CLOTURE_CAISSIER")]
	private Label _Label_TOTAL_NET_CLOTURE_CAISSIER;

	[AccessedThroughProperty("Button_TOTAL_GLOBALE")]
	private Button _Button_TOTAL_GLOBALE;

	[AccessedThroughProperty("Label_TOTAL_NET_CLOTURE_GLOBALE")]
	private Label _Label_TOTAL_NET_CLOTURE_GLOBALE;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("Label_DATE_A_CLOTURE_GLOBALE")]
	private Label _Label_DATE_A_CLOTURE_GLOBALE;

	[AccessedThroughProperty("Label_DATE_DE_CLOTURE_GLOBALE")]
	private Label _Label_DATE_DE_CLOTURE_GLOBALE;

	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	[AccessedThroughProperty("Label_N_CLOTURE_CLOTURE_GLOBALE")]
	private Label _Label_N_CLOTURE_CLOTURE_GLOBALE;

	[AccessedThroughProperty("Label_N_CLOTURE_CLOTURE_CAISSIER")]
	private Label _Label_N_CLOTURE_CLOTURE_CAISSIER;

	[AccessedThroughProperty("Label_DATE_A_CLOTURE_CAISSIER")]
	private Label _Label_DATE_A_CLOTURE_CAISSIER;

	[AccessedThroughProperty("Label_DATE_DE_CLOTURE_CAISSIER")]
	private Label _Label_DATE_DE_CLOTURE_CAISSIER;

	[AccessedThroughProperty("Print_Recette_Globale")]
	private PrintDocument _Print_Recette_Globale;

	[AccessedThroughProperty("Print_Recette_caissier")]
	private PrintDocument _Print_Recette_caissier;

	[AccessedThroughProperty("Button_PrintCaissier")]
	private Button _Button_PrintCaissier;

	[AccessedThroughProperty("Button_ConsCaissier")]
	private Button _Button_ConsCaissier;

	[AccessedThroughProperty("Button_PrintRapport")]
	private Button _Button_PrintRapport;

	[AccessedThroughProperty("Button_ConsRapport")]
	private Button _Button_ConsRapport;

	[AccessedThroughProperty("Button_MAIL_CAISSIER")]
	private Button _Button_MAIL_CAISSIER;

	[AccessedThroughProperty("Button_MAIL_GLOBALE")]
	private Button _Button_MAIL_GLOBALE;

	[AccessedThroughProperty("Text_PRINTER_RAPPORT")]
	private TextBox _Text_PRINTER_RAPPORT;

	[AccessedThroughProperty("Text_mail")]
	private TextBox _Text_mail;

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

	[AccessedThroughProperty("Label_BOTTOM")]
	private Label _Label_BOTTOM;

	[AccessedThroughProperty("Label_LEFT")]
	private Label _Label_LEFT;

	[AccessedThroughProperty("Label_RIGHT")]
	private Label _Label_RIGHT;

	[AccessedThroughProperty("Label_TOP")]
	private Label _Label_TOP;

	[AccessedThroughProperty("ListBox_RAPPORT_GLOBALE")]
	private ListBox _ListBox_RAPPORT_GLOBALE;

	[AccessedThroughProperty("ListBox_CAISSIERS")]
	private ListBox _ListBox_CAISSIERS;

	[AccessedThroughProperty("Button_TOTAL_CAISSIER")]
	private Button _Button_TOTAL_CAISSIER;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("DataGridView3")]
	private DataGridView _DataGridView3;

	[AccessedThroughProperty("DataGridViewTextBoxColumn1")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn1;

	[AccessedThroughProperty("Label21")]
	private Label _Label21;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("Panel_CLOTURE_GLOBALE")]
	private Panel _Panel_CLOTURE_GLOBALE;

	[AccessedThroughProperty("Panel_CLOTURE_CAISSIER")]
	private Panel _Panel_CLOTURE_CAISSIER;

	[AccessedThroughProperty("Button244")]
	private Button _Button244;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[AccessedThroughProperty("Panel_RAPPORT")]
	private Panel _Panel_RAPPORT;

	[AccessedThroughProperty("TabControlEx1")]
	private TabControlEx _TabControlEx1;

	[AccessedThroughProperty("TabPage6")]
	private TabPage _TabPage6;

	[AccessedThroughProperty("Panel8")]
	private Panel _Panel8;

	[AccessedThroughProperty("Button7")]
	private Button _Button7;

	[AccessedThroughProperty("DataGridView122323")]
	private DataGridView _DataGridView122323;

	[AccessedThroughProperty("DataGridViewTextBoxColumn8")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn8;

	[AccessedThroughProperty("DataGridViewTextBoxColumn9")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn9;

	[AccessedThroughProperty("DE")]
	private DataGridViewTextBoxColumn _DE;

	[AccessedThroughProperty("A")]
	private DataGridViewTextBoxColumn _A;

	[AccessedThroughProperty("Label27")]
	private Label _Label27;

	[AccessedThroughProperty("Label28")]
	private Label _Label28;

	[AccessedThroughProperty("Label29")]
	private Label _Label29;

	[AccessedThroughProperty("Label30")]
	private Label _Label30;

	[AccessedThroughProperty("DateTimePicker1")]
	private DateTimePicker _DateTimePicker1;

	[AccessedThroughProperty("Button_PrintRapport_HISTORIQUE")]
	private Button _Button_PrintRapport_HISTORIQUE;

	[AccessedThroughProperty("Button_ConsRapport_HISTORIQUE")]
	private Button _Button_ConsRapport_HISTORIQUE;

	[AccessedThroughProperty("Label23")]
	private Label _Label23;

	[AccessedThroughProperty("Button3")]
	private Button _Button3;

	[AccessedThroughProperty("Label18")]
	private Label _Label18;

	[AccessedThroughProperty("TabPage1")]
	private TabPage _TabPage1;

	[AccessedThroughProperty("Button_PrintCaissier_HISTORIQUE")]
	private Button _Button_PrintCaissier_HISTORIQUE;

	[AccessedThroughProperty("Button_ConsCaissier_HISTORIQUE")]
	private Button _Button_ConsCaissier_HISTORIQUE;

	[AccessedThroughProperty("Label15")]
	private Label _Label15;

	[AccessedThroughProperty("Button10")]
	private Button _Button10;

	[AccessedThroughProperty("Label16")]
	private Label _Label16;

	[AccessedThroughProperty("Panel2")]
	private Panel _Panel2;

	[AccessedThroughProperty("Button6")]
	private Button _Button6;

	[AccessedThroughProperty("Combo_CLOTURE_CAISSIER")]
	private ComboBox _Combo_CLOTURE_CAISSIER;

	[AccessedThroughProperty("DataGridView1434")]
	private DataGridView _DataGridView1434;

	[AccessedThroughProperty("DataGridViewTextBoxColumn2")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn2;

	[AccessedThroughProperty("DataGridViewTextBoxColumn3")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn3;

	[AccessedThroughProperty("DEE")]
	private DataGridViewTextBoxColumn _DEE;

	[AccessedThroughProperty("AA")]
	private DataGridViewTextBoxColumn _AA;

	[AccessedThroughProperty("Label10")]
	private Label _Label10;

	[AccessedThroughProperty("Label11")]
	private Label _Label11;

	[AccessedThroughProperty("Label12")]
	private Label _Label12;

	[AccessedThroughProperty("Label13")]
	private Label _Label13;

	[AccessedThroughProperty("DateTimePicker2")]
	private DateTimePicker _DateTimePicker2;

	[AccessedThroughProperty("Print_Recette_Globale_HISTORIQUE")]
	private PrintDocument _Print_Recette_Globale_HISTORIQUE;

	[AccessedThroughProperty("Print_Recette_caissier_HISTORIQUE")]
	private PrintDocument _Print_Recette_caissier_HISTORIQUE;

	[AccessedThroughProperty("Text_MAIL_TITRE")]
	private TextBox _Text_MAIL_TITRE;

	private MySqlDataAdapter DA;

	private DataTable DT;

	private DataTable _dt;

	private MySqlDataAdapter _da;

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

	internal virtual Button Button_CLOTURE_GLOBALE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_CLOTURE_GLOBALE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_CLOTURE_GLOBALE_Click;
			if (_Button_CLOTURE_GLOBALE != null)
			{
				((Control)_Button_CLOTURE_GLOBALE).Click -= eventHandler;
			}
			_Button_CLOTURE_GLOBALE = value;
			if (_Button_CLOTURE_GLOBALE != null)
			{
				((Control)_Button_CLOTURE_GLOBALE).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button_CLOTURE_CAISSIER
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_CLOTURE_CAISSIER;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button3_Click;
			EventHandler eventHandler2 = Button_CLOTURE_CAISSIER_Click;
			if (_Button_CLOTURE_CAISSIER != null)
			{
				((Control)_Button_CLOTURE_CAISSIER).Click -= eventHandler;
				((Control)_Button_CLOTURE_CAISSIER).Click -= eventHandler2;
			}
			_Button_CLOTURE_CAISSIER = value;
			if (_Button_CLOTURE_CAISSIER != null)
			{
				((Control)_Button_CLOTURE_CAISSIER).Click += eventHandler;
				((Control)_Button_CLOTURE_CAISSIER).Click += eventHandler2;
			}
		}
	}

	internal virtual Label Label_TOTAL_NET_CLOTURE_CAISSIER
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_TOTAL_NET_CLOTURE_CAISSIER;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_TOTAL_NET_CLOTURE_CAISSIER = value;
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

	internal virtual Label Label_TOTAL_NET_CLOTURE_GLOBALE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_TOTAL_NET_CLOTURE_GLOBALE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_TOTAL_NET_CLOTURE_GLOBALE = value;
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

	internal virtual Label Label_DATE_A_CLOTURE_GLOBALE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_DATE_A_CLOTURE_GLOBALE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_DATE_A_CLOTURE_GLOBALE = value;
		}
	}

	internal virtual Label Label_DATE_DE_CLOTURE_GLOBALE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_DATE_DE_CLOTURE_GLOBALE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_DATE_DE_CLOTURE_GLOBALE = value;
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

	internal virtual Label Label_N_CLOTURE_CLOTURE_GLOBALE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_N_CLOTURE_CLOTURE_GLOBALE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_N_CLOTURE_CLOTURE_GLOBALE = value;
		}
	}

	internal virtual Label Label_N_CLOTURE_CLOTURE_CAISSIER
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_N_CLOTURE_CLOTURE_CAISSIER;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_N_CLOTURE_CLOTURE_CAISSIER = value;
		}
	}

	internal virtual Label Label_DATE_A_CLOTURE_CAISSIER
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_DATE_A_CLOTURE_CAISSIER;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_DATE_A_CLOTURE_CAISSIER = value;
		}
	}

	internal virtual Label Label_DATE_DE_CLOTURE_CAISSIER
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_DATE_DE_CLOTURE_CAISSIER;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_DATE_DE_CLOTURE_CAISSIER = value;
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
			EventHandler eventHandler = Button_ConsCaissier_Click;
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
			EventHandler eventHandler = Button_ConsCaissier_Click;
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
			_ListBox_RAPPORT_GLOBALE = value;
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
			EventHandler eventHandler = ListBox_CAISSIERS_SelectedIndexChanged;
			if (_ListBox_CAISSIERS != null)
			{
				_ListBox_CAISSIERS.SelectedIndexChanged -= eventHandler;
			}
			_ListBox_CAISSIERS = value;
			if (_ListBox_CAISSIERS != null)
			{
				_ListBox_CAISSIERS.SelectedIndexChanged += eventHandler;
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

	internal virtual Panel Panel_CLOTURE_GLOBALE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel_CLOTURE_GLOBALE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel_CLOTURE_GLOBALE = value;
		}
	}

	internal virtual Panel Panel_CLOTURE_CAISSIER
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel_CLOTURE_CAISSIER;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel_CLOTURE_CAISSIER = value;
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

	internal virtual Panel Panel_RAPPORT
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel_RAPPORT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel_RAPPORT = value;
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

	internal virtual TabPage TabPage6
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabPage6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabPage6 = value;
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

	internal virtual Button Button7
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button7_Click;
			if (_Button7 != null)
			{
				((Control)_Button7).Click -= eventHandler;
			}
			_Button7 = value;
			if (_Button7 != null)
			{
				((Control)_Button7).Click += eventHandler;
			}
		}
	}

	internal virtual DataGridView DataGridView122323
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridView122323;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGridView122323 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn8
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridViewTextBoxColumn8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGridViewTextBoxColumn8 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn9
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridViewTextBoxColumn9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGridViewTextBoxColumn9 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn DE
	{
		[DebuggerNonUserCode]
		get
		{
			return _DE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DE = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn A
	{
		[DebuggerNonUserCode]
		get
		{
			return _A;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_A = value;
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

	internal virtual Button Button_PrintRapport_HISTORIQUE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_PrintRapport_HISTORIQUE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_Click;
			if (_Button_PrintRapport_HISTORIQUE != null)
			{
				((Control)_Button_PrintRapport_HISTORIQUE).Click -= eventHandler;
			}
			_Button_PrintRapport_HISTORIQUE = value;
			if (_Button_PrintRapport_HISTORIQUE != null)
			{
				((Control)_Button_PrintRapport_HISTORIQUE).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button_ConsRapport_HISTORIQUE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_ConsRapport_HISTORIQUE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_Click;
			if (_Button_ConsRapport_HISTORIQUE != null)
			{
				((Control)_Button_ConsRapport_HISTORIQUE).Click -= eventHandler;
			}
			_Button_ConsRapport_HISTORIQUE = value;
			if (_Button_ConsRapport_HISTORIQUE != null)
			{
				((Control)_Button_ConsRapport_HISTORIQUE).Click += eventHandler;
			}
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

	internal virtual Button Button_PrintCaissier_HISTORIQUE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_PrintCaissier_HISTORIQUE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Buttonn_Click;
			if (_Button_PrintCaissier_HISTORIQUE != null)
			{
				((Control)_Button_PrintCaissier_HISTORIQUE).Click -= eventHandler;
			}
			_Button_PrintCaissier_HISTORIQUE = value;
			if (_Button_PrintCaissier_HISTORIQUE != null)
			{
				((Control)_Button_PrintCaissier_HISTORIQUE).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button_ConsCaissier_HISTORIQUE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_ConsCaissier_HISTORIQUE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Buttonn_Click;
			if (_Button_ConsCaissier_HISTORIQUE != null)
			{
				((Control)_Button_ConsCaissier_HISTORIQUE).Click -= eventHandler;
			}
			_Button_ConsCaissier_HISTORIQUE = value;
			if (_Button_ConsCaissier_HISTORIQUE != null)
			{
				((Control)_Button_ConsCaissier_HISTORIQUE).Click += eventHandler;
			}
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

	internal virtual ComboBox Combo_CLOTURE_CAISSIER
	{
		[DebuggerNonUserCode]
		get
		{
			return _Combo_CLOTURE_CAISSIER;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Combo_CLOTURE_CAISSIER = value;
		}
	}

	internal virtual DataGridView DataGridView1434
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridView1434;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGridView1434 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn2
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridViewTextBoxColumn2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGridViewTextBoxColumn2 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn3
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridViewTextBoxColumn3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGridViewTextBoxColumn3 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn DEE
	{
		[DebuggerNonUserCode]
		get
		{
			return _DEE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DEE = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn AA
	{
		[DebuggerNonUserCode]
		get
		{
			return _AA;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_AA = value;
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

	internal virtual PrintDocument Print_Recette_Globale_HISTORIQUE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Print_Recette_Globale_HISTORIQUE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			PrintPageEventHandler val = Print_Recette_Globale_HISTORIQUE_PrintPage;
			if (_Print_Recette_Globale_HISTORIQUE != null)
			{
				_Print_Recette_Globale_HISTORIQUE.PrintPage -= val;
			}
			_Print_Recette_Globale_HISTORIQUE = value;
			if (_Print_Recette_Globale_HISTORIQUE != null)
			{
				_Print_Recette_Globale_HISTORIQUE.PrintPage += val;
			}
		}
	}

	internal virtual PrintDocument Print_Recette_caissier_HISTORIQUE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Print_Recette_caissier_HISTORIQUE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			PrintPageEventHandler val = Print_Recette_caissier_HISTORIQUE_PrintPage;
			if (_Print_Recette_caissier_HISTORIQUE != null)
			{
				_Print_Recette_caissier_HISTORIQUE.PrintPage -= val;
			}
			_Print_Recette_caissier_HISTORIQUE = value;
			if (_Print_Recette_caissier_HISTORIQUE != null)
			{
				_Print_Recette_caissier_HISTORIQUE.PrintPage += val;
			}
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

	public FormDialog_CLOTURE()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected Obj, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected Obj, but got Unknown
		((Form)this).Load += FormDialog_CLOTURE_Load;
		__ENCAddToList(this);
		DA = new MySqlDataAdapter();
		DT = new DataTable();
		_dt = new DataTable();
		_da = new MySqlDataAdapter();
		prn = new RawPrinterHelper();
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
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected Obj, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected Obj, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected Obj, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected Obj, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected Obj, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected Obj, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected Obj, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected Obj, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected Obj, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected Obj, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected Obj, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected Obj, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected Obj, but got Unknown
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected Obj, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected Obj, but got Unknown
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected Obj, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected Obj, but got Unknown
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected Obj, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected Obj, but got Unknown
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected Obj, but got Unknown
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected Obj, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected Obj, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected Obj, but got Unknown
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected Obj, but got Unknown
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected Obj, but got Unknown
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected Obj, but got Unknown
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected Obj, but got Unknown
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected Obj, but got Unknown
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected Obj, but got Unknown
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected Obj, but got Unknown
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Expected Obj, but got Unknown
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Expected Obj, but got Unknown
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected Obj, but got Unknown
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Expected Obj, but got Unknown
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Expected Obj, but got Unknown
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Expected Obj, but got Unknown
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Expected Obj, but got Unknown
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Expected Obj, but got Unknown
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected Obj, but got Unknown
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Expected Obj, but got Unknown
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Expected Obj, but got Unknown
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Expected Obj, but got Unknown
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Expected Obj, but got Unknown
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Expected Obj, but got Unknown
		//IL_025a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Expected Obj, but got Unknown
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Expected Obj, but got Unknown
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Expected Obj, but got Unknown
		//IL_027e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Expected Obj, but got Unknown
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Expected Obj, but got Unknown
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Expected Obj, but got Unknown
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Expected Obj, but got Unknown
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Expected Obj, but got Unknown
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c4: Expected Obj, but got Unknown
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Expected Obj, but got Unknown
		//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dc: Expected Obj, but got Unknown
		//IL_02de: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e8: Expected Obj, but got Unknown
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Expected Obj, but got Unknown
		//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Expected Obj, but got Unknown
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_030c: Expected Obj, but got Unknown
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Expected Obj, but got Unknown
		//IL_031a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Expected Obj, but got Unknown
		//IL_0326: Unknown result type (might be due to invalid IL or missing references)
		//IL_0330: Expected Obj, but got Unknown
		//IL_0332: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Expected Obj, but got Unknown
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0348: Expected Obj, but got Unknown
		//IL_034a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Expected Obj, but got Unknown
		//IL_0356: Unknown result type (might be due to invalid IL or missing references)
		//IL_0360: Expected Obj, but got Unknown
		//IL_0362: Unknown result type (might be due to invalid IL or missing references)
		//IL_036c: Expected Obj, but got Unknown
		//IL_036e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0378: Expected Obj, but got Unknown
		//IL_037a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0384: Expected Obj, but got Unknown
		//IL_0386: Unknown result type (might be due to invalid IL or missing references)
		//IL_0390: Expected Obj, but got Unknown
		//IL_0392: Unknown result type (might be due to invalid IL or missing references)
		//IL_039c: Expected Obj, but got Unknown
		//IL_039e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a8: Expected Obj, but got Unknown
		//IL_03aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b4: Expected Obj, but got Unknown
		//IL_03b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c0: Expected Obj, but got Unknown
		//IL_03c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cc: Expected Obj, but got Unknown
		//IL_03ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d8: Expected Obj, but got Unknown
		//IL_03da: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e4: Expected Obj, but got Unknown
		//IL_03e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f0: Expected Obj, but got Unknown
		//IL_03f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fc: Expected Obj, but got Unknown
		//IL_03fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0408: Expected Obj, but got Unknown
		//IL_040a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0414: Expected Obj, but got Unknown
		//IL_0416: Unknown result type (might be due to invalid IL or missing references)
		//IL_0420: Expected Obj, but got Unknown
		//IL_0422: Unknown result type (might be due to invalid IL or missing references)
		//IL_042c: Expected Obj, but got Unknown
		//IL_042e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0438: Expected Obj, but got Unknown
		//IL_043a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0444: Expected Obj, but got Unknown
		//IL_0446: Unknown result type (might be due to invalid IL or missing references)
		//IL_0450: Expected Obj, but got Unknown
		//IL_0452: Unknown result type (might be due to invalid IL or missing references)
		//IL_045c: Expected Obj, but got Unknown
		//IL_045e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0468: Expected Obj, but got Unknown
		//IL_0a46: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a50: Expected Obj, but got Unknown
		//IL_0b62: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b6c: Expected Obj, but got Unknown
		//IL_1511: Unknown result type (might be due to invalid IL or missing references)
		//IL_151b: Expected Obj, but got Unknown
		//IL_1536: Unknown result type (might be due to invalid IL or missing references)
		//IL_153c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1812: Unknown result type (might be due to invalid IL or missing references)
		//IL_181c: Expected Obj, but got Unknown
		//IL_2108: Unknown result type (might be due to invalid IL or missing references)
		//IL_2112: Expected Obj, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FormDialog_CLOTURE));
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		DataGridViewCellStyle val3 = new DataGridViewCellStyle();
		DataGridViewCellStyle val4 = new DataGridViewCellStyle();
		DataGridViewCellStyle val5 = new DataGridViewCellStyle();
		Label_N_CLOTURE_CLOTURE_CAISSIER = new Label();
		Label_DATE_A_CLOTURE_CAISSIER = new Label();
		Label_DATE_DE_CLOTURE_CAISSIER = new Label();
		Label8 = new Label();
		Label_N_CLOTURE_CLOTURE_GLOBALE = new Label();
		Label2 = new Label();
		Label6 = new Label();
		Label_DATE_A_CLOTURE_GLOBALE = new Label();
		Label_DATE_DE_CLOTURE_GLOBALE = new Label();
		Label_TOTAL_NET_CLOTURE_GLOBALE = new Label();
		Label_TOTAL_NET_CLOTURE_CAISSIER = new Label();
		Button_CLOTURE_CAISSIER = new Button();
		Button_CLOTURE_GLOBALE = new Button();
		Print_Recette_Globale = new PrintDocument();
		Print_Recette_caissier = new PrintDocument();
		Text_PRINTER_RAPPORT = new TextBox();
		Text_mail = new TextBox();
		Panel1 = new Panel();
		DataGridView3 = new DataGridView();
		DataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
		DataGridView2 = new DataGridView();
		COL_1 = new DataGridViewTextBoxColumn();
		COL_2 = new DataGridViewTextBoxColumn();
		COL_3 = new DataGridViewTextBoxColumn();
		Label_BOTTOM = new Label();
		Label_LEFT = new Label();
		Label_RIGHT = new Label();
		Label_TOP = new Label();
		ListBox_RAPPORT_GLOBALE = new ListBox();
		ListBox_CAISSIERS = new ListBox();
		Label3 = new Label();
		Label4 = new Label();
		Label5 = new Label();
		Label21 = new Label();
		Label7 = new Label();
		Panel_CLOTURE_GLOBALE = new Panel();
		Button_PrintRapport = new Button();
		Button_TOTAL_GLOBALE = new Button();
		Button_ConsRapport = new Button();
		Panel_CLOTURE_CAISSIER = new Panel();
		Button_ConsCaissier = new Button();
		Button_PrintCaissier = new Button();
		Button_TOTAL_CAISSIER = new Button();
		Panel_RAPPORT = new Panel();
		TabControlEx1 = new TabControlEx();
		TabPage6 = new TabPage();
		Panel8 = new Panel();
		Button7 = new Button();
		DataGridView122323 = new DataGridView();
		DataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
		DataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
		DE = new DataGridViewTextBoxColumn();
		A = new DataGridViewTextBoxColumn();
		Label27 = new Label();
		Label28 = new Label();
		Label29 = new Label();
		Label30 = new Label();
		DateTimePicker1 = new DateTimePicker();
		Button_PrintRapport_HISTORIQUE = new Button();
		Button_ConsRapport_HISTORIQUE = new Button();
		Label23 = new Label();
		Button3 = new Button();
		Label18 = new Label();
		TabPage1 = new TabPage();
		Button_PrintCaissier_HISTORIQUE = new Button();
		Button_ConsCaissier_HISTORIQUE = new Button();
		Label15 = new Label();
		Button10 = new Button();
		Label16 = new Label();
		Panel2 = new Panel();
		Button6 = new Button();
		Combo_CLOTURE_CAISSIER = new ComboBox();
		DataGridView1434 = new DataGridView();
		DataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
		DataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
		DEE = new DataGridViewTextBoxColumn();
		AA = new DataGridViewTextBoxColumn();
		Label10 = new Label();
		Label11 = new Label();
		Label12 = new Label();
		Label13 = new Label();
		DateTimePicker2 = new DateTimePicker();
		Print_Recette_Globale_HISTORIQUE = new PrintDocument();
		Print_Recette_caissier_HISTORIQUE = new PrintDocument();
		Text_MAIL_TITRE = new TextBox();
		Button2 = new Button();
		Button244 = new Button();
		Button_MAIL_CAISSIER = new Button();
		Button_MAIL_GLOBALE = new Button();
		Button1 = new Button();
		((Control)Panel1).SuspendLayout();
		((ISupportInitialize)DataGridView3).BeginInit();
		((ISupportInitialize)DataGridView2).BeginInit();
		((Control)Panel_CLOTURE_GLOBALE).SuspendLayout();
		((Control)Panel_CLOTURE_CAISSIER).SuspendLayout();
		((Control)Panel_RAPPORT).SuspendLayout();
		((Control)TabControlEx1).SuspendLayout();
		((Control)TabPage6).SuspendLayout();
		((Control)Panel8).SuspendLayout();
		((ISupportInitialize)DataGridView122323).BeginInit();
		((Control)TabPage1).SuspendLayout();
		((Control)Panel2).SuspendLayout();
		((ISupportInitialize)DataGridView1434).BeginInit();
		((Control)this).SuspendLayout();
		((Control)Label_N_CLOTURE_CLOTURE_CAISSIER).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Label_N_CLOTURE_CLOTURE_CAISSIER, "Label_N_CLOTURE_CLOTURE_CAISSIER");
		((Control)Label_N_CLOTURE_CLOTURE_CAISSIER).ForeColor = Color.Black;
		((Control)Label_N_CLOTURE_CLOTURE_CAISSIER).Name = "Label_N_CLOTURE_CLOTURE_CAISSIER";
		((Control)Label_DATE_A_CLOTURE_CAISSIER).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Label_DATE_A_CLOTURE_CAISSIER, "Label_DATE_A_CLOTURE_CAISSIER");
		((Control)Label_DATE_A_CLOTURE_CAISSIER).ForeColor = Color.Black;
		((Control)Label_DATE_A_CLOTURE_CAISSIER).Name = "Label_DATE_A_CLOTURE_CAISSIER";
		((Control)Label_DATE_DE_CLOTURE_CAISSIER).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Label_DATE_DE_CLOTURE_CAISSIER, "Label_DATE_DE_CLOTURE_CAISSIER");
		((Control)Label_DATE_DE_CLOTURE_CAISSIER).ForeColor = Color.Black;
		((Control)Label_DATE_DE_CLOTURE_CAISSIER).Name = "Label_DATE_DE_CLOTURE_CAISSIER";
		((Control)Label8).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Label8, "Label8");
		((Control)Label8).ForeColor = Color.Black;
		((Control)Label8).Name = "Label8";
		((Control)Label_N_CLOTURE_CLOTURE_GLOBALE).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Label_N_CLOTURE_CLOTURE_GLOBALE, "Label_N_CLOTURE_CLOTURE_GLOBALE");
		((Control)Label_N_CLOTURE_CLOTURE_GLOBALE).ForeColor = Color.Black;
		((Control)Label_N_CLOTURE_CLOTURE_GLOBALE).Name = "Label_N_CLOTURE_CLOTURE_GLOBALE";
		((Control)Label2).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Label2, "Label2");
		((Control)Label2).ForeColor = Color.Black;
		((Control)Label2).Name = "Label2";
		((Control)Label6).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Label6, "Label6");
		((Control)Label6).ForeColor = Color.Black;
		((Control)Label6).Name = "Label6";
		((Control)Label_DATE_A_CLOTURE_GLOBALE).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Label_DATE_A_CLOTURE_GLOBALE, "Label_DATE_A_CLOTURE_GLOBALE");
		((Control)Label_DATE_A_CLOTURE_GLOBALE).ForeColor = Color.Black;
		((Control)Label_DATE_A_CLOTURE_GLOBALE).Name = "Label_DATE_A_CLOTURE_GLOBALE";
		((Control)Label_DATE_DE_CLOTURE_GLOBALE).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Label_DATE_DE_CLOTURE_GLOBALE, "Label_DATE_DE_CLOTURE_GLOBALE");
		((Control)Label_DATE_DE_CLOTURE_GLOBALE).ForeColor = Color.Black;
		((Control)Label_DATE_DE_CLOTURE_GLOBALE).Name = "Label_DATE_DE_CLOTURE_GLOBALE";
		((Control)Label_TOTAL_NET_CLOTURE_GLOBALE).BackColor = Color.White;
		Label_TOTAL_NET_CLOTURE_GLOBALE.BorderStyle = (BorderStyle)1;
		componentResourceManager.ApplyResources(Label_TOTAL_NET_CLOTURE_GLOBALE, "Label_TOTAL_NET_CLOTURE_GLOBALE");
		((Control)Label_TOTAL_NET_CLOTURE_GLOBALE).ForeColor = Color.FromArgb(2, 45, 162);
		((Control)Label_TOTAL_NET_CLOTURE_GLOBALE).Name = "Label_TOTAL_NET_CLOTURE_GLOBALE";
		((Control)Label_TOTAL_NET_CLOTURE_CAISSIER).BackColor = Color.White;
		Label_TOTAL_NET_CLOTURE_CAISSIER.BorderStyle = (BorderStyle)1;
		componentResourceManager.ApplyResources(Label_TOTAL_NET_CLOTURE_CAISSIER, "Label_TOTAL_NET_CLOTURE_CAISSIER");
		((Control)Label_TOTAL_NET_CLOTURE_CAISSIER).ForeColor = Color.FromArgb(2, 45, 162);
		((Control)Label_TOTAL_NET_CLOTURE_CAISSIER).Name = "Label_TOTAL_NET_CLOTURE_CAISSIER";
		((ButtonBase)Button_CLOTURE_CAISSIER).BackColor = Color.Yellow;
		((Control)Button_CLOTURE_CAISSIER).Cursor = Cursors.Hand;
		((ButtonBase)Button_CLOTURE_CAISSIER).FlatAppearance.BorderColor = Color.FromArgb(167, 197, 237);
		((ButtonBase)Button_CLOTURE_CAISSIER).FlatAppearance.BorderSize = 2;
		componentResourceManager.ApplyResources(Button_CLOTURE_CAISSIER, "Button_CLOTURE_CAISSIER");
		((Control)Button_CLOTURE_CAISSIER).Name = "Button_CLOTURE_CAISSIER";
		((ButtonBase)Button_CLOTURE_CAISSIER).UseVisualStyleBackColor = false;
		((ButtonBase)Button_CLOTURE_GLOBALE).BackColor = Color.Yellow;
		((Control)Button_CLOTURE_GLOBALE).Cursor = Cursors.Hand;
		((ButtonBase)Button_CLOTURE_GLOBALE).FlatAppearance.BorderColor = Color.FromArgb(167, 197, 237);
		((ButtonBase)Button_CLOTURE_GLOBALE).FlatAppearance.BorderSize = 2;
		componentResourceManager.ApplyResources(Button_CLOTURE_GLOBALE, "Button_CLOTURE_GLOBALE");
		((Control)Button_CLOTURE_GLOBALE).Name = "Button_CLOTURE_GLOBALE";
		((ButtonBase)Button_CLOTURE_GLOBALE).UseVisualStyleBackColor = false;
		componentResourceManager.ApplyResources(Text_PRINTER_RAPPORT, "Text_PRINTER_RAPPORT");
		((Control)Text_PRINTER_RAPPORT).Name = "Text_PRINTER_RAPPORT";
		componentResourceManager.ApplyResources(Text_mail, "Text_mail");
		((Control)Text_mail).Name = "Text_mail";
		((Control)Panel1).Controls.Add((Control)(object)DataGridView3);
		((Control)Panel1).Controls.Add((Control)(object)DataGridView2);
		componentResourceManager.ApplyResources(Panel1, "Panel1");
		((Control)Panel1).Name = "Panel1";
		DataGridView3.AllowUserToAddRows = false;
		DataGridView3.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		DataGridView3.Columns.AddRange(new DataGridViewColumn[1] { (DataGridViewColumn)DataGridViewTextBoxColumn1 });
		val.Alignment = (DataGridViewContentAlignment)16;
		val.BackColor = SystemColors.Window;
		val.Font = new Font("Microsoft Sans Serif", 8f);
		val.ForeColor = SystemColors.ControlText;
		val.SelectionBackColor = SystemColors.Highlight;
		val.SelectionForeColor = SystemColors.HighlightText;
		val.WrapMode = (DataGridViewTriState)2;
		DataGridView3.DefaultCellStyle = val;
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
		val2.Alignment = (DataGridViewContentAlignment)16;
		val2.BackColor = SystemColors.Window;
		val2.Font = new Font("Microsoft Sans Serif", 8f);
		val2.ForeColor = SystemColors.ControlText;
		val2.SelectionBackColor = SystemColors.Highlight;
		val2.SelectionForeColor = SystemColors.HighlightText;
		val2.WrapMode = (DataGridViewTriState)2;
		DataGridView2.DefaultCellStyle = val2;
		componentResourceManager.ApplyResources(DataGridView2, "DataGridView2");
		((Control)DataGridView2).Name = "DataGridView2";
		componentResourceManager.ApplyResources(COL_1, "COL_1");
		((DataGridViewColumn)COL_1).Name = "COL_1";
		((DataGridViewColumn)COL_1).Resizable = (DataGridViewTriState)1;
		COL_1.SortMode = (DataGridViewColumnSortMode)0;
		componentResourceManager.ApplyResources(COL_2, "COL_2");
		((DataGridViewColumn)COL_2).Name = "COL_2";
		val3.Format = "N2";
		val3.NullValue = null;
		((DataGridViewColumn)COL_3).DefaultCellStyle = val3;
		componentResourceManager.ApplyResources(COL_3, "COL_3");
		((DataGridViewColumn)COL_3).Name = "COL_3";
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
		componentResourceManager.ApplyResources(ListBox_RAPPORT_GLOBALE, "ListBox_RAPPORT_GLOBALE");
		((ListControl)ListBox_RAPPORT_GLOBALE).FormattingEnabled = true;
		ListBox_RAPPORT_GLOBALE.Items.AddRange(new object[3]
		{
			componentResourceManager.GetString("ListBox_RAPPORT_GLOBALE.Items"),
			componentResourceManager.GetString("ListBox_RAPPORT_GLOBALE.Items1"),
			componentResourceManager.GetString("ListBox_RAPPORT_GLOBALE.Items2")
		});
		((Control)ListBox_RAPPORT_GLOBALE).Name = "ListBox_RAPPORT_GLOBALE";
		componentResourceManager.ApplyResources(ListBox_CAISSIERS, "ListBox_CAISSIERS");
		((ListControl)ListBox_CAISSIERS).FormattingEnabled = true;
		((Control)ListBox_CAISSIERS).Name = "ListBox_CAISSIERS";
		((Control)Label3).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Label3, "Label3");
		((Control)Label3).ForeColor = Color.Black;
		((Control)Label3).Name = "Label3";
		((Control)Label4).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Label4, "Label4");
		((Control)Label4).ForeColor = Color.Black;
		((Control)Label4).Name = "Label4";
		((Control)Label5).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Label5, "Label5");
		((Control)Label5).ForeColor = Color.Black;
		((Control)Label5).Name = "Label5";
		componentResourceManager.ApplyResources(Label21, "Label21");
		((Control)Label21).ForeColor = Color.FromArgb(44, 53, 68);
		((Control)Label21).Name = "Label21";
		componentResourceManager.ApplyResources(Label7, "Label7");
		((Control)Label7).ForeColor = Color.FromArgb(44, 53, 68);
		((Control)Label7).Name = "Label7";
		((Control)Panel_CLOTURE_GLOBALE).Controls.Add((Control)(object)Button_CLOTURE_GLOBALE);
		((Control)Panel_CLOTURE_GLOBALE).Controls.Add((Control)(object)Button_PrintRapport);
		((Control)Panel_CLOTURE_GLOBALE).Controls.Add((Control)(object)ListBox_RAPPORT_GLOBALE);
		((Control)Panel_CLOTURE_GLOBALE).Controls.Add((Control)(object)Label6);
		((Control)Panel_CLOTURE_GLOBALE).Controls.Add((Control)(object)Label2);
		((Control)Panel_CLOTURE_GLOBALE).Controls.Add((Control)(object)Label8);
		((Control)Panel_CLOTURE_GLOBALE).Controls.Add((Control)(object)Label_DATE_A_CLOTURE_GLOBALE);
		((Control)Panel_CLOTURE_GLOBALE).Controls.Add((Control)(object)Label_DATE_DE_CLOTURE_GLOBALE);
		((Control)Panel_CLOTURE_GLOBALE).Controls.Add((Control)(object)Button_TOTAL_GLOBALE);
		((Control)Panel_CLOTURE_GLOBALE).Controls.Add((Control)(object)Label_N_CLOTURE_CLOTURE_GLOBALE);
		((Control)Panel_CLOTURE_GLOBALE).Controls.Add((Control)(object)Button_ConsRapport);
		((Control)Panel_CLOTURE_GLOBALE).Controls.Add((Control)(object)Label_TOTAL_NET_CLOTURE_GLOBALE);
		((Control)Panel_CLOTURE_GLOBALE).Controls.Add((Control)(object)Label21);
		componentResourceManager.ApplyResources(Panel_CLOTURE_GLOBALE, "Panel_CLOTURE_GLOBALE");
		((Control)Panel_CLOTURE_GLOBALE).Name = "Panel_CLOTURE_GLOBALE";
		((Control)Button_PrintRapport).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Button_PrintRapport, "Button_PrintRapport");
		((Control)Button_PrintRapport).Name = "Button_PrintRapport";
		((ButtonBase)Button_PrintRapport).UseVisualStyleBackColor = true;
		((Control)Button_TOTAL_GLOBALE).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Button_TOTAL_GLOBALE, "Button_TOTAL_GLOBALE");
		((Control)Button_TOTAL_GLOBALE).ForeColor = Color.FromArgb(2, 45, 162);
		((Control)Button_TOTAL_GLOBALE).Name = "Button_TOTAL_GLOBALE";
		((ButtonBase)Button_TOTAL_GLOBALE).UseVisualStyleBackColor = true;
		((Control)Button_ConsRapport).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Button_ConsRapport, "Button_ConsRapport");
		((Control)Button_ConsRapport).Name = "Button_ConsRapport";
		((ButtonBase)Button_ConsRapport).UseVisualStyleBackColor = true;
		((Control)Panel_CLOTURE_CAISSIER).Controls.Add((Control)(object)Button_CLOTURE_CAISSIER);
		((Control)Panel_CLOTURE_CAISSIER).Controls.Add((Control)(object)ListBox_CAISSIERS);
		((Control)Panel_CLOTURE_CAISSIER).Controls.Add((Control)(object)Label_DATE_DE_CLOTURE_CAISSIER);
		((Control)Panel_CLOTURE_CAISSIER).Controls.Add((Control)(object)Label_DATE_A_CLOTURE_CAISSIER);
		((Control)Panel_CLOTURE_CAISSIER).Controls.Add((Control)(object)Label_N_CLOTURE_CLOTURE_CAISSIER);
		((Control)Panel_CLOTURE_CAISSIER).Controls.Add((Control)(object)Label3);
		((Control)Panel_CLOTURE_CAISSIER).Controls.Add((Control)(object)Button_ConsCaissier);
		((Control)Panel_CLOTURE_CAISSIER).Controls.Add((Control)(object)Label4);
		((Control)Panel_CLOTURE_CAISSIER).Controls.Add((Control)(object)Button_PrintCaissier);
		((Control)Panel_CLOTURE_CAISSIER).Controls.Add((Control)(object)Label5);
		((Control)Panel_CLOTURE_CAISSIER).Controls.Add((Control)(object)Button_TOTAL_CAISSIER);
		((Control)Panel_CLOTURE_CAISSIER).Controls.Add((Control)(object)Label_TOTAL_NET_CLOTURE_CAISSIER);
		((Control)Panel_CLOTURE_CAISSIER).Controls.Add((Control)(object)Label7);
		componentResourceManager.ApplyResources(Panel_CLOTURE_CAISSIER, "Panel_CLOTURE_CAISSIER");
		((Control)Panel_CLOTURE_CAISSIER).Name = "Panel_CLOTURE_CAISSIER";
		((Control)Button_ConsCaissier).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Button_ConsCaissier, "Button_ConsCaissier");
		((Control)Button_ConsCaissier).Name = "Button_ConsCaissier";
		((ButtonBase)Button_ConsCaissier).UseVisualStyleBackColor = true;
		((Control)Button_PrintCaissier).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Button_PrintCaissier, "Button_PrintCaissier");
		((Control)Button_PrintCaissier).Name = "Button_PrintCaissier";
		((ButtonBase)Button_PrintCaissier).UseVisualStyleBackColor = true;
		((Control)Button_TOTAL_CAISSIER).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Button_TOTAL_CAISSIER, "Button_TOTAL_CAISSIER");
		((Control)Button_TOTAL_CAISSIER).ForeColor = Color.FromArgb(2, 45, 162);
		((Control)Button_TOTAL_CAISSIER).Name = "Button_TOTAL_CAISSIER";
		((ButtonBase)Button_TOTAL_CAISSIER).UseVisualStyleBackColor = true;
		((Control)Panel_RAPPORT).Controls.Add((Control)(object)TabControlEx1);
		componentResourceManager.ApplyResources(Panel_RAPPORT, "Panel_RAPPORT");
		((Control)Panel_RAPPORT).Name = "Panel_RAPPORT";
		componentResourceManager.ApplyResources(TabControlEx1, "TabControlEx1");
		TabControlEx1.BackColor = Color.WhiteSmoke;
		((Control)TabControlEx1).Controls.Add((Control)(object)TabPage6);
		((Control)TabControlEx1).Controls.Add((Control)(object)TabPage1);
		TabControlEx1.DrawMode = (TabDrawMode)1;
		TabControlEx1.HeaderAlignment = (ContentAlignment)16;
		TabControlEx1.HeaderBackColor = Color.WhiteSmoke;
		TabControlEx1.HeaderFont = new Font("Segoe UI", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
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
		((Control)TabPage6).Controls.Add((Control)(object)Panel8);
		((Control)TabPage6).Controls.Add((Control)(object)Button_PrintRapport_HISTORIQUE);
		((Control)TabPage6).Controls.Add((Control)(object)Button_ConsRapport_HISTORIQUE);
		((Control)TabPage6).Controls.Add((Control)(object)Label23);
		((Control)TabPage6).Controls.Add((Control)(object)Button3);
		((Control)TabPage6).Controls.Add((Control)(object)Label18);
		componentResourceManager.ApplyResources(TabPage6, "TabPage6");
		((Control)TabPage6).Name = "TabPage6";
		TabPage6.UseVisualStyleBackColor = true;
		((Control)Panel8).BackColor = Color.FromArgb(250, 250, 250);
		((Control)Panel8).Controls.Add((Control)(object)Button7);
		((Control)Panel8).Controls.Add((Control)(object)DataGridView122323);
		((Control)Panel8).Controls.Add((Control)(object)Label27);
		((Control)Panel8).Controls.Add((Control)(object)Label28);
		((Control)Panel8).Controls.Add((Control)(object)Label29);
		((Control)Panel8).Controls.Add((Control)(object)Label30);
		((Control)Panel8).Controls.Add((Control)(object)DateTimePicker1);
		componentResourceManager.ApplyResources(Panel8, "Panel8");
		((Control)Panel8).Name = "Panel8";
		((ButtonBase)Button7).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Button7, "Button7");
		((Control)Button7).Cursor = Cursors.Hand;
		((ButtonBase)Button7).FlatAppearance.BorderSize = 0;
		((Control)Button7).Name = "Button7";
		((ButtonBase)Button7).UseVisualStyleBackColor = false;
		DataGridView122323.AllowUserToAddRows = false;
		DataGridView122323.AllowUserToResizeColumns = false;
		DataGridView122323.AllowUserToResizeRows = false;
		DataGridView122323.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)16;
		DataGridView122323.BackgroundColor = Color.White;
		val4.Alignment = (DataGridViewContentAlignment)16;
		val4.BackColor = SystemColors.Control;
		val4.Font = new Font("Calibri", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		val4.ForeColor = SystemColors.WindowText;
		val4.SelectionBackColor = SystemColors.Highlight;
		val4.SelectionForeColor = SystemColors.HighlightText;
		val4.WrapMode = (DataGridViewTriState)1;
		DataGridView122323.ColumnHeadersDefaultCellStyle = val4;
		DataGridView122323.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		DataGridView122323.Columns.AddRange(new DataGridViewColumn[4]
		{
			(DataGridViewColumn)DataGridViewTextBoxColumn8,
			(DataGridViewColumn)DataGridViewTextBoxColumn9,
			(DataGridViewColumn)DE,
			(DataGridViewColumn)A
		});
		DataGridView122323.EnableHeadersVisualStyles = false;
		componentResourceManager.ApplyResources(DataGridView122323, "DataGridView122323");
		((Control)DataGridView122323).Name = "DataGridView122323";
		DataGridView122323.RowHeadersVisible = false;
		DataGridView122323.SelectionMode = (DataGridViewSelectionMode)1;
		componentResourceManager.ApplyResources(DataGridViewTextBoxColumn8, "DataGridViewTextBoxColumn8");
		((DataGridViewColumn)DataGridViewTextBoxColumn8).Name = "DataGridViewTextBoxColumn8";
		componentResourceManager.ApplyResources(DataGridViewTextBoxColumn9, "DataGridViewTextBoxColumn9");
		((DataGridViewColumn)DataGridViewTextBoxColumn9).Name = "DataGridViewTextBoxColumn9";
		componentResourceManager.ApplyResources(DE, "DE");
		((DataGridViewColumn)DE).Name = "DE";
		componentResourceManager.ApplyResources(A, "A");
		((DataGridViewColumn)A).Name = "A";
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
		componentResourceManager.ApplyResources(DateTimePicker1, "DateTimePicker1");
		DateTimePicker1.Format = (DateTimePickerFormat)2;
		((Control)DateTimePicker1).Name = "DateTimePicker1";
		((Control)Button_PrintRapport_HISTORIQUE).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Button_PrintRapport_HISTORIQUE, "Button_PrintRapport_HISTORIQUE");
		((Control)Button_PrintRapport_HISTORIQUE).Name = "Button_PrintRapport_HISTORIQUE";
		((ButtonBase)Button_PrintRapport_HISTORIQUE).UseVisualStyleBackColor = true;
		((Control)Button_ConsRapport_HISTORIQUE).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Button_ConsRapport_HISTORIQUE, "Button_ConsRapport_HISTORIQUE");
		((Control)Button_ConsRapport_HISTORIQUE).Name = "Button_ConsRapport_HISTORIQUE";
		((ButtonBase)Button_ConsRapport_HISTORIQUE).UseVisualStyleBackColor = true;
		((Control)Label23).BackColor = Color.White;
		Label23.BorderStyle = (BorderStyle)1;
		componentResourceManager.ApplyResources(Label23, "Label23");
		((Control)Label23).ForeColor = Color.FromArgb(2, 45, 162);
		((Control)Label23).Name = "Label23";
		((Control)Button3).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Button3, "Button3");
		((Control)Button3).ForeColor = Color.FromArgb(2, 45, 162);
		((Control)Button3).Name = "Button3";
		((ButtonBase)Button3).UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(Label18, "Label18");
		((Control)Label18).BackColor = Color.Transparent;
		((Control)Label18).ForeColor = Color.FromArgb(44, 53, 68);
		((Control)Label18).Name = "Label18";
		((Control)TabPage1).Controls.Add((Control)(object)Button_PrintCaissier_HISTORIQUE);
		((Control)TabPage1).Controls.Add((Control)(object)Button_ConsCaissier_HISTORIQUE);
		((Control)TabPage1).Controls.Add((Control)(object)Label15);
		((Control)TabPage1).Controls.Add((Control)(object)Button10);
		((Control)TabPage1).Controls.Add((Control)(object)Label16);
		((Control)TabPage1).Controls.Add((Control)(object)Panel2);
		componentResourceManager.ApplyResources(TabPage1, "TabPage1");
		((Control)TabPage1).Name = "TabPage1";
		TabPage1.UseVisualStyleBackColor = true;
		((Control)Button_PrintCaissier_HISTORIQUE).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Button_PrintCaissier_HISTORIQUE, "Button_PrintCaissier_HISTORIQUE");
		((Control)Button_PrintCaissier_HISTORIQUE).Name = "Button_PrintCaissier_HISTORIQUE";
		((ButtonBase)Button_PrintCaissier_HISTORIQUE).UseVisualStyleBackColor = true;
		((Control)Button_ConsCaissier_HISTORIQUE).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Button_ConsCaissier_HISTORIQUE, "Button_ConsCaissier_HISTORIQUE");
		((Control)Button_ConsCaissier_HISTORIQUE).Name = "Button_ConsCaissier_HISTORIQUE";
		((ButtonBase)Button_ConsCaissier_HISTORIQUE).UseVisualStyleBackColor = true;
		((Control)Label15).BackColor = Color.White;
		Label15.BorderStyle = (BorderStyle)1;
		componentResourceManager.ApplyResources(Label15, "Label15");
		((Control)Label15).ForeColor = Color.FromArgb(2, 45, 162);
		((Control)Label15).Name = "Label15";
		((Control)Button10).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Button10, "Button10");
		((Control)Button10).ForeColor = Color.FromArgb(2, 45, 162);
		((Control)Button10).Name = "Button10";
		((ButtonBase)Button10).UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(Label16, "Label16");
		((Control)Label16).BackColor = Color.Transparent;
		((Control)Label16).ForeColor = Color.FromArgb(44, 53, 68);
		((Control)Label16).Name = "Label16";
		((Control)Panel2).BackColor = Color.FromArgb(250, 250, 250);
		((Control)Panel2).Controls.Add((Control)(object)Button6);
		((Control)Panel2).Controls.Add((Control)(object)Combo_CLOTURE_CAISSIER);
		((Control)Panel2).Controls.Add((Control)(object)DataGridView1434);
		((Control)Panel2).Controls.Add((Control)(object)Label10);
		((Control)Panel2).Controls.Add((Control)(object)Label11);
		((Control)Panel2).Controls.Add((Control)(object)Label12);
		((Control)Panel2).Controls.Add((Control)(object)Label13);
		((Control)Panel2).Controls.Add((Control)(object)DateTimePicker2);
		componentResourceManager.ApplyResources(Panel2, "Panel2");
		((Control)Panel2).Name = "Panel2";
		((ButtonBase)Button6).BackColor = Color.Transparent;
		componentResourceManager.ApplyResources(Button6, "Button6");
		((Control)Button6).Cursor = Cursors.Hand;
		((ButtonBase)Button6).FlatAppearance.BorderSize = 0;
		((Control)Button6).Name = "Button6";
		((ButtonBase)Button6).UseVisualStyleBackColor = false;
		Combo_CLOTURE_CAISSIER.DropDownStyle = (ComboBoxStyle)2;
		componentResourceManager.ApplyResources(Combo_CLOTURE_CAISSIER, "Combo_CLOTURE_CAISSIER");
		((ListControl)Combo_CLOTURE_CAISSIER).FormattingEnabled = true;
		((Control)Combo_CLOTURE_CAISSIER).Name = "Combo_CLOTURE_CAISSIER";
		DataGridView1434.AllowUserToAddRows = false;
		DataGridView1434.AllowUserToResizeColumns = false;
		DataGridView1434.AllowUserToResizeRows = false;
		DataGridView1434.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)16;
		DataGridView1434.BackgroundColor = Color.White;
		val5.Alignment = (DataGridViewContentAlignment)16;
		val5.BackColor = SystemColors.Control;
		val5.Font = new Font("Calibri", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		val5.ForeColor = SystemColors.WindowText;
		val5.SelectionBackColor = SystemColors.Highlight;
		val5.SelectionForeColor = SystemColors.HighlightText;
		val5.WrapMode = (DataGridViewTriState)1;
		DataGridView1434.ColumnHeadersDefaultCellStyle = val5;
		DataGridView1434.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		DataGridView1434.Columns.AddRange(new DataGridViewColumn[4]
		{
			(DataGridViewColumn)DataGridViewTextBoxColumn2,
			(DataGridViewColumn)DataGridViewTextBoxColumn3,
			(DataGridViewColumn)DEE,
			(DataGridViewColumn)AA
		});
		DataGridView1434.EnableHeadersVisualStyles = false;
		componentResourceManager.ApplyResources(DataGridView1434, "DataGridView1434");
		((Control)DataGridView1434).Name = "DataGridView1434";
		DataGridView1434.RowHeadersVisible = false;
		DataGridView1434.SelectionMode = (DataGridViewSelectionMode)1;
		componentResourceManager.ApplyResources(DataGridViewTextBoxColumn2, "DataGridViewTextBoxColumn2");
		((DataGridViewColumn)DataGridViewTextBoxColumn2).Name = "DataGridViewTextBoxColumn2";
		componentResourceManager.ApplyResources(DataGridViewTextBoxColumn3, "DataGridViewTextBoxColumn3");
		((DataGridViewColumn)DataGridViewTextBoxColumn3).Name = "DataGridViewTextBoxColumn3";
		componentResourceManager.ApplyResources(DEE, "DEE");
		((DataGridViewColumn)DEE).Name = "DEE";
		componentResourceManager.ApplyResources(AA, "AA");
		((DataGridViewColumn)AA).Name = "AA";
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
		((Control)Label13).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label13).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Label13, "Label13");
		((Control)Label13).ForeColor = Color.White;
		((Control)Label13).Name = "Label13";
		componentResourceManager.ApplyResources(DateTimePicker2, "DateTimePicker2");
		DateTimePicker2.Format = (DateTimePickerFormat)2;
		((Control)DateTimePicker2).Name = "DateTimePicker2";
		((TextBoxBase)Text_MAIL_TITRE).BorderStyle = (BorderStyle)1;
		componentResourceManager.ApplyResources(Text_MAIL_TITRE, "Text_MAIL_TITRE");
		((Control)Text_MAIL_TITRE).Name = "Text_MAIL_TITRE";
		componentResourceManager.ApplyResources(Button2, "Button2");
		((Control)Button2).Cursor = Cursors.Hand;
		((ButtonBase)Button2).FlatAppearance.BorderSize = 0;
		((Control)Button2).Name = "Button2";
		((ButtonBase)Button2).UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(Button244, "Button244");
		((ButtonBase)Button244).BackColor = Color.Red;
		((Control)Button244).Cursor = Cursors.Hand;
		((Control)Button244).ForeColor = Color.White;
		((Control)Button244).Name = "Button244";
		((ButtonBase)Button244).UseCompatibleTextRendering = true;
		((ButtonBase)Button244).UseVisualStyleBackColor = false;
		componentResourceManager.ApplyResources(Button_MAIL_CAISSIER, "Button_MAIL_CAISSIER");
		((Control)Button_MAIL_CAISSIER).Cursor = Cursors.Hand;
		((Control)Button_MAIL_CAISSIER).Name = "Button_MAIL_CAISSIER";
		((ButtonBase)Button_MAIL_CAISSIER).UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(Button_MAIL_GLOBALE, "Button_MAIL_GLOBALE");
		((Control)Button_MAIL_GLOBALE).Cursor = Cursors.Hand;
		((Control)Button_MAIL_GLOBALE).Name = "Button_MAIL_GLOBALE";
		((ButtonBase)Button_MAIL_GLOBALE).UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(Button1, "Button1");
		((Control)Button1).Cursor = Cursors.Hand;
		((ButtonBase)Button1).FlatAppearance.BorderSize = 0;
		((Control)Button1).Name = "Button1";
		((ButtonBase)Button1).UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(this, "$this");
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).BackColor = Color.White;
		((Control)this).Controls.Add((Control)(object)Text_MAIL_TITRE);
		((Control)this).Controls.Add((Control)(object)Button2);
		((Control)this).Controls.Add((Control)(object)Button244);
		((Control)this).Controls.Add((Control)(object)Label_LEFT);
		((Control)this).Controls.Add((Control)(object)Label_TOP);
		((Control)this).Controls.Add((Control)(object)Text_PRINTER_RAPPORT);
		((Control)this).Controls.Add((Control)(object)Text_mail);
		((Control)this).Controls.Add((Control)(object)Button_MAIL_CAISSIER);
		((Control)this).Controls.Add((Control)(object)Button_MAIL_GLOBALE);
		((Control)this).Controls.Add((Control)(object)Label_BOTTOM);
		((Control)this).Controls.Add((Control)(object)Label_RIGHT);
		((Control)this).Controls.Add((Control)(object)Panel1);
		((Control)this).Controls.Add((Control)(object)Button1);
		((Control)this).Controls.Add((Control)(object)Panel_CLOTURE_GLOBALE);
		((Control)this).Controls.Add((Control)(object)Panel_CLOTURE_CAISSIER);
		((Control)this).Controls.Add((Control)(object)Panel_RAPPORT);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "FormDialog_CLOTURE";
		((Form)this).ShowIcon = false;
		((Control)Panel1).ResumeLayout(false);
		((ISupportInitialize)DataGridView3).EndInit();
		((ISupportInitialize)DataGridView2).EndInit();
		((Control)Panel_CLOTURE_GLOBALE).ResumeLayout(false);
		((Control)Panel_CLOTURE_CAISSIER).ResumeLayout(false);
		((Control)Panel_RAPPORT).ResumeLayout(false);
		((Control)TabControlEx1).ResumeLayout(false);
		((Control)TabPage6).ResumeLayout(false);
		((Control)Panel8).ResumeLayout(false);
		((ISupportInitialize)DataGridView122323).EndInit();
		((Control)TabPage1).ResumeLayout(false);
		((Control)Panel2).ResumeLayout(false);
		((ISupportInitialize)DataGridView1434).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
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
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Expected Obj, but got Unknown
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Expected Obj, but got Unknown
		//IL_02e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ed: Expected Obj, but got Unknown
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Expected Obj, but got Unknown
		//IL_0576: Unknown result type (might be due to invalid IL or missing references)
		//IL_057c: Expected Obj, but got Unknown
		//IL_058c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0592: Expected Obj, but got Unknown
		Start_Print_COM_CL();
		PrintBuffer = "";
		prn.OpenPrint(Text_PRINTER_RAPPORT.Text);
		Print_COM_CL("\u001b@\u001b!\0\r\u001bc6\u0001\u001bR3\r\n");
		Print_COM_CL("\n");
		Print_COM_CL("\u001b!8\u001ba1CLOTURE GLOBALE");
		Print_COM_CL("\n");
		Print_COM_CL("\u001b!\0\u001ba0N CLOTURE        : " + Label_N_CLOTURE_CLOTURE_GLOBALE.Text);
		Print_COM_CL("\u001b!\0\u001ba0DE               : " + Label_DATE_DE_CLOTURE_GLOBALE.Text);
		Print_COM_CL("\u001b!\0\u001ba0A                : " + Label_DATE_A_CLOTURE_GLOBALE.Text);
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
			val = new MySqlDataAdapter("select sum(Total_NET) as n     from TABLE_VENTES_JOURNAL  WHERE   CLOTURE_GLOBALE IS  NULL  ", Module1.cn_SQL);
			((DbDataAdapter)(object)val).Fill(dataTable);
			num5 = Conversions.ToDouble(Strings.FormatNumber(Conversion.Val(dataTable.Rows[0]["n"].ToString())));
			Print_COM_CL("\u001b!8\u001ba0TOTAL NET: " + Conversions.ToString(Math.Round(new decimal(num5), 2)) + " DH");
			Print_COM_CL("\u001ba0\u001b!\0" + "-".PadRight(42, '-'));
			Print_COM_CL("\n");
			Print_COM_CL("\u001ba0\u001b!\0---------------FINANCE----------------");
			MySqlDataAdapter val2 = new MySqlDataAdapter();
			DataTable dataTable2 = new DataTable();
			val2 = new MySqlDataAdapter("(select sum(MONTANT) as n     from    TABLE_VENTES_REGLEMENTS     WHERE    CLOTURE_GLOBALE IS  NULL            And     MODE_P  = 'ESPECES'  )      UNION ALL        (select sum(MONTANT) as n from TABLE_VENTES_REGLEMENTS  WHERE    CLOTURE_GLOBALE IS  NULL             And     MODE_P  = 'CARTE'  )       UNION ALL        (select sum(MONTANT) as n from   TABLE_VENTES_REGLEMENTS   WHERE      CLOTURE_GLOBALE IS  NULL             And     MODE_P  = 'CHEQUE'  )     UNION ALL        (select sum(MONTANT) as n from   TABLE_VENTES_REGLEMENTS   WHERE       CLOTURE_GLOBALE IS  NULL             And     MODE_P  = 'CREDIT'  )       UNION ALL        (select sum(MONTANT) as n from   TABLE_VENTES_REGLEMENTS   WHERE      CLOTURE_GLOBALE IS  NULL             And     MODE_P  = 'AVOIR'  )        UNION ALL        (select sum(MONTANT) as n from   TABLE_VENTES_REGLEMENTS   WHERE      CLOTURE_GLOBALE IS  NULL             And     MODE_P  = 'RETOUR'  )  ", Module1.cn_SQL);
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
			val3 = new MySqlDataAdapter("select Caissier, sum(TOTAL_NET) as TOTAL_NET    from   TABLE_VENTES_JOURNAL    Where           CLOTURE_GLOBALE IS  NULL         group by Caissier      ", Module1.cn_SQL);
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
				Print_COM_CL("\u001b!\0\r\u001bc6\u0001\u001bR3" + text2);
				num13++;
			}
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
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected Obj, but got Unknown
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Expected Obj, but got Unknown
		//IL_031d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0323: Expected Obj, but got Unknown
		//IL_0406: Unknown result type (might be due to invalid IL or missing references)
		//IL_040c: Expected Obj, but got Unknown
		Start_Print_COM_CL();
		PrintBuffer = "";
		prn.OpenPrint(Text_PRINTER_RAPPORT.Text);
		Print_COM_CL("\u001b@\u001b!\0\r\u001bc6\u0001\u001bR3\r\n");
		Print_COM_CL("\n");
		Print_COM_CL("\u001b!8\u001ba1CLOTURE CAISSIER");
		Print_COM_CL("\n");
		Print_COM_CL("\u001b!\0\u001ba0N CAISSIER       : " + ListBox_CAISSIERS.Text);
		Print_COM_CL("\u001b!\0\u001ba0N CLOTURE        : " + Label_N_CLOTURE_CLOTURE_GLOBALE.Text);
		Print_COM_CL("\u001b!\0\u001ba0DE               : " + Label_DATE_DE_CLOTURE_GLOBALE.Text);
		Print_COM_CL("\u001b!\0\u001ba0A                : " + Label_DATE_A_CLOTURE_GLOBALE.Text);
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
			val = new MySqlDataAdapter("select sum(Total_NET) as n     from TABLE_VENTES_JOURNAL  WHERE          CLOTURE_CAISSIER IS  NULL       And     Caissier like  '" + Strings.Trim(ListBox_CAISSIERS.Text) + "'     ", Module1.cn_SQL);
			((DbDataAdapter)(object)val).Fill(dataTable);
			num5 = Conversions.ToDouble(Strings.FormatNumber(Conversion.Val(dataTable.Rows[0]["n"].ToString())));
			Print_COM_CL("\u001b!8\u001ba0TOTAL NET: " + Conversions.ToString(Math.Round(new decimal(num5), 2)) + " DH");
			Print_COM_CL("\u001ba0\u001b!\0" + "-".PadRight(42, '-'));
			Print_COM_CL("\n");
			Print_COM_CL("\u001ba0\u001b!\0---------------FINANCE----------------");
			MySqlDataAdapter val2 = new MySqlDataAdapter();
			DataTable dataTable2 = new DataTable();
			val2 = new MySqlDataAdapter("(select sum(MONTANT) as n     from    TABLE_VENTES_REGLEMENTS     WHERE     CLOTURE_CAISSIER IS  NULL                   And     Caissier like  '" + Strings.Trim(ListBox_CAISSIERS.Text) + "'                  And     MODE_P  = 'ESPECES'  )      UNION ALL        (select sum(MONTANT) as n from TABLE_VENTES_REGLEMENTS  WHERE    CLOTURE_CAISSIER IS  NULL                      And     Caissier like  '" + Strings.Trim(ListBox_CAISSIERS.Text) + "'               And     MODE_P  = 'CARTE'  )       UNION ALL        (select sum(MONTANT) as n from   TABLE_VENTES_REGLEMENTS   WHERE    CLOTURE_CAISSIER IS  NULL                  And     Caissier like  '" + Strings.Trim(ListBox_CAISSIERS.Text) + "'                 And     MODE_P  = 'CHEQUE'  )     UNION ALL        (select sum(MONTANT) as n from   TABLE_VENTES_REGLEMENTS   WHERE     CLOTURE_CAISSIER IS  NULL                     And     Caissier like  '" + Strings.Trim(ListBox_CAISSIERS.Text) + "'               And     MODE_P  = 'CREDIT'  )       UNION ALL        (select sum(MONTANT) as n from   TABLE_VENTES_REGLEMENTS   WHERE     CLOTURE_CAISSIER IS  NULL                   And     Caissier like  '" + Strings.Trim(ListBox_CAISSIERS.Text) + "'                 And     MODE_P  = 'AVOIR'  )         UNION ALL        (select sum(MONTANT) as n from   TABLE_VENTES_REGLEMENTS   WHERE     CLOTURE_CAISSIER IS  NULL                   And     Caissier like  '" + Strings.Trim(ListBox_CAISSIERS.Text) + "'                 And     MODE_P  = 'RETOUR'  )  ", Module1.cn_SQL);
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

	private void FormDialog_CLOTURE_Load(object sender, EventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected Obj, but got Unknown
		//IL_0479: Unknown result type (might be due to invalid IL or missing references)
		//IL_0480: Expected Obj, but got Unknown
		checked
		{
			try
			{
				DataTable dataTable = new DataTable();
				MySqlDataAdapter val = new MySqlDataAdapter();
				dataTable.Clear();
				val = new MySqlDataAdapter("select * from TABLE_PASS  order by ID asc", Module1.cn_SQL);
				((DbDataAdapter)(object)val).Fill(dataTable);
				ListBox_CAISSIERS.Items.Clear();
				Combo_CLOTURE_CAISSIER.Items.Clear();
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
					Combo_CLOTURE_CAISSIER.Items.Add((object)ListBox_CAISSIERS.Items[num2].ToString());
					num2++;
				}
				ListBox_RAPPORT_GLOBALE.SelectedIndex = 0;
				ListBox_CAISSIERS.SelectedIndex = 0;
				Text_mail.Text = MyProject.Forms.Form_0_TEMPLATE.ListView1.Items[MyProject.Forms.Form_0_TEMPLATE.ListView1.FindItemWithText("MAIL_ADRESSE", false, 0).Index].SubItems[1].Text;
				Text_MAIL_TITRE.Text = MyProject.Forms.Form_0_TEMPLATE.ListView1.Items[MyProject.Forms.Form_0_TEMPLATE.ListView1.FindItemWithText("MAIL_TITRE", false, 0).Index].SubItems[1].Text;
				Text_PRINTER_RAPPORT.Text = File.ReadAllText(Application.StartupPath + "/PRINTER_RAPPORT.sni");
				ListBox_CAISSIERS.Text = Module1._USERNAME;
				((Control)Panel_CLOTURE_GLOBALE).BringToFront();
				if (((Control)MyProject.Forms.Form_3_VENTE).Visible && Conversions.ToBoolean(MyProject.Forms.Form_0_TEMPLATE.ListView1.Items[MyProject.Forms.Form_0_TEMPLATE.ListView1.FindItemWithText("CLOTURE_CAISSIER_OBLIGER", false, 0).Index].SubItems[1].Text))
				{
					((Control)Panel_CLOTURE_CAISSIER).Visible = true;
					((Control)Panel_CLOTURE_CAISSIER).BringToFront();
					ListBox_CAISSIERS.Text = Module1._USERNAME;
					((Control)Button1).Enabled = false;
					((Control)Button2).Enabled = false;
				}
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
			NewLateBinding.LateSet(sender, null, "enabled", new object[1] { true }, null, null);
		}
	}

	private void Button_TOTAL_GLOBALE_Click(object sender, EventArgs e)
	{
		//IL_043b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0442: Expected Obj, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected Obj, but got Unknown
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected Obj, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected Obj, but got Unknown
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Expected Obj, but got Unknown
		//IL_02e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Expected Obj, but got Unknown
		try
		{
			NewLateBinding.LateSet(sender, null, "enabled", new object[1] { false }, null, null);
			Application.DoEvents();
			if (((Control)MyProject.Forms.Form_3_VENTE_JOURNAL).Visible)
			{
				DT.Clear();
				DA = new MySqlDataAdapter("select * from   TABLE_VENTES_JOURNAL     Where        CLOTURE_GLOBALE IS  NULL      order by ID desc ", Module1.cn_SQL);
				((DbDataAdapter)(object)DA).Fill(DT);
				MyProject.Forms.Form_3_VENTE_JOURNAL.DataGridView1.DataSource = DT;
				MyProject.Forms.Form_3_VENTE_JOURNAL._COLORISE_DATAGRID();
			}
			_dt.Clear();
			_dt = new DataTable();
			_da = new MySqlDataAdapter("select sum(TOTAL_NET) as n from TABLE_VENTES_JOURNAL WHERE        CLOTURE_GLOBALE IS  NULL             and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')         ", Module1.cn_SQL);
			((DbDataAdapter)(object)_da).Fill(_dt);
			Label_TOTAL_NET_CLOTURE_GLOBALE.Text = Strings.FormatNumber(Conversion.Val(_dt.Rows[0]["n"].ToString()));
			_dt.Clear();
			_dt = new DataTable();
			_da = new MySqlDataAdapter("select    TOP 1    *     from     TABLE_VENTES_JOURNAL           Where         CLOTURE_GLOBALE IS  NOT NULL       ORDER BY ID DESC    ", Module1.cn_SQL);
			((DbDataAdapter)(object)_da).Fill(_dt);
			if (_dt.Rows.Count == 0)
			{
				Label_N_CLOTURE_CLOTURE_GLOBALE.Text = Conversions.ToString(Conversions.ToDouble(Strings.FormatNumber(0)) + 1.0);
			}
			else
			{
				Label_N_CLOTURE_CLOTURE_GLOBALE.Text = Conversions.ToString(Conversions.ToDouble(Strings.FormatNumber(Conversion.Val(_dt.Rows[0]["CLOTURE_GLOBALE"].ToString()))) + 1.0);
			}
			_dt.Clear();
			_dt = new DataTable();
			_da = new MySqlDataAdapter("select      TOP 1    *     from     TABLE_VENTES_JOURNAL       Where        CLOTURE_GLOBALE  IS  NULL     ORDER BY ID   ASC ", Module1.cn_SQL);
			((DbDataAdapter)(object)_da).Fill(_dt);
			if (_dt.Rows.Count == 0)
			{
				Label_DATE_DE_CLOTURE_GLOBALE.Text = "-";
			}
			else
			{
				Label_DATE_DE_CLOTURE_GLOBALE.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(_dt.Rows[0]["Dates"], " "), _dt.Rows[0]["Heure"]));
			}
			_dt.Clear();
			_dt = new DataTable();
			_da = new MySqlDataAdapter("select      TOP 1    *     from     TABLE_VENTES_JOURNAL       Where        CLOTURE_GLOBALE  IS  NULL       ORDER BY ID DESC  ", Module1.cn_SQL);
			((DbDataAdapter)(object)_da).Fill(_dt);
			if (_dt.Rows.Count == 0)
			{
				Label_DATE_A_CLOTURE_GLOBALE.Text = "-";
			}
			else
			{
				Label_DATE_A_CLOTURE_GLOBALE.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(_dt.Rows[0]["Dates"], " "), _dt.Rows[0]["Heure"]));
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
		NewLateBinding.LateSet(sender, null, "enabled", new object[1] { true }, null, null);
	}

	private void Combo_CAISSIER_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	private void Button_CLOTURE_GLOBALE_Click(object sender, EventArgs e)
	{
		//IL_05f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fd: Expected Obj, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected Obj, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected Obj, but got Unknown
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Expected Obj, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
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
					catch (Exception ex6)
					{
						ProjectData.SetProjectError(ex6);
						Exception e3 = ex6;
						StackTrace stackTrace3 = new StackTrace(e3, fNeedFileInfo: true);
						StackFrame frame3 = stackTrace3.GetFrame(stackTrace3.FrameCount - 1);
						int fileLineNumber3 = frame3.GetFileLineNumber();
						ProjectData.ClearProjectError();
					}
					Thread.Sleep(100);
				});
				thread.SetApartmentState(ApartmentState.STA);
				thread.IsBackground = true;
				thread.Start();
				if (Conversions.ToBoolean(MyProject.Forms.Form_0_TEMPLATE.ListView1.Items[MyProject.Forms.Form_0_TEMPLATE.ListView1.FindItemWithText("CLOTURE_CAISSIER_OBLIGER", false, 0).Index].SubItems[1].Text))
				{
					DataTable dataTable = new DataTable();
					MySqlDataAdapter val = new MySqlDataAdapter();
					dataTable.Clear();
					val = new MySqlDataAdapter("select DISTINCT CAISSIER  from TABLE_VENTES_JOURNAL   Where  CLOTURE_CAISSIER IS  NULL         ", Module1.cn_SQL);
					((DbDataAdapter)(object)val).Fill(dataTable);
					string text = "";
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
						text = text + " " + dataTable.Rows[num2]["CAISSIER"].ToString();
						num2++;
					}
					if (Strings.Trim(text).Length > 0)
					{
						Module1._QUITTER_PATIENTER = true;
						MessageBox.Show("Veuillez Cloturer Tous les Caissiers " + Strings.Trim(text), "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
						return;
					}
				}
				Button_TOTAL_GLOBALE.PerformClick();
				if (!Versioned.IsNumeric(Label_N_CLOTURE_CLOTURE_GLOBALE.Text) | !Information.IsDate(Label_DATE_DE_CLOTURE_GLOBALE.Text) | !Information.IsDate(Label_DATE_A_CLOTURE_GLOBALE.Text))
				{
					Module1._QUITTER_PATIENTER = true;
					NewLateBinding.LateSet(sender, null, "enabled", new object[1] { true }, null, null);
					return;
				}
				Button_PrintRapport.PerformClick();
				NewLateBinding.LateSet(sender, null, "enabled", new object[1] { false }, null, null);
				MySqlCommand val2 = new MySqlCommand();
				if (Module1.cn_SQL.State != ConnectionState.Open)
				{
					Module1.cn_SQL.Open();
				}
				MySqlTransaction val3 = (val2.Transaction = Module1.cn_SQL.BeginTransaction());
				try
				{
					val2.CommandText = "UPDATE    TABLE_VENTES_JOURNAL      SET   CLOTURE_GLOBALE = '" + Label_N_CLOTURE_CLOTURE_GLOBALE.Text + "'      WHERE       CLOTURE_GLOBALE   IS  NULL    ";
					val2.Connection = Module1.cn_SQL;
					val2.ExecuteNonQuery();
					val2.CommandText = "UPDATE    TABLE_VENTES_ENTETE       SET   CLOTURE_GLOBALE = '" + Label_N_CLOTURE_CLOTURE_GLOBALE.Text + "'      WHERE       CLOTURE_GLOBALE   IS  NULL     ";
					val2.Connection = Module1.cn_SQL;
					val2.ExecuteNonQuery();
					val2.CommandText = "UPDATE    TABLE_VENTES_REGLEMENTS   SET   CLOTURE_GLOBALE = '" + Label_N_CLOTURE_CLOTURE_GLOBALE.Text + "'      WHERE       CLOTURE_GLOBALE   IS  NULL    ";
					val2.Connection = Module1.cn_SQL;
					val2.ExecuteNonQuery();
					val2.CommandText = "UPDATE    TABLE_DEPENSES            SET   CLOTURE_GLOBALE = '" + Label_N_CLOTURE_CLOTURE_GLOBALE.Text + "'      WHERE       CLOTURE_GLOBALE   IS  NULL    ";
					val2.Connection = Module1.cn_SQL;
					val2.ExecuteNonQuery();
					val2.CommandText = "UPDATE    TABLE_FOURNISSEURS_REGLE  SET   CLOTURE_GLOBALE = '" + Label_N_CLOTURE_CLOTURE_GLOBALE.Text + "'      WHERE       CLOTURE_GLOBALE   IS  NULL    ";
					val2.Connection = Module1.cn_SQL;
					val2.ExecuteNonQuery();
					val2.CommandText = "UPDATE    TABLE_CLIENTS_REGLE       SET   CLOTURE_GLOBALE = '" + Label_N_CLOTURE_CLOTURE_GLOBALE.Text + "'      WHERE       CLOTURE_GLOBALE   IS  NULL    ";
					val2.Connection = Module1.cn_SQL;
					val2.ExecuteNonQuery();
					val2.CommandText = "UPDATE    TABLE_POUBELLE            SET   CLOTURE_GLOBALE = '" + Label_N_CLOTURE_CLOTURE_GLOBALE.Text + "'      WHERE       CLOTURE_GLOBALE   IS  NULL    ";
					val2.Connection = Module1.cn_SQL;
					val2.ExecuteNonQuery();
					val3.Commit();
					Module1.cn_SQL.Close();
					string right = "CLOTURE | " + Label_TOTAL_NET_CLOTURE_GLOBALE.Text;
					File.AppendAllText(Application.StartupPath + "\\log.sni", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(Strings.Format(DateTime.Now, "ddMMyy HHmmss fff") + MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text, " | "), Module1._USERNAME), " | "), ((Control)this).Name), " | "), NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null)), " | "), right), "\r\n")), Encoding.UTF8);
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception e2 = ex;
					StackTrace stackTrace = new StackTrace(e2, fNeedFileInfo: true);
					StackFrame frame = stackTrace.GetFrame(stackTrace.FrameCount - 1);
					int fileLineNumber = frame.GetFileLineNumber();
					val3.Rollback();
					Module1._QUITTER_PATIENTER = true;
					NewLateBinding.LateSet(sender, null, "enabled", new object[1] { true }, null, null);
					Interaction.MsgBox("Transaction Erreur :" + Information.Err().Description);
					ProjectData.ClearProjectError();
				}
				Module1._QUITTER_PATIENTER = true;
				NewLateBinding.LateSet(sender, null, "enabled", new object[1] { true }, null, null);
				Application.Restart();
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex3 = ex2;
				StackTrace stackTrace2 = new StackTrace(ex3, fNeedFileInfo: true);
				StackFrame frame2 = stackTrace2.GetFrame(stackTrace2.FrameCount - 1);
				int fileLineNumber2 = frame2.GetFileLineNumber();
				Module1._QUITTER_PATIENTER = true;
				NewLateBinding.LateSet(sender, null, "enabled", new object[1] { true }, null, null);
				Interaction.MsgBox(ex3.Message + "\r\nLigne : " + Conversions.ToString(fileLineNumber2) + "\r\n");
				try
				{
					string text2 = Strings.Format(DateTime.Now, "yyMMddHHmmssfff");
					Bitmap val5 = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, (PixelFormat)2498570);
					Graphics val6 = Graphics.FromImage((Image)(object)val5);
					val6.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, (CopyPixelOperation)13369376);
					((Image)val5).Save(Application.StartupPath + "\\tchak\\" + text2 + ".snidb", ImageFormat.Jpeg);
					val5 = null;
					string right2 = "ERROR | ";
					File.AppendAllText(Application.StartupPath + "\\log_erreur.sni", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(text2 + " | ", MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text), " | "), Module1._USERNAME), " | "), ((Control)this).Name), " | "), NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null)), " | "), right2), " | "), ex3.ToString()), "\r\n"), "Ligne : "), fileLineNumber2), "\r\n"), "\r\n"), "##########################################################################################################"), "\r\n")), Encoding.UTF8);
				}
				catch (Exception ex4)
				{
					ProjectData.SetProjectError(ex4);
					Exception ex5 = ex4;
					ProjectData.ClearProjectError();
				}
				ProjectData.ClearProjectError();
			}
		}
	}

	private void Button_CLOTURE_CAISSIER_Click(object sender, EventArgs e)
	{
		//IL_0684: Unknown result type (might be due to invalid IL or missing references)
		//IL_068b: Expected Obj, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected Obj, but got Unknown
		checked
		{
			try
			{
				if (Operators.CompareString(ListBox_CAISSIERS.Text, "", TextCompare: false) == 0)
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
					catch (Exception ex6)
					{
						ProjectData.SetProjectError(ex6);
						Exception e3 = ex6;
						StackTrace stackTrace3 = new StackTrace(e3, fNeedFileInfo: true);
						StackFrame frame3 = stackTrace3.GetFrame(stackTrace3.FrameCount - 1);
						int fileLineNumber3 = frame3.GetFileLineNumber();
						ProjectData.ClearProjectError();
					}
					Thread.Sleep(100);
				});
				thread.SetApartmentState(ApartmentState.STA);
				thread.IsBackground = true;
				thread.Start();
				Button_TOTAL_CAISSIER.PerformClick();
				if (!Versioned.IsNumeric(Label_N_CLOTURE_CLOTURE_CAISSIER.Text) | !Information.IsDate(Label_DATE_DE_CLOTURE_CAISSIER.Text) | !Information.IsDate(Label_DATE_A_CLOTURE_CAISSIER.Text))
				{
					Module1._QUITTER_PATIENTER = true;
					NewLateBinding.LateSet(sender, null, "enabled", new object[1] { true }, null, null);
					return;
				}
				Button_PrintCaissier.PerformClick();
				NewLateBinding.LateSet(sender, null, "enabled", new object[1] { false }, null, null);
				MySqlCommand val = new MySqlCommand();
				if (Module1.cn_SQL.State != ConnectionState.Open)
				{
					Module1.cn_SQL.Open();
				}
				MySqlTransaction val2 = (val.Transaction = Module1.cn_SQL.BeginTransaction());
				try
				{
					val.CommandText = "UPDATE    TABLE_VENTES_JOURNAL      SET   CLOTURE_CAISSIER = '" + Label_N_CLOTURE_CLOTURE_CAISSIER.Text + "'      WHERE       CLOTURE_CAISSIER   IS  NULL    AND    Caissier like  '" + Strings.Trim(ListBox_CAISSIERS.Text) + "'      ";
					val.Connection = Module1.cn_SQL;
					val.ExecuteNonQuery();
					val.CommandText = "UPDATE    TABLE_VENTES_ENTETE       SET   CLOTURE_CAISSIER = '" + Label_N_CLOTURE_CLOTURE_CAISSIER.Text + "'      WHERE       CLOTURE_CAISSIER   IS  NULL    AND    Caissier like  '" + Strings.Trim(ListBox_CAISSIERS.Text) + "'          ";
					val.Connection = Module1.cn_SQL;
					val.ExecuteNonQuery();
					val.CommandText = "UPDATE    TABLE_VENTES_REGLEMENTS   SET   CLOTURE_CAISSIER = '" + Label_N_CLOTURE_CLOTURE_CAISSIER.Text + "'      WHERE       CLOTURE_CAISSIER   IS  NULL    AND    Caissier like  '" + Strings.Trim(ListBox_CAISSIERS.Text) + "'          ";
					val.Connection = Module1.cn_SQL;
					val.ExecuteNonQuery();
					val.CommandText = "UPDATE    TABLE_DEPENSES            SET   CLOTURE_CAISSIER = '" + Label_N_CLOTURE_CLOTURE_CAISSIER.Text + "'      WHERE       CLOTURE_CAISSIER   IS  NULL    AND    UTILISATEUR like  '" + Strings.Trim(ListBox_CAISSIERS.Text) + "'          ";
					val.Connection = Module1.cn_SQL;
					val.ExecuteNonQuery();
					val.CommandText = "UPDATE    TABLE_FOURNISSEURS_REGLE  SET   CLOTURE_CAISSIER = '" + Label_N_CLOTURE_CLOTURE_CAISSIER.Text + "'      WHERE       CLOTURE_CAISSIER   IS  NULL    AND    UTILISATEUR like  '" + Strings.Trim(ListBox_CAISSIERS.Text) + "'          ";
					val.Connection = Module1.cn_SQL;
					val.ExecuteNonQuery();
					val.CommandText = "UPDATE    TABLE_CLIENTS_REGLE       SET   CLOTURE_CAISSIER = '" + Label_N_CLOTURE_CLOTURE_CAISSIER.Text + "'      WHERE       CLOTURE_CAISSIER   IS  NULL    AND    UTILISATEUR like  '" + Strings.Trim(ListBox_CAISSIERS.Text) + "'          ";
					val.Connection = Module1.cn_SQL;
					val.ExecuteNonQuery();
					val.CommandText = "UPDATE    TABLE_POUBELLE            SET   CLOTURE_CAISSIER = '" + Label_N_CLOTURE_CLOTURE_CAISSIER.Text + "'      WHERE       CLOTURE_CAISSIER   IS  NULL    AND    Caissier like  '" + Strings.Trim(ListBox_CAISSIERS.Text) + "'          ";
					val.Connection = Module1.cn_SQL;
					val.ExecuteNonQuery();
					val2.Commit();
					Module1.cn_SQL.Close();
					string right = "CLOTURE | " + Label_TOTAL_NET_CLOTURE_CAISSIER.Text;
					File.AppendAllText(Application.StartupPath + "\\log.sni", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(Strings.Format(DateTime.Now, "ddMMyy HHmmss fff") + MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text, " | "), Module1._USERNAME), " | "), ((Control)this).Name), " | "), NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null)), " | "), right), "\r\n")), Encoding.UTF8);
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception e2 = ex;
					StackTrace stackTrace = new StackTrace(e2, fNeedFileInfo: true);
					StackFrame frame = stackTrace.GetFrame(stackTrace.FrameCount - 1);
					int fileLineNumber = frame.GetFileLineNumber();
					val2.Rollback();
					Module1._QUITTER_PATIENTER = true;
					NewLateBinding.LateSet(sender, null, "enabled", new object[1] { true }, null, null);
					Interaction.MsgBox("Transaction Erreur :" + Information.Err().Description);
					ProjectData.ClearProjectError();
				}
				Module1._QUITTER_PATIENTER = true;
				NewLateBinding.LateSet(sender, null, "enabled", new object[1] { true }, null, null);
				Application.Restart();
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex3 = ex2;
				StackTrace stackTrace2 = new StackTrace(ex3, fNeedFileInfo: true);
				StackFrame frame2 = stackTrace2.GetFrame(stackTrace2.FrameCount - 1);
				int fileLineNumber2 = frame2.GetFileLineNumber();
				Module1._QUITTER_PATIENTER = true;
				NewLateBinding.LateSet(sender, null, "enabled", new object[1] { true }, null, null);
				Interaction.MsgBox(ex3.Message + "\r\nLigne : " + Conversions.ToString(fileLineNumber2) + "\r\n");
				try
				{
					string text = Strings.Format(DateTime.Now, "yyMMddHHmmssfff");
					Bitmap val4 = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, (PixelFormat)2498570);
					Graphics val5 = Graphics.FromImage((Image)(object)val4);
					val5.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, (CopyPixelOperation)13369376);
					((Image)val4).Save(Application.StartupPath + "\\tchak\\" + text + ".snidb", ImageFormat.Jpeg);
					val4 = null;
					string right2 = "ERROR | ";
					File.AppendAllText(Application.StartupPath + "\\log_erreur.sni", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(text + " | ", MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text), " | "), Module1._USERNAME), " | "), ((Control)this).Name), " | "), NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null)), " | "), right2), " | "), ex3.ToString()), "\r\n"), "Ligne : "), fileLineNumber2), "\r\n"), "\r\n"), "##########################################################################################################"), "\r\n")), Encoding.UTF8);
				}
				catch (Exception ex4)
				{
					ProjectData.SetProjectError(ex4);
					Exception ex5 = ex4;
					ProjectData.ClearProjectError();
				}
				ProjectData.ClearProjectError();
			}
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
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected Obj, but got Unknown
		//IL_00d7: Expected Obj, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected Obj, but got Unknown
		//IL_0121: Expected Obj, but got Unknown
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected Obj, but got Unknown
		//IL_016b: Expected Obj, but got Unknown
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Expected Obj, but got Unknown
		//IL_01a5: Expected Obj, but got Unknown
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Expected Obj, but got Unknown
		//IL_01df: Expected Obj, but got Unknown
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Expected Obj, but got Unknown
		//IL_0219: Expected Obj, but got Unknown
		//IL_075f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0766: Expected Obj, but got Unknown
		//IL_03f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fc: Expected Obj, but got Unknown
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
		//IL_03a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c9: Expected Obj, but got Unknown
		//IL_03c9: Expected Obj, but got Unknown
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e7: Expected Obj, but got Unknown
		//IL_02e7: Expected Obj, but got Unknown
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
				string text = "CLOTURE GLOBALE";
				e.Graphics.DrawString(text, new Font("Inconsolata Condensed", 13f, (FontStyle)1), Brushes.White, Convert.ToSingle(130f - e.Graphics.MeasureString(text, new Font("Inconsolata Condensed", 13f, (FontStyle)1)).Width / 2f), 0f, new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("N CLOTURE        : " + Label_N_CLOTURE_CLOTURE_GLOBALE.Text, new Font("Inconsolata Condensed", 10f, (FontStyle)1), Brushes.Black, 0f, 75f, new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("DE               : " + Label_DATE_DE_CLOTURE_GLOBALE.Text, new Font("Inconsolata Condensed", 10f, (FontStyle)1), Brushes.Black, 0f, 85f, new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("A                : " + Label_DATE_A_CLOTURE_GLOBALE.Text, new Font("Inconsolata Condensed", 10f, (FontStyle)1), Brushes.Black, 0f, 95f, new StringFormat((StringFormatFlags)8192));
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
				val = new MySqlDataAdapter("select sum(Total_NET) as n     from TABLE_VENTES_JOURNAL  WHERE   CLOTURE_GLOBALE IS  NULL         and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')     ", Module1.cn_SQL);
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
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected Obj, but got Unknown
		//IL_0121: Expected Obj, but got Unknown
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected Obj, but got Unknown
		//IL_016b: Expected Obj, but got Unknown
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Expected Obj, but got Unknown
		//IL_01b5: Expected Obj, but got Unknown
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Expected Obj, but got Unknown
		//IL_01ef: Expected Obj, but got Unknown
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Expected Obj, but got Unknown
		//IL_0229: Expected Obj, but got Unknown
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Expected Obj, but got Unknown
		//IL_0263: Expected Obj, but got Unknown
		//IL_07c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ca: Expected Obj, but got Unknown
		//IL_043f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0446: Expected Obj, but got Unknown
		//IL_0472: Unknown result type (might be due to invalid IL or missing references)
		//IL_0479: Expected Obj, but got Unknown
		//IL_04d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0500: Unknown result type (might be due to invalid IL or missing references)
		//IL_050a: Expected Obj, but got Unknown
		//IL_050a: Expected Obj, but got Unknown
		//IL_053e: Unknown result type (might be due to invalid IL or missing references)
		//IL_056c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0576: Expected Obj, but got Unknown
		//IL_0576: Expected Obj, but got Unknown
		//IL_058d: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c5: Expected Obj, but got Unknown
		//IL_05c5: Expected Obj, but got Unknown
		//IL_03ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0409: Unknown result type (might be due to invalid IL or missing references)
		//IL_0413: Expected Obj, but got Unknown
		//IL_0413: Expected Obj, but got Unknown
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_0331: Expected Obj, but got Unknown
		//IL_0331: Expected Obj, but got Unknown
		//IL_0636: Unknown result type (might be due to invalid IL or missing references)
		//IL_0664: Unknown result type (might be due to invalid IL or missing references)
		//IL_066e: Expected Obj, but got Unknown
		//IL_066e: Expected Obj, but got Unknown
		//IL_0693: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d0: Expected Obj, but got Unknown
		//IL_0718: Unknown result type (might be due to invalid IL or missing references)
		//IL_0722: Expected Obj, but got Unknown
		//IL_0722: Expected Obj, but got Unknown
		checked
		{
			try
			{
				e.Graphics.FillRectangle((Brush)new SolidBrush(Color.Black), 0, 0, 260, 20);
				string text = "CLOTURE CAISSIER";
				e.Graphics.DrawString(text, new Font("Inconsolata Condensed", 13f, (FontStyle)1), Brushes.White, Convert.ToSingle(130f - e.Graphics.MeasureString(text, new Font("Inconsolata Condensed", 13f, (FontStyle)1)).Width / 2f), 0f, new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("CAISSIER         : " + ListBox_CAISSIERS.Text, new Font("Inconsolata Condensed", 10f, (FontStyle)1), Brushes.Black, 0f, 65f, new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("N CLOTURE        : " + Label_N_CLOTURE_CLOTURE_CAISSIER.Text, new Font("Inconsolata Condensed", 10f, (FontStyle)1), Brushes.Black, 0f, 75f, new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("DE               : " + Label_DATE_DE_CLOTURE_CAISSIER.Text, new Font("Inconsolata Condensed", 10f, (FontStyle)1), Brushes.Black, 0f, 85f, new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("A                : " + Label_DATE_A_CLOTURE_CAISSIER.Text, new Font("Inconsolata Condensed", 10f, (FontStyle)1), Brushes.Black, 0f, 95f, new StringFormat((StringFormatFlags)8192));
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
				val = new MySqlDataAdapter("select sum(Total_NET) as n     from TABLE_VENTES_JOURNAL  WHERE          CLOTURE_CAISSIER IS  NULL       And     Caissier like  '" + Strings.Trim(ListBox_CAISSIERS.Text) + "'           and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')      ", Module1.cn_SQL);
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

	private void Print_Recette_Globale_HISTORIQUE_PrintPage(object sender, PrintPageEventArgs e)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected Obj, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected Obj, but got Unknown
		//IL_008d: Expected Obj, but got Unknown
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected Obj, but got Unknown
		//IL_0101: Expected Obj, but got Unknown
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Expected Obj, but got Unknown
		//IL_0175: Expected Obj, but got Unknown
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected Obj, but got Unknown
		//IL_01e9: Expected Obj, but got Unknown
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Expected Obj, but got Unknown
		//IL_0223: Expected Obj, but got Unknown
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected Obj, but got Unknown
		//IL_025d: Expected Obj, but got Unknown
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Expected Obj, but got Unknown
		//IL_0297: Expected Obj, but got Unknown
		//IL_0821: Unknown result type (might be due to invalid IL or missing references)
		//IL_0828: Expected Obj, but got Unknown
		//IL_0473: Unknown result type (might be due to invalid IL or missing references)
		//IL_047a: Expected Obj, but got Unknown
		//IL_04d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d7: Expected Obj, but got Unknown
		//IL_0530: Unknown result type (might be due to invalid IL or missing references)
		//IL_055e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0568: Expected Obj, but got Unknown
		//IL_0568: Expected Obj, but got Unknown
		//IL_059c: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d4: Expected Obj, but got Unknown
		//IL_05d4: Expected Obj, but got Unknown
		//IL_05eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0619: Unknown result type (might be due to invalid IL or missing references)
		//IL_0623: Expected Obj, but got Unknown
		//IL_0623: Expected Obj, but got Unknown
		//IL_041e: Unknown result type (might be due to invalid IL or missing references)
		//IL_043d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0447: Expected Obj, but got Unknown
		//IL_0447: Expected Obj, but got Unknown
		//IL_033c: Unknown result type (might be due to invalid IL or missing references)
		//IL_035b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0365: Expected Obj, but got Unknown
		//IL_0365: Expected Obj, but got Unknown
		//IL_0694: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cc: Expected Obj, but got Unknown
		//IL_06cc: Expected Obj, but got Unknown
		//IL_06f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0724: Unknown result type (might be due to invalid IL or missing references)
		//IL_072e: Expected Obj, but got Unknown
		//IL_0776: Unknown result type (might be due to invalid IL or missing references)
		//IL_0780: Expected Obj, but got Unknown
		//IL_0780: Expected Obj, but got Unknown
		checked
		{
			try
			{
				e.Graphics.FillRectangle((Brush)new SolidBrush(Color.Black), 0, 0, 260, 20);
				string text = "HISTORIQUE CLOTURE GLOBALE";
				e.Graphics.DrawString(text, new Font("Inconsolata Condensed", 13f, (FontStyle)1), Brushes.White, Convert.ToSingle(130f - e.Graphics.MeasureString(text, new Font("Inconsolata Condensed", 13f, (FontStyle)1)).Width / 2f), 0f, new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString(Conversions.ToString(Operators.ConcatenateObject("N CLOTURE        : ", DataGridView122323.Rows[((DataGridViewBand)DataGridView122323.CurrentRow).Index].Cells[0].Value)), new Font("Inconsolata Condensed", 10f, (FontStyle)1), Brushes.Black, 0f, 75f, new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString(Conversions.ToString(Operators.ConcatenateObject("DE               : ", DataGridView122323.Rows[((DataGridViewBand)DataGridView122323.CurrentRow).Index].Cells[2].Value)), new Font("Inconsolata Condensed", 10f, (FontStyle)1), Brushes.Black, 0f, 85f, new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString(Conversions.ToString(Operators.ConcatenateObject("A                : ", DataGridView122323.Rows[((DataGridViewBand)DataGridView122323.CurrentRow).Index].Cells[3].Value)), new Font("Inconsolata Condensed", 10f, (FontStyle)1), Brushes.Black, 0f, 95f, new StringFormat((StringFormatFlags)8192));
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
				val = new MySqlDataAdapter("select sum(Total_NET) as n     from TABLE_VENTES_JOURNAL  WHERE   CLOTURE_GLOBALE  = '" + Strings.Trim(Conversions.ToString(DataGridView122323.Rows[((DataGridViewBand)DataGridView122323.CurrentRow).Index].Cells[0].Value)) + "'         and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')     ", Module1.cn_SQL);
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

	private void Print_Recette_caissier_HISTORIQUE_PrintPage(object sender, PrintPageEventArgs e)
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
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected Obj, but got Unknown
		//IL_014b: Expected Obj, but got Unknown
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Expected Obj, but got Unknown
		//IL_01bf: Expected Obj, but got Unknown
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Expected Obj, but got Unknown
		//IL_0233: Expected Obj, but got Unknown
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Expected Obj, but got Unknown
		//IL_026d: Expected Obj, but got Unknown
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Expected Obj, but got Unknown
		//IL_02a7: Expected Obj, but got Unknown
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Expected Obj, but got Unknown
		//IL_02e1: Expected Obj, but got Unknown
		//IL_08a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08aa: Expected Obj, but got Unknown
		//IL_04bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c4: Expected Obj, but got Unknown
		//IL_0552: Unknown result type (might be due to invalid IL or missing references)
		//IL_0559: Expected Obj, but got Unknown
		//IL_05b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ea: Expected Obj, but got Unknown
		//IL_05ea: Expected Obj, but got Unknown
		//IL_061e: Unknown result type (might be due to invalid IL or missing references)
		//IL_064c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0656: Expected Obj, but got Unknown
		//IL_0656: Expected Obj, but got Unknown
		//IL_066d: Unknown result type (might be due to invalid IL or missing references)
		//IL_069b: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a5: Expected Obj, but got Unknown
		//IL_06a5: Expected Obj, but got Unknown
		//IL_0468: Unknown result type (might be due to invalid IL or missing references)
		//IL_0487: Unknown result type (might be due to invalid IL or missing references)
		//IL_0491: Expected Obj, but got Unknown
		//IL_0491: Expected Obj, but got Unknown
		//IL_0386: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03af: Expected Obj, but got Unknown
		//IL_03af: Expected Obj, but got Unknown
		//IL_0716: Unknown result type (might be due to invalid IL or missing references)
		//IL_0744: Unknown result type (might be due to invalid IL or missing references)
		//IL_074e: Expected Obj, but got Unknown
		//IL_074e: Expected Obj, but got Unknown
		//IL_0773: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b0: Expected Obj, but got Unknown
		//IL_07f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0802: Expected Obj, but got Unknown
		//IL_0802: Expected Obj, but got Unknown
		checked
		{
			try
			{
				e.Graphics.FillRectangle((Brush)new SolidBrush(Color.Black), 0, 0, 260, 20);
				string text = "HISTORIQUE CLOTURE CAISSIER";
				e.Graphics.DrawString(text, new Font("Inconsolata Condensed", 13f, (FontStyle)1), Brushes.White, Convert.ToSingle(130f - e.Graphics.MeasureString(text, new Font("Inconsolata Condensed", 13f, (FontStyle)1)).Width / 2f), 0f, new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("CAISSIER         : " + Combo_CLOTURE_CAISSIER.Text, new Font("Inconsolata Condensed", 10f, (FontStyle)1), Brushes.Black, 0f, 65f, new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString(Conversions.ToString(Operators.ConcatenateObject("N CLOTURE        : ", DataGridView1434.Rows[((DataGridViewBand)DataGridView1434.CurrentRow).Index].Cells[0].Value)), new Font("Inconsolata Condensed", 10f, (FontStyle)1), Brushes.Black, 0f, 75f, new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString(Conversions.ToString(Operators.ConcatenateObject("DE               : ", DataGridView1434.Rows[((DataGridViewBand)DataGridView1434.CurrentRow).Index].Cells[2].Value)), new Font("Inconsolata Condensed", 10f, (FontStyle)1), Brushes.Black, 0f, 85f, new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString(Conversions.ToString(Operators.ConcatenateObject("A                : ", DataGridView1434.Rows[((DataGridViewBand)DataGridView1434.CurrentRow).Index].Cells[3].Value)), new Font("Inconsolata Condensed", 10f, (FontStyle)1), Brushes.Black, 0f, 95f, new StringFormat((StringFormatFlags)8192));
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
				val = new MySqlDataAdapter("select sum(Total_NET) as n     from TABLE_VENTES_JOURNAL  WHERE          CLOTURE_CAISSIER  = '" + Strings.Trim(Conversions.ToString(DataGridView1434.Rows[((DataGridViewBand)DataGridView1434.CurrentRow).Index].Cells[0].Value)) + "'        And     Caissier like  '" + Strings.Trim(Combo_CLOTURE_CAISSIER.Text) + "'           and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')      ", Module1.cn_SQL);
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

	private void Button_ConsRapport_Click(object sender, EventArgs e)
	{
		//IL_2073: Unknown result type (might be due to invalid IL or missing references)
		//IL_207a: Expected Obj, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected Obj, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected Obj, but got Unknown
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected Obj, but got Unknown
		//IL_04d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04dd: Expected Obj, but got Unknown
		//IL_04ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f6: Expected Obj, but got Unknown
		//IL_0500: Unknown result type (might be due to invalid IL or missing references)
		//IL_0507: Expected Obj, but got Unknown
		//IL_055c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0563: Expected Obj, but got Unknown
		//IL_0690: Unknown result type (might be due to invalid IL or missing references)
		//IL_0696: Expected Obj, but got Unknown
		//IL_06a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ad: Expected Obj, but got Unknown
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected Obj, but got Unknown
		//IL_07a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a7: Expected Obj, but got Unknown
		//IL_07b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bf: Expected Obj, but got Unknown
		//IL_03be: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c5: Expected Obj, but got Unknown
		//IL_08b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08bd: Expected Obj, but got Unknown
		//IL_08ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d5: Expected Obj, but got Unknown
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Expected Obj, but got Unknown
		//IL_0b2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b31: Expected Obj, but got Unknown
		//IL_0b42: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b48: Expected Obj, but got Unknown
		//IL_0a13: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a1a: Expected Obj, but got Unknown
		//IL_0a24: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a2b: Expected Obj, but got Unknown
		//IL_0cb4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cba: Expected Obj, but got Unknown
		//IL_0e1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e23: Expected Obj, but got Unknown
		//IL_0e34: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e3b: Expected Obj, but got Unknown
		//IL_0fe0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fea: Expected Obj, but got Unknown
		//IL_1126: Unknown result type (might be due to invalid IL or missing references)
		//IL_1130: Expected Obj, but got Unknown
		//IL_126a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1274: Expected Obj, but got Unknown
		//IL_13b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_13ba: Expected Obj, but got Unknown
		//IL_1717: Unknown result type (might be due to invalid IL or missing references)
		//IL_171e: Expected Obj, but got Unknown
		//IL_172f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1736: Expected Obj, but got Unknown
		//IL_14f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_14ff: Expected Obj, but got Unknown
		//IL_1518: Unknown result type (might be due to invalid IL or missing references)
		//IL_151f: Expected Obj, but got Unknown
		//IL_15f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1603: Expected Obj, but got Unknown
		//IL_1a2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a33: Expected Obj, but got Unknown
		//IL_1a44: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a4b: Expected Obj, but got Unknown
		//IL_1bec: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bf3: Expected Obj, but got Unknown
		//IL_1ed0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ed7: Expected Obj, but got Unknown
		//IL_1f0f: Unknown result type (might be due to invalid IL or missing references)
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
				if (Operators.CompareString(ListBox_RAPPORT_GLOBALE.Text, "Sans Détails", TextCompare: false) != 0)
				{
					DataTable dataTable = new DataTable();
					MySqlDataAdapter val = new MySqlDataAdapter();
					dataTable.Clear();
					val = new MySqlDataAdapter("select DISTINCT Famille from TABLE_VENTES_JOURNAL   Where     CLOTURE_GLOBALE IS  NULL            and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')    ", Module1.cn_SQL);
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
							val2 = new MySqlDataAdapter("select Article, sum(Qté) as QTé, sum(TOTAL_NET) as TOTAL_NET    from   TABLE_VENTES_JOURNAL    Where  Famille = '" + Strings.Trim(dataTable.Rows[num2]["Famille"].ToString()) + "'           and             CLOTURE_GLOBALE IS  NULL               and          (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')      group by Article      ", Module1.cn_SQL);
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
							dataTable2.Clear();
							val2 = new MySqlDataAdapter("select  sum(Qté) as Qté, sum(TOTAL_NET) as TOTAL_NET    from   TABLE_VENTES_JOURNAL    Where  Famille = '" + Strings.Trim(dataTable.Rows[num2]["Famille"].ToString()) + "'      and        CLOTURE_GLOBALE IS  NULL               and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')      ", Module1.cn_SQL);
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
							val2 = new MySqlDataAdapter("select  sum(Qté) as QTé, sum(TOTAL_NET) as TOTAL_NET    from   TABLE_VENTES_JOURNAL    Where  Famille = '" + Strings.Trim(dataTable.Rows[num2]["Famille"].ToString()) + "'      and             CLOTURE_GLOBALE IS  NULL               and          (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')   ", Module1.cn_SQL);
							((DbDataAdapter)(object)val2).Fill(dataTable2);
							DataGridView2.Rows.Add(new object[3]
							{
								"",
								dataTable2.Rows[0]["Qté"].ToString(),
								dataTable2.Rows[0]["TOTAL_NET"].ToString()
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
				val3 = new MySqlDataAdapter("select   DISTINCT     MODE_P    from TABLE_VENTES_REGLEMENTS   Where      CLOTURE_GLOBALE IS  NULL     ", Module1.cn_SQL);
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
					val4 = new MySqlDataAdapter("select sum(MONTANT) as n     from    TABLE_VENTES_REGLEMENTS     WHERE          MODE_P  = '" + Strings.Trim(dataTable3.Rows[num9]["MODE_P"].ToString()) + "'          AND    CLOTURE_GLOBALE IS  NULL     ", Module1.cn_SQL);
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
				val5 = new MySqlDataAdapter("SELECT    SUM(MONTANT)      as N          FROM   TABLE_CLIENTS_REGLE     WHERE          CLOTURE_GLOBALE IS  NULL         ", Module1.cn_SQL);
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
				val6 = new MySqlDataAdapter("SELECT    SUM(MONTANT)      as N          FROM   TABLE_FOURNISSEURS_REGLE     WHERE          CLOTURE_GLOBALE IS  NULL         ", Module1.cn_SQL);
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
				val7 = new MySqlDataAdapter(" select sum(Montant) as n                   FROM   TABLE_DEPENSES           WHERE      CLOTURE_GLOBALE IS  NULL      ", Module1.cn_SQL);
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
					val8 = new MySqlDataAdapter("select sum(Total_NET) as n     from TABLE_VENTES_JOURNAL WHERE              CLOTURE_GLOBALE IS  NULL            and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')     ", Module1.cn_SQL);
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
				val9 = new MySqlDataAdapter("select Caissier, sum(TOTAL_NET) as TOTAL_NET    from   TABLE_VENTES_JOURNAL    Where           CLOTURE_GLOBALE IS  NULL               and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')       group by Caissier      ", Module1.cn_SQL);
				dataTable9 = new DataTable();
				dataTable9.Clear();
				((DbDataAdapter)(object)val9).Fill(dataTable9);
				if (dataTable9.Rows.Count > 0)
				{
					DataGridView3.Rows.Add(new object[1] { "---------------CAISSIERS-----------------" });
					int num15 = dataTable9.Rows.Count - 1;
					int num16 = 0;
					while (true)
					{
						int num17 = num16;
						int num4 = num15;
						if (num17 > num4)
						{
							break;
						}
						DataGridView3.Rows.Add(new object[1] { Strings.LSet("- " + dataTable9.Rows[num16]["Caissier"].ToString(), 22) + ":      " + Strings.RSet(Strings.FormatNumber(Conversion.Val(dataTable9.Rows[num16]["TOTAL_NET"].ToString())), 8) + " DH" });
						num16++;
					}
					DataGridView3.Rows.Add(new object[1] { "" });
					DataGridView3.Rows.Add(new object[1] { "" });
				}
				val9 = new MySqlDataAdapter("select VENDEUR, sum(TOTAL_NET) as TOTAL_NET    from   TABLE_VENTES_JOURNAL    Where        VENDEUR <> ''        and      CLOTURE_GLOBALE IS  NULL             and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')            group by VENDEUR      ", Module1.cn_SQL);
				dataTable9 = new DataTable();
				dataTable9.Clear();
				((DbDataAdapter)(object)val9).Fill(dataTable9);
				if (dataTable9.Rows.Count > 0)
				{
					DataGridView3.Rows.Add(new object[1] { "---------------VENDEURS------------------" });
					int num18 = dataTable9.Rows.Count - 1;
					int num19 = 0;
					while (true)
					{
						int num20 = num19;
						int num4 = num18;
						if (num20 > num4)
						{
							break;
						}
						DataGridView3.Rows.Add(new object[1] { Strings.LSet("- " + dataTable9.Rows[num19]["VENDEUR"].ToString(), 22) + ":      " + Strings.RSet(Strings.FormatNumber(Conversion.Val(dataTable9.Rows[num19]["TOTAL_NET"].ToString())), 8) + " DH" });
						num19++;
					}
					DataGridView3.Rows.Add(new object[1] { "" });
					DataGridView3.Rows.Add(new object[1] { "" });
				}
				MySqlDataAdapter val10 = new MySqlDataAdapter();
				DataTable dataTable10 = new DataTable();
				val10 = new MySqlDataAdapter("(select sum(Total_NET) as n from TABLE_VENTES_JOURNAL WHERE                CLOTURE_GLOBALE IS  NULL              and            (OPERATION = 'RETOUR REMBOURSEMENT')     )    UNION ALL  (select sum(Total_NET) as n from TABLE_VENTES_JOURNAL WHERE     CLOTURE_GLOBALE IS  NULL            and            (OPERATION = 'RETOUR AVOIR')    )       UNION ALL  (select sum(Total_NET) as n from TABLE_VENTES_JOURNAL WHERE     CLOTURE_GLOBALE IS  NULL            and            (OPERATION = 'CREDIT')    )          UNION ALL  (select sum(Total_NET) as n from TABLE_VENTES_JOURNAL WHERE     CLOTURE_GLOBALE IS  NULL            and            (OPERATION = 'RETOUR CREDIT')    )   ", Module1.cn_SQL);
				dataTable10 = new DataTable();
				dataTable10.Clear();
				((DbDataAdapter)(object)val10).Fill(dataTable10);
				decimal num21 = new decimal(Conversion.Val(dataTable10.Rows[0]["n"].ToString()));
				decimal num22 = new decimal(Conversion.Val(dataTable10.Rows[1]["n"].ToString()));
				decimal num23 = new decimal(Conversion.Val(dataTable10.Rows[2]["n"].ToString()));
				decimal num24 = new decimal(Conversion.Val(dataTable10.Rows[3]["n"].ToString()));
				if ((decimal.Compare(num21, 0m) != 0) | (decimal.Compare(num22, 0m) != 0) | (decimal.Compare(num23, 0m) != 0) | (decimal.Compare(num24, 0m) != 0))
				{
					DataGridView3.Rows.Add(new object[1] { "---------------ATTENTION-----------------" });
				}
				if (decimal.Compare(num21, 0m) != 0)
				{
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("RETOUR REMBOURSEMENT  : ", 29) + Strings.RSet(Conversions.ToString(num21), 8) + " DH" });
					Module1._DT_TEMP.Clear();
					Module1._DA_TEMP = new MySqlDataAdapter("select Article, sum(Qté) as Qté   from   TABLE_VENTES_JOURNAL    Where               CLOTURE_GLOBALE IS  NULL             and            (OPERATION = 'RETOUR REMBOURSEMENT')               group by Article      ", Module1.cn_SQL);
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
				if (decimal.Compare(num22, 0m) != 0)
				{
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("RETOUR AVOIR          : ", 29) + Strings.RSet(Conversions.ToString(num22), 8) + " DH" });
					Module1._DT_TEMP.Clear();
					Module1._DA_TEMP = new MySqlDataAdapter("select Article, sum(Qté) as Qté   from   TABLE_VENTES_JOURNAL    Where              CLOTURE_GLOBALE IS  NULL              and            (OPERATION = 'RETOUR AVOIR')               group by Article      ", Module1.cn_SQL);
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
				if (decimal.Compare(num23, 0m) != 0)
				{
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("CREDIT                : ", 29) + Strings.RSet(Conversions.ToString(num23), 8) + " DH" });
					Module1._DT_TEMP.Clear();
					Module1._DA_TEMP = new MySqlDataAdapter("select Article, sum(Qté) as Qté   from   TABLE_VENTES_JOURNAL    Where             CLOTURE_GLOBALE IS  NULL               and            (OPERATION = 'CREDIT')               group by Article      ", Module1.cn_SQL);
					((DbDataAdapter)(object)Module1._DA_TEMP).Fill(Module1._DT_TEMP);
					int num31 = Module1._DT_TEMP.Rows.Count - 1;
					int num32 = 0;
					while (true)
					{
						int num33 = num32;
						int num4 = num31;
						if (num33 > num4)
						{
							break;
						}
						DataGridView3.Rows.Add(new object[1] { "  " + Strings.LSet(Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(Module1._DT_TEMP.Rows[num32]["Qté"].ToString()))) + "x", 7) + Module1._DT_TEMP.Rows[num32]["Article"].ToString() });
						num32++;
					}
				}
				if (decimal.Compare(num24, 0m) != 0)
				{
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("RETOUR CREDIT         : ", 29) + Strings.RSet(Conversions.ToString(num24), 8) + " DH" });
					Module1._DT_TEMP.Clear();
					Module1._DA_TEMP = new MySqlDataAdapter("select Article, sum(Qté) as Qté   from   TABLE_VENTES_JOURNAL    Where             CLOTURE_GLOBALE IS  NULL               and            (OPERATION = 'RETOUR CREDIT')               group by Article      ", Module1.cn_SQL);
					((DbDataAdapter)(object)Module1._DA_TEMP).Fill(Module1._DT_TEMP);
					int num34 = Module1._DT_TEMP.Rows.Count - 1;
					int num35 = 0;
					while (true)
					{
						int num36 = num35;
						int num4 = num34;
						if (num36 > num4)
						{
							break;
						}
						DataGridView3.Rows.Add(new object[1] { "  " + Strings.LSet(Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(Module1._DT_TEMP.Rows[num35]["Qté"].ToString()))) + "x", 7) + Module1._DT_TEMP.Rows[num35]["Article"].ToString() });
						num35++;
					}
				}
				DataGridView3.Rows.Add(new object[1] { "" });
				DataGridView3.Rows.Add(new object[1] { "" });
				if (Operators.CompareString(MyProject.Forms.Form_0_TEMPLATE.Label_GESTION_TABLE.Text, "TABLE", TextCompare: false) == 0)
				{
					MySqlDataAdapter val11 = new MySqlDataAdapter();
					DataTable dataTable11 = new DataTable();
					decimal num37 = 0m;
					val11 = new MySqlDataAdapter("Select sum(TOTAL_NET) as n      from TABLE_POUBELLE    Where          CLOTURE_GLOBALE IS  NULL   ", Module1.cn_SQL);
					dataTable11 = new DataTable();
					dataTable11.Clear();
					((DbDataAdapter)(object)val11).Fill(dataTable11);
					num37 = new decimal(Conversion.Val(dataTable11.Rows[0]["n"].ToString()));
					if (decimal.Compare(num37, 0m) != 0)
					{
						DataGridView3.Rows.Add(new object[1] { "---------------ATTENTION-----------------" });
						DataGridView3.Rows.Add(new object[1] { Strings.LSet("IL YA DES ANNULATIONS : ", 29) + Strings.RSet(Conversions.ToString(num37), 8) + " DH" });
						Module1._DT_TEMP.Clear();
						Module1._DA_TEMP = new MySqlDataAdapter("select Article, sum(Qté) as Qté   from   TABLE_POUBELLE    Where             CLOTURE_GLOBALE IS  NULL                    group by Article      ", Module1.cn_SQL);
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
					DataGridView3.Rows.Add(new object[1] { "" });
					DataGridView3.Rows.Add(new object[1] { "" });
				}
				MySqlDataAdapter val12 = new MySqlDataAdapter();
				DataTable dataTable12 = new DataTable();
				val12 = new MySqlDataAdapter("(select sum(TOTAL_NET) as n     from    TABLE_VENTES_JOURNAL     WHERE     (Notes LIKE 'TABLE%' OR Notes LIKE 'SUR PLACE%')          AND    CLOTURE_GLOBALE IS  NULL            and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')       )      UNION ALL   (select sum(TOTAL_NET) as n     from    TABLE_VENTES_JOURNAL     WHERE      Notes  like 'EMPORTER%'          AND    CLOTURE_GLOBALE IS  NULL           and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')      )      UNION ALL   (select sum(TOTAL_NET) as n     from    TABLE_VENTES_JOURNAL     WHERE        Notes  like 'LIVRAISON%'         AND    CLOTURE_GLOBALE IS  NULL            and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')      )       UNION ALL   (select sum(TOTAL_NET) as n     from    TABLE_VENTES_JOURNAL     WHERE     Notes  like 'DIRECTE%'          AND    CLOTURE_GLOBALE IS  NULL          and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')       )         ", Module1.cn_SQL);
				dataTable12 = new DataTable();
				dataTable12.Clear();
				((DbDataAdapter)(object)val12).Fill(dataTable12);
				double num41 = Conversion.Val(dataTable12.Rows[0]["n"].ToString());
				double num42 = Conversion.Val(dataTable12.Rows[1]["n"].ToString());
				double num43 = Conversion.Val(dataTable12.Rows[2]["n"].ToString());
				double num44 = Conversion.Val(dataTable12.Rows[3]["n"].ToString());
				if ((num41 != 0.0) | (num42 != 0.0) | (num43 != 0.0) | (num44 != 0.0))
				{
					DataGridView3.Rows.Add(new object[1] { "-----------------NOTES-------------------" });
				}
				if (num41 != 0.0)
				{
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("- SUR PLACE           : ", 29) + Strings.RSet(Strings.FormatNumber(num41), 8) + " DH" });
				}
				if (num42 != 0.0)
				{
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("- EMPORTER            : ", 29) + Strings.RSet(Strings.FormatNumber(num42), 8) + " DH" });
				}
				if (num43 != 0.0)
				{
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("- LIVRAISON           : ", 29) + Strings.RSet(Strings.FormatNumber(num43), 8) + " DH" });
				}
				if (num44 != 0.0)
				{
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("- DIRECTE             : ", 29) + Strings.RSet(Strings.FormatNumber(num44), 8) + " DH" });
				}
				DataGridView3.Rows.Add(new object[1] { "" });
				DataGridView3.Rows.Add(new object[1] { "" });
				MySqlDataAdapter val13 = new MySqlDataAdapter();
				DataTable dataTable13 = new DataTable();
				val13 = new MySqlDataAdapter("(select sum(TOTAL_NET) as n     from    TABLE_VENTES_JOURNAL     WHERE    CLOTURE_GLOBALE IS  NULL                 and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')          And      (NOTES_TYPE_PRIX = 'PRIX_1')    )      UNION ALL   (select sum(TOTAL_NET) as n     from    TABLE_VENTES_JOURNAL     WHERE    CLOTURE_GLOBALE IS  NULL                and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')         And     (NOTES_TYPE_PRIX = 'PRIX_2')  )         ", Module1.cn_SQL);
				dataTable13 = new DataTable();
				dataTable13.Clear();
				((DbDataAdapter)(object)val13).Fill(dataTable13);
				double num45 = Conversion.Val(dataTable13.Rows[0]["n"].ToString());
				double num46 = Conversion.Val(dataTable13.Rows[1]["n"].ToString());
				if ((num45 != 0.0) & (num46 != 0.0))
				{
					DataGridView3.Rows.Add(new object[1] { "-----------------NOTES-------------------" });
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("- PRIX_1              : ", 29) + Strings.RSet(Strings.FormatNumber(num45), 8) + " DH" });
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("- PRIX_2              : ", 29) + Strings.RSet(Strings.FormatNumber(num46), 8) + " DH" });
				}
				DataGridView3.Rows.Add(new object[1] { "" });
				DataGridView3.Rows.Add(new object[1] { "" });
				val10 = new MySqlDataAdapter("( select sum((PRIX_V*Qté)-TOTAL_NET) as n                    from TABLE_VENTES_JOURNAL WHERE     CLOTURE_GLOBALE IS  NULL              AND     REMISE <  100 )      UNION ALL        ( select sum((PRIX_V*Qté)-TOTAL_NET) as n                   from TABLE_VENTES_JOURNAL WHERE     CLOTURE_GLOBALE IS  NULL                     AND       REMISE = 100 ) UNION ALL (select sum(TOTAL_NET) as n       from TABLE_VENTES_JOURNAL WHERE     CLOTURE_GLOBALE IS  NULL                      And       Famille = 'FAM_DIVERS' )  ", Module1.cn_SQL);
				dataTable10 = new DataTable();
				dataTable10.Clear();
				((DbDataAdapter)(object)val10).Fill(dataTable10);
				decimal num47 = new decimal(Conversion.Val(dataTable10.Rows[0]["n"].ToString()));
				decimal num48 = new decimal(Conversion.Val(dataTable10.Rows[1]["n"].ToString()));
				decimal num49 = new decimal(Conversion.Val(dataTable10.Rows[2]["n"].ToString()));
				if ((decimal.Compare(num47, 0m) != 0) | (decimal.Compare(num48, 0m) != 0) | (decimal.Compare(num49, 0m) != 0))
				{
					DataGridView3.Rows.Add(new object[1] { "---------------ATTENTION-----------------" });
				}
				if (decimal.Compare(num47, 0m) != 0)
				{
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("IL YA DES REMISE      : ", 29) + Strings.RSet(Conversions.ToString(num47), 8) + " DH" });
				}
				if (decimal.Compare(num48, 0m) != 0)
				{
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("IL YA DES OFFERT      : ", 29) + Strings.RSet(Conversions.ToString(num48), 8) + " DH" });
				}
				if (decimal.Compare(num49, 0m) != 0)
				{
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("IL YA DES DIVERS      : ", 29) + Strings.RSet(Conversions.ToString(num49), 8) + " DH" });
				}
				DataGridView3.Rows.Add(new object[1] { "" });
				DataGridView3.Rows.Add(new object[1] { "" });
				if (Operators.CompareString(Text_PRINTER_RAPPORT.Text, "0", TextCompare: false) != 0 && Operators.CompareString(Text_PRINTER_RAPPORT.Text, "", TextCompare: false) != 0)
				{
					Print_Recette_Globale.PrinterSettings.PrinterName = Text_PRINTER_RAPPORT.Text;
				}
				if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null), "Button_ConsRapport", TextCompare: false))
				{
					PrintPreviewDialog val14 = new PrintPreviewDialog();
					val14.Document = Print_Recette_Globale;
					val14.PrintPreviewControl.Zoom = 2.0;
					((Form)val14).WindowState = (FormWindowState)2;
					val14.TopMost = true;
					((Form)val14).ShowDialog();
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

	private void Button_ConsCaissier_Click(object sender, EventArgs e)
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected Obj, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected Obj, but got Unknown
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected Obj, but got Unknown
		//IL_203f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2046: Expected Obj, but got Unknown
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Expected Obj, but got Unknown
		//IL_0426: Unknown result type (might be due to invalid IL or missing references)
		//IL_042d: Expected Obj, but got Unknown
		//IL_0459: Unknown result type (might be due to invalid IL or missing references)
		//IL_0460: Expected Obj, but got Unknown
		//IL_046a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0471: Expected Obj, but got Unknown
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Expected Obj, but got Unknown
		//IL_04fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0505: Expected Obj, but got Unknown
		//IL_0632: Unknown result type (might be due to invalid IL or missing references)
		//IL_0638: Expected Obj, but got Unknown
		//IL_0663: Unknown result type (might be due to invalid IL or missing references)
		//IL_0669: Expected Obj, but got Unknown
		//IL_075c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0763: Expected Obj, but got Unknown
		//IL_078e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0795: Expected Obj, but got Unknown
		//IL_088c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0892: Expected Obj, but got Unknown
		//IL_08bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c3: Expected Obj, but got Unknown
		//IL_0b32: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b39: Expected Obj, but got Unknown
		//IL_0bdb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be2: Expected Obj, but got Unknown
		//IL_0a00: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a07: Expected Obj, but got Unknown
		//IL_0a2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a32: Expected Obj, but got Unknown
		//IL_0da1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dab: Expected Obj, but got Unknown
		//IL_0f01: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f0b: Expected Obj, but got Unknown
		//IL_105f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1069: Expected Obj, but got Unknown
		//IL_11bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_11c9: Expected Obj, but got Unknown
		//IL_17a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_17a7: Expected Obj, but got Unknown
		//IL_1849: Unknown result type (might be due to invalid IL or missing references)
		//IL_1850: Expected Obj, but got Unknown
		//IL_1307: Unknown result type (might be due to invalid IL or missing references)
		//IL_130e: Expected Obj, but got Unknown
		//IL_136d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1374: Expected Obj, but got Unknown
		//IL_13e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_13eb: Expected Obj, but got Unknown
		//IL_143f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1446: Expected Obj, but got Unknown
		//IL_1587: Unknown result type (might be due to invalid IL or missing references)
		//IL_158e: Expected Obj, but got Unknown
		//IL_1682: Unknown result type (might be due to invalid IL or missing references)
		//IL_168c: Expected Obj, but got Unknown
		//IL_1bc1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bc8: Expected Obj, but got Unknown
		//IL_1ea5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1eac: Expected Obj, but got Unknown
		//IL_1edb: Unknown result type (might be due to invalid IL or missing references)
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
				DataTable dataTable = new DataTable();
				MySqlDataAdapter val = new MySqlDataAdapter();
				dataTable.Clear();
				val = new MySqlDataAdapter("select DISTINCT Famille from TABLE_VENTES_JOURNAL   Where  CLOTURE_CAISSIER IS  NULL          And     Caissier like  '" + Strings.Trim(ListBox_CAISSIERS.Text) + "'          and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')    ", Module1.cn_SQL);
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
					val2 = new MySqlDataAdapter("select Article, sum(Qté) as QTé, sum(TOTAL_NET) as TOTAL_NET    from   TABLE_VENTES_JOURNAL    Where  Famille = '" + Strings.Trim(dataTable.Rows[num2]["Famille"].ToString()) + "'         And     Caissier like  '" + Strings.Trim(ListBox_CAISSIERS.Text) + "'    and         CLOTURE_CAISSIER IS  NULL                and           (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')      group by Article      ", Module1.cn_SQL);
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
					dataTable2.Clear();
					val2 = new MySqlDataAdapter("select  sum(Qté) as Qté, sum(TOTAL_NET) as TOTAL_NET    from   TABLE_VENTES_JOURNAL    Where  Famille = '" + Strings.Trim(dataTable.Rows[num2]["Famille"].ToString()) + "'      and         Caissier like  '" + Strings.Trim(ListBox_CAISSIERS.Text) + "'    and         CLOTURE_CAISSIER IS  NULL                  and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')      ", Module1.cn_SQL);
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
				val3 = new MySqlDataAdapter("select   DISTINCT     MODE_P    from TABLE_VENTES_REGLEMENTS   Where     Caissier like  '" + Strings.Trim(ListBox_CAISSIERS.Text) + "'      and            CLOTURE_CAISSIER IS  NULL                      ", Module1.cn_SQL);
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
					val4 = new MySqlDataAdapter("select sum(MONTANT) as n     from    TABLE_VENTES_REGLEMENTS     WHERE        MODE_P  = '" + Strings.Trim(dataTable3.Rows[num9]["MODE_P"].ToString()) + "'           And     Caissier like  '" + Strings.Trim(ListBox_CAISSIERS.Text) + "'          and            CLOTURE_CAISSIER IS  NULL               ", Module1.cn_SQL);
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
				val5 = new MySqlDataAdapter("SELECT    SUM(MONTANT)      as N          FROM   TABLE_CLIENTS_REGLE     WHERE           Utilisateur like  '" + Strings.Trim(ListBox_CAISSIERS.Text) + "'       and            CLOTURE_CAISSIER IS  NULL                      ", Module1.cn_SQL);
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
				val6 = new MySqlDataAdapter("SELECT    SUM(MONTANT)      as N          FROM   TABLE_FOURNISSEURS_REGLE     WHERE             Utilisateur like  '" + Strings.Trim(ListBox_CAISSIERS.Text) + "'       and            CLOTURE_CAISSIER IS  NULL              ", Module1.cn_SQL);
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
				val7 = new MySqlDataAdapter(" select sum(Montant) as n                   FROM   TABLE_DEPENSES           WHERE       Utilisateur like  '" + Strings.Trim(ListBox_CAISSIERS.Text) + "'        and            CLOTURE_CAISSIER IS  NULL                  ", Module1.cn_SQL);
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
					val8 = new MySqlDataAdapter("select sum(Total_NET) as n     from TABLE_VENTES_JOURNAL WHERE        Caissier like  '" + Strings.Trim(ListBox_CAISSIERS.Text) + "'               and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')         and            CLOTURE_CAISSIER IS  NULL              ", Module1.cn_SQL);
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
				val9 = new MySqlDataAdapter("(select sum(Total_NET) as n from TABLE_VENTES_JOURNAL WHERE             CLOTURE_CAISSIER IS  NULL               And     Caissier like  '" + Strings.Trim(ListBox_CAISSIERS.Text) + "'      and            (OPERATION = 'RETOUR REMBOURSEMENT')     )    UNION ALL  (select sum(Total_NET) as n from TABLE_VENTES_JOURNAL WHERE            CLOTURE_CAISSIER IS  NULL            And     Caissier like  '" + Strings.Trim(ListBox_CAISSIERS.Text) + "'         and            (OPERATION = 'RETOUR AVOIR')    )       UNION ALL  (select sum(Total_NET) as n from TABLE_VENTES_JOURNAL WHERE            CLOTURE_CAISSIER IS  NULL            And     Caissier like  '" + Strings.Trim(ListBox_CAISSIERS.Text) + "'         and            (OPERATION = 'CREDIT')    )          UNION ALL  (select sum(Total_NET) as n from TABLE_VENTES_JOURNAL WHERE            CLOTURE_CAISSIER IS  NULL            And     Caissier like  '" + Strings.Trim(ListBox_CAISSIERS.Text) + "'         and            (OPERATION = 'RETOUR CREDIT')    )   ", Module1.cn_SQL);
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
					Module1._DA_TEMP = new MySqlDataAdapter("select Article, sum(Qté) as Qté   from   TABLE_VENTES_JOURNAL    Where               CLOTURE_CAISSIER IS  NULL             And     Caissier like  '" + Strings.Trim(ListBox_CAISSIERS.Text) + "'      and            (OPERATION = 'RETOUR REMBOURSEMENT')               group by Article      ", Module1.cn_SQL);
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
					Module1._DA_TEMP = new MySqlDataAdapter("select Article, sum(Qté) as Qté   from   TABLE_VENTES_JOURNAL    Where              CLOTURE_CAISSIER IS  NULL               And     Caissier like  '" + Strings.Trim(ListBox_CAISSIERS.Text) + "'     and            (OPERATION = 'RETOUR AVOIR')               group by Article      ", Module1.cn_SQL);
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
					Module1._DA_TEMP = new MySqlDataAdapter("select Article, sum(Qté) as Qté   from   TABLE_VENTES_JOURNAL    Where             CLOTURE_CAISSIER IS  NULL                And     Caissier like  '" + Strings.Trim(ListBox_CAISSIERS.Text) + "'     and            (OPERATION = 'CREDIT')               group by Article      ", Module1.cn_SQL);
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
					Module1._DA_TEMP = new MySqlDataAdapter("select Article, sum(Qté) as Qté   from   TABLE_VENTES_JOURNAL    Where             CLOTURE_CAISSIER IS  NULL                And     Caissier like  '" + Strings.Trim(ListBox_CAISSIERS.Text) + "'     and            (OPERATION = 'RETOUR CREDIT')               group by Article      ", Module1.cn_SQL);
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
					val10 = new MySqlDataAdapter("Select sum(TOTAL_NET) as n      from TABLE_POUBELLE     Where    CLOTURE_CAISSIER IS  NULL        And     Caissier like  '" + Strings.Trim(ListBox_CAISSIERS.Text) + "'   ", Module1.cn_SQL);
					dataTable10 = new DataTable();
					dataTable10.Clear();
					((DbDataAdapter)(object)val10).Fill(dataTable10);
					num35 = new decimal(Conversion.Val(dataTable10.Rows[0]["n"].ToString()));
					if (decimal.Compare(num35, 0m) != 0)
					{
						DataGridView3.Rows.Add(new object[1] { "---------------ATTENTION-----------------" });
						DataGridView3.Rows.Add(new object[1] { Strings.LSet("IL YA DES ANNULATIONS : ", 29) + Strings.RSet(Conversions.ToString(num35), 8) + " DH" });
						Module1._DT_TEMP.Clear();
						Module1._DA_TEMP = new MySqlDataAdapter("select Article, sum(Qté) as Qté   from   TABLE_POUBELLE    Where             CLOTURE_CAISSIER IS  NULL        And     Caissier like  '" + Strings.Trim(ListBox_CAISSIERS.Text) + "'                   group by Article      ", Module1.cn_SQL);
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
				val11 = new MySqlDataAdapter("(select sum(TOTAL_NET) as n     from    TABLE_VENTES_JOURNAL     WHERE     (Notes LIKE 'TABLE%' OR Notes LIKE 'SUR PLACE%')            And     Caissier like  '" + Strings.Trim(ListBox_CAISSIERS.Text) + "'        and            CLOTURE_CAISSIER IS  NULL              and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')          )      UNION ALL   (select sum(TOTAL_NET) as n     from    TABLE_VENTES_JOURNAL     WHERE        Notes  like 'EMPORTER%'            And     Caissier like  '" + Strings.Trim(ListBox_CAISSIERS.Text) + "'     and            CLOTURE_CAISSIER IS  NULL              and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')          )      UNION ALL   (select sum(TOTAL_NET) as n     from    TABLE_VENTES_JOURNAL     WHERE        Notes  like 'LIVRAISON%'           And     Caissier like  '" + Strings.Trim(ListBox_CAISSIERS.Text) + "'        and            CLOTURE_CAISSIER IS  NULL              and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')        )       UNION ALL   (select sum(TOTAL_NET) as n     from    TABLE_VENTES_JOURNAL     WHERE        Notes  like 'DIRECTE%'            And     Caissier like  '" + Strings.Trim(ListBox_CAISSIERS.Text) + "'       and            CLOTURE_CAISSIER IS  NULL              and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')        )         ", Module1.cn_SQL);
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
				val9 = new MySqlDataAdapter("( select sum((PRIX_V*Qté)-TOTAL_NET) as n                    from TABLE_VENTES_JOURNAL WHERE     CLOTURE_CAISSIER IS  NULL       And     Caissier like  '" + Strings.Trim(ListBox_CAISSIERS.Text) + "'                AND     REMISE <  100 )      UNION ALL        ( select sum((PRIX_V*Qté)-TOTAL_NET) as n                   from TABLE_VENTES_JOURNAL WHERE     CLOTURE_CAISSIER IS  NULL         And     Caissier like  '" + Strings.Trim(ListBox_CAISSIERS.Text) + "'            AND       REMISE = 100 ) UNION ALL (select sum(TOTAL_NET) as n       from TABLE_VENTES_JOURNAL WHERE     CLOTURE_CAISSIER IS  NULL          And     Caissier like  '" + Strings.Trim(ListBox_CAISSIERS.Text) + "'                And       Famille = 'FAM_DIVERS' )  ", Module1.cn_SQL);
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
				if (Operators.CompareString(Text_PRINTER_RAPPORT.Text, "0", TextCompare: false) != 0 && Operators.CompareString(Text_PRINTER_RAPPORT.Text, "", TextCompare: false) != 0)
				{
					Print_Recette_caissier.PrinterSettings.PrinterName = Text_PRINTER_RAPPORT.Text;
				}
				if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null), "Button_ConsCaissier", TextCompare: false))
				{
					PrintPreviewDialog val12 = new PrintPreviewDialog();
					val12.Document = Print_Recette_caissier;
					val12.PrintPreviewControl.Zoom = 2.0;
					((Form)val12).WindowState = (FormWindowState)2;
					((Form)val12).ShowDialog();
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
				NewLateBinding.LateSet(sender, null, "enabled", new object[1] { true }, null, null);
				Interaction.MsgBox(ex2.Message + "\r\nLigne : " + Conversions.ToString(fileLineNumber) + "\r\n");
				try
				{
					string text = Strings.Format(DateTime.Now, "yyMMddHHmmssfff");
					Bitmap val13 = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, (PixelFormat)2498570);
					Graphics val14 = Graphics.FromImage((Image)(object)val13);
					val14.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, (CopyPixelOperation)13369376);
					((Image)val13).Save(Application.StartupPath + "\\tchak\\" + text + ".snidb", ImageFormat.Jpeg);
					val13 = null;
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
		//IL_1d48: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d4f: Expected Obj, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected Obj, but got Unknown
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected Obj, but got Unknown
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Expected Obj, but got Unknown
		//IL_038b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0392: Expected Obj, but got Unknown
		//IL_03e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ef: Expected Obj, but got Unknown
		//IL_03f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0400: Expected Obj, but got Unknown
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Expected Obj, but got Unknown
		//IL_04b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04be: Expected Obj, but got Unknown
		//IL_05eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f1: Expected Obj, but got Unknown
		//IL_0646: Unknown result type (might be due to invalid IL or missing references)
		//IL_064c: Expected Obj, but got Unknown
		//IL_073f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0746: Expected Obj, but got Unknown
		//IL_079b: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a2: Expected Obj, but got Unknown
		//IL_0899: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a0: Expected Obj, but got Unknown
		//IL_08f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fc: Expected Obj, but got Unknown
		//IL_0b96: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9c: Expected Obj, but got Unknown
		//IL_0bf1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf7: Expected Obj, but got Unknown
		//IL_0a3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a41: Expected Obj, but got Unknown
		//IL_0a8f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a96: Expected Obj, but got Unknown
		//IL_0da7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dad: Expected Obj, but got Unknown
		//IL_0f0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f16: Expected Obj, but got Unknown
		//IL_1060: Unknown result type (might be due to invalid IL or missing references)
		//IL_1067: Expected Obj, but got Unknown
		//IL_1250: Unknown result type (might be due to invalid IL or missing references)
		//IL_125a: Expected Obj, but got Unknown
		//IL_13da: Unknown result type (might be due to invalid IL or missing references)
		//IL_13e4: Expected Obj, but got Unknown
		//IL_1562: Unknown result type (might be due to invalid IL or missing references)
		//IL_156c: Expected Obj, but got Unknown
		//IL_1902: Unknown result type (might be due to invalid IL or missing references)
		//IL_1909: Expected Obj, but got Unknown
		//IL_16ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_16f6: Expected Obj, but got Unknown
		//IL_1be6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bed: Expected Obj, but got Unknown
		//IL_1c25: Unknown result type (might be due to invalid IL or missing references)
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
				if (DataGridView122323.Rows.Count == 0)
				{
					NewLateBinding.LateSet(sender, null, "Enabled", new object[1] { true }, null, null);
					return;
				}
				NewLateBinding.LateSet(sender, null, "enabled", new object[1] { false }, null, null);
				DataTable dataTable = new DataTable();
				MySqlDataAdapter val = new MySqlDataAdapter();
				dataTable.Clear();
				val = new MySqlDataAdapter("select DISTINCT Famille from TABLE_VENTES_JOURNAL   Where     CLOTURE_GLOBALE = '" + Strings.Trim(Conversions.ToString(DataGridView122323.Rows[((DataGridViewBand)DataGridView122323.CurrentRow).Index].Cells[0].Value)) + "'             and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')    ", Module1.cn_SQL);
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
					DataGridView2.Rows.Add(new object[2]
					{
						dataTable.Rows[num2]["Famille"].ToString(),
						"."
					});
					if (Operators.CompareString(ListBox_RAPPORT_GLOBALE.Text, "Par Article", TextCompare: false) == 0)
					{
						dataTable2.Clear();
						val2 = new MySqlDataAdapter("select Article, sum(Qté) as QTé, sum(TOTAL_NET) as TOTAL_NET    from   TABLE_VENTES_JOURNAL    Where  Famille = '" + Strings.Trim(dataTable.Rows[num2]["Famille"].ToString()) + "'           and            CLOTURE_GLOBALE = '" + Strings.Trim(Conversions.ToString(DataGridView122323.Rows[((DataGridViewBand)DataGridView122323.CurrentRow).Index].Cells[0].Value)) + "'                and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')        group by Article      ", Module1.cn_SQL);
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
					}
					DataGridView2.Rows.Add(new object[1] { "" });
					num2++;
				}
				DataGridView3.Rows.Clear();
				DataGridView3.Rows.Add(new object[1] { "                    FINANCE--------------" });
				DataTable dataTable3 = new DataTable();
				MySqlDataAdapter val3 = new MySqlDataAdapter();
				dataTable3.Clear();
				val3 = new MySqlDataAdapter("select   DISTINCT     MODE_P    from TABLE_VENTES_REGLEMENTS   Where      CLOTURE_GLOBALE = '" + Strings.Trim(Conversions.ToString(DataGridView122323.Rows[((DataGridViewBand)DataGridView122323.CurrentRow).Index].Cells[0].Value)) + "'     ", Module1.cn_SQL);
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
					val4 = new MySqlDataAdapter("select sum(MONTANT) as n     from    TABLE_VENTES_REGLEMENTS     WHERE          MODE_P  = '" + Strings.Trim(dataTable3.Rows[num9]["MODE_P"].ToString()) + "'          AND    CLOTURE_GLOBALE = '" + Strings.Trim(Conversions.ToString(DataGridView122323.Rows[((DataGridViewBand)DataGridView122323.CurrentRow).Index].Cells[0].Value)) + "'      ", Module1.cn_SQL);
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
				val5 = new MySqlDataAdapter("SELECT    SUM(MONTANT)      as N          FROM   TABLE_CLIENTS_REGLE     WHERE          CLOTURE_GLOBALE = '" + Strings.Trim(Conversions.ToString(DataGridView122323.Rows[((DataGridViewBand)DataGridView122323.CurrentRow).Index].Cells[0].Value)) + "'         ", Module1.cn_SQL);
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
				val6 = new MySqlDataAdapter("SELECT    SUM(MONTANT)      as N          FROM   TABLE_FOURNISSEURS_REGLE     WHERE             CLOTURE_GLOBALE = '" + Strings.Trim(Conversions.ToString(DataGridView122323.Rows[((DataGridViewBand)DataGridView122323.CurrentRow).Index].Cells[0].Value)) + "'        ", Module1.cn_SQL);
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
				val7 = new MySqlDataAdapter(" select sum(Montant) as n                   FROM   TABLE_DEPENSES           WHERE      CLOTURE_GLOBALE = '" + Strings.Trim(Conversions.ToString(DataGridView122323.Rows[((DataGridViewBand)DataGridView122323.CurrentRow).Index].Cells[0].Value)) + "'       ", Module1.cn_SQL);
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
					val8 = new MySqlDataAdapter("select sum(Total_NET) as n     from TABLE_VENTES_JOURNAL WHERE              CLOTURE_GLOBALE = '" + Strings.Trim(Conversions.ToString(DataGridView122323.Rows[((DataGridViewBand)DataGridView122323.CurrentRow).Index].Cells[0].Value)) + "'            and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')     ", Module1.cn_SQL);
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
				val9 = new MySqlDataAdapter("select Caissier, sum(TOTAL_NET) as TOTAL_NET    from   TABLE_VENTES_JOURNAL    Where           CLOTURE_GLOBALE = '" + Strings.Trim(Conversions.ToString(DataGridView122323.Rows[((DataGridViewBand)DataGridView122323.CurrentRow).Index].Cells[0].Value)) + "'                and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')       group by Caissier      ", Module1.cn_SQL);
				dataTable9 = new DataTable();
				dataTable9.Clear();
				((DbDataAdapter)(object)val9).Fill(dataTable9);
				if (dataTable9.Rows.Count > 0)
				{
					DataGridView3.Rows.Add(new object[1] { "---------------CAISSIERS-----------------" });
					int num15 = dataTable9.Rows.Count - 1;
					int num16 = 0;
					while (true)
					{
						int num17 = num16;
						int num4 = num15;
						if (num17 > num4)
						{
							break;
						}
						DataGridView3.Rows.Add(new object[1] { Strings.LSet("- " + dataTable9.Rows[num16]["Caissier"].ToString(), 22) + ":      " + Strings.RSet(Strings.FormatNumber(Conversion.Val(dataTable9.Rows[num16]["TOTAL_NET"].ToString())), 8) + " DH" });
						num16++;
					}
					DataGridView3.Rows.Add(new object[1] { "" });
					DataGridView3.Rows.Add(new object[1] { "" });
				}
				val9 = new MySqlDataAdapter("select VENDEUR, sum(TOTAL_NET) as TOTAL_NET    from   TABLE_VENTES_JOURNAL    Where        VENDEUR <> ''        and      CLOTURE_GLOBALE = '" + Strings.Trim(Conversions.ToString(DataGridView122323.Rows[((DataGridViewBand)DataGridView122323.CurrentRow).Index].Cells[0].Value)) + "'             and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')            group by VENDEUR      ", Module1.cn_SQL);
				dataTable9 = new DataTable();
				dataTable9.Clear();
				((DbDataAdapter)(object)val9).Fill(dataTable9);
				if (dataTable9.Rows.Count > 0)
				{
					DataGridView3.Rows.Add(new object[1] { "---------------VENDEURS------------------" });
					int num18 = dataTable9.Rows.Count - 1;
					int num19 = 0;
					while (true)
					{
						int num20 = num19;
						int num4 = num18;
						if (num20 > num4)
						{
							break;
						}
						DataGridView3.Rows.Add(new object[1] { Strings.LSet("- " + dataTable9.Rows[num19]["VENDEUR"].ToString(), 22) + ":      " + Strings.RSet(Strings.FormatNumber(Conversion.Val(dataTable9.Rows[num19]["TOTAL_NET"].ToString())), 8) + " DH" });
						num19++;
					}
					DataGridView3.Rows.Add(new object[1] { "" });
					DataGridView3.Rows.Add(new object[1] { "" });
				}
				MySqlDataAdapter val10 = new MySqlDataAdapter();
				DataTable dataTable10 = new DataTable();
				val10 = new MySqlDataAdapter("(select sum(Total_NET) as n from TABLE_VENTES_JOURNAL WHERE                CLOTURE_GLOBALE = '" + Strings.Trim(Conversions.ToString(DataGridView122323.Rows[((DataGridViewBand)DataGridView122323.CurrentRow).Index].Cells[0].Value)) + "'             and            (OPERATION = 'RETOUR REMBOURSEMENT')     )    UNION ALL  (select sum(Total_NET) as n from TABLE_VENTES_JOURNAL WHERE     CLOTURE_GLOBALE  = '" + Strings.Trim(Conversions.ToString(DataGridView122323.Rows[((DataGridViewBand)DataGridView122323.CurrentRow).Index].Cells[0].Value)) + "'            and            (OPERATION = 'RETOUR AVOIR')    )       UNION ALL  (select sum(Total_NET) as n from TABLE_VENTES_JOURNAL WHERE     CLOTURE_GLOBALE  = '" + Strings.Trim(Conversions.ToString(DataGridView122323.Rows[((DataGridViewBand)DataGridView122323.CurrentRow).Index].Cells[0].Value)) + "'            and            (OPERATION = 'CREDIT')    )         UNION ALL  (select sum(Total_NET) as n from TABLE_VENTES_JOURNAL WHERE     CLOTURE_GLOBALE  = '" + Strings.Trim(Conversions.ToString(DataGridView122323.Rows[((DataGridViewBand)DataGridView122323.CurrentRow).Index].Cells[0].Value)) + "'            and            (OPERATION = 'RETOUR CREDIT')    )   ", Module1.cn_SQL);
				dataTable10 = new DataTable();
				dataTable10.Clear();
				((DbDataAdapter)(object)val10).Fill(dataTable10);
				decimal num21 = new decimal(Conversion.Val(dataTable10.Rows[0]["n"].ToString()));
				decimal num22 = new decimal(Conversion.Val(dataTable10.Rows[1]["n"].ToString()));
				decimal num23 = new decimal(Conversion.Val(dataTable10.Rows[2]["n"].ToString()));
				decimal num24 = new decimal(Conversion.Val(dataTable10.Rows[3]["n"].ToString()));
				if ((decimal.Compare(num21, 0m) != 0) | (decimal.Compare(num22, 0m) != 0) | (decimal.Compare(num23, 0m) != 0) | (decimal.Compare(num24, 0m) != 0))
				{
					DataGridView3.Rows.Add(new object[1] { "---------------ATTENTION-----------------" });
				}
				if (decimal.Compare(num21, 0m) != 0)
				{
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("RETOUR REMBOURSEMENT  : ", 29) + Strings.RSet(Conversions.ToString(num21), 8) + " DH" });
					Module1._DT_TEMP.Clear();
					Module1._DA_TEMP = new MySqlDataAdapter("select Article, sum(Qté) as Qté   from   TABLE_VENTES_JOURNAL    Where              CLOTURE_GLOBALE = '" + Strings.Trim(Conversions.ToString(DataGridView122323.Rows[((DataGridViewBand)DataGridView122323.CurrentRow).Index].Cells[0].Value)) + "'      and            (OPERATION = 'RETOUR REMBOURSEMENT')               group by Article      ", Module1.cn_SQL);
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
				if (decimal.Compare(num22, 0m) != 0)
				{
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("RETOUR AVOIR          : ", 29) + Strings.RSet(Conversions.ToString(num22), 8) + " DH" });
					Module1._DT_TEMP.Clear();
					Module1._DA_TEMP = new MySqlDataAdapter("select Article, sum(Qté) as Qté   from   TABLE_VENTES_JOURNAL    Where              CLOTURE_GLOBALE = '" + Strings.Trim(Conversions.ToString(DataGridView122323.Rows[((DataGridViewBand)DataGridView122323.CurrentRow).Index].Cells[0].Value)) + "'     and            (OPERATION = 'RETOUR AVOIR')               group by Article      ", Module1.cn_SQL);
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
				if (decimal.Compare(num23, 0m) != 0)
				{
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("CREDIT                : ", 29) + Strings.RSet(Conversions.ToString(num23), 8) + " DH" });
					Module1._DT_TEMP.Clear();
					Module1._DA_TEMP = new MySqlDataAdapter("select Article, sum(Qté) as Qté   from   TABLE_VENTES_JOURNAL    Where            CLOTURE_GLOBALE = '" + Strings.Trim(Conversions.ToString(DataGridView122323.Rows[((DataGridViewBand)DataGridView122323.CurrentRow).Index].Cells[0].Value)) + "'     and            (OPERATION = 'CREDIT')               group by Article      ", Module1.cn_SQL);
					((DbDataAdapter)(object)Module1._DA_TEMP).Fill(Module1._DT_TEMP);
					int num31 = Module1._DT_TEMP.Rows.Count - 1;
					int num32 = 0;
					while (true)
					{
						int num33 = num32;
						int num4 = num31;
						if (num33 > num4)
						{
							break;
						}
						DataGridView3.Rows.Add(new object[1] { "  " + Strings.LSet(Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(Module1._DT_TEMP.Rows[num32]["Qté"].ToString()))) + "x", 7) + Module1._DT_TEMP.Rows[num32]["Article"].ToString() });
						num32++;
					}
				}
				if (decimal.Compare(num24, 0m) != 0)
				{
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("RETOUR CREDIT         : ", 29) + Strings.RSet(Conversions.ToString(num24), 8) + " DH" });
					Module1._DT_TEMP.Clear();
					Module1._DA_TEMP = new MySqlDataAdapter("select Article, sum(Qté) as Qté   from   TABLE_VENTES_JOURNAL    Where            CLOTURE_GLOBALE = '" + Strings.Trim(Conversions.ToString(DataGridView122323.Rows[((DataGridViewBand)DataGridView122323.CurrentRow).Index].Cells[0].Value)) + "'     and            (OPERATION = 'RETOUR CREDIT')               group by Article      ", Module1.cn_SQL);
					((DbDataAdapter)(object)Module1._DA_TEMP).Fill(Module1._DT_TEMP);
					int num34 = Module1._DT_TEMP.Rows.Count - 1;
					int num35 = 0;
					while (true)
					{
						int num36 = num35;
						int num4 = num34;
						if (num36 > num4)
						{
							break;
						}
						DataGridView3.Rows.Add(new object[1] { "  " + Strings.LSet(Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(Module1._DT_TEMP.Rows[num35]["Qté"].ToString()))) + "x", 7) + Module1._DT_TEMP.Rows[num35]["Article"].ToString() });
						num35++;
					}
				}
				DataGridView3.Rows.Add(new object[1] { "" });
				DataGridView3.Rows.Add(new object[1] { "" });
				val10 = new MySqlDataAdapter("( select sum((PRIX_V*Qté)-TOTAL_NET) as n                    from TABLE_VENTES_JOURNAL WHERE     CLOTURE_GLOBALE = '" + Strings.Trim(Conversions.ToString(DataGridView122323.Rows[((DataGridViewBand)DataGridView122323.CurrentRow).Index].Cells[0].Value)) + "'             AND     REMISE <  100 )      UNION ALL        ( select sum((PRIX_V*Qté)-TOTAL_NET) as n                   from TABLE_VENTES_JOURNAL WHERE     CLOTURE_GLOBALE = '" + Strings.Trim(Conversions.ToString(DataGridView122323.Rows[((DataGridViewBand)DataGridView122323.CurrentRow).Index].Cells[0].Value)) + "'             AND       REMISE = 100 ) UNION ALL (select sum(TOTAL_NET) as n       from TABLE_VENTES_JOURNAL WHERE     CLOTURE_GLOBALE = '" + Strings.Trim(Conversions.ToString(DataGridView122323.Rows[((DataGridViewBand)DataGridView122323.CurrentRow).Index].Cells[0].Value)) + "'                       And       Famille = 'FAM_DIVERS' )  ", Module1.cn_SQL);
				dataTable10 = new DataTable();
				dataTable10.Clear();
				((DbDataAdapter)(object)val10).Fill(dataTable10);
				decimal num37 = new decimal(Conversion.Val(dataTable10.Rows[0]["n"].ToString()));
				decimal num38 = new decimal(Conversion.Val(dataTable10.Rows[1]["n"].ToString()));
				decimal num39 = new decimal(Conversion.Val(dataTable10.Rows[2]["n"].ToString()));
				if ((decimal.Compare(num37, 0m) != 0) | (decimal.Compare(num38, 0m) != 0) | (decimal.Compare(num39, 0m) != 0))
				{
					DataGridView3.Rows.Add(new object[1] { "---------------ATTENTION-----------------" });
				}
				if (decimal.Compare(num37, 0m) != 0)
				{
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("IL YA DES REMISE      : ", 29) + Strings.RSet(Conversions.ToString(num37), 8) + " DH" });
				}
				if (decimal.Compare(num38, 0m) != 0)
				{
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("IL YA DES OFFERT      : ", 29) + Strings.RSet(Conversions.ToString(num38), 8) + " DH" });
				}
				if (decimal.Compare(num39, 0m) != 0)
				{
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("IL YA DES DIVERS      : ", 29) + Strings.RSet(Conversions.ToString(num39), 8) + " DH" });
				}
				DataGridView3.Rows.Add(new object[1] { "" });
				DataGridView3.Rows.Add(new object[1] { "" });
				if (Operators.CompareString(Text_PRINTER_RAPPORT.Text, "0", TextCompare: false) != 0 && Operators.CompareString(Text_PRINTER_RAPPORT.Text, "", TextCompare: false) != 0)
				{
					Print_Recette_Globale_HISTORIQUE.PrinterSettings.PrinterName = Text_PRINTER_RAPPORT.Text;
				}
				if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null), "Button_ConsRapport_HISTORIQUE", TextCompare: false))
				{
					PrintPreviewDialog val11 = new PrintPreviewDialog();
					val11.Document = Print_Recette_Globale_HISTORIQUE;
					val11.PrintPreviewControl.Zoom = 2.0;
					((Form)val11).WindowState = (FormWindowState)2;
					val11.TopMost = true;
					((Form)val11).ShowDialog();
				}
				else if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null), "Button_PrintRapport_HISTORIQUE", TextCompare: false))
				{
					Print_Recette_Globale_HISTORIQUE.Print();
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
					Bitmap val12 = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, (PixelFormat)2498570);
					Graphics val13 = Graphics.FromImage((Image)(object)val12);
					val13.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, (CopyPixelOperation)13369376);
					((Image)val12).Save(Application.StartupPath + "\\tchak\\" + text + ".snidb", ImageFormat.Jpeg);
					val12 = null;
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

	private void Buttonn_Click(object sender, EventArgs e)
	{
		//IL_1e49: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e50: Expected Obj, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected Obj, but got Unknown
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected Obj, but got Unknown
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected Obj, but got Unknown
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Expected Obj, but got Unknown
		//IL_0514: Unknown result type (might be due to invalid IL or missing references)
		//IL_051b: Expected Obj, but got Unknown
		//IL_05a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b0: Expected Obj, but got Unknown
		//IL_05ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c1: Expected Obj, but got Unknown
		//IL_0408: Unknown result type (might be due to invalid IL or missing references)
		//IL_040f: Expected Obj, but got Unknown
		//IL_0697: Unknown result type (might be due to invalid IL or missing references)
		//IL_069e: Expected Obj, but got Unknown
		//IL_07cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d1: Expected Obj, but got Unknown
		//IL_085e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0864: Expected Obj, but got Unknown
		//IL_0957: Unknown result type (might be due to invalid IL or missing references)
		//IL_095e: Expected Obj, but got Unknown
		//IL_09eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f2: Expected Obj, but got Unknown
		//IL_0ae9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aef: Expected Obj, but got Unknown
		//IL_0b7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b82: Expected Obj, but got Unknown
		//IL_0e53: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e5a: Expected Obj, but got Unknown
		//IL_1028: Unknown result type (might be due to invalid IL or missing references)
		//IL_102f: Expected Obj, but got Unknown
		//IL_0cbf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc6: Expected Obj, but got Unknown
		//IL_0d4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d53: Expected Obj, but got Unknown
		//IL_1250: Unknown result type (might be due to invalid IL or missing references)
		//IL_125a: Expected Obj, but got Unknown
		//IL_1412: Unknown result type (might be due to invalid IL or missing references)
		//IL_141c: Expected Obj, but got Unknown
		//IL_15d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_15dc: Expected Obj, but got Unknown
		//IL_1a0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a13: Expected Obj, but got Unknown
		//IL_1794: Unknown result type (might be due to invalid IL or missing references)
		//IL_179e: Expected Obj, but got Unknown
		//IL_1cf0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cf7: Expected Obj, but got Unknown
		//IL_1d26: Unknown result type (might be due to invalid IL or missing references)
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
				if (DataGridView1434.Rows.Count == 0)
				{
					NewLateBinding.LateSet(sender, null, "Enabled", new object[1] { true }, null, null);
					return;
				}
				NewLateBinding.LateSet(sender, null, "enabled", new object[1] { false }, null, null);
				DataTable dataTable = new DataTable();
				MySqlDataAdapter val = new MySqlDataAdapter();
				dataTable.Clear();
				val = new MySqlDataAdapter("select DISTINCT Famille from TABLE_VENTES_JOURNAL   Where  CLOTURE_CAISSIER = '" + Strings.Trim(Conversions.ToString(DataGridView1434.Rows[((DataGridViewBand)DataGridView1434.CurrentRow).Index].Cells[0].Value)) + "'            And     Caissier like  '" + Strings.Trim(Combo_CLOTURE_CAISSIER.Text) + "'          and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')    ", Module1.cn_SQL);
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
					DataGridView2.Rows.Add(new object[2]
					{
						dataTable.Rows[num2]["Famille"].ToString(),
						"."
					});
					dataTable2.Clear();
					val2 = new MySqlDataAdapter("select Article, sum(Qté) as QTé, sum(TOTAL_NET) as TOTAL_NET    from   TABLE_VENTES_JOURNAL    Where  Famille = '" + Strings.Trim(dataTable.Rows[num2]["Famille"].ToString()) + "'         And     Caissier like  '" + Strings.Trim(Combo_CLOTURE_CAISSIER.Text) + "'    and         CLOTURE_CAISSIER  = '" + Strings.Trim(Conversions.ToString(DataGridView1434.Rows[((DataGridViewBand)DataGridView1434.CurrentRow).Index].Cells[0].Value)) + "'               and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')       group by Article      ", Module1.cn_SQL);
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
					dataTable2.Clear();
					val2 = new MySqlDataAdapter("select  sum(Qté) as QTé, sum(TOTAL_NET) as TOTAL_NET    from   TABLE_VENTES_JOURNAL    Where  Famille = '" + Strings.Trim(dataTable.Rows[num2]["Famille"].ToString()) + "'           And     Caissier like  '" + Strings.Trim(Combo_CLOTURE_CAISSIER.Text) + "'    and            CLOTURE_CAISSIER  = '" + Strings.Trim(Conversions.ToString(DataGridView1434.Rows[((DataGridViewBand)DataGridView1434.CurrentRow).Index].Cells[0].Value)) + "'                 and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')    ", Module1.cn_SQL);
					((DbDataAdapter)(object)val2).Fill(dataTable2);
					DataGridView2.Rows.Add(new object[3]
					{
						"  *TOTAL FAMILLE*",
						"*" + dataTable2.Rows[0]["Qté"].ToString() + "*",
						"*" + dataTable2.Rows[0]["TOTAL_NET"].ToString() + "*"
					});
					DataGridView2.Rows.Add(new object[1] { "" });
					num2++;
				}
				DataGridView3.Rows.Clear();
				DataGridView3.Rows.Add(new object[1] { "                    FINANCE--------------" });
				DataTable dataTable3 = new DataTable();
				MySqlDataAdapter val3 = new MySqlDataAdapter();
				dataTable3.Clear();
				val3 = new MySqlDataAdapter("select   DISTINCT     MODE_P    from TABLE_VENTES_REGLEMENTS   Where     Caissier like  '" + Strings.Trim(Combo_CLOTURE_CAISSIER.Text) + "'      and            CLOTURE_CAISSIER  = '" + Strings.Trim(Conversions.ToString(DataGridView1434.Rows[((DataGridViewBand)DataGridView1434.CurrentRow).Index].Cells[0].Value)) + "'                     ", Module1.cn_SQL);
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
					val4 = new MySqlDataAdapter("select sum(MONTANT) as n     from    TABLE_VENTES_REGLEMENTS     WHERE        MODE_P  = '" + Strings.Trim(dataTable3.Rows[num9]["MODE_P"].ToString()) + "'           And     Caissier like  '" + Strings.Trim(Combo_CLOTURE_CAISSIER.Text) + "'          and            CLOTURE_CAISSIER  = '" + Strings.Trim(Conversions.ToString(DataGridView1434.Rows[((DataGridViewBand)DataGridView1434.CurrentRow).Index].Cells[0].Value)) + "'              ", Module1.cn_SQL);
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
				val5 = new MySqlDataAdapter("SELECT    SUM(MONTANT)      as N          FROM   TABLE_CLIENTS_REGLE     WHERE           Utilisateur like  '" + Strings.Trim(Combo_CLOTURE_CAISSIER.Text) + "'       and            CLOTURE_CAISSIER  = '" + Strings.Trim(Conversions.ToString(DataGridView1434.Rows[((DataGridViewBand)DataGridView1434.CurrentRow).Index].Cells[0].Value)) + "'                     ", Module1.cn_SQL);
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
				val6 = new MySqlDataAdapter("SELECT    SUM(MONTANT)      as N          FROM   TABLE_FOURNISSEURS_REGLE     WHERE           Utilisateur like  '" + Strings.Trim(Combo_CLOTURE_CAISSIER.Text) + "'       and            CLOTURE_CAISSIER  = '" + Strings.Trim(Conversions.ToString(DataGridView1434.Rows[((DataGridViewBand)DataGridView1434.CurrentRow).Index].Cells[0].Value)) + "'                     ", Module1.cn_SQL);
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
				val7 = new MySqlDataAdapter(" select sum(Montant) as n                   FROM   TABLE_DEPENSES           WHERE       Utilisateur like  '" + Strings.Trim(Combo_CLOTURE_CAISSIER.Text) + "'        and            CLOTURE_CAISSIER  = '" + Strings.Trim(Conversions.ToString(DataGridView1434.Rows[((DataGridViewBand)DataGridView1434.CurrentRow).Index].Cells[0].Value)) + "'                  ", Module1.cn_SQL);
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
					val8 = new MySqlDataAdapter("select sum(Total_NET) as n     from TABLE_VENTES_JOURNAL WHERE        Caissier like  '" + Strings.Trim(Combo_CLOTURE_CAISSIER.Text) + "'               and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')         and            CLOTURE_CAISSIER  = '" + Strings.Trim(Conversions.ToString(DataGridView1434.Rows[((DataGridViewBand)DataGridView1434.CurrentRow).Index].Cells[0].Value)) + "'             ", Module1.cn_SQL);
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
				val9 = new MySqlDataAdapter("(select sum(Total_NET) as n from TABLE_VENTES_JOURNAL WHERE             CLOTURE_CAISSIER  = '" + Strings.Trim(Conversions.ToString(DataGridView1434.Rows[((DataGridViewBand)DataGridView1434.CurrentRow).Index].Cells[0].Value)) + "'             And     Caissier like  '" + Strings.Trim(Combo_CLOTURE_CAISSIER.Text) + "'      and            (OPERATION = 'RETOUR REMBOURSEMENT')     )    UNION ALL  (select sum(Total_NET) as n from TABLE_VENTES_JOURNAL WHERE            CLOTURE_CAISSIER  = '" + Strings.Trim(Conversions.ToString(DataGridView1434.Rows[((DataGridViewBand)DataGridView1434.CurrentRow).Index].Cells[0].Value)) + "'           And     Caissier like  '" + Strings.Trim(Combo_CLOTURE_CAISSIER.Text) + "'         and            (OPERATION = 'RETOUR AVOIR')    )       UNION ALL  (select sum(Total_NET) as n from TABLE_VENTES_JOURNAL WHERE            CLOTURE_CAISSIER  = '" + Strings.Trim(Conversions.ToString(DataGridView1434.Rows[((DataGridViewBand)DataGridView1434.CurrentRow).Index].Cells[0].Value)) + "'           And     Caissier like  '" + Strings.Trim(Combo_CLOTURE_CAISSIER.Text) + "'         and            (OPERATION = 'CREDIT')    )          UNION ALL  (select sum(Total_NET) as n from TABLE_VENTES_JOURNAL WHERE            CLOTURE_CAISSIER  = '" + Strings.Trim(Conversions.ToString(DataGridView1434.Rows[((DataGridViewBand)DataGridView1434.CurrentRow).Index].Cells[0].Value)) + "'           And     Caissier like  '" + Strings.Trim(Combo_CLOTURE_CAISSIER.Text) + "'         and            (OPERATION = 'RETOUR CREDIT')    )   ", Module1.cn_SQL);
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
					Module1._DA_TEMP = new MySqlDataAdapter("select Article, sum(Qté) as Qté   from   TABLE_VENTES_JOURNAL    Where              CLOTURE_CAISSIER  = '" + Strings.Trim(Conversions.ToString(DataGridView1434.Rows[((DataGridViewBand)DataGridView1434.CurrentRow).Index].Cells[0].Value)) + "'             And     Caissier like  '" + Strings.Trim(Combo_CLOTURE_CAISSIER.Text) + "'       and            (OPERATION = 'RETOUR REMBOURSEMENT')               group by Article      ", Module1.cn_SQL);
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
					Module1._DA_TEMP = new MySqlDataAdapter("select Article, sum(Qté) as Qté   from   TABLE_VENTES_JOURNAL    Where              CLOTURE_CAISSIER  = '" + Strings.Trim(Conversions.ToString(DataGridView1434.Rows[((DataGridViewBand)DataGridView1434.CurrentRow).Index].Cells[0].Value)) + "'             And     Caissier like  '" + Strings.Trim(Combo_CLOTURE_CAISSIER.Text) + "'      and            (OPERATION = 'RETOUR AVOIR')               group by Article      ", Module1.cn_SQL);
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
					Module1._DA_TEMP = new MySqlDataAdapter("select Article, sum(Qté) as Qté   from   TABLE_VENTES_JOURNAL    Where            CLOTURE_CAISSIER  = '" + Strings.Trim(Conversions.ToString(DataGridView1434.Rows[((DataGridViewBand)DataGridView1434.CurrentRow).Index].Cells[0].Value)) + "'             And     Caissier like  '" + Strings.Trim(Combo_CLOTURE_CAISSIER.Text) + "'      and            (OPERATION = 'CREDIT')               group by Article      ", Module1.cn_SQL);
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
					Module1._DA_TEMP = new MySqlDataAdapter("select Article, sum(Qté) as Qté   from   TABLE_VENTES_JOURNAL    Where            CLOTURE_CAISSIER  = '" + Strings.Trim(Conversions.ToString(DataGridView1434.Rows[((DataGridViewBand)DataGridView1434.CurrentRow).Index].Cells[0].Value)) + "'             And     Caissier like  '" + Strings.Trim(Combo_CLOTURE_CAISSIER.Text) + "'      and            (OPERATION = 'RETOUR CREDIT')               group by Article      ", Module1.cn_SQL);
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
				val9 = new MySqlDataAdapter("( select sum((PRIX_V*Qté)-TOTAL_NET) as n                    from TABLE_VENTES_JOURNAL WHERE     CLOTURE_CAISSIER = '" + Strings.Trim(Conversions.ToString(DataGridView1434.Rows[((DataGridViewBand)DataGridView1434.CurrentRow).Index].Cells[0].Value)) + "'          And     Caissier like  '" + Strings.Trim(ListBox_CAISSIERS.Text) + "'               AND     REMISE <  100 )      UNION ALL        ( select sum((PRIX_V*Qté)-TOTAL_NET) as n                   from TABLE_VENTES_JOURNAL WHERE     CLOTURE_CAISSIER = '" + Strings.Trim(Conversions.ToString(DataGridView1434.Rows[((DataGridViewBand)DataGridView1434.CurrentRow).Index].Cells[0].Value)) + "'           And     Caissier like  '" + Strings.Trim(ListBox_CAISSIERS.Text) + "'            AND       REMISE = 100 ) UNION ALL (select sum(TOTAL_NET) as n       from TABLE_VENTES_JOURNAL WHERE     CLOTURE_CAISSIER = '" + Strings.Trim(Conversions.ToString(DataGridView1434.Rows[((DataGridViewBand)DataGridView1434.CurrentRow).Index].Cells[0].Value)) + "'             And     Caissier like  '" + Strings.Trim(ListBox_CAISSIERS.Text) + "'                  And       Famille = 'FAM_DIVERS' )  ", Module1.cn_SQL);
				dataTable9 = new DataTable();
				dataTable9.Clear();
				((DbDataAdapter)(object)val9).Fill(dataTable9);
				decimal num31 = new decimal(Conversion.Val(dataTable9.Rows[0]["n"].ToString()));
				decimal num32 = new decimal(Conversion.Val(dataTable9.Rows[1]["n"].ToString()));
				decimal num33 = new decimal(Conversion.Val(dataTable9.Rows[2]["n"].ToString()));
				if ((decimal.Compare(num31, 0m) != 0) | (decimal.Compare(num32, 0m) != 0) | (decimal.Compare(num33, 0m) != 0))
				{
					DataGridView3.Rows.Add(new object[1] { "---------------ATTENTION-----------------" });
				}
				if (decimal.Compare(num31, 0m) != 0)
				{
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("IL YA DES REMISE      : ", 29) + Strings.RSet(Conversions.ToString(num31), 8) + " DH" });
				}
				if (decimal.Compare(num32, 0m) != 0)
				{
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("IL YA DES OFFERT      : ", 29) + Strings.RSet(Conversions.ToString(num32), 8) + " DH" });
				}
				if (decimal.Compare(num33, 0m) != 0)
				{
					DataGridView3.Rows.Add(new object[1] { Strings.LSet("IL YA DES DIVERS      : ", 29) + Strings.RSet(Conversions.ToString(num33), 8) + " DH" });
				}
				DataGridView3.Rows.Add(new object[1] { "" });
				DataGridView3.Rows.Add(new object[1] { "" });
				if (Operators.CompareString(Text_PRINTER_RAPPORT.Text, "0", TextCompare: false) != 0 && Operators.CompareString(Text_PRINTER_RAPPORT.Text, "", TextCompare: false) != 0)
				{
					Print_Recette_caissier_HISTORIQUE.PrinterSettings.PrinterName = Text_PRINTER_RAPPORT.Text;
				}
				if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null), "Button_ConsCaissier_HISTORIQUE", TextCompare: false))
				{
					PrintPreviewDialog val10 = new PrintPreviewDialog();
					val10.Document = Print_Recette_caissier_HISTORIQUE;
					val10.PrintPreviewControl.Zoom = 2.0;
					((Form)val10).WindowState = (FormWindowState)2;
					((Form)val10).ShowDialog();
				}
				else if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null), "Button_PrintCaissier_HISTORIQUE", TextCompare: false))
				{
					Print_Recette_caissier_HISTORIQUE.Print();
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
					Bitmap val11 = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, (PixelFormat)2498570);
					Graphics val12 = Graphics.FromImage((Image)(object)val11);
					val12.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, (CopyPixelOperation)13369376);
					((Image)val11).Save(Application.StartupPath + "\\tchak\\" + text + ".snidb", ImageFormat.Jpeg);
					val11 = null;
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

	private void Button_MAIL_GLOBALE_Click(object sender, EventArgs e)
	{
		//IL_0619: Unknown result type (might be due to invalid IL or missing references)
		//IL_0620: Expected Obj, but got Unknown
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Expected Obj, but got Unknown
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0336: Expected Obj, but got Unknown
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
				stringBuilder.AppendLine("<tr width='100%'  align='center' valign='center' style='background-color: rgb(22,106,238);color: white; font-size : 25px;font-weight: bold; border: 2px solid rgb(22,106,238);' >CLOTURE GLOBALE</tr>");
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
				val3 = new MySqlDataAdapter("select sum(Total_NET) as n     from TABLE_VENTES_JOURNAL WHERE       CLOTURE_GLOBALE IS  NULL          and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')       ", Module1.cn_SQL);
				((DbDataAdapter)(object)val3).Fill(dataTable);
				num11 = Conversions.ToDouble(Strings.FormatNumber(Conversion.Val(dataTable.Rows[0]["n"].ToString())));
				string text = "<br/><br/> <b style='background-color: White ;color: Black; font-size : 18px ; font-weight: bold'>● " + MyProject.Forms.Form_1_LOGIN.TextBox_ORGANISME.Text + Text_MAIL_TITRE.Text + "</b>";
				string text2 = "<br/><br/> <b style='background-color: White;color: Black; font-size : 18px ; font-weight: bold '>● Date Cloture : " + Label_DATE_DE_CLOTURE_GLOBALE.Text + "</b>";
				string text3 = "<br/><br/> <b style='background-color: White;color: Black; font-size : 18px ; font-weight: bold '>● Date Impression : " + Conversions.ToString(DateTime.Now) + "</b>";
				string text4 = "<br/><br/> <b style='background-color: White;color: Black; font-size : 18px ; font-weight: bold '>● Total Net : " + Strings.FormatNumber(Strings.RSet(Conversions.ToString(num11), 8)) + "  DH</b>";
				MailMessage mailMessage = new MailMessage();
				mailMessage.From = new MailAddress("logica.application@gmail.com");
				mailMessage.To.Add(Text_mail.Text);
				mailMessage.Subject = "Cloture Gloable (" + MyProject.Forms.Form_1_LOGIN.TextBox_ORGANISME.Text + Text_MAIL_TITRE.Text + ") " + Label_DATE_DE_CLOTURE_GLOBALE.Text;
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

	private void Button_MAIL_CAISSIER_Click(object sender, EventArgs e)
	{
		//IL_067b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0682: Expected Obj, but got Unknown
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Expected Obj, but got Unknown
		//IL_0349: Unknown result type (might be due to invalid IL or missing references)
		//IL_0350: Expected Obj, but got Unknown
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
				stringBuilder.AppendLine("<tr width='100%'  align='center' valign='center' style='background-color: rgb(22,106,238);color: white; font-size : 25px;font-weight: bold; border: 2px solid rgb(22,106,238);' >CLOTURE CAISSIER</tr>");
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
				val3 = new MySqlDataAdapter("select sum(Total_NET) as n     from TABLE_VENTES_JOURNAL        WHERE         CLOTURE_CAISSIER   IS  NULL          AND    Caissier like  '" + Strings.Trim(ListBox_CAISSIERS.Text) + "'                and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')          ", Module1.cn_SQL);
				((DbDataAdapter)(object)val3).Fill(dataTable);
				num11 = Conversions.ToDouble(Strings.FormatNumber(Conversion.Val(dataTable.Rows[0]["n"].ToString())));
				string text = "<br/><br/> <b style='background-color: White ;color: Black; font-size : 18px ; font-weight: bold'>● " + MyProject.Forms.Form_1_LOGIN.TextBox_ORGANISME.Text + Text_MAIL_TITRE.Text + "</b>";
				string text2 = "<br/><br/> <b style='background-color: White;color: Black; font-size : 18px ; font-weight: bold'>● Date Cloture    : " + Label_DATE_DE_CLOTURE_CAISSIER.Text + "</b>";
				string text3 = "<br/><br/> <b style='background-color: White;color: Black; font-size : 18px ; font-weight: bold'>● Date Impression : " + Conversions.ToString(DateTime.Now) + "</b>";
				string text4 = "<br/><br/> <b style='background-color: White;color: Black; font-size : 18px ; font-weight: bold'>● Total Net : " + Strings.FormatNumber(Strings.RSet(Conversions.ToString(num11), 8)) + "  DH</b>";
				string text5 = "<br/><br/> <b style='background-color: White;color: Black; font-size : 18px ; font-weight: bold'>● Caissier  : " + Strings.Trim(ListBox_CAISSIERS.Text) + "</b>";
				MailMessage mailMessage = new MailMessage();
				mailMessage.From = new MailAddress("logica.application@gmail.com");
				mailMessage.To.Add(Text_mail.Text);
				mailMessage.Subject = "Cloture " + Strings.Trim(ListBox_CAISSIERS.Text) + " (" + MyProject.Forms.Form_1_LOGIN.TextBox_ORGANISME.Text + Text_MAIL_TITRE.Text + ") " + Label_DATE_DE_CLOTURE_CAISSIER.Text;
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

	private void Button_TOTAL_CAISSIER_Click(object sender, EventArgs e)
	{
		//IL_04bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c4: Expected Obj, but got Unknown
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected Obj, but got Unknown
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Expected Obj, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected Obj, but got Unknown
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Expected Obj, but got Unknown
		//IL_0369: Unknown result type (might be due to invalid IL or missing references)
		//IL_0373: Expected Obj, but got Unknown
		try
		{
			NewLateBinding.LateSet(sender, null, "enabled", new object[1] { false }, null, null);
			Application.DoEvents();
			if (((Control)MyProject.Forms.Form_3_VENTE_JOURNAL).Visible)
			{
				DT.Clear();
				DA = new MySqlDataAdapter("select * from   TABLE_VENTES_JOURNAL     Where        CLOTURE_CAISSIER IS  NULL      And     Caissier like  '" + Strings.Trim(ListBox_CAISSIERS.Text) + "'     order by ID desc ", Module1.cn_SQL);
				((DbDataAdapter)(object)DA).Fill(DT);
				MyProject.Forms.Form_3_VENTE_JOURNAL.DataGridView1.DataSource = DT;
				MyProject.Forms.Form_3_VENTE_JOURNAL._COLORISE_DATAGRID();
			}
			_dt.Clear();
			_dt = new DataTable();
			_da = new MySqlDataAdapter("select sum(TOTAL_NET) as n   from   TABLE_VENTES_JOURNAL    WHERE        CLOTURE_CAISSIER IS  NULL           And     Caissier like  '" + Strings.Trim(ListBox_CAISSIERS.Text) + "'            and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')         ", Module1.cn_SQL);
			((DbDataAdapter)(object)_da).Fill(_dt);
			Label_TOTAL_NET_CLOTURE_CAISSIER.Text = Strings.FormatNumber(Conversion.Val(_dt.Rows[0]["n"].ToString()));
			_dt.Clear();
			_dt = new DataTable();
			_da = new MySqlDataAdapter("select    TOP 1    *     from     TABLE_VENTES_JOURNAL           Where         CLOTURE_CAISSIER IS  NOT NULL     and        Caissier like  '" + Strings.Trim(ListBox_CAISSIERS.Text) + "'          ORDER BY ID DESC    ", Module1.cn_SQL);
			((DbDataAdapter)(object)_da).Fill(_dt);
			if (_dt.Rows.Count == 0)
			{
				Label_N_CLOTURE_CLOTURE_CAISSIER.Text = Conversions.ToString(Conversions.ToDouble(Strings.FormatNumber(0)) + 1.0);
			}
			else
			{
				Label_N_CLOTURE_CLOTURE_CAISSIER.Text = Conversions.ToString(Conversions.ToDouble(Strings.FormatNumber(Conversion.Val(_dt.Rows[0]["CLOTURE_CAISSIER"].ToString()))) + 1.0);
			}
			_dt.Clear();
			_dt = new DataTable();
			_da = new MySqlDataAdapter("select      TOP 1    *     from     TABLE_VENTES_JOURNAL       Where        CLOTURE_CAISSIER IS  NULL     AND     Caissier like  '" + Strings.Trim(ListBox_CAISSIERS.Text) + "'       ORDER BY ID ASC ", Module1.cn_SQL);
			((DbDataAdapter)(object)_da).Fill(_dt);
			if (_dt.Rows.Count == 0)
			{
				Label_DATE_DE_CLOTURE_CAISSIER.Text = "0";
			}
			else
			{
				Label_DATE_DE_CLOTURE_CAISSIER.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(_dt.Rows[0]["Dates"], " "), _dt.Rows[0]["Heure"]));
			}
			_dt.Clear();
			_dt = new DataTable();
			_da = new MySqlDataAdapter("select      TOP 1    *     from     TABLE_VENTES_JOURNAL       Where         CLOTURE_CAISSIER IS NULL     AND      Caissier like  '" + Strings.Trim(ListBox_CAISSIERS.Text) + "'      ORDER BY ID DESC  ", Module1.cn_SQL);
			((DbDataAdapter)(object)_da).Fill(_dt);
			if (_dt.Rows.Count == 0)
			{
				Label_DATE_A_CLOTURE_CAISSIER.Text = "0";
			}
			else
			{
				Label_DATE_A_CLOTURE_CAISSIER.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(_dt.Rows[0]["Dates"], " "), _dt.Rows[0]["Heure"]));
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
		NewLateBinding.LateSet(sender, null, "enabled", new object[1] { true }, null, null);
	}

	private void ListBox_CAISSIERS_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		if (!((Control)Panel_CLOTURE_CAISSIER).Visible)
		{
			((Control)Panel_CLOTURE_CAISSIER).Visible = true;
			((Control)Panel_CLOTURE_CAISSIER).BringToFront();
		}
		else
		{
			((Control)Panel_CLOTURE_CAISSIER).Visible = false;
		}
	}

	private void Button244_Click(object sender, EventArgs e)
	{
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
		((Control)MyProject.Forms.Form_3_VENTE_JOURNAL.Panel_CLOTURE).Hide();
		((Form)this).Close();
	}

	private void Button7_Click(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected Obj, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected Obj, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected Obj, but got Unknown
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected Obj, but got Unknown
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected Obj, but got Unknown
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Expected Obj, but got Unknown
		DataTable dataTable = new DataTable();
		MySqlDataAdapter val = new MySqlDataAdapter();
		dataTable.Clear();
		val = new MySqlDataAdapter("select DISTINCT CLOTURE_GLOBALE from TABLE_VENTES_JOURNAL   Where  Dates   =        ' " + Strings.Format(DateTimePicker1.Value, "yyyy-MM-dd") + " '          ", Module1.cn_SQL);
		((DbDataAdapter)(object)val).Fill(dataTable);
		DataGridView122323.Rows.Clear();
		DataTable dataTable2 = new DataTable();
		MySqlDataAdapter val2 = new MySqlDataAdapter();
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
					dataTable2.Clear();
					dataTable2 = new DataTable();
					val2 = new MySqlDataAdapter("select   sum(TOTAL_NET) as TOTAL_NET    from   TABLE_VENTES_JOURNAL    Where  CLOTURE_GLOBALE = '" + Strings.Trim(dataTable.Rows[num2]["CLOTURE_GLOBALE"].ToString()) + "'              and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')       ", Module1.cn_SQL);
					((DbDataAdapter)(object)val2).Fill(dataTable2);
					string text = Strings.FormatNumber(Conversion.Val(dataTable2.Rows[0]["TOTAL_NET"].ToString()));
					dataTable2.Clear();
					dataTable2 = new DataTable();
					val2 = new MySqlDataAdapter("select      TOP 1    *     from     TABLE_VENTES_JOURNAL       Where        CLOTURE_GLOBALE   = '" + Strings.Trim(dataTable.Rows[num2]["CLOTURE_GLOBALE"].ToString()) + "'     ORDER BY ID   ASC ", Module1.cn_SQL);
					((DbDataAdapter)(object)val2).Fill(dataTable2);
					object obj = ((dataTable2.Rows.Count != 0) ? Operators.ConcatenateObject(Operators.ConcatenateObject(dataTable2.Rows[0]["Dates"], " "), dataTable2.Rows[0]["Heure"]) : "0");
					dataTable2.Clear();
					dataTable2 = new DataTable();
					val2 = new MySqlDataAdapter("select      TOP 1    *     from     TABLE_VENTES_JOURNAL       Where        CLOTURE_GLOBALE = '" + Strings.Trim(dataTable.Rows[num2]["CLOTURE_GLOBALE"].ToString()) + "'       ORDER BY ID DESC  ", Module1.cn_SQL);
					((DbDataAdapter)(object)val2).Fill(dataTable2);
					object obj2 = ((dataTable2.Rows.Count != 0) ? Operators.ConcatenateObject(Operators.ConcatenateObject(dataTable2.Rows[0]["Dates"], " "), dataTable2.Rows[0]["Heure"]) : "0");
					DataGridView122323.Rows.Add(new object[4]
					{
						dataTable.Rows[num2]["CLOTURE_GLOBALE"].ToString(),
						text,
						RuntimeHelpers.GetObjectValue(obj),
						RuntimeHelpers.GetObjectValue(obj2)
					});
					num2++;
					continue;
				}
				break;
			}
		}
	}

	private void Button6_Click(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected Obj, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected Obj, but got Unknown
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected Obj, but got Unknown
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected Obj, but got Unknown
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Expected Obj, but got Unknown
		//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02db: Expected Obj, but got Unknown
		DataTable dataTable = new DataTable();
		MySqlDataAdapter val = new MySqlDataAdapter();
		dataTable.Clear();
		val = new MySqlDataAdapter("select DISTINCT   CLOTURE_CAISSIER    from TABLE_VENTES_JOURNAL   Where  Dates   =        ' " + Strings.Format(DateTimePicker2.Value, "yyyy-MM-dd") + " '     And     Caissier like  '" + Strings.Trim(Combo_CLOTURE_CAISSIER.Text) + "'       ", Module1.cn_SQL);
		((DbDataAdapter)(object)val).Fill(dataTable);
		DataGridView1434.Rows.Clear();
		DataTable dataTable2 = new DataTable();
		MySqlDataAdapter val2 = new MySqlDataAdapter();
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
					dataTable2.Clear();
					dataTable2 = new DataTable();
					val2 = new MySqlDataAdapter("select   sum(TOTAL_NET) as TOTAL_NET    from   TABLE_VENTES_JOURNAL    Where  CLOTURE_CAISSIER = '" + Strings.Trim(dataTable.Rows[num2]["CLOTURE_CAISSIER"].ToString()) + "'     And     Caissier like  '" + Strings.Trim(Combo_CLOTURE_CAISSIER.Text) + "'           and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')       ", Module1.cn_SQL);
					((DbDataAdapter)(object)val2).Fill(dataTable2);
					string text = Strings.FormatNumber(Conversion.Val(dataTable2.Rows[0]["TOTAL_NET"].ToString()));
					dataTable2.Clear();
					dataTable2 = new DataTable();
					val2 = new MySqlDataAdapter("select      TOP 1    *     from     TABLE_VENTES_JOURNAL       Where        CLOTURE_CAISSIER   = '" + Strings.Trim(dataTable.Rows[num2]["CLOTURE_CAISSIER"].ToString()) + "'    And     Caissier like  '" + Strings.Trim(Combo_CLOTURE_CAISSIER.Text) + "'      ORDER BY ID   ASC ", Module1.cn_SQL);
					((DbDataAdapter)(object)val2).Fill(dataTable2);
					object obj = ((dataTable2.Rows.Count != 0) ? Operators.ConcatenateObject(Operators.ConcatenateObject(dataTable2.Rows[0]["Dates"], " "), dataTable2.Rows[0]["Heure"]) : "0");
					dataTable2.Clear();
					dataTable2 = new DataTable();
					val2 = new MySqlDataAdapter("select      TOP 1    *     from     TABLE_VENTES_JOURNAL       Where        CLOTURE_CAISSIER = '" + Strings.Trim(dataTable.Rows[num2]["CLOTURE_CAISSIER"].ToString()) + "'      AND      Caissier like  '" + Strings.Trim(ListBox_CAISSIERS.Text) + "'    ORDER BY ID DESC  ", Module1.cn_SQL);
					((DbDataAdapter)(object)val2).Fill(dataTable2);
					object obj2 = ((dataTable2.Rows.Count != 0) ? Operators.ConcatenateObject(Operators.ConcatenateObject(dataTable2.Rows[0]["Dates"], " "), dataTable2.Rows[0]["Heure"]) : "0");
					DataGridView1434.Rows.Add(new object[4]
					{
						dataTable.Rows[num2]["CLOTURE_CAISSIER"].ToString(),
						text,
						RuntimeHelpers.GetObjectValue(obj),
						RuntimeHelpers.GetObjectValue(obj2)
					});
					num2++;
					continue;
				}
				break;
			}
		}
	}

	private void Button3_Click(object sender, EventArgs e)
	{
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Expected Obj, but got Unknown
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Expected Obj, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected Obj, but got Unknown
		try
		{
			if (DataGridView122323.Rows.Count == 0)
			{
				NewLateBinding.LateSet(sender, null, "Enabled", new object[1] { true }, null, null);
				return;
			}
			NewLateBinding.LateSet(sender, null, "enabled", new object[1] { false }, null, null);
			if (((Control)MyProject.Forms.Form_3_VENTE_JOURNAL).Visible)
			{
				DT.Clear();
				DA = new MySqlDataAdapter("select * from   TABLE_VENTES_JOURNAL     Where        CLOTURE_GLOBALE = '" + Strings.Trim(Conversions.ToString(DataGridView122323.Rows[((DataGridViewBand)DataGridView122323.CurrentRow).Index].Cells[0].Value)) + "'     order by ID desc ", Module1.cn_SQL);
				((DbDataAdapter)(object)DA).Fill(DT);
				MyProject.Forms.Form_3_VENTE_JOURNAL.DataGridView1.DataSource = DT;
				MyProject.Forms.Form_3_VENTE_JOURNAL._COLORISE_DATAGRID();
			}
			_dt.Clear();
			_dt = new DataTable();
			_da = new MySqlDataAdapter("select sum(TOTAL_NET) as n from TABLE_VENTES_JOURNAL WHERE        CLOTURE_GLOBALE  = '" + Strings.Trim(Conversions.ToString(DataGridView122323.Rows[((DataGridViewBand)DataGridView122323.CurrentRow).Index].Cells[0].Value)) + "'             and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')        ", Module1.cn_SQL);
			((DbDataAdapter)(object)_da).Fill(_dt);
			Label23.Text = Strings.FormatNumber(Conversion.Val(_dt.Rows[0]["n"].ToString()));
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
		NewLateBinding.LateSet(sender, null, "enabled", new object[1] { true }, null, null);
	}

	private void Button10_Click(object sender, EventArgs e)
	{
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Expected Obj, but got Unknown
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Expected Obj, but got Unknown
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected Obj, but got Unknown
		try
		{
			if (DataGridView1434.Rows.Count == 0)
			{
				NewLateBinding.LateSet(sender, null, "Enabled", new object[1] { true }, null, null);
				return;
			}
			NewLateBinding.LateSet(sender, null, "enabled", new object[1] { false }, null, null);
			if (((Control)MyProject.Forms.Form_3_VENTE_JOURNAL).Visible)
			{
				DT.Clear();
				DA = new MySqlDataAdapter("select * from   TABLE_VENTES_JOURNAL     Where        CLOTURE_CAISSIER = '" + Strings.Trim(Conversions.ToString(DataGridView1434.Rows[((DataGridViewBand)DataGridView1434.CurrentRow).Index].Cells[0].Value)) + "'       And     Caissier like  '" + Strings.Trim(Combo_CLOTURE_CAISSIER.Text) + "'     order by ID desc ", Module1.cn_SQL);
				((DbDataAdapter)(object)DA).Fill(DT);
				MyProject.Forms.Form_3_VENTE_JOURNAL.DataGridView1.DataSource = DT;
				MyProject.Forms.Form_3_VENTE_JOURNAL._COLORISE_DATAGRID();
			}
			_dt.Clear();
			_dt = new DataTable();
			_da = new MySqlDataAdapter("select sum(TOTAL_NET) as n from TABLE_VENTES_JOURNAL WHERE        CLOTURE_CAISSIER  = '" + Strings.Trim(Conversions.ToString(DataGridView1434.Rows[((DataGridViewBand)DataGridView1434.CurrentRow).Index].Cells[0].Value)) + "'          And     Caissier like  '" + Strings.Trim(Combo_CLOTURE_CAISSIER.Text) + "'       and            (OPERATION = 'VENTE'      OR      OPERATION = 'RETOUR REMBOURSEMENT')        ", Module1.cn_SQL);
			((DbDataAdapter)(object)_da).Fill(_dt);
			Label15.Text = Strings.FormatNumber(Conversion.Val(_dt.Rows[0]["n"].ToString()));
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
		NewLateBinding.LateSet(sender, null, "enabled", new object[1] { true }, null, null);
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		if (!((Control)Panel_RAPPORT).Visible)
		{
			((Control)Panel_RAPPORT).Visible = true;
			((Control)Panel_RAPPORT).BringToFront();
		}
		else
		{
			((Control)Panel_RAPPORT).Visible = false;
		}
	}

	private void Button_ConsCaissier_HISTORIQUE_Click(object sender, EventArgs e)
	{
	}
}
