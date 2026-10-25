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
public class Form_6_FOURNISSEURS : Form
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

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("Text_NOTE")]
	private TextBox _Text_NOTE;

	[AccessedThroughProperty("Text_TEL")]
	private TextBox _Text_TEL;

	[AccessedThroughProperty("Text_VILLE")]
	private TextBox _Text_VILLE;

	[AccessedThroughProperty("Text_ADRESSE")]
	private TextBox _Text_ADRESSE;

	[AccessedThroughProperty("Text_FOURNISSEUR")]
	private TextBox _Text_FOURNISSEUR;

	[AccessedThroughProperty("Text_CODE_FOURNISSEUR")]
	private TextBox _Text_CODE_FOURNISSEUR;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label9")]
	private Label _Label9;

	[AccessedThroughProperty("Label10")]
	private Label _Label10;

	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	[AccessedThroughProperty("Label24")]
	private Label _Label24;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Text_ID")]
	private TextBox _Text_ID;

	[AccessedThroughProperty("TabControl1")]
	private TabControl _TabControl1;

	[AccessedThroughProperty("TabPage1")]
	private TabPage _TabPage1;

	[AccessedThroughProperty("Text_ETAT")]
	private TextBox _Text_ETAT;

	[AccessedThroughProperty("Label19")]
	private Label _Label19;

	[AccessedThroughProperty("DateTimePicker_DATE")]
	private DateTimePicker _DateTimePicker_DATE;

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

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("Panel_HISTORIQUE")]
	private Panel _Panel_HISTORIQUE;

	[AccessedThroughProperty("Label_HISTORIQUE_ID_FOURNISSEUR")]
	private Label _Label_HISTORIQUE_ID_FOURNISSEUR;

	[AccessedThroughProperty("Button3")]
	private Button _Button3;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("Label12")]
	private Label _Label12;

	[AccessedThroughProperty("Label_HISTORIQUE_FOURNISSEUR")]
	private Label _Label_HISTORIQUE_FOURNISSEUR;

	[AccessedThroughProperty("TabControl2")]
	private TabControl _TabControl2;

	[AccessedThroughProperty("TabPage5")]
	private TabPage _TabPage5;

	[AccessedThroughProperty("PictureBox3")]
	private PictureBox _PictureBox3;

	[AccessedThroughProperty("Button16")]
	private Button _Button16;

	[AccessedThroughProperty("Label30")]
	private Label _Label30;

	[AccessedThroughProperty("Label23")]
	private Label _Label23;

	[AccessedThroughProperty("Label21")]
	private Label _Label21;

	[AccessedThroughProperty("Label_BALANCE")]
	private Label _Label_BALANCE;

	[AccessedThroughProperty("Label18")]
	private Label _Label18;

	[AccessedThroughProperty("Label_REGLE")]
	private Label _Label_REGLE;

	[AccessedThroughProperty("PictureBox2")]
	private PictureBox _PictureBox2;

	[AccessedThroughProperty("DataGridView_REGLEMENTS")]
	private DataGridView _DataGridView_REGLEMENTS;

	[AccessedThroughProperty("DataGridViewTextBoxColumn1")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn1;

	[AccessedThroughProperty("DataGridViewTextBoxColumn2")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn2;

	[AccessedThroughProperty("DataGridViewTextBoxColumn3")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn3;

	[AccessedThroughProperty("DataGridViewTextBoxColumn4")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn4;

	[AccessedThroughProperty("Label20")]
	private Label _Label20;

	[AccessedThroughProperty("DateTimePicker3")]
	private DateTimePicker _DateTimePicker3;

	[AccessedThroughProperty("DateTimePicker4")]
	private DateTimePicker _DateTimePicker4;

	[AccessedThroughProperty("Text_ID_FOURNISSEUR")]
	private TextBox _Text_ID_FOURNISSEUR;

	[AccessedThroughProperty("Label31")]
	private Label _Label31;

	[AccessedThroughProperty("Text_CREDIT_INITIAL")]
	private TextBox _Text_CREDIT_INITIAL;

	[AccessedThroughProperty("DataGridViewImageColumn1")]
	private DataGridViewImageColumn _DataGridViewImageColumn1;

	[AccessedThroughProperty("DataGridViewImageColumn2")]
	private DataGridViewImageColumn _DataGridViewImageColumn2;

	[AccessedThroughProperty("DATES")]
	private DataGridViewTextBoxColumn _DATES;

	[AccessedThroughProperty("ID_FOURNISSEUR")]
	private DataGridViewTextBoxColumn _ID_FOURNISSEUR;

	[AccessedThroughProperty("FOURNISSEUR")]
	private DataGridViewTextBoxColumn _FOURNISSEUR;

	[AccessedThroughProperty("TELEPHONE")]
	private DataGridViewTextBoxColumn _TELEPHONE;

	[AccessedThroughProperty("Notes")]
	private DataGridViewTextBoxColumn _Notes;

	[AccessedThroughProperty("ETAT")]
	private DataGridViewTextBoxColumn _ETAT;

	[AccessedThroughProperty("supp")]
	private DataGridViewImageColumn _supp;

	[AccessedThroughProperty("modi")]
	private DataGridViewImageColumn _modi;

	[AccessedThroughProperty("Label36")]
	private Label _Label36;

	[AccessedThroughProperty("Button_CREDIT_INITIAL_MODIF")]
	private Button _Button_CREDIT_INITIAL_MODIF;

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

	[AccessedThroughProperty("Button_FONCTIONS")]
	private Button _Button_FONCTIONS;

	[AccessedThroughProperty("Text_PAYS")]
	private TextBox _Text_PAYS;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

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

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	[AccessedThroughProperty("Combo_FIND")]
	private BunifuDropdown _Combo_FIND;

	[AccessedThroughProperty("Picture_EXPORT")]
	private Button_RJ _Picture_EXPORT;

	[AccessedThroughProperty("Label26")]
	private Label _Label26;

	[AccessedThroughProperty("Label11")]
	private Label _Label11;

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

	[AccessedThroughProperty("Panel112233")]
	private Panel _Panel112233;

	[AccessedThroughProperty("Label_TOTAL_LIGNES_BD")]
	private Label _Label_TOTAL_LIGNES_BD;

	[AccessedThroughProperty("Button_CALC_BD")]
	private Button _Button_CALC_BD;

	[AccessedThroughProperty("Label4141")]
	private Label _Label4141;

	[AccessedThroughProperty("Label28")]
	private Label _Label28;

	[AccessedThroughProperty("Label14")]
	private Label _Label14;

	[AccessedThroughProperty("Label13")]
	private Label _Label13;

	[AccessedThroughProperty("Label_CREDIT_INITIAL")]
	private Label _Label_CREDIT_INITIAL;

	[AccessedThroughProperty("Label_SORTIES")]
	private Label _Label_SORTIES;

	[AccessedThroughProperty("Label_RECEPETIONS")]
	private Label _Label_RECEPETIONS;

	[AccessedThroughProperty("Label16")]
	private Label _Label16;

	[AccessedThroughProperty("Label15")]
	private Label _Label15;

	[AccessedThroughProperty("Label29")]
	private Label _Label29;

	[AccessedThroughProperty("Label_CREDIT")]
	private Label _Label_CREDIT;

	[AccessedThroughProperty("Label_REGLE_FOURNISSEUR")]
	private Label _Label_REGLE_FOURNISSEUR;

	[AccessedThroughProperty("Label17")]
	private Label _Label17;

	[AccessedThroughProperty("TabPage2")]
	private TabPage _TabPage2;

	[AccessedThroughProperty("PictureBox4")]
	private PictureBox _PictureBox4;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[AccessedThroughProperty("DateTimePicker5")]
	private DateTimePicker _DateTimePicker5;

	[AccessedThroughProperty("DateTimePicker6")]
	private DateTimePicker _DateTimePicker6;

	[AccessedThroughProperty("DataGridView_DETAILS_RECEPTIONS")]
	private DataGridView _DataGridView_DETAILS_RECEPTIONS;

	[AccessedThroughProperty("DataGridView_DETAILS_SORTIES")]
	private DataGridView _DataGridView_DETAILS_SORTIES;

	[AccessedThroughProperty("DataGridViewTextBoxColumn8")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn8;

	[AccessedThroughProperty("DataGridViewTextBoxColumn9")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn9;

	[AccessedThroughProperty("DataGridViewTextBoxColumn11")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn11;

	[AccessedThroughProperty("DataGridViewTextBoxColumn12")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn12;

	[AccessedThroughProperty("DataGridViewTextBoxColumn13")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn13;

	[AccessedThroughProperty("DataGridViewTextBoxColumn14")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn14;

	[AccessedThroughProperty("DataGridViewTextBoxColumn15")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn15;

	[AccessedThroughProperty("DataGridViewTextBoxColumn16")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn16;

	[AccessedThroughProperty("DESTINATION")]
	private DataGridViewTextBoxColumn _DESTINATION;

	[AccessedThroughProperty("ID_BRr")]
	private DataGridViewTextBoxColumn _ID_BRr;

	[AccessedThroughProperty("DataGridViewTextBoxColumn7")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn7;

	[AccessedThroughProperty("Code")]
	private DataGridViewTextBoxColumn _Code;

	[AccessedThroughProperty("Article")]
	private DataGridViewTextBoxColumn _Article;

	[AccessedThroughProperty("Prix_A")]
	private DataGridViewTextBoxColumn _Prix_A;

	[AccessedThroughProperty("Qté")]
	private DataGridViewTextBoxColumn _Qté;

	[AccessedThroughProperty("TOTAL_NET_ACHATSS")]
	private DataGridViewTextBoxColumn _TOTAL_NET_ACHATSS;

	[AccessedThroughProperty("ETATT")]
	private DataGridViewTextBoxColumn _ETATT;

	[AccessedThroughProperty("Button_CLAVIER")]
	private Button_CLAVIER_NOSELECT _Button_CLAVIER;

	[AccessedThroughProperty("DataGridView_RECE_SORT")]
	private DataGridView _DataGridView_RECE_SORT;

	[AccessedThroughProperty("ID_DOC")]
	private DataGridViewTextBoxColumn _ID_DOC;

	[AccessedThroughProperty("DATES_RECE_SORT")]
	private DataGridViewTextBoxColumn _DATES_RECE_SORT;

	[AccessedThroughProperty("TOTAL_NET_ACHATS")]
	private DataGridViewTextBoxColumn _TOTAL_NET_ACHATS;

	[AccessedThroughProperty("TYPE")]
	private DataGridViewTextBoxColumn _TYPE;

	[AccessedThroughProperty("Button_PrintRapport_2")]
	private Button _Button_PrintRapport_2;

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
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			EventHandler eventHandler = TextBox6_TextChanged;
			KeyPressEventHandler val = TextBox6_KeyPress;
			if (_Text_NOTE != null)
			{
				((Control)_Text_NOTE).TextChanged -= eventHandler;
				((Control)_Text_NOTE).KeyPress -= val;
			}
			_Text_NOTE = value;
			if (_Text_NOTE != null)
			{
				((Control)_Text_NOTE).TextChanged += eventHandler;
				((Control)_Text_NOTE).KeyPress += val;
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

	internal virtual TextBox Text_FOURNISSEUR
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_FOURNISSEUR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			EventHandler eventHandler = TextBox2_TextChanged;
			KeyPressEventHandler val = TextBox2_KeyPress;
			if (_Text_FOURNISSEUR != null)
			{
				((Control)_Text_FOURNISSEUR).TextChanged -= eventHandler;
				((Control)_Text_FOURNISSEUR).KeyPress -= val;
			}
			_Text_FOURNISSEUR = value;
			if (_Text_FOURNISSEUR != null)
			{
				((Control)_Text_FOURNISSEUR).TextChanged += eventHandler;
				((Control)_Text_FOURNISSEUR).KeyPress += val;
			}
		}
	}

	internal virtual TextBox Text_CODE_FOURNISSEUR
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_CODE_FOURNISSEUR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_CODE_FOURNISSEUR = value;
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

	internal virtual Label Label_HISTORIQUE_ID_FOURNISSEUR
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_HISTORIQUE_ID_FOURNISSEUR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_HISTORIQUE_ID_FOURNISSEUR = value;
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

	internal virtual Label Label_HISTORIQUE_FOURNISSEUR
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_HISTORIQUE_FOURNISSEUR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_HISTORIQUE_FOURNISSEUR = value;
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

	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn4
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridViewTextBoxColumn4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGridViewTextBoxColumn4 = value;
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

	internal virtual TextBox Text_ID_FOURNISSEUR
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_ID_FOURNISSEUR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_ID_FOURNISSEUR = value;
		}
	}

	internal virtual Label Label31
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label31;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label31 = value;
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
			_Text_CREDIT_INITIAL = value;
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

	internal virtual DataGridViewTextBoxColumn ID_FOURNISSEUR
	{
		[DebuggerNonUserCode]
		get
		{
			return _ID_FOURNISSEUR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ID_FOURNISSEUR = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn FOURNISSEUR
	{
		[DebuggerNonUserCode]
		get
		{
			return _FOURNISSEUR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_FOURNISSEUR = value;
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

	internal virtual DataGridViewTextBoxColumn Notes
	{
		[DebuggerNonUserCode]
		get
		{
			return _Notes;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Notes = value;
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

	internal virtual Label Label_SORTIES
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_SORTIES;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_SORTIES = value;
		}
	}

	internal virtual Label Label_RECEPETIONS
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_RECEPETIONS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_RECEPETIONS = value;
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

	internal virtual Label Label_REGLE_FOURNISSEUR
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_REGLE_FOURNISSEUR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_REGLE_FOURNISSEUR = value;
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

	internal virtual DataGridView DataGridView_DETAILS_RECEPTIONS
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridView_DETAILS_RECEPTIONS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGridView_DETAILS_RECEPTIONS = value;
		}
	}

	internal virtual DataGridView DataGridView_DETAILS_SORTIES
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridView_DETAILS_SORTIES;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGridView_DETAILS_SORTIES = value;
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

	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn11
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridViewTextBoxColumn11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGridViewTextBoxColumn11 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn12
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridViewTextBoxColumn12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGridViewTextBoxColumn12 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn13
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridViewTextBoxColumn13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGridViewTextBoxColumn13 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn14
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridViewTextBoxColumn14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGridViewTextBoxColumn14 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn15
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridViewTextBoxColumn15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGridViewTextBoxColumn15 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn16
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridViewTextBoxColumn16;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGridViewTextBoxColumn16 = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn DESTINATION
	{
		[DebuggerNonUserCode]
		get
		{
			return _DESTINATION;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DESTINATION = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn ID_BRr
	{
		[DebuggerNonUserCode]
		get
		{
			return _ID_BRr;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ID_BRr = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn7
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridViewTextBoxColumn7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGridViewTextBoxColumn7 = value;
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

	internal virtual DataGridViewTextBoxColumn Prix_A
	{
		[DebuggerNonUserCode]
		get
		{
			return _Prix_A;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Prix_A = value;
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

	internal virtual DataGridViewTextBoxColumn TOTAL_NET_ACHATSS
	{
		[DebuggerNonUserCode]
		get
		{
			return _TOTAL_NET_ACHATSS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TOTAL_NET_ACHATSS = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn ETATT
	{
		[DebuggerNonUserCode]
		get
		{
			return _ETATT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ETATT = value;
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

	internal virtual DataGridView DataGridView_RECE_SORT
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridView_RECE_SORT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataGridView_RECE_SORT = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn ID_DOC
	{
		[DebuggerNonUserCode]
		get
		{
			return _ID_DOC;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ID_DOC = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn DATES_RECE_SORT
	{
		[DebuggerNonUserCode]
		get
		{
			return _DATES_RECE_SORT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DATES_RECE_SORT = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn TOTAL_NET_ACHATS
	{
		[DebuggerNonUserCode]
		get
		{
			return _TOTAL_NET_ACHATS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TOTAL_NET_ACHATS = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn TYPE
	{
		[DebuggerNonUserCode]
		get
		{
			return _TYPE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TYPE = value;
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

	public Form_6_FOURNISSEURS()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected Obj, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected Obj, but got Unknown
		((Control)this).KeyDown += me_KeyDown;
		((Form)this).FormClosed += Form_6_MOUVEMENTS_STOCK_FormClosed;
		((Form)this).Load += FormDialog_famille_Load;
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
		//IL_0594: Unknown result type (might be due to invalid IL or missing references)
		//IL_059e: Expected Obj, but got Unknown
		//IL_05a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05aa: Expected Obj, but got Unknown
		//IL_05ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b6: Expected Obj, but got Unknown
		//IL_05b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c2: Expected Obj, but got Unknown
		//IL_05c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ce: Expected Obj, but got Unknown
		//IL_05d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05da: Expected Obj, but got Unknown
		//IL_05dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e6: Expected Obj, but got Unknown
		//IL_05e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f2: Expected Obj, but got Unknown
		//IL_05f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fe: Expected Obj, but got Unknown
		//IL_0600: Unknown result type (might be due to invalid IL or missing references)
		//IL_060a: Expected Obj, but got Unknown
		//IL_060c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0616: Expected Obj, but got Unknown
		//IL_0624: Unknown result type (might be due to invalid IL or missing references)
		//IL_062e: Expected Obj, but got Unknown
		//IL_0630: Unknown result type (might be due to invalid IL or missing references)
		//IL_063a: Expected Obj, but got Unknown
		//IL_063c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0646: Expected Obj, but got Unknown
		//IL_0648: Unknown result type (might be due to invalid IL or missing references)
		//IL_0652: Expected Obj, but got Unknown
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
		//IL_06d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e2: Expected Obj, but got Unknown
		//IL_06e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ee: Expected Obj, but got Unknown
		//IL_06f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fa: Expected Obj, but got Unknown
		//IL_06fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0706: Expected Obj, but got Unknown
		//IL_0981: Unknown result type (might be due to invalid IL or missing references)
		//IL_098b: Expected Obj, but got Unknown
		//IL_0a5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a64: Expected Obj, but got Unknown
		//IL_0b29: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b33: Expected Obj, but got Unknown
		//IL_0bf5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bff: Expected Obj, but got Unknown
		//IL_0cc6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd0: Expected Obj, but got Unknown
		//IL_0da4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dae: Expected Obj, but got Unknown
		//IL_0e76: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e80: Expected Obj, but got Unknown
		//IL_0ea3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ead: Expected Obj, but got Unknown
		//IL_0ee1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ee7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f95: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f9f: Expected Obj, but got Unknown
		//IL_0fc2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fcc: Expected Obj, but got Unknown
		//IL_1004: Unknown result type (might be due to invalid IL or missing references)
		//IL_100a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1095: Unknown result type (might be due to invalid IL or missing references)
		//IL_109f: Expected Obj, but got Unknown
		//IL_13b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_13be: Unknown result type (might be due to invalid IL or missing references)
		//IL_1415: Unknown result type (might be due to invalid IL or missing references)
		//IL_141f: Expected Obj, but got Unknown
		//IL_14a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_14ab: Expected Obj, but got Unknown
		//IL_15d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_15de: Expected Obj, but got Unknown
		//IL_168d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1697: Expected Obj, but got Unknown
		//IL_173f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1749: Expected Obj, but got Unknown
		//IL_17e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_17f2: Expected Obj, but got Unknown
		//IL_1871: Unknown result type (might be due to invalid IL or missing references)
		//IL_187b: Expected Obj, but got Unknown
		//IL_1934: Unknown result type (might be due to invalid IL or missing references)
		//IL_193e: Expected Obj, but got Unknown
		//IL_19d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_19e1: Expected Obj, but got Unknown
		//IL_1a63: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a6d: Expected Obj, but got Unknown
		//IL_1b19: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b23: Expected Obj, but got Unknown
		//IL_1bcc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bd6: Expected Obj, but got Unknown
		//IL_1c54: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c5e: Expected Obj, but got Unknown
		//IL_1cfc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d06: Expected Obj, but got Unknown
		//IL_1d91: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d9b: Expected Obj, but got Unknown
		//IL_1e33: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e3d: Expected Obj, but got Unknown
		//IL_1eaa: Unknown result type (might be due to invalid IL or missing references)
		//IL_1eb4: Expected Obj, but got Unknown
		//IL_1f21: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f2b: Expected Obj, but got Unknown
		//IL_1fa6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fb0: Expected Obj, but got Unknown
		//IL_2059: Unknown result type (might be due to invalid IL or missing references)
		//IL_2063: Expected Obj, but got Unknown
		//IL_20de: Unknown result type (might be due to invalid IL or missing references)
		//IL_20e8: Expected Obj, but got Unknown
		//IL_2191: Unknown result type (might be due to invalid IL or missing references)
		//IL_219b: Expected Obj, but got Unknown
		//IL_2216: Unknown result type (might be due to invalid IL or missing references)
		//IL_2220: Expected Obj, but got Unknown
		//IL_22cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_22d6: Expected Obj, but got Unknown
		//IL_2382: Unknown result type (might be due to invalid IL or missing references)
		//IL_238c: Expected Obj, but got Unknown
		//IL_248b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2495: Expected Obj, but got Unknown
		//IL_2859: Unknown result type (might be due to invalid IL or missing references)
		//IL_2863: Expected Obj, but got Unknown
		//IL_2a6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a76: Expected Obj, but got Unknown
		//IL_2b42: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b4c: Expected Obj, but got Unknown
		//IL_2b6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b79: Expected Obj, but got Unknown
		//IL_2bad: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bb3: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c63: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c6d: Expected Obj, but got Unknown
		//IL_2d32: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d3c: Expected Obj, but got Unknown
		//IL_2dfe: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e08: Expected Obj, but got Unknown
		//IL_2ece: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ed8: Expected Obj, but got Unknown
		//IL_2fa1: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fab: Expected Obj, but got Unknown
		//IL_32bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_32c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_332a: Unknown result type (might be due to invalid IL or missing references)
		//IL_3334: Expected Obj, but got Unknown
		//IL_33e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_33ed: Expected Obj, but got Unknown
		//IL_349f: Unknown result type (might be due to invalid IL or missing references)
		//IL_34a9: Expected Obj, but got Unknown
		//IL_3564: Unknown result type (might be due to invalid IL or missing references)
		//IL_356e: Expected Obj, but got Unknown
		//IL_361d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3627: Expected Obj, but got Unknown
		//IL_36d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_36df: Expected Obj, but got Unknown
		//IL_378e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3798: Expected Obj, but got Unknown
		//IL_3847: Unknown result type (might be due to invalid IL or missing references)
		//IL_3851: Expected Obj, but got Unknown
		//IL_3900: Unknown result type (might be due to invalid IL or missing references)
		//IL_390a: Expected Obj, but got Unknown
		//IL_39b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_39c2: Expected Obj, but got Unknown
		//IL_3a5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a69: Expected Obj, but got Unknown
		//IL_3afe: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b08: Expected Obj, but got Unknown
		//IL_3b56: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3be0: Unknown result type (might be due to invalid IL or missing references)
		//IL_3bea: Expected Obj, but got Unknown
		//IL_3cae: Unknown result type (might be due to invalid IL or missing references)
		//IL_3cb8: Expected Obj, but got Unknown
		//IL_3d70: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d7a: Expected Obj, but got Unknown
		//IL_3e1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e28: Expected Obj, but got Unknown
		//IL_3f64: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f6e: Expected Obj, but got Unknown
		//IL_400c: Unknown result type (might be due to invalid IL or missing references)
		//IL_4016: Expected Obj, but got Unknown
		//IL_438f: Unknown result type (might be due to invalid IL or missing references)
		//IL_4399: Expected Obj, but got Unknown
		//IL_4420: Unknown result type (might be due to invalid IL or missing references)
		//IL_442a: Expected Obj, but got Unknown
		//IL_454e: Unknown result type (might be due to invalid IL or missing references)
		//IL_4554: Unknown result type (might be due to invalid IL or missing references)
		//IL_4a0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_4a19: Expected Obj, but got Unknown
		//IL_4aae: Unknown result type (might be due to invalid IL or missing references)
		//IL_4ab8: Expected Obj, but got Unknown
		//IL_4b06: Unknown result type (might be due to invalid IL or missing references)
		//IL_4b0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_4b92: Unknown result type (might be due to invalid IL or missing references)
		//IL_4b9c: Expected Obj, but got Unknown
		//IL_4c23: Unknown result type (might be due to invalid IL or missing references)
		//IL_4c2d: Expected Obj, but got Unknown
		//IL_5196: Unknown result type (might be due to invalid IL or missing references)
		//IL_51a0: Expected Obj, but got Unknown
		//IL_51c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_51cd: Expected Obj, but got Unknown
		//IL_52ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_52b7: Expected Obj, but got Unknown
		//IL_52da: Unknown result type (might be due to invalid IL or missing references)
		//IL_52e4: Expected Obj, but got Unknown
		//IL_54f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_54fd: Expected Obj, but got Unknown
		//IL_55c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_55cc: Expected Obj, but got Unknown
		//IL_568d: Unknown result type (might be due to invalid IL or missing references)
		//IL_5697: Expected Obj, but got Unknown
		//IL_575c: Unknown result type (might be due to invalid IL or missing references)
		//IL_5766: Expected Obj, but got Unknown
		//IL_5839: Unknown result type (might be due to invalid IL or missing references)
		//IL_5843: Expected Obj, but got Unknown
		//IL_5935: Unknown result type (might be due to invalid IL or missing references)
		//IL_593f: Expected Obj, but got Unknown
		//IL_5a1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_5a26: Expected Obj, but got Unknown
		//IL_5aee: Unknown result type (might be due to invalid IL or missing references)
		//IL_5af8: Expected Obj, but got Unknown
		//IL_5b1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_5b25: Expected Obj, but got Unknown
		//IL_5b5d: Unknown result type (might be due to invalid IL or missing references)
		//IL_5b63: Unknown result type (might be due to invalid IL or missing references)
		//IL_5df8: Unknown result type (might be due to invalid IL or missing references)
		//IL_5e02: Expected Obj, but got Unknown
		//IL_5e24: Unknown result type (might be due to invalid IL or missing references)
		//IL_5e2e: Expected Obj, but got Unknown
		//IL_5ea4: Unknown result type (might be due to invalid IL or missing references)
		//IL_5eae: Expected Obj, but got Unknown
		//IL_5ed0: Unknown result type (might be due to invalid IL or missing references)
		//IL_5eda: Expected Obj, but got Unknown
		//IL_5f4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_5f57: Expected Obj, but got Unknown
		//IL_5fdb: Unknown result type (might be due to invalid IL or missing references)
		//IL_5fe5: Expected Obj, but got Unknown
		//IL_61c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_61ce: Expected Obj, but got Unknown
		//IL_6462: Unknown result type (might be due to invalid IL or missing references)
		//IL_646c: Expected Obj, but got Unknown
		//IL_64ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_64f9: Expected Obj, but got Unknown
		//IL_6592: Unknown result type (might be due to invalid IL or missing references)
		//IL_659c: Expected Obj, but got Unknown
		//IL_6695: Unknown result type (might be due to invalid IL or missing references)
		//IL_669f: Expected Obj, but got Unknown
		//IL_6a48: Unknown result type (might be due to invalid IL or missing references)
		//IL_6a52: Expected Obj, but got Unknown
		//IL_6e36: Unknown result type (might be due to invalid IL or missing references)
		//IL_6e40: Expected Obj, but got Unknown
		//IL_6f5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_6f68: Expected Obj, but got Unknown
		//IL_703b: Unknown result type (might be due to invalid IL or missing references)
		//IL_7045: Expected Obj, but got Unknown
		//IL_7079: Unknown result type (might be due to invalid IL or missing references)
		//IL_707f: Unknown result type (might be due to invalid IL or missing references)
		//IL_70b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_70b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_724b: Unknown result type (might be due to invalid IL or missing references)
		//IL_7255: Expected Obj, but got Unknown
		//IL_73b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_73bb: Expected Obj, but got Unknown
		//IL_7498: Unknown result type (might be due to invalid IL or missing references)
		//IL_74a2: Expected Obj, but got Unknown
		//IL_7564: Unknown result type (might be due to invalid IL or missing references)
		//IL_756e: Expected Obj, but got Unknown
		//IL_7855: Unknown result type (might be due to invalid IL or missing references)
		//IL_785f: Expected Obj, but got Unknown
		//IL_7871: Unknown result type (might be due to invalid IL or missing references)
		//IL_787b: Expected Obj, but got Unknown
		//IL_7a11: Unknown result type (might be due to invalid IL or missing references)
		//IL_7a1b: Expected Obj, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form_6_FOURNISSEURS));
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
		Text_PAYS = new TextBox();
		Label1 = new Label();
		Button_CREDIT_INITIAL_MODIF = new Button();
		Label36 = new Label();
		Text_CREDIT_INITIAL = new TextBox();
		Text_ID = new TextBox();
		Text_ID_FOURNISSEUR = new TextBox();
		Label31 = new Label();
		DateTimePicker_DATE = new DateTimePicker();
		Text_ETAT = new TextBox();
		Label19 = new Label();
		Label3 = new Label();
		Text_ICE = new TextBox();
		Label7 = new Label();
		Text_NOTE = new TextBox();
		Label24 = new Label();
		Text_TEL = new TextBox();
		Text_VILLE = new TextBox();
		Text_ADRESSE = new TextBox();
		Label8 = new Label();
		Text_FOURNISSEUR = new TextBox();
		Label10 = new Label();
		Text_CODE_FOURNISSEUR = new TextBox();
		Label9 = new Label();
		Label4 = new Label();
		Label2 = new Label();
		DataGridView1 = new DataGridView();
		DATES = new DataGridViewTextBoxColumn();
		ID_FOURNISSEUR = new DataGridViewTextBoxColumn();
		FOURNISSEUR = new DataGridViewTextBoxColumn();
		TELEPHONE = new DataGridViewTextBoxColumn();
		Notes = new DataGridViewTextBoxColumn();
		ETAT = new DataGridViewTextBoxColumn();
		supp = new DataGridViewImageColumn();
		modi = new DataGridViewImageColumn();
		Label_TABLE = new Label();
		Panel_HISTORIQUE = new Panel();
		Label_HISTORIQUE_ID_FOURNISSEUR = new Label();
		Button3 = new Button();
		Label5 = new Label();
		Label6 = new Label();
		Label12 = new Label();
		Label_HISTORIQUE_FOURNISSEUR = new Label();
		TabControl2 = new TabControl();
		TabPage5 = new TabPage();
		Label_REGLE_FOURNISSEUR = new Label();
		Label17 = new Label();
		Label29 = new Label();
		Label_CREDIT = new Label();
		Label13 = new Label();
		Label_CREDIT_INITIAL = new Label();
		Label_SORTIES = new Label();
		Label_RECEPETIONS = new Label();
		Label16 = new Label();
		Label15 = new Label();
		PictureBox3 = new PictureBox();
		Button16 = new Button();
		Label30 = new Label();
		Label23 = new Label();
		Label21 = new Label();
		Label_BALANCE = new Label();
		Label18 = new Label();
		Label_REGLE = new Label();
		PictureBox2 = new PictureBox();
		DataGridView_REGLEMENTS = new DataGridView();
		DataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
		DataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
		DataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
		DataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
		Label20 = new Label();
		DateTimePicker3 = new DateTimePicker();
		DateTimePicker4 = new DateTimePicker();
		TabPage2 = new TabPage();
		DataGridView_DETAILS_SORTIES = new DataGridView();
		DataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
		DataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
		DataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
		DataGridViewTextBoxColumn12 = new DataGridViewTextBoxColumn();
		DataGridViewTextBoxColumn13 = new DataGridViewTextBoxColumn();
		DataGridViewTextBoxColumn14 = new DataGridViewTextBoxColumn();
		DataGridViewTextBoxColumn15 = new DataGridViewTextBoxColumn();
		DataGridViewTextBoxColumn16 = new DataGridViewTextBoxColumn();
		DESTINATION = new DataGridViewTextBoxColumn();
		PictureBox4 = new PictureBox();
		Button2 = new Button();
		DateTimePicker5 = new DateTimePicker();
		DateTimePicker6 = new DateTimePicker();
		DataGridView_DETAILS_RECEPTIONS = new DataGridView();
		ID_BRr = new DataGridViewTextBoxColumn();
		DataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
		Code = new DataGridViewTextBoxColumn();
		Article = new DataGridViewTextBoxColumn();
		Prix_A = new DataGridViewTextBoxColumn();
		Qté = new DataGridViewTextBoxColumn();
		TOTAL_NET_ACHATSS = new DataGridViewTextBoxColumn();
		ETATT = new DataGridViewTextBoxColumn();
		DataGridViewImageColumn1 = new DataGridViewImageColumn();
		DataGridViewImageColumn2 = new DataGridViewImageColumn();
		Button1 = new Button();
		Button_ADD = new Button();
		Panel_FONCTIONS = new Panel();
		Label41 = new Label();
		Label44 = new Label();
		Label43 = new Label();
		Label42 = new Label();
		Button_PDF = new Button();
		Button_EXCEL = new Button();
		Button_WORD = new Button();
		Button_FONCTIONS = new Button();
		Panel_FIND = new Panel();
		Panel_DATES = new Panel();
		DateTime2_FIND = new DateTimePicker();
		DateTime1_FIND = new DateTimePicker();
		Picture_FIND_DATES = new PictureBox();
		PictureBox1 = new PictureBox();
		Combo_FIND = new BunifuDropdown();
		Picture_EXPORT = new Button_RJ();
		Label26 = new Label();
		Label11 = new Label();
		Check_FIND_DATE = new BunifuCheckBox();
		Check_FIND_EXACTE = new BunifuCheckBox();
		Picture_REFRESH = new Button_RJ();
		Picture_FIND = new Button_RJ();
		Text_FIND = new RJTextBox();
		Panel112233 = new Panel();
		Label_TOTAL_LIGNES_BD = new Label();
		Button_CALC_BD = new Button();
		Label4141 = new Label();
		Label28 = new Label();
		Label14 = new Label();
		DataGridView_RECE_SORT = new DataGridView();
		ID_DOC = new DataGridViewTextBoxColumn();
		DATES_RECE_SORT = new DataGridViewTextBoxColumn();
		TOTAL_NET_ACHATS = new DataGridViewTextBoxColumn();
		TYPE = new DataGridViewTextBoxColumn();
		Button_PrintRapport_2 = new Button();
		((Control)Panel_INFO).SuspendLayout();
		((Control)TabControl1).SuspendLayout();
		((Control)TabPage1).SuspendLayout();
		((ISupportInitialize)DataGridView1).BeginInit();
		((Control)Panel_HISTORIQUE).SuspendLayout();
		((Control)TabControl2).SuspendLayout();
		((Control)TabPage5).SuspendLayout();
		((ISupportInitialize)PictureBox3).BeginInit();
		((ISupportInitialize)PictureBox2).BeginInit();
		((ISupportInitialize)DataGridView_REGLEMENTS).BeginInit();
		((Control)TabPage2).SuspendLayout();
		((ISupportInitialize)DataGridView_DETAILS_SORTIES).BeginInit();
		((ISupportInitialize)PictureBox4).BeginInit();
		((ISupportInitialize)DataGridView_DETAILS_RECEPTIONS).BeginInit();
		((Control)Panel_FONCTIONS).SuspendLayout();
		((Control)Panel_FIND).SuspendLayout();
		((Control)Panel_DATES).SuspendLayout();
		((ISupportInitialize)Picture_FIND_DATES).BeginInit();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)Panel112233).SuspendLayout();
		((ISupportInitialize)DataGridView_RECE_SORT).BeginInit();
		((Control)this).SuspendLayout();
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
		Point location = new Point(190, 72);
		((Control)panel_INFO).Location = location;
		((Control)Panel_INFO).Name = "Panel_INFO";
		Panel panel_INFO2 = Panel_INFO;
		Size size = new Size(644, 438);
		((Control)panel_INFO2).Size = size;
		((Control)Panel_INFO).TabIndex = 808;
		((Control)Panel_INFO).Visible = false;
		((Control)Button_CLAVIER).BackgroundImage = (Image)componentResourceManager.GetObject("Button_CLAVIER.BackgroundImage");
		((Control)Button_CLAVIER).BackgroundImageLayout = (ImageLayout)4;
		((ButtonBase)Button_CLAVIER).ImeMode = (ImeMode)0;
		Button_CLAVIER_NOSELECT button_CLAVIER = Button_CLAVIER;
		location = new Point(303, 398);
		((Control)button_CLAVIER).Location = location;
		((Control)Button_CLAVIER).Name = "Button_CLAVIER";
		Button_CLAVIER_NOSELECT button_CLAVIER2 = Button_CLAVIER;
		size = new Size(36, 31);
		((Control)button_CLAVIER2).Size = size;
		((Control)Button_CLAVIER).TabIndex = 1030;
		((ButtonBase)Button_CLAVIER).UseVisualStyleBackColor = true;
		((Control)Label_BOTTOM).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label_BOTTOM).Cursor = Cursors.Hand;
		((Control)Label_BOTTOM).Dock = (DockStyle)2;
		((Control)Label_BOTTOM).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label_BOTTOM).ForeColor = Color.White;
		Label label_BOTTOM = Label_BOTTOM;
		location = new Point(4, 432);
		((Control)label_BOTTOM).Location = location;
		((Control)Label_BOTTOM).Name = "Label_BOTTOM";
		Label label_BOTTOM2 = Label_BOTTOM;
		size = new Size(634, 4);
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
		size = new Size(4, 412);
		((Control)label_LEFT2).Size = size;
		((Control)Label_LEFT).TabIndex = 865;
		Label_LEFT.TextAlign = (ContentAlignment)16;
		((Control)Label_RIGHT).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label_RIGHT).Cursor = Cursors.Hand;
		((Control)Label_RIGHT).Dock = (DockStyle)4;
		((Control)Label_RIGHT).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label_RIGHT).ForeColor = Color.White;
		Label label_RIGHT = Label_RIGHT;
		location = new Point(638, 24);
		((Control)label_RIGHT).Location = location;
		((Control)Label_RIGHT).Name = "Label_RIGHT";
		Label label_RIGHT2 = Label_RIGHT;
		size = new Size(4, 412);
		((Control)label_RIGHT2).Size = size;
		((Control)Label_RIGHT).TabIndex = 864;
		Label_RIGHT.TextAlign = (ContentAlignment)16;
		((Control)Label_INDEX).Anchor = (AnchorStyles)9;
		((Control)Label_INDEX).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label_INDEX).Cursor = Cursors.Hand;
		((Control)Label_INDEX).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label_INDEX).ForeColor = Color.White;
		Label label_INDEX = Label_INDEX;
		location = new Point(606, 0);
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
		size = new Size(642, 24);
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
		location = new Point(7, 398);
		((Control)button_CLOSE).Location = location;
		Button button_CLOSE2 = Button_CLOSE;
		Padding margin = new Padding(0);
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
		location = new Point(476, 398);
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
		size = new Size(633, 369);
		((Control)tabControl3).Size = size;
		((Control)TabControl1).TabIndex = 0;
		TabPage1.BackColor = Color.White;
		((Control)TabPage1).Controls.Add((Control)(object)Text_PAYS);
		((Control)TabPage1).Controls.Add((Control)(object)Label1);
		((Control)TabPage1).Controls.Add((Control)(object)Button_CREDIT_INITIAL_MODIF);
		((Control)TabPage1).Controls.Add((Control)(object)Label36);
		((Control)TabPage1).Controls.Add((Control)(object)Text_CREDIT_INITIAL);
		((Control)TabPage1).Controls.Add((Control)(object)Text_ID);
		((Control)TabPage1).Controls.Add((Control)(object)Text_ID_FOURNISSEUR);
		((Control)TabPage1).Controls.Add((Control)(object)Label31);
		((Control)TabPage1).Controls.Add((Control)(object)DateTimePicker_DATE);
		((Control)TabPage1).Controls.Add((Control)(object)Text_ETAT);
		((Control)TabPage1).Controls.Add((Control)(object)Label19);
		((Control)TabPage1).Controls.Add((Control)(object)Label3);
		((Control)TabPage1).Controls.Add((Control)(object)Text_ICE);
		((Control)TabPage1).Controls.Add((Control)(object)Label7);
		((Control)TabPage1).Controls.Add((Control)(object)Text_NOTE);
		((Control)TabPage1).Controls.Add((Control)(object)Label24);
		((Control)TabPage1).Controls.Add((Control)(object)Text_TEL);
		((Control)TabPage1).Controls.Add((Control)(object)Text_VILLE);
		((Control)TabPage1).Controls.Add((Control)(object)Text_ADRESSE);
		((Control)TabPage1).Controls.Add((Control)(object)Label8);
		((Control)TabPage1).Controls.Add((Control)(object)Text_FOURNISSEUR);
		((Control)TabPage1).Controls.Add((Control)(object)Label10);
		((Control)TabPage1).Controls.Add((Control)(object)Text_CODE_FOURNISSEUR);
		((Control)TabPage1).Controls.Add((Control)(object)Label9);
		((Control)TabPage1).Controls.Add((Control)(object)Label4);
		((Control)TabPage1).Controls.Add((Control)(object)Label2);
		TabPage tabPage = TabPage1;
		location = new Point(4, 32);
		tabPage.Location = location;
		((Control)TabPage1).Name = "TabPage1";
		TabPage tabPage2 = TabPage1;
		margin = new Padding(3);
		((Control)tabPage2).Padding = margin;
		TabPage tabPage3 = TabPage1;
		size = new Size(625, 333);
		((Control)tabPage3).Size = size;
		TabPage1.TabIndex = 0;
		TabPage1.Text = "FOURNISSEUR";
		((Control)Text_PAYS).Font = new Font("Segoe UI", 12f, (FontStyle)1);
		TextBox text_PAYS = Text_PAYS;
		location = new Point(439, 144);
		((Control)text_PAYS).Location = location;
		((Control)Text_PAYS).Name = "Text_PAYS";
		TextBox text_PAYS2 = Text_PAYS;
		size = new Size(166, 26);
		((Control)text_PAYS2).Size = size;
		((Control)Text_PAYS).TabIndex = 987;
		((Control)Label1).BackColor = SystemColors.Control;
		((Control)Label1).Font = new Font("Segoe UI", 10f, (FontStyle)1);
		((Control)Label1).ForeColor = Color.Black;
		Label label = Label1;
		location = new Point(325, 144);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		size = new Size(108, 26);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 988;
		Label1.Text = "Pays";
		Label1.TextAlign = (ContentAlignment)16;
		((ButtonBase)Button_CREDIT_INITIAL_MODIF).Image = (Image)(object)Resources.Picture_MODIF_Image;
		Button button_CREDIT_INITIAL_MODIF = Button_CREDIT_INITIAL_MODIF;
		location = new Point(568, 297);
		((Control)button_CREDIT_INITIAL_MODIF).Location = location;
		((Control)Button_CREDIT_INITIAL_MODIF).Name = "Button_CREDIT_INITIAL_MODIF";
		Button button_CREDIT_INITIAL_MODIF2 = Button_CREDIT_INITIAL_MODIF;
		size = new Size(37, 26);
		((Control)button_CREDIT_INITIAL_MODIF2).Size = size;
		((Control)Button_CREDIT_INITIAL_MODIF).TabIndex = 986;
		((ButtonBase)Button_CREDIT_INITIAL_MODIF).UseVisualStyleBackColor = true;
		((Control)Label36).BackColor = SystemColors.Control;
		((Control)Label36).Font = new Font("Segoe UI", 10f, (FontStyle)1);
		((Control)Label36).ForeColor = Color.Black;
		Label label3 = Label36;
		location = new Point(325, 297);
		((Control)label3).Location = location;
		((Control)Label36).Name = "Label36";
		Label label4 = Label36;
		size = new Size(108, 26);
		((Control)label4).Size = size;
		((Control)Label36).TabIndex = 985;
		Label36.Text = "Credit Initial";
		Label36.TextAlign = (ContentAlignment)16;
		((TextBoxBase)Text_CREDIT_INITIAL).BackColor = Color.White;
		((Control)Text_CREDIT_INITIAL).Font = new Font("Segoe UI", 12f, (FontStyle)1);
		TextBox text_CREDIT_INITIAL = Text_CREDIT_INITIAL;
		location = new Point(439, 297);
		((Control)text_CREDIT_INITIAL).Location = location;
		((Control)Text_CREDIT_INITIAL).Name = "Text_CREDIT_INITIAL";
		TextBox text_CREDIT_INITIAL2 = Text_CREDIT_INITIAL;
		size = new Size(123, 26);
		((Control)text_CREDIT_INITIAL2).Size = size;
		((Control)Text_CREDIT_INITIAL).TabIndex = 984;
		((TextBoxBase)Text_ID).BackColor = Color.FromArgb(224, 224, 224);
		((TextBoxBase)Text_ID).BorderStyle = (BorderStyle)1;
		((Control)Text_ID).Enabled = false;
		((Control)Text_ID).Font = new Font("Segoe UI", 12f, (FontStyle)1);
		TextBox text_ID = Text_ID;
		location = new Point(239, 14);
		((Control)text_ID).Location = location;
		((Control)Text_ID).Name = "Text_ID";
		TextBox text_ID2 = Text_ID;
		size = new Size(32, 26);
		((Control)text_ID2).Size = size;
		((Control)Text_ID).TabIndex = 2;
		Text_ID.TextAlign = (HorizontalAlignment)2;
		((Control)Text_ID).Visible = false;
		((TextBoxBase)Text_ID_FOURNISSEUR).BackColor = Color.White;
		((Control)Text_ID_FOURNISSEUR).Enabled = false;
		((Control)Text_ID_FOURNISSEUR).Font = new Font("Segoe UI", 12f, (FontStyle)1);
		TextBox text_ID_FOURNISSEUR = Text_ID_FOURNISSEUR;
		location = new Point(439, 14);
		((Control)text_ID_FOURNISSEUR).Location = location;
		((Control)Text_ID_FOURNISSEUR).Name = "Text_ID_FOURNISSEUR";
		TextBox text_ID_FOURNISSEUR2 = Text_ID_FOURNISSEUR;
		size = new Size(166, 26);
		((Control)text_ID_FOURNISSEUR2).Size = size;
		((Control)Text_ID_FOURNISSEUR).TabIndex = 981;
		((Control)Label31).BackColor = SystemColors.Control;
		((Control)Label31).Font = new Font("Segoe UI", 10f, (FontStyle)1);
		((Control)Label31).ForeColor = Color.Black;
		Label31.ImeMode = (ImeMode)0;
		Label label5 = Label31;
		location = new Point(319, 14);
		((Control)label5).Location = location;
		((Control)Label31).Name = "Label31";
		Label label6 = Label31;
		size = new Size(115, 26);
		((Control)label6).Size = size;
		((Control)Label31).TabIndex = 982;
		Label31.Text = "ID Fournisseur";
		Label31.TextAlign = (ContentAlignment)16;
		DateTimePicker_DATE.CustomFormat = "yyyy-MM-dd";
		((Control)DateTimePicker_DATE).Font = new Font("Segoe UI", 12f, (FontStyle)1);
		DateTimePicker_DATE.Format = (DateTimePickerFormat)2;
		DateTimePicker dateTimePicker_DATE = DateTimePicker_DATE;
		location = new Point(131, 14);
		((Control)dateTimePicker_DATE).Location = location;
		((Control)DateTimePicker_DATE).Name = "DateTimePicker_DATE";
		DateTimePicker dateTimePicker_DATE2 = DateTimePicker_DATE;
		size = new Size(166, 26);
		((Control)dateTimePicker_DATE2).Size = size;
		((Control)DateTimePicker_DATE).TabIndex = 970;
		((TextBoxBase)Text_ETAT).BackColor = Color.White;
		((Control)Text_ETAT).Enabled = false;
		((Control)Text_ETAT).Font = new Font("Segoe UI", 12f, (FontStyle)1);
		TextBox text_ETAT = Text_ETAT;
		location = new Point(131, 297);
		((Control)text_ETAT).Location = location;
		((Control)Text_ETAT).Name = "Text_ETAT";
		TextBox text_ETAT2 = Text_ETAT;
		size = new Size(166, 26);
		((Control)text_ETAT2).Size = size;
		((Control)Text_ETAT).TabIndex = 969;
		((Control)Label19).BackColor = SystemColors.Control;
		((Control)Label19).Font = new Font("Segoe UI", 10f, (FontStyle)1);
		((Control)Label19).ForeColor = Color.Black;
		Label label7 = Label19;
		location = new Point(17, 297);
		((Control)label7).Location = location;
		((Control)Label19).Name = "Label19";
		Label label8 = Label19;
		size = new Size(108, 26);
		((Control)label8).Size = size;
		((Control)Label19).TabIndex = 968;
		Label19.Text = "Etat";
		Label19.TextAlign = (ContentAlignment)16;
		((Control)Label3).BackColor = SystemColors.Control;
		((Control)Label3).Font = new Font("Segoe UI", 10f, (FontStyle)1);
		((Control)Label3).ForeColor = Color.Black;
		Label label9 = Label3;
		location = new Point(17, 14);
		((Control)label9).Location = location;
		((Control)Label3).Name = "Label3";
		Label label10 = Label3;
		size = new Size(108, 26);
		((Control)label10).Size = size;
		((Control)Label3).TabIndex = 396;
		Label3.Text = "Date";
		Label3.TextAlign = (ContentAlignment)16;
		((TextBoxBase)Text_ICE).BackColor = Color.White;
		((Control)Text_ICE).Font = new Font("Segoe UI", 12f, (FontStyle)1);
		TextBox text_ICE = Text_ICE;
		location = new Point(439, 177);
		((Control)text_ICE).Location = location;
		((Control)Text_ICE).Name = "Text_ICE";
		TextBox text_ICE2 = Text_ICE;
		size = new Size(166, 26);
		((Control)text_ICE2).Size = size;
		((Control)Text_ICE).TabIndex = 6;
		((Control)Label7).BackColor = SystemColors.Control;
		((Control)Label7).Font = new Font("Segoe UI", 10f, (FontStyle)1);
		((Control)Label7).ForeColor = Color.Black;
		Label label11 = Label7;
		location = new Point(325, 177);
		((Control)label11).Location = location;
		((Control)Label7).Name = "Label7";
		Label label12 = Label7;
		size = new Size(108, 26);
		((Control)label12).Size = size;
		((Control)Label7).TabIndex = 408;
		Label7.Text = "Ice";
		Label7.TextAlign = (ContentAlignment)16;
		((Control)Text_NOTE).Font = new Font("Segoe UI", 12f, (FontStyle)1);
		TextBox text_NOTE = Text_NOTE;
		location = new Point(131, 209);
		((Control)text_NOTE).Location = location;
		Text_NOTE.Multiline = true;
		((Control)Text_NOTE).Name = "Text_NOTE";
		TextBox text_NOTE2 = Text_NOTE;
		size = new Size(474, 82);
		((Control)text_NOTE2).Size = size;
		((Control)Text_NOTE).TabIndex = 7;
		((Control)Label24).BackColor = SystemColors.Control;
		((Control)Label24).Font = new Font("Segoe UI", 9f, (FontStyle)1);
		((Control)Label24).ForeColor = Color.Black;
		Label label13 = Label24;
		location = new Point(17, 46);
		((Control)label13).Location = location;
		((Control)Label24).Name = "Label24";
		Label label14 = Label24;
		size = new Size(108, 26);
		((Control)label14).Size = size;
		((Control)Label24).TabIndex = 388;
		Label24.Text = "Code Fournisseur";
		Label24.TextAlign = (ContentAlignment)16;
		((Control)Text_TEL).Font = new Font("Segoe UI", 12f, (FontStyle)1);
		TextBox text_TEL = Text_TEL;
		location = new Point(131, 176);
		((Control)text_TEL).Location = location;
		((Control)Text_TEL).Name = "Text_TEL";
		TextBox text_TEL2 = Text_TEL;
		size = new Size(166, 26);
		((Control)text_TEL2).Size = size;
		((Control)Text_TEL).TabIndex = 4;
		((Control)Text_VILLE).Font = new Font("Segoe UI", 12f, (FontStyle)1);
		TextBox text_VILLE = Text_VILLE;
		location = new Point(131, 144);
		((Control)text_VILLE).Location = location;
		((Control)Text_VILLE).Name = "Text_VILLE";
		TextBox text_VILLE2 = Text_VILLE;
		size = new Size(166, 26);
		((Control)text_VILLE2).Size = size;
		((Control)Text_VILLE).TabIndex = 3;
		((Control)Text_ADRESSE).Font = new Font("Segoe UI", 12f, (FontStyle)1);
		TextBox text_ADRESSE = Text_ADRESSE;
		location = new Point(131, 112);
		((Control)text_ADRESSE).Location = location;
		((Control)Text_ADRESSE).Name = "Text_ADRESSE";
		TextBox text_ADRESSE2 = Text_ADRESSE;
		size = new Size(474, 26);
		((Control)text_ADRESSE2).Size = size;
		((Control)Text_ADRESSE).TabIndex = 5;
		((Control)Label8).BackColor = SystemColors.Control;
		((Control)Label8).Font = new Font("Segoe UI", 10f, (FontStyle)1);
		((Control)Label8).ForeColor = Color.Black;
		Label label15 = Label8;
		location = new Point(17, 80);
		((Control)label15).Location = location;
		((Control)Label8).Name = "Label8";
		Label label16 = Label8;
		size = new Size(108, 26);
		((Control)label16).Size = size;
		((Control)Label8).TabIndex = 399;
		Label8.Text = "Fournisseur";
		Label8.TextAlign = (ContentAlignment)16;
		((TextBoxBase)Text_FOURNISSEUR).BackColor = Color.White;
		((Control)Text_FOURNISSEUR).Font = new Font("Segoe UI", 12f, (FontStyle)1);
		TextBox text_FOURNISSEUR = Text_FOURNISSEUR;
		location = new Point(131, 80);
		((Control)text_FOURNISSEUR).Location = location;
		((Control)Text_FOURNISSEUR).Name = "Text_FOURNISSEUR";
		TextBox text_FOURNISSEUR2 = Text_FOURNISSEUR;
		size = new Size(474, 26);
		((Control)text_FOURNISSEUR2).Size = size;
		((Control)Text_FOURNISSEUR).TabIndex = 2;
		((Control)Label10).BackColor = SystemColors.Control;
		((Control)Label10).Font = new Font("Segoe UI", 10f, (FontStyle)1);
		((Control)Label10).ForeColor = Color.Black;
		Label label17 = Label10;
		location = new Point(17, 112);
		((Control)label17).Location = location;
		((Control)Label10).Name = "Label10";
		Label label18 = Label10;
		size = new Size(108, 26);
		((Control)label18).Size = size;
		((Control)Label10).TabIndex = 401;
		Label10.Text = "Adresse";
		Label10.TextAlign = (ContentAlignment)16;
		((TextBoxBase)Text_CODE_FOURNISSEUR).BackColor = Color.White;
		((Control)Text_CODE_FOURNISSEUR).Font = new Font("Segoe UI", 12f, (FontStyle)1);
		TextBox text_CODE_FOURNISSEUR = Text_CODE_FOURNISSEUR;
		location = new Point(131, 46);
		((Control)text_CODE_FOURNISSEUR).Location = location;
		((Control)Text_CODE_FOURNISSEUR).Name = "Text_CODE_FOURNISSEUR";
		TextBox text_CODE_FOURNISSEUR2 = Text_CODE_FOURNISSEUR;
		size = new Size(474, 26);
		((Control)text_CODE_FOURNISSEUR2).Size = size;
		((Control)Text_CODE_FOURNISSEUR).TabIndex = 1;
		((Control)Label9).BackColor = SystemColors.Control;
		((Control)Label9).Font = new Font("Segoe UI", 10f, (FontStyle)1);
		((Control)Label9).ForeColor = Color.Black;
		Label label19 = Label9;
		location = new Point(17, 144);
		((Control)label19).Location = location;
		((Control)Label9).Name = "Label9";
		Label label20 = Label9;
		size = new Size(108, 26);
		((Control)label20).Size = size;
		((Control)Label9).TabIndex = 402;
		Label9.Text = "Ville";
		Label9.TextAlign = (ContentAlignment)16;
		((Control)Label4).BackColor = SystemColors.Control;
		((Control)Label4).Font = new Font("Segoe UI", 10f, (FontStyle)1);
		((Control)Label4).ForeColor = Color.Black;
		Label label21 = Label4;
		location = new Point(17, 209);
		((Control)label21).Location = location;
		((Control)Label4).Name = "Label4";
		Label label22 = Label4;
		size = new Size(108, 26);
		((Control)label22).Size = size;
		((Control)Label4).TabIndex = 404;
		Label4.Text = "Notes";
		Label4.TextAlign = (ContentAlignment)16;
		((Control)Label2).BackColor = SystemColors.Control;
		((Control)Label2).Font = new Font("Segoe UI", 10f, (FontStyle)1);
		((Control)Label2).ForeColor = Color.Black;
		Label label23 = Label2;
		location = new Point(17, 176);
		((Control)label23).Location = location;
		((Control)Label2).Name = "Label2";
		Label label24 = Label2;
		size = new Size(108, 26);
		((Control)label24).Size = size;
		((Control)Label2).TabIndex = 403;
		Label2.Text = "Tel";
		Label2.TextAlign = (ContentAlignment)16;
		DataGridView1.AllowUserToAddRows = false;
		((Control)DataGridView1).Anchor = (AnchorStyles)15;
		DataGridView1.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)16;
		DataGridView1.BackgroundColor = Color.White;
		DataGridView1.BorderStyle = (BorderStyle)2;
		DataGridView1.CellBorderStyle = (DataGridViewCellBorderStyle)8;
		val.Alignment = (DataGridViewContentAlignment)16;
		val.BackColor = SystemColors.Control;
		val.Font = new Font("Segoe UI", 10f, (FontStyle)1);
		val.ForeColor = SystemColors.WindowText;
		val.SelectionBackColor = SystemColors.Highlight;
		val.SelectionForeColor = SystemColors.HighlightText;
		val.WrapMode = (DataGridViewTriState)1;
		DataGridView1.ColumnHeadersDefaultCellStyle = val;
		DataGridView1.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		DataGridView1.Columns.AddRange(new DataGridViewColumn[8]
		{
			(DataGridViewColumn)DATES,
			(DataGridViewColumn)ID_FOURNISSEUR,
			(DataGridViewColumn)FOURNISSEUR,
			(DataGridViewColumn)TELEPHONE,
			(DataGridViewColumn)Notes,
			(DataGridViewColumn)ETAT,
			(DataGridViewColumn)supp,
			(DataGridViewColumn)modi
		});
		DataGridView1.EditMode = (DataGridViewEditMode)4;
		DataGridView dataGridView = DataGridView1;
		location = new Point(0, 44);
		((Control)dataGridView).Location = location;
		((Control)DataGridView1).Name = "DataGridView1";
		DataGridView1.RowHeadersVisible = false;
		DataGridView dataGridView2 = DataGridView1;
		size = new Size(1025, 572);
		((Control)dataGridView2).Size = size;
		((Control)DataGridView1).TabIndex = 3;
		((DataGridViewColumn)DATES).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)DATES).DataPropertyName = "DATES";
		((DataGridViewColumn)DATES).HeaderText = "DATES";
		((DataGridViewColumn)DATES).Name = "DATES";
		((DataGridViewColumn)ID_FOURNISSEUR).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)ID_FOURNISSEUR).DataPropertyName = "ID_FOURNISSEUR";
		((DataGridViewColumn)ID_FOURNISSEUR).HeaderText = "ID FOURNISSEUR";
		((DataGridViewColumn)ID_FOURNISSEUR).Name = "ID_FOURNISSEUR";
		ID_FOURNISSEUR.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)ID_FOURNISSEUR).Width = 140;
		((DataGridViewColumn)FOURNISSEUR).DataPropertyName = "FOURNISSEUR";
		((DataGridViewColumn)FOURNISSEUR).HeaderText = "FOURNISSEUR";
		((DataGridViewColumn)FOURNISSEUR).Name = "FOURNISSEUR";
		FOURNISSEUR.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)TELEPHONE).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)TELEPHONE).DataPropertyName = "TELEPHONE";
		((DataGridViewColumn)TELEPHONE).HeaderText = "TELEPHONE";
		((DataGridViewColumn)TELEPHONE).Name = "TELEPHONE";
		TELEPHONE.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)Notes).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)Notes).DataPropertyName = "NOTES";
		((DataGridViewColumn)Notes).HeaderText = "NOTES";
		((DataGridViewColumn)Notes).Name = "Notes";
		((DataGridViewColumn)ETAT).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)ETAT).DataPropertyName = "ETAT";
		((DataGridViewColumn)ETAT).HeaderText = "ETAT";
		((DataGridViewColumn)ETAT).Name = "ETAT";
		((DataGridViewColumn)supp).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)supp).HeaderText = "";
		supp.Image = (Image)(object)Resources.Picture_SUPP_Image;
		((DataGridViewColumn)supp).Name = "supp";
		((DataGridViewColumn)supp).Resizable = (DataGridViewTriState)1;
		((DataGridViewColumn)supp).Width = 40;
		((DataGridViewColumn)modi).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)modi).HeaderText = "";
		modi.Image = (Image)(object)Resources.Picture_MODIF_Image;
		((DataGridViewColumn)modi).Name = "modi";
		((DataGridViewColumn)modi).Resizable = (DataGridViewTriState)1;
		((DataGridViewColumn)modi).Width = 40;
		((Control)Label_TABLE).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label_TABLE).Dock = (DockStyle)1;
		((Control)Label_TABLE).Font = new Font("Tahoma", 9f, (FontStyle)1);
		((Control)Label_TABLE).ForeColor = Color.White;
		Label label_TABLE = Label_TABLE;
		location = new Point(0, 0);
		((Control)label_TABLE).Location = location;
		((Control)Label_TABLE).Name = "Label_TABLE";
		Label label_TABLE2 = Label_TABLE;
		size = new Size(1025, 44);
		((Control)label_TABLE2).Size = size;
		((Control)Label_TABLE).TabIndex = 1037;
		Label_TABLE.Text = "FOURNISSEURS";
		Label_TABLE.TextAlign = (ContentAlignment)16;
		((Control)Panel_HISTORIQUE).Anchor = (AnchorStyles)1;
		((Control)Panel_HISTORIQUE).BackColor = Color.White;
		Panel_HISTORIQUE.BorderStyle = (BorderStyle)1;
		((Control)Panel_HISTORIQUE).Controls.Add((Control)(object)Label_HISTORIQUE_ID_FOURNISSEUR);
		((Control)Panel_HISTORIQUE).Controls.Add((Control)(object)Button3);
		((Control)Panel_HISTORIQUE).Controls.Add((Control)(object)Label5);
		((Control)Panel_HISTORIQUE).Controls.Add((Control)(object)Label6);
		((Control)Panel_HISTORIQUE).Controls.Add((Control)(object)Label12);
		((Control)Panel_HISTORIQUE).Controls.Add((Control)(object)Label_HISTORIQUE_FOURNISSEUR);
		((Control)Panel_HISTORIQUE).Controls.Add((Control)(object)TabControl2);
		Panel panel_HISTORIQUE = Panel_HISTORIQUE;
		location = new Point(59, 46);
		((Control)panel_HISTORIQUE).Location = location;
		((Control)Panel_HISTORIQUE).Name = "Panel_HISTORIQUE";
		Panel panel_HISTORIQUE2 = Panel_HISTORIQUE;
		size = new Size(906, 564);
		((Control)panel_HISTORIQUE2).Size = size;
		((Control)Panel_HISTORIQUE).TabIndex = 1068;
		((Control)Panel_HISTORIQUE).Visible = false;
		((Control)Label_HISTORIQUE_ID_FOURNISSEUR).Anchor = (AnchorStyles)9;
		((Control)Label_HISTORIQUE_ID_FOURNISSEUR).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label_HISTORIQUE_ID_FOURNISSEUR).Cursor = Cursors.Hand;
		((Control)Label_HISTORIQUE_ID_FOURNISSEUR).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label_HISTORIQUE_ID_FOURNISSEUR).ForeColor = Color.White;
		Label label_HISTORIQUE_ID_FOURNISSEUR = Label_HISTORIQUE_ID_FOURNISSEUR;
		location = new Point(689, 0);
		((Control)label_HISTORIQUE_ID_FOURNISSEUR).Location = location;
		((Control)Label_HISTORIQUE_ID_FOURNISSEUR).Name = "Label_HISTORIQUE_ID_FOURNISSEUR";
		Label label_HISTORIQUE_ID_FOURNISSEUR2 = Label_HISTORIQUE_ID_FOURNISSEUR;
		size = new Size(212, 24);
		((Control)label_HISTORIQUE_ID_FOURNISSEUR2).Size = size;
		((Control)Label_HISTORIQUE_ID_FOURNISSEUR).TabIndex = 1044;
		Label_HISTORIQUE_ID_FOURNISSEUR.Text = "-";
		Label_HISTORIQUE_ID_FOURNISSEUR.TextAlign = (ContentAlignment)64;
		((ButtonBase)Button3).BackColor = Color.Red;
		((Control)Button3).Cursor = Cursors.Hand;
		((ButtonBase)Button3).FlatStyle = (FlatStyle)0;
		((Control)Button3).Font = new Font("Tahoma", 11.25f, (FontStyle)1);
		((Control)Button3).ForeColor = Color.White;
		((ButtonBase)Button3).Image = (Image)componentResourceManager.GetObject("Button3.Image");
		((ButtonBase)Button3).ImageAlign = (ContentAlignment)16;
		Button button = Button3;
		location = new Point(7, 524);
		((Control)button).Location = location;
		Button button2 = Button3;
		margin = new Padding(0);
		((Control)button2).Margin = margin;
		((Control)Button3).Name = "Button3";
		Button button3 = Button3;
		size = new Size(156, 30);
		((Control)button3).Size = size;
		((Control)Button3).TabIndex = 1042;
		((ButtonBase)Button3).Text = "  Fermer";
		((ButtonBase)Button3).UseVisualStyleBackColor = false;
		((Control)Label5).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label5).Cursor = Cursors.Hand;
		((Control)Label5).Dock = (DockStyle)2;
		((Control)Label5).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label5).ForeColor = Color.White;
		Label label25 = Label5;
		location = new Point(4, 558);
		((Control)label25).Location = location;
		((Control)Label5).Name = "Label5";
		Label label26 = Label5;
		size = new Size(896, 4);
		((Control)label26).Size = size;
		((Control)Label5).TabIndex = 866;
		Label5.TextAlign = (ContentAlignment)16;
		((Control)Label6).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label6).Cursor = Cursors.Hand;
		((Control)Label6).Dock = (DockStyle)3;
		((Control)Label6).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label6).ForeColor = Color.White;
		Label label27 = Label6;
		location = new Point(0, 24);
		((Control)label27).Location = location;
		((Control)Label6).Name = "Label6";
		Label label28 = Label6;
		size = new Size(4, 538);
		((Control)label28).Size = size;
		((Control)Label6).TabIndex = 865;
		Label6.TextAlign = (ContentAlignment)16;
		((Control)Label12).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label12).Cursor = Cursors.Hand;
		((Control)Label12).Dock = (DockStyle)4;
		((Control)Label12).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label12).ForeColor = Color.White;
		Label label29 = Label12;
		location = new Point(900, 24);
		((Control)label29).Location = location;
		((Control)Label12).Name = "Label12";
		Label label30 = Label12;
		size = new Size(4, 538);
		((Control)label30).Size = size;
		((Control)Label12).TabIndex = 864;
		Label12.TextAlign = (ContentAlignment)16;
		((Control)Label_HISTORIQUE_FOURNISSEUR).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label_HISTORIQUE_FOURNISSEUR).Cursor = Cursors.Hand;
		((Control)Label_HISTORIQUE_FOURNISSEUR).Dock = (DockStyle)1;
		((Control)Label_HISTORIQUE_FOURNISSEUR).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label_HISTORIQUE_FOURNISSEUR).ForeColor = Color.White;
		Label label_HISTORIQUE_FOURNISSEUR = Label_HISTORIQUE_FOURNISSEUR;
		location = new Point(0, 0);
		((Control)label_HISTORIQUE_FOURNISSEUR).Location = location;
		((Control)Label_HISTORIQUE_FOURNISSEUR).Name = "Label_HISTORIQUE_FOURNISSEUR";
		Label label_HISTORIQUE_FOURNISSEUR2 = Label_HISTORIQUE_FOURNISSEUR;
		size = new Size(904, 24);
		((Control)label_HISTORIQUE_FOURNISSEUR2).Size = size;
		((Control)Label_HISTORIQUE_FOURNISSEUR).TabIndex = 862;
		Label_HISTORIQUE_FOURNISSEUR.Text = "-";
		Label_HISTORIQUE_FOURNISSEUR.TextAlign = (ContentAlignment)16;
		((Control)TabControl2).Controls.Add((Control)(object)TabPage5);
		((Control)TabControl2).Controls.Add((Control)(object)TabPage2);
		((Control)TabControl2).Font = new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		TabControl tabControl4 = TabControl2;
		size = new Size(60, 28);
		tabControl4.ItemSize = size;
		TabControl tabControl5 = TabControl2;
		location = new Point(3, 26);
		((Control)tabControl5).Location = location;
		((Control)TabControl2).Name = "TabControl2";
		TabControl2.SelectedIndex = 0;
		TabControl tabControl6 = TabControl2;
		size = new Size(897, 495);
		((Control)tabControl6).Size = size;
		((Control)TabControl2).TabIndex = 0;
		TabPage5.BackColor = Color.FromArgb(249, 249, 249);
		((Control)TabPage5).Controls.Add((Control)(object)Button_PrintRapport_2);
		((Control)TabPage5).Controls.Add((Control)(object)DataGridView_RECE_SORT);
		((Control)TabPage5).Controls.Add((Control)(object)Label_REGLE_FOURNISSEUR);
		((Control)TabPage5).Controls.Add((Control)(object)Label17);
		((Control)TabPage5).Controls.Add((Control)(object)Label29);
		((Control)TabPage5).Controls.Add((Control)(object)Label_CREDIT);
		((Control)TabPage5).Controls.Add((Control)(object)Label13);
		((Control)TabPage5).Controls.Add((Control)(object)Label_CREDIT_INITIAL);
		((Control)TabPage5).Controls.Add((Control)(object)Label_SORTIES);
		((Control)TabPage5).Controls.Add((Control)(object)Label_RECEPETIONS);
		((Control)TabPage5).Controls.Add((Control)(object)Label16);
		((Control)TabPage5).Controls.Add((Control)(object)Label15);
		((Control)TabPage5).Controls.Add((Control)(object)PictureBox3);
		((Control)TabPage5).Controls.Add((Control)(object)Button16);
		((Control)TabPage5).Controls.Add((Control)(object)Label30);
		((Control)TabPage5).Controls.Add((Control)(object)Label23);
		((Control)TabPage5).Controls.Add((Control)(object)Label21);
		((Control)TabPage5).Controls.Add((Control)(object)Label_BALANCE);
		((Control)TabPage5).Controls.Add((Control)(object)Label18);
		((Control)TabPage5).Controls.Add((Control)(object)Label_REGLE);
		((Control)TabPage5).Controls.Add((Control)(object)PictureBox2);
		((Control)TabPage5).Controls.Add((Control)(object)DataGridView_REGLEMENTS);
		((Control)TabPage5).Controls.Add((Control)(object)Label20);
		((Control)TabPage5).Controls.Add((Control)(object)DateTimePicker3);
		((Control)TabPage5).Controls.Add((Control)(object)DateTimePicker4);
		TabPage tabPage4 = TabPage5;
		location = new Point(4, 32);
		tabPage4.Location = location;
		((Control)TabPage5).Name = "TabPage5";
		TabPage tabPage5 = TabPage5;
		margin = new Padding(3);
		((Control)tabPage5).Padding = margin;
		TabPage tabPage6 = TabPage5;
		size = new Size(889, 459);
		((Control)tabPage6).Size = size;
		TabPage5.TabIndex = 1;
		TabPage5.Text = "REGLEMENTS";
		((Control)Label_REGLE_FOURNISSEUR).BackColor = SystemColors.Control;
		((Control)Label_REGLE_FOURNISSEUR).Font = new Font("Calibri", 11.25f, (FontStyle)1);
		((Control)Label_REGLE_FOURNISSEUR).ForeColor = Color.Black;
		Label label_REGLE_FOURNISSEUR = Label_REGLE_FOURNISSEUR;
		location = new Point(604, 253);
		((Control)label_REGLE_FOURNISSEUR).Location = location;
		((Control)Label_REGLE_FOURNISSEUR).Name = "Label_REGLE_FOURNISSEUR";
		Label label_REGLE_FOURNISSEUR2 = Label_REGLE_FOURNISSEUR;
		size = new Size(116, 14);
		((Control)label_REGLE_FOURNISSEUR2).Size = size;
		((Control)Label_REGLE_FOURNISSEUR).TabIndex = 1079;
		Label_REGLE_FOURNISSEUR.Text = "-";
		Label_REGLE_FOURNISSEUR.TextAlign = (ContentAlignment)16;
		((Control)Label17).BackColor = SystemColors.Control;
		((Control)Label17).Font = new Font("Calibri", 11.25f, (FontStyle)1);
		((Control)Label17).ForeColor = Color.Black;
		Label label31 = Label17;
		location = new Point(452, 253);
		((Control)label31).Location = location;
		((Control)Label17).Name = "Label17";
		Label label32 = Label17;
		size = new Size(146, 14);
		((Control)label32).Size = size;
		((Control)Label17).TabIndex = 1078;
		Label17.Text = "REGLE FOURNISSEUR";
		Label17.TextAlign = (ContentAlignment)16;
		((Control)Label29).BackColor = SystemColors.Control;
		((Control)Label29).Font = new Font("Segoe UI", 10f, (FontStyle)1);
		((Control)Label29).ForeColor = Color.Black;
		Label label33 = Label29;
		location = new Point(276, 311);
		((Control)label33).Location = location;
		((Control)Label29).Name = "Label29";
		Label label34 = Label29;
		size = new Size(110, 22);
		((Control)label34).Size = size;
		((Control)Label29).TabIndex = 1077;
		Label29.Text = "CREDIT";
		Label29.TextAlign = (ContentAlignment)32;
		((Control)Label_CREDIT).BackColor = Color.Blue;
		Label_CREDIT.BorderStyle = (BorderStyle)2;
		((Control)Label_CREDIT).Font = new Font("Cambria", 10f);
		((Control)Label_CREDIT).ForeColor = Color.White;
		Label label_CREDIT = Label_CREDIT;
		location = new Point(276, 336);
		((Control)label_CREDIT).Location = location;
		((Control)Label_CREDIT).Name = "Label_CREDIT";
		Label label_CREDIT2 = Label_CREDIT;
		size = new Size(110, 22);
		((Control)label_CREDIT2).Size = size;
		((Control)Label_CREDIT).TabIndex = 1076;
		Label_CREDIT.Text = "0";
		Label_CREDIT.TextAlign = (ContentAlignment)32;
		((Control)Label13).BackColor = SystemColors.Control;
		((Control)Label13).Font = new Font("Calibri", 11.25f, (FontStyle)1);
		((Control)Label13).ForeColor = Color.Black;
		Label label35 = Label13;
		location = new Point(3, 289);
		((Control)label35).Location = location;
		((Control)Label13).Name = "Label13";
		Label label36 = Label13;
		size = new Size(179, 14);
		((Control)label36).Size = size;
		((Control)Label13).TabIndex = 1074;
		Label13.Text = "CREDIT INITIAL";
		Label13.TextAlign = (ContentAlignment)16;
		((Control)Label_CREDIT_INITIAL).BackColor = SystemColors.Control;
		((Control)Label_CREDIT_INITIAL).Font = new Font("Calibri", 11.25f, (FontStyle)1);
		((Control)Label_CREDIT_INITIAL).ForeColor = Color.Black;
		Label label_CREDIT_INITIAL = Label_CREDIT_INITIAL;
		location = new Point(189, 289);
		((Control)label_CREDIT_INITIAL).Location = location;
		((Control)Label_CREDIT_INITIAL).Name = "Label_CREDIT_INITIAL";
		Label label_CREDIT_INITIAL2 = Label_CREDIT_INITIAL;
		size = new Size(116, 14);
		((Control)label_CREDIT_INITIAL2).Size = size;
		((Control)Label_CREDIT_INITIAL).TabIndex = 1075;
		Label_CREDIT_INITIAL.Text = "-";
		Label_CREDIT_INITIAL.TextAlign = (ContentAlignment)16;
		((Control)Label_SORTIES).BackColor = SystemColors.Control;
		((Control)Label_SORTIES).Font = new Font("Calibri", 11.25f, (FontStyle)1);
		((Control)Label_SORTIES).ForeColor = Color.Black;
		Label label_SORTIES = Label_SORTIES;
		location = new Point(189, 271);
		((Control)label_SORTIES).Location = location;
		((Control)Label_SORTIES).Name = "Label_SORTIES";
		Label label_SORTIES2 = Label_SORTIES;
		size = new Size(115, 14);
		((Control)label_SORTIES2).Size = size;
		((Control)Label_SORTIES).TabIndex = 1073;
		Label_SORTIES.Text = "-";
		Label_SORTIES.TextAlign = (ContentAlignment)16;
		((Control)Label_RECEPETIONS).BackColor = SystemColors.Control;
		((Control)Label_RECEPETIONS).Font = new Font("Calibri", 11.25f, (FontStyle)1);
		((Control)Label_RECEPETIONS).ForeColor = Color.Black;
		Label label_RECEPETIONS = Label_RECEPETIONS;
		location = new Point(189, 253);
		((Control)label_RECEPETIONS).Location = location;
		((Control)Label_RECEPETIONS).Name = "Label_RECEPETIONS";
		Label label_RECEPETIONS2 = Label_RECEPETIONS;
		size = new Size(115, 14);
		((Control)label_RECEPETIONS2).Size = size;
		((Control)Label_RECEPETIONS).TabIndex = 1072;
		Label_RECEPETIONS.Text = "-";
		Label_RECEPETIONS.TextAlign = (ContentAlignment)16;
		((Control)Label16).BackColor = SystemColors.Control;
		((Control)Label16).Font = new Font("Calibri", 11.25f, (FontStyle)1);
		((Control)Label16).ForeColor = Color.Black;
		Label label37 = Label16;
		location = new Point(3, 271);
		((Control)label37).Location = location;
		((Control)Label16).Name = "Label16";
		Label label38 = Label16;
		size = new Size(179, 14);
		((Control)label38).Size = size;
		((Control)Label16).TabIndex = 1071;
		Label16.Text = "SORTIES";
		Label16.TextAlign = (ContentAlignment)16;
		((Control)Label15).BackColor = SystemColors.Control;
		((Control)Label15).Font = new Font("Calibri", 11.25f, (FontStyle)1);
		((Control)Label15).ForeColor = Color.Black;
		Label label39 = Label15;
		location = new Point(3, 253);
		((Control)label39).Location = location;
		((Control)Label15).Name = "Label15";
		Label label40 = Label15;
		size = new Size(179, 14);
		((Control)label40).Size = size;
		((Control)Label15).TabIndex = 1070;
		Label15.Text = "RECEPETIONS";
		Label15.TextAlign = (ContentAlignment)16;
		PictureBox3.Image = (Image)componentResourceManager.GetObject("PictureBox3.Image");
		PictureBox pictureBox = PictureBox3;
		location = new Point(107, 9);
		((Control)pictureBox).Location = location;
		((Control)PictureBox3).Name = "PictureBox3";
		PictureBox pictureBox2 = PictureBox3;
		size = new Size(35, 22);
		((Control)pictureBox2).Size = size;
		PictureBox3.SizeMode = (PictureBoxSizeMode)4;
		PictureBox3.TabIndex = 1041;
		PictureBox3.TabStop = false;
		((Control)Button16).Cursor = Cursors.Hand;
		((Control)Button16).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Button16).ForeColor = Color.FromArgb(2, 45, 162);
		((ButtonBase)Button16).ImageAlign = (ContentAlignment)16;
		Button button4 = Button16;
		location = new Point(246, 9);
		((Control)button4).Location = location;
		Button button5 = Button16;
		margin = new Padding(0);
		((Control)button5).Margin = margin;
		((Control)Button16).Name = "Button16";
		Button button6 = Button16;
		size = new Size(41, 22);
		((Control)button6).Size = size;
		((Control)Button16).TabIndex = 937;
		((ButtonBase)Button16).Text = "OK";
		((ButtonBase)Button16).UseVisualStyleBackColor = true;
		((Control)Label30).BackColor = Color.WhiteSmoke;
		((Control)Label30).Font = new Font("Segoe UI", 9.75f, (FontStyle)1);
		((Control)Label30).ForeColor = Color.FromArgb(64, 64, 64);
		Label label41 = Label30;
		location = new Point(503, 311);
		((Control)label41).Location = location;
		((Control)Label30).Name = "Label30";
		Label label42 = Label30;
		size = new Size(110, 22);
		((Control)label42).Size = size;
		((Control)Label30).TabIndex = 936;
		Label30.Text = "REGLÉ";
		Label30.TextAlign = (ContentAlignment)32;
		Label23.AutoSize = true;
		((Control)Label23).BackColor = Color.Transparent;
		((Control)Label23).Font = new Font("Segoe UI", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label23).ForeColor = Color.FromArgb(2, 45, 162);
		Label label43 = Label23;
		location = new Point(452, 40);
		((Control)label43).Location = location;
		((Control)Label23).Name = "Label23";
		Label label44 = Label23;
		size = new Size(168, 15);
		((Control)label44).Size = size;
		((Control)Label23).TabIndex = 934;
		Label23.Text = "REGLEMENTS FOURNISSEUR";
		Label21.AutoSize = true;
		((Control)Label21).BackColor = Color.Transparent;
		((Control)Label21).Font = new Font("Segoe UI", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label21).ForeColor = Color.FromArgb(2, 45, 162);
		Label label45 = Label21;
		location = new Point(6, 40);
		((Control)label45).Location = location;
		((Control)Label21).Name = "Label21";
		Label label46 = Label21;
		size = new Size(139, 15);
		((Control)label46).Size = size;
		((Control)Label21).TabIndex = 933;
		Label21.Text = "RECEPTIONS / SORTIES";
		((Control)Label_BALANCE).BackColor = Color.Black;
		((Control)Label_BALANCE).Font = new Font("Cambria", 10f);
		((Control)Label_BALANCE).ForeColor = Color.White;
		Label label_BALANCE = Label_BALANCE;
		location = new Point(402, 423);
		((Control)label_BALANCE).Location = location;
		((Control)Label_BALANCE).Name = "Label_BALANCE";
		Label label_BALANCE2 = Label_BALANCE;
		size = new Size(85, 22);
		((Control)label_BALANCE2).Size = size;
		((Control)Label_BALANCE).TabIndex = 932;
		Label_BALANCE.Text = "0";
		Label_BALANCE.TextAlign = (ContentAlignment)32;
		((Control)Label18).BackColor = Color.Black;
		Label label47 = Label18;
		location = new Point(277, 358);
		((Control)label47).Location = location;
		((Control)Label18).Name = "Label18";
		Label label48 = Label18;
		size = new Size(336, 10);
		((Control)label48).Size = size;
		((Control)Label18).TabIndex = 931;
		Label18.Text = "Label18";
		((Control)Label_REGLE).BackColor = Color.Red;
		Label_REGLE.BorderStyle = (BorderStyle)2;
		((Control)Label_REGLE).Font = new Font("Cambria", 10f);
		((Control)Label_REGLE).ForeColor = Color.White;
		Label label_REGLE = Label_REGLE;
		location = new Point(503, 336);
		((Control)label_REGLE).Location = location;
		((Control)Label_REGLE).Name = "Label_REGLE";
		Label label_REGLE2 = Label_REGLE;
		size = new Size(110, 22);
		((Control)label_REGLE2).Size = size;
		((Control)Label_REGLE).TabIndex = 929;
		Label_REGLE.Text = "0";
		Label_REGLE.TextAlign = (ContentAlignment)32;
		PictureBox2.Image = (Image)componentResourceManager.GetObject("PictureBox2.Image");
		PictureBox pictureBox3 = PictureBox2;
		location = new Point(376, 365);
		((Control)pictureBox3).Location = location;
		((Control)PictureBox2).Name = "PictureBox2";
		PictureBox pictureBox4 = PictureBox2;
		size = new Size(136, 85);
		((Control)pictureBox4).Size = size;
		PictureBox2.SizeMode = (PictureBoxSizeMode)1;
		PictureBox2.TabIndex = 927;
		PictureBox2.TabStop = false;
		DataGridView_REGLEMENTS.AllowUserToAddRows = false;
		DataGridView_REGLEMENTS.AllowUserToResizeColumns = false;
		DataGridView_REGLEMENTS.AllowUserToResizeRows = false;
		DataGridView_REGLEMENTS.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)16;
		DataGridView_REGLEMENTS.BackgroundColor = Color.White;
		DataGridView_REGLEMENTS.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		DataGridView_REGLEMENTS.Columns.AddRange(new DataGridViewColumn[4]
		{
			(DataGridViewColumn)DataGridViewTextBoxColumn1,
			(DataGridViewColumn)DataGridViewTextBoxColumn2,
			(DataGridViewColumn)DataGridViewTextBoxColumn3,
			(DataGridViewColumn)DataGridViewTextBoxColumn4
		});
		DataGridView_REGLEMENTS.EditMode = (DataGridViewEditMode)4;
		DataGridView_REGLEMENTS.EnableHeadersVisualStyles = false;
		DataGridView dataGridView_REGLEMENTS = DataGridView_REGLEMENTS;
		location = new Point(455, 58);
		((Control)dataGridView_REGLEMENTS).Location = location;
		((Control)DataGridView_REGLEMENTS).Name = "DataGridView_REGLEMENTS";
		DataGridView_REGLEMENTS.RowHeadersVisible = false;
		DataGridView_REGLEMENTS.RowHeadersWidth = 11;
		DataGridView_REGLEMENTS.SelectionMode = (DataGridViewSelectionMode)1;
		DataGridView dataGridView_REGLEMENTS2 = DataGridView_REGLEMENTS;
		size = new Size(427, 192);
		((Control)dataGridView_REGLEMENTS2).Size = size;
		((Control)DataGridView_REGLEMENTS).TabIndex = 926;
		((DataGridViewColumn)DataGridViewTextBoxColumn1).DataPropertyName = "ID_REGLE";
		((DataGridViewColumn)DataGridViewTextBoxColumn1).HeaderText = "ID_REGLE";
		((DataGridViewColumn)DataGridViewTextBoxColumn1).Name = "DataGridViewTextBoxColumn1";
		((DataGridViewColumn)DataGridViewTextBoxColumn2).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)DataGridViewTextBoxColumn2).DataPropertyName = "DATES";
		((DataGridViewColumn)DataGridViewTextBoxColumn2).HeaderText = "DATES";
		((DataGridViewColumn)DataGridViewTextBoxColumn2).Name = "DataGridViewTextBoxColumn2";
		((DataGridViewColumn)DataGridViewTextBoxColumn3).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)DataGridViewTextBoxColumn3).DataPropertyName = "MONTANT";
		val2.Format = "N2";
		val2.NullValue = null;
		((DataGridViewColumn)DataGridViewTextBoxColumn3).DefaultCellStyle = val2;
		((DataGridViewColumn)DataGridViewTextBoxColumn3).HeaderText = "MONTANT";
		((DataGridViewColumn)DataGridViewTextBoxColumn3).Name = "DataGridViewTextBoxColumn3";
		((DataGridViewColumn)DataGridViewTextBoxColumn4).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)DataGridViewTextBoxColumn4).DataPropertyName = "NOTES";
		((DataGridViewColumn)DataGridViewTextBoxColumn4).HeaderText = "NOTES";
		((DataGridViewColumn)DataGridViewTextBoxColumn4).Name = "DataGridViewTextBoxColumn4";
		((DataGridViewColumn)DataGridViewTextBoxColumn4).Width = 120;
		((Control)Label20).BackColor = Color.Black;
		Label label49 = Label20;
		location = new Point(439, 58);
		((Control)label49).Location = location;
		((Control)Label20).Name = "Label20";
		Label label50 = Label20;
		size = new Size(10, 192);
		((Control)label50).Size = size;
		((Control)Label20).TabIndex = 925;
		Label20.Text = "Label20";
		DateTimePicker3.CustomFormat = "yyyy-MM-dd";
		((Control)DateTimePicker3).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		DateTimePicker3.Format = (DateTimePickerFormat)2;
		DateTimePicker dateTimePicker = DateTimePicker3;
		location = new Point(6, 9);
		((Control)dateTimePicker).Location = location;
		((Control)DateTimePicker3).Name = "DateTimePicker3";
		DateTimePicker dateTimePicker2 = DateTimePicker3;
		size = new Size(101, 22);
		((Control)dateTimePicker2).Size = size;
		((Control)DateTimePicker3).TabIndex = 916;
		DateTimePicker4.CustomFormat = "yyyy-MM-dd";
		((Control)DateTimePicker4).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		DateTimePicker4.Format = (DateTimePickerFormat)2;
		DateTimePicker dateTimePicker3 = DateTimePicker4;
		location = new Point(142, 9);
		((Control)dateTimePicker3).Location = location;
		((Control)DateTimePicker4).Name = "DateTimePicker4";
		DateTimePicker dateTimePicker4 = DateTimePicker4;
		size = new Size(101, 22);
		((Control)dateTimePicker4).Size = size;
		((Control)DateTimePicker4).TabIndex = 915;
		((Control)TabPage2).Controls.Add((Control)(object)DataGridView_DETAILS_SORTIES);
		((Control)TabPage2).Controls.Add((Control)(object)PictureBox4);
		((Control)TabPage2).Controls.Add((Control)(object)Button2);
		((Control)TabPage2).Controls.Add((Control)(object)DateTimePicker5);
		((Control)TabPage2).Controls.Add((Control)(object)DateTimePicker6);
		((Control)TabPage2).Controls.Add((Control)(object)DataGridView_DETAILS_RECEPTIONS);
		TabPage tabPage7 = TabPage2;
		location = new Point(4, 32);
		tabPage7.Location = location;
		((Control)TabPage2).Name = "TabPage2";
		TabPage tabPage8 = TabPage2;
		margin = new Padding(3);
		((Control)tabPage8).Padding = margin;
		TabPage tabPage9 = TabPage2;
		size = new Size(889, 459);
		((Control)tabPage9).Size = size;
		TabPage2.TabIndex = 2;
		TabPage2.Text = "DETAILS";
		TabPage2.UseVisualStyleBackColor = true;
		DataGridView_DETAILS_SORTIES.AllowUserToAddRows = false;
		DataGridView_DETAILS_SORTIES.AllowUserToResizeColumns = false;
		DataGridView_DETAILS_SORTIES.AllowUserToResizeRows = false;
		DataGridView_DETAILS_SORTIES.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)16;
		DataGridView_DETAILS_SORTIES.BackgroundColor = Color.White;
		DataGridView_DETAILS_SORTIES.BorderStyle = (BorderStyle)2;
		DataGridView_DETAILS_SORTIES.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		DataGridView_DETAILS_SORTIES.Columns.AddRange(new DataGridViewColumn[9]
		{
			(DataGridViewColumn)DataGridViewTextBoxColumn8,
			(DataGridViewColumn)DataGridViewTextBoxColumn9,
			(DataGridViewColumn)DataGridViewTextBoxColumn11,
			(DataGridViewColumn)DataGridViewTextBoxColumn12,
			(DataGridViewColumn)DataGridViewTextBoxColumn13,
			(DataGridViewColumn)DataGridViewTextBoxColumn14,
			(DataGridViewColumn)DataGridViewTextBoxColumn15,
			(DataGridViewColumn)DataGridViewTextBoxColumn16,
			(DataGridViewColumn)DESTINATION
		});
		DataGridView_DETAILS_SORTIES.EditMode = (DataGridViewEditMode)4;
		DataGridView dataGridView_DETAILS_SORTIES = DataGridView_DETAILS_SORTIES;
		location = new Point(6, 232);
		((Control)dataGridView_DETAILS_SORTIES).Location = location;
		((Control)DataGridView_DETAILS_SORTIES).Name = "DataGridView_DETAILS_SORTIES";
		DataGridView_DETAILS_SORTIES.RowHeadersVisible = false;
		DataGridView_DETAILS_SORTIES.RowHeadersWidth = 11;
		DataGridView_DETAILS_SORTIES.SelectionMode = (DataGridViewSelectionMode)1;
		DataGridView dataGridView_DETAILS_SORTIES2 = DataGridView_DETAILS_SORTIES;
		size = new Size(877, 172);
		((Control)dataGridView_DETAILS_SORTIES2).Size = size;
		((Control)DataGridView_DETAILS_SORTIES).TabIndex = 1078;
		((DataGridViewColumn)DataGridViewTextBoxColumn8).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)DataGridViewTextBoxColumn8).DataPropertyName = "ID_BS";
		((DataGridViewColumn)DataGridViewTextBoxColumn8).HeaderText = "ID_BS";
		((DataGridViewColumn)DataGridViewTextBoxColumn8).Name = "DataGridViewTextBoxColumn8";
		DataGridViewTextBoxColumn8.SortMode = (DataGridViewColumnSortMode)2;
		((DataGridViewColumn)DataGridViewTextBoxColumn8).Width = 80;
		((DataGridViewColumn)DataGridViewTextBoxColumn9).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)DataGridViewTextBoxColumn9).DataPropertyName = "DATES";
		((DataGridViewColumn)DataGridViewTextBoxColumn9).HeaderText = "DATES";
		((DataGridViewColumn)DataGridViewTextBoxColumn9).Name = "DataGridViewTextBoxColumn9";
		DataGridViewTextBoxColumn9.SortMode = (DataGridViewColumnSortMode)2;
		((DataGridViewColumn)DataGridViewTextBoxColumn9).Width = 90;
		((DataGridViewColumn)DataGridViewTextBoxColumn11).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)DataGridViewTextBoxColumn11).DataPropertyName = "Code";
		((DataGridViewColumn)DataGridViewTextBoxColumn11).HeaderText = "Code";
		((DataGridViewColumn)DataGridViewTextBoxColumn11).Name = "DataGridViewTextBoxColumn11";
		((DataGridViewColumn)DataGridViewTextBoxColumn12).DataPropertyName = "Article";
		((DataGridViewColumn)DataGridViewTextBoxColumn12).HeaderText = "Article";
		((DataGridViewColumn)DataGridViewTextBoxColumn12).Name = "DataGridViewTextBoxColumn12";
		DataGridViewTextBoxColumn12.SortMode = (DataGridViewColumnSortMode)2;
		((DataGridViewColumn)DataGridViewTextBoxColumn13).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)DataGridViewTextBoxColumn13).DataPropertyName = "Prix_A";
		((DataGridViewColumn)DataGridViewTextBoxColumn13).HeaderText = "Prix_A";
		((DataGridViewColumn)DataGridViewTextBoxColumn13).Name = "DataGridViewTextBoxColumn13";
		DataGridViewTextBoxColumn13.SortMode = (DataGridViewColumnSortMode)2;
		((DataGridViewColumn)DataGridViewTextBoxColumn13).Width = 80;
		((DataGridViewColumn)DataGridViewTextBoxColumn14).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)DataGridViewTextBoxColumn14).DataPropertyName = "Qté";
		((DataGridViewColumn)DataGridViewTextBoxColumn14).HeaderText = "Qté";
		((DataGridViewColumn)DataGridViewTextBoxColumn14).Name = "DataGridViewTextBoxColumn14";
		DataGridViewTextBoxColumn14.SortMode = (DataGridViewColumnSortMode)2;
		((DataGridViewColumn)DataGridViewTextBoxColumn14).Width = 50;
		((DataGridViewColumn)DataGridViewTextBoxColumn15).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)DataGridViewTextBoxColumn15).DataPropertyName = "TOTAL_NET_ACHATS";
		((DataGridViewColumn)DataGridViewTextBoxColumn15).HeaderText = "TOTAL ACHATS";
		((DataGridViewColumn)DataGridViewTextBoxColumn15).Name = "DataGridViewTextBoxColumn15";
		DataGridViewTextBoxColumn15.SortMode = (DataGridViewColumnSortMode)2;
		((DataGridViewColumn)DataGridViewTextBoxColumn15).Width = 130;
		((DataGridViewColumn)DataGridViewTextBoxColumn16).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)DataGridViewTextBoxColumn16).DataPropertyName = "ETAT";
		((DataGridViewColumn)DataGridViewTextBoxColumn16).HeaderText = "ETAT";
		((DataGridViewColumn)DataGridViewTextBoxColumn16).Name = "DataGridViewTextBoxColumn16";
		DataGridViewTextBoxColumn16.SortMode = (DataGridViewColumnSortMode)2;
		((DataGridViewColumn)DataGridViewTextBoxColumn16).Width = 90;
		((DataGridViewColumn)DESTINATION).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)DESTINATION).DataPropertyName = "DESTINATION";
		((DataGridViewColumn)DESTINATION).HeaderText = "DESTINATION";
		((DataGridViewColumn)DESTINATION).Name = "DESTINATION";
		PictureBox4.Image = (Image)componentResourceManager.GetObject("PictureBox4.Image");
		PictureBox pictureBox5 = PictureBox4;
		location = new Point(107, 9);
		((Control)pictureBox5).Location = location;
		((Control)PictureBox4).Name = "PictureBox4";
		PictureBox pictureBox6 = PictureBox4;
		size = new Size(35, 22);
		((Control)pictureBox6).Size = size;
		PictureBox4.SizeMode = (PictureBoxSizeMode)4;
		PictureBox4.TabIndex = 1076;
		PictureBox4.TabStop = false;
		((Control)Button2).Cursor = Cursors.Hand;
		((Control)Button2).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Button2).ForeColor = Color.FromArgb(2, 45, 162);
		((ButtonBase)Button2).ImageAlign = (ContentAlignment)16;
		Button button7 = Button2;
		location = new Point(246, 9);
		((Control)button7).Location = location;
		Button button8 = Button2;
		margin = new Padding(0);
		((Control)button8).Margin = margin;
		((Control)Button2).Name = "Button2";
		Button button9 = Button2;
		size = new Size(41, 22);
		((Control)button9).Size = size;
		((Control)Button2).TabIndex = 1075;
		((ButtonBase)Button2).Text = "OK";
		((ButtonBase)Button2).UseVisualStyleBackColor = true;
		DateTimePicker5.CustomFormat = "yyyy-MM-dd";
		((Control)DateTimePicker5).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		DateTimePicker5.Format = (DateTimePickerFormat)2;
		DateTimePicker dateTimePicker5 = DateTimePicker5;
		location = new Point(6, 9);
		((Control)dateTimePicker5).Location = location;
		((Control)DateTimePicker5).Name = "DateTimePicker5";
		DateTimePicker dateTimePicker6 = DateTimePicker5;
		size = new Size(101, 22);
		((Control)dateTimePicker6).Size = size;
		((Control)DateTimePicker5).TabIndex = 1074;
		DateTimePicker6.CustomFormat = "yyyy-MM-dd";
		((Control)DateTimePicker6).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		DateTimePicker6.Format = (DateTimePickerFormat)2;
		DateTimePicker dateTimePicker7 = DateTimePicker6;
		location = new Point(142, 9);
		((Control)dateTimePicker7).Location = location;
		((Control)DateTimePicker6).Name = "DateTimePicker6";
		DateTimePicker dateTimePicker8 = DateTimePicker6;
		size = new Size(101, 22);
		((Control)dateTimePicker8).Size = size;
		((Control)DateTimePicker6).TabIndex = 1073;
		DataGridView_DETAILS_RECEPTIONS.AllowUserToAddRows = false;
		DataGridView_DETAILS_RECEPTIONS.AllowUserToResizeColumns = false;
		DataGridView_DETAILS_RECEPTIONS.AllowUserToResizeRows = false;
		DataGridView_DETAILS_RECEPTIONS.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)16;
		DataGridView_DETAILS_RECEPTIONS.BackgroundColor = Color.White;
		DataGridView_DETAILS_RECEPTIONS.BorderStyle = (BorderStyle)2;
		DataGridView_DETAILS_RECEPTIONS.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		DataGridView_DETAILS_RECEPTIONS.Columns.AddRange(new DataGridViewColumn[8]
		{
			(DataGridViewColumn)ID_BRr,
			(DataGridViewColumn)DataGridViewTextBoxColumn7,
			(DataGridViewColumn)Code,
			(DataGridViewColumn)Article,
			(DataGridViewColumn)Prix_A,
			(DataGridViewColumn)Qté,
			(DataGridViewColumn)TOTAL_NET_ACHATSS,
			(DataGridViewColumn)ETATT
		});
		DataGridView_DETAILS_RECEPTIONS.EditMode = (DataGridViewEditMode)4;
		DataGridView dataGridView_DETAILS_RECEPTIONS = DataGridView_DETAILS_RECEPTIONS;
		location = new Point(6, 56);
		((Control)dataGridView_DETAILS_RECEPTIONS).Location = location;
		((Control)DataGridView_DETAILS_RECEPTIONS).Name = "DataGridView_DETAILS_RECEPTIONS";
		DataGridView_DETAILS_RECEPTIONS.RowHeadersVisible = false;
		DataGridView_DETAILS_RECEPTIONS.RowHeadersWidth = 11;
		DataGridView_DETAILS_RECEPTIONS.SelectionMode = (DataGridViewSelectionMode)1;
		DataGridView dataGridView_DETAILS_RECEPTIONS2 = DataGridView_DETAILS_RECEPTIONS;
		size = new Size(877, 172);
		((Control)dataGridView_DETAILS_RECEPTIONS2).Size = size;
		((Control)DataGridView_DETAILS_RECEPTIONS).TabIndex = 1072;
		((DataGridViewColumn)ID_BRr).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)ID_BRr).DataPropertyName = "ID_BR";
		((DataGridViewColumn)ID_BRr).HeaderText = "ID_BR";
		((DataGridViewColumn)ID_BRr).Name = "ID_BRr";
		ID_BRr.SortMode = (DataGridViewColumnSortMode)2;
		((DataGridViewColumn)ID_BRr).Width = 80;
		((DataGridViewColumn)DataGridViewTextBoxColumn7).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)DataGridViewTextBoxColumn7).DataPropertyName = "DATES";
		((DataGridViewColumn)DataGridViewTextBoxColumn7).HeaderText = "DATES";
		((DataGridViewColumn)DataGridViewTextBoxColumn7).Name = "DataGridViewTextBoxColumn7";
		DataGridViewTextBoxColumn7.SortMode = (DataGridViewColumnSortMode)2;
		((DataGridViewColumn)DataGridViewTextBoxColumn7).Width = 90;
		((DataGridViewColumn)Code).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)Code).DataPropertyName = "Code";
		((DataGridViewColumn)Code).HeaderText = "Code";
		((DataGridViewColumn)Code).Name = "Code";
		((DataGridViewColumn)Article).DataPropertyName = "Article";
		((DataGridViewColumn)Article).HeaderText = "Article";
		((DataGridViewColumn)Article).Name = "Article";
		Article.SortMode = (DataGridViewColumnSortMode)2;
		((DataGridViewColumn)Prix_A).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)Prix_A).DataPropertyName = "Prix_A";
		((DataGridViewColumn)Prix_A).HeaderText = "Prix_A";
		((DataGridViewColumn)Prix_A).Name = "Prix_A";
		Prix_A.SortMode = (DataGridViewColumnSortMode)2;
		((DataGridViewColumn)Prix_A).Width = 80;
		((DataGridViewColumn)Qté).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)Qté).DataPropertyName = "Qté";
		((DataGridViewColumn)Qté).HeaderText = "Qté";
		((DataGridViewColumn)Qté).Name = "Qté";
		Qté.SortMode = (DataGridViewColumnSortMode)2;
		((DataGridViewColumn)Qté).Width = 50;
		((DataGridViewColumn)TOTAL_NET_ACHATSS).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)TOTAL_NET_ACHATSS).DataPropertyName = "TOTAL_NET_ACHATS";
		((DataGridViewColumn)TOTAL_NET_ACHATSS).HeaderText = "TOTAL ACHATS";
		((DataGridViewColumn)TOTAL_NET_ACHATSS).Name = "TOTAL_NET_ACHATSS";
		TOTAL_NET_ACHATSS.SortMode = (DataGridViewColumnSortMode)2;
		((DataGridViewColumn)TOTAL_NET_ACHATSS).Width = 130;
		((DataGridViewColumn)ETATT).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)ETATT).DataPropertyName = "ETAT";
		((DataGridViewColumn)ETATT).HeaderText = "ETAT";
		((DataGridViewColumn)ETATT).Name = "ETATT";
		ETATT.SortMode = (DataGridViewColumnSortMode)2;
		((DataGridViewColumn)ETATT).Width = 190;
		((DataGridViewColumn)DataGridViewImageColumn1).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)DataGridViewImageColumn1).HeaderText = "";
		DataGridViewImageColumn1.Image = (Image)(object)Resources.Picture_SUPP_Image;
		((DataGridViewColumn)DataGridViewImageColumn1).Name = "DataGridViewImageColumn1";
		((DataGridViewColumn)DataGridViewImageColumn1).Resizable = (DataGridViewTriState)1;
		((DataGridViewColumn)DataGridViewImageColumn1).Width = 40;
		((DataGridViewColumn)DataGridViewImageColumn2).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)DataGridViewImageColumn2).HeaderText = "";
		DataGridViewImageColumn2.Image = (Image)(object)Resources.Picture_MODIF_Image;
		((DataGridViewColumn)DataGridViewImageColumn2).Name = "DataGridViewImageColumn2";
		((DataGridViewColumn)DataGridViewImageColumn2).Resizable = (DataGridViewTriState)1;
		((DataGridViewColumn)DataGridViewImageColumn2).Width = 40;
		((Control)Button1).Anchor = (AnchorStyles)10;
		((ButtonBase)Button1).BackColor = Color.Transparent;
		((Control)Button1).Cursor = Cursors.Hand;
		((Control)Button1).Font = new Font("Tahoma", 11.25f, (FontStyle)1);
		((Control)Button1).ForeColor = Color.Black;
		((ButtonBase)Button1).Image = (Image)componentResourceManager.GetObject("Button1.Image");
		((ButtonBase)Button1).ImageAlign = (ContentAlignment)16;
		Button button10 = Button1;
		location = new Point(613, 646);
		((Control)button10).Location = location;
		((Control)Button1).Name = "Button1";
		Button button11 = Button1;
		size = new Size(240, 40);
		((Control)button11).Size = size;
		((Control)Button1).TabIndex = 1065;
		((ButtonBase)Button1).Text = "      Historique Fournisseur";
		((ButtonBase)Button1).UseVisualStyleBackColor = false;
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
		((Control)Panel_FONCTIONS).Anchor = (AnchorStyles)10;
		((Control)Panel_FONCTIONS).BackColor = Color.White;
		Panel_FONCTIONS.BorderStyle = (BorderStyle)1;
		((Control)Panel_FONCTIONS).Controls.Add((Control)(object)Label41);
		((Control)Panel_FONCTIONS).Controls.Add((Control)(object)Label44);
		((Control)Panel_FONCTIONS).Controls.Add((Control)(object)Label43);
		((Control)Panel_FONCTIONS).Controls.Add((Control)(object)Label42);
		((Control)Panel_FONCTIONS).Controls.Add((Control)(object)Button_PDF);
		((Control)Panel_FONCTIONS).Controls.Add((Control)(object)Button_EXCEL);
		((Control)Panel_FONCTIONS).Controls.Add((Control)(object)Button_WORD);
		Panel panel_FONCTIONS = Panel_FONCTIONS;
		location = new Point(859, 315);
		((Control)panel_FONCTIONS).Location = location;
		((Control)Panel_FONCTIONS).Name = "Panel_FONCTIONS";
		Panel panel_FONCTIONS2 = Panel_FONCTIONS;
		size = new Size(166, 326);
		((Control)panel_FONCTIONS2).Size = size;
		((Control)Panel_FONCTIONS).TabIndex = 1070;
		((Control)Panel_FONCTIONS).Visible = false;
		((Control)Label41).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label41).Cursor = Cursors.Hand;
		((Control)Label41).Dock = (DockStyle)2;
		((Control)Label41).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label41).ForeColor = Color.White;
		Label label51 = Label41;
		location = new Point(2, 322);
		((Control)label51).Location = location;
		((Control)Label41).Name = "Label41";
		Label label52 = Label41;
		size = new Size(160, 2);
		((Control)label52).Size = size;
		((Control)Label41).TabIndex = 1059;
		Label41.TextAlign = (ContentAlignment)16;
		((Control)Label44).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label44).Cursor = Cursors.Hand;
		((Control)Label44).Dock = (DockStyle)1;
		((Control)Label44).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label44).ForeColor = Color.White;
		Label label53 = Label44;
		location = new Point(2, 0);
		((Control)label53).Location = location;
		((Control)Label44).Name = "Label44";
		Label label54 = Label44;
		size = new Size(160, 2);
		((Control)label54).Size = size;
		((Control)Label44).TabIndex = 1062;
		Label44.TextAlign = (ContentAlignment)16;
		((Control)Label43).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label43).Cursor = Cursors.Hand;
		((Control)Label43).Dock = (DockStyle)4;
		((Control)Label43).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label43).ForeColor = Color.White;
		Label label55 = Label43;
		location = new Point(162, 0);
		((Control)label55).Location = location;
		((Control)Label43).Name = "Label43";
		Label label56 = Label43;
		size = new Size(2, 324);
		((Control)label56).Size = size;
		((Control)Label43).TabIndex = 1061;
		Label43.TextAlign = (ContentAlignment)16;
		((Control)Label42).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label42).Cursor = Cursors.Hand;
		((Control)Label42).Dock = (DockStyle)3;
		((Control)Label42).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label42).ForeColor = Color.White;
		Label label57 = Label42;
		location = new Point(0, 0);
		((Control)label57).Location = location;
		((Control)Label42).Name = "Label42";
		Label label58 = Label42;
		size = new Size(2, 324);
		((Control)label58).Size = size;
		((Control)Label42).TabIndex = 1060;
		Label42.TextAlign = (ContentAlignment)16;
		((ButtonBase)Button_PDF).BackColor = Color.Transparent;
		((Control)Button_PDF).Cursor = Cursors.Hand;
		((ButtonBase)Button_PDF).FlatAppearance.BorderColor = Color.FromArgb(192, 0, 0);
		((ButtonBase)Button_PDF).FlatStyle = (FlatStyle)0;
		((Control)Button_PDF).Font = new Font("Segoe UI", 9f, (FontStyle)1);
		((Control)Button_PDF).ForeColor = Color.Black;
		((ButtonBase)Button_PDF).ImageAlign = (ContentAlignment)16;
		Button button_PDF = Button_PDF;
		location = new Point(4, 4);
		((Control)button_PDF).Location = location;
		((Control)Button_PDF).Name = "Button_PDF";
		Button button_PDF2 = Button_PDF;
		size = new Size(156, 40);
		((Control)button_PDF2).Size = size;
		((Control)Button_PDF).TabIndex = 382;
		((ButtonBase)Button_PDF).Text = "Historique Modif Crédit Initial";
		((ButtonBase)Button_PDF).UseVisualStyleBackColor = false;
		((ButtonBase)Button_EXCEL).BackColor = Color.Transparent;
		((Control)Button_EXCEL).Cursor = Cursors.Hand;
		((ButtonBase)Button_EXCEL).FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
		((ButtonBase)Button_EXCEL).FlatStyle = (FlatStyle)0;
		((Control)Button_EXCEL).Font = new Font("Segoe UI", 11.25f, (FontStyle)1);
		((Control)Button_EXCEL).ForeColor = Color.Black;
		((ButtonBase)Button_EXCEL).ImageAlign = (ContentAlignment)16;
		Button button_EXCEL = Button_EXCEL;
		location = new Point(4, 50);
		((Control)button_EXCEL).Location = location;
		((Control)Button_EXCEL).Name = "Button_EXCEL";
		Button button_EXCEL2 = Button_EXCEL;
		size = new Size(156, 40);
		((Control)button_EXCEL2).Size = size;
		((Control)Button_EXCEL).TabIndex = 381;
		((ButtonBase)Button_EXCEL).UseVisualStyleBackColor = false;
		((ButtonBase)Button_WORD).BackColor = Color.Transparent;
		((Control)Button_WORD).Cursor = Cursors.Hand;
		((ButtonBase)Button_WORD).FlatAppearance.BorderColor = Color.Blue;
		((ButtonBase)Button_WORD).FlatStyle = (FlatStyle)0;
		((Control)Button_WORD).Font = new Font("Segoe UI", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Button_WORD).ForeColor = Color.Black;
		((ButtonBase)Button_WORD).ImageAlign = (ContentAlignment)16;
		Button button_WORD = Button_WORD;
		location = new Point(4, 96);
		((Control)button_WORD).Location = location;
		((Control)Button_WORD).Name = "Button_WORD";
		Button button_WORD2 = Button_WORD;
		size = new Size(156, 40);
		((Control)button_WORD2).Size = size;
		((Control)Button_WORD).TabIndex = 380;
		((ButtonBase)Button_WORD).UseVisualStyleBackColor = false;
		((Control)Button_FONCTIONS).Anchor = (AnchorStyles)10;
		((ButtonBase)Button_FONCTIONS).BackColor = Color.Transparent;
		((Control)Button_FONCTIONS).Cursor = Cursors.Hand;
		((Control)Button_FONCTIONS).Font = new Font("Segoe UI", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Button_FONCTIONS).ForeColor = SystemColors.ControlText;
		((ButtonBase)Button_FONCTIONS).Image = (Image)componentResourceManager.GetObject("Button_FONCTIONS.Image");
		((ButtonBase)Button_FONCTIONS).ImageAlign = (ContentAlignment)16;
		Button button_FONCTIONS = Button_FONCTIONS;
		location = new Point(866, 646);
		((Control)button_FONCTIONS).Location = location;
		Button button_FONCTIONS2 = Button_FONCTIONS;
		margin = new Padding(0);
		((Control)button_FONCTIONS2).Margin = margin;
		((Control)Button_FONCTIONS).Name = "Button_FONCTIONS";
		Button button_FONCTIONS3 = Button_FONCTIONS;
		size = new Size(156, 40);
		((Control)button_FONCTIONS3).Size = size;
		((Control)Button_FONCTIONS).TabIndex = 1069;
		((ButtonBase)Button_FONCTIONS).Text = "   Fonctions";
		((ButtonBase)Button_FONCTIONS).UseVisualStyleBackColor = false;
		((Control)Panel_FIND).Anchor = (AnchorStyles)13;
		((Control)Panel_FIND).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Panel_FIND).Controls.Add((Control)(object)Panel_DATES);
		((Control)Panel_FIND).Controls.Add((Control)(object)Combo_FIND);
		((Control)Panel_FIND).Controls.Add((Control)(object)Picture_EXPORT);
		((Control)Panel_FIND).Controls.Add((Control)(object)Label26);
		((Control)Panel_FIND).Controls.Add((Control)(object)Label11);
		((Control)Panel_FIND).Controls.Add((Control)(object)Check_FIND_DATE);
		((Control)Panel_FIND).Controls.Add((Control)(object)Check_FIND_EXACTE);
		((Control)Panel_FIND).Controls.Add((Control)(object)Picture_REFRESH);
		((Control)Panel_FIND).Controls.Add((Control)(object)Picture_FIND);
		((Control)Panel_FIND).Controls.Add((Control)(object)Text_FIND);
		Panel panel_FIND = Panel_FIND;
		location = new Point(143, 0);
		((Control)panel_FIND).Location = location;
		((Control)Panel_FIND).Name = "Panel_FIND";
		Panel panel_FIND2 = Panel_FIND;
		size = new Size(882, 44);
		((Control)panel_FIND2).Size = size;
		((Control)Panel_FIND).TabIndex = 1071;
		((Control)Panel_DATES).Controls.Add((Control)(object)DateTime2_FIND);
		((Control)Panel_DATES).Controls.Add((Control)(object)DateTime1_FIND);
		((Control)Panel_DATES).Controls.Add((Control)(object)Picture_FIND_DATES);
		((Control)Panel_DATES).Controls.Add((Control)(object)PictureBox1);
		Panel panel_DATES = Panel_DATES;
		location = new Point(564, 3);
		((Control)panel_DATES).Location = location;
		((Control)Panel_DATES).Name = "Panel_DATES";
		Panel panel_DATES2 = Panel_DATES;
		size = new Size(276, 39);
		((Control)panel_DATES2).Size = size;
		((Control)Panel_DATES).TabIndex = 1043;
		DateTime2_FIND.CalendarFont = new Font("Segoe UI", 9.75f);
		DateTime2_FIND.CustomFormat = "yyyy-MM-dd";
		((Control)DateTime2_FIND).Font = new Font("Segoe UI", 9.75f);
		DateTime2_FIND.Format = (DateTimePickerFormat)2;
		DateTimePicker dateTime2_FIND = DateTime2_FIND;
		location = new Point(143, 6);
		((Control)dateTime2_FIND).Location = location;
		((Control)DateTime2_FIND).Name = "DateTime2_FIND";
		DateTimePicker dateTime2_FIND2 = DateTime2_FIND;
		size = new Size(100, 26);
		((Control)dateTime2_FIND2).Size = size;
		((Control)DateTime2_FIND).TabIndex = 1043;
		DateTime1_FIND.CalendarFont = new Font("Segoe UI", 9.75f);
		DateTime1_FIND.CustomFormat = "yyyy-MM-dd";
		((Control)DateTime1_FIND).Font = new Font("Segoe UI", 9.75f);
		DateTime1_FIND.Format = (DateTimePickerFormat)2;
		DateTimePicker dateTime1_FIND = DateTime1_FIND;
		location = new Point(8, 6);
		((Control)dateTime1_FIND).Location = location;
		((Control)DateTime1_FIND).Name = "DateTime1_FIND";
		DateTimePicker dateTime1_FIND2 = DateTime1_FIND;
		size = new Size(100, 26);
		((Control)dateTime1_FIND2).Size = size;
		((Control)DateTime1_FIND).TabIndex = 986;
		Picture_FIND_DATES.Image = (Image)componentResourceManager.GetObject("Picture_FIND_DATES.Image");
		PictureBox picture_FIND_DATES = Picture_FIND_DATES;
		location = new Point(243, 6);
		((Control)picture_FIND_DATES).Location = location;
		((Control)Picture_FIND_DATES).Name = "Picture_FIND_DATES";
		PictureBox picture_FIND_DATES2 = Picture_FIND_DATES;
		size = new Size(27, 26);
		((Control)picture_FIND_DATES2).Size = size;
		Picture_FIND_DATES.SizeMode = (PictureBoxSizeMode)4;
		Picture_FIND_DATES.TabIndex = 1042;
		Picture_FIND_DATES.TabStop = false;
		PictureBox1.Image = (Image)componentResourceManager.GetObject("PictureBox1.Image");
		PictureBox pictureBox7 = PictureBox1;
		location = new Point(108, 6);
		((Control)pictureBox7).Location = location;
		((Control)PictureBox1).Name = "PictureBox1";
		PictureBox pictureBox8 = PictureBox1;
		size = new Size(35, 26);
		((Control)pictureBox8).Size = size;
		PictureBox1.SizeMode = (PictureBoxSizeMode)4;
		PictureBox1.TabIndex = 1040;
		PictureBox1.TabStop = false;
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
		Combo_FIND.FlatStyle = (FlatStyle)0;
		Combo_FIND.Font = new Font("Segoe UI", 9.75f);
		Combo_FIND.ForeColor = Color.White;
		((ListControl)Combo_FIND).FormattingEnabled = true;
		Combo_FIND.Icon = null;
		Combo_FIND.IndicatorAlignment = (Bunifu.UI.WinForms.BunifuDropdown.Indicator)1;
		Combo_FIND.IndicatorColor = Color.White;
		Combo_FIND.IndicatorLocation = (Bunifu.UI.WinForms.BunifuDropdown.Indicator)1;
		Combo_FIND.ItemBackColor = Color.White;
		Combo_FIND.ItemBorderColor = Color.White;
		Combo_FIND.ItemForeColor = Color.Black;
		Combo_FIND.ItemHeight = 26;
		Combo_FIND.ItemHighLightColor = Color.DodgerBlue;
		Combo_FIND.ItemHighLightForeColor = Color.White;
		((ComboBox)Combo_FIND).Items.AddRange(new object[11]
		{
			"ID_FOURNISSEUR", "CODE_FOURNISSEUR", "FOURNISSEUR", "ICE", "ADRESSE", "VILLE", "PAYS", "TELEPHONE", "NOTES", "ETAT",
			"DATES"
		});
		Combo_FIND.ItemTopMargin = 3;
		BunifuDropdown combo_FIND = Combo_FIND;
		location = new Point(3, 7);
		((Control)combo_FIND).Location = location;
		((Control)Combo_FIND).Name = "Combo_FIND";
		BunifuDropdown combo_FIND2 = Combo_FIND;
		size = new Size(121, 32);
		((Control)combo_FIND2).Size = size;
		((Control)Combo_FIND).TabIndex = 986;
		Combo_FIND.Text = null;
		Combo_FIND.TextAlignment = (Bunifu.UI.WinForms.BunifuDropdown.TextAlign)0;
		Combo_FIND.TextLeftMargin = 5;
		Picture_EXPORT._BackgroundColor = Color.FromArgb(75, 141, 242);
		Picture_EXPORT._BorderColor = Color.White;
		Picture_EXPORT._BorderRadius = 16;
		Picture_EXPORT._BorderSize = 1;
		Picture_EXPORT._TextColor = Color.White;
		((Control)Picture_EXPORT).Anchor = (AnchorStyles)9;
		((ButtonBase)Picture_EXPORT).BackColor = Color.FromArgb(75, 141, 242);
		((ButtonBase)Picture_EXPORT).FlatAppearance.BorderSize = 0;
		((ButtonBase)Picture_EXPORT).FlatStyle = (FlatStyle)0;
		((Control)Picture_EXPORT).ForeColor = Color.White;
		((ButtonBase)Picture_EXPORT).Image = (Image)componentResourceManager.GetObject("Picture_EXPORT.Image");
		Button_RJ picture_EXPORT = Picture_EXPORT;
		location = new Point(844, 6);
		((Control)picture_EXPORT).Location = location;
		((Control)Picture_EXPORT).Name = "Picture_EXPORT";
		Button_RJ picture_EXPORT2 = Picture_EXPORT;
		size = new Size(33, 33);
		((Control)picture_EXPORT2).Size = size;
		((Control)Picture_EXPORT).TabIndex = 1056;
		((ButtonBase)Picture_EXPORT).UseVisualStyleBackColor = false;
		Label26.AutoSize = true;
		((Control)Label26).Font = new Font("Segoe UI", 9.75f);
		((Control)Label26).ForeColor = Color.White;
		Label label59 = Label26;
		location = new Point(492, 13);
		((Control)label59).Location = location;
		((Control)Label26).Name = "Label26";
		Label label60 = Label26;
		size = new Size(68, 18);
		((Control)label60).Size = size;
		((Control)Label26).TabIndex = 1055;
		Label26.Text = "Avec date";
		Label11.AutoSize = true;
		((Control)Label11).Font = new Font("Segoe UI", 9.75f);
		((Control)Label11).ForeColor = Color.White;
		Label label61 = Label11;
		location = new Point(411, 13);
		((Control)label61).Location = location;
		((Control)Label11).Name = "Label11";
		Label label62 = Label11;
		size = new Size(50, 18);
		((Control)label62).Size = size;
		((Control)Label11).TabIndex = 1054;
		Label11.Text = "Exacte";
		Check_FIND_DATE.AllowBindingControlAnimation = true;
		Check_FIND_DATE.AllowBindingControlColorChanges = false;
		Check_FIND_DATE.AllowBindingControlLocation = true;
		Check_FIND_DATE.AllowCheckBoxAnimation = false;
		Check_FIND_DATE.AllowCheckmarkAnimation = true;
		Check_FIND_DATE.AllowOnHoverStates = true;
		Check_FIND_DATE.AutoCheck = true;
		((Control)Check_FIND_DATE).BackColor = Color.Transparent;
		Check_FIND_DATE.BackgroundImage = (Image)componentResourceManager.GetObject("Check_FIND_DATE.BackgroundImage");
		Check_FIND_DATE.BackgroundImageLayout = (ImageLayout)4;
		Check_FIND_DATE.BindingControlPosition = (Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions)1;
		Check_FIND_DATE.BorderRadius = 12;
		Check_FIND_DATE.Checked = false;
		Check_FIND_DATE.CheckState = (Bunifu.UI.WinForms.BunifuCheckBox.CheckStates)1;
		((Control)Check_FIND_DATE).Cursor = Cursors.Default;
		Check_FIND_DATE.CustomCheckmarkImage = null;
		BunifuCheckBox check_FIND_DATE = Check_FIND_DATE;
		location = new Point(465, 9);
		((Control)check_FIND_DATE).Location = location;
		BunifuCheckBox check_FIND_DATE2 = Check_FIND_DATE;
		size = new Size(17, 17);
		((Control)check_FIND_DATE2).MinimumSize = size;
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
		BunifuCheckBox check_FIND_DATE3 = Check_FIND_DATE;
		size = new Size(27, 27);
		((Control)check_FIND_DATE3).Size = size;
		Check_FIND_DATE.Style = (Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles)0;
		((Control)Check_FIND_DATE).TabIndex = 1053;
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
		Check_FIND_EXACTE.BackgroundImage = (Image)componentResourceManager.GetObject("Check_FIND_EXACTE.BackgroundImage");
		Check_FIND_EXACTE.BackgroundImageLayout = (ImageLayout)4;
		Check_FIND_EXACTE.BindingControlPosition = (Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions)1;
		Check_FIND_EXACTE.BorderRadius = 12;
		Check_FIND_EXACTE.Checked = false;
		Check_FIND_EXACTE.CheckState = (Bunifu.UI.WinForms.BunifuCheckBox.CheckStates)1;
		((Control)Check_FIND_EXACTE).Cursor = Cursors.Default;
		Check_FIND_EXACTE.CustomCheckmarkImage = null;
		BunifuCheckBox check_FIND_EXACTE = Check_FIND_EXACTE;
		location = new Point(384, 9);
		((Control)check_FIND_EXACTE).Location = location;
		BunifuCheckBox check_FIND_EXACTE2 = Check_FIND_EXACTE;
		size = new Size(17, 17);
		((Control)check_FIND_EXACTE2).MinimumSize = size;
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
		BunifuCheckBox check_FIND_EXACTE3 = Check_FIND_EXACTE;
		size = new Size(27, 27);
		((Control)check_FIND_EXACTE3).Size = size;
		Check_FIND_EXACTE.Style = (Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles)0;
		((Control)Check_FIND_EXACTE).TabIndex = 1052;
		Check_FIND_EXACTE.ThreeState = false;
		Check_FIND_EXACTE.ToolTipText = null;
		Picture_REFRESH._BackgroundColor = Color.FromArgb(75, 141, 242);
		Picture_REFRESH._BorderColor = Color.White;
		Picture_REFRESH._BorderRadius = 16;
		Picture_REFRESH._BorderSize = 1;
		Picture_REFRESH._TextColor = Color.White;
		((ButtonBase)Picture_REFRESH).BackColor = Color.FromArgb(75, 141, 242);
		((ButtonBase)Picture_REFRESH).FlatAppearance.BorderSize = 0;
		((ButtonBase)Picture_REFRESH).FlatStyle = (FlatStyle)0;
		((Control)Picture_REFRESH).ForeColor = Color.White;
		((ButtonBase)Picture_REFRESH).Image = (Image)componentResourceManager.GetObject("Picture_REFRESH.Image");
		Button_RJ picture_REFRESH = Picture_REFRESH;
		location = new Point(342, 6);
		((Control)picture_REFRESH).Location = location;
		((Control)Picture_REFRESH).Name = "Picture_REFRESH";
		Button_RJ picture_REFRESH2 = Picture_REFRESH;
		size = new Size(33, 33);
		((Control)picture_REFRESH2).Size = size;
		((Control)Picture_REFRESH).TabIndex = 1048;
		((ButtonBase)Picture_REFRESH).UseVisualStyleBackColor = false;
		Picture_FIND._BackgroundColor = Color.FromArgb(75, 141, 242);
		Picture_FIND._BorderColor = Color.White;
		Picture_FIND._BorderRadius = 16;
		Picture_FIND._BorderSize = 1;
		Picture_FIND._TextColor = Color.White;
		((ButtonBase)Picture_FIND).BackColor = Color.FromArgb(75, 141, 242);
		((ButtonBase)Picture_FIND).FlatAppearance.BorderSize = 0;
		((ButtonBase)Picture_FIND).FlatStyle = (FlatStyle)0;
		((Control)Picture_FIND).ForeColor = Color.White;
		((ButtonBase)Picture_FIND).Image = (Image)componentResourceManager.GetObject("Picture_FIND.Image");
		Button_RJ picture_FIND = Picture_FIND;
		location = new Point(305, 6);
		((Control)picture_FIND).Location = location;
		((Control)Picture_FIND).Name = "Picture_FIND";
		Button_RJ picture_FIND2 = Picture_FIND;
		size = new Size(33, 33);
		((Control)picture_FIND2).Size = size;
		((Control)Picture_FIND).TabIndex = 987;
		((ButtonBase)Picture_FIND).UseVisualStyleBackColor = false;
		Text_FIND.BackColor = Color.FromArgb(75, 141, 242);
		Text_FIND.BorderColor = Color.White;
		Text_FIND.BorderFocusColor = Color.White;
		Text_FIND.BorderRadius = 16;
		Text_FIND.BorderSize = 1;
		Text_FIND.Font = new Font("Segoe UI", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Text_FIND.ForeColor = Color.White;
		RJTextBox text_FIND = Text_FIND;
		location = new Point(127, 6);
		((Control)text_FIND).Location = location;
		RJTextBox text_FIND2 = Text_FIND;
		margin = new Padding(4);
		((Control)text_FIND2).Margin = margin;
		Text_FIND.Multiline = false;
		((Control)Text_FIND).Name = "Text_FIND";
		RJTextBox text_FIND3 = Text_FIND;
		margin = new Padding(10, 7, 10, 7);
		((Control)text_FIND3).Padding = margin;
		Text_FIND.PasswordChar = false;
		Text_FIND.PlaceholderColor = Color.White;
		Text_FIND.PlaceholderText = "";
		RJTextBox text_FIND4 = Text_FIND;
		size = new Size(211, 33);
		((Control)text_FIND4).Size = size;
		((Control)Text_FIND).TabIndex = 986;
		Text_FIND.Texts = "";
		Text_FIND.UnderlinedStyle = false;
		((Control)Panel112233).Anchor = (AnchorStyles)14;
		((Control)Panel112233).BackColor = Color.Transparent;
		((Control)Panel112233).Controls.Add((Control)(object)Label_TOTAL_LIGNES_BD);
		((Control)Panel112233).Controls.Add((Control)(object)Button_CALC_BD);
		((Control)Panel112233).Controls.Add((Control)(object)Label4141);
		((Control)Panel112233).Controls.Add((Control)(object)Label28);
		((Control)Panel112233).Controls.Add((Control)(object)Label14);
		Panel panel = Panel112233;
		location = new Point(0, 609);
		((Control)panel).Location = location;
		((Control)Panel112233).Name = "Panel112233";
		Panel panel2 = Panel112233;
		size = new Size(1025, 31);
		((Control)panel2).Size = size;
		((Control)Panel112233).TabIndex = 1072;
		((Control)Label_TOTAL_LIGNES_BD).BackColor = Color.White;
		((Control)Label_TOTAL_LIGNES_BD).Font = new Font("Calibri", 11f, (FontStyle)1);
		((Control)Label_TOTAL_LIGNES_BD).ForeColor = Color.FromArgb(64, 64, 64);
		Label label_TOTAL_LIGNES_BD = Label_TOTAL_LIGNES_BD;
		location = new Point(3, 1);
		((Control)label_TOTAL_LIGNES_BD).Location = location;
		((Control)Label_TOTAL_LIGNES_BD).Name = "Label_TOTAL_LIGNES_BD";
		Label label_TOTAL_LIGNES_BD2 = Label_TOTAL_LIGNES_BD;
		size = new Size(66, 29);
		((Control)label_TOTAL_LIGNES_BD2).Size = size;
		((Control)Label_TOTAL_LIGNES_BD).TabIndex = 1070;
		Label_TOTAL_LIGNES_BD.Text = "-/-";
		Label_TOTAL_LIGNES_BD.TextAlign = (ContentAlignment)16;
		((Control)Button_CALC_BD).ForeColor = Color.Red;
		Button button_CALC_BD = Button_CALC_BD;
		location = new Point(190, 5);
		((Control)button_CALC_BD).Location = location;
		((Control)Button_CALC_BD).Name = "Button_CALC_BD";
		Button button_CALC_BD2 = Button_CALC_BD;
		size = new Size(48, 16);
		((Control)button_CALC_BD2).Size = size;
		((Control)Button_CALC_BD).TabIndex = 985;
		((ButtonBase)Button_CALC_BD).Text = "CALC";
		((ButtonBase)Button_CALC_BD).UseCompatibleTextRendering = true;
		((ButtonBase)Button_CALC_BD).UseVisualStyleBackColor = true;
		((Control)Button_CALC_BD).Visible = false;
		((Control)Label4141).Anchor = (AnchorStyles)9;
		((Control)Label4141).BackColor = Color.White;
		((Control)Label4141).Font = new Font("Calibri", 11f, (FontStyle)1);
		((Control)Label4141).ForeColor = Color.FromArgb(64, 64, 64);
		Label label63 = Label4141;
		location = new Point(647, 1);
		((Control)label63).Location = location;
		((Control)Label4141).Name = "Label4141";
		Label label64 = Label4141;
		size = new Size(375, 29);
		((Control)label64).Size = size;
		((Control)Label4141).TabIndex = 1066;
		Label4141.Text = "-";
		Label4141.TextAlign = (ContentAlignment)64;
		((Control)Label28).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label28).Cursor = Cursors.Hand;
		((Control)Label28).Dock = (DockStyle)2;
		((Control)Label28).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label28).ForeColor = Color.White;
		Label label65 = Label28;
		location = new Point(0, 30);
		((Control)label65).Location = location;
		((Control)Label28).Name = "Label28";
		Label label66 = Label28;
		size = new Size(1025, 1);
		((Control)label66).Size = size;
		((Control)Label28).TabIndex = 1064;
		Label28.TextAlign = (ContentAlignment)16;
		((Control)Label14).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label14).Cursor = Cursors.Hand;
		((Control)Label14).Dock = (DockStyle)1;
		((Control)Label14).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label14).ForeColor = Color.White;
		Label label67 = Label14;
		location = new Point(0, 0);
		((Control)label67).Location = location;
		((Control)Label14).Name = "Label14";
		Label label68 = Label14;
		size = new Size(1025, 1);
		((Control)label68).Size = size;
		((Control)Label14).TabIndex = 1063;
		Label14.TextAlign = (ContentAlignment)16;
		DataGridView_RECE_SORT.AllowUserToAddRows = false;
		DataGridView_RECE_SORT.AllowUserToResizeColumns = false;
		DataGridView_RECE_SORT.AllowUserToResizeRows = false;
		DataGridView_RECE_SORT.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)16;
		DataGridView_RECE_SORT.BackgroundColor = Color.White;
		DataGridView_RECE_SORT.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		DataGridView_RECE_SORT.Columns.AddRange(new DataGridViewColumn[4]
		{
			(DataGridViewColumn)ID_DOC,
			(DataGridViewColumn)DATES_RECE_SORT,
			(DataGridViewColumn)TOTAL_NET_ACHATS,
			(DataGridViewColumn)TYPE
		});
		DataGridView_RECE_SORT.EditMode = (DataGridViewEditMode)4;
		DataGridView_RECE_SORT.EnableHeadersVisualStyles = false;
		DataGridView dataGridView_RECE_SORT = DataGridView_RECE_SORT;
		location = new Point(6, 58);
		((Control)dataGridView_RECE_SORT).Location = location;
		((Control)DataGridView_RECE_SORT).Name = "DataGridView_RECE_SORT";
		DataGridView_RECE_SORT.RowHeadersVisible = false;
		DataGridView_RECE_SORT.RowHeadersWidth = 11;
		DataGridView_RECE_SORT.SelectionMode = (DataGridViewSelectionMode)1;
		DataGridView dataGridView_RECE_SORT2 = DataGridView_RECE_SORT;
		size = new Size(427, 192);
		((Control)dataGridView_RECE_SORT2).Size = size;
		((Control)DataGridView_RECE_SORT).TabIndex = 1080;
		((DataGridViewColumn)ID_DOC).DataPropertyName = "ID_DOC";
		((DataGridViewColumn)ID_DOC).HeaderText = "ID_DOC";
		((DataGridViewColumn)ID_DOC).Name = "ID_DOC";
		((DataGridViewColumn)DATES_RECE_SORT).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)DATES_RECE_SORT).DataPropertyName = "DATES";
		((DataGridViewColumn)DATES_RECE_SORT).HeaderText = "DATES";
		((DataGridViewColumn)DATES_RECE_SORT).Name = "DATES_RECE_SORT";
		((DataGridViewColumn)TOTAL_NET_ACHATS).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)TOTAL_NET_ACHATS).DataPropertyName = "TOTAL_NET_ACHATS";
		val3.Format = "N2";
		val3.NullValue = null;
		((DataGridViewColumn)TOTAL_NET_ACHATS).DefaultCellStyle = val3;
		((DataGridViewColumn)TOTAL_NET_ACHATS).HeaderText = "TOTAL_NET_ACHATS";
		((DataGridViewColumn)TOTAL_NET_ACHATS).Name = "TOTAL_NET_ACHATS";
		((DataGridViewColumn)TOTAL_NET_ACHATS).Width = 150;
		((DataGridViewColumn)TYPE).DataPropertyName = "TYPE";
		((DataGridViewColumn)TYPE).HeaderText = "TYPE";
		((DataGridViewColumn)TYPE).Name = "TYPE";
		((Control)Button_PrintRapport_2).Cursor = Cursors.Hand;
		((Control)Button_PrintRapport_2).Font = new Font("Tahoma", 9f, (FontStyle)1);
		((ButtonBase)Button_PrintRapport_2).Image = (Image)componentResourceManager.GetObject("Button_PrintRapport_2.Image");
		((ButtonBase)Button_PrintRapport_2).ImageAlign = (ContentAlignment)16;
		Button button_PrintRapport_ = Button_PrintRapport_2;
		location = new Point(722, 417);
		((Control)button_PrintRapport_).Location = location;
		((Control)Button_PrintRapport_2).Name = "Button_PrintRapport_2";
		Button button_PrintRapport_2 = Button_PrintRapport_2;
		size = new Size(160, 36);
		((Control)button_PrintRapport_2).Size = size;
		((Control)Button_PrintRapport_2).TabIndex = 1081;
		((ButtonBase)Button_PrintRapport_2).Text = "IMPRIMER";
		((ButtonBase)Button_PrintRapport_2).UseVisualStyleBackColor = true;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).BackColor = Color.White;
		size = new Size(1025, 692);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)Panel112233);
		((Control)this).Controls.Add((Control)(object)Panel_FIND);
		((Control)this).Controls.Add((Control)(object)Panel_FONCTIONS);
		((Control)this).Controls.Add((Control)(object)Button_FONCTIONS);
		((Control)this).Controls.Add((Control)(object)Button1);
		((Control)this).Controls.Add((Control)(object)Label_TABLE);
		((Control)this).Controls.Add((Control)(object)Button_ADD);
		((Control)this).Controls.Add((Control)(object)Panel_HISTORIQUE);
		((Control)this).Controls.Add((Control)(object)Panel_INFO);
		((Control)this).Controls.Add((Control)(object)DataGridView1);
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Form)this).KeyPreview = true;
		((Control)this).Name = "Form_6_FOURNISSEURS";
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).WindowState = (FormWindowState)2;
		((Control)Panel_INFO).ResumeLayout(false);
		((Control)TabControl1).ResumeLayout(false);
		((Control)TabPage1).ResumeLayout(false);
		((Control)TabPage1).PerformLayout();
		((ISupportInitialize)DataGridView1).EndInit();
		((Control)Panel_HISTORIQUE).ResumeLayout(false);
		((Control)TabControl2).ResumeLayout(false);
		((Control)TabPage5).ResumeLayout(false);
		((Control)TabPage5).PerformLayout();
		((ISupportInitialize)PictureBox3).EndInit();
		((ISupportInitialize)PictureBox2).EndInit();
		((ISupportInitialize)DataGridView_REGLEMENTS).EndInit();
		((Control)TabPage2).ResumeLayout(false);
		((ISupportInitialize)DataGridView_DETAILS_SORTIES).EndInit();
		((ISupportInitialize)PictureBox4).EndInit();
		((ISupportInitialize)DataGridView_DETAILS_RECEPTIONS).EndInit();
		((Control)Panel_FONCTIONS).ResumeLayout(false);
		((Control)Panel_FIND).ResumeLayout(false);
		((Control)Panel_FIND).PerformLayout();
		((Control)Panel_DATES).ResumeLayout(false);
		((ISupportInitialize)Picture_FIND_DATES).EndInit();
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)Panel112233).ResumeLayout(false);
		((ISupportInitialize)DataGridView_RECE_SORT).EndInit();
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

	private void FormDialog_famille_Load(object sender, EventArgs e)
	{
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Expected Obj, but got Unknown
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Expected Obj, but got Unknown
		//IL_0ac6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0acd: Expected Obj, but got Unknown
		//IL_037d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0387: Expected Obj, but got Unknown
		//IL_039e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a8: Expected Obj, but got Unknown
		//IL_0535: Unknown result type (might be due to invalid IL or missing references)
		//IL_053f: Expected Obj, but got Unknown
		//IL_0556: Unknown result type (might be due to invalid IL or missing references)
		//IL_0560: Expected Obj, but got Unknown
		//IL_06ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f7: Expected Obj, but got Unknown
		//IL_070e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0718: Expected Obj, but got Unknown
		//IL_08a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08af: Expected Obj, but got Unknown
		//IL_08c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d0: Expected Obj, but got Unknown
		//IL_0999: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a3: Expected Obj, but got Unknown
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
				DataGridView_RECE_SORT.AutoGenerateColumns = false;
				DataGridView_RECE_SORT.RowTemplate.Height = 30;
				DataGridView_RECE_SORT.BackgroundColor = Color.White;
				DataGridView_RECE_SORT.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(34, 34, 34);
				DataGridView_RECE_SORT.DefaultCellStyle.SelectionBackColor = Color.Yellow;
				DataGridView_RECE_SORT.DefaultCellStyle.SelectionForeColor = Color.Red;
				DataGridView_RECE_SORT.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(221, 235, 247);
				DataGridView_RECE_SORT.GridColor = Color.FromArgb(231, 231, 231);
				DataGridView_RECE_SORT.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10f, (FontStyle)1);
				DataGridView_RECE_SORT.DefaultCellStyle.Font = new Font("Segoe UI", 10f, (FontStyle)0);
				DataGridView_RECE_SORT.ColumnHeadersBorderStyle = (DataGridViewHeaderBorderStyle)1;
				DataGridView_RECE_SORT.ColumnHeadersDefaultCellStyle.Alignment = (DataGridViewContentAlignment)16;
				DataGridView_RECE_SORT.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)0;
				DataGridView_RECE_SORT.AutoResizeColumnHeadersHeight();
				DataGridView_RECE_SORT.CellBorderStyle = (DataGridViewCellBorderStyle)5;
				DataGridView_RECE_SORT.SelectionMode = (DataGridViewSelectionMode)1;
				DataGridView_RECE_SORT.MultiSelect = true;
				DataGridView_RECE_SORT.EditMode = (DataGridViewEditMode)4;
				DataGridView_RECE_SORT.ClipboardCopyMode = (DataGridViewClipboardCopyMode)0;
				int num5 = ((BaseCollection)DataGridView_RECE_SORT.Columns).Count - 1;
				int num6 = 0;
				while (true)
				{
					int num7 = num6;
					int num4 = num5;
					if (num7 > num4)
					{
						break;
					}
					DataGridView_RECE_SORT.Columns[num6].SortMode = (DataGridViewColumnSortMode)2;
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
				DataGridView_DETAILS_RECEPTIONS.AutoGenerateColumns = false;
				DataGridView_DETAILS_RECEPTIONS.RowTemplate.Height = 30;
				DataGridView_DETAILS_RECEPTIONS.BackgroundColor = Color.White;
				DataGridView_DETAILS_RECEPTIONS.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(34, 34, 34);
				DataGridView_DETAILS_RECEPTIONS.DefaultCellStyle.SelectionBackColor = Color.Yellow;
				DataGridView_DETAILS_RECEPTIONS.DefaultCellStyle.SelectionForeColor = Color.Red;
				DataGridView_DETAILS_RECEPTIONS.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(221, 235, 247);
				DataGridView_DETAILS_RECEPTIONS.GridColor = Color.FromArgb(231, 231, 231);
				DataGridView_DETAILS_RECEPTIONS.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10f, (FontStyle)1);
				DataGridView_DETAILS_RECEPTIONS.DefaultCellStyle.Font = new Font("Segoe UI", 10f, (FontStyle)0);
				DataGridView_DETAILS_RECEPTIONS.ColumnHeadersBorderStyle = (DataGridViewHeaderBorderStyle)1;
				DataGridView_DETAILS_RECEPTIONS.ColumnHeadersDefaultCellStyle.Alignment = (DataGridViewContentAlignment)16;
				DataGridView_DETAILS_RECEPTIONS.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)0;
				DataGridView_DETAILS_RECEPTIONS.AutoResizeColumnHeadersHeight();
				DataGridView_DETAILS_RECEPTIONS.CellBorderStyle = (DataGridViewCellBorderStyle)5;
				DataGridView_DETAILS_RECEPTIONS.SelectionMode = (DataGridViewSelectionMode)1;
				DataGridView_DETAILS_RECEPTIONS.MultiSelect = true;
				DataGridView_DETAILS_RECEPTIONS.EditMode = (DataGridViewEditMode)4;
				DataGridView_DETAILS_RECEPTIONS.ClipboardCopyMode = (DataGridViewClipboardCopyMode)0;
				int num11 = ((BaseCollection)DataGridView_DETAILS_RECEPTIONS.Columns).Count - 1;
				int num12 = 0;
				while (true)
				{
					int num13 = num12;
					int num4 = num11;
					if (num13 > num4)
					{
						break;
					}
					DataGridView_DETAILS_RECEPTIONS.Columns[num12].SortMode = (DataGridViewColumnSortMode)2;
					num12++;
				}
				DataGridView_DETAILS_SORTIES.AutoGenerateColumns = false;
				DataGridView_DETAILS_SORTIES.RowTemplate.Height = 30;
				DataGridView_DETAILS_SORTIES.BackgroundColor = Color.White;
				DataGridView_DETAILS_SORTIES.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(34, 34, 34);
				DataGridView_DETAILS_SORTIES.DefaultCellStyle.SelectionBackColor = Color.Yellow;
				DataGridView_DETAILS_SORTIES.DefaultCellStyle.SelectionForeColor = Color.Red;
				DataGridView_DETAILS_SORTIES.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(221, 235, 247);
				DataGridView_DETAILS_SORTIES.GridColor = Color.FromArgb(231, 231, 231);
				DataGridView_DETAILS_SORTIES.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10f, (FontStyle)1);
				DataGridView_DETAILS_SORTIES.DefaultCellStyle.Font = new Font("Segoe UI", 10f, (FontStyle)0);
				DataGridView_DETAILS_SORTIES.ColumnHeadersBorderStyle = (DataGridViewHeaderBorderStyle)1;
				DataGridView_DETAILS_SORTIES.ColumnHeadersDefaultCellStyle.Alignment = (DataGridViewContentAlignment)16;
				DataGridView_DETAILS_SORTIES.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)0;
				DataGridView_DETAILS_SORTIES.AutoResizeColumnHeadersHeight();
				DataGridView_DETAILS_SORTIES.CellBorderStyle = (DataGridViewCellBorderStyle)5;
				DataGridView_DETAILS_SORTIES.SelectionMode = (DataGridViewSelectionMode)1;
				DataGridView_DETAILS_SORTIES.MultiSelect = true;
				DataGridView_DETAILS_SORTIES.EditMode = (DataGridViewEditMode)4;
				DataGridView_DETAILS_SORTIES.ClipboardCopyMode = (DataGridViewClipboardCopyMode)0;
				int num14 = ((BaseCollection)DataGridView_DETAILS_SORTIES.Columns).Count - 1;
				int num15 = 0;
				while (true)
				{
					int num16 = num15;
					int num4 = num14;
					if (num16 > num4)
					{
						break;
					}
					DataGridView_DETAILS_SORTIES.Columns[num15].SortMode = (DataGridViewColumnSortMode)2;
					num15++;
				}
				DA = new MySqlDataAdapter("select * from     TABLE_FOURNISSEURS             order by       ID      DESC", Module1.cn_SQL);
				DT = new DataTable();
				DT.Clear();
				((DbDataAdapter)(object)DA).Fill(DT);
				DataGridView1.DataSource = DT;
				TabControl1.SizeMode = (TabSizeMode)2;
				TabControl tabControl = TabControl1;
				Size itemSize = new Size((int)Math.Round((double)((Control)TabControl1).Width / (double)TabControl1.TabCount - 4.0), 28);
				tabControl.ItemSize = itemSize;
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

	private void Button19_Click(object sender, EventArgs e)
	{
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Expected Obj, but got Unknown
		try
		{
			((Control)Panel_INFO).Visible = true;
			((Control)Panel_INFO).BringToFront();
			Label_TOP.Text = "NOUVEAU";
			((Control)Button_SAVE).Visible = true;
			Text_ID.Text = "";
			Text_ID_FOURNISSEUR.Text = "";
			DateTimePicker_DATE.Text = Conversions.ToString(DateTime.Now.Date);
			Text_CODE_FOURNISSEUR.Text = "";
			Text_FOURNISSEUR.Text = "";
			Text_ICE.Text = "";
			Text_ADRESSE.Text = "";
			Text_VILLE.Text = "";
			Text_PAYS.Text = "";
			Text_TEL.Text = "";
			Text_NOTE.Text = "";
			Text_CREDIT_INITIAL.Text = "0";
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
		//IL_0569: Unknown result type (might be due to invalid IL or missing references)
		//IL_0570: Expected Obj, but got Unknown
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
				Label_INDEX.Text = Conversions.ToString(((DataGridViewBand)DataGridView1.CurrentRow).Index);
				Label_TOP.Text = "MODIFICATION";
				((Control)Button_SAVE).Visible = true;
				int position2 = ((ContainerControl)this).BindingContext[(object)DT].Position;
				Text_ID.Text = DT.Rows[position2]["ID"].ToString();
				Text_ID_FOURNISSEUR.Text = DT.Rows[position2]["ID_FOURNISSEUR"].ToString();
				Text_CODE_FOURNISSEUR.Text = DT.Rows[position2]["CODE_FOURNISSEUR"].ToString();
				Text_FOURNISSEUR.Text = DT.Rows[position2]["FOURNISSEUR"].ToString();
				DateTimePicker_DATE.Text = Conversions.ToDate(DT.Rows[position2]["DATES"]).ToString("yyyy-MM-dd");
				Text_ICE.Text = DT.Rows[position2]["ICE"].ToString();
				Text_ADRESSE.Text = DT.Rows[position2]["ADRESSE"].ToString();
				Text_VILLE.Text = DT.Rows[position2]["VILLE"].ToString();
				Text_PAYS.Text = DT.Rows[position2]["PAYS"].ToString();
				Text_TEL.Text = DT.Rows[position2]["TELEPHONE"].ToString();
				Text_NOTE.Text = DT.Rows[position2]["NOTES"].ToString();
				Text_ETAT.Text = DT.Rows[position2]["ETAT"].ToString();
				Text_CREDIT_INITIAL.Text = DT.Rows[position2]["CREDIT_INITIAL"].ToString();
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
		//IL_0b79: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b80: Expected Obj, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected Obj, but got Unknown
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected Obj, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected Obj, but got Unknown
		//IL_06e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f2: Expected Obj, but got Unknown
		//IL_05c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cb: Expected Obj, but got Unknown
		//IL_0625: Unknown result type (might be due to invalid IL or missing references)
		//IL_062c: Expected Obj, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_0967: Unknown result type (might be due to invalid IL or missing references)
		//IL_096e: Expected Obj, but got Unknown
		//IL_099a: Unknown result type (might be due to invalid IL or missing references)
		//IL_072b: Unknown result type (might be due to invalid IL or missing references)
		//IL_067d: Unknown result type (might be due to invalid IL or missing references)
		//IL_048f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0496: Expected Obj, but got Unknown
		//IL_050d: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			try
			{
				if (Operators.CompareString(Text_FOURNISSEUR.Text, "", TextCompare: false) == 0)
				{
					MessageBox.Show("Veuillez remplir le champ -FOURNISSEUR- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
				if (Operators.CompareString(Text_CREDIT_INITIAL.Text, "", TextCompare: false) == 0)
				{
					MessageBox.Show("Veuillez remplir le champ -CREDIT_INITIAL- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
				if (Operators.CompareString(Label_TOP.Text, "NOUVEAU", TextCompare: false) == 0)
				{
					if (Operators.CompareString(Text_CODE_FOURNISSEUR.Text, "", TextCompare: false) != 0)
					{
						DataTable dataTable = new DataTable();
						MySqlDataAdapter val = new MySqlDataAdapter();
						dataTable.Clear();
						val = new MySqlDataAdapter("select ID,CODE_FOURNISSEUR,FOURNISSEUR     from TABLE_FOURNISSEURS WHERE   CODE_FOURNISSEUR = '" + Text_CODE_FOURNISSEUR.Text + "'", Module1.cn_SQL);
						((DbDataAdapter)(object)val).Fill(dataTable);
						if (dataTable.Rows.Count != 0)
						{
							MessageBox.Show(Conversions.ToString(Operators.ConcatenateObject("Ce Code est déja utilisé pour ==> ", dataTable.Rows[0]["FOURNISSEUR"])), "Attetion", (MessageBoxButtons)0, (MessageBoxIcon)48, (MessageBoxDefaultButton)0);
							return;
						}
					}
					MySqlCommand val2 = new MySqlCommand();
					val2.CommandText = "SELECT MAX(ID) From TABLE_FOURNISSEURS ";
					val2.Connection = Module1.cn_SQL;
					val2.CommandType = CommandType.Text;
					if (Module1.cn_SQL.State != ConnectionState.Open)
					{
						Module1.cn_SQL.Open();
					}
					int num = ((val2.ExecuteScalar() == DBNull.Value) ? 1 : ((int)Math.Round(Conversions.ToDouble(val2.ExecuteScalar()) + 1.0)));
					Module1.cn_SQL.Close();
					val2.CommandText = "Select FOURNISSEUR from TABLE_NUM  where ID = 0 ";
					val2.Connection = Module1.cn_SQL;
					val2.CommandType = CommandType.Text;
					if (Module1.cn_SQL.State != ConnectionState.Open)
					{
						Module1.cn_SQL.Open();
					}
					string value = ((val2.ExecuteScalar() != DBNull.Value) ? ("FR" + Strings.Format(Conversions.ToDouble(val2.ExecuteScalar()), "000000")) : Conversions.ToString(0));
					Module1.cn_SQL.Close();
					DT.Rows.Add();
					int index = DT.Rows.Count - 1;
					DT.Rows[index]["ID"] = num;
					DT.Rows[index]["ID_FOURNISSEUR"] = value;
					DT.Rows[index]["CODE_FOURNISSEUR"] = Strings.Trim(Text_CODE_FOURNISSEUR.Text);
					DT.Rows[index]["FOURNISSEUR"] = Strings.Trim(Text_FOURNISSEUR.Text);
					DT.Rows[index]["DATES"] = DateTimePicker_DATE.Value;
					DT.Rows[index]["ICE"] = Text_ICE.Text;
					DT.Rows[index]["ADRESSE"] = Text_ADRESSE.Text;
					DT.Rows[index]["VILLE"] = Text_VILLE.Text;
					DT.Rows[index]["PAYS"] = Text_PAYS.Text;
					DT.Rows[index]["TELEPHONE"] = Text_TEL.Text;
					DT.Rows[index]["NOTES"] = Text_NOTE.Text;
					DT.Rows[index]["ETAT"] = "VALIDER";
					DT.Rows[index]["CREDIT_INITIAL"] = Text_CREDIT_INITIAL.Text;
					MySqlCommandBuilder val3 = new MySqlCommandBuilder(DA);
					((DbDataAdapter)(object)DA).Update(DT);
					DT.AcceptChanges();
					if (Module1.cn_SQL.State != ConnectionState.Open)
					{
						Module1.cn_SQL.Open();
					}
					val2.CommandText = "UPDATE     TABLE_NUM    SET FOURNISSEUR =  FOURNISSEUR + 1   ";
					val2.Connection = Module1.cn_SQL;
					val2.ExecuteNonQuery();
					Module1.cn_SQL.Close();
					MessageBox.Show("Enregistré avec succès", "ok", (MessageBoxButtons)0, (MessageBoxIcon)64, (MessageBoxDefaultButton)0);
				}
				else if (Operators.CompareString(Label_TOP.Text, "MODIFICATION", TextCompare: false) == 0)
				{
					DataGridView1.CurrentCell = DataGridView1.Rows[Conversions.ToInteger(Label_INDEX.Text)].Cells[0];
					DataGridView1.Rows[Conversions.ToInteger(Label_INDEX.Text)].Selected = true;
					if (Operators.CompareString(Text_CODE_FOURNISSEUR.Text, "", TextCompare: false) != 0)
					{
						DataTable dataTable2 = new DataTable();
						MySqlDataAdapter val4 = new MySqlDataAdapter();
						dataTable2.Clear();
						val4 = new MySqlDataAdapter("select ID,CODE_FOURNISSEUR,FOURNISSEUR     from TABLE_FOURNISSEURS WHERE   CODE_FOURNISSEUR = '" + Text_CODE_FOURNISSEUR.Text + "'    AND    ID <> " + Text_ID.Text + "    ", Module1.cn_SQL);
						((DbDataAdapter)(object)val4).Fill(dataTable2);
						if (dataTable2.Rows.Count != 0)
						{
							MessageBox.Show(Conversions.ToString(Operators.ConcatenateObject("Ce Code est déja utilisé pour ==> ", dataTable2.Rows[0]["FOURNISSEUR"])), "Attetion", (MessageBoxButtons)0, (MessageBoxIcon)48, (MessageBoxDefaultButton)0);
							return;
						}
					}
					Module1._DT_TEMP.Clear();
					Module1._DA_TEMP = new MySqlDataAdapter("select ID,ID_FOURNISSEUR     from TABLE_FOURNISSEURS WHERE   ID_FOURNISSEUR = '" + Text_ID_FOURNISSEUR.Text + "'    AND    ID <> " + Text_ID.Text + "    ", Module1.cn_SQL);
					((DbDataAdapter)(object)Module1._DA_TEMP).Fill(Module1._DT_TEMP);
					if (Module1._DT_TEMP.Rows.Count != 0)
					{
						MessageBox.Show("Cet ID est déja utilisé", "Attetion", (MessageBoxButtons)0, (MessageBoxIcon)48, (MessageBoxDefaultButton)0);
						return;
					}
					int position = ((ContainerControl)this).BindingContext[(object)DT].Position;
					DT.Rows[position]["ID"] = Text_ID.Text;
					DT.Rows[position]["ID_FOURNISSEUR"] = Text_ID_FOURNISSEUR.Text;
					DT.Rows[position]["CODE_FOURNISSEUR"] = Strings.Trim(Text_CODE_FOURNISSEUR.Text);
					DT.Rows[position]["FOURNISSEUR"] = Strings.Trim(Text_FOURNISSEUR.Text);
					DT.Rows[position]["DATES"] = DateTimePicker_DATE.Value;
					DT.Rows[position]["ICE"] = Text_ICE.Text;
					DT.Rows[position]["ADRESSE"] = Text_ADRESSE.Text;
					DT.Rows[position]["VILLE"] = Text_VILLE.Text;
					DT.Rows[position]["PAYS"] = Text_PAYS.Text;
					DT.Rows[position]["TELEPHONE"] = Text_TEL.Text;
					DT.Rows[position]["NOTES"] = Text_NOTE.Text;
					DT.Rows[position]["ETAT"] = "VALIDER";
					DT.Rows[position]["CREDIT_INITIAL"] = Text_CREDIT_INITIAL.Text;
					MySqlCommandBuilder val5 = new MySqlCommandBuilder(DA);
					((DbDataAdapter)(object)DA).Update(DT);
					DT.AcceptChanges();
					MessageBox.Show("Modifié avec succès", "ok", (MessageBoxButtons)0, (MessageBoxIcon)64, (MessageBoxDefaultButton)0);
					string right = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("MODIFICATION | ", DataGridView1.Rows[((DataGridViewBand)DataGridView1.CurrentRow).Index].Cells["ID_FOURNISSEUR"].Value), DataGridView1.Rows[((DataGridViewBand)DataGridView1.CurrentRow).Index].Cells["FOURNISSEUR"].Value));
					File.AppendAllText(Application.StartupPath + "\\log.sni", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(Strings.Format(DateTime.Now, "ddMMyy HHmmss fff") + MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text, " | "), Module1._USERNAME), " | "), ((Control)this).Name), " | "), NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null)), " | "), right), "\r\n")), Encoding.UTF8);
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
			DA = new MySqlDataAdapter("select * from   TABLE_FOURNISSEURS        order by   ID    desc ", Module1.cn_SQL);
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

	private void Button1_Click(object sender, EventArgs e)
	{
		try
		{
			if (DataGridView1.Rows.Count != 0)
			{
				((Control)Panel_HISTORIQUE).Visible = true;
				((Control)Panel_HISTORIQUE).BringToFront();
				Label_HISTORIQUE_ID_FOURNISSEUR.Text = DataGridView1.Rows[((DataGridViewBand)DataGridView1.CurrentRow).Index].Cells["ID_FOURNISSEUR"].Value.ToString();
				Label_HISTORIQUE_FOURNISSEUR.Text = DataGridView1.Rows[((DataGridViewBand)DataGridView1.CurrentRow).Index].Cells["FOURNISSEUR"].Value.ToString();
				DataGridView_RECE_SORT.DataSource = null;
				DataGridView_REGLEMENTS.DataSource = null;
				DataGridView_DETAILS_RECEPTIONS.DataSource = null;
				DataGridView_DETAILS_SORTIES.DataSource = null;
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
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected Obj, but got Unknown
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected Obj, but got Unknown
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected Obj, but got Unknown
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Expected Obj, but got Unknown
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Expected Obj, but got Unknown
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Expected Obj, but got Unknown
		//IL_03bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c2: Expected Obj, but got Unknown
		//IL_04e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ed: Expected Obj, but got Unknown
		//IL_05a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ad: Expected Obj, but got Unknown
		DataTable dataTable = new DataTable();
		MySqlDataAdapter val = new MySqlDataAdapter();
		dataTable.Clear();
		val = new MySqlDataAdapter("select     ID_BR as ID_DOC ,DATES,TOTAL_NET_ACHATS  , 'RECEPTION' AS Type          from   TABLE_RECEPTIONS_ENTETE   Where         DATES   between   ' " + Strings.Format(DateTimePicker3.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker4.Value, "yyyy-MM-dd") + " '        AND   ID_FOURNISSEUR  =  '" + Label_HISTORIQUE_ID_FOURNISSEUR.Text + "'                UNION ALL          select         ID_BS as ID_DOC ,DATES,TOTAL_NET_ACHATS , 'SORTIE' AS Type             from   TABLE_SORTIES_ENTETE     Where         DATES   between   ' " + Strings.Format(DateTimePicker3.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker4.Value, "yyyy-MM-dd") + " '        AND   ID_FOURNISSEUR  =  '" + Label_HISTORIQUE_ID_FOURNISSEUR.Text + "'                order by Dates  desc ", Module1.cn_SQL);
		((DbDataAdapter)(object)val).Fill(dataTable);
		DataGridView_RECE_SORT.DataSource = dataTable;
		DataTable dataTable2 = new DataTable();
		MySqlDataAdapter val2 = new MySqlDataAdapter();
		dataTable2.Clear();
		val2 = new MySqlDataAdapter("select     ID_REGLE , DATES, MONTANT, NOTES           from   TABLE_FOURNISSEURS_REGLE     Where         DATES   between   ' " + Strings.Format(DateTimePicker3.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker4.Value, "yyyy-MM-dd") + " '        AND     ID_FOURNISSEUR  =  '" + Label_HISTORIQUE_ID_FOURNISSEUR.Text + "'                 order by ID  desc ", Module1.cn_SQL);
		((DbDataAdapter)(object)val2).Fill(dataTable2);
		DataGridView_REGLEMENTS.DataSource = dataTable2;
		DataTable dataTable3 = new DataTable();
		MySqlDataAdapter val3 = new MySqlDataAdapter();
		dataTable3.Clear();
		val3 = new MySqlDataAdapter("SELECT    SUM(TOTAL_NET_ACHATS)      as N          FROM   TABLE_RECEPTIONS_ENTETE     WHERE      DATES   between   ' " + Strings.Format(DateTimePicker3.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker4.Value, "yyyy-MM-dd") + " '        AND        ID_FOURNISSEUR  =  '" + Label_HISTORIQUE_ID_FOURNISSEUR.Text + "'                ", Module1.cn_SQL);
		((DbDataAdapter)(object)val3).Fill(dataTable3);
		decimal num = 0m;
		num = ((dataTable3.Rows[0]["N"] != DBNull.Value) ? Conversions.ToDecimal(Strings.FormatNumber(RuntimeHelpers.GetObjectValue(dataTable3.Rows[0]["N"]))) : Conversions.ToDecimal(Strings.FormatNumber(0)));
		Label_RECEPETIONS.Text = Conversions.ToString(num);
		dataTable3.Clear();
		val3 = new MySqlDataAdapter("SELECT    SUM(TOTAL_NET_ACHATS)      as N          FROM   TABLE_SORTIES_ENTETE     WHERE      DATES   between   ' " + Strings.Format(DateTimePicker3.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker4.Value, "yyyy-MM-dd") + " '        AND        ID_FOURNISSEUR  =  '" + Label_HISTORIQUE_ID_FOURNISSEUR.Text + "'                ", Module1.cn_SQL);
		((DbDataAdapter)(object)val3).Fill(dataTable3);
		decimal num2 = 0m;
		num2 = ((dataTable3.Rows[0]["N"] != DBNull.Value) ? Conversions.ToDecimal(Strings.FormatNumber(RuntimeHelpers.GetObjectValue(dataTable3.Rows[0]["N"]))) : Conversions.ToDecimal(Strings.FormatNumber(0)));
		Label_SORTIES.Text = Conversions.ToString(num2);
		dataTable3.Clear();
		val3 = new MySqlDataAdapter("SELECT    SUM(MONTANT)      as N          FROM   TABLE_FOURNISSEURS_REGLE     WHERE       DATES   between   ' " + Strings.Format(DateTimePicker3.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker4.Value, "yyyy-MM-dd") + " '        AND       ID_FOURNISSEUR  =  '" + Label_HISTORIQUE_ID_FOURNISSEUR.Text + "'                        ", Module1.cn_SQL);
		((DbDataAdapter)(object)val3).Fill(dataTable3);
		decimal num3 = 0m;
		num3 = ((dataTable3.Rows[0]["N"] != DBNull.Value) ? Conversions.ToDecimal(Strings.FormatNumber(RuntimeHelpers.GetObjectValue(dataTable3.Rows[0]["N"]))) : Conversions.ToDecimal(Strings.FormatNumber(0)));
		Label_REGLE_FOURNISSEUR.Text = Conversions.ToString(num3);
		dataTable3.Clear();
		val3 = new MySqlDataAdapter("select    SUM(CREDIT_INITIAL)      as N           from   TABLE_FOURNISSEURS       WHERE        ID_FOURNISSEUR  =  '" + Label_HISTORIQUE_ID_FOURNISSEUR.Text + "'                 ", Module1.cn_SQL);
		((DbDataAdapter)(object)val3).Fill(dataTable3);
		decimal num4 = 0m;
		num4 = ((dataTable3.Rows[0]["N"] != DBNull.Value) ? Conversions.ToDecimal(Strings.FormatNumber(RuntimeHelpers.GetObjectValue(dataTable3.Rows[0]["N"]))) : Conversions.ToDecimal(Strings.FormatNumber(0)));
		Label_CREDIT_INITIAL.Text = Conversions.ToString(num4);
		Label_CREDIT.Text = Conversions.ToString(decimal.Add(decimal.Subtract(num, num2), num4));
		Label_REGLE.Text = Conversions.ToString(num3);
		Label_BALANCE.Text = Conversions.ToString(decimal.Subtract(decimal.Add(decimal.Subtract(num, num2), num4), num3)) + " DH";
	}

	private void Button3_Click(object sender, EventArgs e)
	{
		((Control)Panel_HISTORIQUE).Hide();
	}

	private void Button_CREDIT_INITIAL_MODIF_Click(object sender, EventArgs e)
	{
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		if (!((Control)Text_CREDIT_INITIAL).Enabled)
		{
			MyProject.Forms.Form_6_FOURNISSEURS_MODIFICATION_CREDIT_INITIAL.Text_ID_FOURNISSEUR.Text = Text_ID_FOURNISSEUR.Text;
			MyProject.Forms.Form_6_FOURNISSEURS_MODIFICATION_CREDIT_INITIAL.Text_FOURNISSEUR.Text = Text_FOURNISSEUR.Text;
			MyProject.Forms.Form_6_FOURNISSEURS_MODIFICATION_CREDIT_INITIAL.Text_VALEUR_ANCIENNE.Text = Text_CREDIT_INITIAL.Text;
			MyProject.Forms.Form_6_FOURNISSEURS_MODIFICATION_CREDIT_INITIAL.Text_VALEUR_NOUVELLE.Text = "";
			((Control)Panel_INFO).Hide();
			((Form)MyProject.Forms.Form_6_FOURNISSEURS_MODIFICATION_CREDIT_INITIAL).ShowDialog();
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
		((Form)MyProject.Forms.Form_6_FOURNISSEURS_HISTORIQUE_CREDIT_INITIAL).ShowDialog();
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
		Label4141.Text = "Nbr FOURNISSEURS : " + Conversions.ToString(DataGridView1.Rows.Count);
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected Obj, but got Unknown
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected Obj, but got Unknown
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Expected Obj, but got Unknown
		try
		{
			DataTable dataTable = new DataTable();
			MySqlDataAdapter val = new MySqlDataAdapter();
			dataTable.Clear();
			val = new MySqlDataAdapter("select     *            from   TABLE_RECEPTIONS_DETAILS     Where     DATES   between   ' " + Strings.Format(DateTimePicker5.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker6.Value, "yyyy-MM-dd") + " '       and    ID_FOURNISSEUR  =  '" + Label_HISTORIQUE_ID_FOURNISSEUR.Text + "'           order by ID  desc ", Module1.cn_SQL);
			((DbDataAdapter)(object)val).Fill(dataTable);
			DataGridView_DETAILS_RECEPTIONS.DataSource = dataTable;
			DataTable dataTable2 = new DataTable();
			MySqlDataAdapter val2 = new MySqlDataAdapter();
			dataTable2.Clear();
			val2 = new MySqlDataAdapter("select     *            from   TABLE_SORTIES_DETAILS     Where     DATES   between   ' " + Strings.Format(DateTimePicker5.Value, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(DateTimePicker6.Value, "yyyy-MM-dd") + " '       and    ID_FOURNISSEUR  =  '" + Label_HISTORIQUE_ID_FOURNISSEUR.Text + "'           order by ID  desc ", Module1.cn_SQL);
			((DbDataAdapter)(object)val2).Fill(dataTable2);
			DataGridView_DETAILS_SORTIES.DataSource = dataTable2;
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
				((Report)MyProject.Forms.Report_FOURNISSEURS_ETAT_HISTORIQUE.ReportViewer1.LocalReport).SetParameters(new ReportParameter("DATES", DateTimePicker3.Text + " --> " + DateTimePicker4.Text));
				((Report)MyProject.Forms.Report_FOURNISSEURS_ETAT_HISTORIQUE.ReportViewer1.LocalReport).SetParameters(new ReportParameter("ID_FOURNISSEUR", Label_HISTORIQUE_ID_FOURNISSEUR.Text));
				((Report)MyProject.Forms.Report_FOURNISSEURS_ETAT_HISTORIQUE.ReportViewer1.LocalReport).SetParameters(new ReportParameter("FOURNISSEUR", Label_HISTORIQUE_FOURNISSEUR.Text));
				((Report)MyProject.Forms.Report_FOURNISSEURS_ETAT_HISTORIQUE.ReportViewer1.LocalReport).SetParameters(new ReportParameter("RECEPTIONS", Label_RECEPETIONS.Text));
				((Report)MyProject.Forms.Report_FOURNISSEURS_ETAT_HISTORIQUE.ReportViewer1.LocalReport).SetParameters(new ReportParameter("SORTIES", Label_SORTIES.Text));
				((Report)MyProject.Forms.Report_FOURNISSEURS_ETAT_HISTORIQUE.ReportViewer1.LocalReport).SetParameters(new ReportParameter("CREDIT_INITIAL", Label_CREDIT_INITIAL.Text));
				((Report)MyProject.Forms.Report_FOURNISSEURS_ETAT_HISTORIQUE.ReportViewer1.LocalReport).SetParameters(new ReportParameter("REGLE_FOURNISSEUR", Label_REGLE_FOURNISSEUR.Text));
				((Report)MyProject.Forms.Report_FOURNISSEURS_ETAT_HISTORIQUE.ReportViewer1.LocalReport).SetParameters(new ReportParameter("BALANCE", Label_BALANCE.Text));
				DataTable dataTable = new DataTable();
				int num = ((BaseCollection)DataGridView_RECE_SORT.Columns).Count - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					dataTable.Columns.Add(DataGridView_RECE_SORT.Columns[num2].Name.ToString());
					dataTable.Columns[DataGridView_RECE_SORT.Columns[num2].Name.ToString()].Caption = DataGridView_RECE_SORT.Columns[num2].HeaderText.ToString();
					num2++;
				}
				int num5 = DataGridView_RECE_SORT.Rows.Count - 1;
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
					int num7 = ((BaseCollection)DataGridView_RECE_SORT.Columns).Count - 1;
					int num8 = 0;
					while (true)
					{
						int num9 = num8;
						num4 = num7;
						if (num9 > num4)
						{
							break;
						}
						dataTable.Rows[y][num8] = DataGridView_RECE_SORT.Rows[y].Cells[num8].Value.ToString();
						num8++;
					}
					y++;
				}
				ReportDataSource item = new ReportDataSource("DataSet1", dataTable);
				((Collection<ReportDataSource>)(object)MyProject.Forms.Report_FOURNISSEURS_ETAT_HISTORIQUE.ReportViewer1.LocalReport.DataSources).Clear();
				((Collection<ReportDataSource>)(object)MyProject.Forms.Report_FOURNISSEURS_ETAT_HISTORIQUE.ReportViewer1.LocalReport.DataSources).Add(item);
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
				((Collection<ReportDataSource>)(object)MyProject.Forms.Report_FOURNISSEURS_ETAT_HISTORIQUE.ReportViewer1.LocalReport.DataSources).Add(item2);
				MyProject.Forms.Report_FOURNISSEURS_ETAT_HISTORIQUE.ReportViewer1.RefreshReport();
				MyProject.Forms.Report_FOURNISSEURS_ETAT_HISTORIQUE.ReportViewer1.SetDisplayMode((DisplayMode)1);
				MyProject.Forms.Report_FOURNISSEURS_ETAT_HISTORIQUE.ReportViewer1.ZoomMode = (ZoomMode)2;
				MyProject.Forms.Report_FOURNISSEURS_ETAT_HISTORIQUE.ReportViewer1.ZoomPercent = 25;
				((Control)MyProject.Forms.Report_FOURNISSEURS_ETAT_HISTORIQUE).Show();
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
}
