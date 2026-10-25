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
public class Form_6_INVENTAIRES : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Button_ADD")]
	private Button _Button_ADD;

	[AccessedThroughProperty("Panel_INFO")]
	private Panel _Panel_INFO;

	[AccessedThroughProperty("Button_CLOSE")]
	private Button _Button_CLOSE;

	[AccessedThroughProperty("Button_SAVE")]
	private Button _Button_SAVE;

	[AccessedThroughProperty("DataGridView1")]
	private DataGridView _DataGridView1;

	[AccessedThroughProperty("Label24")]
	private Label _Label24;

	[AccessedThroughProperty("Text_CODE_FIND")]
	private TextBox _Text_CODE_FIND;

	[AccessedThroughProperty("Text_ID")]
	private TextBox _Text_ID;

	[AccessedThroughProperty("Button_FIND")]
	private Button _Button_FIND;

	[AccessedThroughProperty("DataGrid_BODY")]
	private DataGridView _DataGrid_BODY;

	[AccessedThroughProperty("Text_UTILISATEUR")]
	private TextBox _Text_UTILISATEUR;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("Text_ID_INV")]
	private TextBox _Text_ID_INV;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("DateTimePicker_DATE")]
	private DateTimePicker _DateTimePicker_DATE;

	[AccessedThroughProperty("Text_NOTES")]
	private TextBox _Text_NOTES;

	[AccessedThroughProperty("Label10")]
	private Label _Label10;

	[AccessedThroughProperty("Text_ETAT")]
	private TextBox _Text_ETAT;

	[AccessedThroughProperty("Label12")]
	private Label _Label12;

	[AccessedThroughProperty("TabControl1")]
	private TabControl _TabControl1;

	[AccessedThroughProperty("TabPage1")]
	private TabPage _TabPage1;

	[AccessedThroughProperty("TabPage2")]
	private TabPage _TabPage2;

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

	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	[AccessedThroughProperty("Label11")]
	private Label _Label11;

	[AccessedThroughProperty("Label14")]
	private Label _Label14;

	[AccessedThroughProperty("Label17")]
	private Label _Label17;

	[AccessedThroughProperty("Label18")]
	private Label _Label18;

	[AccessedThroughProperty("Panel4")]
	private Panel _Panel4;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("Label13")]
	private Label _Label13;

	[AccessedThroughProperty("Label20")]
	private Label _Label20;

	[AccessedThroughProperty("Label21")]
	private Label _Label21;

	[AccessedThroughProperty("Panel3")]
	private Panel _Panel3;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label28")]
	private Label _Label28;

	[AccessedThroughProperty("Label29")]
	private Label _Label29;

	[AccessedThroughProperty("Label30")]
	private Label _Label30;

	[AccessedThroughProperty("Panel5")]
	private Panel _Panel5;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[AccessedThroughProperty("Panel_INV_MASSE")]
	private Panel _Panel_INV_MASSE;

	[AccessedThroughProperty("Label23")]
	private Label _Label23;

	[AccessedThroughProperty("Label26")]
	private Label _Label26;

	[AccessedThroughProperty("PictureBox5")]
	private PictureBox _PictureBox5;

	[AccessedThroughProperty("ListBox1")]
	private ListBox _ListBox1;

	[AccessedThroughProperty("Button5")]
	private Button _Button5;

	[AccessedThroughProperty("Button_FERMER")]
	private Button _Button_FERMER;

	[AccessedThroughProperty("Label9")]
	private Label _Label9;

	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	[AccessedThroughProperty("Label16")]
	private Label _Label16;

	[AccessedThroughProperty("Label22")]
	private Label _Label22;

	[AccessedThroughProperty("Button_ETAT_INVENTAIRE")]
	private Button _Button_ETAT_INVENTAIRE;

	[AccessedThroughProperty("Print_INV")]
	private PrintDocument _Print_INV;

	[AccessedThroughProperty("Button_VALIDER")]
	private Button _Button_VALIDER;

	[AccessedThroughProperty("Button_CALC_DOC")]
	private Button _Button_CALC_DOC;

	[AccessedThroughProperty("Panel6")]
	private Panel _Panel6;

	[AccessedThroughProperty("Text_CODE")]
	private TextBox _Text_CODE;

	[AccessedThroughProperty("Label34")]
	private Label _Label34;

	[AccessedThroughProperty("Label35")]
	private Label _Label35;

	[AccessedThroughProperty("Text_ARTICLE")]
	private TextBox _Text_ARTICLE;

	[AccessedThroughProperty("Label36")]
	private Label _Label36;

	[AccessedThroughProperty("Label37")]
	private Label _Label37;

	[AccessedThroughProperty("Label38")]
	private Label _Label38;

	[AccessedThroughProperty("Label39")]
	private Label _Label39;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("Label40")]
	private Label _Label40;

	[AccessedThroughProperty("Text_STOCK_ACTUEL")]
	private TextBox _Text_STOCK_ACTUEL;

	[AccessedThroughProperty("Label41")]
	private Label _Label41;

	[AccessedThroughProperty("Button4")]
	private Button _Button4;

	[AccessedThroughProperty("Text_ARTICLE_FIND")]
	private TextBox _Text_ARTICLE_FIND;

	[AccessedThroughProperty("DataGridView_ARTICLES")]
	private DataGridView _DataGridView_ARTICLES;

	[AccessedThroughProperty("Button_CALC_BD")]
	private Button _Button_CALC_BD;

	[AccessedThroughProperty("Button6")]
	private Button _Button6;

	[AccessedThroughProperty("Button23")]
	private Button _Button23;

	[AccessedThroughProperty("Panel243544")]
	private Panel _Panel243544;

	[AccessedThroughProperty("DataGridView_FAMILLES")]
	private DataGridView _DataGridView_FAMILLES;

	[AccessedThroughProperty("DataGridViewTextBoxColumn4")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn4;

	[AccessedThroughProperty("Panel7727")]
	private Panel _Panel7727;

	[AccessedThroughProperty("Button_CALC_ENREGISTRER")]
	private Button _Button_CALC_ENREGISTRER;

	[AccessedThroughProperty("PictureBox3")]
	private PictureBox _PictureBox3;

	[AccessedThroughProperty("TextBox33398")]
	private TextBox _TextBox33398;

	[AccessedThroughProperty("Label42")]
	private Label _Label42;

	[AccessedThroughProperty("Text_UNITE")]
	private TextBox _Text_UNITE;

	[AccessedThroughProperty("Label43")]
	private Label _Label43;

	[AccessedThroughProperty("Text_PRIX_A")]
	private TextBox _Text_PRIX_A;

	[AccessedThroughProperty("Button_RAPPORT")]
	private Button _Button_RAPPORT;

	[AccessedThroughProperty("Panel7")]
	private Panel _Panel7;

	[AccessedThroughProperty("ListBox2")]
	private ListBox _ListBox2;

	[AccessedThroughProperty("Button3")]
	private Button _Button3;

	[AccessedThroughProperty("Button8")]
	private Button _Button8;

	[AccessedThroughProperty("Label46")]
	private Label _Label46;

	[AccessedThroughProperty("Label47")]
	private Label _Label47;

	[AccessedThroughProperty("Label48")]
	private Label _Label48;

	[AccessedThroughProperty("Label49")]
	private Label _Label49;

	[AccessedThroughProperty("Print_INV_PRE")]
	private PrintDocument _Print_INV_PRE;

	[AccessedThroughProperty("Button_FONCTIONS")]
	private Button _Button_FONCTIONS;

	[AccessedThroughProperty("Panel_FONCTIONS")]
	private Panel _Panel_FONCTIONS;

	[AccessedThroughProperty("Button_PrintRapport")]
	private Button _Button_PrintRapport;

	[AccessedThroughProperty("Label44")]
	private Label _Label44;

	[AccessedThroughProperty("Label45")]
	private Label _Label45;

	[AccessedThroughProperty("Label50")]
	private Label _Label50;

	[AccessedThroughProperty("Label51")]
	private Label _Label51;

	[AccessedThroughProperty("Button_PDF")]
	private Button _Button_PDF;

	[AccessedThroughProperty("Button_EXCEL")]
	private Button _Button_EXCEL;

	[AccessedThroughProperty("Button_WORD")]
	private Button _Button_WORD;

	[AccessedThroughProperty("Button_PRINT_80MM")]
	private Button _Button_PRINT_80MM;

	[AccessedThroughProperty("Button_PRINT_A4")]
	private Button _Button_PRINT_A4;

	[AccessedThroughProperty("Button_SPLITE")]
	private Button _Button_SPLITE;

	[AccessedThroughProperty("PictureBox2323")]
	private PictureBox _PictureBox2323;

	[AccessedThroughProperty("Column1")]
	private DataGridViewTextBoxColumn _Column1;

	[AccessedThroughProperty("DataGridViewTextBoxColumn1")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn1;

	[AccessedThroughProperty("DataGridViewTextBoxColumn2")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn2;

	[AccessedThroughProperty("ID_ARTICLE")]
	private DataGridViewTextBoxColumn _ID_ARTICLE;

	[AccessedThroughProperty("Code")]
	private DataGridViewTextBoxColumn _Code;

	[AccessedThroughProperty("Article")]
	private DataGridViewTextBoxColumn _Article;

	[AccessedThroughProperty("Prix_A")]
	private DataGridViewTextBoxColumn _Prix_A;

	[AccessedThroughProperty("Stock_Logique")]
	private DataGridViewTextBoxColumn _Stock_Logique;

	[AccessedThroughProperty("Stock_Physique")]
	private DataGridViewTextBoxColumn _Stock_Physique;

	[AccessedThroughProperty("Ecart")]
	private DataGridViewTextBoxColumn _Ecart;

	[AccessedThroughProperty("Valeur")]
	private DataGridViewTextBoxColumn _Valeur;

	[AccessedThroughProperty("sup")]
	private DataGridViewImageColumn _sup;

	[AccessedThroughProperty("Text_ID_ARTICLE")]
	private TextBox _Text_ID_ARTICLE;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("Label_TABLE")]
	private Label _Label_TABLE;

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

	[AccessedThroughProperty("Label19")]
	private Label _Label19;

	[AccessedThroughProperty("Label25")]
	private Label _Label25;

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

	[AccessedThroughProperty("Text_FIND_BODY")]
	private RJTextBox _Text_FIND_BODY;

	[AccessedThroughProperty("Label27")]
	private Label _Label27;

	[AccessedThroughProperty("Label31")]
	private Label _Label31;

	[AccessedThroughProperty("Label_TOTAL_LIGNES_BD")]
	private Label _Label_TOTAL_LIGNES_BD;

	[AccessedThroughProperty("Label_TOTAL_NET_ACHATS_BD")]
	private Label _Label_TOTAL_NET_ACHATS_BD;

	[AccessedThroughProperty("Label32")]
	private Label _Label32;

	[AccessedThroughProperty("Label15")]
	private Label _Label15;

	[AccessedThroughProperty("Label33")]
	private Label _Label33;

	[AccessedThroughProperty("Label_TOTAL_LIGNES")]
	private Label _Label_TOTAL_LIGNES;

	[AccessedThroughProperty("Panel2")]
	private Panel _Panel2;

	[AccessedThroughProperty("DataGridView3")]
	private DataGridView _DataGridView3;

	[AccessedThroughProperty("DataGridViewTextBoxColumn3")]
	private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn3;

	[AccessedThroughProperty("DataGridView2")]
	private DataGridView _DataGridView2;

	[AccessedThroughProperty("COL_1")]
	private DataGridViewTextBoxColumn _COL_1;

	[AccessedThroughProperty("COL_2")]
	private DataGridViewTextBoxColumn _COL_2;

	[AccessedThroughProperty("COL_3")]
	private DataGridViewTextBoxColumn _COL_3;

	[AccessedThroughProperty("Panel_CLAVIER")]
	private Panel _Panel_CLAVIER;

	[AccessedThroughProperty("Button_CLAVIER_NOSELECT1")]
	private Button_CLAVIER_NOSELECT _Button_CLAVIER_NOSELECT1;

	[AccessedThroughProperty("Butt_")]
	private Button_CLAVIER_NOSELECT _Butt_;

	[AccessedThroughProperty("Butt_DOT")]
	private Button_CLAVIER_NOSELECT _Butt_DOT;

	[AccessedThroughProperty("Butt_1")]
	private Button_CLAVIER_NOSELECT _Butt_1;

	[AccessedThroughProperty("Butt_2")]
	private Button_CLAVIER_NOSELECT _Butt_2;

	[AccessedThroughProperty("Butt_4")]
	private Button_CLAVIER_NOSELECT _Butt_4;

	[AccessedThroughProperty("Butt_3")]
	private Button_CLAVIER_NOSELECT _Butt_3;

	[AccessedThroughProperty("Butt_5")]
	private Button_CLAVIER_NOSELECT _Butt_5;

	[AccessedThroughProperty("Butt_7")]
	private Button_CLAVIER_NOSELECT _Butt_7;

	[AccessedThroughProperty("Butt_8")]
	private Button_CLAVIER_NOSELECT _Butt_8;

	[AccessedThroughProperty("Butt_BACK")]
	private Button_CLAVIER_NOSELECT _Butt_BACK;

	[AccessedThroughProperty("Butt_6")]
	private Button_CLAVIER_NOSELECT _Butt_6;

	[AccessedThroughProperty("Butt_9")]
	private Button_CLAVIER_NOSELECT _Butt_9;

	[AccessedThroughProperty("Butt_0")]
	private Button_CLAVIER_NOSELECT _Butt_0;

	[AccessedThroughProperty("Text_QTE")]
	private TextBox _Text_QTE;

	[AccessedThroughProperty("Button_CLAVIER")]
	private Button_CLAVIER_NOSELECT _Button_CLAVIER;

	[AccessedThroughProperty("Button_MOINS")]
	private Button _Button_MOINS;

	[AccessedThroughProperty("Button_PLUS")]
	private Button _Button_PLUS;

	[AccessedThroughProperty("Dates")]
	private DataGridViewTextBoxColumn _Dates;

	[AccessedThroughProperty("ID_INV")]
	private DataGridViewTextBoxColumn _ID_INV;

	[AccessedThroughProperty("NOTES")]
	private DataGridViewTextBoxColumn _NOTES;

	[AccessedThroughProperty("TOTAL_VALEUR")]
	private DataGridViewTextBoxColumn _TOTAL_VALEUR;

	[AccessedThroughProperty("ETAT")]
	private DataGridViewTextBoxColumn _ETAT;

	[AccessedThroughProperty("supp")]
	private DataGridViewImageColumn _supp;

	[AccessedThroughProperty("modi")]
	private DataGridViewImageColumn _modi;

	[AccessedThroughProperty("cons")]
	private DataGridViewImageColumn _cons;

	[AccessedThroughProperty("Label_TOTAL_VALEUR_DOC")]
	private Label _Label_TOTAL_VALEUR_DOC;

	[AccessedThroughProperty("Label52")]
	private Label _Label52;

	private MySqlDataAdapter DA;

	private DataTable DT;

	private int x;

	private int y;

	private Point newpoint;

	private DataTable dt_ARTICLE_FIND;

	private MySqlDataAdapter da_ARTICLE_FIND;

	private object _sql;

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
			EventHandler eventHandler = Button20_Click;
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
			EventHandler eventHandler = Button_CLOSE_Click;
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
			EventHandler eventHandler = Button_SAVE_Click;
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
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Expected Obj, but got Unknown
			EventHandler eventHandler = DataGridView1_DoubleClick;
			DataGridViewCellEventHandler val = DataGridView1_CellClick;
			DataGridViewCellEventHandler val2 = DataGridView1_CellContentClick;
			DataGridViewBindingCompleteEventHandler val3 = DataGridView1_DataBindingComplete;
			DataGridViewCellEventHandler val4 = DataGridView1_CellEnter;
			if (_DataGridView1 != null)
			{
				((Control)_DataGridView1).DoubleClick -= eventHandler;
				_DataGridView1.CellClick -= val;
				_DataGridView1.CellContentClick -= val2;
				_DataGridView1.DataBindingComplete -= val3;
				_DataGridView1.CellEnter -= val4;
			}
			_DataGridView1 = value;
			if (_DataGridView1 != null)
			{
				((Control)_DataGridView1).DoubleClick += eventHandler;
				_DataGridView1.CellClick += val;
				_DataGridView1.CellContentClick += val2;
				_DataGridView1.DataBindingComplete += val3;
				_DataGridView1.CellEnter += val4;
			}
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

	internal virtual TextBox Text_CODE_FIND
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_CODE_FIND;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			KeyEventHandler val = TextBox14_KeyDown;
			EventHandler eventHandler = Text_CODE_FIND_TextChanged;
			EventHandler eventHandler2 = TextBox_LostFocus;
			EventHandler eventHandler3 = TextBox_GotFocus;
			if (_Text_CODE_FIND != null)
			{
				((Control)_Text_CODE_FIND).KeyDown -= val;
				((Control)_Text_CODE_FIND).TextChanged -= eventHandler;
				((Control)_Text_CODE_FIND).LostFocus -= eventHandler2;
				((Control)_Text_CODE_FIND).GotFocus -= eventHandler3;
			}
			_Text_CODE_FIND = value;
			if (_Text_CODE_FIND != null)
			{
				((Control)_Text_CODE_FIND).KeyDown += val;
				((Control)_Text_CODE_FIND).TextChanged += eventHandler;
				((Control)_Text_CODE_FIND).LostFocus += eventHandler2;
				((Control)_Text_CODE_FIND).GotFocus += eventHandler3;
			}
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

	internal virtual Button Button_FIND
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_FIND;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_FIND_GotFocus;
			EventHandler eventHandler2 = Button_FIND_Click;
			if (_Button_FIND != null)
			{
				((Control)_Button_FIND).GotFocus -= eventHandler;
				((Control)_Button_FIND).Click -= eventHandler2;
			}
			_Button_FIND = value;
			if (_Button_FIND != null)
			{
				((Control)_Button_FIND).GotFocus += eventHandler;
				((Control)_Button_FIND).Click += eventHandler2;
			}
		}
	}

	internal virtual DataGridView DataGrid_BODY
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGrid_BODY;
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
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Expected Obj, but got Unknown
			DataGridViewCellEventHandler val = DataGrid_BODY_CellContentClick;
			DataGridViewCellEventHandler val2 = DataGrid_BODY_CellValidated;
			DataGridViewCellEventHandler val3 = DataGrid_BODY_CellEnter;
			DataGridViewEditingControlShowingEventHandler val4 = DataGrid_BODY_EditingControlShowing;
			if (_DataGrid_BODY != null)
			{
				_DataGrid_BODY.CellContentClick -= val;
				_DataGrid_BODY.CellValidated -= val2;
				_DataGrid_BODY.CellEnter -= val3;
				_DataGrid_BODY.EditingControlShowing -= val4;
			}
			_DataGrid_BODY = value;
			if (_DataGrid_BODY != null)
			{
				_DataGrid_BODY.CellContentClick += val;
				_DataGrid_BODY.CellValidated += val2;
				_DataGrid_BODY.CellEnter += val3;
				_DataGrid_BODY.EditingControlShowing += val4;
			}
		}
	}

	internal virtual TextBox Text_UTILISATEUR
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_UTILISATEUR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_UTILISATEUR = value;
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

	internal virtual TextBox Text_ID_INV
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_ID_INV;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_ID_INV = value;
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

	internal virtual TextBox Text_NOTES
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_NOTES;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_NOTES = value;
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
			EventHandler eventHandler = TabControl1_Click;
			if (_TabControl1 != null)
			{
				((Control)_TabControl1).Click -= eventHandler;
			}
			_TabControl1 = value;
			if (_TabControl1 != null)
			{
				((Control)_TabControl1).Click += eventHandler;
			}
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

	internal virtual Panel Panel_INV_MASSE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel_INV_MASSE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel_INV_MASSE = value;
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

	internal virtual ListBox ListBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ListBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ListBox1 = value;
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

	internal virtual Button Button_FERMER
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_FERMER;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_FERMER_Click;
			if (_Button_FERMER != null)
			{
				((Control)_Button_FERMER).Click -= eventHandler;
			}
			_Button_FERMER = value;
			if (_Button_FERMER != null)
			{
				((Control)_Button_FERMER).Click += eventHandler;
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

	internal virtual Button Button_ETAT_INVENTAIRE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_ETAT_INVENTAIRE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_ETAT_INVENTAIRE_Click;
			if (_Button_ETAT_INVENTAIRE != null)
			{
				((Control)_Button_ETAT_INVENTAIRE).Click -= eventHandler;
			}
			_Button_ETAT_INVENTAIRE = value;
			if (_Button_ETAT_INVENTAIRE != null)
			{
				((Control)_Button_ETAT_INVENTAIRE).Click += eventHandler;
			}
		}
	}

	internal virtual PrintDocument Print_INV
	{
		[DebuggerNonUserCode]
		get
		{
			return _Print_INV;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			PrintPageEventHandler val = Print_INV_PrintPage;
			if (_Print_INV != null)
			{
				_Print_INV.PrintPage -= val;
			}
			_Print_INV = value;
			if (_Print_INV != null)
			{
				_Print_INV.PrintPage += val;
			}
		}
	}

	internal virtual Button Button_VALIDER
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_VALIDER;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_VALIDER_Click;
			if (_Button_VALIDER != null)
			{
				((Control)_Button_VALIDER).Click -= eventHandler;
			}
			_Button_VALIDER = value;
			if (_Button_VALIDER != null)
			{
				((Control)_Button_VALIDER).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button_CALC_DOC
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_CALC_DOC;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_CALC_DOC_Click;
			if (_Button_CALC_DOC != null)
			{
				((Control)_Button_CALC_DOC).Click -= eventHandler;
			}
			_Button_CALC_DOC = value;
			if (_Button_CALC_DOC != null)
			{
				((Control)_Button_CALC_DOC).Click += eventHandler;
			}
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

	internal virtual TextBox Text_CODE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_CODE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_CODE = value;
		}
	}

	internal virtual Label Label34
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label34;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label34 = value;
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

	internal virtual TextBox Text_ARTICLE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_ARTICLE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_ARTICLE = value;
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

	internal virtual TextBox Text_STOCK_ACTUEL
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_STOCK_ACTUEL;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_STOCK_ACTUEL = value;
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
			_Button4 = value;
		}
	}

	internal virtual TextBox Text_ARTICLE_FIND
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_ARTICLE_FIND;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected Obj, but got Unknown
			EventHandler eventHandler = TextBox_LostFocus;
			EventHandler eventHandler2 = TextBox_GotFocus;
			KeyEventHandler val = Text_ARTICLE_FIND_KeyDown;
			EventHandler eventHandler3 = Text_ARTICLE_FIND_TextChanged;
			if (_Text_ARTICLE_FIND != null)
			{
				((Control)_Text_ARTICLE_FIND).LostFocus -= eventHandler;
				((Control)_Text_ARTICLE_FIND).GotFocus -= eventHandler2;
				((Control)_Text_ARTICLE_FIND).KeyDown -= val;
				((Control)_Text_ARTICLE_FIND).TextChanged -= eventHandler3;
			}
			_Text_ARTICLE_FIND = value;
			if (_Text_ARTICLE_FIND != null)
			{
				((Control)_Text_ARTICLE_FIND).LostFocus += eventHandler;
				((Control)_Text_ARTICLE_FIND).GotFocus += eventHandler2;
				((Control)_Text_ARTICLE_FIND).KeyDown += val;
				((Control)_Text_ARTICLE_FIND).TextChanged += eventHandler3;
			}
		}
	}

	internal virtual DataGridView DataGridView_ARTICLES
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridView_ARTICLES;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			DataGridViewCellEventHandler val = DataGridView_ARTICLES_CellContentClick;
			DataGridViewCellEventHandler val2 = DataGridView_ARTICLES_CellClick;
			if (_DataGridView_ARTICLES != null)
			{
				_DataGridView_ARTICLES.CellContentClick -= val;
				_DataGridView_ARTICLES.CellClick -= val2;
			}
			_DataGridView_ARTICLES = value;
			if (_DataGridView_ARTICLES != null)
			{
				_DataGridView_ARTICLES.CellContentClick += val;
				_DataGridView_ARTICLES.CellClick += val2;
			}
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

	internal virtual Button Button23
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button23;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button23_Click;
			if (_Button23 != null)
			{
				((Control)_Button23).Click -= eventHandler;
			}
			_Button23 = value;
			if (_Button23 != null)
			{
				((Control)_Button23).Click += eventHandler;
			}
		}
	}

	internal virtual Panel Panel243544
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel243544;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel243544 = value;
		}
	}

	internal virtual DataGridView DataGridView_FAMILLES
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataGridView_FAMILLES;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			DataGridViewCellEventHandler val = DataGridView_FAMILLES_CellContentClick;
			DataGridViewCellEventHandler val2 = DataGridView_FAMILLES_CellClick;
			if (_DataGridView_FAMILLES != null)
			{
				_DataGridView_FAMILLES.CellContentClick -= val;
				_DataGridView_FAMILLES.CellClick -= val2;
			}
			_DataGridView_FAMILLES = value;
			if (_DataGridView_FAMILLES != null)
			{
				_DataGridView_FAMILLES.CellContentClick += val;
				_DataGridView_FAMILLES.CellClick += val2;
			}
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

	internal virtual Panel Panel7727
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel7727;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel7727 = value;
		}
	}

	internal virtual Button Button_CALC_ENREGISTRER
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_CALC_ENREGISTRER;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_CALC_ENREGISTRER_Click;
			if (_Button_CALC_ENREGISTRER != null)
			{
				((Control)_Button_CALC_ENREGISTRER).Click -= eventHandler;
			}
			_Button_CALC_ENREGISTRER = value;
			if (_Button_CALC_ENREGISTRER != null)
			{
				((Control)_Button_CALC_ENREGISTRER).Click += eventHandler;
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

	internal virtual TextBox TextBox33398
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox33398;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBox33398 = value;
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

	internal virtual TextBox Text_UNITE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_UNITE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_UNITE = value;
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

	internal virtual TextBox Text_PRIX_A
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_PRIX_A;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_PRIX_A = value;
		}
	}

	internal virtual Button Button_RAPPORT
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_RAPPORT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_RAPPORT_Click;
			if (_Button_RAPPORT != null)
			{
				((Control)_Button_RAPPORT).Click -= eventHandler;
			}
			_Button_RAPPORT = value;
			if (_Button_RAPPORT != null)
			{
				((Control)_Button_RAPPORT).Click += eventHandler;
			}
		}
	}

	internal virtual Panel Panel7
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel7 = value;
		}
	}

	internal virtual ListBox ListBox2
	{
		[DebuggerNonUserCode]
		get
		{
			return _ListBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ListBox2 = value;
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

	internal virtual PrintDocument Print_INV_PRE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Print_INV_PRE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			PrintPageEventHandler val = Print_INV_PRE_PrintPage;
			if (_Print_INV_PRE != null)
			{
				_Print_INV_PRE.PrintPage -= val;
			}
			_Print_INV_PRE = value;
			if (_Print_INV_PRE != null)
			{
				_Print_INV_PRE.PrintPage += val;
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
			EventHandler eventHandler = Button_PrintRapport_Click;
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

	internal virtual Label Label50
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label50;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label50 = value;
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
			EventHandler eventHandler = Button_EXCEL_Click;
			if (_Button_EXCEL != null)
			{
				((Control)_Button_EXCEL).Click -= eventHandler;
			}
			_Button_EXCEL = value;
			if (_Button_EXCEL != null)
			{
				((Control)_Button_EXCEL).Click += eventHandler;
			}
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
			EventHandler eventHandler = Button_WORD_Click;
			if (_Button_WORD != null)
			{
				((Control)_Button_WORD).Click -= eventHandler;
			}
			_Button_WORD = value;
			if (_Button_WORD != null)
			{
				((Control)_Button_WORD).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button_PRINT_80MM
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_PRINT_80MM;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_PRINT_80MM_Click;
			if (_Button_PRINT_80MM != null)
			{
				((Control)_Button_PRINT_80MM).Click -= eventHandler;
			}
			_Button_PRINT_80MM = value;
			if (_Button_PRINT_80MM != null)
			{
				((Control)_Button_PRINT_80MM).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button_PRINT_A4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_PRINT_A4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_PRINT_A4_Click;
			if (_Button_PRINT_A4 != null)
			{
				((Control)_Button_PRINT_A4).Click -= eventHandler;
			}
			_Button_PRINT_A4 = value;
			if (_Button_PRINT_A4 != null)
			{
				((Control)_Button_PRINT_A4).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button_SPLITE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_SPLITE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_SPLITE_Click;
			if (_Button_SPLITE != null)
			{
				((Control)_Button_SPLITE).Click -= eventHandler;
			}
			_Button_SPLITE = value;
			if (_Button_SPLITE != null)
			{
				((Control)_Button_SPLITE).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox PictureBox2323
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox2323;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = PictureBox2323_Click;
			if (_PictureBox2323 != null)
			{
				((Control)_PictureBox2323).Click -= eventHandler;
			}
			_PictureBox2323 = value;
			if (_PictureBox2323 != null)
			{
				((Control)_PictureBox2323).Click += eventHandler;
			}
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

	internal virtual DataGridViewTextBoxColumn ID_ARTICLE
	{
		[DebuggerNonUserCode]
		get
		{
			return _ID_ARTICLE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ID_ARTICLE = value;
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

	internal virtual DataGridViewTextBoxColumn Stock_Logique
	{
		[DebuggerNonUserCode]
		get
		{
			return _Stock_Logique;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Stock_Logique = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Stock_Physique
	{
		[DebuggerNonUserCode]
		get
		{
			return _Stock_Physique;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Stock_Physique = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Ecart
	{
		[DebuggerNonUserCode]
		get
		{
			return _Ecart;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Ecart = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Valeur
	{
		[DebuggerNonUserCode]
		get
		{
			return _Valeur;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Valeur = value;
		}
	}

	internal virtual DataGridViewImageColumn sup
	{
		[DebuggerNonUserCode]
		get
		{
			return _sup;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_sup = value;
		}
	}

	internal virtual TextBox Text_ID_ARTICLE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_ID_ARTICLE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Text_ID_ARTICLE = value;
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

	internal virtual Label Label25
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label25;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label25 = value;
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

	protected virtual RJTextBox Text_FIND_BODY
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_FIND_BODY;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Text_FIND_BODY__TextChanged;
			if (_Text_FIND_BODY != null)
			{
				_Text_FIND_BODY._TextChanged -= eventHandler;
			}
			_Text_FIND_BODY = value;
			if (_Text_FIND_BODY != null)
			{
				_Text_FIND_BODY._TextChanged += eventHandler;
			}
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

	internal virtual Label Label_TOTAL_NET_ACHATS_BD
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_TOTAL_NET_ACHATS_BD;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_TOTAL_NET_ACHATS_BD = value;
		}
	}

	internal virtual Label Label32
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label32;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label32 = value;
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

	internal virtual Label Label_TOTAL_LIGNES
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_TOTAL_LIGNES;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_TOTAL_LIGNES = value;
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

	internal virtual Button_CLAVIER_NOSELECT Button_CLAVIER_NOSELECT1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_CLAVIER_NOSELECT1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_CLAVIER_NOSELECT1_Click;
			if (_Button_CLAVIER_NOSELECT1 != null)
			{
				((Control)_Button_CLAVIER_NOSELECT1).Click -= eventHandler;
			}
			_Button_CLAVIER_NOSELECT1 = value;
			if (_Button_CLAVIER_NOSELECT1 != null)
			{
				((Control)_Button_CLAVIER_NOSELECT1).Click += eventHandler;
			}
		}
	}

	internal virtual Button_CLAVIER_NOSELECT Butt_
	{
		[DebuggerNonUserCode]
		get
		{
			return _Butt_;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Butt_ = value;
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

	internal virtual TextBox Text_QTE
	{
		[DebuggerNonUserCode]
		get
		{
			return _Text_QTE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			KeyEventHandler val = Text_QTE_KeyDown;
			KeyPressEventHandler val2 = Text_QTE_KeyPress;
			EventHandler eventHandler = Text_QTE_Click;
			EventHandler eventHandler2 = Text_QTE_TextChanged;
			if (_Text_QTE != null)
			{
				((Control)_Text_QTE).KeyDown -= val;
				((Control)_Text_QTE).KeyPress -= val2;
				((TextBoxBase)_Text_QTE).Click -= eventHandler;
				((Control)_Text_QTE).TextChanged -= eventHandler2;
			}
			_Text_QTE = value;
			if (_Text_QTE != null)
			{
				((Control)_Text_QTE).KeyDown += val;
				((Control)_Text_QTE).KeyPress += val2;
				((TextBoxBase)_Text_QTE).Click += eventHandler;
				((Control)_Text_QTE).TextChanged += eventHandler2;
			}
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

	internal virtual Button Button_MOINS
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_MOINS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_MOINS_Click;
			if (_Button_MOINS != null)
			{
				((Control)_Button_MOINS).Click -= eventHandler;
			}
			_Button_MOINS = value;
			if (_Button_MOINS != null)
			{
				((Control)_Button_MOINS).Click += eventHandler;
			}
		}
	}

	internal virtual Button Button_PLUS
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button_PLUS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button_PLUS_Click;
			if (_Button_PLUS != null)
			{
				((Control)_Button_PLUS).Click -= eventHandler;
			}
			_Button_PLUS = value;
			if (_Button_PLUS != null)
			{
				((Control)_Button_PLUS).Click += eventHandler;
			}
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

	internal virtual DataGridViewTextBoxColumn ID_INV
	{
		[DebuggerNonUserCode]
		get
		{
			return _ID_INV;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ID_INV = value;
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

	internal virtual DataGridViewTextBoxColumn TOTAL_VALEUR
	{
		[DebuggerNonUserCode]
		get
		{
			return _TOTAL_VALEUR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TOTAL_VALEUR = value;
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

	internal virtual DataGridViewImageColumn cons
	{
		[DebuggerNonUserCode]
		get
		{
			return _cons;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cons = value;
		}
	}

	internal virtual Label Label_TOTAL_VALEUR_DOC
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label_TOTAL_VALEUR_DOC;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label_TOTAL_VALEUR_DOC = value;
		}
	}

	internal virtual Label Label52
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label52;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label52 = value;
		}
	}

	public Form_6_INVENTAIRES()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected Obj, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected Obj, but got Unknown
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected Obj, but got Unknown
		((Control)this).KeyDown += me_KeyDown;
		((Form)this).FormClosed += Form_6_RECEPTIONS_FormClosed;
		((Form)this).Load += Form_Load;
		__ENCAddToList(this);
		DA = new MySqlDataAdapter();
		DT = new DataTable();
		newpoint = default;
		dt_ARTICLE_FIND = new DataTable();
		da_ARTICLE_FIND = new MySqlDataAdapter();
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
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected Obj, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected Obj, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected Obj, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected Obj, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected Obj, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected Obj, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected Obj, but got Unknown
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
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0317: Expected Obj, but got Unknown
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
		//IL_05d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05db: Expected Obj, but got Unknown
		//IL_05dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e7: Expected Obj, but got Unknown
		//IL_05e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f3: Expected Obj, but got Unknown
		//IL_05f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ff: Expected Obj, but got Unknown
		//IL_0601: Unknown result type (might be due to invalid IL or missing references)
		//IL_060b: Expected Obj, but got Unknown
		//IL_060d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0617: Expected Obj, but got Unknown
		//IL_0619: Unknown result type (might be due to invalid IL or missing references)
		//IL_0623: Expected Obj, but got Unknown
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
		//IL_0685: Unknown result type (might be due to invalid IL or missing references)
		//IL_068f: Expected Obj, but got Unknown
		//IL_0691: Unknown result type (might be due to invalid IL or missing references)
		//IL_069b: Expected Obj, but got Unknown
		//IL_069d: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a7: Expected Obj, but got Unknown
		//IL_06a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b3: Expected Obj, but got Unknown
		//IL_06b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bf: Expected Obj, but got Unknown
		//IL_06c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cb: Expected Obj, but got Unknown
		//IL_06cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d7: Expected Obj, but got Unknown
		//IL_06d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e3: Expected Obj, but got Unknown
		//IL_06e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ef: Expected Obj, but got Unknown
		//IL_06f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fb: Expected Obj, but got Unknown
		//IL_06fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0707: Expected Obj, but got Unknown
		//IL_0709: Unknown result type (might be due to invalid IL or missing references)
		//IL_0713: Expected Obj, but got Unknown
		//IL_0715: Unknown result type (might be due to invalid IL or missing references)
		//IL_071f: Expected Obj, but got Unknown
		//IL_0721: Unknown result type (might be due to invalid IL or missing references)
		//IL_072b: Expected Obj, but got Unknown
		//IL_072d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0737: Expected Obj, but got Unknown
		//IL_0739: Unknown result type (might be due to invalid IL or missing references)
		//IL_0743: Expected Obj, but got Unknown
		//IL_0745: Unknown result type (might be due to invalid IL or missing references)
		//IL_074f: Expected Obj, but got Unknown
		//IL_0751: Unknown result type (might be due to invalid IL or missing references)
		//IL_075b: Expected Obj, but got Unknown
		//IL_075d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0767: Expected Obj, but got Unknown
		//IL_0769: Unknown result type (might be due to invalid IL or missing references)
		//IL_0773: Expected Obj, but got Unknown
		//IL_0775: Unknown result type (might be due to invalid IL or missing references)
		//IL_077f: Expected Obj, but got Unknown
		//IL_0781: Unknown result type (might be due to invalid IL or missing references)
		//IL_078b: Expected Obj, but got Unknown
		//IL_078d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0797: Expected Obj, but got Unknown
		//IL_0799: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a3: Expected Obj, but got Unknown
		//IL_07a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07af: Expected Obj, but got Unknown
		//IL_07b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bb: Expected Obj, but got Unknown
		//IL_07bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c7: Expected Obj, but got Unknown
		//IL_07c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d3: Expected Obj, but got Unknown
		//IL_07d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07df: Expected Obj, but got Unknown
		//IL_07e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07eb: Expected Obj, but got Unknown
		//IL_07ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f7: Expected Obj, but got Unknown
		//IL_07f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0803: Expected Obj, but got Unknown
		//IL_0811: Unknown result type (might be due to invalid IL or missing references)
		//IL_081b: Expected Obj, but got Unknown
		//IL_081d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0827: Expected Obj, but got Unknown
		//IL_0829: Unknown result type (might be due to invalid IL or missing references)
		//IL_0833: Expected Obj, but got Unknown
		//IL_0835: Unknown result type (might be due to invalid IL or missing references)
		//IL_083f: Expected Obj, but got Unknown
		//IL_0859: Unknown result type (might be due to invalid IL or missing references)
		//IL_0863: Expected Obj, but got Unknown
		//IL_0865: Unknown result type (might be due to invalid IL or missing references)
		//IL_086f: Expected Obj, but got Unknown
		//IL_0871: Unknown result type (might be due to invalid IL or missing references)
		//IL_087b: Expected Obj, but got Unknown
		//IL_087d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0887: Expected Obj, but got Unknown
		//IL_0889: Unknown result type (might be due to invalid IL or missing references)
		//IL_0893: Expected Obj, but got Unknown
		//IL_0895: Unknown result type (might be due to invalid IL or missing references)
		//IL_089f: Expected Obj, but got Unknown
		//IL_08a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ab: Expected Obj, but got Unknown
		//IL_08ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b7: Expected Obj, but got Unknown
		//IL_08b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c3: Expected Obj, but got Unknown
		//IL_08c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08cf: Expected Obj, but got Unknown
		//IL_08d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08db: Expected Obj, but got Unknown
		//IL_08dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e7: Expected Obj, but got Unknown
		//IL_08e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f3: Expected Obj, but got Unknown
		//IL_08f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ff: Expected Obj, but got Unknown
		//IL_0901: Unknown result type (might be due to invalid IL or missing references)
		//IL_090b: Expected Obj, but got Unknown
		//IL_090d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0917: Expected Obj, but got Unknown
		//IL_0919: Unknown result type (might be due to invalid IL or missing references)
		//IL_0923: Expected Obj, but got Unknown
		//IL_0925: Unknown result type (might be due to invalid IL or missing references)
		//IL_092f: Expected Obj, but got Unknown
		//IL_0c92: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c9c: Expected Obj, but got Unknown
		//IL_0f52: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f5c: Expected Obj, but got Unknown
		//IL_0f94: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_105f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1069: Expected Obj, but got Unknown
		//IL_10a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_10aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_115e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1168: Expected Obj, but got Unknown
		//IL_11a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_11a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1278: Unknown result type (might be due to invalid IL or missing references)
		//IL_1282: Expected Obj, but got Unknown
		//IL_12b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_12bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1382: Unknown result type (might be due to invalid IL or missing references)
		//IL_138c: Expected Obj, but got Unknown
		//IL_13c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_13c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_148c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1496: Expected Obj, but got Unknown
		//IL_14cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_14d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1596: Unknown result type (might be due to invalid IL or missing references)
		//IL_15a0: Expected Obj, but got Unknown
		//IL_15d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_15de: Unknown result type (might be due to invalid IL or missing references)
		//IL_16a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_16ad: Expected Obj, but got Unknown
		//IL_16e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_16e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_17ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_17b7: Expected Obj, but got Unknown
		//IL_17eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_17f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_18b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_18c0: Expected Obj, but got Unknown
		//IL_18f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_18fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_19bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_19c9: Expected Obj, but got Unknown
		//IL_19ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_19f7: Expected Obj, but got Unknown
		//IL_1a1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a23: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ad7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ae1: Expected Obj, but got Unknown
		//IL_1b19: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b1f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1be4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bee: Expected Obj, but got Unknown
		//IL_1c25: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cf0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cfa: Expected Obj, but got Unknown
		//IL_1d32: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d38: Unknown result type (might be due to invalid IL or missing references)
		//IL_1df7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e01: Expected Obj, but got Unknown
		//IL_1e39: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e73: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e79: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f42: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f4c: Expected Obj, but got Unknown
		//IL_20fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_2107: Expected Obj, but got Unknown
		//IL_21dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_21e7: Expected Obj, but got Unknown
		//IL_22a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_22b3: Expected Obj, but got Unknown
		//IL_2361: Unknown result type (might be due to invalid IL or missing references)
		//IL_236b: Expected Obj, but got Unknown
		//IL_238f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2399: Expected Obj, but got Unknown
		//IL_23cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_23d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_246d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2477: Expected Obj, but got Unknown
		//IL_249b: Unknown result type (might be due to invalid IL or missing references)
		//IL_24a5: Expected Obj, but got Unknown
		//IL_24d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_24df: Unknown result type (might be due to invalid IL or missing references)
		//IL_2620: Unknown result type (might be due to invalid IL or missing references)
		//IL_262a: Expected Obj, but got Unknown
		//IL_26ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_26f9: Expected Obj, but got Unknown
		//IL_2793: Unknown result type (might be due to invalid IL or missing references)
		//IL_279d: Expected Obj, but got Unknown
		//IL_285f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2869: Expected Obj, but got Unknown
		//IL_2930: Unknown result type (might be due to invalid IL or missing references)
		//IL_293a: Expected Obj, but got Unknown
		//IL_2a0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a18: Expected Obj, but got Unknown
		//IL_2ae9: Unknown result type (might be due to invalid IL or missing references)
		//IL_2af3: Expected Obj, but got Unknown
		//IL_2b17: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b21: Expected Obj, but got Unknown
		//IL_2b59: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c00: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c0a: Expected Obj, but got Unknown
		//IL_2c2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c38: Expected Obj, but got Unknown
		//IL_2c6d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c73: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d17: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d21: Expected Obj, but got Unknown
		//IL_2e17: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f88: Expected Obj, but got Unknown
		//IL_305d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3067: Expected Obj, but got Unknown
		//IL_30f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_30fb: Expected Obj, but got Unknown
		//IL_31b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_31ba: Expected Obj, but got Unknown
		//IL_327b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3285: Expected Obj, but got Unknown
		//IL_334a: Unknown result type (might be due to invalid IL or missing references)
		//IL_3354: Expected Obj, but got Unknown
		//IL_35a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_35aa: Expected Obj, but got Unknown
		//IL_365f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3669: Expected Obj, but got Unknown
		//IL_3705: Unknown result type (might be due to invalid IL or missing references)
		//IL_370f: Expected Obj, but got Unknown
		//IL_37bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_37c5: Expected Obj, but got Unknown
		//IL_389a: Unknown result type (might be due to invalid IL or missing references)
		//IL_38a4: Expected Obj, but got Unknown
		//IL_3965: Unknown result type (might be due to invalid IL or missing references)
		//IL_396f: Expected Obj, but got Unknown
		//IL_3a17: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a21: Expected Obj, but got Unknown
		//IL_3ad6: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ae0: Expected Obj, but got Unknown
		//IL_3b89: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b93: Expected Obj, but got Unknown
		//IL_3c58: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c62: Expected Obj, but got Unknown
		//IL_3cf4: Unknown result type (might be due to invalid IL or missing references)
		//IL_3cfe: Expected Obj, but got Unknown
		//IL_3db6: Unknown result type (might be due to invalid IL or missing references)
		//IL_3dc0: Expected Obj, but got Unknown
		//IL_3e4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e55: Expected Obj, but got Unknown
		//IL_3f31: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f37: Unknown result type (might be due to invalid IL or missing references)
		//IL_41fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_4208: Expected Obj, but got Unknown
		//IL_421b: Unknown result type (might be due to invalid IL or missing references)
		//IL_4225: Expected Obj, but got Unknown
		//IL_42c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_42d2: Expected Obj, but got Unknown
		//IL_42e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_42ef: Expected Obj, but got Unknown
		//IL_4379: Unknown result type (might be due to invalid IL or missing references)
		//IL_4383: Expected Obj, but got Unknown
		//IL_442a: Unknown result type (might be due to invalid IL or missing references)
		//IL_4434: Expected Obj, but got Unknown
		//IL_44b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_44ba: Expected Obj, but got Unknown
		//IL_4566: Unknown result type (might be due to invalid IL or missing references)
		//IL_4570: Expected Obj, but got Unknown
		//IL_4633: Unknown result type (might be due to invalid IL or missing references)
		//IL_463d: Expected Obj, but got Unknown
		//IL_46b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_46c0: Expected Obj, but got Unknown
		//IL_4787: Unknown result type (might be due to invalid IL or missing references)
		//IL_4791: Expected Obj, but got Unknown
		//IL_4828: Unknown result type (might be due to invalid IL or missing references)
		//IL_4832: Expected Obj, but got Unknown
		//IL_48d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_48de: Expected Obj, but got Unknown
		//IL_497a: Unknown result type (might be due to invalid IL or missing references)
		//IL_4984: Expected Obj, but got Unknown
		//IL_4a47: Unknown result type (might be due to invalid IL or missing references)
		//IL_4a51: Expected Obj, but got Unknown
		//IL_4af6: Unknown result type (might be due to invalid IL or missing references)
		//IL_4b00: Expected Obj, but got Unknown
		//IL_4b98: Unknown result type (might be due to invalid IL or missing references)
		//IL_4ba2: Expected Obj, but got Unknown
		//IL_4c73: Unknown result type (might be due to invalid IL or missing references)
		//IL_4c7d: Expected Obj, but got Unknown
		//IL_4d42: Unknown result type (might be due to invalid IL or missing references)
		//IL_4d4c: Expected Obj, but got Unknown
		//IL_4e0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_4e15: Expected Obj, but got Unknown
		//IL_4e39: Unknown result type (might be due to invalid IL or missing references)
		//IL_4e43: Expected Obj, but got Unknown
		//IL_4eee: Unknown result type (might be due to invalid IL or missing references)
		//IL_4ef8: Expected Obj, but got Unknown
		//IL_4fbb: Unknown result type (might be due to invalid IL or missing references)
		//IL_4fc5: Expected Obj, but got Unknown
		//IL_503e: Unknown result type (might be due to invalid IL or missing references)
		//IL_5048: Expected Obj, but got Unknown
		//IL_53d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_53dc: Expected Obj, but got Unknown
		//IL_5490: Unknown result type (might be due to invalid IL or missing references)
		//IL_549a: Expected Obj, but got Unknown
		//IL_5771: Unknown result type (might be due to invalid IL or missing references)
		//IL_577b: Expected Obj, but got Unknown
		//IL_5850: Unknown result type (might be due to invalid IL or missing references)
		//IL_585a: Expected Obj, but got Unknown
		//IL_58f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_5901: Expected Obj, but got Unknown
		//IL_59f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_59fa: Expected Obj, but got Unknown
		//IL_5abb: Unknown result type (might be due to invalid IL or missing references)
		//IL_5ac5: Expected Obj, but got Unknown
		//IL_5b8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_5b94: Expected Obj, but got Unknown
		//IL_5c2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_5c35: Expected Obj, but got Unknown
		//IL_5f70: Unknown result type (might be due to invalid IL or missing references)
		//IL_5f7a: Expected Obj, but got Unknown
		//IL_6128: Unknown result type (might be due to invalid IL or missing references)
		//IL_6132: Expected Obj, but got Unknown
		//IL_6403: Unknown result type (might be due to invalid IL or missing references)
		//IL_640d: Expected Obj, but got Unknown
		//IL_64c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_64d0: Expected Obj, but got Unknown
		//IL_6578: Unknown result type (might be due to invalid IL or missing references)
		//IL_6582: Expected Obj, but got Unknown
		//IL_6609: Unknown result type (might be due to invalid IL or missing references)
		//IL_6613: Expected Obj, but got Unknown
		//IL_66d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_66de: Expected Obj, but got Unknown
		//IL_6702: Unknown result type (might be due to invalid IL or missing references)
		//IL_670c: Expected Obj, but got Unknown
		//IL_6744: Unknown result type (might be due to invalid IL or missing references)
		//IL_674a: Unknown result type (might be due to invalid IL or missing references)
		//IL_67de: Unknown result type (might be due to invalid IL or missing references)
		//IL_67e8: Expected Obj, but got Unknown
		//IL_6831: Unknown result type (might be due to invalid IL or missing references)
		//IL_6837: Unknown result type (might be due to invalid IL or missing references)
		//IL_68e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_68ee: Expected Obj, but got Unknown
		//IL_69b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_69bd: Expected Obj, but got Unknown
		//IL_6a7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_6a89: Expected Obj, but got Unknown
		//IL_6b4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_6b59: Expected Obj, but got Unknown
		//IL_6c11: Unknown result type (might be due to invalid IL or missing references)
		//IL_6c1b: Expected Obj, but got Unknown
		//IL_6c3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_6c49: Expected Obj, but got Unknown
		//IL_6c81: Unknown result type (might be due to invalid IL or missing references)
		//IL_6c87: Unknown result type (might be due to invalid IL or missing references)
		//IL_6eb1: Unknown result type (might be due to invalid IL or missing references)
		//IL_6ebb: Expected Obj, but got Unknown
		//IL_6f80: Unknown result type (might be due to invalid IL or missing references)
		//IL_6f8a: Expected Obj, but got Unknown
		//IL_703e: Unknown result type (might be due to invalid IL or missing references)
		//IL_7048: Expected Obj, but got Unknown
		//IL_711e: Unknown result type (might be due to invalid IL or missing references)
		//IL_7128: Expected Obj, but got Unknown
		//IL_71ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_71f4: Expected Obj, but got Unknown
		//IL_73e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_73eb: Expected Obj, but got Unknown
		//IL_748f: Unknown result type (might be due to invalid IL or missing references)
		//IL_7499: Expected Obj, but got Unknown
		//IL_7579: Unknown result type (might be due to invalid IL or missing references)
		//IL_7583: Expected Obj, but got Unknown
		//IL_7596: Unknown result type (might be due to invalid IL or missing references)
		//IL_75a0: Expected Obj, but got Unknown
		//IL_75d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_75da: Unknown result type (might be due to invalid IL or missing references)
		//IL_7691: Unknown result type (might be due to invalid IL or missing references)
		//IL_769b: Expected Obj, but got Unknown
		//IL_76bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_76c9: Expected Obj, but got Unknown
		//IL_76fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_7703: Unknown result type (might be due to invalid IL or missing references)
		//IL_77ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_77b7: Expected Obj, but got Unknown
		//IL_77db: Unknown result type (might be due to invalid IL or missing references)
		//IL_77e5: Expected Obj, but got Unknown
		//IL_7819: Unknown result type (might be due to invalid IL or missing references)
		//IL_781f: Unknown result type (might be due to invalid IL or missing references)
		//IL_78d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_78e2: Expected Obj, but got Unknown
		//IL_7906: Unknown result type (might be due to invalid IL or missing references)
		//IL_7910: Expected Obj, but got Unknown
		//IL_7ad6: Unknown result type (might be due to invalid IL or missing references)
		//IL_7ae0: Expected Obj, but got Unknown
		//IL_7ba1: Unknown result type (might be due to invalid IL or missing references)
		//IL_7bab: Expected Obj, but got Unknown
		//IL_7bf4: Unknown result type (might be due to invalid IL or missing references)
		//IL_7bfa: Unknown result type (might be due to invalid IL or missing references)
		//IL_7c8e: Unknown result type (might be due to invalid IL or missing references)
		//IL_7c98: Expected Obj, but got Unknown
		//IL_7ce1: Unknown result type (might be due to invalid IL or missing references)
		//IL_7ce7: Unknown result type (might be due to invalid IL or missing references)
		//IL_7d94: Unknown result type (might be due to invalid IL or missing references)
		//IL_7d9e: Expected Obj, but got Unknown
		//IL_7e63: Unknown result type (might be due to invalid IL or missing references)
		//IL_7e6d: Expected Obj, but got Unknown
		//IL_7f2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_7f39: Expected Obj, but got Unknown
		//IL_7fff: Unknown result type (might be due to invalid IL or missing references)
		//IL_8009: Expected Obj, but got Unknown
		//IL_80c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_80cd: Expected Obj, but got Unknown
		//IL_80f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_80fb: Expected Obj, but got Unknown
		//IL_8133: Unknown result type (might be due to invalid IL or missing references)
		//IL_8139: Unknown result type (might be due to invalid IL or missing references)
		//IL_83af: Unknown result type (might be due to invalid IL or missing references)
		//IL_83b9: Expected Obj, but got Unknown
		//IL_847a: Unknown result type (might be due to invalid IL or missing references)
		//IL_8484: Expected Obj, but got Unknown
		//IL_8549: Unknown result type (might be due to invalid IL or missing references)
		//IL_8553: Expected Obj, but got Unknown
		//IL_8614: Unknown result type (might be due to invalid IL or missing references)
		//IL_861e: Expected Obj, but got Unknown
		//IL_86f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_86ff: Expected Obj, but got Unknown
		//IL_8723: Unknown result type (might be due to invalid IL or missing references)
		//IL_872d: Expected Obj, but got Unknown
		//IL_880e: Unknown result type (might be due to invalid IL or missing references)
		//IL_8818: Expected Obj, but got Unknown
		//IL_883c: Unknown result type (might be due to invalid IL or missing references)
		//IL_8846: Expected Obj, but got Unknown
		//IL_8923: Unknown result type (might be due to invalid IL or missing references)
		//IL_892d: Expected Obj, but got Unknown
		//IL_8951: Unknown result type (might be due to invalid IL or missing references)
		//IL_895b: Expected Obj, but got Unknown
		//IL_8a02: Unknown result type (might be due to invalid IL or missing references)
		//IL_8a0c: Expected Obj, but got Unknown
		//IL_8ac0: Unknown result type (might be due to invalid IL or missing references)
		//IL_8aca: Expected Obj, but got Unknown
		//IL_8ba2: Unknown result type (might be due to invalid IL or missing references)
		//IL_8bac: Expected Obj, but got Unknown
		//IL_8bbf: Unknown result type (might be due to invalid IL or missing references)
		//IL_8bc9: Expected Obj, but got Unknown
		//IL_8c89: Unknown result type (might be due to invalid IL or missing references)
		//IL_8c93: Expected Obj, but got Unknown
		//IL_8f58: Unknown result type (might be due to invalid IL or missing references)
		//IL_8f62: Expected Obj, but got Unknown
		//IL_8f84: Unknown result type (might be due to invalid IL or missing references)
		//IL_8f8e: Expected Obj, but got Unknown
		//IL_9004: Unknown result type (might be due to invalid IL or missing references)
		//IL_900e: Expected Obj, but got Unknown
		//IL_9030: Unknown result type (might be due to invalid IL or missing references)
		//IL_903a: Expected Obj, but got Unknown
		//IL_90ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_90b8: Expected Obj, but got Unknown
		//IL_914a: Unknown result type (might be due to invalid IL or missing references)
		//IL_9154: Expected Obj, but got Unknown
		//IL_9340: Unknown result type (might be due to invalid IL or missing references)
		//IL_934a: Expected Obj, but got Unknown
		//IL_9596: Unknown result type (might be due to invalid IL or missing references)
		//IL_95a0: Expected Obj, but got Unknown
		//IL_9630: Unknown result type (might be due to invalid IL or missing references)
		//IL_963a: Expected Obj, but got Unknown
		//IL_96e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_96ea: Expected Obj, but got Unknown
		//IL_97f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_97fb: Expected Obj, but got Unknown
		//IL_9ba5: Unknown result type (might be due to invalid IL or missing references)
		//IL_9baf: Expected Obj, but got Unknown
		//IL_9f94: Unknown result type (might be due to invalid IL or missing references)
		//IL_9f9e: Expected Obj, but got Unknown
		//IL_a0ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_a0d4: Expected Obj, but got Unknown
		//IL_a1b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_a1bb: Expected Obj, but got Unknown
		//IL_a1ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_a1f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_a229: Unknown result type (might be due to invalid IL or missing references)
		//IL_a22f: Unknown result type (might be due to invalid IL or missing references)
		//IL_a3ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_a3b6: Expected Obj, but got Unknown
		//IL_a519: Unknown result type (might be due to invalid IL or missing references)
		//IL_a523: Expected Obj, but got Unknown
		//IL_a9b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_a9c3: Expected Obj, but got Unknown
		//IL_aa85: Unknown result type (might be due to invalid IL or missing references)
		//IL_aa8f: Expected Obj, but got Unknown
		//IL_ac5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_ac69: Expected Obj, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form_6_INVENTAIRES));
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
		Panel_INFO = new Panel();
		Button_CLAVIER = new Button_CLAVIER_NOSELECT();
		Panel_CLAVIER = new Panel();
		Button_CLAVIER_NOSELECT1 = new Button_CLAVIER_NOSELECT();
		Butt_ = new Button_CLAVIER_NOSELECT();
		Butt_DOT = new Button_CLAVIER_NOSELECT();
		Butt_1 = new Button_CLAVIER_NOSELECT();
		Butt_2 = new Button_CLAVIER_NOSELECT();
		Butt_4 = new Button_CLAVIER_NOSELECT();
		Butt_3 = new Button_CLAVIER_NOSELECT();
		Butt_5 = new Button_CLAVIER_NOSELECT();
		Butt_7 = new Button_CLAVIER_NOSELECT();
		Butt_8 = new Button_CLAVIER_NOSELECT();
		Butt_BACK = new Button_CLAVIER_NOSELECT();
		Butt_6 = new Button_CLAVIER_NOSELECT();
		Butt_9 = new Button_CLAVIER_NOSELECT();
		Butt_0 = new Button_CLAVIER_NOSELECT();
		Text_FIND_BODY = new RJTextBox();
		Button_SPLITE = new Button();
		Panel5 = new Panel();
		Label_TOTAL_LIGNES = new Label();
		Label15 = new Label();
		Label33 = new Label();
		Button6 = new Button();
		Button23 = new Button();
		Button_CALC_DOC = new Button();
		Label_BOTTOM = new Label();
		Label_LEFT = new Label();
		PictureBox2323 = new PictureBox();
		Label_RIGHT = new Label();
		Label_INDEX = new Label();
		Label_TOP = new Label();
		Button_SAVE = new Button();
		Button_CLOSE = new Button();
		TabControl1 = new TabControl();
		TabPage1 = new TabPage();
		Panel4 = new Panel();
		Label10 = new Label();
		Label7 = new Label();
		Text_NOTES = new TextBox();
		Label13 = new Label();
		Label20 = new Label();
		Label21 = new Label();
		Panel3 = new Panel();
		Text_ETAT = new TextBox();
		Label2 = new Label();
		Label1 = new Label();
		Label12 = new Label();
		Label28 = new Label();
		Label29 = new Label();
		Text_UTILISATEUR = new TextBox();
		Label30 = new Label();
		Label6 = new Label();
		Text_ID = new TextBox();
		Label4 = new Label();
		Text_ID_INV = new TextBox();
		DateTimePicker_DATE = new DateTimePicker();
		TabPage2 = new TabPage();
		Panel6 = new Panel();
		Button_MOINS = new Button();
		Button_PLUS = new Button();
		Text_QTE = new TextBox();
		Text_ID_ARTICLE = new TextBox();
		Label5 = new Label();
		Label43 = new Label();
		Text_PRIX_A = new TextBox();
		Label42 = new Label();
		Text_UNITE = new TextBox();
		Text_CODE = new TextBox();
		Label34 = new Label();
		Label35 = new Label();
		Text_ARTICLE = new TextBox();
		Label36 = new Label();
		Label37 = new Label();
		Label38 = new Label();
		Label39 = new Label();
		Button1 = new Button();
		Label40 = new Label();
		Text_STOCK_ACTUEL = new TextBox();
		Label41 = new Label();
		Panel1 = new Panel();
		DataGridView_FAMILLES = new DataGridView();
		DataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
		Button4 = new Button();
		Text_ARTICLE_FIND = new TextBox();
		DataGridView_ARTICLES = new DataGridView();
		Column1 = new DataGridViewTextBoxColumn();
		DataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
		DataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
		Label24 = new Label();
		Label11 = new Label();
		Button_FIND = new Button();
		Label14 = new Label();
		Label17 = new Label();
		Label18 = new Label();
		Text_CODE_FIND = new TextBox();
		DataGrid_BODY = new DataGridView();
		ID_ARTICLE = new DataGridViewTextBoxColumn();
		Code = new DataGridViewTextBoxColumn();
		Article = new DataGridViewTextBoxColumn();
		Prix_A = new DataGridViewTextBoxColumn();
		Stock_Logique = new DataGridViewTextBoxColumn();
		Stock_Physique = new DataGridViewTextBoxColumn();
		Ecart = new DataGridViewTextBoxColumn();
		Valeur = new DataGridViewTextBoxColumn();
		sup = new DataGridViewImageColumn();
		DataGridView1 = new DataGridView();
		Panel_INV_MASSE = new Panel();
		Label23 = new Label();
		Label26 = new Label();
		PictureBox5 = new PictureBox();
		ListBox1 = new ListBox();
		Button5 = new Button();
		Button_FERMER = new Button();
		Label9 = new Label();
		Label8 = new Label();
		Label16 = new Label();
		Label22 = new Label();
		Print_INV = new PrintDocument();
		Button_VALIDER = new Button();
		Button_CALC_BD = new Button();
		Panel243544 = new Panel();
		Label_TOTAL_NET_ACHATS_BD = new Label();
		Label32 = new Label();
		Label_TOTAL_LIGNES_BD = new Label();
		Label31 = new Label();
		Label27 = new Label();
		Panel7727 = new Panel();
		Button_CALC_ENREGISTRER = new Button();
		PictureBox3 = new PictureBox();
		TextBox33398 = new TextBox();
		Button_RAPPORT = new Button();
		Button_ETAT_INVENTAIRE = new Button();
		Button2 = new Button();
		Button_ADD = new Button();
		Panel7 = new Panel();
		ListBox2 = new ListBox();
		Button3 = new Button();
		Button8 = new Button();
		Label46 = new Label();
		Label47 = new Label();
		Label48 = new Label();
		Label49 = new Label();
		Print_INV_PRE = new PrintDocument();
		Button_FONCTIONS = new Button();
		Panel_FONCTIONS = new Panel();
		Label44 = new Label();
		Label45 = new Label();
		Label50 = new Label();
		Label51 = new Label();
		Button_PDF = new Button();
		Button_EXCEL = new Button();
		Button_WORD = new Button();
		Button_PRINT_80MM = new Button();
		Button_PRINT_A4 = new Button();
		Button_PrintRapport = new Button();
		Label_TABLE = new Label();
		Panel_FIND = new Panel();
		Panel_DATES = new Panel();
		DateTime2_FIND = new DateTimePicker();
		DateTime1_FIND = new DateTimePicker();
		Picture_FIND_DATES = new PictureBox();
		PictureBox13 = new PictureBox();
		Combo_FIND = new BunifuDropdown();
		Picture_EXPORT = new Button_RJ();
		Label19 = new Label();
		Label25 = new Label();
		Check_FIND_DATE = new BunifuCheckBox();
		Check_FIND_EXACTE = new BunifuCheckBox();
		Picture_REFRESH = new Button_RJ();
		Picture_FIND = new Button_RJ();
		Text_FIND = new RJTextBox();
		Panel2 = new Panel();
		DataGridView3 = new DataGridView();
		DataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
		DataGridView2 = new DataGridView();
		COL_1 = new DataGridViewTextBoxColumn();
		COL_2 = new DataGridViewTextBoxColumn();
		COL_3 = new DataGridViewTextBoxColumn();
		Dates = new DataGridViewTextBoxColumn();
		ID_INV = new DataGridViewTextBoxColumn();
		NOTES = new DataGridViewTextBoxColumn();
		TOTAL_VALEUR = new DataGridViewTextBoxColumn();
		ETAT = new DataGridViewTextBoxColumn();
		supp = new DataGridViewImageColumn();
		modi = new DataGridViewImageColumn();
		cons = new DataGridViewImageColumn();
		Label_TOTAL_VALEUR_DOC = new Label();
		Label52 = new Label();
		((Control)Panel_INFO).SuspendLayout();
		((Control)Panel_CLAVIER).SuspendLayout();
		((Control)Panel5).SuspendLayout();
		((ISupportInitialize)PictureBox2323).BeginInit();
		((Control)TabControl1).SuspendLayout();
		((Control)TabPage1).SuspendLayout();
		((Control)Panel4).SuspendLayout();
		((Control)Panel3).SuspendLayout();
		((Control)TabPage2).SuspendLayout();
		((Control)Panel6).SuspendLayout();
		((Control)Panel1).SuspendLayout();
		((ISupportInitialize)DataGridView_FAMILLES).BeginInit();
		((ISupportInitialize)DataGridView_ARTICLES).BeginInit();
		((ISupportInitialize)DataGrid_BODY).BeginInit();
		((ISupportInitialize)DataGridView1).BeginInit();
		((Control)Panel_INV_MASSE).SuspendLayout();
		((ISupportInitialize)PictureBox5).BeginInit();
		((Control)Panel243544).SuspendLayout();
		((Control)Panel7727).SuspendLayout();
		((ISupportInitialize)PictureBox3).BeginInit();
		((Control)Panel7).SuspendLayout();
		((Control)Panel_FONCTIONS).SuspendLayout();
		((Control)Panel_FIND).SuspendLayout();
		((Control)Panel_DATES).SuspendLayout();
		((ISupportInitialize)Picture_FIND_DATES).BeginInit();
		((ISupportInitialize)PictureBox13).BeginInit();
		((Control)Panel2).SuspendLayout();
		((ISupportInitialize)DataGridView3).BeginInit();
		((ISupportInitialize)DataGridView2).BeginInit();
		((Control)this).SuspendLayout();
		((Control)Panel_INFO).Anchor = (AnchorStyles)1;
		((Control)Panel_INFO).BackColor = Color.White;
		Panel_INFO.BorderStyle = (BorderStyle)1;
		((Control)Panel_INFO).Controls.Add((Control)(object)Button_CLAVIER);
		((Control)Panel_INFO).Controls.Add((Control)(object)Panel_CLAVIER);
		((Control)Panel_INFO).Controls.Add((Control)(object)Text_FIND_BODY);
		((Control)Panel_INFO).Controls.Add((Control)(object)Button_SPLITE);
		((Control)Panel_INFO).Controls.Add((Control)(object)Panel5);
		((Control)Panel_INFO).Controls.Add((Control)(object)Label_BOTTOM);
		((Control)Panel_INFO).Controls.Add((Control)(object)Label_LEFT);
		((Control)Panel_INFO).Controls.Add((Control)(object)PictureBox2323);
		((Control)Panel_INFO).Controls.Add((Control)(object)Label_RIGHT);
		((Control)Panel_INFO).Controls.Add((Control)(object)Label_INDEX);
		((Control)Panel_INFO).Controls.Add((Control)(object)Label_TOP);
		((Control)Panel_INFO).Controls.Add((Control)(object)Button_SAVE);
		((Control)Panel_INFO).Controls.Add((Control)(object)Button_CLOSE);
		((Control)Panel_INFO).Controls.Add((Control)(object)TabControl1);
		((Control)Panel_INFO).Controls.Add((Control)(object)DataGrid_BODY);
		Panel panel_INFO = Panel_INFO;
		Point location = new Point(63, 55);
		((Control)panel_INFO).Location = location;
		((Control)Panel_INFO).Name = "Panel_INFO";
		Panel panel_INFO2 = Panel_INFO;
		Size size = new Size(898, 548);
		((Control)panel_INFO2).Size = size;
		((Control)Panel_INFO).TabIndex = 378;
		((Control)Panel_INFO).Visible = false;
		((Control)Button_CLAVIER).BackgroundImage = (Image)componentResourceManager.GetObject("Button_CLAVIER.BackgroundImage");
		((Control)Button_CLAVIER).BackgroundImageLayout = (ImageLayout)4;
		((ButtonBase)Button_CLAVIER).ImeMode = (ImeMode)0;
		Button_CLAVIER_NOSELECT button_CLAVIER = Button_CLAVIER;
		location = new Point(430, 510);
		((Control)button_CLAVIER).Location = location;
		((Control)Button_CLAVIER).Name = "Button_CLAVIER";
		Button_CLAVIER_NOSELECT button_CLAVIER2 = Button_CLAVIER;
		size = new Size(36, 31);
		((Control)button_CLAVIER2).Size = size;
		((Control)Button_CLAVIER).TabIndex = 1028;
		((ButtonBase)Button_CLAVIER).UseVisualStyleBackColor = true;
		((Control)Panel_CLAVIER).BackColor = Color.Transparent;
		Panel_CLAVIER.BorderStyle = (BorderStyle)1;
		((Control)Panel_CLAVIER).Controls.Add((Control)(object)Button_CLAVIER_NOSELECT1);
		((Control)Panel_CLAVIER).Controls.Add((Control)(object)Butt_);
		((Control)Panel_CLAVIER).Controls.Add((Control)(object)Butt_DOT);
		((Control)Panel_CLAVIER).Controls.Add((Control)(object)Butt_1);
		((Control)Panel_CLAVIER).Controls.Add((Control)(object)Butt_2);
		((Control)Panel_CLAVIER).Controls.Add((Control)(object)Butt_4);
		((Control)Panel_CLAVIER).Controls.Add((Control)(object)Butt_3);
		((Control)Panel_CLAVIER).Controls.Add((Control)(object)Butt_5);
		((Control)Panel_CLAVIER).Controls.Add((Control)(object)Butt_7);
		((Control)Panel_CLAVIER).Controls.Add((Control)(object)Butt_8);
		((Control)Panel_CLAVIER).Controls.Add((Control)(object)Butt_BACK);
		((Control)Panel_CLAVIER).Controls.Add((Control)(object)Butt_6);
		((Control)Panel_CLAVIER).Controls.Add((Control)(object)Butt_9);
		((Control)Panel_CLAVIER).Controls.Add((Control)(object)Butt_0);
		Panel panel_CLAVIER = Panel_CLAVIER;
		location = new Point(815, 523);
		((Control)panel_CLAVIER).Location = location;
		((Control)Panel_CLAVIER).Name = "Panel_CLAVIER";
		Panel panel_CLAVIER2 = Panel_CLAVIER;
		size = new Size(312, 254);
		((Control)panel_CLAVIER2).Size = size;
		((Control)Panel_CLAVIER).TabIndex = 1027;
		((Control)Panel_CLAVIER).Visible = false;
		((ButtonBase)Button_CLAVIER_NOSELECT1).BackColor = Color.White;
		((Control)Button_CLAVIER_NOSELECT1).BackgroundImageLayout = (ImageLayout)2;
		((Control)Button_CLAVIER_NOSELECT1).Cursor = Cursors.Hand;
		((ButtonBase)Button_CLAVIER_NOSELECT1).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Button_CLAVIER_NOSELECT1).FlatStyle = (FlatStyle)0;
		((Control)Button_CLAVIER_NOSELECT1).Font = new Font("Calibri", 20.25f, (FontStyle)1);
		((Control)Button_CLAVIER_NOSELECT1).ForeColor = Color.Black;
		Button_CLAVIER_NOSELECT button_CLAVIER_NOSELECT = Button_CLAVIER_NOSELECT1;
		location = new Point(228, 121);
		((Control)button_CLAVIER_NOSELECT).Location = location;
		Button_CLAVIER_NOSELECT button_CLAVIER_NOSELECT2 = Button_CLAVIER_NOSELECT1;
		Padding margin = new Padding(0);
		((Control)button_CLAVIER_NOSELECT2).Margin = margin;
		((Control)Button_CLAVIER_NOSELECT1).Name = "Button_CLAVIER_NOSELECT1";
		Button_CLAVIER_NOSELECT button_CLAVIER_NOSELECT3 = Button_CLAVIER_NOSELECT1;
		size = new Size(61, 110);
		((Control)button_CLAVIER_NOSELECT3).Size = size;
		((Control)Button_CLAVIER_NOSELECT1).TabIndex = 795;
		((ButtonBase)Button_CLAVIER_NOSELECT1).Text = "OK";
		((ButtonBase)Button_CLAVIER_NOSELECT1).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_).BackColor = Color.White;
		((Control)Butt_).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_).Cursor = Cursors.Hand;
		((ButtonBase)Butt_).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_).FlatStyle = (FlatStyle)0;
		((Control)Butt_).Font = new Font("Calibri", 20.25f, (FontStyle)1);
		((Control)Butt_).ForeColor = Color.Black;
		Button_CLAVIER_NOSELECT butt_ = Butt_;
		location = new Point(159, 180);
		((Control)butt_).Location = location;
		Button_CLAVIER_NOSELECT butt_2 = Butt_;
		margin = new Padding(0);
		((Control)butt_2).Margin = margin;
		((Control)Butt_).Name = "Butt_";
		Button_CLAVIER_NOSELECT butt_3 = Butt_;
		size = new Size(61, 51);
		((Control)butt_3).Size = size;
		((Control)Butt_).TabIndex = 794;
		((ButtonBase)Butt_).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_DOT).BackColor = Color.White;
		((Control)Butt_DOT).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_DOT).Cursor = Cursors.Hand;
		((ButtonBase)Butt_DOT).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_DOT).FlatStyle = (FlatStyle)0;
		((Control)Butt_DOT).Font = new Font("Calibri", 20.25f, (FontStyle)1);
		((Control)Butt_DOT).ForeColor = Color.Black;
		Button_CLAVIER_NOSELECT butt_DOT = Butt_DOT;
		location = new Point(90, 180);
		((Control)butt_DOT).Location = location;
		Button_CLAVIER_NOSELECT butt_DOT2 = Butt_DOT;
		margin = new Padding(0);
		((Control)butt_DOT2).Margin = margin;
		((Control)Butt_DOT).Name = "Butt_DOT";
		Button_CLAVIER_NOSELECT butt_DOT3 = Butt_DOT;
		size = new Size(61, 51);
		((Control)butt_DOT3).Size = size;
		((Control)Butt_DOT).TabIndex = 793;
		((ButtonBase)Butt_DOT).Text = ".";
		((ButtonBase)Butt_DOT).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_1).BackColor = Color.White;
		((Control)Butt_1).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_1).CausesValidation = false;
		((Control)Butt_1).Cursor = Cursors.Hand;
		((ButtonBase)Butt_1).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_1).FlatStyle = (FlatStyle)0;
		((Control)Butt_1).Font = new Font("Calibri", 20.25f, (FontStyle)1);
		((Control)Butt_1).ForeColor = Color.Black;
		Button_CLAVIER_NOSELECT butt_4 = Butt_1;
		location = new Point(21, 121);
		((Control)butt_4).Location = location;
		Button_CLAVIER_NOSELECT butt_5 = Butt_1;
		margin = new Padding(0);
		((Control)butt_5).Margin = margin;
		((Control)Butt_1).Name = "Butt_1";
		Button_CLAVIER_NOSELECT butt_6 = Butt_1;
		size = new Size(61, 51);
		((Control)butt_6).Size = size;
		((Control)Butt_1).TabIndex = 785;
		((ButtonBase)Butt_1).Text = "1";
		((ButtonBase)Butt_1).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_2).BackColor = Color.White;
		((Control)Butt_2).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_2).Cursor = Cursors.Hand;
		((ButtonBase)Butt_2).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_2).FlatStyle = (FlatStyle)0;
		((Control)Butt_2).Font = new Font("Calibri", 20.25f, (FontStyle)1);
		((Control)Butt_2).ForeColor = Color.Black;
		Button_CLAVIER_NOSELECT butt_7 = Butt_2;
		location = new Point(90, 121);
		((Control)butt_7).Location = location;
		Button_CLAVIER_NOSELECT butt_8 = Butt_2;
		margin = new Padding(0);
		((Control)butt_8).Margin = margin;
		((Control)Butt_2).Name = "Butt_2";
		Button_CLAVIER_NOSELECT butt_9 = Butt_2;
		size = new Size(61, 51);
		((Control)butt_9).Size = size;
		((Control)Butt_2).TabIndex = 784;
		((ButtonBase)Butt_2).Text = "2";
		((ButtonBase)Butt_2).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_4).BackColor = Color.White;
		((Control)Butt_4).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_4).Cursor = Cursors.Hand;
		((ButtonBase)Butt_4).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_4).FlatStyle = (FlatStyle)0;
		((Control)Butt_4).Font = new Font("Calibri", 20.25f, (FontStyle)1);
		((Control)Butt_4).ForeColor = Color.Black;
		Button_CLAVIER_NOSELECT butt_10 = Butt_4;
		location = new Point(21, 62);
		((Control)butt_10).Location = location;
		Button_CLAVIER_NOSELECT butt_11 = Butt_4;
		margin = new Padding(0);
		((Control)butt_11).Margin = margin;
		((Control)Butt_4).Name = "Butt_4";
		Button_CLAVIER_NOSELECT butt_12 = Butt_4;
		size = new Size(61, 51);
		((Control)butt_12).Size = size;
		((Control)Butt_4).TabIndex = 788;
		((ButtonBase)Butt_4).Text = "4";
		((ButtonBase)Butt_4).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_3).BackColor = Color.White;
		((Control)Butt_3).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_3).Cursor = Cursors.Hand;
		((ButtonBase)Butt_3).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_3).FlatStyle = (FlatStyle)0;
		((Control)Butt_3).Font = new Font("Calibri", 20.25f, (FontStyle)1);
		((Control)Butt_3).ForeColor = Color.Black;
		Button_CLAVIER_NOSELECT butt_13 = Butt_3;
		location = new Point(159, 121);
		((Control)butt_13).Location = location;
		Button_CLAVIER_NOSELECT butt_14 = Butt_3;
		margin = new Padding(0);
		((Control)butt_14).Margin = margin;
		((Control)Butt_3).Name = "Butt_3";
		Button_CLAVIER_NOSELECT butt_15 = Butt_3;
		size = new Size(61, 51);
		((Control)butt_15).Size = size;
		((Control)Butt_3).TabIndex = 783;
		((ButtonBase)Butt_3).Text = "3";
		((ButtonBase)Butt_3).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_5).BackColor = Color.White;
		((Control)Butt_5).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_5).Cursor = Cursors.Hand;
		((ButtonBase)Butt_5).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_5).FlatStyle = (FlatStyle)0;
		((Control)Butt_5).Font = new Font("Calibri", 20.25f, (FontStyle)1);
		((Control)Butt_5).ForeColor = Color.Black;
		Button_CLAVIER_NOSELECT butt_16 = Butt_5;
		location = new Point(90, 62);
		((Control)butt_16).Location = location;
		Button_CLAVIER_NOSELECT butt_17 = Butt_5;
		margin = new Padding(0);
		((Control)butt_17).Margin = margin;
		((Control)Butt_5).Name = "Butt_5";
		Button_CLAVIER_NOSELECT butt_18 = Butt_5;
		size = new Size(61, 51);
		((Control)butt_18).Size = size;
		((Control)Butt_5).TabIndex = 786;
		((ButtonBase)Butt_5).Text = "5";
		((ButtonBase)Butt_5).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_7).BackColor = Color.White;
		((Control)Butt_7).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_7).Cursor = Cursors.Hand;
		((ButtonBase)Butt_7).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_7).FlatStyle = (FlatStyle)0;
		((Control)Butt_7).Font = new Font("Calibri", 20.25f, (FontStyle)1);
		((Control)Butt_7).ForeColor = Color.Black;
		Button_CLAVIER_NOSELECT butt_19 = Butt_7;
		location = new Point(21, 3);
		((Control)butt_19).Location = location;
		Button_CLAVIER_NOSELECT butt_20 = Butt_7;
		margin = new Padding(0);
		((Control)butt_20).Margin = margin;
		((Control)Butt_7).Name = "Butt_7";
		Button_CLAVIER_NOSELECT butt_21 = Butt_7;
		size = new Size(61, 51);
		((Control)butt_21).Size = size;
		((Control)Butt_7).TabIndex = 790;
		((ButtonBase)Butt_7).Text = "7";
		((ButtonBase)Butt_7).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_8).BackColor = Color.White;
		((Control)Butt_8).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_8).Cursor = Cursors.Hand;
		((ButtonBase)Butt_8).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_8).FlatStyle = (FlatStyle)0;
		((Control)Butt_8).Font = new Font("Calibri", 20.25f, (FontStyle)1);
		((Control)Butt_8).ForeColor = Color.Black;
		Button_CLAVIER_NOSELECT butt_22 = Butt_8;
		location = new Point(90, 3);
		((Control)butt_22).Location = location;
		Button_CLAVIER_NOSELECT butt_23 = Butt_8;
		margin = new Padding(0);
		((Control)butt_23).Margin = margin;
		((Control)Butt_8).Name = "Butt_8";
		Button_CLAVIER_NOSELECT butt_24 = Butt_8;
		size = new Size(61, 51);
		((Control)butt_24).Size = size;
		((Control)Butt_8).TabIndex = 791;
		((ButtonBase)Butt_8).Text = "8";
		((ButtonBase)Butt_8).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_BACK).BackColor = Color.White;
		((Control)Butt_BACK).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_BACK).Cursor = Cursors.Hand;
		((ButtonBase)Butt_BACK).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_BACK).FlatStyle = (FlatStyle)0;
		((Control)Butt_BACK).Font = new Font("Calibri", 20.25f, (FontStyle)1);
		((Control)Butt_BACK).ForeColor = Color.Black;
		((ButtonBase)Butt_BACK).Image = (Image)componentResourceManager.GetObject("Butt_BACK.Image");
		Button_CLAVIER_NOSELECT butt_BACK = Butt_BACK;
		location = new Point(228, 3);
		((Control)butt_BACK).Location = location;
		Button_CLAVIER_NOSELECT butt_BACK2 = Butt_BACK;
		margin = new Padding(0);
		((Control)butt_BACK2).Margin = margin;
		((Control)Butt_BACK).Name = "Butt_BACK";
		Button_CLAVIER_NOSELECT butt_BACK3 = Butt_BACK;
		size = new Size(61, 110);
		((Control)butt_BACK3).Size = size;
		((Control)Butt_BACK).TabIndex = 782;
		((ButtonBase)Butt_BACK).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_6).BackColor = Color.White;
		((Control)Butt_6).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_6).Cursor = Cursors.Hand;
		((ButtonBase)Butt_6).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_6).FlatStyle = (FlatStyle)0;
		((Control)Butt_6).Font = new Font("Calibri", 20.25f, (FontStyle)1);
		((Control)Butt_6).ForeColor = Color.Black;
		Button_CLAVIER_NOSELECT butt_25 = Butt_6;
		location = new Point(159, 62);
		((Control)butt_25).Location = location;
		Button_CLAVIER_NOSELECT butt_26 = Butt_6;
		margin = new Padding(0);
		((Control)butt_26).Margin = margin;
		((Control)Butt_6).Name = "Butt_6";
		Button_CLAVIER_NOSELECT butt_27 = Butt_6;
		size = new Size(61, 51);
		((Control)butt_27).Size = size;
		((Control)Butt_6).TabIndex = 789;
		((ButtonBase)Butt_6).Text = "6";
		((ButtonBase)Butt_6).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_9).BackColor = Color.White;
		((Control)Butt_9).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_9).Cursor = Cursors.Hand;
		((ButtonBase)Butt_9).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_9).FlatStyle = (FlatStyle)0;
		((Control)Butt_9).Font = new Font("Calibri", 20.25f, (FontStyle)1);
		((Control)Butt_9).ForeColor = Color.Black;
		Button_CLAVIER_NOSELECT butt_28 = Butt_9;
		location = new Point(159, 3);
		((Control)butt_28).Location = location;
		Button_CLAVIER_NOSELECT butt_29 = Butt_9;
		margin = new Padding(0);
		((Control)butt_29).Margin = margin;
		((Control)Butt_9).Name = "Butt_9";
		Button_CLAVIER_NOSELECT butt_30 = Butt_9;
		size = new Size(61, 51);
		((Control)butt_30).Size = size;
		((Control)Butt_9).TabIndex = 787;
		((ButtonBase)Butt_9).Text = "9";
		((ButtonBase)Butt_9).UseVisualStyleBackColor = false;
		((ButtonBase)Butt_0).BackColor = Color.White;
		((Control)Butt_0).BackgroundImageLayout = (ImageLayout)2;
		((Control)Butt_0).Cursor = Cursors.Hand;
		((ButtonBase)Butt_0).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Butt_0).FlatStyle = (FlatStyle)0;
		((Control)Butt_0).Font = new Font("Calibri", 20.25f, (FontStyle)1);
		((Control)Butt_0).ForeColor = Color.Black;
		Button_CLAVIER_NOSELECT butt_31 = Butt_0;
		location = new Point(21, 180);
		((Control)butt_31).Location = location;
		Button_CLAVIER_NOSELECT butt_32 = Butt_0;
		margin = new Padding(0);
		((Control)butt_32).Margin = margin;
		((Control)Butt_0).Name = "Butt_0";
		Button_CLAVIER_NOSELECT butt_33 = Butt_0;
		size = new Size(61, 51);
		((Control)butt_33).Size = size;
		((Control)Butt_0).TabIndex = 792;
		((ButtonBase)Butt_0).Text = "0";
		((ButtonBase)Butt_0).UseVisualStyleBackColor = false;
		Text_FIND_BODY.BackColor = Color.WhiteSmoke;
		Text_FIND_BODY.BorderColor = Color.Silver;
		Text_FIND_BODY.BorderFocusColor = Color.Silver;
		Text_FIND_BODY.BorderRadius = 8;
		Text_FIND_BODY.BorderSize = 1;
		Text_FIND_BODY.Font = new Font("Calibri", 10f);
		Text_FIND_BODY.ForeColor = Color.Black;
		RJTextBox text_FIND_BODY = Text_FIND_BODY;
		location = new Point(10, 302);
		((Control)text_FIND_BODY).Location = location;
		RJTextBox text_FIND_BODY2 = Text_FIND_BODY;
		margin = new Padding(4);
		((Control)text_FIND_BODY2).Margin = margin;
		Text_FIND_BODY.Multiline = false;
		((Control)Text_FIND_BODY).Name = "Text_FIND_BODY";
		RJTextBox text_FIND_BODY3 = Text_FIND_BODY;
		margin = new Padding(10, 4, 10, 3);
		((Control)text_FIND_BODY3).Padding = margin;
		Text_FIND_BODY.PasswordChar = false;
		Text_FIND_BODY.PlaceholderColor = Color.DimGray;
		Text_FIND_BODY.PlaceholderText = "";
		RJTextBox text_FIND_BODY4 = Text_FIND_BODY;
		size = new Size(188, 25);
		((Control)text_FIND_BODY4).Size = size;
		((Control)Text_FIND_BODY).TabIndex = 1026;
		Text_FIND_BODY.Texts = "";
		Text_FIND_BODY.UnderlinedStyle = false;
		((Control)Button_SPLITE).Cursor = Cursors.Hand;
		((ButtonBase)Button_SPLITE).FlatAppearance.BorderColor = Color.Silver;
		((ButtonBase)Button_SPLITE).FlatStyle = (FlatStyle)0;
		((ButtonBase)Button_SPLITE).Image = (Image)componentResourceManager.GetObject("Button_SPLITE.Image");
		Button button_SPLITE = Button_SPLITE;
		location = new Point(411, 304);
		((Control)button_SPLITE).Location = location;
		((Control)Button_SPLITE).Name = "Button_SPLITE";
		Button button_SPLITE2 = Button_SPLITE;
		size = new Size(76, 19);
		((Control)button_SPLITE2).Size = size;
		((Control)Button_SPLITE).TabIndex = 992;
		((ButtonBase)Button_SPLITE).UseVisualStyleBackColor = true;
		((Control)Panel5).BackColor = Color.Transparent;
		((Control)Panel5).Controls.Add((Control)(object)Label_TOTAL_VALEUR_DOC);
		((Control)Panel5).Controls.Add((Control)(object)Label52);
		((Control)Panel5).Controls.Add((Control)(object)Label_TOTAL_LIGNES);
		((Control)Panel5).Controls.Add((Control)(object)Label15);
		((Control)Panel5).Controls.Add((Control)(object)Label33);
		((Control)Panel5).Controls.Add((Control)(object)Button6);
		((Control)Panel5).Controls.Add((Control)(object)Button23);
		((Control)Panel5).Controls.Add((Control)(object)Button_CALC_DOC);
		Panel panel = Panel5;
		location = new Point(10, 476);
		((Control)panel).Location = location;
		((Control)Panel5).Name = "Panel5";
		Panel panel2 = Panel5;
		size = new Size(877, 31);
		((Control)panel2).Size = size;
		((Control)Panel5).TabIndex = 991;
		((Control)Label_TOTAL_LIGNES).BackColor = Color.White;
		((Control)Label_TOTAL_LIGNES).Font = new Font("Calibri", 11f, (FontStyle)1);
		((Control)Label_TOTAL_LIGNES).ForeColor = Color.FromArgb(64, 64, 64);
		Label label_TOTAL_LIGNES = Label_TOTAL_LIGNES;
		location = new Point(3, 1);
		((Control)label_TOTAL_LIGNES).Location = location;
		((Control)Label_TOTAL_LIGNES).Name = "Label_TOTAL_LIGNES";
		Label label_TOTAL_LIGNES2 = Label_TOTAL_LIGNES;
		size = new Size(66, 29);
		((Control)label_TOTAL_LIGNES2).Size = size;
		((Control)Label_TOTAL_LIGNES).TabIndex = 1073;
		Label_TOTAL_LIGNES.Text = "-/-";
		Label_TOTAL_LIGNES.TextAlign = (ContentAlignment)16;
		((Control)Label15).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label15).Cursor = Cursors.Hand;
		((Control)Label15).Dock = (DockStyle)2;
		((Control)Label15).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label15).ForeColor = Color.White;
		Label label = Label15;
		location = new Point(0, 30);
		((Control)label).Location = location;
		((Control)Label15).Name = "Label15";
		Label label2 = Label15;
		size = new Size(877, 1);
		((Control)label2).Size = size;
		((Control)Label15).TabIndex = 1067;
		Label15.TextAlign = (ContentAlignment)16;
		((Control)Label33).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label33).Cursor = Cursors.Hand;
		((Control)Label33).Dock = (DockStyle)1;
		((Control)Label33).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label33).ForeColor = Color.White;
		Label label3 = Label33;
		location = new Point(0, 0);
		((Control)label3).Location = location;
		((Control)Label33).Name = "Label33";
		Label label4 = Label33;
		size = new Size(877, 1);
		((Control)label4).Size = size;
		((Control)Label33).TabIndex = 1066;
		Label33.TextAlign = (ContentAlignment)16;
		((Control)Button6).Cursor = Cursors.Hand;
		((ButtonBase)Button6).FlatAppearance.BorderColor = Color.DarkGray;
		((Control)Button6).Font = new Font("Tahoma", 9f, (FontStyle)1);
		((Control)Button6).ForeColor = Color.Black;
		((ButtonBase)Button6).Image = (Image)componentResourceManager.GetObject("Button6.Image");
		((ButtonBase)Button6).ImageAlign = (ContentAlignment)16;
		Button button = Button6;
		location = new Point(338, 1);
		((Control)button).Location = location;
		Button button2 = Button6;
		margin = new Padding(0);
		((Control)button2).Margin = margin;
		((Control)Button6).Name = "Button6";
		Button button3 = Button6;
		size = new Size(97, 28);
		((Control)button3).Size = size;
		((Control)Button6).TabIndex = 994;
		((ButtonBase)Button6).Text = "     Importer";
		((ButtonBase)Button6).UseVisualStyleBackColor = true;
		((Control)Button23).Cursor = Cursors.Hand;
		((ButtonBase)Button23).FlatAppearance.BorderColor = Color.DarkGray;
		((Control)Button23).Font = new Font("Tahoma", 9f, (FontStyle)1);
		((Control)Button23).ForeColor = Color.Black;
		((ButtonBase)Button23).Image = (Image)componentResourceManager.GetObject("Button23.Image");
		((ButtonBase)Button23).ImageAlign = (ContentAlignment)16;
		Button button4 = Button23;
		location = new Point(441, 1);
		((Control)button4).Location = location;
		Button button5 = Button23;
		margin = new Padding(0);
		((Control)button5).Margin = margin;
		((Control)Button23).Name = "Button23";
		Button button6 = Button23;
		size = new Size(97, 28);
		((Control)button6).Size = size;
		((Control)Button23).TabIndex = 993;
		((ButtonBase)Button23).Text = "     Exporter";
		((ButtonBase)Button23).UseVisualStyleBackColor = true;
		((Control)Button_CALC_DOC).ForeColor = Color.Red;
		Button button_CALC_DOC = Button_CALC_DOC;
		location = new Point(131, 0);
		((Control)button_CALC_DOC).Location = location;
		((Control)Button_CALC_DOC).Name = "Button_CALC_DOC";
		Button button_CALC_DOC2 = Button_CALC_DOC;
		size = new Size(48, 29);
		((Control)button_CALC_DOC2).Size = size;
		((Control)Button_CALC_DOC).TabIndex = 992;
		((ButtonBase)Button_CALC_DOC).Text = "CALC";
		((ButtonBase)Button_CALC_DOC).UseVisualStyleBackColor = true;
		((Control)Button_CALC_DOC).Visible = false;
		((Control)Label_BOTTOM).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label_BOTTOM).Cursor = Cursors.Hand;
		((Control)Label_BOTTOM).Dock = (DockStyle)2;
		((Control)Label_BOTTOM).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label_BOTTOM).ForeColor = Color.White;
		Label label_BOTTOM = Label_BOTTOM;
		location = new Point(4, 542);
		((Control)label_BOTTOM).Location = location;
		((Control)Label_BOTTOM).Name = "Label_BOTTOM";
		Label label_BOTTOM2 = Label_BOTTOM;
		size = new Size(888, 4);
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
		size = new Size(4, 522);
		((Control)label_LEFT2).Size = size;
		((Control)Label_LEFT).TabIndex = 865;
		Label_LEFT.TextAlign = (ContentAlignment)16;
		((Control)PictureBox2323).Cursor = Cursors.Hand;
		PictureBox2323.Image = (Image)componentResourceManager.GetObject("PictureBox2323.Image");
		PictureBox pictureBox = PictureBox2323;
		location = new Point(202, 302);
		((Control)pictureBox).Location = location;
		((Control)PictureBox2323).Name = "PictureBox2323";
		PictureBox pictureBox2 = PictureBox2323;
		size = new Size(24, 26);
		((Control)pictureBox2).Size = size;
		PictureBox2323.SizeMode = (PictureBoxSizeMode)4;
		PictureBox2323.TabIndex = 997;
		PictureBox2323.TabStop = false;
		((Control)Label_RIGHT).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label_RIGHT).Cursor = Cursors.Hand;
		((Control)Label_RIGHT).Dock = (DockStyle)4;
		((Control)Label_RIGHT).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label_RIGHT).ForeColor = Color.White;
		Label label_RIGHT = Label_RIGHT;
		location = new Point(892, 24);
		((Control)label_RIGHT).Location = location;
		((Control)Label_RIGHT).Name = "Label_RIGHT";
		Label label_RIGHT2 = Label_RIGHT;
		size = new Size(4, 522);
		((Control)label_RIGHT2).Size = size;
		((Control)Label_RIGHT).TabIndex = 864;
		Label_RIGHT.TextAlign = (ContentAlignment)16;
		((Control)Label_INDEX).Anchor = (AnchorStyles)9;
		((Control)Label_INDEX).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label_INDEX).Cursor = Cursors.Hand;
		((Control)Label_INDEX).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label_INDEX).ForeColor = Color.White;
		Label label_INDEX = Label_INDEX;
		location = new Point(860, 0);
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
		size = new Size(896, 24);
		((Control)label_TOP2).Size = size;
		((Control)Label_TOP).TabIndex = 862;
		Label_TOP.Text = "-";
		Label_TOP.TextAlign = (ContentAlignment)16;
		((ButtonBase)Button_SAVE).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Button_SAVE).Cursor = Cursors.Hand;
		((ButtonBase)Button_SAVE).FlatStyle = (FlatStyle)0;
		((Control)Button_SAVE).Font = new Font("Segoe UI", 12f, (FontStyle)1);
		((Control)Button_SAVE).ForeColor = Color.White;
		((ButtonBase)Button_SAVE).Image = (Image)componentResourceManager.GetObject("Button_SAVE.Image");
		((ButtonBase)Button_SAVE).ImageAlign = (ContentAlignment)16;
		Button button_SAVE = Button_SAVE;
		location = new Point(731, 510);
		((Control)button_SAVE).Location = location;
		Button button_SAVE2 = Button_SAVE;
		margin = new Padding(0);
		((Control)button_SAVE2).Margin = margin;
		((Control)Button_SAVE).Name = "Button_SAVE";
		Button button_SAVE3 = Button_SAVE;
		size = new Size(156, 30);
		((Control)button_SAVE3).Size = size;
		((Control)Button_SAVE).TabIndex = 0;
		((ButtonBase)Button_SAVE).Text = "Enregistrer";
		((ButtonBase)Button_SAVE).UseVisualStyleBackColor = false;
		((ButtonBase)Button_CLOSE).BackColor = Color.Red;
		((Control)Button_CLOSE).Cursor = Cursors.Hand;
		((ButtonBase)Button_CLOSE).FlatStyle = (FlatStyle)0;
		((Control)Button_CLOSE).Font = new Font("Segoe UI", 12f, (FontStyle)1);
		((Control)Button_CLOSE).ForeColor = Color.White;
		((ButtonBase)Button_CLOSE).Image = (Image)componentResourceManager.GetObject("Button_CLOSE.Image");
		((ButtonBase)Button_CLOSE).ImageAlign = (ContentAlignment)16;
		Button button_CLOSE = Button_CLOSE;
		location = new Point(10, 510);
		((Control)button_CLOSE).Location = location;
		Button button_CLOSE2 = Button_CLOSE;
		margin = new Padding(0);
		((Control)button_CLOSE2).Margin = margin;
		((Control)Button_CLOSE).Name = "Button_CLOSE";
		Button button_CLOSE3 = Button_CLOSE;
		size = new Size(156, 30);
		((Control)button_CLOSE3).Size = size;
		((Control)Button_CLOSE).TabIndex = 680;
		((ButtonBase)Button_CLOSE).Text = "  Fermer";
		((ButtonBase)Button_CLOSE).UseVisualStyleBackColor = false;
		((Control)TabControl1).Controls.Add((Control)(object)TabPage1);
		((Control)TabControl1).Controls.Add((Control)(object)TabPage2);
		((Control)TabControl1).Font = new Font("Tahoma", 8.25f, (FontStyle)1);
		TabControl tabControl = TabControl1;
		size = new Size(60, 28);
		tabControl.ItemSize = size;
		TabControl tabControl2 = TabControl1;
		location = new Point(10, 28);
		((Control)tabControl2).Location = location;
		((Control)TabControl1).Name = "TabControl1";
		TabControl1.SelectedIndex = 0;
		TabControl tabControl3 = TabControl1;
		size = new Size(877, 274);
		((Control)tabControl3).Size = size;
		((Control)TabControl1).TabIndex = 867;
		TabPage1.BackColor = Color.White;
		((Control)TabPage1).Controls.Add((Control)(object)Panel4);
		((Control)TabPage1).Controls.Add((Control)(object)Panel3);
		TabPage tabPage = TabPage1;
		location = new Point(4, 32);
		tabPage.Location = location;
		((Control)TabPage1).Name = "TabPage1";
		TabPage tabPage2 = TabPage1;
		margin = new Padding(3);
		((Control)tabPage2).Padding = margin;
		TabPage tabPage3 = TabPage1;
		size = new Size(869, 238);
		((Control)tabPage3).Size = size;
		TabPage1.TabIndex = 0;
		TabPage1.Text = "Informations";
		((Control)Panel4).BackColor = Color.White;
		((Control)Panel4).Controls.Add((Control)(object)Label10);
		((Control)Panel4).Controls.Add((Control)(object)Label7);
		((Control)Panel4).Controls.Add((Control)(object)Text_NOTES);
		((Control)Panel4).Controls.Add((Control)(object)Label13);
		((Control)Panel4).Controls.Add((Control)(object)Label20);
		((Control)Panel4).Controls.Add((Control)(object)Label21);
		Panel panel3 = Panel4;
		location = new Point(442, 8);
		((Control)panel3).Location = location;
		((Control)Panel4).Name = "Panel4";
		Panel panel4 = Panel4;
		size = new Size(417, 158);
		((Control)panel4).Size = size;
		((Control)Panel4).TabIndex = 991;
		((Control)Label10).BackColor = SystemColors.Control;
		((Control)Label10).Font = new Font("Segoe UI", 10f, (FontStyle)1);
		((Control)Label10).ForeColor = Color.Black;
		Label label5 = Label10;
		location = new Point(18, 11);
		((Control)label5).Location = location;
		((Control)Label10).Name = "Label10";
		Label label6 = Label10;
		size = new Size(142, 23);
		((Control)label6).Size = size;
		((Control)Label10).TabIndex = 973;
		Label10.Text = "NOTES";
		Label10.TextAlign = (ContentAlignment)16;
		((Control)Label7).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label7).Cursor = Cursors.Hand;
		((Control)Label7).Dock = (DockStyle)2;
		((Control)Label7).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label7).ForeColor = Color.White;
		Label label7 = Label7;
		location = new Point(1, 157);
		((Control)label7).Location = location;
		((Control)Label7).Name = "Label7";
		Label label8 = Label7;
		size = new Size(415, 1);
		((Control)label8).Size = size;
		((Control)Label7).TabIndex = 997;
		Label7.TextAlign = (ContentAlignment)16;
		((Control)Text_NOTES).Font = new Font("Cambria", 9.75f);
		TextBox text_NOTES = Text_NOTES;
		location = new Point(164, 11);
		((Control)text_NOTES).Location = location;
		Text_NOTES.Multiline = true;
		((Control)Text_NOTES).Name = "Text_NOTES";
		TextBox text_NOTES2 = Text_NOTES;
		size = new Size(243, 55);
		((Control)text_NOTES2).Size = size;
		((Control)Text_NOTES).TabIndex = 972;
		((Control)Label13).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label13).Cursor = Cursors.Hand;
		((Control)Label13).Dock = (DockStyle)3;
		((Control)Label13).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label13).ForeColor = Color.White;
		Label label9 = Label13;
		location = new Point(0, 1);
		((Control)label9).Location = location;
		((Control)Label13).Name = "Label13";
		Label label10 = Label13;
		size = new Size(1, 157);
		((Control)label10).Size = size;
		((Control)Label13).TabIndex = 994;
		Label13.TextAlign = (ContentAlignment)16;
		((Control)Label20).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label20).Cursor = Cursors.Hand;
		((Control)Label20).Dock = (DockStyle)4;
		((Control)Label20).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label20).ForeColor = Color.White;
		Label label11 = Label20;
		location = new Point(416, 1);
		((Control)label11).Location = location;
		((Control)Label20).Name = "Label20";
		Label label12 = Label20;
		size = new Size(1, 157);
		((Control)label12).Size = size;
		((Control)Label20).TabIndex = 993;
		Label20.TextAlign = (ContentAlignment)16;
		((Control)Label21).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label21).Cursor = Cursors.Hand;
		((Control)Label21).Dock = (DockStyle)1;
		((Control)Label21).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label21).ForeColor = Color.White;
		Label label13 = Label21;
		location = new Point(0, 0);
		((Control)label13).Location = location;
		((Control)Label21).Name = "Label21";
		Label label14 = Label21;
		size = new Size(417, 1);
		((Control)label14).Size = size;
		((Control)Label21).TabIndex = 992;
		Label21.Text = "-";
		Label21.TextAlign = (ContentAlignment)16;
		((Control)Panel3).BackColor = Color.White;
		((Control)Panel3).Controls.Add((Control)(object)Text_ETAT);
		((Control)Panel3).Controls.Add((Control)(object)Label2);
		((Control)Panel3).Controls.Add((Control)(object)Label1);
		((Control)Panel3).Controls.Add((Control)(object)Label12);
		((Control)Panel3).Controls.Add((Control)(object)Label28);
		((Control)Panel3).Controls.Add((Control)(object)Label29);
		((Control)Panel3).Controls.Add((Control)(object)Text_UTILISATEUR);
		((Control)Panel3).Controls.Add((Control)(object)Label30);
		((Control)Panel3).Controls.Add((Control)(object)Label6);
		((Control)Panel3).Controls.Add((Control)(object)Text_ID);
		((Control)Panel3).Controls.Add((Control)(object)Label4);
		((Control)Panel3).Controls.Add((Control)(object)Text_ID_INV);
		((Control)Panel3).Controls.Add((Control)(object)DateTimePicker_DATE);
		Panel panel5 = Panel3;
		location = new Point(10, 8);
		((Control)panel5).Location = location;
		((Control)Panel3).Name = "Panel3";
		Panel panel6 = Panel3;
		size = new Size(417, 158);
		((Control)panel6).Size = size;
		((Control)Panel3).TabIndex = 990;
		((TextBoxBase)Text_ETAT).BackColor = Color.White;
		((Control)Text_ETAT).Enabled = false;
		((Control)Text_ETAT).Font = new Font("Cambria", 9.75f);
		TextBox text_ETAT = Text_ETAT;
		location = new Point(159, 124);
		((Control)text_ETAT).Location = location;
		((Control)Text_ETAT).Name = "Text_ETAT";
		TextBox text_ETAT2 = Text_ETAT;
		size = new Size(249, 23);
		((Control)text_ETAT2).Size = size;
		((Control)Text_ETAT).TabIndex = 967;
		Text_ETAT.TextAlign = (HorizontalAlignment)2;
		((Control)Label2).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label2).Cursor = Cursors.Hand;
		((Control)Label2).Dock = (DockStyle)2;
		((Control)Label2).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label2).ForeColor = Color.White;
		Label label15 = Label2;
		location = new Point(1, 157);
		((Control)label15).Location = location;
		((Control)Label2).Name = "Label2";
		Label label16 = Label2;
		size = new Size(415, 1);
		((Control)label16).Size = size;
		((Control)Label2).TabIndex = 997;
		Label2.TextAlign = (ContentAlignment)16;
		((Control)Label1).BackColor = SystemColors.Control;
		((Control)Label1).Font = new Font("Segoe UI", 10f, (FontStyle)1);
		((Control)Label1).ForeColor = Color.Black;
		Label label17 = Label1;
		location = new Point(20, 11);
		((Control)label17).Location = location;
		((Control)Label1).Name = "Label1";
		Label label18 = Label1;
		size = new Size(134, 23);
		((Control)label18).Size = size;
		((Control)Label1).TabIndex = 961;
		Label1.Text = "DATES";
		Label1.TextAlign = (ContentAlignment)16;
		((Control)Label12).BackColor = SystemColors.Control;
		((Control)Label12).Font = new Font("Segoe UI", 10f, (FontStyle)1);
		((Control)Label12).ForeColor = Color.Black;
		Label label19 = Label12;
		location = new Point(20, 124);
		((Control)label19).Location = location;
		((Control)Label12).Name = "Label12";
		Label label20 = Label12;
		size = new Size(134, 23);
		((Control)label20).Size = size;
		((Control)Label12).TabIndex = 966;
		Label12.Text = "ETAT";
		Label12.TextAlign = (ContentAlignment)16;
		((Control)Label28).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label28).Cursor = Cursors.Hand;
		((Control)Label28).Dock = (DockStyle)3;
		((Control)Label28).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label28).ForeColor = Color.White;
		Label label21 = Label28;
		location = new Point(0, 1);
		((Control)label21).Location = location;
		((Control)Label28).Name = "Label28";
		Label label22 = Label28;
		size = new Size(1, 157);
		((Control)label22).Size = size;
		((Control)Label28).TabIndex = 994;
		Label28.TextAlign = (ContentAlignment)16;
		((Control)Label29).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label29).Cursor = Cursors.Hand;
		((Control)Label29).Dock = (DockStyle)4;
		((Control)Label29).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label29).ForeColor = Color.White;
		Label label23 = Label29;
		location = new Point(416, 1);
		((Control)label23).Location = location;
		((Control)Label29).Name = "Label29";
		Label label24 = Label29;
		size = new Size(1, 157);
		((Control)label24).Size = size;
		((Control)Label29).TabIndex = 993;
		Label29.TextAlign = (ContentAlignment)16;
		((TextBoxBase)Text_UTILISATEUR).BackColor = Color.White;
		((Control)Text_UTILISATEUR).Enabled = false;
		((Control)Text_UTILISATEUR).Font = new Font("Cambria", 9.75f);
		TextBox text_UTILISATEUR = Text_UTILISATEUR;
		location = new Point(159, 96);
		((Control)text_UTILISATEUR).Location = location;
		((Control)Text_UTILISATEUR).Name = "Text_UTILISATEUR";
		TextBox text_UTILISATEUR2 = Text_UTILISATEUR;
		size = new Size(249, 23);
		((Control)text_UTILISATEUR2).Size = size;
		((Control)Text_UTILISATEUR).TabIndex = 964;
		Text_UTILISATEUR.TextAlign = (HorizontalAlignment)2;
		((Control)Label30).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label30).Cursor = Cursors.Hand;
		((Control)Label30).Dock = (DockStyle)1;
		((Control)Label30).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label30).ForeColor = Color.White;
		Label label25 = Label30;
		location = new Point(0, 0);
		((Control)label25).Location = location;
		((Control)Label30).Name = "Label30";
		Label label26 = Label30;
		size = new Size(417, 1);
		((Control)label26).Size = size;
		((Control)Label30).TabIndex = 992;
		Label30.Text = "-";
		Label30.TextAlign = (ContentAlignment)16;
		((Control)Label6).BackColor = SystemColors.Control;
		((Control)Label6).Font = new Font("Segoe UI", 10f, (FontStyle)1);
		((Control)Label6).ForeColor = Color.Black;
		Label label27 = Label6;
		location = new Point(20, 96);
		((Control)label27).Location = location;
		((Control)Label6).Name = "Label6";
		Label label28 = Label6;
		size = new Size(134, 23);
		((Control)label28).Size = size;
		((Control)Label6).TabIndex = 965;
		Label6.Text = "UTILISATEUR";
		Label6.TextAlign = (ContentAlignment)16;
		((TextBoxBase)Text_ID).BackColor = Color.White;
		((TextBoxBase)Text_ID).BorderStyle = (BorderStyle)1;
		((Control)Text_ID).Enabled = false;
		((Control)Text_ID).Font = new Font("Cambria", 9.75f);
		TextBox text_ID = Text_ID;
		location = new Point(159, 11);
		((Control)text_ID).Location = location;
		((Control)Text_ID).Name = "Text_ID";
		TextBox text_ID2 = Text_ID;
		size = new Size(25, 23);
		((Control)text_ID2).Size = size;
		((Control)Text_ID).TabIndex = 2;
		Text_ID.TextAlign = (HorizontalAlignment)2;
		((Control)Text_ID).Visible = false;
		((Control)Label4).BackColor = SystemColors.Control;
		((Control)Label4).Font = new Font("Segoe UI", 10f, (FontStyle)1);
		((Control)Label4).ForeColor = Color.Black;
		Label label29 = Label4;
		location = new Point(20, 40);
		((Control)label29).Location = location;
		((Control)Label4).Name = "Label4";
		Label label30 = Label4;
		size = new Size(134, 23);
		((Control)label30).Size = size;
		((Control)Label4).TabIndex = 963;
		Label4.Text = "ID_INV";
		Label4.TextAlign = (ContentAlignment)16;
		((TextBoxBase)Text_ID_INV).BackColor = Color.White;
		((Control)Text_ID_INV).Enabled = false;
		((Control)Text_ID_INV).Font = new Font("Cambria", 9.75f);
		TextBox text_ID_INV = Text_ID_INV;
		location = new Point(159, 40);
		((Control)text_ID_INV).Location = location;
		((Control)Text_ID_INV).Name = "Text_ID_INV";
		TextBox text_ID_INV2 = Text_ID_INV;
		size = new Size(249, 23);
		((Control)text_ID_INV2).Size = size;
		((Control)Text_ID_INV).TabIndex = 962;
		Text_ID_INV.TextAlign = (HorizontalAlignment)2;
		DateTimePicker_DATE.CustomFormat = "yyyy-MM-dd";
		((Control)DateTimePicker_DATE).Font = new Font("Cambria", 9.75f);
		DateTimePicker_DATE.Format = (DateTimePickerFormat)2;
		DateTimePicker dateTimePicker_DATE = DateTimePicker_DATE;
		location = new Point(159, 11);
		((Control)dateTimePicker_DATE).Location = location;
		((Control)DateTimePicker_DATE).Name = "DateTimePicker_DATE";
		DateTimePicker dateTimePicker_DATE2 = DateTimePicker_DATE;
		size = new Size(249, 23);
		((Control)dateTimePicker_DATE2).Size = size;
		((Control)DateTimePicker_DATE).TabIndex = 960;
		TabPage2.BackColor = Color.White;
		((Control)TabPage2).Controls.Add((Control)(object)Panel6);
		((Control)TabPage2).Controls.Add((Control)(object)Panel1);
		TabPage tabPage4 = TabPage2;
		location = new Point(4, 32);
		tabPage4.Location = location;
		((Control)TabPage2).Name = "TabPage2";
		TabPage tabPage5 = TabPage2;
		margin = new Padding(3);
		((Control)tabPage5).Padding = margin;
		TabPage tabPage6 = TabPage2;
		size = new Size(869, 238);
		((Control)tabPage6).Size = size;
		TabPage2.TabIndex = 1;
		TabPage2.Text = "Désignations";
		((Control)Panel6).BackColor = Color.White;
		((Control)Panel6).Controls.Add((Control)(object)Button_MOINS);
		((Control)Panel6).Controls.Add((Control)(object)Button_PLUS);
		((Control)Panel6).Controls.Add((Control)(object)Text_QTE);
		((Control)Panel6).Controls.Add((Control)(object)Text_ID_ARTICLE);
		((Control)Panel6).Controls.Add((Control)(object)Label5);
		((Control)Panel6).Controls.Add((Control)(object)Label43);
		((Control)Panel6).Controls.Add((Control)(object)Text_PRIX_A);
		((Control)Panel6).Controls.Add((Control)(object)Label42);
		((Control)Panel6).Controls.Add((Control)(object)Text_UNITE);
		((Control)Panel6).Controls.Add((Control)(object)Text_CODE);
		((Control)Panel6).Controls.Add((Control)(object)Label34);
		((Control)Panel6).Controls.Add((Control)(object)Label35);
		((Control)Panel6).Controls.Add((Control)(object)Text_ARTICLE);
		((Control)Panel6).Controls.Add((Control)(object)Label36);
		((Control)Panel6).Controls.Add((Control)(object)Label37);
		((Control)Panel6).Controls.Add((Control)(object)Label38);
		((Control)Panel6).Controls.Add((Control)(object)Label39);
		((Control)Panel6).Controls.Add((Control)(object)Button1);
		((Control)Panel6).Controls.Add((Control)(object)Label40);
		((Control)Panel6).Controls.Add((Control)(object)Text_STOCK_ACTUEL);
		((Control)Panel6).Controls.Add((Control)(object)Label41);
		Panel panel7 = Panel6;
		location = new Point(442, 5);
		((Control)panel7).Location = location;
		((Control)Panel6).Name = "Panel6";
		Panel panel8 = Panel6;
		size = new Size(417, 228);
		((Control)panel8).Size = size;
		((Control)Panel6).TabIndex = 1013;
		((Control)Button_MOINS).Cursor = Cursors.Hand;
		((ButtonBase)Button_MOINS).FlatStyle = (FlatStyle)0;
		((Control)Button_MOINS).Font = new Font("Tahoma", 15.75f, (FontStyle)1);
		((ButtonBase)Button_MOINS).Image = (Image)componentResourceManager.GetObject("Button_MOINS.Image");
		((ButtonBase)Button_MOINS).ImeMode = (ImeMode)0;
		Button button_MOINS = Button_MOINS;
		location = new Point(98, 130);
		((Control)button_MOINS).Location = location;
		((Control)Button_MOINS).Name = "Button_MOINS";
		Button button_MOINS2 = Button_MOINS;
		size = new Size(51, 40);
		((Control)button_MOINS2).Size = size;
		((Control)Button_MOINS).TabIndex = 1070;
		((ButtonBase)Button_MOINS).UseVisualStyleBackColor = true;
		((Control)Button_PLUS).Cursor = Cursors.Hand;
		((ButtonBase)Button_PLUS).FlatStyle = (FlatStyle)0;
		((Control)Button_PLUS).Font = new Font("Tahoma", 15.75f, (FontStyle)1);
		((ButtonBase)Button_PLUS).Image = (Image)componentResourceManager.GetObject("Button_PLUS.Image");
		((ButtonBase)Button_PLUS).ImeMode = (ImeMode)0;
		Button button_PLUS = Button_PLUS;
		location = new Point(359, 130);
		((Control)button_PLUS).Location = location;
		((Control)Button_PLUS).Name = "Button_PLUS";
		Button button_PLUS2 = Button_PLUS;
		size = new Size(51, 40);
		((Control)button_PLUS2).Size = size;
		((Control)Button_PLUS).TabIndex = 1069;
		((ButtonBase)Button_PLUS).UseVisualStyleBackColor = true;
		((Control)Text_QTE).Font = new Font("Tahoma", 20.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		TextBox text_QTE = Text_QTE;
		location = new Point(98, 130);
		((Control)text_QTE).Location = location;
		((Control)Text_QTE).Name = "Text_QTE";
		TextBox text_QTE2 = Text_QTE;
		size = new Size(312, 40);
		((Control)text_QTE2).Size = size;
		((Control)Text_QTE).TabIndex = 1039;
		Text_QTE.TextAlign = (HorizontalAlignment)2;
		((TextBoxBase)Text_ID_ARTICLE).BackColor = Color.FromArgb(250, 250, 250);
		((Control)Text_ID_ARTICLE).Enabled = false;
		((Control)Text_ID_ARTICLE).Font = new Font("Cambria", 9.75f);
		TextBox text_ID_ARTICLE = Text_ID_ARTICLE;
		location = new Point(295, 10);
		((Control)text_ID_ARTICLE).Location = location;
		((Control)Text_ID_ARTICLE).Name = "Text_ID_ARTICLE";
		TextBox text_ID_ARTICLE2 = Text_ID_ARTICLE;
		size = new Size(115, 23);
		((Control)text_ID_ARTICLE2).Size = size;
		((Control)Text_ID_ARTICLE).TabIndex = 1018;
		((Control)Label5).BackColor = SystemColors.Control;
		((Control)Label5).Font = new Font("Segoe UI", 9f, (FontStyle)1);
		((Control)Label5).ForeColor = Color.Black;
		Label label31 = Label5;
		location = new Point(228, 10);
		((Control)label31).Location = location;
		((Control)Label5).Name = "Label5";
		Label label32 = Label5;
		size = new Size(62, 23);
		((Control)label32).Size = size;
		((Control)Label5).TabIndex = 1017;
		Label5.Text = "ID Article";
		Label5.TextAlign = (ContentAlignment)16;
		((Control)Label43).BackColor = SystemColors.Control;
		((Control)Label43).Font = new Font("Segoe UI", 10f, (FontStyle)1);
		((Control)Label43).ForeColor = Color.Black;
		Label label33 = Label43;
		location = new Point(6, 97);
		((Control)label33).Location = location;
		((Control)Label43).Name = "Label43";
		Label label34 = Label43;
		size = new Size(87, 23);
		((Control)label34).Size = size;
		((Control)Label43).TabIndex = 1016;
		Label43.Text = "Prix A";
		Label43.TextAlign = (ContentAlignment)16;
		((TextBoxBase)Text_PRIX_A).BackColor = Color.FromArgb(250, 250, 250);
		((Control)Text_PRIX_A).Enabled = false;
		((Control)Text_PRIX_A).Font = new Font("Cambria", 9.75f);
		TextBox text_PRIX_A = Text_PRIX_A;
		location = new Point(98, 97);
		((Control)text_PRIX_A).Location = location;
		((Control)Text_PRIX_A).Name = "Text_PRIX_A";
		TextBox text_PRIX_A2 = Text_PRIX_A;
		size = new Size(124, 23);
		((Control)text_PRIX_A2).Size = size;
		((Control)Text_PRIX_A).TabIndex = 1015;
		((Control)Label42).BackColor = SystemColors.Control;
		((Control)Label42).Font = new Font("Segoe UI", 10f, (FontStyle)1);
		((Control)Label42).ForeColor = Color.Black;
		Label label35 = Label42;
		location = new Point(228, 68);
		((Control)label35).Location = location;
		((Control)Label42).Name = "Label42";
		Label label36 = Label42;
		size = new Size(61, 23);
		((Control)label36).Size = size;
		((Control)Label42).TabIndex = 1013;
		Label42.Text = "Unité";
		Label42.TextAlign = (ContentAlignment)16;
		((TextBoxBase)Text_UNITE).BackColor = Color.FromArgb(250, 250, 250);
		((Control)Text_UNITE).Enabled = false;
		((Control)Text_UNITE).Font = new Font("Cambria", 9.75f);
		TextBox text_UNITE = Text_UNITE;
		location = new Point(295, 68);
		((Control)text_UNITE).Location = location;
		((Control)Text_UNITE).Name = "Text_UNITE";
		TextBox text_UNITE2 = Text_UNITE;
		size = new Size(115, 23);
		((Control)text_UNITE2).Size = size;
		((Control)Text_UNITE).TabIndex = 1012;
		((TextBoxBase)Text_CODE).BackColor = Color.FromArgb(250, 250, 250);
		((Control)Text_CODE).Enabled = false;
		((Control)Text_CODE).Font = new Font("Cambria", 9.75f);
		TextBox text_CODE = Text_CODE;
		location = new Point(98, 10);
		((Control)text_CODE).Location = location;
		((Control)Text_CODE).Name = "Text_CODE";
		TextBox text_CODE2 = Text_CODE;
		size = new Size(124, 23);
		((Control)text_CODE2).Size = size;
		((Control)Text_CODE).TabIndex = 1011;
		((Control)Label34).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label34).Cursor = Cursors.Hand;
		((Control)Label34).Dock = (DockStyle)2;
		((Control)Label34).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label34).ForeColor = Color.White;
		Label label37 = Label34;
		location = new Point(1, 227);
		((Control)label37).Location = location;
		((Control)Label34).Name = "Label34";
		Label label38 = Label34;
		size = new Size(415, 1);
		((Control)label38).Size = size;
		((Control)Label34).TabIndex = 1000;
		Label34.TextAlign = (ContentAlignment)16;
		((Control)Label35).BackColor = SystemColors.Control;
		((Control)Label35).Font = new Font("Segoe UI", 10f, (FontStyle)1);
		((Control)Label35).ForeColor = Color.Black;
		Label label39 = Label35;
		location = new Point(6, 10);
		((Control)label39).Location = location;
		((Control)Label35).Name = "Label35";
		Label label40 = Label35;
		size = new Size(87, 23);
		((Control)label40).Size = size;
		((Control)Label35).TabIndex = 1010;
		Label35.Text = "Code";
		Label35.TextAlign = (ContentAlignment)16;
		((TextBoxBase)Text_ARTICLE).BackColor = Color.FromArgb(250, 250, 250);
		((Control)Text_ARTICLE).Enabled = false;
		((Control)Text_ARTICLE).Font = new Font("Cambria", 9.75f);
		TextBox text_ARTICLE = Text_ARTICLE;
		location = new Point(98, 39);
		((Control)text_ARTICLE).Location = location;
		((Control)Text_ARTICLE).Name = "Text_ARTICLE";
		TextBox text_ARTICLE2 = Text_ARTICLE;
		size = new Size(312, 23);
		((Control)text_ARTICLE2).Size = size;
		((Control)Text_ARTICLE).TabIndex = 1009;
		((Control)Label36).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label36).Cursor = Cursors.Hand;
		((Control)Label36).Dock = (DockStyle)3;
		((Control)Label36).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label36).ForeColor = Color.White;
		Label label41 = Label36;
		location = new Point(0, 1);
		((Control)label41).Location = location;
		((Control)Label36).Name = "Label36";
		Label label42 = Label36;
		size = new Size(1, 227);
		((Control)label42).Size = size;
		((Control)Label36).TabIndex = 994;
		Label36.TextAlign = (ContentAlignment)16;
		((Control)Label37).BackColor = SystemColors.Control;
		((Control)Label37).Font = new Font("Segoe UI", 10f, (FontStyle)1);
		((Control)Label37).ForeColor = Color.Black;
		Label label43 = Label37;
		location = new Point(6, 39);
		((Control)label43).Location = location;
		((Control)Label37).Name = "Label37";
		Label label44 = Label37;
		size = new Size(87, 23);
		((Control)label44).Size = size;
		((Control)Label37).TabIndex = 1008;
		Label37.Text = "Article";
		Label37.TextAlign = (ContentAlignment)16;
		((Control)Label38).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label38).Cursor = Cursors.Hand;
		((Control)Label38).Dock = (DockStyle)4;
		((Control)Label38).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label38).ForeColor = Color.White;
		Label label45 = Label38;
		location = new Point(416, 1);
		((Control)label45).Location = location;
		((Control)Label38).Name = "Label38";
		Label label46 = Label38;
		size = new Size(1, 227);
		((Control)label46).Size = size;
		((Control)Label38).TabIndex = 993;
		Label38.TextAlign = (ContentAlignment)16;
		((Control)Label39).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label39).Cursor = Cursors.Hand;
		((Control)Label39).Dock = (DockStyle)1;
		((Control)Label39).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label39).ForeColor = Color.White;
		Label label47 = Label39;
		location = new Point(0, 0);
		((Control)label47).Location = location;
		((Control)Label39).Name = "Label39";
		Label label48 = Label39;
		size = new Size(417, 1);
		((Control)label48).Size = size;
		((Control)Label39).TabIndex = 992;
		Label39.Text = "-";
		Label39.TextAlign = (ContentAlignment)16;
		((ButtonBase)Button1).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Button1).BackgroundImageLayout = (ImageLayout)4;
		((Control)Button1).Font = new Font("Tahoma", 11.25f, (FontStyle)1);
		((Control)Button1).ForeColor = Color.White;
		((ButtonBase)Button1).Image = (Image)componentResourceManager.GetObject("Button1.Image");
		((ButtonBase)Button1).ImageAlign = (ContentAlignment)16;
		Button button7 = Button1;
		location = new Point(98, 175);
		((Control)button7).Location = location;
		((Control)Button1).Name = "Button1";
		Button button8 = Button1;
		size = new Size(312, 39);
		((Control)button8).Size = size;
		((Control)Button1).TabIndex = 729;
		((ButtonBase)Button1).Text = "Insérer";
		((ButtonBase)Button1).UseVisualStyleBackColor = false;
		((Control)Label40).BackColor = SystemColors.Control;
		((Control)Label40).Font = new Font("Segoe UI", 10f, (FontStyle)1);
		((Control)Label40).ForeColor = Color.Black;
		Label label49 = Label40;
		location = new Point(6, 68);
		((Control)label49).Location = location;
		((Control)Label40).Name = "Label40";
		Label label50 = Label40;
		size = new Size(87, 23);
		((Control)label50).Size = size;
		((Control)Label40).TabIndex = 727;
		Label40.Text = "Stock Actuel";
		Label40.TextAlign = (ContentAlignment)16;
		((TextBoxBase)Text_STOCK_ACTUEL).BackColor = Color.FromArgb(250, 250, 250);
		((Control)Text_STOCK_ACTUEL).Enabled = false;
		((Control)Text_STOCK_ACTUEL).Font = new Font("Cambria", 9.75f);
		TextBox text_STOCK_ACTUEL = Text_STOCK_ACTUEL;
		location = new Point(98, 68);
		((Control)text_STOCK_ACTUEL).Location = location;
		((Control)Text_STOCK_ACTUEL).Name = "Text_STOCK_ACTUEL";
		TextBox text_STOCK_ACTUEL2 = Text_STOCK_ACTUEL;
		size = new Size(124, 23);
		((Control)text_STOCK_ACTUEL2).Size = size;
		((Control)Text_STOCK_ACTUEL).TabIndex = 728;
		((Control)Label41).BackColor = SystemColors.Control;
		((Control)Label41).Font = new Font("Segoe UI", 10f, (FontStyle)1);
		((Control)Label41).ForeColor = Color.Black;
		Label label51 = Label41;
		location = new Point(6, 130);
		((Control)label51).Location = location;
		((Control)Label41).Name = "Label41";
		Label label52 = Label41;
		size = new Size(87, 39);
		((Control)label52).Size = size;
		((Control)Label41).TabIndex = 378;
		Label41.Text = "QUANTITE";
		Label41.TextAlign = (ContentAlignment)16;
		((Control)Panel1).BackColor = Color.White;
		((Control)Panel1).Controls.Add((Control)(object)DataGridView_FAMILLES);
		((Control)Panel1).Controls.Add((Control)(object)Button4);
		((Control)Panel1).Controls.Add((Control)(object)Text_ARTICLE_FIND);
		((Control)Panel1).Controls.Add((Control)(object)DataGridView_ARTICLES);
		((Control)Panel1).Controls.Add((Control)(object)Label24);
		((Control)Panel1).Controls.Add((Control)(object)Label11);
		((Control)Panel1).Controls.Add((Control)(object)Button_FIND);
		((Control)Panel1).Controls.Add((Control)(object)Label14);
		((Control)Panel1).Controls.Add((Control)(object)Label17);
		((Control)Panel1).Controls.Add((Control)(object)Label18);
		((Control)Panel1).Controls.Add((Control)(object)Text_CODE_FIND);
		Panel panel9 = Panel1;
		location = new Point(9, 5);
		((Control)panel9).Location = location;
		((Control)Panel1).Name = "Panel1";
		Panel panel10 = Panel1;
		size = new Size(417, 228);
		((Control)panel10).Size = size;
		((Control)Panel1).TabIndex = 993;
		DataGridView_FAMILLES.AllowUserToAddRows = false;
		DataGridView_FAMILLES.AllowUserToResizeRows = false;
		DataGridView_FAMILLES.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)16;
		DataGridView_FAMILLES.BackgroundColor = Color.White;
		DataGridView_FAMILLES.BorderStyle = (BorderStyle)2;
		DataGridView_FAMILLES.CellBorderStyle = (DataGridViewCellBorderStyle)5;
		DataGridView_FAMILLES.ColumnHeadersBorderStyle = (DataGridViewHeaderBorderStyle)1;
		DataGridView_FAMILLES.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		DataGridView_FAMILLES.Columns.AddRange(new DataGridViewColumn[1] { (DataGridViewColumn)DataGridViewTextBoxColumn4 });
		((Control)DataGridView_FAMILLES).Cursor = Cursors.Default;
		DataGridView_FAMILLES.EditMode = (DataGridViewEditMode)4;
		DataGridView_FAMILLES.EnableHeadersVisualStyles = false;
		DataGridView dataGridView_FAMILLES = DataGridView_FAMILLES;
		location = new Point(11, 66);
		((Control)dataGridView_FAMILLES).Location = location;
		((Control)DataGridView_FAMILLES).Name = "DataGridView_FAMILLES";
		DataGridView_FAMILLES.RowHeadersVisible = false;
		DataGridView_FAMILLES.RowHeadersWidth = 25;
		DataGridView_FAMILLES.SelectionMode = (DataGridViewSelectionMode)1;
		DataGridView dataGridView_FAMILLES2 = DataGridView_FAMILLES;
		size = new Size(136, 156);
		((Control)dataGridView_FAMILLES2).Size = size;
		((Control)DataGridView_FAMILLES).TabIndex = 1014;
		((DataGridViewColumn)DataGridViewTextBoxColumn4).FillWeight = 91.08049f;
		((DataGridViewColumn)DataGridViewTextBoxColumn4).HeaderText = "Famille";
		((DataGridViewColumn)DataGridViewTextBoxColumn4).Name = "DataGridViewTextBoxColumn4";
		((ButtonBase)Button4).BackColor = Color.White;
		((Control)Button4).BackgroundImage = (Image)componentResourceManager.GetObject("Button4.BackgroundImage");
		((Control)Button4).BackgroundImageLayout = (ImageLayout)2;
		((Control)Button4).Cursor = Cursors.Hand;
		((ButtonBase)Button4).FlatAppearance.BorderSize = 0;
		((ButtonBase)Button4).FlatStyle = (FlatStyle)0;
		Button button9 = Button4;
		location = new Point(378, 44);
		((Control)button9).Location = location;
		((Control)Button4).Name = "Button4";
		Button button10 = Button4;
		size = new Size(28, 20);
		((Control)button10).Size = size;
		((Control)Button4).TabIndex = 1013;
		((ButtonBase)Button4).UseVisualStyleBackColor = false;
		((Control)Text_ARTICLE_FIND).Font = new Font("Cambria", 9.75f);
		TextBox text_ARTICLE_FIND = Text_ARTICLE_FIND;
		location = new Point(151, 42);
		((Control)text_ARTICLE_FIND).Location = location;
		((Control)Text_ARTICLE_FIND).Name = "Text_ARTICLE_FIND";
		TextBox text_ARTICLE_FIND2 = Text_ARTICLE_FIND;
		size = new Size(257, 23);
		((Control)text_ARTICLE_FIND2).Size = size;
		((Control)Text_ARTICLE_FIND).TabIndex = 1012;
		DataGridView_ARTICLES.AllowUserToAddRows = false;
		DataGridView_ARTICLES.AllowUserToResizeRows = false;
		DataGridView_ARTICLES.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)16;
		DataGridView_ARTICLES.BackgroundColor = Color.White;
		DataGridView_ARTICLES.BorderStyle = (BorderStyle)2;
		DataGridView_ARTICLES.CellBorderStyle = (DataGridViewCellBorderStyle)5;
		DataGridView_ARTICLES.ColumnHeadersBorderStyle = (DataGridViewHeaderBorderStyle)1;
		DataGridView_ARTICLES.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		DataGridView_ARTICLES.Columns.AddRange(new DataGridViewColumn[3]
		{
			(DataGridViewColumn)Column1,
			(DataGridViewColumn)DataGridViewTextBoxColumn1,
			(DataGridViewColumn)DataGridViewTextBoxColumn2
		});
		((Control)DataGridView_ARTICLES).Cursor = Cursors.Default;
		DataGridView_ARTICLES.EditMode = (DataGridViewEditMode)4;
		DataGridView_ARTICLES.EnableHeadersVisualStyles = false;
		DataGridView dataGridView_ARTICLES = DataGridView_ARTICLES;
		location = new Point(151, 65);
		((Control)dataGridView_ARTICLES).Location = location;
		((Control)DataGridView_ARTICLES).Name = "DataGridView_ARTICLES";
		DataGridView_ARTICLES.RowHeadersVisible = false;
		DataGridView_ARTICLES.RowHeadersWidth = 25;
		DataGridView_ARTICLES.SelectionMode = (DataGridViewSelectionMode)1;
		DataGridView dataGridView_ARTICLES2 = DataGridView_ARTICLES;
		size = new Size(259, 156);
		((Control)dataGridView_ARTICLES2).Size = size;
		((Control)DataGridView_ARTICLES).TabIndex = 1011;
		((DataGridViewColumn)Column1).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)Column1).DataPropertyName = "ID_ARTICLE";
		((DataGridViewColumn)Column1).HeaderText = "ID_ARTICLE";
		((DataGridViewColumn)Column1).MinimumWidth = 2;
		((DataGridViewColumn)Column1).Name = "Column1";
		((DataGridViewColumn)Column1).Width = 2;
		((DataGridViewColumn)DataGridViewTextBoxColumn1).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)DataGridViewTextBoxColumn1).DataPropertyName = "Code";
		((DataGridViewColumn)DataGridViewTextBoxColumn1).FillWeight = 91.08049f;
		((DataGridViewColumn)DataGridViewTextBoxColumn1).HeaderText = "Code";
		((DataGridViewColumn)DataGridViewTextBoxColumn1).Name = "DataGridViewTextBoxColumn1";
		((DataGridViewColumn)DataGridViewTextBoxColumn1).Width = 70;
		((DataGridViewColumn)DataGridViewTextBoxColumn2).DataPropertyName = "Article";
		((DataGridViewColumn)DataGridViewTextBoxColumn2).FillWeight = 91.08049f;
		((DataGridViewColumn)DataGridViewTextBoxColumn2).HeaderText = "Article";
		((DataGridViewColumn)DataGridViewTextBoxColumn2).Name = "DataGridViewTextBoxColumn2";
		((Control)Label24).BackColor = SystemColors.Control;
		((Control)Label24).Font = new Font("Segoe UI", 10f, (FontStyle)1);
		((Control)Label24).ForeColor = Color.Black;
		Label label53 = Label24;
		location = new Point(11, 10);
		((Control)label53).Location = location;
		((Control)Label24).Name = "Label24";
		Label label54 = Label24;
		size = new Size(134, 23);
		((Control)label54).Size = size;
		((Control)Label24).TabIndex = 404;
		Label24.Text = "CODE";
		Label24.TextAlign = (ContentAlignment)16;
		((Control)Label11).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label11).Cursor = Cursors.Hand;
		((Control)Label11).Dock = (DockStyle)2;
		((Control)Label11).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label11).ForeColor = Color.White;
		Label label55 = Label11;
		location = new Point(1, 227);
		((Control)label55).Location = location;
		((Control)Label11).Name = "Label11";
		Label label56 = Label11;
		size = new Size(415, 1);
		((Control)label56).Size = size;
		((Control)Label11).TabIndex = 1000;
		Label11.TextAlign = (ContentAlignment)16;
		((ButtonBase)Button_FIND).BackColor = Color.White;
		((Control)Button_FIND).BackgroundImage = (Image)componentResourceManager.GetObject("Button_FIND.BackgroundImage");
		((Control)Button_FIND).BackgroundImageLayout = (ImageLayout)2;
		((Control)Button_FIND).Cursor = Cursors.Hand;
		((ButtonBase)Button_FIND).FlatAppearance.BorderSize = 0;
		((ButtonBase)Button_FIND).FlatStyle = (FlatStyle)0;
		Button button_FIND = Button_FIND;
		location = new Point(378, 11);
		((Control)button_FIND).Location = location;
		((Control)Button_FIND).Name = "Button_FIND";
		Button button_FIND2 = Button_FIND;
		size = new Size(28, 20);
		((Control)button_FIND2).Size = size;
		((Control)Button_FIND).TabIndex = 726;
		((ButtonBase)Button_FIND).UseVisualStyleBackColor = false;
		((Control)Label14).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label14).Cursor = Cursors.Hand;
		((Control)Label14).Dock = (DockStyle)3;
		((Control)Label14).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label14).ForeColor = Color.White;
		Label label57 = Label14;
		location = new Point(0, 1);
		((Control)label57).Location = location;
		((Control)Label14).Name = "Label14";
		Label label58 = Label14;
		size = new Size(1, 227);
		((Control)label58).Size = size;
		((Control)Label14).TabIndex = 994;
		Label14.TextAlign = (ContentAlignment)16;
		((Control)Label17).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label17).Cursor = Cursors.Hand;
		((Control)Label17).Dock = (DockStyle)4;
		((Control)Label17).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label17).ForeColor = Color.White;
		Label label59 = Label17;
		location = new Point(416, 1);
		((Control)label59).Location = location;
		((Control)Label17).Name = "Label17";
		Label label60 = Label17;
		size = new Size(1, 227);
		((Control)label60).Size = size;
		((Control)Label17).TabIndex = 993;
		Label17.TextAlign = (ContentAlignment)16;
		((Control)Label18).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label18).Cursor = Cursors.Hand;
		((Control)Label18).Dock = (DockStyle)1;
		((Control)Label18).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label18).ForeColor = Color.White;
		Label label61 = Label18;
		location = new Point(0, 0);
		((Control)label61).Location = location;
		((Control)Label18).Name = "Label18";
		Label label62 = Label18;
		size = new Size(417, 1);
		((Control)label62).Size = size;
		((Control)Label18).TabIndex = 992;
		Label18.Text = "-";
		Label18.TextAlign = (ContentAlignment)16;
		((Control)Text_CODE_FIND).Font = new Font("Cambria", 9.75f);
		TextBox text_CODE_FIND = Text_CODE_FIND;
		location = new Point(151, 10);
		((Control)text_CODE_FIND).Location = location;
		((Control)Text_CODE_FIND).Name = "Text_CODE_FIND";
		TextBox text_CODE_FIND2 = Text_CODE_FIND;
		size = new Size(257, 23);
		((Control)text_CODE_FIND2).Size = size;
		((Control)Text_CODE_FIND).TabIndex = 0;
		DataGrid_BODY.AllowUserToAddRows = false;
		DataGrid_BODY.AllowUserToResizeRows = false;
		DataGrid_BODY.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)16;
		DataGrid_BODY.BackgroundColor = Color.White;
		DataGrid_BODY.BorderStyle = (BorderStyle)2;
		DataGrid_BODY.CellBorderStyle = (DataGridViewCellBorderStyle)5;
		DataGrid_BODY.ColumnHeadersBorderStyle = (DataGridViewHeaderBorderStyle)1;
		DataGrid_BODY.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		DataGrid_BODY.Columns.AddRange(new DataGridViewColumn[9]
		{
			(DataGridViewColumn)ID_ARTICLE,
			(DataGridViewColumn)Code,
			(DataGridViewColumn)Article,
			(DataGridViewColumn)Prix_A,
			(DataGridViewColumn)Stock_Logique,
			(DataGridViewColumn)Stock_Physique,
			(DataGridViewColumn)Ecart,
			(DataGridViewColumn)Valeur,
			(DataGridViewColumn)sup
		});
		DataGrid_BODY.EditMode = (DataGridViewEditMode)4;
		DataGridView dataGrid_BODY = DataGrid_BODY;
		location = new Point(10, 328);
		((Control)dataGrid_BODY).Location = location;
		((Control)DataGrid_BODY).Name = "DataGrid_BODY";
		DataGrid_BODY.RowHeadersVisible = false;
		DataGrid_BODY.RowHeadersWidth = 50;
		DataGrid_BODY.SelectionMode = (DataGridViewSelectionMode)1;
		DataGridView dataGrid_BODY2 = DataGrid_BODY;
		size = new Size(877, 148);
		((Control)dataGrid_BODY2).Size = size;
		((Control)DataGrid_BODY).TabIndex = 645;
		((DataGridViewColumn)ID_ARTICLE).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)ID_ARTICLE).HeaderText = "ID_ARTICLE";
		((DataGridViewColumn)ID_ARTICLE).Name = "ID_ARTICLE";
		((DataGridViewColumn)Code).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)Code).FillWeight = 91.08049f;
		((DataGridViewColumn)Code).HeaderText = "Code";
		((DataGridViewColumn)Code).Name = "Code";
		((DataGridViewColumn)Code).Width = 90;
		((DataGridViewColumn)Article).FillWeight = 91.08049f;
		((DataGridViewColumn)Article).HeaderText = "Article";
		((DataGridViewColumn)Article).Name = "Article";
		((DataGridViewColumn)Prix_A).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)Prix_A).HeaderText = "Prix_A";
		((DataGridViewColumn)Prix_A).Name = "Prix_A";
		((DataGridViewColumn)Prix_A).Width = 70;
		((DataGridViewColumn)Stock_Logique).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		val.Alignment = (DataGridViewContentAlignment)32;
		val.Format = "N2";
		((DataGridViewColumn)Stock_Logique).DefaultCellStyle = val;
		((DataGridViewColumn)Stock_Logique).HeaderText = "Stock_Logique";
		((DataGridViewColumn)Stock_Logique).Name = "Stock_Logique";
		((DataGridViewColumn)Stock_Physique).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		val2.Alignment = (DataGridViewContentAlignment)32;
		val2.Font = new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((DataGridViewColumn)Stock_Physique).DefaultCellStyle = val2;
		((DataGridViewColumn)Stock_Physique).HeaderText = "Stock_Physique";
		((DataGridViewColumn)Stock_Physique).Name = "Stock_Physique";
		((DataGridViewColumn)Ecart).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		val3.Alignment = (DataGridViewContentAlignment)32;
		((DataGridViewColumn)Ecart).DefaultCellStyle = val3;
		((DataGridViewColumn)Ecart).HeaderText = "Ecart";
		((DataGridViewColumn)Ecart).Name = "Ecart";
		((DataGridViewColumn)Ecart).Width = 70;
		((DataGridViewColumn)Valeur).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)Valeur).HeaderText = "Valeur";
		((DataGridViewColumn)Valeur).Name = "Valeur";
		((DataGridViewColumn)Valeur).Width = 70;
		((DataGridViewColumn)sup).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)sup).HeaderText = "";
		sup.Image = (Image)(object)Resources.Picture_SUPP_Image;
		((DataGridViewColumn)sup).Name = "sup";
		((DataGridViewColumn)sup).Resizable = (DataGridViewTriState)1;
		((DataGridViewColumn)sup).Width = 40;
		DataGridView1.AllowUserToAddRows = false;
		val4.BackColor = Color.FromArgb(255, 128, 128);
		DataGridView1.AlternatingRowsDefaultCellStyle = val4;
		((Control)DataGridView1).Anchor = (AnchorStyles)15;
		DataGridView1.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)16;
		DataGridView1.BackgroundColor = Color.White;
		DataGridView1.CellBorderStyle = (DataGridViewCellBorderStyle)8;
		val5.Alignment = (DataGridViewContentAlignment)16;
		val5.BackColor = SystemColors.Control;
		val5.Font = new Font("Calibri", 11.25f, (FontStyle)1);
		val5.ForeColor = SystemColors.WindowText;
		val5.SelectionBackColor = SystemColors.Highlight;
		val5.SelectionForeColor = SystemColors.HighlightText;
		val5.WrapMode = (DataGridViewTriState)1;
		DataGridView1.ColumnHeadersDefaultCellStyle = val5;
		DataGridView1.ColumnHeadersHeight = 24;
		DataGridView1.Columns.AddRange(new DataGridViewColumn[8]
		{
			(DataGridViewColumn)Dates,
			(DataGridViewColumn)ID_INV,
			(DataGridViewColumn)NOTES,
			(DataGridViewColumn)TOTAL_VALEUR,
			(DataGridViewColumn)ETAT,
			(DataGridViewColumn)supp,
			(DataGridViewColumn)modi,
			(DataGridViewColumn)cons
		});
		DataGridView1.EditMode = (DataGridViewEditMode)4;
		DataGridView dataGridView = DataGridView1;
		location = new Point(0, 42);
		((Control)dataGridView).Location = location;
		((Control)DataGridView1).Name = "DataGridView1";
		DataGridView1.RowHeadersVisible = false;
		DataGridView1.RowHeadersWidth = 25;
		DataGridView dataGridView2 = DataGridView1;
		size = new Size(1025, 566);
		((Control)dataGridView2).Size = size;
		((Control)DataGridView1).TabIndex = 0;
		((Control)Panel_INV_MASSE).BackColor = Color.White;
		Panel_INV_MASSE.BorderStyle = (BorderStyle)1;
		((Control)Panel_INV_MASSE).Controls.Add((Control)(object)Label23);
		((Control)Panel_INV_MASSE).Controls.Add((Control)(object)Label26);
		((Control)Panel_INV_MASSE).Controls.Add((Control)(object)PictureBox5);
		((Control)Panel_INV_MASSE).Controls.Add((Control)(object)ListBox1);
		((Control)Panel_INV_MASSE).Controls.Add((Control)(object)Button5);
		((Control)Panel_INV_MASSE).Controls.Add((Control)(object)Button_FERMER);
		((Control)Panel_INV_MASSE).Controls.Add((Control)(object)Label9);
		((Control)Panel_INV_MASSE).Controls.Add((Control)(object)Label8);
		((Control)Panel_INV_MASSE).Controls.Add((Control)(object)Label16);
		((Control)Panel_INV_MASSE).Controls.Add((Control)(object)Label22);
		Panel panel_INV_MASSE = Panel_INV_MASSE;
		location = new Point(277, 100);
		((Control)panel_INV_MASSE).Location = location;
		((Control)Panel_INV_MASSE).Name = "Panel_INV_MASSE";
		Panel panel_INV_MASSE2 = Panel_INV_MASSE;
		size = new Size(470, 429);
		((Control)panel_INV_MASSE2).Size = size;
		((Control)Panel_INV_MASSE).TabIndex = 1053;
		((Control)Panel_INV_MASSE).Visible = false;
		((Control)Label23).BackColor = Color.White;
		((Control)Label23).Font = new Font("Tahoma", 10.75f, (FontStyle)1);
		((Control)Label23).ForeColor = Color.FromArgb(232, 72, 73);
		Label label63 = Label23;
		location = new Point(242, 101);
		((Control)label63).Location = location;
		((Control)Label23).Name = "Label23";
		Label label64 = Label23;
		size = new Size(206, 102);
		((Control)label64).Size = size;
		((Control)Label23).TabIndex = 1002;
		Label23.Text = "Si vous choisissez le boutton «\u00a0remise à zéro\u00a0» tout le stock de cette Famille sera réinitialiser à zéro";
		Label26.AutoSize = true;
		((Control)Label26).BackColor = Color.White;
		((Control)Label26).Font = new Font("Tahoma", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label26).ForeColor = Color.FromArgb(232, 72, 73);
		Label label65 = Label26;
		location = new Point(312, 38);
		((Control)label65).Location = location;
		((Control)Label26).Name = "Label26";
		Label label66 = Label26;
		size = new Size(110, 25);
		((Control)label66).Size = size;
		((Control)Label26).TabIndex = 1001;
		Label26.Text = "Attention";
		((Control)PictureBox5).BackColor = Color.White;
		PictureBox5.Image = (Image)componentResourceManager.GetObject("PictureBox5.Image");
		PictureBox pictureBox3 = PictureBox5;
		location = new Point(279, 35);
		((Control)pictureBox3).Location = location;
		((Control)PictureBox5).Name = "PictureBox5";
		PictureBox pictureBox4 = PictureBox5;
		size = new Size(32, 32);
		((Control)pictureBox4).Size = size;
		PictureBox5.SizeMode = (PictureBoxSizeMode)2;
		PictureBox5.TabIndex = 1000;
		PictureBox5.TabStop = false;
		ListBox1.Font = new Font("Tahoma", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((ListControl)ListBox1).FormattingEnabled = true;
		ListBox1.ItemHeight = 14;
		ListBox listBox = ListBox1;
		location = new Point(10, 34);
		((Control)listBox).Location = location;
		((Control)ListBox1).Name = "ListBox1";
		ListBox listBox2 = ListBox1;
		size = new Size(229, 312);
		((Control)listBox2).Size = size;
		((Control)ListBox1).TabIndex = 999;
		((ButtonBase)Button5).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Button5).Cursor = Cursors.Hand;
		((ButtonBase)Button5).FlatStyle = (FlatStyle)0;
		((Control)Button5).Font = new Font("Tahoma", 11.25f, (FontStyle)1);
		((Control)Button5).ForeColor = Color.White;
		((ButtonBase)Button5).Image = (Image)componentResourceManager.GetObject("Button5.Image");
		((ButtonBase)Button5).ImageAlign = (ContentAlignment)16;
		Button button11 = Button5;
		location = new Point(247, 317);
		((Control)button11).Location = location;
		Button button12 = Button5;
		margin = new Padding(0);
		((Control)button12).Margin = margin;
		((Control)Button5).Name = "Button5";
		Button button13 = Button5;
		size = new Size(214, 30);
		((Control)button13).Size = size;
		((Control)Button5).TabIndex = 998;
		((ButtonBase)Button5).Text = "Remise à zéro";
		((ButtonBase)Button5).UseVisualStyleBackColor = false;
		((Control)Button_FERMER).Cursor = Cursors.Hand;
		((ButtonBase)Button_FERMER).FlatStyle = (FlatStyle)0;
		((Control)Button_FERMER).Font = new Font("Tahoma", 11.25f, (FontStyle)1);
		((Control)Button_FERMER).ForeColor = Color.Red;
		((ButtonBase)Button_FERMER).ImageAlign = (ContentAlignment)16;
		Button button_FERMER = Button_FERMER;
		location = new Point(345, 381);
		((Control)button_FERMER).Location = location;
		Button button_FERMER2 = Button_FERMER;
		margin = new Padding(0);
		((Control)button_FERMER2).Margin = margin;
		((Control)Button_FERMER).Name = "Button_FERMER";
		Button button_FERMER3 = Button_FERMER;
		size = new Size(116, 38);
		((Control)button_FERMER3).Size = size;
		((Control)Button_FERMER).TabIndex = 997;
		((ButtonBase)Button_FERMER).Text = "Fermer";
		((ButtonBase)Button_FERMER).UseVisualStyleBackColor = true;
		((Control)Label9).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label9).Cursor = Cursors.Hand;
		((Control)Label9).Dock = (DockStyle)2;
		((Control)Label9).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label9).ForeColor = Color.White;
		Label label67 = Label9;
		location = new Point(4, 423);
		((Control)label67).Location = location;
		((Control)Label9).Name = "Label9";
		Label label68 = Label9;
		size = new Size(460, 4);
		((Control)label68).Size = size;
		((Control)Label9).TabIndex = 856;
		Label9.TextAlign = (ContentAlignment)16;
		((Control)Label8).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label8).Cursor = Cursors.Hand;
		((Control)Label8).Dock = (DockStyle)3;
		((Control)Label8).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label8).ForeColor = Color.White;
		Label label69 = Label8;
		location = new Point(0, 24);
		((Control)label69).Location = location;
		((Control)Label8).Name = "Label8";
		Label label70 = Label8;
		size = new Size(4, 403);
		((Control)label70).Size = size;
		((Control)Label8).TabIndex = 855;
		Label8.TextAlign = (ContentAlignment)16;
		((Control)Label16).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label16).Cursor = Cursors.Hand;
		((Control)Label16).Dock = (DockStyle)4;
		((Control)Label16).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label16).ForeColor = Color.White;
		Label label71 = Label16;
		location = new Point(464, 24);
		((Control)label71).Location = location;
		((Control)Label16).Name = "Label16";
		Label label72 = Label16;
		size = new Size(4, 403);
		((Control)label72).Size = size;
		((Control)Label16).TabIndex = 854;
		Label16.TextAlign = (ContentAlignment)16;
		((Control)Label22).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label22).Cursor = Cursors.Hand;
		((Control)Label22).Dock = (DockStyle)1;
		((Control)Label22).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label22).ForeColor = Color.White;
		Label label73 = Label22;
		location = new Point(0, 0);
		((Control)label73).Location = location;
		((Control)Label22).Name = "Label22";
		Label label74 = Label22;
		size = new Size(468, 24);
		((Control)label74).Size = size;
		((Control)Label22).TabIndex = 144;
		Label22.TextAlign = (ContentAlignment)16;
		((Control)Button_VALIDER).Anchor = (AnchorStyles)10;
		((ButtonBase)Button_VALIDER).BackColor = Color.Transparent;
		((Control)Button_VALIDER).Cursor = Cursors.Hand;
		((Control)Button_VALIDER).Font = new Font("Segoe UI", 12f, (FontStyle)1);
		((Control)Button_VALIDER).ForeColor = SystemColors.ControlText;
		((ButtonBase)Button_VALIDER).Image = (Image)componentResourceManager.GetObject("Button_VALIDER.Image");
		((ButtonBase)Button_VALIDER).ImageAlign = (ContentAlignment)16;
		Button button_VALIDER = Button_VALIDER;
		location = new Point(695, 646);
		((Control)button_VALIDER).Location = location;
		Button button_VALIDER2 = Button_VALIDER;
		margin = new Padding(0);
		((Control)button_VALIDER2).Margin = margin;
		((Control)Button_VALIDER).Name = "Button_VALIDER";
		Button button_VALIDER3 = Button_VALIDER;
		size = new Size(156, 40);
		((Control)button_VALIDER3).Size = size;
		((Control)Button_VALIDER).TabIndex = 1062;
		((ButtonBase)Button_VALIDER).Text = "Valider";
		((ButtonBase)Button_VALIDER).UseVisualStyleBackColor = false;
		((Control)Button_CALC_BD).ForeColor = Color.Red;
		Button button_CALC_BD = Button_CALC_BD;
		location = new Point(74, 2);
		((Control)button_CALC_BD).Location = location;
		((Control)Button_CALC_BD).Name = "Button_CALC_BD";
		Button button_CALC_BD2 = Button_CALC_BD;
		size = new Size(48, 29);
		((Control)button_CALC_BD2).Size = size;
		((Control)Button_CALC_BD).TabIndex = 1063;
		((ButtonBase)Button_CALC_BD).Text = "CALC";
		((ButtonBase)Button_CALC_BD).UseVisualStyleBackColor = true;
		((Control)Button_CALC_BD).Visible = false;
		((Control)Panel243544).Anchor = (AnchorStyles)14;
		((Control)Panel243544).BackColor = Color.Transparent;
		((Control)Panel243544).Controls.Add((Control)(object)Label_TOTAL_NET_ACHATS_BD);
		((Control)Panel243544).Controls.Add((Control)(object)Label32);
		((Control)Panel243544).Controls.Add((Control)(object)Label_TOTAL_LIGNES_BD);
		((Control)Panel243544).Controls.Add((Control)(object)Label31);
		((Control)Panel243544).Controls.Add((Control)(object)Label27);
		((Control)Panel243544).Controls.Add((Control)(object)Button_CALC_BD);
		Panel panel11 = Panel243544;
		location = new Point(0, 609);
		((Control)panel11).Location = location;
		((Control)Panel243544).Name = "Panel243544";
		Panel panel12 = Panel243544;
		size = new Size(1025, 31);
		((Control)panel12).Size = size;
		((Control)Panel243544).TabIndex = 1065;
		((Control)Label_TOTAL_NET_ACHATS_BD).Anchor = (AnchorStyles)9;
		((Control)Label_TOTAL_NET_ACHATS_BD).BackColor = Color.White;
		((Control)Label_TOTAL_NET_ACHATS_BD).Font = new Font("Calibri", 13f, (FontStyle)1);
		((Control)Label_TOTAL_NET_ACHATS_BD).ForeColor = Color.FromArgb(22, 106, 238);
		Label label_TOTAL_NET_ACHATS_BD = Label_TOTAL_NET_ACHATS_BD;
		location = new Point(891, 1);
		((Control)label_TOTAL_NET_ACHATS_BD).Location = location;
		((Control)Label_TOTAL_NET_ACHATS_BD).Name = "Label_TOTAL_NET_ACHATS_BD";
		Label label_TOTAL_NET_ACHATS_BD2 = Label_TOTAL_NET_ACHATS_BD;
		size = new Size(132, 29);
		((Control)label_TOTAL_NET_ACHATS_BD2).Size = size;
		((Control)Label_TOTAL_NET_ACHATS_BD).TabIndex = 1077;
		Label_TOTAL_NET_ACHATS_BD.Text = "-";
		Label_TOTAL_NET_ACHATS_BD.TextAlign = (ContentAlignment)16;
		((Control)Label32).Anchor = (AnchorStyles)9;
		((Control)Label32).BackColor = Color.White;
		((Control)Label32).Font = new Font("Calibri", 13f, (FontStyle)1);
		((Control)Label32).ForeColor = Color.FromArgb(64, 64, 64);
		Label label75 = Label32;
		location = new Point(759, 1);
		((Control)label75).Location = location;
		((Control)Label32).Name = "Label32";
		Label label76 = Label32;
		size = new Size(132, 29);
		((Control)label76).Size = size;
		((Control)Label32).TabIndex = 1076;
		Label32.Text = "TOTAL VALEUR :";
		Label32.TextAlign = (ContentAlignment)16;
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
		((Control)Label_TOTAL_LIGNES_BD).TabIndex = 1072;
		Label_TOTAL_LIGNES_BD.Text = "-/-";
		Label_TOTAL_LIGNES_BD.TextAlign = (ContentAlignment)16;
		((Control)Label31).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label31).Cursor = Cursors.Hand;
		((Control)Label31).Dock = (DockStyle)2;
		((Control)Label31).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label31).ForeColor = Color.White;
		Label label77 = Label31;
		location = new Point(0, 30);
		((Control)label77).Location = location;
		((Control)Label31).Name = "Label31";
		Label label78 = Label31;
		size = new Size(1025, 1);
		((Control)label78).Size = size;
		((Control)Label31).TabIndex = 1067;
		Label31.TextAlign = (ContentAlignment)16;
		((Control)Label27).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label27).Cursor = Cursors.Hand;
		((Control)Label27).Dock = (DockStyle)1;
		((Control)Label27).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label27).ForeColor = Color.White;
		Label label79 = Label27;
		location = new Point(0, 0);
		((Control)label79).Location = location;
		((Control)Label27).Name = "Label27";
		Label label80 = Label27;
		size = new Size(1025, 1);
		((Control)label80).Size = size;
		((Control)Label27).TabIndex = 1066;
		Label27.TextAlign = (ContentAlignment)16;
		((Control)Panel7727).Anchor = (AnchorStyles)6;
		((Control)Panel7727).BackColor = Color.FromArgb(64, 64, 64);
		((Control)Panel7727).Controls.Add((Control)(object)Button_CALC_ENREGISTRER);
		((Control)Panel7727).Controls.Add((Control)(object)PictureBox3);
		((Control)Panel7727).Controls.Add((Control)(object)TextBox33398);
		Panel panel13 = Panel7727;
		location = new Point(0, 577);
		((Control)panel13).Location = location;
		((Control)Panel7727).Name = "Panel7727";
		Panel panel14 = Panel7727;
		size = new Size(360, 31);
		((Control)panel14).Size = size;
		((Control)Panel7727).TabIndex = 1066;
		((Control)Panel7727).Visible = false;
		((Control)Button_CALC_ENREGISTRER).ForeColor = Color.Red;
		Button button_CALC_ENREGISTRER = Button_CALC_ENREGISTRER;
		location = new Point(314, 2);
		((Control)button_CALC_ENREGISTRER).Location = location;
		((Control)Button_CALC_ENREGISTRER).Name = "Button_CALC_ENREGISTRER";
		Button button_CALC_ENREGISTRER2 = Button_CALC_ENREGISTRER;
		size = new Size(43, 24);
		((Control)button_CALC_ENREGISTRER2).Size = size;
		((Control)Button_CALC_ENREGISTRER).TabIndex = 992;
		((ButtonBase)Button_CALC_ENREGISTRER).Text = "CALC";
		((ButtonBase)Button_CALC_ENREGISTRER).UseVisualStyleBackColor = true;
		((Control)Button_CALC_ENREGISTRER).Visible = false;
		PictureBox3.Image = (Image)componentResourceManager.GetObject("PictureBox3.Image");
		PictureBox pictureBox5 = PictureBox3;
		location = new Point(6, 2);
		((Control)pictureBox5).Location = location;
		((Control)PictureBox3).Name = "PictureBox3";
		PictureBox pictureBox6 = PictureBox3;
		size = new Size(31, 26);
		((Control)pictureBox6).Size = size;
		PictureBox3.SizeMode = (PictureBoxSizeMode)4;
		PictureBox3.TabIndex = 992;
		PictureBox3.TabStop = false;
		((TextBoxBase)TextBox33398).BackColor = Color.FromArgb(64, 64, 64);
		((TextBoxBase)TextBox33398).BorderStyle = (BorderStyle)1;
		((Control)TextBox33398).Font = new Font("Cambria", 12f, (FontStyle)1);
		((TextBoxBase)TextBox33398).ForeColor = Color.White;
		TextBox textBox = TextBox33398;
		location = new Point(43, 2);
		((Control)textBox).Location = location;
		((Control)TextBox33398).Name = "TextBox33398";
		((TextBoxBase)TextBox33398).ReadOnly = true;
		TextBox textBox2 = TextBox33398;
		size = new Size(314, 26);
		((Control)textBox2).Size = size;
		((Control)TextBox33398).TabIndex = 977;
		TextBox33398.Text = "Il y a ... documents non validé";
		((ButtonBase)Button_RAPPORT).BackColor = Color.White;
		((Control)Button_RAPPORT).Cursor = Cursors.Hand;
		((ButtonBase)Button_RAPPORT).FlatAppearance.BorderColor = Color.DarkGray;
		((ButtonBase)Button_RAPPORT).FlatStyle = (FlatStyle)0;
		((Control)Button_RAPPORT).Font = new Font("Segoe UI", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((ButtonBase)Button_RAPPORT).Image = (Image)componentResourceManager.GetObject("Button_RAPPORT.Image");
		((ButtonBase)Button_RAPPORT).ImageAlign = (ContentAlignment)16;
		Button button_RAPPORT = Button_RAPPORT;
		location = new Point(4, 148);
		((Control)button_RAPPORT).Location = location;
		Button button_RAPPORT2 = Button_RAPPORT;
		margin = new Padding(0);
		((Control)button_RAPPORT2).Margin = margin;
		((Control)Button_RAPPORT).Name = "Button_RAPPORT";
		Button button_RAPPORT3 = Button_RAPPORT;
		size = new Size(156, 40);
		((Control)button_RAPPORT3).Size = size;
		((Control)Button_RAPPORT).TabIndex = 1057;
		((ButtonBase)Button_RAPPORT).Text = "Impression\r\n    Pré-inventaire";
		((ButtonBase)Button_RAPPORT).UseCompatibleTextRendering = true;
		((ButtonBase)Button_RAPPORT).UseVisualStyleBackColor = false;
		((Control)Button_ETAT_INVENTAIRE).Cursor = Cursors.Hand;
		((ButtonBase)Button_ETAT_INVENTAIRE).FlatAppearance.BorderColor = Color.DarkGray;
		((ButtonBase)Button_ETAT_INVENTAIRE).FlatStyle = (FlatStyle)0;
		((Control)Button_ETAT_INVENTAIRE).Font = new Font("Segoe UI", 9.75f, (FontStyle)1);
		((Control)Button_ETAT_INVENTAIRE).ForeColor = Color.Black;
		((ButtonBase)Button_ETAT_INVENTAIRE).Image = (Image)componentResourceManager.GetObject("Button_ETAT_INVENTAIRE.Image");
		((ButtonBase)Button_ETAT_INVENTAIRE).ImageAlign = (ContentAlignment)16;
		Button button_ETAT_INVENTAIRE = Button_ETAT_INVENTAIRE;
		location = new Point(4, 192);
		((Control)button_ETAT_INVENTAIRE).Location = location;
		Button button_ETAT_INVENTAIRE2 = Button_ETAT_INVENTAIRE;
		margin = new Padding(0);
		((Control)button_ETAT_INVENTAIRE2).Margin = margin;
		((Control)Button_ETAT_INVENTAIRE).Name = "Button_ETAT_INVENTAIRE";
		Button button_ETAT_INVENTAIRE3 = Button_ETAT_INVENTAIRE;
		size = new Size(156, 40);
		((Control)button_ETAT_INVENTAIRE3).Size = size;
		((Control)Button_ETAT_INVENTAIRE).TabIndex = 1056;
		((ButtonBase)Button_ETAT_INVENTAIRE).Text = "      Etat d'Inventaire";
		((ButtonBase)Button_ETAT_INVENTAIRE).UseVisualStyleBackColor = true;
		((Control)Button2).Cursor = Cursors.Hand;
		((ButtonBase)Button2).FlatAppearance.BorderColor = Color.DarkGray;
		((ButtonBase)Button2).FlatStyle = (FlatStyle)0;
		((Control)Button2).Font = new Font("Segoe UI", 9.75f, (FontStyle)1);
		((Control)Button2).ForeColor = Color.Black;
		((ButtonBase)Button2).Image = (Image)componentResourceManager.GetObject("Button2.Image");
		((ButtonBase)Button2).ImageAlign = (ContentAlignment)16;
		Button button14 = Button2;
		location = new Point(4, 235);
		((Control)button14).Location = location;
		Button button15 = Button2;
		margin = new Padding(0);
		((Control)button15).Margin = margin;
		((Control)Button2).Name = "Button2";
		Button button16 = Button2;
		size = new Size(156, 40);
		((Control)button16).Size = size;
		((Control)Button2).TabIndex = 1051;
		((ButtonBase)Button2).Text = "    Remise à zéro";
		((ButtonBase)Button2).UseVisualStyleBackColor = true;
		((Control)Button_ADD).Anchor = (AnchorStyles)6;
		((ButtonBase)Button_ADD).BackColor = Color.FromArgb(0, 192, 0);
		((Control)Button_ADD).Cursor = Cursors.Hand;
		((ButtonBase)Button_ADD).FlatStyle = (FlatStyle)0;
		((Control)Button_ADD).Font = new Font("Segoe UI", 12f, (FontStyle)1);
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
		((Control)Button_ADD).TabIndex = 379;
		((ButtonBase)Button_ADD).Text = "   Nouveau";
		((ButtonBase)Button_ADD).UseVisualStyleBackColor = false;
		((Control)Panel7).BackColor = Color.White;
		Panel7.BorderStyle = (BorderStyle)1;
		((Control)Panel7).Controls.Add((Control)(object)ListBox2);
		((Control)Panel7).Controls.Add((Control)(object)Button3);
		((Control)Panel7).Controls.Add((Control)(object)Button8);
		((Control)Panel7).Controls.Add((Control)(object)Label46);
		((Control)Panel7).Controls.Add((Control)(object)Label47);
		((Control)Panel7).Controls.Add((Control)(object)Label48);
		((Control)Panel7).Controls.Add((Control)(object)Label49);
		Panel panel15 = Panel7;
		location = new Point(277, 99);
		((Control)panel15).Location = location;
		((Control)Panel7).Name = "Panel7";
		Panel panel16 = Panel7;
		size = new Size(470, 429);
		((Control)panel16).Size = size;
		((Control)Panel7).TabIndex = 1069;
		((Control)Panel7).Visible = false;
		ListBox2.Font = new Font("Tahoma", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((ListControl)ListBox2).FormattingEnabled = true;
		ListBox2.ItemHeight = 14;
		ListBox listBox3 = ListBox2;
		location = new Point(10, 34);
		((Control)listBox3).Location = location;
		((Control)ListBox2).Name = "ListBox2";
		ListBox listBox4 = ListBox2;
		size = new Size(229, 312);
		((Control)listBox4).Size = size;
		((Control)ListBox2).TabIndex = 999;
		((ButtonBase)Button3).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Button3).Cursor = Cursors.Hand;
		((ButtonBase)Button3).FlatStyle = (FlatStyle)0;
		((Control)Button3).Font = new Font("Tahoma", 11.25f, (FontStyle)1);
		((Control)Button3).ForeColor = Color.White;
		((ButtonBase)Button3).ImageAlign = (ContentAlignment)16;
		Button button17 = Button3;
		location = new Point(247, 317);
		((Control)button17).Location = location;
		Button button18 = Button3;
		margin = new Padding(0);
		((Control)button18).Margin = margin;
		((Control)Button3).Name = "Button3";
		Button button19 = Button3;
		size = new Size(214, 30);
		((Control)button19).Size = size;
		((Control)Button3).TabIndex = 998;
		((ButtonBase)Button3).Text = "Imprimer";
		((ButtonBase)Button3).UseVisualStyleBackColor = false;
		((Control)Button8).Cursor = Cursors.Hand;
		((ButtonBase)Button8).FlatStyle = (FlatStyle)0;
		((Control)Button8).Font = new Font("Tahoma", 11.25f, (FontStyle)1);
		((Control)Button8).ForeColor = Color.Red;
		((ButtonBase)Button8).ImageAlign = (ContentAlignment)16;
		Button button20 = Button8;
		location = new Point(345, 381);
		((Control)button20).Location = location;
		Button button21 = Button8;
		margin = new Padding(0);
		((Control)button21).Margin = margin;
		((Control)Button8).Name = "Button8";
		Button button22 = Button8;
		size = new Size(116, 38);
		((Control)button22).Size = size;
		((Control)Button8).TabIndex = 997;
		((ButtonBase)Button8).Text = "Fermer";
		((ButtonBase)Button8).UseVisualStyleBackColor = true;
		((Control)Label46).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label46).Cursor = Cursors.Hand;
		((Control)Label46).Dock = (DockStyle)2;
		((Control)Label46).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label46).ForeColor = Color.White;
		Label label81 = Label46;
		location = new Point(4, 423);
		((Control)label81).Location = location;
		((Control)Label46).Name = "Label46";
		Label label82 = Label46;
		size = new Size(460, 4);
		((Control)label82).Size = size;
		((Control)Label46).TabIndex = 856;
		Label46.TextAlign = (ContentAlignment)16;
		((Control)Label47).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label47).Cursor = Cursors.Hand;
		((Control)Label47).Dock = (DockStyle)3;
		((Control)Label47).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label47).ForeColor = Color.White;
		Label label83 = Label47;
		location = new Point(0, 24);
		((Control)label83).Location = location;
		((Control)Label47).Name = "Label47";
		Label label84 = Label47;
		size = new Size(4, 403);
		((Control)label84).Size = size;
		((Control)Label47).TabIndex = 855;
		Label47.TextAlign = (ContentAlignment)16;
		((Control)Label48).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label48).Cursor = Cursors.Hand;
		((Control)Label48).Dock = (DockStyle)4;
		((Control)Label48).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label48).ForeColor = Color.White;
		Label label85 = Label48;
		location = new Point(464, 24);
		((Control)label85).Location = location;
		((Control)Label48).Name = "Label48";
		Label label86 = Label48;
		size = new Size(4, 403);
		((Control)label86).Size = size;
		((Control)Label48).TabIndex = 854;
		Label48.TextAlign = (ContentAlignment)16;
		((Control)Label49).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label49).Cursor = Cursors.Hand;
		((Control)Label49).Dock = (DockStyle)1;
		((Control)Label49).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label49).ForeColor = Color.White;
		Label label87 = Label49;
		location = new Point(0, 0);
		((Control)label87).Location = location;
		((Control)Label49).Name = "Label49";
		Label label88 = Label49;
		size = new Size(468, 24);
		((Control)label88).Size = size;
		((Control)Label49).TabIndex = 144;
		Label49.TextAlign = (ContentAlignment)16;
		((Control)Button_FONCTIONS).Anchor = (AnchorStyles)10;
		((ButtonBase)Button_FONCTIONS).BackColor = Color.Transparent;
		((Control)Button_FONCTIONS).Cursor = Cursors.Hand;
		((Control)Button_FONCTIONS).Font = new Font("Segoe UI", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Button_FONCTIONS).ForeColor = SystemColors.ControlText;
		((ButtonBase)Button_FONCTIONS).Image = (Image)componentResourceManager.GetObject("Button_FONCTIONS.Image");
		((ButtonBase)Button_FONCTIONS).ImageAlign = (ContentAlignment)16;
		Button button_FONCTIONS = Button_FONCTIONS;
		location = new Point(860, 646);
		((Control)button_FONCTIONS).Location = location;
		Button button_FONCTIONS2 = Button_FONCTIONS;
		margin = new Padding(0);
		((Control)button_FONCTIONS2).Margin = margin;
		((Control)Button_FONCTIONS).Name = "Button_FONCTIONS";
		Button button_FONCTIONS3 = Button_FONCTIONS;
		size = new Size(156, 40);
		((Control)button_FONCTIONS3).Size = size;
		((Control)Button_FONCTIONS).TabIndex = 1070;
		((ButtonBase)Button_FONCTIONS).Text = "   Fonctions";
		((ButtonBase)Button_FONCTIONS).UseVisualStyleBackColor = false;
		((Control)Panel_FONCTIONS).Anchor = (AnchorStyles)10;
		((Control)Panel_FONCTIONS).BackColor = Color.White;
		Panel_FONCTIONS.BorderStyle = (BorderStyle)1;
		((Control)Panel_FONCTIONS).Controls.Add((Control)(object)Button_RAPPORT);
		((Control)Panel_FONCTIONS).Controls.Add((Control)(object)Label44);
		((Control)Panel_FONCTIONS).Controls.Add((Control)(object)Label45);
		((Control)Panel_FONCTIONS).Controls.Add((Control)(object)Label50);
		((Control)Panel_FONCTIONS).Controls.Add((Control)(object)Label51);
		((Control)Panel_FONCTIONS).Controls.Add((Control)(object)Button2);
		((Control)Panel_FONCTIONS).Controls.Add((Control)(object)Button_PDF);
		((Control)Panel_FONCTIONS).Controls.Add((Control)(object)Button_ETAT_INVENTAIRE);
		((Control)Panel_FONCTIONS).Controls.Add((Control)(object)Button_EXCEL);
		((Control)Panel_FONCTIONS).Controls.Add((Control)(object)Button_WORD);
		((Control)Panel_FONCTIONS).Controls.Add((Control)(object)Button_PRINT_80MM);
		((Control)Panel_FONCTIONS).Controls.Add((Control)(object)Button_PRINT_A4);
		((Control)Panel_FONCTIONS).Controls.Add((Control)(object)Button_PrintRapport);
		Panel panel_FONCTIONS = Panel_FONCTIONS;
		location = new Point(854, 320);
		((Control)panel_FONCTIONS).Location = location;
		((Control)Panel_FONCTIONS).Name = "Panel_FONCTIONS";
		Panel panel_FONCTIONS2 = Panel_FONCTIONS;
		size = new Size(166, 326);
		((Control)panel_FONCTIONS2).Size = size;
		((Control)Panel_FONCTIONS).TabIndex = 1071;
		((Control)Panel_FONCTIONS).Visible = false;
		((Control)Label44).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label44).Cursor = Cursors.Hand;
		((Control)Label44).Dock = (DockStyle)1;
		((Control)Label44).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label44).ForeColor = Color.White;
		Label label89 = Label44;
		location = new Point(2, 0);
		((Control)label89).Location = location;
		((Control)Label44).Name = "Label44";
		Label label90 = Label44;
		size = new Size(160, 2);
		((Control)label90).Size = size;
		((Control)Label44).TabIndex = 1062;
		Label44.TextAlign = (ContentAlignment)16;
		((Control)Label45).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label45).Cursor = Cursors.Hand;
		((Control)Label45).Dock = (DockStyle)4;
		((Control)Label45).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label45).ForeColor = Color.White;
		Label label91 = Label45;
		location = new Point(162, 0);
		((Control)label91).Location = location;
		((Control)Label45).Name = "Label45";
		Label label92 = Label45;
		size = new Size(2, 322);
		((Control)label92).Size = size;
		((Control)Label45).TabIndex = 1061;
		Label45.TextAlign = (ContentAlignment)16;
		((Control)Label50).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label50).Cursor = Cursors.Hand;
		((Control)Label50).Dock = (DockStyle)3;
		((Control)Label50).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label50).ForeColor = Color.White;
		Label label93 = Label50;
		location = new Point(0, 0);
		((Control)label93).Location = location;
		((Control)Label50).Name = "Label50";
		Label label94 = Label50;
		size = new Size(2, 322);
		((Control)label94).Size = size;
		((Control)Label50).TabIndex = 1060;
		Label50.TextAlign = (ContentAlignment)16;
		((Control)Label51).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label51).Cursor = Cursors.Hand;
		((Control)Label51).Dock = (DockStyle)2;
		((Control)Label51).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label51).ForeColor = Color.White;
		Label label95 = Label51;
		location = new Point(0, 322);
		((Control)label95).Location = location;
		((Control)Label51).Name = "Label51";
		Label label96 = Label51;
		size = new Size(164, 2);
		((Control)label96).Size = size;
		((Control)Label51).TabIndex = 1059;
		Label51.TextAlign = (ContentAlignment)16;
		((ButtonBase)Button_PDF).BackColor = Color.Transparent;
		((Control)Button_PDF).Cursor = Cursors.Hand;
		((ButtonBase)Button_PDF).FlatAppearance.BorderColor = Color.FromArgb(192, 0, 0);
		((ButtonBase)Button_PDF).FlatStyle = (FlatStyle)0;
		((Control)Button_PDF).Font = new Font("Segoe UI", 11.25f, (FontStyle)1);
		((Control)Button_PDF).ForeColor = Color.Black;
		((ButtonBase)Button_PDF).Image = (Image)componentResourceManager.GetObject("Button_PDF.Image");
		((ButtonBase)Button_PDF).ImageAlign = (ContentAlignment)16;
		Button button_PDF = Button_PDF;
		location = new Point(4, 4);
		((Control)button_PDF).Location = location;
		((Control)Button_PDF).Name = "Button_PDF";
		Button button_PDF2 = Button_PDF;
		size = new Size(156, 40);
		((Control)button_PDF2).Size = size;
		((Control)Button_PDF).TabIndex = 382;
		((ButtonBase)Button_PDF).Text = "  Exporter Pdf";
		((ButtonBase)Button_PDF).UseVisualStyleBackColor = false;
		((ButtonBase)Button_EXCEL).BackColor = Color.Transparent;
		((Control)Button_EXCEL).Cursor = Cursors.Hand;
		((ButtonBase)Button_EXCEL).FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
		((ButtonBase)Button_EXCEL).FlatStyle = (FlatStyle)0;
		((Control)Button_EXCEL).Font = new Font("Segoe UI", 11.25f, (FontStyle)1);
		((Control)Button_EXCEL).ForeColor = Color.Black;
		((ButtonBase)Button_EXCEL).Image = (Image)componentResourceManager.GetObject("Button_EXCEL.Image");
		((ButtonBase)Button_EXCEL).ImageAlign = (ContentAlignment)16;
		Button button_EXCEL = Button_EXCEL;
		location = new Point(4, 50);
		((Control)button_EXCEL).Location = location;
		((Control)Button_EXCEL).Name = "Button_EXCEL";
		Button button_EXCEL2 = Button_EXCEL;
		size = new Size(156, 40);
		((Control)button_EXCEL2).Size = size;
		((Control)Button_EXCEL).TabIndex = 381;
		((ButtonBase)Button_EXCEL).Text = "      Exporter Excel";
		((ButtonBase)Button_EXCEL).UseVisualStyleBackColor = false;
		((ButtonBase)Button_WORD).BackColor = Color.Transparent;
		((Control)Button_WORD).Cursor = Cursors.Hand;
		((ButtonBase)Button_WORD).FlatAppearance.BorderColor = Color.Blue;
		((ButtonBase)Button_WORD).FlatStyle = (FlatStyle)0;
		((Control)Button_WORD).Font = new Font("Segoe UI", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Button_WORD).ForeColor = Color.Black;
		((ButtonBase)Button_WORD).Image = (Image)componentResourceManager.GetObject("Button_WORD.Image");
		((ButtonBase)Button_WORD).ImageAlign = (ContentAlignment)16;
		Button button_WORD = Button_WORD;
		location = new Point(4, 96);
		((Control)button_WORD).Location = location;
		((Control)Button_WORD).Name = "Button_WORD";
		Button button_WORD2 = Button_WORD;
		size = new Size(156, 40);
		((Control)button_WORD2).Size = size;
		((Control)Button_WORD).TabIndex = 380;
		((ButtonBase)Button_WORD).Text = "      Exporter Word";
		((ButtonBase)Button_WORD).UseVisualStyleBackColor = false;
		((Control)Button_PRINT_80MM).Cursor = Cursors.Hand;
		((Control)Button_PRINT_80MM).Font = new Font("Tahoma", 9f, (FontStyle)1);
		((ButtonBase)Button_PRINT_80MM).ImageAlign = (ContentAlignment)16;
		Button button_PRINT_80MM = Button_PRINT_80MM;
		location = new Point(4, 280);
		((Control)button_PRINT_80MM).Location = location;
		((Control)Button_PRINT_80MM).Name = "Button_PRINT_80MM";
		Button button_PRINT_80MM2 = Button_PRINT_80MM;
		size = new Size(77, 40);
		((Control)button_PRINT_80MM2).Size = size;
		((Control)Button_PRINT_80MM).TabIndex = 1057;
		((ButtonBase)Button_PRINT_80MM).Text = "80mm";
		((ButtonBase)Button_PRINT_80MM).UseVisualStyleBackColor = true;
		((Control)Button_PRINT_80MM).Visible = false;
		((Control)Button_PRINT_A4).Cursor = Cursors.Hand;
		((Control)Button_PRINT_A4).Font = new Font("Tahoma", 9f, (FontStyle)1);
		((ButtonBase)Button_PRINT_A4).ImageAlign = (ContentAlignment)16;
		Button button_PRINT_A = Button_PRINT_A4;
		location = new Point(83, 280);
		((Control)button_PRINT_A).Location = location;
		((Control)Button_PRINT_A4).Name = "Button_PRINT_A4";
		Button button_PRINT_A2 = Button_PRINT_A4;
		size = new Size(77, 40);
		((Control)button_PRINT_A2).Size = size;
		((Control)Button_PRINT_A4).TabIndex = 1058;
		((ButtonBase)Button_PRINT_A4).Text = "A4";
		((ButtonBase)Button_PRINT_A4).UseVisualStyleBackColor = true;
		((Control)Button_PRINT_A4).Visible = false;
		((Control)Button_PrintRapport).Cursor = Cursors.Hand;
		((ButtonBase)Button_PrintRapport).FlatAppearance.BorderColor = Color.DarkGray;
		((ButtonBase)Button_PrintRapport).FlatStyle = (FlatStyle)0;
		((Control)Button_PrintRapport).Font = new Font("Segoe UI", 12f, (FontStyle)1);
		((ButtonBase)Button_PrintRapport).Image = (Image)componentResourceManager.GetObject("Button_PrintRapport.Image");
		((ButtonBase)Button_PrintRapport).ImageAlign = (ContentAlignment)16;
		Button button_PrintRapport = Button_PrintRapport;
		location = new Point(4, 280);
		((Control)button_PrintRapport).Location = location;
		((Control)Button_PrintRapport).Name = "Button_PrintRapport";
		Button button_PrintRapport2 = Button_PrintRapport;
		size = new Size(156, 40);
		((Control)button_PrintRapport2).Size = size;
		((Control)Button_PrintRapport).TabIndex = 1056;
		((ButtonBase)Button_PrintRapport).Text = "Imprimer";
		((ButtonBase)Button_PrintRapport).UseVisualStyleBackColor = true;
		((Control)Label_TABLE).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Label_TABLE).Dock = (DockStyle)1;
		((Control)Label_TABLE).Font = new Font("Tahoma", 9f, (FontStyle)1);
		((Control)Label_TABLE).ForeColor = Color.White;
		Label_TABLE.ImeMode = (ImeMode)0;
		Label label_TABLE = Label_TABLE;
		location = new Point(0, 0);
		((Control)label_TABLE).Location = location;
		((Control)Label_TABLE).Name = "Label_TABLE";
		Label label_TABLE2 = Label_TABLE;
		size = new Size(1025, 44);
		((Control)label_TABLE2).Size = size;
		((Control)Label_TABLE).TabIndex = 1072;
		Label_TABLE.Text = "INVENTAIRES_ENTETE";
		Label_TABLE.TextAlign = (ContentAlignment)16;
		((Control)Panel_FIND).Anchor = (AnchorStyles)13;
		((Control)Panel_FIND).BackColor = Color.FromArgb(22, 106, 238);
		((Control)Panel_FIND).Controls.Add((Control)(object)Panel_DATES);
		((Control)Panel_FIND).Controls.Add((Control)(object)Combo_FIND);
		((Control)Panel_FIND).Controls.Add((Control)(object)Picture_EXPORT);
		((Control)Panel_FIND).Controls.Add((Control)(object)Label19);
		((Control)Panel_FIND).Controls.Add((Control)(object)Label25);
		((Control)Panel_FIND).Controls.Add((Control)(object)Check_FIND_DATE);
		((Control)Panel_FIND).Controls.Add((Control)(object)Check_FIND_EXACTE);
		((Control)Panel_FIND).Controls.Add((Control)(object)Picture_REFRESH);
		((Control)Panel_FIND).Controls.Add((Control)(object)Picture_FIND);
		((Control)Panel_FIND).Controls.Add((Control)(object)Text_FIND);
		Panel panel_FIND = Panel_FIND;
		location = new Point(138, 0);
		((Control)panel_FIND).Location = location;
		((Control)Panel_FIND).Name = "Panel_FIND";
		Panel panel_FIND2 = Panel_FIND;
		size = new Size(882, 44);
		((Control)panel_FIND2).Size = size;
		((Control)Panel_FIND).TabIndex = 1073;
		((Control)Panel_DATES).Controls.Add((Control)(object)DateTime2_FIND);
		((Control)Panel_DATES).Controls.Add((Control)(object)DateTime1_FIND);
		((Control)Panel_DATES).Controls.Add((Control)(object)Picture_FIND_DATES);
		((Control)Panel_DATES).Controls.Add((Control)(object)PictureBox13);
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
		size = new Size(100, 25);
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
		size = new Size(100, 25);
		((Control)dateTime1_FIND2).Size = size;
		((Control)DateTime1_FIND).TabIndex = 986;
		Picture_FIND_DATES.Image = (Image)componentResourceManager.GetObject("Picture_FIND_DATES.Image");
		Picture_FIND_DATES.ImeMode = (ImeMode)0;
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
		PictureBox13.Image = (Image)componentResourceManager.GetObject("PictureBox13.Image");
		PictureBox13.ImeMode = (ImeMode)0;
		PictureBox pictureBox7 = PictureBox13;
		location = new Point(108, 6);
		((Control)pictureBox7).Location = location;
		((Control)PictureBox13).Name = "PictureBox13";
		PictureBox pictureBox8 = PictureBox13;
		size = new Size(35, 26);
		((Control)pictureBox8).Size = size;
		PictureBox13.SizeMode = (PictureBoxSizeMode)4;
		PictureBox13.TabIndex = 1040;
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
		((ComboBox)Combo_FIND).Items.AddRange(new object[4] { "ID_INV", "UTILISATEUR", "ETAT", "DATES" });
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
		((ButtonBase)Picture_EXPORT).ImeMode = (ImeMode)0;
		Button_RJ picture_EXPORT = Picture_EXPORT;
		location = new Point(844, 6);
		((Control)picture_EXPORT).Location = location;
		((Control)Picture_EXPORT).Name = "Picture_EXPORT";
		Button_RJ picture_EXPORT2 = Picture_EXPORT;
		size = new Size(33, 33);
		((Control)picture_EXPORT2).Size = size;
		((Control)Picture_EXPORT).TabIndex = 1056;
		((ButtonBase)Picture_EXPORT).UseVisualStyleBackColor = false;
		Label19.AutoSize = true;
		((Control)Label19).Font = new Font("Segoe UI", 9.75f);
		((Control)Label19).ForeColor = Color.White;
		Label19.ImeMode = (ImeMode)0;
		Label label97 = Label19;
		location = new Point(492, 13);
		((Control)label97).Location = location;
		((Control)Label19).Name = "Label19";
		Label label98 = Label19;
		size = new Size(65, 17);
		((Control)label98).Size = size;
		((Control)Label19).TabIndex = 1055;
		Label19.Text = "Avec date";
		Label25.AutoSize = true;
		((Control)Label25).Font = new Font("Segoe UI", 9.75f);
		((Control)Label25).ForeColor = Color.White;
		Label25.ImeMode = (ImeMode)0;
		Label label99 = Label25;
		location = new Point(411, 13);
		((Control)label99).Location = location;
		((Control)Label25).Name = "Label25";
		Label label100 = Label25;
		size = new Size(45, 17);
		((Control)label100).Size = size;
		((Control)Label25).TabIndex = 1054;
		Label25.Text = "Exacte";
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
		((ButtonBase)Picture_REFRESH).ImeMode = (ImeMode)0;
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
		((ButtonBase)Picture_FIND).ImeMode = (ImeMode)0;
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
		Text_FIND.Font = new Font("Segoe UI", 9.75f);
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
		size = new Size(211, 32);
		((Control)text_FIND4).Size = size;
		((Control)Text_FIND).TabIndex = 986;
		Text_FIND.Texts = "";
		Text_FIND.UnderlinedStyle = false;
		((Control)Panel2).Controls.Add((Control)(object)DataGridView3);
		((Control)Panel2).Controls.Add((Control)(object)DataGridView2);
		Panel panel17 = Panel2;
		location = new Point(17, 116);
		((Control)panel17).Location = location;
		((Control)Panel2).Name = "Panel2";
		Panel panel18 = Panel2;
		size = new Size(582, 348);
		((Control)panel18).Size = size;
		((Control)Panel2).TabIndex = 1077;
		((Control)Panel2).Visible = false;
		DataGridView3.AllowUserToAddRows = false;
		DataGridView3.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		DataGridView3.Columns.AddRange(new DataGridViewColumn[1] { (DataGridViewColumn)DataGridViewTextBoxColumn3 });
		val6.Alignment = (DataGridViewContentAlignment)16;
		val6.BackColor = SystemColors.Window;
		val6.Font = new Font("Microsoft Sans Serif", 8f);
		val6.ForeColor = SystemColors.ControlText;
		val6.SelectionBackColor = SystemColors.Highlight;
		val6.SelectionForeColor = SystemColors.HighlightText;
		val6.WrapMode = (DataGridViewTriState)2;
		DataGridView3.DefaultCellStyle = val6;
		DataGridView dataGridView3 = DataGridView3;
		location = new Point(5, 207);
		((Control)dataGridView3).Location = location;
		((Control)DataGridView3).Name = "DataGridView3";
		DataGridView dataGridView4 = DataGridView3;
		size = new Size(570, 133);
		((Control)dataGridView4).Size = size;
		((Control)DataGridView3).TabIndex = 383;
		((DataGridViewColumn)DataGridViewTextBoxColumn3).HeaderText = "COL_1";
		((DataGridViewColumn)DataGridViewTextBoxColumn3).Name = "DataGridViewTextBoxColumn3";
		((DataGridViewColumn)DataGridViewTextBoxColumn3).Resizable = (DataGridViewTriState)1;
		DataGridViewTextBoxColumn3.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)DataGridViewTextBoxColumn3).Width = 180;
		DataGridView2.AllowUserToAddRows = false;
		DataGridView2.ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		DataGridView2.Columns.AddRange(new DataGridViewColumn[3]
		{
			(DataGridViewColumn)COL_1,
			(DataGridViewColumn)COL_2,
			(DataGridViewColumn)COL_3
		});
		val7.Alignment = (DataGridViewContentAlignment)16;
		val7.BackColor = SystemColors.Window;
		val7.Font = new Font("Microsoft Sans Serif", 8f);
		val7.ForeColor = SystemColors.ControlText;
		val7.SelectionBackColor = SystemColors.Highlight;
		val7.SelectionForeColor = SystemColors.HighlightText;
		val7.WrapMode = (DataGridViewTriState)2;
		DataGridView2.DefaultCellStyle = val7;
		DataGridView dataGridView5 = DataGridView2;
		location = new Point(5, 3);
		((Control)dataGridView5).Location = location;
		((Control)DataGridView2).Name = "DataGridView2";
		DataGridView dataGridView6 = DataGridView2;
		size = new Size(570, 198);
		((Control)dataGridView6).Size = size;
		((Control)DataGridView2).TabIndex = 382;
		((DataGridViewColumn)COL_1).HeaderText = "COL_1";
		((DataGridViewColumn)COL_1).Name = "COL_1";
		((DataGridViewColumn)COL_1).Resizable = (DataGridViewTriState)1;
		COL_1.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)COL_1).Width = 180;
		((DataGridViewColumn)COL_2).HeaderText = "COL_2";
		((DataGridViewColumn)COL_2).Name = "COL_2";
		((DataGridViewColumn)COL_2).Width = 140;
		val8.Format = "N2";
		val8.NullValue = null;
		((DataGridViewColumn)COL_3).DefaultCellStyle = val8;
		((DataGridViewColumn)COL_3).HeaderText = "COL_3";
		((DataGridViewColumn)COL_3).Name = "COL_3";
		((DataGridViewColumn)COL_3).Width = 180;
		((DataGridViewColumn)Dates).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)Dates).DataPropertyName = "Dates";
		val9.Format = "d";
		val9.NullValue = null;
		((DataGridViewColumn)Dates).DefaultCellStyle = val9;
		((DataGridViewColumn)Dates).HeaderText = "DATES";
		((DataGridViewColumn)Dates).Name = "Dates";
		Dates.SortMode = (DataGridViewColumnSortMode)0;
		((DataGridViewColumn)ID_INV).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)ID_INV).DataPropertyName = "ID_INV";
		((DataGridViewColumn)ID_INV).HeaderText = "ID_INV";
		((DataGridViewColumn)ID_INV).MinimumWidth = 2;
		((DataGridViewColumn)ID_INV).Name = "ID_INV";
		((DataGridViewColumn)ID_INV).Resizable = (DataGridViewTriState)2;
		((DataGridViewColumn)NOTES).DataPropertyName = "NOTES";
		((DataGridViewColumn)NOTES).HeaderText = "NOTES";
		((DataGridViewColumn)NOTES).Name = "NOTES";
		((DataGridViewColumn)TOTAL_VALEUR).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)TOTAL_VALEUR).DataPropertyName = "TOTAL_VALEUR";
		val10.Format = "N2";
		val10.NullValue = null;
		((DataGridViewColumn)TOTAL_VALEUR).DefaultCellStyle = val10;
		((DataGridViewColumn)TOTAL_VALEUR).HeaderText = "TOTAL_VALEUR";
		((DataGridViewColumn)TOTAL_VALEUR).Name = "TOTAL_VALEUR";
		((DataGridViewColumn)TOTAL_VALEUR).Width = 120;
		((DataGridViewColumn)ETAT).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)ETAT).DataPropertyName = "ETAT";
		((DataGridViewColumn)ETAT).HeaderText = "ETAT";
		((DataGridViewColumn)ETAT).Name = "ETAT";
		ETAT.SortMode = (DataGridViewColumnSortMode)2;
		((DataGridViewColumn)ETAT).Width = 110;
		((DataGridViewColumn)supp).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)supp).HeaderText = "";
		supp.Image = (Image)(object)Resources.Picture_SUPP_Image;
		((DataGridViewColumn)supp).Name = "supp";
		((DataGridViewColumn)supp).Resizable = (DataGridViewTriState)1;
		((DataGridViewColumn)supp).SortMode = (DataGridViewColumnSortMode)2;
		((DataGridViewColumn)supp).Width = 40;
		((DataGridViewColumn)modi).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)modi).HeaderText = "";
		modi.Image = (Image)(object)Resources.Picture_MODIF_Image;
		((DataGridViewColumn)modi).Name = "modi";
		((DataGridViewColumn)modi).Resizable = (DataGridViewTriState)1;
		((DataGridViewColumn)modi).SortMode = (DataGridViewColumnSortMode)2;
		((DataGridViewColumn)modi).Width = 40;
		((DataGridViewColumn)cons).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)cons).HeaderText = "";
		cons.Image = (Image)(object)Resources.Picture_CONS_Image;
		((DataGridViewColumn)cons).Name = "cons";
		((DataGridViewColumn)cons).Resizable = (DataGridViewTriState)1;
		((DataGridViewColumn)cons).Width = 40;
		((Control)Label_TOTAL_VALEUR_DOC).Anchor = (AnchorStyles)9;
		((Control)Label_TOTAL_VALEUR_DOC).BackColor = Color.White;
		((Control)Label_TOTAL_VALEUR_DOC).Font = new Font("Segoe UI", 11.25f, (FontStyle)1);
		((Control)Label_TOTAL_VALEUR_DOC).ForeColor = Color.FromArgb(22, 106, 238);
		Label label_TOTAL_VALEUR_DOC = Label_TOTAL_VALEUR_DOC;
		location = new Point(762, 1);
		((Control)label_TOTAL_VALEUR_DOC).Location = location;
		((Control)Label_TOTAL_VALEUR_DOC).Name = "Label_TOTAL_VALEUR_DOC";
		Label label_TOTAL_VALEUR_DOC2 = Label_TOTAL_VALEUR_DOC;
		size = new Size(113, 29);
		((Control)label_TOTAL_VALEUR_DOC2).Size = size;
		((Control)Label_TOTAL_VALEUR_DOC).TabIndex = 1083;
		Label_TOTAL_VALEUR_DOC.Text = "-";
		Label_TOTAL_VALEUR_DOC.TextAlign = (ContentAlignment)16;
		((Control)Label52).Anchor = (AnchorStyles)9;
		((Control)Label52).BackColor = Color.White;
		((Control)Label52).Font = new Font("Segoe UI", 11.25f, (FontStyle)1);
		((Control)Label52).ForeColor = Color.FromArgb(64, 64, 64);
		Label label101 = Label52;
		location = new Point(637, 1);
		((Control)label101).Location = location;
		((Control)Label52).Name = "Label52";
		Label label102 = Label52;
		size = new Size(125, 29);
		((Control)label102).Size = size;
		((Control)Label52).TabIndex = 1082;
		Label52.Text = "TOTAL VALEUR :";
		Label52.TextAlign = (ContentAlignment)16;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).BackColor = Color.White;
		size = new Size(1025, 692);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)Panel_INFO);
		((Control)this).Controls.Add((Control)(object)Panel_FIND);
		((Control)this).Controls.Add((Control)(object)Label_TABLE);
		((Control)this).Controls.Add((Control)(object)Panel7727);
		((Control)this).Controls.Add((Control)(object)Button_FONCTIONS);
		((Control)this).Controls.Add((Control)(object)Panel243544);
		((Control)this).Controls.Add((Control)(object)Button_VALIDER);
		((Control)this).Controls.Add((Control)(object)Button_ADD);
		((Control)this).Controls.Add((Control)(object)Panel_FONCTIONS);
		((Control)this).Controls.Add((Control)(object)Panel_INV_MASSE);
		((Control)this).Controls.Add((Control)(object)Panel7);
		((Control)this).Controls.Add((Control)(object)Panel2);
		((Control)this).Controls.Add((Control)(object)DataGridView1);
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Form)this).KeyPreview = true;
		((Control)this).Name = "Form_6_INVENTAIRES";
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).WindowState = (FormWindowState)2;
		((Control)Panel_INFO).ResumeLayout(false);
		((Control)Panel_CLAVIER).ResumeLayout(false);
		((Control)Panel5).ResumeLayout(false);
		((ISupportInitialize)PictureBox2323).EndInit();
		((Control)TabControl1).ResumeLayout(false);
		((Control)TabPage1).ResumeLayout(false);
		((Control)Panel4).ResumeLayout(false);
		((Control)Panel4).PerformLayout();
		((Control)Panel3).ResumeLayout(false);
		((Control)Panel3).PerformLayout();
		((Control)TabPage2).ResumeLayout(false);
		((Control)Panel6).ResumeLayout(false);
		((Control)Panel6).PerformLayout();
		((Control)Panel1).ResumeLayout(false);
		((Control)Panel1).PerformLayout();
		((ISupportInitialize)DataGridView_FAMILLES).EndInit();
		((ISupportInitialize)DataGridView_ARTICLES).EndInit();
		((ISupportInitialize)DataGrid_BODY).EndInit();
		((ISupportInitialize)DataGridView1).EndInit();
		((Control)Panel_INV_MASSE).ResumeLayout(false);
		((Control)Panel_INV_MASSE).PerformLayout();
		((ISupportInitialize)PictureBox5).EndInit();
		((Control)Panel243544).ResumeLayout(false);
		((Control)Panel7727).ResumeLayout(false);
		((Control)Panel7727).PerformLayout();
		((ISupportInitialize)PictureBox3).EndInit();
		((Control)Panel7).ResumeLayout(false);
		((Control)Panel_FONCTIONS).ResumeLayout(false);
		((Control)Panel_FIND).ResumeLayout(false);
		((Control)Panel_FIND).PerformLayout();
		((Control)Panel_DATES).ResumeLayout(false);
		((ISupportInitialize)Picture_FIND_DATES).EndInit();
		((ISupportInitialize)PictureBox13).EndInit();
		((Control)Panel2).ResumeLayout(false);
		((ISupportInitialize)DataGridView3).EndInit();
		((ISupportInitialize)DataGridView2).EndInit();
		((Control)this).ResumeLayout(false);
	}

	public void FUN_CAT_ACCES()
	{
		if (Operators.CompareString(Module1._USERCATEGORIE, "ADMIN", TextCompare: false) == 0)
		{
			DataGridView1.Columns["supp"].Visible = true;
			DataGridView1.Columns["modi"].Visible = true;
			DataGridView1.Columns["cons"].Visible = true;
			((Control)Button_VALIDER).Enabled = true;
			((Control)Button_FONCTIONS).Visible = true;
		}
		else if (Operators.CompareString(Module1._USERCATEGORIE, "MANAGER", TextCompare: false) == 0)
		{
			DataGridView1.Columns["supp"].Visible = true;
			DataGridView1.Columns["modi"].Visible = true;
			DataGridView1.Columns["cons"].Visible = true;
			((Control)Button_VALIDER).Enabled = true;
			((Control)Button_FONCTIONS).Visible = true;
		}
		else if (Operators.CompareString(Module1._USERCATEGORIE, "UTILISATEUR", TextCompare: false) == 0)
		{
			DataGridView1.Columns["supp"].Visible = true;
			DataGridView1.Columns["modi"].Visible = true;
			DataGridView1.Columns["cons"].Visible = true;
			((Control)Button_VALIDER).Enabled = false;
			((Control)Button_FONCTIONS).Visible = false;
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

	private void Form_6_RECEPTIONS_FormClosed(object sender, FormClosedEventArgs e)
	{
		DT.Clear();
	}

	private void Form_Load(object sender, EventArgs e)
	{
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected Obj, but got Unknown
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected Obj, but got Unknown
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Expected Obj, but got Unknown
		//IL_069e: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a5: Expected Obj, but got Unknown
		//IL_03d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e3: Expected Obj, but got Unknown
		//IL_0424: Unknown result type (might be due to invalid IL or missing references)
		//IL_042a: Expected Obj, but got Unknown
		//IL_043b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0441: Expected Obj, but got Unknown
		checked
		{
			try
			{
				Combo_FIND.SelectedIndex = 0;
				Text_FIND.PlaceholderText = "Recherche";
				DateTime1_FIND.Text = "01/01/2000";
				DateTime2_FIND.Text = Conversions.ToString(DateTime.Now.Date);
				Text_FIND_BODY.PlaceholderText = "Recherche";
				ImageList val = new ImageList();
				val.Images.Add("key1", (Image)(object)Resources.dot_13);
				TabControl1.ImageList = val;
				TabPage1.ImageIndex = 0;
				TabPage2.ImageIndex = 0;
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
				DataGridView1.ClearSelection();
				DataGrid_BODY.Columns[1].DefaultCellStyle.WrapMode = (DataGridViewTriState)1;
				DataGrid_BODY.AutoSizeRowsMode = (DataGridViewAutoSizeRowsMode)7;
				int num5 = ((BaseCollection)DataGrid_BODY.Columns).Count - 1;
				int num6 = 0;
				while (true)
				{
					int num7 = num6;
					int num4 = num5;
					if (num7 > num4)
					{
						break;
					}
					DataGrid_BODY.Columns[num6].SortMode = (DataGridViewColumnSortMode)2;
					DataGrid_BODY.Columns[num6].ReadOnly = true;
					num6++;
				}
				DataGrid_BODY.EditMode = (DataGridViewEditMode)0;
				DataGrid_BODY.Columns["Stock_Physique"].ReadOnly = false;
				DataGrid_BODY.EnableHeadersVisualStyles = false;
				((DataGridViewCell)DataGrid_BODY.Columns["Stock_Logique"].HeaderCell).Style.BackColor = Color.Salmon;
				((DataGridViewCell)DataGrid_BODY.Columns["Stock_Physique"].HeaderCell).Style.BackColor = Color.Yellow;
				DA = new MySqlDataAdapter("select * from     TABLE_" + Label_TABLE.Text + "              order by       ID      DESC", Module1.cn_SQL);
				DT = new DataTable();
				DT.Clear();
				((DbDataAdapter)(object)DA).Fill(DT);
				DataGridView1.DataSource = DT;
				DataTable dataTable = new DataTable();
				MySqlDataAdapter val2 = new MySqlDataAdapter();
				dataTable.Clear();
				val2 = new MySqlDataAdapter("select Famille from TABLE_FAMILLES order by Ordre asc", Module1.cn_SQL);
				((DbDataAdapter)(object)val2).Fill(dataTable);
				DataGridView_FAMILLES.RowTemplate.Height = 15;
				DataGridView_FAMILLES.Rows.Clear();
				DataGridView_FAMILLES.Rows.Add(new object[1] { "TOUT" });
				ListBox1.Items.Clear();
				ListBox1.Items.Add((object)"TOUT");
				ListBox2.Items.Clear();
				ListBox2.Items.Add((object)"TOUT");
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
					DataGridView_FAMILLES.Rows.Add(new object[1] { dataTable.Rows[num9]["Famille"].ToString() });
					ListBox1.Items.Add((object)dataTable.Rows[num9]["FAMILLE"].ToString());
					ListBox2.Items.Add((object)dataTable.Rows[num9]["FAMILLE"].ToString());
					num9++;
				}
				TabControl1.SizeMode = (TabSizeMode)2;
				TabControl tabControl = TabControl1;
				Size itemSize = new Size((int)Math.Round((double)((Control)TabControl1).Width / (double)TabControl1.TabCount - 4.0), 30);
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
					Bitmap val3 = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, (PixelFormat)2498570);
					Graphics val4 = Graphics.FromImage((Image)(object)val3);
					val4.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, (CopyPixelOperation)13369376);
					((Image)val3).Save(Application.StartupPath + "\\tchak\\" + text + ".snidb", ImageFormat.Jpeg);
					val3 = null;
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

	private void Button_SAVE_Click(object sender, EventArgs e)
	{
		//IL_0e90: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e97: Expected Obj, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected Obj, but got Unknown
		//IL_0da3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dad: Expected Obj, but got Unknown
		//IL_074a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0751: Expected Obj, but got Unknown
		//IL_07c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07cc: Expected Obj, but got Unknown
		//IL_0948: Unknown result type (might be due to invalid IL or missing references)
		//IL_094f: Expected Obj, but got Unknown
		//IL_096d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0974: Expected Obj, but got Unknown
		//IL_07fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c77: Unknown result type (might be due to invalid IL or missing references)
		//IL_0383: Unknown result type (might be due to invalid IL or missing references)
		//IL_038a: Expected Obj, but got Unknown
		//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ae: Expected Obj, but got Unknown
		//IL_06b8: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			try
			{
				if (Operators.CompareString(DateTimePicker_DATE.Text, "", TextCompare: false) == 0)
				{
					MessageBox.Show("Veuillez remplir le champ -Date- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
				if (Operators.CompareString(Text_UTILISATEUR.Text, "", TextCompare: false) == 0)
				{
					MessageBox.Show("Veuillez remplir le champ -UTILISATEUR- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
				if (DataGrid_BODY.Rows.Count == 0)
				{
					MessageBox.Show("Veuillez remplir la Table ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
				if (Operators.CompareString(Label_TOTAL_VALEUR_DOC.Text, "", TextCompare: false) == 0)
				{
					MessageBox.Show("Veuillez remplir le champ -TOTAL_VALEUR- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
				Button_CALC_DOC_Click(RuntimeHelpers.GetObjectValue(sender), e);
				DataGrid_BODY_CellValidated(null, null);
				if (Operators.CompareString(Label_TOP.Text, "NOUVEAU", TextCompare: false) == 0)
				{
					MySqlCommand val = new MySqlCommand();
					val.CommandText = "SELECT MAX(ID) From TABLE_" + Label_TABLE.Text + " ";
					val.Connection = Module1.cn_SQL;
					val.CommandType = CommandType.Text;
					if (Module1.cn_SQL.State != ConnectionState.Open)
					{
						Module1.cn_SQL.Open();
					}
					int num = ((val.ExecuteScalar() == DBNull.Value) ? 1 : ((int)Math.Round(Conversions.ToDouble(val.ExecuteScalar()) + 1.0)));
					Module1.cn_SQL.Close();
					val.CommandText = "Select INV from TABLE_NUM  where ID = 0 ";
					val.Connection = Module1.cn_SQL;
					val.CommandType = CommandType.Text;
					if (Module1.cn_SQL.State != ConnectionState.Open)
					{
						Module1.cn_SQL.Open();
					}
					string text = ((val.ExecuteScalar() != DBNull.Value) ? ("INV" + Strings.Format(Conversions.ToDouble(val.ExecuteScalar()), "000000")) : Conversions.ToString(0));
					Module1.cn_SQL.Close();
					DT.Rows.Add();
					int index = DT.Rows.Count - 1;
					DT.Rows[index]["ID"] = num;
					DT.Rows[index]["ID_INV"] = text;
					DT.Rows[index]["Dates"] = DateTimePicker_DATE.Text;
					DT.Rows[index]["UTILISATEUR"] = Text_UTILISATEUR.Text;
					DT.Rows[index]["TOTAL_VALEUR"] = Module1.FLOUSS(Conversions.ToDecimal(Label_TOTAL_VALEUR_DOC.Text));
					DT.Rows[index]["NOTES"] = Text_NOTES.Text;
					DT.Rows[index]["ETAT"] = "ENREGISTRER";
					MySqlCommandBuilder val2 = new MySqlCommandBuilder(DA);
					((DbDataAdapter)(object)DA).Update(DT);
					DT.AcceptChanges();
					MySqlCommand val3 = new MySqlCommand();
					if (Module1.cn_SQL.State != ConnectionState.Open)
					{
						Module1.cn_SQL.Open();
					}
					int num2 = DataGrid_BODY.Rows.Count - 1;
					int num3 = 0;
					while (true)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						val3.CommandText = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(string.Concat(string.Concat("INSERT  INTO   TABLE_INVENTAIRES_DETAILS              ( Dates,ID_INV ,N_INV ,ID_ARTICLE, Code, Article , PRIX_A, STOCK_LOGIQUE, STOCK_PHYSIQUE, ECART , VALEUR , ETAT  )      values           ('" + Strings.Format(Conversions.ToDate(DateTimePicker_DATE.Text), "yyyy-MM-dd"), "' ,'"), text), "' ,' '    ,'"), DataGrid_BODY.Rows[num3].Cells["ID_ARTICLE"].Value), "','"), DataGrid_BODY.Rows[num3].Cells["Code"].Value), "' ,'"), DataGrid_BODY.Rows[num3].Cells["Article"].Value), "' ,'"), Module1.FLOUSS(Conversions.ToDecimal(DataGrid_BODY.Rows[num3].Cells["Prix_A"].Value))), "','"), Module1.FLOUSS(Conversions.ToDecimal(DataGrid_BODY.Rows[num3].Cells["STOCK_LOGIQUE"].Value))), "' ,'"), Module1.FLOUSS(Conversions.ToDecimal(DataGrid_BODY.Rows[num3].Cells["STOCK_PHYSIQUE"].Value))), "' ,'"), Module1.FLOUSS(Conversions.ToDecimal(DataGrid_BODY.Rows[num3].Cells["ECART"].Value))), "' ,'"), Module1.FLOUSS(Conversions.ToDecimal(DataGrid_BODY.Rows[num3].Cells["VALEUR"].Value))), "',   'ENREGISTRER'   )   "));
						val3.Connection = Module1.cn_SQL;
						val3.ExecuteNonQuery();
						num3++;
					}
					Module1.cn_SQL.Close();
					if (Module1.cn_SQL.State != ConnectionState.Open)
					{
						Module1.cn_SQL.Open();
					}
					val.CommandText = "UPDATE     TABLE_NUM    SET INV =  INV + 1   ";
					val.Connection = Module1.cn_SQL;
					val.ExecuteNonQuery();
					Module1.cn_SQL.Close();
					MessageBox.Show("Enregistré avec succès", "ok", (MessageBoxButtons)0, (MessageBoxIcon)64, (MessageBoxDefaultButton)0);
				}
				else if (Operators.CompareString(Label_TOP.Text, "MODIFICATION", TextCompare: false) == 0)
				{
					DataGridView1.CurrentCell = DataGridView1.Rows[Conversions.ToInteger(Label_INDEX.Text)].Cells[0];
					DataGridView1.Rows[Conversions.ToInteger(Label_INDEX.Text)].Selected = true;
					DataTable dataTable = new DataTable();
					MySqlDataAdapter val4 = new MySqlDataAdapter();
					dataTable.Clear();
					val4 = new MySqlDataAdapter("select ID,ID_INV     from TABLE_" + Label_TABLE.Text + " WHERE   ID_INV = '" + Text_ID_INV.Text + "'    AND    ID <> " + Text_ID.Text + "    ", Module1.cn_SQL);
					((DbDataAdapter)(object)val4).Fill(dataTable);
					if (dataTable.Rows.Count != 0)
					{
						MessageBox.Show("Cet ID est déja utilisé", "Attetion", (MessageBoxButtons)0, (MessageBoxIcon)48, (MessageBoxDefaultButton)0);
						return;
					}
					int position = ((ContainerControl)this).BindingContext[(object)DT].Position;
					DT.Rows[position]["ID"] = Text_ID.Text;
					DT.Rows[position]["ID_INV"] = Text_ID_INV.Text;
					DT.Rows[position]["Dates"] = DateTimePicker_DATE.Text;
					DT.Rows[position]["UTILISATEUR"] = Text_UTILISATEUR.Text;
					DT.Rows[position]["TOTAL_VALEUR"] = Module1.FLOUSS(Conversions.ToDecimal(Label_TOTAL_VALEUR_DOC.Text));
					DT.Rows[position]["NOTES"] = Text_NOTES.Text;
					DT.Rows[position]["ETAT"] = "ENREGISTRER";
					MySqlCommandBuilder val5 = new MySqlCommandBuilder(DA);
					((DbDataAdapter)(object)DA).Update(DT);
					DT.AcceptChanges();
					MySqlCommand val6 = new MySqlCommand();
					if (Module1.cn_SQL.State != ConnectionState.Open)
					{
						Module1.cn_SQL.Open();
					}
					val6.CommandText = "Delete   from TABLE_INVENTAIRES_DETAILS    Where   ID_INV = '" + Text_ID_INV.Text + "' ";
					val6.Connection = Module1.cn_SQL;
					val6.ExecuteNonQuery();
					int num6 = DataGrid_BODY.Rows.Count - 1;
					int num7 = 0;
					while (true)
					{
						int num8 = num7;
						int num5 = num6;
						if (num8 > num5)
						{
							break;
						}
						val6.CommandText = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(string.Concat(string.Concat("INSERT  INTO   TABLE_INVENTAIRES_DETAILS              ( Dates,ID_INV ,N_INV ,ID_ARTICLE, Code, Article , PRIX_A, STOCK_LOGIQUE, STOCK_PHYSIQUE, ECART , VALEUR , ETAT  )      values           ('" + Strings.Format(Conversions.ToDate(DateTimePicker_DATE.Text), "yyyy-MM-dd"), "' ,'"), Text_ID_INV.Text), "' ,  ' '  ,'"), DataGrid_BODY.Rows[num7].Cells["ID_ARTICLE"].Value), "','"), DataGrid_BODY.Rows[num7].Cells["Code"].Value), "' ,'"), DataGrid_BODY.Rows[num7].Cells["Article"].Value), "' ,'"), Module1.FLOUSS(Conversions.ToDecimal(DataGrid_BODY.Rows[num7].Cells["Prix_A"].Value))), "','"), Module1.FLOUSS(Conversions.ToDecimal(DataGrid_BODY.Rows[num7].Cells["STOCK_LOGIQUE"].Value))), "' ,'"), Module1.FLOUSS(Conversions.ToDecimal(DataGrid_BODY.Rows[num7].Cells["STOCK_PHYSIQUE"].Value))), "' ,'"), Module1.FLOUSS(Conversions.ToDecimal(DataGrid_BODY.Rows[num7].Cells["ECART"].Value))), "' ,'"), Module1.FLOUSS(Conversions.ToDecimal(DataGrid_BODY.Rows[num7].Cells["VALEUR"].Value))), "',   'ENREGISTRER'  )   "));
						val6.Connection = Module1.cn_SQL;
						val6.ExecuteNonQuery();
						num7++;
					}
					Module1.cn_SQL.Close();
					MessageBox.Show("Modifié avec succès", "ok", (MessageBoxButtons)0, (MessageBoxIcon)64, (MessageBoxDefaultButton)0);
					string right = Conversions.ToString(Operators.ConcatenateObject("MODIFICATION | ", DataGridView1.Rows[((DataGridViewBand)DataGridView1.CurrentRow).Index].Cells["ID_INV"].Value));
					File.AppendAllText(Application.StartupPath + "\\log.sni", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(Strings.Format(DateTime.Now, "ddMMyy HHmmss fff") + MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text, " | "), Module1._USERNAME), " | "), ((Control)this).Name), " | "), NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null)), " | "), right), "\r\n")), Encoding.UTF8);
				}
				((Control)Panel_INFO).Hide();
				DA = new MySqlDataAdapter("select * from     TABLE_" + Label_TABLE.Text + "             order by       ID      DESC", Module1.cn_SQL);
				DT = new DataTable();
				DT.Clear();
				((DbDataAdapter)(object)DA).Fill(DT);
				DataGridView1.DataSource = DT;
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
					string text2 = Strings.Format(DateTime.Now, "yyMMddHHmmssfff");
					Bitmap val7 = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, (PixelFormat)2498570);
					Graphics val8 = Graphics.FromImage((Image)(object)val7);
					val8.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, (CopyPixelOperation)13369376);
					((Image)val7).Save(Application.StartupPath + "\\tchak\\" + text2 + ".snidb", ImageFormat.Jpeg);
					val7 = null;
					string right2 = "ERROR | ";
					File.AppendAllText(Application.StartupPath + "\\log_erreur.sni", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(text2 + " | ", MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text), " | "), Module1._USERNAME), " | "), ((Control)this).Name), " | "), NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null)), " | "), right2), " | "), ex2.ToString()), "\r\n"), "Ligne : "), fileLineNumber), "\r\n"), "\r\n"), "##########################################################################################################"), "\r\n")), Encoding.UTF8);
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

	private void Button20_Click(object sender, EventArgs e)
	{
		try
		{
			((Control)Panel_INFO).Visible = true;
			((Control)Panel_INFO).BringToFront();
			Label_INDEX.Text = "-";
			Label_TOP.Text = "NOUVEAU";
			DataGrid_BODY.Columns["sup"].Visible = true;
			((Control)Button_SAVE).Visible = true;
			Text_ID.Text = "";
			Text_ID_INV.Text = "";
			DateTimePicker_DATE.Text = Conversions.ToString(DateTime.Now.Date);
			Text_UTILISATEUR.Text = Module1._USERNAME;
			Text_CODE_FIND.Text = "";
			Text_ARTICLE_FIND.Text = "";
			Text_CODE.Text = "";
			Text_ARTICLE.Text = "";
			Text_NOTES.Text = "";
			DataGrid_BODY.Rows.Clear();
			Text_ETAT.Text = "EN COURS";
			Button_CALC_DOC_Click(RuntimeHelpers.GetObjectValue(sender), e);
			((Control)Text_ARTICLE_FIND).Focus();
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

	private void DataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
	{
		Label_TOTAL_LIGNES_BD.Text = Conversions.ToString(Conversions.ToDouble(DataGridView1.CurrentCell.RowIndex.ToString()) + 1.0) + "/" + Conversions.ToString(DataGridView1.Rows.Count);
	}

	private void DataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
	{
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected Obj, but got Unknown
		int try0001_dispatch = -1;
		int num3 = default;
		int num = default;
		int num2 = default;
		int num5 = default;
		Font font = default;
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
					goto IL_000a;
				case 440:
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
							goto IL_000a;
						case 3:
							goto IL_0027;
						case 4:
							goto IL_0060;
						case 6:
							goto IL_009e;
						case 7:
							goto IL_00a2;
						case 5:
						case 8:
						case 9:
							goto IL_00d6;
						case 10:
							goto IL_00eb;
						case 11:
							goto IL_0121;
						case 12:
							goto IL_0155;
						default:
							goto end_IL_0001;
						case 13:
							goto end_IL_0001_2;
						}
						goto default;
					}
					IL_00eb:
					num2 = 10;
					DataGridView1.Rows[num5].Cells["ETAT"].Style.Font = new Font(font, (FontStyle)1);
					goto IL_0121;
					IL_0121:
					num2 = 11;
					DataGridView1.Rows[num5].Cells["ETAT"].Style.ForeColor = Color.White;
					goto IL_0155;
					IL_00d6:
					num2 = 9;
					font = DataGridView1.DefaultCellStyle.Font;
					goto IL_00eb;
					IL_0155:
					num2 = 12;
					num5 = checked(num5 + 1);
					goto IL_015e;
					IL_000a:
					num2 = 2;
					num6 = checked(DataGridView1.Rows.Count - 1);
					num5 = 0;
					goto IL_015e;
					IL_015e:
					num7 = num5;
					num8 = num6;
					if (num7 > num8)
					{
						goto end_IL_0001_2;
					}
					goto IL_0027;
					IL_0027:
					num2 = 3;
					if (Operators.ConditionalCompareObjectEqual(DataGridView1.Rows[num5].Cells["ETAT"].Value, "VALIDER", TextCompare: false))
					{
						goto IL_0060;
					}
					goto IL_009e;
					IL_0060:
					num2 = 4;
					DataGridView1.Rows[num5].Cells["ETAT"].Style.BackColor = Color.FromArgb(22, 106, 238);
					goto IL_00d6;
					IL_009e:
					num2 = 6;
					goto IL_00a2;
					IL_00a2:
					num2 = 7;
					DataGridView1.Rows[num5].Cells["ETAT"].Style.BackColor = Color.Red;
					goto IL_00d6;
					end_IL_0001:
					break;
				}
			}
			catch (Exception ex) when ((num3 != 0) & (num == 0))
			{
				ProjectData.SetProjectError(ex);
				try0001_dispatch = 440;
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

	private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
	}

	private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		//IL_0b7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b83: Expected Obj, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Invalid comparison between Unknown and I4
		//IL_090d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0914: Expected Obj, but got Unknown
		//IL_0528: Unknown result type (might be due to invalid IL or missing references)
		//IL_052f: Expected Obj, but got Unknown
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Expected Obj, but got Unknown
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Expected Obj, but got Unknown
		try
		{
			if (Operators.ConditionalCompareObjectEqual(e.ColumnIndex, Operators.SubtractObject(NewLateBinding.LateGet(sender, null, "ColumnCount", new object[0], null, null, null), 3), TextCompare: false))
			{
				((Control)Panel_INFO).Hide();
				if (Operators.ConditionalCompareObjectEqual(DataGridView1.Rows[((DataGridViewBand)DataGridView1.CurrentRow).Index].Cells["ETAT"].Value, "VALIDER", TextCompare: false))
				{
					return;
				}
				if ((int)MessageBox.Show("Voulez-vous vraiment Supprimer ??", "Annulation", (MessageBoxButtons)1, (MessageBoxIcon)32, (MessageBoxDefaultButton)0) == 1)
				{
					string right = Conversions.ToString(Operators.ConcatenateObject("SUPPRESION | ", DataGridView1.Rows[((DataGridViewBand)DataGridView1.CurrentRow).Index].Cells[2].Value));
					File.AppendAllText(Application.StartupPath + "\\log.sni", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(Strings.Format(DateTime.Now, "ddMMyy HHmmss fff") + MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text, " | "), Module1._USERNAME), " | "), ((Control)this).Name), " | "), NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null)), " | "), right), "\r\n")), Encoding.UTF8);
					MySqlCommand val = new MySqlCommand();
					if (Module1.cn_SQL.State != ConnectionState.Open)
					{
						Module1.cn_SQL.Open();
					}
					val.CommandText = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("Delete   from     TABLE_INVENTAIRES_DETAILS      WHERE    ID_INV =  '", DataGridView1.Rows[((DataGridViewBand)DataGridView1.CurrentRow).Index].Cells["ID_INV"].Value), "'         "));
					val.Connection = Module1.cn_SQL;
					val.ExecuteNonQuery();
					Module1.cn_SQL.Close();
					int position = ((ContainerControl)this).BindingContext[(object)DT].Position;
					DT.Rows[position].Delete();
					MySqlCommandBuilder val2 = new MySqlCommandBuilder(DA);
					((DbDataAdapter)(object)DA).Update(DT);
					DT.AcceptChanges();
					((ContainerControl)this).BindingContext[(object)DT].Position = position;
					Button_CALC_BD_Click(RuntimeHelpers.GetObjectValue(sender), (EventArgs)(object)e);
				}
			}
			if (Operators.ConditionalCompareObjectEqual(e.ColumnIndex, Operators.SubtractObject(NewLateBinding.LateGet(sender, null, "ColumnCount", new object[0], null, null, null), 2), TextCompare: false))
			{
				if (Operators.ConditionalCompareObjectEqual(DataGridView1.Rows[((DataGridViewBand)DataGridView1.CurrentRow).Index].Cells["ETAT"].Value, "VALIDER", TextCompare: false))
				{
					((Control)Panel_INFO).Visible = false;
					return;
				}
				((Control)Panel_INFO).Visible = true;
				((Control)Panel_INFO).BringToFront();
				Label_INDEX.Text = Conversions.ToString(((DataGridViewBand)DataGridView1.CurrentRow).Index);
				Label_TOP.Text = "MODIFICATION";
				DataGrid_BODY.Columns["sup"].Visible = true;
				((Control)Button_SAVE).Visible = true;
				int position2 = ((ContainerControl)this).BindingContext[(object)DT].Position;
				Text_ID.Text = DT.Rows[position2]["ID"].ToString();
				Text_ID_INV.Text = DT.Rows[position2]["ID_INV"].ToString();
				DateTimePicker_DATE.Text = DT.Rows[position2]["DATES"].ToString();
				Text_UTILISATEUR.Text = DT.Rows[position2]["UTILISATEUR"].ToString();
				Label_TOTAL_VALEUR_DOC.Text = Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(DT.Rows[position2]["TOTAL_VALEUR"].ToString())));
				Text_NOTES.Text = DT.Rows[position2]["NOTES"].ToString();
				Text_ETAT.Text = DT.Rows[position2]["ETAT"].ToString();
				MySqlCommand val3 = new MySqlCommand();
				if (Module1.cn_SQL.State != ConnectionState.Open)
				{
					Module1.cn_SQL.Open();
				}
				val3.CommandText = "select     *      from    TABLE_INVENTAIRES_DETAILS      WHERE     ID_INV  = '" + Text_ID_INV.Text + "' ";
				val3.Connection = Module1.cn_SQL;
				MySqlDataReader val4 = val3.ExecuteReader();
				DataGrid_BODY.DataSource = null;
				DataGrid_BODY.Rows.Clear();
				if (val4.HasRows)
				{
					while (val4.Read())
					{
						DataGrid_BODY.Rows.Add(new object[8]
						{
							val4["ID_ARTICLE"].ToString(),
							val4["Code"].ToString(),
							val4["Article"].ToString(),
							Module1.FLOUSS(Conversions.ToDecimal(val4["PRIX_A"].ToString())),
							Module1.FLOUSS(Conversions.ToDecimal(val4["STOCK_LOGIQUE"].ToString())),
							Module1.FLOUSS(Conversions.ToDecimal(val4["STOCK_PHYSIQUE"].ToString())),
							Module1.FLOUSS(Conversions.ToDecimal(val4["ECART"].ToString())),
							Module1.FLOUSS(Conversions.ToDecimal(val4["VALEUR"].ToString()))
						});
					}
				}
				Module1.cn_SQL.Close();
				Button_CALC_DOC_Click(RuntimeHelpers.GetObjectValue(sender), (EventArgs)(object)e);
			}
			if (!Operators.ConditionalCompareObjectEqual(e.ColumnIndex, Operators.SubtractObject(NewLateBinding.LateGet(sender, null, "ColumnCount", new object[0], null, null, null), 1), TextCompare: false))
			{
				return;
			}
			((Control)Panel_INFO).Visible = true;
			((Control)Panel_INFO).BringToFront();
			Label_INDEX.Text = Conversions.ToString(((DataGridViewBand)DataGridView1.CurrentRow).Index);
			Label_TOP.Text = "CONSULTATION";
			DataGrid_BODY.Columns["sup"].Visible = false;
			((Control)Button_SAVE).Visible = false;
			int position3 = ((ContainerControl)this).BindingContext[(object)DT].Position;
			Text_ID.Text = DT.Rows[position3]["ID"].ToString();
			Text_ID_INV.Text = DT.Rows[position3]["ID_INV"].ToString();
			DateTimePicker_DATE.Text = DT.Rows[position3]["DATES"].ToString();
			Text_UTILISATEUR.Text = DT.Rows[position3]["UTILISATEUR"].ToString();
			Label_TOTAL_VALEUR_DOC.Text = Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(DT.Rows[position3]["TOTAL_VALEUR"].ToString())));
			Text_NOTES.Text = DT.Rows[position3]["NOTES"].ToString();
			Text_ETAT.Text = DT.Rows[position3]["ETAT"].ToString();
			MySqlCommand val5 = new MySqlCommand();
			if (Module1.cn_SQL.State != ConnectionState.Open)
			{
				Module1.cn_SQL.Open();
			}
			val5.CommandText = "select     *      from    TABLE_INVENTAIRES_DETAILS      WHERE     ID_INV  = '" + Text_ID_INV.Text + "' ";
			val5.Connection = Module1.cn_SQL;
			MySqlDataReader val6 = val5.ExecuteReader();
			DataGrid_BODY.DataSource = null;
			DataGrid_BODY.Rows.Clear();
			if (val6.HasRows)
			{
				while (val6.Read())
				{
					DataGrid_BODY.Rows.Add(new object[8]
					{
						val6["ID_ARTICLE"].ToString(),
						val6["Code"].ToString(),
						val6["Article"].ToString(),
						Module1.FLOUSS(Conversions.ToDecimal(val6["PRIX_A"].ToString())),
						Module1.FLOUSS(Conversions.ToDecimal(val6["STOCK_LOGIQUE"].ToString())),
						Module1.FLOUSS(Conversions.ToDecimal(val6["STOCK_PHYSIQUE"].ToString())),
						Module1.FLOUSS(Conversions.ToDecimal(val6["ECART"].ToString())),
						Module1.FLOUSS(Conversions.ToDecimal(val6["VALEUR"].ToString()))
					});
				}
			}
			Module1.cn_SQL.Close();
			Button_CALC_DOC_Click(RuntimeHelpers.GetObjectValue(sender), (EventArgs)(object)e);
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
				Bitmap val7 = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, (PixelFormat)2498570);
				Graphics val8 = Graphics.FromImage((Image)(object)val7);
				val8.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, (CopyPixelOperation)13369376);
				((Image)val7).Save(Application.StartupPath + "\\tchak\\" + text + ".snidb", ImageFormat.Jpeg);
				val7 = null;
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

	private void TextBox14_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Invalid comparison between Unknown and I4
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected Obj, but got Unknown
		try
		{
			if ((int)e.KeyCode == 13)
			{
				Button_FIND.PerformClick();
				((TextBoxBase)Text_CODE_FIND).HideSelection = false;
				((TextBoxBase)Text_CODE_FIND).SelectAll();
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

	private void Button_FIND_Click(object sender, EventArgs e)
	{
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Expected Obj, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected Obj, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected Obj, but got Unknown
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (Operators.CompareString(Text_CODE_FIND.Text.Trim(), "", TextCompare: false) != 0)
			{
				DataTable dataTable = new DataTable();
				MySqlDataAdapter val = new MySqlDataAdapter();
				dataTable.Clear();
				val = new MySqlDataAdapter("select      ID_ARTICLE,Code,Article,STOCK,Prix_A,UNITE         from TABLE_ARTICLES WHERE Code =  '" + Text_CODE_FIND.Text + "'    ", Module1.cn_SQL);
				((DbDataAdapter)(object)val).Fill(dataTable);
				if (dataTable.Rows.Count != 0)
				{
					Text_ID_ARTICLE.Text = dataTable.Rows[0]["ID_ARTICLE"].ToString();
					Text_CODE.Text = dataTable.Rows[0]["Code"].ToString();
					Text_ARTICLE.Text = dataTable.Rows[0]["Article"].ToString();
					Text_STOCK_ACTUEL.Text = dataTable.Rows[0]["STOCK"].ToString();
					Text_PRIX_A.Text = dataTable.Rows[0]["Prix_A"].ToString();
					Text_UNITE.Text = dataTable.Rows[0]["UNITE"].ToString();
					Text_QTE.Text = "";
					((Control)Text_QTE).Focus();
				}
				else
				{
					MessageBox.Show("Article inconnu", "Erreur", (MessageBoxButtons)0, (MessageBoxIcon)64, (MessageBoxDefaultButton)0);
					Text_ID_ARTICLE.Text = "";
					Text_CODE.Text = "";
					Text_ARTICLE.Text = "";
					Text_STOCK_ACTUEL.Text = "";
					Text_PRIX_A.Text = "";
					Text_UNITE.Text = "";
					Text_QTE.Text = "";
					Text_CODE_FIND.Text = "";
					Text_ARTICLE_FIND.Text = "";
					((Control)Text_CODE_FIND).Focus();
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

	private void Button_FIND_GotFocus(object sender, EventArgs e)
	{
		((Control)Text_CODE_FIND).Focus();
	}

	private void Button_CLOSE_Click(object sender, EventArgs e)
	{
		((Control)Panel_INFO).Hide();
	}

	private void DataGrid_BODY_CellValidated(object sender, DataGridViewCellEventArgs e)
	{
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Expected Obj, but got Unknown
		try
		{
			DataGrid_BODY.Rows[((DataGridViewBand)DataGrid_BODY.CurrentRow).Index].Cells["ECART"].Value = Module1.FLOUSS(Conversions.ToDecimal(Operators.SubtractObject(DataGrid_BODY.Rows[((DataGridViewBand)DataGrid_BODY.CurrentRow).Index].Cells["STOCK_PHYSIQUE"].Value, DataGrid_BODY.Rows[((DataGridViewBand)DataGrid_BODY.CurrentRow).Index].Cells["STOCK_LOGIQUE"].Value)));
			DataGrid_BODY.Rows[((DataGridViewBand)DataGrid_BODY.CurrentRow).Index].Cells["VALEUR"].Value = Module1.FLOUSS(Conversions.ToDecimal(Operators.MultiplyObject(DataGrid_BODY.Rows[((DataGridViewBand)DataGrid_BODY.CurrentRow).Index].Cells["ECART"].Value, DataGrid_BODY.Rows[((DataGridViewBand)DataGrid_BODY.CurrentRow).Index].Cells["Prix_A"].Value)));
			Button_CALC_DOC_Click(RuntimeHelpers.GetObjectValue(sender), (EventArgs)(object)e);
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

	private void DataGrid_BODY_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected Obj, but got Unknown
		if (DataGrid_BODY.CurrentCell.ColumnIndex == 5)
		{
			((Control)(TextBox)e.Control).KeyPress += TextBox_keyPress;
		}
	}

	private void TextBox_keyPress(object sender, KeyPressEventArgs e)
	{
		if (((Operators.CompareString(Conversions.ToString(e.KeyChar), "0", TextCompare: false) < 0) | (Operators.CompareString(Conversions.ToString(e.KeyChar), "9", TextCompare: false) > 0)) & (e.KeyChar != '\b') & (e.KeyChar != '.') & (e.KeyChar != '-'))
		{
			e.Handled = true;
		}
	}

	private void DataGrid_BODY_CellEnter(object sender, DataGridViewCellEventArgs e)
	{
		Label_TOTAL_LIGNES.Text = Conversions.ToString(Conversions.ToDouble(DataGrid_BODY.CurrentCell.RowIndex.ToString()) + 1.0) + "/" + Conversions.ToString(DataGrid_BODY.Rows.Count);
	}

	private void DataGrid_BODY_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected Obj, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Invalid comparison between Unknown and I4
		try
		{
			if (((Operators.ConditionalCompareObjectEqual(e.ColumnIndex, Operators.SubtractObject(NewLateBinding.LateGet(sender, null, "ColumnCount", new object[0], null, null, null), 1), TextCompare: false) && e.RowIndex >= 0) ? true : false) && (int)MessageBox.Show("Voulez-vous vraiment supprimer ??", "Suppression", (MessageBoxButtons)1, (MessageBoxIcon)32, (MessageBoxDefaultButton)0) == 1)
			{
				DataGrid_BODY.Rows.RemoveAt(DataGrid_BODY.CurrentCell.RowIndex);
				Button_CALC_DOC_Click(RuntimeHelpers.GetObjectValue(sender), (EventArgs)(object)e);
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

	private void Button2_Click(object sender, EventArgs e)
	{
		((Control)Panel_FONCTIONS).Hide();
		if (((Control)Panel_INV_MASSE).Visible)
		{
			((Control)Panel_INV_MASSE).Hide();
			return;
		}
		((Control)Panel_INV_MASSE).Show();
		((Control)Panel_INV_MASSE).BringToFront();
		checked
		{
			((Control)Panel_INV_MASSE).Left = (int)Math.Round((double)((Control)this).Width / 2.0 - (double)((Control)Panel_INV_MASSE).Width / 2.0);
			((Control)Panel_INV_MASSE).Top = (int)Math.Round((double)((Control)this).Height / 2.0 - (double)((Control)Panel_INV_MASSE).Height / 2.0);
		}
	}

	private void Button_FERMER_Click(object sender, EventArgs e)
	{
		((Control)Panel_INV_MASSE).Hide();
	}

	private void Button5_Click(object sender, EventArgs e)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Invalid comparison between Unknown and I4
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Expected Obj, but got Unknown
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Expected Obj, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected Obj, but got Unknown
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected Obj, but got Unknown
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		if ((int)MessageBox.Show("Voulez-vous lancer l'inventaire des stocks ?", "Attention", (MessageBoxButtons)4, (MessageBoxIcon)32, (MessageBoxDefaultButton)0) == 6)
		{
			string right = "Remise à zéro du stock | " + ListBox1.Text;
			File.AppendAllText(Application.StartupPath + "\\log.sni", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(Strings.Format(DateTime.Now, "ddMMyy HHmmss fff") + MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text, " | "), Module1._USERNAME), " | "), ((Control)this).Name), " | "), NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null)), " | "), right), "\r\n")), Encoding.UTF8);
			if (Operators.CompareString(ListBox1.Text, "TOUT", TextCompare: false) == 0)
			{
				DataTable dataTable = new DataTable();
				MySqlDataAdapter val = new MySqlDataAdapter();
				dataTable.Clear();
				dataTable = new DataTable();
				val = new MySqlDataAdapter("UPDATE     TABLE_ARTICLES    SET STOCK =  0 , DATE_INVENTAIRE =  '" + DateTime.Now.Date.ToString("yyyy-MM-dd") + "'  ,STOCK_INITIAL =  0      ", Module1.cn_SQL);
				((DbDataAdapter)(object)val).Fill(dataTable);
			}
			else
			{
				DataTable dataTable2 = new DataTable();
				MySqlDataAdapter val2 = new MySqlDataAdapter();
				dataTable2.Clear();
				dataTable2 = new DataTable();
				val2 = new MySqlDataAdapter("UPDATE     TABLE_ARTICLES    SET STOCK =  0 , DATE_INVENTAIRE =  '" + DateTime.Now.Date.ToString("yyyy-MM-dd") + "'  ,STOCK_INITIAL =  0    WHERE Famille = '" + ListBox1.Text + "'       ", Module1.cn_SQL);
				((DbDataAdapter)(object)val2).Fill(dataTable2);
			}
			MessageBox.Show("Modifié avec succès", "ok", (MessageBoxButtons)0, (MessageBoxIcon)64, (MessageBoxDefaultButton)0);
			((Control)Panel_INV_MASSE).Hide();
		}
	}

	private void Button_ETAT_INVENTAIRE_Click(object sender, EventArgs e)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		((Control)Panel_FONCTIONS).Hide();
		((Form)MyProject.Forms.FormDialog_ETAT_INVENTAIRE).ShowDialog();
	}

	private void Print_INV_PrintPage(object sender, PrintPageEventArgs e)
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
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected Obj, but got Unknown
		//IL_0130: Expected Obj, but got Unknown
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected Obj, but got Unknown
		//IL_016a: Expected Obj, but got Unknown
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected Obj, but got Unknown
		//IL_01a4: Expected Obj, but got Unknown
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected Obj, but got Unknown
		//IL_01de: Expected Obj, but got Unknown
		//IL_049c: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a3: Expected Obj, but got Unknown
		//IL_036b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0384: Unknown result type (might be due to invalid IL or missing references)
		//IL_038e: Expected Obj, but got Unknown
		//IL_038e: Expected Obj, but got Unknown
		//IL_03a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c4: Expected Obj, but got Unknown
		//IL_03c4: Expected Obj, but got Unknown
		//IL_03d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fb: Expected Obj, but got Unknown
		//IL_03fb: Expected Obj, but got Unknown
		checked
		{
			try
			{
				e.Graphics.FillRectangle((Brush)new SolidBrush(Color.Silver), 0, 0, 300, 15);
				string text = "INVENTAIRE";
				e.Graphics.DrawString(text, new Font("Lucida Console", 10f, (FontStyle)1), Brushes.Black, Convert.ToSingle(130f - e.Graphics.MeasureString(text, new Font("Lucida Console", 10f, (FontStyle)1)).Width / 2f), 0f, new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("NUM     :" + Text_ID_INV.Text, new Font("Lucida Console", 6.4f, (FontStyle)0), Brushes.Black, 0f, 85f, new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("Rapport :" + Strings.Format(DateTimePicker_DATE.Value, "yyyy-MM-ddy"), new Font("Lucida Console", 6.4f, (FontStyle)0), Brushes.Black, 0f, 95f, new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("-----------------------------------------", new Font("Lucida Console", 8f, (FontStyle)0), Brushes.Black, 0f, 100f, new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("Désignation          |Logique |Physique |  ", new Font("Lucida Console", 7f, (FontStyle)1), Brushes.Black, 0f, 110f, new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("-----------------------------------------", new Font("Lucida Console", 8f, (FontStyle)0), Brushes.Black, 0f, 120f, new StringFormat((StringFormatFlags)8192));
				int num = 0;
				string text2 = "";
				string text3 = "";
				string text4 = "";
				int num2 = DataGrid_BODY.RowCount - 1;
				num = 0;
				while (true)
				{
					int num3 = num;
					int num4 = num2;
					if (num3 > num4)
					{
						break;
					}
					text2 = text2 + Strings.LSet(DataGrid_BODY.Rows[num].Cells["Article"].Value.ToString(), 22) + "|" + Environment.NewLine + Environment.NewLine;
					text3 = text3 + Strings.RSet(DataGrid_BODY.Rows[num].Cells["Stock_Logique"].Value.ToString(), 8) + "|" + Environment.NewLine + Environment.NewLine;
					text4 = text4 + Strings.RSet(DataGrid_BODY.Rows[num].Cells["Stock_Physique"].Value.ToString(), 8) + "|" + Environment.NewLine + Environment.NewLine;
					num++;
				}
				e.Graphics.DrawString(text2, new Font("Lucida Console", 7f, (FontStyle)0), Brushes.Black, 0f, 130f, new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString(text3, new Font("Lucida Console", 7f, (FontStyle)0), Brushes.Black, 140f, 130f, new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString(text4, new Font("Lucida Console", 7f, (FontStyle)0), Brushes.Black, 190f, 130f, new StringFormat((StringFormatFlags)8192));
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
					string text5 = Strings.Format(DateTime.Now, "yyMMddHHmmssfff");
					Bitmap val = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, (PixelFormat)2498570);
					Graphics val2 = Graphics.FromImage((Image)(object)val);
					val2.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, (CopyPixelOperation)13369376);
					((Image)val).Save(Application.StartupPath + "\\tchak\\" + text5 + ".snidb", ImageFormat.Jpeg);
					val = null;
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
			Module1._QUITTER_PATIENTER = true;
		}
	}

	private void Button_VALIDER_Click(object sender, EventArgs e)
	{
		//IL_0533: Unknown result type (might be due to invalid IL or missing references)
		//IL_053d: Expected Obj, but got Unknown
		//IL_062e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0635: Expected Obj, but got Unknown
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Invalid comparison between Unknown and I4
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Expected Obj, but got Unknown
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Expected Obj, but got Unknown
		//IL_04a6: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			try
			{
				((Control)Button_VALIDER).Enabled = false;
				if (DataGridView1.Rows.Count == 0)
				{
					((Control)Button_VALIDER).Enabled = true;
					return;
				}
				if (Operators.ConditionalCompareObjectEqual(DataGridView1.Rows[((DataGridViewBand)DataGridView1.CurrentRow).Index].Cells["ETAT"].Value, "VALIDER", TextCompare: false))
				{
					((Control)Button_VALIDER).Enabled = true;
					return;
				}
				if (unchecked((int)MessageBox.Show(Conversions.ToString(Operators.ConcatenateObject("Voulez-vous vraiment Valider le Bon N° ", DataGridView1.Rows[((DataGridViewBand)DataGridView1.CurrentRow).Index].Cells["ID_INV"].Value)), "Attention", (MessageBoxButtons)1, (MessageBoxIcon)32, (MessageBoxDefaultButton)0)) == 1)
				{
					DataGridViewCellEventArgs e2 = new DataGridViewCellEventArgs(((DataGridViewBand)DataGridView1.Columns["cons"]).Index, DataGridView1.CurrentCell.RowIndex);
					DataGridView1_CellClick(DataGridView1, e2);
					MySqlCommand val = new MySqlCommand();
					if (Module1.cn_SQL.State != ConnectionState.Open)
					{
						Module1.cn_SQL.Open();
					}
					MySqlTransaction val2 = (val.Transaction = Module1.cn_SQL.BeginTransaction());
					try
					{
						int num = DataGrid_BODY.Rows.Count - 1;
						int num2 = 0;
						while (true)
						{
							int num3 = num2;
							int num4 = num;
							if (num3 > num4)
							{
								break;
							}
							val.CommandText = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat("UPDATE     TABLE_ARTICLES    SET STOCK =  " + Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(DataGrid_BODY.Rows[num2].Cells["Stock_Physique"].Value))), ", DATE_INVENTAIRE =  '"), Conversions.ToDate(DateTimePicker_DATE.Text).ToString("yyyy-MM-dd")), "'  ,STOCK_INITIAL =  "), Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(DataGrid_BODY.Rows[num2].Cells["Stock_Physique"].Value)))), "    WHERE       ID_ARTICLE = '"), DataGrid_BODY.Rows[num2].Cells["ID_ARTICLE"].Value), "'       "));
							val.Connection = Module1.cn_SQL;
							val.ExecuteNonQuery();
							val.CommandText = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(string.Concat(string.Concat("INSERT  INTO   TABLE_MOUVEMENTS_STOCK               ( DATES , HEURE , LIBELLE,ID_ARTICLE, CODE_ARTICLE, ARTICLE, QUANTITE)         values           ( '" + DateTime.Now.ToString("yyyy-MM-dd"), "' ,  '"), DateTime.Now.ToString("HH:mm:ss")), "'  ,  'Inventaire'    ,'"), DataGrid_BODY.Rows[num2].Cells["ID_ARTICLE"].Value), "' ,'"), DataGrid_BODY.Rows[num2].Cells["Code"].Value), "' ,'"), DataGrid_BODY.Rows[num2].Cells["Article"].Value), "'  ,'"), Module1.FLOUSS(Conversions.ToDecimal(DataGrid_BODY.Rows[num2].Cells["Stock_Physique"].Value))), "'       )        "));
							val.Connection = Module1.cn_SQL;
							val.ExecuteNonQuery();
							Application.DoEvents();
							Thread.Sleep(1);
							DataGrid_BODY.CurrentCell = DataGrid_BODY.Rows[num2].Cells[0];
							num2++;
						}
						val.CommandText = "UPDATE    TABLE_INVENTAIRES_ENTETE     SET  ETAT = 'VALIDER'        WHERE  ID_INV = '" + Text_ID_INV.Text + "'           ";
						val.Connection = Module1.cn_SQL;
						val.ExecuteNonQuery();
						val.CommandText = "UPDATE    TABLE_INVENTAIRES_DETAILS     SET  ETAT = 'VALIDER'        WHERE  ID_INV = '" + Text_ID_INV.Text + "'           ";
						val.Connection = Module1.cn_SQL;
						val.ExecuteNonQuery();
						val2.Commit();
						Module1.cn_SQL.Close();
						MessageBox.Show("Valider avec succès", "ok", (MessageBoxButtons)0, (MessageBoxIcon)64, (MessageBoxDefaultButton)0);
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception e3 = ex;
						StackTrace stackTrace = new StackTrace(e3, fNeedFileInfo: true);
						StackFrame frame = stackTrace.GetFrame(stackTrace.FrameCount - 1);
						int fileLineNumber = frame.GetFileLineNumber();
						val2.Rollback();
						Interaction.MsgBox("Transaction Erreur :" + Information.Err().Description);
						ProjectData.ClearProjectError();
					}
					((Control)Panel_INFO).Hide();
					DA = new MySqlDataAdapter("select * from     TABLE_" + Label_TABLE.Text + "             order by       ID      DESC", Module1.cn_SQL);
					DT = new DataTable();
					DT.Clear();
					((DbDataAdapter)(object)DA).Fill(DT);
					DataGridView1.DataSource = DT;
					Button_CALC_ENREGISTRER_Click(RuntimeHelpers.GetObjectValue(sender), e);
				}
				((Control)Button_VALIDER).Enabled = true;
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex3 = ex2;
				StackTrace stackTrace2 = new StackTrace(ex3, fNeedFileInfo: true);
				StackFrame frame2 = stackTrace2.GetFrame(stackTrace2.FrameCount - 1);
				int fileLineNumber2 = frame2.GetFileLineNumber();
				Interaction.MsgBox(ex3.Message + "\r\nLigne : " + Conversions.ToString(fileLineNumber2) + "\r\n");
				try
				{
					string text = Strings.Format(DateTime.Now, "yyMMddHHmmssfff");
					Bitmap val4 = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, (PixelFormat)2498570);
					Graphics val5 = Graphics.FromImage((Image)(object)val4);
					val5.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, (CopyPixelOperation)13369376);
					((Image)val4).Save(Application.StartupPath + "\\tchak\\" + text + ".snidb", ImageFormat.Jpeg);
					val4 = null;
					string right = "ERROR | ";
					File.AppendAllText(Application.StartupPath + "\\log_erreur.sni", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(text + " | ", MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text), " | "), Module1._USERNAME), " | "), ((Control)this).Name), " | "), NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null)), " | "), right), " | "), ex3.ToString()), "\r\n"), "Ligne : "), fileLineNumber2), "\r\n"), "\r\n"), "##########################################################################################################"), "\r\n")), Encoding.UTF8);
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

	private void Button_CALC_DOC_Click(object sender, EventArgs e)
	{
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected Obj, but got Unknown
		try
		{
			decimal num = ((IEnumerable)DataGrid_BODY.Rows).Cast<DataGridViewRow>().Sum([SpecialName] (DataGridViewRow row) => Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(row.Cells["VALEUR"].Value)) ? Convert.ToDecimal(RuntimeHelpers.GetObjectValue(row.Cells["VALEUR"].Value)) : 0m);
			Label_TOTAL_VALEUR_DOC.Text = Conversions.ToString(Module1.FLOUSS(num));
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

	private void Button1_Click(object sender, EventArgs e)
	{
		//IL_07bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c3: Expected Obj, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			try
			{
				if (Operators.CompareString(Text_ID_ARTICLE.Text, "", TextCompare: false) == 0)
				{
					MessageBox.Show("Veuillez remplir le champ -ID_ARTICLE- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
				if (Operators.CompareString(Text_CODE.Text, "", TextCompare: false) == 0)
				{
					MessageBox.Show("Veuillez remplir le champ -Code- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
				if (Operators.CompareString(Text_ARTICLE.Text, "", TextCompare: false) == 0)
				{
					MessageBox.Show("Veuillez remplir le champ -Article- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
				if (Operators.CompareString(Text_PRIX_A.Text, "", TextCompare: false) == 0)
				{
					MessageBox.Show("Veuillez remplir le champ -Prix_A- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
				if (Conversion.Val(Text_QTE.Text) < 0.0)
				{
					MessageBox.Show("Veuillez remplir le champ -Quantité- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
				if (Conversion.Val(Text_QTE.Text) > 9999.0)
				{
					MessageBox.Show("Erreur Qté", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
				string text = Text_ID_ARTICLE.Text;
				string text2 = Text_CODE.Text;
				string text3 = Text_ARTICLE.Text;
				decimal num = Module1.FLOUSS(Conversions.ToDecimal(Text_PRIX_A.Text));
				decimal num2 = Module1.FLOUSS(Conversions.ToDecimal(Text_STOCK_ACTUEL.Text));
				decimal num3 = Module1.FLOUSS(Conversions.ToDecimal(Text_QTE.Text));
				decimal num4 = Module1.FLOUSS(decimal.Subtract(Module1.FLOUSS(num3), Module1.FLOUSS(num2)));
				decimal num5 = Module1.FLOUSS(decimal.Multiply(Module1.FLOUSS(num4), Module1.FLOUSS(Conversions.ToDecimal(Text_PRIX_A.Text))));
				if (!Versioned.IsNumeric(num))
				{
					MessageBox.Show("Vérifier le champ -Prix_A- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
				if (!Versioned.IsNumeric(Text_QTE.Text))
				{
					MessageBox.Show("Vérifier le champ -QUANTITE- ", "Attention", (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
				int num6 = DataGrid_BODY.Rows.Count - 1;
				int num7 = 0;
				while (true)
				{
					int num8 = num7;
					int num9 = num6;
					if (num8 > num9)
					{
						break;
					}
					if (Operators.ConditionalCompareObjectEqual(DataGrid_BODY.Rows[num7].Cells["Code"].Value, Text_CODE.Text, TextCompare: false))
					{
						DataGrid_BODY.Rows[num7].Cells["Stock_Physique"].Value = decimal.Add(Module1.FLOUSS(Conversions.ToDecimal(DataGrid_BODY.Rows[num7].Cells["Stock_Physique"].Value)), Module1.FLOUSS(Conversions.ToDecimal(Text_QTE.Text)));
						DataGrid_BODY.Rows[num7].Cells["Ecart"].Value = Operators.SubtractObject(DataGrid_BODY.Rows[num7].Cells["Stock_Physique"].Value, DataGrid_BODY.Rows[num7].Cells["Stock_Logique"].Value);
						DataGrid_BODY.Rows[num7].Cells["Valeur"].Value = Operators.MultiplyObject(DataGrid_BODY.Rows[num7].Cells["Ecart"].Value, DataGrid_BODY.Rows[num7].Cells["Prix_A"].Value);
						DataGrid_BODY.CurrentCell = DataGrid_BODY.Rows[num7].Cells["Stock_Physique"];
						DataGrid_BODY.Rows[num7].Selected = true;
						DataGrid_BODY.BeginEdit(true);
						Button_CALC_DOC_Click(RuntimeHelpers.GetObjectValue(sender), e);
						DataGrid_BODY_CellValidated(null, null);
						Text_ID_ARTICLE.Text = "";
						Text_CODE.Text = "";
						Text_ARTICLE.Text = "";
						Text_PRIX_A.Text = "";
						Text_STOCK_ACTUEL.Text = "";
						Text_QTE.Text = "0";
						Text_CODE_FIND.Text = "";
						Text_ARTICLE_FIND.Text = "";
						((Control)Text_ARTICLE_FIND).Focus();
						return;
					}
					num7++;
				}
				DataGrid_BODY.Rows.Add(new object[8] { text, text2, text3, num, num2, num3, num4, num5 });
				Button_CALC_DOC_Click(RuntimeHelpers.GetObjectValue(sender), e);
				DataGrid_BODY_CellValidated(null, null);
				DataGrid_BODY.CurrentCell = DataGrid_BODY.Rows[DataGrid_BODY.Rows.Count - 1].Cells["Stock_Physique"];
				DataGrid_BODY.Rows[DataGrid_BODY.Rows.Count - 1].Selected = true;
				DataGrid_BODY.BeginEdit(true);
				Text_ID_ARTICLE.Text = "";
				Text_CODE.Text = "";
				Text_ARTICLE.Text = "";
				Text_PRIX_A.Text = "";
				Text_STOCK_ACTUEL.Text = "";
				Text_QTE.Text = "0";
				Text_CODE_FIND.Text = "";
				Text_ARTICLE_FIND.Text = "";
				((Control)Text_ARTICLE_FIND).Focus();
				DataGrid_BODY.CurrentCell = DataGrid_BODY.Rows[DataGrid_BODY.Rows.Count - 1].Cells[0];
				DataGrid_BODY.Rows[DataGrid_BODY.Rows.Count - 1].Selected = true;
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
					Bitmap val = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, (PixelFormat)2498570);
					Graphics val2 = Graphics.FromImage((Image)(object)val);
					val2.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, (CopyPixelOperation)13369376);
					((Image)val).Save(Application.StartupPath + "\\tchak\\" + text4 + ".snidb", ImageFormat.Jpeg);
					val = null;
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
			NewLateBinding.LateSet(sender, null, "Enabled", new object[1] { true }, null, null);
		}
	}

	private void Text_ARTICLE_FIND_TextChanged(object sender, EventArgs e)
	{
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected Obj, but got Unknown
		try
		{
			if (dt_ARTICLE_FIND.Rows.Count != 0)
			{
				DataView dataView = new DataView(dt_ARTICLE_FIND);
				dataView.RowFilter = "Article LIKE '%" + Text_ARTICLE_FIND.Text + "%'       or        Code LIKE '%" + Text_ARTICLE_FIND.Text + "%'";
				DataGridView_ARTICLES.DataSource = dataView;
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

	private void Text_ARTICLE_FIND_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Invalid comparison between Unknown and I4
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected Obj, but got Unknown
		try
		{
			if ((int)e.KeyCode == 13)
			{
				DataGridView_ARTICLES_CellClick(null, null);
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

	private void DataGridView_ARTICLES_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected Obj, but got Unknown
		try
		{
			if (DataGridView_ARTICLES.Rows.Count != 0)
			{
				Text_CODE_FIND.Text = Conversions.ToString(DataGridView_ARTICLES.Rows[((DataGridViewBand)DataGridView_ARTICLES.CurrentRow).Index].Cells[1].Value);
				Button_FIND.PerformClick();
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

	private void DataGridView_ARTICLES_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
	}

	private void Button_CALC_BD_Click(object sender, EventArgs e)
	{
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected Obj, but got Unknown
		decimal num = 0m;
		decimal num2 = 0m;
		if (Module1.cn_SQL.State != ConnectionState.Open)
		{
			Module1.cn_SQL.Open();
		}
		MySqlCommand val = new MySqlCommand("select sum(TOTAL_VALEUR) as n     from      TABLE_" + Label_TABLE.Text + "     ", Module1.cn_SQL);
		num = ((val.ExecuteScalar() != DBNull.Value) ? Conversions.ToDecimal(val.ExecuteScalar()) : 0m);
		Module1.cn_SQL.Close();
		Label_TOTAL_NET_ACHATS_BD.Text = Conversions.ToString(Module1.FLOUSS(num));
		Button_CALC_ENREGISTRER_Click(RuntimeHelpers.GetObjectValue(sender), e);
	}

	private void Button6_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected Obj, but got Unknown
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Invalid comparison between Unknown and I4
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Expected Obj, but got Unknown
		try
		{
			OpenFileDialog val = new OpenFileDialog();
			((FileDialog)val).Filter = "Text Files (*.csv)|*.csv";
			if ((int)((CommonDialog)val).ShowDialog() == 1)
			{
				DataGrid_BODY.Rows.Clear();
				string text = "";
				StreamReader streamReader = new StreamReader(Strings.Trim(((FileDialog)val).FileName), Encoding.Default);
				while (streamReader.Peek() != -1)
				{
					text = streamReader.ReadLine();
					string[] array = Strings.Split(text, ";");
					DataGrid_BODY.Rows.Add((object[])array);
				}
				streamReader.Close();
				DataGrid_BODY.Rows.RemoveAt(0);
			}
			Button_CALC_DOC_Click(RuntimeHelpers.GetObjectValue(sender), e);
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
				Bitmap val2 = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, (PixelFormat)2498570);
				Graphics val3 = Graphics.FromImage((Image)(object)val2);
				val3.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, (CopyPixelOperation)13369376);
				((Image)val2).Save(Application.StartupPath + "\\tchak\\" + text2 + ".snidb", ImageFormat.Jpeg);
				val2 = null;
				string right = "ERROR | ";
				File.AppendAllText(Application.StartupPath + "\\log_erreur.sni", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(text2 + " | ", MyProject.Forms.Form_0_TEMPLATE.Label_POSTE.Text), " | "), Module1._USERNAME), " | "), ((Control)this).Name), " | "), NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null)), " | "), right), " | "), ex2.ToString()), "\r\n"), "Ligne : "), fileLineNumber), "\r\n"), "\r\n"), "##########################################################################################################"), "\r\n")), Encoding.UTF8);
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

	private void Button23_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected Obj, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Invalid comparison between Unknown and I4
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Expected Obj, but got Unknown
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			try
			{
				SaveFileDialog val = new SaveFileDialog();
				((FileDialog)val).Filter = "Text Files (*.csv)|*.csv";
				((FileDialog)val).FileName = "INVENTAIRE_" + DateTime.Now.ToString("dd-MM-yyy HH-mm-ss");
				if (unchecked((int)((CommonDialog)val).ShowDialog()) != 1)
				{
					return;
				}
				string separator = ";";
				StringBuilder stringBuilder = new StringBuilder();
				int num = DataGrid_BODY.Rows.Count - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					string[] array = new string[((BaseCollection)DataGrid_BODY.Columns).Count - 2 + 1];
					if (num2.Equals(0))
					{
						int num5 = ((BaseCollection)DataGrid_BODY.Columns).Count - 2;
						int num6 = 0;
						while (true)
						{
							int num7 = num6;
							num4 = num5;
							if (num7 > num4)
							{
								break;
							}
							array[num6] = DataGrid_BODY.Columns[num6].HeaderText;
							num6++;
						}
						stringBuilder.AppendLine(string.Join(separator, array));
					}
					int num8 = ((BaseCollection)DataGrid_BODY.Columns).Count - 2;
					int num9 = 0;
					while (true)
					{
						int num10 = num9;
						num4 = num8;
						if (num10 > num4)
						{
							break;
						}
						if (!DataGrid_BODY.Rows[num2].IsNewRow)
						{
							array[num9] = DataGrid_BODY[num9, num2].Value.ToString();
						}
						num9++;
					}
					if (!DataGrid_BODY.Rows[num2].IsNewRow)
					{
						stringBuilder.AppendLine(string.Join(separator, array));
					}
					num2++;
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

	private void DataGridView_FAMILLES_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Expected Obj, but got Unknown
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected Obj, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected Obj, but got Unknown
		try
		{
			if (Operators.ConditionalCompareObjectEqual(DataGridView_FAMILLES.Rows[((DataGridViewBand)DataGridView_FAMILLES.CurrentRow).Index].Cells[0].Value, "TOUT", TextCompare: false))
			{
				dt_ARTICLE_FIND.Clear();
				da_ARTICLE_FIND = new MySqlDataAdapter("select    ID_ARTICLE,Code,Article    from   TABLE_ARTICLES     ", Module1.cn_SQL);
				((DbDataAdapter)(object)da_ARTICLE_FIND).Fill(dt_ARTICLE_FIND);
			}
			else
			{
				dt_ARTICLE_FIND.Clear();
				da_ARTICLE_FIND = new MySqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select    ID_ARTICLE,Code,Article    from   TABLE_ARTICLES    Where   Famille = '", DataGridView_FAMILLES.Rows[((DataGridViewBand)DataGridView_FAMILLES.CurrentRow).Index].Cells[0].Value), "'  ")), Module1.cn_SQL);
				((DbDataAdapter)(object)da_ARTICLE_FIND).Fill(dt_ARTICLE_FIND);
			}
			DataGridView_ARTICLES.AutoGenerateColumns = false;
			DataGridView_ARTICLES.DataSource = dt_ARTICLE_FIND;
			DataGridView_ARTICLES.Columns[1].DefaultCellStyle.WrapMode = (DataGridViewTriState)1;
			DataGridView_ARTICLES.AutoSizeRowsMode = (DataGridViewAutoSizeRowsMode)7;
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

	private void DataGridView_FAMILLES_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
	}

	private void TabControl1_Click(object sender, EventArgs e)
	{
		if (TabControl1.SelectedIndex == 1)
		{
			DataGridView_FAMILLES.ClearSelection();
			((Control)Text_CODE_FIND).Focus();
		}
	}

	private void Button_CALC_ENREGISTRER_Click(object sender, EventArgs e)
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected Obj, but got Unknown
		if (Module1.cn_SQL.State != ConnectionState.Open)
		{
			Module1.cn_SQL.Open();
		}
		MySqlCommand val = new MySqlCommand("select Count(ID) as n     from      TABLE_" + Label_TABLE.Text + "    WHERE    ETAT = 'ENREGISTRER'    ", Module1.cn_SQL);
		int num = ((val.ExecuteScalar() != DBNull.Value) ? Conversions.ToInteger(val.ExecuteScalar()) : 0);
		Module1.cn_SQL.Close();
		if (num == 0)
		{
			TextBox33398.Text = "";
			((Control)Panel7727).Visible = false;
		}
		else
		{
			TextBox33398.Text = "Il y a " + Conversions.ToString(num) + " documents non validé";
			((Control)Panel7727).Visible = true;
			((Control)Panel7727).BringToFront();
		}
	}

	private void Button7_Click(object sender, EventArgs e)
	{
		((Control)Panel_FONCTIONS).Visible = false;
	}

	private void Button_RAPPORT_Click(object sender, EventArgs e)
	{
		((Control)Panel7).Hide();
		if (((Control)Panel7).Visible)
		{
			((Control)Panel7).Hide();
			return;
		}
		((Control)Panel7).Show();
		((Control)Panel7).BringToFront();
		checked
		{
			((Control)Panel7).Left = (int)Math.Round((double)((Control)this).Width / 2.0 - (double)((Control)Panel7).Width / 2.0);
			((Control)Panel7).Top = (int)Math.Round((double)((Control)this).Height / 2.0 - (double)((Control)Panel7).Height / 2.0);
		}
	}

	private void Button8_Click(object sender, EventArgs e)
	{
		((Control)Panel7).Hide();
	}

	private void Button3_Click(object sender, EventArgs e)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected Obj, but got Unknown
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected Obj, but got Unknown
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected Obj, but got Unknown
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected Obj, but got Unknown
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected Obj, but got Unknown
		//IL_02de: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Expected Obj, but got Unknown
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
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
				if (Operators.CompareString(ListBox2.Text, "TOUT", TextCompare: false) == 0)
				{
					dataTable.Clear();
					val = new MySqlDataAdapter("select    DISTINCT    Famille    from    TABLE_ARTICLES       ", Module1.cn_SQL);
					((DbDataAdapter)(object)val).Fill(dataTable);
				}
				else
				{
					dataTable.Clear();
					val = new MySqlDataAdapter("select    DISTINCT    Famille    from    TABLE_ARTICLES     Where   Famille = '" + ListBox2.Text + "'     ", Module1.cn_SQL);
					((DbDataAdapter)(object)val).Fill(dataTable);
				}
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
					val2 = new MySqlDataAdapter("select  Code, Article , STOCK     from   TABLE_ARTICLES            Where   Famille = '" + Strings.Trim(dataTable.Rows[num2]["Famille"].ToString()) + "'           order by Article      ", Module1.cn_SQL);
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
						DataGridView2.Rows.Add(new object[1] { "  CODE : " + dataTable2.Rows[num6]["Code"].ToString() });
						DataGridView2.Rows.Add(new object[2]
						{
							"  " + dataTable2.Rows[num6]["Article"].ToString(),
							Strings.FormatNumber(Conversion.Val(dataTable2.Rows[num6]["STOCK"].ToString()))
						});
						num6++;
					}
					DataGridView2.Rows.Add(new object[3] { "", "", "" });
					num2++;
				}
				PrintPreviewDialog val3 = new PrintPreviewDialog();
				val3.Document = Print_INV_PRE;
				val3.PrintPreviewControl.Zoom = 2.0;
				((Form)val3).WindowState = (FormWindowState)2;
				((Form)val3).ShowDialog();
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
				ProjectData.ClearProjectError();
			}
		}
	}

	private void Print_INV_PRE_PrintPage(object sender, PrintPageEventArgs e)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected Obj, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected Obj, but got Unknown
		//IL_008d: Expected Obj, but got Unknown
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected Obj, but got Unknown
		//IL_00e9: Expected Obj, but got Unknown
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected Obj, but got Unknown
		//IL_0123: Expected Obj, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Expected Obj, but got Unknown
		//IL_015d: Expected Obj, but got Unknown
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected Obj, but got Unknown
		//IL_0197: Expected Obj, but got Unknown
		//IL_03f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ff: Expected Obj, but got Unknown
		//IL_0318: Unknown result type (might be due to invalid IL or missing references)
		//IL_0337: Unknown result type (might be due to invalid IL or missing references)
		//IL_0341: Expected Obj, but got Unknown
		//IL_0341: Expected Obj, but got Unknown
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Expected Obj, but got Unknown
		//IL_0262: Expected Obj, but got Unknown
		checked
		{
			try
			{
				e.Graphics.FillRectangle((Brush)new SolidBrush(Color.Black), 0, 0, 260, 20);
				string text = "PRE-INVENTAIRE";
				e.Graphics.DrawString(text, new Font("Inconsolata Condensed", 13f, (FontStyle)1), Brushes.White, Convert.ToSingle(130f - e.Graphics.MeasureString(text, new Font("Inconsolata Condensed", 13f, (FontStyle)1)).Width / 2f), 0f, new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("Rapport :" + Strings.Format(DateTime.Now.Date, "yyyy-MM-ddy"), new Font("Inconsolata Condensed", 10f, (FontStyle)1), Brushes.Black, 0f, 80f, new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("-----------------------------------------", new Font("Inconsolata Condensed", 11f, (FontStyle)0), Brushes.Black, 0f, 100f, new StringFormat((StringFormatFlags)8192));
				e.Graphics.DrawString("Désignation          |Logique |Physique |  ", new Font("Inconsolata Condensed", 11f, (FontStyle)1), Brushes.Black, 0f, 110f, new StringFormat((StringFormatFlags)8192));
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
						text2 = Strings.LSet(Conversions.ToString(DataGridView2.Rows[num3].Cells["COL_1"].Value), 24) + Strings.RSet(Conversions.ToString(DataGridView2.Rows[num3].Cells["COL_2"].Value), 6) + " " + Strings.RSet(Conversions.ToString(DataGridView2.Rows[num3].Cells["COL_3"].Value), 12);
						e.Graphics.DrawString(text2, new Font("Inconsolata Condensed", 10f, (FontStyle)1), Brushes.Black, 0f, (float)(120 + num * 16 + 10), new StringFormat((StringFormatFlags)8192));
					}
					num++;
					num3++;
				}
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
			Module1._QUITTER_PATIENTER = true;
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
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected Obj, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Invalid comparison between Unknown and I4
		try
		{
			if (DataGridView1.Rows.Count != 0)
			{
				Button_PRINT_A4_Click(RuntimeHelpers.GetObjectValue(sender), e);
				((Control)MyProject.Forms.Report_INVENTAIRE).Visible = false;
				byte[] array = ((Report)MyProject.Forms.Report_INVENTAIRE.ReportViewer1.LocalReport).Render("PDF");
				SaveFileDialog val = new SaveFileDialog();
				((FileDialog)val).Filter = "*PDF files (*.pdf)|*.pdf";
				((FileDialog)val).FileName = "INV_" + Text_ID_INV.Text + "_" + DateTime.Now.ToString("dd-MM-yyy HH-mm");
				if ((int)((CommonDialog)val).ShowDialog() == 1)
				{
					FileStream fileStream = new FileStream(((FileDialog)val).FileName, FileMode.Create);
					fileStream.Write(array, 0, array.Length);
					fileStream.Close();
				}
				((Form)MyProject.Forms.Report_INVENTAIRE).Close();
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

	private void Button_EXCEL_Click(object sender, EventArgs e)
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected Obj, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Invalid comparison between Unknown and I4
		try
		{
			if (DataGridView1.Rows.Count != 0)
			{
				Button_PRINT_A4_Click(RuntimeHelpers.GetObjectValue(sender), e);
				((Control)MyProject.Forms.Report_INVENTAIRE).Visible = false;
				byte[] array = ((Report)MyProject.Forms.Report_INVENTAIRE.ReportViewer1.LocalReport).Render("EXCEL");
				SaveFileDialog val = new SaveFileDialog();
				((FileDialog)val).Filter = "*EXCEL files (*.xls)|*.xls";
				((FileDialog)val).FileName = "INV_" + Text_ID_INV.Text + "_" + DateTime.Now.ToString("dd-MM-yyy HH-mm");
				if ((int)((CommonDialog)val).ShowDialog() == 1)
				{
					FileStream fileStream = new FileStream(((FileDialog)val).FileName, FileMode.Create);
					fileStream.Write(array, 0, array.Length);
					fileStream.Close();
				}
				((Form)MyProject.Forms.Report_INVENTAIRE).Close();
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

	private void Button_WORD_Click(object sender, EventArgs e)
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected Obj, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Invalid comparison between Unknown and I4
		try
		{
			if (DataGridView1.Rows.Count != 0)
			{
				Button_PRINT_A4_Click(RuntimeHelpers.GetObjectValue(sender), e);
				((Control)MyProject.Forms.Report_INVENTAIRE).Visible = false;
				byte[] array = ((Report)MyProject.Forms.Report_INVENTAIRE.ReportViewer1.LocalReport).Render("WORD");
				SaveFileDialog val = new SaveFileDialog();
				((FileDialog)val).Filter = "*WORD files (*.doc)|*.doc";
				((FileDialog)val).FileName = "INV_" + Text_ID_INV.Text + "_" + DateTime.Now.ToString("dd-MM-yyy HH-mm");
				if ((int)((CommonDialog)val).ShowDialog() == 1)
				{
					FileStream fileStream = new FileStream(((FileDialog)val).FileName, FileMode.Create);
					fileStream.Write(array, 0, array.Length);
					fileStream.Close();
				}
				((Form)MyProject.Forms.Report_INVENTAIRE).Close();
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

	private void Button_PrintRapport_Click(object sender, EventArgs e)
	{
		if (DataGridView1.Rows.Count != 0)
		{
			NewLateBinding.LateSet(sender, null, "visible", new object[1] { false }, null, null);
			((Control)Button_PRINT_80MM).Visible = true;
			((Control)Button_PRINT_A4).Visible = true;
		}
	}

	private void Button_PRINT_80MM_Click(object sender, EventArgs e)
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected Obj, but got Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected Obj, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected Obj, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
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
						Exception e3 = ex3;
						StackTrace stackTrace2 = new StackTrace(e3, fNeedFileInfo: true);
						StackFrame frame2 = stackTrace2.GetFrame(stackTrace2.FrameCount - 1);
						int fileLineNumber2 = frame2.GetFileLineNumber();
						ProjectData.ClearProjectError();
					}
					Thread.Sleep(100);
				});
				thread.SetApartmentState(ApartmentState.STA);
				thread.IsBackground = true;
				thread.Start();
				DataGridViewCellEventArgs e2 = new DataGridViewCellEventArgs(((DataGridViewBand)DataGridView1.Columns["cons"]).Index, DataGridView1.CurrentCell.RowIndex);
				DataGridView1_CellClick(DataGridView1, e2);
				int num = DataGrid_BODY.Rows.Count * 20 + 20 + 200;
				Print_INV.DefaultPageSettings.PaperSize = new PaperSize("Custom", 264, num);
				PrintPreviewDialog val = new PrintPreviewDialog();
				val.Document = Print_INV;
				val.PrintPreviewControl.Zoom = 2.0;
				((Form)val).WindowState = (FormWindowState)2;
				((Form)val).ShowDialog();
				Module1._QUITTER_PATIENTER = true;
				((Control)Button_PrintRapport).Visible = true;
				((Control)Button_PRINT_80MM).Visible = false;
				((Control)Button_PRINT_A4).Visible = false;
				((Control)Panel_INFO).Hide();
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

	private void Button_PRINT_A4_Click(object sender, EventArgs e)
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected Obj, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected Obj, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected Obj, but got Unknown
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected Obj, but got Unknown
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected Obj, but got Unknown
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected Obj, but got Unknown
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d4: Expected Obj, but got Unknown
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
						Exception e3 = ex3;
						StackTrace stackTrace2 = new StackTrace(e3, fNeedFileInfo: true);
						StackFrame frame2 = stackTrace2.GetFrame(stackTrace2.FrameCount - 1);
						int fileLineNumber2 = frame2.GetFileLineNumber();
						ProjectData.ClearProjectError();
					}
					Thread.Sleep(100);
				});
				thread.SetApartmentState(ApartmentState.STA);
				thread.IsBackground = true;
				thread.Start();
				DataGridViewCellEventArgs e2 = new DataGridViewCellEventArgs(((DataGridViewBand)DataGridView1.Columns["cons"]).Index, DataGridView1.CurrentCell.RowIndex);
				DataGridView1_CellClick(DataGridView1, e2);
				((Report)MyProject.Forms.Report_INVENTAIRE.ReportViewer1.LocalReport).SetParameters(new ReportParameter("NUM", Text_ID_INV.Text));
				((Report)MyProject.Forms.Report_INVENTAIRE.ReportViewer1.LocalReport).SetParameters(new ReportParameter("DATES", DateTimePicker_DATE.Text));
				((Report)MyProject.Forms.Report_INVENTAIRE.ReportViewer1.LocalReport).SetParameters(new ReportParameter("ETAT", Text_ETAT.Text));
				((Report)MyProject.Forms.Report_INVENTAIRE.ReportViewer1.LocalReport).SetParameters(new ReportParameter("TOTAL_VALEUR", Conversions.ToString(Module1.FLOUSS(Conversions.ToDecimal(Label_TOTAL_VALEUR_DOC.Text)))));
				((Report)MyProject.Forms.Report_INVENTAIRE.ReportViewer1.LocalReport).SetParameters(new ReportParameter("ID_DOCUMENT", Text_ID_INV.Text));
				DataTable dataTable = new DataTable();
				int num = ((BaseCollection)DataGrid_BODY.Columns).Count - 2;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					dataTable.Columns.Add(DataGrid_BODY.Columns[num2].Name.ToString());
					dataTable.Columns[DataGrid_BODY.Columns[num2].Name.ToString()].Caption = DataGrid_BODY.Columns[num2].HeaderText.ToString();
					num2++;
				}
				int num5 = DataGrid_BODY.Rows.Count - 1;
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
					int num7 = ((BaseCollection)DataGrid_BODY.Columns).Count - 2;
					int num8 = 0;
					while (true)
					{
						int num9 = num8;
						num4 = num7;
						if (num9 > num4)
						{
							break;
						}
						dataTable.Rows[y][num8] = DataGrid_BODY.Rows[y].Cells[num8].Value.ToString();
						num8++;
					}
					y++;
				}
				ReportDataSource item = new ReportDataSource("DataSet1", dataTable);
				((Collection<ReportDataSource>)(object)MyProject.Forms.Report_INVENTAIRE.ReportViewer1.LocalReport.DataSources).Clear();
				((Collection<ReportDataSource>)(object)MyProject.Forms.Report_INVENTAIRE.ReportViewer1.LocalReport.DataSources).Add(item);
				MyProject.Forms.Report_INVENTAIRE.ReportViewer1.RefreshReport();
				MyProject.Forms.Report_INVENTAIRE.ReportViewer1.SetDisplayMode((DisplayMode)1);
				MyProject.Forms.Report_INVENTAIRE.ReportViewer1.ZoomMode = (ZoomMode)2;
				MyProject.Forms.Report_INVENTAIRE.ReportViewer1.ZoomPercent = 25;
				((Control)MyProject.Forms.Report_INVENTAIRE).Show();
				Module1._QUITTER_PATIENTER = true;
				((Control)Button_PrintRapport).Visible = true;
				((Control)Button_PRINT_80MM).Visible = false;
				((Control)Button_PRINT_A4).Visible = false;
				((Control)Panel_INFO).Hide();
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

	private void Button_SPLITE_Click(object sender, EventArgs e)
	{
		if (((Control)Button_SPLITE).Top == 304)
		{
			((Control)Button_SPLITE).Top = 65;
			((Control)TabControl1).Height = 36;
			((Control)DataGrid_BODY).Top = 90;
			((Control)DataGrid_BODY).Height = 386;
			((Control)Text_FIND_BODY).Top = 63;
			((Control)PictureBox2323).Top = 63;
		}
		else
		{
			((Control)Button_SPLITE).Top = 304;
			((Control)TabControl1).Height = 274;
			((Control)DataGrid_BODY).Top = 328;
			((Control)DataGrid_BODY).Height = 148;
			((Control)Text_FIND_BODY).Top = 302;
			((Control)PictureBox2323).Top = 302;
		}
	}

	private void PictureBox2323_Click(object sender, EventArgs e)
	{
		checked
		{
			if (!DataGrid_BODY.RowHeadersVisible)
			{
				DataGrid_BODY.RowHeadersVisible = true;
				int num = DataGrid_BODY.RowCount - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 <= num4)
					{
						((DataGridViewCell)DataGrid_BODY.Rows[num2].HeaderCell).Value = Conversion.Val(num2 + 1).ToString("00");
						num2++;
						continue;
					}
					break;
				}
			}
			else
			{
				DataGrid_BODY.RowHeadersVisible = false;
			}
		}
	}

	private void Text_CODE_FIND_TextChanged(object sender, EventArgs e)
	{
	}

	private void TextBox_GotFocus(object sender, EventArgs e)
	{
		NewLateBinding.LateSet(sender, null, "BackColor", new object[1] { Color.Yellow }, null, null);
	}

	private void TextBox_LostFocus(object sender, EventArgs e)
	{
		NewLateBinding.LateSet(sender, null, "BackColor", new object[1] { Color.White }, null, null);
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

	private void Text_FIND_BODY__TextChanged(object sender, EventArgs e)
	{
		DataGrid_BODY.ClearSelection();
		checked
		{
			int num = DataGrid_BODY.RowCount - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 <= num4)
				{
					if (DataGrid_BODY.Rows[num2].Cells["Article"].Value.ToString().StartsWith(Conversions.ToString(NewLateBinding.LateGet(sender, null, "Text", new object[0], null, null, null)), StringComparison.OrdinalIgnoreCase))
					{
						DataGrid_BODY.Rows[num2].Selected = true;
						DataGrid_BODY.CurrentCell = DataGrid_BODY.Rows[num2].Cells[0];
						DataGrid_BODY.Rows[DataGrid_BODY.CurrentCell.RowIndex].Selected = true;
					}
					num2++;
					continue;
				}
				break;
			}
		}
	}

	private void Butt_Click(object sender, EventArgs e)
	{
		Text_QTE.Text = Conversions.ToString(Operators.AddObject(Text_QTE.Text, NewLateBinding.LateGet(sender, null, "text", new object[0], null, null, null)));
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
					break;
				case 90:
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
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 3:
							goto end_IL_0001_3;
						}
						goto default;
					}
					end_IL_0001_2:
					break;
				}
				num2 = 2;
				Text_QTE.Text = Text_QTE.Text.Remove(checked(Text_QTE.Text.Length - 1));
				break;
				end_IL_0001:;
			}
			catch (Exception ex) when ((num3 != 0) & (num == 0))
			{
				ProjectData.SetProjectError(ex);
				try0001_dispatch = 90;
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

	private void Button_CLAVIER_NOSELECT1_Click(object sender, EventArgs e)
	{
		try
		{
			((Control)Panel_CLAVIER).Visible = false;
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

	private void Button_NUMERIQUE_Click(object sender, EventArgs e)
	{
		if (!((Control)Panel_CLAVIER).Visible)
		{
			((Control)Panel_CLAVIER).Visible = true;
			((Control)Panel_CLAVIER).BringToFront();
			((Control)Panel_CLAVIER).Top = 234;
			((Control)Panel_CLAVIER).Left = 554;
		}
		else
		{
			((Control)Panel_CLAVIER).Visible = false;
		}
	}

	private void Button_PLUS_Click(object sender, EventArgs e)
	{
		Text_QTE.Text = Conversions.ToString(Conversion.Val(Text_QTE.Text) + 1.0);
		if (Conversions.ToDouble(Text_QTE.Text) < 1.0)
		{
			Text_QTE.Text = Conversions.ToString(1);
		}
	}

	private void Button_MOINS_Click(object sender, EventArgs e)
	{
		Text_QTE.Text = Conversions.ToString(Conversion.Val(Text_QTE.Text) - 1.0);
		if (Conversions.ToDouble(Text_QTE.Text) < 1.0)
		{
			Text_QTE.Text = Conversions.ToString(1);
		}
	}

	private void Text_QTE_TextChanged(object sender, EventArgs e)
	{
	}

	private void Text_QTE_Click(object sender, EventArgs e)
	{
		if (!((Control)Panel_CLAVIER).Visible)
		{
			((Control)Panel_CLAVIER).Visible = true;
			((Control)Panel_CLAVIER).BringToFront();
			((Control)Panel_CLAVIER).Top = 234;
			((Control)Panel_CLAVIER).Left = 554;
		}
		else
		{
			((Control)Panel_CLAVIER).Visible = false;
		}
	}

	private void Text_QTE_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (((Operators.CompareString(Conversions.ToString(e.KeyChar), "0", TextCompare: false) < 0) | (Operators.CompareString(Conversions.ToString(e.KeyChar), "9", TextCompare: false) > 0)) & (e.KeyChar != '\b') & (e.KeyChar != '.') & (e.KeyChar != '-'))
		{
			e.Handled = true;
		}
	}

	private void Text_QTE_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Invalid comparison between Unknown and I4
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected Obj, but got Unknown
		try
		{
			if ((int)e.KeyCode == 13)
			{
				Button1.PerformClick();
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
