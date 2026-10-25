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
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Bunifu.UI.WinForms;
using ClosedXML.Excel;
using CustomControls.RJControls;
using LOGICA.My;
using LOGICA.My.Resources;
using Microsoft.Reporting.WinForms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace LOGICA;

[DesignerGenerated]
public class Form_5_CLIENTS : Form
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

	[AccessedThroughProperty("Text_ICE")]
	private TextBox _Text_ICE;

	[AccessedThroughProperty("Text_NOTE")]
	private TextBox _Text_NOTE;

	[AccessedThroughProperty("Text_TEL")]
	private TextBox _Text_TEL;

	[AccessedThroughProperty("Text_VILLE")]
	private TextBox _Text_VILLE;

	[AccessedThroughProperty("Text_ADRESSE")]
	private TextBox _Text_ADRESSE;

	[AccessedThroughProperty("Text_CLIENT")]
	private TextBox _Text_CLIENT;

	[AccessedThroughProperty("Text_CODE_CLIENT")]
	private TextBox _Text_CODE_CLIENT;

	[AccessedThroughProperty("Text_ID")]
	private TextBox _Text_ID;

	[AccessedThroughProperty("TabControl1")]
	private TabControl _TabControl1;

	[AccessedThroughProperty("TabPage1")]
	private TabPage _TabPage1;

	[AccessedThroughProperty("DateTimePicker3")]
	private DateTimePicker _DateTimePicker3;

	[AccessedThroughProperty("DateTimePicker4")]
	private DateTimePicker _DateTimePicker4;

	[AccessedThroughProperty("DataGridView_REGLEMENTS")]
	private DataGridView _DataGridView_REGLEMENTS;

	[AccessedThroughProperty("Label15")]
	private Label _Label15;

	[AccessedThroughProperty("Label_REGLE")]
	private Label _Label_REGLE;

	[AccessedThroughProperty("Label_CREDIT")]
	private Label _Label_CREDIT;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	[AccessedThroughProperty("Label17")]
	private Label _Label17;

	[AccessedThroughProperty("Label_BALANCE")]
	private Label _Label_BALANCE;

	[AccessedThroughProperty("Text_ETAT")]
	private TextBox _Text_ETAT;

	[AccessedThroughProperty("DateTimePicker_DATE")]
	private DateTimePicker _DateTimePicker_DATE;

	[AccessedThroughProperty("Label23")]
	private Label _Label23;

	[AccessedThroughProperty("Label21")]
	private Label _Label21;

	[AccessedThroughProperty("DateTimePicker5")]
	private DateTimePicker _DateTimePicker5;

	[AccessedThroughProperty("DateTimePicker6")]
	private DateTimePicker _DateTimePicker6;

	[AccessedThroughProperty("DataGridView_DETAILS_VENTES")]
	private DataGridView _DataGridView_DETAILS_VENTES;

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

	[AccessedThroughProperty("Label_TABLE")]
	private Label _Label_TABLE;

	[AccessedThroughProperty("Panel_HISTORIQUE")]
	private Panel _Panel_HISTORIQUE;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("Label_HISTORIQUE_CLIENT")]
	private Label _Label_HISTORIQUE_CLIENT;

	[AccessedThroughProperty("TabControl2")]
	private TabControl _TabControl2;

	[AccessedThroughProperty("TabPage5")]
	private TabPage _TabPage5;

	[AccessedThroughProperty("TabPage6")]
	private TabPage _TabPage6;

	[AccessedThroughProperty("Label30")]
	private Label _Label30;

	[AccessedThroughProperty("Label29")]
	private Label _Label29;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("PictureBox3")]
	private PictureBox _PictureBox3;

	[AccessedThroughProperty("Button16")]
	private Button _Button16;

	[AccessedThroughProperty("PictureBox4")]
	private PictureBox _PictureBox4;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[AccessedThroughProperty("Button3")]
	private Button _Button3;

	[AccessedThroughProperty("Label_HISTORIQUE_ID_CLIENT")]
	private Label _Label_HISTORIQUE_ID_CLIENT;

	[AccessedThroughProperty("Button_PrintRapport_2")]
	private Button _Button_PrintRapport_2;

	[AccessedThroughProperty("Panel_FIND")]
	private Panel _Panel_FIND;

	[AccessedThroughProperty("Panel_DATES")]
	private Panel _Panel_DATES;

	[AccessedThroughProperty("Picture_FIND_DATES")]
	private PictureBox _Picture_FIND_DATES;

	[AccessedThroughProperty("PictureBox2")]
	private PictureBox _PictureBox2;

	[AccessedThroughProperty("Label_REGLE_CLIENT")]
	private Label _Label_REGLE_CLIENT;

	[AccessedThroughProperty("Label13")]
	private Label _Label13;

	[AccessedThroughProperty("Label_RETOUR_CREDIT")]
	private Label _Label_RETOUR_CREDIT;

	[AccessedThroughProperty("Label_VENTE_CREDIT")]
	private Label _Label_VENTE_CREDIT;

	[AccessedThroughProperty("Label16")]
	private Label _Label16;

	[AccessedThroughProperty("Label18")]
	private Label _Label18;

	[AccessedThroughProperty("Label22")]
	private Label _Label22;

	[AccessedThroughProperty("Label_CREDIT_INITIAL")]
	private Label _Label_CREDIT_INITIAL;

	[AccessedThroughProperty("Text_CREDIT_INITIAL")]
	private TextBox _Text_CREDIT_INITIAL;

	[AccessedThroughProperty("DataGridView_VENTES")]
	private DataGridView _DataGridView_VENTES;

	[AccessedThroughProperty("ID_REGLE")]
	private DataGridViewTextBoxColumn _ID_REGLE;

	[AccessedThroughProperty("DATES_REGLEMENT")]
	private DataGridViewTextBoxColumn _DATES_REGLEMENT;

	[AccessedThroughProperty("MONTANT")]
	private DataGridViewTextBoxColumn _MONTANT;

	[AccessedThroughProperty("NOTES")]
	private DataGridViewTextBoxColumn _NOTES;

	[AccessedThroughProperty("ID_TICKET")]
	private DataGridViewTextBoxColumn _ID_TICKET;

	[AccessedThroughProperty("TICKET")]
	private DataGridViewTextBoxColumn _TICKET;

	[AccessedThroughProperty("DATES_CREDIT")]
	private DataGridViewTextBoxColumn _DATES_CREDIT;

	[AccessedThroughProperty("TOTAL_NET")]
	private DataGridViewTextBoxColumn _TOTAL_NET;

	[AccessedThroughProperty("OPERATION")]
	private DataGridViewTextBoxColumn _OPERATION;

	[AccessedThroughProperty("Text_ID_CLIENT")]
	private TextBox _Text_ID_CLIENT;

	[AccessedThroughProperty("Combo_VENDEUR")]
	private ComboBox _Combo_VENDEUR;

	[AccessedThroughProperty("Button_CREDIT_INITIAL_MODIF")]
	private Button _Button_CREDIT_INITIAL_MODIF;

	[AccessedThroughProperty("Button_FONCTIONS")]
	private Button _Button_FONCTIONS;

	[AccessedThroughProperty("Panel_FONCTIONS")]
	private Panel _Panel_FONCTIONS;

	[AccessedThroughProperty("Label41")]
	private Label _Label41;

	[AccessedThroughProperty("Label44")]
	private Label _Label44;

	[AccessedThroughProperty("Label43")]
	private Label _Label43;

	[AccessedThroughProperty("Label42")]
	private Label _Label42;

	[AccessedThroughProperty("Button_PDF")]
	private Button _Button_PDF;

	[AccessedThroughProperty("Button_EXCEL")]
	private Button _Button_EXCEL;

	[AccessedThroughProperty("Button_WORD")]
	private Button _Button_WORD;

	[AccessedThroughProperty("Text_PAYS")]
	private TextBox _Text_PAYS;

	[AccessedThroughProperty("Picture_FIND")]
	private Button_RJ _Picture_FIND;

	[AccessedThroughProperty("Text_FIND")]
	private RJTextBox _Text_FIND;

	[AccessedThroughProperty("Picture_REFRESH")]
	private Button_RJ _Picture_REFRESH;

	[AccessedThroughProperty("Check_FIND_EXACTE")]
	private BunifuCheckBox _Check_FIND_EXACTE;

	[AccessedThroughProperty("Check_FIND_DATE")]
	private BunifuCheckBox _Check_FIND_DATE;

	[AccessedThroughProperty("Label26")]
	private Label _Label26;

	[AccessedThroughProperty("Label20")]
	private Label _Label20;

	[AccessedThroughProperty("Picture_EXPORT")]
	private Button_RJ _Picture_EXPORT;

	[AccessedThroughProperty("Combo_FIND")]
	private BunifuDropdown _Combo_FIND;

	[AccessedThroughProperty("DateTime1_FIND")]
	private DateTimePicker _DateTime1_FIND;

	[AccessedThroughProperty("DateTime2_FIND")]
	private DateTimePicker _DateTime2_FIND;

	[AccessedThroughProperty("Panel112233")]
	private Panel _Panel112233;

	[AccessedThroughProperty("Button_CALC_BD")]
	private Button _Button_CALC_BD;

	[AccessedThroughProperty("Label4141")]
	private Label _Label4141;

	[AccessedThroughProperty("Label28")]
	private Label _Label28;

	[AccessedThroughProperty("Label27")]
	private Label _Label27;

	[AccessedThroughProperty("Label_TOTAL_LIGNES_BD")]
	private Label _Label_TOTAL_LIGNES_BD;

	[AccessedThroughProperty("Button4")]
	private Button _Button4;

	[AccessedThroughProperty("DataGridViewImageColumn1")]
	private DataGridViewImageColumn _DataGridViewImageColumn1;

	[AccessedThroughProperty("DataGridViewImageColumn2")]
	private DataGridViewImageColumn _DataGridViewImageColumn2;

	[AccessedThroughProperty("Tickett")]
	private DataGridViewTextBoxColumn _Tickett;

	[AccessedThroughProperty("DATESs")]
	private DataGridViewTextBoxColumn _DATESs;

	[AccessedThroughProperty("Heuree")]
	private DataGridViewTextBoxColumn _Heuree;

	[AccessedThroughProperty("Articlee")]
	private DataGridViewTextBoxColumn _Articlee;

	[AccessedThroughProperty("PRIX_Vv")]
	private DataGridViewTextBoxColumn _PRIX_Vv;

	[AccessedThroughProperty("Qtéé")]
	private DataGridViewTextBoxColumn _Qtéé;

	[AccessedThroughProperty("Remisee")]
	private DataGridViewTextBoxColumn _Remisee;

	[AccessedThroughProperty("TOTAL_NETt")]
	private DataGridViewTextBoxColumn _TOTAL_NETt;

	[AccessedThroughProperty("OPERATIONn")]
	private DataGridViewTextBoxColumn _OPERATIONn;

	[AccessedThroughProperty("Button_CLAVIER")]
	private Button_CLAVIER_NOSELECT _Button_CLAVIER;

	[AccessedThroughProperty("Label14")]
	private Label _Label14;

	[AccessedThroughProperty("Label12")]
	private Label _Label12;

	[AccessedThroughProperty("Label11")]
	private Label _Label11;

	[AccessedThroughProperty("Label36")]
	private Label _Label36;

	[AccessedThroughProperty("Label19")]
	private Label _Label19;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("Label24")]
	private Label _Label24;

	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	[AccessedThroughProperty("Label10")]
	private Label _Label10;

	[AccessedThroughProperty("Label9")]
	private Label _Label9;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("DATES")]
	private DataGridViewTextBoxColumn _DATES;

	[AccessedThroughProperty("ID_Client")]
	private DataGridViewTextBoxColumn _ID_Client;

	[AccessedThroughProperty("CODE_CLIENT")]
	private DataGridViewTextBoxColumn _CODE_CLIENT;

	[AccessedThroughProperty("Client")]
	private DataGridViewTextBoxColumn _Client;

	[AccessedThroughProperty("TELEPHONE")]
	private DataGridViewTextBoxColumn _TELEPHONE;

	[AccessedThroughProperty("Notess")]
	private DataGridViewTextBoxColumn _Notess;

	[AccessedThroughProperty("ETAT")]
	private DataGridViewTextBoxColumn _ETAT;

	[AccessedThroughProperty("supp")]
	private DataGridViewImageColumn _supp;

	[AccessedThroughProperty("modi")]
	private DataGridViewImageColumn _modi;

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
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected Obj, but got Unknown
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Expected Obj, but got Unknown
			EventHandler eventHandler = DataGridView1_DoubleClick;
			DataGridViewCellEventHandler val = DataGridView1_CellClick;
			DataGridViewCellEventHandler val2 = DataGridView1_CellContentClick;
			DataGridViewCellEventHandler val3 = DataGridView1_CellEnter;
			if (_DataGridView1 != null)
			{
				((Control)_DataGridView1).DoubleClick -= eventHandler;
				_DataGridView1.CellClick -= val;
				_DataGridView1.CellContentClick -= val2;
				_DataGridView1.CellEnter -= val3;
			}
			_DataGridView1 = value;
			if (_DataGridView1 != null)
			{
				((Control)_DataGridView1).DoubleClick += eventHandler;
				_DataGridView1.CellClick += val;
				_DataGridView1.CellContentClick += val2;
				_DataGridView1.CellEnter += val3;
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
			EventHandler eventHandler = Button19_Click;
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

	internal virtual TextBox Text_ICE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_ICE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_ICE = value;
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
			EventHandler eventHandler = TextBox6_TextChanged;
			if (_Text_NOTE != null)
			{
				((Control)_Text_NOTE).KeyPress -= val;
				((Control)_Text_NOTE).TextChanged -= eventHandler;
			}
			_Text_NOTE = value;
			if (_Text_NOTE != null)
			{
				((Control)_Text_NOTE).KeyPress += val;
				((Control)_Text_NOTE).TextChanged += eventHandler;
			}
		}
	}

	internal virtual TextBox Text_TEL
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_TEL;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_TEL = value;
		}
	}

	internal virtual TextBox Text_VILLE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_VILLE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			EventHandler eventHandler = TextBox8_TextChanged;
			KeyPressEventHandler val = TextBox8_KeyPress;
			if (_Text_VILLE != null)
			{
				((Control)_Text_VILLE).TextChanged -= eventHandler;
				((Control)_Text_VILLE).KeyPress -= val;
			}
			_Text_VILLE = value;
			if (_Text_VILLE != null)
			{
				((Control)_Text_VILLE).TextChanged += eventHandler;
				((Control)_Text_VILLE).KeyPress += val;
			}
		}
	}

	internal virtual TextBox Text_ADRESSE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_ADRESSE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			EventHandler eventHandler = TextBox5_TextChanged;
			KeyPressEventHandler val = TextBox5_KeyPress;
			if (_Text_ADRESSE != null)
			{
				((Control)_Text_ADRESSE).TextChanged -= eventHandler;
				((Control)_Text_ADRESSE).KeyPress -= val;
			}
			_Text_ADRESSE = value;
			if (_Text_ADRESSE != null)
			{
				((Control)_Text_ADRESSE).TextChanged += eventHandler;
				((Control)_Text_ADRESSE).KeyPress += val;
			}
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
			EventHandler eventHandler = TextBox2_TextChanged;
			if (_Text_CLIENT != null)
			{
				((Control)_Text_CLIENT).KeyPress -= val;
				((Control)_Text_CLIENT).TextChanged -= eventHandler;
			}
			_Text_CLIENT = value;
			if (_Text_CLIENT != null)
			{
				((Control)_Text_CLIENT).KeyPress += val;
				((Control)_Text_CLIENT).TextChanged += eventHandler;
			}
		}
	}

	internal virtual TextBox Text_CODE_CLIENT
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_CODE_CLIENT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_CODE_CLIENT = value;
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

	internal virtual DateTimePicker DateTimePicker3
	{
		[DebuggerNonUserCode]
		get
		{
			return _DateTimePicker3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DateTimePicker3 = value;
		}
	}

	internal virtual DateTimePicker DateTimePicker4
	{
		[DebuggerNonUserCode]
		get
		{
			return _DateTimePicker4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DateTimePicker4 = value;
		}
	}

	internal virtual DataGridView DataGridView_REGLEMENTS
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridView_REGLEMENTS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGridView_REGLEMENTS = value;
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

	internal virtual Label Label_REGLE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_REGLE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_REGLE = value;
		}
	}

	internal virtual Label Label_CREDIT
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_CREDIT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_CREDIT = value;
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

	internal virtual Label Label_BALANCE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_BALANCE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_BALANCE = value;
		}
	}

	internal virtual TextBox Text_ETAT
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_ETAT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_ETAT = value;
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

	internal virtual DateTimePicker DateTimePicker5
	{
		[DebuggerNonUserCode]
		get
		{
			return _DateTimePicker5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DateTimePicker5 = value;
		}
	}

	internal virtual DateTimePicker DateTimePicker6
	{
		[DebuggerNonUserCode]
		get
		{
			return _DateTimePicker6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DateTimePicker6 = value;
		}
	}

	internal virtual DataGridView DataGridView_DETAILS_VENTES
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridView_DETAILS_VENTES;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGridView_DETAILS_VENTES = value;
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

	internal virtual Panel Panel_HISTORIQUE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel_HISTORIQUE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel_HISTORIQUE = value;
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

	internal virtual Label Label_HISTORIQUE_CLIENT
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_HISTORIQUE_CLIENT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_HISTORIQUE_CLIENT = value;
		}
	}

	internal virtual TabControl TabControl2
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabControl2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabControl2 = value;
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

	internal virtual Button Button16
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button16;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button16_Click;
			if (_Button16 != null)
			{
				((Control)_Button16).Click -= eventHandler;
			}
			_Button16 = value;
			if (_Button16 != null)
			{
				((Control)_Button16).Click += eventHandler;
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

	internal virtual Label Label_HISTORIQUE_ID_CLIENT
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_HISTORIQUE_ID_CLIENT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_HISTORIQUE_ID_CLIENT = value;
		}
	}

	internal virtual Button Button_PrintRapport_2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_PrintRapport_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_PrintRapport_2_Click;
			if (_Button_PrintRapport_2 != null)
			{
				((Control)_Button_PrintRapport_2).Click -= eventHandler;
			}
			_Button_PrintRapport_2 = value;
			if (_Button_PrintRapport_2 != null)
			{
				((Control)_Button_PrintRapport_2).Click += eventHandler;
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

	internal virtual Label Label_REGLE_CLIENT
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_REGLE_CLIENT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_REGLE_CLIENT = value;
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

	internal virtual Label Label_RETOUR_CREDIT
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_RETOUR_CREDIT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_RETOUR_CREDIT = value;
		}
	}

	internal virtual Label Label_VENTE_CREDIT
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_VENTE_CREDIT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_VENTE_CREDIT = value;
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

	internal virtual Label Label_CREDIT_INITIAL
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_CREDIT_INITIAL;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_CREDIT_INITIAL = value;
		}
	}

	internal virtual TextBox Text_CREDIT_INITIAL
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_CREDIT_INITIAL;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			EventHandler eventHandler = Text_CREDIT_INITIAL_TextChanged;
			KeyPressEventHandler val = Text_SOLDE_INITIAL_KeyPress;
			if (_Text_CREDIT_INITIAL != null)
			{
				((Control)_Text_CREDIT_INITIAL).TextChanged -= eventHandler;
				((Control)_Text_CREDIT_INITIAL).KeyPress -= val;
			}
			_Text_CREDIT_INITIAL = value;
			if (_Text_CREDIT_INITIAL != null)
			{
				((Control)_Text_CREDIT_INITIAL).TextChanged += eventHandler;
				((Control)_Text_CREDIT_INITIAL).KeyPress += val;
			}
		}
	}

	internal virtual DataGridView DataGridView_VENTES
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridView_VENTES;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGridView_VENTES = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn ID_REGLE
	{
		[DebuggerNonUserCode]
		get
		{
			return _ID_REGLE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ID_REGLE = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn DATES_REGLEMENT
	{
		[DebuggerNonUserCode]
		get
		{
			return _DATES_REGLEMENT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DATES_REGLEMENT = value;
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

	internal virtual DataGridViewTextBoxColumn TICKET
	{
		[DebuggerNonUserCode]
		get
		{
			return _TICKET;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TICKET = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn DATES_CREDIT
	{
		[DebuggerNonUserCode]
		get
		{
			return _DATES_CREDIT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DATES_CREDIT = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn TOTAL_NET
	{
		[DebuggerNonUserCode]
		get
		{
			return _TOTAL_NET;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TOTAL_NET = value;
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

	internal virtual TextBox Text_ID_CLIENT
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_ID_CLIENT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_ID_CLIENT = value;
		}
	}

	internal virtual ComboBox Combo_VENDEUR
	{
		[DebuggerNonUserCode]
		get
		{
			return _Combo_VENDEUR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Combo_VENDEUR = value;
		}
	}

	internal virtual Button Button_CREDIT_INITIAL_MODIF
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_CREDIT_INITIAL_MODIF;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_CREDIT_INITIAL_MODIF_Click;
			if (_Button_CREDIT_INITIAL_MODIF != null)
			{
				((Control)_Button_CREDIT_INITIAL_MODIF).Click -= eventHandler;
			}
			_Button_CREDIT_INITIAL_MODIF = value;
			if (_Button_CREDIT_INITIAL_MODIF != null)
			{
				((Control)_Button_CREDIT_INITIAL_MODIF).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button_FONCTIONS
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_FONCTIONS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_FONCTIONS_Click;
			if (_Button_FONCTIONS != null)
			{
				((Control)_Button_FONCTIONS).Click -= eventHandler;
			}
			_Button_FONCTIONS = value;
			if (_Button_FONCTIONS != null)
			{
				((Control)_Button_FONCTIONS).Click += eventHandler;
			}
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
			_Panel_FONCTIONS = value;
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

	internal virtual Button Button_PDF
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_PDF;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_PDF_Click;
			if (_Button_PDF != null)
			{
				((Control)_Button_PDF).Click -= eventHandler;
			}
			_Button_PDF = value;
			if (_Button_PDF != null)
			{
				((Control)_Button_PDF).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button_EXCEL
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_EXCEL;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Button_EXCEL = value;
		}
	}

	internal virtual Button Button_WORD
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_WORD;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Button_WORD = value;
		}
	}

	internal virtual TextBox Text_PAYS
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_PAYS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_PAYS = value;
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

	internal virtual Label Label26
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label26;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label26 = value;
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

	internal virtual Panel Panel112233
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel112233;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel112233 = value;
		}
	}

	internal virtual Button Button_CALC_BD
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_CALC_BD;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_CALC_BD_Click;
			if (_Button_CALC_BD != null)
			{
				((Control)_Button_CALC_BD).Click -= eventHandler;
			}
			_Button_CALC_BD = value;
			if (_Button_CALC_BD != null)
			{
				((Control)_Button_CALC_BD).Click += eventHandler;
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

	internal virtual Label Label_TOTAL_LIGNES_BD
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_TOTAL_LIGNES_BD;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_TOTAL_LIGNES_BD = value;
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

	internal virtual DataGridViewTextBoxColumn Tickett
	{
		[DebuggerNonUserCode]
		get
		{
			return _Tickett;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Tickett = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn DATESs
	{
		[DebuggerNonUserCode]
		get
		{
			return _DATESs;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DATESs = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Heuree
	{
		[DebuggerNonUserCode]
		get
		{
			return _Heuree;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Heuree = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Articlee
	{
		[DebuggerNonUserCode]
		get
		{
			return _Articlee;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Articlee = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn PRIX_Vv
	{
		[DebuggerNonUserCode]
		get
		{
			return _PRIX_Vv;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PRIX_Vv = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Qtéé
	{
		[DebuggerNonUserCode]
		get
		{
			return _Qtéé;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Qtéé = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Remisee
	{
		[DebuggerNonUserCode]
		get
		{
			return _Remisee;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Remisee = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn TOTAL_NETt
	{
		[DebuggerNonUserCode]
		get
		{
			return _TOTAL_NETt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TOTAL_NETt = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn OPERATIONn
	{
		[DebuggerNonUserCode]
		get
		{
			return _OPERATIONn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_OPERATIONn = value;
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

	internal virtual DataGridViewTextBoxColumn ID_Client
	{
		[DebuggerNonUserCode]
		get
		{
			return _ID_Client;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ID_Client = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn CODE_CLIENT
	{
		[DebuggerNonUserCode]
		get
		{
			return _CODE_CLIENT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CODE_CLIENT = value;
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

	internal virtual DataGridViewTextBoxColumn Notess
	{
		[DebuggerNonUserCode]
		get
		{
			return _Notess;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Notess = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn ETAT
	{
		[DebuggerNonUserCode]
		get
		{
			return _ETAT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ETAT = value;
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

	public Form_5_CLIENTS()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected Obj, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected Obj, but got Unknown
		((Control)this).KeyDown += me_KeyDown;
		((Form)this).Load += FormDialog_famille_Load;
		((Form)this).FormClosed += Form_5_CLIENTS_FormClosed;
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
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected Obj, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected Obj, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected Obj, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected Obj, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected Obj, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected Obj, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected Obj, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected Obj, but got Unknown
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected Obj, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected Obj, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected Obj, but got Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected Obj, but got Unknown
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected Obj, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected Obj, but got Unknown
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected Obj, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected Obj, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected Obj, but got Unknown
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected Obj, but got Unknown
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected Obj, but got Unknown
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected Obj, but got Unknown
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected Obj, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected Obj, but got Unknown
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected Obj, but got Unknown
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Expected Obj, but got Unknown
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected Obj, but got Unknown
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Expected Obj, but got Unknown
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected Obj, but got Unknown
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected Obj, but got Unknown
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Expected Obj, but got Unknown
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected Obj, but got Unknown
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Expected Obj, but got Unknown
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Expected Obj, but got Unknown
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected Obj, but got Unknown
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected Obj, but got Unknown
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Expected Obj, but got Unknown
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Expected Obj, but got Unknown
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Expected Obj, but got Unknown
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected Obj, but got Unknown
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Expected Obj, but got Unknown
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Expected Obj, but got Unknown
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Expected Obj, but got Unknown
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Expected Obj, but got Unknown
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Expected Obj, but got Unknown
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Expected Obj, but got Unknown
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Expected Obj, but got Unknown
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Expected Obj, but got Unknown
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Expected Obj, but got Unknown
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Expected Obj, but got Unknown
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Expected Obj, but got Unknown
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Expected Obj, but got Unknown
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Expected Obj, but got Unknown
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Expected Obj, but got Unknown
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Expected Obj, but got Unknown
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Expected Obj, but got Unknown
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Expected Obj, but got Unknown
		//IL_02ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b6: Expected Obj, but got Unknown
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Expected Obj, but got Unknown
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Expected Obj, but got Unknown
		//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02da: Expected Obj, but got Unknown
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e6: Expected Obj, but got Unknown
		//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f2: Expected Obj, but got Unknown
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Expected Obj, but got Unknown
		//IL_0300: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Expected Obj, but got Unknown
		//IL_030c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0316: Expected Obj, but got Unknown
		//IL_0318: Unknown result type (might be due to invalid IL or missing references)
		//IL_0322: Expected Obj, but got Unknown
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_032e: Expected Obj, but got Unknown
		//IL_0330: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Expected Obj, but got Unknown
		//IL_033c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0346: Expected Obj, but got Unknown
		//IL_0348: Unknown result type (might be due to invalid IL or missing references)
		//IL_0352: Expected Obj, but got Unknown
		//IL_0354: Unknown result type (might be due to invalid IL or missing references)
		//IL_035e: Expected Obj, but got Unknown
		//IL_0360: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Expected Obj, but got Unknown
		//IL_036c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0376: Expected Obj, but got Unknown
		//IL_0378: Unknown result type (might be due to invalid IL or missing references)
		//IL_0382: Expected Obj, but got Unknown
		//IL_0384: Unknown result type (might be due to invalid IL or missing references)
		//IL_038e: Expected Obj, but got Unknown
		//IL_0390: Unknown result type (might be due to invalid IL or missing references)
		//IL_039a: Expected Obj, but got Unknown
		//IL_039c: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a6: Expected Obj, but got Unknown
		//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b2: Expected Obj, but got Unknown
		//IL_03b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03be: Expected Obj, but got Unknown
		//IL_03c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ca: Expected Obj, but got Unknown
		//IL_03cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d6: Expected Obj, but got Unknown
		//IL_03d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e2: Expected Obj, but got Unknown
		//IL_03e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ee: Expected Obj, but got Unknown
		//IL_03f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fa: Expected Obj, but got Unknown
		//IL_03fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0406: Expected Obj, but got Unknown
		//IL_0408: Unknown result type (might be due to invalid IL or missing references)
		//IL_0412: Expected Obj, but got Unknown
		//IL_0414: Unknown result type (might be due to invalid IL or missing references)
		//IL_041e: Expected Obj, but got Unknown
		//IL_0420: Unknown result type (might be due to invalid IL or missing references)
		//IL_042a: Expected Obj, but got Unknown
		//IL_042c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0436: Expected Obj, but got Unknown
		//IL_0438: Unknown result type (might be due to invalid IL or missing references)
		//IL_0442: Expected Obj, but got Unknown
		//IL_0444: Unknown result type (might be due to invalid IL or missing references)
		//IL_044e: Expected Obj, but got Unknown
		//IL_0450: Unknown result type (might be due to invalid IL or missing references)
		//IL_045a: Expected Obj, but got Unknown
		//IL_045c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0466: Expected Obj, but got Unknown
		//IL_0468: Unknown result type (might be due to invalid IL or missing references)
		//IL_0472: Expected Obj, but got Unknown
		//IL_0474: Unknown result type (might be due to invalid IL or missing references)
		//IL_047e: Expected Obj, but got Unknown
		//IL_0480: Unknown result type (might be due to invalid IL or missing references)
		//IL_048a: Expected Obj, but got Unknown
		//IL_048c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0496: Expected Obj, but got Unknown
		//IL_0498: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a2: Expected Obj, but got Unknown
		//IL_04a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ae: Expected Obj, but got Unknown
		//IL_04b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ba: Expected Obj, but got Unknown
		//IL_04bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c6: Expected Obj, but got Unknown
		//IL_04c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d2: Expected Obj, but got Unknown
		//IL_04d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04de: Expected Obj, but got Unknown
		//IL_04e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ea: Expected Obj, but got Unknown
		//IL_04ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f6: Expected Obj, but got Unknown
		//IL_04f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0502: Expected Obj, but got Unknown
		//IL_0504: Unknown result type (might be due to invalid IL or missing references)
		//IL_050e: Expected Obj, but got Unknown
		//IL_0510: Unknown result type (might be due to invalid IL or missing references)
		//IL_051a: Expected Obj, but got Unknown
		//IL_051c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0526: Expected Obj, but got Unknown
		//IL_0528: Unknown result type (might be due to invalid IL or missing references)
		//IL_0532: Expected Obj, but got Unknown
		//IL_0534: Unknown result type (might be due to invalid IL or missing references)
		//IL_053e: Expected Obj, but got Unknown
		//IL_0540: Unknown result type (might be due to invalid IL or missing references)
		//IL_054a: Expected Obj, but got Unknown
		//IL_054c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0556: Expected Obj, but got Unknown
		//IL_0558: Unknown result type (might be due to invalid IL or missing references)
		//IL_0562: Expected Obj, but got Unknown
		//IL_0564: Unknown result type (might be due to invalid IL or missing references)
		//IL_056e: Expected Obj, but got Unknown
		//IL_0570: Unknown result type (might be due to invalid IL or missing references)
		//IL_057a: Expected Obj, but got Unknown
		//IL_057c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0586: Expected Obj, but got Unknown
		//IL_0588: Unknown result type (might be due to invalid IL or missing references)
		//IL_0592: Expected Obj, but got Unknown
		//IL_05a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05aa: Expected Obj, but got Unknown
		//IL_05ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b6: Expected Obj, but got Unknown
		//IL_05b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c2: Expected Obj, but got Unknown
		//IL_05c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ce: Expected Obj, but got Unknown
		//IL_05e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f2: Expected Obj, but got Unknown
		//IL_05f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fe: Expected Obj, but got Unknown
		//IL_0600: Unknown result type (might be due to invalid IL or missing references)
		//IL_060a: Expected Obj, but got Unknown
		//IL_060c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0616: Expected Obj, but got Unknown
		//IL_0618: Unknown result type (might be due to invalid IL or missing references)
		//IL_0622: Expected Obj, but got Unknown
		//IL_0624: Unknown result type (might be due to invalid IL or missing references)
		//IL_062e: Expected Obj, but got Unknown
		//IL_0630: Unknown result type (might be due to invalid IL or missing references)
		//IL_063a: Expected Obj, but got Unknown
		//IL_063c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0646: Expected Obj, but got Unknown
		//IL_0648: Unknown result type (might be due to invalid IL or missing references)
		//IL_0652: Expected Obj, but got Unknown
		//IL_0654: Unknown result type (might be due to invalid IL or missing references)
		//IL_065e: Expected Obj, but got Unknown
		//IL_0660: Unknown result type (might be due to invalid IL or missing references)
		//IL_066a: Expected Obj, but got Unknown
		//IL_066c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0676: Expected Obj, but got Unknown
		//IL_0678: Unknown result type (might be due to invalid IL or missing references)
		//IL_0682: Expected Obj, but got Unknown
		//IL_0684: Unknown result type (might be due to invalid IL or missing references)
		//IL_068e: Expected Obj, but got Unknown
		//IL_0690: Unknown result type (might be due to invalid IL or missing references)
		//IL_069a: Expected Obj, but got Unknown
		//IL_069c: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a6: Expected Obj, but got Unknown
		//IL_06a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b2: Expected Obj, but got Unknown
		//IL_06b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06be: Expected Obj, but got Unknown
		//IL_06c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ca: Expected Obj, but got Unknown
		//IL_06cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d6: Expected Obj, but got Unknown
		//IL_1e7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e84: Expected Obj, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form_5_CLIENTS));
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		DataGridViewCellStyle val3 = new DataGridViewCellStyle();
		Panel_INFO = new Panel();
		Button_CLAVIER = new Button_CLAVIER_NOSELECT();
		Label_BOTTOM = new Label();
		Label_LEFT = new Label();
		Label_RIGHT = new Label();
		Label_INDEX = new Label();
		Label_TOP = new Label();
		Button_CLOSE = new Button();
		Button_SAVE = new Button();
		TabControl1 = new TabControl();
		TabPage1 = new TabPage();
		Label14 = new Label();
		Label12 = new Label();
		Label11 = new Label();
		Label36 = new Label();
		Label19 = new Label();
		Label3 = new Label();
		Label7 = new Label();
		Label24 = new Label();
		Label8 = new Label();
		Label10 = new Label();
		Label9 = new Label();
		Label4 = new Label();
		Label2 = new Label();
		Text_PAYS = new TextBox();
		Button_CREDIT_INITIAL_MODIF = new Button();
		Combo_VENDEUR = new ComboBox();
		Text_ID_CLIENT = new TextBox();
		Text_CREDIT_INITIAL = new TextBox();
		Text_ETAT = new TextBox();
		Text_ICE = new TextBox();
		Text_ID = new TextBox();
		Text_NOTE = new TextBox();
		Text_TEL = new TextBox();
		Text_VILLE = new TextBox();
		Text_ADRESSE = new TextBox();
		Text_CLIENT = new TextBox();
		Text_CODE_CLIENT = new TextBox();
		DateTimePicker_DATE = new DateTimePicker();
		Label23 = new Label();
		Label21 = new Label();
		Label_BALANCE = new Label();
		Label17 = new Label();
		Label_REGLE = new Label();
		Label_CREDIT = new Label();
		DataGridView_REGLEMENTS = new DataGridView();
		ID_REGLE = new DataGridViewTextBoxColumn();
		DATES_REGLEMENT = new DataGridViewTextBoxColumn();
		MONTANT = new DataGridViewTextBoxColumn();
		NOTES = new DataGridViewTextBoxColumn();
		Label15 = new Label();
		DateTimePicker3 = new DateTimePicker();
		DateTimePicker4 = new DateTimePicker();
		DateTimePicker5 = new DateTimePicker();
		DateTimePicker6 = new DateTimePicker();
		DataGridView_DETAILS_VENTES = new DataGridView();
		Tickett = new DataGridViewTextBoxColumn();
		DATESs = new DataGridViewTextBoxColumn();
		Heuree = new DataGridViewTextBoxColumn();
		Articlee = new DataGridViewTextBoxColumn();
		PRIX_Vv = new DataGridViewTextBoxColumn();
		Qtéé = new DataGridViewTextBoxColumn();
		Remisee = new DataGridViewTextBoxColumn();
		TOTAL_NETt = new DataGridViewTextBoxColumn();
		OPERATIONn = new DataGridViewTextBoxColumn();
		DataGridView1 = new DataGridView();
		DATES = new DataGridViewTextBoxColumn();
		ID_Client = new DataGridViewTextBoxColumn();
		CODE_CLIENT = new DataGridViewTextBoxColumn();
		Client = new DataGridViewTextBoxColumn();
		TELEPHONE = new DataGridViewTextBoxColumn();
		Notess = new DataGridViewTextBoxColumn();
		ETAT = new DataGridViewTextBoxColumn();
		supp = new DataGridViewImageColumn();
		modi = new DataGridViewImageColumn();
		Label_TABLE = new Label();
		Panel_HISTORIQUE = new Panel();
		Label_HISTORIQUE_ID_CLIENT = new Label();
		TabControl2 = new TabControl();
		TabPage5 = new TabPage();
		DataGridView_VENTES = new DataGridView();
		ID_TICKET = new DataGridViewTextBoxColumn();
		TICKET = new DataGridViewTextBoxColumn();
		DATES_CREDIT = new DataGridViewTextBoxColumn();
		TOTAL_NET = new DataGridViewTextBoxColumn();
		OPERATION = new DataGridViewTextBoxColumn();
		Label22 = new Label();
		Label_CREDIT_INITIAL = new Label();
		Label_REGLE_CLIENT = new Label();
		Label13 = new Label();
		Label_RETOUR_CREDIT = new Label();
		Label_VENTE_CREDIT = new Label();
		Button_PrintRapport_2 = new Button();
		Label16 = new Label();
		Label18 = new Label();
		PictureBox3 = new PictureBox();
		Button16 = new Button();
		Label30 = new Label();
		Label29 = new Label();
		PictureBox1 = new PictureBox();
		TabPage6 = new TabPage();
		Button4 = new Button();
		PictureBox4 = new PictureBox();
		Button2 = new Button();
		Button3 = new Button();
		Label1 = new Label();
		Label5 = new Label();
		Label6 = new Label();
		Label_HISTORIQUE_CLIENT = new Label();
		Panel_FIND = new Panel();
		Panel_DATES = new Panel();
		DateTime2_FIND = new DateTimePicker();
		DateTime1_FIND = new DateTimePicker();
		Picture_FIND_DATES = new PictureBox();
		PictureBox2 = new PictureBox();
		Combo_FIND = new BunifuDropdown();
		Picture_EXPORT = new Button_RJ();
		Label26 = new Label();
		Label20 = new Label();
		Check_FIND_DATE = new BunifuCheckBox();
		Check_FIND_EXACTE = new BunifuCheckBox();
		Picture_REFRESH = new Button_RJ();
		Picture_FIND = new Button_RJ();
		Text_FIND = new RJTextBox();
		Panel_FONCTIONS = new Panel();
		Label41 = new Label();
		Label44 = new Label();
		Label43 = new Label();
		Label42 = new Label();
		Button_PDF = new Button();
		Button_EXCEL = new Button();
		Button_WORD = new Button();
		Panel112233 = new Panel();
		Label_TOTAL_LIGNES_BD = new Label();
		Button_CALC_BD = new Button();
		Label4141 = new Label();
		Label28 = new Label();
		Label27 = new Label();
		DataGridViewImageColumn1 = new DataGridViewImageColumn();
		DataGridViewImageColumn2 = new DataGridViewImageColumn();
		Button_FONCTIONS = new Button();
		Button1 = new Button();
		Button_ADD = new Button();
		((Control)Panel_INFO).SuspendLayout();
		((Control)TabControl1).SuspendLayout();
		((Control)TabPage1).SuspendLayout();
		((ISupportInitialize)DataGridView_REGLEMENTS).BeginInit();
		((ISupportInitialize)DataGridView_DETAILS_VENTES).BeginInit();
		((ISupportInitialize)DataGridView1).BeginInit();
		((Control)Panel_HISTORIQUE).SuspendLayout();
		((Control)TabControl2).SuspendLayout();
		((Control)TabPage5).SuspendLayout();
		((ISupportInitialize)DataGridView_VENTES).BeginInit();
		((ISupportInitialize)PictureBox3).BeginInit();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)TabPage6).SuspendLayout();
		((ISupportInitialize)PictureBox4).BeginInit();
		((Control)Panel_FIND).SuspendLayout();
		((Control)Panel_DATES).SuspendLayout();
		((ISupportInitialize)Picture_FIND_DATES).BeginInit();
		((ISupportInitialize)PictureBox2).BeginInit();
		((Control)Panel_FONCTIONS).SuspendLayout();
		((Control)Panel112233).SuspendLayout();
		((Control)this).SuspendLayout();
		componentResourceManager.ApplyResources(Panel_INFO, "Panel_INFO");
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
		((Control)Panel_INFO).Name = "Panel_INFO";
		componentResourceManager.ApplyResources(Button_CLAVIER, "Button_CLAVIER");
		((Control)Button_CLAVIER).Name = "Button_CLAVIER";
		((ButtonBase)Button_CLAVIER).UseVisualStyleBackColor = true;
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
		componentResourceManager.ApplyResources(Label_INDEX, "Label_INDEX");
		((Control)Label_INDEX).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label_INDEX).Cursor = Cursors.Hand;
		((Control)Label_INDEX).ForeColor = Color.White;
		((Control)Label_INDEX).Name = "Label_INDEX";
		((Control)Label_TOP).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label_TOP).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Label_TOP, "Label_TOP");
		((Control)Label_TOP).ForeColor = Color.White;
		((Control)Label_TOP).Name = "Label_TOP";
		((ButtonBase)Button_CLOSE).BackColor = Color.Red;
		((Control)Button_CLOSE).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Button_CLOSE, "Button_CLOSE");
		((Control)Button_CLOSE).ForeColor = Color.White;
		((Control)Button_CLOSE).Name = "Button_CLOSE";
		((ButtonBase)Button_CLOSE).UseVisualStyleBackColor = false;
		((ButtonBase)Button_SAVE).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Button_SAVE).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Button_SAVE, "Button_SAVE");
		((Control)Button_SAVE).ForeColor = Color.White;
		((Control)Button_SAVE).Name = "Button_SAVE";
		((ButtonBase)Button_SAVE).UseVisualStyleBackColor = false;
		((Control)TabControl1).Controls.Add((Control)(object)TabPage1);
		componentResourceManager.ApplyResources(TabControl1, "TabControl1");
		((Control)TabControl1).Name = "TabControl1";
		TabControl1.SelectedIndex = 0;
		TabPage1.BackColor = Color.White;
		((Control)TabPage1).Controls.Add((Control)(object)Label14);
		((Control)TabPage1).Controls.Add((Control)(object)Label12);
		((Control)TabPage1).Controls.Add((Control)(object)Label11);
		((Control)TabPage1).Controls.Add((Control)(object)Label36);
		((Control)TabPage1).Controls.Add((Control)(object)Label19);
		((Control)TabPage1).Controls.Add((Control)(object)Label3);
		((Control)TabPage1).Controls.Add((Control)(object)Label7);
		((Control)TabPage1).Controls.Add((Control)(object)Label24);
		((Control)TabPage1).Controls.Add((Control)(object)Label8);
		((Control)TabPage1).Controls.Add((Control)(object)Label10);
		((Control)TabPage1).Controls.Add((Control)(object)Label9);
		((Control)TabPage1).Controls.Add((Control)(object)Label4);
		((Control)TabPage1).Controls.Add((Control)(object)Label2);
		((Control)TabPage1).Controls.Add((Control)(object)Text_PAYS);
		((Control)TabPage1).Controls.Add((Control)(object)Button_CREDIT_INITIAL_MODIF);
		((Control)TabPage1).Controls.Add((Control)(object)Combo_VENDEUR);
		((Control)TabPage1).Controls.Add((Control)(object)Text_ID_CLIENT);
		((Control)TabPage1).Controls.Add((Control)(object)Text_CREDIT_INITIAL);
		((Control)TabPage1).Controls.Add((Control)(object)Text_ETAT);
		((Control)TabPage1).Controls.Add((Control)(object)Text_ICE);
		((Control)TabPage1).Controls.Add((Control)(object)Text_ID);
		((Control)TabPage1).Controls.Add((Control)(object)Text_NOTE);
		((Control)TabPage1).Controls.Add((Control)(object)Text_TEL);
		((Control)TabPage1).Controls.Add((Control)(object)Text_VILLE);
		((Control)TabPage1).Controls.Add((Control)(object)Text_ADRESSE);
		((Control)TabPage1).Controls.Add((Control)(object)Text_CLIENT);
		((Control)TabPage1).Controls.Add((Control)(object)Text_CODE_CLIENT);
		((Control)TabPage1).Controls.Add((Control)(object)DateTimePicker_DATE);
		((Control)TabPage1).ForeColor = Color.Black;
		componentResourceManager.ApplyResources(TabPage1, "TabPage1");
		((Control)TabPage1).Name = "TabPage1";
		((Control)Label14).BackColor = SystemColors.Control;
		componentResourceManager.ApplyResources(Label14, "Label14");
		((Control)Label14).ForeColor = Color.Black;
		((Control)Label14).Name = "Label14";
		((Control)Label12).BackColor = SystemColors.Control;
		componentResourceManager.ApplyResources(Label12, "Label12");
		((Control)Label12).ForeColor = Color.Black;
		((Control)Label12).Name = "Label12";
		((Control)Label11).BackColor = SystemColors.Control;
		componentResourceManager.ApplyResources(Label11, "Label11");
		((Control)Label11).ForeColor = Color.Black;
		((Control)Label11).Name = "Label11";
		((Control)Label36).BackColor = SystemColors.Control;
		componentResourceManager.ApplyResources(Label36, "Label36");
		((Control)Label36).ForeColor = Color.Black;
		((Control)Label36).Name = "Label36";
		((Control)Label19).BackColor = SystemColors.Control;
		componentResourceManager.ApplyResources(Label19, "Label19");
		((Control)Label19).ForeColor = Color.Black;
		((Control)Label19).Name = "Label19";
		((Control)Label3).BackColor = SystemColors.Control;
		componentResourceManager.ApplyResources(Label3, "Label3");
		((Control)Label3).ForeColor = Color.Black;
		((Control)Label3).Name = "Label3";
		((Control)Label7).BackColor = SystemColors.Control;
		componentResourceManager.ApplyResources(Label7, "Label7");
		((Control)Label7).ForeColor = Color.Black;
		((Control)Label7).Name = "Label7";
		((Control)Label24).BackColor = SystemColors.Control;
		componentResourceManager.ApplyResources(Label24, "Label24");
		((Control)Label24).ForeColor = Color.Black;
		((Control)Label24).Name = "Label24";
		((Control)Label8).BackColor = SystemColors.Control;
		componentResourceManager.ApplyResources(Label8, "Label8");
		((Control)Label8).ForeColor = Color.Black;
		((Control)Label8).Name = "Label8";
		((Control)Label10).BackColor = SystemColors.Control;
		componentResourceManager.ApplyResources(Label10, "Label10");
		((Control)Label10).ForeColor = Color.Black;
		((Control)Label10).Name = "Label10";
		((Control)Label9).BackColor = SystemColors.Control;
		componentResourceManager.ApplyResources(Label9, "Label9");
		((Control)Label9).ForeColor = Color.Black;
		((Control)Label9).Name = "Label9";
		((Control)Label4).BackColor = SystemColors.Control;
		componentResourceManager.ApplyResources(Label4, "Label4");
		((Control)Label4).ForeColor = Color.Black;
		((Control)Label4).Name = "Label4";
		((Control)Label2).BackColor = SystemColors.Control;
		componentResourceManager.ApplyResources(Label2, "Label2");
		((Control)Label2).ForeColor = Color.Black;
		((Control)Label2).Name = "Label2";
		componentResourceManager.ApplyResources(Text_PAYS, "Text_PAYS");
		((Control)Text_PAYS).Name = "Text_PAYS";
		((ButtonBase)Button_CREDIT_INITIAL_MODIF).Image = (Image)(object)Resources.Picture_MODIF_Image;
		componentResourceManager.ApplyResources(Button_CREDIT_INITIAL_MODIF, "Button_CREDIT_INITIAL_MODIF");
		((Control)Button_CREDIT_INITIAL_MODIF).Name = "Button_CREDIT_INITIAL_MODIF";
		((ButtonBase)Button_CREDIT_INITIAL_MODIF).UseVisualStyleBackColor = true;
		Combo_VENDEUR.AutoCompleteMode = (AutoCompleteMode)3;
		Combo_VENDEUR.AutoCompleteSource = (AutoCompleteSource)256;
		Combo_VENDEUR.DropDownStyle = (ComboBoxStyle)2;
		componentResourceManager.ApplyResources(Combo_VENDEUR, "Combo_VENDEUR");
		((ListControl)Combo_VENDEUR).FormattingEnabled = true;
		((Control)Combo_VENDEUR).Name = "Combo_VENDEUR";
		((TextBoxBase)Text_ID_CLIENT).BackColor = Color.White;
		componentResourceManager.ApplyResources(Text_ID_CLIENT, "Text_ID_CLIENT");
		((Control)Text_ID_CLIENT).Name = "Text_ID_CLIENT";
		((TextBoxBase)Text_CREDIT_INITIAL).BackColor = Color.White;
		componentResourceManager.ApplyResources(Text_CREDIT_INITIAL, "Text_CREDIT_INITIAL");
		((Control)Text_CREDIT_INITIAL).Name = "Text_CREDIT_INITIAL";
		((TextBoxBase)Text_ETAT).BackColor = Color.White;
		componentResourceManager.ApplyResources(Text_ETAT, "Text_ETAT");
		((Control)Text_ETAT).Name = "Text_ETAT";
		((TextBoxBase)Text_ICE).BackColor = Color.White;
		componentResourceManager.ApplyResources(Text_ICE, "Text_ICE");
		((Control)Text_ICE).Name = "Text_ICE";
		((TextBoxBase)Text_ID).BackColor = Color.FromArgb(224, 224, 224);
		((TextBoxBase)Text_ID).BorderStyle = (BorderStyle)1;
		componentResourceManager.ApplyResources(Text_ID, "Text_ID");
		((Control)Text_ID).Name = "Text_ID";
		componentResourceManager.ApplyResources(Text_NOTE, "Text_NOTE");
		((Control)Text_NOTE).Name = "Text_NOTE";
		componentResourceManager.ApplyResources(Text_TEL, "Text_TEL");
		((Control)Text_TEL).Name = "Text_TEL";
		componentResourceManager.ApplyResources(Text_VILLE, "Text_VILLE");
		((Control)Text_VILLE).Name = "Text_VILLE";
		componentResourceManager.ApplyResources(Text_ADRESSE, "Text_ADRESSE");
		((Control)Text_ADRESSE).Name = "Text_ADRESSE";
		((TextBoxBase)Text_CLIENT).BackColor = Color.White;
		componentResourceManager.ApplyResources(Text_CLIENT, "Text_CLIENT");
		((Control)Text_CLIENT).Name = "Text_CLIENT";
		((TextBoxBase)Text_CODE_CLIENT).BackColor = Color.White;
		componentResourceManager.ApplyResources(Text_CODE_CLIENT, "Text_CODE_CLIENT");
		((Control)Text_CODE_CLIENT).Name = "Text_CODE_CLIENT";
		componentResourceManager.ApplyResources(DateTimePicker_DATE, "DateTimePicker_DATE");
		DateTimePicker_DATE.Format = (DateTimePickerFormat)2;
		((Control)DateTimePicker_DATE).Name = "DateTimePicker_DATE";
		componentResourceManager.ApplyResources(Label23, "Label23");
		((Control)Label23).BackColor = Color.Transparent;
		((Control)Label23).ForeColor = Color.FromArgb(2, 45, 162);
		((Control)Label23).Name = "Label23";
		componentResourceManager.ApplyResources(Label21, "Label21");
		((Control)Label21).BackColor = Color.Transparent;
		((Control)Label21).ForeColor = Color.FromArgb(2, 45, 162);
		((Control)Label21).Name = "Label21";
		((Control)Label_BALANCE).BackColor = Color.Black;
		componentResourceManager.ApplyResources(Label_BALANCE, "Label_BALANCE");
		((Control)Label_BALANCE).ForeColor = Color.White;
		((Control)Label_BALANCE).Name = "Label_BALANCE";
		((Control)Label17).BackColor = Color.Black;
		componentResourceManager.ApplyResources(Label17, "Label17");
		((Control)Label17).Name = "Label17";
		((Control)Label_REGLE).BackColor = Color.Red;
		Label_REGLE.BorderStyle = (BorderStyle)2;
		componentResourceManager.ApplyResources(Label_REGLE, "Label_REGLE");
		((Control)Label_REGLE).ForeColor = Color.White;
		((Control)Label_REGLE).Name = "Label_REGLE";
		((Control)Label_CREDIT).BackColor = Color.Blue;
		Label_CREDIT.BorderStyle = (BorderStyle)2;
		componentResourceManager.ApplyResources(Label_CREDIT, "Label_CREDIT");
		((Control)Label_CREDIT).ForeColor = Color.White;
		((Control)Label_CREDIT).Name = "Label_CREDIT";
		DataGridView_REGLEMENTS.AllowUserToAddRows = false;
		DataGridView_REGLEMENTS.AllowUserToDeleteRows = false;
		DataGridView_REGLEMENTS.AllowUserToResizeRows = false;
		DataGridView_REGLEMENTS.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)16;
		DataGridView_REGLEMENTS.BackgroundColor = Color.White;
		DataGridView_REGLEMENTS.BorderStyle = (BorderStyle)2;
		DataGridView_REGLEMENTS.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		DataGridView_REGLEMENTS.Columns.AddRange(new DataGridViewColumn[4]
		{
			(DataGridViewColumn)ID_REGLE,
			(DataGridViewColumn)DATES_REGLEMENT,
			(DataGridViewColumn)MONTANT,
			(DataGridViewColumn)NOTES
		});
		DataGridView_REGLEMENTS.EditMode = (DataGridViewEditMode)4;
		DataGridView_REGLEMENTS.EnableHeadersVisualStyles = false;
		componentResourceManager.ApplyResources(DataGridView_REGLEMENTS, "DataGridView_REGLEMENTS");
		((Control)DataGridView_REGLEMENTS).Name = "DataGridView_REGLEMENTS";
		DataGridView_REGLEMENTS.RowHeadersVisible = false;
		DataGridView_REGLEMENTS.SelectionMode = (DataGridViewSelectionMode)1;
		((DataGridViewColumn)ID_REGLE).DataPropertyName = "ID_REGLE";
		componentResourceManager.ApplyResources(ID_REGLE, "ID_REGLE");
		((DataGridViewColumn)ID_REGLE).Name = "ID_REGLE";
		((DataGridViewColumn)DATES_REGLEMENT).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)DATES_REGLEMENT).DataPropertyName = "DATES";
		componentResourceManager.ApplyResources(DATES_REGLEMENT, "DATES_REGLEMENT");
		((DataGridViewColumn)DATES_REGLEMENT).Name = "DATES_REGLEMENT";
		((DataGridViewColumn)MONTANT).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)MONTANT).DataPropertyName = "MONTANT";
		val.Format = "N2";
		val.NullValue = null;
		((DataGridViewColumn)MONTANT).DefaultCellStyle = val;
		componentResourceManager.ApplyResources(MONTANT, "MONTANT");
		((DataGridViewColumn)MONTANT).Name = "MONTANT";
		((DataGridViewColumn)NOTES).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)NOTES).DataPropertyName = "NOTES";
		componentResourceManager.ApplyResources(NOTES, "NOTES");
		((DataGridViewColumn)NOTES).Name = "NOTES";
		((Control)Label15).BackColor = Color.Black;
		componentResourceManager.ApplyResources(Label15, "Label15");
		((Control)Label15).Name = "Label15";
		componentResourceManager.ApplyResources(DateTimePicker3, "DateTimePicker3");
		DateTimePicker3.Format = (DateTimePickerFormat)2;
		((Control)DateTimePicker3).Name = "DateTimePicker3";
		componentResourceManager.ApplyResources(DateTimePicker4, "DateTimePicker4");
		DateTimePicker4.Format = (DateTimePickerFormat)2;
		((Control)DateTimePicker4).Name = "DateTimePicker4";
		componentResourceManager.ApplyResources(DateTimePicker5, "DateTimePicker5");
		DateTimePicker5.Format = (DateTimePickerFormat)2;
		((Control)DateTimePicker5).Name = "DateTimePicker5";
		componentResourceManager.ApplyResources(DateTimePicker6, "DateTimePicker6");
		DateTimePicker6.Format = (DateTimePickerFormat)2;
		((Control)DateTimePicker6).Name = "DateTimePicker6";
		DataGridView_DETAILS_VENTES.AllowUserToAddRows = false;
		DataGridView_DETAILS_VENTES.AllowUserToResizeColumns = false;
		DataGridView_DETAILS_VENTES.AllowUserToResizeRows = false;
		DataGridView_DETAILS_VENTES.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)16;
		DataGridView_DETAILS_VENTES.BackgroundColor = Color.White;
		DataGridView_DETAILS_VENTES.BorderStyle = (BorderStyle)2;
		DataGridView_DETAILS_VENTES.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		DataGridView_DETAILS_VENTES.Columns.AddRange(new DataGridViewColumn[9]
		{
			(DataGridViewColumn)Tickett,
			(DataGridViewColumn)DATESs,
			(DataGridViewColumn)Heuree,
			(DataGridViewColumn)Articlee,
			(DataGridViewColumn)PRIX_Vv,
			(DataGridViewColumn)Qtéé,
			(DataGridViewColumn)Remisee,
			(DataGridViewColumn)TOTAL_NETt,
			(DataGridViewColumn)OPERATIONn
		});
		DataGridView_DETAILS_VENTES.EditMode = (DataGridViewEditMode)4;
		componentResourceManager.ApplyResources(DataGridView_DETAILS_VENTES, "DataGridView_DETAILS_VENTES");
		((Control)DataGridView_DETAILS_VENTES).Name = "DataGridView_DETAILS_VENTES";
		DataGridView_DETAILS_VENTES.RowHeadersVisible = false;
		DataGridView_DETAILS_VENTES.SelectionMode = (DataGridViewSelectionMode)1;
		((DataGridViewColumn)Tickett).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)Tickett).DataPropertyName = "Ticket";
		componentResourceManager.ApplyResources(Tickett, "Tickett");
		((DataGridViewColumn)Tickett).Name = "Tickett";
		Tickett.SortMode = (DataGridViewColumnSortMode)2;
		((DataGridViewColumn)DATESs).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)DATESs).DataPropertyName = "DATES";
		componentResourceManager.ApplyResources(DATESs, "DATESs");
		((DataGridViewColumn)DATESs).Name = "DATESs";
		DATESs.SortMode = (DataGridViewColumnSortMode)2;
		((DataGridViewColumn)Heuree).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)Heuree).DataPropertyName = "Heure";
		componentResourceManager.ApplyResources(Heuree, "Heuree");
		((DataGridViewColumn)Heuree).Name = "Heuree";
		Heuree.SortMode = (DataGridViewColumnSortMode)2;
		((DataGridViewColumn)Articlee).DataPropertyName = "Article";
		componentResourceManager.ApplyResources(Articlee, "Articlee");
		((DataGridViewColumn)Articlee).Name = "Articlee";
		Articlee.SortMode = (DataGridViewColumnSortMode)2;
		((DataGridViewColumn)PRIX_Vv).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)PRIX_Vv).DataPropertyName = "PRIX_V";
		componentResourceManager.ApplyResources(PRIX_Vv, "PRIX_Vv");
		((DataGridViewColumn)PRIX_Vv).Name = "PRIX_Vv";
		PRIX_Vv.SortMode = (DataGridViewColumnSortMode)2;
		((DataGridViewColumn)Qtéé).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)Qtéé).DataPropertyName = "Qté";
		componentResourceManager.ApplyResources(Qtéé, "Qtéé");
		((DataGridViewColumn)Qtéé).Name = "Qtéé";
		Qtéé.SortMode = (DataGridViewColumnSortMode)2;
		((DataGridViewColumn)Remisee).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)Remisee).DataPropertyName = "Remise";
		componentResourceManager.ApplyResources(Remisee, "Remisee");
		((DataGridViewColumn)Remisee).Name = "Remisee";
		Remisee.SortMode = (DataGridViewColumnSortMode)2;
		((DataGridViewColumn)TOTAL_NETt).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)TOTAL_NETt).DataPropertyName = "TOTAL_NET";
		componentResourceManager.ApplyResources(TOTAL_NETt, "TOTAL_NETt");
		((DataGridViewColumn)TOTAL_NETt).Name = "TOTAL_NETt";
		TOTAL_NETt.SortMode = (DataGridViewColumnSortMode)2;
		((DataGridViewColumn)OPERATIONn).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)OPERATIONn).DataPropertyName = "OPERATION";
		componentResourceManager.ApplyResources(OPERATIONn, "OPERATIONn");
		((DataGridViewColumn)OPERATIONn).Name = "OPERATIONn";
		OPERATIONn.SortMode = (DataGridViewColumnSortMode)2;
		DataGridView1.AllowUserToAddRows = false;
		DataGridView1.AllowUserToDeleteRows = false;
		DataGridView1.AllowUserToResizeRows = false;
		componentResourceManager.ApplyResources(DataGridView1, "DataGridView1");
		DataGridView1.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)16;
		DataGridView1.BackgroundColor = Color.White;
		DataGridView1.BorderStyle = (BorderStyle)2;
		DataGridView1.CellBorderStyle = (DataGridViewCellBorderStyle)8;
		val2.Alignment = (DataGridViewContentAlignment)16;
		val2.BackColor = SystemColors.Control;
		val2.Font = new Font("Segoe UI", 10f, (FontStyle)1);
		val2.ForeColor = SystemColors.WindowText;
		val2.SelectionBackColor = SystemColors.Highlight;
		val2.SelectionForeColor = SystemColors.HighlightText;
		val2.WrapMode = (DataGridViewTriState)1;
		DataGridView1.ColumnHeadersDefaultCellStyle = val2;
		DataGridView1.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		DataGridView1.Columns.AddRange(new DataGridViewColumn[9]
		{
			(DataGridViewColumn)DATES,
			(DataGridViewColumn)ID_Client,
			(DataGridViewColumn)CODE_CLIENT,
			(DataGridViewColumn)Client,
			(DataGridViewColumn)TELEPHONE,
			(DataGridViewColumn)Notess,
			(DataGridViewColumn)ETAT,
			(DataGridViewColumn)supp,
			(DataGridViewColumn)modi
		});
		DataGridView1.EditMode = (DataGridViewEditMode)4;
		((Control)DataGridView1).Name = "DataGridView1";
		DataGridView1.RowHeadersVisible = false;
		((DataGridViewColumn)DATES).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)DATES).DataPropertyName = "DATES";
		componentResourceManager.ApplyResources(DATES, "DATES");
		((DataGridViewColumn)DATES).Name = "DATES";
		((DataGridViewColumn)ID_Client).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)ID_Client).DataPropertyName = "ID_Client";
		componentResourceManager.ApplyResources(ID_Client, "ID_Client");
		((DataGridViewColumn)ID_Client).Name = "ID_Client";
		((DataGridViewColumn)CODE_CLIENT).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)CODE_CLIENT).DataPropertyName = "CODE_CLIENT";
		componentResourceManager.ApplyResources(CODE_CLIENT, "CODE_CLIENT");
		((DataGridViewColumn)CODE_CLIENT).Name = "CODE_CLIENT";
		CODE_CLIENT.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)Client).DataPropertyName = "CLIENT";
		componentResourceManager.ApplyResources(Client, "Client");
		((DataGridViewColumn)Client).Name = "Client";
		Client.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)TELEPHONE).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)TELEPHONE).DataPropertyName = "TELEPHONE";
		componentResourceManager.ApplyResources(TELEPHONE, "TELEPHONE");
		((DataGridViewColumn)TELEPHONE).Name = "TELEPHONE";
		TELEPHONE.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)Notess).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)Notess).DataPropertyName = "NOTES";
		componentResourceManager.ApplyResources(Notess, "Notess");
		((DataGridViewColumn)Notess).Name = "Notess";
		((DataGridViewColumn)ETAT).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)ETAT).DataPropertyName = "ETAT";
		componentResourceManager.ApplyResources(ETAT, "ETAT");
		((DataGridViewColumn)ETAT).Name = "ETAT";
		((DataGridViewColumn)supp).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		componentResourceManager.ApplyResources(supp, "supp");
		supp.Image = (Image)(object)Resources.Picture_SUPP_Image;
		((DataGridViewColumn)supp).Name = "supp";
		((DataGridViewColumn)supp).Resizable = (DataGridViewTriState)1;
		((DataGridViewColumn)modi).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		componentResourceManager.ApplyResources(modi, "modi");
		modi.Image = (Image)(object)Resources.Picture_MODIF_Image;
		((DataGridViewColumn)modi).Name = "modi";
		((DataGridViewColumn)modi).Resizable = (DataGridViewTriState)1;
		((Control)Label_TABLE).BackColor = Color.FromArgb(22, 106, 238);
		componentResourceManager.ApplyResources(Label_TABLE, "Label_TABLE");
		((Control)Label_TABLE).ForeColor = Color.White;
		((Control)Label_TABLE).Name = "Label_TABLE";
		componentResourceManager.ApplyResources(Panel_HISTORIQUE, "Panel_HISTORIQUE");
		((Control)Panel_HISTORIQUE).BackColor = Color.White;
		Panel_HISTORIQUE.BorderStyle = (BorderStyle)1;
		((Control)Panel_HISTORIQUE).Controls.Add((Control)(object)Label_HISTORIQUE_ID_CLIENT);
		((Control)Panel_HISTORIQUE).Controls.Add((Control)(object)TabControl2);
		((Control)Panel_HISTORIQUE).Controls.Add((Control)(object)Button3);
		((Control)Panel_HISTORIQUE).Controls.Add((Control)(object)Label1);
		((Control)Panel_HISTORIQUE).Controls.Add((Control)(object)Label5);
		((Control)Panel_HISTORIQUE).Controls.Add((Control)(object)Label6);
		((Control)Panel_HISTORIQUE).Controls.Add((Control)(object)Label_HISTORIQUE_CLIENT);
		((Control)Panel_HISTORIQUE).Name = "Panel_HISTORIQUE";
		componentResourceManager.ApplyResources(Label_HISTORIQUE_ID_CLIENT, "Label_HISTORIQUE_ID_CLIENT");
		((Control)Label_HISTORIQUE_ID_CLIENT).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label_HISTORIQUE_ID_CLIENT).Cursor = Cursors.Hand;
		((Control)Label_HISTORIQUE_ID_CLIENT).ForeColor = Color.White;
		((Control)Label_HISTORIQUE_ID_CLIENT).Name = "Label_HISTORIQUE_ID_CLIENT";
		((Control)TabControl2).Controls.Add((Control)(object)TabPage5);
		((Control)TabControl2).Controls.Add((Control)(object)TabPage6);
		componentResourceManager.ApplyResources(TabControl2, "TabControl2");
		((Control)TabControl2).Name = "TabControl2";
		TabControl2.SelectedIndex = 0;
		TabPage5.BackColor = Color.White;
		((Control)TabPage5).Controls.Add((Control)(object)DataGridView_VENTES);
		((Control)TabPage5).Controls.Add((Control)(object)Label22);
		((Control)TabPage5).Controls.Add((Control)(object)Label_CREDIT_INITIAL);
		((Control)TabPage5).Controls.Add((Control)(object)Label_REGLE_CLIENT);
		((Control)TabPage5).Controls.Add((Control)(object)Label13);
		((Control)TabPage5).Controls.Add((Control)(object)Label_RETOUR_CREDIT);
		((Control)TabPage5).Controls.Add((Control)(object)Label_VENTE_CREDIT);
		((Control)TabPage5).Controls.Add((Control)(object)Button_PrintRapport_2);
		((Control)TabPage5).Controls.Add((Control)(object)Label16);
		((Control)TabPage5).Controls.Add((Control)(object)Label18);
		((Control)TabPage5).Controls.Add((Control)(object)PictureBox3);
		((Control)TabPage5).Controls.Add((Control)(object)Button16);
		((Control)TabPage5).Controls.Add((Control)(object)Label30);
		((Control)TabPage5).Controls.Add((Control)(object)Label29);
		((Control)TabPage5).Controls.Add((Control)(object)Label23);
		((Control)TabPage5).Controls.Add((Control)(object)Label21);
		((Control)TabPage5).Controls.Add((Control)(object)Label_BALANCE);
		((Control)TabPage5).Controls.Add((Control)(object)Label17);
		((Control)TabPage5).Controls.Add((Control)(object)Label_REGLE);
		((Control)TabPage5).Controls.Add((Control)(object)Label_CREDIT);
		((Control)TabPage5).Controls.Add((Control)(object)PictureBox1);
		((Control)TabPage5).Controls.Add((Control)(object)DataGridView_REGLEMENTS);
		((Control)TabPage5).Controls.Add((Control)(object)Label15);
		((Control)TabPage5).Controls.Add((Control)(object)DateTimePicker3);
		((Control)TabPage5).Controls.Add((Control)(object)DateTimePicker4);
		componentResourceManager.ApplyResources(TabPage5, "TabPage5");
		((Control)TabPage5).Name = "TabPage5";
		DataGridView_VENTES.AllowUserToAddRows = false;
		DataGridView_VENTES.AllowUserToDeleteRows = false;
		DataGridView_VENTES.AllowUserToResizeRows = false;
		DataGridView_VENTES.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)16;
		DataGridView_VENTES.BackgroundColor = Color.White;
		DataGridView_VENTES.BorderStyle = (BorderStyle)2;
		DataGridView_VENTES.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		DataGridView_VENTES.Columns.AddRange(new DataGridViewColumn[5]
		{
			(DataGridViewColumn)ID_TICKET,
			(DataGridViewColumn)TICKET,
			(DataGridViewColumn)DATES_CREDIT,
			(DataGridViewColumn)TOTAL_NET,
			(DataGridViewColumn)OPERATION
		});
		DataGridView_VENTES.EditMode = (DataGridViewEditMode)4;
		DataGridView_VENTES.EnableHeadersVisualStyles = false;
		componentResourceManager.ApplyResources(DataGridView_VENTES, "DataGridView_VENTES");
		((Control)DataGridView_VENTES).Name = "DataGridView_VENTES";
		DataGridView_VENTES.RowHeadersVisible = false;
		DataGridView_VENTES.SelectionMode = (DataGridViewSelectionMode)1;
		((DataGridViewColumn)ID_TICKET).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)ID_TICKET).DataPropertyName = "ID_TICKET";
		componentResourceManager.ApplyResources(ID_TICKET, "ID_TICKET");
		((DataGridViewColumn)ID_TICKET).Name = "ID_TICKET";
		((DataGridViewColumn)TICKET).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)TICKET).DataPropertyName = "TICKET";
		componentResourceManager.ApplyResources(TICKET, "TICKET");
		((DataGridViewColumn)TICKET).Name = "TICKET";
		((DataGridViewColumn)DATES_CREDIT).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)DATES_CREDIT).DataPropertyName = "DATES";
		componentResourceManager.ApplyResources(DATES_CREDIT, "DATES_CREDIT");
		((DataGridViewColumn)DATES_CREDIT).Name = "DATES_CREDIT";
		((DataGridViewColumn)TOTAL_NET).DataPropertyName = "TOTAL_NET";
		val3.Format = "N2";
		val3.NullValue = null;
		((DataGridViewColumn)TOTAL_NET).DefaultCellStyle = val3;
		componentResourceManager.ApplyResources(TOTAL_NET, "TOTAL_NET");
		((DataGridViewColumn)TOTAL_NET).Name = "TOTAL_NET";
		((DataGridViewColumn)OPERATION).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)OPERATION).DataPropertyName = "OPERATION";
		componentResourceManager.ApplyResources(OPERATION, "OPERATION");
		((DataGridViewColumn)OPERATION).Name = "OPERATION";
		((Control)Label22).BackColor = SystemColors.Control;
		componentResourceManager.ApplyResources(Label22, "Label22");
		((Control)Label22).ForeColor = Color.Black;
		((Control)Label22).Name = "Label22";
		((Control)Label_CREDIT_INITIAL).BackColor = SystemColors.Control;
		componentResourceManager.ApplyResources(Label_CREDIT_INITIAL, "Label_CREDIT_INITIAL");
		((Control)Label_CREDIT_INITIAL).ForeColor = Color.Black;
		((Control)Label_CREDIT_INITIAL).Name = "Label_CREDIT_INITIAL";
		((Control)Label_REGLE_CLIENT).BackColor = SystemColors.Control;
		componentResourceManager.ApplyResources(Label_REGLE_CLIENT, "Label_REGLE_CLIENT");
		((Control)Label_REGLE_CLIENT).ForeColor = Color.Black;
		((Control)Label_REGLE_CLIENT).Name = "Label_REGLE_CLIENT";
		((Control)Label13).BackColor = SystemColors.Control;
		componentResourceManager.ApplyResources(Label13, "Label13");
		((Control)Label13).ForeColor = Color.Black;
		((Control)Label13).Name = "Label13";
		((Control)Label_RETOUR_CREDIT).BackColor = SystemColors.Control;
		componentResourceManager.ApplyResources(Label_RETOUR_CREDIT, "Label_RETOUR_CREDIT");
		((Control)Label_RETOUR_CREDIT).ForeColor = Color.Black;
		((Control)Label_RETOUR_CREDIT).Name = "Label_RETOUR_CREDIT";
		((Control)Label_VENTE_CREDIT).BackColor = SystemColors.Control;
		componentResourceManager.ApplyResources(Label_VENTE_CREDIT, "Label_VENTE_CREDIT");
		((Control)Label_VENTE_CREDIT).ForeColor = Color.Black;
		((Control)Label_VENTE_CREDIT).Name = "Label_VENTE_CREDIT";
		((Control)Button_PrintRapport_2).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Button_PrintRapport_2, "Button_PrintRapport_2");
		((Control)Button_PrintRapport_2).Name = "Button_PrintRapport_2";
		((ButtonBase)Button_PrintRapport_2).UseVisualStyleBackColor = true;
		((Control)Label16).BackColor = SystemColors.Control;
		componentResourceManager.ApplyResources(Label16, "Label16");
		((Control)Label16).ForeColor = Color.Black;
		((Control)Label16).Name = "Label16";
		((Control)Label18).BackColor = SystemColors.Control;
		componentResourceManager.ApplyResources(Label18, "Label18");
		((Control)Label18).ForeColor = Color.Black;
		((Control)Label18).Name = "Label18";
		componentResourceManager.ApplyResources(PictureBox3, "PictureBox3");
		((Control)PictureBox3).Name = "PictureBox3";
		PictureBox3.TabStop = false;
		((Control)Button16).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Button16, "Button16");
		((Control)Button16).ForeColor = Color.FromArgb(2, 45, 162);
		((Control)Button16).Name = "Button16";
		((ButtonBase)Button16).UseVisualStyleBackColor = true;
		((Control)Label30).BackColor = SystemColors.Control;
		componentResourceManager.ApplyResources(Label30, "Label30");
		((Control)Label30).ForeColor = Color.Black;
		((Control)Label30).Name = "Label30";
		((Control)Label29).BackColor = SystemColors.Control;
		componentResourceManager.ApplyResources(Label29, "Label29");
		((Control)Label29).ForeColor = Color.Black;
		((Control)Label29).Name = "Label29";
		componentResourceManager.ApplyResources(PictureBox1, "PictureBox1");
		((Control)PictureBox1).Name = "PictureBox1";
		PictureBox1.TabStop = false;
		TabPage6.BackColor = Color.White;
		((Control)TabPage6).Controls.Add((Control)(object)Button4);
		((Control)TabPage6).Controls.Add((Control)(object)PictureBox4);
		((Control)TabPage6).Controls.Add((Control)(object)Button2);
		((Control)TabPage6).Controls.Add((Control)(object)DateTimePicker5);
		((Control)TabPage6).Controls.Add((Control)(object)DateTimePicker6);
		((Control)TabPage6).Controls.Add((Control)(object)DataGridView_DETAILS_VENTES);
		componentResourceManager.ApplyResources(TabPage6, "TabPage6");
		((Control)TabPage6).Name = "TabPage6";
		((Control)Button4).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Button4, "Button4");
		((Control)Button4).Name = "Button4";
		((ButtonBase)Button4).UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(PictureBox4, "PictureBox4");
		((Control)PictureBox4).Name = "PictureBox4";
		PictureBox4.TabStop = false;
		((Control)Button2).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Button2, "Button2");
		((Control)Button2).ForeColor = Color.FromArgb(2, 45, 162);
		((Control)Button2).Name = "Button2";
		((ButtonBase)Button2).UseVisualStyleBackColor = true;
		((ButtonBase)Button3).BackColor = Color.Red;
		((Control)Button3).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Button3, "Button3");
		((Control)Button3).ForeColor = Color.White;
		((Control)Button3).Name = "Button3";
		((ButtonBase)Button3).UseVisualStyleBackColor = false;
		((Control)Label1).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label1).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Label1, "Label1");
		((Control)Label1).ForeColor = Color.White;
		((Control)Label1).Name = "Label1";
		((Control)Label5).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label5).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Label5, "Label5");
		((Control)Label5).ForeColor = Color.White;
		((Control)Label5).Name = "Label5";
		((Control)Label6).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label6).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Label6, "Label6");
		((Control)Label6).ForeColor = Color.White;
		((Control)Label6).Name = "Label6";
		((Control)Label_HISTORIQUE_CLIENT).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label_HISTORIQUE_CLIENT).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Label_HISTORIQUE_CLIENT, "Label_HISTORIQUE_CLIENT");
		((Control)Label_HISTORIQUE_CLIENT).ForeColor = Color.White;
		((Control)Label_HISTORIQUE_CLIENT).Name = "Label_HISTORIQUE_CLIENT";
		componentResourceManager.ApplyResources(Panel_FIND, "Panel_FIND");
		((Control)Panel_FIND).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Panel_FIND).Controls.Add((Control)(object)Panel_DATES);
		((Control)Panel_FIND).Controls.Add((Control)(object)Combo_FIND);
		((Control)Panel_FIND).Controls.Add((Control)(object)Picture_EXPORT);
		((Control)Panel_FIND).Controls.Add((Control)(object)Label26);
		((Control)Panel_FIND).Controls.Add((Control)(object)Label20);
		((Control)Panel_FIND).Controls.Add((Control)(object)Check_FIND_DATE);
		((Control)Panel_FIND).Controls.Add((Control)(object)Check_FIND_EXACTE);
		((Control)Panel_FIND).Controls.Add((Control)(object)Picture_REFRESH);
		((Control)Panel_FIND).Controls.Add((Control)(object)Picture_FIND);
		((Control)Panel_FIND).Controls.Add((Control)(object)Text_FIND);
		((Control)Panel_FIND).Name = "Panel_FIND";
		((Control)Panel_DATES).Controls.Add((Control)(object)DateTime2_FIND);
		((Control)Panel_DATES).Controls.Add((Control)(object)DateTime1_FIND);
		((Control)Panel_DATES).Controls.Add((Control)(object)Picture_FIND_DATES);
		((Control)Panel_DATES).Controls.Add((Control)(object)PictureBox2);
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
		componentResourceManager.ApplyResources(PictureBox2, "PictureBox2");
		((Control)PictureBox2).Name = "PictureBox2";
		PictureBox2.TabStop = false;
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
		((ComboBox)Combo_FIND).Items.AddRange(new object[10]
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
			componentResourceManager.GetString("Combo_FIND.Items9")
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
		componentResourceManager.ApplyResources(Label26, "Label26");
		((Control)Label26).ForeColor = Color.White;
		((Control)Label26).Name = "Label26";
		componentResourceManager.ApplyResources(Label20, "Label20");
		((Control)Label20).ForeColor = Color.White;
		((Control)Label20).Name = "Label20";
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
		componentResourceManager.ApplyResources(Panel_FONCTIONS, "Panel_FONCTIONS");
		((Control)Panel_FONCTIONS).BackColor = Color.White;
		Panel_FONCTIONS.BorderStyle = (BorderStyle)1;
		((Control)Panel_FONCTIONS).Controls.Add((Control)(object)Label41);
		((Control)Panel_FONCTIONS).Controls.Add((Control)(object)Label44);
		((Control)Panel_FONCTIONS).Controls.Add((Control)(object)Label43);
		((Control)Panel_FONCTIONS).Controls.Add((Control)(object)Label42);
		((Control)Panel_FONCTIONS).Controls.Add((Control)(object)Button_PDF);
		((Control)Panel_FONCTIONS).Controls.Add((Control)(object)Button_EXCEL);
		((Control)Panel_FONCTIONS).Controls.Add((Control)(object)Button_WORD);
		((Control)Panel_FONCTIONS).Name = "Panel_FONCTIONS";
		((Control)Label41).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label41).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Label41, "Label41");
		((Control)Label41).ForeColor = Color.White;
		((Control)Label41).Name = "Label41";
		((Control)Label44).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label44).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Label44, "Label44");
		((Control)Label44).ForeColor = Color.White;
		((Control)Label44).Name = "Label44";
		((Control)Label43).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label43).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Label43, "Label43");
		((Control)Label43).ForeColor = Color.White;
		((Control)Label43).Name = "Label43";
		((Control)Label42).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label42).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Label42, "Label42");
		((Control)Label42).ForeColor = Color.White;
		((Control)Label42).Name = "Label42";
		((ButtonBase)Button_PDF).BackColor = Color.Transparent;
		((Control)Button_PDF).Cursor = Cursors.Hand;
		((ButtonBase)Button_PDF).FlatAppearance.BorderColor = Color.FromArgb(192, 0, 0);
		componentResourceManager.ApplyResources(Button_PDF, "Button_PDF");
		((Control)Button_PDF).ForeColor = Color.Black;
		((Control)Button_PDF).Name = "Button_PDF";
		((ButtonBase)Button_PDF).UseVisualStyleBackColor = false;
		((ButtonBase)Button_EXCEL).BackColor = Color.Transparent;
		((Control)Button_EXCEL).Cursor = Cursors.Hand;
		((ButtonBase)Button_EXCEL).FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
		componentResourceManager.ApplyResources(Button_EXCEL, "Button_EXCEL");
		((Control)Button_EXCEL).ForeColor = Color.Black;
		((Control)Button_EXCEL).Name = "Button_EXCEL";
		((ButtonBase)Button_EXCEL).UseVisualStyleBackColor = false;
		((ButtonBase)Button_WORD).BackColor = Color.Transparent;
		((Control)Button_WORD).Cursor = Cursors.Hand;
		((ButtonBase)Button_WORD).FlatAppearance.BorderColor = Color.Blue;
		componentResourceManager.ApplyResources(Button_WORD, "Button_WORD");
		((Control)Button_WORD).ForeColor = Color.Black;
		((Control)Button_WORD).Name = "Button_WORD";
		((ButtonBase)Button_WORD).UseVisualStyleBackColor = false;
		componentResourceManager.ApplyResources(Panel112233, "Panel112233");
		((Control)Panel112233).BackColor = Color.Transparent;
		((Control)Panel112233).Controls.Add((Control)(object)Label_TOTAL_LIGNES_BD);
		((Control)Panel112233).Controls.Add((Control)(object)Button_CALC_BD);
		((Control)Panel112233).Controls.Add((Control)(object)Label4141);
		((Control)Panel112233).Controls.Add((Control)(object)Label28);
		((Control)Panel112233).Controls.Add((Control)(object)Label27);
		((Control)Panel112233).Name = "Panel112233";
		((Control)Label_TOTAL_LIGNES_BD).BackColor = Color.White;
		componentResourceManager.ApplyResources(Label_TOTAL_LIGNES_BD, "Label_TOTAL_LIGNES_BD");
		((Control)Label_TOTAL_LIGNES_BD).ForeColor = Color.FromArgb(64, 64, 64);
		((Control)Label_TOTAL_LIGNES_BD).Name = "Label_TOTAL_LIGNES_BD";
		((Control)Button_CALC_BD).ForeColor = Color.Red;
		componentResourceManager.ApplyResources(Button_CALC_BD, "Button_CALC_BD");
		((Control)Button_CALC_BD).Name = "Button_CALC_BD";
		((ButtonBase)Button_CALC_BD).UseCompatibleTextRendering = true;
		((ButtonBase)Button_CALC_BD).UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(Label4141, "Label4141");
		((Control)Label4141).BackColor = Color.White;
		((Control)Label4141).ForeColor = Color.FromArgb(64, 64, 64);
		((Control)Label4141).Name = "Label4141";
		((Control)Label28).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label28).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Label28, "Label28");
		((Control)Label28).ForeColor = Color.White;
		((Control)Label28).Name = "Label28";
		((Control)Label27).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label27).Cursor = Cursors.Hand;
		componentResourceManager.ApplyResources(Label27, "Label27");
		((Control)Label27).ForeColor = Color.White;
		((Control)Label27).Name = "Label27";
		((DataGridViewColumn)DataGridViewImageColumn1).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		componentResourceManager.ApplyResources(DataGridViewImageColumn1, "DataGridViewImageColumn1");
		DataGridViewImageColumn1.Image = (Image)(object)Resources.Picture_SUPP_Image;
		((DataGridViewColumn)DataGridViewImageColumn1).Name = "DataGridViewImageColumn1";
		((DataGridViewColumn)DataGridViewImageColumn1).Resizable = (DataGridViewTriState)1;
		((DataGridViewColumn)DataGridViewImageColumn2).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		componentResourceManager.ApplyResources(DataGridViewImageColumn2, "DataGridViewImageColumn2");
		DataGridViewImageColumn2.Image = (Image)(object)Resources.Picture_MODIF_Image;
		((DataGridViewColumn)DataGridViewImageColumn2).Name = "DataGridViewImageColumn2";
		((DataGridViewColumn)DataGridViewImageColumn2).Resizable = (DataGridViewTriState)1;
		componentResourceManager.ApplyResources(Button_FONCTIONS, "Button_FONCTIONS");
		((ButtonBase)Button_FONCTIONS).BackColor = Color.Transparent;
		((Control)Button_FONCTIONS).Cursor = Cursors.Hand;
		((Control)Button_FONCTIONS).ForeColor = SystemColors.ControlText;
		((Control)Button_FONCTIONS).Name = "Button_FONCTIONS";
		((ButtonBase)Button_FONCTIONS).UseVisualStyleBackColor = false;
		componentResourceManager.ApplyResources(Button1, "Button1");
		((ButtonBase)Button1).BackColor = Color.Transparent;
		((Control)Button1).Cursor = Cursors.Hand;
		((Control)Button1).ForeColor = Color.Black;
		((Control)Button1).Name = "Button1";
		((ButtonBase)Button1).UseVisualStyleBackColor = false;
		componentResourceManager.ApplyResources(Button_ADD, "Button_ADD");
		((ButtonBase)Button_ADD).BackColor = Color.FromArgb(0, 192, 0);
		((Control)Button_ADD).Cursor = Cursors.Hand;
		((Control)Button_ADD).ForeColor = Color.White;
		((Control)Button_ADD).Name = "Button_ADD";
		((ButtonBase)Button_ADD).UseVisualStyleBackColor = false;
		componentResourceManager.ApplyResources(this, "$this");
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).BackColor = Color.White;
		((Control)this).Controls.Add((Control)(object)Panel_HISTORIQUE);
		((Control)this).Controls.Add((Control)(object)Button_FONCTIONS);
		((Control)this).Controls.Add((Control)(object)Panel_FIND);
		((Control)this).Controls.Add((Control)(object)Button1);
		((Control)this).Controls.Add((Control)(object)Label_TABLE);
		((Control)this).Controls.Add((Control)(object)Button_ADD);
		((Control)this).Controls.Add((Control)(object)Panel_FONCTIONS);
		((Control)this).Controls.Add((Control)(object)Panel_INFO);
		((Control)this).Controls.Add((Control)(object)Panel112233);
		((Control)this).Controls.Add((Control)(object)DataGridView1);
		((Form)this).KeyPreview = true;
		((Control)this).Name = "Form_5_CLIENTS";
		((Form)this).WindowState = (FormWindowState)2;
		((Control)Panel_INFO).ResumeLayout(false);
		((Control)TabControl1).ResumeLayout(false);
		((Control)TabPage1).ResumeLayout(false);
		((Control)TabPage1).PerformLayout();
		((ISupportInitialize)DataGridView_REGLEMENTS).EndInit();
		((ISupportInitialize)DataGridView_DETAILS_VENTES).EndInit();
		((ISupportInitialize)DataGridView1).EndInit();
		((Control)Panel_HISTORIQUE).ResumeLayout(false);
		((Control)TabControl2).ResumeLayout(false);
		((Control)TabPage5).ResumeLayout(false);
		((Control)TabPage5).PerformLayout();
		((ISupportInitialize)DataGridView_VENTES).EndInit();
		((ISupportInitialize)PictureBox3).EndInit();
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)TabPage6).ResumeLayout(false);
		((ISupportInitialize)PictureBox4).EndInit();
		((Control)Panel_FIND).ResumeLayout(false);
		((Control)Panel_FIND).PerformLayout();
		((Control)Panel_DATES).ResumeLayout(false);
		((ISupportInitialize)Picture_FIND_DATES).EndInit();
		((ISupportInitialize)PictureBox2).EndInit();
		((Control)Panel_FONCTIONS).ResumeLayout(false);
		((Control)Panel112233).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	public void FUN_CAT_ACCES()
	{
		if (Operators.CompareString(Module1._USERCATEGORIE, "ADMIN", TextCompare: false) == 0)
		{
			DataGridView1.Columns["supp"].Visible = true;
			DataGridView1.Columns["modi"].Visible = true;
		}
		else if (Operators.CompareString(Module1._USERCATEGORIE, "MANAGER", TextCompare: false) == 0)
		{
			DataGridView1.Columns["supp"].Visible = false;
			DataGridView1.Columns["modi"].Visible = false;
		}
		else if (Operators.CompareString(Module1._USERCATEGORIE, "UTILISATEUR", TextCompare: false) == 0)
		{
			DataGridView1.Columns["supp"].Visible = false;
			DataGridView1.Columns["modi"].Visible = false;
		}
	}

	public void _COLORISE_DATAGRID()
	{
		checked
		{
			int num = DataGridView_DETAILS_VENTES.Rows.Count - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 <= num4)
				{
					if (num2 == 0)
					{
						DataGridView_DETAILS_VENTES.Rows[num2].DefaultCellStyle.BackColor = Color.FromArgb(221, 235, 247);
					}
					else if (Operators.ConditionalCompareObjectEqual(DataGridView_DETAILS_VENTES.Rows[num2].Cells[0].Value, DataGridView_DETAILS_VENTES.Rows[num2 - 1].Cells[0].Value, TextCompare: false))
					{
						DataGridView_DETAILS_VENTES.Rows[num2].DefaultCellStyle.BackColor = DataGridView_DETAILS_VENTES.Rows[num2 - 1].DefaultCellStyle.BackColor;
					}
					else if (DataGridView_DETAILS_VENTES.Rows[num2 - 1].DefaultCellStyle.BackColor == Color.FromArgb(221, 235, 247))
					{
						DataGridView_DETAILS_VENTES.Rows[num2].DefaultCellStyle.BackColor = Color.White;
					}
					else
					{
						DataGridView_DETAILS_VENTES.Rows[num2].DefaultCellStyle.BackColor = Color.FromArgb(221, 235, 247);
					}
					num2++;
					continue;
				}
				break;
			}
		}
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

	private void Form_5_CLIENTS_FormClosed(object sender, FormClosedEventArgs e)
	{
		DT.Clear();
	}

	private void FormDialog_famille_Load(object sender, EventArgs e)
	{
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Expected Obj, but got Unknown
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Expected Obj, but got Unknown
		//IL_09d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_09dc: Expected Obj, but got Unknown
		//IL_037d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0387: Expected Obj, but got Unknown
		//IL_039e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a8: Expected Obj, but got Unknown
		//IL_0535: Unknown result type (might be due to invalid IL or missing references)
		//IL_053f: Expected Obj, but got Unknown
		//IL_0556: Unknown result type (might be due to invalid IL or missing references)
		//IL_0560: Expected Obj, but got Unknown
		//IL_06f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fc: Expected Obj, but got Unknown
		//IL_0713: Unknown result type (might be due to invalid IL or missing references)
		//IL_071d: Expected Obj, but got Unknown
		//IL_07e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e7: Expected Obj, but got Unknown
		//IL_07f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fe: Expected Obj, but got Unknown
		//IL_0893: Unknown result type (might be due to invalid IL or missing references)
		//IL_089d: Expected Obj, but got Unknown
		checked
		{
			try
			{
				Combo_FIND.SelectedIndex = 2;
				Text_FIND.PlaceholderText = "Recherche";
				DateTime1_FIND.Text = "01/01/2000";
				DateTime2_FIND.Text = Conversions.ToString(DateTime.Now.Date);
				DateTimePicker3.Text = "01/01/2000";
				DateTimePicker4.Text = Conversions.ToString(DateTime.Now.Date);
				DateTimePicker5.Text = "01/01/2000";
				DateTimePicker6.Text = Conversions.ToString(DateTime.Now.Date);
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
				DataGridView_VENTES.AutoGenerateColumns = false;
				DataGridView_VENTES.RowTemplate.Height = 30;
				DataGridView_VENTES.BackgroundColor = Color.White;
				DataGridView_VENTES.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(34, 34, 34);
				DataGridView_VENTES.DefaultCellStyle.SelectionBackColor = Color.Yellow;
				DataGridView_VENTES.DefaultCellStyle.SelectionForeColor = Color.Red;
				DataGridView_VENTES.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(221, 235, 247);
				DataGridView_VENTES.GridColor = Color.FromArgb(231, 231, 231);
				DataGridView_VENTES.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10f, (FontStyle)1);
				DataGridView_VENTES.DefaultCellStyle.Font = new Font("Segoe UI", 10f, (FontStyle)0);
				DataGridView_VENTES.ColumnHeadersBorderStyle = (DataGridViewHeaderBorderStyle)1;
				DataGridView_VENTES.ColumnHeadersDefaultCellStyle.Alignment = (DataGridViewContentAlignment)16;
				DataGridView_VENTES.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)0;
				DataGridView_VENTES.AutoResizeColumnHeadersHeight();
				DataGridView_VENTES.CellBorderStyle = (DataGridViewCellBorderStyle)5;
				DataGridView_VENTES.SelectionMode = (DataGridViewSelectionMode)1;
				DataGridView_VENTES.MultiSelect = true;
				DataGridView_VENTES.EditMode = (DataGridViewEditMode)4;
				DataGridView_VENTES.ClipboardCopyMode = (DataGridViewClipboardCopyMode)0;
				int num5 = ((BaseCollection)DataGridView_VENTES.Columns).Count - 1;
				int num6 = 0;
				while (true)
				{
					int num7 = num6;
					int num4 = num5;
					if (num7 > num4)
					{
						break;
					}
					DataGridView_VENTES.Columns[num6].SortMode = (DataGridViewColumnSortMode)2;
					num6++;
				}
				DataGridView_REGLEMENTS.AutoGenerateColumns = false;
				DataGridView_REGLEMENTS.RowTemplate.Height = 30;
				DataGridView_REGLEMENTS.BackgroundColor = Color.White;
				DataGridView_REGLEMENTS.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(34, 34, 34);
				DataGridView_REGLEMENTS.DefaultCellStyle.SelectionBackColor = Color.Yellow;
				DataGridView_REGLEMENTS.DefaultCellStyle.SelectionForeColor = Color.Red;
				DataGridView_REGLEMENTS.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(221, 235, 247);
				DataGridView_REGLEMENTS.GridColor = Color.FromArgb(231, 231, 231);
				DataGridView_REGLEMENTS.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10f, (FontStyle)1);
				DataGridView_REGLEMENTS.DefaultCellStyle.Font = new Font("Segoe UI", 10f, (FontStyle)0);
				DataGridView_REGLEMENTS.ColumnHeadersBorderStyle = (DataGridViewHeaderBorderStyle)1;
				DataGridView_REGLEMENTS.ColumnHeadersDefaultCellStyle.Alignment = (DataGridViewContentAlignment)16;
				DataGridView_REGLEMENTS.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)0;
				DataGridView_REGLEMENTS.AutoResizeColumnHeadersHeight();
				DataGridView_REGLEMENTS.CellBorderStyle = (DataGridViewCellBorderStyle)5;
				DataGridView_REGLEMENTS.SelectionMode = (DataGridViewSelectionMode)1;
				DataGridView_REGLEMENTS.MultiSelect = true;
				DataGridView_REGLEMENTS.EditMode = (DataGridViewEditMode)4;
				DataGridView_REGLEMENTS.ClipboardCopyMode = (DataGridViewClipboardCopyMode)0;
				int num8 = ((BaseCollection)DataGridView_REGLEMENTS.Columns).Count - 1;
				int num9 = 0;
				while (true)
				{
					int num10 = num9;
					int num4 = num8;
					if (num10 > num4)
					{
						break;
					}
					DataGridView_REGLEMENTS.Columns[num9].SortMode = (DataGridViewColumnSortMode)2;
					num9++;
				}
				DataGridView_DETAILS_VENTES.AutoGenerateColumns = false;
				DataGridView_DETAILS_VENTES.RowTemplate.Height = 30;
				DataGridView_DETAILS_VENTES.BackgroundColor = Color.White;
				DataGridView_DETAILS_VENTES.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(34, 34, 34);
				DataGridView_DETAILS_VENTES.DefaultCellStyle.SelectionBackColor = Color.Yellow;
				DataGridView_DETAILS_VENTES.DefaultCellStyle.SelectionForeColor = Color.Red;
				DataGridView_DETAILS_VENTES.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(221, 235, 247);
				DataGridView_DETAILS_VENTES.GridColor = Color.FromArgb(231, 231, 231);
				DataGridView_DETAILS_VENTES.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10f, (FontStyle)1);
				DataGridView_DETAILS_VENTES.DefaultCellStyle.Font = new Font("Segoe UI", 10f, (FontStyle)0);
				DataGridView_DETAILS_VENTES.ColumnHeadersBorderStyle = (DataGridViewHeaderBorderStyle)1;
				DataGridView_DETAILS_VENTES.ColumnHeadersDefaultCellStyle.Alignment = (DataGridViewContentAlignment)16;
				DataGridView_DETAILS_VENTES.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)0;
				DataGridView_DETAILS_VENTES.AutoResizeColumnHeadersHeight();
				DataGridView_DETAILS_VENTES.CellBorderStyle = (DataGridViewCellBorderStyle)5;
				DataGridView_DETAILS_VENTES.SelectionMode = (DataGridViewSelectionMode)1;
				DataGridView_DETAILS_VENTES.MultiSelect = true;
				DataGridView_DETAILS_VENTES.EditMode = (DataGridViewEditMode)4;
				DataGridView_DETAILS_VENTES.ClipboardCopyMode = (DataGridViewClipboardCopyMode)0;
				int num11 = ((BaseCollection)DataGridView_DETAILS_VENTES.Columns).Count - 1;
				int num12 = 0;
				while (true)
				{
					int num13 = num12;
					int num4 = num11;
					if (num13 > num4)
					{
						break;
					}
					DataGridView_DETAILS_VENTES.Columns[num12].SortMode = (DataGridViewColumnSortMode)2;
					num12++;
				}
				DataTable dataTable = new DataTable();
				MySqlDataAdapter val = new MySqlDataAdapter();
				dataTable.Clear();
				val = new MySqlDataAdapter("select    ListUser    from TABLE_PASS  where  Catégorie = 'UTILISATEUR'   order by ID asc", Module1.cn_SQL);
				((DbDataAdapter)(object)val).Fill(dataTable);
				Combo_VENDEUR.Items.Clear();
				Combo_VENDEUR.Items.Add((object)"");
				int num14 = dataTable.Rows.Count - 1;
				int num15 = 0;
				while (true)
				{
					int num16 = num15;
					int num4 = num14;
					if (num16 > num4)
					{
						break;
					}
					Combo_VENDEUR.Items.Add((object)dataTable.Rows[num15]["ListUser"].ToString());
					num15++;
				}
				dataTable.Clear();
				dataTable = null;
				DA = new MySqlDataAdapter("select * from     TABLE_CLIENTS             order by       ID      DESC", Module1.cn_SQL);
				DT = new DataTable();
				DT.Clear();
				((DbDataAdapter)(object)DA).Fill(DT);
				DataGridView1.DataSource = DT;
				TabControl1.SizeMode = (TabSizeMode)2;
				TabControl tabControl = TabControl1;
				Size itemSize = new Size((int)Math.Round((double)((Control)TabControl1).Width / (double)TabControl1.TabCount - 4.0), 28);
				tabControl.ItemSize = itemSize;
				FUN_CAT_ACCES();
				Button_CALC_BD_Click(RuntimeHelpers.GetObjectValue(sender), e);
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

	private void Button19_Click(object sender, EventArgs e)
	{
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected Obj, but got Unknown
		try
		{
			((Control)Panel_INFO).Visible = true;
			((Control)Panel_INFO).BringToFront();
			Label_TOP.Text = "NOUVEAU";
			((Control)Button_SAVE).Visible = true;
			Text_ID.Text = "";
			DateTimePicker_DATE.Text = Conversions.ToString(DateTime.Now.Date);
			Text_ID_CLIENT.Text = "";
			Text_CODE_CLIENT.Text = "";
			Text_CLIENT.Text = "";
			Text_ICE.Text = "";
			Text_ADRESSE.Text = "";
			Text_VILLE.Text = "";
			Text_PAYS.Text = "";
			Text_TEL.Text = "";
			Text_NOTE.Text = "";
			Text_CREDIT_INITIAL.Text = "0";
			Combo_VENDEUR.Text = null;
			Text_ETAT.Text = "EN COURS";
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

	private void DataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
	{
	}

	private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
	}

	private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		//IL_05a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a8: Expected Obj, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Invalid comparison between Unknown and I4
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected Obj, but got Unknown
		try
		{
			if (Operators.ConditionalCompareObjectEqual(e.ColumnIndex, Operators.SubtractObject(NewLateBinding.LateGet(sender, null, "ColumnCount", new object[0], null, null, null), 2), TextCompare: false))
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
			if (Operators.ConditionalCompareObjectEqual(e.ColumnIndex, Operators.SubtractObject(NewLateBinding.LateGet(sender, null, "ColumnCount", new object[0], null, null, null), 1), TextCompare: false))
			{
				((Control)Panel_INFO).Visible = true;
				((Control)Panel_INFO).BringToFront();
				Label_INDEX.Text = Conversions.ToString(((DataGridViewBand)DataGridView1.CurrentRow).Index);
				Label_TOP.Text = "MODIFICATION";
				((Control)Button_SAVE).Visible = true;
				int position2 = ((ContainerControl)this).BindingContext[(object)DT].Position;
				Text_ID.Text = DT.Rows[position2]["ID"].ToString();
				Text_ID_CLIENT.Text = DT.Rows[position2]["ID_CLIENT"].ToString();
				Text_CODE_CLIENT.Text = DT.Rows[position2]["CODE_CLIENT"].ToString();
				Text_CLIENT.Text = DT.Rows[position2]["CLIENT"].ToString();
				DateTimePicker_DATE.Text = Conversions.ToDate(DT.Rows[position2]["DATES"]).ToString("yyyy-MM-dd");
				Text_ICE.Text = DT.Rows[position2]["ICE"].ToString();
				Text_ADRESSE.Text = DT.Rows[position2]["ADRESSE"].ToString();
				Text_VILLE.Text = DT.Rows[position2]["VILLE"].ToString();
				Text_PAYS.Text = DT.Rows[position2]["PAYS"].ToString();
				Text_TEL.Text = DT.Rows[position2]["TELEPHONE"].ToString();
				Text_NOTE.Text = DT.Rows[position2]["NOTES"].ToString();
				Text_ETAT.Text = DT.Rows[position2]["ETAT"].ToString();
				Text_CREDIT_INITIAL.Text = DT.Rows[position2]["CREDIT_INITIAL"].ToString();
				Combo_VENDEUR.Text = DT.Rows[position2]["VENDEUR"].ToString();
				((Control)Text_CREDIT_INITIAL).Enabled = false;
			}
			Button_CALC_BD_Click(RuntimeHelpers.GetObjectValue(sender), (EventArgs)(object)e);
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

	private void DataGridView1_DoubleClick(object sender, EventArgs e)
	{
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected Obj, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected Obj, but got Unknown
		try
		{
			if (DataGridView1.Rows.Count != 0)
			{
				DataGridViewCellEventArgs e2 = new DataGridViewCellEventArgs(((DataGridViewBand)DataGridView1.Columns["modi"]).Index, DataGridView1.CurrentCell.RowIndex);
				DataGridView1_CellClick(DataGridView1, e2);
				Label_TOP.Text = "CONSULTATION";
				((Control)Button_SAVE).Visible = false;
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

	private void Button12_Click(object sender, EventArgs e)
	{
		//IL_0c0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c16: Expected Obj, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected Obj, but got Unknown
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected Obj, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected Obj, but got Unknown
		//IL_070f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0719: Expected Obj, but got Unknown
		//IL_05eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f2: Expected Obj, but got Unknown
		//IL_064c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0653: Expected Obj, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_09bd: Expected Obj, but got Unknown
		//IL_09e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0752: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bd: Expected Obj, but got Unknown
		//IL_0534: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			try
			{
				if (Operators.CompareString(Text_CLIENT.Text, "", TextCompare: false) == 0)
				{
					MessageBox.Show("Veuillez remplir le champ -CLIENT- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
				if (Operators.CompareString(Text_CREDIT_INITIAL.Text, "", TextCompare: false) == 0)
				{
					MessageBox.Show("Veuillez remplir le champ -CREDIT_INITIAL- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
				if (Operators.CompareString(Label_TOP.Text, "NOUVEAU", TextCompare: false) == 0)
				{
					if (Operators.CompareString(Text_CODE_CLIENT.Text, "", TextCompare: false) != 0)
					{
						DataTable dataTable = new DataTable();
						MySqlDataAdapter val = new MySqlDataAdapter();
						dataTable.Clear();
						val = new MySqlDataAdapter("select ID,CODE_CLIENT,CLIENT     from TABLE_CLIENTS WHERE   CODE_CLIENT = '" + Text_CODE_CLIENT.Text + "'", Module1.cn_SQL);
						((DbDataAdapter)(object)val).Fill(dataTable);
						if (dataTable.Rows.Count != 0)
						{
							MessageBox.Show(Conversions.ToString(Operators.ConcatenateObject("Ce Code est déja utilisé pour ==> ", dataTable.Rows[0]["CLIENT"])), "Attetion", (MessageBoxButtons)0, (MessageBoxIcon)48, (MessageBoxDefaultButton)0);
							return;
						}
					}
					MySqlCommand val2 = new MySqlCommand();
					val2.CommandText = "SELECT MAX(ID) From TABLE_CLIENTS ";
					val2.Connection = Module1.cn_SQL;
					val2.CommandType = CommandType.Text;
					if (Module1.cn_SQL.State != ConnectionState.Open)
					{
						Module1.cn_SQL.Open();
					}
					int num = ((val2.ExecuteScalar() == DBNull.Value) ? 1 : ((int)Math.Round(Conversions.ToDouble(val2.ExecuteScalar()) + 1.0)));
					Module1.cn_SQL.Close();
					val2.CommandText = "Select CLIENT from TABLE_NUM  where ID = 0 ";
					val2.Connection = Module1.cn_SQL;
					val2.CommandType = CommandType.Text;
					if (Module1.cn_SQL.State != ConnectionState.Open)
					{
						Module1.cn_SQL.Open();
					}
					string value = ((val2.ExecuteScalar() != DBNull.Value) ? ("CL" + Strings.Format(Conversions.ToDouble(val2.ExecuteScalar()), "000000")) : Conversions.ToString(0));
					Module1.cn_SQL.Close();
					DT.Rows.Add();
					int index = DT.Rows.Count - 1;
					DT.Rows[index]["ID"] = num;
					DT.Rows[index]["ID_CLIENT"] = value;
					DT.Rows[index]["CODE_CLIENT"] = Strings.Trim(Text_CODE_CLIENT.Text);
					DT.Rows[index]["CLIENT"] = Strings.Trim(Text_CLIENT.Text);
					DT.Rows[index]["DATES"] = DateTimePicker_DATE.Value;
					DT.Rows[index]["ICE"] = Text_ICE.Text;
					DT.Rows[index]["ADRESSE"] = Text_ADRESSE.Text;
					DT.Rows[index]["VILLE"] = Text_VILLE.Text;
					DT.Rows[index]["PAYS"] = Text_PAYS.Text;
					DT.Rows[index]["TELEPHONE"] = Text_TEL.Text;
					DT.Rows[index]["NOTES"] = Text_NOTE.Text;
					DT.Rows[index]["ETAT"] = "VALIDER";
					DT.Rows[index]["CREDIT_INITIAL"] = Text_CREDIT_INITIAL.Text;
					DT.Rows[index]["VENDEUR"] = Combo_VENDEUR.Text;
					MySqlCommandBuilder val3 = new MySqlCommandBuilder(DA);
					((DbDataAdapter)(object)DA).Update(DT);
					DT.AcceptChanges();
					if (Module1.cn_SQL.State != ConnectionState.Open)
					{
						Module1.cn_SQL.Open();
					}
					val2.CommandText = "UPDATE     TABLE_NUM    SET CLIENT =  CLIENT + 1   ";
					val2.Connection = Module1.cn_SQL;
					val2.ExecuteNonQuery();
					Module1.cn_SQL.Close();
					MessageBox.Show("Enregistré avec succès", "ok", (MessageBoxButtons)0, (MessageBoxIcon)64, (MessageBoxDefaultButton)0);
				}
				else if (Operators.CompareString(Label_TOP.Text, "MODIFICATION", TextCompare: false) == 0)
				{
					DataGridView1.CurrentCell = DataGridView1.Rows[Conversions.ToInteger(Label_INDEX.Text)].Cells[0];
					DataGridView1.Rows[Conversions.ToInteger(Label_INDEX.Text)].Selected = true;
					if (Operators.CompareString(Text_CODE_CLIENT.Text, "", TextCompare: false) != 0)
					{
						DataTable dataTable2 = new DataTable();
						MySqlDataAdapter val4 = new MySqlDataAdapter();
						dataTable2.Clear();
						val4 = new MySqlDataAdapter("select ID,CODE_CLIENT,CLIENT     from TABLE_CLIENTS WHERE   CODE_CLIENT = '" + Text_CODE_CLIENT.Text + "'    AND    ID <> " + Text_ID.Text + "    ", Module1.cn_SQL);
						((DbDataAdapter)(object)val4).Fill(dataTable2);
						if (dataTable2.Rows.Count != 0)
						{
							MessageBox.Show(Conversions.ToString(Operators.ConcatenateObject("Ce Code est déja utilisé pour ==> ", dataTable2.Rows[0]["CLIENT"])), "Attetion", (MessageBoxButtons)0, (MessageBoxIcon)48, (MessageBoxDefaultButton)0);
							return;
						}
					}
					Module1._DT_TEMP.Clear();
					Module1._DA_TEMP = new MySqlDataAdapter("select ID,ID_CLIENT     from TABLE_CLIENTS WHERE   ID_CLIENT = '" + Text_ID_CLIENT.Text + "'    AND    ID <> " + Text_ID.Text + "    ", Module1.cn_SQL);
					((DbDataAdapter)(object)Module1._DA_TEMP).Fill(Module1._DT_TEMP);
					if (Module1._DT_TEMP.Rows.Count != 0)
					{
						MessageBox.Show("Cet ID est déja utilisé", "Attetion", (MessageBoxButtons)0, (MessageBoxIcon)48, (MessageBoxDefaultButton)0);
						return;
					}
					int position = ((ContainerControl)this).BindingContext[(object)DT].Position;
					DT.Rows[position]["ID"] = Text_ID.Text;
					DT.Rows[position]["ID_CLIENT"] = Text_ID_CLIENT.Text;
					DT.Rows[position]["CODE_CLIENT"] = Strings.Trim(Text_CODE_CLIENT.Text);
					DT.Rows[position]["CLIENT"] = Strings.Trim(Text_CLIENT.Text);
					DT.Rows[position]["DATES"] = DateTimePicker_DATE.Value;
					DT.Rows[position]["ICE"] = Text_ICE.Text;
					DT.Rows[position]["ADRESSE"] = Text_ADRESSE.Text;
					DT.Rows[position]["VILLE"] = Text_VILLE.Text;
					DT.Rows[position]["PAYS"] = Text_PAYS.Text;
					DT.Rows[position]["TELEPHONE"] = Text_TEL.Text;
					DT.Rows[position]["NOTES"] = Text_NOTE.Text;
					DT.Rows[position]["ETAT"] = "VALIDER";
					DT.Rows[position]["CREDIT_INITIAL"] = Text_CREDIT_INITIAL.Text;
					DT.Rows[position]["VENDEUR"] = Combo_VENDEUR.Text;
					MySqlCommandBuilder val5 = new MySqlCommandBuilder(DA);
					((DbDataAdapter)(object)DA).Update(DT);
					DT.AcceptChanges();
					MessageBox.Show("Modifié avec succès", "ok", (MessageBoxButtons)0, (MessageBoxIcon)64, (MessageBoxDefaultButton)0);
					string right = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("MODIFICATION | ", DataGridView1.Rows[((DataGridViewBand)DataGridView1.CurrentRow).Index].Cells["ID_CLIENT"].Value), DataGridView1.Rows[((DataGridViewBand)DataGridView1.CurrentRow).Index].Cells["CODE_CLIENT"].Value), DataGridView1.Rows[((DataGridViewBand)DataGridView1.CurrentRow).Index].Cells["CLIENT"].Value));
					File.AppendAllText(Application.StartupPath + "\\log.sni", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(Strings.Format(DateTime.Now, "ddMMyy HHmmss fff") + MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text, " | "), Module1._USERNAME), " | "), ((Control)this).Name), " | "), NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null)), " | "), right), "\r\n")), Encoding.UTF8);
				}
				((Control)Panel_INFO).Hide();
				Button_CALC_BD_Click(RuntimeHelpers.GetObjectValue(sender), e);
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
					Bitmap val6 = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, (PixelFormat)2498570);
					Graphics val7 = Graphics.FromImage((Image)(object)val6);
					val7.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, (CopyPixelOperation)13369376);
					((Image)val6).Save(Application.StartupPath + "\\tchak\\" + text + ".snidb", ImageFormat.Jpeg);
					val6 = null;
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
	}

	private void Button11_Click(object sender, EventArgs e)
	{
		((Control)Panel_INFO).Hide();
	}

	private void RadioButton1_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void RadioButton1_Click(object sender, EventArgs e)
	{
	}

	private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (e.KeyChar == '\'')
		{
			e.Handled = true;
		}
	}

	private void TextBox2_TextChanged(object sender, EventArgs e)
	{
	}

	private void TextBox5_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (e.KeyChar == '\'')
		{
			e.Handled = true;
		}
	}

	private void TextBox5_TextChanged(object sender, EventArgs e)
	{
	}

	private void TextBox8_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (e.KeyChar == '\'')
		{
			e.Handled = true;
		}
	}

	private void TextBox8_TextChanged(object sender, EventArgs e)
	{
	}

	private void TextBox6_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (e.KeyChar == '\'')
		{
			e.Handled = true;
		}
	}

	private void TextBox6_TextChanged(object sender, EventArgs e)
	{
	}

	private void RadioButton4_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void RadioButton4_Click(object sender, EventArgs e)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected Obj, but got Unknown
		try
		{
			DT.Clear();
			DA = new MySqlDataAdapter("select * from   TABLE_CLIENTS        order by   ID    desc ", Module1.cn_SQL);
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

	private void RadioButton2_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void RadioButton2_Click(object sender, EventArgs e)
	{
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		try
		{
			if (DataGridView1.Rows.Count != 0)
			{
				((Control)Panel_HISTORIQUE).Visible = true;
				((Control)Panel_HISTORIQUE).BringToFront();
				Label_HISTORIQUE_ID_CLIENT.Text = DataGridView1.Rows[((DataGridViewBand)DataGridView1.CurrentRow).Index].Cells["ID_Client"].Value.ToString();
				Label_HISTORIQUE_CLIENT.Text = DataGridView1.Rows[((DataGridViewBand)DataGridView1.CurrentRow).Index].Cells["CLIENT"].Value.ToString();
				DataGridView_VENTES.DataSource = null;
				DataGridView_REGLEMENTS.DataSource = null;
				DataGridView_DETAILS_VENTES.DataSource = null;
				Button16.PerformClick();
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

	private void Button16_Click(object sender, EventArgs e)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected Obj, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected Obj, but got Unknown
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected Obj, but got Unknown
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Expected Obj, but got Unknown
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Expected Obj, but got Unknown
		//IL_034b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0352: Expected Obj, but got Unknown
		//IL_0476: Unknown result type (might be due to invalid IL or missing references)
		//IL_047d: Expected Obj, but got Unknown
		//IL_0536: Unknown result type (might be due to invalid IL or missing references)
		//IL_053d: Expected Obj, but got Unknown
		try
		{
			DataTable dataTable = new DataTable();
			MySqlDataAdapter val = new MySqlDataAdapter();
			dataTable.Clear();
			val = new MySqlDataAdapter("select     ID_TICKET,TICKET,DATES,TOTAL_NET,OPERATION            from   TABLE_VENTES_ENTETE     Where         DATES   between   ' " + Strings.Format(DateTimePicker3.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker4.Value, "yyyy-MM-dd") + " '        AND   ID_CLIENT  =  '" + Label_HISTORIQUE_ID_CLIENT.Text + "'          AND      ( OPERATION  =  'CREDIT'   or  OPERATION  =  'RETOUR CREDIT')         order by ID  desc ", Module1.cn_SQL);
			((DbDataAdapter)(object)val).Fill(dataTable);
			DataGridView_VENTES.DataSource = dataTable;
			DataTable dataTable2 = new DataTable();
			MySqlDataAdapter val2 = new MySqlDataAdapter();
			dataTable2.Clear();
			val2 = new MySqlDataAdapter("select     ID_REGLE,DATES,MONTANT,NOTES           from   TABLE_CLIENTS_REGLE     Where         DATES   between   ' " + Strings.Format(DateTimePicker3.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker4.Value, "yyyy-MM-dd") + " '        AND     ID_CLIENT  =  '" + Label_HISTORIQUE_ID_CLIENT.Text + "'                 order by ID  desc ", Module1.cn_SQL);
			((DbDataAdapter)(object)val2).Fill(dataTable2);
			DataGridView_REGLEMENTS.DataSource = dataTable2;
			DataTable dataTable3 = new DataTable();
			MySqlDataAdapter val3 = new MySqlDataAdapter();
			dataTable3.Clear();
			val3 = new MySqlDataAdapter("SELECT    SUM(TOTAL_NET)      as N          FROM   TABLE_VENTES_ENTETE     WHERE       DATES   between   ' " + Strings.Format(DateTimePicker3.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker4.Value, "yyyy-MM-dd") + " '     AND     ID_CLIENT  =  '" + Label_HISTORIQUE_ID_CLIENT.Text + "'        AND     OPERATION  =  'CREDIT'           ", Module1.cn_SQL);
			((DbDataAdapter)(object)val3).Fill(dataTable3);
			decimal num = 0m;
			num = ((dataTable3.Rows[0]["N"] != DBNull.Value) ? Conversions.ToDecimal(Strings.FormatNumber(RuntimeHelpers.GetObjectValue(dataTable3.Rows[0]["N"]))) : Conversions.ToDecimal(Strings.FormatNumber(0)));
			Label_VENTE_CREDIT.Text = Conversions.ToString(num);
			dataTable3.Clear();
			val3 = new MySqlDataAdapter("SELECT    SUM(TOTAL_NET)      as N          FROM   TABLE_VENTES_ENTETE     WHERE        DATES   between   ' " + Strings.Format(DateTimePicker3.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker4.Value, "yyyy-MM-dd") + " '     AND     ID_CLIENT  =  '" + Label_HISTORIQUE_ID_CLIENT.Text + "'        AND      OPERATION  =  'RETOUR CREDIT'       ", Module1.cn_SQL);
			((DbDataAdapter)(object)val3).Fill(dataTable3);
			decimal num2 = 0m;
			num2 = ((dataTable3.Rows[0]["N"] != DBNull.Value) ? Conversions.ToDecimal(Strings.FormatNumber(RuntimeHelpers.GetObjectValue(dataTable3.Rows[0]["N"]))) : Conversions.ToDecimal(Strings.FormatNumber(0)));
			Label_RETOUR_CREDIT.Text = Conversions.ToString(num2);
			dataTable3.Clear();
			val3 = new MySqlDataAdapter("select    SUM(MONTANT)      as N           from   TABLE_CLIENTS_REGLE       WHERE      DATES   between   ' " + Strings.Format(DateTimePicker3.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker4.Value, "yyyy-MM-dd") + " '        AND     ID_CLIENT  =  '" + Label_HISTORIQUE_ID_CLIENT.Text + "'                 ", Module1.cn_SQL);
			((DbDataAdapter)(object)val3).Fill(dataTable3);
			decimal num3 = 0m;
			num3 = ((dataTable3.Rows[0]["N"] != DBNull.Value) ? Conversions.ToDecimal(Strings.FormatNumber(RuntimeHelpers.GetObjectValue(dataTable3.Rows[0]["N"]))) : Conversions.ToDecimal(Strings.FormatNumber(0)));
			Label_REGLE_CLIENT.Text = Conversions.ToString(num3);
			dataTable3.Clear();
			val3 = new MySqlDataAdapter("select    SUM(CREDIT_INITIAL)      as N           from   TABLE_CLIENTS       WHERE       ID_CLIENT  =  '" + Label_HISTORIQUE_ID_CLIENT.Text + "'                 ", Module1.cn_SQL);
			((DbDataAdapter)(object)val3).Fill(dataTable3);
			decimal num4 = 0m;
			num4 = ((dataTable3.Rows[0]["N"] != DBNull.Value) ? Conversions.ToDecimal(Strings.FormatNumber(RuntimeHelpers.GetObjectValue(dataTable3.Rows[0]["N"]))) : Conversions.ToDecimal(Strings.FormatNumber(0)));
			Label_CREDIT_INITIAL.Text = Conversions.ToString(num4);
			Label_CREDIT.Text = Conversions.ToString(decimal.Add(decimal.Add(num, num2), num4));
			Label_REGLE.Text = Conversions.ToString(num3);
			Label_BALANCE.Text = Conversions.ToString(decimal.Subtract(decimal.Add(decimal.Add(num, num2), num4), num3)) + " DH";
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

	private void Button2_Click(object sender, EventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected Obj, but got Unknown
		try
		{
			DataTable dataTable = new DataTable();
			MySqlDataAdapter val = new MySqlDataAdapter();
			dataTable.Clear();
			val = new MySqlDataAdapter("select     *            from   TABLE_VENTES_JOURNAL     Where     DATES   between   ' " + Strings.Format(DateTimePicker5.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker6.Value, "yyyy-MM-dd") + " '       and    ID_CLIENT  =  '" + Label_HISTORIQUE_ID_CLIENT.Text + "'           order by ID  desc ", Module1.cn_SQL);
			((DbDataAdapter)(object)val).Fill(dataTable);
			DataGridView_DETAILS_VENTES.DataSource = dataTable;
			_COLORISE_DATAGRID();
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

	private void Button3_Click(object sender, EventArgs e)
	{
		((Control)Panel_HISTORIQUE).Hide();
	}

	private void Button_PrintRapport_2_Click(object sender, EventArgs e)
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected Obj, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected Obj, but got Unknown
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected Obj, but got Unknown
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected Obj, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected Obj, but got Unknown
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Expected Obj, but got Unknown
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected Obj, but got Unknown
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Expected Obj, but got Unknown
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_032d: Expected Obj, but got Unknown
		//IL_04d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04dd: Expected Obj, but got Unknown
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
				((Report)MyProject.Forms.Report_CLIENTS_ETAT_HISTORIQUE.ReportViewer1.LocalReport).SetParameters(new ReportParameter("DATES", DateTimePicker3.Text + " --> " + DateTimePicker4.Text));
				((Report)MyProject.Forms.Report_CLIENTS_ETAT_HISTORIQUE.ReportViewer1.LocalReport).SetParameters(new ReportParameter("ID_CLIENT", Label_HISTORIQUE_ID_CLIENT.Text));
				((Report)MyProject.Forms.Report_CLIENTS_ETAT_HISTORIQUE.ReportViewer1.LocalReport).SetParameters(new ReportParameter("CLIENT", Label_HISTORIQUE_CLIENT.Text));
				((Report)MyProject.Forms.Report_CLIENTS_ETAT_HISTORIQUE.ReportViewer1.LocalReport).SetParameters(new ReportParameter("CREDIT", Label_VENTE_CREDIT.Text));
				((Report)MyProject.Forms.Report_CLIENTS_ETAT_HISTORIQUE.ReportViewer1.LocalReport).SetParameters(new ReportParameter("RETOUR_CREDIT", Label_RETOUR_CREDIT.Text));
				((Report)MyProject.Forms.Report_CLIENTS_ETAT_HISTORIQUE.ReportViewer1.LocalReport).SetParameters(new ReportParameter("CREDIT_INITIAL", Label_CREDIT_INITIAL.Text));
				((Report)MyProject.Forms.Report_CLIENTS_ETAT_HISTORIQUE.ReportViewer1.LocalReport).SetParameters(new ReportParameter("REGLE_CLIENT", Label_REGLE_CLIENT.Text));
				((Report)MyProject.Forms.Report_CLIENTS_ETAT_HISTORIQUE.ReportViewer1.LocalReport).SetParameters(new ReportParameter("BALANCE", Label_BALANCE.Text));
				DataTable dataTable = new DataTable();
				int num = ((BaseCollection)DataGridView_VENTES.Columns).Count - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					dataTable.Columns.Add(DataGridView_VENTES.Columns[num2].Name.ToString());
					dataTable.Columns[DataGridView_VENTES.Columns[num2].Name.ToString()].Caption = DataGridView_VENTES.Columns[num2].HeaderText.ToString();
					num2++;
				}
				int num5 = DataGridView_VENTES.Rows.Count - 1;
				y = 0;
				while (true)
				{
					int num6 = y;
					int num4 = num5;
					if (num6 > num4)
					{
						break;
					}
					dataTable.Rows.Add();
					int num7 = ((BaseCollection)DataGridView_VENTES.Columns).Count - 1;
					int num8 = 0;
					while (true)
					{
						int num9 = num8;
						num4 = num7;
						if (num9 > num4)
						{
							break;
						}
						dataTable.Rows[y][num8] = DataGridView_VENTES.Rows[y].Cells[num8].Value.ToString();
						num8++;
					}
					y++;
				}
				ReportDataSource item = new ReportDataSource("DataSet1", dataTable);
				((Collection<ReportDataSource>)(object)MyProject.Forms.Report_CLIENTS_ETAT_HISTORIQUE.ReportViewer1.LocalReport.DataSources).Clear();
				((Collection<ReportDataSource>)(object)MyProject.Forms.Report_CLIENTS_ETAT_HISTORIQUE.ReportViewer1.LocalReport.DataSources).Add(item);
				DataTable dataTable2 = new DataTable();
				int num10 = ((BaseCollection)DataGridView_REGLEMENTS.Columns).Count - 1;
				int num11 = 0;
				while (true)
				{
					int num12 = num11;
					int num4 = num10;
					if (num12 > num4)
					{
						break;
					}
					dataTable2.Columns.Add(DataGridView_REGLEMENTS.Columns[num11].Name.ToString());
					dataTable2.Columns[DataGridView_REGLEMENTS.Columns[num11].Name.ToString()].Caption = DataGridView_REGLEMENTS.Columns[num11].HeaderText.ToString();
					num11++;
				}
				int num13 = DataGridView_REGLEMENTS.Rows.Count - 1;
				y = 0;
				while (true)
				{
					int num14 = y;
					int num4 = num13;
					if (num14 > num4)
					{
						break;
					}
					dataTable2.Rows.Add();
					int num15 = ((BaseCollection)DataGridView_REGLEMENTS.Columns).Count - 1;
					int num16 = 0;
					while (true)
					{
						int num17 = num16;
						num4 = num15;
						if (num17 > num4)
						{
							break;
						}
						dataTable2.Rows[y][num16] = DataGridView_REGLEMENTS.Rows[y].Cells[num16].Value.ToString();
						num16++;
					}
					y++;
				}
				ReportDataSource item2 = new ReportDataSource("DataSet2", dataTable2);
				((Collection<ReportDataSource>)(object)MyProject.Forms.Report_CLIENTS_ETAT_HISTORIQUE.ReportViewer1.LocalReport.DataSources).Add(item2);
				MyProject.Forms.Report_CLIENTS_ETAT_HISTORIQUE.ReportViewer1.RefreshReport();
				MyProject.Forms.Report_CLIENTS_ETAT_HISTORIQUE.ReportViewer1.SetDisplayMode((DisplayMode)1);
				MyProject.Forms.Report_CLIENTS_ETAT_HISTORIQUE.ReportViewer1.ZoomMode = (ZoomMode)2;
				MyProject.Forms.Report_CLIENTS_ETAT_HISTORIQUE.ReportViewer1.ZoomPercent = 25;
				((Control)MyProject.Forms.Report_CLIENTS_ETAT_HISTORIQUE).Show();
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
		//IL_03ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b3: Expected Obj, but got Unknown
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
			Button_CALC_BD_Click(RuntimeHelpers.GetObjectValue(sender), e);
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
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected Obj, but got Unknown
		try
		{
			NewLateBinding.LateCall(sender, null, "Focus", new object[0], null, null, null, IgnoreReturn: true);
			Text_FIND.Texts = "";
			((Control)Text_FIND).Focus();
			DT.Clear();
			DA = new MySqlDataAdapter("select * from      TABLE_" + Label_TABLE.Text + "                  order by   ID    desc ", Module1.cn_SQL);
			((DbDataAdapter)(object)DA).Fill(DT);
			DataGridView1.DataSource = DT;
			Button_CALC_BD_Click(RuntimeHelpers.GetObjectValue(sender), e);
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

	private void Text_SOLDE_INITIAL_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (((Operators.CompareString(Conversions.ToString(e.KeyChar), "0", TextCompare: false) < 0) | (Operators.CompareString(Conversions.ToString(e.KeyChar), "9", TextCompare: false) > 0)) & (e.KeyChar != '\b') & (e.KeyChar != '.') & (e.KeyChar != '-'))
		{
			e.Handled = true;
		}
	}

	private void Text_CREDIT_INITIAL_TextChanged(object sender, EventArgs e)
	{
	}

	private void Button_CREDIT_INITIAL_MODIF_Click(object sender, EventArgs e)
	{
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		if (!((Control)Text_CREDIT_INITIAL).Enabled)
		{
			MyProject.Forms.Form_5_CLIENTS_MODIFICATION_CREDIT_INITIAL.Text_ID_CLIENT.Text = Text_ID_CLIENT.Text;
			MyProject.Forms.Form_5_CLIENTS_MODIFICATION_CREDIT_INITIAL.Text_CLIENT.Text = Text_CLIENT.Text;
			MyProject.Forms.Form_5_CLIENTS_MODIFICATION_CREDIT_INITIAL.Text_VALEUR_ANCIENNE.Text = Text_CREDIT_INITIAL.Text;
			MyProject.Forms.Form_5_CLIENTS_MODIFICATION_CREDIT_INITIAL.Text_VALEUR_NOUVELLE.Text = "";
			((Control)Panel_INFO).Hide();
			((Form)MyProject.Forms.Form_5_CLIENTS_MODIFICATION_CREDIT_INITIAL).ShowDialog();
		}
	}

	private void Button_FONCTIONS_Click(object sender, EventArgs e)
	{
		if (!((Control)Panel_FONCTIONS).Visible)
		{
			((Control)Panel_FONCTIONS).Visible = true;
			((Control)Panel_FONCTIONS).BringToFront();
		}
		else
		{
			((Control)Panel_FONCTIONS).Visible = false;
		}
	}

	private void Button_PDF_Click(object sender, EventArgs e)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		((Control)Panel_FONCTIONS).Visible = false;
		((Form)MyProject.Forms.Form_5_CLIENTS_HISTORIQUE_CREDIT_INITIAL).ShowDialog();
	}

	private void Button_CALC_BD_Click(object sender, EventArgs e)
	{
		if (DataGridView1.Rows.Count > 0)
		{
			Label_TOTAL_LIGNES_BD.Text = Conversions.ToString(Conversions.ToDouble(DataGridView1.CurrentCell.RowIndex.ToString()) + 1.0) + "/" + Conversions.ToString(DataGridView1.Rows.Count);
		}
		else
		{
			Label_TOTAL_LIGNES_BD.Text = Conversions.ToString(0) + "/" + Conversions.ToString(0);
		}
		Label4141.Text = "Nbr CLIENTS : " + Conversions.ToString(DataGridView1.Rows.Count);
	}

	private void Button4_Click(object sender, EventArgs e)
	{
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected Obj, but got Unknown
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected Obj, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected Obj, but got Unknown
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Expected Obj, but got Unknown
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
				((Report)MyProject.Forms.Report_CLIENTS_ETAT_HISTORIQUE_DETAILS.ReportViewer1.LocalReport).SetParameters(new ReportParameter("DATES", DateTimePicker5.Text + " --> " + DateTimePicker6.Text));
				((Report)MyProject.Forms.Report_CLIENTS_ETAT_HISTORIQUE_DETAILS.ReportViewer1.LocalReport).SetParameters(new ReportParameter("ID_CLIENT", Label_HISTORIQUE_ID_CLIENT.Text));
				((Report)MyProject.Forms.Report_CLIENTS_ETAT_HISTORIQUE_DETAILS.ReportViewer1.LocalReport).SetParameters(new ReportParameter("CLIENT", Label_HISTORIQUE_CLIENT.Text));
				DataTable dataTable = new DataTable();
				int num = ((BaseCollection)DataGridView_DETAILS_VENTES.Columns).Count - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					dataTable.Columns.Add(DataGridView_DETAILS_VENTES.Columns[num2].Name.ToString());
					dataTable.Columns[DataGridView_DETAILS_VENTES.Columns[num2].Name.ToString()].Caption = DataGridView_DETAILS_VENTES.Columns[num2].HeaderText.ToString();
					num2++;
				}
				int num5 = DataGridView_DETAILS_VENTES.Rows.Count - 1;
				y = 0;
				while (true)
				{
					int num6 = y;
					int num4 = num5;
					if (num6 > num4)
					{
						break;
					}
					dataTable.Rows.Add();
					int num7 = ((BaseCollection)DataGridView_DETAILS_VENTES.Columns).Count - 1;
					int num8 = 0;
					while (true)
					{
						int num9 = num8;
						num4 = num7;
						if (num9 > num4)
						{
							break;
						}
						dataTable.Rows[y][num8] = DataGridView_DETAILS_VENTES.Rows[y].Cells[num8].Value.ToString();
						num8++;
					}
					y++;
				}
				ReportDataSource item = new ReportDataSource("DataSet1", dataTable);
				((Collection<ReportDataSource>)(object)MyProject.Forms.Report_CLIENTS_ETAT_HISTORIQUE_DETAILS.ReportViewer1.LocalReport.DataSources).Clear();
				((Collection<ReportDataSource>)(object)MyProject.Forms.Report_CLIENTS_ETAT_HISTORIQUE_DETAILS.ReportViewer1.LocalReport.DataSources).Add(item);
				MyProject.Forms.Report_CLIENTS_ETAT_HISTORIQUE_DETAILS.ReportViewer1.RefreshReport();
				MyProject.Forms.Report_CLIENTS_ETAT_HISTORIQUE_DETAILS.ReportViewer1.SetDisplayMode((DisplayMode)1);
				MyProject.Forms.Report_CLIENTS_ETAT_HISTORIQUE_DETAILS.ReportViewer1.ZoomMode = (ZoomMode)2;
				MyProject.Forms.Report_CLIENTS_ETAT_HISTORIQUE_DETAILS.ReportViewer1.ZoomPercent = 25;
				((Control)MyProject.Forms.Report_CLIENTS_ETAT_HISTORIQUE_DETAILS).Show();
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

	private void Check_FIND_DATE_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
	{
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
